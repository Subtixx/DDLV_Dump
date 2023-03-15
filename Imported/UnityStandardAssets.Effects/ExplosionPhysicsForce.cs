using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public float explosionForce = 4f;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2F10840", Offset = "0x2F0F240", VA = "0x182F10840")]
		[IteratorStateMachine(typeof(_003CStart_003Ed__1))]
		private IEnumerator Start()
		{
			int _003C_003E1__state = default(int);
			_003CStart_003Ed__1 _003CStart_003Ed__ = new _003CStart_003Ed__1(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CStart_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2F108B0", Offset = "0x2F0F2B0", VA = "0x182F108B0")]
		public ExplosionPhysicsForce()
		{
		}
	}
}
