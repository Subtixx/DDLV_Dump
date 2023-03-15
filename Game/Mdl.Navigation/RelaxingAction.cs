using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BEE")]
	internal class RelaxingAction : PlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400427F")]
		public float DestinationDistanceTolerance = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004280")]
		private (RelaxingPosition relaxingPosition, int destinationIndex)? reservedRelaxingPosition;

		[Cpp2IlInjected.Token(Token = "0x600368B")]
		[Cpp2IlInjected.Address(RVA = "0xCBE1E0", Offset = "0xCBCBE0", VA = "0x180CBE1E0", Slot = "8")]
		[AsyncStateMachine(typeof(_003CCanExecuteAction_003Ed__2))]
		public override Task<bool> CanExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600368C")]
		[Cpp2IlInjected.Address(RVA = "0xCBE700", Offset = "0xCBD100", VA = "0x180CBE700", Slot = "4")]
		public unsafe override Task StartAction(PlayerAvatar avatar, PlayerTask task)
		{
			//Discarded unreachable code: IL_0021
			int num = 0;
			if (SystemExtensions.TryGetValue<(RelaxingPosition, int)>((Nullable<>)reservedRelaxingPosition, ref *((RelaxingPosition, int)*)num))
			{
				GameObject _003CgameObject_003Ek__BackingField = avatar.gameObject;
			}
			return base.StartAction(avatar, task);
		}

		[Cpp2IlInjected.Token(Token = "0x600368D")]
		[Cpp2IlInjected.Address(RVA = "0xCBE5E0", Offset = "0xCBCFE0", VA = "0x180CBE5E0", Slot = "7")]
		public override Vector3? OverrideDestination(PlayerAvatar avatar, PlayerTask task, Vector3 destination)
		{
			int num = 0;
			Collider _003CCollider_003Ek__BackingField = avatar.Collider;
			bool flag = default(bool);
			if (!flag)
			{
				int num2 = 0;
			}
			int num3 = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600368E")]
		[Cpp2IlInjected.Address(RVA = "0xCBE3E0", Offset = "0xCBCDE0", VA = "0x180CBE3E0", Slot = "5")]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0020
			bool flag = default(bool);
			if (!flag)
			{
				int num = 0;
				Task completedTask = Task.CompletedTask;
			}
			base.CanBeResumed = false;
			RelaxingBehaviour _003CRelaxingBehaviour_003Ek__BackingField = avatar.RelaxingBehaviour;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600368F")]
		[Cpp2IlInjected.Address(RVA = "0xCBE350", Offset = "0xCBCD50", VA = "0x180CBE350", Slot = "6")]
		public unsafe override void CancelAction(PlayerAvatar avatar, PlayerTask task)
		{
			//Discarded unreachable code: IL_0019
			int num = 0;
			if (SystemExtensions.TryGetValue<(RelaxingPosition, int)>((Nullable<>)reservedRelaxingPosition, ref *((RelaxingPosition, int)*)num))
			{
				GameObject _003CgameObject_003Ek__BackingField = avatar.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003690")]
		[Cpp2IlInjected.Address(RVA = "0xCBE900", Offset = "0xCBD300", VA = "0x180CBE900")]
		public RelaxingAction()
		{
		}
	}
}
