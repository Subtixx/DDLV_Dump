using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000999")]
	public class FilterItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200099A")]
		public delegate void Clicked(FilterItem button);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003898")]
		public Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003899")]
		public Transform AnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400389A")]
		public GameObject FullBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400389B")]
		public SpriteAtlasImage bg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400389C")]
		public SpriteAtlasImage AlternateBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400389D")]
		public bool ShowSelected = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400389E")]
		public TextBase text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400389F")]
		[SerializeField]
		private GameObject Decoration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40038A0")]
		[SerializeField]
		protected GameObject SelectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40038A1")]
		[SerializeField]
		protected GameObject HighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40038A2")]
		[SerializeField]
		protected GameObject SelectedHighlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40038A3")]
		[SerializeField]
		private GameObject SelectedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40038A4")]
		[SerializeField]
		private AK.Wwise.Event _selectSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40038A5")]
		[SerializeField]
		private AK.Wwise.Event _deselectSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40038A6")]
		public Clicked OnClicked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40038A8")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40038A9")]
		private float _oY;

		[Cpp2IlInjected.Token(Token = "0x17000855")]
		public Filter Filter
		{
			[Cpp2IlInjected.Token(Token = "0x6003C51")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			[CompilerGenerated]
			get
			{
				return _003CFilter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C52")]
			[Cpp2IlInjected.Address(RVA = "0xAE8630", Offset = "0xAE7030", VA = "0x180AE8630")]
			[CompilerGenerated]
			protected set
			{
				_003CFilter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000856")]
		public bool isSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003C53")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0F0", Offset = "0xA8CAF0", VA = "0x180A8E0F0")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C54")]
			[Cpp2IlInjected.Address(RVA = "0x1536860", Offset = "0x1535260", VA = "0x181536860")]
			set
			{
				_isSelected = value;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C55")]
		[Cpp2IlInjected.Address(RVA = "0x15361F0", Offset = "0x1534BF0", VA = "0x1815361F0", Slot = "4")]
		public virtual void Init(Filter filter, bool showText)
		{
			//Discarded unreachable code: IL_00c8
			//IL_0070: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			Filter = filter;
			GameObject gameObject = this.text.gameObject;
			int num = 0;
			gameObject.SetActive(showText);
			if ((object)filter != null)
			{
				int num2 = 0;
				int num3 = 0;
				if ((object)filter != null)
				{
					int num4 = 0;
					int num5 = 0;
					uint num6 = default(uint);
					if (num3 < (int)num6)
					{
						num3 += num3;
						num3++;
					}
					num3 += 360;
				}
			}
			TextBase textBase = this.text;
			string text = (textBase.StringID = filter.DisplayName);
			Button button = this.button;
			int num7 = 0;
			if (button != (Object)num7)
			{
				Button.ButtonClickedEvent onClick = this.button.m_OnClick;
				UnityAction call = Click;
				onClick.AddListener(call);
			}
			Transform animatedContent = AnimatedContent;
			int num8 = 0;
			if (animatedContent != (Object)num8)
			{
				Transform animatedContent2 = AnimatedContent;
				Vector3 vector = default(Vector3);
				float num9 = (_oY = vector.y);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C56")]
		[Cpp2IlInjected.Address(RVA = "0x1536110", Offset = "0x1534B10", VA = "0x181536110")]
		internal void Click()
		{
			//Discarded unreachable code: IL_0071
			if (!ShowSelected)
			{
				BaseButton component = GetComponent<BaseButton>();
				if ((object)component == null)
				{
					goto IL_003c;
				}
				component.PostWwiseEvent();
			}
			int num = 0;
			if ((_isSelected ? 1 : 0) != num)
			{
			}
			AK.Wwise.Event selectSFX = _selectSFX;
			GameObject gameObject = base.gameObject;
			uint num2 = selectSFX.Post(gameObject);
			goto IL_003c;
			IL_003c:
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				RemoveHighlight();
			}
			OnClicked?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C57")]
		[Cpp2IlInjected.Address(RVA = "0x15364F0", Offset = "0x1534EF0", VA = "0x1815364F0", Slot = "5")]
		protected virtual void RefreshSelected()
		{
			//Discarded unreachable code: IL_00e6
			//IL_0010: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			while (true)
			{
				GameObject selectedIcon = SelectedIcon;
				int num = 0;
				bool flag = selectedIcon != (Object)num;
				int num2 = 0;
				if (flag)
				{
					GameObject selectedIcon2 = SelectedIcon;
					if ((_isSelected ? 1 : 0) != num2)
					{
					}
					bool active = num2 != 0;
					selectedIcon2.SetActive(active);
				}
				GameObject selectedBg = SelectedBg;
				int num3 = 0;
				if (selectedBg != (Object)num3)
				{
					GameObject selectedBg2 = SelectedBg;
					if ((_isSelected ? 1 : 0) == num2)
					{
						continue;
					}
					bool active2 = ShowSelected;
					selectedBg2.SetActive(active2);
				}
				GameObject selectedHighlightBg = SelectedHighlightBg;
				int num4 = 0;
				if (selectedHighlightBg != (Object)num4)
				{
					GameObject decoration = Decoration;
					int num5 = 0;
					if (decoration != (Object)num5 && Decoration.gameObject.activeInHierarchy)
					{
						GameObject selectedHighlightBg2 = SelectedHighlightBg;
						if ((_isSelected ? 1 : 0) != num2)
						{
							bool active3 = ShowSelected;
							selectedHighlightBg2.SetActive(active3);
							break;
						}
						continue;
					}
					break;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C58")]
		[Cpp2IlInjected.Address(RVA = "0x1535F30", Offset = "0x1534930", VA = "0x181535F30", Slot = "6")]
		public virtual void AddHighlight()
		{
			//Discarded unreachable code: IL_00cb
			//IL_0010: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_00a5: Expected O, but got I4
			Transform animatedContent = AnimatedContent;
			int num = 0;
			if (animatedContent != (Object)num)
			{
				Transform animatedContent2 = AnimatedContent;
				int complete = 0;
				int num2 = DOTween.Kill(animatedContent2, (byte)complete != 0);
				float oY = _oY;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(AnimatedContent, oY, 0.2f, (byte)num3 != 0)).Play();
			}
			GameObject highlightBg = HighlightBg;
			int num4 = 0;
			if (highlightBg != (Object)num4)
			{
				HighlightBg.SetActive(value: true);
			}
			GameObject decoration = Decoration;
			int num5 = 0;
			if (decoration != (Object)num5)
			{
				Decoration.SetActive(value: true);
			}
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int num6 = 0;
			if (selectedHighlightBg != (Object)num6 && _isSelected)
			{
				GameObject selectedHighlightBg2 = SelectedHighlightBg;
				bool showSelected = ShowSelected;
				selectedHighlightBg2.SetActive(showSelected);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C59")]
		[Cpp2IlInjected.Address(RVA = "0x15366A0", Offset = "0x15350A0", VA = "0x1815366A0", Slot = "7")]
		public virtual void RemoveHighlight()
		{
			//Discarded unreachable code: IL_00c9
			//IL_0040: Expected F4, but got I4
			//IL_005b: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			//IL_00b1: Expected O, but got I4
			if ((bool)AnimatedContent)
			{
				Transform animatedContent = AnimatedContent;
				int complete = 0;
				int num = DOTween.Kill(animatedContent, (byte)complete != 0);
				float oY = _oY;
				int num2 = 0;
				Transform animatedContent2 = AnimatedContent;
				int num3 = 0;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOLocalMoveY(animatedContent2, oY, (float)num3, (byte)num2 != 0)).Play();
			}
			GameObject highlightBg = HighlightBg;
			int num4 = 0;
			if (highlightBg != (Object)num4)
			{
				GameObject highlightBg2 = HighlightBg;
				int active = 0;
				highlightBg2.SetActive((byte)active != 0);
			}
			GameObject decoration = Decoration;
			int num5 = 0;
			if (decoration != (Object)num5)
			{
				GameObject decoration2 = Decoration;
				int active2 = 0;
				decoration2.SetActive((byte)active2 != 0);
			}
			GameObject selectedHighlightBg = SelectedHighlightBg;
			int num6 = 0;
			if (selectedHighlightBg != (Object)num6)
			{
				GameObject selectedHighlightBg2 = SelectedHighlightBg;
				int active3 = 0;
				selectedHighlightBg2.SetActive((byte)active3 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C5A")]
		[Cpp2IlInjected.Address(RVA = "0x86CF20", Offset = "0x86B920", VA = "0x18086CF20")]
		public FilterItem()
		{
		}
	}
}
