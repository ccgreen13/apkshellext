﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KKHomeProj.ApkShellExt.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KKHomeProj.ApkShellExt.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static byte[] aapt {
            get {
                object obj = ResourceManager.GetObject("aapt", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static byte[] adb {
            get {
                object obj = ResourceManager.GetObject("adb", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static System.Drawing.Bitmap deficon {
            get {
                object obj = ResourceManager.GetObject("deficon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No device attached!.
        /// </summary>
        internal static string menu_CannotFindPhone {
            get {
                return ResourceManager.GetString("menu_CannotFindPhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect adb with TCP/IP via WIFI.
        /// </summary>
        internal static string menu_comment_ConnectViaWIFI {
            get {
                return ResourceManager.GetString("menu_comment_ConnectViaWIFI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install to your device via adb.
        /// </summary>
        internal static string menu_comment_InstallToPhone {
            get {
                return ResourceManager.GetString("menu_comment_InstallToPhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect device via WIFI.
        /// </summary>
        internal static string menu_ConnectViaWIFI {
            get {
                return ResourceManager.GetString("menu_ConnectViaWIFI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disconnect.
        /// </summary>
        internal static string menu_DisconnectWIFI {
            get {
                return ResourceManager.GetString("menu_DisconnectWIFI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To Memory.
        /// </summary>
        internal static string menu_InstallToInternalMemory {
            get {
                return ResourceManager.GetString("menu_InstallToInternalMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install to Device.
        /// </summary>
        internal static string menu_InstallToPhone {
            get {
                return ResourceManager.GetString("menu_InstallToPhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To SD card.
        /// </summary>
        internal static string menu_InstallToSDCard {
            get {
                return ResourceManager.GetString("menu_InstallToSDCard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstall.
        /// </summary>
        internal static string menu_Uninstall {
            get {
                return ResourceManager.GetString("menu_Uninstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot connect this IP..
        /// </summary>
        internal static string prompt_ConnectFail {
            get {
                return ResourceManager.GetString("prompt_ConnectFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input the IP and port number of your device:.
        /// </summary>
        internal static string prompt_ConnectViaWIFI {
            get {
                return ResourceManager.GetString("prompt_ConnectViaWIFI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please type the IP of your device, like 192.168.0.11:5555.
        /// </summary>
        internal static string prompt_NotAnIP {
            get {
                return ResourceManager.GetString("prompt_NotAnIP", resourceCulture);
            }
        }
    }
}
