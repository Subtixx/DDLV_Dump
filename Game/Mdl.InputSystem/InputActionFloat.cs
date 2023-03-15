using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003C0")]
	public class InputActionFloat : InputAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001918")]
		protected string inputName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001919")]
		protected string negativeInputName;

		[Cpp2IlInjected.Token(Token = "0x6001048")]
		[Cpp2IlInjected.Address(RVA = "0x11B3140", Offset = "0x11B1B40", VA = "0x1811B3140")]
		public InputActionFloat(string input, InputTrigger trigger, [Optional] string negativeInput, [Optional] InputProvider provider)
		{
			inputName = input;
			negativeInputName = negativeInput;
			previousIsActuated = false;
			previousIsActuated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001049")]
		[Cpp2IlInjected.Address(RVA = "0x11B30A0", Offset = "0x11B1AA0", VA = "0x1811B30A0", Slot = "4")]
		protected override void UpdateInputActionValueFromProvider(ref InputActionValue value)
		{
			//Discarded unreachable code: IL_0039
			//IL_0038: Expected I4, but got I8
			InputProvider inputProvider = base.inputProvider;
			string text = inputName;
			float @float = inputProvider.GetFloat(text);
			string text2 = negativeInputName;
			if (text2 != null)
			{
				float float2 = base.inputProvider.GetFloat(text2);
			}
			value.ValueType = InputActionValueType.Float;
		}

		[Cpp2IlInjected.Token(Token = "0x600104A")]
		[Cpp2IlInjected.Address(RVA = "0x11B2F90", Offset = "0x11B1990", VA = "0x1811B2F90", Slot = "5")]
		public override float GetValueFloatRaw()
		{
			//Discarded unreachable code: IL_0031
			InputProvider inputProvider = base.inputProvider;
			string text = inputName;
			float floatRaw = inputProvider.GetFloatRaw(text);
			string text2 = negativeInputName;
			if (text2 != null)
			{
				float floatRaw2 = base.inputProvider.GetFloatRaw(text2);
			}
			return floatRaw;
		}

		[Cpp2IlInjected.Token(Token = "0x600104B")]
		[Cpp2IlInjected.Address(RVA = "0x11B3000", Offset = "0x11B1A00", VA = "0x1811B3000", Slot = "6")]
		public override Vector2 GetValueVector2Raw()
		{
			float valueFloatRaw = GetValueFloatRaw();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600104C")]
		[Cpp2IlInjected.Address(RVA = "0x11B3030", Offset = "0x11B1A30", VA = "0x1811B3030", Slot = "3")]
		public override string ToString()
		{
			InputActionValue modifiedValue = base.ModifiedValue;
			return string.Format("{0}", "{0}");
		}
	}
}
