using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000693")]
	public class DragEventListener : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000694")]
		public delegate void BeginDrag();

		[Cpp2IlInjected.Token(Token = "0x2000695")]
		public delegate void Drag();

		[Cpp2IlInjected.Token(Token = "0x2000696")]
		public delegate void EndDrag();

		[Cpp2IlInjected.Token(Token = "0x2000697")]
		public delegate void PointerUp();

		[Cpp2IlInjected.Token(Token = "0x2000698")]
		public delegate void PointerDown();

		[Cpp2IlInjected.Token(Token = "0x1400004A")]
		public event BeginDrag OnBeginDragEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002A65")]
			[Cpp2IlInjected.Address(RVA = "0xF18300", Offset = "0xF16D00", VA = "0x180F18300")]
			[CompilerGenerated]
			add
			{
				BeginDrag onBeginDragEvent = this.OnBeginDragEvent;
				Delegate @delegate = Delegate.Combine(onBeginDragEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBeginDragEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A66")]
			[Cpp2IlInjected.Address(RVA = "0xF18620", Offset = "0xF17020", VA = "0x180F18620")]
			[CompilerGenerated]
			remove
			{
				BeginDrag onBeginDragEvent = this.OnBeginDragEvent;
				Delegate @delegate = Delegate.Remove(onBeginDragEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBeginDragEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004B")]
		public event Drag OnDragEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002A68")]
			[Cpp2IlInjected.Address(RVA = "0xF183A0", Offset = "0xF16DA0", VA = "0x180F183A0")]
			[CompilerGenerated]
			add
			{
				Drag onDragEvent = this.OnDragEvent;
				Delegate @delegate = Delegate.Combine(onDragEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDragEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A69")]
			[Cpp2IlInjected.Address(RVA = "0xF186C0", Offset = "0xF170C0", VA = "0x180F186C0")]
			[CompilerGenerated]
			remove
			{
				Drag onDragEvent = this.OnDragEvent;
				Delegate @delegate = Delegate.Remove(onDragEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onDragEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004C")]
		public event EndDrag OnEndDragEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002A6B")]
			[Cpp2IlInjected.Address(RVA = "0xF18440", Offset = "0xF16E40", VA = "0x180F18440")]
			[CompilerGenerated]
			add
			{
				EndDrag onEndDragEvent = this.OnEndDragEvent;
				Delegate @delegate = Delegate.Combine(onEndDragEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEndDragEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A6C")]
			[Cpp2IlInjected.Address(RVA = "0xF18760", Offset = "0xF17160", VA = "0x180F18760")]
			[CompilerGenerated]
			remove
			{
				EndDrag onEndDragEvent = this.OnEndDragEvent;
				Delegate @delegate = Delegate.Remove(onEndDragEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEndDragEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004D")]
		public event EndDrag OnPointerUpEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002A6E")]
			[Cpp2IlInjected.Address(RVA = "0xF18580", Offset = "0xF16F80", VA = "0x180F18580")]
			[CompilerGenerated]
			add
			{
				EndDrag onPointerUpEvent = this.OnPointerUpEvent;
				Delegate @delegate = Delegate.Combine(onPointerUpEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPointerUpEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A6F")]
			[Cpp2IlInjected.Address(RVA = "0xF188A0", Offset = "0xF172A0", VA = "0x180F188A0")]
			[CompilerGenerated]
			remove
			{
				EndDrag onPointerUpEvent = this.OnPointerUpEvent;
				Delegate @delegate = Delegate.Remove(onPointerUpEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPointerUpEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004E")]
		public event EndDrag OnPointerDownEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002A71")]
			[Cpp2IlInjected.Address(RVA = "0xF184E0", Offset = "0xF16EE0", VA = "0x180F184E0")]
			[CompilerGenerated]
			add
			{
				EndDrag onPointerDownEvent = this.OnPointerDownEvent;
				Delegate @delegate = Delegate.Combine(onPointerDownEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPointerDownEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A72")]
			[Cpp2IlInjected.Address(RVA = "0xF18800", Offset = "0xF17200", VA = "0x180F18800")]
			[CompilerGenerated]
			remove
			{
				EndDrag onPointerDownEvent = this.OnPointerDownEvent;
				Delegate @delegate = Delegate.Remove(onPointerDownEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPointerDownEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A67")]
		[Cpp2IlInjected.Address(RVA = "0x998E10", Offset = "0x997810", VA = "0x180998E10", Slot = "4")]
		public void OnBeginDrag(PointerEventData e)
		{
			this.OnBeginDragEvent?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A6A")]
		[Cpp2IlInjected.Address(RVA = "0xF182A0", Offset = "0xF16CA0", VA = "0x180F182A0", Slot = "5")]
		public void OnDrag(PointerEventData e)
		{
			this.OnDragEvent?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A6D")]
		[Cpp2IlInjected.Address(RVA = "0xF182C0", Offset = "0xF16CC0", VA = "0x180F182C0", Slot = "6")]
		public void OnEndDrag(PointerEventData e)
		{
			this.OnEndDragEvent?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A70")]
		[Cpp2IlInjected.Address(RVA = "0x88C470", Offset = "0x88AE70", VA = "0x18088C470", Slot = "8")]
		public void OnPointerUp(PointerEventData e)
		{
			this.OnPointerUpEvent?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A73")]
		[Cpp2IlInjected.Address(RVA = "0xF182E0", Offset = "0xF16CE0", VA = "0x180F182E0", Slot = "7")]
		public void OnPointerDown(PointerEventData e)
		{
			this.OnPointerDownEvent?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A74")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DragEventListener()
		{
		}
	}
}
