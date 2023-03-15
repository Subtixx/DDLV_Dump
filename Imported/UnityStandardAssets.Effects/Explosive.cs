using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class Explosive : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Transform explosionPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public float detonationImpactVelocity = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public float sizeMultiplier = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public bool reset = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public float resetTimeDelay = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private bool m_Exploded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private ObjectResetter m_ObjectResetter;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2F10950", Offset = "0x2F0F350", VA = "0x182F10950")]
		private void Start()
		{
			ObjectResetter objectResetter = (m_ObjectResetter = GetComponent<ObjectResetter>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2F108C0", Offset = "0x2F0F2C0", VA = "0x182F108C0")]
		[IteratorStateMachine(typeof(_003COnCollisionEnter_003Ed__8))]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			int _003C_003E1__state = default(int);
			_003COnCollisionEnter_003Ed__8 _003COnCollisionEnter_003Ed__ = new _003COnCollisionEnter_003Ed__8(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnCollisionEnter_003Ed__._003C_003E4__this = this;
			_003COnCollisionEnter_003Ed__.col = col;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA63A10", Offset = "0xA62410", VA = "0x180A63A10")]
		public void Reset()
		{
			m_Exploded = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2F109A0", Offset = "0x2F0F3A0", VA = "0x182F109A0")]
		public Explosive()
		{
		}
	}
}
