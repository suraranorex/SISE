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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SISE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the SISERepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("f4f343a7-113c-4a65-8a38-09298a549234")]
    public partial class SISERepository : RepoGenBaseFolder
    {
        static SISERepository instance = new SISERepository();
        SISERepositoryFolders.ExplorerAppFolder _explorer;
        SISERepositoryFolders.SisePreProdAppFolder _sisepreprod;
        SISERepositoryFolders.PuttyAppFolder _putty;
        SISERepositoryFolders.PuTTYExitConfirmationAppFolder _puttyexitconfirmation;

        /// <summary>
        /// Gets the singleton class instance representing the SISERepository element repository.
        /// </summary>
        [RepositoryFolder("f4f343a7-113c-4a65-8a38-09298a549234")]
        public static SISERepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public SISERepository() 
            : base("SISERepository", "/", null, 0, false, "f4f343a7-113c-4a65-8a38-09298a549234", ".\\RepositoryImages\\SISERepositoryf4f343a7.rximgres")
        {
            _explorer = new SISERepositoryFolders.ExplorerAppFolder(this);
            _sisepreprod = new SISERepositoryFolders.SisePreProdAppFolder(this);
            _putty = new SISERepositoryFolders.PuttyAppFolder(this);
            _puttyexitconfirmation = new SISERepositoryFolders.PuTTYExitConfirmationAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f4f343a7-113c-4a65-8a38-09298a549234")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("205cf496-b57a-46a6-a0b2-f79c6524a04f")]
        public virtual SISERepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The SisePreProd folder.
        /// </summary>
        [RepositoryFolder("d15925a6-9610-499e-9464-48d1c1386f87")]
        public virtual SISERepositoryFolders.SisePreProdAppFolder SisePreProd
        {
            get { return _sisepreprod; }
        }

        /// <summary>
        /// The Putty folder.
        /// </summary>
        [RepositoryFolder("0f75a26d-46b9-4239-ac61-63bbc6b9a3d1")]
        public virtual SISERepositoryFolders.PuttyAppFolder Putty
        {
            get { return _putty; }
        }

        /// <summary>
        /// The PuTTYExitConfirmation folder.
        /// </summary>
        [RepositoryFolder("7d749db4-24fb-41bd-bd5b-fcf93beac97c")]
        public virtual SISERepositoryFolders.PuTTYExitConfirmationAppFolder PuTTYExitConfirmation
        {
            get { return _puttyexitconfirmation; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class SISERepositoryFolders
    {
        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("205cf496-b57a-46a6-a0b2-f79c6524a04f")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _sisepreprod1ventanadeejecucionInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "205cf496-b57a-46a6-a0b2-f79c6524a04f", "")
            {
                _sisepreprod1ventanadeejecucionInfo = new RepoItemInfo(this, "SISEPREPROD1VentanaDeEjecucion", "container[@controlid='40965']//toolbar[@accessiblename='Aplicaciones en ejecución']/button[@accessiblename>'SISE PREPROD - 1 ventana de']", 30000, null, "18c0838a-66cd-4c1b-b427-11d2cd09a70b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("205cf496-b57a-46a6-a0b2-f79c6524a04f")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("205cf496-b57a-46a6-a0b2-f79c6524a04f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SISEPREPROD1VentanaDeEjecucion item.
            /// </summary>
            [RepositoryItem("18c0838a-66cd-4c1b-b427-11d2cd09a70b")]
            public virtual Ranorex.Button SISEPREPROD1VentanaDeEjecucion
            {
                get
                {
                    return _sisepreprod1ventanadeejecucionInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SISEPREPROD1VentanaDeEjecucion item info.
            /// </summary>
            [RepositoryItemInfo("18c0838a-66cd-4c1b-b427-11d2cd09a70b")]
            public virtual RepoItemInfo SISEPREPROD1VentanaDeEjecucionInfo
            {
                get
                {
                    return _sisepreprod1ventanadeejecucionInfo;
                }
            }
        }

        /// <summary>
        /// The SisePreProdAppFolder folder.
        /// </summary>
        [RepositoryFolder("d15925a6-9610-499e-9464-48d1c1386f87")]
        public partial class SisePreProdAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _sistemaInfo;

            /// <summary>
            /// Creates a new SisePreProd  folder.
            /// </summary>
            public SisePreProdAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SisePreProd", "/form[@title='Sise Pre Prod']", parentFolder, 30000, null, true, "d15925a6-9610-499e-9464-48d1c1386f87", "")
            {
                _sistemaInfo = new RepoItemInfo(this, "Sistema", "?/?/menuitem[@accessiblename='Sistema']", 30000, null, "99a239ff-8c73-4359-af78-9d72c0bccc02");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d15925a6-9610-499e-9464-48d1c1386f87")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d15925a6-9610-499e-9464-48d1c1386f87")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Sistema item.
            /// </summary>
            [RepositoryItem("99a239ff-8c73-4359-af78-9d72c0bccc02")]
            public virtual Ranorex.MenuItem Sistema
            {
                get
                {
                    return _sistemaInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Sistema item info.
            /// </summary>
            [RepositoryItemInfo("99a239ff-8c73-4359-af78-9d72c0bccc02")]
            public virtual RepoItemInfo SistemaInfo
            {
                get
                {
                    return _sistemaInfo;
                }
            }
        }

        /// <summary>
        /// The PuttyAppFolder folder.
        /// </summary>
        [RepositoryFolder("0f75a26d-46b9-4239-ac61-63bbc6b9a3d1")]
        public partial class PuttyAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _copyalltoclipboardInfo;

            /// <summary>
            /// Creates a new Putty  folder.
            /// </summary>
            public PuttyAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Putty", "/contextmenu[@processname='putty']", parentFolder, 30000, null, false, "0f75a26d-46b9-4239-ac61-63bbc6b9a3d1", "")
            {
                _copyalltoclipboardInfo = new RepoItemInfo(this, "CopyAllToClipboard", "?/?/menuitem[@accessiblename='Copy All to Clipboard']", 30000, null, "d6ea5e5e-5b4b-4397-b33c-8313330de3b9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0f75a26d-46b9-4239-ac61-63bbc6b9a3d1")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("0f75a26d-46b9-4239-ac61-63bbc6b9a3d1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The CopyAllToClipboard item.
            /// </summary>
            [RepositoryItem("d6ea5e5e-5b4b-4397-b33c-8313330de3b9")]
            public virtual Ranorex.MenuItem CopyAllToClipboard
            {
                get
                {
                    return _copyalltoclipboardInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The CopyAllToClipboard item info.
            /// </summary>
            [RepositoryItemInfo("d6ea5e5e-5b4b-4397-b33c-8313330de3b9")]
            public virtual RepoItemInfo CopyAllToClipboardInfo
            {
                get
                {
                    return _copyalltoclipboardInfo;
                }
            }
        }

        /// <summary>
        /// The PuTTYExitConfirmationAppFolder folder.
        /// </summary>
        [RepositoryFolder("7d749db4-24fb-41bd-bd5b-fcf93beac97c")]
        public partial class PuTTYExitConfirmationAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _aceptarInfo;

            /// <summary>
            /// Creates a new PuTTYExitConfirmation  folder.
            /// </summary>
            public PuTTYExitConfirmationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("PuTTYExitConfirmation", "/form[@title='PuTTY Exit Confirmation']", parentFolder, 30000, null, true, "7d749db4-24fb-41bd-bd5b-fcf93beac97c", "")
            {
                _aceptarInfo = new RepoItemInfo(this, "Aceptar", "button[@text='Aceptar']", 30000, null, "eae3ff0f-bb1c-48e7-9796-af3ce63ff9cd");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7d749db4-24fb-41bd-bd5b-fcf93beac97c")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("7d749db4-24fb-41bd-bd5b-fcf93beac97c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Aceptar item.
            /// </summary>
            [RepositoryItem("eae3ff0f-bb1c-48e7-9796-af3ce63ff9cd")]
            public virtual Ranorex.Button Aceptar
            {
                get
                {
                    return _aceptarInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Aceptar item info.
            /// </summary>
            [RepositoryItemInfo("eae3ff0f-bb1c-48e7-9796-af3ce63ff9cd")]
            public virtual RepoItemInfo AceptarInfo
            {
                get
                {
                    return _aceptarInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
