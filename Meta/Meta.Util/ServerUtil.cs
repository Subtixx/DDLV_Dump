using System;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B29")]
	public static class ServerUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6005E4E")]
		[Cpp2IlInjected.Address(RVA = "0x1774A50", Offset = "0x1773450", VA = "0x181774A50")]
		public static DateTime NowUtc(ProfilePlayer profilePlayer)
		{
			//Discarded unreachable code: IL_0026
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			if (profilePlayer != null)
			{
				TimeSpan timeSpan = profilePlayer.debugTimeSkipped_.ToTimeSpan();
			}
			TimeSpan zero = TimeSpan.Zero;
			return utcNow + zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E4F")]
		[Cpp2IlInjected.Address(RVA = "0x1774B60", Offset = "0x1773560", VA = "0x181774B60")]
		internal static DateTime NowUtc(ProfilePlayer profilePlayer, DateTime utcNow)
		{
			//Discarded unreachable code: IL_001e
			if (profilePlayer != null)
			{
				TimeSpan timeSpan = profilePlayer.debugTimeSkipped_.ToTimeSpan();
			}
			TimeSpan zero = TimeSpan.Zero;
			return utcNow + zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E50")]
		[Cpp2IlInjected.Address(RVA = "0x1B22B20", Offset = "0x1B21520", VA = "0x181B22B20")]
		internal static TReply Validate<TReply, TRequest>(in Player player, in World world, ITransactionContext transactionContext, TRequest request) where TReply : IMessage, new()where TRequest : IMessage, new()
		{
			if ((object)typeof(Type).TypeHandle != null)
			{
				Type typeFromHandle = typeof(ITransactionAction);
				Type typeFromHandle2 = typeof(ITransactionAction);
				if (typeFromHandle.IsAssignableFrom(typeFromHandle2))
				{
					int num = 0;
					num += num;
					num++;
					if (num != 0)
					{
						if (num == 0)
						{
							throw new InvalidCastException();
						}
						if (num == 0)
						{
							goto IL_0099;
						}
						uint num2 = default(uint);
						if (num < (int)num2)
						{
							num += num;
							num++;
						}
						if (num != 0 && num != 0 && num != 0)
						{
							int num3 = 0;
							uint num4 = default(uint);
							if (num < (int)num4)
							{
								num += num;
								num++;
							}
						}
						InventoryFullDetails inventoryFullDetails = (InventoryFullDetails)(object)((object)inventoryFullDetails + (object)inventoryFullDetails);
						num += 312;
						inventoryFullDetails = (InventoryFullDetails)(object)((object)inventoryFullDetails + (object)inventoryFullDetails);
						num += 344;
						num += num;
						num += 328;
					}
				}
			}
			int num5 = 0;
			goto IL_0099;
			IL_0099:
			throw new InvalidCastException();
		}
	}
}
