using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000810")]
	public sealed class DefaultPlayerHouseData : IMessage<DefaultPlayerHouseData>, IMessage, IEquatable<DefaultPlayerHouseData>, IDeepCloneable<DefaultPlayerHouseData>, IMessageFieldAccessor, IDefaultGridCollectionContainer, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400202D")]
		private static readonly MessageParser<DefaultPlayerHouseData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400202E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400202F")]
		public const int DefaultHouseFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002030")]
		private House defaultHouse_;

		[Cpp2IlInjected.Token(Token = "0x4002031")]
		public const int DefaultGridCollectionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002032")]
		private GridCollection defaultGridCollection_;

		[Cpp2IlInjected.Token(Token = "0x17000AF9")]
		[DebuggerNonUserCode]
		public static MessageParser<DefaultPlayerHouseData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600433A")]
			[Cpp2IlInjected.Address(RVA = "0x1A25870", Offset = "0x1A24270", VA = "0x181A25870")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFA")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600433B")]
			[Cpp2IlInjected.Address(RVA = "0x1A257A0", Offset = "0x1A241A0", VA = "0x181A257A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFB")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600433C")]
			[Cpp2IlInjected.Address(RVA = "0x1A258D0", Offset = "0x1A242D0", VA = "0x181A258D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFC")]
		[DebuggerNonUserCode]
		public House DefaultHouse
		{
			[Cpp2IlInjected.Token(Token = "0x6004340")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return defaultHouse_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004341")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				defaultHouse_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AFD")]
		[DebuggerNonUserCode]
		public GridCollection DefaultGridCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6004342")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "14")]
			get
			{
				return defaultGridCollection_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004343")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				defaultGridCollection_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600433D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DefaultPlayerHouseData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600433E")]
		[Cpp2IlInjected.Address(RVA = "0x1A25700", Offset = "0x1A24100", VA = "0x181A25700")]
		[DebuggerNonUserCode]
		public DefaultPlayerHouseData(DefaultPlayerHouseData other)
		{
			//IL_0021: Expected O, but got I4
			House house = other.defaultHouse_;
			int num = 0;
			if (house != null)
			{
				House house2 = house.Clone();
			}
			defaultHouse_ = (House)num;
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

		[Cpp2IlInjected.Token(Token = "0x600433F")]
		[Cpp2IlInjected.Address(RVA = "0x1A24820", Offset = "0x1A23220", VA = "0x181A24820", Slot = "10")]
		[DebuggerNonUserCode]
		public DefaultPlayerHouseData Clone()
		{
			//Discarded unreachable code: IL_0056
			//IL_0021: Expected O, but got I4
			DefaultPlayerHouseData defaultPlayerHouseData = new DefaultPlayerHouseData();
			House house = defaultHouse_;
			int num = 0;
			if (house != null)
			{
				House house2 = house.Clone();
			}
			defaultPlayerHouseData.defaultHouse_ = (House)num;
			GridCollection gridCollection = defaultGridCollection_;
			GridCollection gridCollection2 = default(GridCollection);
			if (gridCollection != null)
			{
				gridCollection2 = gridCollection.Clone();
			}
			defaultPlayerHouseData.defaultGridCollection_ = gridCollection2;
			UnknownFieldSet unknownFieldSet = (defaultPlayerHouseData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return defaultPlayerHouseData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004344")]
		[Cpp2IlInjected.Address(RVA = "0x1A25110", Offset = "0x1A23B10", VA = "0x181A25110", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(defaultHouse_, other) && object.Equals(defaultGridCollection_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004345")]
		[Cpp2IlInjected.Address(RVA = "0x18AB550", Offset = "0x18A9F50", VA = "0x1818AB550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultPlayerHouseData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				House objB = other.defaultHouse_;
				if (object.Equals(defaultHouse_, objB))
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

		[Cpp2IlInjected.Token(Token = "0x6004346")]
		[Cpp2IlInjected.Address(RVA = "0x18AB720", Offset = "0x18AA120", VA = "0x1818AB720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				House house = defaultHouse_;
				if (house != null)
				{
					int hashCode = house.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6004347")]
		[Cpp2IlInjected.Address(RVA = "0x1A25590", Offset = "0x1A23F90", VA = "0x181A25590", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004348")]
		[Cpp2IlInjected.Address(RVA = "0x18ABC30", Offset = "0x18AA630", VA = "0x1818ABC30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0045
			if ((long)defaultHouse_ != 0)
			{
				House value = defaultHouse_;
				output.WriteMessage(value);
			}
			if ((long)defaultGridCollection_ != 0)
			{
				GridCollection value2 = defaultGridCollection_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004349")]
		[Cpp2IlInjected.Address(RVA = "0x1A24750", Offset = "0x1A23150", VA = "0x181A24750", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				House house = defaultHouse_;
				num = 0;
				if (house != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(house);
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

		[Cpp2IlInjected.Token(Token = "0x600434A")]
		[Cpp2IlInjected.Address(RVA = "0x1A25260", Offset = "0x1A23C60", VA = "0x181A25260", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DefaultPlayerHouseData other)
		{
			//Discarded unreachable code: IL_009b
			if (other == null)
			{
				return;
			}
			if ((long)other.defaultHouse_ != 0)
			{
				House house = defaultHouse_;
				if (house == null)
				{
					House house2 = (defaultHouse_ = new House());
					House house3 = defaultHouse_;
				}
				House other2 = other.defaultHouse_;
				house.MergeFrom(other2);
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

		[Cpp2IlInjected.Token(Token = "0x600434B")]
		[Cpp2IlInjected.Address(RVA = "0x1A25390", Offset = "0x1A23D90", VA = "0x181A25390", Slot = "5")]
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
				House house = defaultHouse_;
				if (house == null)
				{
					House house2 = (defaultHouse_ = new House());
				}
				input.ReadMessage(house);
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

		[Cpp2IlInjected.Token(Token = "0x600434C")]
		[Cpp2IlInjected.Address(RVA = "0x1A251D0", Offset = "0x1A23BD0", VA = "0x181A251D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				House house = defaultHouse_;
			}
			if (fieldNumber == 2)
			{
				GridCollection gridCollection = defaultGridCollection_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600434D")]
		[Cpp2IlInjected.Address(RVA = "0x1A254D0", Offset = "0x1A23ED0", VA = "0x181A254D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					defaultHouse_ = (House)num;
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

		[Cpp2IlInjected.Token(Token = "0x600434E")]
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

		[Cpp2IlInjected.Token(Token = "0x600434F")]
		[Cpp2IlInjected.Address(RVA = "0x1A248F0", Offset = "0x1A232F0", VA = "0x181A248F0", Slot = "15")]
		public unsafe void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00e2, IL_00e8, IL_00ee, IL_0100, IL_0106, IL_010c, IL_0118, IL_011e, IL_0124
			//IL_0047: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (ProtoDatabase.Instance.TryGet("DefaultInventories", out *(DefaultInventories*)num))
			{
				RepeatedField<House.Types.Floor> floors_ = defaultHouse_.floors_;
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					if (flag2)
					{
						bool flag3 = default(bool);
						if (!flag3)
						{
							string message = $"Flooring item {flag3} is not in the default inventory";
							context.AddInvalidMemberError(message, "Flooring");
						}
						bool flag4 = default(bool);
						if (flag4)
						{
							string value = (flag4 ? ((bool*)1) : ((bool*)null))->ToString();
							bool flag5 = flag4;
							int ownerOverride = 0;
							IDisposable disposable = context.ScopeStackName(value, (byte)ownerOverride != 0);
							bool flag6 = default(bool);
							if (!flag6)
							{
								string message2 = $"Wallpaper item {flag6} is not in the default inventory";
								context.AddInvalidMemberError(message2, "Wallpapers");
							}
							num++;
							if (disposable != null)
							{
							}
							if (flag4)
							{
								throw new NullReferenceException();
							}
							while (num == 0)
							{
							}
						}
						int num3 = num3 + 1;
						if (flag4)
						{
							throw new NullReferenceException();
						}
						if (num3 != 0)
						{
						}
						IDisposable disposable2 = default(IDisposable);
						if (disposable2 != null)
						{
						}
						if (flag4)
						{
							throw new NullReferenceException();
						}
						while (num3 == 0)
						{
						}
						int num4 = num3 - 1;
					}
					num++;
					while (num == 0)
					{
					}
				}
			}
			context.AddError("Unable to find default inventories");
		}

		[Cpp2IlInjected.Token(Token = "0x6004350")]
		[Cpp2IlInjected.Address(RVA = "0x1A255F0", Offset = "0x1A23FF0", VA = "0x181A255F0")]
		static DefaultPlayerHouseData()
		{
			Func<DefaultPlayerHouseData> func = default(Func<DefaultPlayerHouseData>);
			_parser = (MessageParser<DefaultPlayerHouseData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
