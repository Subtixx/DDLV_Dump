using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000625")]
	public class CastleStairLocksController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024E4")]
		[SerializeField]
		public CastleStairLock[] _stairsLocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024E5")]
		public int _maxWait = 2;

		[Cpp2IlInjected.Token(Token = "0x6001B46")]
		[Cpp2IlInjected.Address(RVA = "0x12D8390", Offset = "0x12D6D90", VA = "0x1812D8390")]
		private void Start()
		{
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B47")]
		[Cpp2IlInjected.Address(RVA = "0x12D84F0", Offset = "0x12D6EF0", VA = "0x1812D84F0")]
		[AsyncStateMachine(typeof(_003CUpdateThorns_003Ed__3))]
		public Task UpdateThorns()
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B48")]
		[Cpp2IlInjected.Address(RVA = "0x12D8270", Offset = "0x12D6C70", VA = "0x1812D8270")]
		[AsyncStateMachine(typeof(_003CRemoveStairsThorn_003Ed__4))]
		private Task RemoveStairsThorn(GameObject objectRoot)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B49")]
		[Cpp2IlInjected.Address(RVA = "0x12D8170", Offset = "0x12D6B70", VA = "0x1812D8170")]
		[AsyncStateMachine(typeof(_003COnBuidingUpgraded_003Ed__5))]
		private void OnBuidingUpgraded(GridObject gridObj, UpgradeData upData)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B4A")]
		[Cpp2IlInjected.Address(RVA = "0x12D8610", Offset = "0x12D7010", VA = "0x1812D8610")]
		public CastleStairLocksController()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
