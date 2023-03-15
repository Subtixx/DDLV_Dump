using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Meta;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000490")]
	public class EventRewardItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000491")]
		public delegate void Selected(EventRewardItem tab);

		[Cpp2IlInjected.Token(Token = "0x2000492")]
		public delegate void GamepadClicked(EventRewardItem tab);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400177C")]
		[SerializeField]
		private BaseButton _btn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400177D")]
		[SerializeField]
		private RectTransform _animatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400177E")]
		[SerializeField]
		private RectTransform _unlockedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400177F")]
		[SerializeField]
		private RectTransform _rewardInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001780")]
		[SerializeField]
		private RectTransform _bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001781")]
		[SerializeField]
		private RectTransform _collectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001782")]
		[SerializeField]
		private RectTransform _highlightedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001783")]
		[SerializeField]
		private RectTransform _selectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001784")]
		[SerializeField]
		private RectTransform _selectedHighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001785")]
		[SerializeField]
		private SpriteAtlasImage _lockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001786")]
		[SerializeField]
		private SpriteAtlasImage _collectedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001787")]
		[SerializeField]
		private RectTransform _deco;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001788")]
		[SerializeField]
		private AsyncAtlassedIcon _itemIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001789")]
		[SerializeField]
		private TextBase _labelPremium;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400178A")]
		[SerializeField]
		private TextBase _labelCollected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400178B")]
		[SerializeField]
		private RectTransform _mcPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400178C")]
		[SerializeField]
		private RectTransform _mcCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400178D")]
		[SerializeField]
		private TextBase _tfPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400178E")]
		[SerializeField]
		private TextBase _tfCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400178F")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001790")]
		[SerializeField]
		private float _topCurrencyIconModifier = 35f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4001791")]
		[SerializeField]
		private float _bottomCurrencyIconModifier = 85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001792")]
		[SerializeField]
		private float _leftCurrencyIconModifier = 55f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4001793")]
		[SerializeField]
		private float _rightCurrencyIconModifier = 55f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4001797")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
		[Cpp2IlInjected.Token(Token = "0x4001798")]
		private bool _isHighlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001799")]
		private float _oY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400179A")]
		public bool IsLockedByPremium;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
		[Cpp2IlInjected.Token(Token = "0x400179B")]
		public bool IsLockedByPage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE6")]
		[Cpp2IlInjected.Token(Token = "0x400179C")]
		public bool IsCollectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE7")]
		[Cpp2IlInjected.Token(Token = "0x400179D")]
		private bool _isCollected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400179E")]
		public bool IsPremium;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400179F")]
		public int Price;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40017A0")]
		public int Amount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40017A1")]
		public IItemData ItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40017A2")]
		public BattlePassReward RewardData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40017A3")]
		private BattlePassUIGameColors _colorConfig;

		[Cpp2IlInjected.Token(Token = "0x170004D9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xD8"), Cpp2IlInjected.Token(Token = "0x4001796")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA7")]
			[Cpp2IlInjected.Address(RVA = "0x1406560", Offset = "0x1404F60", VA = "0x181406560")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001DA8")]
			[Cpp2IlInjected.Address(RVA = "0x14066E0", Offset = "0x14050E0", VA = "0x1814066E0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004DA")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA9")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC60", Offset = "0x7D9660", VA = "0x1807DAC60")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6001DAA")]
			[Cpp2IlInjected.Address(RVA = "0x1406700", Offset = "0x1405100", VA = "0x181406700")]
			set
			{
				_isSelected = value;
				RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DB")]
		public bool IsLocked
		{
			[Cpp2IlInjected.Token(Token = "0x6001DAB")]
			[Cpp2IlInjected.Address(RVA = "0x1406580", Offset = "0x1404F80", VA = "0x181406580")]
			get
			{
				if (!IsLockedByPremium)
				{
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DC")]
		public bool IsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001DAC")]
			[Cpp2IlInjected.Address(RVA = "0x1406570", Offset = "0x1404F70", VA = "0x181406570")]
			get
			{
				return _isCollected;
			}
			[Cpp2IlInjected.Token(Token = "0x6001DAD")]
			[Cpp2IlInjected.Address(RVA = "0x14066F0", Offset = "0x14050F0", VA = "0x1814066F0")]
			set
			{
				_isCollected = value;
				RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000038")]
		public event Selected OnSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA3")]
			[Cpp2IlInjected.Address(RVA = "0x14064C0", Offset = "0x1404EC0", VA = "0x1814064C0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001DA4")]
			[Cpp2IlInjected.Address(RVA = "0x1406640", Offset = "0x1405040", VA = "0x181406640")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000039")]
		public event GamepadClicked OnGamepadClicked
		{
			[Cpp2IlInjected.Token(Token = "0x6001DA5")]
			[Cpp2IlInjected.Address(RVA = "0x1406420", Offset = "0x1404E20", VA = "0x181406420")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001DA6")]
			[Cpp2IlInjected.Address(RVA = "0x14065A0", Offset = "0x1404FA0", VA = "0x1814065A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DAE")]
		[Cpp2IlInjected.Address(RVA = "0x14062E0", Offset = "0x1404CE0", VA = "0x1814062E0")]
		private void Start()
		{
			//Discarded unreachable code: IL_005d
			//IL_0010: Expected O, but got I4
			RectTransform animatedContent = _animatedContent;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = _animatedContent;
				Vector3 vector = default(Vector3);
				float num2 = (_oY = vector.y);
			}
			BaseButton btn = _btn;
			if ((object)btn != null)
			{
				Button.ButtonClickedEvent onClick = btn.ButtonComponent.m_OnClick;
				UnityAction call = OnClicked;
				onClick.AddListener(call);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DAF")]
		[Cpp2IlInjected.Address(RVA = "0x1405800", Offset = "0x1404200", VA = "0x181405800")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_002c
			BaseButton btn = _btn;
			if ((object)btn != null)
			{
				Button.ButtonClickedEvent onClick = btn.ButtonComponent.m_OnClick;
				UnityAction call = OnClicked;
				onClick.RemoveListener(call);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB0")]
		[Cpp2IlInjected.Address(RVA = "0x1405740", Offset = "0x1404140", VA = "0x181405740")]
		private void OnClicked()
		{
			//Discarded unreachable code: IL_007a
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num2 = 0;
				if (UiRoot.Instance.IsLastInputFromJoystick)
				{
					this.OnGamepadClicked?.Invoke(this);
					return;
				}
			}
			while (_isSelected)
			{
			}
			_btn?.PostWwiseEvent();
			_isSelected = true;
			RefreshDisplay();
			Selected onSelected = this.OnSelected;
			while (onSelected == null)
			{
			}
			onSelected(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB1")]
		[Cpp2IlInjected.Address(RVA = "0x1404F10", Offset = "0x1403910", VA = "0x181404F10")]
		internal void Click()
		{
			if (!_isSelected)
			{
				_btn?.PostWwiseEvent();
				_isSelected = true;
				RefreshDisplay();
				this.OnSelected?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB2")]
		[Cpp2IlInjected.Address(RVA = "0x14058B0", Offset = "0x14042B0", VA = "0x1814058B0")]
		public void OnHighlightAdded()
		{
			//Discarded unreachable code: IL_00b1
			//IL_0017: Expected O, but got I4
			RectTransform animatedContent = _animatedContent;
			_isHighlighted = true;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = _animatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oY = _oY;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)_animatedContent, oY, 0.2f, (byte)num3 != 0)).Play();
			}
			RefreshDisplay();
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !_isSelected)
			{
				_btn?.PostWwiseEvent();
				_isSelected = true;
				RefreshDisplay();
				this.OnSelected?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB3")]
		[Cpp2IlInjected.Address(RVA = "0x1405A10", Offset = "0x1404410", VA = "0x181405A10")]
		public void OnHighlightRemoved()
		{
			//IL_0017: Expected O, but got I4
			//IL_004f: Expected F4, but got I4
			RectTransform animatedContent = _animatedContent;
			_isHighlighted = false;
			int num = 0;
			if (animatedContent != (UnityEngine.Object)num)
			{
				RectTransform animatedContent2 = _animatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oY = _oY;
				int num3 = 0;
				RectTransform animatedContent3 = _animatedContent;
				int num4 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY((Transform)animatedContent3, oY, (float)num4, (byte)num3 != 0)).Play();
			}
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB4")]
		[Cpp2IlInjected.Address(RVA = "0x1404F70", Offset = "0x1403970", VA = "0x181404F70")]
		public void Init(int index, BattlePassReward rewardData, BattlePassUIGameColors colorConfig, bool isPremium = false, bool isLockedByPremium = false, bool isLockedByPage = false, bool isCollected = false, bool isCollectable = true, int price = -1)
		{
			//Discarded unreachable code: IL_01dd
			//IL_00c5: Expected O, but got I4
			//IL_0157: Expected O, but got I4
			int num = 0;
			Index = index;
			RewardData = rewardData;
			_colorConfig = colorConfig;
			IsPremium = false;
			IsLockedByPage = false;
			IsLockedByPremium = false;
			IsCollectable = false;
			_isCollected = false;
			Price = 0;
			if (rewardData != null)
			{
			}
			Amount = -1;
			TextBase tfPrice = _tfPrice;
			int num2 = 0;
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string text = default(string);
			tfPrice.Text = text;
			TextBase tfCount = _tfCount;
			int num3 = 0;
			CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
			string text2 = default(string);
			string text4 = (tfCount.Text = "x" + text2);
			_itemIcon.Dispose();
			_tfName.Text = "";
			AsyncAtlassedIcon itemIcon3 = default(AsyncAtlassedIcon);
			if (rewardData != null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				bool flag = default(bool);
				if (flag)
				{
					ItemData = (IItemData)num;
					TextBase tfName = _tfName;
					ItemType itemType = default(ItemType);
					if (itemType != ItemType.Decal)
					{
						AsyncAtlassedIcon itemIcon = _itemIcon;
						Color white = Color.white;
					}
					AsyncAtlassedIcon itemIcon2 = _itemIcon;
					DecalItemData decalItemData = default(DecalItemData);
					if ((decalItemData.allowColoring_ ? 1 : 0) == num)
					{
						Color white2 = Color.white;
					}
					Transform transform = _itemIcon.transform;
					if ((object)transform != null)
					{
					}
					ItemType itemType2 = default(ItemType);
					if (itemType2 != ItemType.Currency || (object)transform != null)
					{
					}
					int num4 = 0;
					Transform transform2 = _itemIcon.transform;
					if ((object)transform2 != null)
					{
					}
					ItemType itemType3 = default(ItemType);
					if (itemType3 != ItemType.Currency || (object)transform2 != null)
					{
					}
					AspectRatioFitter component = _itemIcon.gameObject.GetComponent<AspectRatioFitter>();
					int num5 = 0;
					int num6 = 0;
					if (component != (UnityEngine.Object)num6 && _itemIcon.gameObject.GetComponent<AspectRatioFitter>().m_AspectMode == AspectRatioFitter.AspectMode.WidthControlsHeight)
					{
						Transform transform3 = _itemIcon.transform;
						if ((object)transform3 != null)
						{
						}
						ItemType itemType4 = default(ItemType);
						if (itemType4 != ItemType.Currency || (object)transform3 != null)
						{
						}
						int num7 = 0;
						Transform transform4 = _itemIcon.transform;
						if ((object)transform4 != null)
						{
						}
						ItemType itemType5 = default(ItemType);
						if (itemType5 == ItemType.Currency && (object)transform4 == null)
						{
						}
					}
					itemIcon3 = _itemIcon;
					Client client = default(Client);
					ProfilePlayer player_ = client.profile.player_;
					string icon = default(string);
					bool flag2 = itemIcon3.SetIcon(icon);
				}
			}
			ItemData = (IItemData)itemIcon3;
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB5")]
		[Cpp2IlInjected.Address(RVA = "0x1405B00", Offset = "0x1404500", VA = "0x181405B00")]
		private void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0330
			//IL_0037: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_0238: Expected O, but got I4
			int num;
			bool flag = default(bool);
			GameObject gameObject3;
			do
			{
				BattlePassReward rewardData = RewardData;
				num = 0;
				if (rewardData != null)
				{
					if ((_isCollected ? 1 : 0) == num)
					{
					}
					flag = (rewardData.isRecurrent_ ? 1 : 0) == num;
				}
				CanvasGroup component = _unlockedContent.GetComponent<CanvasGroup>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					CanvasGroup component2 = _unlockedContent.GetComponent<CanvasGroup>();
					if ((IsLockedByPremium ? 1 : 0) != num || (IsLockedByPage ? 1 : 0) == num)
					{
					}
					component2.alpha = 0.4f;
				}
				CanvasGroup component3 = _rewardInfo.GetComponent<CanvasGroup>();
				int num3 = 0;
				if (component3 != (UnityEngine.Object)num3)
				{
					CanvasGroup component4 = _rewardInfo.GetComponent<CanvasGroup>();
					if ((IsCollectable ? 1 : 0) == num)
					{
					}
					component4.alpha = 0.6f;
				}
				GameObject gameObject = _highlightedBg.gameObject;
				bool isHighlighted = _isHighlighted;
				gameObject.SetActive(isHighlighted);
				GameObject gameObject2 = _selectedBg.gameObject;
				bool isSelected = _isSelected;
				gameObject2.SetActive(isSelected);
				gameObject3 = _selectedHighlightBg.gameObject;
			}
			while ((_isSelected ? 1 : 0) == num);
			bool active = _isHighlighted;
			gameObject3.SetActive(active);
			GameObject gameObject4 = _deco.gameObject;
			bool isHighlighted2 = _isHighlighted;
			gameObject4.SetActive(isHighlighted2);
			_collectedBg.gameObject.SetActive(flag);
			_labelCollected.gameObject.SetActive(flag);
			_collectedIcon.gameObject.SetActive(flag);
			GameObject gameObject5 = _lockedIcon.gameObject;
			bool isLockedByPage = default(bool);
			if ((IsLockedByPremium ? 1 : 0) == num)
			{
				isLockedByPage = IsLockedByPage;
			}
			gameObject5.SetActive(isLockedByPage);
			GameObject gameObject6 = _labelPremium.gameObject;
			if ((IsLockedByPremium ? 1 : 0) == num || (IsPremium ? 1 : 0) != num)
			{
			}
			int active2 = 0;
			gameObject6.SetActive((byte)active2 != 0);
			GameObject gameObject7 = _mcPrice.gameObject;
			if (flag || (IsLockedByPremium ? 1 : 0) == num || (IsPremium ? 1 : 0) == num)
			{
			}
			gameObject7.SetActive((byte)num != 0);
			_mcPrice.RebuildLayout();
			_mcPrice.parent.RebuildLayout();
			GameObject gameObject8 = _mcCount.gameObject;
			if (ItemData == null)
			{
			}
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Currency)
			{
			}
			int amount = Amount;
			gameObject8.SetActive((byte)amount != 0);
			BattlePassUIGameColors colorConfig = _colorConfig;
			int num4 = 0;
			if (!(colorConfig != (UnityEngine.Object)num4))
			{
				return;
			}
			TextMeshProUGUI textComponent = _labelPremium.TextComponent;
			if ((_isHighlighted ? 1 : 0) == num && (_isSelected ? 1 : 0) == num)
			{
				BattlePassUIGameColors colorConfig2 = _colorConfig;
				if ((IsLockedByPremium ? 1 : 0) == num)
				{
					bool isLockedByPage2 = IsLockedByPage;
				}
			}
			int num5 = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
			Image image = _collectedIcon.Image;
			TextMeshProUGUI textComponent2 = _labelCollected.TextComponent;
			if (!_isHighlighted && !_isSelected)
			{
				int num6 = 0;
				UIGameColors gameColors2 = UiRoot.Instance._gameColors;
			}
			int num7 = 0;
			UIGameColors gameColors3 = UiRoot.Instance._gameColors;
			TextMeshProUGUI textComponent3 = _tfName.TextComponent;
			BattlePassUIGameColors colorConfig3 = _colorConfig;
			TextMeshProUGUI textComponent4 = _tfPrice.TextComponent;
			if (_isHighlighted)
			{
				int num8 = 0;
				UIGameColors gameColors4 = UiRoot.Instance._gameColors;
			}
			BattlePassUIGameColors colorConfig4 = _colorConfig;
			if (_isSelected)
			{
			}
			TextMeshProUGUI textComponent5 = _tfCount.TextComponent;
			BattlePassUIGameColors colorConfig5 = _colorConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DB6")]
		[Cpp2IlInjected.Address(RVA = "0x14063F0", Offset = "0x1404DF0", VA = "0x1814063F0")]
		public EventRewardItem()
		{
		}
	}
}
