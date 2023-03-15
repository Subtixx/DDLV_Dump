using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Keyholes
{
	[Cpp2IlInjected.Token(Token = "0x2000274")]
	public sealed class KeyholeConfig : IMessage<KeyholeConfig>, IMessage, IEquatable<KeyholeConfig>, IDeepCloneable<KeyholeConfig>, IMessageFieldAccessor, IProtobufCloneDefaultValue, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000275")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000276")]
			public sealed class FilterItem : IMessage<FilterItem>, IMessage, IEquatable<FilterItem>, IDeepCloneable<FilterItem>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40009C3")]
				private static readonly MessageParser<FilterItem> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40009C4")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40009C5")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40009C6")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x17000533")]
				[DebuggerNonUserCode]
				public static MessageParser<FilterItem> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001782")]
					[Cpp2IlInjected.Address(RVA = "0x2FEEF70", Offset = "0x2FED970", VA = "0x182FEEF70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000534")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001783")]
					[Cpp2IlInjected.Address(RVA = "0x2FEEEF0", Offset = "0x2FED8F0", VA = "0x182FEEEF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000535")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001784")]
					[Cpp2IlInjected.Address(RVA = "0x2FEEFD0", Offset = "0x2FED9D0", VA = "0x182FEEFD0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000536")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6001788")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001789")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001785")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public FilterItem()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001786")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
				[DebuggerNonUserCode]
				public FilterItem(FilterItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001787")]
				[Cpp2IlInjected.Address(RVA = "0x2FEEB40", Offset = "0x2FED540", VA = "0x182FEEB40", Slot = "10")]
				[DebuggerNonUserCode]
				public FilterItem Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600178A")]
				[Cpp2IlInjected.Address(RVA = "0x2FEEBC0", Offset = "0x2FED5C0", VA = "0x182FEEBC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600178B")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FilterItem other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600178C")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600178D")]
				[Cpp2IlInjected.Address(RVA = "0x2FEED80", Offset = "0x2FED780", VA = "0x182FEED80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600178E")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600178F")]
				[Cpp2IlInjected.Address(RVA = "0x2FEEAA0", Offset = "0x2FED4A0", VA = "0x182FEEAA0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001790")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FilterItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001791")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001792")]
				[Cpp2IlInjected.Address(RVA = "0x2FEEC50", Offset = "0x2FED650", VA = "0x182FEEC50", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001793")]
				[Cpp2IlInjected.Address(RVA = "0x2FEED00", Offset = "0x2FED700", VA = "0x182FEED00", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001794")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40009B6")]
		private static readonly MessageParser<KeyholeConfig> _parser = (MessageParser<KeyholeConfig>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new KeyholeConfig()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009B7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40009B8")]
		public const int GUIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009B9")]
		private string gUID_ = "";

		[Cpp2IlInjected.Token(Token = "0x40009BA")]
		public const int MenuTitleLocIDOverrideFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009BB")]
		private string menuTitleLocIDOverride_ = "";

		[Cpp2IlInjected.Token(Token = "0x40009BC")]
		public const int SizeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40009BD")]
		private int size_;

		[Cpp2IlInjected.Token(Token = "0x40009BE")]
		public const int ActiveWhenFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40009BF")]
		private ConditionsList activeWhen_;

		[Cpp2IlInjected.Token(Token = "0x40009C0")]
		public const int LevelsFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40009C1")]
		private static readonly FieldCodec<CompletionLevel> _repeated_levels_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40009C2")]
		private readonly RepeatedField<CompletionLevel> levels_ = (RepeatedField<CompletionLevel>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700052B")]
		[DebuggerNonUserCode]
		public static MessageParser<KeyholeConfig> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001762")]
			[Cpp2IlInjected.Address(RVA = "0x273A860", Offset = "0x2739260", VA = "0x18273A860")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001763")]
			[Cpp2IlInjected.Address(RVA = "0x273A790", Offset = "0x2739190", VA = "0x18273A790")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001764")]
			[Cpp2IlInjected.Address(RVA = "0x273A8C0", Offset = "0x27392C0", VA = "0x18273A8C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052E")]
		[DebuggerNonUserCode]
		public string GUID
		{
			[Cpp2IlInjected.Token(Token = "0x6001769")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return gUID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600176A")]
			[Cpp2IlInjected.Address(RVA = "0x273A9D0", Offset = "0x27393D0", VA = "0x18273A9D0")]
			set
			{
				string text = (gUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052F")]
		[DebuggerNonUserCode]
		public string MenuTitleLocIDOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600176B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return menuTitleLocIDOverride_;
			}
			[Cpp2IlInjected.Token(Token = "0x600176C")]
			[Cpp2IlInjected.Address(RVA = "0x273AA40", Offset = "0x2739440", VA = "0x18273AA40")]
			set
			{
				string text = (menuTitleLocIDOverride_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000530")]
		[DebuggerNonUserCode]
		public int Size
		{
			[Cpp2IlInjected.Token(Token = "0x600176D")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return size_;
			}
			[Cpp2IlInjected.Token(Token = "0x600176E")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				size_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000531")]
		[DebuggerNonUserCode]
		public ConditionsList ActiveWhen
		{
			[Cpp2IlInjected.Token(Token = "0x600176F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return activeWhen_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001770")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				activeWhen_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000532")]
		[DebuggerNonUserCode]
		public RepeatedField<CompletionLevel> Levels
		{
			[Cpp2IlInjected.Token(Token = "0x6001771")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return levels_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001765")]
		[Cpp2IlInjected.Address(RVA = "0x273A380", Offset = "0x2738D80", VA = "0x18273A380")]
		[DebuggerNonUserCode]
		public KeyholeConfig()
		{
			Guid guid = Guid.NewGuid();
			string value = default(string);
			string text = (gUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
			ConditionsList conditionsList = (activeWhen_ = new ConditionsList());
		}

		[Cpp2IlInjected.Token(Token = "0x6001766")]
		[Cpp2IlInjected.Address(RVA = "0x2739C30", Offset = "0x2738630", VA = "0x182739C30")]
		private void OnConstruction()
		{
			Guid guid = Guid.NewGuid();
			string value = default(string);
			string text = (gUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
			ConditionsList conditionsList = (activeWhen_ = new ConditionsList());
		}

		[Cpp2IlInjected.Token(Token = "0x6001767")]
		[Cpp2IlInjected.Address(RVA = "0x273A520", Offset = "0x2738F20", VA = "0x18273A520")]
		[DebuggerNonUserCode]
		public KeyholeConfig(KeyholeConfig other)
		{
			//IL_00a2: Expected O, but got I4
			Guid guid = Guid.NewGuid();
			string value = default(string);
			string text = (gUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
			ConditionsList conditionsList = (activeWhen_ = new ConditionsList());
			string text2 = (gUID_ = other.gUID_);
			string text3 = (menuTitleLocIDOverride_ = other.menuTitleLocIDOverride_);
			int num = (size_ = other.size_);
			ConditionsList conditionsList2 = other.activeWhen_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num2 = 0;
			activeWhen_ = (ConditionsList)num2;
			RepeatedField<CompletionLevel> repeatedField = (levels_ = (RepeatedField<CompletionLevel>)(object)((RepeatedField<T>)(object)other.levels_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001768")]
		[Cpp2IlInjected.Address(RVA = "0x2739070", Offset = "0x2737A70", VA = "0x182739070", Slot = "10")]
		[DebuggerNonUserCode]
		public KeyholeConfig Clone()
		{
			return new KeyholeConfig(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001772")]
		[Cpp2IlInjected.Address(RVA = "0x27393A0", Offset = "0x2737DA0", VA = "0x1827393A0", Slot = "0")]
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
				string text = gUID_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = menuTitleLocIDOverride_;
					bool flag2 = default(bool);
					if (!flag2 && size_ == (flag2 ? 1 : 0) && object.Equals(activeWhen_, other))
					{
						RepeatedField<CompletionLevel> repeatedField = levels_;
						bool flag3 = default(bool);
						if (flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001773")]
		[Cpp2IlInjected.Address(RVA = "0x27392C0", Offset = "0x2737CC0", VA = "0x1827392C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(KeyholeConfig other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.gUID_;
				if (!(gUID_ != text))
				{
					string text2 = other.menuTitleLocIDOverride_;
					if (!(menuTitleLocIDOverride_ != text2))
					{
						int num = other.size_;
						if (size_ == num)
						{
							ConditionsList objB = other.activeWhen_;
							if (object.Equals(activeWhen_, objB))
							{
								RepeatedField<CompletionLevel> repeatedField = levels_;
								RepeatedField<CompletionLevel> repeatedField2 = other.levels_;
								if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001774")]
		[Cpp2IlInjected.Address(RVA = "0x27395C0", Offset = "0x2737FC0", VA = "0x1827395C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0073
			string text = gUID_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = menuTitleLocIDOverride_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			if (size_ != 0)
			{
			}
			ConditionsList conditionsList = activeWhen_;
			if (conditionsList != null)
			{
				int hashCode3 = conditionsList.GetHashCode();
			}
			int hashCode4 = ((RepeatedField<T>)(object)levels_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001775")]
		[Cpp2IlInjected.Address(RVA = "0x2739FD0", Offset = "0x27389D0", VA = "0x182739FD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001776")]
		[Cpp2IlInjected.Address(RVA = "0x273A030", Offset = "0x2738A30", VA = "0x18273A030", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0097
			if (gUID_.m_stringLength != 0)
			{
				string value = gUID_;
				output.WriteString(value);
			}
			if (size_ != 0)
			{
				int value2 = size_;
				output.WriteInt32(value2);
			}
			if ((long)activeWhen_ != 0)
			{
				ConditionsList value3 = activeWhen_;
				output.WriteMessage(value3);
			}
			RepeatedField<CompletionLevel> repeatedField = levels_;
			FieldCodec<CompletionLevel> repeated_levels_codec = _repeated_levels_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_levels_codec);
			if (menuTitleLocIDOverride_.m_stringLength != 0)
			{
				string value4 = menuTitleLocIDOverride_;
				output.WriteString(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001777")]
		[Cpp2IlInjected.Address(RVA = "0x2738DD0", Offset = "0x27377D0", VA = "0x182738DD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00ba
			string text = gUID_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = menuTitleLocIDOverride_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			int num4 = size_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			ConditionsList conditionsList = activeWhen_;
			if (conditionsList != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num6++;
				num += num6;
			}
			RepeatedField<CompletionLevel> repeatedField = levels_;
			FieldCodec<CompletionLevel> repeated_levels_codec = _repeated_levels_codec;
			int num7 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_levels_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num7;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001778")]
		[Cpp2IlInjected.Address(RVA = "0x2739930", Offset = "0x2738330", VA = "0x182739930", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(KeyholeConfig other)
		{
			//Discarded unreachable code: IL_00ba
			if (other == null)
			{
				return;
			}
			string text = other.gUID_;
			if (text.m_stringLength != 0)
			{
				GUID = text;
			}
			string text2 = other.menuTitleLocIDOverride_;
			if (text2.m_stringLength != 0)
			{
				MenuTitleLocIDOverride = text2;
			}
			int num = other.size_;
			if (num != 0)
			{
				size_ = num;
			}
			if ((long)other.activeWhen_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (activeWhen_ == null)
				{
					ConditionsList conditionsList = (activeWhen_ = new ConditionsList());
					conditionsList2 = activeWhen_;
				}
				ConditionsList other2 = other.activeWhen_;
				conditionsList2.MergeFrom(other2);
			}
			RepeatedField<CompletionLevel> repeatedField = levels_;
			RepeatedField<CompletionLevel> repeatedField2 = other.levels_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001779")]
		[Cpp2IlInjected.Address(RVA = "0x2739A70", Offset = "0x2738470", VA = "0x182739A70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b2
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					ConditionsList conditionsList = activeWhen_;
					if (conditionsList == null)
					{
						ConditionsList conditionsList2 = (activeWhen_ = new ConditionsList());
					}
					input.ReadMessage(conditionsList);
				}
				if (num == 34)
				{
					RepeatedField<CompletionLevel> repeatedField = levels_;
					FieldCodec<CompletionLevel> repeated_levels_codec = _repeated_levels_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_levels_codec);
				}
				if (num != 42)
				{
					goto IL_009b;
				}
				string text2 = (MenuTitleLocIDOverride = input.ReadString());
			}
			string text4 = default(string);
			if (num == 10)
			{
				text4 = (GUID = input.ReadString());
			}
			if ((long)text4 == 16)
			{
				int num2 = (size_ = input.ReadInt32());
			}
			goto IL_009b;
			IL_009b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600177A")]
		[Cpp2IlInjected.Address(RVA = "0x27394C0", Offset = "0x2737EC0", VA = "0x1827394C0", Slot = "11")]
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
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_003d;
							}
							string text = menuTitleLocIDOverride_;
						}
						RepeatedField<CompletionLevel> repeatedField = levels_;
					}
					ConditionsList conditionsList = activeWhen_;
				}
				int num2 = size_;
			}
			string text2 = gUID_;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600177B")]
		[Cpp2IlInjected.Address(RVA = "0x2739E00", Offset = "0x2738800", VA = "0x182739E00", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0029: Expected O, but got I4
			//IL_0040: Expected I4, but got O
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
							int num2 = 0;
							if (value == null || value != null)
							{
								MenuTitleLocIDOverride = (string)num2;
								return;
							}
							break;
						}
						default:
							return;
						case 0:
							break;
						}
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					}
					else if (value == null || value != null)
					{
						activeWhen_ = (ConditionsList)value;
						goto IL_0039;
					}
					throw new InvalidCastException();
				}
				goto IL_0039;
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
			IL_0039:
			object obj = default(object);
			size_ = (int)obj;
		}

		[Cpp2IlInjected.Token(Token = "0x600177C")]
		[Cpp2IlInjected.Address(RVA = "0x2738F80", Offset = "0x2737980", VA = "0x182738F80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0041
			//IL_0034: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0)
				{
					switch (num)
					{
					case 1:
						MenuTitleLocIDOverride = "";
						return;
					case 0:
						break;
					default:
						return;
					}
					RepeatedField<CompletionLevel> repeatedField = levels_;
				}
				size_ = 0;
			}
			else
			{
				GUID = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600177D")]
		[Cpp2IlInjected.Address(RVA = "0x2739D30", Offset = "0x2738730", VA = "0x182739D30", Slot = "14")]
		public void SetCloneDefaultData()
		{
			Guid guid = Guid.NewGuid();
			string value = default(string);
			string text = (gUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
		}

		[Cpp2IlInjected.Token(Token = "0x600177E")]
		[Cpp2IlInjected.Address(RVA = "0x2739870", Offset = "0x2738270", VA = "0x182739870")]
		public static IEnumerable<KeyholeConfig> GetKeyholeConfigs()
		{
			//Discarded unreachable code: IL_000b
			return (IEnumerable<KeyholeConfig>)ProtoDatabase.Instance.Enumerate<KeyholeConfig>();
		}

		[Cpp2IlInjected.Token(Token = "0x600177F")]
		[Cpp2IlInjected.Address(RVA = "0x27396B0", Offset = "0x27380B0", VA = "0x1827396B0")]
		public static KeyholeConfig GetKeyholeConfig(string guid)
		{
			//Discarded unreachable code: IL_002d
			IEnumerable<> enumerable = ProtoDatabase.Instance.Enumerate<KeyholeConfig>();
			Func<KeyholeConfig, bool> func = (Func<KeyholeConfig, bool>)(object)(Func<T, TResult>)delegate(KeyholeConfig x)
			{
				//Discarded unreachable code: IL_0014
				string b = guid;
				return string.Equals(x.gUID_, b);
			};
			return Enumerable.FirstOrDefault<KeyholeConfig>(enumerable, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6001780")]
		[Cpp2IlInjected.Address(RVA = "0x27390D0", Offset = "0x2737AD0", VA = "0x1827390D0", Slot = "15")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0069
			if (((RepeatedField<T>)(object)levels_).Count != 0)
			{
				int num = size_;
				RepeatedField<CompletionLevel> repeatedField = levels_;
				Func<CompletionLevel, int> _003C_003E9__52_ = _003C_003Ec._003C_003E9__52_0;
				if (_003C_003E9__52_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CompletionLevel x) => ((RepeatedField<T>)(object)x.neededItems_).Count);
				}
				int num2 = Enumerable.Max<CompletionLevel>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__52_);
				if (num != num2)
				{
					context.AddInvalidMemberError("NeededItems.Count must match Keyhole size", "Size");
				}
			}
			else
			{
				context.AddInvalidMemberError("Cannot be empty", "Levels");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001781")]
		[Cpp2IlInjected.Address(RVA = "0x273A1B0", Offset = "0x2738BB0", VA = "0x18273A1B0")]
		static KeyholeConfig()
		{
			MessageParser<CompletionLevel> parser = CompletionLevel._parser;
			uint num = default(uint);
			_parser = (MessageParser<KeyholeConfig>)(object)FieldCodec.ForMessage<CompletionLevel>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
