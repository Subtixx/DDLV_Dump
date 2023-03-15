using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200064E")]
	public interface IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x1700130F")]
		int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6004A32")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001310")]
		Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004A33")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001311")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004A34")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001312")]
		string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6004A35")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001313")]
		string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004A36")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001314")]
		string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004A37")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6004A38")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IItemData Clone();
	}
}
