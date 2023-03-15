using System;
using System.Diagnostics;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003CD")]
	public class InputActionModifier_Accel : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400192E")]
		private InputActionValue actionValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400192F")]
		private float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001930")]
		private float speedNotTriggered;

		[Cpp2IlInjected.Token(Token = "0x600106D")]
		[Cpp2IlInjected.Address(RVA = "0x11B3480", Offset = "0x11B1E80", VA = "0x1811B3480")]
		public unsafe InputActionModifier_Accel()
		{
			//IL_0016: Expected I4, but got I8
			//IL_0011: Expected native int or pointer, but got O
			int num = 0;
			Vector2 zero = Vector2.zero;
			((InputActionValue*)(IntPtr)actionValue)->ValueType = InputActionValueType.Vector2;
			speed = 1f;
			speedNotTriggered = 10f;
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x600106E")]
		[Cpp2IlInjected.Address(RVA = "0x11B3390", Offset = "0x11B1D90", VA = "0x1811B3390")]
		public unsafe InputActionModifier_Accel(float speed)
		{
			//IL_0016: Expected I4, but got I8
			//IL_0011: Expected native int or pointer, but got O
			int num = 0;
			Vector2 zero = Vector2.zero;
			((InputActionValue*)(IntPtr)actionValue)->ValueType = InputActionValueType.Vector2;
			this.speed = 1f;
			speedNotTriggered = 10f;
			((object)this)._002Ector();
			this.speed = speed;
			speedNotTriggered = speed;
		}

		[Cpp2IlInjected.Token(Token = "0x600106F")]
		[Cpp2IlInjected.Address(RVA = "0x11B3400", Offset = "0x11B1E00", VA = "0x1811B3400")]
		public unsafe InputActionModifier_Accel(float speed, float speedNotTriggered)
		{
			//IL_0016: Expected I4, but got I8
			//IL_0011: Expected native int or pointer, but got O
			int num = 0;
			Vector2 zero = Vector2.zero;
			((InputActionValue*)(IntPtr)actionValue)->ValueType = InputActionValueType.Vector2;
			this.speed = 1f;
			this.speedNotTriggered = 10f;
			((object)this)._002Ector();
			this.speed = speed;
			this.speedNotTriggered = speedNotTriggered;
		}

		[Cpp2IlInjected.Token(Token = "0x6001070")]
		[Cpp2IlInjected.Address(RVA = "0x11B3200", Offset = "0x11B1C00", VA = "0x1811B3200")]
		[Conditional("DEBUG")]
		public void DebugUpdate(float speed)
		{
			this.speed = speed;
			speedNotTriggered = speed;
		}

		[Cpp2IlInjected.Token(Token = "0x6001071")]
		[Cpp2IlInjected.Address(RVA = "0x11B3210", Offset = "0x11B1C10", VA = "0x1811B3210")]
		[Conditional("DEBUG")]
		public void DebugUpdate(float speed, float speedNotTriggered)
		{
			this.speed = speed;
			this.speedNotTriggered = speedNotTriggered;
		}

		[Cpp2IlInjected.Token(Token = "0x6001072")]
		[Cpp2IlInjected.Address(RVA = "0x11B3220", Offset = "0x11B1C20", VA = "0x1811B3220", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			//IL_0011: Expected O, but got F4
			//IL_001d: Expected O, but got F4
			bool flag = default(bool);
			if (flag)
			{
			}
			int num = 0;
			Vector2 vector = default(Vector2);
			if ((long)(IntPtr)vector > (long)num)
			{
				float num2 = default(float);
				actionValue = (InputActionValue)num2;
			}
			if ((long)num > (long)(IntPtr)vector)
			{
				float num3 = default(float);
				actionValue = (InputActionValue)num3;
			}
			float num4 = default(float);
			float num5 = num4;
		}
	}
}
