using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class AsyncExtension
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static bool ContinueOnCapturedContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x40325F0", Offset = "0x4030FF0", VA = "0x1840325F0")]
			[CompilerGenerated]
			get
			{
				//IL_0006: Expected I4, but got O
				return (byte)(int)typeof(AsyncExtension).TypeHandle != 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4032630", Offset = "0x4031030", VA = "0x184032630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x40325B0", Offset = "0x4030FB0", VA = "0x1840325B0")]
		public static void EnableContinueOnCapturedContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4032540", Offset = "0x4030F40", VA = "0x184032540")]
		public static ConfiguredTaskAwaitable ConfigureAwait(this Task task)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCF0", Offset = "0x7EE6F0", VA = "0x1807EFCF0")]
		public static ConfiguredTaskAwaitable<T> ConfigureAwait<T>(this Task<T> task)
		{
			throw new NullReferenceException();
		}
	}
}
