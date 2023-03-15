using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class ShaderGlobals
{
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly int CloudTexture = Shader.PropertyToID("_GlobalCloudsTexture");

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly int CloudData = Shader.PropertyToID("_GlobalCloudsData");

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly int CloudColor = Shader.PropertyToID("_GlobalCloudsColor");

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly int WindStrength = Shader.PropertyToID("_WindStrength");

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly int WindVector = Shader.PropertyToID("_Wind");

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly int TrunkStrength = Shader.PropertyToID("_TrunkStrength");

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly int TrunkFrequency = Shader.PropertyToID("_TrunkFrequency");

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly int LeavesStrength = Shader.PropertyToID("_LeavesStrength");

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly int LeavesFrequency = Shader.PropertyToID("_LeavesFrequency");

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly int LeavesOffsetScale = Shader.PropertyToID("_LeavesOffsetScale");

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly int HeightStrength = Shader.PropertyToID("_HeightStrength");

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly int HeightSpeed = Shader.PropertyToID("_HeightSpeed");

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly int HeightOffsetScale = Shader.PropertyToID("_HeightOffsetScale");

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly int BendScale = Shader.PropertyToID("_BendScale");

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly int NormalBlend = Shader.PropertyToID("_NormalBend");

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly int Cutoff = Shader.PropertyToID("_Cutoff");
}
