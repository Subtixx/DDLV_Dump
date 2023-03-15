using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000761")]
	[RequiredAllNotNull]
	public class SelectColorPanel : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000762")]
		public delegate void EyeColorPanelToggle(bool isShown);

		[Cpp2IlInjected.Token(Token = "0x2000763")]
		public delegate void HairColorPanelToggle(bool isShown);

		[Cpp2IlInjected.Token(Token = "0x2000764")]
		public delegate void HairHighlightColorPanelToggle(bool isShown);

		[Cpp2IlInjected.Token(Token = "0x2000765")]
		public delegate void SkinColorPanelToggle(bool isShown);

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B32")]
		[SerializeField]
		private Toggle _toggleEyeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B33")]
		[SerializeField]
		private Toggle _toggleHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002B34")]
		[SerializeField]
		private Toggle _toggleSkinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002B35")]
		[SerializeField]
		private Toggle _toggleHairHighlightColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002B36")]
		[SerializeField]
		private ToggleGroup _toggleGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002B39")]
		private bool _constructed;

		[Cpp2IlInjected.Token(Token = "0x170006B9")]
		public Toggle ToggleEyeColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F43")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _toggleEyeColor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BA")]
		public Toggle ToggleHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F44")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _toggleHairColor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BB")]
		public Toggle ToggleSkinColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F45")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return _toggleSkinColor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BC")]
		public Toggle ToggleHairHighlightColor
		{
			[Cpp2IlInjected.Token(Token = "0x6002F46")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return _toggleHairHighlightColor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BD")]
		public AvatarCustomization AvatarCustomization
		{
			[Cpp2IlInjected.Token(Token = "0x6002F47")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CAvatarCustomization_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F48")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CAvatarCustomization_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006BE")]
		public AvatarAppearance Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6002F49")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			[CompilerGenerated]
			get
			{
				return _003CAvatar_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F4A")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			[CompilerGenerated]
			set
			{
				_003CAvatar_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400004F")]
		public event EyeColorPanelToggle OnEyeColorPanelToggle
		{
			[Cpp2IlInjected.Token(Token = "0x6002F3B")]
			[Cpp2IlInjected.Address(RVA = "0x125AB40", Offset = "0x1259540", VA = "0x18125AB40")]
			[CompilerGenerated]
			add
			{
				EyeColorPanelToggle onEyeColorPanelToggle = this.OnEyeColorPanelToggle;
				Delegate @delegate = Delegate.Combine(onEyeColorPanelToggle, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEyeColorPanelToggle)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002F3C")]
			[Cpp2IlInjected.Address(RVA = "0x125ADC0", Offset = "0x12597C0", VA = "0x18125ADC0")]
			[CompilerGenerated]
			remove
			{
				EyeColorPanelToggle onEyeColorPanelToggle = this.OnEyeColorPanelToggle;
				Delegate @delegate = Delegate.Remove(onEyeColorPanelToggle, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEyeColorPanelToggle)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000050")]
		public event HairColorPanelToggle OnHairColorPanelToggle
		{
			[Cpp2IlInjected.Token(Token = "0x6002F3D")]
			[Cpp2IlInjected.Address(RVA = "0x125ABE0", Offset = "0x12595E0", VA = "0x18125ABE0")]
			[CompilerGenerated]
			add
			{
				HairColorPanelToggle onHairColorPanelToggle = this.OnHairColorPanelToggle;
				Delegate @delegate = Delegate.Combine(onHairColorPanelToggle, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onHairColorPanelToggle)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002F3E")]
			[Cpp2IlInjected.Address(RVA = "0x125AE60", Offset = "0x1259860", VA = "0x18125AE60")]
			[CompilerGenerated]
			remove
			{
				HairColorPanelToggle onHairColorPanelToggle = this.OnHairColorPanelToggle;
				Delegate @delegate = Delegate.Remove(onHairColorPanelToggle, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onHairColorPanelToggle)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000051")]
		public event HairHighlightColorPanelToggle OnHairHighlightColorPanelToggle
		{
			[Cpp2IlInjected.Token(Token = "0x6002F3F")]
			[Cpp2IlInjected.Address(RVA = "0x125AC80", Offset = "0x1259680", VA = "0x18125AC80")]
			[CompilerGenerated]
			add
			{
				HairHighlightColorPanelToggle onHairHighlightColorPanelToggle = this.OnHairHighlightColorPanelToggle;
				Delegate @delegate = Delegate.Combine(onHairHighlightColorPanelToggle, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onHairHighlightColorPanelToggle)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002F40")]
			[Cpp2IlInjected.Address(RVA = "0x125AF00", Offset = "0x1259900", VA = "0x18125AF00")]
			[CompilerGenerated]
			remove
			{
				HairHighlightColorPanelToggle onHairHighlightColorPanelToggle = this.OnHairHighlightColorPanelToggle;
				Delegate @delegate = Delegate.Remove(onHairHighlightColorPanelToggle, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onHairHighlightColorPanelToggle)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000052")]
		public event SkinColorPanelToggle OnSkinColorPanelToggle
		{
			[Cpp2IlInjected.Token(Token = "0x6002F41")]
			[Cpp2IlInjected.Address(RVA = "0x125AD20", Offset = "0x1259720", VA = "0x18125AD20")]
			[CompilerGenerated]
			add
			{
				SkinColorPanelToggle onSkinColorPanelToggle = this.OnSkinColorPanelToggle;
				Delegate @delegate = Delegate.Combine(onSkinColorPanelToggle, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSkinColorPanelToggle)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002F42")]
			[Cpp2IlInjected.Address(RVA = "0x125AFA0", Offset = "0x12599A0", VA = "0x18125AFA0")]
			[CompilerGenerated]
			remove
			{
				SkinColorPanelToggle onSkinColorPanelToggle = this.OnSkinColorPanelToggle;
				Delegate @delegate = Delegate.Remove(onSkinColorPanelToggle, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSkinColorPanelToggle)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F4B")]
		[Cpp2IlInjected.Address(RVA = "0x125A4D0", Offset = "0x1258ED0", VA = "0x18125A4D0")]
		public void Show(string currentFilterName)
		{
			//Discarded unreachable code: IL_0249
			if (!_constructed)
			{
				Toggle toggleEyeColor = _toggleEyeColor;
				_constructed = true;
				Toggle.ToggleEvent onValueChanged = toggleEyeColor.onValueChanged;
				UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnEyeValueChangedHandler);
				((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
				Toggle.ToggleEvent onValueChanged2 = _toggleSkinColor.onValueChanged;
				UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnSkinValueChangedHandler);
				((UnityEvent<T0>)(object)onValueChanged2).AddListener((UnityAction<>)(object)unityAction2);
				Toggle.ToggleEvent onValueChanged3 = _toggleHairHighlightColor.onValueChanged;
				UnityAction<bool> unityAction3 = (UnityAction<bool>)(object)new UnityAction<T0>(OnHairHighlightValueChangedHandler);
				((UnityEvent<T0>)(object)onValueChanged3).AddListener((UnityAction<>)(object)unityAction3);
				Toggle.ToggleEvent onValueChanged4 = _toggleHairColor.onValueChanged;
				UnityAction<bool> unityAction4 = (UnityAction<bool>)(object)new UnityAction<T0>(OnHairValueChangedHandler);
				((UnityEvent<T0>)(object)onValueChanged4).AddListener((UnityAction<>)(object)unityAction4);
			}
			if (currentFilterName != null)
			{
				if (string.Equals(currentFilterName, "Body"))
				{
					_toggleSkinColor.gameObject.SetActive(value: true);
					GameObject gameObject = _toggleEyeColor.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					GameObject gameObject2 = _toggleHairHighlightColor.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
				}
				if (string.Equals(currentFilterName, "Eyes"))
				{
					_toggleEyeColor.gameObject.SetActive(value: true);
					GameObject gameObject3 = _toggleSkinColor.gameObject;
					int active3 = 0;
					gameObject3.SetActive((byte)active3 != 0);
					GameObject gameObject4 = _toggleHairHighlightColor.gameObject;
					int active4 = 0;
					gameObject4.SetActive((byte)active4 != 0);
				}
				if (string.Equals(currentFilterName, "Hairstyle") || string.Equals(currentFilterName, "FacialHair"))
				{
					_toggleHairHighlightColor.gameObject.SetActive(value: true);
					_toggleHairColor.gameObject.SetActive(value: true);
					GameObject gameObject5 = _toggleSkinColor.gameObject;
					int active5 = 0;
					gameObject5.SetActive((byte)active5 != 0);
					GameObject gameObject6 = _toggleEyeColor.gameObject;
					int active6 = 0;
					gameObject6.SetActive((byte)active6 != 0);
				}
			}
			base.gameObject.SetActive(value: true);
			if (base.gameObject.activeInHierarchy)
			{
				BaseWardrobeItem component = _toggleHairHighlightColor.GetComponent<BaseWardrobeItem>();
				int num = ((component.IsSelected = false) ? 1 : 0);
				BaseWardrobeItem component2 = _toggleSkinColor.GetComponent<BaseWardrobeItem>();
				int num2 = ((component2.IsSelected = false) ? 1 : 0);
				BaseWardrobeItem component3 = _toggleHairColor.GetComponent<BaseWardrobeItem>();
				int num3 = ((component3.IsSelected = false) ? 1 : 0);
				BaseWardrobeItem component4 = _toggleEyeColor.GetComponent<BaseWardrobeItem>();
				int num4 = ((component4.IsSelected = false) ? 1 : 0);
				_toggleGroup.SetAllTogglesOff();
			}
			RefreshColor();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F4C")]
		[Cpp2IlInjected.Address(RVA = "0x1259690", Offset = "0x1258090", VA = "0x181259690")]
		private void Construct()
		{
			//Discarded unreachable code: IL_0094
			Toggle toggleEyeColor = _toggleEyeColor;
			_constructed = true;
			Toggle.ToggleEvent onValueChanged = toggleEyeColor.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnEyeValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Toggle.ToggleEvent onValueChanged2 = _toggleSkinColor.onValueChanged;
			UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnSkinValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged2).AddListener((UnityAction<>)(object)unityAction2);
			Toggle.ToggleEvent onValueChanged3 = _toggleHairHighlightColor.onValueChanged;
			UnityAction<bool> unityAction3 = (UnityAction<bool>)(object)new UnityAction<T0>(OnHairHighlightValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged3).AddListener((UnityAction<>)(object)unityAction3);
			Toggle.ToggleEvent onValueChanged4 = _toggleHairColor.onValueChanged;
			UnityAction<bool> unityAction4 = (UnityAction<bool>)(object)new UnityAction<T0>(OnHairValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged4).AddListener((UnityAction<>)(object)unityAction4);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F4D")]
		[Cpp2IlInjected.Address(RVA = "0x1259980", Offset = "0x1258380", VA = "0x181259980")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0089
			Toggle.ToggleEvent onValueChanged = _toggleEyeColor.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnEyeValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Toggle.ToggleEvent onValueChanged2 = _toggleSkinColor.onValueChanged;
			UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnSkinValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged2).RemoveListener((UnityAction<>)(object)unityAction2);
			Toggle.ToggleEvent onValueChanged3 = _toggleHairHighlightColor.onValueChanged;
			UnityAction<bool> unityAction3 = (UnityAction<bool>)(object)new UnityAction<T0>(OnHairHighlightValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged3).RemoveListener((UnityAction<>)(object)unityAction3);
			Toggle.ToggleEvent onValueChanged4 = _toggleHairColor.onValueChanged;
			UnityAction<bool> unityAction4 = (UnityAction<bool>)(object)new UnityAction<T0>(OnHairValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged4).AddListener((UnityAction<>)(object)unityAction4);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F4E")]
		[Cpp2IlInjected.Address(RVA = "0x1259B70", Offset = "0x1258570", VA = "0x181259B70")]
		private void OnEyeValueChangedHandler(bool isShown)
		{
			//Discarded unreachable code: IL_0061
			_toggleEyeColor.GetComponent<BaseWardrobeItem>().IsSelected = isShown;
			BaseWardrobeItem component = _toggleSkinColor.GetComponent<BaseWardrobeItem>();
			int num = ((component.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component2 = _toggleHairHighlightColor.GetComponent<BaseWardrobeItem>();
			int num2 = ((component2.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component3 = _toggleHairColor.GetComponent<BaseWardrobeItem>();
			int num3 = ((component3.IsSelected = false) ? 1 : 0);
			this.OnEyeColorPanelToggle(isShown);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F4F")]
		[Cpp2IlInjected.Address(RVA = "0x1259E70", Offset = "0x1258870", VA = "0x181259E70")]
		private void OnSkinValueChangedHandler(bool isShown)
		{
			//Discarded unreachable code: IL_0061
			_toggleSkinColor.GetComponent<BaseWardrobeItem>().IsSelected = isShown;
			BaseWardrobeItem component = _toggleEyeColor.GetComponent<BaseWardrobeItem>();
			int num = ((component.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component2 = _toggleHairHighlightColor.GetComponent<BaseWardrobeItem>();
			int num2 = ((component2.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component3 = _toggleHairColor.GetComponent<BaseWardrobeItem>();
			int num3 = ((component3.IsSelected = false) ? 1 : 0);
			this.OnSkinColorPanelToggle(isShown);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F50")]
		[Cpp2IlInjected.Address(RVA = "0x1259D70", Offset = "0x1258770", VA = "0x181259D70")]
		private void OnHairValueChangedHandler(bool isShown)
		{
			//Discarded unreachable code: IL_0061
			_toggleHairColor.GetComponent<BaseWardrobeItem>().IsSelected = isShown;
			BaseWardrobeItem component = _toggleSkinColor.GetComponent<BaseWardrobeItem>();
			int num = ((component.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component2 = _toggleHairHighlightColor.GetComponent<BaseWardrobeItem>();
			int num2 = ((component2.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component3 = _toggleEyeColor.GetComponent<BaseWardrobeItem>();
			int num3 = ((component3.IsSelected = false) ? 1 : 0);
			this.OnHairColorPanelToggle(isShown);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F51")]
		[Cpp2IlInjected.Address(RVA = "0x1259C70", Offset = "0x1258670", VA = "0x181259C70")]
		private void OnHairHighlightValueChangedHandler(bool isShown)
		{
			//Discarded unreachable code: IL_0061
			_toggleHairHighlightColor.GetComponent<BaseWardrobeItem>().IsSelected = isShown;
			BaseWardrobeItem component = _toggleSkinColor.GetComponent<BaseWardrobeItem>();
			int num = ((component.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component2 = _toggleHairColor.GetComponent<BaseWardrobeItem>();
			int num2 = ((component2.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component3 = _toggleEyeColor.GetComponent<BaseWardrobeItem>();
			int num3 = ((component3.IsSelected = false) ? 1 : 0);
			this.OnHairHighlightColorPanelToggle(isShown);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F52")]
		[Cpp2IlInjected.Address(RVA = "0x1259870", Offset = "0x1258270", VA = "0x181259870")]
		public void Hide()
		{
			//Discarded unreachable code: IL_007d
			BaseWardrobeItem component = _toggleHairHighlightColor.GetComponent<BaseWardrobeItem>();
			int num = ((component.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component2 = _toggleSkinColor.GetComponent<BaseWardrobeItem>();
			int num2 = ((component2.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component3 = _toggleHairColor.GetComponent<BaseWardrobeItem>();
			int num3 = ((component3.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component4 = _toggleEyeColor.GetComponent<BaseWardrobeItem>();
			int num4 = ((component4.IsSelected = false) ? 1 : 0);
			_toggleGroup.SetAllTogglesOff();
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F53")]
		[Cpp2IlInjected.Address(RVA = "0x125AA50", Offset = "0x1259450", VA = "0x18125AA50")]
		public void ToggleAllOff()
		{
			//Discarded unreachable code: IL_0069
			BaseWardrobeItem component = _toggleHairHighlightColor.GetComponent<BaseWardrobeItem>();
			int num = ((component.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component2 = _toggleSkinColor.GetComponent<BaseWardrobeItem>();
			int num2 = ((component2.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component3 = _toggleHairColor.GetComponent<BaseWardrobeItem>();
			int num3 = ((component3.IsSelected = false) ? 1 : 0);
			BaseWardrobeItem component4 = _toggleEyeColor.GetComponent<BaseWardrobeItem>();
			int num4 = ((component4.IsSelected = false) ? 1 : 0);
			_toggleGroup.SetAllTogglesOff();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F54")]
		[Cpp2IlInjected.Address(RVA = "0x1259F70", Offset = "0x1258970", VA = "0x181259F70")]
		public void RefreshColor()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002F55")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SelectColorPanel()
		{
		}
	}
}
