using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007CE")]
	public struct Angle
	{
		[Cpp2IlInjected.Token(Token = "0x170004D4")]
		public static Angle Zero
		{
			[Cpp2IlInjected.Token(Token = "0x60022A4")]
			[Cpp2IlInjected.Address(RVA = "0xA3D2C0", Offset = "0xA3BCC0", VA = "0x180A3D2C0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D5")]
		public float Degrees
		{
			[Cpp2IlInjected.Token(Token = "0x60022A5")]
			[Cpp2IlInjected.Address(RVA = "0xA3D2A0", Offset = "0xA3BCA0", VA = "0x180A3D2A0")]
			get
			{
				float result = default(float);
				return result;
			}
			[Cpp2IlInjected.Token(Token = "0x60022A6")]
			[Cpp2IlInjected.Address(RVA = "0xA3D380", Offset = "0xA3BD80", VA = "0x180A3D380")]
			set
			{
				float num = (Radians = value * ((float)Math.PI / 180f));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D6")]
		public float Radians
		{
			[Cpp2IlInjected.Token(Token = "0x60022A7")]
			[Cpp2IlInjected.Address(RVA = "0xA3D2B0", Offset = "0xA3BCB0", VA = "0x180A3D2B0")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60022A8")]
			[Cpp2IlInjected.Address(RVA = "0xA3D390", Offset = "0xA3BD90", VA = "0x180A3D390")]
			[CompilerGenerated]
			set
			{
				_003CRadians_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022A2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D280", Offset = "0xA3BC80", VA = "0x180A3D280")]
		public static Angle FromDegrees(float degrees)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022A3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D290", Offset = "0xA3BC90", VA = "0x180A3D290")]
		public static Angle FromRadians(float radians)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2D0", Offset = "0xA3BCD0", VA = "0x180A3D2D0")]
		public static Angle operator +(Angle a, Angle b)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022AA")]
		[Cpp2IlInjected.Address(RVA = "0xA3D360", Offset = "0xA3BD60", VA = "0x180A3D360")]
		public static Angle operator -(Angle a, Angle b)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D320", Offset = "0xA3BD20", VA = "0x180A3D320")]
		public static Angle operator *(Angle a, Angle b)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3D340", Offset = "0xA3BD40", VA = "0x180A3D340")]
		public static Angle operator *(Angle a, float amount)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3D350", Offset = "0xA3BD50", VA = "0x180A3D350")]
		public static Angle operator *(float amount, Angle a)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3D300", Offset = "0xA3BD00", VA = "0x180A3D300")]
		public static Angle operator /(Angle a, Angle b)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022AF")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2F0", Offset = "0xA3BCF0", VA = "0x180A3D2F0")]
		public static Angle operator /(Angle a, float amount)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
