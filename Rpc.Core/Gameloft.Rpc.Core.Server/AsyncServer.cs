using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class AsyncServer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly bool ownTransport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private bool disposedValue;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400009B")]
		public ITransport Transport
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400009C")]
		public IRequestProcessor Processor
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x38D99A0", Offset = "0x38D83A0", VA = "0x1838D99A0")]
		public AsyncServer(IEnumerable<ICallInvoker> services, ITransport transport, [Optional] ILogger logger, bool ownTransport = true)
		{
			Transport = transport;
			this.ownTransport = false;
			if (logger == null)
			{
			}
			DefaultProcessor defaultProcessor = (DefaultProcessor)(Processor = new DefaultProcessor((IEnumerable<>)services, logger));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x38D9810", Offset = "0x38D8210", VA = "0x1838D9810")]
		public Task StartAsync(CancellationToken token)
		{
			//Discarded unreachable code: IL_0025
			ITransport transport = Transport;
			IRequestProcessor processor = Processor;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return transport.StartAsync(processor, token);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x38D98E0", Offset = "0x38D82E0", VA = "0x1838D98E0")]
		public Task StopAsync(CancellationToken token)
		{
			//Discarded unreachable code: IL_001d
			ITransport transport = Transport;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return transport.StopAsync(token);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x38D96E0", Offset = "0x38D80E0", VA = "0x1838D96E0")]
		[AsyncStateMachine(typeof(_003CRunAsync_003Ed__10))]
		public Task RunAsync(CancellationToken token)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x38D9660", Offset = "0x38D8060", VA = "0x1838D9660")]
		private void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (!disposing || !ownTransport || (object)typeof(IDisposable).TypeHandle != null)
				{
				}
				disposedValue = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x38D95F0", Offset = "0x38D7FF0", VA = "0x1838D95F0", Slot = "4")]
		public void Dispose()
		{
			if (!disposedValue)
			{
				if (!ownTransport || (object)typeof(IDisposable).TypeHandle != null)
				{
				}
				disposedValue = true;
			}
		}
	}
}
