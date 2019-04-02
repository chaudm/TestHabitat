﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Foundation.SitecoreExtensions.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "Service")]
    public partial class RichTextEditorConfigurationFeature : Xunit.IClassFixture<RichTextEditorConfigurationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Rich text editor configuration.feature"
#line hidden
        
        public RichTextEditorConfigurationFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Rich text editor configuration", null, ProgrammingLanguage.CSharp, new string[] {
                        "Service"});
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
        
        public virtual void SetFixture(RichTextEditorConfigurationFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Rich text editor configuration")]
        [Xunit.TraitAttribute("Description", "Rich text editor configuration_UC1_Default rich text editor defined")]
        [Xunit.TraitAttribute("Category", "OnlyManual")]
        public virtual void RichTextEditorConfiguration_UC1_DefaultRichTextEditorDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Rich text editor configuration_UC1_Default rich text editor defined", new string[] {
                        "OnlyManual"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table1.AddRow(new string[] {
                        "/sitecore/templates/Feature/PageContent",
                        "Summary",
                        "@empty"});
#line 7
 testRunner.Given("Value set to item field", ((string)(null)), table1, "Given ");
#line 10
 testRunner.And("Experience Editor application is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("User navigates to News page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.And("User clicks on News Summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("User opens Rich Text Editor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Class"});
            table2.AddRow(new string[] {
                        "Bold"});
            table2.AddRow(new string[] {
                        "Italic"});
            table2.AddRow(new string[] {
                        "InsertSitecoreLink"});
            table2.AddRow(new string[] {
                        "InsertSitecoreMedia"});
            table2.AddRow(new string[] {
                        "Unlink"});
            table2.AddRow(new string[] {
                        "LinkManager"});
            table2.AddRow(new string[] {
                        "InsertSymbol"});
            table2.AddRow(new string[] {
                        "PasteFromWordNoFontsNoSizes"});
            table2.AddRow(new string[] {
                        "Undo"});
            table2.AddRow(new string[] {
                        "Redo"});
            table2.AddRow(new string[] {
                        "FindAndReplace"});
#line 14
 testRunner.Then("Following classes present in a Rich Text Editor popup", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Rich text editor configuration")]
        [Xunit.TraitAttribute("Description", "Rich text editor configuration_UC2_Limitted rich text editor defined")]
        [Xunit.TraitAttribute("Category", "OnlyManual")]
        public virtual void RichTextEditorConfiguration_UC2_LimittedRichTextEditorDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Rich text editor configuration_UC2_Limitted rich text editor defined", new string[] {
                        "OnlyManual"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table3.AddRow(new string[] {
                        "/sitecore/templates/Feature/PageContent",
                        "Summary",
                        "/sitecore/system/Settings/Html Editor Profiles/Rich Text Limited"});
#line 32
 testRunner.Given("Value set to item field", ((string)(null)), table3, "Given ");
#line 35
 testRunner.And("Experience Editor application is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("User navigates to News page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And("User clicks on News Summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("User opens Rich Text Editor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Class"});
            table4.AddRow(new string[] {
                        "Bold"});
            table4.AddRow(new string[] {
                        "Italic"});
            table4.AddRow(new string[] {
                        "InsertSitecoreLink"});
            table4.AddRow(new string[] {
                        "InsertSitecoreMedia"});
            table4.AddRow(new string[] {
                        "Unlink"});
            table4.AddRow(new string[] {
                        "LinkManager"});
            table4.AddRow(new string[] {
                        "InsertSymbol"});
            table4.AddRow(new string[] {
                        "PasteFromWordNoFontsNoSizes"});
            table4.AddRow(new string[] {
                        "Undo"});
            table4.AddRow(new string[] {
                        "Redo"});
            table4.AddRow(new string[] {
                        "FindAndReplace"});
#line 39
 testRunner.Then("Following classes present in a Rich Text Editor popup", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Rich text editor configuration")]
        [Xunit.TraitAttribute("Description", "Rich text editor configuration_UC3_Complete rich text editor defined")]
        [Xunit.TraitAttribute("Category", "OnlyManual")]
        public virtual void RichTextEditorConfiguration_UC3_CompleteRichTextEditorDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Rich text editor configuration_UC3_Complete rich text editor defined", new string[] {
                        "OnlyManual"});
#line 54
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table5.AddRow(new string[] {
                        "/sitecore/templates/Feature/PageContent",
                        "Body",
                        "/sitecore/system/Settings/Html Editor Profiles/Rich Text Complete"});
#line 55
 testRunner.Given("Value set to item field", ((string)(null)), table5, "Given ");
#line 58
 testRunner.And("Experience Editor application is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.When("User navigates to News page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.And("User clicks on News Body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("User opens Rich Text Editor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Class"});
            table6.AddRow(new string[] {
                        "Print"});
            table6.AddRow(new string[] {
                        "FindAndReplace"});
            table6.AddRow(new string[] {
                        "Cut"});
            table6.AddRow(new string[] {
                        "Copy"});
            table6.AddRow(new string[] {
                        "Paste"});
            table6.AddRow(new string[] {
                        "PasteFromWord"});
            table6.AddRow(new string[] {
                        "PasteFromWordNoFontsNoSizes"});
            table6.AddRow(new string[] {
                        "PastePlainText"});
            table6.AddRow(new string[] {
                        "PasteAsHtml"});
            table6.AddRow(new string[] {
                        "FormatStripper"});
            table6.AddRow(new string[] {
                        "Undo"});
            table6.AddRow(new string[] {
                        "Redo"});
            table6.AddRow(new string[] {
                        "InsertSitecoreLink"});
            table6.AddRow(new string[] {
                        "InsertSitecoreBucketLink"});
            table6.AddRow(new string[] {
                        "InsertSitecoreMedia"});
            table6.AddRow(new string[] {
                        "LinkManager"});
            table6.AddRow(new string[] {
                        "Unlink"});
            table6.AddRow(new string[] {
                        "InsertTable"});
            table6.AddRow(new string[] {
                        "InsertParagraph"});
            table6.AddRow(new string[] {
                        "InsertDate"});
            table6.AddRow(new string[] {
                        "InsertSnippet"});
            table6.AddRow(new string[] {
                        "Bold"});
            table6.AddRow(new string[] {
                        "Italic"});
            table6.AddRow(new string[] {
                        "Underline"});
            table6.AddRow(new string[] {
                        "InsertOrderedList"});
            table6.AddRow(new string[] {
                        "InsertUnorderedList"});
            table6.AddRow(new string[] {
                        "StrikeThrough"});
            table6.AddRow(new string[] {
                        "Subscript"});
            table6.AddRow(new string[] {
                        "Superscript"});
            table6.AddRow(new string[] {
                        "AjaxSpellCheck"});
            table6.AddRow(new string[] {
                        "XhtmlValidator"});
            table6.AddRow(new string[] {
                        "Help"});
#line 62
 testRunner.Then("Following classes present in a Rich Text Editor popup", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Rich text editor configuration")]
        [Xunit.TraitAttribute("Description", "Rich text editor configuration_UC4_Assert Custom Html profiles are present")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void RichTextEditorConfiguration_UC4_AssertCustomHtmlProfilesArePresent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Rich text editor configuration_UC4_Assert Custom Html profiles are present", new string[] {
                        "Ready"});
#line 99
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Html profile"});
            table7.AddRow(new string[] {
                        "Rich Text Complete"});
            table7.AddRow(new string[] {
                        "Rich Text Limited"});
            table7.AddRow(new string[] {
                        "Rich Text Default"});
#line 100
 testRunner.Then("Following items are present under /sitecore/system/Settings/Html Editor Profiles " +
                    "item in Core db", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Rich text editor configuration")]
        [Xunit.TraitAttribute("Description", "Rich text editor configuration_UC5_Assert Page Content has correct Rich Text Edit" +
            "or values")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void RichTextEditorConfiguration_UC5_AssertPageContentHasCorrectRichTextEditorValues()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Rich text editor configuration_UC5_Assert Page Content has correct Rich Text Edit" +
                    "or values", new string[] {
                        "Ready"});
#line 107
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "itemPath",
                        "fieldName",
                        "fieldValue"});
            table8.AddRow(new string[] {
                        "/sitecore/templates/Feature/PageContent/_HasPageContent/Content/Summary",
                        "Source",
                        "/sitecore/system/Settings/Html Editor Profiles/Rich Text Limited"});
            table8.AddRow(new string[] {
                        "/sitecore/templates/Feature/PageContent/_HasPageContent/Content/Body",
                        "Source",
                        "/sitecore/system/Settings/Html Editor Profiles/Rich Text Complete"});
#line 108
 testRunner.Then("Page Content has correct Rich Text Editor sources", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RichTextEditorConfigurationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RichTextEditorConfigurationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
