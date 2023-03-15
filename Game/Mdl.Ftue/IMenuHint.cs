using Cpp2IlInjected;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x2000583")]
	public interface IMenuHint
	{
		[Cpp2IlInjected.Token(Token = "0x17000341")]
		string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x60018A1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000342")]
		string MenuName
		{
			[Cpp2IlInjected.Token(Token = "0x60018A2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000343")]
		string ElementName
		{
			[Cpp2IlInjected.Token(Token = "0x60018A3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000344")]
		string ElementContainerName
		{
			[Cpp2IlInjected.Token(Token = "0x60018A4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000345")]
		MenuHintScope SearchScope
		{
			[Cpp2IlInjected.Token(Token = "0x60018A5")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000346")]
		float SearchTimeout
		{
			[Cpp2IlInjected.Token(Token = "0x60018A6")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000347")]
		MenuHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x60018A7")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000348")]
		BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x60018A8")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000349")]
		bool SkipIfInactive
		{
			[Cpp2IlInjected.Token(Token = "0x60018A9")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
}
