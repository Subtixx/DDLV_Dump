using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Google.Protobuf.Collections;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002B8")]
	[RequiredAllNotNull]
	public class MoanaBoatFishCaughtPanel : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20002B9")]
		public delegate void HideEventDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C7C")]
		[SerializeField]
		private ListBase _fishList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000C7D")]
		[SerializeField]
		private RectTransform _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000C7E")]
		[SerializeField]
		private Button _btnOkay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000C7F")]
		private AnyReward[] _collectedFishes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000C80")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000C81")]
		[SerializeField]
		[Header("Sizing")]
		private GridLayoutGroup _mcGridLayoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000C82")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000C83")]
		[SerializeField]
		private float _singleRowHeight = 483f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000C84")]
		[SerializeField]
		private float _doubleRowHeight = 741f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000C85")]
		[SerializeField]
		private float _paddingWidth = 245f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000C86")]
		[SerializeField]
		private float _minWidth = 835f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000C87")]
		[SerializeField]
		private float _maxWidth = 1230f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000C88")]
		[SerializeField]
		private int _itemsPerRow = 5;

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event HideEventDelegate OnHide
		{
			[Cpp2IlInjected.Token(Token = "0x6001120")]
			[Cpp2IlInjected.Address(RVA = "0x12936A0", Offset = "0x12920A0", VA = "0x1812936A0")]
			[CompilerGenerated]
			add
			{
				HideEventDelegate onHide = this.OnHide;
				Delegate @delegate = Delegate.Combine(onHide, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onHide)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001121")]
			[Cpp2IlInjected.Address(RVA = "0x1293A00", Offset = "0x1292400", VA = "0x181293A00")]
			[CompilerGenerated]
			remove
			{
				HideEventDelegate onHide = this.OnHide;
				Delegate @delegate = Delegate.Remove(onHide, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onHide)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001122")]
		[Cpp2IlInjected.Address(RVA = "0x1292E70", Offset = "0x1291870", VA = "0x181292E70")]
		public void Init()
		{
			//Discarded unreachable code: IL_0041
			ListBase.ListEvents onItemData = _fishList.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(onFishItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = _btnOkay.m_OnClick;
			UnityAction call = OnOkayClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001123")]
		[Cpp2IlInjected.Address(RVA = "0x1292F90", Offset = "0x1291990", VA = "0x181292F90")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0041
			ListBase.ListEvents onItemData = _fishList.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(onFishItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			Button.ButtonClickedEvent onClick = _btnOkay.m_OnClick;
			UnityAction call = OnOkayClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001124")]
		[Cpp2IlInjected.Address(RVA = "0x1293350", Offset = "0x1291D50", VA = "0x181293350")]
		public void Show(RepeatedField<AnyReward> collectedFish)
		{
			//Discarded unreachable code: IL_012a
			RectTransform mcBackground = _mcBackground;
			float z = Vector3.one.z;
			Transform transform = _btnOkay.transform;
			float z2 = Vector3.one.z;
			ListBase fishList = _fishList;
			int num2 = (fishList.TotalCount = 0);
			_fishList.RefreshCells();
			base.gameObject.SetActive(value: true);
			AnyReward[] array = (_collectedFishes = ((IEnumerable<>)(object)collectedFish).ToArray<AnyReward>());
			_fishList.gameObject.SetActive(value: true);
			AnyReward[] collectedFishes = _collectedFishes;
			ListBase fishList2 = _fishList;
			int num3 = (fishList2.TotalCount = collectedFishes.Length);
			ListBase fishList3 = _fishList;
			int offset = 0;
			fishList3.RefillCells(offset);
			ListBase fishList4 = _fishList;
			int itemsPerRow = _itemsPerRow;
			_mcGridLayoutGroup.constraintCount = 5;
			ListBase fishList5 = _fishList;
			GridLayoutGroup mcGridLayoutGroup = _mcGridLayoutGroup;
			RectTransform mcContent = _mcContent;
			float singleRowHeight = _singleRowHeight;
			RectTransform mcContent2 = _mcContent;
			float maxWidth = _maxWidth;
			float doubleRowHeight = _doubleRowHeight;
			int _003C_003E1__state = default(int);
			_003CResizeForDoubleRow_003Ed__22 _003CResizeForDoubleRow_003Ed__ = new _003CResizeForDoubleRow_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResizeForDoubleRow_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CResizeForDoubleRow_003Ed__);
			_btnOkay.enabled = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001125")]
		[Cpp2IlInjected.Address(RVA = "0x12932A0", Offset = "0x1291CA0", VA = "0x1812932A0")]
		private void ShowList(RepeatedField<AnyReward> collectedFish)
		{
			//Discarded unreachable code: IL_0050
			AnyReward[] array = (_collectedFishes = ((IEnumerable<>)(object)collectedFish).ToArray<AnyReward>());
			_fishList.gameObject.SetActive(value: true);
			AnyReward[] collectedFishes = _collectedFishes;
			ListBase fishList = _fishList;
			int num = (fishList.TotalCount = collectedFishes.Length);
			ListBase fishList2 = _fishList;
			int offset = 0;
			fishList2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6001126")]
		[Cpp2IlInjected.Address(RVA = "0x1293120", Offset = "0x1291B20", VA = "0x181293120")]
		public void ResizeWindow()
		{
			//Discarded unreachable code: IL_0041, IL_0056
			//IL_0055: Expected O, but got I4
			ListBase fishList = _fishList;
			int itemsPerRow = _itemsPerRow;
			_mcGridLayoutGroup.constraintCount = 5;
			ListBase fishList2 = _fishList;
			GridLayoutGroup mcGridLayoutGroup = _mcGridLayoutGroup;
			RectTransform mcContent = _mcContent;
			float minWidth = _minWidth;
			float singleRowHeight = _singleRowHeight;
		}

		[Cpp2IlInjected.Token(Token = "0x6001127")]
		[Cpp2IlInjected.Address(RVA = "0x12930B0", Offset = "0x1291AB0", VA = "0x1812930B0")]
		[IteratorStateMachine(typeof(_003CResizeForDoubleRow_003Ed__22))]
		private IEnumerator ResizeForDoubleRow()
		{
			int _003C_003E1__state = default(int);
			_003CResizeForDoubleRow_003Ed__22 _003CResizeForDoubleRow_003Ed__ = new _003CResizeForDoubleRow_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CResizeForDoubleRow_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001128")]
		[Cpp2IlInjected.Address(RVA = "0x1292D90", Offset = "0x1291790", VA = "0x181292D90")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0067
			Button btnOkay = _btnOkay;
			int num = ((btnOkay.enabled = false) ? 1 : 0);
			GameObject gameObject = _fishList.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Transform transform = _btnOkay.transform;
			float z = Vector3.zero.z;
			this.OnHide?.Invoke();
			GameObject gameObject2 = base.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001129")]
		[Cpp2IlInjected.Address(RVA = "0x1293740", Offset = "0x1292140", VA = "0x181293740")]
		private void onFishItemDataHandler(ListBase.ListEventData arg)
		{
			//Discarded unreachable code: IL_00bb
			//IL_0017: Expected O, but got I4
			GameObject displayObject = arg.DisplayObject;
			ShoppingCartItem component = displayObject.GetComponent<ShoppingCartItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				AnyReward[] collectedFishes = _collectedFishes;
				int itemIndex = arg.ItemIndex;
				AnyReward anyReward = collectedFishes[itemIndex];
				Item item = anyReward.Item.Item;
				bool flag = default(bool);
				if (flag)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Item item2 = anyReward.Item.Item;
					component.GiveItem = true;
					IItemData _003CItemData_003Ek__BackingField = default(IItemData);
					component.ItemData = _003CItemData_003Ek__BackingField;
					int num2 = ((component.ShowCurrency = false) ? 1 : 0);
					component.Refresh();
					int amount_ = anyReward.Item.amount_;
					int amount_2 = anyReward.Item.amount_;
					bool active = amount_ != 1;
					component.SetItemAmount(active, amount_2);
					displayObject.GetComponent<FocusNavigationElement>().IgnoreThis = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600112A")]
		[Cpp2IlInjected.Address(RVA = "0x1292D90", Offset = "0x1291790", VA = "0x181292D90")]
		private void OnOkayClickHandler()
		{
			//Discarded unreachable code: IL_0067
			Button btnOkay = _btnOkay;
			int num = ((btnOkay.enabled = false) ? 1 : 0);
			GameObject gameObject = _fishList.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Transform transform = _btnOkay.transform;
			float z = Vector3.zero.z;
			this.OnHide?.Invoke();
			GameObject gameObject2 = base.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600112B")]
		[Cpp2IlInjected.Address(RVA = "0x1292D40", Offset = "0x1291740", VA = "0x181292D40")]
		public FocusNavigationElement GetFocus()
		{
			//Discarded unreachable code: IL_000c
			return _btnOkay.GetComponent<FocusNavigationElement>();
		}

		[Cpp2IlInjected.Token(Token = "0x600112C")]
		[Cpp2IlInjected.Address(RVA = "0x1293660", Offset = "0x1292060", VA = "0x181293660")]
		public MoanaBoatFishCaughtPanel()
		{
		}//IL_0040: Expected I4, but got I8

	}
}
