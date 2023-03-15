using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Activities;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009B0")]
	internal class GardenStallFakeSlot : MonoBehaviour, IPlayerTaskProvider, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003575")]
		public GameObject fakeSapling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003576")]
		public int hourToShowFakeSapling = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003579")]
		[SerializeField]
		private PlayerTaskDefinition _collectGardenStallSlotTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400357A")]
		private GameObject plantedSeedHarvest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400357B")]
		private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x1700067F")]
		public GardenStall GardenStall
		{
			[Cpp2IlInjected.Token(Token = "0x6002D5A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CGardenStall_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D5B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CGardenStall_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000680")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4003578")]
		public int SlotIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6002D5C")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002D5D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3C90", Offset = "0x8C2690", VA = "0x1808C3C90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002D5F")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B40", Offset = "0x8C2540", VA = "0x1808C3B40")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__14))]
		public Task Init(GardenStall gardenStall, int index, GardenStallData.Types.GardenStallSlot gardenStallSlot)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D60")]
		[Cpp2IlInjected.Address(RVA = "0x8C3AD0", Offset = "0x8C24D0", VA = "0x1808C3AD0", Slot = "4")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__15))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__15(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D61")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E30", Offset = "0x8C2830", VA = "0x1808C3E30")]
		public GardenStallFakeSlot()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
