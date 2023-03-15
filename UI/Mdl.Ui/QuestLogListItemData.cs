using Cpp2IlInjected;
using Definitions.Items;
using Meta.Missions;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000683")]
	public struct QuestLogListItemData
	{
		[Cpp2IlInjected.Token(Token = "0x2000684")]
		public enum CategoryType
		{
			[Cpp2IlInjected.Token(Token = "0x40024B1")]
			Realm,
			[Cpp2IlInjected.Token(Token = "0x40024B2")]
			Story,
			[Cpp2IlInjected.Token(Token = "0x40024B3")]
			Event,
			[Cpp2IlInjected.Token(Token = "0x40024B4")]
			Friendship
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40024AD")]
		public CategoryType Category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40024AE")]
		public MissionSlot Mission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024AF")]
		public MissionItemData MissionItemData;
	}
}
