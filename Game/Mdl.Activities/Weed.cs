using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Util;
using Mdl.Grid;
using Mdl.Navigation;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B93")]
	public class Weed : MonoBehaviour, IPlayerTaskData, IDefaultGridStateProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004075")]
		public string avatarAnimationTrigger = "Removal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004076")]
		public string avatarAnimationState = "removal";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004077")]
		public GameObject avatarAnimationHandVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004078")]
		public GameObject avatarAnimationRootVFXPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700073B")]
		public WeedData WeedData
		{
			[Cpp2IlInjected.Token(Token = "0x6003583")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CWeedData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003584")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CWeedData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003585")]
		[Cpp2IlInjected.Address(RVA = "0x840E20", Offset = "0x83F820", VA = "0x180840E20", Slot = "4")]
		public void InitFromGridState(GridState gridState)
		{
			//IL_001f: Expected O, but got I4
			if (gridState != null)
			{
				WeedData weedData = gridState.WeedData;
				if (weedData != null)
				{
					WeedData weedData2 = weedData.Clone();
				}
			}
			int num = 0;
			WeedData = (WeedData)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003586")]
		[Cpp2IlInjected.Address(RVA = "0x840D80", Offset = "0x83F780", VA = "0x180840D80", Slot = "5")]
		public bool ForceGridState(ref GridState gridState, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0023
			if ((long)WeedData == 0)
			{
				int num = 0;
			}
			GridState gridState2 = new GridState();
			WeedData weedData2 = (gridState2.WeedData = WeedData);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003587")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public void ChangeGridState(GridState gridState, ITransactionContext context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003588")]
		[Cpp2IlInjected.Address(RVA = "0x840E70", Offset = "0x83F870", VA = "0x180840E70")]
		public Weed()
		{
		}
	}
}
