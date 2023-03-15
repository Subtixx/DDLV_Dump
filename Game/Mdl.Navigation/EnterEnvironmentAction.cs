using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Environments;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BB8")]
	internal class EnterEnvironmentAction : DialogueAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004156")]
		public float PostBuildingUnlockDelay = 2.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4004157")]
		public float CameraTransitionDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004158")]
		public Vector3 CameraTransitionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004159")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x6003604")]
		[Cpp2IlInjected.Address(RVA = "0x19DB6C0", Offset = "0x19DA0C0", VA = "0x1819DB6C0")]
		[AsyncStateMachine(typeof(_003CCanEnterEnvironment_003Ed__4))]
		private Task<bool> CanEnterEnvironment(PlayerTask task, PlayerAvatar avatar, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003605")]
		[Cpp2IlInjected.Address(RVA = "0x19DB9E0", Offset = "0x19DA3E0", VA = "0x1819DB9E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__5))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003606")]
		[Cpp2IlInjected.Address(RVA = "0x19DB840", Offset = "0x19DA240", VA = "0x1819DB840", Slot = "6")]
		public override void CancelAction(PlayerAvatar avatar, PlayerTask task)
		{
			//Discarded unreachable code: IL_0018
			CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				cancellationTokenSource.Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003607")]
		[Cpp2IlInjected.Address(RVA = "0x19DBB40", Offset = "0x19DA540", VA = "0x1819DBB40", Slot = "9")]
		public override bool TryGetActionCost(GameObject target, PlayerTaskDefinition playerTaskDefinition, out Item currencyItem, out int amount)
		{
			//IL_0052: Expected I4, but got O
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			int num3 = default(int);
			if (flag && num3 > 0)
			{
				Client client = default(Client);
				ProfileWorld world_ = client.profile.world_;
				bool flag2 = default(bool);
				if (!flag2)
				{
					UnlockRealm.Types.Request request = new UnlockRealm.Types.Request();
					int num4 = (request.realmID_ = request.realmID_);
					UnlockRealm.Types.Result result = default(UnlockRealm.Types.Result);
					if (result != UnlockRealm.Types.Result.AlreadyUnlocked)
					{
						int num5 = 0;
						CurrencyCost currencyCost = default(CurrencyCost);
						Item item = currencyCost.Item;
						currencyItem.ItemID = (int)item;
						return true;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003608")]
		[Cpp2IlInjected.Address(RVA = "0x19DB890", Offset = "0x19DA290", VA = "0x1819DB890")]
		[AsyncStateMachine(typeof(_003CEnterEnvironment_003Ed__8))]
		public static Task EnterEnvironment(PlayerAvatar avatar, BaseEnvironmentDoor door, SceneItemData sceneDefinitionItemData, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003609")]
		[Cpp2IlInjected.Address(RVA = "0x19DBF00", Offset = "0x19DA900", VA = "0x1819DBF00")]
		public unsafe EnterEnvironmentAction()
		{
			//IL_0028: Expected native int or pointer, but got O
			float z = Vector3.up.z;
			((Vector3*)(IntPtr)CameraTransitionOffset)->z = z;
			cancellationTokenSource = new CancellationTokenSource();
			base._002Ector();
		}
	}
}
