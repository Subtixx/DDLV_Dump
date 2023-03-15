using System;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	public interface IProtobufOneOfDefaultValue
	{
		[Cpp2IlInjected.Token(Token = "0x6000DD9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object GetDefaultValue(Enum enumValue);
	}
}
