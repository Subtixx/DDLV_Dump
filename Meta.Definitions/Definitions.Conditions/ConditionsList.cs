using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007B7")]
	public sealed class ConditionsList : IDateCondition, ICondition, IConditions, IMessage<ConditionsList>, IMessage, IEquatable<ConditionsList>, IDeepCloneable<ConditionsList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20007B8")]
		private delegate void MergeDateMethod(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, IDateCondition dateCondition, ref bool hasStartDate, ref DateTime startDate, ref bool hasEndDate, ref DateTime endDate);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002692")]
		private ConditionListener? MergedListenerCache;

		[Cpp2IlInjected.Token(Token = "0x4002693")]
		private static readonly MessageParser<ConditionsList> _parser = (MessageParser<ConditionsList>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ConditionsList()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002694")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002695")]
		public const int OperatorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002696")]
		private BoolOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x4002697")]
		public const int ConditionsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4002698")]
		private static readonly FieldCodec<ConditionOneOf> _repeated_conditions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002699")]
		private readonly RepeatedField<ConditionOneOf> conditions_;

		[Cpp2IlInjected.Token(Token = "0x17001571")]
		IEnumerable<ICondition> IConditions.Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x60054E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "10")]
			get
			{
				RepeatedField<ConditionOneOf> repeatedField = conditions_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001572")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60054E2")]
			[Cpp2IlInjected.Address(RVA = "0x24DBE40", Offset = "0x24DA840", VA = "0x1824DBE40")]
			get
			{
				//Discarded unreachable code: IL_000f
				return ((RepeatedField<T>)(object)conditions_).Count == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001573")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60054E5")]
			[Cpp2IlInjected.Address(RVA = "0x24DBDF0", Offset = "0x24DA7F0", VA = "0x1824DBDF0", Slot = "7")]
			get
			{
				string result = "All conditions are true (AND)";
				if (operator_ == BoolOperator.Or)
				{
					result = "Any condition is true (OR)";
				}
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001574")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x60054E6")]
			[Cpp2IlInjected.Address(RVA = "0x24DBE90", Offset = "0x24DA890", VA = "0x1824DBE90", Slot = "8")]
			get
			{
				//Discarded unreachable code: IL_0002, IL_0011, IL_0028
				//IL_003d: Expected O, but got I8
				ConditionListener result = default(ConditionListener);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001575")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionsList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60054EE")]
			[Cpp2IlInjected.Address(RVA = "0x24DC0A0", Offset = "0x24DAAA0", VA = "0x1824DC0A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001576")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60054EF")]
			[Cpp2IlInjected.Address(RVA = "0x24DBD20", Offset = "0x24DA720", VA = "0x1824DBD20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001577")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60054F0")]
			[Cpp2IlInjected.Address(RVA = "0x24DC100", Offset = "0x24DAB00", VA = "0x1824DC100", Slot = "15")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001578")]
		[DebuggerNonUserCode]
		public BoolOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x60054F4")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x60054F5")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001579")]
		[DebuggerNonUserCode]
		public RepeatedField<ConditionOneOf> Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x60054F6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return conditions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054D9")]
		[Cpp2IlInjected.Address(RVA = "0x24DA7C0", Offset = "0x24D91C0", VA = "0x1824DA7C0")]
		private unsafe void IntersectDates(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, IDateCondition dateCondition, ref bool hasStartDate, ref DateTime startDate, ref bool hasEndDate, ref DateTime endDate)
		{
			//Discarded unreachable code: IL_002f
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected I4, but got Unknown
			int num = 0;
			if ((long)num < (long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref worldProfile))
			{
				num += num;
				num++;
			}
			bool flag = default(bool);
			if ((object)typeof(IDateCondition).TypeHandle == null || flag)
			{
			}
			if (num < num)
			{
				num += num;
				num++;
			}
			bool flag2 = default(bool);
			if (num != 0 && !flag2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054DA")]
		[Cpp2IlInjected.Address(RVA = "0x24DB5E0", Offset = "0x24D9FE0", VA = "0x1824DB5E0")]
		private unsafe void UnionDates(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, IDateCondition dateCondition, ref bool hasStartDate, ref DateTime startDate, ref bool hasEndDate, ref DateTime endDate)
		{
			//Discarded unreachable code: IL_004f
			int num = 0;
			if ((long)num < (long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref worldProfile))
			{
				num += num;
				num++;
			}
			if ((long)num < (long)(IntPtr)typeof(IDateCondition).TypeHandle)
			{
				num += num;
				num++;
			}
			if ((IntPtr)typeof(ITransactionContext).TypeHandle == (IntPtr)num && (object)typeof(ITransactionContext).TypeHandle == null)
			{
				if (num == 0)
				{
					return;
				}
				num += 312;
				num += 328;
			}
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag || flag2)
			{
			}
			if (num == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054DB")]
		[Cpp2IlInjected.Address(RVA = "0x24DB140", Offset = "0x24D9B40", VA = "0x1824DB140")]
		private void MergeStartDates(ref DateTime startDate, DateTime start)
		{
			//IL_000b: Expected I8, but got O
			bool flag = default(bool);
			if (flag)
			{
				startDate.dateData = (ulong)(long)start;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054DC")]
		[Cpp2IlInjected.Address(RVA = "0x24DAF30", Offset = "0x24D9930", VA = "0x1824DAF30")]
		private void MergeEndDates(ref DateTime endDate, DateTime end)
		{
			//IL_000b: Expected I8, but got O
			bool flag = default(bool);
			if (flag)
			{
				endDate.dateData = (ulong)(long)end;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054DD")]
		[Cpp2IlInjected.Address(RVA = "0x24DB1C0", Offset = "0x24D9BC0", VA = "0x1824DB1C0")]
		private void SelectBestDates(DateTime now, ref DateTime startDate, ref DateTime endDate, DateTime start, DateTime end)
		{
			//IL_0030: Expected I8, but got I4
			//IL_0037: Expected I8, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				return;
			}
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			if (!flag3 || !flag4)
			{
				bool flag5 = default(bool);
				bool flag6 = default(bool);
				if (!flag5 || flag6)
				{
				}
				bool flag7 = default(bool);
				bool flag8 = default(bool);
				if (!flag7 || flag8)
				{
				}
				bool flag9 = default(bool);
				if (!flag9)
				{
					return;
				}
			}
			startDate.dateData = 0uL;
			endDate.dateData = 0uL;
		}

		[Cpp2IlInjected.Token(Token = "0x60054DE")]
		[Cpp2IlInjected.Address(RVA = "0x24DAA30", Offset = "0x24D9430", VA = "0x1824DAA30")]
		public bool MergeAllDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out bool hasStartDate, out DateTime startDate, out bool hasEndDate, out DateTime endDate)
		{
			//Discarded unreachable code: IL_0039, IL_003f, IL_0045
			int num = 0;
			MergeDateMethod mergeDateMethod = IntersectDates;
			if (operator_ == BoolOperator.Or)
			{
				MergeDateMethod mergeDateMethod2 = UnionDates;
			}
			RepeatedField<ConditionOneOf> repeatedField = conditions_;
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60054DF")]
		[Cpp2IlInjected.Address(RVA = "0x24D9EC0", Offset = "0x24D88C0", VA = "0x1824D9EC0")]
		public bool HasStartDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime startDate)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60054E0")]
		[Cpp2IlInjected.Address(RVA = "0x24D9E70", Offset = "0x24D8870", VA = "0x1824D9E70")]
		public bool HasEndDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime endDate)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60054E3")]
		[Cpp2IlInjected.Address(RVA = "0x24DA1E0", Offset = "0x24D8BE0", VA = "0x1824DA1E0")]
		public bool Evaluate(IProfile profile, ITransactionContext context)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60054E4")]
		[Cpp2IlInjected.Address(RVA = "0x24DA090", Offset = "0x24D8A90", VA = "0x1824DA090")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			if (((RepeatedField<T>)(object)conditions_).Count != 0)
			{
				RepeatedField<ConditionOneOf> repeatedField = conditions_;
				int num = 0;
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				if (num < count)
				{
					bool flag = ((ConditionOneOf)((RepeatedField<T>)(object)conditions_)[num]).Evaluate(in playerProfile, in worldProfile, context);
					BoolOperator boolOperator = operator_;
					if (!flag)
					{
						if (boolOperator == BoolOperator.And)
						{
							return flag;
						}
					}
					else if (boolOperator == BoolOperator.Or)
					{
						goto IL_005b;
					}
					RepeatedField<ConditionOneOf> repeatedField2 = conditions_;
					num++;
				}
			}
			goto IL_005b;
			IL_005b:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054E7")]
		[Cpp2IlInjected.Address(RVA = "0x24DAA10", Offset = "0x24D9410", VA = "0x1824DAA10")]
		public bool IsAffectedBy(ConditionListener listener)
		{
			ConditionListener listener2 = Listener;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60054E8")]
		[Cpp2IlInjected.Address(RVA = "0x24DA5E0", Offset = "0x24D8FE0", VA = "0x1824DA5E0", Slot = "9")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			//Discarded unreachable code: IL_0053
			RepeatedField<ConditionOneOf> repeatedField = conditions_;
			Func<ConditionOneOf, LockedInfo> func = (Func<ConditionOneOf, LockedInfo>)(object)(Func<T, TResult>)delegate(ConditionOneOf x)
			{
				//Discarded unreachable code: IL_000f
				MissionItemData data2 = data;
				return x.GetLockedInfo(data2);
			};
			IEnumerable<ConditionOneOf> enumerable = (IEnumerable<ConditionOneOf>)Enumerable.Select<ConditionOneOf, LockedInfo>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			Func<LockedInfo, bool> _003C_003E9__21_ = _003C_003Ec._003C_003E9__21_1;
			if (_003C_003E9__21_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((LockedInfo x) => x != null);
			}
			return Enumerable.FirstOrDefault<LockedInfo>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__21_);
		}

		[Cpp2IlInjected.Token(Token = "0x60054E9")]
		[Cpp2IlInjected.Address(RVA = "0x24DAD60", Offset = "0x24D9760", VA = "0x1824DAD60")]
		public static ConditionListener MergeConditionListeners(IEnumerable<ConditionListener> listeners)
		{
			//Discarded unreachable code: IL_0030
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					goto IL_002a;
				}
				num++;
			}
			uint num3 = default(uint);
			if ((object)typeof(IEnumerator).TypeHandle != null && num < (int)num3)
			{
				num += num;
				if (num != (int)num3)
				{
					num++;
				}
			}
			goto IL_002a;
			IL_002a:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054EA")]
		[Cpp2IlInjected.Address(RVA = "0x24DA380", Offset = "0x24D8D80", VA = "0x1824DA380")]
		public string GetAllInfo(PlayerProfile playerProfile, WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_002c
			//IL_002b: Expected O, but got I4
			int deep2 = 0;
			_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0;
			string arg = GetInfo(this, deep2);
			ConditionListener listener = Listener;
			return $"{arg}\nEvents: {listener}";
			[Cpp2IlInjected.Token(Token = "0x6005514")]
			[Cpp2IlInjected.Address(RVA = "0x9098C0", Offset = "0x9082C0", VA = "0x1809098C0")]
			string GetInfo(ICondition condition, int deep)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_1();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals0.deep = deep;
				if (CS_0024_003C_003E8__locals0 != null)
				{
				}
				int num = default(int);
				if (condition != null && condition != null && num == 1)
				{
					int deep3 = CS_0024_003C_003E8__locals0.deep;
					ConditionOneOf condition2 = default(ConditionOneOf);
					return GetInfo(condition2, deep3);
				}
				string text2 = Prefix(CS_0024_003C_003E8__locals0.deep);
				if (context != null)
				{
				}
				string text3 = default(string);
				string text4 = text2 + "" + text3;
				if (text4 != null && text4 != null && Enumerable.Any<ICondition>((IEnumerable<>)(object)text4))
				{
					string text5 = Prefix(CS_0024_003C_003E8__locals0.deep);
					string text6 = "\n" + text5;
					Func<ICondition, string> func = (Func<ICondition, string>)(object)(Func<T, TResult>)delegate(ICondition x)
					{
						//Discarded unreachable code: IL_0017
						CS_0024_003C_003E8__locals0 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1;
						int deep4 = CS_0024_003C_003E8__locals0.deep;
						return GetInfo(x, deep4);
					};
					IEnumerable<ICondition> enumerable = (IEnumerable<ICondition>)Enumerable.Select<ICondition, string>((IEnumerable<>)(object)text6, (Func<, >)(object)func);
					string text7 = string.Join(text6, (IEnumerable<>)enumerable);
					string text8 = text4 + text6 + text7;
				}
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005506")]
			[Cpp2IlInjected.Address(RVA = "0x24DB580", Offset = "0x24D9F80", VA = "0x1824DB580")]
			static string Prefix(int deep)
			{
				if (deep > 0)
				{
					string text = "" + "  ";
					while (deep != 0)
					{
					}
				}
				return "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054EB")]
		[Cpp2IlInjected.Address(RVA = "0x24DA260", Offset = "0x24D8C60", VA = "0x1824DA260")]
		public IEnumerable<ICondition> GetAllConditions()
		{
			new _003CGetAllConditions_003Ed__26(-2)._003C_003E3__condition = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054EC")]
		[Cpp2IlInjected.Address(RVA = "0x16CDE40", Offset = "0x16CC840", VA = "0x1816CDE40")]
		public IEnumerable<> GetAllConditions<T>() where T : class, ICondition
		{
			//IL_000e: Expected O, but got I4
			int num = 0;
			IEnumerator<ICondition> enumerator = (IEnumerator<ICondition>)((IEnumerable<T>)Enumerable.Where<ICondition>(ConditionsList.GetAllConditions((ICondition)this), (Func<, >)num)).GetEnumerator();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60054ED")]
		[Cpp2IlInjected.Address(RVA = "0x24DA310", Offset = "0x24D8D10", VA = "0x1824DA310")]
		[IteratorStateMachine(typeof(_003CGetAllConditions_003Ed__26))]
		private static IEnumerable<ICondition> GetAllConditions(ICondition condition)
		{
			new _003CGetAllConditions_003Ed__26(-2)._003C_003E3__condition = condition;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054F1")]
		[Cpp2IlInjected.Address(RVA = "0x24DBC10", Offset = "0x24DA610", VA = "0x1824DBC10")]
		[DebuggerNonUserCode]
		public ConditionsList()
		{
			conditions_ = (RepeatedField<ConditionOneOf>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60054F2")]
		[Cpp2IlInjected.Address(RVA = "0x24DBC90", Offset = "0x24DA690", VA = "0x1824DBC90")]
		[DebuggerNonUserCode]
		public ConditionsList(ConditionsList other)
		{
			BoolOperator boolOperator = (operator_ = other.operator_);
			RepeatedField<ConditionOneOf> repeatedField = (conditions_ = (RepeatedField<ConditionOneOf>)(object)((RepeatedField<T>)(object)other.conditions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054F3")]
		[Cpp2IlInjected.Address(RVA = "0x24D9DA0", Offset = "0x24D87A0", VA = "0x1824D9DA0", Slot = "17")]
		[DebuggerNonUserCode]
		public ConditionsList Clone()
		{
			//Discarded unreachable code: IL_003c
			ConditionsList conditionsList = new ConditionsList();
			BoolOperator boolOperator = (conditionsList.operator_ = operator_);
			RepeatedField<ConditionOneOf> repeatedField = (conditionsList.conditions_ = (RepeatedField<ConditionOneOf>)(object)((RepeatedField<T>)(object)conditions_).Clone());
			UnknownFieldSet unknownFieldSet = (conditionsList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionsList;
		}

		[Cpp2IlInjected.Token(Token = "0x60054F7")]
		[Cpp2IlInjected.Address(RVA = "0x24D9F10", Offset = "0x24D8910", VA = "0x1824D9F10", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionsList).TypeHandle)
				{
					RepeatedField<ConditionOneOf> repeatedField = conditions_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054F8")]
		[Cpp2IlInjected.Address(RVA = "0x24D9FF0", Offset = "0x24D89F0", VA = "0x1824D9FF0", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionsList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				BoolOperator boolOperator = other.operator_;
				if (operator_ == boolOperator)
				{
					RepeatedField<ConditionOneOf> repeatedField = conditions_;
					RepeatedField<ConditionOneOf> repeatedField2 = other.conditions_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60054F9")]
		[Cpp2IlInjected.Address(RVA = "0x24DA560", Offset = "0x24D8F60", VA = "0x1824DA560", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0029
			if (operator_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)conditions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60054FA")]
		[Cpp2IlInjected.Address(RVA = "0x24DB520", Offset = "0x24D9F20", VA = "0x1824DB520", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60054FB")]
		[Cpp2IlInjected.Address(RVA = "0x24DB950", Offset = "0x24DA350", VA = "0x1824DB950", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0031
			if (operator_ != 0)
			{
			}
			RepeatedField<ConditionOneOf> repeatedField = conditions_;
			FieldCodec<ConditionOneOf> repeated_conditions_codec = _repeated_conditions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_conditions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60054FC")]
		[Cpp2IlInjected.Address(RVA = "0x24D9C40", Offset = "0x24D8640", VA = "0x1824D9C40", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			BoolOperator boolOperator = operator_;
			int num = 0;
			if (boolOperator != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)boolOperator);
			}
			RepeatedField<ConditionOneOf> repeatedField = conditions_;
			FieldCodec<ConditionOneOf> repeated_conditions_codec = _repeated_conditions_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_conditions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60054FD")]
		[Cpp2IlInjected.Address(RVA = "0x24DAFB0", Offset = "0x24D99B0", VA = "0x1824DAFB0", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionsList other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				BoolOperator boolOperator = other.operator_;
				if (boolOperator != 0)
				{
					operator_ = boolOperator;
				}
				RepeatedField<ConditionOneOf> repeatedField = conditions_;
				RepeatedField<ConditionOneOf> repeatedField2 = other.conditions_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054FE")]
		[Cpp2IlInjected.Address(RVA = "0x24DB040", Offset = "0x24D9A40", VA = "0x1824DB040", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(operator_ = (BoolOperator)input.ReadInt32());
				}
				if (num == 18)
				{
					RepeatedField<ConditionOneOf> repeatedField = conditions_;
					FieldCodec<ConditionOneOf> repeated_conditions_codec = _repeated_conditions_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_conditions_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60054FF")]
		[Cpp2IlInjected.Address(RVA = "0x24DA490", Offset = "0x24D8E90", VA = "0x1824DA490", Slot = "18")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				BoolOperator boolOperator = operator_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<ConditionOneOf> repeatedField = conditions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005500")]
		[Cpp2IlInjected.Address(RVA = "0x24DB450", Offset = "0x24D9E50", VA = "0x1824DB450", Slot = "19")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				operator_ = (BoolOperator)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005501")]
		[Cpp2IlInjected.Address(RVA = "0x24D9D30", Offset = "0x24D8730", VA = "0x1824D9D30", Slot = "20")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				operator_ = BoolOperator.And;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<ConditionOneOf> repeatedField = conditions_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005502")]
		[Cpp2IlInjected.Address(RVA = "0x24DBA40", Offset = "0x24DA440", VA = "0x1824DBA40")]
		static ConditionsList()
		{
			MessageParser<ConditionOneOf> parser = ConditionOneOf._parser;
			uint num = default(uint);
			_parser = (MessageParser<ConditionsList>)(object)FieldCodec.ForMessage<ConditionOneOf>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005503")]
		[Cpp2IlInjected.Address(RVA = "0x24D9EC0", Offset = "0x24D88C0", VA = "0x1824D9EC0", Slot = "4")]
		bool IDateCondition.HasStartDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime startDate)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005504")]
		[Cpp2IlInjected.Address(RVA = "0x24D9E70", Offset = "0x24D8870", VA = "0x1824D9E70", Slot = "5")]
		bool IDateCondition.HasEndDate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context, out DateTime endDate)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005505")]
		[Cpp2IlInjected.Address(RVA = "0x24D9E60", Offset = "0x24D8860", VA = "0x1824D9E60", Slot = "6")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			return Evaluate(in playerProfile, in worldProfile, context);
		}
	}
}
