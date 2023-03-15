using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002D7")]
	[RequiredAllNotNull]
	public class CatalogMenuParam : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000D62")]
		public bool ActiveDesignChallenge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000D63")]
		public bool ForceOpenCatalog = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000D64")]
		public bool IsInEditMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000D65")]
		public ItemFilterData ItemFilterData;

		[Cpp2IlInjected.Token(Token = "0x600121F")]
		[Cpp2IlInjected.Address(RVA = "0xFEF470", Offset = "0xFEDE70", VA = "0x180FEF470")]
		public CatalogMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001220")]
		[Cpp2IlInjected.Address(RVA = "0xFEF460", Offset = "0xFEDE60", VA = "0x180FEF460")]
		public CatalogMenuParam(MenuParam other)
			: base(other)
		{
		}
	}
}
