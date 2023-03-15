using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ACF")]
	internal class May31ClothingRemovalUpdate : RemoveClothingProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D61")]
		[Cpp2IlInjected.Address(RVA = "0x7F3500", Offset = "0x7F1F00", VA = "0x1807F3500")]
		public May31ClothingRemovalUpdate()
		{
			//Discarded unreachable code: IL_004b
			//IL_001b: Expected O, but got I8
			//IL_002f: Expected O, but got I8
			//IL_0043: Expected O, but got I8
			Item[] array = new Item[3];
			array[0] = (Item)Convert.ToInt64(51500004u);
			array[0] = (Item)Convert.ToInt64(51300011u);
			array[1] = (Item)Convert.ToInt64(51300012u);
			base._002Ector(array);
		}
	}
}
