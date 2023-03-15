using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.ClientModels;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007B0")]
	public sealed class StringIdAttribute : RequiredAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BB1")]
		private readonly bool canBeNullOrEmpty;

		[Cpp2IlInjected.Token(Token = "0x6002236")]
		[Cpp2IlInjected.Address(RVA = "0x10644C0", Offset = "0x1062EC0", VA = "0x1810644C0")]
		public StringIdAttribute(bool canBeNullOrEmpty = false)
		{
			((LinkGoogleAccountResult)(object)this)._002Ector();
			this.canBeNullOrEmpty = canBeNullOrEmpty;
		}

		[Cpp2IlInjected.Token(Token = "0x6002237")]
		[Cpp2IlInjected.Address(RVA = "0x1064430", Offset = "0x1062E30", VA = "0x181064430", Slot = "7")]
		[IteratorStateMachine(typeof(_003CGetErrors_003Ed__2))]
		public override IEnumerable<string> GetErrors(object value)
		{
			_003CGetErrors_003Ed__2 _003CGetErrors_003Ed__ = new _003CGetErrors_003Ed__2(-2);
			_003CGetErrors_003Ed__._003C_003E4__this = this;
			_003CGetErrors_003Ed__._003C_003E3__value = value;
			throw new NullReferenceException();
		}
	}
}
