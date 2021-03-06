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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(23, "Radio Subcategory", 8)]
	public enum RadioSubcategory : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c411520e-5269-11df-a7fd-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c4126ab8-5269-11df-8ed7-080069138b88", Description="Joint Electronics Type Designation System (JETDS) Non-specific Series")]
		JointElectronicsTypeDesignationSystemJETDSNonSpecificSeries = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c4138376-5269-11df-94c7-080069138b88", Description="Manufacturer Designation")]
		ManufacturerDesignation = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c41491f8-5269-11df-8328-080069138b88", Description="National Designation")]
		NationalDesignation = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5fb39416-c0b7-4444-9883-6fb0c7bcc008", Description="JETDS ARC Set 1")]
		JETDSARCSet1 = 11,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6d5e30b5-4c53-4d0b-9185-5d46dfc1e998", Description="JETDS ARC Set 2")]
		JETDSARCSet2 = 12,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1737affd-5312-49dd-994f-1fadb130034a", Description="JETDS ARC Set 3")]
		JETDSARCSet3 = 13,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8afeb0cb-9fae-4c97-a686-d95064e3c5a8", Description="JETDS ARC Set 4")]
		JETDSARCSet4 = 14,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("61399834-bc39-4b1b-82c7-42e31b830560", Description="JETDS BRC Set 1")]
		JETDSBRCSet1 = 15,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("4f9c2c8f-5cb9-4292-85ef-5ff5361a3f87", Description="JETDS BRC Set 2")]
		JETDSBRCSet2 = 16,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f4f133ca-5dc8-4bc2-91f4-5f56f7169795", Description="JETDS BRC Set 3")]
		JETDSBRCSet3 = 17,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("688ecd55-902c-4340-afc5-414d28f2d896", Description="JETDS BRC Set 4")]
		JETDSBRCSet4 = 18,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("91000b3c-7dfd-4221-ba16-5119148e0d1f", Description="JETDS CRC Set 1")]
		JETDSCRCSet1 = 19,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d112e35-f31c-48e7-8e9a-c6d1a769b5b5", Description="JETDS CRC Set 2")]
		JETDSCRCSet2 = 20,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a0265658-274a-4ed2-83f7-0d248d31b411", Description="JETDS CRC Set 3")]
		JETDSCRCSet3 = 21,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0ffee62c-50a0-4bd3-93b8-246978aaa70f", Description="JETDS CRC Set 4")]
		JETDSCRCSet4 = 22,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("004c5212-047c-4f32-b241-2a0a18c9e364", Description="JETDS DRC Set 1")]
		JETDSDRCSet1 = 23,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a1a16c6e-f90c-4015-bfca-b73193360665", Description="JETDS DRC Set 2")]
		JETDSDRCSet2 = 24,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("30e833ed-ee9a-49ae-ba9d-9c5ad0d11f83", Description="JETDS DRC Set 3")]
		JETDSDRCSet3 = 25,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("82fa7c8b-a47a-4dc7-82c6-c593bc771e10", Description="JETDS DRC Set 4")]
		JETDSDRCSet4 = 26,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("32210338-7dc5-4530-8534-141e7c1e7e4a", Description="JETDS FRC Set 1")]
		JETDSFRCSet1 = 27,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("eeedff95-e51e-4e7e-80bb-3981682b32d7", Description="JETDS FRC Set 2")]
		JETDSFRCSet2 = 28,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e0275312-7422-4413-9526-1095f17628b4", Description="JETDS FRC Set 3")]
		JETDSFRCSet3 = 29,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("03972e0d-481b-4e02-8b16-fd2ffd5edad8", Description="JETDS FRC Set 4")]
		JETDSFRCSet4 = 30,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ddaff935-52ae-4b7a-8c62-6e25059c20d1", Description="JETDS GRC Set 1")]
		JETDSGRCSet1 = 31,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("b6d35a33-343c-4f62-9dcf-f3bbd6068af4", Description="JETDS GRC Set 2")]
		JETDSGRCSet2 = 32,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ced086cf-5cfd-40f8-8911-b54bb4b9ab7c", Description="JETDS GRC Set 3")]
		JETDSGRCSet3 = 33,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f346fdba-4c74-4bc7-a81e-2664e93e473c", Description="JETDS GRC Set 4")]
		JETDSGRCSet4 = 34,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("4a3aad94-5b9a-4c6a-aa0d-a39aed9a54eb", Description="JETDS KRC Set 1")]
		JETDSKRCSet1 = 35,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("fa3d91a2-5e12-4d6e-a6a2-6f8ff6e98112", Description="JETDS KRC Set 2")]
		JETDSKRCSet2 = 36,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("42692351-1e35-41ca-ba5a-fab57a10bea2", Description="JETDS KRC Set 3")]
		JETDSKRCSet3 = 37,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c7ff7a84-0197-4724-845b-4da4eef75957", Description="JETDS KRC Set 4")]
		JETDSKRCSet4 = 38,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8ec2b34f-db75-44b9-b1f6-9cc8f42aacb7", Description="JETDS MRC Set 1")]
		JETDSMRCSet1 = 39,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c33beb21-ba66-4966-81e5-c22e6f04c7b2", Description="JETDS MRC Set 2")]
		JETDSMRCSet2 = 40,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c6f0f475-9865-41f8-bbd7-af4455d47b6f", Description="JETDS MRC Set 3")]
		JETDSMRCSet3 = 41,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c95386c7-baa4-42ed-b3f0-b88b006fb684", Description="JETDS MRC Set 4")]
		JETDSMRCSet4 = 42,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1fbf9109-d765-426e-9991-9fe61937bb53", Description="JETDS PRC Set 1")]
		JETDSPRCSet1 = 43,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("08a003a5-01c2-4e75-bfd9-aec7c3e320e1", Description="JETDS PRC Set 2")]
		JETDSPRCSet2 = 44,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0dc82ddf-c880-40f2-b6c2-209cf9bcaec7", Description="JETDS PRC Set 3")]
		JETDSPRCSet3 = 45,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("14d79ee1-45e3-41a3-ae86-4fcaf52c00fd", Description="JETDS PRC Set 4")]
		JETDSPRCSet4 = 46,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6719aab7-b5ee-4602-960b-9b4fe1268b63", Description="JETDS SRC Set 1")]
		JETDSSRCSet1 = 47,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a304a0c5-e50a-4627-b4ee-39ba38894341", Description="JETDS SRC Set 2")]
		JETDSSRCSet2 = 48,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c0a5952f-2af0-4f56-901e-b003a3355482", Description="JETDS SRC Set 3")]
		JETDSSRCSet3 = 49,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1deb2e05-cbcd-4042-a8b7-2ca06adeb58d", Description="JETDS SRC Set 4")]
		JETDSSRCSet4 = 50,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("368959a9-5925-419d-8c6e-0b7a9dcd994d", Description="JETDS TRC Set 1")]
		JETDSTRCSet1 = 51,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("06cd94ad-1d02-4603-861f-1f558240201b", Description="JETDS TRC Set 2")]
		JETDSTRCSet2 = 52,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("bfc3c296-d345-4d48-bad4-92ea62b19dec", Description="JETDS TRC Set 3")]
		JETDSTRCSet3 = 53,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("92b4bcf0-1937-4bc6-b8bb-cd3d46682f2b", Description="JETDS TRC Set 4")]
		JETDSTRCSet4 = 54,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1e7af6ba-7a0b-4578-a712-15a2fb2dbbee", Description="JETDS VRC Set 1")]
		JETDSVRCSet1 = 55,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("fa135147-83a5-4d02-ad53-79f84a670b2a", Description="JETDS VRC Set 2")]
		JETDSVRCSet2 = 56,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("66b7614d-ce26-4efd-95c4-92c006331c5a", Description="JETDS VRC Set 3")]
		JETDSVRCSet3 = 57,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a7d24354-6c12-4aae-8e92-71b741322675", Description="JETDS VRC Set 4")]
		JETDSVRCSet4 = 58,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3fe0321a-3b76-4571-9253-82e7a342dca8", Description="JETDS WRC Set 1")]
		JETDSWRCSet1 = 59,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("579415ef-2700-494c-b2a6-8f8645f2163c", Description="JETDS WRC Set 2")]
		JETDSWRCSet2 = 60,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0fd2ddbd-31cd-407b-a99a-524233ed6d98", Description="JETDS WRC Set 3")]
		JETDSWRCSet3 = 61,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f292d609-e64b-4935-ab93-1e8b5a5adcee", Description="JETDS WRC Set 4")]
		JETDSWRCSet4 = 62,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("571a1f25-2b83-489a-a5a8-bcc6a9c1bd0f", Description="JETDS ZRC Set 1")]
		JETDSZRCSet1 = 63,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("b3801dcc-5a49-402c-bf94-b289a71aa4a8", Description="JETDS ZRC Set 2")]
		JETDSZRCSet2 = 64,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5755e1bd-a446-4fe2-bee2-9fd4d1145821", Description="JETDS ZRC Set 3")]
		JETDSZRCSet3 = 65,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1981c772-9038-4c22-b5bc-5e7a0908cdee", Description="JETDS ZRC Set 4")]
		JETDSZRCSet4 = 66,
	}
}
