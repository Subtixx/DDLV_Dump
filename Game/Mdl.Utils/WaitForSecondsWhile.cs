using System;
using System.ComponentModel;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000738")]
	public sealed class WaitForSecondsWhile : CustomYieldInstruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40029F3")]
		private Func<bool> m_Predicate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40029F4")]
		private float m_timeout;

		[Cpp2IlInjected.Token(Token = "0x1700048E")]
		public override bool keepWaiting
		{
			[Cpp2IlInjected.Token(Token = "0x6002006")]
			[Cpp2IlInjected.Address(RVA = "0xD4C8E0", Offset = "0xD4B2E0", VA = "0x180D4C8E0", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_002d
				float timeout = m_timeout;
				int num = 0;
				float deltaTime = Time.deltaTime;
				int num2 = 0;
				m_timeout = timeout;
				int num3 = 0;
				return m_Predicate() != null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002005")]
		[Cpp2IlInjected.Address(RVA = "0xD4C810", Offset = "0xD4B210", VA = "0x180D4C810")]
		private bool WaitForSecondsWhileProcess()
		{
			//Discarded unreachable code: IL_001a, IL_0029
			float timeout = m_timeout;
			int num = 0;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			m_timeout = timeout;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002007")]
		[Cpp2IlInjected.Address(RVA = "0xD4C890", Offset = "0xD4B290", VA = "0x180D4C890")]
		public WaitForSecondsWhile(float timeout, Func<bool> predicate)
		{
			((ComponentEditor)(object)this)._002Ector();
			m_Predicate = predicate;
			m_timeout = timeout;
		}
	}
}
