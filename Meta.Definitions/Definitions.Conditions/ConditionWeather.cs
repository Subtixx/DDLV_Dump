using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000827")]
	public sealed class ConditionWeather : ICondition, IMessage<ConditionWeather>, IMessage, IEquatable<ConditionWeather>, IDeepCloneable<ConditionWeather>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002885")]
		private static readonly MessageParser<ConditionWeather> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002886")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002887")]
		public const int WeatherFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002888")]
		private string weather_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002889")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400288A")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x1700171A")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005B51")]
			[Cpp2IlInjected.Address(RVA = "0x24CE810", Offset = "0x24CD210", VA = "0x1824CE810", Slot = "5")]
			get
			{
				if (!inversed_)
				{
				}
				string text = weather_;
				return "Weather " + "NOT " + " " + text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171B")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005B52")]
			[Cpp2IlInjected.Address(RVA = "0x24CE8A0", Offset = "0x24CD2A0", VA = "0x1824CE8A0", Slot = "6")]
			get
			{
				return ConditionListener.Weather;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171C")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionWeather> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005B54")]
			[Cpp2IlInjected.Address(RVA = "0x24CE8B0", Offset = "0x24CD2B0", VA = "0x1824CE8B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B55")]
			[Cpp2IlInjected.Address(RVA = "0x24CE740", Offset = "0x24CD140", VA = "0x1824CE740")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B56")]
			[Cpp2IlInjected.Address(RVA = "0x24CE910", Offset = "0x24CD310", VA = "0x1824CE910", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700171F")]
		[DebuggerNonUserCode]
		public string Weather
		{
			[Cpp2IlInjected.Token(Token = "0x6005B5A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return weather_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B5B")]
			[Cpp2IlInjected.Address(RVA = "0x24CEA20", Offset = "0x24CD420", VA = "0x1824CEA20")]
			set
			{
				string text = (weather_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001720")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005B5C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B5D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B50")]
		[Cpp2IlInjected.Address(RVA = "0x24CE050", Offset = "0x24CCA50", VA = "0x1824CE050")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_002e
			IProfileWorld section = worldProfile.Section;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string text = weather_;
			bool inversed = inversed_;
			bool condition = default(bool);
			return Operations.EvaluateInverse(condition, inversed);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B53")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B57")]
		[Cpp2IlInjected.Address(RVA = "0x24CE650", Offset = "0x24CD050", VA = "0x1824CE650")]
		[DebuggerNonUserCode]
		public ConditionWeather()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B58")]
		[Cpp2IlInjected.Address(RVA = "0x24CE6A0", Offset = "0x24CD0A0", VA = "0x1824CE6A0")]
		[DebuggerNonUserCode]
		public ConditionWeather(ConditionWeather other)
		{
			string text = (weather_ = other.weather_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B59")]
		[Cpp2IlInjected.Address(RVA = "0x24CDF80", Offset = "0x24CC980", VA = "0x1824CDF80", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionWeather Clone()
		{
			//Discarded unreachable code: IL_0042
			ConditionWeather conditionWeather = new ConditionWeather();
			conditionWeather.weather_ = "";
			string text = (conditionWeather.weather_ = weather_);
			bool flag = (conditionWeather.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionWeather._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionWeather;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B5E")]
		[Cpp2IlInjected.Address(RVA = "0x24CE140", Offset = "0x24CCB40", VA = "0x1824CE140", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = weather_;
				bool flag = default(bool);
				if (!flag && inversed_ == flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B5F")]
		[Cpp2IlInjected.Address(RVA = "0x17C5550", Offset = "0x17C3F50", VA = "0x1817C5550", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionWeather other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.weather_;
				if (!(weather_ != text))
				{
					bool flag = other.inversed_;
					if (inversed_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B60")]
		[Cpp2IlInjected.Address(RVA = "0x17C5740", Offset = "0x17C4140", VA = "0x1817C5740", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0038
			string text = weather_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (inversed_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B61")]
		[Cpp2IlInjected.Address(RVA = "0x24CE4E0", Offset = "0x24CCEE0", VA = "0x1824CE4E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B62")]
		[Cpp2IlInjected.Address(RVA = "0x17C5A50", Offset = "0x17C4450", VA = "0x1817C5A50", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0046
			if (weather_.m_stringLength != 0)
			{
				string value = weather_;
				output.WriteString(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B63")]
		[Cpp2IlInjected.Address(RVA = "0x24CDE30", Offset = "0x24CC830", VA = "0x1824CDE30", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0037
			string text = weather_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B64")]
		[Cpp2IlInjected.Address(RVA = "0x24CE2C0", Offset = "0x24CCCC0", VA = "0x1824CE2C0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionWeather other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				string text = other.weather_;
				if (text.m_stringLength != 0)
				{
					Weather = text;
				}
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B65")]
		[Cpp2IlInjected.Address(RVA = "0x24CE330", Offset = "0x24CCD30", VA = "0x1824CE330", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0049
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Weather = input.ReadString());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B66")]
		[Cpp2IlInjected.Address(RVA = "0x24CE1F0", Offset = "0x24CCBF0", VA = "0x1824CE1F0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = weather_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B67")]
		[Cpp2IlInjected.Address(RVA = "0x24CE3D0", Offset = "0x24CCDD0", VA = "0x1824CE3D0", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002e
			//IL_0019: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (weather_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				inversed_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B68")]
		[Cpp2IlInjected.Address(RVA = "0x24CDED0", Offset = "0x24CC8D0", VA = "0x1824CDED0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (weather_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			if (fieldNumber == 2)
			{
				inversed_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B69")]
		[Cpp2IlInjected.Address(RVA = "0x24CE540", Offset = "0x24CCF40", VA = "0x1824CE540")]
		static ConditionWeather()
		{
			Func<ConditionWeather> func = default(Func<ConditionWeather>);
			_parser = (MessageParser<ConditionWeather>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B6A")]
		[Cpp2IlInjected.Address(RVA = "0x24CE050", Offset = "0x24CCA50", VA = "0x1824CE050", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_002e
			IProfileWorld section = worldProfile.Section;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string text = weather_;
			bool inversed = inversed_;
			bool condition = default(bool);
			return Operations.EvaluateInverse(condition, inversed);
		}
	}
}
