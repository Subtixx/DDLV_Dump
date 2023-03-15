using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AC8")]
	internal class April12ClothingRemovalUpdate : RemoveClothingProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D53")]
		[Cpp2IlInjected.Address(RVA = "0x18EA9B0", Offset = "0x18E93B0", VA = "0x1818EA9B0")]
		public April12ClothingRemovalUpdate()
		{
			//Discarded unreachable code: IL_0061
			//IL_001b: Expected O, but got I8
			//IL_002f: Expected O, but got I8
			//IL_0043: Expected O, but got I8
			//IL_0059: Expected O, but got I8
			Item[] array = new Item[4];
			array[0] = (Item)Convert.ToInt64(50900054u);
			array[0] = (Item)Convert.ToInt64(50900055u);
			array[1] = (Item)Convert.ToInt64(50900056u);
			array[1] = (Item)Convert.ToInt64(50900057u);
			base._002Ector(array);
		}
	}
}
