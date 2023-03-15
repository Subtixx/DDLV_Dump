using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Gameloft.Common;
using Meta.Online;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006FB")]
	public class ShopProductItemGem : ShopProductItemDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40027BC")]
		[SerializeField]
		private GameObject _mcAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40027BD")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40027BE")]
		[SerializeField]
		private SpriteAtlasImage _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40027BF")]
		[SerializeField]
		private ButtonTmPro _btnPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40027C0")]
		[SerializeField]
		private GameObject _mcDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40027C1")]
		[SerializeField]
		private GameObject _mcInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40027C2")]
		[SerializeField]
		private TextBase _tfInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40027C3")]
		[SerializeField]
		private TextBase _tfDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40027C4")]
		[SerializeField]
		private GameObject _mcOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40027C5")]
		[SerializeField]
		private TextBase _tfOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40027C6")]
		[SerializeField]
		private GameObject _mcOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40027C7")]
		[SerializeField]
		private TextBase _tfOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40027C8")]
		[SerializeField]
		private GameObject _mcFeaturedTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40027C9")]
		[SerializeField]
		private TextBase _tfFeatured;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40027CA")]
		[SerializeField]
		private UITimer _mcTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40027CB")]
		[SerializeField]
		private Transform _mcLayout1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40027CC")]
		[SerializeField]
		private Transform _mcLayout2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40027CD")]
		[SerializeField]
		private Transform _mcLayout3;

		[Cpp2IlInjected.Token(Token = "0x6002C87")]
		[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90", Slot = "25")]
		public override void RefreshData(ShopProductModel model)
		{
			base.Model = model;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C88")]
		[Cpp2IlInjected.Address(RVA = "0x1436620", Offset = "0x1435020", VA = "0x181436620", Slot = "26")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00cc, IL_0197, IL_01d4, IL_01dc, IL_02ad, IL_02bb, IL_0313, IL_0318, IL_032d, IL_034f, IL_0357, IL_036c, IL_0371, IL_0377, IL_03a6, IL_03b1, IL_03b7, IL_03d5, IL_03da, IL_03df, IL_03e4, IL_03eb, IL_03f2, IL_0419, IL_0427, IL_0435
			//IL_006f: Expected O, but got I4
			//IL_00b7: Expected I4, but got I8
			//IL_0101: Expected I4, but got I8
			//IL_0130: Expected O, but got I4
			//IL_0130: Expected O, but got F4
			//IL_0172: Expected O, but got I4
			//IL_0172: Expected O, but got F4
			//IL_0172: Expected O, but got F4
			//IL_018a: Expected I4, but got I8
			//IL_01cc: Expected I4, but got I8
			//IL_01fe: Expected O, but got I4
			//IL_0227: Expected F4, but got I4
			//IL_0239: Expected I4, but got I8
			//IL_0325: Expected O, but got I4
			//IL_039a: Expected O, but got I4
			//IL_0425: Expected O, but got I4
			//IL_0433: Expected O, but got I4
			//IL_0441: Expected O, but got I4
			ShopProductModel shopProductModel = base.Model;
			int num = 0;
			if (shopProductModel == null)
			{
				return;
			}
			int num2 = 0;
			if (shopProductModel != null)
			{
				Client client = default(Client);
				DateTime localTime = client.LocalTime;
				ShopProductModel shopProductModel2 = base.Model;
				if (shopProductModel2 == null)
				{
				}
				int num3 = 0;
				FakeShopProductModel fakeData = (FakeShopProductModel)shopProductModel2;
				GameObject mcInactive = _mcInactive;
				Predicate<FakeShopProductUnlockCondition> predicate = (Predicate<FakeShopProductUnlockCondition>)(object)(Predicate<T>)delegate(FakeShopProductUnlockCondition x)
				{
					//Discarded unreachable code: IL_000f
					FakeShopProductModel productModel = fakeData;
					return x.IsUnlocked(productModel);
				};
				int num4 = 0;
				mcInactive.SetActive((byte)num4 != 0);
				_mcImage.ImageAddress = (string)num4;
				GameObject mcOffer = _mcOffer;
				int active = 0;
				mcOffer.SetActive((byte)active != 0);
				GameObject mcAmount = _mcAmount;
				TextBase tfAmount = _tfAmount;
				string text = default(string);
				string text3 = (tfAmount.Text = "x" + text);
				ulong num5 = default(ulong);
				_mcAmount.SetActive((byte)num5 != 0);
				GameObject mcOffer2 = _mcOffer;
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C89")]
		[Cpp2IlInjected.Address(RVA = "0x1435AA0", Offset = "0x14344A0", VA = "0x181435AA0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C8A")]
		[Cpp2IlInjected.Address(RVA = "0x14364C0", Offset = "0x1434EC0", VA = "0x1814364C0")]
		private void OnTimerComplete(object sender, object param)
		{
			//IL_0037: Expected O, but got I4
			GameObject target = base.gameObject;
			TweenDelegate tweenDelegate = delegate
			{
				UnityEngine.Object.Destroy(base.gameObject);
			};
			TweenDelegate tweenDelegate2 = delegate
			{
				//Discarded unreachable code: IL_0019
				//IL_0018: Expected O, but got I4
				Transform parent = base.transform.parent;
				int num2 = 0;
				if ((object)parent != null)
				{
				}
				LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)num2);
			};
			int num = 0;
			_003C_003Ef__AnonymousType32<float, float, float, TweenDelegate, TweenDelegate> vars = default(_003C_003Ef__AnonymousType32<float, float, float, TweenDelegate, TweenDelegate>);
			TweenMax tweenMax = TweenMax.To(target, 0.2f, vars, int.MinValue, num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8B")]
		[Cpp2IlInjected.Address(RVA = "0x14362A0", Offset = "0x1434CA0", VA = "0x1814362A0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C8C")]
		[Cpp2IlInjected.Address(RVA = "0x14360D0", Offset = "0x1434AD0", VA = "0x1814360D0")]
		[AsyncStateMachine(typeof(_003CDoFakePurchaseTransaction_003Ed__23))]
		private Task DoFakePurchaseTransaction(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8D")]
		[Cpp2IlInjected.Address(RVA = "0x14361F0", Offset = "0x1434BF0", VA = "0x1814361F0")]
		[IteratorStateMachine(typeof(_003COnDelayedCall_003Ed__24))]
		private IEnumerator OnDelayedCall(float delay, ItemReward itemReward, GameObject imageObj, bool doTransaction)
		{
			int _003C_003E1__state = default(int);
			_003COnDelayedCall_003Ed__24 _003COnDelayedCall_003Ed__ = new _003COnDelayedCall_003Ed__24(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnDelayedCall_003Ed__.itemReward = itemReward;
			_003COnDelayedCall_003Ed__.delay = delay;
			_003COnDelayedCall_003Ed__.imageObj = imageObj;
			_003COnDelayedCall_003Ed__.doTransaction = false;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8E")]
		[Cpp2IlInjected.Address(RVA = "0x142EDD0", Offset = "0x142D7D0", VA = "0x18142EDD0")]
		public ShopProductItemGem()
		{
		}
	}
}
