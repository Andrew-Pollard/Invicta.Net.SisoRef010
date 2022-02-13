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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(177, "Signal-User Protocol Identification Number", 32)]
	public enum SignalUserProtocolIdentificationNumber : uint {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("193f37aa-526a-11df-8eb4-080069138b88", Description="CCSIL")]
		CCSIL = 1u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("194230e0-526a-11df-81c9-080069138b88", Description="A2ATD SINCGARS ERF")]
		A2ATDSINCGARSERF = 5u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1945cfca-526a-11df-bed4-080069138b88", Description="A2ATD CAC2")]
		A2ATDCAC2 = 6u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("19497314-526a-11df-aa34-080069138b88", Description="Battle Command")]
		BattleCommand = 20u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("194d1866-526a-11df-8522-080069138b88", Description="AFIWC IADS Track Report")]
		AFIWCIADSTrackReport = 30u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("195163da-526a-11df-880a-080069138b88", Description="AFIWC IADS Comm C2 Message")]
		AFIWCIADSCommC2Message = 31u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("19550ec2-526a-11df-882e-080069138b88", Description="AFIWC IADS Ground Control Interceptor (GCI) Command")]
		AFIWCIADSGroundControlInterceptorGCICommand = 32u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1958b86a-526a-11df-964f-080069138b88", Description="AFIWC Voice Text Message")]
		AFIWCVoiceTextMessage = 35u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("195c56aa-526a-11df-91e5-080069138b88", Description="ModSAF Text Radio")]
		ModsafTextRadio = 177u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("195ff3fa-526a-11df-b536-080069138b88", Description="CCTT SINCGARS ERF-LOCKOUT")]
		CCTTSINCGARSERFLOCKOUT = 200u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("19639500-526a-11df-8c6f-080069138b88", Description="CCTT SINCGARS ERF-HOPSET")]
		CCTTSINCGARSERFHOPSET = 201u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("19673886-526a-11df-94d8-080069138b88", Description="CCTT SINCGARS OTAR")]
		CCTTSINCGARSOTAR = 202u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("196ad3c4-526a-11df-aa9d-080069138b88", Description="CCTT SINCGARS DATA")]
		CCTTSINCGARSDATA = 203u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("196e7574-526a-11df-aad7-080069138b88", Description="ModSAF FWA Forward Air Controller")]
		ModsafFWAForwardAirController = 546u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1972138c-526a-11df-a296-080069138b88", Description="ModSAF Threat ADA C3")]
		ModsafThreatADAC3 = 832u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1975b082-526a-11df-bc4e-080069138b88", Description="F-16 MTC AFAPD Protocol")]
		F16MTCAFAPDProtocol = 1000u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1979f782-526a-11df-b96f-080069138b88", Description="F-16 MTC IDL Protocol")]
		F16MTCIDLProtocol = 1100u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5ce78d24-02c0-4a07-b4b1-74ca7af9f517", Description="Automatic Identification System (AIS)")]
		AutomaticIdentificationSystemAIS = 1371u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("197e3c3e-526a-11df-9bc6-080069138b88", Description="ModSAF Artillery Fire Control")]
		ModsafArtilleryFireControl = 4570u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1981da4c-526a-11df-a2b2-080069138b88", Description="AGTS")]
		AGTS = 5361u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("19857d6e-526a-11df-a3f1-080069138b88", Description="GC3")]
		GC3 = 6000u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("19891c58-526a-11df-ab12-080069138b88", Description="WNCP data")]
		WNCPData = 6010u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("198cb93a-526a-11df-9d02-080069138b88", Description="Spoken text message")]
		SpokenTextMessage = 6020u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1990ffc2-526a-11df-98d8-080069138b88", Description="Longbow IDM message")]
		LongbowIDMMessage = 6661u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("19954762-526a-11df-8542-080069138b88", Description="Comanche IDM message")]
		ComancheIDMMessage = 6662u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1999882c-526a-11df-8c26-080069138b88", Description="Longbow Airborne TACFIRE Message")]
		LongbowAirborneTACFIREMessage = 6663u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("199dcfa4-526a-11df-b705-080069138b88", Description="Longbow Ground TACFIRE Message")]
		LongbowGroundTACFIREMessage = 6664u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("19a2150a-526a-11df-88d6-080069138b88", Description="Longbow AFAPD Message")]
		LongbowAFAPDMessage = 6665u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("19a65eda-526a-11df-a245-080069138b88", Description="Longbow ERF message")]
		LongbowERFMessage = 6666u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3735b85d-ad48-4818-8907-912c1c1e6910", Description="VMF IDM")]
		VMFIDM = 7000u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("7094780e-4b7c-4d39-b6e7-eebb24a8e3f1", Description="CSAR Radio Survivor Message")]
		CSARRadioSurvivorMessage = 7010u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0380ed7c-6811-43c0-8f13-e4112dd0d3e6", Description="CSAR Radio Interrogator Message")]
		CSARRadioInterrogatorMessage = 7020u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("12bc3ded-5114-44fa-8d5a-930438dcb7e6", Description="Image File Transfer Message")]
		ImageFileTransferMessage = 7030u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9f84acd6-d1e4-4187-a0fd-2120227457ee", Description="Geotag Data Message")]
		GeotagDataMessage = 7040u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8f437b4b-b58b-4f26-8fc6-4354a591eedf", Description="Tactical Video Regeneration Data")]
		TacticalVideoRegenerationData = 7050u,
	}
}
