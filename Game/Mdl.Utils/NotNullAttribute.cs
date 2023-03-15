using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.ClientModels;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007AC")]
	public sealed class NotNullAttribute : RequiredAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6002222")]
		[Cpp2IlInjected.Address(RVA = "0xF03400", Offset = "0xF01E00", VA = "0x180F03400", Slot = "7")]
		[IteratorStateMachine(typeof(_003CGetErrors_003Ed__0))]
		public override IEnumerable<string> GetErrors(object value)
		{
			new _003CGetErrors_003Ed__0(-2)._003C_003E3__value = value;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002223")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8E0", Offset = "0x8BA2E0", VA = "0x1808BB8E0")]
		public NotNullAttribute()
		{
			((LinkGoogleAccountResult)(object)this)._002Ector();
		}
	}
}
