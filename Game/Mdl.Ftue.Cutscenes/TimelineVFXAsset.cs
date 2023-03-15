using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005FD")]
	public class TimelineVFXAsset : PlayableAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002453")]
		public TimelineVFXBehaviour template;

		[Cpp2IlInjected.Token(Token = "0x170003CD")]
		public GameObject TrackTargetObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001A85")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CTrackTargetObject_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A86")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CTrackTargetObject_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CE")]
		public TimelineVFXTrack VFXTrack
		{
			[Cpp2IlInjected.Token(Token = "0x6001A87")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CVFXTrack_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A88")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CVFXTrack_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A89")]
		[Cpp2IlInjected.Address(RVA = "0x13D1870", Offset = "0x13D0270", VA = "0x1813D1870", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8A")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public TimelineVFXAsset()
		{
		}
	}
}
