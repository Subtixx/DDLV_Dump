using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public interface INumberHandler
	{
		[Cpp2IlInjected.Token(Token = "0x17000128")]
		float MinValue
		{
			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		float MaxValue
		{
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TryParse(string input, out object value);

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ValuesAreEqual(object value1, object value2);

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object ConvertFromFloat(float value);

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		float ConvertToFloat(object value);
	}
}
