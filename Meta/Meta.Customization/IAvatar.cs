using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010D9")]
	public interface IAvatar
	{
		[Cpp2IlInjected.Token(Token = "0x170017AA")]
		IReadOnlyDictionary<uint, int> Clothes
		{
			[Cpp2IlInjected.Token(Token = "0x600888F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017AB")]
		int SkinColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6008890")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017AC")]
		int EyeColor
		{
			[Cpp2IlInjected.Token(Token = "0x6008891")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017AD")]
		int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6008892")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017AE")]
		IReadOnlyDictionary<uint, int> FaceType
		{
			[Cpp2IlInjected.Token(Token = "0x6008893")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170017AF")]
		IReadOnlyDictionary<uint, Makeup> Makeup
		{
			[Cpp2IlInjected.Token(Token = "0x6008894")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6008895")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IsWearing(ClothingItemType clothingType);

		[Cpp2IlInjected.Token(Token = "0x6008896")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsWearing(ClothingItemType clothingType, out Item item);

		[Cpp2IlInjected.Token(Token = "0x6008897")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool IsWearing(Item item);
	}
}
