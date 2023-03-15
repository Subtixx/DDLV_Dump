using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003F7")]
	public class DecalColorPicker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003F8")]
		public delegate void ColorChanged(Color color);

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001380")]
		public List<Color> ColorPallet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001381")]
		public WadrobeAppearanceColorItem colorPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001382")]
		public FocusNavigation FocusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001383")]
		public TextBase tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001384")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001385")]
		private bool _isInit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001386")]
		private WadrobeAppearanceColorItem _selectedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001387")]
		private ISupportsFocusNavigation _focusedElementOrigin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001388")]
		public bool isShown;

		[Cpp2IlInjected.Token(Token = "0x1700042E")]
		public virtual Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600193E")]
			[Cpp2IlInjected.Address(RVA = "0x1024660", Offset = "0x1023060", VA = "0x181024660", Slot = "4")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600193F")]
			[Cpp2IlInjected.Address(RVA = "0x10247E0", Offset = "0x10231E0", VA = "0x1810247E0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042F")]
		public RectTransform Content
		{
			[Cpp2IlInjected.Token(Token = "0x6001940")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return _mcContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event ColorChanged OnColorChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6001938")]
			[Cpp2IlInjected.Address(RVA = "0x155AF00", Offset = "0x1559900", VA = "0x18155AF00")]
			[CompilerGenerated]
			add
			{
				ColorChanged onColorChanged = this.OnColorChanged;
				Delegate @delegate = Delegate.Combine(onColorChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onColorChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001939")]
			[Cpp2IlInjected.Address(RVA = "0x155B0E0", Offset = "0x1559AE0", VA = "0x18155B0E0")]
			[CompilerGenerated]
			remove
			{
				ColorChanged onColorChanged = this.OnColorChanged;
				Delegate @delegate = Delegate.Remove(onColorChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onColorChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event ColorChanged OnColorHighlightAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600193A")]
			[Cpp2IlInjected.Address(RVA = "0x155AFA0", Offset = "0x15599A0", VA = "0x18155AFA0")]
			[CompilerGenerated]
			add
			{
				ColorChanged onColorHighlightAdded = this.OnColorHighlightAdded;
				Delegate @delegate = Delegate.Combine(onColorHighlightAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onColorHighlightAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600193B")]
			[Cpp2IlInjected.Address(RVA = "0x155B180", Offset = "0x1559B80", VA = "0x18155B180")]
			[CompilerGenerated]
			remove
			{
				ColorChanged onColorHighlightAdded = this.OnColorHighlightAdded;
				Delegate @delegate = Delegate.Remove(onColorHighlightAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onColorHighlightAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event ColorChanged OnColorHighlightRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x600193C")]
			[Cpp2IlInjected.Address(RVA = "0x155B040", Offset = "0x1559A40", VA = "0x18155B040")]
			[CompilerGenerated]
			add
			{
				ColorChanged onColorHighlightRemoved = this.OnColorHighlightRemoved;
				Delegate @delegate = Delegate.Combine(onColorHighlightRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onColorHighlightRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600193D")]
			[Cpp2IlInjected.Address(RVA = "0x155B220", Offset = "0x1559C20", VA = "0x18155B220")]
			[CompilerGenerated]
			remove
			{
				ColorChanged onColorHighlightRemoved = this.OnColorHighlightRemoved;
				Delegate @delegate = Delegate.Remove(onColorHighlightRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onColorHighlightRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001941")]
		[Cpp2IlInjected.Address(RVA = "0x155A850", Offset = "0x1559250", VA = "0x18155A850")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00ec
			if (!_isInit)
			{
				List<Color> colorPallet = ColorPallet;
				int num = 0;
				List<Color> colorPallet2 = ColorPallet;
				int num2 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				WadrobeAppearanceColorItem original = colorPrefab;
				RectTransform mcContent = _mcContent;
				WadrobeAppearanceColorItem wadrobeAppearanceColorItem = UnityEngine.Object.Instantiate(original, mcContent);
				Color color = default(Color);
				Color color2 = color;
				wadrobeAppearanceColorItem.RefreshColor(color2, num);
				Button.ButtonClickedEvent onClick = wadrobeAppearanceColorItem.Button.ButtonComponent.m_OnClick;
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_002b
					DecalColorPicker decalColorPicker3 = this;
					Color color6 = (decalColorPicker3.Color = color);
					DecalColorPicker decalColorPicker4 = this;
					Color color7 = color;
					decalColorPicker4.RaiseColorChanged(color7);
				};
				onClick.AddListener(call);
				UnityEvent onHighlightAdded = wadrobeAppearanceColorItem.Button.OnHighlightAdded;
				UnityAction call2 = delegate
				{
					//Discarded unreachable code: IL_0016
					DecalColorPicker decalColorPicker2 = this;
					Color color4 = color;
					decalColorPicker2.RaiseColorHighlightAdded(color4);
				};
				onHighlightAdded.AddListener(call2);
				UnityEvent onHighlightRemoved = wadrobeAppearanceColorItem.Button.OnHighlightRemoved;
				UnityAction call3 = delegate
				{
					//Discarded unreachable code: IL_0016
					DecalColorPicker decalColorPicker = this;
					Color color3 = color;
					decalColorPicker.RaiseColorHighlightRemoved(color3);
				};
				onHighlightRemoved.AddListener(call3);
				List<Color> colorPallet3 = ColorPallet;
				num++;
				_isInit = true;
			}
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001942")]
		[Cpp2IlInjected.Address(RVA = "0x155A780", Offset = "0x1559180", VA = "0x18155A780")]
		private void OnDisable()
		{
			//IL_0010: Expected O, but got I4
			FocusNavigation focusNavigation = FocusNavigation;
			int num = 0;
			if (focusNavigation != (UnityEngine.Object)num)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
				FocusNavigation focusNavigation2 = FocusNavigation;
				if (flag)
				{
					goto IL_0049;
				}
				ISupportsFocusNavigation supportsFocusNavigation = (focusNavigation2.FocusedElement = _focusedElementOrigin);
			}
			int num3 = 0;
			goto IL_0049;
			IL_0049:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001943")]
		[Cpp2IlInjected.Address(RVA = "0x155AB90", Offset = "0x1559590", VA = "0x18155AB90")]
		internal void RefreshSelected(Color color)
		{
			//Discarded unreachable code: IL_0068
			//IL_0009: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			int num = 0;
			_selectedColor = (WadrobeAppearanceColorItem)num;
			int childCount = _mcContent.childCount;
			if (num >= childCount)
			{
				return;
			}
			WadrobeAppearanceColorItem component = _mcContent.GetChild(num).GetComponent<WadrobeAppearanceColorItem>();
			int num2 = 0;
			if (component != (UnityEngine.Object)num2)
			{
				Color color2 = component.Color;
				bool isSelected = default(bool);
				component.IsSelected = isSelected;
				Color color3 = component.Color;
				bool flag = default(bool);
				if (flag)
				{
					_selectedColor = component;
				}
			}
			RectTransform mcContent = _mcContent;
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001944")]
		[Cpp2IlInjected.Address(RVA = "0x155AD20", Offset = "0x1559720", VA = "0x18155AD20")]
		internal void SetFocus()
		{
			//Discarded unreachable code: IL_0082
			//IL_0010: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			FocusNavigation focusNavigation = FocusNavigation;
			int num = 0;
			if (!(focusNavigation != (UnityEngine.Object)num))
			{
				return;
			}
			ISupportsFocusNavigation supportsFocusNavigation = (_focusedElementOrigin = FocusNavigation._focusedElement);
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNavigation2 = FocusNavigation;
				WadrobeAppearanceColorItem selectedColor = _selectedColor;
				int num3 = 0;
				if (selectedColor != (UnityEngine.Object)num3)
				{
				}
				RectTransform mcContent = _mcContent;
				int index = 0;
				FocusNavigationElement component = mcContent.GetChild(index).GetComponent<FocusNavigationElement>();
				focusNavigation2.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001945")]
		[Cpp2IlInjected.Address(RVA = "0x155A780", Offset = "0x1559180", VA = "0x18155A780")]
		internal void RemoveFocus()
		{
			//IL_0010: Expected O, but got I4
			FocusNavigation focusNavigation = FocusNavigation;
			int num = 0;
			if (focusNavigation != (UnityEngine.Object)num)
			{
				int num2 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
				FocusNavigation focusNavigation2 = FocusNavigation;
				if (flag)
				{
					goto IL_0049;
				}
				ISupportsFocusNavigation supportsFocusNavigation = (focusNavigation2.FocusedElement = _focusedElementOrigin);
			}
			int num3 = 0;
			goto IL_0049;
			IL_0049:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001946")]
		[Cpp2IlInjected.Address(RVA = "0x155A550", Offset = "0x1558F50", VA = "0x18155A550")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0044, IL_004a, IL_0050, IL_0056, IL_0068
			//IL_0027: Expected O, but got I4
			BaseButton baseButton = default(BaseButton);
			Button buttonComponent = default(Button);
			while (true)
			{
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num = 0;
					if (enumerator == null)
					{
						break;
					}
					int num2 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num3 = 0;
					if (!(baseButton != (UnityEngine.Object)num3))
					{
						continue;
					}
					buttonComponent = baseButton.ButtonComponent;
					buttonComponent.m_OnClick.RemoveAllListeners();
				}
				if ((object)buttonComponent == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001947")]
		[Cpp2IlInjected.Address(RVA = "0x1150A00", Offset = "0x114F400", VA = "0x181150A00")]
		protected void RaiseColorChanged(Color color)
		{
			if (this.OnColorChanged == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001948")]
		[Cpp2IlInjected.Address(RVA = "0x155AB30", Offset = "0x1559530", VA = "0x18155AB30")]
		protected void RaiseColorHighlightAdded(Color color)
		{
			if (this.OnColorHighlightAdded == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001949")]
		[Cpp2IlInjected.Address(RVA = "0x155AB60", Offset = "0x1559560", VA = "0x18155AB60")]
		protected void RaiseColorHighlightRemoved(Color color)
		{
			if (this.OnColorHighlightRemoved == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600194A")]
		[Cpp2IlInjected.Address(RVA = "0x155AE70", Offset = "0x1559870", VA = "0x18155AE70")]
		public DecalColorPicker()
		{
			Color white = Color.white;
			ColorPallet = (List<Color>)(object)new List<T>();
			base._002Ector();
		}
	}
}
