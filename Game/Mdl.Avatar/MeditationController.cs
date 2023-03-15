using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Online;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A69")]
	internal class MeditationController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003962")]
		public GameObject MeditationInfoGizmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003963")]
		[ItemID]
		[SerializeField]
		private int _infoGizmoConditionItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003964")]
		private bool showInfoGizmo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003965")]
		private ManaData manaData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003966")]
		private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x170006B6")]
		public Item InfoGizmoConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600303A")]
			[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC12D0", VA = "0x180BC28D0")]
			get
			{
				long num = Convert.ToInt64((uint)_infoGizmoConditionItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600303B")]
		[Cpp2IlInjected.Address(RVA = "0xBC2390", Offset = "0xBC0D90", VA = "0x180BC2390")]
		private void Start()
		{
			//Discarded unreachable code: IL_0075
			//IL_0021: Expected O, but got I4
			int handle = base.gameObject.scene.m_Handle;
			GameObject gameObject = default(GameObject);
			PlayerHouseEnvironment component = gameObject.GetComponent<PlayerHouseEnvironment>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				int infoGizmoConditionItemID = _infoGizmoConditionItemID;
				Client metaClient = SystemRoot.Instance.MetaClient;
				Client metaClient2 = SystemRoot.Instance.MetaClient;
				CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
				bool flag = default(bool);
				showInfoGizmo = flag;
				CancellationToken token = cancellationTokenSource.Token;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600303C")]
		[Cpp2IlInjected.Address(RVA = "0xBC2260", Offset = "0xBC0C60", VA = "0x180BC2260")]
		private void OnDestroy()
		{
			if ((long)cancellationTokenSource == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600303D")]
		[Cpp2IlInjected.Address(RVA = "0xBC2130", Offset = "0xBC0B30", VA = "0x180BC2130")]
		[AsyncStateMachine(typeof(_003CMeditate_003Ed__9))]
		private Task Meditate(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600303E")]
		[Cpp2IlInjected.Address(RVA = "0xBC22C0", Offset = "0xBC0CC0", VA = "0x180BC22C0")]
		private bool ShouldMeditate()
		{
			//Discarded unreachable code: IL_0022
			//IL_0021: Expected O, but got I4
			int handle = base.gameObject.scene.m_Handle;
			GameObject gameObject = default(GameObject);
			PlayerHouseEnvironment component = gameObject.GetComponent<PlayerHouseEnvironment>();
			int num = 0;
			return component != (UnityEngine.Object)num;
		}

		[Cpp2IlInjected.Token(Token = "0x600303F")]
		[Cpp2IlInjected.Address(RVA = "0xBC2860", Offset = "0xBC1260", VA = "0x180BC2860")]
		public MeditationController()
		{
		}
	}
}
