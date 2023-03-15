using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000741")]
	internal class DestroyAfterTime : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A0C")]
		public float destroyAfterSeconds;

		[Cpp2IlInjected.Token(Token = "0x600204D")]
		[Cpp2IlInjected.Address(RVA = "0x1625CA0", Offset = "0x16246A0", VA = "0x181625CA0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CDestroyAfter_003Ed__2 _003CDestroyAfter_003Ed__ = new _003CDestroyAfter_003Ed__2(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDestroyAfter_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CDestroyAfter_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x600204E")]
		[Cpp2IlInjected.Address(RVA = "0x1625C30", Offset = "0x1624630", VA = "0x181625C30")]
		[IteratorStateMachine(typeof(_003CDestroyAfter_003Ed__2))]
		private IEnumerator DestroyAfter()
		{
			int _003C_003E1__state = default(int);
			_003CDestroyAfter_003Ed__2 _003CDestroyAfter_003Ed__ = new _003CDestroyAfter_003Ed__2(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDestroyAfter_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600204F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DestroyAfterTime()
		{
		}
	}
}
