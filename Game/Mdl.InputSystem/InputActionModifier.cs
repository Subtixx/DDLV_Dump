using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003C5")]
	public abstract class InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001928")]
		public InputActionModifierMask Mask;

		[Cpp2IlInjected.Token(Token = "0x6001059")]
		[Cpp2IlInjected.Address(RVA = "0x11B34D0", Offset = "0x11B1ED0", VA = "0x1811B34D0")]
		internal void ApplyModifier(float deltaTime, ref InputActionValue value)
		{
			//Discarded unreachable code: IL_0019, IL_001a
			//IL_0018: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			ModifyValue(deltaTime, ref value);
			if (Mask == InputActionModifierMask.UseModifierY)
			{
				value.Value = (Vector2)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600105A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void ModifyValue(float deltaTime, ref InputActionValue value);

		[Cpp2IlInjected.Token(Token = "0x600105B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected InputActionModifier()
		{
		}
	}
}
