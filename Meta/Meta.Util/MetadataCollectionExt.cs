using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Rpc.Core;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000B27")]
	public static class MetadataCollectionExt
	{
		[Cpp2IlInjected.Token(Token = "0x6005E43")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D10", Offset = "0x7F3710", VA = "0x1807F4D10")]
		public static bool TryGetBytes(this MetadataCollection self, string key, out byte[] bytes)
		{
			//Discarded unreachable code: IL_001d
			//IL_001b: Expected I4, but got O
			bool flag = self.ContainsKey(key);
			if (flag)
			{
				byte[] bytes2 = self.GetBytes(key);
				System.Runtime.CompilerServices.Unsafe.As<byte[], byte>(ref bytes).m_value = (byte)(int)bytes2;
			}
			return flag;
		}
	}
}
