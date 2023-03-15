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
	[Cpp2IlInjected.Token(Token = "0x20006EB")]
	public class ShopProductItemCurrency : ShopProductItemDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002709")]
		[SerializeField]
		private GameObject _mcAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400270A")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400270B")]
		[SerializeField]
		private SpriteAtlasImage _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400270C")]
		[SerializeField]
		private GameObject _mcDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400270D")]
		[SerializeField]
		private TextBase _tfDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400270E")]
		[SerializeField]
		private GameObject _mcOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400270F")]
		[SerializeField]
		private TextBase _tfOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002710")]
		[SerializeField]
		private GameObject _mcOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002711")]
		[SerializeField]
		private TextBase _tfOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002712")]
		[SerializeField]
		private GameObject _mcFeaturedTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002713")]
		[SerializeField]
		private TextBase _tfFeatured;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002714")]
		[SerializeField]
		private UITimer _mcTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002715")]
		[SerializeField]
		private Transform _mcLayout1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002716")]
		[SerializeField]
		private Transform _mcLayout2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002717")]
		[SerializeField]
		private Transform _mcLayout3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002718")]
		[SerializeField]
		private ButtonTmProIcon _btnPurchase;

		[Cpp2IlInjected.Token(Token = "0x6002C3D")]
		[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90", Slot = "25")]
		public override void RefreshData(ShopProductModel model)
		{
			base.Model = model;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3E")]
		[Cpp2IlInjected.Address(RVA = "0x14304B0", Offset = "0x142EEB0", VA = "0x1814304B0", Slot = "26")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00b7, IL_011d, IL_0162, IL_019e, IL_01ad, IL_027d, IL_028b, IL_02e3, IL_02e8, IL_030f, IL_031e
			//IL_008f: Expected O, but got I4
			//IL_01a7: Expected O, but got I4
			//IL_01cf: Expected O, but got I4
			//IL_01f8: Expected F4, but got I4
			//IL_02f5: Expected O, but got I4
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
				int num3 = 0;
				SpriteAtlasImage mcImage = _mcImage;
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
				if ((object)_tfAmount.transform.parent != null)
				{
				}
				GameObject mcOffer2 = _mcOffer;
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3F")]
		[Cpp2IlInjected.Address(RVA = "0x142F970", Offset = "0x142E370", VA = "0x18142F970")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C40")]
		[Cpp2IlInjected.Address(RVA = "0x1430390", Offset = "0x142ED90", VA = "0x181430390")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C41")]
		[Cpp2IlInjected.Address(RVA = "0x1430170", Offset = "0x142EB70", VA = "0x181430170")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C42")]
		[Cpp2IlInjected.Address(RVA = "0x142FFA0", Offset = "0x142E9A0", VA = "0x18142FFA0")]
		[AsyncStateMachine(typeof(_003CDoFakePurchaseTransaction_003Ed__21))]
		private Task DoFakePurchaseTransaction(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C43")]
		[Cpp2IlInjected.Address(RVA = "0x14300C0", Offset = "0x142EAC0", VA = "0x1814300C0")]
		[IteratorStateMachine(typeof(_003COnDelayedCall_003Ed__22))]
		private IEnumerator OnDelayedCall(float delay, ItemReward itemReward, GameObject imageObj, bool doTransaction)
		{
			int _003C_003E1__state = default(int);
			_003COnDelayedCall_003Ed__22 _003COnDelayedCall_003Ed__ = new _003COnDelayedCall_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnDelayedCall_003Ed__.itemReward = itemReward;
			_003COnDelayedCall_003Ed__.delay = delay;
			_003COnDelayedCall_003Ed__.imageObj = imageObj;
			_003COnDelayedCall_003Ed__.doTransaction = false;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C44")]
		[Cpp2IlInjected.Address(RVA = "0x142EDD0", Offset = "0x142D7D0", VA = "0x18142EDD0")]
		public ShopProductItemCurrency()
		{
		}
	}
}
