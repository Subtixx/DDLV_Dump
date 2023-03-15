using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ftue.Cutscenes.Clips
{
	[Cpp2IlInjected.Token(Token = "0x200060C")]
	public class CutsceneSetAnimBool : CutsceneClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400247E")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400247F")]
		public string parameter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002480")]
		public bool isOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002481")]
		[Header("Anim events")]
		public UnityEvent OnPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002482")]
		public UnityEvent OnStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002483")]
		public UnityEvent OnPause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002484")]
		public UnityEvent OnResume;

		[Cpp2IlInjected.Token(Token = "0x6001AC8")]
		[Cpp2IlInjected.Address(RVA = "0x1112020", Offset = "0x1110A20", VA = "0x181112020", Slot = "4")]
		public override bool Play(float elapsed)
		{
			Animator animator = this.animator;
			bool value = isOn;
			string text = parameter;
			animator.SetBool(text, value);
			if (isOn)
			{
				OnPlay.Invoke();
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC9")]
		[Cpp2IlInjected.Address(RVA = "0x11120B0", Offset = "0x1110AB0", VA = "0x1811120B0", Slot = "5")]
		public override void Stop()
		{
			//Discarded unreachable code: IL_002c
			Animator animator = this.animator;
			string text = parameter;
			bool value = !isOn;
			animator.SetBool(text, value);
			OnStop.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACA")]
		[Cpp2IlInjected.Address(RVA = "0x1111FE0", Offset = "0x11109E0", VA = "0x181111FE0", Slot = "6")]
		public override void Pause()
		{
			//Discarded unreachable code: IL_001c
			//IL_0010: Expected F4, but got I4
			Animator animator = this.animator;
			int num = 0;
			animator.speed = num;
			OnPause.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACB")]
		[Cpp2IlInjected.Address(RVA = "0x1112070", Offset = "0x1110A70", VA = "0x181112070", Slot = "7")]
		public override void Resume()
		{
			//Discarded unreachable code: IL_001c
			animator.speed = 1f;
			OnResume.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ACC")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CutsceneSetAnimBool()
		{
		}
	}
}
