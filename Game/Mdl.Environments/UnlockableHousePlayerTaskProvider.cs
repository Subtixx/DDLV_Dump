using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Items;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200069E")]
	internal class UnlockableHousePlayerTaskProvider : MonoBehaviour, IPlayerTaskProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400272C")]
		[SerializeField]
		private PlayerTaskDefinition _enterEnvironmentTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400272D")]
		private ItemScript itemScript;

		[Cpp2IlInjected.Token(Token = "0x6001D56")]
		[Cpp2IlInjected.Address(RVA = "0xD394D0", Offset = "0xD37ED0", VA = "0x180D394D0", Slot = "4")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__2))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__2(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D57")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public UnlockableHousePlayerTaskProvider()
		{
		}
	}
}
