using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000768")]
	public class SliderMakeupOpacity : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B46")]
		[HideInInspector]
		public MakeupColor MakeupColor;

		[Cpp2IlInjected.Token(Token = "0x6002F76")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SliderMakeupOpacity()
		{
		}
	}
}
