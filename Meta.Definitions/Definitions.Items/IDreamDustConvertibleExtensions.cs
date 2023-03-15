using Cpp2IlInjected;
using Definitions.DreamDust;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000681")]
	public static class IDreamDustConvertibleExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6004ABE")]
		[Cpp2IlInjected.Address(RVA = "0x27B1D20", Offset = "0x27B0720", VA = "0x1827B1D20")]
		public unsafe static bool GetDreamDustValue(this IDreamDustConvertible dreamDustConvertible, out int amount)
		{
			//Discarded unreachable code: IL_0043
			//IL_000d: Expected I4, but got O
			//IL_003d: Expected I4, but got O
			//IL_0043: Expected I4, but got O
			int num = 0;
			amount.m_value = (int)"DreamDustConversionValues";
			if ("DreamDustConversionValues" == null)
			{
				bool flag = ProtoDatabase.Instance.TryGet("DreamDustConversionValues", out *(ConversionValues*)num);
				IItemData itemData = default(IItemData);
				if (itemData != null && (itemData != null || itemData != null || itemData != null))
				{
					amount.m_value = (int)itemData;
				}
			}
			return (byte)(int)"DreamDustConversionValues" != 0;
		}
	}
}
