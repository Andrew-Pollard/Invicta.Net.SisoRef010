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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(44, "Dead Reckoning Algorithm", 8)]
	public enum DeadReckoningAlgorithm : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("037007d8-526a-11df-a7d2-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0371154c-526a-11df-977c-080069138b88", Description="Static - Non-moving Entity")]
		StaticNonMovingEntity = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("037222ca-526a-11df-a336-080069138b88", Description="DRM (FPW) - Constant Velocity / Low Acceleration Linear Motion Entity")]
		DRMFPWConstantVelocityOrLowAccelerationLinearMotionEntity = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("037330b6-526a-11df-9bff-080069138b88", Description="DRM (RPW) - Constant Velocity / Low Acceleration Linear Motion Entity with Extrap" +
			"olation of Orientation")]
		DRMRPWConstantVelocityOrLowAccelerationLinearMotionEntityWithExtrapolationOfOrientation = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("03743d3a-526a-11df-81c0-080069138b88", Description="DRM (RVW) - High Speed or Maneuvering Entity with Extrapolation of Orientation")]
		DRMRVWHighSpeedOrManeuveringEntityWithExtrapolationOfOrientation = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0375450e-526a-11df-8ded-080069138b88", Description="DRM (FVW) - High Speed or Maneuvering Entity")]
		DRMFVWHighSpeedOrManeuveringEntity = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("037656ba-526a-11df-8532-080069138b88", Description="DRM (FPB) - Similar to FPW except in Body Coordinates")]
		DRMFPBSimilarToFPWExceptInBodyCoordinates = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("03776e42-526a-11df-a48e-080069138b88", Description="DRM (RPB) - Similar to RPW except in Body Coordinates")]
		DRMRPBSimilarToRPWExceptInBodyCoordinates = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0378765c-526a-11df-a7b2-080069138b88", Description="DRM (RVB) - Similar to RVW except in Body Coordinates")]
		DRMRVBSimilarToRVWExceptInBodyCoordinates = 8,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("03798790-526a-11df-b290-080069138b88", Description="DRM (FVB) - Similar to FVW except in Body Coordinates")]
		DRMFVBSimilarToFVWExceptInBodyCoordinates = 9,
	}
}
