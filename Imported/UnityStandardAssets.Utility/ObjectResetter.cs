using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class ObjectResetter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Vector3 originalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Quaternion originalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private List<Transform> originalStructure;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Rigidbody Rigidbody;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C430", Offset = "0x2F1AE30", VA = "0x182F1C430")]
		private unsafe void Start()
		{
			//IL_000b: Expected I4, but got O
			//IL_0028: Expected native int or pointer, but got O
			List<Transform> list = (originalStructure = (List<Transform>)(object)new List<T>((int)GetComponentsInChildren<Transform>()));
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)originalPosition)->z = z;
			Transform transform2 = base.transform;
			Rigidbody rigidbody = (Rigidbody = GetComponent<Rigidbody>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C320", Offset = "0x2F1AD20", VA = "0x182F1C320")]
		public void DelayedReset(float delay)
		{
			//Discarded unreachable code: IL_0020
			int _003C_003E1__state = default(int);
			_003CResetCoroutine_003Ed__6 _003CResetCoroutine_003Ed__ = new _003CResetCoroutine_003Ed__6(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetCoroutine_003Ed__._003C_003E4__this = this;
			_003CResetCoroutine_003Ed__.delay = delay;
			Coroutine coroutine = StartCoroutine(_003CResetCoroutine_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C3B0", Offset = "0x2F1ADB0", VA = "0x182F1C3B0")]
		[IteratorStateMachine(typeof(_003CResetCoroutine_003Ed__6))]
		public IEnumerator ResetCoroutine(float delay)
		{
			int _003C_003E1__state = default(int);
			_003CResetCoroutine_003Ed__6 _003CResetCoroutine_003Ed__ = new _003CResetCoroutine_003Ed__6(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResetCoroutine_003Ed__._003C_003E4__this = this;
			_003CResetCoroutine_003Ed__.delay = delay;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ObjectResetter()
		{
		}
	}
}
