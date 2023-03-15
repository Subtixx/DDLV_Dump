using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006F3")]
	public class ShopProductItemDailyReward : ShopProductItemDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002756")]
		[SerializeField]
		private GameObject _mcOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002757")]
		[SerializeField]
		private TextBase _tfOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002758")]
		[SerializeField]
		private GameObject _mcFeaturedTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002759")]
		[SerializeField]
		private TextBase _tfFeatured;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400275A")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400275B")]
		[SerializeField]
		private SpriteAtlasImage _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400275C")]
		[SerializeField]
		private GameObject _mcOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400275D")]
		[SerializeField]
		private TextBase _tfOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400275E")]
		[SerializeField]
		private GameObject _mcPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400275F")]
		[SerializeField]
		private TextBase _tfPurchaseDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002760")]
		[SerializeField]
		private GameObject _mcCollect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002761")]
		[SerializeField]
		private ButtonTmPro _btnCollect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002762")]
		[SerializeField]
		private ButtonTmPro _btnPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002763")]
		[SerializeField]
		private RedDot _mcRedDotCollect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002764")]
		[SerializeField]
		private TextBase _tfDayLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002765")]
		[SerializeField]
		private UITimer _mcTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002766")]
		[SerializeField]
		private GameObject _mcAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002767")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002768")]
		[SerializeField]
		private GameObject _mcDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4002769")]
		[SerializeField]
		private TextBase _tfDiscount;

		[Cpp2IlInjected.Token(Token = "0x6002C5C")]
		[Cpp2IlInjected.Address(RVA = "0x1432150", Offset = "0x1430B50", VA = "0x181432150")]
		private new void OnDisable()
		{
			//Discarded unreachable code: IL_001c
			UITimer mcTimer = _mcTimer;
			UITimer.TimerEventDelegate value = OnTimerComplete;
			mcTimer.TimerComplete -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C5D")]
		[Cpp2IlInjected.Address(RVA = "0x14321E0", Offset = "0x1430BE0", VA = "0x1814321E0")]
		private new void OnEnable()
		{
			//Discarded unreachable code: IL_0040
			UITimer mcTimer = _mcTimer;
			if (!mcTimer.IsPaused)
			{
				UITimer.TimerEventDelegate value = OnTimerComplete;
				mcTimer.TimerComplete -= value;
				UITimer mcTimer2 = _mcTimer;
				UITimer.TimerEventDelegate value2 = OnTimerComplete;
				mcTimer2.TimerComplete += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C5E")]
		[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90", Slot = "25")]
		public override void RefreshData(ShopProductModel model)
		{
			base.Model = model;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C5F")]
		[Cpp2IlInjected.Address(RVA = "0x1432580", Offset = "0x1430F80", VA = "0x181432580", Slot = "26")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00a4, IL_0125, IL_0133, IL_0148, IL_0154, IL_0176, IL_0184, IL_0199, IL_019e, IL_01b3, IL_0237, IL_0244, IL_0420
			//IL_01ab: Expected O, but got I4
			//IL_01de: Expected O, but got I4
			//IL_01ee: Expected O, but got I4
			//IL_0263: Expected O, but got I4
			//IL_0273: Expected O, but got I4
			//IL_02ee: Expected I4, but got F8
			//IL_0305: Expected O, but got I4
			//IL_032e: Expected F4, but got I4
			ShopProductModel shopProductModel = base.Model;
			int num = 0;
			if (shopProductModel != null)
			{
				int num2 = 0;
				if (shopProductModel != null)
				{
					Client client = default(Client);
					DateTime localTime = client.LocalTime;
					ShopProductModel shopProductModel2 = base.Model;
					int num3 = 0;
					SpriteAtlasImage mcImage = _mcImage;
					_mcImage.gameObject.SetActive(value: true);
					TextBase tfTitle = _tfTitle;
					string text = default(string);
					_btnPurchase.Label.Text = text;
					int num4 = 0;
					GameObject mcOldPrice = _mcOldPrice;
					int active = 0;
					mcOldPrice.SetActive((byte)active != 0);
					GameObject mcDiscount = _mcDiscount;
					string text2 = default(string);
					_tfOldPrice.Text = text2;
					_mcOldPrice.SetActive(value: true);
					Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C60")]
		[Cpp2IlInjected.Address(RVA = "0x14324F0", Offset = "0x1430EF0", VA = "0x1814324F0")]
		private void OnTimerComplete(object sender, object param)
		{
			ShopProductModel shopProductModel = base.Model;
			if (shopProductModel != null)
			{
				int num = 0;
				if (shopProductModel != null)
				{
					ContextStack context = ((IDesignerSerializationManager)this).Context;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C61")]
		[Cpp2IlInjected.Address(RVA = "0x1431F00", Offset = "0x1430900", VA = "0x181431F00")]
		public void OnCollectClicked()
		{
			//Discarded unreachable code: IL_0032
			ButtonTmPro btnCollect = _btnCollect;
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C62")]
		[Cpp2IlInjected.Address(RVA = "0x14322C0", Offset = "0x1430CC0", VA = "0x1814322C0")]
		public void OnPurchaseClicked()
		{
			//Discarded unreachable code: IL_002a
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C63")]
		[Cpp2IlInjected.Address(RVA = "0x1431DD0", Offset = "0x14307D0", VA = "0x181431DD0")]
		[AsyncStateMachine(typeof(_003CDoFakePurchaseTransaction_003Ed__27))]
		private Task DoFakePurchaseTransaction(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C64")]
		[Cpp2IlInjected.Address(RVA = "0x1431CA0", Offset = "0x14306A0", VA = "0x181431CA0")]
		[AsyncStateMachine(typeof(_003CDoFakeCollectTransaction_003Ed__28))]
		private Task DoFakeCollectTransaction(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C65")]
		[Cpp2IlInjected.Address(RVA = "0x142EDD0", Offset = "0x142D7D0", VA = "0x18142EDD0")]
		public ShopProductItemDailyReward()
		{
		}
	}
}
