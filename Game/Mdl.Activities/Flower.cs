using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Activities;
using Mdl.Grid;
using Mdl.Navigation;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B5B")]
	public class Flower : GridObjectStateUser, IPlayerTaskProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003F25")]
		[SerializeField]
		private PlayerTaskDefinition _pickUpFlowerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003F26")]
		private WaterStateDisplay waterStateDisplay;

		[Cpp2IlInjected.Token(Token = "0x600347C")]
		[Cpp2IlInjected.Address(RVA = "0x1457740", Offset = "0x1456140", VA = "0x181457740", Slot = "5")]
		protected override void Start()
		{
			WaterStateDisplay waterStateDisplay = (this.waterStateDisplay = GetComponent<WaterStateDisplay>());
			base.Start();
		}

		[Cpp2IlInjected.Token(Token = "0x600347D")]
		[Cpp2IlInjected.Address(RVA = "0x14574F0", Offset = "0x1455EF0", VA = "0x1814574F0", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_004f
			//IL_0028: Expected O, but got I4
			if (gridObject == null)
			{
				return;
			}
			GridState state_ = gridObject.state_;
			if (state_ != null && state_.FlowerData != null)
			{
				WaterStateDisplay waterStateDisplay = this.waterStateDisplay;
				int num = 0;
				if (waterStateDisplay != (UnityEngine.Object)num)
				{
					GridState state_2 = gridObject.state_;
					WaterStateDisplay waterStateDisplay2 = this.waterStateDisplay;
					int wateringState = 0;
					FlowerData flowerData = state_2.FlowerData;
					waterStateDisplay2.UpdateVisual((WateringState)wateringState);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600347E")]
		[Cpp2IlInjected.Address(RVA = "0x1457480", Offset = "0x1455E80", VA = "0x181457480", Slot = "8")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__4))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__4(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600347F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public Flower()
		{
		}
	}
}
