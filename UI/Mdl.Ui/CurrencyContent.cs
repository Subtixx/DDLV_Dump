using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	public class CurrencyContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		[ItemID]
		public int[] CurrencyItems = new int[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public SlidingPanel Slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		[SerializeField]
		private ListBase list_currencyItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public bool AutomaticRefresh = true;

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		public ListBase ListCurrencyItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000A63")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return list_currencyItems;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x400070B")]
		internal bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000A64")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0x1117430", Offset = "0x1115E30", VA = "0x181117430")]
		public void AddListeners()
		{
			//Discarded unreachable code: IL_0069
			ListBase.ListEvents onItemData = list_currencyItems.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnCurrencyItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
					_003CDispatcher_003Ek__BackingField.OnCurrencyChanged += value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x1117E40", Offset = "0x1116840", VA = "0x181117E40")]
		public void RemoveListeners()
		{
			//Discarded unreachable code: IL_0055
			list_currencyItems.m_OnItemData.RemoveAllListeners();
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.CurrencyChanged value = OnCurrencyChanged;
					_003CDispatcher_003Ek__BackingField.OnCurrencyChanged -= value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0x1118020", Offset = "0x1116A20", VA = "0x181118020")]
		public void Show()
		{
			//Discarded unreachable code: IL_0062
			//IL_0026: Expected O, but got I4
			if (!IsVisible)
			{
				AddListeners();
			}
			SlidingPanel slider = Slider;
			IsVisible = true;
			int num = 0;
			if (slider != (Object)num && Slider.enabled)
			{
				Slider.Show(andOpen: true);
			}
			int[] currencyItems = CurrencyItems;
			ListBase listBase = list_currencyItems;
			int num2 = (listBase.TotalCount = currencyItems.Length);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x1117760", Offset = "0x1116160", VA = "0x181117760")]
		public void Hide()
		{
			RemoveListeners();
			Slider?.Hide();
			IsVisible = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x1117E10", Offset = "0x1116810", VA = "0x181117E10")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_001d
			int[] currencyItems = CurrencyItems;
			ListBase listBase = list_currencyItems;
			int num = (listBase.TotalCount = currencyItems.Length);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x1117A50", Offset = "0x1116450", VA = "0x181117A50")]
		private void OnDestroy()
		{
			RemoveListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x1117680", Offset = "0x1116080", VA = "0x181117680")]
		public static int GetCurrencyBalance(Item currencyItem)
		{
			//Discarded unreachable code: IL_0017
			ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x1117BD0", Offset = "0x11165D0", VA = "0x181117BD0")]
		private void RefreshCurrencyBalance(Item currencyItem, FreemiumCurrencyItem freemiumCurrencyItem)
		{
			//Discarded unreachable code: IL_009e
			//IL_008b: Expected O, but got I4
			//IL_008b: Expected O, but got I4
			int itemID = currencyItem.ItemID;
			int num = 0;
			bool isHudOnTop = UiRoot.Instance._menuStack.IsHudOnTop;
			int num2 = 0;
			if (isHudOnTop)
			{
				goto IL_0045;
			}
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num3 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num4 = 0;
				if (top != null)
				{
					goto IL_0045;
				}
			}
			goto IL_008d;
			IL_0045:
			RectTransform content = UiRoot.Instance._menuStack.GetMenu<HudMenu>()._currencyItems.m_Content;
			int index = 0;
			Transform child = content.GetChild(index);
			if ((object)child != null)
			{
				FreemiumCurrencyItem component = child.GetComponent<FreemiumCurrencyItem>();
			}
			int num5 = 0;
			int num6 = 0;
			bool flag = (Object)num5 != (Object)num6;
			goto IL_008d;
			IL_008d:
			list_currencyItems.m_Content.RebuildLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x1117980", Offset = "0x1116380", VA = "0x181117980")]
		private void OnCurrencyItemDataHandler(ListBase.ListEventData args)
		{
			//Discarded unreachable code: IL_0028
			int[] currencyItems = CurrencyItems;
			int itemIndex = args.ItemIndex;
			int num = currencyItems[itemIndex];
			GameObject displayObject = args.DisplayObject;
			num = itemIndex;
			FreemiumCurrencyItem component = displayObject.GetComponent<FreemiumCurrencyItem>();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x1117380", Offset = "0x1115D80", VA = "0x181117380")]
		public void AddCoinAmount(int amount)
		{
			//Discarded unreachable code: IL_0045
			if (list_currencyItems.m_Content.childCount > 0 && amount != -1)
			{
				RectTransform content = list_currencyItems.m_Content;
				int index = 0;
				FreemiumCurrencyItem component = content.GetChild(index).GetComponent<FreemiumCurrencyItem>();
				int amount2 = component._amount;
				amount2 = (component.Amount = amount2 + amount);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x1117790", Offset = "0x1116190", VA = "0x181117790")]
		private void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_007a
			//IL_001b: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			int num = 0;
			if ((AutomaticRefresh ? 1 : 0) == num)
			{
				return;
			}
			GameObject gameObject = base.gameObject;
			int num2 = 0;
			if (gameObject == (Object)num2 || !base.gameObject.activeInHierarchy)
			{
				return;
			}
			ListBase listBase = list_currencyItems;
			if (num < listBase._totalCount)
			{
				Transform itemByDataIndex = listBase.GetItemByDataIndex(num);
				int num3 = 0;
				if (!(itemByDataIndex != (Object)num3) || (object)list_currencyItems.GetItemByDataIndex(num).GetComponent<FreemiumCurrencyItem>().CurrencyItem == null)
				{
					ListBase listBase2 = list_currencyItems;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x1117A60", Offset = "0x1116460", VA = "0x181117A60")]
		public void RefreshAllCurrencies(bool animated = true)
		{
			//Discarded unreachable code: IL_0082
			//IL_0023: Expected O, but got I4
			ListBase listBase = list_currencyItems;
			int num = 0;
			ListBase listBase2 = default(ListBase);
			if (num < listBase._totalCount)
			{
				Transform itemByDataIndex = listBase.GetItemByDataIndex(num);
				int num2 = 0;
				if (itemByDataIndex != (Object)num2)
				{
					FreemiumCurrencyItem component = list_currencyItems.GetItemByDataIndex(num).GetComponent<FreemiumCurrencyItem>();
					int itemID = component.CurrencyItem.ItemID;
					int num3 = default(int);
					if (!animated)
					{
						component.Amount = num3;
					}
					component.AnimatedAmount = num3;
					component.transform.RebuildLayout();
				}
				listBase2 = list_currencyItems;
				num++;
			}
			listBase2.m_Content.RebuildLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x11180F0", Offset = "0x1116AF0", VA = "0x1811180F0")]
		public CurrencyContent()
		{
		}
	}
}
