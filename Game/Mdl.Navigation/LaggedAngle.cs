using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C37")]
	public class LaggedAngle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400441D")]
		public float InterpolationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400441E")]
		public bool UseInterpolation;

		[Cpp2IlInjected.Token(Token = "0x1700076B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400441B")]
		public float Desired
		{
			[Cpp2IlInjected.Token(Token = "0x60037C5")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60037C6")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0")]
			protected set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700076C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x400441C")]
		public float Current
		{
			[Cpp2IlInjected.Token(Token = "0x60037C7")]
			[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60037C8")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
			protected set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700076D")]
		private bool IsInterpolating
		{
			[Cpp2IlInjected.Token(Token = "0x60037CB")]
			[Cpp2IlInjected.Address(RVA = "0x11C5740", Offset = "0x11C4140", VA = "0x1811C5740")]
			get
			{
				if (!UseInterpolation)
				{
					int num = 0;
				}
				float interpolationSpeed = InterpolationSpeed;
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037C9")]
		[Cpp2IlInjected.Address(RVA = "0x11C5670", Offset = "0x11C4070", VA = "0x1811C5670")]
		public void Reset(float angle)
		{
			Desired = angle;
			Current = angle;
		}

		[Cpp2IlInjected.Token(Token = "0x60037CA")]
		[Cpp2IlInjected.Address(RVA = "0x11C5680", Offset = "0x11C4080", VA = "0x1811C5680")]
		public void Update(float deltaTime, float newDesiredAngle, float actualCurrentAngle)
		{
			float _003CRadians_003Ek__BackingField = Angle.FromDegrees(newDesiredAngle).Radians;
			float num = default(float);
			Desired = num;
			if (UseInterpolation)
			{
				float interpolationSpeed = InterpolationSpeed;
				int num2 = 0;
				Angle angle = default(Angle);
				if ((object)angle != null)
				{
				}
			}
			float num3 = Mathf.Clamp01(float.MaxValue);
			float b = Desired;
			num3 = actualCurrentAngle;
			float _003CRadians_003Ek__BackingField2 = Angle.FromDegrees(Mathf.LerpAngle(num3, b, newDesiredAngle)).Radians;
			float num4 = default(float);
			Current = num4;
		}

		[Cpp2IlInjected.Token(Token = "0x60037CC")]
		[Cpp2IlInjected.Address(RVA = "0x11C5640", Offset = "0x11C4040", VA = "0x1811C5640")]
		private static float ClampAngle(float angle)
		{
			float _003CRadians_003Ek__BackingField = Angle.FromDegrees(angle).Radians;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037CD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LaggedAngle()
		{
		}
	}
}
