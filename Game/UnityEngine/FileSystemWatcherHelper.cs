using Cpp2IlInjected;

namespace UnityEngine
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public static class FileSystemWatcherHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x136E7F0", Offset = "0x136D1F0", VA = "0x18136E7F0")]
		public static bool IsCurrentPlatformSupported()
		{
			int num = 0;
			if (Application.platform == RuntimePlatform.OSXEditor)
			{
			}
			int num2 = 0;
			return !Application.isBatchMode;
		}
	}
}
