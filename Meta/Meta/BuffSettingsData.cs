using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008CB")]
	public sealed class BuffSettingsData : IMessage<BuffSettingsData>, IMessage, IEquatable<BuffSettingsData>, IDeepCloneable<BuffSettingsData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20008CC")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20008CD")]
			public sealed class BuffGardenData : IMessage<BuffGardenData>, IMessage, IEquatable<BuffGardenData>, IDeepCloneable<BuffGardenData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400238B")]
				private static readonly MessageParser<BuffGardenData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400238C")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400238D")]
				public const int BuffFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400238E")]
				private BuffType buff_;

				[Cpp2IlInjected.Token(Token = "0x400238F")]
				public const int GardensFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4002390")]
				private static readonly FieldCodec<int> _repeated_gardens_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002391")]
				private readonly RepeatedField<int> gardens_;

				[Cpp2IlInjected.Token(Token = "0x17000CBD")]
				[DebuggerNonUserCode]
				public static MessageParser<BuffGardenData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004B6B")]
					[Cpp2IlInjected.Address(RVA = "0x27220C0", Offset = "0x2720AC0", VA = "0x1827220C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CBE")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004B6C")]
					[Cpp2IlInjected.Address(RVA = "0x2722040", Offset = "0x2720A40", VA = "0x182722040")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CBF")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004B6D")]
					[Cpp2IlInjected.Address(RVA = "0x2722120", Offset = "0x2720B20", VA = "0x182722120", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CC0")]
				[DebuggerNonUserCode]
				public BuffType Buff
				{
					[Cpp2IlInjected.Token(Token = "0x6004B71")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(BuffType);
					}
					[Cpp2IlInjected.Token(Token = "0x6004B72")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CC1")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Gardens
				{
					[Cpp2IlInjected.Token(Token = "0x6004B73")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004B6E")]
				[Cpp2IlInjected.Address(RVA = "0x2721EC0", Offset = "0x27208C0", VA = "0x182721EC0")]
				[DebuggerNonUserCode]
				public BuffGardenData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B6F")]
				[Cpp2IlInjected.Address(RVA = "0x2721F40", Offset = "0x2720940", VA = "0x182721F40")]
				[DebuggerNonUserCode]
				public BuffGardenData(BuffGardenData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B70")]
				[Cpp2IlInjected.Address(RVA = "0x2721640", Offset = "0x2720040", VA = "0x182721640", Slot = "10")]
				[DebuggerNonUserCode]
				public BuffGardenData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004B74")]
				[Cpp2IlInjected.Address(RVA = "0x2721770", Offset = "0x2720170", VA = "0x182721770", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004B75")]
				[Cpp2IlInjected.Address(RVA = "0x2721850", Offset = "0x2720250", VA = "0x182721850", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(BuffGardenData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004B76")]
				[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004B77")]
				[Cpp2IlInjected.Address(RVA = "0x2721C30", Offset = "0x2720630", VA = "0x182721C30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004B78")]
				[Cpp2IlInjected.Address(RVA = "0x2721C90", Offset = "0x2720690", VA = "0x182721C90", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B79")]
				[Cpp2IlInjected.Address(RVA = "0x27214E0", Offset = "0x271FEE0", VA = "0x1827214E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004B7A")]
				[Cpp2IlInjected.Address(RVA = "0x2721AD0", Offset = "0x27204D0", VA = "0x182721AD0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(BuffGardenData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B7B")]
				[Cpp2IlInjected.Address(RVA = "0x27219C0", Offset = "0x27203C0", VA = "0x1827219C0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B7C")]
				[Cpp2IlInjected.Address(RVA = "0x27218F0", Offset = "0x27202F0", VA = "0x1827218F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004B7D")]
				[Cpp2IlInjected.Address(RVA = "0x2721B60", Offset = "0x2720560", VA = "0x182721B60", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004B7E")]
				[Cpp2IlInjected.Address(RVA = "0x27215D0", Offset = "0x271FFD0", VA = "0x1827215D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002386")]
		private static readonly MessageParser<BuffSettingsData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002387")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002388")]
		public const int BuffToGardenSettingsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002389")]
		private static readonly FieldCodec<Types.BuffGardenData> _repeated_buffToGardenSettings_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400238A")]
		private readonly RepeatedField<Types.BuffGardenData> buffToGardenSettings_ = (RepeatedField<Types.BuffGardenData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000CB9")]
		[DebuggerNonUserCode]
		public static MessageParser<BuffSettingsData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004B57")]
			[Cpp2IlInjected.Address(RVA = "0x1AC2960", Offset = "0x1AC1360", VA = "0x181AC2960")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CBA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004B58")]
			[Cpp2IlInjected.Address(RVA = "0x1AC2890", Offset = "0x1AC1290", VA = "0x181AC2890")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CBB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004B59")]
			[Cpp2IlInjected.Address(RVA = "0x1AC29C0", Offset = "0x1AC13C0", VA = "0x181AC29C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CBC")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.BuffGardenData> BuffToGardenSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6004B5D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return buffToGardenSettings_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B5A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2710", Offset = "0x1AC1110", VA = "0x181AC2710")]
		[DebuggerNonUserCode]
		public BuffSettingsData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004B5B")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2790", Offset = "0x1AC1190", VA = "0x181AC2790")]
		[DebuggerNonUserCode]
		public BuffSettingsData(BuffSettingsData other)
		{
			RepeatedField<Types.BuffGardenData> repeatedField = (buffToGardenSettings_ = (RepeatedField<Types.BuffGardenData>)(object)((RepeatedField<T>)(object)other.buffToGardenSettings_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B5C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1D60", Offset = "0x1AC0760", VA = "0x181AC1D60", Slot = "10")]
		[DebuggerNonUserCode]
		public BuffSettingsData Clone()
		{
			//Discarded unreachable code: IL_003b
			BuffSettingsData buffSettingsData = new BuffSettingsData();
			RepeatedField<Types.BuffGardenData> repeatedField = (buffSettingsData.buffToGardenSettings_ = (RepeatedField<Types.BuffGardenData>)(object)new RepeatedField<T>());
			RepeatedField<Types.BuffGardenData> repeatedField2 = (buffSettingsData.buffToGardenSettings_ = (RepeatedField<Types.BuffGardenData>)(object)((RepeatedField<T>)(object)buffToGardenSettings_).Clone());
			UnknownFieldSet unknownFieldSet = (buffSettingsData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return buffSettingsData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B5E")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1F20", Offset = "0x1AC0920", VA = "0x181AC1F20", Slot = "0")]
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
				RepeatedField<Types.BuffGardenData> repeatedField = buffToGardenSettings_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B5F")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1E90", Offset = "0x1AC0890", VA = "0x181AC1E90", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuffSettingsData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.BuffGardenData> repeatedField = buffToGardenSettings_;
				RepeatedField<Types.BuffGardenData> repeatedField2 = other.buffToGardenSettings_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B60")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)buffToGardenSettings_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B61")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2250", Offset = "0x1AC0C50", VA = "0x181AC2250", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B62")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2480", Offset = "0x1AC0E80", VA = "0x181AC2480", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Types.BuffGardenData> repeatedField = buffToGardenSettings_;
			FieldCodec<Types.BuffGardenData> repeated_buffToGardenSettings_codec = _repeated_buffToGardenSettings_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_buffToGardenSettings_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004B63")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1C50", Offset = "0x1AC0650", VA = "0x181AC1C50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Types.BuffGardenData> repeatedField = buffToGardenSettings_;
			FieldCodec<Types.BuffGardenData> repeated_buffToGardenSettings_codec = _repeated_buffToGardenSettings_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_buffToGardenSettings_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B64")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2170", Offset = "0x1AC0B70", VA = "0x181AC2170", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuffSettingsData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Types.BuffGardenData> repeatedField = buffToGardenSettings_;
				RepeatedField<Types.BuffGardenData> repeatedField2 = other.buffToGardenSettings_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B65")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2080", Offset = "0x1AC0A80", VA = "0x181AC2080", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.BuffGardenData> repeatedField = buffToGardenSettings_;
					FieldCodec<Types.BuffGardenData> repeated_buffToGardenSettings_codec = _repeated_buffToGardenSettings_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_buffToGardenSettings_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B66")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2000", Offset = "0x1AC0A00", VA = "0x181AC2000", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.BuffGardenData> repeatedField = buffToGardenSettings_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B67")]
		[Cpp2IlInjected.Address(RVA = "0x1AC21F0", Offset = "0x1AC0BF0", VA = "0x181AC21F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004B68")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1D00", Offset = "0x1AC0700", VA = "0x181AC1D00", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Types.BuffGardenData> repeatedField = buffToGardenSettings_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004B69")]
		[Cpp2IlInjected.Address(RVA = "0x1AC22B0", Offset = "0x1AC0CB0", VA = "0x181AC22B0")]
		public bool TryGetBuffForGarden(Item gardenItem, out BuffType associatedBuff)
		{
			//Discarded unreachable code: IL_0036, IL_003c, IL_0042
			int itemID = gardenItem.ItemID;
			int num = 0;
			int num2 = 0;
			RepeatedField<Types.BuffGardenData> repeatedField = buffToGardenSettings_;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				associatedBuff.value__ = (flag2 ? 1 : 0);
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004B6A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC2540", Offset = "0x1AC0F40", VA = "0x181AC2540")]
		static BuffSettingsData()
		{
			Func<BuffSettingsData> func = default(Func<BuffSettingsData>);
			_parser = (MessageParser<BuffSettingsData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.BuffGardenData> parser = Types.BuffGardenData._parser;
			uint num = default(uint);
			_parser = (MessageParser<BuffSettingsData>)(object)FieldCodec.ForMessage<Types.BuffGardenData>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
