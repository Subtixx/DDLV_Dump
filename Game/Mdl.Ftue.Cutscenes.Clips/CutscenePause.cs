using Cpp2IlInjected;

namespace Mdl.Ftue.Cutscenes.Clips
{
	[Cpp2IlInjected.Token(Token = "0x200060B")]
	public class CutscenePause : CutsceneClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400247C")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400247D")]
		private float _elapsed;

		[Cpp2IlInjected.Token(Token = "0x6001AC3")]
		[Cpp2IlInjected.Address(RVA = "0x1111FB0", Offset = "0x11109B0", VA = "0x181111FB0", Slot = "4")]
		public override bool Play(float elapsed)
		{
			_elapsed = elapsed;
			if (!(elapsed >= duration))
			{
				return true;
			}
			_elapsed = 0f;
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC4")]
		[Cpp2IlInjected.Address(RVA = "0x1111FD0", Offset = "0x11109D0", VA = "0x181111FD0", Slot = "5")]
		public override void Stop()
		{
			_elapsed = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void Pause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void Resume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC7")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CutscenePause()
		{
		}
	}
}
