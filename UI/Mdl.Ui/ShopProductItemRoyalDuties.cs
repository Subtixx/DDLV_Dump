using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Gameloft.Common;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000701")]
	public class ShopProductItemRoyalDuties : ShopProductItemDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002823")]
		[SerializeField]
		private GameObject _mcAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002824")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002825")]
		[SerializeField]
		private SpriteAtlasImage _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002826")]
		[SerializeField]
		private AsyncAtlassedIcon _mcAsyncImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002827")]
		[SerializeField]
		private Image _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002828")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002829")]
		[SerializeField]
		private GameObject _mcGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400282A")]
		[SerializeField]
		private GameObject _mcLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400282B")]
		[SerializeField]
		private GameObject _mcLockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400282C")]
		[SerializeField]
		private TextBase _tfLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400282D")]
		[SerializeField]
		private GameObject _mcDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400282E")]
		[SerializeField]
		private TextBase _tfDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400282F")]
		[SerializeField]
		private GameObject _mcOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002830")]
		[SerializeField]
		private TextBase _tfOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002831")]
		[SerializeField]
		private GameObject _mcOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002832")]
		[SerializeField]
		private TextBase _tfOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002833")]
		[SerializeField]
		private GameObject _mcFeaturedTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002834")]
		[SerializeField]
		private TextBase _tfFeatured;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002835")]
		[SerializeField]
		private UITimer _mcTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4002836")]
		[SerializeField]
		private Transform _mcLayout1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4002837")]
		[SerializeField]
		private Transform _mcLayout2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002838")]
		[SerializeField]
		private Transform _mcLayout3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4002839")]
		[SerializeField]
		private ButtonTmProIcon _btnPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400283A")]
		[SerializeField]
		private Button _btnInfo;

		[Cpp2IlInjected.Token(Token = "0x6002CA9")]
		[Cpp2IlInjected.Address(RVA = "0x143B230", Offset = "0x1439C30", VA = "0x18143B230")]
		private new void Start()
		{
			//Discarded unreachable code: IL_0046
			Button.ButtonClickedEvent onClick = _btnPurchase.ButtonComponent.m_OnClick;
			UnityAction call = OnPurchaseClicked;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnInfo.m_OnClick;
			UnityAction call2 = base.OnInfoClicked;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CAA")]
		[Cpp2IlInjected.Address(RVA = "0x14395C0", Offset = "0x1437FC0", VA = "0x1814395C0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0046
			Button.ButtonClickedEvent onClick = _btnPurchase.ButtonComponent.m_OnClick;
			UnityAction call = OnPurchaseClicked;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnInfo.m_OnClick;
			UnityAction call2 = base.OnInfoClicked;
			onClick2.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CAB")]
		[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90", Slot = "25")]
		public override void RefreshData(ShopProductModel model)
		{
			base.Model = model;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CAC")]
		[Cpp2IlInjected.Address(RVA = "0x1439A10", Offset = "0x1438410", VA = "0x181439A10", Slot = "26")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_010a, IL_01c9, IL_021e, IL_026b, IL_0296, IL_02a5, IL_0375, IL_0383, IL_03db, IL_03e0, IL_0407, IL_0416
			//IL_0084: Expected O, but got I4
			//IL_00df: Expected O, but got I4
			//IL_0159: Expected O, but got I4
			//IL_029f: Expected O, but got I4
			//IL_02c7: Expected O, but got I4
			//IL_02f0: Expected F4, but got I4
			//IL_03ed: Expected O, but got I4
			ShopProductModel shopProductModel = base.Model;
			int num = 0;
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
			TextBase tfTitle = _tfTitle;
			ItemReward itemReward = default(ItemReward);
			Item item = itemReward.Item;
			ItemType itemType = default(ItemType);
			ItemType itemType2 = default(ItemType);
			if (itemType != ItemType.Furniture && itemType2 != ItemType.Clothing)
			{
				_mcImage.gameObject.SetActive(value: true);
				GameObject gameObject = _mcAsyncImage.gameObject;
				int num4 = 0;
				gameObject.SetActive((byte)num4 != 0);
				_mcImage.ImageAddress = (string)num4;
				GameObject mcOffer = _mcOffer;
				int active = 0;
				mcOffer.SetActive((byte)active != 0);
				GameObject mcAmount = _mcAmount;
				TextBase tfAmount = _tfAmount;
				string text = default(string);
				string text3 = (tfAmount.Text = "x" + text);
				_mcAmount.SetActive(value: true);
				if ((object)_tfAmount.transform != null)
				{
				}
				LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num);
				if ((object)_mcAmount.transform != null)
				{
				}
				GameObject mcOffer2 = _mcOffer;
				TextBase tfOffer = _tfOffer;
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			GameObject gameObject2 = _mcImage.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			_mcAsyncImage.gameObject.SetActive(value: true);
			Item item2 = Enumerable.FirstOrDefault<ItemReward>((IEnumerable<>)0).Item;
			AsyncAtlassedIcon mcAsyncImage = _mcAsyncImage;
			bool flag = default(bool);
			while ((flag ? 1 : 0) <= (true ? 1 : 0))
			{
			}
			TextBase tfAmount2 = _tfAmount;
			string text4 = default(string);
			string text6 = (tfAmount2.Text = "x" + text4);
			_mcAmount.SetActive(value: true);
			if ((object)_tfAmount.transform != null)
			{
			}
			if ((object)_mcAmount.transform != null)
			{
			}
			TextBase tfOffer2 = _tfOffer;
			Dictionary<string, object> dictionary2 = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CAD")]
		[Cpp2IlInjected.Address(RVA = "0x143A9A0", Offset = "0x14393A0", VA = "0x18143A9A0")]
		private void RefreshLocked(FakeShopProductModel fakeData)
		{
			//Discarded unreachable code: IL_010b, IL_0111, IL_0117, IL_011d, IL_0123
			//IL_0097: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Predicate<FakeShopProductUnlockCondition> predicate = (Predicate<FakeShopProductUnlockCondition>)(object)(Predicate<T>)delegate(FakeShopProductUnlockCondition x)
			{
				//Discarded unreachable code: IL_000f
				FakeShopProductModel productModel = fakeData;
				return x.IsUnlocked(productModel);
			};
			Image component = _mcAmount.GetComponent<Image>();
			GameObject mcGlow = _mcGlow;
			if (1 == 0)
			{
				int active = 0;
				mcGlow.SetActive((byte)active != 0);
				_mcLocked.SetActive(value: true);
				_mcLockedIcon.SetActive(value: true);
				if (true)
				{
					bool flag = default(bool);
					if (flag)
					{
						bool flag2 = default(bool);
						while (flag2)
						{
						}
						if (!flag2)
						{
							if (flag2)
							{
								goto IL_00a5;
							}
							GameObject mcLockedIcon = _mcLockedIcon;
							int active2 = 0;
							mcLockedIcon.SetActive((byte)active2 != 0);
						}
						string text = $"Required lvl {flag2}";
						_mcLockedIcon.SetActive(value: true);
					}
					goto IL_00a5;
				}
				goto IL_00a8;
			}
			goto IL_00e3;
			IL_00a5:
			int num3 = 0;
			goto IL_00a8;
			IL_00a8:
			Transform transform = default(Transform);
			if ((object)transform != null)
			{
			}
			GameObject gameObject = transform.gameObject;
			int active3 = 0;
			gameObject.SetActive((byte)active3 != 0);
			int num4 = 0;
			component.color = (Color)num4;
			int num5 = 0;
			TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
			textMeshProUGUI.color = (Color)num5;
			Color color = (Color32)num5;
			goto IL_00e3;
			IL_00e3:
			int num6 = 0;
			GameObject gameObject2 = default(GameObject);
			gameObject2.SetActive(value: true);
			Color white = Color.white;
			Color white2 = Color.white;
			Color white3 = Color.white;
			Color white4 = Color.white;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CAE")]
		[Cpp2IlInjected.Address(RVA = "0x1438DC0", Offset = "0x14377C0", VA = "0x181438DC0")]
		private void DebugDoVisualTweak()
		{
			//Discarded unreachable code: IL_0118, IL_011e, IL_0124, IL_012a, IL_0130, IL_0136, IL_013c, IL_0148
			float f = default(float);
			ItemReward itemReward = default(ItemReward);
			GameObject gameObject2 = default(GameObject);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				ShopProductModel shopProductModel = base.Model;
				if (shopProductModel == null)
				{
					break;
				}
				int num2 = 0;
				if (shopProductModel == null)
				{
					break;
				}
				int num3 = 0;
				int num4 = 0;
				int b = Mathf.FloorToInt(f);
				int num5 = Mathf.Min(2, b);
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = itemReward.Item;
				switch (num5)
				{
				}
				Transform mcLayout = _mcLayout1;
				int childCount = _mcImage.transform.parent.childCount;
				GameObject original = _mcImage.gameObject;
				Transform parent = _mcImage.transform.parent;
				GameObject gameObject = UnityEngine.Object.Instantiate(original, parent);
				childCount++;
				while (childCount <= num5)
				{
				}
				mcLayout.gameObject.SetActive(value: true);
				IEnumerator enumerator = _mcImage.transform.parent.GetEnumerator();
				if (enumerator != null)
				{
					if (enumerator == null)
					{
					}
					int num6 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					UnityEngine.Object.Destroy(gameObject2);
					num++;
					if ((object)mcLayout.GetChild(num) != null)
					{
					}
					if ((object)gameObject2 != null)
					{
					}
					num++;
				}
				if (flag)
				{
				}
				if (num5 == 0)
				{
					GameObject gameObject3 = mcLayout.gameObject;
					int active = 0;
					gameObject3.SetActive((byte)active != 0);
					return;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CAF")]
		[Cpp2IlInjected.Address(RVA = "0x14398F0", Offset = "0x14382F0", VA = "0x1814398F0")]
		private void OnTimerComplete(object sender, object param)
		{
			//IL_0028: Expected O, but got I4
			GameObject target = base.gameObject;
			TweenDelegate tweenDelegate = delegate
			{
				UnityEngine.Object.Destroy(base.gameObject);
			};
			int num = 0;
			_003C_003Ef__AnonymousType31<float, float, float, TweenDelegate> vars = default(_003C_003Ef__AnonymousType31<float, float, float, TweenDelegate>);
			TweenMax tweenMax = TweenMax.To(target, 0.2f, vars, int.MinValue, num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB0")]
		[Cpp2IlInjected.Address(RVA = "0x14396D0", Offset = "0x14380D0", VA = "0x1814396D0")]
		public void OnPurchaseClicked()
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB1")]
		[Cpp2IlInjected.Address(RVA = "0x14393F0", Offset = "0x1437DF0", VA = "0x1814393F0")]
		[AsyncStateMachine(typeof(_003CDoFakePurchaseTransaction_003Ed__32))]
		private Task DoFakePurchaseTransaction(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB2")]
		[Cpp2IlInjected.Address(RVA = "0x1439510", Offset = "0x1437F10", VA = "0x181439510")]
		[IteratorStateMachine(typeof(_003COnDelayedCall_003Ed__33))]
		private IEnumerator OnDelayedCall(float delay, ItemReward itemReward, GameObject imageObj, bool doTransaction)
		{
			int _003C_003E1__state = default(int);
			_003COnDelayedCall_003Ed__33 _003COnDelayedCall_003Ed__ = new _003COnDelayedCall_003Ed__33(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnDelayedCall_003Ed__.itemReward = itemReward;
			_003COnDelayedCall_003Ed__.delay = delay;
			_003COnDelayedCall_003Ed__.imageObj = imageObj;
			_003COnDelayedCall_003Ed__.doTransaction = false;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB3")]
		[Cpp2IlInjected.Address(RVA = "0x142EDD0", Offset = "0x142D7D0", VA = "0x18142EDD0")]
		public ShopProductItemRoyalDuties()
		{
		}
	}
}
