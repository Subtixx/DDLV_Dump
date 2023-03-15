using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Util;
using Mdl.Grid;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B1C")]
	public class Blocker : MonoBehaviour, IDefaultGridStateProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DD4")]
		public RewardSpawnAnimationData rewardSpawnAnimationDataOverride;

		[Cpp2IlInjected.Token(Token = "0x170006FC")]
		public BlockerData BlockerData
		{
			[Cpp2IlInjected.Token(Token = "0x6003335")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CBlockerData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003336")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CBlockerData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003337")]
		[Cpp2IlInjected.Address(RVA = "0x1641DE0", Offset = "0x16407E0", VA = "0x181641DE0", Slot = "4")]
		public void InitFromGridState(GridState gridState)
		{
			//IL_001f: Expected O, but got I4
			if (gridState != null)
			{
				BlockerData blockerData = gridState.BlockerData;
				if (blockerData != null)
				{
					BlockerData blockerData2 = blockerData.Clone();
				}
			}
			int num = 0;
			BlockerData = (BlockerData)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003338")]
		[Cpp2IlInjected.Address(RVA = "0x1641D40", Offset = "0x1640740", VA = "0x181641D40", Slot = "5")]
		public bool ForceGridState(ref GridState gridState, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0023
			if ((long)BlockerData == 0)
			{
				int num = 0;
			}
			GridState gridState2 = new GridState();
			BlockerData blockerData2 = (gridState2.BlockerData = BlockerData);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003339")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public void ChangeGridState(GridState gridState, ITransactionContext context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600333A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public Blocker()
		{
		}
	}
}
