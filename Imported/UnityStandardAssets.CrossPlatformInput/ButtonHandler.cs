using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class ButtonHandler : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public string Name;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnEnable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2F08260", Offset = "0x2F06C60", VA = "0x182F08260")]
		public void SetDownState()
		{
			//Discarded unreachable code: IL_0014
			string text = Name;
			bool button = CrossPlatformInputManager.activeInput.GetButton(text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2F08330", Offset = "0x2F06D30", VA = "0x182F08330")]
		public void SetUpState()
		{
			//Discarded unreachable code: IL_0014
			string text = Name;
			bool button = CrossPlatformInputManager.activeInput.GetButton(text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2F08190", Offset = "0x2F06B90", VA = "0x182F08190")]
		public void SetAxisPositiveState()
		{
			//Discarded unreachable code: IL_0014
			string text = Name;
			bool button = CrossPlatformInputManager.activeInput.GetButton(text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2F080C0", Offset = "0x2F06AC0", VA = "0x182F080C0")]
		public void SetAxisNeutralState()
		{
			//Discarded unreachable code: IL_0014
			string text = Name;
			bool button = CrossPlatformInputManager.activeInput.GetButton(text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2F07FF0", Offset = "0x2F069F0", VA = "0x182F07FF0")]
		public void SetAxisNegativeState()
		{
			//Discarded unreachable code: IL_0014
			string text = Name;
			bool button = CrossPlatformInputManager.activeInput.GetButton(text);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ButtonHandler()
		{
		}
	}
}
