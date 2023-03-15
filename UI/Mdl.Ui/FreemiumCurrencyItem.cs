using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	public class FreemiumCurrencyItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public bool ShowAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private Item? _currencyItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private int _amount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private int _displayAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		[SerializeField]
		private AsyncAtlassedIcon mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		[SerializeField]
		private TextBase tf_amount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		[SerializeField]
		private ButtonWithHold btn_add;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		[SerializeField]
		private ButtonWithHold btn_minus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		[SerializeField]
		[Header("Delay to fit vfx")]
		private float _longDelay = 0.85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		[SerializeField]
		private float _shortDelay = 0.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		[SerializeField]
		private float _substractDelay = 0.15f;

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		internal AsyncAtlassedIcon CurrencyIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return mc_icon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		public Item CurrencyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0x166CFE0", Offset = "0x166B9E0", VA = "0x18166CFE0")]
			get
			{
				Item result = default(Item);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		public int Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A75")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return _amount;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A76")]
			[Cpp2IlInjected.Address(RVA = "0x166D030", Offset = "0x166BA30", VA = "0x18166D030")]
			set
			{
				_amount = value;
				_displayAmount = value;
				RefreshLabel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		public int DisplayAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return _displayAmount;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A78")]
			[Cpp2IlInjected.Address(RVA = "0x166D0C0", Offset = "0x166BAC0", VA = "0x18166D0C0")]
			set
			{
				_displayAmount = value;
				RefreshLabel();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public int AnimatedAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6000A79")]
			[Cpp2IlInjected.Address(RVA = "0x166D040", Offset = "0x166BA40", VA = "0x18166D040")]
			set
			{
				//Discarded unreachable code: IL_0020
				_amount = value;
				int _003C_003E1__state = default(int);
				_003CExecuteAnimation_003Ed__33 _003CExecuteAnimation_003Ed__ = new _003CExecuteAnimation_003Ed__33(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CExecuteAnimation_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = StartCoroutine(_003CExecuteAnimation_003Ed__);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		private bool IsAnimating
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0x166D020", Offset = "0x166BA20", VA = "0x18166D020")]
			get
			{
				int amount = _amount;
				return _displayAmount != amount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x166CF60", Offset = "0x166B960", VA = "0x18166CF60")]
		private void Start()
		{
			//Discarded unreachable code: IL_002b
			GameObject gameObject = btn_add.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = btn_minus.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x166C9D0", Offset = "0x166B3D0", VA = "0x18166C9D0")]
		private void OnDestroy()
		{
			TweenMax.KillAllByCancelationToken(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x166CA30", Offset = "0x166B430", VA = "0x18166CA30")]
		public unsafe void RefreshData(KeyValuePair<Item, int> currencyData, bool animated = false)
		{
			//Discarded unreachable code: IL_007d
			//IL_0010: Expected O, but got I4
			int num = 0;
			Item key = (Item)((KeyValuePair<, >*)(&currencyData))->key;
			_currencyItem = (Item?)(object)num;
			int amount = _amount;
			_amount = 0;
			if (1 == 0)
			{
				_displayAmount = 0;
				RefreshLabel();
			}
			int _003C_003E1__state = default(int);
			_003CExecuteAnimation_003Ed__33 _003CExecuteAnimation_003Ed__ = new _003CExecuteAnimation_003Ed__33(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CExecuteAnimation_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CExecuteAnimation_003Ed__);
			Item? currencyItem = _currencyItem;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			if (itemData != null)
			{
			}
			bool flag = mc_icon.SetIcon("Assets/UI/Images/HUD/softCurrency_icon.png");
			base.transform.RebuildLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x166CE20", Offset = "0x166B820", VA = "0x18166CE20")]
		private void RefreshLabel()
		{
			//Discarded unreachable code: IL_0029
			TextBase textBase = tf_amount;
			if (ShowAll)
			{
				CultureInfo _003CCultureInfo_003Ek__BackingField = SystemRoot.Instance._localizationManager.CultureInfo;
			}
			string text = default(string);
			textBase.Text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0x166CCA0", Offset = "0x166B6A0", VA = "0x18166CCA0")]
		private void RefreshIcon()
		{
			//Discarded unreachable code: IL_0036
			//IL_001a: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			Item? currencyItem = _currencyItem;
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			if (itemData != null)
			{
			}
			bool flag = string.IsNullOrEmpty((string)num);
			bool flag2 = mc_icon.SetIcon((string)num);
			base.transform.RebuildLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A80")]
		[Cpp2IlInjected.Address(RVA = "0x166C810", Offset = "0x166B210", VA = "0x18166C810")]
		private string DebugGetCurrencyIconPath(Item? currencyItem)
		{
			//IL_0012: Expected O, but got I4
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			if (itemData != null)
			{
			}
			bool flag = string.IsNullOrEmpty((string)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnAddBtnClicked()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnMinusBtnClicked()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x166C960", Offset = "0x166B360", VA = "0x18166C960")]
		[IteratorStateMachine(typeof(_003CExecuteAnimation_003Ed__33))]
		private IEnumerator ExecuteAnimation()
		{
			int _003C_003E1__state = default(int);
			_003CExecuteAnimation_003Ed__33 _003CExecuteAnimation_003Ed__ = new _003CExecuteAnimation_003Ed__33(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CExecuteAnimation_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x166CFC0", Offset = "0x166B9C0", VA = "0x18166CFC0")]
		public FreemiumCurrencyItem()
		{
		}
	}
}
