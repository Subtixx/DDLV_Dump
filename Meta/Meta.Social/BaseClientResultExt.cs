using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Gameloft.Common;
using Google.Protobuf.Collections;
using PlayFab.LeaderboardsModels;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DCC")]
	public static class BaseClientResultExt
	{
		[Cpp2IlInjected.Token(Token = "0x60072DE")]
		[Cpp2IlInjected.Address(RVA = "0x1AB89F0", Offset = "0x1AB73F0", VA = "0x181AB89F0")]
		public unsafe static Statistic ToSocial(this EntityStatisticValue self)
		{
			//Discarded unreachable code: IL_00a3
			//IL_003e: Expected I4, but got O
			Statistic statistic2 = new Statistic();
			string text = (statistic2.Metadata = self.Metadata);
			string text2 = (statistic2.Name = self.Name);
			int? value = self.Value;
			int value_ = default(int);
			if ((object)value != null)
			{
				value_ = (int)((Nullable<>*)(&value))->value;
			}
			statistic2.value_ = value_;
			int num = (statistic2.version_ = self.Version);
			Statistic statistic = statistic2;
			MapField<string, StatisticChildValue> childStatistics_ = statistic.childStatistics_;
			if (childStatistics_ != null && ((MapField<TKey, TValue>)(object)childStatistics_).Count > 0)
			{
				Dictionary<string, EntityStatisticChildValue> childStatistics = self.ChildStatistics;
				Action<KeyValuePair<string, EntityStatisticChildValue>> action = (Action<KeyValuePair<string, EntityStatisticChildValue>>)(object)(Action<T>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
				MoreLinq.ForEach<KeyValuePair<string, EntityStatisticChildValue>>((IEnumerable<>)childStatistics, (Action<>)(object)action);
			}
			return statistic;
		}
	}
}
