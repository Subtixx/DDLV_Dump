using Cpp2IlInjected;

namespace UnityEngine
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class AsyncOperationExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA45BA0", Offset = "0xA445A0", VA = "0x180A45BA0")]
		public static AsyncOperationAwaiter GetAwaiter(this AsyncOperation asyncOperation)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA45B40", Offset = "0xA44540", VA = "0x180A45B40")]
		public static AsyncOperationAwaiter ConfigureUnityContext(this AsyncOperation asyncOperation, bool useUnityContext)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
