using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x2000727")]
	public static class DisplayExt
	{
		[Cpp2IlInjected.Token(Token = "0x6004F58")]
		[Cpp2IlInjected.Address(RVA = "0x2C3F460", Offset = "0x2C3DE60", VA = "0x182C3F460")]
		public static List<LayoutInfo.AreaSize> GetAreas(this LayoutType type, int sizeX, int sizeY)
		{
			//Discarded unreachable code: IL_0018
			LayoutInfo layoutInfo = new LayoutInfo();
			layoutInfo.type_ = type;
			return (List<LayoutInfo.AreaSize>)(object)layoutInfo.GetAreas(sizeX, sizeY);
		}
	}
}
