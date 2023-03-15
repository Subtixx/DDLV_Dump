using System;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000998")]
	internal static class IBurningStateExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6005427")]
		[Cpp2IlInjected.Address(RVA = "0x1707B40", Offset = "0x1706540", VA = "0x181707B40")]
		internal unsafe static void OnBurningStateCollected(this BurningState.IBurningState burningState, DateTime now, IWorldEventDispatcher dispatcher, ItemInstance item)
		{
			//Discarded unreachable code: IL_0062
			int num = 0;
			if ("BurningStateData" == null)
			{
				bool flag = ProtoDatabase.Instance.TryGet("BurningStateData", out *(BurningStateData*)num);
				DateTime dateTime = default(DateTime);
				TimeSpan timeSpan = now - dateTime;
				TimeSpan timeSpan2 = default(TimeSpan);
				if (timeSpan < timeSpan2)
				{
					TimeSpan timeSpan3 = default(TimeSpan);
					TimeSpan timeSpan4 = timeSpan3 - timeSpan;
					DateTime dateTime2 = default(DateTime);
					Timestamp timestamp = (dateTime2 - timeSpan4).ToProto();
				}
			}
			Timestamp timestamp2 = now.ToProto();
			uint num2 = default(uint);
			if (dispatcher != null && num < (int)num2)
			{
				num += num;
				num++;
			}
		}
	}
}
