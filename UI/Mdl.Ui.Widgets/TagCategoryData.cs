using System;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui.Widgets
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000992")]
	public struct TagCategoryData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003887")]
		public TagItemType tagType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4003888")]
		public string locKeySuffix;
	}
}
