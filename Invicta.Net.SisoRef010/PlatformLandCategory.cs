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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(9, "Platform-Land Category", 8)]
	public enum PlatformLandCategory : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2852474-5269-11df-9ada-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2863706-5269-11df-b99c-080069138b88", Description="Tank")]
		Tank = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c28741e6-5269-11df-8a90-080069138b88", Description="Armored Fighting Vehicle")]
		ArmoredFightingVehicle = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2885aea-5269-11df-9f86-080069138b88", Description="Armored Utility Vehicle")]
		ArmoredUtilityVehicle = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c28973da-5269-11df-b1dc-080069138b88", Description="Self-Propelled Artillery")]
		SelfPropelledArtillery = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c28a8478-5269-11df-9ad1-080069138b88", Description="Towed Artillery")]
		TowedArtillery = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c28b9700-5269-11df-ad45-080069138b88", Description="Small Wheeled Utility Vehicle")]
		SmallWheeledUtilityVehicle = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c28ca78a-5269-11df-a477-080069138b88", Description="Large Wheeled Utility Vehicle")]
		LargeWheeledUtilityVehicle = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c28db918-5269-11df-b1cd-080069138b88", Description="Small Tracked Utility Vehicle")]
		SmallTrackedUtilityVehicle = 8,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c28ecc22-5269-11df-9aec-080069138b88", Description="Large Tracked Utility Vehicle")]
		LargeTrackedUtilityVehicle = 9,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c28fe058-5269-11df-a780-080069138b88", Description="Mortar")]
		Mortar = 10,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c290e8fe-5269-11df-a764-080069138b88", Description="Mine Plow")]
		MinePlow = 11,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c291f8c0-5269-11df-811f-080069138b88", Description="Mine Rake")]
		MineRake = 12,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2930b8e-5269-11df-a459-080069138b88", Description="Mine Roller")]
		MineRoller = 13,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2941380-5269-11df-8797-080069138b88", Description="Cargo Trailer")]
		CargoTrailer = 14,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c29523a6-5269-11df-b83d-080069138b88", Description="Fuel Trailer")]
		FuelTrailer = 15,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c29634bc-5269-11df-a431-080069138b88", Description="Generator Trailer")]
		GeneratorTrailer = 16,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2974014-5269-11df-ac4b-080069138b88", Description="Water Trailer")]
		WaterTrailer = 17,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2984e14-5269-11df-ac53-080069138b88", Description="Engineer Equipment")]
		EngineerEquipment = 18,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c29961c8-5269-11df-8a6a-080069138b88", Description="Heavy Equipment Transport Trailer")]
		HeavyEquipmentTransportTrailer = 19,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c29a6cd0-5269-11df-b3c7-080069138b88", Description="Maintenance Equipment Trailer")]
		MaintenanceEquipmentTrailer = 20,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c29b7c24-5269-11df-9cf1-080069138b88", Description="Limber")]
		Limber = 21,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c29c8dee-5269-11df-9206-080069138b88", Description="Chemical Decontamination Trailer")]
		ChemicalDecontaminationTrailer = 22,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c29d9824-5269-11df-b446-080069138b88", Description="Warning System")]
		WarningSystem = 23,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c29ea6f6-5269-11df-8a26-080069138b88", Description="Train - Engine")]
		TrainEngine = 24,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c29fb82a-5269-11df-ade2-080069138b88", Description="Train - Car")]
		TrainCar = 25,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2a0c044-5269-11df-a639-080069138b88", Description="Train - Caboose")]
		TrainCaboose = 26,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2a1d876-5269-11df-b450-080069138b88", Description="Civilian Vehicle")]
		[System.ObsoleteAttribute("Civilian land vehicles were moved to a group of Category values starting at 80")]
		CivilianVehicle = 27,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2a2edec-5269-11df-b6d5-080069138b88", Description="Air Defense / Missile Defense Unit Equipment")]
		AirDefenseOrMissileDefenseUnitEquipment = 28,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2a3fa70-5269-11df-88e6-080069138b88", Description="Command, Control, Communications, and Intelligence (C3I) System")]
		CommandControlCommunicationsAndIntelligenceC3ISystem = 29,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2a50cb2-5269-11df-bd44-080069138b88", Description="Operations Facility")]
		OperationsFacility = 30,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2a61ed6-5269-11df-a83a-080069138b88", Description="Intelligence Facility")]
		IntelligenceFacility = 31,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2a72d4e-5269-11df-862b-080069138b88", Description="Surveillance Facility")]
		SurveillanceFacility = 32,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2a83ca2-5269-11df-b796-080069138b88", Description="Communications Facility")]
		CommunicationsFacility = 33,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2a94c0a-5269-11df-a112-080069138b88", Description="Command Facility")]
		CommandFacility = 34,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2aa56ea-5269-11df-8994-080069138b88", Description="C4I Facility")]
		C4IFacility = 35,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2ab68dc-5269-11df-a376-080069138b88", Description="Control Facility")]
		ControlFacility = 36,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2ac7664-5269-11df-83c9-080069138b88", Description="Fire Control Facility")]
		FireControlFacility = 37,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2ad813a-5269-11df-b580-080069138b88", Description="Missile Defense Facility")]
		MissileDefenseFacility = 38,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2ae953e-5269-11df-8666-080069138b88", Description="Field Command Post")]
		FieldCommandPost = 39,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2afa5e6-5269-11df-bdd3-080069138b88", Description="Observation Post")]
		ObservationPost = 40,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ea30565a-e619-488a-ba5f-5214e7212183", Description="Unmanned")]
		Unmanned = 50,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a6b8a2cb-99f5-457d-be88-b954ffcd6e8c", Description="Motorcycle")]
		Motorcycle = 80,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8d4722d2-8e69-4176-ad65-4233d1efc9c2", Description="Car")]
		Car = 81,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5c309127-de26-4e9e-9eb6-42bc712ea159", Description="Bus")]
		Bus = 82,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("79d70cd6-00bb-4fb3-82f8-51da6aa12f7d", Description="Single Unit Cargo Truck")]
		SingleUnitCargoTruck = 83,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("08bdfc46-7d1c-4b8e-bb41-31e0bd32a639", Description="Single Unit Utility/Emergency Truck")]
		SingleUnitUtilityOrEmergencyTruck = 84,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("536e94d7-9a65-4d2e-961a-4474f441eb24", Description="Multiple Unit Cargo Truck")]
		MultipleUnitCargoTruck = 85,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0ccf5e9c-4485-491b-96c4-148389499cf9", Description="Multiple Unit Utility/Emergency Truck")]
		MultipleUnitUtilityOrEmergencyTruck = 86,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d2f79398-59b5-485d-96b1-0998c7729e40", Description="Construction Specialty Vehicle")]
		ConstructionSpecialtyVehicle = 87,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("7854426e-cfa1-4d6c-8543-0cbcd86ec40e", Description="Farm Specialty Vehicle")]
		FarmSpecialtyVehicle = 88,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d4401ead-006f-4989-9257-bd2ec447b4cf", Description="Trailer")]
		Trailer = 89,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c19a2d18-3a88-49ce-a586-7ac22a8bf93c", Description="Recreational")]
		Recreational = 90,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ac0b6ca1-cbe3-452f-9015-fe43bf245d48", Description="Non-motorized")]
		NonMotorized = 91,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("33850eff-0647-4cc4-affb-b116d3ce22a4", Description="Trains")]
		Trains = 92,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d6421ccd-8eae-4f5b-9dd8-8189a9d31c2f", Description="Utility/Emergency Car")]
		UtilityOrEmergencyCar = 93,
	}
}
