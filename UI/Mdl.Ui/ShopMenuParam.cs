using System.Xml.Schema;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006D1")]
	public class ShopMenuParam : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400267B")]
		public ShopMenu.ShopMenuTabs ShopMenuTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400267C")]
		public bool BlockMenuNavgation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x400267D")]
		public bool BlockSubMenuTab;

		[Cpp2IlInjected.Token(Token = "0x6002BC4")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public ShopMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
