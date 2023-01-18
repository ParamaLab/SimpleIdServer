﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AuthorizationCodeGrantTypeFeature : object, Xunit.IClassFixture<AuthorizationCodeGrantTypeFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AuthorizationCodeGrantType.feature"
#line hidden
        
        public AuthorizationCodeGrantTypeFeature(AuthorizationCodeGrantTypeFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "AuthorizationCodeGrantType", "\tCheck all the alternatives scenarios in code grant-type\t", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="resource parameter can be overridden and scopes \'admin\', \'calendar\' are returned")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantType")]
        [Xunit.TraitAttribute("Description", "resource parameter can be overridden and scopes \'admin\', \'calendar\' are returned")]
        public void ResourceParameterCanBeOverriddenAndScopesAdminCalendarAreReturned()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("resource parameter can be overridden and scopes \'admin\', \'calendar\' are returned", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table115 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table115.AddRow(new string[] {
                            "response_type",
                            "code"});
                table115.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table115.AddRow(new string[] {
                            "state",
                            "state"});
                table115.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table115.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table115.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table115.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
#line 6
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table115, "When ");
#line hidden
#line 16
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table116 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table116.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table116.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table116.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table116.AddRow(new string[] {
                            "code",
                            "$code$"});
                table116.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table116.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
                table116.AddRow(new string[] {
                            "resource",
                            "https://contacts.example.com"});
#line 18
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table116, "And ");
#line hidden
#line 28
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.And("JSON \'scope\'=\'admin calendar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("access_token audience contains \'https://cal.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("access_token audience contains \'https://contacts.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("access_token contains the claim \'scope\'=\'admin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("access_token contains the claim \'scope\'=\'calendar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="scope of a resource can be filtered")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantType")]
        [Xunit.TraitAttribute("Description", "scope of a resource can be filtered")]
        public void ScopeOfAResourceCanBeFiltered()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scope of a resource can be filtered", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 39
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table117 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table117.AddRow(new string[] {
                            "response_type",
                            "code"});
                table117.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table117.AddRow(new string[] {
                            "state",
                            "state"});
                table117.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table117.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table117.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table117.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
#line 40
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table117, "When ");
#line hidden
#line 50
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table118 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table118.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table118.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table118.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table118.AddRow(new string[] {
                            "code",
                            "$code$"});
                table118.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table118.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
                table118.AddRow(new string[] {
                            "resource",
                            "https://contacts.example.com"});
                table118.AddRow(new string[] {
                            "scope",
                            "admin"});
#line 52
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table118, "And ");
#line hidden
#line 63
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.And("access_token audience contains \'https://cal.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("access_token audience contains \'https://contacts.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("access_token contains the claim \'scope\'=\'admin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("access_token doesn\'t contain the claim \'scope\'=\'calendar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="scopes \'admin\', \'calendar\' are returned thanks to the original request")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantType")]
        [Xunit.TraitAttribute("Description", "scopes \'admin\', \'calendar\' are returned thanks to the original request")]
        public void ScopesAdminCalendarAreReturnedThanksToTheOriginalRequest()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scopes \'admin\', \'calendar\' are returned thanks to the original request", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 71
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 72
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table119 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table119.AddRow(new string[] {
                            "response_type",
                            "code"});
                table119.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table119.AddRow(new string[] {
                            "state",
                            "state"});
                table119.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table119.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table119.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table119.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
#line 73
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table119, "When ");
#line hidden
#line 83
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table120 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table120.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table120.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table120.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table120.AddRow(new string[] {
                            "code",
                            "$code$"});
                table120.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 85
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table120, "And ");
#line hidden
#line 93
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.Then("JSON \'scope\'=\'admin calendar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.And("access_token audience contains \'https://cal.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And("access_token contains the claim \'scope\'=\'admin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("access_token contains the claim \'scope\'=\'calendar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AuthorizationCodeGrantTypeFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AuthorizationCodeGrantTypeFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
