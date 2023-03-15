using System;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002F0")]
	public class CollectionMemoryShardsItem : CollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x6001319")]
		[Cpp2IlInjected.Address(RVA = "0x1006170", Offset = "0x1004B70", VA = "0x181006170", Slot = "6")]
		internal override void UpdateView()
		{
			//Discarded unreachable code: IL_0157
			//IL_0030: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_0088: Expected I4, but got I8
			//IL_0099: Expected O, but got I8
			//IL_0103: Expected O, but got I4
			//IL_011a: Expected O, but got I4
			//IL_0148: Expected O, but got I4
			bool flag = default(bool);
			ulong num5 = default(ulong);
			bool flag2 = default(bool);
			ItemSlot itemSlot;
			int num9;
			do
			{
				if (flag)
				{
					RecycleBin recycleBin = RecycleBin;
					Type typeFromHandle = typeof(CollectionMemoryShardsView);
					Transform transform = base.transform;
					int num = 0;
					if ((object)transform != null)
					{
					}
					GameObject gameObject = recycleBin.FindReusableOrNew(typeFromHandle, (Transform)num);
					if ((object)gameObject != null)
					{
						CollectionMemoryShardsView component = gameObject.GetComponent<CollectionMemoryShardsView>();
					}
					base.View = (ItemSlot)num;
					int num2 = 0;
					if (!(recycleBin != (UnityEngine.Object)num2))
					{
						return;
					}
					Transform transform2 = recycleBin.transform;
					if ((object)transform2 != null)
					{
					}
					int num3 = 0;
					Vector2 zero = Vector2.zero;
					int num4 = 0;
					Vector2 zero2 = Vector2.zero;
					transform2.gameObject.SetActive((byte)num5 != 0);
					FocusNavigationElement focusNavigationElement = FocusNavigationElement;
					focusNavigationElement.ClickButton = (TemplateButton)num5;
					FocusNavigationElement focusNavigationElement2 = (FocusNavigationElement)(object)(focusNavigationElement.ClickButton = (TemplateButton)(object)FocusNavigationElement);
					FocusNavigation focusNavigation = (FocusNavigation)(object)(focusNavigationElement.ClickButton = (TemplateButton)(object)FocusNavigation);
					IntPtr method_code = ((Delegate)new UnityAction(OnClicked)).method_code;
					MethodInfo method_info = ((Delegate)new UnityAction(base.OnHighlighted)).method_info;
					UnityAction unityAction = base.OnDehighlighted;
					FocusNavigation focusNavigation2 = FocusNavigation;
					int num6 = 0;
					if (!(focusNavigation2 != (UnityEngine.Object)num6))
					{
						return;
					}
					FocusNavigationElement focusNavigationElement3 = FocusNavigationElement;
					int num7 = 0;
					if (focusNavigationElement3 != (UnityEngine.Object)num7)
					{
						if (FocusNavigation._focusedElement != null)
						{
							int num8 = 0;
						}
						if (!flag2)
						{
						}
					}
					return;
				}
				itemSlot = base.View;
				num9 = 0;
			}
			while (!(itemSlot != (UnityEngine.Object)num9));
			IDictionaryEnumerator enumerator = ((IOrderedDictionary)this).GetEnumerator();
		}

		[Cpp2IlInjected.Token(Token = "0x600131A")]
		[Cpp2IlInjected.Address(RVA = "0x1005FE0", Offset = "0x10049E0", VA = "0x181005FE0", Slot = "7")]
		public override void ReleaseView()
		{
			//Discarded unreachable code: IL_0082
			//IL_0010: Expected O, but got I4
			ItemSlot itemSlot = base.View;
			int num = 0;
			if (itemSlot != (UnityEngine.Object)num)
			{
				UnityEvent onClicked = base.View.OnClicked;
				UnityAction call = OnClicked;
				onClicked.RemoveListener(call);
				UnityEvent onHighlighted = base.View.OnHighlighted;
				UnityAction call2 = base.OnHighlighted;
				onHighlighted.RemoveListener(call2);
				UnityEvent onDehighlighted = base.View.OnDehighlighted;
				UnityAction call3 = base.OnDehighlighted;
				onDehighlighted.RemoveListener(call3);
			}
			base.ReleaseView();
		}

		[Cpp2IlInjected.Token(Token = "0x600131B")]
		[Cpp2IlInjected.Address(RVA = "0x1005F80", Offset = "0x1004980", VA = "0x181005F80")]
		private void OnClicked()
		{
			//Discarded unreachable code: IL_001e
			((Action<T>)(object)base.Model.MenuModel.OnMemoryShards)?.Invoke((T)this);
		}

		[Cpp2IlInjected.Token(Token = "0x600131C")]
		[Cpp2IlInjected.Address(RVA = "0x1005F70", Offset = "0x1004970", VA = "0x181005F70")]
		public CollectionMemoryShardsItem()
		{
			base.IsVisible = true;
			((MonoBehaviour)this)._002Ector();
		}
	}
}
