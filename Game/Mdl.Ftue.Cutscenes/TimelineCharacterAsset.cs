using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005F7")]
	public class TimelineCharacterAsset : PlayableAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002429")]
		public TimelineCharacterBehaviour template;

		[Cpp2IlInjected.Token(Token = "0x170003C9")]
		public GameObject TrackTargetObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001A6E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CTrackTargetObject_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A6F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CTrackTargetObject_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CA")]
		public TimelineCharacterTrack CharacterTrack
		{
			[Cpp2IlInjected.Token(Token = "0x6001A70")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CCharacterTrack_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A71")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CCharacterTrack_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A72")]
		[Cpp2IlInjected.Address(RVA = "0x13C94F0", Offset = "0x13C7EF0", VA = "0x1813C94F0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A73")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public TimelineCharacterAsset()
		{
		}
	}
}
