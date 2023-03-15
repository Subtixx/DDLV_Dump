using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2001119")]
[CompilerGenerated]
internal sealed class _003CPrivateImplementationDetails_003E
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	[Cpp2IlInjected.Token(Token = "0x200111A")]
	private struct __StaticArrayInitTypeSize_003D20
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4004674")]
	internal static readonly __StaticArrayInitTypeSize_003D20 B4843ED2E446B452D4953BF279FCFA4F4276D1C88CAAB93A30A2B7BCEC457664/* Not supported: data(04 00 00 00 05 00 00 00 0E 00 00 00 10 00 00 00 0A 00 00 00) */;

	[Cpp2IlInjected.Token(Token = "0x6008B5C")]
	[Cpp2IlInjected.Address(RVA = "0x898870", Offset = "0x897270", VA = "0x180898870")]
	internal static uint ComputeStringHash(string s)
	{
		int num;
		do
		{
			num = 0;
		}
		while (s == null || num >= s.m_stringLength);
		char c = s[num];
		num++;
		/*Error: Unexpected end of block*/;
	}
}
