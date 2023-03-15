using Cpp2IlInjected;

namespace NodeCanvas.DialogueTrees.Gameloft.Flux
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public interface IFluxStatement
	{
		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		int xp
		{
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		string choiceID
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		bool AutoSkip
		{
			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
