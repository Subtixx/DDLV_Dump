using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BA7")]
	internal class ConsumeBuffElixirAction : PlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40040E6")]
		public AssetReferenceGameObject ConsumeVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40040E7")]
		public VolumeProfile PostProcessProfile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40040E8")]
		public float ToolBuffAnimationDelayInSeconds;

		[Cpp2IlInjected.Token(Token = "0x60035C6")]
		[Cpp2IlInjected.Address(RVA = "0xA92640", Offset = "0xA91040", VA = "0x180A92640", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__3))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035C7")]
		[Cpp2IlInjected.Address(RVA = "0xA927A0", Offset = "0xA911A0", VA = "0x180A927A0")]
		[AsyncStateMachine(typeof(_003CPlayAnimation_003Ed__4))]
		private Task PlayAnimation(BuffElixirItemData buffElixirItemData, PlayerAvatar avatar)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035C8")]
		[Cpp2IlInjected.Address(RVA = "0xA928E0", Offset = "0xA912E0", VA = "0x180A928E0")]
		[AsyncStateMachine(typeof(_003CToolBuffAnimation_003Ed__5))]
		private static Task ToolBuffAnimation(PlayerAvatar avatar, Toolbox.ToolType toolType, float animationDelay)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035C9")]
		[Cpp2IlInjected.Address(RVA = "0xA92A20", Offset = "0xA91420", VA = "0x180A92A20")]
		public ConsumeBuffElixirAction()
		{
		}
	}
}
