using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class PointerEventListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		public delegate void PointerEvent(PointerEventData eventData);

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PointerEvent PointerDown
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0xE131D0", Offset = "0xE11BD0", VA = "0x180E131D0")]
			[CompilerGenerated]
			add
			{
				PointerEvent pointerDown = this.PointerDown;
				Delegate @delegate = Delegate.Combine(pointerDown, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != pointerDown)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xE133B0", Offset = "0xE11DB0", VA = "0x180E133B0")]
			[CompilerGenerated]
			remove
			{
				PointerEvent pointerDown = this.PointerDown;
				Delegate @delegate = Delegate.Remove(pointerDown, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != pointerDown)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PointerEvent PointerUp
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xE13270", Offset = "0xE11C70", VA = "0x180E13270")]
			[CompilerGenerated]
			add
			{
				PointerEvent pointerUp = this.PointerUp;
				Delegate @delegate = Delegate.Combine(pointerUp, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != pointerUp)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xE13450", Offset = "0xE11E50", VA = "0x180E13450")]
			[CompilerGenerated]
			remove
			{
				PointerEvent pointerUp = this.PointerUp;
				Delegate @delegate = Delegate.Remove(pointerUp, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != pointerUp)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PointerEvent PointerClick
		{
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0xE13130", Offset = "0xE11B30", VA = "0x180E13130")]
			[CompilerGenerated]
			add
			{
				PointerEvent pointerClick = this.PointerClick;
				Delegate @delegate = Delegate.Combine(pointerClick, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != pointerClick)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xE13310", Offset = "0xE11D10", VA = "0x180E13310")]
			[CompilerGenerated]
			remove
			{
				PointerEvent pointerClick = this.PointerClick;
				Delegate @delegate = Delegate.Remove(pointerClick, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != pointerClick)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xE130F0", Offset = "0xE11AF0", VA = "0x180E130F0", Slot = "4")]
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			this.PointerDown?.Invoke(eventData);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xE13110", Offset = "0xE11B10", VA = "0x180E13110", Slot = "5")]
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
			this.PointerUp?.Invoke(eventData);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xE130D0", Offset = "0xE11AD0", VA = "0x180E130D0", Slot = "6")]
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
			this.PointerClick?.Invoke(eventData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PointerEventListener()
		{
			((MeshRenderer)(object)this)._002Ector();
		}
	}
}
