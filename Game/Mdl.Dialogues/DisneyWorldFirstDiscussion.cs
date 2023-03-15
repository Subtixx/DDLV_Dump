using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Dialogues
{
	[Cpp2IlInjected.Token(Token = "0x200082F")]
	internal class DisneyWorldFirstDiscussion : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002DB7")]
		[ItemID]
		[SerializeField]
		private int npcDiscussionItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002DB8")]
		public float ConversationDelayInSeconds = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002DB9")]
		private DisneyWorldEnvironment disneyWorldEnvironment;

		[Cpp2IlInjected.Token(Token = "0x17000533")]
		public Item NPCDiscussionItem
		{
			[Cpp2IlInjected.Token(Token = "0x60024C8")]
			[Cpp2IlInjected.Address(RVA = "0x16331F0", Offset = "0x1631BF0", VA = "0x1816331F0")]
			get
			{
				long num = Convert.ToInt64((uint)npcDiscussionItemId);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024C9")]
		[Cpp2IlInjected.Address(RVA = "0x1633020", Offset = "0x1631A20", VA = "0x181633020")]
		private void Start()
		{
			//Discarded unreachable code: IL_0057
			long num = Convert.ToInt64((uint)npcDiscussionItemId);
			bool flag = default(bool);
			if (flag)
			{
				DisneyWorldEnvironment disneyWorldEnvironment = (this.disneyWorldEnvironment = GetComponent<DisneyWorldEnvironment>());
				DisneyWorldEnvironment disneyWorldEnvironment2 = this.disneyWorldEnvironment;
				EventHandler b = OnFirstVisitInWorld;
				EventHandler firstVisitEvent = disneyWorldEnvironment2.FirstVisitEvent;
				Delegate @delegate = Delegate.Combine(firstVisitEvent, b);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				while ((object)@delegate != firstVisitEvent)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024CA")]
		[Cpp2IlInjected.Address(RVA = "0x1632C30", Offset = "0x1631630", VA = "0x181632C30")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_004a
			//IL_0010: Expected O, but got I4
			DisneyWorldEnvironment disneyWorldEnvironment = this.disneyWorldEnvironment;
			int num = 0;
			if (disneyWorldEnvironment != (UnityEngine.Object)num)
			{
				DisneyWorldEnvironment disneyWorldEnvironment2 = this.disneyWorldEnvironment;
				EventHandler value = OnFirstVisitInWorld;
				EventHandler firstVisitEvent = disneyWorldEnvironment2.FirstVisitEvent;
				Delegate @delegate = Delegate.Remove(firstVisitEvent, value);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				while ((object)@delegate != firstVisitEvent)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024CB")]
		[Cpp2IlInjected.Address(RVA = "0x1632D70", Offset = "0x1631770", VA = "0x181632D70")]
		private void OnFirstVisitInWorld(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_001f
			CancellationToken cancellationToken = ((Mdl.Environments.Environment)disneyWorldEnvironment).CancellationTokenProvider.CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60024CC")]
		[Cpp2IlInjected.Address(RVA = "0x1632F00", Offset = "0x1631900", VA = "0x181632F00")]
		[AsyncStateMachine(typeof(_003CStartFirstNPCDiscussion_003Ed__8))]
		private Task StartFirstNPCDiscussion(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024CD")]
		[Cpp2IlInjected.Address(RVA = "0x16331E0", Offset = "0x1631BE0", VA = "0x1816331E0")]
		public DisneyWorldFirstDiscussion()
		{
		}
	}
}
