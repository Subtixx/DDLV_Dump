using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using UnityEngine;

namespace Mdl.Ui.Tools
{
	[Cpp2IlInjected.Token(Token = "0x20008C7")]
	public class AvatarCustomizationBootstrap : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003476")]
		public PlayerAvatar avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003477")]
		public AsyncMenu customizationMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003478")]
		public TextAsset profileAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003479")]
		private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x170007C5")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6003745")]
			[Cpp2IlInjected.Address(RVA = "0x882DC0", Offset = "0x8817C0", VA = "0x180882DC0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _cancellationTokenSource.Token;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003746")]
		[Cpp2IlInjected.Address(RVA = "0x882BC0", Offset = "0x8815C0", VA = "0x180882BC0")]
		private void Start()
		{
			//Discarded unreachable code: IL_001a
			CancellationToken token = _cancellationTokenSource.Token;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003747")]
		[Cpp2IlInjected.Address(RVA = "0x882A90", Offset = "0x881490", VA = "0x180882A90")]
		[AsyncStateMachine(typeof(_003CLogin_003Ed__7))]
		private Task Login(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003748")]
		[Cpp2IlInjected.Address(RVA = "0x882D50", Offset = "0x881750", VA = "0x180882D50")]
		public AvatarCustomizationBootstrap()
		{
		}
	}
}
