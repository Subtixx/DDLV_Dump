using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000326")]
	public sealed class ProfessionStatFormulaItemData : IMessage<ProfessionStatFormulaItemData>, IMessage, IEquatable<ProfessionStatFormulaItemData>, IDeepCloneable<ProfessionStatFormulaItemData>, IMessageFieldAccessor, IItemData, IEquationContext
	{
		[Cpp2IlInjected.Token(Token = "0x2000327")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000328")]
			public sealed class TableOfValue : IMessage<TableOfValue>, IMessage, IEquatable<TableOfValue>, IDeepCloneable<TableOfValue>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000329")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x200032A")]
					public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x4001013")]
						private static readonly MessageParser<Value> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001014")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001015")]
						public const int LevelFieldNumber = 1;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4001016")]
						private int level_;

						[Cpp2IlInjected.Token(Token = "0x4001017")]
						public const int EquationValueFieldNumber = 3;

						[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
						[Cpp2IlInjected.Token(Token = "0x4001018")]
						private float equationValue_;

						[Cpp2IlInjected.Token(Token = "0x1700090A")]
						[DebuggerNonUserCode]
						public static MessageParser<Value> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x60024C8")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E750", Offset = "0x3F9D150", VA = "0x183F9E750")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700090B")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60024C9")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E670", Offset = "0x3F9D070", VA = "0x183F9E670")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700090C")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60024CA")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E930", Offset = "0x3F9D330", VA = "0x183F9E930", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700090D")]
						[DebuggerNonUserCode]
						public int Level
						{
							[Cpp2IlInjected.Token(Token = "0x60024CE")]
							[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
							get
							{
								return default(int);
							}
							[Cpp2IlInjected.Token(Token = "0x60024CF")]
							[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700090E")]
						[DebuggerNonUserCode]
						public float EquationValue
						{
							[Cpp2IlInjected.Token(Token = "0x60024D0")]
							[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320")]
							get
							{
								return default(float);
							}
							[Cpp2IlInjected.Token(Token = "0x60024D1")]
							[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x60024CB")]
						[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
						[DebuggerNonUserCode]
						public Value()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60024CC")]
						[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
						[DebuggerNonUserCode]
						public Value(Value other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60024CD")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C010", Offset = "0x3F9AA10", VA = "0x183F9C010", Slot = "10")]
						[DebuggerNonUserCode]
						public Value Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60024D2")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C730", Offset = "0x3F9B130", VA = "0x183F9C730", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60024D3")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C170", Offset = "0x3F9AB70", VA = "0x183F9C170", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(Value other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60024D4")]
						[Cpp2IlInjected.Address(RVA = "0x3F9CF70", Offset = "0x3F9B970", VA = "0x183F9CF70", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60024D5")]
						[Cpp2IlInjected.Address(RVA = "0x3F9DA60", Offset = "0x3F9C460", VA = "0x183F9DA60", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60024D6")]
						[Cpp2IlInjected.Address(RVA = "0x3F9DD50", Offset = "0x3F9C750", VA = "0x183F9DD50", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60024D7")]
						[Cpp2IlInjected.Address(RVA = "0x3F9BA50", Offset = "0x3F9A450", VA = "0x183F9BA50", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60024D8")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D2D0", Offset = "0x3F9BCD0", VA = "0x183F9D2D0", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(Value other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60024D9")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D3E0", Offset = "0x3F9BDE0", VA = "0x183F9D3E0", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60024DA")]
						[Cpp2IlInjected.Address(RVA = "0x3F9CB30", Offset = "0x3F9B530", VA = "0x183F9CB30", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60024DB")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D640", Offset = "0x3F9C040", VA = "0x183F9D640", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60024DC")]
						[Cpp2IlInjected.Address(RVA = "0x26441D0", Offset = "0x2642BD0", VA = "0x1826441D0", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400100A")]
				private static readonly MessageParser<TableOfValue> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400100B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400100C")]
				public const int VariableNameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400100D")]
				private string variableName_;

				[Cpp2IlInjected.Token(Token = "0x400100E")]
				public const int DefaultValueFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400100F")]
				private float defaultValue_;

				[Cpp2IlInjected.Token(Token = "0x4001010")]
				public const int ValuesFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4001011")]
				private static readonly FieldCodec<Types.Value> _repeated_values_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001012")]
				private readonly RepeatedField<Types.Value> values_;

				[Cpp2IlInjected.Token(Token = "0x17000904")]
				[DebuggerNonUserCode]
				public static MessageParser<TableOfValue> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60024B1")]
					[Cpp2IlInjected.Address(RVA = "0x2378930", Offset = "0x2377330", VA = "0x182378930")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000905")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60024B2")]
					[Cpp2IlInjected.Address(RVA = "0x2378830", Offset = "0x2377230", VA = "0x182378830")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000906")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60024B3")]
					[Cpp2IlInjected.Address(RVA = "0x2378AB0", Offset = "0x23774B0", VA = "0x182378AB0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000907")]
				[DebuggerNonUserCode]
				public string VariableName
				{
					[Cpp2IlInjected.Token(Token = "0x60024B7")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60024B8")]
					[Cpp2IlInjected.Address(RVA = "0x2378C50", Offset = "0x2377650", VA = "0x182378C50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000908")]
				[DebuggerNonUserCode]
				public float DefaultValue
				{
					[Cpp2IlInjected.Token(Token = "0x60024B9")]
					[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
					get
					{
						return default(float);
					}
					[Cpp2IlInjected.Token(Token = "0x60024BA")]
					[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000909")]
				[DebuggerNonUserCode]
				public RepeatedField<Types.Value> Values
				{
					[Cpp2IlInjected.Token(Token = "0x60024BB")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60024B4")]
				[Cpp2IlInjected.Address(RVA = "0x2378590", Offset = "0x2376F90", VA = "0x182378590")]
				[DebuggerNonUserCode]
				public TableOfValue()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024B5")]
				[Cpp2IlInjected.Address(RVA = "0x23786E0", Offset = "0x23770E0", VA = "0x1823786E0")]
				[DebuggerNonUserCode]
				public TableOfValue(TableOfValue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024B6")]
				[Cpp2IlInjected.Address(RVA = "0x23768F0", Offset = "0x23752F0", VA = "0x1823768F0", Slot = "10")]
				[DebuggerNonUserCode]
				public TableOfValue Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024BC")]
				[Cpp2IlInjected.Address(RVA = "0x23769C0", Offset = "0x23753C0", VA = "0x1823769C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60024BD")]
				[Cpp2IlInjected.Address(RVA = "0x2376C30", Offset = "0x2375630", VA = "0x182376C30", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TableOfValue other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60024BE")]
				[Cpp2IlInjected.Address(RVA = "0x23772F0", Offset = "0x2375CF0", VA = "0x1823772F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60024BF")]
				[Cpp2IlInjected.Address(RVA = "0x2377F00", Offset = "0x2376900", VA = "0x182377F00", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024C0")]
				[Cpp2IlInjected.Address(RVA = "0x23780C0", Offset = "0x2376AC0", VA = "0x1823780C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024C1")]
				[Cpp2IlInjected.Address(RVA = "0x2376590", Offset = "0x2374F90", VA = "0x182376590", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60024C2")]
				[Cpp2IlInjected.Address(RVA = "0x2377B40", Offset = "0x2376540", VA = "0x182377B40", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TableOfValue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024C3")]
				[Cpp2IlInjected.Address(RVA = "0x2377A10", Offset = "0x2376410", VA = "0x182377A10", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024C4")]
				[Cpp2IlInjected.Address(RVA = "0x2377200", Offset = "0x2375C00", VA = "0x182377200", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024C5")]
				[Cpp2IlInjected.Address(RVA = "0x2377D70", Offset = "0x2376770", VA = "0x182377D70", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60024C6")]
				[Cpp2IlInjected.Address(RVA = "0x23766A0", Offset = "0x23750A0", VA = "0x1823766A0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000FF6")]
		private static readonly MessageParser<ProfessionStatFormulaItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000FF7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000FF8")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000FF9")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000FFA")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000FFB")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000FFC")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000FFD")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000FFE")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000FFF")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001000")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001001")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001002")]
		public const int EquationFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001003")]
		private string equation_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001004")]
		public const int TablesOfValuesFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4001005")]
		private static readonly FieldCodec<Types.TableOfValue> _repeated_tablesOfValues_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001006")]
		private readonly RepeatedField<Types.TableOfValue> tablesOfValues_ = (RepeatedField<Types.TableOfValue>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001007")]
		private Equation equation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001008")]
		private int ProfessionLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001009")]
		private int TotalProfessionLevel;

		[Cpp2IlInjected.Token(Token = "0x170008F8")]
		[DebuggerNonUserCode]
		public static MessageParser<ProfessionStatFormulaItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600248B")]
			[Cpp2IlInjected.Address(RVA = "0x28893D0", Offset = "0x2887DD0", VA = "0x1828893D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600248C")]
			[Cpp2IlInjected.Address(RVA = "0x28892A0", Offset = "0x2887CA0", VA = "0x1828892A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600248D")]
			[Cpp2IlInjected.Address(RVA = "0x2889490", Offset = "0x2887E90", VA = "0x182889490", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FB")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002491")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002492")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FC")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002493")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002494")]
			[Cpp2IlInjected.Address(RVA = "0x28896F0", Offset = "0x28880F0", VA = "0x1828896F0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FD")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002495")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002496")]
			[Cpp2IlInjected.Address(RVA = "0x28895A0", Offset = "0x2887FA0", VA = "0x1828895A0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FE")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002497")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002498")]
			[Cpp2IlInjected.Address(RVA = "0x2889680", Offset = "0x2888080", VA = "0x182889680")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FF")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002499")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600249A")]
			[Cpp2IlInjected.Address(RVA = "0x2889760", Offset = "0x2888160", VA = "0x182889760")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000900")]
		[DebuggerNonUserCode]
		public string Equation
		{
			[Cpp2IlInjected.Token(Token = "0x600249B")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return equation_;
			}
			[Cpp2IlInjected.Token(Token = "0x600249C")]
			[Cpp2IlInjected.Address(RVA = "0x2889610", Offset = "0x2888010", VA = "0x182889610")]
			set
			{
				string text = (equation_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000901")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.TableOfValue> TablesOfValues
		{
			[Cpp2IlInjected.Token(Token = "0x600249D")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return tablesOfValues_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000902")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60024A9")]
			[Cpp2IlInjected.Address(RVA = "0x2889370", Offset = "0x2887D70", VA = "0x182889370", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000903")]
		private Equation TheEquation
		{
			[Cpp2IlInjected.Token(Token = "0x60024AA")]
			[Cpp2IlInjected.Address(RVA = "0x2889430", Offset = "0x2887E30", VA = "0x182889430")]
			get
			{
				Equation equation = this.equation;
				if (equation != null)
				{
					string text = equation_;
					if (!(equation.EquationString != text))
					{
						goto IL_0034;
					}
				}
				Equation equation2 = (this.equation = Definitions.Util.Equation.Parse(equation_));
				goto IL_0034;
				IL_0034:
				return this.equation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600248E")]
		[Cpp2IlInjected.Address(RVA = "0x28891B0", Offset = "0x2887BB0", VA = "0x1828891B0")]
		[DebuggerNonUserCode]
		public ProfessionStatFormulaItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600248F")]
		[Cpp2IlInjected.Address(RVA = "0x2888FD0", Offset = "0x28879D0", VA = "0x182888FD0")]
		[DebuggerNonUserCode]
		public ProfessionStatFormulaItemData(ProfessionStatFormulaItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (equation_ = other.equation_);
			RepeatedField<Types.TableOfValue> repeatedField = (tablesOfValues_ = (RepeatedField<Types.TableOfValue>)(object)((RepeatedField<T>)(object)other.tablesOfValues_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002490")]
		[Cpp2IlInjected.Address(RVA = "0x2887D70", Offset = "0x2886770", VA = "0x182887D70", Slot = "10")]
		[DebuggerNonUserCode]
		public ProfessionStatFormulaItemData Clone()
		{
			return new ProfessionStatFormulaItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600249E")]
		[Cpp2IlInjected.Address(RVA = "0x2888250", Offset = "0x2886C50", VA = "0x182888250", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(ProfessionStatFormulaItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									string text5 = equation_;
									bool flag5 = default(bool);
									if (!flag5)
									{
										RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
										bool flag6 = default(bool);
										if (flag6)
										{
											return object.Equals(_unknownFields, other);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600249F")]
		[Cpp2IlInjected.Address(RVA = "0x2888140", Offset = "0x2886B40", VA = "0x182888140", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProfessionStatFormulaItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									string text5 = other.equation_;
									if (!(equation_ != text5))
									{
										RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
										RepeatedField<Types.TableOfValue> repeatedField2 = other.tablesOfValues_;
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
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024A0")]
		[Cpp2IlInjected.Address(RVA = "0x2888500", Offset = "0x2886F00", VA = "0x182888500", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00ae
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			string text5 = equation_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			int hashCode6 = ((RepeatedField<T>)(object)tablesOfValues_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60024A1")]
		[Cpp2IlInjected.Address(RVA = "0x2888BA0", Offset = "0x28875A0", VA = "0x182888BA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60024A2")]
		[Cpp2IlInjected.Address(RVA = "0x2888C00", Offset = "0x2887600", VA = "0x182888C00", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d6
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (equation_.m_stringLength != 0)
			{
				string value6 = equation_;
				output.WriteString(value6);
			}
			RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
			FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tablesOfValues_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60024A3")]
		[Cpp2IlInjected.Address(RVA = "0x2887A00", Offset = "0x2886400", VA = "0x182887A00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_010b
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			string text5 = equation_;
			if (text5.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text5);
				num8++;
				num2 += num8;
			}
			RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
			FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tablesOfValues_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num9;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num2 += num10;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60024A4")]
		[Cpp2IlInjected.Address(RVA = "0x2888810", Offset = "0x2887210", VA = "0x182888810", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProfessionStatFormulaItemData other)
		{
			//Discarded unreachable code: IL_00cb
			if (other != null)
			{
				int num = other.iD_;
				if (num != 0)
				{
					iD_ = num;
				}
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				string text2 = other.displayName_;
				if (text2.m_stringLength != 0)
				{
					DisplayName = text2;
				}
				string text3 = other.iconAddress_;
				if (text3.m_stringLength != 0)
				{
					IconAddress = text3;
				}
				string text4 = other.prefabAddress_;
				if (text4.m_stringLength != 0)
				{
					PrefabAddress = text4;
				}
				string text5 = other.equation_;
				if (text5.m_stringLength != 0)
				{
					Equation = text5;
				}
				RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
				RepeatedField<Types.TableOfValue> repeatedField2 = other.tablesOfValues_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024A5")]
		[Cpp2IlInjected.Address(RVA = "0x2888640", Offset = "0x2887040", VA = "0x182888640", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00d5
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 42)
				{
					if (num == 58)
					{
						string text2 = (Equation = input.ReadString());
					}
					if (num != 74)
					{
						goto IL_00be;
					}
					RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
					FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tablesOfValues_codec);
				}
				string text4 = default(string);
				if (num == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_00be;
				}
				string text6 = (PrefabAddress = input.ReadString());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			string text8 = default(string);
			if (num2 == 18)
			{
				text8 = (Name = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (DisplayName = input.ReadString());
			}
			goto IL_00be;
			IL_00be:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60024A6")]
		[Cpp2IlInjected.Address(RVA = "0x28883B0", Offset = "0x2886DB0", VA = "0x1828883B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60024A7")]
		[Cpp2IlInjected.Address(RVA = "0x2888930", Offset = "0x2887330", VA = "0x182888930", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0024, IL_002a, IL_0030, IL_0036
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 8)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024A8")]
		[Cpp2IlInjected.Address(RVA = "0x2887C30", Offset = "0x2886630", VA = "0x182887C30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0017
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 8)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024AB")]
		[Cpp2IlInjected.Address(RVA = "0x2887940", Offset = "0x2886340", VA = "0x182887940")]
		public float CalculateBuffModifier(int professionLevel, int totalProfessionLevel)
		{
			//Discarded unreachable code: IL_0051
			int num = 0;
			ProfessionLevel = professionLevel;
			TotalProfessionLevel = totalProfessionLevel;
			Equation equation = this.equation;
			if (equation != null)
			{
				string text = equation_;
				if (!(equation.EquationString != text))
				{
					goto IL_0044;
				}
			}
			Equation equation2 = (this.equation = Definitions.Util.Equation.Parse(equation_));
			goto IL_0044;
			IL_0044:
			return this.equation.Evaluate(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60024AC")]
		[Cpp2IlInjected.Address(RVA = "0x2887810", Offset = "0x2886210", VA = "0x182887810")]
		public (float, string) CalculateBuffModifierWithLog(int professionLevel, int totalProfessionLevel)
		{
			bool flag = default(bool);
			do
			{
				int num = 0;
				if (flag)
				{
				}
			}
			while (false);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024AD")]
		[Cpp2IlInjected.Address(RVA = "0x2887D70", Offset = "0x2886770", VA = "0x182887D70", Slot = "20")]
		IItemData IItemData.Clone()
		{
			ProfessionStatFormulaItemData professionStatFormulaItemData = new ProfessionStatFormulaItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60024AE")]
		[Cpp2IlInjected.Address(RVA = "0x2887FF0", Offset = "0x28869F0", VA = "0x182887FF0", Slot = "22")]
		bool IEquationContext.HasVariableValue(string variableName)
		{
			string text = variableName;
			if (text != null && (string.Equals(text, "Level") || string.Equals(text, "TotalLevel")))
			{
				return true;
			}
			RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
			Func<Types.TableOfValue, bool> func = (Func<Types.TableOfValue, bool>)(object)(Func<T, TResult>)delegate(Types.TableOfValue x)
			{
				//Discarded unreachable code: IL_0014
				string b = variableName;
				return string.Equals(x.variableName_, b);
			};
			Types.TableOfValue tableOfValue = Enumerable.FirstOrDefault<Types.TableOfValue>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024AF")]
		[Cpp2IlInjected.Address(RVA = "0x2887DD0", Offset = "0x28867D0", VA = "0x182887DD0", Slot = "21")]
		float IEquationContext.GetVariableValue(string variableName)
		{
			string text = variableName;
			if (text != null)
			{
				if (string.Equals(text, "Level"))
				{
				}
				if (!string.Equals(text, "TotalLevel"))
				{
				}
			}
			RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
			Func<Types.TableOfValue, bool> func = (Func<Types.TableOfValue, bool>)(object)(Func<T, TResult>)delegate(Types.TableOfValue x)
			{
				//Discarded unreachable code: IL_0014
				string b = variableName;
				return string.Equals(x.variableName_, b);
			};
			Types.TableOfValue tableOfValue = Enumerable.FirstOrDefault<Types.TableOfValue>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			if (tableOfValue == null)
			{
			}
			if (((RepeatedField<T>)(object)tableOfValue.values_).Count != 0)
			{
				if (((RepeatedField<T>)(object)tableOfValue.values_).Count != 1)
				{
					NotImplementedException ex = new NotImplementedException("If you need more functionality, get a programmer to look at ProfessionStatFormulaItemData");
					/*Error: Unexpected end of block*/;
				}
				RepeatedField<Types.TableOfValue.Types.Value> values_ = tableOfValue.values_;
				int index = 0;
				Types.TableOfValue.Types.Value value = (Types.TableOfValue.Types.Value)((RepeatedField<T>)(object)values_)[index];
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024B0")]
		[Cpp2IlInjected.Address(RVA = "0x2888E00", Offset = "0x2887800", VA = "0x182888E00")]
		static ProfessionStatFormulaItemData()
		{
			Func<ProfessionStatFormulaItemData> func = default(Func<ProfessionStatFormulaItemData>);
			_parser = (MessageParser<ProfessionStatFormulaItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.TableOfValue> parser = Types.TableOfValue._parser;
			uint num = default(uint);
			_parser = (MessageParser<ProfessionStatFormulaItemData>)(object)FieldCodec.ForMessage<Types.TableOfValue>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
