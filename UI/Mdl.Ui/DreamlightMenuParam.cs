using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000442")]
	internal class DreamlightMenuParam : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001593")]
		public AchievementType AchievementType;

		[Cpp2IlInjected.Token(Token = "0x6001B95")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public DreamlightMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
