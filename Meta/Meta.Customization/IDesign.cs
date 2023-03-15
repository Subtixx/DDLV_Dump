using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010ED")]
	public interface IDesign
	{
		[Cpp2IlInjected.Token(Token = "0x17001806")]
		int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60089CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001807")]
		Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60089CB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001808")]
		string BaseColor
		{
			[Cpp2IlInjected.Token(Token = "0x60089CC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001809")]
		IReadOnlyList<IDecal> Decals
		{
			[Cpp2IlInjected.Token(Token = "0x60089CD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
}
