using Cpp2IlInjected;
using Gameloft.Rpc.Core;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000FB6")]
	public static class MetadataCollectionExtension
	{
		[Cpp2IlInjected.Token(Token = "0x6007F42")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D90", Offset = "0x7F3790", VA = "0x1807F4D90")]
		public static int GetPlayerId(this MetadataCollection metaCollection)
		{
			//Discarded unreachable code: IL_001c
			if (metaCollection.ContainsKey("networkplayerid"))
			{
				return metaCollection.GetInt("networkplayerid");
			}
			return 0;
		}
	}
}
