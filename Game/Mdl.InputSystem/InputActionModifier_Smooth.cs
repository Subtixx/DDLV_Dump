using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003CE")]
	public class InputActionModifier_Smooth : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001931")]
		private InputActionValue[] actionValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001932")]
		private int currentValueIndex;

		[Cpp2IlInjected.Token(Token = "0x6001073")]
		[Cpp2IlInjected.Address(RVA = "0x11B3DB0", Offset = "0x11B27B0", VA = "0x1811B3DB0")]
		public InputActionModifier_Smooth(int frames)
		{
			//Discarded unreachable code: IL_0032
			InputActionValue[] array = (actionValues = new InputActionValue[frames]);
			InputActionValue[] array2 = actionValues;
			int num = 0;
			if (num < array2.Length)
			{
				num++;
				InputActionValue[] array3 = actionValues;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001074")]
		[Cpp2IlInjected.Address(RVA = "0x11B3AD0", Offset = "0x11B24D0", VA = "0x1811B3AD0", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			//Discarded unreachable code: IL_0069
			//IL_0065: Expected O, but got I4
			IEnumerable<InputActionValue> enumerable;
			uint num3 = default(uint);
			do
			{
				int num = 0;
				InputActionValue[] array = actionValues;
				int num2 = 0;
				Vector2 zero = Vector2.zero;
				InputActionValue[] array2 = actionValues;
				int b = currentValueIndex;
				b = Mathf.Min(array2.Length, b);
				enumerable = (IEnumerable<InputActionValue>)Enumerable.Take<InputActionValue>((IEnumerable<>)(object)array2, b);
				if (enumerable == null)
				{
					continue;
				}
				if (num < (int)num3)
				{
					num += num;
					if (num != (int)num3)
					{
						num++;
					}
				}
				enumerable = (IEnumerable<InputActionValue>)(object)((object)enumerable + (object)enumerable);
			}
			while (enumerable == null);
			if (!((Vector2)0).isNearZero())
			{
			}
		}
	}
}
