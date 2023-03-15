using System.Xml.Schema;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000673")]
	public class PromptParams : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400241E")]
		public PromptData data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400241F")]
		public bool goToStartOnExit;

		[Cpp2IlInjected.Token(Token = "0x60029B3")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public PromptParams()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
