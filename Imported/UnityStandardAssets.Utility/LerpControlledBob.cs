using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class LerpControlledBob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public float BobDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float BobAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private float m_Offset;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
		public float Offset()
		{
			return m_Offset;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2F16490", Offset = "0x2F14E90", VA = "0x182F16490")]
		[IteratorStateMachine(typeof(_003CDoBobCycle_003Ed__4))]
		public IEnumerator DoBobCycle()
		{
			int _003C_003E1__state = default(int);
			_003CDoBobCycle_003Ed__4 _003CDoBobCycle_003Ed__ = new _003CDoBobCycle_003Ed__4(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CDoBobCycle_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LerpControlledBob()
		{
		}
	}
}
