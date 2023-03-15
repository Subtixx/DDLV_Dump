using Cpp2IlInjected;
using Definitions.Activities;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000713")]
	public interface IGridUpgradeStateData
	{
		[Cpp2IlInjected.Token(Token = "0x17001422")]
		UpgradeState UpgradeState
		{
			[Cpp2IlInjected.Token(Token = "0x6004EDC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004EDD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
