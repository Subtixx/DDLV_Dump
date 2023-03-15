using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using Meta.Customization;
using Rewired;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200076E")]
	[RequiredAllNotNull]
	public class WardrobeAppearanceContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B61")]
		private bool _constructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B62")]
		[Nulllable]
		public Transform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B63")]
		[Nulllable]
		public SelectGenderPanel _genderPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002B64")]
		[SerializeField]
		private Transform _mcPresetItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002B65")]
		[Nulllable]
		public RectTransform _mcAvatarColorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002B66")]
		[Nulllable]
		public RectTransform _mcAvatarSecondaryColorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002B67")]
		[Nulllable]
		public RectTransform _mcAvataHairColorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002B68")]
		[Nulllable]
		public RectTransform _secondaryColorButtonContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002B69")]
		[SerializeField]
		private RectTransform _subItemlistContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002B6A")]
		[Nulllable]
		public Transform _mcColorHeader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002B6B")]
		[Nulllable]
		public RectTransform _eyeColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002B6C")]
		[Nulllable]
		public RectTransform _skinColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002B6D")]
		[Nulllable]
		public RectTransform _hairColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002B6E")]
		[Nulllable]
		public RectTransform _makeupMainColorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002B6F")]
		[Nulllable]
		public RectTransform _makeupSecondColorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002B70")]
		[Nulllable]
		public RectTransform _makeupThirdColorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002B71")]
		[Nulllable]
		public RectTransform _makeupMainColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002B72")]
		[Nulllable]
		public RectTransform _makeupSecondColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002B73")]
		[Nulllable]
		public RectTransform _makeupThirdColorContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002B74")]
		[Nulllable]
		public RectTransform _bodyTypeContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002B75")]
		[SerializeField]
		private Transform _mcPresetHeader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002B76")]
		[SerializeField]
		private TextBase _mcPresetHeaderText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002B77")]
		[SerializeField]
		private ScrollRect _mcAvatarItemsScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4002B78")]
		[SerializeField]
		private SelectColorPanel _mcColorPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002B79")]
		[SerializeField]
		private TextBase _tfCategoryEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002B7A")]
		[Nulllable]
		public FacePresetItem facePresetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002B7B")]
		[Nulllable]
		public BodyShapePresetItem bodyShapeItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002B7C")]
		[Nulllable]
		public FtueClothingItem hairStyleItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002B7D")]
		[SerializeField]
		private WadrobeAppearanceColorItem _colorButtonPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002B7E")]
		[SerializeField]
		private WadrobeAppearanceColorItem _hairColorButtonPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4002B7F")]
		[SerializeField]
		private WadrobeAppearanceColorItem _hairHighlightColorButtonPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4002B80")]
		[SerializeField]
		private GameObject _subListItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4002B81")]
		[Nulllable]
		public RectTransform _mcTrashBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002B82")]
		private FocusNavigation _currentFocusNav;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002B83")]
		[Nulllable]
		public GameObject _makeupColorPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4002B84")]
		[Nulllable]
		public WadrobeAppearanceColorItem _makeupColorMainItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002B85")]
		[Nulllable]
		public WadrobeAppearanceColorItem _makeupColorSecondItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4002B86")]
		[Nulllable]
		public WadrobeAppearanceColorItem _makeupColorThirdItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002B87")]
		[SerializeField]
		private string _eyesMakeupColorStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002B88")]
		[SerializeField]
		private string _eyesMakeupOpacityStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002B89")]
		[SerializeField]
		private string _genericMakeupColorStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002B8A")]
		[SerializeField]
		private string _genericMakeupOpacityStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4002B8B")]
		[HideInInspector]
		[Nulllable]
		public Slider CurrentMakeupSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4002B8C")]
		private Toggle _currentMakeupColorToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002B8D")]
		private List<MakeupColor> _makeupColorList = (List<MakeupColor>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4002B8E")]
		private MakeupColor _makeupColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4002B8F")]
		private int _currentSkinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4002B90")]
		private int _currentEyeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4002B91")]
		private int _currentHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4002B92")]
		private int _currentHairHighlightColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4002B93")]
		private int _currentMakeupColorMain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4002B94")]
		private int _currentMakeupColorSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4002B95")]
		private int _currentMakeupColorThird;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4002B96")]
		private bool _isInPreview;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4002B97")]
		private Rewired.Player _defaultPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4002B98")]
		private FocusNavigationElement _focusGoal;

		[Cpp2IlInjected.Token(Token = "0x170006C5")]
		public Mdl.Avatar.AvatarCustomization AvatarCustomization
		{
			[Cpp2IlInjected.Token(Token = "0x6002F8C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CAvatarCustomization_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F8D")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CAvatarCustomization_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C6")]
		public AvatarAppearance Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6002F8E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CAvatar_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F8F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CAvatar_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C7")]
		public Filter CurrentFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6002F90")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentFilter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F91")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CCurrentFilter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F92")]
		[Cpp2IlInjected.Address(RVA = "0x14D7BD0", Offset = "0x14D65D0", VA = "0x1814D7BD0")]
		private void Construct()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F93")]
		[Cpp2IlInjected.Address(RVA = "0x14E0030", Offset = "0x14DEA30", VA = "0x1814E0030")]
		private void PreviewMakeupMainColor(int index, bool fromSet = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F94")]
		[Cpp2IlInjected.Address(RVA = "0x14E2AB0", Offset = "0x14E14B0", VA = "0x1814E2AB0")]
		private void SetMakeupColorMain(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F95")]
		[Cpp2IlInjected.Address(RVA = "0x14E01A0", Offset = "0x14DEBA0", VA = "0x1814E01A0")]
		private void PreviewMakeupSecondColor(int index, bool fromSet = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F96")]
		[Cpp2IlInjected.Address(RVA = "0x14E2C30", Offset = "0x14E1630", VA = "0x1814E2C30")]
		private void SetMakeupColorSecond(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F97")]
		[Cpp2IlInjected.Address(RVA = "0x14E0310", Offset = "0x14DED10", VA = "0x1814E0310")]
		private void PreviewMakeupThirdColor(int index, bool fromSet = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F98")]
		[Cpp2IlInjected.Address(RVA = "0x14E2DB0", Offset = "0x14E17B0", VA = "0x1814E2DB0")]
		private void SetMakeupColorThird(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F99")]
		[Cpp2IlInjected.Address(RVA = "0x14E3760", Offset = "0x14E2160", VA = "0x1814E3760")]
		private void TryToSelectFirstOne(MakeupItemType makeupType)
		{
			//Discarded unreachable code: IL_0095
			//IL_0039: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			int num = 0;
			RectTransform subItemlistContent = _subItemlistContent;
			int num2 = 0;
			int childCount = subItemlistContent.childCount;
			if (num2 < childCount)
			{
				WardrobeSubFilterItemList component = _subItemlistContent.GetChild(num2).GetComponent<WardrobeSubFilterItemList>();
				int num3 = 0;
				if (!(component != (UnityEngine.Object)num3) || component.MakeupType != makeupType)
				{
					RectTransform subItemlistContent2 = _subItemlistContent;
					num2++;
				}
			}
			int num4 = 0;
			if ((UnityEngine.Object)num2 != (UnityEngine.Object)num4)
			{
				int num5 = default(int);
				Transform transform = default(Transform);
				if (num2 < num5)
				{
					WardrobeMakeupItem component2 = transform.GetComponent<WardrobeMakeupItem>();
					num2++;
				}
				if (1 == 0 && transform.childCount > 0)
				{
					int index = 0;
					WardrobeMakeupItem component3 = transform.GetChild(index).GetComponent<WardrobeMakeupItem>();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9A")]
		[Cpp2IlInjected.Address(RVA = "0x14D9E70", Offset = "0x14D8870", VA = "0x1814D9E70")]
		private WardrobeSubFilterItemList FindSubItemList(MakeupItemType makeupType)
		{
			//IL_0035: Expected O, but got I4
			RectTransform subItemlistContent = _subItemlistContent;
			int num = 0;
			int childCount = subItemlistContent.childCount;
			if (num < childCount)
			{
				WardrobeSubFilterItemList component = _subItemlistContent.GetChild(num).GetComponent<WardrobeSubFilterItemList>();
				int num2 = 0;
				if (!(component != (UnityEngine.Object)num2) || component.MakeupType != makeupType)
				{
					RectTransform subItemlistContent2 = _subItemlistContent;
					num++;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9B")]
		[Cpp2IlInjected.Address(RVA = "0x14DCF90", Offset = "0x14DB990", VA = "0x1814DCF90")]
		public void OnMakupOpacityChange(float value, bool isInitSlider)
		{
			//Discarded unreachable code: IL_0034
			MakeupColor makeupColor = CurrentMakeupSlider.GetComponent<SliderMakeupOpacity>().MakeupColor;
			if (isInitSlider)
			{
				makeupColor.IsInitSlider = false;
			}
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			MakeupItemType makeupType = makeupColor.MakeupType;
			avatarCustomization.SetMakeupOpacity(makeupType, value);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9C")]
		[Cpp2IlInjected.Address(RVA = "0x14E29F0", Offset = "0x14E13F0", VA = "0x1814E29F0")]
		private void SetHairColor(int index)
		{
			//Discarded unreachable code: IL_0031
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			bool forceSave = _currentHairColor != index;
			avatarCustomization.SetHairColor(index, forceSave);
			_currentHairColor = index;
			RefreshSelectedHairColor();
			bool flag = TryCloseColorPopup();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9D")]
		[Cpp2IlInjected.Address(RVA = "0x14DFFD0", Offset = "0x14DE9D0", VA = "0x1814DFFD0")]
		private void PreviewHairColor(int index)
		{
			//Discarded unreachable code: IL_0015
			_isInPreview = true;
			bool flag = Avatar.SetHairColor(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9E")]
		[Cpp2IlInjected.Address(RVA = "0x14E0000", Offset = "0x14DEA00", VA = "0x1814E0000")]
		private void PreviewHairHighlightColor(int index)
		{
			//Discarded unreachable code: IL_0015
			_isInPreview = true;
			bool flag = Avatar.SetHairHighlightColor(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F9F")]
		[Cpp2IlInjected.Address(RVA = "0x14DFFA0", Offset = "0x14DE9A0", VA = "0x1814DFFA0")]
		private void PreviewEyeColor(int index)
		{
			//Discarded unreachable code: IL_0015
			_isInPreview = true;
			bool flag = Avatar.SetEyeColor(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA0")]
		[Cpp2IlInjected.Address(RVA = "0x14E0590", Offset = "0x14DEF90", VA = "0x1814E0590")]
		private void PreviewSkinColor(int index)
		{
			_isInPreview = true;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA1")]
		[Cpp2IlInjected.Address(RVA = "0x14E0480", Offset = "0x14DEE80", VA = "0x1814E0480")]
		[AsyncStateMachine(typeof(_003CPreviewSkinColorTask_003Ed__83))]
		private Task PreviewSkinColorTask(int index)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA2")]
		[Cpp2IlInjected.Address(RVA = "0x14E3450", Offset = "0x14E1E50", VA = "0x1814E3450")]
		public bool TryCloseColorPopup()
		{
			//Discarded unreachable code: IL_0171
			if ((!_mcAvatarColorContent.gameObject.activeInHierarchy || !_eyeColorContainer.gameObject.activeInHierarchy) && (!_mcAvatarColorContent.gameObject.activeInHierarchy || !_skinColorContainer.gameObject.activeInHierarchy) && !_mcAvataHairColorContent.gameObject.activeInHierarchy && !_mcAvatarSecondaryColorContent.gameObject.activeInHierarchy)
			{
				if (!_makeupMainColorContent.gameObject.activeInHierarchy && !_makeupSecondColorContent.gameObject.activeInHierarchy)
				{
					bool activeInHierarchy = _makeupThirdColorContent.gameObject.activeInHierarchy;
					if (!activeInHierarchy)
					{
						return activeInHierarchy;
					}
				}
				MakeupColor makeupColor = _currentMakeupColorToggle.GetComponent<ToggleMakeupColor>().ToggleGroupMakeupColor.MakeupColor;
				int currentMakeupColorMain = _currentMakeupColorMain;
				if (makeupColor.MakeupColorMain != currentMakeupColorMain)
				{
					SetMakeupColorMain(currentMakeupColorMain);
				}
				int makeupColorSecond = makeupColor.MakeupColorSecond;
				if (makeupColorSecond != -1)
				{
					int currentMakeupColorSecond = _currentMakeupColorSecond;
					if (makeupColorSecond != currentMakeupColorSecond)
					{
						SetMakeupColorSecond(currentMakeupColorSecond);
					}
				}
				int makeupColorThird = makeupColor.MakeupColorThird;
				if (makeupColorThird != -1)
				{
					int currentMakeupColorThird = _currentMakeupColorThird;
					if (makeupColorThird != currentMakeupColorThird)
					{
						SetMakeupColorThird(currentMakeupColorThird);
					}
				}
				Toggle currentMakeupColorToggle = _currentMakeupColorToggle;
				int num = ((currentMakeupColorToggle.isOn = false) ? 1 : 0);
				Toggle currentMakeupColorToggle2 = _currentMakeupColorToggle;
				FocusNavigation currentFocusNav = _currentFocusNav;
				FocusNavigationElement component = currentMakeupColorToggle2.GetComponent<FocusNavigationElement>();
				SetFocus(currentFocusNav, component);
				return true;
			}
			_mcColorPanel.ToggleAllOff();
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA3")]
		[Cpp2IlInjected.Address(RVA = "0x14DD040", Offset = "0x14DBA40", VA = "0x1814DD040")]
		private unsafe void OnMouseClick(InputActionEventData data)
		{
			//IL_00d4: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			//IL_0139: Expected O, but got I4
			//IL_016f: Expected O, but got I4
			//IL_016f: Expected O, but got I4
			RectTransform mcAvatarColorContent = _mcAvatarColorContent;
			int num = 0;
			if (mcAvatarColorContent.gameObject.activeInHierarchy && _eyeColorContainer.gameObject.activeInHierarchy)
			{
				SelectColorPanel mcColorPanel = _mcColorPanel;
			}
			if (_mcAvatarColorContent.gameObject.activeInHierarchy && _skinColorContainer.gameObject.activeInHierarchy)
			{
				SelectColorPanel mcColorPanel2 = _mcColorPanel;
			}
			if (!_mcAvataHairColorContent.gameObject.activeInHierarchy)
			{
				if (!_mcAvatarSecondaryColorContent.gameObject.activeInHierarchy && !_makeupMainColorContent.gameObject.activeInHierarchy && !_makeupSecondColorContent.gameObject.activeInHierarchy)
				{
					if (!_makeupThirdColorContent.gameObject.activeInHierarchy)
					{
						goto IL_010f;
					}
					Toggle currentMakeupColorToggle = _currentMakeupColorToggle;
					int num2 = 0;
					if (currentMakeupColorToggle != (UnityEngine.Object)num2)
					{
						Transform transform = _currentMakeupColorToggle.transform;
					}
				}
				SelectColorPanel mcColorPanel3 = _mcColorPanel;
			}
			SelectColorPanel mcColorPanel4 = _mcColorPanel;
			RectTransform mcAvataHairColorContent = _mcAvataHairColorContent;
			Transform transform2 = mcColorPanel4._toggleHairColor.transform;
			if ((object)transform2 == null)
			{
			}
			goto IL_010f;
			IL_010f:
			if (!((InputActionEventData*)data)->GetButton())
			{
				return;
			}
			int num3 = 0;
			if (!(mcAvataHairColorContent != (UnityEngine.Object)num3))
			{
				return;
			}
			int num4 = 0;
			bool flag = transform2 != (UnityEngine.Object)num4;
			if (!flag)
			{
				return;
			}
			int num5 = 0;
			float axis = ((InputActionEventData*)data)->GetAxis();
			if (flag)
			{
				return;
			}
			int num6 = 0;
			Vector2 mousePosition = Input.mousePosition;
			int num7 = 0;
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(mcAvataHairColorContent, (Vector2)num5, (Camera)num7, out *(Vector2*)num) || flag2 || !flag3 || flag4)
			{
				return;
			}
			if (!_makeupMainColorContent.gameObject.activeInHierarchy)
			{
				if (!_makeupSecondColorContent.gameObject.activeInHierarchy)
				{
					if (!_makeupThirdColorContent.gameObject.activeInHierarchy)
					{
						bool flag5 = TryCloseColorPopup();
						return;
					}
					int currentMakeupColorThird = _currentMakeupColorThird;
					SetMakeupColorThird(currentMakeupColorThird);
				}
				int currentMakeupColorSecond = _currentMakeupColorSecond;
				SetMakeupColorSecond(currentMakeupColorSecond);
			}
			int currentMakeupColorMain = _currentMakeupColorMain;
			SetMakeupColorMain(currentMakeupColorMain);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA4")]
		[Cpp2IlInjected.Address(RVA = "0x14DB320", Offset = "0x14D9D20", VA = "0x1814DB320")]
		private void OnEyeColorPanelToggle(bool isShown)
		{
			//Discarded unreachable code: IL_0185
			//IL_0099: Expected I4, but got I8
			//IL_012e: Expected O, but got I4
			//IL_0156: Expected I4, but got I8
			//IL_0184: Expected O, but got I4
			RectTransform skinColorContainer = _skinColorContainer;
			int num = 0;
			GameObject gameObject = skinColorContainer.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _mcAvataHairColorContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _mcAvatarSecondaryColorContent.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			_mcAvatarColorContent.gameObject.SetActive(isShown);
			_eyeColorContainer.gameObject.SetActive(isShown);
			if (!isShown)
			{
				Rewired.Player defaultPlayer = _defaultPlayer;
				Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
				int num2 = 0;
				ulong num3 = default(ulong);
				defaultPlayer.RemoveInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num2, InputActionEventType.ButtonJustPressed, (int)num3);
				_mcAvatarItemsScrollRect.enabled = true;
				Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
				int currentEyeColor = _currentEyeColor;
				int forceSave = 0;
				avatarCustomization.SetEyeColor(currentEyeColor, (byte)forceSave != 0);
				_currentEyeColor = currentEyeColor;
				RefreshSelectedEyeColor();
				bool flag = TryCloseColorPopup();
				_isInPreview = false;
			}
			ScrollRect mcAvatarItemsScrollRect = _mcAvatarItemsScrollRect;
			int num4 = ((mcAvatarItemsScrollRect.enabled = false) ? 1 : 0);
			_eyeColorContainer.GetComponent<RectTransform>().RebuildLayout();
			RectTransform mcAvatarColorContent = _mcAvatarColorContent;
			Vector2 sizeDelta = mcAvatarColorContent.sizeDelta;
			RectTransform component = _eyeColorContainer.GetComponent<RectTransform>();
			int num5 = 0;
			mcAvatarColorContent.sizeDelta = (Vector2)num5;
			Rewired.Player defaultPlayer2 = _defaultPlayer;
			Action<InputActionEventData> action2 = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
			int num6 = 0;
			ulong num7 = default(ulong);
			defaultPlayer2.AddInputEventDelegate((Action<>)(object)action2, (UpdateLoopType)num6, InputActionEventType.ButtonJustPressed, (int)num7);
			int num8 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation currentFocusNav = _currentFocusNav;
				int num9 = 0;
				SetFocus(currentFocusNav, (FocusNavigationElement)num9);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA5")]
		[Cpp2IlInjected.Address(RVA = "0x14DD610", Offset = "0x14DC010", VA = "0x1814DD610")]
		private void OnSkinColorPanelToggle(bool isShown)
		{
			//Discarded unreachable code: IL_015f
			//IL_009b: Expected I4, but got I8
			//IL_0106: Expected O, but got I4
			//IL_0130: Expected I4, but got I8
			//IL_015e: Expected O, but got I4
			RectTransform eyeColorContainer = _eyeColorContainer;
			int num = 0;
			GameObject gameObject = eyeColorContainer.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _mcAvataHairColorContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _mcAvatarSecondaryColorContent.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			_mcAvatarColorContent.gameObject.SetActive(isShown);
			_skinColorContainer.gameObject.SetActive(isShown);
			if (!isShown)
			{
				Rewired.Player defaultPlayer = _defaultPlayer;
				Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
				int num2 = 0;
				int num3 = 0;
				ulong num4 = default(ulong);
				defaultPlayer.RemoveInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num3, InputActionEventType.ButtonJustPressed, (int)num4);
				_mcAvatarItemsScrollRect.enabled = true;
				int num5 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				_isInPreview = false;
			}
			ScrollRect mcAvatarItemsScrollRect = _mcAvatarItemsScrollRect;
			int num6 = ((mcAvatarItemsScrollRect.enabled = false) ? 1 : 0);
			_skinColorContainer.GetComponent<RectTransform>().RebuildLayout();
			RectTransform mcAvatarColorContent = _mcAvatarColorContent;
			Vector2 sizeDelta = mcAvatarColorContent.sizeDelta;
			RectTransform component = _skinColorContainer.GetComponent<RectTransform>();
			int num7 = 0;
			mcAvatarColorContent.sizeDelta = (Vector2)num7;
			Rewired.Player defaultPlayer2 = _defaultPlayer;
			Action<InputActionEventData> action2 = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
			int num8 = 0;
			int num9 = 0;
			ulong num10 = default(ulong);
			defaultPlayer2.AddInputEventDelegate((Action<>)(object)action2, (UpdateLoopType)num9, InputActionEventType.ButtonJustPressed, (int)num10);
			int num11 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation currentFocusNav = _currentFocusNav;
				int num12 = 0;
				SetFocus(currentFocusNav, (FocusNavigationElement)num12);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA6")]
		[Cpp2IlInjected.Address(RVA = "0x14DB690", Offset = "0x14DA090", VA = "0x1814DB690")]
		private void OnHairColorPanelToggle(bool isShown)
		{
			//Discarded unreachable code: IL_0181
			//IL_0071: Expected I4, but got I8
			//IL_013f: Expected I4, but got I8
			RectTransform mcAvatarSecondaryColorContent = _mcAvatarSecondaryColorContent;
			int num = 0;
			GameObject gameObject = mcAvatarSecondaryColorContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _mcAvataHairColorContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			_mcAvataHairColorContent.gameObject.SetActive(isShown);
			if (!isShown)
			{
				Rewired.Player defaultPlayer = _defaultPlayer;
				Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
				int isInPreview = 0;
				int num2 = 0;
				ulong num3 = default(ulong);
				defaultPlayer.RemoveInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num2, InputActionEventType.ButtonJustPressed, (int)num3);
				_mcAvatarItemsScrollRect.enabled = true;
				Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
				int currentHairColor = _currentHairColor;
				int forceSave = 0;
				avatarCustomization.SetHairColor(currentHairColor, (byte)forceSave != 0);
				_currentHairColor = currentHairColor;
				RefreshSelectedHairColor();
				bool flag = TryCloseColorPopup();
				_isInPreview = (byte)isInPreview != 0;
			}
			ScrollRect mcAvatarItemsScrollRect = _mcAvatarItemsScrollRect;
			int num4 = ((mcAvatarItemsScrollRect.enabled = false) ? 1 : 0);
			_hairColorContainer.RebuildLayout();
			GridLayoutGroup component = _hairColorContainer.GetComponent<GridLayoutGroup>();
			RectTransform mcAvataHairColorContent = _mcAvataHairColorContent;
			Vector2 cellSize = component.m_CellSize;
			RectTransform component2 = mcAvataHairColorContent.GetComponent<RectTransform>();
			RectTransform component3 = _hairColorContainer.GetComponent<RectTransform>();
			component2.sizeDelta = cellSize;
			Rewired.Player defaultPlayer2 = _defaultPlayer;
			Action<InputActionEventData> action2 = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
			int num5 = 0;
			int num6 = 0;
			ulong num7 = default(ulong);
			defaultPlayer2.AddInputEventDelegate((Action<>)(object)action2, (UpdateLoopType)num6, InputActionEventType.ButtonJustPressed, (int)num7);
			int num8 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation currentFocusNav = _currentFocusNav;
				FocusNavigationElement component4 = default(FocusNavigationElement);
				if (!isShown)
				{
					component4 = _mcColorPanel._toggleHairColor.GetComponent<FocusNavigationElement>();
				}
				SetFocus(currentFocusNav, component4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA7")]
		[Cpp2IlInjected.Address(RVA = "0x14DBA60", Offset = "0x14DA460", VA = "0x1814DBA60")]
		private void OnHairHighlightColorPanelToggle(bool isShown)
		{
			//Discarded unreachable code: IL_0181
			//IL_0071: Expected I4, but got I8
			//IL_013f: Expected I4, but got I8
			RectTransform mcAvatarColorContent = _mcAvatarColorContent;
			int num = 0;
			GameObject gameObject = mcAvatarColorContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _mcAvataHairColorContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			_mcAvatarSecondaryColorContent.gameObject.SetActive(isShown);
			if (!isShown)
			{
				Rewired.Player defaultPlayer = _defaultPlayer;
				Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
				int isInPreview = 0;
				int num2 = 0;
				ulong num3 = default(ulong);
				defaultPlayer.RemoveInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num2, InputActionEventType.ButtonJustPressed, (int)num3);
				_mcAvatarItemsScrollRect.enabled = true;
				Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
				int currentHairHighlightColor = _currentHairHighlightColor;
				int forceSave = 0;
				avatarCustomization.SetHairHightlightColor(currentHairHighlightColor, (byte)forceSave != 0);
				_currentHairHighlightColor = currentHairHighlightColor;
				RefreshSelectedHighlightColor();
				bool flag = TryCloseColorPopup();
				_isInPreview = (byte)isInPreview != 0;
			}
			ScrollRect mcAvatarItemsScrollRect = _mcAvatarItemsScrollRect;
			int num4 = ((mcAvatarItemsScrollRect.enabled = false) ? 1 : 0);
			_secondaryColorButtonContainer.RebuildLayout();
			GridLayoutGroup component = _secondaryColorButtonContainer.GetComponent<GridLayoutGroup>();
			RectTransform mcAvatarSecondaryColorContent = _mcAvatarSecondaryColorContent;
			Vector2 cellSize = component.m_CellSize;
			RectTransform component2 = mcAvatarSecondaryColorContent.GetComponent<RectTransform>();
			RectTransform component3 = _secondaryColorButtonContainer.GetComponent<RectTransform>();
			component2.sizeDelta = cellSize;
			Rewired.Player defaultPlayer2 = _defaultPlayer;
			Action<InputActionEventData> action2 = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
			int num5 = 0;
			int num6 = 0;
			ulong num7 = default(ulong);
			defaultPlayer2.AddInputEventDelegate((Action<>)(object)action2, (UpdateLoopType)num6, InputActionEventType.ButtonJustPressed, (int)num7);
			int num8 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation currentFocusNav = _currentFocusNav;
				FocusNavigationElement component4 = default(FocusNavigationElement);
				if (!isShown)
				{
					component4 = _mcColorPanel._toggleHairHighlightColor.GetComponent<FocusNavigationElement>();
				}
				SetFocus(currentFocusNav, component4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA8")]
		[Cpp2IlInjected.Address(RVA = "0x14DBE20", Offset = "0x14DA820", VA = "0x1814DBE20")]
		public void OnMakeupMainColorToggle(bool isShown, Toggle makeupToggle, MakeupColor MakeupColor, FocusNavigationElement element)
		{
			//Discarded unreachable code: IL_01d8, IL_01de, IL_01e4, IL_01ea, IL_01f6
			//IL_0009: Expected O, but got I4
			//IL_00ca: Expected I4, but got I8
			//IL_0115: Expected I4, but got I8
			//IL_0167: Expected I4, but got I8
			//IL_0192: Expected O, but got I4
			//IL_0192: Expected O, but got I4
			ulong num7 = default(ulong);
			uint num8 = default(uint);
			WadrobeAppearanceColorItem wadrobeAppearanceColorItem = default(WadrobeAppearanceColorItem);
			ulong num10 = default(ulong);
			BaseButton baseButton = default(BaseButton);
			ulong num12 = default(ulong);
			while (true)
			{
				int num = 0;
				_focusGoal = (FocusNavigationElement)0;
				_currentMakeupColorToggle = makeupToggle;
				_makeupMainColorContent.gameObject.SetActive(isShown);
				GameObject gameObject = _makeupSecondColorContent.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _makeupThirdColorContent.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				if (isShown)
				{
					int num2 = (_currentMakeupColorMain = MakeupColor.MakeupColorMain);
					int num3 = (_currentMakeupColorSecond = MakeupColor.MakeupColorSecond);
					int num4 = (_currentMakeupColorThird = MakeupColor.MakeupColorThird);
					ScrollRect mcAvatarItemsScrollRect = _mcAvatarItemsScrollRect;
					int num5 = ((mcAvatarItemsScrollRect.enabled = false) ? 1 : 0);
					_makeupMainColorContainer.RebuildLayout();
					Rewired.Player defaultPlayer = _defaultPlayer;
					Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
					int num6 = 0;
					defaultPlayer.AddInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num6, InputActionEventType.ButtonJustPressed, (int)num7);
					IEnumerator enumerator = _makeupMainColorContainer.GetEnumerator();
					if (enumerator != null)
					{
						if (num < (int)num8)
						{
							num += num;
							num++;
						}
						if (enumerator == null)
						{
							break;
						}
						if (wadrobeAppearanceColorItem.Index != MakeupColor.MakeupColorMain)
						{
							int num9 = ((wadrobeAppearanceColorItem.IsSelected = false) ? 1 : 0);
						}
						wadrobeAppearanceColorItem.IsSelected = (byte)num10 != 0;
						int num11 = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
						{
							continue;
						}
						baseButton.OnHighlightEnter();
					}
					num++;
					if (num != 0)
					{
					}
					if (num == 0)
					{
					}
				}
				Rewired.Player defaultPlayer2 = _defaultPlayer;
				Action<InputActionEventData> action2 = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
				_mcAvatarItemsScrollRect.enabled = (byte)num12 != 0;
				_isInPreview = false;
				int num13 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (!instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
					return;
				}
				int num14 = 0;
				bool flag3 = (UnityEngine.Object)num != (UnityEngine.Object)num14;
				FocusNavigation currentFocusNav = _currentFocusNav;
				if (!flag3)
				{
					if (!isShown)
					{
						FocusNavigationElement component = _currentMakeupColorToggle.GetComponent<FocusNavigationElement>();
						currentFocusNav.SetFocus(component);
						return;
					}
					RectTransform makeupMainColorContainer = _makeupMainColorContainer;
					int index = 0;
					Transform child = makeupMainColorContainer.GetChild(index);
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FA9")]
		[Cpp2IlInjected.Address(RVA = "0x14DC3F0", Offset = "0x14DADF0", VA = "0x1814DC3F0")]
		public void OnMakeupSecondColorPanelToggle(bool isShown, Toggle makeupToggle, MakeupColor MakeupColor, FocusNavigationElement element)
		{
			//Discarded unreachable code: IL_01d8, IL_01de, IL_01e4, IL_01ea, IL_01f6
			//IL_0009: Expected O, but got I4
			//IL_00ca: Expected I4, but got I8
			//IL_0115: Expected I4, but got I8
			//IL_0167: Expected I4, but got I8
			//IL_0192: Expected O, but got I4
			//IL_0192: Expected O, but got I4
			ulong num7 = default(ulong);
			uint num8 = default(uint);
			WadrobeAppearanceColorItem wadrobeAppearanceColorItem = default(WadrobeAppearanceColorItem);
			ulong num10 = default(ulong);
			BaseButton baseButton = default(BaseButton);
			ulong num12 = default(ulong);
			while (true)
			{
				int num = 0;
				_focusGoal = (FocusNavigationElement)0;
				_currentMakeupColorToggle = makeupToggle;
				GameObject gameObject = _makeupMainColorContent.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				_makeupSecondColorContent.gameObject.SetActive(isShown);
				GameObject gameObject2 = _makeupThirdColorContent.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				if (isShown)
				{
					int num2 = (_currentMakeupColorMain = MakeupColor.MakeupColorMain);
					int num3 = (_currentMakeupColorSecond = MakeupColor.MakeupColorSecond);
					int num4 = (_currentMakeupColorThird = MakeupColor.MakeupColorThird);
					ScrollRect mcAvatarItemsScrollRect = _mcAvatarItemsScrollRect;
					int num5 = ((mcAvatarItemsScrollRect.enabled = false) ? 1 : 0);
					_makeupSecondColorContainer.RebuildLayout();
					Rewired.Player defaultPlayer = _defaultPlayer;
					Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
					int num6 = 0;
					defaultPlayer.AddInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num6, InputActionEventType.ButtonJustPressed, (int)num7);
					IEnumerator enumerator = _makeupSecondColorContainer.GetEnumerator();
					if (enumerator != null)
					{
						if (num < (int)num8)
						{
							num += num;
							num++;
						}
						if (enumerator == null)
						{
							break;
						}
						if (wadrobeAppearanceColorItem.Index != MakeupColor.MakeupColorSecond)
						{
							int num9 = ((wadrobeAppearanceColorItem.IsSelected = false) ? 1 : 0);
						}
						wadrobeAppearanceColorItem.IsSelected = (byte)num10 != 0;
						int num11 = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
						{
							continue;
						}
						baseButton.OnHighlightEnter();
					}
					num++;
					if (num != 0)
					{
					}
					if (num == 0)
					{
					}
				}
				Rewired.Player defaultPlayer2 = _defaultPlayer;
				Action<InputActionEventData> action2 = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
				_mcAvatarItemsScrollRect.enabled = (byte)num12 != 0;
				_isInPreview = false;
				int num13 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (!instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
					return;
				}
				int num14 = 0;
				bool flag3 = (UnityEngine.Object)num != (UnityEngine.Object)num14;
				FocusNavigation currentFocusNav = _currentFocusNav;
				if (!flag3)
				{
					if (!isShown)
					{
						FocusNavigationElement component = _currentMakeupColorToggle.GetComponent<FocusNavigationElement>();
						currentFocusNav.SetFocus(component);
						return;
					}
					RectTransform makeupSecondColorContainer = _makeupSecondColorContainer;
					int index = 0;
					Transform child = makeupSecondColorContainer.GetChild(index);
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAA")]
		[Cpp2IlInjected.Address(RVA = "0x14DC9C0", Offset = "0x14DB3C0", VA = "0x1814DC9C0")]
		public void OnMakeupThirdColorPanelToggle(bool isShown, Toggle makeupToggle, MakeupColor MakeupColor, FocusNavigationElement element)
		{
			//Discarded unreachable code: IL_01d8, IL_01de, IL_01e4, IL_01ea, IL_01f6
			//IL_0009: Expected O, but got I4
			//IL_00ca: Expected I4, but got I8
			//IL_0115: Expected I4, but got I8
			//IL_0167: Expected I4, but got I8
			//IL_0192: Expected O, but got I4
			//IL_0192: Expected O, but got I4
			ulong num7 = default(ulong);
			uint num8 = default(uint);
			WadrobeAppearanceColorItem wadrobeAppearanceColorItem = default(WadrobeAppearanceColorItem);
			ulong num10 = default(ulong);
			BaseButton baseButton = default(BaseButton);
			ulong num12 = default(ulong);
			while (true)
			{
				int num = 0;
				_focusGoal = (FocusNavigationElement)0;
				_currentMakeupColorToggle = makeupToggle;
				GameObject gameObject = _makeupMainColorContent.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _makeupSecondColorContent.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				_makeupThirdColorContent.gameObject.SetActive(isShown);
				if (isShown)
				{
					int num2 = (_currentMakeupColorMain = MakeupColor.MakeupColorMain);
					int num3 = (_currentMakeupColorSecond = MakeupColor.MakeupColorSecond);
					int num4 = (_currentMakeupColorThird = MakeupColor.MakeupColorThird);
					ScrollRect mcAvatarItemsScrollRect = _mcAvatarItemsScrollRect;
					int num5 = ((mcAvatarItemsScrollRect.enabled = false) ? 1 : 0);
					_makeupThirdColorContainer.RebuildLayout();
					Rewired.Player defaultPlayer = _defaultPlayer;
					Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
					int num6 = 0;
					defaultPlayer.AddInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num6, InputActionEventType.ButtonJustPressed, (int)num7);
					IEnumerator enumerator = _makeupThirdColorContainer.GetEnumerator();
					if (enumerator != null)
					{
						if (num < (int)num8)
						{
							num += num;
							num++;
						}
						if (enumerator == null)
						{
							break;
						}
						if (wadrobeAppearanceColorItem.Index != MakeupColor.MakeupColorThird)
						{
							int num9 = ((wadrobeAppearanceColorItem.IsSelected = false) ? 1 : 0);
						}
						wadrobeAppearanceColorItem.IsSelected = (byte)num10 != 0;
						int num11 = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
						{
							continue;
						}
						baseButton.OnHighlightEnter();
					}
					num++;
					if (num != 0)
					{
					}
					if (num == 0)
					{
					}
				}
				Rewired.Player defaultPlayer2 = _defaultPlayer;
				Action<InputActionEventData> action2 = (Action<InputActionEventData>)(object)new Action<T>(OnMouseClick);
				_mcAvatarItemsScrollRect.enabled = (byte)num12 != 0;
				_isInPreview = false;
				int num13 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				if (!instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
				{
					return;
				}
				int num14 = 0;
				bool flag3 = (UnityEngine.Object)num != (UnityEngine.Object)num14;
				FocusNavigation currentFocusNav = _currentFocusNav;
				if (!flag3)
				{
					if (!isShown)
					{
						FocusNavigationElement component = _currentMakeupColorToggle.GetComponent<FocusNavigationElement>();
						currentFocusNav.SetFocus(component);
						return;
					}
					RectTransform makeupThirdColorContainer = _makeupThirdColorContainer;
					int index = 0;
					Transform child = makeupThirdColorContainer.GetChild(index);
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAB")]
		[Cpp2IlInjected.Address(RVA = "0x14E1070", Offset = "0x14DFA70", VA = "0x1814E1070")]
		private void RefreshSelectedHairColor()
		{
			//Discarded unreachable code: IL_0058, IL_005e, IL_0064, IL_0076
			//IL_002a: Expected O, but got I4
			int num = 0;
			IEnumerator enumerator = _hairColorContainer.GetEnumerator();
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				WadrobeAppearanceColorItem wadrobeAppearanceColorItem = default(WadrobeAppearanceColorItem);
				if (!(wadrobeAppearanceColorItem == (UnityEngine.Object)num4))
				{
					bool flag2 = (wadrobeAppearanceColorItem.IsSelected = _currentHairColor == wadrobeAppearanceColorItem.Index);
				}
				num++;
			}
			num++;
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAC")]
		[Cpp2IlInjected.Address(RVA = "0x14DAAA0", Offset = "0x14D94A0", VA = "0x1814DAAA0")]
		private int GetSelectedHairColorChildIndex()
		{
			//Discarded unreachable code: IL_004b, IL_0051, IL_0057, IL_0063
			//IL_0023: Expected O, but got I4
			WadrobeAppearanceColorItem wadrobeAppearanceColorItem = default(WadrobeAppearanceColorItem);
			int num4 = default(int);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = _hairColorContainer.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (!(wadrobeAppearanceColorItem == (UnityEngine.Object)num3))
					{
						if (_currentHairColor != wadrobeAppearanceColorItem.Index)
						{
							continue;
						}
						num++;
					}
					num++;
				}
				num++;
				if (num4 != 0)
				{
				}
				if (num != 0)
				{
				}
				return -1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAD")]
		[Cpp2IlInjected.Address(RVA = "0x14DAD20", Offset = "0x14D9720", VA = "0x1814DAD20")]
		private int GetSelectedHairHighlightColorChildIndex()
		{
			//Discarded unreachable code: IL_002d, IL_0033, IL_0039, IL_0045
			int num = 0;
			IEnumerator enumerator = _secondaryColorButtonContainer.GetEnumerator();
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				int currentHairHighlightColor = _currentHairHighlightColor;
			}
			int num3 = default(int);
			if (num3 != 0)
			{
			}
			return num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAE")]
		[Cpp2IlInjected.Address(RVA = "0x14E2FE0", Offset = "0x14E19E0", VA = "0x1814E2FE0")]
		public void Show(Filter currentFilter)
		{
			//Discarded unreachable code: IL_01b2
			//IL_0057: Expected O, but got I4
			if (!_constructed || _skinColorContainer.childCount == 0)
			{
				Construct();
			}
			base.gameObject.SetActive(value: true);
			Transform mcPresetItems = _mcPresetItems;
			KillChildren(mcPresetItems);
			RectTransform subItemlistContent = _subItemlistContent;
			KillChildren(subItemlistContent);
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			int num = 0;
			if (avatarCustomization == (UnityEngine.Object)num)
			{
				return;
			}
			CurrentFilter = currentFilter;
			string text = currentFilter.Name;
			if (text != null)
			{
				string text2 = default(string);
				if (string.Equals(text, "Body"))
				{
					AvatarCustomization.ZoomOut();
					SelectColorPanel mcColorPanel = _mcColorPanel;
					text2 = currentFilter.Name;
					mcColorPanel.Show(text2);
				}
				string text3 = default(string);
				if (text2 != null)
				{
					AvatarCustomization.ZoomInTowardsTargetPoint();
					SelectColorPanel mcColorPanel2 = _mcColorPanel;
					text3 = currentFilter.Name;
					mcColorPanel2.Show(text3);
				}
				while (text3 != null)
				{
				}
				while (text3 != null)
				{
				}
			}
			AvatarCustomization.ZoomInTowardsTargetPoint();
			GameObject gameObject = _mcAvatarColorContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _mcAvatarSecondaryColorContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _mcAvataHairColorContent.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			_mcColorPanel.Hide();
			string text4 = currentFilter.Name;
			bool flag = default(bool);
			if (!flag)
			{
				if (!string.Equals(currentFilter.Name, "Body"))
				{
					if (!string.Equals(currentFilter.Name, "Hairstyle"))
					{
						AvatarAppearance avatarAppearance = Avatar;
					}
					PopulateHairStyle();
				}
				bool _003CIsMale_003Ek__BackingField = Avatar.IsMale;
				PopulateBodyShapes(_003CIsMale_003Ek__BackingField);
			}
			AvatarAppearance avatarAppearance2 = Avatar;
			RefreshLayout();
			_mcAvatarItemsScrollRect.verticalNormalizedPosition = 1f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FAF")]
		[Cpp2IlInjected.Address(RVA = "0x14DAEF0", Offset = "0x14D98F0", VA = "0x1814DAEF0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_004e
			//IL_0022: Expected O, but got I4
			bool flag = TryCloseColorPopup();
			_mcColorPanel.Hide();
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			int num = 0;
			if (avatarCustomization != (UnityEngine.Object)num)
			{
				AvatarCustomization.ZoomOut();
			}
			RefreshLayout();
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB0")]
		[Cpp2IlInjected.Address(RVA = "0x14E2250", Offset = "0x14E0C50", VA = "0x1814E2250")]
		private void SetEyeColor(int index)
		{
			//Discarded unreachable code: IL_0031
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			bool forceSave = _currentEyeColor != index;
			avatarCustomization.SetEyeColor(index, forceSave);
			_currentEyeColor = index;
			RefreshSelectedEyeColor();
			bool flag = TryCloseColorPopup();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB1")]
		[Cpp2IlInjected.Address(RVA = "0x14E0820", Offset = "0x14DF220", VA = "0x1814E0820")]
		private void RefreshLayout()
		{
			//Discarded unreachable code: IL_0057
			//IL_0023: Expected O, but got I4
			_subItemlistContent.RebuildLayout();
			Transform parent = _subItemlistContent.parent;
			int num = 0;
			if ((object)parent != null)
			{
			}
			((RectTransform)num).RebuildLayout();
			if ((object)_subItemlistContent.parent.parent != null)
			{
			}
			if ((object)_mcPresetItems != null)
			{
			}
			if ((object)_mcPresetItems.parent != null)
			{
			}
			if ((object)_content == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB2")]
		[Cpp2IlInjected.Address(RVA = "0x14E0B50", Offset = "0x14DF550", VA = "0x1814E0B50")]
		private void RefreshSelectedEyeColor()
		{
			//Discarded unreachable code: IL_005f, IL_0065, IL_006b, IL_0071, IL_0083
			//IL_002a: Expected O, but got I4
			int num = 0;
			IEnumerator enumerator = _eyeColorContainer.GetEnumerator();
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				WadrobeAppearanceColorItem wadrobeAppearanceColorItem = default(WadrobeAppearanceColorItem);
				if (!(wadrobeAppearanceColorItem == (UnityEngine.Object)num4))
				{
					int currentEyeColor = Avatar.GetCurrentEyeColor();
					bool flag2 = (wadrobeAppearanceColorItem.IsSelected = num == currentEyeColor);
					num++;
				}
				num++;
			}
			num++;
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB3")]
		[Cpp2IlInjected.Address(RVA = "0x14E2A50", Offset = "0x14E1450", VA = "0x1814E2A50")]
		private void SetHairHighlightColor(int index, bool reset = false)
		{
			//Discarded unreachable code: IL_0031
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			bool forceSave = _currentHairHighlightColor != index;
			avatarCustomization.SetHairHightlightColor(index, forceSave);
			_currentHairHighlightColor = index;
			RefreshSelectedHighlightColor();
			bool flag = TryCloseColorPopup();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB4")]
		[Cpp2IlInjected.Address(RVA = "0x14E12E0", Offset = "0x14DFCE0", VA = "0x1814E12E0")]
		private void RefreshSelectedHighlightColor()
		{
			//Discarded unreachable code: IL_003d, IL_0043, IL_0049, IL_005b
			IEnumerator enumerator;
			int num;
			do
			{
				num = 0;
				enumerator = _secondaryColorButtonContainer.GetEnumerator();
			}
			while (enumerator == null);
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			int num3 = 0;
			if (enumerator != null)
			{
				int num4 = 0;
				if (enumerator != null)
				{
					bool flag = default(bool);
					while (!flag)
					{
					}
					if (_currentHairHighlightColor != 0)
					{
						int num5 = 0;
					}
					return;
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB5")]
		[Cpp2IlInjected.Address(RVA = "0x14E2F30", Offset = "0x14E1930", VA = "0x1814E2F30")]
		public void SetSkinColor(int skinColorIndex)
		{
			//Discarded unreachable code: IL_0036
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			bool forceSave = _currentSkinColor != skinColorIndex;
			avatarCustomization.SetSkinColor(skinColorIndex, forceSave).FireAndForgetTask();
			_currentSkinColor = skinColorIndex;
			RefreshSelectedSkinColor();
			bool flag = TryCloseColorPopup();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB6")]
		[Cpp2IlInjected.Address(RVA = "0x14E1730", Offset = "0x14E0130", VA = "0x1814E1730")]
		private void RefreshSelectedSkinColor()
		{
			//Discarded unreachable code: IL_005d, IL_0063, IL_0069, IL_006f, IL_0081
			//IL_002a: Expected O, but got I4
			int num = 0;
			IEnumerator enumerator = _skinColorContainer.GetEnumerator();
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				WadrobeAppearanceColorItem wadrobeAppearanceColorItem = default(WadrobeAppearanceColorItem);
				if (!(wadrobeAppearanceColorItem == (UnityEngine.Object)num4))
				{
					bool flag2 = (wadrobeAppearanceColorItem.IsSelected = Avatar.GetCurrentSkinColorIndex() == wadrobeAppearanceColorItem.Index);
				}
				num++;
			}
			num++;
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB7")]
		[Cpp2IlInjected.Address(RVA = "0x14DE550", Offset = "0x14DCF50", VA = "0x1814DE550")]
		public unsafe void Populate(FacePartType? facePartType, bool isMale)
		{
			//IL_0041: Expected I4, but got I8
			//IL_0083: Expected I4, but got I8
			//IL_0189: Expected O, but got I4
			//IL_019d: Expected O, but got I4
			//IL_03ef: Expected I4, but got I8
			//IL_04b6: Expected I4, but got I8
			ulong num2 = default(ulong);
			ulong num3 = default(ulong);
			bool active2 = default(bool);
			FacePartType _003CFacePartType_003Ek__BackingField = default(FacePartType);
			Func<ITagData, bool> func = default(Func<ITagData, bool>);
			TagItemType tagItemType = default(TagItemType);
			bool active3 = default(bool);
			IEnumerable<> enumerable = default(IEnumerable<>);
			Predicate<MakeupItemData> predicate = default(Predicate<MakeupItemData>);
			ulong num16 = default(ulong);
			ITagData tagData = default(ITagData);
			int order = default(int);
			Client client = default(Client);
			IEnumerable<> enumerable2 = default(IEnumerable<>);
			string displayName = default(string);
			ulong num18 = default(ulong);
			ITagData tagData2 = default(ITagData);
			int order2 = default(int);
			while (true)
			{
				int num = 0;
				FacePartType? facePartType2 = facePartType;
				if ((object)facePartType == null)
				{
					GameObject gameObject = _mcPresetHeader.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					_tfCategoryEmpty.gameObject.SetActive((byte)num2 != 0);
					Filter filter = CurrentFilter;
				}
				bool flag = (object)facePartType == null;
				if ((IntPtr)(void*)facePartType == (IntPtr)(flag ? 1 : 0))
				{
					GameObject gameObject2 = _mcPresetHeader.gameObject;
				}
				_mcPresetHeaderText.StringID = "menu.avatar_category_eyes";
				_mcPresetHeader.gameObject.SetActive((byte)num3 != 0);
				AvatarAppearance avatarAppearance = Avatar;
				_tfCategoryEmpty.gameObject.SetActive(active2);
				FacePresetItem original = facePresetPrefab;
				Transform mcPresetItems = _mcPresetItems;
				FacePresetItem facePresetItem = UnityEngine.Object.Instantiate(original, mcPresetItems);
				Transform transform = facePresetItem.transform;
				float z = UnityEngine.Vector3.zero.z;
				Transform transform2 = facePresetItem.transform;
				float z2 = UnityEngine.Vector3.one.z;
				_003C_003Ec__DisplayClass105_0 CS_0024_003C_003E8__locals0;
				_003C_003Ec__DisplayClass105_0 _003C_003Ec__DisplayClass105_ = CS_0024_003C_003E8__locals0;
				facePresetItem.FacePartType = _003CFacePartType_003Ek__BackingField;
				AvatarAppearance avatarAppearance2 = Avatar;
				int index = num;
				Button.ButtonClickedEvent onClick = facePresetItem._button.ButtonComponent.m_OnClick;
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_000d
					WardrobeAppearanceContent wardrobeAppearanceContent = this;
				};
				int num4 = 0;
				onClick.AddListener(call);
				AvatarWorkingCopy currentAvatar = Avatar.CurrentAvatar;
				FacePartType _003CFacePartType_003Ek__BackingField2 = facePresetItem.FacePartType;
				bool isSelected = currentAvatar.CurrentFaceType(_003CFacePartType_003Ek__BackingField2) == facePresetItem.Index;
				int num5 = 0;
				facePresetItem.IsSelected = isSelected;
				num++;
				int num6 = 0;
				int num7 = 0;
				List<DynamicFilterItemData> subFilterList = (List<DynamicFilterItemData>)num5;
				RectTransform subItemlistContent = _subItemlistContent;
				int num8 = 0;
				if (subItemlistContent != (UnityEngine.Object)num8)
				{
					IEnumerable<ITagData> allTagsData = (IEnumerable<ITagData>)ItemDatabase.Instance.get_AllTagsData();
					if (_003C_003Ec._003C_003E9__105_1 == null)
					{
						func = (Func<ITagData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ITagData x) => tagItemType == TagItemType.MakeupType));
					}
					List<ITagData> makeupTagList = (List<ITagData>)(object)Enumerable.ToList<ITagData>(Enumerable.Where<ITagData>((IEnumerable<>)allTagsData, (Func<, >)(object)func));
					GameObject gameObject3 = _subItemlistContent.gameObject;
					List<DynamicFilterItemData> list = subFilterList;
					gameObject3.SetActive(active3);
					List<ITagData> list2 = makeupTagList;
					Func<ITagData, bool> func2 = (Func<ITagData, bool>)(object)(Func<T, TResult>)delegate(ITagData x)
					{
						//Discarded unreachable code: IL_0034
						List<DynamicFilterItemData> list5 = subFilterList;
						Func<DynamicFilterItemData, bool> func5 = (Func<DynamicFilterItemData, bool>)(object)(Func<T, TResult>)delegate(DynamicFilterItemData subFilter)
						{
							//Discarded unreachable code: IL_0014
							//IL_0014: Expected I4, but got O
							string text = subFilter.Name;
							ITagData tagData3 = x;
							return (byte)(int)typeof(IItemData).TypeHandle != 0;
						};
						return Enumerable.Count<DynamicFilterItemData>(Enumerable.Where<DynamicFilterItemData>((IEnumerable<>)list5, (Func<, >)(object)func5)) != 0;
					};
					makeupTagList = (List<ITagData>)(object)Enumerable.ToList<ITagData>(Enumerable.Where<ITagData>((IEnumerable<>)list2, (Func<, >)(object)func2));
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					bool _003CIsMale_003Ek__BackingField = Avatar.IsMale;
					List<MakeupItemData> list3 = (List<MakeupItemData>)(object)this.FilterGender(enumerable, _003CIsMale_003Ek__BackingField);
					ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
					ListInventory makeup = Avatar.CurrentProfile.Makeup;
					IEnumerable<MakeupItemData> ownedMakeup = (IEnumerable<MakeupItemData>)ItemDatabaseExtensions.GetOwnedMakeup(_003CInstance_003Ek__BackingField2, makeup);
					bool _003CIsMale_003Ek__BackingField2 = Avatar.IsMale;
					List<MakeupItemData> ownedItems = (List<MakeupItemData>)(object)this.FilterGender((IEnumerable<>)ownedMakeup, _003CIsMale_003Ek__BackingField2);
					int i = num;
					int num9 = i;
					Func<MakeupItemData, bool> func3 = (Func<MakeupItemData, bool>)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
					List<MakeupItemData> list4 = (List<MakeupItemData>)(object)Enumerable.ToList<MakeupItemData>(Enumerable.Where<MakeupItemData>((IEnumerable<>)list3, (Func<, >)(object)func3));
					if (func3 == null)
					{
					}
					int num10 = ((List<T>)(object)list4).RemoveAll((Predicate<>)(object)predicate);
					GameObject subListItemPrefab = _subListItemPrefab;
					RectTransform subItemlistContent2 = _subItemlistContent;
					GameObject gameObject4 = UnityEngine.Object.Instantiate(subListItemPrefab, subItemlistContent2);
					WardrobeSubFilterItemList component = gameObject4.GetComponent<WardrobeSubFilterItemList>();
					int num11 = i;
					int num12 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
					AvatarAppearance avatarAppearance3 = Avatar;
					if (i == num)
					{
						int num13 = 0;
						MenuStack menuStack = UiRoot.Instance._menuStack;
						int num14 = 0;
						if (menuStack.Top != null)
						{
							int num15 = 0;
						}
						((LayoutGroup)gameObject4.GetComponent<WardrobeSubFilterItemList>()._gridLayout).m_Padding.top = 10;
						GameObject header = gameObject4.GetComponent<WardrobeSubFilterItemList>().Header;
						int active4 = 0;
						header.SetActive((byte)active4 != 0);
					}
				}
				if (CurrentFilter.Name != null)
				{
					_mcPresetHeaderText.StringID = "menu.avatar_category_facialhair";
					if (_subItemlistContent.childCount > 0)
					{
						RectTransform subItemlistContent3 = _subItemlistContent;
						int index2 = 0;
						subItemlistContent3.GetChild(index2).GetComponent<WardrobeSubFilterItemList>().Header.SetActive((byte)num16 != 0);
					}
					HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
					TagFilter item = new TagFilter(tagData, order);
					order = 0;
					bool flag2 = ((HashSet<T>)(object)hashSet).Add((T)item);
					Profile profile = client.Profile;
					Func<ClothingItemData, bool> func4 = (Func<ClothingItemData, bool>)(object)(Func<T, TResult>)delegate(ClothingItemData x)
					{
						//Discarded unreachable code: IL_0018
						ProfilePlayer player_ = profile.player_;
						int iD = x.ID;
						int num20 = default(int);
						return num20 > 0;
					};
					ClothingItemData[] array = Enumerable.Where<ClothingItemData>(enumerable2, (Func<, >)(object)func4).ToArray<ClothingItemData>();
					int num17 = 0;
					ClothingItemData[] array2 = (ClothingItemData[])(object)((List<T>)(object)FilterUtil.Filter<ClothingItemData>((IEnumerable<>)(object)array, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num17)).ToArray();
					if (array2.Length != num)
					{
						GameObject subListItemPrefab2 = _subListItemPrefab;
						RectTransform subItemlistContent4 = _subItemlistContent;
						GameObject gameObject5 = UnityEngine.Object.Instantiate(subListItemPrefab2, subItemlistContent4);
						WardrobeSubFilterItemList component2 = gameObject5.GetComponent<WardrobeSubFilterItemList>();
						Mdl.Avatar.AvatarCustomization avatarCustomization2 = AvatarCustomization;
						AvatarAppearance avatar = Avatar;
						component2.SetData(array2, avatar, avatarCustomization2, displayName);
						gameObject5.GetComponent<WardrobeSubFilterItemList>().Header.SetActive((byte)num18 != 0);
						Transform transform3 = gameObject5.transform;
						int siblingIndex = 0;
						transform3.SetSiblingIndex(siblingIndex);
					}
					HashSet<Filter> hashSet2 = (HashSet<Filter>)(object)new HashSet<T>();
					TagFilter item2 = new TagFilter(tagData2, order2);
					order2 = 0;
					bool flag3 = ((HashSet<T>)(object)hashSet2).Add((T)item2);
					int num19 = 0;
					if (((List<T>)(object)FilterUtil.Filter<ClothingItemData>((IEnumerable<>)(object)array, (IEnumerable<>)hashSet2, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num19)).ToArray().Length != num)
					{
						/*Error: Could not find block for branch target IL_050a*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB8")]
		[Cpp2IlInjected.Address(RVA = "0x14D9C80", Offset = "0x14D8680", VA = "0x1814D9C80")]
		private List<MakeupItemData> FilterGender(IEnumerable<MakeupItemData> items, bool isMale)
		{
			if (!isMale)
			{
				if (_003C_003Ec._003C_003E9__106_1 != null)
				{
					goto IL_003c;
				}
				Func<MakeupItemData, bool> func = (Func<MakeupItemData, bool>)(object)(Func<T, TResult>)delegate(MakeupItemData m)
				{
					if (m == null)
					{
					}
					string femaleMakeupAddress_ = m.femaleMakeupAddress_;
					return m == null;
				};
			}
			Func<MakeupItemData, bool> func2 = default(Func<MakeupItemData, bool>);
			if (_003C_003Ec._003C_003E9__106_0 == null)
			{
				func2 = (Func<MakeupItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MakeupItemData m)
				{
					if (m == null)
					{
					}
					string maleMakeupAddress_ = m.maleMakeupAddress_;
					return m == null;
				});
			}
			goto IL_003c;
			IL_003c:
			return (List<MakeupItemData>)(object)Enumerable.ToList<MakeupItemData>(Enumerable.Where<MakeupItemData>((IEnumerable<>)items, (Func<, >)(object)func2));
		}

		[Cpp2IlInjected.Token(Token = "0x6002FB9")]
		[Cpp2IlInjected.Address(RVA = "0x14DDF10", Offset = "0x14DC910", VA = "0x1814DDF10")]
		private void PopulateHairStyle()
		{
			//Discarded unreachable code: IL_019b
			//IL_002e: Expected I4, but got I8
			_mcPresetHeaderText.StringID = "menu.avatar_category_hairstyle";
			ulong num = default(ulong);
			_mcPresetHeader.gameObject.SetActive((byte)num != 0);
			Profile profile = SystemRoot.Instance.Client.Profile;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Func<ClothingItemData, bool> func = (Func<ClothingItemData, bool>)(object)(Func<T, TResult>)delegate(ClothingItemData x)
			{
				//Discarded unreachable code: IL_0018
				ProfilePlayer player_ = profile.player_;
				int iD = x.ID;
				int num4 = default(int);
				return num4 > 0;
			};
			IEnumerable<> enumerable = default(IEnumerable<>);
			ClothingItemData[] array = Enumerable.Where<ClothingItemData>(enumerable, (Func<, >)(object)func).ToArray<ClothingItemData>();
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			ITagData tagData = default(ITagData);
			int order = default(int);
			TagFilter item = new TagFilter(tagData, order);
			order = 0;
			bool flag = ((HashSet<T>)(object)hashSet).Add((T)item);
			int num2 = 0;
			ClothingItemData[] array2 = (ClothingItemData[])(object)((List<T>)(object)FilterUtil.Filter<ClothingItemData>((IEnumerable<>)(object)array, (IEnumerable<>)hashSet, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num2)).ToArray();
			GameObject gameObject = _tfCategoryEmpty.gameObject;
			bool active = array2.Length == 0;
			gameObject.SetActive(active);
			int num3 = 0;
			int length = array2.Length;
			if (num3 < length)
			{
				ClothingItemData clothingItem = array2[num3];
				FtueClothingItem original = hairStyleItemPrefab;
				Transform mcPresetItems = _mcPresetItems;
				FtueClothingItem hairItem = UnityEngine.Object.Instantiate(original, mcPresetItems);
				hairItem.ClothingItem = clothingItem;
				AvatarAppearance avatarAppearance = Avatar;
				FtueClothingItem ftueClothingItem = hairItem;
				bool flag2 = (ftueClothingItem.IsMale = avatarAppearance.IsMale);
				hairItem.Refresh();
				Button.ButtonClickedEvent onClick = hairItem.Button.m_OnClick;
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_001b
					WardrobeAppearanceContent wardrobeAppearanceContent = this;
					FtueClothingItem instance = hairItem;
					wardrobeAppearanceContent.SelectCloth(instance);
				};
				onClick.AddListener(call);
				FtueClothingItem item2 = hairItem;
				RefreshSelected(item2);
				num3++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FBA")]
		[Cpp2IlInjected.Address(RVA = "0x14E2060", Offset = "0x14E0A60", VA = "0x1814E2060")]
		private void SelectCloth(FtueClothingItem instance)
		{
			//Discarded unreachable code: IL_002e
			int iD = instance.ClothingItem.ID;
			bool flag = default(bool);
			if (flag)
			{
				ClothingItemType clothingItemType = default(ClothingItemType);
				int num = (int)clothingItemType;
				bool flag2 = default(bool);
				if (flag2)
				{
					Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
					RefreshSelectedItems();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FBB")]
		[Cpp2IlInjected.Address(RVA = "0x14E06F0", Offset = "0x14DF0F0", VA = "0x1814E06F0")]
		public void RefreshAll()
		{
			//Discarded unreachable code: IL_0089
			RefreshSelectedSubItems();
			RefreshSelectedItems();
			RefreshSelectedFacePresets();
			RefreshSelectedEyeColor();
			RefreshSelectedSkinColor();
			RefreshSelectedHairColor();
			RefreshSelectedHighlightColor();
			Transform mcPresetItems = _mcPresetItems;
			int num = 0;
			int childCount = mcPresetItems.childCount;
			if (num < childCount)
			{
				BaseWardrobeItem component = _mcPresetItems.GetChild(num).transform.GetComponent<BaseWardrobeItem>();
				int currentBodyTypeIndex = Avatar.GetCurrentBodyTypeIndex();
				bool flag2 = (component.IsSelected = num == currentBodyTypeIndex);
				Transform mcPresetItems2 = _mcPresetItems;
				num++;
			}
			_genderPanel.RefreshToggles();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FBC")]
		[Cpp2IlInjected.Address(RVA = "0x14E0A50", Offset = "0x14DF450", VA = "0x1814E0A50")]
		public void RefreshSelectedBodyTypes()
		{
			//Discarded unreachable code: IL_006c
			AvatarAppearance avatarAppearance = Avatar;
			if (avatarAppearance.IsMale)
			{
			}
			List<AvatarAppearance.BodyType> femaleBodyTypes = avatarAppearance.femaleBodyTypes;
			int currentBodyTypeIndex = avatarAppearance.GetCurrentBodyTypeIndex();
			AvatarAppearance.BodyType bodyType = Enumerable.ElementAtOrDefault<AvatarAppearance.BodyType>((IEnumerable<>)femaleBodyTypes, currentBodyTypeIndex);
			BodyShapePresetItem[] componentsInChildren = _mcPresetItems.GetComponentsInChildren<BodyShapePresetItem>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				BodyShapePresetItem bodyShapePresetItem = componentsInChildren[num];
				bool flag2 = (bodyShapePresetItem.IsSelected = bodyShapePresetItem.BodyType == bodyType);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FBD")]
		[Cpp2IlInjected.Address(RVA = "0x14E19B0", Offset = "0x14E03B0", VA = "0x1814E19B0")]
		public void RefreshSelectedSubItems()
		{
			//Discarded unreachable code: IL_003d, IL_0043, IL_0055
			int num = 0;
			WardrobeSubFilterItemList wardrobeSubFilterItemList = default(WardrobeSubFilterItemList);
			if (_subItemlistContent.GetEnumerator() != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num += 328;
				int num3 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				wardrobeSubFilterItemList.RefreshSelected();
			}
			if ((object)wardrobeSubFilterItemList == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FBE")]
		[Cpp2IlInjected.Address(RVA = "0x14E1530", Offset = "0x14DFF30", VA = "0x1814E1530")]
		public void RefreshSelectedItems()
		{
			//Discarded unreachable code: IL_003b, IL_004d
			//IL_0027: Expected O, but got I4
			IEnumerator enumerator = _mcPresetItems.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				FtueClothingItem ftueClothingItem = default(FtueClothingItem);
				flag = ftueClothingItem != (UnityEngine.Object)num3;
				while (!flag)
				{
				}
				RefreshSelected(ftueClothingItem);
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FBF")]
		[Cpp2IlInjected.Address(RVA = "0x14E0960", Offset = "0x14DF360", VA = "0x1814E0960")]
		private void RefreshSelectedBodyType()
		{
			//Discarded unreachable code: IL_005f
			Transform mcPresetItems = _mcPresetItems;
			int num = 0;
			int childCount = mcPresetItems.childCount;
			if (num < childCount)
			{
				BaseWardrobeItem component = _mcPresetItems.GetChild(num).transform.GetComponent<BaseWardrobeItem>();
				int currentBodyTypeIndex = Avatar.GetCurrentBodyTypeIndex();
				bool flag2 = (component.IsSelected = num == currentBodyTypeIndex);
				Transform mcPresetItems2 = _mcPresetItems;
				num++;
			}
			_genderPanel.RefreshToggles();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC0")]
		[Cpp2IlInjected.Address(RVA = "0x14E1BD0", Offset = "0x14E05D0", VA = "0x1814E1BD0")]
		private void RefreshSelected(FtueClothingItem item)
		{
			//Discarded unreachable code: IL_0022
			AvatarAppearance avatarAppearance = Avatar;
			int iD = item.ClothingItem.ID;
			bool isSelected = default(bool);
			item.IsSelected = isSelected;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)item).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC1")]
		[Cpp2IlInjected.Address(RVA = "0x14DDA80", Offset = "0x14DC480", VA = "0x1814DDA80")]
		public void PopulateBodyShapes(bool isMale)
		{
			//Discarded unreachable code: IL_013c, IL_0142, IL_0148, IL_014e, IL_0154, IL_015a, IL_0160, IL_0166
			//IL_008b: Expected O, but got I4
			bool active = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				AvatarAppearance avatarAppearance = Avatar;
				if (!isMale)
				{
				}
				List<AvatarAppearance.BodyType> maleBodyTypes = avatarAppearance.maleBodyTypes;
				if (maleBodyTypes == null)
				{
					break;
				}
				_mcPresetHeaderText.StringID = "menu.avatar_presets";
				_mcPresetHeader.gameObject.SetActive(value: true);
				_tfCategoryEmpty.gameObject.SetActive(active);
				int currentBodyTypeIndex = Avatar.GetCurrentBodyTypeIndex();
				AvatarAppearance.BodyType bodyType = Enumerable.ElementAtOrDefault<AvatarAppearance.BodyType>((IEnumerable<>)maleBodyTypes, currentBodyTypeIndex);
				if (flag)
				{
					AvatarAppearance.BodyType preset = (AvatarAppearance.BodyType)num2;
					BodyShapePresetItem original = bodyShapeItemPrefab;
					Transform mcPresetItems = _mcPresetItems;
					BodyShapePresetItem bodyShapePresetItem = UnityEngine.Object.Instantiate(original, mcPresetItems);
					Transform transform = bodyShapePresetItem.transform;
					float z = UnityEngine.Vector3.zero.z;
					Transform transform2 = bodyShapePresetItem.transform;
					float z2 = UnityEngine.Vector3.one.z;
					AvatarAppearance.BodyType data = preset;
					bodyShapePresetItem.Init(data);
					Button.ButtonClickedEvent onClick = bodyShapePresetItem._button.ButtonComponent.m_OnClick;
					UnityAction call = delegate
					{
						//Discarded unreachable code: IL_0016
						WardrobeAppearanceContent wardrobeAppearanceContent = this;
						AvatarAppearance.BodyType bodyType2 = preset;
						wardrobeAppearanceContent.SelectBodyPreset(bodyType2);
					};
					onClick.AddListener(call);
					bool flag3 = (bodyShapePresetItem.IsSelected = preset == bodyType);
				}
				num3++;
				if (bodyType == null)
				{
					if (num3 == 0)
					{
					}
					break;
				}
			}
			GameObject gameObject = default(GameObject);
			gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC2")]
		[Cpp2IlInjected.Address(RVA = "0x14E21B0", Offset = "0x14E0BB0", VA = "0x1814E21B0")]
		public void SelectFaceType(FacePartType facePartType, int index)
		{
			//Discarded unreachable code: IL_0014
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			RefreshSelectedFacePresets();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC3")]
		[Cpp2IlInjected.Address(RVA = "0x14E0E30", Offset = "0x14DF830", VA = "0x1814E0E30")]
		private void RefreshSelectedFacePresets()
		{
			//Discarded unreachable code: IL_0064, IL_006a, IL_0070, IL_0076, IL_0088
			//IL_0027: Expected O, but got I4
			IEnumerator enumerator = _mcPresetItems.GetEnumerator();
			int num4 = default(int);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				FacePresetItem facePresetItem = default(FacePresetItem);
				if (!(facePresetItem == (UnityEngine.Object)num3))
				{
					AvatarWorkingCopy currentAvatar = Avatar.CurrentAvatar;
					FacePartType _003CFacePartType_003Ek__BackingField = facePresetItem.FacePartType;
					num4 = currentAvatar.CurrentFaceType(_003CFacePartType_003Ek__BackingField);
					bool flag2 = (facePresetItem.IsSelected = num4 == facePresetItem.Index);
				}
			}
			if (num4 == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC4")]
		[Cpp2IlInjected.Address(RVA = "0x14E0DE0", Offset = "0x14DF7E0", VA = "0x1814E0DE0")]
		private void RefreshSelectedFaceItem(FacePresetItem item)
		{
			//Discarded unreachable code: IL_002b
			AvatarWorkingCopy currentAvatar = Avatar.CurrentAvatar;
			FacePartType _003CFacePartType_003Ek__BackingField = item.FacePartType;
			bool flag2 = (item.IsSelected = currentAvatar.CurrentFaceType(_003CFacePartType_003Ek__BackingField) == item.Index);
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC5")]
		[Cpp2IlInjected.Address(RVA = "0x14E1D10", Offset = "0x14E0710", VA = "0x1814E1D10")]
		public void SelectBodyPreset(AvatarAppearance.BodyType bodyType)
		{
			//Discarded unreachable code: IL_00a8, IL_00ae, IL_00c0
			//IL_0082: Expected O, but got I4
			int num = 0;
			AvatarAppearance avatarAppearance = Avatar;
			if ((avatarAppearance.IsMale ? 1 : 0) == num)
			{
			}
			List<AvatarAppearance.BodyType> maleBodyTypes = avatarAppearance.maleBodyTypes;
			Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
			Predicate<AvatarAppearance.BodyType> predicate = (Predicate<AvatarAppearance.BodyType>)(object)(Predicate<T>)((AvatarAppearance.BodyType x) => x == bodyType);
			int bodyType2 = ((List<T>)(object)maleBodyTypes).FindIndex((Predicate<>)(object)predicate);
			avatarCustomization.SetBodyType(bodyType2).FireAndForgetTask();
			IEnumerator enumerator = _mcPresetItems.GetEnumerator();
			AvatarAppearance.BodyType _003CBodyType_003Ek__BackingField = default(AvatarAppearance.BodyType);
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				BodyShapePresetItem bodyShapePresetItem = default(BodyShapePresetItem);
				if (!(bodyShapePresetItem == (UnityEngine.Object)num4))
				{
					_003CBodyType_003Ek__BackingField = bodyShapePresetItem.BodyType;
					bool flag2 = (bodyShapePresetItem.IsSelected = _003CBodyType_003Ek__BackingField == "{il2cpp field on {'constant16' (constant value of type Cpp2IL.Core.Analysis.ResultModels.FieldPointer)}, offset 0x0}");
				}
			}
			if (_003CBodyType_003Ek__BackingField == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC6")]
		[Cpp2IlInjected.Address(RVA = "0x14DAFC0", Offset = "0x14D99C0", VA = "0x1814DAFC0")]
		private void KillChildren(Transform container)
		{
			//Discarded unreachable code: IL_0049, IL_0055, IL_005b
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			List<Transform> list = (List<Transform>)(object)new List<T>();
			IEnumerator enumerator = container.GetEnumerator();
			int num5 = default(int);
			if (enumerator != null)
			{
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					num3++;
				}
				if (enumerator == null)
				{
					num3 += num3;
				}
				num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
			}
			if (num5 != 0)
			{
			}
			bool flag = default(bool);
			if (flag)
			{
				GameObject obj = default(GameObject);
				UnityEngine.Object.Destroy(obj);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC7")]
		[Cpp2IlInjected.Address(RVA = "0x14E22B0", Offset = "0x14E0CB0", VA = "0x1814E22B0")]
		internal void SetFocus(FocusNavigation focusNavigation, [System.Runtime.InteropServices.Optional] FocusNavigationElement focusGoal)
		{
			//IL_0012: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_01a7: Expected O, but got I4
			//IL_01b2: Expected O, but got I4
			int num;
			bool flag = default(bool);
			GameObject gameObject = default(GameObject);
			GameObject gameObject2 = default(GameObject);
			GameObject gameObject3 = default(GameObject);
			Transform transform = default(Transform);
			GameObject gameObject4 = default(GameObject);
			GameObject gameObject5 = default(GameObject);
			Transform transform2 = default(Transform);
			GameObject gameObject6 = default(GameObject);
			GameObject gameObject7 = default(GameObject);
			GameObject gameObject8 = default(GameObject);
			GameObject gameObject9 = default(GameObject);
			GameObject gameObject10 = default(GameObject);
			Transform transform3 = default(Transform);
			GameObject gameObject11 = default(GameObject);
			GameObject gameObject12 = default(GameObject);
			Transform transform4 = default(Transform);
			GameObject gameObject14 = default(GameObject);
			GameObject gameObject15 = default(GameObject);
			GameObject gameObject16 = default(GameObject);
			GameObject gameObject17 = default(GameObject);
			GameObject gameObject18 = default(GameObject);
			do
			{
				IL_0000:
				num = 0;
				if (flag)
				{
					break;
				}
				int num2 = 0;
				if (focusNavigation == (UnityEngine.Object)num2)
				{
					return;
				}
				int num3 = 0;
				if (focusGoal != (UnityEngine.Object)num3)
				{
					break;
				}
				if (_mcAvatarColorContent.gameObject.activeInHierarchy && _eyeColorContainer.gameObject.activeInHierarchy)
				{
					RectTransform eyeColorContainer = _eyeColorContainer;
					int currentEyeColor = _currentEyeColor;
					Transform child = eyeColorContainer.GetChild(currentEyeColor);
					if ((object)child != null)
					{
						FocusNavigationElement componentInChildren = child.GetComponentInChildren<FocusNavigationElement>();
					}
					int num4 = 0;
					focusNavigation.SetFocus((FocusNavigationElement)num4);
					return;
				}
				if (!focusNavigation.gameObject.activeInHierarchy || gameObject.activeInHierarchy)
				{
				}
				if (gameObject2.activeInHierarchy && gameObject3.activeInHierarchy)
				{
					int num5 = 0;
					while ((object)transform == null)
					{
					}
				}
				if (gameObject4.activeInHierarchy && gameObject5.activeInHierarchy)
				{
					int num6 = 0;
					while ((object)transform2 == null)
					{
					}
				}
				if (!gameObject6.activeSelf && !gameObject7.activeSelf)
				{
					if (gameObject8.activeInHierarchy || gameObject9.activeInHierarchy)
					{
						break;
					}
					if (!gameObject10.activeInHierarchy)
					{
						goto IL_0000;
					}
					int num7 = 0;
					FocusNavigationElement component = transform3.GetComponent<FocusNavigationElement>();
					if (transform3.gameObject.activeInHierarchy || gameObject11.activeInHierarchy)
					{
						break;
					}
					if (gameObject12.activeInHierarchy)
					{
						goto IL_0000;
					}
					int num8 = 0;
					FocusNavigationElement componentInChildren2 = transform4.GetComponentInChildren<FocusNavigationElement>();
					GameObject gameObject13 = transform4.gameObject;
					gameObject10 = gameObject13;
					if (gameObject13.activeInHierarchy || gameObject14.activeInHierarchy)
					{
						break;
					}
					if (gameObject15.activeInHierarchy)
					{
						goto IL_0000;
					}
				}
			}
			while (!gameObject16.activeInHierarchy && !gameObject17.activeInHierarchy && gameObject18.activeInHierarchy);
			focusNavigation.SetFocus((FocusNavigationElement)num);
			int num9 = 0;
			_focusGoal = (FocusNavigationElement)num9;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC8")]
		[Cpp2IlInjected.Address(RVA = "0x14DA0A0", Offset = "0x14D8AA0", VA = "0x1814DA0A0")]
		public int GetMakeupColorMain(MakeupItem item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FC9")]
		[Cpp2IlInjected.Address(RVA = "0x14DA390", Offset = "0x14D8D90", VA = "0x1814DA390")]
		public int GetMakeupColorSecond(MakeupItem item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FCA")]
		[Cpp2IlInjected.Address(RVA = "0x14DA680", Offset = "0x14D9080", VA = "0x1814DA680")]
		public int GetMakeupColorThird(MakeupItem item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FCB")]
		[Cpp2IlInjected.Address(RVA = "0x14D9F80", Offset = "0x14D8980", VA = "0x1814D9F80")]
		private unsafe WardrobeMakeupItem FindWardrobeMakeupItem(int index)
		{
			RectTransform subItemlistContent = _subItemlistContent;
			int num = 0;
			WardrobeSubFilterItemList component = subItemlistContent.GetChild(index).GetComponent<RectTransform>().GetComponent<WardrobeSubFilterItemList>();
			int childCount = component._itemContainer.childCount;
			if (num < childCount)
			{
				if (component._itemContainer.GetChild(num).TryGetComponent<WardrobeMakeupItem>(out *(WardrobeMakeupItem*)num))
				{
				}
				num++;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FCC")]
		[Cpp2IlInjected.Address(RVA = "0x14DA970", Offset = "0x14D9370", VA = "0x1814DA970")]
		public float GetMakeupOpacity(MakeupItem item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002FCD")]
		[Cpp2IlInjected.Address(RVA = "0x14E1C40", Offset = "0x14E0640", VA = "0x1814E1C40")]
		private void ResetToCurrentMakeupSettings()
		{
			//Discarded unreachable code: IL_006e
			MakeupColor makeupColor = _currentMakeupColorToggle.GetComponent<ToggleMakeupColor>().ToggleGroupMakeupColor.MakeupColor;
			int currentMakeupColorMain = _currentMakeupColorMain;
			if (makeupColor.MakeupColorMain != currentMakeupColorMain)
			{
				SetMakeupColorMain(currentMakeupColorMain);
			}
			int makeupColorSecond = makeupColor.MakeupColorSecond;
			if (makeupColorSecond != -1)
			{
				int currentMakeupColorSecond = _currentMakeupColorSecond;
				if (makeupColorSecond != currentMakeupColorSecond)
				{
					SetMakeupColorSecond(currentMakeupColorSecond);
				}
			}
			int makeupColorThird = makeupColor.MakeupColorThird;
			if (makeupColorThird != -1)
			{
				int currentMakeupColorThird = _currentMakeupColorThird;
				if (makeupColorThird != currentMakeupColorThird)
				{
					SetMakeupColorThird(currentMakeupColorThird);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FCE")]
		[Cpp2IlInjected.Address(RVA = "0x14E3AA0", Offset = "0x14E24A0", VA = "0x1814E3AA0")]
		public WardrobeAppearanceContent()
		{
		}
	}
}
