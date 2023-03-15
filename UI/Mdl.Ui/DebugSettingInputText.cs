using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003E8")]
	public class DebugSettingInputText : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003E9")]
		public delegate void ValueChanged(string value);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001335")]
		[SerializeField]
		private InputField _tfInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001336")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.Token(Token = "0x17000420")]
		public string Label
		{
			[Cpp2IlInjected.Token(Token = "0x60018DF")]
			[Cpp2IlInjected.Address(RVA = "0x7DAB50", Offset = "0x7D9550", VA = "0x1807DAB50")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _tfLabel._text;
			}
			[Cpp2IlInjected.Token(Token = "0x60018E0")]
			[Cpp2IlInjected.Address(RVA = "0x15534B0", Offset = "0x1551EB0", VA = "0x1815534B0")]
			set
			{
				//Discarded unreachable code: IL_0013
				TextBase tfLabel = _tfLabel;
				if (value == null)
				{
				}
				tfLabel.Text = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000421")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60018E1")]
			[Cpp2IlInjected.Address(RVA = "0x15533F0", Offset = "0x1551DF0", VA = "0x1815533F0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _tfInput.m_Text;
			}
			[Cpp2IlInjected.Token(Token = "0x60018E2")]
			[Cpp2IlInjected.Address(RVA = "0x1553520", Offset = "0x1551F20", VA = "0x181553520")]
			set
			{
				//Discarded unreachable code: IL_0013
				InputField tfInput = _tfInput;
				if (value == null)
				{
				}
				tfInput.text = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event ValueChanged OnValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60018DC")]
			[Cpp2IlInjected.Address(RVA = "0x1553350", Offset = "0x1551D50", VA = "0x181553350")]
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
			[Cpp2IlInjected.Token(Token = "0x60018DD")]
			[Cpp2IlInjected.Address(RVA = "0x1553410", Offset = "0x1551E10", VA = "0x181553410")]
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

		[Cpp2IlInjected.Token(Token = "0x60018DE")]
		[Cpp2IlInjected.Address(RVA = "0x1553250", Offset = "0x1551C50", VA = "0x181553250")]
		private void Start()
		{
			//Discarded unreachable code: IL_0031
			InputField tfInput = _tfInput;
			int num = ((tfInput.shouldActivateOnSelect = false) ? 1 : 0);
			InputField.SubmitEvent onEndEdit = _tfInput.m_OnEndEdit;
			UnityAction<string> unityAction = (UnityAction<string>)(object)(UnityAction<T0>)delegate(string val)
			{
				//Discarded unreachable code: IL_000d
				this.OnValueChanged(val);
			};
			((UnityEvent<T0>)(object)onEndEdit).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60018E3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugSettingInputText()
		{
		}
	}
}
