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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(175, "JTIDS/MIDS Modulation Parameters-Synchronization State", 8)]
	public enum JTIDSOrMIDSModulationParametersSynchronizationState : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("7be4da22-d3de-4851-a166-fb60b0ea2fcd", Description="No Statement")]
		NoStatement = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1928b746-526a-11df-9d6c-080069138b88", Description="Initial Net Entry")]
		InitialNetEntry = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1929c87a-526a-11df-8cf1-080069138b88", Description="Coarse Synchronization")]
		CoarseSynchronization = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("39ec128b-c315-4c2b-94ee-778be0676d58", Description="Fine Synchronization")]
		FineSynchronization = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("25caa783-7a5c-4739-baea-c92df9dcac2d", Description="Synchronization Maintenance")]
		[System.ObsoleteAttribute()]
		SynchronizationMaintenance = 4,
	}
}