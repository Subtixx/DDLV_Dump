using Cpp2IlInjected;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IFlightPedalsTemplate : IControllerTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		IControllerTemplateAxis leftPedal
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		IControllerTemplateAxis rightPedal
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		IControllerTemplateAxis slide
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
