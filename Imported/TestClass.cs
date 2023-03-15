using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000034")]
public class TestClass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public int IntField;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool field;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int IntProperty
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	public void VoidMethod()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
	public TestClass()
	{
		VoidMethod();
	}
}
