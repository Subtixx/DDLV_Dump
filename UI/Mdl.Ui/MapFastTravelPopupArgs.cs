using System.Xml.Schema;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000628")]
	public class MapFastTravelPopupArgs : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002246")]
		public MapMenu MapMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002247")]
		public int TabIndex;

		[Cpp2IlInjected.Token(Token = "0x600282A")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public MapFastTravelPopupArgs()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
