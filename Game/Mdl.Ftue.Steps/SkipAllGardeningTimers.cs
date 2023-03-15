using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Activities;
using Mdl.Grid;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x200059D")]
	[CreateAssetMenu]
	public class SkipAllGardeningTimers : FtueStep, IMenuHint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002295")]
		public string skipButtonName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002296")]
		public string elementContainerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002297")]
		public string menuName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002298")]
		public MenuHintScope searchScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4002299")]
		public float searchTimeout = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400229A")]
		public string messageKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400229B")]
		public BubblePosition bubblePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400229C")]
		public bool skipIfInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400229D")]
		private Client client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400229E")]
		private List<GardeningSlot> validSlots = (List<GardeningSlot>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400229F")]
		private CancellationTokenSource ctSource;

		[Cpp2IlInjected.Token(Token = "0x17000379")]
		public string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x6001913")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "5")]
			get
			{
				return messageKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037A")]
		public string ElementName
		{
			[Cpp2IlInjected.Token(Token = "0x6001914")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "7")]
			get
			{
				return skipButtonName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037B")]
		public string ElementContainerName
		{
			[Cpp2IlInjected.Token(Token = "0x6001915")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "8")]
			get
			{
				return elementContainerName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037C")]
		public string MenuName
		{
			[Cpp2IlInjected.Token(Token = "0x6001916")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "6")]
			get
			{
				return menuName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037D")]
		public MenuHintScope SearchScope
		{
			[Cpp2IlInjected.Token(Token = "0x6001917")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "9")]
			get
			{
				return searchScope;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037E")]
		public float SearchTimeout
		{
			[Cpp2IlInjected.Token(Token = "0x6001918")]
			[Cpp2IlInjected.Address(RVA = "0xF50B10", Offset = "0xF4F510", VA = "0x180F50B10", Slot = "10")]
			get
			{
				return searchTimeout;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037F")]
		public MenuHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x6001919")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "11")]
			get
			{
				return MenuHintCompletion.PressButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000380")]
		public BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x600191A")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "12")]
			get
			{
				return bubblePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000381")]
		public bool SkipIfInactive
		{
			[Cpp2IlInjected.Token(Token = "0x600191B")]
			[Cpp2IlInjected.Address(RVA = "0x9657A0", Offset = "0x9641A0", VA = "0x1809657A0", Slot = "13")]
			get
			{
				return skipIfInactive;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600191C")]
		[Cpp2IlInjected.Address(RVA = "0xF54900", Offset = "0xF53300", VA = "0x180F54900", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__29))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x600191D")]
		[Cpp2IlInjected.Address(RVA = "0xF549F0", Offset = "0xF533F0", VA = "0x180F549F0")]
		private void OnGardeningEvent(Meta.Grids.Grid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, [Optional] bool? inVillage, bool burningState = false)
		{
			//Discarded unreachable code: IL_0046
			//IL_0034: Expected O, but got I4
			List<GardeningSlot> list = validSlots;
			Func<GardeningSlot, bool> func = (Func<GardeningSlot, bool>)(object)(Func<T, TResult>)delegate(GardeningSlot slot)
			{
				//Discarded unreachable code: IL_0018
				GridObjectScript _003CGridObjectScript_003Ek__BackingField = ((GridObjectStateUser)slot).GridObjectScript;
				GridObject gridObject2 = gridObject;
				return _003CGridObjectScript_003Ek__BackingField.GridObject == gridObject2;
			};
			GardeningSlot gardeningSlot = Enumerable.FirstOrDefault<GardeningSlot>((IEnumerable<>)list, (Func<, >)(object)func);
			int num = 0;
			if (gardeningSlot != (UnityEngine.Object)num)
			{
				bool flag = ((List<T>)(object)validSlots).Remove((T)gardeningSlot);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600191E")]
		[Cpp2IlInjected.Address(RVA = "0xF54B50", Offset = "0xF53550", VA = "0x180F54B50")]
		public SkipAllGardeningTimers()
		{
		}
	}
}
