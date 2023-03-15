using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005BA")]
	public abstract class CutsceneClip : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x170003A6")]
		public Camera Camera
		{
			[Cpp2IlInjected.Token(Token = "0x6001985")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCamera_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001986")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCamera_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001987")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool Play(float elapsed);

		[Cpp2IlInjected.Token(Token = "0x6001988")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Stop();

		[Cpp2IlInjected.Token(Token = "0x6001989")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Pause();

		[Cpp2IlInjected.Token(Token = "0x600198A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void Resume();

		[Cpp2IlInjected.Token(Token = "0x600198B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected CutsceneClip()
		{
		}
	}
}
