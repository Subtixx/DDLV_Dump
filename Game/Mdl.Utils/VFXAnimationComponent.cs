using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007D3")]
	[RequireComponent(typeof(Animator))]
	internal class VFXAnimationComponent : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20007D4")]
		private class VFXAnimation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002C06")]
			public GameObject vfxPrefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002C07")]
			public string eventStringParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002C08")]
			public Transform parent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4002C09")]
			public string outEventStringParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4002C0A")]
			public string outAnimatorBool;

			[Cpp2IlInjected.Token(Token = "0x60022C9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public VFXAnimation()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002C04")]
		[SerializeField]
		private VFXAnimation[] _animations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C05")]
		private readonly List<(GameObject vfx, string eventParameter, string outAnimatorBool)> vfxToMonitor = (List<(GameObject vfx, string eventParameter, string outAnimatorBool)>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60022C7")]
		[Cpp2IlInjected.Address(RVA = "0xD40F00", Offset = "0xD3F900", VA = "0x180D40F00")]
		public void PlayVFXAnimation(string eventData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022C8")]
		[Cpp2IlInjected.Address(RVA = "0xD412D0", Offset = "0xD3FCD0", VA = "0x180D412D0")]
		public VFXAnimationComponent()
		{
		}
	}
}
