using Cpp2IlInjected;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x200050C")]
	public interface IKey
	{
		[Cpp2IlInjected.Token(Token = "0x170002EA")]
		float time
		{
			[Cpp2IlInjected.Token(Token = "0x600167C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600167D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002EB")]
		float duration
		{
			[Cpp2IlInjected.Token(Token = "0x600167E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600167F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}
	}
}
