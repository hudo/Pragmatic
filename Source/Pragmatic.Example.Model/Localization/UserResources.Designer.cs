﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pragmatic.Example.Model.Localization {
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
    public class UserResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UserResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pragmatic.Example.Model.Localization.UserResources", typeof(UserResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user with administrator privileges cannot be deleted..
        /// </summary>
        public static string AdministratorCannotBeDeleted {
            get {
                return ResourceManager.GetString("AdministratorCannotBeDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleteing user permanently deletes all information about the user. The information cannot be recovered later on..
        /// </summary>
        public static string DeletingUserPermanentlyDeletesAllItsData {
            get {
                return ResourceManager.GetString("DeletingUserPermanentlyDeletesAllItsData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email must be a valid email address..
        /// </summary>
        public static string EmailMustBeAValidEmailAddress {
            get {
                return ResourceManager.GetString("EmailMustBeAValidEmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email must not be empty..
        /// </summary>
        public static string EmailMustNotBeEmpty {
            get {
                return ResourceManager.GetString("EmailMustNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First name must not be empty..
        /// </summary>
        public static string FirstNameMustNotBeEmpty {
            get {
                return ResourceManager.GetString("FirstNameMustNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User: {0}.
        /// </summary>
        public static string InformationUserFullName {
            get {
                return ResourceManager.GetString("InformationUserFullName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last name must not be empty..
        /// </summary>
        public static string LastNameMustNotBeEmpty {
            get {
                return ResourceManager.GetString("LastNameMustNotBeEmpty", resourceCulture);
            }
        }
    }
}
