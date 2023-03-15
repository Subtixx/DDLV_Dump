using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Assets.UI.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public static class IconHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x130FDB0", Offset = "0x130E7B0", VA = "0x18130FDB0")]
		public static string GetIconAddressForGender(this IItemData itemData, bool isMale)
		{
			if (isMale && itemData != null && (object)typeof(ClothingItemData).TypeHandle == null)
			{
				return (string)typeof(ClothingItemData).TypeHandle;
			}
			throw new NullReferenceException();
		}
	}
}
