using System;
using Cpp2IlInjected;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010EB")]
	public interface IVector3 : IEquatable<IVector3>
	{
		[Cpp2IlInjected.Token(Token = "0x170017F9")]
		float X
		{
			[Cpp2IlInjected.Token(Token = "0x60089BD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017FA")]
		float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60089BE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017FB")]
		float Z
		{
			[Cpp2IlInjected.Token(Token = "0x60089BF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
