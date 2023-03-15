using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000748")]
	[RequireComponent(typeof(Animation))]
	internal class FireAndForgetAnimation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A13")]
		private Animation animation;

		[Cpp2IlInjected.Token(Token = "0x6002061")]
		[Cpp2IlInjected.Address(RVA = "0x1370070", Offset = "0x136EA70", VA = "0x181370070")]
		private void Start()
		{
			//Discarded unreachable code: IL_0034
			Animation animation = (this.animation = GetComponent<Animation>());
			bool flag = this.animation.Play();
			int _003C_003E1__state = default(int);
			_003CDestroyAfterClip_003Ed__2 _003CDestroyAfterClip_003Ed__ = new _003CDestroyAfterClip_003Ed__2(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDestroyAfterClip_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CDestroyAfterClip_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002062")]
		[Cpp2IlInjected.Address(RVA = "0x1370000", Offset = "0x136EA00", VA = "0x181370000")]
		[IteratorStateMachine(typeof(_003CDestroyAfterClip_003Ed__2))]
		private IEnumerator DestroyAfterClip()
		{
			int _003C_003E1__state = default(int);
			_003CDestroyAfterClip_003Ed__2 _003CDestroyAfterClip_003Ed__ = new _003CDestroyAfterClip_003Ed__2(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDestroyAfterClip_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002063")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FireAndForgetAnimation()
		{
		}
	}
}
