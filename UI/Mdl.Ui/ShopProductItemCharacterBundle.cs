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
	[Cpp2IlInjected.Token(Token = "0x20006E8")]
	public class ShopProductItemCharacterBundle : ShopProductItemDefault
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40026EC")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40026ED")]
		[SerializeField]
		private SpriteAtlasImage _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40026EE")]
		[SerializeField]
		private GameObject _mcOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40026EF")]
		[SerializeField]
		private TextBase _tfOldPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40026F0")]
		[SerializeField]
		private GameObject _mcPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40026F1")]
		[SerializeField]
		private TextBase _tfPurchaseDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40026F2")]
		[SerializeField]
		private ButtonTmPro _btnPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40026F3")]
		[SerializeField]
		private GameObject _mcRewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40026F4")]
		[SerializeField]
		private Transform _mcItemRewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40026F5")]
		[SerializeField]
		private GameObject _mcDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40026F6")]
		[SerializeField]
		private TextBase _tfDiscount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40026F7")]
		public GameObject McBackground;

		[Cpp2IlInjected.Token(Token = "0x6002C31")]
		[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90", Slot = "25")]
		public override void RefreshData(ShopProductModel model)
		{
			base.Model = model;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C32")]
		[Cpp2IlInjected.Address(RVA = "0x142F1D0", Offset = "0x142DBD0", VA = "0x18142F1D0", Slot = "26")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00a7, IL_00e4, IL_00f9, IL_010b, IL_0110, IL_0118, IL_0135, IL_013a, IL_013d, IL_014a, IL_0150, IL_0156, IL_015c, IL_0162, IL_0168, IL_016e, IL_0174, IL_017a
			//IL_0047: Expected I4, but got I8
			//IL_009a: Expected I4, but got I8
			//IL_00dc: Expected I4, but got I8
			//IL_0131: Expected I4, but got I8
			int num = 0;
			ShopProductModel shopProductModel = base.Model;
			if (shopProductModel == null)
			{
				return;
			}
			int num2 = 0;
			if (shopProductModel != null)
			{
				Client client = default(Client);
				DateTime localTime = client.LocalTime;
				if (base.Model == null)
				{
				}
				int num3 = 0;
				SpriteAtlasImage mcImage = _mcImage;
				ulong num4 = default(ulong);
				_mcImage.gameObject.SetActive((byte)num4 != 0);
				TextBase tfTitle = _tfTitle;
				string text = default(string);
				_btnPurchase.Label.Text = text;
				int num5 = 0;
				GameObject mcOldPrice = _mcOldPrice;
				int active = 0;
				mcOldPrice.SetActive((byte)active != 0);
				GameObject mcDiscount = _mcDiscount;
				string text2 = default(string);
				_tfOldPrice.Text = text2;
				ulong num6 = default(ulong);
				_mcOldPrice.SetActive((byte)num6 != 0);
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C33")]
		[Cpp2IlInjected.Address(RVA = "0x142F140", Offset = "0x142DB40", VA = "0x18142F140")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C34")]
		[Cpp2IlInjected.Address(RVA = "0x142EF10", Offset = "0x142D910", VA = "0x18142EF10")]
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

		[Cpp2IlInjected.Token(Token = "0x6002C35")]
		[Cpp2IlInjected.Address(RVA = "0x142EDE0", Offset = "0x142D7E0", VA = "0x18142EDE0")]
		[AsyncStateMachine(typeof(_003CDoFakePurchaseTransaction_003Ed__16))]
		private Task DoFakePurchaseTransaction(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C36")]
		[Cpp2IlInjected.Address(RVA = "0x142EDD0", Offset = "0x142D7D0", VA = "0x18142EDD0")]
		public ShopProductItemCharacterBundle()
		{
		}
	}
}
