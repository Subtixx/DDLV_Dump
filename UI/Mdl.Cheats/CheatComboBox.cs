using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Ui;
using Rewired;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	public class CheatComboBox : CheatVisualComponent
	{
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		public delegate void ValueChanged(int value);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		[SerializeField]
		private Text _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		[SerializeField]
		private Dropdown _dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		[SerializeField]
		private GameObject _arrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private string[] _values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private int _index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private Player _player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private bool _interactable = true;

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public bool Interactable
		{
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0xA5F820", Offset = "0xA5E220", VA = "0x180A5F820")]
			get
			{
				return _interactable;
			}
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0x1000200", Offset = "0xFFEC00", VA = "0x181000200")]
			set
			{
				//Discarded unreachable code: IL_009c
				//IL_002a: Expected O, but got I4
				//IL_0054: Expected O, but got I4
				//IL_007f: Expected O, but got I4
				Dropdown dropdown = _dropdown;
				_interactable = value;
				dropdown.interactable = value;
				TemplateButton component = _dropdown.GetComponent<TemplateButton>();
				int num = 0;
				if (component != (UnityEngine.Object)num)
				{
					bool flag = (component.IsActivated = _interactable);
				}
				FocusNavigationElement component2 = _dropdown.GetComponent<FocusNavigationElement>();
				int num2 = 0;
				if (component2 != (UnityEngine.Object)num2)
				{
					bool flag2 = (component2.IgnoreThis = !_interactable);
				}
				GameObject arrow = _arrow;
				int num3 = 0;
				if (arrow != (UnityEngine.Object)num3)
				{
					GameObject arrow2 = _arrow;
					bool interactable2 = _interactable;
					arrow2.SetActive(interactable2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public Dropdown Dropdown
		{
			[Cpp2IlInjected.Token(Token = "0x6000903")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _dropdown;
			}
			[Cpp2IlInjected.Token(Token = "0x6000904")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				_dropdown = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event ValueChanged OnValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0x10000C0", Offset = "0xFFEAC0", VA = "0x1810000C0")]
			[CompilerGenerated]
			add
			{
				ValueChanged onValueChanged = this.OnValueChanged;
				Delegate @delegate = Delegate.Combine(onValueChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onValueChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0x1000160", Offset = "0xFFEB60", VA = "0x181000160")]
			[CompilerGenerated]
			remove
			{
				ValueChanged onValueChanged = this.OnValueChanged;
				Delegate @delegate = Delegate.Remove(onValueChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onValueChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0xFFF820", Offset = "0xFFE220", VA = "0x180FFF820")]
		public void Init(string name, int index, string[] values)
		{
			//Discarded unreachable code: IL_0187
			//IL_00fc: Expected I4, but got I8
			//IL_012c: Expected I4, but got I8
			//IL_0159: Expected I4, but got I8
			//IL_0186: Expected I4, but got I8
			base.gameObject.name = name;
			Name = name;
			_name.text = name;
			_values = values;
			Dropdown dropdown = _dropdown;
			_index = index;
			List<Dropdown.OptionData> options = (List<Dropdown.OptionData>)(object)new List<T>();
			dropdown.set_options((List<>)(object)options);
			int num = 0;
			if (values != null)
			{
				int length = values.Length;
			}
			Dropdown dropdown2 = _dropdown;
			bool flag = num < num;
			if (num != (flag ? 1 : 0))
			{
				List<Dropdown.OptionData> options2 = (List<Dropdown.OptionData>)(object)dropdown2.get_options();
				Dropdown.OptionData item = new Dropdown.OptionData(values[num]);
				((List<T>)(object)options2).Add((T)item);
				num++;
			}
			UnityAction<int> unityAction = (UnityAction<int>)(object)new UnityAction<T0>(UpdateValue);
			Dropdown dropdown3 = _dropdown;
			int index2 = _index;
			dropdown3.SetValueWithoutNotify(index2);
			int num2 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = (_player = players.GetPlayer(playerId));
			Player player2 = _player;
			if (player2 == null)
			{
				return;
			}
			Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnScroll);
			int num3 = 0;
			ulong num4 = default(ulong);
			player2.AddInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num3, InputActionEventType.ButtonJustPressed, (int)num4);
			Player player3 = _player;
			if (player3 == null)
			{
				return;
			}
			Action<InputActionEventData> action2 = (Action<InputActionEventData>)(object)new Action<T>(OnScroll);
			int num5 = 0;
			ulong num6 = default(ulong);
			player3.AddInputEventDelegate((Action<>)(object)action2, (UpdateLoopType)num5, InputActionEventType.ButtonJustPressed, (int)num6);
			Player player4 = _player;
			if (player4 != null)
			{
				Action<InputActionEventData> action3 = (Action<InputActionEventData>)(object)new Action<T>(OnScroll);
				int num7 = 0;
				ulong num8 = default(ulong);
				player4.AddInputEventDelegate((Action<>)(object)action3, (UpdateLoopType)num7, InputActionEventType.ButtonJustPressed, (int)num8);
				Player player5 = _player;
				if (player5 != null)
				{
					Action<InputActionEventData> action4 = (Action<InputActionEventData>)(object)new Action<T>(OnScroll);
					int num9 = 0;
					ulong num10 = default(ulong);
					player5.AddInputEventDelegate((Action<>)(object)action4, (UpdateLoopType)num9, InputActionEventType.ButtonJustPressed, (int)num10);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x1000090", Offset = "0xFFEA90", VA = "0x181000090")]
		private void UpdateValue(int index)
		{
			_index = index;
			this.OnValueChanged?.Invoke(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xFFFD30", Offset = "0xFFE730", VA = "0x180FFFD30")]
		private void OnScroll(InputActionEventData data)
		{
			//IL_004e: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			if (!base.gameObject.activeInHierarchy || !base.gameObject.activeSelf)
			{
				return;
			}
			int num = 0;
			GameObject selected = EventSystem.current.m_CurrentSelected;
			GameObject gameObject = selected;
			int num2 = 0;
			if (!(gameObject != (UnityEngine.Object)num2))
			{
				return;
			}
			Transform transform = selected.transform;
			Transform parent = _dropdown.gameObject.transform;
			if (!transform.IsChildOf(parent))
			{
				return;
			}
			List<Dropdown.OptionData> options = (List<Dropdown.OptionData>)(object)_dropdown.get_options();
			Predicate<Dropdown.OptionData> predicate = (Predicate<Dropdown.OptionData>)(object)(Predicate<T>)delegate(Dropdown.OptionData elem)
			{
				GameObject gameObject2 = selected;
				string text = elem.m_Text;
				Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
				if ((object)componentInChildren2 != null)
				{
					string text2 = componentInChildren2.text;
				}
				throw new NullReferenceException();
			};
			int num3 = ((List<T>)(object)options).FindIndex((Predicate<>)(object)predicate);
			Scrollbar componentInChildren = base.gameObject.GetComponentInChildren<Scrollbar>();
			List<Dropdown.OptionData> options2 = (List<Dropdown.OptionData>)(object)_dropdown.get_options();
			int num4 = 0;
			if (componentInChildren != (UnityEngine.Object)num4)
			{
				Dropdown dropdown = _dropdown;
				if (componentInChildren.m_Direction == Scrollbar.Direction.TopToBottom)
				{
					throw new NullReferenceException();
				}
				List<Dropdown.OptionData> options3 = (List<Dropdown.OptionData>)(object)dropdown.get_options();
				float num6 = (componentInChildren.value = Mathf.Max(0.001f, 1f));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0xFFFC90", Offset = "0xFFE690", VA = "0x180FFFC90")]
		private void OnDestroy()
		{
			Player player = _player;
			if (player != null)
			{
				Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnScroll);
				player.RemoveInputEventDelegate((Action<>)(object)action);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x10000B0", Offset = "0xFFEAB0", VA = "0x1810000B0")]
		public CheatComboBox()
		{
		}
	}
}
