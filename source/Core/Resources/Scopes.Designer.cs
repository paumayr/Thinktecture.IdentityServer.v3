﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thinktecture.IdentityServer.Core.Resources {
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
    internal class Scopes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Scopes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Thinktecture.IdentityServer.Core.Resources.Scopes", typeof(Scopes).Assembly);
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
        ///   Looks up a localized string similar to Your postal address.
        /// </summary>
        internal static string AddressDisplayName {
            get {
                return ResourceManager.GetString("AddressDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your email address.
        /// </summary>
        internal static string EmailDisplayName {
            get {
                return ResourceManager.GetString("EmailDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offline access.
        /// </summary>
        internal static string OfflineAccessDisplayName {
            get {
                return ResourceManager.GetString("OfflineAccessDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your user identifier.
        /// </summary>
        internal static string OpenIdDisplayName {
            get {
                return ResourceManager.GetString("OpenIdDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your phone number.
        /// </summary>
        internal static string PhoneDisplayName {
            get {
                return ResourceManager.GetString("PhoneDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your user profile information (first name, last name, etc.).
        /// </summary>
        internal static string ProfileDescription {
            get {
                return ResourceManager.GetString("ProfileDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User profile.
        /// </summary>
        internal static string ProfileDisplayName {
            get {
                return ResourceManager.GetString("ProfileDisplayName", resourceCulture);
            }
        }
    }
}
