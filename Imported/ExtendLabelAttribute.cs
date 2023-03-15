using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ExtendLabelAttribute : Hidesbase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float valueWidth;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2F109C0", Offset = "0x2F0F3C0", VA = "0x182F109C0")]
	public ExtendLabelAttribute(float size, float valueWidth = 32f)
	{
		this.size = size;
		this.valueWidth = valueWidth;
	}
}
