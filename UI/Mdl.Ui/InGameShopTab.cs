using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Mdl.Systems;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005B5")]
	public class InGameShopTab : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20005B6")]
		public delegate void SelectedTab(InGameShopTab tab);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FA2")]
		[SerializeField]
		private InGameShopMenu.InGameShopTabType _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FA3")]
		[SerializeField]
		private BaseButton _btnToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001FA4")]
		[SerializeField]
		internal TextBase title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001FA5")]
		[SerializeField]
		private Image _backgroundSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001FA6")]
		[SerializeField]
		private Image _backgroundSelectedHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001FA7")]
		[SerializeField]
		private Image _backgroundHighlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001FA8")]
		[SerializeField]
		private Image _pointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001FA9")]
		[SerializeField]
		private RedDot _redDot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001FAA")]
		private int _highlightedTextColor = 3885165;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001FAB")]
		private int _unhighlightedTextColor = 15264506;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001FAC")]
		public Action OnClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001FAD")]
		public UnityEvent OnGamepadClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001FAF")]
		private bool _highlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4001FB0")]
		private bool _selected;

		[Cpp2IlInjected.Token(Token = "0x170005CA")]
		public InGameShopMenu.InGameShopTabType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6002561")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return _type;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005CB")]
		public bool Selected
		{
			[Cpp2IlInjected.Token(Token = "0x6002564")]
			[Cpp2IlInjected.Address(RVA = "0xAE85F0", Offset = "0xAE6FF0", VA = "0x180AE85F0")]
			get
			{
				return _selected;
			}
			[Cpp2IlInjected.Token(Token = "0x6002565")]
			[Cpp2IlInjected.Address(RVA = "0xD20A90", Offset = "0xD1F490", VA = "0x180D20A90")]
			set
			{
				_selected = value;
				RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000045")]
		public event SelectedTab OnSelectedTab
		{
			[Cpp2IlInjected.Token(Token = "0x6002562")]
			[Cpp2IlInjected.Address(RVA = "0xD20950", Offset = "0xD1F350", VA = "0x180D20950")]
			[CompilerGenerated]
			add
			{
				SelectedTab onSelectedTab = this.OnSelectedTab;
				Delegate @delegate = Delegate.Combine(onSelectedTab, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSelectedTab)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002563")]
			[Cpp2IlInjected.Address(RVA = "0xD209F0", Offset = "0xD1F3F0", VA = "0x180D209F0")]
			[CompilerGenerated]
			remove
			{
				SelectedTab onSelectedTab = this.OnSelectedTab;
				Delegate @delegate = Delegate.Remove(onSelectedTab, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSelectedTab)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002566")]
		[Cpp2IlInjected.Address(RVA = "0xD20160", Offset = "0xD1EB60", VA = "0x180D20160")]
		private void Start()
		{
			//Discarded unreachable code: IL_0047
			Button.ButtonClickedEvent onClick = _btnToggle.ButtonComponent.m_OnClick;
			UnityAction call = OnClick;
			onClick.AddListener(call);
			if (_type <= InGameShopMenu.InGameShopTabType.GameUpgrades)
			{
				int num = 0;
				Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			}
			title.StringID = "";
		}

		[Cpp2IlInjected.Token(Token = "0x6002567")]
		[Cpp2IlInjected.Address(RVA = "0xD1FF50", Offset = "0xD1E950", VA = "0x180D1FF50")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnToggle.ButtonComponent.m_OnClick;
			UnityAction call = OnClick;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002568")]
		[Cpp2IlInjected.Address(RVA = "0xD1FEC0", Offset = "0xD1E8C0", VA = "0x180D1FEC0")]
		public void OnClick()
		{
			//Discarded unreachable code: IL_0051, IL_0067
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				OnClicked?.Invoke();
				if (!_selected)
				{
					SelectedTab onSelectedTab = this.OnSelectedTab;
					_selected = true;
					onSelectedTab?.Invoke(this);
				}
				RefreshDisplay();
			}
			else
			{
				UnityEvent onGamepadClicked = OnGamepadClicked;
				while (onGamepadClicked == null)
				{
				}
				onGamepadClicked.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002569")]
		[Cpp2IlInjected.Address(RVA = "0xD1FE70", Offset = "0xD1E870", VA = "0x180D1FE70")]
		public void ClickAction()
		{
			OnClicked?.Invoke();
			if (!_selected)
			{
				SelectedTab onSelectedTab = this.OnSelectedTab;
				_selected = true;
				onSelectedTab?.Invoke(this);
			}
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x600256A")]
		[Cpp2IlInjected.Address(RVA = "0xD203A0", Offset = "0xD1EDA0", VA = "0x180D203A0")]
		public void UpdateRedDotState(List<OnlineStoreData> stores, bool forceRemove = false)
		{
			//IL_009f: Expected I4, but got I8
			//IL_00c1: Expected I4, but got I8
			if (!forceRemove && _type != 0)
			{
				OnlineClient onlineClient = default(OnlineClient);
				List<BattlePassSeasonData> battlePasses = (List<BattlePassSeasonData>)(object)onlineClient.GetBattlePasses();
				Func<BattlePassSeasonData, bool> _003C_003E9__27_ = _003C_003Ec._003C_003E9__27_0;
				if (_003C_003E9__27_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(BattlePassSeasonData x)
					{
						//Discarded unreachable code: IL_0029
						DateTime dateTime = x.finishDate_.date_.ToDateTime();
						DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
						return dateTime > serverTime;
					};
				}
				List<BattlePassSeasonData> list = (List<BattlePassSeasonData>)(object)Enumerable.ToList<BattlePassSeasonData>(Enumerable.Where<BattlePassSeasonData>((IEnumerable<>)battlePasses, (Func<, >)(object)_003C_003E9__27_));
				if (_type != InGameShopMenu.InGameShopTabType.BattlePass)
				{
					if (stores != null)
					{
						List<InGameShopContent.ContentsPerStore> list2 = (List<InGameShopContent.ContentsPerStore>)(object)new List<T>();
						InGameShopMenu.InGameShopTabType type = _type;
						int num = 0;
						int num2 = 0;
						int num3 = 0;
						List<InGameShopContent.ContentsPerStore> storeTabContents = (List<InGameShopContent.ContentsPerStore>)(object)InGameShopContent.GetStoreTabContents((List<>)(object)stores, type, (byte)num3 != 0, (byte)num2 != 0);
						((List<T>)(object)list2).AddRange((IEnumerable<>)storeTabContents);
						if (_type == InGameShopMenu.InGameShopTabType.TimeLimited)
						{
							int num4 = 0;
							ulong num5 = default(ulong);
							List<InGameShopContent.ContentsPerStore> storeTabContents2 = (List<InGameShopContent.ContentsPerStore>)(object)InGameShopContent.GetStoreTabContents((List<>)(object)stores, InGameShopMenu.InGameShopTabType.TimeLimited, (byte)num5 != 0, (byte)num4 != 0);
							((List<T>)(object)list2).AddRange((IEnumerable<>)storeTabContents2);
							InGameShopMenu.InGameShopTabType type2 = _type;
							int num6 = 0;
							ulong num7 = default(ulong);
							List<InGameShopContent.ContentsPerStore> storeTabContents3 = (List<InGameShopContent.ContentsPerStore>)(object)InGameShopContent.GetStoreTabContents((List<>)(object)stores, type2, (byte)num6 != 0, (byte)num7 != 0);
							((List<T>)(object)list2).AddRange((IEnumerable<>)storeTabContents3);
						}
						GameObject gameObject = _redDot.gameObject;
						Func<InGameShopContent.ContentsPerStore, bool> cpp2il__autoParamName__idx_ = default(Func<InGameShopContent.ContentsPerStore, bool>);
						if (_003C_003Ec._003C_003E9__27_2 == null)
						{
							cpp2il__autoParamName__idx_ = (Func<InGameShopContent.ContentsPerStore, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								//Discarded unreachable code: IL_000f
								int num9 = 0;
								RedDotHelper redDotHelper2 = UiRoot.Instance.RedDotHelper;
								bool result = default(bool);
								return result;
							});
						}
						bool active = ((IEnumerable<>)list2).Any<InGameShopContent.ContentsPerStore>((Func<, >)(object)cpp2il__autoParamName__idx_);
						gameObject.SetActive(active);
						return;
					}
				}
				else
				{
					if (_003C_003Ec._003C_003E9__27_1 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Comparison<T>)delegate(BattlePassSeasonData x, BattlePassSeasonData y)
						{
							//Discarded unreachable code: IL_002a
							DateTime t = y.startDate_.date_.ToDateTime();
							DateTime t2 = x.startDate_.date_.ToDateTime();
							return DateTime.Compare(t, t2);
						};
					}
					int num8 = 0;
					RedDotHelper redDotHelper = UiRoot.Instance.RedDotHelper;
					BattlePassSeasonData battlePassSeasonData = default(BattlePassSeasonData);
					string onlineId_ = battlePassSeasonData.onlineId_;
					bool flag = redDotHelper.IsNewBattlePass(onlineId_);
				}
			}
			GameObject gameObject2 = _redDot.gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600256B")]
		[Cpp2IlInjected.Address(RVA = "0xD20000", Offset = "0xD1EA00", VA = "0x180D20000")]
		public void OnHighlightAdded()
		{
			//Discarded unreachable code: IL_005e
			_highlighted = true;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				OnClicked?.Invoke();
				if (!_selected)
				{
					SelectedTab onSelectedTab = this.OnSelectedTab;
					_selected = true;
					onSelectedTab?.Invoke(this);
				}
				RefreshDisplay();
			}
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x600256C")]
		[Cpp2IlInjected.Address(RVA = "0xD20080", Offset = "0xD1EA80", VA = "0x180D20080")]
		public void OnHighlightRemoved()
		{
			_highlighted = false;
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x600256D")]
		[Cpp2IlInjected.Address(RVA = "0xD20090", Offset = "0xD1EA90", VA = "0x180D20090")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0094
			GameObject gameObject2;
			do
			{
				GameObject gameObject = _backgroundHighlight.gameObject;
				int num = 0;
				if ((_highlighted ? 1 : 0) == num)
				{
				}
				bool active = (_selected ? 1 : 0) == num;
				gameObject.SetActive(active);
				gameObject2 = _backgroundSelectedHighlight.gameObject;
			}
			while (!_highlighted);
			bool active2 = _selected;
			gameObject2.SetActive(active2);
			GameObject gameObject3 = _backgroundSelected.gameObject;
			bool selected = _selected;
			gameObject3.SetActive(selected);
			TextBase textBase = title;
			if (_highlighted)
			{
			}
			int unhighlightedTextColor = _unhighlightedTextColor;
			textBase.SetColorRGB(unhighlightedTextColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600256E")]
		[Cpp2IlInjected.Address(RVA = "0xD20930", Offset = "0xD1F330", VA = "0x180D20930")]
		public InGameShopTab()
		{
		}//IL_000d: Expected I4, but got I8
		//IL_001a: Expected I4, but got I8

	}
}
