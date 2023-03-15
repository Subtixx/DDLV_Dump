using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005DE")]
	public class TimelineSetMultipleFlags : MonoBehaviour, ITimelineCutsceneCleanUp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023D3")]
		public List<TimelineFlag> timelineFlags;

		[Cpp2IlInjected.Token(Token = "0x6001A12")]
		[Cpp2IlInjected.Address(RVA = "0x13D0A20", Offset = "0x13CF420", VA = "0x1813D0A20")]
		public void SetFlag(string flagId)
		{
			//Discarded unreachable code: IL_0037, IL_0058
			//IL_0055: Expected O, but got I4
			List<TimelineFlag> list = timelineFlags;
			Func<TimelineFlag, bool> func = (Func<TimelineFlag, bool>)(object)(Func<T, TResult>)delegate(TimelineFlag x)
			{
				//Discarded unreachable code: IL_0014
				string b = flagId;
				return string.Equals(x.flagId, b);
			};
			if (Enumerable.FirstOrDefault<TimelineFlag>((IEnumerable<>)list, (Func<, >)(object)func) != null)
			{
				Dictionary<int, bool> dictionary = (Dictionary<int, bool>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A13")]
		[Cpp2IlInjected.Address(RVA = "0x13D0900", Offset = "0x13CF300", VA = "0x1813D0900")]
		public bool IsFlagSet(int flag)
		{
			//Discarded unreachable code: IL_0017
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A14")]
		[Cpp2IlInjected.Address(RVA = "0x13D07D0", Offset = "0x13CF1D0", VA = "0x1813D07D0", Slot = "4")]
		public void EndCutsceneCleanup()
		{
			//Discarded unreachable code: IL_000c
			List<TimelineFlag> list = timelineFlags;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A15")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineSetMultipleFlags()
		{
		}
	}
}
