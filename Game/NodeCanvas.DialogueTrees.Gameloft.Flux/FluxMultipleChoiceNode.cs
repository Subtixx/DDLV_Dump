using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Missions;
using Mdl.Systems;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees.Gameloft.Flux
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[Icon("List", false, "")]
	[Category("Branch")]
	[Name("Flux Multiple Choice", 0)]
	[Color("F68A10")]
	[Description("Prompt a Flux Dialogue Multiple Choice. A choice will be available if the connection's condition is true or there is no condition on that connection. The Actor selected is used for the Condition checks as well as will Say the selection if the option is checked.")]
	public class FluxMultipleChoiceNode : DTNode, ISubTasksContainer
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		public class Choice
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public bool isUnfolded = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public FluxStatement statement;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public ConditionTask condition;

			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x11D92E0", Offset = "0x11D7CE0", VA = "0x1811D92E0")]
			public Choice()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x11D92A0", Offset = "0x11D7CA0", VA = "0x1811D92A0")]
			public Choice(FluxStatement statement)
			{
				this.statement = statement;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		[SerializeField]
		private string animation = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		[SliderField(0f, 10f)]
		public float availableTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public bool saySelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public List<Choice> availableChoices = (List<Choice>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public FluxStatement additionalQuote = new FluxStatement("");

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public bool sayAdditionalQuote;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public bool selectLastOnCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private string errorMessage = string.Empty;

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public override int maxOutConnections
		{
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x145B600", Offset = "0x145A000", VA = "0x18145B600", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)availableChoices)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public override bool requireActorSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "39")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private MissionManager MissionManager
		{
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x145B540", Offset = "0x1459F40", VA = "0x18145B540")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<MissionManager>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x145A930", Offset = "0x1459330", VA = "0x18145A930", Slot = "40")]
		public Task[] GetSubTasks()
		{
			List<Choice> list;
			do
			{
				list = availableChoices;
			}
			while (list == null);
			Func<Choice, ConditionTask> _003C_003E9__9_ = _003C_003Ec._003C_003E9__9_0;
			if (_003C_003E9__9_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Choice c) => c.condition);
			}
			ConditionTask[] array = Enumerable.Select<Choice, ConditionTask>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__9_).ToArray<ConditionTask>();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x145AAA0", Offset = "0x14594A0", VA = "0x18145AAA0", Slot = "27")]
		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x145B040", Offset = "0x1459A40", VA = "0x18145B040")]
		private void OnOptionSelected(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x145B430", Offset = "0x1459E30", VA = "0x18145B430")]
		public FluxMultipleChoiceNode()
		{
		}
	}
}
