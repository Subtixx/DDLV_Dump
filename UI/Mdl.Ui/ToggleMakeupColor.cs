using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200076A")]
	public class ToggleMakeupColor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B4E")]
		[SerializeField]
		private Image _toggleImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B4F")]
		public GameObject IconObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B50")]
		public ToggleGroupMakeupColor ToggleGroupMakeupColor;

		[Cpp2IlInjected.Token(Token = "0x6002F80")]
		[Cpp2IlInjected.Address(RVA = "0x17F1BE0", Offset = "0x17F05E0", VA = "0x1817F1BE0")]
		public void SetColor(Color color)
		{
			//Discarded unreachable code: IL_0023
			Image toggleImage = _toggleImage;
			if (!_toggleImage.enabled)
			{
				_toggleImage.enabled = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F81")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ToggleMakeupColor()
		{
		}
	}
}
