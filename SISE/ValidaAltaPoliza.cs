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

namespace SISE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidaAltaPoliza recording.
    /// </summary>
    [TestModule("49139661-5b4c-4a0e-aa52-cd6dbe0a75d6", ModuleType.Recording, 1)]
    public partial class ValidaAltaPoliza : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SISERepository repository.
        /// </summary>
        public static SISERepository repo = SISERepository.Instance;

        static ValidaAltaPoliza instance = new ValidaAltaPoliza();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidaAltaPoliza()
        {
            NroPoliza = "04104008212";
            PolizaConvertida = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidaAltaPoliza Instance
        {
            get { return instance; }
        }

#region Variables

        string _NroPoliza;

        /// <summary>
        /// Gets or sets the value of variable NroPoliza.
        /// </summary>
        [TestVariable("aac5330d-becc-4ed7-8c4b-6b6852750412")]
        public string NroPoliza
        {
            get { return _NroPoliza; }
            set { _NroPoliza = value; }
        }

        string _PolizaConvertida;

        /// <summary>
        /// Gets or sets the value of variable PolizaConvertida.
        /// </summary>
        [TestVariable("8107bb7b-8c95-469b-8ddf-31d112bb88b3")]
        public string PolizaConvertida
        {
            get { return _PolizaConvertida; }
            set { _PolizaConvertida = value; }
        }

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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SisePreProd' at 109;42.", repo.SisePreProd.SelfInfo, new RecordItemIndex(0));
            //repo.SisePreProd.Self.Click("109;42");
            //Delay.Milliseconds(0);
            
            PolizaConverter();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", PolizaConvertida, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(3));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'sistema{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(4));
            repo.SisePreProd.Self.PressKeys("sistema{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 12s.", new RecordItemIndex(5));
            Delay.Duration(12000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '990{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(6));
            repo.SisePreProd.Self.PressKeys("990{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(7));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Sura2040{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(8));
            repo.SisePreProd.Self.PressKeys("Sura2040{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(9));
            Delay.Duration(5000, false);
            
            // Validación del Login (Texto: MENU PRINICPAL)
            ValidarLogin("M E N U    P R I N C I P A L", "Validación del Login");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(11));
            repo.SisePreProd.Self.PressKeys("1{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(12));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(13));
            repo.SisePreProd.Self.PressKeys("1{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(14));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(15));
            repo.SisePreProd.Self.PressKeys("1{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(16));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(17));
            repo.SisePreProd.Self.PressKeys("2{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(18));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NroPoliza' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(19));
            repo.SisePreProd.Self.PressKeys(NroPoliza);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SisePreProd'.", repo.SisePreProd.SelfInfo, new RecordItemIndex(20));
            repo.SisePreProd.Self.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(21));
            Delay.Duration(2000, false);
            
            // Validación de Póliza Existente
            ValidarLogin(PolizaConvertida, "Validación de Póliza");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SisePreProd.Self, false, new RecordItemIndex(23));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SisePreProd.Sistema' at 18;6.", repo.SisePreProd.SistemaInfo, new RecordItemIndex(24));
            //repo.SisePreProd.Sistema.Click("18;6");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Putty.CopyAllToClipboard' at 122;9.", repo.Putty.CopyAllToClipboardInfo, new RecordItemIndex(25));
            //repo.Putty.CopyAllToClipboard.Click("122;9");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
