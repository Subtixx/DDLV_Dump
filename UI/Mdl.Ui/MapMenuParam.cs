using System.Xml.Schema;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000632")]
	public class MapMenuParam : MenuParam
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002283")]
		public bool ShowCharacters = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4002284")]
		public bool ShowCrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4002285")]
		public bool ShowFastTravelDestinations = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x4002286")]
		public bool IsInTutorial;

		[Cpp2IlInjected.Token(Token = "0x600285F")]
		[Cpp2IlInjected.Address(RVA = "0x117D790", Offset = "0x117C190", VA = "0x18117D790")]
		public MapMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
