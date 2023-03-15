using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Meta.Customization;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200075A")]
	public class MakeupColor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AFD")]
		[SerializeField]
		private TextBase _colorTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AFE")]
		[SerializeField]
		private string _colorStringID = "menu.wardrobe_filter_dominantcolor";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002AFF")]
		[SerializeField]
		private FocusNavigationElement _colorMainFocusAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B00")]
		[SerializeField]
		private FocusNavigationElement _colorSecondaryFocusAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B01")]
		[SerializeField]
		private FocusNavigationElement _colorThirdFocusAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B02")]
		[SerializeField]
		private TextBase _opacityTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002B03")]
		[SerializeField]
		private string _opacityStringID = "menu.Opacity";

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002B04")]
		[SerializeField]
		private GameObject _OpacityGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002B05")]
		[SerializeField]
		private ToggleGroupMakeupColor _toggleMakeupColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002B06")]
		public Slider Slider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002B07")]
		[SerializeField]
		private float _sliderFailSafeDelay = 0.02f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002B08")]
		[SerializeField]
		private FocusNavigationElement _sliderAnchorNavElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002B09")]
		[SerializeField]
		private TextBase _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002B0A")]
		[HideInInspector]
		public MakeupItemType MakeupType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002B0B")]
		[HideInInspector]
		public List<MakeupItem> makeupItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002B0C")]
		[HideInInspector]
		public int MakeupColorMain = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4002B0D")]
		[HideInInspector]
		public int MakeupColorSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002B0E")]
		[HideInInspector]
		public int MakeupColorThird = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4002B0F")]
		[HideInInspector]
		public float MakeupOpacity = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002B10")]
		[HideInInspector]
		public bool IsInitSlider = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x4002B11")]
		[HideInInspector]
		public bool UseFullOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002B12")]
		private WardrobeSubFilterItemList _subFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002B13")]
		private WardrobeAppearanceContent _appearanceContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002B14")]
		private Coroutine _sliderCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002B15")]
		private Coroutine _waitNextFrame;

		[Cpp2IlInjected.Token(Token = "0x6002F03")]
		[Cpp2IlInjected.Address(RVA = "0xFA71C0", Offset = "0xFA5BC0", VA = "0x180FA71C0")]
		private void OnEnable()
		{
			//IL_001d: Expected I4, but got I8
			//IL_002d: Expected I4, but got I8
			List<MakeupItem> list = (makeupItemList = (List<MakeupItem>)(object)new List<T>());
			IsInitSlider = true;
			MakeupColorMain = -1;
			MakeupColorThird = -1;
			MakeupOpacity = -1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F04")]
		[Cpp2IlInjected.Address(RVA = "0xFA7180", Offset = "0xFA5B80", VA = "0x180FA7180")]
		private void OnDisable()
		{
			Coroutine sliderCoroutine = _sliderCoroutine;
			if (sliderCoroutine != null)
			{
				StopCoroutine(sliderCoroutine);
			}
			Coroutine waitNextFrame = _waitNextFrame;
			if (waitNextFrame != null)
			{
				StopCoroutine(waitNextFrame);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F05")]
		[Cpp2IlInjected.Address(RVA = "0xFA8010", Offset = "0xFA6A10", VA = "0x180FA8010")]
		public void SetupMakeupColor(string categoryStringID, MakeupItemType makeupItemType, AvatarAppearance avatar, WardrobeSubFilterItemList sub, WardrobeAppearanceContent AppearanceContent, [Optional] Transform presetItems, [Optional] RectTransform subAbove, string title = "")
		{
			//IL_001a: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			//IL_010e: Expected O, but got I4
			//IL_0116: Expected O, but got I4
			bool active = default(bool);
			_title.gameObject.SetActive(active);
			_appearanceContent = (WardrobeAppearanceContent)0;
			ToggleGroupMakeupColor toggleMakeupColor = _toggleMakeupColor;
			WardrobeAppearanceContent wardrobeAppearanceContent = (toggleMakeupColor.AppearanceContent = _appearanceContent);
			_toggleMakeupColor.MakeupColor = this;
			int num = 0;
			string text = LocalizationManager.FromStringID(categoryStringID, (IResolver)num);
			_title.Text = text;
			string colorStringID = _colorStringID;
			int num2 = 0;
			string stringID = LocalizationManager.FromStringID(colorStringID, (IResolver)num2);
			string opacityStringID = _opacityStringID;
			int num3 = 0;
			string stringID2 = LocalizationManager.FromStringID(opacityStringID, (IResolver)num3);
			_colorTitle.StringID = stringID;
			_opacityTitle.StringID = stringID2;
			Slider slider = Slider;
			MakeupType = makeupItemType;
			slider.GetComponent<SliderMakeupOpacity>().MakeupColor = this;
			_subFilter = (WardrobeSubFilterItemList)0;
			SetDefaultMainColor(avatar);
			SetDefaultSecondColor(avatar);
			SetDefaultThirdColor(avatar);
			int index = 0;
			if (!SetDefaultSlider(avatar, index))
			{
				Slider.value = 100f;
			}
			int _003C_003E1__state = default(int);
			_003CSetupNavElements_003Ed__44 _003CSetupNavElements_003Ed__ = new _003CSetupNavElements_003Ed__44(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSetupNavElements_003Ed__._003C_003E4__this = this;
			_003CSetupNavElements_003Ed__.presetItems = (Transform)0;
			_003CSetupNavElements_003Ed__.subAbove = (RectTransform)0;
			Coroutine coroutine = (_waitNextFrame = StartCoroutine(_003CSetupNavElements_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F06")]
		[Cpp2IlInjected.Address(RVA = "0xFA7130", Offset = "0xFA5B30", VA = "0x180FA7130")]
		public bool Init(AvatarAppearance avatar)
		{
			SetDefaultMainColor(avatar);
			SetDefaultSecondColor(avatar);
			SetDefaultThirdColor(avatar);
			int index = 0;
			return SetDefaultSlider(avatar, index);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F07")]
		[Cpp2IlInjected.Address(RVA = "0xFA7260", Offset = "0xFA5C60", VA = "0x180FA7260")]
		public void SetDefaultMainColor(AvatarAppearance avatar)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F08")]
		[Cpp2IlInjected.Address(RVA = "0xFA74F0", Offset = "0xFA5EF0", VA = "0x180FA74F0")]
		public void SetDefaultSecondColor(AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_008d, IL_0093, IL_0099, IL_009f, IL_00a5, IL_00ab
			//IL_008c: Expected O, but got I4
			if (_subFilter._itemContainer.transform.childCount > 0)
			{
				Transform transform = _subFilter._itemContainer.transform;
				int index = 0;
				WardrobeMakeupItem component = transform.GetChild(index).GetComponent<WardrobeMakeupItem>();
				if (component.ItemData.defaultColor2_ != -1)
				{
					MapField<uint, Makeup> makeup_ = avatar.CurrentAvatar.Data.makeup_;
					Makeup makeup = default(Makeup);
					int num = (MakeupColorSecond = makeup.colorIndex2_);
					MakeupItemData itemData = component.ItemData;
				}
			}
			bool isActive = (long)"{il2cpp field on {'constant5' (constant value of type Cpp2IL.Core.Analysis.ResultModels.FieldPointer)}, offset 0x0}" != -1;
			int num2 = 0;
			SetThirdColorActiveState(isActive, (AvatarAppearance)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F09")]
		[Cpp2IlInjected.Address(RVA = "0xFA78F0", Offset = "0xFA62F0", VA = "0x180FA78F0")]
		public void SetDefaultThirdColor(AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_009e, IL_00a4, IL_00aa, IL_00b0, IL_00b6, IL_00bc
			//IL_007b: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			if (_subFilter._itemContainer.transform.childCount > 0)
			{
				Transform transform = _subFilter._itemContainer.transform;
				int index = 0;
				WardrobeMakeupItem component = transform.GetChild(index).GetComponent<WardrobeMakeupItem>();
				if (component.ItemData.defaultColor3_ != -1)
				{
					MapField<uint, Makeup> makeup_ = avatar.CurrentAvatar.Data.makeup_;
					Makeup makeup = default(Makeup);
					int num = (MakeupColorThird = makeup.colorIndex3_);
					MakeupItemData itemData = component.ItemData;
				}
			}
			int num2 = 0;
			bool flag = (UnityEngine.Object)0 != (UnityEngine.Object)num2;
			bool flag2 = default(bool);
			_toggleMakeupColor._toggleMakeupThirdColor.gameObject.SetActive(flag2);
			SetIconSate(3, flag2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0A")]
		[Cpp2IlInjected.Address(RVA = "0xFA7B60", Offset = "0xFA6560", VA = "0x180FA7B60")]
		private void SetIconSate(int colorSetIndex, bool value)
		{
			//Discarded unreachable code: IL_0062
			//IL_0039: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			int num = 0;
			int num2 = colorSetIndex - 1;
			if (num2 != 0)
			{
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						goto IL_002d;
					}
					ToggleGroupMakeupColor toggleMakeupColor = _toggleMakeupColor;
				}
				ToggleGroupMakeupColor toggleMakeupColor2 = _toggleMakeupColor;
			}
			Toggle toggleMakeupMainColor = _toggleMakeupColor._toggleMakeupMainColor;
			goto IL_002d;
			IL_002d:
			int num3 = 0;
			GameObject iconObject = default(GameObject);
			if (toggleMakeupMainColor != (UnityEngine.Object)num3)
			{
				iconObject = toggleMakeupMainColor.GetComponent<ToggleMakeupColor>().IconObject;
			}
			int num4 = 0;
			if (iconObject != (UnityEngine.Object)num4)
			{
				iconObject.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0B")]
		[Cpp2IlInjected.Address(RVA = "0xFA7CB0", Offset = "0xFA66B0", VA = "0x180FA7CB0")]
		public void SetSecondColorActiveState(bool isActive, [Optional] AvatarAppearance avatar)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0C")]
		[Cpp2IlInjected.Address(RVA = "0xFA7E80", Offset = "0xFA6880", VA = "0x180FA7E80")]
		public void SetThirdColorActiveState(bool isActive, [Optional] AvatarAppearance avatar)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0D")]
		[Cpp2IlInjected.Address(RVA = "0xFA76B0", Offset = "0xFA60B0", VA = "0x180FA76B0")]
		public bool SetDefaultSlider(AvatarAppearance avatar, int index = 0)
		{
			//Discarded unreachable code: IL_0093, IL_0099, IL_009f, IL_00a5, IL_00ab, IL_00b1
			WardrobeMakeupItem component;
			while (true)
			{
				if (index != 0 && _subFilter._itemContainer.transform.childCount > 0)
				{
					component = _subFilter._itemContainer.transform.GetChild(index).GetComponent<WardrobeMakeupItem>();
					if (component.ItemData != null)
					{
						break;
					}
				}
			}
			MapField<uint, Makeup> makeup_ = avatar.CurrentAvatar.Data.makeup_;
			Makeup makeup = default(Makeup);
			float num = (MakeupOpacity = makeup.opacity_);
			if (component.ItemData == null)
			{
				GameObject opacityGO = _OpacityGO;
				int active = 0;
				opacityGO.SetActive((byte)active != 0);
				UseFullOpacity = true;
			}
			float value = default(float);
			Slider.value = value;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0E")]
		[Cpp2IlInjected.Address(RVA = "0xFA8ED0", Offset = "0xFA78D0", VA = "0x180FA8ED0")]
		public void SetupToggle()
		{
			ToggleGroupMakeupColor toggleMakeupColor = _toggleMakeupColor;
			WardrobeAppearanceContent wardrobeAppearanceContent = (toggleMakeupColor.AppearanceContent = _appearanceContent);
			_toggleMakeupColor.MakeupColor = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F0F")]
		[Cpp2IlInjected.Address(RVA = "0xFA8F90", Offset = "0xFA7990", VA = "0x180FA8F90")]
		public void UpdateOpacity()
		{
			//IL_003f: Expected F4, but got I4
			WardrobeAppearanceContent appearanceContent = _appearanceContent;
			Slider slider = (appearanceContent.CurrentMakeupSlider = Slider);
			Slider slider2 = Slider;
			float value = slider2.value;
			int num = 0;
			if ((object)slider2 != null)
			{
				float value2 = Slider.value;
			}
			MakeupOpacity = num;
			if (IsInitSlider)
			{
				Slider.GetComponentInChildren<SliderMenu>().OnEnable();
			}
			WardrobeAppearanceContent appearanceContent2 = _appearanceContent;
			bool isInitSlider = IsInitSlider;
			float makeupOpacity = MakeupOpacity;
			appearanceContent2.OnMakupOpacityChange(makeupOpacity, isInitSlider);
			int _003C_003E1__state = default(int);
			_003CSliderFailSafe_003Ed__38 _003CSliderFailSafe_003Ed__ = new _003CSliderFailSafe_003Ed__38(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSliderFailSafe_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_sliderCoroutine = StartCoroutine(_003CSliderFailSafe_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F10")]
		[Cpp2IlInjected.Address(RVA = "0xFA8F20", Offset = "0xFA7920", VA = "0x180FA8F20")]
		[IteratorStateMachine(typeof(_003CSliderFailSafe_003Ed__38))]
		private IEnumerator SliderFailSafe()
		{
			int _003C_003E1__state = default(int);
			_003CSliderFailSafe_003Ed__38 _003CSliderFailSafe_003Ed__ = new _003CSliderFailSafe_003Ed__38(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSliderFailSafe_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F11")]
		[Cpp2IlInjected.Address(RVA = "0xFA8810", Offset = "0xFA7210", VA = "0x180FA8810")]
		private void SetupNextElementsForPresetInSubBelow()
		{
			//Discarded unreachable code: IL_00f6
			//IL_00c0: Expected O, but got I4
			while (true)
			{
				int childCount = _subFilter._itemContainer.transform.childCount;
				if (childCount == 0)
				{
					break;
				}
				if (_subFilter._itemContainer.transform.childCount > 0)
				{
					Transform transform = _subFilter._itemContainer.transform;
					int index = 0;
					RectTransform component = transform.GetChild(index).GetComponent<RectTransform>();
				}
				if (childCount <= 1 || (object)_subFilter._itemContainer.transform.GetChild(1).GetComponent<RectTransform>() == null)
				{
				}
				if (_subFilter._itemContainer.transform.childCount <= 0)
				{
					break;
				}
				int num = 0;
				if (1 <= 0)
				{
					break;
				}
				FocusNavigationElement component2 = _subFilter._itemContainer.transform.GetChild(num).GetComponent<FocusNavigationElement>();
				int num2 = 0;
				bool flag = component2 != (UnityEngine.Object)num2;
				if (flag)
				{
					FocusNavigationElement[] links = component2.Links;
					FocusNavigationElement sliderAnchorNavElement = _sliderAnchorNavElement;
					if ((object)sliderAnchorNavElement != null && !flag)
					{
						continue;
					}
					links[2] = sliderAnchorNavElement;
				}
				num++;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F12")]
		[Cpp2IlInjected.Address(RVA = "0xFA6E80", Offset = "0xFA5880", VA = "0x180FA6E80")]
		private int GetNbInFirstRow(int childCount)
		{
			//Discarded unreachable code: IL_005c
			if (_subFilter._itemContainer.transform.childCount > 0)
			{
				Transform transform = _subFilter._itemContainer.transform;
				int index = 0;
				RectTransform component = transform.GetChild(index).GetComponent<RectTransform>();
			}
			if (childCount <= 1 || (object)_subFilter._itemContainer.transform.GetChild(1).GetComponent<RectTransform>() == null)
			{
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F13")]
		[Cpp2IlInjected.Address(RVA = "0xFA8380", Offset = "0xFA6D80", VA = "0x180FA8380")]
		private void SetupNextElementsForPresetAbove(Transform presetItems)
		{
			//Discarded unreachable code: IL_0175
			float num = default(float);
			float num2 = default(float);
			float num3 = default(float);
			while (true)
			{
				Vector2 anchoredPosition = _toggleMakeupColor._toggleMakeupMainColor.GetComponent<RectTransform>().anchoredPosition;
				Vector2 anchoredPosition2 = _toggleMakeupColor._toggleMakeupSecondColor.GetComponent<RectTransform>().anchoredPosition;
				Vector2 anchoredPosition3 = _toggleMakeupColor._toggleMakeupThirdColor.GetComponent<RectTransform>().anchoredPosition;
				int childCount = presetItems.childCount;
				int nbInLastRow = GetNbInLastRow(childCount, presetItems);
				int childCount2 = presetItems.childCount;
				childCount2 -= nbInLastRow;
				int childCount3 = presetItems.childCount;
				if (childCount2 >= childCount3)
				{
					break;
				}
				RectTransform component = presetItems.GetChild(childCount2).GetComponent<RectTransform>();
				Vector2 anchoredPosition4 = component.anchoredPosition;
				Vector2 anchoredPosition5 = component.anchoredPosition;
				Vector2 anchoredPosition6 = component.anchoredPosition;
				if (!(num >= num2) && _toggleMakeupColor._toggleMakeupSecondColor.gameObject.activeInHierarchy && _toggleMakeupColor._toggleMakeupThirdColor.gameObject.activeInHierarchy)
				{
					if (!(num3 >= num) && _toggleMakeupColor._toggleMakeupThirdColor.gameObject.activeInHierarchy)
					{
						FocusNavigationElement component2 = component.GetComponent<FocusNavigationElement>();
						FocusNavigationElement[] links = component2.Links;
						if ((object)_colorThirdFocusAnchor != null && (object)component2 == null)
						{
							continue;
						}
					}
					FocusNavigationElement component3 = component.GetComponent<FocusNavigationElement>();
					FocusNavigationElement[] links2 = component3.Links;
					if ((object)_colorSecondaryFocusAnchor != null && (object)component3 == null)
					{
						continue;
					}
				}
				FocusNavigationElement component4 = component.GetComponent<FocusNavigationElement>();
				FocusNavigationElement[] links3 = component4.Links;
				FocusNavigationElement colorMainFocusAnchor = _colorMainFocusAnchor;
				if ((object)colorMainFocusAnchor == null || (object)component4 != null)
				{
					links3[3] = colorMainFocusAnchor;
					childCount2++;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F14")]
		[Cpp2IlInjected.Address(RVA = "0xFA7010", Offset = "0xFA5A10", VA = "0x180FA7010")]
		private int GetNbInLastRow(int childCount, Transform presetItems)
		{
			//Discarded unreachable code: IL_002b
			uint num = default(uint);
			if (childCount > (int)num)
			{
				int index = childCount - 1;
				RectTransform component = presetItems.GetChild(index).GetComponent<RectTransform>();
				if ((object)presetItems.GetChild(childCount).GetComponent<RectTransform>() == null)
				{
					num++;
				}
			}
			return childCount;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F15")]
		[Cpp2IlInjected.Address(RVA = "0xFA8B70", Offset = "0xFA7570", VA = "0x180FA8B70")]
		private void SetupNextElementsForSubAbove(RectTransform subAbove)
		{
			//Discarded unreachable code: IL_0109
			float num = default(float);
			float num2 = default(float);
			while (true)
			{
				Vector2 anchoredPosition = _toggleMakeupColor._toggleMakeupMainColor.GetComponent<RectTransform>().anchoredPosition;
				Vector2 anchoredPosition2 = _toggleMakeupColor._toggleMakeupSecondColor.GetComponent<RectTransform>().anchoredPosition;
				WardrobeSubFilterItemList component = subAbove.GetComponent<WardrobeSubFilterItemList>();
				int childCount = component._itemContainer.transform.childCount;
				Transform presetItems = component._itemContainer.transform;
				int nbInLastRow = GetNbInLastRow(childCount, presetItems);
				childCount -= nbInLastRow;
				if (childCount >= childCount)
				{
					break;
				}
				RectTransform component2 = component._itemContainer.transform.GetChild(childCount).GetComponent<RectTransform>();
				Vector2 anchoredPosition3 = component2.anchoredPosition;
				Vector2 anchoredPosition4 = component2.anchoredPosition;
				if (!(num >= num2) && _toggleMakeupColor._toggleMakeupSecondColor.gameObject.activeInHierarchy)
				{
					FocusNavigationElement component3 = component2.GetComponent<FocusNavigationElement>();
					FocusNavigationElement[] links = component3.Links;
					if ((object)_colorSecondaryFocusAnchor != null && (object)component3 == null)
					{
						continue;
					}
				}
				FocusNavigationElement component4 = component2.GetComponent<FocusNavigationElement>();
				FocusNavigationElement[] links2 = component4.Links;
				FocusNavigationElement colorMainFocusAnchor = _colorMainFocusAnchor;
				if ((object)colorMainFocusAnchor == null || (object)component4 != null)
				{
					links2[3] = colorMainFocusAnchor;
					childCount++;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F16")]
		[Cpp2IlInjected.Address(RVA = "0xFA82D0", Offset = "0xFA6CD0", VA = "0x180FA82D0")]
		[IteratorStateMachine(typeof(_003CSetupNavElements_003Ed__44))]
		private IEnumerator SetupNavElements(Transform presetItems, RectTransform subAbove)
		{
			int _003C_003E1__state = default(int);
			_003CSetupNavElements_003Ed__44 _003CSetupNavElements_003Ed__ = new _003CSetupNavElements_003Ed__44(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSetupNavElements_003Ed__._003C_003E4__this = this;
			_003CSetupNavElements_003Ed__.presetItems = presetItems;
			_003CSetupNavElements_003Ed__.subAbove = subAbove;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F17")]
		[Cpp2IlInjected.Address(RVA = "0xFA7E40", Offset = "0xFA6840", VA = "0x180FA7E40")]
		public void SetStringID(string color, string opacity)
		{
			_colorStringID = color;
			_opacityStringID = opacity;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F18")]
		[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
		public ToggleGroupMakeupColor GetToggle()
		{
			return _toggleMakeupColor;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F19")]
		[Cpp2IlInjected.Address(RVA = "0xFA9110", Offset = "0xFA7B10", VA = "0x180FA9110")]
		public MakeupColor()
		{
		}//IL_002a: Expected I4, but got I8
		//IL_003a: Expected I4, but got I8

	}
}
