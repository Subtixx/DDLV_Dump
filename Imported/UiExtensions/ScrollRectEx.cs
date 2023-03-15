using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UiExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ScrollRectEx : ScrollRect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private bool routeToParent;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1B20870", Offset = "0x1B1F270", VA = "0x181B20870")]
		private void DoForParents<T>(Action<> P_0) where T : IEventSystemHandler
		{
			//IL_0015: Expected O, but got I4
			Transform parent = base.transform.parent;
			int num = 0;
			if (!(parent != (UnityEngine.Object)num))
			{
				return;
			}
			Component[] components = parent.GetComponents<Component>();
			int num2 = 0;
			if (num2 >= components.Length)
			{
				return;
			}
			Component component = components[num2];
			if (num2 != 0)
			{
				if ((object)component == null)
				{
				}
				if (num2 == 0)
				{
					throw new InvalidCastException();
				}
				if (num2 == 0)
				{
					throw new InvalidCastException();
				}
			}
			num2++;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1770", Offset = "0x3DC0170", VA = "0x183DC1770", Slot = "43")]
		public override void OnInitializePotentialDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0030
			Action<IInitializePotentialDragHandler> action = (Action<IInitializePotentialDragHandler>)(object)(Action<T>)delegate
			{
				throw new NullReferenceException();
			};
			DoForParents<IInitializePotentialDragHandler>((Action<>)(object)action);
			PointerEventData eventData2 = eventData;
			base.OnInitializePotentialDrag(eventData2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1550", Offset = "0x3DBFF50", VA = "0x183DC1550", Slot = "46")]
		public override void OnDrag(PointerEventData eventData)
		{
			if (!routeToParent)
			{
				PointerEventData eventData2 = eventData;
				base.OnDrag(eventData2);
				return;
			}
			Action<IDragHandler> action = (Action<IDragHandler>)(object)(Action<T>)delegate
			{
				throw new NullReferenceException();
			};
			DoForParents<IDragHandler>((Action<>)(object)action);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1350", Offset = "0x3DBFD50", VA = "0x183DC1350", Slot = "44")]
		public override void OnBeginDrag(PointerEventData eventData)
		{
			//IL_002c: Invalid comparison between O and F4
			//IL_004b: Invalid comparison between F4 and O
			Vector2 _003Cdelta_003Ek__BackingField = eventData.delta;
			float y = eventData.delta.y;
			if (_003Cdelta_003Ek__BackingField <= (object)y)
			{
				Vector2 _003Cdelta_003Ek__BackingField2 = eventData.delta;
				if ((object)eventData.delta.y <= _003Cdelta_003Ek__BackingField2)
				{
					routeToParent = false;
					throw new NullReferenceException();
				}
			}
			routeToParent = true;
			Action<IBeginDragHandler> action = (Action<IBeginDragHandler>)(object)(Action<T>)delegate
			{
				throw new NullReferenceException();
			};
			DoForParents<IBeginDragHandler>((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1660", Offset = "0x3DC0060", VA = "0x183DC1660", Slot = "45")]
		public override void OnEndDrag(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0040
			if (!routeToParent)
			{
				PointerEventData eventData2 = eventData;
				base.OnEndDrag(eventData2);
			}
			Action<IEndDragHandler> action = (Action<IEndDragHandler>)(object)(Action<T>)delegate
			{
				throw new NullReferenceException();
			};
			DoForParents<IEndDragHandler>((Action<>)(object)action);
			routeToParent = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1870", Offset = "0x3DC0270", VA = "0x183DC1870")]
		public ScrollRectEx()
		{
		}
	}
}
