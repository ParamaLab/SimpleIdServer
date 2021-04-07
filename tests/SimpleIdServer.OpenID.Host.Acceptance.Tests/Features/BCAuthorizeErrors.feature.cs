﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.OpenID.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class BCAuthorizeErrorsFeature : object, Xunit.IClassFixture<BCAuthorizeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "BCAuthorizeErrors.feature"
#line hidden
        
        public BCAuthorizeErrorsFeature(BCAuthorizeErrorsFeature.FixtureData fixtureData, SimpleIdServer_OpenID_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "BCAuthorizeErrors", "\tCheck errors returned by /mtls/bc-authorize endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when hint is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "BCAuthorizeErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when hint is missing")]
        public virtual void ErrorIsReturnedWhenHintIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when hint is missing", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table174 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table174.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 5
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table174, "When ");
#line hidden
                TechTalk.SpecFlow.Table table175 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table175.AddRow(new string[] {
                            "token_endpoint_auth_method",
                            "tls_client_auth"});
                table175.AddRow(new string[] {
                            "response_types",
                            "[token]"});
                table175.AddRow(new string[] {
                            "grant_types",
                            "[client_credentials]"});
                table175.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table175.AddRow(new string[] {
                            "redirect_uris",
                            "[http://localhost:8080]"});
                table175.AddRow(new string[] {
                            "tls_client_auth_san_dns",
                            "firstMtlsClient"});
#line 9
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/register\'", ((string)(null)), table175, "And ");
#line hidden
#line 18
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table176 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table176.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table176.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table176.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table176.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 21
 testRunner.And("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table176, "And ");
#line hidden
                TechTalk.SpecFlow.Table table177 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table177.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table177.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
#line 28
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/mtls/bc-authorize\'", ((string)(null)), table177, "And ");
#line hidden
#line 33
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.Then("JSON \'error_description\'=\'only one hint can be passed in the request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when scope is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "BCAuthorizeErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when scope is missing")]
        public virtual void ErrorIsReturnedWhenScopeIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when scope is missing", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table178 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table178.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 39
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table178, "When ");
#line hidden
                TechTalk.SpecFlow.Table table179 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table179.AddRow(new string[] {
                            "token_endpoint_auth_method",
                            "tls_client_auth"});
                table179.AddRow(new string[] {
                            "response_types",
                            "[token]"});
                table179.AddRow(new string[] {
                            "grant_types",
                            "[client_credentials]"});
                table179.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table179.AddRow(new string[] {
                            "redirect_uris",
                            "[http://localhost:8080]"});
                table179.AddRow(new string[] {
                            "tls_client_auth_san_dns",
                            "firstMtlsClient"});
#line 43
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/register\'", ((string)(null)), table179, "And ");
#line hidden
#line 52
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table180 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table180.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table180.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table180.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table180.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 55
 testRunner.And("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table180, "And ");
#line hidden
                TechTalk.SpecFlow.Table table181 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table181.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table181.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table181.AddRow(new string[] {
                            "id_token_hint",
                            "idtokenhint"});
#line 62
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/mtls/bc-authorize\'", ((string)(null)), table181, "And ");
#line hidden
#line 68
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.Then("JSON \'error_description\'=\'missing parameter scope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when scope is not valid")]
        [Xunit.TraitAttribute("FeatureTitle", "BCAuthorizeErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when scope is not valid")]
        public virtual void ErrorIsReturnedWhenScopeIsNotValid()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when scope is not valid", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 73
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table182 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table182.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 74
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table182, "When ");
#line hidden
                TechTalk.SpecFlow.Table table183 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table183.AddRow(new string[] {
                            "token_endpoint_auth_method",
                            "tls_client_auth"});
                table183.AddRow(new string[] {
                            "response_types",
                            "[token]"});
                table183.AddRow(new string[] {
                            "grant_types",
                            "[client_credentials]"});
                table183.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table183.AddRow(new string[] {
                            "redirect_uris",
                            "[http://localhost:8080]"});
                table183.AddRow(new string[] {
                            "tls_client_auth_san_dns",
                            "firstMtlsClient"});
