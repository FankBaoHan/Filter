using System.Collections;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;
using Core.Api.Application;
using Core.Api.Service;
using Core.Api.Tools;
using Core.Api.Utilities;
using Core.Utilities.Utilities;
using Core.Engine.Application;
using Neo.ApplicationFramework.Attributes;
using Neo.ApplicationFramework.Common;
using Neo.ApplicationFramework.Common.Runtime;
using Neo.ApplicationFramework.Common.TypeConverters;
using Neo.ApplicationFramework.Common.Utilities;
using Neo.ApplicationFramework.Interfaces;
using Neo.ApplicationFramework.Measurement;
using Neo.ApplicationFramework.Storage.Settings;
using Neo.ApplicationFramework.Tools.Runtime;
using Neo.ApplicationFramework.Tools.Storage;

[assembly: AssemblyVersion("2.41.177.0")]
[assembly: NeoDesignerVersion("2.41.177.0")]

namespace Neo.ApplicationFramework.Generated
{
    public class Globals : GlobalsBase
    {
        private static readonly log4net.ILog m_Log = log4net.LogManager.GetLogger(typeof(Globals));

        static Globals()
        {
            
        }

        public Globals() 
            : base(CreateToolManager())
        {
            m_ProjectSettings.MainScreenTitle = "Project1";
            m_ProjectSettings.Topmost = false;
            m_ProjectSettings.StartupLocation = new Point(0, 0);
            m_ProjectSettings.MaximizeOnStartup = false;
            m_ProjectSettings.UseWideScrollbars = false;
            m_ProjectSettings.MainScreenSize = new Size(800,480);
            m_ProjectSettings.BorderStyle = ScreenBorderStyle.SingleBorder;
            m_ProjectSettings.InputDelay = 2000;
            m_ProjectSettings.IsOnScreenKeyboardEnabled = true;
            m_ProjectSettings.KeyboardLayoutName = "US";
            m_ProjectSettings.TerminalGroup = TerminalGroup.Default;
            List<IStorageProviderSetting> storageProviderSettingsList = new List<IStorageProviderSetting>() {
                new ProjectStorageProviderSetting("BackupAtStartup", false), new ProjectStorageProviderSetting("MaxSize", 0), 
            };
            m_ProjectSettings.StorageProviderSettings = new LocallyHostedProjectStorageProviderSettings("SQLite Database", storageProviderSettingsList, "");
            m_SystemSettings.AutomaticallyTurnOfBacklight = false;
            m_SystemSettings.BacklightTimeout = 900;    
            m_SystemSettings.KeepBacklightOnIfNotifierWindowIsVisible = false;
            Dictionary<ComPort, PortMode> comPortModes = new Dictionary<ComPort, PortMode>();
            comPortModes.Add(ComPort.COM1, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM2, PortMode.rs485); comPortModes.Add(ComPort.COM3, PortMode.rs485);                            
            m_SystemSettings.ComPortModes = comPortModes;                            
            m_SystemSettings.KeyBeep = true;
            m_SystemSettings.TimeZoneDisplayName = "";
            m_SystemSettings.TimeZoneId = -1;
            m_SystemSettings.RegionLCID = 0;
            m_SystemSettings.AdjustForDaylightSaving = true;
            m_SystemSettings.FtpServerEnabled = false;
            m_SystemSettings.FtpServerFriendlyNamesEnabled = false;
            m_SystemSettings.FtpServerAllowAnonymous = false;
            m_SystemSettings.FtpServerSdCardAccess = false;
            m_SystemSettings.FtpServerUsbAccess = false;
            m_SystemSettings.FtpServerDefaultDir = @"";
            m_SystemSettings.NTLMUser = @"";
            m_SystemSettings.NTLMPassword = @"";
            m_SystemSettings.VncServerEnabled = false;
            m_SystemSettings.VncTcpPort = 5900;
            m_SystemSettings.VncHttpTcpPort = 5800;
            m_SystemSettings.VncViewOnlyPassword = @"";
            m_SystemSettings.VncFullAccessPassword = @"";
            m_SystemSettings.VncActiveConnectionNotification = false;
            m_SystemSettings.IsKeyPanel = false;
            m_SystemSettings.IsHeadless = false;
            m_SystemSettings.AlarmButtonShowScreenTarget = @"";
            m_SystemSettings.ScreenRotationAngle = 0;
            m_SystemSettings.BeShellMenuPassword = @"";
            m_SystemSettings.ProjectGuid = new Guid("5db07867-799a-499c-8a4f-ae0740bd6341");
        }
        
        
        private static IToolManager CreateToolManager()
        {
            string executablePath = typeof(Globals).Module.FullyQualifiedName;            
            // take simulation into account
            var coreApplication = Environment.OSVersion.Platform != PlatformID.WinCE ? (ICoreApplication)new CoreApplication(true, executablePath) : (ICoreApplication)new CoreApplicationCe();
            IToolManager toolManager = new ApplicationEngineCe().CreateToolManager(true, coreApplication, Path.Combine(coreApplication.StartupPath, "Modules.cfgtool"));
            return toolManager;
        }
            

        
       

