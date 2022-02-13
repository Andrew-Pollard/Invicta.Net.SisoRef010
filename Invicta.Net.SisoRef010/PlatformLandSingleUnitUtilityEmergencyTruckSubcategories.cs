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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(431, "Platform-Land-Single Unit Utility Emergency Truck Subcategories", 8)]
	public enum PlatformLandSingleUnitUtilityEmergencyTruckSubcategories : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3f8a2bc1-a18b-49a5-9caa-7e9980a5b4ab", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0e7a5ac6-18e8-47a9-9fe3-450dec99d478", Description="Ambulance Truck")]
		AmbulanceTruck = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a8e627c9-2130-466b-ac69-0c9eecbf7d4f", Description="Fire/Paramedic Truck")]
		FireOrParamedicTruck = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("82067446-8bf8-43e7-968a-7eb0656b9363", Description="Ambulance, Advanced Life Support")]
		AmbulanceAdvancedLifeSupport = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8bfe9d57-1cdc-43ae-a615-7be1b2503161", Description="Ambulance Pickup Truck")]
		AmbulancePickupTruck = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f7d0f7b8-5b0a-41e3-b15c-64c4867ab694", Description="Fire Engine")]
		FireEngine = 10,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("658d76ec-7c96-488a-9d61-8131f7163cea", Description="Aerial Ladder Fire Engine")]
		AerialLadderFireEngine = 11,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("76f982a6-f199-4cf4-9d27-623e85ead464", Description="Airport Fire Engine")]
		AirportFireEngine = 12,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f03d48b9-174c-4393-9eb3-01b1838c4dd5", Description="Wildland Fire Engine")]
		WildlandFireEngine = 13,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1165d2d6-06c6-4bba-a87e-6fb457b05652", Description="Fire Chief")]
		FireChief = 14,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d57763b2-3558-456b-b856-95d34de39b04", Description="Police Paddy Wagon")]
		PolicePaddyWagon = 20,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("665b28f5-fef7-4fbc-bf22-791869b033e7", Description="Police, SWAT")]
		PoliceSWAT = 21,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("dcf0a91c-7d81-4536-a570-dc61ed377960", Description="Police, Bomb Squad")]
		PoliceBombSquad = 22,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("27619b48-4edf-4b42-afe8-ac25553cc31d", Description="Police, Pickup Truck")]
		PolicePickupTruck = 23,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6d9f7541-e2d0-4adf-83bd-cb16f1d1d65b", Description="Hazmat")]
		Hazmat = 30,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("383143f0-c9e6-44fa-a440-ab816d6856d8", Description="Wrecker, Normal Hook and Chain")]
		WreckerNormalHookAndChain = 40,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e2740fc9-02db-43ad-a1a3-6079de994b80", Description="Wrecker, Normal Boom")]
		WreckerNormalBoom = 41,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("191332dd-9173-4230-8cc8-d166c20cbb03", Description="Wrecker, Normal Wheel Lift")]
		WreckerNormalWheelLift = 42,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e1c39fde-88a8-4daf-b0dc-420b0d1b41f5", Description="Wrecker, Normal Flatbed")]
		WreckerNormalFlatbed = 43,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("062a4522-b97c-4d26-8050-d671f920977e", Description="Wrecker, Normal Integrated")]
		WreckerNormalIntegrated = 44,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0b6fcc76-13d9-4872-bc12-e66a60950a68", Description="Wrecker, Heavy Hook and Chain")]
		WreckerHeavyHookAndChain = 45,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f28249f1-e6b5-4d23-a2b3-1c413326413b", Description="Wrecker, Heavy Boom")]
		WreckerHeavyBoom = 46,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("791e5a73-42ca-473e-93ca-49ea28298c65", Description="Wrecker, Heavy Wheel Lift")]
		WreckerHeavyWheelLift = 47,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c95e8038-066a-412f-aa47-84d7d9366c4d", Description="Wrecker, Heavy Flatbed")]
		WreckerHeavyFlatbed = 48,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("85bb3168-2140-417a-97f6-e924e1b0a98f", Description="Wrecker, Heavy Integrated")]
		WreckerHeavyIntegrated = 49,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("bc84c361-9a4b-4e45-a72a-dcea0787cc07", Description="Postal Truck")]
		PostalTruck = 60,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2805ca59-749a-4b16-ba6c-5f3ebb195cf9", Description="Street Sweeper")]
		StreetSweeper = 70,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6b28d74e-9a97-4975-bf81-85893b3baec2", Description="Street Sweeper, Three Wheeled")]
		StreetSweeperThreeWheeled = 71,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f3c30684-6ab5-4a5a-84de-140665477f39", Description="Waste Collection, Other")]
		WasteCollectionOther = 80,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0efe6f10-5d3f-4f71-a9e0-d8d4cf069b8d", Description="Waste Collection, Front Loader")]
		WasteCollectionFrontLoader = 81,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d1510e29-c678-4a73-91ce-22ba94badd2c", Description="Waste Collection, Rear Loader")]
		WasteCollectionRearLoader = 82,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b85f49a-6632-4b1a-8f61-4b4017951ad0", Description="Waste Collection, Automated Side Loader")]
		WasteCollectionAutomatedSideLoader = 83,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("96003649-6b12-4462-85bf-26decd230230", Description="Waste Collection, Pneumatic Collection")]
		WasteCollectionPneumaticCollection = 84,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("df6b5b55-30f8-4a6c-9576-0f0d829bc71f", Description="Waste Collection, Grapple")]
		WasteCollectionGrapple = 85,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ce9cd7f6-a5b4-45ee-afca-564eeccef813", Description="Utility Truck")]
		UtilityTruck = 90,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a0a36d25-b03b-4cda-92b9-42e22320c059", Description="Utility Truck w/ Boom")]
		UtilityTruckWOrBoom = 91,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0959522e-97dd-45b7-8006-8b83ebdd29bb", Description="Aerial Work Platform, Other")]
		AerialWorkPlatformOther = 100,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("153e32b4-0777-44e3-b4f6-55ff90f5198e", Description="Aerial Work Platform, Scissor Lift")]
		AerialWorkPlatformScissorLift = 101,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("b12e1fc3-8ba2-4e3a-b502-767be75d7b2a", Description="Aerial Work Platform, Telescoping")]
		AerialWorkPlatformTelescoping = 102,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f9d70c99-0d94-4571-b8e0-28399c8aeb96", Description="Maintenance Truck")]
		MaintenanceTruck = 120,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("cfadb755-c2df-439f-ac3a-c5bb07442a2c", Description="Decontamination Truck")]
		DecontaminationTruck = 121,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("78cda4f0-b685-4c0c-9819-e66ad064be8b", Description="Water Cannon Truck")]
		WaterCannonTruck = 122,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("31af9e99-2a41-40f4-996d-24c0c396b8a7", Description="Water Purification Truck")]
		WaterPurificationTruck = 123,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("81223d20-be16-4411-b9b8-a12beffdb5d0", Description="Smoke Generator Truck")]
		SmokeGeneratorTruck = 124,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0726926d-4e00-4912-bbde-fd4bedc07289", Description="Auto Rickshaw")]
		AutoRickshaw = 150,
	}
}
