using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200064F")]
	public static class IItemDataExt
	{
		[Cpp2IlInjected.Token(Token = "0x6004A39")]
		[Cpp2IlInjected.Address(RVA = "0x27B2AB0", Offset = "0x27B14B0", VA = "0x1827B2AB0")]
		public static string GetLocIdRoot(this IItemData itemdata)
		{
			//Discarded unreachable code: IL_0002
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A3A")]
		[Cpp2IlInjected.Address(RVA = "0x27B2B30", Offset = "0x27B1530", VA = "0x1827B2B30")]
		public static string GetLocIdRoot(Item item, string name)
		{
			//Discarded unreachable code: IL_010d
			MissionItemType missionItemType = default(MissionItemType);
			string text = default(string);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (missionItemType != 0)
				{
					break;
				}
				char[] array = new char[num2];
				array[0] = '!';
				string[] array2 = name.Split(array);
				string[] array3 = new string[6];
				int length = array2.Length;
				if (text != null && array3 == null)
				{
					continue;
				}
				array3[0] = text;
				if ("/" != null && "/" == null)
				{
					continue;
				}
				array3[1] = "/";
				int length2 = array2.Length;
				int num3 = length2 - 1;
				string text2 = array2[num3];
				if (text2 != null && length2 == 0)
				{
					continue;
				}
				array3[2] = text2;
				if ("." != null && "." == null)
				{
					continue;
				}
				array3[3] = ".";
				if ("." != null)
				{
					array3[4] = name;
					if ("_" == null || "_" != null)
					{
						array3[5] = "_";
						string text3 = string.Concat(array3);
						break;
					}
				}
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag || !flag)
			{
			}
			string result = default(string);
			return result;
		}
	}
}
