using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010EC")]
	public interface IDecal : IEquatable<IDecal>
	{
		[Cpp2IlInjected.Token(Token = "0x170017FC")]
		Item DecalItem
		{
			[Cpp2IlInjected.Token(Token = "0x60089C0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017FD")]
		string Color
		{
			[Cpp2IlInjected.Token(Token = "0x60089C1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017FE")]
		IVector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x60089C2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017FF")]
		IVector3 Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60089C3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001800")]
		float Size
		{
			[Cpp2IlInjected.Token(Token = "0x60089C4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001801")]
		bool Flipped
		{
			[Cpp2IlInjected.Token(Token = "0x60089C5")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001802")]
		bool Cutout
		{
			[Cpp2IlInjected.Token(Token = "0x60089C6")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001803")]
		bool SeeThrough
		{
			[Cpp2IlInjected.Token(Token = "0x60089C7")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001804")]
		bool UVSpace
		{
			[Cpp2IlInjected.Token(Token = "0x60089C8")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001805")]
		bool Repeat
		{
			[Cpp2IlInjected.Token(Token = "0x60089C9")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}
	}
}
