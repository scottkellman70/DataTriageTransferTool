﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataTriageTransferTool.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DataTriageTransferTool.Properties.Resources", typeof(Resources).Assembly);
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
        
        /// <summary>
        ///   Looks up a localized string similar to select * from case_folder.
        /// </summary>
        internal static string case_folder {
            get {
                return ResourceManager.GetString("case_folder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from cellex_types.
        /// </summary>
        internal static string cellex_types {
            get {
                return ResourceManager.GetString("cellex_types", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\source\repos\DataTriageTransferTool\DT3.mdf;Integrated Security=True;Connect Timeout=30.
        /// </summary>
        internal static string dt3_connection_string {
            get {
                return ResourceManager.GetString("dt3_connection_string", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from flume.
        /// </summary>
        internal static string flume_data {
            get {
                return ResourceManager.GetString("flume_data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C:\Program Files\SaratogaDataSystems\Flume.
        /// </summary>
        internal static string FlumeWorkingDirectory {
            get {
                return ResourceManager.GetString("FlumeWorkingDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id from aors where aor =.
        /// </summary>
        internal static string get_aor_id {
            get {
                return ResourceManager.GetString("get_aor_id", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id from classifications where classification =.
        /// </summary>
        internal static string get_classification_id {
            get {
                return ResourceManager.GetString("get_classification_id", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from medex_types.
        /// </summary>
        internal static string medex_types {
            get {
                return ResourceManager.GetString("medex_types", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id, aor from aors.
        /// </summary>
        internal static string select_aors {
            get {
                return ResourceManager.GetString("select_aors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from cases.
        /// </summary>
        internal static string select_cases {
            get {
                return ResourceManager.GetString("select_cases", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id,classification from classifications.
        /// </summary>
        internal static string select_classifications {
            get {
                return ResourceManager.GetString("select_classifications", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from items where case_id=.
        /// </summary>
        internal static string select_items {
            get {
                return ResourceManager.GetString("select_items", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from sizes.
        /// </summary>
        internal static string sizes {
            get {
                return ResourceManager.GetString("sizes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1.0.0 BETA.
        /// </summary>
        internal static string Version {
            get {
                return ResourceManager.GetString("Version", resourceCulture);
            }
        }
    }
}
