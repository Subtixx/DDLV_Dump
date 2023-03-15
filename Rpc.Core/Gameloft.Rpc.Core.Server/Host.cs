using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Server
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class Host : HostBase<ServiceBase>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncServer Server
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x38DDA00", Offset = "0x38DC400", VA = "0x1838DDA00")]
		public Host(AsyncServer server, IEnumerable<ServiceBase> services, IReadOnlyDictionary<Type, object> singletons)
		{
			((HostBase<TServiceType>)(object)this)._002Ector((IEnumerable<>)services, (IReadOnlyDictionary<, >)singletons);
			Server = server;
			/*Error: Unexpected end of block*/;
		}
	}
}
