using System;
using AK.Wwise;
using Cpp2IlInjected;
using Meta.Missions;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees.Gameloft.Flux
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[Name("Localized Say", 0)]
	[Category("Flux Localization")]
	[Description("Get the translations from localization manager")]
	public class FluxStatementNode : DTNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[SerializeField]
		private string animation = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[SerializeField]
		public Switch voOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[HideInInspector]
		public FluxStatement statement = new FluxStatement("");

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public override bool requireActorSelection
		{
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "39")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x145B640", Offset = "0x145A040", VA = "0x18145B640", Slot = "27")]
		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			//Discarded unreachable code: IL_008d
			//IL_004d: Expected O, but got I4
			if (statement.CheckDialogueFlag())
			{
				string text = animation;
				string emptyAnimation = FluxStatement.EmptyAnimation;
				if (text != emptyAnimation)
				{
					IDialogueActor dialogueActor = base.finalActor;
					Switch @switch = voOverride;
				}
				FluxStatement fluxStatement = statement;
				int checkText = 0;
				int num = 0;
				FluxStatement fluxStatement2 = fluxStatement.BlackboardReplace(bb, (MissionSlot)num, (byte)checkText != 0);
				IDialogueActor actor = base.finalActor;
				Action callback = OnStatementFinish;
				DialogueTree.RequestSubtitles(new SubtitlesRequestInfo(actor, fluxStatement2, callback));
				return Status.Running;
			}
			DialogueTree dLGTree = base.DLGTree;
			int index = 0;
			dLGTree.Continue(index);
			return Status.Success;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x145B830", Offset = "0x145A230", VA = "0x18145B830")]
		private void OnStatementFinish()
		{
			//Discarded unreachable code: IL_001a
			//IL_0009: Expected I4, but got I8
			((Node)this)._status = Status.Success;
			DialogueTree dLGTree = base.DLGTree;
			int index = 0;
			dLGTree.Continue(index);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x145B860", Offset = "0x145A260", VA = "0x18145B860")]
		public FluxStatementNode()
		{
		}
	}
}
