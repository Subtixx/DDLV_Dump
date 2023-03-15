using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004E0")]
	public sealed class StepAmount : IMessage<StepAmount>, IMessage, IEquatable<StepAmount>, IDeepCloneable<StepAmount>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20004E1")]
		public enum StepAmountOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001A31")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001A32")]
			Value,
			[Cpp2IlInjected.Token(Token = "0x4001A33")]
			Range,
			[Cpp2IlInjected.Token(Token = "0x4001A34")]
			Variable
		}

		[Cpp2IlInjected.Token(Token = "0x4001A25")]
		private static readonly MessageParser<StepAmount> _parser = (MessageParser<StepAmount>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new StepAmount()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A26")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001A27")]
		public const int ValueFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001A28")]
		public const int RangeFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001A29")]
		public const int VariableFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4001A2A")]
		public const int UseCustomVariableNameFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A2B")]
		private bool useCustomVariableName_;

		[Cpp2IlInjected.Token(Token = "0x4001A2C")]
		public const int VariableNameFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001A2D")]
		private string variableName_ = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001A2E")]
		private object stepAmount_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001A2F")]
		private StepAmountOneofCase stepAmountCase_;

		[Cpp2IlInjected.Token(Token = "0x17000F71")]
		[DebuggerNonUserCode]
		public static MessageParser<StepAmount> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003C2A")]
			[Cpp2IlInjected.Address(RVA = "0x26337E0", Offset = "0x26321E0", VA = "0x1826337E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F72")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003C2B")]
			[Cpp2IlInjected.Address(RVA = "0x2633710", Offset = "0x2632110", VA = "0x182633710")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F73")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2633970", Offset = "0x2632370", VA = "0x182633970", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F74")]
		[DebuggerNonUserCode]
		public ScalableValue Value
		{
			[Cpp2IlInjected.Token(Token = "0x6003C31")]
			[Cpp2IlInjected.Address(RVA = "0x26338A0", Offset = "0x26322A0", VA = "0x1826338A0")]
			get
			{
				int num = 0;
				if (stepAmountCase_ == StepAmountOneofCase.Value)
				{
					object obj = stepAmount_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003C32")]
			[Cpp2IlInjected.Address(RVA = "0x25F14A0", Offset = "0x25EFEA0", VA = "0x1825F14A0")]
			set
			{
				stepAmount_ = value;
				bool flag = (byte)(stepAmountCase_ = ((value != null) ? StepAmountOneofCase.Value : StepAmountOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F75")]
		[DebuggerNonUserCode]
		public Range Range
		{
			[Cpp2IlInjected.Token(Token = "0x6003C33")]
			[Cpp2IlInjected.Address(RVA = "0x2633840", Offset = "0x2632240", VA = "0x182633840")]
			get
			{
				int num = 0;
				if (stepAmountCase_ == StepAmountOneofCase.Range)
				{
					object obj = stepAmount_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003C34")]
			[Cpp2IlInjected.Address(RVA = "0x25F1460", Offset = "0x25EFE60", VA = "0x1825F1460")]
			set
			{
				stepAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F76")]
		[DebuggerNonUserCode]
		public string Variable
		{
			[Cpp2IlInjected.Token(Token = "0x6003C35")]
			[Cpp2IlInjected.Address(RVA = "0x2633900", Offset = "0x2632300", VA = "0x182633900")]
			get
			{
				if (stepAmountCase_ == StepAmountOneofCase.Variable)
				{
					object obj = stepAmount_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				return "";
			}
			[Cpp2IlInjected.Token(Token = "0x6003C36")]
			[Cpp2IlInjected.Address(RVA = "0x2633AF0", Offset = "0x26324F0", VA = "0x182633AF0")]
			set
			{
				//IL_001c: Expected I4, but got I8
				string text = (string)(stepAmount_ = ProtoPreconditions.CheckNotNull(value, "value"));
				stepAmountCase_ = StepAmountOneofCase.Variable;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F77")]
		[DebuggerNonUserCode]
		public bool UseCustomVariableName
		{
			[Cpp2IlInjected.Token(Token = "0x6003C37")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useCustomVariableName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C38")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useCustomVariableName_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F78")]
		[DebuggerNonUserCode]
		public string VariableName
		{
			[Cpp2IlInjected.Token(Token = "0x6003C39")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return variableName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C3A")]
			[Cpp2IlInjected.Address(RVA = "0x2633A80", Offset = "0x2632480", VA = "0x182633A80")]
			set
			{
				string text = (variableName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F79")]
		[DebuggerNonUserCode]
		public StepAmountOneofCase StepAmountCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003C3B")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return stepAmountCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7A")]
		public bool IsVariableSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003C4A")]
			[Cpp2IlInjected.Address(RVA = "0x25F1130", Offset = "0x25EFB30", VA = "0x1825F1130")]
			get
			{
				return stepAmountCase_ == StepAmountOneofCase.Variable;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C2D")]
		[Cpp2IlInjected.Address(RVA = "0x2633390", Offset = "0x2631D90", VA = "0x182633390")]
		[DebuggerNonUserCode]
		public StepAmount()
		{
			bool flag = (byte)(stepAmountCase_ = (((stepAmount_ = new ScalableValue()) != null) ? StepAmountOneofCase.Value : StepAmountOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C2E")]
		[Cpp2IlInjected.Address(RVA = "0x2632DF0", Offset = "0x26317F0", VA = "0x182632DF0")]
		private void OnConstruction()
		{
			bool flag = (byte)(stepAmountCase_ = (((stepAmount_ = new ScalableValue()) != null) ? StepAmountOneofCase.Value : StepAmountOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2633430", Offset = "0x2631E30", VA = "0x182633430")]
		[DebuggerNonUserCode]
		public StepAmount(StepAmount other)
		{
			//IL_007e: Expected I4, but got O
			ScalableValue scalableValue = (ScalableValue)(stepAmount_ = new ScalableValue());
			int num = 0;
			bool flag = (byte)(stepAmountCase_ = ((scalableValue != null) ? StepAmountOneofCase.Value : StepAmountOneofCase.None)) != 0;
			bool flag2 = (useCustomVariableName_ = other.useCustomVariableName_);
			string text = (variableName_ = other.variableName_);
			string text2 = (Variable = other.Variable);
			StepAmountOneofCase stepAmountOneofCase = other.stepAmountCase_;
			if (other.stepAmount_ != null)
			{
				Range range = default(Range);
				stepAmount_ = range;
				stepAmountCase_ = (StepAmountOneofCase)range;
				StepAmountOneofCase stepAmountOneofCase2 = other.stepAmountCase_;
				if (other.stepAmount_ != null)
				{
					ScalableValue scalableValue2 = default(ScalableValue);
					stepAmount_ = scalableValue2;
					bool flag3 = (byte)(stepAmountCase_ = ((scalableValue2 != null) ? StepAmountOneofCase.Value : StepAmountOneofCase.None)) != 0;
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C30")]
		[Cpp2IlInjected.Address(RVA = "0x2631D80", Offset = "0x2630780", VA = "0x182631D80", Slot = "10")]
		[DebuggerNonUserCode]
		public StepAmount Clone()
		{
			return new StepAmount(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C3C")]
		[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
		[DebuggerNonUserCode]
		public void ClearStepAmount()
		{
			//IL_0010: Expected O, but got I4
			stepAmount_ = (stepAmountCase_ = StepAmountOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2632110", Offset = "0x2630B10", VA = "0x182632110", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((StepAmount)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2631F90", Offset = "0x2630990", VA = "0x182631F90", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StepAmount other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (stepAmountCase_ == StepAmountOneofCase.Value)
				{
					object obj = stepAmount_;
					if (obj != null && obj == null)
					{
						goto IL_00e5;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.stepAmountCase_ == StepAmountOneofCase.Value)
				{
					obj2 = other.stepAmount_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					Range range = Range;
					Range range2 = other.Range;
					if (object.Equals(range, range2))
					{
						string variable = Variable;
						string variable2 = other.Variable;
						if (!(variable != variable2))
						{
							bool flag = other.useCustomVariableName_;
							if (useCustomVariableName_ == flag)
							{
								string text = other.variableName_;
								if (!(variableName_ != text))
								{
									StepAmountOneofCase stepAmountOneofCase = other.stepAmountCase_;
									if (stepAmountCase_ == stepAmountOneofCase)
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										bool flag2 = object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00e5;
			IL_00e5:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2632530", Offset = "0x2630F30", VA = "0x182632530", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00a9
			while (true)
			{
				StepAmountOneofCase stepAmountOneofCase = stepAmountCase_;
				int num = 0;
				if (stepAmountOneofCase == StepAmountOneofCase.Value)
				{
					object obj = stepAmount_;
					if (obj == null)
					{
						break;
					}
					int hashCode = obj.GetHashCode();
				}
				if (stepAmountOneofCase != StepAmountOneofCase.Range)
				{
					continue;
				}
				object obj2 = stepAmount_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (stepAmountCase_ == StepAmountOneofCase.Variable)
					{
						if (stepAmountCase_ != StepAmountOneofCase.Variable)
						{
						}
						object obj3 = stepAmount_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
						int hashCode3 = obj3.GetHashCode();
					}
					if (useCustomVariableName_)
					{
					}
					string text = variableName_;
					if (text.m_stringLength != 0)
					{
						int hashCode4 = text.GetHashCode();
					}
					UnknownFieldSet unknownFields = _unknownFields;
					if (unknownFields != null)
					{
						int hashCode5 = unknownFields.GetHashCode();
					}
					return 1;
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C40")]
		[Cpp2IlInjected.Address(RVA = "0x2633060", Offset = "0x2631A60", VA = "0x182633060", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C41")]
		[Cpp2IlInjected.Address(RVA = "0x26330C0", Offset = "0x2631AC0", VA = "0x1826330C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b1
			//IL_002f: Expected O, but got I4
			while (true)
			{
				StepAmountOneofCase stepAmountOneofCase = stepAmountCase_;
				int num = 0;
				if (stepAmountOneofCase == StepAmountOneofCase.Value)
				{
					if (stepAmountCase_ == StepAmountOneofCase.Value)
					{
						object obj = stepAmount_;
						if (obj != null && obj == null)
						{
							break;
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (stepAmountOneofCase != StepAmountOneofCase.Range)
				{
					continue;
				}
				if (stepAmountCase_ == StepAmountOneofCase.Range)
				{
					object obj2 = stepAmount_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (stepAmountCase_ == StepAmountOneofCase.Variable)
				{
					string variable = Variable;
					output.WriteString(variable);
				}
				if (useCustomVariableName_)
				{
					bool value = useCustomVariableName_;
					output.WriteBool(value);
				}
				if (variableName_.m_stringLength != 0)
				{
					string value2 = variableName_;
					output.WriteString(value2);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C42")]
		[Cpp2IlInjected.Address(RVA = "0x2631A20", Offset = "0x2630420", VA = "0x182631A20", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00ca
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (stepAmountCase_ == StepAmountOneofCase.Value)
			{
				if (stepAmountCase_ == StepAmountOneofCase.Value)
				{
					object obj = stepAmount_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (stepAmountCase_ == StepAmountOneofCase.Range)
			{
				if (stepAmountCase_ != StepAmountOneofCase.Range)
				{
				}
				object obj2 = stepAmount_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (stepAmountCase_ == StepAmountOneofCase.Variable)
			{
				if (stepAmountCase_ != StepAmountOneofCase.Variable)
				{
				}
				object obj3 = stepAmount_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			string text = variableName_;
			if (text.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text);
				num5++;
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

		[Cpp2IlInjected.Token(Token = "0x6003C43")]
		[Cpp2IlInjected.Address(RVA = "0x26329D0", Offset = "0x26313D0", VA = "0x1826329D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StepAmount other)
		{
			//Discarded unreachable code: IL_00fa
			//IL_007e: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			bool flag = other.useCustomVariableName_;
			if (flag)
			{
				useCustomVariableName_ = flag;
			}
			string text = other.variableName_;
			if (text.m_stringLength != 0)
			{
				VariableName = text;
			}
			StepAmountOneofCase stepAmountOneofCase = other.stepAmountCase_;
			if (text.m_stringLength != 0)
			{
				if (text.m_stringLength != 0)
				{
					if (stepAmountOneofCase != StepAmountOneofCase.Value)
					{
						goto IL_00da;
					}
					string text2 = (Variable = other.Variable);
				}
				if (Range == null)
				{
					stepAmountCase_ = (StepAmountOneofCase)(stepAmount_ = new Range());
				}
				Range range = Range;
				Range range2 = other.Range;
				range.MergeFrom(range2);
			}
			if (Value == null)
			{
				bool flag2 = (byte)(stepAmountCase_ = (((stepAmount_ = new ScalableValue()) != null) ? StepAmountOneofCase.Value : StepAmountOneofCase.None)) != 0;
			}
			ScalableValue value = Value;
			ScalableValue value2 = other.Value;
			value.MergeFrom(value2);
			goto IL_00da;
			IL_00da:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003C44")]
		[Cpp2IlInjected.Address(RVA = "0x2632B90", Offset = "0x2631590", VA = "0x182632B90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00f3: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (Variable = input.ReadString());
				}
				bool flag = default(bool);
				if (num == 80)
				{
					flag = (useCustomVariableName_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_00f3;
				}
				string text4 = (VariableName = input.ReadString());
			}
			bool flag2 = default(bool);
			if (num == 10)
			{
				ScalableValue scalableValue = new ScalableValue();
				if (stepAmountCase_ == StepAmountOneofCase.Value)
				{
					if (stepAmountCase_ != StepAmountOneofCase.Value)
					{
					}
					object obj = stepAmount_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(scalableValue);
				stepAmount_ = scalableValue;
				flag2 = (byte)(stepAmountCase_ = ((scalableValue != null) ? StepAmountOneofCase.Value : StepAmountOneofCase.None)) != 0;
			}
			if (flag2)
			{
				Range builder = new Range();
				if (stepAmountCase_ == StepAmountOneofCase.Range)
				{
					if (stepAmountCase_ != StepAmountOneofCase.Range)
					{
					}
					object obj2 = stepAmount_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				stepAmount_ = builder;
				stepAmountCase_ = (StepAmountOneofCase)typeof(Range).TypeHandle;
			}
			goto IL_00f3;
			IL_00f3:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003C45")]
		[Cpp2IlInjected.Address(RVA = "0x26323A0", Offset = "0x2630DA0", VA = "0x1826323A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						if (fieldNumber == 10)
						{
							bool flag = useCustomVariableName_;
						}
						if (fieldNumber != 11)
						{
							ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
							goto IL_007c;
						}
						string text = variableName_;
					}
					string variable = Variable;
				}
				while (stepAmountCase_ != StepAmountOneofCase.Range)
				{
				}
				object obj = stepAmount_;
				while (obj == null)
				{
				}
				if (obj == null)
				{
					goto IL_007c;
				}
			}
			while (stepAmountCase_ != StepAmountOneofCase.Value)
			{
			}
			object obj2 = stepAmount_;
			while (obj2 == null)
			{
			}
			while (obj2 != null)
			{
			}
			throw new InvalidCastException();
			IL_007c:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C46")]
		[Cpp2IlInjected.Address(RVA = "0x2632E60", Offset = "0x2631860", VA = "0x182632E60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001c: Expected I4, but got O
			//IL_004e: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					if (value == null || value != null)
					{
						return;
					}
					throw new InvalidCastException();
				case 0:
					if (value == null || value != null)
					{
						stepAmount_ = value;
						stepAmountCase_ = (StepAmountOneofCase)typeof(string).TypeHandle;
						return;
					}
					throw new InvalidCastException();
				}
				switch (fieldNumber)
				{
				case 10:
				{
					object obj = default(object);
					useCustomVariableName_ = (byte)(int)obj != 0;
					break;
				}
				case 11:
					if (value == null || value != null)
					{
						break;
					}
					throw new InvalidCastException();
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				stepAmount_ = value;
				bool flag = (byte)(stepAmountCase_ = ((value != null) ? StepAmountOneofCase.Value : StepAmountOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C47")]
		[Cpp2IlInjected.Address(RVA = "0x2631C60", Offset = "0x2630660", VA = "0x182631C60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0043: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				default:
					switch (fieldNumber)
					{
					case 10:
						useCustomVariableName_ = false;
						break;
					case 11:
						VariableName = "";
						break;
					}
					return;
				case 1:
					Variable = "";
					return;
				case 0:
					break;
				}
			}
			int num2 = 0;
			stepAmount_ = num2;
			stepAmountCase_ = (StepAmountOneofCase)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C48")]
		[Cpp2IlInjected.Address(RVA = "0x2632730", Offset = "0x2631130", VA = "0x182632730", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "StepAmount"))
			{
				StepAmountOneofCase stepAmountOneofCase = stepAmountCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C49")]
		[Cpp2IlInjected.Address(RVA = "0x2631D10", Offset = "0x2630710", VA = "0x182631D10", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "StepAmount"))
			{
				stepAmount_ = (stepAmountCase_ = StepAmountOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C4B")]
		[Cpp2IlInjected.Address(RVA = "0x2633660", Offset = "0x2632060", VA = "0x182633660")]
		public StepAmount(int value)
		{
			//Discarded unreachable code: IL_002f
			//IL_002e: Expected I4, but got I8
			stepAmount_ = new ScalableValue
			{
				value_ = value
			};
			stepAmountCase_ = StepAmountOneofCase.Value;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C4C")]
		[Cpp2IlInjected.Address(RVA = "0x2631DE0", Offset = "0x26307E0", VA = "0x182631DE0", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00a5
			StepAmountOneofCase stepAmountOneofCase = stepAmountCase_;
			if (stepAmountOneofCase == StepAmountOneofCase.None)
			{
				context.AddError("StepAmount cannot be None");
			}
			string b = default(string);
			if (stepAmountOneofCase == StepAmountOneofCase.Variable && string.Equals(Variable.ToLower(), b))
			{
				string variable = Variable;
				string error = "Variable: Deprecated value (\"" + variable + "\")";
				context.AddError(error);
			}
			if (useCustomVariableName_ && string.IsNullOrEmpty(variableName_))
			{
				string text = variableName_;
				string error2 = "VariableName is invalid: \"" + text + "\"";
				context.AddError(error2);
			}
			if (stepAmountCase_ == StepAmountOneofCase.Range && context.IsMission)
			{
				context.AddError("Range cannot be used in Mission");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C4D")]
		[Cpp2IlInjected.Address(RVA = "0x2632960", Offset = "0x2631360", VA = "0x182632960")]
		public bool IsZero()
		{
			//Discarded unreachable code: IL_0016
			if (stepAmountCase_ != StepAmountOneofCase.Value)
			{
				int num = 0;
			}
			bool result = default(bool);
			if (stepAmount_ != null)
			{
				return result;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C4E")]
		[Cpp2IlInjected.Address(RVA = "0x26327E0", Offset = "0x26311E0", VA = "0x1826327E0")]
		public bool IsValueEqualTo(int value)
		{
			//Discarded unreachable code: IL_0016
			if (stepAmountCase_ != StepAmountOneofCase.Value)
			{
				int num = 0;
			}
			bool result = default(bool);
			if (stepAmount_ != null)
			{
				return result;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C4F")]
		[Cpp2IlInjected.Address(RVA = "0x2632860", Offset = "0x2631260", VA = "0x182632860")]
		public bool IsValueGreaterThen(int value)
		{
			//Discarded unreachable code: IL_0016
			if (stepAmountCase_ != StepAmountOneofCase.Value)
			{
				int num = 0;
			}
			bool result = default(bool);
			if (stepAmount_ != null)
			{
				return result;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C50")]
		[Cpp2IlInjected.Address(RVA = "0x26328E0", Offset = "0x26312E0", VA = "0x1826328E0")]
		public bool IsValueSmallerThen(int value)
		{
			//Discarded unreachable code: IL_0016
			if (stepAmountCase_ != StepAmountOneofCase.Value)
			{
				int num = 0;
			}
			bool result = default(bool);
			if (stepAmount_ != null)
			{
				return result;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C51")]
		[Cpp2IlInjected.Address(RVA = "0x2632170", Offset = "0x2630B70", VA = "0x182632170")]
		public int GetAmount(Random random, int defaultValue, [Optional] Func<IScalableValue, int> scaleFunc, bool dontUseRandom = false)
		{
			//IL_005a: Expected I4, but got O
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected I4, but got Unknown
			if (scaleFunc == null && _003C_003Ec._003C_003E9__61_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				};
			}
			if (stepAmountCase_ == StepAmountOneofCase.Value && stepAmountCase_ == StepAmountOneofCase.Value)
			{
				object obj = stepAmount_;
				if (obj != null && obj == null)
				{
					int num = default(int);
					int num2 = num;
					throw new InvalidCastException();
				}
			}
			int num3 = default(int);
			if (num3 == 2)
			{
				ScalableValue min_ = Range.min_;
				int num2 = (int)scaleFunc((T)min_);
				ScalableValue max_ = Range.max_;
				int maxValue = scaleFunc((T)max_) + 1;
				int num = random.Next(num2, maxValue);
			}
			return defaultValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C52")]
		[Cpp2IlInjected.Address(RVA = "0x2633280", Offset = "0x2631C80", VA = "0x182633280")]
		static StepAmount()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
