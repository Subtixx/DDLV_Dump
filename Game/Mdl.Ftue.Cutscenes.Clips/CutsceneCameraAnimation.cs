using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes.Clips
{
	[Cpp2IlInjected.Token(Token = "0x2000607")]
	public class CutsceneCameraAnimation : CutsceneClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400246A")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400246B")]
		private Transform _oldParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400246C")]
		private float _elapsed;

		[Cpp2IlInjected.Token(Token = "0x6001AA8")]
		[Cpp2IlInjected.Address(RVA = "0x1110E00", Offset = "0x110F800", VA = "0x181110E00")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0011
			Animator animator = this.animator;
			int num = ((animator.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA9")]
		[Cpp2IlInjected.Address(RVA = "0x1110F30", Offset = "0x110F930", VA = "0x181110F30", Slot = "4")]
		public override bool Play(float elapsed)
		{
			//IL_0010: Expected O, but got I4
			//IL_0056: Expected F4, but got I4
			//IL_00e0: Expected F4, but got I4
			Transform oldParent = _oldParent;
			int num = 0;
			bool flag = oldParent == (UnityEngine.Object)num;
			Animator animator = this.animator;
			if (!flag)
			{
				_elapsed = elapsed;
				AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
				float length = animatorStateInfo.m_Length;
				int loop = animatorStateInfo.m_Loop;
				Finish();
				int num2 = 0;
			}
			int num3 = 0;
			int num4 = 0;
			int layer = 0;
			animator.Play("", layer, num4);
			this.animator.enabled = true;
			Transform transform = (_oldParent = base.Camera.transform.parent);
			Transform transform2 = base.Camera.transform;
			Transform transform4 = (transform2.parentInternal = this.animator.transform);
			Transform transform5 = base.Camera.transform;
			float z = Vector3.zero.z;
			Transform transform6 = base.Camera.transform;
			Quaternion identity = Quaternion.identity;
			base.Camera.enabled = true;
			_elapsed = num3;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AAA")]
		[Cpp2IlInjected.Address(RVA = "0x1110E30", Offset = "0x110F830", VA = "0x181110E30")]
		private void Finish()
		{
			//Discarded unreachable code: IL_004b
			//IL_0010: Expected O, but got I4
			//IL_004a: Expected O, but got I8
			Transform oldParent = _oldParent;
			int num = 0;
			if (!(oldParent == (UnityEngine.Object)num))
			{
				Transform transform = base.Camera.transform;
				Transform transform2 = (transform.parentInternal = _oldParent);
				Animator animator = this.animator;
				int num2 = ((animator.enabled = false) ? 1 : 0);
				_oldParent = (Transform)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AAB")]
		[Cpp2IlInjected.Address(RVA = "0x11111C0", Offset = "0x110FBC0", VA = "0x1811111C0", Slot = "5")]
		public override void Stop()
		{
			Finish();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AAC")]
		[Cpp2IlInjected.Address(RVA = "0x1110F00", Offset = "0x110F900", VA = "0x181110F00", Slot = "6")]
		public override void Pause()
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected F4, but got I4
			Animator animator = this.animator;
			int num = 0;
			animator.speed = num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AAD")]
		[Cpp2IlInjected.Address(RVA = "0x1111190", Offset = "0x110FB90", VA = "0x181111190", Slot = "7")]
		public override void Resume()
		{
			//Discarded unreachable code: IL_0011
			animator.speed = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AAE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CutsceneCameraAnimation()
		{
		}
	}
}
