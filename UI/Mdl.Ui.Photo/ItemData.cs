using System;
using Cpp2IlInjected;

namespace Mdl.Ui.Photo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200093F")]
	public class ItemData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003673")]
		public int itemType = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003674")]
		public int itemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003675")]
		public string itemName = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003676")]
		public uint itemAmount = 1u;

		[Cpp2IlInjected.Token(Token = "0x60039F8")]
		[Cpp2IlInjected.Address(RVA = "0xD35290", Offset = "0xD33C90", VA = "0x180D35290")]
		public ItemData()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_001d: Expected I4, but got I8


		[Cpp2IlInjected.Token(Token = "0x60039F9")]
		[Cpp2IlInjected.Address(RVA = "0xD351E0", Offset = "0xD33BE0", VA = "0x180D351E0")]
		public ItemData(string name = "", int ID = -1, int type = -1, uint amount = 1u)
		{
			//IL_0009: Expected I4, but got I8
			//IL_001d: Expected I4, but got I8
			itemName = name;
			itemType = type;
			itemAmount = 0u;
			itemID = ID;
		}
	}
}
