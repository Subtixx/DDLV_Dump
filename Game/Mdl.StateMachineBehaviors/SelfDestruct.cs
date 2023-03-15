using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.StateMachineBehaviors
{
	[Cpp2IlInjected.Token(Token = "0x2000230")]
	public class SelfDestruct : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001313")]
		public float delay;

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0xCCC0D0", Offset = "0xCCAAD0", VA = "0x180CCC0D0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CDestroyAsync_003Ed__2 _003CDestroyAsync_003Ed__ = new _003CDestroyAsync_003Ed__2(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDestroyAsync_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CDestroyAsync_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0xCCC060", Offset = "0xCCAA60", VA = "0x180CCC060")]
		[IteratorStateMachine(typeof(_003CDestroyAsync_003Ed__2))]
		private IEnumerator DestroyAsync()
		{
			int _003C_003E1__state = default(int);
			_003CDestroyAsync_003Ed__2 _003CDestroyAsync_003Ed__ = new _003CDestroyAsync_003Ed__2(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDestroyAsync_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SelfDestruct()
		{
		}
	}
}
