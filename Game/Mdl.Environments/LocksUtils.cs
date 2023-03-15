using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000657")]
	public static class LocksUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6001C4C")]
		[Cpp2IlInjected.Address(RVA = "0xBB9FF0", Offset = "0xBB89F0", VA = "0x180BB9FF0")]
		[AsyncStateMachine(typeof(_003CWaitingAnimationsDone_003Ed__0))]
		public static Task WaitingAnimationsDone(List<Animation> animations, int maxWait)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}
	}
}
