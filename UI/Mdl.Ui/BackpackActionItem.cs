using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000347")]
	public class BackpackActionItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F6A")]
		[SerializeField]
		private TextBase _label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F6B")]
		private Action _action;

		[Cpp2IlInjected.Token(Token = "0x60014A3")]
		[Cpp2IlInjected.Address(RVA = "0x88DBC0", Offset = "0x88C5C0", VA = "0x18088DBC0")]
		public void Init(string stringID, Action action)
		{
			_label.StringID = stringID;
			_action = action;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014A4")]
		[Cpp2IlInjected.Address(RVA = "0x88DC00", Offset = "0x88C600", VA = "0x18088DC00")]
		public void OnClick()
		{
			_action?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60014A5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public BackpackActionItem()
		{
		}
	}
}
