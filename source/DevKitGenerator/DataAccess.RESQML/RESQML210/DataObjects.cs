
//This code was generated using the Energistics Generator tool.  Direct changes to this code will be lost
//during regeneration.

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
    #region Classes
    /// <summary>
    /// This class represents the AbstractObject xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MdDatum))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertySet))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractPropertyLookup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringTableLookup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleTableLookup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointsProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractValuesProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscreteProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContinuousProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommentProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoricalProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanProperty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractLocal3dCrs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocalTime3dCrs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocalDepth3dCrs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocalGridSet))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RepresentationIdentitySet))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellboreMarker))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractRepresentation))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicUnitDictionary))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeatureInterpretation))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicColumn))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureInterpretationSet))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractFeature))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RockVolumeFeatureDictionary))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphicalInformationSet))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataAssuranceRecord))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCrs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCrs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCrs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityTemplate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Activity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeSeries))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyKind))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyKindDictionary))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EpcExternalPartReference))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/commonv2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDataObject", Namespace="http://www.energistics.org/energyml/data/commonv2", IsNullable=false)]
	[Description("This class represents the AbstractObject xsd type.")]
    public abstract partial class AbstractObject : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Aliases property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "ObjectAlias")]
		[XmlElement("Aliases")]
        public List<ObjectAlias> Aliases {
            get {
                return AliasesField;
            } 
            set {
                AliasesField = value;
                NotifyPropertyChanged("Aliases");
            }
        }

         /// <summary>
         /// bool to indicate if Aliases has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool AliasesSpecified
         {
             get {
             if(AliasesField!=null)
                 return AliasesField.Count>0?true:false;
             else return false;
             }
         }
        private List<ObjectAlias> AliasesField; 

        /// <summary>
        /// Citation property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Citation")]
		[XmlElement("Citation")]
        public Citation Citation {
            get {
                return CitationField;
            } 
            set {
                CitationField = value;
                NotifyPropertyChanged("Citation");
            }
        }

        private Citation CitationField; 

        /// <summary>
        /// CustomData property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "CustomData")]
		[XmlElement("CustomData")]
        public CustomData CustomData {
            get {
                return CustomDataField;
            } 
            set {
                CustomDataField = value;
                NotifyPropertyChanged("CustomData");
            }
        }

        private CustomData CustomDataField; 

        /// <summary>
        /// ExtensionNameValue property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "ExtensionNameValue")]
		[XmlElement("ExtensionNameValue")]
        public List<ExtensionNameValue> ExtensionNameValue {
            get {
                return ExtensionNameValueField;
            } 
            set {
                ExtensionNameValueField = value;
                NotifyPropertyChanged("ExtensionNameValue");
            }
        }

         /// <summary>
         /// bool to indicate if ExtensionNameValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ExtensionNameValueSpecified
         {
             get {
             if(ExtensionNameValueField!=null)
                 return ExtensionNameValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<ExtensionNameValue> ExtensionNameValueField; 

		/// <summary>
        /// objectVersion property
        /// </summary>
		[StringLength(64)]
        [EnergisticsDataTypeAttribute(DataType = "String64")]
        [XmlAttribute("objectVersion")]
		
        public string ObjectVersion {
            get {
                return objectVersionField;
            } 
            set {
                objectVersionField = value;
                NotifyPropertyChanged("ObjectVersion");
            }
        }

        private string objectVersionField; 

		/// <summary>
        /// schemaVersion property
        /// </summary>
		[Required]
        [StringLength(64)]
        [EnergisticsDataTypeAttribute(DataType = "String64")]
        [XmlAttribute("schemaVersion")]
		
        public string SchemaVersion {
            get {
                return schemaVersionField;
            } 
            set {
                schemaVersionField = value;
                NotifyPropertyChanged("SchemaVersion");
            }
        }

        private string schemaVersionField; 

		/// <summary>
        /// uuid property
        /// </summary>
		[Required]
        [RegularExpression("[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}")]
        [EnergisticsDataTypeAttribute(DataType = "UuidString")]
        [XmlAttribute("uuid")]
		
        public string Uuid {
            get {
                return uuidField;
            } 
            set {
                uuidField = value;
                NotifyPropertyChanged("Uuid");
            }
        }

        private string uuidField; 

		/// <summary>
        /// existenceKind property
        /// </summary>
		[Description("A lifecycle state like actual, required, planned, predicted, etc. This is used to qualify any top-level element (from Epicentre 2.1).")]
        [EnergisticsDataTypeAttribute(DataType = "ExistenceKind")]
        [XmlAttribute("existenceKind")]
		
        public ExistenceKind ExistenceKind {
            get {
                return existenceKindField;
            } 
            set {
                existenceKindField = value;
                 this.ExistenceKindSpecified = true;
                NotifyPropertyChanged("ExistenceKind");
            }
        }

        private ExistenceKind existenceKindField; 

        /// <summary>
        /// existenceKindSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool ExistenceKindSpecified {
            get {
                return existenceKindSpecifiedField;
            } 
            set {
                existenceKindSpecifiedField = value;
                NotifyPropertyChanged("ExistenceKindSpecified");
            }
        }

        private bool existenceKindSpecifiedField; 


        
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

  

    /// <summary>
    /// This class represents the TimeSeries xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/commonv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/commonv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the TimeSeries xsd type.")]
    public partial class TimeSeries : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Time property
        /// </summary>
		[Required]
        [Description("Individual times composing the series. The list ordering is used by the time index.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "GeologicTime")]
		[XmlElement("Time")]
        public List<GeologicTime> Time {
            get {
                return TimeField;
            } 
            set {
                TimeField = value;
                NotifyPropertyChanged("Time");
            }
        }

         /// <summary>
         /// bool to indicate if Time has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TimeSpecified
         {
             get {
             if(TimeField!=null)
                 return TimeField.Count>0?true:false;
             else return false;
             }
         }
        private List<GeologicTime> TimeField; 

        /// <summary>
        /// TimeSeriesParentage property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "TimeSeriesParentage")]
		[XmlElement("TimeSeriesParentage")]
        public TimeSeriesParentage TimeSeriesParentage {
            get {
                return TimeSeriesParentageField;
            } 
            set {
                TimeSeriesParentageField = value;
                NotifyPropertyChanged("TimeSeriesParentage");
            }
        }

        private TimeSeriesParentage TimeSeriesParentageField; 


    } //here







    /// <summary>
    /// This class represents the GeodeticCRSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("GeodeticCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeodeticCRSType xsd type.")]
    public partial class GeodeticCRSType : AbstractCRSType, INotifyPropertyChanged
    {

        /// <summary>
        /// cartesianCS property
        /// </summary>
        [ComponentElement]
        [XmlElement("cartesianCS")]
        public CartesianCSPropertyType CartesianCS {
            get {
                return cartesianCSField;
            } 
            set {
                cartesianCSField = value;
                CartesianCSSpecified = (value!=null);
                NotifyPropertyChanged("CartesianCS");
            }
        }

        private CartesianCSPropertyType cartesianCSField; 
        private bool cartesianCSSpecified = false; 

        /// <summary>
        /// bool to indicate if CartesianCS has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool CartesianCSSpecified
        {
            get {
                return cartesianCSSpecified;
            }
            set {
                cartesianCSSpecified= value;
            }
        }

        /// <summary>
        /// ellipsoidalCS property
        /// </summary>
        [ComponentElement]
        [XmlElement("ellipsoidalCS")]
        public EllipsoidalCSPropertyType EllipsoidalCS {
            get {
                return ellipsoidalCSField;
            } 
            set {
                ellipsoidalCSField = value;
                EllipsoidalCSSpecified = (value!=null);
                NotifyPropertyChanged("EllipsoidalCS");
            }
        }

        private EllipsoidalCSPropertyType ellipsoidalCSField; 
        private bool ellipsoidalCSSpecified = false; 

        /// <summary>
        /// bool to indicate if EllipsoidalCS has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool EllipsoidalCSSpecified
        {
            get {
                return ellipsoidalCSSpecified;
            }
            set {
                ellipsoidalCSSpecified= value;
            }
        }

        /// <summary>
        /// sphericalCS property
        /// </summary>
        [ComponentElement]
        [XmlElement("sphericalCS")]
        public SphericalCSPropertyType SphericalCS {
            get {
                return sphericalCSField;
            } 
            set {
                sphericalCSField = value;
                SphericalCSSpecified = (value!=null);
                NotifyPropertyChanged("SphericalCS");
            }
        }

        private SphericalCSPropertyType sphericalCSField; 
        private bool sphericalCSSpecified = false; 

        /// <summary>
        /// bool to indicate if SphericalCS has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SphericalCSSpecified
        {
            get {
                return sphericalCSSpecified;
            }
            set {
                sphericalCSSpecified= value;
            }
        }


        /// <summary>
        /// geodeticDatum property
        /// </summary>
		[ComponentElement]
		[XmlElement("geodeticDatum")]
        public GeodeticDatumPropertyType GeodeticDatum {
            get {
                return geodeticDatumField;
            } 
            set {
                geodeticDatumField = value;
                NotifyPropertyChanged("GeodeticDatum");
            }
        }

        private GeodeticDatumPropertyType geodeticDatumField; 


    } //here

    /// <summary>
    /// This class represents the CartesianCSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("cartesianCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CartesianCSPropertyType xsd type.")]
    public partial class CartesianCSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CartesianCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("CartesianCS")]
        public CartesianCSType CartesianCS {
            get {
                return CartesianCSField;
            } 
            set {
                CartesianCSField = value;
                NotifyPropertyChanged("CartesianCS");
            }
        }

        private CartesianCSType CartesianCSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the CartesianCSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CartesianCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CartesianCSType xsd type.")]
    public partial class CartesianCSType : AbstractCoordinateSystemType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the AbstractCoordinateSystemType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipsoidalCSType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractCoordinateSystem", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractCoordinateSystemType xsd type.")]
    public abstract partial class AbstractCoordinateSystemType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// axis property
        /// </summary>
		[RecurringElement]
		[XmlElement("axis")]
        public List<CoordinateSystemAxisPropertyType> Axis {
            get {
                return axisField;
            } 
            set {
                axisField = value;
                NotifyPropertyChanged("Axis");
            }
        }

         /// <summary>
         /// bool to indicate if Axis has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool AxisSpecified
         {
             get {
             if(axisField!=null)
                 return axisField.Count>0?true:false;
             else return false;
             }
         }
        private List<CoordinateSystemAxisPropertyType> axisField; 

		/// <summary>
        /// aggregationType property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "AggregationType")]
        [XmlAttribute("aggregationType")]
		
        public AggregationType AggregationType {
            get {
                return aggregationTypeField;
            } 
            set {
                aggregationTypeField = value;
                 this.AggregationTypeSpecified = true;
                NotifyPropertyChanged("AggregationType");
            }
        }

        private AggregationType aggregationTypeField; 

        /// <summary>
        /// aggregationTypeSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool AggregationTypeSpecified {
            get {
                return aggregationTypeSpecifiedField;
            } 
            set {
                aggregationTypeSpecifiedField = value;
                NotifyPropertyChanged("AggregationTypeSpecified");
            }
        }

        private bool aggregationTypeSpecifiedField; 


    } //here

    /// <summary>
    /// This class represents the CoordinateSystemAxisPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("axis", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CoordinateSystemAxisPropertyType xsd type.")]
    public partial class CoordinateSystemAxisPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// CoordinateSystemAxis property
        /// </summary>
		[ComponentElement]
		[XmlElement("CoordinateSystemAxis")]
        public CoordinateSystemAxisType CoordinateSystemAxis {
            get {
                return CoordinateSystemAxisField;
            } 
            set {
                CoordinateSystemAxisField = value;
                NotifyPropertyChanged("CoordinateSystemAxis");
            }
        }

        private CoordinateSystemAxisType CoordinateSystemAxisField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the CoordinateSystemAxisType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("CoordinateSystemAxis", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CoordinateSystemAxisType xsd type.")]
    public partial class CoordinateSystemAxisType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// axisAbbrev property
        /// </summary>
		[ComponentElement]
		[XmlElement("axisAbbrev")]
        public CodeType AxisAbbrev {
            get {
                return axisAbbrevField;
            } 
            set {
                axisAbbrevField = value;
                NotifyPropertyChanged("AxisAbbrev");
            }
        }

        private CodeType axisAbbrevField; 

        /// <summary>
        /// axisDirection property
        /// </summary>
		[ComponentElement]
		[XmlElement("axisDirection")]
        public CodeWithAuthorityType AxisDirection {
            get {
                return axisDirectionField;
            } 
            set {
                axisDirectionField = value;
                NotifyPropertyChanged("AxisDirection");
            }
        }

        private CodeWithAuthorityType axisDirectionField; 

        /// <summary>
        /// minimumValue property
        /// </summary>
		
		[XmlElement("minimumValue")]
        public double? MinimumValue {
            get {
                return minimumValueField;
            } 
            set {
                minimumValueField = value;
                 this.MinimumValueSpecified = true;
                NotifyPropertyChanged("MinimumValue");
            }
        }

        private double? minimumValueField; 

        /// <summary>
        /// minimumValueSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool MinimumValueSpecified {
            get {
                return minimumValueSpecifiedField;
            } 
            set {
                minimumValueSpecifiedField = value;
                NotifyPropertyChanged("MinimumValueSpecified");
            }
        }

        private bool minimumValueSpecifiedField; 

        /// <summary>
        /// maximumValue property
        /// </summary>
		
		[XmlElement("maximumValue")]
        public double? MaximumValue {
            get {
                return maximumValueField;
            } 
            set {
                maximumValueField = value;
                 this.MaximumValueSpecified = true;
                NotifyPropertyChanged("MaximumValue");
            }
        }

        private double? maximumValueField; 

        /// <summary>
        /// maximumValueSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool MaximumValueSpecified {
            get {
                return maximumValueSpecifiedField;
            } 
            set {
                maximumValueSpecifiedField = value;
                NotifyPropertyChanged("MaximumValueSpecified");
            }
        }

        private bool maximumValueSpecifiedField; 

        /// <summary>
        /// rangeMeaning property
        /// </summary>
		[ComponentElement]
		[XmlElement("rangeMeaning")]
        public CodeWithAuthorityType RangeMeaning {
            get {
                return rangeMeaningField;
            } 
            set {
                rangeMeaningField = value;
                NotifyPropertyChanged("RangeMeaning");
            }
        }

        private CodeWithAuthorityType rangeMeaningField; 


    } //here

    /// <summary>
    /// This class represents the CodeType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CodeWithAuthorityType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("name", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CodeType xsd type.")]
    public partial class CodeType : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the CodeType class.
        /// </summary>
        public CodeType() {}

        /// <summary>
        /// Initializes a new instance of the CodeType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public CodeType(string value)
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
        /// codeSpace property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("codeSpace")]
		
        public string CodeSpace {
            get {
                return codeSpaceField;
            } 
            set {
                codeSpaceField = value;
                NotifyPropertyChanged("CodeSpace");
            }
        }

        private string codeSpaceField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
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

    /// <summary>
    /// This class represents the CodeWithAuthorityType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("identifier", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CodeWithAuthorityType xsd type.")]
    public partial class CodeWithAuthorityType : CodeType, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the CodeWithAuthorityType class.
        /// </summary>
        public CodeWithAuthorityType() {}

        /// <summary>
        /// Initializes a new instance of the CodeWithAuthorityType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public CodeWithAuthorityType(string value)
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



    /// <summary>
    /// This class represents the DefinitionType xsd type.
    /// </summary>
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Definition", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the DefinitionType xsd type.")]
    public partial class DefinitionType : DefinitionBaseType, INotifyPropertyChanged
    {

        /// <summary>
        /// remarks property
        /// </summary>
		
		[XmlElement("remarks")]
        public string Remarks {
            get {
                return remarksField;
            } 
            set {
                remarksField = value;
                NotifyPropertyChanged("Remarks");
            }
        }

        private string remarksField; 


    } //here



    /// <summary>
    /// This class represents the AbstractGMLType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimePrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DefinitionBaseType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGML", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractGMLType xsd type.")]
    public abstract partial class AbstractGMLType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
		[XmlElement("description")]
        public StringOrRefType Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private StringOrRefType descriptionField; 

        /// <summary>
        /// descriptionReference property
        /// </summary>
		[ComponentElement]
		[XmlElement("descriptionReference")]
        public ReferenceType DescriptionReference {
            get {
                return descriptionReferenceField;
            } 
            set {
                descriptionReferenceField = value;
                NotifyPropertyChanged("DescriptionReference");
            }
        }

        private ReferenceType descriptionReferenceField; 

        /// <summary>
        /// identifier property
        /// </summary>
		[ComponentElement]
		[XmlElement("identifier")]
        public CodeWithAuthorityType Identifier {
            get {
                return identifierField;
            } 
            set {
                identifierField = value;
                NotifyPropertyChanged("Identifier");
            }
        }

        private CodeWithAuthorityType identifierField; 

        /// <summary>
        /// name property
        /// </summary>
		[RecurringElement]
		[XmlElement("name")]
        public List<CodeType> Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

         /// <summary>
         /// bool to indicate if Name has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool NameSpecified
         {
             get {
             if(nameField!=null)
                 return nameField.Count>0?true:false;
             else return false;
             }
         }
        private List<CodeType> nameField; 

		/// <summary>
        /// id property
        /// </summary>
		
        [XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
		
        public string Id {
            get {
                return idField;
            } 
            set {
                idField = value;
                NotifyPropertyChanged("Id");
            }
        }

        private string idField; 


        
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

    /// <summary>
    /// This class represents the StringOrRefType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("description", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the StringOrRefType xsd type.")]
    public partial class StringOrRefType : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the StringOrRefType class.
        /// </summary>
        public StringOrRefType() {}

        /// <summary>
        /// Initializes a new instance of the StringOrRefType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public StringOrRefType(string value)
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
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
                nilReasonField = value;
                NotifyPropertyChanged("NilReason");
            }
        }

        private string nilReasonField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
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

    /// <summary>
    /// This class represents the ReferenceType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("descriptionReference", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the ReferenceType xsd type.")]
    public partial class ReferenceType : Object, INotifyPropertyChanged
    {

		/// <summary>
        /// owns property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "boolean")]
        [XmlAttribute("owns")]
		
        public bool Owns {
            get {
                return ownsField;
            } 
            set {
                ownsField = value;
                NotifyPropertyChanged("Owns");
            }
        }

        private bool ownsField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the AbstractTimeObjectType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimePrimitiveType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractTimeObject", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractTimeObjectType xsd type.")]
    public abstract partial class AbstractTimeObjectType : AbstractGMLType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the AbstractTimePrimitiveType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractTimePrimitive", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractTimePrimitiveType xsd type.")]
    public abstract partial class AbstractTimePrimitiveType : AbstractTimeObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// relatedTime property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "RelatedTimeType")]
		[XmlElement("relatedTime")]
        public List<RelatedTimeType> RelatedTime {
            get {
                return relatedTimeField;
            } 
            set {
                relatedTimeField = value;
                NotifyPropertyChanged("RelatedTime");
            }
        }

         /// <summary>
         /// bool to indicate if RelatedTime has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool RelatedTimeSpecified
         {
             get {
             if(relatedTimeField!=null)
                 return relatedTimeField.Count>0?true:false;
             else return false;
             }
         }
        private List<RelatedTimeType> relatedTimeField; 


    } //here



    /// <summary>
    /// This class represents the AbstractCoordinateOperationType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractOperation", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractCoordinateOperationType xsd type.")]
    public abstract partial class AbstractCoordinateOperationType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// domainOfValidity property
        /// </summary>
		[ComponentElement]
		[XmlElement("domainOfValidity")]
        public DomainOfValidity DomainOfValidity {
            get {
                return domainOfValidityField;
            } 
            set {
                domainOfValidityField = value;
                NotifyPropertyChanged("DomainOfValidity");
            }
        }

        private DomainOfValidity domainOfValidityField; 

        /// <summary>
        /// scope property
        /// </summary>
		[RecurringElement]
		[XmlElement("scope")]
        public List<string> Scope {
            get {
                return scopeField;
            } 
            set {
                scopeField = value;
                NotifyPropertyChanged("Scope");
            }
        }

         /// <summary>
         /// bool to indicate if Scope has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ScopeSpecified
         {
             get {
             if(scopeField!=null)
                 return scopeField.Count>0?true:false;
             else return false;
             }
         }
        private List<string> scopeField; 

        /// <summary>
        /// operationVersion property
        /// </summary>
		
		[XmlElement("operationVersion")]
        public string OperationVersion {
            get {
                return operationVersionField;
            } 
            set {
                operationVersionField = value;
                NotifyPropertyChanged("OperationVersion");
            }
        }

        private string operationVersionField; 

        /// <summary>
        /// coordinateOperationAccuracy property
        /// </summary>
		[RecurringElement]
		[XmlElement("coordinateOperationAccuracy")]
        public List<CoordinateOperationAccuracy> CoordinateOperationAccuracy {
            get {
                return coordinateOperationAccuracyField;
            } 
            set {
                coordinateOperationAccuracyField = value;
                NotifyPropertyChanged("CoordinateOperationAccuracy");
            }
        }

         /// <summary>
         /// bool to indicate if CoordinateOperationAccuracy has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool CoordinateOperationAccuracySpecified
         {
             get {
             if(coordinateOperationAccuracyField!=null)
                 return coordinateOperationAccuracyField.Count>0?true:false;
             else return false;
             }
         }
        private List<CoordinateOperationAccuracy> coordinateOperationAccuracyField; 

        /// <summary>
        /// sourceCRS property
        /// </summary>
		[ComponentElement]
		[XmlElement("sourceCRS")]
        public CRSPropertyType SourceCRS {
            get {
                return sourceCRSField;
            } 
            set {
                sourceCRSField = value;
                NotifyPropertyChanged("SourceCRS");
            }
        }

        private CRSPropertyType sourceCRSField; 

        /// <summary>
        /// targetCRS property
        /// </summary>
		[ComponentElement]
		[XmlElement("targetCRS")]
        public CRSPropertyType TargetCRS {
            get {
                return targetCRSField;
            } 
            set {
                targetCRSField = value;
                NotifyPropertyChanged("TargetCRS");
            }
        }

        private CRSPropertyType targetCRSField; 


    } //here

    /// <summary>
    /// This class represents the domainOfValidity xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the domainOfValidity xsd type.")]
    public partial class DomainOfValidity : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// EX_Extent property
        /// </summary>
		[ComponentElement]
		[XmlElement("EX_Extent", Namespace="http://www.isotc211.org/2005/gmd")]
        public EX_Extent_Type EX_Extent {
            get {
                return EX_ExtentField;
            } 
            set {
                EX_ExtentField = value;
                NotifyPropertyChanged("EX_Extent");
            }
        }

        private EX_Extent_Type EX_ExtentField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the EX_Extent_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_Extent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the EX_Extent_Type xsd type.")]
    public partial class EX_Extent_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("description")]
        public CharacterString_PropertyType Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private CharacterString_PropertyType descriptionField; 

        /// <summary>
        /// geographicElement property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "EX_GeographicExtent_PropertyType")]
		[XmlElement("geographicElement")]
        public List<EX_GeographicExtent_PropertyType> GeographicElement {
            get {
                return geographicElementField;
            } 
            set {
                geographicElementField = value;
                NotifyPropertyChanged("GeographicElement");
            }
        }

         /// <summary>
         /// bool to indicate if GeographicElement has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool GeographicElementSpecified
         {
             get {
             if(geographicElementField!=null)
                 return geographicElementField.Count>0?true:false;
             else return false;
             }
         }
        private List<EX_GeographicExtent_PropertyType> geographicElementField; 

        /// <summary>
        /// temporalElement property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "EX_TemporalExtent_PropertyType")]
		[XmlElement("temporalElement")]
        public List<EX_TemporalExtent_PropertyType> TemporalElement {
            get {
                return temporalElementField;
            } 
            set {
                temporalElementField = value;
                NotifyPropertyChanged("TemporalElement");
            }
        }

         /// <summary>
         /// bool to indicate if TemporalElement has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TemporalElementSpecified
         {
             get {
             if(temporalElementField!=null)
                 return temporalElementField.Count>0?true:false;
             else return false;
             }
         }
        private List<EX_TemporalExtent_PropertyType> temporalElementField; 

        /// <summary>
        /// verticalElement property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "EX_VerticalExtent_PropertyType")]
		[XmlElement("verticalElement")]
        public List<EX_VerticalExtent_PropertyType> VerticalElement {
            get {
                return verticalElementField;
            } 
            set {
                verticalElementField = value;
                NotifyPropertyChanged("VerticalElement");
            }
        }

         /// <summary>
         /// bool to indicate if VerticalElement has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool VerticalElementSpecified
         {
             get {
             if(verticalElementField!=null)
                 return verticalElementField.Count>0?true:false;
             else return false;
             }
         }
        private List<EX_VerticalExtent_PropertyType> verticalElementField; 


    } //here



    /// <summary>
    /// This class represents the AbstractEX_GeographicExtent_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractEX_GeographicExtent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the AbstractEX_GeographicExtent_Type xsd type.")]
    public abstract partial class AbstractEX_GeographicExtent_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// extentTypeCode property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Boolean_PropertyType")]
		[XmlElement("extentTypeCode")]
        public Boolean_PropertyType ExtentTypeCode {
            get {
                return extentTypeCodeField;
            } 
            set {
                extentTypeCodeField = value;
                NotifyPropertyChanged("ExtentTypeCode");
            }
        }

        private Boolean_PropertyType extentTypeCodeField; 


    } //here



    /// <summary>
    /// This class represents the AbstractDQ_Result_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDQ_Result", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the AbstractDQ_Result_Type xsd type.")]
    public abstract partial class AbstractDQ_Result_Type : AbstractObject_Type, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the CI_Series_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Series", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Series_Type xsd type.")]
    public partial class CI_Series_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// name property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("name")]
        public CharacterString_PropertyType Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private CharacterString_PropertyType nameField; 

        /// <summary>
        /// issueIdentification property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("issueIdentification")]
        public CharacterString_PropertyType IssueIdentification {
            get {
                return issueIdentificationField;
            } 
            set {
                issueIdentificationField = value;
                NotifyPropertyChanged("IssueIdentification");
            }
        }

        private CharacterString_PropertyType issueIdentificationField; 

        /// <summary>
        /// page property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("page")]
        public CharacterString_PropertyType Page {
            get {
                return pageField;
            } 
            set {
                pageField = value;
                NotifyPropertyChanged("Page");
            }
        }

        private CharacterString_PropertyType pageField; 


    } //here

    /// <summary>
    /// This class represents the CI_OnlineResource_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_OnlineResource", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_OnlineResource_Type xsd type.")]
    public partial class CI_OnlineResource_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// linkage property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "URL_PropertyType")]
		[XmlElement("linkage")]
        public URL_PropertyType Linkage {
            get {
                return linkageField;
            } 
            set {
                linkageField = value;
                NotifyPropertyChanged("Linkage");
            }
        }

        private URL_PropertyType linkageField; 

        /// <summary>
        /// protocol property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("protocol")]
        public CharacterString_PropertyType Protocol {
            get {
                return protocolField;
            } 
            set {
                protocolField = value;
                NotifyPropertyChanged("Protocol");
            }
        }

        private CharacterString_PropertyType protocolField; 

        /// <summary>
        /// applicationProfile property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("applicationProfile")]
        public CharacterString_PropertyType ApplicationProfile {
            get {
                return applicationProfileField;
            } 
            set {
                applicationProfileField = value;
                NotifyPropertyChanged("ApplicationProfile");
            }
        }

        private CharacterString_PropertyType applicationProfileField; 

        /// <summary>
        /// name property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("name")]
        public CharacterString_PropertyType Name {
            get {
                return nameField;
            } 
            set {
                nameField = value;
                NotifyPropertyChanged("Name");
            }
        }

        private CharacterString_PropertyType nameField; 

        /// <summary>
        /// description property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("description")]
        public CharacterString_PropertyType Description {
            get {
                return descriptionField;
            } 
            set {
                descriptionField = value;
                NotifyPropertyChanged("Description");
            }
        }

        private CharacterString_PropertyType descriptionField; 

        /// <summary>
        /// function property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_OnLineFunctionCode_PropertyType")]
		[XmlElement("function")]
        public CI_OnLineFunctionCode_PropertyType Function {
            get {
                return functionField;
            } 
            set {
                functionField = value;
                NotifyPropertyChanged("Function");
            }
        }

        private CI_OnLineFunctionCode_PropertyType functionField; 


    } //here



    /// <summary>
    /// This class represents the CodeListValue_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gco")]
    [System.Xml.Serialization.XmlRootAttribute("CI_DateTypeCode", Namespace="http://www.isotc211.org/2005/gco", IsNullable=false)]
	[Description("This class represents the CodeListValue_Type xsd type.")]
    public partial class CodeListValue_Type : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the CodeListValue_Type class.
        /// </summary>
        public CodeListValue_Type() {}

        /// <summary>
        /// Initializes a new instance of the CodeListValue_Type class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public CodeListValue_Type(string value)
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
        /// codeList property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("codeList")]
		
        public string CodeList {
            get {
                return codeListField;
            } 
            set {
                codeListField = value;
                NotifyPropertyChanged("CodeList");
            }
        }

        private string codeListField; 

		/// <summary>
        /// codeListValue property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("codeListValue")]
		
        public string CodeListValue {
            get {
                return codeListValueField;
            } 
            set {
                codeListValueField = value;
                NotifyPropertyChanged("CodeListValue");
            }
        }

        private string codeListValueField; 

		/// <summary>
        /// codeSpace property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "anyURI")]
        [XmlAttribute("codeSpace")]
		
        public string CodeSpace {
            get {
                return codeSpaceField;
            } 
            set {
                codeSpaceField = value;
                NotifyPropertyChanged("CodeSpace");
            }
        }

        private string codeSpaceField; 

        /// <summary>
        /// Value property
        /// </summary>
        
        [XmlText]
        public string Value {
            get {
                return ValueField;
            } 
            set {
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

    /// <summary>
    /// This class represents the CI_Address_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Address", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Address_Type xsd type.")]
    public partial class CI_Address_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// deliveryPoint property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("deliveryPoint")]
        public List<CharacterString_PropertyType> DeliveryPoint {
            get {
                return deliveryPointField;
            } 
            set {
                deliveryPointField = value;
                NotifyPropertyChanged("DeliveryPoint");
            }
        }

         /// <summary>
         /// bool to indicate if DeliveryPoint has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DeliveryPointSpecified
         {
             get {
             if(deliveryPointField!=null)
                 return deliveryPointField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> deliveryPointField; 

        /// <summary>
        /// city property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("city")]
        public CharacterString_PropertyType City {
            get {
                return cityField;
            } 
            set {
                cityField = value;
                NotifyPropertyChanged("City");
            }
        }

        private CharacterString_PropertyType cityField; 

        /// <summary>
        /// administrativeArea property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("administrativeArea")]
        public CharacterString_PropertyType AdministrativeArea {
            get {
                return administrativeAreaField;
            } 
            set {
                administrativeAreaField = value;
                NotifyPropertyChanged("AdministrativeArea");
            }
        }

        private CharacterString_PropertyType administrativeAreaField; 

        /// <summary>
        /// postalCode property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("postalCode")]
        public CharacterString_PropertyType PostalCode {
            get {
                return postalCodeField;
            } 
            set {
                postalCodeField = value;
                NotifyPropertyChanged("PostalCode");
            }
        }

        private CharacterString_PropertyType postalCodeField; 

        /// <summary>
        /// country property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("country")]
        public CharacterString_PropertyType Country {
            get {
                return countryField;
            } 
            set {
                countryField = value;
                NotifyPropertyChanged("Country");
            }
        }

        private CharacterString_PropertyType countryField; 

        /// <summary>
        /// electronicMailAddress property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("electronicMailAddress")]
        public List<CharacterString_PropertyType> ElectronicMailAddress {
            get {
                return electronicMailAddressField;
            } 
            set {
                electronicMailAddressField = value;
                NotifyPropertyChanged("ElectronicMailAddress");
            }
        }

         /// <summary>
         /// bool to indicate if ElectronicMailAddress has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ElectronicMailAddressSpecified
         {
             get {
             if(electronicMailAddressField!=null)
                 return electronicMailAddressField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> electronicMailAddressField; 


    } //here

    /// <summary>
    /// This class represents the CI_Telephone_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Telephone", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Telephone_Type xsd type.")]
    public partial class CI_Telephone_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// voice property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("voice")]
        public List<CharacterString_PropertyType> Voice {
            get {
                return voiceField;
            } 
            set {
                voiceField = value;
                NotifyPropertyChanged("Voice");
            }
        }

         /// <summary>
         /// bool to indicate if Voice has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool VoiceSpecified
         {
             get {
             if(voiceField!=null)
                 return voiceField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> voiceField; 

        /// <summary>
        /// facsimile property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("facsimile")]
        public List<CharacterString_PropertyType> Facsimile {
            get {
                return facsimileField;
            } 
            set {
                facsimileField = value;
                NotifyPropertyChanged("Facsimile");
            }
        }

         /// <summary>
         /// bool to indicate if Facsimile has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool FacsimileSpecified
         {
             get {
             if(facsimileField!=null)
                 return facsimileField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> facsimileField; 


    } //here

    /// <summary>
    /// This class represents the CI_Contact_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Contact", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Contact_Type xsd type.")]
    public partial class CI_Contact_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// phone property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Telephone_PropertyType")]
		[XmlElement("phone")]
        public CI_Telephone_PropertyType Phone {
            get {
                return phoneField;
            } 
            set {
                phoneField = value;
                NotifyPropertyChanged("Phone");
            }
        }

        private CI_Telephone_PropertyType phoneField; 

        /// <summary>
        /// address property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Address_PropertyType")]
		[XmlElement("address")]
        public CI_Address_PropertyType Address {
            get {
                return addressField;
            } 
            set {
                addressField = value;
                NotifyPropertyChanged("Address");
            }
        }

        private CI_Address_PropertyType addressField; 

        /// <summary>
        /// onlineResource property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_OnlineResource_PropertyType")]
		[XmlElement("onlineResource")]
        public CI_OnlineResource_PropertyType OnlineResource {
            get {
                return onlineResourceField;
            } 
            set {
                onlineResourceField = value;
                NotifyPropertyChanged("OnlineResource");
            }
        }

        private CI_OnlineResource_PropertyType onlineResourceField; 

        /// <summary>
        /// hoursOfService property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("hoursOfService")]
        public CharacterString_PropertyType HoursOfService {
            get {
                return hoursOfServiceField;
            } 
            set {
                hoursOfServiceField = value;
                NotifyPropertyChanged("HoursOfService");
            }
        }

        private CharacterString_PropertyType hoursOfServiceField; 

        /// <summary>
        /// contactInstructions property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("contactInstructions")]
        public CharacterString_PropertyType ContactInstructions {
            get {
                return contactInstructionsField;
            } 
            set {
                contactInstructionsField = value;
                NotifyPropertyChanged("ContactInstructions");
            }
        }

        private CharacterString_PropertyType contactInstructionsField; 


    } //here



    /// <summary>
    /// This class represents the CI_ResponsibleParty_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_ResponsibleParty", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_ResponsibleParty_Type xsd type.")]
    public partial class CI_ResponsibleParty_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// individualName property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("individualName")]
        public CharacterString_PropertyType IndividualName {
            get {
                return individualNameField;
            } 
            set {
                individualNameField = value;
                NotifyPropertyChanged("IndividualName");
            }
        }

        private CharacterString_PropertyType individualNameField; 

        /// <summary>
        /// organisationName property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("organisationName")]
        public CharacterString_PropertyType OrganisationName {
            get {
                return organisationNameField;
            } 
            set {
                organisationNameField = value;
                NotifyPropertyChanged("OrganisationName");
            }
        }

        private CharacterString_PropertyType organisationNameField; 

        /// <summary>
        /// positionName property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("positionName")]
        public CharacterString_PropertyType PositionName {
            get {
                return positionNameField;
            } 
            set {
                positionNameField = value;
                NotifyPropertyChanged("PositionName");
            }
        }

        private CharacterString_PropertyType positionNameField; 

        /// <summary>
        /// contactInfo property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Contact_PropertyType")]
		[XmlElement("contactInfo")]
        public CI_Contact_PropertyType ContactInfo {
            get {
                return contactInfoField;
            } 
            set {
                contactInfoField = value;
                NotifyPropertyChanged("ContactInfo");
            }
        }

        private CI_Contact_PropertyType contactInfoField; 

        /// <summary>
        /// role property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_RoleCode_PropertyType")]
		[XmlElement("role")]
        public CI_RoleCode_PropertyType Role {
            get {
                return roleField;
            } 
            set {
                roleField = value;
                NotifyPropertyChanged("Role");
            }
        }

        private CI_RoleCode_PropertyType roleField; 


    } //here



    /// <summary>
    /// This class represents the CI_Date_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Date", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Date_Type xsd type.")]
    public partial class CI_Date_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// date property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Date_PropertyType")]
		[XmlElement("date")]
        public Date_PropertyType Date {
            get {
                return dateField;
            } 
            set {
                dateField = value;
                NotifyPropertyChanged("Date");
            }
        }

        private Date_PropertyType dateField; 

        /// <summary>
        /// dateType property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_DateTypeCode_PropertyType")]
		[XmlElement("dateType")]
        public CI_DateTypeCode_PropertyType DateType {
            get {
                return dateTypeField;
            } 
            set {
                dateTypeField = value;
                NotifyPropertyChanged("DateType");
            }
        }

        private CI_DateTypeCode_PropertyType dateTypeField; 


    } //here



    /// <summary>
    /// This class represents the CI_Citation_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("CI_Citation", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the CI_Citation_Type xsd type.")]
    public partial class CI_Citation_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// title property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("title")]
        public CharacterString_PropertyType Title {
            get {
                return titleField;
            } 
            set {
                titleField = value;
                NotifyPropertyChanged("Title");
            }
        }

        private CharacterString_PropertyType titleField; 

        /// <summary>
        /// alternateTitle property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("alternateTitle")]
        public List<CharacterString_PropertyType> AlternateTitle {
            get {
                return alternateTitleField;
            } 
            set {
                alternateTitleField = value;
                NotifyPropertyChanged("AlternateTitle");
            }
        }

         /// <summary>
         /// bool to indicate if AlternateTitle has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool AlternateTitleSpecified
         {
             get {
             if(alternateTitleField!=null)
                 return alternateTitleField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> alternateTitleField; 

        /// <summary>
        /// date property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Date_PropertyType")]
		[XmlElement("date")]
        public List<CI_Date_PropertyType> Date {
            get {
                return dateField;
            } 
            set {
                dateField = value;
                NotifyPropertyChanged("Date");
            }
        }

         /// <summary>
         /// bool to indicate if Date has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DateSpecified
         {
             get {
             if(dateField!=null)
                 return dateField.Count>0?true:false;
             else return false;
             }
         }
        private List<CI_Date_PropertyType> dateField; 

        /// <summary>
        /// edition property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("edition")]
        public CharacterString_PropertyType Edition {
            get {
                return editionField;
            } 
            set {
                editionField = value;
                NotifyPropertyChanged("Edition");
            }
        }

        private CharacterString_PropertyType editionField; 

        /// <summary>
        /// editionDate property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Date_PropertyType")]
		[XmlElement("editionDate")]
        public Date_PropertyType EditionDate {
            get {
                return editionDateField;
            } 
            set {
                editionDateField = value;
                NotifyPropertyChanged("EditionDate");
            }
        }

        private Date_PropertyType editionDateField; 

        /// <summary>
        /// identifier property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "MD_Identifier_PropertyType")]
		[XmlElement("identifier")]
        public List<MD_Identifier_PropertyType> Identifier {
            get {
                return identifierField;
            } 
            set {
                identifierField = value;
                NotifyPropertyChanged("Identifier");
            }
        }

         /// <summary>
         /// bool to indicate if Identifier has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool IdentifierSpecified
         {
             get {
             if(identifierField!=null)
                 return identifierField.Count>0?true:false;
             else return false;
             }
         }
        private List<MD_Identifier_PropertyType> identifierField; 

        /// <summary>
        /// citedResponsibleParty property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_ResponsibleParty_PropertyType")]
		[XmlElement("citedResponsibleParty")]
        public List<CI_ResponsibleParty_PropertyType> CitedResponsibleParty {
            get {
                return citedResponsiblePartyField;
            } 
            set {
                citedResponsiblePartyField = value;
                NotifyPropertyChanged("CitedResponsibleParty");
            }
        }

         /// <summary>
         /// bool to indicate if CitedResponsibleParty has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool CitedResponsiblePartySpecified
         {
             get {
             if(citedResponsiblePartyField!=null)
                 return citedResponsiblePartyField.Count>0?true:false;
             else return false;
             }
         }
        private List<CI_ResponsibleParty_PropertyType> citedResponsiblePartyField; 

        /// <summary>
        /// presentationForm property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_PresentationFormCode_PropertyType")]
		[XmlElement("presentationForm")]
        public List<CI_PresentationFormCode_PropertyType> PresentationForm {
            get {
                return presentationFormField;
            } 
            set {
                presentationFormField = value;
                NotifyPropertyChanged("PresentationForm");
            }
        }

         /// <summary>
         /// bool to indicate if PresentationForm has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PresentationFormSpecified
         {
             get {
             if(presentationFormField!=null)
                 return presentationFormField.Count>0?true:false;
             else return false;
             }
         }
        private List<CI_PresentationFormCode_PropertyType> presentationFormField; 

        /// <summary>
        /// series property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Series_PropertyType")]
		[XmlElement("series")]
        public CI_Series_PropertyType Series {
            get {
                return seriesField;
            } 
            set {
                seriesField = value;
                NotifyPropertyChanged("Series");
            }
        }

        private CI_Series_PropertyType seriesField; 

        /// <summary>
        /// otherCitationDetails property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("otherCitationDetails")]
        public CharacterString_PropertyType OtherCitationDetails {
            get {
                return otherCitationDetailsField;
            } 
            set {
                otherCitationDetailsField = value;
                NotifyPropertyChanged("OtherCitationDetails");
            }
        }

        private CharacterString_PropertyType otherCitationDetailsField; 

        /// <summary>
        /// collectiveTitle property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("collectiveTitle")]
        public CharacterString_PropertyType CollectiveTitle {
            get {
                return collectiveTitleField;
            } 
            set {
                collectiveTitleField = value;
                NotifyPropertyChanged("CollectiveTitle");
            }
        }

        private CharacterString_PropertyType collectiveTitleField; 

        /// <summary>
        /// ISBN property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("ISBN")]
        public CharacterString_PropertyType ISBN {
            get {
                return ISBNField;
            } 
            set {
                ISBNField = value;
                NotifyPropertyChanged("ISBN");
            }
        }

        private CharacterString_PropertyType ISBNField; 

        /// <summary>
        /// ISSN property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("ISSN")]
        public CharacterString_PropertyType ISSN {
            get {
                return ISSNField;
            } 
            set {
                ISSNField = value;
                NotifyPropertyChanged("ISSN");
            }
        }

        private CharacterString_PropertyType ISSNField; 


    } //here



    /// <summary>
    /// This class represents the MD_Identifier_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Identifier", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the MD_Identifier_Type xsd type.")]
    public partial class MD_Identifier_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// authority property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Citation_PropertyType")]
		[XmlElement("authority")]
        public CI_Citation_PropertyType Authority {
            get {
                return authorityField;
            } 
            set {
                authorityField = value;
                NotifyPropertyChanged("Authority");
            }
        }

        private CI_Citation_PropertyType authorityField; 

        /// <summary>
        /// code property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("code")]
        public CharacterString_PropertyType Code {
            get {
                return codeField;
            } 
            set {
                codeField = value;
                NotifyPropertyChanged("Code");
            }
        }

        private CharacterString_PropertyType codeField; 


    } //here



    /// <summary>
    /// This class represents the AbstractDQ_Element_Type xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_PositionalAccuracy_Type))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDQ_Element", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the AbstractDQ_Element_Type xsd type.")]
    public abstract partial class AbstractDQ_Element_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// nameOfMeasure property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("nameOfMeasure")]
        public List<CharacterString_PropertyType> NameOfMeasure {
            get {
                return nameOfMeasureField;
            } 
            set {
                nameOfMeasureField = value;
                NotifyPropertyChanged("NameOfMeasure");
            }
        }

         /// <summary>
         /// bool to indicate if NameOfMeasure has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool NameOfMeasureSpecified
         {
             get {
             if(nameOfMeasureField!=null)
                 return nameOfMeasureField.Count>0?true:false;
             else return false;
             }
         }
        private List<CharacterString_PropertyType> nameOfMeasureField; 

        /// <summary>
        /// measureIdentification property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "MD_Identifier_PropertyType")]
		[XmlElement("measureIdentification")]
        public MD_Identifier_PropertyType MeasureIdentification {
            get {
                return measureIdentificationField;
            } 
            set {
                measureIdentificationField = value;
                NotifyPropertyChanged("MeasureIdentification");
            }
        }

        private MD_Identifier_PropertyType measureIdentificationField; 

        /// <summary>
        /// measureDescription property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("measureDescription")]
        public CharacterString_PropertyType MeasureDescription {
            get {
                return measureDescriptionField;
            } 
            set {
                measureDescriptionField = value;
                NotifyPropertyChanged("MeasureDescription");
            }
        }

        private CharacterString_PropertyType measureDescriptionField; 

        /// <summary>
        /// evaluationMethodType property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DQ_EvaluationMethodTypeCode_PropertyType")]
		[XmlElement("evaluationMethodType")]
        public DQ_EvaluationMethodTypeCode_PropertyType EvaluationMethodType {
            get {
                return evaluationMethodTypeField;
            } 
            set {
                evaluationMethodTypeField = value;
                NotifyPropertyChanged("EvaluationMethodType");
            }
        }

        private DQ_EvaluationMethodTypeCode_PropertyType evaluationMethodTypeField; 

        /// <summary>
        /// evaluationMethodDescription property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CharacterString_PropertyType")]
		[XmlElement("evaluationMethodDescription")]
        public CharacterString_PropertyType EvaluationMethodDescription {
            get {
                return evaluationMethodDescriptionField;
            } 
            set {
                evaluationMethodDescriptionField = value;
                NotifyPropertyChanged("EvaluationMethodDescription");
            }
        }

        private CharacterString_PropertyType evaluationMethodDescriptionField; 

        /// <summary>
        /// evaluationProcedure property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CI_Citation_PropertyType")]
		[XmlElement("evaluationProcedure")]
        public CI_Citation_PropertyType EvaluationProcedure {
            get {
                return evaluationProcedureField;
            } 
            set {
                evaluationProcedureField = value;
                NotifyPropertyChanged("EvaluationProcedure");
            }
        }

        private CI_Citation_PropertyType evaluationProcedureField; 

        /// <summary>
        /// dateTime property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DateTime_PropertyType")]
		[XmlElement("dateTime")]
        public List<DateTime_PropertyType> DateTime {
            get {
                return dateTimeField;
            } 
            set {
                dateTimeField = value;
                NotifyPropertyChanged("DateTime");
            }
        }

         /// <summary>
         /// bool to indicate if DateTime has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DateTimeSpecified
         {
             get {
             if(dateTimeField!=null)
                 return dateTimeField.Count>0?true:false;
             else return false;
             }
         }
        private List<DateTime_PropertyType> dateTimeField; 

        /// <summary>
        /// result property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DQ_Result_PropertyType")]
		[XmlElement("result")]
        public List<DQ_Result_PropertyType> Result {
            get {
                return resultField;
            } 
            set {
                resultField = value;
                NotifyPropertyChanged("Result");
            }
        }

         /// <summary>
         /// bool to indicate if Result has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ResultSpecified
         {
             get {
             if(resultField!=null)
                 return resultField.Count>0?true:false;
             else return false;
             }
         }
        private List<DQ_Result_PropertyType> resultField; 


    } //here



    /// <summary>
    /// This class represents the AbstractDQ_PositionalAccuracy_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDQ_PositionalAccuracy", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the AbstractDQ_PositionalAccuracy_Type xsd type.")]
    public abstract partial class AbstractDQ_PositionalAccuracy_Type : AbstractDQ_Element_Type, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the EX_VerticalExtent_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_VerticalExtent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the EX_VerticalExtent_Type xsd type.")]
    public partial class EX_VerticalExtent_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// minimumValue property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Real_PropertyType")]
		[XmlElement("minimumValue")]
        public Real_PropertyType MinimumValue {
            get {
                return minimumValueField;
            } 
            set {
                minimumValueField = value;
                NotifyPropertyChanged("MinimumValue");
            }
        }

        private Real_PropertyType minimumValueField; 

        /// <summary>
        /// maximumValue property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Real_PropertyType")]
		[XmlElement("maximumValue")]
        public Real_PropertyType MaximumValue {
            get {
                return maximumValueField;
            } 
            set {
                maximumValueField = value;
                NotifyPropertyChanged("MaximumValue");
            }
        }

        private Real_PropertyType maximumValueField; 

        /// <summary>
        /// verticalCRS property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "SC_CRS_PropertyType")]
		[XmlElement("verticalCRS")]
        public SC_CRS_PropertyType VerticalCRS {
            get {
                return verticalCRSField;
            } 
            set {
                verticalCRSField = value;
                NotifyPropertyChanged("VerticalCRS");
            }
        }

        private SC_CRS_PropertyType verticalCRSField; 


    } //here



    /// <summary>
    /// This class represents the AbstractCRSType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralDerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticCRSType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractCRSType xsd type.")]
    public abstract partial class AbstractCRSType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// domainOfValidity property
        /// </summary>
		[RecurringElement]
		[XmlElement("domainOfValidity")]
        public List<DomainOfValidity> DomainOfValidity {
            get {
                return domainOfValidityField;
            } 
            set {
                domainOfValidityField = value;
                NotifyPropertyChanged("DomainOfValidity");
            }
        }

         /// <summary>
         /// bool to indicate if DomainOfValidity has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool DomainOfValiditySpecified
         {
             get {
             if(domainOfValidityField!=null)
                 return domainOfValidityField.Count>0?true:false;
             else return false;
             }
         }
        private List<DomainOfValidity> domainOfValidityField; 

        /// <summary>
        /// scope property
        /// </summary>
		[RecurringElement]
		[XmlElement("scope")]
        public List<string> Scope {
            get {
                return scopeField;
            } 
            set {
                scopeField = value;
                NotifyPropertyChanged("Scope");
            }
        }

         /// <summary>
         /// bool to indicate if Scope has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ScopeSpecified
         {
             get {
             if(scopeField!=null)
                 return scopeField.Count>0?true:false;
             else return false;
             }
         }
        private List<string> scopeField; 


    } //here

    /// <summary>
    /// This class represents the VerticalCRSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalCRSType xsd type.")]
    public partial class VerticalCRSType : AbstractCRSType, INotifyPropertyChanged
    {

        /// <summary>
        /// verticalCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("verticalCS")]
        public VerticalCSPropertyType VerticalCS {
            get {
                return verticalCSField;
            } 
            set {
                verticalCSField = value;
                NotifyPropertyChanged("VerticalCS");
            }
        }

        private VerticalCSPropertyType verticalCSField; 

        /// <summary>
        /// verticalDatum property
        /// </summary>
		[ComponentElement]
		[XmlElement("verticalDatum")]
        public VerticalDatumPropertyType VerticalDatum {
            get {
                return verticalDatumField;
            } 
            set {
                verticalDatumField = value;
                NotifyPropertyChanged("VerticalDatum");
            }
        }

        private VerticalDatumPropertyType verticalDatumField; 


    } //here

    /// <summary>
    /// This class represents the VerticalCSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("verticalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalCSPropertyType xsd type.")]
    public partial class VerticalCSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// VerticalCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("VerticalCS")]
        public VerticalCSType VerticalCS {
            get {
                return VerticalCSField;
            } 
            set {
                VerticalCSField = value;
                NotifyPropertyChanged("VerticalCS");
            }
        }

        private VerticalCSType VerticalCSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the VerticalCSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalCSType xsd type.")]
    public partial class VerticalCSType : AbstractCoordinateSystemType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the VerticalDatumPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("verticalDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalDatumPropertyType xsd type.")]
    public partial class VerticalDatumPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// VerticalDatum property
        /// </summary>
		[ComponentElement]
		[XmlElement("VerticalDatum")]
        public VerticalDatumType VerticalDatum {
            get {
                return VerticalDatumField;
            } 
            set {
                VerticalDatumField = value;
                NotifyPropertyChanged("VerticalDatum");
            }
        }

        private VerticalDatumType VerticalDatumField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the VerticalDatumType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the VerticalDatumType xsd type.")]
    public partial class VerticalDatumType : AbstractDatumType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the AbstractDatumType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractDatumType xsd type.")]
    public abstract partial class AbstractDatumType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// domainOfValidity property
        /// </summary>
		[ComponentElement]
		[XmlElement("domainOfValidity")]
        public DomainOfValidity DomainOfValidity {
            get {
                return domainOfValidityField;
            } 
            set {
                domainOfValidityField = value;
                NotifyPropertyChanged("DomainOfValidity");
            }
        }

        private DomainOfValidity domainOfValidityField; 

        /// <summary>
        /// scope property
        /// </summary>
		[RecurringElement]
		[XmlElement("scope")]
        public List<string> Scope {
            get {
                return scopeField;
            } 
            set {
                scopeField = value;
                NotifyPropertyChanged("Scope");
            }
        }

         /// <summary>
         /// bool to indicate if Scope has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ScopeSpecified
         {
             get {
             if(scopeField!=null)
                 return scopeField.Count>0?true:false;
             else return false;
             }
         }
        private List<string> scopeField; 

        /// <summary>
        /// anchorDefinition property
        /// </summary>
		[ComponentElement]
		[XmlElement("anchorDefinition")]
        public CodeType AnchorDefinition {
            get {
                return anchorDefinitionField;
            } 
            set {
                anchorDefinitionField = value;
                NotifyPropertyChanged("AnchorDefinition");
            }
        }

        private CodeType anchorDefinitionField; 

        /// <summary>
        /// realizationEpoch property
        /// </summary>
		
		[XmlElement("realizationEpoch", DataType="date")]
        public DateTime? RealizationEpoch {
            get {
                return realizationEpochField;
            } 
            set {
                realizationEpochField = value;
                 this.RealizationEpochSpecified = true;
                NotifyPropertyChanged("RealizationEpoch");
            }
        }

        private DateTime? realizationEpochField; 

        /// <summary>
        /// realizationEpochSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool RealizationEpochSpecified {
            get {
                return realizationEpochSpecifiedField;
            } 
            set {
                realizationEpochSpecifiedField = value;
                NotifyPropertyChanged("RealizationEpochSpecified");
            }
        }

        private bool realizationEpochSpecifiedField; 


    } //here

    /// <summary>
    /// This class represents the GeodeticDatumType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("GeodeticDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeodeticDatumType xsd type.")]
    public partial class GeodeticDatumType : AbstractDatumType, INotifyPropertyChanged
    {

        /// <summary>
        /// primeMeridian property
        /// </summary>
		[ComponentElement]
		[XmlElement("primeMeridian")]
        public PrimeMeridianPropertyType PrimeMeridian {
            get {
                return primeMeridianField;
            } 
            set {
                primeMeridianField = value;
                NotifyPropertyChanged("PrimeMeridian");
            }
        }

        private PrimeMeridianPropertyType primeMeridianField; 

        /// <summary>
        /// ellipsoid property
        /// </summary>
		[ComponentElement]
		[XmlElement("ellipsoid")]
        public EllipsoidPropertyType Ellipsoid {
            get {
                return ellipsoidField;
            } 
            set {
                ellipsoidField = value;
                NotifyPropertyChanged("Ellipsoid");
            }
        }

        private EllipsoidPropertyType ellipsoidField; 


    } //here

    /// <summary>
    /// This class represents the PrimeMeridianPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("primeMeridian", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the PrimeMeridianPropertyType xsd type.")]
    public partial class PrimeMeridianPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// PrimeMeridian property
        /// </summary>
		[ComponentElement]
		[XmlElement("PrimeMeridian")]
        public PrimeMeridianType PrimeMeridian {
            get {
                return PrimeMeridianField;
            } 
            set {
                PrimeMeridianField = value;
                NotifyPropertyChanged("PrimeMeridian");
            }
        }

        private PrimeMeridianType PrimeMeridianField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the PrimeMeridianType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("PrimeMeridian", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the PrimeMeridianType xsd type.")]
    public partial class PrimeMeridianType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// greenwichLongitude property
        /// </summary>
		
		[XmlElement("greenwichLongitude")]
        public AngleType GreenwichLongitude {
            get {
                return greenwichLongitudeField;
            } 
            set {
                greenwichLongitudeField = value;
                NotifyPropertyChanged("GreenwichLongitude");
            }
        }

        private AngleType greenwichLongitudeField; 


    } //here

    /// <summary>
    /// This class represents the AngleType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("greenwichLongitude", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AngleType xsd type.")]
    public partial class AngleType : MeasureType, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the AngleType class.
        /// </summary>
        public AngleType() {}

        /// <summary>
        /// Initializes a new instance of the AngleType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public AngleType(double value)
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

    /// <summary>
    /// This class represents the MeasureType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("semiMajorAxis", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the MeasureType xsd type.")]
    public partial class MeasureType : Object, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MeasureType class.
        /// </summary>
        public MeasureType() {}

        /// <summary>
        /// Initializes a new instance of the MeasureType class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public MeasureType(double value)
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
        
        [XmlText]
        public double Value {
            get {
                return ValueField;
            } 
            set {
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



    /// <summary>
    /// This class represents the EllipsoidPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ellipsoid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the EllipsoidPropertyType xsd type.")]
    public partial class EllipsoidPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// Ellipsoid property
        /// </summary>
		[ComponentElement]
		[XmlElement("Ellipsoid")]
        public EllipsoidType Ellipsoid {
            get {
                return EllipsoidField;
            } 
            set {
                EllipsoidField = value;
                NotifyPropertyChanged("Ellipsoid");
            }
        }

        private EllipsoidType EllipsoidField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the EllipsoidType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Ellipsoid", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the EllipsoidType xsd type.")]
    public partial class EllipsoidType : IdentifiedObjectType, INotifyPropertyChanged
    {

        /// <summary>
        /// semiMajorAxis property
        /// </summary>
		
		[XmlElement("semiMajorAxis")]
        public MeasureType SemiMajorAxis {
            get {
                return semiMajorAxisField;
            } 
            set {
                semiMajorAxisField = value;
                NotifyPropertyChanged("SemiMajorAxis");
            }
        }

        private MeasureType semiMajorAxisField; 

        /// <summary>
        /// secondDefiningParameter property
        /// </summary>
		[ComponentElement]
		[XmlElement("secondDefiningParameter")]
        public SecondDefParameter SecondDefPara {
            get {
                return secondDefiningParameterField;
            } 
            set {
                secondDefiningParameterField = value;
                NotifyPropertyChanged("SecondDefPara");
            }
        }

        private SecondDefParameter secondDefiningParameterField; 


    } //here

    /// <summary>
    /// This class represents the secondDefiningParameter xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the secondDefiningParameter xsd type.")]
    public partial class SecondDefParameter : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// SecondDefiningParameter property
        /// </summary>
		[ComponentElement]
		[XmlElement("SecondDefiningParameter")]
        public SecondDefiningParameter SecondDefPara {
            get {
                return SecondDefiningParameterField;
            } 
            set {
                SecondDefiningParameterField = value;
                NotifyPropertyChanged("SecondDefPara");
            }
        }

        private SecondDefiningParameter SecondDefiningParameterField; 


        
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

    /// <summary>
    /// This class represents the SecondDefiningParameter xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the SecondDefiningParameter xsd type.")]
    public partial class SecondDefiningParameter : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// inverseFlattening property
        /// </summary>
        [XmlElement("inverseFlattening")]
        public MeasureType InverseFlattening {
            get {
                return inverseFlatteningField;
            } 
            set {
                inverseFlatteningField = value;
                InverseFlatteningSpecified = (value!=null);
                NotifyPropertyChanged("InverseFlattening");
            }
        }

        private MeasureType inverseFlatteningField; 
        private bool inverseFlatteningSpecified = false; 

        /// <summary>
        /// bool to indicate if InverseFlattening has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool InverseFlatteningSpecified
        {
            get {
                return inverseFlatteningSpecified;
            }
            set {
                inverseFlatteningSpecified= value;
            }
        }

        /// <summary>
        /// isSphere property
        /// </summary>
        [XmlElement("isSphere")]
        public bool? IsSphere {
            get {
                return isSphereField;
            } 
            set {
                isSphereField = value;
                IsSphereSpecified = (value!=null);
                NotifyPropertyChanged("IsSphere");
            }
        }

        private bool? isSphereField; 
        private bool isSphereSpecified = false; 

        /// <summary>
        /// bool to indicate if IsSphere has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool IsSphereSpecified
        {
            get {
                return isSphereSpecified;
            }
            set {
                isSphereSpecified= value;
            }
        }

        /// <summary>
        /// semiMinorAxis property
        /// </summary>
        [XmlElement("semiMinorAxis")]
        public LengthType SemiMinorAxis {
            get {
                return semiMinorAxisField;
            } 
            set {
                semiMinorAxisField = value;
                SemiMinorAxisSpecified = (value!=null);
                NotifyPropertyChanged("SemiMinorAxis");
            }
        }

        private LengthType semiMinorAxisField; 
        private bool semiMinorAxisSpecified = false; 

        /// <summary>
        /// bool to indicate if SemiMinorAxis has been set. Used for serialization.
        /// </summary>
        [XmlIgnore]
        public bool SemiMinorAxisSpecified
        {
            get {
                return semiMinorAxisSpecified;
            }
            set {
                semiMinorAxisSpecified= value;
            }
        }



        
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

    /// <summary>
    /// This class represents the AbstractGeneralDerivedCRSType xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGeneralDerivedCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractGeneralDerivedCRSType xsd type.")]
    public abstract partial class AbstractGeneralDerivedCRSType : AbstractCRSType, INotifyPropertyChanged
    {

        /// <summary>
        /// conversion property
        /// </summary>
		[ComponentElement]
		[XmlElement("conversion")]
        public GeneralConversionPropertyType Conversion {
            get {
                return conversionField;
            } 
            set {
                conversionField = value;
                NotifyPropertyChanged("Conversion");
            }
        }

        private GeneralConversionPropertyType conversionField; 


    } //here

    /// <summary>
    /// This class represents the GeneralConversionPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("conversion", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeneralConversionPropertyType xsd type.")]
    public partial class GeneralConversionPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractGeneralConversion property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractGeneralConversion")]
        public AbstractGeneralConversionType AbstractGeneralConversion {
            get {
                return AbstractGeneralConversionField;
            } 
            set {
                AbstractGeneralConversionField = value;
                NotifyPropertyChanged("AbstractGeneralConversion");
            }
        }

        private AbstractGeneralConversionType AbstractGeneralConversionField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the AbstractGeneralConversionType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGeneralConversion", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the AbstractGeneralConversionType xsd type.")]
    public abstract partial class AbstractGeneralConversionType : AbstractCoordinateOperationType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the ProjectedCRSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ProjectedCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the ProjectedCRSType xsd type.")]
    public partial class ProjectedCRSType : AbstractGeneralDerivedCRSType, INotifyPropertyChanged
    {

        /// <summary>
        /// Item property
        /// </summary>
		[ComponentElement]
		[XmlElement("baseGeodeticCRS")]
        public GeodeticCRSPropertyType Item {
            get {
                return ItemField;
            } 
            set {
                ItemField = value;
                NotifyPropertyChanged("Item");
            }
        }

        private GeodeticCRSPropertyType ItemField; 

        /// <summary>
        /// cartesianCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("cartesianCS")]
        public CartesianCSPropertyType CartesianCS {
            get {
                return cartesianCSField;
            } 
            set {
                cartesianCSField = value;
                NotifyPropertyChanged("CartesianCS");
            }
        }

        private CartesianCSPropertyType cartesianCSField; 


    } //here

    /// <summary>
    /// This class represents the GeodeticCRSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("baseGeodeticCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeodeticCRSPropertyType xsd type.")]
    public partial class GeodeticCRSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// GeodeticCRS property
        /// </summary>
		[ComponentElement]
		[XmlElement("GeodeticCRS")]
        public GeodeticCRSType GeodeticCRS {
            get {
                return GeodeticCRSField;
            } 
            set {
                GeodeticCRSField = value;
                NotifyPropertyChanged("GeodeticCRS");
            }
        }

        private GeodeticCRSType GeodeticCRSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the EX_TemporalExtent_Type xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("EX_TemporalExtent", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
	[Description("This class represents the EX_TemporalExtent_Type xsd type.")]
    public partial class EX_TemporalExtent_Type : AbstractObject_Type, INotifyPropertyChanged
    {

        /// <summary>
        /// extent property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "TM_Primitive_PropertyType")]
		[XmlElement("extent")]
        public TM_Primitive_PropertyType Extent {
            get {
                return extentField;
            } 
            set {
                extentField = value;
                NotifyPropertyChanged("Extent");
            }
        }

        private TM_Primitive_PropertyType extentField; 


    } //here



    /// <summary>
    /// This class represents the coordinateOperationAccuracy xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the coordinateOperationAccuracy xsd type.")]
    public partial class CoordinateOperationAccuracy : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractDQ_PositionalAccuracy property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractDQ_PositionalAccuracy", Namespace="http://www.isotc211.org/2005/gmd")]
        public AbstractDQ_PositionalAccuracy_Type AbstractDQ_PositionalAccuracy {
            get {
                return AbstractDQ_PositionalAccuracyField;
            } 
            set {
                AbstractDQ_PositionalAccuracyField = value;
                NotifyPropertyChanged("AbstractDQ_PositionalAccuracy");
            }
        }

        private AbstractDQ_PositionalAccuracy_Type AbstractDQ_PositionalAccuracyField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the CRSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("sourceCRS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the CRSPropertyType xsd type.")]
    public partial class CRSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// AbstractCRS property
        /// </summary>
		[ComponentElement]
		[XmlElement("AbstractCRS")]
        public AbstractCRSType AbstractCRS {
            get {
                return AbstractCRSField;
            } 
            set {
                AbstractCRSField = value;
                NotifyPropertyChanged("AbstractCRS");
            }
        }

        private AbstractCRSType AbstractCRSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the SphericalCSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("SphericalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the SphericalCSType xsd type.")]
    public partial class SphericalCSType : AbstractCoordinateSystemType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the EllipsoidalCSType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("EllipsoidalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the EllipsoidalCSType xsd type.")]
    public partial class EllipsoidalCSType : AbstractCoordinateSystemType, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the EllipsoidalCSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ellipsoidalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the EllipsoidalCSPropertyType xsd type.")]
    public partial class EllipsoidalCSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// EllipsoidalCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("EllipsoidalCS")]
        public EllipsoidalCSType EllipsoidalCS {
            get {
                return EllipsoidalCSField;
            } 
            set {
                EllipsoidalCSField = value;
                NotifyPropertyChanged("EllipsoidalCS");
            }
        }

        private EllipsoidalCSType EllipsoidalCSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the SphericalCSPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("sphericalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the SphericalCSPropertyType xsd type.")]
    public partial class SphericalCSPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// SphericalCS property
        /// </summary>
		[ComponentElement]
		[XmlElement("SphericalCS")]
        public SphericalCSType SphericalCS {
            get {
                return SphericalCSField;
            } 
            set {
                SphericalCSField = value;
                NotifyPropertyChanged("SphericalCS");
            }
        }

        private SphericalCSType SphericalCSField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

    /// <summary>
    /// This class represents the GeodeticDatumPropertyType xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("geodeticDatum", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
	[Description("This class represents the GeodeticDatumPropertyType xsd type.")]
    public partial class GeodeticDatumPropertyType : Object, INotifyPropertyChanged
    {

        /// <summary>
        /// GeodeticDatum property
        /// </summary>
		[ComponentElement]
		[XmlElement("GeodeticDatum")]
        public GeodeticDatumType GeodeticDatum {
            get {
                return GeodeticDatumField;
            } 
            set {
                GeodeticDatumField = value;
                NotifyPropertyChanged("GeodeticDatum");
            }
        }

        private GeodeticDatumType GeodeticDatumField; 

		/// <summary>
        /// nilReason property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "NilReasonType")]
        [XmlAttribute("nilReason")]
		
        public string NilReason {
            get {
                return nilReasonField;
            } 
            set {
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

   



    /// <summary>
    /// This class represents the MdDatum xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the MdDatum xsd type.")]
    public partial class MdDatum : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Location property
        /// </summary>
		[Required]
        [Description("The location of the MD reference point relative to a local CRS.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "SinglePointGeometry")]
		[XmlElement("Location")]
        public SinglePointGeometry Location {
            get {
                return LocationField;
            } 
            set {
                LocationField = value;
                NotifyPropertyChanged("Location");
            }
        }

        private SinglePointGeometry LocationField; 

        /// <summary>
        /// MdReference property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "WellboreDatumReference")]
		[XmlElement("MdReference")]
        public WellboreDatumReference? MDReference {
            get {
                return MdReferenceField;
            } 
            set {
                MdReferenceField = value;
                 this.MDReferenceSpecified = true;
                NotifyPropertyChanged("MDReference");
            }
        }

        
        private bool MDReferenceSpecifiedField = false;
        
        /// <summary>
        /// MDReferenceSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool MDReferenceSpecified {
            get {
                return MDReferenceSpecifiedField;
            } 
            set {
                MDReferenceSpecifiedField = value;
                NotifyPropertyChanged("MDReferenceSpecified");
            }
        }
        
        private WellboreDatumReference? MdReferenceField; 


    } //here

    /// <summary>
    /// This class represents the PropertySet xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the PropertySet xsd type.")]
    public partial class PropertySet : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// TimeSetKind property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "TimeSetKind")]
		[XmlElement("TimeSetKind")]
        public TimeSetKind? TimeSetKind {
            get {
                return TimeSetKindField;
            } 
            set {
                TimeSetKindField = value;
                 this.TimeSetKindSpecified = true;
                NotifyPropertyChanged("TimeSetKind");
            }
        }

        
        private bool TimeSetKindSpecifiedField = false;
        
        /// <summary>
        /// TimeSetKindSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool TimeSetKindSpecified {
            get {
                return TimeSetKindSpecifiedField;
            } 
            set {
                TimeSetKindSpecifiedField = value;
                NotifyPropertyChanged("TimeSetKindSpecified");
            }
        }
        
        private TimeSetKind? TimeSetKindField; 

        /// <summary>
        /// If true, indicates that the collection contains only property values associated with a single property kind.
        /// </summary>
		[Required]
        [Description("If true, indicates that the collection contains only property values associated with a single property kind.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("HasSinglePropertyKind")]
        public bool? HasSinglePropertyKind {
            get {
                return HasSinglePropertyKindField;
            } 
            set {
                HasSinglePropertyKindField = value;
                NotifyPropertyChanged("HasSinglePropertyKind");
            }
        }

        private bool? HasSinglePropertyKindField; 

        /// <summary>
        /// If true, indicates that the collection contains properties with defined realization indices.
        /// </summary>
		[Required]
        [Description("If true, indicates that the collection contains properties with defined realization indices.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("HasMultipleRealizations")]
        public bool? HasMultipleRealizations {
            get {
                return HasMultipleRealizationsField;
            } 
            set {
                HasMultipleRealizationsField = value;
                NotifyPropertyChanged("HasMultipleRealizations");
            }
        }

        private bool? HasMultipleRealizationsField; 

        /// <summary>
        /// A pointer to the parent property group of this property group.
        /// </summary>
		[Description("A pointer to the parent property group of this property group.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("ParentSet")]
        public List<DataObjectReference> ParentSet {
            get {
                return ParentSetField;
            } 
            set {
                ParentSetField = value;
                NotifyPropertyChanged("ParentSet");
            }
        }

         /// <summary>
         /// bool to indicate if ParentSet has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ParentSetSpecified
         {
             get {
             if(ParentSetField!=null)
                 return ParentSetField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> ParentSetField; 

        /// <summary>
        /// Defines the properties which are contained into a property set
        /// </summary>
		[Description("Defines the properties which are contained into a property set")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Properties")]
        public List<DataObjectReference> Properties {
            get {
                return PropertiesField;
            } 
            set {
                PropertiesField = value;
                NotifyPropertyChanged("Properties");
            }
        }

         /// <summary>
         /// bool to indicate if Properties has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PropertiesSpecified
         {
             get {
             if(PropertiesField!=null)
                 return PropertiesField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> PropertiesField; 


    } //here



    /// <summary>
    /// This class represents the StringTableLookup xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the StringTableLookup xsd type.")]
    public partial class StringTableLookup : AbstractPropertyLookup, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the StringTableLookup class.
        /// </summary>
        public StringTableLookup() {}

        /// <summary>
        /// Initializes a new instance of the StringTableLookup class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public StringTableLookup(List<StringLookup> value)
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
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "StringLookup")]
		[XmlElement("Value")]
        public List<StringLookup> Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

         /// <summary>
         /// bool to indicate if Value has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ValueSpecified
         {
             get {
             if(ValueField!=null)
                 return ValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<StringLookup> ValueField; 


    } //here

    /// <summary>
    /// This class represents the DoubleTableLookup xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the DoubleTableLookup xsd type.")]
    public partial class DoubleTableLookup : AbstractPropertyLookup, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the DoubleTableLookup class.
        /// </summary>
        public DoubleTableLookup() {}

        /// <summary>
        /// Initializes a new instance of the DoubleTableLookup class.
        /// </summary>
        /// <param name="value">Initial value</param>
        public DoubleTableLookup(List<DoubleLookup> value)
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
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DoubleLookup")]
		[XmlElement("Value")]
        public List<DoubleLookup> Value {
            get {
                return ValueField;
            } 
            set {
                ValueField = value;
                NotifyPropertyChanged("Value");
            }
        }

         /// <summary>
         /// bool to indicate if Value has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ValueSpecified
         {
             get {
             if(ValueField!=null)
                 return ValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<DoubleLookup> ValueField; 


    } //here

   

    /// <summary>
    /// This class represents the PropertyKind xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/commonv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/commonv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the PropertyKind xsd type.")]
    public partial class PropertyKind : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// IsAbstract property
        /// </summary>
		[Required]
        [Description("This boolean indicates whether the PropertyKind should be used as a real property or not.  If the Is Abstract flag is set, then this entry should be used only as the parent of a real property. For example, the PropertyKind of \"force per length\" shouldn't be used directly, as it is really just a description of some units of measure. This entry should only be used as the parent of the real physical property \"surface tension\".")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("IsAbstract")]
        public bool? IsAbstract {
            get {
                return IsAbstractField;
            } 
            set {
                IsAbstractField = value;
                NotifyPropertyChanged("IsAbstract");
            }
        }

        private bool? IsAbstractField; 

        /// <summary>
        /// DeprecationDate property
        /// </summary>
		[Description("Date at which this property dictionary entry must no longer be used. Files generated before this date would have used this entry so it is left here for reference.   A null value means the property kind is still valid.")]
        [EnergisticsDataTypeAttribute(DataType = "TimeStamp")]
		[XmlElement("DeprecationDate")]
        public Timestamp? DeprecationDate {
            get {
                return DeprecationDateField;
            } 
            set {
                DeprecationDateField = value;
                 this.DeprecationDateSpecified = true;
                NotifyPropertyChanged("DeprecationDate");
            }
        }

        
        private bool DeprecationDateSpecifiedField = false;
        
        /// <summary>
        /// DeprecationDateSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool DeprecationDateSpecified {
            get {
                return DeprecationDateSpecifiedField;
            } 
            set {
                DeprecationDateSpecifiedField = value;
                NotifyPropertyChanged("DeprecationDateSpecified");
            }
        }
        
        private Timestamp? DeprecationDateField; 

        /// <summary>
        /// QuantityClass property
        /// </summary>
		[Required]
        [Description("A reference to the name of a quantity class in the Energistics Unit of Measure Dictionary. If there is no match in the Energistics Unit of Measure Dictionary, then this attribute is purely for human information.")]
        [EnergisticsDataTypeAttribute(DataType = "QuantityClassKindExt")]
		[XmlElement("QuantityClass")]
        public ExtensibleEnum<QuantityClassKind>? QuantityClass {
            get {
                return QuantityClassField;
            } 
            set {
                QuantityClassField = value;
                NotifyPropertyChanged("QuantityClass");
            }
        }

        private ExtensibleEnum<QuantityClassKind>? QuantityClassField; 

        /// <summary>
        /// Parent property
        /// </summary>
		[Description("Indicates the parent of this property kind. BUSINESS RULE : Only the top root abstract property kind has not to define a parent property kind.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Parent")]
        public DataObjectReference Parent {
            get {
                return ParentField;
            } 
            set {
                ParentField = value;
                NotifyPropertyChanged("Parent");
            }
        }

        private DataObjectReference ParentField; 


    } //here

    /// <summary>
    /// This class represents the PointsProperty xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the PointsProperty xsd type.")]
    public partial class PointsProperty : AbstractProperty, INotifyPropertyChanged
    {

        /// <summary>
        /// PatchOfPoints property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "PatchOfPoints")]
		[XmlElement("PatchOfPoints")]
        public List<PatchOfPoints> PatchOfPoints {
            get {
                return PatchOfPointsField;
            } 
            set {
                PatchOfPointsField = value;
                NotifyPropertyChanged("PatchOfPoints");
            }
        }

         /// <summary>
         /// bool to indicate if PatchOfPoints has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PatchOfPointsSpecified
         {
             get {
             if(PatchOfPointsField!=null)
                 return PatchOfPointsField.Count>0?true:false;
             else return false;
             }
         }
        private List<PatchOfPoints> PatchOfPointsField; 


    } //here


    /// <summary>
    /// This class represents the DiscreteProperty xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the DiscreteProperty xsd type.")]
    public partial class DiscreteProperty : AbstractValuesProperty, INotifyPropertyChanged
    {

        /// <summary>
        /// The minimum of the associated property values. BUSINESS RULE: There can only be one value per number of elements.
        /// </summary>
		[Description("The minimum of the associated property values.  BUSINESS RULE: There can only be one value per number of elements.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "long")]
		[XmlElement("MinimumValue")]
        public List<long> MinimumValue {
            get {
                return MinimumValueField;
            } 
            set {
                MinimumValueField = value;
                NotifyPropertyChanged("MinimumValue");
            }
        }

         /// <summary>
         /// bool to indicate if MinimumValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool MinimumValueSpecified
         {
             get {
             if(MinimumValueField!=null)
                 return MinimumValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<long> MinimumValueField; 

        /// <summary>
        /// The maximum of the associated property values. BUSINESS RULE: There can only be one value per number of elements.
        /// </summary>
		[Description("The maximum of the associated property values.  BUSINESS RULE: There can only be one value per number of elements.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "long")]
		[XmlElement("MaximumValue")]
        public List<long> MaximumValue {
            get {
                return MaximumValueField;
            } 
            set {
                MaximumValueField = value;
                NotifyPropertyChanged("MaximumValue");
            }
        }

         /// <summary>
         /// bool to indicate if MaximumValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool MaximumValueSpecified
         {
             get {
             if(MaximumValueField!=null)
                 return MaximumValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<long> MaximumValueField; 


    } //here

    /// <summary>
    /// This class represents the ContinuousProperty xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the ContinuousProperty xsd type.")]
    public partial class ContinuousProperty : AbstractValuesProperty, INotifyPropertyChanged
    {

        /// <summary>
        /// MinimumValue property
        /// </summary>
		[Description("The minimum of the associated property values.  BUSINESS RULE: There can be only one value per number of elements.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("MinimumValue")]
        public List<double> MinimumValue {
            get {
                return MinimumValueField;
            } 
            set {
                MinimumValueField = value;
                NotifyPropertyChanged("MinimumValue");
            }
        }

         /// <summary>
         /// bool to indicate if MinimumValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool MinimumValueSpecified
         {
             get {
             if(MinimumValueField!=null)
                 return MinimumValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<double> MinimumValueField; 

        /// <summary>
        /// MaximumValue property
        /// </summary>
		[Description("The maximum of the associated property values.  BUSINESS RULE: There can be only one value per number of elements.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("MaximumValue")]
        public List<double> MaximumValue {
            get {
                return MaximumValueField;
            } 
            set {
                MaximumValueField = value;
                NotifyPropertyChanged("MaximumValue");
            }
        }

         /// <summary>
         /// bool to indicate if MaximumValue has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool MaximumValueSpecified
         {
             get {
             if(MaximumValueField!=null)
                 return MaximumValueField.Count>0?true:false;
             else return false;
             }
         }
        private List<double> MaximumValueField; 

        /// <summary>
        /// Uom property
        /// </summary>
		[Required]
        [Description("Unit of measure for the property.")]
        [EnergisticsDataTypeAttribute(DataType = "UnitOfMeasureExt")]
		[XmlElement("Uom")]
        public ExtensibleEnum<UnitOfMeasure>? Uom {
            get {
                return UomField;
            } 
            set {
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
        public DataObjectReference CustomUnitDictionary {
            get {
                return CustomUnitDictionaryField;
            } 
            set {
                CustomUnitDictionaryField = value;
                NotifyPropertyChanged("CustomUnitDictionary");
            }
        }

        private DataObjectReference CustomUnitDictionaryField; 


    } //here

    /// <summary>
    /// This class represents the CommentProperty xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the CommentProperty xsd type.")]
    public partial class CommentProperty : AbstractValuesProperty, INotifyPropertyChanged
    {

        /// <summary>
        /// Identify the language (e.g., US English or French) of the string. It is recommended that language names conform to ISO 639.
        /// </summary>
		[StringLength(64)]
        [Description("Identify the language (e.g., US English or French) of the string. It is recommended that language names conform to ISO 639.")]
        [EnergisticsDataTypeAttribute(DataType = "String64")]
		[XmlElement("Language")]
        public string Language {
            get {
                return LanguageField;
            } 
            set {
                LanguageField = value;
                NotifyPropertyChanged("Language");
            }
        }

        private string LanguageField; 


    } //here

    /// <summary>
    /// This class represents the CategoricalProperty xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the CategoricalProperty xsd type.")]
    public partial class CategoricalProperty : AbstractValuesProperty, INotifyPropertyChanged
    {

        /// <summary>
        /// Lookup property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Lookup")]
        public DataObjectReference Lookup {
            get {
                return LookupField;
            } 
            set {
                LookupField = value;
                NotifyPropertyChanged("Lookup");
            }
        }

        private DataObjectReference LookupField; 


    } //here

    /// <summary>
    /// This class represents the BooleanProperty xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the BooleanProperty xsd type.")]
    public partial class BooleanProperty : AbstractValuesProperty, INotifyPropertyChanged
    {


    } //here



    /// <summary>
    /// This class represents the LocalTime3dCrs xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the LocalTime3dCrs xsd type.")]
    public partial class LocalTime3dCrs : AbstractLocal3dCrs, INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the unit of measure of the third (time) coordinates, for the geometries that refer to it.
        /// </summary>
		[Required]
        [Description("Defines the unit of measure of the third (time) coordinates, for the geometries that refer to it.")]
        [EnergisticsDataTypeAttribute(DataType = "TimeUomExt")]
		[XmlElement("TimeUom")]
        public ExtensibleEnum<TimeUom>? TimeUom {
            get {
                return TimeUomField;
            } 
            set {
                TimeUomField = value;
                NotifyPropertyChanged("TimeUom");
            }
        }

        private ExtensibleEnum<TimeUom>? TimeUomField; 

        /// <summary>
        /// Reference to a custom units dictionary, if one is used. 
        /// </summary>
		[Description("Reference to a custom units dictionary, if one is used.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("CustomUnitDictionary")]
        public DataObjectReference CustomUnitDictionary {
            get {
                return CustomUnitDictionaryField;
            } 
            set {
                CustomUnitDictionaryField = value;
                NotifyPropertyChanged("CustomUnitDictionary");
            }
        }

        private DataObjectReference CustomUnitDictionaryField; 


    } //here

    /// <summary>
    /// This class represents the LocalDepth3dCrs xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the LocalDepth3dCrs xsd type.")]
    public partial class LocalDepth3dCrs : AbstractLocal3dCrs, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the LocalGridSet xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the LocalGridSet xsd type.")]
    public partial class LocalGridSet : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Activation property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Activation")]
		[XmlElement("Activation")]
        public Activation Activation {
            get {
                return ActivationField;
            } 
            set {
                ActivationField = value;
                NotifyPropertyChanged("Activation");
            }
        }

        private Activation ActivationField; 

        /// <summary>
        /// ChildGrid property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("ChildGrid")]
        public List<DataObjectReference> ChildGrid {
            get {
                return ChildGridField;
            } 
            set {
                ChildGridField = value;
                NotifyPropertyChanged("ChildGrid");
            }
        }

         /// <summary>
         /// bool to indicate if ChildGrid has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ChildGridSpecified
         {
             get {
             if(ChildGridField!=null)
                 return ChildGridField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> ChildGridField; 


    } //here

    /// <summary>
    /// This class represents the RepresentationIdentitySet xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the RepresentationIdentitySet xsd type.")]
    public partial class RepresentationIdentitySet : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// RepresentationIdentity property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "RepresentationIdentity")]
		[XmlElement("RepresentationIdentity")]
        public List<RepresentationIdentity> RepresentationIdentity {
            get {
                return RepresentationIdentityField;
            } 
            set {
                RepresentationIdentityField = value;
                NotifyPropertyChanged("RepresentationIdentity");
            }
        }

         /// <summary>
         /// bool to indicate if RepresentationIdentity has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool RepresentationIdentitySpecified
         {
             get {
             if(RepresentationIdentityField!=null)
                 return RepresentationIdentityField.Count>0?true:false;
             else return false;
             }
         }
        private List<RepresentationIdentity> RepresentationIdentityField; 


    } //here



    /// <summary>
    /// This class represents the StreamlinesRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the StreamlinesRepresentation xsd type.")]
    public partial class StreamlinesRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// LineCount property
        /// </summary>
		[Required]
        [Description("Number of streamlines.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("LineCount")]
        public long? LineCount {
            get {
                return LineCountField;
            } 
            set {
                LineCountField = value;
                NotifyPropertyChanged("LineCount");
            }
        }

        private long? LineCountField; 

        /// <summary>
        /// StreamlineWellbores property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "StreamlineWellbores")]
		[XmlElement("StreamlineWellbores")]
        public StreamlineWellbores StreamlineWellbores {
            get {
                return StreamlineWellboresField;
            } 
            set {
                StreamlineWellboresField = value;
                NotifyPropertyChanged("StreamlineWellbores");
            }
        }

        private StreamlineWellbores StreamlineWellboresField; 

        /// <summary>
        /// Geometry property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "PolylineSetPatch")]
		[XmlElement("Geometry")]
        public PolylineSetPatch Geometry {
            get {
                return GeometryField;
            } 
            set {
                GeometryField = value;
                NotifyPropertyChanged("Geometry");
            }
        }

        private PolylineSetPatch GeometryField; 


    } //here

    /// <summary>
    /// This class represents the WellboreTrajectoryRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the WellboreTrajectoryRepresentation xsd type.")]
    public partial class WellboreTrajectoryRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// StartMd property
        /// </summary>
		[Required]
        [Description("Specifies the measured depth  for the start of the wellbore trajectory.  Range may often be from kickoff to TD, but this is not required.   BUSINESS RULE: Start MD is always less than the Finish MD.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("StartMd")]
        public double? StartMD {
            get {
                return StartMdField;
            } 
            set {
                StartMdField = value;
                NotifyPropertyChanged("StartMD");
            }
        }

        private double? StartMdField; 

        /// <summary>
        /// FinishMd property
        /// </summary>
		[Required]
        [Description("Specifies the ending measured depth of the range for the wellbore trajectory.  Range may often be from kickoff to TD, but this is not required.   BUSINESS RULE: Start MD is always less than the Finish MD.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("FinishMd")]
        public double? FinishMD {
            get {
                return FinishMdField;
            } 
            set {
                FinishMdField = value;
                NotifyPropertyChanged("FinishMD");
            }
        }

        private double? FinishMdField; 

        /// <summary>
        /// MdUom property
        /// </summary>
		[Required]
        [Description("Units of measure of the measured depths along this trajectory.")]
        [EnergisticsDataTypeAttribute(DataType = "LengthUomExt")]
		[XmlElement("MdUom")]
        public ExtensibleEnum<LengthUom>? MDUom {
            get {
                return MdUomField;
            } 
            set {
                MdUomField = value;
                NotifyPropertyChanged("MDUom");
            }
        }

        private ExtensibleEnum<LengthUom>? MdUomField; 

        /// <summary>
        /// CustomUnitDictionary property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("CustomUnitDictionary")]
        public DataObjectReference CustomUnitDictionary {
            get {
                return CustomUnitDictionaryField;
            } 
            set {
                CustomUnitDictionaryField = value;
                NotifyPropertyChanged("CustomUnitDictionary");
            }
        }

        private DataObjectReference CustomUnitDictionaryField; 

        /// <summary>
        /// MdDomain property
        /// </summary>
		[Description("Indicates if the MD is either in “driller” domain or “logger” domain.")]
        [EnergisticsDataTypeAttribute(DataType = "MdDomain")]
		[XmlElement("MdDomain")]
        public MdDomain? MDDomain {
            get {
                return MdDomainField;
            } 
            set {
                MdDomainField = value;
                 this.MDDomainSpecified = true;
                NotifyPropertyChanged("MDDomain");
            }
        }

        private MdDomain? MdDomainField; 

        /// <summary>
        /// MdDomainSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool MDDomainSpecified {
            get {
                return MdDomainSpecifiedField;
            } 
            set {
                MdDomainSpecifiedField = value;
                NotifyPropertyChanged("MDDomainSpecified");
            }
        }

        private bool MdDomainSpecifiedField; 

        /// <summary>
        /// WitsmlTrajectoryReference property
        /// </summary>
		[Description("Pointer to the WITSML trajectory that is contained in the referenced wellbore. (For information about WITSML well and wellbore references, see the definition for RESQML technical feature, WellboreFeature).")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("WitsmlTrajectoryReference")]
        public DataObjectReference WitsmlTrajectoryReference {
            get {
                return WitsmlTrajectoryReferenceField;
            } 
            set {
                WitsmlTrajectoryReferenceField = value;
                NotifyPropertyChanged("WitsmlTrajectoryReference");
            }
        }

        private DataObjectReference WitsmlTrajectoryReferenceField; 

        /// <summary>
        /// ParentIntersection property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "WellboreTrajectoryParentIntersection")]
		[XmlElement("ParentIntersection")]
        public WellboreTrajectoryParentIntersection ParentIntersection {
            get {
                return ParentIntersectionField;
            } 
            set {
                ParentIntersectionField = value;
                NotifyPropertyChanged("ParentIntersection");
            }
        }

        private WellboreTrajectoryParentIntersection ParentIntersectionField; 

        /// <summary>
        /// MdDatum property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("MdDatum")]
        public DataObjectReference MDDatum {
            get {
                return MdDatumField;
            } 
            set {
                MdDatumField = value;
                NotifyPropertyChanged("MDDatum");
            }
        }

        private DataObjectReference MdDatumField; 

        /// <summary>
        /// DeviationSurvey property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("DeviationSurvey")]
        public DataObjectReference DeviationSurvey {
            get {
                return DeviationSurveyField;
            } 
            set {
                DeviationSurveyField = value;
                NotifyPropertyChanged("DeviationSurvey");
            }
        }

        private DataObjectReference DeviationSurveyField; 

        /// <summary>
        /// Explicit geometry is not required for vertical wells
        /// </summary>
		[Description("Explicit geometry is not required for vertical wells")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "AbstractParametricLineGeometry")]
		[XmlElement("Geometry")]
        public AbstractParametricLineGeometry Geometry {
            get {
                return GeometryField;
            } 
            set {
                GeometryField = value;
                NotifyPropertyChanged("Geometry");
            }
        }

        private AbstractParametricLineGeometry GeometryField; 


    } //here

    /// <summary>
    /// This class represents the WellboreFrameRepresentation xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WellboreMarkerFrameRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeismicWellboreFrameRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BlockedWellboreRepresentation))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the WellboreFrameRepresentation xsd type.")]
    public partial class WellboreFrameRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// NodeCount property
        /// </summary>
		[Required]
        [Description("Number of nodes. Must be positive.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("NodeCount")]
        public long? NodeCount {
            get {
                return NodeCountField;
            } 
            set {
                NodeCountField = value;
                NotifyPropertyChanged("NodeCount");
            }
        }

        private long? NodeCountField; 

        /// <summary>
        /// NodeMd property
        /// </summary>
		[Required]
        [Description("MD values for each node. BUSINESS RULE: MD values and UOM must be consistent with the trajectory representation.")]
        [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
		[XmlElement("NodeMd")]
        public AbstractFloatingPointArray NodeMD {
            get {
                return NodeMdField;
            } 
            set {
                NodeMdField = value;
                NotifyPropertyChanged("NodeMD");
            }
        }

        private AbstractFloatingPointArray NodeMdField; 

        /// <summary>
        /// WitsmlLogReference property
        /// </summary>
		[Description("The reference to the equivalent WITSML well log.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("WitsmlLogReference")]
        public DataObjectReference WitsmlLogReference {
            get {
                return WitsmlLogReferenceField;
            } 
            set {
                WitsmlLogReferenceField = value;
                NotifyPropertyChanged("WitsmlLogReference");
            }
        }

        private DataObjectReference WitsmlLogReferenceField; 

        /// <summary>
        /// Trajectory property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Trajectory")]
        public DataObjectReference Trajectory {
            get {
                return TrajectoryField;
            } 
            set {
                TrajectoryField = value;
                NotifyPropertyChanged("Trajectory");
            }
        }

        private DataObjectReference TrajectoryField; 

        /// <summary>
        /// IntervalStratigraphiUnits property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "IntervalStratigraphicUnits")]
		[XmlElement("IntervalStratigraphiUnits")]
        public List<IntervalStratigraphicUnits> IntervalStratigraphiUnits {
            get {
                return IntervalStratigraphiUnitsField;
            } 
            set {
                IntervalStratigraphiUnitsField = value;
                NotifyPropertyChanged("IntervalStratigraphiUnits");
            }
        }

         /// <summary>
         /// bool to indicate if IntervalStratigraphiUnits has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool IntervalStratigraphiUnitsSpecified
         {
             get {
             if(IntervalStratigraphiUnitsField!=null)
                 return IntervalStratigraphiUnitsField.Count>0?true:false;
             else return false;
             }
         }
        private List<IntervalStratigraphicUnits> IntervalStratigraphiUnitsField; 

        /// <summary>
        /// CellFluidPhaseUnits property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CellFluidPhaseUnits")]
		[XmlElement("CellFluidPhaseUnits")]
        public CellFluidPhaseUnits CellFluidPhaseUnits {
            get {
                return CellFluidPhaseUnitsField;
            } 
            set {
                CellFluidPhaseUnitsField = value;
                NotifyPropertyChanged("CellFluidPhaseUnits");
            }
        }

        private CellFluidPhaseUnits CellFluidPhaseUnitsField; 


    } //here

    /// <summary>
    /// This class represents the WellboreMarkerFrameRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the WellboreMarkerFrameRepresentation xsd type.")]
    public partial class WellboreMarkerFrameRepresentation : WellboreFrameRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// WellboreMarker property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "WellboreMarker")]
		[XmlElement("WellboreMarker")]
        public List<WellboreMarker> WellboreMarker {
            get {
                return WellboreMarkerField;
            } 
            set {
                WellboreMarkerField = value;
                NotifyPropertyChanged("WellboreMarker");
            }
        }

         /// <summary>
         /// bool to indicate if WellboreMarker has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool WellboreMarkerSpecified
         {
             get {
             if(WellboreMarkerField!=null)
                 return WellboreMarkerField.Count>0?true:false;
             else return false;
             }
         }
        private List<WellboreMarker> WellboreMarkerField; 


    } //here

    /// <summary>
    /// This class represents the SeismicWellboreFrameRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the SeismicWellboreFrameRepresentation xsd type.")]
    public partial class SeismicWellboreFrameRepresentation : WellboreFrameRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// NodeTimeValues property
        /// </summary>
		[Required]
        [Description("BUSINESS RULE: Count must be  equal to the inherited NodeCount.  The direction of the supporting axis is given by the LocalTime3dCrs itself. It is necessary to get this information to know what means positive or negative values.  The values are given with respect to the SeismicReferenceDatum.  The UOM is the one specified in the LocalTime3dCrs.")]
        [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
		[XmlElement("NodeTimeValues")]
        public AbstractFloatingPointArray NodeTimeValues {
            get {
                return NodeTimeValuesField;
            } 
            set {
                NodeTimeValuesField = value;
                NotifyPropertyChanged("NodeTimeValues");
            }
        }

        private AbstractFloatingPointArray NodeTimeValuesField; 

        /// <summary>
        /// SeismicReferenceDatum property
        /// </summary>
		[Required]
        [Description("This is the Z value where the seismic time is equal to zero for this survey wellbore frame.  The direction of the supporting axis is given by the LocalTime3dCrs of the associated wellbore trajectory. It is necessary to get the information to know what means a positive or a negative value.  The value is given with respect to the ZOffset of the LocalDepth3dCrs of the associated wellbore trajectory.   The UOM is the one specified in the LocalDepth3dCrs of the associated wellbore trajectory.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("SeismicReferenceDatum")]
        public double? SeismicReferenceDatum {
            get {
                return SeismicReferenceDatumField;
            } 
            set {
                SeismicReferenceDatumField = value;
                NotifyPropertyChanged("SeismicReferenceDatum");
            }
        }

        private double? SeismicReferenceDatumField; 

        /// <summary>
        /// WeatheringVelocity property
        /// </summary>
		[Required]
        [Description("The UOM is composed by: UOM of the LocalDepth3dCrs of the associated wellbore frame trajectory / UOM of the associated LocalTime3dCrs  Sometimes also called seismic velocity replacement.")]
        [EnergisticsDataTypeAttribute(DataType = "double")]
		[XmlElement("WeatheringVelocity")]
        public double? WeatheringVelocity {
            get {
                return WeatheringVelocityField;
            } 
            set {
                WeatheringVelocityField = value;
                NotifyPropertyChanged("WeatheringVelocity");
            }
        }

        private double? WeatheringVelocityField; 

        /// <summary>
        /// TvdInformation property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "TvdInformation")]
		[XmlElement("TvdInformation")]
        public TvdInformation TvdInformation {
            get {
                return TvdInformationField;
            } 
            set {
                TvdInformationField = value;
                NotifyPropertyChanged("TvdInformation");
            }
        }

        private TvdInformation TvdInformationField; 

        /// <summary>
        /// CorrectionInformation property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "CorrectionInformation")]
		[XmlElement("CorrectionInformation")]
        public CorrectionInformation CorrectionInformation {
            get {
                return CorrectionInformationField;
            } 
            set {
                CorrectionInformationField = value;
                NotifyPropertyChanged("CorrectionInformation");
            }
        }

        private CorrectionInformation CorrectionInformationField; 

        /// <summary>
        /// LocalTime3dCrs property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("LocalTime3dCrs")]
        public DataObjectReference LocalTime3dCrs {
            get {
                return LocalTime3dCrsField;
            } 
            set {
                LocalTime3dCrsField = value;
                NotifyPropertyChanged("LocalTime3dCrs");
            }
        }

        private DataObjectReference LocalTime3dCrsField; 


    } //here

    /// <summary>
    /// This class represents the BlockedWellboreRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the BlockedWellboreRepresentation xsd type.")]
    public partial class BlockedWellboreRepresentation : WellboreFrameRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// IntervalGridCells property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "IntervalGridCells")]
		[XmlElement("IntervalGridCells")]
        public IntervalGridCells IntervalGridCells {
            get {
                return IntervalGridCellsField;
            } 
            set {
                IntervalGridCellsField = value;
                NotifyPropertyChanged("IntervalGridCells");
            }
        }

        private IntervalGridCells IntervalGridCellsField; 


    } //here

    /// <summary>
    /// This class represents the DeviationSurveyRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the DeviationSurveyRepresentation xsd type.")]
    public partial class DeviationSurveyRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// AngleUom property
        /// </summary>
		[Required]
        [Description("Defines the units of measure for the azimuth and inclination.")]
        [EnergisticsDataTypeAttribute(DataType = "PlaneAngleUomExt")]
		[XmlElement("AngleUom")]
        public ExtensibleEnum<PlaneAngleUom>? AngleUom {
            get {
                return AngleUomField;
            } 
            set {
                AngleUomField = value;
                NotifyPropertyChanged("AngleUom");
            }
        }

        private ExtensibleEnum<PlaneAngleUom>? AngleUomField; 

        /// <summary>
        /// AngleUomCustomDict property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("AngleUomCustomDict")]
        public DataObjectReference AngleUomCustomDict {
            get {
                return AngleUomCustomDictField;
            } 
            set {
                AngleUomCustomDictField = value;
                NotifyPropertyChanged("AngleUomCustomDict");
            }
        }

        private DataObjectReference AngleUomCustomDictField; 

        /// <summary>
        /// Azimuths property
        /// </summary>
		[Required]
        [Description("An array of azimuth angles, one for each survey station. The rotation is relative to the projected CRS north with a positive value indicating a clockwise rotation as seen from above.  If the local CRS--whether in time or depth--is rotated relative to the projected CRS, then the azimuths remain relative to the projected CRS, not the local CRS.  Note that the projection’s north is not the same as true north or magnetic north. A good definition of the different kinds of “north” can be found in the OGP Surveying & Positioning Guidance Note 1 http://www.ogp.org.uk/pubs/373-01.pdf (the \"True, Grid and Magnetic North bearings\" paragraph).  BUSINESS RULE: Array length equals station count.")]
        [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
		[XmlElement("Azimuths")]
        public AbstractFloatingPointArray Azimuths {
            get {
                return AzimuthsField;
            } 
            set {
                AzimuthsField = value;
                NotifyPropertyChanged("Azimuths");
            }
        }

        private AbstractFloatingPointArray AzimuthsField; 

        /// <summary>
        /// FirstStationLocation property
        /// </summary>
		[Required]
        [Description("XYZ location of the first station of the deviation survey.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "SinglePointGeometry")]
		[XmlElement("FirstStationLocation")]
        public SinglePointGeometry FirstStationLocation {
            get {
                return FirstStationLocationField;
            } 
            set {
                FirstStationLocationField = value;
                NotifyPropertyChanged("FirstStationLocation");
            }
        }

        private SinglePointGeometry FirstStationLocationField; 

        /// <summary>
        /// Inclinations property
        /// </summary>
		[Required]
        [Description("Dip (or inclination) angle for each station.  BUSINESS RULE: Array length equals station count.")]
        [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
		[XmlElement("Inclinations")]
        public AbstractFloatingPointArray Inclinations {
            get {
                return InclinationsField;
            } 
            set {
                InclinationsField = value;
                NotifyPropertyChanged("Inclinations");
            }
        }

        private AbstractFloatingPointArray InclinationsField; 

        /// <summary>
        /// IsFinal property
        /// </summary>
		[Required]
        [Description("Used to indicate that this is a final version of the deviation survey, as distinct from the interim interpretations.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("IsFinal")]
        public bool? IsFinal {
            get {
                return IsFinalField;
            } 
            set {
                IsFinalField = value;
                NotifyPropertyChanged("IsFinal");
            }
        }

        private bool? IsFinalField; 

        /// <summary>
        /// Mds property
        /// </summary>
		[Required]
        [Description("MD values for the position of the stations.  BUSINESS RULE: Array length equals station count.")]
        [EnergisticsDataTypeAttribute(DataType = "AbstractFloatingPointArray")]
		[XmlElement("Mds")]
        public AbstractFloatingPointArray Mds {
            get {
                return MdsField;
            } 
            set {
                MdsField = value;
                NotifyPropertyChanged("Mds");
            }
        }

        private AbstractFloatingPointArray MdsField; 

        /// <summary>
        /// MdUom property
        /// </summary>
		[Required]
        [Description("Units of measure of the measured depths along this deviation survey.")]
        [EnergisticsDataTypeAttribute(DataType = "LengthUomExt")]
		[XmlElement("MdUom")]
        public ExtensibleEnum<LengthUom>? MDUom {
            get {
                return MdUomField;
            } 
            set {
                MdUomField = value;
                NotifyPropertyChanged("MDUom");
            }
        }

        private ExtensibleEnum<LengthUom>? MdUomField; 

        /// <summary>
        /// MdUomCustomDict property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("MdUomCustomDict")]
        public DataObjectReference MDUomCustomDict {
            get {
                return MdUomCustomDictField;
            } 
            set {
                MdUomCustomDictField = value;
                NotifyPropertyChanged("MDUomCustomDict");
            }
        }

        private DataObjectReference MdUomCustomDictField; 

        /// <summary>
        /// StationCount property
        /// </summary>
		[Required]
        [Description("Number of stations.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("StationCount")]
        public long? StationCount {
            get {
                return StationCountField;
            } 
            set {
                StationCountField = value;
                NotifyPropertyChanged("StationCount");
            }
        }

        private long? StationCountField; 

        /// <summary>
        /// WitsmlDeviationSurveyReference property
        /// </summary>
		[Description("A reference to an existing WITSML deviation survey.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("WitsmlDeviationSurveyReference")]
        public DataObjectReference WitsmlDeviationSurveyReference {
            get {
                return WitsmlDeviationSurveyReferenceField;
            } 
            set {
                WitsmlDeviationSurveyReferenceField = value;
                NotifyPropertyChanged("WitsmlDeviationSurveyReference");
            }
        }

        private DataObjectReference WitsmlDeviationSurveyReferenceField; 

        /// <summary>
        /// MdDatum property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("MdDatum")]
        public DataObjectReference MDDatum {
            get {
                return MdDatumField;
            } 
            set {
                MdDatumField = value;
                NotifyPropertyChanged("MDDatum");
            }
        }

        private DataObjectReference MdDatumField; 


    } //here

    /// <summary>
    /// This class represents the PolylineRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the PolylineRepresentation xsd type.")]
    public partial class PolylineRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// LineRole property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "LineRole")]
		[XmlElement("LineRole")]
        public LineRole? LineRole {
            get {
                return LineRoleField;
            } 
            set {
                LineRoleField = value;
                 this.LineRoleSpecified = true;
                NotifyPropertyChanged("LineRole");
            }
        }

        private LineRole? LineRoleField; 

        /// <summary>
        /// LineRoleSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool LineRoleSpecified {
            get {
                return LineRoleSpecifiedField;
            } 
            set {
                LineRoleSpecifiedField = value;
                NotifyPropertyChanged("LineRoleSpecified");
            }
        }

        private bool LineRoleSpecifiedField; 

        /// <summary>
        /// IsClosed property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("IsClosed")]
        public bool? IsClosed {
            get {
                return IsClosedField;
            } 
            set {
                IsClosedField = value;
                NotifyPropertyChanged("IsClosed");
            }
        }

        private bool? IsClosedField; 

        /// <summary>
        /// NodePatch property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "NodePatch")]
		[XmlElement("NodePatch")]
        public NodePatch NodePatch {
            get {
                return NodePatchField;
            } 
            set {
                NodePatchField = value;
                NotifyPropertyChanged("NodePatch");
            }
        }

        private NodePatch NodePatchField; 


    } //here

    /// <summary>
    /// This class represents the PointSetRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the PointSetRepresentation xsd type.")]
    public partial class PointSetRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// NodePatch property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "NodePatch")]
		[XmlElement("NodePatch")]
        public List<NodePatch> NodePatch {
            get {
                return NodePatchField;
            } 
            set {
                NodePatchField = value;
                NotifyPropertyChanged("NodePatch");
            }
        }

         /// <summary>
         /// bool to indicate if NodePatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool NodePatchSpecified
         {
             get {
             if(NodePatchField!=null)
                 return NodePatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<NodePatch> NodePatchField; 


    } //here



    /// <summary>
    /// This class represents the PlaneSetRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the PlaneSetRepresentation xsd type.")]
    public partial class PlaneSetRepresentation : AbstractSurfaceRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// Planes property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "AbstractPlaneGeometry")]
		[XmlElement("Planes")]
        public List<AbstractPlaneGeometry> Planes {
            get {
                return PlanesField;
            } 
            set {
                PlanesField = value;
                NotifyPropertyChanged("Planes");
            }
        }

         /// <summary>
         /// bool to indicate if Planes has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PlanesSpecified
         {
             get {
             if(PlanesField!=null)
                 return PlanesField.Count>0?true:false;
             else return false;
             }
         }
        private List<AbstractPlaneGeometry> PlanesField; 


    } //here

    /// <summary>
    /// This class represents the TriangulatedSetRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the TriangulatedSetRepresentation xsd type.")]
    public partial class TriangulatedSetRepresentation : AbstractSurfaceRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// TrianglePatch property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "TrianglePatch")]
		[XmlElement("TrianglePatch")]
        public List<TrianglePatch> TrianglePatch {
            get {
                return TrianglePatchField;
            } 
            set {
                TrianglePatchField = value;
                NotifyPropertyChanged("TrianglePatch");
            }
        }

         /// <summary>
         /// bool to indicate if TrianglePatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TrianglePatchSpecified
         {
             get {
             if(TrianglePatchField!=null)
                 return TrianglePatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<TrianglePatch> TrianglePatchField; 


    } //here

    /// <summary>
    /// This class represents the Grid2dSetRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the Grid2dSetRepresentation xsd type.")]
    public partial class Grid2dSetRepresentation : AbstractSurfaceRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// Grid2dPatch property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "Grid2dPatch")]
		[XmlElement("Grid2dPatch")]
        public List<Grid2dPatch> Grid2dPatch {
            get {
                return Grid2dPatchField;
            } 
            set {
                Grid2dPatchField = value;
                NotifyPropertyChanged("Grid2dPatch");
            }
        }

         /// <summary>
         /// bool to indicate if Grid2dPatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool Grid2dPatchSpecified
         {
             get {
             if(Grid2dPatchField!=null)
                 return Grid2dPatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<Grid2dPatch> Grid2dPatchField; 


    } //here

    /// <summary>
    /// This class represents the Grid2dRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the Grid2dRepresentation xsd type.")]
    public partial class Grid2dRepresentation : AbstractSurfaceRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// Grid2dPatch property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "Grid2dPatch")]
		[XmlElement("Grid2dPatch")]
        public Grid2dPatch Grid2dPatch {
            get {
                return Grid2dPatchField;
            } 
            set {
                Grid2dPatchField = value;
                NotifyPropertyChanged("Grid2dPatch");
            }
        }

        private Grid2dPatch Grid2dPatchField; 


    } //here

    /// <summary>
    /// This class represents the Seismic2dPostStackRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the Seismic2dPostStackRepresentation xsd type.")]
    public partial class Seismic2dPostStackRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// SeismicLineSubSampling property
        /// </summary>
		[Required]
        [Description("This array must be one dimension and count must be the node count in the associated seismic line i.e., polylineRepresentation.  The index is based on array indexing, not on index labeling of traces.  The values of the integer lattice array are the increments between 2 consecutive subsampled nodes.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "IntegerLatticeArray")]
		[XmlElement("SeismicLineSubSampling")]
        public IntegerLatticeArray SeismicLineSubSampling {
            get {
                return SeismicLineSubSamplingField;
            } 
            set {
                SeismicLineSubSamplingField = value;
                NotifyPropertyChanged("SeismicLineSubSampling");
            }
        }

        private IntegerLatticeArray SeismicLineSubSamplingField; 

        /// <summary>
        /// TraceSampling property
        /// </summary>
		[Required]
        [Description("Defines the sampling in the vertical dimension of the representation.  This array must be one dimension.  The values are given with respect to the associated local CRS.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "FloatingPointLatticeArray")]
		[XmlElement("TraceSampling")]
        public FloatingPointLatticeArray TraceSampling {
            get {
                return TraceSamplingField;
            } 
            set {
                TraceSamplingField = value;
                NotifyPropertyChanged("TraceSampling");
            }
        }

        private FloatingPointLatticeArray TraceSamplingField; 

        /// <summary>
        /// SeismicLineRepresentation property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("SeismicLineRepresentation")]
        public DataObjectReference SeismicLineRepresentation {
            get {
                return SeismicLineRepresentationField;
            } 
            set {
                SeismicLineRepresentationField = value;
                NotifyPropertyChanged("SeismicLineRepresentation");
            }
        }

        private DataObjectReference SeismicLineRepresentationField; 

        /// <summary>
        /// LocalCrs property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("LocalCrs")]
        public DataObjectReference LocalCrs {
            get {
                return LocalCrsField;
            } 
            set {
                LocalCrsField = value;
                NotifyPropertyChanged("LocalCrs");
            }
        }

        private DataObjectReference LocalCrsField; 


    } //here

    /// <summary>
    /// This class represents the GridConnectionSetRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the GridConnectionSetRepresentation xsd type.")]
    public partial class GridConnectionSetRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// Count property
        /// </summary>
		[Required]
        [Description("count of connections. Must be positive.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("Count")]
        public long? Count {
            get {
                return CountField;
            } 
            set {
                CountField = value;
                NotifyPropertyChanged("Count");
            }
        }

        private long? CountField; 

        /// <summary>
        /// CellIndexPairs property
        /// </summary>
		[Required]
        [Description("2 x #Connections array of cell indices for (Cell1,Cell2) for each connection.")]
        [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
		[XmlElement("CellIndexPairs")]
        public AbstractIntegerArray CellIndexPairs {
            get {
                return CellIndexPairsField;
            } 
            set {
                CellIndexPairsField = value;
                NotifyPropertyChanged("CellIndexPairs");
            }
        }

        private AbstractIntegerArray CellIndexPairsField; 

        /// <summary>
        /// GridIndexPairs property
        /// </summary>
		[Description("2 x #Connections array of grid indices for (Cell1,Cell2) for each connection. The grid indices are obtained from the grid index pairs.  If only a single grid is referenced from the grid index, then this array need not be used.  BUSINESS RULE: If more than one grid index pair is referenced, then this array should appear.")]
        [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
		[XmlElement("GridIndexPairs")]
        public AbstractIntegerArray GridIndexPairs {
            get {
                return GridIndexPairsField;
            } 
            set {
                GridIndexPairsField = value;
                NotifyPropertyChanged("GridIndexPairs");
            }
        }

        private AbstractIntegerArray GridIndexPairsField; 

        /// <summary>
        /// LocalFacePerCellIndexPairs property
        /// </summary>
		[Description("Optional 2 x #Connections array of local face-per-cell indices for (Cell1,Cell2) for each connection. Local face-per-cell indices are used because global face indices need not have been defined.  If no face-per-cell definition occurs as part of the grid representation, e.g., for a block-centered grid, then this array need not appear.")]
        [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
		[XmlElement("LocalFacePerCellIndexPairs")]
        public AbstractIntegerArray LocalFacePerCellIndexPairs {
            get {
                return LocalFacePerCellIndexPairsField;
            } 
            set {
                LocalFacePerCellIndexPairsField = value;
                NotifyPropertyChanged("LocalFacePerCellIndexPairs");
            }
        }

        private AbstractIntegerArray LocalFacePerCellIndexPairsField; 

        /// <summary>
        /// ConnectionInterpretations property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "ConnectionInterpretations")]
		[XmlElement("ConnectionInterpretations")]
        public ConnectionInterpretations ConnectionInterpretations {
            get {
                return ConnectionInterpretationsField;
            } 
            set {
                ConnectionInterpretationsField = value;
                NotifyPropertyChanged("ConnectionInterpretations");
            }
        }

        private ConnectionInterpretations ConnectionInterpretationsField; 

        /// <summary>
        /// Grid property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Grid")]
        public List<DataObjectReference> Grid {
            get {
                return GridField;
            } 
            set {
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
             get {
             if(GridField!=null)
                 return GridField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> GridField; 


    } //here



    /// <summary>
    /// This class represents the Seismic3dPostStackRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the Seismic3dPostStackRepresentation xsd type.")]
    public partial class Seismic3dPostStackRepresentation : AbstractGridRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// SeismicLatticeSubSampling property
        /// </summary>
		[Required]
        [Description("This array must be two dimensions: - Fastest Axis is inline. - Slowest Axis is crossline.  The index is based on array indexing, not on index labeling of inlines/crosslines.  The values of the integer lattice array are the increments between 2 consecutive subsampled nodes.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "IntegerLatticeArray")]
		[XmlElement("SeismicLatticeSubSampling")]
        public IntegerLatticeArray SeismicLatticeSubSampling {
            get {
                return SeismicLatticeSubSamplingField;
            } 
            set {
                SeismicLatticeSubSamplingField = value;
                NotifyPropertyChanged("SeismicLatticeSubSampling");
            }
        }

        private IntegerLatticeArray SeismicLatticeSubSamplingField; 

        /// <summary>
        /// TraceSampling property
        /// </summary>
		[Required]
        [Description("Defines the sampling in the vertical dimension of the representation.  This array must be one dimension.  The values are given with respect to the associated Local Crs.")]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "FloatingPointLatticeArray")]
		[XmlElement("TraceSampling")]
        public FloatingPointLatticeArray TraceSampling {
            get {
                return TraceSamplingField;
            } 
            set {
                TraceSamplingField = value;
                NotifyPropertyChanged("TraceSampling");
            }
        }

        private FloatingPointLatticeArray TraceSamplingField; 

        /// <summary>
        /// SeismicLatticeRepresentation property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("SeismicLatticeRepresentation")]
        public DataObjectReference SeismicLatticeRepresentation {
            get {
                return SeismicLatticeRepresentationField;
            } 
            set {
                SeismicLatticeRepresentationField = value;
                NotifyPropertyChanged("SeismicLatticeRepresentation");
            }
        }

        private DataObjectReference SeismicLatticeRepresentationField; 

        /// <summary>
        /// LocalCrs property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("LocalCrs")]
        public DataObjectReference LocalCrs {
            get {
                return LocalCrsField;
            } 
            set {
                LocalCrsField = value;
                NotifyPropertyChanged("LocalCrs");
            }
        }

        private DataObjectReference LocalCrsField; 


    } //here

    /// <summary>
    /// This class represents the UnstructuredGridRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the UnstructuredGridRepresentation xsd type.")]
    public partial class UnstructuredGridRepresentation : AbstractGridRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// CellCount property
        /// </summary>
		[Required]
        [Description("Number of cells in the grid. Must be positive.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("CellCount")]
        public long? CellCount {
            get {
                return CellCountField;
            } 
            set {
                CellCountField = value;
                NotifyPropertyChanged("CellCount");
            }
        }

        private long? CellCountField; 

        /// <summary>
        /// Geometry property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "UnstructuredGridGeometry")]
		[XmlElement("Geometry")]
        public UnstructuredGridGeometry Geometry {
            get {
                return GeometryField;
            } 
            set {
                GeometryField = value;
                NotifyPropertyChanged("Geometry");
            }
        }

        private UnstructuredGridGeometry GeometryField; 

        /// <summary>
        /// OriginalCellIndex property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "AlternateCellIndex")]
		[XmlElement("OriginalCellIndex")]
        public AlternateCellIndex OriginalCellIndex {
            get {
                return OriginalCellIndexField;
            } 
            set {
                OriginalCellIndexField = value;
                NotifyPropertyChanged("OriginalCellIndex");
            }
        }

        private AlternateCellIndex OriginalCellIndexField; 


    } //here

    /// <summary>
    /// This class represents the GpGridRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the GpGridRepresentation xsd type.")]
    public partial class GpGridRepresentation : AbstractGridRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// UnstructuredGpGridPatch property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "UnstructuredGpGridPatch")]
		[XmlElement("UnstructuredGpGridPatch")]
        public List<UnstructuredGpGridPatch> UnstructuredGpGridPatch {
            get {
                return UnstructuredGpGridPatchField;
            } 
            set {
                UnstructuredGpGridPatchField = value;
                NotifyPropertyChanged("UnstructuredGpGridPatch");
            }
        }

         /// <summary>
         /// bool to indicate if UnstructuredGpGridPatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool UnstructuredGpGridPatchSpecified
         {
             get {
             if(UnstructuredGpGridPatchField!=null)
                 return UnstructuredGpGridPatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<UnstructuredGpGridPatch> UnstructuredGpGridPatchField; 

        /// <summary>
        /// ColumnLayerGpGrid property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "ColumnLayerGpGrid")]
		[XmlElement("ColumnLayerGpGrid")]
        public List<ColumnLayerGpGrid> ColumnLayerGpGrid {
            get {
                return ColumnLayerGpGridField;
            } 
            set {
                ColumnLayerGpGridField = value;
                NotifyPropertyChanged("ColumnLayerGpGrid");
            }
        }

         /// <summary>
         /// bool to indicate if ColumnLayerGpGrid has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ColumnLayerGpGridSpecified
         {
             get {
             if(ColumnLayerGpGridField!=null)
                 return ColumnLayerGpGridField.Count>0?true:false;
             else return false;
             }
         }
        private List<ColumnLayerGpGrid> ColumnLayerGpGridField; 


    } //here



    /// <summary>
    /// This class represents the TruncatedUnstructuredColumnLayerGridRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the TruncatedUnstructuredColumnLayerGridRepresentation xsd type.")]
    public partial class TruncatedUnstructuredColumnLayerGridRepresentation : AbstractTruncatedColumnLayerGridRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// ColumnCount property
        /// </summary>
		[Required]
        [Description("Number of unstructured columns in the grid. Must be positive.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("ColumnCount")]
        public long? ColumnCount {
            get {
                return ColumnCountField;
            } 
            set {
                ColumnCountField = value;
                NotifyPropertyChanged("ColumnCount");
            }
        }

        private long? ColumnCountField; 

        /// <summary>
        /// Geometry property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "UnstructuredColumnLayerGridGeometry")]
		[XmlElement("Geometry")]
        public UnstructuredColumnLayerGridGeometry Geometry {
            get {
                return GeometryField;
            } 
            set {
                GeometryField = value;
                NotifyPropertyChanged("Geometry");
            }
        }

        private UnstructuredColumnLayerGridGeometry GeometryField; 


    } //here

    /// <summary>
    /// This class represents the TruncatedIjkGridRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the TruncatedIjkGridRepresentation xsd type.")]
    public partial class TruncatedIjkGridRepresentation : AbstractTruncatedColumnLayerGridRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// Ni property
        /// </summary>
		[Required]
        [Description("Count of I-indices in the grid. Must be positive.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("Ni")]
        public long? Ni {
            get {
                return NiField;
            } 
            set {
                NiField = value;
                NotifyPropertyChanged("Ni");
            }
        }

        private long? NiField; 

        /// <summary>
        /// Nj property
        /// </summary>
		[Required]
        [Description("Count of J-indices in the grid. Must be positive.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("Nj")]
        public long? Nj {
            get {
                return NjField;
            } 
            set {
                NjField = value;
                NotifyPropertyChanged("Nj");
            }
        }

        private long? NjField; 

        /// <summary>
        /// Geometry property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "IjkGridGeometry")]
		[XmlElement("Geometry")]
        public IjkGridGeometry Geometry {
            get {
                return GeometryField;
            } 
            set {
                GeometryField = value;
                NotifyPropertyChanged("Geometry");
            }
        }

        private IjkGridGeometry GeometryField; 


    } //here



    /// <summary>
    /// This class represents the UnstructuredColumnLayerGridRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the UnstructuredColumnLayerGridRepresentation xsd type.")]
    public partial class UnstructuredColumnLayerGridRepresentation : AbstractColumnLayerGridRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// ColumnCount property
        /// </summary>
		[Required]
        [Description("Number of unstructured columns in the grid. Must be positive.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("ColumnCount")]
        public long? ColumnCount {
            get {
                return ColumnCountField;
            } 
            set {
                ColumnCountField = value;
                NotifyPropertyChanged("ColumnCount");
            }
        }

        private long? ColumnCountField; 

        /// <summary>
        /// Geometry property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "UnstructuredColumnLayerGridGeometry")]
		[XmlElement("Geometry")]
        public UnstructuredColumnLayerGridGeometry Geometry {
            get {
                return GeometryField;
            } 
            set {
                GeometryField = value;
                NotifyPropertyChanged("Geometry");
            }
        }

        private UnstructuredColumnLayerGridGeometry GeometryField; 


    } //here

    /// <summary>
    /// This class represents the IjkGridRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the IjkGridRepresentation xsd type.")]
    public partial class IjkGridRepresentation : AbstractColumnLayerGridRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// Ni property
        /// </summary>
		[Required]
        [Description("Count of cells in the I-direction in the grid. Must be positive. I=1,...,NI, I0=0,...,NI-1.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("Ni")]
        public long? Ni {
            get {
                return NiField;
            } 
            set {
                NiField = value;
                NotifyPropertyChanged("Ni");
            }
        }

        private long? NiField; 

        /// <summary>
        /// Nj property
        /// </summary>
		[Required]
        [Description("Count of cells in the J-direction in the grid. Must be positive. J=1,...,NJ, J0=0,...,NJ-1.")]
        [EnergisticsDataTypeAttribute(DataType = "PositiveLong")]
		[XmlElement("Nj")]
        public long? Nj {
            get {
                return NjField;
            } 
            set {
                NjField = value;
                NotifyPropertyChanged("Nj");
            }
        }

        private long? NjField; 

        /// <summary>
        /// RadialGridIsComplete property
        /// </summary>
		[Description("TRUE if the grid is periodic in J, i.e., has the topology of a complete 360 degree circle.  If TRUE, then NJL=NJ. Otherwise, NJL=NJ+1  May be used to change the grid topology for either a Cartesian or a radial grid, although radial grid usage is by far the more common.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("RadialGridIsComplete")]
        public bool? RadialGridIsComplete {
            get {
                return RadialGridIsCompleteField;
            } 
            set {
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
        public bool RadialGridIsCompleteSpecified {
            get {
                return RadialGridIsCompleteSpecifiedField;
            } 
            set {
                RadialGridIsCompleteSpecifiedField = value;
                NotifyPropertyChanged("RadialGridIsCompleteSpecified");
            }
        }

        private bool RadialGridIsCompleteSpecifiedField; 

        /// <summary>
        /// KGaps property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "KGaps")]
		[XmlElement("KGaps")]
        public KGaps KGaps {
            get {
                return KGapsField;
            } 
            set {
                KGapsField = value;
                NotifyPropertyChanged("KGaps");
            }
        }

        private KGaps KGapsField; 

        /// <summary>
        /// Geometry property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "IjkGridGeometry")]
		[XmlElement("Geometry")]
        public IjkGridGeometry Geometry {
            get {
                return GeometryField;
            } 
            set {
                GeometryField = value;
                NotifyPropertyChanged("Geometry");
            }
        }

        private IjkGridGeometry GeometryField; 


    } //here

    /// <summary>
    /// This class represents the SubRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the SubRepresentation xsd type.")]
    public partial class SubRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// AdditionalGridTopology property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "AdditionalGridTopology")]
		[XmlElement("AdditionalGridTopology")]
        public AdditionalGridTopology AdditionalGridTopology {
            get {
                return AdditionalGridTopologyField;
            } 
            set {
                AdditionalGridTopologyField = value;
                NotifyPropertyChanged("AdditionalGridTopology");
            }
        }

        private AdditionalGridTopology AdditionalGridTopologyField; 

        /// <summary>
        /// SubRepresentationPatch property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "SubRepresentationPatch")]
		[XmlElement("SubRepresentationPatch")]
        public List<SubRepresentationPatch> SubRepresentationPatch {
            get {
                return SubRepresentationPatchField;
            } 
            set {
                SubRepresentationPatchField = value;
                NotifyPropertyChanged("SubRepresentationPatch");
            }
        }

         /// <summary>
         /// bool to indicate if SubRepresentationPatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool SubRepresentationPatchSpecified
         {
             get {
             if(SubRepresentationPatchField!=null)
                 return SubRepresentationPatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<SubRepresentationPatch> SubRepresentationPatchField; 

        /// <summary>
        /// SupportingRepresentation property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("SupportingRepresentation")]
        public List<DataObjectReference> SupportingRepresentation {
            get {
                return SupportingRepresentationField;
            } 
            set {
                SupportingRepresentationField = value;
                NotifyPropertyChanged("SupportingRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if SupportingRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool SupportingRepresentationSpecified
         {
             get {
             if(SupportingRepresentationField!=null)
                 return SupportingRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> SupportingRepresentationField; 


    } //here

    /// <summary>
    /// This class represents the RepresentationSetRepresentation xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SealedVolumeFrameworkRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceFrameworkRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SealedSurfaceFrameworkRepresentation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonSealedSurfaceFrameworkRepresentation))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the RepresentationSetRepresentation xsd type.")]
    public partial class RepresentationSetRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// IsHomogeneous property
        /// </summary>
		[Required]
        [Description("Indicates that all of the selected representations are of a single kind.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("IsHomogeneous")]
        public bool? IsHomogeneous {
            get {
                return IsHomogeneousField;
            } 
            set {
                IsHomogeneousField = value;
                NotifyPropertyChanged("IsHomogeneous");
            }
        }

        private bool? IsHomogeneousField; 

        /// <summary>
        /// Representation property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Representation")]
        public List<DataObjectReference> Representation {
            get {
                return RepresentationField;
            } 
            set {
                RepresentationField = value;
                NotifyPropertyChanged("Representation");
            }
        }

         /// <summary>
         /// bool to indicate if Representation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool RepresentationSpecified
         {
             get {
             if(RepresentationField!=null)
                 return RepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> RepresentationField; 


    } //here

    /// <summary>
    /// This class represents the SealedVolumeFrameworkRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the SealedVolumeFrameworkRepresentation xsd type.")]
    public partial class SealedVolumeFrameworkRepresentation : RepresentationSetRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// Regions property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "VolumeRegion")]
		[XmlElement("Regions")]
        public List<VolumeRegion> Regions {
            get {
                return RegionsField;
            } 
            set {
                RegionsField = value;
                NotifyPropertyChanged("Regions");
            }
        }

         /// <summary>
         /// bool to indicate if Regions has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool RegionsSpecified
         {
             get {
             if(RegionsField!=null)
                 return RegionsField.Count>0?true:false;
             else return false;
             }
         }
        private List<VolumeRegion> RegionsField; 

        /// <summary>
        /// BasedOn property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("BasedOn")]
        public DataObjectReference BasedOn {
            get {
                return BasedOnField;
            } 
            set {
                BasedOnField = value;
                NotifyPropertyChanged("BasedOn");
            }
        }

        private DataObjectReference BasedOnField; 


    } //here



    /// <summary>
    /// This class represents the SealedSurfaceFrameworkRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the SealedSurfaceFrameworkRepresentation xsd type.")]
    public partial class SealedSurfaceFrameworkRepresentation : AbstractSurfaceFrameworkRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// SealedContactRepresentation property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "SealedContactRepresentationPart")]
		[XmlElement("SealedContactRepresentation")]
        public List<SealedContactRepresentationPart> SealedContactRepresentation {
            get {
                return SealedContactRepresentationField;
            } 
            set {
                SealedContactRepresentationField = value;
                NotifyPropertyChanged("SealedContactRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if SealedContactRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool SealedContactRepresentationSpecified
         {
             get {
             if(SealedContactRepresentationField!=null)
                 return SealedContactRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<SealedContactRepresentationPart> SealedContactRepresentationField; 


    } //here

    /// <summary>
    /// This class represents the NonSealedSurfaceFrameworkRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the NonSealedSurfaceFrameworkRepresentation xsd type.")]
    public partial class NonSealedSurfaceFrameworkRepresentation : AbstractSurfaceFrameworkRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// NonSealedContactRepresentation property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "AbstractContactRepresentationPart")]
		[XmlElement("NonSealedContactRepresentation")]
        public List<AbstractContactRepresentationPart> NonSealedContactRepresentation {
            get {
                return NonSealedContactRepresentationField;
            } 
            set {
                NonSealedContactRepresentationField = value;
                NotifyPropertyChanged("NonSealedContactRepresentation");
            }
        }

         /// <summary>
         /// bool to indicate if NonSealedContactRepresentation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool NonSealedContactRepresentationSpecified
         {
             get {
             if(NonSealedContactRepresentationField!=null)
                 return NonSealedContactRepresentationField.Count>0?true:false;
             else return false;
             }
         }
        private List<AbstractContactRepresentationPart> NonSealedContactRepresentationField; 


    } //here

    /// <summary>
    /// This class represents the RedefinedGeometryRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the RedefinedGeometryRepresentation xsd type.")]
    public partial class RedefinedGeometryRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// PatchOfGeometry property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "PatchOfGeometry")]
		[XmlElement("PatchOfGeometry")]
        public List<PatchOfGeometry> PatchOfGeometry {
            get {
                return PatchOfGeometryField;
            } 
            set {
                PatchOfGeometryField = value;
                NotifyPropertyChanged("PatchOfGeometry");
            }
        }

         /// <summary>
         /// bool to indicate if PatchOfGeometry has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PatchOfGeometrySpecified
         {
             get {
             if(PatchOfGeometryField!=null)
                 return PatchOfGeometryField.Count>0?true:false;
             else return false;
             }
         }
        private List<PatchOfGeometry> PatchOfGeometryField; 

        /// <summary>
        /// SupportingRepresentation property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("SupportingRepresentation")]
        public DataObjectReference SupportingRepresentation {
            get {
                return SupportingRepresentationField;
            } 
            set {
                SupportingRepresentationField = value;
                NotifyPropertyChanged("SupportingRepresentation");
            }
        }

        private DataObjectReference SupportingRepresentationField; 


    } //here

    /// <summary>
    /// This class represents the PolylineSetRepresentation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the PolylineSetRepresentation xsd type.")]
    public partial class PolylineSetRepresentation : AbstractRepresentation, INotifyPropertyChanged
    {

        /// <summary>
        /// LineRole property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "LineRole")]
		[XmlElement("LineRole")]
        public LineRole? LineRole {
            get {
                return LineRoleField;
            } 
            set {
                LineRoleField = value;
                 this.LineRoleSpecified = true;
                NotifyPropertyChanged("LineRole");
            }
        }

        private LineRole? LineRoleField; 

        /// <summary>
        /// LineRoleSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool LineRoleSpecified {
            get {
                return LineRoleSpecifiedField;
            } 
            set {
                LineRoleSpecifiedField = value;
                NotifyPropertyChanged("LineRoleSpecified");
            }
        }

        private bool LineRoleSpecifiedField; 

        /// <summary>
        /// LinePatch property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "PolylineSetPatch")]
		[XmlElement("LinePatch")]
        public List<PolylineSetPatch> LinePatch {
            get {
                return LinePatchField;
            } 
            set {
                LinePatchField = value;
                NotifyPropertyChanged("LinePatch");
            }
        }

         /// <summary>
         /// bool to indicate if LinePatch has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool LinePatchSpecified
         {
             get {
             if(LinePatchField!=null)
                 return LinePatchField.Count>0?true:false;
             else return false;
             }
         }
        private List<PolylineSetPatch> LinePatchField; 


    } //here

    /// <summary>
    /// This class represents the StratigraphicUnitDictionary xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the StratigraphicUnitDictionary xsd type.")]
    public partial class StratigraphicUnitDictionary : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// StratigraphicUnitInterpretation property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "StratigraphicUnitInterpretation")]
		[XmlElement("StratigraphicUnitInterpretation")]
        public List<StratigraphicUnitInterpretation> StratigraphicUnitInterpretation {
            get {
                return StratigraphicUnitInterpretationField;
            } 
            set {
                StratigraphicUnitInterpretationField = value;
                NotifyPropertyChanged("StratigraphicUnitInterpretation");
            }
        }

         /// <summary>
         /// bool to indicate if StratigraphicUnitInterpretation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool StratigraphicUnitInterpretationSpecified
         {
             get {
             if(StratigraphicUnitInterpretationField!=null)
                 return StratigraphicUnitInterpretationField.Count>0?true:false;
             else return false;
             }
         }
        private List<StratigraphicUnitInterpretation> StratigraphicUnitInterpretationField; 


    } //here

    /// <summary>
    /// This class represents the StratigraphicUnitInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the StratigraphicUnitInterpretation xsd type.")]
    public partial class StratigraphicUnitInterpretation : GeologicUnitInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// DepositionMode property
        /// </summary>
		[Description("BUSINESS RULE: The deposition mode for a geological unit MUST be consistent with the boundary relations of a genetic boundary. If it is not, then the boundary relation declaration is retained.")]
        [EnergisticsDataTypeAttribute(DataType = "DepositionMode")]
		[XmlElement("DepositionMode")]
        public DepositionMode? DepositionMode {
            get {
                return DepositionModeField;
            } 
            set {
                DepositionModeField = value;
                 this.DepositionModeSpecified = true;
                NotifyPropertyChanged("DepositionMode");
            }
        }

        private DepositionMode? DepositionModeField; 

        /// <summary>
        /// DepositionModeSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool DepositionModeSpecified {
            get {
                return DepositionModeSpecifiedField;
            } 
            set {
                DepositionModeSpecifiedField = value;
                NotifyPropertyChanged("DepositionModeSpecified");
            }
        }

        private bool DepositionModeSpecifiedField; 

        /// <summary>
        /// MaxThickness property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "LengthMeasure")]
		[XmlElement("MaxThickness")]
        public LengthMeasure MaxThickness {
            get {
                return MaxThicknessField;
            } 
            set {
                MaxThicknessField = value;
                NotifyPropertyChanged("MaxThickness");
            }
        }

        private LengthMeasure MaxThicknessField; 

        /// <summary>
        /// MinThickness property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "LengthMeasure")]
		[XmlElement("MinThickness")]
        public LengthMeasure MinThickness {
            get {
                return MinThicknessField;
            } 
            set {
                MinThicknessField = value;
                NotifyPropertyChanged("MinThickness");
            }
        }

        private LengthMeasure MinThicknessField; 

        /// <summary>
        /// StratigraphicUnitKind property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "StratigraphicUnitKind")]
		[XmlElement("StratigraphicUnitKind")]
        public StratigraphicUnitKind? StratigraphicUnitKind {
            get {
                return StratigraphicUnitKindField;
            } 
            set {
                StratigraphicUnitKindField = value;
                 this.StratigraphicUnitKindSpecified = true;
                NotifyPropertyChanged("StratigraphicUnitKind");
            }
        }

        private StratigraphicUnitKind? StratigraphicUnitKindField; 

        /// <summary>
        /// StratigraphicUnitKindSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool StratigraphicUnitKindSpecified {
            get {
                return StratigraphicUnitKindSpecifiedField;
            } 
            set {
                StratigraphicUnitKindSpecifiedField = value;
                NotifyPropertyChanged("StratigraphicUnitKindSpecified");
            }
        }

        private bool StratigraphicUnitKindSpecifiedField; 


    } //here

    /// <summary>
    /// This class represents the GeologicUnitInterpretation xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StratigraphicUnitInterpretation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RockFluidUnitInterpretation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeobodyInterpretation))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the GeologicUnitInterpretation xsd type.")]
    public partial class GeologicUnitInterpretation : AbstractFeatureInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// GeologicUnitComposition property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "LithologyKindExt")]
		[XmlElement("GeologicUnitComposition")]
        public ExtensibleEnum<LithologyKind>? GeologicUnitComposition {
            get {
                return GeologicUnitCompositionField;
            } 
            set {
                GeologicUnitCompositionField = value;
                NotifyPropertyChanged("GeologicUnitComposition");
            }
        }

        private ExtensibleEnum<LithologyKind>? GeologicUnitCompositionField; 

        /// <summary>
        /// Attribute specifying whether the GeologicalUnitIntepretation is intrusive or not.
        /// </summary>
		[Description("Attribute specifying whether the GeologicalUnitIntepretation is intrusive or not.")]
        [EnergisticsDataTypeAttribute(DataType = "GeologicUnitMaterialEmplacement")]
		[XmlElement("GeologicUnitMaterialEmplacement")]
        public GeologicUnitMaterialEmplacement? GeologicUnitMaterialEmplacement {
            get {
                return GeologicUnitMaterialEmplacementField;
            } 
            set {
                GeologicUnitMaterialEmplacementField = value;
                 this.GeologicUnitMaterialEmplacementSpecified = true;
                NotifyPropertyChanged("GeologicUnitMaterialEmplacement");
            }
        }

        private GeologicUnitMaterialEmplacement? GeologicUnitMaterialEmplacementField; 

        /// <summary>
        /// GeologicUnitMaterialEmplacementSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool GeologicUnitMaterialEmplacementSpecified {
            get {
                return GeologicUnitMaterialEmplacementSpecifiedField;
            } 
            set {
                GeologicUnitMaterialEmplacementSpecifiedField = value;
                NotifyPropertyChanged("GeologicUnitMaterialEmplacementSpecified");
            }
        }

        private bool GeologicUnitMaterialEmplacementSpecifiedField; 

        /// <summary>
        /// 3D shape of the geologic unit. 
        /// </summary>
		[Description("3D shape of the geologic unit.")]
        [EnergisticsDataTypeAttribute(DataType = "Shape3dExt")]
		[XmlElement("GeologicUnit3dShape")]
        public ExtensibleEnum<Shape3d>? GeologicUnit3dShape {
            get {
                return GeologicUnit3dShapeField;
            } 
            set {
                GeologicUnit3dShapeField = value;
                NotifyPropertyChanged("GeologicUnit3dShape");
            }
        }

        private ExtensibleEnum<Shape3d>? GeologicUnit3dShapeField; 


    } //here



    /// <summary>
    /// This class represents the WellboreInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the WellboreInterpretation xsd type.")]
    public partial class WellboreInterpretation : AbstractFeatureInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// Used to indicate that this wellbore has been, or is being, drilled, as opposed to planned wells. One wellbore feature may have multiple wellbore interpretations. - For updated drilled trajectories, use IsDrilled=TRUE. - For planned trajectories, use IsDrilled=FALSE used.
        /// </summary>
		[Required]
        [Description("Used to indicate that this wellbore has been, or is being, drilled, as opposed to planned wells. One wellbore feature may have multiple wellbore interpretations.   - For updated drilled trajectories, use IsDrilled=TRUE.  - For planned trajectories, use IsDrilled=FALSE used.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("IsDrilled")]
        public bool? IsDrilled {
            get {
                return IsDrilledField;
            } 
            set {
                IsDrilledField = value;
                NotifyPropertyChanged("IsDrilled");
            }
        }

        private bool? IsDrilledField; 


    } //here



    /// <summary>
    /// This class represents the StratigraphicOccurrenceInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the StratigraphicOccurrenceInterpretation xsd type.")]
    public partial class StratigraphicOccurrenceInterpretation : AbstractStratigraphicOrganizationInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// GeologicUnitIndex property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("GeologicUnitIndex")]
        public List<DataObjectReference> GeologicUnitIndex {
            get {
                return GeologicUnitIndexField;
            } 
            set {
                GeologicUnitIndexField = value;
                NotifyPropertyChanged("GeologicUnitIndex");
            }
        }

         /// <summary>
         /// bool to indicate if GeologicUnitIndex has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool GeologicUnitIndexSpecified
         {
             get {
             if(GeologicUnitIndexField!=null)
                 return GeologicUnitIndexField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> GeologicUnitIndexField; 

        /// <summary>
        /// IsOccurrenceOf property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("IsOccurrenceOf")]
        public DataObjectReference IsOccurrenceOf {
            get {
                return IsOccurrenceOfField;
            } 
            set {
                IsOccurrenceOfField = value;
                NotifyPropertyChanged("IsOccurrenceOf");
            }
        }

        private DataObjectReference IsOccurrenceOfField; 


    } //here

    /// <summary>
    /// This class represents the StratigraphicColumnRankInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the StratigraphicColumnRankInterpretation xsd type.")]
    public partial class StratigraphicColumnRankInterpretation : AbstractStratigraphicOrganizationInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// RankInStratigraphicColumn property
        /// </summary>
		[Required]
        [Description("The rank in the stratigraphic column.")]
        [EnergisticsDataTypeAttribute(DataType = "NonNegativeLong")]
		[XmlElement("RankInStratigraphicColumn")]
        public long? RankInStratigraphicColumn {
            get {
                return RankInStratigraphicColumnField;
            } 
            set {
                RankInStratigraphicColumnField = value;
                NotifyPropertyChanged("RankInStratigraphicColumn");
            }
        }

        private long? RankInStratigraphicColumnField; 

        /// <summary>
        /// StratigraphicUnits property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("StratigraphicUnits")]
        public List<DataObjectReference> StratigraphicUnits {
            get {
                return StratigraphicUnitsField;
            } 
            set {
                StratigraphicUnitsField = value;
                NotifyPropertyChanged("StratigraphicUnits");
            }
        }

         /// <summary>
         /// bool to indicate if StratigraphicUnits has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool StratigraphicUnitsSpecified
         {
             get {
             if(StratigraphicUnitsField!=null)
                 return StratigraphicUnitsField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> StratigraphicUnitsField; 


    } //here

    /// <summary>
    /// This class represents the RockFluidOrganizationInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the RockFluidOrganizationInterpretation xsd type.")]
    public partial class RockFluidOrganizationInterpretation : AbstractOrganizationInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// RockFluidUnitIndex property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("RockFluidUnitIndex")]
        public List<DataObjectReference> RockFluidUnitIndex {
            get {
                return RockFluidUnitIndexField;
            } 
            set {
                RockFluidUnitIndexField = value;
                NotifyPropertyChanged("RockFluidUnitIndex");
            }
        }

         /// <summary>
         /// bool to indicate if RockFluidUnitIndex has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool RockFluidUnitIndexSpecified
         {
             get {
             if(RockFluidUnitIndexField!=null)
                 return RockFluidUnitIndexField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> RockFluidUnitIndexField; 


    } //here

    /// <summary>
    /// This class represents the StructuralOrganizationInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the StructuralOrganizationInterpretation xsd type.")]
    public partial class StructuralOrganizationInterpretation : AbstractOrganizationInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// OrderingCriteria property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "OrderingCriteria")]
		[XmlElement("OrderingCriteria")]
        public OrderingCriteria? OrderingCriteria {
            get {
                return OrderingCriteriaField;
            } 
            set {
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
        public bool OrderingCriteriaSpecified {
            get {
                return OrderingCriteriaSpecifiedField;
            } 
            set {
                OrderingCriteriaSpecifiedField = value;
                NotifyPropertyChanged("OrderingCriteriaSpecified");
            }
        }
        
        private OrderingCriteria? OrderingCriteriaField; 

        /// <summary>
        /// Sides property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Sides")]
        public List<DataObjectReference> Sides {
            get {
                return SidesField;
            } 
            set {
                SidesField = value;
                NotifyPropertyChanged("Sides");
            }
        }

         /// <summary>
         /// bool to indicate if Sides has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool SidesSpecified
         {
             get {
             if(SidesField!=null)
                 return SidesField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> SidesField; 

        /// <summary>
        /// TopFrontier property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("TopFrontier")]
        public List<DataObjectReference> TopFrontier {
            get {
                return TopFrontierField;
            } 
            set {
                TopFrontierField = value;
                NotifyPropertyChanged("TopFrontier");
            }
        }

         /// <summary>
         /// bool to indicate if TopFrontier has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool TopFrontierSpecified
         {
             get {
             if(TopFrontierField!=null)
                 return TopFrontierField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> TopFrontierField; 

        /// <summary>
        /// BottomFrontier property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("BottomFrontier")]
        public List<DataObjectReference> BottomFrontier {
            get {
                return BottomFrontierField;
            } 
            set {
                BottomFrontierField = value;
                NotifyPropertyChanged("BottomFrontier");
            }
        }

         /// <summary>
         /// bool to indicate if BottomFrontier has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BottomFrontierSpecified
         {
             get {
             if(BottomFrontierField!=null)
                 return BottomFrontierField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> BottomFrontierField; 

        /// <summary>
        /// UnorderedFaultCollection property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "FeatureInterpretationSet")]
		[XmlElement("UnorderedFaultCollection")]
        public FeatureInterpretationSet UnorderedFaultCollection {
            get {
                return UnorderedFaultCollectionField;
            } 
            set {
                UnorderedFaultCollectionField = value;
                NotifyPropertyChanged("UnorderedFaultCollection");
            }
        }

        private FeatureInterpretationSet UnorderedFaultCollectionField; 

        /// <summary>
        /// OrderedBoundaryFeatureInterpretation property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "BoundaryFeatureInterpretationPlusItsRank")]
		[XmlElement("OrderedBoundaryFeatureInterpretation")]
        public List<BoundaryFeatureInterpretationPlusItsRank> OrderedBoundaryFeatureInterpretation {
            get {
                return OrderedBoundaryFeatureInterpretationField;
            } 
            set {
                OrderedBoundaryFeatureInterpretationField = value;
                NotifyPropertyChanged("OrderedBoundaryFeatureInterpretation");
            }
        }

         /// <summary>
         /// bool to indicate if OrderedBoundaryFeatureInterpretation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool OrderedBoundaryFeatureInterpretationSpecified
         {
             get {
             if(OrderedBoundaryFeatureInterpretationField!=null)
                 return OrderedBoundaryFeatureInterpretationField.Count>0?true:false;
             else return false;
             }
         }
        private List<BoundaryFeatureInterpretationPlusItsRank> OrderedBoundaryFeatureInterpretationField; 


    } //here

    /// <summary>
    /// This class represents the EarthModelInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the EarthModelInterpretation xsd type.")]
    public partial class EarthModelInterpretation : AbstractFeatureInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// Fluid property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Fluid")]
        public List<DataObjectReference> Fluid {
            get {
                return FluidField;
            } 
            set {
                FluidField = value;
                NotifyPropertyChanged("Fluid");
            }
        }

         /// <summary>
         /// bool to indicate if Fluid has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool FluidSpecified
         {
             get {
             if(FluidField!=null)
                 return FluidField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> FluidField; 

        /// <summary>
        /// Structure property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Structure")]
        public List<DataObjectReference> Structure {
            get {
                return StructureField;
            } 
            set {
                StructureField = value;
                NotifyPropertyChanged("Structure");
            }
        }

         /// <summary>
         /// bool to indicate if Structure has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool StructureSpecified
         {
             get {
             if(StructureField!=null)
                 return StructureField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> StructureField; 

        /// <summary>
        /// StratigraphicOccurrences property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("StratigraphicOccurrences")]
        public List<DataObjectReference> StratigraphicOccurrences {
            get {
                return StratigraphicOccurrencesField;
            } 
            set {
                StratigraphicOccurrencesField = value;
                NotifyPropertyChanged("StratigraphicOccurrences");
            }
        }

         /// <summary>
         /// bool to indicate if StratigraphicOccurrences has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool StratigraphicOccurrencesSpecified
         {
             get {
             if(StratigraphicOccurrencesField!=null)
                 return StratigraphicOccurrencesField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> StratigraphicOccurrencesField; 

        /// <summary>
        /// StratigraphicColumn property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("StratigraphicColumn")]
        public DataObjectReference StratigraphicColumn {
            get {
                return StratigraphicColumnField;
            } 
            set {
                StratigraphicColumnField = value;
                NotifyPropertyChanged("StratigraphicColumn");
            }
        }

        private DataObjectReference StratigraphicColumnField; 


    } //here

    /// <summary>
    /// This class represents the GenericFeatureInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the GenericFeatureInterpretation xsd type.")]
    public partial class GenericFeatureInterpretation : AbstractFeatureInterpretation, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the BoundaryFeatureInterpretation xsd type.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HorizonInterpretation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeobodyBoundaryInterpretation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FluidBoundaryInterpretation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaultInterpretation))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the BoundaryFeatureInterpretation xsd type.")]
    public partial class BoundaryFeatureInterpretation : AbstractFeatureInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// OlderPossibleAge property
        /// </summary>
		[Description("A value in years of the age offset between the DateTime attribute value and the DateTime of a GeologicalEvent occurrence of generation. When it represents a geological event that happened in the past, this value must be POSITIVE.")]
        [EnergisticsDataTypeAttribute(DataType = "long")]
		[XmlElement("OlderPossibleAge")]
        public long? OlderPossibleAge {
            get {
                return OlderPossibleAgeField;
            } 
            set {
                OlderPossibleAgeField = value;
                 this.OlderPossibleAgeSpecified = true;
                NotifyPropertyChanged("OlderPossibleAge");
            }
        }

        private long? OlderPossibleAgeField; 

        /// <summary>
        /// OlderPossibleAgeSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool OlderPossibleAgeSpecified {
            get {
                return OlderPossibleAgeSpecifiedField;
            } 
            set {
                OlderPossibleAgeSpecifiedField = value;
                NotifyPropertyChanged("OlderPossibleAgeSpecified");
            }
        }

        private bool OlderPossibleAgeSpecifiedField; 

        /// <summary>
        /// YoungerPossibleAge property
        /// </summary>
		[Description("A value in years of the age offset between the DateTime attribute value and the DateTime of a GeologicalEvent occurrence of generation. When it represents a geological event that happened in the past, this value must be POSITIVE.")]
        [EnergisticsDataTypeAttribute(DataType = "long")]
		[XmlElement("YoungerPossibleAge")]
        public long? YoungerPossibleAge {
            get {
                return YoungerPossibleAgeField;
            } 
            set {
                YoungerPossibleAgeField = value;
                 this.YoungerPossibleAgeSpecified = true;
                NotifyPropertyChanged("YoungerPossibleAge");
            }
        }

        private long? YoungerPossibleAgeField; 

        /// <summary>
        /// YoungerPossibleAgeSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool YoungerPossibleAgeSpecified {
            get {
                return YoungerPossibleAgeSpecifiedField;
            } 
            set {
                YoungerPossibleAgeSpecifiedField = value;
                NotifyPropertyChanged("YoungerPossibleAgeSpecified");
            }
        }

        private bool YoungerPossibleAgeSpecifiedField; 

        /// <summary>
        /// AbsoluteAge property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "GeologicTime")]
		[XmlElement("AbsoluteAge")]
        public GeologicTime AbsoluteAge {
            get {
                return AbsoluteAgeField;
            } 
            set {
                AbsoluteAgeField = value;
                NotifyPropertyChanged("AbsoluteAge");
            }
        }

        private GeologicTime AbsoluteAgeField; 


    } //here

    /// <summary>
    /// This class represents the HorizonInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the HorizonInterpretation xsd type.")]
    public partial class HorizonInterpretation : BoundaryFeatureInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// BoundaryRelation property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "BoundaryRelation")]
		[XmlElement("BoundaryRelation")]
        public List<BoundaryRelation> BoundaryRelation {
            get {
                return BoundaryRelationField;
            } 
            set {
                BoundaryRelationField = value;
                NotifyPropertyChanged("BoundaryRelation");
            }
        }

         /// <summary>
         /// bool to indicate if BoundaryRelation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BoundaryRelationSpecified
         {
             get {
             if(BoundaryRelationField!=null)
                 return BoundaryRelationField.Count>0?true:false;
             else return false;
             }
         }
        private List<BoundaryRelation> BoundaryRelationField; 

        /// <summary>
        /// HorizonStratigraphicRole property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "HorizonStratigraphicRole")]
		[XmlElement("HorizonStratigraphicRole")]
        public List<HorizonStratigraphicRole> HorizonStratigraphicRole {
            get {
                return HorizonStratigraphicRoleField;
            } 
            set {
                HorizonStratigraphicRoleField = value;
                NotifyPropertyChanged("HorizonStratigraphicRole");
            }
        }

         /// <summary>
         /// bool to indicate if HorizonStratigraphicRole has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool HorizonStratigraphicRoleSpecified
         {
             get {
             if(HorizonStratigraphicRoleField!=null)
                 return HorizonStratigraphicRoleField.Count>0?true:false;
             else return false;
             }
         }
        private List<HorizonStratigraphicRole> HorizonStratigraphicRoleField; 

        /// <summary>
        /// SequenceStratigraphySurface property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "SequenceStratigraphySurface")]
		[XmlElement("SequenceStratigraphySurface")]
        public SequenceStratigraphySurface? SequenceStratigraphySurface {
            get {
                return SequenceStratigraphySurfaceField;
            } 
            set {
                SequenceStratigraphySurfaceField = value;
                 this.SequenceStratigraphySurfaceSpecified = true;
                NotifyPropertyChanged("SequenceStratigraphySurface");
            }
        }

        private SequenceStratigraphySurface? SequenceStratigraphySurfaceField; 

        /// <summary>
        /// SequenceStratigraphySurfaceSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool SequenceStratigraphySurfaceSpecified {
            get {
                return SequenceStratigraphySurfaceSpecifiedField;
            } 
            set {
                SequenceStratigraphySurfaceSpecifiedField = value;
                NotifyPropertyChanged("SequenceStratigraphySurfaceSpecified");
            }
        }

        private bool SequenceStratigraphySurfaceSpecifiedField; 


    } //here

    /// <summary>
    /// This class represents the GeobodyBoundaryInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the GeobodyBoundaryInterpretation xsd type.")]
    public partial class GeobodyBoundaryInterpretation : BoundaryFeatureInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// Characterizes the stratigraphic relationships of a horizon with the stratigraphic units that its bounds.
        /// </summary>
		[Description("Characterizes the stratigraphic relationships of a horizon with the stratigraphic units that its bounds.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "BoundaryRelation")]
		[XmlElement("BoundaryRelation")]
        public List<BoundaryRelation> BoundaryRelation {
            get {
                return BoundaryRelationField;
            } 
            set {
                BoundaryRelationField = value;
                NotifyPropertyChanged("BoundaryRelation");
            }
        }

         /// <summary>
         /// bool to indicate if BoundaryRelation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool BoundaryRelationSpecified
         {
             get {
             if(BoundaryRelationField!=null)
                 return BoundaryRelationField.Count>0?true:false;
             else return false;
             }
         }
        private List<BoundaryRelation> BoundaryRelationField; 


    } //here

    /// <summary>
    /// This class represents the FluidBoundaryInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the FluidBoundaryInterpretation xsd type.")]
    public partial class FluidBoundaryInterpretation : BoundaryFeatureInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// The kind of contact of this boundary.
        /// </summary>
		[Required]
        [Description("The kind of contact of this boundary.")]
        [EnergisticsDataTypeAttribute(DataType = "FluidContact")]
		[XmlElement("FluidContact")]
        public FluidContact? FluidContact {
            get {
                return FluidContactField;
            } 
            set {
                FluidContactField = value;
                 this.FluidContactSpecified = true;
                NotifyPropertyChanged("FluidContact");
            }
        }

        
        private bool FluidContactSpecifiedField = false;
        
        /// <summary>
        /// FluidContactSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool FluidContactSpecified {
            get {
                return FluidContactSpecifiedField;
            } 
            set {
                FluidContactSpecifiedField = value;
                NotifyPropertyChanged("FluidContactSpecified");
            }
        }
        
        private FluidContact? FluidContactField; 


    } //here

    /// <summary>
    /// This class represents the FaultInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the FaultInterpretation xsd type.")]
    public partial class FaultInterpretation : BoundaryFeatureInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// IsListric property
        /// </summary>
		[Description("Indicates if the normal fault is listric or not.  BUSINESS RULE: Must be present if the fault is normal. Must not be present if the fault is not normal.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("IsListric")]
        public bool? IsListric {
            get {
                return IsListricField;
            } 
            set {
                IsListricField = value;
                 this.IsListricSpecified = true;
                NotifyPropertyChanged("IsListric");
            }
        }

        private bool? IsListricField; 

        /// <summary>
        /// IsListricSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool IsListricSpecified {
            get {
                return IsListricSpecifiedField;
            } 
            set {
                IsListricSpecifiedField = value;
                NotifyPropertyChanged("IsListricSpecified");
            }
        }

        private bool IsListricSpecifiedField; 

        /// <summary>
        /// MaximumThrow property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "LengthMeasure")]
		[XmlElement("MaximumThrow")]
        public LengthMeasure MaximumThrow {
            get {
                return MaximumThrowField;
            } 
            set {
                MaximumThrowField = value;
                NotifyPropertyChanged("MaximumThrow");
            }
        }

        private LengthMeasure MaximumThrowField; 

        /// <summary>
        /// MeanAzimuth property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "PlaneAngleMeasure")]
		[XmlElement("MeanAzimuth")]
        public PlaneAngleMeasure MeanAzimuth {
            get {
                return MeanAzimuthField;
            } 
            set {
                MeanAzimuthField = value;
                NotifyPropertyChanged("MeanAzimuth");
            }
        }

        private PlaneAngleMeasure MeanAzimuthField; 

        /// <summary>
        /// MeanDip property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "PlaneAngleMeasure")]
		[XmlElement("MeanDip")]
        public PlaneAngleMeasure MeanDip {
            get {
                return MeanDipField;
            } 
            set {
                MeanDipField = value;
                NotifyPropertyChanged("MeanDip");
            }
        }

        private PlaneAngleMeasure MeanDipField; 

        /// <summary>
        /// ThrowInterpretation property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "FaultThrow")]
		[XmlElement("ThrowInterpretation")]
        public List<FaultThrow> ThrowInterpretation {
            get {
                return ThrowInterpretationField;
            } 
            set {
                ThrowInterpretationField = value;
                NotifyPropertyChanged("ThrowInterpretation");
            }
        }

         /// <summary>
         /// bool to indicate if ThrowInterpretation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ThrowInterpretationSpecified
         {
             get {
             if(ThrowInterpretationField!=null)
                 return ThrowInterpretationField.Count>0?true:false;
             else return false;
             }
         }
        private List<FaultThrow> ThrowInterpretationField; 


    } //here

    /// <summary>
    /// This class represents the RockFluidUnitInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the RockFluidUnitInterpretation xsd type.")]
    public partial class RockFluidUnitInterpretation : GeologicUnitInterpretation, INotifyPropertyChanged
    {

        /// <summary>
        /// Phase property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "Phase")]
		[XmlElement("Phase")]
        public Phase? Phase {
            get {
                return PhaseField;
            } 
            set {
                PhaseField = value;
                 this.PhaseSpecified = true;
                NotifyPropertyChanged("Phase");
            }
        }

        private Phase? PhaseField; 

        /// <summary>
        /// PhaseSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool PhaseSpecified {
            get {
                return PhaseSpecifiedField;
            } 
            set {
                PhaseSpecifiedField = value;
                NotifyPropertyChanged("PhaseSpecified");
            }
        }

        private bool PhaseSpecifiedField; 


    } //here

    /// <summary>
    /// This class represents the GeobodyInterpretation xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the GeobodyInterpretation xsd type.")]
    public partial class GeobodyInterpretation : GeologicUnitInterpretation, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the StratigraphicColumn xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the StratigraphicColumn xsd type.")]
    public partial class StratigraphicColumn : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Ranks property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Ranks")]
        public List<DataObjectReference> Ranks {
            get {
                return RanksField;
            } 
            set {
                RanksField = value;
                NotifyPropertyChanged("Ranks");
            }
        }

         /// <summary>
         /// bool to indicate if Ranks has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool RanksSpecified
         {
             get {
             if(RanksField!=null)
                 return RanksField.Count>0?true:false;
             else return false;
             }
         }
        private List<DataObjectReference> RanksField; 


    } //here



    /// <summary>
    /// This class represents the Model xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the Model xsd type.")]
    public partial class Model : AbstractFeature, INotifyPropertyChanged
    {


    } //here



    /// <summary>
    /// This class represents the StreamlinesFeature xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the StreamlinesFeature xsd type.")]
    public partial class StreamlinesFeature : AbstractTechnicalFeature, INotifyPropertyChanged
    {

        /// <summary>
        /// Flux property
        /// </summary>
		[Required]
        [Description("Specification of the streamline flux, drawn from the enumeration.")]
        [EnergisticsDataTypeAttribute(DataType = "StreamlineFlux")]
		[XmlElement("Flux")]
        public StreamlineFlux? Flux {
            get {
                return FluxField;
            } 
            set {
                FluxField = value;
                 this.FluxSpecified = true;
                NotifyPropertyChanged("Flux");
            }
        }

        
        private bool FluxSpecifiedField = false;
        
        /// <summary>
        /// FluxSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool FluxSpecified {
            get {
                return FluxSpecifiedField;
            } 
            set {
                FluxSpecifiedField = value;
                NotifyPropertyChanged("FluxSpecified");
            }
        }
        
        private StreamlineFlux? FluxField; 

        /// <summary>
        /// OtherFlux property
        /// </summary>
		[StringLength(64)]
        [Description("Optional specification of the streamline flux, if an extension is required beyond the enumeration.  BUSINESS RULE: OtherFlux should appear if Flux has the value of other.")]
        [EnergisticsDataTypeAttribute(DataType = "String64")]
		[XmlElement("OtherFlux")]
        public string OtherFlux {
            get {
                return OtherFluxField;
            } 
            set {
                OtherFluxField = value;
                NotifyPropertyChanged("OtherFlux");
            }
        }

        private string OtherFluxField; 

        /// <summary>
        /// TimeIndex property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "TimeIndex")]
		[XmlElement("TimeIndex")]
        public TimeIndex TimeIndex {
            get {
                return TimeIndexField;
            } 
            set {
                TimeIndexField = value;
                NotifyPropertyChanged("TimeIndex");
            }
        }

        private TimeIndex TimeIndexField; 


    } //here

    /// <summary>
    /// This class represents the WellboreFeature xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the WellboreFeature xsd type.")]
    public partial class WellboreFeature : AbstractTechnicalFeature, INotifyPropertyChanged
    {

        /// <summary>
        /// WitsmlWellbore property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "WitsmlWellboreReference")]
		[XmlElement("WitsmlWellbore")]
        public WitsmlWellboreReference WitsmlWellbore {
            get {
                return WitsmlWellboreField;
            } 
            set {
                WitsmlWellboreField = value;
                NotifyPropertyChanged("WitsmlWellbore");
            }
        }

        private WitsmlWellboreReference WitsmlWellboreField; 


    } //here



    /// <summary>
    /// This class represents the SeismicLineSetFeature xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the SeismicLineSetFeature xsd type.")]
    public partial class SeismicLineSetFeature : AbstractSeismicSurveyFeature, INotifyPropertyChanged
    {


    } //here



    /// <summary>
    /// This class represents the SeismicLatticeFeature xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the SeismicLatticeFeature xsd type.")]
    public partial class SeismicLatticeFeature : AbstractSeismicSurveyFeature, INotifyPropertyChanged
    {

        /// <summary>
        /// CrosslineLabels property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "IntegerLatticeArray")]
		[XmlElement("CrosslineLabels")]
        public IntegerLatticeArray CrosslineLabels {
            get {
                return CrosslineLabelsField;
            } 
            set {
                CrosslineLabelsField = value;
                NotifyPropertyChanged("CrosslineLabels");
            }
        }

        private IntegerLatticeArray CrosslineLabelsField; 

        /// <summary>
        /// IsPartOf property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "SeismicLatticeSetFeature")]
		[XmlElement("IsPartOf")]
        public SeismicLatticeSetFeature IsPartOf {
            get {
                return IsPartOfField;
            } 
            set {
                IsPartOfField = value;
                NotifyPropertyChanged("IsPartOf");
            }
        }

        private SeismicLatticeSetFeature IsPartOfField; 

        /// <summary>
        /// InlineLabels property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "IntegerLatticeArray")]
		[XmlElement("InlineLabels")]
        public IntegerLatticeArray InlineLabels {
            get {
                return InlineLabelsField;
            } 
            set {
                InlineLabelsField = value;
                NotifyPropertyChanged("InlineLabels");
            }
        }

        private IntegerLatticeArray InlineLabelsField; 


    } //here



    /// <summary>
    /// This class represents the ShotPointLineFeature xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the ShotPointLineFeature xsd type.")]
    public partial class ShotPointLineFeature : AbstractSeismicLineFeature, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the CmpLineFeature xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the CmpLineFeature xsd type.")]
    public partial class CmpLineFeature : AbstractSeismicLineFeature, INotifyPropertyChanged
    {

        /// <summary>
        /// NearestShotPointIndices property
        /// </summary>
		[Required]
        [EnergisticsDataTypeAttribute(DataType = "AbstractIntegerArray")]
		[XmlElement("NearestShotPointIndices")]
        public AbstractIntegerArray NearestShotPointIndices {
            get {
                return NearestShotPointIndicesField;
            } 
            set {
                NearestShotPointIndicesField = value;
                NotifyPropertyChanged("NearestShotPointIndices");
            }
        }

        private AbstractIntegerArray NearestShotPointIndicesField; 

        /// <summary>
        /// ShotPointLineFeature property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("ShotPointLineFeature")]
        public DataObjectReference ShotPointLineFeature {
            get {
                return ShotPointLineFeatureField;
            } 
            set {
                ShotPointLineFeatureField = value;
                NotifyPropertyChanged("ShotPointLineFeature");
            }
        }

        private DataObjectReference ShotPointLineFeatureField; 


    } //here

    /// <summary>
    /// This class represents the FrontierFeature xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the FrontierFeature xsd type.")]
    public partial class FrontierFeature : AbstractTechnicalFeature, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the RockVolumeFeature xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the RockVolumeFeature xsd type.")]
    public partial class RockVolumeFeature : AbstractFeature, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the BoundaryFeature xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[Description("This class represents the BoundaryFeature xsd type.")]
    public partial class BoundaryFeature : AbstractFeature, INotifyPropertyChanged
    {


    } //here

    /// <summary>
    /// This class represents the RockVolumeFeatureDictionary xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/resqmlv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/resqmlv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the RockVolumeFeatureDictionary xsd type.")]
    public partial class RockVolumeFeatureDictionary : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// RockVolumeFeature property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "RockVolumeFeature")]
		[XmlElement("RockVolumeFeature")]
        public List<RockVolumeFeature> RockVolumeFeature {
            get {
                return RockVolumeFeatureField;
            } 
            set {
                RockVolumeFeatureField = value;
                NotifyPropertyChanged("RockVolumeFeature");
            }
        }

         /// <summary>
         /// bool to indicate if RockVolumeFeature has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool RockVolumeFeatureSpecified
         {
             get {
             if(RockVolumeFeatureField!=null)
                 return RockVolumeFeatureField.Count>0?true:false;
             else return false;
             }
         }
        private List<RockVolumeFeature> RockVolumeFeatureField; 


    } //here

    /// <summary>
    /// This class represents the GraphicalInformationSet xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/commonv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/commonv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the GraphicalInformationSet xsd type.")]
    public partial class GraphicalInformationSet : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// GraphicalInformation property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "AbstractGraphicalInformation")]
		[XmlElement("GraphicalInformation")]
        public List<AbstractGraphicalInformation> GraphicalInformation {
            get {
                return GraphicalInformationField;
            } 
            set {
                GraphicalInformationField = value;
                NotifyPropertyChanged("GraphicalInformation");
            }
        }

         /// <summary>
         /// bool to indicate if GraphicalInformation has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool GraphicalInformationSpecified
         {
             get {
             if(GraphicalInformationField!=null)
                 return GraphicalInformationField.Count>0?true:false;
             else return false;
             }
         }
        private List<AbstractGraphicalInformation> GraphicalInformationField; 


    } //here

    /// <summary>
    /// This class represents the DataAssuranceRecord xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/commonv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/commonv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the DataAssuranceRecord xsd type.")]
    public partial class DataAssuranceRecord : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// PolicyId property
        /// </summary>
		[Required]
        [StringLength(64)]
        [Description("Identifier of the policy whose conformance is being described.")]
        [EnergisticsDataTypeAttribute(DataType = "String64")]
		[XmlElement("PolicyId")]
        public string PolicyId {
            get {
                return PolicyIdField;
            } 
            set {
                PolicyIdField = value;
                NotifyPropertyChanged("PolicyId");
            }
        }

        private string PolicyIdField; 

        /// <summary>
        /// PolicyName property
        /// </summary>
		[StringLength(2000)]
        [Description("Human-readable name of the policy")]
        [EnergisticsDataTypeAttribute(DataType = "String2000")]
		[XmlElement("PolicyName")]
        public string PolicyName {
            get {
                return PolicyNameField;
            } 
            set {
                PolicyNameField = value;
                NotifyPropertyChanged("PolicyName");
            }
        }

        private string PolicyNameField; 

        /// <summary>
        /// ReferencedElementName property
        /// </summary>
		[StringLength(64)]
        [Description("If the Policy applies to a single element within the referenced data object this attribute holds its element name.")]
        [EnergisticsDataTypeAttribute(DataType = "String64")]
		[XmlElement("ReferencedElementName")]
        public string ReferencedElementName {
            get {
                return ReferencedElementNameField;
            } 
            set {
                ReferencedElementNameField = value;
                NotifyPropertyChanged("ReferencedElementName");
            }
        }

        private string ReferencedElementNameField; 

        /// <summary>
        /// ReferencedElementUid property
        /// </summary>
		[StringLength(64)]
        [Description("If the Policy applies to a single occurrence of a recurring element within the referenced data object this attribute holds its uid.  The name of the recurring element would be in the ReferencedElementName.")]
        [EnergisticsDataTypeAttribute(DataType = "String64")]
		[XmlElement("ReferencedElementUid")]
        public string ReferencedElementUid {
            get {
                return ReferencedElementUidField;
            } 
            set {
                ReferencedElementUidField = value;
                NotifyPropertyChanged("ReferencedElementUid");
            }
        }

        private string ReferencedElementUidField; 

        /// <summary>
        /// Origin property
        /// </summary>
		[Required]
        [Description("Agent which checked the data for conformance with the policy. This could be a person or an automated computer process or any number of other things.")]
        [EnergisticsDataTypeAttribute(DataType = "string")]
		[XmlElement("Origin")]
        public string Origin {
            get {
                return OriginField;
            } 
            set {
                OriginField = value;
                NotifyPropertyChanged("Origin");
            }
        }

        private string OriginField; 

        /// <summary>
        /// Conformance property
        /// </summary>
		[Required]
        [Description("Yes/no flag indicating whether this particular data ???? conforms with the policy or not.")]
        [EnergisticsDataTypeAttribute(DataType = "boolean")]
		[XmlElement("Conformance")]
        public bool? Conformance {
            get {
                return ConformanceField;
            } 
            set {
                ConformanceField = value;
                NotifyPropertyChanged("Conformance");
            }
        }

        private bool? ConformanceField; 

        /// <summary>
        /// Date property
        /// </summary>
		[Required]
        [Description("Date the policy was last checked. This is the date for which the Conformance value is valid.")]
        [EnergisticsDataTypeAttribute(DataType = "TimeStamp")]
		[XmlElement("Date")]
        public Timestamp? Date {
            get {
                return DateField;
            } 
            set {
                DateField = value;
                 this.DateSpecified = true;
                NotifyPropertyChanged("Date");
            }
        }

        
        private bool DateSpecifiedField = false;
        
        /// <summary>
        /// DateSpecified property
        /// </summary>
        [XmlIgnore]
        [Browsable(false)]
        public bool DateSpecified {
            get {
                return DateSpecifiedField;
            } 
            set {
                DateSpecifiedField = value;
                NotifyPropertyChanged("DateSpecified");
            }
        }
        
        private Timestamp? DateField; 

        /// <summary>
        /// Comment property
        /// </summary>
		[EnergisticsDataTypeAttribute(DataType = "string")]
		[XmlElement("Comment")]
        public string Comment {
            get {
                return CommentField;
            } 
            set {
                CommentField = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private string CommentField; 

        /// <summary>
        /// FailingRules property
        /// </summary>
		[RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "FailingRule")]
		[XmlElement("FailingRules")]
        public List<FailingRule> FailingRules {
            get {
                return FailingRulesField;
            } 
            set {
                FailingRulesField = value;
                NotifyPropertyChanged("FailingRules");
            }
        }

         /// <summary>
         /// bool to indicate if FailingRules has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool FailingRulesSpecified
         {
             get {
             if(FailingRulesField!=null)
                 return FailingRulesField.Count>0?true:false;
             else return false;
             }
         }
        private List<FailingRule> FailingRulesField; 

        /// <summary>
        /// IndexRange property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "IndexRange")]
		[XmlElement("IndexRange")]
        public IndexRange IndexRange {
            get {
                return IndexRangeField;
            } 
            set {
                IndexRangeField = value;
                NotifyPropertyChanged("IndexRange");
            }
        }

        private IndexRange IndexRangeField; 

        /// <summary>
        /// ReferencedData property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("ReferencedData")]
        public DataObjectReference ReferencedData {
            get {
                return ReferencedDataField;
            } 
            set {
                ReferencedDataField = value;
                NotifyPropertyChanged("ReferencedData");
            }
        }

        private DataObjectReference ReferencedDataField; 


    } //here



    /// <summary>
    /// This class represents the ActivityTemplate xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/commonv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/commonv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the ActivityTemplate xsd type.")]
    public partial class ActivityTemplate : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Parameter property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "ParameterTemplate")]
		[XmlElement("Parameter")]
        public List<ParameterTemplate> Parameter {
            get {
                return ParameterField;
            } 
            set {
                ParameterField = value;
                NotifyPropertyChanged("Parameter");
            }
        }

         /// <summary>
         /// bool to indicate if Parameter has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ParameterSpecified
         {
             get {
             if(ParameterField!=null)
                 return ParameterField.Count>0?true:false;
             else return false;
             }
         }
        private List<ParameterTemplate> ParameterField; 


    } //here

    /// <summary>
    /// This class represents the Activity xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/commonv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/commonv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the Activity xsd type.")]
    public partial class Activity : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// ActivityDescriptor property
        /// </summary>
		[Required]
        [ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("ActivityDescriptor")]
        public DataObjectReference ActivityDescriptor {
            get {
                return ActivityDescriptorField;
            } 
            set {
                ActivityDescriptorField = value;
                NotifyPropertyChanged("ActivityDescriptor");
            }
        }

        private DataObjectReference ActivityDescriptorField; 

        /// <summary>
        /// Parent property
        /// </summary>
		[ComponentElement]
        [EnergisticsDataTypeAttribute(DataType = "DataObjectReference")]
		[XmlElement("Parent")]
        public DataObjectReference Parent {
            get {
                return ParentField;
            } 
            set {
                ParentField = value;
                NotifyPropertyChanged("Parent");
            }
        }

        private DataObjectReference ParentField; 

        /// <summary>
        /// Parameter property
        /// </summary>
		[Required]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "AbstractActivityParameter")]
		[XmlElement("Parameter")]
        public List<AbstractActivityParameter> Parameter {
            get {
                return ParameterField;
            } 
            set {
                ParameterField = value;
                NotifyPropertyChanged("Parameter");
            }
        }

         /// <summary>
         /// bool to indicate if Parameter has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool ParameterSpecified
         {
             get {
             if(ParameterField!=null)
                 return ParameterField.Count>0?true:false;
             else return false;
             }
         }
        private List<AbstractActivityParameter> ParameterField; 


    } //here

    /// <summary>
    /// This class represents the PropertyKindDictionary xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/commonv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/commonv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the PropertyKindDictionary xsd type.")]
    public partial class PropertyKindDictionary : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// PropertyKind property
        /// </summary>
		[Required]
        [Description("Defines which property kind are contained into a property kind dictionary.")]
        [RecurringElement]
        [EnergisticsDataTypeAttribute(DataType = "PropertyKind")]
		[XmlElement("PropertyKind")]
        public List<PropertyKind> PropertyKind {
            get {
                return PropertyKindField;
            } 
            set {
                PropertyKindField = value;
                NotifyPropertyChanged("PropertyKind");
            }
        }

         /// <summary>
         /// bool to indicate if PropertyKind has been set. Used for serialization.
         /// </summary>
         [XmlIgnore]
         public bool PropertyKindSpecified
         {
             get {
             if(PropertyKindField!=null)
                 return PropertyKindField.Count>0?true:false;
             else return false;
             }
         }
        private List<PropertyKind> PropertyKindField; 


    } //here

    /// <summary>
    /// This class represents the EpcExternalPartReference xsd type.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.energistics.org/energyml/data/commonv2")]
    [System.Xml.Serialization.XmlRootAttribute("", Namespace="http://www.energistics.org/energyml/data/commonv2", IsNullable=false)]
	[EnergisticsDataObjectAttribute(StandardFamily.RESQML, "2.1")]
    [Description("This class represents the EpcExternalPartReference xsd type.")]
    public partial class EpcExternalPartReference : AbstractObject, IResqmlDataObject, INotifyPropertyChanged
    {

        /// <summary>
        /// Filename property
        /// </summary>
		[StringLength(2000)]
        [EnergisticsDataTypeAttribute(DataType = "String2000")]
		[XmlElement("Filename")]
        public string Filename {
            get {
                return FilenameField;
            } 
            set {
                FilenameField = value;
                NotifyPropertyChanged("Filename");
            }
        }

        private string FilenameField; 

        /// <summary>
        /// MimeType property
        /// </summary>
		[StringLength(2000)]
        [Description("IAMF registered, if one exists, or a free text field. Needs documentation on seismic especially.  MIME type for HDF proxy is : application/x-hdf5 (by convention).")]
        [EnergisticsDataTypeAttribute(DataType = "String2000")]
		[XmlElement("MimeType")]
        public string MimeType {
            get {
                return MimeTypeField;
            } 
            set {
                MimeTypeField = value;
                NotifyPropertyChanged("MimeType");
            }
        }

        private string MimeTypeField; 


    } //here

    #endregion

    #region Enumerations
 
    #endregion
}