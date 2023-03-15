using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009C2")]
	public class StallShelfInteractionEventArgs : EventArgs
	{
		[Cpp2IlInjected.Token(Token = "0x1700068B")]
		public ShoppingStall Stall
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CStall_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DB2")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CStall_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700068C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40035CF")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002DB4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700068D")]
		public GameObject Shelf
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CShelf_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DB6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CShelf_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB7")]
		[Cpp2IlInjected.Address(RVA = "0xF5B650", Offset = "0xF5A050", VA = "0x180F5B650")]
		public StallShelfInteractionEventArgs()
		{
		}
	}
}
