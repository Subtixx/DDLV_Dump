using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000691")]
	public static class SpawnHelperExt
	{
		[Cpp2IlInjected.Token(Token = "0x6004AE2")]
		[Cpp2IlInjected.Address(RVA = "0x262BC20", Offset = "0x262A620", VA = "0x18262BC20")]
		public static bool IsRadiusUseless(this ISpawnHelper spawnData)
		{
			//Discarded unreachable code: IL_0047
			//IL_002c: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			bool flag = default(bool);
			List<LocationSource> list = default(List<LocationSource>);
			if (!flag)
			{
				list = (List<LocationSource>)(object)new List<T>();
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				((List<T>)(object)list).Add((T)num);
			}
			Func<LocationSource, bool> func = (Func<LocationSource, bool>)(object)new Func<T, TResult>(IsRadiusUselessForSource);
			int num4 = 0;
			return ((IEnumerable<>)list).All<LocationSource>((Func<, >)(object)func);
			[Cpp2IlInjected.Token(Token = "0x6004AE3")]
			[Cpp2IlInjected.Address(RVA = "0x262BE60", Offset = "0x262A860", VA = "0x18262BE60")]
			static bool IsRadiusUselessForSource(LocationSource src)
			{
				//Discarded unreachable code: IL_0014
				LocationSource.LocationOneofCase locationCase_ = src.locationCase_;
				if (locationCase_ > LocationSource.LocationOneofCase.Anywhere && locationCase_ != LocationSource.LocationOneofCase.Realm)
				{
					int num5 = 0;
				}
				return true;
			}
		}
	}
}
