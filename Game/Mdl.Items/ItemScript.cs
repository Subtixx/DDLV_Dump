using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Navigation;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003BC")]
	public class ItemScript : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400190A")]
		[ItemID]
		[SerializeField]
		private int _item;

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600101C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				int item = _item;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600101D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ItemScript()
		{
		}
	}
}
