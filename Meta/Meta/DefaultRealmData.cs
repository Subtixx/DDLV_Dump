using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200087B")]
	public sealed class DefaultRealmData : IMessage<DefaultRealmData>, IMessage, IEquatable<DefaultRealmData>, IDeepCloneable<DefaultRealmData>, IMessageFieldAccessor, IDefaultGridCollectionContainer
	{
		[Cpp2IlInjected.Token(Token = "0x4002219")]
		private static readonly MessageParser<DefaultRealmData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400221A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400221B")]
		public const int DefaultRealmFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400221C")]
		private Realm defaultRealm_;

		[Cpp2IlInjected.Token(Token = "0x400221D")]
		public const int DefaultGridCollectionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400221E")]
		private GridCollection defaultGridCollection_;

		[Cpp2IlInjected.Token(Token = "0x17000BDB")]
		[DebuggerNonUserCode]
		public static MessageParser<DefaultRealmData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600478A")]
			[Cpp2IlInjected.Address(RVA = "0x1A262E0", Offset = "0x1A24CE0", VA = "0x181A262E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600478B")]
			[Cpp2IlInjected.Address(RVA = "0x1A26210", Offset = "0x1A24C10", VA = "0x181A26210")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600478C")]
			[Cpp2IlInjected.Address(RVA = "0x1A26340", Offset = "0x1A24D40", VA = "0x181A26340", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDE")]
		[DebuggerNonUserCode]
		public Realm DefaultRealm
		{
			[Cpp2IlInjected.Token(Token = "0x6004790")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return defaultRealm_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004791")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				defaultRealm_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BDF")]
		[DebuggerNonUserCode]
		public GridCollection DefaultGridCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6004792")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "14")]
			get
			{
				return defaultGridCollection_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004793")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				defaultGridCollection_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600478D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DefaultRealmData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600478E")]
		[Cpp2IlInjected.Address(RVA = "0x1A26170", Offset = "0x1A24B70", VA = "0x181A26170")]
		[DebuggerNonUserCode]
		public DefaultRealmData(DefaultRealmData other)
		{
			//IL_0021: Expected O, but got I4
			Realm realm = other.defaultRealm_;
			int num = 0;
			if (realm != null)
			{
				Realm realm2 = realm.Clone();
			}
			defaultRealm_ = (Realm)num;
			GridCollection gridCollection = other.defaultGridCollection_;
			GridCollection gridCollection2 = default(GridCollection);
			if (gridCollection != null)
			{
				gridCollection2 = gridCollection.Clone();
			}
			defaultGridCollection_ = gridCollection2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600478F")]
		[Cpp2IlInjected.Address(RVA = "0x1A25AB0", Offset = "0x1A244B0", VA = "0x181A25AB0", Slot = "10")]
		[DebuggerNonUserCode]
		public DefaultRealmData Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_0021: Expected O, but got I4
			DefaultRealmData defaultRealmData = new DefaultRealmData();
			Realm realm = defaultRealm_;
			int num = 0;
			if (realm != null)
			{
				Realm realm2 = realm.Clone();
			}
			defaultRealmData.defaultRealm_ = (Realm)num;
			GridCollection gridCollection = defaultGridCollection_;
			GridCollection gridCollection2 = default(GridCollection);
			if (gridCollection != null)
			{
				gridCollection2 = gridCollection.Clone();
			}
			defaultRealmData.defaultGridCollection_ = gridCollection2;
			UnknownFieldSet unknownFieldSet = (defaultRealmData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return defaultRealmData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004794")]
		[Cpp2IlInjected.Address(RVA = "0x1A25B80", Offset = "0x1A24580", VA = "0x181A25B80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(defaultRealm_, other) && object.Equals(defaultGridCollection_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004795")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultRealmData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Realm objB = other.defaultRealm_;
				if (object.Equals(defaultRealm_, objB))
				{
					GridCollection objB2 = other.defaultGridCollection_;
					if (object.Equals(defaultGridCollection_, objB2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004796")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				Realm realm = defaultRealm_;
				if (realm != null)
				{
					int hashCode = realm.GetHashCode();
				}
				GridCollection gridCollection = defaultGridCollection_;
				if (gridCollection != null)
				{
					int hashCode2 = gridCollection.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004797")]
		[Cpp2IlInjected.Address(RVA = "0x1A26000", Offset = "0x1A24A00", VA = "0x181A26000", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004798")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)defaultRealm_ != 0)
			{
				Realm value = defaultRealm_;
				output.WriteMessage(value);
			}
			if ((long)defaultGridCollection_ != 0)
			{
				GridCollection value2 = defaultGridCollection_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004799")]
		[Cpp2IlInjected.Address(RVA = "0x1A259E0", Offset = "0x1A243E0", VA = "0x181A259E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Realm realm = defaultRealm_;
				num = 0;
				if (realm != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(realm);
				}
				GridCollection gridCollection = defaultGridCollection_;
				if (gridCollection != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(gridCollection);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600479A")]
		[Cpp2IlInjected.Address(RVA = "0x1A25CD0", Offset = "0x1A246D0", VA = "0x181A25CD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DefaultRealmData other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.defaultRealm_ != 0)
			{
				Realm realm = defaultRealm_;
				if (realm == null)
				{
					Realm realm2 = (defaultRealm_ = new Realm());
					Realm realm3 = defaultRealm_;
				}
				Realm other2 = other.defaultRealm_;
				realm.MergeFrom(other2);
			}
			if ((long)other.defaultGridCollection_ != 0)
			{
				GridCollection gridCollection2 = default(GridCollection);
				if (defaultGridCollection_ == null)
				{
					GridCollection gridCollection = (defaultGridCollection_ = new GridCollection());
					gridCollection2 = defaultGridCollection_;
				}
				GridCollection other3 = other.defaultGridCollection_;
				gridCollection2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600479B")]
		[Cpp2IlInjected.Address(RVA = "0x1A25E00", Offset = "0x1A24800", VA = "0x181A25E00", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0074
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Realm realm = defaultRealm_;
				if (realm == null)
				{
					Realm realm2 = (defaultRealm_ = new Realm());
				}
				input.ReadMessage(realm);
			}
			if (num == 18)
			{
				GridCollection builder = default(GridCollection);
				if (defaultGridCollection_ == null)
				{
					GridCollection gridCollection = (defaultGridCollection_ = new GridCollection());
					builder = defaultGridCollection_;
				}
				input.ReadMessage(builder);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600479C")]
		[Cpp2IlInjected.Address(RVA = "0x1A25C40", Offset = "0x1A24640", VA = "0x181A25C40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Realm realm = defaultRealm_;
			}
			if (fieldNumber == 2)
			{
				GridCollection gridCollection = defaultGridCollection_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600479D")]
		[Cpp2IlInjected.Address(RVA = "0x1A25F40", Offset = "0x1A24940", VA = "0x181A25F40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					defaultRealm_ = (Realm)num;
					return;
				}
				throw new InvalidCastException();
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600479E")]
		[Cpp2IlInjected.Address(RVA = "0x18AB380", Offset = "0x18A9D80", VA = "0x1818AB380", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600479F")]
		[Cpp2IlInjected.Address(RVA = "0x1A26060", Offset = "0x1A24A60", VA = "0x181A26060")]
		static DefaultRealmData()
		{
			Func<DefaultRealmData> func = default(Func<DefaultRealmData>);
			_parser = (MessageParser<DefaultRealmData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
