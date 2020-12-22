using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

using Energistics.DataAccess.RESQML210.ComponentSchemas;
using Energistics.DataAccess.RESQML210.ReferenceData;
using Energistics.DataAccess.Reflection;
using Energistics.DataAccess.Validation;

namespace Energistics.DataAccess.RESQML210
{
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractOrganizationInterpretation xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractStratigraphicOrganizationInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicOccurrenceInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicColumnRankInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(RockFluidOrganizationInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuralOrganizationInterpretation))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractOrganizationInterpretation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractOrganizationInterpretation xsd type.")]
        public abstract partial class AbstractOrganizationInterpretation : AbstractFeatureInterpretation, INotifyPropertyChanged
        {

            /// <summary>
            /// ContactInterpretation property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "AbstractContactInterpretationPart")]
            [XmlElement("ContactInterpretation")]
            public List<AbstractContactInterpretationPart> ContactInterpretation
            {
                get
                {
                    return ContactInterpretationField;
                }
                set
                {
                    ContactInterpretationField = value;
                    NotifyPropertyChanged("ContactInterpretation");
                }
            }

            /// <summary>
            /// bool to indicate if ContactInterpretation has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ContactInterpretationSpecified
            {
                get
                {
                    if (ContactInterpretationField != null)
                        return ContactInterpretationField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<AbstractContactInterpretationPart> ContactInterpretationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractStratigraphicOrganizationInterpretation xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicOccurrenceInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicColumnRankInterpretation))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractStratigraphicOrganizationInterpretation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractStratigraphicOrganizationInterpretation xsd type.")]
        public abstract partial class AbstractStratigraphicOrganizationInterpretation : AbstractOrganizationInterpretation, INotifyPropertyChanged
        {

            /// <summary>
            /// OrderingCriteria property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "OrderingCriteria")]
            [XmlElement("OrderingCriteria")]
            public OrderingCriteria? OrderingCriteria
            {
                get
                {
                    return OrderingCriteriaField;
                }
                set
                {
                    OrderingCriteriaField = value;
                    this.OrderingCriteriaSpecified = true;
                    NotifyPropertyChanged("OrderingCriteria");
                }
            }


            private bool OrderingCriteriaSpecifiedField = false;

            /// <summary>
            /// OrderingCriteriaSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool OrderingCriteriaSpecified
            {
                get
                {
                    return OrderingCriteriaSpecifiedField;
                }
                set
                {
                    OrderingCriteriaSpecifiedField = value;
                    NotifyPropertyChanged("OrderingCriteriaSpecified");
                }
            }

            private OrderingCriteria? OrderingCriteriaField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Boolean_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Boolean_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
        [Description("This class represents the Boolean_PropertyType xsd type.")]
        public partial class Boolean_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Boolean property
            /// </summary>

            [XmlElement("Boolean")]
            public bool? Boolean
            {
                get
                {
                    return BooleanField;
                }
                set
                {
                    BooleanField = value;
                    NotifyPropertyChanged("Boolean");
                }
            }

            private bool? BooleanField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractObject_Type xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_Result_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Series_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_OnlineResource_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Address_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Telephone_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Contact_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_ResponsibleParty_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Date_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CI_Citation_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(MD_Identifier_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_Element_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_PositionalAccuracy_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_VerticalExtent_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_TemporalExtent_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractEX_GeographicExtent_Type))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EX_Extent_Type))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractObject_Type", Namespace = "http://www.isotc211.org/2005/gco")]
        [Description("This class represents the AbstractObject_Type xsd type.")]
        public abstract partial class AbstractObject_Type : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// id property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "ID")]
            [XmlAttribute("id")]

            public string Id
            {
                get
                {
                    return idField;
                }
                set
                {
                    idField = value;
                    NotifyPropertyChanged("Id");
                }
            }

            private string idField;

            /// <summary>
            /// uuid property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuid")]

            public string Uuid
            {
                get
                {
                    return uuidField;
                }
                set
                {
                    uuidField = value;
                    NotifyPropertyChanged("Uuid");
                }
            }

            private string uuidField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractLocal3dCrs xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocalTime3dCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocalDepth3dCrs))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractLocal3dCrs", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the AbstractLocal3dCrs xsd type.")]
        public abstract partial class AbstractLocal3dCrs : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {

            /// <summary>
            /// YOffset property
            /// </summary>
            [Required]
            [Description("The Y offset of the origin of the local areal axes relative to the projected CRS origin. BUSINESS RULE: The value MUST represent the second axis of the coordinate system. The unit of measure is defined by the unit of measure for the projected 2D CRS.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("YOffset")]
            public double? YOffset
            {
                get
                {
                    return YOffsetField;
                }
                set
                {
                    YOffsetField = value;
                    NotifyPropertyChanged("YOffset");
                }
            }

            private double? YOffsetField;

            /// <summary>
            /// ZOffset property
            /// </summary>
            [Required]
            [Description("The Z offset of the origin of the local vertical axis relative to the vertical CRS origin. According to CRS type (depth or time) it corresponds to the depth or time datum.  BUSINESS RULE: The value MUST represent the third axis of the coordinate system. The unit of measure is defined by the unit of measure for the vertical CRS.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("ZOffset")]
            public double? ZOffset
            {
                get
                {
                    return ZOffsetField;
                }
                set
                {
                    ZOffsetField = value;
                    NotifyPropertyChanged("ZOffset");
                }
            }

            private double? ZOffsetField;

            /// <summary>
            /// ArealRotation property
            /// </summary>
            [Required]
            [Description("The rotation of the local Y axis relative to the projected Y axis.   - A positive value indicates a clockwise rotation from the projected Y axis.   - A negative value indicates a counter-clockwise rotation form the projected Y axis.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "PlaneAngleMeasure")]
            [XmlElement("ArealRotation")]
            public PlaneAngleMeasure ArealRotation
            {
                get
                {
                    return ArealRotationField;
                }
                set
                {
                    ArealRotationField = value;
                    NotifyPropertyChanged("ArealRotation");
                }
            }

            private PlaneAngleMeasure ArealRotationField;

            /// <summary>
            /// ProjectedAxisOrder property
            /// </summary>
            [Required]
            [Description("Defines the coordinate system axis order of the global projected CRS when the projected CRS is an unknown CRS, else it must correspond to the axis order of the projected CRS.")]
            [EnergisticsDataTypeAttribute(DataType = "AxisOrder2d")]
            [XmlElement("ProjectedAxisOrder")]
            public AxisOrder2d? ProjectedAxisOrder
            {
                get
                {
                    return ProjectedAxisOrderField;
                }
                set
                {
                    ProjectedAxisOrderField = value;
                    this.ProjectedAxisOrderSpecified = true;
                    NotifyPropertyChanged("ProjectedAxisOrder");
                }
            }


            private bool ProjectedAxisOrderSpecifiedField = false;

            /// <summary>
            /// ProjectedAxisOrderSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool ProjectedAxisOrderSpecified
            {
                get
                {
                    return ProjectedAxisOrderSpecifiedField;
                }
                set
                {
                    ProjectedAxisOrderSpecifiedField = value;
                    NotifyPropertyChanged("ProjectedAxisOrderSpecified");
                }
            }

            private AxisOrder2d? ProjectedAxisOrderField;

            /// <summary>
            /// ProjectedUomCustomDict property
            /// </summary>
            [Description("A reference to the dictionary where the projected UOM is defined.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("ProjectedUomCustomDict")]
            public DataObjectReference ProjectedUomCustomDict
            {
                get
                {
                    return ProjectedUomCustomDictField;
                }
                set
                {
                    ProjectedUomCustomDictField = value;
                    NotifyPropertyChanged("ProjectedUomCustomDict");
                }
            }

            private DataObjectReference ProjectedUomCustomDictField;

            /// <summary>
            /// ProjectedUom property
            /// </summary>
            [Required]
            [Description("Unit of measure of the associated projected CRS. BUSINESS RULE: When the projected CRS is well known, it must have the same UOM as the UOM defined by the well-known projected CRS. Explanation: A well-known CRS already defines the UOM. When you indicate that you use a CRS EPSG code, e.g., 7500, if you go to the EPSG database, you find the constrained UOM. This approach removes the need to depend on an EPSG database (or other external database), so RESQML copies the UOM of the well-known CRS into the RESQML CRS.")]
            [EnergisticsDataTypeAttribute(DataType = "LengthUomExt")]
            [XmlElement("ProjectedUom")]
            public ExtensibleEnum<LengthUom>? ProjectedUom
            {
                get
                {
                    return ProjectedUomField;
                }
                set
                {
                    ProjectedUomField = value;
                    NotifyPropertyChanged("ProjectedUom");
                }
            }

            private ExtensibleEnum<LengthUom>? ProjectedUomField;

            /// <summary>
            /// VerticalUom property
            /// </summary>
            [Required]
            [Description("Unit of measure of the associated vertical CRS. BUSINESS RULE: When the vertical CRS is well known, it must have the same UOM defined by the well-known vertical CRS. Explanation: See ProjectedUom.")]
            [EnergisticsDataTypeAttribute(DataType = "LengthUomExt")]
            [XmlElement("VerticalUom")]
            public ExtensibleEnum<LengthUom>? VerticalUom
            {
                get
                {
                    return VerticalUomField;
                }
                set
                {
                    VerticalUomField = value;
                    NotifyPropertyChanged("VerticalUom");
                }
            }

            private ExtensibleEnum<LengthUom>? VerticalUomField;

            /// <summary>
            /// VerticalUomCustomDict property
            /// </summary>
            [Description("A reference to the dictionary where the vertical UOM is defined.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("VerticalUomCustomDict")]
            public DataObjectReference VerticalUomCustomDict
            {
                get
                {
                    return VerticalUomCustomDictField;
                }
                set
                {
                    VerticalUomCustomDictField = value;
                    NotifyPropertyChanged("VerticalUomCustomDict");
                }
            }

            private DataObjectReference VerticalUomCustomDictField;

            /// <summary>
            /// ZIncreasingDownward property
            /// </summary>
            [Required]
            [Description("Indicates that Z values correspond to depth values and are increasing downward, as opposite to elevation values increasing upward. BUSINESS RULE: When the vertical CRS is already defined somewhere else (e.g., in a well-known source), it must correspond to the axis orientation of the vertical CRS.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("ZIncreasingDownward")]
            public bool? ZIncreasingDownward
            {
                get
                {
                    return ZIncreasingDownwardField;
                }
                set
                {
                    ZIncreasingDownwardField = value;
                    NotifyPropertyChanged("ZIncreasingDownward");
                }
            }

            private bool? ZIncreasingDownwardField;

            /// <summary>
            /// XOffset property
            /// </summary>
            [Required]
            [Description("The X location of the origin of the local areal axes relative to the projected CRS origin. BUSINESS RULE: The value MUST represent the first axis of the coordinate system. The unit of measure is defined by the unit of measure for the projected 2D CRS.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("XOffset")]
            public double? XOffset
            {
                get
                {
                    return XOffsetField;
                }
                set
                {
                    XOffsetField = value;
                    NotifyPropertyChanged("XOffset");
                }
            }

            private double? XOffsetField;

            /// <summary>
            /// ProjectedCrs property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "AbstractProjectedCrs")]
            [XmlElement("ProjectedCrs")]
            public AbstractProjectedCrs ProjectedCrs
            {
                get
                {
                    return ProjectedCrsField;
                }
                set
                {
                    ProjectedCrsField = value;
                    NotifyPropertyChanged("ProjectedCrs");
                }
            }

            private AbstractProjectedCrs ProjectedCrsField;

            /// <summary>
            /// VerticalCrs property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "AbstractVerticalCrs")]
            [XmlElement("VerticalCrs")]
            public AbstractVerticalCrs VerticalCrs
            {
                get
                {
                    return VerticalCrsField;
                }
                set
                {
                    VerticalCrsField = value;
                    NotifyPropertyChanged("VerticalCrs");
                }
            }

            private AbstractVerticalCrs VerticalCrsField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the GeologicTime xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeologicTime", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the GeologicTime xsd type.")]
        public partial class GeologicTime : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// AgeOffsetAttribute property
            /// </summary>
            [Description("A Value in Years of the Age Offset between the DateTime Attribute value and the DateTime of a GeologicalEvent Occurrence. This value must be POSITIVE when it represents a Geological Event in The past.")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("AgeOffsetAttribute")]
            public long? AgeOffsetAttribute
            {
                get
                {
                    return AgeOffsetAttributeField;
                }
                set
                {
                    AgeOffsetAttributeField = value;
                    this.AgeOffsetAttributeSpecified = true;
                    NotifyPropertyChanged("AgeOffsetAttribute");
                }
            }

            private long? AgeOffsetAttributeField;

            /// <summary>
            /// AgeOffsetAttributeSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool AgeOffsetAttributeSpecified
            {
                get
                {
                    return AgeOffsetAttributeSpecifiedField;
                }
                set
                {
                    AgeOffsetAttributeSpecifiedField = value;
                    NotifyPropertyChanged("AgeOffsetAttributeSpecified");
                }
            }

            private bool AgeOffsetAttributeSpecifiedField;

            /// <summary>
            /// DateTime property
            /// </summary>
            [Required]
            [Description("A date, which can be represented according to the W3CDTF format.")]
            [EnergisticsDataTypeAttribute(DataType = "dateTime")]
            [XmlElement("DateTime")]
            public DateTime? DateTime
            {
                get
                {
                    return DateTimeField;
                }
                set
                {
                    DateTimeField = value;
                    NotifyPropertyChanged("DateTime");
                }
            }

            private DateTime? DateTimeField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TimeSeriesParentage xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TimeSeriesParentage", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the TimeSeriesParentage xsd type.")]
        public partial class TimeSeriesParentage : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// HasOverlap property
            /// </summary>
            [Required]
            [Description("Used to indicate that a time series overlaps with its parent time series, e.g., as may be done for simulation studies, where the end state of one calculation is the initial state of the next.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("HasOverlap")]
            public bool? HasOverlap
            {
                get
                {
                    return HasOverlapField;
                }
                set
                {
                    HasOverlapField = value;
                    NotifyPropertyChanged("HasOverlap");
                }
            }

            private bool? HasOverlapField;

            /// <summary>
            /// ParentTimeIndex property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TimeIndex")]
            [XmlElement("ParentTimeIndex")]
            public TimeIndex ParentTimeIndex
            {
                get
                {
                    return ParentTimeIndexField;
                }
                set
                {
                    ParentTimeIndexField = value;
                    NotifyPropertyChanged("ParentTimeIndex");
                }
            }

            private TimeIndex ParentTimeIndexField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TimeIndex xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TimeIndex", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the TimeIndex xsd type.")]
        public partial class TimeIndex : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Index property
            /// </summary>
            [Required]
            [Description("The index of the time in the time series.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("Index")]
            public long? Index
            {
                get
                {
                    return IndexField;
                }
                set
                {
                    IndexField = value;
                    NotifyPropertyChanged("Index");
                }
            }

            private long? IndexField;

            /// <summary>
            /// TimeSeries property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("TimeSeries")]
            public DataObjectReference TimeSeries
            {
                get
                {
                    return TimeSeriesField;
                }
                set
                {
                    TimeSeriesField = value;
                    NotifyPropertyChanged("TimeSeries");
                }
            }

            private DataObjectReference TimeSeriesField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ElementIdentity xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ElementIdentity", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ElementIdentity xsd type.")]
        public partial class ElementIdentity : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// ElementIndices property
            /// </summary>
            [Description("Indicates which elements are identical based on their indices in the (sub)representation. If not given, then the selected indexable elements of each of the selected representations are identical at the element by element level.  BUSINESS RULE: The number of identical elements must be equal to identicalElementCount for each representation.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ElementIndices")]
            public AbstractIntegerArray ElementIndices
            {
                get
                {
                    return ElementIndicesField;
                }
                set
                {
                    ElementIndicesField = value;
                    NotifyPropertyChanged("ElementIndices");
                }
            }

            private AbstractIntegerArray ElementIndicesField;

            /// <summary>
            /// IdentityKind property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "IdentityKind")]
            [XmlElement("IdentityKind")]
            public IdentityKind? IdentityKind
            {
                get
                {
                    return IdentityKindField;
                }
                set
                {
                    IdentityKindField = value;
                    this.IdentityKindSpecified = true;
                    NotifyPropertyChanged("IdentityKind");
                }
            }


            private bool IdentityKindSpecifiedField = false;

            /// <summary>
            /// IdentityKindSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool IdentityKindSpecified
            {
                get
                {
                    return IdentityKindSpecifiedField;
                }
                set
                {
                    IdentityKindSpecifiedField = value;
                    NotifyPropertyChanged("IdentityKindSpecified");
                }
            }

            private IdentityKind? IdentityKindField;

            /// <summary>
            /// IndexableElement property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "IndexableElement")]
            [XmlElement("IndexableElement")]
            public IndexableElement? IndexableElement
            {
                get
                {
                    return IndexableElementField;
                }
                set
                {
                    IndexableElementField = value;
                    this.IndexableElementSpecified = true;
                    NotifyPropertyChanged("IndexableElement");
                }
            }


            private bool IndexableElementSpecifiedField = false;

            /// <summary>
            /// IndexableElementSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool IndexableElementSpecified
            {
                get
                {
                    return IndexableElementSpecifiedField;
                }
                set
                {
                    IndexableElementSpecifiedField = value;
                    NotifyPropertyChanged("IndexableElementSpecified");
                }
            }

            private IndexableElement? IndexableElementField;

            /// <summary>
            /// Representation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("Representation")]
            public DataObjectReference Representation
            {
                get
                {
                    return RepresentationField;
                }
                set
                {
                    RepresentationField = value;
                    NotifyPropertyChanged("Representation");
                }
            }

            private DataObjectReference RepresentationField;

            /// <summary>
            /// FromTimeIndex property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TimeIndex")]
            [XmlElement("FromTimeIndex")]
            public TimeIndex FromTimeIndex
            {
                get
                {
                    return FromTimeIndexField;
                }
                set
                {
                    FromTimeIndexField = value;
                    NotifyPropertyChanged("FromTimeIndex");
                }
            }

            private TimeIndex FromTimeIndexField;

            /// <summary>
            /// ToTimeIndex property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TimeIndex")]
            [XmlElement("ToTimeIndex")]
            public TimeIndex ToTimeIndex
            {
                get
                {
                    return ToTimeIndexField;
                }
                set
                {
                    ToTimeIndexField = value;
                    NotifyPropertyChanged("ToTimeIndex");
                }
            }

            private TimeIndex ToTimeIndexField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the RepresentationIdentity xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RepresentationIdentity", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the RepresentationIdentity xsd type.")]
        public partial class RepresentationIdentity : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// IdenticalElementCount property
            /// </summary>
            [Required]
            [Description("Number of elements within each representation for which a representation identity is specified.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("IdenticalElementCount")]
            public long? IdenticalElementCount
            {
                get
                {
                    return IdenticalElementCountField;
                }
                set
                {
                    IdenticalElementCountField = value;
                    NotifyPropertyChanged("IdenticalElementCount");
                }
            }

            private long? IdenticalElementCountField;

            /// <summary>
            /// AdditionalGridTopology property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "AdditionalGridTopology")]
            [XmlElement("AdditionalGridTopology")]
            public AdditionalGridTopology AdditionalGridTopology
            {
                get
                {
                    return AdditionalGridTopologyField;
                }
                set
                {
                    AdditionalGridTopologyField = value;
                    NotifyPropertyChanged("AdditionalGridTopology");
                }
            }

            private AdditionalGridTopology AdditionalGridTopologyField;

            /// <summary>
            /// ElementIdentity property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ElementIdentity")]
            [XmlElement("ElementIdentity")]
            public List<ElementIdentity> ElementIdentity
            {
                get
                {
                    return ElementIdentityField;
                }
                set
                {
                    ElementIdentityField = value;
                    NotifyPropertyChanged("ElementIdentity");
                }
            }

            /// <summary>
            /// bool to indicate if ElementIdentity has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ElementIdentitySpecified
            {
                get
                {
                    if (ElementIdentityField != null)
                        return ElementIdentityField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ElementIdentity> ElementIdentityField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AdditionalGridTopology xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdditionalGridTopology", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AdditionalGridTopology xsd type.")]
        public partial class AdditionalGridTopology : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// SplitEdges property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "SplitEdges")]
            [XmlElement("SplitEdges")]
            public SplitEdges SplitEdges
            {
                get
                {
                    return SplitEdgesField;
                }
                set
                {
                    SplitEdgesField = value;
                    NotifyPropertyChanged("SplitEdges");
                }
            }

            private SplitEdges SplitEdgesField;

            /// <summary>
            /// SplitNodePatch property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "SplitNodePatch")]
            [XmlElement("SplitNodePatch")]
            public SplitNodePatch SplitNodePatch
            {
                get
                {
                    return SplitNodePatchField;
                }
                set
                {
                    SplitNodePatchField = value;
                    NotifyPropertyChanged("SplitNodePatch");
                }
            }

            private SplitNodePatch SplitNodePatchField;

            /// <summary>
            /// SplitColumnEdges property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "SplitColumnEdges")]
            [XmlElement("SplitColumnEdges")]
            public SplitColumnEdges SplitColumnEdges
            {
                get
                {
                    return SplitColumnEdgesField;
                }
                set
                {
                    SplitColumnEdgesField = value;
                    NotifyPropertyChanged("SplitColumnEdges");
                }
            }

            private SplitColumnEdges SplitColumnEdgesField;

            /// <summary>
            /// UnstructuredColumnEdges property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "UnstructuredColumnEdges")]
            [XmlElement("UnstructuredColumnEdges")]
            public UnstructuredColumnEdges UnstructuredColumnEdges
            {
                get
                {
                    return UnstructuredColumnEdgesField;
                }
                set
                {
                    UnstructuredColumnEdgesField = value;
                    NotifyPropertyChanged("UnstructuredColumnEdges");
                }
            }

            private UnstructuredColumnEdges UnstructuredColumnEdgesField;

            /// <summary>
            /// SplitFaces property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "SplitFaces")]
            [XmlElement("SplitFaces")]
            public SplitFaces SplitFaces
            {
                get
                {
                    return SplitFacesField;
                }
                set
                {
                    SplitFacesField = value;
                    NotifyPropertyChanged("SplitFaces");
                }
            }

            private SplitFaces SplitFacesField;

            /// <summary>
            /// UnstructuredSubnodeTopology property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "UnstructuredSubnodeTopology")]
            [XmlElement("UnstructuredSubnodeTopology")]
            public UnstructuredSubnodeTopology UnstructuredSubnodeTopology
            {
                get
                {
                    return UnstructuredSubnodeTopologyField;
                }
                set
                {
                    UnstructuredSubnodeTopologyField = value;
                    NotifyPropertyChanged("UnstructuredSubnodeTopology");
                }
            }

            private UnstructuredSubnodeTopology UnstructuredSubnodeTopologyField;

            /// <summary>
            /// ColumnLayerSubnodeTopology property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "ColumnLayerSubnodeTopology")]
            [XmlElement("ColumnLayerSubnodeTopology")]
            public ColumnLayerSubnodeTopology ColumnLayerSubnodeTopology
            {
                get
                {
                    return ColumnLayerSubnodeTopologyField;
                }
                set
                {
                    ColumnLayerSubnodeTopologyField = value;
                    NotifyPropertyChanged("ColumnLayerSubnodeTopology");
                }
            }

            private ColumnLayerSubnodeTopology ColumnLayerSubnodeTopologyField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SplitEdges xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SplitEdges", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SplitEdges xsd type.")]
        public partial class SplitEdges : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of edges. Must be positive.
            /// </summary>
            [Required]
            [Description("Number of edges. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// Parent unsplit edge index for each of the additional split edges.
            /// </summary>
            [Required]
            [Description("Parent unsplit edge index for each of the additional split edges.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ParentEdgeIndices")]
            public AbstractIntegerArray ParentEdgeIndices
            {
                get
                {
                    return ParentEdgeIndicesField;
                }
                set
                {
                    ParentEdgeIndicesField = value;
                    NotifyPropertyChanged("ParentEdgeIndices");
                }
            }

            private AbstractIntegerArray ParentEdgeIndicesField;

            /// <summary>
            /// Association of faces with the split edges, used to infer continuity of property, geometry, or interpretation with an attachment kind of edges.
            /// </summary>
            [Required]
            [Description("Association of faces with the split edges, used to infer continuity of property, geometry, or interpretation with an attachment kind of edges.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("FacesPerSplitEdge")]
            public JaggedArray FacesPerSplitEdge
            {
                get
                {
                    return FacesPerSplitEdgeField;
                }
                set
                {
                    FacesPerSplitEdgeField = value;
                    NotifyPropertyChanged("FacesPerSplitEdge");
                }
            }

            private JaggedArray FacesPerSplitEdgeField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the JaggedArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "JaggedArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the JaggedArray xsd type.")]
        public partial class JaggedArray : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Elements property
            /// </summary>
            [Required]
            [Description("1D array of elements containing the aggregation of individual array data.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractValueArray")]
            [XmlElement("Elements")]
            public AbstractValueArray Elements
            {
                get
                {
                    return ElementsField;
                }
                set
                {
                    ElementsField = value;
                    NotifyPropertyChanged("Elements");
                }
            }

            private AbstractValueArray ElementsField;

            /// <summary>
            /// CumulativeLength property
            /// </summary>
            [Required]
            [Description("1D array of cumulative lengths to the end of the current sub-array. Each cumulative length is also equal to the index of the first element of the next sub-array, i.e., the index in the elements array for which the next variable length sub-array begins.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("CumulativeLength")]
            public AbstractIntegerArray CumulativeLength
            {
                get
                {
                    return CumulativeLengthField;
                }
                set
                {
                    CumulativeLengthField = value;
                    NotifyPropertyChanged("CumulativeLength");
                }
            }

            private AbstractIntegerArray CumulativeLengthField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SplitNodePatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SplitNodePatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SplitNodePatch xsd type.")]
        public partial class SplitNodePatch : Patch, INotifyPropertyChanged
        {

            /// <summary>
            /// Count property
            /// </summary>
            [Required]
            [Description("Number of additional split nodes. Count must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// ParentNodeIndices property
            /// </summary>
            [Required]
            [Description("Parent coordinate line node index for each of the split nodes. Used to implicitly define cell geometry.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ParentNodeIndices")]
            public AbstractIntegerArray ParentNodeIndices
            {
                get
                {
                    return ParentNodeIndicesField;
                }
                set
                {
                    ParentNodeIndicesField = value;
                    NotifyPropertyChanged("ParentNodeIndices");
                }
            }

            private AbstractIntegerArray ParentNodeIndicesField;

            /// <summary>
            /// CellsPerSplitNode property
            /// </summary>
            [Required]
            [Description("Cell indices for each of the split nodes. Used to implicitly define cell geometry. List-of-lists construction used to support split nodes shared between multiple cells.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("CellsPerSplitNode")]
            public JaggedArray CellsPerSplitNode
            {
                get
                {
                    return CellsPerSplitNodeField;
                }
                set
                {
                    CellsPerSplitNodeField = value;
                    NotifyPropertyChanged("CellsPerSplitNode");
                }
            }

            private JaggedArray CellsPerSplitNodeField;

            /// <summary>
            /// SplitFaces property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "SplitFaces")]
            [XmlElement("SplitFaces")]
            public SplitFaces SplitFaces
            {
                get
                {
                    return SplitFacesField;
                }
                set
                {
                    SplitFacesField = value;
                    NotifyPropertyChanged("SplitFaces");
                }
            }

            private SplitFaces SplitFacesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SplitFaces xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SplitFaces", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SplitFaces xsd type.")]
        public partial class SplitFaces : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Count property
            /// </summary>
            [Required]
            [Description("Number of additional split faces. Count must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// ParentFaceIndices property
            /// </summary>
            [Required]
            [Description("Parent unsplit face index for each of the additional split faces.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ParentFaceIndices")]
            public AbstractIntegerArray ParentFaceIndices
            {
                get
                {
                    return ParentFaceIndicesField;
                }
                set
                {
                    ParentFaceIndicesField = value;
                    NotifyPropertyChanged("ParentFaceIndices");
                }
            }

            private AbstractIntegerArray ParentFaceIndicesField;

            /// <summary>
            /// CellPerSplitFace property
            /// </summary>
            [Required]
            [Description("Cell index for each split face. Used to implicitly define cell geometry.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("CellPerSplitFace")]
            public AbstractIntegerArray CellPerSplitFace
            {
                get
                {
                    return CellPerSplitFaceField;
                }
                set
                {
                    CellPerSplitFaceField = value;
                    NotifyPropertyChanged("CellPerSplitFace");
                }
            }

            private AbstractIntegerArray CellPerSplitFaceField;

            /// <summary>
            /// SplitEdges property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "SplitEdges")]
            [XmlElement("SplitEdges")]
            public SplitEdges SplitEdges
            {
                get
                {
                    return SplitEdgesField;
                }
                set
                {
                    SplitEdgesField = value;
                    NotifyPropertyChanged("SplitEdges");
                }
            }

            private SplitEdges SplitEdgesField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Patch xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grid2dPatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredGpGridPatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredColumnLayerGpGridPatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TruncationCellPatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IjkGpGridPatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolylineSetPatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SplitNodePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubnodePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VariableSubnodePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UniformSubnodePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ColumnSubnodePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Patch1d))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrianglePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(NodePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactPatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubRepresentationPatch))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Patch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Patch xsd type.")]
        public partial class Patch : Object, INotifyPropertyChanged
        {



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Grid2dPatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Grid2dPatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Grid2dPatch xsd type.")]
        public partial class Grid2dPatch : Patch, INotifyPropertyChanged
        {

            /// <summary>
            /// FastestAxisCount property
            /// </summary>
            [Required]
            [Description("The number of nodes in the fastest direction.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("FastestAxisCount")]
            public long? FastestAxisCount
            {
                get
                {
                    return FastestAxisCountField;
                }
                set
                {
                    FastestAxisCountField = value;
                    NotifyPropertyChanged("FastestAxisCount");
                }
            }

            private long? FastestAxisCountField;

            /// <summary>
            /// SlowestAxisCount property
            /// </summary>
            [Required]
            [Description("The number of nodes in the slowest direction.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("SlowestAxisCount")]
            public long? SlowestAxisCount
            {
                get
                {
                    return SlowestAxisCountField;
                }
                set
                {
                    SlowestAxisCountField = value;
                    NotifyPropertyChanged("SlowestAxisCount");
                }
            }

            private long? SlowestAxisCountField;

            /// <summary>
            /// Geometry property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "PointGeometry")]
            [XmlElement("Geometry")]
            public PointGeometry Geometry
            {
                get
                {
                    return GeometryField;
                }
                set
                {
                    GeometryField = value;
                    NotifyPropertyChanged("Geometry");
                }
            }

            private PointGeometry GeometryField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the PointGeometry xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractColumnLayerGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredColumnLayerGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IjkGridGeometry))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PointGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the PointGeometry xsd type.")]
        public partial class PointGeometry : AbstractGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// Points property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "AbstractPoint3dArray")]
            [XmlElement("Points")]
            public AbstractPoint3dArray Points
            {
                get
                {
                    return PointsField;
                }
                set
                {
                    PointsField = value;
                    NotifyPropertyChanged("Points");
                }
            }

            private AbstractPoint3dArray PointsField;

            /// <summary>
            /// SeismicCoordinates property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "AbstractSeismicCoordinates")]
            [XmlElement("SeismicCoordinates")]
            public AbstractSeismicCoordinates SeismicCoordinates
            {
                get
                {
                    return SeismicCoordinatesField;
                }
                set
                {
                    SeismicCoordinatesField = value;
                    NotifyPropertyChanged("SeismicCoordinates");
                }
            }

            private AbstractSeismicCoordinates SeismicCoordinatesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractSeismicCoordinates xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Seismic3dCoordinates))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Seismic2dCoordinates))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractSeismicCoordinates", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractSeismicCoordinates xsd type.")]
        public abstract partial class AbstractSeismicCoordinates : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// SeismicSupport property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("SeismicSupport")]
            public DataObjectReference SeismicSupport
            {
                get
                {
                    return SeismicSupportField;
                }
                set
                {
                    SeismicSupportField = value;
                    NotifyPropertyChanged("SeismicSupport");
                }
            }

            private DataObjectReference SeismicSupportField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Seismic3dCoordinates xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Seismic3dCoordinates", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Seismic3dCoordinates xsd type.")]
        public partial class Seismic3dCoordinates : AbstractSeismicCoordinates, INotifyPropertyChanged
        {

            /// <summary>
            /// The sequence of trace or inter-trace crossline positions that correspond to the geometry coordinates. BUSINESS RULE: Both sequences must be in the same order.
            /// </summary>
            [Required]
            [Description("The sequence of trace or inter-trace crossline positions that correspond to the geometry coordinates. BUSINESS RULE: Both sequences must be in the same order.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("CrosslineCoordinates")]
            public AbstractFloatingPointArray CrosslineCoordinates
            {
                get
                {
                    return CrosslineCoordinatesField;
                }
                set
                {
                    CrosslineCoordinatesField = value;
                    NotifyPropertyChanged("CrosslineCoordinates");
                }
            }

            private AbstractFloatingPointArray CrosslineCoordinatesField;

            /// <summary>
            /// The sequence of trace or inter-trace inline positions that correspond to the geometry coordinates. BUSINESS RULE: Both sequences must be in the same order.
            /// </summary>
            [Required]
            [Description("The sequence of trace or inter-trace inline positions that correspond to the geometry coordinates. BUSINESS RULE: Both sequences must be in the same order.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("InlineCoordinates")]
            public AbstractFloatingPointArray InlineCoordinates
            {
                get
                {
                    return InlineCoordinatesField;
                }
                set
                {
                    InlineCoordinatesField = value;
                    NotifyPropertyChanged("InlineCoordinates");
                }
            }

            private AbstractFloatingPointArray InlineCoordinatesField;

            /// <summary>
            /// The sequence of vertical sample or inter-sample positions that corresponds to the geometry coordinates. BUSINESS RULE: Sequence must be in the same order as the two previous ones.
            /// </summary>
            [Description("The sequence of vertical sample or inter-sample positions that corresponds to the geometry coordinates. BUSINESS RULE: Sequence must be in the same order as the two previous ones.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("VerticalCoordinates")]
            public AbstractFloatingPointArray VerticalCoordinates
            {
                get
                {
                    return VerticalCoordinatesField;
                }
                set
                {
                    VerticalCoordinatesField = value;
                    NotifyPropertyChanged("VerticalCoordinates");
                }
            }

            private AbstractFloatingPointArray VerticalCoordinatesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Seismic2dCoordinates xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Seismic2dCoordinates", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Seismic2dCoordinates xsd type.")]
        public partial class Seismic2dCoordinates : AbstractSeismicCoordinates, INotifyPropertyChanged
        {

            /// <summary>
            /// The sequence of trace or inter-trace positions that correspond to the geometry coordinates. BUSINESS RULE: Both sequences must be in the same order.
            /// </summary>
            [Required]
            [Description("The sequence of trace or inter-trace positions that correspond to the geometry coordinates. BUSINESS RULE: Both sequences must be in the same order.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("LineAbscissa")]
            public AbstractFloatingPointArray LineAbscissa
            {
                get
                {
                    return LineAbscissaField;
                }
                set
                {
                    LineAbscissaField = value;
                    NotifyPropertyChanged("LineAbscissa");
                }
            }

            private AbstractFloatingPointArray LineAbscissaField;

            /// <summary>
            /// The sequence of vertical sample or inter-sample positions that corresponds to the geometry coordinates. BUSINESS RULE: Sequence must be in the same order as the previous one.
            /// </summary>
            [Description("The sequence of vertical sample or inter-sample positions that corresponds to the geometry coordinates. BUSINESS RULE: Sequence must be in the same order as the previous one.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("VerticalCoordinates")]
            public AbstractFloatingPointArray VerticalCoordinates
            {
                get
                {
                    return VerticalCoordinatesField;
                }
                set
                {
                    VerticalCoordinatesField = value;
                    NotifyPropertyChanged("VerticalCoordinates");
                }
            }

            private AbstractFloatingPointArray VerticalCoordinatesField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractGridRepresentation xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Seismic3dPostStackRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GpGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTruncatedColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TruncatedUnstructuredColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TruncatedIjkGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IjkGridRepresentation))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractGridRepresentation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractGridRepresentation xsd type.")]
        public abstract partial class AbstractGridRepresentation : AbstractRepresentation, INotifyPropertyChanged
        {

            /// <summary>
            /// CellFluidPhaseUnits property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "CellFluidPhaseUnits")]
            [XmlElement("CellFluidPhaseUnits")]
            public CellFluidPhaseUnits CellFluidPhaseUnits
            {
                get
                {
                    return CellFluidPhaseUnitsField;
                }
                set
                {
                    CellFluidPhaseUnitsField = value;
                    NotifyPropertyChanged("CellFluidPhaseUnits");
                }
            }

            private CellFluidPhaseUnits CellFluidPhaseUnitsField;

            /// <summary>
            /// ParentWindow property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "AbstractParentWindow")]
            [XmlElement("ParentWindow")]
            public AbstractParentWindow ParentWindow
            {
                get
                {
                    return ParentWindowField;
                }
                set
                {
                    ParentWindowField = value;
                    NotifyPropertyChanged("ParentWindow");
                }
            }

            private AbstractParentWindow ParentWindowField;

            /// <summary>
            /// IntervalStratigraphicUnits property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "IntervalStratigraphicUnits")]
            [XmlElement("IntervalStratigraphicUnits")]
            public IntervalStratigraphicUnits IntervalStratigraphicUnits
            {
                get
                {
                    return IntervalStratigraphicUnitsField;
                }
                set
                {
                    IntervalStratigraphicUnitsField = value;
                    NotifyPropertyChanged("IntervalStratigraphicUnits");
                }
            }

            private IntervalStratigraphicUnits IntervalStratigraphicUnitsField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractGeometry xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractPlaneGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(HorizontalPlaneGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TiltedPlaneGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractParametricLineGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParametricLineGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParametricLineFromRepresentationGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SinglePointGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractColumnLayerGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredColumnLayerGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IjkGridGeometry))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractGeometry xsd type.")]
        public abstract partial class AbstractGeometry : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// TimeIndex property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TimeIndex")]
            [XmlElement("TimeIndex")]
            public TimeIndex TimeIndex
            {
                get
                {
                    return TimeIndexField;
                }
                set
                {
                    TimeIndexField = value;
                    NotifyPropertyChanged("TimeIndex");
                }
            }

            private TimeIndex TimeIndexField;

            /// <summary>
            /// LocalCrs property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("LocalCrs")]
            public DataObjectReference LocalCrs
            {
                get
                {
                    return LocalCrsField;
                }
                set
                {
                    LocalCrsField = value;
                    NotifyPropertyChanged("LocalCrs");
                }
            }

            private DataObjectReference LocalCrsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractPlaneGeometry xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(HorizontalPlaneGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TiltedPlaneGeometry))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractPlaneGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractPlaneGeometry xsd type.")]
        public abstract partial class AbstractPlaneGeometry : AbstractGeometry, INotifyPropertyChanged
        {


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the HorizontalPlaneGeometry xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "HorizontalPlaneGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the HorizontalPlaneGeometry xsd type.")]
        public partial class HorizontalPlaneGeometry : AbstractPlaneGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// Coordinate property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("Coordinate")]
            public double? Coordinate
            {
                get
                {
                    return CoordinateField;
                }
                set
                {
                    CoordinateField = value;
                    NotifyPropertyChanged("Coordinate");
                }
            }

            private double? CoordinateField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TiltedPlaneGeometry xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TiltedPlaneGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the TiltedPlaneGeometry xsd type.")]
        public partial class TiltedPlaneGeometry : AbstractPlaneGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// Plane property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ThreePoint3d")]
            [XmlArrayItem("ThreePoint3d")]
            [XmlArray("Plane")]
            public List<List<Point3d>> Plane
            {
                get
                {
                    return PlaneField;
                }
                set
                {
                    PlaneField = value;
                    NotifyPropertyChanged("Plane");
                }
            }

            /// <summary>
            /// bool to indicate if Plane has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool PlaneSpecified
            {
                get
                {
                    if (PlaneField != null)
                        return PlaneField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<List<Point3d>> PlaneField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractParametricLineGeometry xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParametricLineGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParametricLineFromRepresentationGeometry))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractParametricLineGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractParametricLineGeometry xsd type.")]
        public abstract partial class AbstractParametricLineGeometry : AbstractGeometry, INotifyPropertyChanged
        {


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ParametricLineGeometry xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ParametricLineGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ParametricLineGeometry xsd type.")]
        public partial class ParametricLineGeometry : AbstractParametricLineGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// An optional array of explicit control point parameters for the control points on the parametric line. Used only if control point parameters are present. NOTES: (1) Vertical parametric lines do not require control point parameters. (2) Z linear cubic splines have implicitly defined parameters. For a line with N intervals (N+1 control points), the parametric values are P=0,...,N. BUSINESS RULE: If present, the size must match the number of control points. BUSINESS RULE: For vertical and Z linear cubic parametric lines, this count must be zero. For all other parametric line kinds, each control point must have one control point parameter. BUSINESS RULE: The parametric values must be strictly monotonically increasing on each parametric line. This is an optional array which should only be used if control point parameters are present. BUSINESS RULE: If present, the size must match the number of control points. BUSINESS RULE: This count should be zero for vertical and Z linear cubic parametric lines. For all other parametric line kinds there should be one control point parameter for each control point. Notes: (1) Vertical parametric lines do not require control point parameters (2) Z linear cubic splines have implicitly defined parameters. For a line with N intervals (N+1 control points), the parametric values are P=0,...,N. BUSINESS RULE: The parametric values must be strictly monotonically increasing on each parametric line.
            /// </summary>
            [Description("An optional array of explicit control point parameters for the control points on the parametric line. Used only if control point parameters are present.  NOTES: (1) Vertical parametric lines do not require control point parameters. (2) Z linear cubic splines have implicitly defined parameters. For a line with N intervals (N+1 control points), the parametric values are P=0,...,N.  BUSINESS RULE: If present, the size must match the number of control points.  BUSINESS RULE: For vertical and Z linear cubic parametric lines, this count must be zero. For all other parametric line kinds, each control point must have one control point parameter.  BUSINESS RULE: The parametric values must be strictly monotonically increasing on each parametric line. This is an optional array which should only be used if control point parameters are present.  BUSINESS RULE: If present, the size must match the number of control points.  BUSINESS RULE: This count should be zero for vertical and Z linear cubic parametric lines. For all other parametric line kinds there should be one control point parameter for each control point.  Notes: (1) Vertical parametric lines do not require control point parameters (2) Z linear cubic splines have implicitly defined parameters. For a line with N intervals (N+1 control points), the parametric values are P=0,...,N.  BUSINESS RULE: The parametric values must be strictly monotonically increasing on each parametric line.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("ControlPointParameters")]
            public AbstractFloatingPointArray ControlPointParameters
            {
                get
                {
                    return ControlPointParametersField;
                }
                set
                {
                    ControlPointParametersField = value;
                    NotifyPropertyChanged("ControlPointParameters");
                }
            }

            private AbstractFloatingPointArray ControlPointParametersField;

            /// <summary>
            /// An array of 3D points for the control points on the parametric line.
            /// </summary>
            [Required]
            [Description("An array of 3D points for the control points on the parametric line.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractPoint3dArray")]
            [XmlElement("ControlPoints")]
            public AbstractPoint3dArray ControlPoints
            {
                get
                {
                    return ControlPointsField;
                }
                set
                {
                    ControlPointsField = value;
                    NotifyPropertyChanged("ControlPoints");
                }
            }

            private AbstractPoint3dArray ControlPointsField;

            /// <summary>
            /// Number of spline knots in the parametric line.
            /// </summary>
            [Required]
            [Description("Number of spline knots in the parametric line.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("KnotCount")]
            public long? KnotCount
            {
                get
                {
                    return KnotCountField;
                }
                set
                {
                    KnotCountField = value;
                    NotifyPropertyChanged("KnotCount");
                }
            }

            private long? KnotCountField;

            /// <summary>
            /// Integer indicating the parametric line kind 0 for vertical 1 for linear spline 2 for natural cubic spline 3 for cubic spline 4 for z linear cubic spline 5 for minimum-curvature spline (-1) for null: no line
            /// </summary>
            [Required]
            [Description("Integer indicating the parametric line kind  0 for vertical 1 for linear spline 2 for natural cubic spline 3 for cubic spline 4 for z linear cubic spline 5 for minimum-curvature spline (-1) for null: no line")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("LineKindIndex")]
            public long? LineKindIndex
            {
                get
                {
                    return LineKindIndexField;
                }
                set
                {
                    LineKindIndexField = value;
                    NotifyPropertyChanged("LineKindIndex");
                }
            }

            private long? LineKindIndexField;

            /// <summary>
            /// An optional array of tangent vectors for each control point on the cubic and minimum-curvature parametric lines. Used only if tangent vectors are present. If a tangent vector is missing, then it is computed in the same fashion as for a natural cubic spline. Specifically, to obtain the tangent at internal knots, the control points are fit by a quadratic function with the two adjacent control points. At edge knots, the second derivative vanishes.
            /// </summary>
            [Description("An optional array of tangent vectors for each control point on the cubic and minimum-curvature parametric lines. Used only if tangent vectors are present.  If a tangent vector is missing, then it is computed in the same fashion as for a natural cubic spline. Specifically, to obtain the tangent at internal knots, the control points are fit by a quadratic function with the two adjacent control points. At edge knots, the second derivative vanishes.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractPoint3dArray")]
            [XmlElement("TangentVectors")]
            public AbstractPoint3dArray TangentVectors
            {
                get
                {
                    return TangentVectorsField;
                }
                set
                {
                    TangentVectorsField = value;
                    NotifyPropertyChanged("TangentVectors");
                }
            }

            private AbstractPoint3dArray TangentVectorsField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ParametricLineFromRepresentationGeometry xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ParametricLineFromRepresentationGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ParametricLineFromRepresentationGeometry xsd type.")]
        public partial class ParametricLineFromRepresentationGeometry : AbstractParametricLineGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// LineIndexOnSupportingRepresentation property
            /// </summary>
            [Required]
            [Description("The line index of the selected line in the supporting representation.  For a column-layer grid, the parametric lines follow the indexing of the pillars.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("LineIndexOnSupportingRepresentation")]
            public long? LineIndexOnSupportingRepresentation
            {
                get
                {
                    return LineIndexOnSupportingRepresentationField;
                }
                set
                {
                    LineIndexOnSupportingRepresentationField = value;
                    NotifyPropertyChanged("LineIndexOnSupportingRepresentation");
                }
            }

            private long? LineIndexOnSupportingRepresentationField;

            /// <summary>
            /// SupportingRepresentation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("SupportingRepresentation")]
            public DataObjectReference SupportingRepresentation
            {
                get
                {
                    return SupportingRepresentationField;
                }
                set
                {
                    SupportingRepresentationField = value;
                    NotifyPropertyChanged("SupportingRepresentation");
                }
            }

            private DataObjectReference SupportingRepresentationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SinglePointGeometry xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SinglePointGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SinglePointGeometry xsd type.")]
        public partial class SinglePointGeometry : AbstractGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// Point3d property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "Point3d")]
            [XmlElement("Point3d")]
            public Point3d Point3d
            {
                get
                {
                    return Point3dField;
                }
                set
                {
                    Point3dField = value;
                    NotifyPropertyChanged("Point3d");
                }
            }

            private Point3d Point3dField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractGridGeometry xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractColumnLayerGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredColumnLayerGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IjkGridGeometry))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractGridGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractGridGeometry xsd type.")]
        public abstract partial class AbstractGridGeometry : PointGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// AdditionalGridPoints property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "AdditionalGridPoints")]
            [XmlElement("AdditionalGridPoints")]
            public List<AdditionalGridPoints> AdditionalGridPoints
            {
                get
                {
                    return AdditionalGridPointsField;
                }
                set
                {
                    AdditionalGridPointsField = value;
                    NotifyPropertyChanged("AdditionalGridPoints");
                }
            }

            /// <summary>
            /// bool to indicate if AdditionalGridPoints has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool AdditionalGridPointsSpecified
            {
                get
                {
                    if (AdditionalGridPointsField != null)
                        return AdditionalGridPointsField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<AdditionalGridPoints> AdditionalGridPointsField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AdditionalGridPoints xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdditionalGridPoints", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AdditionalGridPoints xsd type.")]
        public partial class AdditionalGridPoints : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// RepresentationPatchIndex property
            /// </summary>
            [Description("Used to remove ambiguity in geometry attachment, if the attachment element is not sufficient. Usually required for subnodes and for the general purpose grid, but not otherwise.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("RepresentationPatchIndex")]
            public long? RepresentationPatchIndex
            {
                get
                {
                    return RepresentationPatchIndexField;
                }
                set
                {
                    RepresentationPatchIndexField = value;
                    this.RepresentationPatchIndexSpecified = true;
                    NotifyPropertyChanged("RepresentationPatchIndex");
                }
            }

            private long? RepresentationPatchIndexField;

            /// <summary>
            /// RepresentationPatchIndexSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool RepresentationPatchIndexSpecified
            {
                get
                {
                    return RepresentationPatchIndexSpecifiedField;
                }
                set
                {
                    RepresentationPatchIndexSpecifiedField = value;
                    NotifyPropertyChanged("RepresentationPatchIndexSpecified");
                }
            }

            private bool RepresentationPatchIndexSpecifiedField;

            /// <summary>
            /// Attachment property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "GridGeometryAttachment")]
            [XmlElement("Attachment")]
            public GridGeometryAttachment? Attachment
            {
                get
                {
                    return AttachmentField;
                }
                set
                {
                    AttachmentField = value;
                    this.AttachmentSpecified = true;
                    NotifyPropertyChanged("Attachment");
                }
            }


            private bool AttachmentSpecifiedField = false;

            /// <summary>
            /// AttachmentSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool AttachmentSpecified
            {
                get
                {
                    return AttachmentSpecifiedField;
                }
                set
                {
                    AttachmentSpecifiedField = value;
                    NotifyPropertyChanged("AttachmentSpecified");
                }
            }

            private GridGeometryAttachment? AttachmentField;

            /// <summary>
            /// Points property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "AbstractPoint3dArray")]
            [XmlElement("Points")]
            public AbstractPoint3dArray Points
            {
                get
                {
                    return PointsField;
                }
                set
                {
                    PointsField = value;
                    NotifyPropertyChanged("Points");
                }
            }

            private AbstractPoint3dArray PointsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the UnstructuredGridGeometry xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UnstructuredGridGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the UnstructuredGridGeometry xsd type.")]
        public partial class UnstructuredGridGeometry : AbstractGridGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// CellFaceIsRightHanded property
            /// </summary>
            [Required]
            [Description("Boolean mask used to indicate which cell faces have an outwardly directed normal following a right hand rule. Array length is the sum of the cell face count per cell, and the data follows the order of the faces per cell RESQMLlist-of-lists.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("CellFaceIsRightHanded")]
            public AbstractBooleanArray CellFaceIsRightHanded
            {
                get
                {
                    return CellFaceIsRightHandedField;
                }
                set
                {
                    CellFaceIsRightHandedField = value;
                    NotifyPropertyChanged("CellFaceIsRightHanded");
                }
            }

            private AbstractBooleanArray CellFaceIsRightHandedField;

            /// <summary>
            /// CellShape property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "CellShape")]
            [XmlElement("CellShape")]
            public CellShape? CellShape
            {
                get
                {
                    return CellShapeField;
                }
                set
                {
                    CellShapeField = value;
                    this.CellShapeSpecified = true;
                    NotifyPropertyChanged("CellShape");
                }
            }


            private bool CellShapeSpecifiedField = false;

            /// <summary>
            /// CellShapeSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool CellShapeSpecified
            {
                get
                {
                    return CellShapeSpecifiedField;
                }
                set
                {
                    CellShapeSpecifiedField = value;
                    NotifyPropertyChanged("CellShapeSpecified");
                }
            }

            private CellShape? CellShapeField;

            /// <summary>
            /// FaceCount property
            /// </summary>
            [Required]
            [Description("Total number of faces in the grid. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("FaceCount")]
            public long? FaceCount
            {
                get
                {
                    return FaceCountField;
                }
                set
                {
                    FaceCountField = value;
                    NotifyPropertyChanged("FaceCount");
                }
            }

            private long? FaceCountField;

            /// <summary>
            /// FacesPerCell property
            /// </summary>
            [Required]
            [Description("List of faces per cell. Face count per cell can be obtained from the offsets in the first list-of-lists array.  BUSINESS RULE: CellCount must match the length of the first list-of-lists array.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("FacesPerCell")]
            public JaggedArray FacesPerCell
            {
                get
                {
                    return FacesPerCellField;
                }
                set
                {
                    FacesPerCellField = value;
                    NotifyPropertyChanged("FacesPerCell");
                }
            }

            private JaggedArray FacesPerCellField;

            /// <summary>
            /// NodeCount property
            /// </summary>
            [Required]
            [Description("Total number of nodes in the grid. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("NodeCount")]
            public long? NodeCount
            {
                get
                {
                    return NodeCountField;
                }
                set
                {
                    NodeCountField = value;
                    NotifyPropertyChanged("NodeCount");
                }
            }

            private long? NodeCountField;

            /// <summary>
            /// NodesPerFace property
            /// </summary>
            [Required]
            [Description("List of nodes per face. Node count per face can be obtained from the offsets in the first list-of-lists array.  BUSINESS RULE: FaceCount must match the length of the first list- of-lists array.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("NodesPerFace")]
            public JaggedArray NodesPerFace
            {
                get
                {
                    return NodesPerFaceField;
                }
                set
                {
                    NodesPerFaceField = value;
                    NotifyPropertyChanged("NodesPerFace");
                }
            }

            private JaggedArray NodesPerFaceField;

            /// <summary>
            /// UnstructuredGridHingeNodeFaces property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "UnstructuredGridHingeNodeFaces")]
            [XmlElement("UnstructuredGridHingeNodeFaces")]
            public UnstructuredGridHingeNodeFaces UnstructuredGridHingeNodeFaces
            {
                get
                {
                    return UnstructuredGridHingeNodeFacesField;
                }
                set
                {
                    UnstructuredGridHingeNodeFacesField = value;
                    NotifyPropertyChanged("UnstructuredGridHingeNodeFaces");
                }
            }

            private UnstructuredGridHingeNodeFaces UnstructuredGridHingeNodeFacesField;

            /// <summary>
            /// UnstructuredSubnodeTopology property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "UnstructuredSubnodeTopology")]
            [XmlElement("UnstructuredSubnodeTopology")]
            public UnstructuredSubnodeTopology UnstructuredSubnodeTopology
            {
                get
                {
                    return UnstructuredSubnodeTopologyField;
                }
                set
                {
                    UnstructuredSubnodeTopologyField = value;
                    NotifyPropertyChanged("UnstructuredSubnodeTopology");
                }
            }

            private UnstructuredSubnodeTopology UnstructuredSubnodeTopologyField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the UnstructuredGridHingeNodeFaces xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UnstructuredGridHingeNodeFaces", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the UnstructuredGridHingeNodeFaces xsd type.")]
        public partial class UnstructuredGridHingeNodeFaces : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of K faces. This count must be positive.
            /// </summary>
            [Required]
            [Description("Number of K faces. This count must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// List of faces to be identified as K faces for hinge node geometry attachment. BUSINESS RULE: Array length equals K face count.
            /// </summary>
            [Required]
            [Description("List of faces to be identified as K faces for hinge node geometry attachment.  BUSINESS RULE: Array length equals K face count.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("FaceIndices")]
            public AbstractIntegerArray FaceIndices
            {
                get
                {
                    return FaceIndicesField;
                }
                set
                {
                    FaceIndicesField = value;
                    NotifyPropertyChanged("FaceIndices");
                }
            }

            private AbstractIntegerArray FaceIndicesField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the UnstructuredSubnodeTopology xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UnstructuredSubnodeTopology", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the UnstructuredSubnodeTopology xsd type.")]
        public partial class UnstructuredSubnodeTopology : SubnodeTopology, INotifyPropertyChanged
        {

            /// <summary>
            /// NodesPerCell property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("NodesPerCell")]
            public JaggedArray NodesPerCell
            {
                get
                {
                    return NodesPerCellField;
                }
                set
                {
                    NodesPerCellField = value;
                    NotifyPropertyChanged("NodesPerCell");
                }
            }

            private JaggedArray NodesPerCellField;

            /// <summary>
            /// Edges property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "Edges")]
            [XmlElement("Edges")]
            public Edges Edges
            {
                get
                {
                    return EdgesField;
                }
                set
                {
                    EdgesField = value;
                    NotifyPropertyChanged("Edges");
                }
            }

            private Edges EdgesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Edges xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Edges", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Edges xsd type.")]
        public partial class Edges : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of edges. Must be positive.
            /// </summary>
            [Required]
            [Description("Number of edges. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// Defines a list of 2 nodes per edge. Count = 2 x EdgeCount
            /// </summary>
            [Required]
            [Description("Defines a list of 2 nodes per edge.  Count = 2 x EdgeCount")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("NodesPerEdge")]
            public AbstractIntegerArray NodesPerEdge
            {
                get
                {
                    return NodesPerEdgeField;
                }
                set
                {
                    NodesPerEdgeField = value;
                    NotifyPropertyChanged("NodesPerEdge");
                }
            }

            private AbstractIntegerArray NodesPerEdgeField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SubnodeTopology xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredSubnodeTopology))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ColumnLayerSubnodeTopology))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SubnodeTopology", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SubnodeTopology xsd type.")]
        public partial class SubnodeTopology : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// VariableSubnodePatch property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "VariableSubnodePatch")]
            [XmlElement("VariableSubnodePatch")]
            public List<VariableSubnodePatch> VariableSubnodePatch
            {
                get
                {
                    return VariableSubnodePatchField;
                }
                set
                {
                    VariableSubnodePatchField = value;
                    NotifyPropertyChanged("VariableSubnodePatch");
                }
            }

            /// <summary>
            /// bool to indicate if VariableSubnodePatch has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool VariableSubnodePatchSpecified
            {
                get
                {
                    if (VariableSubnodePatchField != null)
                        return VariableSubnodePatchField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<VariableSubnodePatch> VariableSubnodePatchField;

            /// <summary>
            /// UniformSubnodePatch property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "UniformSubnodePatch")]
            [XmlElement("UniformSubnodePatch")]
            public List<UniformSubnodePatch> UniformSubnodePatch
            {
                get
                {
                    return UniformSubnodePatchField;
                }
                set
                {
                    UniformSubnodePatchField = value;
                    NotifyPropertyChanged("UniformSubnodePatch");
                }
            }

            /// <summary>
            /// bool to indicate if UniformSubnodePatch has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool UniformSubnodePatchSpecified
            {
                get
                {
                    if (UniformSubnodePatchField != null)
                        return UniformSubnodePatchField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<UniformSubnodePatch> UniformSubnodePatchField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the VariableSubnodePatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VariableSubnodePatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the VariableSubnodePatch xsd type.")]
        public partial class VariableSubnodePatch : SubnodePatch, INotifyPropertyChanged
        {

            /// <summary>
            /// Indices of the selected data-objects
            /// </summary>
            [Required]
            [Description("Indices of the selected data-objects")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ObjectIndices")]
            public AbstractIntegerArray ObjectIndices
            {
                get
                {
                    return ObjectIndicesField;
                }
                set
                {
                    ObjectIndicesField = value;
                    NotifyPropertyChanged("ObjectIndices");
                }
            }

            private AbstractIntegerArray ObjectIndicesField;

            /// <summary>
            /// Number of subnodes per selected data-object.
            /// </summary>
            [Required]
            [Description("Number of subnodes per selected data-object.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("SubnodeCountPerSelectedObject")]
            public AbstractIntegerArray SubnodeCountPerSelectedObject
            {
                get
                {
                    return SubnodeCountPerSelectedObjectField;
                }
                set
                {
                    SubnodeCountPerSelectedObjectField = value;
                    NotifyPropertyChanged("SubnodeCountPerSelectedObject");
                }
            }

            private AbstractIntegerArray SubnodeCountPerSelectedObjectField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SubnodePatch xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VariableSubnodePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UniformSubnodePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ColumnSubnodePatch))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SubnodePatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SubnodePatch xsd type.")]
        public partial class SubnodePatch : Patch, INotifyPropertyChanged
        {

            /// <summary>
            /// SubnodeNodeObject property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "SubnodeNodeObject")]
            [XmlElement("SubnodeNodeObject")]
            public SubnodeNodeObject? SubnodeNodeObject
            {
                get
                {
                    return SubnodeNodeObjectField;
                }
                set
                {
                    SubnodeNodeObjectField = value;
                    this.SubnodeNodeObjectSpecified = true;
                    NotifyPropertyChanged("SubnodeNodeObject");
                }
            }


            private bool SubnodeNodeObjectSpecifiedField = false;

            /// <summary>
            /// SubnodeNodeObjectSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool SubnodeNodeObjectSpecified
            {
                get
                {
                    return SubnodeNodeObjectSpecifiedField;
                }
                set
                {
                    SubnodeNodeObjectSpecifiedField = value;
                    NotifyPropertyChanged("SubnodeNodeObjectSpecified");
                }
            }

            private SubnodeNodeObject? SubnodeNodeObjectField;

            /// <summary>
            /// Node weights for each subnode. Count of nodes per subnode is known for each specific subnode construction. Data order consists of all the nodes for each subnode in turn. For example, if uniform and stored as a multi-dimensional array, the node index cycles first. BUSINESS RULE: Weights must be non-negative. BUSINESS RULE: Length of array must be consistent with the sum of nodeCount x subnodeCount per object, e.g., for 3 subnodes per edge (uniform), there are 6 weights.
            /// </summary>
            [Required]
            [Description("Node weights for each subnode. Count of nodes per subnode is known for each specific subnode construction.  Data order consists of all the nodes for each subnode in turn. For example, if uniform and stored as a multi-dimensional array, the node index cycles first.  BUSINESS RULE: Weights must be non-negative.  BUSINESS RULE: Length of array must be consistent with the sum of nodeCount x subnodeCount per object, e.g., for 3 subnodes per edge (uniform), there are 6 weights.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractValueArray")]
            [XmlElement("NodeWeightsPerSubnode")]
            public AbstractValueArray NodeWeightsPerSubnode
            {
                get
                {
                    return NodeWeightsPerSubnodeField;
                }
                set
                {
                    NodeWeightsPerSubnodeField = value;
                    NotifyPropertyChanged("NodeWeightsPerSubnode");
                }
            }

            private AbstractValueArray NodeWeightsPerSubnodeField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the UniformSubnodePatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UniformSubnodePatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the UniformSubnodePatch xsd type.")]
        public partial class UniformSubnodePatch : SubnodePatch, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of subnodes per object, with the same number for each of this data-object kind in the grid.
            /// </summary>
            [Required]
            [Description("Number of subnodes per object, with the same number for each of this data-object kind in the grid.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("SubnodeCountPerObject")]
            public long? SubnodeCountPerObject
            {
                get
                {
                    return SubnodeCountPerObjectField;
                }
                set
                {
                    SubnodeCountPerObjectField = value;
                    NotifyPropertyChanged("SubnodeCountPerObject");
                }
            }

            private long? SubnodeCountPerObjectField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ColumnSubnodePatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ColumnSubnodePatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ColumnSubnodePatch xsd type.")]
        public partial class ColumnSubnodePatch : SubnodePatch, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of subnodes per object, with a different number in each column of the grid.
            /// </summary>
            [Required]
            [Description("Number of subnodes per object, with a different number in each column of the grid.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("SubnodeCountPerObject")]
            public AbstractIntegerArray SubnodeCountPerObject
            {
                get
                {
                    return SubnodeCountPerObjectField;
                }
                set
                {
                    SubnodeCountPerObjectField = value;
                    NotifyPropertyChanged("SubnodeCountPerObject");
                }
            }

            private AbstractIntegerArray SubnodeCountPerObjectField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ColumnLayerSubnodeTopology xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ColumnLayerSubnodeTopology", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ColumnLayerSubnodeTopology xsd type.")]
        public partial class ColumnLayerSubnodeTopology : SubnodeTopology, INotifyPropertyChanged
        {

            /// <summary>
            /// ColumnSubnodePatch property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ColumnSubnodePatch")]
            [XmlElement("ColumnSubnodePatch")]
            public List<ColumnSubnodePatch> ColumnSubnodePatch
            {
                get
                {
                    return ColumnSubnodePatchField;
                }
                set
                {
                    ColumnSubnodePatchField = value;
                    NotifyPropertyChanged("ColumnSubnodePatch");
                }
            }

            /// <summary>
            /// bool to indicate if ColumnSubnodePatch has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ColumnSubnodePatchSpecified
            {
                get
                {
                    if (ColumnSubnodePatchField != null)
                        return ColumnSubnodePatchField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ColumnSubnodePatch> ColumnSubnodePatchField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractFeatureInterpretation xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellboreInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractOrganizationInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractStratigraphicOrganizationInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicOccurrenceInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicColumnRankInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(RockFluidOrganizationInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuralOrganizationInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EarthModelInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeologicUnitInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicUnitInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(RockFluidUnitInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeobodyInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericFeatureInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BoundaryFeatureInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(HorizonInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeobodyBoundaryInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FluidBoundaryInterpretation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaultInterpretation))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractFeatureInterpretation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the AbstractFeatureInterpretation xsd type.")]
        public abstract partial class AbstractFeatureInterpretation : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {

            /// <summary>
            /// Domain property
            /// </summary>
            [Description("An enumeration that specifies in which domain the interpretation of an AbstractFeature has been performed: depth, time, mixed (= depth + time )")]
            [EnergisticsDataTypeAttribute(DataType = "Domain")]
            [XmlElement("Domain")]
            public Domain? Domain
            {
                get
                {
                    return DomainField;
                }
                set
                {
                    DomainField = value;
                    this.DomainSpecified = true;
                    NotifyPropertyChanged("Domain");
                }
            }

            private Domain? DomainField;

            /// <summary>
            /// DomainSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool DomainSpecified
            {
                get
                {
                    return DomainSpecifiedField;
                }
                set
                {
                    DomainSpecifiedField = value;
                    NotifyPropertyChanged("DomainSpecified");
                }
            }

            private bool DomainSpecifiedField;

            /// <summary>
            /// HasOccurredDuring property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "AbstractTimeInterval")]
            [XmlElement("HasOccurredDuring")]
            public AbstractTimeInterval HasOccurredDuring
            {
                get
                {
                    return HasOccurredDuringField;
                }
                set
                {
                    HasOccurredDuringField = value;
                    NotifyPropertyChanged("HasOccurredDuring");
                }
            }

            private AbstractTimeInterval HasOccurredDuringField;

            /// <summary>
            /// InterpretedFeature property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("InterpretedFeature")]
            public DataObjectReference InterpretedFeature
            {
                get
                {
                    return InterpretedFeatureField;
                }
                set
                {
                    InterpretedFeatureField = value;
                    NotifyPropertyChanged("InterpretedFeature");
                }
            }

            private DataObjectReference InterpretedFeatureField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_Date_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_Date_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_Date_PropertyType xsd type.")]
        public partial class CI_Date_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_Date property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_Date")]
            public CI_Date_Type CI_Date
            {
                get
                {
                    return CI_DateField;
                }
                set
                {
                    CI_DateField = value;
                    NotifyPropertyChanged("CI_Date");
                }
            }

            private CI_Date_Type CI_DateField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the MD_Identifier_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MD_Identifier_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the MD_Identifier_PropertyType xsd type.")]
        public partial class MD_Identifier_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// MD_Identifier property
            /// </summary>
            [ComponentElement]
            [XmlElement("MD_Identifier")]
            public MD_Identifier_Type MD_Identifier
            {
                get
                {
                    return MD_IdentifierField;
                }
                set
                {
                    MD_IdentifierField = value;
                    NotifyPropertyChanged("MD_Identifier");
                }
            }

            private MD_Identifier_Type MD_IdentifierField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractTechnicalFeature xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StreamlinesFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellboreFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSeismicSurveyFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicLineSetFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicLatticeSetFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicLatticeFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSeismicLineFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShotPointLineFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CmpLineFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrontierFeature))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractTechnicalFeature", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractTechnicalFeature xsd type.")]
        public abstract partial class AbstractTechnicalFeature : AbstractFeature, INotifyPropertyChanged
        {


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractFeature xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Model))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTechnicalFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StreamlinesFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellboreFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSeismicSurveyFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicLineSetFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicLatticeSetFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicLatticeFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSeismicLineFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShotPointLineFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CmpLineFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrontierFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(RockVolumeFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BoundaryFeature))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractFeature", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the AbstractFeature xsd type.")]
        public abstract partial class AbstractFeature : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractColumnLayerGridRepresentation xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IjkGridRepresentation))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractColumnLayerGridRepresentation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractColumnLayerGridRepresentation xsd type.")]
        public abstract partial class AbstractColumnLayerGridRepresentation : AbstractGridRepresentation, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of layers in the grid. Must be positive.
            /// </summary>
            [Required]
            [Description("Number of layers in the grid. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Nk")]
            public long? Nk
            {
                get
                {
                    return NkField;
                }
                set
                {
                    NkField = value;
                    NotifyPropertyChanged("Nk");
                }
            }

            private long? NkField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractColumnLayerGridGeometry xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredColumnLayerGridGeometry))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IjkGridGeometry))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractColumnLayerGridGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractColumnLayerGridGeometry xsd type.")]
        public abstract partial class AbstractColumnLayerGridGeometry : AbstractGridGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// CellGeometryIsDefined property
            /// </summary>
            [Description("Indicator that a cell has a defined geometry. This attribute is grid metadata. If the indicator shows that the cell geometry is NOT defined, then this attribute overrides any other node geometry specification.  Array index is 2D/3D.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("CellGeometryIsDefined")]
            public AbstractBooleanArray CellGeometryIsDefined
            {
                get
                {
                    return CellGeometryIsDefinedField;
                }
                set
                {
                    CellGeometryIsDefinedField = value;
                    NotifyPropertyChanged("CellGeometryIsDefined");
                }
            }

            private AbstractBooleanArray CellGeometryIsDefinedField;

            /// <summary>
            /// KDirection property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "KDirection")]
            [XmlElement("KDirection")]
            public KDirection? KDirection
            {
                get
                {
                    return KDirectionField;
                }
                set
                {
                    KDirectionField = value;
                    this.KDirectionSpecified = true;
                    NotifyPropertyChanged("KDirection");
                }
            }


            private bool KDirectionSpecifiedField = false;

            /// <summary>
            /// KDirectionSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool KDirectionSpecified
            {
                get
                {
                    return KDirectionSpecifiedField;
                }
                set
                {
                    KDirectionSpecifiedField = value;
                    NotifyPropertyChanged("KDirectionSpecified");
                }
            }

            private KDirection? KDirectionField;

            /// <summary>
            /// NodeIsColocatedInKDirection property
            /// </summary>
            [Description("Optional indicator that two adjacent nodes on a coordinate line are colocated. This is considered grid metadata, and is intended to over-ride any geometric comparison of node locations.  Array index follows #CoordinateLines x (NKL-1).")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("NodeIsColocatedInKDirection")]
            public AbstractBooleanArray NodeIsColocatedInKDirection
            {
                get
                {
                    return NodeIsColocatedInKDirectionField;
                }
                set
                {
                    NodeIsColocatedInKDirectionField = value;
                    NotifyPropertyChanged("NodeIsColocatedInKDirection");
                }
            }

            private AbstractBooleanArray NodeIsColocatedInKDirectionField;

            /// <summary>
            /// NodeIsColocatedOnKEdge property
            /// </summary>
            [Description("Optional indicator that two adjacent nodes on the KEDGE of a cell are colocated. This is considered grid metadata, and is intended to over-ride any geometric comparison of node locations.  Array index follows #EdgesPerColumn x NKL for unstructured column layer grids and 4 x NI x NJ x NKL for IJK grids.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("NodeIsColocatedOnKEdge")]
            public AbstractBooleanArray NodeIsColocatedOnKEdge
            {
                get
                {
                    return NodeIsColocatedOnKEdgeField;
                }
                set
                {
                    NodeIsColocatedOnKEdgeField = value;
                    NotifyPropertyChanged("NodeIsColocatedOnKEdge");
                }
            }

            private AbstractBooleanArray NodeIsColocatedOnKEdgeField;

            /// <summary>
            /// PillarGeometryIsDefined property
            /// </summary>
            [Required]
            [Description("Indicator that a pillar has at least one node with a defined cell geometry. This is considered grid metadata. If the indicator does not indicate that the pillar geometry is defined, then this over-rides any other node geometry specification.  Array index follows #Pillars and so may be either 2D or 1D.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("PillarGeometryIsDefined")]
            public AbstractBooleanArray PillarGeometryIsDefined
            {
                get
                {
                    return PillarGeometryIsDefinedField;
                }
                set
                {
                    PillarGeometryIsDefinedField = value;
                    NotifyPropertyChanged("PillarGeometryIsDefined");
                }
            }

            private AbstractBooleanArray PillarGeometryIsDefinedField;

            /// <summary>
            /// PillarShape property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "PillarShape")]
            [XmlElement("PillarShape")]
            public PillarShape? PillarShape
            {
                get
                {
                    return PillarShapeField;
                }
                set
                {
                    PillarShapeField = value;
                    this.PillarShapeSpecified = true;
                    NotifyPropertyChanged("PillarShape");
                }
            }


            private bool PillarShapeSpecifiedField = false;

            /// <summary>
            /// PillarShapeSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool PillarShapeSpecified
            {
                get
                {
                    return PillarShapeSpecifiedField;
                }
                set
                {
                    PillarShapeSpecifiedField = value;
                    NotifyPropertyChanged("PillarShapeSpecified");
                }
            }

            private PillarShape? PillarShapeField;

            /// <summary>
            /// ColumnLayerSubnodeTopology property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "ColumnLayerSubnodeTopology")]
            [XmlElement("ColumnLayerSubnodeTopology")]
            public ColumnLayerSubnodeTopology ColumnLayerSubnodeTopology
            {
                get
                {
                    return ColumnLayerSubnodeTopologyField;
                }
                set
                {
                    ColumnLayerSubnodeTopologyField = value;
                    NotifyPropertyChanged("ColumnLayerSubnodeTopology");
                }
            }

            private ColumnLayerSubnodeTopology ColumnLayerSubnodeTopologyField;

            /// <summary>
            /// ColumnLayerSplitCoordinateLines property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "ColumnLayerSplitCoordinateLines")]
            [XmlElement("ColumnLayerSplitCoordinateLines")]
            public ColumnLayerSplitCoordinateLines ColumnLayerSplitCoordinateLines
            {
                get
                {
                    return ColumnLayerSplitCoordinateLinesField;
                }
                set
                {
                    ColumnLayerSplitCoordinateLinesField = value;
                    NotifyPropertyChanged("ColumnLayerSplitCoordinateLines");
                }
            }

            private ColumnLayerSplitCoordinateLines ColumnLayerSplitCoordinateLinesField;

            /// <summary>
            /// SplitColumnEdges property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "SplitColumnEdges")]
            [XmlElement("SplitColumnEdges")]
            public SplitColumnEdges SplitColumnEdges
            {
                get
                {
                    return SplitColumnEdgesField;
                }
                set
                {
                    SplitColumnEdgesField = value;
                    NotifyPropertyChanged("SplitColumnEdges");
                }
            }

            private SplitColumnEdges SplitColumnEdgesField;

            /// <summary>
            /// SplitNodePatch property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "SplitNodePatch")]
            [XmlElement("SplitNodePatch")]
            public SplitNodePatch SplitNodePatch
            {
                get
                {
                    return SplitNodePatchField;
                }
                set
                {
                    SplitNodePatchField = value;
                    NotifyPropertyChanged("SplitNodePatch");
                }
            }

            private SplitNodePatch SplitNodePatchField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ColumnLayerSplitCoordinateLines xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ColumnLayerSplitCoordinateLines", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ColumnLayerSplitCoordinateLines xsd type.")]
        public partial class ColumnLayerSplitCoordinateLines : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of split coordinate lines. The count must be positive.
            /// </summary>
            [Required]
            [Description("Number of split coordinate lines. The count must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// Pillar index for each split coordinate line. Length of this array is equal to the number of split coordinate lines. For the first pillarCount lines, the index of the coordinate line equals the index of the corresponding pillar. This array provides the pillar indices for the additional (split) coordinate lines. Used to implicitly define column and cell geometry.
            /// </summary>
            [Required]
            [Description("Pillar index for each split coordinate line. Length of this array is equal to the number of split coordinate lines.  For the first pillarCount lines, the index of the coordinate line equals the index of the corresponding pillar.  This array provides the pillar indices for the additional (split) coordinate lines.  Used to implicitly define column and cell geometry.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("PillarIndices")]
            public AbstractIntegerArray PillarIndices
            {
                get
                {
                    return PillarIndicesField;
                }
                set
                {
                    PillarIndicesField = value;
                    NotifyPropertyChanged("PillarIndices");
                }
            }

            private AbstractIntegerArray PillarIndicesField;

            /// <summary>
            /// Column indices for each of the split coordinate lines. Used to implicitly define column and cell geometry. List-of-lists construction used to support shared coordinate lines. 
            /// </summary>
            [Required]
            [Description("Column indices for each of the split coordinate lines. Used to implicitly define column and cell geometry. List-of-lists construction used to support shared coordinate lines.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("ColumnsPerSplitCoordinateLine")]
            public JaggedArray ColumnsPerSplitCoordinateLine
            {
                get
                {
                    return ColumnsPerSplitCoordinateLineField;
                }
                set
                {
                    ColumnsPerSplitCoordinateLineField = value;
                    NotifyPropertyChanged("ColumnsPerSplitCoordinateLine");
                }
            }

            private JaggedArray ColumnsPerSplitCoordinateLineField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SplitColumnEdges xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SplitColumnEdges", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SplitColumnEdges xsd type.")]
        public partial class SplitColumnEdges : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of split column edges in this grid. Must be positive.
            /// </summary>
            [Required]
            [Description("Number of split column edges in this grid. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// Parent unsplit column edge index for each of the split column edges. Used to implicitly define split face indexing.
            /// </summary>
            [Required]
            [Description("Parent unsplit column edge index for each of the split column edges. Used to implicitly define split face indexing.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ParentColumnEdgeIndices")]
            public AbstractIntegerArray ParentColumnEdgeIndices
            {
                get
                {
                    return ParentColumnEdgeIndicesField;
                }
                set
                {
                    ParentColumnEdgeIndicesField = value;
                    NotifyPropertyChanged("ParentColumnEdgeIndices");
                }
            }

            private AbstractIntegerArray ParentColumnEdgeIndicesField;

            /// <summary>
            /// Column index for each of the split column edges. Used to implicitly define column and cell faces. List-of-lists construction not required because each split column edge must be in a single column.
            /// </summary>
            [Required]
            [Description("Column index for each of the split column edges. Used to implicitly define column and cell faces. List-of-lists construction not required because each split column edge must be in a single column.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ColumnPerSplitColumnEdge")]
            public AbstractIntegerArray ColumnPerSplitColumnEdge
            {
                get
                {
                    return ColumnPerSplitColumnEdgeField;
                }
                set
                {
                    ColumnPerSplitColumnEdgeField = value;
                    NotifyPropertyChanged("ColumnPerSplitColumnEdge");
                }
            }

            private AbstractIntegerArray ColumnPerSplitColumnEdgeField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the UnstructuredColumnLayerGridGeometry xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UnstructuredColumnLayerGridGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the UnstructuredColumnLayerGridGeometry xsd type.")]
        public partial class UnstructuredColumnLayerGridGeometry : AbstractColumnLayerGridGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// ColumnIsRightHanded property
            /// </summary>
            [Required]
            [Description("List of columns that are right handed. Right handedness is evaluated following the pillar order and the K-direction tangent vector for each column.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("ColumnIsRightHanded")]
            public AbstractBooleanArray ColumnIsRightHanded
            {
                get
                {
                    return ColumnIsRightHandedField;
                }
                set
                {
                    ColumnIsRightHandedField = value;
                    NotifyPropertyChanged("ColumnIsRightHanded");
                }
            }

            private AbstractBooleanArray ColumnIsRightHandedField;

            /// <summary>
            /// ColumnShape property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "ColumnShape")]
            [XmlElement("ColumnShape")]
            public ColumnShape? ColumnShape
            {
                get
                {
                    return ColumnShapeField;
                }
                set
                {
                    ColumnShapeField = value;
                    this.ColumnShapeSpecified = true;
                    NotifyPropertyChanged("ColumnShape");
                }
            }


            private bool ColumnShapeSpecifiedField = false;

            /// <summary>
            /// ColumnShapeSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool ColumnShapeSpecified
            {
                get
                {
                    return ColumnShapeSpecifiedField;
                }
                set
                {
                    ColumnShapeSpecifiedField = value;
                    NotifyPropertyChanged("ColumnShapeSpecified");
                }
            }

            private ColumnShape? ColumnShapeField;

            /// <summary>
            /// PillarCount property
            /// </summary>
            [Required]
            [Description("Number of pillars in the grid. Must be positive. Pillars are used to describe the shape of the columns in the grid.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("PillarCount")]
            public long? PillarCount
            {
                get
                {
                    return PillarCountField;
                }
                set
                {
                    PillarCountField = value;
                    NotifyPropertyChanged("PillarCount");
                }
            }

            private long? PillarCountField;

            /// <summary>
            /// PillarsPerColumn property
            /// </summary>
            [Required]
            [Description("List of pillars for each column. The pillars define the corners of each column.  The number of pillars per column can be obtained from the offsets in the first list-of-lists array.  BUSINESS RULE: The length of the first array in the list -of-lists construction must equal the columnCount.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("PillarsPerColumn")]
            public JaggedArray PillarsPerColumn
            {
                get
                {
                    return PillarsPerColumnField;
                }
                set
                {
                    PillarsPerColumnField = value;
                    NotifyPropertyChanged("PillarsPerColumn");
                }
            }

            private JaggedArray PillarsPerColumnField;

            /// <summary>
            /// UnstructuredColumnEdges property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "UnstructuredColumnEdges")]
            [XmlElement("UnstructuredColumnEdges")]
            public UnstructuredColumnEdges UnstructuredColumnEdges
            {
                get
                {
                    return UnstructuredColumnEdgesField;
                }
                set
                {
                    UnstructuredColumnEdgesField = value;
                    NotifyPropertyChanged("UnstructuredColumnEdges");
                }
            }

            private UnstructuredColumnEdges UnstructuredColumnEdgesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the UnstructuredColumnEdges xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UnstructuredColumnEdges", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the UnstructuredColumnEdges xsd type.")]
        public partial class UnstructuredColumnEdges : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of unstructured column edges in this grid. Must be positive.
            /// </summary>
            [Required]
            [Description("Number of unstructured column edges in this grid. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// Definition of the column edges in terms of the pillars-per-column edge. Pillar count per edge is usually 2, but the list-of-lists construction is used to allow column edges to be defined by more than 2 pillars.
            /// </summary>
            [Required]
            [Description("Definition of the column edges in terms of the pillars-per-column edge. Pillar count per edge is usually 2, but the list-of-lists construction is used to allow column edges to be defined by more than 2 pillars.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("PillarsPerColumnEdge")]
            public JaggedArray PillarsPerColumnEdge
            {
                get
                {
                    return PillarsPerColumnEdgeField;
                }
                set
                {
                    PillarsPerColumnEdgeField = value;
                    NotifyPropertyChanged("PillarsPerColumnEdge");
                }
            }

            private JaggedArray PillarsPerColumnEdgeField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IjkGridGeometry xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IjkGridGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the IjkGridGeometry xsd type.")]
        public partial class IjkGridGeometry : AbstractColumnLayerGridGeometry, INotifyPropertyChanged
        {

            /// <summary>
            /// GridIsRighthanded property
            /// </summary>
            [Required]
            [Description("Indicates that the IJK grid is right handed, as determined by the triple product of tangent vectors in the I, J, and K directions.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("GridIsRighthanded")]
            public bool? GridIsRighthanded
            {
                get
                {
                    return GridIsRighthandedField;
                }
                set
                {
                    GridIsRighthandedField = value;
                    NotifyPropertyChanged("GridIsRighthanded");
                }
            }

            private bool? GridIsRighthandedField;

            /// <summary>
            /// IjGaps property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "IjGaps")]
            [XmlElement("IjGaps")]
            public IjGaps IjGaps
            {
                get
                {
                    return IjGapsField;
                }
                set
                {
                    IjGapsField = value;
                    NotifyPropertyChanged("IjGaps");
                }
            }

            private IjGaps IjGapsField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IjGaps xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IjGaps", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the IjGaps xsd type.")]
        public partial class IjGaps : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of split pillars in the model. Count must be positive.
            /// </summary>
            [Description("Number of split pillars in the model. Count must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("SplitPillarCount")]
            public long? SplitPillarCount
            {
                get
                {
                    return SplitPillarCountField;
                }
                set
                {
                    SplitPillarCountField = value;
                    NotifyPropertyChanged("SplitPillarCount");
                }
            }

            private long? SplitPillarCountField;

            /// <summary>
            /// Parent pillar index for each of the split pillars. This information is used to infer the grid cell geometry. BUSINESS RULE: Array length must match splitPillarCount.
            /// </summary>
            [Description("Parent pillar index for each of the split pillars. This information is used to infer the grid cell geometry.  BUSINESS RULE: Array length must match splitPillarCount.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ParentPillarIndices")]
            public AbstractIntegerArray ParentPillarIndices
            {
                get
                {
                    return ParentPillarIndicesField;
                }
                set
                {
                    ParentPillarIndicesField = value;
                    NotifyPropertyChanged("ParentPillarIndices");
                }
            }

            private AbstractIntegerArray ParentPillarIndicesField;

            /// <summary>
            /// List of columns for each of the split pillars. This information is used to infer the grid cell geometry. BUSINESS RULE: The length of the first list-of-lists array must match the splitPillarCount.
            /// </summary>
            [Description("List of columns for each of the split pillars. This information is used to infer the grid cell geometry.  BUSINESS RULE: The length of the first list-of-lists array must match the splitPillarCount.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("ColumnsPerSplitPillar")]
            public JaggedArray ColumnsPerSplitPillar
            {
                get
                {
                    return ColumnsPerSplitPillarField;
                }
                set
                {
                    ColumnsPerSplitPillarField = value;
                    NotifyPropertyChanged("ColumnsPerSplitPillar");
                }
            }

            private JaggedArray ColumnsPerSplitPillarField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the UnstructuredGpGridPatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UnstructuredGpGridPatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the UnstructuredGpGridPatch xsd type.")]
        public partial class UnstructuredGpGridPatch : Patch, INotifyPropertyChanged
        {

            /// <summary>
            /// UnstructuredCellCount property
            /// </summary>
            [Required]
            [Description("Number of unstructured cells. Degenerate case (count=0) is allowed for GPGrid.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("UnstructuredCellCount")]
            public long? UnstructuredCellCount
            {
                get
                {
                    return UnstructuredCellCountField;
                }
                set
                {
                    UnstructuredCellCountField = value;
                    NotifyPropertyChanged("UnstructuredCellCount");
                }
            }

            private long? UnstructuredCellCountField;

            /// <summary>
            /// Geometry property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "UnstructuredGridGeometry")]
            [XmlElement("Geometry")]
            public UnstructuredGridGeometry Geometry
            {
                get
                {
                    return GeometryField;
                }
                set
                {
                    GeometryField = value;
                    NotifyPropertyChanged("Geometry");
                }
            }

            private UnstructuredGridGeometry GeometryField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the UnstructuredColumnLayerGpGridPatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UnstructuredColumnLayerGpGridPatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the UnstructuredColumnLayerGpGridPatch xsd type.")]
        public partial class UnstructuredColumnLayerGpGridPatch : Patch, INotifyPropertyChanged
        {

            /// <summary>
            /// UnstructuredColumnCount property
            /// </summary>
            [Required]
            [Description("Number of unstructured columns. Degenerate case (count=0) is allowed for GPGrid.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("UnstructuredColumnCount")]
            public long? UnstructuredColumnCount
            {
                get
                {
                    return UnstructuredColumnCountField;
                }
                set
                {
                    UnstructuredColumnCountField = value;
                    NotifyPropertyChanged("UnstructuredColumnCount");
                }
            }

            private long? UnstructuredColumnCountField;

            /// <summary>
            /// Geometry property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "UnstructuredColumnLayerGridGeometry")]
            [XmlElement("Geometry")]
            public UnstructuredColumnLayerGridGeometry Geometry
            {
                get
                {
                    return GeometryField;
                }
                set
                {
                    GeometryField = value;
                    NotifyPropertyChanged("Geometry");
                }
            }

            private UnstructuredColumnLayerGridGeometry GeometryField;

            /// <summary>
            /// TruncationCellPatch property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TruncationCellPatch")]
            [XmlElement("TruncationCellPatch")]
            public TruncationCellPatch TruncationCellPatch
            {
                get
                {
                    return TruncationCellPatchField;
                }
                set
                {
                    TruncationCellPatchField = value;
                    NotifyPropertyChanged("TruncationCellPatch");
                }
            }

            private TruncationCellPatch TruncationCellPatchField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TruncationCellPatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TruncationCellPatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the TruncationCellPatch xsd type.")]
        public partial class TruncationCellPatch : Patch, INotifyPropertyChanged
        {

            /// <summary>
            /// Local cell face index for those faces that are retained from the parent cell in the definition of the truncation cell. The use of a local cell-face index, e.g., 0...5 for an IJK cell, can be used even if the face indices have not been defined.
            /// </summary>
            [Required]
            [Description("Local cell face index for those faces that are retained from the parent cell in the definition of the truncation cell.  The use of a local cell-face index, e.g., 0...5 for an IJK cell, can be used even if the face indices have not been defined.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("LocalFacesPerCell")]
            public JaggedArray LocalFacesPerCell
            {
                get
                {
                    return LocalFacesPerCellField;
                }
                set
                {
                    LocalFacesPerCellField = value;
                    NotifyPropertyChanged("LocalFacesPerCell");
                }
            }

            private JaggedArray LocalFacesPerCellField;

            /// <summary>
            /// Definition of the truncation faces is in terms of an ordered list of nodes. Node indexing is EXTENDED, i.e., is based on the list of untruncated grid nodes (always first) plus the split nodes (if any) and the truncation face nodes. Relative order of split nodes and truncation face nodes is set by the pillar indices.
            /// </summary>
            [Required]
            [Description("Definition of the truncation faces is in terms of an ordered list of nodes. Node indexing is EXTENDED, i.e., is based on the list of untruncated grid nodes (always first) plus the split nodes (if any) and the truncation face nodes. Relative order of split nodes and truncation face nodes is set by the pillar indices.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("NodesPerTruncationFace")]
            public JaggedArray NodesPerTruncationFace
            {
                get
                {
                    return NodesPerTruncationFaceField;
                }
                set
                {
                    NodesPerTruncationFaceField = value;
                    NotifyPropertyChanged("NodesPerTruncationFace");
                }
            }

            private JaggedArray NodesPerTruncationFaceField;

            /// <summary>
            /// Parent cell index for each of the truncation cells. BUSINESS RULE: Size must match truncationCellCount
            /// </summary>
            [Required]
            [Description("Parent cell index for each of the truncation cells.  BUSINESS RULE: Size must match truncationCellCount")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ParentCellIndices")]
            public AbstractIntegerArray ParentCellIndices
            {
                get
                {
                    return ParentCellIndicesField;
                }
                set
                {
                    ParentCellIndicesField = value;
                    NotifyPropertyChanged("ParentCellIndices");
                }
            }

            private AbstractIntegerArray ParentCellIndicesField;

            /// <summary>
            /// Number of polyhedral cells created by truncation. Must be positive. Note: Parent cells are replaced.
            /// </summary>
            [Required]
            [Description("Number of polyhedral cells created by truncation. Must be positive. Note: Parent cells are replaced.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("TruncationCellCount")]
            public long? TruncationCellCount
            {
                get
                {
                    return TruncationCellCountField;
                }
                set
                {
                    TruncationCellCountField = value;
                    NotifyPropertyChanged("TruncationCellCount");
                }
            }

            private long? TruncationCellCountField;

            /// <summary>
            /// Boolean mask used to indicate which truncation cell faces have an outwardly directed normal, following a right hand rule. Data size and order follows the truncationFacesPerCell list-of-lists.
            /// </summary>
            [Required]
            [Description("Boolean mask used to indicate which truncation cell faces have an outwardly directed normal, following a right hand rule. Data size and order follows the truncationFacesPerCell list-of-lists.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("TruncationCellFaceIsRightHanded")]
            public AbstractBooleanArray TruncationCellFaceIsRightHanded
            {
                get
                {
                    return TruncationCellFaceIsRightHandedField;
                }
                set
                {
                    TruncationCellFaceIsRightHandedField = value;
                    NotifyPropertyChanged("TruncationCellFaceIsRightHanded");
                }
            }

            private AbstractBooleanArray TruncationCellFaceIsRightHandedField;

            /// <summary>
            /// Number of additional faces required for the split and truncation construction. The construction does not modify existing face definitions, but instead uses these new faces to redefine the truncated cell geometry. Must be positive. These faces are added to the enumeration of faces for the grid
            /// </summary>
            [Required]
            [Description("Number of additional faces required for the split and truncation construction. The construction does not modify existing face definitions, but instead uses these new faces to redefine the truncated cell geometry. Must be positive.  These faces are added to the enumeration of faces for the grid")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("TruncationFaceCount")]
            public long? TruncationFaceCount
            {
                get
                {
                    return TruncationFaceCountField;
                }
                set
                {
                    TruncationFaceCountField = value;
                    NotifyPropertyChanged("TruncationFaceCount");
                }
            }

            private long? TruncationFaceCountField;

            /// <summary>
            /// Truncation face index for the additional cell faces that are required to complete the definition of the truncation cell. The resulting local cell face index follows the local faces-per-cell list, followed by the truncation faces in the order within the list-of-lists constructions.
            /// </summary>
            [Required]
            [Description("Truncation face index for the additional cell faces that are required to complete the definition of the truncation cell.  The resulting local cell face index follows the local faces-per-cell list, followed by the truncation faces in the order within the list-of-lists constructions.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("TruncationFacesPerCell")]
            public JaggedArray TruncationFacesPerCell
            {
                get
                {
                    return TruncationFacesPerCellField;
                }
                set
                {
                    TruncationFacesPerCellField = value;
                    NotifyPropertyChanged("TruncationFacesPerCell");
                }
            }

            private JaggedArray TruncationFacesPerCellField;

            /// <summary>
            /// Number of additional nodes required for the truncation construction. Must be positive. Uses a separate enumeration and does not increase the number of nodes, except as noted below.
            /// </summary>
            [Required]
            [Description("Number of additional nodes required for the truncation construction. Must be positive. Uses a separate enumeration and does not increase the number of nodes, except as noted below.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("TruncationNodeCount")]
            public long? TruncationNodeCount
            {
                get
                {
                    return TruncationNodeCountField;
                }
                set
                {
                    TruncationNodeCountField = value;
                    NotifyPropertyChanged("TruncationNodeCount");
                }
            }

            private long? TruncationNodeCountField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IjkGpGridPatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IjkGpGridPatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the IjkGpGridPatch xsd type.")]
        public partial class IjkGpGridPatch : Patch, INotifyPropertyChanged
        {

            /// <summary>
            /// Ni property
            /// </summary>
            [Required]
            [Description("Count of I indices. Degenerate case (ni=0) is allowed for GPGrid representations.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("Ni")]
            public long? Ni
            {
                get
                {
                    return NiField;
                }
                set
                {
                    NiField = value;
                    NotifyPropertyChanged("Ni");
                }
            }

            private long? NiField;

            /// <summary>
            /// Nj property
            /// </summary>
            [Required]
            [Description("Count of J indices. Degenerate case (nj=0) is allowed for GPGrid representations.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("Nj")]
            public long? Nj
            {
                get
                {
                    return NjField;
                }
                set
                {
                    NjField = value;
                    NotifyPropertyChanged("Nj");
                }
            }

            private long? NjField;

            /// <summary>
            /// RadialGridIsComplete property
            /// </summary>
            [Description("TRUE if the grid is periodic in J, i.e., has the topology of a complete 360 degree circle.  If TRUE, then NJL=NJ. Otherwise, NJL=NJ+1")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("RadialGridIsComplete")]
            public bool? RadialGridIsComplete
            {
                get
                {
                    return RadialGridIsCompleteField;
                }
                set
                {
                    RadialGridIsCompleteField = value;
                    this.RadialGridIsCompleteSpecified = true;
                    NotifyPropertyChanged("RadialGridIsComplete");
                }
            }

            private bool? RadialGridIsCompleteField;

            /// <summary>
            /// RadialGridIsCompleteSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool RadialGridIsCompleteSpecified
            {
                get
                {
                    return RadialGridIsCompleteSpecifiedField;
                }
                set
                {
                    RadialGridIsCompleteSpecifiedField = value;
                    NotifyPropertyChanged("RadialGridIsCompleteSpecified");
                }
            }

            private bool RadialGridIsCompleteSpecifiedField;

            /// <summary>
            /// Geometry property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "IjkGridGeometry")]
            [XmlElement("Geometry")]
            public IjkGridGeometry Geometry
            {
                get
                {
                    return GeometryField;
                }
                set
                {
                    GeometryField = value;
                    NotifyPropertyChanged("Geometry");
                }
            }

            private IjkGridGeometry GeometryField;

            /// <summary>
            /// TruncationCellPatch property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TruncationCellPatch")]
            [XmlElement("TruncationCellPatch")]
            public TruncationCellPatch TruncationCellPatch
            {
                get
                {
                    return TruncationCellPatchField;
                }
                set
                {
                    TruncationCellPatchField = value;
                    NotifyPropertyChanged("TruncationCellPatch");
                }
            }

            private TruncationCellPatch TruncationCellPatchField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the PolylineSetPatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PolylineSetPatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the PolylineSetPatch xsd type.")]
        public partial class PolylineSetPatch : Patch, INotifyPropertyChanged
        {

            /// <summary>
            /// NodeCount property
            /// </summary>
            [Required]
            [Description("Total number of nodes.  BUSINESS RULE: Should be equal to the sum of the number of nodes per polyline.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("NodeCount")]
            public long? NodeCount
            {
                get
                {
                    return NodeCountField;
                }
                set
                {
                    NodeCountField = value;
                    NotifyPropertyChanged("NodeCount");
                }
            }

            private long? NodeCountField;

            /// <summary>
            /// IntervalCount property
            /// </summary>
            [Required]
            [Description("Total number of intervals.  BUSINESS RULE: Should be equal to the sum of the count of intervals per polyline.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("IntervalCount")]
            public long? IntervalCount
            {
                get
                {
                    return IntervalCountField;
                }
                set
                {
                    IntervalCountField = value;
                    NotifyPropertyChanged("IntervalCount");
                }
            }

            private long? IntervalCountField;

            /// <summary>
            /// NodeCountPerPolyline property
            /// </summary>
            [Required]
            [Description("The first number in the list defines the node count for the first polyline in the polyline set patch. The second number in the list defines the node count for the second polyline in the polyline set patch. etc.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("NodeCountPerPolyline")]
            public AbstractIntegerArray NodeCountPerPolyline
            {
                get
                {
                    return NodeCountPerPolylineField;
                }
                set
                {
                    NodeCountPerPolylineField = value;
                    NotifyPropertyChanged("NodeCountPerPolyline");
                }
            }

            private AbstractIntegerArray NodeCountPerPolylineField;

            /// <summary>
            /// ClosedPolylines property
            /// </summary>
            [Required]
            [Description("Indicates whether a polyline is closed.  If closed, then the interval count for that polyline is equal to the node count.  If open, then the interval count for that polyline is one less than the node count.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("ClosedPolylines")]
            public AbstractBooleanArray ClosedPolylines
            {
                get
                {
                    return ClosedPolylinesField;
                }
                set
                {
                    ClosedPolylinesField = value;
                    NotifyPropertyChanged("ClosedPolylines");
                }
            }

            private AbstractBooleanArray ClosedPolylinesField;

            /// <summary>
            /// IntervalGridCells property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "IntervalGridCells")]
            [XmlElement("IntervalGridCells")]
            public IntervalGridCells IntervalGridCells
            {
                get
                {
                    return IntervalGridCellsField;
                }
                set
                {
                    IntervalGridCellsField = value;
                    NotifyPropertyChanged("IntervalGridCells");
                }
            }

            private IntervalGridCells IntervalGridCellsField;

            /// <summary>
            /// Geometry property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "PointGeometry")]
            [XmlElement("Geometry")]
            public PointGeometry Geometry
            {
                get
                {
                    return GeometryField;
                }
                set
                {
                    GeometryField = value;
                    NotifyPropertyChanged("Geometry");
                }
            }

            private PointGeometry GeometryField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IntervalGridCells xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IntervalGridCells", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the IntervalGridCells xsd type.")]
        public partial class IntervalGridCells : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CellCount property
            /// </summary>
            [Required]
            [Description("The number of non-null entries in the grid indices array.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("CellCount")]
            public long? CellCount
            {
                get
                {
                    return CellCountField;
                }
                set
                {
                    CellCountField = value;
                    NotifyPropertyChanged("CellCount");
                }
            }

            private long? CellCountField;

            /// <summary>
            /// GridIndices property
            /// </summary>
            [Required]
            [Description("Size of array = IntervalCount.  Null values signify that interval is not within a grid.  BUSINESS RULE: The cell count must equal the number of non-null entries in this array.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("GridIndices")]
            public AbstractIntegerArray GridIndices
            {
                get
                {
                    return GridIndicesField;
                }
                set
                {
                    GridIndicesField = value;
                    NotifyPropertyChanged("GridIndices");
                }
            }

            private AbstractIntegerArray GridIndicesField;

            /// <summary>
            /// CellIndices property
            /// </summary>
            [Required]
            [Description("The cell index for each interval of a representation. The grid index is specified by grid index array, to give the (Grid,Cell) index pair.  BUSINESS RULE: Array length must equal cell count.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("CellIndices")]
            public AbstractIntegerArray CellIndices
            {
                get
                {
                    return CellIndicesField;
                }
                set
                {
                    CellIndicesField = value;
                    NotifyPropertyChanged("CellIndices");
                }
            }

            private AbstractIntegerArray CellIndicesField;

            /// <summary>
            /// LocalFacePairPerCellIndices property
            /// </summary>
            [Required]
            [Description("For each cell, these are the entry and exit intersection faces of the trajectory in the cell. Use null for missing intersections, e.g., when a trajectory originates or terminates within a cell. The local face-per-cell index is used because a global face index need not have been defined on the grid.  BUSINESS RULE: The array dimensions must equal 2 x CellCount.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("LocalFacePairPerCellIndices")]
            public AbstractIntegerArray LocalFacePairPerCellIndices
            {
                get
                {
                    return LocalFacePairPerCellIndicesField;
                }
                set
                {
                    LocalFacePairPerCellIndicesField = value;
                    NotifyPropertyChanged("LocalFacePairPerCellIndices");
                }
            }

            private AbstractIntegerArray LocalFacePairPerCellIndicesField;

            /// <summary>
            /// Grid property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("Grid")]
            public List<DataObjectReference> Grid
            {
                get
                {
                    return GridField;
                }
                set
                {
                    GridField = value;
                    NotifyPropertyChanged("Grid");
                }
            }

            /// <summary>
            /// bool to indicate if Grid has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool GridSpecified
            {
                get
                {
                    if (GridField != null)
                        return GridField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<DataObjectReference> GridField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Patch1d xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrianglePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(NodePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactPatch))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubRepresentationPatch))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Patch1d", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Patch1d xsd type.")]
        public partial class Patch1d : Patch, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of items in the patch.
            /// </summary>
            [Required]
            [Description("Number of items in the patch.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TrianglePatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TrianglePatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the TrianglePatch xsd type.")]
        public partial class TrianglePatch : Patch1d, INotifyPropertyChanged
        {

            /// <summary>
            /// NodeCount property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("NodeCount")]
            public long? NodeCount
            {
                get
                {
                    return NodeCountField;
                }
                set
                {
                    NodeCountField = value;
                    NotifyPropertyChanged("NodeCount");
                }
            }

            private long? NodeCountField;

            /// <summary>
            /// Triangles property
            /// </summary>
            [Required]
            [Description("The triangles are a 2D array of non-negative integers with the dimensions 3 x numTriangles.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("Triangles")]
            public AbstractIntegerArray Triangles
            {
                get
                {
                    return TrianglesField;
                }
                set
                {
                    TrianglesField = value;
                    NotifyPropertyChanged("Triangles");
                }
            }

            private AbstractIntegerArray TrianglesField;

            /// <summary>
            /// SplitEdgePatch property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "EdgePatch")]
            [XmlElement("SplitEdgePatch")]
            public List<EdgePatch> SplitEdgePatch
            {
                get
                {
                    return SplitEdgePatchField;
                }
                set
                {
                    SplitEdgePatchField = value;
                    NotifyPropertyChanged("SplitEdgePatch");
                }
            }

            /// <summary>
            /// bool to indicate if SplitEdgePatch has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool SplitEdgePatchSpecified
            {
                get
                {
                    if (SplitEdgePatchField != null)
                        return SplitEdgePatchField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<EdgePatch> SplitEdgePatchField;

            /// <summary>
            /// Geometry property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "PointGeometry")]
            [XmlElement("Geometry")]
            public PointGeometry Geometry
            {
                get
                {
                    return GeometryField;
                }
                set
                {
                    GeometryField = value;
                    NotifyPropertyChanged("Geometry");
                }
            }

            private PointGeometry GeometryField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the EdgePatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EdgePatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the EdgePatch xsd type.")]
        public partial class EdgePatch : Patch1d, INotifyPropertyChanged
        {

            /// <summary>
            /// An array of split edges to define patches. It points to an HDF5 dataset, which must be a 2D array of non-negative integers with dimensions 2 x numSplitEdges.
            /// </summary>
            [Description("An array of split edges to define patches. It points to an HDF5 dataset, which must be a 2D array of non-negative integers with dimensions 2 x numSplitEdges.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("SplitEdges")]
            public AbstractIntegerArray SplitEdges
            {
                get
                {
                    return SplitEdgesField;
                }
                set
                {
                    SplitEdgesField = value;
                    NotifyPropertyChanged("SplitEdges");
                }
            }

            private AbstractIntegerArray SplitEdgesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the NodePatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NodePatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the NodePatch xsd type.")]
        public partial class NodePatch : Patch1d, INotifyPropertyChanged
        {

            /// <summary>
            /// Geometry property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "PointGeometry")]
            [XmlElement("Geometry")]
            public PointGeometry Geometry
            {
                get
                {
                    return GeometryField;
                }
                set
                {
                    GeometryField = value;
                    NotifyPropertyChanged("Geometry");
                }
            }

            private PointGeometry GeometryField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ContactPatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ContactPatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ContactPatch xsd type.")]
        public partial class ContactPatch : Patch1d, INotifyPropertyChanged
        {

            /// <summary>
            /// Identifies a representation by its index, in the list of representations contained in the organization.
            /// </summary>
            [Required]
            [Description("Identifies a representation by its index, in the list of representations contained in the organization.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("RepresentationIndex")]
            public long? RepresentationIndex
            {
                get
                {
                    return RepresentationIndexField;
                }
                set
                {
                    RepresentationIndexField = value;
                    NotifyPropertyChanged("RepresentationIndex");
                }
            }

            private long? RepresentationIndexField;

            /// <summary>
            /// The ordered list of nodes (identified by their global index) in the supporting representation, which constitutes the contact patch.
            /// </summary>
            [Required]
            [Description("The ordered list of nodes (identified by their global index) in the supporting representation, which constitutes the contact patch.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("SupportingRepresentationNodes")]
            public AbstractIntegerArray SupportingRepresentationNodes
            {
                get
                {
                    return SupportingRepresentationNodesField;
                }
                set
                {
                    SupportingRepresentationNodesField = value;
                    NotifyPropertyChanged("SupportingRepresentationNodes");
                }
            }

            private AbstractIntegerArray SupportingRepresentationNodesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SubRepresentationPatch xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SubRepresentationPatch", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SubRepresentationPatch xsd type.")]
        public partial class SubRepresentationPatch : Patch1d, INotifyPropertyChanged
        {

            /// <summary>
            /// ElementIndices property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ElementIndices")]
            [XmlElement("ElementIndices")]
            public List<ElementIndices> ElementIndices
            {
                get
                {
                    return ElementIndicesField;
                }
                set
                {
                    ElementIndicesField = value;
                    NotifyPropertyChanged("ElementIndices");
                }
            }

            /// <summary>
            /// bool to indicate if ElementIndices has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ElementIndicesSpecified
            {
                get
                {
                    if (ElementIndicesField != null)
                        return ElementIndicesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ElementIndices> ElementIndicesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ElementIndices xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ElementIndices", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ElementIndices xsd type.")]
        public partial class ElementIndices : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// IndexableElement property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "IndexableElement")]
            [XmlElement("IndexableElement")]
            public IndexableElement? IndexableElement
            {
                get
                {
                    return IndexableElementField;
                }
                set
                {
                    IndexableElementField = value;
                    this.IndexableElementSpecified = true;
                    NotifyPropertyChanged("IndexableElement");
                }
            }


            private bool IndexableElementSpecifiedField = false;

            /// <summary>
            /// IndexableElementSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool IndexableElementSpecified
            {
                get
                {
                    return IndexableElementSpecifiedField;
                }
                set
                {
                    IndexableElementSpecifiedField = value;
                    NotifyPropertyChanged("IndexableElementSpecified");
                }
            }

            private IndexableElement? IndexableElementField;

            /// <summary>
            /// Indices property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("Indices")]
            public AbstractIntegerArray Indices
            {
                get
                {
                    return IndicesField;
                }
                set
                {
                    IndicesField = value;
                    NotifyPropertyChanged("Indices");
                }
            }

            private AbstractIntegerArray IndicesField;

            /// <summary>
            /// SupportingRepresentationIndex property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("SupportingRepresentationIndex")]
            public AbstractIntegerArray SupportingRepresentationIndex
            {
                get
                {
                    return SupportingRepresentationIndexField;
                }
                set
                {
                    SupportingRepresentationIndexField = value;
                    NotifyPropertyChanged("SupportingRepresentationIndex");
                }
            }

            private AbstractIntegerArray SupportingRepresentationIndexField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the StreamlineWellbores xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StreamlineWellbores", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the StreamlineWellbores xsd type.")]
        public partial class StreamlineWellbores : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// InjectorPerLine property
            /// </summary>
            [Required]
            [Description("Size of array = LineCount.  Null values signify that that line does not initiate at an injector, e.g., it may come from fluid expansion or an aquifer.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("InjectorPerLine")]
            public AbstractIntegerArray InjectorPerLine
            {
                get
                {
                    return InjectorPerLineField;
                }
                set
                {
                    InjectorPerLineField = value;
                    NotifyPropertyChanged("InjectorPerLine");
                }
            }

            private AbstractIntegerArray InjectorPerLineField;

            /// <summary>
            /// ProducerPerLine property
            /// </summary>
            [Required]
            [Description("Size of array = LineCount  Null values signify that that line does not terminate at a producer, e.g., it may approach a stagnation area.  BUSINESS RULE: The cell count must equal the number of non-null entries in this array.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ProducerPerLine")]
            public AbstractIntegerArray ProducerPerLine
            {
                get
                {
                    return ProducerPerLineField;
                }
                set
                {
                    ProducerPerLineField = value;
                    NotifyPropertyChanged("ProducerPerLine");
                }
            }

            private AbstractIntegerArray ProducerPerLineField;

            /// <summary>
            /// WellboreTrajectoryRepresentation property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("WellboreTrajectoryRepresentation")]
            public List<DataObjectReference> WellboreTrajectoryRepresentation
            {
                get
                {
                    return WellboreTrajectoryRepresentationField;
                }
                set
                {
                    WellboreTrajectoryRepresentationField = value;
                    NotifyPropertyChanged("WellboreTrajectoryRepresentation");
                }
            }

            /// <summary>
            /// bool to indicate if WellboreTrajectoryRepresentation has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool WellboreTrajectoryRepresentationSpecified
            {
                get
                {
                    if (WellboreTrajectoryRepresentationField != null)
                        return WellboreTrajectoryRepresentationField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<DataObjectReference> WellboreTrajectoryRepresentationField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the WellboreTrajectoryParentIntersection xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "WellboreTrajectoryParentIntersection", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the WellboreTrajectoryParentIntersection xsd type.")]
        public partial class WellboreTrajectoryParentIntersection : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// KickoffMd property
            /// </summary>
            [Required]
            [Description("KickoffMd is the measured depth for the start of the child trajectory, as defined within the child.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("KickoffMd")]
            public double? KickoffMD
            {
                get
                {
                    return KickoffMdField;
                }
                set
                {
                    KickoffMdField = value;
                    NotifyPropertyChanged("KickoffMD");
                }
            }

            private double? KickoffMdField;

            /// <summary>
            /// ParentMd property
            /// </summary>
            [Description("If the kickoff MD in the child (KickoffMd) is different from the kickoff MD in the parent (ParentMd), then specify the ParentMD here. If not specified, then these two MD's are implied to be identical.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("ParentMd")]
            public double? ParentMD
            {
                get
                {
                    return ParentMdField;
                }
                set
                {
                    ParentMdField = value;
                    this.ParentMDSpecified = true;
                    NotifyPropertyChanged("ParentMD");
                }
            }

            private double? ParentMdField;

            /// <summary>
            /// ParentMdSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool ParentMDSpecified
            {
                get
                {
                    return ParentMdSpecifiedField;
                }
                set
                {
                    ParentMdSpecifiedField = value;
                    NotifyPropertyChanged("ParentMDSpecified");
                }
            }

            private bool ParentMdSpecifiedField;

            /// <summary>
            /// ParentTrajectory property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("ParentTrajectory")]
            public DataObjectReference ParentTrajectory
            {
                get
                {
                    return ParentTrajectoryField;
                }
                set
                {
                    ParentTrajectoryField = value;
                    NotifyPropertyChanged("ParentTrajectory");
                }
            }

            private DataObjectReference ParentTrajectoryField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CorrectionInformation xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CorrectionInformation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the CorrectionInformation xsd type.")]
        public partial class CorrectionInformation : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// The UOM is composed by: UOM of the LocalDepth3dCrs of the associated wellbore frame trajectory / UOM of the associated LocalTime3dCrs. If not used, enter zero. 
            /// </summary>
            [Description("The UOM is composed by: UOM of the LocalDepth3dCrs of the associated wellbore frame trajectory / UOM of the associated LocalTime3dCrs.  If not used, enter zero.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlAttribute("CorrectionAverageVelocity")]

            public double CorrectionAverageVelocity
            {
                get
                {
                    return CorrectionAverageVelocityField;
                }
                set
                {
                    CorrectionAverageVelocityField = value;
                    NotifyPropertyChanged("CorrectionAverageVelocity");
                }
            }

            private double CorrectionAverageVelocityField;

            /// <summary>
            /// The UOM is the one specified in the LocalTime3dCrs. If not used, enter zero. 
            /// </summary>
            [Description("The UOM is the one specified in the LocalTime3dCrs.  If not used, enter zero.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlAttribute("CorrectionTimeShift")]

            public double CorrectionTimeShift
            {
                get
                {
                    return CorrectionTimeShiftField;
                }
                set
                {
                    CorrectionTimeShiftField = value;
                    NotifyPropertyChanged("CorrectionTimeShift");
                }
            }

            private double CorrectionTimeShiftField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TvdInformation xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TvdInformation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the TvdInformation xsd type.")]
        public partial class TvdInformation : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// NodeTvdValues property
            /// </summary>
            [Required]
            [Description("Count must be equal to count of nodes of the associated wellbore frame.  The direction of the supporting axis is given by the LocalDepth3dCrs itself. It is necessary to get the information to know what are positive or negative values.  The values are given with respect to the TvdDatum, not with respect to the ZOffest of the LocalDepth3dCrs  The UOM is the one specified in the LocalDepth3dCrs.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("NodeTvdValues")]
            public AbstractFloatingPointArray NodeTvdValues
            {
                get
                {
                    return NodeTvdValuesField;
                }
                set
                {
                    NodeTvdValuesField = value;
                    NotifyPropertyChanged("NodeTvdValues");
                }
            }

            private AbstractFloatingPointArray NodeTvdValuesField;

            /// <summary>
            /// TvdDatum property
            /// </summary>
            [Required]
            [Description("The direction of the supporting axis is given by the LocalDepth3dCrs itself. It is necessary to get the information to know what is a positive or a negative value.  The value is given with respect to the ZOffset of the  LocalDepth3dCrs.  The UOM is the one specified in the LocalDepth3dCrs.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("TvdDatum")]
            public double? TvdDatum
            {
                get
                {
                    return TvdDatumField;
                }
                set
                {
                    TvdDatumField = value;
                    NotifyPropertyChanged("TvdDatum");
                }
            }

            private double? TvdDatumField;

            /// <summary>
            /// TvdReference property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "WellboreDatumReference")]
            [XmlElement("TvdReference")]
            public WellboreDatumReference? TvdReference
            {
                get
                {
                    return TvdReferenceField;
                }
                set
                {
                    TvdReferenceField = value;
                    this.TvdReferenceSpecified = true;
                    NotifyPropertyChanged("TvdReference");
                }
            }


            private bool TvdReferenceSpecifiedField = false;

            /// <summary>
            /// TvdReferenceSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool TvdReferenceSpecified
            {
                get
                {
                    return TvdReferenceSpecifiedField;
                }
                set
                {
                    TvdReferenceSpecifiedField = value;
                    NotifyPropertyChanged("TvdReferenceSpecified");
                }
            }

            private WellboreDatumReference? TvdReferenceField;

            /// <summary>
            /// LocalDepth3dCrs property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("LocalDepth3dCrs")]
            public DataObjectReference LocalDepth3dCrs
            {
                get
                {
                    return LocalDepth3dCrsField;
                }
                set
                {
                    LocalDepth3dCrsField = value;
                    NotifyPropertyChanged("LocalDepth3dCrs");
                }
            }

            private DataObjectReference LocalDepth3dCrsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the PatchBoundaries xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PatchBoundaries", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the PatchBoundaries xsd type.")]
        public partial class PatchBoundaries : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// ReferencedPatch property
            /// </summary>
            [Required]
            [Description("The XML index of the referenced patch inside this representation.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("ReferencedPatch")]
            public long? ReferencedPatch
            {
                get
                {
                    return ReferencedPatchField;
                }
                set
                {
                    ReferencedPatchField = value;
                    NotifyPropertyChanged("ReferencedPatch");
                }
            }

            private long? ReferencedPatchField;

            /// <summary>
            /// InnerRing property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("InnerRing")]
            public List<DataObjectReference> InnerRing
            {
                get
                {
                    return InnerRingField;
                }
                set
                {
                    InnerRingField = value;
                    NotifyPropertyChanged("InnerRing");
                }
            }

            /// <summary>
            /// bool to indicate if InnerRing has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool InnerRingSpecified
            {
                get
                {
                    if (InnerRingField != null)
                        return InnerRingField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<DataObjectReference> InnerRingField;

            /// <summary>
            /// OuterRing property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("OuterRing")]
            public DataObjectReference OuterRing
            {
                get
                {
                    return OuterRingField;
                }
                set
                {
                    OuterRingField = value;
                    NotifyPropertyChanged("OuterRing");
                }
            }

            private DataObjectReference OuterRingField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ConnectionInterpretations xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConnectionInterpretations", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ConnectionInterpretations xsd type.")]
        public partial class ConnectionInterpretations : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// InterpretationIndices property
            /// </summary>
            [Required]
            [Description("Indices for the interpretations for each connection, if any. The use of a RESQML jagged array allows zero or more than one interpretation to be associated with a single connection.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("InterpretationIndices")]
            public JaggedArray InterpretationIndices
            {
                get
                {
                    return InterpretationIndicesField;
                }
                set
                {
                    InterpretationIndicesField = value;
                    NotifyPropertyChanged("InterpretationIndices");
                }
            }

            private JaggedArray InterpretationIndicesField;

            /// <summary>
            /// FeatureInterpretation property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("FeatureInterpretation")]
            public List<DataObjectReference> FeatureInterpretation
            {
                get
                {
                    return FeatureInterpretationField;
                }
                set
                {
                    FeatureInterpretationField = value;
                    NotifyPropertyChanged("FeatureInterpretation");
                }
            }

            /// <summary>
            /// bool to indicate if FeatureInterpretation has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool FeatureInterpretationSpecified
            {
                get
                {
                    if (FeatureInterpretationField != null)
                        return FeatureInterpretationField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<DataObjectReference> FeatureInterpretationField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AlternateCellIndex xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AlternateCellIndex", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AlternateCellIndex xsd type.")]
        public partial class AlternateCellIndex : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CellIndex property
            /// </summary>
            [Required]
            [Description("Defines each alternate cell index for each representation cell. BUSINESS RULE :CellIndex.Count = GridIndex.Count = Representation.Cell.Count")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("CellIndex")]
            public AbstractIntegerArray CellIndex
            {
                get
                {
                    return CellIndexField;
                }
                set
                {
                    CellIndexField = value;
                    NotifyPropertyChanged("CellIndex");
                }
            }

            private AbstractIntegerArray CellIndexField;

            /// <summary>
            /// GridIndex property
            /// </summary>
            [Required]
            [Description("Defines which grid each alternate cell index comes from. The grids are defined by means of an index of the OriginalGrids set. BUSINESS RULE : GridIndex.Count = CellIndex.Count = Representation.Cell.Count")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("GridIndex")]
            public AbstractIntegerArray GridIndex
            {
                get
                {
                    return GridIndexField;
                }
                set
                {
                    GridIndexField = value;
                    NotifyPropertyChanged("GridIndex");
                }
            }

            private AbstractIntegerArray GridIndexField;

            /// <summary>
            /// OriginalGrids property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("OriginalGrids")]
            public List<DataObjectReference> OriginalGrids
            {
                get
                {
                    return OriginalGridsField;
                }
                set
                {
                    OriginalGridsField = value;
                    NotifyPropertyChanged("OriginalGrids");
                }
            }

            /// <summary>
            /// bool to indicate if OriginalGrids has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool OriginalGridsSpecified
            {
                get
                {
                    if (OriginalGridsField != null)
                        return OriginalGridsField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<DataObjectReference> OriginalGridsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ColumnLayerGpGrid xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ColumnLayerGpGrid", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ColumnLayerGpGrid xsd type.")]
        public partial class ColumnLayerGpGrid : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Nk property
            /// </summary>
            [Required]
            [Description("Number of layers. Degenerate case (nk=0) is allowed for GPGrid.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("Nk")]
            public long? Nk
            {
                get
                {
                    return NkField;
                }
                set
                {
                    NkField = value;
                    NotifyPropertyChanged("Nk");
                }
            }

            private long? NkField;

            /// <summary>
            /// KGaps property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "KGaps")]
            [XmlElement("KGaps")]
            public KGaps KGaps
            {
                get
                {
                    return KGapsField;
                }
                set
                {
                    KGapsField = value;
                    NotifyPropertyChanged("KGaps");
                }
            }

            private KGaps KGapsField;

            /// <summary>
            /// UnstructuredColumnLayerGpGridPatch property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "UnstructuredColumnLayerGpGridPatch")]
            [XmlElement("UnstructuredColumnLayerGpGridPatch")]
            public List<UnstructuredColumnLayerGpGridPatch> UnstructuredColumnLayerGpGridPatch
            {
                get
                {
                    return UnstructuredColumnLayerGpGridPatchField;
                }
                set
                {
                    UnstructuredColumnLayerGpGridPatchField = value;
                    NotifyPropertyChanged("UnstructuredColumnLayerGpGridPatch");
                }
            }

            /// <summary>
            /// bool to indicate if UnstructuredColumnLayerGpGridPatch has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool UnstructuredColumnLayerGpGridPatchSpecified
            {
                get
                {
                    if (UnstructuredColumnLayerGpGridPatchField != null)
                        return UnstructuredColumnLayerGpGridPatchField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<UnstructuredColumnLayerGpGridPatch> UnstructuredColumnLayerGpGridPatchField;

            /// <summary>
            /// IjkGpGridPatch property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "IjkGpGridPatch")]
            [XmlElement("IjkGpGridPatch")]
            public List<IjkGpGridPatch> IjkGpGridPatch
            {
                get
                {
                    return IjkGpGridPatchField;
                }
                set
                {
                    IjkGpGridPatchField = value;
                    NotifyPropertyChanged("IjkGpGridPatch");
                }
            }

            /// <summary>
            /// bool to indicate if IjkGpGridPatch has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool IjkGpGridPatchSpecified
            {
                get
                {
                    if (IjkGpGridPatchField != null)
                        return IjkGpGridPatchField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<IjkGpGridPatch> IjkGpGridPatchField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the KGaps xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "KGaps", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the KGaps xsd type.")]
        public partial class KGaps : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of gaps between layers. Must be positive. Number of intervals = gapCount + NK.
            /// </summary>
            [Description("Number of gaps between layers. Must be positive.  Number of intervals = gapCount + NK.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// Boolean array of length NK-1. TRUE if there is a gap after the corresponding layer. NKL = NK + gapCount + 1 BUSINESS RULE: gapCount must be consistent with the number of gaps specified by the gapAfterLayer array.
            /// </summary>
            [Description("Boolean array of length NK-1. TRUE if there is a gap after the corresponding layer.  NKL = NK + gapCount + 1  BUSINESS RULE: gapCount must be consistent with the number of gaps specified by the gapAfterLayer array.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("GapAfterLayer")]
            public AbstractBooleanArray GapAfterLayer
            {
                get
                {
                    return GapAfterLayerField;
                }
                set
                {
                    GapAfterLayerField = value;
                    NotifyPropertyChanged("GapAfterLayer");
                }
            }

            private AbstractBooleanArray GapAfterLayerField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IntervalStratigraphicUnits xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IntervalStratigraphicUnits", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the IntervalStratigraphicUnits xsd type.")]
        public partial class IntervalStratigraphicUnits : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// UnitIndices property
            /// </summary>
            [Required]
            [Description("Index of the stratigraphic unit per interval, of a given stratigraphic column.  Notes: 1.) For grids: if it does not exist a property kind \"geologic k\" attached to the grid then intervals = layers + K gaps else intervals = values property of property kind \"geologic k\" 2.) If there is no stratigraphic column, e.g., within salt, use null value  BUSINESS RULE: Array length must equal the number of intervals.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("UnitIndices")]
            public JaggedArray UnitIndices
            {
                get
                {
                    return UnitIndicesField;
                }
                set
                {
                    UnitIndicesField = value;
                    NotifyPropertyChanged("UnitIndices");
                }
            }

            private JaggedArray UnitIndicesField;

            /// <summary>
            /// StratigraphicOrganizationInterpretation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("StratigraphicOrganizationInterpretation")]
            public DataObjectReference StratigraphicOrganizationInterpretation
            {
                get
                {
                    return StratigraphicOrganizationInterpretationField;
                }
                set
                {
                    StratigraphicOrganizationInterpretationField = value;
                    NotifyPropertyChanged("StratigraphicOrganizationInterpretation");
                }
            }

            private DataObjectReference StratigraphicOrganizationInterpretationField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Intervals xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Intervals", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Intervals xsd type.")]
        public partial class Intervals : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Weights that are proportional to the relative sizes of child cells within each interval. The weights need not be normalized.
            /// </summary>
            [Description("Weights that are proportional to the relative sizes of child cells within each interval. The weights need not be normalized.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("ChildCellWeights")]
            public AbstractFloatingPointArray ChildCellWeights
            {
                get
                {
                    return ChildCellWeightsField;
                }
                set
                {
                    ChildCellWeightsField = value;
                    NotifyPropertyChanged("ChildCellWeights");
                }
            }

            private AbstractFloatingPointArray ChildCellWeightsField;

            /// <summary>
            /// The number of child cells in each interval. If the child grid type is not commensurate with the parent type, then this attribute is ignored by a reader and its value should be set to null value. For example, for a parent IJK grid with a child unstructured column-layer grid, then the child count is non-null for a K regrid, but null for an I or J regrid. BUSINESS RULES: 1.) The array length must be equal to intervalCount. 2.) If the child grid type is commensurate with the parent grid, then the sum of values over all intervals must be equal to the corresponding child grid dimension.
            /// </summary>
            [Required]
            [Description("The number of child cells in each interval.  If the child grid type is not commensurate with the parent type, then this attribute is ignored by a reader and its value should be set to null value. For example, for a parent IJK grid with a child unstructured column-layer grid, then the child count is non-null for a K regrid, but null for an I or J regrid.  BUSINESS RULES: 1.) The array length must be equal to intervalCount. 2.) If the child grid type is commensurate with the parent grid, then the sum of values over all intervals must be equal to the corresponding child grid dimension.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ChildCountPerInterval")]
            public AbstractIntegerArray ChildCountPerInterval
            {
                get
                {
                    return ChildCountPerIntervalField;
                }
                set
                {
                    ChildCountPerIntervalField = value;
                    NotifyPropertyChanged("ChildCountPerInterval");
                }
            }

            private AbstractIntegerArray ChildCountPerIntervalField;

            /// <summary>
            /// The number of intervals in the regrid description. Must be positive.
            /// </summary>
            [Required]
            [Description("The number of intervals in the regrid description. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("IntervalCount")]
            public long? IntervalCount
            {
                get
                {
                    return IntervalCountField;
                }
                set
                {
                    IntervalCountField = value;
                    NotifyPropertyChanged("IntervalCount");
                }
            }

            private long? IntervalCountField;

            /// <summary>
            /// The number of parent cells in each interval. BUSINESS RULES: 1.) The array length must be equal to intervalCount. 2.) For the given parentIndex, the total count of parent cells should not extend beyond the boundary of the parent grid.
            /// </summary>
            [Required]
            [Description("The number of parent cells in each interval.  BUSINESS RULES: 1.) The array length must be equal to intervalCount. 2.) For the given parentIndex, the total count of parent cells should not extend beyond the boundary of the parent grid.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ParentCountPerInterval")]
            public AbstractIntegerArray ParentCountPerInterval
            {
                get
                {
                    return ParentCountPerIntervalField;
                }
                set
                {
                    ParentCountPerIntervalField = value;
                    NotifyPropertyChanged("ParentCountPerInterval");
                }
            }

            private AbstractIntegerArray ParentCountPerIntervalField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Regrid xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Regrid", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Regrid xsd type.")]
        public partial class Regrid : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// InitialIndexOnParentGrid property
            /// </summary>
            [Required]
            [Description("0-based index for the placement of the window on the parent grid.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("InitialIndexOnParentGrid")]
            public long? InitialIndexOnParentGrid
            {
                get
                {
                    return InitialIndexOnParentGridField;
                }
                set
                {
                    InitialIndexOnParentGridField = value;
                    NotifyPropertyChanged("InitialIndexOnParentGrid");
                }
            }

            private long? InitialIndexOnParentGridField;

            /// <summary>
            /// Intervals property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "Intervals")]
            [XmlElement("Intervals")]
            public Intervals Intervals
            {
                get
                {
                    return IntervalsField;
                }
                set
                {
                    IntervalsField = value;
                    NotifyPropertyChanged("Intervals");
                }
            }

            private Intervals IntervalsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the OverlapVolume xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OverlapVolume", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the OverlapVolume xsd type.")]
        public partial class OverlapVolume : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Parent-child cell volume overlap. BUSINESS RULE: Length of array must equal the cell overlap count.
            /// </summary>
            [Description("Parent-child cell volume overlap.  BUSINESS RULE: Length of array must equal the cell overlap count.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("OverlapVolumes")]
            public AbstractFloatingPointArray OverlapVolumes
            {
                get
                {
                    return OverlapVolumesField;
                }
                set
                {
                    OverlapVolumesField = value;
                    NotifyPropertyChanged("OverlapVolumes");
                }
            }

            private AbstractFloatingPointArray OverlapVolumesField;

            /// <summary>
            /// Units of measure for the overlapVolume.
            /// </summary>
            [Description("Units of measure for the overlapVolume.")]
            [EnergisticsDataTypeAttribute(DataType = "VolumeUom")]
            [XmlElement("VolumeUom")]
            public VolumeUom? VolumeUom
            {
                get
                {
                    return VolumeUomField;
                }
                set
                {
                    VolumeUomField = value;
                    this.VolumeUomSpecified = true;
                    NotifyPropertyChanged("VolumeUom");
                }
            }


            private bool VolumeUomSpecifiedField = false;

            /// <summary>
            /// VolumeUomSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool VolumeUomSpecified
            {
                get
                {
                    return VolumeUomSpecifiedField;
                }
                set
                {
                    VolumeUomSpecifiedField = value;
                    NotifyPropertyChanged("VolumeUomSpecified");
                }
            }

            private VolumeUom? VolumeUomField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CellOverlap xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CellOverlap", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the CellOverlap xsd type.")]
        public partial class CellOverlap : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Count property
            /// </summary>
            [Description("Number of parent-child cell overlaps. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// ParentChildCellPairs property
            /// </summary>
            [Description("(Parent cell index, child cell index) pair for each overlap.  BUSINESS RULE: Length of array must equal 2 x overlapCount.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ParentChildCellPairs")]
            public AbstractIntegerArray ParentChildCellPairs
            {
                get
                {
                    return ParentChildCellPairsField;
                }
                set
                {
                    ParentChildCellPairsField = value;
                    NotifyPropertyChanged("ParentChildCellPairs");
                }
            }

            private AbstractIntegerArray ParentChildCellPairsField;

            /// <summary>
            /// OverlapVolume property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "OverlapVolume")]
            [XmlElement("OverlapVolume")]
            public OverlapVolume OverlapVolume
            {
                get
                {
                    return OverlapVolumeField;
                }
                set
                {
                    OverlapVolumeField = value;
                    NotifyPropertyChanged("OverlapVolume");
                }
            }

            private OverlapVolume OverlapVolumeField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractParentWindow xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IjkParentWindow))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ColumnLayerParentWindow))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CellParentWindow))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractParentWindow", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractParentWindow xsd type.")]
        public abstract partial class AbstractParentWindow : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CellOverlap property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "CellOverlap")]
            [XmlElement("CellOverlap")]
            public CellOverlap CellOverlap
            {
                get
                {
                    return CellOverlapField;
                }
                set
                {
                    CellOverlapField = value;
                    NotifyPropertyChanged("CellOverlap");
                }
            }

            private CellOverlap CellOverlapField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IjkParentWindow xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IjkParentWindow", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the IjkParentWindow xsd type.")]
        public partial class IjkParentWindow : AbstractParentWindow, INotifyPropertyChanged
        {

            /// <summary>
            /// OmitParentCells property
            /// </summary>
            [Description("List of parent cells that are to be retained at their original resolution and are not to be included within a local grid. The \"omit\" allows non-rectangular local grids to be specified.  0-based indexing follows NI x NJ x NK relative to the parent window cell count—not to the parent grid.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("OmitParentCells")]
            public AbstractIntegerArray OmitParentCells
            {
                get
                {
                    return OmitParentCellsField;
                }
                set
                {
                    OmitParentCellsField = value;
                    NotifyPropertyChanged("OmitParentCells");
                }
            }

            private AbstractIntegerArray OmitParentCellsField;

            /// <summary>
            /// JRegrid property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "Regrid")]
            [XmlElement("JRegrid")]
            public Regrid JRegrid
            {
                get
                {
                    return JRegridField;
                }
                set
                {
                    JRegridField = value;
                    NotifyPropertyChanged("JRegrid");
                }
            }

            private Regrid JRegridField;

            /// <summary>
            /// KRegrid property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "Regrid")]
            [XmlElement("KRegrid")]
            public Regrid KRegrid
            {
                get
                {
                    return KRegridField;
                }
                set
                {
                    KRegridField = value;
                    NotifyPropertyChanged("KRegrid");
                }
            }

            private Regrid KRegridField;

            /// <summary>
            /// IRegrid property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "Regrid")]
            [XmlElement("IRegrid")]
            public Regrid IRegrid
            {
                get
                {
                    return IRegridField;
                }
                set
                {
                    IRegridField = value;
                    NotifyPropertyChanged("IRegrid");
                }
            }

            private Regrid IRegridField;

            /// <summary>
            /// ParentIjkGridRepresentation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("ParentIjkGridRepresentation")]
            public DataObjectReference ParentIjkGridRepresentation
            {
                get
                {
                    return ParentIjkGridRepresentationField;
                }
                set
                {
                    ParentIjkGridRepresentationField = value;
                    NotifyPropertyChanged("ParentIjkGridRepresentation");
                }
            }

            private DataObjectReference ParentIjkGridRepresentationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ColumnLayerParentWindow xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ColumnLayerParentWindow", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ColumnLayerParentWindow xsd type.")]
        public partial class ColumnLayerParentWindow : AbstractParentWindow, INotifyPropertyChanged
        {

            /// <summary>
            /// ColumnIndices property
            /// </summary>
            [Required]
            [Description("Column indices that list the columns in the parent window.  BUSINESS RULE: Number of columns must be consistent with the child grid column count.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ColumnIndices")]
            public AbstractIntegerArray ColumnIndices
            {
                get
                {
                    return ColumnIndicesField;
                }
                set
                {
                    ColumnIndicesField = value;
                    NotifyPropertyChanged("ColumnIndices");
                }
            }

            private AbstractIntegerArray ColumnIndicesField;

            /// <summary>
            /// OmitParentCells property
            /// </summary>
            [Description("List of parent cells that are to be retained at their original resolution and are not to be included within a local grid. The \"omit\" allows non-rectangular local grids to be specified.  0-based indexing follows #Columns x #Layers relative to the parent window cell count, not to the parent grid.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("OmitParentCells")]
            public AbstractIntegerArray OmitParentCells
            {
                get
                {
                    return OmitParentCellsField;
                }
                set
                {
                    OmitParentCellsField = value;
                    NotifyPropertyChanged("OmitParentCells");
                }
            }

            private AbstractIntegerArray OmitParentCellsField;

            /// <summary>
            /// KRegrid property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "Regrid")]
            [XmlElement("KRegrid")]
            public Regrid KRegrid
            {
                get
                {
                    return KRegridField;
                }
                set
                {
                    KRegridField = value;
                    NotifyPropertyChanged("KRegrid");
                }
            }

            private Regrid KRegridField;

            /// <summary>
            /// ParentColumnLayerGridRepresentation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("ParentColumnLayerGridRepresentation")]
            public DataObjectReference ParentColumnLayerGridRepresentation
            {
                get
                {
                    return ParentColumnLayerGridRepresentationField;
                }
                set
                {
                    ParentColumnLayerGridRepresentationField = value;
                    NotifyPropertyChanged("ParentColumnLayerGridRepresentation");
                }
            }

            private DataObjectReference ParentColumnLayerGridRepresentationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CellParentWindow xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CellParentWindow", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the CellParentWindow xsd type.")]
        public partial class CellParentWindow : AbstractParentWindow, INotifyPropertyChanged
        {

            /// <summary>
            /// CellIndices property
            /// </summary>
            [Required]
            [Description("Cell indices that list the cells in the parent window.  BUSINESS RULE: Number of cells must be consistent with the child grid cell count.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("CellIndices")]
            public AbstractIntegerArray CellIndices
            {
                get
                {
                    return CellIndicesField;
                }
                set
                {
                    CellIndicesField = value;
                    NotifyPropertyChanged("CellIndices");
                }
            }

            private AbstractIntegerArray CellIndicesField;

            /// <summary>
            /// ParentGridRepresentation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("ParentGridRepresentation")]
            public DataObjectReference ParentGridRepresentation
            {
                get
                {
                    return ParentGridRepresentationField;
                }
                set
                {
                    ParentGridRepresentationField = value;
                    NotifyPropertyChanged("ParentGridRepresentation");
                }
            }

            private DataObjectReference ParentGridRepresentationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CellFluidPhaseUnits xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CellFluidPhaseUnits", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the CellFluidPhaseUnits xsd type.")]
        public partial class CellFluidPhaseUnits : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// PhaseUnitIndices property
            /// </summary>
            [Required]
            [Description("Index of the phase unit kind within a given fluid phase organization for each cell. Follows the indexing defined by the PhaseUnit enumeration. When applied to the wellbore frame representation, the indexing is identical to the number of intervals. Since a single cell or interval may corresponds to several units, the mapping is done using a jagged array.  Use null value if no fluid phase is present, e.g., within the seal.  BUSINESS RULE: Array length is equal to the number of cells in the representation (grid, wellbore frame or blocked well).")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "JaggedArray")]
            [XmlElement("PhaseUnitIndices")]
            public JaggedArray PhaseUnitIndices
            {
                get
                {
                    return PhaseUnitIndicesField;
                }
                set
                {
                    PhaseUnitIndicesField = value;
                    NotifyPropertyChanged("PhaseUnitIndices");
                }
            }

            private JaggedArray PhaseUnitIndicesField;

            /// <summary>
            /// RockFluidOrganizationInterpretation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("RockFluidOrganizationInterpretation")]
            public DataObjectReference RockFluidOrganizationInterpretation
            {
                get
                {
                    return RockFluidOrganizationInterpretationField;
                }
                set
                {
                    RockFluidOrganizationInterpretationField = value;
                    NotifyPropertyChanged("RockFluidOrganizationInterpretation");
                }
            }

            private DataObjectReference RockFluidOrganizationInterpretationField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the OrientedMacroFace xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OrientedMacroFace", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the OrientedMacroFace xsd type.")]
        public partial class OrientedMacroFace : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Creates the triangulation and 2D grid representation for which the patches match the macrofaces.
            /// </summary>
            [Required]
            [Description("Creates the triangulation and 2D grid representation for which the patches match the macrofaces.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("PatchIndexOfRepresentation")]
            public long? PatchIndexOfRepresentation
            {
                get
                {
                    return PatchIndexOfRepresentationField;
                }
                set
                {
                    PatchIndexOfRepresentationField = value;
                    NotifyPropertyChanged("PatchIndexOfRepresentation");
                }
            }

            private long? PatchIndexOfRepresentationField;

            /// <summary>
            /// Identifies the representation by its index, in the list of representations contained in the organization.
            /// </summary>
            [Required]
            [Description("Identifies the representation by its index, in the list of representations contained in the organization.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("RepresentationIndex")]
            public long? RepresentationIndex
            {
                get
                {
                    return RepresentationIndexField;
                }
                set
                {
                    RepresentationIndexField = value;
                    NotifyPropertyChanged("RepresentationIndex");
                }
            }

            private long? RepresentationIndexField;

            /// <summary>
            /// Because a user must represent the two sides of a macro face that correspond to the same patch (identified by a PatchIndexOfRepresentation) of a Representation (identified by a RepresentationIndex), then he must define each side by its orientation. Each macro face has two orientations: A positive one and a negative one. The positive one is declared by setting SideIsPlus = True; the negative one is declared by setting SideIsPlus = False. This attribute allows us to define different property distributions on the different macro face sides.
            /// </summary>
            [Required]
            [Description("Because a user must represent the two sides of a macro face that correspond to the same patch (identified by a PatchIndexOfRepresentation) of a Representation (identified by a RepresentationIndex), then he must define each side by its orientation. Each macro face has two orientations: A positive one and a negative one. The positive one is declared by setting SideIsPlus = True; the negative one is declared by setting SideIsPlus = False.  This attribute allows us to define different property distributions on the different macro face sides.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("SideIsPlus")]
            public bool? SideIsPlus
            {
                get
                {
                    return SideIsPlusField;
                }
                set
                {
                    SideIsPlusField = value;
                    NotifyPropertyChanged("SideIsPlus");
                }
            }

            private bool? SideIsPlusField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the VolumeShell xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VolumeShell", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the VolumeShell xsd type.")]
        public partial class VolumeShell : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// ShellUid property
            /// </summary>
            [Required]
            [StringLength(64)]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("ShellUid")]
            public string ShellUid
            {
                get
                {
                    return ShellUidField;
                }
                set
                {
                    ShellUidField = value;
                    NotifyPropertyChanged("ShellUid");
                }
            }

            private string ShellUidField;

            /// <summary>
            /// MacroFaces property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "OrientedMacroFace")]
            [XmlElement("MacroFaces")]
            public List<OrientedMacroFace> MacroFaces
            {
                get
                {
                    return MacroFacesField;
                }
                set
                {
                    MacroFacesField = value;
                    NotifyPropertyChanged("MacroFaces");
                }
            }

            /// <summary>
            /// bool to indicate if MacroFaces has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool MacroFacesSpecified
            {
                get
                {
                    if (MacroFacesField != null)
                        return MacroFacesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<OrientedMacroFace> MacroFacesField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the VolumeRegion xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VolumeRegion", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the VolumeRegion xsd type.")]
        public partial class VolumeRegion : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// PatchIndex property
            /// </summary>
            [Required]
            [Description("This patch index is used to enumerate the volume regions.  Known issue (2.0): Patch Index should  inherit from patch, instead of being listed as a volume region element.  Volume regions must be considered as a patch in version 2.0 (even if now, this volume region is not literally inheriting from the patch class).")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("PatchIndex")]
            public long? PatchIndex
            {
                get
                {
                    return PatchIndexField;
                }
                set
                {
                    PatchIndexField = value;
                    NotifyPropertyChanged("PatchIndex");
                }
            }

            private long? PatchIndexField;

            /// <summary>
            /// InternalShells property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "VolumeShell")]
            [XmlElement("InternalShells")]
            public List<VolumeShell> InternalShells
            {
                get
                {
                    return InternalShellsField;
                }
                set
                {
                    InternalShellsField = value;
                    NotifyPropertyChanged("InternalShells");
                }
            }

            /// <summary>
            /// bool to indicate if InternalShells has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool InternalShellsSpecified
            {
                get
                {
                    if (InternalShellsField != null)
                        return InternalShellsField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<VolumeShell> InternalShellsField;

            /// <summary>
            /// ExternalShell property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "VolumeShell")]
            [XmlElement("ExternalShell")]
            public VolumeShell ExternalShell
            {
                get
                {
                    return ExternalShellField;
                }
                set
                {
                    ExternalShellField = value;
                    NotifyPropertyChanged("ExternalShell");
                }
            }

            private VolumeShell ExternalShellField;

            /// <summary>
            /// Represents property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("Represents")]
            public DataObjectReference Represents
            {
                get
                {
                    return RepresentsField;
                }
                set
                {
                    RepresentsField = value;
                    NotifyPropertyChanged("Represents");
                }
            }

            private DataObjectReference RepresentsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractContactRepresentationPart xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SealedContactRepresentationPart))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonSealedContactRepresentationPart))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactRepresentationReference))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractContactRepresentationPart", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractContactRepresentationPart xsd type.")]
        public abstract partial class AbstractContactRepresentationPart : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// The index of the contact. Indicates identity of the contact in the surface framework context. It is used for contact identities and to find the interpretation of this particular contact.
            /// </summary>
            [Required]
            [Description("The index of the contact. Indicates identity of the contact in the surface framework context. It is used for contact identities and to find the interpretation of this particular contact.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("Index")]
            public long? Index
            {
                get
                {
                    return IndexField;
                }
                set
                {
                    IndexField = value;
                    NotifyPropertyChanged("Index");
                }
            }

            private long? IndexField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SealedContactRepresentationPart xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SealedContactRepresentationPart", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SealedContactRepresentationPart xsd type.")]
        public partial class SealedContactRepresentationPart : AbstractContactRepresentationPart, INotifyPropertyChanged
        {

            /// <summary>
            /// IdenticalNodeIndices property
            /// </summary>
            [Description("Indicates which nodes (identified by their common index in all contact patches) of the contact patches are identical.  If this list is not present, then it indicates that all nodes in each representation are identical, on an element-by-element level.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("IdenticalNodeIndices")]
            public AbstractIntegerArray IdenticalNodeIndices
            {
                get
                {
                    return IdenticalNodeIndicesField;
                }
                set
                {
                    IdenticalNodeIndicesField = value;
                    NotifyPropertyChanged("IdenticalNodeIndices");
                }
            }

            private AbstractIntegerArray IdenticalNodeIndicesField;

            /// <summary>
            /// IdentityKind property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "IdentityKind")]
            [XmlElement("IdentityKind")]
            public IdentityKind? IdentityKind
            {
                get
                {
                    return IdentityKindField;
                }
                set
                {
                    IdentityKindField = value;
                    this.IdentityKindSpecified = true;
                    NotifyPropertyChanged("IdentityKind");
                }
            }


            private bool IdentityKindSpecifiedField = false;

            /// <summary>
            /// IdentityKindSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool IdentityKindSpecified
            {
                get
                {
                    return IdentityKindSpecifiedField;
                }
                set
                {
                    IdentityKindSpecifiedField = value;
                    NotifyPropertyChanged("IdentityKindSpecified");
                }
            }

            private IdentityKind? IdentityKindField;

            /// <summary>
            /// Contact property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ContactPatch")]
            [XmlElement("Contact")]
            public List<ContactPatch> Contact
            {
                get
                {
                    return ContactField;
                }
                set
                {
                    ContactField = value;
                    NotifyPropertyChanged("Contact");
                }
            }

            /// <summary>
            /// bool to indicate if Contact has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ContactSpecified
            {
                get
                {
                    if (ContactField != null)
                        return ContactField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ContactPatch> ContactField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the NonSealedContactRepresentationPart xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NonSealedContactRepresentationPart", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the NonSealedContactRepresentationPart xsd type.")]
        public partial class NonSealedContactRepresentationPart : AbstractContactRepresentationPart, INotifyPropertyChanged
        {

            /// <summary>
            /// Contact property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ContactPatch")]
            [XmlElement("Contact")]
            public List<ContactPatch> Contact
            {
                get
                {
                    return ContactField;
                }
                set
                {
                    ContactField = value;
                    NotifyPropertyChanged("Contact");
                }
            }

            /// <summary>
            /// bool to indicate if Contact has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ContactSpecified
            {
                get
                {
                    if (ContactField != null)
                        return ContactField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ContactPatch> ContactField;

            /// <summary>
            /// Geometry property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "AbstractGeometry")]
            [XmlElement("Geometry")]
            public AbstractGeometry Geometry
            {
                get
                {
                    return GeometryField;
                }
                set
                {
                    GeometryField = value;
                    NotifyPropertyChanged("Geometry");
                }
            }

            private AbstractGeometry GeometryField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ContactRepresentationReference xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ContactRepresentationReference", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ContactRepresentationReference xsd type.")]
        public partial class ContactRepresentationReference : AbstractContactRepresentationPart, INotifyPropertyChanged
        {

            /// <summary>
            /// Representation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("Representation")]
            public DataObjectReference Representation
            {
                get
                {
                    return RepresentationField;
                }
                set
                {
                    RepresentationField = value;
                    NotifyPropertyChanged("Representation");
                }
            }

            private DataObjectReference RepresentationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ContactIdentity xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ContactIdentity", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ContactIdentity xsd type.")]
        public partial class ContactIdentity : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// The kind of contact identity.
            /// </summary>
            [Required]
            [Description("The kind of contact identity.")]
            [EnergisticsDataTypeAttribute(DataType = "IdentityKind")]
            [XmlElement("IdentityKind")]
            public IdentityKind? IdentityKind
            {
                get
                {
                    return IdentityKindField;
                }
                set
                {
                    IdentityKindField = value;
                    this.IdentityKindSpecified = true;
                    NotifyPropertyChanged("IdentityKind");
                }
            }


            private bool IdentityKindSpecifiedField = false;

            /// <summary>
            /// IdentityKindSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool IdentityKindSpecified
            {
                get
                {
                    return IdentityKindSpecifiedField;
                }
                set
                {
                    IdentityKindSpecifiedField = value;
                    NotifyPropertyChanged("IdentityKindSpecified");
                }
            }

            private IdentityKind? IdentityKindField;

            /// <summary>
            /// The contact representations that share common identity as specified by their indices.
            /// </summary>
            [Required]
            [Description("The contact representations that share common identity as specified by their indices.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ListOfContactRepresentations")]
            public AbstractIntegerArray ListOfContactRepresentations
            {
                get
                {
                    return ListOfContactRepresentationsField;
                }
                set
                {
                    ListOfContactRepresentationsField = value;
                    NotifyPropertyChanged("ListOfContactRepresentations");
                }
            }

            private AbstractIntegerArray ListOfContactRepresentationsField;

            /// <summary>
            /// Indicates which nodes (identified by their common index in all contact representations) of the contact representations are identical. If this list is not present, then it indicates that all nodes in each representation are identical, on an element by element level.
            /// </summary>
            [Description("Indicates which nodes (identified by their common index in all contact representations) of the contact representations are identical.  If this list is not present, then it indicates that all nodes in each representation are identical, on an element by element level.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ListOfIdenticalNodes")]
            public AbstractIntegerArray ListOfIdenticalNodes
            {
                get
                {
                    return ListOfIdenticalNodesField;
                }
                set
                {
                    ListOfIdenticalNodesField = value;
                    NotifyPropertyChanged("ListOfIdenticalNodes");
                }
            }

            private AbstractIntegerArray ListOfIdenticalNodesField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the PatchOfGeometry xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PatchOfGeometry", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the PatchOfGeometry xsd type.")]
        public partial class PatchOfGeometry : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// RepresentationPatchIndex property
            /// </summary>
            [Description("Patch index for the geometry attachment, if required.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("RepresentationPatchIndex")]
            public long? RepresentationPatchIndex
            {
                get
                {
                    return RepresentationPatchIndexField;
                }
                set
                {
                    RepresentationPatchIndexField = value;
                    this.RepresentationPatchIndexSpecified = true;
                    NotifyPropertyChanged("RepresentationPatchIndex");
                }
            }

            private long? RepresentationPatchIndexField;

            /// <summary>
            /// RepresentationPatchIndexSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool RepresentationPatchIndexSpecified
            {
                get
                {
                    return RepresentationPatchIndexSpecifiedField;
                }
                set
                {
                    RepresentationPatchIndexSpecifiedField = value;
                    NotifyPropertyChanged("RepresentationPatchIndexSpecified");
                }
            }

            private bool RepresentationPatchIndexSpecifiedField;

            /// <summary>
            /// Geometry property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "AbstractGeometry")]
            [XmlElement("Geometry")]
            public AbstractGeometry Geometry
            {
                get
                {
                    return GeometryField;
                }
                set
                {
                    GeometryField = value;
                    NotifyPropertyChanged("Geometry");
                }
            }

            private AbstractGeometry GeometryField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the BoundaryFeatureInterpretationPlusItsRank xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BoundaryFeatureInterpretationPlusItsRank", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the BoundaryFeatureInterpretationPlusItsRank xsd type.")]
        public partial class BoundaryFeatureInterpretationPlusItsRank : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// StratigraphicRank property
            /// </summary>
            [Description("The first rank on which you find the boundary or the interpretation set of boundaries.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("StratigraphicRank")]
            public long? StratigraphicRank
            {
                get
                {
                    return StratigraphicRankField;
                }
                set
                {
                    StratigraphicRankField = value;
                    this.StratigraphicRankSpecified = true;
                    NotifyPropertyChanged("StratigraphicRank");
                }
            }

            private long? StratigraphicRankField;

            /// <summary>
            /// StratigraphicRankSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool StratigraphicRankSpecified
            {
                get
                {
                    return StratigraphicRankSpecifiedField;
                }
                set
                {
                    StratigraphicRankSpecifiedField = value;
                    NotifyPropertyChanged("StratigraphicRankSpecified");
                }
            }

            private bool StratigraphicRankSpecifiedField;

            /// <summary>
            /// FaultCollection property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "FeatureInterpretationSet")]
            [XmlElement("FaultCollection")]
            public FeatureInterpretationSet FaultCollection
            {
                get
                {
                    return FaultCollectionField;
                }
                set
                {
                    FaultCollectionField = value;
                    NotifyPropertyChanged("FaultCollection");
                }
            }

            private FeatureInterpretationSet FaultCollectionField;

            /// <summary>
            /// BoundaryFeatureInterpretation property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("BoundaryFeatureInterpretation")]
            public DataObjectReference BoundaryFeatureInterpretation
            {
                get
                {
                    return BoundaryFeatureInterpretationField;
                }
                set
                {
                    BoundaryFeatureInterpretationField = value;
                    NotifyPropertyChanged("BoundaryFeatureInterpretation");
                }
            }

            private DataObjectReference BoundaryFeatureInterpretationField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the FeatureInterpretationSet xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeatureInterpretationSet", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the FeatureInterpretationSet xsd type.")]
        public partial class FeatureInterpretationSet : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {

            /// <summary>
            /// IsHomogeneous property
            /// </summary>
            [Required]
            [Description("Indicates that all of the selected interpretations are of a single kind.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("IsHomogeneous")]
            public bool? IsHomogeneous
            {
                get
                {
                    return IsHomogeneousField;
                }
                set
                {
                    IsHomogeneousField = value;
                    NotifyPropertyChanged("IsHomogeneous");
                }
            }

            private bool? IsHomogeneousField;

            /// <summary>
            /// FeatureInterpretation property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("FeatureInterpretation")]
            public List<DataObjectReference> FeatureInterpretation
            {
                get
                {
                    return FeatureInterpretationField;
                }
                set
                {
                    FeatureInterpretationField = value;
                    NotifyPropertyChanged("FeatureInterpretation");
                }
            }

            /// <summary>
            /// bool to indicate if FeatureInterpretation has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool FeatureInterpretationSpecified
            {
                get
                {
                    if (FeatureInterpretationField != null)
                        return FeatureInterpretationField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<DataObjectReference> FeatureInterpretationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractContactInterpretationPart xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultipleContactInterpretationPart))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryContactInterpretationPart))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractContactInterpretationPart", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractContactInterpretationPart xsd type.")]
        public abstract partial class AbstractContactInterpretationPart : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// PartOf property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("PartOf")]
            public DataObjectReference PartOf
            {
                get
                {
                    return PartOfField;
                }
                set
                {
                    PartOfField = value;
                    NotifyPropertyChanged("PartOf");
                }
            }

            private DataObjectReference PartOfField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the MultipleContactInterpretationPart xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MultipleContactInterpretationPart", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the MultipleContactInterpretationPart xsd type.")]
        public partial class MultipleContactInterpretationPart : AbstractContactInterpretationPart, INotifyPropertyChanged
        {

            /// <summary>
            /// Indicates a list of binary contacts (by their UUIDs) that participate in this multiple-part contact.
            /// </summary>
            [Required]
            [Description("Indicates a list of binary contacts (by their UUIDs) that participate in this multiple-part contact.")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("With")]
            public List<long> With
            {
                get
                {
                    return WithField;
                }
                set
                {
                    WithField = value;
                    NotifyPropertyChanged("With");
                }
            }

            /// <summary>
            /// bool to indicate if With has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool WithSpecified
            {
                get
                {
                    if (WithField != null)
                        return WithField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<long> WithField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the BinaryContactInterpretationPart xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BinaryContactInterpretationPart", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the BinaryContactInterpretationPart xsd type.")]
        public partial class BinaryContactInterpretationPart : AbstractContactInterpretationPart, INotifyPropertyChanged
        {

            /// <summary>
            /// DirectObject property
            /// </summary>
            [Required]
            [Description("Data-object reference (by UUID link) to a geologic feature-interpretation, which is the direct object of the sentence that defines how the contact was constructed.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "ContactElementReference")]
            [XmlElement("DirectObject")]
            public ContactElementReference DirectObject
            {
                get
                {
                    return DirectObjectField;
                }
                set
                {
                    DirectObjectField = value;
                    NotifyPropertyChanged("DirectObject");
                }
            }

            private ContactElementReference DirectObjectField;

            /// <summary>
            /// Subject property
            /// </summary>
            [Required]
            [Description("Data-object reference (by UUID link) to a geologic feature-interpretation, which is the subject of the sentence that defines how the contact was constructed.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "ContactElementReference")]
            [XmlElement("Subject")]
            public ContactElementReference Subject
            {
                get
                {
                    return SubjectField;
                }
                set
                {
                    SubjectField = value;
                    NotifyPropertyChanged("Subject");
                }
            }

            private ContactElementReference SubjectField;

            /// <summary>
            /// Verb property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "ContactVerb")]
            [XmlElement("Verb")]
            public ContactVerb? Verb
            {
                get
                {
                    return VerbField;
                }
                set
                {
                    VerbField = value;
                    this.VerbSpecified = true;
                    NotifyPropertyChanged("Verb");
                }
            }


            private bool VerbSpecifiedField = false;

            /// <summary>
            /// VerbSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool VerbSpecified
            {
                get
                {
                    return VerbSpecifiedField;
                }
                set
                {
                    VerbSpecifiedField = value;
                    NotifyPropertyChanged("VerbSpecified");
                }
            }

            private ContactVerb? VerbField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the FaultThrow xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FaultThrow", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the FaultThrow xsd type.")]
        public partial class FaultThrow : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Throw property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "ThrowKindExt")]
            [XmlElement("Throw")]
            public ExtensibleEnum<ThrowKind>? Throw
            {
                get
                {
                    return ThrowField;
                }
                set
                {
                    ThrowField = value;
                    NotifyPropertyChanged("Throw");
                }
            }

            private ExtensibleEnum<ThrowKind>? ThrowField;

            /// <summary>
            /// HasOccurredDuring property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "AbstractTimeInterval")]
            [XmlElement("HasOccurredDuring")]
            public AbstractTimeInterval HasOccurredDuring
            {
                get
                {
                    return HasOccurredDuringField;
                }
                set
                {
                    HasOccurredDuringField = value;
                    NotifyPropertyChanged("HasOccurredDuring");
                }
            }

            private AbstractTimeInterval HasOccurredDuringField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractTimeInterval xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeneticBoundaryBasedTimeInterval))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeologicTimeBasedTimeInterval))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractTimeInterval", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractTimeInterval xsd type.")]
        public abstract partial class AbstractTimeInterval : Object, INotifyPropertyChanged
        {



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the GeneticBoundaryBasedTimeInterval xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeneticBoundaryBasedTimeInterval", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the GeneticBoundaryBasedTimeInterval xsd type.")]
        public partial class GeneticBoundaryBasedTimeInterval : AbstractTimeInterval, INotifyPropertyChanged
        {

            /// <summary>
            /// ChronoBottom property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("ChronoBottom")]
            public DataObjectReference ChronoBottom
            {
                get
                {
                    return ChronoBottomField;
                }
                set
                {
                    ChronoBottomField = value;
                    NotifyPropertyChanged("ChronoBottom");
                }
            }

            private DataObjectReference ChronoBottomField;

            /// <summary>
            /// ChronoTop property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("ChronoTop")]
            public DataObjectReference ChronoTop
            {
                get
                {
                    return ChronoTopField;
                }
                set
                {
                    ChronoTopField = value;
                    NotifyPropertyChanged("ChronoTop");
                }
            }

            private DataObjectReference ChronoTopField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the GeologicTimeBasedTimeInterval xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeologicTimeBasedTimeInterval", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the GeologicTimeBasedTimeInterval xsd type.")]
        public partial class GeologicTimeBasedTimeInterval : AbstractTimeInterval, INotifyPropertyChanged
        {

            /// <summary>
            /// Start property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "GeologicTime")]
            [XmlElement("Start")]
            public GeologicTime Start
            {
                get
                {
                    return StartField;
                }
                set
                {
                    StartField = value;
                    NotifyPropertyChanged("Start");
                }
            }

            private GeologicTime StartField;

            /// <summary>
            /// End property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "GeologicTime")]
            [XmlElement("End")]
            public GeologicTime End
            {
                get
                {
                    return EndField;
                }
                set
                {
                    EndField = value;
                    NotifyPropertyChanged("End");
                }
            }

            private GeologicTime EndField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the PlaneAngleMeasure xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PlaneAngleMeasure", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the PlaneAngleMeasure xsd type.")]
        public partial class PlaneAngleMeasure : Object, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the PlaneAngleMeasure class.
            /// </summary>
            public PlaneAngleMeasure() { }

            /// <summary>
            /// Initializes a new instance of the PlaneAngleMeasure class.
            /// </summary>
            /// <param name="value">Initial value</param>
            /// <param name="uom">Initial unit of measure</param>
            public PlaneAngleMeasure(double value, PlaneAngleUom uom)
            {
                this.Uom = uom;
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value + " " + Uom;
            }

            /// <summary>
            /// uom property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "PlaneAngleUom")]
            [XmlAttribute("uom")]

            public PlaneAngleUom Uom
            {
                get
                {
                    return uomField;
                }
                set
                {
                    uomField = value;
                    NotifyPropertyChanged("Uom");
                }
            }

            private PlaneAngleUom uomField;

            /// <summary>
            /// Value property
            /// </summary>

            [XmlText]
            public double Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private double ValueField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the LengthMeasure xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LengthMeasure", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the LengthMeasure xsd type.")]
        public partial class LengthMeasure : Object, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the LengthMeasure class.
            /// </summary>
            public LengthMeasure() { }

            /// <summary>
            /// Initializes a new instance of the LengthMeasure class.
            /// </summary>
            /// <param name="value">Initial value</param>
            /// <param name="uom">Initial unit of measure</param>
            public LengthMeasure(double value, LengthUom uom)
            {
                this.Uom = uom;
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value + " " + Uom;
            }

            /// <summary>
            /// uom property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "LengthUom")]
            [XmlAttribute("uom")]

            public LengthUom Uom
            {
                get
                {
                    return uomField;
                }
                set
                {
                    uomField = value;
                    NotifyPropertyChanged("Uom");
                }
            }

            private LengthUom uomField;

            /// <summary>
            /// Value property
            /// </summary>

            [XmlText]
            public double Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private double ValueField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the WitsmlWellboreReference xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "WitsmlWellboreReference", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the WitsmlWellboreReference xsd type.")]
        public partial class WitsmlWellboreReference : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// WitsmlWell property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("WitsmlWell")]
            public DataObjectReference WitsmlWell
            {
                get
                {
                    return WitsmlWellField;
                }
                set
                {
                    WitsmlWellField = value;
                    NotifyPropertyChanged("WitsmlWell");
                }
            }

            private DataObjectReference WitsmlWellField;

            /// <summary>
            /// WitsmlWellbore property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("WitsmlWellbore")]
            public DataObjectReference WitsmlWellbore
            {
                get
                {
                    return WitsmlWellboreField;
                }
                set
                {
                    WitsmlWellboreField = value;
                    NotifyPropertyChanged("WitsmlWellbore");
                }
            }

            private DataObjectReference WitsmlWellboreField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractGraphicalInformation xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractGraphicalInformation", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractGraphicalInformation xsd type.")]
        public abstract partial class AbstractGraphicalInformation : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// TargetObject property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("TargetObject")]
            public DataObjectReference TargetObject
            {
                get
                {
                    return TargetObjectField;
                }
                set
                {
                    TargetObjectField = value;
                    NotifyPropertyChanged("TargetObject");
                }
            }

            private DataObjectReference TargetObjectField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IndexRange xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IndexRange", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the IndexRange xsd type.")]
        public partial class IndexRange : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// IndexMinimum property
            /// </summary>
            [Required]
            [StringLength(64)]
            [Description("The minimum index for the range over which the referenced data's conformance with the policy is being assessed.")]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("IndexMinimum")]
            public string IndexMinimum
            {
                get
                {
                    return IndexMinimumField;
                }
                set
                {
                    IndexMinimumField = value;
                    NotifyPropertyChanged("IndexMinimum");
                }
            }

            private string IndexMinimumField;

            /// <summary>
            /// IndexMaximum property
            /// </summary>
            [Required]
            [StringLength(64)]
            [Description("The maximum index for the range over which the referenced data's conformance with the policy is being assessed.")]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("IndexMaximum")]
            public string IndexMaximum
            {
                get
                {
                    return IndexMaximumField;
                }
                set
                {
                    IndexMaximumField = value;
                    NotifyPropertyChanged("IndexMaximum");
                }
            }

            private string IndexMaximumField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the FailingRule xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FailingRule", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the FailingRule xsd type.")]
        public partial class FailingRule : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// RuleId property
            /// </summary>
            [Required]
            [StringLength(64)]
            [Description("Identifier of the atomic rule being checked against the data.")]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("RuleId")]
            public string RuleId
            {
                get
                {
                    return RuleIdField;
                }
                set
                {
                    RuleIdField = value;
                    NotifyPropertyChanged("RuleId");
                }
            }

            private string RuleIdField;

            /// <summary>
            /// RuleName property
            /// </summary>
            [StringLength(2000)]
            [Description("Human-readable name of the atomic rule being checked against the data.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("RuleName")]
            public string RuleName
            {
                get
                {
                    return RuleNameField;
                }
                set
                {
                    RuleNameField = value;
                    NotifyPropertyChanged("RuleName");
                }
            }

            private string RuleNameField;

            /// <summary>
            /// Severity property
            /// </summary>
            [StringLength(64)]
            [Description("Severity of the failure. This could be used to indicate that a rule is a high-priority rule whose failure is considered as severe or could be used to indicate just how badly a rule was contravened.  The meaning of this field should be standardized within a company to maximize its utility.")]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("Severity")]
            public string Severity
            {
                get
                {
                    return SeverityField;
                }
                set
                {
                    SeverityField = value;
                    NotifyPropertyChanged("Severity");
                }
            }

            private string SeverityField;

            /// <summary>
            /// FailingRuleExtensions property
            /// </summary>
            [Description("This allows extending the FailingRule class with as many arbitrary name-value pairs as is required at run-time.  Uses for this might include why the rule failed or by how much.")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ExtensionNameValue")]
            [XmlElement("FailingRuleExtensions")]
            public List<ExtensionNameValue> FailingRuleExtensions
            {
                get
                {
                    return FailingRuleExtensionsField;
                }
                set
                {
                    FailingRuleExtensionsField = value;
                    NotifyPropertyChanged("FailingRuleExtensions");
                }
            }

            /// <summary>
            /// bool to indicate if FailingRuleExtensions has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool FailingRuleExtensionsSpecified
            {
                get
                {
                    if (FailingRuleExtensionsField != null)
                        return FailingRuleExtensionsField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ExtensionNameValue> FailingRuleExtensionsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ExtensionNameValue xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ExtensionNameValue", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ExtensionNameValue xsd type.")]
        public partial class ExtensionNameValue : Object, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the ExtensionNameValue class.
            /// </summary>
            public ExtensionNameValue() { }

            /// <summary>
            /// Initializes a new instance of the ExtensionNameValue class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public ExtensionNameValue(StringMeasure value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Name property
            /// </summary>
            [Required]
            [StringLength(64)]
            [Description("The name of the extension. Each standard name should document the expected measure class. Each standard name should document the expected maximum size.  For numeric values the size should be in terms of xsd types such as int, long, short, byte, float or double. For strings, the maximum length should be defined in number of characters. Local extensions to the list of standard names are allowed but it is strongly recommended that the names and definitions be approved by the  respective SIG Technical Team before use.")]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("Name")]
            public string Name
            {
                get
                {
                    return NameField;
                }
                set
                {
                    NameField = value;
                    NotifyPropertyChanged("Name");
                }
            }

            private string NameField;

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [Description("The value of the extension. This may also include a uom attribute. The content should conform to constraints defined by the data type.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "StringMeasure")]
            [XmlElement("Value")]
            public StringMeasure Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private StringMeasure ValueField;

            /// <summary>
            /// MeasureClass property
            /// </summary>
            [Description("The kind of the measure. For example, \"length\". This should be specified if the value requires a unit of measure.")]
            [EnergisticsDataTypeAttribute(DataType = "MeasureClass")]
            [XmlElement("MeasureClass")]
            public MeasureClass? MeasureClass
            {
                get
                {
                    return MeasureClassField;
                }
                set
                {
                    MeasureClassField = value;
                    this.MeasureClassSpecified = true;
                    NotifyPropertyChanged("MeasureClass");
                }
            }

            private MeasureClass? MeasureClassField;

            /// <summary>
            /// MeasureClassSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool MeasureClassSpecified
            {
                get
                {
                    return MeasureClassSpecifiedField;
                }
                set
                {
                    MeasureClassSpecifiedField = value;
                    NotifyPropertyChanged("MeasureClassSpecified");
                }
            }

            private bool MeasureClassSpecifiedField;

            /// <summary>
            /// DTim property
            /// </summary>
            [Description("The date-time associated with the value.")]
            [EnergisticsDataTypeAttribute(DataType = "TimeStamp")]
            [XmlElement("DTim")]
            public Timestamp? DateTime
            {
                get
                {
                    return DTimField;
                }
                set
                {
                    DTimField = value;
                    this.DateTimeSpecified = true;
                    NotifyPropertyChanged("DateTime");
                }
            }


            private bool DateTimeSpecifiedField = false;

            /// <summary>
            /// DateTimeSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool DateTimeSpecified
            {
                get
                {
                    return DateTimeSpecifiedField;
                }
                set
                {
                    DateTimeSpecifiedField = value;
                    NotifyPropertyChanged("DateTimeSpecified");
                }
            }

            private Timestamp? DTimField;

            /// <summary>
            /// Index property
            /// </summary>
            [Description("Indexes things with the same name.  That is, 1 indicates the first one, 2 indicates the second one, etc.")]
            [EnergisticsDataTypeAttribute(DataType = "int")]
            [XmlElement("Index")]
            public int? Index
            {
                get
                {
                    return IndexField;
                }
                set
                {
                    IndexField = value;
                    this.IndexSpecified = true;
                    NotifyPropertyChanged("Index");
                }
            }

            private int? IndexField;

            /// <summary>
            /// IndexSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool IndexSpecified
            {
                get
                {
                    return IndexSpecifiedField;
                }
                set
                {
                    IndexSpecifiedField = value;
                    NotifyPropertyChanged("IndexSpecified");
                }
            }

            private bool IndexSpecifiedField;

            /// <summary>
            /// Description property
            /// </summary>
            [StringLength(2000)]
            [Description("A textual description of the extension.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Description")]
            public string Description
            {
                get
                {
                    return DescriptionField;
                }
                set
                {
                    DescriptionField = value;
                    NotifyPropertyChanged("Description");
                }
            }

            private string DescriptionField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the StringMeasure xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringMeasure", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the StringMeasure xsd type.")]
        public partial class StringMeasure : Object, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the StringMeasure class.
            /// </summary>
            public StringMeasure() { }

            /// <summary>
            /// Initializes a new instance of the StringMeasure class.
            /// </summary>
            /// <param name="value">Initial value</param>
            /// <param name="uom">Initial unit of measure</param>
            public StringMeasure(string value, UnitOfMeasure uom)
            {
                this.Uom = uom;
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value + " " + Uom;
            }

            /// <summary>
            /// uom property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "UnitOfMeasure")]
            [XmlAttribute("uom")]

            public UnitOfMeasure Uom
            {
                get
                {
                    return uomField;
                }
                set
                {
                    uomField = value;
                    this.UomSpecified = true;
                    NotifyPropertyChanged("Uom");
                }
            }

            private UnitOfMeasure uomField;

            /// <summary>
            /// uomSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool UomSpecified
            {
                get
                {
                    return uomSpecifiedField;
                }
                set
                {
                    uomSpecifiedField = value;
                    NotifyPropertyChanged("UomSpecified");
                }
            }

            private bool uomSpecifiedField;

            /// <summary>
            /// Value property
            /// </summary>

            [XmlText]
            public string Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private string ValueField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractGeodeticCrs xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticWktCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticGmlCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticEpsgCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticLocalAuthorityCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticUnknownCrs))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractGeodeticCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractGeodeticCrs xsd type.")]
        public abstract partial class AbstractGeodeticCrs : Object, INotifyPropertyChanged
        {



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the GeodeticWktCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeodeticWktCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the GeodeticWktCrs xsd type.")]
        public partial class GeodeticWktCrs : AbstractGeodeticCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// WellKnownText property
            /// </summary>
            [Required]
            [Description("ISO 19162 compliant well known text of the CRS")]
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlElement("WellKnownText")]
            public string WellKnownText
            {
                get
                {
                    return WellKnownTextField;
                }
                set
                {
                    WellKnownTextField = value;
                    NotifyPropertyChanged("WellKnownText");
                }
            }

            private string WellKnownTextField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the GeodeticGmlCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeodeticGmlCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the GeodeticGmlCrs xsd type.")]
        public partial class GeodeticGmlCrs : AbstractGeodeticCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// GmlProjectedCrsDefinition property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "GeodeticCRSType")]
            [XmlElement("GmlProjectedCrsDefinition")]
            public GeodeticCRSType GmlProjectedCrsDefinition
            {
                get
                {
                    return GmlProjectedCrsDefinitionField;
                }
                set
                {
                    GmlProjectedCrsDefinitionField = value;
                    NotifyPropertyChanged("GmlProjectedCrsDefinition");
                }
            }

            private GeodeticCRSType GmlProjectedCrsDefinitionField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractActivityParameter xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataObjectParameter))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringParameter))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerQuantityParameter))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleQuantityParameter))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeIndexParameter))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractActivityParameter", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractActivityParameter xsd type.")]
        public abstract partial class AbstractActivityParameter : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Title property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("Name of the parameter, used to identify it in the activity. Must have an equivalent in the activity descriptor parameters.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Title")]
            public string Title
            {
                get
                {
                    return TitleField;
                }
                set
                {
                    TitleField = value;
                    NotifyPropertyChanged("Title");
                }
            }

            private string TitleField;

            /// <summary>
            /// Index property
            /// </summary>
            [Description("When parameter is an array, used to indicate the index in the array")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("Index")]
            public long? Index
            {
                get
                {
                    return IndexField;
                }
                set
                {
                    IndexField = value;
                    this.IndexSpecified = true;
                    NotifyPropertyChanged("Index");
                }
            }

            private long? IndexField;

            /// <summary>
            /// IndexSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool IndexSpecified
            {
                get
                {
                    return IndexSpecifiedField;
                }
                set
                {
                    IndexSpecifiedField = value;
                    NotifyPropertyChanged("IndexSpecified");
                }
            }

            private bool IndexSpecifiedField;

            /// <summary>
            /// Selection property
            /// </summary>
            [StringLength(2000)]
            [Description("Textual description about how this parameter was selected.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Selection")]
            public string Selection
            {
                get
                {
                    return SelectionField;
                }
                set
                {
                    SelectionField = value;
                    NotifyPropertyChanged("Selection");
                }
            }

            private string SelectionField;

            /// <summary>
            /// Key property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "AbstractParameterKey")]
            [XmlElement("Key")]
            public List<AbstractParameterKey> Key
            {
                get
                {
                    return KeyField;
                }
                set
                {
                    KeyField = value;
                    NotifyPropertyChanged("Key");
                }
            }

            /// <summary>
            /// bool to indicate if Key has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool KeySpecified
            {
                get
                {
                    if (KeyField != null)
                        return KeyField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<AbstractParameterKey> KeyField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractParameterKey xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObjectParameterKey))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeIndexParameterKey))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractParameterKey", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractParameterKey xsd type.")]
        public abstract partial class AbstractParameterKey : Object, INotifyPropertyChanged
        {



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ObjectParameterKey xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ObjectParameterKey", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ObjectParameterKey xsd type.")]
        public partial class ObjectParameterKey : AbstractParameterKey, INotifyPropertyChanged
        {

            /// <summary>
            /// DataObject property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("DataObject")]
            public DataObjectReference DataObject
            {
                get
                {
                    return DataObjectField;
                }
                set
                {
                    DataObjectField = value;
                    NotifyPropertyChanged("DataObject");
                }
            }

            private DataObjectReference DataObjectField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TimeIndexParameterKey xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TimeIndexParameterKey", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the TimeIndexParameterKey xsd type.")]
        public partial class TimeIndexParameterKey : AbstractParameterKey, INotifyPropertyChanged
        {

            /// <summary>
            /// TimeIndex property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TimeIndex")]
            [XmlElement("TimeIndex")]
            public TimeIndex TimeIndex
            {
                get
                {
                    return TimeIndexField;
                }
                set
                {
                    TimeIndexField = value;
                    NotifyPropertyChanged("TimeIndex");
                }
            }

            private TimeIndex TimeIndexField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the DataObjectParameter xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DataObjectParameter", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the DataObjectParameter xsd type.")]
        public partial class DataObjectParameter : AbstractActivityParameter, INotifyPropertyChanged
        {

            /// <summary>
            /// DataObject property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("DataObject")]
            public DataObjectReference DataObject
            {
                get
                {
                    return DataObjectField;
                }
                set
                {
                    DataObjectField = value;
                    NotifyPropertyChanged("DataObject");
                }
            }

            private DataObjectReference DataObjectField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the StringParameter xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringParameter", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the StringParameter xsd type.")]
        public partial class StringParameter : AbstractActivityParameter, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the StringParameter class.
            /// </summary>
            public StringParameter() { }

            /// <summary>
            /// Initializes a new instance of the StringParameter class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public StringParameter(string value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("String value")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Value")]
            public string Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private string ValueField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IntegerQuantityParameter xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IntegerQuantityParameter", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the IntegerQuantityParameter xsd type.")]
        public partial class IntegerQuantityParameter : AbstractActivityParameter, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the IntegerQuantityParameter class.
            /// </summary>
            public IntegerQuantityParameter() { }

            /// <summary>
            /// Initializes a new instance of the IntegerQuantityParameter class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public IntegerQuantityParameter(long value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [Description("Integer value")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("Value")]
            public long? Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private long? ValueField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the DoubleQuantityParameter xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DoubleQuantityParameter", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the DoubleQuantityParameter xsd type.")]
        public partial class DoubleQuantityParameter : AbstractActivityParameter, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the DoubleQuantityParameter class.
            /// </summary>
            public DoubleQuantityParameter() { }

            /// <summary>
            /// Initializes a new instance of the DoubleQuantityParameter class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public DoubleQuantityParameter(double value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [Description("Double value")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("Value")]
            public double? Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private double? ValueField;

            /// <summary>
            /// Uom property
            /// </summary>
            [Required]
            [Description("Unit of measure associated with the value")]
            [EnergisticsDataTypeAttribute(DataType = "UnitOfMeasureExt")]
            [XmlElement("Uom")]
            public ExtensibleEnum<UnitOfMeasure>? Uom
            {
                get
                {
                    return UomField;
                }
                set
                {
                    UomField = value;
                    NotifyPropertyChanged("Uom");
                }
            }

            private ExtensibleEnum<UnitOfMeasure>? UomField;

            /// <summary>
            /// CustomUnitDictionary property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("CustomUnitDictionary")]
            public DataObjectReference CustomUnitDictionary
            {
                get
                {
                    return CustomUnitDictionaryField;
                }
                set
                {
                    CustomUnitDictionaryField = value;
                    NotifyPropertyChanged("CustomUnitDictionary");
                }
            }

            private DataObjectReference CustomUnitDictionaryField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TimeIndexParameter xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TimeIndexParameter", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the TimeIndexParameter xsd type.")]
        public partial class TimeIndexParameter : AbstractActivityParameter, INotifyPropertyChanged
        {

            /// <summary>
            /// TimeIndex property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TimeIndex")]
            [XmlElement("TimeIndex")]
            public TimeIndex TimeIndex
            {
                get
                {
                    return TimeIndexField;
                }
                set
                {
                    TimeIndexField = value;
                    NotifyPropertyChanged("TimeIndex");
                }
            }

            private TimeIndex TimeIndexField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CustomData xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CustomData", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the CustomData xsd type.")]
        public partial class CustomData : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Any property
            /// </summary>
            [RecurringElement]
            [XmlAnyElement]
            public List<XmlElement> Any
            {
                get
                {
                    return AnyField;
                }
                set
                {
                    AnyField = value;
                    NotifyPropertyChanged("Any");
                }
            }

            /// <summary>
            /// bool to indicate if Any has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool AnySpecified
            {
                get
                {
                    if (AnyField != null)
                        return AnyField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<XmlElement> AnyField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Citation xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Citation", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the Citation xsd type.")]
        public partial class Citation : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Title property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("One line description/name of the object.  This is the equivalent in ISO 19115 of CI_Citation.title  Legacy DCGroup - title")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Title")]
            public string Title
            {
                get
                {
                    return TitleField;
                }
                set
                {
                    TitleField = value;
                    NotifyPropertyChanged("Title");
                }
            }

            private string TitleField;

            /// <summary>
            /// Originator property
            /// </summary>
            [Required]
            [StringLength(64)]
            [Description("Name (or other human-readable identifier) of the person who initially originated the object or document in the source application. If that information is not available, then this is the user who created the format file. The originator remains the same as the object is subsequently edited.   This is the equivalent in ISO 19115 to the CI_Individual.name or the CI_Organization.name of the citedResponsibleParty whose role is \"originator\".  Legacy DCGroup - author")]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("Originator")]
            public string Originator
            {
                get
                {
                    return OriginatorField;
                }
                set
                {
                    OriginatorField = value;
                    NotifyPropertyChanged("Originator");
                }
            }

            private string OriginatorField;

            /// <summary>
            /// Creation property
            /// </summary>
            [Required]
            [Description("Date and time the document was created in the source application or, if that information is not available, when it was saved to the file.  This is the equivalent of the ISO 19115 CI_Date where the CI_DateTypeCode = ”creation\"  Format: YYYY-MM-DDThh:mm:ssZ[+/-]hh:mm  Legacy DCGroup - created")]
            [EnergisticsDataTypeAttribute(DataType = "dateTime")]
            [XmlElement("Creation")]
            public DateTime? Creation
            {
                get
                {
                    return CreationField;
                }
                set
                {
                    CreationField = value;
                    NotifyPropertyChanged("Creation");
                }
            }

            private DateTime? CreationField;

            /// <summary>
            /// Format property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("Software or service that was used to originate the object and the file format created. Must be human and machine readable and unambiguously identify the software by including the company name, software name and software version. This is the equivalent in ISO 19115 to the distributionFormat.MD_Format.  The ISO format for this is [vendor:applicationName]/fileExtension where the application name includes the version number of the application.  SIG Implementation Notes - Legacy DCGroup from v1.1 - publisher - fileExtension is not relevant and will be ignored if present. - vendor and applicationName are mandatory.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Format")]
            public string Format
            {
                get
                {
                    return FormatField;
                }
                set
                {
                    FormatField = value;
                    NotifyPropertyChanged("Format");
                }
            }

            private string FormatField;

            /// <summary>
            /// Editor property
            /// </summary>
            [StringLength(64)]
            [Description("Name (or other human-readable identifier) of the last person who updated the object.   This is the equivalent in ISO 19115 to the CI_Individual.name or the CI_Organization.name of the citedResponsibleParty whose role is \"editor\".  Legacy DCGroup - contributor")]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("Editor")]
            public string Editor
            {
                get
                {
                    return EditorField;
                }
                set
                {
                    EditorField = value;
                    NotifyPropertyChanged("Editor");
                }
            }

            private string EditorField;

            /// <summary>
            /// LastUpdate property
            /// </summary>
            [Description("Date and time the document was last modified in the source application or, if that information is not available, when it was last saved to the RESQML format file.  This is the equivalent of the ISO 19115 CI_Date where the CI_DateTypeCode = ”lastUpdate\"   Format: YYYY-MM-DDThh:mm:ssZ[+/-]hh:mm  Legacy DCGroup - modified")]
            [EnergisticsDataTypeAttribute(DataType = "dateTime")]
            [XmlElement("LastUpdate")]
            public DateTime? LastUpdate
            {
                get
                {
                    return LastUpdateField;
                }
                set
                {
                    LastUpdateField = value;
                    this.LastUpdateSpecified = true;
                    NotifyPropertyChanged("LastUpdate");
                }
            }

            private DateTime? LastUpdateField;

            /// <summary>
            /// LastUpdateSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool LastUpdateSpecified
            {
                get
                {
                    return LastUpdateSpecifiedField;
                }
                set
                {
                    LastUpdateSpecifiedField = value;
                    NotifyPropertyChanged("LastUpdateSpecified");
                }
            }

            private bool LastUpdateSpecifiedField;

            /// <summary>
            /// VersionString property
            /// </summary>
            [StringLength(64)]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("VersionString")]
            public string VersionString
            {
                get
                {
                    return VersionStringField;
                }
                set
                {
                    VersionStringField = value;
                    NotifyPropertyChanged("VersionString");
                }
            }

            private string VersionStringField;

            /// <summary>
            /// Description property
            /// </summary>
            [StringLength(2000)]
            [Description("User descriptive comments about the object. Intended for end-user use (human readable); not necessarily meant to be used by software.  This is the equivalent of the ISO 19115 abstract.CharacterString  Legacy DCGroup - description")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Description")]
            public string Description
            {
                get
                {
                    return DescriptionField;
                }
                set
                {
                    DescriptionField = value;
                    NotifyPropertyChanged("Description");
                }
            }

            private string DescriptionField;

            /// <summary>
            /// DescriptiveKeywords property
            /// </summary>
            [StringLength(2000)]
            [Description("Key words to describe the activity, for example, history match or volumetric calculations, relevant to this object. Intended to be used in a search function by software.  This is the equivalent in ISO 19115 of descriptiveKeywords.MD_Keywords  Legacy DCGroup - subject")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("DescriptiveKeywords")]
            public string DescriptiveKeywords
            {
                get
                {
                    return DescriptiveKeywordsField;
                }
                set
                {
                    DescriptiveKeywordsField = value;
                    NotifyPropertyChanged("DescriptiveKeywords");
                }
            }

            private string DescriptiveKeywordsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ObjectAlias xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ObjectAlias", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ObjectAlias xsd type.")]
        public partial class ObjectAlias : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Identifier property
            /// </summary>
            [Required]
            [StringLength(64)]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("Identifier")]
            public string Identifier
            {
                get
                {
                    return IdentifierField;
                }
                set
                {
                    IdentifierField = value;
                    NotifyPropertyChanged("Identifier");
                }
            }

            private string IdentifierField;

            /// <summary>
            /// Description property
            /// </summary>
            [StringLength(2000)]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Description")]
            public string Description
            {
                get
                {
                    return DescriptionField;
                }
                set
                {
                    DescriptionField = value;
                    NotifyPropertyChanged("Description");
                }
            }

            private string DescriptionField;

            /// <summary>
            /// authority property
            /// </summary>
            [Required]
            [StringLength(64)]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlAttribute("authority")]

            public string Authority
            {
                get
                {
                    return authorityField;
                }
                set
                {
                    authorityField = value;
                    NotifyPropertyChanged("Authority");
                }
            }

            private string authorityField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the StringLookup xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringLookup", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the StringLookup xsd type.")]
        public partial class StringLookup : Object, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the StringLookup class.
            /// </summary>
            public StringLookup() { }

            /// <summary>
            /// Initializes a new instance of the StringLookup class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public StringLookup(string value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// The corresponding integer value. This value is used in HDF5 instead of the string value. The value of null integer value must be reserved for NULL. The size of this value is constrained by the size of the format used in HDF5.
            /// </summary>
            [Required]
            [Description("The corresponding integer value. This value is used in HDF5 instead of the string value. The value of null integer value must be reserved for NULL. The size of this value is constrained by the size of the format used in HDF5.")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("Key")]
            public long? Key
            {
                get
                {
                    return KeyField;
                }
                set
                {
                    KeyField = value;
                    NotifyPropertyChanged("Key");
                }
            }

            private long? KeyField;

            /// <summary>
            /// A string value. Output from the lookup table.
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("A string value. Output from the lookup table.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Value")]
            public string Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private string ValueField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the DoubleLookup xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DoubleLookup", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the DoubleLookup xsd type.")]
        public partial class DoubleLookup : Object, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the DoubleLookup class.
            /// </summary>
            public DoubleLookup() { }

            /// <summary>
            /// Initializes a new instance of the DoubleLookup class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public DoubleLookup(double value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Input to a table lookup.
            /// </summary>
            [Required]
            [Description("Input to a table lookup.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("Key")]
            public double? Key
            {
                get
                {
                    return KeyField;
                }
                set
                {
                    KeyField = value;
                    NotifyPropertyChanged("Key");
                }
            }

            private double? KeyField;

            /// <summary>
            /// Output from a table lookup.
            /// </summary>
            [Required]
            [Description("Output from a table lookup.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("Value")]
            public double? Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private double? ValueField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the PatchOfPoints xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PatchOfPoints", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the PatchOfPoints xsd type.")]
        public partial class PatchOfPoints : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Optional patch index used to attach properties to a specific patch of the indexable elements.
            /// </summary>
            [Description("Optional patch index used to attach properties to a specific patch of the indexable elements.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("RepresentationPatchIndex")]
            public long? RepresentationPatchIndex
            {
                get
                {
                    return RepresentationPatchIndexField;
                }
                set
                {
                    RepresentationPatchIndexField = value;
                    this.RepresentationPatchIndexSpecified = true;
                    NotifyPropertyChanged("RepresentationPatchIndex");
                }
            }

            private long? RepresentationPatchIndexField;

            /// <summary>
            /// RepresentationPatchIndexSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool RepresentationPatchIndexSpecified
            {
                get
                {
                    return RepresentationPatchIndexSpecifiedField;
                }
                set
                {
                    RepresentationPatchIndexSpecifiedField = value;
                    NotifyPropertyChanged("RepresentationPatchIndexSpecified");
                }
            }

            private bool RepresentationPatchIndexSpecifiedField;

            /// <summary>
            /// Geometric points (or vectors) to be attached to the specified indexable elements.
            /// </summary>
            [Required]
            [Description("Geometric points (or vectors) to be attached to the specified indexable elements.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractPoint3dArray")]
            [XmlElement("Points")]
            public AbstractPoint3dArray Points
            {
                get
                {
                    return PointsField;
                }
                set
                {
                    PointsField = value;
                    NotifyPropertyChanged("Points");
                }
            }

            private AbstractPoint3dArray PointsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractPoint3dArray xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Point3dZValueArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Point3dParametricArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Point3dLatticeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Point3dHdf5Array))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Point3dFromRepresentationLatticeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Point2dHdf5Array))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractPoint3dArray", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractPoint3dArray xsd type.")]
        public abstract partial class AbstractPoint3dArray : Object, INotifyPropertyChanged
        {



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Point3dZValueArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Point3dZValueArray", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Point3dZValueArray xsd type.")]
        public partial class Point3dZValueArray : AbstractPoint3dArray, INotifyPropertyChanged
        {

            /// <summary>
            /// Geometry defining the X and Y coordinates.
            /// </summary>
            [Required]
            [Description("Geometry defining the X and Y coordinates.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractPoint3dArray")]
            [XmlElement("SupportingGeometry")]
            public AbstractPoint3dArray SupportingGeometry
            {
                get
                {
                    return SupportingGeometryField;
                }
                set
                {
                    SupportingGeometryField = value;
                    NotifyPropertyChanged("SupportingGeometry");
                }
            }

            private AbstractPoint3dArray SupportingGeometryField;

            /// <summary>
            /// The values for Z coordinates
            /// </summary>
            [Required]
            [Description("The values for Z coordinates")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("ZValues")]
            public AbstractFloatingPointArray ZValues
            {
                get
                {
                    return ZValuesField;
                }
                set
                {
                    ZValuesField = value;
                    NotifyPropertyChanged("ZValues");
                }
            }

            private AbstractFloatingPointArray ZValuesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractFloatingPointArray xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatingPointLatticeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatingPointConstantArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatingPointExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatExternalArray))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractFloatingPointArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractFloatingPointArray xsd type.")]
        public abstract partial class AbstractFloatingPointArray : AbstractNumericArray, INotifyPropertyChanged
        {


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractNumericArray xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractIntegerArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerRangeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerArrayFromBooleanMaskArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerConstantArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerLatticeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFloatingPointArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatingPointLatticeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatingPointConstantArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatingPointExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatExternalArray))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractNumericArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractNumericArray xsd type.")]
        public abstract partial class AbstractNumericArray : AbstractValueArray, INotifyPropertyChanged
        {


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractValueArray xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractStringArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringConstantArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractNumericArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractIntegerArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerRangeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerArrayFromBooleanMaskArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerConstantArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerLatticeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFloatingPointArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatingPointLatticeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatingPointConstantArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatingPointExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractBooleanArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanArrayFromDiscretePropertyArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanArrayFromIndexArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanConstantArray))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractValueArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractValueArray xsd type.")]
        public abstract partial class AbstractValueArray : Object, INotifyPropertyChanged
        {



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractStringArray xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringConstantArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringExternalArray))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractStringArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractStringArray xsd type.")]
        public abstract partial class AbstractStringArray : AbstractValueArray, INotifyPropertyChanged
        {


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the StringConstantArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringConstantArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the StringConstantArray xsd type.")]
        public partial class StringConstantArray : AbstractStringArray, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the StringConstantArray class.
            /// </summary>
            public StringConstantArray() { }

            /// <summary>
            /// Initializes a new instance of the StringConstantArray class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public StringConstantArray(string value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("Value inside all the elements of the array.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Value")]
            public string Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private string ValueField;

            /// <summary>
            /// Count property
            /// </summary>
            [Required]
            [Description("Size of the array.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the StringExternalArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringExternalArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the StringExternalArray xsd type.")]
        public partial class StringExternalArray : AbstractStringArray, INotifyPropertyChanged
        {

            /// <summary>
            /// Values property
            /// </summary>
            [Required]
            [Description("Reference to HDF5 array of integer or double")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ExternalDataset")]
            [XmlArrayItem("ExternalFileProxy")]
            [XmlArray("Values")]
            public List<ExternalDatasetPart> Values
            {
                get
                {
                    return ValuesField;
                }
                set
                {
                    ValuesField = value;
                    NotifyPropertyChanged("Values");
                }
            }

            /// <summary>
            /// bool to indicate if Values has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ValuesSpecified
            {
                get
                {
                    if (ValuesField != null)
                        return ValuesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ExternalDatasetPart> ValuesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ExternalDatasetPart xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ExternalDatasetPart", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ExternalDatasetPart xsd type.")]
        public partial class ExternalDatasetPart : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Count property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// PathInExternalFile property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("A string which is meaningful to the API which will store and retrieve data from the external file.  For an HDF file this is the path of the referenced dataset in the external file. The separator between groups and final dataset is a slash '/' in an hdf file.  For a LAS file this could be the list of mnemonics in the ~A block.  For a SEG-Y file this could be a list of trace headers.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("PathInExternalFile")]
            public string PathInExternalFile
            {
                get
                {
                    return PathInExternalFileField;
                }
                set
                {
                    PathInExternalFileField = value;
                    NotifyPropertyChanged("PathInExternalFile");
                }
            }

            private string PathInExternalFileField;

            /// <summary>
            /// StartIndex property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("StartIndex")]
            public long? StartIndex
            {
                get
                {
                    return StartIndexField;
                }
                set
                {
                    StartIndexField = value;
                    NotifyPropertyChanged("StartIndex");
                }
            }

            private long? StartIndexField;

            /// <summary>
            /// EpcExternalPartReference property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("EpcExternalPartReference")]
            public DataObjectReference EpcExternalPartReference
            {
                get
                {
                    return EpcExternalPartReferenceField;
                }
                set
                {
                    EpcExternalPartReferenceField = value;
                    NotifyPropertyChanged("EpcExternalPartReference");
                }
            }

            private DataObjectReference EpcExternalPartReferenceField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the DataObjectReference xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactElementReference))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DataObjectReference", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the DataObjectReference xsd type.")]
        public partial class DataObjectReference : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// ContentType property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("The content type of the referenced element.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("ContentType")]
            public string ContentType
            {
                get
                {
                    return ContentTypeField;
                }
                set
                {
                    ContentTypeField = value;
                    NotifyPropertyChanged("ContentType");
                }
            }

            private string ContentTypeField;

            /// <summary>
            /// Title property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("The Title of the referenced object. The Title of a top level element would be inherited from AbstractObject and must be present on any referenced object.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Title")]
            public string Title
            {
                get
                {
                    return TitleField;
                }
                set
                {
                    TitleField = value;
                    NotifyPropertyChanged("Title");
                }
            }

            private string TitleField;

            /// <summary>
            /// Uuid property
            /// </summary>
            [Required]
            [RegularExpression("[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}")]
            [Description("Reference to an object using its global UID.")]
            [EnergisticsDataTypeAttribute(DataType = "UuidString")]
            [XmlElement("Uuid")]
            public string Uuid
            {
                get
                {
                    return UuidField;
                }
                set
                {
                    UuidField = value;
                    NotifyPropertyChanged("Uuid");
                }
            }

            private string UuidField;

            /// <summary>
            /// UuidAuthority property
            /// </summary>
            [StringLength(64)]
            [Description("The authority that issued and maintains the uuid of the referenced object. Used mainly in alias context.")]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("UuidAuthority")]
            public string UuidAuthority
            {
                get
                {
                    return UuidAuthorityField;
                }
                set
                {
                    UuidAuthorityField = value;
                    NotifyPropertyChanged("UuidAuthority");
                }
            }

            private string UuidAuthorityField;

            /// <summary>
            /// Uri property
            /// </summary>
            [Description("This is the URI of a referenced object.   Do not use this to store the path and file names of an external object - that is done through the External Dataset machinery.  This element is intended for use with the Energistics Transfer Protocol.")]
            [EnergisticsDataTypeAttribute(DataType = "anyURI")]
            [XmlElement("Uri", DataType = "anyURI")]
            public string Uri
            {
                get
                {
                    return UriField;
                }
                set
                {
                    UriField = value;
                    NotifyPropertyChanged("Uri");
                }
            }

            private string UriField;

            /// <summary>
            /// VersionString property
            /// </summary>
            [StringLength(64)]
            [Description("Indicates the version of the object which is referenced.")]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlElement("VersionString")]
            public string VersionString
            {
                get
                {
                    return VersionStringField;
                }
                set
                {
                    VersionStringField = value;
                    NotifyPropertyChanged("VersionString");
                }
            }

            private string VersionStringField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ContactElementReference xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ContactElementReference", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ContactElementReference xsd type.")]
        public partial class ContactElementReference : DataObjectReference, INotifyPropertyChanged
        {

            /// <summary>
            /// Qualifier property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "ContactSide")]
            [XmlElement("Qualifier")]
            public ContactSide? Qualifier
            {
                get
                {
                    return QualifierField;
                }
                set
                {
                    QualifierField = value;
                    this.QualifierSpecified = true;
                    NotifyPropertyChanged("Qualifier");
                }
            }

            private ContactSide? QualifierField;

            /// <summary>
            /// QualifierSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool QualifierSpecified
            {
                get
                {
                    return QualifierSpecifiedField;
                }
                set
                {
                    QualifierSpecifiedField = value;
                    NotifyPropertyChanged("QualifierSpecified");
                }
            }

            private bool QualifierSpecifiedField;

            /// <summary>
            /// SecondaryQualifier property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "ContactMode")]
            [XmlElement("SecondaryQualifier")]
            public ContactMode? SecondaryQualifier
            {
                get
                {
                    return SecondaryQualifierField;
                }
                set
                {
                    SecondaryQualifierField = value;
                    this.SecondaryQualifierSpecified = true;
                    NotifyPropertyChanged("SecondaryQualifier");
                }
            }

            private ContactMode? SecondaryQualifierField;

            /// <summary>
            /// SecondaryQualifierSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool SecondaryQualifierSpecified
            {
                get
                {
                    return SecondaryQualifierSpecifiedField;
                }
                set
                {
                    SecondaryQualifierSpecifiedField = value;
                    NotifyPropertyChanged("SecondaryQualifierSpecified");
                }
            }

            private bool SecondaryQualifierSpecifiedField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractBooleanArray xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanArrayFromDiscretePropertyArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanArrayFromIndexArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanConstantArray))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractBooleanArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractBooleanArray xsd type.")]
        public abstract partial class AbstractBooleanArray : AbstractValueArray, INotifyPropertyChanged
        {


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the BooleanArrayFromDiscretePropertyArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BooleanArrayFromDiscretePropertyArray", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the BooleanArrayFromDiscretePropertyArray xsd type.")]
        public partial class BooleanArrayFromDiscretePropertyArray : AbstractBooleanArray, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the BooleanArrayFromDiscretePropertyArray class.
            /// </summary>
            public BooleanArrayFromDiscretePropertyArray() { }

            /// <summary>
            /// Initializes a new instance of the BooleanArrayFromDiscretePropertyArray class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public BooleanArrayFromDiscretePropertyArray(long value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [Description("Integer to match for the value to be considered true")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("Value")]
            public long? Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private long? ValueField;

            /// <summary>
            /// Property property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("Property")]
            public DataObjectReference Property
            {
                get
                {
                    return PropertyField;
                }
                set
                {
                    PropertyField = value;
                    NotifyPropertyChanged("Property");
                }
            }

            private DataObjectReference PropertyField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the BooleanArrayFromIndexArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BooleanArrayFromIndexArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the BooleanArrayFromIndexArray xsd type.")]
        public partial class BooleanArrayFromIndexArray : AbstractBooleanArray, INotifyPropertyChanged
        {

            /// <summary>
            /// Count property
            /// </summary>
            [Required]
            [Description("Total number of Boolean elements in the array. This number is different from the number of indices used to represent the array.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// Indices property
            /// </summary>
            [Required]
            [Description("Array of integer indices.  BUSINESS RULE: Must be non-negative.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("Indices")]
            public AbstractIntegerArray Indices
            {
                get
                {
                    return IndicesField;
                }
                set
                {
                    IndicesField = value;
                    NotifyPropertyChanged("Indices");
                }
            }

            private AbstractIntegerArray IndicesField;

            /// <summary>
            /// IndexIsTrue property
            /// </summary>
            [Required]
            [Description("Indicates whether the specified elements are true or false.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("IndexIsTrue")]
            public bool? IndexIsTrue
            {
                get
                {
                    return IndexIsTrueField;
                }
                set
                {
                    IndexIsTrueField = value;
                    NotifyPropertyChanged("IndexIsTrue");
                }
            }

            private bool? IndexIsTrueField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractIntegerArray xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerRangeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerArrayFromBooleanMaskArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerConstantArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerLatticeArray))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractIntegerArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractIntegerArray xsd type.")]
        public abstract partial class AbstractIntegerArray : AbstractNumericArray, INotifyPropertyChanged
        {


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IntegerRangeArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IntegerRangeArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the IntegerRangeArray xsd type.")]
        public partial class IntegerRangeArray : AbstractIntegerArray, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the IntegerRangeArray class.
            /// </summary>
            public IntegerRangeArray() { }

            /// <summary>
            /// Initializes a new instance of the IntegerRangeArray class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public IntegerRangeArray(long value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Count property
            /// </summary>
            [Required]
            [Description("Size of the array.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [Description("Start value for the range. End value is start+count-1.")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("Value")]
            public long? Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private long? ValueField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IntegerExternalArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IntegerExternalArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the IntegerExternalArray xsd type.")]
        public partial class IntegerExternalArray : AbstractIntegerArray, INotifyPropertyChanged
        {

            /// <summary>
            /// NullValue property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("NullValue")]
            public long? NullValue
            {
                get
                {
                    return NullValueField;
                }
                set
                {
                    NullValueField = value;
                    NotifyPropertyChanged("NullValue");
                }
            }

            private long? NullValueField;

            /// <summary>
            /// Values property
            /// </summary>
            [Required]
            [Description("Reference to an HDF5 array of integers or doubles.")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ExternalDataset")]
            [XmlArrayItem("ExternalFileProxy")]
            [XmlArray("Values")]
            public List<ExternalDatasetPart> Values
            {
                get
                {
                    return ValuesField;
                }
                set
                {
                    ValuesField = value;
                    NotifyPropertyChanged("Values");
                }
            }

            /// <summary>
            /// bool to indicate if Values has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ValuesSpecified
            {
                get
                {
                    if (ValuesField != null)
                        return ValuesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ExternalDatasetPart> ValuesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IntegerArrayFromBooleanMaskArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IntegerArrayFromBooleanMaskArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the IntegerArrayFromBooleanMaskArray xsd type.")]
        public partial class IntegerArrayFromBooleanMaskArray : AbstractIntegerArray, INotifyPropertyChanged
        {

            /// <summary>
            /// TotalIndexCount property
            /// </summary>
            [Required]
            [Description("Total number of integer elements in the array. This number is different from the number of Boolean mask values used to represent the array.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("TotalIndexCount")]
            public long? TotalIndexCount
            {
                get
                {
                    return TotalIndexCountField;
                }
                set
                {
                    TotalIndexCountField = value;
                    NotifyPropertyChanged("TotalIndexCount");
                }
            }

            private long? TotalIndexCountField;

            /// <summary>
            /// Mask property
            /// </summary>
            [Required]
            [Description("Boolean mask. A true element indicates that the index is included on the list of integer values.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractBooleanArray")]
            [XmlElement("Mask")]
            public AbstractBooleanArray Mask
            {
                get
                {
                    return MaskField;
                }
                set
                {
                    MaskField = value;
                    NotifyPropertyChanged("Mask");
                }
            }

            private AbstractBooleanArray MaskField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IntegerConstantArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IntegerConstantArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the IntegerConstantArray xsd type.")]
        public partial class IntegerConstantArray : AbstractIntegerArray, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the IntegerConstantArray class.
            /// </summary>
            public IntegerConstantArray() { }

            /// <summary>
            /// Initializes a new instance of the IntegerConstantArray class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public IntegerConstantArray(long value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [Description("Values inside all the elements of the array.")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("Value")]
            public long? Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private long? ValueField;

            /// <summary>
            /// Count property
            /// </summary>
            [Required]
            [Description("Size of the array.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IntegerLatticeArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IntegerLatticeArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the IntegerLatticeArray xsd type.")]
        public partial class IntegerLatticeArray : AbstractIntegerArray, INotifyPropertyChanged
        {

            /// <summary>
            /// StartValue property
            /// </summary>
            [Required]
            [Description("Value representing the global start for the lattice: i.e., iStart + jStart*ni + kStart*ni*nj")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("StartValue")]
            public long? StartValue
            {
                get
                {
                    return StartValueField;
                }
                set
                {
                    StartValueField = value;
                    NotifyPropertyChanged("StartValue");
                }
            }

            private long? StartValueField;

            /// <summary>
            /// Offset property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "IntegerConstantArray")]
            [XmlElement("Offset")]
            public List<IntegerConstantArray> Offset
            {
                get
                {
                    return OffsetField;
                }
                set
                {
                    OffsetField = value;
                    NotifyPropertyChanged("Offset");
                }
            }

            /// <summary>
            /// bool to indicate if Offset has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool OffsetSpecified
            {
                get
                {
                    if (OffsetField != null)
                        return OffsetField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<IntegerConstantArray> OffsetField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the BooleanExternalArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BooleanExternalArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the BooleanExternalArray xsd type.")]
        public partial class BooleanExternalArray : AbstractBooleanArray, INotifyPropertyChanged
        {

            /// <summary>
            /// Values property
            /// </summary>
            [Required]
            [Description("Reference to an HDF5 array of values.")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ExternalDataset")]
            [XmlArrayItem("ExternalFileProxy")]
            [XmlArray("Values")]
            public List<ExternalDatasetPart> Values
            {
                get
                {
                    return ValuesField;
                }
                set
                {
                    ValuesField = value;
                    NotifyPropertyChanged("Values");
                }
            }

            /// <summary>
            /// bool to indicate if Values has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ValuesSpecified
            {
                get
                {
                    if (ValuesField != null)
                        return ValuesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ExternalDatasetPart> ValuesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the BooleanConstantArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BooleanConstantArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the BooleanConstantArray xsd type.")]
        public partial class BooleanConstantArray : AbstractBooleanArray, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the BooleanConstantArray class.
            /// </summary>
            public BooleanConstantArray() { }

            /// <summary>
            /// Initializes a new instance of the BooleanConstantArray class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public BooleanConstantArray(bool value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [Description("Value inside all the elements of the array.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("Value")]
            public bool? Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private bool? ValueField;

            /// <summary>
            /// Count property
            /// </summary>
            [Required]
            [Description("Size of the array.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the FloatingPointLatticeArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FloatingPointLatticeArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the FloatingPointLatticeArray xsd type.")]
        public partial class FloatingPointLatticeArray : AbstractFloatingPointArray, INotifyPropertyChanged
        {

            /// <summary>
            /// StartValue property
            /// </summary>
            [Required]
            [Description("Value representing the global start for the lattice.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("StartValue")]
            public double? StartValue
            {
                get
                {
                    return StartValueField;
                }
                set
                {
                    StartValueField = value;
                    NotifyPropertyChanged("StartValue");
                }
            }

            private double? StartValueField;

            /// <summary>
            /// Offset property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "FloatingPointConstantArray")]
            [XmlElement("Offset")]
            public List<FloatingPointConstantArray> Offset
            {
                get
                {
                    return OffsetField;
                }
                set
                {
                    OffsetField = value;
                    NotifyPropertyChanged("Offset");
                }
            }

            /// <summary>
            /// bool to indicate if Offset has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool OffsetSpecified
            {
                get
                {
                    if (OffsetField != null)
                        return OffsetField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<FloatingPointConstantArray> OffsetField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the FloatingPointConstantArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FloatingPointConstantArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the FloatingPointConstantArray xsd type.")]
        public partial class FloatingPointConstantArray : AbstractFloatingPointArray, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the FloatingPointConstantArray class.
            /// </summary>
            public FloatingPointConstantArray() { }

            /// <summary>
            /// Initializes a new instance of the FloatingPointConstantArray class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public FloatingPointConstantArray(double value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// Value property
            /// </summary>
            [Required]
            [Description("Values inside all the elements of the array.")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("Value")]
            public double? Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private double? ValueField;

            /// <summary>
            /// Count property
            /// </summary>
            [Required]
            [Description("Size of the array.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the FloatingPointExternalArray xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleExternalArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(FloatExternalArray))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FloatingPointExternalArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the FloatingPointExternalArray xsd type.")]
        public partial class FloatingPointExternalArray : AbstractFloatingPointArray, INotifyPropertyChanged
        {

            /// <summary>
            /// Values property
            /// </summary>
            [Required]
            [Description("Reference to an HDF5 array of doubles.")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ExternalDataset")]
            [XmlArrayItem("ExternalFileProxy")]
            [XmlArray("Values")]
            public List<ExternalDatasetPart> Values
            {
                get
                {
                    return ValuesField;
                }
                set
                {
                    ValuesField = value;
                    NotifyPropertyChanged("Values");
                }
            }

            /// <summary>
            /// bool to indicate if Values has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ValuesSpecified
            {
                get
                {
                    if (ValuesField != null)
                        return ValuesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ExternalDatasetPart> ValuesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the DoubleExternalArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DoubleExternalArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the DoubleExternalArray xsd type.")]
        public partial class DoubleExternalArray : FloatingPointExternalArray, INotifyPropertyChanged
        {


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the FloatExternalArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FloatExternalArray", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the FloatExternalArray xsd type.")]
        public partial class FloatExternalArray : FloatingPointExternalArray, INotifyPropertyChanged
        {


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Point3dParametricArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Point3dParametricArray", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Point3dParametricArray xsd type.")]
        public partial class Point3dParametricArray : AbstractPoint3dArray, INotifyPropertyChanged
        {

            /// <summary>
            /// Parameters property
            /// </summary>
            [Required]
            [Description("A multi-dimensional array of parametric values that implicitly specifies an array of XYZ points.  The parametric values provided in this data-object must be consistent with the parametric values specified in the referenced parametric line array.  When constructing a column-layer grid geometry using parametric points, the array indexing follows the dimensionality of the coordinate lines x NKL, which is either a 2D or 3D array.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractValueArray")]
            [XmlElement("Parameters")]
            public AbstractValueArray Parameters
            {
                get
                {
                    return ParametersField;
                }
                set
                {
                    ParametersField = value;
                    NotifyPropertyChanged("Parameters");
                }
            }

            private AbstractValueArray ParametersField;

            /// <summary>
            /// ParametricLineIndices property
            /// </summary>
            [Description("An optional array of indices that map from the array index to the index of the corresponding parametric line.  If this information is known from context, then this array is not needed. For example, in either of these cases: (1) If the mapping from array index to parametric line is 1:1. (2) If the mapping has already been specified, as with the pillar Index from the column-layer geometry of a grid.  For example, when constructing a column-layer grid geometry using parametric lines, the array indexing follows the dimensionality of the coordinate lines.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ParametricLineIndices")]
            public AbstractIntegerArray ParametricLineIndices
            {
                get
                {
                    return ParametricLineIndicesField;
                }
                set
                {
                    ParametricLineIndicesField = value;
                    NotifyPropertyChanged("ParametricLineIndices");
                }
            }

            private AbstractIntegerArray ParametricLineIndicesField;

            /// <summary>
            /// TruncatedLineIndices property
            /// </summary>
            [Description("A 2D array of line indices for use with intersecting parametric lines. Each record consists of a single line index, which indicates the array line that uses this truncation information, followed by the parametric line indices for each of the points on that line.  For a non-truncated line, the equivalent record repeats the array line index NKL+1 times.   Size = (NKL+1) x truncatedLineCount")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("TruncatedLineIndices")]
            public AbstractIntegerArray TruncatedLineIndices
            {
                get
                {
                    return TruncatedLineIndicesField;
                }
                set
                {
                    TruncatedLineIndicesField = value;
                    NotifyPropertyChanged("TruncatedLineIndices");
                }
            }

            private AbstractIntegerArray TruncatedLineIndicesField;

            /// <summary>
            /// ParametricLines property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "AbstractParametricLineArray")]
            [XmlElement("ParametricLines")]
            public AbstractParametricLineArray ParametricLines
            {
                get
                {
                    return ParametricLinesField;
                }
                set
                {
                    ParametricLinesField = value;
                    NotifyPropertyChanged("ParametricLines");
                }
            }

            private AbstractParametricLineArray ParametricLinesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractParametricLineArray xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParametricLineFromRepresentationLatticeArray))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParametricLineArray))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractParametricLineArray", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractParametricLineArray xsd type.")]
        public abstract partial class AbstractParametricLineArray : Object, INotifyPropertyChanged
        {



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ParametricLineFromRepresentationLatticeArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ParametricLineFromRepresentationLatticeArray", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ParametricLineFromRepresentationLatticeArray xsd type.")]
        public partial class ParametricLineFromRepresentationLatticeArray : AbstractParametricLineArray, INotifyPropertyChanged
        {

            /// <summary>
            /// LineIndicesOnSupportingRepresentation property
            /// </summary>
            [Required]
            [Description("The line indices of the selected lines in the supporting representation. The index selection is regularly incremented from one node to the next node.  BUSINESS RULE: The dimensions of the integer lattice array must be consistent with the dimensions of the supporting representation.  For a column-layer grid, the parametric lines follow the indexing of the pillars.  BUSINESS RULE: The start value of the integer lattice array must be the linearized index of the starting line. Example: iStart + ni * jStart in case of a supporting 2D grid.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "IntegerLatticeArray")]
            [XmlElement("LineIndicesOnSupportingRepresentation")]
            public IntegerLatticeArray LineIndicesOnSupportingRepresentation
            {
                get
                {
                    return LineIndicesOnSupportingRepresentationField;
                }
                set
                {
                    LineIndicesOnSupportingRepresentationField = value;
                    NotifyPropertyChanged("LineIndicesOnSupportingRepresentation");
                }
            }

            private IntegerLatticeArray LineIndicesOnSupportingRepresentationField;

            /// <summary>
            /// SupportingRepresentation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("SupportingRepresentation")]
            public DataObjectReference SupportingRepresentation
            {
                get
                {
                    return SupportingRepresentationField;
                }
                set
                {
                    SupportingRepresentationField = value;
                    NotifyPropertyChanged("SupportingRepresentation");
                }
            }

            private DataObjectReference SupportingRepresentationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ParametricLineArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ParametricLineArray", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ParametricLineArray xsd type.")]
        public partial class ParametricLineArray : AbstractParametricLineArray, INotifyPropertyChanged
        {

            /// <summary>
            /// ControlPointParameters property
            /// </summary>
            [Description("An optional array of explicit control point parameters for all of the control points on each of the parametric lines. Used only if control point parameters are present.  The number of explicit control point parameters per line is given by the count of non-null parameters on each line.   Described as a 1D array, the control point parameter array is divided into segments of length count, with null (NaN) values added to each segment to fill it up.  Size = count x #Lines, e.g., 2D or 3D  BUSINESS RULE: This count should be zero for vertical and Z linear cubic parametric lines. For all other parametric line kinds, there should be one control point parameter for each control point.  NOTES: (1) Vertical parametric lines do not require control point parameters (2) Z linear cubic splines have implicitly defined parameters. For a line with N intervals (N+1 control points), the parametric values are P=0,...,N.  BUSINESS RULE: The parametric values must be strictly monotonically increasing on each parametric line.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("ControlPointParameters")]
            public AbstractFloatingPointArray ControlPointParameters
            {
                get
                {
                    return ControlPointParametersField;
                }
                set
                {
                    ControlPointParametersField = value;
                    NotifyPropertyChanged("ControlPointParameters");
                }
            }

            private AbstractFloatingPointArray ControlPointParametersField;

            /// <summary>
            /// ControlPoints property
            /// </summary>
            [Required]
            [Description("An array of 3D points for all of the control points on each of the parametric lines. The number of control points per line is given by the KnotCount.  Described as a 1D array, the control point array is divided into segments of length KnotCount, with null (NaN) values added to each segment to fill it up.  Size = KnotCount x #Lines, e.g., 2D or 3D")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractPoint3dArray")]
            [XmlElement("ControlPoints")]
            public AbstractPoint3dArray ControlPoints
            {
                get
                {
                    return ControlPointsField;
                }
                set
                {
                    ControlPointsField = value;
                    NotifyPropertyChanged("ControlPoints");
                }
            }

            private AbstractPoint3dArray ControlPointsField;

            /// <summary>
            /// KnotCount property
            /// </summary>
            [Required]
            [Description("The first dimension of the control point, control point parameter, and tangent vector arrays for the parametric splines. The Knot Count is typically chosen to be the maximum number of control points, parameters or tangent vectors on any parametric line in the array of parametric lines.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("KnotCount")]
            public long? KnotCount
            {
                get
                {
                    return KnotCountField;
                }
                set
                {
                    KnotCountField = value;
                    NotifyPropertyChanged("KnotCount");
                }
            }

            private long? KnotCountField;

            /// <summary>
            /// LineKindIndices property
            /// </summary>
            [Required]
            [Description("An array of integers indicating the parametric line kind.  0 = vertical 1 = linear spline 2 = natural cubic spline 3 = tangential cubic spline 4 = Z linear cubic spline 5 = minimum-curvature spline null value: no line   Size = #Lines, e.g., (1D or 2D)")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("LineKindIndices")]
            public AbstractIntegerArray LineKindIndices
            {
                get
                {
                    return LineKindIndicesField;
                }
                set
                {
                    LineKindIndicesField = value;
                    NotifyPropertyChanged("LineKindIndices");
                }
            }

            private AbstractIntegerArray LineKindIndicesField;

            /// <summary>
            /// TangentVectors property
            /// </summary>
            [Description("An optional array of tangent vectors for all of the control points on each of the tangential cubic and minimum-curvature parametric lines. Used only if tangent vectors are present. The number of tangent vectors per line is given by the KnotCount for these spline types.  Described as a 1D array, the tangent vector array is divided into segments of length Knot Count, with null (NaN) values added to each segment to fill it up.  Size = Knot Count x #Lines, e.g., 2D or 3D  BUSINESS RULE: For all lines other than the cubic and minimum-curvature parametric lines, this array should not appear. For these line kinds, there should be one tangent vector for each control point.  If a tangent vector is missing, then it is computed in the same fashion as for a natural cubic spline. Specifically, to obtain the tangent at internal knots, the control points are fit by a quadratic function with the two adjacent control points. At edge knots, the second derivative vanishes.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractPoint3dArray")]
            [XmlElement("TangentVectors")]
            public AbstractPoint3dArray TangentVectors
            {
                get
                {
                    return TangentVectorsField;
                }
                set
                {
                    TangentVectorsField = value;
                    NotifyPropertyChanged("TangentVectors");
                }
            }

            private AbstractPoint3dArray TangentVectorsField;

            /// <summary>
            /// ParametricLineIntersections property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "ParametricLineIntersections")]
            [XmlElement("ParametricLineIntersections")]
            public ParametricLineIntersections ParametricLineIntersections
            {
                get
                {
                    return ParametricLineIntersectionsField;
                }
                set
                {
                    ParametricLineIntersectionsField = value;
                    NotifyPropertyChanged("ParametricLineIntersections");
                }
            }

            private ParametricLineIntersections ParametricLineIntersectionsField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ParametricLineIntersections xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ParametricLineIntersections", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the ParametricLineIntersections xsd type.")]
        public partial class ParametricLineIntersections : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Number of parametric line intersections. Must be positive.
            /// </summary>
            [Required]
            [Description("Number of parametric line intersections. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Count")]
            public long? Count
            {
                get
                {
                    return CountField;
                }
                set
                {
                    CountField = value;
                    NotifyPropertyChanged("Count");
                }
            }

            private long? CountField;

            /// <summary>
            /// Intersected line index pair for (line 1, line 2). Size = 2 x count
            /// </summary>
            [Required]
            [Description("Intersected line index pair for (line 1, line 2).  Size = 2 x count")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("IntersectionLinePairs")]
            public AbstractIntegerArray IntersectionLinePairs
            {
                get
                {
                    return IntersectionLinePairsField;
                }
                set
                {
                    IntersectionLinePairsField = value;
                    NotifyPropertyChanged("IntersectionLinePairs");
                }
            }

            private AbstractIntegerArray IntersectionLinePairsField;

            /// <summary>
            /// Intersected line parameter value pairs for (line 1, line 2). Size = 2 x count
            /// </summary>
            [Required]
            [Description("Intersected line parameter value pairs for (line 1, line 2).  Size = 2 x count")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractValueArray")]
            [XmlElement("ParameterValuePairs")]
            public AbstractValueArray ParameterValuePairs
            {
                get
                {
                    return ParameterValuePairsField;
                }
                set
                {
                    ParameterValuePairsField = value;
                    NotifyPropertyChanged("ParameterValuePairs");
                }
            }

            private AbstractValueArray ParameterValuePairsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Point3dLatticeArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Point3dLatticeArray", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Point3dLatticeArray xsd type.")]
        public partial class Point3dLatticeArray : AbstractPoint3dArray, INotifyPropertyChanged
        {

            /// <summary>
            /// AllDimensionsAreOrthogonal property
            /// </summary>
            [Description("The optional element that indicates that the offset vectors for each direction are mutually orthogonal to each other. This meta-information is useful to remove any doubt of orthogonality in case of numerical precision issues.  BUSINESS RULE: If you don't know it or if only one lattice dimension is given, do not provide this element.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("AllDimensionsAreOrthogonal")]
            public bool? AllDimensionsAreOrthogonal
            {
                get
                {
                    return AllDimensionsAreOrthogonalField;
                }
                set
                {
                    AllDimensionsAreOrthogonalField = value;
                    this.AllDimensionsAreOrthogonalSpecified = true;
                    NotifyPropertyChanged("AllDimensionsAreOrthogonal");
                }
            }

            private bool? AllDimensionsAreOrthogonalField;

            /// <summary>
            /// AllDimensionsAreOrthogonalSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool AllDimensionsAreOrthogonalSpecified
            {
                get
                {
                    return AllDimensionsAreOrthogonalSpecifiedField;
                }
                set
                {
                    AllDimensionsAreOrthogonalSpecifiedField = value;
                    NotifyPropertyChanged("AllDimensionsAreOrthogonalSpecified");
                }
            }

            private bool AllDimensionsAreOrthogonalSpecifiedField;

            /// <summary>
            /// Origin property
            /// </summary>
            [Required]
            [Description("The origin location of the lattice given as XYZ coordinates.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "Point3d")]
            [XmlElement("Origin")]
            public Point3d Origin
            {
                get
                {
                    return OriginField;
                }
                set
                {
                    OriginField = value;
                    NotifyPropertyChanged("Origin");
                }
            }

            private Point3d OriginField;

            /// <summary>
            /// Offset property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "Point3dOffset")]
            [XmlElement("Offset")]
            public List<Point3dOffset> Offset
            {
                get
                {
                    return OffsetField;
                }
                set
                {
                    OffsetField = value;
                    NotifyPropertyChanged("Offset");
                }
            }

            /// <summary>
            /// bool to indicate if Offset has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool OffsetSpecified
            {
                get
                {
                    if (OffsetField != null)
                        return OffsetField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<Point3dOffset> OffsetField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Point3d xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Point3d", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Point3d xsd type.")]
        public partial class Point3d : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// X coordinate
            /// </summary>
            [Required]
            [Description("X coordinate")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("Coordinate1")]
            public double? Coordinate1
            {
                get
                {
                    return Coordinate1Field;
                }
                set
                {
                    Coordinate1Field = value;
                    NotifyPropertyChanged("Coordinate1");
                }
            }

            private double? Coordinate1Field;

            /// <summary>
            /// Y coordinate
            /// </summary>
            [Required]
            [Description("Y coordinate")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("Coordinate2")]
            public double? Coordinate2
            {
                get
                {
                    return Coordinate2Field;
                }
                set
                {
                    Coordinate2Field = value;
                    NotifyPropertyChanged("Coordinate2");
                }
            }

            private double? Coordinate2Field;

            /// <summary>
            /// Either Z or T coordinate
            /// </summary>
            [Required]
            [Description("Either Z or T coordinate")]
            [EnergisticsDataTypeAttribute(DataType = "double")]
            [XmlElement("Coordinate3")]
            public double? Coordinate3
            {
                get
                {
                    return Coordinate3Field;
                }
                set
                {
                    Coordinate3Field = value;
                    NotifyPropertyChanged("Coordinate3");
                }
            }

            private double? Coordinate3Field;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Point3dOffset xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Point3dOffset", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Point3dOffset xsd type.")]
        public partial class Point3dOffset : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// The direction of the axis of this lattice dimension. This is a relative offset vector instead of an absolute 3D point.
            /// </summary>
            [Required]
            [Description("The direction of the axis of this lattice dimension. This is a relative offset vector instead of an absolute 3D point.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "Point3d")]
            [XmlElement("Offset")]
            public Point3d Offset
            {
                get
                {
                    return OffsetField;
                }
                set
                {
                    OffsetField = value;
                    NotifyPropertyChanged("Offset");
                }
            }

            private Point3d OffsetField;

            /// <summary>
            /// A lattice of N offset points is described by a spacing array of size N-1. The offset between points is given by the spacing value multiplied by the offset vector. For example, the first offset is 0. The second offset is the first spacing * offset. The second offset is (first spacing + second spacing) * offset, etc.
            /// </summary>
            [Required]
            [Description("A lattice of N offset points is described by a spacing array of size N-1. The offset between points is given by the spacing value multiplied by the offset vector. For example, the first offset is 0. The second offset is the first spacing * offset. The second offset is (first spacing + second spacing) * offset, etc.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
            [XmlElement("Spacing")]
            public AbstractFloatingPointArray Spacing
            {
                get
                {
                    return SpacingField;
                }
                set
                {
                    SpacingField = value;
                    NotifyPropertyChanged("Spacing");
                }
            }

            private AbstractFloatingPointArray SpacingField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Point3dHdf5Array xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Point3dHdf5Array", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Point3dHdf5Array xsd type.")]
        public partial class Point3dHdf5Array : AbstractPoint3dArray, INotifyPropertyChanged
        {

            /// <summary>
            /// Reference to an HDF5 3D dataset of XYZ points. The 3 coordinates are stored sequentially in HDF5, i.e., a multi-dimensional array of points is stored as a 3 x ... HDF5 array.
            /// </summary>
            [Required]
            [Description("Reference to an HDF5 3D dataset of XYZ points. The 3 coordinates are stored sequentially in HDF5, i.e., a multi-dimensional array of points is stored as a 3 x ... HDF5 array.")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ExternalDataset")]
            [XmlArrayItem("ExternalFileProxy")]
            [XmlArray("Coordinates")]
            public List<ExternalDatasetPart> Coordinates
            {
                get
                {
                    return CoordinatesField;
                }
                set
                {
                    CoordinatesField = value;
                    NotifyPropertyChanged("Coordinates");
                }
            }

            /// <summary>
            /// bool to indicate if Coordinates has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool CoordinatesSpecified
            {
                get
                {
                    if (CoordinatesField != null)
                        return CoordinatesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ExternalDatasetPart> CoordinatesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Point3dFromRepresentationLatticeArray xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Point3dFromRepresentationLatticeArray", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Point3dFromRepresentationLatticeArray xsd type.")]
        public partial class Point3dFromRepresentationLatticeArray : AbstractPoint3dArray, INotifyPropertyChanged
        {

            /// <summary>
            /// NodeIndicesOnSupportingRepresentation property
            /// </summary>
            [Required]
            [Description("The node indices of the selected nodes in the supporting representation. The index selection is regularly incremented from one node to the next node.  BUSINESS RULE: The node indices must be consistent with the size of supporting representation.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "IntegerLatticeArray")]
            [XmlElement("NodeIndicesOnSupportingRepresentation")]
            public IntegerLatticeArray NodeIndicesOnSupportingRepresentation
            {
                get
                {
                    return NodeIndicesOnSupportingRepresentationField;
                }
                set
                {
                    NodeIndicesOnSupportingRepresentationField = value;
                    NotifyPropertyChanged("NodeIndicesOnSupportingRepresentation");
                }
            }

            private IntegerLatticeArray NodeIndicesOnSupportingRepresentationField;

            /// <summary>
            /// SupportingRepresentation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("SupportingRepresentation")]
            public DataObjectReference SupportingRepresentation
            {
                get
                {
                    return SupportingRepresentationField;
                }
                set
                {
                    SupportingRepresentationField = value;
                    NotifyPropertyChanged("SupportingRepresentation");
                }
            }

            private DataObjectReference SupportingRepresentationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Point2dHdf5Array xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Point2dHdf5Array", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Point2dHdf5Array xsd type.")]
        public partial class Point2dHdf5Array : AbstractPoint3dArray, INotifyPropertyChanged
        {

            /// <summary>
            /// Reference to an HDF5 2D dataset of XY points. The 2 coordinates are stored sequentially in HDF5, i.e., a multi-dimensional array of points is stored as a 2 x ... HDF5 array.
            /// </summary>
            [Required]
            [Description("Reference to an HDF5 2D dataset of XY points. The 2 coordinates are stored sequentially in HDF5, i.e., a multi-dimensional array of points is stored as a 2 x ... HDF5 array.")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ExternalDataset")]
            [XmlArrayItem("ExternalFileProxy")]
            [XmlArray("Coordinates")]
            public List<ExternalDatasetPart> Coordinates
            {
                get
                {
                    return CoordinatesField;
                }
                set
                {
                    CoordinatesField = value;
                    NotifyPropertyChanged("Coordinates");
                }
            }

            /// <summary>
            /// bool to indicate if Coordinates has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool CoordinatesSpecified
            {
                get
                {
                    if (CoordinatesField != null)
                        return CoordinatesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ExternalDatasetPart> CoordinatesField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the PropertyKindFacet xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PropertyKindFacet", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the PropertyKindFacet xsd type.")]
        public partial class PropertyKindFacet : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// A facet allows you to better define a property in the context of its property kind. The technical advantage of using a facet vs. a specialized property kind is to limit the number of property kinds.
            /// </summary>
            [Required]
            [Description("A facet allows you to better define a property in the context of its property kind. The technical advantage of using a facet vs. a specialized property kind is to limit the number of property kinds.")]
            [EnergisticsDataTypeAttribute(DataType = "FacetExt")]
            [XmlElement("Facet")]
            public ExtensibleEnum<Facet>? Facet
            {
                get
                {
                    return FacetField;
                }
                set
                {
                    FacetField = value;
                    NotifyPropertyChanged("Facet");
                }
            }

            private ExtensibleEnum<Facet>? FacetField;

            /// <summary>
            /// Facet kind of the property kind (see the enumeration)
            /// </summary>
            [Required]
            [Description("Facet kind of the property kind (see the enumeration)")]
            [EnergisticsDataTypeAttribute(DataType = "FacetKind")]
            [XmlElement("Kind")]
            public FacetKind? Kind
            {
                get
                {
                    return KindField;
                }
                set
                {
                    KindField = value;
                    this.KindSpecified = true;
                    NotifyPropertyChanged("Kind");
                }
            }


            private bool KindSpecifiedField = false;

            /// <summary>
            /// KindSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool KindSpecified
            {
                get
                {
                    return KindSpecifiedField;
                }
                set
                {
                    KindSpecifiedField = value;
                    NotifyPropertyChanged("KindSpecified");
                }
            }

            private FacetKind? KindField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the PatchOfValues xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PatchOfValues", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the PatchOfValues xsd type.")]
        public partial class PatchOfValues : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Patch index used to attach properties to a specific patch of the indexable elements.
            /// </summary>
            [Description("Patch index used to attach properties to a specific patch of the indexable elements.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("RepresentationPatchIndex")]
            public long? RepresentationPatchIndex
            {
                get
                {
                    return RepresentationPatchIndexField;
                }
                set
                {
                    RepresentationPatchIndexField = value;
                    this.RepresentationPatchIndexSpecified = true;
                    NotifyPropertyChanged("RepresentationPatchIndex");
                }
            }

            private long? RepresentationPatchIndexField;

            /// <summary>
            /// RepresentationPatchIndexSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool RepresentationPatchIndexSpecified
            {
                get
                {
                    return RepresentationPatchIndexSpecifiedField;
                }
                set
                {
                    RepresentationPatchIndexSpecifiedField = value;
                    NotifyPropertyChanged("RepresentationPatchIndexSpecified");
                }
            }

            private bool RepresentationPatchIndexSpecifiedField;

            /// <summary>
            /// Values to be attached to the indexable elements.
            /// </summary>
            [Required]
            [Description("Values to be attached to the indexable elements.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractValueArray")]
            [XmlElement("Values")]
            public AbstractValueArray Values
            {
                get
                {
                    return ValuesField;
                }
                set
                {
                    ValuesField = value;
                    NotifyPropertyChanged("Values");
                }
            }

            private AbstractValueArray ValuesField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TimeIndices xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TimeIndices", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the TimeIndices xsd type.")]
        public partial class TimeIndices : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// TimeIndexCount property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("TimeIndexCount")]
            public long? TimeIndexCount
            {
                get
                {
                    return TimeIndexCountField;
                }
                set
                {
                    TimeIndexCountField = value;
                    NotifyPropertyChanged("TimeIndexCount");
                }
            }

            private long? TimeIndexCountField;

            /// <summary>
            /// TimeIndexStart property
            /// </summary>
            [Description("The index of the start time in the time series, if not zero.")]
            [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
            [XmlElement("TimeIndexStart")]
            public long? TimeIndexStart
            {
                get
                {
                    return TimeIndexStartField;
                }
                set
                {
                    TimeIndexStartField = value;
                    this.TimeIndexStartSpecified = true;
                    NotifyPropertyChanged("TimeIndexStart");
                }
            }

            private long? TimeIndexStartField;

            /// <summary>
            /// TimeIndexStartSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool TimeIndexStartSpecified
            {
                get
                {
                    return TimeIndexStartSpecifiedField;
                }
                set
                {
                    TimeIndexStartSpecifiedField = value;
                    NotifyPropertyChanged("TimeIndexStartSpecified");
                }
            }

            private bool TimeIndexStartSpecifiedField;

            /// <summary>
            /// SimulatorTimeStep property
            /// </summary>
            [Description("Simulation time step for each time index")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("SimulatorTimeStep")]
            public AbstractIntegerArray SimulatorTimeStep
            {
                get
                {
                    return SimulatorTimeStepField;
                }
                set
                {
                    SimulatorTimeStepField = value;
                    NotifyPropertyChanged("SimulatorTimeStep");
                }
            }

            private AbstractIntegerArray SimulatorTimeStepField;

            /// <summary>
            /// UseInterval property
            /// </summary>
            [Required]
            [Description("When UseInterval is true, the values are associated with each time intervals between two consecutive time entries instead of each individual time entry. As a consequence the dimension of the value array corresponding to the time series is the number of entry in the series minus one.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("UseInterval")]
            public bool? UseInterval
            {
                get
                {
                    return UseIntervalField;
                }
                set
                {
                    UseIntervalField = value;
                    NotifyPropertyChanged("UseInterval");
                }
            }

            private bool? UseIntervalField;

            /// <summary>
            /// TimeSeries property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("TimeSeries")]
            public DataObjectReference TimeSeries
            {
                get
                {
                    return TimeSeriesField;
                }
                set
                {
                    TimeSeriesField = value;
                    NotifyPropertyChanged("TimeSeries");
                }
            }

            private DataObjectReference TimeSeriesField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Activation xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Activation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the Activation xsd type.")]
        public partial class Activation : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// ActivationToggleIndices property
            /// </summary>
            [Required]
            [Description("The index in the time series at which the state of the referencing object is changed. Toggle changes state from inactive to active, or toggle changes state from active to inactive.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("ActivationToggleIndices")]
            public AbstractIntegerArray ActivationToggleIndices
            {
                get
                {
                    return ActivationToggleIndicesField;
                }
                set
                {
                    ActivationToggleIndicesField = value;
                    NotifyPropertyChanged("ActivationToggleIndices");
                }
            }

            private AbstractIntegerArray ActivationToggleIndicesField;

            /// <summary>
            /// TimeSeries property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TimeSeries")]
            [XmlElement("TimeSeries")]
            public TimeSeries TimeSeries
            {
                get
                {
                    return TimeSeriesField;
                }
                set
                {
                    TimeSeriesField = value;
                    NotifyPropertyChanged("TimeSeries");
                }
            }

            private TimeSeries TimeSeriesField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the WellboreMarker xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "WellboreMarker", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the WellboreMarker xsd type.")]
        public partial class WellboreMarker : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {

            /// <summary>
            /// FluidContact property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "FluidContact")]
            [XmlElement("FluidContact")]
            public FluidContact? FluidContact
            {
                get
                {
                    return FluidContactField;
                }
                set
                {
                    FluidContactField = value;
                    this.FluidContactSpecified = true;
                    NotifyPropertyChanged("FluidContact");
                }
            }

            private FluidContact? FluidContactField;

            /// <summary>
            /// FluidContactSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool FluidContactSpecified
            {
                get
                {
                    return FluidContactSpecifiedField;
                }
                set
                {
                    FluidContactSpecifiedField = value;
                    NotifyPropertyChanged("FluidContactSpecified");
                }
            }

            private bool FluidContactSpecifiedField;

            /// <summary>
            /// FluidMarker property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "FluidMarker")]
            [XmlElement("FluidMarker")]
            public FluidMarker? FluidMarker
            {
                get
                {
                    return FluidMarkerField;
                }
                set
                {
                    FluidMarkerField = value;
                    this.FluidMarkerSpecified = true;
                    NotifyPropertyChanged("FluidMarker");
                }
            }

            private FluidMarker? FluidMarkerField;

            /// <summary>
            /// FluidMarkerSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool FluidMarkerSpecified
            {
                get
                {
                    return FluidMarkerSpecifiedField;
                }
                set
                {
                    FluidMarkerSpecifiedField = value;
                    NotifyPropertyChanged("FluidMarkerSpecified");
                }
            }

            private bool FluidMarkerSpecifiedField;

            /// <summary>
            /// GeologicBoundaryKind property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "GeologicBoundaryKind")]
            [XmlElement("GeologicBoundaryKind")]
            public GeologicBoundaryKind? GeologicBoundaryKind
            {
                get
                {
                    return GeologicBoundaryKindField;
                }
                set
                {
                    GeologicBoundaryKindField = value;
                    this.GeologicBoundaryKindSpecified = true;
                    NotifyPropertyChanged("GeologicBoundaryKind");
                }
            }

            private GeologicBoundaryKind? GeologicBoundaryKindField;

            /// <summary>
            /// GeologicBoundaryKindSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool GeologicBoundaryKindSpecified
            {
                get
                {
                    return GeologicBoundaryKindSpecifiedField;
                }
                set
                {
                    GeologicBoundaryKindSpecifiedField = value;
                    NotifyPropertyChanged("GeologicBoundaryKindSpecified");
                }
            }

            private bool GeologicBoundaryKindSpecifiedField;

            /// <summary>
            /// WitsmlFormationMarker property
            /// </summary>
            [Description("Optional WITSML wellbore reference of the well marker frame.")]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("WitsmlFormationMarker")]
            public DataObjectReference WitsmlFormationMarker
            {
                get
                {
                    return WitsmlFormationMarkerField;
                }
                set
                {
                    WitsmlFormationMarkerField = value;
                    NotifyPropertyChanged("WitsmlFormationMarker");
                }
            }

            private DataObjectReference WitsmlFormationMarkerField;

            /// <summary>
            /// Interpretation property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("Interpretation")]
            public DataObjectReference Interpretation
            {
                get
                {
                    return InterpretationField;
                }
                set
                {
                    InterpretationField = value;
                    NotifyPropertyChanged("Interpretation");
                }
            }

            private DataObjectReference InterpretationField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractRepresentation xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StreamlinesRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellboreTrajectoryRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellboreFrameRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellboreMarkerFrameRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicWellboreFrameRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BlockedWellboreRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeviationSurveyRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolylineRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointSetRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneSetRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSetRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grid2dSetRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grid2dRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Seismic2dPostStackRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GridConnectionSetRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Seismic3dPostStackRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GpGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTruncatedColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TruncatedUnstructuredColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TruncatedIjkGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnstructuredColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IjkGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(RepresentationSetRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SealedVolumeFrameworkRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceFrameworkRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SealedSurfaceFrameworkRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonSealedSurfaceFrameworkRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(RedefinedGeometryRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolylineSetRepresentation))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractRepresentation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the AbstractRepresentation xsd type.")]
        public abstract partial class AbstractRepresentation : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {

            /// <summary>
            /// RepresentedInterpretation property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("RepresentedInterpretation")]
            public DataObjectReference RepresentedInterpretation
            {
                get
                {
                    return RepresentedInterpretationField;
                }
                set
                {
                    RepresentedInterpretationField = value;
                    NotifyPropertyChanged("RepresentedInterpretation");
                }
            }

            private DataObjectReference RepresentedInterpretationField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the GeodeticEpsgCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeodeticEpsgCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the GeodeticEpsgCrs xsd type.")]
        public partial class GeodeticEpsgCrs : AbstractGeodeticCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// EpsgCode property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("EpsgCode")]
            public long? EpsgCode
            {
                get
                {
                    return EpsgCodeField;
                }
                set
                {
                    EpsgCodeField = value;
                    NotifyPropertyChanged("EpsgCode");
                }
            }

            private long? EpsgCodeField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the GeodeticLocalAuthorityCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeodeticLocalAuthorityCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the GeodeticLocalAuthorityCrs xsd type.")]
        public partial class GeodeticLocalAuthorityCrs : AbstractGeodeticCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// LocalAuthorityCrsName property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "AuthorityQualifiedName")]
            [XmlElement("LocalAuthorityCrsName")]
            public AuthorityQualifiedName LocalAuthorityCrsName
            {
                get
                {
                    return LocalAuthorityCrsNameField;
                }
                set
                {
                    LocalAuthorityCrsNameField = value;
                    NotifyPropertyChanged("LocalAuthorityCrsName");
                }
            }

            private AuthorityQualifiedName LocalAuthorityCrsNameField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AuthorityQualifiedName xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AuthorityQualifiedName", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AuthorityQualifiedName xsd type.")]
        public partial class AuthorityQualifiedName : Object, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the AuthorityQualifiedName class.
            /// </summary>
            public AuthorityQualifiedName() { }

            /// <summary>
            /// Initializes a new instance of the AuthorityQualifiedName class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public AuthorityQualifiedName(string value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }

            /// <summary>
            /// authority property
            /// </summary>
            [Required]
            [StringLength(64)]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlAttribute("authority")]

            public string Authority
            {
                get
                {
                    return authorityField;
                }
                set
                {
                    authorityField = value;
                    NotifyPropertyChanged("Authority");
                }
            }

            private string authorityField;

            /// <summary>
            /// code property
            /// </summary>
            [StringLength(64)]
            [EnergisticsDataTypeAttribute(DataType = "String64")]
            [XmlAttribute("code")]

            public string Code
            {
                get
                {
                    return codeField;
                }
                set
                {
                    codeField = value;
                    NotifyPropertyChanged("Code");
                }
            }

            private string codeField;

            /// <summary>
            /// Value property
            /// </summary>

            [XmlText]
            public string Value
            {
                get
                {
                    return ValueField;
                }
                set
                {
                    ValueField = value;
                    NotifyPropertyChanged("Value");
                }
            }

            private string ValueField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the GeodeticUnknownCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeodeticUnknownCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the GeodeticUnknownCrs xsd type.")]
        public partial class GeodeticUnknownCrs : AbstractGeodeticCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// Unknown property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Unknown")]
            public string Unknown
            {
                get
                {
                    return UnknownField;
                }
                set
                {
                    UnknownField = value;
                    NotifyPropertyChanged("Unknown");
                }
            }

            private string UnknownField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractProjectedCrs xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedLocalAuthorityCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedGmlCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedUnknownCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedWktCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedEpsgCrs))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractProjectedCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractProjectedCrs xsd type.")]
        public abstract partial class AbstractProjectedCrs : Object, INotifyPropertyChanged
        {



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ProjectedLocalAuthorityCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProjectedLocalAuthorityCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ProjectedLocalAuthorityCrs xsd type.")]
        public partial class ProjectedLocalAuthorityCrs : AbstractProjectedCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// LocalAuthorityCrsName property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "AuthorityQualifiedName")]
            [XmlElement("LocalAuthorityCrsName")]
            public AuthorityQualifiedName LocalAuthorityCrsName
            {
                get
                {
                    return LocalAuthorityCrsNameField;
                }
                set
                {
                    LocalAuthorityCrsNameField = value;
                    NotifyPropertyChanged("LocalAuthorityCrsName");
                }
            }

            private AuthorityQualifiedName LocalAuthorityCrsNameField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ProjectedGmlCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProjectedGmlCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ProjectedGmlCrs xsd type.")]
        public partial class ProjectedGmlCrs : AbstractProjectedCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// GmlProjectedCrsDefinition property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "ProjectedCRSType")]
            [XmlElement("GmlProjectedCrsDefinition")]
            public ProjectedCRSType GmlProjectedCrsDefinition
            {
                get
                {
                    return GmlProjectedCrsDefinitionField;
                }
                set
                {
                    GmlProjectedCrsDefinitionField = value;
                    NotifyPropertyChanged("GmlProjectedCrsDefinition");
                }
            }

            private ProjectedCRSType GmlProjectedCrsDefinitionField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ProjectedUnknownCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProjectedUnknownCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ProjectedUnknownCrs xsd type.")]
        public partial class ProjectedUnknownCrs : AbstractProjectedCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// Unknown property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Unknown")]
            public string Unknown
            {
                get
                {
                    return UnknownField;
                }
                set
                {
                    UnknownField = value;
                    NotifyPropertyChanged("Unknown");
                }
            }

            private string UnknownField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ProjectedWktCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProjectedWktCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ProjectedWktCrs xsd type.")]
        public partial class ProjectedWktCrs : AbstractProjectedCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// WellKnownText property
            /// </summary>
            [Required]
            [Description("ISO 19162 compliant well known text of the CRS")]
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlElement("WellKnownText")]
            public string WellKnownText
            {
                get
                {
                    return WellKnownTextField;
                }
                set
                {
                    WellKnownTextField = value;
                    NotifyPropertyChanged("WellKnownText");
                }
            }

            private string WellKnownTextField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ProjectedEpsgCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProjectedEpsgCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ProjectedEpsgCrs xsd type.")]
        public partial class ProjectedEpsgCrs : AbstractProjectedCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// EpsgCode property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("EpsgCode")]
            public long? EpsgCode
            {
                get
                {
                    return EpsgCodeField;
                }
                set
                {
                    EpsgCodeField = value;
                    NotifyPropertyChanged("EpsgCode");
                }
            }

            private long? EpsgCodeField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractVerticalCrs xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalWktCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalGmlCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalLocalAuthorityCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalEpsgCrs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalUnknownCrs))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractVerticalCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the AbstractVerticalCrs xsd type.")]
        public abstract partial class AbstractVerticalCrs : Object, INotifyPropertyChanged
        {



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the VerticalWktCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VerticalWktCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the VerticalWktCrs xsd type.")]
        public partial class VerticalWktCrs : AbstractVerticalCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// WellKnownText property
            /// </summary>
            [Required]
            [Description("ISO 19162 compliant well known text of the CRS")]
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlElement("WellKnownText")]
            public string WellKnownText
            {
                get
                {
                    return WellKnownTextField;
                }
                set
                {
                    WellKnownTextField = value;
                    NotifyPropertyChanged("WellKnownText");
                }
            }

            private string WellKnownTextField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the VerticalGmlCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VerticalGmlCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the VerticalGmlCrs xsd type.")]
        public partial class VerticalGmlCrs : AbstractVerticalCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// GmlVerticalCrsDefinition property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "VerticalCRSType")]
            [XmlElement("GmlVerticalCrsDefinition")]
            public VerticalCRSType GmlVerticalCrsDefinition
            {
                get
                {
                    return GmlVerticalCrsDefinitionField;
                }
                set
                {
                    GmlVerticalCrsDefinitionField = value;
                    NotifyPropertyChanged("GmlVerticalCrsDefinition");
                }
            }

            private VerticalCRSType GmlVerticalCrsDefinitionField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the VerticalLocalAuthorityCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VerticalLocalAuthorityCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the VerticalLocalAuthorityCrs xsd type.")]
        public partial class VerticalLocalAuthorityCrs : AbstractVerticalCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// LocalAuthorityCrsName property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "AuthorityQualifiedName")]
            [XmlElement("LocalAuthorityCrsName")]
            public AuthorityQualifiedName LocalAuthorityCrsName
            {
                get
                {
                    return LocalAuthorityCrsNameField;
                }
                set
                {
                    LocalAuthorityCrsNameField = value;
                    NotifyPropertyChanged("LocalAuthorityCrsName");
                }
            }

            private AuthorityQualifiedName LocalAuthorityCrsNameField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the VerticalEpsgCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VerticalEpsgCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the VerticalEpsgCrs xsd type.")]
        public partial class VerticalEpsgCrs : AbstractVerticalCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// EpsgCode property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("EpsgCode")]
            public long? EpsgCode
            {
                get
                {
                    return EpsgCodeField;
                }
                set
                {
                    EpsgCodeField = value;
                    NotifyPropertyChanged("EpsgCode");
                }
            }

            private long? EpsgCodeField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the VerticalUnknownCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VerticalUnknownCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the VerticalUnknownCrs xsd type.")]
        public partial class VerticalUnknownCrs : AbstractVerticalCrs, INotifyPropertyChanged
        {

            /// <summary>
            /// Unknown property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Unknown")]
            public string Unknown
            {
                get
                {
                    return UnknownField;
                }
                set
                {
                    UnknownField = value;
                    NotifyPropertyChanged("Unknown");
                }
            }

            private string UnknownField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ParameterTemplate xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ParameterTemplate", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [Description("This class represents the ParameterTemplate xsd type.")]
        public partial class ParameterTemplate : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// AllowedKind property
            /// </summary>
            [Description("If no allowed type is given, then all kind of datatypes is allowed.")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ParameterKind")]
            [XmlElement("AllowedKind")]
            public List<ParameterKind> AllowedKind
            {
                get
                {
                    return AllowedKindField;
                }
                set
                {
                    AllowedKindField = value;
                    NotifyPropertyChanged("AllowedKind");
                }
            }

            /// <summary>
            /// bool to indicate if AllowedKind has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool AllowedKindSpecified
            {
                get
                {
                    if (AllowedKindField != null)
                        return AllowedKindField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ParameterKind> AllowedKindField;

            /// <summary>
            /// IsInput property
            /// </summary>
            [Required]
            [Description("Indicates if the parameter is an input of the activity. If the parameter is a data object and is also an output of the activity, it is strongly advised to use two parameters : one for input and one for output. The reason is to be able to give two different versions strings for the input and output dataobject which has got obviously the same UUID.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("IsInput")]
            public bool? IsInput
            {
                get
                {
                    return IsInputField;
                }
                set
                {
                    IsInputField = value;
                    NotifyPropertyChanged("IsInput");
                }
            }

            private bool? IsInputField;

            /// <summary>
            /// KeyConstraint property
            /// </summary>
            [Description("Allows to indicate that, in the same activity, this parameter template must be associated to another parameter template identified by its title.")]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("KeyConstraint")]
            public List<string> KeyConstraint
            {
                get
                {
                    return KeyConstraintField;
                }
                set
                {
                    KeyConstraintField = value;
                    NotifyPropertyChanged("KeyConstraint");
                }
            }

            /// <summary>
            /// bool to indicate if KeyConstraint has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool KeyConstraintSpecified
            {
                get
                {
                    if (KeyConstraintField != null)
                        return KeyConstraintField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<string> KeyConstraintField;

            /// <summary>
            /// IsOutput property
            /// </summary>
            [Required]
            [Description("Indicates if the parameter is an output of the activity. If the parameter is a data object and is also an input of the activity, it is strongly advised to use two parameters : one for input and one for output. The reason is to be able to give two different versions strings for the input and output dataobject which has got obviously the same UUID.")]
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlElement("IsOutput")]
            public bool? IsOutput
            {
                get
                {
                    return IsOutputField;
                }
                set
                {
                    IsOutputField = value;
                    NotifyPropertyChanged("IsOutput");
                }
            }

            private bool? IsOutputField;

            /// <summary>
            /// Title property
            /// </summary>
            [Required]
            [StringLength(2000)]
            [Description("Name of the parameter in the activity. Key to identify parameter.")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Title")]
            public string Title
            {
                get
                {
                    return TitleField;
                }
                set
                {
                    TitleField = value;
                    NotifyPropertyChanged("Title");
                }
            }

            private string TitleField;

            /// <summary>
            /// DataObjectContentType property
            /// </summary>
            [StringLength(2000)]
            [Description("When parameter is limited to data object of given types, describe the allowed types. Used only when ParameterType is dataObject")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("DataObjectContentType")]
            public string DataObjectContentType
            {
                get
                {
                    return DataObjectContentTypeField;
                }
                set
                {
                    DataObjectContentTypeField = value;
                    NotifyPropertyChanged("DataObjectContentType");
                }
            }

            private string DataObjectContentTypeField;

            /// <summary>
            /// MaxOccurs property
            /// </summary>
            [Required]
            [Description("Maximum number of parameters of this type allowed in the activity. If the maximum number of parameters is infinite, use -1 value.")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("MaxOccurs")]
            public long? MaxOccurs
            {
                get
                {
                    return MaxOccursField;
                }
                set
                {
                    MaxOccursField = value;
                    NotifyPropertyChanged("MaxOccurs");
                }
            }

            private long? MaxOccursField;

            /// <summary>
            /// MinOccurs property
            /// </summary>
            [Required]
            [Description("Minimum number of parameter of this type required by the activity. If the minimum number of parameters is infinite, use -1 value.")]
            [EnergisticsDataTypeAttribute(DataType = "long")]
            [XmlElement("MinOccurs")]
            public long? MinOccurs
            {
                get
                {
                    return MinOccursField;
                }
                set
                {
                    MinOccursField = value;
                    NotifyPropertyChanged("MinOccurs");
                }
            }

            private long? MinOccursField;

            /// <summary>
            /// Constraint property
            /// </summary>
            [StringLength(2000)]
            [Description("Textual description of additional constraint associated with the parameter. (note that it will be better to have a formal description of the constraint)")]
            [EnergisticsDataTypeAttribute(DataType = "String2000")]
            [XmlElement("Constraint")]
            public string Constraint
            {
                get
                {
                    return ConstraintField;
                }
                set
                {
                    ConstraintField = value;
                    NotifyPropertyChanged("Constraint");
                }
            }

            private string ConstraintField;

            /// <summary>
            /// DefaultValue property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "AbstractActivityParameter")]
            [XmlElement("DefaultValue")]
            public List<AbstractActivityParameter> DefaultValue
            {
                get
                {
                    return DefaultValueField;
                }
                set
                {
                    DefaultValueField = value;
                    NotifyPropertyChanged("DefaultValue");
                }
            }

            /// <summary>
            /// bool to indicate if DefaultValue has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool DefaultValueSpecified
            {
                get
                {
                    if (DefaultValueField != null)
                        return DefaultValueField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<AbstractActivityParameter> DefaultValueField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractProperty xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointsProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractValuesProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscreteProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContinuousProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommentProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoricalProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanProperty))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractProperty", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the AbstractProperty xsd type.")]
        public abstract partial class AbstractProperty : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {

            /// <summary>
            /// IndexableElement property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "IndexableElement")]
            [XmlElement("IndexableElement")]
            public IndexableElement? IndexableElement
            {
                get
                {
                    return IndexableElementField;
                }
                set
                {
                    IndexableElementField = value;
                    this.IndexableElementSpecified = true;
                    NotifyPropertyChanged("IndexableElement");
                }
            }


            private bool IndexableElementSpecifiedField = false;

            /// <summary>
            /// IndexableElementSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool IndexableElementSpecified
            {
                get
                {
                    return IndexableElementSpecifiedField;
                }
                set
                {
                    IndexableElementSpecifiedField = value;
                    NotifyPropertyChanged("IndexableElementSpecified");
                }
            }

            private IndexableElement? IndexableElementField;

            /// <summary>
            /// RealizationIndices property
            /// </summary>
            [Description("Provide the list of indices corresponding to realizations number. For example, if a user wants to send the realization corresponding to p10, p20, ... he would write the array 10, 20, ... If not provided, then the realization count (which could be 1) does not introduce a dimension to the multi-dimensional array storage.")]
            [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
            [XmlElement("RealizationIndices")]
            public AbstractIntegerArray RealizationIndices
            {
                get
                {
                    return RealizationIndicesField;
                }
                set
                {
                    RealizationIndicesField = value;
                    NotifyPropertyChanged("RealizationIndices");
                }
            }

            private AbstractIntegerArray RealizationIndicesField;

            /// <summary>
            /// ValueCountPerIndexableElement property
            /// </summary>
            [Description("Number of elements in a 1D list of properties of the same property kind. When used in a two-dimensional array, count is always the fastest. If not provided, then the value count does not introduce a dimension to the multi-dimensional array storage.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("ValueCountPerIndexableElement")]
            public long? ValueCountPerIndexableElement
            {
                get
                {
                    return ValueCountPerIndexableElementField;
                }
                set
                {
                    ValueCountPerIndexableElementField = value;
                    this.ValueCountPerIndexableElementSpecified = true;
                    NotifyPropertyChanged("ValueCountPerIndexableElement");
                }
            }

            private long? ValueCountPerIndexableElementField;

            /// <summary>
            /// ValueCountPerIndexableElementSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool ValueCountPerIndexableElementSpecified
            {
                get
                {
                    return ValueCountPerIndexableElementSpecifiedField;
                }
                set
                {
                    ValueCountPerIndexableElementSpecifiedField = value;
                    NotifyPropertyChanged("ValueCountPerIndexableElementSpecified");
                }
            }

            private bool ValueCountPerIndexableElementSpecifiedField;

            /// <summary>
            /// SupportingRepresentation property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("SupportingRepresentation")]
            public DataObjectReference SupportingRepresentation
            {
                get
                {
                    return SupportingRepresentationField;
                }
                set
                {
                    SupportingRepresentationField = value;
                    NotifyPropertyChanged("SupportingRepresentation");
                }
            }

            private DataObjectReference SupportingRepresentationField;

            /// <summary>
            /// TimeIndices property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TimeIndices")]
            [XmlElement("TimeIndices")]
            public TimeIndices TimeIndices
            {
                get
                {
                    return TimeIndicesField;
                }
                set
                {
                    TimeIndicesField = value;
                    NotifyPropertyChanged("TimeIndices");
                }
            }

            private TimeIndices TimeIndicesField;

            /// <summary>
            /// LocalCrs property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("LocalCrs")]
            public DataObjectReference LocalCrs
            {
                get
                {
                    return LocalCrsField;
                }
                set
                {
                    LocalCrsField = value;
                    NotifyPropertyChanged("LocalCrs");
                }
            }

            private DataObjectReference LocalCrsField;

            /// <summary>
            /// PropertyKind property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "PropertyKind")]
            [XmlElement("PropertyKind")]
            public PropertyKind PropertyKind
            {
                get
                {
                    return PropertyKindField;
                }
                set
                {
                    PropertyKindField = value;
                    NotifyPropertyChanged("PropertyKind");
                }
            }

            private PropertyKind PropertyKindField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractPropertyLookup xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringTableLookup))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleTableLookup))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractPropertyLookup", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the AbstractPropertyLookup xsd type.")]
        public abstract partial class AbstractPropertyLookup : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the IdentifiedObjectType xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCRSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IdentifiedObjectType", Namespace = "http://www.opengis.net/gml/3.2")]
        [Description("This class represents the IdentifiedObjectType xsd type.")]
        public abstract partial class IdentifiedObjectType : DefinitionType, INotifyPropertyChanged
        {


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the DefinitionBaseType xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifiedObjectType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrimeMeridianType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystemAxisType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateSystemType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCRSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DefinitionBaseType", Namespace = "http://www.opengis.net/gml/3.2")]
        [Description("This class represents the DefinitionBaseType xsd type.")]
        public partial class DefinitionBaseType : AbstractGMLType, INotifyPropertyChanged
        {


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the RelatedTimeType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RelatedTimeType", Namespace = "http://www.opengis.net/gml/3.2")]
        [Description("This class represents the RelatedTimeType xsd type.")]
        public partial class RelatedTimeType : TimePrimitivePropertyType, INotifyPropertyChanged
        {

            /// <summary>
            /// relativePosition property
            /// </summary>

            [XmlAttribute("relativePosition")]

            public RelatedTimeTypeRelativePosition RelativePosition
            {
                get
                {
                    return relativePositionField;
                }
                set
                {
                    relativePositionField = value;
                    this.RelativePositionSpecified = true;
                    NotifyPropertyChanged("RelativePosition");
                }
            }

            private RelatedTimeTypeRelativePosition relativePositionField;

            /// <summary>
            /// relativePositionSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool RelativePositionSpecified
            {
                get
                {
                    return relativePositionSpecifiedField;
                }
                set
                {
                    relativePositionSpecifiedField = value;
                    NotifyPropertyChanged("RelativePositionSpecified");
                }
            }

            private bool relativePositionSpecifiedField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TimePrimitivePropertyType xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedTimeType))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TimePrimitivePropertyType", Namespace = "http://www.opengis.net/gml/3.2")]
        [Description("This class represents the TimePrimitivePropertyType xsd type.")]
        public partial class TimePrimitivePropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// AbstractTimePrimitive property
            /// </summary>
            [ComponentElement]
            [XmlElement("AbstractTimePrimitive")]
            public AbstractTimePrimitiveType AbstractTimePrimitive
            {
                get
                {
                    return AbstractTimePrimitiveField;
                }
                set
                {
                    AbstractTimePrimitiveField = value;
                    NotifyPropertyChanged("AbstractTimePrimitive");
                }
            }

            private AbstractTimePrimitiveType AbstractTimePrimitiveField;

            /// <summary>
            /// nilReason property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
            [XmlAttribute("nilReason")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;

            /// <summary>
            /// owns property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "boolean")]
            [XmlAttribute("owns")]

            public bool Owns
            {
                get
                {
                    return ownsField;
                }
                set
                {
                    ownsField = value;
                    NotifyPropertyChanged("Owns");
                }
            }

            private bool ownsField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CharacterString_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CharacterString_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
        [Description("This class represents the CharacterString_PropertyType xsd type.")]
        public partial class CharacterString_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CharacterString property
            /// </summary>

            [XmlElement("CharacterString")]
            public string CharacterString
            {
                get
                {
                    return CharacterStringField;
                }
                set
                {
                    CharacterStringField = value;
                    NotifyPropertyChanged("CharacterString");
                }
            }

            private string CharacterStringField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the EX_GeographicExtent_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EX_GeographicExtent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the EX_GeographicExtent_PropertyType xsd type.")]
        public partial class EX_GeographicExtent_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// AbstractEX_GeographicExtent property
            /// </summary>
            [ComponentElement]
            [XmlElement("AbstractEX_GeographicExtent")]
            public AbstractEX_GeographicExtent_Type AbstractEX_GeographicExtent
            {
                get
                {
                    return AbstractEX_GeographicExtentField;
                }
                set
                {
                    AbstractEX_GeographicExtentField = value;
                    NotifyPropertyChanged("AbstractEX_GeographicExtent");
                }
            }

            private AbstractEX_GeographicExtent_Type AbstractEX_GeographicExtentField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the URL_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "URL_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the URL_PropertyType xsd type.")]
        public partial class URL_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// URL property
            /// </summary>

            [XmlElement("URL", DataType = "anyURI")]
            public string URL
            {
                get
                {
                    return URLField;
                }
                set
                {
                    URLField = value;
                    NotifyPropertyChanged("URL");
                }
            }

            private string URLField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_OnLineFunctionCode_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_OnLineFunctionCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_OnLineFunctionCode_PropertyType xsd type.")]
        public partial class CI_OnLineFunctionCode_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_OnLineFunctionCode property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_OnLineFunctionCode")]
            public CodeListValue_Type CI_OnLineFunctionCode
            {
                get
                {
                    return CI_OnLineFunctionCodeField;
                }
                set
                {
                    CI_OnLineFunctionCodeField = value;
                    NotifyPropertyChanged("CI_OnLineFunctionCode");
                }
            }

            private CodeListValue_Type CI_OnLineFunctionCodeField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_Telephone_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_Telephone_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_Telephone_PropertyType xsd type.")]
        public partial class CI_Telephone_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_Telephone property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_Telephone")]
            public CI_Telephone_Type CI_Telephone
            {
                get
                {
                    return CI_TelephoneField;
                }
                set
                {
                    CI_TelephoneField = value;
                    NotifyPropertyChanged("CI_Telephone");
                }
            }

            private CI_Telephone_Type CI_TelephoneField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_Address_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_Address_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_Address_PropertyType xsd type.")]
        public partial class CI_Address_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_Address property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_Address")]
            public CI_Address_Type CI_Address
            {
                get
                {
                    return CI_AddressField;
                }
                set
                {
                    CI_AddressField = value;
                    NotifyPropertyChanged("CI_Address");
                }
            }

            private CI_Address_Type CI_AddressField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_OnlineResource_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_OnlineResource_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_OnlineResource_PropertyType xsd type.")]
        public partial class CI_OnlineResource_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_OnlineResource property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_OnlineResource")]
            public CI_OnlineResource_Type CI_OnlineResource
            {
                get
                {
                    return CI_OnlineResourceField;
                }
                set
                {
                    CI_OnlineResourceField = value;
                    NotifyPropertyChanged("CI_OnlineResource");
                }
            }

            private CI_OnlineResource_Type CI_OnlineResourceField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_Contact_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_Contact_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_Contact_PropertyType xsd type.")]
        public partial class CI_Contact_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_Contact property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_Contact")]
            public CI_Contact_Type CI_Contact
            {
                get
                {
                    return CI_ContactField;
                }
                set
                {
                    CI_ContactField = value;
                    NotifyPropertyChanged("CI_Contact");
                }
            }

            private CI_Contact_Type CI_ContactField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_RoleCode_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_RoleCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_RoleCode_PropertyType xsd type.")]
        public partial class CI_RoleCode_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_RoleCode property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_RoleCode")]
            public CodeListValue_Type CI_RoleCode
            {
                get
                {
                    return CI_RoleCodeField;
                }
                set
                {
                    CI_RoleCodeField = value;
                    NotifyPropertyChanged("CI_RoleCode");
                }
            }

            private CodeListValue_Type CI_RoleCodeField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Date_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Date_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
        [Description("This class represents the Date_PropertyType xsd type.")]
        public partial class Date_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Date property
            /// </summary>
            [XmlElement("Date")]
            public string Date
            {
                get
                {
                    return DateField;
                }
                set
                {
                    DateField = value;
                    DateSpecified = (value != null);
                    NotifyPropertyChanged("Date");
                }
            }

            private string DateField;
            private bool dateSpecified = false;

            /// <summary>
            /// bool to indicate if Date has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool DateSpecified
            {
                get
                {
                    return dateSpecified;
                }
                set
                {
                    dateSpecified = value;
                }
            }

            /// <summary>
            /// DateTime property
            /// </summary>
            [XmlElement("DateTime")]
            public DateTime? DateTime
            {
                get
                {
                    return DateTimeField;
                }
                set
                {
                    DateTimeField = value;
                    DateTimeSpecified = (value != null);
                    NotifyPropertyChanged("DateTime");
                }
            }

            private DateTime? DateTimeField;
            private bool dateTimeSpecified = false;

            /// <summary>
            /// bool to indicate if DateTime has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool DateTimeSpecified
            {
                get
                {
                    return dateTimeSpecified;
                }
                set
                {
                    dateTimeSpecified = value;
                }
            }


            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_DateTypeCode_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_DateTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_DateTypeCode_PropertyType xsd type.")]
        public partial class CI_DateTypeCode_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_DateTypeCode property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_DateTypeCode")]
            public CodeListValue_Type CI_DateTypeCode
            {
                get
                {
                    return CI_DateTypeCodeField;
                }
                set
                {
                    CI_DateTypeCodeField = value;
                    NotifyPropertyChanged("CI_DateTypeCode");
                }
            }

            private CodeListValue_Type CI_DateTypeCodeField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_Citation_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_Citation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_Citation_PropertyType xsd type.")]
        public partial class CI_Citation_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_Citation property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_Citation")]
            public CI_Citation_Type CI_Citation
            {
                get
                {
                    return CI_CitationField;
                }
                set
                {
                    CI_CitationField = value;
                    NotifyPropertyChanged("CI_Citation");
                }
            }

            private CI_Citation_Type CI_CitationField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_ResponsibleParty_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_ResponsibleParty_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_ResponsibleParty_PropertyType xsd type.")]
        public partial class CI_ResponsibleParty_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_ResponsibleParty property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_ResponsibleParty")]
            public CI_ResponsibleParty_Type CI_ResponsibleParty
            {
                get
                {
                    return CI_ResponsiblePartyField;
                }
                set
                {
                    CI_ResponsiblePartyField = value;
                    NotifyPropertyChanged("CI_ResponsibleParty");
                }
            }

            private CI_ResponsibleParty_Type CI_ResponsiblePartyField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_PresentationFormCode_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_PresentationFormCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_PresentationFormCode_PropertyType xsd type.")]
        public partial class CI_PresentationFormCode_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_PresentationFormCode property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_PresentationFormCode")]
            public CodeListValue_Type CI_PresentationFormCode
            {
                get
                {
                    return CI_PresentationFormCodeField;
                }
                set
                {
                    CI_PresentationFormCodeField = value;
                    NotifyPropertyChanged("CI_PresentationFormCode");
                }
            }

            private CodeListValue_Type CI_PresentationFormCodeField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the CI_Series_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CI_Series_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the CI_Series_PropertyType xsd type.")]
        public partial class CI_Series_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// CI_Series property
            /// </summary>
            [ComponentElement]
            [XmlElement("CI_Series")]
            public CI_Series_Type CI_Series
            {
                get
                {
                    return CI_SeriesField;
                }
                set
                {
                    CI_SeriesField = value;
                    NotifyPropertyChanged("CI_Series");
                }
            }

            private CI_Series_Type CI_SeriesField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the DQ_EvaluationMethodTypeCode_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DQ_EvaluationMethodTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the DQ_EvaluationMethodTypeCode_PropertyType xsd type.")]
        public partial class DQ_EvaluationMethodTypeCode_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// DQ_EvaluationMethodTypeCode property
            /// </summary>
            [ComponentElement]
            [XmlElement("DQ_EvaluationMethodTypeCode")]
            public CodeListValue_Type DQ_EvaluationMethodTypeCode
            {
                get
                {
                    return DQ_EvaluationMethodTypeCodeField;
                }
                set
                {
                    DQ_EvaluationMethodTypeCodeField = value;
                    NotifyPropertyChanged("DQ_EvaluationMethodTypeCode");
                }
            }

            private CodeListValue_Type DQ_EvaluationMethodTypeCodeField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the DateTime_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DateTime_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
        [Description("This class represents the DateTime_PropertyType xsd type.")]
        public partial class DateTime_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// DateTime property
            /// </summary>

            [XmlElement("DateTime")]
            public DateTime? DateTime
            {
                get
                {
                    return DateTimeField;
                }
                set
                {
                    DateTimeField = value;
                    NotifyPropertyChanged("DateTime");
                }
            }

            private DateTime? DateTimeField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the DQ_Result_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DQ_Result_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the DQ_Result_PropertyType xsd type.")]
        public partial class DQ_Result_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// AbstractDQ_Result property
            /// </summary>
            [ComponentElement]
            [XmlElement("AbstractDQ_Result")]
            public AbstractDQ_Result_Type AbstractDQ_Result
            {
                get
                {
                    return AbstractDQ_ResultField;
                }
                set
                {
                    AbstractDQ_ResultField = value;
                    NotifyPropertyChanged("AbstractDQ_Result");
                }
            }

            private AbstractDQ_Result_Type AbstractDQ_ResultField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the Real_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Real_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
        [Description("This class represents the Real_PropertyType xsd type.")]
        public partial class Real_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// Real property
            /// </summary>

            [XmlElement("Real")]
            public double? Real
            {
                get
                {
                    return RealField;
                }
                set
                {
                    RealField = value;
                    NotifyPropertyChanged("Real");
                }
            }

            private double? RealField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SC_CRS_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SC_CRS_PropertyType", Namespace = "http://www.isotc211.org/2005/gsr")]
        [Description("This class represents the SC_CRS_PropertyType xsd type.")]
        public partial class SC_CRS_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// AbstractCRS property
            /// </summary>
            [ComponentElement]
            [XmlElement("AbstractCRS", Namespace = "http://www.opengis.net/gml/3.2")]
            public AbstractCRSType AbstractCRS
            {
                get
                {
                    return AbstractCRSField;
                }
                set
                {
                    AbstractCRSField = value;
                    NotifyPropertyChanged("AbstractCRS");
                }
            }

            private AbstractCRSType AbstractCRSField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the LengthType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LengthType", Namespace = "http://www.opengis.net/gml/3.2")]
        [Description("This class represents the LengthType xsd type.")]
        public partial class LengthType : MeasureType, INotifyPropertyChanged
        {
            /// <summary>
            /// Initializes a new instance of the LengthType class.
            /// </summary>
            public LengthType() { }

            /// <summary>
            /// Initializes a new instance of the LengthType class.
            /// </summary>
            /// <param name="value">Initial value</param>
            public LengthType(double value)
            {
                this.Value = value;
            }

            /// <summary>
            /// Returns a string that represents the current object.
            /// </summary>
            public override string ToString()
            {
                return Value.ToString();
            }


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the TM_Primitive_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TM_Primitive_PropertyType", Namespace = "http://www.isotc211.org/2005/gts")]
        [Description("This class represents the TM_Primitive_PropertyType xsd type.")]
        public partial class TM_Primitive_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// AbstractTimePrimitive property
            /// </summary>
            [ComponentElement]
            [XmlElement("AbstractTimePrimitive", Namespace = "http://www.opengis.net/gml/3.2")]
            public AbstractTimePrimitiveType AbstractTimePrimitive
            {
                get
                {
                    return AbstractTimePrimitiveField;
                }
                set
                {
                    AbstractTimePrimitiveField = value;
                    NotifyPropertyChanged("AbstractTimePrimitive");
                }
            }

            private AbstractTimePrimitiveType AbstractTimePrimitiveField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the EX_TemporalExtent_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EX_TemporalExtent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the EX_TemporalExtent_PropertyType xsd type.")]
        public partial class EX_TemporalExtent_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// EX_TemporalExtent property
            /// </summary>
            [ComponentElement]
            [XmlElement("EX_TemporalExtent")]
            public EX_TemporalExtent_Type EX_TemporalExtent
            {
                get
                {
                    return EX_TemporalExtentField;
                }
                set
                {
                    EX_TemporalExtentField = value;
                    NotifyPropertyChanged("EX_TemporalExtent");
                }
            }

            private EX_TemporalExtent_Type EX_TemporalExtentField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the EX_VerticalExtent_PropertyType xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EX_VerticalExtent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
        [Description("This class represents the EX_VerticalExtent_PropertyType xsd type.")]
        public partial class EX_VerticalExtent_PropertyType : Object, INotifyPropertyChanged
        {

            /// <summary>
            /// EX_VerticalExtent property
            /// </summary>
            [ComponentElement]
            [XmlElement("EX_VerticalExtent")]
            public EX_VerticalExtent_Type EX_VerticalExtent
            {
                get
                {
                    return EX_VerticalExtentField;
                }
                set
                {
                    EX_VerticalExtentField = value;
                    NotifyPropertyChanged("EX_VerticalExtent");
                }
            }

            private EX_VerticalExtent_Type EX_VerticalExtentField;

            /// <summary>
            /// uuidref property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "string")]
            [XmlAttribute("uuidref")]

            public string Uuidref
            {
                get
                {
                    return uuidrefField;
                }
                set
                {
                    uuidrefField = value;
                    NotifyPropertyChanged("Uuidref");
                }
            }

            private string uuidrefField;

            /// <summary>
            /// nilReason property
            /// </summary>

            [XmlAttribute("nilReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.isotc211.org/2005/gco")]

            public string NilReason
            {
                get
                {
                    return nilReasonField;
                }
                set
                {
                    nilReasonField = value;
                    NotifyPropertyChanged("NilReason");
                }
            }

            private string nilReasonField;



            #region INotifyPropertyChanged Members
            /// <summary>
            /// Occurs when a property value changes. 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Triggers PropertyChanged Event
            /// </summary>
            /// <param name="info">Name of property changed</param>
            protected void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }
            #endregion INotifyPropertyChanged Members
        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractValuesProperty xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscreteProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContinuousProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommentProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoricalProperty))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanProperty))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractValuesProperty", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractValuesProperty xsd type.")]
        public abstract partial class AbstractValuesProperty : AbstractProperty, INotifyPropertyChanged
        {

            /// <summary>
            /// PatchOfValues property
            /// </summary>
            [Required]
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "PatchOfValues")]
            [XmlElement("PatchOfValues")]
            public List<PatchOfValues> PatchOfValues
            {
                get
                {
                    return PatchOfValuesField;
                }
                set
                {
                    PatchOfValuesField = value;
                    NotifyPropertyChanged("PatchOfValues");
                }
            }

            /// <summary>
            /// bool to indicate if PatchOfValues has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool PatchOfValuesSpecified
            {
                get
                {
                    if (PatchOfValuesField != null)
                        return PatchOfValuesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<PatchOfValues> PatchOfValuesField;

            /// <summary>
            /// Facet property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "PropertyKindFacet")]
            [XmlElement("Facet")]
            public List<PropertyKindFacet> Facet
            {
                get
                {
                    return FacetField;
                }
                set
                {
                    FacetField = value;
                    NotifyPropertyChanged("Facet");
                }
            }

            /// <summary>
            /// bool to indicate if Facet has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool FacetSpecified
            {
                get
                {
                    if (FacetField != null)
                        return FacetField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<PropertyKindFacet> FacetField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractSurfaceRepresentation xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneSetRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSetRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grid2dSetRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grid2dRepresentation))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractSurfaceRepresentation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractSurfaceRepresentation xsd type.")]
        public abstract partial class AbstractSurfaceRepresentation : AbstractRepresentation, INotifyPropertyChanged
        {

            /// <summary>
            /// SurfaceRole property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "SurfaceRole")]
            [XmlElement("SurfaceRole")]
            public SurfaceRole? SurfaceRole
            {
                get
                {
                    return SurfaceRoleField;
                }
                set
                {
                    SurfaceRoleField = value;
                    this.SurfaceRoleSpecified = true;
                    NotifyPropertyChanged("SurfaceRole");
                }
            }


            private bool SurfaceRoleSpecifiedField = false;

            /// <summary>
            /// SurfaceRoleSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool SurfaceRoleSpecified
            {
                get
                {
                    return SurfaceRoleSpecifiedField;
                }
                set
                {
                    SurfaceRoleSpecifiedField = value;
                    NotifyPropertyChanged("SurfaceRoleSpecified");
                }
            }

            private SurfaceRole? SurfaceRoleField;

            /// <summary>
            /// Boundaries property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "PatchBoundaries")]
            [XmlElement("Boundaries")]
            public List<PatchBoundaries> Boundaries
            {
                get
                {
                    return BoundariesField;
                }
                set
                {
                    BoundariesField = value;
                    NotifyPropertyChanged("Boundaries");
                }
            }

            /// <summary>
            /// bool to indicate if Boundaries has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool BoundariesSpecified
            {
                get
                {
                    if (BoundariesField != null)
                        return BoundariesField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<PatchBoundaries> BoundariesField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractTruncatedColumnLayerGridRepresentation xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TruncatedUnstructuredColumnLayerGridRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(TruncatedIjkGridRepresentation))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractTruncatedColumnLayerGridRepresentation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractTruncatedColumnLayerGridRepresentation xsd type.")]
        public abstract partial class AbstractTruncatedColumnLayerGridRepresentation : AbstractGridRepresentation, INotifyPropertyChanged
        {

            /// <summary>
            /// Nk property
            /// </summary>
            [Required]
            [Description("Number of layers in the grid. Must be positive.")]
            [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
            [XmlElement("Nk")]
            public long? Nk
            {
                get
                {
                    return NkField;
                }
                set
                {
                    NkField = value;
                    NotifyPropertyChanged("Nk");
                }
            }

            private long? NkField;

            /// <summary>
            /// TruncationCellPatch property
            /// </summary>
            [Required]
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "TruncationCellPatch")]
            [XmlElement("TruncationCellPatch")]
            public TruncationCellPatch TruncationCellPatch
            {
                get
                {
                    return TruncationCellPatchField;
                }
                set
                {
                    TruncationCellPatchField = value;
                    NotifyPropertyChanged("TruncationCellPatch");
                }
            }

            private TruncationCellPatch TruncationCellPatchField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractSurfaceFrameworkRepresentation xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SealedSurfaceFrameworkRepresentation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonSealedSurfaceFrameworkRepresentation))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractSurfaceFrameworkRepresentation", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractSurfaceFrameworkRepresentation xsd type.")]
        public abstract partial class AbstractSurfaceFrameworkRepresentation : RepresentationSetRepresentation, INotifyPropertyChanged
        {

            /// <summary>
            /// ContactIdentity property
            /// </summary>
            [RecurringElement]
            [EnergisticsDataTypeAttribute(DataType = "ContactIdentity")]
            [XmlElement("ContactIdentity")]
            public List<ContactIdentity> ContactIdentity
            {
                get
                {
                    return ContactIdentityField;
                }
                set
                {
                    ContactIdentityField = value;
                    NotifyPropertyChanged("ContactIdentity");
                }
            }

            /// <summary>
            /// bool to indicate if ContactIdentity has been set. Used for serialization.
            /// </summary>
            [XmlIgnore]
            public bool ContactIdentitySpecified
            {
                get
                {
                    if (ContactIdentityField != null)
                        return ContactIdentityField.Count > 0 ? true : false;
                    else return false;
                }
            }
            private List<ContactIdentity> ContactIdentityField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractSeismicSurveyFeature xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicLineSetFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicLatticeSetFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicLatticeFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSeismicLineFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShotPointLineFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CmpLineFeature))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractSeismicSurveyFeature", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractSeismicSurveyFeature xsd type.")]
        public abstract partial class AbstractSeismicSurveyFeature : AbstractTechnicalFeature, INotifyPropertyChanged
        {


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the SeismicLatticeSetFeature xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SeismicLatticeSetFeature", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the SeismicLatticeSetFeature xsd type.")]
        public partial class SeismicLatticeSetFeature : AbstractSeismicSurveyFeature, INotifyPropertyChanged
        {


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the AbstractSeismicLineFeature xsd type.
        /// </summary>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShotPointLineFeature))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(CmpLineFeature))]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AbstractSeismicLineFeature", Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
        [Description("This class represents the AbstractSeismicLineFeature xsd type.")]
        public abstract partial class AbstractSeismicLineFeature : AbstractSeismicSurveyFeature, INotifyPropertyChanged
        {

            /// <summary>
            /// TraceLabels property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "StringExternalArray")]
            [XmlElement("TraceLabels")]
            public StringExternalArray TraceLabels
            {
                get
                {
                    return TraceLabelsField;
                }
                set
                {
                    TraceLabelsField = value;
                    NotifyPropertyChanged("TraceLabels");
                }
            }

            private StringExternalArray TraceLabelsField;

            /// <summary>
            /// IsPartOf property
            /// </summary>
            [ComponentElement]
            [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
            [XmlElement("IsPartOf")]
            public DataObjectReference IsPartOf
            {
                get
                {
                    return IsPartOfField;
                }
                set
                {
                    IsPartOfField = value;
                    NotifyPropertyChanged("IsPartOf");
                }
            }

            private DataObjectReference IsPartOfField;


        } //here
    }
    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the GeodeticCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeodeticCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the GeodeticCrs xsd type.")]
        public partial class GeodeticCrs : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {

            /// <summary>
            /// AbstractGeodeticCrs property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "AbstractGeodeticCrs")]
            [XmlElement("AbstractGeodeticCrs")]
            public AbstractGeodeticCrs AbstractGeodeticCrs
            {
                get
                {
                    return AbstractGeodeticCrsField;
                }
                set
                {
                    AbstractGeodeticCrsField = value;
                    NotifyPropertyChanged("AbstractGeodeticCrs");
                }
            }

            private AbstractGeodeticCrs AbstractGeodeticCrsField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the ProjectedCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProjectedCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the ProjectedCrs xsd type.")]
        public partial class ProjectedCrs : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {

            /// <summary>
            /// AxisOrder property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "AxisOrder2d")]
            [XmlElement("AxisOrder")]
            public AxisOrder2d? AxisOrder
            {
                get
                {
                    return AxisOrderField;
                }
                set
                {
                    AxisOrderField = value;
                    this.AxisOrderSpecified = true;
                    NotifyPropertyChanged("AxisOrder");
                }
            }


            private bool AxisOrderSpecifiedField = false;

            /// <summary>
            /// AxisOrderSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool AxisOrderSpecified
            {
                get
                {
                    return AxisOrderSpecifiedField;
                }
                set
                {
                    AxisOrderSpecifiedField = value;
                    NotifyPropertyChanged("AxisOrderSpecified");
                }
            }

            private AxisOrder2d? AxisOrderField;

            /// <summary>
            /// AbstractProjectedCrs property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "AbstractProjectedCrs")]
            [XmlElement("AbstractProjectedCrs")]
            public AbstractProjectedCrs AbstractProjectedCrs
            {
                get
                {
                    return AbstractProjectedCrsField;
                }
                set
                {
                    AbstractProjectedCrsField = value;
                    NotifyPropertyChanged("AbstractProjectedCrs");
                }
            }

            private AbstractProjectedCrs AbstractProjectedCrsField;

            /// <summary>
            /// uom property
            /// </summary>
            [EnergisticsDataTypeAttribute(DataType = "LengthUomExt")]
            [XmlAttribute("uom")]

            public string Uom
            {
                get
                {
                    return uomField;
                }
                set
                {
                    uomField = value;
                    NotifyPropertyChanged("Uom");
                }
            }

            private string uomField;


        } //here
    }

    namespace ComponentSchemas
    {
        /// <summary>
        /// This class represents the VerticalCrs xsd type.
        /// </summary>
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VerticalCrs", Namespace = "http://www.energistics.org/energyml/data/commonv2")]
        [EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
        [Description("This class represents the VerticalCrs xsd type.")]
        public partial class VerticalCrs : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
        {

            /// <summary>
            /// Direction property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "VerticalDirection")]
            [XmlElement("Direction")]
            public VerticalDirection? Direction
            {
                get
                {
                    return DirectionField;
                }
                set
                {
                    DirectionField = value;
                    this.DirectionSpecified = true;
                    NotifyPropertyChanged("Direction");
                }
            }


            private bool DirectionSpecifiedField = false;

            /// <summary>
            /// DirectionSpecified property
            /// </summary>
            [XmlIgnore]
            [Browsable(false)]
            public bool DirectionSpecified
            {
                get
                {
                    return DirectionSpecifiedField;
                }
                set
                {
                    DirectionSpecifiedField = value;
                    NotifyPropertyChanged("DirectionSpecified");
                }
            }

            private VerticalDirection? DirectionField;

            /// <summary>
            /// AbstractVerticalCrs property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "AbstractVerticalCrs")]
            [XmlElement("AbstractVerticalCrs")]
            public AbstractVerticalCrs AbstractVerticalCrs
            {
                get
                {
                    return AbstractVerticalCrsField;
                }
                set
                {
                    AbstractVerticalCrsField = value;
                    NotifyPropertyChanged("AbstractVerticalCrs");
                }
            }

            private AbstractVerticalCrs AbstractVerticalCrsField;

            /// <summary>
            /// uom property
            /// </summary>
            [Required]
            [EnergisticsDataTypeAttribute(DataType = "LengthUomExt")]
            [XmlAttribute("uom")]

            public string Uom
            {
                get
                {
                    return uomField;
                }
                set
                {
                    uomField = value;
                    NotifyPropertyChanged("Uom");
                }
            }

            private string uomField;


        } //here
    }
}
