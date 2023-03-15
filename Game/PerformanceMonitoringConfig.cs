using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000A6")]
[CreateAssetMenu]
public class PerformanceMonitoringConfig : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public string uri = "https://elk-us-east-1.crosssilo-beta.gameloft.com";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public string indexFormat = "mydisneylife-benchmark-{0:yyyy.MM.dd}";

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public int sampleIntervalInSeconds = 5;

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0xF0D8E0", Offset = "0xF0C2E0", VA = "0x180F0D8E0")]
	public PerformanceMonitoringConfig()
	{
	}//IL_001f: Expected I4, but got I8

}
