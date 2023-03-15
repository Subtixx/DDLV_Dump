using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D3")]
	public class InputActionModifier_ScaleCurve : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001937")]
		private AnimationCurve curve;

		[Cpp2IlInjected.Token(Token = "0x600107D")]
		[Cpp2IlInjected.Address(RVA = "0x5391F0", Offset = "0x537BF0", VA = "0x1805391F0")]
		public InputActionModifier_ScaleCurve(AnimationCurve curve)
		{
			this.curve = curve;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600107E")]
		[Cpp2IlInjected.Address(RVA = "0x11B37F0", Offset = "0x11B21F0", VA = "0x1811B37F0", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			//Discarded unreachable code: IL_0016
			//IL_000e: Expected O, but got F4
			AnimationCurve animationCurve = curve;
			float num = default(float);
			value.Value = (Vector2)num;
			AnimationCurve animationCurve2 = curve;
		}
	}
}
