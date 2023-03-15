using Cpp2IlInjected;
using Gameloft.Localization.Core;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200105B")]
	public interface IMissionIdentifier
	{
		[Cpp2IlInjected.Token(Token = "0x170016FD")]
		IMissionIdentifier IdentifierParent
		{
			[Cpp2IlInjected.Token(Token = "0x60084AF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170016FE")]
		int IdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x60084B0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170016FF")]
		string IdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x60084B1")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001700")]
		string FullIdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x60084B2")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001701")]
		string FullIdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x60084B3")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60084AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object ResolveKey(Localizator localizator, string key);
	}
}
