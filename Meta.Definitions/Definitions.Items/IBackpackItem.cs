using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000652")]
	public interface IBackpackItem : ISellable
	{
		[Cpp2IlInjected.Token(Token = "0x17001318")]
		Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004A3F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001319")]
		string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6004A40")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700131A")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6004A41")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
