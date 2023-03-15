using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D4")]
	public class InputActionModifier_ScaleExternalCurve : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001938")]
		private AnimationCurve curveData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001939")]
		public float CurveIndex;

		[Cpp2IlInjected.Token(Token = "0x600107F")]
		[Cpp2IlInjected.Address(RVA = "0x11B3A00", Offset = "0x11B2400", VA = "0x1811B3A00")]
		public InputActionModifier_ScaleExternalCurve(AnimationCurve curveData, float initialCurveIndex)
		{
			this.curveData = curveData;
			CurveIndex = initialCurveIndex;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001080")]
		[Cpp2IlInjected.Address(RVA = "0x11B39A0", Offset = "0x11B23A0", VA = "0x1811B39A0", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			//Discarded unreachable code: IL_0017
			AnimationCurve animationCurve = curveData;
			float curveIndex = CurveIndex;
			float num = animationCurve.Evaluate(curveIndex);
		}
	}
}
