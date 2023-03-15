using System;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002EA")]
	public class CollectionItem : MonoBehaviour, IHasDynamicView
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000E24")]
		public ItemSlotModel.AlternateDataClass AlternateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000E27")]
		public FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000E28")]
		public GameObject LockedInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000E29")]
		public FocusNavigationElement FocusNavigationElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000E2A")]
		public RecycleBin RecycleBin;

		[Cpp2IlInjected.Token(Token = "0x17000342")]
		public CollectionItemModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x60012D6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60012D7")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000343")]
		public ItemSlot View
		{
			[Cpp2IlInjected.Token(Token = "0x60012D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CView_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60012D9")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CView_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000344")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000E26")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60012DA")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012DB")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x60012DC")]
		[Cpp2IlInjected.Address(RVA = "0x10054C0", Offset = "0x1003EC0", VA = "0x1810054C0")]
		internal void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0124
			//IL_0024: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			if ((long)Model != 0)
			{
				UpdateView();
				ItemSlot itemSlot = View;
				int num = 0;
				if (!(itemSlot != (UnityEngine.Object)num))
				{
					return;
				}
				ItemSlot itemSlot2 = View;
				CollectionItemModel collectionItemModel = Model;
				if (itemSlot2.Model == collectionItemModel)
				{
					return;
				}
				itemSlot2.Model = collectionItemModel;
				ItemSlot itemSlot3 = View;
				CollectionItemModel collectionItemModel2 = Model;
				ItemSlotModel itemSlotModel = itemSlot3.Model;
				ItemSlotModel.AlternateDataClass alternateDataClass = (itemSlotModel.AlternateData = collectionItemModel2.AlternateData);
				View.RefreshDisplay();
				((TemplateButton)View).IgnoreHighlightWhenNotActivated = false;
				GameObject friendshipLevel = View.FriendshipLevel;
				int num2 = 0;
				if (friendshipLevel != (UnityEngine.Object)num2)
				{
					CollectionItemModel collectionItemModel3 = Model;
					ItemSlot itemSlot4 = View;
					if (collectionItemModel3.CharLevel == -1)
					{
						itemSlot4.ExtraPhases[3]?.Invoke();
						GameObject friendshipLevel2 = itemSlot4.FriendshipLevel;
						int active = 0;
						friendshipLevel2.SetActive((byte)active != 0);
					}
					else
					{
						TMP_Text componentInChildren = View.FriendshipLevel.GetComponentInChildren<TMP_Text>();
						int _003CCharLevel_003Ek__BackingField = Model.CharLevel;
						string text = default(string);
						componentInChildren.text = text;
					}
				}
			}
			else
			{
				Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012DD")]
		[Cpp2IlInjected.Address(RVA = "0x10059D0", Offset = "0x10043D0", VA = "0x1810059D0", Slot = "6")]
		internal virtual void UpdateView()
		{
			//Discarded unreachable code: IL_0213
			//IL_001c: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_00aa: Expected I4, but got I8
			//IL_0199: Expected O, but got I4
			//IL_01b0: Expected O, but got I4
			//IL_01d6: Expected I4, but got I8
			//IL_0204: Expected O, but got I4
			ulong num6 = default(ulong);
			bool flag = default(bool);
			ulong num10 = default(ulong);
			ItemSlot itemSlot7;
			int num11;
			do
			{
				if (IsVisible)
				{
					ItemSlot itemSlot = View;
					int num = 0;
					if (itemSlot == (UnityEngine.Object)num)
					{
						RecycleBin recycleBin = RecycleBin;
						Type typeFromHandle = typeof(ItemSlot);
						Transform transform = base.transform;
						int num2 = 0;
						if ((object)transform != null)
						{
						}
						ItemSlot itemSlot2 = (View = recycleBin.FindReusableOrNew(typeFromHandle, (Transform)num2).GetComponent<ItemSlot>());
						ItemSlot itemSlot3 = View;
						int num3 = 0;
						if (itemSlot3 != (UnityEngine.Object)num3)
						{
							if ((object)View.transform != null)
							{
							}
							int num4 = 0;
							Vector2 zero = Vector2.zero;
							int num5 = 0;
							Vector2 zero2 = Vector2.zero;
							View.gameObject.SetActive((byte)num6 != 0);
							FocusNavigationElement focusNavigationElement = FocusNavigationElement;
							ItemSlot itemSlot4 = (ItemSlot)(focusNavigationElement.ClickButton = View);
							ItemSlot itemSlot5 = View;
							FocusNavigationElement focusNavigationElement2 = (((TemplateButton)itemSlot5).FocusNavigationElement = FocusNavigationElement);
							ItemSlot itemSlot6 = View;
							FocusNavigation focusNavigation = (((TemplateButton)itemSlot6).FocusNavigation = FocusNavigation);
							UnityEvent onHighlighted = View.OnHighlighted;
							UnityAction call = OnHighlighted;
							onHighlighted.AddListener(call);
							UnityEvent onDehighlighted = View.OnDehighlighted;
							UnityAction call2 = OnDehighlighted;
							onDehighlighted.AddListener(call2);
							UnityEvent onRightClicked = View.OnRightClicked;
							UnityAction call3 = OnRightClick;
							onRightClicked.AddListener(call3);
							UnityEvent onClicked = View.OnClicked;
							UnityAction call4 = OnClick;
							onClicked.AddListener(call4);
							FocusNavigation focusNavigation2 = FocusNavigation;
							int num7 = 0;
							if (focusNavigation2 != (UnityEngine.Object)num7)
							{
								FocusNavigationElement focusNavigationElement3 = FocusNavigationElement;
								int num8 = 0;
								if (focusNavigationElement3 != (UnityEngine.Object)num8)
								{
									if (FocusNavigation._focusedElement != null)
									{
										int num9 = 0;
									}
									if (flag)
									{
										View.IsHighlighted = (byte)num10 != 0;
									}
								}
							}
						}
						LockedInfo.transform.SetAsLastSibling();
						return;
					}
					while (IsVisible)
					{
					}
				}
				itemSlot7 = View;
				num11 = 0;
			}
			while (!(itemSlot7 != (UnityEngine.Object)num11));
			IDictionaryEnumerator enumerator = ((IOrderedDictionary)this).GetEnumerator();
		}

		[Cpp2IlInjected.Token(Token = "0x60012DE")]
		[Cpp2IlInjected.Address(RVA = "0x10053A0", Offset = "0x1003DA0", VA = "0x1810053A0")]
		protected void OnDehighlighted()
		{
			//Discarded unreachable code: IL_0027
			//IL_0025: Expected O, but got I4
			CollectionMenuModel _003CMenuModel_003Ek__BackingField = Model.MenuModel;
			if (_003CMenuModel_003Ek__BackingField != null)
			{
				Action<CollectionItem, bool> onTooltip = _003CMenuModel_003Ek__BackingField.OnTooltip;
				if (onTooltip != null)
				{
					int num = 0;
					onTooltip((T1)this, (T2)num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012DF")]
		[Cpp2IlInjected.Address(RVA = "0x1005410", Offset = "0x1003E10", VA = "0x181005410")]
		protected void OnHighlighted()
		{
			//Discarded unreachable code: IL_0030
			//IL_002e: Expected O, but got I4
			View.UpdateRedDot();
			((Action<T1, T2>)(object)Model.MenuModel?.OnTooltip)?.Invoke((T1)this, (T2)1);
		}

		[Cpp2IlInjected.Token(Token = "0x60012E0")]
		[Cpp2IlInjected.Address(RVA = "0x1005090", Offset = "0x1003A90", VA = "0x181005090")]
		internal void Dispose()
		{
			//IL_004e: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			int num = 0;
			if ((IntPtr)Model != (IntPtr)num && (IntPtr)AlternateData == (IntPtr)num)
			{
				int num2 = 0;
				RedDotHelper redDotHelper = UiRoot.Instance.RedDotHelper;
				IItemData _003CItemData_003Ek__BackingField = ((ItemSlotModel)Model).ItemData;
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
			}
			GameObject lockedInfo = LockedInfo;
			int num4 = 0;
			if (lockedInfo != (UnityEngine.Object)num4)
			{
				GameObject lockedInfo2 = LockedInfo;
				int active = 0;
				lockedInfo2.SetActive((byte)active != 0);
			}
			IsVisible = (byte)num != 0;
			ReleaseView();
			int num5 = 0;
			Model = (CollectionItemModel)num;
			num5 += num5;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60012E1")]
		[Cpp2IlInjected.Address(RVA = "0x1005240", Offset = "0x1003C40", VA = "0x181005240", Slot = "4")]
		public GameObject GetView()
		{
			//Discarded unreachable code: IL_0028
			//IL_0027: Expected O, but got I4
			RecycleBin recycleBin = RecycleBin;
			Type typeFromHandle = typeof(ItemSlot);
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			return recycleBin.FindReusableOrNew(typeFromHandle, (Transform)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60012E2")]
		[Cpp2IlInjected.Address(RVA = "0x1005750", Offset = "0x1004150", VA = "0x181005750", Slot = "7")]
		public virtual void ReleaseView()
		{
			//Discarded unreachable code: IL_0081
			CollectionItemModel collectionItemModel = Model;
			if (collectionItemModel != null)
			{
				ItemSlot view = View;
				collectionItemModel.Release(view);
			}
			bool flag = default(bool);
			if (flag)
			{
				FocusNavigationElement focusNavigationElement = FocusNavigationElement;
				MethodInfo method_info = ((Delegate)new UnityAction(OnHighlighted)).method_info;
				UnityAction unityAction = OnDehighlighted;
				UnityAction unityAction2 = OnRightClick;
				UnityAction unityAction3 = OnClick;
				Module module = method_info.Module;
				GameObject trash = default(GameObject);
				RecycleBin?.SendToBin(trash);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012E3")]
		[Cpp2IlInjected.Address(RVA = "0x1005490", Offset = "0x1003E90", VA = "0x181005490")]
		public void OnRightClick()
		{
			//Discarded unreachable code: IL_0016
			Model.MenuModel.OnTooltipPart2();
		}

		[Cpp2IlInjected.Token(Token = "0x60012E4")]
		[Cpp2IlInjected.Address(RVA = "0x1005310", Offset = "0x1003D10", VA = "0x181005310")]
		private void OnClick()
		{
			//Discarded unreachable code: IL_0016, IL_002d
			Model.MenuModel.OnSkinShortcut();
		}

		[Cpp2IlInjected.Token(Token = "0x60012E5")]
		[Cpp2IlInjected.Address(RVA = "0x1005F70", Offset = "0x1004970", VA = "0x181005F70")]
		public CollectionItem()
		{
		}
	}
}
