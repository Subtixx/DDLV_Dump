using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Activities;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000AB1")]
	internal class Phone : Tool
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003AEB")]
		[SerializeField]
		private PhotoModeType defaultPhotoMode;

		[Cpp2IlInjected.Token(Token = "0x170006DD")]
		public override Toolbox.ToolType ToolType
		{
			[Cpp2IlInjected.Token(Token = "0x6003150")]
			[Cpp2IlInjected.Address(RVA = "0x7D4F00", Offset = "0x7D3900", VA = "0x1807D4F00", Slot = "8")]
			get
			{
				return Toolbox.ToolType.CameraTool;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003151")]
		[Cpp2IlInjected.Address(RVA = "0xF0F9C0", Offset = "0xF0E3C0", VA = "0x180F0F9C0", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUseTool_003Ed__3))]
		protected override Task<bool> UseTool(PlayerAvatar avatar)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003152")]
		[Cpp2IlInjected.Address(RVA = "0xF0FAE0", Offset = "0xF0E4E0", VA = "0x180F0FAE0")]
		public Phone()
		{
		}
	}
}
