﻿///////////////////////////////////////////////////////////////////////////////
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

namespace op_app_demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The add_payment_pg1 recording.
    /// </summary>
    [TestModule("08f599c3-ec8a-428c-a089-9de1a5179ddd", ModuleType.Recording, 1)]
    public partial class add_payment_pg1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the op_app_demoRepository repository.
        /// </summary>
        public static op_app_demoRepository repo = op_app_demoRepository.Instance;

        static add_payment_pg1 instance = new add_payment_pg1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public add_payment_pg1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static add_payment_pg1 Instance
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item 'ApplicationUnderTest.Form1PaymentType'.", repo.ApplicationUnderTest.Form1PaymentTypeInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Form1PaymentType.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '100000245004' on item 'ApplicationUnderTest.Form1Paymentreportentity'.", repo.ApplicationUnderTest.Form1PaymentreportentityInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Form1Paymentreportentity.Element.SetAttributeValue("TagValue", "100000245004");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2018' on item 'ApplicationUnderTest.Form1ProgramYear'.", repo.ApplicationUnderTest.Form1ProgramYearInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Form1ProgramYear.Element.SetAttributeValue("TagValue", "2018");
            Delay.Milliseconds(20);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(3));
            //Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Form1ContinueButton' at 66;22.", repo.ApplicationUnderTest.Form1ContinueButtonInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.Form1ContinueButton.Click("66;22");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.Form1ContinueButton'.", repo.ApplicationUnderTest.Form1ContinueButtonInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Form1ContinueButton.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
