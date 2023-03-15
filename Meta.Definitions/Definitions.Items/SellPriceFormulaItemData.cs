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
	[Cpp2IlInjected.Token(Token = "0x2000569")]
	public sealed class SellPriceFormulaItemData : IMessage<SellPriceFormulaItemData>, IMessage, IEquatable<SellPriceFormulaItemData>, IDeepCloneable<SellPriceFormulaItemData>, IMessageFieldAccessor, IItemData, IEquationContext, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200056A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200056B")]
			public sealed class TableOfValue : IMessage<TableOfValue>, IMessage, IEquatable<TableOfValue>, IDeepCloneable<TableOfValue>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x200056C")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x200056D")]
					public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x4001D7D")]
						private static readonly MessageParser<Value> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001D7E")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001D7F")]
						public const int KeyFieldNumber = 1;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4001D80")]
						private string key_;

						[Cpp2IlInjected.Token(Token = "0x4001D81")]
						public const int EquationValueFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x4001D82")]
						private float equationValue_;

						[Cpp2IlInjected.Token(Token = "0x1700117A")]
						[DebuggerNonUserCode]
						public static MessageParser<Value> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x60043B5")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E810", Offset = "0x3F9D210", VA = "0x183F9E810")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700117B")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60043B6")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E5F0", Offset = "0x3F9CFF0", VA = "0x183F9E5F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700117C")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x60043B7")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E870", Offset = "0x3F9D270", VA = "0x183F9E870", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700117D")]
						[DebuggerNonUserCode]
						public string Key
						{
							[Cpp2IlInjected.Token(Token = "0x60043BB")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x60043BC")]
							[Cpp2IlInjected.Address(RVA = "0x3F9EBE0", Offset = "0x3F9D5E0", VA = "0x183F9EBE0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x1700117E")]
						[DebuggerNonUserCode]
						public float EquationValue
						{
							[Cpp2IlInjected.Token(Token = "0x60043BD")]
							[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
							get
							{
								return default(float);
							}
							[Cpp2IlInjected.Token(Token = "0x60043BE")]
							[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x60043B8")]
						[Cpp2IlInjected.Address(RVA = "0x3F9E4A0", Offset = "0x3F9CEA0", VA = "0x183F9E4A0")]
						[DebuggerNonUserCode]
						public Value()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043B9")]
						[Cpp2IlInjected.Address(RVA = "0x3F9E270", Offset = "0x3F9CC70", VA = "0x183F9E270")]
						[DebuggerNonUserCode]
						public Value(Value other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043BA")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C0A0", Offset = "0x3F9AAA0", VA = "0x183F9C0A0", Slot = "10")]
						[DebuggerNonUserCode]
						public Value Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60043BF")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C610", Offset = "0x3F9B010", VA = "0x183F9C610", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60043C0")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C320", Offset = "0x3F9AD20", VA = "0x183F9C320", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(Value other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x60043C1")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D0A0", Offset = "0x3F9BAA0", VA = "0x183F9D0A0", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60043C2")]
						[Cpp2IlInjected.Address(RVA = "0x3F9DB20", Offset = "0x3F9C520", VA = "0x183F9DB20", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60043C3")]
						[Cpp2IlInjected.Address(RVA = "0x3F9DBE0", Offset = "0x3F9C5E0", VA = "0x183F9DBE0", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043C4")]
						[Cpp2IlInjected.Address(RVA = "0x3F9B9A0", Offset = "0x3F9A3A0", VA = "0x183F9B9A0", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x60043C5")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D5C0", Offset = "0x3F9BFC0", VA = "0x183F9D5C0", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(Value other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043C6")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D340", Offset = "0x3F9BD40", VA = "0x183F9D340", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043C7")]
						[Cpp2IlInjected.Address(RVA = "0x3F9CC20", Offset = "0x3F9B620", VA = "0x183F9CC20", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x60043C8")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D950", Offset = "0x3F9C350", VA = "0x183F9D950", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x60043C9")]
						[Cpp2IlInjected.Address(RVA = "0x3F9BC90", Offset = "0x3F9A690", VA = "0x183F9BC90", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4001D72")]
				private static readonly MessageParser<TableOfValue> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001D73")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001D74")]
				public const int VariableNameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001D75")]
				private string variableName_;

				[Cpp2IlInjected.Token(Token = "0x4001D76")]
				public const int FieldNameFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001D77")]
				private string fieldName_;

				[Cpp2IlInjected.Token(Token = "0x4001D78")]
				public const int DefaultValueFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001D79")]
				private float defaultValue_;

				[Cpp2IlInjected.Token(Token = "0x4001D7A")]
				public const int ValuesFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4001D7B")]
				private static readonly FieldCodec<Types.Value> _repeated_values_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4001D7C")]
				private readonly RepeatedField<Types.Value> values_;

				[Cpp2IlInjected.Token(Token = "0x17001173")]
				[DebuggerNonUserCode]
				public static MessageParser<TableOfValue> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004399")]
					[Cpp2IlInjected.Address(RVA = "0x2378990", Offset = "0x2377390", VA = "0x182378990")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001174")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600439A")]
					[Cpp2IlInjected.Address(RVA = "0x23788B0", Offset = "0x23772B0", VA = "0x1823788B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001175")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600439B")]
					[Cpp2IlInjected.Address(RVA = "0x23789F0", Offset = "0x23773F0", VA = "0x1823789F0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001176")]
				[DebuggerNonUserCode]
				public string VariableName
				{
					[Cpp2IlInjected.Token(Token = "0x600439F")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60043A0")]
					[Cpp2IlInjected.Address(RVA = "0x2378BE0", Offset = "0x23775E0", VA = "0x182378BE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001177")]
				[DebuggerNonUserCode]
				public string FieldName
				{
					[Cpp2IlInjected.Token(Token = "0x60043A1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60043A2")]
					[Cpp2IlInjected.Address(RVA = "0x2378B70", Offset = "0x2377570", VA = "0x182378B70")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001178")]
				[DebuggerNonUserCode]
				public float DefaultValue
				{
					[Cpp2IlInjected.Token(Token = "0x60043A3")]
					[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
					get
					{
						return default(float);
					}
					[Cpp2IlInjected.Token(Token = "0x60043A4")]
					[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001179")]
				[DebuggerNonUserCode]
				public RepeatedField<Types.Value> Values
				{
					[Cpp2IlInjected.Token(Token = "0x60043A5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600439C")]
				[Cpp2IlInjected.Address(RVA = "0x2378780", Offset = "0x2377180", VA = "0x182378780")]
				[DebuggerNonUserCode]
				public TableOfValue()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600439D")]
				[Cpp2IlInjected.Address(RVA = "0x2378630", Offset = "0x2377030", VA = "0x182378630")]
				[DebuggerNonUserCode]
				public TableOfValue(TableOfValue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600439E")]
				[Cpp2IlInjected.Address(RVA = "0x2376810", Offset = "0x2375210", VA = "0x182376810", Slot = "10")]
				[DebuggerNonUserCode]
				public TableOfValue Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60043A6")]
				[Cpp2IlInjected.Address(RVA = "0x2376D40", Offset = "0x2375740", VA = "0x182376D40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60043A7")]
				[Cpp2IlInjected.Address(RVA = "0x2376B10", Offset = "0x2375510", VA = "0x182376B10", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TableOfValue other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60043A8")]
				[Cpp2IlInjected.Address(RVA = "0x2377440", Offset = "0x2375E40", VA = "0x182377440", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60043A9")]
				[Cpp2IlInjected.Address(RVA = "0x2377EA0", Offset = "0x23768A0", VA = "0x182377EA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60043AA")]
				[Cpp2IlInjected.Address(RVA = "0x2377F60", Offset = "0x2376960", VA = "0x182377F60", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60043AB")]
				[Cpp2IlInjected.Address(RVA = "0x2376440", Offset = "0x2374E40", VA = "0x182376440", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60043AC")]
				[Cpp2IlInjected.Address(RVA = "0x23777E0", Offset = "0x23761E0", VA = "0x1823777E0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TableOfValue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60043AD")]
				[Cpp2IlInjected.Address(RVA = "0x23778B0", Offset = "0x23762B0", VA = "0x1823778B0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60043AE")]
				[Cpp2IlInjected.Address(RVA = "0x2377110", Offset = "0x2375B10", VA = "0x182377110", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60043AF")]
				[Cpp2IlInjected.Address(RVA = "0x2377BF0", Offset = "0x23765F0", VA = "0x182377BF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60043B0")]
				[Cpp2IlInjected.Address(RVA = "0x2376750", Offset = "0x2375150", VA = "0x182376750", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60043B1")]
				[Cpp2IlInjected.Address(RVA = "0x23776C0", Offset = "0x23760C0", VA = "0x1823776C0")]
				public float GetValueForItem(Item item, ItemState state)
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60043B2")]
				[Cpp2IlInjected.Address(RVA = "0x2376EB0", Offset = "0x23758B0", VA = "0x182376EB0")]
				public string GetFieldValueForItem(Item item, ItemState state)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60043B3")]
				[Cpp2IlInjected.Address(RVA = "0x23775B0", Offset = "0x2375FB0", VA = "0x1823775B0")]
				private Types.Value GetTableValue(Item item, ItemState state)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001D5A")]
		private static readonly MessageParser<SellPriceFormulaItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001D5B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001D5C")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001D5D")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001D5E")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D5F")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D60")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D61")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D62")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001D63")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D64")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D65")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D66")]
		public const int ObjectTypeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001D67")]
		private string objectType_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D68")]
		public const int EquationFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001D69")]
		private string equation_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D6A")]
		public const int TablesOfValuesFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4001D6B")]
		private static readonly FieldCodec<Types.TableOfValue> _repeated_tablesOfValues_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001D6C")]
		private readonly RepeatedField<Types.TableOfValue> tablesOfValues_ = (RepeatedField<Types.TableOfValue>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001D6D")]
		private Equation equation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001D6E")]
		private Item evaluatedItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001D6F")]
		private ItemState evaluatedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001D70")]
		private ItemDatabase.ItemTypeMetaInfo cachedMetaInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001D71")]
		private string cachedObjectType;

		[Cpp2IlInjected.Token(Token = "0x17001166")]
		[DebuggerNonUserCode]
		public static MessageParser<SellPriceFormulaItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600436D")]
			[Cpp2IlInjected.Address(RVA = "0x384AA10", Offset = "0x3849410", VA = "0x18384AA10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001167")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600436E")]
			[Cpp2IlInjected.Address(RVA = "0x384A8E0", Offset = "0x38492E0", VA = "0x18384A8E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001168")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600436F")]
			[Cpp2IlInjected.Address(RVA = "0x384AA70", Offset = "0x3849470", VA = "0x18384AA70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001169")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6004373")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004374")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116A")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004375")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004376")]
			[Cpp2IlInjected.Address(RVA = "0x384ACD0", Offset = "0x38496D0", VA = "0x18384ACD0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116B")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6004377")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004378")]
			[Cpp2IlInjected.Address(RVA = "0x384AB80", Offset = "0x3849580", VA = "0x18384AB80")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116C")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004379")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600437A")]
			[Cpp2IlInjected.Address(RVA = "0x384AC60", Offset = "0x3849660", VA = "0x18384AC60")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116D")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600437B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600437C")]
			[Cpp2IlInjected.Address(RVA = "0x384ADB0", Offset = "0x38497B0", VA = "0x18384ADB0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116E")]
		[DebuggerNonUserCode]
		public string ObjectType
		{
			[Cpp2IlInjected.Token(Token = "0x600437D")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return objectType_;
			}
			[Cpp2IlInjected.Token(Token = "0x600437E")]
			[Cpp2IlInjected.Address(RVA = "0x384AD40", Offset = "0x3849740", VA = "0x18384AD40")]
			set
			{
				string text = (objectType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700116F")]
		[DebuggerNonUserCode]
		public string Equation
		{
			[Cpp2IlInjected.Token(Token = "0x600437F")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return equation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004380")]
			[Cpp2IlInjected.Address(RVA = "0x384ABF0", Offset = "0x38495F0", VA = "0x18384ABF0")]
			set
			{
				string text = (equation_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001170")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.TableOfValue> TablesOfValues
		{
			[Cpp2IlInjected.Token(Token = "0x6004381")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return tablesOfValues_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001171")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600438D")]
			[Cpp2IlInjected.Address(RVA = "0x384A9B0", Offset = "0x38493B0", VA = "0x18384A9B0", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001172")]
		private Equation TheEquation
		{
			[Cpp2IlInjected.Token(Token = "0x600438F")]
			[Cpp2IlInjected.Address(RVA = "0x29EB830", Offset = "0x29EA230", VA = "0x1829EB830")]
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

		[Cpp2IlInjected.Token(Token = "0x6004370")]
		[Cpp2IlInjected.Address(RVA = "0x384A7E0", Offset = "0x38491E0", VA = "0x18384A7E0")]
		[DebuggerNonUserCode]
		public SellPriceFormulaItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004371")]
		[Cpp2IlInjected.Address(RVA = "0x384A5E0", Offset = "0x3848FE0", VA = "0x18384A5E0")]
		[DebuggerNonUserCode]
		public SellPriceFormulaItemData(SellPriceFormulaItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (objectType_ = other.objectType_);
			string text6 = (equation_ = other.equation_);
			RepeatedField<Types.TableOfValue> repeatedField = (tablesOfValues_ = (RepeatedField<Types.TableOfValue>)(object)((RepeatedField<T>)(object)other.tablesOfValues_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004372")]
		[Cpp2IlInjected.Address(RVA = "0x3848670", Offset = "0x3847070", VA = "0x183848670", Slot = "10")]
		[DebuggerNonUserCode]
		public SellPriceFormulaItemData Clone()
		{
			return new SellPriceFormulaItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004382")]
		[Cpp2IlInjected.Address(RVA = "0x38488D0", Offset = "0x38472D0", VA = "0x1838488D0", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(SellPriceFormulaItemData).TypeHandle)
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
									string text5 = objectType_;
									bool flag5 = default(bool);
									if (!flag5)
									{
										string text6 = equation_;
										bool flag6 = default(bool);
										if (!flag6)
										{
											RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
											bool flag7 = default(bool);
											if (flag7)
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
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004383")]
		[Cpp2IlInjected.Address(RVA = "0x3848A40", Offset = "0x3847440", VA = "0x183848A40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SellPriceFormulaItemData other)
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
									string text5 = other.objectType_;
									if (!(objectType_ != text5))
									{
										string text6 = other.equation_;
										if (!(equation_ != text6))
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
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004384")]
		[Cpp2IlInjected.Address(RVA = "0x3848CD0", Offset = "0x38476D0", VA = "0x183848CD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00c9
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
			string text5 = objectType_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			string text6 = equation_;
			if (text6.m_stringLength != 0)
			{
				int hashCode6 = text6.GetHashCode();
			}
			int hashCode7 = ((RepeatedField<T>)(object)tablesOfValues_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004385")]
		[Cpp2IlInjected.Address(RVA = "0x384A170", Offset = "0x3848B70", VA = "0x18384A170", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004386")]
		[Cpp2IlInjected.Address(RVA = "0x384A1D0", Offset = "0x3848BD0", VA = "0x18384A1D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00f4
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
			if (objectType_.m_stringLength != 0)
			{
				string value6 = objectType_;
				output.WriteString(value6);
			}
			if (equation_.m_stringLength != 0)
			{
				string value7 = equation_;
				output.WriteString(value7);
			}
			RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
			FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tablesOfValues_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004387")]
		[Cpp2IlInjected.Address(RVA = "0x38482A0", Offset = "0x3846CA0", VA = "0x1838482A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0131
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
			string text5 = objectType_;
			if (text5.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text5);
				num8++;
				num2 += num8;
			}
			string text6 = equation_;
			if (text6.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text6);
				num9++;
				num2 += num9;
			}
			RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
			FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tablesOfValues_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num10;
			if (unknownFields != null)
			{
				int num11 = unknownFields.CalculateSize();
				num2 += num11;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004388")]
		[Cpp2IlInjected.Address(RVA = "0x3849D80", Offset = "0x3848780", VA = "0x183849D80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SellPriceFormulaItemData other)
		{
			//Discarded unreachable code: IL_00e5
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
				string text5 = other.objectType_;
				if (text5.m_stringLength != 0)
				{
					ObjectType = text5;
				}
				string text6 = other.equation_;
				if (text6.m_stringLength != 0)
				{
					Equation = text6;
				}
				RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
				RepeatedField<Types.TableOfValue> repeatedField2 = other.tablesOfValues_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004389")]
		[Cpp2IlInjected.Address(RVA = "0x3849B90", Offset = "0x3848590", VA = "0x183849B90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00fc
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			string text6 = default(string);
			if ((int)num > 34)
			{
				string text2 = default(string);
				if ((int)num > 50)
				{
					if (num == 58)
					{
						text2 = (Equation = input.ReadString());
					}
					if ((long)text2 != 66)
					{
						goto IL_00e5;
					}
					RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
					FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tablesOfValues_codec);
				}
				string text4 = default(string);
				if ((long)text2 == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_00e5;
				}
				text6 = (ObjectType = input.ReadString());
			}
			string text10 = default(string);
			if ((long)text6 > 18)
			{
				string text8 = default(string);
				if ((long)text6 == 26)
				{
					text8 = (DisplayName = input.ReadString());
				}
				if ((long)text8 != 34)
				{
					goto IL_00e5;
				}
				text10 = (IconAddress = input.ReadString());
			}
			int num2 = default(int);
			if ((long)text10 == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				string text12 = (Name = input.ReadString());
			}
			goto IL_00e5;
			IL_00e5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600438A")]
		[Cpp2IlInjected.Address(RVA = "0x3848B70", Offset = "0x3847570", VA = "0x183848B70", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600438B")]
		[Cpp2IlInjected.Address(RVA = "0x3849EC0", Offset = "0x38488C0", VA = "0x183849EC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0025, IL_002b, IL_0031, IL_0037, IL_003d
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 7)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600438C")]
		[Cpp2IlInjected.Address(RVA = "0x3848510", Offset = "0x3846F10", VA = "0x183848510", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 7)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600438E")]
		[Cpp2IlInjected.Address(RVA = "0x3848670", Offset = "0x3847070", VA = "0x183848670", Slot = "20")]
		IItemData IItemData.Clone()
		{
			SellPriceFormulaItemData sellPriceFormulaItemData = new SellPriceFormulaItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004390")]
		[Cpp2IlInjected.Address(RVA = "0x3848100", Offset = "0x3846B00", VA = "0x183848100")]
		public CurrencyCost CalculateItemPrice(Item item, ItemState state)
		{
			//Discarded unreachable code: IL_007e, IL_0084
			//IL_000e: Expected O, but got I4
			//IL_0073: Expected I4, but got O
			//IL_007b: Expected I4, but got O
			int itemID = item.ItemID;
			evaluatedItem = (Item)itemID;
			evaluatedState = state;
			Equation equation = this.equation;
			if (equation != null)
			{
				string text = equation_;
				if (!(equation.EquationString != text))
				{
					goto IL_004b;
				}
			}
			Equation equation2 = (this.equation = Definitions.Util.Equation.Parse(equation_));
			goto IL_004b;
			IL_004b:
			float num = this.equation.Evaluate(this);
			CurrencyCost currencyCost = new CurrencyCost();
			int num2 = 0;
			Item socialCurrencyItem = CurrencyItem.SocialCurrencyItem;
			currencyCost.id_ = (int)socialCurrencyItem;
			currencyCost.amount_ = (int)state;
			return currencyCost;
		}

		[Cpp2IlInjected.Token(Token = "0x6004391")]
		[Cpp2IlInjected.Address(RVA = "0x3849A10", Offset = "0x3848410", VA = "0x183849A10", Slot = "22")]
		public bool HasVariableValue(string variableName)
		{
			_003C_003Ec__DisplayClass73_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass73_0();
			CS_0024_003C_003E8__locals0.variableName = variableName;
			if (CS_0024_003C_003E8__locals0 != null && (long)evaluatedState == 0)
			{
				int num = 0;
			}
			if (!string.Equals(CS_0024_003C_003E8__locals0.variableName, "DefaultSellPrice"))
			{
				RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
				Func<Types.TableOfValue, bool> func = (Func<Types.TableOfValue, bool>)(object)(Func<T, TResult>)delegate(Types.TableOfValue x)
				{
					//Discarded unreachable code: IL_0014
					string variableName2 = CS_0024_003C_003E8__locals0.variableName;
					return string.Equals(x.variableName_, variableName2);
				};
				Types.TableOfValue tableOfValue = Enumerable.FirstOrDefault<Types.TableOfValue>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004392")]
		[Cpp2IlInjected.Address(RVA = "0x3849840", Offset = "0x3848240", VA = "0x183849840", Slot = "21")]
		public float GetVariableValue(string variableName)
		{
			_003C_003Ec__DisplayClass74_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass74_0();
			CS_0024_003C_003E8__locals0.variableName = variableName;
			if (CS_0024_003C_003E8__locals0 != null && (long)evaluatedState == 0)
			{
				goto IL_004d;
			}
			if (!string.Equals(CS_0024_003C_003E8__locals0.variableName, "DefaultSellPrice"))
			{
				RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
				Func<Types.TableOfValue, bool> func = (Func<Types.TableOfValue, bool>)(object)(Func<T, TResult>)delegate(Types.TableOfValue x)
				{
					//Discarded unreachable code: IL_0014
					string variableName2 = CS_0024_003C_003E8__locals0.variableName;
					return string.Equals(x.variableName_, variableName2);
				};
				if (Enumerable.FirstOrDefault<Types.TableOfValue>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func) == null)
				{
					goto IL_004d;
				}
			}
			goto IL_004f;
			IL_004d:
			int num = 0;
			goto IL_004f;
			IL_004f:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004393")]
		[Cpp2IlInjected.Address(RVA = "0x3849160", Offset = "0x3847B60", VA = "0x183849160")]
		private unsafe ItemDatabase.ItemTypeMetaInfo GetObjectTypeMetaInfo()
		{
			//Discarded unreachable code: IL_00e5
			//IL_00a0: Expected O, but got I4
			//IL_00a0: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00ce: Expected O, but got I4
			while (true)
			{
				string value = objectType_;
				int num = 0;
				if (string.IsNullOrEmpty(value))
				{
					break;
				}
				if ((IntPtr)cachedMetaInfo != (IntPtr)num)
				{
					string text = cachedObjectType;
					if (!(objectType_ != text))
					{
						break;
					}
				}
				string text2 = objectType_;
				char[] array = new char[1];
				array[0] = '/';
				string[] array2 = text2.Split(array);
				if (Enum.TryParse<ItemType>(array2[0], out *(ItemType*)num) && ItemDatabase.ItemTypeMetaInfo.TryGetItemTypeMetaInfo((ItemType)num, out *(ItemDatabase.ItemTypeMetaInfo*)num) && array2.Length > 1 && array2[1] != "Base")
				{
					int num2 = 0;
					if ((System.RuntimeType)num != (System.RuntimeType)num2)
					{
						string value2 = array2[1];
						object obj = Enum.Parse((Type)num, value2);
						if (obj != null)
						{
							int num3 = 0;
							if (obj == null)
							{
								continue;
							}
						}
					}
				}
				cachedMetaInfo = (ItemDatabase.ItemTypeMetaInfo)num;
				string text3 = (cachedObjectType = objectType_);
				break;
			}
			return cachedMetaInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6004394")]
		[Cpp2IlInjected.Address(RVA = "0x3848F50", Offset = "0x3847950", VA = "0x183848F50")]
		public static CurrencyCost GetItemSellPrice(Item item, ItemState state)
		{
			//Discarded unreachable code: IL_0023
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			SellPriceFormulaItemData sellPriceFormulaItemData = GetSellPriceFormulaItemData(itemData);
			if (sellPriceFormulaItemData != null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				CurrencyCost result = default(CurrencyCost);
				return result;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004395")]
		[Cpp2IlInjected.Address(RVA = "0x3848E30", Offset = "0x3847830", VA = "0x183848E30")]
		public static CurrencyCost GetItemSellPrice(IItemData itemData, ItemState itemState)
		{
			//Discarded unreachable code: IL_001b
			SellPriceFormulaItemData sellPriceFormulaItemData = GetSellPriceFormulaItemData(itemData);
			if (sellPriceFormulaItemData != null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				CurrencyCost result = default(CurrencyCost);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004396")]
		[Cpp2IlInjected.Address(RVA = "0x38494B0", Offset = "0x3847EB0", VA = "0x1838494B0")]
		public static SellPriceFormulaItemData GetSellPriceFormulaItemData(IItemData itemData)
		{
			//Discarded unreachable code: IL_0076
			uint num2 = default(uint);
			IEnumerable<SellPriceFormulaItemData> enumerable = default(IEnumerable<SellPriceFormulaItemData>);
			uint num3 = default(uint);
			ItemDatabase.ItemTypeMetaInfo itemTypeMetaInfo = default(ItemDatabase.ItemTypeMetaInfo);
			Type type = default(Type);
			while (true)
			{
				int num = 0;
				if (itemData == null)
				{
					break;
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (enumerable != null)
				{
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_0052;
						}
						num++;
					}
					if (!((object)itemTypeMetaInfo.ProtobufClassType).Equals((object)type))
					{
						continue;
					}
					num++;
					type = (Type)(object)((object)type + (object)type);
					num += 312;
					goto IL_0052;
				}
				goto IL_0061;
				IL_0052:
				type = (Type)(object)((object)type + (object)type);
				num += 312;
				goto IL_0061;
				IL_0061:
				num++;
				if (enumerable != null)
				{
				}
				if (num == 0)
				{
				}
				break;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004397")]
		[Cpp2IlInjected.Address(RVA = "0x38486D0", Offset = "0x38470D0", VA = "0x1838486D0", Slot = "23")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0060
			string text = objectType_;
			if ("ObjectType" != null)
			{
				context.AddInvalidMemberError("Formula.Price: Please select an ObjectType (cannot be empty)", "ObjectType");
			}
			ItemDatabase.ItemTypeMetaInfo objectTypeMetaInfo = GetObjectTypeMetaInfo();
			Type typeFromHandle = typeof(IItemSellPriceCalculator);
			Type protobufClassType = objectTypeMetaInfo.ProtobufClassType;
			if (typeFromHandle.IsAssignableFrom(protobufClassType))
			{
				context.AddInvalidMemberError("A SellPriceFormulaItemData cannot be created for an item which implements a custom price calculation algorithm.", "ObjectType");
			}
			Equation equation = Definitions.Util.Equation.Parse(equation_);
		}

		[Cpp2IlInjected.Token(Token = "0x6004398")]
		[Cpp2IlInjected.Address(RVA = "0x384A410", Offset = "0x3848E10", VA = "0x18384A410")]
		static SellPriceFormulaItemData()
		{
			Func<SellPriceFormulaItemData> func = default(Func<SellPriceFormulaItemData>);
			_parser = (MessageParser<SellPriceFormulaItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.TableOfValue> parser = Types.TableOfValue._parser;
			uint num = default(uint);
			_parser = (MessageParser<SellPriceFormulaItemData>)(object)FieldCodec.ForMessage<Types.TableOfValue>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
