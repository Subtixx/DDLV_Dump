using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200035D")]
	public class NavigationBar : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001045")]
		[SerializeField]
		private RectTransform _buttonsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001046")]
		[SerializeField]
		private RectTransform _selectedButtonBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001047")]
		[SerializeField]
		private NavigationBarButton _navigationBarButtonPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001048")]
		private List<(NavigationBarButton button, Action action)> _buttons = (List<(NavigationBarButton button, Action action)>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001049")]
		private int _selectedIndex = -1;

		[Cpp2IlInjected.Token(Token = "0x170003B7")]
		public List<(NavigationBarButton button, Action action)> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x6001582")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _buttons;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001583")]
		[Cpp2IlInjected.Address(RVA = "0x12990C0", Offset = "0x1297AC0", VA = "0x1812990C0")]
		public void Init(Dictionary<string, Action> buttonsConfig, int selectedTab = 0)
		{
			//Discarded unreachable code: IL_008b, IL_0091, IL_0097, IL_009d, IL_00a3, IL_00a9, IL_00af
			//IL_008a: Expected O, but got I4
			GameObject gameObject = _selectedButtonBackground.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			bool flag = default(bool);
			if (flag)
			{
				NavigationBarButton navigationBarButtonPrefab = _navigationBarButtonPrefab;
				RectTransform buttonsHolder = _buttonsHolder;
				NavigationBarButton item;
				NavigationBarButton navigationBarButton = (item = UnityEngine.Object.Instantiate(navigationBarButtonPrefab, buttonsHolder));
				TextBase text = navigationBarButton._text;
				UnityEvent onSelected = navigationBarButton.OnSelected;
				UnityAction call = delegate
				{
					//Discarded unreachable code: IL_0016
					NavigationBar navigationBar = this;
					NavigationBarButton button = item;
					navigationBar.Select(button);
				};
				onSelected.AddListener(call);
				List<(NavigationBarButton, Action)> buttons = _buttons;
				int num = 0;
				((List<T>)(object)buttons).Add((T)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001584")]
		[Cpp2IlInjected.Address(RVA = "0x1299780", Offset = "0x1298180", VA = "0x181299780")]
		public void Select(NavigationBarButton button)
		{
			//Discarded unreachable code: IL_003c
			NavigationBarButton navigationBarButton = button;
			List<(NavigationBarButton, Action)> buttons = _buttons;
			bool result = default(bool);
			Predicate<(NavigationBarButton, Action)> predicate = (Predicate<(NavigationBarButton, Action)>)(object)(Predicate<T>)(((NavigationBarButton button, Action action) x) => result);
			int index = ((List<T>)(object)buttons).FindIndex((Predicate<>)(object)predicate);
			bool flag = Select(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6001585")]
		[Cpp2IlInjected.Address(RVA = "0x1299460", Offset = "0x1297E60", VA = "0x181299460")]
		private bool IsValidIndex(int index)
		{
			//Discarded unreachable code: IL_000b
			int num = 0;
			List<(NavigationBarButton, Action)> buttons = _buttons;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001586")]
		[Cpp2IlInjected.Address(RVA = "0x1299630", Offset = "0x1298030", VA = "0x181299630")]
		public bool Select(int index)
		{
			List<(NavigationBarButton, Action)> buttons = _buttons;
			List<(NavigationBarButton, Action)> buttons2 = _buttons;
			if (index != _selectedIndex)
			{
				int num = 0;
				_selectedIndex = index;
				int num2 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				bool flag = num == _selectedIndex;
				List<(NavigationBarButton, Action)> buttons3 = _buttons;
				num++;
				int selectedIndex = _selectedIndex;
				int num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				if (num3 + num3 == 0)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001587")]
		[Cpp2IlInjected.Address(RVA = "0x12994C0", Offset = "0x1297EC0", VA = "0x1812994C0")]
		public void SelectNext()
		{
			//Discarded unreachable code: IL_0032
			List<(NavigationBarButton, Action)> buttons = _buttons;
			int selectedIndex = _selectedIndex;
			selectedIndex++;
			bool flag = default(bool);
			if (flag)
			{
				List<(NavigationBarButton, Action)> buttons2 = _buttons;
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				if (num + num == 0)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001588")]
		[Cpp2IlInjected.Address(RVA = "0x1299570", Offset = "0x1297F70", VA = "0x181299570")]
		public void SelectPrevious()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001589")]
		[Cpp2IlInjected.Address(RVA = "0x12998A0", Offset = "0x12982A0", VA = "0x1812998A0")]
		public NavigationBar()
		{
		}//IL_001d: Expected I4, but got I8

	}
}
