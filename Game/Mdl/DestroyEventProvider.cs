using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x2000211")]
	public class DestroyEventProvider : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event EventHandler DestroyEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0x1625DA0", Offset = "0x16247A0", VA = "0x181625DA0")]
			[CompilerGenerated]
			add
			{
				EventHandler destroyEvent = this.DestroyEvent;
				Delegate @delegate = Delegate.Combine(destroyEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != destroyEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x1625E40", Offset = "0x1624840", VA = "0x181625E40")]
			[CompilerGenerated]
			remove
			{
				EventHandler destroyEvent = this.DestroyEvent;
				Delegate @delegate = Delegate.Remove(destroyEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != destroyEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x1625D20", Offset = "0x1624720", VA = "0x181625D20")]
		private void OnDestroy()
		{
			if (this.DestroyEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DestroyEventProvider()
		{
		}
	}
}
