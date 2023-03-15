using System;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Service;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class OnlineEnvironmentExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x28C3B30", Offset = "0x28C2530", VA = "0x1828C3B30")]
		public unsafe static OnlineEnvironment SetMutablePayloadField(this OnlineEnvironment env, string field, object value)
		{
			//Discarded unreachable code: IL_0014
			//IL_0012: Expected O, but got I4
			//IL_000d: Expected native int or pointer, but got O
			bool flag = default(bool);
			if (flag)
			{
			}
			int stringLength = field.m_stringLength;
			((OnlineEnvironment*)(IntPtr)env)->EventScope = (EventScope)stringLength;
			return env;
		}
	}
}
