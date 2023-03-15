using Cpp2IlInjected;
using Mdl.Characters;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005CA")]
	public class ForgottenIceVFX : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023A2")]
		public string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023A3")]
		public float startValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40023A4")]
		public float endValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40023A5")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40023A6")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40023A7")]
		private TheForgottenCharacter forgotten;

		[Cpp2IlInjected.Token(Token = "0x60019D4")]
		[Cpp2IlInjected.Address(RVA = "0x14647D0", Offset = "0x14631D0", VA = "0x1814647D0")]
		public void StartForgottenIntensityChange()
		{
			//Discarded unreachable code: IL_004f
			//IL_001f: Expected O, but got I4
			TheForgottenCharacter theForgottenCharacter = (forgotten = GetComponentInChildren<TheForgottenCharacter>(includeInactive: true));
			TheForgottenCharacter theForgottenCharacter2 = forgotten;
			int num = 0;
			if (theForgottenCharacter2 != (Object)num)
			{
				TheForgottenCharacter theForgottenCharacter3 = forgotten;
				time = 0f;
				float newValue = startValue;
				string text = parameterName;
				theForgottenCharacter3.SetFloatMaterialsParameter(text, newValue);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019D5")]
		[Cpp2IlInjected.Address(RVA = "0x14648A0", Offset = "0x14632A0", VA = "0x1814648A0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0046
			//IL_0010: Expected O, but got I4
			//IL_002e: Expected O, but got I8
			//IL_0043: Expected F4, but got I4
			TheForgottenCharacter theForgottenCharacter = forgotten;
			int num = 0;
			if (theForgottenCharacter != (Object)num)
			{
				float num2 = duration;
				float num3 = time;
				if (!(num2 > num3))
				{
					forgotten = (TheForgottenCharacter)0;
					return;
				}
				int num4 = 0;
				float deltaTime = Time.deltaTime;
				deltaTime = Mathf.Lerp(deltaTime, num, deltaTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019D6")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ForgottenIceVFX()
		{
		}
	}
}
