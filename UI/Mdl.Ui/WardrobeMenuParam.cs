using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200078E")]
	[RequiredAllNotNull]
	public class WardrobeMenuParam : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002BF4")]
		public ItemFilterData ItemFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002BF5")]
		public string CategoryFilter;

		[Cpp2IlInjected.Token(Token = "0x6003044")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public WardrobeMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
