
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
namespace Energistics.DataAccess.RESQML210.ReferenceData
{
    /// <summary>
    /// This class represents the ExistenceKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ExistenceKind xsd enumeration.")]
    public enum ExistenceKind
    {
        /// <summary>
        /// actual property
        /// </summary>
        actual,
        /// <summary>
        /// planned property
        /// </summary>
        planned,
        /// <summary>
        /// simulated property
        /// </summary>
        simulated
    }
    /// <summary>
    /// This class represents the MatrixCementKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MatrixCementKind xsd enumeration.")]
    public enum MatrixCementKind
    {
        /// <summary>
        /// ankerite property
        /// </summary>
        ankerite,
        /// <summary>
        /// calcite property
        /// </summary>
        calcite,
        /// <summary>
        /// chlorite property
        /// </summary>
        chlorite,
        /// <summary>
        /// dolomite property
        /// </summary>
        dolomite,
        /// <summary>
        /// illite property
        /// </summary>
        illite,
        /// <summary>
        /// kaolinite property
        /// </summary>
        kaolinite,
        /// <summary>
        /// quartz property
        /// </summary>
        quartz,
        /// <summary>
        /// siderite property
        /// </summary>
        siderite,
        /// <summary>
        /// smectite property
        /// </summary>
        smectite
    }
    /// <summary>
    /// This class represents the MeasureClass xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MeasureClass xsd enumeration.")]
    public enum MeasureClass
    {
        /// <summary>
        /// absorbeddose property
        /// </summary>
        [XmlEnum("absorbed dose")]
        absorbeddose,
        /// <summary>
        /// activityofradioactivity property
        /// </summary>
        [XmlEnum("activity of radioactivity")]
        activityofradioactivity,
        /// <summary>
        /// amountofsubstance property
        /// </summary>
        [XmlEnum("amount of substance")]
        amountofsubstance,
        /// <summary>
        /// amountofsubstanceperamountofsubstance property
        /// </summary>
        [XmlEnum("amount of substance per amount of substance")]
        amountofsubstanceperamountofsubstance,
        /// <summary>
        /// amountofsubstanceperarea property
        /// </summary>
        [XmlEnum("amount of substance per area")]
        amountofsubstanceperarea,
        /// <summary>
        /// amountofsubstancepertime property
        /// </summary>
        [XmlEnum("amount of substance per time")]
        amountofsubstancepertime,
        /// <summary>
        /// amountofsubstancepertimeperarea property
        /// </summary>
        [XmlEnum("amount of substance per time per area")]
        amountofsubstancepertimeperarea,
        /// <summary>
        /// amountofsubstancepervolume property
        /// </summary>
        [XmlEnum("amount of substance per volume")]
        amountofsubstancepervolume,
        /// <summary>
        /// angleperlength property
        /// </summary>
        [XmlEnum("angle per length")]
        angleperlength,
        /// <summary>
        /// anglepervolume property
        /// </summary>
        [XmlEnum("angle per volume")]
        anglepervolume,
        /// <summary>
        /// angularacceleration property
        /// </summary>
        [XmlEnum("angular acceleration")]
        angularacceleration,
        /// <summary>
        /// angularvelocity property
        /// </summary>
        [XmlEnum("angular velocity")]
        angularvelocity,
        /// <summary>
        /// apigammaray property
        /// </summary>
        [XmlEnum("api gamma ray")]
        apigammaray,
        /// <summary>
        /// apigravity property
        /// </summary>
        [XmlEnum("api gravity")]
        apigravity,
        /// <summary>
        /// apineutron property
        /// </summary>
        [XmlEnum("api neutron")]
        apineutron,
        /// <summary>
        /// area property
        /// </summary>
        area,
        /// <summary>
        /// areaperamountofsubstance property
        /// </summary>
        [XmlEnum("area per amount of substance")]
        areaperamountofsubstance,
        /// <summary>
        /// areaperarea property
        /// </summary>
        [XmlEnum("area per area")]
        areaperarea,
        /// <summary>
        /// areapercount property
        /// </summary>
        [XmlEnum("area per count")]
        areapercount,
        /// <summary>
        /// areapermass property
        /// </summary>
        [XmlEnum("area per mass")]
        areapermass,
        /// <summary>
        /// areapertime property
        /// </summary>
        [XmlEnum("area per time")]
        areapertime,
        /// <summary>
        /// areapervolume property
        /// </summary>
        [XmlEnum("area per volume")]
        areapervolume,
        /// <summary>
        /// attenuationperfrequencyinterval property
        /// </summary>
        [XmlEnum("attenuation per frequency interval")]
        attenuationperfrequencyinterval,
        /// <summary>
        /// capacitance property
        /// </summary>
        capacitance,
        /// <summary>
        /// cationexchangecapacity property
        /// </summary>
        [XmlEnum("cation exchange capacity")]
        cationexchangecapacity,
        /// <summary>
        /// datatransferspeed property
        /// </summary>
        [XmlEnum("data transfer speed")]
        datatransferspeed,
        /// <summary>
        /// diffusioncoefficient property
        /// </summary>
        [XmlEnum("diffusion coefficient")]
        diffusioncoefficient,
        /// <summary>
        /// diffusivetimeofflight property
        /// </summary>
        [XmlEnum("diffusive time of flight")]
        diffusivetimeofflight,
        /// <summary>
        /// digitalstorage property
        /// </summary>
        [XmlEnum("digital storage")]
        digitalstorage,
        /// <summary>
        /// dimensionless property
        /// </summary>
        dimensionless,
        /// <summary>
        /// dipolemoment property
        /// </summary>
        [XmlEnum("dipole moment")]
        dipolemoment,
        /// <summary>
        /// doseequivalent property
        /// </summary>
        [XmlEnum("dose equivalent")]
        doseequivalent,
        /// <summary>
        /// dynamicviscosity property
        /// </summary>
        [XmlEnum("dynamic viscosity")]
        dynamicviscosity,
        /// <summary>
        /// electriccharge property
        /// </summary>
        [XmlEnum("electric charge")]
        electriccharge,
        /// <summary>
        /// electricchargeperarea property
        /// </summary>
        [XmlEnum("electric charge per area")]
        electricchargeperarea,
        /// <summary>
        /// electricchargepermass property
        /// </summary>
        [XmlEnum("electric charge per mass")]
        electricchargepermass,
        /// <summary>
        /// electricchargepervolume property
        /// </summary>
        [XmlEnum("electric charge per volume")]
        electricchargepervolume,
        /// <summary>
        /// electricconductance property
        /// </summary>
        [XmlEnum("electric conductance")]
        electricconductance,
        /// <summary>
        /// electricconductivity property
        /// </summary>
        [XmlEnum("electric conductivity")]
        electricconductivity,
        /// <summary>
        /// electriccurrent property
        /// </summary>
        [XmlEnum("electric current")]
        electriccurrent,
        /// <summary>
        /// electriccurrentdensity property
        /// </summary>
        [XmlEnum("electric current density")]
        electriccurrentdensity,
        /// <summary>
        /// electricfieldstrength property
        /// </summary>
        [XmlEnum("electric field strength")]
        electricfieldstrength,
        /// <summary>
        /// electricpotentialdifference property
        /// </summary>
        [XmlEnum("electric potential difference")]
        electricpotentialdifference,
        /// <summary>
        /// electricresistance property
        /// </summary>
        [XmlEnum("electric resistance")]
        electricresistance,
        /// <summary>
        /// electricresistanceperlength property
        /// </summary>
        [XmlEnum("electric resistance per length")]
        electricresistanceperlength,
        /// <summary>
        /// electricalresistivity property
        /// </summary>
        [XmlEnum("electrical resistivity")]
        electricalresistivity,
        /// <summary>
        /// electromagneticmoment property
        /// </summary>
        [XmlEnum("electromagnetic moment")]
        electromagneticmoment,
        /// <summary>
        /// energy property
        /// </summary>
        energy,
        /// <summary>
        /// energylengthperarea property
        /// </summary>
        [XmlEnum("energy length per area")]
        energylengthperarea,
        /// <summary>
        /// energylengthpertimeareatemperature property
        /// </summary>
        [XmlEnum("energy length per time area temperature")]
        energylengthpertimeareatemperature,
        /// <summary>
        /// energyperarea property
        /// </summary>
        [XmlEnum("energy per area")]
        energyperarea,
        /// <summary>
        /// energyperlength property
        /// </summary>
        [XmlEnum("energy per length")]
        energyperlength,
        /// <summary>
        /// energypermass property
        /// </summary>
        [XmlEnum("energy per mass")]
        energypermass,
        /// <summary>
        /// energypermasspertime property
        /// </summary>
        [XmlEnum("energy per mass per time")]
        energypermasspertime,
        /// <summary>
        /// energypervolume property
        /// </summary>
        [XmlEnum("energy per volume")]
        energypervolume,
        /// <summary>
        /// force property
        /// </summary>
        force,
        /// <summary>
        /// forcearea property
        /// </summary>
        [XmlEnum("force area")]
        forcearea,
        /// <summary>
        /// forcelengthperlength property
        /// </summary>
        [XmlEnum("force length per length")]
        forcelengthperlength,
        /// <summary>
        /// forceperforce property
        /// </summary>
        [XmlEnum("force per force")]
        forceperforce,
        /// <summary>
        /// forceperlength property
        /// </summary>
        [XmlEnum("force per length")]
        forceperlength,
        /// <summary>
        /// forcepervolume property
        /// </summary>
        [XmlEnum("force per volume")]
        forcepervolume,
        /// <summary>
        /// frequency property
        /// </summary>
        frequency,
        /// <summary>
        /// frequencyinterval property
        /// </summary>
        [XmlEnum("frequency interval")]
        frequencyinterval,
        /// <summary>
        /// heatcapacity property
        /// </summary>
        [XmlEnum("heat capacity")]
        heatcapacity,
        /// <summary>
        /// heatflowrate property
        /// </summary>
        [XmlEnum("heat flow rate")]
        heatflowrate,
        /// <summary>
        /// heattransfercoefficient property
        /// </summary>
        [XmlEnum("heat transfer coefficient")]
        heattransfercoefficient,
        /// <summary>
        /// illuminance property
        /// </summary>
        illuminance,
        /// <summary>
        /// inductance property
        /// </summary>
        inductance,
        /// <summary>
        /// isothermalcompressibility property
        /// </summary>
        [XmlEnum("isothermal compressibility")]
        isothermalcompressibility,
        /// <summary>
        /// kinematicviscosity property
        /// </summary>
        [XmlEnum("kinematic viscosity")]
        kinematicviscosity,
        /// <summary>
        /// length property
        /// </summary>
        length,
        /// <summary>
        /// lengthperlength property
        /// </summary>
        [XmlEnum("length per length")]
        lengthperlength,
        /// <summary>
        /// lengthpermass property
        /// </summary>
        [XmlEnum("length per mass")]
        lengthpermass,
        /// <summary>
        /// lengthperpressure property
        /// </summary>
        [XmlEnum("length per pressure")]
        lengthperpressure,
        /// <summary>
        /// lengthpertemperature property
        /// </summary>
        [XmlEnum("length per temperature")]
        lengthpertemperature,
        /// <summary>
        /// lengthpertime property
        /// </summary>
        [XmlEnum("length per time")]
        lengthpertime,
        /// <summary>
        /// lengthpervolume property
        /// </summary>
        [XmlEnum("length per volume")]
        lengthpervolume,
        /// <summary>
        /// lightexposure property
        /// </summary>
        [XmlEnum("light exposure")]
        lightexposure,
        /// <summary>
        /// linearacceleration property
        /// </summary>
        [XmlEnum("linear acceleration")]
        linearacceleration,
        /// <summary>
        /// linearthermalexpansion property
        /// </summary>
        [XmlEnum("linear thermal expansion")]
        linearthermalexpansion,
        /// <summary>
        /// logarithmicpowerratio property
        /// </summary>
        [XmlEnum("logarithmic power ratio")]
        logarithmicpowerratio,
        /// <summary>
        /// logarithmicpowerratioperlength property
        /// </summary>
        [XmlEnum("logarithmic power ratio per length")]
        logarithmicpowerratioperlength,
        /// <summary>
        /// luminance property
        /// </summary>
        luminance,
        /// <summary>
        /// luminousefficacy property
        /// </summary>
        [XmlEnum("luminous efficacy")]
        luminousefficacy,
        /// <summary>
        /// luminousflux property
        /// </summary>
        [XmlEnum("luminous flux")]
        luminousflux,
        /// <summary>
        /// luminousintensity property
        /// </summary>
        [XmlEnum("luminous intensity")]
        luminousintensity,
        /// <summary>
        /// magneticdipolemoment property
        /// </summary>
        [XmlEnum("magnetic dipole moment")]
        magneticdipolemoment,
        /// <summary>
        /// magneticfieldstrength property
        /// </summary>
        [XmlEnum("magnetic field strength")]
        magneticfieldstrength,
        /// <summary>
        /// magneticflux property
        /// </summary>
        [XmlEnum("magnetic flux")]
        magneticflux,
        /// <summary>
        /// magneticfluxdensity property
        /// </summary>
        [XmlEnum("magnetic flux density")]
        magneticfluxdensity,
        /// <summary>
        /// magneticfluxdensityperlength property
        /// </summary>
        [XmlEnum("magnetic flux density per length")]
        magneticfluxdensityperlength,
        /// <summary>
        /// magneticpermeability property
        /// </summary>
        [XmlEnum("magnetic permeability")]
        magneticpermeability,
        /// <summary>
        /// magneticvectorpotential property
        /// </summary>
        [XmlEnum("magnetic vector potential")]
        magneticvectorpotential,
        /// <summary>
        /// mass property
        /// </summary>
        mass,
        /// <summary>
        /// masslength property
        /// </summary>
        [XmlEnum("mass length")]
        masslength,
        /// <summary>
        /// massperarea property
        /// </summary>
        [XmlEnum("mass per area")]
        massperarea,
        /// <summary>
        /// massperenergy property
        /// </summary>
        [XmlEnum("mass per energy")]
        massperenergy,
        /// <summary>
        /// massperlength property
        /// </summary>
        [XmlEnum("mass per length")]
        massperlength,
        /// <summary>
        /// masspermass property
        /// </summary>
        [XmlEnum("mass per mass")]
        masspermass,
        /// <summary>
        /// masspertime property
        /// </summary>
        [XmlEnum("mass per time")]
        masspertime,
        /// <summary>
        /// masspertimeperarea property
        /// </summary>
        [XmlEnum("mass per time per area")]
        masspertimeperarea,
        /// <summary>
        /// masspertimeperlength property
        /// </summary>
        [XmlEnum("mass per time per length")]
        masspertimeperlength,
        /// <summary>
        /// masspervolume property
        /// </summary>
        [XmlEnum("mass per volume")]
        masspervolume,
        /// <summary>
        /// masspervolumeperlength property
        /// </summary>
        [XmlEnum("mass per volume per length")]
        masspervolumeperlength,
        /// <summary>
        /// masspervolumeperpressure property
        /// </summary>
        [XmlEnum("mass per volume per pressure")]
        masspervolumeperpressure,
        /// <summary>
        /// masspervolumepertemperature property
        /// </summary>
        [XmlEnum("mass per volume per temperature")]
        masspervolumepertemperature,
        /// <summary>
        /// mobility property
        /// </summary>
        mobility,
        /// <summary>
        /// molarenergy property
        /// </summary>
        [XmlEnum("molar energy")]
        molarenergy,
        /// <summary>
        /// molarheatcapacity property
        /// </summary>
        [XmlEnum("molar heat capacity")]
        molarheatcapacity,
        /// <summary>
        /// molarvolume property
        /// </summary>
        [XmlEnum("molar volume")]
        molarvolume,
        /// <summary>
        /// molecularweight property
        /// </summary>
        [XmlEnum("molecular weight")]
        molecularweight,
        /// <summary>
        /// momentofforce property
        /// </summary>
        [XmlEnum("moment of force")]
        momentofforce,
        /// <summary>
        /// momentofinertia property
        /// </summary>
        [XmlEnum("moment of inertia")]
        momentofinertia,
        /// <summary>
        /// momentum property
        /// </summary>
        momentum,
        /// <summary>
        /// normalizedpower property
        /// </summary>
        [XmlEnum("normalized power")]
        normalizedpower,
        /// <summary>
        /// permeabilitylength property
        /// </summary>
        [XmlEnum("permeability length")]
        permeabilitylength,
        /// <summary>
        /// permeabilityrock property
        /// </summary>
        [XmlEnum("permeability rock")]
        permeabilityrock,
        /// <summary>
        /// permittivity property
        /// </summary>
        permittivity,
        /// <summary>
        /// planeangle property
        /// </summary>
        [XmlEnum("plane angle")]
        planeangle,
        /// <summary>
        /// potentialdifferenceperpowerdrop property
        /// </summary>
        [XmlEnum("potential difference per power drop")]
        potentialdifferenceperpowerdrop,
        /// <summary>
        /// power property
        /// </summary>
        power,
        /// <summary>
        /// powerperarea property
        /// </summary>
        [XmlEnum("power per area")]
        powerperarea,
        /// <summary>
        /// powerperpower property
        /// </summary>
        [XmlEnum("power per power")]
        powerperpower,
        /// <summary>
        /// powerpervolume property
        /// </summary>
        [XmlEnum("power per volume")]
        powerpervolume,
        /// <summary>
        /// pressure property
        /// </summary>
        pressure,
        /// <summary>
        /// pressureperpressure property
        /// </summary>
        [XmlEnum("pressure per pressure")]
        pressureperpressure,
        /// <summary>
        /// pressurepertime property
        /// </summary>
        [XmlEnum("pressure per time")]
        pressurepertime,
        /// <summary>
        /// pressurepervolume property
        /// </summary>
        [XmlEnum("pressure per volume")]
        pressurepervolume,
        /// <summary>
        /// pressuresquared property
        /// </summary>
        [XmlEnum("pressure squared")]
        pressuresquared,
        /// <summary>
        /// pressuresquaredperforcetimeperarea property
        /// </summary>
        [XmlEnum("pressure squared per force time per area")]
        pressuresquaredperforcetimeperarea,
        /// <summary>
        /// pressuretimepervolume property
        /// </summary>
        [XmlEnum("pressure time per volume")]
        pressuretimepervolume,
        /// <summary>
        /// quantityoflight property
        /// </summary>
        [XmlEnum("quantity of light")]
        quantityoflight,
        /// <summary>
        /// radiance property
        /// </summary>
        radiance,
        /// <summary>
        /// radiantintensity property
        /// </summary>
        [XmlEnum("radiant intensity")]
        radiantintensity,
        /// <summary>
        /// reciprocalarea property
        /// </summary>
        [XmlEnum("reciprocal area")]
        reciprocalarea,
        /// <summary>
        /// reciprocalelectricpotentialdifference property
        /// </summary>
        [XmlEnum("reciprocal electric potential difference")]
        reciprocalelectricpotentialdifference,
        /// <summary>
        /// reciprocalforce property
        /// </summary>
        [XmlEnum("reciprocal force")]
        reciprocalforce,
        /// <summary>
        /// reciprocallength property
        /// </summary>
        [XmlEnum("reciprocal length")]
        reciprocallength,
        /// <summary>
        /// reciprocalmass property
        /// </summary>
        [XmlEnum("reciprocal mass")]
        reciprocalmass,
        /// <summary>
        /// reciprocalmasstime property
        /// </summary>
        [XmlEnum("reciprocal mass time")]
        reciprocalmasstime,
        /// <summary>
        /// reciprocalpressure property
        /// </summary>
        [XmlEnum("reciprocal pressure")]
        reciprocalpressure,
        /// <summary>
        /// reciprocaltime property
        /// </summary>
        [XmlEnum("reciprocal time")]
        reciprocaltime,
        /// <summary>
        /// reciprocalvolume property
        /// </summary>
        [XmlEnum("reciprocal volume")]
        reciprocalvolume,
        /// <summary>
        /// reluctance property
        /// </summary>
        reluctance,
        /// <summary>
        /// secondmomentofarea property
        /// </summary>
        [XmlEnum("second moment of area")]
        secondmomentofarea,
        /// <summary>
        /// signalingeventpertime property
        /// </summary>
        [XmlEnum("signaling event per time")]
        signalingeventpertime,
        /// <summary>
        /// solidangle property
        /// </summary>
        [XmlEnum("solid angle")]
        solidangle,
        /// <summary>
        /// specificheatcapacity property
        /// </summary>
        [XmlEnum("specific heat capacity")]
        specificheatcapacity,
        /// <summary>
        /// temperatureinterval property
        /// </summary>
        [XmlEnum("temperature interval")]
        temperatureinterval,
        /// <summary>
        /// temperatureintervalperlength property
        /// </summary>
        [XmlEnum("temperature interval per length")]
        temperatureintervalperlength,
        /// <summary>
        /// temperatureintervalperpressure property
        /// </summary>
        [XmlEnum("temperature interval per pressure")]
        temperatureintervalperpressure,
        /// <summary>
        /// temperatureintervalpertime property
        /// </summary>
        [XmlEnum("temperature interval per time")]
        temperatureintervalpertime,
        /// <summary>
        /// thermalconductance property
        /// </summary>
        [XmlEnum("thermal conductance")]
        thermalconductance,
        /// <summary>
        /// thermalconductivity property
        /// </summary>
        [XmlEnum("thermal conductivity")]
        thermalconductivity,
        /// <summary>
        /// thermaldiffusivity property
        /// </summary>
        [XmlEnum("thermal diffusivity")]
        thermaldiffusivity,
        /// <summary>
        /// thermalinsulance property
        /// </summary>
        [XmlEnum("thermal insulance")]
        thermalinsulance,
        /// <summary>
        /// thermalresistance property
        /// </summary>
        [XmlEnum("thermal resistance")]
        thermalresistance,
        /// <summary>
        /// thermodynamictemperature property
        /// </summary>
        [XmlEnum("thermodynamic temperature")]
        thermodynamictemperature,
        /// <summary>
        /// thermodynamictemperatureperthermodynamictemperature property
        /// </summary>
        [XmlEnum("thermodynamic temperature per thermodynamic temperature")]
        thermodynamictemperatureperthermodynamictemperature,
        /// <summary>
        /// time property
        /// </summary>
        time,
        /// <summary>
        /// timeperlength property
        /// </summary>
        [XmlEnum("time per length")]
        timeperlength,
        /// <summary>
        /// timepermass property
        /// </summary>
        [XmlEnum("time per mass")]
        timepermass,
        /// <summary>
        /// timepertime property
        /// </summary>
        [XmlEnum("time per time")]
        timepertime,
        /// <summary>
        /// timepervolume property
        /// </summary>
        [XmlEnum("time per volume")]
        timepervolume,
        /// <summary>
        /// verticalcoordinate property
        /// </summary>
        [XmlEnum("vertical coordinate")]
        verticalcoordinate,
        /// <summary>
        /// volume property
        /// </summary>
        volume,
        /// <summary>
        /// volumeflowratepervolumeflowrate property
        /// </summary>
        [XmlEnum("volume flow rate per volume flow rate")]
        volumeflowratepervolumeflowrate,
        /// <summary>
        /// volumeperarea property
        /// </summary>
        [XmlEnum("volume per area")]
        volumeperarea,
        /// <summary>
        /// volumeperlength property
        /// </summary>
        [XmlEnum("volume per length")]
        volumeperlength,
        /// <summary>
        /// volumepermass property
        /// </summary>
        [XmlEnum("volume per mass")]
        volumepermass,
        /// <summary>
        /// volumeperpressure property
        /// </summary>
        [XmlEnum("volume per pressure")]
        volumeperpressure,
        /// <summary>
        /// volumeperrotation property
        /// </summary>
        [XmlEnum("volume per rotation")]
        volumeperrotation,
        /// <summary>
        /// volumepertime property
        /// </summary>
        [XmlEnum("volume per time")]
        volumepertime,
        /// <summary>
        /// volumepertimelength property
        /// </summary>
        [XmlEnum("volume per time length")]
        volumepertimelength,
        /// <summary>
        /// volumepertimeperarea property
        /// </summary>
        [XmlEnum("volume per time per area")]
        volumepertimeperarea,
        /// <summary>
        /// volumepertimeperlength property
        /// </summary>
        [XmlEnum("volume per time per length")]
        volumepertimeperlength,
        /// <summary>
        /// volumepertimeperpressure property
        /// </summary>
        [XmlEnum("volume per time per pressure")]
        volumepertimeperpressure,
        /// <summary>
        /// volumepertimeperpressurelength property
        /// </summary>
        [XmlEnum("volume per time per pressure length")]
        volumepertimeperpressurelength,
        /// <summary>
        /// volumepertimepertime property
        /// </summary>
        [XmlEnum("volume per time per time")]
        volumepertimepertime,
        /// <summary>
        /// volumepertimepervolume property
        /// </summary>
        [XmlEnum("volume per time per volume")]
        volumepertimepervolume,
        /// <summary>
        /// volumepervolume property
        /// </summary>
        [XmlEnum("volume per volume")]
        volumepervolume,
        /// <summary>
        /// volumetricheattransfercoefficient property
        /// </summary>
        [XmlEnum("volumetric heat transfer coefficient")]
        volumetricheattransfercoefficient,
        /// <summary>
        /// volumetricthermalexpansion property
        /// </summary>
        [XmlEnum("volumetric thermal expansion")]
        volumetricthermalexpansion,
        /// <summary>
        /// unitless property
        /// </summary>
        unitless
    }
    /// <summary>
    /// This class represents the LithostratigraphicRank xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LithostratigraphicRank xsd enumeration.")]
    public enum LithostratigraphicRank
    {
        /// <summary>
        /// group property
        /// </summary>
        group,
        /// <summary>
        /// formation property
        /// </summary>
        formation,
        /// <summary>
        /// member property
        /// </summary>
        member,
        /// <summary>
        /// bed property
        /// </summary>
        bed
    }
    /// <summary>
    /// This class represents the WellboreDatumReference xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the WellboreDatumReference xsd enumeration.")]
    public enum WellboreDatumReference
    {
        /// <summary>
        /// groundlevel property
        /// </summary>
        [XmlEnum("ground level")]
        groundlevel,
        /// <summary>
        /// kellybushing property
        /// </summary>
        [XmlEnum("kelly bushing")]
        kellybushing,
        /// <summary>
        /// meansealevel property
        /// </summary>
        [XmlEnum("mean sea level")]
        meansealevel,
        /// <summary>
        /// derrickfloor property
        /// </summary>
        [XmlEnum("derrick floor")]
        derrickfloor,
        /// <summary>
        /// casingflange property
        /// </summary>
        [XmlEnum("casing flange")]
        casingflange,
        /// <summary>
        /// crownvalve property
        /// </summary>
        [XmlEnum("crown valve")]
        crownvalve,
        /// <summary>
        /// rotarybushing property
        /// </summary>
        [XmlEnum("rotary bushing")]
        rotarybushing,
        /// <summary>
        /// rotarytable property
        /// </summary>
        [XmlEnum("rotary table")]
        rotarytable,
        /// <summary>
        /// seafloor property
        /// </summary>
        [XmlEnum("sea floor")]
        seafloor,
        /// <summary>
        /// lowestastronomicaltide property
        /// </summary>
        [XmlEnum("lowest astronomical tide")]
        lowestastronomicaltide,
        /// <summary>
        /// meanhigherhighwater property
        /// </summary>
        [XmlEnum("mean higher high water")]
        meanhigherhighwater,
        /// <summary>
        /// meanhighwater property
        /// </summary>
        [XmlEnum("mean high water")]
        meanhighwater,
        /// <summary>
        /// meanlowerlowwater property
        /// </summary>
        [XmlEnum("mean lower low water")]
        meanlowerlowwater,
        /// <summary>
        /// meanlowwater property
        /// </summary>
        [XmlEnum("mean low water")]
        meanlowwater,
        /// <summary>
        /// meantidelevel property
        /// </summary>
        [XmlEnum("mean tide level")]
        meantidelevel,
        /// <summary>
        /// kickoffpoint property
        /// </summary>
        [XmlEnum("kickoff point")]
        kickoffpoint
    }
    /// <summary>
    /// This class represents the QuantityClassKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the QuantityClassKind xsd enumeration.")]
    public enum QuantityClassKind
    {
        /// <summary>
        /// absorbeddose property
        /// </summary>
        [XmlEnum("absorbed dose")]
        absorbeddose,
        /// <summary>
        /// activityofradioactivity property
        /// </summary>
        [XmlEnum("activity of radioactivity")]
        activityofradioactivity,
        /// <summary>
        /// amountofsubstance property
        /// </summary>
        [XmlEnum("amount of substance")]
        amountofsubstance,
        /// <summary>
        /// amountofsubstanceperamountofsubstance property
        /// </summary>
        [XmlEnum("amount of substance per amount of substance")]
        amountofsubstanceperamountofsubstance,
        /// <summary>
        /// amountofsubstanceperarea property
        /// </summary>
        [XmlEnum("amount of substance per area")]
        amountofsubstanceperarea,
        /// <summary>
        /// amountofsubstancepertime property
        /// </summary>
        [XmlEnum("amount of substance per time")]
        amountofsubstancepertime,
        /// <summary>
        /// amountofsubstancepertimeperarea property
        /// </summary>
        [XmlEnum("amount of substance per time per area")]
        amountofsubstancepertimeperarea,
        /// <summary>
        /// amountofsubstancepervolume property
        /// </summary>
        [XmlEnum("amount of substance per volume")]
        amountofsubstancepervolume,
        /// <summary>
        /// angleperlength property
        /// </summary>
        [XmlEnum("angle per length")]
        angleperlength,
        /// <summary>
        /// anglepervolume property
        /// </summary>
        [XmlEnum("angle per volume")]
        anglepervolume,
        /// <summary>
        /// angularacceleration property
        /// </summary>
        [XmlEnum("angular acceleration")]
        angularacceleration,
        /// <summary>
        /// angularvelocity property
        /// </summary>
        [XmlEnum("angular velocity")]
        angularvelocity,
        /// <summary>
        /// apigammaray property
        /// </summary>
        [XmlEnum("api gamma ray")]
        apigammaray,
        /// <summary>
        /// apigravity property
        /// </summary>
        [XmlEnum("api gravity")]
        apigravity,
        /// <summary>
        /// apineutron property
        /// </summary>
        [XmlEnum("api neutron")]
        apineutron,
        /// <summary>
        /// area property
        /// </summary>
        area,
        /// <summary>
        /// areaperamountofsubstance property
        /// </summary>
        [XmlEnum("area per amount of substance")]
        areaperamountofsubstance,
        /// <summary>
        /// areaperarea property
        /// </summary>
        [XmlEnum("area per area")]
        areaperarea,
        /// <summary>
        /// areapercount property
        /// </summary>
        [XmlEnum("area per count")]
        areapercount,
        /// <summary>
        /// areapermass property
        /// </summary>
        [XmlEnum("area per mass")]
        areapermass,
        /// <summary>
        /// areapertime property
        /// </summary>
        [XmlEnum("area per time")]
        areapertime,
        /// <summary>
        /// areapervolume property
        /// </summary>
        [XmlEnum("area per volume")]
        areapervolume,
        /// <summary>
        /// attenuationperfrequencyinterval property
        /// </summary>
        [XmlEnum("attenuation per frequency interval")]
        attenuationperfrequencyinterval,
        /// <summary>
        /// capacitance property
        /// </summary>
        capacitance,
        /// <summary>
        /// cationexchangecapacity property
        /// </summary>
        [XmlEnum("cation exchange capacity")]
        cationexchangecapacity,
        /// <summary>
        /// datatransferspeed property
        /// </summary>
        [XmlEnum("data transfer speed")]
        datatransferspeed,
        /// <summary>
        /// diffusioncoefficient property
        /// </summary>
        [XmlEnum("diffusion coefficient")]
        diffusioncoefficient,
        /// <summary>
        /// diffusivetimeofflight property
        /// </summary>
        [XmlEnum("diffusive time of flight")]
        diffusivetimeofflight,
        /// <summary>
        /// digitalstorage property
        /// </summary>
        [XmlEnum("digital storage")]
        digitalstorage,
        /// <summary>
        /// dimensionless property
        /// </summary>
        dimensionless,
        /// <summary>
        /// dipolemoment property
        /// </summary>
        [XmlEnum("dipole moment")]
        dipolemoment,
        /// <summary>
        /// doseequivalent property
        /// </summary>
        [XmlEnum("dose equivalent")]
        doseequivalent,
        /// <summary>
        /// dynamicviscosity property
        /// </summary>
        [XmlEnum("dynamic viscosity")]
        dynamicviscosity,
        /// <summary>
        /// electriccharge property
        /// </summary>
        [XmlEnum("electric charge")]
        electriccharge,
        /// <summary>
        /// electricchargeperarea property
        /// </summary>
        [XmlEnum("electric charge per area")]
        electricchargeperarea,
        /// <summary>
        /// electricchargepermass property
        /// </summary>
        [XmlEnum("electric charge per mass")]
        electricchargepermass,
        /// <summary>
        /// electricchargepervolume property
        /// </summary>
        [XmlEnum("electric charge per volume")]
        electricchargepervolume,
        /// <summary>
        /// electricconductance property
        /// </summary>
        [XmlEnum("electric conductance")]
        electricconductance,
        /// <summary>
        /// electricconductivity property
        /// </summary>
        [XmlEnum("electric conductivity")]
        electricconductivity,
        /// <summary>
        /// electriccurrent property
        /// </summary>
        [XmlEnum("electric current")]
        electriccurrent,
        /// <summary>
        /// electriccurrentdensity property
        /// </summary>
        [XmlEnum("electric current density")]
        electriccurrentdensity,
        /// <summary>
        /// electricfieldstrength property
        /// </summary>
        [XmlEnum("electric field strength")]
        electricfieldstrength,
        /// <summary>
        /// electricpotentialdifference property
        /// </summary>
        [XmlEnum("electric potential difference")]
        electricpotentialdifference,
        /// <summary>
        /// electricresistance property
        /// </summary>
        [XmlEnum("electric resistance")]
        electricresistance,
        /// <summary>
        /// electricresistanceperlength property
        /// </summary>
        [XmlEnum("electric resistance per length")]
        electricresistanceperlength,
        /// <summary>
        /// electricalresistivity property
        /// </summary>
        [XmlEnum("electrical resistivity")]
        electricalresistivity,
        /// <summary>
        /// electromagneticmoment property
        /// </summary>
        [XmlEnum("electromagnetic moment")]
        electromagneticmoment,
        /// <summary>
        /// energy property
        /// </summary>
        energy,
        /// <summary>
        /// energylengthperarea property
        /// </summary>
        [XmlEnum("energy length per area")]
        energylengthperarea,
        /// <summary>
        /// energylengthpertimeareatemperature property
        /// </summary>
        [XmlEnum("energy length per time area temperature")]
        energylengthpertimeareatemperature,
        /// <summary>
        /// energyperarea property
        /// </summary>
        [XmlEnum("energy per area")]
        energyperarea,
        /// <summary>
        /// energyperlength property
        /// </summary>
        [XmlEnum("energy per length")]
        energyperlength,
        /// <summary>
        /// energypermass property
        /// </summary>
        [XmlEnum("energy per mass")]
        energypermass,
        /// <summary>
        /// energypermasspertime property
        /// </summary>
        [XmlEnum("energy per mass per time")]
        energypermasspertime,
        /// <summary>
        /// energypervolume property
        /// </summary>
        [XmlEnum("energy per volume")]
        energypervolume,
        /// <summary>
        /// force property
        /// </summary>
        force,
        /// <summary>
        /// forcearea property
        /// </summary>
        [XmlEnum("force area")]
        forcearea,
        /// <summary>
        /// forcelengthperlength property
        /// </summary>
        [XmlEnum("force length per length")]
        forcelengthperlength,
        /// <summary>
        /// forceperforce property
        /// </summary>
        [XmlEnum("force per force")]
        forceperforce,
        /// <summary>
        /// forceperlength property
        /// </summary>
        [XmlEnum("force per length")]
        forceperlength,
        /// <summary>
        /// forcepervolume property
        /// </summary>
        [XmlEnum("force per volume")]
        forcepervolume,
        /// <summary>
        /// frequency property
        /// </summary>
        frequency,
        /// <summary>
        /// frequencyinterval property
        /// </summary>
        [XmlEnum("frequency interval")]
        frequencyinterval,
        /// <summary>
        /// heatcapacity property
        /// </summary>
        [XmlEnum("heat capacity")]
        heatcapacity,
        /// <summary>
        /// heatflowrate property
        /// </summary>
        [XmlEnum("heat flow rate")]
        heatflowrate,
        /// <summary>
        /// heattransfercoefficient property
        /// </summary>
        [XmlEnum("heat transfer coefficient")]
        heattransfercoefficient,
        /// <summary>
        /// illuminance property
        /// </summary>
        illuminance,
        /// <summary>
        /// inductance property
        /// </summary>
        inductance,
        /// <summary>
        /// isothermalcompressibility property
        /// </summary>
        [XmlEnum("isothermal compressibility")]
        isothermalcompressibility,
        /// <summary>
        /// kinematicviscosity property
        /// </summary>
        [XmlEnum("kinematic viscosity")]
        kinematicviscosity,
        /// <summary>
        /// length property
        /// </summary>
        length,
        /// <summary>
        /// lengthperlength property
        /// </summary>
        [XmlEnum("length per length")]
        lengthperlength,
        /// <summary>
        /// lengthpermass property
        /// </summary>
        [XmlEnum("length per mass")]
        lengthpermass,
        /// <summary>
        /// lengthperpressure property
        /// </summary>
        [XmlEnum("length per pressure")]
        lengthperpressure,
        /// <summary>
        /// lengthpertemperature property
        /// </summary>
        [XmlEnum("length per temperature")]
        lengthpertemperature,
        /// <summary>
        /// lengthpertime property
        /// </summary>
        [XmlEnum("length per time")]
        lengthpertime,
        /// <summary>
        /// lengthpervolume property
        /// </summary>
        [XmlEnum("length per volume")]
        lengthpervolume,
        /// <summary>
        /// lightexposure property
        /// </summary>
        [XmlEnum("light exposure")]
        lightexposure,
        /// <summary>
        /// linearacceleration property
        /// </summary>
        [XmlEnum("linear acceleration")]
        linearacceleration,
        /// <summary>
        /// linearthermalexpansion property
        /// </summary>
        [XmlEnum("linear thermal expansion")]
        linearthermalexpansion,
        /// <summary>
        /// logarithmicpowerratio property
        /// </summary>
        [XmlEnum("logarithmic power ratio")]
        logarithmicpowerratio,
        /// <summary>
        /// logarithmicpowerratioperlength property
        /// </summary>
        [XmlEnum("logarithmic power ratio per length")]
        logarithmicpowerratioperlength,
        /// <summary>
        /// luminance property
        /// </summary>
        luminance,
        /// <summary>
        /// luminousefficacy property
        /// </summary>
        [XmlEnum("luminous efficacy")]
        luminousefficacy,
        /// <summary>
        /// luminousflux property
        /// </summary>
        [XmlEnum("luminous flux")]
        luminousflux,
        /// <summary>
        /// luminousintensity property
        /// </summary>
        [XmlEnum("luminous intensity")]
        luminousintensity,
        /// <summary>
        /// magneticdipolemoment property
        /// </summary>
        [XmlEnum("magnetic dipole moment")]
        magneticdipolemoment,
        /// <summary>
        /// magneticfieldstrength property
        /// </summary>
        [XmlEnum("magnetic field strength")]
        magneticfieldstrength,
        /// <summary>
        /// magneticflux property
        /// </summary>
        [XmlEnum("magnetic flux")]
        magneticflux,
        /// <summary>
        /// magneticfluxdensity property
        /// </summary>
        [XmlEnum("magnetic flux density")]
        magneticfluxdensity,
        /// <summary>
        /// magneticfluxdensityperlength property
        /// </summary>
        [XmlEnum("magnetic flux density per length")]
        magneticfluxdensityperlength,
        /// <summary>
        /// magneticpermeability property
        /// </summary>
        [XmlEnum("magnetic permeability")]
        magneticpermeability,
        /// <summary>
        /// magneticvectorpotential property
        /// </summary>
        [XmlEnum("magnetic vector potential")]
        magneticvectorpotential,
        /// <summary>
        /// mass property
        /// </summary>
        mass,
        /// <summary>
        /// masslength property
        /// </summary>
        [XmlEnum("mass length")]
        masslength,
        /// <summary>
        /// massperarea property
        /// </summary>
        [XmlEnum("mass per area")]
        massperarea,
        /// <summary>
        /// massperenergy property
        /// </summary>
        [XmlEnum("mass per energy")]
        massperenergy,
        /// <summary>
        /// massperlength property
        /// </summary>
        [XmlEnum("mass per length")]
        massperlength,
        /// <summary>
        /// masspermass property
        /// </summary>
        [XmlEnum("mass per mass")]
        masspermass,
        /// <summary>
        /// masspertime property
        /// </summary>
        [XmlEnum("mass per time")]
        masspertime,
        /// <summary>
        /// masspertimeperarea property
        /// </summary>
        [XmlEnum("mass per time per area")]
        masspertimeperarea,
        /// <summary>
        /// masspertimeperlength property
        /// </summary>
        [XmlEnum("mass per time per length")]
        masspertimeperlength,
        /// <summary>
        /// masspervolume property
        /// </summary>
        [XmlEnum("mass per volume")]
        masspervolume,
        /// <summary>
        /// masspervolumeperlength property
        /// </summary>
        [XmlEnum("mass per volume per length")]
        masspervolumeperlength,
        /// <summary>
        /// masspervolumeperpressure property
        /// </summary>
        [XmlEnum("mass per volume per pressure")]
        masspervolumeperpressure,
        /// <summary>
        /// masspervolumepertemperature property
        /// </summary>
        [XmlEnum("mass per volume per temperature")]
        masspervolumepertemperature,
        /// <summary>
        /// mobility property
        /// </summary>
        mobility,
        /// <summary>
        /// molarenergy property
        /// </summary>
        [XmlEnum("molar energy")]
        molarenergy,
        /// <summary>
        /// molarheatcapacity property
        /// </summary>
        [XmlEnum("molar heat capacity")]
        molarheatcapacity,
        /// <summary>
        /// molarvolume property
        /// </summary>
        [XmlEnum("molar volume")]
        molarvolume,
        /// <summary>
        /// molecularweight property
        /// </summary>
        [XmlEnum("molecular weight")]
        molecularweight,
        /// <summary>
        /// momentofforce property
        /// </summary>
        [XmlEnum("moment of force")]
        momentofforce,
        /// <summary>
        /// momentofinertia property
        /// </summary>
        [XmlEnum("moment of inertia")]
        momentofinertia,
        /// <summary>
        /// momentum property
        /// </summary>
        momentum,
        /// <summary>
        /// normalizedpower property
        /// </summary>
        [XmlEnum("normalized power")]
        normalizedpower,
        /// <summary>
        /// permeabilitylength property
        /// </summary>
        [XmlEnum("permeability length")]
        permeabilitylength,
        /// <summary>
        /// permeabilityrock property
        /// </summary>
        [XmlEnum("permeability rock")]
        permeabilityrock,
        /// <summary>
        /// permittivity property
        /// </summary>
        permittivity,
        /// <summary>
        /// planeangle property
        /// </summary>
        [XmlEnum("plane angle")]
        planeangle,
        /// <summary>
        /// potentialdifferenceperpowerdrop property
        /// </summary>
        [XmlEnum("potential difference per power drop")]
        potentialdifferenceperpowerdrop,
        /// <summary>
        /// power property
        /// </summary>
        power,
        /// <summary>
        /// powerperarea property
        /// </summary>
        [XmlEnum("power per area")]
        powerperarea,
        /// <summary>
        /// powerperpower property
        /// </summary>
        [XmlEnum("power per power")]
        powerperpower,
        /// <summary>
        /// powerpervolume property
        /// </summary>
        [XmlEnum("power per volume")]
        powerpervolume,
        /// <summary>
        /// pressure property
        /// </summary>
        pressure,
        /// <summary>
        /// pressureperpressure property
        /// </summary>
        [XmlEnum("pressure per pressure")]
        pressureperpressure,
        /// <summary>
        /// pressurepertime property
        /// </summary>
        [XmlEnum("pressure per time")]
        pressurepertime,
        /// <summary>
        /// pressurepervolume property
        /// </summary>
        [XmlEnum("pressure per volume")]
        pressurepervolume,
        /// <summary>
        /// pressuresquared property
        /// </summary>
        [XmlEnum("pressure squared")]
        pressuresquared,
        /// <summary>
        /// pressuresquaredperforcetimeperarea property
        /// </summary>
        [XmlEnum("pressure squared per force time per area")]
        pressuresquaredperforcetimeperarea,
        /// <summary>
        /// pressuretimepervolume property
        /// </summary>
        [XmlEnum("pressure time per volume")]
        pressuretimepervolume,
        /// <summary>
        /// quantityoflight property
        /// </summary>
        [XmlEnum("quantity of light")]
        quantityoflight,
        /// <summary>
        /// radiance property
        /// </summary>
        radiance,
        /// <summary>
        /// radiantintensity property
        /// </summary>
        [XmlEnum("radiant intensity")]
        radiantintensity,
        /// <summary>
        /// reciprocalarea property
        /// </summary>
        [XmlEnum("reciprocal area")]
        reciprocalarea,
        /// <summary>
        /// reciprocalelectricpotentialdifference property
        /// </summary>
        [XmlEnum("reciprocal electric potential difference")]
        reciprocalelectricpotentialdifference,
        /// <summary>
        /// reciprocalforce property
        /// </summary>
        [XmlEnum("reciprocal force")]
        reciprocalforce,
        /// <summary>
        /// reciprocallength property
        /// </summary>
        [XmlEnum("reciprocal length")]
        reciprocallength,
        /// <summary>
        /// reciprocalmass property
        /// </summary>
        [XmlEnum("reciprocal mass")]
        reciprocalmass,
        /// <summary>
        /// reciprocalmasstime property
        /// </summary>
        [XmlEnum("reciprocal mass time")]
        reciprocalmasstime,
        /// <summary>
        /// reciprocalpressure property
        /// </summary>
        [XmlEnum("reciprocal pressure")]
        reciprocalpressure,
        /// <summary>
        /// reciprocaltime property
        /// </summary>
        [XmlEnum("reciprocal time")]
        reciprocaltime,
        /// <summary>
        /// reciprocalvolume property
        /// </summary>
        [XmlEnum("reciprocal volume")]
        reciprocalvolume,
        /// <summary>
        /// reluctance property
        /// </summary>
        reluctance,
        /// <summary>
        /// secondmomentofarea property
        /// </summary>
        [XmlEnum("second moment of area")]
        secondmomentofarea,
        /// <summary>
        /// signalingeventpertime property
        /// </summary>
        [XmlEnum("signaling event per time")]
        signalingeventpertime,
        /// <summary>
        /// solidangle property
        /// </summary>
        [XmlEnum("solid angle")]
        solidangle,
        /// <summary>
        /// specificheatcapacity property
        /// </summary>
        [XmlEnum("specific heat capacity")]
        specificheatcapacity,
        /// <summary>
        /// temperatureinterval property
        /// </summary>
        [XmlEnum("temperature interval")]
        temperatureinterval,
        /// <summary>
        /// temperatureintervalperlength property
        /// </summary>
        [XmlEnum("temperature interval per length")]
        temperatureintervalperlength,
        /// <summary>
        /// temperatureintervalperpressure property
        /// </summary>
        [XmlEnum("temperature interval per pressure")]
        temperatureintervalperpressure,
        /// <summary>
        /// temperatureintervalpertime property
        /// </summary>
        [XmlEnum("temperature interval per time")]
        temperatureintervalpertime,
        /// <summary>
        /// thermalconductance property
        /// </summary>
        [XmlEnum("thermal conductance")]
        thermalconductance,
        /// <summary>
        /// thermalconductivity property
        /// </summary>
        [XmlEnum("thermal conductivity")]
        thermalconductivity,
        /// <summary>
        /// thermaldiffusivity property
        /// </summary>
        [XmlEnum("thermal diffusivity")]
        thermaldiffusivity,
        /// <summary>
        /// thermalinsulance property
        /// </summary>
        [XmlEnum("thermal insulance")]
        thermalinsulance,
        /// <summary>
        /// thermalresistance property
        /// </summary>
        [XmlEnum("thermal resistance")]
        thermalresistance,
        /// <summary>
        /// thermodynamictemperature property
        /// </summary>
        [XmlEnum("thermodynamic temperature")]
        thermodynamictemperature,
        /// <summary>
        /// thermodynamictemperatureperthermodynamictemperature property
        /// </summary>
        [XmlEnum("thermodynamic temperature per thermodynamic temperature")]
        thermodynamictemperatureperthermodynamictemperature,
        /// <summary>
        /// time property
        /// </summary>
        time,
        /// <summary>
        /// timeperlength property
        /// </summary>
        [XmlEnum("time per length")]
        timeperlength,
        /// <summary>
        /// timepermass property
        /// </summary>
        [XmlEnum("time per mass")]
        timepermass,
        /// <summary>
        /// timepertime property
        /// </summary>
        [XmlEnum("time per time")]
        timepertime,
        /// <summary>
        /// timepervolume property
        /// </summary>
        [XmlEnum("time per volume")]
        timepervolume,
        /// <summary>
        /// verticalcoordinate property
        /// </summary>
        [XmlEnum("vertical coordinate")]
        verticalcoordinate,
        /// <summary>
        /// volume property
        /// </summary>
        volume,
        /// <summary>
        /// volumeflowratepervolumeflowrate property
        /// </summary>
        [XmlEnum("volume flow rate per volume flow rate")]
        volumeflowratepervolumeflowrate,
        /// <summary>
        /// volumeperarea property
        /// </summary>
        [XmlEnum("volume per area")]
        volumeperarea,
        /// <summary>
        /// volumeperlength property
        /// </summary>
        [XmlEnum("volume per length")]
        volumeperlength,
        /// <summary>
        /// volumepermass property
        /// </summary>
        [XmlEnum("volume per mass")]
        volumepermass,
        /// <summary>
        /// volumeperpressure property
        /// </summary>
        [XmlEnum("volume per pressure")]
        volumeperpressure,
        /// <summary>
        /// volumeperrotation property
        /// </summary>
        [XmlEnum("volume per rotation")]
        volumeperrotation,
        /// <summary>
        /// volumepertime property
        /// </summary>
        [XmlEnum("volume per time")]
        volumepertime,
        /// <summary>
        /// volumepertimelength property
        /// </summary>
        [XmlEnum("volume per time length")]
        volumepertimelength,
        /// <summary>
        /// volumepertimeperarea property
        /// </summary>
        [XmlEnum("volume per time per area")]
        volumepertimeperarea,
        /// <summary>
        /// volumepertimeperlength property
        /// </summary>
        [XmlEnum("volume per time per length")]
        volumepertimeperlength,
        /// <summary>
        /// volumepertimeperpressure property
        /// </summary>
        [XmlEnum("volume per time per pressure")]
        volumepertimeperpressure,
        /// <summary>
        /// volumepertimeperpressurelength property
        /// </summary>
        [XmlEnum("volume per time per pressure length")]
        volumepertimeperpressurelength,
        /// <summary>
        /// volumepertimepertime property
        /// </summary>
        [XmlEnum("volume per time per time")]
        volumepertimepertime,
        /// <summary>
        /// volumepertimepervolume property
        /// </summary>
        [XmlEnum("volume per time per volume")]
        volumepertimepervolume,
        /// <summary>
        /// volumepervolume property
        /// </summary>
        [XmlEnum("volume per volume")]
        volumepervolume,
        /// <summary>
        /// volumetricheattransfercoefficient property
        /// </summary>
        [XmlEnum("volumetric heat transfer coefficient")]
        volumetricheattransfercoefficient,
        /// <summary>
        /// volumetricthermalexpansion property
        /// </summary>
        [XmlEnum("volumetric thermal expansion")]
        volumetricthermalexpansion,
        /// <summary>
        /// unitless property
        /// </summary>
        unitless,
        /// <summary>
        /// notameasure property
        /// </summary>
        [XmlEnum("not a measure")]
        notameasure
    }
    /// <summary>
    /// This class represents the ReferenceCondition xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReferenceCondition xsd enumeration.")]
    public enum ReferenceCondition
    {
        /// <summary>
        /// Item0degC1atm property
        /// </summary>
        [XmlEnum("0 degC 1 atm")]
        Item0degC1atm,
        /// <summary>
        /// Item0degC1bar property
        /// </summary>
        [XmlEnum("0 degC 1 bar")]
        Item0degC1bar,
        /// <summary>
        /// Item15degC1atm property
        /// </summary>
        [XmlEnum("15 degC 1 atm")]
        Item15degC1atm,
        /// <summary>
        /// Item15degC1bar property
        /// </summary>
        [XmlEnum("15 degC 1 bar")]
        Item15degC1bar,
        /// <summary>
        /// Item20degC1atm property
        /// </summary>
        [XmlEnum("20 degC 1 atm")]
        Item20degC1atm,
        /// <summary>
        /// Item20degC1bar property
        /// </summary>
        [XmlEnum("20 degC 1 bar")]
        Item20degC1bar,
        /// <summary>
        /// Item25degC1bar property
        /// </summary>
        [XmlEnum("25 degC 1 bar")]
        Item25degC1bar,
        /// <summary>
        /// Item60degF1atm property
        /// </summary>
        [XmlEnum("60 degF 1 atm")]
        Item60degF1atm,
        /// <summary>
        /// Item60degF30inHg property
        /// </summary>
        [XmlEnum("60 degF 30 in Hg")]
        Item60degF30inHg,
        /// <summary>
        /// ambient property
        /// </summary>
        ambient
    }
    /// <summary>
    /// This class represents the LithologyQualifierKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LithologyQualifierKind xsd enumeration.")]
    public enum LithologyQualifierKind
    {
        /// <summary>
        /// alkalifeldsparrhyolite property
        /// </summary>
        [XmlEnum("alkali feldspar rhyolite")]
        alkalifeldsparrhyolite,
        /// <summary>
        /// alkaliolivinebasalt property
        /// </summary>
        [XmlEnum("alkali olivine basalt")]
        alkaliolivinebasalt,
        /// <summary>
        /// amphibolite property
        /// </summary>
        amphibolite,
        /// <summary>
        /// amphibolitic property
        /// </summary>
        amphibolitic,
        /// <summary>
        /// andesite property
        /// </summary>
        andesite,
        /// <summary>
        /// andesitic property
        /// </summary>
        andesitic,
        /// <summary>
        /// anhydrite property
        /// </summary>
        anhydrite,
        /// <summary>
        /// anhydritic property
        /// </summary>
        anhydritic,
        /// <summary>
        /// ankerite property
        /// </summary>
        ankerite,
        /// <summary>
        /// ankeritic property
        /// </summary>
        ankeritic,
        /// <summary>
        /// anorthositicrock property
        /// </summary>
        [XmlEnum("anorthositic rock")]
        anorthositicrock,
        /// <summary>
        /// anthracite property
        /// </summary>
        anthracite,
        /// <summary>
        /// anthracitic property
        /// </summary>
        anthracitic,
        /// <summary>
        /// aplite property
        /// </summary>
        aplite,
        /// <summary>
        /// aplitic property
        /// </summary>
        aplitic,
        /// <summary>
        /// arenite property
        /// </summary>
        arenite,
        /// <summary>
        /// arenitic property
        /// </summary>
        arenitic,
        /// <summary>
        /// argillaceous property
        /// </summary>
        argillaceous,
        /// <summary>
        /// arkose property
        /// </summary>
        arkose,
        /// <summary>
        /// arkosic property
        /// </summary>
        arkosic,
        /// <summary>
        /// barite property
        /// </summary>
        barite,
        /// <summary>
        /// baritic property
        /// </summary>
        baritic,
        /// <summary>
        /// basalt property
        /// </summary>
        basalt,
        /// <summary>
        /// basaltic property
        /// </summary>
        basaltic,
        /// <summary>
        /// basanite property
        /// </summary>
        basanite,
        /// <summary>
        /// basanitic property
        /// </summary>
        basanitic,
        /// <summary>
        /// bauxite property
        /// </summary>
        bauxite,
        /// <summary>
        /// bauxitic property
        /// </summary>
        bauxitic,
        /// <summary>
        /// belemnites property
        /// </summary>
        belemnites,
        /// <summary>
        /// belemnitic property
        /// </summary>
        belemnitic,
        /// <summary>
        /// bioturbated property
        /// </summary>
        bioturbated,
        /// <summary>
        /// bioturbation property
        /// </summary>
        bioturbation,
        /// <summary>
        /// bitumen property
        /// </summary>
        bitumen,
        /// <summary>
        /// bituminous property
        /// </summary>
        bituminous,
        /// <summary>
        /// bituminouscoal property
        /// </summary>
        [XmlEnum("bituminous coal")]
        bituminouscoal,
        /// <summary>
        /// blueschistmetamorphicrock property
        /// </summary>
        [XmlEnum("blueschist metamorphic rock")]
        blueschistmetamorphicrock,
        /// <summary>
        /// boninite property
        /// </summary>
        boninite,
        /// <summary>
        /// breccia property
        /// </summary>
        breccia,
        /// <summary>
        /// brecciated property
        /// </summary>
        brecciated,
        /// <summary>
        /// bryozoan property
        /// </summary>
        bryozoan,
        /// <summary>
        /// bryozoans property
        /// </summary>
        bryozoans,
        /// <summary>
        /// burrowed property
        /// </summary>
        burrowed,
        /// <summary>
        /// burrows property
        /// </summary>
        burrows,
        /// <summary>
        /// calcareous property
        /// </summary>
        calcareous,
        /// <summary>
        /// calcite property
        /// </summary>
        calcite,
        /// <summary>
        /// calciteconcretion property
        /// </summary>
        [XmlEnum("calcite concretion")]
        calciteconcretion,
        /// <summary>
        /// calcitic property
        /// </summary>
        calcitic,
        /// <summary>
        /// carbonaceous property
        /// </summary>
        carbonaceous,
        /// <summary>
        /// carbonateooze property
        /// </summary>
        [XmlEnum("carbonate ooze")]
        carbonateooze,
        /// <summary>
        /// carbonatite property
        /// </summary>
        carbonatite,
        /// <summary>
        /// carbonatitic property
        /// </summary>
        carbonatitic,
        /// <summary>
        /// chalk property
        /// </summary>
        chalk,
        /// <summary>
        /// chalky property
        /// </summary>
        chalky,
        /// <summary>
        /// chamosite property
        /// </summary>
        chamosite,
        /// <summary>
        /// chamositic property
        /// </summary>
        chamositic,
        /// <summary>
        /// chert property
        /// </summary>
        chert,
        /// <summary>
        /// cherty property
        /// </summary>
        cherty,
        /// <summary>
        /// chlorite property
        /// </summary>
        chlorite,
        /// <summary>
        /// chloritic property
        /// </summary>
        chloritic,
        /// <summary>
        /// clay property
        /// </summary>
        clay,
        /// <summary>
        /// claystone property
        /// </summary>
        claystone,
        /// <summary>
        /// coal property
        /// </summary>
        coal,
        /// <summary>
        /// concretionary property
        /// </summary>
        concretionary,
        /// <summary>
        /// concretions property
        /// </summary>
        concretions,
        /// <summary>
        /// conglomerate property
        /// </summary>
        conglomerate,
        /// <summary>
        /// conglomeratic property
        /// </summary>
        conglomeratic,
        /// <summary>
        /// coralfragments property
        /// </summary>
        [XmlEnum("coral fragments")]
        coralfragments,
        /// <summary>
        /// coralline property
        /// </summary>
        coralline,
        /// <summary>
        /// crinoidal property
        /// </summary>
        crinoidal,
        /// <summary>
        /// crinoids property
        /// </summary>
        crinoids,
        /// <summary>
        /// dacite property
        /// </summary>
        dacite,
        /// <summary>
        /// dacitic property
        /// </summary>
        dacitic,
        /// <summary>
        /// diabase property
        /// </summary>
        diabase,
        /// <summary>
        /// diabasic property
        /// </summary>
        diabasic,
        /// <summary>
        /// diamictite property
        /// </summary>
        diamictite,
        /// <summary>
        /// diamictitic property
        /// </summary>
        diamictitic,
        /// <summary>
        /// diatomaceous property
        /// </summary>
        diatomaceous,
        /// <summary>
        /// diatoms property
        /// </summary>
        diatoms,
        /// <summary>
        /// diorite property
        /// </summary>
        diorite,
        /// <summary>
        /// dioritic property
        /// </summary>
        dioritic,
        /// <summary>
        /// dioritoid property
        /// </summary>
        dioritoid,
        /// <summary>
        /// dioritoidic property
        /// </summary>
        dioritoidic,
        /// <summary>
        /// doleriticrock property
        /// </summary>
        [XmlEnum("doleritic rock")]
        doleriticrock,
        /// <summary>
        /// dolomite property
        /// </summary>
        dolomite,
        /// <summary>
        /// dolomiteconcretion property
        /// </summary>
        [XmlEnum("dolomite concretion")]
        dolomiteconcretion,
        /// <summary>
        /// dolomitestringer property
        /// </summary>
        [XmlEnum("dolomite stringer")]
        dolomitestringer,
        /// <summary>
        /// dolomitic property
        /// </summary>
        dolomitic,
        /// <summary>
        /// eclogite property
        /// </summary>
        eclogite,
        /// <summary>
        /// eclogitic property
        /// </summary>
        eclogitic,
        /// <summary>
        /// exoticalkalinerock property
        /// </summary>
        [XmlEnum("exotic alkaline rock")]
        exoticalkalinerock,
        /// <summary>
        /// feldspar property
        /// </summary>
        feldspar,
        /// <summary>
        /// feldsparic property
        /// </summary>
        feldsparic,
        /// <summary>
        /// feldspathic property
        /// </summary>
        feldspathic,
        /// <summary>
        /// feldspathicarenite property
        /// </summary>
        [XmlEnum("feldspathic arenite")]
        feldspathicarenite,
        /// <summary>
        /// ferruginous property
        /// </summary>
        ferruginous,
        /// <summary>
        /// finegrainedigneousrock property
        /// </summary>
        [XmlEnum("fine grained igneous rock")]
        finegrainedigneousrock,
        /// <summary>
        /// foiddioritoid property
        /// </summary>
        [XmlEnum("foid dioritoid")]
        foiddioritoid,
        /// <summary>
        /// foidgabbroid property
        /// </summary>
        [XmlEnum("foid gabbroid")]
        foidgabbroid,
        /// <summary>
        /// foidsyenitoid property
        /// </summary>
        [XmlEnum("foid syenitoid")]
        foidsyenitoid,
        /// <summary>
        /// foidite property
        /// </summary>
        foidite,
        /// <summary>
        /// foiditic property
        /// </summary>
        foiditic,
        /// <summary>
        /// foiditoid property
        /// </summary>
        foiditoid,
        /// <summary>
        /// foidolite property
        /// </summary>
        foidolite,
        /// <summary>
        /// foidolitic property
        /// </summary>
        foidolitic,
        /// <summary>
        /// foliatedmetamorphicrock property
        /// </summary>
        [XmlEnum("foliated metamorphic rock")]
        foliatedmetamorphicrock,
        /// <summary>
        /// foraminifera property
        /// </summary>
        foraminifera,
        /// <summary>
        /// foraminiferous property
        /// </summary>
        foraminiferous,
        /// <summary>
        /// forams property
        /// </summary>
        forams,
        /// <summary>
        /// fossilfragments property
        /// </summary>
        [XmlEnum("fossil fragments")]
        fossilfragments,
        /// <summary>
        /// fossiliferous property
        /// </summary>
        fossiliferous,
        /// <summary>
        /// fossilsundifferentiated property
        /// </summary>
        [XmlEnum("fossils undifferentiated")]
        fossilsundifferentiated,
        /// <summary>
        /// fragmentaligneousrock property
        /// </summary>
        [XmlEnum("fragmental igneous rock")]
        fragmentaligneousrock,
        /// <summary>
        /// gabbro property
        /// </summary>
        gabbro,
        /// <summary>
        /// gabbroic property
        /// </summary>
        gabbroic,
        /// <summary>
        /// gabbroicrock property
        /// </summary>
        [XmlEnum("gabbroic rock")]
        gabbroicrock,
        /// <summary>
        /// gabbroid property
        /// </summary>
        gabbroid,
        /// <summary>
        /// gabbroidic property
        /// </summary>
        gabbroidic,
        /// <summary>
        /// gilsonite property
        /// </summary>
        gilsonite,
        /// <summary>
        /// gilsonitic property
        /// </summary>
        gilsonitic,
        /// <summary>
        /// glauconite property
        /// </summary>
        glauconite,
        /// <summary>
        /// glauconitic property
        /// </summary>
        glauconitic,
        /// <summary>
        /// gneiss property
        /// </summary>
        gneiss,
        /// <summary>
        /// gneissic property
        /// </summary>
        gneissic,
        /// <summary>
        /// granite property
        /// </summary>
        granite,
        /// <summary>
        /// granitic property
        /// </summary>
        granitic,
        /// <summary>
        /// granodiorite property
        /// </summary>
        granodiorite,
        /// <summary>
        /// granodioritic property
        /// </summary>
        granodioritic,
        /// <summary>
        /// granofels property
        /// </summary>
        granofels,
        /// <summary>
        /// granulite property
        /// </summary>
        granulite,
        /// <summary>
        /// granulitic property
        /// </summary>
        granulitic,
        /// <summary>
        /// gravel property
        /// </summary>
        gravel,
        /// <summary>
        /// gravelly property
        /// </summary>
        gravelly,
        /// <summary>
        /// greenstone property
        /// </summary>
        greenstone,
        /// <summary>
        /// gumbo property
        /// </summary>
        gumbo,
        /// <summary>
        /// gypsiferous property
        /// </summary>
        gypsiferous,
        /// <summary>
        /// gypsum property
        /// </summary>
        gypsum,
        /// <summary>
        /// halite property
        /// </summary>
        halite,
        /// <summary>
        /// halitic property
        /// </summary>
        halitic,
        /// <summary>
        /// hornfels property
        /// </summary>
        hornfels,
        /// <summary>
        /// hornfelsic property
        /// </summary>
        hornfelsic,
        /// <summary>
        /// igneous property
        /// </summary>
        igneous,
        /// <summary>
        /// igneousrock property
        /// </summary>
        [XmlEnum("igneous rock")]
        igneousrock,
        /// <summary>
        /// illite property
        /// </summary>
        illite,
        /// <summary>
        /// illitic property
        /// </summary>
        illitic,
        /// <summary>
        /// impactgeneratedmaterial property
        /// </summary>
        [XmlEnum("impact generated material")]
        impactgeneratedmaterial,
        /// <summary>
        /// impuredolomite property
        /// </summary>
        [XmlEnum("impure dolomite")]
        impuredolomite,
        /// <summary>
        /// impurelimestone property
        /// </summary>
        [XmlEnum("impure limestone")]
        impurelimestone,
        /// <summary>
        /// intrusiverockplutonic property
        /// </summary>
        [XmlEnum("intrusive rock (plutonic)")]
        intrusiverockplutonic,
        /// <summary>
        /// ironrichsedimentaryrock property
        /// </summary>
        [XmlEnum("iron rich sedimentary rock")]
        ironrichsedimentaryrock,
        /// <summary>
        /// kalsiliticandmeliliticrocks property
        /// </summary>
        [XmlEnum("kalsilitic and melilitic rocks")]
        kalsiliticandmeliliticrocks,
        /// <summary>
        /// kaolinite property
        /// </summary>
        kaolinite,
        /// <summary>
        /// kaolinitic property
        /// </summary>
        kaolinitic,
        /// <summary>
        /// komatiiticrock property
        /// </summary>
        [XmlEnum("komatiitic rock")]
        komatiiticrock,
        /// <summary>
        /// latiticrock property
        /// </summary>
        [XmlEnum("latitic rock")]
        latiticrock,
        /// <summary>
        /// lignite property
        /// </summary>
        lignite,
        /// <summary>
        /// lignitic property
        /// </summary>
        lignitic,
        /// <summary>
        /// limeboundstone property
        /// </summary>
        [XmlEnum("lime boundstone")]
        limeboundstone,
        /// <summary>
        /// limeframestone property
        /// </summary>
        [XmlEnum("lime framestone")]
        limeframestone,
        /// <summary>
        /// limegrainstone property
        /// </summary>
        [XmlEnum("lime grainstone")]
        limegrainstone,
        /// <summary>
        /// limemudstone property
        /// </summary>
        [XmlEnum("lime mudstone")]
        limemudstone,
        /// <summary>
        /// limepackstone property
        /// </summary>
        [XmlEnum("lime packstone")]
        limepackstone,
        /// <summary>
        /// limewackestone property
        /// </summary>
        [XmlEnum("lime wackestone")]
        limewackestone,
        /// <summary>
        /// limestone property
        /// </summary>
        limestone,
        /// <summary>
        /// limestonestringer property
        /// </summary>
        [XmlEnum("limestone stringer")]
        limestonestringer,
        /// <summary>
        /// lithic property
        /// </summary>
        lithic,
        /// <summary>
        /// lithicfragments property
        /// </summary>
        [XmlEnum("lithic fragments")]
        lithicfragments,
        /// <summary>
        /// marble property
        /// </summary>
        marble,
        /// <summary>
        /// marcasite property
        /// </summary>
        marcasite,
        /// <summary>
        /// marcasitic property
        /// </summary>
        marcasitic,
        /// <summary>
        /// marl property
        /// </summary>
        marl,
        /// <summary>
        /// marly property
        /// </summary>
        marly,
        /// <summary>
        /// metamorphicrock property
        /// </summary>
        [XmlEnum("metamorphic rock")]
        metamorphicrock,
        /// <summary>
        /// mica property
        /// </summary>
        mica,
        /// <summary>
        /// micaschist property
        /// </summary>
        [XmlEnum("mica schist")]
        micaschist,
        /// <summary>
        /// micaceous property
        /// </summary>
        micaceous,
        /// <summary>
        /// microfossiliferous property
        /// </summary>
        microfossiliferous,
        /// <summary>
        /// microfossils property
        /// </summary>
        microfossils,
        /// <summary>
        /// migmatite property
        /// </summary>
        migmatite,
        /// <summary>
        /// migmatitic property
        /// </summary>
        migmatitic,
        /// <summary>
        /// monzogabbro property
        /// </summary>
        monzogabbro,
        /// <summary>
        /// monzogabbroic property
        /// </summary>
        monzogabbroic,
        /// <summary>
        /// mud property
        /// </summary>
        mud,
        /// <summary>
        /// muddy property
        /// </summary>
        muddy,
        /// <summary>
        /// mudstone property
        /// </summary>
        mudstone,
        /// <summary>
        /// myloniticrock property
        /// </summary>
        [XmlEnum("mylonitic rock")]
        myloniticrock,
        /// <summary>
        /// nosample property
        /// </summary>
        [XmlEnum("no sample")]
        nosample,
        /// <summary>
        /// oncolite property
        /// </summary>
        oncolite,
        /// <summary>
        /// oncoliths property
        /// </summary>
        oncoliths,
        /// <summary>
        /// oncolitic property
        /// </summary>
        oncolitic,
        /// <summary>
        /// ooids property
        /// </summary>
        ooids,
        /// <summary>
        /// ooliths property
        /// </summary>
        ooliths,
        /// <summary>
        /// oolitic property
        /// </summary>
        oolitic,
        /// <summary>
        /// ooze property
        /// </summary>
        ooze,
        /// <summary>
        /// ophiolite property
        /// </summary>
        ophiolite,
        /// <summary>
        /// ophiolitic property
        /// </summary>
        ophiolitic,
        /// <summary>
        /// organicbearingmudstone property
        /// </summary>
        [XmlEnum("organic bearing mudstone")]
        organicbearingmudstone,
        /// <summary>
        /// ostracodal property
        /// </summary>
        ostracodal,
        /// <summary>
        /// ostracods property
        /// </summary>
        ostracods,
        /// <summary>
        /// peat property
        /// </summary>
        peat,
        /// <summary>
        /// peaty property
        /// </summary>
        peaty,
        /// <summary>
        /// pebble property
        /// </summary>
        pebble,
        /// <summary>
        /// pebbly property
        /// </summary>
        pebbly,
        /// <summary>
        /// pegmatite property
        /// </summary>
        pegmatite,
        /// <summary>
        /// pegmatitic property
        /// </summary>
        pegmatitic,
        /// <summary>
        /// pelletal property
        /// </summary>
        pelletal,
        /// <summary>
        /// pellets property
        /// </summary>
        pellets,
        /// <summary>
        /// peloidal property
        /// </summary>
        peloidal,
        /// <summary>
        /// peloids property
        /// </summary>
        peloids,
        /// <summary>
        /// peridotite property
        /// </summary>
        peridotite,
        /// <summary>
        /// peridotitic property
        /// </summary>
        peridotitic,
        /// <summary>
        /// phaneriticigneousrock property
        /// </summary>
        [XmlEnum("phaneritic igneous rock")]
        phaneriticigneousrock,
        /// <summary>
        /// phonolite property
        /// </summary>
        phonolite,
        /// <summary>
        /// phonolitic property
        /// </summary>
        phonolitic,
        /// <summary>
        /// phonolitoid property
        /// </summary>
        phonolitoid,
        /// <summary>
        /// phosphate property
        /// </summary>
        phosphate,
        /// <summary>
        /// phosphaterock property
        /// </summary>
        [XmlEnum("phosphate rock")]
        phosphaterock,
        /// <summary>
        /// phosphatic property
        /// </summary>
        phosphatic,
        /// <summary>
        /// phyllite property
        /// </summary>
        phyllite,
        /// <summary>
        /// phyllitic property
        /// </summary>
        phyllitic,
        /// <summary>
        /// pisolite property
        /// </summary>
        pisolite,
        /// <summary>
        /// pisoliths property
        /// </summary>
        pisoliths,
        /// <summary>
        /// pisolitic property
        /// </summary>
        pisolitic,
        /// <summary>
        /// plantremains property
        /// </summary>
        [XmlEnum("plant remains")]
        plantremains,
        /// <summary>
        /// porphyritic property
        /// </summary>
        porphyritic,
        /// <summary>
        /// porphyry property
        /// </summary>
        porphyry,
        /// <summary>
        /// potassiumandmagnesiumsalts property
        /// </summary>
        [XmlEnum("potassium and magnesium salts")]
        potassiumandmagnesiumsalts,
        /// <summary>
        /// pyrite property
        /// </summary>
        pyrite,
        /// <summary>
        /// pyritic property
        /// </summary>
        pyritic,
        /// <summary>
        /// pyroclasticbreccia property
        /// </summary>
        [XmlEnum("pyroclastic breccia")]
        pyroclasticbreccia,
        /// <summary>
        /// pyroclasticrock property
        /// </summary>
        [XmlEnum("pyroclastic rock")]
        pyroclasticrock,
        /// <summary>
        /// pyroxenite property
        /// </summary>
        pyroxenite,
        /// <summary>
        /// pyroxenitic property
        /// </summary>
        pyroxenitic,
        /// <summary>
        /// quartiferous property
        /// </summary>
        quartiferous,
        /// <summary>
        /// quartz property
        /// </summary>
        quartz,
        /// <summary>
        /// quartzarenite property
        /// </summary>
        [XmlEnum("quartz arenite")]
        quartzarenite,
        /// <summary>
        /// quartzite property
        /// </summary>
        quartzite,
        /// <summary>
        /// quartzitic property
        /// </summary>
        quartzitic,
        /// <summary>
        /// radiolaria property
        /// </summary>
        radiolaria,
        /// <summary>
        /// radiolarian property
        /// </summary>
        radiolarian,
        /// <summary>
        /// rhyolite property
        /// </summary>
        rhyolite,
        /// <summary>
        /// rhyolitic property
        /// </summary>
        rhyolitic,
        /// <summary>
        /// rocksalt property
        /// </summary>
        [XmlEnum("rock salt")]
        rocksalt,
        /// <summary>
        /// rootlets property
        /// </summary>
        rootlets,
        /// <summary>
        /// salty property
        /// </summary>
        salty,
        /// <summary>
        /// sand property
        /// </summary>
        sand,
        /// <summary>
        /// sandstone property
        /// </summary>
        sandstone,
        /// <summary>
        /// sandy property
        /// </summary>
        sandy,
        /// <summary>
        /// sapropel property
        /// </summary>
        sapropel,
        /// <summary>
        /// sapropelic property
        /// </summary>
        sapropelic,
        /// <summary>
        /// schist property
        /// </summary>
        schist,
        /// <summary>
        /// schisty property
        /// </summary>
        schisty,
        /// <summary>
        /// sepentinitic property
        /// </summary>
        sepentinitic,
        /// <summary>
        /// serpentinite property
        /// </summary>
        serpentinite,
        /// <summary>
        /// shale property
        /// </summary>
        shale,
        /// <summary>
        /// shaly property
        /// </summary>
        shaly,
        /// <summary>
        /// shellfragments property
        /// </summary>
        [XmlEnum("shell fragments")]
        shellfragments,
        /// <summary>
        /// shelly property
        /// </summary>
        shelly,
        /// <summary>
        /// siderite property
        /// </summary>
        siderite,
        /// <summary>
        /// sideriteconcretion property
        /// </summary>
        [XmlEnum("siderite concretion")]
        sideriteconcretion,
        /// <summary>
        /// sideritic property
        /// </summary>
        sideritic,
        /// <summary>
        /// siliceousooze property
        /// </summary>
        [XmlEnum("siliceous ooze")]
        siliceousooze,
        /// <summary>
        /// silt property
        /// </summary>
        silt,
        /// <summary>
        /// siltstone property
        /// </summary>
        siltstone,
        /// <summary>
        /// silty property
        /// </summary>
        silty,
        /// <summary>
        /// skarn property
        /// </summary>
        skarn,
        /// <summary>
        /// skarny property
        /// </summary>
        skarny,
        /// <summary>
        /// slate property
        /// </summary>
        slate,
        /// <summary>
        /// slaty property
        /// </summary>
        slaty,
        /// <summary>
        /// smectite property
        /// </summary>
        smectite,
        /// <summary>
        /// smectitic property
        /// </summary>
        smectitic,
        /// <summary>
        /// spicular property
        /// </summary>
        spicular,
        /// <summary>
        /// spicules property
        /// </summary>
        spicules,
        /// <summary>
        /// spilite property
        /// </summary>
        spilite,
        /// <summary>
        /// spilitic property
        /// </summary>
        spilitic,
        /// <summary>
        /// stylolites property
        /// </summary>
        stylolites,
        /// <summary>
        /// stylolitic property
        /// </summary>
        stylolitic,
        /// <summary>
        /// syenite property
        /// </summary>
        syenite,
        /// <summary>
        /// syenitic property
        /// </summary>
        syenitic,
        /// <summary>
        /// syenitoid property
        /// </summary>
        syenitoid,
        /// <summary>
        /// sylvite property
        /// </summary>
        sylvite,
        /// <summary>
        /// sylvitic property
        /// </summary>
        sylvitic,
        /// <summary>
        /// tarry property
        /// </summary>
        tarry,
        /// <summary>
        /// tephrite property
        /// </summary>
        tephrite,
        /// <summary>
        /// tephritic property
        /// </summary>
        tephritic,
        /// <summary>
        /// tephritoid property
        /// </summary>
        tephritoid,
        /// <summary>
        /// tholeiiticbasalt property
        /// </summary>
        [XmlEnum("tholeiitic basalt")]
        tholeiiticbasalt,
        /// <summary>
        /// tonalite property
        /// </summary>
        tonalite,
        /// <summary>
        /// tonalitic property
        /// </summary>
        tonalitic,
        /// <summary>
        /// trachyte property
        /// </summary>
        trachyte,
        /// <summary>
        /// trachytic property
        /// </summary>
        trachytic,
        /// <summary>
        /// trachyticrock property
        /// </summary>
        [XmlEnum("trachytic rock")]
        trachyticrock,
        /// <summary>
        /// trachytoid property
        /// </summary>
        trachytoid,
        /// <summary>
        /// travertine property
        /// </summary>
        travertine,
        /// <summary>
        /// tuff property
        /// </summary>
        tuff,
        /// <summary>
        /// tuffaceous property
        /// </summary>
        tuffaceous,
        /// <summary>
        /// tuffite property
        /// </summary>
        tuffite,
        /// <summary>
        /// tuffitic property
        /// </summary>
        tuffitic,
        /// <summary>
        /// ultrabasic property
        /// </summary>
        ultrabasic,
        /// <summary>
        /// undifferentiated property
        /// </summary>
        undifferentiated,
        /// <summary>
        /// unknown property
        /// </summary>
        unknown,
        /// <summary>
        /// wacke property
        /// </summary>
        wacke
    }
    /// <summary>
    /// This class represents the WellStatus xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the WellStatus xsd enumeration.")]
    public enum WellStatus
    {
        /// <summary>
        /// abandoned property
        /// </summary>
        abandoned,
        /// <summary>
        /// active property
        /// </summary>
        active,
        /// <summary>
        /// activeinjecting property
        /// </summary>
        [XmlEnum("active -- injecting")]
        activeinjecting,
        /// <summary>
        /// activeproducing property
        /// </summary>
        [XmlEnum("active -- producing")]
        activeproducing,
        /// <summary>
        /// completed property
        /// </summary>
        completed,
        /// <summary>
        /// drilling property
        /// </summary>
        drilling,
        /// <summary>
        /// partiallyplugged property
        /// </summary>
        [XmlEnum("partially plugged")]
        partiallyplugged,
        /// <summary>
        /// permitted property
        /// </summary>
        permitted,
        /// <summary>
        /// pluggedandabandoned property
        /// </summary>
        [XmlEnum("plugged and abandoned")]
        pluggedandabandoned,
        /// <summary>
        /// proposed property
        /// </summary>
        proposed,
        /// <summary>
        /// sold property
        /// </summary>
        sold,
        /// <summary>
        /// suspended property
        /// </summary>
        suspended,
        /// <summary>
        /// temporarilyabandoned property
        /// </summary>
        [XmlEnum("temporarily abandoned")]
        temporarilyabandoned,
        /// <summary>
        /// testing property
        /// </summary>
        testing,
        /// <summary>
        /// tight property
        /// </summary>
        tight,
        /// <summary>
        /// workingover property
        /// </summary>
        [XmlEnum("working over")]
        workingover,
        /// <summary>
        /// unknown property
        /// </summary>
        unknown
    }
    /// <summary>
    /// This class represents the UnitOfMeasure xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the UnitOfMeasure xsd enumeration.")]
    public enum UnitOfMeasure
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// area property
        /// </summary>
        [XmlEnum("%[area]")]
        area,
        /// <summary>
        /// mass property
        /// </summary>
        [XmlEnum("%[mass]")]
        mass,
        /// <summary>
        /// molar property
        /// </summary>
        [XmlEnum("%[molar]")]
        molar,
        /// <summary>
        /// vol property
        /// </summary>
        [XmlEnum("%[vol]")]
        vol,
        /// <summary>
        /// bbldbbld property
        /// </summary>
        [XmlEnum("(bbl/d)/(bbl/d)")]
        bbldbbld,
        /// <summary>
        /// m3dm3d property
        /// </summary>
        [XmlEnum("(m3/d)/(m3/d)")]
        m3dm3d,
        /// <summary>
        /// m3sm3s property
        /// </summary>
        [XmlEnum("(m3/s)/(m3/s)")]
        m3sm3s,
        /// <summary>
        /// Item0001bblft3 property
        /// </summary>
        [XmlEnum("0.001 bbl/ft3")]
        Item0001bblft3,
        /// <summary>
        /// Item0001bblm3 property
        /// </summary>
        [XmlEnum("0.001 bbl/m3")]
        Item0001bblm3,
        /// <summary>
        /// Item0001dft3 property
        /// </summary>
        [XmlEnum("0.001 d/ft3")]
        Item0001dft3,
        /// <summary>
        /// Item0001galUKbbl property
        /// </summary>
        [XmlEnum("0.001 gal[UK]/bbl")]
        Item0001galUKbbl,
        /// <summary>
        /// Item0001galUKgalUK property
        /// </summary>
        [XmlEnum("0.001 gal[UK]/gal[UK]")]
        Item0001galUKgalUK,
        /// <summary>
        /// Item0001galUSbbl property
        /// </summary>
        [XmlEnum("0.001 gal[US]/bbl")]
        Item0001galUSbbl,
        /// <summary>
        /// Item0001galUSft3 property
        /// </summary>
        [XmlEnum("0.001 gal[US]/ft3")]
        Item0001galUSft3,
        /// <summary>
        /// Item0001galUSgalUS property
        /// </summary>
        [XmlEnum("0.001 gal[US]/gal[US]")]
        Item0001galUSgalUS,
        /// <summary>
        /// Item0001hft property
        /// </summary>
        [XmlEnum("0.001 h/ft")]
        Item0001hft,
        /// <summary>
        /// Item0001kPa2cP property
        /// </summary>
        [XmlEnum("0.001 kPa2/cP")]
        Item0001kPa2cP,
        /// <summary>
        /// Item0001lbmbbl property
        /// </summary>
        [XmlEnum("0.001 lbm/bbl")]
        Item0001lbmbbl,
        /// <summary>
        /// Item0001lbmgalUK property
        /// </summary>
        [XmlEnum("0.001 lbm/gal[UK]")]
        Item0001lbmgalUK,
        /// <summary>
        /// Item0001lbmgalUS property
        /// </summary>
        [XmlEnum("0.001 lbm/gal[US]")]
        Item0001lbmgalUS,
        /// <summary>
        /// Item0001psift property
        /// </summary>
        [XmlEnum("0.001 psi/ft")]
        Item0001psift,
        /// <summary>
        /// Item0001ptUKbbl property
        /// </summary>
        [XmlEnum("0.001 pt[UK]/bbl")]
        Item0001ptUKbbl,
        /// <summary>
        /// Item0001seca property
        /// </summary>
        [XmlEnum("0.001 seca")]
        Item0001seca,
        /// <summary>
        /// Item001bblbbl property
        /// </summary>
        [XmlEnum("0.01 bbl/bbl")]
        Item001bblbbl,
        /// <summary>
        /// Item001degaft property
        /// </summary>
        [XmlEnum("0.01 dega/ft")]
        Item001degaft,
        /// <summary>
        /// Item001degFft property
        /// </summary>
        [XmlEnum("0.01 degF/ft")]
        Item001degFft,
        /// <summary>
        /// Item001dm3km property
        /// </summary>
        [XmlEnum("0.01 dm3/km")]
        Item001dm3km,
        /// <summary>
        /// Item001ftft property
        /// </summary>
        [XmlEnum("0.01 ft/ft")]
        Item001ftft,
        /// <summary>
        /// Item001grainft3 property
        /// </summary>
        [XmlEnum("0.01 grain/ft3")]
        Item001grainft3,
        /// <summary>
        /// Item001Lkg property
        /// </summary>
        [XmlEnum("0.01 L/kg")]
        Item001Lkg,
        /// <summary>
        /// Item001Lkm property
        /// </summary>
        [XmlEnum("0.01 L/km")]
        Item001Lkm,
        /// <summary>
        /// Item001lbfft property
        /// </summary>
        [XmlEnum("0.01 lbf/ft")]
        Item001lbfft,
        /// <summary>
        /// Item001lbfft2 property
        /// </summary>
        [XmlEnum("0.01 lbf/ft2")]
        Item001lbfft2,
        /// <summary>
        /// Item001lbmft2 property
        /// </summary>
        [XmlEnum("0.01 lbm/ft2")]
        Item001lbmft2,
        /// <summary>
        /// Item001psift property
        /// </summary>
        [XmlEnum("0.01 psi/ft")]
        Item001psift,
        /// <summary>
        /// Item01ft property
        /// </summary>
        [XmlEnum("0.1 ft")]
        Item01ft,
        /// <summary>
        /// Item01ftUS property
        /// </summary>
        [XmlEnum("0.1 ft[US]")]
        Item01ftUS,
        /// <summary>
        /// Item01galUSbbl property
        /// </summary>
        [XmlEnum("0.1 gal[US]/bbl")]
        Item01galUSbbl,
        /// <summary>
        /// Item01in property
        /// </summary>
        [XmlEnum("0.1 in")]
        Item01in,
        /// <summary>
        /// Item01Lbbl property
        /// </summary>
        [XmlEnum("0.1 L/bbl")]
        Item01Lbbl,
        /// <summary>
        /// Item01lbmbbl property
        /// </summary>
        [XmlEnum("0.1 lbm/bbl")]
        Item01lbmbbl,
        /// <summary>
        /// Item01ptUSbbl property
        /// </summary>
        [XmlEnum("0.1 pt[US]/bbl")]
        Item01ptUSbbl,
        /// <summary>
        /// Item01yd property
        /// </summary>
        [XmlEnum("0.1 yd")]
        Item01yd,
        /// <summary>
        /// Item1kgs property
        /// </summary>
        [XmlEnum("1/(kg.s)")]
        Item1kgs,
        /// <summary>
        /// Item116in property
        /// </summary>
        [XmlEnum("1/16 in")]
        Item116in,
        /// <summary>
        /// Item12ft property
        /// </summary>
        [XmlEnum("1/2 ft")]
        Item12ft,
        /// <summary>
        /// Item12ms property
        /// </summary>
        [XmlEnum("1/2 ms")]
        Item12ms,
        /// <summary>
        /// Item130cm3min property
        /// </summary>
        [XmlEnum("1/30 cm3/min")]
        Item130cm3min,
        /// <summary>
        /// Item130degaft property
        /// </summary>
        [XmlEnum("1/30 dega/ft")]
        Item130degaft,
        /// <summary>
        /// Item130degam property
        /// </summary>
        [XmlEnum("1/30 dega/m")]
        Item130degam,
        /// <summary>
        /// Item130lbfm property
        /// </summary>
        [XmlEnum("1/30 lbf/m")]
        Item130lbfm,
        /// <summary>
        /// Item130mm property
        /// </summary>
        [XmlEnum("1/30 m/m")]
        Item130mm,
        /// <summary>
        /// Item130Nm property
        /// </summary>
        [XmlEnum("1/30 N/m")]
        Item130Nm,
        /// <summary>
        /// Item132in property
        /// </summary>
        [XmlEnum("1/32 in")]
        Item132in,
        /// <summary>
        /// Item164in property
        /// </summary>
        [XmlEnum("1/64 in")]
        Item164in,
        /// <summary>
        /// Item1a property
        /// </summary>
        [XmlEnum("1/a")]
        Item1a,
        /// <summary>
        /// Item1angstrom property
        /// </summary>
        [XmlEnum("1/angstrom")]
        Item1angstrom,
        /// <summary>
        /// Item1bar property
        /// </summary>
        [XmlEnum("1/bar")]
        Item1bar,
        /// <summary>
        /// Item1bbl property
        /// </summary>
        [XmlEnum("1/bbl")]
        Item1bbl,
        /// <summary>
        /// Item1cm property
        /// </summary>
        [XmlEnum("1/cm")]
        Item1cm,
        /// <summary>
        /// Item1d property
        /// </summary>
        [XmlEnum("1/d")]
        Item1d,
        /// <summary>
        /// Item1degC property
        /// </summary>
        [XmlEnum("1/degC")]
        Item1degC,
        /// <summary>
        /// Item1degF property
        /// </summary>
        [XmlEnum("1/degF")]
        Item1degF,
        /// <summary>
        /// Item1degR property
        /// </summary>
        [XmlEnum("1/degR")]
        Item1degR,
        /// <summary>
        /// Item1ft property
        /// </summary>
        [XmlEnum("1/ft")]
        Item1ft,
        /// <summary>
        /// Item1ft2 property
        /// </summary>
        [XmlEnum("1/ft2")]
        Item1ft2,
        /// <summary>
        /// Item1ft3 property
        /// </summary>
        [XmlEnum("1/ft3")]
        Item1ft3,
        /// <summary>
        /// Item1g property
        /// </summary>
        [XmlEnum("1/g")]
        Item1g,
        /// <summary>
        /// Item1galUK property
        /// </summary>
        [XmlEnum("1/gal[UK]")]
        Item1galUK,
        /// <summary>
        /// Item1galUS property
        /// </summary>
        [XmlEnum("1/gal[US]")]
        Item1galUS,
        /// <summary>
        /// Item1h property
        /// </summary>
        [XmlEnum("1/h")]
        Item1h,
        /// <summary>
        /// Item1H property
        /// </summary>
        [XmlEnum("1/H")]
        Item1H,
        /// <summary>
        /// Item1in property
        /// </summary>
        [XmlEnum("1/in")]
        Item1in,
        /// <summary>
        /// Item1K property
        /// </summary>
        [XmlEnum("1/K")]
        Item1K,
        /// <summary>
        /// Item1kg property
        /// </summary>
        [XmlEnum("1/kg")]
        Item1kg,
        /// <summary>
        /// Item1km2 property
        /// </summary>
        [XmlEnum("1/km2")]
        Item1km2,
        /// <summary>
        /// Item1kPa property
        /// </summary>
        [XmlEnum("1/kPa")]
        Item1kPa,
        /// <summary>
        /// Item1L property
        /// </summary>
        [XmlEnum("1/L")]
        Item1L,
        /// <summary>
        /// Item1lbf property
        /// </summary>
        [XmlEnum("1/lbf")]
        Item1lbf,
        /// <summary>
        /// Item1lbm property
        /// </summary>
        [XmlEnum("1/lbm")]
        Item1lbm,
        /// <summary>
        /// Item1m property
        /// </summary>
        [XmlEnum("1/m")]
        Item1m,
        /// <summary>
        /// Item1m2 property
        /// </summary>
        [XmlEnum("1/m2")]
        Item1m2,
        /// <summary>
        /// Item1m3 property
        /// </summary>
        [XmlEnum("1/m3")]
        Item1m3,
        /// <summary>
        /// Item1mi property
        /// </summary>
        [XmlEnum("1/mi")]
        Item1mi,
        /// <summary>
        /// Item1mi2 property
        /// </summary>
        [XmlEnum("1/mi2")]
        Item1mi2,
        /// <summary>
        /// Item1min property
        /// </summary>
        [XmlEnum("1/min")]
        Item1min,
        /// <summary>
        /// Item1mm property
        /// </summary>
        [XmlEnum("1/mm")]
        Item1mm,
        /// <summary>
        /// Item1ms property
        /// </summary>
        [XmlEnum("1/ms")]
        Item1ms,
        /// <summary>
        /// Item1N property
        /// </summary>
        [XmlEnum("1/N")]
        Item1N,
        /// <summary>
        /// Item1nm property
        /// </summary>
        [XmlEnum("1/nm")]
        Item1nm,
        /// <summary>
        /// Item1Pa property
        /// </summary>
        [XmlEnum("1/Pa")]
        Item1Pa,
        /// <summary>
        /// Item1pPa property
        /// </summary>
        [XmlEnum("1/pPa")]
        Item1pPa,
        /// <summary>
        /// Item1psi property
        /// </summary>
        [XmlEnum("1/psi")]
        Item1psi,
        /// <summary>
        /// Item1s property
        /// </summary>
        [XmlEnum("1/s")]
        Item1s,
        /// <summary>
        /// Item1upsi property
        /// </summary>
        [XmlEnum("1/upsi")]
        Item1upsi,
        /// <summary>
        /// Item1us property
        /// </summary>
        [XmlEnum("1/us")]
        Item1us,
        /// <summary>
        /// Item1uV property
        /// </summary>
        [XmlEnum("1/uV")]
        Item1uV,
        /// <summary>
        /// Item1V property
        /// </summary>
        [XmlEnum("1/V")]
        Item1V,
        /// <summary>
        /// Item1wk property
        /// </summary>
        [XmlEnum("1/wk")]
        Item1wk,
        /// <summary>
        /// Item1yd property
        /// </summary>
        [XmlEnum("1/yd")]
        Item1yd,
        /// <summary>
        /// Item10ft property
        /// </summary>
        [XmlEnum("10 ft")]
        Item10ft,
        /// <summary>
        /// Item10in property
        /// </summary>
        [XmlEnum("10 in")]
        Item10in,
        /// <summary>
        /// Item10km property
        /// </summary>
        [XmlEnum("10 km")]
        Item10km,
        /// <summary>
        /// Item10kN property
        /// </summary>
        [XmlEnum("10 kN")]
        Item10kN,
        /// <summary>
        /// Item10Mgm3 property
        /// </summary>
        [XmlEnum("10 Mg/m3")]
        Item10Mgm3,
        /// <summary>
        /// Item100ft property
        /// </summary>
        [XmlEnum("100 ft")]
        Item100ft,
        /// <summary>
        /// Item100kat property
        /// </summary>
        [XmlEnum("100 ka[t]")]
        Item100kat,
        /// <summary>
        /// Item100km property
        /// </summary>
        [XmlEnum("100 km")]
        Item100km,
        /// <summary>
        /// Item1000bbl property
        /// </summary>
        [XmlEnum("1000 bbl")]
        Item1000bbl,
        /// <summary>
        /// Item1000bblftd property
        /// </summary>
        [XmlEnum("1000 bbl.ft/d")]
        Item1000bblftd,
        /// <summary>
        /// Item1000bbld property
        /// </summary>
        [XmlEnum("1000 bbl/d")]
        Item1000bbld,
        /// <summary>
        /// Item1000ft property
        /// </summary>
        [XmlEnum("1000 ft")]
        Item1000ft,
        /// <summary>
        /// Item1000fth property
        /// </summary>
        [XmlEnum("1000 ft/h")]
        Item1000fth,
        /// <summary>
        /// Item1000fts property
        /// </summary>
        [XmlEnum("1000 ft/s")]
        Item1000fts,
        /// <summary>
        /// Item1000ft3 property
        /// </summary>
        [XmlEnum("1000 ft3")]
        Item1000ft3,
        /// <summary>
        /// Item1000ft3dft property
        /// </summary>
        [XmlEnum("1000 ft3/(d.ft)")]
        Item1000ft3dft,
        /// <summary>
        /// Item1000ft3psid property
        /// </summary>
        [XmlEnum("1000 ft3/(psi.d)")]
        Item1000ft3psid,
        /// <summary>
        /// Item1000ft3bbl property
        /// </summary>
        [XmlEnum("1000 ft3/bbl")]
        Item1000ft3bbl,
        /// <summary>
        /// Item1000ft3d property
        /// </summary>
        [XmlEnum("1000 ft3/d")]
        Item1000ft3d,
        /// <summary>
        /// Item1000galUK property
        /// </summary>
        [XmlEnum("1000 gal[UK]")]
        Item1000galUK,
        /// <summary>
        /// Item1000galUS property
        /// </summary>
        [XmlEnum("1000 gal[US]")]
        Item1000galUS,
        /// <summary>
        /// Item1000lbfft property
        /// </summary>
        [XmlEnum("1000 lbf.ft")]
        Item1000lbfft,
        /// <summary>
        /// Item1000m3 property
        /// </summary>
        [XmlEnum("1000 m3")]
        Item1000m3,
        /// <summary>
        /// Item1000m3dm property
        /// </summary>
        [XmlEnum("1000 m3/(d.m)")]
        Item1000m3dm,
        /// <summary>
        /// Item1000m3hm property
        /// </summary>
        [XmlEnum("1000 m3/(h.m)")]
        Item1000m3hm,
        /// <summary>
        /// Item1000m3d property
        /// </summary>
        [XmlEnum("1000 m3/d")]
        Item1000m3d,
        /// <summary>
        /// Item1000m3h property
        /// </summary>
        [XmlEnum("1000 m3/h")]
        Item1000m3h,
        /// <summary>
        /// Item1000m3m3 property
        /// </summary>
        [XmlEnum("1000 m3/m3")]
        Item1000m3m3,
        /// <summary>
        /// Item1000m4d property
        /// </summary>
        [XmlEnum("1000 m4/d")]
        Item1000m4d,
        /// <summary>
        /// Item1E12ft3 property
        /// </summary>
        [XmlEnum("1E12 ft3")]
        Item1E12ft3,
        /// <summary>
        /// Item1E6ft3dbbld property
        /// </summary>
        [XmlEnum("1E6 (ft3/d)/(bbl/d)")]
        Item1E6ft3dbbld,
        /// <summary>
        /// Item1E6acreftbbl property
        /// </summary>
        [XmlEnum("1E-6 acre.ft/bbl")]
        Item1E6acreftbbl,
        /// <summary>
        /// Item1E6bbl property
        /// </summary>
        [XmlEnum("1E6 bbl")]
        Item1E6bbl,
        /// <summary>
        /// Item1E6bblacreft property
        /// </summary>
        [XmlEnum("1E6 bbl/(acre.ft)")]
        Item1E6bblacreft,
        /// <summary>
        /// Item1E6bblacre property
        /// </summary>
        [XmlEnum("1E6 bbl/acre")]
        Item1E6bblacre,
        /// <summary>
        /// Item1E6bbld property
        /// </summary>
        [XmlEnum("1E6 bbl/d")]
        Item1E6bbld,
        /// <summary>
        /// Item1E6bblft3 property
        /// </summary>
        [XmlEnum("1E-6 bbl/ft3")]
        Item1E6bblft3,
        /// <summary>
        /// Item1E6bblm3 property
        /// </summary>
        [XmlEnum("1E-6 bbl/m3")]
        Item1E6bblm3,
        /// <summary>
        /// Item1E6BtuIT property
        /// </summary>
        [XmlEnum("1E6 Btu[IT]")]
        Item1E6BtuIT,
        /// <summary>
        /// Item1E6BtuITh property
        /// </summary>
        [XmlEnum("1E6 Btu[IT]/h")]
        Item1E6BtuITh,
        /// <summary>
        /// Item1E6ft3 property
        /// </summary>
        [XmlEnum("1E6 ft3")]
        Item1E6ft3,
        /// <summary>
        /// Item1E6ft3acreft property
        /// </summary>
        [XmlEnum("1E6 ft3/(acre.ft)")]
        Item1E6ft3acreft,
        /// <summary>
        /// Item1E6ft3bbl property
        /// </summary>
        [XmlEnum("1E6 ft3/bbl")]
        Item1E6ft3bbl,
        /// <summary>
        /// Item1E6ft3d property
        /// </summary>
        [XmlEnum("1E6 ft3/d")]
        Item1E6ft3d,
        /// <summary>
        /// Item1E6galUS property
        /// </summary>
        [XmlEnum("1E-6 gal[US]")]
        Item1E6galUS,
        /// <summary>
        /// Item1E6lbma property
        /// </summary>
        [XmlEnum("1E6 lbm/a")]
        Item1E6lbma,
        /// <summary>
        /// Item1E6m3 property
        /// </summary>
        [XmlEnum("1E6 m3")]
        Item1E6m3,
        /// <summary>
        /// Item1E6m3m3degC property
        /// </summary>
        [XmlEnum("1E-6 m3/(m3.degC)")]
        Item1E6m3m3degC,
        /// <summary>
        /// Item1E6m3m3degF property
        /// </summary>
        [XmlEnum("1E-6 m3/(m3.degF)")]
        Item1E6m3m3degF,
        /// <summary>
        /// Item1E6m3d property
        /// </summary>
        [XmlEnum("1E6 m3/d")]
        Item1E6m3d,
        /// <summary>
        /// Item1E91ft property
        /// </summary>
        [XmlEnum("1E-9 1/ft")]
        Item1E91ft,
        /// <summary>
        /// Item1E9bbl property
        /// </summary>
        [XmlEnum("1E9 bbl")]
        Item1E9bbl,
        /// <summary>
        /// Item1E9ft3 property
        /// </summary>
        [XmlEnum("1E9 ft3")]
        Item1E9ft3,
        /// <summary>
        /// Item30ft property
        /// </summary>
        [XmlEnum("30 ft")]
        Item30ft,
        /// <summary>
        /// Item30m property
        /// </summary>
        [XmlEnum("30 m")]
        Item30m,
        /// <summary>
        /// A property
        /// </summary>
        A,
        /// <summary>
        /// a property
        /// </summary>
        a,
        /// <summary>
        /// Ah property
        /// </summary>
        [XmlEnum("A.h")]
        Ah,
        /// <summary>
        /// Am2 property
        /// </summary>
        [XmlEnum("A.m2")]
        Am2,
        /// <summary>
        /// As property
        /// </summary>
        [XmlEnum("A.s")]
        As,
        /// <summary>
        /// Askg property
        /// </summary>
        [XmlEnum("A.s/kg")]
        Askg,
        /// <summary>
        /// Asm3 property
        /// </summary>
        [XmlEnum("A.s/m3")]
        Asm3,
        /// <summary>
        /// Acm2 property
        /// </summary>
        [XmlEnum("A/cm2")]
        Acm2,
        /// <summary>
        /// Aft2 property
        /// </summary>
        [XmlEnum("A/ft2")]
        Aft2,
        /// <summary>
        /// Am property
        /// </summary>
        [XmlEnum("A/m")]
        Am,
        /// <summary>
        /// Am21 property
        /// </summary>
        [XmlEnum("A/m2")]
        Am21,
        /// <summary>
        /// Amm property
        /// </summary>
        [XmlEnum("A/mm")]
        Amm,
        /// <summary>
        /// Amm2 property
        /// </summary>
        [XmlEnum("A/mm2")]
        Amm2,
        /// <summary>
        /// at property
        /// </summary>
        [XmlEnum("a[t]")]
        at,
        /// <summary>
        /// acre property
        /// </summary>
        acre,
        /// <summary>
        /// acreft property
        /// </summary>
        [XmlEnum("acre.ft")]
        acreft,
        /// <summary>
        /// ag property
        /// </summary>
        ag,
        /// <summary>
        /// aJ property
        /// </summary>
        aJ,
        /// <summary>
        /// angstrom property
        /// </summary>
        angstrom,
        /// <summary>
        /// at1 property
        /// </summary>
        [XmlEnum("at")]
        at1,
        /// <summary>
        /// atm property
        /// </summary>
        atm,
        /// <summary>
        /// atmft property
        /// </summary>
        [XmlEnum("atm/ft")]
        atmft,
        /// <summary>
        /// atmh property
        /// </summary>
        [XmlEnum("atm/h")]
        atmh,
        /// <summary>
        /// atmhm property
        /// </summary>
        [XmlEnum("atm/hm")]
        atmhm,
        /// <summary>
        /// atmm property
        /// </summary>
        [XmlEnum("atm/m")]
        atmm,
        /// <summary>
        /// b property
        /// </summary>
        b,
        /// <summary>
        /// B property
        /// </summary>
        B,
        /// <summary>
        /// BW property
        /// </summary>
        [XmlEnum("B.W")]
        BW,
        /// <summary>
        /// bcm3 property
        /// </summary>
        [XmlEnum("b/cm3")]
        bcm3,
        /// <summary>
        /// Bm property
        /// </summary>
        [XmlEnum("B/m")]
        Bm,
        /// <summary>
        /// BO property
        /// </summary>
        [XmlEnum("B/O")]
        BO,
        /// <summary>
        /// bar property
        /// </summary>
        bar,
        /// <summary>
        /// barh property
        /// </summary>
        [XmlEnum("bar/h")]
        barh,
        /// <summary>
        /// barkm property
        /// </summary>
        [XmlEnum("bar/km")]
        barkm,
        /// <summary>
        /// barm property
        /// </summary>
        [XmlEnum("bar/m")]
        barm,
        /// <summary>
        /// bar2 property
        /// </summary>
        bar2,
        /// <summary>
        /// bar2cP property
        /// </summary>
        [XmlEnum("bar2/cP")]
        bar2cP,
        /// <summary>
        /// bbl property
        /// </summary>
        bbl,
        /// <summary>
        /// bblacreft property
        /// </summary>
        [XmlEnum("bbl/(acre.ft)")]
        bblacreft,
        /// <summary>
        /// bbldacreft property
        /// </summary>
        [XmlEnum("bbl/(d.acre.ft)")]
        bbldacreft,
        /// <summary>
        /// bbldft property
        /// </summary>
        [XmlEnum("bbl/(d.ft)")]
        bbldft,
        /// <summary>
        /// bblftpsid property
        /// </summary>
        [XmlEnum("bbl/(ft.psi.d)")]
        bblftpsid,
        /// <summary>
        /// bblkPad property
        /// </summary>
        [XmlEnum("bbl/(kPa.d)")]
        bblkPad,
        /// <summary>
        /// bblpsid property
        /// </summary>
        [XmlEnum("bbl/(psi.d)")]
        bblpsid,
        /// <summary>
        /// bblacre property
        /// </summary>
        [XmlEnum("bbl/acre")]
        bblacre,
        /// <summary>
        /// bblbbl property
        /// </summary>
        [XmlEnum("bbl/bbl")]
        bblbbl,
        /// <summary>
        /// bbld property
        /// </summary>
        [XmlEnum("bbl/d")]
        bbld,
        /// <summary>
        /// bbld2 property
        /// </summary>
        [XmlEnum("bbl/d2")]
        bbld2,
        /// <summary>
        /// bblft property
        /// </summary>
        [XmlEnum("bbl/ft")]
        bblft,
        /// <summary>
        /// bblft3 property
        /// </summary>
        [XmlEnum("bbl/ft3")]
        bblft3,
        /// <summary>
        /// bblh property
        /// </summary>
        [XmlEnum("bbl/h")]
        bblh,
        /// <summary>
        /// bblh2 property
        /// </summary>
        [XmlEnum("bbl/h2")]
        bblh2,
        /// <summary>
        /// bblin property
        /// </summary>
        [XmlEnum("bbl/in")]
        bblin,
        /// <summary>
        /// bblm3 property
        /// </summary>
        [XmlEnum("bbl/m3")]
        bblm3,
        /// <summary>
        /// bblmi property
        /// </summary>
        [XmlEnum("bbl/mi")]
        bblmi,
        /// <summary>
        /// bblmin property
        /// </summary>
        [XmlEnum("bbl/min")]
        bblmin,
        /// <summary>
        /// bblpsi property
        /// </summary>
        [XmlEnum("bbl/psi")]
        bblpsi,
        /// <summary>
        /// bbltonUK property
        /// </summary>
        [XmlEnum("bbl/ton[UK]")]
        bbltonUK,
        /// <summary>
        /// bbltonUS property
        /// </summary>
        [XmlEnum("bbl/ton[US]")]
        bbltonUS,
        /// <summary>
        /// Bd property
        /// </summary>
        Bd,
        /// <summary>
        /// bit property
        /// </summary>
        bit,
        /// <summary>
        /// bits property
        /// </summary>
        [XmlEnum("bit/s")]
        bits,
        /// <summary>
        /// Bq property
        /// </summary>
        Bq,
        /// <summary>
        /// Bqkg property
        /// </summary>
        [XmlEnum("Bq/kg")]
        Bqkg,
        /// <summary>
        /// BtuIT property
        /// </summary>
        [XmlEnum("Btu[IT]")]
        BtuIT,
        /// <summary>
        /// BtuITinhft2degF property
        /// </summary>
        [XmlEnum("Btu[IT].in/(h.ft2.degF)")]
        BtuITinhft2degF,
        /// <summary>
        /// BtuIThftdegF property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft.degF)")]
        BtuIThftdegF,
        /// <summary>
        /// BtuIThft2 property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft2)")]
        BtuIThft2,
        /// <summary>
        /// BtuIThft2degF property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft2.degF)")]
        BtuIThft2degF,
        /// <summary>
        /// BtuIThft2degR property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft2.degR)")]
        BtuIThft2degR,
        /// <summary>
        /// BtuIThft3 property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft3)")]
        BtuIThft3,
        /// <summary>
        /// BtuIThft3degF property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft3.degF)")]
        BtuIThft3degF,
        /// <summary>
        /// BtuIThm2degC property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.m2.degC)")]
        BtuIThm2degC,
        /// <summary>
        /// BtuIThph property
        /// </summary>
        [XmlEnum("Btu[IT]/(hp.h)")]
        BtuIThph,
        /// <summary>
        /// BtuITlbmdegF property
        /// </summary>
        [XmlEnum("Btu[IT]/(lbm.degF)")]
        BtuITlbmdegF,
        /// <summary>
        /// BtuITlbmdegR property
        /// </summary>
        [XmlEnum("Btu[IT]/(lbm.degR)")]
        BtuITlbmdegR,
        /// <summary>
        /// BtuITlbmoldegF property
        /// </summary>
        [XmlEnum("Btu[IT]/(lbmol.degF)")]
        BtuITlbmoldegF,
        /// <summary>
        /// BtuITsft2 property
        /// </summary>
        [XmlEnum("Btu[IT]/(s.ft2)")]
        BtuITsft2,
        /// <summary>
        /// BtuITsft2degF property
        /// </summary>
        [XmlEnum("Btu[IT]/(s.ft2.degF)")]
        BtuITsft2degF,
        /// <summary>
        /// BtuITsft3 property
        /// </summary>
        [XmlEnum("Btu[IT]/(s.ft3)")]
        BtuITsft3,
        /// <summary>
        /// BtuITsft3degF property
        /// </summary>
        [XmlEnum("Btu[IT]/(s.ft3.degF)")]
        BtuITsft3degF,
        /// <summary>
        /// BtuITbbl property
        /// </summary>
        [XmlEnum("Btu[IT]/bbl")]
        BtuITbbl,
        /// <summary>
        /// BtuITft3 property
        /// </summary>
        [XmlEnum("Btu[IT]/ft3")]
        BtuITft3,
        /// <summary>
        /// BtuITgalUK property
        /// </summary>
        [XmlEnum("Btu[IT]/gal[UK]")]
        BtuITgalUK,
        /// <summary>
        /// BtuITgalUS property
        /// </summary>
        [XmlEnum("Btu[IT]/gal[US]")]
        BtuITgalUS,
        /// <summary>
        /// BtuITh property
        /// </summary>
        [XmlEnum("Btu[IT]/h")]
        BtuITh,
        /// <summary>
        /// BtuITlbm property
        /// </summary>
        [XmlEnum("Btu[IT]/lbm")]
        BtuITlbm,
        /// <summary>
        /// BtuITlbmol property
        /// </summary>
        [XmlEnum("Btu[IT]/lbmol")]
        BtuITlbmol,
        /// <summary>
        /// BtuITmin property
        /// </summary>
        [XmlEnum("Btu[IT]/min")]
        BtuITmin,
        /// <summary>
        /// BtuITs property
        /// </summary>
        [XmlEnum("Btu[IT]/s")]
        BtuITs,
        /// <summary>
        /// Btuth property
        /// </summary>
        [XmlEnum("Btu[th]")]
        Btuth,
        /// <summary>
        /// BtuUK property
        /// </summary>
        [XmlEnum("Btu[UK]")]
        BtuUK,
        /// <summary>
        /// byte property
        /// </summary>
        @byte,
        /// <summary>
        /// bytes property
        /// </summary>
        [XmlEnum("byte/s")]
        bytes,
        /// <summary>
        /// C property
        /// </summary>
        C,
        /// <summary>
        /// Cm property
        /// </summary>
        [XmlEnum("C.m")]
        Cm,
        /// <summary>
        /// Ccm2 property
        /// </summary>
        [XmlEnum("C/cm2")]
        Ccm2,
        /// <summary>
        /// Ccm3 property
        /// </summary>
        [XmlEnum("C/cm3")]
        Ccm3,
        /// <summary>
        /// Cg property
        /// </summary>
        [XmlEnum("C/g")]
        Cg,
        /// <summary>
        /// Ckg property
        /// </summary>
        [XmlEnum("C/kg")]
        Ckg,
        /// <summary>
        /// Cm2 property
        /// </summary>
        [XmlEnum("C/m2")]
        Cm2,
        /// <summary>
        /// Cm3 property
        /// </summary>
        [XmlEnum("C/m3")]
        Cm3,
        /// <summary>
        /// Cmm2 property
        /// </summary>
        [XmlEnum("C/mm2")]
        Cmm2,
        /// <summary>
        /// Cmm3 property
        /// </summary>
        [XmlEnum("C/mm3")]
        Cmm3,
        /// <summary>
        /// ca property
        /// </summary>
        ca,
        /// <summary>
        /// cA property
        /// </summary>
        cA,
        /// <summary>
        /// calIT property
        /// </summary>
        [XmlEnum("cal[IT]")]
        calIT,
        /// <summary>
        /// calth property
        /// </summary>
        [XmlEnum("cal[th]")]
        calth,
        /// <summary>
        /// calthgK property
        /// </summary>
        [XmlEnum("cal[th]/(g.K)")]
        calthgK,
        /// <summary>
        /// calthhcmdegC property
        /// </summary>
        [XmlEnum("cal[th]/(h.cm.degC)")]
        calthhcmdegC,
        /// <summary>
        /// calthhcm2 property
        /// </summary>
        [XmlEnum("cal[th]/(h.cm2)")]
        calthhcm2,
        /// <summary>
        /// calthhcm2degC property
        /// </summary>
        [XmlEnum("cal[th]/(h.cm2.degC)")]
        calthhcm2degC,
        /// <summary>
        /// calthhcm3 property
        /// </summary>
        [XmlEnum("cal[th]/(h.cm3)")]
        calthhcm3,
        /// <summary>
        /// calthmoldegC property
        /// </summary>
        [XmlEnum("cal[th]/(mol.degC)")]
        calthmoldegC,
        /// <summary>
        /// calthscmdegC property
        /// </summary>
        [XmlEnum("cal[th]/(s.cm.degC)")]
        calthscmdegC,
        /// <summary>
        /// calthscm2degC property
        /// </summary>
        [XmlEnum("cal[th]/(s.cm2.degC)")]
        calthscm2degC,
        /// <summary>
        /// calthscm3 property
        /// </summary>
        [XmlEnum("cal[th]/(s.cm3)")]
        calthscm3,
        /// <summary>
        /// calthcm3 property
        /// </summary>
        [XmlEnum("cal[th]/cm3")]
        calthcm3,
        /// <summary>
        /// calthg property
        /// </summary>
        [XmlEnum("cal[th]/g")]
        calthg,
        /// <summary>
        /// calthh property
        /// </summary>
        [XmlEnum("cal[th]/h")]
        calthh,
        /// <summary>
        /// calthkg property
        /// </summary>
        [XmlEnum("cal[th]/kg")]
        calthkg,
        /// <summary>
        /// calthlbm property
        /// </summary>
        [XmlEnum("cal[th]/lbm")]
        calthlbm,
        /// <summary>
        /// calthmL property
        /// </summary>
        [XmlEnum("cal[th]/mL")]
        calthmL,
        /// <summary>
        /// calthmm3 property
        /// </summary>
        [XmlEnum("cal[th]/mm3")]
        calthmm3,
        /// <summary>
        /// cC property
        /// </summary>
        cC,
        /// <summary>
        /// ccalth property
        /// </summary>
        [XmlEnum("ccal[th]")]
        ccalth,
        /// <summary>
        /// ccgr property
        /// </summary>
        ccgr,
        /// <summary>
        /// cd property
        /// </summary>
        cd,
        /// <summary>
        /// cdm2 property
        /// </summary>
        [XmlEnum("cd/m2")]
        cdm2,
        /// <summary>
        /// cEuc property
        /// </summary>
        cEuc,
        /// <summary>
        /// ceV property
        /// </summary>
        ceV,
        /// <summary>
        /// cF property
        /// </summary>
        cF,
        /// <summary>
        /// cg property
        /// </summary>
        cg,
        /// <summary>
        /// cgauss property
        /// </summary>
        cgauss,
        /// <summary>
        /// cgr property
        /// </summary>
        cgr,
        /// <summary>
        /// cGy property
        /// </summary>
        cGy,
        /// <summary>
        /// cH property
        /// </summary>
        cH,
        /// <summary>
        /// chain property
        /// </summary>
        chain,
        /// <summary>
        /// chainBnA property
        /// </summary>
        [XmlEnum("chain[BnA]")]
        chainBnA,
        /// <summary>
        /// chainBnB property
        /// </summary>
        [XmlEnum("chain[BnB]")]
        chainBnB,
        /// <summary>
        /// chainCla property
        /// </summary>
        [XmlEnum("chain[Cla]")]
        chainCla,
        /// <summary>
        /// chainInd37 property
        /// </summary>
        [XmlEnum("chain[Ind37]")]
        chainInd37,
        /// <summary>
        /// chainSe property
        /// </summary>
        [XmlEnum("chain[Se]")]
        chainSe,
        /// <summary>
        /// chainSeT property
        /// </summary>
        [XmlEnum("chain[SeT]")]
        chainSeT,
        /// <summary>
        /// chainUS property
        /// </summary>
        [XmlEnum("chain[US]")]
        chainUS,
        /// <summary>
        /// cHz property
        /// </summary>
        cHz,
        /// <summary>
        /// Ci property
        /// </summary>
        Ci,
        /// <summary>
        /// cJ property
        /// </summary>
        cJ,
        /// <summary>
        /// cm property
        /// </summary>
        cm,
        /// <summary>
        /// cma property
        /// </summary>
        [XmlEnum("cm/a")]
        cma,
        /// <summary>
        /// cms property
        /// </summary>
        [XmlEnum("cm/s")]
        cms,
        /// <summary>
        /// cms2 property
        /// </summary>
        [XmlEnum("cm/s2")]
        cms2,
        /// <summary>
        /// cm2 property
        /// </summary>
        cm2,
        /// <summary>
        /// cm2g property
        /// </summary>
        [XmlEnum("cm2/g")]
        cm2g,
        /// <summary>
        /// cm2s property
        /// </summary>
        [XmlEnum("cm2/s")]
        cm2s,
        /// <summary>
        /// cm3 property
        /// </summary>
        cm3,
        /// <summary>
        /// cm3cm3 property
        /// </summary>
        [XmlEnum("cm3/cm3")]
        cm3cm3,
        /// <summary>
        /// cm3g property
        /// </summary>
        [XmlEnum("cm3/g")]
        cm3g,
        /// <summary>
        /// cm3h property
        /// </summary>
        [XmlEnum("cm3/h")]
        cm3h,
        /// <summary>
        /// cm3L property
        /// </summary>
        [XmlEnum("cm3/L")]
        cm3L,
        /// <summary>
        /// cm3m3 property
        /// </summary>
        [XmlEnum("cm3/m3")]
        cm3m3,
        /// <summary>
        /// cm3min property
        /// </summary>
        [XmlEnum("cm3/min")]
        cm3min,
        /// <summary>
        /// cm3s property
        /// </summary>
        [XmlEnum("cm3/s")]
        cm3s,
        /// <summary>
        /// cm4 property
        /// </summary>
        cm4,
        /// <summary>
        /// cmH2O4degC property
        /// </summary>
        [XmlEnum("cmH2O[4degC]")]
        cmH2O4degC,
        /// <summary>
        /// cN property
        /// </summary>
        cN,
        /// <summary>
        /// cohm property
        /// </summary>
        cohm,
        /// <summary>
        /// cP property
        /// </summary>
        cP,
        /// <summary>
        /// cPa property
        /// </summary>
        cPa,
        /// <summary>
        /// crd property
        /// </summary>
        crd,
        /// <summary>
        /// cS property
        /// </summary>
        cS,
        /// <summary>
        /// cs property
        /// </summary>
        cs,
        /// <summary>
        /// cSt property
        /// </summary>
        cSt,
        /// <summary>
        /// ct property
        /// </summary>
        ct,
        /// <summary>
        /// cT property
        /// </summary>
        cT,
        /// <summary>
        /// cu property
        /// </summary>
        cu,
        /// <summary>
        /// cV property
        /// </summary>
        cV,
        /// <summary>
        /// cW property
        /// </summary>
        cW,
        /// <summary>
        /// cWb property
        /// </summary>
        cWb,
        /// <summary>
        /// cwtUK property
        /// </summary>
        [XmlEnum("cwt[UK]")]
        cwtUK,
        /// <summary>
        /// cwtUS property
        /// </summary>
        [XmlEnum("cwt[US]")]
        cwtUS,
        /// <summary>
        /// D property
        /// </summary>
        D,
        /// <summary>
        /// d property
        /// </summary>
        d,
        /// <summary>
        /// Dft property
        /// </summary>
        [XmlEnum("D.ft")]
        Dft,
        /// <summary>
        /// Dm property
        /// </summary>
        [XmlEnum("D.m")]
        Dm,
        /// <summary>
        /// DPas property
        /// </summary>
        [XmlEnum("D/(Pa.s)")]
        DPas,
        /// <summary>
        /// dbbl property
        /// </summary>
        [XmlEnum("d/bbl")]
        dbbl,
        /// <summary>
        /// DcP property
        /// </summary>
        [XmlEnum("D/cP")]
        DcP,
        /// <summary>
        /// dft3 property
        /// </summary>
        [XmlEnum("d/ft3")]
        dft3,
        /// <summary>
        /// dm3 property
        /// </summary>
        [XmlEnum("d/m3")]
        dm3,
        /// <summary>
        /// DAPI property
        /// </summary>
        [XmlEnum("D[API]")]
        DAPI,
        /// <summary>
        /// dA property
        /// </summary>
        dA,
        /// <summary>
        /// dam property
        /// </summary>
        dam,
        /// <summary>
        /// daN property
        /// </summary>
        daN,
        /// <summary>
        /// daNm property
        /// </summary>
        [XmlEnum("daN.m")]
        daNm,
        /// <summary>
        /// dAPI property
        /// </summary>
        dAPI,
        /// <summary>
        /// dB property
        /// </summary>
        dB,
        /// <summary>
        /// dBmW property
        /// </summary>
        [XmlEnum("dB.mW")]
        dBmW,
        /// <summary>
        /// dBMW property
        /// </summary>
        [XmlEnum("dB.MW")]
        dBMW,
        /// <summary>
        /// dBW property
        /// </summary>
        [XmlEnum("dB.W")]
        dBW,
        /// <summary>
        /// dBft property
        /// </summary>
        [XmlEnum("dB/ft")]
        dBft,
        /// <summary>
        /// dBkm property
        /// </summary>
        [XmlEnum("dB/km")]
        dBkm,
        /// <summary>
        /// dBm property
        /// </summary>
        [XmlEnum("dB/m")]
        dBm,
        /// <summary>
        /// dBO property
        /// </summary>
        [XmlEnum("dB/O")]
        dBO,
        /// <summary>
        /// dC property
        /// </summary>
        dC,
        /// <summary>
        /// dcalth property
        /// </summary>
        [XmlEnum("dcal[th]")]
        dcalth,
        /// <summary>
        /// dega property
        /// </summary>
        dega,
        /// <summary>
        /// degaft property
        /// </summary>
        [XmlEnum("dega/ft")]
        degaft,
        /// <summary>
        /// degah property
        /// </summary>
        [XmlEnum("dega/h")]
        degah,
        /// <summary>
        /// degam property
        /// </summary>
        [XmlEnum("dega/m")]
        degam,
        /// <summary>
        /// degamin property
        /// </summary>
        [XmlEnum("dega/min")]
        degamin,
        /// <summary>
        /// degas property
        /// </summary>
        [XmlEnum("dega/s")]
        degas,
        /// <summary>
        /// degC property
        /// </summary>
        degC,
        /// <summary>
        /// degCm2hkcalth property
        /// </summary>
        [XmlEnum("degC.m2.h/kcal[th]")]
        degCm2hkcalth,
        /// <summary>
        /// degCft property
        /// </summary>
        [XmlEnum("degC/ft")]
        degCft,
        /// <summary>
        /// degCh property
        /// </summary>
        [XmlEnum("degC/h")]
        degCh,
        /// <summary>
        /// degChm property
        /// </summary>
        [XmlEnum("degC/hm")]
        degChm,
        /// <summary>
        /// degCkm property
        /// </summary>
        [XmlEnum("degC/km")]
        degCkm,
        /// <summary>
        /// degCkPa property
        /// </summary>
        [XmlEnum("degC/kPa")]
        degCkPa,
        /// <summary>
        /// degCm property
        /// </summary>
        [XmlEnum("degC/m")]
        degCm,
        /// <summary>
        /// degCmin property
        /// </summary>
        [XmlEnum("degC/min")]
        degCmin,
        /// <summary>
        /// degCs property
        /// </summary>
        [XmlEnum("degC/s")]
        degCs,
        /// <summary>
        /// degF property
        /// </summary>
        degF,
        /// <summary>
        /// degFft2hBtuIT property
        /// </summary>
        [XmlEnum("degF.ft2.h/Btu[IT]")]
        degFft2hBtuIT,
        /// <summary>
        /// degFft property
        /// </summary>
        [XmlEnum("degF/ft")]
        degFft,
        /// <summary>
        /// degFh property
        /// </summary>
        [XmlEnum("degF/h")]
        degFh,
        /// <summary>
        /// degFm property
        /// </summary>
        [XmlEnum("degF/m")]
        degFm,
        /// <summary>
        /// degFmin property
        /// </summary>
        [XmlEnum("degF/min")]
        degFmin,
        /// <summary>
        /// degFpsi property
        /// </summary>
        [XmlEnum("degF/psi")]
        degFpsi,
        /// <summary>
        /// degFs property
        /// </summary>
        [XmlEnum("degF/s")]
        degFs,
        /// <summary>
        /// degR property
        /// </summary>
        degR,
        /// <summary>
        /// dEuc property
        /// </summary>
        dEuc,
        /// <summary>
        /// deV property
        /// </summary>
        deV,
        /// <summary>
        /// dF property
        /// </summary>
        dF,
        /// <summary>
        /// dgauss property
        /// </summary>
        dgauss,
        /// <summary>
        /// dGy property
        /// </summary>
        dGy,
        /// <summary>
        /// dH property
        /// </summary>
        dH,
        /// <summary>
        /// dHz property
        /// </summary>
        dHz,
        /// <summary>
        /// dJ property
        /// </summary>
        dJ,
        /// <summary>
        /// dm property
        /// </summary>
        dm,
        /// <summary>
        /// dms property
        /// </summary>
        [XmlEnum("dm/s")]
        dms,
        /// <summary>
        /// dm31 property
        /// </summary>
        [XmlEnum("dm3")]
        dm31,
        /// <summary>
        /// dm3kWh property
        /// </summary>
        [XmlEnum("dm3/(kW.h)")]
        dm3kWh,
        /// <summary>
        /// dm3kg property
        /// </summary>
        [XmlEnum("dm3/kg")]
        dm3kg,
        /// <summary>
        /// dm3kmol property
        /// </summary>
        [XmlEnum("dm3/kmol")]
        dm3kmol,
        /// <summary>
        /// dm3m property
        /// </summary>
        [XmlEnum("dm3/m")]
        dm3m,
        /// <summary>
        /// dm3m3 property
        /// </summary>
        [XmlEnum("dm3/m3")]
        dm3m3,
        /// <summary>
        /// dm3MJ property
        /// </summary>
        [XmlEnum("dm3/MJ")]
        dm3MJ,
        /// <summary>
        /// dm3s property
        /// </summary>
        [XmlEnum("dm3/s")]
        dm3s,
        /// <summary>
        /// dm3s2 property
        /// </summary>
        [XmlEnum("dm3/s2")]
        dm3s2,
        /// <summary>
        /// dm3t property
        /// </summary>
        [XmlEnum("dm3/t")]
        dm3t,
        /// <summary>
        /// dN property
        /// </summary>
        dN,
        /// <summary>
        /// dNm property
        /// </summary>
        [XmlEnum("dN.m")]
        dNm,
        /// <summary>
        /// dohm property
        /// </summary>
        dohm,
        /// <summary>
        /// dP property
        /// </summary>
        dP,
        /// <summary>
        /// dPa property
        /// </summary>
        dPa,
        /// <summary>
        /// drd property
        /// </summary>
        drd,
        /// <summary>
        /// ds property
        /// </summary>
        ds,
        /// <summary>
        /// dS property
        /// </summary>
        dS,
        /// <summary>
        /// dT property
        /// </summary>
        dT,
        /// <summary>
        /// dV property
        /// </summary>
        dV,
        /// <summary>
        /// dW property
        /// </summary>
        dW,
        /// <summary>
        /// dWb property
        /// </summary>
        dWb,
        /// <summary>
        /// dyne property
        /// </summary>
        dyne,
        /// <summary>
        /// dynecm2 property
        /// </summary>
        [XmlEnum("dyne.cm2")]
        dynecm2,
        /// <summary>
        /// dynescm2 property
        /// </summary>
        [XmlEnum("dyne.s/cm2")]
        dynescm2,
        /// <summary>
        /// dynecm property
        /// </summary>
        [XmlEnum("dyne/cm")]
        dynecm,
        /// <summary>
        /// dynecm21 property
        /// </summary>
        [XmlEnum("dyne/cm2")]
        dynecm21,
        /// <summary>
        /// EA property
        /// </summary>
        EA,
        /// <summary>
        /// Eat property
        /// </summary>
        [XmlEnum("Ea[t]")]
        Eat,
        /// <summary>
        /// EC property
        /// </summary>
        EC,
        /// <summary>
        /// Ecalth property
        /// </summary>
        [XmlEnum("Ecal[th]")]
        Ecalth,
        /// <summary>
        /// EEuc property
        /// </summary>
        EEuc,
        /// <summary>
        /// EeV property
        /// </summary>
        EeV,
        /// <summary>
        /// EF property
        /// </summary>
        EF,
        /// <summary>
        /// Eg property
        /// </summary>
        Eg,
        /// <summary>
        /// Egauss property
        /// </summary>
        Egauss,
        /// <summary>
        /// EGy property
        /// </summary>
        EGy,
        /// <summary>
        /// EH property
        /// </summary>
        EH,
        /// <summary>
        /// EHz property
        /// </summary>
        EHz,
        /// <summary>
        /// EJ property
        /// </summary>
        EJ,
        /// <summary>
        /// EJa property
        /// </summary>
        [XmlEnum("EJ/a")]
        EJa,
        /// <summary>
        /// Em property
        /// </summary>
        Em,
        /// <summary>
        /// EN property
        /// </summary>
        EN,
        /// <summary>
        /// Eohm property
        /// </summary>
        Eohm,
        /// <summary>
        /// EP property
        /// </summary>
        EP,
        /// <summary>
        /// EPa property
        /// </summary>
        EPa,
        /// <summary>
        /// Erd property
        /// </summary>
        Erd,
        /// <summary>
        /// erg property
        /// </summary>
        erg,
        /// <summary>
        /// erga property
        /// </summary>
        [XmlEnum("erg/a")]
        erga,
        /// <summary>
        /// ergcm2 property
        /// </summary>
        [XmlEnum("erg/cm2")]
        ergcm2,
        /// <summary>
        /// ergcm3 property
        /// </summary>
        [XmlEnum("erg/cm3")]
        ergcm3,
        /// <summary>
        /// ergg property
        /// </summary>
        [XmlEnum("erg/g")]
        ergg,
        /// <summary>
        /// ergkg property
        /// </summary>
        [XmlEnum("erg/kg")]
        ergkg,
        /// <summary>
        /// ergm3 property
        /// </summary>
        [XmlEnum("erg/m3")]
        ergm3,
        /// <summary>
        /// ES property
        /// </summary>
        ES,
        /// <summary>
        /// ET property
        /// </summary>
        ET,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// eV property
        /// </summary>
        eV,
        /// <summary>
        /// EW property
        /// </summary>
        EW,
        /// <summary>
        /// EWb property
        /// </summary>
        EWb,
        /// <summary>
        /// F property
        /// </summary>
        F,
        /// <summary>
        /// Fm property
        /// </summary>
        [XmlEnum("F/m")]
        Fm,
        /// <summary>
        /// fa property
        /// </summary>
        fa,
        /// <summary>
        /// fA property
        /// </summary>
        fA,
        /// <summary>
        /// fathom property
        /// </summary>
        fathom,
        /// <summary>
        /// fC property
        /// </summary>
        fC,
        /// <summary>
        /// fcalth property
        /// </summary>
        [XmlEnum("fcal[th]")]
        fcalth,
        /// <summary>
        /// fEuc property
        /// </summary>
        fEuc,
        /// <summary>
        /// feV property
        /// </summary>
        feV,
        /// <summary>
        /// fF property
        /// </summary>
        fF,
        /// <summary>
        /// fg property
        /// </summary>
        fg,
        /// <summary>
        /// fgauss property
        /// </summary>
        fgauss,
        /// <summary>
        /// fGy property
        /// </summary>
        fGy,
        /// <summary>
        /// fH property
        /// </summary>
        fH,
        /// <summary>
        /// fHz property
        /// </summary>
        fHz,
        /// <summary>
        /// fJ property
        /// </summary>
        fJ,
        /// <summary>
        /// flozUK property
        /// </summary>
        [XmlEnum("floz[UK]")]
        flozUK,
        /// <summary>
        /// flozUS property
        /// </summary>
        [XmlEnum("floz[US]")]
        flozUS,
        /// <summary>
        /// fm property
        /// </summary>
        fm,
        /// <summary>
        /// fN property
        /// </summary>
        fN,
        /// <summary>
        /// fohm property
        /// </summary>
        fohm,
        /// <summary>
        /// footcandle property
        /// </summary>
        footcandle,
        /// <summary>
        /// footcandles property
        /// </summary>
        [XmlEnum("footcandle.s")]
        footcandles,
        /// <summary>
        /// fP property
        /// </summary>
        fP,
        /// <summary>
        /// fPa property
        /// </summary>
        fPa,
        /// <summary>
        /// frd property
        /// </summary>
        frd,
        /// <summary>
        /// fS property
        /// </summary>
        fS,
        /// <summary>
        /// ft property
        /// </summary>
        ft,
        /// <summary>
        /// fT property
        /// </summary>
        fT,
        /// <summary>
        /// ftbbl property
        /// </summary>
        [XmlEnum("ft/bbl")]
        ftbbl,
        /// <summary>
        /// ftd property
        /// </summary>
        [XmlEnum("ft/d")]
        ftd,
        /// <summary>
        /// ftdegF property
        /// </summary>
        [XmlEnum("ft/degF")]
        ftdegF,
        /// <summary>
        /// ftft property
        /// </summary>
        [XmlEnum("ft/ft")]
        ftft,
        /// <summary>
        /// ftft3 property
        /// </summary>
        [XmlEnum("ft/ft3")]
        ftft3,
        /// <summary>
        /// ftgalUS property
        /// </summary>
        [XmlEnum("ft/gal[US]")]
        ftgalUS,
        /// <summary>
        /// fth property
        /// </summary>
        [XmlEnum("ft/h")]
        fth,
        /// <summary>
        /// ftin property
        /// </summary>
        [XmlEnum("ft/in")]
        ftin,
        /// <summary>
        /// ftlbm property
        /// </summary>
        [XmlEnum("ft/lbm")]
        ftlbm,
        /// <summary>
        /// ftm property
        /// </summary>
        [XmlEnum("ft/m")]
        ftm,
        /// <summary>
        /// ftmi property
        /// </summary>
        [XmlEnum("ft/mi")]
        ftmi,
        /// <summary>
        /// ftmin property
        /// </summary>
        [XmlEnum("ft/min")]
        ftmin,
        /// <summary>
        /// ftms property
        /// </summary>
        [XmlEnum("ft/ms")]
        ftms,
        /// <summary>
        /// ftpsi property
        /// </summary>
        [XmlEnum("ft/psi")]
        ftpsi,
        /// <summary>
        /// fts property
        /// </summary>
        [XmlEnum("ft/s")]
        fts,
        /// <summary>
        /// fts2 property
        /// </summary>
        [XmlEnum("ft/s2")]
        fts2,
        /// <summary>
        /// ftus property
        /// </summary>
        [XmlEnum("ft/us")]
        ftus,
        /// <summary>
        /// ftBnA property
        /// </summary>
        [XmlEnum("ft[BnA]")]
        ftBnA,
        /// <summary>
        /// ftBnB property
        /// </summary>
        [XmlEnum("ft[BnB]")]
        ftBnB,
        /// <summary>
        /// ftBr36 property
        /// </summary>
        [XmlEnum("ft[Br36]")]
        ftBr36,
        /// <summary>
        /// ftBr65 property
        /// </summary>
        [XmlEnum("ft[Br65]")]
        ftBr65,
        /// <summary>
        /// ftCla property
        /// </summary>
        [XmlEnum("ft[Cla]")]
        ftCla,
        /// <summary>
        /// ftGC property
        /// </summary>
        [XmlEnum("ft[GC]")]
        ftGC,
        /// <summary>
        /// ftInd property
        /// </summary>
        [XmlEnum("ft[Ind]")]
        ftInd,
        /// <summary>
        /// ftInd37 property
        /// </summary>
        [XmlEnum("ft[Ind37]")]
        ftInd37,
        /// <summary>
        /// ftInd62 property
        /// </summary>
        [XmlEnum("ft[Ind62]")]
        ftInd62,
        /// <summary>
        /// ftInd75 property
        /// </summary>
        [XmlEnum("ft[Ind75]")]
        ftInd75,
        /// <summary>
        /// ftSe property
        /// </summary>
        [XmlEnum("ft[Se]")]
        ftSe,
        /// <summary>
        /// ftSeT property
        /// </summary>
        [XmlEnum("ft[SeT]")]
        ftSeT,
        /// <summary>
        /// ftUS property
        /// </summary>
        [XmlEnum("ft[US]")]
        ftUS,
        /// <summary>
        /// ft2 property
        /// </summary>
        ft2,
        /// <summary>
        /// ft2h property
        /// </summary>
        [XmlEnum("ft2/h")]
        ft2h,
        /// <summary>
        /// ft2in3 property
        /// </summary>
        [XmlEnum("ft2/in3")]
        ft2in3,
        /// <summary>
        /// ft2lbm property
        /// </summary>
        [XmlEnum("ft2/lbm")]
        ft2lbm,
        /// <summary>
        /// ft2s property
        /// </summary>
        [XmlEnum("ft2/s")]
        ft2s,
        /// <summary>
        /// ft3 property
        /// </summary>
        ft3,
        /// <summary>
        /// ft3dft property
        /// </summary>
        [XmlEnum("ft3/(d.ft)")]
        ft3dft,
        /// <summary>
        /// ft3ftpsid property
        /// </summary>
        [XmlEnum("ft3/(ft.psi.d)")]
        ft3ftpsid,
        /// <summary>
        /// ft3minft2 property
        /// </summary>
        [XmlEnum("ft3/(min.ft2)")]
        ft3minft2,
        /// <summary>
        /// ft3sft2 property
        /// </summary>
        [XmlEnum("ft3/(s.ft2)")]
        ft3sft2,
        /// <summary>
        /// ft3bbl property
        /// </summary>
        [XmlEnum("ft3/bbl")]
        ft3bbl,
        /// <summary>
        /// ft3d property
        /// </summary>
        [XmlEnum("ft3/d")]
        ft3d,
        /// <summary>
        /// ft3d2 property
        /// </summary>
        [XmlEnum("ft3/d2")]
        ft3d2,
        /// <summary>
        /// ft3ft property
        /// </summary>
        [XmlEnum("ft3/ft")]
        ft3ft,
        /// <summary>
        /// ft3ft2 property
        /// </summary>
        [XmlEnum("ft3/ft2")]
        ft3ft2,
        /// <summary>
        /// ft3ft3 property
        /// </summary>
        [XmlEnum("ft3/ft3")]
        ft3ft3,
        /// <summary>
        /// ft3h property
        /// </summary>
        [XmlEnum("ft3/h")]
        ft3h,
        /// <summary>
        /// ft3h2 property
        /// </summary>
        [XmlEnum("ft3/h2")]
        ft3h2,
        /// <summary>
        /// ft3kg property
        /// </summary>
        [XmlEnum("ft3/kg")]
        ft3kg,
        /// <summary>
        /// ft3lbm property
        /// </summary>
        [XmlEnum("ft3/lbm")]
        ft3lbm,
        /// <summary>
        /// ft3lbmol property
        /// </summary>
        [XmlEnum("ft3/lbmol")]
        ft3lbmol,
        /// <summary>
        /// ft3min property
        /// </summary>
        [XmlEnum("ft3/min")]
        ft3min,
        /// <summary>
        /// ft3min2 property
        /// </summary>
        [XmlEnum("ft3/min2")]
        ft3min2,
        /// <summary>
        /// ft3rad property
        /// </summary>
        [XmlEnum("ft3/rad")]
        ft3rad,
        /// <summary>
        /// ft3s property
        /// </summary>
        [XmlEnum("ft3/s")]
        ft3s,
        /// <summary>
        /// ft3s2 property
        /// </summary>
        [XmlEnum("ft3/s2")]
        ft3s2,
        /// <summary>
        /// ft3sack94lbm property
        /// </summary>
        [XmlEnum("ft3/sack[94lbm]")]
        ft3sack94lbm,
        /// <summary>
        /// furUS property
        /// </summary>
        [XmlEnum("fur[US]")]
        furUS,
        /// <summary>
        /// fV property
        /// </summary>
        fV,
        /// <summary>
        /// fW property
        /// </summary>
        fW,
        /// <summary>
        /// fWb property
        /// </summary>
        fWb,
        /// <summary>
        /// g property
        /// </summary>
        g,
        /// <summary>
        /// gftcm3s property
        /// </summary>
        [XmlEnum("g.ft/(cm3.s)")]
        gftcm3s,
        /// <summary>
        /// gmcm3s property
        /// </summary>
        [XmlEnum("g.m/(cm3.s)")]
        gmcm3s,
        /// <summary>
        /// gcm3 property
        /// </summary>
        [XmlEnum("g/cm3")]
        gcm3,
        /// <summary>
        /// gcm4 property
        /// </summary>
        [XmlEnum("g/cm4")]
        gcm4,
        /// <summary>
        /// gdm3 property
        /// </summary>
        [XmlEnum("g/dm3")]
        gdm3,
        /// <summary>
        /// ggalUK property
        /// </summary>
        [XmlEnum("g/gal[UK]")]
        ggalUK,
        /// <summary>
        /// ggalUS property
        /// </summary>
        [XmlEnum("g/gal[US]")]
        ggalUS,
        /// <summary>
        /// gkg property
        /// </summary>
        [XmlEnum("g/kg")]
        gkg,
        /// <summary>
        /// gL property
        /// </summary>
        [XmlEnum("g/L")]
        gL,
        /// <summary>
        /// gm3 property
        /// </summary>
        [XmlEnum("g/m3")]
        gm3,
        /// <summary>
        /// gmol property
        /// </summary>
        [XmlEnum("g/mol")]
        gmol,
        /// <summary>
        /// gs property
        /// </summary>
        [XmlEnum("g/s")]
        gs,
        /// <summary>
        /// gt property
        /// </summary>
        [XmlEnum("g/t")]
        gt,
        /// <summary>
        /// GA property
        /// </summary>
        GA,
        /// <summary>
        /// Gat property
        /// </summary>
        [XmlEnum("Ga[t]")]
        Gat,
        /// <summary>
        /// Gal property
        /// </summary>
        Gal,
        /// <summary>
        /// galUK property
        /// </summary>
        [XmlEnum("gal[UK]")]
        galUK,
        /// <summary>
        /// galUKhft property
        /// </summary>
        [XmlEnum("gal[UK]/(h.ft)")]
        galUKhft,
        /// <summary>
        /// galUKhft2 property
        /// </summary>
        [XmlEnum("gal[UK]/(h.ft2)")]
        galUKhft2,
        /// <summary>
        /// galUKhin property
        /// </summary>
        [XmlEnum("gal[UK]/(h.in)")]
        galUKhin,
        /// <summary>
        /// galUKhin2 property
        /// </summary>
        [XmlEnum("gal[UK]/(h.in2)")]
        galUKhin2,
        /// <summary>
        /// galUKminft property
        /// </summary>
        [XmlEnum("gal[UK]/(min.ft)")]
        galUKminft,
        /// <summary>
        /// galUKminft2 property
        /// </summary>
        [XmlEnum("gal[UK]/(min.ft2)")]
        galUKminft2,
        /// <summary>
        /// galUKd property
        /// </summary>
        [XmlEnum("gal[UK]/d")]
        galUKd,
        /// <summary>
        /// galUKft3 property
        /// </summary>
        [XmlEnum("gal[UK]/ft3")]
        galUKft3,
        /// <summary>
        /// galUKh property
        /// </summary>
        [XmlEnum("gal[UK]/h")]
        galUKh,
        /// <summary>
        /// galUKh2 property
        /// </summary>
        [XmlEnum("gal[UK]/h2")]
        galUKh2,
        /// <summary>
        /// galUKlbm property
        /// </summary>
        [XmlEnum("gal[UK]/lbm")]
        galUKlbm,
        /// <summary>
        /// galUKmi property
        /// </summary>
        [XmlEnum("gal[UK]/mi")]
        galUKmi,
        /// <summary>
        /// galUKmin property
        /// </summary>
        [XmlEnum("gal[UK]/min")]
        galUKmin,
        /// <summary>
        /// galUKmin2 property
        /// </summary>
        [XmlEnum("gal[UK]/min2")]
        galUKmin2,
        /// <summary>
        /// galUS property
        /// </summary>
        [XmlEnum("gal[US]")]
        galUS,
        /// <summary>
        /// galUShft property
        /// </summary>
        [XmlEnum("gal[US]/(h.ft)")]
        galUShft,
        /// <summary>
        /// galUShft2 property
        /// </summary>
        [XmlEnum("gal[US]/(h.ft2)")]
        galUShft2,
        /// <summary>
        /// galUShin property
        /// </summary>
        [XmlEnum("gal[US]/(h.in)")]
        galUShin,
        /// <summary>
        /// galUShin2 property
        /// </summary>
        [XmlEnum("gal[US]/(h.in2)")]
        galUShin2,
        /// <summary>
        /// galUSminft property
        /// </summary>
        [XmlEnum("gal[US]/(min.ft)")]
        galUSminft,
        /// <summary>
        /// galUSminft2 property
        /// </summary>
        [XmlEnum("gal[US]/(min.ft2)")]
        galUSminft2,
        /// <summary>
        /// galUSbbl property
        /// </summary>
        [XmlEnum("gal[US]/bbl")]
        galUSbbl,
        /// <summary>
        /// galUSd property
        /// </summary>
        [XmlEnum("gal[US]/d")]
        galUSd,
        /// <summary>
        /// galUSft property
        /// </summary>
        [XmlEnum("gal[US]/ft")]
        galUSft,
        /// <summary>
        /// galUSft3 property
        /// </summary>
        [XmlEnum("gal[US]/ft3")]
        galUSft3,
        /// <summary>
        /// galUSh property
        /// </summary>
        [XmlEnum("gal[US]/h")]
        galUSh,
        /// <summary>
        /// galUSh2 property
        /// </summary>
        [XmlEnum("gal[US]/h2")]
        galUSh2,
        /// <summary>
        /// galUSlbm property
        /// </summary>
        [XmlEnum("gal[US]/lbm")]
        galUSlbm,
        /// <summary>
        /// galUSmi property
        /// </summary>
        [XmlEnum("gal[US]/mi")]
        galUSmi,
        /// <summary>
        /// galUSmin property
        /// </summary>
        [XmlEnum("gal[US]/min")]
        galUSmin,
        /// <summary>
        /// galUSmin2 property
        /// </summary>
        [XmlEnum("gal[US]/min2")]
        galUSmin2,
        /// <summary>
        /// galUSsack94lbm property
        /// </summary>
        [XmlEnum("gal[US]/sack[94lbm]")]
        galUSsack94lbm,
        /// <summary>
        /// galUStonUK property
        /// </summary>
        [XmlEnum("gal[US]/ton[UK]")]
        galUStonUK,
        /// <summary>
        /// galUStonUS property
        /// </summary>
        [XmlEnum("gal[US]/ton[US]")]
        galUStonUS,
        /// <summary>
        /// gAPI property
        /// </summary>
        gAPI,
        /// <summary>
        /// gauss property
        /// </summary>
        gauss,
        /// <summary>
        /// gausscm property
        /// </summary>
        [XmlEnum("gauss/cm")]
        gausscm,
        /// <summary>
        /// GBq property
        /// </summary>
        GBq,
        /// <summary>
        /// GC property
        /// </summary>
        GC,
        /// <summary>
        /// Gcalth property
        /// </summary>
        [XmlEnum("Gcal[th]")]
        Gcalth,
        /// <summary>
        /// GEuc property
        /// </summary>
        GEuc,
        /// <summary>
        /// GeV property
        /// </summary>
        GeV,
        /// <summary>
        /// gf property
        /// </summary>
        gf,
        /// <summary>
        /// GF property
        /// </summary>
        GF,
        /// <summary>
        /// Gg property
        /// </summary>
        Gg,
        /// <summary>
        /// Ggauss property
        /// </summary>
        Ggauss,
        /// <summary>
        /// GGy property
        /// </summary>
        GGy,
        /// <summary>
        /// GH property
        /// </summary>
        GH,
        /// <summary>
        /// GHz property
        /// </summary>
        GHz,
        /// <summary>
        /// GJ property
        /// </summary>
        GJ,
        /// <summary>
        /// Gm property
        /// </summary>
        Gm,
        /// <summary>
        /// GN property
        /// </summary>
        GN,
        /// <summary>
        /// gn property
        /// </summary>
        gn,
        /// <summary>
        /// Gohm property
        /// </summary>
        Gohm,
        /// <summary>
        /// gon property
        /// </summary>
        gon,
        /// <summary>
        /// GP property
        /// </summary>
        GP,
        /// <summary>
        /// GPa property
        /// </summary>
        GPa,
        /// <summary>
        /// GPacm property
        /// </summary>
        [XmlEnum("GPa/cm")]
        GPacm,
        /// <summary>
        /// GPa2 property
        /// </summary>
        GPa2,
        /// <summary>
        /// grain property
        /// </summary>
        grain,
        /// <summary>
        /// grainft3 property
        /// </summary>
        [XmlEnum("grain/ft3")]
        grainft3,
        /// <summary>
        /// graingalUS property
        /// </summary>
        [XmlEnum("grain/gal[US]")]
        graingalUS,
        /// <summary>
        /// Grd property
        /// </summary>
        Grd,
        /// <summary>
        /// GS property
        /// </summary>
        GS,
        /// <summary>
        /// GT property
        /// </summary>
        GT,
        /// <summary>
        /// GV property
        /// </summary>
        GV,
        /// <summary>
        /// GW property
        /// </summary>
        GW,
        /// <summary>
        /// GWh property
        /// </summary>
        [XmlEnum("GW.h")]
        GWh,
        /// <summary>
        /// GWb property
        /// </summary>
        GWb,
        /// <summary>
        /// Gy property
        /// </summary>
        Gy,
        /// <summary>
        /// H property
        /// </summary>
        H,
        /// <summary>
        /// h property
        /// </summary>
        h,
        /// <summary>
        /// hft3 property
        /// </summary>
        [XmlEnum("h/ft3")]
        hft3,
        /// <summary>
        /// hkm property
        /// </summary>
        [XmlEnum("h/km")]
        hkm,
        /// <summary>
        /// Hm property
        /// </summary>
        [XmlEnum("H/m")]
        Hm,
        /// <summary>
        /// hm3 property
        /// </summary>
        [XmlEnum("h/m3")]
        hm3,
        /// <summary>
        /// ha property
        /// </summary>
        ha,
        /// <summary>
        /// ham property
        /// </summary>
        [XmlEnum("ha.m")]
        ham,
        /// <summary>
        /// hbar property
        /// </summary>
        hbar,
        /// <summary>
        /// hg property
        /// </summary>
        hg,
        /// <summary>
        /// hL property
        /// </summary>
        hL,
        /// <summary>
        /// hm property
        /// </summary>
        hm,
        /// <summary>
        /// hN property
        /// </summary>
        hN,
        /// <summary>
        /// hp property
        /// </summary>
        hp,
        /// <summary>
        /// hph property
        /// </summary>
        [XmlEnum("hp.h")]
        hph,
        /// <summary>
        /// hphbbl property
        /// </summary>
        [XmlEnum("hp.h/bbl")]
        hphbbl,
        /// <summary>
        /// hphlbm property
        /// </summary>
        [XmlEnum("hp.h/lbm")]
        hphlbm,
        /// <summary>
        /// hpft3 property
        /// </summary>
        [XmlEnum("hp/ft3")]
        hpft3,
        /// <summary>
        /// hpin2 property
        /// </summary>
        [XmlEnum("hp/in2")]
        hpin2,
        /// <summary>
        /// hpelec property
        /// </summary>
        [XmlEnum("hp[elec]")]
        hpelec,
        /// <summary>
        /// hphyd property
        /// </summary>
        [XmlEnum("hp[hyd]")]
        hphyd,
        /// <summary>
        /// hphydin2 property
        /// </summary>
        [XmlEnum("hp[hyd]/in2")]
        hphydin2,
        /// <summary>
        /// hpmetric property
        /// </summary>
        [XmlEnum("hp[metric]")]
        hpmetric,
        /// <summary>
        /// hpmetrich property
        /// </summary>
        [XmlEnum("hp[metric].h")]
        hpmetrich,
        /// <summary>
        /// hs property
        /// </summary>
        hs,
        /// <summary>
        /// Hz property
        /// </summary>
        Hz,
        /// <summary>
        /// in property
        /// </summary>
        @in,
        /// <summary>
        /// inindegF property
        /// </summary>
        [XmlEnum("in/(in.degF)")]
        inindegF,
        /// <summary>
        /// ina property
        /// </summary>
        [XmlEnum("in/a")]
        ina,
        /// <summary>
        /// inmin property
        /// </summary>
        [XmlEnum("in/min")]
        inmin,
        /// <summary>
        /// ins property
        /// </summary>
        [XmlEnum("in/s")]
        ins,
        /// <summary>
        /// ins2 property
        /// </summary>
        [XmlEnum("in/s2")]
        ins2,
        /// <summary>
        /// inUS property
        /// </summary>
        [XmlEnum("in[US]")]
        inUS,
        /// <summary>
        /// in2 property
        /// </summary>
        in2,
        /// <summary>
        /// in2ft2 property
        /// </summary>
        [XmlEnum("in2/ft2")]
        in2ft2,
        /// <summary>
        /// in2in2 property
        /// </summary>
        [XmlEnum("in2/in2")]
        in2in2,
        /// <summary>
        /// in2s property
        /// </summary>
        [XmlEnum("in2/s")]
        in2s,
        /// <summary>
        /// in3 property
        /// </summary>
        in3,
        /// <summary>
        /// in3ft property
        /// </summary>
        [XmlEnum("in3/ft")]
        in3ft,
        /// <summary>
        /// in4 property
        /// </summary>
        in4,
        /// <summary>
        /// inH2O39degF property
        /// </summary>
        [XmlEnum("inH2O[39degF]")]
        inH2O39degF,
        /// <summary>
        /// inH2O60degF property
        /// </summary>
        [XmlEnum("inH2O[60degF]")]
        inH2O60degF,
        /// <summary>
        /// inHg32degF property
        /// </summary>
        [XmlEnum("inHg[32degF]")]
        inHg32degF,
        /// <summary>
        /// inHg60degF property
        /// </summary>
        [XmlEnum("inHg[60degF]")]
        inHg60degF,
        /// <summary>
        /// J property
        /// </summary>
        J,
        /// <summary>
        /// Jmsm2K property
        /// </summary>
        [XmlEnum("J.m/(s.m2.K)")]
        Jmsm2K,
        /// <summary>
        /// Jmm2 property
        /// </summary>
        [XmlEnum("J.m/m2")]
        Jmm2,
        /// <summary>
        /// JgK property
        /// </summary>
        [XmlEnum("J/(g.K)")]
        JgK,
        /// <summary>
        /// JkgK property
        /// </summary>
        [XmlEnum("J/(kg.K)")]
        JkgK,
        /// <summary>
        /// JmolK property
        /// </summary>
        [XmlEnum("J/(mol.K)")]
        JmolK,
        /// <summary>
        /// Jsm2degC property
        /// </summary>
        [XmlEnum("J/(s.m2.degC)")]
        Jsm2degC,
        /// <summary>
        /// Jcm2 property
        /// </summary>
        [XmlEnum("J/cm2")]
        Jcm2,
        /// <summary>
        /// Jdm3 property
        /// </summary>
        [XmlEnum("J/dm3")]
        Jdm3,
        /// <summary>
        /// Jg property
        /// </summary>
        [XmlEnum("J/g")]
        Jg,
        /// <summary>
        /// JK property
        /// </summary>
        [XmlEnum("J/K")]
        JK,
        /// <summary>
        /// Jkg property
        /// </summary>
        [XmlEnum("J/kg")]
        Jkg,
        /// <summary>
        /// Jm property
        /// </summary>
        [XmlEnum("J/m")]
        Jm,
        /// <summary>
        /// Jm2 property
        /// </summary>
        [XmlEnum("J/m2")]
        Jm2,
        /// <summary>
        /// Jm3 property
        /// </summary>
        [XmlEnum("J/m3")]
        Jm3,
        /// <summary>
        /// Jmol property
        /// </summary>
        [XmlEnum("J/mol")]
        Jmol,
        /// <summary>
        /// Js property
        /// </summary>
        [XmlEnum("J/s")]
        Js,
        /// <summary>
        /// K property
        /// </summary>
        K,
        /// <summary>
        /// Km2kW property
        /// </summary>
        [XmlEnum("K.m2/kW")]
        Km2kW,
        /// <summary>
        /// Km2W property
        /// </summary>
        [XmlEnum("K.m2/W")]
        Km2W,
        /// <summary>
        /// Kkm property
        /// </summary>
        [XmlEnum("K/km")]
        Kkm,
        /// <summary>
        /// Km property
        /// </summary>
        [XmlEnum("K/m")]
        Km,
        /// <summary>
        /// KPa property
        /// </summary>
        [XmlEnum("K/Pa")]
        KPa,
        /// <summary>
        /// Ks property
        /// </summary>
        [XmlEnum("K/s")]
        Ks,
        /// <summary>
        /// KW property
        /// </summary>
        [XmlEnum("K/W")]
        KW,
        /// <summary>
        /// kA property
        /// </summary>
        kA,
        /// <summary>
        /// kat property
        /// </summary>
        [XmlEnum("ka[t]")]
        kat,
        /// <summary>
        /// kC property
        /// </summary>
        kC,
        /// <summary>
        /// kcalth property
        /// </summary>
        [XmlEnum("kcal[th]")]
        kcalth,
        /// <summary>
        /// kcalthmcm2 property
        /// </summary>
        [XmlEnum("kcal[th].m/cm2")]
        kcalthmcm2,
        /// <summary>
        /// kcalthhmdegC property
        /// </summary>
        [XmlEnum("kcal[th]/(h.m.degC)")]
        kcalthhmdegC,
        /// <summary>
        /// kcalthhm2degC property
        /// </summary>
        [XmlEnum("kcal[th]/(h.m2.degC)")]
        kcalthhm2degC,
        /// <summary>
        /// kcalthkgdegC property
        /// </summary>
        [XmlEnum("kcal[th]/(kg.degC)")]
        kcalthkgdegC,
        /// <summary>
        /// kcalthcm3 property
        /// </summary>
        [XmlEnum("kcal[th]/cm3")]
        kcalthcm3,
        /// <summary>
        /// kcalthg property
        /// </summary>
        [XmlEnum("kcal[th]/g")]
        kcalthg,
        /// <summary>
        /// kcalthh property
        /// </summary>
        [XmlEnum("kcal[th]/h")]
        kcalthh,
        /// <summary>
        /// kcalthkg property
        /// </summary>
        [XmlEnum("kcal[th]/kg")]
        kcalthkg,
        /// <summary>
        /// kcalthm3 property
        /// </summary>
        [XmlEnum("kcal[th]/m3")]
        kcalthm3,
        /// <summary>
        /// kcalthmol property
        /// </summary>
        [XmlEnum("kcal[th]/mol")]
        kcalthmol,
        /// <summary>
        /// kcd property
        /// </summary>
        kcd,
        /// <summary>
        /// kdyne property
        /// </summary>
        kdyne,
        /// <summary>
        /// kEuc property
        /// </summary>
        kEuc,
        /// <summary>
        /// keV property
        /// </summary>
        keV,
        /// <summary>
        /// kF property
        /// </summary>
        kF,
        /// <summary>
        /// kg property
        /// </summary>
        kg,
        /// <summary>
        /// kgm property
        /// </summary>
        [XmlEnum("kg.m")]
        kgm,
        /// <summary>
        /// kgmcm2 property
        /// </summary>
        [XmlEnum("kg.m/cm2")]
        kgmcm2,
        /// <summary>
        /// kgms property
        /// </summary>
        [XmlEnum("kg.m/s")]
        kgms,
        /// <summary>
        /// kgm2 property
        /// </summary>
        [XmlEnum("kg.m2")]
        kgm2,
        /// <summary>
        /// kgkWh property
        /// </summary>
        [XmlEnum("kg/(kW.h)")]
        kgkWh,
        /// <summary>
        /// kgms1 property
        /// </summary>
        [XmlEnum("kg/(m.s)")]
        kgms1,
        /// <summary>
        /// kgm2s property
        /// </summary>
        [XmlEnum("kg/(m2.s)")]
        kgm2s,
        /// <summary>
        /// kgd property
        /// </summary>
        [XmlEnum("kg/d")]
        kgd,
        /// <summary>
        /// kgdm3 property
        /// </summary>
        [XmlEnum("kg/dm3")]
        kgdm3,
        /// <summary>
        /// kgdm4 property
        /// </summary>
        [XmlEnum("kg/dm4")]
        kgdm4,
        /// <summary>
        /// kgh property
        /// </summary>
        [XmlEnum("kg/h")]
        kgh,
        /// <summary>
        /// kgJ property
        /// </summary>
        [XmlEnum("kg/J")]
        kgJ,
        /// <summary>
        /// kgkg property
        /// </summary>
        [XmlEnum("kg/kg")]
        kgkg,
        /// <summary>
        /// kgL property
        /// </summary>
        [XmlEnum("kg/L")]
        kgL,
        /// <summary>
        /// kgm1 property
        /// </summary>
        [XmlEnum("kg/m")]
        kgm1,
        /// <summary>
        /// kgm21 property
        /// </summary>
        [XmlEnum("kg/m2")]
        kgm21,
        /// <summary>
        /// kgm3 property
        /// </summary>
        [XmlEnum("kg/m3")]
        kgm3,
        /// <summary>
        /// kgm4 property
        /// </summary>
        [XmlEnum("kg/m4")]
        kgm4,
        /// <summary>
        /// kgmin property
        /// </summary>
        [XmlEnum("kg/min")]
        kgmin,
        /// <summary>
        /// kgMJ property
        /// </summary>
        [XmlEnum("kg/MJ")]
        kgMJ,
        /// <summary>
        /// kgmol property
        /// </summary>
        [XmlEnum("kg/mol")]
        kgmol,
        /// <summary>
        /// kgs property
        /// </summary>
        [XmlEnum("kg/s")]
        kgs,
        /// <summary>
        /// kgsack94lbm property
        /// </summary>
        [XmlEnum("kg/sack[94lbm]")]
        kgsack94lbm,
        /// <summary>
        /// kgt property
        /// </summary>
        [XmlEnum("kg/t")]
        kgt,
        /// <summary>
        /// kgauss property
        /// </summary>
        kgauss,
        /// <summary>
        /// kgf property
        /// </summary>
        kgf,
        /// <summary>
        /// kgfm property
        /// </summary>
        [XmlEnum("kgf.m")]
        kgfm,
        /// <summary>
        /// kgfmcm2 property
        /// </summary>
        [XmlEnum("kgf.m/cm2")]
        kgfmcm2,
        /// <summary>
        /// kgfmm property
        /// </summary>
        [XmlEnum("kgf.m/m")]
        kgfmm,
        /// <summary>
        /// kgfm2 property
        /// </summary>
        [XmlEnum("kgf.m2")]
        kgfm2,
        /// <summary>
        /// kgfsm2 property
        /// </summary>
        [XmlEnum("kgf.s/m2")]
        kgfsm2,
        /// <summary>
        /// kgfcm property
        /// </summary>
        [XmlEnum("kgf/cm")]
        kgfcm,
        /// <summary>
        /// kgfcm2 property
        /// </summary>
        [XmlEnum("kgf/cm2")]
        kgfcm2,
        /// <summary>
        /// kgfkgf property
        /// </summary>
        [XmlEnum("kgf/kgf")]
        kgfkgf,
        /// <summary>
        /// kgfm21 property
        /// </summary>
        [XmlEnum("kgf/m2")]
        kgfm21,
        /// <summary>
        /// kgfmm2 property
        /// </summary>
        [XmlEnum("kgf/mm2")]
        kgfmm2,
        /// <summary>
        /// kGy property
        /// </summary>
        kGy,
        /// <summary>
        /// kH property
        /// </summary>
        kH,
        /// <summary>
        /// kHz property
        /// </summary>
        kHz,
        /// <summary>
        /// Kibyte property
        /// </summary>
        Kibyte,
        /// <summary>
        /// kJ property
        /// </summary>
        kJ,
        /// <summary>
        /// kJmhm2K property
        /// </summary>
        [XmlEnum("kJ.m/(h.m2.K)")]
        kJmhm2K,
        /// <summary>
        /// kJhm2K property
        /// </summary>
        [XmlEnum("kJ/(h.m2.K)")]
        kJhm2K,
        /// <summary>
        /// kJkgK property
        /// </summary>
        [XmlEnum("kJ/(kg.K)")]
        kJkgK,
        /// <summary>
        /// kJkmolK property
        /// </summary>
        [XmlEnum("kJ/(kmol.K)")]
        kJkmolK,
        /// <summary>
        /// kJdm3 property
        /// </summary>
        [XmlEnum("kJ/dm3")]
        kJdm3,
        /// <summary>
        /// kJkg property
        /// </summary>
        [XmlEnum("kJ/kg")]
        kJkg,
        /// <summary>
        /// kJkmol property
        /// </summary>
        [XmlEnum("kJ/kmol")]
        kJkmol,
        /// <summary>
        /// kJm3 property
        /// </summary>
        [XmlEnum("kJ/m3")]
        kJm3,
        /// <summary>
        /// klbf property
        /// </summary>
        klbf,
        /// <summary>
        /// klbm property
        /// </summary>
        klbm,
        /// <summary>
        /// klbmin property
        /// </summary>
        [XmlEnum("klbm/in")]
        klbmin,
        /// <summary>
        /// klx property
        /// </summary>
        klx,
        /// <summary>
        /// km property
        /// </summary>
        km,
        /// <summary>
        /// kmcm property
        /// </summary>
        [XmlEnum("km/cm")]
        kmcm,
        /// <summary>
        /// kmdm3 property
        /// </summary>
        [XmlEnum("km/dm3")]
        kmdm3,
        /// <summary>
        /// kmh property
        /// </summary>
        [XmlEnum("km/h")]
        kmh,
        /// <summary>
        /// kmL property
        /// </summary>
        [XmlEnum("km/L")]
        kmL,
        /// <summary>
        /// kms property
        /// </summary>
        [XmlEnum("km/s")]
        kms,
        /// <summary>
        /// km2 property
        /// </summary>
        km2,
        /// <summary>
        /// km3 property
        /// </summary>
        km3,
        /// <summary>
        /// kmol property
        /// </summary>
        kmol,
        /// <summary>
        /// kmolh property
        /// </summary>
        [XmlEnum("kmol/h")]
        kmolh,
        /// <summary>
        /// kmolm3 property
        /// </summary>
        [XmlEnum("kmol/m3")]
        kmolm3,
        /// <summary>
        /// kmols property
        /// </summary>
        [XmlEnum("kmol/s")]
        kmols,
        /// <summary>
        /// kN property
        /// </summary>
        kN,
        /// <summary>
        /// kNm property
        /// </summary>
        [XmlEnum("kN.m")]
        kNm,
        /// <summary>
        /// kNm2 property
        /// </summary>
        [XmlEnum("kN.m2")]
        kNm2,
        /// <summary>
        /// kNm1 property
        /// </summary>
        [XmlEnum("kN/m")]
        kNm1,
        /// <summary>
        /// kNm21 property
        /// </summary>
        [XmlEnum("kN/m2")]
        kNm21,
        /// <summary>
        /// knot property
        /// </summary>
        knot,
        /// <summary>
        /// kohm property
        /// </summary>
        kohm,
        /// <summary>
        /// kohmm property
        /// </summary>
        [XmlEnum("kohm.m")]
        kohmm,
        /// <summary>
        /// kP property
        /// </summary>
        kP,
        /// <summary>
        /// kPa property
        /// </summary>
        kPa,
        /// <summary>
        /// kPasm property
        /// </summary>
        [XmlEnum("kPa.s/m")]
        kPasm,
        /// <summary>
        /// kPah property
        /// </summary>
        [XmlEnum("kPa/h")]
        kPah,
        /// <summary>
        /// kPahm property
        /// </summary>
        [XmlEnum("kPa/hm")]
        kPahm,
        /// <summary>
        /// kPam property
        /// </summary>
        [XmlEnum("kPa/m")]
        kPam,
        /// <summary>
        /// kPamin property
        /// </summary>
        [XmlEnum("kPa/min")]
        kPamin,
        /// <summary>
        /// kPa2 property
        /// </summary>
        kPa2,
        /// <summary>
        /// kPa2cP property
        /// </summary>
        [XmlEnum("kPa2/cP")]
        kPa2cP,
        /// <summary>
        /// kpsi property
        /// </summary>
        kpsi,
        /// <summary>
        /// kpsi2 property
        /// </summary>
        kpsi2,
        /// <summary>
        /// krad property
        /// </summary>
        krad,
        /// <summary>
        /// krd property
        /// </summary>
        krd,
        /// <summary>
        /// kS property
        /// </summary>
        kS,
        /// <summary>
        /// kSm property
        /// </summary>
        [XmlEnum("kS/m")]
        kSm,
        /// <summary>
        /// kT property
        /// </summary>
        kT,
        /// <summary>
        /// kV property
        /// </summary>
        kV,
        /// <summary>
        /// kW property
        /// </summary>
        kW,
        /// <summary>
        /// kWh property
        /// </summary>
        [XmlEnum("kW.h")]
        kWh,
        /// <summary>
        /// kWhkgdegC property
        /// </summary>
        [XmlEnum("kW.h/(kg.degC)")]
        kWhkgdegC,
        /// <summary>
        /// kWhdm3 property
        /// </summary>
        [XmlEnum("kW.h/dm3")]
        kWhdm3,
        /// <summary>
        /// kWhkg property
        /// </summary>
        [XmlEnum("kW.h/kg")]
        kWhkg,
        /// <summary>
        /// kWhm3 property
        /// </summary>
        [XmlEnum("kW.h/m3")]
        kWhm3,
        /// <summary>
        /// kWm2K property
        /// </summary>
        [XmlEnum("kW/(m2.K)")]
        kWm2K,
        /// <summary>
        /// kWm3K property
        /// </summary>
        [XmlEnum("kW/(m3.K)")]
        kWm3K,
        /// <summary>
        /// kWcm2 property
        /// </summary>
        [XmlEnum("kW/cm2")]
        kWcm2,
        /// <summary>
        /// kWm2 property
        /// </summary>
        [XmlEnum("kW/m2")]
        kWm2,
        /// <summary>
        /// kWm3 property
        /// </summary>
        [XmlEnum("kW/m3")]
        kWm3,
        /// <summary>
        /// kWb property
        /// </summary>
        kWb,
        /// <summary>
        /// L property
        /// </summary>
        L,
        /// <summary>
        /// Lbarmin property
        /// </summary>
        [XmlEnum("L/(bar.min)")]
        Lbarmin,
        /// <summary>
        /// Lh property
        /// </summary>
        [XmlEnum("L/h")]
        Lh,
        /// <summary>
        /// Lkg property
        /// </summary>
        [XmlEnum("L/kg")]
        Lkg,
        /// <summary>
        /// Lkmol property
        /// </summary>
        [XmlEnum("L/kmol")]
        Lkmol,
        /// <summary>
        /// Lm property
        /// </summary>
        [XmlEnum("L/m")]
        Lm,
        /// <summary>
        /// Lm3 property
        /// </summary>
        [XmlEnum("L/m3")]
        Lm3,
        /// <summary>
        /// Lmin property
        /// </summary>
        [XmlEnum("L/min")]
        Lmin,
        /// <summary>
        /// Lmol property
        /// </summary>
        [XmlEnum("L/mol")]
        Lmol,
        /// <summary>
        /// Ls property
        /// </summary>
        [XmlEnum("L/s")]
        Ls,
        /// <summary>
        /// Ls2 property
        /// </summary>
        [XmlEnum("L/s2")]
        Ls2,
        /// <summary>
        /// Lt property
        /// </summary>
        [XmlEnum("L/t")]
        Lt,
        /// <summary>
        /// LtonUK property
        /// </summary>
        [XmlEnum("L/ton[UK]")]
        LtonUK,
        /// <summary>
        /// lbf property
        /// </summary>
        lbf,
        /// <summary>
        /// lbfft property
        /// </summary>
        [XmlEnum("lbf.ft")]
        lbfft,
        /// <summary>
        /// lbfftbbl property
        /// </summary>
        [XmlEnum("lbf.ft/bbl")]
        lbfftbbl,
        /// <summary>
        /// lbfftgalUS property
        /// </summary>
        [XmlEnum("lbf.ft/gal[US]")]
        lbfftgalUS,
        /// <summary>
        /// lbfftin property
        /// </summary>
        [XmlEnum("lbf.ft/in")]
        lbfftin,
        /// <summary>
        /// lbfftin2 property
        /// </summary>
        [XmlEnum("lbf.ft/in2")]
        lbfftin2,
        /// <summary>
        /// lbfftlbm property
        /// </summary>
        [XmlEnum("lbf.ft/lbm")]
        lbfftlbm,
        /// <summary>
        /// lbfftmin property
        /// </summary>
        [XmlEnum("lbf.ft/min")]
        lbfftmin,
        /// <summary>
        /// lbffts property
        /// </summary>
        [XmlEnum("lbf.ft/s")]
        lbffts,
        /// <summary>
        /// lbfin property
        /// </summary>
        [XmlEnum("lbf.in")]
        lbfin,
        /// <summary>
        /// lbfinin property
        /// </summary>
        [XmlEnum("lbf.in/in")]
        lbfinin,
        /// <summary>
        /// lbfin2 property
        /// </summary>
        [XmlEnum("lbf.in2")]
        lbfin2,
        /// <summary>
        /// lbfsft2 property
        /// </summary>
        [XmlEnum("lbf.s/ft2")]
        lbfsft2,
        /// <summary>
        /// lbfsin2 property
        /// </summary>
        [XmlEnum("lbf.s/in2")]
        lbfsin2,
        /// <summary>
        /// lbfft1 property
        /// </summary>
        [XmlEnum("lbf/ft")]
        lbfft1,
        /// <summary>
        /// lbfft2 property
        /// </summary>
        [XmlEnum("lbf/ft2")]
        lbfft2,
        /// <summary>
        /// lbfft3 property
        /// </summary>
        [XmlEnum("lbf/ft3")]
        lbfft3,
        /// <summary>
        /// lbfgalUS property
        /// </summary>
        [XmlEnum("lbf/gal[US]")]
        lbfgalUS,
        /// <summary>
        /// lbfin1 property
        /// </summary>
        [XmlEnum("lbf/in")]
        lbfin1,
        /// <summary>
        /// lbflbf property
        /// </summary>
        [XmlEnum("lbf/lbf")]
        lbflbf,
        /// <summary>
        /// lbm property
        /// </summary>
        lbm,
        /// <summary>
        /// lbmft property
        /// </summary>
        [XmlEnum("lbm.ft")]
        lbmft,
        /// <summary>
        /// lbmfts property
        /// </summary>
        [XmlEnum("lbm.ft/s")]
        lbmfts,
        /// <summary>
        /// lbmft2 property
        /// </summary>
        [XmlEnum("lbm.ft2")]
        lbmft2,
        /// <summary>
        /// lbmft2s2 property
        /// </summary>
        [XmlEnum("lbm.ft2/s2")]
        lbmft2s2,
        /// <summary>
        /// lbmfth property
        /// </summary>
        [XmlEnum("lbm/(ft.h)")]
        lbmfth,
        /// <summary>
        /// lbmfts1 property
        /// </summary>
        [XmlEnum("lbm/(ft.s)")]
        lbmfts1,
        /// <summary>
        /// lbmft2h property
        /// </summary>
        [XmlEnum("lbm/(ft2.h)")]
        lbmft2h,
        /// <summary>
        /// lbmft2s property
        /// </summary>
        [XmlEnum("lbm/(ft2.s)")]
        lbmft2s,
        /// <summary>
        /// lbmgalUKft property
        /// </summary>
        [XmlEnum("lbm/(gal[UK].ft)")]
        lbmgalUKft,
        /// <summary>
        /// lbmgalUSft property
        /// </summary>
        [XmlEnum("lbm/(gal[US].ft)")]
        lbmgalUSft,
        /// <summary>
        /// lbmhph property
        /// </summary>
        [XmlEnum("lbm/(hp.h)")]
        lbmhph,
        /// <summary>
        /// lbmbbl property
        /// </summary>
        [XmlEnum("lbm/bbl")]
        lbmbbl,
        /// <summary>
        /// lbmd property
        /// </summary>
        [XmlEnum("lbm/d")]
        lbmd,
        /// <summary>
        /// lbmft1 property
        /// </summary>
        [XmlEnum("lbm/ft")]
        lbmft1,
        /// <summary>
        /// lbmft21 property
        /// </summary>
        [XmlEnum("lbm/ft2")]
        lbmft21,
        /// <summary>
        /// lbmft3 property
        /// </summary>
        [XmlEnum("lbm/ft3")]
        lbmft3,
        /// <summary>
        /// lbmft4 property
        /// </summary>
        [XmlEnum("lbm/ft4")]
        lbmft4,
        /// <summary>
        /// lbmgalUK property
        /// </summary>
        [XmlEnum("lbm/gal[UK]")]
        lbmgalUK,
        /// <summary>
        /// lbmgalUS property
        /// </summary>
        [XmlEnum("lbm/gal[US]")]
        lbmgalUS,
        /// <summary>
        /// lbmh property
        /// </summary>
        [XmlEnum("lbm/h")]
        lbmh,
        /// <summary>
        /// lbmin3 property
        /// </summary>
        [XmlEnum("lbm/in3")]
        lbmin3,
        /// <summary>
        /// lbmlbmol property
        /// </summary>
        [XmlEnum("lbm/lbmol")]
        lbmlbmol,
        /// <summary>
        /// lbmmin property
        /// </summary>
        [XmlEnum("lbm/min")]
        lbmmin,
        /// <summary>
        /// lbms property
        /// </summary>
        [XmlEnum("lbm/s")]
        lbms,
        /// <summary>
        /// lbmol property
        /// </summary>
        lbmol,
        /// <summary>
        /// lbmolhft2 property
        /// </summary>
        [XmlEnum("lbmol/(h.ft2)")]
        lbmolhft2,
        /// <summary>
        /// lbmolsft2 property
        /// </summary>
        [XmlEnum("lbmol/(s.ft2)")]
        lbmolsft2,
        /// <summary>
        /// lbmolft3 property
        /// </summary>
        [XmlEnum("lbmol/ft3")]
        lbmolft3,
        /// <summary>
        /// lbmolgalUK property
        /// </summary>
        [XmlEnum("lbmol/gal[UK]")]
        lbmolgalUK,
        /// <summary>
        /// lbmolgalUS property
        /// </summary>
        [XmlEnum("lbmol/gal[US]")]
        lbmolgalUS,
        /// <summary>
        /// lbmolh property
        /// </summary>
        [XmlEnum("lbmol/h")]
        lbmolh,
        /// <summary>
        /// lbmols property
        /// </summary>
        [XmlEnum("lbmol/s")]
        lbmols,
        /// <summary>
        /// link property
        /// </summary>
        link,
        /// <summary>
        /// linkBnA property
        /// </summary>
        [XmlEnum("link[BnA]")]
        linkBnA,
        /// <summary>
        /// linkBnB property
        /// </summary>
        [XmlEnum("link[BnB]")]
        linkBnB,
        /// <summary>
        /// linkCla property
        /// </summary>
        [XmlEnum("link[Cla]")]
        linkCla,
        /// <summary>
        /// linkSe property
        /// </summary>
        [XmlEnum("link[Se]")]
        linkSe,
        /// <summary>
        /// linkSeT property
        /// </summary>
        [XmlEnum("link[SeT]")]
        linkSeT,
        /// <summary>
        /// linkUS property
        /// </summary>
        [XmlEnum("link[US]")]
        linkUS,
        /// <summary>
        /// lm property
        /// </summary>
        lm,
        /// <summary>
        /// lms property
        /// </summary>
        [XmlEnum("lm.s")]
        lms,
        /// <summary>
        /// lmm2 property
        /// </summary>
        [XmlEnum("lm/m2")]
        lmm2,
        /// <summary>
        /// lmW property
        /// </summary>
        [XmlEnum("lm/W")]
        lmW,
        /// <summary>
        /// lx property
        /// </summary>
        lx,
        /// <summary>
        /// lxs property
        /// </summary>
        [XmlEnum("lx.s")]
        lxs,
        /// <summary>
        /// m property
        /// </summary>
        m,
        /// <summary>
        /// mmK property
        /// </summary>
        [XmlEnum("m/(m.K)")]
        mmK,
        /// <summary>
        /// mcm property
        /// </summary>
        [XmlEnum("m/cm")]
        mcm,
        /// <summary>
        /// md property
        /// </summary>
        [XmlEnum("m/d")]
        md,
        /// <summary>
        /// mh property
        /// </summary>
        [XmlEnum("m/h")]
        mh,
        /// <summary>
        /// mK property
        /// </summary>
        [XmlEnum("m/K")]
        mK,
        /// <summary>
        /// mkg property
        /// </summary>
        [XmlEnum("m/kg")]
        mkg,
        /// <summary>
        /// mkm property
        /// </summary>
        [XmlEnum("m/km")]
        mkm,
        /// <summary>
        /// mkPa property
        /// </summary>
        [XmlEnum("m/kPa")]
        mkPa,
        /// <summary>
        /// mm property
        /// </summary>
        [XmlEnum("m/m")]
        mm,
        /// <summary>
        /// mm3 property
        /// </summary>
        [XmlEnum("m/m3")]
        mm3,
        /// <summary>
        /// mmin property
        /// </summary>
        [XmlEnum("m/min")]
        mmin,
        /// <summary>
        /// mms property
        /// </summary>
        [XmlEnum("m/ms")]
        mms,
        /// <summary>
        /// mPa property
        /// </summary>
        [XmlEnum("m/Pa")]
        mPa,
        /// <summary>
        /// ms property
        /// </summary>
        [XmlEnum("m/s")]
        ms,
        /// <summary>
        /// ms2 property
        /// </summary>
        [XmlEnum("m/s2")]
        ms2,
        /// <summary>
        /// mGer property
        /// </summary>
        [XmlEnum("m[Ger]")]
        mGer,
        /// <summary>
        /// m2 property
        /// </summary>
        m2,
        /// <summary>
        /// m2kPad property
        /// </summary>
        [XmlEnum("m2/(kPa.d)")]
        m2kPad,
        /// <summary>
        /// m2Pas property
        /// </summary>
        [XmlEnum("m2/(Pa.s)")]
        m2Pas,
        /// <summary>
        /// m2cm3 property
        /// </summary>
        [XmlEnum("m2/cm3")]
        m2cm3,
        /// <summary>
        /// m2d property
        /// </summary>
        [XmlEnum("m2/d")]
        m2d,
        /// <summary>
        /// m2g property
        /// </summary>
        [XmlEnum("m2/g")]
        m2g,
        /// <summary>
        /// m2h property
        /// </summary>
        [XmlEnum("m2/h")]
        m2h,
        /// <summary>
        /// m2kg property
        /// </summary>
        [XmlEnum("m2/kg")]
        m2kg,
        /// <summary>
        /// m2m2 property
        /// </summary>
        [XmlEnum("m2/m2")]
        m2m2,
        /// <summary>
        /// m2m3 property
        /// </summary>
        [XmlEnum("m2/m3")]
        m2m3,
        /// <summary>
        /// m2mol property
        /// </summary>
        [XmlEnum("m2/mol")]
        m2mol,
        /// <summary>
        /// m2s property
        /// </summary>
        [XmlEnum("m2/s")]
        m2s,
        /// <summary>
        /// m3 property
        /// </summary>
        m3,
        /// <summary>
        /// m3bard property
        /// </summary>
        [XmlEnum("m3/(bar.d)")]
        m3bard,
        /// <summary>
        /// m3barh property
        /// </summary>
        [XmlEnum("m3/(bar.h)")]
        m3barh,
        /// <summary>
        /// m3barmin property
        /// </summary>
        [XmlEnum("m3/(bar.min)")]
        m3barmin,
        /// <summary>
        /// m3dm property
        /// </summary>
        [XmlEnum("m3/(d.m)")]
        m3dm,
        /// <summary>
        /// m3hm property
        /// </summary>
        [XmlEnum("m3/(h.m)")]
        m3hm,
        /// <summary>
        /// m3ham property
        /// </summary>
        [XmlEnum("m3/(ha.m)")]
        m3ham,
        /// <summary>
        /// m3kPad property
        /// </summary>
        [XmlEnum("m3/(kPa.d)")]
        m3kPad,
        /// <summary>
        /// m3kPah property
        /// </summary>
        [XmlEnum("m3/(kPa.h)")]
        m3kPah,
        /// <summary>
        /// m3kWh property
        /// </summary>
        [XmlEnum("m3/(kW.h)")]
        m3kWh,
        /// <summary>
        /// m3m3K property
        /// </summary>
        [XmlEnum("m3/(m3.K)")]
        m3m3K,
        /// <summary>
        /// m3Pas property
        /// </summary>
        [XmlEnum("m3/(Pa.s)")]
        m3Pas,
        /// <summary>
        /// m3psid property
        /// </summary>
        [XmlEnum("m3/(psi.d)")]
        m3psid,
        /// <summary>
        /// m3sft property
        /// </summary>
        [XmlEnum("m3/(s.ft)")]
        m3sft,
        /// <summary>
        /// m3sm property
        /// </summary>
        [XmlEnum("m3/(s.m)")]
        m3sm,
        /// <summary>
        /// m3sm2 property
        /// </summary>
        [XmlEnum("m3/(s.m2)")]
        m3sm2,
        /// <summary>
        /// m3sm3 property
        /// </summary>
        [XmlEnum("m3/(s.m3)")]
        m3sm3,
        /// <summary>
        /// m3bbl property
        /// </summary>
        [XmlEnum("m3/bbl")]
        m3bbl,
        /// <summary>
        /// m3d property
        /// </summary>
        [XmlEnum("m3/d")]
        m3d,
        /// <summary>
        /// m3d2 property
        /// </summary>
        [XmlEnum("m3/d2")]
        m3d2,
        /// <summary>
        /// m3g property
        /// </summary>
        [XmlEnum("m3/g")]
        m3g,
        /// <summary>
        /// m3h property
        /// </summary>
        [XmlEnum("m3/h")]
        m3h,
        /// <summary>
        /// m3J property
        /// </summary>
        [XmlEnum("m3/J")]
        m3J,
        /// <summary>
        /// m3kg property
        /// </summary>
        [XmlEnum("m3/kg")]
        m3kg,
        /// <summary>
        /// m3km property
        /// </summary>
        [XmlEnum("m3/km")]
        m3km,
        /// <summary>
        /// m3kmol property
        /// </summary>
        [XmlEnum("m3/kmol")]
        m3kmol,
        /// <summary>
        /// m3kPa property
        /// </summary>
        [XmlEnum("m3/kPa")]
        m3kPa,
        /// <summary>
        /// m3m property
        /// </summary>
        [XmlEnum("m3/m")]
        m3m,
        /// <summary>
        /// m3m2 property
        /// </summary>
        [XmlEnum("m3/m2")]
        m3m2,
        /// <summary>
        /// m3m3 property
        /// </summary>
        [XmlEnum("m3/m3")]
        m3m3,
        /// <summary>
        /// m3min property
        /// </summary>
        [XmlEnum("m3/min")]
        m3min,
        /// <summary>
        /// m3mol property
        /// </summary>
        [XmlEnum("m3/mol")]
        m3mol,
        /// <summary>
        /// m3Pa property
        /// </summary>
        [XmlEnum("m3/Pa")]
        m3Pa,
        /// <summary>
        /// m3rad property
        /// </summary>
        [XmlEnum("m3/rad")]
        m3rad,
        /// <summary>
        /// m3rev property
        /// </summary>
        [XmlEnum("m3/rev")]
        m3rev,
        /// <summary>
        /// m3s property
        /// </summary>
        [XmlEnum("m3/s")]
        m3s,
        /// <summary>
        /// m3s2 property
        /// </summary>
        [XmlEnum("m3/s2")]
        m3s2,
        /// <summary>
        /// m3t property
        /// </summary>
        [XmlEnum("m3/t")]
        m3t,
        /// <summary>
        /// m3tonUK property
        /// </summary>
        [XmlEnum("m3/ton[UK]")]
        m3tonUK,
        /// <summary>
        /// m3tonUS property
        /// </summary>
        [XmlEnum("m3/ton[US]")]
        m3tonUS,
        /// <summary>
        /// m4 property
        /// </summary>
        m4,
        /// <summary>
        /// m4s property
        /// </summary>
        [XmlEnum("m4/s")]
        m4s,
        /// <summary>
        /// mA property
        /// </summary>
        mA,
        /// <summary>
        /// MA property
        /// </summary>
        MA,
        /// <summary>
        /// mAcm2 property
        /// </summary>
        [XmlEnum("mA/cm2")]
        mAcm2,
        /// <summary>
        /// mAft2 property
        /// </summary>
        [XmlEnum("mA/ft2")]
        mAft2,
        /// <summary>
        /// Mat property
        /// </summary>
        [XmlEnum("Ma[t]")]
        Mat,
        /// <summary>
        /// mbar property
        /// </summary>
        mbar,
        /// <summary>
        /// MBq property
        /// </summary>
        MBq,
        /// <summary>
        /// mC property
        /// </summary>
        mC,
        /// <summary>
        /// MC property
        /// </summary>
        MC,
        /// <summary>
        /// mCm2 property
        /// </summary>
        [XmlEnum("mC/m2")]
        mCm2,
        /// <summary>
        /// mcalth property
        /// </summary>
        [XmlEnum("mcal[th]")]
        mcalth,
        /// <summary>
        /// Mcalth property
        /// </summary>
        [XmlEnum("Mcal[th]")]
        Mcalth,
        /// <summary>
        /// mCi property
        /// </summary>
        mCi,
        /// <summary>
        /// mD property
        /// </summary>
        mD,
        /// <summary>
        /// mDft property
        /// </summary>
        [XmlEnum("mD.ft")]
        mDft,
        /// <summary>
        /// mDft2lbfs property
        /// </summary>
        [XmlEnum("mD.ft2/(lbf.s)")]
        mDft2lbfs,
        /// <summary>
        /// mDin2lbfs property
        /// </summary>
        [XmlEnum("mD.in2/(lbf.s)")]
        mDin2lbfs,
        /// <summary>
        /// mDm property
        /// </summary>
        [XmlEnum("mD.m")]
        mDm,
        /// <summary>
        /// mDPas property
        /// </summary>
        [XmlEnum("mD/(Pa.s)")]
        mDPas,
        /// <summary>
        /// mDcP property
        /// </summary>
        [XmlEnum("mD/cP")]
        mDcP,
        /// <summary>
        /// MEuc property
        /// </summary>
        MEuc,
        /// <summary>
        /// mEuc property
        /// </summary>
        mEuc,
        /// <summary>
        /// meV property
        /// </summary>
        meV,
        /// <summary>
        /// MeV property
        /// </summary>
        MeV,
        /// <summary>
        /// MF property
        /// </summary>
        MF,
        /// <summary>
        /// mF property
        /// </summary>
        mF,
        /// <summary>
        /// mg property
        /// </summary>
        mg,
        /// <summary>
        /// Mg property
        /// </summary>
        Mg,
        /// <summary>
        /// Mga property
        /// </summary>
        [XmlEnum("Mg/a")]
        Mga,
        /// <summary>
        /// Mgd property
        /// </summary>
        [XmlEnum("Mg/d")]
        Mgd,
        /// <summary>
        /// mgdm3 property
        /// </summary>
        [XmlEnum("mg/dm3")]
        mgdm3,
        /// <summary>
        /// mgg property
        /// </summary>
        [XmlEnum("mg/g")]
        mgg,
        /// <summary>
        /// mggalUS property
        /// </summary>
        [XmlEnum("mg/gal[US]")]
        mggalUS,
        /// <summary>
        /// Mgh property
        /// </summary>
        [XmlEnum("Mg/h")]
        Mgh,
        /// <summary>
        /// Mgin property
        /// </summary>
        [XmlEnum("Mg/in")]
        Mgin,
        /// <summary>
        /// mgJ property
        /// </summary>
        [XmlEnum("mg/J")]
        mgJ,
        /// <summary>
        /// mgkg property
        /// </summary>
        [XmlEnum("mg/kg")]
        mgkg,
        /// <summary>
        /// mgL property
        /// </summary>
        [XmlEnum("mg/L")]
        mgL,
        /// <summary>
        /// Mgm2 property
        /// </summary>
        [XmlEnum("Mg/m2")]
        Mgm2,
        /// <summary>
        /// mgm3 property
        /// </summary>
        [XmlEnum("mg/m3")]
        mgm3,
        /// <summary>
        /// Mgm3 property
        /// </summary>
        [XmlEnum("Mg/m3")]
        Mgm3,
        /// <summary>
        /// Mgmin property
        /// </summary>
        [XmlEnum("Mg/min")]
        Mgmin,
        /// <summary>
        /// mGal property
        /// </summary>
        mGal,
        /// <summary>
        /// mgauss property
        /// </summary>
        mgauss,
        /// <summary>
        /// Mgauss property
        /// </summary>
        Mgauss,
        /// <summary>
        /// Mgf property
        /// </summary>
        Mgf,
        /// <summary>
        /// mgn property
        /// </summary>
        mgn,
        /// <summary>
        /// MGy property
        /// </summary>
        MGy,
        /// <summary>
        /// mGy property
        /// </summary>
        mGy,
        /// <summary>
        /// mH property
        /// </summary>
        mH,
        /// <summary>
        /// MH property
        /// </summary>
        MH,
        /// <summary>
        /// mHz property
        /// </summary>
        mHz,
        /// <summary>
        /// MHz property
        /// </summary>
        MHz,
        /// <summary>
        /// mi property
        /// </summary>
        mi,
        /// <summary>
        /// migalUK property
        /// </summary>
        [XmlEnum("mi/gal[UK]")]
        migalUK,
        /// <summary>
        /// migalUS property
        /// </summary>
        [XmlEnum("mi/gal[US]")]
        migalUS,
        /// <summary>
        /// mih property
        /// </summary>
        [XmlEnum("mi/h")]
        mih,
        /// <summary>
        /// miin property
        /// </summary>
        [XmlEnum("mi/in")]
        miin,
        /// <summary>
        /// minaut property
        /// </summary>
        [XmlEnum("mi[naut]")]
        minaut,
        /// <summary>
        /// minautUK property
        /// </summary>
        [XmlEnum("mi[nautUK]")]
        minautUK,
        /// <summary>
        /// miUS property
        /// </summary>
        [XmlEnum("mi[US]")]
        miUS,
        /// <summary>
        /// miUS2 property
        /// </summary>
        [XmlEnum("mi[US]2")]
        miUS2,
        /// <summary>
        /// mi2 property
        /// </summary>
        mi2,
        /// <summary>
        /// mi3 property
        /// </summary>
        mi3,
        /// <summary>
        /// Mibyte property
        /// </summary>
        Mibyte,
        /// <summary>
        /// mil property
        /// </summary>
        mil,
        /// <summary>
        /// mila property
        /// </summary>
        [XmlEnum("mil/a")]
        mila,
        /// <summary>
        /// mila1 property
        /// </summary>
        [XmlEnum("mila")]
        mila1,
        /// <summary>
        /// min property
        /// </summary>
        min,
        /// <summary>
        /// minft property
        /// </summary>
        [XmlEnum("min/ft")]
        minft,
        /// <summary>
        /// minm property
        /// </summary>
        [XmlEnum("min/m")]
        minm,
        /// <summary>
        /// mina property
        /// </summary>
        mina,
        /// <summary>
        /// mJ property
        /// </summary>
        mJ,
        /// <summary>
        /// MJ property
        /// </summary>
        MJ,
        /// <summary>
        /// MJa property
        /// </summary>
        [XmlEnum("MJ/a")]
        MJa,
        /// <summary>
        /// mJcm2 property
        /// </summary>
        [XmlEnum("mJ/cm2")]
        mJcm2,
        /// <summary>
        /// MJkg property
        /// </summary>
        [XmlEnum("MJ/kg")]
        MJkg,
        /// <summary>
        /// MJkmol property
        /// </summary>
        [XmlEnum("MJ/kmol")]
        MJkmol,
        /// <summary>
        /// MJm property
        /// </summary>
        [XmlEnum("MJ/m")]
        MJm,
        /// <summary>
        /// mJm2 property
        /// </summary>
        [XmlEnum("mJ/m2")]
        mJm2,
        /// <summary>
        /// MJm3 property
        /// </summary>
        [XmlEnum("MJ/m3")]
        MJm3,
        /// <summary>
        /// mL property
        /// </summary>
        mL,
        /// <summary>
        /// mLgalUK property
        /// </summary>
        [XmlEnum("mL/gal[UK]")]
        mLgalUK,
        /// <summary>
        /// mLgalUS property
        /// </summary>
        [XmlEnum("mL/gal[US]")]
        mLgalUS,
        /// <summary>
        /// mLmL property
        /// </summary>
        [XmlEnum("mL/mL")]
        mLmL,
        /// <summary>
        /// mm1 property
        /// </summary>
        [XmlEnum("mm")]
        mm1,
        /// <summary>
        /// Mm property
        /// </summary>
        Mm,
        /// <summary>
        /// mmmmK property
        /// </summary>
        [XmlEnum("mm/(mm.K)")]
        mmmmK,
        /// <summary>
        /// mma property
        /// </summary>
        [XmlEnum("mm/a")]
        mma,
        /// <summary>
        /// mms1 property
        /// </summary>
        [XmlEnum("mm/s")]
        mms1,
        /// <summary>
        /// mm2 property
        /// </summary>
        mm2,
        /// <summary>
        /// mm2mm2 property
        /// </summary>
        [XmlEnum("mm2/mm2")]
        mm2mm2,
        /// <summary>
        /// mm2s property
        /// </summary>
        [XmlEnum("mm2/s")]
        mm2s,
        /// <summary>
        /// mm31 property
        /// </summary>
        [XmlEnum("mm3")]
        mm31,
        /// <summary>
        /// mm3J property
        /// </summary>
        [XmlEnum("mm3/J")]
        mm3J,
        /// <summary>
        /// mmHg0degC property
        /// </summary>
        [XmlEnum("mmHg[0degC]")]
        mmHg0degC,
        /// <summary>
        /// mmol property
        /// </summary>
        mmol,
        /// <summary>
        /// MN property
        /// </summary>
        MN,
        /// <summary>
        /// mN property
        /// </summary>
        mN,
        /// <summary>
        /// mNm2 property
        /// </summary>
        [XmlEnum("mN.m2")]
        mNm2,
        /// <summary>
        /// mNkm property
        /// </summary>
        [XmlEnum("mN/km")]
        mNkm,
        /// <summary>
        /// mNm property
        /// </summary>
        [XmlEnum("mN/m")]
        mNm,
        /// <summary>
        /// Mohm property
        /// </summary>
        Mohm,
        /// <summary>
        /// mohm property
        /// </summary>
        mohm,
        /// <summary>
        /// mol property
        /// </summary>
        mol,
        /// <summary>
        /// molm2mols property
        /// </summary>
        [XmlEnum("mol.m2/(mol.s)")]
        molm2mols,
        /// <summary>
        /// molsm2 property
        /// </summary>
        [XmlEnum("mol/(s.m2)")]
        molsm2,
        /// <summary>
        /// molm2 property
        /// </summary>
        [XmlEnum("mol/m2")]
        molm2,
        /// <summary>
        /// molm3 property
        /// </summary>
        [XmlEnum("mol/m3")]
        molm3,
        /// <summary>
        /// molmol property
        /// </summary>
        [XmlEnum("mol/mol")]
        molmol,
        /// <summary>
        /// mols property
        /// </summary>
        [XmlEnum("mol/s")]
        mols,
        /// <summary>
        /// MP property
        /// </summary>
        MP,
        /// <summary>
        /// mP property
        /// </summary>
        mP,
        /// <summary>
        /// mPa1 property
        /// </summary>
        [XmlEnum("mPa")]
        mPa1,
        /// <summary>
        /// MPa property
        /// </summary>
        MPa,
        /// <summary>
        /// mPas property
        /// </summary>
        [XmlEnum("mPa.s")]
        mPas,
        /// <summary>
        /// MPasm property
        /// </summary>
        [XmlEnum("MPa.s/m")]
        MPasm,
        /// <summary>
        /// MPah property
        /// </summary>
        [XmlEnum("MPa/h")]
        MPah,
        /// <summary>
        /// MPam property
        /// </summary>
        [XmlEnum("MPa/m")]
        MPam,
        /// <summary>
        /// Mpsi property
        /// </summary>
        Mpsi,
        /// <summary>
        /// Mrad property
        /// </summary>
        Mrad,
        /// <summary>
        /// mrad property
        /// </summary>
        mrad,
        /// <summary>
        /// mrd property
        /// </summary>
        mrd,
        /// <summary>
        /// Mrd property
        /// </summary>
        Mrd,
        /// <summary>
        /// mrem property
        /// </summary>
        mrem,
        /// <summary>
        /// mremh property
        /// </summary>
        [XmlEnum("mrem/h")]
        mremh,
        /// <summary>
        /// ms1 property
        /// </summary>
        [XmlEnum("ms")]
        ms1,
        /// <summary>
        /// MS property
        /// </summary>
        MS,
        /// <summary>
        /// mS property
        /// </summary>
        mS,
        /// <summary>
        /// mScm property
        /// </summary>
        [XmlEnum("mS/cm")]
        mScm,
        /// <summary>
        /// mscm property
        /// </summary>
        [XmlEnum("ms/cm")]
        mscm,
        /// <summary>
        /// msft property
        /// </summary>
        [XmlEnum("ms/ft")]
        msft,
        /// <summary>
        /// msin property
        /// </summary>
        [XmlEnum("ms/in")]
        msin,
        /// <summary>
        /// mSm property
        /// </summary>
        [XmlEnum("mS/m")]
        mSm,
        /// <summary>
        /// msm property
        /// </summary>
        [XmlEnum("ms/m")]
        msm,
        /// <summary>
        /// mss property
        /// </summary>
        [XmlEnum("ms/s")]
        mss,
        /// <summary>
        /// mSv property
        /// </summary>
        mSv,
        /// <summary>
        /// mSvh property
        /// </summary>
        [XmlEnum("mSv/h")]
        mSvh,
        /// <summary>
        /// mT property
        /// </summary>
        mT,
        /// <summary>
        /// mTdm property
        /// </summary>
        [XmlEnum("mT/dm")]
        mTdm,
        /// <summary>
        /// MV property
        /// </summary>
        MV,
        /// <summary>
        /// mV property
        /// </summary>
        mV,
        /// <summary>
        /// mVft property
        /// </summary>
        [XmlEnum("mV/ft")]
        mVft,
        /// <summary>
        /// mVm property
        /// </summary>
        [XmlEnum("mV/m")]
        mVm,
        /// <summary>
        /// mW property
        /// </summary>
        mW,
        /// <summary>
        /// MW property
        /// </summary>
        MW,
        /// <summary>
        /// MWh property
        /// </summary>
        [XmlEnum("MW.h")]
        MWh,
        /// <summary>
        /// MWhkg property
        /// </summary>
        [XmlEnum("MW.h/kg")]
        MWhkg,
        /// <summary>
        /// MWhm3 property
        /// </summary>
        [XmlEnum("MW.h/m3")]
        MWhm3,
        /// <summary>
        /// mWm2 property
        /// </summary>
        [XmlEnum("mW/m2")]
        mWm2,
        /// <summary>
        /// MWb property
        /// </summary>
        MWb,
        /// <summary>
        /// mWb property
        /// </summary>
        mWb,
        /// <summary>
        /// N property
        /// </summary>
        N,
        /// <summary>
        /// Nm property
        /// </summary>
        [XmlEnum("N.m")]
        Nm,
        /// <summary>
        /// Nmm property
        /// </summary>
        [XmlEnum("N.m/m")]
        Nmm,
        /// <summary>
        /// Nm2 property
        /// </summary>
        [XmlEnum("N.m2")]
        Nm2,
        /// <summary>
        /// Nsm2 property
        /// </summary>
        [XmlEnum("N.s/m2")]
        Nsm2,
        /// <summary>
        /// Nm1 property
        /// </summary>
        [XmlEnum("N/m")]
        Nm1,
        /// <summary>
        /// Nm21 property
        /// </summary>
        [XmlEnum("N/m2")]
        Nm21,
        /// <summary>
        /// Nm3 property
        /// </summary>
        [XmlEnum("N/m3")]
        Nm3,
        /// <summary>
        /// Nmm2 property
        /// </summary>
        [XmlEnum("N/mm2")]
        Nmm2,
        /// <summary>
        /// NN property
        /// </summary>
        [XmlEnum("N/N")]
        NN,
        /// <summary>
        /// na property
        /// </summary>
        na,
        /// <summary>
        /// nA property
        /// </summary>
        nA,
        /// <summary>
        /// nAPI property
        /// </summary>
        nAPI,
        /// <summary>
        /// nC property
        /// </summary>
        nC,
        /// <summary>
        /// ncalth property
        /// </summary>
        [XmlEnum("ncal[th]")]
        ncalth,
        /// <summary>
        /// nCi property
        /// </summary>
        nCi,
        /// <summary>
        /// nEuc property
        /// </summary>
        nEuc,
        /// <summary>
        /// neV property
        /// </summary>
        neV,
        /// <summary>
        /// nF property
        /// </summary>
        nF,
        /// <summary>
        /// ng property
        /// </summary>
        ng,
        /// <summary>
        /// ngg property
        /// </summary>
        [XmlEnum("ng/g")]
        ngg,
        /// <summary>
        /// ngmg property
        /// </summary>
        [XmlEnum("ng/mg")]
        ngmg,
        /// <summary>
        /// ngauss property
        /// </summary>
        ngauss,
        /// <summary>
        /// nGy property
        /// </summary>
        nGy,
        /// <summary>
        /// nH property
        /// </summary>
        nH,
        /// <summary>
        /// nHz property
        /// </summary>
        nHz,
        /// <summary>
        /// nJ property
        /// </summary>
        nJ,
        /// <summary>
        /// nm property
        /// </summary>
        nm,
        /// <summary>
        /// nms property
        /// </summary>
        [XmlEnum("nm/s")]
        nms,
        /// <summary>
        /// nN property
        /// </summary>
        nN,
        /// <summary>
        /// nohm property
        /// </summary>
        nohm,
        /// <summary>
        /// nohmmil2ft property
        /// </summary>
        [XmlEnum("nohm.mil2/ft")]
        nohmmil2ft,
        /// <summary>
        /// nohmmm2m property
        /// </summary>
        [XmlEnum("nohm.mm2/m")]
        nohmmm2m,
        /// <summary>
        /// nP property
        /// </summary>
        nP,
        /// <summary>
        /// nPa property
        /// </summary>
        nPa,
        /// <summary>
        /// nrd property
        /// </summary>
        nrd,
        /// <summary>
        /// ns property
        /// </summary>
        ns,
        /// <summary>
        /// nS property
        /// </summary>
        nS,
        /// <summary>
        /// nsft property
        /// </summary>
        [XmlEnum("ns/ft")]
        nsft,
        /// <summary>
        /// nsm property
        /// </summary>
        [XmlEnum("ns/m")]
        nsm,
        /// <summary>
        /// nT property
        /// </summary>
        nT,
        /// <summary>
        /// nV property
        /// </summary>
        nV,
        /// <summary>
        /// nW property
        /// </summary>
        nW,
        /// <summary>
        /// nWb property
        /// </summary>
        nWb,
        /// <summary>
        /// O property
        /// </summary>
        O,
        /// <summary>
        /// Oe property
        /// </summary>
        Oe,
        /// <summary>
        /// ohm property
        /// </summary>
        ohm,
        /// <summary>
        /// ohmcm property
        /// </summary>
        [XmlEnum("ohm.cm")]
        ohmcm,
        /// <summary>
        /// ohmm property
        /// </summary>
        [XmlEnum("ohm.m")]
        ohmm,
        /// <summary>
        /// ohmm2m property
        /// </summary>
        [XmlEnum("ohm.m2/m")]
        ohmm2m,
        /// <summary>
        /// ohmm1 property
        /// </summary>
        [XmlEnum("ohm/m")]
        ohmm1,
        /// <summary>
        /// ozf property
        /// </summary>
        ozf,
        /// <summary>
        /// ozm property
        /// </summary>
        ozm,
        /// <summary>
        /// ozmtroy property
        /// </summary>
        [XmlEnum("ozm[troy]")]
        ozmtroy,
        /// <summary>
        /// P property
        /// </summary>
        P,
        /// <summary>
        /// Pa property
        /// </summary>
        Pa,
        /// <summary>
        /// pA property
        /// </summary>
        pA,
        /// <summary>
        /// Pas property
        /// </summary>
        [XmlEnum("Pa.s")]
        Pas,
        /// <summary>
        /// Pasm3kg property
        /// </summary>
        [XmlEnum("Pa.s.m3/kg")]
        Pasm3kg,
        /// <summary>
        /// Pasm3 property
        /// </summary>
        [XmlEnum("Pa.s/m3")]
        Pasm3,
        /// <summary>
        /// Pas2m3 property
        /// </summary>
        [XmlEnum("Pa.s2/m3")]
        Pas2m3,
        /// <summary>
        /// Pah property
        /// </summary>
        [XmlEnum("Pa/h")]
        Pah,
        /// <summary>
        /// Pam property
        /// </summary>
        [XmlEnum("Pa/m")]
        Pam,
        /// <summary>
        /// Pam3 property
        /// </summary>
        [XmlEnum("Pa/m3")]
        Pam3,
        /// <summary>
        /// Pas1 property
        /// </summary>
        [XmlEnum("Pa/s")]
        Pas1,
        /// <summary>
        /// Pa2 property
        /// </summary>
        Pa2,
        /// <summary>
        /// Pa2Pas property
        /// </summary>
        [XmlEnum("Pa2/(Pa.s)")]
        Pa2Pas,
        /// <summary>
        /// pC property
        /// </summary>
        pC,
        /// <summary>
        /// pcalth property
        /// </summary>
        [XmlEnum("pcal[th]")]
        pcalth,
        /// <summary>
        /// pCi property
        /// </summary>
        pCi,
        /// <summary>
        /// pCig property
        /// </summary>
        [XmlEnum("pCi/g")]
        pCig,
        /// <summary>
        /// pdl property
        /// </summary>
        pdl,
        /// <summary>
        /// pdlcm2 property
        /// </summary>
        [XmlEnum("pdl.cm2")]
        pdlcm2,
        /// <summary>
        /// pdlft property
        /// </summary>
        [XmlEnum("pdl.ft")]
        pdlft,
        /// <summary>
        /// pdlcm property
        /// </summary>
        [XmlEnum("pdl/cm")]
        pdlcm,
        /// <summary>
        /// pEuc property
        /// </summary>
        pEuc,
        /// <summary>
        /// peV property
        /// </summary>
        peV,
        /// <summary>
        /// pF property
        /// </summary>
        pF,
        /// <summary>
        /// pg property
        /// </summary>
        pg,
        /// <summary>
        /// pgauss property
        /// </summary>
        pgauss,
        /// <summary>
        /// pGy property
        /// </summary>
        pGy,
        /// <summary>
        /// pHz property
        /// </summary>
        pHz,
        /// <summary>
        /// pJ property
        /// </summary>
        pJ,
        /// <summary>
        /// pm property
        /// </summary>
        pm,
        /// <summary>
        /// pN property
        /// </summary>
        pN,
        /// <summary>
        /// pohm property
        /// </summary>
        pohm,
        /// <summary>
        /// pP property
        /// </summary>
        pP,
        /// <summary>
        /// pPa property
        /// </summary>
        pPa,
        /// <summary>
        /// ppk property
        /// </summary>
        ppk,
        /// <summary>
        /// ppm property
        /// </summary>
        ppm,
        /// <summary>
        /// ppmmass property
        /// </summary>
        [XmlEnum("ppm[mass]")]
        ppmmass,
        /// <summary>
        /// ppmvol property
        /// </summary>
        [XmlEnum("ppm[vol]")]
        ppmvol,
        /// <summary>
        /// ppmvoldegC property
        /// </summary>
        [XmlEnum("ppm[vol]/degC")]
        ppmvoldegC,
        /// <summary>
        /// ppmvoldegF property
        /// </summary>
        [XmlEnum("ppm[vol]/degF")]
        ppmvoldegF,
        /// <summary>
        /// prd property
        /// </summary>
        prd,
        /// <summary>
        /// pS property
        /// </summary>
        pS,
        /// <summary>
        /// ps property
        /// </summary>
        ps,
        /// <summary>
        /// psi property
        /// </summary>
        psi,
        /// <summary>
        /// psidbbl property
        /// </summary>
        [XmlEnum("psi.d/bbl")]
        psidbbl,
        /// <summary>
        /// psis property
        /// </summary>
        [XmlEnum("psi.s")]
        psis,
        /// <summary>
        /// psift property
        /// </summary>
        [XmlEnum("psi/ft")]
        psift,
        /// <summary>
        /// psih property
        /// </summary>
        [XmlEnum("psi/h")]
        psih,
        /// <summary>
        /// psim property
        /// </summary>
        [XmlEnum("psi/m")]
        psim,
        /// <summary>
        /// psimin property
        /// </summary>
        [XmlEnum("psi/min")]
        psimin,
        /// <summary>
        /// psi2 property
        /// </summary>
        psi2,
        /// <summary>
        /// psi2dcPft3 property
        /// </summary>
        [XmlEnum("psi2.d/(cP.ft3)")]
        psi2dcPft3,
        /// <summary>
        /// psi2cP property
        /// </summary>
        [XmlEnum("psi2/cP")]
        psi2cP,
        /// <summary>
        /// pT property
        /// </summary>
        pT,
        /// <summary>
        /// ptUK property
        /// </summary>
        [XmlEnum("pt[UK]")]
        ptUK,
        /// <summary>
        /// ptUKhph property
        /// </summary>
        [XmlEnum("pt[UK]/(hp.h)")]
        ptUKhph,
        /// <summary>
        /// ptUS property
        /// </summary>
        [XmlEnum("pt[US]")]
        ptUS,
        /// <summary>
        /// pV property
        /// </summary>
        pV,
        /// <summary>
        /// pW property
        /// </summary>
        pW,
        /// <summary>
        /// pWb property
        /// </summary>
        pWb,
        /// <summary>
        /// qtUK property
        /// </summary>
        [XmlEnum("qt[UK]")]
        qtUK,
        /// <summary>
        /// qtUS property
        /// </summary>
        [XmlEnum("qt[US]")]
        qtUS,
        /// <summary>
        /// quad property
        /// </summary>
        quad,
        /// <summary>
        /// quada property
        /// </summary>
        [XmlEnum("quad/a")]
        quada,
        /// <summary>
        /// rad property
        /// </summary>
        rad,
        /// <summary>
        /// radft property
        /// </summary>
        [XmlEnum("rad/ft")]
        radft,
        /// <summary>
        /// radft3 property
        /// </summary>
        [XmlEnum("rad/ft3")]
        radft3,
        /// <summary>
        /// radm property
        /// </summary>
        [XmlEnum("rad/m")]
        radm,
        /// <summary>
        /// radm3 property
        /// </summary>
        [XmlEnum("rad/m3")]
        radm3,
        /// <summary>
        /// rads property
        /// </summary>
        [XmlEnum("rad/s")]
        rads,
        /// <summary>
        /// rads2 property
        /// </summary>
        [XmlEnum("rad/s2")]
        rads2,
        /// <summary>
        /// rd property
        /// </summary>
        rd,
        /// <summary>
        /// rem property
        /// </summary>
        rem,
        /// <summary>
        /// remh property
        /// </summary>
        [XmlEnum("rem/h")]
        remh,
        /// <summary>
        /// rev property
        /// </summary>
        rev,
        /// <summary>
        /// revft property
        /// </summary>
        [XmlEnum("rev/ft")]
        revft,
        /// <summary>
        /// revm property
        /// </summary>
        [XmlEnum("rev/m")]
        revm,
        /// <summary>
        /// revs property
        /// </summary>
        [XmlEnum("rev/s")]
        revs,
        /// <summary>
        /// rodUS property
        /// </summary>
        [XmlEnum("rod[US]")]
        rodUS,
        /// <summary>
        /// rpm property
        /// </summary>
        rpm,
        /// <summary>
        /// rpms property
        /// </summary>
        [XmlEnum("rpm/s")]
        rpms,
        /// <summary>
        /// S property
        /// </summary>
        S,
        /// <summary>
        /// s property
        /// </summary>
        s,
        /// <summary>
        /// scm property
        /// </summary>
        [XmlEnum("s/cm")]
        scm,
        /// <summary>
        /// sft property
        /// </summary>
        [XmlEnum("s/ft")]
        sft,
        /// <summary>
        /// sft3 property
        /// </summary>
        [XmlEnum("s/ft3")]
        sft3,
        /// <summary>
        /// sin property
        /// </summary>
        [XmlEnum("s/in")]
        sin,
        /// <summary>
        /// skg property
        /// </summary>
        [XmlEnum("s/kg")]
        skg,
        /// <summary>
        /// sL property
        /// </summary>
        [XmlEnum("s/L")]
        sL,
        /// <summary>
        /// sm property
        /// </summary>
        [XmlEnum("s/m")]
        sm,
        /// <summary>
        /// Sm property
        /// </summary>
        [XmlEnum("S/m")]
        Sm,
        /// <summary>
        /// sm3 property
        /// </summary>
        [XmlEnum("s/m3")]
        sm3,
        /// <summary>
        /// sqtUK property
        /// </summary>
        [XmlEnum("s/qt[UK]")]
        sqtUK,
        /// <summary>
        /// sqtUS property
        /// </summary>
        [XmlEnum("s/qt[US]")]
        sqtUS,
        /// <summary>
        /// ss property
        /// </summary>
        [XmlEnum("s/s")]
        ss,
        /// <summary>
        /// sack94lbm property
        /// </summary>
        [XmlEnum("sack[94lbm]")]
        sack94lbm,
        /// <summary>
        /// seca property
        /// </summary>
        seca,
        /// <summary>
        /// section property
        /// </summary>
        section,
        /// <summary>
        /// sr property
        /// </summary>
        sr,
        /// <summary>
        /// St property
        /// </summary>
        St,
        /// <summary>
        /// Sv property
        /// </summary>
        Sv,
        /// <summary>
        /// Svh property
        /// </summary>
        [XmlEnum("Sv/h")]
        Svh,
        /// <summary>
        /// Svs property
        /// </summary>
        [XmlEnum("Sv/s")]
        Svs,
        /// <summary>
        /// t property
        /// </summary>
        t,
        /// <summary>
        /// T property
        /// </summary>
        T,
        /// <summary>
        /// ta property
        /// </summary>
        [XmlEnum("t/a")]
        ta,
        /// <summary>
        /// td property
        /// </summary>
        [XmlEnum("t/d")]
        td,
        /// <summary>
        /// th property
        /// </summary>
        [XmlEnum("t/h")]
        th,
        /// <summary>
        /// Tm property
        /// </summary>
        [XmlEnum("T/m")]
        Tm,
        /// <summary>
        /// tm3 property
        /// </summary>
        [XmlEnum("t/m3")]
        tm3,
        /// <summary>
        /// tmin property
        /// </summary>
        [XmlEnum("t/min")]
        tmin,
        /// <summary>
        /// TA property
        /// </summary>
        TA,
        /// <summary>
        /// Tat property
        /// </summary>
        [XmlEnum("Ta[t]")]
        Tat,
        /// <summary>
        /// TBq property
        /// </summary>
        TBq,
        /// <summary>
        /// TC property
        /// </summary>
        TC,
        /// <summary>
        /// Tcalth property
        /// </summary>
        [XmlEnum("Tcal[th]")]
        Tcalth,
        /// <summary>
        /// TDAPI property
        /// </summary>
        [XmlEnum("TD[API]")]
        TDAPI,
        /// <summary>
        /// TDAPIm property
        /// </summary>
        [XmlEnum("TD[API].m")]
        TDAPIm,
        /// <summary>
        /// TDAPIPas property
        /// </summary>
        [XmlEnum("TD[API]/(Pa.s)")]
        TDAPIPas,
        /// <summary>
        /// TEuc property
        /// </summary>
        TEuc,
        /// <summary>
        /// TeV property
        /// </summary>
        TeV,
        /// <summary>
        /// TF property
        /// </summary>
        TF,
        /// <summary>
        /// Tg property
        /// </summary>
        Tg,
        /// <summary>
        /// Tgauss property
        /// </summary>
        Tgauss,
        /// <summary>
        /// TGy property
        /// </summary>
        TGy,
        /// <summary>
        /// TH property
        /// </summary>
        TH,
        /// <summary>
        /// thermEC property
        /// </summary>
        [XmlEnum("therm[EC]")]
        thermEC,
        /// <summary>
        /// thermUK property
        /// </summary>
        [XmlEnum("therm[UK]")]
        thermUK,
        /// <summary>
        /// thermUS property
        /// </summary>
        [XmlEnum("therm[US]")]
        thermUS,
        /// <summary>
        /// THz property
        /// </summary>
        THz,
        /// <summary>
        /// TJ property
        /// </summary>
        TJ,
        /// <summary>
        /// TJa property
        /// </summary>
        [XmlEnum("TJ/a")]
        TJa,
        /// <summary>
        /// Tm1 property
        /// </summary>
        [XmlEnum("Tm")]
        Tm1,
        /// <summary>
        /// TN property
        /// </summary>
        TN,
        /// <summary>
        /// Tohm property
        /// </summary>
        Tohm,
        /// <summary>
        /// tonUK property
        /// </summary>
        [XmlEnum("ton[UK]")]
        tonUK,
        /// <summary>
        /// tonUKa property
        /// </summary>
        [XmlEnum("ton[UK]/a")]
        tonUKa,
        /// <summary>
        /// tonUKd property
        /// </summary>
        [XmlEnum("ton[UK]/d")]
        tonUKd,
        /// <summary>
        /// tonUKh property
        /// </summary>
        [XmlEnum("ton[UK]/h")]
        tonUKh,
        /// <summary>
        /// tonUKmin property
        /// </summary>
        [XmlEnum("ton[UK]/min")]
        tonUKmin,
        /// <summary>
        /// tonUS property
        /// </summary>
        [XmlEnum("ton[US]")]
        tonUS,
        /// <summary>
        /// tonUSa property
        /// </summary>
        [XmlEnum("ton[US]/a")]
        tonUSa,
        /// <summary>
        /// tonUSd property
        /// </summary>
        [XmlEnum("ton[US]/d")]
        tonUSd,
        /// <summary>
        /// tonUSft2 property
        /// </summary>
        [XmlEnum("ton[US]/ft2")]
        tonUSft2,
        /// <summary>
        /// tonUSh property
        /// </summary>
        [XmlEnum("ton[US]/h")]
        tonUSh,
        /// <summary>
        /// tonUSmin property
        /// </summary>
        [XmlEnum("ton[US]/min")]
        tonUSmin,
        /// <summary>
        /// tonfUK property
        /// </summary>
        [XmlEnum("tonf[UK]")]
        tonfUK,
        /// <summary>
        /// tonfUKft2 property
        /// </summary>
        [XmlEnum("tonf[UK].ft2")]
        tonfUKft2,
        /// <summary>
        /// tonfUKft property
        /// </summary>
        [XmlEnum("tonf[UK]/ft")]
        tonfUKft,
        /// <summary>
        /// tonfUKft21 property
        /// </summary>
        [XmlEnum("tonf[UK]/ft2")]
        tonfUKft21,
        /// <summary>
        /// tonfUS property
        /// </summary>
        [XmlEnum("tonf[US]")]
        tonfUS,
        /// <summary>
        /// tonfUSft property
        /// </summary>
        [XmlEnum("tonf[US].ft")]
        tonfUSft,
        /// <summary>
        /// tonfUSft2 property
        /// </summary>
        [XmlEnum("tonf[US].ft2")]
        tonfUSft2,
        /// <summary>
        /// tonfUSmi property
        /// </summary>
        [XmlEnum("tonf[US].mi")]
        tonfUSmi,
        /// <summary>
        /// tonfUSmibbl property
        /// </summary>
        [XmlEnum("tonf[US].mi/bbl")]
        tonfUSmibbl,
        /// <summary>
        /// tonfUSmift property
        /// </summary>
        [XmlEnum("tonf[US].mi/ft")]
        tonfUSmift,
        /// <summary>
        /// tonfUSft1 property
        /// </summary>
        [XmlEnum("tonf[US]/ft")]
        tonfUSft1,
        /// <summary>
        /// tonfUSft21 property
        /// </summary>
        [XmlEnum("tonf[US]/ft2")]
        tonfUSft21,
        /// <summary>
        /// tonfUSin2 property
        /// </summary>
        [XmlEnum("tonf[US]/in2")]
        tonfUSin2,
        /// <summary>
        /// tonRefrig property
        /// </summary>
        tonRefrig,
        /// <summary>
        /// torr property
        /// </summary>
        torr,
        /// <summary>
        /// TP property
        /// </summary>
        TP,
        /// <summary>
        /// TPa property
        /// </summary>
        TPa,
        /// <summary>
        /// Trd property
        /// </summary>
        Trd,
        /// <summary>
        /// TS property
        /// </summary>
        TS,
        /// <summary>
        /// TT property
        /// </summary>
        TT,
        /// <summary>
        /// TV property
        /// </summary>
        TV,
        /// <summary>
        /// TW property
        /// </summary>
        TW,
        /// <summary>
        /// TWh property
        /// </summary>
        [XmlEnum("TW.h")]
        TWh,
        /// <summary>
        /// TWb property
        /// </summary>
        TWb,
        /// <summary>
        /// uA property
        /// </summary>
        uA,
        /// <summary>
        /// uAcm2 property
        /// </summary>
        [XmlEnum("uA/cm2")]
        uAcm2,
        /// <summary>
        /// uAin2 property
        /// </summary>
        [XmlEnum("uA/in2")]
        uAin2,
        /// <summary>
        /// ubar property
        /// </summary>
        ubar,
        /// <summary>
        /// uC property
        /// </summary>
        uC,
        /// <summary>
        /// ucalth property
        /// </summary>
        [XmlEnum("ucal[th]")]
        ucalth,
        /// <summary>
        /// ucalthscm2 property
        /// </summary>
        [XmlEnum("ucal[th]/(s.cm2)")]
        ucalthscm2,
        /// <summary>
        /// ucalths property
        /// </summary>
        [XmlEnum("ucal[th]/s")]
        ucalths,
        /// <summary>
        /// uCi property
        /// </summary>
        uCi,
        /// <summary>
        /// uEuc property
        /// </summary>
        uEuc,
        /// <summary>
        /// ueV property
        /// </summary>
        ueV,
        /// <summary>
        /// uF property
        /// </summary>
        uF,
        /// <summary>
        /// uFm property
        /// </summary>
        [XmlEnum("uF/m")]
        uFm,
        /// <summary>
        /// ug property
        /// </summary>
        ug,
        /// <summary>
        /// ugcm3 property
        /// </summary>
        [XmlEnum("ug/cm3")]
        ugcm3,
        /// <summary>
        /// ugg property
        /// </summary>
        [XmlEnum("ug/g")]
        ugg,
        /// <summary>
        /// ugmg property
        /// </summary>
        [XmlEnum("ug/mg")]
        ugmg,
        /// <summary>
        /// ugauss property
        /// </summary>
        ugauss,
        /// <summary>
        /// uGy property
        /// </summary>
        uGy,
        /// <summary>
        /// uH property
        /// </summary>
        uH,
        /// <summary>
        /// uHm property
        /// </summary>
        [XmlEnum("uH/m")]
        uHm,
        /// <summary>
        /// uHz property
        /// </summary>
        uHz,
        /// <summary>
        /// uJ property
        /// </summary>
        uJ,
        /// <summary>
        /// um property
        /// </summary>
        um,
        /// <summary>
        /// ums property
        /// </summary>
        [XmlEnum("um/s")]
        ums,
        /// <summary>
        /// um2 property
        /// </summary>
        um2,
        /// <summary>
        /// um2m property
        /// </summary>
        [XmlEnum("um2.m")]
        um2m,
        /// <summary>
        /// umHg0degC property
        /// </summary>
        [XmlEnum("umHg[0degC]")]
        umHg0degC,
        /// <summary>
        /// umol property
        /// </summary>
        umol,
        /// <summary>
        /// uN property
        /// </summary>
        uN,
        /// <summary>
        /// uohm property
        /// </summary>
        uohm,
        /// <summary>
        /// uohmft property
        /// </summary>
        [XmlEnum("uohm/ft")]
        uohmft,
        /// <summary>
        /// uohmm property
        /// </summary>
        [XmlEnum("uohm/m")]
        uohmm,
        /// <summary>
        /// uP property
        /// </summary>
        uP,
        /// <summary>
        /// uPa property
        /// </summary>
        uPa,
        /// <summary>
        /// upsi property
        /// </summary>
        upsi,
        /// <summary>
        /// urad property
        /// </summary>
        urad,
        /// <summary>
        /// urd property
        /// </summary>
        urd,
        /// <summary>
        /// us property
        /// </summary>
        us,
        /// <summary>
        /// uS property
        /// </summary>
        uS,
        /// <summary>
        /// usft property
        /// </summary>
        [XmlEnum("us/ft")]
        usft,
        /// <summary>
        /// usin property
        /// </summary>
        [XmlEnum("us/in")]
        usin,
        /// <summary>
        /// usm property
        /// </summary>
        [XmlEnum("us/m")]
        usm,
        /// <summary>
        /// uT property
        /// </summary>
        uT,
        /// <summary>
        /// uV property
        /// </summary>
        uV,
        /// <summary>
        /// uVft property
        /// </summary>
        [XmlEnum("uV/ft")]
        uVft,
        /// <summary>
        /// uVm property
        /// </summary>
        [XmlEnum("uV/m")]
        uVm,
        /// <summary>
        /// uW property
        /// </summary>
        uW,
        /// <summary>
        /// uWm3 property
        /// </summary>
        [XmlEnum("uW/m3")]
        uWm3,
        /// <summary>
        /// uWb property
        /// </summary>
        uWb,
        /// <summary>
        /// V property
        /// </summary>
        V,
        /// <summary>
        /// VB property
        /// </summary>
        [XmlEnum("V/B")]
        VB,
        /// <summary>
        /// VdB property
        /// </summary>
        [XmlEnum("V/dB")]
        VdB,
        /// <summary>
        /// Vm property
        /// </summary>
        [XmlEnum("V/m")]
        Vm,
        /// <summary>
        /// W property
        /// </summary>
        W,
        /// <summary>
        /// Wm2KJK property
        /// </summary>
        [XmlEnum("W.m2.K/(J.K)")]
        Wm2KJK,
        /// <summary>
        /// WmK property
        /// </summary>
        [XmlEnum("W/(m.K)")]
        WmK,
        /// <summary>
        /// Wm2K property
        /// </summary>
        [XmlEnum("W/(m2.K)")]
        Wm2K,
        /// <summary>
        /// Wm2sr property
        /// </summary>
        [XmlEnum("W/(m2.sr)")]
        Wm2sr,
        /// <summary>
        /// Wm3K property
        /// </summary>
        [XmlEnum("W/(m3.K)")]
        Wm3K,
        /// <summary>
        /// Wcm2 property
        /// </summary>
        [XmlEnum("W/cm2")]
        Wcm2,
        /// <summary>
        /// WK property
        /// </summary>
        [XmlEnum("W/K")]
        WK,
        /// <summary>
        /// WkW property
        /// </summary>
        [XmlEnum("W/kW")]
        WkW,
        /// <summary>
        /// Wm2 property
        /// </summary>
        [XmlEnum("W/m2")]
        Wm2,
        /// <summary>
        /// Wm3 property
        /// </summary>
        [XmlEnum("W/m3")]
        Wm3,
        /// <summary>
        /// Wmm2 property
        /// </summary>
        [XmlEnum("W/mm2")]
        Wmm2,
        /// <summary>
        /// Wsr property
        /// </summary>
        [XmlEnum("W/sr")]
        Wsr,
        /// <summary>
        /// WW property
        /// </summary>
        [XmlEnum("W/W")]
        WW,
        /// <summary>
        /// Wb property
        /// </summary>
        Wb,
        /// <summary>
        /// Wbm property
        /// </summary>
        [XmlEnum("Wb.m")]
        Wbm,
        /// <summary>
        /// Wbm1 property
        /// </summary>
        [XmlEnum("Wb/m")]
        Wbm1,
        /// <summary>
        /// Wbmm property
        /// </summary>
        [XmlEnum("Wb/mm")]
        Wbmm,
        /// <summary>
        /// wk property
        /// </summary>
        wk,
        /// <summary>
        /// yd property
        /// </summary>
        yd,
        /// <summary>
        /// ydBnA property
        /// </summary>
        [XmlEnum("yd[BnA]")]
        ydBnA,
        /// <summary>
        /// ydBnB property
        /// </summary>
        [XmlEnum("yd[BnB]")]
        ydBnB,
        /// <summary>
        /// ydCla property
        /// </summary>
        [XmlEnum("yd[Cla]")]
        ydCla,
        /// <summary>
        /// ydInd property
        /// </summary>
        [XmlEnum("yd[Ind]")]
        ydInd,
        /// <summary>
        /// ydInd37 property
        /// </summary>
        [XmlEnum("yd[Ind37]")]
        ydInd37,
        /// <summary>
        /// ydInd62 property
        /// </summary>
        [XmlEnum("yd[Ind62]")]
        ydInd62,
        /// <summary>
        /// ydInd75 property
        /// </summary>
        [XmlEnum("yd[Ind75]")]
        ydInd75,
        /// <summary>
        /// ydSe property
        /// </summary>
        [XmlEnum("yd[Se]")]
        ydSe,
        /// <summary>
        /// ydSeT property
        /// </summary>
        [XmlEnum("yd[SeT]")]
        ydSeT,
        /// <summary>
        /// ydUS property
        /// </summary>
        [XmlEnum("yd[US]")]
        ydUS,
        /// <summary>
        /// yd2 property
        /// </summary>
        yd2,
        /// <summary>
        /// yd3 property
        /// </summary>
        yd3
    }
    /// <summary>
    /// This class represents the GeochronologicalRank xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the GeochronologicalRank xsd enumeration.")]
    public enum GeochronologicalRank
    {
        /// <summary>
        /// eon property
        /// </summary>
        eon,
        /// <summary>
        /// era property
        /// </summary>
        era,
        /// <summary>
        /// period property
        /// </summary>
        period,
        /// <summary>
        /// epoch property
        /// </summary>
        epoch,
        /// <summary>
        /// age property
        /// </summary>
        age,
        /// <summary>
        /// chron property
        /// </summary>
        chron
    }
    /// <summary>
    /// This class represents the LithologyKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LithologyKind xsd enumeration.")]
    public enum LithologyKind
    {
        /// <summary>
        /// alkalifeldsparrhyolite property
        /// </summary>
        [XmlEnum("alkali feldspar rhyolite")]
        alkalifeldsparrhyolite,
        /// <summary>
        /// alkaliolivinebasalt property
        /// </summary>
        [XmlEnum("alkali olivine basalt")]
        alkaliolivinebasalt,
        /// <summary>
        /// amphibolite property
        /// </summary>
        amphibolite,
        /// <summary>
        /// andesite property
        /// </summary>
        andesite,
        /// <summary>
        /// anhydrite property
        /// </summary>
        anhydrite,
        /// <summary>
        /// anorthositicrock property
        /// </summary>
        [XmlEnum("anorthositic rock")]
        anorthositicrock,
        /// <summary>
        /// anthracite property
        /// </summary>
        anthracite,
        /// <summary>
        /// aplite property
        /// </summary>
        aplite,
        /// <summary>
        /// arenite property
        /// </summary>
        arenite,
        /// <summary>
        /// argillaceous property
        /// </summary>
        argillaceous,
        /// <summary>
        /// arkose property
        /// </summary>
        arkose,
        /// <summary>
        /// basalt property
        /// </summary>
        basalt,
        /// <summary>
        /// basanite property
        /// </summary>
        basanite,
        /// <summary>
        /// bauxite property
        /// </summary>
        bauxite,
        /// <summary>
        /// bituminouscoal property
        /// </summary>
        [XmlEnum("bituminous coal")]
        bituminouscoal,
        /// <summary>
        /// blueschistmetamorphicrock property
        /// </summary>
        [XmlEnum("blueschist metamorphic rock")]
        blueschistmetamorphicrock,
        /// <summary>
        /// boninite property
        /// </summary>
        boninite,
        /// <summary>
        /// breccia property
        /// </summary>
        breccia,
        /// <summary>
        /// carbonateooze property
        /// </summary>
        [XmlEnum("carbonate ooze")]
        carbonateooze,
        /// <summary>
        /// carbonatite property
        /// </summary>
        carbonatite,
        /// <summary>
        /// chalk property
        /// </summary>
        chalk,
        /// <summary>
        /// chert property
        /// </summary>
        chert,
        /// <summary>
        /// clay property
        /// </summary>
        clay,
        /// <summary>
        /// claystone property
        /// </summary>
        claystone,
        /// <summary>
        /// coal property
        /// </summary>
        coal,
        /// <summary>
        /// conglomerate property
        /// </summary>
        conglomerate,
        /// <summary>
        /// dacite property
        /// </summary>
        dacite,
        /// <summary>
        /// diabase property
        /// </summary>
        diabase,
        /// <summary>
        /// diamictite property
        /// </summary>
        diamictite,
        /// <summary>
        /// diorite property
        /// </summary>
        diorite,
        /// <summary>
        /// dioritoid property
        /// </summary>
        dioritoid,
        /// <summary>
        /// doleriticrock property
        /// </summary>
        [XmlEnum("doleritic rock")]
        doleriticrock,
        /// <summary>
        /// dolomite property
        /// </summary>
        dolomite,
        /// <summary>
        /// dolomitic property
        /// </summary>
        dolomitic,
        /// <summary>
        /// eclogite property
        /// </summary>
        eclogite,
        /// <summary>
        /// exoticalkalinerock property
        /// </summary>
        [XmlEnum("exotic alkaline rock")]
        exoticalkalinerock,
        /// <summary>
        /// feldspar property
        /// </summary>
        feldspar,
        /// <summary>
        /// feldspathicarenite property
        /// </summary>
        [XmlEnum("feldspathic arenite")]
        feldspathicarenite,
        /// <summary>
        /// finegrainedigneousrock property
        /// </summary>
        [XmlEnum("fine grained igneous rock")]
        finegrainedigneousrock,
        /// <summary>
        /// foiddioritoid property
        /// </summary>
        [XmlEnum("foid dioritoid")]
        foiddioritoid,
        /// <summary>
        /// foidgabbroid property
        /// </summary>
        [XmlEnum("foid gabbroid")]
        foidgabbroid,
        /// <summary>
        /// foidsyenitoid property
        /// </summary>
        [XmlEnum("foid syenitoid")]
        foidsyenitoid,
        /// <summary>
        /// foidite property
        /// </summary>
        foidite,
        /// <summary>
        /// foiditoid property
        /// </summary>
        foiditoid,
        /// <summary>
        /// foidolite property
        /// </summary>
        foidolite,
        /// <summary>
        /// foliatedmetamorphicrock property
        /// </summary>
        [XmlEnum("foliated metamorphic rock")]
        foliatedmetamorphicrock,
        /// <summary>
        /// fragmentaligneousrock property
        /// </summary>
        [XmlEnum("fragmental igneous rock")]
        fragmentaligneousrock,
        /// <summary>
        /// gabbro property
        /// </summary>
        gabbro,
        /// <summary>
        /// gabbroicrock property
        /// </summary>
        [XmlEnum("gabbroic rock")]
        gabbroicrock,
        /// <summary>
        /// gabbroid property
        /// </summary>
        gabbroid,
        /// <summary>
        /// glauconite property
        /// </summary>
        glauconite,
        /// <summary>
        /// gneiss property
        /// </summary>
        gneiss,
        /// <summary>
        /// granite property
        /// </summary>
        granite,
        /// <summary>
        /// granodiorite property
        /// </summary>
        granodiorite,
        /// <summary>
        /// granofels property
        /// </summary>
        granofels,
        /// <summary>
        /// granulite property
        /// </summary>
        granulite,
        /// <summary>
        /// gravel property
        /// </summary>
        gravel,
        /// <summary>
        /// greenstone property
        /// </summary>
        greenstone,
        /// <summary>
        /// gumbo property
        /// </summary>
        gumbo,
        /// <summary>
        /// gypsum property
        /// </summary>
        gypsum,
        /// <summary>
        /// halite property
        /// </summary>
        halite,
        /// <summary>
        /// hornfels property
        /// </summary>
        hornfels,
        /// <summary>
        /// igneousrock property
        /// </summary>
        [XmlEnum("igneous rock")]
        igneousrock,
        /// <summary>
        /// impactgeneratedmaterial property
        /// </summary>
        [XmlEnum("impact generated material")]
        impactgeneratedmaterial,
        /// <summary>
        /// impuredolomite property
        /// </summary>
        [XmlEnum("impure dolomite")]
        impuredolomite,
        /// <summary>
        /// impurelimestone property
        /// </summary>
        [XmlEnum("impure limestone")]
        impurelimestone,
        /// <summary>
        /// intrusiverockplutonic property
        /// </summary>
        [XmlEnum("intrusive rock (plutonic)")]
        intrusiverockplutonic,
        /// <summary>
        /// ironrichsedimentaryrock property
        /// </summary>
        [XmlEnum("iron rich sedimentary rock")]
        ironrichsedimentaryrock,
        /// <summary>
        /// kalsiliticandmeliliticrocks property
        /// </summary>
        [XmlEnum("kalsilitic and melilitic rocks")]
        kalsiliticandmeliliticrocks,
        /// <summary>
        /// komatiiticrock property
        /// </summary>
        [XmlEnum("komatiitic rock")]
        komatiiticrock,
        /// <summary>
        /// latiticrock property
        /// </summary>
        [XmlEnum("latitic rock")]
        latiticrock,
        /// <summary>
        /// lignite property
        /// </summary>
        lignite,
        /// <summary>
        /// limeboundstone property
        /// </summary>
        [XmlEnum("lime boundstone")]
        limeboundstone,
        /// <summary>
        /// limeframestone property
        /// </summary>
        [XmlEnum("lime framestone")]
        limeframestone,
        /// <summary>
        /// limegrainstone property
        /// </summary>
        [XmlEnum("lime grainstone")]
        limegrainstone,
        /// <summary>
        /// limemudstone property
        /// </summary>
        [XmlEnum("lime mudstone")]
        limemudstone,
        /// <summary>
        /// limepackstone property
        /// </summary>
        [XmlEnum("lime packstone")]
        limepackstone,
        /// <summary>
        /// limewackestone property
        /// </summary>
        [XmlEnum("lime wackestone")]
        limewackestone,
        /// <summary>
        /// limestone property
        /// </summary>
        limestone,
        /// <summary>
        /// marble property
        /// </summary>
        marble,
        /// <summary>
        /// marl property
        /// </summary>
        marl,
        /// <summary>
        /// metamorphicrock property
        /// </summary>
        [XmlEnum("metamorphic rock")]
        metamorphicrock,
        /// <summary>
        /// micaschist property
        /// </summary>
        [XmlEnum("mica schist")]
        micaschist,
        /// <summary>
        /// migmatite property
        /// </summary>
        migmatite,
        /// <summary>
        /// monzogabbro property
        /// </summary>
        monzogabbro,
        /// <summary>
        /// mud property
        /// </summary>
        mud,
        /// <summary>
        /// mudstone property
        /// </summary>
        mudstone,
        /// <summary>
        /// myloniticrock property
        /// </summary>
        [XmlEnum("mylonitic rock")]
        myloniticrock,
        /// <summary>
        /// nodescription property
        /// </summary>
        [XmlEnum("no description")]
        nodescription,
        /// <summary>
        /// nosample property
        /// </summary>
        [XmlEnum("no sample")]
        nosample,
        /// <summary>
        /// ooze property
        /// </summary>
        ooze,
        /// <summary>
        /// ophiolite property
        /// </summary>
        ophiolite,
        /// <summary>
        /// organicbearingmudstone property
        /// </summary>
        [XmlEnum("organic bearing mudstone")]
        organicbearingmudstone,
        /// <summary>
        /// peat property
        /// </summary>
        peat,
        /// <summary>
        /// pegmatite property
        /// </summary>
        pegmatite,
        /// <summary>
        /// peridotite property
        /// </summary>
        peridotite,
        /// <summary>
        /// phaneriticigneousrock property
        /// </summary>
        [XmlEnum("phaneritic igneous rock")]
        phaneriticigneousrock,
        /// <summary>
        /// phonolite property
        /// </summary>
        phonolite,
        /// <summary>
        /// phonolitoid property
        /// </summary>
        phonolitoid,
        /// <summary>
        /// phosphate property
        /// </summary>
        phosphate,
        /// <summary>
        /// phosphaterock property
        /// </summary>
        [XmlEnum("phosphate rock")]
        phosphaterock,
        /// <summary>
        /// phyllite property
        /// </summary>
        phyllite,
        /// <summary>
        /// porphyry property
        /// </summary>
        porphyry,
        /// <summary>
        /// potassiumandmagnesiumsalts property
        /// </summary>
        [XmlEnum("potassium and magnesium salts")]
        potassiumandmagnesiumsalts,
        /// <summary>
        /// pyroclasticbreccia property
        /// </summary>
        [XmlEnum("pyroclastic breccia")]
        pyroclasticbreccia,
        /// <summary>
        /// pyroclasticrock property
        /// </summary>
        [XmlEnum("pyroclastic rock")]
        pyroclasticrock,
        /// <summary>
        /// pyroxenite property
        /// </summary>
        pyroxenite,
        /// <summary>
        /// quartzarenite property
        /// </summary>
        [XmlEnum("quartz arenite")]
        quartzarenite,
        /// <summary>
        /// quartzite property
        /// </summary>
        quartzite,
        /// <summary>
        /// rhyolite property
        /// </summary>
        rhyolite,
        /// <summary>
        /// rocksalt property
        /// </summary>
        [XmlEnum("rock salt")]
        rocksalt,
        /// <summary>
        /// sand property
        /// </summary>
        sand,
        /// <summary>
        /// sandstone property
        /// </summary>
        sandstone,
        /// <summary>
        /// sandy property
        /// </summary>
        sandy,
        /// <summary>
        /// sapropel property
        /// </summary>
        sapropel,
        /// <summary>
        /// schist property
        /// </summary>
        schist,
        /// <summary>
        /// serpentinite property
        /// </summary>
        serpentinite,
        /// <summary>
        /// shale property
        /// </summary>
        shale,
        /// <summary>
        /// siliceousooze property
        /// </summary>
        [XmlEnum("siliceous ooze")]
        siliceousooze,
        /// <summary>
        /// silt property
        /// </summary>
        silt,
        /// <summary>
        /// siltstone property
        /// </summary>
        siltstone,
        /// <summary>
        /// skarn property
        /// </summary>
        skarn,
        /// <summary>
        /// slate property
        /// </summary>
        slate,
        /// <summary>
        /// spilite property
        /// </summary>
        spilite,
        /// <summary>
        /// syenite property
        /// </summary>
        syenite,
        /// <summary>
        /// syenitoid property
        /// </summary>
        syenitoid,
        /// <summary>
        /// sylvite property
        /// </summary>
        sylvite,
        /// <summary>
        /// tephrite property
        /// </summary>
        tephrite,
        /// <summary>
        /// tephritoid property
        /// </summary>
        tephritoid,
        /// <summary>
        /// tholeiiticbasalt property
        /// </summary>
        [XmlEnum("tholeiitic basalt")]
        tholeiiticbasalt,
        /// <summary>
        /// tonalite property
        /// </summary>
        tonalite,
        /// <summary>
        /// trachyte property
        /// </summary>
        trachyte,
        /// <summary>
        /// trachyticrock property
        /// </summary>
        [XmlEnum("trachytic rock")]
        trachyticrock,
        /// <summary>
        /// trachytoid property
        /// </summary>
        trachytoid,
        /// <summary>
        /// travertine property
        /// </summary>
        travertine,
        /// <summary>
        /// tuff property
        /// </summary>
        tuff,
        /// <summary>
        /// tuffite property
        /// </summary>
        tuffite,
        /// <summary>
        /// ultrabasic property
        /// </summary>
        ultrabasic,
        /// <summary>
        /// undifferentiated property
        /// </summary>
        undifferentiated,
        /// <summary>
        /// unknown property
        /// </summary>
        unknown,
        /// <summary>
        /// wacke property
        /// </summary>
        wacke
    }
    /// <summary>
    /// This class represents the ContactSide xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the ContactSide xsd enumeration.")]
    public enum ContactSide
    {
        /// <summary>
        /// footwall property
        /// </summary>
        footwall,
        /// <summary>
        /// hangingwall property
        /// </summary>
        [XmlEnum("hanging wall")]
        hangingwall,
        /// <summary>
        /// For a vertical fault, specification of the north side.
        /// </summary>
        north,
        /// <summary>
        /// For a vertical fault, specification of the south side. 
        /// </summary>
        south,
        /// <summary>
        /// For a vertical fault, specification of the east side. 
        /// </summary>
        east,
        /// <summary>
        /// For a vertical fault, specification of the west side. 
        /// </summary>
        west,
        /// <summary>
        /// Indicates that a fault splits a genetic boundary on its younger side. 
        /// </summary>
        younger,
        /// <summary>
        /// Indicates that a fault splits a genetic boundary on its older side. 
        /// </summary>
        older,
        /// <summary>
        /// Indicates that a fault splits both sides of a genetic feature.
        /// </summary>
        both
    }
    /// <summary>
    /// This class represents the ContactMode xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the ContactMode xsd enumeration.")]
    public enum ContactMode
    {
        /// <summary>
        /// conformable property
        /// </summary>
        conformable,
        /// <summary>
        /// extended property
        /// </summary>
        extended,
        /// <summary>
        /// unconformable property
        /// </summary>
        unconformable
    }
    /// <summary>
    /// This class represents the FacetKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the FacetKind xsd enumeration.")]
    public enum FacetKind
    {
        /// <summary>
        /// Indicates condition of how the property was acquired, e.g., distinguishing surface condition of a fluid compared to reservoir conditions. 
        /// </summary>
        conditions,
        /// <summary>
        /// Indicates on which side of a surface the property applies, for example, it can indicate plus or minus.
        /// </summary>
        side,
        /// <summary>
        /// Indicates that the property is directional. Common values are X, Y, or Z for vectors; I, J, or K for properties on a grid; or tensorial coordinates, e.g., XX or IJ. For example, vertical permeability vs. horizontal permeability.
        /// </summary>
        direction,
        /// <summary>
        /// Indicates that the property is of kind net or gross, i.e., indicates that the spatial support of a property is averaged only over the net rock or all of the rock. rock or all of the rock.
        /// </summary>
        netgross,
        /// <summary>
        /// Used to capture any other context not covered by the other facet types listed here.
        /// </summary>
        qualifier,
        /// <summary>
        /// Indicates values such as minimum, maximum, average, etc.
        /// </summary>
        statistics,
        /// <summary>
        /// Indicates the element that is measured, for example, the concentration of a mineral.
        /// </summary>
        what
    }
    /// <summary>
    /// This class represents the IdentityKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the IdentityKind xsd enumeration.")]
    public enum IdentityKind
    {
        /// <summary>
        /// A set of (sub)representations is collocated if there is bijection between the simple elements of all of the participating (sub)representations. This definition implies there is the same number of simple elements. NOTE: The geometric location of each set of simple elements mapped through the bijection is intended to be identical even if the numeric values of the associated geometries differ, i.e., due to loss of spatial resolution.
        /// </summary>
        collocation,
        /// <summary>
        /// previouscollocation property
        /// </summary>
        [XmlEnum("previous collocation")]
        previouscollocation,
        /// <summary>
        /// A set of (sub)representations is equivalent if there is a map giving an association between some of the simple topological elements of the participating (sub)representations.
        /// </summary>
        equivalence,
        /// <summary>
        /// previousequivalence property
        /// </summary>
        [XmlEnum("previous equivalence")]
        previousequivalence
    }
    /// <summary>
    /// This class represents the IndexableElement xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the IndexableElement xsd enumeration.")]
    public enum IndexableElement
    {
        /// <summary>
        /// cells property
        /// </summary>
        cells,
        /// <summary>
        /// intervalsfromdatum property
        /// </summary>
        [XmlEnum("intervals from datum")]
        intervalsfromdatum,
        /// <summary>
        /// columnedges property
        /// </summary>
        [XmlEnum("column edges")]
        columnedges,
        /// <summary>
        /// columns property
        /// </summary>
        columns,
        /// <summary>
        /// contacts property
        /// </summary>
        contacts,
        /// <summary>
        /// coordinatelines property
        /// </summary>
        [XmlEnum("coordinate lines")]
        coordinatelines,
        /// <summary>
        /// edges property
        /// </summary>
        edges,
        /// <summary>
        /// edgespercolumn property
        /// </summary>
        [XmlEnum("edges per column")]
        edgespercolumn,
        /// <summary>
        /// enumeratedelements property
        /// </summary>
        [XmlEnum("enumerated elements")]
        enumeratedelements,
        /// <summary>
        /// faces property
        /// </summary>
        faces,
        /// <summary>
        /// facespercell property
        /// </summary>
        [XmlEnum("faces per cell")]
        facespercell,
        /// <summary>
        /// intervaledges property
        /// </summary>
        [XmlEnum("interval edges")]
        intervaledges,
        /// <summary>
        /// intervals property
        /// </summary>
        intervals,
        /// <summary>
        /// I0 property
        /// </summary>
        I0,
        /// <summary>
        /// I0edges property
        /// </summary>
        [XmlEnum("I0 edges")]
        I0edges,
        /// <summary>
        /// J0 property
        /// </summary>
        J0,
        /// <summary>
        /// J0edges property
        /// </summary>
        [XmlEnum("J0 edges")]
        J0edges,
        /// <summary>
        /// layers property
        /// </summary>
        layers,
        /// <summary>
        /// lines property
        /// </summary>
        lines,
        /// <summary>
        /// nodes property
        /// </summary>
        nodes,
        /// <summary>
        /// nodespercell property
        /// </summary>
        [XmlEnum("nodes per cell")]
        nodespercell,
        /// <summary>
        /// nodesperedge property
        /// </summary>
        [XmlEnum("nodes per edge")]
        nodesperedge,
        /// <summary>
        /// nodesperface property
        /// </summary>
        [XmlEnum("nodes per face")]
        nodesperface,
        /// <summary>
        /// patches property
        /// </summary>
        patches,
        /// <summary>
        /// pillars property
        /// </summary>
        pillars,
        /// <summary>
        /// regions property
        /// </summary>
        regions,
        /// <summary>
        /// representation property
        /// </summary>
        representation,
        /// <summary>
        /// subnodes property
        /// </summary>
        subnodes,
        /// <summary>
        /// triangles property
        /// </summary>
        triangles
    }
    /// <summary>
    /// This class represents the GridGeometryAttachment xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the GridGeometryAttachment xsd enumeration.")]
    public enum GridGeometryAttachment
    {
        /// <summary>
        /// Geometry may be attached to cells to distort the geometry of that specific cell, only (finite element grid).
        /// </summary>
        cells,
        /// <summary>
        /// Geometry may be attached to edges to distort the geometry of all cells that refer to that edge (finite element grid). BUSINESS RULE: The edges indexing must be known or defined in the grid representation if geometry is attached to the edges.
        /// </summary>
        edges,
        /// <summary>
        /// Geometry may be attached to faces to distort the geometry of all cells that refer to that face (finite element grid). BUSINESS RULE: The faces indexing must be known or defined in the grid representation if geometry is attached to the faces.
        /// </summary>
        faces,
        /// <summary>
        /// hingenodefaces property
        /// </summary>
        [XmlEnum("hinge node faces")]
        hingenodefaces,
        /// <summary>
        /// Additional grid geometry may be attached to split or truncated node patches for column layer grids. All other node geometry attachment should be done through the Points array of the AbstractGridGeometry, not through the additional grid geometry.
        /// </summary>
        nodes,
        /// <summary>
        /// radialoriginpolyline property
        /// </summary>
        [XmlEnum("radial origin polyline")]
        radialoriginpolyline,
        /// <summary>
        /// Geometry may be attached to subnodes to distort the geometry of all cells that refer to that subnode (finite element grid). BUSINESS RULE: An optional subnode patch object must be defined in the grid representation if geometry is attached to the subnodes.
        /// </summary>
        subnodes
    }
    /// <summary>
    /// This class represents the CellShape xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the CellShape xsd enumeration.")]
    public enum CellShape
    {
        /// <summary>
        /// All grid cells are constrained to have only 4 nodes/cell with 4 faces/cell, 3 nodes/face, 4 nodes/cell for all cells (degeneracy allowed).
        /// </summary>
        tetrahedral,
        /// <summary>
        /// All grid cells are constrained to have only 5 nodes/cell with 5 faces/cell, with 1 quadrilateral face and 4 triangular faces.
        /// </summary>
        pyramidal,
        /// <summary>
        /// All grid cells are constrained to have 6 nodes/cell with 5 faces/cell, with 3 quadrilateral faces and 2 non-adjacent triangular faces, as in a column layer grid with triangular columns.
        /// </summary>
        prism,
        /// <summary>
        /// All grid cells are constrained to have 8 nodes/cell with 6 faces/cell, 4 nodes/face, 8 nodes/cell for all cells (degeneracy allowed). Equivalent to IJK grid cells.
        /// </summary>
        hexahedral,
        /// <summary>
        /// If the cell geometry is not of a more specific kind, use polyhedral.
        /// </summary>
        polyhedral
    }
    /// <summary>
    /// This class represents the SubnodeNodeObject xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the SubnodeNodeObject xsd enumeration.")]
    public enum SubnodeNodeObject
    {
        /// <summary>
        /// If geometry or properties are discontinuous from cell to cell (i.e., their spatial support is cell), then attach them to cell subnodes. BUSINESS RULE: If this object kind is selected, then an ordered list of nodes per cell must be specified or otherwise known.
        /// </summary>
        cell,
        /// <summary>
        /// If geometry or properties are continuous between cells that share the same face (i.e., their spatial support is the face), then attach them to face subnodes. BUSINESS RULE: If this object kind is selected, then an ordered list of nodes per face must be specified or otherwise known.
        /// </summary>
        face,
        /// <summary>
        /// If geometry and properties are continuous between cells that share the same edge of a face (i.e. their spatial support is the edge), then attach them to edge subnodes. BUSINESS RULE: If this object kind is selected, then an ordered list of nodes per edge must be specified or otherwise known.
        /// </summary>
        edge
    }
    /// <summary>
    /// This class represents the KDirection xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the KDirection xsd enumeration.")]
    public enum KDirection
    {
        /// <summary>
        /// K is increasing with depth, dot(tangent,gradDepth)&amp;gt;0.
        /// </summary>
        down,
        /// <summary>
        /// K is increasing with elevation, dot(tangent,gradDepth)&amp;lt;0.
        /// </summary>
        up,
        /// <summary>
        /// notmonotonic property
        /// </summary>
        [XmlEnum("not monotonic")]
        notmonotonic
    }
    /// <summary>
    /// This class represents the PillarShape xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the PillarShape xsd enumeration.")]
    public enum PillarShape
    {
        /// <summary>
        /// If represented by a parametric line, requires only a single control point per line.
        /// </summary>
        vertical,
        /// <summary>
        /// If represented by a parametric line, requires 2 control points per line.
        /// </summary>
        straight,
        /// <summary>
        /// If represented by a parametric line, requires 3 or more control points per line.
        /// </summary>
        curved
    }
    /// <summary>
    /// This class represents the ColumnShape xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the ColumnShape xsd enumeration.")]
    public enum ColumnShape
    {
        /// <summary>
        /// All grid columns have 3 sides.
        /// </summary>
        triangular,
        /// <summary>
        /// All grid columns have 4 sides. Includes tartan and corner point grids.
        /// </summary>
        quadrilateral,
        /// <summary>
        /// At least one grid column is a polygon, N&amp;gt;4.
        /// </summary>
        polygonal
    }
    /// <summary>
    /// This class represents the VolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumeUom xsd enumeration.")]
    public enum VolumeUom
    {
        /// <summary>
        /// Item1000bbl property
        /// </summary>
        [XmlEnum("1000 bbl")]
        Item1000bbl,
        /// <summary>
        /// Item1000ft3 property
        /// </summary>
        [XmlEnum("1000 ft3")]
        Item1000ft3,
        /// <summary>
        /// Item1000galUK property
        /// </summary>
        [XmlEnum("1000 gal[UK]")]
        Item1000galUK,
        /// <summary>
        /// Item1000galUS property
        /// </summary>
        [XmlEnum("1000 gal[US]")]
        Item1000galUS,
        /// <summary>
        /// Item1000m3 property
        /// </summary>
        [XmlEnum("1000 m3")]
        Item1000m3,
        /// <summary>
        /// Item1E6galUS property
        /// </summary>
        [XmlEnum("1E-6 gal[US]")]
        Item1E6galUS,
        /// <summary>
        /// Item1E12ft3 property
        /// </summary>
        [XmlEnum("1E12 ft3")]
        Item1E12ft3,
        /// <summary>
        /// Item1E6bbl property
        /// </summary>
        [XmlEnum("1E6 bbl")]
        Item1E6bbl,
        /// <summary>
        /// Item1E6ft3 property
        /// </summary>
        [XmlEnum("1E6 ft3")]
        Item1E6ft3,
        /// <summary>
        /// Item1E6m3 property
        /// </summary>
        [XmlEnum("1E6 m3")]
        Item1E6m3,
        /// <summary>
        /// Item1E9bbl property
        /// </summary>
        [XmlEnum("1E9 bbl")]
        Item1E9bbl,
        /// <summary>
        /// Item1E9ft3 property
        /// </summary>
        [XmlEnum("1E9 ft3")]
        Item1E9ft3,
        /// <summary>
        /// acreft property
        /// </summary>
        [XmlEnum("acre.ft")]
        acreft,
        /// <summary>
        /// bbl property
        /// </summary>
        bbl,
        /// <summary>
        /// cm3 property
        /// </summary>
        cm3,
        /// <summary>
        /// dm3 property
        /// </summary>
        dm3,
        /// <summary>
        /// flozUK property
        /// </summary>
        [XmlEnum("floz[UK]")]
        flozUK,
        /// <summary>
        /// flozUS property
        /// </summary>
        [XmlEnum("floz[US]")]
        flozUS,
        /// <summary>
        /// ft3 property
        /// </summary>
        ft3,
        /// <summary>
        /// galUK property
        /// </summary>
        [XmlEnum("gal[UK]")]
        galUK,
        /// <summary>
        /// galUS property
        /// </summary>
        [XmlEnum("gal[US]")]
        galUS,
        /// <summary>
        /// ham property
        /// </summary>
        [XmlEnum("ha.m")]
        ham,
        /// <summary>
        /// hL property
        /// </summary>
        hL,
        /// <summary>
        /// in3 property
        /// </summary>
        in3,
        /// <summary>
        /// km3 property
        /// </summary>
        km3,
        /// <summary>
        /// L property
        /// </summary>
        L,
        /// <summary>
        /// m3 property
        /// </summary>
        m3,
        /// <summary>
        /// mi3 property
        /// </summary>
        mi3,
        /// <summary>
        /// mL property
        /// </summary>
        mL,
        /// <summary>
        /// mm3 property
        /// </summary>
        mm3,
        /// <summary>
        /// ptUK property
        /// </summary>
        [XmlEnum("pt[UK]")]
        ptUK,
        /// <summary>
        /// ptUS property
        /// </summary>
        [XmlEnum("pt[US]")]
        ptUS,
        /// <summary>
        /// qtUK property
        /// </summary>
        [XmlEnum("qt[UK]")]
        qtUK,
        /// <summary>
        /// qtUS property
        /// </summary>
        [XmlEnum("qt[US]")]
        qtUS,
        /// <summary>
        /// um2m property
        /// </summary>
        [XmlEnum("um2.m")]
        um2m,
        /// <summary>
        /// yd3 property
        /// </summary>
        yd3
    }
    /// <summary>
    /// This class represents the ContactVerb xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the ContactVerb xsd enumeration.")]
    public enum ContactVerb
    {
        /// <summary>
        /// stops property
        /// </summary>
        stops,
        /// <summary>
        /// Operation on which an “unconformable” genetic boundary interpretation interrupts another genetic boundary interpretation or a stratigraphic unit interpretation. 
        /// </summary>
        interrupts,
        /// <summary>
        /// Defines if a tectonic boundary interpretation crosses another tectonic boundary interpretation. 
        /// </summary>
        crosses
    }
    /// <summary>
    /// This class represents the PlaneAngleUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PlaneAngleUom xsd enumeration.")]
    public enum PlaneAngleUom
    {
        /// <summary>
        /// Item0001seca property
        /// </summary>
        [XmlEnum("0.001 seca")]
        Item0001seca,
        /// <summary>
        /// ccgr property
        /// </summary>
        ccgr,
        /// <summary>
        /// cgr property
        /// </summary>
        cgr,
        /// <summary>
        /// dega property
        /// </summary>
        dega,
        /// <summary>
        /// gon property
        /// </summary>
        gon,
        /// <summary>
        /// krad property
        /// </summary>
        krad,
        /// <summary>
        /// mila property
        /// </summary>
        mila,
        /// <summary>
        /// mina property
        /// </summary>
        mina,
        /// <summary>
        /// Mrad property
        /// </summary>
        Mrad,
        /// <summary>
        /// mrad property
        /// </summary>
        mrad,
        /// <summary>
        /// rad property
        /// </summary>
        rad,
        /// <summary>
        /// rev property
        /// </summary>
        rev,
        /// <summary>
        /// seca property
        /// </summary>
        seca,
        /// <summary>
        /// urad property
        /// </summary>
        urad
    }
    /// <summary>
    /// This class represents the LengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LengthUom xsd enumeration.")]
    public enum LengthUom
    {
        /// <summary>
        /// Item01ft property
        /// </summary>
        [XmlEnum("0.1 ft")]
        Item01ft,
        /// <summary>
        /// Item01ftUS property
        /// </summary>
        [XmlEnum("0.1 ft[US]")]
        Item01ftUS,
        /// <summary>
        /// Item01in property
        /// </summary>
        [XmlEnum("0.1 in")]
        Item01in,
        /// <summary>
        /// Item01yd property
        /// </summary>
        [XmlEnum("0.1 yd")]
        Item01yd,
        /// <summary>
        /// Item116in property
        /// </summary>
        [XmlEnum("1/16 in")]
        Item116in,
        /// <summary>
        /// Item12ft property
        /// </summary>
        [XmlEnum("1/2 ft")]
        Item12ft,
        /// <summary>
        /// Item132in property
        /// </summary>
        [XmlEnum("1/32 in")]
        Item132in,
        /// <summary>
        /// Item164in property
        /// </summary>
        [XmlEnum("1/64 in")]
        Item164in,
        /// <summary>
        /// Item10ft property
        /// </summary>
        [XmlEnum("10 ft")]
        Item10ft,
        /// <summary>
        /// Item10in property
        /// </summary>
        [XmlEnum("10 in")]
        Item10in,
        /// <summary>
        /// Item10km property
        /// </summary>
        [XmlEnum("10 km")]
        Item10km,
        /// <summary>
        /// Item100ft property
        /// </summary>
        [XmlEnum("100 ft")]
        Item100ft,
        /// <summary>
        /// Item100km property
        /// </summary>
        [XmlEnum("100 km")]
        Item100km,
        /// <summary>
        /// Item1000ft property
        /// </summary>
        [XmlEnum("1000 ft")]
        Item1000ft,
        /// <summary>
        /// Item30ft property
        /// </summary>
        [XmlEnum("30 ft")]
        Item30ft,
        /// <summary>
        /// Item30m property
        /// </summary>
        [XmlEnum("30 m")]
        Item30m,
        /// <summary>
        /// angstrom property
        /// </summary>
        angstrom,
        /// <summary>
        /// chain property
        /// </summary>
        chain,
        /// <summary>
        /// chainBnA property
        /// </summary>
        [XmlEnum("chain[BnA]")]
        chainBnA,
        /// <summary>
        /// chainBnB property
        /// </summary>
        [XmlEnum("chain[BnB]")]
        chainBnB,
        /// <summary>
        /// chainCla property
        /// </summary>
        [XmlEnum("chain[Cla]")]
        chainCla,
        /// <summary>
        /// chainInd37 property
        /// </summary>
        [XmlEnum("chain[Ind37]")]
        chainInd37,
        /// <summary>
        /// chainSe property
        /// </summary>
        [XmlEnum("chain[Se]")]
        chainSe,
        /// <summary>
        /// chainSeT property
        /// </summary>
        [XmlEnum("chain[SeT]")]
        chainSeT,
        /// <summary>
        /// chainUS property
        /// </summary>
        [XmlEnum("chain[US]")]
        chainUS,
        /// <summary>
        /// cm property
        /// </summary>
        cm,
        /// <summary>
        /// dam property
        /// </summary>
        dam,
        /// <summary>
        /// dm property
        /// </summary>
        dm,
        /// <summary>
        /// Em property
        /// </summary>
        Em,
        /// <summary>
        /// fathom property
        /// </summary>
        fathom,
        /// <summary>
        /// fm property
        /// </summary>
        fm,
        /// <summary>
        /// ft property
        /// </summary>
        ft,
        /// <summary>
        /// ftBnA property
        /// </summary>
        [XmlEnum("ft[BnA]")]
        ftBnA,
        /// <summary>
        /// ftBnB property
        /// </summary>
        [XmlEnum("ft[BnB]")]
        ftBnB,
        /// <summary>
        /// ftBr36 property
        /// </summary>
        [XmlEnum("ft[Br36]")]
        ftBr36,
        /// <summary>
        /// ftBr65 property
        /// </summary>
        [XmlEnum("ft[Br65]")]
        ftBr65,
        /// <summary>
        /// ftCla property
        /// </summary>
        [XmlEnum("ft[Cla]")]
        ftCla,
        /// <summary>
        /// ftGC property
        /// </summary>
        [XmlEnum("ft[GC]")]
        ftGC,
        /// <summary>
        /// ftInd property
        /// </summary>
        [XmlEnum("ft[Ind]")]
        ftInd,
        /// <summary>
        /// ftInd37 property
        /// </summary>
        [XmlEnum("ft[Ind37]")]
        ftInd37,
        /// <summary>
        /// ftInd62 property
        /// </summary>
        [XmlEnum("ft[Ind62]")]
        ftInd62,
        /// <summary>
        /// ftInd75 property
        /// </summary>
        [XmlEnum("ft[Ind75]")]
        ftInd75,
        /// <summary>
        /// ftSe property
        /// </summary>
        [XmlEnum("ft[Se]")]
        ftSe,
        /// <summary>
        /// ftSeT property
        /// </summary>
        [XmlEnum("ft[SeT]")]
        ftSeT,
        /// <summary>
        /// ftUS property
        /// </summary>
        [XmlEnum("ft[US]")]
        ftUS,
        /// <summary>
        /// furUS property
        /// </summary>
        [XmlEnum("fur[US]")]
        furUS,
        /// <summary>
        /// Gm property
        /// </summary>
        Gm,
        /// <summary>
        /// hm property
        /// </summary>
        hm,
        /// <summary>
        /// in property
        /// </summary>
        @in,
        /// <summary>
        /// inUS property
        /// </summary>
        [XmlEnum("in[US]")]
        inUS,
        /// <summary>
        /// km property
        /// </summary>
        km,
        /// <summary>
        /// link property
        /// </summary>
        link,
        /// <summary>
        /// linkBnA property
        /// </summary>
        [XmlEnum("link[BnA]")]
        linkBnA,
        /// <summary>
        /// linkBnB property
        /// </summary>
        [XmlEnum("link[BnB]")]
        linkBnB,
        /// <summary>
        /// linkCla property
        /// </summary>
        [XmlEnum("link[Cla]")]
        linkCla,
        /// <summary>
        /// linkSe property
        /// </summary>
        [XmlEnum("link[Se]")]
        linkSe,
        /// <summary>
        /// linkSeT property
        /// </summary>
        [XmlEnum("link[SeT]")]
        linkSeT,
        /// <summary>
        /// linkUS property
        /// </summary>
        [XmlEnum("link[US]")]
        linkUS,
        /// <summary>
        /// m property
        /// </summary>
        m,
        /// <summary>
        /// mGer property
        /// </summary>
        [XmlEnum("m[Ger]")]
        mGer,
        /// <summary>
        /// mi property
        /// </summary>
        mi,
        /// <summary>
        /// minaut property
        /// </summary>
        [XmlEnum("mi[naut]")]
        minaut,
        /// <summary>
        /// minautUK property
        /// </summary>
        [XmlEnum("mi[nautUK]")]
        minautUK,
        /// <summary>
        /// miUS property
        /// </summary>
        [XmlEnum("mi[US]")]
        miUS,
        /// <summary>
        /// mil property
        /// </summary>
        mil,
        /// <summary>
        /// mm property
        /// </summary>
        mm,
        /// <summary>
        /// Mm property
        /// </summary>
        Mm,
        /// <summary>
        /// nm property
        /// </summary>
        nm,
        /// <summary>
        /// pm property
        /// </summary>
        pm,
        /// <summary>
        /// rodUS property
        /// </summary>
        [XmlEnum("rod[US]")]
        rodUS,
        /// <summary>
        /// Tm property
        /// </summary>
        Tm,
        /// <summary>
        /// um property
        /// </summary>
        um,
        /// <summary>
        /// yd property
        /// </summary>
        yd,
        /// <summary>
        /// ydBnA property
        /// </summary>
        [XmlEnum("yd[BnA]")]
        ydBnA,
        /// <summary>
        /// ydBnB property
        /// </summary>
        [XmlEnum("yd[BnB]")]
        ydBnB,
        /// <summary>
        /// ydCla property
        /// </summary>
        [XmlEnum("yd[Cla]")]
        ydCla,
        /// <summary>
        /// ydInd property
        /// </summary>
        [XmlEnum("yd[Ind]")]
        ydInd,
        /// <summary>
        /// ydInd37 property
        /// </summary>
        [XmlEnum("yd[Ind37]")]
        ydInd37,
        /// <summary>
        /// ydInd62 property
        /// </summary>
        [XmlEnum("yd[Ind62]")]
        ydInd62,
        /// <summary>
        /// ydInd75 property
        /// </summary>
        [XmlEnum("yd[Ind75]")]
        ydInd75,
        /// <summary>
        /// ydSe property
        /// </summary>
        [XmlEnum("yd[Se]")]
        ydSe,
        /// <summary>
        /// ydSeT property
        /// </summary>
        [XmlEnum("yd[SeT]")]
        ydSeT,
        /// <summary>
        /// ydUS property
        /// </summary>
        [XmlEnum("yd[US]")]
        ydUS
    }
    /// <summary>
    /// This class represents the RelatedTimeTypeRelativePosition xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
    [Description("This class represents the RelatedTimeTypeRelativePosition xsd enumeration.")]
    public enum RelatedTimeTypeRelativePosition
    {
        /// <summary>
        /// Before property
        /// </summary>
        Before,
        /// <summary>
        /// After property
        /// </summary>
        After,
        /// <summary>
        /// Begins property
        /// </summary>
        Begins,
        /// <summary>
        /// Ends property
        /// </summary>
        Ends,
        /// <summary>
        /// During property
        /// </summary>
        During,
        /// <summary>
        /// Equals property
        /// </summary>
        Equals,
        /// <summary>
        /// Contains property
        /// </summary>
        Contains,
        /// <summary>
        /// Overlaps property
        /// </summary>
        Overlaps,
        /// <summary>
        /// Meets property
        /// </summary>
        Meets,
        /// <summary>
        /// OverlappedBy property
        /// </summary>
        OverlappedBy,
        /// <summary>
        /// MetBy property
        /// </summary>
        MetBy,
        /// <summary>
        /// BegunBy property
        /// </summary>
        BegunBy,
        /// <summary>
        /// EndedBy property
        /// </summary>
        EndedBy
    }
    /// <summary>
    /// This class represents the AggregationType xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
    [Description("This class represents the AggregationType xsd enumeration.")]
    public enum AggregationType
    {
        /// <summary>
        /// set property
        /// </summary>
        set,
        /// <summary>
        /// bag property
        /// </summary>
        bag,
        /// <summary>
        /// sequence property
        /// </summary>
        sequence,
        /// <summary>
        /// array property
        /// </summary>
        array,
        /// <summary>
        /// record property
        /// </summary>
        record,
        /// <summary>
        /// table property
        /// </summary>
        table
    }
    /// <summary>
    /// This class represents the ParameterKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ParameterKind xsd enumeration.")]
    public enum ParameterKind
    {
        /// <summary>
        /// dataObject property
        /// </summary>
        dataObject,
        /// <summary>
        /// double property
        /// </summary>
        @double,
        /// <summary>
        /// integer property
        /// </summary>
        integer,
        /// <summary>
        /// string property
        /// </summary>
        @string,
        /// <summary>
        /// timestamp property
        /// </summary>
        timestamp,
        /// <summary>
        /// subActivity property
        /// </summary>
        subActivity
    }
    /// <summary>
    /// This class represents the TimeSetKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the TimeSetKind xsd enumeration.")]
    public enum TimeSetKind
    {
        /// <summary>
        /// singletime property
        /// </summary>
        [XmlEnum("single time")]
        singletime,
        /// <summary>
        /// singletimeseries property
        /// </summary>
        [XmlEnum("single time series")]
        singletimeseries,
        /// <summary>
        /// equivalenttimes property
        /// </summary>
        [XmlEnum("equivalent times")]
        equivalenttimes,
        /// <summary>
        /// notatimeset property
        /// </summary>
        [XmlEnum("not a time set")]
        notatimeset
    }
    /// <summary>
    /// This class represents the AxisOrder2d xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AxisOrder2d xsd enumeration.")]
    public enum AxisOrder2d
    {
        /// <summary>
        /// eastingnorthing property
        /// </summary>
        [XmlEnum("easting northing")]
        eastingnorthing,
        /// <summary>
        /// northingeasting property
        /// </summary>
        [XmlEnum("northing easting")]
        northingeasting,
        /// <summary>
        /// westingsouthing property
        /// </summary>
        [XmlEnum("westing southing")]
        westingsouthing,
        /// <summary>
        /// southingwesting property
        /// </summary>
        [XmlEnum("southing westing")]
        southingwesting,
        /// <summary>
        /// northingwesting property
        /// </summary>
        [XmlEnum("northing westing")]
        northingwesting,
        /// <summary>
        /// westingnorthing property
        /// </summary>
        [XmlEnum("westing northing")]
        westingnorthing
    }
    /// <summary>
    /// This class represents the FluidContact xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the FluidContact xsd enumeration.")]
    public enum FluidContact
    {
        /// <summary>
        /// freewatercontact property
        /// </summary>
        [XmlEnum("free water contact")]
        freewatercontact,
        /// <summary>
        /// gasoilcontact property
        /// </summary>
        [XmlEnum("gas oil contact")]
        gasoilcontact,
        /// <summary>
        /// gaswatercontact property
        /// </summary>
        [XmlEnum("gas water contact")]
        gaswatercontact,
        /// <summary>
        /// Identifies a break in the hydrostatic column.
        /// </summary>
        seal,
        /// <summary>
        /// wateroilcontact property
        /// </summary>
        [XmlEnum("water oil contact")]
        wateroilcontact
    }
    /// <summary>
    /// This class represents the FluidMarker xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the FluidMarker xsd enumeration.")]
    public enum FluidMarker
    {
        /// <summary>
        /// gasdownto property
        /// </summary>
        [XmlEnum("gas down to")]
        gasdownto,
        /// <summary>
        /// gasupto property
        /// </summary>
        [XmlEnum("gas up to")]
        gasupto,
        /// <summary>
        /// oildownto property
        /// </summary>
        [XmlEnum("oil down to")]
        oildownto,
        /// <summary>
        /// oilupto property
        /// </summary>
        [XmlEnum("oil up to")]
        oilupto,
        /// <summary>
        /// waterdownto property
        /// </summary>
        [XmlEnum("water down to")]
        waterdownto,
        /// <summary>
        /// waterupto property
        /// </summary>
        [XmlEnum("water up to")]
        waterupto
    }
    /// <summary>
    /// This class represents the GeologicBoundaryKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the GeologicBoundaryKind xsd enumeration.")]
    public enum GeologicBoundaryKind
    {
        /// <summary>
        /// fault property
        /// </summary>
        fault,
        /// <summary>
        /// geobody property
        /// </summary>
        geobody,
        /// <summary>
        /// horizon property
        /// </summary>
        horizon
    }
    /// <summary>
    /// This class represents the MdDomain xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the MdDomain xsd enumeration.")]
    public enum MdDomain
    {
        /// <summary>
        /// The original depths recorded while drilling a well or LWD or MWD.
        /// </summary>
        driller,
        /// <summary>
        /// Depths recorded when logging a well, which are in general considered to be more accurate than driller's depth.
        /// </summary>
        logger
    }
    /// <summary>
    /// This class represents the LineRole xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the LineRole xsd enumeration.")]
    public enum LineRole
    {
        /// <summary>
        /// faultcenterline property
        /// </summary>
        [XmlEnum("fault center line")]
        faultcenterline,
        /// <summary>
        /// Used to represent all types of nonsealed contact interpretation parts defined by a horizon/fault intersection.
        /// </summary>
        pick,
        /// <summary>
        /// innerring property
        /// </summary>
        [XmlEnum("inner ring")]
        innerring,
        /// <summary>
        /// outerring property
        /// </summary>
        [XmlEnum("outer ring")]
        outerring,
        /// <summary>
        /// Polyline that is used to represent a well trajectory representation.
        /// </summary>
        trajectory,
        /// <summary>
        /// interpretationline property
        /// </summary>
        [XmlEnum("interpretation line")]
        interpretationline,
        /// <summary>
        /// Used to represent nonsealed contact interpretation parts defined by a horizon/fault intersection.
        /// </summary>
        contact,
        /// <summary>
        /// depositionalline property
        /// </summary>
        [XmlEnum("depositional line")]
        depositionalline,
        /// <summary>
        /// erosionline property
        /// </summary>
        [XmlEnum("erosion line")]
        erosionline,
        /// <summary>
        /// Used to obtain sets of 3D x, y, z points to represent any boundary interpretation.
        /// </summary>
        contouring,
        /// <summary>
        /// Used to represent the pillars of a column-layer volumic grid. 
        /// </summary>
        pillar
    }
    /// <summary>
    /// This class represents the SurfaceRole xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the SurfaceRole xsd enumeration.")]
    public enum SurfaceRole
    {
        /// <summary>
        /// Representation support for properties.
        /// </summary>
        map,
        /// <summary>
        /// Representation support for 3D points picked in 2D or 3D.
        /// </summary>
        pick
    }
    /// <summary>
    /// This class represents the DepositionMode xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the DepositionMode xsd enumeration.")]
    public enum DepositionMode
    {
        /// <summary>
        /// proportionalbetweentopandbottom property
        /// </summary>
        [XmlEnum("proportional between top and bottom")]
        proportionalbetweentopandbottom,
        /// <summary>
        /// paralleltobottom property
        /// </summary>
        [XmlEnum("parallel to bottom")]
        paralleltobottom,
        /// <summary>
        /// paralleltotop property
        /// </summary>
        [XmlEnum("parallel to top")]
        paralleltotop,
        /// <summary>
        /// paralleltoanotherboundary property
        /// </summary>
        [XmlEnum("parallel to another boundary")]
        paralleltoanotherboundary
    }
    /// <summary>
    /// This class represents the StratigraphicUnitKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the StratigraphicUnitKind xsd enumeration.")]
    public enum StratigraphicUnitKind
    {
        /// <summary>
        /// chronostratigraphic property
        /// </summary>
        chronostratigraphic,
        /// <summary>
        /// lithostratigraphic property
        /// </summary>
        lithostratigraphic,
        /// <summary>
        /// biostratigraphic property
        /// </summary>
        biostratigraphic
    }
    /// <summary>
    /// This class represents the GeologicUnitMaterialEmplacement xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the GeologicUnitMaterialEmplacement xsd enumeration.")]
    public enum GeologicUnitMaterialEmplacement
    {
        /// <summary>
        /// intrusive property
        /// </summary>
        intrusive,
        /// <summary>
        /// nonintrusive property
        /// </summary>
        [XmlEnum("non-intrusive")]
        nonintrusive
    }
    /// <summary>
    /// This class represents the Domain xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the Domain xsd enumeration.")]
    public enum Domain
    {
        /// <summary>
        /// Position defined by measurements in the depth domain.
        /// </summary>
        depth,
        /// <summary>
        /// Position based on geophysical measurements in two-way time (TWT).
        /// </summary>
        time,
        /// <summary>
        /// depth + time
        /// </summary>
        mixed
    }
    /// <summary>
    /// This class represents the OrderingCriteria xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the OrderingCriteria xsd enumeration.")]
    public enum OrderingCriteria
    {
        /// <summary>
        /// From youngest to oldest period (increasing age).
        /// </summary>
        age,
        /// <summary>
        /// apparentdepth property
        /// </summary>
        [XmlEnum("apparent depth")]
        apparentdepth,
        /// <summary>
        /// measureddepth property
        /// </summary>
        [XmlEnum("measured depth")]
        measureddepth
    }
    /// <summary>
    /// This class represents the BoundaryRelation xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the BoundaryRelation xsd enumeration.")]
    public enum BoundaryRelation
    {
        /// <summary>
        /// conformable property
        /// </summary>
        conformable,
        /// <summary>
        /// unconformablebelowandabove property
        /// </summary>
        [XmlEnum("unconformable below and above")]
        unconformablebelowandabove,
        /// <summary>
        /// unconformableabove property
        /// </summary>
        [XmlEnum("unconformable above")]
        unconformableabove,
        /// <summary>
        /// unconformablebelow property
        /// </summary>
        [XmlEnum("unconformable below")]
        unconformablebelow
    }
    /// <summary>
    /// This class represents the HorizonStratigraphicRole xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the HorizonStratigraphicRole xsd enumeration.")]
    public enum HorizonStratigraphicRole
    {
        /// <summary>
        /// chronostratigraphic property
        /// </summary>
        chronostratigraphic,
        /// <summary>
        /// lithostratigraphic property
        /// </summary>
        lithostratigraphic,
        /// <summary>
        /// biostratigraphic property
        /// </summary>
        biostratigraphic
    }
    /// <summary>
    /// This class represents the SequenceStratigraphySurface xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the SequenceStratigraphySurface xsd enumeration.")]
    public enum SequenceStratigraphySurface
    {
        /// <summary>
        /// flooding property
        /// </summary>
        flooding,
        /// <summary>
        /// ravinement property
        /// </summary>
        ravinement,
        /// <summary>
        /// maximumflooding property
        /// </summary>
        [XmlEnum("maximum flooding")]
        maximumflooding,
        /// <summary>
        /// transgressive property
        /// </summary>
        transgressive
    }
    /// <summary>
    /// This class represents the Phase xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the Phase xsd enumeration.")]
    public enum Phase
    {
        /// <summary>
        /// Volume of the hydrostatic column for which only the aqueous phase is mobile. Typically below the Pc (hydrocarbon-water) = 0 free fluid surface.
        /// </summary>
        aquifer,
        /// <summary>
        /// gascap property
        /// </summary>
        [XmlEnum("gas cap")]
        gascap,
        /// <summary>
        /// oilcolumn property
        /// </summary>
        [XmlEnum("oil column")]
        oilcolumn,
        /// <summary>
        /// Impermeable volume that provides the seal for a hydrostatic fluid column.
        /// </summary>
        seal
    }
    /// <summary>
    /// This class represents the StreamlineFlux xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the StreamlineFlux xsd enumeration.")]
    public enum StreamlineFlux
    {
        /// <summary>
        /// Oil Phase flux
        /// </summary>
        oil,
        /// <summary>
        /// Gas Phase flux
        /// </summary>
        gas,
        /// <summary>
        /// Water Phase flux
        /// </summary>
        water,
        /// <summary>
        /// Sum of (Water + Oil + Gas) Phase fluxes
        /// </summary>
        total,
        /// <summary>
        /// Used to indicate that another flux is being traced. BUSINESS RULE: OtherFlux should appear if this value is specified.
        /// </summary>
        other
    }
    /// <summary>
    /// This class represents the VerticalDirection xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VerticalDirection xsd enumeration.")]
    public enum VerticalDirection
    {
        /// <summary>
        /// up property
        /// </summary>
        up,
        /// <summary>
        /// down property
        /// </summary>
        down
    }
    /// <summary>
    /// This class represents the LogarithmicPowerRatioUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LogarithmicPowerRatioUom xsd enumeration.")]
    public enum LogarithmicPowerRatioUom
    {
        /// <summary>
        /// B property
        /// </summary>
        B,
        /// <summary>
        /// dB property
        /// </summary>
        dB
    }
    /// <summary>
    /// This class represents the AmountOfSubstancePerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AmountOfSubstancePerTimeUom xsd enumeration.")]
    public enum AmountOfSubstancePerTimeUom
    {
        /// <summary>
        /// kat property
        /// </summary>
        kat,
        /// <summary>
        /// kmolh property
        /// </summary>
        [XmlEnum("kmol/h")]
        kmolh,
        /// <summary>
        /// kmols property
        /// </summary>
        [XmlEnum("kmol/s")]
        kmols,
        /// <summary>
        /// lbmolh property
        /// </summary>
        [XmlEnum("lbmol/h")]
        lbmolh,
        /// <summary>
        /// lbmols property
        /// </summary>
        [XmlEnum("lbmol/s")]
        lbmols,
        /// <summary>
        /// mols property
        /// </summary>
        [XmlEnum("mol/s")]
        mols
    }
    /// <summary>
    /// This class represents the ElectricConductivityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricConductivityUom xsd enumeration.")]
    public enum ElectricConductivityUom
    {
        /// <summary>
        /// kSm property
        /// </summary>
        [XmlEnum("kS/m")]
        kSm,
        /// <summary>
        /// mScm property
        /// </summary>
        [XmlEnum("mS/cm")]
        mScm,
        /// <summary>
        /// mSm property
        /// </summary>
        [XmlEnum("mS/m")]
        mSm,
        /// <summary>
        /// Sm property
        /// </summary>
        [XmlEnum("S/m")]
        Sm
    }
    /// <summary>
    /// This class represents the VolumePerRotationUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerRotationUom xsd enumeration.")]
    public enum VolumePerRotationUom
    {
        /// <summary>
        /// ft3rad property
        /// </summary>
        [XmlEnum("ft3/rad")]
        ft3rad,
        /// <summary>
        /// m3rad property
        /// </summary>
        [XmlEnum("m3/rad")]
        m3rad,
        /// <summary>
        /// m3rev property
        /// </summary>
        [XmlEnum("m3/rev")]
        m3rev
    }
    /// <summary>
    /// This class represents the DiffusiveTimeOfFlightUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the DiffusiveTimeOfFlightUom xsd enumeration.")]
    public enum DiffusiveTimeOfFlightUom
    {
        /// <summary>
        /// h05 property
        /// </summary>
        [XmlEnum("h(0.5)")]
        h05,
        /// <summary>
        /// s05 property
        /// </summary>
        [XmlEnum("s(0.5)")]
        s05
    }
    /// <summary>
    /// This class represents the VolumePerTimePerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerTimePerAreaUom xsd enumeration.")]
    public enum VolumePerTimePerAreaUom
    {
        /// <summary>
        /// ft3minft2 property
        /// </summary>
        [XmlEnum("ft3/(min.ft2)")]
        ft3minft2,
        /// <summary>
        /// ft3sft2 property
        /// </summary>
        [XmlEnum("ft3/(s.ft2)")]
        ft3sft2,
        /// <summary>
        /// galUKhft2 property
        /// </summary>
        [XmlEnum("gal[UK]/(h.ft2)")]
        galUKhft2,
        /// <summary>
        /// galUKhin2 property
        /// </summary>
        [XmlEnum("gal[UK]/(h.in2)")]
        galUKhin2,
        /// <summary>
        /// galUKminft2 property
        /// </summary>
        [XmlEnum("gal[UK]/(min.ft2)")]
        galUKminft2,
        /// <summary>
        /// galUShft2 property
        /// </summary>
        [XmlEnum("gal[US]/(h.ft2)")]
        galUShft2,
        /// <summary>
        /// galUShin2 property
        /// </summary>
        [XmlEnum("gal[US]/(h.in2)")]
        galUShin2,
        /// <summary>
        /// galUSminft2 property
        /// </summary>
        [XmlEnum("gal[US]/(min.ft2)")]
        galUSminft2,
        /// <summary>
        /// m3sm2 property
        /// </summary>
        [XmlEnum("m3/(s.m2)")]
        m3sm2
    }
    /// <summary>
    /// This class represents the MobilityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MobilityUom xsd enumeration.")]
    public enum MobilityUom
    {
        /// <summary>
        /// DPas property
        /// </summary>
        [XmlEnum("D/(Pa.s)")]
        DPas,
        /// <summary>
        /// DcP property
        /// </summary>
        [XmlEnum("D/cP")]
        DcP,
        /// <summary>
        /// mDft2lbfs property
        /// </summary>
        [XmlEnum("mD.ft2/(lbf.s)")]
        mDft2lbfs,
        /// <summary>
        /// mDin2lbfs property
        /// </summary>
        [XmlEnum("mD.in2/(lbf.s)")]
        mDin2lbfs,
        /// <summary>
        /// mDPas property
        /// </summary>
        [XmlEnum("mD/(Pa.s)")]
        mDPas,
        /// <summary>
        /// mDcP property
        /// </summary>
        [XmlEnum("mD/cP")]
        mDcP,
        /// <summary>
        /// TDAPIPas property
        /// </summary>
        [XmlEnum("TD[API]/(Pa.s)")]
        TDAPIPas
    }
    /// <summary>
    /// This class represents the HeatTransferCoefficientUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the HeatTransferCoefficientUom xsd enumeration.")]
    public enum HeatTransferCoefficientUom
    {
        /// <summary>
        /// BtuIThft2deltaF property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft2.deltaF)")]
        BtuIThft2deltaF,
        /// <summary>
        /// BtuIThft2deltaR property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft2.deltaR)")]
        BtuIThft2deltaR,
        /// <summary>
        /// BtuIThm2deltaC property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.m2.deltaC)")]
        BtuIThm2deltaC,
        /// <summary>
        /// BtuITsft2deltaF property
        /// </summary>
        [XmlEnum("Btu[IT]/(s.ft2.deltaF)")]
        BtuITsft2deltaF,
        /// <summary>
        /// calthhcm2deltaC property
        /// </summary>
        [XmlEnum("cal[th]/(h.cm2.deltaC)")]
        calthhcm2deltaC,
        /// <summary>
        /// calthscm2deltaC property
        /// </summary>
        [XmlEnum("cal[th]/(s.cm2.deltaC)")]
        calthscm2deltaC,
        /// <summary>
        /// Jsm2deltaC property
        /// </summary>
        [XmlEnum("J/(s.m2.deltaC)")]
        Jsm2deltaC,
        /// <summary>
        /// kcalthhm2deltaC property
        /// </summary>
        [XmlEnum("kcal[th]/(h.m2.deltaC)")]
        kcalthhm2deltaC,
        /// <summary>
        /// kJhm2deltaK property
        /// </summary>
        [XmlEnum("kJ/(h.m2.deltaK)")]
        kJhm2deltaK,
        /// <summary>
        /// kWm2deltaK property
        /// </summary>
        [XmlEnum("kW/(m2.deltaK)")]
        kWm2deltaK,
        /// <summary>
        /// Wm2deltaK property
        /// </summary>
        [XmlEnum("W/(m2.deltaK)")]
        Wm2deltaK
    }
    /// <summary>
    /// This class represents the MassPerEnergyUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerEnergyUom xsd enumeration.")]
    public enum MassPerEnergyUom
    {
        /// <summary>
        /// kgkWh property
        /// </summary>
        [XmlEnum("kg/(kW.h)")]
        kgkWh,
        /// <summary>
        /// kgJ property
        /// </summary>
        [XmlEnum("kg/J")]
        kgJ,
        /// <summary>
        /// kgMJ property
        /// </summary>
        [XmlEnum("kg/MJ")]
        kgMJ,
        /// <summary>
        /// lbmhph property
        /// </summary>
        [XmlEnum("lbm/(hp.h)")]
        lbmhph,
        /// <summary>
        /// mgJ property
        /// </summary>
        [XmlEnum("mg/J")]
        mgJ
    }
    /// <summary>
    /// This class represents the MomentOfInertiaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MomentOfInertiaUom xsd enumeration.")]
    public enum MomentOfInertiaUom
    {
        /// <summary>
        /// kgm2 property
        /// </summary>
        [XmlEnum("kg.m2")]
        kgm2,
        /// <summary>
        /// lbmft2 property
        /// </summary>
        [XmlEnum("lbm.ft2")]
        lbmft2
    }
    /// <summary>
    /// This class represents the CapacitanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the CapacitanceUom xsd enumeration.")]
    public enum CapacitanceUom
    {
        /// <summary>
        /// cF property
        /// </summary>
        cF,
        /// <summary>
        /// dF property
        /// </summary>
        dF,
        /// <summary>
        /// EF property
        /// </summary>
        EF,
        /// <summary>
        /// F property
        /// </summary>
        F,
        /// <summary>
        /// fF property
        /// </summary>
        fF,
        /// <summary>
        /// GF property
        /// </summary>
        GF,
        /// <summary>
        /// kF property
        /// </summary>
        kF,
        /// <summary>
        /// mF property
        /// </summary>
        mF,
        /// <summary>
        /// MF property
        /// </summary>
        MF,
        /// <summary>
        /// nF property
        /// </summary>
        nF,
        /// <summary>
        /// pF property
        /// </summary>
        pF,
        /// <summary>
        /// TF property
        /// </summary>
        TF,
        /// <summary>
        /// uF property
        /// </summary>
        uF
    }
    /// <summary>
    /// This class represents the MagneticFluxDensityPerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MagneticFluxDensityPerLengthUom xsd enumeration.")]
    public enum MagneticFluxDensityPerLengthUom
    {
        /// <summary>
        /// gausscm property
        /// </summary>
        [XmlEnum("gauss/cm")]
        gausscm,
        /// <summary>
        /// mTdm property
        /// </summary>
        [XmlEnum("mT/dm")]
        mTdm,
        /// <summary>
        /// Tm property
        /// </summary>
        [XmlEnum("T/m")]
        Tm
    }
    /// <summary>
    /// This class represents the LengthPerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LengthPerVolumeUom xsd enumeration.")]
    public enum LengthPerVolumeUom
    {
        /// <summary>
        /// ftbbl property
        /// </summary>
        [XmlEnum("ft/bbl")]
        ftbbl,
        /// <summary>
        /// ftft3 property
        /// </summary>
        [XmlEnum("ft/ft3")]
        ftft3,
        /// <summary>
        /// ftgalUS property
        /// </summary>
        [XmlEnum("ft/gal[US]")]
        ftgalUS,
        /// <summary>
        /// kmdm3 property
        /// </summary>
        [XmlEnum("km/dm3")]
        kmdm3,
        /// <summary>
        /// kmL property
        /// </summary>
        [XmlEnum("km/L")]
        kmL,
        /// <summary>
        /// mm3 property
        /// </summary>
        [XmlEnum("m/m3")]
        mm3,
        /// <summary>
        /// migalUK property
        /// </summary>
        [XmlEnum("mi/gal[UK]")]
        migalUK,
        /// <summary>
        /// migalUS property
        /// </summary>
        [XmlEnum("mi/gal[US]")]
        migalUS
    }
    /// <summary>
    /// This class represents the CationExchangeCapacityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the CationExchangeCapacityUom xsd enumeration.")]
    public enum CationExchangeCapacityUom
    {
        /// <summary>
        /// Item01meqg property
        /// </summary>
        [XmlEnum(".01 meq/g")]
        Item01meqg
    }
    /// <summary>
    /// This class represents the MassPerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerTimeUom xsd enumeration.")]
    public enum MassPerTimeUom
    {
        /// <summary>
        /// Item1E6lbma property
        /// </summary>
        [XmlEnum("1E6 lbm/a")]
        Item1E6lbma,
        /// <summary>
        /// gs property
        /// </summary>
        [XmlEnum("g/s")]
        gs,
        /// <summary>
        /// kgd property
        /// </summary>
        [XmlEnum("kg/d")]
        kgd,
        /// <summary>
        /// kgh property
        /// </summary>
        [XmlEnum("kg/h")]
        kgh,
        /// <summary>
        /// kgmin property
        /// </summary>
        [XmlEnum("kg/min")]
        kgmin,
        /// <summary>
        /// kgs property
        /// </summary>
        [XmlEnum("kg/s")]
        kgs,
        /// <summary>
        /// lbmd property
        /// </summary>
        [XmlEnum("lbm/d")]
        lbmd,
        /// <summary>
        /// lbmh property
        /// </summary>
        [XmlEnum("lbm/h")]
        lbmh,
        /// <summary>
        /// lbmmin property
        /// </summary>
        [XmlEnum("lbm/min")]
        lbmmin,
        /// <summary>
        /// lbms property
        /// </summary>
        [XmlEnum("lbm/s")]
        lbms,
        /// <summary>
        /// Mga property
        /// </summary>
        [XmlEnum("Mg/a")]
        Mga,
        /// <summary>
        /// Mgd property
        /// </summary>
        [XmlEnum("Mg/d")]
        Mgd,
        /// <summary>
        /// Mgh property
        /// </summary>
        [XmlEnum("Mg/h")]
        Mgh,
        /// <summary>
        /// Mgmin property
        /// </summary>
        [XmlEnum("Mg/min")]
        Mgmin,
        /// <summary>
        /// ta property
        /// </summary>
        [XmlEnum("t/a")]
        ta,
        /// <summary>
        /// td property
        /// </summary>
        [XmlEnum("t/d")]
        td,
        /// <summary>
        /// th property
        /// </summary>
        [XmlEnum("t/h")]
        th,
        /// <summary>
        /// tmin property
        /// </summary>
        [XmlEnum("t/min")]
        tmin,
        /// <summary>
        /// tonUKa property
        /// </summary>
        [XmlEnum("ton[UK]/a")]
        tonUKa,
        /// <summary>
        /// tonUKd property
        /// </summary>
        [XmlEnum("ton[UK]/d")]
        tonUKd,
        /// <summary>
        /// tonUKh property
        /// </summary>
        [XmlEnum("ton[UK]/h")]
        tonUKh,
        /// <summary>
        /// tonUKmin property
        /// </summary>
        [XmlEnum("ton[UK]/min")]
        tonUKmin,
        /// <summary>
        /// tonUSa property
        /// </summary>
        [XmlEnum("ton[US]/a")]
        tonUSa,
        /// <summary>
        /// tonUSd property
        /// </summary>
        [XmlEnum("ton[US]/d")]
        tonUSd,
        /// <summary>
        /// tonUSh property
        /// </summary>
        [XmlEnum("ton[US]/h")]
        tonUSh,
        /// <summary>
        /// tonUSmin property
        /// </summary>
        [XmlEnum("ton[US]/min")]
        tonUSmin
    }
    /// <summary>
    /// This class represents the MolecularWeightUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MolecularWeightUom xsd enumeration.")]
    public enum MolecularWeightUom
    {
        /// <summary>
        /// gmol property
        /// </summary>
        [XmlEnum("g/mol")]
        gmol,
        /// <summary>
        /// kgmol property
        /// </summary>
        [XmlEnum("kg/mol")]
        kgmol,
        /// <summary>
        /// lbmlbmol property
        /// </summary>
        [XmlEnum("lbm/lbmol")]
        lbmlbmol
    }
    /// <summary>
    /// This class represents the MagneticFluxUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MagneticFluxUom xsd enumeration.")]
    public enum MagneticFluxUom
    {
        /// <summary>
        /// cWb property
        /// </summary>
        cWb,
        /// <summary>
        /// dWb property
        /// </summary>
        dWb,
        /// <summary>
        /// EWb property
        /// </summary>
        EWb,
        /// <summary>
        /// fWb property
        /// </summary>
        fWb,
        /// <summary>
        /// GWb property
        /// </summary>
        GWb,
        /// <summary>
        /// kWb property
        /// </summary>
        kWb,
        /// <summary>
        /// mWb property
        /// </summary>
        mWb,
        /// <summary>
        /// MWb property
        /// </summary>
        MWb,
        /// <summary>
        /// nWb property
        /// </summary>
        nWb,
        /// <summary>
        /// pWb property
        /// </summary>
        pWb,
        /// <summary>
        /// TWb property
        /// </summary>
        TWb,
        /// <summary>
        /// uWb property
        /// </summary>
        uWb,
        /// <summary>
        /// Wb property
        /// </summary>
        Wb
    }
    /// <summary>
    /// This class represents the ThermalConductanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ThermalConductanceUom xsd enumeration.")]
    public enum ThermalConductanceUom
    {
        /// <summary>
        /// WdeltaK property
        /// </summary>
        [XmlEnum("W/deltaK")]
        WdeltaK
    }
    /// <summary>
    /// This class represents the MassPerVolumePerTemperatureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerVolumePerTemperatureUom xsd enumeration.")]
    public enum MassPerVolumePerTemperatureUom
    {
        /// <summary>
        /// kgm3degC property
        /// </summary>
        [XmlEnum("kg/m3.degC")]
        kgm3degC,
        /// <summary>
        /// kgm3K property
        /// </summary>
        [XmlEnum("kg/m3.K")]
        kgm3K,
        /// <summary>
        /// lbftdegF property
        /// </summary>
        [XmlEnum("lb/ft.degF")]
        lbftdegF
    }
    /// <summary>
    /// This class represents the QuantityOfLightUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the QuantityOfLightUom xsd enumeration.")]
    public enum QuantityOfLightUom
    {
        /// <summary>
        /// lms property
        /// </summary>
        [XmlEnum("lm.s")]
        lms
    }
    /// <summary>
    /// This class represents the LengthPerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LengthPerTimeUom xsd enumeration.")]
    public enum LengthPerTimeUom
    {
        /// <summary>
        /// Item1000fth property
        /// </summary>
        [XmlEnum("1000 ft/h")]
        Item1000fth,
        /// <summary>
        /// Item1000fts property
        /// </summary>
        [XmlEnum("1000 ft/s")]
        Item1000fts,
        /// <summary>
        /// cma property
        /// </summary>
        [XmlEnum("cm/a")]
        cma,
        /// <summary>
        /// cms property
        /// </summary>
        [XmlEnum("cm/s")]
        cms,
        /// <summary>
        /// dms property
        /// </summary>
        [XmlEnum("dm/s")]
        dms,
        /// <summary>
        /// ftd property
        /// </summary>
        [XmlEnum("ft/d")]
        ftd,
        /// <summary>
        /// fth property
        /// </summary>
        [XmlEnum("ft/h")]
        fth,
        /// <summary>
        /// ftmin property
        /// </summary>
        [XmlEnum("ft/min")]
        ftmin,
        /// <summary>
        /// ftms property
        /// </summary>
        [XmlEnum("ft/ms")]
        ftms,
        /// <summary>
        /// fts property
        /// </summary>
        [XmlEnum("ft/s")]
        fts,
        /// <summary>
        /// ftus property
        /// </summary>
        [XmlEnum("ft/us")]
        ftus,
        /// <summary>
        /// ina property
        /// </summary>
        [XmlEnum("in/a")]
        ina,
        /// <summary>
        /// inmin property
        /// </summary>
        [XmlEnum("in/min")]
        inmin,
        /// <summary>
        /// ins property
        /// </summary>
        [XmlEnum("in/s")]
        ins,
        /// <summary>
        /// kmh property
        /// </summary>
        [XmlEnum("km/h")]
        kmh,
        /// <summary>
        /// kms property
        /// </summary>
        [XmlEnum("km/s")]
        kms,
        /// <summary>
        /// knot property
        /// </summary>
        knot,
        /// <summary>
        /// md property
        /// </summary>
        [XmlEnum("m/d")]
        md,
        /// <summary>
        /// mh property
        /// </summary>
        [XmlEnum("m/h")]
        mh,
        /// <summary>
        /// mmin property
        /// </summary>
        [XmlEnum("m/min")]
        mmin,
        /// <summary>
        /// mms property
        /// </summary>
        [XmlEnum("m/ms")]
        mms,
        /// <summary>
        /// ms property
        /// </summary>
        [XmlEnum("m/s")]
        ms,
        /// <summary>
        /// mih property
        /// </summary>
        [XmlEnum("mi/h")]
        mih,
        /// <summary>
        /// mila property
        /// </summary>
        [XmlEnum("mil/a")]
        mila,
        /// <summary>
        /// mma property
        /// </summary>
        [XmlEnum("mm/a")]
        mma,
        /// <summary>
        /// mms1 property
        /// </summary>
        [XmlEnum("mm/s")]
        mms1,
        /// <summary>
        /// nms property
        /// </summary>
        [XmlEnum("nm/s")]
        nms,
        /// <summary>
        /// ums property
        /// </summary>
        [XmlEnum("um/s")]
        ums
    }
    /// <summary>
    /// This class represents the ForceLengthPerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ForceLengthPerLengthUom xsd enumeration.")]
    public enum ForceLengthPerLengthUom
    {
        /// <summary>
        /// kgfmm property
        /// </summary>
        [XmlEnum("kgf.m/m")]
        kgfmm,
        /// <summary>
        /// lbfftin property
        /// </summary>
        [XmlEnum("lbf.ft/in")]
        lbfftin,
        /// <summary>
        /// lbfinin property
        /// </summary>
        [XmlEnum("lbf.in/in")]
        lbfinin,
        /// <summary>
        /// Nmm property
        /// </summary>
        [XmlEnum("N.m/m")]
        Nmm,
        /// <summary>
        /// tonfUSmift property
        /// </summary>
        [XmlEnum("tonf[US].mi/ft")]
        tonfUSmift
    }
    /// <summary>
    /// This class represents the SolidAngleUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the SolidAngleUom xsd enumeration.")]
    public enum SolidAngleUom
    {
        /// <summary>
        /// sr property
        /// </summary>
        sr
    }
    /// <summary>
    /// This class represents the MassPerVolumePerPressureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerVolumePerPressureUom xsd enumeration.")]
    public enum MassPerVolumePerPressureUom
    {
        /// <summary>
        /// kgm3kPa property
        /// </summary>
        [XmlEnum("kg/m3.kPa")]
        kgm3kPa,
        /// <summary>
        /// lbftpsi property
        /// </summary>
        [XmlEnum("lb/ft.psi")]
        lbftpsi
    }
    /// <summary>
    /// This class represents the VolumePerTimePerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerTimePerVolumeUom xsd enumeration.")]
    public enum VolumePerTimePerVolumeUom
    {
        /// <summary>
        /// bbldacreft property
        /// </summary>
        [XmlEnum("bbl/(d.acre.ft)")]
        bbldacreft,
        /// <summary>
        /// m3sm3 property
        /// </summary>
        [XmlEnum("m3/(s.m3)")]
        m3sm3
    }
    /// <summary>
    /// This class represents the MomentOfForceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MomentOfForceUom xsd enumeration.")]
    public enum MomentOfForceUom
    {
        /// <summary>
        /// Item1000lbfft property
        /// </summary>
        [XmlEnum("1000 lbf.ft")]
        Item1000lbfft,
        /// <summary>
        /// daNm property
        /// </summary>
        [XmlEnum("daN.m")]
        daNm,
        /// <summary>
        /// dNm property
        /// </summary>
        [XmlEnum("dN.m")]
        dNm,
        /// <summary>
        /// J property
        /// </summary>
        J,
        /// <summary>
        /// kgfm property
        /// </summary>
        [XmlEnum("kgf.m")]
        kgfm,
        /// <summary>
        /// kNm property
        /// </summary>
        [XmlEnum("kN.m")]
        kNm,
        /// <summary>
        /// lbfft property
        /// </summary>
        [XmlEnum("lbf.ft")]
        lbfft,
        /// <summary>
        /// lbfin property
        /// </summary>
        [XmlEnum("lbf.in")]
        lbfin,
        /// <summary>
        /// lbmft2s2 property
        /// </summary>
        [XmlEnum("lbm.ft2/s2")]
        lbmft2s2,
        /// <summary>
        /// Nm property
        /// </summary>
        [XmlEnum("N.m")]
        Nm,
        /// <summary>
        /// pdlft property
        /// </summary>
        [XmlEnum("pdl.ft")]
        pdlft,
        /// <summary>
        /// tonfUSft property
        /// </summary>
        [XmlEnum("tonf[US].ft")]
        tonfUSft,
        /// <summary>
        /// tonfUSmi property
        /// </summary>
        [XmlEnum("tonf[US].mi")]
        tonfUSmi
    }
    /// <summary>
    /// This class represents the MassPerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerVolumeUom xsd enumeration.")]
    public enum MassPerVolumeUom
    {
        /// <summary>
        /// Item0001lbmbbl property
        /// </summary>
        [XmlEnum("0.001 lbm/bbl")]
        Item0001lbmbbl,
        /// <summary>
        /// Item0001lbmgalUK property
        /// </summary>
        [XmlEnum("0.001 lbm/gal[UK]")]
        Item0001lbmgalUK,
        /// <summary>
        /// Item0001lbmgalUS property
        /// </summary>
        [XmlEnum("0.001 lbm/gal[US]")]
        Item0001lbmgalUS,
        /// <summary>
        /// Item001grainft3 property
        /// </summary>
        [XmlEnum("0.01 grain/ft3")]
        Item001grainft3,
        /// <summary>
        /// Item01lbmbbl property
        /// </summary>
        [XmlEnum("0.1 lbm/bbl")]
        Item01lbmbbl,
        /// <summary>
        /// Item10Mgm3 property
        /// </summary>
        [XmlEnum("10 Mg/m3")]
        Item10Mgm3,
        /// <summary>
        /// gcm3 property
        /// </summary>
        [XmlEnum("g/cm3")]
        gcm3,
        /// <summary>
        /// gdm3 property
        /// </summary>
        [XmlEnum("g/dm3")]
        gdm3,
        /// <summary>
        /// ggalUK property
        /// </summary>
        [XmlEnum("g/gal[UK]")]
        ggalUK,
        /// <summary>
        /// ggalUS property
        /// </summary>
        [XmlEnum("g/gal[US]")]
        ggalUS,
        /// <summary>
        /// gL property
        /// </summary>
        [XmlEnum("g/L")]
        gL,
        /// <summary>
        /// gm3 property
        /// </summary>
        [XmlEnum("g/m3")]
        gm3,
        /// <summary>
        /// grainft3 property
        /// </summary>
        [XmlEnum("grain/ft3")]
        grainft3,
        /// <summary>
        /// graingalUS property
        /// </summary>
        [XmlEnum("grain/gal[US]")]
        graingalUS,
        /// <summary>
        /// kgdm3 property
        /// </summary>
        [XmlEnum("kg/dm3")]
        kgdm3,
        /// <summary>
        /// kgL property
        /// </summary>
        [XmlEnum("kg/L")]
        kgL,
        /// <summary>
        /// kgm3 property
        /// </summary>
        [XmlEnum("kg/m3")]
        kgm3,
        /// <summary>
        /// lbmbbl property
        /// </summary>
        [XmlEnum("lbm/bbl")]
        lbmbbl,
        /// <summary>
        /// lbmft3 property
        /// </summary>
        [XmlEnum("lbm/ft3")]
        lbmft3,
        /// <summary>
        /// lbmgalUK property
        /// </summary>
        [XmlEnum("lbm/gal[UK]")]
        lbmgalUK,
        /// <summary>
        /// lbmgalUS property
        /// </summary>
        [XmlEnum("lbm/gal[US]")]
        lbmgalUS,
        /// <summary>
        /// lbmin3 property
        /// </summary>
        [XmlEnum("lbm/in3")]
        lbmin3,
        /// <summary>
        /// mgdm3 property
        /// </summary>
        [XmlEnum("mg/dm3")]
        mgdm3,
        /// <summary>
        /// mggalUS property
        /// </summary>
        [XmlEnum("mg/gal[US]")]
        mggalUS,
        /// <summary>
        /// mgL property
        /// </summary>
        [XmlEnum("mg/L")]
        mgL,
        /// <summary>
        /// mgm3 property
        /// </summary>
        [XmlEnum("mg/m3")]
        mgm3,
        /// <summary>
        /// Mgm3 property
        /// </summary>
        [XmlEnum("Mg/m3")]
        Mgm3,
        /// <summary>
        /// tm3 property
        /// </summary>
        [XmlEnum("t/m3")]
        tm3,
        /// <summary>
        /// ugcm3 property
        /// </summary>
        [XmlEnum("ug/cm3")]
        ugcm3
    }
    /// <summary>
    /// This class represents the MolarVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MolarVolumeUom xsd enumeration.")]
    public enum MolarVolumeUom
    {
        /// <summary>
        /// dm3kmol property
        /// </summary>
        [XmlEnum("dm3/kmol")]
        dm3kmol,
        /// <summary>
        /// ft3lbmol property
        /// </summary>
        [XmlEnum("ft3/lbmol")]
        ft3lbmol,
        /// <summary>
        /// Lkmol property
        /// </summary>
        [XmlEnum("L/kmol")]
        Lkmol,
        /// <summary>
        /// Lmol property
        /// </summary>
        [XmlEnum("L/mol")]
        Lmol,
        /// <summary>
        /// m3kmol property
        /// </summary>
        [XmlEnum("m3/kmol")]
        m3kmol,
        /// <summary>
        /// m3mol property
        /// </summary>
        [XmlEnum("m3/mol")]
        m3mol
    }
    /// <summary>
    /// This class represents the AmountOfSubstanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AmountOfSubstanceUom xsd enumeration.")]
    public enum AmountOfSubstanceUom
    {
        /// <summary>
        /// kmol property
        /// </summary>
        kmol,
        /// <summary>
        /// lbmol property
        /// </summary>
        lbmol,
        /// <summary>
        /// mmol property
        /// </summary>
        mmol,
        /// <summary>
        /// mol property
        /// </summary>
        mol,
        /// <summary>
        /// umol property
        /// </summary>
        umol
    }
    /// <summary>
    /// This class represents the DipoleMomentUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the DipoleMomentUom xsd enumeration.")]
    public enum DipoleMomentUom
    {
        /// <summary>
        /// Cm property
        /// </summary>
        [XmlEnum("C.m")]
        Cm
    }
    /// <summary>
    /// This class represents the APINeutronUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the APINeutronUom xsd enumeration.")]
    public enum APINeutronUom
    {
        /// <summary>
        /// nAPI property
        /// </summary>
        nAPI
    }
    /// <summary>
    /// This class represents the ReciprocalTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReciprocalTimeUom xsd enumeration.")]
    public enum ReciprocalTimeUom
    {
        /// <summary>
        /// Item1a property
        /// </summary>
        [XmlEnum("1/a")]
        Item1a,
        /// <summary>
        /// Item1d property
        /// </summary>
        [XmlEnum("1/d")]
        Item1d,
        /// <summary>
        /// Item1h property
        /// </summary>
        [XmlEnum("1/h")]
        Item1h,
        /// <summary>
        /// Item1min property
        /// </summary>
        [XmlEnum("1/min")]
        Item1min,
        /// <summary>
        /// Item1ms property
        /// </summary>
        [XmlEnum("1/ms")]
        Item1ms,
        /// <summary>
        /// Item1s property
        /// </summary>
        [XmlEnum("1/s")]
        Item1s,
        /// <summary>
        /// Item1us property
        /// </summary>
        [XmlEnum("1/us")]
        Item1us,
        /// <summary>
        /// Item1wk property
        /// </summary>
        [XmlEnum("1/wk")]
        Item1wk
    }
    /// <summary>
    /// This class represents the TemperatureIntervalPerPressureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the TemperatureIntervalPerPressureUom xsd enumeration.")]
    public enum TemperatureIntervalPerPressureUom
    {
        /// <summary>
        /// deltaCkPa property
        /// </summary>
        [XmlEnum("deltaC/kPa")]
        deltaCkPa,
        /// <summary>
        /// deltaFpsi property
        /// </summary>
        [XmlEnum("deltaF/psi")]
        deltaFpsi,
        /// <summary>
        /// deltaKPa property
        /// </summary>
        [XmlEnum("deltaK/Pa")]
        deltaKPa
    }
    /// <summary>
    /// This class represents the LengthPerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LengthPerLengthUom xsd enumeration.")]
    public enum LengthPerLengthUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// Item001ftft property
        /// </summary>
        [XmlEnum("0.01 ft/ft")]
        Item001ftft,
        /// <summary>
        /// Item130mm property
        /// </summary>
        [XmlEnum("1/30 m/m")]
        Item130mm,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// ftft property
        /// </summary>
        [XmlEnum("ft/ft")]
        ftft,
        /// <summary>
        /// ftin property
        /// </summary>
        [XmlEnum("ft/in")]
        ftin,
        /// <summary>
        /// ftm property
        /// </summary>
        [XmlEnum("ft/m")]
        ftm,
        /// <summary>
        /// ftmi property
        /// </summary>
        [XmlEnum("ft/mi")]
        ftmi,
        /// <summary>
        /// kmcm property
        /// </summary>
        [XmlEnum("km/cm")]
        kmcm,
        /// <summary>
        /// mcm property
        /// </summary>
        [XmlEnum("m/cm")]
        mcm,
        /// <summary>
        /// mkm property
        /// </summary>
        [XmlEnum("m/km")]
        mkm,
        /// <summary>
        /// mm property
        /// </summary>
        [XmlEnum("m/m")]
        mm,
        /// <summary>
        /// miin property
        /// </summary>
        [XmlEnum("mi/in")]
        miin
    }
    /// <summary>
    /// This class represents the AreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AreaUom xsd enumeration.")]
    public enum AreaUom
    {
        /// <summary>
        /// acre property
        /// </summary>
        acre,
        /// <summary>
        /// b property
        /// </summary>
        b,
        /// <summary>
        /// cm2 property
        /// </summary>
        cm2,
        /// <summary>
        /// ft2 property
        /// </summary>
        ft2,
        /// <summary>
        /// ha property
        /// </summary>
        ha,
        /// <summary>
        /// in2 property
        /// </summary>
        in2,
        /// <summary>
        /// km2 property
        /// </summary>
        km2,
        /// <summary>
        /// m2 property
        /// </summary>
        m2,
        /// <summary>
        /// miUS2 property
        /// </summary>
        [XmlEnum("mi[US]2")]
        miUS2,
        /// <summary>
        /// mi2 property
        /// </summary>
        mi2,
        /// <summary>
        /// mm2 property
        /// </summary>
        mm2,
        /// <summary>
        /// section property
        /// </summary>
        section,
        /// <summary>
        /// um2 property
        /// </summary>
        um2,
        /// <summary>
        /// yd2 property
        /// </summary>
        yd2
    }
    /// <summary>
    /// This class represents the APIGammaRayUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the APIGammaRayUom xsd enumeration.")]
    public enum APIGammaRayUom
    {
        /// <summary>
        /// gAPI property
        /// </summary>
        gAPI
    }
    /// <summary>
    /// This class represents the VolumetricThermalExpansionUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumetricThermalExpansionUom xsd enumeration.")]
    public enum VolumetricThermalExpansionUom
    {
        /// <summary>
        /// Item1deltaC property
        /// </summary>
        [XmlEnum("1/deltaC")]
        Item1deltaC,
        /// <summary>
        /// Item1deltaF property
        /// </summary>
        [XmlEnum("1/deltaF")]
        Item1deltaF,
        /// <summary>
        /// Item1deltaK property
        /// </summary>
        [XmlEnum("1/deltaK")]
        Item1deltaK,
        /// <summary>
        /// Item1deltaR property
        /// </summary>
        [XmlEnum("1/deltaR")]
        Item1deltaR,
        /// <summary>
        /// Item1E6m3m3deltaC property
        /// </summary>
        [XmlEnum("1E-6 m3/(m3.deltaC)")]
        Item1E6m3m3deltaC,
        /// <summary>
        /// Item1E6m3m3deltaF property
        /// </summary>
        [XmlEnum("1E-6 m3/(m3.deltaF)")]
        Item1E6m3m3deltaF,
        /// <summary>
        /// m3m3deltaK property
        /// </summary>
        [XmlEnum("m3/(m3.deltaK)")]
        m3m3deltaK,
        /// <summary>
        /// ppmvoldeltaC property
        /// </summary>
        [XmlEnum("ppm[vol]/deltaC")]
        ppmvoldeltaC,
        /// <summary>
        /// ppmvoldeltaF property
        /// </summary>
        [XmlEnum("ppm[vol]/deltaF")]
        ppmvoldeltaF
    }
    /// <summary>
    /// This class represents the ElectricCurrentDensityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricCurrentDensityUom xsd enumeration.")]
    public enum ElectricCurrentDensityUom
    {
        /// <summary>
        /// Acm2 property
        /// </summary>
        [XmlEnum("A/cm2")]
        Acm2,
        /// <summary>
        /// Aft2 property
        /// </summary>
        [XmlEnum("A/ft2")]
        Aft2,
        /// <summary>
        /// Am2 property
        /// </summary>
        [XmlEnum("A/m2")]
        Am2,
        /// <summary>
        /// Amm2 property
        /// </summary>
        [XmlEnum("A/mm2")]
        Amm2,
        /// <summary>
        /// mAcm2 property
        /// </summary>
        [XmlEnum("mA/cm2")]
        mAcm2,
        /// <summary>
        /// mAft2 property
        /// </summary>
        [XmlEnum("mA/ft2")]
        mAft2,
        /// <summary>
        /// uAcm2 property
        /// </summary>
        [XmlEnum("uA/cm2")]
        uAcm2,
        /// <summary>
        /// uAin2 property
        /// </summary>
        [XmlEnum("uA/in2")]
        uAin2
    }
    /// <summary>
    /// This class represents the ForceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ForceUom xsd enumeration.")]
    public enum ForceUom
    {
        /// <summary>
        /// Item10kN property
        /// </summary>
        [XmlEnum("10 kN")]
        Item10kN,
        /// <summary>
        /// cN property
        /// </summary>
        cN,
        /// <summary>
        /// daN property
        /// </summary>
        daN,
        /// <summary>
        /// dN property
        /// </summary>
        dN,
        /// <summary>
        /// dyne property
        /// </summary>
        dyne,
        /// <summary>
        /// EN property
        /// </summary>
        EN,
        /// <summary>
        /// fN property
        /// </summary>
        fN,
        /// <summary>
        /// gf property
        /// </summary>
        gf,
        /// <summary>
        /// GN property
        /// </summary>
        GN,
        /// <summary>
        /// hN property
        /// </summary>
        hN,
        /// <summary>
        /// kdyne property
        /// </summary>
        kdyne,
        /// <summary>
        /// kgf property
        /// </summary>
        kgf,
        /// <summary>
        /// klbf property
        /// </summary>
        klbf,
        /// <summary>
        /// kN property
        /// </summary>
        kN,
        /// <summary>
        /// lbf property
        /// </summary>
        lbf,
        /// <summary>
        /// Mgf property
        /// </summary>
        Mgf,
        /// <summary>
        /// mN property
        /// </summary>
        mN,
        /// <summary>
        /// MN property
        /// </summary>
        MN,
        /// <summary>
        /// N property
        /// </summary>
        N,
        /// <summary>
        /// nN property
        /// </summary>
        nN,
        /// <summary>
        /// ozf property
        /// </summary>
        ozf,
        /// <summary>
        /// pdl property
        /// </summary>
        pdl,
        /// <summary>
        /// pN property
        /// </summary>
        pN,
        /// <summary>
        /// TN property
        /// </summary>
        TN,
        /// <summary>
        /// tonfUK property
        /// </summary>
        [XmlEnum("tonf[UK]")]
        tonfUK,
        /// <summary>
        /// tonfUS property
        /// </summary>
        [XmlEnum("tonf[US]")]
        tonfUS,
        /// <summary>
        /// uN property
        /// </summary>
        uN
    }
    /// <summary>
    /// This class represents the VolumePerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerAreaUom xsd enumeration.")]
    public enum VolumePerAreaUom
    {
        /// <summary>
        /// Item1E6bblacre property
        /// </summary>
        [XmlEnum("1E6 bbl/acre")]
        Item1E6bblacre,
        /// <summary>
        /// bblacre property
        /// </summary>
        [XmlEnum("bbl/acre")]
        bblacre,
        /// <summary>
        /// ft3ft2 property
        /// </summary>
        [XmlEnum("ft3/ft2")]
        ft3ft2,
        /// <summary>
        /// m3m2 property
        /// </summary>
        [XmlEnum("m3/m2")]
        m3m2
    }
    /// <summary>
    /// This class represents the ReciprocalElectricPotentialDifferenceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReciprocalElectricPotentialDifferenceUom xsd enumeration.")]
    public enum ReciprocalElectricPotentialDifferenceUom
    {
        /// <summary>
        /// Item1uV property
        /// </summary>
        [XmlEnum("1/uV")]
        Item1uV,
        /// <summary>
        /// Item1V property
        /// </summary>
        [XmlEnum("1/V")]
        Item1V
    }
    /// <summary>
    /// This class represents the TimePerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the TimePerLengthUom xsd enumeration.")]
    public enum TimePerLengthUom
    {
        /// <summary>
        /// Item0001hft property
        /// </summary>
        [XmlEnum("0.001 h/ft")]
        Item0001hft,
        /// <summary>
        /// hkm property
        /// </summary>
        [XmlEnum("h/km")]
        hkm,
        /// <summary>
        /// minft property
        /// </summary>
        [XmlEnum("min/ft")]
        minft,
        /// <summary>
        /// minm property
        /// </summary>
        [XmlEnum("min/m")]
        minm,
        /// <summary>
        /// mscm property
        /// </summary>
        [XmlEnum("ms/cm")]
        mscm,
        /// <summary>
        /// msft property
        /// </summary>
        [XmlEnum("ms/ft")]
        msft,
        /// <summary>
        /// msin property
        /// </summary>
        [XmlEnum("ms/in")]
        msin,
        /// <summary>
        /// msm property
        /// </summary>
        [XmlEnum("ms/m")]
        msm,
        /// <summary>
        /// nsft property
        /// </summary>
        [XmlEnum("ns/ft")]
        nsft,
        /// <summary>
        /// nsm property
        /// </summary>
        [XmlEnum("ns/m")]
        nsm,
        /// <summary>
        /// scm property
        /// </summary>
        [XmlEnum("s/cm")]
        scm,
        /// <summary>
        /// sft property
        /// </summary>
        [XmlEnum("s/ft")]
        sft,
        /// <summary>
        /// sin property
        /// </summary>
        [XmlEnum("s/in")]
        sin,
        /// <summary>
        /// sm property
        /// </summary>
        [XmlEnum("s/m")]
        sm,
        /// <summary>
        /// usft property
        /// </summary>
        [XmlEnum("us/ft")]
        usft,
        /// <summary>
        /// usin property
        /// </summary>
        [XmlEnum("us/in")]
        usin,
        /// <summary>
        /// usm property
        /// </summary>
        [XmlEnum("us/m")]
        usm
    }
    /// <summary>
    /// This class represents the VolumePerPressureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerPressureUom xsd enumeration.")]
    public enum VolumePerPressureUom
    {
        /// <summary>
        /// bblpsi property
        /// </summary>
        [XmlEnum("bbl/psi")]
        bblpsi,
        /// <summary>
        /// m3kPa property
        /// </summary>
        [XmlEnum("m3/kPa")]
        m3kPa,
        /// <summary>
        /// m3Pa property
        /// </summary>
        [XmlEnum("m3/Pa")]
        m3Pa
    }
    /// <summary>
    /// This class represents the ElectricChargePerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricChargePerAreaUom xsd enumeration.")]
    public enum ElectricChargePerAreaUom
    {
        /// <summary>
        /// Ccm2 property
        /// </summary>
        [XmlEnum("C/cm2")]
        Ccm2,
        /// <summary>
        /// Cm2 property
        /// </summary>
        [XmlEnum("C/m2")]
        Cm2,
        /// <summary>
        /// Cmm2 property
        /// </summary>
        [XmlEnum("C/mm2")]
        Cmm2,
        /// <summary>
        /// mCm2 property
        /// </summary>
        [XmlEnum("mC/m2")]
        mCm2
    }
    /// <summary>
    /// This class represents the MassPerTimePerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerTimePerLengthUom xsd enumeration.")]
    public enum MassPerTimePerLengthUom
    {
        /// <summary>
        /// kgms property
        /// </summary>
        [XmlEnum("kg/(m.s)")]
        kgms,
        /// <summary>
        /// lbmfth property
        /// </summary>
        [XmlEnum("lbm/(ft.h)")]
        lbmfth,
        /// <summary>
        /// lbmfts property
        /// </summary>
        [XmlEnum("lbm/(ft.s)")]
        lbmfts,
        /// <summary>
        /// Pas property
        /// </summary>
        [XmlEnum("Pa.s")]
        Pas
    }
    /// <summary>
    /// This class represents the MagneticFluxDensityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MagneticFluxDensityUom xsd enumeration.")]
    public enum MagneticFluxDensityUom
    {
        /// <summary>
        /// cgauss property
        /// </summary>
        cgauss,
        /// <summary>
        /// cT property
        /// </summary>
        cT,
        /// <summary>
        /// dgauss property
        /// </summary>
        dgauss,
        /// <summary>
        /// dT property
        /// </summary>
        dT,
        /// <summary>
        /// Egauss property
        /// </summary>
        Egauss,
        /// <summary>
        /// ET property
        /// </summary>
        ET,
        /// <summary>
        /// fgauss property
        /// </summary>
        fgauss,
        /// <summary>
        /// fT property
        /// </summary>
        fT,
        /// <summary>
        /// gauss property
        /// </summary>
        gauss,
        /// <summary>
        /// Ggauss property
        /// </summary>
        Ggauss,
        /// <summary>
        /// GT property
        /// </summary>
        GT,
        /// <summary>
        /// kgauss property
        /// </summary>
        kgauss,
        /// <summary>
        /// kT property
        /// </summary>
        kT,
        /// <summary>
        /// mgauss property
        /// </summary>
        mgauss,
        /// <summary>
        /// Mgauss property
        /// </summary>
        Mgauss,
        /// <summary>
        /// mT property
        /// </summary>
        mT,
        /// <summary>
        /// ngauss property
        /// </summary>
        ngauss,
        /// <summary>
        /// nT property
        /// </summary>
        nT,
        /// <summary>
        /// pgauss property
        /// </summary>
        pgauss,
        /// <summary>
        /// pT property
        /// </summary>
        pT,
        /// <summary>
        /// T property
        /// </summary>
        T,
        /// <summary>
        /// Tgauss property
        /// </summary>
        Tgauss,
        /// <summary>
        /// TT property
        /// </summary>
        TT,
        /// <summary>
        /// ugauss property
        /// </summary>
        ugauss,
        /// <summary>
        /// uT property
        /// </summary>
        uT
    }
    /// <summary>
    /// This class represents the SignalingEventPerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the SignalingEventPerTimeUom xsd enumeration.")]
    public enum SignalingEventPerTimeUom
    {
        /// <summary>
        /// Bd property
        /// </summary>
        Bd
    }
    /// <summary>
    /// This class represents the EnergyPerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the EnergyPerLengthUom xsd enumeration.")]
    public enum EnergyPerLengthUom
    {
        /// <summary>
        /// Jm property
        /// </summary>
        [XmlEnum("J/m")]
        Jm,
        /// <summary>
        /// MJm property
        /// </summary>
        [XmlEnum("MJ/m")]
        MJm
    }
    /// <summary>
    /// This class represents the ElectricCurrentUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricCurrentUom xsd enumeration.")]
    public enum ElectricCurrentUom
    {
        /// <summary>
        /// A property
        /// </summary>
        A,
        /// <summary>
        /// cA property
        /// </summary>
        cA,
        /// <summary>
        /// dA property
        /// </summary>
        dA,
        /// <summary>
        /// EA property
        /// </summary>
        EA,
        /// <summary>
        /// fA property
        /// </summary>
        fA,
        /// <summary>
        /// GA property
        /// </summary>
        GA,
        /// <summary>
        /// kA property
        /// </summary>
        kA,
        /// <summary>
        /// MA property
        /// </summary>
        MA,
        /// <summary>
        /// mA property
        /// </summary>
        mA,
        /// <summary>
        /// nA property
        /// </summary>
        nA,
        /// <summary>
        /// pA property
        /// </summary>
        pA,
        /// <summary>
        /// TA property
        /// </summary>
        TA,
        /// <summary>
        /// uA property
        /// </summary>
        uA
    }
    /// <summary>
    /// This class represents the PressureSquaredUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PressureSquaredUom xsd enumeration.")]
    public enum PressureSquaredUom
    {
        /// <summary>
        /// bar2 property
        /// </summary>
        bar2,
        /// <summary>
        /// GPa2 property
        /// </summary>
        GPa2,
        /// <summary>
        /// kPa2 property
        /// </summary>
        kPa2,
        /// <summary>
        /// kpsi2 property
        /// </summary>
        kpsi2,
        /// <summary>
        /// Pa2 property
        /// </summary>
        Pa2,
        /// <summary>
        /// psi2 property
        /// </summary>
        psi2
    }
    /// <summary>
    /// This class represents the AngularAccelerationUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AngularAccelerationUom xsd enumeration.")]
    public enum AngularAccelerationUom
    {
        /// <summary>
        /// rads2 property
        /// </summary>
        [XmlEnum("rad/s2")]
        rads2,
        /// <summary>
        /// rpms property
        /// </summary>
        [XmlEnum("rpm/s")]
        rpms
    }
    /// <summary>
    /// This class represents the ReciprocalMassTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReciprocalMassTimeUom xsd enumeration.")]
    public enum ReciprocalMassTimeUom
    {
        /// <summary>
        /// Item1kgs property
        /// </summary>
        [XmlEnum("1/(kg.s)")]
        Item1kgs,
        /// <summary>
        /// Bqkg property
        /// </summary>
        [XmlEnum("Bq/kg")]
        Bqkg,
        /// <summary>
        /// pCig property
        /// </summary>
        [XmlEnum("pCi/g")]
        pCig
    }
    /// <summary>
    /// This class represents the ThermalDiffusivityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ThermalDiffusivityUom xsd enumeration.")]
    public enum ThermalDiffusivityUom
    {
        /// <summary>
        /// cm2s property
        /// </summary>
        [XmlEnum("cm2/s")]
        cm2s,
        /// <summary>
        /// ft2h property
        /// </summary>
        [XmlEnum("ft2/h")]
        ft2h,
        /// <summary>
        /// ft2s property
        /// </summary>
        [XmlEnum("ft2/s")]
        ft2s,
        /// <summary>
        /// in2s property
        /// </summary>
        [XmlEnum("in2/s")]
        in2s,
        /// <summary>
        /// m2h property
        /// </summary>
        [XmlEnum("m2/h")]
        m2h,
        /// <summary>
        /// m2s property
        /// </summary>
        [XmlEnum("m2/s")]
        m2s,
        /// <summary>
        /// mm2s property
        /// </summary>
        [XmlEnum("mm2/s")]
        mm2s
    }
    /// <summary>
    /// This class represents the VolumePerTimeLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerTimeLengthUom xsd enumeration.")]
    public enum VolumePerTimeLengthUom
    {
        /// <summary>
        /// Item1000bblftd property
        /// </summary>
        [XmlEnum("1000 bbl.ft/d")]
        Item1000bblftd,
        /// <summary>
        /// Item1000m4d property
        /// </summary>
        [XmlEnum("1000 m4/d")]
        Item1000m4d,
        /// <summary>
        /// m4s property
        /// </summary>
        [XmlEnum("m4/s")]
        m4s
    }
    /// <summary>
    /// This class represents the PermeabilityRockUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PermeabilityRockUom xsd enumeration.")]
    public enum PermeabilityRockUom
    {
        /// <summary>
        /// D property
        /// </summary>
        D,
        /// <summary>
        /// DAPI property
        /// </summary>
        [XmlEnum("D[API]")]
        DAPI,
        /// <summary>
        /// mD property
        /// </summary>
        mD,
        /// <summary>
        /// TDAPI property
        /// </summary>
        [XmlEnum("TD[API]")]
        TDAPI
    }
    /// <summary>
    /// This class represents the SecondMomentOfAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the SecondMomentOfAreaUom xsd enumeration.")]
    public enum SecondMomentOfAreaUom
    {
        /// <summary>
        /// cm4 property
        /// </summary>
        cm4,
        /// <summary>
        /// in4 property
        /// </summary>
        in4,
        /// <summary>
        /// m4 property
        /// </summary>
        m4
    }
    /// <summary>
    /// This class represents the ForceAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ForceAreaUom xsd enumeration.")]
    public enum ForceAreaUom
    {
        /// <summary>
        /// dynecm2 property
        /// </summary>
        [XmlEnum("dyne.cm2")]
        dynecm2,
        /// <summary>
        /// kgfm2 property
        /// </summary>
        [XmlEnum("kgf.m2")]
        kgfm2,
        /// <summary>
        /// kNm2 property
        /// </summary>
        [XmlEnum("kN.m2")]
        kNm2,
        /// <summary>
        /// lbfin2 property
        /// </summary>
        [XmlEnum("lbf.in2")]
        lbfin2,
        /// <summary>
        /// mNm2 property
        /// </summary>
        [XmlEnum("mN.m2")]
        mNm2,
        /// <summary>
        /// Nm2 property
        /// </summary>
        [XmlEnum("N.m2")]
        Nm2,
        /// <summary>
        /// pdlcm2 property
        /// </summary>
        [XmlEnum("pdl.cm2")]
        pdlcm2,
        /// <summary>
        /// tonfUKft2 property
        /// </summary>
        [XmlEnum("tonf[UK].ft2")]
        tonfUKft2,
        /// <summary>
        /// tonfUSft2 property
        /// </summary>
        [XmlEnum("tonf[US].ft2")]
        tonfUSft2
    }
    /// <summary>
    /// This class represents the ElectricFieldStrengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricFieldStrengthUom xsd enumeration.")]
    public enum ElectricFieldStrengthUom
    {
        /// <summary>
        /// mVft property
        /// </summary>
        [XmlEnum("mV/ft")]
        mVft,
        /// <summary>
        /// mVm property
        /// </summary>
        [XmlEnum("mV/m")]
        mVm,
        /// <summary>
        /// uVft property
        /// </summary>
        [XmlEnum("uV/ft")]
        uVft,
        /// <summary>
        /// uVm property
        /// </summary>
        [XmlEnum("uV/m")]
        uVm,
        /// <summary>
        /// Vm property
        /// </summary>
        [XmlEnum("V/m")]
        Vm
    }
    /// <summary>
    /// This class represents the AmountOfSubstancePerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AmountOfSubstancePerAreaUom xsd enumeration.")]
    public enum AmountOfSubstancePerAreaUom
    {
        /// <summary>
        /// molm2 property
        /// </summary>
        [XmlEnum("mol/m2")]
        molm2
    }
    /// <summary>
    /// This class represents the TimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the TimeUom xsd enumeration.")]
    public enum TimeUom
    {
        /// <summary>
        /// Item12ms property
        /// </summary>
        [XmlEnum("1/2 ms")]
        Item12ms,
        /// <summary>
        /// Item100kat property
        /// </summary>
        [XmlEnum("100 ka[t]")]
        Item100kat,
        /// <summary>
        /// a property
        /// </summary>
        a,
        /// <summary>
        /// at property
        /// </summary>
        [XmlEnum("a[t]")]
        at,
        /// <summary>
        /// ca property
        /// </summary>
        ca,
        /// <summary>
        /// cs property
        /// </summary>
        cs,
        /// <summary>
        /// d property
        /// </summary>
        d,
        /// <summary>
        /// ds property
        /// </summary>
        ds,
        /// <summary>
        /// Eat property
        /// </summary>
        [XmlEnum("Ea[t]")]
        Eat,
        /// <summary>
        /// fa property
        /// </summary>
        fa,
        /// <summary>
        /// Gat property
        /// </summary>
        [XmlEnum("Ga[t]")]
        Gat,
        /// <summary>
        /// h property
        /// </summary>
        h,
        /// <summary>
        /// hs property
        /// </summary>
        hs,
        /// <summary>
        /// kat property
        /// </summary>
        [XmlEnum("ka[t]")]
        kat,
        /// <summary>
        /// Mat property
        /// </summary>
        [XmlEnum("Ma[t]")]
        Mat,
        /// <summary>
        /// min property
        /// </summary>
        min,
        /// <summary>
        /// ms property
        /// </summary>
        ms,
        /// <summary>
        /// na property
        /// </summary>
        na,
        /// <summary>
        /// ns property
        /// </summary>
        ns,
        /// <summary>
        /// ps property
        /// </summary>
        ps,
        /// <summary>
        /// s property
        /// </summary>
        s,
        /// <summary>
        /// Tat property
        /// </summary>
        [XmlEnum("Ta[t]")]
        Tat,
        /// <summary>
        /// us property
        /// </summary>
        us,
        /// <summary>
        /// wk property
        /// </summary>
        wk
    }
    /// <summary>
    /// This class represents the ThermalConductivityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ThermalConductivityUom xsd enumeration.")]
    public enum ThermalConductivityUom
    {
        /// <summary>
        /// BtuIThftdeltaF property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft.deltaF)")]
        BtuIThftdeltaF,
        /// <summary>
        /// calthhcmdeltaC property
        /// </summary>
        [XmlEnum("cal[th]/(h.cm.deltaC)")]
        calthhcmdeltaC,
        /// <summary>
        /// calthscmdeltaC property
        /// </summary>
        [XmlEnum("cal[th]/(s.cm.deltaC)")]
        calthscmdeltaC,
        /// <summary>
        /// kcalthhmdeltaC property
        /// </summary>
        [XmlEnum("kcal[th]/(h.m.deltaC)")]
        kcalthhmdeltaC,
        /// <summary>
        /// WmdeltaK property
        /// </summary>
        [XmlEnum("W/(m.deltaK)")]
        WmdeltaK
    }
    /// <summary>
    /// This class represents the AreaPerAmountOfSubstanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AreaPerAmountOfSubstanceUom xsd enumeration.")]
    public enum AreaPerAmountOfSubstanceUom
    {
        /// <summary>
        /// m2mol property
        /// </summary>
        [XmlEnum("m2/mol")]
        m2mol
    }
    /// <summary>
    /// This class represents the LogarithmicPowerRatioPerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LogarithmicPowerRatioPerLengthUom xsd enumeration.")]
    public enum LogarithmicPowerRatioPerLengthUom
    {
        /// <summary>
        /// Bm property
        /// </summary>
        [XmlEnum("B/m")]
        Bm,
        /// <summary>
        /// dBft property
        /// </summary>
        [XmlEnum("dB/ft")]
        dBft,
        /// <summary>
        /// dBkm property
        /// </summary>
        [XmlEnum("dB/km")]
        dBkm,
        /// <summary>
        /// dBm property
        /// </summary>
        [XmlEnum("dB/m")]
        dBm
    }
    /// <summary>
    /// This class represents the ReciprocalLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReciprocalLengthUom xsd enumeration.")]
    public enum ReciprocalLengthUom
    {
        /// <summary>
        /// Item1angstrom property
        /// </summary>
        [XmlEnum("1/angstrom")]
        Item1angstrom,
        /// <summary>
        /// Item1cm property
        /// </summary>
        [XmlEnum("1/cm")]
        Item1cm,
        /// <summary>
        /// Item1ft property
        /// </summary>
        [XmlEnum("1/ft")]
        Item1ft,
        /// <summary>
        /// Item1in property
        /// </summary>
        [XmlEnum("1/in")]
        Item1in,
        /// <summary>
        /// Item1m property
        /// </summary>
        [XmlEnum("1/m")]
        Item1m,
        /// <summary>
        /// Item1mi property
        /// </summary>
        [XmlEnum("1/mi")]
        Item1mi,
        /// <summary>
        /// Item1mm property
        /// </summary>
        [XmlEnum("1/mm")]
        Item1mm,
        /// <summary>
        /// Item1nm property
        /// </summary>
        [XmlEnum("1/nm")]
        Item1nm,
        /// <summary>
        /// Item1yd property
        /// </summary>
        [XmlEnum("1/yd")]
        Item1yd,
        /// <summary>
        /// Item1E91ft property
        /// </summary>
        [XmlEnum("1E-9 1/ft")]
        Item1E91ft
    }
    /// <summary>
    /// This class represents the LuminanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LuminanceUom xsd enumeration.")]
    public enum LuminanceUom
    {
        /// <summary>
        /// cdm2 property
        /// </summary>
        [XmlEnum("cd/m2")]
        cdm2
    }
    /// <summary>
    /// This class represents the VolumePerTimePerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerTimePerTimeUom xsd enumeration.")]
    public enum VolumePerTimePerTimeUom
    {
        /// <summary>
        /// bbld2 property
        /// </summary>
        [XmlEnum("bbl/d2")]
        bbld2,
        /// <summary>
        /// bblh2 property
        /// </summary>
        [XmlEnum("bbl/h2")]
        bblh2,
        /// <summary>
        /// dm3s2 property
        /// </summary>
        [XmlEnum("dm3/s2")]
        dm3s2,
        /// <summary>
        /// ft3d2 property
        /// </summary>
        [XmlEnum("ft3/d2")]
        ft3d2,
        /// <summary>
        /// ft3h2 property
        /// </summary>
        [XmlEnum("ft3/h2")]
        ft3h2,
        /// <summary>
        /// ft3min2 property
        /// </summary>
        [XmlEnum("ft3/min2")]
        ft3min2,
        /// <summary>
        /// ft3s2 property
        /// </summary>
        [XmlEnum("ft3/s2")]
        ft3s2,
        /// <summary>
        /// galUKh2 property
        /// </summary>
        [XmlEnum("gal[UK]/h2")]
        galUKh2,
        /// <summary>
        /// galUKmin2 property
        /// </summary>
        [XmlEnum("gal[UK]/min2")]
        galUKmin2,
        /// <summary>
        /// galUSh2 property
        /// </summary>
        [XmlEnum("gal[US]/h2")]
        galUSh2,
        /// <summary>
        /// galUSmin2 property
        /// </summary>
        [XmlEnum("gal[US]/min2")]
        galUSmin2,
        /// <summary>
        /// Ls2 property
        /// </summary>
        [XmlEnum("L/s2")]
        Ls2,
        /// <summary>
        /// m3d2 property
        /// </summary>
        [XmlEnum("m3/d2")]
        m3d2,
        /// <summary>
        /// m3s2 property
        /// </summary>
        [XmlEnum("m3/s2")]
        m3s2
    }
    /// <summary>
    /// This class represents the MolarHeatCapacityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MolarHeatCapacityUom xsd enumeration.")]
    public enum MolarHeatCapacityUom
    {
        /// <summary>
        /// BtuITlbmoldeltaF property
        /// </summary>
        [XmlEnum("Btu[IT]/(lbmol.deltaF)")]
        BtuITlbmoldeltaF,
        /// <summary>
        /// calthmoldeltaC property
        /// </summary>
        [XmlEnum("cal[th]/(mol.deltaC)")]
        calthmoldeltaC,
        /// <summary>
        /// JmoldeltaK property
        /// </summary>
        [XmlEnum("J/(mol.deltaK)")]
        JmoldeltaK,
        /// <summary>
        /// kJkmoldeltaK property
        /// </summary>
        [XmlEnum("kJ/(kmol.deltaK)")]
        kJkmoldeltaK
    }
    /// <summary>
    /// This class represents the VolumeFlowRatePerVolumeFlowRateUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumeFlowRatePerVolumeFlowRateUom xsd enumeration.")]
    public enum VolumeFlowRatePerVolumeFlowRateUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// bbldbbld property
        /// </summary>
        [XmlEnum("(bbl/d)/(bbl/d)")]
        bbldbbld,
        /// <summary>
        /// m3dm3d property
        /// </summary>
        [XmlEnum("(m3/d)/(m3/d)")]
        m3dm3d,
        /// <summary>
        /// m3sm3s property
        /// </summary>
        [XmlEnum("(m3/s)/(m3/s)")]
        m3sm3s,
        /// <summary>
        /// Item1E6ft3dbbld property
        /// </summary>
        [XmlEnum("1E6 (ft3/d)/(bbl/d)")]
        Item1E6ft3dbbld,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc
    }
    /// <summary>
    /// This class represents the FrequencyIntervalUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the FrequencyIntervalUom xsd enumeration.")]
    public enum FrequencyIntervalUom
    {
        /// <summary>
        /// O property
        /// </summary>
        O
    }
    /// <summary>
    /// This class represents the TemperatureIntervalUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the TemperatureIntervalUom xsd enumeration.")]
    public enum TemperatureIntervalUom
    {
        /// <summary>
        /// deltaC property
        /// </summary>
        deltaC,
        /// <summary>
        /// deltaF property
        /// </summary>
        deltaF,
        /// <summary>
        /// deltaK property
        /// </summary>
        deltaK,
        /// <summary>
        /// deltaR property
        /// </summary>
        deltaR
    }
    /// <summary>
    /// This class represents the RadiantIntensityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the RadiantIntensityUom xsd enumeration.")]
    public enum RadiantIntensityUom
    {
        /// <summary>
        /// Wsr property
        /// </summary>
        [XmlEnum("W/sr")]
        Wsr
    }
    /// <summary>
    /// This class represents the PermeabilityLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PermeabilityLengthUom xsd enumeration.")]
    public enum PermeabilityLengthUom
    {
        /// <summary>
        /// Dft property
        /// </summary>
        [XmlEnum("D.ft")]
        Dft,
        /// <summary>
        /// Dm property
        /// </summary>
        [XmlEnum("D.m")]
        Dm,
        /// <summary>
        /// mDft property
        /// </summary>
        [XmlEnum("mD.ft")]
        mDft,
        /// <summary>
        /// mDm property
        /// </summary>
        [XmlEnum("mD.m")]
        mDm,
        /// <summary>
        /// TDAPIm property
        /// </summary>
        [XmlEnum("TD[API].m")]
        TDAPIm
    }
    /// <summary>
    /// This class represents the DataTransferSpeedUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the DataTransferSpeedUom xsd enumeration.")]
    public enum DataTransferSpeedUom
    {
        /// <summary>
        /// bits property
        /// </summary>
        [XmlEnum("bit/s")]
        bits,
        /// <summary>
        /// bytes property
        /// </summary>
        [XmlEnum("byte/s")]
        bytes
    }
    /// <summary>
    /// This class represents the InductanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the InductanceUom xsd enumeration.")]
    public enum InductanceUom
    {
        /// <summary>
        /// cH property
        /// </summary>
        cH,
        /// <summary>
        /// dH property
        /// </summary>
        dH,
        /// <summary>
        /// EH property
        /// </summary>
        EH,
        /// <summary>
        /// fH property
        /// </summary>
        fH,
        /// <summary>
        /// GH property
        /// </summary>
        GH,
        /// <summary>
        /// H property
        /// </summary>
        H,
        /// <summary>
        /// kH property
        /// </summary>
        kH,
        /// <summary>
        /// MH property
        /// </summary>
        MH,
        /// <summary>
        /// mH property
        /// </summary>
        mH,
        /// <summary>
        /// nH property
        /// </summary>
        nH,
        /// <summary>
        /// TH property
        /// </summary>
        TH,
        /// <summary>
        /// uH property
        /// </summary>
        uH
    }
    /// <summary>
    /// This class represents the KinematicViscosityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the KinematicViscosityUom xsd enumeration.")]
    public enum KinematicViscosityUom
    {
        /// <summary>
        /// cm2s property
        /// </summary>
        [XmlEnum("cm2/s")]
        cm2s,
        /// <summary>
        /// cSt property
        /// </summary>
        cSt,
        /// <summary>
        /// ft2h property
        /// </summary>
        [XmlEnum("ft2/h")]
        ft2h,
        /// <summary>
        /// ft2s property
        /// </summary>
        [XmlEnum("ft2/s")]
        ft2s,
        /// <summary>
        /// in2s property
        /// </summary>
        [XmlEnum("in2/s")]
        in2s,
        /// <summary>
        /// m2h property
        /// </summary>
        [XmlEnum("m2/h")]
        m2h,
        /// <summary>
        /// m2s property
        /// </summary>
        [XmlEnum("m2/s")]
        m2s,
        /// <summary>
        /// mm2s property
        /// </summary>
        [XmlEnum("mm2/s")]
        mm2s,
        /// <summary>
        /// Pasm3kg property
        /// </summary>
        [XmlEnum("Pa.s.m3/kg")]
        Pasm3kg,
        /// <summary>
        /// St property
        /// </summary>
        St
    }
    /// <summary>
    /// This class represents the VolumePerTimePerPressureLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerTimePerPressureLengthUom xsd enumeration.")]
    public enum VolumePerTimePerPressureLengthUom
    {
        /// <summary>
        /// bblftpsid property
        /// </summary>
        [XmlEnum("bbl/(ft.psi.d)")]
        bblftpsid,
        /// <summary>
        /// ft3ftpsid property
        /// </summary>
        [XmlEnum("ft3/(ft.psi.d)")]
        ft3ftpsid,
        /// <summary>
        /// m2kPad property
        /// </summary>
        [XmlEnum("m2/(kPa.d)")]
        m2kPad,
        /// <summary>
        /// m2Pas property
        /// </summary>
        [XmlEnum("m2/(Pa.s)")]
        m2Pas
    }
    /// <summary>
    /// This class represents the ReciprocalForceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReciprocalForceUom xsd enumeration.")]
    public enum ReciprocalForceUom
    {
        /// <summary>
        /// Item1lbf property
        /// </summary>
        [XmlEnum("1/lbf")]
        Item1lbf,
        /// <summary>
        /// Item1N property
        /// </summary>
        [XmlEnum("1/N")]
        Item1N
    }
    /// <summary>
    /// This class represents the ReciprocalAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReciprocalAreaUom xsd enumeration.")]
    public enum ReciprocalAreaUom
    {
        /// <summary>
        /// Item1ft2 property
        /// </summary>
        [XmlEnum("1/ft2")]
        Item1ft2,
        /// <summary>
        /// Item1km2 property
        /// </summary>
        [XmlEnum("1/km2")]
        Item1km2,
        /// <summary>
        /// Item1m2 property
        /// </summary>
        [XmlEnum("1/m2")]
        Item1m2,
        /// <summary>
        /// Item1mi2 property
        /// </summary>
        [XmlEnum("1/mi2")]
        Item1mi2
    }
    /// <summary>
    /// This class represents the PressurePerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PressurePerTimeUom xsd enumeration.")]
    public enum PressurePerTimeUom
    {
        /// <summary>
        /// atmh property
        /// </summary>
        [XmlEnum("atm/h")]
        atmh,
        /// <summary>
        /// barh property
        /// </summary>
        [XmlEnum("bar/h")]
        barh,
        /// <summary>
        /// kPah property
        /// </summary>
        [XmlEnum("kPa/h")]
        kPah,
        /// <summary>
        /// kPamin property
        /// </summary>
        [XmlEnum("kPa/min")]
        kPamin,
        /// <summary>
        /// MPah property
        /// </summary>
        [XmlEnum("MPa/h")]
        MPah,
        /// <summary>
        /// Pah property
        /// </summary>
        [XmlEnum("Pa/h")]
        Pah,
        /// <summary>
        /// Pas property
        /// </summary>
        [XmlEnum("Pa/s")]
        Pas,
        /// <summary>
        /// psih property
        /// </summary>
        [XmlEnum("psi/h")]
        psih,
        /// <summary>
        /// psimin property
        /// </summary>
        [XmlEnum("psi/min")]
        psimin
    }
    /// <summary>
    /// This class represents the ElectricChargeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricChargeUom xsd enumeration.")]
    public enum ElectricChargeUom
    {
        /// <summary>
        /// Ah property
        /// </summary>
        [XmlEnum("A.h")]
        Ah,
        /// <summary>
        /// As property
        /// </summary>
        [XmlEnum("A.s")]
        As,
        /// <summary>
        /// C property
        /// </summary>
        C,
        /// <summary>
        /// cC property
        /// </summary>
        cC,
        /// <summary>
        /// dC property
        /// </summary>
        dC,
        /// <summary>
        /// EC property
        /// </summary>
        EC,
        /// <summary>
        /// fC property
        /// </summary>
        fC,
        /// <summary>
        /// GC property
        /// </summary>
        GC,
        /// <summary>
        /// kC property
        /// </summary>
        kC,
        /// <summary>
        /// MC property
        /// </summary>
        MC,
        /// <summary>
        /// mC property
        /// </summary>
        mC,
        /// <summary>
        /// nC property
        /// </summary>
        nC,
        /// <summary>
        /// pC property
        /// </summary>
        pC,
        /// <summary>
        /// TC property
        /// </summary>
        TC,
        /// <summary>
        /// uC property
        /// </summary>
        uC
    }
    /// <summary>
    /// This class represents the LuminousEfficacyUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LuminousEfficacyUom xsd enumeration.")]
    public enum LuminousEfficacyUom
    {
        /// <summary>
        /// lmW property
        /// </summary>
        [XmlEnum("lm/W")]
        lmW
    }
    /// <summary>
    /// This class represents the PowerUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PowerUom xsd enumeration.")]
    public enum PowerUom
    {
        /// <summary>
        /// cW property
        /// </summary>
        cW,
        /// <summary>
        /// dW property
        /// </summary>
        dW,
        /// <summary>
        /// EW property
        /// </summary>
        EW,
        /// <summary>
        /// fW property
        /// </summary>
        fW,
        /// <summary>
        /// GW property
        /// </summary>
        GW,
        /// <summary>
        /// hp property
        /// </summary>
        hp,
        /// <summary>
        /// hpelec property
        /// </summary>
        [XmlEnum("hp[elec]")]
        hpelec,
        /// <summary>
        /// hphyd property
        /// </summary>
        [XmlEnum("hp[hyd]")]
        hphyd,
        /// <summary>
        /// hpmetric property
        /// </summary>
        [XmlEnum("hp[metric]")]
        hpmetric,
        /// <summary>
        /// kW property
        /// </summary>
        kW,
        /// <summary>
        /// MW property
        /// </summary>
        MW,
        /// <summary>
        /// mW property
        /// </summary>
        mW,
        /// <summary>
        /// nW property
        /// </summary>
        nW,
        /// <summary>
        /// pW property
        /// </summary>
        pW,
        /// <summary>
        /// tonRefrig property
        /// </summary>
        tonRefrig,
        /// <summary>
        /// TW property
        /// </summary>
        TW,
        /// <summary>
        /// uW property
        /// </summary>
        uW,
        /// <summary>
        /// W property
        /// </summary>
        W
    }
    /// <summary>
    /// This class represents the PressurePerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PressurePerVolumeUom xsd enumeration.")]
    public enum PressurePerVolumeUom
    {
        /// <summary>
        /// Pam3 property
        /// </summary>
        [XmlEnum("Pa/m3")]
        Pam3,
        /// <summary>
        /// psi2dcPft3 property
        /// </summary>
        [XmlEnum("psi2.d/(cP.ft3)")]
        psi2dcPft3
    }
    /// <summary>
    /// This class represents the ActivityOfRadioactivityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ActivityOfRadioactivityUom xsd enumeration.")]
    public enum ActivityOfRadioactivityUom
    {
        /// <summary>
        /// Bq property
        /// </summary>
        Bq,
        /// <summary>
        /// Ci property
        /// </summary>
        Ci,
        /// <summary>
        /// GBq property
        /// </summary>
        GBq,
        /// <summary>
        /// MBq property
        /// </summary>
        MBq,
        /// <summary>
        /// mCi property
        /// </summary>
        mCi,
        /// <summary>
        /// nCi property
        /// </summary>
        nCi,
        /// <summary>
        /// pCi property
        /// </summary>
        pCi,
        /// <summary>
        /// TBq property
        /// </summary>
        TBq,
        /// <summary>
        /// uCi property
        /// </summary>
        uCi
    }
    /// <summary>
    /// This class represents the ElectricPotentialDifferenceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricPotentialDifferenceUom xsd enumeration.")]
    public enum ElectricPotentialDifferenceUom
    {
        /// <summary>
        /// cV property
        /// </summary>
        cV,
        /// <summary>
        /// dV property
        /// </summary>
        dV,
        /// <summary>
        /// fV property
        /// </summary>
        fV,
        /// <summary>
        /// GV property
        /// </summary>
        GV,
        /// <summary>
        /// kV property
        /// </summary>
        kV,
        /// <summary>
        /// mV property
        /// </summary>
        mV,
        /// <summary>
        /// MV property
        /// </summary>
        MV,
        /// <summary>
        /// nV property
        /// </summary>
        nV,
        /// <summary>
        /// pV property
        /// </summary>
        pV,
        /// <summary>
        /// TV property
        /// </summary>
        TV,
        /// <summary>
        /// uV property
        /// </summary>
        uV,
        /// <summary>
        /// V property
        /// </summary>
        V
    }
    /// <summary>
    /// This class represents the LengthPerPressureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LengthPerPressureUom xsd enumeration.")]
    public enum LengthPerPressureUom
    {
        /// <summary>
        /// ftpsi property
        /// </summary>
        [XmlEnum("ft/psi")]
        ftpsi,
        /// <summary>
        /// mkPa property
        /// </summary>
        [XmlEnum("m/kPa")]
        mkPa,
        /// <summary>
        /// mPa property
        /// </summary>
        [XmlEnum("m/Pa")]
        mPa
    }
    /// <summary>
    /// This class represents the AreaPerCountUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AreaPerCountUom xsd enumeration.")]
    public enum AreaPerCountUom
    {
        /// <summary>
        /// belectron property
        /// </summary>
        [XmlEnum("b/electron")]
        belectron
    }
    /// <summary>
    /// This class represents the MagneticVectorPotentialUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MagneticVectorPotentialUom xsd enumeration.")]
    public enum MagneticVectorPotentialUom
    {
        /// <summary>
        /// Wbm property
        /// </summary>
        [XmlEnum("Wb/m")]
        Wbm,
        /// <summary>
        /// Wbmm property
        /// </summary>
        [XmlEnum("Wb/mm")]
        Wbmm
    }
    /// <summary>
    /// This class represents the MagneticFieldStrengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MagneticFieldStrengthUom xsd enumeration.")]
    public enum MagneticFieldStrengthUom
    {
        /// <summary>
        /// Am property
        /// </summary>
        [XmlEnum("A/m")]
        Am,
        /// <summary>
        /// Amm property
        /// </summary>
        [XmlEnum("A/mm")]
        Amm,
        /// <summary>
        /// Oe property
        /// </summary>
        Oe
    }
    /// <summary>
    /// This class represents the VolumePerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerTimeUom xsd enumeration.")]
    public enum VolumePerTimeUom
    {
        /// <summary>
        /// Item130cm3min property
        /// </summary>
        [XmlEnum("1/30 cm3/min")]
        Item130cm3min,
        /// <summary>
        /// Item1000bbld property
        /// </summary>
        [XmlEnum("1000 bbl/d")]
        Item1000bbld,
        /// <summary>
        /// Item1000ft3d property
        /// </summary>
        [XmlEnum("1000 ft3/d")]
        Item1000ft3d,
        /// <summary>
        /// Item1000m3d property
        /// </summary>
        [XmlEnum("1000 m3/d")]
        Item1000m3d,
        /// <summary>
        /// Item1000m3h property
        /// </summary>
        [XmlEnum("1000 m3/h")]
        Item1000m3h,
        /// <summary>
        /// Item1E6bbld property
        /// </summary>
        [XmlEnum("1E6 bbl/d")]
        Item1E6bbld,
        /// <summary>
        /// Item1E6ft3d property
        /// </summary>
        [XmlEnum("1E6 ft3/d")]
        Item1E6ft3d,
        /// <summary>
        /// Item1E6m3d property
        /// </summary>
        [XmlEnum("1E6 m3/d")]
        Item1E6m3d,
        /// <summary>
        /// bbld property
        /// </summary>
        [XmlEnum("bbl/d")]
        bbld,
        /// <summary>
        /// bblh property
        /// </summary>
        [XmlEnum("bbl/h")]
        bblh,
        /// <summary>
        /// bblmin property
        /// </summary>
        [XmlEnum("bbl/min")]
        bblmin,
        /// <summary>
        /// cm3h property
        /// </summary>
        [XmlEnum("cm3/h")]
        cm3h,
        /// <summary>
        /// cm3min property
        /// </summary>
        [XmlEnum("cm3/min")]
        cm3min,
        /// <summary>
        /// cm3s property
        /// </summary>
        [XmlEnum("cm3/s")]
        cm3s,
        /// <summary>
        /// dm3s property
        /// </summary>
        [XmlEnum("dm3/s")]
        dm3s,
        /// <summary>
        /// ft3d property
        /// </summary>
        [XmlEnum("ft3/d")]
        ft3d,
        /// <summary>
        /// ft3h property
        /// </summary>
        [XmlEnum("ft3/h")]
        ft3h,
        /// <summary>
        /// ft3min property
        /// </summary>
        [XmlEnum("ft3/min")]
        ft3min,
        /// <summary>
        /// ft3s property
        /// </summary>
        [XmlEnum("ft3/s")]
        ft3s,
        /// <summary>
        /// galUKd property
        /// </summary>
        [XmlEnum("gal[UK]/d")]
        galUKd,
        /// <summary>
        /// galUKh property
        /// </summary>
        [XmlEnum("gal[UK]/h")]
        galUKh,
        /// <summary>
        /// galUKmin property
        /// </summary>
        [XmlEnum("gal[UK]/min")]
        galUKmin,
        /// <summary>
        /// galUSd property
        /// </summary>
        [XmlEnum("gal[US]/d")]
        galUSd,
        /// <summary>
        /// galUSh property
        /// </summary>
        [XmlEnum("gal[US]/h")]
        galUSh,
        /// <summary>
        /// galUSmin property
        /// </summary>
        [XmlEnum("gal[US]/min")]
        galUSmin,
        /// <summary>
        /// Lh property
        /// </summary>
        [XmlEnum("L/h")]
        Lh,
        /// <summary>
        /// Lmin property
        /// </summary>
        [XmlEnum("L/min")]
        Lmin,
        /// <summary>
        /// Ls property
        /// </summary>
        [XmlEnum("L/s")]
        Ls,
        /// <summary>
        /// m3d property
        /// </summary>
        [XmlEnum("m3/d")]
        m3d,
        /// <summary>
        /// m3h property
        /// </summary>
        [XmlEnum("m3/h")]
        m3h,
        /// <summary>
        /// m3min property
        /// </summary>
        [XmlEnum("m3/min")]
        m3min,
        /// <summary>
        /// m3s property
        /// </summary>
        [XmlEnum("m3/s")]
        m3s
    }
    /// <summary>
    /// This class represents the AreaPerMassUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AreaPerMassUom xsd enumeration.")]
    public enum AreaPerMassUom
    {
        /// <summary>
        /// cm2g property
        /// </summary>
        [XmlEnum("cm2/g")]
        cm2g,
        /// <summary>
        /// ft2lbm property
        /// </summary>
        [XmlEnum("ft2/lbm")]
        ft2lbm,
        /// <summary>
        /// m2g property
        /// </summary>
        [XmlEnum("m2/g")]
        m2g,
        /// <summary>
        /// m2kg property
        /// </summary>
        [XmlEnum("m2/kg")]
        m2kg
    }
    /// <summary>
    /// This class represents the ThermalResistanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ThermalResistanceUom xsd enumeration.")]
    public enum ThermalResistanceUom
    {
        /// <summary>
        /// deltaKW property
        /// </summary>
        [XmlEnum("deltaK/W")]
        deltaKW
    }
    /// <summary>
    /// This class represents the ForcePerForceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ForcePerForceUom xsd enumeration.")]
    public enum ForcePerForceUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// kgfkgf property
        /// </summary>
        [XmlEnum("kgf/kgf")]
        kgfkgf,
        /// <summary>
        /// lbflbf property
        /// </summary>
        [XmlEnum("lbf/lbf")]
        lbflbf,
        /// <summary>
        /// NN property
        /// </summary>
        [XmlEnum("N/N")]
        NN
    }
    /// <summary>
    /// This class represents the MassUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassUom xsd enumeration.")]
    public enum MassUom
    {
        /// <summary>
        /// ag property
        /// </summary>
        ag,
        /// <summary>
        /// cg property
        /// </summary>
        cg,
        /// <summary>
        /// ct property
        /// </summary>
        ct,
        /// <summary>
        /// cwtUK property
        /// </summary>
        [XmlEnum("cwt[UK]")]
        cwtUK,
        /// <summary>
        /// cwtUS property
        /// </summary>
        [XmlEnum("cwt[US]")]
        cwtUS,
        /// <summary>
        /// Eg property
        /// </summary>
        Eg,
        /// <summary>
        /// fg property
        /// </summary>
        fg,
        /// <summary>
        /// g property
        /// </summary>
        g,
        /// <summary>
        /// Gg property
        /// </summary>
        Gg,
        /// <summary>
        /// grain property
        /// </summary>
        grain,
        /// <summary>
        /// hg property
        /// </summary>
        hg,
        /// <summary>
        /// kg property
        /// </summary>
        kg,
        /// <summary>
        /// klbm property
        /// </summary>
        klbm,
        /// <summary>
        /// lbm property
        /// </summary>
        lbm,
        /// <summary>
        /// mg property
        /// </summary>
        mg,
        /// <summary>
        /// Mg property
        /// </summary>
        Mg,
        /// <summary>
        /// ng property
        /// </summary>
        ng,
        /// <summary>
        /// ozm property
        /// </summary>
        ozm,
        /// <summary>
        /// ozmtroy property
        /// </summary>
        [XmlEnum("ozm[troy]")]
        ozmtroy,
        /// <summary>
        /// pg property
        /// </summary>
        pg,
        /// <summary>
        /// sack94lbm property
        /// </summary>
        [XmlEnum("sack[94lbm]")]
        sack94lbm,
        /// <summary>
        /// t property
        /// </summary>
        t,
        /// <summary>
        /// Tg property
        /// </summary>
        Tg,
        /// <summary>
        /// tonUK property
        /// </summary>
        [XmlEnum("ton[UK]")]
        tonUK,
        /// <summary>
        /// tonUS property
        /// </summary>
        [XmlEnum("ton[US]")]
        tonUS,
        /// <summary>
        /// ug property
        /// </summary>
        ug
    }
    /// <summary>
    /// This class represents the SpecificHeatCapacityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the SpecificHeatCapacityUom xsd enumeration.")]
    public enum SpecificHeatCapacityUom
    {
        /// <summary>
        /// BtuITlbmdeltaF property
        /// </summary>
        [XmlEnum("Btu[IT]/(lbm.deltaF)")]
        BtuITlbmdeltaF,
        /// <summary>
        /// BtuITlbmdeltaR property
        /// </summary>
        [XmlEnum("Btu[IT]/(lbm.deltaR)")]
        BtuITlbmdeltaR,
        /// <summary>
        /// calthgdeltaK property
        /// </summary>
        [XmlEnum("cal[th]/(g.deltaK)")]
        calthgdeltaK,
        /// <summary>
        /// JgdeltaK property
        /// </summary>
        [XmlEnum("J/(g.deltaK)")]
        JgdeltaK,
        /// <summary>
        /// JkgdeltaK property
        /// </summary>
        [XmlEnum("J/(kg.deltaK)")]
        JkgdeltaK,
        /// <summary>
        /// kcalthkgdeltaC property
        /// </summary>
        [XmlEnum("kcal[th]/(kg.deltaC)")]
        kcalthkgdeltaC,
        /// <summary>
        /// kJkgdeltaK property
        /// </summary>
        [XmlEnum("kJ/(kg.deltaK)")]
        kJkgdeltaK,
        /// <summary>
        /// kWhkgdeltaC property
        /// </summary>
        [XmlEnum("kW.h/(kg.deltaC)")]
        kWhkgdeltaC
    }
    /// <summary>
    /// This class represents the LengthPerMassUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LengthPerMassUom xsd enumeration.")]
    public enum LengthPerMassUom
    {
        /// <summary>
        /// ftlbm property
        /// </summary>
        [XmlEnum("ft/lbm")]
        ftlbm,
        /// <summary>
        /// mkg property
        /// </summary>
        [XmlEnum("m/kg")]
        mkg
    }
    /// <summary>
    /// This class represents the AmountOfSubstancePerTimePerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AmountOfSubstancePerTimePerAreaUom xsd enumeration.")]
    public enum AmountOfSubstancePerTimePerAreaUom
    {
        /// <summary>
        /// lbmolhft2 property
        /// </summary>
        [XmlEnum("lbmol/(h.ft2)")]
        lbmolhft2,
        /// <summary>
        /// lbmolsft2 property
        /// </summary>
        [XmlEnum("lbmol/(s.ft2)")]
        lbmolsft2,
        /// <summary>
        /// molsm2 property
        /// </summary>
        [XmlEnum("mol/(s.m2)")]
        molsm2
    }
    /// <summary>
    /// This class represents the ThermodynamicTemperatureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ThermodynamicTemperatureUom xsd enumeration.")]
    public enum ThermodynamicTemperatureUom
    {
        /// <summary>
        /// degC property
        /// </summary>
        degC,
        /// <summary>
        /// degF property
        /// </summary>
        degF,
        /// <summary>
        /// degR property
        /// </summary>
        degR,
        /// <summary>
        /// K property
        /// </summary>
        K
    }
    /// <summary>
    /// This class represents the LinearThermalExpansionUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LinearThermalExpansionUom xsd enumeration.")]
    public enum LinearThermalExpansionUom
    {
        /// <summary>
        /// Item1deltaK property
        /// </summary>
        [XmlEnum("1/deltaK")]
        Item1deltaK,
        /// <summary>
        /// inindeltaF property
        /// </summary>
        [XmlEnum("in/(in.deltaF)")]
        inindeltaF,
        /// <summary>
        /// mmdeltaK property
        /// </summary>
        [XmlEnum("m/(m.deltaK)")]
        mmdeltaK,
        /// <summary>
        /// mmmmdeltaK property
        /// </summary>
        [XmlEnum("mm/(mm.deltaK)")]
        mmmmdeltaK
    }
    /// <summary>
    /// This class represents the MassPerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerLengthUom xsd enumeration.")]
    public enum MassPerLengthUom
    {
        /// <summary>
        /// kgmcm2 property
        /// </summary>
        [XmlEnum("kg.m/cm2")]
        kgmcm2,
        /// <summary>
        /// kgm property
        /// </summary>
        [XmlEnum("kg/m")]
        kgm,
        /// <summary>
        /// klbmin property
        /// </summary>
        [XmlEnum("klbm/in")]
        klbmin,
        /// <summary>
        /// lbmft property
        /// </summary>
        [XmlEnum("lbm/ft")]
        lbmft,
        /// <summary>
        /// Mgin property
        /// </summary>
        [XmlEnum("Mg/in")]
        Mgin
    }
    /// <summary>
    /// This class represents the ElectricalResistivityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricalResistivityUom xsd enumeration.")]
    public enum ElectricalResistivityUom
    {
        /// <summary>
        /// kohmm property
        /// </summary>
        [XmlEnum("kohm.m")]
        kohmm,
        /// <summary>
        /// nohmmil2ft property
        /// </summary>
        [XmlEnum("nohm.mil2/ft")]
        nohmmil2ft,
        /// <summary>
        /// nohmmm2m property
        /// </summary>
        [XmlEnum("nohm.mm2/m")]
        nohmmm2m,
        /// <summary>
        /// ohmcm property
        /// </summary>
        [XmlEnum("ohm.cm")]
        ohmcm,
        /// <summary>
        /// ohmm property
        /// </summary>
        [XmlEnum("ohm.m")]
        ohmm,
        /// <summary>
        /// ohmm2m property
        /// </summary>
        [XmlEnum("ohm.m2/m")]
        ohmm2m
    }
    /// <summary>
    /// This class represents the MassPerMassUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerMassUom xsd enumeration.")]
    public enum MassPerMassUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// mass property
        /// </summary>
        [XmlEnum("%[mass]")]
        mass,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// gkg property
        /// </summary>
        [XmlEnum("g/kg")]
        gkg,
        /// <summary>
        /// gt property
        /// </summary>
        [XmlEnum("g/t")]
        gt,
        /// <summary>
        /// kgkg property
        /// </summary>
        [XmlEnum("kg/kg")]
        kgkg,
        /// <summary>
        /// kgsack94lbm property
        /// </summary>
        [XmlEnum("kg/sack[94lbm]")]
        kgsack94lbm,
        /// <summary>
        /// kgt property
        /// </summary>
        [XmlEnum("kg/t")]
        kgt,
        /// <summary>
        /// mgg property
        /// </summary>
        [XmlEnum("mg/g")]
        mgg,
        /// <summary>
        /// mgkg property
        /// </summary>
        [XmlEnum("mg/kg")]
        mgkg,
        /// <summary>
        /// ngg property
        /// </summary>
        [XmlEnum("ng/g")]
        ngg,
        /// <summary>
        /// ngmg property
        /// </summary>
        [XmlEnum("ng/mg")]
        ngmg,
        /// <summary>
        /// ppk property
        /// </summary>
        ppk,
        /// <summary>
        /// ppm property
        /// </summary>
        ppm,
        /// <summary>
        /// ppmmass property
        /// </summary>
        [XmlEnum("ppm[mass]")]
        ppmmass,
        /// <summary>
        /// ugg property
        /// </summary>
        [XmlEnum("ug/g")]
        ugg,
        /// <summary>
        /// ugmg property
        /// </summary>
        [XmlEnum("ug/mg")]
        ugmg
    }
    /// <summary>
    /// This class represents the PressureSquaredPerForceTimePerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PressureSquaredPerForceTimePerAreaUom xsd enumeration.")]
    public enum PressureSquaredPerForceTimePerAreaUom
    {
        /// <summary>
        /// Item0001kPa2cP property
        /// </summary>
        [XmlEnum("0.001 kPa2/cP")]
        Item0001kPa2cP,
        /// <summary>
        /// bar2cP property
        /// </summary>
        [XmlEnum("bar2/cP")]
        bar2cP,
        /// <summary>
        /// kPa2cP property
        /// </summary>
        [XmlEnum("kPa2/cP")]
        kPa2cP,
        /// <summary>
        /// Pa2Pas property
        /// </summary>
        [XmlEnum("Pa2/(Pa.s)")]
        Pa2Pas,
        /// <summary>
        /// psi2cP property
        /// </summary>
        [XmlEnum("psi2/cP")]
        psi2cP
    }
    /// <summary>
    /// This class represents the LuminousFluxUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LuminousFluxUom xsd enumeration.")]
    public enum LuminousFluxUom
    {
        /// <summary>
        /// lm property
        /// </summary>
        lm
    }
    /// <summary>
    /// This class represents the VolumePerTimePerPressureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerTimePerPressureUom xsd enumeration.")]
    public enum VolumePerTimePerPressureUom
    {
        /// <summary>
        /// Item1000ft3psid property
        /// </summary>
        [XmlEnum("1000 ft3/(psi.d)")]
        Item1000ft3psid,
        /// <summary>
        /// bblkPad property
        /// </summary>
        [XmlEnum("bbl/(kPa.d)")]
        bblkPad,
        /// <summary>
        /// bblpsid property
        /// </summary>
        [XmlEnum("bbl/(psi.d)")]
        bblpsid,
        /// <summary>
        /// Lbarmin property
        /// </summary>
        [XmlEnum("L/(bar.min)")]
        Lbarmin,
        /// <summary>
        /// m3bard property
        /// </summary>
        [XmlEnum("m3/(bar.d)")]
        m3bard,
        /// <summary>
        /// m3barh property
        /// </summary>
        [XmlEnum("m3/(bar.h)")]
        m3barh,
        /// <summary>
        /// m3barmin property
        /// </summary>
        [XmlEnum("m3/(bar.min)")]
        m3barmin,
        /// <summary>
        /// m3kPad property
        /// </summary>
        [XmlEnum("m3/(kPa.d)")]
        m3kPad,
        /// <summary>
        /// m3kPah property
        /// </summary>
        [XmlEnum("m3/(kPa.h)")]
        m3kPah,
        /// <summary>
        /// m3Pas property
        /// </summary>
        [XmlEnum("m3/(Pa.s)")]
        m3Pas,
        /// <summary>
        /// m3psid property
        /// </summary>
        [XmlEnum("m3/(psi.d)")]
        m3psid
    }
    /// <summary>
    /// This class represents the AmountOfSubstancePerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AmountOfSubstancePerVolumeUom xsd enumeration.")]
    public enum AmountOfSubstancePerVolumeUom
    {
        /// <summary>
        /// kmolm3 property
        /// </summary>
        [XmlEnum("kmol/m3")]
        kmolm3,
        /// <summary>
        /// lbmolft3 property
        /// </summary>
        [XmlEnum("lbmol/ft3")]
        lbmolft3,
        /// <summary>
        /// lbmolgalUK property
        /// </summary>
        [XmlEnum("lbmol/gal[UK]")]
        lbmolgalUK,
        /// <summary>
        /// lbmolgalUS property
        /// </summary>
        [XmlEnum("lbmol/gal[US]")]
        lbmolgalUS,
        /// <summary>
        /// molm3 property
        /// </summary>
        [XmlEnum("mol/m3")]
        molm3
    }
    /// <summary>
    /// This class represents the EnergyPerMassUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the EnergyPerMassUom xsd enumeration.")]
    public enum EnergyPerMassUom
    {
        /// <summary>
        /// BtuITlbm property
        /// </summary>
        [XmlEnum("Btu[IT]/lbm")]
        BtuITlbm,
        /// <summary>
        /// calthg property
        /// </summary>
        [XmlEnum("cal[th]/g")]
        calthg,
        /// <summary>
        /// calthkg property
        /// </summary>
        [XmlEnum("cal[th]/kg")]
        calthkg,
        /// <summary>
        /// calthlbm property
        /// </summary>
        [XmlEnum("cal[th]/lbm")]
        calthlbm,
        /// <summary>
        /// ergg property
        /// </summary>
        [XmlEnum("erg/g")]
        ergg,
        /// <summary>
        /// ergkg property
        /// </summary>
        [XmlEnum("erg/kg")]
        ergkg,
        /// <summary>
        /// hphlbm property
        /// </summary>
        [XmlEnum("hp.h/lbm")]
        hphlbm,
        /// <summary>
        /// Jg property
        /// </summary>
        [XmlEnum("J/g")]
        Jg,
        /// <summary>
        /// Jkg property
        /// </summary>
        [XmlEnum("J/kg")]
        Jkg,
        /// <summary>
        /// kcalthg property
        /// </summary>
        [XmlEnum("kcal[th]/g")]
        kcalthg,
        /// <summary>
        /// kcalthkg property
        /// </summary>
        [XmlEnum("kcal[th]/kg")]
        kcalthkg,
        /// <summary>
        /// kJkg property
        /// </summary>
        [XmlEnum("kJ/kg")]
        kJkg,
        /// <summary>
        /// kWhkg property
        /// </summary>
        [XmlEnum("kW.h/kg")]
        kWhkg,
        /// <summary>
        /// lbfftlbm property
        /// </summary>
        [XmlEnum("lbf.ft/lbm")]
        lbfftlbm,
        /// <summary>
        /// MJkg property
        /// </summary>
        [XmlEnum("MJ/kg")]
        MJkg,
        /// <summary>
        /// MWhkg property
        /// </summary>
        [XmlEnum("MW.h/kg")]
        MWhkg
    }
    /// <summary>
    /// This class represents the PermittivityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PermittivityUom xsd enumeration.")]
    public enum PermittivityUom
    {
        /// <summary>
        /// Fm property
        /// </summary>
        [XmlEnum("F/m")]
        Fm,
        /// <summary>
        /// uFm property
        /// </summary>
        [XmlEnum("uF/m")]
        uFm
    }
    /// <summary>
    /// This class represents the ElectromagneticMomentUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectromagneticMomentUom xsd enumeration.")]
    public enum ElectromagneticMomentUom
    {
        /// <summary>
        /// Am2 property
        /// </summary>
        [XmlEnum("A.m2")]
        Am2
    }
    /// <summary>
    /// This class represents the ThermalInsulanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ThermalInsulanceUom xsd enumeration.")]
    public enum ThermalInsulanceUom
    {
        /// <summary>
        /// deltaCm2hkcalth property
        /// </summary>
        [XmlEnum("deltaC.m2.h/kcal[th]")]
        deltaCm2hkcalth,
        /// <summary>
        /// deltaFft2hBtuIT property
        /// </summary>
        [XmlEnum("deltaF.ft2.h/Btu[IT]")]
        deltaFft2hBtuIT,
        /// <summary>
        /// deltaKm2kW property
        /// </summary>
        [XmlEnum("deltaK.m2/kW")]
        deltaKm2kW,
        /// <summary>
        /// deltaKm2W property
        /// </summary>
        [XmlEnum("deltaK.m2/W")]
        deltaKm2W
    }
    /// <summary>
    /// This class represents the PowerPerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PowerPerAreaUom xsd enumeration.")]
    public enum PowerPerAreaUom
    {
        /// <summary>
        /// BtuIThft2 property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft2)")]
        BtuIThft2,
        /// <summary>
        /// BtuITsft2 property
        /// </summary>
        [XmlEnum("Btu[IT]/(s.ft2)")]
        BtuITsft2,
        /// <summary>
        /// calthhcm2 property
        /// </summary>
        [XmlEnum("cal[th]/(h.cm2)")]
        calthhcm2,
        /// <summary>
        /// hpin2 property
        /// </summary>
        [XmlEnum("hp/in2")]
        hpin2,
        /// <summary>
        /// hphydin2 property
        /// </summary>
        [XmlEnum("hp[hyd]/in2")]
        hphydin2,
        /// <summary>
        /// kWcm2 property
        /// </summary>
        [XmlEnum("kW/cm2")]
        kWcm2,
        /// <summary>
        /// kWm2 property
        /// </summary>
        [XmlEnum("kW/m2")]
        kWm2,
        /// <summary>
        /// mWm2 property
        /// </summary>
        [XmlEnum("mW/m2")]
        mWm2,
        /// <summary>
        /// ucalthscm2 property
        /// </summary>
        [XmlEnum("ucal[th]/(s.cm2)")]
        ucalthscm2,
        /// <summary>
        /// Wcm2 property
        /// </summary>
        [XmlEnum("W/cm2")]
        Wcm2,
        /// <summary>
        /// Wm2 property
        /// </summary>
        [XmlEnum("W/m2")]
        Wm2,
        /// <summary>
        /// Wmm2 property
        /// </summary>
        [XmlEnum("W/mm2")]
        Wmm2
    }
    /// <summary>
    /// This class represents the MassPerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerAreaUom xsd enumeration.")]
    public enum MassPerAreaUom
    {
        /// <summary>
        /// Item001lbmft2 property
        /// </summary>
        [XmlEnum("0.01 lbm/ft2")]
        Item001lbmft2,
        /// <summary>
        /// kgm2 property
        /// </summary>
        [XmlEnum("kg/m2")]
        kgm2,
        /// <summary>
        /// lbmft2 property
        /// </summary>
        [XmlEnum("lbm/ft2")]
        lbmft2,
        /// <summary>
        /// Mgm2 property
        /// </summary>
        [XmlEnum("Mg/m2")]
        Mgm2,
        /// <summary>
        /// tonUSft2 property
        /// </summary>
        [XmlEnum("ton[US]/ft2")]
        tonUSft2
    }
    /// <summary>
    /// This class represents the IlluminanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the IlluminanceUom xsd enumeration.")]
    public enum IlluminanceUom
    {
        /// <summary>
        /// footcandle property
        /// </summary>
        footcandle,
        /// <summary>
        /// klx property
        /// </summary>
        klx,
        /// <summary>
        /// lmm2 property
        /// </summary>
        [XmlEnum("lm/m2")]
        lmm2,
        /// <summary>
        /// lx property
        /// </summary>
        lx
    }
    /// <summary>
    /// This class represents the AreaPerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AreaPerVolumeUom xsd enumeration.")]
    public enum AreaPerVolumeUom
    {
        /// <summary>
        /// Item1m property
        /// </summary>
        [XmlEnum("1/m")]
        Item1m,
        /// <summary>
        /// bcm3 property
        /// </summary>
        [XmlEnum("b/cm3")]
        bcm3,
        /// <summary>
        /// cu property
        /// </summary>
        cu,
        /// <summary>
        /// ft2in3 property
        /// </summary>
        [XmlEnum("ft2/in3")]
        ft2in3,
        /// <summary>
        /// m2cm3 property
        /// </summary>
        [XmlEnum("m2/cm3")]
        m2cm3,
        /// <summary>
        /// m2m3 property
        /// </summary>
        [XmlEnum("m2/m3")]
        m2m3
    }
    /// <summary>
    /// This class represents the TemperatureIntervalPerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the TemperatureIntervalPerTimeUom xsd enumeration.")]
    public enum TemperatureIntervalPerTimeUom
    {
        /// <summary>
        /// deltaCh property
        /// </summary>
        [XmlEnum("deltaC/h")]
        deltaCh,
        /// <summary>
        /// deltaCmin property
        /// </summary>
        [XmlEnum("deltaC/min")]
        deltaCmin,
        /// <summary>
        /// deltaCs property
        /// </summary>
        [XmlEnum("deltaC/s")]
        deltaCs,
        /// <summary>
        /// deltaFh property
        /// </summary>
        [XmlEnum("deltaF/h")]
        deltaFh,
        /// <summary>
        /// deltaFmin property
        /// </summary>
        [XmlEnum("deltaF/min")]
        deltaFmin,
        /// <summary>
        /// deltaFs property
        /// </summary>
        [XmlEnum("deltaF/s")]
        deltaFs,
        /// <summary>
        /// deltaKs property
        /// </summary>
        [XmlEnum("deltaK/s")]
        deltaKs
    }
    /// <summary>
    /// This class represents the AmountOfSubstancePerAmountOfSubstanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AmountOfSubstancePerAmountOfSubstanceUom xsd enumeration.")]
    public enum AmountOfSubstancePerAmountOfSubstanceUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// molar property
        /// </summary>
        [XmlEnum("%[molar]")]
        molar,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// molmol property
        /// </summary>
        [XmlEnum("mol/mol")]
        molmol,
        /// <summary>
        /// nEuc property
        /// </summary>
        nEuc,
        /// <summary>
        /// ppk property
        /// </summary>
        ppk,
        /// <summary>
        /// ppm property
        /// </summary>
        ppm
    }
    /// <summary>
    /// This class represents the RadianceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the RadianceUom xsd enumeration.")]
    public enum RadianceUom
    {
        /// <summary>
        /// Wm2sr property
        /// </summary>
        [XmlEnum("W/(m2.sr)")]
        Wm2sr
    }
    /// <summary>
    /// This class represents the HeatFlowRateUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the HeatFlowRateUom xsd enumeration.")]
    public enum HeatFlowRateUom
    {
        /// <summary>
        /// Item1E6BtuITh property
        /// </summary>
        [XmlEnum("1E6 Btu[IT]/h")]
        Item1E6BtuITh,
        /// <summary>
        /// BtuITh property
        /// </summary>
        [XmlEnum("Btu[IT]/h")]
        BtuITh,
        /// <summary>
        /// BtuITmin property
        /// </summary>
        [XmlEnum("Btu[IT]/min")]
        BtuITmin,
        /// <summary>
        /// BtuITs property
        /// </summary>
        [XmlEnum("Btu[IT]/s")]
        BtuITs,
        /// <summary>
        /// calthh property
        /// </summary>
        [XmlEnum("cal[th]/h")]
        calthh,
        /// <summary>
        /// EJa property
        /// </summary>
        [XmlEnum("EJ/a")]
        EJa,
        /// <summary>
        /// erga property
        /// </summary>
        [XmlEnum("erg/a")]
        erga,
        /// <summary>
        /// GW property
        /// </summary>
        GW,
        /// <summary>
        /// Js property
        /// </summary>
        [XmlEnum("J/s")]
        Js,
        /// <summary>
        /// kcalthh property
        /// </summary>
        [XmlEnum("kcal[th]/h")]
        kcalthh,
        /// <summary>
        /// kW property
        /// </summary>
        kW,
        /// <summary>
        /// lbfftmin property
        /// </summary>
        [XmlEnum("lbf.ft/min")]
        lbfftmin,
        /// <summary>
        /// lbffts property
        /// </summary>
        [XmlEnum("lbf.ft/s")]
        lbffts,
        /// <summary>
        /// MJa property
        /// </summary>
        [XmlEnum("MJ/a")]
        MJa,
        /// <summary>
        /// mW property
        /// </summary>
        mW,
        /// <summary>
        /// MW property
        /// </summary>
        MW,
        /// <summary>
        /// nW property
        /// </summary>
        nW,
        /// <summary>
        /// quada property
        /// </summary>
        [XmlEnum("quad/a")]
        quada,
        /// <summary>
        /// TJa property
        /// </summary>
        [XmlEnum("TJ/a")]
        TJa,
        /// <summary>
        /// TW property
        /// </summary>
        TW,
        /// <summary>
        /// ucalths property
        /// </summary>
        [XmlEnum("ucal[th]/s")]
        ucalths,
        /// <summary>
        /// uW property
        /// </summary>
        uW,
        /// <summary>
        /// W property
        /// </summary>
        W
    }
    /// <summary>
    /// This class represents the DoseEquivalentUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the DoseEquivalentUom xsd enumeration.")]
    public enum DoseEquivalentUom
    {
        /// <summary>
        /// mrem property
        /// </summary>
        mrem,
        /// <summary>
        /// mSv property
        /// </summary>
        mSv,
        /// <summary>
        /// rem property
        /// </summary>
        rem,
        /// <summary>
        /// Sv property
        /// </summary>
        Sv
    }
    /// <summary>
    /// This class represents the PowerPerPowerUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PowerPerPowerUom xsd enumeration.")]
    public enum PowerPerPowerUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// BtuIThph property
        /// </summary>
        [XmlEnum("Btu[IT]/(hp.h)")]
        BtuIThph,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// WkW property
        /// </summary>
        [XmlEnum("W/kW")]
        WkW,
        /// <summary>
        /// WW property
        /// </summary>
        [XmlEnum("W/W")]
        WW
    }
    /// <summary>
    /// This class represents the ElectricChargePerMassUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricChargePerMassUom xsd enumeration.")]
    public enum ElectricChargePerMassUom
    {
        /// <summary>
        /// Askg property
        /// </summary>
        [XmlEnum("A.s/kg")]
        Askg,
        /// <summary>
        /// Cg property
        /// </summary>
        [XmlEnum("C/g")]
        Cg,
        /// <summary>
        /// Ckg property
        /// </summary>
        [XmlEnum("C/kg")]
        Ckg
    }
    /// <summary>
    /// This class represents the MassPerVolumePerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerVolumePerLengthUom xsd enumeration.")]
    public enum MassPerVolumePerLengthUom
    {
        /// <summary>
        /// gcm4 property
        /// </summary>
        [XmlEnum("g/cm4")]
        gcm4,
        /// <summary>
        /// kgdm4 property
        /// </summary>
        [XmlEnum("kg/dm4")]
        kgdm4,
        /// <summary>
        /// kgm4 property
        /// </summary>
        [XmlEnum("kg/m4")]
        kgm4,
        /// <summary>
        /// lbmgalUKft property
        /// </summary>
        [XmlEnum("lbm/(gal[UK].ft)")]
        lbmgalUKft,
        /// <summary>
        /// lbmgalUSft property
        /// </summary>
        [XmlEnum("lbm/(gal[US].ft)")]
        lbmgalUSft,
        /// <summary>
        /// lbmft4 property
        /// </summary>
        [XmlEnum("lbm/ft4")]
        lbmft4,
        /// <summary>
        /// Pas2m3 property
        /// </summary>
        [XmlEnum("Pa.s2/m3")]
        Pas2m3
    }
    /// <summary>
    /// This class represents the MassLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassLengthUom xsd enumeration.")]
    public enum MassLengthUom
    {
        /// <summary>
        /// kgm property
        /// </summary>
        [XmlEnum("kg.m")]
        kgm,
        /// <summary>
        /// lbmft property
        /// </summary>
        [XmlEnum("lbm.ft")]
        lbmft
    }
    /// <summary>
    /// This class represents the ForcePerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ForcePerVolumeUom xsd enumeration.")]
    public enum ForcePerVolumeUom
    {
        /// <summary>
        /// Item0001psift property
        /// </summary>
        [XmlEnum("0.001 psi/ft")]
        Item0001psift,
        /// <summary>
        /// Item001psift property
        /// </summary>
        [XmlEnum("0.01 psi/ft")]
        Item001psift,
        /// <summary>
        /// atmft property
        /// </summary>
        [XmlEnum("atm/ft")]
        atmft,
        /// <summary>
        /// atmhm property
        /// </summary>
        [XmlEnum("atm/hm")]
        atmhm,
        /// <summary>
        /// atmm property
        /// </summary>
        [XmlEnum("atm/m")]
        atmm,
        /// <summary>
        /// barkm property
        /// </summary>
        [XmlEnum("bar/km")]
        barkm,
        /// <summary>
        /// barm property
        /// </summary>
        [XmlEnum("bar/m")]
        barm,
        /// <summary>
        /// GPacm property
        /// </summary>
        [XmlEnum("GPa/cm")]
        GPacm,
        /// <summary>
        /// kPahm property
        /// </summary>
        [XmlEnum("kPa/hm")]
        kPahm,
        /// <summary>
        /// kPam property
        /// </summary>
        [XmlEnum("kPa/m")]
        kPam,
        /// <summary>
        /// lbfft3 property
        /// </summary>
        [XmlEnum("lbf/ft3")]
        lbfft3,
        /// <summary>
        /// lbfgalUS property
        /// </summary>
        [XmlEnum("lbf/gal[US]")]
        lbfgalUS,
        /// <summary>
        /// MPam property
        /// </summary>
        [XmlEnum("MPa/m")]
        MPam,
        /// <summary>
        /// Nm3 property
        /// </summary>
        [XmlEnum("N/m3")]
        Nm3,
        /// <summary>
        /// Pam property
        /// </summary>
        [XmlEnum("Pa/m")]
        Pam,
        /// <summary>
        /// psift property
        /// </summary>
        [XmlEnum("psi/ft")]
        psift,
        /// <summary>
        /// psim property
        /// </summary>
        [XmlEnum("psi/m")]
        psim
    }
    /// <summary>
    /// This class represents the ElectricChargePerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricChargePerVolumeUom xsd enumeration.")]
    public enum ElectricChargePerVolumeUom
    {
        /// <summary>
        /// Asm3 property
        /// </summary>
        [XmlEnum("A.s/m3")]
        Asm3,
        /// <summary>
        /// Ccm3 property
        /// </summary>
        [XmlEnum("C/cm3")]
        Ccm3,
        /// <summary>
        /// Cm3 property
        /// </summary>
        [XmlEnum("C/m3")]
        Cm3,
        /// <summary>
        /// Cmm3 property
        /// </summary>
        [XmlEnum("C/mm3")]
        Cmm3
    }
    /// <summary>
    /// This class represents the APIGravityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the APIGravityUom xsd enumeration.")]
    public enum APIGravityUom
    {
        /// <summary>
        /// dAPI property
        /// </summary>
        dAPI
    }
    /// <summary>
    /// This class represents the ReluctanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReluctanceUom xsd enumeration.")]
    public enum ReluctanceUom
    {
        /// <summary>
        /// Item1H property
        /// </summary>
        [XmlEnum("1/H")]
        Item1H
    }
    /// <summary>
    /// This class represents the LengthPerTemperatureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LengthPerTemperatureUom xsd enumeration.")]
    public enum LengthPerTemperatureUom
    {
        /// <summary>
        /// ftdeltaF property
        /// </summary>
        [XmlEnum("ft/deltaF")]
        ftdeltaF,
        /// <summary>
        /// mdeltaK property
        /// </summary>
        [XmlEnum("m/deltaK")]
        mdeltaK
    }
    /// <summary>
    /// This class represents the VolumePerTimePerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerTimePerLengthUom xsd enumeration.")]
    public enum VolumePerTimePerLengthUom
    {
        /// <summary>
        /// Item1000ft3dft property
        /// </summary>
        [XmlEnum("1000 ft3/(d.ft)")]
        Item1000ft3dft,
        /// <summary>
        /// Item1000m3dm property
        /// </summary>
        [XmlEnum("1000 m3/(d.m)")]
        Item1000m3dm,
        /// <summary>
        /// Item1000m3hm property
        /// </summary>
        [XmlEnum("1000 m3/(h.m)")]
        Item1000m3hm,
        /// <summary>
        /// bbldft property
        /// </summary>
        [XmlEnum("bbl/(d.ft)")]
        bbldft,
        /// <summary>
        /// ft3dft property
        /// </summary>
        [XmlEnum("ft3/(d.ft)")]
        ft3dft,
        /// <summary>
        /// galUKhft property
        /// </summary>
        [XmlEnum("gal[UK]/(h.ft)")]
        galUKhft,
        /// <summary>
        /// galUKhin property
        /// </summary>
        [XmlEnum("gal[UK]/(h.in)")]
        galUKhin,
        /// <summary>
        /// galUKminft property
        /// </summary>
        [XmlEnum("gal[UK]/(min.ft)")]
        galUKminft,
        /// <summary>
        /// galUShft property
        /// </summary>
        [XmlEnum("gal[US]/(h.ft)")]
        galUShft,
        /// <summary>
        /// galUShin property
        /// </summary>
        [XmlEnum("gal[US]/(h.in)")]
        galUShin,
        /// <summary>
        /// galUSminft property
        /// </summary>
        [XmlEnum("gal[US]/(min.ft)")]
        galUSminft,
        /// <summary>
        /// m3dm property
        /// </summary>
        [XmlEnum("m3/(d.m)")]
        m3dm,
        /// <summary>
        /// m3hm property
        /// </summary>
        [XmlEnum("m3/(h.m)")]
        m3hm,
        /// <summary>
        /// m3sft property
        /// </summary>
        [XmlEnum("m3/(s.ft)")]
        m3sft,
        /// <summary>
        /// m3sm property
        /// </summary>
        [XmlEnum("m3/(s.m)")]
        m3sm
    }
    /// <summary>
    /// This class represents the LinearAccelerationUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LinearAccelerationUom xsd enumeration.")]
    public enum LinearAccelerationUom
    {
        /// <summary>
        /// cms2 property
        /// </summary>
        [XmlEnum("cm/s2")]
        cms2,
        /// <summary>
        /// fts2 property
        /// </summary>
        [XmlEnum("ft/s2")]
        fts2,
        /// <summary>
        /// Gal property
        /// </summary>
        Gal,
        /// <summary>
        /// gn property
        /// </summary>
        gn,
        /// <summary>
        /// ins2 property
        /// </summary>
        [XmlEnum("in/s2")]
        ins2,
        /// <summary>
        /// ms2 property
        /// </summary>
        [XmlEnum("m/s2")]
        ms2,
        /// <summary>
        /// mGal property
        /// </summary>
        mGal,
        /// <summary>
        /// mgn property
        /// </summary>
        mgn
    }
    /// <summary>
    /// This class represents the DimensionlessUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the DimensionlessUom xsd enumeration.")]
    public enum DimensionlessUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// cEuc property
        /// </summary>
        cEuc,
        /// <summary>
        /// dEuc property
        /// </summary>
        dEuc,
        /// <summary>
        /// EEuc property
        /// </summary>
        EEuc,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// fEuc property
        /// </summary>
        fEuc,
        /// <summary>
        /// GEuc property
        /// </summary>
        GEuc,
        /// <summary>
        /// kEuc property
        /// </summary>
        kEuc,
        /// <summary>
        /// MEuc property
        /// </summary>
        MEuc,
        /// <summary>
        /// mEuc property
        /// </summary>
        mEuc,
        /// <summary>
        /// nEuc property
        /// </summary>
        nEuc,
        /// <summary>
        /// pEuc property
        /// </summary>
        pEuc,
        /// <summary>
        /// ppk property
        /// </summary>
        ppk,
        /// <summary>
        /// ppm property
        /// </summary>
        ppm,
        /// <summary>
        /// TEuc property
        /// </summary>
        TEuc,
        /// <summary>
        /// uEuc property
        /// </summary>
        uEuc
    }
    /// <summary>
    /// This class represents the EnergyUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the EnergyUom xsd enumeration.")]
    public enum EnergyUom
    {
        /// <summary>
        /// Item1E6BtuIT property
        /// </summary>
        [XmlEnum("1E6 Btu[IT]")]
        Item1E6BtuIT,
        /// <summary>
        /// aJ property
        /// </summary>
        aJ,
        /// <summary>
        /// BtuIT property
        /// </summary>
        [XmlEnum("Btu[IT]")]
        BtuIT,
        /// <summary>
        /// Btuth property
        /// </summary>
        [XmlEnum("Btu[th]")]
        Btuth,
        /// <summary>
        /// BtuUK property
        /// </summary>
        [XmlEnum("Btu[UK]")]
        BtuUK,
        /// <summary>
        /// calIT property
        /// </summary>
        [XmlEnum("cal[IT]")]
        calIT,
        /// <summary>
        /// calth property
        /// </summary>
        [XmlEnum("cal[th]")]
        calth,
        /// <summary>
        /// ccalth property
        /// </summary>
        [XmlEnum("ccal[th]")]
        ccalth,
        /// <summary>
        /// ceV property
        /// </summary>
        ceV,
        /// <summary>
        /// cJ property
        /// </summary>
        cJ,
        /// <summary>
        /// dcalth property
        /// </summary>
        [XmlEnum("dcal[th]")]
        dcalth,
        /// <summary>
        /// deV property
        /// </summary>
        deV,
        /// <summary>
        /// dJ property
        /// </summary>
        dJ,
        /// <summary>
        /// Ecalth property
        /// </summary>
        [XmlEnum("Ecal[th]")]
        Ecalth,
        /// <summary>
        /// EeV property
        /// </summary>
        EeV,
        /// <summary>
        /// EJ property
        /// </summary>
        EJ,
        /// <summary>
        /// erg property
        /// </summary>
        erg,
        /// <summary>
        /// eV property
        /// </summary>
        eV,
        /// <summary>
        /// fcalth property
        /// </summary>
        [XmlEnum("fcal[th]")]
        fcalth,
        /// <summary>
        /// feV property
        /// </summary>
        feV,
        /// <summary>
        /// fJ property
        /// </summary>
        fJ,
        /// <summary>
        /// Gcalth property
        /// </summary>
        [XmlEnum("Gcal[th]")]
        Gcalth,
        /// <summary>
        /// GeV property
        /// </summary>
        GeV,
        /// <summary>
        /// GJ property
        /// </summary>
        GJ,
        /// <summary>
        /// GWh property
        /// </summary>
        [XmlEnum("GW.h")]
        GWh,
        /// <summary>
        /// hph property
        /// </summary>
        [XmlEnum("hp.h")]
        hph,
        /// <summary>
        /// hpmetrich property
        /// </summary>
        [XmlEnum("hp[metric].h")]
        hpmetrich,
        /// <summary>
        /// J property
        /// </summary>
        J,
        /// <summary>
        /// kcalth property
        /// </summary>
        [XmlEnum("kcal[th]")]
        kcalth,
        /// <summary>
        /// keV property
        /// </summary>
        keV,
        /// <summary>
        /// kJ property
        /// </summary>
        kJ,
        /// <summary>
        /// kWh property
        /// </summary>
        [XmlEnum("kW.h")]
        kWh,
        /// <summary>
        /// mcalth property
        /// </summary>
        [XmlEnum("mcal[th]")]
        mcalth,
        /// <summary>
        /// Mcalth property
        /// </summary>
        [XmlEnum("Mcal[th]")]
        Mcalth,
        /// <summary>
        /// meV property
        /// </summary>
        meV,
        /// <summary>
        /// MeV property
        /// </summary>
        MeV,
        /// <summary>
        /// MJ property
        /// </summary>
        MJ,
        /// <summary>
        /// mJ property
        /// </summary>
        mJ,
        /// <summary>
        /// MWh property
        /// </summary>
        [XmlEnum("MW.h")]
        MWh,
        /// <summary>
        /// ncalth property
        /// </summary>
        [XmlEnum("ncal[th]")]
        ncalth,
        /// <summary>
        /// neV property
        /// </summary>
        neV,
        /// <summary>
        /// nJ property
        /// </summary>
        nJ,
        /// <summary>
        /// pcalth property
        /// </summary>
        [XmlEnum("pcal[th]")]
        pcalth,
        /// <summary>
        /// peV property
        /// </summary>
        peV,
        /// <summary>
        /// pJ property
        /// </summary>
        pJ,
        /// <summary>
        /// quad property
        /// </summary>
        quad,
        /// <summary>
        /// Tcalth property
        /// </summary>
        [XmlEnum("Tcal[th]")]
        Tcalth,
        /// <summary>
        /// TeV property
        /// </summary>
        TeV,
        /// <summary>
        /// thermEC property
        /// </summary>
        [XmlEnum("therm[EC]")]
        thermEC,
        /// <summary>
        /// thermUK property
        /// </summary>
        [XmlEnum("therm[UK]")]
        thermUK,
        /// <summary>
        /// thermUS property
        /// </summary>
        [XmlEnum("therm[US]")]
        thermUS,
        /// <summary>
        /// TJ property
        /// </summary>
        TJ,
        /// <summary>
        /// TWh property
        /// </summary>
        [XmlEnum("TW.h")]
        TWh,
        /// <summary>
        /// ucalth property
        /// </summary>
        [XmlEnum("ucal[th]")]
        ucalth,
        /// <summary>
        /// ueV property
        /// </summary>
        ueV,
        /// <summary>
        /// uJ property
        /// </summary>
        uJ
    }
    /// <summary>
    /// This class represents the AnglePerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AnglePerLengthUom xsd enumeration.")]
    public enum AnglePerLengthUom
    {
        /// <summary>
        /// Item001degaft property
        /// </summary>
        [XmlEnum("0.01 dega/ft")]
        Item001degaft,
        /// <summary>
        /// Item130degaft property
        /// </summary>
        [XmlEnum("1/30 dega/ft")]
        Item130degaft,
        /// <summary>
        /// Item130degam property
        /// </summary>
        [XmlEnum("1/30 dega/m")]
        Item130degam,
        /// <summary>
        /// degaft property
        /// </summary>
        [XmlEnum("dega/ft")]
        degaft,
        /// <summary>
        /// degam property
        /// </summary>
        [XmlEnum("dega/m")]
        degam,
        /// <summary>
        /// radft property
        /// </summary>
        [XmlEnum("rad/ft")]
        radft,
        /// <summary>
        /// radm property
        /// </summary>
        [XmlEnum("rad/m")]
        radm,
        /// <summary>
        /// revft property
        /// </summary>
        [XmlEnum("rev/ft")]
        revft,
        /// <summary>
        /// revm property
        /// </summary>
        [XmlEnum("rev/m")]
        revm
    }
    /// <summary>
    /// This class represents the VerticalCoordinateUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VerticalCoordinateUom xsd enumeration.")]
    public enum VerticalCoordinateUom
    {
        /// <summary>
        /// m property
        /// </summary>
        m,
        /// <summary>
        /// ft property
        /// </summary>
        ft,
        /// <summary>
        /// ftUS property
        /// </summary>
        ftUS,
        /// <summary>
        /// ftBr65 property
        /// </summary>
        [XmlEnum("ftBr(65)")]
        ftBr65
    }
    /// <summary>
    /// This class represents the VolumePerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerLengthUom xsd enumeration.")]
    public enum VolumePerLengthUom
    {
        /// <summary>
        /// Item001dm3km property
        /// </summary>
        [XmlEnum("0.01 dm3/km")]
        Item001dm3km,
        /// <summary>
        /// Item001Lkm property
        /// </summary>
        [XmlEnum("0.01 L/km")]
        Item001Lkm,
        /// <summary>
        /// bblft property
        /// </summary>
        [XmlEnum("bbl/ft")]
        bblft,
        /// <summary>
        /// bblin property
        /// </summary>
        [XmlEnum("bbl/in")]
        bblin,
        /// <summary>
        /// bblmi property
        /// </summary>
        [XmlEnum("bbl/mi")]
        bblmi,
        /// <summary>
        /// dm3m property
        /// </summary>
        [XmlEnum("dm3/m")]
        dm3m,
        /// <summary>
        /// ft3ft property
        /// </summary>
        [XmlEnum("ft3/ft")]
        ft3ft,
        /// <summary>
        /// galUKmi property
        /// </summary>
        [XmlEnum("gal[UK]/mi")]
        galUKmi,
        /// <summary>
        /// galUSft property
        /// </summary>
        [XmlEnum("gal[US]/ft")]
        galUSft,
        /// <summary>
        /// galUSmi property
        /// </summary>
        [XmlEnum("gal[US]/mi")]
        galUSmi,
        /// <summary>
        /// in3ft property
        /// </summary>
        [XmlEnum("in3/ft")]
        in3ft,
        /// <summary>
        /// Lm property
        /// </summary>
        [XmlEnum("L/m")]
        Lm,
        /// <summary>
        /// m3km property
        /// </summary>
        [XmlEnum("m3/km")]
        m3km,
        /// <summary>
        /// m3m property
        /// </summary>
        [XmlEnum("m3/m")]
        m3m
    }
    /// <summary>
    /// This class represents the EnergyPerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the EnergyPerVolumeUom xsd enumeration.")]
    public enum EnergyPerVolumeUom
    {
        /// <summary>
        /// BtuITbbl property
        /// </summary>
        [XmlEnum("Btu[IT]/bbl")]
        BtuITbbl,
        /// <summary>
        /// BtuITft3 property
        /// </summary>
        [XmlEnum("Btu[IT]/ft3")]
        BtuITft3,
        /// <summary>
        /// BtuITgalUK property
        /// </summary>
        [XmlEnum("Btu[IT]/gal[UK]")]
        BtuITgalUK,
        /// <summary>
        /// BtuITgalUS property
        /// </summary>
        [XmlEnum("Btu[IT]/gal[US]")]
        BtuITgalUS,
        /// <summary>
        /// calthcm3 property
        /// </summary>
        [XmlEnum("cal[th]/cm3")]
        calthcm3,
        /// <summary>
        /// calthmL property
        /// </summary>
        [XmlEnum("cal[th]/mL")]
        calthmL,
        /// <summary>
        /// calthmm3 property
        /// </summary>
        [XmlEnum("cal[th]/mm3")]
        calthmm3,
        /// <summary>
        /// ergcm3 property
        /// </summary>
        [XmlEnum("erg/cm3")]
        ergcm3,
        /// <summary>
        /// ergm3 property
        /// </summary>
        [XmlEnum("erg/m3")]
        ergm3,
        /// <summary>
        /// hphbbl property
        /// </summary>
        [XmlEnum("hp.h/bbl")]
        hphbbl,
        /// <summary>
        /// Jdm3 property
        /// </summary>
        [XmlEnum("J/dm3")]
        Jdm3,
        /// <summary>
        /// Jm3 property
        /// </summary>
        [XmlEnum("J/m3")]
        Jm3,
        /// <summary>
        /// kcalthcm3 property
        /// </summary>
        [XmlEnum("kcal[th]/cm3")]
        kcalthcm3,
        /// <summary>
        /// kcalthm3 property
        /// </summary>
        [XmlEnum("kcal[th]/m3")]
        kcalthm3,
        /// <summary>
        /// kJdm3 property
        /// </summary>
        [XmlEnum("kJ/dm3")]
        kJdm3,
        /// <summary>
        /// kJm3 property
        /// </summary>
        [XmlEnum("kJ/m3")]
        kJm3,
        /// <summary>
        /// kWhdm3 property
        /// </summary>
        [XmlEnum("kW.h/dm3")]
        kWhdm3,
        /// <summary>
        /// kWhm3 property
        /// </summary>
        [XmlEnum("kW.h/m3")]
        kWhm3,
        /// <summary>
        /// lbfftbbl property
        /// </summary>
        [XmlEnum("lbf.ft/bbl")]
        lbfftbbl,
        /// <summary>
        /// lbfftgalUS property
        /// </summary>
        [XmlEnum("lbf.ft/gal[US]")]
        lbfftgalUS,
        /// <summary>
        /// MJm3 property
        /// </summary>
        [XmlEnum("MJ/m3")]
        MJm3,
        /// <summary>
        /// MWhm3 property
        /// </summary>
        [XmlEnum("MW.h/m3")]
        MWhm3,
        /// <summary>
        /// tonfUSmibbl property
        /// </summary>
        [XmlEnum("tonf[US].mi/bbl")]
        tonfUSmibbl
    }
    /// <summary>
    /// This class represents the MagneticPermeabilityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MagneticPermeabilityUom xsd enumeration.")]
    public enum MagneticPermeabilityUom
    {
        /// <summary>
        /// Hm property
        /// </summary>
        [XmlEnum("H/m")]
        Hm,
        /// <summary>
        /// uHm property
        /// </summary>
        [XmlEnum("uH/m")]
        uHm
    }
    /// <summary>
    /// This class represents the ReciprocalMassUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReciprocalMassUom xsd enumeration.")]
    public enum ReciprocalMassUom
    {
        /// <summary>
        /// Item1g property
        /// </summary>
        [XmlEnum("1/g")]
        Item1g,
        /// <summary>
        /// Item1kg property
        /// </summary>
        [XmlEnum("1/kg")]
        Item1kg,
        /// <summary>
        /// Item1lbm property
        /// </summary>
        [XmlEnum("1/lbm")]
        Item1lbm
    }
    /// <summary>
    /// This class represents the DynamicViscosityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the DynamicViscosityUom xsd enumeration.")]
    public enum DynamicViscosityUom
    {
        /// <summary>
        /// cP property
        /// </summary>
        cP,
        /// <summary>
        /// dP property
        /// </summary>
        dP,
        /// <summary>
        /// dynescm2 property
        /// </summary>
        [XmlEnum("dyne.s/cm2")]
        dynescm2,
        /// <summary>
        /// EP property
        /// </summary>
        EP,
        /// <summary>
        /// fP property
        /// </summary>
        fP,
        /// <summary>
        /// GP property
        /// </summary>
        GP,
        /// <summary>
        /// kgfsm2 property
        /// </summary>
        [XmlEnum("kgf.s/m2")]
        kgfsm2,
        /// <summary>
        /// kP property
        /// </summary>
        kP,
        /// <summary>
        /// lbfsft2 property
        /// </summary>
        [XmlEnum("lbf.s/ft2")]
        lbfsft2,
        /// <summary>
        /// lbfsin2 property
        /// </summary>
        [XmlEnum("lbf.s/in2")]
        lbfsin2,
        /// <summary>
        /// mP property
        /// </summary>
        mP,
        /// <summary>
        /// MP property
        /// </summary>
        MP,
        /// <summary>
        /// mPas property
        /// </summary>
        [XmlEnum("mPa.s")]
        mPas,
        /// <summary>
        /// Nsm2 property
        /// </summary>
        [XmlEnum("N.s/m2")]
        Nsm2,
        /// <summary>
        /// nP property
        /// </summary>
        nP,
        /// <summary>
        /// P property
        /// </summary>
        P,
        /// <summary>
        /// Pas property
        /// </summary>
        [XmlEnum("Pa.s")]
        Pas,
        /// <summary>
        /// pP property
        /// </summary>
        pP,
        /// <summary>
        /// psis property
        /// </summary>
        [XmlEnum("psi.s")]
        psis,
        /// <summary>
        /// TP property
        /// </summary>
        TP,
        /// <summary>
        /// uP property
        /// </summary>
        uP
    }
    /// <summary>
    /// This class represents the PotentialDifferencePerPowerDropUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PotentialDifferencePerPowerDropUom xsd enumeration.")]
    public enum PotentialDifferencePerPowerDropUom
    {
        /// <summary>
        /// VB property
        /// </summary>
        [XmlEnum("V/B")]
        VB,
        /// <summary>
        /// VdB property
        /// </summary>
        [XmlEnum("V/dB")]
        VdB
    }
    /// <summary>
    /// This class represents the AreaPerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AreaPerTimeUom xsd enumeration.")]
    public enum AreaPerTimeUom
    {
        /// <summary>
        /// cm2s property
        /// </summary>
        [XmlEnum("cm2/s")]
        cm2s,
        /// <summary>
        /// ft2h property
        /// </summary>
        [XmlEnum("ft2/h")]
        ft2h,
        /// <summary>
        /// ft2s property
        /// </summary>
        [XmlEnum("ft2/s")]
        ft2s,
        /// <summary>
        /// in2s property
        /// </summary>
        [XmlEnum("in2/s")]
        in2s,
        /// <summary>
        /// m2d property
        /// </summary>
        [XmlEnum("m2/d")]
        m2d,
        /// <summary>
        /// m2h property
        /// </summary>
        [XmlEnum("m2/h")]
        m2h,
        /// <summary>
        /// m2s property
        /// </summary>
        [XmlEnum("m2/s")]
        m2s,
        /// <summary>
        /// mm2s property
        /// </summary>
        [XmlEnum("mm2/s")]
        mm2s
    }
    /// <summary>
    /// This class represents the HeatCapacityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the HeatCapacityUom xsd enumeration.")]
    public enum HeatCapacityUom
    {
        /// <summary>
        /// JdeltaK property
        /// </summary>
        [XmlEnum("J/deltaK")]
        JdeltaK
    }
    /// <summary>
    /// This class represents the ThermodynamicTemperaturePerThermodynamicTemperatureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ThermodynamicTemperaturePerThermodynamicTemperatureUom xsd enumeration.")]
    public enum ThermodynamicTemperaturePerThermodynamicTemperatureUom
    {
        /// <summary>
        /// degCdegC property
        /// </summary>
        [XmlEnum("degC/degC")]
        degCdegC,
        /// <summary>
        /// degFdegF property
        /// </summary>
        [XmlEnum("degF/degF")]
        degFdegF,
        /// <summary>
        /// degRdegR property
        /// </summary>
        [XmlEnum("degR/degR")]
        degRdegR,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// KK property
        /// </summary>
        [XmlEnum("K/K")]
        KK
    }
    /// <summary>
    /// This class represents the MolarEnergyUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MolarEnergyUom xsd enumeration.")]
    public enum MolarEnergyUom
    {
        /// <summary>
        /// BtuITlbmol property
        /// </summary>
        [XmlEnum("Btu[IT]/lbmol")]
        BtuITlbmol,
        /// <summary>
        /// Jmol property
        /// </summary>
        [XmlEnum("J/mol")]
        Jmol,
        /// <summary>
        /// kcalthmol property
        /// </summary>
        [XmlEnum("kcal[th]/mol")]
        kcalthmol,
        /// <summary>
        /// kJkmol property
        /// </summary>
        [XmlEnum("kJ/kmol")]
        kJkmol,
        /// <summary>
        /// MJkmol property
        /// </summary>
        [XmlEnum("MJ/kmol")]
        MJkmol
    }
    /// <summary>
    /// This class represents the ElectricConductanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricConductanceUom xsd enumeration.")]
    public enum ElectricConductanceUom
    {
        /// <summary>
        /// cS property
        /// </summary>
        cS,
        /// <summary>
        /// dS property
        /// </summary>
        dS,
        /// <summary>
        /// ES property
        /// </summary>
        ES,
        /// <summary>
        /// fS property
        /// </summary>
        fS,
        /// <summary>
        /// GS property
        /// </summary>
        GS,
        /// <summary>
        /// kS property
        /// </summary>
        kS,
        /// <summary>
        /// mS property
        /// </summary>
        mS,
        /// <summary>
        /// MS property
        /// </summary>
        MS,
        /// <summary>
        /// nS property
        /// </summary>
        nS,
        /// <summary>
        /// pS property
        /// </summary>
        pS,
        /// <summary>
        /// S property
        /// </summary>
        S,
        /// <summary>
        /// TS property
        /// </summary>
        TS,
        /// <summary>
        /// uS property
        /// </summary>
        uS
    }
    /// <summary>
    /// This class represents the MomentumUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MomentumUom xsd enumeration.")]
    public enum MomentumUom
    {
        /// <summary>
        /// kgms property
        /// </summary>
        [XmlEnum("kg.m/s")]
        kgms,
        /// <summary>
        /// lbmfts property
        /// </summary>
        [XmlEnum("lbm.ft/s")]
        lbmfts
    }
    /// <summary>
    /// This class represents the MassPerTimePerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MassPerTimePerAreaUom xsd enumeration.")]
    public enum MassPerTimePerAreaUom
    {
        /// <summary>
        /// gftcm3s property
        /// </summary>
        [XmlEnum("g.ft/(cm3.s)")]
        gftcm3s,
        /// <summary>
        /// gmcm3s property
        /// </summary>
        [XmlEnum("g.m/(cm3.s)")]
        gmcm3s,
        /// <summary>
        /// kgm2s property
        /// </summary>
        [XmlEnum("kg/(m2.s)")]
        kgm2s,
        /// <summary>
        /// kPasm property
        /// </summary>
        [XmlEnum("kPa.s/m")]
        kPasm,
        /// <summary>
        /// lbmft2h property
        /// </summary>
        [XmlEnum("lbm/(ft2.h)")]
        lbmft2h,
        /// <summary>
        /// lbmft2s property
        /// </summary>
        [XmlEnum("lbm/(ft2.s)")]
        lbmft2s,
        /// <summary>
        /// MPasm property
        /// </summary>
        [XmlEnum("MPa.s/m")]
        MPasm
    }
    /// <summary>
    /// This class represents the PowerPerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PowerPerVolumeUom xsd enumeration.")]
    public enum PowerPerVolumeUom
    {
        /// <summary>
        /// BtuIThft3 property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft3)")]
        BtuIThft3,
        /// <summary>
        /// BtuITsft3 property
        /// </summary>
        [XmlEnum("Btu[IT]/(s.ft3)")]
        BtuITsft3,
        /// <summary>
        /// calthhcm3 property
        /// </summary>
        [XmlEnum("cal[th]/(h.cm3)")]
        calthhcm3,
        /// <summary>
        /// calthscm3 property
        /// </summary>
        [XmlEnum("cal[th]/(s.cm3)")]
        calthscm3,
        /// <summary>
        /// hpft3 property
        /// </summary>
        [XmlEnum("hp/ft3")]
        hpft3,
        /// <summary>
        /// kWm3 property
        /// </summary>
        [XmlEnum("kW/m3")]
        kWm3,
        /// <summary>
        /// uWm3 property
        /// </summary>
        [XmlEnum("uW/m3")]
        uWm3,
        /// <summary>
        /// Wm3 property
        /// </summary>
        [XmlEnum("W/m3")]
        Wm3
    }
    /// <summary>
    /// This class represents the FrequencyUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the FrequencyUom xsd enumeration.")]
    public enum FrequencyUom
    {
        /// <summary>
        /// cHz property
        /// </summary>
        cHz,
        /// <summary>
        /// dHz property
        /// </summary>
        dHz,
        /// <summary>
        /// EHz property
        /// </summary>
        EHz,
        /// <summary>
        /// fHz property
        /// </summary>
        fHz,
        /// <summary>
        /// GHz property
        /// </summary>
        GHz,
        /// <summary>
        /// Hz property
        /// </summary>
        Hz,
        /// <summary>
        /// kHz property
        /// </summary>
        kHz,
        /// <summary>
        /// mHz property
        /// </summary>
        mHz,
        /// <summary>
        /// MHz property
        /// </summary>
        MHz,
        /// <summary>
        /// nHz property
        /// </summary>
        nHz,
        /// <summary>
        /// pHz property
        /// </summary>
        pHz,
        /// <summary>
        /// THz property
        /// </summary>
        THz,
        /// <summary>
        /// uHz property
        /// </summary>
        uHz
    }
    /// <summary>
    /// This class represents the LuminousIntensityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LuminousIntensityUom xsd enumeration.")]
    public enum LuminousIntensityUom
    {
        /// <summary>
        /// cd property
        /// </summary>
        cd,
        /// <summary>
        /// kcd property
        /// </summary>
        kcd
    }
    /// <summary>
    /// This class represents the AbsorbedDoseUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AbsorbedDoseUom xsd enumeration.")]
    public enum AbsorbedDoseUom
    {
        /// <summary>
        /// cGy property
        /// </summary>
        cGy,
        /// <summary>
        /// crd property
        /// </summary>
        crd,
        /// <summary>
        /// dGy property
        /// </summary>
        dGy,
        /// <summary>
        /// drd property
        /// </summary>
        drd,
        /// <summary>
        /// EGy property
        /// </summary>
        EGy,
        /// <summary>
        /// Erd property
        /// </summary>
        Erd,
        /// <summary>
        /// fGy property
        /// </summary>
        fGy,
        /// <summary>
        /// frd property
        /// </summary>
        frd,
        /// <summary>
        /// GGy property
        /// </summary>
        GGy,
        /// <summary>
        /// Grd property
        /// </summary>
        Grd,
        /// <summary>
        /// Gy property
        /// </summary>
        Gy,
        /// <summary>
        /// kGy property
        /// </summary>
        kGy,
        /// <summary>
        /// krd property
        /// </summary>
        krd,
        /// <summary>
        /// mGy property
        /// </summary>
        mGy,
        /// <summary>
        /// MGy property
        /// </summary>
        MGy,
        /// <summary>
        /// Mrd property
        /// </summary>
        Mrd,
        /// <summary>
        /// mrd property
        /// </summary>
        mrd,
        /// <summary>
        /// nGy property
        /// </summary>
        nGy,
        /// <summary>
        /// nrd property
        /// </summary>
        nrd,
        /// <summary>
        /// pGy property
        /// </summary>
        pGy,
        /// <summary>
        /// prd property
        /// </summary>
        prd,
        /// <summary>
        /// rd property
        /// </summary>
        rd,
        /// <summary>
        /// TGy property
        /// </summary>
        TGy,
        /// <summary>
        /// Trd property
        /// </summary>
        Trd,
        /// <summary>
        /// uGy property
        /// </summary>
        uGy,
        /// <summary>
        /// urd property
        /// </summary>
        urd
    }
    /// <summary>
    /// This class represents the TimePerMassUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the TimePerMassUom xsd enumeration.")]
    public enum TimePerMassUom
    {
        /// <summary>
        /// skg property
        /// </summary>
        [XmlEnum("s/kg")]
        skg
    }
    /// <summary>
    /// This class represents the VolumetricHeatTransferCoefficientUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumetricHeatTransferCoefficientUom xsd enumeration.")]
    public enum VolumetricHeatTransferCoefficientUom
    {
        /// <summary>
        /// BtuIThft3deltaF property
        /// </summary>
        [XmlEnum("Btu[IT]/(h.ft3.deltaF)")]
        BtuIThft3deltaF,
        /// <summary>
        /// BtuITsft3deltaF property
        /// </summary>
        [XmlEnum("Btu[IT]/(s.ft3.deltaF)")]
        BtuITsft3deltaF,
        /// <summary>
        /// kWm3deltaK property
        /// </summary>
        [XmlEnum("kW/(m3.deltaK)")]
        kWm3deltaK,
        /// <summary>
        /// Wm3deltaK property
        /// </summary>
        [XmlEnum("W/(m3.deltaK)")]
        Wm3deltaK
    }
    /// <summary>
    /// This class represents the NormalizedPowerUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the NormalizedPowerUom xsd enumeration.")]
    public enum NormalizedPowerUom
    {
        /// <summary>
        /// BW property
        /// </summary>
        [XmlEnum("B.W")]
        BW,
        /// <summary>
        /// dBmW property
        /// </summary>
        [XmlEnum("dB.mW")]
        dBmW,
        /// <summary>
        /// dBMW property
        /// </summary>
        [XmlEnum("dB.MW")]
        dBMW,
        /// <summary>
        /// dBW property
        /// </summary>
        [XmlEnum("dB.W")]
        dBW
    }
    /// <summary>
    /// This class represents the EnergyLengthPerTimeAreaTemperatureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the EnergyLengthPerTimeAreaTemperatureUom xsd enumeration.")]
    public enum EnergyLengthPerTimeAreaTemperatureUom
    {
        /// <summary>
        /// BtuITinhft2deltaF property
        /// </summary>
        [XmlEnum("Btu[IT].in/(h.ft2.deltaF)")]
        BtuITinhft2deltaF,
        /// <summary>
        /// Jmsm2deltaK property
        /// </summary>
        [XmlEnum("J.m/(s.m2.deltaK)")]
        Jmsm2deltaK,
        /// <summary>
        /// kJmhm2deltaK property
        /// </summary>
        [XmlEnum("kJ.m/(h.m2.deltaK)")]
        kJmhm2deltaK,
        /// <summary>
        /// WmdeltaK property
        /// </summary>
        [XmlEnum("W/(m.deltaK)")]
        WmdeltaK
    }
    /// <summary>
    /// This class represents the PressureTimePerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PressureTimePerVolumeUom xsd enumeration.")]
    public enum PressureTimePerVolumeUom
    {
        /// <summary>
        /// Pasm3 property
        /// </summary>
        [XmlEnum("Pa.s/m3")]
        Pasm3,
        /// <summary>
        /// psidbbl property
        /// </summary>
        [XmlEnum("psi.d/bbl")]
        psidbbl
    }
    /// <summary>
    /// This class represents the VolumePerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerVolumeUom xsd enumeration.")]
    public enum VolumePerVolumeUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// vol property
        /// </summary>
        [XmlEnum("%[vol]")]
        vol,
        /// <summary>
        /// Item0001bblft3 property
        /// </summary>
        [XmlEnum("0.001 bbl/ft3")]
        Item0001bblft3,
        /// <summary>
        /// Item0001bblm3 property
        /// </summary>
        [XmlEnum("0.001 bbl/m3")]
        Item0001bblm3,
        /// <summary>
        /// Item0001galUKbbl property
        /// </summary>
        [XmlEnum("0.001 gal[UK]/bbl")]
        Item0001galUKbbl,
        /// <summary>
        /// Item0001galUKgalUK property
        /// </summary>
        [XmlEnum("0.001 gal[UK]/gal[UK]")]
        Item0001galUKgalUK,
        /// <summary>
        /// Item0001galUSbbl property
        /// </summary>
        [XmlEnum("0.001 gal[US]/bbl")]
        Item0001galUSbbl,
        /// <summary>
        /// Item0001galUSft3 property
        /// </summary>
        [XmlEnum("0.001 gal[US]/ft3")]
        Item0001galUSft3,
        /// <summary>
        /// Item0001galUSgalUS property
        /// </summary>
        [XmlEnum("0.001 gal[US]/gal[US]")]
        Item0001galUSgalUS,
        /// <summary>
        /// Item0001ptUKbbl property
        /// </summary>
        [XmlEnum("0.001 pt[UK]/bbl")]
        Item0001ptUKbbl,
        /// <summary>
        /// Item001bblbbl property
        /// </summary>
        [XmlEnum("0.01 bbl/bbl")]
        Item001bblbbl,
        /// <summary>
        /// Item01galUSbbl property
        /// </summary>
        [XmlEnum("0.1 gal[US]/bbl")]
        Item01galUSbbl,
        /// <summary>
        /// Item01Lbbl property
        /// </summary>
        [XmlEnum("0.1 L/bbl")]
        Item01Lbbl,
        /// <summary>
        /// Item01ptUSbbl property
        /// </summary>
        [XmlEnum("0.1 pt[US]/bbl")]
        Item01ptUSbbl,
        /// <summary>
        /// Item1000ft3bbl property
        /// </summary>
        [XmlEnum("1000 ft3/bbl")]
        Item1000ft3bbl,
        /// <summary>
        /// Item1000m3m3 property
        /// </summary>
        [XmlEnum("1000 m3/m3")]
        Item1000m3m3,
        /// <summary>
        /// Item1E6acreftbbl property
        /// </summary>
        [XmlEnum("1E-6 acre.ft/bbl")]
        Item1E6acreftbbl,
        /// <summary>
        /// Item1E6bblft3 property
        /// </summary>
        [XmlEnum("1E-6 bbl/ft3")]
        Item1E6bblft3,
        /// <summary>
        /// Item1E6bblm3 property
        /// </summary>
        [XmlEnum("1E-6 bbl/m3")]
        Item1E6bblm3,
        /// <summary>
        /// Item1E6bblacreft property
        /// </summary>
        [XmlEnum("1E6 bbl/(acre.ft)")]
        Item1E6bblacreft,
        /// <summary>
        /// Item1E6ft3acreft property
        /// </summary>
        [XmlEnum("1E6 ft3/(acre.ft)")]
        Item1E6ft3acreft,
        /// <summary>
        /// Item1E6ft3bbl property
        /// </summary>
        [XmlEnum("1E6 ft3/bbl")]
        Item1E6ft3bbl,
        /// <summary>
        /// bblacreft property
        /// </summary>
        [XmlEnum("bbl/(acre.ft)")]
        bblacreft,
        /// <summary>
        /// bblbbl property
        /// </summary>
        [XmlEnum("bbl/bbl")]
        bblbbl,
        /// <summary>
        /// bblft3 property
        /// </summary>
        [XmlEnum("bbl/ft3")]
        bblft3,
        /// <summary>
        /// bblm3 property
        /// </summary>
        [XmlEnum("bbl/m3")]
        bblm3,
        /// <summary>
        /// cEuc property
        /// </summary>
        cEuc,
        /// <summary>
        /// cm3cm3 property
        /// </summary>
        [XmlEnum("cm3/cm3")]
        cm3cm3,
        /// <summary>
        /// cm3L property
        /// </summary>
        [XmlEnum("cm3/L")]
        cm3L,
        /// <summary>
        /// cm3m3 property
        /// </summary>
        [XmlEnum("cm3/m3")]
        cm3m3,
        /// <summary>
        /// dm3m3 property
        /// </summary>
        [XmlEnum("dm3/m3")]
        dm3m3,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// ft3bbl property
        /// </summary>
        [XmlEnum("ft3/bbl")]
        ft3bbl,
        /// <summary>
        /// ft3ft3 property
        /// </summary>
        [XmlEnum("ft3/ft3")]
        ft3ft3,
        /// <summary>
        /// galUKft3 property
        /// </summary>
        [XmlEnum("gal[UK]/ft3")]
        galUKft3,
        /// <summary>
        /// galUSbbl property
        /// </summary>
        [XmlEnum("gal[US]/bbl")]
        galUSbbl,
        /// <summary>
        /// galUSft3 property
        /// </summary>
        [XmlEnum("gal[US]/ft3")]
        galUSft3,
        /// <summary>
        /// Lm3 property
        /// </summary>
        [XmlEnum("L/m3")]
        Lm3,
        /// <summary>
        /// m3ham property
        /// </summary>
        [XmlEnum("m3/(ha.m)")]
        m3ham,
        /// <summary>
        /// m3bbl property
        /// </summary>
        [XmlEnum("m3/bbl")]
        m3bbl,
        /// <summary>
        /// m3m3 property
        /// </summary>
        [XmlEnum("m3/m3")]
        m3m3,
        /// <summary>
        /// mLgalUK property
        /// </summary>
        [XmlEnum("mL/gal[UK]")]
        mLgalUK,
        /// <summary>
        /// mLgalUS property
        /// </summary>
        [XmlEnum("mL/gal[US]")]
        mLgalUS,
        /// <summary>
        /// mLmL property
        /// </summary>
        [XmlEnum("mL/mL")]
        mLmL,
        /// <summary>
        /// ppk property
        /// </summary>
        ppk,
        /// <summary>
        /// ppm property
        /// </summary>
        ppm,
        /// <summary>
        /// ppmvol property
        /// </summary>
        [XmlEnum("ppm[vol]")]
        ppmvol
    }
    /// <summary>
    /// This class represents the AnglePerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AnglePerVolumeUom xsd enumeration.")]
    public enum AnglePerVolumeUom
    {
        /// <summary>
        /// radft3 property
        /// </summary>
        [XmlEnum("rad/ft3")]
        radft3,
        /// <summary>
        /// radm3 property
        /// </summary>
        [XmlEnum("rad/m3")]
        radm3
    }
    /// <summary>
    /// This class represents the DiffusionCoefficientUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the DiffusionCoefficientUom xsd enumeration.")]
    public enum DiffusionCoefficientUom
    {
        /// <summary>
        /// m2s property
        /// </summary>
        [XmlEnum("m2/s")]
        m2s
    }
    /// <summary>
    /// This class represents the TimePerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the TimePerTimeUom xsd enumeration.")]
    public enum TimePerTimeUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// mss property
        /// </summary>
        [XmlEnum("ms/s")]
        mss,
        /// <summary>
        /// ss property
        /// </summary>
        [XmlEnum("s/s")]
        ss
    }
    /// <summary>
    /// This class represents the PressurePerPressureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PressurePerPressureUom xsd enumeration.")]
    public enum PressurePerPressureUom
    {
        /// <summary>
        /// atmatm property
        /// </summary>
        [XmlEnum("atm/atm")]
        atmatm,
        /// <summary>
        /// barbar property
        /// </summary>
        [XmlEnum("bar/bar")]
        barbar,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// kPakPa property
        /// </summary>
        [XmlEnum("kPa/kPa")]
        kPakPa,
        /// <summary>
        /// MPaMPa property
        /// </summary>
        [XmlEnum("MPa/MPa")]
        MPaMPa,
        /// <summary>
        /// PaPa property
        /// </summary>
        [XmlEnum("Pa/Pa")]
        PaPa,
        /// <summary>
        /// psipsi property
        /// </summary>
        [XmlEnum("psi/psi")]
        psipsi
    }
    /// <summary>
    /// This class represents the EnergyPerMassPerTimeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the EnergyPerMassPerTimeUom xsd enumeration.")]
    public enum EnergyPerMassPerTimeUom
    {
        /// <summary>
        /// mremh property
        /// </summary>
        [XmlEnum("mrem/h")]
        mremh,
        /// <summary>
        /// mSvh property
        /// </summary>
        [XmlEnum("mSv/h")]
        mSvh,
        /// <summary>
        /// remh property
        /// </summary>
        [XmlEnum("rem/h")]
        remh,
        /// <summary>
        /// Svh property
        /// </summary>
        [XmlEnum("Sv/h")]
        Svh,
        /// <summary>
        /// Svs property
        /// </summary>
        [XmlEnum("Sv/s")]
        Svs
    }
    /// <summary>
    /// This class represents the VolumePerMassUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the VolumePerMassUom xsd enumeration.")]
    public enum VolumePerMassUom
    {
        /// <summary>
        /// Item001Lkg property
        /// </summary>
        [XmlEnum("0.01 L/kg")]
        Item001Lkg,
        /// <summary>
        /// bbltonUK property
        /// </summary>
        [XmlEnum("bbl/ton[UK]")]
        bbltonUK,
        /// <summary>
        /// bbltonUS property
        /// </summary>
        [XmlEnum("bbl/ton[US]")]
        bbltonUS,
        /// <summary>
        /// cm3g property
        /// </summary>
        [XmlEnum("cm3/g")]
        cm3g,
        /// <summary>
        /// dm3kg property
        /// </summary>
        [XmlEnum("dm3/kg")]
        dm3kg,
        /// <summary>
        /// dm3t property
        /// </summary>
        [XmlEnum("dm3/t")]
        dm3t,
        /// <summary>
        /// ft3kg property
        /// </summary>
        [XmlEnum("ft3/kg")]
        ft3kg,
        /// <summary>
        /// ft3lbm property
        /// </summary>
        [XmlEnum("ft3/lbm")]
        ft3lbm,
        /// <summary>
        /// ft3sack94lbm property
        /// </summary>
        [XmlEnum("ft3/sack[94lbm]")]
        ft3sack94lbm,
        /// <summary>
        /// galUKlbm property
        /// </summary>
        [XmlEnum("gal[UK]/lbm")]
        galUKlbm,
        /// <summary>
        /// galUSlbm property
        /// </summary>
        [XmlEnum("gal[US]/lbm")]
        galUSlbm,
        /// <summary>
        /// galUSsack94lbm property
        /// </summary>
        [XmlEnum("gal[US]/sack[94lbm]")]
        galUSsack94lbm,
        /// <summary>
        /// galUStonUK property
        /// </summary>
        [XmlEnum("gal[US]/ton[UK]")]
        galUStonUK,
        /// <summary>
        /// galUStonUS property
        /// </summary>
        [XmlEnum("gal[US]/ton[US]")]
        galUStonUS,
        /// <summary>
        /// Lkg property
        /// </summary>
        [XmlEnum("L/kg")]
        Lkg,
        /// <summary>
        /// Lt property
        /// </summary>
        [XmlEnum("L/t")]
        Lt,
        /// <summary>
        /// LtonUK property
        /// </summary>
        [XmlEnum("L/ton[UK]")]
        LtonUK,
        /// <summary>
        /// m3g property
        /// </summary>
        [XmlEnum("m3/g")]
        m3g,
        /// <summary>
        /// m3kg property
        /// </summary>
        [XmlEnum("m3/kg")]
        m3kg,
        /// <summary>
        /// m3t property
        /// </summary>
        [XmlEnum("m3/t")]
        m3t,
        /// <summary>
        /// m3tonUK property
        /// </summary>
        [XmlEnum("m3/ton[UK]")]
        m3tonUK,
        /// <summary>
        /// m3tonUS property
        /// </summary>
        [XmlEnum("m3/ton[US]")]
        m3tonUS
    }
    /// <summary>
    /// This class represents the TemperatureIntervalPerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the TemperatureIntervalPerLengthUom xsd enumeration.")]
    public enum TemperatureIntervalPerLengthUom
    {
        /// <summary>
        /// Item001deltaFft property
        /// </summary>
        [XmlEnum("0.01 deltaF/ft")]
        Item001deltaFft,
        /// <summary>
        /// deltaCft property
        /// </summary>
        [XmlEnum("deltaC/ft")]
        deltaCft,
        /// <summary>
        /// deltaChm property
        /// </summary>
        [XmlEnum("deltaC/hm")]
        deltaChm,
        /// <summary>
        /// deltaCkm property
        /// </summary>
        [XmlEnum("deltaC/km")]
        deltaCkm,
        /// <summary>
        /// deltaCm property
        /// </summary>
        [XmlEnum("deltaC/m")]
        deltaCm,
        /// <summary>
        /// deltaFft property
        /// </summary>
        [XmlEnum("deltaF/ft")]
        deltaFft,
        /// <summary>
        /// deltaFm property
        /// </summary>
        [XmlEnum("deltaF/m")]
        deltaFm,
        /// <summary>
        /// deltaKkm property
        /// </summary>
        [XmlEnum("deltaK/km")]
        deltaKkm,
        /// <summary>
        /// deltaKm property
        /// </summary>
        [XmlEnum("deltaK/m")]
        deltaKm
    }
    /// <summary>
    /// This class represents the AttenuationPerFrequencyIntervalUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AttenuationPerFrequencyIntervalUom xsd enumeration.")]
    public enum AttenuationPerFrequencyIntervalUom
    {
        /// <summary>
        /// BO property
        /// </summary>
        [XmlEnum("B/O")]
        BO,
        /// <summary>
        /// dBO property
        /// </summary>
        [XmlEnum("dB/O")]
        dBO
    }
    /// <summary>
    /// This class represents the IsothermalCompressibilityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the IsothermalCompressibilityUom xsd enumeration.")]
    public enum IsothermalCompressibilityUom
    {
        /// <summary>
        /// dm3kWh property
        /// </summary>
        [XmlEnum("dm3/(kW.h)")]
        dm3kWh,
        /// <summary>
        /// dm3MJ property
        /// </summary>
        [XmlEnum("dm3/MJ")]
        dm3MJ,
        /// <summary>
        /// m3kWh property
        /// </summary>
        [XmlEnum("m3/(kW.h)")]
        m3kWh,
        /// <summary>
        /// m3J property
        /// </summary>
        [XmlEnum("m3/J")]
        m3J,
        /// <summary>
        /// mm3J property
        /// </summary>
        [XmlEnum("mm3/J")]
        mm3J,
        /// <summary>
        /// ptUKhph property
        /// </summary>
        [XmlEnum("pt[UK]/(hp.h)")]
        ptUKhph
    }
    /// <summary>
    /// This class represents the ElectricResistanceUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricResistanceUom xsd enumeration.")]
    public enum ElectricResistanceUom
    {
        /// <summary>
        /// cohm property
        /// </summary>
        cohm,
        /// <summary>
        /// dohm property
        /// </summary>
        dohm,
        /// <summary>
        /// Eohm property
        /// </summary>
        Eohm,
        /// <summary>
        /// fohm property
        /// </summary>
        fohm,
        /// <summary>
        /// Gohm property
        /// </summary>
        Gohm,
        /// <summary>
        /// kohm property
        /// </summary>
        kohm,
        /// <summary>
        /// Mohm property
        /// </summary>
        Mohm,
        /// <summary>
        /// mohm property
        /// </summary>
        mohm,
        /// <summary>
        /// nohm property
        /// </summary>
        nohm,
        /// <summary>
        /// ohm property
        /// </summary>
        ohm,
        /// <summary>
        /// pohm property
        /// </summary>
        pohm,
        /// <summary>
        /// Tohm property
        /// </summary>
        Tohm,
        /// <summary>
        /// uohm property
        /// </summary>
        uohm
    }
    /// <summary>
    /// This class represents the ReciprocalVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReciprocalVolumeUom xsd enumeration.")]
    public enum ReciprocalVolumeUom
    {
        /// <summary>
        /// Item1bbl property
        /// </summary>
        [XmlEnum("1/bbl")]
        Item1bbl,
        /// <summary>
        /// Item1ft3 property
        /// </summary>
        [XmlEnum("1/ft3")]
        Item1ft3,
        /// <summary>
        /// Item1galUK property
        /// </summary>
        [XmlEnum("1/gal[UK]")]
        Item1galUK,
        /// <summary>
        /// Item1galUS property
        /// </summary>
        [XmlEnum("1/gal[US]")]
        Item1galUS,
        /// <summary>
        /// Item1L property
        /// </summary>
        [XmlEnum("1/L")]
        Item1L,
        /// <summary>
        /// Item1m3 property
        /// </summary>
        [XmlEnum("1/m3")]
        Item1m3
    }
    /// <summary>
    /// This class represents the PressureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the PressureUom xsd enumeration.")]
    public enum PressureUom
    {
        /// <summary>
        /// Item001lbfft2 property
        /// </summary>
        [XmlEnum("0.01 lbf/ft2")]
        Item001lbfft2,
        /// <summary>
        /// at property
        /// </summary>
        at,
        /// <summary>
        /// atm property
        /// </summary>
        atm,
        /// <summary>
        /// bar property
        /// </summary>
        bar,
        /// <summary>
        /// cmH2O4degC property
        /// </summary>
        [XmlEnum("cmH2O[4degC]")]
        cmH2O4degC,
        /// <summary>
        /// cPa property
        /// </summary>
        cPa,
        /// <summary>
        /// dPa property
        /// </summary>
        dPa,
        /// <summary>
        /// dynecm2 property
        /// </summary>
        [XmlEnum("dyne/cm2")]
        dynecm2,
        /// <summary>
        /// EPa property
        /// </summary>
        EPa,
        /// <summary>
        /// fPa property
        /// </summary>
        fPa,
        /// <summary>
        /// GPa property
        /// </summary>
        GPa,
        /// <summary>
        /// hbar property
        /// </summary>
        hbar,
        /// <summary>
        /// inH2O39degF property
        /// </summary>
        [XmlEnum("inH2O[39degF]")]
        inH2O39degF,
        /// <summary>
        /// inH2O60degF property
        /// </summary>
        [XmlEnum("inH2O[60degF]")]
        inH2O60degF,
        /// <summary>
        /// inHg32degF property
        /// </summary>
        [XmlEnum("inHg[32degF]")]
        inHg32degF,
        /// <summary>
        /// inHg60degF property
        /// </summary>
        [XmlEnum("inHg[60degF]")]
        inHg60degF,
        /// <summary>
        /// kgfcm2 property
        /// </summary>
        [XmlEnum("kgf/cm2")]
        kgfcm2,
        /// <summary>
        /// kgfm2 property
        /// </summary>
        [XmlEnum("kgf/m2")]
        kgfm2,
        /// <summary>
        /// kgfmm2 property
        /// </summary>
        [XmlEnum("kgf/mm2")]
        kgfmm2,
        /// <summary>
        /// kNm2 property
        /// </summary>
        [XmlEnum("kN/m2")]
        kNm2,
        /// <summary>
        /// kPa property
        /// </summary>
        kPa,
        /// <summary>
        /// kpsi property
        /// </summary>
        kpsi,
        /// <summary>
        /// lbfft2 property
        /// </summary>
        [XmlEnum("lbf/ft2")]
        lbfft2,
        /// <summary>
        /// mbar property
        /// </summary>
        mbar,
        /// <summary>
        /// mmHg0degC property
        /// </summary>
        [XmlEnum("mmHg[0degC]")]
        mmHg0degC,
        /// <summary>
        /// mPa property
        /// </summary>
        mPa,
        /// <summary>
        /// MPa property
        /// </summary>
        MPa,
        /// <summary>
        /// Mpsi property
        /// </summary>
        Mpsi,
        /// <summary>
        /// Nm2 property
        /// </summary>
        [XmlEnum("N/m2")]
        Nm2,
        /// <summary>
        /// Nmm2 property
        /// </summary>
        [XmlEnum("N/mm2")]
        Nmm2,
        /// <summary>
        /// nPa property
        /// </summary>
        nPa,
        /// <summary>
        /// Pa property
        /// </summary>
        Pa,
        /// <summary>
        /// pPa property
        /// </summary>
        pPa,
        /// <summary>
        /// psi property
        /// </summary>
        psi,
        /// <summary>
        /// tonfUKft2 property
        /// </summary>
        [XmlEnum("tonf[UK]/ft2")]
        tonfUKft2,
        /// <summary>
        /// tonfUSft2 property
        /// </summary>
        [XmlEnum("tonf[US]/ft2")]
        tonfUSft2,
        /// <summary>
        /// tonfUSin2 property
        /// </summary>
        [XmlEnum("tonf[US]/in2")]
        tonfUSin2,
        /// <summary>
        /// torr property
        /// </summary>
        torr,
        /// <summary>
        /// TPa property
        /// </summary>
        TPa,
        /// <summary>
        /// ubar property
        /// </summary>
        ubar,
        /// <summary>
        /// umHg0degC property
        /// </summary>
        [XmlEnum("umHg[0degC]")]
        umHg0degC,
        /// <summary>
        /// uPa property
        /// </summary>
        uPa,
        /// <summary>
        /// upsi property
        /// </summary>
        upsi
    }
    /// <summary>
    /// This class represents the AreaPerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AreaPerAreaUom xsd enumeration.")]
    public enum AreaPerAreaUom
    {
        /// <summary>
        /// Item property
        /// </summary>
        [XmlEnum("%")]
        Item,
        /// <summary>
        /// area property
        /// </summary>
        [XmlEnum("%[area]")]
        area,
        /// <summary>
        /// cEuc property
        /// </summary>
        cEuc,
        /// <summary>
        /// Euc property
        /// </summary>
        Euc,
        /// <summary>
        /// in2ft2 property
        /// </summary>
        [XmlEnum("in2/ft2")]
        in2ft2,
        /// <summary>
        /// in2in2 property
        /// </summary>
        [XmlEnum("in2/in2")]
        in2in2,
        /// <summary>
        /// m2m2 property
        /// </summary>
        [XmlEnum("m2/m2")]
        m2m2,
        /// <summary>
        /// mm2mm2 property
        /// </summary>
        [XmlEnum("mm2/mm2")]
        mm2mm2
    }
    /// <summary>
    /// This class represents the AngularVelocityUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the AngularVelocityUom xsd enumeration.")]
    public enum AngularVelocityUom
    {
        /// <summary>
        /// degah property
        /// </summary>
        [XmlEnum("dega/h")]
        degah,
        /// <summary>
        /// degamin property
        /// </summary>
        [XmlEnum("dega/min")]
        degamin,
        /// <summary>
        /// degas property
        /// </summary>
        [XmlEnum("dega/s")]
        degas,
        /// <summary>
        /// rads property
        /// </summary>
        [XmlEnum("rad/s")]
        rads,
        /// <summary>
        /// revs property
        /// </summary>
        [XmlEnum("rev/s")]
        revs,
        /// <summary>
        /// rpm property
        /// </summary>
        rpm
    }
    /// <summary>
    /// This class represents the TimePerVolumeUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the TimePerVolumeUom xsd enumeration.")]
    public enum TimePerVolumeUom
    {
        /// <summary>
        /// Item0001dft3 property
        /// </summary>
        [XmlEnum("0.001 d/ft3")]
        Item0001dft3,
        /// <summary>
        /// dbbl property
        /// </summary>
        [XmlEnum("d/bbl")]
        dbbl,
        /// <summary>
        /// dft3 property
        /// </summary>
        [XmlEnum("d/ft3")]
        dft3,
        /// <summary>
        /// dm3 property
        /// </summary>
        [XmlEnum("d/m3")]
        dm3,
        /// <summary>
        /// hft3 property
        /// </summary>
        [XmlEnum("h/ft3")]
        hft3,
        /// <summary>
        /// hm3 property
        /// </summary>
        [XmlEnum("h/m3")]
        hm3,
        /// <summary>
        /// sft3 property
        /// </summary>
        [XmlEnum("s/ft3")]
        sft3,
        /// <summary>
        /// sL property
        /// </summary>
        [XmlEnum("s/L")]
        sL,
        /// <summary>
        /// sm3 property
        /// </summary>
        [XmlEnum("s/m3")]
        sm3,
        /// <summary>
        /// sqtUK property
        /// </summary>
        [XmlEnum("s/qt[UK]")]
        sqtUK,
        /// <summary>
        /// sqtUS property
        /// </summary>
        [XmlEnum("s/qt[US]")]
        sqtUS
    }
    /// <summary>
    /// This class represents the EnergyLengthPerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the EnergyLengthPerAreaUom xsd enumeration.")]
    public enum EnergyLengthPerAreaUom
    {
        /// <summary>
        /// Jmm2 property
        /// </summary>
        [XmlEnum("J.m/m2")]
        Jmm2,
        /// <summary>
        /// kcalthmcm2 property
        /// </summary>
        [XmlEnum("kcal[th].m/cm2")]
        kcalthmcm2
    }
    /// <summary>
    /// This class represents the ElectricResistancePerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ElectricResistancePerLengthUom xsd enumeration.")]
    public enum ElectricResistancePerLengthUom
    {
        /// <summary>
        /// ohmm property
        /// </summary>
        [XmlEnum("ohm/m")]
        ohmm,
        /// <summary>
        /// uohmft property
        /// </summary>
        [XmlEnum("uohm/ft")]
        uohmft,
        /// <summary>
        /// uohmm property
        /// </summary>
        [XmlEnum("uohm/m")]
        uohmm
    }
    /// <summary>
    /// This class represents the ForcePerLengthUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ForcePerLengthUom xsd enumeration.")]
    public enum ForcePerLengthUom
    {
        /// <summary>
        /// Item001lbfft property
        /// </summary>
        [XmlEnum("0.01 lbf/ft")]
        Item001lbfft,
        /// <summary>
        /// Item130lbfm property
        /// </summary>
        [XmlEnum("1/30 lbf/m")]
        Item130lbfm,
        /// <summary>
        /// Item130Nm property
        /// </summary>
        [XmlEnum("1/30 N/m")]
        Item130Nm,
        /// <summary>
        /// dynecm property
        /// </summary>
        [XmlEnum("dyne/cm")]
        dynecm,
        /// <summary>
        /// kgfcm property
        /// </summary>
        [XmlEnum("kgf/cm")]
        kgfcm,
        /// <summary>
        /// kNm property
        /// </summary>
        [XmlEnum("kN/m")]
        kNm,
        /// <summary>
        /// lbfft property
        /// </summary>
        [XmlEnum("lbf/ft")]
        lbfft,
        /// <summary>
        /// lbfin property
        /// </summary>
        [XmlEnum("lbf/in")]
        lbfin,
        /// <summary>
        /// mNkm property
        /// </summary>
        [XmlEnum("mN/km")]
        mNkm,
        /// <summary>
        /// mNm property
        /// </summary>
        [XmlEnum("mN/m")]
        mNm,
        /// <summary>
        /// Nm property
        /// </summary>
        [XmlEnum("N/m")]
        Nm,
        /// <summary>
        /// pdlcm property
        /// </summary>
        [XmlEnum("pdl/cm")]
        pdlcm,
        /// <summary>
        /// tonfUKft property
        /// </summary>
        [XmlEnum("tonf[UK]/ft")]
        tonfUKft,
        /// <summary>
        /// tonfUSft property
        /// </summary>
        [XmlEnum("tonf[US]/ft")]
        tonfUSft
    }
    /// <summary>
    /// This class represents the ReciprocalPressureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReciprocalPressureUom xsd enumeration.")]
    public enum ReciprocalPressureUom
    {
        /// <summary>
        /// Item1bar property
        /// </summary>
        [XmlEnum("1/bar")]
        Item1bar,
        /// <summary>
        /// Item1kPa property
        /// </summary>
        [XmlEnum("1/kPa")]
        Item1kPa,
        /// <summary>
        /// Item1Pa property
        /// </summary>
        [XmlEnum("1/Pa")]
        Item1Pa,
        /// <summary>
        /// Item1pPa property
        /// </summary>
        [XmlEnum("1/pPa")]
        Item1pPa,
        /// <summary>
        /// Item1psi property
        /// </summary>
        [XmlEnum("1/psi")]
        Item1psi,
        /// <summary>
        /// Item1upsi property
        /// </summary>
        [XmlEnum("1/upsi")]
        Item1upsi
    }
    /// <summary>
    /// This class represents the LightExposureUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the LightExposureUom xsd enumeration.")]
    public enum LightExposureUom
    {
        /// <summary>
        /// footcandles property
        /// </summary>
        [XmlEnum("footcandle.s")]
        footcandles,
        /// <summary>
        /// lxs property
        /// </summary>
        [XmlEnum("lx.s")]
        lxs
    }
    /// <summary>
    /// This class represents the EnergyPerAreaUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the EnergyPerAreaUom xsd enumeration.")]
    public enum EnergyPerAreaUom
    {
        /// <summary>
        /// ergcm2 property
        /// </summary>
        [XmlEnum("erg/cm2")]
        ergcm2,
        /// <summary>
        /// Jcm2 property
        /// </summary>
        [XmlEnum("J/cm2")]
        Jcm2,
        /// <summary>
        /// Jm2 property
        /// </summary>
        [XmlEnum("J/m2")]
        Jm2,
        /// <summary>
        /// kgfmcm2 property
        /// </summary>
        [XmlEnum("kgf.m/cm2")]
        kgfmcm2,
        /// <summary>
        /// lbfftin2 property
        /// </summary>
        [XmlEnum("lbf.ft/in2")]
        lbfftin2,
        /// <summary>
        /// mJcm2 property
        /// </summary>
        [XmlEnum("mJ/cm2")]
        mJcm2,
        /// <summary>
        /// mJm2 property
        /// </summary>
        [XmlEnum("mJ/m2")]
        mJm2,
        /// <summary>
        /// Nm property
        /// </summary>
        [XmlEnum("N/m")]
        Nm
    }
    /// <summary>
    /// This class represents the MagneticDipoleMomentUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the MagneticDipoleMomentUom xsd enumeration.")]
    public enum MagneticDipoleMomentUom
    {
        /// <summary>
        /// Wbm property
        /// </summary>
        [XmlEnum("Wb.m")]
        Wbm
    }
    /// <summary>
    /// This class represents the DigitalStorageUom xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the DigitalStorageUom xsd enumeration.")]
    public enum DigitalStorageUom
    {
        /// <summary>
        /// bit property
        /// </summary>
        bit,
        /// <summary>
        /// byte property
        /// </summary>
        @byte,
        /// <summary>
        /// Kibyte property
        /// </summary>
        Kibyte,
        /// <summary>
        /// Mibyte property
        /// </summary>
        Mibyte
    }
    /// <summary>
    /// This class represents the ReferencePressureKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/commonv2")]
    [Description("This class represents the ReferencePressureKind xsd enumeration.")]
    public enum ReferencePressureKind
    {
        /// <summary>
        /// absolute property
        /// </summary>
        absolute,
        /// <summary>
        /// ambient property
        /// </summary>
        ambient,
        /// <summary>
        /// legal property
        /// </summary>
        legal
    }
    /// <summary>
    /// This class represents the Shape3d xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the Shape3d xsd enumeration.")]
    public enum Shape3d
    {
        /// <summary>
        /// sheet property
        /// </summary>
        sheet,
        /// <summary>
        /// dyke property
        /// </summary>
        dyke,
        /// <summary>
        /// dome property
        /// </summary>
        dome,
        /// <summary>
        /// mushroom property
        /// </summary>
        mushroom,
        /// <summary>
        /// channel property
        /// </summary>
        channel,
        /// <summary>
        /// delta property
        /// </summary>
        delta,
        /// <summary>
        /// dune property
        /// </summary>
        dune,
        /// <summary>
        /// fan property
        /// </summary>
        fan,
        /// <summary>
        /// reef property
        /// </summary>
        reef,
        /// <summary>
        /// wedge property
        /// </summary>
        wedge
    }
    /// <summary>
    /// This class represents the ThrowKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the ThrowKind xsd enumeration.")]
    public enum ThrowKind
    {
        /// <summary>
        /// reverse property
        /// </summary>
        reverse,
        /// <summary>
        /// normal property
        /// </summary>
        normal,
        /// <summary>
        /// thrust property
        /// </summary>
        thrust,
        /// <summary>
        /// strikeandslip property
        /// </summary>
        [XmlEnum("strike and slip")]
        strikeandslip,
        /// <summary>
        /// scissor property
        /// </summary>
        scissor,
        /// <summary>
        /// Used when a throw has different behaviors during its lifetime.
        /// </summary>
        variable
    }
    /// <summary>
    /// This class represents the IjkIndexableElements xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the IjkIndexableElements xsd enumeration.")]
    public enum IjkIndexableElements
    {
        /// <summary>
        /// Count = NI x NJ x NK
        /// </summary>
        cells,
        /// <summary>
        /// columnedges property
        /// </summary>
        [XmlEnum("column edges")]
        columnedges,
        /// <summary>
        /// Count = NI x NJ = #Columns = columnCount
        /// </summary>
        columns,
        /// <summary>
        /// coordinatelines property
        /// </summary>
        [XmlEnum("coordinate lines")]
        coordinatelines,
        /// <summary>
        /// Count = #Edges = edgeCount
        /// </summary>
        edges,
        /// <summary>
        /// edgespercolumn property
        /// </summary>
        [XmlEnum("edges per column")]
        edgespercolumn,
        /// <summary>
        /// Count = #Faces = #KFaces + #ColumnEdges x NK + #SplitFaces
        /// </summary>
        faces,
        /// <summary>
        /// facespercell property
        /// </summary>
        [XmlEnum("faces per cell")]
        facespercell,
        /// <summary>
        /// hingenodefaces property
        /// </summary>
        [XmlEnum("hinge node faces")]
        hingenodefaces,
        /// <summary>
        /// intervaledges property
        /// </summary>
        [XmlEnum("interval edges")]
        intervaledges,
        /// <summary>
        /// Count = NK + gapCount
        /// </summary>
        intervals,
        /// <summary>
        /// Count = NI
        /// </summary>
        I0,
        /// <summary>
        /// I0edges property
        /// </summary>
        [XmlEnum("I0 edges")]
        I0edges,
        /// <summary>
        /// Count = NJ
        /// </summary>
        J0,
        /// <summary>
        /// J0edges property
        /// </summary>
        [XmlEnum("J0 edges")]
        J0edges,
        /// <summary>
        /// Count = NK
        /// </summary>
        layers,
        /// <summary>
        /// Count = #Nodes = #CoordinateLines x NKL
        /// </summary>
        nodes,
        /// <summary>
        /// nodespercell property
        /// </summary>
        [XmlEnum("nodes per cell")]
        nodespercell,
        /// <summary>
        /// nodesperedge property
        /// </summary>
        [XmlEnum("nodes per edge")]
        nodesperedge,
        /// <summary>
        /// nodesperface property
        /// </summary>
        [XmlEnum("nodes per face")]
        nodesperface,
        /// <summary>
        /// Count = #Pillars = NIL x NJL + #SplitPillars
        /// </summary>
        pillars,
        /// <summary>
        /// radialoriginpolyline property
        /// </summary>
        [XmlEnum("radial origin polyline")]
        radialoriginpolyline,
        /// <summary>
        /// Count specified per subnode patch
        /// </summary>
        subnodes
    }
    /// <summary>
    /// This class represents the UnstructuredCellIndexableElements xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the UnstructuredCellIndexableElements xsd enumeration.")]
    public enum UnstructuredCellIndexableElements
    {
        /// <summary>
        /// Count = #Cells = cellCount
        /// </summary>
        cells,
        /// <summary>
        /// Count = #Edges = edgeCount
        /// </summary>
        edges,
        /// <summary>
        /// Count = #Faces = faceCount
        /// </summary>
        faces,
        /// <summary>
        /// facespercell property
        /// </summary>
        [XmlEnum("faces per cell")]
        facespercell,
        /// <summary>
        /// hingenodefaces property
        /// </summary>
        [XmlEnum("hinge node faces")]
        hingenodefaces,
        /// <summary>
        /// Count = #Nodes = nodeCount
        /// </summary>
        nodes,
        /// <summary>
        /// nodespercell property
        /// </summary>
        [XmlEnum("nodes per cell")]
        nodespercell,
        /// <summary>
        /// nodesperedge property
        /// </summary>
        [XmlEnum("nodes per edge")]
        nodesperedge,
        /// <summary>
        /// nodesperface property
        /// </summary>
        [XmlEnum("nodes per face")]
        nodesperface,
        /// <summary>
        /// Count specified per subnode patch
        /// </summary>
        subnodes
    }
    /// <summary>
    /// This class represents the UnstructuredColumnLayerIndexableElements xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the UnstructuredColumnLayerIndexableElements xsd enumeration.")]
    public enum UnstructuredColumnLayerIndexableElements
    {
        /// <summary>
        /// Count = #Columns x NK
        /// </summary>
        cells,
        /// <summary>
        /// columnedges property
        /// </summary>
        [XmlEnum("column edges")]
        columnedges,
        /// <summary>
        /// Count = #Columns = columnCount
        /// </summary>
        columns,
        /// <summary>
        /// coordinatelines property
        /// </summary>
        [XmlEnum("coordinate lines")]
        coordinatelines,
        /// <summary>
        /// Count = #Edges = edgeCount
        /// </summary>
        edges,
        /// <summary>
        /// edgespercolumn property
        /// </summary>
        [XmlEnum("edges per column")]
        edgespercolumn,
        /// <summary>
        /// Count = #KFaces + #ColumnEdges x NK
        /// </summary>
        faces,
        /// <summary>
        /// facespercell property
        /// </summary>
        [XmlEnum("faces per cell")]
        facespercell,
        /// <summary>
        /// hingenodefaces property
        /// </summary>
        [XmlEnum("hinge node faces")]
        hingenodefaces,
        /// <summary>
        /// intervaledges property
        /// </summary>
        [XmlEnum("interval edges")]
        intervaledges,
        /// <summary>
        /// Count = NK + gapCount Only needed if the Unstructured Column Layer indices are a component of GPGrid.
        /// </summary>
        intervals,
        /// <summary>
        /// Count = NK
        /// </summary>
        layers,
        /// <summary>
        /// Count = #CoordinateLines x NKL
        /// </summary>
        nodes,
        /// <summary>
        /// nodespercell property
        /// </summary>
        [XmlEnum("nodes per cell")]
        nodespercell,
        /// <summary>
        /// nodesperedge property
        /// </summary>
        [XmlEnum("nodes per edge")]
        nodesperedge,
        /// <summary>
        /// nodesperface property
        /// </summary>
        [XmlEnum("nodes per face")]
        nodesperface,
        /// <summary>
        /// Count = #Pillars = pillarCount
        /// </summary>
        pillars,
        /// <summary>
        /// Count specified per subnode patch
        /// </summary>
        subnodes
    }
    /// <summary>
    /// This class represents the Facet xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the Facet xsd enumeration.")]
    public enum Facet
    {
        /// <summary>
        /// I property
        /// </summary>
        I,
        /// <summary>
        /// J property
        /// </summary>
        J,
        /// <summary>
        /// K property
        /// </summary>
        K,
        /// <summary>
        /// X property
        /// </summary>
        X,
        /// <summary>
        /// Y property
        /// </summary>
        Y,
        /// <summary>
        /// Z property
        /// </summary>
        Z,
        /// <summary>
        /// I1 property
        /// </summary>
        [XmlEnum("I+")]
        I1,
        /// <summary>
        /// J1 property
        /// </summary>
        [XmlEnum("J+")]
        J1,
        /// <summary>
        /// K1 property
        /// </summary>
        [XmlEnum("K+")]
        K1,
        /// <summary>
        /// X1 property
        /// </summary>
        [XmlEnum("X+")]
        X1,
        /// <summary>
        /// Y1 property
        /// </summary>
        [XmlEnum("Y+")]
        Y1,
        /// <summary>
        /// Z1 property
        /// </summary>
        [XmlEnum("Z+")]
        Z1,
        /// <summary>
        /// I2 property
        /// </summary>
        [XmlEnum("I-")]
        I2,
        /// <summary>
        /// J2 property
        /// </summary>
        [XmlEnum("J-")]
        J2,
        /// <summary>
        /// K2 property
        /// </summary>
        [XmlEnum("K-")]
        K2,
        /// <summary>
        /// X2 property
        /// </summary>
        [XmlEnum("X-")]
        X2,
        /// <summary>
        /// Y2 property
        /// </summary>
        [XmlEnum("Y-")]
        Y2,
        /// <summary>
        /// Z2 property
        /// </summary>
        [XmlEnum("Z-")]
        Z2,
        /// <summary>
        /// net property
        /// </summary>
        net,
        /// <summary>
        /// gross property
        /// </summary>
        gross,
        /// <summary>
        /// plus property
        /// </summary>
        plus,
        /// <summary>
        /// minus property
        /// </summary>
        minus,
        /// <summary>
        /// Applies to statistics facet kind.
        /// </summary>
        average,
        /// <summary>
        /// Applies to statistics facet kind.
        /// </summary>
        maximum,
        /// <summary>
        /// Applies to statistics facet kind.
        /// </summary>
        minimum,
        /// <summary>
        /// maximumthreshold property
        /// </summary>
        [XmlEnum("maximum threshold")]
        maximumthreshold,
        /// <summary>
        /// minimumthreshold property
        /// </summary>
        [XmlEnum("minimum threshold")]
        minimumthreshold,
        /// <summary>
        /// surfacecondition property
        /// </summary>
        [XmlEnum("surface condition")]
        surfacecondition,
        /// <summary>
        /// reservoircondition property
        /// </summary>
        [XmlEnum("reservoir condition")]
        reservoircondition,
        /// <summary>
        /// Applies to what facet kind.
        /// </summary>
        oil,
        /// <summary>
        /// Applies to what facet kind.
        /// </summary>
        water,
        /// <summary>
        /// Applies to what facet kind.
        /// </summary>
        gas,
        /// <summary>
        /// Applies to what facet kind.
        /// </summary>
        condensate,
        /// <summary>
        /// Applies to statistics facet kind.
        /// </summary>
        cumulative
    }
    /// <summary>
    /// This class represents the ResqmlPropertyKind xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the ResqmlPropertyKind xsd enumeration.")]
    public enum ResqmlPropertyKind
    {
        /// <summary>
        /// absorbeddose property
        /// </summary>
        [XmlEnum("absorbed dose")]
        absorbeddose,
        /// <summary>
        /// accelerationlinear property
        /// </summary>
        [XmlEnum("acceleration linear")]
        accelerationlinear,
        /// <summary>
        /// active property
        /// </summary>
        active,
        /// <summary>
        /// activityofradioactivity property
        /// </summary>
        [XmlEnum("activity (of radioactivity)")]
        activityofradioactivity,
        /// <summary>
        /// amountofsubstance property
        /// </summary>
        [XmlEnum("amount of substance")]
        amountofsubstance,
        /// <summary>
        /// amplitude property
        /// </summary>
        amplitude,
        /// <summary>
        /// angleperlength property
        /// </summary>
        [XmlEnum("angle per length")]
        angleperlength,
        /// <summary>
        /// anglepertime property
        /// </summary>
        [XmlEnum("angle per time")]
        anglepertime,
        /// <summary>
        /// anglepervolume property
        /// </summary>
        [XmlEnum("angle per volume")]
        anglepervolume,
        /// <summary>
        /// angularacceleration property
        /// </summary>
        [XmlEnum("angular acceleration")]
        angularacceleration,
        /// <summary>
        /// area property
        /// </summary>
        area,
        /// <summary>
        /// attenuation property
        /// </summary>
        attenuation,
        /// <summary>
        /// areaperarea property
        /// </summary>
        [XmlEnum("area per area")]
        areaperarea,
        /// <summary>
        /// attenuationperlength property
        /// </summary>
        [XmlEnum("attenuation per length")]
        attenuationperlength,
        /// <summary>
        /// areapervolume property
        /// </summary>
        [XmlEnum("area per volume")]
        areapervolume,
        /// <summary>
        /// azimuth property
        /// </summary>
        azimuth,
        /// <summary>
        /// bubblepointpressure property
        /// </summary>
        [XmlEnum("bubble point pressure")]
        bubblepointpressure,
        /// <summary>
        /// bulkmodulus property
        /// </summary>
        [XmlEnum("bulk modulus")]
        bulkmodulus,
        /// <summary>
        /// capacitance property
        /// </summary>
        capacitance,
        /// <summary>
        /// categorical property
        /// </summary>
        categorical,
        /// <summary>
        /// celllength property
        /// </summary>
        [XmlEnum("cell length")]
        celllength,
        /// <summary>
        /// code property
        /// </summary>
        code,
        /// <summary>
        /// chargedensity property
        /// </summary>
        [XmlEnum("charge density")]
        chargedensity,
        /// <summary>
        /// compressibility property
        /// </summary>
        compressibility,
        /// <summary>
        /// chemicalpotential property
        /// </summary>
        [XmlEnum("chemical potential")]
        chemicalpotential,
        /// <summary>
        /// concentrationofB property
        /// </summary>
        [XmlEnum("concentration of B")]
        concentrationofB,
        /// <summary>
        /// conductivity property
        /// </summary>
        conductivity,
        /// <summary>
        /// continuous property
        /// </summary>
        continuous,
        /// <summary>
        /// crosssectionabsorption property
        /// </summary>
        [XmlEnum("cross section absorption")]
        crosssectionabsorption,
        /// <summary>
        /// currentdensity property
        /// </summary>
        [XmlEnum("current density")]
        currentdensity,
        /// <summary>
        /// Darcyflowcoefficient property
        /// </summary>
        [XmlEnum("Darcy flow coefficient")]
        Darcyflowcoefficient,
        /// <summary>
        /// datatransmissionspeed property
        /// </summary>
        [XmlEnum("data transmission speed")]
        datatransmissionspeed,
        /// <summary>
        /// deltatemperature property
        /// </summary>
        [XmlEnum("delta temperature")]
        deltatemperature,
        /// <summary>
        /// density property
        /// </summary>
        density,
        /// <summary>
        /// depth property
        /// </summary>
        depth,
        /// <summary>
        /// diffusioncoefficient property
        /// </summary>
        [XmlEnum("diffusion coefficient")]
        diffusioncoefficient,
        /// <summary>
        /// digitalstorage property
        /// </summary>
        [XmlEnum("digital storage")]
        digitalstorage,
        /// <summary>
        /// dimensionless property
        /// </summary>
        dimensionless,
        /// <summary>
        /// dip property
        /// </summary>
        dip,
        /// <summary>
        /// discrete property
        /// </summary>
        discrete,
        /// <summary>
        /// doseequivalent property
        /// </summary>
        [XmlEnum("dose equivalent")]
        doseequivalent,
        /// <summary>
        /// doseequivalentrate property
        /// </summary>
        [XmlEnum("dose equivalent rate")]
        doseequivalentrate,
        /// <summary>
        /// dynamicviscosity property
        /// </summary>
        [XmlEnum("dynamic viscosity")]
        dynamicviscosity,
        /// <summary>
        /// electriccharge property
        /// </summary>
        [XmlEnum("electric charge")]
        electriccharge,
        /// <summary>
        /// electricconductance property
        /// </summary>
        [XmlEnum("electric conductance")]
        electricconductance,
        /// <summary>
        /// electriccurrent property
        /// </summary>
        [XmlEnum("electric current")]
        electriccurrent,
        /// <summary>
        /// electricdipolemoment property
        /// </summary>
        [XmlEnum("electric dipole moment")]
        electricdipolemoment,
        /// <summary>
        /// electricfieldstrength property
        /// </summary>
        [XmlEnum("electric field strength")]
        electricfieldstrength,
        /// <summary>
        /// electricpolarization property
        /// </summary>
        [XmlEnum("electric polarization")]
        electricpolarization,
        /// <summary>
        /// electricpotential property
        /// </summary>
        [XmlEnum("electric potential")]
        electricpotential,
        /// <summary>
        /// electricalresistivity property
        /// </summary>
        [XmlEnum("electrical resistivity")]
        electricalresistivity,
        /// <summary>
        /// electrochemicalequivalent property
        /// </summary>
        [XmlEnum("electrochemical equivalent")]
        electrochemicalequivalent,
        /// <summary>
        /// electromagneticmoment property
        /// </summary>
        [XmlEnum("electromagnetic moment")]
        electromagneticmoment,
        /// <summary>
        /// energylengthperarea property
        /// </summary>
        [XmlEnum("energy length per area")]
        energylengthperarea,
        /// <summary>
        /// energylengthpertimeareatemperature property
        /// </summary>
        [XmlEnum("energy length per time area temperature")]
        energylengthpertimeareatemperature,
        /// <summary>
        /// energyperarea property
        /// </summary>
        [XmlEnum("energy per area")]
        energyperarea,
        /// <summary>
        /// energyperlength property
        /// </summary>
        [XmlEnum("energy per length")]
        energyperlength,
        /// <summary>
        /// equivalentpermass property
        /// </summary>
        [XmlEnum("equivalent per mass")]
        equivalentpermass,
        /// <summary>
        /// equivalentpervolume property
        /// </summary>
        [XmlEnum("equivalent per volume")]
        equivalentpervolume,
        /// <summary>
        /// exposureradioactivity property
        /// </summary>
        [XmlEnum("exposure (radioactivity)")]
        exposureradioactivity,
        /// <summary>
        /// faultblock property
        /// </summary>
        [XmlEnum("fault block")]
        faultblock,
        /// <summary>
        /// fluidvolume property
        /// </summary>
        [XmlEnum("fluid volume")]
        fluidvolume,
        /// <summary>
        /// force property
        /// </summary>
        force,
        /// <summary>
        /// forcearea property
        /// </summary>
        [XmlEnum("force area")]
        forcearea,
        /// <summary>
        /// forcelengthperlength property
        /// </summary>
        [XmlEnum("force length per length")]
        forcelengthperlength,
        /// <summary>
        /// forceperforce property
        /// </summary>
        [XmlEnum("force per force")]
        forceperforce,
        /// <summary>
        /// forceperlength property
        /// </summary>
        [XmlEnum("force per length")]
        forceperlength,
        /// <summary>
        /// forcepervolume property
        /// </summary>
        [XmlEnum("force per volume")]
        forcepervolume,
        /// <summary>
        /// formationvolumefactor property
        /// </summary>
        [XmlEnum("formation volume factor")]
        formationvolumefactor,
        /// <summary>
        /// frequency property
        /// </summary>
        frequency,
        /// <summary>
        /// frequencyinterval property
        /// </summary>
        [XmlEnum("frequency interval")]
        frequencyinterval,
        /// <summary>
        /// gammarayAPIunit property
        /// </summary>
        [XmlEnum("gamma ray API unit")]
        gammarayAPIunit,
        /// <summary>
        /// geologick property
        /// </summary>
        [XmlEnum("geologic k")]
        geologick,
        /// <summary>
        /// heatcapacity property
        /// </summary>
        [XmlEnum("heat capacity")]
        heatcapacity,
        /// <summary>
        /// heatflowrate property
        /// </summary>
        [XmlEnum("heat flow rate")]
        heatflowrate,
        /// <summary>
        /// heattransfercoefficient property
        /// </summary>
        [XmlEnum("heat transfer coefficient")]
        heattransfercoefficient,
        /// <summary>
        /// illuminance property
        /// </summary>
        illuminance,
        /// <summary>
        /// index property
        /// </summary>
        index,
        /// <summary>
        /// irradiance property
        /// </summary>
        irradiance,
        /// <summary>
        /// isothermalcompressibility property
        /// </summary>
        [XmlEnum("isothermal compressibility")]
        isothermalcompressibility,
        /// <summary>
        /// kinematicviscosity property
        /// </summary>
        [XmlEnum("kinematic viscosity")]
        kinematicviscosity,
        /// <summary>
        /// LambdaRho property
        /// </summary>
        [XmlEnum("Lambda Rho")]
        LambdaRho,
        /// <summary>
        /// Lameconstant property
        /// </summary>
        [XmlEnum("Lame constant")]
        Lameconstant,
        /// <summary>
        /// length property
        /// </summary>
        length,
        /// <summary>
        /// lengthperlength property
        /// </summary>
        [XmlEnum("length per length")]
        lengthperlength,
        /// <summary>
        /// lengthpertemperature property
        /// </summary>
        [XmlEnum("length per temperature")]
        lengthpertemperature,
        /// <summary>
        /// lengthpervolume property
        /// </summary>
        [XmlEnum("length per volume")]
        lengthpervolume,
        /// <summary>
        /// levelofpowerintensity property
        /// </summary>
        [XmlEnum("level of power intensity")]
        levelofpowerintensity,
        /// <summary>
        /// lightexposure property
        /// </summary>
        [XmlEnum("light exposure")]
        lightexposure,
        /// <summary>
        /// linearthermalexpansion property
        /// </summary>
        [XmlEnum("linear thermal expansion")]
        linearthermalexpansion,
        /// <summary>
        /// luminance property
        /// </summary>
        luminance,
        /// <summary>
        /// luminousefficacy property
        /// </summary>
        [XmlEnum("luminous efficacy")]
        luminousefficacy,
        /// <summary>
        /// luminousflux property
        /// </summary>
        [XmlEnum("luminous flux")]
        luminousflux,
        /// <summary>
        /// luminousintensity property
        /// </summary>
        [XmlEnum("luminous intensity")]
        luminousintensity,
        /// <summary>
        /// magneticdipolemoment property
        /// </summary>
        [XmlEnum("magnetic dipole moment")]
        magneticdipolemoment,
        /// <summary>
        /// magneticfieldstrength property
        /// </summary>
        [XmlEnum("magnetic field strength")]
        magneticfieldstrength,
        /// <summary>
        /// magneticflux property
        /// </summary>
        [XmlEnum("magnetic flux")]
        magneticflux,
        /// <summary>
        /// magneticinduction property
        /// </summary>
        [XmlEnum("magnetic induction")]
        magneticinduction,
        /// <summary>
        /// magneticpermeability property
        /// </summary>
        [XmlEnum("magnetic permeability")]
        magneticpermeability,
        /// <summary>
        /// magneticvectorpotential property
        /// </summary>
        [XmlEnum("magnetic vector potential")]
        magneticvectorpotential,
        /// <summary>
        /// mass property
        /// </summary>
        mass,
        /// <summary>
        /// massattenuationcoefficient property
        /// </summary>
        [XmlEnum("mass attenuation coefficient")]
        massattenuationcoefficient,
        /// <summary>
        /// massconcentration property
        /// </summary>
        [XmlEnum("mass concentration")]
        massconcentration,
        /// <summary>
        /// massflowrate property
        /// </summary>
        [XmlEnum("mass flow rate")]
        massflowrate,
        /// <summary>
        /// masslength property
        /// </summary>
        [XmlEnum("mass length")]
        masslength,
        /// <summary>
        /// massperenergy property
        /// </summary>
        [XmlEnum("mass per energy")]
        massperenergy,
        /// <summary>
        /// massperlength property
        /// </summary>
        [XmlEnum("mass per length")]
        massperlength,
        /// <summary>
        /// masspertimeperarea property
        /// </summary>
        [XmlEnum("mass per time per area")]
        masspertimeperarea,
        /// <summary>
        /// masspertimeperlength property
        /// </summary>
        [XmlEnum("mass per time per length")]
        masspertimeperlength,
        /// <summary>
        /// masspervolumeperlength property
        /// </summary>
        [XmlEnum("mass per volume per length")]
        masspervolumeperlength,
        /// <summary>
        /// mobility property
        /// </summary>
        mobility,
        /// <summary>
        /// modulusofcompression property
        /// </summary>
        [XmlEnum("modulus of compression")]
        modulusofcompression,
        /// <summary>
        /// molarconcentration property
        /// </summary>
        [XmlEnum("molar concentration")]
        molarconcentration,
        /// <summary>
        /// molarheatcapacity property
        /// </summary>
        [XmlEnum("molar heat capacity")]
        molarheatcapacity,
        /// <summary>
        /// molarvolume property
        /// </summary>
        [XmlEnum("molar volume")]
        molarvolume,
        /// <summary>
        /// moleperarea property
        /// </summary>
        [XmlEnum("mole per area")]
        moleperarea,
        /// <summary>
        /// molepertime property
        /// </summary>
        [XmlEnum("mole per time")]
        molepertime,
        /// <summary>
        /// molepertimeperarea property
        /// </summary>
        [XmlEnum("mole per time per area")]
        molepertimeperarea,
        /// <summary>
        /// momentofforce property
        /// </summary>
        [XmlEnum("moment of force")]
        momentofforce,
        /// <summary>
        /// momentofinertia property
        /// </summary>
        [XmlEnum("moment of inertia")]
        momentofinertia,
        /// <summary>
        /// momentofsection property
        /// </summary>
        [XmlEnum("moment of section")]
        momentofsection,
        /// <summary>
        /// momentum property
        /// </summary>
        momentum,
        /// <summary>
        /// MuRho property
        /// </summary>
        [XmlEnum("Mu Rho")]
        MuRho,
        /// <summary>
        /// nettogrossratio property
        /// </summary>
        [XmlEnum("net to gross ratio")]
        nettogrossratio,
        /// <summary>
        /// neutronAPIunit property
        /// </summary>
        [XmlEnum("neutron API unit")]
        neutronAPIunit,
        /// <summary>
        /// nonDarcyflowcoefficient property
        /// </summary>
        [XmlEnum("nonDarcy flow coefficient")]
        nonDarcyflowcoefficient,
        /// <summary>
        /// operationspertime property
        /// </summary>
        [XmlEnum("operations per time")]
        operationspertime,
        /// <summary>
        /// parachor property
        /// </summary>
        parachor,
        /// <summary>
        /// perarea property
        /// </summary>
        [XmlEnum("per area")]
        perarea,
        /// <summary>
        /// perelectricpotential property
        /// </summary>
        [XmlEnum("per electric potential")]
        perelectricpotential,
        /// <summary>
        /// perforce property
        /// </summary>
        [XmlEnum("per force")]
        perforce,
        /// <summary>
        /// perlength property
        /// </summary>
        [XmlEnum("per length")]
        perlength,
        /// <summary>
        /// permass property
        /// </summary>
        [XmlEnum("per mass")]
        permass,
        /// <summary>
        /// pervolume property
        /// </summary>
        [XmlEnum("per volume")]
        pervolume,
        /// <summary>
        /// permeabilitylength property
        /// </summary>
        [XmlEnum("permeability length")]
        permeabilitylength,
        /// <summary>
        /// permeabilityrock property
        /// </summary>
        [XmlEnum("permeability rock")]
        permeabilityrock,
        /// <summary>
        /// permeabilitythickness property
        /// </summary>
        [XmlEnum("permeability thickness")]
        permeabilitythickness,
        /// <summary>
        /// permeance property
        /// </summary>
        permeance,
        /// <summary>
        /// permittivity property
        /// </summary>
        permittivity,
        /// <summary>
        /// pH property
        /// </summary>
        pH,
        /// <summary>
        /// planeangle property
        /// </summary>
        [XmlEnum("plane angle")]
        planeangle,
        /// <summary>
        /// Poissonratio property
        /// </summary>
        [XmlEnum("Poisson ratio")]
        Poissonratio,
        /// <summary>
        /// porevolume property
        /// </summary>
        [XmlEnum("pore volume")]
        porevolume,
        /// <summary>
        /// porosity property
        /// </summary>
        porosity,
        /// <summary>
        /// potentialdifferenceperpowerdrop property
        /// </summary>
        [XmlEnum("potential difference per power drop")]
        potentialdifferenceperpowerdrop,
        /// <summary>
        /// power property
        /// </summary>
        power,
        /// <summary>
        /// powerpervolume property
        /// </summary>
        [XmlEnum("power per volume")]
        powerpervolume,
        /// <summary>
        /// pressure property
        /// </summary>
        pressure,
        /// <summary>
        /// pressurepertime property
        /// </summary>
        [XmlEnum("pressure per time")]
        pressurepertime,
        /// <summary>
        /// pressuresquared property
        /// </summary>
        [XmlEnum("pressure squared")]
        pressuresquared,
        /// <summary>
        /// pressuresquaredperforcetimeperarea property
        /// </summary>
        [XmlEnum("pressure squared per force time per area")]
        pressuresquaredperforcetimeperarea,
        /// <summary>
        /// pressuretimepervolume property
        /// </summary>
        [XmlEnum("pressure time per volume")]
        pressuretimepervolume,
        /// <summary>
        /// productivityindex property
        /// </summary>
        [XmlEnum("productivity index")]
        productivityindex,
        /// <summary>
        /// propertymultiplier property
        /// </summary>
        [XmlEnum("property multiplier")]
        propertymultiplier,
        /// <summary>
        /// quantity property
        /// </summary>
        quantity,
        /// <summary>
        /// quantityoflight property
        /// </summary>
        [XmlEnum("quantity of light")]
        quantityoflight,
        /// <summary>
        /// radiance property
        /// </summary>
        radiance,
        /// <summary>
        /// radiantintensity property
        /// </summary>
        [XmlEnum("radiant intensity")]
        radiantintensity,
        /// <summary>
        /// regioninitialization property
        /// </summary>
        [XmlEnum("region initialization")]
        regioninitialization,
        /// <summary>
        /// relativepermeability property
        /// </summary>
        [XmlEnum("relative permeability")]
        relativepermeability,
        /// <summary>
        /// relativepower property
        /// </summary>
        [XmlEnum("relative power")]
        relativepower,
        /// <summary>
        /// relativetime property
        /// </summary>
        [XmlEnum("relative time")]
        relativetime,
        /// <summary>
        /// reluctance property
        /// </summary>
        reluctance,
        /// <summary>
        /// resistance property
        /// </summary>
        resistance,
        /// <summary>
        /// resistivityperlength property
        /// </summary>
        [XmlEnum("resistivity per length")]
        resistivityperlength,
        /// <summary>
        /// RESQMLrootproperty property
        /// </summary>
        [XmlEnum("RESQML root property")]
        RESQMLrootproperty,
        /// <summary>
        /// RockImpedance property
        /// </summary>
        [XmlEnum("Rock Impedance")]
        RockImpedance,
        /// <summary>
        /// rockpermeability property
        /// </summary>
        [XmlEnum("rock permeability")]
        rockpermeability,
        /// <summary>
        /// rockvolume property
        /// </summary>
        [XmlEnum("rock volume")]
        rockvolume,
        /// <summary>
        /// saturation property
        /// </summary>
        saturation,
        /// <summary>
        /// secondmomentofarea property
        /// </summary>
        [XmlEnum("second moment of area")]
        secondmomentofarea,
        /// <summary>
        /// shearmodulus property
        /// </summary>
        [XmlEnum("shear modulus")]
        shearmodulus,
        /// <summary>
        /// solidangle property
        /// </summary>
        [XmlEnum("solid angle")]
        solidangle,
        /// <summary>
        /// solutiongasoilratio property
        /// </summary>
        [XmlEnum("solution gas-oil ratio")]
        solutiongasoilratio,
        /// <summary>
        /// specificactivityofradioactivity property
        /// </summary>
        [XmlEnum("specific activity (of radioactivity)")]
        specificactivityofradioactivity,
        /// <summary>
        /// specificenergy property
        /// </summary>
        [XmlEnum("specific energy")]
        specificenergy,
        /// <summary>
        /// specificheatcapacity property
        /// </summary>
        [XmlEnum("specific heat capacity")]
        specificheatcapacity,
        /// <summary>
        /// specificproductivityindex property
        /// </summary>
        [XmlEnum("specific productivity index")]
        specificproductivityindex,
        /// <summary>
        /// specificvolume property
        /// </summary>
        [XmlEnum("specific volume")]
        specificvolume,
        /// <summary>
        /// surfacedensity property
        /// </summary>
        [XmlEnum("surface density")]
        surfacedensity,
        /// <summary>
        /// temperatureperlength property
        /// </summary>
        [XmlEnum("temperature per length")]
        temperatureperlength,
        /// <summary>
        /// temperaturepertime property
        /// </summary>
        [XmlEnum("temperature per time")]
        temperaturepertime,
        /// <summary>
        /// thermalconductance property
        /// </summary>
        [XmlEnum("thermal conductance")]
        thermalconductance,
        /// <summary>
        /// thermalconductivity property
        /// </summary>
        [XmlEnum("thermal conductivity")]
        thermalconductivity,
        /// <summary>
        /// thermaldiffusivity property
        /// </summary>
        [XmlEnum("thermal diffusivity")]
        thermaldiffusivity,
        /// <summary>
        /// thermalinsulance property
        /// </summary>
        [XmlEnum("thermal insulance")]
        thermalinsulance,
        /// <summary>
        /// thermalresistance property
        /// </summary>
        [XmlEnum("thermal resistance")]
        thermalresistance,
        /// <summary>
        /// thermodynamictemperature property
        /// </summary>
        [XmlEnum("thermodynamic temperature")]
        thermodynamictemperature,
        /// <summary>
        /// thickness property
        /// </summary>
        thickness,
        /// <summary>
        /// time property
        /// </summary>
        time,
        /// <summary>
        /// timeperlength property
        /// </summary>
        [XmlEnum("time per length")]
        timeperlength,
        /// <summary>
        /// timepervolume property
        /// </summary>
        [XmlEnum("time per volume")]
        timepervolume,
        /// <summary>
        /// transmissibility property
        /// </summary>
        transmissibility,
        /// <summary>
        /// unitproductivityindex property
        /// </summary>
        [XmlEnum("unit productivity index")]
        unitproductivityindex,
        /// <summary>
        /// unitless property
        /// </summary>
        unitless,
        /// <summary>
        /// vaporoilgasratio property
        /// </summary>
        [XmlEnum("vapor oil-gas ratio")]
        vaporoilgasratio,
        /// <summary>
        /// velocity property
        /// </summary>
        velocity,
        /// <summary>
        /// volume property
        /// </summary>
        volume,
        /// <summary>
        /// volumeflowrate property
        /// </summary>
        [XmlEnum("volume flow rate")]
        volumeflowrate,
        /// <summary>
        /// volumelengthpertime property
        /// </summary>
        [XmlEnum("volume length per time")]
        volumelengthpertime,
        /// <summary>
        /// volumeperarea property
        /// </summary>
        [XmlEnum("volume per area")]
        volumeperarea,
        /// <summary>
        /// volumeperlength property
        /// </summary>
        [XmlEnum("volume per length")]
        volumeperlength,
        /// <summary>
        /// volumepertimeperarea property
        /// </summary>
        [XmlEnum("volume per time per area")]
        volumepertimeperarea,
        /// <summary>
        /// volumepertimeperlength property
        /// </summary>
        [XmlEnum("volume per time per length")]
        volumepertimeperlength,
        /// <summary>
        /// volumepertimepertime property
        /// </summary>
        [XmlEnum("volume per time per time")]
        volumepertimepertime,
        /// <summary>
        /// volumepertimepervolume property
        /// </summary>
        [XmlEnum("volume per time per volume")]
        volumepertimepervolume,
        /// <summary>
        /// volumepervolume property
        /// </summary>
        [XmlEnum("volume per volume")]
        volumepervolume,
        /// <summary>
        /// volumetricheattransfercoefficient property
        /// </summary>
        [XmlEnum("volumetric heat transfer coefficient")]
        volumetricheattransfercoefficient,
        /// <summary>
        /// volumetricthermalexpansion property
        /// </summary>
        [XmlEnum("volumetric thermal expansion")]
        volumetricthermalexpansion,
        /// <summary>
        /// work property
        /// </summary>
        work,
        /// <summary>
        /// Youngmodulus property
        /// </summary>
        [XmlEnum("Young modulus")]
        Youngmodulus
    }
    /// <summary>
    /// This class represents the WellboreFrameIndexableElements xsd enumeration.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.energistics.org/energyml/data/resqmlv2")]
    [Description("This class represents the WellboreFrameIndexableElements xsd enumeration.")]
    public enum WellboreFrameIndexableElements
    {
        /// <summary>
        /// intervals property
        /// </summary>
        intervals,
        /// <summary>
        /// nodes property
        /// </summary>
        nodes,
        /// <summary>
        /// cells property
        /// </summary>
        cells,
        /// <summary>
        /// intervalsfromdatum property
        /// </summary>
        [XmlEnum("intervals from datum")]
        intervalsfromdatum
    }
}