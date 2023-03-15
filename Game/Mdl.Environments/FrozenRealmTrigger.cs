using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200064A")]
	public class FrozenRealmTrigger : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002589")]
		public EventHandler<Collider> onTriggerEntered;

		[Cpp2IlInjected.Token(Token = "0x6001C07")]
		[Cpp2IlInjected.Address(RVA = "0x1470F10", Offset = "0x146F910", VA = "0x181470F10")]
		private void OnTriggerEnter(Collider other)
		{
			((EventHandler<TEventArgs>)(object)onTriggerEntered)?.Invoke((object)this, (TEventArgs)other);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C08")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FrozenRealmTrigger()
		{
		}
	}
}
