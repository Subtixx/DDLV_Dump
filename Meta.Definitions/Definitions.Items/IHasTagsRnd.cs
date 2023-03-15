using System.Collections.Generic;
using Cpp2IlInjected;
using Google.Protobuf.Collections;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200065C")]
	public interface IHasTagsRnd
	{
		[Cpp2IlInjected.Token(Token = "0x17001327")]
		IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004A55")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001328")]
		RepeatedField<TagGroupWithRndOption> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6004A56")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
