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
    [NUnit.Framework.DescriptionAttribute("Patient")]
    [NUnit.Framework.CategoryAttribute("http")]
    public partial class PatientFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Patient.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Patient", null, ProgrammingLanguage.CSharp, new string[] {
                        "http"});
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
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "NHSNumber"});
            table1.AddRow(new string[] {
                        "patientNotInSystem",
                        "9999999999"});
            table1.AddRow(new string[] {
                        "patient1",
                        "9000000001"});
            table1.AddRow(new string[] {
                        "patient2",
                        "9000000002"});
            table1.AddRow(new string[] {
                        "patient16",
                        "9000000016"});
#line 5
 testRunner.Given("I have the following patient records", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The provider system should accept the search parameter URL encoded")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void TheProviderSystemShouldAcceptTheSearchParameterURLEncoded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The provider system should accept the search parameter URL encoded", new string[] {
                        "ignore"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Returned patients should contain a logical identifier")]
        public virtual void ReturnedPatientsShouldContainALogicalIdentifier()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Returned patients should contain a logical identifier", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 18
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("I search for Patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
  testRunner.And("the response should be a Bundle resource of type \"searchset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
  testRunner.And("all search response entities in bundle should contain a logical identifier", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider should return a patient resource when a valid request is sent")]
        public virtual void ProviderShouldReturnAPatientResourceWhenAValidRequestIsSent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider should return a patient resource when a valid request is sent", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 29
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When("I search for Patient \"patient1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
  testRunner.And("the response should be a Bundle resource of type \"searchset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider should return an error when an invalid system is supplied in the identif" +
            "ier parameter")]
        public virtual void ProviderShouldReturnAnErrorWhenAnInvalidSystemIsSuppliedInTheIdentifierParameter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider should return an error when an invalid system is supplied in the identif" +
                    "ier parameter", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 39
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("I search for Patient \"patient1\" with system \"http://test.net/types/internalIdenti" +
                    "fier\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
  testRunner.And("the response should be a OperationOutcome resource with error code \"INVALID_PARAM" +
                    "ETER\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider should return an error when no system is supplied in the identifier para" +
            "meter")]
        public virtual void ProviderShouldReturnAnErrorWhenNoSystemIsSuppliedInTheIdentifierParameter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider should return an error when no system is supplied in the identifier para" +
                    "meter", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 49
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.When("I search for Patient \"patient1\" without system in identifier parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("the response status code should be \"422\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
  testRunner.And("the response should be a OperationOutcome resource with error code \"INVALID_PARAM" +
                    "ETER\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider should return an error when a blank system is supplied in the identifier" +
            " parameter")]
        public virtual void ProviderShouldReturnAnErrorWhenABlankSystemIsSuppliedInTheIdentifierParameter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider should return an error when a blank system is supplied in the identifier" +
                    " parameter", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 59
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.When("I search for Patient \"patient1\" with system \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("the response status code should be \"422\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
  testRunner.And("the response should be a OperationOutcome resource with error code \"INVALID_PARAM" +
                    "ETER\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When a patient is not found on the provider system an empty bundle should be retu" +
            "rned")]
        public virtual void WhenAPatientIsNotFoundOnTheProviderSystemAnEmptyBundleShouldBeReturned()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When a patient is not found on the provider system an empty bundle should be retu" +
                    "rned", ((string[])(null)));
#line 68
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 69
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
  testRunner.And("I set the JWT requested record NHS number to config patient \"patientNotInSystem\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.When("I search for Patient \"patientNotInSystem\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
  testRunner.And("the response should be a Bundle resource of type \"searchset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
  testRunner.And("response bundle should contain \"0\" entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patient search should fail if no identifier parameter is include")]
        public virtual void PatientSearchShouldFailIfNoIdentifierParameterIsInclude()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patient search should fail if no identifier parameter is include", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 80
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 81
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.When("I make a GET request to \"/Patient\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
  testRunner.And("the response should be a OperationOutcome resource with error code \"BAD_REQUEST\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The identifier parameter should be rejected if the case is incorrect")]
        public virtual void TheIdentifierParameterShouldBeRejectedIfTheCaseIsIncorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The identifier parameter should be rejected if the case is incorrect", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 90
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I search for Patient \"patient2\" with parameter name \"IdentIfier\" and system \"http" +
                    "://fhir.nhs.net/Id/nhs-number\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
  testRunner.And("the response should be a OperationOutcome resource with error code \"BAD_REQUEST\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The response should be an error if parameter is not identifier")]
        public virtual void TheResponseShouldBeAnErrorIfParameterIsNotIdentifier()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The response should be an error if parameter is not identifier", ((string[])(null)));
#line 99
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 100
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 101
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.When("I search for Patient \"patient2\" with parameter name \"nhsNumberParam\" and system \"" +
                    "http://fhir.nhs.net/Id/nhs-number\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
  testRunner.And("the response should be a OperationOutcome resource with error code \"BAD_REQUEST\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The response should be an error if no value is sent in the identifier parameter")]
        public virtual void TheResponseShouldBeAnErrorIfNoValueIsSentInTheIdentifierParameter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The response should be an error if no value is sent in the identifier parameter", ((string[])(null)));
#line 109
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 110
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 111
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
  testRunner.And("I add the parameter \"identifier\" with the value \"http://fhir.nhs.net/Id/nhs-numbe" +
                    "r|\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.When("I make a GET request to \"/Patient\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.Then("the response status code should be \"422\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
  testRunner.And("the response should be a OperationOutcome resource with error code \"INVALID_PARAM" +
                    "ETER\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The patient search endpoint should accept the format parameter after the identifi" +
            "er parameter")]
        [NUnit.Framework.TestCaseAttribute("application/xml+fhir", "application/xml+fhir", "patient2", "XML", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/json+fhir", "application/xml+fhir", "patient2", "XML", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/json+fhir", "application/json+fhir", "patient2", "JSON", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/xml+fhir", "application/json+fhir", "patient2", "JSON", new string[0])]
        public virtual void ThePatientSearchEndpointShouldAcceptTheFormatParameterAfterTheIdentifierParameter(string acceptHeader, string formatParam, string patient, string resultFormat, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The patient search endpoint should accept the format parameter after the identifi" +
                    "er parameter", exampleTags);
#line 120
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 121
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 122
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
  testRunner.And(string.Format("I set the JWT requested record NHS number to config patient \"{0}\"", patient), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
  testRunner.And(string.Format("I set the Accept header to \"{0}\"", acceptHeader), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
  testRunner.And(string.Format("I add the parameter \"identifier\" with system \"http://fhir.nhs.net/Id/nhs-number\" " +
                        "for patient \"{0}\"", patient), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
  testRunner.And(string.Format("I add the parameter \"_format\" with the value \"{0}\"", formatParam), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.When("I make a GET request to \"/Patient\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
  testRunner.And(string.Format("the response body should be FHIR {0}", resultFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
  testRunner.And("the response should be a Bundle resource of type \"searchset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
  testRunner.And("response bundle should contain \"1\" entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The patient search endpoint should accept the format parameter before the identif" +
            "ier parameter")]
        [NUnit.Framework.TestCaseAttribute("application/xml+fhir", "application/xml+fhir", "patient2", "XML", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/json+fhir", "application/xml+fhir", "patient2", "XML", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/json+fhir", "application/json+fhir", "patient2", "JSON", new string[0])]
        [NUnit.Framework.TestCaseAttribute("application/xml+fhir", "application/json+fhir", "patient2", "JSON", new string[0])]
        public virtual void ThePatientSearchEndpointShouldAcceptTheFormatParameterBeforeTheIdentifierParameter(string acceptHeader, string formatParam, string patient, string resultFormat, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The patient search endpoint should accept the format parameter before the identif" +
                    "ier parameter", exampleTags);
#line 140
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 141
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 142
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
  testRunner.And(string.Format("I set the JWT requested record NHS number to config patient \"{0}\"", patient), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
  testRunner.And(string.Format("I set the Accept header to \"{0}\"", acceptHeader), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
  testRunner.And(string.Format("I add the parameter \"_format\" with the value \"{0}\"", formatParam), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
  testRunner.And(string.Format("I add the parameter \"identifier\" with system \"http://fhir.nhs.net/Id/nhs-number\" " +
                        "for patient \"{0}\"", patient), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.When("I make a GET request to \"/Patient\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
  testRunner.And(string.Format("the response body should be FHIR {0}", resultFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
  testRunner.And("the response should be a Bundle resource of type \"searchset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
  testRunner.And("response bundle should contain \"1\" entries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patient search failure due to invalid interactionId")]
        [NUnit.Framework.TestCaseAttribute("urn:nhs:names:services:gpconnect:fhir:operation:gpc.getcarerecord", new string[0])]
        [NUnit.Framework.TestCaseAttribute("InvalidInteractionId", new string[0])]
        [NUnit.Framework.TestCaseAttribute("", new string[0])]
        public virtual void PatientSearchFailureDueToInvalidInteractionId(string interactionId, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patient search failure due to invalid interactionId", exampleTags);
#line 160
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 161
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 162
  testRunner.And(string.Format("I am performing the \"{0}\" interaction", interactionId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 163
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.When("I search for Patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 165
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 166
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
  testRunner.And("the response should be a OperationOutcome resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patient search failure due to missing header")]
        [NUnit.Framework.TestCaseAttribute("Ssp-TraceID", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Ssp-From", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Ssp-To", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Ssp-InteractionId", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Authorization", new string[0])]
        public virtual void PatientSearchFailureDueToMissingHeader(string header, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patient search failure due to missing header", exampleTags);
#line 174
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 175
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 176
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
  testRunner.And(string.Format("I do not send header \"{0}\"", header), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 180
 testRunner.When("I search for Patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 181
 testRunner.Then("the response status code should be \"400\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 182
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
  testRunner.And("the response should be a OperationOutcome resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patient search with invalid identifier value")]
        [NUnit.Framework.TestCaseAttribute("1234567891", new string[0])]
        [NUnit.Framework.TestCaseAttribute("abcdefghij", new string[0])]
        [NUnit.Framework.TestCaseAttribute("", new string[0])]
        public virtual void PatientSearchWithInvalidIdentifierValue(string identifierValue, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patient search with invalid identifier value", exampleTags);
#line 192
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 193
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 194
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
  testRunner.And("I set the JWT requested record NHS number to config patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
  testRunner.And("I set the JWT requested scope to \"patient/*.read\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.When(string.Format("I search for a Patient with patameter name \"identifier\" and parameter string \"htt" +
                        "p://fhir.nhs.net/Id/nhs-number|{0}\"", identifierValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 198
 testRunner.Then("the response status code should be \"422\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
  testRunner.And("the response should be a OperationOutcome resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
