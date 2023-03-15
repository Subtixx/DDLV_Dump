using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private const float fpsMeasurePeriod = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int m_FpsAccumulator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private float m_FpsNextPeriod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int m_CurrentFps;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private const string display = "{0} FPS";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private Text m_Text;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2F10E30", Offset = "0x2F0F830", VA = "0x182F10E30")]
		private void Start()
		{
			int num = 0;
			float num2 = (m_FpsNextPeriod = Time.realtimeSinceStartup);
			Text text = (m_Text = GetComponent<Text>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2F10E90", Offset = "0x2F0F890", VA = "0x182F10E90")]
		private void Update()
		{
			//Discarded unreachable code: IL_004f
			//IL_001c: Expected I4, but got I8
			//IL_002e: Expected I4, but got O
			int num = 0;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float fpsNextPeriod = m_FpsNextPeriod;
			if (!(realtimeSinceStartup <= fpsNextPeriod))
			{
				m_FpsAccumulator = 0;
				m_FpsNextPeriod = fpsNextPeriod;
				m_CurrentFps = (int)"{0} FPS";
				Text text = m_Text;
				string text3 = (text.text = string.Format("{0} FPS", "{0} FPS"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FPSCounter()
		{
		}
	}
}
