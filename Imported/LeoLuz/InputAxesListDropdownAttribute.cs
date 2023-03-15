using Cpp2IlInjected;
using UnityEngine;

namespace LeoLuz
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class InputAxesListDropdownAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public bool hideLabel;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2F118F0", Offset = "0x2F102F0", VA = "0x182F118F0")]
		public InputAxesListDropdownAttribute(bool hideLabel = false)
		{
			this.hideLabel = hideLabel;
		}
	}
}
