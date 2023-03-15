using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Mdl.Online;
using Mdl.Ui.Widgets;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004E1")]
	public class DonateItemPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40019D1")]
		private List<IItemData> _items = (List<IItemData>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40019D2")]
		private Dictionary<IItemData, int> _itemsAmount = (Dictionary<IItemData, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40019D3")]
		private Dictionary<Item, int> _itemsNeeded = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40019D4")]
		[SerializeField]
		private DonateItem _ItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40019D5")]
		[SerializeField]
		private AsyncMenu shoppingCartPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40019D6")]
		[SerializeField]
		private Button _btnExit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40019D7")]
		[SerializeField]
		private ScrollRect _mcItemsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40019D8")]
		[SerializeField]
		private ButtonTmPro _btnDonate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40019D9")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40019DA")]
		[SerializeField]
		private RectTransform _mcAnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40019DB")]
		[SerializeField]
		private Image _mcBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40019DC")]
		private ListBase hudCurrencylist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40019DD")]
		private Transform hudCurrencylistContainer;

		[Cpp2IlInjected.Token(Token = "0x6001FD4")]
		[Cpp2IlInjected.Address(RVA = "0xF16200", Offset = "0xF14C00", VA = "0x180F16200", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//IL_0034: Expected O, but got I4
			//IL_009c: Expected I4, but got I8
			base.OnPush(stack, param);
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			if (top != null)
			{
				int num4 = 0;
				if (top == null)
				{
				}
			}
			hudCurrencylist = (ListBase)num3;
			Transform transform = (hudCurrencylistContainer = hudCurrencylist.transform.parent);
			ListBase listBase = hudCurrencylist;
			if ((object)listBase != null)
			{
				Transform transform2 = listBase.transform;
				int num5 = 0;
				Transform transform4 = (transform2.parentInternal = UiRoot.Instance._popupStack.transform);
				ulong num6 = default(ulong);
				hudCurrencylist?.GetComponent<SlidingPanel>().Show((byte)num6 != 0);
			}
			MenuParam menuParam = _menuParam;
			if (menuParam != null)
			{
				object[] @params = menuParam.Params;
				if (@params.Length != 0)
				{
					object obj = @params[0];
					if (obj != null)
					{
						int num7 = 0;
						if (obj != null)
						{
							_items = (List<IItemData>)obj;
						}
					}
				}
			}
			Image mcBlocker = _mcBlocker;
			Transform transform5 = _mcAnimatedContent.transform;
			float z = Vector3.zero.z;
			List<IItemData> items = _items;
			Func<IItemData, IItemData> func = default(Func<IItemData, IItemData>);
			if (_003C_003Ec._003C_003E9__13_0 == null)
			{
				func = (Func<IItemData, IItemData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IItemData x) => x));
			}
			IEnumerable<> enumerable = Enumerable.GroupBy<IItemData, IItemData>((IEnumerable<>)items, (Func<, >)(object)func);
			Func<IGrouping<IItemData, IItemData>, IItemData> func2 = default(Func<IGrouping<IItemData, IItemData>, IItemData>);
			if (_003C_003Ec._003C_003E9__13_1 == null)
			{
				func2 = (Func<IGrouping<IItemData, IItemData>, IItemData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				});
			}
			Func<IGrouping<IItemData, IItemData>, int> func3 = default(Func<IGrouping<IItemData, IItemData>, int>);
			if (_003C_003Ec._003C_003E9__13_2 == null)
			{
				func3 = (Func<IGrouping<IItemData, IItemData>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IGrouping<IItemData, IItemData> x) => Enumerable.Count<IItemData>((IEnumerable<>)x)));
			}
			Dictionary<IGrouping<IItemData, IItemData>, IItemData> dictionary = (Dictionary<IGrouping<IItemData, IItemData>, IItemData>)(object)(_itemsAmount = (Dictionary<IItemData, int>)(object)Enumerable.ToDictionary<IGrouping<IItemData, IItemData>, IItemData, int>(enumerable, (Func<, >)(object)func2, (Func<, >)(object)func3));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD5")]
		[Cpp2IlInjected.Address(RVA = "0xF15FA0", Offset = "0xF149A0", VA = "0x180F15FA0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0051, IL_0057, IL_0069
			//IL_0032: Expected O, but got I4
			DonateItem donateItem = default(DonateItem);
			DonateItem.ItemPurchased itemPurchased = default(DonateItem.ItemPurchased);
			while (true)
			{
				base.OnPop();
				IEnumerator enumerator = _mcItemsContent.m_Content.GetEnumerator();
				if (enumerator != null)
				{
					int num = 0;
					if (enumerator == null)
					{
						break;
					}
					int num2 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num3 = 0;
					if (!(donateItem != (UnityEngine.Object)num3))
					{
						continue;
					}
					itemPurchased = RefreshPurchaseButton;
					donateItem.OnItemPurchased -= itemPurchased;
				}
				if (itemPurchased == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD6")]
		[Cpp2IlInjected.Address(RVA = "0xF15CE0", Offset = "0xF146E0", VA = "0x180F15CE0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_006f
			//IL_003c: Expected O, but got I4
			base.OnFocusIn();
			int _003C_003E1__state = default(int);
			_003CFocusInCoroutine_003Ed__16 _003CFocusInCoroutine_003Ed__ = new _003CFocusInCoroutine_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFocusInCoroutine_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CFocusInCoroutine_003Ed__);
			base.IsDataUpToDate = true;
			Image mcBlocker = _mcBlocker;
			int num = 0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = (TweenerCore<Color, Color, ColorOptions>)(object)DOTweenModuleUI.DOColor(mcBlocker, (Color)num, 0.3f);
			RectTransform mcAnimatedContent = _mcAnimatedContent;
			float z = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = t.SetDelay(0.25f).SetEase(Ease.OutBack);
			RefreshPurchaseButton();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD7")]
		[Cpp2IlInjected.Address(RVA = "0xF159D0", Offset = "0xF143D0", VA = "0x180F159D0")]
		[IteratorStateMachine(typeof(_003CFocusInCoroutine_003Ed__16))]
		private IEnumerator FocusInCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CFocusInCoroutine_003Ed__16 _003CFocusInCoroutine_003Ed__ = new _003CFocusInCoroutine_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFocusInCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD8")]
		[Cpp2IlInjected.Address(RVA = "0xF16DE0", Offset = "0xF157E0", VA = "0x180F16DE0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_004c
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnDonate.ButtonComponent.m_OnClick;
			UnityAction call = OnConfirmClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnExit.m_OnClick;
			UnityAction call2 = OnCloseClickedHandler;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD9")]
		[Cpp2IlInjected.Address(RVA = "0xF16EF0", Offset = "0xF158F0", VA = "0x180F16EF0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_004c
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnDonate.ButtonComponent.m_OnClick;
			UnityAction call = OnConfirmClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnExit.m_OnClick;
			UnityAction call2 = OnCloseClickedHandler;
			onClick2.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FDA")]
		[Cpp2IlInjected.Address(RVA = "0xF15E70", Offset = "0xF14870", VA = "0x180F15E70", Slot = "28")]
		public override void OnFocusOut(bool popAfterPreFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0061
			//IL_001c: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			base.OnFocusOut(popAfterPreFocusOut);
			if (!popAfterPreFocusOut)
			{
				return;
			}
			Transform transform = hudCurrencylistContainer;
			int num = 0;
			if (transform != (UnityEngine.Object)num)
			{
				ListBase listBase = hudCurrencylist;
				int num2 = 0;
				if (listBase != (UnityEngine.Object)num2)
				{
					Transform transform2 = hudCurrencylist.transform;
					Transform transform4 = (transform2.parentInternal = hudCurrencylistContainer);
					hudCurrencylist.GetComponent<SlidingPanel>().Hide();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FDB")]
		[Cpp2IlInjected.Address(RVA = "0xF167C0", Offset = "0xF151C0", VA = "0x180F167C0", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__20))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__20 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__20(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FDC")]
		[Cpp2IlInjected.Address(RVA = "0xF15B60", Offset = "0xF14560", VA = "0x180F15B60")]
		private void OnConfirmClickHandler()
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FDD")]
		[Cpp2IlInjected.Address(RVA = "0xF15AF0", Offset = "0xF144F0", VA = "0x180F15AF0")]
		public void OnCloseClickedHandler()
		{
			//IL_001f: Expected O, but got I4
			MenuParam menuParam = _menuParam;
			if (menuParam != null)
			{
				Action<int> answerAction = menuParam.AnswerAction;
				if (answerAction != null)
				{
					int num = 0;
					answerAction((T)num);
				}
			}
			string typeName = ((IRemotingTypeInfo)this).TypeName;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FDE")]
		[Cpp2IlInjected.Address(RVA = "0xF158A0", Offset = "0xF142A0", VA = "0x180F158A0")]
		[AsyncStateMachine(typeof(_003CConfirmTask_003Ed__23))]
		public Task ConfirmTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FDF")]
		[Cpp2IlInjected.Address(RVA = "0xF16840", Offset = "0xF15240", VA = "0x180F16840")]
		private void RefreshPurchaseButton()
		{
			//Discarded unreachable code: IL_0032, IL_0038, IL_003e, IL_0044, IL_004a, IL_0050
			((Dictionary<TKey, TValue>)(object)_itemsNeeded).Clear();
			Dictionary<IItemData, int> itemsAmount = _itemsAmount;
			bool flag = default(bool);
			if (flag)
			{
				Client client = default(Client);
				ProfilePlayer player_ = client.Profile.player_;
				Dictionary<Item, int> itemsNeeded = _itemsNeeded;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FE0")]
		[Cpp2IlInjected.Address(RVA = "0xF16AC0", Offset = "0xF154C0", VA = "0x180F16AC0")]
		private unsafe void RefreshPurchaseItem()
		{
			//Discarded unreachable code: IL_007c, IL_0082, IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6, IL_00b8
			//IL_0035: Expected O, but got I4
			DonateItem donateItem = default(DonateItem);
			Client client = default(Client);
			bool isOwned = default(bool);
			int num5 = default(int);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = _mcItemsContent.m_Content.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num4 = 0;
					if (!(donateItem != (UnityEngine.Object)num4))
					{
						continue;
					}
					Dictionary<IItemData, int> itemsAmount = _itemsAmount;
					IItemData itemData = donateItem.ItemData;
					if (!((Dictionary<TKey, TValue>)(object)itemsAmount).TryGetValue((TKey)itemData, out *(TValue*)num))
					{
						continue;
					}
					ProfilePlayer player_ = client.Profile.player_;
					IItemData itemData2 = donateItem.ItemData;
					donateItem.RefreshPurchase(isOwned);
				}
				if (num5 == 0)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FE1")]
		[Cpp2IlInjected.Address(RVA = "0xF15A40", Offset = "0xF14440", VA = "0x180F15A40", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0005, IL_0022, IL_0026
			if (redirectionType != (RedirectionType)1)
			{
				return;
			}
			Button btnExit = _btnExit;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FE2")]
		[Cpp2IlInjected.Address(RVA = "0xF17000", Offset = "0xF15A00", VA = "0x180F17000")]
		public DonateItemPopup()
		{
		}
	}
}
