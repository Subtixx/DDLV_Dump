using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Rewards;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000503")]
	public class PresentPopUpParam : MenuParam
	{
		[Cpp2IlInjected.Token(Token = "0x17000520")]
		public List<ItemReward> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x600209A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CRewards_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600209B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CRewards_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000521")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4001B07")]
		public int BoxIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600209C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600209D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600209E")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public PresentPopUpParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
