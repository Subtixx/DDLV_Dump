using System;
using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Rewards;
using Gameloft.Common;
using Meta.Online;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006E4")]
	public class ShopProductItemBundle : ShopProductItemDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40026C2")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40026C3")]
		[SerializeField]
		private Image _mcBackgroundGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40026C4")]
		[SerializeField]
		private SpriteAtlasImage _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40026C5")]
		[SerializeField]
		private GameObject _mcOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40026C6")]
		[SerializeField]
		private TextBase _tfOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40026C7")]
		[SerializeField]
		private GameObject _mcPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40026C8")]
		[SerializeField]
		private TextBase _tfPurchaseDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40026C9")]
		[SerializeField]
		private GameObject _mcCollect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40026CA")]
		[SerializeField]
		private ButtonTmPro _btnCollect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40026CB")]
		[SerializeField]
		private ButtonTmPro _btnPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40026CC")]
		[SerializeField]
		private RedDot _mcRedDotCollect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40026CD")]
		[SerializeField]
		private GameObject _mcRewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40026CE")]
		[SerializeField]
		private Transform _mcItemRewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40026CF")]
		[SerializeField]
		private GameObject _mcPerk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40026D0")]
		[SerializeField]
		private TextBase _tfPerk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40026D1")]
		[SerializeField]
		private AsyncAtlassedIcon _iconPerk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40026D2")]
		[SerializeField]
		private ShopProductSubItemBundle _mcDailyReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40026D3")]
		[SerializeField]
		private TextBase _tfDailyReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40026D4")]
		[SerializeField]
		private UITimer _mcTimer;

		[Cpp2IlInjected.Token(Token = "0x6002C1C")]
		[Cpp2IlInjected.Address(RVA = "0x142D900", Offset = "0x142C300", VA = "0x18142D900")]
		private new void OnDisable()
		{
			//Discarded unreachable code: IL_001c
			UITimer mcTimer = _mcTimer;
			UITimer.TimerEventDelegate value = OnTimerComplete;
			mcTimer.TimerComplete -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C1D")]
		[Cpp2IlInjected.Address(RVA = "0x142D990", Offset = "0x142C390", VA = "0x18142D990")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C1E")]
		[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90", Slot = "25")]
		public override void RefreshData(ShopProductModel model)
		{
			base.Model = model;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C1F")]
		[Cpp2IlInjected.Address(RVA = "0x142DD30", Offset = "0x142C730", VA = "0x18142DD30", Slot = "26")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_01d1, IL_025b, IL_0433, IL_0461, IL_0467, IL_046d, IL_0473, IL_0479, IL_047f, IL_0485, IL_0491
			//IL_00c6: Expected F4, but got I4
			//IL_00c6: Expected F4, but got I4
			//IL_00d9: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			//IL_0212: Expected O, but got I4
			//IL_0222: Expected O, but got I4
			//IL_0272: Expected O, but got I4
			//IL_0282: Expected O, but got I4
			//IL_02fd: Expected I4, but got F8
			//IL_0314: Expected O, but got I4
			//IL_033d: Expected F4, but got I4
			int num = 0;
			ShopProductModel shopProductModel = base.Model;
			if (shopProductModel == null)
			{
				return;
			}
			int num2 = 0;
			if (shopProductModel == null)
			{
				return;
			}
			Client client = default(Client);
			DateTime localTime = client.LocalTime;
			ShopProductModel shopProductModel2 = base.Model;
			int num3 = 0;
			SpriteAtlasImage mcImage = _mcImage;
			if (shopProductModel2 == null)
			{
				GameObject gameObject = mcImage.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				Transform transform = _mcRewards.transform;
			}
			_mcImage.gameObject.SetActive(value: true);
			Transform transform2 = _mcRewards.transform;
			GameObject gameObject2 = _mcBackgroundGradient.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = default(GameObject);
			gameObject3.SetActive(value: true);
			Image mcBackgroundGradient = _mcBackgroundGradient;
			RectTransform rectTransform = _mcBackgroundGradient.rectTransform;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			Quaternion quaternion = Quaternion.Euler(239f, num6, num5);
			_mcBackgroundGradient.rectTransform.offsetMin = (Vector2)num;
			_tfTitle.Text = (string)num;
			string text = default(string);
			_btnPurchase.Label.Text = text;
			GameObject mcOldPrice = _mcOldPrice;
			string text2 = default(string);
			_tfOldPrice.Text = text2;
			_mcOldPrice.SetActive(value: true);
			if (text2 != null)
			{
				GameObject mcPerk = _mcPerk;
				int active3 = 0;
				mcPerk.SetActive((byte)active3 != 0);
				((LayoutGroup)_mcRewards.GetComponent<VerticalLayoutGroup>()).m_Padding.top = 50;
				IEnumerator enumerator = _mcItemRewards.GetEnumerator();
				if (enumerator != null)
				{
					if (enumerator == null)
					{
					}
					int num7 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int active4 = 0;
					GameObject gameObject4 = default(GameObject);
					gameObject4.SetActive((byte)active4 != 0);
					num++;
					GameObject gameObject5 = default(GameObject);
					gameObject5.SetActive(value: true);
					num++;
				}
				num++;
				if (num != 0)
				{
				}
				if (num == 0)
				{
				}
			}
			int num8 = 0;
			int active5 = 0;
			GameObject gameObject6 = default(GameObject);
			gameObject6.SetActive((byte)active5 != 0);
			int active6 = 0;
			gameObject6.SetActive((byte)active6 != 0);
			int active7 = 0;
			GameObject gameObject7 = default(GameObject);
			gameObject7.SetActive((byte)active7 != 0);
			gameObject7.SetActive(value: true);
			int active8 = 0;
			GameObject gameObject8 = default(GameObject);
			gameObject8.SetActive((byte)active8 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C20")]
		[Cpp2IlInjected.Address(RVA = "0x142DCA0", Offset = "0x142C6A0", VA = "0x18142DCA0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C21")]
		[Cpp2IlInjected.Address(RVA = "0x142D630", Offset = "0x142C030", VA = "0x18142D630")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C22")]
		[Cpp2IlInjected.Address(RVA = "0x142DA70", Offset = "0x142C470", VA = "0x18142DA70")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C23")]
		[Cpp2IlInjected.Address(RVA = "0x142D500", Offset = "0x142BF00", VA = "0x18142D500")]
		[AsyncStateMachine(typeof(_003CDoFakePurchaseTransaction_003Ed__26))]
		private Task DoFakePurchaseTransaction(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C24")]
		[Cpp2IlInjected.Address(RVA = "0x142D850", Offset = "0x142C250", VA = "0x18142D850")]
		[IteratorStateMachine(typeof(_003COnDelayedCall_003Ed__27))]
		private IEnumerator OnDelayedCall(float delay, ItemReward itemReward, GameObject imageObj, bool doTransaction)
		{
			int _003C_003E1__state = default(int);
			_003COnDelayedCall_003Ed__27 _003COnDelayedCall_003Ed__ = new _003COnDelayedCall_003Ed__27(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnDelayedCall_003Ed__.itemReward = itemReward;
			_003COnDelayedCall_003Ed__.delay = delay;
			_003COnDelayedCall_003Ed__.imageObj = imageObj;
			_003COnDelayedCall_003Ed__.doTransaction = false;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C25")]
		[Cpp2IlInjected.Address(RVA = "0x142D400", Offset = "0x142BE00", VA = "0x18142D400")]
		[AsyncStateMachine(typeof(_003CDoFakeCollectTransaction_003Ed__28))]
		private Task DoFakeCollectTransaction(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C26")]
		[Cpp2IlInjected.Address(RVA = "0x142EDD0", Offset = "0x142D7D0", VA = "0x18142EDD0")]
		public ShopProductItemBundle()
		{
		}
	}
}
