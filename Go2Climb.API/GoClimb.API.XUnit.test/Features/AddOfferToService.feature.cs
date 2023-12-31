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
namespace GoClimb.API.XUnit.test.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AddOfferToServiceFeature : object, Xunit.IClassFixture<AddOfferToServiceFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AddOfferToService.feature"
#line hidden
        
        public AddOfferToServiceFeature(AddOfferToServiceFeature.FixtureData fixtureData, GoClimb_API_XUnit_test_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "AddOfferToService", "\tAs Agency I want to add my services so that my clients can see them", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 4
 #line hidden
#line 5
  testRunner.Given("The Endpoint https://localhost:5001/api/v1/services/1 is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Email",
                        "PhoneNumber",
                        "Description",
                        "Location",
                        "Ruc",
                        "Photo",
                        "Score"});
            table7.AddRow(new string[] {
                        "1",
                        "Climbling",
                        "Climbling@go.com",
                        "987654321",
                        "funny",
                        "calle 2",
                        "12345678",
                        "none",
                        "5"});
#line 6
  testRunner.And("A agency is already stored", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Score",
                        "Price",
                        "Location",
                        "CreationDate",
                        "Description",
                        "AgencyId"});
            table8.AddRow(new string[] {
                        "1",
                        "New Service",
                        "0",
                        "420",
                        "Ancash",
                        "06-11-2021",
                        "This is a new service for my agency",
                        "1"});
#line 9
     testRunner.And("A Service is already stored", ((string)(null)), table8, "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add Offer to Service")]
        [Xunit.TraitAttribute("FeatureTitle", "AddOfferToService")]
        [Xunit.TraitAttribute("Description", "Add Offer to Service")]
        [Xunit.TraitAttribute("Category", "offer-adding")]
        public virtual void AddOfferToService()
        {
            string[] tagsOfScenario = new string[] {
                    "offer-adding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Offer to Service", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 14
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
#line 4
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Name",
                            "Price",
                            "Location",
                            "CreationDate",
                            "Description",
                            "AgencyId"});
                table9.AddRow(new string[] {
                            "1",
                            "New Service",
                            "420",
                            "Ancash",
                            "06-11-2021",
                            "This is a new service for my agency",
                            "1"});
#line 15
 testRunner.When("A Service Request is Sent with complete information for a upgrade of price", ((string)(null)), table9, "When ");
#line hidden
#line 18
   testRunner.Then("A response with status 200 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                AddOfferToServiceFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AddOfferToServiceFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
