using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006F7")]
	public class ShopProductItemGacha : ShopProductItemDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400277E")]
		public List<Texture2D> TexturesPresentBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400277F")]
		[SerializeField]
		private Image _mcBackgroundGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002780")]
		[SerializeField]
		private GameObject _mcOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002781")]
		[SerializeField]
		private TextBase _tfOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002782")]
		[SerializeField]
		private GameObject _mcPresent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002783")]
		[SerializeField]
		private RawImage _mcPresentTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002784")]
		[SerializeField]
		private RawImage _mcPresentBot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002785")]
		[SerializeField]
		private TextBase _tfOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002786")]
		[SerializeField]
		private TextBase _tfOldPriceX10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002787")]
		[SerializeField]
		private GameObject _mcDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002788")]
		[SerializeField]
		private TextBase _tfDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002789")]
		[SerializeField]
		private GameObject _mcDiscountX10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400278A")]
		[SerializeField]
		private TextBase _tfDiscountX10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400278B")]
		[SerializeField]
		private RedDot _mcRedDotFree;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400278C")]
		[SerializeField]
		private UITimer _mcTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400278D")]
		[SerializeField]
		private GameObject _mcActionsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400278E")]
		[SerializeField]
		private GameObject _mcAction1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400278F")]
		[SerializeField]
		private GameObject _mcAction2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002790")]
		[SerializeField]
		private GameObject _mcGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4002791")]
		[SerializeField]
		private GameObject _mcSparkle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4002792")]
		[SerializeField]
		private ButtonTmProIcon _btnPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002793")]
		[SerializeField]
		private ButtonTmProIcon _btnPurchase10x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4002794")]
		[SerializeField]
		private ButtonTmPro _btnFree;

		[Cpp2IlInjected.Token(Token = "0x6002C74")]
		[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90", Slot = "25")]
		public override void RefreshData(ShopProductModel model)
		{
			base.Model = model;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C75")]
		[Cpp2IlInjected.Address(RVA = "0x1434880", Offset = "0x1433280", VA = "0x181434880", Slot = "26")]
		public override void RefreshDisplay()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C76")]
		[Cpp2IlInjected.Address(RVA = "0x1433EB0", Offset = "0x14328B0", VA = "0x181433EB0", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//Discarded unreachable code: IL_00bb
			do
			{
				if (direction != 0)
				{
					continue;
				}
				BaseButton baseButton = BaseButton;
				ButtonTmPro btnFree = _btnFree;
				if (baseButton == btnFree)
				{
					continue;
				}
				BaseButton baseButton2 = BaseButton;
				ButtonTmProIcon btnPurchase = _btnPurchase;
				if (!(baseButton2 == btnPurchase))
				{
					BaseButton.OnHighlightExit();
					if (!_btnFree.gameObject.activeSelf)
					{
						ButtonTmProIcon buttonTmProIcon = (ButtonTmProIcon)(BaseButton = _btnPurchase);
					}
					ButtonTmPro buttonTmPro = (ButtonTmPro)(BaseButton = _btnFree);
				}
			}
			while (direction != FocusDirection.Right);
			BaseButton baseButton3 = BaseButton;
			ButtonTmProIcon btnPurchase10x = _btnPurchase10x;
			if (!(baseButton3 == btnPurchase10x))
			{
				BaseButton.OnHighlightExit();
				ButtonTmProIcon buttonTmProIcon2 = (ButtonTmProIcon)(BaseButton = _btnPurchase10x);
			}
			return base.FindNext(FocusDirection.Right, input);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C77")]
		[Cpp2IlInjected.Address(RVA = "0x1434720", Offset = "0x1433120", VA = "0x181434720")]
		private void OnTimerComplete(object sender, object param)
		{
			//IL_0037: Expected O, but got I4
			GameObject target = base.gameObject;
			TweenDelegate tweenDelegate = delegate
			{
				Object.Destroy(base.gameObject);
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

		[Cpp2IlInjected.Token(Token = "0x6002C78")]
		[Cpp2IlInjected.Address(RVA = "0x14340A0", Offset = "0x1432AA0", VA = "0x1814340A0")]
		public void OnFreeClicked()
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

		[Cpp2IlInjected.Token(Token = "0x6002C79")]
		[Cpp2IlInjected.Address(RVA = "0x14342C0", Offset = "0x1432CC0", VA = "0x1814342C0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C7A")]
		[Cpp2IlInjected.Address(RVA = "0x14344F0", Offset = "0x1432EF0", VA = "0x1814344F0")]
		public void OnPurchaseX10Clicked()
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

		[Cpp2IlInjected.Token(Token = "0x6002C7B")]
		[Cpp2IlInjected.Address(RVA = "0x1433B30", Offset = "0x1432530", VA = "0x181433B30")]
		[AsyncStateMachine(typeof(_003CDoFakeFreeTransaction_003Ed__30))]
		private Task DoFakeFreeTransaction(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C7C")]
		[Cpp2IlInjected.Address(RVA = "0x1433C50", Offset = "0x1432650", VA = "0x181433C50")]
		[AsyncStateMachine(typeof(_003CDoFakePurchaseTransaction_003Ed__31))]
		private Task DoFakePurchaseTransaction(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C7D")]
		[Cpp2IlInjected.Address(RVA = "0x1433D80", Offset = "0x1432780", VA = "0x181433D80")]
		[AsyncStateMachine(typeof(_003CDoFakePurchaseX10Transaction_003Ed__32))]
		private Task DoFakePurchaseX10Transaction(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C7E")]
		[Cpp2IlInjected.Address(RVA = "0x142EDD0", Offset = "0x142D7D0", VA = "0x18142EDD0")]
		public ShopProductItemGacha()
		{
		}
	}
}
