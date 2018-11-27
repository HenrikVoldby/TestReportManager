﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TivoliTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class TivoliTestsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "TivoliTests.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TivoliTests", "\tIn order to use the Tivoli site\r\n\tAs a user\r\n\tI want to navigate between pages", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "TivoliTests")))
            {
                global::TivoliTests.TivoliTestsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can access the contact us page in IE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TivoliTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("InternetExplorer")]
        public virtual void ICanAccessTheContactUsPageInIE()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can access the contact us page in IE", new string[] {
                        "InternetExplorer"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I open the Tivoli web site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.Then("The page contains header \'Glæd dig til\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
  testRunner.When("I click the link with text \'Kontakt os\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
  testRunner.Then("The page contains substring \'Åbningstider for Tivolis Callcenter i perioden\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can access the Tivoli Foodhall page under Spisesteder in Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TivoliTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Chrome")]
        public virtual void ICanAccessTheTivoliFoodhallPageUnderSpisestederInChrome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can access the Tivoli Foodhall page under Spisesteder in Chrome", new string[] {
                        "Chrome"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I open the Tivoli web site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
  testRunner.Then("The page contains header \'Glæd dig til\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
  testRunner.When("I click the main menu item with text \'Mad og drikke\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
  testRunner.When("I click the submenu item with text \'Tivoli Food Hall\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
  testRunner.Then("The page contains header \'Tivoli Food Hall\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can not enter an invalid email address when applying for news letter in Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TivoliTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Chrome")]
        public virtual void ICanNotEnterAnInvalidEmailAddressWhenApplyingForNewsLetterInChrome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can not enter an invalid email address when applying for news letter in Chrome", new string[] {
                        "Chrome"});
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("I open the Tivoli web site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
  testRunner.Then("The page contains header \'Glæd dig til\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Given("I click the main menu item with text \'Mad og drikke\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
  testRunner.When("I enter \'not_a_valid_mailaddress\' in the \'NewsletterFormEmailID\' textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
  testRunner.When("I click the button with text \'Hold mig opdateret\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
  testRunner.Then("The \'NewsletterFormEmailID\' textbox shows validation message \'Please include an \'" +
                    "@\' in the email address.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can access the price information page in headless browser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "TivoliTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PhantomJS")]
        public virtual void ICanAccessThePriceInformationPageInHeadlessBrowser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can access the price information page in headless browser", new string[] {
                        "PhantomJS"});
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
 testRunner.Given("I open the Tivoli web site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
  testRunner.Then("The page contains header \'Glæd dig til\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.Given("I click the main menu item with text \'Praktisk information\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
 testRunner.Given("I click the submenu item with text \'Priser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
  testRunner.Then("The page contains header \'Priser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
