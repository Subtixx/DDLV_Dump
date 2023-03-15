using Cpp2IlInjected;
using Mdl.Avatar;
using Meta.Customization;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000718")]
	public interface IAvatarInfoProvider
	{
		[Cpp2IlInjected.Token(Token = "0x17000474")]
		bool IsMale
		{
			[Cpp2IlInjected.Token(Token = "0x6001F78")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000475")]
		GameObject GO
		{
			[Cpp2IlInjected.Token(Token = "0x6001F79")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000476")]
		AvatarAppearance.BodyType BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6001F7A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000477")]
		AvatarHairColorConfig HairColorConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6001F7B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000478")]
		Meta.Customization.Avatar Data
		{
			[Cpp2IlInjected.Token(Token = "0x6001F7C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}
	}
}