        /// <summary>
        /// Neo generated code - do not modify
        /// the contents of this method(s) with the code editor.
        /// </summary>        
                    public static IPrinterDevice Printer1
                    {
                        get
                        {
                            IDeviceManagerServiceCF deviceManagerService = ServiceContainerCF.GetService<IDeviceManagerServiceCF>();
                            return deviceManagerService.GetOutputDevice<IPrinterDevice>();
                        }
                    }           
                    public static AlarmSet AlarmSet
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<AlarmSet>("AlarmSet");
                        }
                    }           
                    public static Deviation Deviation
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Deviation>("Deviation");
                        }
                    }           
                    public static Harmonic4UnitOne Harmonic4UnitOne
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Harmonic4UnitOne>("Harmonic4UnitOne");
                        }
                    }           
                    public static Flicker Flicker
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Flicker>("Flicker");
                        }
                    }           
                    public static AlarmServer AlarmServer
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<AlarmServer>("AlarmServer");
                        }
                    }           
                    public static Tags Tags
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Tags>("Tags");
                        }
                    }           
                    public static Expressions Expressions
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Expressions>("Expressions");
                        }
                    }           
                    public static Security Security
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Security>("Security");
                        }
                    }           
                    public static IScreenAdapter SUPERDETAIL2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SUPERDETAIL2>("Screens.SUPERDETAIL2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter DNV_DIS_2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DNV_DIS_2>("Screens.DNV_DIS_2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ALARMCONFIG
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ALARMCONFIG>("Screens.ALARMCONFIG.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter DNV_DIS_1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DNV_DIS_1>("Screens.DNV_DIS_1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ERR2_3
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ERR2_3>("Screens.ERR2_3.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ERR2_2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ERR2_2>("Screens.ERR2_2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ERR2_1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ERR2_1>("Screens.ERR2_1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter DETAIL2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DETAIL2>("Screens.DETAIL2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SUPERDUNIT
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SUPERDUNIT>("Screens.SUPERDUNIT.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SUPERCUNIT
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SUPERCUNIT>("Screens.SUPERCUNIT.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter UNITS
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<UNITS>("Screens.UNITS.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SUPERDETAIL1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SUPERDETAIL1>("Screens.SUPERDETAIL1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SUPERCONFIG1_4
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SUPERCONFIG1_4>("Screens.SUPERCONFIG1_4.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SUPERCONFIG1_3
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SUPERCONFIG1_3>("Screens.SUPERCONFIG1_3.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SUPERCONFIG1_2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SUPERCONFIG1_2>("Screens.SUPERCONFIG1_2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SUPERCONFIG1_1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SUPERCONFIG1_1>("Screens.SUPERCONFIG1_1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SETTING
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SETTING>("Screens.SETTING.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter RUNSTOP
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<RUNSTOP>("Screens.RUNSTOP.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter RUNIT
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<RUNIT>("Screens.RUNIT.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter REALALARM
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<REALALARM>("Screens.REALALARM.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter HOME2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<HOME2>("Screens.HOME2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter HOME1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<HOME1>("Screens.HOME1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ERR1_3
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ERR1_3>("Screens.ERR1_3.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ERR1_2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ERR1_2>("Screens.ERR1_2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ERR1_1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ERR1_1>("Screens.ERR1_1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter DETAIL1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DETAIL1>("Screens.DETAIL1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter CUNITS
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<CUNITS>("Screens.CUNITS.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter CONFIG1_3
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<CONFIG1_3>("Screens.CONFIG1_3.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter CONFIG1_2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<CONFIG1_2>("Screens.CONFIG1_2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter CONFIG1_1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<CONFIG1_1>("Screens.CONFIG1_1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter BG
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<BG>("Screens.BG.Default").Adapter;
                        }
                    }   
        [MTAThread]
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "NeoMainThread";
            
            InitializeBeHwApiLog();
            
            
            
            UserStartupMessage.SendUserStartupMessageToBeijerShell("Loading Files");
            if (!StopWatchCF.Silent)
                StopWatchCF.Send("Starting Project");
            StopWatchCF.SetTimestamp("***** Project Startup Time *****");
            while (ProcessExplorer.WaitForAttachDebugger)
            {
                Thread.Sleep(1000);
            }
            IsCompiledForCE = true;
            IsCompiledForDesktopWindowsPanel = false;

            Instance = new Globals();
        	if (!Instance.CheckIfApplicationCanRun())
				return;

            string executingAssemblyName = Assembly.GetExecutingAssembly().FullName;
            string executablePath = typeof(Globals).Module.FullyQualifiedName;

            Instance.Go(executingAssemblyName, executablePath, args, new string[]{"Security","Expressions","Tags","AlarmServer","Flicker","Harmonic4UnitOne","Deviation","AlarmSet"}, new string[]{}, () => HOME1);
        }

    }
}