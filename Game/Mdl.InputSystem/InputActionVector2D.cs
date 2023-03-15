using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003C1")]
	public class InputActionVector2D : InputAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400191A")]
		protected string xInputName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400191B")]
		protected string yInputName;

		[Cpp2IlInjected.Token(Token = "0x600104D")]
		[Cpp2IlInjected.Address(RVA = "0x11B4320", Offset = "0x11B2D20", VA = "0x1811B4320")]
		public InputActionVector2D(string xInput, string yInput, InputTrigger trigger, [Optional] InputProvider provider)
		{
			xInputName = xInput;
			yInputName = yInput;
			previousIsActuated = false;
			previousIsActuated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600104E")]
		[Cpp2IlInjected.Address(RVA = "0x11B42D0", Offset = "0x11B2CD0", VA = "0x1811B42D0", Slot = "4")]
		protected override void UpdateInputActionValueFromProvider(ref InputActionValue value)
		{
			//Discarded unreachable code: IL_002f
			//IL_0009: Expected I4, but got I8
			value.ValueType = InputActionValueType.Vector2;
			InputProvider inputProvider = base.inputProvider;
			string axisName = yInputName;
			string axisName2 = xInputName;
			Vector2 vector = (value.Value = inputProvider.GetAxis2D(axisName2, axisName));
		}

		[Cpp2IlInjected.Token(Token = "0x600104F")]
		[Cpp2IlInjected.Address(RVA = "0x11B41D0", Offset = "0x11B2BD0", VA = "0x1811B41D0", Slot = "5")]
		public override float GetValueFloatRaw()
		{
			Vector2 valueVector2Raw = GetValueVector2Raw();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001050")]
		[Cpp2IlInjected.Address(RVA = "0x11B4200", Offset = "0x11B2C00", VA = "0x1811B4200", Slot = "6")]
		public override Vector2 GetValueVector2Raw()
		{
			InputProvider inputProvider = base.inputProvider;
			string inputName = xInputName;
			bool @bool = inputProvider.GetBool(inputName);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001051")]
		[Cpp2IlInjected.Address(RVA = "0x11B4240", Offset = "0x11B2C40", VA = "0x1811B4240", Slot = "3")]
		public override string ToString()
		{
			InputActionValue modifiedValue = base.ModifiedValue;
			return string.Format("{0}, {1}", "{0}, {1}", "{0}, {1}");
		}
	}
}
