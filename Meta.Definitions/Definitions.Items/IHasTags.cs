using System.Collections.Generic;
using Cpp2IlInjected;
using Google.Protobuf.Collections;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200065B")]
	public interface IHasTags
	{
		[Cpp2IlInjected.Token(Token = "0x17001325")]
		IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004A53")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001326")]
		RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6004A54")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
