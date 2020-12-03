using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDatos
{
    public class ClaseEntradaSalidaNuevo
    {
        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class MENSAJEREQ_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private INTEGRACIONREQ_Type iNTEGREQField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public INTEGRACIONREQ_Type INTEGREQ
            {
                get
                {
                    return this.iNTEGREQField;
                }
                set
                {
                    this.iNTEGREQField = value;
                    this.RaisePropertyChanged("INTEGREQ");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class INTEGRACIONREQ_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private CABECERA_Type cABECERAField;

            private DETALLE_Type dETALLEField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public CABECERA_Type CABECERA
            {
                get
                {
                    return this.cABECERAField;
                }
                set
                {
                    this.cABECERAField = value;
                    this.RaisePropertyChanged("CABECERA");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public DETALLE_Type DETALLE
            {
                get
                {
                    return this.dETALLEField;
                }
                set
                {
                    this.dETALLEField = value;
                    this.RaisePropertyChanged("DETALLE");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/")]
        public partial class CABECERA_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string cOD_SERVICIOField;

            private string aPP_CONSUMIDORAField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string COD_SERVICIO
            {
                get
                {
                    return this.cOD_SERVICIOField;
                }
                set
                {
                    this.cOD_SERVICIOField = value;
                    this.RaisePropertyChanged("COD_SERVICIO");
                }
            }


            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public string APP_CONSUMIDORA
            {
                get
                {
                    return this.aPP_CONSUMIDORAField;
                }
                set
                {
                    this.aPP_CONSUMIDORAField = value;
                    this.RaisePropertyChanged("APP_CONSUMIDORA");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class AddInvoiceXMLResponseDetail_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string idProcesoField;

            private string resultCodeField;

            private string messageField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 0)]
            public string idProceso
            {
                get
                {
                    return this.idProcesoField;
                }
                set
                {
                    this.idProcesoField = value;
                    this.RaisePropertyChanged("idProceso");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 1)]
            public string idPadre
            {
                get
                {
                    return this.resultCodeField;
                }
                set
                {
                    this.resultCodeField = value;
                    this.RaisePropertyChanged("resultCode");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            public string message
            {
                get
                {
                    return this.messageField;
                }
                set
                {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class AddInvoiceXMLResponse_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private AddInvoiceXMLResponseDetail_Type addInvoiceXMLResponseDetailField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public AddInvoiceXMLResponseDetail_Type addInvoiceXMLResponseDetail
            {
                get
                {
                    return this.addInvoiceXMLResponseDetailField;
                }
                set
                {
                    this.addInvoiceXMLResponseDetailField = value;
                    this.RaisePropertyChanged("addInvoiceXMLResponseDetail");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class DATOSRes_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private AddInvoiceXMLResponse_Type addInvoiceXMLResponseField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public AddInvoiceXMLResponse_Type addInvoiceXMLResponse
            {
                get
                {
                    return this.addInvoiceXMLResponseField;
                }
                set
                {
                    this.addInvoiceXMLResponseField = value;
                    this.RaisePropertyChanged("addInvoiceXMLResponse");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class DETALLERes_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private DATOSRes_Type dATOSField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public DATOSRes_Type DATOS
            {
                get
                {
                    return this.dATOSField;
                }
                set
                {
                    this.dATOSField = value;
                    this.RaisePropertyChanged("DATOS");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb")]
        public partial class CABECERARes_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string cOD_SERVICIOField;

            private string aPP_CONSUMIDORAField;

            private string tIP_RESPUESTAField;

            private string cOD_RESPUESTAField;

            private string dES_RESPUESTAField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string COD_SERVICIO
            {
                get
                {
                    return this.cOD_SERVICIOField;
                }
                set
                {
                    this.cOD_SERVICIOField = value;
                    this.RaisePropertyChanged("COD_SERVICIO");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public string APP_CONSUMIDORA
            {
                get
                {
                    return this.aPP_CONSUMIDORAField;
                }
                set
                {
                    this.aPP_CONSUMIDORAField = value;
                    this.RaisePropertyChanged("APP_CONSUMIDORA");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            public string TIP_RESPUESTA
            {
                get
                {
                    return this.tIP_RESPUESTAField;
                }
                set
                {
                    this.tIP_RESPUESTAField = value;
                    this.RaisePropertyChanged("TIP_RESPUESTA");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
            public string COD_RESPUESTA
            {
                get
                {
                    return this.cOD_RESPUESTAField;
                }
                set
                {
                    this.cOD_RESPUESTAField = value;
                    this.RaisePropertyChanged("COD_RESPUESTA");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
            public string DES_RESPUESTA
            {
                get
                {
                    return this.dES_RESPUESTAField;
                }
                set
                {
                    this.dES_RESPUESTAField = value;
                    this.RaisePropertyChanged("DES_RESPUESTA");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class INTEGRACIONRES_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private CABECERARes_Type cABECERAField;

            private DETALLERes_Type dETALLEField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public CABECERARes_Type CABECERA
            {
                get
                {
                    return this.cABECERAField;
                }
                set
                {
                    this.cABECERAField = value;
                    this.RaisePropertyChanged("CABECERA");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public DETALLERes_Type DETALLE
            {
                get
                {
                    return this.dETALLEField;
                }
                set
                {
                    this.dETALLEField = value;
                    this.RaisePropertyChanged("DETALLE");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class MENSAJERES_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private INTEGRACIONRES_Type iNTEGRESField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public INTEGRACIONRES_Type INTEGRES
            {
                get
                {
                    return this.iNTEGRESField;
                }
                set
                {
                    this.iNTEGRESField = value;
                    this.RaisePropertyChanged("INTEGRES");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class InvoiceXML_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string nameField;

            private byte[] fileXmlField;

            private string additionalField1Field;

            private string additionalField2Field;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "base64Binary", Order = 1)]
            public byte[] fileXml
            {
                get
                {
                    return this.fileXmlField;
                }
                set
                {
                    this.fileXmlField = value;
                    this.RaisePropertyChanged("fileXml");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            public string additionalField1
            {
                get
                {
                    return this.additionalField1Field;
                }
                set
                {
                    this.additionalField1Field = value;
                    this.RaisePropertyChanged("additionalField1");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
            public string additionalField2
            {
                get
                {
                    return this.additionalField2Field;
                }
                set
                {
                    this.additionalField2Field = value;
                    this.RaisePropertyChanged("additionalField2");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class ProcessDetail_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string processNumberField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 0)]
            public string processNumber
            {
                get
                {
                    return this.processNumberField;
                }
                set
                {
                    this.processNumberField = value;
                    this.RaisePropertyChanged("processNumber");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class Consumer_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private string typeField;

            private string participantCodeField;

            private string idPadreField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 1)]
            public string participantCode
            {
                get
                {
                    return this.participantCodeField;
                }
                set
                {
                    this.participantCodeField = value;
                    this.RaisePropertyChanged("participantCode");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 2)]
            public string idPadre
            {
                get
                {
                    return this.idPadreField;
                }
                set
                {
                    this.idPadreField = value;
                    this.RaisePropertyChanged("idPadre");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class AddInvoiceXMLRequestDetail_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private Consumer_Type consumerField;

            private ProcessDetail_Type processDetailField;

            private InvoiceXML_Type[] invoiceXMLDetailField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public Consumer_Type consumer
            {
                get
                {
                    return this.consumerField;
                }
                set
                {
                    this.consumerField = value;
                    this.RaisePropertyChanged("consumer");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
            public ProcessDetail_Type processDetail
            {
                get
                {
                    return this.processDetailField;
                }
                set
                {
                    this.processDetailField = value;
                    this.RaisePropertyChanged("processDetail");
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
            [System.Xml.Serialization.XmlArrayItemAttribute("invoiceXML", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
            public InvoiceXML_Type[] invoiceXMLDetail
            {
                get
                {
                    return this.invoiceXMLDetailField;
                }
                set
                {
                    this.invoiceXMLDetailField = value;
                    this.RaisePropertyChanged("invoiceXMLDetail");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class AddInvoiceXMLRequest_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private AddInvoiceXMLRequestDetail_Type addInvoiceXMLRequestDetailField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public AddInvoiceXMLRequestDetail_Type addInvoiceXMLRequestDetail
            {
                get
                {
                    return this.addInvoiceXMLRequestDetailField;
                }
                set
                {
                    this.addInvoiceXMLRequestDetailField = value;
                    this.RaisePropertyChanged("addInvoiceXMLRequestDetail");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class DATOS_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private AddInvoiceXMLRequest_Type addInvoiceXMLRequestField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public AddInvoiceXMLRequest_Type addInvoiceXMLRequest
            {
                get
                {
                    return this.addInvoiceXMLRequestField;
                }
                set
                {
                    this.addInvoiceXMLRequestField = value;
                    this.RaisePropertyChanged("addInvoiceXMLRequest");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3130.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cavali.com.pe/ib/esb/srv04002")]
        public partial class DETALLE_Type : object, System.ComponentModel.INotifyPropertyChanged
        {

            private DATOS_Type dATOSField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
            public DATOS_Type DATOS
            {
                get
                {
                    return this.dATOSField;
                }
                set
                {
                    this.dATOSField = value;
                    this.RaisePropertyChanged("DATOS");
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

            protected void RaisePropertyChanged(string propertyName)
            {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null))
                {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }

    }
}
