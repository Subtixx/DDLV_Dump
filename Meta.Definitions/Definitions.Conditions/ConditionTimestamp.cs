using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200082B")]
	public sealed class ConditionTimestamp : ICondition, IMessage<ConditionTimestamp>, IMessage, IEquatable<ConditionTimestamp>, IDeepCloneable<ConditionTimestamp>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200082C")]
		public enum CheckOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40028A0")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40028A1")]
			Elapsed = 3,
			[Cpp2IlInjected.Token(Token = "0x40028A2")]
			NumberOfResets = 4
		}

		[Cpp2IlInjected.Token(Token = "0x4002895")]
		private static readonly MessageParser<ConditionTimestamp> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002896")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002897")]
		public const int TimestampFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002898")]
		private string timestamp_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002899")]
		public const int OperatorFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400289A")]
		private IntOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x400289B")]
		public const int ElapsedFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400289C")]
		public const int NumberOfResetsFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400289D")]
		private object check_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400289E")]
		private CheckOneofCase checkCase_;

		[Cpp2IlInjected.Token(Token = "0x17001729")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005B8F")]
			[Cpp2IlInjected.Address(RVA = "0x24CC4F0", Offset = "0x24CAEF0", VA = "0x1824CC4F0", Slot = "5")]
			get
			{
				//IL_005a: Expected O, but got I4
				RepeatedField<GUIDNameCollection.Types.GUIDName> gUIDNames_ = ProtoDatabase.Instance.Get<GUIDNameCollection>("TimestampList").gUIDNames_;
				Func<GUIDNameCollection.Types.GUIDName, bool> func = (Func<GUIDNameCollection.Types.GUIDName, bool>)(object)(Func<T, TResult>)delegate(GUIDNameCollection.Types.GUIDName x)
				{
					//Discarded unreachable code: IL_0014
					string b = timestamp_;
					return string.Equals(x.gUID_, b);
				};
				if (Enumerable.FirstOrDefault<GUIDNameCollection.Types.GUIDName>((IEnumerable<>)(object)gUIDNames_, (Func<, >)(object)func) != null)
				{
				}
				int num = 0;
				if (checkCase_ == CheckOneofCase.Elapsed)
				{
					string arg = Operations.ToString(operator_);
					TimeSpan arg2 = default(TimeSpan);
					if (check_ != null)
					{
						return $"Timestamp {num} elapsed {arg} {arg2}";
					}
					throw new InvalidCastException();
				}
				string text = default(string);
				if ((long)text == 4)
				{
					string text2 = Operations.ToString(operator_);
					int numberOfResets = NumberOfResets;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172A")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005B90")]
			[Cpp2IlInjected.Address(RVA = "0x20BE250", Offset = "0x20BCC50", VA = "0x1820BE250", Slot = "6")]
			get
			{
				return ConditionListener.Time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172B")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionTimestamp> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005B92")]
			[Cpp2IlInjected.Address(RVA = "0x24CC820", Offset = "0x24CB220", VA = "0x1824CC820")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B93")]
			[Cpp2IlInjected.Address(RVA = "0x24CC3C0", Offset = "0x24CADC0", VA = "0x1824CC3C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B94")]
			[Cpp2IlInjected.Address(RVA = "0x24CC880", Offset = "0x24CB280", VA = "0x1824CC880", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172E")]
		[DebuggerNonUserCode]
		public string Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6005B99")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return timestamp_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B9A")]
			[Cpp2IlInjected.Address(RVA = "0x24CCA40", Offset = "0x24CB440", VA = "0x1824CCA40")]
			set
			{
				string text = (timestamp_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700172F")]
		[DebuggerNonUserCode]
		public IntOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x6005B9B")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B9C")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001730")]
		[DebuggerNonUserCode]
		public Duration Elapsed
		{
			[Cpp2IlInjected.Token(Token = "0x6005B9D")]
			[Cpp2IlInjected.Address(RVA = "0x24CC490", Offset = "0x24CAE90", VA = "0x1824CC490")]
			get
			{
				int num = 0;
				if (checkCase_ == CheckOneofCase.Elapsed)
				{
					object obj = check_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005B9E")]
			[Cpp2IlInjected.Address(RVA = "0x24CC990", Offset = "0x24CB390", VA = "0x1824CC990")]
			set
			{
				check_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001731")]
		[DebuggerNonUserCode]
		public int NumberOfResets
		{
			[Cpp2IlInjected.Token(Token = "0x6005B9F")]
			[Cpp2IlInjected.Address(RVA = "0x24CC7B0", Offset = "0x24CB1B0", VA = "0x1824CC7B0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (checkCase_ == CheckOneofCase.NumberOfResets)
				{
					object obj = check_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BA0")]
			[Cpp2IlInjected.Address(RVA = "0x24CC9D0", Offset = "0x24CB3D0", VA = "0x1824CC9D0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				check_ = typeof(int).TypeHandle;
				checkCase_ = CheckOneofCase.NumberOfResets;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001732")]
		[DebuggerNonUserCode]
		public CheckOneofCase CheckCase
		{
			[Cpp2IlInjected.Token(Token = "0x6005BA1")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return checkCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B8E")]
		[Cpp2IlInjected.Address(RVA = "0x24CB200", Offset = "0x24C9C00", VA = "0x1824CB200")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_003e, IL_0080
			int num = 0;
			IProfilePlayer section = playerProfile.Section;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (checkCase_ == CheckOneofCase.Elapsed)
				{
					IntOperator intOperator = operator_;
					object obj = check_;
					if (obj != null)
					{
						int num3 = (int)intOperator;
						return flag2;
					}
					throw new InvalidCastException();
				}
				if (flag2)
				{
					uint num4 = default(uint);
					object obj = default(object);
					if ((long)(IntPtr)obj < (long)(int)num4)
					{
						obj += obj;
					}
					DateTime dateTime = default(DateTime);
					TimeSpan timeSpan = DailyResetUtil.LastDailyReset(dateTime) - dateTime;
					IntOperator intOperator2 = operator_;
					int numberOfResets = NumberOfResets;
					int num5 = default(int);
					int num6 = num5 + 1;
					bool result = default(bool);
					return result;
				}
			}
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B91")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B95")]
		[Cpp2IlInjected.Address(RVA = "0x24CC320", Offset = "0x24CAD20", VA = "0x1824CC320")]
		[DebuggerNonUserCode]
		public ConditionTimestamp()
		{
			//IL_0025: Expected I4, but got O
			checkCase_ = (CheckOneofCase)(check_ = new Duration());
		}

		[Cpp2IlInjected.Token(Token = "0x6005B96")]
		[Cpp2IlInjected.Address(RVA = "0x24CBCB0", Offset = "0x24CA6B0", VA = "0x1824CBCB0")]
		private void OnConstruction()
		{
			//IL_0014: Expected I4, but got O
			checkCase_ = (CheckOneofCase)(check_ = new Duration());
		}

		[Cpp2IlInjected.Token(Token = "0x6005B97")]
		[Cpp2IlInjected.Address(RVA = "0x24CC170", Offset = "0x24CAB70", VA = "0x1824CC170")]
		[DebuggerNonUserCode]
		public ConditionTimestamp(ConditionTimestamp other)
		{
			//IL_0025: Expected I4, but got O
			//IL_006d: Expected I4, but got O
			checkCase_ = (CheckOneofCase)(check_ = new Duration());
			string text = (timestamp_ = other.timestamp_);
			IntOperator intOperator = (operator_ = other.operator_);
			CheckOneofCase checkOneofCase = other.checkCase_;
			if (checkOneofCase == CheckOneofCase.Elapsed)
			{
				CheckOneofCase checkOneofCase2 = other.checkCase_;
				if (other.check_ == null)
				{
					throw new InvalidCastException();
				}
				Duration duration = default(Duration);
				check_ = duration;
				checkCase_ = (CheckOneofCase)duration;
			}
			if (checkOneofCase == CheckOneofCase.NumberOfResets)
			{
				int num = (NumberOfResets = other.NumberOfResets);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B98")]
		[Cpp2IlInjected.Address(RVA = "0x24CAFA0", Offset = "0x24C99A0", VA = "0x1824CAFA0", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionTimestamp Clone()
		{
			return new ConditionTimestamp(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005BA2")]
		[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
		[DebuggerNonUserCode]
		public void ClearCheck()
		{
			//IL_0010: Expected O, but got I4
			check_ = (checkCase_ = CheckOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BA3")]
		[Cpp2IlInjected.Address(RVA = "0x24CB010", Offset = "0x24C9A10", VA = "0x1824CB010", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0055: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = timestamp_;
				bool flag = default(bool);
				Duration objB = default(Duration);
				if (!flag && operator_ == (flag ? IntOperator.NotEqual : IntOperator.Equal) && object.Equals(Elapsed, objB))
				{
					int numberOfResets = NumberOfResets;
					int num = 0;
					int num2 = default(int);
					if (numberOfResets == num2 && checkCase_ == (CheckOneofCase)num2)
					{
						return object.Equals(_unknownFields, num);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BA4")]
		[Cpp2IlInjected.Address(RVA = "0x24CB120", Offset = "0x24C9B20", VA = "0x1824CB120", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionTimestamp other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.timestamp_;
				if (!(timestamp_ != text))
				{
					IntOperator intOperator = other.operator_;
					if (operator_ == intOperator)
					{
						Duration elapsed = Elapsed;
						Duration elapsed2 = other.Elapsed;
						if (object.Equals(elapsed, elapsed2))
						{
							int numberOfResets = NumberOfResets;
							int numberOfResets2 = other.NumberOfResets;
							if (numberOfResets == numberOfResets2)
							{
								CheckOneofCase checkOneofCase = other.checkCase_;
								if (checkCase_ == checkOneofCase)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BA5")]
		[Cpp2IlInjected.Address(RVA = "0x24CB6D0", Offset = "0x24CA0D0", VA = "0x1824CB6D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0070
			do
			{
				int num = 0;
				string text = timestamp_;
				if (text.m_stringLength != num)
				{
					int hashCode = text.GetHashCode();
				}
				if (operator_ != 0)
				{
				}
			}
			while (checkCase_ != CheckOneofCase.Elapsed);
			object obj = check_;
			if (obj != null)
			{
				int hashCode2 = obj.GetHashCode();
				if (checkCase_ == CheckOneofCase.NumberOfResets && checkCase_ == CheckOneofCase.NumberOfResets)
				{
					object obj2 = check_;
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode3 = unknownFields.GetHashCode();
				}
				return 1;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005BA6")]
		[Cpp2IlInjected.Address(RVA = "0x24CBEC0", Offset = "0x24CA8C0", VA = "0x1824CBEC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005BA7")]
		[Cpp2IlInjected.Address(RVA = "0x24CBF20", Offset = "0x24CA920", VA = "0x1824CBF20", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0070
			do
			{
				if (timestamp_.m_stringLength != 0)
				{
					string value = timestamp_;
					output.WriteString(value);
				}
				if (operator_ != 0)
				{
				}
			}
			while (checkCase_ != CheckOneofCase.Elapsed);
			if (checkCase_ == CheckOneofCase.Elapsed)
			{
				object obj = check_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (checkCase_ == CheckOneofCase.NumberOfResets)
			{
				int numberOfResets = NumberOfResets;
				output.WriteInt32(numberOfResets);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005BA8")]
		[Cpp2IlInjected.Address(RVA = "0x24CACA0", Offset = "0x24C96A0", VA = "0x1824CACA0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00a4
			string text = timestamp_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			IntOperator intOperator = operator_;
			if (intOperator != 0)
			{
				int num3 = CodedOutputStream.ComputeEnumSize((int)intOperator);
				num3++;
				num += num3;
			}
			if (checkCase_ == CheckOneofCase.Elapsed)
			{
				if (checkCase_ != CheckOneofCase.Elapsed)
				{
				}
				object obj = check_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (checkCase_ == CheckOneofCase.NumberOfResets)
			{
				if (checkCase_ == CheckOneofCase.NumberOfResets)
				{
					object obj2 = check_;
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BA9")]
		[Cpp2IlInjected.Address(RVA = "0x24CBAA0", Offset = "0x24CA4A0", VA = "0x1824CBAA0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionTimestamp other)
		{
			//Discarded unreachable code: IL_00e9
			if (other == null)
			{
				return;
			}
			string text = other.timestamp_;
			if (text.m_stringLength != 0)
			{
				Timestamp = text;
			}
			IntOperator intOperator = other.operator_;
			if (intOperator != 0)
			{
				operator_ = intOperator;
			}
			if (other.checkCase_ == CheckOneofCase.Elapsed)
			{
				CheckOneofCase checkOneofCase = checkCase_;
				object obj = default(object);
				if (checkOneofCase == CheckOneofCase.Elapsed)
				{
					obj = check_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					Duration duration = (Duration)(check_ = new Duration());
					checkCase_ = checkOneofCase;
				}
				if (checkCase_ == CheckOneofCase.Elapsed)
				{
					object obj2 = check_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.checkCase_ == CheckOneofCase.Elapsed)
				{
					object obj3 = other.check_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(Duration).TypeHandle == 4)
			{
				int num = (NumberOfResets = other.NumberOfResets);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6005BAA")]
		[Cpp2IlInjected.Address(RVA = "0x24CB8F0", Offset = "0x24CA2F0", VA = "0x1824CB8F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0057: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					Duration duration = new Duration();
					if (checkCase_ == CheckOneofCase.Elapsed)
					{
						if (checkCase_ != CheckOneofCase.Elapsed)
						{
						}
						object obj = check_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(duration);
					check_ = duration;
					checkCase_ = (CheckOneofCase)duration;
				}
				if (num != 32)
				{
					goto IL_0099;
				}
				int num3 = (NumberOfResets = input.ReadInt32());
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (Timestamp = input.ReadString());
			}
			if ((long)text2 == 16)
			{
				int num4 = (int)(operator_ = (IntOperator)input.ReadInt32());
			}
			goto IL_0099;
			IL_0099:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005BAB")]
		[Cpp2IlInjected.Address(RVA = "0x24CB5B0", Offset = "0x24C9FB0", VA = "0x1824CB5B0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						int numberOfResets = NumberOfResets;
					}
					Duration elapsed = Elapsed;
				}
				IntOperator intOperator = operator_;
			}
			string text = timestamp_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BAC")]
		[Cpp2IlInjected.Address(RVA = "0x24CBD20", Offset = "0x24CA720", VA = "0x1824CBD20", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_002f: Expected I4, but got O
			//IL_0037: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 0:
						if (value == null || value != null)
						{
							check_ = value;
							checkCase_ = (CheckOneofCase)typeof(string).TypeHandle;
							break;
						}
						throw new InvalidCastException();
					}
				}
				else
				{
					object obj = default(object);
					operator_ = (IntOperator)obj;
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005BAD")]
		[Cpp2IlInjected.Address(RVA = "0x24CAE80", Offset = "0x24C9880", VA = "0x1824CAE80", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0027: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num4 = (NumberOfResets = 0);
						break;
					}
					case 0:
					{
						int num2 = 0;
						check_ = num2;
						checkCase_ = (CheckOneofCase)num2;
						break;
					}
					}
				}
				else
				{
					int num5 = (int)(operator_ = IntOperator.Equal);
				}
			}
			else
			{
				Timestamp = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005BAE")]
		[Cpp2IlInjected.Address(RVA = "0x24CB840", Offset = "0x24CA240", VA = "0x1824CB840", Slot = "18")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Check"))
			{
				CheckOneofCase checkOneofCase = checkCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BAF")]
		[Cpp2IlInjected.Address(RVA = "0x24CAF30", Offset = "0x24C9930", VA = "0x1824CAF30", Slot = "19")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Check"))
			{
				check_ = (checkCase_ = CheckOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005BB0")]
		[Cpp2IlInjected.Address(RVA = "0x24CC060", Offset = "0x24CAA60", VA = "0x1824CC060")]
		static ConditionTimestamp()
		{
			Func<ConditionTimestamp> func = default(Func<ConditionTimestamp>);
			_parser = (MessageParser<ConditionTimestamp>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005BB1")]
		[Cpp2IlInjected.Address(RVA = "0x24CB000", Offset = "0x24C9A00", VA = "0x1824CB000", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			return Evaluate(in playerProfile, in worldProfile, context);
		}
	}
}
