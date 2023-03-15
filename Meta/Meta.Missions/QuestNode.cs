using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2001068")]
	public class QuestNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400439A")]
		public List<QuestNode> Parents = (List<QuestNode>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400439B")]
		public List<QuestNode> Childs = (List<QuestNode>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400439C")]
		public MissionItemData Data;

		[Cpp2IlInjected.Token(Token = "0x17001713")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400439D")]
		public ConditionListener Flags
		{
			[Cpp2IlInjected.Token(Token = "0x60084FB")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60084FC")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001714")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60084FE")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8C0", Offset = "0x5BA2C0", VA = "0x1805BB8C0")]
			get
			{
				//Discarded unreachable code: IL_0009, IL_0011, IL_0028, IL_0036
				List<QuestNode> parents = Parents;
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60084FD")]
		[Cpp2IlInjected.Address(RVA = "0x5BB7C0", Offset = "0x5BA1C0", VA = "0x1805BB7C0")]
		public QuestNode(MissionItemData data)
		{
			//Discarded unreachable code: IL_0040
			Data = data;
			ConditionListener conditionListener = (Flags = Data.availableConditions_.Listener);
		}

		[Cpp2IlInjected.Token(Token = "0x60084FF")]
		[Cpp2IlInjected.Address(RVA = "0x5BB4D0", Offset = "0x5B9ED0", VA = "0x1805BB4D0")]
		public bool IsChildren(QuestNode children)
		{
			if (children == this)
			{
				return true;
			}
			List<QuestNode> childs = Childs;
			Func<QuestNode, bool> cpp2il__autoParamName__idx_ = (Func<QuestNode, bool>)(object)(Func<T, TResult>)delegate(QuestNode x)
			{
				//Discarded unreachable code: IL_000f
				QuestNode children2 = children;
				return x.IsChildren(children2);
			};
			bool flag = ((IEnumerable<>)childs).Any<QuestNode>((Func<, >)(object)cpp2il__autoParamName__idx_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008500")]
		[Cpp2IlInjected.Address(RVA = "0x5BB5D0", Offset = "0x5B9FD0", VA = "0x1805BB5D0")]
		public bool IsParent(QuestNode parent)
		{
			if (parent == this)
			{
				return true;
			}
			List<QuestNode> parents = Parents;
			Func<QuestNode, bool> cpp2il__autoParamName__idx_ = (Func<QuestNode, bool>)(object)(Func<T, TResult>)delegate(QuestNode x)
			{
				//Discarded unreachable code: IL_000f
				QuestNode parent2 = parent;
				return x.IsParent(parent2);
			};
			bool flag = ((IEnumerable<>)parents).Any<QuestNode>((Func<, >)(object)cpp2il__autoParamName__idx_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008501")]
		[Cpp2IlInjected.Address(RVA = "0x5BB3D0", Offset = "0x5B9DD0", VA = "0x1805BB3D0")]
		public bool Evaluate(IProfile profile, ITransactionContext context, ConditionListener flag = ConditionListener.None, bool refuseDebug = false)
		{
			//Discarded unreachable code: IL_001d
			if (flag != 0)
			{
				ConditionListener conditionListener = Flags;
			}
			if (Data.status_ == MissionItemData.Types.MissionStatus.Debug)
			{
				int num = 0;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008502")]
		[Cpp2IlInjected.Address(RVA = "0x5BB460", Offset = "0x5B9E60", VA = "0x1805BB460")]
		[IteratorStateMachine(typeof(_003CExtractParents_003Ed__13))]
		public IEnumerable<Item> ExtractParents()
		{
			new _003CExtractParents_003Ed__13(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008503")]
		[Cpp2IlInjected.Address(RVA = "0x5BAF90", Offset = "0x5B9990", VA = "0x1805BAF90")]
		public string DebugInfoString(QuestTree quest)
		{
			//Discarded unreachable code: IL_0082
			int nodeCount = quest.NodeCount;
			string text = default(string);
			string text2 = $"Position: {text} (Linear x{text})";
			string text3 = default(string);
			string text4 = "Position: " + text3;
			string text5 = default(string);
			string text6 = default(string);
			string text7 = "Position: " + text5 + " to " + text6;
			string text8 = "" + text7;
			int nodeCount2 = quest.NodeCount;
			string text9 = $" (TreeNode x{text8})";
			string text10 = text8 + text9;
			string text11 = $"\nStats: {text10} out of {text10} ({text10:0}%)";
			return text10 + text11;
		}

		[Cpp2IlInjected.Token(Token = "0x6008504")]
		[Cpp2IlInjected.Address(RVA = "0x5BB220", Offset = "0x5B9C20", VA = "0x1805BB220")]
		public (int, int, int, int) DebugInfo(QuestTree quest)
		{
			QuestNode questNode = (QuestNode)(object)quest;
			List<QuestNode> nextNodes = quest.NextNodes;
			bool flag = default(bool);
			if (!flag)
			{
				int min = (flag ? 1 : 0);
				int max;
				int otherWay = (max = 0);
				int num = otherWay;
				int num2 = 0;
				int num3 = min;
				int num4 = max;
				int myWay = default(int);
				int num5 = myWay;
				throw new NullReferenceException();
			}
			Exception ex = new Exception("TryGetDebugInfo not properly used: Invalid quest");
			/*Error: Unexpected end of block*/;
		}
	}
}
