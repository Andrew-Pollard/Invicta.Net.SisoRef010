:: *****************************************************************************
:: This script must be run using the Visual Studio Developer Command Prompt

:: If you receive a System.PlatformNotSupportedException: 'Compiling
:: JScript/CSharp scripts is not supported' exception when attempting to to use
:: the generated .cs file check that XmlArrayItemAttributes for multidimensional
:: arrays have been correctly generated.
:: *****************************************************************************

xsd SISO-REF-010.xsd /classes /language:CS /namespace:Invicta.Net.SisoRef010.CodeGeneration.Xml
