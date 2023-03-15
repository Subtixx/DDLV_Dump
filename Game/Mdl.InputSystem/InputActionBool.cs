using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003BF")]
	public class InputActionBool : InputAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001917")]
		protected string inputName;

		[Cpp2IlInjected.Token(Token = "0x6001043")]
		[Cpp2IlInjected.Address(RVA = "0x11B2EE0", Offset = "0x11B18E0", VA = "0x1811B2EE0")]
		public InputActionBool(string input, InputTrigger trigger, [Optional] InputProvider provider)
			: base(trigger, provider)
		{
			inputName = input;
			previousIsActuated = false;
			previousIsActuated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001044")]
		[Cpp2IlInjected.Address(RVA = "0x11B2E80", Offset = "0x11B1880", VA = "0x1811B2E80", Slot = "4")]
		protected override void UpdateInputActionValueFromProvider(ref InputActionValue value)
		{
			//Discarded unreachable code: IL_002b
			//IL_0021: Expected O, but got I4
			//IL_002a: Expected I4, but got I8
			InputProvider inputProvider = base.inputProvider;
			string text = inputName;
			if (inputProvider.GetBool(text))
			{
			}
			int num = 0;
			value.Value = (Vector2)num;
			value.ValueType = InputActionValueType.Bool;
		}

		[Cpp2IlInjected.Token(Token = "0x6001045")]
		[Cpp2IlInjected.Address(RVA = "0x11B2D90", Offset = "0x11B1790", VA = "0x1811B2D90", Slot = "5")]
		public override float GetValueFloatRaw()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001046")]
		[Cpp2IlInjected.Address(RVA = "0x11B2DC0", Offset = "0x11B17C0", VA = "0x1811B2DC0", Slot = "6")]
		public override Vector2 GetValueVector2Raw()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001047")]
		[Cpp2IlInjected.Address(RVA = "0x11B2E00", Offset = "0x11B1800", VA = "0x1811B2E00", Slot = "3")]
		public override string ToString()
		{
			//IL_000b: Expected O, but got I4
			bool flag = default(bool);
			return $"{flag}";
		}
	}
}
