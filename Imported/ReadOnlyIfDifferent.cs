using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ReadOnlyIfDifferent : Hidesbase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public string varName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public object ValueToCheck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public float labelWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public float valueWidth;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0BE0", Offset = "0x3DBF5E0", VA = "0x183DC0BE0")]
	public ReadOnlyIfDifferent(string varToCheck, object ValueToCheck, float labelWidth = -1f, float valueWidth = 32f)
	{
		//IL_0022: Expected F4, but got I4
		varName = varToCheck;
		this.ValueToCheck = ValueToCheck;
		this.labelWidth = labelWidth;
		this.valueWidth = 0f;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0B90", Offset = "0x3DBF590", VA = "0x183DC0B90")]
	public ReadOnlyIfDifferent(string varToCheck, object ValueToCheck)
	{
		varName = varToCheck;
		this.ValueToCheck = ValueToCheck;
		/*Error: Unexpected end of block*/;
	}
}
