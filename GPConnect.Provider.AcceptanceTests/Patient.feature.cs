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
        [NUnit.Framework.DescriptionAttribute("Returned patients should contain a logical identifier")]
        public virtual void ReturnedPatientsShouldContainALogicalIdentifier()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Returned patients should contain a logical identifier", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 13
 testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("I search for a Patient \"patient2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
  testRunner.And("the JSON response should be a Bundle resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
  testRunner.And("all search response entities in bundle should contain a logical identifier", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider should return a paitent resource when a valid request is sent")]
        public virtual void ProviderShouldReturnAPaitentResourceWhenAValidRequestIsSent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider should return a paitent resource when a valid request is sent", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 22
  testRunner.Given("I am using the default server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
  testRunner.And("I am performing the \"urn:nhs:names:services:gpconnect:fhir:rest:search:patient\" i" +
                    "nteraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("I search for a Patient \"patient1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the response status code should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
  testRunner.And("the response body should be FHIR JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
  testRunner.And("the JSON response should be a Bundle resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider should return an error when an invalid system is supplied in the identif" +
            "ier parameter")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void ProviderShouldReturnAnErrorWhenAnInvalidSystemIsSuppliedInTheIdentifierParameter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider should return an error when an invalid system is supplied in the identif" +
                    "ier parameter", new string[] {
                        "ignore"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider should return an error when no system is supplied in the identifier para" +
            "meter")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void ProviderShouldReturnAnErrorWhenNoSystemIsSuppliedInTheIdentifierParameter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider should return an error when no system is supplied in the identifier para" +
                    "meter", new string[] {
                        "ignore"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider should return an error when a blank system is supplied in the identifier" +
            " parameter")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void ProviderShouldReturnAnErrorWhenABlankSystemIsSuppliedInTheIdentifierParameter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider should return an error when a blank system is supplied in the identifier" +
                    " parameter", new string[] {
                        "ignore"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When a patient is not found on the provider system an empty bundle should be retu" +
            "rned")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void WhenAPatientIsNotFoundOnTheProviderSystemAnEmptyBundleShouldBeReturned()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When a patient is not found on the provider system an empty bundle should be retu" +
                    "rned", new string[] {
                        "ignore"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The provider system should accept the search parameter URL encoded")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void TheProviderSystemShouldAcceptTheSearchParameterURLEncoded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The provider system should accept the search parameter URL encoded", new string[] {
                        "ignore"});
#line 46
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The provider system should accept the search parameter without URL encoding")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void TheProviderSystemShouldAcceptTheSearchParameterWithoutURLEncoding()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The provider system should accept the search parameter without URL encoding", new string[] {
                        "ignore"});
#line 50
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
