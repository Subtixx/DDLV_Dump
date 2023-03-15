using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core.Client
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class Host : HostBase<ClientBase>
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x38DDA80", Offset = "0x38DC480", VA = "0x1838DDA80")]
		internal Host(IEnumerable<ClientBase> services, IReadOnlyDictionary<Type, object> singletons)
		{
			((HostBase<TServiceType>)(object)this)._002Ector((IEnumerable<>)services, (IReadOnlyDictionary<, >)singletons);
		}
	}
}
