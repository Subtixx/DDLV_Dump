using System.Runtime.Serialization;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Gameloft.GdidService.Model
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DeviceTypes
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[EnumMember]
		Mac = 1,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[EnumMember]
		Ios,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[EnumMember]
		Android,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[EnumMember]
		W8,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[EnumMember]
		Wp8,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[EnumMember]
		W10,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[EnumMember]
		Win32,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[EnumMember]
		Blackberry,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[EnumMember]
		Tizen,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[EnumMember]
		Tvos,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[EnumMember]
		Nx
	}
}
