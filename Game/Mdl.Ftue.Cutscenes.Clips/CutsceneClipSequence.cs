using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Ftue.Cutscenes.Clips
{
	[Cpp2IlInjected.Token(Token = "0x2000608")]
	public class CutsceneClipSequence : CutsceneClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400246D")]
		private List<CutsceneClip> _clips = (List<CutsceneClip>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400246E")]
		private int _currentClip;

		[Cpp2IlInjected.Token(Token = "0x6001AAF")]
		[Cpp2IlInjected.Address(RVA = "0x11111D0", Offset = "0x110FBD0", VA = "0x1811111D0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0030, IL_0036, IL_0042
			CutsceneClip cutsceneClip = default(CutsceneClip);
			CutsceneClip cutsceneClip2 = default(CutsceneClip);
			while (true)
			{
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num = 0;
					if (enumerator == null)
					{
						break;
					}
					if (!cutsceneClip)
					{
						continue;
					}
					((List<T>)(object)_clips).Add((T)cutsceneClip2);
				}
				if ((object)cutsceneClip2 == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB0")]
		[Cpp2IlInjected.Address(RVA = "0x1111450", Offset = "0x110FE50", VA = "0x181111450", Slot = "4")]
		public override bool Play(float elapsed)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB1")]
		[Cpp2IlInjected.Address(RVA = "0x1111580", Offset = "0x110FF80", VA = "0x181111580", Slot = "5")]
		public override void Stop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB2")]
		[Cpp2IlInjected.Address(RVA = "0x11113D0", Offset = "0x110FDD0", VA = "0x1811113D0", Slot = "6")]
		public override void Pause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB3")]
		[Cpp2IlInjected.Address(RVA = "0x1111500", Offset = "0x110FF00", VA = "0x181111500", Slot = "7")]
		public override void Resume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB4")]
		[Cpp2IlInjected.Address(RVA = "0x1111610", Offset = "0x1110010", VA = "0x181111610")]
		public CutsceneClipSequence()
		{
		}
	}
}
