using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000462")]
	public class EventMenuParam : MenuParam
	{
		[Cpp2IlInjected.Token(Token = "0x170004A9")]
		public MegaEventData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6001C4F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C50")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C51")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public EventMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
