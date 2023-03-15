using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class TextMeshProSwitcherClip : PlayableAsset, ITimelineClipAsset
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public TextMeshProSwitcherBehaviour template;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public ClipCaps clipCaps
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x17EC850", Offset = "0x17EB250", VA = "0x1817EC850", Slot = "9")]
		get
		{
			return ClipCaps.Blending;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x17EC6E0", Offset = "0x17EB0E0", VA = "0x1817EC6E0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x17EC7C0", Offset = "0x17EB1C0", VA = "0x1817EC7C0")]
	public TextMeshProSwitcherClip()
	{
		//IL_0010: Expected I4, but got I8
		Color white = Color.white;
		TextMeshProSwitcherBehaviour textMeshProSwitcherBehaviour = default(TextMeshProSwitcherBehaviour);
		textMeshProSwitcherBehaviour.fontSize = 14;
		textMeshProSwitcherBehaviour.localizeText = true;
		template = textMeshProSwitcherBehaviour;
		base._002Ector();
	}
}
