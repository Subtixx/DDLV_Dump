using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B45")]
	public sealed class Statistic : IMessage<Statistic>, IMessage, IEquatable<Statistic>, IDeepCloneable<Statistic>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002BB8")]
		private static readonly MessageParser<Statistic> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BB9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002BBA")]
		public const int ChildStatisticsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002BBB")]
		private static readonly MapField<string, StatisticChildValue>.Codec _map_childStatistics_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BBC")]
		private readonly MapField<string, StatisticChildValue> childStatistics_ = (MapField<string, StatisticChildValue>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4002BBD")]
		public const int MetadataFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002BBE")]
		private string metadata_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002BBF")]
		public const int NameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002BC0")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002BC1")]
		public const int ValueFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002BC2")]
		private int value_;

		[Cpp2IlInjected.Token(Token = "0x4002BC3")]
		public const int VersionFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002BC4")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x1700104F")]
		[DebuggerNonUserCode]
		public static MessageParser<Statistic> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005F53")]
			[Cpp2IlInjected.Address(RVA = "0xC07F00", Offset = "0xC06900", VA = "0x180C07F00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001050")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F54")]
			[Cpp2IlInjected.Address(RVA = "0xC07E30", Offset = "0xC06830", VA = "0x180C07E30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001051")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005F55")]
			[Cpp2IlInjected.Address(RVA = "0xC07F60", Offset = "0xC06960", VA = "0x180C07F60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001052")]
		[DebuggerNonUserCode]
		public MapField<string, StatisticChildValue> ChildStatistics
		{
			[Cpp2IlInjected.Token(Token = "0x6005F59")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return childStatistics_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001053")]
		[DebuggerNonUserCode]
		public string Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x6005F5A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return metadata_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F5B")]
			[Cpp2IlInjected.Address(RVA = "0xC08070", Offset = "0xC06A70", VA = "0x180C08070")]
			set
			{
				string text = (metadata_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001054")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6005F5C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F5D")]
			[Cpp2IlInjected.Address(RVA = "0xC080E0", Offset = "0xC06AE0", VA = "0x180C080E0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001055")]
		[DebuggerNonUserCode]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6005F5E")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F5F")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				value_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001056")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6005F60")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005F61")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				version_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F56")]
		[Cpp2IlInjected.Address(RVA = "0xC07C10", Offset = "0xC06610", VA = "0x180C07C10")]
		[DebuggerNonUserCode]
		public Statistic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005F57")]
		[Cpp2IlInjected.Address(RVA = "0xC07CC0", Offset = "0xC066C0", VA = "0x180C07CC0")]
		[DebuggerNonUserCode]
		public Statistic(Statistic other)
		{
			MapField<string, StatisticChildValue> mapField = (childStatistics_ = (MapField<string, StatisticChildValue>)(object)((MapField<TKey, TValue>)(object)other.childStatistics_).Clone());
			string text = (metadata_ = other.metadata_);
			string text2 = (name_ = other.name_);
			int num = (value_ = other.value_);
			int num2 = (version_ = other.version_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F58")]
		[Cpp2IlInjected.Address(RVA = "0xC06E90", Offset = "0xC05890", VA = "0x180C06E90", Slot = "10")]
		[DebuggerNonUserCode]
		public Statistic Clone()
		{
			//Discarded unreachable code: IL_0091
			Statistic statistic = new Statistic();
			MapField<string, StatisticChildValue> mapField = (statistic.childStatistics_ = (MapField<string, StatisticChildValue>)(object)new MapField<TKey, TValue>());
			statistic.metadata_ = "";
			statistic.name_ = "";
			MapField<string, StatisticChildValue> mapField2 = (statistic.childStatistics_ = (MapField<string, StatisticChildValue>)(object)((MapField<TKey, TValue>)(object)childStatistics_).Clone());
			string text = (statistic.metadata_ = metadata_);
			string text2 = (statistic.name_ = name_);
			int num = (statistic.value_ = value_);
			int num2 = (statistic.version_ = version_);
			UnknownFieldSet unknownFieldSet = (statistic._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return statistic;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F62")]
		[Cpp2IlInjected.Address(RVA = "0xC07100", Offset = "0xC05B00", VA = "0x180C07100", Slot = "0")]
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
				MapField<string, StatisticChildValue> mapField = childStatistics_;
				bool flag = default(bool);
				if (flag)
				{
					string text = metadata_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text2 = name_;
						bool flag3 = default(bool);
						if (!flag3 && value_ == (flag3 ? 1 : 0) && version_ == (flag3 ? 1 : 0))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F63")]
		[Cpp2IlInjected.Address(RVA = "0xC07030", Offset = "0xC05A30", VA = "0x180C07030", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Statistic other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<string, StatisticChildValue> mapField = childStatistics_;
				MapField<string, StatisticChildValue> mapField2 = other.childStatistics_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					string text = other.metadata_;
					if (!(metadata_ != text))
					{
						string text2 = other.name_;
						if (!(name_ != text2))
						{
							int num = other.value_;
							if (value_ == num)
							{
								int num2 = other.version_;
								if (version_ == num2)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F64")]
		[Cpp2IlInjected.Address(RVA = "0xC07320", Offset = "0xC05D20", VA = "0x180C07320", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006c
			int hashCode = ((MapField<TKey, TValue>)(object)childStatistics_).GetHashCode();
			string text = metadata_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			string text2 = name_;
			if (text2.m_stringLength != 0)
			{
				int hashCode3 = text2.GetHashCode();
			}
			if (value_ != 0)
			{
			}
			if (version_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F65")]
		[Cpp2IlInjected.Address(RVA = "0xC07800", Offset = "0xC06200", VA = "0x180C07800", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F66")]
		[Cpp2IlInjected.Address(RVA = "0xC07860", Offset = "0xC06260", VA = "0x180C07860", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0095
			MapField<string, StatisticChildValue> mapField = childStatistics_;
			MapField<string, StatisticChildValue>.Codec map_childStatistics_codec = _map_childStatistics_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_childStatistics_codec);
			if (metadata_.m_stringLength != 0)
			{
				string value = metadata_;
				output.WriteString(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (value_ != 0)
			{
				int value3 = value_;
				output.WriteInt32(value3);
			}
			if (version_ != 0)
			{
				int value4 = version_;
				output.WriteInt32(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005F67")]
		[Cpp2IlInjected.Address(RVA = "0xC06C00", Offset = "0xC05600", VA = "0x180C06C00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00c1
			MapField<string, StatisticChildValue> mapField = childStatistics_;
			MapField<string, StatisticChildValue>.Codec map_childStatistics_codec = _map_childStatistics_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_childStatistics_codec);
			string text = metadata_;
			if (text.m_stringLength != 0)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
				num += num2;
			}
			string text2 = name_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			int num4 = value_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			int num6 = version_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F68")]
		[Cpp2IlInjected.Address(RVA = "0xC07560", Offset = "0xC05F60", VA = "0x180C07560", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Statistic other)
		{
			//Discarded unreachable code: IL_0094
			if (other != null)
			{
				MapField<string, StatisticChildValue> mapField = childStatistics_;
				MapField<string, StatisticChildValue> mapField2 = other.childStatistics_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				string text = other.metadata_;
				if (text.m_stringLength != 0)
				{
					Metadata = text;
				}
				string text2 = other.name_;
				if (text2.m_stringLength != 0)
				{
					Name = text2;
				}
				int num = other.value_;
				if (num != 0)
				{
					value_ = num;
				}
				int num2 = other.version_;
				if (num2 != 0)
				{
					version_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005F69")]
		[Cpp2IlInjected.Address(RVA = "0xC07400", Offset = "0xC05E00", VA = "0x180C07400", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_009c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (Name = input.ReadString());
				}
				int num2 = default(int);
				if (num == 32)
				{
					num2 = (value_ = input.ReadInt32());
				}
				if (num2 != 40)
				{
					goto IL_0085;
				}
				int num3 = (version_ = input.ReadInt32());
			}
			if (num == 10)
			{
				MapField<string, StatisticChildValue> mapField = childStatistics_;
				MapField<string, StatisticChildValue>.Codec map_childStatistics_codec = _map_childStatistics_codec;
				((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_childStatistics_codec);
			}
			if (num == 18)
			{
				string text4 = (Metadata = input.ReadString());
			}
			goto IL_0085;
			IL_0085:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005F6A")]
		[Cpp2IlInjected.Address(RVA = "0xC07220", Offset = "0xC05C20", VA = "0x180C07220", Slot = "11")]
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
						if (num != 0 && num != 1)
						{
							goto IL_0035;
						}
						int num2 = value_;
					}
					string text = name_;
				}
				string text2 = metadata_;
			}
			MapField<string, StatisticChildValue> mapField = childStatistics_;
			goto IL_0035;
			IL_0035:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005F6B")]
		[Cpp2IlInjected.Address(RVA = "0xC07630", Offset = "0xC06030", VA = "0x180C07630", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0)
				{
					if (value == null || value != null)
					{
						return;
					}
					throw new InvalidCastException();
				}
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						object obj2 = default(object);
						version_ = (int)obj2;
						break;
					}
					case 0:
					{
						object obj = default(object);
						value_ = (int)obj;
						break;
					}
					}
					return;
				}
				if (value == null || value != null)
				{
					return;
				}
			}
			else
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F6C")]
		[Cpp2IlInjected.Address(RVA = "0xC06DB0", Offset = "0xC057B0", VA = "0x180C06DB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
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
							version_ = 0;
							break;
						case 0:
							value_ = 0;
							break;
						}
					}
					else
					{
						Name = "";
					}
				}
				else
				{
					Metadata = "";
				}
				return;
			}
			MapField<string, StatisticChildValue> mapField = childStatistics_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005F6D")]
		[Cpp2IlInjected.Address(RVA = "0xC079E0", Offset = "0xC063E0", VA = "0x180C079E0")]
		static Statistic()
		{
			Func<Statistic> func = default(Func<Statistic>);
			_parser = (MessageParser<Statistic>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			MessageParser<StatisticChildValue> parser = StatisticChildValue._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<StatisticChildValue>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<Statistic>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
