using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200050F")]
	public class TimeLimitedEventOpeningPopUpParam : MenuParam
	{
		[Cpp2IlInjected.Token(Token = "0x1700052B")]
		public MegaEventData Data
		{
			[Cpp2IlInjected.Token(Token = "0x60020F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60020F6")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020F7")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public TimeLimitedEventOpeningPopUpParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
