using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Ftue.Cutscenes;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Cpp2IlInjected.Token(Token = "0x200006F")]
[TrackColor(0.1394896f, 0.4411765f, 0.3413077f)]
[TrackBindingType(typeof(TextMeshProUGUI))]
[TrackClipType(typeof(TextMeshProSwitcherClip))]
public class TextMeshProSwitcherTrack : TrackAsset, ITextTrack
{
	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x17ECDF0", Offset = "0x17EB7F0", VA = "0x1817ECDF0", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x17ECEB0", Offset = "0x17EB8B0", VA = "0x1817ECEB0", Slot = "28")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
		base.GatherProperties(director, driver);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x17ECEC0", Offset = "0x17EB8C0", VA = "0x1817ECEC0", Slot = "35")]
	public void SetTrackText(Dictionary<string, string> textForTracks, bool localizeText)
	{
		//Discarded unreachable code: IL_0023, IL_0027, IL_0049, IL_004f, IL_0055, IL_005b, IL_0061, IL_0067
		//IL_0042: Expected O, but got I4
		int num = 0;
		IEnumerable<TimelineClip> enumerable = (IEnumerable<TimelineClip>)base.GetClips();
		if (enumerable != null)
		{
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					int num3 = 0;
					int num4 = 0;
					bool flag = default(bool);
					while (!flag)
					{
					}
					string text = (string)((Dictionary<TKey, TValue>)(object)textForTracks)[(TKey)num4];
					goto IL_0044;
				}
				num++;
			}
			throw new NullReferenceException();
		}
		goto IL_0044;
		IL_0044:
		if (enumerable == null)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x17ED180", Offset = "0x17EBB80", VA = "0x1817ED180")]
	public TextMeshProSwitcherTrack()
	{
	}
}
