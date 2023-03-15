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
	[Cpp2IlInjected.Token(Token = "0x2001060")]
	public class QuestTree
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004382")]
		public MissionQuestItemData Data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004383")]
		public QuestNode Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004384")]
		public List<QuestNode> NextNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004385")]
		public int NodeCount;

		[Cpp2IlInjected.Token(Token = "0x1700170C")]
		public string DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x60084D6")]
			[Cpp2IlInjected.Address(RVA = "0x5BC5B0", Offset = "0x5BAFB0", VA = "0x1805BC5B0")]
			get
			{
				//Discarded unreachable code: IL_009d
				MissionQuestItemData data = Data;
				if (data != null)
				{
					int iD = data.ID;
					char[] array = new char[1];
					array[0] = '/';
					string text = default(string);
					string text2 = ((IEnumerable<>)(object)text.Split(array)).Last<string>();
					if (text2 != null)
					{
						char[] array2 = new char[1];
						array2[0] = '!';
						string[] array3 = text2.Split(array2);
						if (array3 != null && array3.Length == 3 && string.Equals(array3[0].ToLower(), "village"))
						{
							string text3 = array3[2];
							return "village!" + text3;
						}
					}
				}
				return "<ERROR>";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700170D")]
		public int MaxIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60084D8")]
			[Cpp2IlInjected.Address(RVA = "0x5BC950", Offset = "0x5BB350", VA = "0x1805BC950")]
			get
			{
				IEnumerable<QuestNode> finalLeaf = (IEnumerable<QuestNode>)this.get_FinalLeaf();
				Func<QuestNode, int> _003C_003E9__9_ = _003C_003Ec._003C_003E9__9_0;
				if (_003C_003E9__9_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((QuestNode x) => x.Index);
				}
				return Enumerable.Max<QuestNode>((IEnumerable<>)finalLeaf, (Func<, >)(object)_003C_003E9__9_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700170E")]
		public IEnumerable<QuestNode> FinalLeaf
		{
			[Cpp2IlInjected.Token(Token = "0x60084D9")]
			[Cpp2IlInjected.Address(RVA = "0x5BC780", Offset = "0x5BB180", VA = "0x1805BC780")]
			get
			{
				//Discarded unreachable code: IL_0052
				_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
				List<QuestNode> list = (CS_0024_003C_003E8__locals0.result = (List<QuestNode>)(object)new List<T>());
				QuestNode head = Head;
				AddRecursive(head);
				List<QuestNode> result = CS_0024_003C_003E8__locals0.result;
				Func<QuestNode, bool> _003C_003E9__11_ = _003C_003Ec._003C_003E9__11_0;
				if (_003C_003E9__11_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(QuestNode x)
					{
						//Discarded unreachable code: IL_0009
						List<QuestNode> childs3 = x.Childs;
						bool result2 = default(bool);
						return result2;
					};
				}
				return (IEnumerable<QuestNode>)Enumerable.Where<QuestNode>((IEnumerable<>)result, (Func<, >)(object)_003C_003E9__11_);
				[Cpp2IlInjected.Token(Token = "0x60084E6")]
				[Cpp2IlInjected.Address(RVA = "0xEBA720", Offset = "0xEB9120", VA = "0x180EBA720")]
				void AddRecursive(QuestNode node)
				{
					//Discarded unreachable code: IL_0037
					if (!((List<T>)(object)CS_0024_003C_003E8__locals0.result).Contains((T)node))
					{
						((List<T>)(object)CS_0024_003C_003E8__locals0.result).Add((T)node);
						List<QuestNode> childs = node.Childs;
						Action<QuestNode> action = (Action<QuestNode>)(object)(Action<T>)delegate(QuestNode x)
						{
							//Discarded unreachable code: IL_0037
							// Found self-referencing delegate construction. Abort transformation to avoid stack overflow.
							if (!((List<T>)(object)CS_0024_003C_003E8__locals0.result).Contains((T)x))
							{
								((List<T>)(object)CS_0024_003C_003E8__locals0.result).Add((T)x);
								List<QuestNode> childs2 = x.Childs;
								Action<QuestNode> action2 = (Action<QuestNode>)(object)new Action<T>(CS_0024_003C_003E8__locals0._003Cget_All_003Eb__1);
								((List<T>)(object)childs2).ForEach((Action<>)(object)action2);
							}
						};
						((List<T>)(object)childs).ForEach((Action<>)(object)action);
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700170F")]
		public List<QuestNode> All
		{
			[Cpp2IlInjected.Token(Token = "0x60084DA")]
			[Cpp2IlInjected.Address(RVA = "0x5BC4E0", Offset = "0x5BAEE0", VA = "0x1805BC4E0")]
			get
			{
				//Discarded unreachable code: IL_0028
				_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
				List<QuestNode> list = (CS_0024_003C_003E8__locals0.result = (List<QuestNode>)(object)new List<T>());
				QuestNode head = Head;
				AddRecursive(head);
				return CS_0024_003C_003E8__locals0.result;
				[Cpp2IlInjected.Token(Token = "0x60084E6")]
				[Cpp2IlInjected.Address(RVA = "0xEBA720", Offset = "0xEB9120", VA = "0x180EBA720")]
				void AddRecursive(QuestNode node)
				{
					//Discarded unreachable code: IL_0037
					if (!((List<T>)(object)CS_0024_003C_003E8__locals0.result).Contains((T)node))
					{
						((List<T>)(object)CS_0024_003C_003E8__locals0.result).Add((T)node);
						List<QuestNode> childs = node.Childs;
						Action<QuestNode> action = (Action<QuestNode>)(object)(Action<T>)delegate(QuestNode x)
						{
							//Discarded unreachable code: IL_0037
							// Found self-referencing delegate construction. Abort transformation to avoid stack overflow.
							if (!((List<T>)(object)CS_0024_003C_003E8__locals0.result).Contains((T)x))
							{
								((List<T>)(object)CS_0024_003C_003E8__locals0.result).Add((T)x);
								List<QuestNode> childs2 = x.Childs;
								Action<QuestNode> action2 = (Action<QuestNode>)(object)new Action<T>(CS_0024_003C_003E8__locals0._003Cget_All_003Eb__1);
								((List<T>)(object)childs2).ForEach((Action<>)(object)action2);
							}
						};
						((List<T>)(object)childs).ForEach((Action<>)(object)action);
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001710")]
		public IEnumerable<QuestNode> AllLinear
		{
			[Cpp2IlInjected.Token(Token = "0x60084DB")]
			[Cpp2IlInjected.Address(RVA = "0x5BC470", Offset = "0x5BAE70", VA = "0x1805BC470")]
			[IteratorStateMachine(typeof(_003Cget_AllLinear_003Ed__15))]
			get
			{
				new _003Cget_AllLinear_003Ed__15(-2)._003C_003E4__this = this;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60084D5")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public QuestTree(MissionQuestItemData data)
		{
			Data = data;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60084D7")]
		[Cpp2IlInjected.Address(RVA = "0x5BC2E0", Offset = "0x5BACE0", VA = "0x1805BC2E0")]
		public bool IsActive(Profile profile)
		{
			if (profile != null)
			{
				return Enumerable.Any<MissionSlot>(profile.world_.SearchQuestSlots(this));
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60084DC")]
		[Cpp2IlInjected.Address(RVA = "0x5BC360", Offset = "0x5BAD60", VA = "0x1805BC360")]
		public List<QuestNode> RefreshNextNodes(IProfileWorld profileWorld, bool forceRefresh = false)
		{
			//Discarded unreachable code: IL_0040
			_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
			CS_0024_003C_003E8__locals0.profileWorld = profileWorld;
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			List<QuestNode> nextNodes = NextNodes;
			if (nextNodes == null || forceRefresh)
			{
				List<QuestNode> list = (NextNodes = (List<QuestNode>)(object)new List<T>());
				QuestNode head = Head;
				RecursiveSearch(head);
			}
			return nextNodes;
			[Cpp2IlInjected.Token(Token = "0x60084F1")]
			[Cpp2IlInjected.Address(RVA = "0xEBAB60", Offset = "0xEB9560", VA = "0x180EBAB60")]
			void RecursiveSearch(QuestNode node)
			{
				IProfileWorld profileWorld2 = CS_0024_003C_003E8__locals0.profileWorld;
				if (node.Data.ID == 0)
				{
					List<QuestNode> childs = node.Childs;
					Func<QuestNode, bool> cpp2il__autoParamName__idx_ = (Func<QuestNode, bool>)(object)(Func<T, TResult>)delegate(QuestNode x)
					{
						//Discarded unreachable code: IL_0033
						// Found self-referencing delegate construction. Abort transformation to avoid stack overflow.
						IProfileWorld profileWorld5 = CS_0024_003C_003E8__locals0.profileWorld;
						if (x.Data.ID == 0)
						{
							List<QuestNode> childs6 = x.Childs;
							Func<QuestNode, bool> cpp2il__autoParamName__idx_4 = (Func<QuestNode, bool>)(object)new Func<T, TResult>(CS_0024_003C_003E8__locals0._003CRefreshNextNodes_003Eb__3);
							return ((IEnumerable<>)childs6).Any<QuestNode>((Func<, >)(object)cpp2il__autoParamName__idx_4);
						}
						return true;
					};
					if (!((IEnumerable<>)childs).Any<QuestNode>((Func<, >)(object)cpp2il__autoParamName__idx_))
					{
						((List<T>)(object)CS_0024_003C_003E8__locals0._003C_003E4__this.NextNodes).Add((T)node);
					}
					return;
				}
				List<QuestNode> childs2 = node.Childs;
				Action<QuestNode> action = (Action<QuestNode>)(object)(Action<T>)delegate(QuestNode x)
				{
					// Found self-referencing delegate construction. Abort transformation to avoid stack overflow.
					IProfileWorld profileWorld3 = CS_0024_003C_003E8__locals0.profileWorld;
					if (x.Data.ID == 0)
					{
						List<QuestNode> childs3 = x.Childs;
						Func<QuestNode, bool> cpp2il__autoParamName__idx_2 = (Func<QuestNode, bool>)(object)(Func<T, TResult>)delegate(QuestNode x)
						{
							//Discarded unreachable code: IL_0033
							// Found self-referencing delegate construction. Abort transformation to avoid stack overflow.
							IProfileWorld profileWorld4 = CS_0024_003C_003E8__locals0.profileWorld;
							if (x.Data.ID == 0)
							{
								List<QuestNode> childs5 = x.Childs;
								Func<QuestNode, bool> cpp2il__autoParamName__idx_3 = (Func<QuestNode, bool>)(object)new Func<T, TResult>(CS_0024_003C_003E8__locals0._003CRefreshNextNodes_003Eb__3);
								return ((IEnumerable<>)childs5).Any<QuestNode>((Func<, >)(object)cpp2il__autoParamName__idx_3);
							}
							return true;
						};
						if (!((IEnumerable<>)childs3).Any<QuestNode>((Func<, >)(object)cpp2il__autoParamName__idx_2))
						{
							((List<T>)(object)CS_0024_003C_003E8__locals0._003C_003E4__this.NextNodes).Add((T)x);
						}
						return;
					}
					List<QuestNode> childs4 = x.Childs;
					Action<QuestNode> action2 = (Action<QuestNode>)(object)new Action<T>(CS_0024_003C_003E8__locals0._003CRefreshNextNodes_003Eb__2);
					((List<T>)(object)childs4).ForEach((Action<>)(object)action2);
					throw new NullReferenceException();
				};
				((List<T>)(object)childs2).ForEach((Action<>)(object)action);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60084DD")]
		[Cpp2IlInjected.Address(RVA = "0x5BBC20", Offset = "0x5BA620", VA = "0x1805BBC20")]
		public QuestNode EvaluateNextNodes(IProfile profile, ITransactionContext context, ConditionListener flag = ConditionListener.None, bool forceRefresh = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60084DE")]
		[Cpp2IlInjected.Address(RVA = "0x5BC090", Offset = "0x5BAA90", VA = "0x1805BC090")]
		public IEnumerable<Item> ExtractParents()
		{
			//Discarded unreachable code: IL_0053, IL_0059
			//IL_003b: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			QuestNode._003CExtractParents_003Ed__13 _003CExtractParents_003Ed__;
			uint num2 = default(uint);
			while (true)
			{
				int num = 0;
				List<Item> list = (List<Item>)(object)new List<T>();
				QuestNode head = Head;
				_003CExtractParents_003Ed__ = new QuestNode._003CExtractParents_003Ed__13(-2);
				_003CExtractParents_003Ed__._003C_003E4__this = head;
				if (_003CExtractParents_003Ed__ == null)
				{
					break;
				}
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0045;
					}
					num++;
				}
				if (((List<T>)(object)list).Contains((T)num))
				{
					continue;
				}
				((List<T>)(object)list).Add((T)num);
				goto IL_0045;
				IL_0045:
				num += num;
				break;
			}
			if (_003CExtractParents_003Ed__ != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60084DF")]
		[Cpp2IlInjected.Address(RVA = "0x5BBA30", Offset = "0x5BA430", VA = "0x1805BBA30")]
		public string DebugInfoString()
		{
			//Discarded unreachable code: IL_00c4
			//IL_0061: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			int nodeCount = NodeCount;
			int num = 0;
			int min = nodeCount;
			int max = num;
			int maxChildCount = num;
			int num2 = Enumerable.Count<QuestNode>(this.get_FinalLeaf());
			QuestNode head = Head;
			int count = 0;
			findMinMax(head, count);
			int nodeCount2 = NodeCount;
			if (maxChildCount != 1)
			{
				string text = $"Count: {num2} (TreeNode)";
				string text2 = "" + text;
				int num3 = min;
				int num4 = max;
				string text3 = $"\nMinPath: {text2}, MaxPath: {text2}";
				string arg = text2 + text3;
				string text4 = $"\nFinalLeaf: {arg}";
			}
			string text5 = $"Count: {num2} (Linear)";
			return "" + text5;
			[Cpp2IlInjected.Token(Token = "0x60084F8")]
			[Cpp2IlInjected.Address(RVA = "0xEBB850", Offset = "0xEBA250", VA = "0x180EBB850")]
			void findMinMax(QuestNode _node, int _count)
			{
				//Discarded unreachable code: IL_006e
				//IL_0045: Expected I4, but got O
				//IL_0065: Expected I4, but got O
				//IL_006d: Expected I4, but got O
				List<QuestNode> childs = _node.Childs;
				Action<QuestNode> action = (Action<QuestNode>)(object)(Action<T>)delegate(QuestNode x)
				{
					//Discarded unreachable code: IL_001b
					int num8 = _count;
					num8++;
					findMinMax(x, num8);
				};
				((List<T>)(object)childs).ForEach((Action<>)(object)action);
				List<QuestNode> childs2 = _node.Childs;
				int num5 = maxChildCount;
				maxChildCount = (int)childs2;
				List<QuestNode> childs3 = _node.Childs;
				int num6 = min;
				int num7 = max;
				min = (int)childs3;
				max = (int)childs3;
			}
		}
	}
}
