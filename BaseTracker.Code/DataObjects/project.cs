﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
//public partial class id {
    
//	private string typeField;
    
//	private string valueField;
    
//	/// <remarks/>
//	[System.Xml.Serialization.XmlAttributeAttribute()]
//	public string type {
//		get {
//			return this.typeField;
//		}
//		set {
//			this.typeField = value;
//		}
//	}
    
//	/// <remarks/>
//	[System.Xml.Serialization.XmlTextAttribute()]
//	public string Value {
//		get {
//			return this.valueField;
//		}
//		set {
//			this.valueField = value;
//		}
//	}
//}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class project {
    
    private string nameField;
    
    private string statusField;
    
    private projectCreatedon[] createdonField;
    
    private id[] idField;
    
    private projectLastchangedon[] lastchangedonField;
    
    private projectCompany[] companyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("created-on", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public projectCreatedon[] createdon {
        get {
            return this.createdonField;
        }
        set {
            this.createdonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id", IsNullable=true)]
    public id[] id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("last-changed-on", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public projectLastchangedon[] lastchangedon {
        get {
            return this.lastchangedonField;
        }
        set {
            this.lastchangedonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("company", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public projectCompany[] company {
        get {
            return this.companyField;
        }
        set {
            this.companyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class projectCreatedon {
    
    private string typeField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class projectLastchangedon {
    
    private string typeField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class projectCompany {
    
    private string nameField;
    
    private id[] idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id", IsNullable=true)]
    public id[] id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

///// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
//[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
//public partial class NewDataSet {
    
//	private object[] itemsField;
    
//	/// <remarks/>
//	[System.Xml.Serialization.XmlElementAttribute("id", typeof(id), IsNullable=true)]
//	[System.Xml.Serialization.XmlElementAttribute("project", typeof(project))]
//	public object[] Items {
//		get {
//			return this.itemsField;
//		}
//		set {
//			this.itemsField = value;
//		}
//	}
//}
