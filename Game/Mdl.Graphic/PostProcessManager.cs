using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x20004AD")]
	public class PostProcessManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4001D4B")]
		public static PostProcessManager Instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001D4C")]
		private Stack<VolumeProfile> postProcessOverrides = (Stack<VolumeProfile>)(object)new Stack<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D4D")]
		public VolumeProfile noDOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D4E")]
		public VolumeProfile nearDOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001D4F")]
		public VolumeProfile midDOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D50")]
		public VolumeProfile farDOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001D51")]
		public VolumeProfile baseProfile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001D52")]
		public Volume A;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001D53")]
		public Volume B;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001D54")]
		public Volume DisableEffectVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001D55")]
		public Volume DOFVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001D56")]
		public Volume PhotoEffect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001D57")]
		public DOFDistance currentDOF = DOFDistance.DEFAULT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4001D58")]
		public bool forced;

		[Cpp2IlInjected.Token(Token = "0x60014BF")]
		[Cpp2IlInjected.Address(RVA = "0xCB6770", Offset = "0xCB5170", VA = "0x180CB6770")]
		public void Awake()
		{
			Instance = this;
			Volume dOFVolume = DOFVolume;
			VolumeProfile volumeProfile = (dOFVolume.sharedProfile = baseProfile);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014C0")]
		[Cpp2IlInjected.Address(RVA = "0xCB68C0", Offset = "0xCB52C0", VA = "0x180CB68C0")]
		public void PushPostProcessOverride(VolumeProfile postProcessProfile)
		{
			//Discarded unreachable code: IL_0029
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!(postProcessProfile != (UnityEngine.Object)num) || flag)
			{
			}
			((Stack<T>)(object)postProcessOverrides).Push((T)postProcessProfile);
			TransitionToNewPostProcess(postProcessProfile);
		}

		[Cpp2IlInjected.Token(Token = "0x60014C1")]
		[Cpp2IlInjected.Address(RVA = "0xCB67E0", Offset = "0xCB51E0", VA = "0x180CB67E0")]
		public void PopPostProcessOverride()
		{
			//Discarded unreachable code: IL_0031
			Stack<VolumeProfile> stack = postProcessOverrides;
			Debug.LogWarning("PostProcessOverride Push / Pop is unbalanced");
			VolumeProfile volumeProfile = (VolumeProfile)((Stack<T>)(object)postProcessOverrides).Peek();
			VolumeProfile newPostProcess = baseProfile;
			TransitionToNewPostProcess(newPostProcess);
		}

		[Cpp2IlInjected.Token(Token = "0x60014C2")]
		[Cpp2IlInjected.Address(RVA = "0xCB6BA0", Offset = "0xCB55A0", VA = "0x180CB6BA0")]
		public void StartPushPhotoEffectPostProcessCoroutine(float duration, VolumeProfile postProcessProfile)
		{
			//Discarded unreachable code: IL_002d
			StopAllCoroutines();
			int _003C_003E1__state = default(int);
			_003C_003CStartPushPhotoEffectPostProcessCoroutine_003Eg__PushPhotoEffectPostProcess_007C16_0_003Ed _003C_003CStartPushPhotoEffectPostProcessCoroutine_003Eg__PushPhotoEffectPostProcess_007C16_0_003Ed = new _003C_003CStartPushPhotoEffectPostProcessCoroutine_003Eg__PushPhotoEffectPostProcess_007C16_0_003Ed(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003C_003CStartPushPhotoEffectPostProcessCoroutine_003Eg__PushPhotoEffectPostProcess_007C16_0_003Ed._003C_003E4__this = this;
			_003C_003CStartPushPhotoEffectPostProcessCoroutine_003Eg__PushPhotoEffectPostProcess_007C16_0_003Ed.postProcessProfile = postProcessProfile;
			_003C_003CStartPushPhotoEffectPostProcessCoroutine_003Eg__PushPhotoEffectPostProcess_007C16_0_003Ed.duration = duration;
			Coroutine coroutine = StartCoroutine(_003C_003CStartPushPhotoEffectPostProcessCoroutine_003Eg__PushPhotoEffectPostProcess_007C16_0_003Ed);
		}

		[Cpp2IlInjected.Token(Token = "0x60014C3")]
		[Cpp2IlInjected.Address(RVA = "0xCB6B10", Offset = "0xCB5510", VA = "0x180CB6B10")]
		public void StartPopPhotoEffectPostProcessCoroutine(float duration)
		{
			//Discarded unreachable code: IL_0026
			StopAllCoroutines();
			int _003C_003E1__state = default(int);
			_003C_003CStartPopPhotoEffectPostProcessCoroutine_003Eg__PopPhotoEffectPostProcess_007C17_0_003Ed _003C_003CStartPopPhotoEffectPostProcessCoroutine_003Eg__PopPhotoEffectPostProcess_007C17_0_003Ed = new _003C_003CStartPopPhotoEffectPostProcessCoroutine_003Eg__PopPhotoEffectPostProcess_007C17_0_003Ed(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003C_003CStartPopPhotoEffectPostProcessCoroutine_003Eg__PopPhotoEffectPostProcess_007C17_0_003Ed._003C_003E4__this = this;
			_003C_003CStartPopPhotoEffectPostProcessCoroutine_003Eg__PopPhotoEffectPostProcess_007C17_0_003Ed.duration = duration;
			Coroutine coroutine = StartCoroutine(_003C_003CStartPopPhotoEffectPostProcessCoroutine_003Eg__PopPhotoEffectPostProcess_007C17_0_003Ed);
		}

		[Cpp2IlInjected.Token(Token = "0x60014C4")]
		[Cpp2IlInjected.Address(RVA = "0xCB69F0", Offset = "0xCB53F0", VA = "0x180CB69F0")]
		public void SetDof(DOFDistance d)
		{
			//Discarded unreachable code: IL_003e
			if (!forced)
			{
				if (d == DOFDistance.NONE || d == DOFDistance.NONE || d == DOFDistance.NONE || d != 0)
				{
				}
				VolumeProfile sharedProfile = noDOF;
				bool flag = default(bool);
				if (flag)
				{
				}
				Volume dOFVolume = DOFVolume;
				currentDOF = d;
				dOFVolume.sharedProfile = sharedProfile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014C5")]
		[Cpp2IlInjected.Address(RVA = "0xCB6CD0", Offset = "0xCB56D0", VA = "0x180CB6CD0")]
		private void TransitionToNewPostProcess(VolumeProfile newPostProcess, float duration = 0.5f)
		{
			//Discarded unreachable code: IL_0091
			StopAllCoroutines();
			Volume b = B;
			Volume a = A;
			VolumeProfile volumeProfile = (a.sharedProfile = b.sharedProfile);
			A.weight = 1f;
			A.priority = 9f;
			B.sharedProfile = newPostProcess;
			B.weight = 0f;
			B.priority = 10f;
			int _003C_003E1__state = default(int);
			_003CTransitionCoroutine_003Ed__21 _003CTransitionCoroutine_003Ed__ = new _003CTransitionCoroutine_003Ed__21(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTransitionCoroutine_003Ed__._003C_003E4__this = this;
			_003CTransitionCoroutine_003Ed__.duration = duration;
			Coroutine coroutine = StartCoroutine(_003CTransitionCoroutine_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x60014C6")]
		[Cpp2IlInjected.Address(RVA = "0xCB6C50", Offset = "0xCB5650", VA = "0x180CB6C50")]
		[IteratorStateMachine(typeof(_003CTransitionCoroutine_003Ed__21))]
		private IEnumerator TransitionCoroutine(float duration)
		{
			int _003C_003E1__state = default(int);
			_003CTransitionCoroutine_003Ed__21 _003CTransitionCoroutine_003Ed__ = new _003CTransitionCoroutine_003Ed__21(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTransitionCoroutine_003Ed__._003C_003E4__this = this;
			_003CTransitionCoroutine_003Ed__.duration = duration;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014C7")]
		[Cpp2IlInjected.Address(RVA = "0xCB6F20", Offset = "0xCB5920", VA = "0x180CB6F20")]
		public PostProcessManager()
		{
		}//IL_0016: Expected I4, but got I8

	}
}