#line 78
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/register\'", ((string)(null)), table183, "And ");
#line hidden
#line 87
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table184 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table184.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table184.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table184.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table184.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 90
 testRunner.And("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table184, "And ");
#line hidden
                TechTalk.SpecFlow.Table table185 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table185.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table185.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table185.AddRow(new string[] {
                            "id_token_hint",
                            "idtokenhint"});
                table185.AddRow(new string[] {
                            "scope",
                            "scope2"});
#line 97
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/mtls/bc-authorize\'", ((string)(null)), table185, "And ");
#line hidden
#line 104
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.Then("JSON \'error\'=\'invalid_scope\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 107
 testRunner.Then("JSON \'error_description\'=\'invalid scopes : scope2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when client_notification_token is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "BCAuthorizeErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when client_notification_token is missing")]
        public virtual void ErrorIsReturnedWhenClient_Notification_TokenIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when client_notification_token is missing", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 109
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table186 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table186.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 110
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table186, "When ");
#line hidden
                TechTalk.SpecFlow.Table table187 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table187.AddRow(new string[] {
                            "token_endpoint_auth_method",
                            "tls_client_auth"});
                table187.AddRow(new string[] {
                            "response_types",
                            "[token]"});
                table187.AddRow(new string[] {
                            "grant_types",
                            "[client_credentials]"});
                table187.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table187.AddRow(new string[] {
                            "redirect_uris",
                            "[http://localhost:8080]"});
                table187.AddRow(new string[] {
                            "tls_client_auth_san_dns",
                            "firstMtlsClient"});
#line 114
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/register\'", ((string)(null)), table187, "And ");
#line hidden
#line 123
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table188 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table188.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table188.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table188.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table188.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 126
 testRunner.And("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table188, "And ");
#line hidden
                TechTalk.SpecFlow.Table table189 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table189.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table189.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table189.AddRow(new string[] {
                            "id_token_hint",
                            "idtokenhint"});
                table189.AddRow(new string[] {
                            "scope",
                            "scope1"});
#line 133
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/mtls/bc-authorize\'", ((string)(null)), table189, "And ");
#line hidden
#line 140
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 142
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 143
 testRunner.Then("JSON \'error_description\'=\'missing parameter client_notification_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when client_notification_token is < 128 bits")]
        [Xunit.TraitAttribute("FeatureTitle", "BCAuthorizeErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when client_notification_token is < 128 bits")]
        public virtual void ErrorIsReturnedWhenClient_Notification_TokenIs128Bits()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when client_notification_token is < 128 bits", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 145
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table190 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table190.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 146
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table190, "When ");
#line hidden
                TechTalk.SpecFlow.Table table191 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table191.AddRow(new string[] {
                            "token_endpoint_auth_method",
                            "tls_client_auth"});
                table191.AddRow(new string[] {
                            "response_types",
                            "[token]"});
                table191.AddRow(new string[] {
                            "grant_types",
                            "[client_credentials]"});
                table191.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table191.AddRow(new string[] {
                            "redirect_uris",
                            "[http://localhost:8080]"});
                table191.AddRow(new string[] {
                            "tls_client_auth_san_dns",
                            "firstMtlsClient"});
#line 150
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/register\'", ((string)(null)), table191, "And ");
#line hidden
#line 159
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 160
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table192 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table192.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table192.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table192.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table192.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 162
 testRunner.And("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table192, "And ");
#line hidden
                TechTalk.SpecFlow.Table table193 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table193.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table193.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table193.AddRow(new string[] {
                            "id_token_hint",
                            "idtokenhint"});
                table193.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table193.AddRow(new string[] {
                            "client_notification_token",
                            "1"});
#line 169
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/mtls/bc-authorize\'", ((string)(null)), table193, "And ");
#line hidden
#line 177
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 179
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 180
 testRunner.Then("JSON \'error_description\'=\'client_notification_token must contains at least 128 by" +
                        "tes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when id_token_hint is invalid")]
        [Xunit.TraitAttribute("FeatureTitle", "BCAuthorizeErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when id_token_hint is invalid")]
        public virtual void ErrorIsReturnedWhenId_Token_HintIsInvalid()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when id_token_hint is invalid", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 182
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table194 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Kid",
                            "AlgName"});
                table194.AddRow(new string[] {
                            "SIG",
                            "1",
                            "RS256"});
#line 183
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table194, "When ");
#line hidden
                TechTalk.SpecFlow.Table table195 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table195.AddRow(new string[] {
                            "token_endpoint_auth_method",
                            "tls_client_auth"});
                table195.AddRow(new string[] {
                            "response_types",
                            "[token]"});
                table195.AddRow(new string[] {
                            "grant_types",
                            "[client_credentials]"});
                table195.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table195.AddRow(new string[] {
                            "redirect_uris",
                            "[http://localhost:8080]"});
                table195.AddRow(new string[] {
                            "tls_client_auth_san_dns",
                            "firstMtlsClient"});
#line 187
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/register\'", ((string)(null)), table195, "And ");
#line hidden
#line 196
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 197
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table196 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table196.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table196.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table196.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table196.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 199
 testRunner.And("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table196, "And ");
#line hidden
                TechTalk.SpecFlow.Table table197 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table197.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "mtlsClient.crt"});
                table197.AddRow(new string[] {
                            "client_id",
                            "$client_id$"});
                table197.AddRow(new string[] {
                            "id_token_hint",
                            "idtokenhint"});
                table197.AddRow(new string[] {
                            "scope",
                            "scope1"});
                table197.AddRow(new string[] {
                            "client_notification_token",
                            "04bcf708-dfba-4719-a3d3-b213322e2c38"});
#line 206
 testRunner.And("execute HTTP POST JSON request \'https://localhost:8080/mtls/bc-authorize\'", ((string)(null)), table197, "And ");
#line hidden
#line 214
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 216
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 217
 testRunner.Then("JSON \'error_description\'=\'id_token_hint is invalid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                BCAuthorizeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                BCAuthorizeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion