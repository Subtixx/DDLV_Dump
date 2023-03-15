using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Ui;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	public class ComboBoxTMP : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000176")]
		public delegate void ValueChanged(int value);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		[SerializeField]
		private TMP_Text _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		[SerializeField]
		private TMP_Dropdown _dropdown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		[SerializeField]
		private GameObject _arrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private string[] _values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private int _index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private Player _player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private bool _interactable = true;

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public bool Interactable
		{
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return _interactable;
			}
			[Cpp2IlInjected.Token(Token = "0x6000929")]
			[Cpp2IlInjected.Address(RVA = "0x14A2EA0", Offset = "0x14A18A0", VA = "0x1814A2EA0")]
			set
			{
				//Discarded unreachable code: IL_009c
				//IL_002a: Expected O, but got I4
				//IL_0054: Expected O, but got I4
				//IL_007f: Expected O, but got I4
				TMP_Dropdown dropdown = _dropdown;
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

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public TMP_Dropdown Dropdown
		{
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _dropdown;
			}
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				_dropdown = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event ValueChanged OnValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0x14A2D60", Offset = "0x14A1760", VA = "0x1814A2D60")]
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
			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0x14A2E00", Offset = "0x14A1800", VA = "0x1814A2E00")]
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

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x14A24F0", Offset = "0x14A0EF0", VA = "0x1814A24F0")]
		public void Init(string name, int index, string[] values)
		{
			//Discarded unreachable code: IL_0174
			//IL_00e9: Expected I4, but got I8
			//IL_0119: Expected I4, but got I8
			//IL_0146: Expected I4, but got I8
			//IL_0173: Expected I4, but got I8
			_name.text = name;
			_values = values;
			_index = index;
			TMP_Dropdown dropdown = _dropdown;
			List<TMP_Dropdown.OptionData> options = (List<TMP_Dropdown.OptionData>)(object)new List<T>();
			dropdown.set_options((List<>)(object)options);
			int num = 0;
			if (values != null)
			{
				int length = values.Length;
			}
			TMP_Dropdown dropdown2 = _dropdown;
			bool flag = num < num;
			if (num != (flag ? 1 : 0))
			{
				List<TMP_Dropdown.OptionData> options2 = (List<TMP_Dropdown.OptionData>)(object)dropdown2.get_options();
				TMP_Dropdown.OptionData item = new TMP_Dropdown.OptionData(values[num]);
				((List<T>)(object)options2).Add((T)item);
				num++;
			}
			UnityAction<int> unityAction = (UnityAction<int>)(object)new UnityAction<T0>(UpdateValue);
			TMP_Dropdown dropdown3 = _dropdown;
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

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x14A2D30", Offset = "0x14A1730", VA = "0x1814A2D30")]
		private void UpdateValue(int index)
		{
			_index = index;
			this.OnValueChanged?.Invoke(index);
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x14A29D0", Offset = "0x14A13D0", VA = "0x1814A29D0")]
		private void OnScroll(InputActionEventData data)
		{
			//IL_004e: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			int num = 0;
			GameObject selection = EventSystem.current.m_CurrentSelected;
			if (!base.gameObject.activeInHierarchy || !base.gameObject.activeSelf)
			{
				return;
			}
			GameObject gameObject = selection;
			int num2 = 0;
			if (gameObject == (UnityEngine.Object)num2)
			{
				return;
			}
			Transform transform = selection.transform;
			Transform parent = _dropdown.gameObject.transform;
			if (!transform.IsChildOf(parent))
			{
				return;
			}
			List<TMP_Dropdown.OptionData> options = (List<TMP_Dropdown.OptionData>)(object)_dropdown.get_options();
			Predicate<TMP_Dropdown.OptionData> predicate = (Predicate<TMP_Dropdown.OptionData>)(object)(Predicate<T>)delegate(TMP_Dropdown.OptionData elem)
			{
				GameObject gameObject2 = selection;
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
			List<TMP_Dropdown.OptionData> options2 = (List<TMP_Dropdown.OptionData>)(object)_dropdown.get_options();
			int num4 = 0;
			if (componentInChildren != (UnityEngine.Object)num4)
			{
				TMP_Dropdown dropdown = _dropdown;
				if (componentInChildren.m_Direction == Scrollbar.Direction.TopToBottom)
				{
					throw new NullReferenceException();
				}
				List<TMP_Dropdown.OptionData> options3 = (List<TMP_Dropdown.OptionData>)(object)dropdown.get_options();
				float num6 = (componentInChildren.value = Mathf.Max(0.001f, 1f));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x14A2930", Offset = "0x14A1330", VA = "0x1814A2930")]
		private void OnDestroy()
		{
			Player player = _player;
			if (player != null)
			{
				Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnScroll);
				player.RemoveInputEventDelegate((Action<>)(object)action);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x14A2D50", Offset = "0x14A1750", VA = "0x1814A2D50")]
		public ComboBoxTMP()
		{
		}
	}
}
