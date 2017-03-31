﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GPConnect.Provider.AcceptanceTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("OrganizationSearch")]
    [NUnit.Framework.CategoryAttribute("Organization")]
    public partial class OrganizationSearchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "OrganizationSearch.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "OrganizationSearch", null, ProgrammingLanguage.CSharp, new string[] {
                        "Organization"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 5
 testRunner.Given("I have the test ods codes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search success")]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-organization-code", "unknownORG", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-organization-code", "ORG1", "1", new string[0])]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-organization-code", "ORG2", "2", new string[0])]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-organization-code", "ORG3", "1", new string[0])]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-site-code", "unknownSIT", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-site-code", "SIT1", "1", new string[0])]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-site-code", "SIT2", "1", new string[0])]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-site-code", "SIT3", "2", new string[0])]
        public virtual void OrganizationSearchSuccess(string system, string value, string expectedSize, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search success", exampleTags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 8
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.And(string.Format("I add the organization identifier parameter with system \"{0}\" and value \"{1}\"", system, value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
  testRunner.And(string.Format("response bundle should contain \"{0}\" entries", expectedSize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search by organization code success single result contains correct f" +
            "ields")]
        public virtual void OrganizationSearchByOrganizationCodeSuccessSingleResultContainsCorrectFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search by organization code success single result contains correct f" +
                    "ields", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 27
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
  testRunner.And("I add the organization identifier parameter with system \"http://fhir.nhs.net/Id/o" +
                    "ds-organization-code\" and value \"ORG1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
  testRunner.And("the JSON value \"resourceType\" should be \"Bundle\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
  testRunner.And("the JSON value \"type\" should be \"searchset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
  testRunner.And("response bundle should contain \"1\" entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
  testRunner.And("response bundle entry \"Organization\" should contain element \"fullUrl\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
  testRunner.And("response bundle entry \"Organization\" should contain element \"resource.meta.versio" +
                    "nId\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
  testRunner.And("response bundle entry \"Organization\" should contain element \"resource.meta.profil" +
                    "e[0]\" with value \"http://fhir.nhs.net/StructureDefinition/gpconnect-organization" +
                    "-1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
  testRunner.And("response should contain ods-organization-codes \"ORG1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
  testRunner.And("response should contain ods-site-codes \"SIT1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search by organization code success multiple results contains correc" +
            "t fields")]
        public virtual void OrganizationSearchByOrganizationCodeSuccessMultipleResultsContainsCorrectFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search by organization code success multiple results contains correc" +
                    "t fields", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 43
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
  testRunner.And("I add the organization identifier parameter with system \"http://fhir.nhs.net/Id/o" +
                    "ds-organization-code\" and value \"ORG2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
  testRunner.And("the JSON value \"resourceType\" should be \"Bundle\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
  testRunner.And("the JSON value \"type\" should be \"searchset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
  testRunner.And("response bundle should contain \"2\" entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
  testRunner.And("response bundle \"Organization\" entries should contain element \"fullUrl\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
  testRunner.And("response bundle \"Organization\" entries should contain element \"resource.meta.vers" +
                    "ionId\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
  testRunner.And("response bundle \"Organization\" entries should contain element \"resource.meta.prof" +
                    "ile[0]\" with value \"http://fhir.nhs.net/StructureDefinition/gpconnect-organizati" +
                    "on-1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
  testRunner.And("response should contain ods-organization-codes \"ORG2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
  testRunner.And("response should contain ods-site-codes \"SIT2|SIT3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search by site code success single result contains correct fields")]
        public virtual void OrganizationSearchBySiteCodeSuccessSingleResultContainsCorrectFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search by site code success single result contains correct fields", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 59
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
  testRunner.And("I add the organization identifier parameter with system \"http://fhir.nhs.net/Id/o" +
                    "ds-site-code\" and value \"SIT1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
  testRunner.And("the JSON value \"resourceType\" should be \"Bundle\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
  testRunner.And("the JSON value \"type\" should be \"searchset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
  testRunner.And("response bundle should contain \"1\" entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
  testRunner.And("response bundle entry \"Organization\" should contain element \"fullUrl\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
  testRunner.And("response bundle entry \"Organization\" should contain element \"resource.meta.versio" +
                    "nId\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
  testRunner.And("response bundle entry \"Organization\" should contain element \"resource.meta.profil" +
                    "e[0]\" with value \"http://fhir.nhs.net/StructureDefinition/gpconnect-organization" +
                    "-1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
  testRunner.And("response should contain ods-organization-codes \"ORG1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
  testRunner.And("response should contain ods-site-codes \"SIT1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search by site code success multiple results contains correct fields" +
            "")]
        public virtual void OrganizationSearchBySiteCodeSuccessMultipleResultsContainsCorrectFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search by site code success multiple results contains correct fields" +
                    "", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 75
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
  testRunner.And("I add the organization identifier parameter with system \"http://fhir.nhs.net/Id/o" +
                    "ds-site-code\" and value \"SIT3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
  testRunner.And("the JSON value \"resourceType\" should be \"Bundle\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
  testRunner.And("the JSON value \"type\" should be \"searchset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
  testRunner.And("response bundle should contain \"2\" entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
  testRunner.And("response bundle \"Organization\" entries should contain element \"fullUrl\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
  testRunner.And("response bundle \"Organization\" entries should contain element \"resource.meta.vers" +
                    "ionId\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
  testRunner.And("response bundle \"Organization\" entries should contain element \"resource.meta.prof" +
                    "ile[0]\" with value \"http://fhir.nhs.net/StructureDefinition/gpconnect-organizati" +
                    "on-1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
  testRunner.And("response should contain ods-organization-codes \"ORG2|ORG3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
  testRunner.And("response should contain ods-site-codes \"SIT3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search failure due to invalid identifier")]
        [NUnit.Framework.TestCaseAttribute("GPC001", new string[0])]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-site-code", new string[0])]
        [NUnit.Framework.TestCaseAttribute("http://fhir.nhs.net/Id/ods-site-code|", new string[0])]
        [NUnit.Framework.TestCaseAttribute("|GPC001", new string[0])]
        public virtual void OrganizationSearchFailureDueToInvalidIdentifier(string identifier, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search failure due to invalid identifier", exampleTags);
#line 90
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 91
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
  testRunner.And(string.Format("I add the parameter \"identifier\" with the value \"{0}\"", identifier), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("the response status code should be \"422\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
  testRunner.And("the JSON response should be a OperationOutcome resource with error code \"INVALID_" +
                    "PARAMETER\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search failure due to invalid system")]
        public virtual void OrganizationSearchFailureDueToInvalidSystem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search failure due to invalid system", ((string[])(null)));
#line 105
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 106
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 107
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
  testRunner.And("I add the parameter \"identifier\" with the value \"badSystem|GPC001\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
  testRunner.And("the JSON response should be a OperationOutcome resource with error code \"INVALID_" +
                    "PARAMETER\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search failure due to no identifier parameter")]
        public virtual void OrganizationSearchFailureDueToNoIdentifierParameter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search failure due to no identifier parameter", ((string[])(null)));
#line 114
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 115
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 116
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
  testRunner.And("the JSON response should be a OperationOutcome resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search failure due to invalid identifier parameter case")]
        [NUnit.Framework.TestCaseAttribute("idenddstifier", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Idenddstifier", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Identifier", new string[0])]
        public virtual void OrganizationSearchFailureDueToInvalidIdentifierParameterCase(string identifier, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search failure due to invalid identifier parameter case", exampleTags);
#line 122
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 123
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 124
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
  testRunner.And(string.Format("I add the parameter \"{0}\" with the value \"http://fhir.nhs.net/Id/ods-organization" +
                        "-code\\|GPC001\"", identifier), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
  testRunner.And("the JSON response should be a OperationOutcome resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search failure due to invalid interactionId")]
        [NUnit.Framework.TestCaseAttribute("urn:nhs:names:services:gpconnect:fhir:operation:gpc.getcarerecord", new string[0])]
        [NUnit.Framework.TestCaseAttribute("InvalidInteractionId", new string[0])]
        [NUnit.Framework.TestCaseAttribute("", new string[0])]
        public virtual void OrganizationSearchFailureDueToInvalidInteractionId(string interactionId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search failure due to invalid interactionId", exampleTags);
#line 136
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 137
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 138
  testRunner.And(string.Format("I am performing the \"{0}\" interaction", interactionId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
  testRunner.And("I add the organization identifier parameter with system \"http://fhir.nhs.net/Id/o" +
                    "ds-organization-code\" and value \"ORG1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
  testRunner.And("the JSON response should be a OperationOutcome resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search failure due to missing header")]
        [NUnit.Framework.TestCaseAttribute("Ssp-TraceID", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Ssp-From", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Ssp-To", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Ssp-InteractionId", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Authorization", new string[0])]
        public virtual void OrganizationSearchFailureDueToMissingHeader(string header, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search failure due to missing header", exampleTags);
#line 150
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 151
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 152
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
  testRunner.And("I add the organization identifier parameter with system \"http://fhir.nhs.net/Id/o" +
                    "ds-organization-code\" and value \"ORG1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
  testRunner.And(string.Format("I do not send header \"{0}\"", header), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 157
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
  testRunner.And("the JSON response should be a OperationOutcome resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search accept header")]
        [NUnit.Framework.TestCaseAttribute("application/json+fhir", "JSON", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/xml+fhir", "XML", new string[0])]
        public virtual void OrganizationSearchAcceptHeader(string header, string bodyFormat, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search accept header", exampleTags);
#line 167
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 168
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 169
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
  testRunner.And("I add the organization identifier parameter with system \"http://fhir.nhs.net/Id/o" +
                    "ds-organization-code\" and value \"ORG1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
  testRunner.And(string.Format("I set the Accept header to \"{0}\"", header), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 173
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 174
  testRunner.And(string.Format("the response body should be FHIR {0}", bodyFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search _format parameter")]
        [NUnit.Framework.TestCaseAttribute("application/json+fhir", "JSON", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/xml+fhir", "XML", new string[0])]
        public virtual void OrganizationSearch_FormatParameter(string parameter, string bodyFormat, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search _format parameter", exampleTags);
#line 180
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 181
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 182
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
  testRunner.And("I add the organization identifier parameter with system \"http://fhir.nhs.net/Id/o" +
                    "ds-organization-code\" and value \"ORG1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 184
  testRunner.And("I do not send header \"Accept\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
  testRunner.And(string.Format("I add the parameter \"_format\" with the value \"{0}\"", parameter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 186
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 187
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 188
  testRunner.And(string.Format("the response body should be FHIR {0}", bodyFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Organization search accept header and _format parameter")]
        [NUnit.Framework.TestCaseAttribute("application/json+fhir", "application/json+fhir", "JSON", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/json+fhir", "application/xml+fhir", "XML", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/xml+fhir", "application/json+fhir", "JSON", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/xml+fhir", "application/xml+fhir", "XML", new string[0])]
        public virtual void OrganizationSearchAcceptHeaderAnd_FormatParameter(string header, string parameter, string bodyFormat, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Organization search accept header and _format parameter", exampleTags);
#line 194
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 195
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 196
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:organizati" +
                    "on\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
  testRunner.And("I add the organization identifier parameter with system \"http://fhir.nhs.net/Id/o" +
                    "ds-organization-code\" and value \"ORG1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 198
  testRunner.And(string.Format("I set the Accept header to \"{0}\"", header), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
  testRunner.And(string.Format("I add the parameter \"_format\" with the value \"{0}\"", parameter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
 testRunner.When("I make a GET request to \"/Organization\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 201
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 202
  testRunner.And(string.Format("the response body should be FHIR {0}", bodyFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Conformance profile supports the Organization search operation")]
        public virtual void ConformanceProfileSupportsTheOrganizationSearchOperation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conformance profile supports the Organization search operation", ((string[])(null)));
#line 210
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 211
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 212
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:read:metadata\" in" +
                    "teraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 213
 testRunner.When("I make a GET request to \"/metadata\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 214
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 215
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 216
  testRunner.And("the conformance profile should contain the \"Organization\" resource with a \"search" +
                    "-type\" interaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
