using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ACD")]
	internal class May10DisneyFeedbackRemovalProfileUpdate : RemoveFurnitureProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D5E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3400", Offset = "0x7F1E00", VA = "0x1807F3400")]
		public May10DisneyFeedbackRemovalProfileUpdate()
		{
			//Discarded unreachable code: IL_004b
			//IL_001b: Expected O, but got I8
			//IL_002f: Expected O, but got I8
			//IL_0043: Expected O, but got I8
			Item[] array = new Item[3];
			array[0] = (Item)Convert.ToInt64(40001148u);
			array[0] = (Item)Convert.ToInt64(40000343u);
			array[1] = (Item)Convert.ToInt64(40000574u);
			base._002Ector(array);
		}
	}
}
