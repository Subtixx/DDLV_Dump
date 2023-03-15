using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000960")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(ParticleSystem))]
	public class FitEmitter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037C7")]
		public float leftMargin = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40037C8")]
		public float rightMargin = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037C9")]
		public float topMargin = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40037CA")]
		public float bottomMargin = 20f;

		[Cpp2IlInjected.Token(Token = "0x6003B18")]
		[Cpp2IlInjected.Address(RVA = "0x165FE60", Offset = "0x165E860", VA = "0x18165FE60")]
		private void Start()
		{
			//Discarded unreachable code: IL_0031
			RectTransform component = GetComponent<RectTransform>();
			ParticleSystem.MainModule main = GetComponent<ParticleSystem>().main;
			float num = leftMargin * 0.5f;
			float num2 = bottomMargin * 0.5f;
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B19")]
		[Cpp2IlInjected.Address(RVA = "0x165FE60", Offset = "0x165E860", VA = "0x18165FE60")]
		internal void UpdateEmitter()
		{
			//Discarded unreachable code: IL_0031
			RectTransform component = GetComponent<RectTransform>();
			ParticleSystem.MainModule main = GetComponent<ParticleSystem>().main;
			float num = leftMargin * 0.5f;
			float num2 = bottomMargin * 0.5f;
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1A")]
		[Cpp2IlInjected.Address(RVA = "0x1660000", Offset = "0x165EA00", VA = "0x181660000")]
		public FitEmitter()
		{
		}
	}
}
