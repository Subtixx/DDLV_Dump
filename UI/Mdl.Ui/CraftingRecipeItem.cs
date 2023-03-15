using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003D8")]
	public class CraftingRecipeItem : MonoBehaviour, IHasDynamicView
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40012E4")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40012E5")]
		[SerializeField]
		private RectTransform _viewHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40012E6")]
		[SerializeField]
		private GameObject _newLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40012E7")]
		[SerializeField]
		private GameObject _questMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40012E8")]
		[SerializeField]
		private AsyncAtlassedIcon _questCharacterIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40012E9")]
		[SerializeField]
		private UnityEvent _onItemHighlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40012EA")]
		[SerializeField]
		private UnityEvent _onItemSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40012EB")]
		[SerializeField]
		private AK.Wwise.Event _selectSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40012EE")]
		public FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40012EF")]
		public FocusNavigationElement FocusNavigationElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40012F0")]
		private Vector3 _newLabelPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40012F1")]
		private Vector3 _questMarkerPos;

		[Cpp2IlInjected.Token(Token = "0x1700040A")]
		public ItemSlot View
		{
			[Cpp2IlInjected.Token(Token = "0x600186C")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CView_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600186D")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			set
			{
				_003CView_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040B")]
		public CraftingRecipeItemItemModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x600186E")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600186F")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040C")]
		public RecycleBin RecycleBin
		{
			[Cpp2IlInjected.Token(Token = "0x6001870")]
			[Cpp2IlInjected.Address(RVA = "0x1117340", Offset = "0x1115D40", VA = "0x181117340")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return UiRoot.Instance._itemRecycleBin;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040D")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x6001871")]
			[Cpp2IlInjected.Address(RVA = "0x1117320", Offset = "0x1115D20", VA = "0x181117320")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _newLabel.activeSelf;
			}
			[Cpp2IlInjected.Token(Token = "0x6001872")]
			[Cpp2IlInjected.Address(RVA = "0x1117360", Offset = "0x1115D60", VA = "0x181117360")]
			set
			{
				//Discarded unreachable code: IL_000d
				_newLabel.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001873")]
		[Cpp2IlInjected.Address(RVA = "0x1116100", Offset = "0x1114B00", VA = "0x181116100")]
		private void OnDisable()
		{
			ReleaseView();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001874")]
		[Cpp2IlInjected.Address(RVA = "0x1116B60", Offset = "0x1115560", VA = "0x181116B60")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_0045
			//IL_0021: Expected native int or pointer, but got O
			//IL_003f: Expected native int or pointer, but got O
			Transform transform = _newLabel.transform;
			GameObject questMarker = _questMarker;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)_newLabelPos)->z = z;
			Transform transform2 = questMarker.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			((Vector3*)(IntPtr)_questMarkerPos)->z = z2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001875")]
		[Cpp2IlInjected.Address(RVA = "0x11162F0", Offset = "0x1114CF0", VA = "0x1811162F0")]
		internal void RefreshDisplay()
		{
			//IL_0024: Expected O, but got I4
			//IL_0135: Expected O, but got I8
			if ((long)Model != 0)
			{
				UpdateView();
				ItemSlot itemSlot = View;
				int num = 0;
				if (itemSlot != (UnityEngine.Object)num)
				{
					ItemSlot itemSlot2 = View;
					CraftingRecipeItemItemModel craftingRecipeItemItemModel = (CraftingRecipeItemItemModel)(itemSlot2.Model = Model);
					View.RefreshDisplay();
				}
				IEnumerable<ProfileWorld.FilterInfo> filtersCraftInfo = (IEnumerable<ProfileWorld.FilterInfo>)SystemRoot.Instance.MetaClient.profile.world_.GetFiltersCraftInfo();
				Func<ProfileWorld.FilterInfo, bool> func = (Func<ProfileWorld.FilterInfo, bool>)(object)(Func<T, TResult>)delegate(ProfileWorld.FilterInfo quest)
				{
					//Discarded unreachable code: IL_001c
					List<MissionObjective> _003CObjectives_003Ek__BackingField2 = quest.Objectives;
					Func<MissionObjective, bool> cpp2il__autoParamName__idx_ = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective obj)
					{
						//Discarded unreachable code: IL_0034
						//IL_0027: Expected O, but got I4
						ItemFilter itemFilter_ = obj.itemFilter_;
						Item[] array = new Item[1];
						int iD = Model.CraftingRecipeItemData.ID;
						array[0] = (Item)iD;
						return Enumerable.Any<Item>((IEnumerable<>)itemFilter_.ApplyFilter((IEnumerable<>)(object)array));
					};
					return ((IEnumerable<>)_003CObjectives_003Ek__BackingField2).Any<MissionObjective>((Func<, >)(object)cpp2il__autoParamName__idx_);
				};
				ProfileWorld.FilterInfo filterInfo = default(ProfileWorld.FilterInfo);
				if (Enumerable.FirstOrDefault<ProfileWorld.FilterInfo>((IEnumerable<>)filtersCraftInfo, (Func<, >)(object)func) == null)
				{
					Client client = default(Client);
					ProfileWorld world_ = client.profile.world_;
					Item item = Model.CraftingRecipeItemData.result_.Item;
					Func<ProfileWorld.FilterInfo, bool> func2 = default(Func<ProfileWorld.FilterInfo, bool>);
					if (_003C_003Ec._003C_003E9__27_1 == null)
					{
						func2 = (Func<ProfileWorld.FilterInfo, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ProfileWorld.FilterInfo quest)
						{
							//Discarded unreachable code: IL_002e
							List<MissionObjective> _003CObjectives_003Ek__BackingField = quest.Objectives;
							Func<MissionObjective, bool> _003C_003E9__27_ = _003C_003Ec._003C_003E9__27_3;
							if (_003C_003E9__27_ == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjective obj)
								{
									//Discarded unreachable code: IL_001f
									if (obj.Data.PurchaseItem != null)
									{
										int num2 = 0;
									}
									return obj.Data.SellItem == null;
								};
							}
							return ((IEnumerable<>)_003CObjectives_003Ek__BackingField).Any<MissionObjective>((Func<, >)(object)_003C_003E9__27_);
						});
					}
					IEnumerable<ProfileWorld.FilterInfo> enumerable = default(IEnumerable<ProfileWorld.FilterInfo>);
					filterInfo = Enumerable.FirstOrDefault<ProfileWorld.FilterInfo>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
				}
				GameObject questMarker = _questMarker;
				bool active = filterInfo != null;
				questMarker.SetActive(active);
				if (filterInfo != null)
				{
					AsyncAtlassedIcon questCharacterIcon = _questCharacterIcon;
					Item characterItem = filterInfo.MissionSlot.CharacterItem;
				}
				CraftingRecipeItemItemModel craftingRecipeItemItemModel2 = Model;
				GameObject newLabel = _newLabel;
				bool _003CIsNew_003Ek__BackingField = craftingRecipeItemItemModel2.IsNew;
				newLabel.SetActive(_003CIsNew_003Ek__BackingField);
				return;
			}
			ReleaseView();
			Model = (CraftingRecipeItemItemModel)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001876")]
		[Cpp2IlInjected.Address(RVA = "0x1116D70", Offset = "0x1115770", VA = "0x181116D70", Slot = "6")]
		internal virtual void UpdateView()
		{
			//Discarded unreachable code: IL_0248
			//IL_0010: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			//IL_00b1: Expected I4, but got I8
			//IL_019b: Expected O, but got I4
			//IL_020a: Expected O, but got I4
			//IL_0221: Expected O, but got I4
			//IL_0247: Expected I4, but got I8
			ItemSlot itemSlot = View;
			int num = 0;
			if (!(itemSlot == (UnityEngine.Object)num))
			{
				return;
			}
			int num2 = 0;
			RecycleBin itemRecycleBin = UiRoot.Instance._itemRecycleBin;
			Type typeFromHandle = typeof(ItemSlot);
			RectTransform viewHolder = _viewHolder;
			ItemSlot itemSlot2 = (View = itemRecycleBin.FindReusableOrNew(typeFromHandle, viewHolder).GetComponent<ItemSlot>());
			ItemSlot itemSlot3 = View;
			int num3 = 0;
			if (!(itemSlot3 != (UnityEngine.Object)num3))
			{
				return;
			}
			((TemplateButton)View).IgnoreHighlightWhenNotActivated = false;
			Transform transform = View.transform;
			int num4 = 0;
			if ((object)transform != null)
			{
			}
			int num5 = 0;
			Vector2 zero = Vector2.zero;
			int num6 = 0;
			Vector2 zero2 = Vector2.zero;
			ulong num7 = default(ulong);
			View.gameObject.SetActive((byte)num7 != 0);
			FocusNavigationElement focusNavigationElement = FocusNavigationElement;
			ItemSlot itemSlot4 = (ItemSlot)(focusNavigationElement.ClickButton = View);
			ItemSlot itemSlot5 = View;
			FocusNavigationElement focusNavigationElement2 = (((TemplateButton)itemSlot5).FocusNavigationElement = FocusNavigationElement);
			ItemSlot itemSlot6 = View;
			FocusNavigation focusNavigation = (((TemplateButton)itemSlot6).FocusNavigation = FocusNavigation);
			UnityEvent onClicked = View.OnClicked;
			UnityAction call = OnClicked;
			onClicked.AddListener(call);
			UnityEvent onHighlighted = View.OnHighlighted;
			UnityAction call2 = OnHighlighted;
			onHighlighted.AddListener(call2);
			UnityEvent onSelected = View.OnSelected;
			UnityAction call3 = OnSelected;
			onSelected.AddListener(call3);
			CanvasGroup[] canvasGroups = View.CanvasGroups;
			int length = canvasGroups.Length;
			if (num4 < length)
			{
				CanvasGroup canvasGroup = canvasGroups[num4];
				int num8 = 0;
				if (canvasGroup != (UnityEngine.Object)num8)
				{
					int num9 = ((canvasGroup.ignoreParentGroups = false) ? 1 : 0);
				}
				num4++;
			}
			Transform transform2 = _newLabel.transform;
			RectTransform rectTransform = (RectTransform)(transform2.parentInternal = View.Content);
			Transform transform3 = _questMarker.transform;
			RectTransform rectTransform2 = (RectTransform)(transform3.parentInternal = View.Content);
			FocusNavigation focusNavigation2 = FocusNavigation;
			int num10 = 0;
			if (!(focusNavigation2 != (UnityEngine.Object)num10))
			{
				return;
			}
			FocusNavigationElement focusNavigationElement3 = FocusNavigationElement;
			int num11 = 0;
			if (focusNavigationElement3 != (UnityEngine.Object)num11)
			{
				if (FocusNavigation._focusedElement != null)
				{
					int num12 = 0;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
					ulong num13 = default(ulong);
					View.IsHighlighted = (byte)num13 != 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001877")]
		[Cpp2IlInjected.Address(RVA = "0x11161E0", Offset = "0x1114BE0", VA = "0x1811161E0")]
		private void OnClicked()
		{
			//Discarded unreachable code: IL_004d
			//IL_0010: Expected O, but got I4
			ItemSlot itemSlot = View;
			int num = 0;
			if (itemSlot != (UnityEngine.Object)num)
			{
				ItemSlot itemSlot2 = View;
				AK.Wwise.Event selectSfx = _selectSfx;
				GameObject gameObject = base.gameObject;
				uint num2 = selectSfx.Post(gameObject);
			}
			GetComponent<Button>().m_OnClick?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001878")]
		[Cpp2IlInjected.Address(RVA = "0x11162B0", Offset = "0x1114CB0", VA = "0x1811162B0")]
		private void OnHighlighted()
		{
			_onItemHighlighted?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001879")]
		[Cpp2IlInjected.Address(RVA = "0x1116100", Offset = "0x1114B00", VA = "0x181116100")]
		internal void Dispose()
		{
			ReleaseView();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600187A")]
		[Cpp2IlInjected.Address(RVA = "0x11162D0", Offset = "0x1114CD0", VA = "0x1811162D0")]
		private void OnSelected()
		{
			_onItemSelected?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600187B")]
		[Cpp2IlInjected.Address(RVA = "0x1116130", Offset = "0x1114B30", VA = "0x181116130", Slot = "4")]
		public GameObject GetView()
		{
			//Discarded unreachable code: IL_0028
			int num = 0;
			RecycleBin itemRecycleBin = UiRoot.Instance._itemRecycleBin;
			Type typeFromHandle = typeof(ItemSlot);
			RectTransform viewHolder = _viewHolder;
			return itemRecycleBin.FindReusableOrNew(typeFromHandle, viewHolder);
		}

		[Cpp2IlInjected.Token(Token = "0x600187C")]
		[Cpp2IlInjected.Address(RVA = "0x11167A0", Offset = "0x11151A0", VA = "0x1811167A0", Slot = "7")]
		public virtual void ReleaseView()
		{
			//Discarded unreachable code: IL_019d
			//IL_0029: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_0074: Expected I4, but got I8
			//IL_019c: Expected O, but got I8
			CraftingRecipeItemItemModel craftingRecipeItemItemModel = Model;
			if (craftingRecipeItemItemModel != null)
			{
				ItemSlot view = View;
				craftingRecipeItemItemModel.Release(view);
			}
			ItemSlot itemSlot = View;
			int num = 0;
			if (!(itemSlot != (UnityEngine.Object)num))
			{
				return;
			}
			CanvasGroup[] canvasGroups = View.CanvasGroups;
			int num2 = 0;
			int num3 = 0;
			int length = canvasGroups.Length;
			if (num3 < length)
			{
				CanvasGroup canvasGroup = canvasGroups[num2];
				int num4 = 0;
				if (canvasGroup != (UnityEngine.Object)num4)
				{
					ulong num5 = default(ulong);
					canvasGroup.ignoreParentGroups = (byte)num5 != 0;
				}
				num2++;
			}
			Transform transform = _newLabel.transform;
			RectTransform rectTransform = (RectTransform)(transform.parentInternal = _content);
			Transform transform2 = _questMarker.transform;
			RectTransform rectTransform2 = (RectTransform)(transform2.parentInternal = _content);
			Transform transform3 = _newLabel.transform;
			float z = _newLabelPos.z;
			Transform transform4 = _questMarker.transform;
			float z2 = _questMarkerPos.z;
			FocusNavigationElement focusNavigationElement = FocusNavigationElement;
			UnityEvent onClicked = View.OnClicked;
			UnityAction call = OnClicked;
			onClicked.RemoveListener(call);
			UnityEvent onHighlighted = View.OnHighlighted;
			UnityAction call2 = OnHighlighted;
			onHighlighted.RemoveListener(call2);
			UnityEvent onSelected = View.OnSelected;
			UnityAction call3 = OnSelected;
			onSelected.RemoveListener(call3);
			View.Release();
			int num6 = 0;
			RecycleBin itemRecycleBin = UiRoot.Instance._itemRecycleBin;
			if ((object)itemRecycleBin != null)
			{
				GameObject trash = View.gameObject;
				itemRecycleBin.SendToBin(trash);
			}
			View = (ItemSlot)0;
		}

		[Cpp2IlInjected.Token(Token = "0x600187D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CraftingRecipeItem()
		{
		}
	}
}
