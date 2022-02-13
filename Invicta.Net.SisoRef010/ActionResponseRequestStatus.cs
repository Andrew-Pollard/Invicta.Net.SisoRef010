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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(72, "Action Response-Request Status", 32)]
	public enum ActionResponseRequestStatus : uint {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0dd4f2c4-526a-11df-acc4-080069138b88", Description="Other")]
		Other = 0u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0dd600ba-526a-11df-91e4-080069138b88", Description="Pending")]
		Pending = 1u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0dd70816-526a-11df-8022-080069138b88", Description="Executing")]
		Executing = 2u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0dd81a12-526a-11df-b6aa-080069138b88", Description="Partially Complete")]
		PartiallyComplete = 3u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0dd92948-526a-11df-8052-080069138b88", Description="Complete")]
		Complete = 4u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0dda3392-526a-11df-9048-080069138b88", Description="Request rejected")]
		RequestRejected = 5u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0ddb458e-526a-11df-bf68-080069138b88", Description="Retransmit request now")]
		RetransmitRequestNow = 6u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0ddc5910-526a-11df-9d97-080069138b88", Description="Retransmit request later")]
		RetransmitRequestLater = 7u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0ddd6346-526a-11df-a22f-080069138b88", Description="Invalid time parameters")]
		InvalidTimeParameters = 8u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0dde74ac-526a-11df-bcbe-080069138b88", Description="Simulation time exceeded")]
		SimulationTimeExceeded = 9u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0ddf8630-526a-11df-a354-080069138b88", Description="Request done")]
		RequestDone = 10u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0de09070-526a-11df-82fa-080069138b88", Description="TACCSF LOS Reply-Type 1")]
		TACCSFLOSReplyType1 = 100u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0de1a26c-526a-11df-8af3-080069138b88", Description="TACCSF LOS Reply-Type 2")]
		TACCSFLOSReplyType2 = 101u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0de2b2f6-526a-11df-b9ae-080069138b88", Description="Join Exercise Request Rejected")]
		JoinExerciseRequestRejected = 201u,
	}
}
