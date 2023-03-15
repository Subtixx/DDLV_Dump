using System;
using Cpp2IlInjected;
using Mdl.Motion;
using Mdl.Ui;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005D6")]
	public class TimelineFade : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023C3")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x60019FD")]
		[Cpp2IlInjected.Address(RVA = "0x13CE5D0", Offset = "0x13CCFD0", VA = "0x1813CE5D0")]
		public unsafe void FadeOut()
		{
			//Discarded unreachable code: IL_0024
			//IL_001f: Expected O, but got I4
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			BaseUiRoot _003CInstance_003Ek__BackingField2 = BaseUiRoot.Instance;
			Color black = Color.black;
			int num = default(int);
			EasingFunction easingFunction = new EasingFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60019FE")]
		[Cpp2IlInjected.Address(RVA = "0x13CE440", Offset = "0x13CCE40", VA = "0x1813CE440")]
		public unsafe void FadeIn()
		{
			//Discarded unreachable code: IL_001c
			//IL_0018: Expected O, but got I4
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			Color black = Color.black;
			int num = default(int);
			EasingFunction easingFunction = new EasingFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60019FF")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineFade()
		{
		}
	}
}
