using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000670")]
	public interface ITrimmingData
	{
		[Cpp2IlInjected.Token(Token = "0x1700134E")]
		string MaterialAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004A80")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700134F")]
		string AccentPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004A81")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
