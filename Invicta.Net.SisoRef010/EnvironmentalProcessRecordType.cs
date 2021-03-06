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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(250, "Environmental Process-Record Type", 32)]
	public enum EnvironmentalProcessRecordType : uint {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d251fec-526a-11df-9212-080069138b88", Description="COMBIC State")]
		COMBICState = 256u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d2629dc-526a-11df-9296-080069138b88", Description="Flare State")]
		FlareState = 259u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d273b74-526a-11df-bdbe-080069138b88", Description="Bounding Sphere Record")]
		BoundingSphereRecord = 65536u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d284dd4-526a-11df-a856-080069138b88", Description="Uniform Geometry Record")]
		UniformGeometryRecord = 327680u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d295d1e-526a-11df-8559-080069138b88", Description="Point Record 1")]
		PointRecord1 = 655360u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d2a6df8-526a-11df-9639-080069138b88", Description="Line Record 1")]
		LineRecord1 = 786432u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d2b7e28-526a-11df-bdc7-080069138b88", Description="Sphere Record 1")]
		SphereRecord1 = 851968u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d2c8b56-526a-11df-8acc-080069138b88", Description="Ellipsoid Record 1")]
		EllipsoidRecord1 = 1048576u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d2d9c6c-526a-11df-809b-080069138b88", Description="Cone Record 1")]
		ConeRecord1 = 3145728u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d2eae5e-526a-11df-9364-080069138b88", Description="Rectangular Volume Record 1")]
		RectangularVolumeRecord1 = 5242880u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d2fb90c-526a-11df-aa2b-080069138b88", Description="Rectangular Volume Record 3")]
		RectangularVolumeRecord3 = 83886080u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d30caf4-526a-11df-b281-080069138b88", Description="Point Record 2")]
		PointRecord2 = 167772160u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d31dfc0-526a-11df-9215-080069138b88", Description="Line Record 2")]
		LineRecord2 = 201326592u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d32e960-526a-11df-b465-080069138b88", Description="Sphere Record 2")]
		SphereRecord2 = 218103808u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d33fb70-526a-11df-9394-080069138b88", Description="Ellipsoid Record 2")]
		EllipsoidRecord2 = 268435456u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d350cf4-526a-11df-9b19-080069138b88", Description="Cone Record 2")]
		ConeRecord2 = 805306368u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d3619aa-526a-11df-a7df-080069138b88", Description="Rectangular Volume Record 2")]
		RectangularVolumeRecord2 = 1342177280u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d372a0c-526a-11df-b2d4-080069138b88", Description="Gaussian Plume Record")]
		GaussianPlumeRecord = 1610612736u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1d38407c-526a-11df-a157-080069138b88", Description="Gaussian Puff Record")]
		GaussianPuffRecord = 1879048192u,
	}
}
