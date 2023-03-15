using System;
using System.Collections.Generic;
using CloudScripts;
using Cpp2IlInjected;
using Gameloft.Common;
using glPlayFab;
using Google.Protobuf.Collections;
using Meta.Social;
using PlayFab.LeaderboardsModels;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FBA")]
	public static class BaseClientResultExt
	{
		[Cpp2IlInjected.Token(Token = "0x6007F55")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8DC0", Offset = "0x1AB77C0", VA = "0x181AB8DC0")]
		public static Meta.Social.Amount ToSocial(this glPlayFab.Amount self)
		{
			//Discarded unreachable code: IL_0024
			Meta.Social.Amount amount = new Meta.Social.Amount();
			int num = (amount.quantity_ = self.Quantity);
			int num2 = (amount.changed_ = self.Changed);
			return amount;
		}

		[Cpp2IlInjected.Token(Token = "0x6007F56")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8BD0", Offset = "0x1AB75D0", VA = "0x181AB8BD0")]
		public static OnlineProfile ToSocial(this BaseClientResult self)
		{
			//Discarded unreachable code: IL_0073
			OnlineProfile op = new OnlineProfile();
			Dictionary<int, glPlayFab.Amount> _003CCurrencies_003Ek__BackingField = self.Currencies;
			Action<KeyValuePair<int, glPlayFab.Amount>> action = (Action<KeyValuePair<int, glPlayFab.Amount>>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_000d
				MapField<int, Meta.Social.Amount> currencies_ = op.currencies_;
			};
			MoreLinq.ForEach<KeyValuePair<int, glPlayFab.Amount>>((IEnumerable<>)_003CCurrencies_003Ek__BackingField, (Action<>)(object)action);
			Dictionary<int, glPlayFab.Amount> _003CItems_003Ek__BackingField = self.Items;
			Action<KeyValuePair<int, glPlayFab.Amount>> action2 = (Action<KeyValuePair<int, glPlayFab.Amount>>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_000d
				MapField<int, Meta.Social.Amount> items_ = op.items_;
			};
			MoreLinq.ForEach<KeyValuePair<int, glPlayFab.Amount>>((IEnumerable<>)_003CItems_003Ek__BackingField, (Action<>)(object)action2);
			Dictionary<string, EntityStatisticValue> _003CStatistics_003Ek__BackingField = self.Statistics;
			Action<KeyValuePair<string, EntityStatisticValue>> action3 = (Action<KeyValuePair<string, EntityStatisticValue>>)(object)(Action<T>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			MoreLinq.ForEach<KeyValuePair<string, EntityStatisticValue>>((IEnumerable<>)_003CStatistics_003Ek__BackingField, (Action<>)(object)action3);
			return op;
		}
	}
}
