using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Characters.Pets;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BCD")]
	internal class InteractWithPetAction : PlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40041DA")]
		[SerializeField]
		private AssetReference happyVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40041DB")]
		public string avatarAnimationTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40041DC")]
		public float vfxOffset;

		[Cpp2IlInjected.Token(Token = "0x6003637")]
		[Cpp2IlInjected.Address(RVA = "0x11B8C70", Offset = "0x11B7670", VA = "0x1811B8C70", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__3))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003638")]
		[Cpp2IlInjected.Address(RVA = "0x11B8DD0", Offset = "0x11B77D0", VA = "0x1811B8DD0")]
		[AsyncStateMachine(typeof(_003CPlayPetAnimations_003Ed__4))]
		private Task PlayPetAnimations(Pet pet)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003639")]
		[Cpp2IlInjected.Address(RVA = "0x11B8EF0", Offset = "0x11B78F0", VA = "0x1811B8EF0")]
		[AsyncStateMachine(typeof(_003CStartHappyVFX_003Ed__5))]
		private Task StartHappyVFX(Transform transform)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600363A")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public InteractWithPetAction()
		{
		}
	}
}
