using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Avatar;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004B1")]
	public class FTUEAppearencePanel : MonoBehaviour, IStartFTUEPanel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001897")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001898")]
		public RectTransform AnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001899")]
		public BaseButton NextButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400189A")]
		public BaseButton BackButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400189B")]
		[SerializeField]
		private DynamicFilterSelector _mcAvatarCategorySelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400189C")]
		public FacePresetItem facePresetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400189D")]
		public BodyShapePresetItem bodyShapeItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400189E")]
		[SerializeField]
		private RectTransform _mcAvatarCategoryContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400189F")]
		[SerializeField]
		private WardrobeAppearanceContent _mcAvatarItemsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40018A0")]
		[SerializeField]
		private SelectGenderPanel _genderPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40018A1")]
		[SerializeField]
		private WardrobeMakeupContent _mcMakeupPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40018A2")]
		[SerializeField]
		private TextBase _tfItemsTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40018A3")]
		[SerializeField]
		private BaseButton _btnCategories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40018A4")]
		[SerializeField]
		private RectTransform _mcHeader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40018A5")]
		[NotNull]
		[SerializeField]
		private GameObject _mcBackKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40018A6")]
		public AvatarCustomization AvatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40018A7")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40018A8")]
		private ISupportsFocusNavigation _focusedCategoryItem;

		[Cpp2IlInjected.Token(Token = "0x170004F1")]
		public WardrobeAppearanceContent AvatarItemsContent
		{
			[Cpp2IlInjected.Token(Token = "0x6001E79")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _mcAvatarItemsContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA8"), Cpp2IlInjected.Token(Token = "0x40018A9")]
		public bool IsInAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x6001E7A")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEB0", Offset = "0x7D98B0", VA = "0x1807DAEB0", Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001E7B")]
			[Cpp2IlInjected.Address(RVA = "0x7DB480", Offset = "0x7D9E80", VA = "0x1807DB480", Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004F3")]
		public bool IsInCategoryDepth
		{
			[Cpp2IlInjected.Token(Token = "0x6001E7C")]
			[Cpp2IlInjected.Address(RVA = "0x1522970", Offset = "0x1521370", VA = "0x181522970")]
			get
			{
				//Discarded unreachable code: IL_0011
				return _mcAvatarCategoryContent.gameObject.activeSelf;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7D")]
		[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "6")]
		public Transform GetContent()
		{
			RectTransform animatedContent = AnimatedContent;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7E")]
		[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "7")]
		public BaseButton GetBackButton()
		{
			return BackButton;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E7F")]
		[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "8")]
		public BaseButton GetNextButton()
		{
			return NextButton;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E80")]
		[Cpp2IlInjected.Address(RVA = "0x1521AE0", Offset = "0x15204E0", VA = "0x181521AE0")]
		public unsafe void Init(AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_00b3, IL_00c5
			int num = 0;
			IEnumerator enumerator = _mcAvatarCategorySelector.filtersAnchor.GetEnumerator();
			int num4 = default(int);
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				Vector3 zero = Vector3.zero;
				zero += zero;
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				float z = zero.z;
				num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
			}
			int num5 = default(int);
			if (num4 != 0)
			{
				num5 = 0;
			}
			num5 += 72;
			((int*)num5)->m_value = 0;
			num5 += 80;
			((int*)num5)->m_value = 0;
			num5 += 32;
			((int*)num5)->m_value = 0;
			num5 += 24;
			((int*)num5)->m_value = 0;
			num5 += 56;
			((int*)num5)->m_value = 0;
			num5 += 48;
			((int*)num5)->m_value = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E81")]
		[Cpp2IlInjected.Address(RVA = "0x15216E0", Offset = "0x15200E0", VA = "0x1815216E0")]
		public void AnimateIn()
		{
			//Discarded unreachable code: IL_007a, IL_0086
			//IL_0055: Expected F4, but got I4
			int num = 0;
			_mcAvatarCategorySelector.Init();
			IEnumerator enumerator = _mcAvatarCategorySelector.filtersAnchor.GetEnumerator();
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				float z = Vector3.one.z;
				if (enumerator == null)
				{
					z += 4.6E-43f;
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
				uint num4 = default(uint);
				tweenerCore = t.SetDelay((int)num4);
				num++;
			}
			if (tweenerCore != null)
			{
			}
			int num5 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E82")]
		[Cpp2IlInjected.Address(RVA = "0x88E390", Offset = "0x88CD90", VA = "0x18088E390")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0016
			GameObject gameObject = AnimatedContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E83")]
		[Cpp2IlInjected.Address(RVA = "0x1522770", Offset = "0x1521170", VA = "0x181522770")]
		private void Start()
		{
			//IL_0080: Expected O, but got I4
			DynamicFilterSelector mcAvatarCategorySelector = _mcAvatarCategorySelector;
			FilterSelector.FilterSelectedByUser value = SelectAvatarCategory;
			mcAvatarCategorySelector.OnFilterSelectedByUser += value;
			Button.ButtonClickedEvent onClick = _btnCategories.ButtonComponent.m_OnClick;
			UnityAction call = OnCategoryClickedHandler;
			onClick.AddListener(call);
			SelectGenderPanel genderPanel = _genderPanel;
			Action onChangeGender = genderPanel.OnChangeGender;
			Action b = OnGenderChangeHandler;
			Delegate @delegate = Delegate.Combine(onChangeGender, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				genderPanel.OnChangeGender = (Action)num;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E84")]
		[Cpp2IlInjected.Address(RVA = "0x1521F00", Offset = "0x1520900", VA = "0x181521F00")]
		private void OnDestroy()
		{
			DynamicFilterSelector mcAvatarCategorySelector = _mcAvatarCategorySelector;
			FilterSelector.FilterSelectedByUser value = SelectAvatarCategory;
			FilterSelector.FilterSelectedByUser onFilterSelectedByUser = ((FilterSelector)mcAvatarCategorySelector).OnFilterSelectedByUser;
			Delegate @delegate = Delegate.Remove(onFilterSelectedByUser, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onFilterSelectedByUser)
				{
				}
				Button.ButtonClickedEvent onClick = _btnCategories.ButtonComponent.m_OnClick;
				UnityAction call = OnCategoryClickedHandler;
				onClick.RemoveListener(call);
				SelectGenderPanel genderPanel = _genderPanel;
				Action onChangeGender = genderPanel.OnChangeGender;
				Action value2 = OnGenderChangeHandler;
				Delegate delegate2 = Delegate.Remove(onChangeGender, value2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					genderPanel.OnChangeGender = (Action)delegate2;
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E85")]
		[Cpp2IlInjected.Address(RVA = "0x1522570", Offset = "0x1520F70", VA = "0x181522570", Slot = "10")]
		public void Show()
		{
			RectTransform animatedContent = AnimatedContent;
			IsInAnimation = true;
			float z = Vector3.zero.z;
			AnimatedContent.gameObject.SetActive(value: true);
			_mcBackKey.SetActive(value: true);
			_genderPanel.RefreshToggles();
			Transform transform = AnimatedContent.transform;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack).SetDelay(0.3f);
			TweenCallback tweenCallback = delegate
			{
				AnimateIn();
				IsInAnimation = false;
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E86")]
		[Cpp2IlInjected.Address(RVA = "0x1521990", Offset = "0x1520390", VA = "0x181521990", Slot = "11")]
		public void Hide()
		{
			GameObject mcBackKey = _mcBackKey;
			IsInAnimation = true;
			int active = 0;
			mcBackKey.SetActive((byte)active != 0);
			RectTransform animatedContent = AnimatedContent;
			float z = Vector3.zero.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.InExpo);
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_001d
				GameObject gameObject = AnimatedContent.gameObject;
				int active2 = 0;
				gameObject.SetActive((byte)active2 != 0);
				IsInAnimation = false;
			};
			Delegate @delegate = Delegate.Combine(tweenCallback, tweenCallback);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E87")]
		[Cpp2IlInjected.Address(RVA = "0x1521E00", Offset = "0x1520800", VA = "0x181521E00")]
		public void OnCategoryClickedHandler()
		{
			//Discarded unreachable code: IL_0074
			((List<T>)(object)_mcAvatarCategorySelector.selectedFilters).Clear();
			_mcMakeupPanel.Hide();
			_mcAvatarCategoryContent.gameObject.SetActive(value: true);
			GameObject gameObject = _mcHeader.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_mcAvatarItemsContent.Hide();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNavigation = _focusNavigation;
				SetFocus(focusNavigation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E88")]
		[Cpp2IlInjected.Address(RVA = "0x15221B0", Offset = "0x1520BB0", VA = "0x1815221B0")]
		private void SelectAvatarCategory()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001E89")]
		[Cpp2IlInjected.Address(RVA = "0x1522110", Offset = "0x1520B10", VA = "0x181522110")]
		private void OnGenderChangeHandler()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001E8A")]
		[Cpp2IlInjected.Address(RVA = "0x1522480", Offset = "0x1520E80", VA = "0x181522480", Slot = "9")]
		public void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_0060
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			if (!_mcAvatarItemsContent.gameObject.activeSelf)
			{
				if (_mcAvatarCategorySelector.filtersAnchor.childCount > 0 && _focusedCategoryItem == null)
				{
					DynamicFilterSelector mcAvatarCategorySelector = _mcAvatarCategorySelector;
					FocusNavigation focusNavigation2 = _focusNavigation;
					mcAvatarCategorySelector.SetFocus(focusNavigation2);
				}
			}
			else
			{
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E8B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FTUEAppearencePanel()
		{
		}
	}
}
