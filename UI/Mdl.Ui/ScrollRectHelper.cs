using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000888")]
	public class ScrollRectHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400327F")]
		[SerializeField]
		private GameObject[] _alternateTopFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003280")]
		[SerializeField]
		private GridLayoutGroup[] _gridLayoutGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003281")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003282")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003283")]
		private Coroutine _setup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003284")]
		private Coroutine _slide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003285")]
		private int _firstRowLastIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4003286")]
		private int _lastRowFirstIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003287")]
		private int _firstActiveGrid = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4003288")]
		private int _lastActiveGrid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003289")]
		private int _altIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400328A")]
		private float _lastvalue = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400328B")]
		private float _requestedValue = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400328C")]
		private float _currentValue = -1f;

		[Cpp2IlInjected.Token(Token = "0x1700078F")]
		private float CurrentValue
		{
			[Cpp2IlInjected.Token(Token = "0x60035E3")]
			[Cpp2IlInjected.Address(RVA = "0x823E70", Offset = "0x822870", VA = "0x180823E70")]
			get
			{
				return _currentValue;
			}
			[Cpp2IlInjected.Token(Token = "0x60035E4")]
			[Cpp2IlInjected.Address(RVA = "0x1259640", Offset = "0x1258040", VA = "0x181259640")]
			set
			{
				//Discarded unreachable code: IL_002e
				_currentValue = value;
				_scrollRect.verticalNormalizedPosition = value;
				Scrollbar verticalScrollbar = _scrollRect.m_VerticalScrollbar;
				float num = (verticalScrollbar.value = _currentValue);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035E5")]
		[Cpp2IlInjected.Address(RVA = "0x1259380", Offset = "0x1257D80", VA = "0x181259380")]
		private void OnEnable()
		{
			int _003C_003E1__state = default(int);
			_003CSetupCoroutine_003Ed__18 _003CSetupCoroutine_003Ed__ = new _003CSetupCoroutine_003Ed__18(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSetupCoroutine_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = (_setup = StartCoroutine(_003CSetupCoroutine_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035E6")]
		[Cpp2IlInjected.Address(RVA = "0x1259410", Offset = "0x1257E10", VA = "0x181259410")]
		[IteratorStateMachine(typeof(_003CSetupCoroutine_003Ed__18))]
		private IEnumerator SetupCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CSetupCoroutine_003Ed__18 _003CSetupCoroutine_003Ed__ = new _003CSetupCoroutine_003Ed__18(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSetupCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035E7")]
		[Cpp2IlInjected.Address(RVA = "0x12594F0", Offset = "0x1257EF0", VA = "0x1812594F0")]
		private void ValueChange(Vector2 arg0)
		{
			//Discarded unreachable code: IL_0072
			//IL_0048: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			FocusNavigationElement sideMenuElement;
			int num3;
			do
			{
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
				{
					if ((long)_focusNavigation._focusedElement != 0 && (IsInAlt() || IsInFirst() || IsInLast()))
					{
						int num2 = 0;
						FocusChange((ISupportsFocusNavigation)num2);
						return;
					}
					sideMenuElement = GetSideMenuElement();
					num3 = 0;
					continue;
				}
				return;
			}
			while (!(sideMenuElement != (UnityEngine.Object)num3));
			float num4 = (_lastvalue = _requestedValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60035E8")]
		[Cpp2IlInjected.Address(RVA = "0x1259210", Offset = "0x1257C10", VA = "0x181259210")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_007b
			//IL_0034: Expected O, but got I4
			Coroutine setup = _setup;
			if (setup != null)
			{
				StopCoroutine(setup);
			}
			Coroutine slide = _slide;
			if (slide != null)
			{
				StopCoroutine(slide);
			}
			FocusNavigation focusNavigation = _focusNavigation;
			int num = 0;
			if (focusNavigation != (UnityEngine.Object)num)
			{
				FocusNavigation focusNavigation2 = _focusNavigation;
				FocusNavigation.FocusChanged value = FocusChange;
				focusNavigation2.OnFocusChanged -= value;
			}
			ScrollRect.ScrollRectEvent onValueChanged = _scrollRect.m_OnValueChanged;
			UnityAction<Vector2> unityAction = (UnityAction<Vector2>)(object)new UnityAction<T0>(ValueChange);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60035E9")]
		[Cpp2IlInjected.Address(RVA = "0x12588E0", Offset = "0x12572E0", VA = "0x1812588E0")]
		private void FocusChange(ISupportsFocusNavigation menu)
		{
			//Discarded unreachable code: IL_0174
			//IL_0072: Expected O, but got I4
			//IL_0100: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) || (long)_focusNavigation._focusedElement == 0)
			{
				return;
			}
			GridLayoutGroup[] gridLayoutGroup = _gridLayoutGroup;
			if (!IsInFirst())
			{
				return;
			}
			if (!IsInAlt())
			{
				if (AdjustFirstRow() || AdjustLastRow())
				{
					goto IL_010d;
				}
				FocusNavigationElement sideMenuElement = GetSideMenuElement();
				int num2 = 0;
				if (!(sideMenuElement != (UnityEngine.Object)num2))
				{
					goto IL_0102;
				}
				float num3 = (_requestedValue = _lastvalue);
				bool flag = default(bool);
				if (!flag)
				{
					goto IL_00ae;
				}
			}
			ScrollRect scrollRect = _scrollRect;
			float verticalNormalizedPosition = scrollRect.verticalNormalizedPosition;
			if ((object)scrollRect != null)
			{
				_requestedValue = 1f;
				goto IL_00ae;
			}
			goto IL_010d;
			IL_0102:
			_requestedValue = -1f;
			goto IL_010d;
			IL_00e3:
			if (!AdjustFirstRow())
			{
				goto IL_00ec;
			}
			goto IL_010d;
			IL_010d:
			ScrollRect scrollRect2 = _scrollRect;
			float verticalNormalizedPosition2 = scrollRect2.verticalNormalizedPosition;
			if ((object)scrollRect2 != null)
			{
				Coroutine slide = _slide;
				if (slide != null)
				{
					StopCoroutine(slide);
				}
				float num4 = (_currentValue = _scrollRect.verticalNormalizedPosition);
				int _003C_003E1__state = default(int);
				_003CSlide_003Ed__28 _003CSlide_003Ed__ = new _003CSlide_003Ed__28(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CSlide_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = (_slide = StartCoroutine(_003CSlide_003Ed__));
			}
			return;
			IL_00ae:
			if (!IsInFirst() || !IsInLast() || AdjustFirstRow())
			{
				if (IsInFirst())
				{
					goto IL_00e3;
				}
				if (!IsInLast())
				{
					goto IL_00ec;
				}
			}
			bool flag2 = AdjustLastRow();
			goto IL_00e3;
			IL_00ec:
			FocusNavigationElement sideMenuElement2 = GetSideMenuElement();
			int num5 = 0;
			bool flag3 = sideMenuElement2 != (UnityEngine.Object)num5;
			goto IL_0102;
		}

		[Cpp2IlInjected.Token(Token = "0x60035EA")]
		[Cpp2IlInjected.Address(RVA = "0x1258BC0", Offset = "0x12575C0", VA = "0x181258BC0")]
		private FocusNavigationElement GetSideMenuElement()
		{
			//Discarded unreachable code: IL_0017
			int num = 0;
			return UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>().GetSelectedTab();
		}

		[Cpp2IlInjected.Token(Token = "0x60035EB")]
		[Cpp2IlInjected.Address(RVA = "0x1258F30", Offset = "0x1257930", VA = "0x181258F30")]
		private bool IsInFirst()
		{
			//Discarded unreachable code: IL_004b
			if (_focusNavigation._focusedElement == null)
			{
				int num = 0;
			}
			int num2 = 0;
			int num3 = 0;
			GameObject gameObject = default(GameObject);
			Transform parent = gameObject.transform.parent;
			GridLayoutGroup[] gridLayoutGroup = _gridLayoutGroup;
			int firstActiveGrid = _firstActiveGrid;
			Transform transform = gridLayoutGroup[firstActiveGrid].transform;
			return parent == transform;
		}

		[Cpp2IlInjected.Token(Token = "0x60035EC")]
		[Cpp2IlInjected.Address(RVA = "0x12590A0", Offset = "0x1257AA0", VA = "0x1812590A0")]
		private bool IsInLast()
		{
			//Discarded unreachable code: IL_004b
			if (_focusNavigation._focusedElement == null)
			{
				int num = 0;
			}
			int num2 = 0;
			int num3 = 0;
			GameObject gameObject = default(GameObject);
			Transform parent = gameObject.transform.parent;
			GridLayoutGroup[] gridLayoutGroup = _gridLayoutGroup;
			int lastActiveGrid = _lastActiveGrid;
			Transform transform = gridLayoutGroup[lastActiveGrid].transform;
			return parent == transform;
		}

		[Cpp2IlInjected.Token(Token = "0x60035ED")]
		[Cpp2IlInjected.Address(RVA = "0x1258C20", Offset = "0x1257620", VA = "0x181258C20")]
		private bool IsInAlt()
		{
			//Discarded unreachable code: IL_0067, IL_006d, IL_007f
			int num = 0;
			int num2 = 0;
			int altIndex = _altIndex;
			if (altIndex != -1)
			{
				IEnumerator enumerator = _alternateTopFocus[altIndex].transform.GetEnumerator();
				if (enumerator != null)
				{
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num4 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					if (_focusNavigation._focusedElement == null)
					{
					}
					int num5 = 0;
					bool flag = default(bool);
					while (!flag)
					{
					}
					num2++;
				}
				num2++;
				if (num2 != 0)
				{
				}
				if (num2 == 0)
				{
				}
			}
			int num6 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035EE")]
		[Cpp2IlInjected.Address(RVA = "0x12586B0", Offset = "0x12570B0", VA = "0x1812586B0")]
		private bool AdjustFirstRow()
		{
			//Discarded unreachable code: IL_0049
			ISupportsFocusNavigation focusedElement = _focusNavigation._focusedElement;
			int num = 0;
			int num2 = 0;
			GameObject gameObject = default(GameObject);
			if (gameObject.transform.GetSiblingIndex() > _firstRowLastIndex)
			{
				int num3 = 0;
			}
			ScrollRect scrollRect = _scrollRect;
			float verticalNormalizedPosition = scrollRect.verticalNormalizedPosition;
			if ((object)scrollRect != null)
			{
				_requestedValue = 1f;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60035EF")]
		[Cpp2IlInjected.Address(RVA = "0x12587D0", Offset = "0x12571D0", VA = "0x1812587D0")]
		private bool AdjustLastRow()
		{
			//Discarded unreachable code: IL_0049
			ISupportsFocusNavigation focusedElement = _focusNavigation._focusedElement;
			int num = 0;
			int num2 = 0;
			GameObject gameObject = default(GameObject);
			if (gameObject.transform.GetSiblingIndex() < _lastRowFirstIndex)
			{
				int num3 = 0;
			}
			ScrollRect scrollRect = _scrollRect;
			float verticalNormalizedPosition = scrollRect.verticalNormalizedPosition;
			if ((object)scrollRect != null)
			{
				_requestedValue = 0f;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60035F0")]
		[Cpp2IlInjected.Address(RVA = "0x1259480", Offset = "0x1257E80", VA = "0x181259480")]
		[IteratorStateMachine(typeof(_003CSlide_003Ed__28))]
		private IEnumerator Slide()
		{
			int _003C_003E1__state = default(int);
			_003CSlide_003Ed__28 _003CSlide_003Ed__ = new _003CSlide_003Ed__28(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CSlide_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035F1")]
		[Cpp2IlInjected.Address(RVA = "0x1259600", Offset = "0x1258000", VA = "0x181259600")]
		public ScrollRectHelper()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_0012: Expected I4, but got I8
		//IL_0022: Expected I4, but got I8

	}
}
