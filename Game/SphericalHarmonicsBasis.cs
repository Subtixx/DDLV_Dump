using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200009E")]
public class SphericalHarmonicsBasis
{
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static SH_Base[] Eval;

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0xF58250", Offset = "0xF56C50", VA = "0x180F58250")]
	public static float Y0(Vector3 v)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xF58260", Offset = "0xF56C60", VA = "0x180F58260")]
	public static float Y1(Vector3 v)
	{
		return v.y * 0.48860252f;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0xF58280", Offset = "0xF56C80", VA = "0x180F58280")]
	public static float Y2(Vector3 v)
	{
		return v.z * 0.48860252f;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xF582A0", Offset = "0xF56CA0", VA = "0x180F582A0")]
	public static float Y3(Vector3 v)
	{
		float result = default(float);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xF582B0", Offset = "0xF56CB0", VA = "0x180F582B0")]
	public unsafe static float Y4(Vector3 v)
	{
		//IL_0001: Expected native int or pointer, but got F4
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F4, but got Unknown
		float num = default(float);
		float y = ((Vector3*)(IntPtr)num)->y;
		return /*Error near IL_0007: Stack underflow*/* y;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0xF582D0", Offset = "0xF56CD0", VA = "0x180F582D0")]
	public static float Y5(Vector3 v)
	{
		float result = v.y * 1.0925485f;
		float z = v.z;
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xF58300", Offset = "0xF56D00", VA = "0x180F58300")]
	public static float Y6(Vector3 v)
	{
		return v.z * 3f * 0.31539157f;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xF58340", Offset = "0xF56D40", VA = "0x180F58340")]
	public static float Y7(Vector3 v)
	{
		float z = v.z;
		float result = default(float);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0xF58370", Offset = "0xF56D70", VA = "0x180F58370")]
	public static float Y8(Vector3 v)
	{
		float result = default(float);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
	public SphericalHarmonicsBasis()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0xF583A0", Offset = "0xF56DA0", VA = "0x180F583A0")]
	static unsafe SphericalHarmonicsBasis()
	{
		//IL_0014: Expected O, but got I4
		//IL_0034: Expected O, but got I4
		//IL_0055: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_00ca: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		SH_Base[] array;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		SH_Base sH_Base9;
		int num9 = default(int);
		while (true)
		{
			array = new SH_Base[9];
			SH_Base sH_Base = new SH_Base(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, float>*/)(&Y0));
			num = 0;
			if (sH_Base != null && sH_Base == null)
			{
				continue;
			}
			array[0] = sH_Base;
			SH_Base sH_Base2 = new SH_Base(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, float>*/)(&Y1));
			num2 = 0;
			if (sH_Base2 != null && sH_Base2 == null)
			{
				continue;
			}
			array[1] = sH_Base2;
			SH_Base sH_Base3 = new SH_Base(num3, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, float>*/)(&Y2));
			num3 = 0;
			if (sH_Base3 != null && sH_Base3 == null)
			{
				continue;
			}
			array[2] = sH_Base3;
			SH_Base sH_Base4 = new SH_Base(num4, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, float>*/)(&Y3));
			num4 = 0;
			if (sH_Base4 != null && sH_Base4 == null)
			{
				continue;
			}
			array[3] = sH_Base4;
			SH_Base sH_Base5 = new SH_Base(num5, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, float>*/)(&Y4));
			num5 = 0;
			if (sH_Base5 != null && sH_Base5 == null)
			{
				continue;
			}
			array[4] = sH_Base5;
			SH_Base sH_Base6 = new SH_Base(num6, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, float>*/)(&Y5));
			num6 = 0;
			if (sH_Base6 != null && sH_Base6 == null)
			{
				continue;
			}
			array[5] = sH_Base6;
			SH_Base sH_Base7 = new SH_Base(num7, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, float>*/)(&Y6));
			num7 = 0;
			if (sH_Base7 != null && sH_Base7 == null)
			{
				continue;
			}
			array[6] = sH_Base7;
			SH_Base sH_Base8 = new SH_Base(num8, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, float>*/)(&Y7));
			num8 = 0;
			if (sH_Base8 == null || sH_Base8 != null)
			{
				array[7] = sH_Base8;
				sH_Base9 = new SH_Base(num9, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, float>*/)(&Y8));
				num9 = 0;
				if (sH_Base9 == null || sH_Base9 != null)
				{
					break;
				}
			}
		}
		array[8] = sH_Base9;
		throw new NullReferenceException();
	}
}
