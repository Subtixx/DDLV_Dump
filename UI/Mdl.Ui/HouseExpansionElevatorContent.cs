using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200052D")]
	public class HouseExpansionElevatorContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001BE8")]
		private HouseExpansionMenu _menu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001BE9")]
		private int _numberOfFloorsInTheHouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001BEA")]
		private int _currentFloorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001BEB")]
		private Action<int> _chooseFloorDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001BEC")]
		[SerializeField]
		private AnimatedButton _floorPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001BED")]
		[SerializeField]
		private BaseButton _btnExpand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001BEE")]
		[SerializeField]
		private RectTransform _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001BEF")]
		[SerializeField]
		private ScrollRect _floorScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001BF0")]
		[SerializeField]
		private RectTransform _floorContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001BF1")]
		private AnimatedButton _lastSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001BF2")]
		private bool _isConstructed;

		[Cpp2IlInjected.Token(Token = "0x60021A2")]
		[Cpp2IlInjected.Address(RVA = "0xAEB8E0", Offset = "0xAEA2E0", VA = "0x180AEB8E0")]
		public void Init(HouseExpansionMenu menu, int numberOfFloorsInTheHouse, int currentFloorIndex, Action<int> chooseFloorDelegate)
		{
			//Discarded unreachable code: IL_00af, IL_0111, IL_01bd, IL_01dd, IL_01f6
			//IL_0010: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0174: Expected O, but got I4
			int num = 0;
			_menu = menu;
			_chooseFloorDelegate = (Action<int>)0;
			_numberOfFloorsInTheHouse = numberOfFloorsInTheHouse;
			_currentFloorIndex = currentFloorIndex;
			RectTransform mcContent = _mcContent;
			int num2 = 0;
			Vector2 sizeDelta = mcContent.sizeDelta;
			mcContent.sizeDelta = (Vector2)num2;
			GameObject gameObject = _floorContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			LayoutRebuilder.ForceRebuildLayoutImmediate(_floorScroll.m_Content);
			int num3 = 0;
			AnimatedButton floorPrefab = _floorPrefab;
			RectTransform floorContent = _floorContent;
			AnimatedButton floor = UnityEngine.Object.Instantiate(floorPrefab, floorContent);
			TextBase label = floor.Label;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021A3")]
		[Cpp2IlInjected.Address(RVA = "0xAEB790", Offset = "0xAEA190", VA = "0x180AEB790")]
		private void FloorClickedHandler(AnimatedButton floorButton, int floorIndex)
		{
			//Discarded unreachable code: IL_0077
			//IL_0010: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			AnimatedButton lastSelected = _lastSelected;
			int num = 0;
			if (lastSelected != (UnityEngine.Object)num)
			{
				_lastSelected.IsActive = true;
				AnimatedButton lastSelected2 = _lastSelected;
				int num2 = ((lastSelected2.isSelected = false) ? 1 : 0);
			}
			int num3 = ((floorButton.IsActive = false) ? 1 : 0);
			_lastSelected.isSelected = true;
			_lastSelected = floorButton;
			((Action<T>)(object)_chooseFloorDelegate)?.Invoke((T)floorIndex);
			_menu?.PopSelf();
		}

		[Cpp2IlInjected.Token(Token = "0x60021A4")]
		[Cpp2IlInjected.Address(RVA = "0xAEBF00", Offset = "0xAEA900", VA = "0x180AEBF00")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			if (focusNavigation._focusedElement == null)
			{
			}
			int num = 0;
			if (!_isConstructed)
			{
				return;
			}
			bool flag = default(bool);
			if (!flag)
			{
				Transform parent = base.transform;
				Transform transform = default(Transform);
				if (transform.IsChildOf(parent))
				{
					return;
				}
			}
			if (_floorScroll.gameObject.activeSelf && _floorContent.childCount > 0)
			{
				RectTransform floorContent = _floorContent;
				int index = 0;
				Transform child = floorContent.GetChild(index);
				FocusNavigationElement component = default(FocusNavigationElement);
				if ((object)child != null)
				{
					component = child.GetComponent<FocusNavigationElement>();
				}
				focusNavigation.SetFocus(component);
				return;
			}
			FocusNavigationElement component2 = focusNavigation.GetComponent<FocusNavigationElement>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021A5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HouseExpansionElevatorContent()
		{
		}
	}
}
