using Cpp2IlInjected;
using Definitions.Items;
using Meta;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x20006AC")]
	internal class WallpaperSetter : TrimmingSetter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400276F")]
		[SerializeField]
		private House.Types.WallPosition _wallPosition;

		[Cpp2IlInjected.Token(Token = "0x17000427")]
		public House.Types.WallPosition WallPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001D9B")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get
			{
				return _wallPosition;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D9C")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set
			{
				_wallPosition = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000428")]
		public override TrimmingItemType HandledTrimmingItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6001D9D")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "4")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D9E")]
		[Cpp2IlInjected.Address(RVA = "0xD4DE40", Offset = "0xD4C840", VA = "0x180D4DE40")]
		public WallpaperSetter()
		{
		}
	}
}
