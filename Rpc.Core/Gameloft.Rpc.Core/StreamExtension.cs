using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class StreamExtension
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const int CopyBufferSize = 4096;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x38E4000", Offset = "0x38E2A00", VA = "0x1838E4000")]
		[AsyncStateMachine(typeof(_003CReadFullyAsync_003Ed__0))]
		public static Task ReadFullyAsync(this Stream stream, byte[] buffer, int offset, int length, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x38E3EC0", Offset = "0x38E28C0", VA = "0x1838E3EC0")]
		[AsyncStateMachine(typeof(_003CReadAsByteArrayAsync_003Ed__2))]
		public static Task<byte[]> ReadAsByteArrayAsync(this Stream stream, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<byte[]>)(object)result;
		}
	}
}
