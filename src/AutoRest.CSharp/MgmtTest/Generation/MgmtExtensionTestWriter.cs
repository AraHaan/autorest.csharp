﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Mgmt.Models;
using AutoRest.CSharp.Utilities;

namespace AutoRest.CSharp.MgmtTest.Generation
{
    /// <summary>
    /// Code writer for resource test.
    /// </summary>
    internal class MgmtExtensionTestWriter : MgmtBaseTestWriter
    {
        protected MgmtExtensions extensions;
        protected string TestNamespace => extensions.Type.Namespace + ".Tests.Mock";
        protected string TypeNameOfThis => extensions.Type.Name + "MockTests";

        protected string TestBaseName => $"MockTestBase";

        public MgmtExtensionTestWriter(CodeWriter writer, MgmtExtensions extensions, IEnumerable<string>? scenarioVariables = default) : base(writer, extensions, scenarioVariables)
        {
            this.extensions = extensions;
        }

        public override void Write()
        {
            WriteUsings(_writer);

            using (_writer.Namespace(TestNamespace))
            {
                _writer.WriteXmlDocumentationSummary($"Test for {extensions.ResourceName}");
                _writer.Append($"public partial class {TypeNameOfThis:D} : ");
                _writer.Line($"{TestBaseName}");
                using (_writer.Scope())
                {
                    WriteTesterCtors();
                    foreach (var clientOperation in extensions.ClientOperations)
                    {
                        _writer.Line();
                        WriteMethodTest(clientOperation, true, false);
                    }
                }
            }
        }

        protected void WriteUsings(CodeWriter writer)
        {
            writer.UseNamespace("System");
            writer.UseNamespace("System.Threading.Tasks");
            writer.UseNamespace("System.Net");
            writer.UseNamespace("System.Collections.Generic");
            writer.UseNamespace("Azure.Core.TestFramework");
            writer.UseNamespace("Azure.ResourceManager.TestFramework");
        }

        protected void WriteTesterCtors()
        {
            _writer.Line();
            using (_writer.Scope($"public {TypeNameOfThis}(bool isAsync): base(isAsync, RecordedTestMode.Record)"))
            {
                _writer.Line($"ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;");
                _writer.Line($"System.Environment.SetEnvironmentVariable(\"RESOURCE_MANAGER_URL\", $\"https://localhost:8443\");");
            }
        }

        protected void WriteMethodTest(MgmtClientOperation clientOperation, bool async, bool isLroOperation)
        {
            Debug.Assert(clientOperation != null);
            var methodName = clientOperation.Name;
            int exampleIdx = 0;
            foreach ((var branch, var operation) in GetSortedOperationMappings(clientOperation))
            {
                var exampleGroup = MgmtBaseTestWriter.FindExampleGroup(operation);
                if (exampleGroup is null || exampleGroup.Examples.Count() == 0)
                    return;

                foreach (var exampleModel in exampleGroup?.Examples ?? Enumerable.Empty<ExampleModel>())
                {
                    WriteTestDecorator();
                    var testCaseSuffix = exampleIdx > 0 ? (exampleIdx + 1).ToString() : String.Empty;
                    _writer.Append($"public {GetAsyncKeyword(async)} {MgmtBaseTestWriter.GetTaskOrVoid(async)} {methodName}{testCaseSuffix}()");
                    using (_writer.Scope())
                    {
                        _writer.LineRaw($"// Example: {exampleModel.Name}");
                        WriteOperationInvocation(clientOperation, operation, exampleModel, async, isLroOperation);
                    }
                    _writer.Line();
                    exampleIdx++;
                }
            }
        }

        public void WriteOperationInvocation(MgmtClientOperation clientOperation, MgmtRestOperation restOperation, ExampleModel exampleModel, bool async, bool isLroOperation)
        {
            var testMethodName = CreateMethodName(clientOperation.Name, async);
            var resourceIdentifierParams = ComposeResourceIdentifierParams(restOperation.RequestPath, exampleModel);
            var subscriptionVariableName = new CodeWriterDeclaration(extensions.Type.Name.FirstCharToLowerCase());
            var subscriptionRequestPath = GetSubscriptionRequestPath(restOperation.RequestPath.SerializedPath, exampleModel);
            _writer.Line($@"var {subscriptionVariableName:D} = GetArmClient().GetSubscription(new {typeof(Azure.Core.ResourceIdentifier)}({FormatResourceId(subscriptionRequestPath).RefScenariDefinedVariables(scenarioVariables)}));");
            List<KeyValuePair<string, FormattableString>> parameterValues = WriteOperationParameters(clientOperation.MethodParameters.ToArray().AsSpan().Slice(1).ToArray(), exampleModel);

            _writer.Line();
            WriteMethodTestInvocation(async, clientOperation, isLroOperation, $"{subscriptionVariableName}.{testMethodName}", parameterValues.Select(pv => pv.Value));
        }

        public string GetSubscriptionRequestPath(string requestPath, ExampleModel exampleModel)
        {
            List<string> result = new List<string>();
            var segements = requestPath.Split('/');
            int maxSegment = 3;
            int i = 0;
            foreach (string segment in segements)
            {
                if (segment.StartsWith("{") && segment.EndsWith("}"))
                {
                    var v = FindParameterValueByName(exampleModel, segment.Substring(1, segment.Length - 2));
                    if (v is null)
                    {
                        return "/subscriptions/00000000-0000-0000-0000-000000000000";
                    }
                    result.Add(v);
                }
                else
                {
                    result.Add(segment);
                }
                if (++i >= maxSegment)
                    break;
            }
            return String.Join("/", result.ToArray());
        }
    }
}
