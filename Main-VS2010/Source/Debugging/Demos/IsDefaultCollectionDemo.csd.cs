//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debugging.Demos
{
    
    
    /// <summary>
    /// The ConfigurationSection1 Configuration Section.
    /// </summary>
    public partial class ConfigurationSection1 : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the ConfigurationSection1 Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string ConfigurationSection1SectionName = "configurationSection1";
        
        /// <summary>
        /// Gets the ConfigurationSection1 instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public static global::Debugging.Demos.ConfigurationSection1 Instance
        {
            get
            {
                return ((global::Debugging.Demos.ConfigurationSection1)(global::System.Configuration.ConfigurationManager.GetSection(global::Debugging.Demos.ConfigurationSection1.ConfigurationSection1SectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Debugging.Demos.ConfigurationSection1.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Debugging.Demos.ConfigurationSection1.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Demo1Items Property
        /// <summary>
        /// The XML name of the <see cref="Demo1Items"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string Demo1ItemsPropertyName = "";
        
        /// <summary>
        /// Gets or sets the Demo1Items.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Demo1Items.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Debugging.Demos.ConfigurationSection1.Demo1ItemsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=true)]
        public global::Debugging.Demos.Demo1Collection Demo1Items
        {
            get
            {
                return ((global::Debugging.Demos.Demo1Collection)(base[global::Debugging.Demos.ConfigurationSection1.Demo1ItemsPropertyName]));
            }
            set
            {
                base[global::Debugging.Demos.ConfigurationSection1.Demo1ItemsPropertyName] = value;
            }
        }
        #endregion
        
        #region Demo2Items Property
        /// <summary>
        /// The XML name of the <see cref="Demo2Items"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string Demo2ItemsPropertyName = "demo2Items";
        
        /// <summary>
        /// Gets or sets the Demo2Items.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Demo2Items.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Debugging.Demos.ConfigurationSection1.Demo2ItemsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public global::Debugging.Demos.Demo2Collection Demo2Items
        {
            get
            {
                return ((global::Debugging.Demos.Demo2Collection)(base[global::Debugging.Demos.ConfigurationSection1.Demo2ItemsPropertyName]));
            }
            set
            {
                base[global::Debugging.Demos.ConfigurationSection1.Demo2ItemsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Debugging.Demos
{
    
    
    /// <summary>
    /// A collection of Demo1Element instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::Debugging.Demos.Demo1Element), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::Debugging.Demos.Demo1Collection.Demo1ElementPropertyName)]
    public partial class Demo1Collection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::Debugging.Demos.Demo1Element"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string Demo1ElementPropertyName = "demoElement";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        protected override string ElementName
        {
            get
            {
                return global::Debugging.Demos.Demo1Collection.Demo1ElementPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::Debugging.Demos.Demo1Collection.Demo1ElementPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::Debugging.Demos.Demo1Element)(element)).attribute1;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::Debugging.Demos.Demo1Element"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::Debugging.Demos.Demo1Element"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::Debugging.Demos.Demo1Element();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::Debugging.Demos.Demo1Element"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Debugging.Demos.Demo1Element"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public global::Debugging.Demos.Demo1Element this[int index]
        {
            get
            {
                return ((global::Debugging.Demos.Demo1Element)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::Debugging.Demos.Demo1Element"/> with the specified key.
        /// </summary>
        /// <param name="attribute1">The key of the <see cref="global::Debugging.Demos.Demo1Element"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public global::Debugging.Demos.Demo1Element this[object attribute1]
        {
            get
            {
                return ((global::Debugging.Demos.Demo1Element)(base.BaseGet(attribute1)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::Debugging.Demos.Demo1Element"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="demoElement">The <see cref="global::Debugging.Demos.Demo1Element"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public void Add(global::Debugging.Demos.Demo1Element demoElement)
        {
            base.BaseAdd(demoElement);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::Debugging.Demos.Demo1Element"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="demoElement">The <see cref="global::Debugging.Demos.Demo1Element"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public void Remove(global::Debugging.Demos.Demo1Element demoElement)
        {
            base.BaseRemove(this.GetElementKey(demoElement));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::Debugging.Demos.Demo1Element"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Debugging.Demos.Demo1Element"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public global::Debugging.Demos.Demo1Element GetItemAt(int index)
        {
            return ((global::Debugging.Demos.Demo1Element)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::Debugging.Demos.Demo1Element"/> with the specified key.
        /// </summary>
        /// <param name="attribute1">The key of the <see cref="global::Debugging.Demos.Demo1Element"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public global::Debugging.Demos.Demo1Element GetItemByKey(string attribute1)
        {
            return ((global::Debugging.Demos.Demo1Element)(base.BaseGet(((object)(attribute1)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace Debugging.Demos
{
    
    
    /// <summary>
    /// The Demo1Element Configuration Element.
    /// </summary>
    public partial class Demo1Element : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region attribute1 Property
        /// <summary>
        /// The XML name of the <see cref="attribute1"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string attribute1PropertyName = "attribute1";
        
        /// <summary>
        /// Gets or sets the attribute1.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The attribute1.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Debugging.Demos.Demo1Element.attribute1PropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public string attribute1
        {
            get
            {
                return ((string)(base[global::Debugging.Demos.Demo1Element.attribute1PropertyName]));
            }
            set
            {
                base[global::Debugging.Demos.Demo1Element.attribute1PropertyName] = value;
            }
        }
        #endregion
        
        #region attribute2 Property
        /// <summary>
        /// The XML name of the <see cref="attribute2"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string attribute2PropertyName = "attribute2";
        
        /// <summary>
        /// Gets or sets the attribute2.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The attribute2.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Debugging.Demos.Demo1Element.attribute2PropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string attribute2
        {
            get
            {
                return ((string)(base[global::Debugging.Demos.Demo1Element.attribute2PropertyName]));
            }
            set
            {
                base[global::Debugging.Demos.Demo1Element.attribute2PropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Debugging.Demos
{
    
    
    /// <summary>
    /// A collection of Demo2Element instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::Debugging.Demos.Demo2Element), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::Debugging.Demos.Demo2Collection.Demo2ElementPropertyName)]
    public partial class Demo2Collection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::Debugging.Demos.Demo2Element"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string Demo2ElementPropertyName = "demo2Element";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        protected override string ElementName
        {
            get
            {
                return global::Debugging.Demos.Demo2Collection.Demo2ElementPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::Debugging.Demos.Demo2Collection.Demo2ElementPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::Debugging.Demos.Demo2Element)(element)).attribute21;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::Debugging.Demos.Demo2Element"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::Debugging.Demos.Demo2Element"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::Debugging.Demos.Demo2Element();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::Debugging.Demos.Demo2Element"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Debugging.Demos.Demo2Element"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public global::Debugging.Demos.Demo2Element this[int index]
        {
            get
            {
                return ((global::Debugging.Demos.Demo2Element)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::Debugging.Demos.Demo2Element"/> with the specified key.
        /// </summary>
        /// <param name="attribute21">The key of the <see cref="global::Debugging.Demos.Demo2Element"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public global::Debugging.Demos.Demo2Element this[object attribute21]
        {
            get
            {
                return ((global::Debugging.Demos.Demo2Element)(base.BaseGet(attribute21)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::Debugging.Demos.Demo2Element"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="demo2Element">The <see cref="global::Debugging.Demos.Demo2Element"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public void Add(global::Debugging.Demos.Demo2Element demo2Element)
        {
            base.BaseAdd(demo2Element);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::Debugging.Demos.Demo2Element"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="demo2Element">The <see cref="global::Debugging.Demos.Demo2Element"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public void Remove(global::Debugging.Demos.Demo2Element demo2Element)
        {
            base.BaseRemove(this.GetElementKey(demo2Element));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::Debugging.Demos.Demo2Element"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Debugging.Demos.Demo2Element"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public global::Debugging.Demos.Demo2Element GetItemAt(int index)
        {
            return ((global::Debugging.Demos.Demo2Element)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::Debugging.Demos.Demo2Element"/> with the specified key.
        /// </summary>
        /// <param name="attribute21">The key of the <see cref="global::Debugging.Demos.Demo2Element"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public global::Debugging.Demos.Demo2Element GetItemByKey(string attribute21)
        {
            return ((global::Debugging.Demos.Demo2Element)(base.BaseGet(((object)(attribute21)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace Debugging.Demos
{
    
    
    /// <summary>
    /// The Demo2Element Configuration Element.
    /// </summary>
    public partial class Demo2Element : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region attribute21 Property
        /// <summary>
        /// The XML name of the <see cref="attribute21"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        internal const string attribute21PropertyName = "attribute21";
        
        /// <summary>
        /// Gets or sets the attribute21.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.0")]
        [global::System.ComponentModel.DescriptionAttribute("The attribute21.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Debugging.Demos.Demo2Element.attribute21PropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public string attribute21
        {
            get
            {
                return ((string)(base[global::Debugging.Demos.Demo2Element.attribute21PropertyName]));
            }
            set
            {
                base[global::Debugging.Demos.Demo2Element.attribute21PropertyName] = value;
            }
        }
        #endregion
    }
}
