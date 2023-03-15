using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using Meta.Customization;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004B6")]
	public class FacePresetItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40018CE")]
		[SerializeField]
		private Image _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40018CF")]
		[SerializeField]
		private BaseButton _button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40018D2")]
		private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x170004FB")]
		public BaseButton Button
		{
			[Cpp2IlInjected.Token(Token = "0x6001EC5")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return _button;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x78"), Cpp2IlInjected.Token(Token = "0x40018D0")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6001EC6")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001EC7")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004FD")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x7C"), Cpp2IlInjected.Token(Token = "0x40018D1")]
		public FacePartType FacePartType
		{
			[Cpp2IlInjected.Token(Token = "0x6001EC8")]
			[Cpp2IlInjected.Address(RVA = "0xAE8600", Offset = "0xAE7000", VA = "0x180AE8600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001EC9")]
			[Cpp2IlInjected.Address(RVA = "0x1525600", Offset = "0x1524000", VA = "0x181525600")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECA")]
		[Cpp2IlInjected.Address(RVA = "0x15251C0", Offset = "0x1523BC0", VA = "0x1815251C0")]
		public void Init(AvatarFaceConfig.FacePartOption data, int index, bool isMale)
		{
			//Discarded unreachable code: IL_001c
			Index = index;
			CancellationToken token = cancellationTokenSource.Token;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECB")]
		[Cpp2IlInjected.Address(RVA = "0x15253B0", Offset = "0x1523DB0", VA = "0x1815253B0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0016
			_button.ButtonComponent.m_OnClick.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECC")]
		[Cpp2IlInjected.Address(RVA = "0x1525380", Offset = "0x1523D80", VA = "0x181525380")]
		public void OnClick()
		{
			//Discarded unreachable code: IL_000c, IL_000d
			_button.PostWwiseEvent();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECD")]
		[Cpp2IlInjected.Address(RVA = "0x1525440", Offset = "0x1523E40", VA = "0x181525440")]
		[AsyncStateMachine(typeof(_003CSetSprite_003Ed__16))]
		private Task SetSprite(AvatarFaceConfig.FacePartOption data, bool isMale, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001ECE")]
		[Cpp2IlInjected.Address(RVA = "0x1525590", Offset = "0x1523F90", VA = "0x181525590")]
		public FacePresetItem()
		{
		}
	}
}
