using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000946")]
	internal struct CameraCollisionFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400336E")]
		public ItemType[] Items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400336F")]
		public FurnitureItemType[] FurnitureItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003370")]
		public ActivityItemType[] ActivityItems;
	}
}
