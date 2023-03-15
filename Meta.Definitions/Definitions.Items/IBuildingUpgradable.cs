using Cpp2IlInjected;
using Google.Protobuf.Collections;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000684")]
	public interface IBuildingUpgradable
	{
		[Cpp2IlInjected.Token(Token = "0x17001364")]
		RepeatedField<UpgradeData> UpgradeInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
