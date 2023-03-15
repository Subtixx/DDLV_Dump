using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200054C")]
	public sealed class ExponentialScalingByLevel : IMessage<ExponentialScalingByLevel>, IMessage, IEquatable<ExponentialScalingByLevel>, IDeepCloneable<ExponentialScalingByLevel>, IMessageFieldAccessor, IScalingScript
	{
		[Cpp2IlInjected.Token(Token = "0x4001CC4")]
		private static readonly MessageParser<ExponentialScalingByLevel> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001CC5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001CC6")]
		public const int StartLevelFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CC7")]
		private int startLevel_;

		[Cpp2IlInjected.Token(Token = "0x4001CC8")]
		public const int EndLevelFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001CC9")]
		private int endLevel_;

		[Cpp2IlInjected.Token(Token = "0x4001CCA")]
		public const int StartScaleMultiplierFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001CCB")]
		private float startScaleMultiplier_;

		[Cpp2IlInjected.Token(Token = "0x4001CCC")]
		public const int EndScaleMultiplierFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001CCD")]
		private float endScaleMultiplier_;

		[Cpp2IlInjected.Token(Token = "0x4001CCE")]
		public const int ExponentFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001CCF")]
		private float exponent_;

		[Cpp2IlInjected.Token(Token = "0x17001110")]
		[DebuggerNonUserCode]
		public static MessageParser<ExponentialScalingByLevel> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004213")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2B00", Offset = "0x2CA1500", VA = "0x182CA2B00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001111")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004214")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2A30", Offset = "0x2CA1430", VA = "0x182CA2A30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001112")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004215")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2B60", Offset = "0x2CA1560", VA = "0x182CA2B60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001113")]
		[DebuggerNonUserCode]
		public int StartLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6004219")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return startLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x600421A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				startLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001114")]
		[DebuggerNonUserCode]
		public int EndLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600421B")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return endLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x600421C")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				endLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001115")]
		[DebuggerNonUserCode]
		public float StartScaleMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600421D")]
			[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
			get
			{
				return startScaleMultiplier_;
			}
			[Cpp2IlInjected.Token(Token = "0x600421E")]
			[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
			set
			{
				startScaleMultiplier_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001116")]
		[DebuggerNonUserCode]
		public float EndScaleMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600421F")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF70", Offset = "0xA7C970", VA = "0x180A7DF70")]
			get
			{
				return endScaleMultiplier_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004220")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF90", Offset = "0xA7C990", VA = "0x180A7DF90")]
			set
			{
				endScaleMultiplier_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001117")]
		[DebuggerNonUserCode]
		public float Exponent
		{
			[Cpp2IlInjected.Token(Token = "0x6004221")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get
			{
				return exponent_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004222")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
			set
			{
				exponent_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004216")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ExponentialScalingByLevel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004217")]
		[Cpp2IlInjected.Address(RVA = "0x1A54730", Offset = "0x1A53130", VA = "0x181A54730")]
		[DebuggerNonUserCode]
		public ExponentialScalingByLevel(ExponentialScalingByLevel other)
		{
			int num = (startLevel_ = other.startLevel_);
			int num2 = (endLevel_ = other.endLevel_);
			float num3 = (startScaleMultiplier_ = other.startScaleMultiplier_);
			float num4 = (endScaleMultiplier_ = other.endScaleMultiplier_);
			float num5 = (exponent_ = other.exponent_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004218")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1BE0", Offset = "0x2CA05E0", VA = "0x182CA1BE0", Slot = "10")]
		[DebuggerNonUserCode]
		public ExponentialScalingByLevel Clone()
		{
			//Discarded unreachable code: IL_0067
			ExponentialScalingByLevel exponentialScalingByLevel = new ExponentialScalingByLevel();
			int num = (exponentialScalingByLevel.startLevel_ = startLevel_);
			int num2 = (exponentialScalingByLevel.endLevel_ = endLevel_);
			float num3 = (exponentialScalingByLevel.startScaleMultiplier_ = startScaleMultiplier_);
			float num4 = (exponentialScalingByLevel.endScaleMultiplier_ = endScaleMultiplier_);
			float num5 = (exponentialScalingByLevel.exponent_ = exponent_);
			UnknownFieldSet unknownFieldSet = (exponentialScalingByLevel._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return exponentialScalingByLevel;
		}

		[Cpp2IlInjected.Token(Token = "0x6004223")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1E00", Offset = "0x2CA0800", VA = "0x182CA1E00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
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
				if ((IntPtr)startLevel_ == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle && (IntPtr)endLevel_ == (IntPtr)typeof(ProtobufEqualityComparers).TypeHandle && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004224")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1C80", Offset = "0x2CA0680", VA = "0x182CA1C80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ExponentialScalingByLevel other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.startLevel_;
				if (startLevel_ == num)
				{
					int num2 = other.endLevel_;
					if (endLevel_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004225")]
		[Cpp2IlInjected.Address(RVA = "0x2CA20E0", Offset = "0x2CA0AE0", VA = "0x182CA20E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0068
			//IL_0027: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			if (startLevel_ != 0)
			{
			}
			int num = endLevel_;
			int num2 = default(int);
			if (num != 0)
			{
				num2 = 0;
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = default(EqualityComparer<float>);
			if (num != 0)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField).GetHashCode((T)num2);
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField2 = default(EqualityComparer<float>);
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField != null)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField2 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode2 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField2).GetHashCode((T)num2);
			}
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField2 != null)
			{
				int hashCode3 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num2);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004226")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2790", Offset = "0x2CA1190", VA = "0x182CA2790", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004227")]
		[Cpp2IlInjected.Address(RVA = "0x2CA27F0", Offset = "0x2CA11F0", VA = "0x182CA27F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007c
			if (startLevel_ != 0)
			{
				int value = startLevel_;
				output.WriteInt32(value);
			}
			if (endLevel_ != 0)
			{
				int value2 = endLevel_;
				output.WriteInt32(value2);
			}
			if (output != null)
			{
				float value3 = startScaleMultiplier_;
				output.WriteFloat(value3);
			}
			if (output != null)
			{
				float value4 = endScaleMultiplier_;
				output.WriteFloat(value4);
			}
			if (output != null)
			{
				float value5 = exponent_;
				output.WriteFloat(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004228")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1AE0", Offset = "0x2CA04E0", VA = "0x182CA1AE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = startLevel_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = endLevel_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				num2 += 5;
				num2 += 5;
				num2 += 5;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004229")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2550", Offset = "0x2CA0F50", VA = "0x182CA2550", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ExponentialScalingByLevel other)
		{
			if (other != null)
			{
				int num = other.startLevel_;
				if (num != 0)
				{
					startLevel_ = num;
				}
				int num2 = other.endLevel_;
				if (num2 != 0)
				{
					endLevel_ = num2;
				}
				float num3 = other.startScaleMultiplier_;
				if (num2 != 0)
				{
					startScaleMultiplier_ = num3;
				}
				float num4 = other.endScaleMultiplier_;
				if (num2 != 0)
				{
					endScaleMultiplier_ = num4;
				}
				float num5 = other.exponent_;
				if (num2 != 0)
				{
					exponent_ = num5;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600422A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2470", Offset = "0x2CA0E70", VA = "0x182CA2470", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0093
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 29)
				{
					float num2 = (startScaleMultiplier_ = input.ReadFloat());
				}
				if (num == 37)
				{
					float num3 = (endScaleMultiplier_ = input.ReadFloat());
				}
				if (num != 45)
				{
					goto IL_007c;
				}
				float num4 = (exponent_ = input.ReadFloat());
			}
			int num5 = default(int);
			if (num == 8)
			{
				num5 = (startLevel_ = input.ReadInt32());
			}
			if (num5 == 16)
			{
				int num6 = (endLevel_ = input.ReadInt32());
			}
			goto IL_007c;
			IL_007c:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600422B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1FD0", Offset = "0x2CA09D0", VA = "0x182CA1FD0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num != 0)
			{
				if (num == 1)
				{
					float num2 = exponent_;
					return typeof(float).TypeHandle;
				}
			}
			else
			{
				int num3 = startLevel_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600422C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA25E0", Offset = "0x2CA0FE0", VA = "0x182CA25E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0042
			//IL_001f: Expected F4, but got O
			//IL_0027: Expected F4, but got O
			//IL_002f: Expected F4, but got O
			//IL_0038: Expected I4, but got O
			//IL_0041: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							object obj2 = default(object);
							exponent_ = (float)obj2;
							break;
						}
						case 0:
						{
							object obj = default(object);
							endScaleMultiplier_ = (float)obj;
							break;
						}
						}
					}
					else
					{
						object obj3 = default(object);
						startScaleMultiplier_ = (float)obj3;
					}
				}
				else
				{
					object obj4 = default(object);
					endLevel_ = (int)obj4;
				}
			}
			else
			{
				object obj5 = default(object);
				startLevel_ = (int)obj5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600422D")]
		[Cpp2IlInjected.Address(RVA = "0x1A53A70", Offset = "0x1A52470", VA = "0x181A53A70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_001c, IL_0028, IL_0032
			//IL_0031: Expected I4, but got I8
			//IL_003b: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				exponent_ = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600422E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2380", Offset = "0x2CA0D80", VA = "0x182CA2380", Slot = "14")]
		public float GetScale(float input)
		{
			//IL_0020: Expected F8, but got I4
			float result = endScaleMultiplier_;
			int num = startLevel_;
			int num2 = endLevel_;
			num2 -= num;
			double num3 = Math.Pow(0.0, input);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600422F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2920", Offset = "0x2CA1320", VA = "0x182CA2920")]
		static ExponentialScalingByLevel()
		{
			Func<ExponentialScalingByLevel> func = default(Func<ExponentialScalingByLevel>);
			_parser = (MessageParser<ExponentialScalingByLevel>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
