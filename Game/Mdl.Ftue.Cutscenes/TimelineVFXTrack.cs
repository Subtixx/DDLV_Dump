using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x2000601")]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(TimelineVFXAsset))]
	public class TimelineVFXTrack : TrackAsset
	{
		[Cpp2IlInjected.Token(Token = "0x6001A92")]
		[Cpp2IlInjected.Address(RVA = "0x13D1B80", Offset = "0x13D0580", VA = "0x1813D1B80", Slot = "23")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			//Discarded unreachable code: IL_0031, IL_0037, IL_003d
			//IL_0024: Expected O, but got I4
			IEnumerable<TimelineClip> enumerable = default(IEnumerable<TimelineClip>);
			bool flag = default(bool);
			int num4;
			UnityEngine.Object @object = default(UnityEngine.Object);
			do
			{
				int num = 0;
				if (enumerable == null)
				{
					break;
				}
				int num2 = 0;
				if ((object)typeof(IEnumerator<TimelineClip>).TypeHandle == null)
				{
				}
				int num3 = 0;
				while (!flag)
				{
				}
				num4 = 0;
			}
			while (!(@object != (UnityEngine.Object)num4));
			if (enumerable != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A93")]
		[Cpp2IlInjected.Address(RVA = "0x13D1ED0", Offset = "0x13D08D0", VA = "0x1813D1ED0")]
		public TimelineVFXTrack()
		{
		}
	}
}
