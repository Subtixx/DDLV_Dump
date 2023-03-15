using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20005D9")]
	public class TimelineForceVisibility : MonoBehaviour, ITimelineCutsceneCleanUp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023CD")]
		public List<TimelineForceVisibilityInfo> forceVisibilityList;

		[Cpp2IlInjected.Token(Token = "0x6001A02")]
		[Cpp2IlInjected.Address(RVA = "0x13CE880", Offset = "0x13CD280", VA = "0x1813CE880")]
		public void ForceVisibility(string forceVisibilityID)
		{
			//IL_0055: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			List<TimelineForceVisibilityInfo> list = forceVisibilityList;
			Func<TimelineForceVisibilityInfo, bool> func = (Func<TimelineForceVisibilityInfo, bool>)(object)(Func<T, TResult>)delegate(TimelineForceVisibilityInfo x)
			{
				//Discarded unreachable code: IL_0014
				string b = forceVisibilityID;
				return string.Equals(x.forceVisibilityID, b);
			};
			TimelineForceVisibilityInfo timelineForceVisibilityInfo = Enumerable.FirstOrDefault<TimelineForceVisibilityInfo>((IEnumerable<>)list, (Func<, >)(object)func);
			if (timelineForceVisibilityInfo != null)
			{
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				int num = 0;
				if ((object)system != null)
				{
					int characterID = timelineForceVisibilityInfo.characterID;
				}
				int num2 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num2 && (timelineForceVisibilityInfo.forceVisibility ? 1 : 0) != num)
				{
					bool isVisible = timelineForceVisibilityInfo.isVisible;
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A03")]
		[Cpp2IlInjected.Address(RVA = "0x13CE780", Offset = "0x13CD180", VA = "0x1813CE780", Slot = "4")]
		public void EndCutsceneCleanup()
		{
			//Discarded unreachable code: IL_000c
			List<TimelineForceVisibilityInfo> list = forceVisibilityList;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A04")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineForceVisibility()
		{
		}
	}
}
