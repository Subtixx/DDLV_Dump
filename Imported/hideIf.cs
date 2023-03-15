using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200002D")]
public class hideIf : Hidesbase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public string varName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public object value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool skipLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool readOnly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float labelWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float valueWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool withMold;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD990", Offset = "0x3DCC390", VA = "0x183DCD990")]
	public hideIf(string varToCheck, object ValueToCheck, bool drawNextInThisLine = true, bool readOnly = false, float labelWidth = 0f, float valueWidth = 0f)
	{
		//IL_0022: Expected F4, but got I4
		//IL_0029: Expected F4, but got I4
		varName = varToCheck;
		value = ValueToCheck;
		skipLine = drawNextInThisLine;
		this.labelWidth = 0f;
		this.valueWidth = 0f;
		this.readOnly = false;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD850", Offset = "0x3DCC250", VA = "0x183DCD850")]
	public hideIf(string varToCheck, object ValueToCheck, bool withMold)
	{
		varName = varToCheck;
		value = ValueToCheck;
		this.withMold = withMold;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD8B0", Offset = "0x3DCC2B0", VA = "0x183DCD8B0")]
	public hideIf(string value, float labelWidth = 0f, float valueWidth = 0f)
	{
		this.value = value;
		this.labelWidth = labelWidth;
		this.valueWidth = valueWidth;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD910", Offset = "0x3DCC310", VA = "0x183DCD910")]
	public hideIf(string varToCheck, object ValueToCheck, float labelWidth, float valueWidth, bool drawNextInThisLine = true, bool readOnly = false)
	{
		//IL_0030: Expected F4, but got I4
		varName = varToCheck;
		value = ValueToCheck;
		skipLine = false;
		this.labelWidth = labelWidth;
		this.readOnly = false;
		this.valueWidth = 0f;
	}
}
