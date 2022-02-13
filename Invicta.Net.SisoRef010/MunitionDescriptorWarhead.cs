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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(60, "Munition Descriptor-Warhead", 16)]
	public class MunitionDescriptorWarhead {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0553387c-526a-11df-b629-080069138b88", Description="Other")]
		public const ushort Other = 0;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("055446d6-526a-11df-b81b-080069138b88", Description="Cargo (Variable Submunitions)")]
		public const ushort CargoVariableSubmunitions = 10;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0555542c-526a-11df-88c6-080069138b88", Description="Fuel/Air Explosive")]
		public const ushort FuelOrAirExplosive = 20;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0556634e-526a-11df-9a97-080069138b88", Description="Glass Beads")]
		public const ushort GlassBeads = 30;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05577194-526a-11df-a1df-080069138b88", Description="1 um")]
		public const ushort _1Um = 31;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05587d28-526a-11df-a761-080069138b88", Description="5 um")]
		public const ushort _5Um = 32;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("055989de-526a-11df-b6f7-080069138b88", Description="10 um")]
		public const ushort _10Um = 33;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("055a9752-526a-11df-bac3-080069138b88", Description="High Explosive (HE)")]
		public const ushort HighExplosiveHE = 1000;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("055ba4bc-526a-11df-836e-080069138b88", Description="HE, Plastic")]
		public const ushort HEPlastic = 1100;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("055cb320-526a-11df-8a8f-080069138b88", Description="HE, Incendiary")]
		public const ushort HEIncendiary = 1200;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("055dc0e4-526a-11df-83b8-080069138b88", Description="HE, Fragmentation")]
		public const ushort HEFragmentation = 1300;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("055ece12-526a-11df-9334-080069138b88", Description="HE, Anti-Tank")]
		public const ushort HEAntiTank = 1400;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("055fde56-526a-11df-a5b4-080069138b88", Description="HE, Bomblets")]
		public const ushort HEBomblets = 1500;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0560f4b2-526a-11df-b98c-080069138b88", Description="HE, Shaped Charge")]
		public const ushort HEShapedCharge = 1600;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0561fd12-526a-11df-9a93-080069138b88", Description="HE, Continuous Rod")]
		public const ushort HEContinuousRod = 1610;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05630de2-526a-11df-b899-080069138b88", Description="HE, Tungsten Ball")]
		public const ushort HETungstenBall = 1615;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05642222-526a-11df-99bc-080069138b88", Description="HE, Blast Fragmentation")]
		public const ushort HEBlastFragmentation = 1620;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05652c26-526a-11df-8267-080069138b88", Description="HE, Steerable Darts with HE")]
		public const ushort HESteerableDartsWithHE = 1625;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05663be8-526a-11df-9cef-080069138b88", Description="HE, Darts")]
		public const ushort HEDarts = 1630;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05674c04-526a-11df-a30b-080069138b88", Description="HE, Flechettes")]
		public const ushort HEFlechettes = 1635;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0568570c-526a-11df-8f15-080069138b88", Description="HE, Directed Fragmentation")]
		public const ushort HEDirectedFragmentation = 1640;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05696570-526a-11df-ac4d-080069138b88", Description="HE, Semi-Armor Piercing (SAP)")]
		public const ushort HESemiArmorPiercingSAP = 1645;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("056a78c0-526a-11df-97e9-080069138b88", Description="HE, Shaped Charge Fragmentation")]
		public const ushort HEShapedChargeFragmentation = 1650;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("056b8396-526a-11df-bac6-080069138b88", Description="HE, Semi-Armor Piercing, Fragmentation")]
		public const ushort HESemiArmorPiercingFragmentation = 1655;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("056c9434-526a-11df-904f-080069138b88", Description="HE, Hollow Charge")]
		public const ushort HEHollowCharge = 1660;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("056da586-526a-11df-b810-080069138b88", Description="HE, Double Hollow Charge")]
		public const ushort HEDoubleHollowCharge = 1665;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("056eb00c-526a-11df-9f95-080069138b88", Description="HE, General Purpose")]
		public const ushort HEGeneralPurpose = 1670;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("056fbee8-526a-11df-b802-080069138b88", Description="HE, Blast Penetrator")]
		public const ushort HEBlastPenetrator = 1675;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0570cf04-526a-11df-80ae-080069138b88", Description="HE, Rod Penetrator")]
		public const ushort HERodPenetrator = 1680;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0571d75a-526a-11df-98c8-080069138b88", Description="HE, Anti-Personnel")]
		public const ushort HEAntiPersonnel = 1685;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8f323a2f-1fa5-4b64-a0ab-f4a71848e70d", Description="HE, Shaped Charge, Fragmentation, Incendiary")]
		public const ushort HEShapedChargeFragmentationIncendiary = 1690;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c7a20cb8-232d-4fff-9e7e-3190c51c42d2", Description="HE, Penetrator, Blast, Fragmentation")]
		public const ushort HEPenetratorBlastFragmentation = 1695;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0572e6e0-526a-11df-9022-080069138b88", Description="Smoke")]
		public const ushort Smoke = 2000;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ac2b65f0-b166-41ad-9510-f72ce7e6795c", Description="WP (White Phosphorus)")]
		public const ushort WPWhitePhosphorus = 2005;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5c629414-0419-48a2-b713-3fbd202d3295", Description="FOGO (Fog Oil)")]
		public const ushort FOGOFogOil = 2010;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8aea604b-3112-4ac3-9313-20512bc3ba19", Description="HC (HexaChloroEthane)")]
		public const ushort HCHexachloroethane = 2015;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0573f896-526a-11df-aaf9-080069138b88", Description="Illumination")]
		public const ushort Illumination = 3000;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05750272-526a-11df-aab5-080069138b88", Description="Practice")]
		public const ushort Practice = 4000;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b3c239e-faa5-4c67-8d78-e544cafc2a92", Description="Blank")]
		public const ushort Blank = 4001;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("066b68ad-993a-429e-a57f-faf9bfc5c2f6", Description="Dummy")]
		public const ushort Dummy = 4002;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("057610cc-526a-11df-a33e-080069138b88", Description="Kinetic")]
		public const ushort Kinetic = 5000;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05772174-526a-11df-a43f-080069138b88", Description="Mines")]
		public const ushort Mines = 6000;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("057829fc-526a-11df-92b4-080069138b88", Description="Nuclear")]
		public const ushort Nuclear = 7000;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("057936ee-526a-11df-87bc-080069138b88", Description="Nuclear, IMT")]
		public const ushort NuclearIMT = 7010;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("057a4b1a-526a-11df-b08c-080069138b88", Description="Chemical, General")]
		public const ushort ChemicalGeneral = 8000;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("057b58fc-526a-11df-bdfa-080069138b88", Description="Chemical, Blister Agent")]
		public const ushort ChemicalBlisterAgent = 8100;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("057c6846-526a-11df-befd-080069138b88", Description="HD (Mustard)")]
		public const ushort HDMustard = 8110;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("057d76e6-526a-11df-8175-080069138b88", Description="Thickened HD (Mustard)")]
		public const ushort ThickenedHDMustard = 8115;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("057e9058-526a-11df-a083-080069138b88", Description="Dusty HD (Mustard)")]
		public const ushort DustyHDMustard = 8120;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3acedfff-a686-4e53-99bc-fd968863047f", Description="L (Lewisite)")]
		public const ushort LLewisite = 8125;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1cd293b5-2031-45e8-b99c-69cc1ea47cbc", Description="HN3 (Nitrogen Mustard)")]
		public const ushort HN3NitrogenMustard = 8130;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("36d90616-7ad9-43d6-8c54-8818f174546a", Description="HL (Mustard/Lewisite)")]
		public const ushort HLMustardOrLewisite = 8135;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("690c3393-e653-4a77-aecc-ede0220e7a63", Description="CX (Phosgene Oxime)")]
		public const ushort CXPhosgeneOxime = 8140;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e7dda79d-8e90-4c66-a24e-4d7457d7a338", Description="DMMP (Phosphate Dimethyl Hydrogen)")]
		public const ushort DMMPPhosphateDimethylHydrogen = 8145;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9377bd73-812c-4410-8b5c-736f08b197a3", Description="DMHP (Phosphite)")]
		public const ushort DMHPPhosphite = 8150;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8f413abf-2a29-4739-9d75-5a87cbea485f", Description="DMA (Dimethyl Acrylate)")]
		public const ushort DMADimethylAcrylate = 8155;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8c705256-e0c0-4214-8812-c345cfca3de5", Description="DEM")]
		public const ushort DEM = 8160;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2899dc81-bae0-4014-96db-671de8b722b9", Description="PX (P-xlene)")]
		public const ushort PXPXlene = 8165;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("057fa92a-526a-11df-82af-080069138b88", Description="Chemical, Blood Agent")]
		public const ushort ChemicalBloodAgent = 8200;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0580ba18-526a-11df-847a-080069138b88", Description="AC (HCN)")]
		public const ushort ACHCN = 8210;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0581c26e-526a-11df-8acd-080069138b88", Description="CK (CNCI)")]
		public const ushort CKCNCI = 8215;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0582d29e-526a-11df-96da-080069138b88", Description="CG (Phosgene)")]
		public const ushort CGPhosgene = 8220;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0583e594-526a-11df-a97d-080069138b88", Description="Chemical, Nerve Agent")]
		public const ushort ChemicalNerveAgent = 8300;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0584ef5c-526a-11df-a7be-080069138b88", Description="VX")]
		public const ushort VX = 8310;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0585fcbc-526a-11df-abbf-080069138b88", Description="Thickened VX")]
		public const ushort ThickenedVX = 8315;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05870cb0-526a-11df-9c2d-080069138b88", Description="Dusty VX")]
		public const ushort DustyVX = 8320;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("058816e6-526a-11df-a9e2-080069138b88", Description="GA (Tabun)")]
		public const ushort GATabun = 8325;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("058924f0-526a-11df-969e-080069138b88", Description="Thickened GA (Tabun)")]
		public const ushort ThickenedGATabun = 8330;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("058a380e-526a-11df-94bc-080069138b88", Description="Dusty GA (Tabun)")]
		public const ushort DustyGATabun = 8335;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("058b41c2-526a-11df-a16b-080069138b88", Description="GB (Sarin)")]
		public const ushort GBSarin = 8340;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("058c4fe0-526a-11df-9d11-080069138b88", Description="Thickened GB (Sarin)")]
		public const ushort ThickenedGBSarin = 8345;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("058d6150-526a-11df-94cf-080069138b88", Description="Dusty GB (Sarin)")]
		public const ushort DustyGBSarin = 8350;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("058e6b68-526a-11df-85f8-080069138b88", Description="GD (Soman)")]
		public const ushort GDSoman = 8355;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("058f79ea-526a-11df-8ecd-080069138b88", Description="Thickened GD (Soman)")]
		public const ushort ThickenedGDSoman = 8360;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("05908a92-526a-11df-922e-080069138b88", Description="Dusty GD (Soman)")]
		public const ushort DustyGDSoman = 8365;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("059191c6-526a-11df-ac2c-080069138b88", Description="GF")]
		public const ushort GF = 8370;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0592a1ce-526a-11df-999c-080069138b88", Description="Thickened GF")]
		public const ushort ThickenedGF = 8375;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0593b456-526a-11df-b241-080069138b88", Description="Dusty GF")]
		public const ushort DustyGF = 8380;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("7031ae99-bd54-47bd-949b-2c0a3220d5b3", Description="SVX (Soviet VX)")]
		public const ushort SVXSovietVX = 8385;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3e2209b4-28d8-4374-9b3c-f3a4849b7dc1", Description="BIS")]
		public const ushort BIS = 8410;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3d49d7f0-0095-4a38-9aae-fb4d8b47431d", Description="TCP")]
		public const ushort TCP = 8415;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("42f4745f-2095-4f7e-82b4-40d1f941454d", Description="MS (Methyl Salicylate)")]
		public const ushort MSMethylSalicylate = 8425;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6ed6ffb7-b5c9-4dd0-865b-ffa9a9042b09", Description="TEP")]
		public const ushort TEP = 8430;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("10fd31d1-0e12-4eda-9c59-a3df6d8ba57f", Description="H2O (Water)")]
		public const ushort H2OWater = 8445;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d3ad1651-bbf1-4eb2-8eed-bbc8a53345ec", Description="TO1 (Toxic Organic 1)")]
		public const ushort TO1ToxicOrganic1 = 8450;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("023612e3-3117-4cc7-b5d4-f965b953c7e5", Description="TO2 (Toxic Organic 2)")]
		public const ushort TO2ToxicOrganic2 = 8455;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("df6ed89a-d402-4f32-b51b-4404d8ca3a10", Description="TO3 (Toxic Organic 3)")]
		public const ushort TO3ToxicOrganic3 = 8460;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c69d0277-b751-4d3a-bbac-121c67e4b7c7", Description="Sulfur Hexafluoride")]
		public const ushort SulfurHexafluoride = 8465;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("fd2fa52f-2c5c-47f6-b1f7-27cae6713c35", Description="AA (Acetic Acid)")]
		public const ushort AAAceticAcid = 8470;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1901fe78-3891-40ec-a127-6de3a503e805", Description="HF (Hydrofluoric Acid)")]
		public const ushort HFHydrofluoricAcid = 8475;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0594bd1a-526a-11df-8268-080069138b88", Description="Biological")]
		public const ushort Biological = 9000;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0595cc0a-526a-11df-ac6c-080069138b88", Description="Biological, Virus")]
		public const ushort BiologicalVirus = 9100;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0596de42-526a-11df-9187-080069138b88", Description="Biological, Bacteria")]
		public const ushort BiologicalBacteria = 9200;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0597e8d2-526a-11df-babe-080069138b88", Description="Biological, Rickettsia")]
		public const ushort BiologicalRickettsia = 9300;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0598f7a4-526a-11df-aa18-080069138b88", Description="Biological, Genetically Modified Micro-organisms")]
		public const ushort BiologicalGeneticallyModifiedMicroOrganisms = 9400;
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("059a0928-526a-11df-96da-080069138b88", Description="Biological, Toxin")]
		public const ushort BiologicalToxin = 9500;
	}
}