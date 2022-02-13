//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
//Copyright © 2010-2011, 2013-2021 by the Simulation Interoperability Standards Organization, Inc.
//7901 4th St N, Suite 300-4043
//St. Petersburg, FL 33702
//All rights reserved.
//
//Schema and API: SISO hereby grants a general, royalty-free license to copy, distribute, display, and
//make derivative works from this material, for all purposes, provided that any use of the material
//contains the following attribution: “Reprinted with permission from SISO Inc.” Should
//a reader require additional information, contact the SISO Inc. Board of Directors.
//
//Documentation: SISO hereby grants a general, royalty-free license to copy, distribute,
//display, and make derivative works from this material, for noncommercial purposes, provided that
//any use of the material contains the following attribution: “Reprinted with permission from SISO Inc.” 
//The material may not be used for a commercial purpose without express written
//permission from the SISO Inc Board of Directors.
//
//SISO Inc. Board of Directors
//7901 4th St N, Suite 300-4043
//St. Petersburg, FL 33702
//
namespace Invicta.Net.SisoRef010 {
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(22, "Radio Category", 8)]
	public enum RadioCategory : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c3f998b2-5269-11df-983d-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c3faa7ac-5269-11df-9150-080069138b88", Description="Voice Transmission/Reception")]
		VoiceTransmissionOrReception = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c3fbb9f8-5269-11df-a0bc-080069138b88", Description="Data Link Transmission/Reception")]
		DataLinkTransmissionOrReception = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c3fcceec-5269-11df-a618-080069138b88", Description="Voice and Data Link Transmission/Reception")]
		VoiceAndDataLinkTransmissionOrReception = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c3fdda9e-5269-11df-abc5-080069138b88", Description="Instrumented Landing System (ILS) Glideslope Transmitter")]
		InstrumentedLandingSystemILSGlideslopeTransmitter = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c3feed94-5269-11df-add8-080069138b88", Description="Instrumented Landing System (ILS) Localizer Transmitter")]
		InstrumentedLandingSystemILSLocalizerTransmitter = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c400044a-5269-11df-a2b5-080069138b88", Description="Instrumented Landing System (ILS) Outer Marker Beacon")]
		InstrumentedLandingSystemILSOuterMarkerBeacon = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c4010ffc-5269-11df-8939-080069138b88", Description="Instrumented Landing System (ILS) Middle Marker Beacon")]
		InstrumentedLandingSystemILSMiddleMarkerBeacon = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c402223e-5269-11df-a442-080069138b88", Description="Instrumented Landing System (ILS) Inner Marker Beacon")]
		InstrumentedLandingSystemILSInnerMarkerBeacon = 8,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c4033958-5269-11df-9638-080069138b88", Description="Instrumented Landing System (ILS) Receiver (Platform Radio)")]
		InstrumentedLandingSystemILSReceiverPlatformRadio = 9,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c4044a0a-5269-11df-9804-080069138b88", Description="Tactical Air Navigation (TACAN) Transmitter (Ground Fixed Equipment)")]
		TacticalAirNavigationTACANTransmitterGroundFixedEquipment = 10,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c4055d00-5269-11df-98c2-080069138b88", Description="Tactical Air Navigation (TACAN) Receiver (Moving Platform Equipment)")]
		TacticalAirNavigationTACANReceiverMovingPlatformEquipment = 11,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c4066f88-5269-11df-bcea-080069138b88", Description="Tactical Air Navigation (TACAN) Transmitter/Receiver (Moving Platform Equipment)")]
		TacticalAirNavigationTACANTransmitterOrReceiverMovingPlatformEquipment = 12,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c407803a-5269-11df-8600-080069138b88", Description="Variable Omni-Ranging (VOR) Transmitter (Ground Fixed Equipment)")]
		VariableOmniRangingVORTransmitterGroundFixedEquipment = 13,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c4089858-5269-11df-a006-080069138b88", Description="Variable Omni-Ranging (VOR) with Distance Measuring Equipment (DME) Transmitter (" +
			"Ground Fixed Equipment)")]
		VariableOmniRangingVORWithDistanceMeasuringEquipmentDMETransmitterGroundFixedEquipment = 14,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c409ad6a-5269-11df-8c67-080069138b88", Description="Combined VOR/ILS Receiver (Moving Platform Equipment)")]
		CombinedVOROrILSReceiverMovingPlatformEquipment = 15,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c40ab962-5269-11df-93ba-080069138b88", Description="Combined VOR & TACAN (VORTAC) Transmitter")]
		CombinedVORAndTACANVORTACTransmitter = 16,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c40bcf8c-5269-11df-bdde-080069138b88", Description="Non-Directional Beacon (NDB) Transmitter")]
		NonDirectionalBeaconNDBTransmitter = 17,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c40ce0e8-5269-11df-919c-080069138b88", Description="Non-Directional Beacon (NDB) Receiver")]
		NonDirectionalBeaconNDBReceiver = 18,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c40dede4-5269-11df-8ed3-080069138b88", Description="Non-Directional Beacon (NDB) with Distance Measuring Equipment (DME) Transmitter")]
		NonDirectionalBeaconNDBWithDistanceMeasuringEquipmentDMETransmitter = 19,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c40f001c-5269-11df-9b82-080069138b88", Description="Distance Measuring Equipment (DME)")]
		DistanceMeasuringEquipmentDME = 20,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a5dd2383-0259-462e-abbb-f1087f40d6ca", Description="Link 16 Terminal")]
		Link16Terminal = 21,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e7b0eccf-0f16-4048-b5ed-aa961e3a418f", Description="Link 11 Terminal")]
		Link11Terminal = 22,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("93b57a7b-f729-44ec-b4c8-acbded5ef7e7", Description="Link 11B Terminal")]
		Link11BTerminal = 23,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ce63c4de-63bd-4751-950c-2e15ca897260", Description="EPLRS/SADL Terminal")]
		EPLRSOrSADLTerminal = 24,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e819fbc5-d8ba-47b9-978c-c758818f3260", Description="F-22 Intra-Flight Data Link (IFDL)")]
		F22IntraFlightDataLinkIFDL = 25,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6da19020-ab86-4723-952a-0bafb1abd2d4", Description="F-35 Multifunction Advanced Data Link (MADL)")]
		F35MultifunctionAdvancedDataLinkMADL = 26,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c107bcea-8c2d-4975-9eb2-106165f50386", Description="SINCGARS Terminal")]
		SINCGARSTerminal = 27,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("127d7945-bb14-4612-8d37-b94fe5fd4a6e", Description="L-Band SATCOM Terminal")]
		LBandSATCOMTerminal = 28,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2392eb51-9666-4d8f-b555-eb69b0bba74c", Description="IBS Terminal")]
		IBSTerminal = 29,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a13b180d-7cb1-4bc2-9886-6794e13cd5bd", Description="GPS")]
		GPS = 30,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("85e54568-28d1-4eb6-9b75-9ead554fc6bf", Description="Tactical Video")]
		TacticalVideo = 31,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("7dd64031-4e52-42c2-b3d4-8abb74e0ae53", Description="Air-to-Air Missile Datalink")]
		AirToAirMissileDatalink = 32,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0d5442aa-4788-4289-80f7-ddad2c56e04e", Description="Link 16 Surrogate for Non-NATO TDL Terminal")]
		Link16SurrogateForNonNATOTDLTerminal = 33,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f68feb63-3b83-4b50-9d30-3b6c0cf773d1", Description="MQ-1/9 C-Band LOS Datalink")]
		MQ1Or9CBandLOSDatalink = 34,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("facb0bdc-adda-4210-953c-0c8d0e10514d", Description="MQ-1/9 Ku-Band SATCOM Datalink")]
		MQ1Or9KuBandSATCOMDatalink = 35,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("818ae570-884c-4a26-9966-87584238ef9a", Description="Air-to-Ground Weapon Datalink")]
		AirToGroundWeaponDatalink = 36,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3483cdb3-3d69-4702-ac8c-613b87550e39", Description="Automatic Identification System (AIS)")]
		AutomaticIdentificationSystemAIS = 37,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6401dc01-3b68-4fdc-b96e-845452e5c7ae", Description="JPALS Data Link")]
		JPALSDataLink = 38,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("516b1675-b36f-411a-9265-4341362728e9", Description="Combat Search and Rescue (CSAR) Radio")]
		CombatSearchAndRescueCSARRadio = 40,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0cc28b61-3f46-4e6b-a64d-dfd9408e8a13", Description="Counter Unmanned Aircraft System (C-UAS) Radio")]
		CounterUnmannedAircraftSystemCUASRadio = 41,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("be7d736d-a364-4bd3-bf59-49ac9ac42e08", Description="Emergency Position-Indicating Radio Beacons (EPIRB)")]
		EmergencyPositionIndicatingRadioBeaconsEPIRB = 42,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16a00bff-caeb-4c00-82de-ed0cd7f3192d", Description="Electronic Attack Systems")]
		ElectronicAttackSystems = 50,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("70f22b97-06f7-48b9-9a31-c1aadb7880f1", Description="Tactical Targeting Network Technology (TTNT)")]
		TacticalTargetingNetworkTechnologyTTNT = 51,
	}
}
