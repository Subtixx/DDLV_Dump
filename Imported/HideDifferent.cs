using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HideDifferent : Hidesbase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public string varName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public object value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool skipLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public bool readOnly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool hideLabel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int DisplaceLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public bool HidedOnLastFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public float labelWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public float valueWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool withMold;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F11AB0", Offset = "0x2F104B0", VA = "0x182F11AB0")]
	public HideDifferent(string varToCheck, object ValueToCheck, bool skipLine = false, bool readOnly = false, bool hideLabel = false)
	{
		varName = varToCheck;
		value = ValueToCheck;
		this.readOnly = false;
		this.skipLine = skipLine;
		this.hideLabel = false;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F11BA0", Offset = "0x2F105A0", VA = "0x182F11BA0")]
	public HideDifferent(string varToCheck, object ValueToCheck, bool withMold)
	{
		varName = varToCheck;
		value = ValueToCheck;
		this.withMold = withMold;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F11A20", Offset = "0x2F10420", VA = "0x182F11A20")]
	public HideDifferent(string varToCheck, object ValueToCheck, float ExtendLabel, float valueWidth, bool skipLine = false, bool readOnly = false, bool hideLabel = false)
	{
		//IL_0037: Expected F4, but got I4
		varName = varToCheck;
		value = ValueToCheck;
		this.skipLine = false;
		this.readOnly = false;
		labelWidth = ExtendLabel;
		this.hideLabel = false;
		this.valueWidth = 0f;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2F11B20", Offset = "0x2F10520", VA = "0x182F11B20")]
	public HideDifferent(string varToCheck, object ValueToCheck, int DisplaceLevel, bool skipLine = false, bool readOnly = false, bool hideLabel = false)
	{
		varName = varToCheck;
		value = ValueToCheck;
		this.skipLine = false;
		this.readOnly = false;
		this.DisplaceLevel = DisplaceLevel;
		this.hideLabel = false;
	}
}
