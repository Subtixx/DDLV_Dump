using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public sealed class WeatherOverride : IMessage<WeatherOverride>, IMessage, IEquatable<WeatherOverride>, IDeepCloneable<WeatherOverride>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private static readonly MessageParser<WeatherOverride> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public const int ConditionsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public const int WeatherProfileAssetAddressFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private string weatherProfileAssetAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public const int LockTimeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private bool lockTime_;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public const int TimeFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private TimeInDay time_;

		[Cpp2IlInjected.Token(Token = "0x170002B7")]
		[DebuggerNonUserCode]
		public static MessageParser<WeatherOverride> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0x17C79E0", Offset = "0x17C63E0", VA = "0x1817C79E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0x17C7910", Offset = "0x17C6310", VA = "0x1817C7910")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0x17C7A40", Offset = "0x17C6440", VA = "0x1817C7A40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BA")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6000B48")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B49")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BB")]
		[DebuggerNonUserCode]
		public string WeatherProfileAssetAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return weatherProfileAssetAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0x17C7B50", Offset = "0x17C6550", VA = "0x1817C7B50")]
			set
			{
				string text = (weatherProfileAssetAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BC")]
		[DebuggerNonUserCode]
		public bool LockTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4C")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return lockTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4D")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				lockTime_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BD")]
		[DebuggerNonUserCode]
		public TimeInDay Time
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return time_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				time_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x17C76C0", Offset = "0x17C60C0", VA = "0x1817C76C0")]
		[DebuggerNonUserCode]
		public WeatherOverride()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			TimeInDay timeInDay = (time_ = new TimeInDay());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x17C7250", Offset = "0x17C5C50", VA = "0x1817C7250")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			TimeInDay timeInDay = (time_ = new TimeInDay());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x17C7790", Offset = "0x17C6190", VA = "0x1817C7790")]
		[DebuggerNonUserCode]
		public WeatherOverride(WeatherOverride other)
		{
			//IL_0047: Expected O, but got I4
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			TimeInDay timeInDay = (time_ = new TimeInDay());
			ConditionsList conditionsList2 = other.conditions_;
			int num = 0;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			conditions_ = (ConditionsList)num;
			string text = (weatherProfileAssetAddress_ = other.weatherProfileAssetAddress_);
			bool flag = (lockTime_ = other.lockTime_);
			TimeInDay timeInDay2 = other.time_;
			TimeInDay timeInDay3 = default(TimeInDay);
			if (timeInDay2 != null)
			{
				timeInDay3 = timeInDay2.Clone();
			}
			time_ = timeInDay3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x17C6AA0", Offset = "0x17C54A0", VA = "0x1817C6AA0", Slot = "10")]
		[DebuggerNonUserCode]
		public WeatherOverride Clone()
		{
			//Discarded unreachable code: IL_009e
			//IL_0049: Expected O, but got I4
			WeatherOverride weatherOverride = new WeatherOverride();
			weatherOverride.weatherProfileAssetAddress_ = "";
			ConditionsList conditionsList = (weatherOverride.conditions_ = new ConditionsList());
			TimeInDay timeInDay = (weatherOverride.time_ = new TimeInDay());
			ConditionsList conditionsList2 = conditions_;
			int num = 0;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			weatherOverride.conditions_ = (ConditionsList)num;
			string text = (weatherOverride.weatherProfileAssetAddress_ = weatherProfileAssetAddress_);
			bool flag = (weatherOverride.lockTime_ = lockTime_);
			TimeInDay timeInDay2 = time_;
			TimeInDay timeInDay3 = default(TimeInDay);
			if (timeInDay2 != null)
			{
				timeInDay3 = timeInDay2.Clone();
			}
			weatherOverride.time_ = timeInDay3;
			UnknownFieldSet unknownFieldSet = (weatherOverride._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return weatherOverride;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x17C6CF0", Offset = "0x17C56F0", VA = "0x1817C6CF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(conditions_, other))
				{
					string text = weatherProfileAssetAddress_;
					bool flag = default(bool);
					if (!flag && lockTime_ == flag && object.Equals(time_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x17C6C50", Offset = "0x17C5650", VA = "0x1817C6C50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WeatherOverride other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ConditionsList objB = other.conditions_;
				if (object.Equals(conditions_, objB))
				{
					string text = other.weatherProfileAssetAddress_;
					if (!(weatherProfileAssetAddress_ != text))
					{
						bool flag = other.lockTime_;
						if (lockTime_ == flag)
						{
							TimeInDay objB2 = other.time_;
							if (object.Equals(time_, objB2))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x17C6EC0", Offset = "0x17C58C0", VA = "0x1817C6EC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0061
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int hashCode = conditionsList.GetHashCode();
			}
			string text = weatherProfileAssetAddress_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			if (lockTime_)
			{
			}
			TimeInDay timeInDay = time_;
			if (timeInDay != null)
			{
				int hashCode3 = timeInDay.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x17C7460", Offset = "0x17C5E60", VA = "0x1817C7460", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x17C74C0", Offset = "0x17C5EC0", VA = "0x1817C74C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007b
			if ((long)conditions_ != 0)
			{
				ConditionsList value = conditions_;
				output.WriteMessage(value);
			}
			if (weatherProfileAssetAddress_.m_stringLength != 0)
			{
				string value2 = weatherProfileAssetAddress_;
				output.WriteString(value2);
			}
			if (lockTime_)
			{
				bool value3 = lockTime_;
				output.WriteBool(value3);
			}
			if ((long)time_ != 0)
			{
				TimeInDay value4 = time_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x17C6900", Offset = "0x17C5300", VA = "0x1817C6900", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0075
			ConditionsList conditionsList = conditions_;
			int num = 0;
			if (conditionsList != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(conditionsList);
			}
			string text = weatherProfileAssetAddress_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			TimeInDay timeInDay = time_;
			if (timeInDay != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(timeInDay);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x17C7100", Offset = "0x17C5B00", VA = "0x1817C7100", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WeatherOverride other)
		{
			//Discarded unreachable code: IL_00ca
			if (other == null)
			{
				return;
			}
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList = conditions_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (conditions_ = new ConditionsList());
					ConditionsList conditionsList3 = conditions_;
				}
				ConditionsList other2 = other.conditions_;
				conditionsList.MergeFrom(other2);
			}
			string text = other.weatherProfileAssetAddress_;
			if (text.m_stringLength != 0)
			{
				WeatherProfileAssetAddress = text;
			}
			bool flag = other.lockTime_;
			if (flag)
			{
				lockTime_ = flag;
			}
			if ((long)other.time_ != 0)
			{
				TimeInDay timeInDay2 = default(TimeInDay);
				if (time_ == null)
				{
					TimeInDay timeInDay = (time_ = new TimeInDay());
					timeInDay2 = time_;
				}
				TimeInDay other3 = other.time_;
				timeInDay2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x17C6F80", Offset = "0x17C5980", VA = "0x1817C6F80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b0
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					bool flag = (lockTime_ = input.ReadBool());
				}
				if (num != 34)
				{
					goto IL_0099;
				}
				TimeInDay builder = default(TimeInDay);
				if (time_ == null)
				{
					TimeInDay timeInDay = (time_ = new TimeInDay());
					builder = time_;
				}
				input.ReadMessage(builder);
			}
			ConditionsList conditionsList = default(ConditionsList);
			if (num == 10)
			{
				ConditionsList builder2 = default(ConditionsList);
				if (conditions_ == null)
				{
					conditionsList = (conditions_ = new ConditionsList());
					builder2 = conditions_;
				}
				input.ReadMessage(builder2);
			}
			if ((long)conditionsList == 18)
			{
				string text2 = (WeatherProfileAssetAddress = input.ReadString());
			}
			goto IL_0099;
			IL_0099:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x17C6DD0", Offset = "0x17C57D0", VA = "0x1817C6DD0", Slot = "11")]
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
						TimeInDay timeInDay = time_;
					}
					bool flag = lockTime_;
				}
				string text = weatherProfileAssetAddress_;
			}
			ConditionsList conditionsList = conditions_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x17C72E0", Offset = "0x17C5CE0", VA = "0x1817C72E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0025: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							time_ = (TimeInDay)num2;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
					{
						object obj = default(object);
						lockTime_ = (byte)(int)obj != 0;
						break;
					}
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				return;
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x17C6A10", Offset = "0x17C5410", VA = "0x1817C6A10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0)
			{
				return;
			}
			if (num != 0)
			{
				if (num == 0 || num == 1)
				{
					lockTime_ = false;
				}
			}
			else
			{
				WeatherProfileAssetAddress = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x17C75B0", Offset = "0x17C5FB0", VA = "0x1817C75B0")]
		static WeatherOverride()
		{
			Func<WeatherOverride> func = default(Func<WeatherOverride>);
			_parser = (MessageParser<WeatherOverride>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
