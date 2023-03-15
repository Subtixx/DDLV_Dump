using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009CF")]
	public class StallSystem : Mdl.Systems.System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400363F")]
		[SerializeField]
		private RectTransform _inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003640")]
		private TaskCompletionSource<bool> interactWithStallTCS;

		[Cpp2IlInjected.Token(Token = "0x17000695")]
		public Stall CurrentStall
		{
			[Cpp2IlInjected.Token(Token = "0x6002DE7")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentStall_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002DE8")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			private set
			{
				_003CCurrentStall_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000696")]
		public Task InteractWithStallTask
		{
			[Cpp2IlInjected.Token(Token = "0x6002DE9")]
			[Cpp2IlInjected.Address(RVA = "0xF5B8F0", Offset = "0xF5A2F0", VA = "0x180F5B8F0")]
			get
			{
				//Discarded unreachable code: IL_0027
				//IL_0010: Expected O, but got I4
				Stall stall = CurrentStall;
				int num = 0;
				if (!(stall == (UnityEngine.Object)num))
				{
					Task<> task = (Task<>)(object)((TaskCompletionSource<>)(object)interactWithStallTCS).m_task;
				}
				int num2 = 0;
				return Task.CompletedTask;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000697")]
		public RectTransform FullScreenInputZone
		{
			[Cpp2IlInjected.Token(Token = "0x6002DEA")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return _inputZone;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DEB")]
		[Cpp2IlInjected.Address(RVA = "0xF5B820", Offset = "0xF5A220", VA = "0x180F5B820", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			TaskCompletionSource<bool> taskCompletionSource = (interactWithStallTCS = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DEC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DED")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DEE")]
		[Cpp2IlInjected.Address(RVA = "0xF5B890", Offset = "0xF5A290", VA = "0x180F5B890", Slot = "5")]
		public override void OnSystemStop()
		{
			//IL_000c: Expected O, but got I4
			//IL_0016: Expected O, but got I8
			bool flag = ((TaskCompletionSource<TResult>)(object)interactWithStallTCS).TrySetResult((TResult)1);
			interactWithStallTCS = (TaskCompletionSource<bool>)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DEF")]
		[Cpp2IlInjected.Address(RVA = "0xF5B6B0", Offset = "0xF5A0B0", VA = "0x180F5B6B0")]
		[AsyncStateMachine(typeof(_003CInteract_003Ed__14))]
		internal Task Interact(Stall stall, PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DF0")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public StallSystem()
		{
		}
	}
}
