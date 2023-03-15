using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007AE")]
	public sealed class RequiredComponentAttribute : RequiredAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BAA")]
		private readonly Type componentType;

		[Cpp2IlInjected.Token(Token = "0x600222C")]
		[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
		public RequiredComponentAttribute(Type componentType)
		{
			this.componentType = componentType;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600222D")]
		[Cpp2IlInjected.Address(RVA = "0xCC17D0", Offset = "0xCC01D0", VA = "0x180CC17D0", Slot = "7")]
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
