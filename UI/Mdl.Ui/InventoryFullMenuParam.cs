using System;
using System.Collections.Generic;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005D2")]
	public class InventoryFullMenuParam : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002063")]
		public IEnumerable<ItemInstance> ItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002064")]
		public IEnumerable<int> UnavailablePositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002065")]
		public Action<List<int>> OnDropAction;

		[Cpp2IlInjected.Token(Token = "0x600262F")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public InventoryFullMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
