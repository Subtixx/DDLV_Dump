using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HideByClausule : Hidesbase
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum Clausule
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		equal,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		different
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum Operator
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		or,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		and
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public string varName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public string varName2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public object value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public object value2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public bool skipLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public bool readOnly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool hideLabel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Clausule FirstClausule;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Clausule SecondClausule;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Operator _Operator;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2F11970", Offset = "0x2F10370", VA = "0x182F11970")]
	public HideByClausule(string varToCheck, Clausule FirstClausule, object ValueToCheck, Operator _Operator, string secondVarToCheck, Clausule SecondClausule, object SecondValueToCheck, bool skipLine = false, bool readOnly = false, bool hideLabel = false)
	{
		//IL_0016: Expected O, but got I4
		//IL_0024: Expected O, but got I4
		varName = varToCheck;
		varName2 = (string)0;
		value = ValueToCheck;
		value2 = 0;
		this.skipLine = false;
		this.readOnly = false;
		this.hideLabel = false;
		this.SecondClausule = Clausule.equal;
		this.FirstClausule = FirstClausule;
		this._Operator = Operator.or;
	}
}
