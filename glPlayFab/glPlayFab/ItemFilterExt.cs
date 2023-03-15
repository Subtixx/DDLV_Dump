using System;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.EconomyModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class ItemFilterExt
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1032830", Offset = "0x1031230", VA = "0x181032830")]
		public static string Serialize(this ItemFilter self)
		{
			ISerializerPlugin plugin = PluginManager.GetPlugin<ISerializerPlugin>(PluginContract.PlayFab_Serializer, "");
			throw new NullReferenceException();
		}
	}
}
