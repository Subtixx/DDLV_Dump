using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class CustomPostProcessData : PostProcessData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public Shader bloomOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public Shader uberPostOverride;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x110F1A0", Offset = "0x110DBA0", VA = "0x18110F1A0")]
	public void OnValidate()
	{
		//Discarded unreachable code: IL_0059
		//IL_0010: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		Shader shader = bloomOverride;
		int num = 0;
		if (shader != (UnityEngine.Object)num)
		{
			ShaderResources shaderResources = shaders;
			Shader shader2 = (shaderResources.bloomPS = bloomOverride);
		}
		Shader shader3 = uberPostOverride;
		int num2 = 0;
		if (shader3 != (UnityEngine.Object)num2)
		{
			ShaderResources shaderResources2 = shaders;
			Shader shader4 = (shaderResources2.uberPostPS = uberPostOverride);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
	public CustomPostProcessData()
	{
	}
}
