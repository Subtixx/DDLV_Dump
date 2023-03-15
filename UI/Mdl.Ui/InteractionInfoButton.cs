using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007B4")]
	public class InteractionInfoButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D36")]
		[SerializeField]
		private TextBase _label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D37")]
		private Action<int> OnButtonClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D38")]
		private int _index;

		[Cpp2IlInjected.Token(Token = "0x6003141")]
		[Cpp2IlInjected.Address(RVA = "0xD24CB0", Offset = "0xD236B0", VA = "0x180D24CB0")]
		public void Init(string stringID, Action<int> onButtonClick, int index)
		{
			//Discarded unreachable code: IL_001b
			_label.StringID = stringID;
			OnButtonClick = onButtonClick;
			_index = index;
		}

		[Cpp2IlInjected.Token(Token = "0x6003142")]
		[Cpp2IlInjected.Address(RVA = "0xD24D10", Offset = "0xD23710", VA = "0x180D24D10")]
		public void OnClick()
		{
			//IL_0019: Expected O, but got I4
			Action<int> onButtonClick = OnButtonClick;
			if (onButtonClick != null)
			{
				int index = _index;
				onButtonClick((T)index);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003143")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InteractionInfoButton()
		{
		}
	}
}
