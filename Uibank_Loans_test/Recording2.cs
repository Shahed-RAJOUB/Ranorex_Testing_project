///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Uibank_Loans_test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording2 recording.
    /// </summary>
    [TestModule("d9ce81bb-e1ee-44f2-be7c-d96ffece6089", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Uibank_Loans_testRepository repository.
        /// </summary>
        public static Uibank_Loans_testRepository repo = Uibank_Loans_testRepository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest' at 585;491.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Self.Click("585;491");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UiBankGoogleChrome' at 590;686.", repo.UiBankGoogleChrome.SelfInfo, new RecordItemIndex(1));
            repo.UiBankGoogleChrome.Self.Click("590;686");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest' at 595;587.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Self.Click("595;587");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad2}{NumPad0}{NumPad0}{NumPad0}' with focus on 'UiBankGoogleChrome'.", repo.UiBankGoogleChrome.SelfInfo, new RecordItemIndex(3));
            repo.UiBankGoogleChrome.Self.PressKeys("{NumPad1}{NumPad2}{NumPad0}{NumPad0}{NumPad0}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest' at 600;711.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Self.Click("600;711");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UiBankGoogleChrome' at 580;928.", repo.UiBankGoogleChrome.SelfInfo, new RecordItemIndex(5));
            repo.UiBankGoogleChrome.Self.Click("580;928");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest' at 569;808.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Self.Click("569;808");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad3}{NumPad0}{NumPad0}{NumPad0}' with focus on 'UiBankGoogleChrome'.", repo.UiBankGoogleChrome.SelfInfo, new RecordItemIndex(7));
            repo.UiBankGoogleChrome.Self.PressKeys("{NumPad3}{NumPad0}{NumPad0}{NumPad0}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(8));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest' at 585;787.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Self.Click("585;787");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad3}{NumPad5}' with focus on 'UiBankGoogleChrome'.", repo.UiBankGoogleChrome.SelfInfo, new RecordItemIndex(10));
            repo.UiBankGoogleChrome.Self.PressKeys("{NumPad3}{NumPad5}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(11));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest' at 756;799.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Self.Click("756;799");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest' at 917;209.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Self.Click("917;209");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
