using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002E6")]
	public class CharacterSummonMenuParam : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000E0C")]
		public Item CharacterItem;

		[Cpp2IlInjected.Token(Token = "0x60012AE")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public CharacterSummonMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
