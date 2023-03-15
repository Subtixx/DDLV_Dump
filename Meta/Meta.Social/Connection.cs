using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Social.Ralph;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000BAC")]
	public sealed class Connection : IMessage<Connection>, IMessage, IEquatable<Connection>, IDeepCloneable<Connection>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002D1E")]
		private static readonly MessageParser<Connection> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002D1F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002D20")]
		public const int FedIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D21")]
		private string fedId_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002D22")]
		public const int SnapshotFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D23")]
		private Snapshot snapshot_;

		[Cpp2IlInjected.Token(Token = "0x4002D24")]
		public const int GuildFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D25")]
		private string guild_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002D26")]
		public const int StatsFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4002D27")]
		private static readonly MapField<string, int>.Codec _map_stats_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002D28")]
		private readonly MapField<string, int> stats_ = (MapField<string, int>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4002D29")]
		public const int AlbumFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002D2A")]
		private Album album_;

		[Cpp2IlInjected.Token(Token = "0x4002D2B")]
		public const int LastOnlineFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002D2C")]
		private Timestamp lastOnline_;

		[Cpp2IlInjected.Token(Token = "0x17001105")]
		[DebuggerNonUserCode]
		public static MessageParser<Connection> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60062F3")]
			[Cpp2IlInjected.Address(RVA = "0x168CF20", Offset = "0x168B920", VA = "0x18168CF20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001106")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60062F4")]
			[Cpp2IlInjected.Address(RVA = "0x168CD20", Offset = "0x168B720", VA = "0x18168CD20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001107")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60062F5")]
			[Cpp2IlInjected.Address(RVA = "0x168CF80", Offset = "0x168B980", VA = "0x18168CF80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001108")]
		[DebuggerNonUserCode]
		public string FedId
		{
			[Cpp2IlInjected.Token(Token = "0x60062F9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return fedId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60062FA")]
			[Cpp2IlInjected.Address(RVA = "0x168D1A0", Offset = "0x168BBA0", VA = "0x18168D1A0")]
			set
			{
				string text = (fedId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001109")]
		[DebuggerNonUserCode]
		public Snapshot Snapshot
		{
			[Cpp2IlInjected.Token(Token = "0x60062FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return snapshot_;
			}
			[Cpp2IlInjected.Token(Token = "0x60062FC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				snapshot_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110A")]
		[DebuggerNonUserCode]
		public string Guild
		{
			[Cpp2IlInjected.Token(Token = "0x60062FD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return guild_;
			}
			[Cpp2IlInjected.Token(Token = "0x60062FE")]
			[Cpp2IlInjected.Address(RVA = "0x168D210", Offset = "0x168BC10", VA = "0x18168D210")]
			set
			{
				string text = (guild_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110B")]
		[DebuggerNonUserCode]
		public MapField<string, int> Stats
		{
			[Cpp2IlInjected.Token(Token = "0x60062FF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return stats_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110C")]
		[DebuggerNonUserCode]
		public Album Album
		{
			[Cpp2IlInjected.Token(Token = "0x6006300")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return album_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006301")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				album_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700110D")]
		[DebuggerNonUserCode]
		public Timestamp LastOnline
		{
			[Cpp2IlInjected.Token(Token = "0x6006302")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return lastOnline_;
			}
			[Cpp2IlInjected.Token(Token = "0x6006303")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				lastOnline_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60062F6")]
		[Cpp2IlInjected.Address(RVA = "0x168C960", Offset = "0x168B360", VA = "0x18168C960")]
		[DebuggerNonUserCode]
		public Connection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60062F7")]
		[Cpp2IlInjected.Address(RVA = "0x168CA10", Offset = "0x168B410", VA = "0x18168CA10")]
		[DebuggerNonUserCode]
		public Connection(Connection other)
		{
			//IL_0053: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			string text = (fedId_ = other.fedId_);
			Snapshot snapshot = other.snapshot_;
			int num = 0;
			if (snapshot != null)
			{
				Snapshot snapshot2 = snapshot.Clone();
			}
			snapshot_ = (Snapshot)num;
			string text2 = (guild_ = other.guild_);
			MapField<string, int> mapField = (stats_ = (MapField<string, int>)(object)((MapField<TKey, TValue>)(object)other.stats_).Clone());
			Album album = other.album_;
			if (album != null)
			{
				Album album2 = album.Clone();
			}
			album_ = (Album)num;
			Timestamp timestamp = other.lastOnline_;
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp != null)
			{
				timestamp2 = timestamp.Clone();
			}
			lastOnline_ = timestamp2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60062F8")]
		[Cpp2IlInjected.Address(RVA = "0x168B250", Offset = "0x1689C50", VA = "0x18168B250", Slot = "10")]
		[DebuggerNonUserCode]
		public Connection Clone()
		{
			return new Connection(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006304")]
		[Cpp2IlInjected.Address(RVA = "0x168B380", Offset = "0x1689D80", VA = "0x18168B380", Slot = "0")]
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
				string text = fedId_;
				bool flag = default(bool);
				if (!flag && object.Equals(snapshot_, other))
				{
					string text2 = guild_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						MapField<string, int> mapField = stats_;
						bool flag3 = default(bool);
						if (flag3 && object.Equals(album_, other) && object.Equals(lastOnline_, other))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006305")]
		[Cpp2IlInjected.Address(RVA = "0x168B4D0", Offset = "0x1689ED0", VA = "0x18168B4D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Connection other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.fedId_;
				if (!(fedId_ != text))
				{
					Snapshot objB = other.snapshot_;
					if (object.Equals(snapshot_, objB))
					{
						string text2 = other.guild_;
						if (!(guild_ != text2))
						{
							MapField<string, int> mapField = stats_;
							MapField<string, int> mapField2 = other.stats_;
							if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
							{
								Album objB2 = other.album_;
								if (object.Equals(album_, objB2))
								{
									Timestamp objB3 = other.lastOnline_;
									if (object.Equals(lastOnline_, objB3))
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										return object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006306")]
		[Cpp2IlInjected.Address(RVA = "0x168B860", Offset = "0x168A260", VA = "0x18168B860", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0095
			string text = fedId_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			Snapshot snapshot = snapshot_;
			if (snapshot != null)
			{
				int hashCode2 = snapshot.GetHashCode();
			}
			string text2 = guild_;
			if (text2.m_stringLength != 0)
			{
				int hashCode3 = text2.GetHashCode();
			}
			int hashCode4 = ((MapField<TKey, TValue>)(object)stats_).GetHashCode();
			Album album = album_;
			if (album != null)
			{
				int hashCode5 = album.GetHashCode();
			}
			Timestamp timestamp = lastOnline_;
			if (timestamp != null)
			{
				int hashCode6 = timestamp.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006307")]
		[Cpp2IlInjected.Address(RVA = "0x168C3B0", Offset = "0x168ADB0", VA = "0x18168C3B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006308")]
		[Cpp2IlInjected.Address(RVA = "0x168C410", Offset = "0x168AE10", VA = "0x18168C410", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b4
			if (fedId_.m_stringLength != 0)
			{
				string value = fedId_;
				output.WriteString(value);
			}
			if ((long)snapshot_ != 0)
			{
				Snapshot value2 = snapshot_;
				output.WriteMessage(value2);
			}
			if (guild_.m_stringLength != 0)
			{
				string value3 = guild_;
				output.WriteString(value3);
			}
			MapField<string, int> mapField = stats_;
			MapField<string, int>.Codec map_stats_codec = _map_stats_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_stats_codec);
			if ((long)album_ != 0)
			{
				Album value4 = album_;
				output.WriteMessage(value4);
			}
			if ((long)lastOnline_ != 0)
			{
				Timestamp value5 = lastOnline_;
				output.WriteMessage(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006309")]
		[Cpp2IlInjected.Address(RVA = "0x168ADC0", Offset = "0x16897C0", VA = "0x18168ADC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00db
			string text = fedId_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			Snapshot snapshot = snapshot_;
			if (snapshot != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(snapshot);
				num3++;
				num += num3;
			}
			string text2 = guild_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				num += num4;
			}
			MapField<string, int> mapField = stats_;
			MapField<string, int>.Codec map_stats_codec = _map_stats_codec;
			int num5 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_stats_codec);
			Album album = album_;
			num += num5;
			if (album != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(album);
				num6++;
				num += num6;
			}
			Timestamp timestamp = lastOnline_;
			if (timestamp != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(timestamp);
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

		[Cpp2IlInjected.Token(Token = "0x600630A")]
		[Cpp2IlInjected.Address(RVA = "0x168BAB0", Offset = "0x168A4B0", VA = "0x18168BAB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Connection other)
		{
			//Discarded unreachable code: IL_011f
			if (other == null)
			{
				return;
			}
			string text = other.fedId_;
			if (text.m_stringLength != 0)
			{
				FedId = text;
			}
			if ((long)other.snapshot_ != 0)
			{
				Snapshot snapshot2 = default(Snapshot);
				if (snapshot_ == null)
				{
					Snapshot snapshot = (snapshot_ = new Snapshot());
					snapshot2 = snapshot_;
				}
				Snapshot other2 = other.snapshot_;
				snapshot2.MergeFrom(other2);
			}
			string text2 = other.guild_;
			if (text2.m_stringLength != 0)
			{
				Guild = text2;
			}
			MapField<string, int> mapField = stats_;
			MapField<string, int> mapField2 = other.stats_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			if ((long)other.album_ != 0)
			{
				Album album2 = default(Album);
				if (album_ == null)
				{
					Album album = (album_ = new Album());
					album2 = album_;
				}
				Album other3 = other.album_;
				album2.MergeFrom(other3);
			}
			if ((long)other.lastOnline_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (lastOnline_ == null)
				{
					Timestamp timestamp = (lastOnline_ = new Timestamp());
					timestamp2 = lastOnline_;
				}
				Timestamp other4 = other.lastOnline_;
				timestamp2.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600630B")]
		[Cpp2IlInjected.Address(RVA = "0x168BCA0", Offset = "0x168A6A0", VA = "0x18168BCA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0106
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if (num == 50)
				{
					MapField<string, int> mapField = stats_;
					MapField<string, int>.Codec map_stats_codec = _map_stats_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_stats_codec);
				}
				Album album = default(Album);
				if (num == 58)
				{
					Album builder = default(Album);
					if (album_ == null)
					{
						album = (album_ = new Album());
						builder = album_;
					}
					input.ReadMessage(builder);
				}
				if ((long)album != 66)
				{
					goto IL_00ef;
				}
				Timestamp builder2 = default(Timestamp);
				if (lastOnline_ == null)
				{
					Timestamp timestamp = (lastOnline_ = new Timestamp());
					builder2 = lastOnline_;
				}
				input.ReadMessage(builder2);
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (FedId = input.ReadString());
			}
			Snapshot snapshot = default(Snapshot);
			if ((long)text2 == 18)
			{
				Snapshot builder3 = default(Snapshot);
				if (snapshot_ == null)
				{
					snapshot = (snapshot_ = new Snapshot());
					builder3 = snapshot_;
				}
				input.ReadMessage(builder3);
			}
			if ((long)snapshot == 42)
			{
				string text4 = (Guild = input.ReadString());
			}
			goto IL_00ef;
			IL_00ef:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600630C")]
		[Cpp2IlInjected.Address(RVA = "0x168B670", Offset = "0x168A070", VA = "0x18168B670", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 7)
			{
				string text = fedId_;
				Snapshot snapshot = snapshot_;
				string text2 = guild_;
				MapField<string, int> mapField = stats_;
				Album album = album_;
				Timestamp timestamp = lastOnline_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600630D")]
		[Cpp2IlInjected.Address(RVA = "0x168BFD0", Offset = "0x168A9D0", VA = "0x18168BFD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0020, IL_0021, IL_002d, IL_0033
			//IL_0017: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				FedId = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600630E")]
		[Cpp2IlInjected.Address(RVA = "0x168AFA0", Offset = "0x16899A0", VA = "0x18168AFA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0016
			if (fieldNumber - 1 <= 7)
			{
				FedId = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600630F")]
		[Cpp2IlInjected.Address(RVA = "0x168C7C0", Offset = "0x168B1C0", VA = "0x18168C7C0")]
		static Connection()
		{
			Func<Connection> func = default(Func<Connection>);
			_parser = (MessageParser<Connection>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			FieldCodec<int> fieldCodec2 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num = default(uint);
			_parser = (MessageParser<Connection>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			/*Error: Unexpected end of block*/;
		}
	}
}
