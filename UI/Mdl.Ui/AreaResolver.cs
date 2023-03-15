using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200030C")]
	public class AreaResolver
	{
		[Cpp2IlInjected.Token(Token = "0x60013C8")]
		[Cpp2IlInjected.Address(RVA = "0x87E8C0", Offset = "0x87D2C0", VA = "0x18087E8C0")]
		public static List<ActivityDataLocationFilter> Resolver(List<VillageAreaType> areas)
		{
			//Discarded unreachable code: IL_0019, IL_001f, IL_0025
			List<ActivityDataLocationFilter> list = (List<ActivityDataLocationFilter>)(object)new List<T>();
			bool flag = default(bool);
			if (flag)
			{
				ActivityDataLocationFilter item = new ActivityDataLocationFilter();
				((List<T>)(object)list).Add((T)item);
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60013C9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AreaResolver()
		{
		}
	}
}
