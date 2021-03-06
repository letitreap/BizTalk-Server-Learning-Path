namespace WorkingWithConditions._02_CommonConditions {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://WorkingWithConditions.CommonConditionsSource",@"CommonConditionsSource")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CommonConditionsSource"})]
    public sealed class CommonConditionsSource : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://WorkingWithConditions.CommonConditionsSource"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://WorkingWithConditions.CommonConditionsSource"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CommonConditionsSource"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""MapElemBaseCondition"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Number"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""MapRecordBaseCondition"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Number"" type=""xs:int"" />
              <xs:element name=""Name"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CommonConditionsSource() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CommonConditionsSource";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
