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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(428, "Platform-Land-Car Subcategories", 8)]
	public enum PlatformLandCarSubcategories : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("62f22150-da68-4072-86b3-ff9892d49828", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("921f67de-1592-4079-8d1d-5a24714ac24a", Description="Generic")]
		Generic = 10,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5dc076ef-ee58-49e8-a6ec-d61ebfd6f820", Description="Generic, Mini/Microcar (Tiny)")]
		GenericMiniOrMicrocarTiny = 11,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0a2462e5-db0a-4d02-8553-c49b560c44b7", Description="Generic, Economy/Compact (Small)")]
		GenericEconomyOrCompactSmall = 12,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6c716aca-339d-48d6-a8c4-bceaf4d99f8f", Description="Generic, Intermediate/Standard (Medium)")]
		GenericIntermediateOrStandardMedium = 13,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("316e3a4b-1b2d-4e57-994d-85d13ef6e1ab", Description="Generic, Full/Premium/Luxury (Large)")]
		GenericFullOrPremiumOrLuxuryLarge = 14,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("efe9712e-7995-46cf-875d-eae9a4d0cd5d", Description="Generic, Oversize")]
		GenericOversize = 15,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8522fdfb-f19c-4724-8b46-85ea68d4c9da", Description="2-Door (Coupe)")]
		_2DoorCoupe = 20,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("b5a4ed62-21fa-446c-9103-5c8444d31057", Description="2-Door (Coupe), Mini/Microcar (Tiny)")]
		_2DoorCoupeMiniOrMicrocarTiny = 21,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("20392367-9de9-4dd4-9471-d7059b7a35ad", Description="2-Door (Coupe), Economy/Compact (Small)")]
		_2DoorCoupeEconomyOrCompactSmall = 22,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9684c45f-39a9-4b27-a414-d547b03299d7", Description="2-Door (Coupe), Intermediate/Standard (Medium)")]
		_2DoorCoupeIntermediateOrStandardMedium = 23,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("084d9471-a085-4a66-bc6f-cc2732006b31", Description="3-Door Hatchback")]
		_3DoorHatchback = 30,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3c4c4760-7c01-4a6f-975f-7abc9c662869", Description="3-Door Hatchback, Mini/Microcar (Tiny)")]
		_3DoorHatchbackMiniOrMicrocarTiny = 31,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("4661cf49-44fa-440c-be68-826b668799ba", Description="3-Door Hatchback, Economy/Compact (Small)")]
		_3DoorHatchbackEconomyOrCompactSmall = 32,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("725fba05-0bbd-4edc-9efe-e879de159ec8", Description="4-Door Sedan")]
		_4DoorSedan = 40,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9a12c1c5-8a00-4a31-80ff-2c10fd883fee", Description="4-Door Sedan, Mini/Microcar (Tiny)")]
		_4DoorSedanMiniOrMicrocarTiny = 41,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("dfd1ad07-362c-48bf-97f7-27b285c6ce5f", Description="4-Door Sedan, Economy/Compact (Small)")]
		_4DoorSedanEconomyOrCompactSmall = 42,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("fe916222-e265-477e-85e0-c54edf2c2a03", Description="4-Door Sedan, Intermediate/Standard (Medium)")]
		_4DoorSedanIntermediateOrStandardMedium = 43,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("58ae6872-73d4-4701-a7ee-46d25591a3bd", Description="4-Door Sedan, Full/Premium/Luxury (Large)")]
		_4DoorSedanFullOrPremiumOrLuxuryLarge = 44,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9e112d4f-177f-45f9-8552-1e6f0e78db4b", Description="4-Door Sedan, Oversize")]
		_4DoorSedanOversize = 45,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("44c41183-4ebe-4d1f-8b69-f0e20eb8418a", Description="5-Door Hatchback")]
		_5DoorHatchback = 50,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("fd61e2b1-996e-4ebc-8b56-fd10f770f941", Description="5-Door Hatchback, Mini/Microcar (Tiny)")]
		_5DoorHatchbackMiniOrMicrocarTiny = 51,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("02436c7b-3a8d-4793-a954-5ed464045c8f", Description="5-Door Hatchback, Economy/Compact (Small)")]
		_5DoorHatchbackEconomyOrCompactSmall = 52,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("dd76f3df-a9f1-4830-ae96-7d425a30d46e", Description="5-Door Hatchback, Intermediate/Standard (Medium)")]
		_5DoorHatchbackIntermediateOrStandardMedium = 53,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0a63b0de-40e8-4eeb-97ff-5436e1a5a6d9", Description="5-Door Hatchback, Full/Premium/Luxury (Large)")]
		_5DoorHatchbackFullOrPremiumOrLuxuryLarge = 54,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3689d156-4c40-4173-881e-5fc61d370a0c", Description="Wagon")]
		Wagon = 60,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("b898e315-f7db-410c-b72b-9af225835793", Description="Wagon, Economy/Compact (Small)")]
		WagonEconomyOrCompactSmall = 62,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("98d7ccb8-8178-4c64-91e6-cbd20b1d4a9c", Description="Wagon, Intermediate/Standard (Medium)")]
		WagonIntermediateOrStandardMedium = 63,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ab2a8fb2-f618-4442-8f56-7e21befbd955", Description="Wagon, Full/Premium/Luxury (Large)")]
		WagonFullOrPremiumOrLuxuryLarge = 64,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3d616c40-9802-4c21-98ef-aa531aa39a6d", Description="Minivan")]
		Minivan = 70,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("4bd27908-eeaa-4d19-97b6-53e064fc5db3", Description="Limousine")]
		Limousine = 80,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9b0e3979-6af9-46a3-ab74-a487b122ca85", Description="Limousine, Full/Premium/Luxury (Large)")]
		LimousineFullOrPremiumOrLuxuryLarge = 84,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8c8a9c4d-76a5-49d0-98d1-24406a754384", Description="Limousine, Oversize")]
		LimousineOversize = 85,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8c94d723-5534-48c6-9d49-863b3fbb0426", Description="Sports (High Performance)")]
		SportsHighPerformance = 90,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3e5d9ef0-f772-4fd1-8a6f-0a6e9887883b", Description="Convertible")]
		Convertible = 100,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e5ec0aea-a969-46ee-aaae-d458fd6cbf94", Description="Convertible, Mini/Microcar (Tiny)")]
		ConvertibleMiniOrMicrocarTiny = 101,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0fa1d30e-f7d3-46f7-9c35-10e4c437ae51", Description="Convertible, Economy/Compact (Small)")]
		ConvertibleEconomyOrCompactSmall = 102,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("cb0eda52-1cb3-45af-9519-c51400f506ed", Description="Convertible, Intermediate/Standard (Medium)")]
		ConvertibleIntermediateOrStandardMedium = 103,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6494f21a-e02b-401e-9b8f-ce0ae55680a8", Description="Convertible, Full/Premium/Luxury (Large)")]
		ConvertibleFullOrPremiumOrLuxuryLarge = 104,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("28fe87a5-79a1-48a9-94e0-37f2ddba6855", Description="Sports Utility Vehicle (SUV)")]
		SportsUtilityVehicleSUV = 110,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("dbc59f60-b6fc-4eff-a043-f3cb2a9232cd", Description="Sports Utility Vehicle (SUV), Economy/Compact (Small)")]
		SportsUtilityVehicleSUVEconomyOrCompactSmall = 112,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("4664a9f0-16d4-4fe8-9a3e-7acc5c13d1bb", Description="Sports Utility Vehicle (SUV), Intermediate/Standard (Medium)")]
		SportsUtilityVehicleSUVIntermediateOrStandardMedium = 113,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("737e9f1e-c45a-4b83-bf14-24079fa76f0a", Description="Sports Utility Vehicle (SUV), Full/Premium/Luxury (Large)")]
		SportsUtilityVehicleSUVFullOrPremiumOrLuxuryLarge = 114,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("570794a0-0683-4077-bd14-8019b56ce8a3", Description="Sports Utility Vehicle (SUV), Oversize")]
		SportsUtilityVehicleSUVOversize = 115,
	}
}
