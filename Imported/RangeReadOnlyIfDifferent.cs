using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200002B")]
public class RangeReadOnlyIfDifferent : Hidesbase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public string varName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public object ValueToCheck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public float min;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public float max;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0B20", Offset = "0x3DBF520", VA = "0x183DC0B20")]
	public RangeReadOnlyIfDifferent(float min, float max, string varToCheck, object ValueToCheck)
	{
		//IL_0014: Expected O, but got I4
		varName = varToCheck;
		this.ValueToCheck = 0;
		this.min = min;
		this.max = max;
	}
}
