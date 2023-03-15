using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string axis;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2F12240", Offset = "0x2F10C40", VA = "0x182F12240")]
		public void HandleInput(float value)
		{
			//Discarded unreachable code: IL_0014
			string text = axis;
			bool button = CrossPlatformInputManager.activeInput.GetButton(text);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public InputAxisScrollbar()
		{
		}
	}
}
