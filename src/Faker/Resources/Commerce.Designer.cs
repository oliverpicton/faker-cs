﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Faker.Resources {
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
    internal class Commerce {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Commerce() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Faker.Resources.Commerce", typeof(Commerce).Assembly);
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
        ///   Looks up a localized string similar to Books;Movies;Music;Games;Electronics;Computers;Home;Garden;Tools;Grocery;Health;Beauty;Toys;Kids;Baby;Clothing;Shoes;Jewelery;Sports;Outdoors;Automotive;Industrial.
        /// </summary>
        internal static string department {
            get {
                return ResourceManager.GetString("department", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Chair;Car;Computer;Gloves;Pants;Shirt;Table;Shoes;Hat;Plate;Knife;Bottle;Coat;Lamp;Keyboard;Bag;Bench;Clock;Watch;Wallet.
        /// </summary>
        internal static string productName {
            get {
                return ResourceManager.GetString("productName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Small;Ergonomic;Rustic;Intelligent;Gorgeous;Incredible;Fantastic;Practical;Sleek;Awesome;Enormous;Mediocre;Synergistic;Heavy Duty;Lightweight;Aerodynamic;Durable.
        /// </summary>
        internal static string productNameAdjective {
            get {
                return ResourceManager.GetString("productNameAdjective", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Steel;Wooden;Concrete;Plastic;Cotton;Granite;Rubber;Leather;Silk;Wool;Linen;Marble;Iron;Bronze;Copper;Aluminum;Paper.
        /// </summary>
        internal static string productNameMaterial {
            get {
                return ResourceManager.GetString("productNameMaterial", resourceCulture);
            }
        }
    }
}
