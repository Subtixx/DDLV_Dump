using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200002A")]
public class RangeHideIfDifferent : Hidesbase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public string varName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public object ValueToCheck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public float min;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public float max;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool upperLabel;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0AB0", Offset = "0x3DBF4B0", VA = "0x183DC0AB0")]
	public RangeHideIfDifferent(float min, float max, string varToCheck, object ValueToCheck, bool upperLabel = false)
	{
		//IL_0014: Expected O, but got I4
		varName = varToCheck;
		this.ValueToCheck = 0;
		this.min = min;
		this.max = max;
		this.upperLabel = false;
	}
}
