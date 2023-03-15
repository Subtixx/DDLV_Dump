using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HideIfAnyIsDifferent : Hidesbase
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum teste
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		oi,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		eita
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public string varName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public string varName2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public object value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public object value2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool skipLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool readOnly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public bool hideLabel;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2F11C00", Offset = "0x2F10600", VA = "0x182F11C00")]
	public HideIfAnyIsDifferent(string varToCheck, object ValueToCheck, string secondVarToCheck, object SecondValueToCheck, bool skipLine = false, bool readOnly = false, bool hideLabel = false)
	{
		//IL_0022: Expected O, but got I4
		varName = varToCheck;
		varName2 = secondVarToCheck;
		value = ValueToCheck;
		value2 = 0;
		this.skipLine = false;
		this.readOnly = false;
		this.hideLabel = false;
	}
}
