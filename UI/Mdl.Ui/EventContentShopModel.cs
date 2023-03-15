using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200045D")]
	public class EventContentShopModel : EventContentModelBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001606")]
		public List<ShopProductModel> Products;

		[Cpp2IlInjected.Token(Token = "0x6001C37")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public EventContentShopModel()
		{
		}
	}
}
