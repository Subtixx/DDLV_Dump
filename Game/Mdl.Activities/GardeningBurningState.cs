using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B1F")]
	internal class GardeningBurningState : BurningState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003DE2")]
		[SerializeField]
		private float _interactiblePriorityOverrideDistance = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4003DE3")]
		[SerializeField]
		private float _interactiblePriorityOverrideDuration = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003DE4")]
		private GardeningSlot gardeningSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003DE5")]
		private string vfxPrefabAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003DE6")]
		private string collectVFXPrefabAddress;

		[Cpp2IlInjected.Token(Token = "0x600334D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5720", Offset = "0x8C4120", VA = "0x1808C5720", Slot = "5")]
		protected override void Start()
		{
			base.Start();
			GardeningSlot gardeningSlot = (this.gardeningSlot = GetComponent<GardeningSlot>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600334E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5200", Offset = "0x8C3C00", VA = "0x1808C5200", Slot = "7")]
		protected override bool IsBurningForThisObject(Meta.BurningState.IBurningState burningState)
		{
			if (burningState != null && burningState != null)
			{
				uint gridID = ((GridObjectStateUser)this.gardeningSlot).GridObjectScript.GridScript.GridID;
				GardeningSlot gardeningSlot = this.gardeningSlot;
				GridObjectScript _003CGridObjectScript_003Ek__BackingField = ((GridObjectStateUser)gardeningSlot).GridObjectScript;
				if ((IntPtr)(int)_003CGridObjectScript_003Ek__BackingField.GridObject.iD_ == (IntPtr)_003CGridObjectScript_003Ek__BackingField)
				{
					return (IntPtr)gardeningSlot._slotIndex == (IntPtr)_003CGridObjectScript_003Ek__BackingField;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600334F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5570", Offset = "0x8C3F70", VA = "0x1808C5570", Slot = "8")]
		protected override void StartBurningState(Meta.BurningState.IBurningState burningState)
		{
			//Discarded unreachable code: IL_005f
			base.StartBurningState(burningState);
			PlayerNavigation playerNavigation = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			GardeningSlot gardeningSlot = this.gardeningSlot;
			PlayerNavigation playerNavigation2 = playerNavigation;
			GameObject go = gardeningSlot.Garden.gameObject;
			float interactiblePriorityOverrideDistance = _interactiblePriorityOverrideDistance;
			playerNavigation2.AddInteractiblePriorityOverride(go, interactiblePriorityOverrideDistance);
			WaitForEndOfOverride().FireAndForgetTask();
			[Cpp2IlInjected.Token(Token = "0x6003357")]
			[Cpp2IlInjected.Address(RVA = "0x1053CA0", Offset = "0x10526A0", VA = "0x181053CA0")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass7_0._003C_003CStartBurningState_003Eg__WaitForEndOfOverride_007C0_003Ed))]
			Task WaitForEndOfOverride()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003350")]
		[Cpp2IlInjected.Address(RVA = "0x8C50F0", Offset = "0x8C3AF0", VA = "0x1808C50F0", Slot = "9")]
		protected override void EndBurningState()
		{
			//Discarded unreachable code: IL_002a
			base.EndBurningState();
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			GameObject go = gardeningSlot.Garden.gameObject;
			system.RemoveInteractiblePriorityOverride(go);
		}

		[Cpp2IlInjected.Token(Token = "0x6003351")]
		[Cpp2IlInjected.Address(RVA = "0x8C5470", Offset = "0x8C3E70", VA = "0x1808C5470", Slot = "10")]
		protected override Task<GameObject> PlayBurningStateVFX(CancellationToken ct)
		{
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
			_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
			_003C_003Ec__DisplayClass9_.ct = ct;
			string text = vfxPrefabAddress;
			if (_003C_003Ec__DisplayClass9_ != null)
			{
				CancellationToken ct2 = _003C_003Ec__DisplayClass9_.ct;
				return (Task<GameObject>)(object)base.PlayBurningStateVFX(ct2);
			}
			Task<GameObject> task = (Task<GameObject>)(object)_003C_003Ec__DisplayClass9_._003CPlayBurningStateVFX_003Eg__LoadAsync_007C0();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003352")]
		[Cpp2IlInjected.Address(RVA = "0x8C52D0", Offset = "0x8C3CD0", VA = "0x1808C52D0", Slot = "11")]
		protected override void PlayBurningStateCollectVFX()
		{
			if (string.IsNullOrEmpty(collectVFXPrefabAddress))
			{
				base.PlayBurningStateCollectVFX();
				return;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> asyncTask = default(Task<>);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003353")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3F30", VA = "0x1808C5530")]
		internal void SetVFXOverrides(string vfxPrefabAddress, string collectVFXPrefabAddress)
		{
			this.vfxPrefabAddress = vfxPrefabAddress;
			this.collectVFXPrefabAddress = collectVFXPrefabAddress;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003354")]
		[Cpp2IlInjected.Address(RVA = "0x8C58C0", Offset = "0x8C42C0", VA = "0x1808C58C0")]
		public GardeningBurningState()
		{
		}
	}
}
