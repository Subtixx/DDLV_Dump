using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000559")]
	public sealed class PriceFormulaItemData : IMessage<PriceFormulaItemData>, IMessage, IEquatable<PriceFormulaItemData>, IDeepCloneable<PriceFormulaItemData>, IMessageFieldAccessor, IItemData, IEquationContext, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200055A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200055B")]
			public sealed class BaseValueParameters : IMessage<BaseValueParameters>, IMessage, IEquatable<BaseValueParameters>, IDeepCloneable<BaseValueParameters>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001D31")]
				private static readonly MessageParser<BaseValueParameters> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001D32")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001D33")]
				public const int CurrencyItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001D34")]
				private int currencyItemID_;

				[Cpp2IlInjected.Token(Token = "0x4001D35")]
				public const int BaseValueFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4001D36")]
				private int baseValue_;

				[Cpp2IlInjected.Token(Token = "0x4001D37")]
				public const int SellingPriceRatioFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001D38")]
				private float sellingPriceRatio_;

				[Cpp2IlInjected.Token(Token = "0x17001152")]
				[DebuggerNonUserCode]
				public static MessageParser<BaseValueParameters> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004304")]
					[Cpp2IlInjected.Address(RVA = "0x2FE74D0", Offset = "0x2FE5ED0", VA = "0x182FE74D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001153")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004305")]
					[Cpp2IlInjected.Address(RVA = "0x2FE7450", Offset = "0x2FE5E50", VA = "0x182FE7450")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001154")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004306")]
					[Cpp2IlInjected.Address(RVA = "0x2FE7530", Offset = "0x2FE5F30", VA = "0x182FE7530", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001155")]
				[DebuggerNonUserCode]
				public int CurrencyItemID
				{
					[Cpp2IlInjected.Token(Token = "0x600430A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600430B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001156")]
				[DebuggerNonUserCode]
				public int BaseValue
				{
					[Cpp2IlInjected.Token(Token = "0x600430C")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600430D")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001157")]
				[DebuggerNonUserCode]
				public float SellingPriceRatio
				{
					[Cpp2IlInjected.Token(Token = "0x600430E")]
					[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
					get
					{
						return default(float);
					}
					[Cpp2IlInjected.Token(Token = "0x600430F")]
					[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004307")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public BaseValueParameters()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004308")]
				[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
				[DebuggerNonUserCode]
				public BaseValueParameters(BaseValueParameters other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004309")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6B20", Offset = "0x2FE5520", VA = "0x182FE6B20", Slot = "10")]
				[DebuggerNonUserCode]
				public BaseValueParameters Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004310")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6C80", Offset = "0x2FE5680", VA = "0x182FE6C80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004311")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6BB0", Offset = "0x2FE55B0", VA = "0x182FE6BB0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(BaseValueParameters other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004312")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6EA0", Offset = "0x2FE58A0", VA = "0x182FE6EA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004313")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7220", Offset = "0x2FE5C20", VA = "0x182FE7220", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004314")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7280", Offset = "0x2FE5C80", VA = "0x182FE7280", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004315")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6A40", Offset = "0x2FE5440", VA = "0x182FE6A40", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004316")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7090", Offset = "0x2FE5A90", VA = "0x182FE7090", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(BaseValueParameters other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004317")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6FE0", Offset = "0x2FE59E0", VA = "0x182FE6FE0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004318")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6DA0", Offset = "0x2FE57A0", VA = "0x182FE6DA0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004319")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7100", Offset = "0x2FE5B00", VA = "0x182FE7100", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600431A")]
				[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200055D")]
			public sealed class TableOfValue : IMessage<TableOfValue>, IMessage, IEquatable<TableOfValue>, IDeepCloneable<TableOfValue>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x200055E")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x200055F")]
					public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x4001D47")]
						private static readonly MessageParser<Value> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001D48")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001D49")]
						public const int KeyFieldNumber = 1;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4001D4A")]
						private string key_;

						[Cpp2IlInjected.Token(Token = "0x4001D4B")]
						public const int EquationValueFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x4001D4C")]
						private float equationValue_;

						[Cpp2IlInjected.Token(Token = "0x4001D4D")]
						public const int CurrencyFieldNumber = 3;

						[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
						[Cpp2IlInjected.Token(Token = "0x4001D4E")]
						private int currency_;

						[Cpp2IlInjected.Token(Token = "0x17001160")]
						[DebuggerNonUserCode]
						public static MessageParser<Value> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x600433E")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E6F0", Offset = "0x3F9D0F0", VA = "0x183F9E6F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17001161")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x600433F")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E570", Offset = "0x3F9CF70", VA = "0x183F9E570")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17001162")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6004340")]
							[Cpp2IlInjected.Address(RVA = "0x3F9EAB0", Offset = "0x3F9D4B0", VA = "0x183F9EAB0", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17001163")]
						[DebuggerNonUserCode]
						public string Key
						{
							[Cpp2IlInjected.Token(Token = "0x6004344")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x6004345")]
							[Cpp2IlInjected.Address(RVA = "0x3F9EC50", Offset = "0x3F9D650", VA = "0x183F9EC50")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17001164")]
						[DebuggerNonUserCode]
						public float EquationValue
						{
							[Cpp2IlInjected.Token(Token = "0x6004346")]
							[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
							get
							{
								return default(float);
							}
							[Cpp2IlInjected.Token(Token = "0x6004347")]
							[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17001165")]
						[DebuggerNonUserCode]
						public int Currency
						{
							[Cpp2IlInjected.Token(Token = "0x6004348")]
							[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
							get
							{
								return default(int);
							}
							[Cpp2IlInjected.Token(Token = "0x6004349")]
							[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x6004341")]
						[Cpp2IlInjected.Address(RVA = "0x3F9E220", Offset = "0x3F9CC20", VA = "0x183F9E220")]
						[DebuggerNonUserCode]
						public Value()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004342")]
						[Cpp2IlInjected.Address(RVA = "0x3F9E310", Offset = "0x3F9CD10", VA = "0x183F9E310")]
						[DebuggerNonUserCode]
						public Value(Value other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004343")]
						[Cpp2IlInjected.Address(RVA = "0x3F9BE70", Offset = "0x3F9A870", VA = "0x183F9BE70", Slot = "10")]
						[DebuggerNonUserCode]
						public Value Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600434A")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C4E0", Offset = "0x3F9AEE0", VA = "0x183F9C4E0", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600434B")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C400", Offset = "0x3F9AE00", VA = "0x183F9C400", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(Value other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600434C")]
						[Cpp2IlInjected.Address(RVA = "0x3F9CCF0", Offset = "0x3F9B6F0", VA = "0x183F9CCF0", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600434D")]
						[Cpp2IlInjected.Address(RVA = "0x3F9DAC0", Offset = "0x3F9C4C0", VA = "0x183F9DAC0", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600434E")]
						[Cpp2IlInjected.Address(RVA = "0x3F9DC80", Offset = "0x3F9C680", VA = "0x183F9DC80", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600434F")]
						[Cpp2IlInjected.Address(RVA = "0x3F9BBB0", Offset = "0x3F9A5B0", VA = "0x183F9BBB0", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x6004350")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D250", Offset = "0x3F9BC50", VA = "0x183F9D250", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(Value other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004351")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D510", Offset = "0x3F9BF10", VA = "0x183F9D510", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004352")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C960", Offset = "0x3F9B360", VA = "0x183F9C960", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6004353")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D820", Offset = "0x3F9C220", VA = "0x183F9D820", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004354")]
						[Cpp2IlInjected.Address(RVA = "0x3F9BD40", Offset = "0x3F9A740", VA = "0x183F9BD40", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4001D3A")]
				private static readonly MessageParser<TableOfValue> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001D3B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001D3C")]
				public const int VariableNameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001D3D")]
				private string variableName_;

				[Cpp2IlInjected.Token(Token = "0x4001D3E")]
				public const int FieldNameFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001D3F")]
				private string fieldName_;

				[Cpp2IlInjected.Token(Token = "0x4001D40")]
				public const int DefaultValueFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001D41")]
				private float defaultValue_;

				[Cpp2IlInjected.Token(Token = "0x4001D42")]
				public const int DefaultCurrencyFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4001D43")]
				private int defaultCurrency_;

				[Cpp2IlInjected.Token(Token = "0x4001D44")]
				public const int ValuesFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x4001D45")]
				private static readonly FieldCodec<Types.Value> _repeated_values_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4001D46")]
				private readonly RepeatedField<Types.Value> values_;

				[Cpp2IlInjected.Token(Token = "0x17001158")]
				[DebuggerNonUserCode]
				public static MessageParser<TableOfValue> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600431F")]
					[Cpp2IlInjected.Address(RVA = "0x2FF63C0", Offset = "0x2FF4DC0", VA = "0x182FF63C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001159")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004320")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6340", Offset = "0x2FF4D40", VA = "0x182FF6340")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004321")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6540", Offset = "0x2FF4F40", VA = "0x182FF6540", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115B")]
				[DebuggerNonUserCode]
				public string VariableName
				{
					[Cpp2IlInjected.Token(Token = "0x6004325")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004326")]
					[Cpp2IlInjected.Address(RVA = "0x2FF66E0", Offset = "0x2FF50E0", VA = "0x182FF66E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115C")]
				[DebuggerNonUserCode]
				public string FieldName
				{
					[Cpp2IlInjected.Token(Token = "0x6004327")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004328")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6670", Offset = "0x2FF5070", VA = "0x182FF6670")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115D")]
				[DebuggerNonUserCode]
				public float DefaultValue
				{
					[Cpp2IlInjected.Token(Token = "0x6004329")]
					[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
					get
					{
						return default(float);
					}
					[Cpp2IlInjected.Token(Token = "0x600432A")]
					[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115E")]
				[DebuggerNonUserCode]
				public int DefaultCurrency
				{
					[Cpp2IlInjected.Token(Token = "0x600432B")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600432C")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700115F")]
				[DebuggerNonUserCode]
				public RepeatedField<Types.Value> Values
				{
					[Cpp2IlInjected.Token(Token = "0x600432D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004322")]
				[Cpp2IlInjected.Address(RVA = "0x2FF5F40", Offset = "0x2FF4940", VA = "0x182FF5F40")]
				[DebuggerNonUserCode]
				public TableOfValue()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004323")]
				[Cpp2IlInjected.Address(RVA = "0x2FF6150", Offset = "0x2FF4B50", VA = "0x182FF6150")]
				[DebuggerNonUserCode]
				public TableOfValue(TableOfValue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004324")]
				[Cpp2IlInjected.Address(RVA = "0x2FF32F0", Offset = "0x2FF1CF0", VA = "0x182FF32F0", Slot = "10")]
				[DebuggerNonUserCode]
				public TableOfValue Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600432E")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3790", Offset = "0x2FF2190", VA = "0x182FF3790", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600432F")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3900", Offset = "0x2FF2300", VA = "0x182FF3900", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TableOfValue other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004330")]
				[Cpp2IlInjected.Address(RVA = "0x2FF4CA0", Offset = "0x2FF36A0", VA = "0x182FF4CA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004331")]
				[Cpp2IlInjected.Address(RVA = "0x2FF57A0", Offset = "0x2FF41A0", VA = "0x182FF57A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004332")]
				[Cpp2IlInjected.Address(RVA = "0x2FF5960", Offset = "0x2FF4360", VA = "0x182FF5960", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004333")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2CF0", Offset = "0x2FF16F0", VA = "0x182FF2CF0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004334")]
				[Cpp2IlInjected.Address(RVA = "0x2FF4F70", Offset = "0x2FF3970", VA = "0x182FF4F70", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TableOfValue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004335")]
				[Cpp2IlInjected.Address(RVA = "0x2FF5050", Offset = "0x2FF3A50", VA = "0x182FF5050", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004336")]
				[Cpp2IlInjected.Address(RVA = "0x2FF4910", Offset = "0x2FF3310", VA = "0x182FF4910", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004337")]
				[Cpp2IlInjected.Address(RVA = "0x2FF5570", Offset = "0x2FF3F70", VA = "0x182FF5570", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004338")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3080", Offset = "0x2FF1A80", VA = "0x182FF3080", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004339")]
				[Cpp2IlInjected.Address(RVA = "0x2FF4F40", Offset = "0x2FF3940", VA = "0x182FF4F40")]
				public float GetValueForItem(IItemData itemData)
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600433A")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3A30", Offset = "0x2FF2430", VA = "0x182FF3A30")]
				public Item? GetCurrencyForItem(IItemData itemData)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600433B")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3C90", Offset = "0x2FF2690", VA = "0x182FF3C90")]
				public string GetFieldValueForItem(IItemData itemData, bool useDatabase)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600433C")]
				[Cpp2IlInjected.Address(RVA = "0x2FF4E30", Offset = "0x2FF3830", VA = "0x182FF4E30")]
				private Types.Value GetTableValue(IItemData itemData)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001D17")]
		private static readonly MessageParser<PriceFormulaItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001D18")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001D19")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001D1A")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001D1B")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D1C")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D1D")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D1E")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D1F")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001D20")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D21")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D22")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D23")]
		public const int ObjectTypeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001D24")]
		private string objectType_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D25")]
		public const int EquationFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001D26")]
		private string equation_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D27")]
		public const int BaseValueFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4001D28")]
		private static readonly FieldCodec<Types.BaseValueParameters> _repeated_baseValue_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001D29")]
		private readonly RepeatedField<Types.BaseValueParameters> baseValue_ = (RepeatedField<Types.BaseValueParameters>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001D2A")]
		public const int TablesOfValuesFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4001D2B")]
		private static readonly FieldCodec<Types.TableOfValue> _repeated_tablesOfValues_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001D2C")]
		private readonly RepeatedField<Types.TableOfValue> tablesOfValues_ = (RepeatedField<Types.TableOfValue>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001D2D")]
		private Equation equation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001D2E")]
		private IItemData evaluatedItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001D2F")]
		private Item usedCurrencyItem;

		[Cpp2IlInjected.Token(Token = "0x4001D30")]
		private static Item[] currencyPriority;

		[Cpp2IlInjected.Token(Token = "0x17001144")]
		[DebuggerNonUserCode]
		public static MessageParser<PriceFormulaItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60042D5")]
			[Cpp2IlInjected.Address(RVA = "0x28826C0", Offset = "0x28810C0", VA = "0x1828826C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001145")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60042D6")]
			[Cpp2IlInjected.Address(RVA = "0x2882590", Offset = "0x2880F90", VA = "0x182882590")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001146")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60042D7")]
			[Cpp2IlInjected.Address(RVA = "0x2882780", Offset = "0x2881180", VA = "0x182882780", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001147")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60042DB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001148")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60042DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042DE")]
			[Cpp2IlInjected.Address(RVA = "0x28829E0", Offset = "0x28813E0", VA = "0x1828829E0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001149")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60042DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042E0")]
			[Cpp2IlInjected.Address(RVA = "0x2882890", Offset = "0x2881290", VA = "0x182882890")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700114A")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60042E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042E2")]
			[Cpp2IlInjected.Address(RVA = "0x2882970", Offset = "0x2881370", VA = "0x182882970")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700114B")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60042E3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042E4")]
			[Cpp2IlInjected.Address(RVA = "0x2882AC0", Offset = "0x28814C0", VA = "0x182882AC0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700114C")]
		[DebuggerNonUserCode]
		public string ObjectType
		{
			[Cpp2IlInjected.Token(Token = "0x60042E5")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return objectType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042E6")]
			[Cpp2IlInjected.Address(RVA = "0x2882A50", Offset = "0x2881450", VA = "0x182882A50")]
			set
			{
				string text = (objectType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700114D")]
		[DebuggerNonUserCode]
		public string Equation
		{
			[Cpp2IlInjected.Token(Token = "0x60042E7")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return equation_;
			}
			[Cpp2IlInjected.Token(Token = "0x60042E8")]
			[Cpp2IlInjected.Address(RVA = "0x2882900", Offset = "0x2881300", VA = "0x182882900")]
			set
			{
				string text = (equation_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700114E")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.BaseValueParameters> BaseValue
		{
			[Cpp2IlInjected.Token(Token = "0x60042E9")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return baseValue_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700114F")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.TableOfValue> TablesOfValues
		{
			[Cpp2IlInjected.Token(Token = "0x60042EA")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return tablesOfValues_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001150")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60042F6")]
			[Cpp2IlInjected.Address(RVA = "0x2882660", Offset = "0x2881060", VA = "0x182882660", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001151")]
		private Equation TheEquation
		{
			[Cpp2IlInjected.Token(Token = "0x60042F7")]
			[Cpp2IlInjected.Address(RVA = "0x2882720", Offset = "0x2881120", VA = "0x182882720")]
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

		[Cpp2IlInjected.Token(Token = "0x60042D8")]
		[Cpp2IlInjected.Address(RVA = "0x28821E0", Offset = "0x2880BE0", VA = "0x1828821E0")]
		[DebuggerNonUserCode]
		public PriceFormulaItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60042D9")]
		[Cpp2IlInjected.Address(RVA = "0x2882320", Offset = "0x2880D20", VA = "0x182882320")]
		[DebuggerNonUserCode]
		public PriceFormulaItemData(PriceFormulaItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (objectType_ = other.objectType_);
			string text6 = (equation_ = other.equation_);
			RepeatedField<Types.BaseValueParameters> repeatedField = (baseValue_ = (RepeatedField<Types.BaseValueParameters>)(object)((RepeatedField<T>)(object)other.baseValue_).Clone());
			RepeatedField<Types.TableOfValue> repeatedField2 = (tablesOfValues_ = (RepeatedField<Types.TableOfValue>)(object)((RepeatedField<T>)(object)other.tablesOfValues_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042DA")]
		[Cpp2IlInjected.Address(RVA = "0x287F320", Offset = "0x287DD20", VA = "0x18287F320", Slot = "10")]
		[DebuggerNonUserCode]
		public PriceFormulaItemData Clone()
		{
			return new PriceFormulaItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60042EB")]
		[Cpp2IlInjected.Address(RVA = "0x287FF00", Offset = "0x287E900", VA = "0x18287FF00", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(PriceFormulaItemData).TypeHandle)
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
											RepeatedField<Types.BaseValueParameters> repeatedField = baseValue_;
											bool flag7 = default(bool);
											if (flag7)
											{
												RepeatedField<Types.TableOfValue> repeatedField2 = tablesOfValues_;
												bool flag8 = default(bool);
												if (flag8)
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
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042EC")]
		[Cpp2IlInjected.Address(RVA = "0x287FDA0", Offset = "0x287E7A0", VA = "0x18287FDA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PriceFormulaItemData other)
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
											RepeatedField<Types.BaseValueParameters> repeatedField = baseValue_;
											RepeatedField<Types.BaseValueParameters> repeatedField2 = other.baseValue_;
											if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
											{
												RepeatedField<Types.TableOfValue> repeatedField3 = tablesOfValues_;
												RepeatedField<Types.TableOfValue> repeatedField4 = other.tablesOfValues_;
												if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
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
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042ED")]
		[Cpp2IlInjected.Address(RVA = "0x2880210", Offset = "0x287EC10", VA = "0x182880210", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00db
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
			int hashCode7 = ((RepeatedField<T>)(object)baseValue_).GetHashCode();
			int hashCode8 = ((RepeatedField<T>)(object)tablesOfValues_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return hashCode8;
		}

		[Cpp2IlInjected.Token(Token = "0x60042EE")]
		[Cpp2IlInjected.Address(RVA = "0x2881C80", Offset = "0x2880680", VA = "0x182881C80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60042EF")]
		[Cpp2IlInjected.Address(RVA = "0x2881CE0", Offset = "0x28806E0", VA = "0x182881CE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_010d
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
			RepeatedField<Types.BaseValueParameters> repeatedField = baseValue_;
			FieldCodec<Types.BaseValueParameters> repeated_baseValue_codec = _repeated_baseValue_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_baseValue_codec);
			RepeatedField<Types.TableOfValue> repeatedField2 = tablesOfValues_;
			FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_tablesOfValues_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60042F0")]
		[Cpp2IlInjected.Address(RVA = "0x287EF10", Offset = "0x287D910", VA = "0x18287EF10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0146
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
			RepeatedField<Types.BaseValueParameters> repeatedField = baseValue_;
			FieldCodec<Types.BaseValueParameters> repeated_baseValue_codec = _repeated_baseValue_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_baseValue_codec);
			RepeatedField<Types.TableOfValue> repeatedField2 = tablesOfValues_;
			FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_tablesOfValues_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num12 = unknownFields.CalculateSize();
				num2 += num12;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60042F1")]
		[Cpp2IlInjected.Address(RVA = "0x28815C0", Offset = "0x287FFC0", VA = "0x1828815C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PriceFormulaItemData other)
		{
			//Discarded unreachable code: IL_00fe
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
				RepeatedField<Types.BaseValueParameters> repeatedField = baseValue_;
				RepeatedField<Types.BaseValueParameters> repeatedField2 = other.baseValue_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<Types.TableOfValue> repeatedField3 = tablesOfValues_;
				RepeatedField<Types.TableOfValue> repeatedField4 = other.tablesOfValues_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042F2")]
		[Cpp2IlInjected.Address(RVA = "0x2881720", Offset = "0x2880120", VA = "0x182881720", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0118
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if (num == 58)
					{
						string text2 = (Equation = input.ReadString());
					}
					if (num == 66)
					{
						RepeatedField<Types.BaseValueParameters> repeatedField = baseValue_;
						FieldCodec<Types.BaseValueParameters> repeated_baseValue_codec = _repeated_baseValue_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_baseValue_codec);
					}
					if (num != 74)
					{
						goto IL_0101;
					}
					RepeatedField<Types.TableOfValue> repeatedField2 = tablesOfValues_;
					FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tablesOfValues_codec);
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 50)
				{
					goto IL_0101;
				}
				string text6 = (ObjectType = input.ReadString());
			}
			string text10 = default(string);
			if ((int)num > 18)
			{
				string text8 = default(string);
				if (num == 26)
				{
					text8 = (DisplayName = input.ReadString());
				}
				if ((long)text8 != 34)
				{
					goto IL_0101;
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
			goto IL_0101;
			IL_0101:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60042F3")]
		[Cpp2IlInjected.Address(RVA = "0x28800A0", Offset = "0x287EAA0", VA = "0x1828800A0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60042F4")]
		[Cpp2IlInjected.Address(RVA = "0x2881980", Offset = "0x2880380", VA = "0x182881980", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0025, IL_002b, IL_0031, IL_0037, IL_003d
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 8)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042F5")]
		[Cpp2IlInjected.Address(RVA = "0x287F1B0", Offset = "0x287DBB0", VA = "0x18287F1B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 8)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60042F8")]
		[Cpp2IlInjected.Address(RVA = "0x2880E30", Offset = "0x287F830", VA = "0x182880E30")]
		private Item GetUsedCurrency(IItemData itemData, Item? forceCurrencyItem)
		{
			//Discarded unreachable code: IL_00fd
			IEnumerable<string> variables;
			int num5 = default(int);
			int num6 = default(int);
			while (true)
			{
				int num = 0;
				Item[] array = new Item[3];
				int num2 = 0;
				Item item = (array[0] = CurrencyItem.SocialCurrencyItem);
				int num3 = 0;
				Item item2 = (array[0] = CurrencyItem.HardCurrencyItem);
				int num4 = 0;
				Item item3 = (array[1] = CurrencyItem.SoftCurrencyItem);
				_parser = (MessageParser<PriceFormulaItemData>)(object)array;
				Equation equation = this.equation;
				if (equation != null)
				{
					string text = equation_;
					if (!(equation.EquationString != text))
					{
						goto IL_0082;
					}
				}
				Equation equation2 = (this.equation = Definitions.Util.Equation.Parse(equation_));
				goto IL_0082;
				IL_0082:
				variables = (IEnumerable<string>)this.equation.get_Variables();
				if (variables == null)
				{
					break;
				}
				_003C_003Ec__DisplayClass77_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass77_0();
				CS_0024_003C_003E8__locals0.variable = (string)(object)CS_0024_003C_003E8__locals0;
				RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
				Func<Types.TableOfValue, bool> func = (Func<Types.TableOfValue, bool>)(object)(Func<T, TResult>)delegate(Types.TableOfValue x)
				{
					//Discarded unreachable code: IL_0014
					string variable = CS_0024_003C_003E8__locals0.variable;
					return string.Equals(x.variableName_, variable);
				};
				Types.TableOfValue tableOfValue = Enumerable.FirstOrDefault<Types.TableOfValue>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				while (tableOfValue == null)
				{
				}
				if ((object)tableOfValue.GetCurrencyForItem(itemData) != null)
				{
					Item[] array2 = currencyPriority;
					Item[] array3 = currencyPriority;
					while (num5 >= num6)
					{
					}
					break;
				}
			}
			if (variables != null)
			{
			}
			return ((IEnumerable<>)(object)currencyPriority).Last<Item>();
		}

		[Cpp2IlInjected.Token(Token = "0x60042F9")]
		[Cpp2IlInjected.Address(RVA = "0x287ED90", Offset = "0x287D790", VA = "0x18287ED90")]
		public CurrencyCost CalculateItemPrice(IItemData itemData, [Optional] Item? forceCurrencyItem)
		{
			//Discarded unreachable code: IL_007e, IL_0084
			//IL_0073: Expected I4, but got O
			//IL_007b: Expected I4, but got O
			evaluatedItem = itemData;
			Item item = (usedCurrencyItem = this.GetUsedCurrency(itemData, (Nullable<>)forceCurrencyItem));
			Equation equation = this.equation;
			if (equation != null)
			{
				string text = equation_;
				if (!(equation.EquationString != text))
				{
					goto IL_004d;
				}
			}
			Equation equation2 = (this.equation = Definitions.Util.Equation.Parse(equation_));
			goto IL_004d;
			IL_004d:
			float num = this.equation.Evaluate(this);
			CurrencyCost currencyCost = new CurrencyCost();
			Item item2 = usedCurrencyItem;
			currencyCost.id_ = (int)item2;
			currencyCost.amount_ = (int)itemData;
			return currencyCost;
		}

		[Cpp2IlInjected.Token(Token = "0x60042FA")]
		[Cpp2IlInjected.Address(RVA = "0x287F320", Offset = "0x287DD20", VA = "0x18287F320", Slot = "20")]
		IItemData IItemData.Clone()
		{
			PriceFormulaItemData priceFormulaItemData = new PriceFormulaItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60042FB")]
		[Cpp2IlInjected.Address(RVA = "0x287F9A0", Offset = "0x287E3A0", VA = "0x18287F9A0", Slot = "22")]
		bool IEquationContext.HasVariableValue(string variableName)
		{
			string text = variableName;
			if (text != null)
			{
				bool flag = string.Equals(text, "IsSetless");
				if (flag)
				{
					return flag;
				}
				if (string.Equals(text, "BaseValue"))
				{
					int count = ((RepeatedField<T>)(object)baseValue_).Count;
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
			if (tableOfValue != null)
			{
				goto IL_0112;
			}
			IItemData itemData = evaluatedItem;
			string[] array2;
			FieldDescriptor fieldDescriptor = default(FieldDescriptor);
			int num2;
			if (tableOfValue != null)
			{
				string text2 = variableName;
				char[] array = new char[1];
				array[0] = '.';
				array2 = text2.Split(array);
				int num = 0;
				num2 = 0;
				int length = array2.Length;
				if (num < length)
				{
					if (tableOfValue != null)
					{
						string text3 = array2[num2];
						if (fieldDescriptor == null)
						{
							goto IL_00e0;
						}
						IFieldAccessor accessor = fieldDescriptor.accessor;
					}
					if (0 == 0)
					{
						goto IL_00e0;
					}
					goto IL_00e6;
				}
				goto IL_00f1;
			}
			goto IL_0118;
			IL_00e0:
			num2++;
			goto IL_00e6;
			IL_00e6:
			if (fieldDescriptor != null)
			{
				num2++;
				goto IL_00f1;
			}
			goto IL_0118;
			IL_00f1:
			if (fieldDescriptor != null)
			{
				string text4 = ((IEnumerable<>)(object)array2).Last<string>();
				FieldDescriptor fieldDescriptor2 = default(FieldDescriptor);
				if (fieldDescriptor2 != null)
				{
					int fieldType = (int)fieldDescriptor2.fieldType;
					bool flag2 = default(bool);
					if (flag2)
					{
					}
				}
			}
			goto IL_0112;
			IL_0118:
			throw new InvalidCastException();
			IL_0112:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60042FC")]
		[Cpp2IlInjected.Address(RVA = "0x287F4A0", Offset = "0x287DEA0", VA = "0x18287F4A0", Slot = "21")]
		float IEquationContext.GetVariableValue(string variableName)
		{
			string variableName2 = variableName;
			if (variableName != null)
			{
				bool flag = string.Equals(variableName, "IsSetless");
				if (flag)
				{
					if (!flag)
					{
						goto IL_005f;
					}
					if (!flag)
					{
						goto IL_0112;
					}
				}
				if (string.Equals(variableName, "BaseValue"))
				{
					RepeatedField<Types.BaseValueParameters> repeatedField = baseValue_;
					Func<Types.BaseValueParameters, bool> func = (Func<Types.BaseValueParameters, bool>)(object)(Func<T, TResult>)delegate(Types.BaseValueParameters x)
					{
						//Discarded unreachable code: IL_0016
						Item item = usedCurrencyItem;
						return (IntPtr)x.currencyItemID_ == (IntPtr)item;
					};
					if (Enumerable.FirstOrDefault<Types.BaseValueParameters>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func) == null)
					{
					}
				}
			}
			goto IL_005f;
			IL_0112:
			throw new NullReferenceException();
			IL_00e2:
			FieldDescriptor fieldDescriptor = default(FieldDescriptor);
			int num;
			if (fieldDescriptor != null)
			{
				num++;
				goto IL_00ed;
			}
			goto IL_0118;
			IL_00ed:
			string[] array = default(string[]);
			if (fieldDescriptor != null)
			{
				string text = ((IEnumerable<>)(object)array).Last<string>();
				FieldDescriptor fieldDescriptor2 = default(FieldDescriptor);
				if (fieldDescriptor2 != null)
				{
					IFieldAccessor accessor = fieldDescriptor2.accessor;
					float num2 = Convert.ToSingle(fieldDescriptor2);
				}
			}
			goto IL_0112;
			IL_00dc:
			num++;
			goto IL_00e2;
			IL_0118:
			throw new InvalidCastException();
			IL_005f:
			RepeatedField<Types.TableOfValue> repeatedField2 = tablesOfValues_;
			Func<Types.TableOfValue, bool> func2 = (Func<Types.TableOfValue, bool>)(object)(Func<T, TResult>)delegate(Types.TableOfValue x)
			{
				//Discarded unreachable code: IL_0014
				string b = variableName2;
				return string.Equals(x.variableName_, b);
			};
			Types.TableOfValue tableOfValue = Enumerable.FirstOrDefault<Types.TableOfValue>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func2);
			IItemData itemData = evaluatedItem;
			if (tableOfValue != null)
			{
				goto IL_0112;
			}
			if (tableOfValue != null)
			{
				(new char[1])[0] = '.';
				num = 0;
				int length = array.Length;
				if (num < length)
				{
					if (tableOfValue != null)
					{
						string text2 = array[num];
						if (fieldDescriptor == null)
						{
							goto IL_00dc;
						}
						IFieldAccessor accessor2 = fieldDescriptor.accessor;
					}
					if (num == 0)
					{
						goto IL_00dc;
					}
					goto IL_00e2;
				}
				goto IL_00ed;
			}
			goto IL_0118;
		}

		[Cpp2IlInjected.Token(Token = "0x60042FD")]
		[Cpp2IlInjected.Address(RVA = "0x2880600", Offset = "0x287F000", VA = "0x182880600")]
		public static CurrencyCost GetItemPrice(Item item, [Optional] Item? forcedCurrencyItem, bool usePriceOverrider = true)
		{
			//Discarded unreachable code: IL_000f
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			return PriceFormulaItemData.GetItemPrice(itemData, (Nullable<>)forcedCurrencyItem, usePriceOverrider);
		}

		[Cpp2IlInjected.Token(Token = "0x60042FE")]
		[Cpp2IlInjected.Address(RVA = "0x28803A0", Offset = "0x287EDA0", VA = "0x1828803A0")]
		public unsafe static CurrencyCost GetItemPrice(IItemData itemData, [Optional] Item? forcedCurrencyItem, bool usePriceOverrider = true)
		{
			//Discarded unreachable code: IL_0039
			CurrencyCost currencyCost = default(CurrencyCost);
			CurrencyCost result = default(CurrencyCost);
			Item item;
			CurrencyCost currencyCost2 = default(CurrencyCost);
			Item item2 = default(Item);
			do
			{
				int num = 0;
				if (!usePriceOverrider || num == 0 || num == 1)
				{
					if (GetPriceFormulaItemData(itemData) != null)
					{
						return currencyCost;
					}
					return result;
				}
				while ((long)currencyCost != 2)
				{
				}
				item = currencyCost2.Item;
			}
			while (!(*(Item*)item2 == *(Item*)item));
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60042FF")]
		[Cpp2IlInjected.Address(RVA = "0x2880D40", Offset = "0x287F740", VA = "0x182880D40")]
		public static PriceFormulaItemData GetPriceFormulaItemData(Item item)
		{
			//Discarded unreachable code: IL_000d
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			return GetPriceFormulaItemData(itemData);
		}

		[Cpp2IlInjected.Token(Token = "0x6004300")]
		[Cpp2IlInjected.Address(RVA = "0x2880710", Offset = "0x287F110", VA = "0x182880710")]
		public unsafe static PriceFormulaItemData GetPriceFormulaItemData(IItemData itemData)
		{
			//Discarded unreachable code: IL_00d2, IL_00d8, IL_00de, IL_00e4, IL_00f0, IL_00f6, IL_00fc, IL_0102, IL_0108, IL_010e
			//IL_0094: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			IEnumerable<PriceFormulaItemData> enumerable = default(IEnumerable<PriceFormulaItemData>);
			uint num2 = default(uint);
			char[] array = default(char[]);
			uint num4 = default(uint);
			uint num5 = default(uint);
			string[] array2 = default(string[]);
			int num7 = default(int);
			Type obj2 = default(Type);
			while (true)
			{
				int num = 0;
				if (itemData != null)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					if (enumerable != null)
					{
						if (num < (int)num2)
						{
							num += num;
							if (num == (int)num2)
							{
								goto IL_0034;
							}
							num++;
						}
						while (enumerable != null)
						{
						}
						array = new char[1];
						goto IL_0034;
					}
					goto IL_00b6;
				}
				goto IL_00c9;
				IL_00b6:
				num++;
				if (enumerable != null)
				{
				}
				if (num != 0)
				{
					continue;
				}
				if (num == 0)
				{
				}
				goto IL_00c9;
				IL_00c9:
				int num3 = 0;
				throw new IndexOutOfRangeException();
				IL_0034:
				num4 += num4;
				array[0] = (char)num5;
				if (Enum.TryParse<ItemType>(array2[0], out *(ItemType*)num) && ItemDatabase.ItemTypeMetaInfo.TryGetItemTypeMetaInfo((ItemType)num, out *(ItemDatabase.ItemTypeMetaInfo*)num) && array2.Length > 1 && array2[1] != "Base" && num != 0)
				{
					string value = array2[1];
					object obj = Enum.Parse((Type)num, value);
					if (obj == null)
					{
					}
					int num6 = 0;
					if (obj == null)
					{
						break;
					}
				}
				if (!((object)num7).Equals((object)obj2))
				{
					continue;
				}
				num++;
				goto IL_00b6;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004301")]
		[Cpp2IlInjected.Address(RVA = "0x2881320", Offset = "0x287FD20", VA = "0x182881320")]
		public string GetVariableFieldValue(IItemData itemData, string variableName)
		{
			//IL_0017: Expected O, but got I4
			int num = 0;
			Item usedCurrency = this.GetUsedCurrency(itemData, (Nullable<>)num);
			string text = variableName;
			Item usedCurrencyItem = usedCurrency;
			if (text != null)
			{
				bool flag = string.Equals(text, "IsSetless");
				if (flag)
				{
					string result = default(string);
					if (flag)
					{
						return result;
					}
					goto IL_00a3;
				}
				if (string.Equals(text, "BaseValue"))
				{
					RepeatedField<Types.BaseValueParameters> repeatedField = baseValue_;
					Func<Types.BaseValueParameters, bool> func = (Func<Types.BaseValueParameters, bool>)(object)(Func<T, TResult>)delegate(Types.BaseValueParameters x)
					{
						//Discarded unreachable code: IL_0011
						Item item = usedCurrencyItem;
						return (IntPtr)x.currencyItemID_ == (IntPtr)item;
					};
					Types.BaseValueParameters baseValueParameters = Enumerable.FirstOrDefault<Types.BaseValueParameters>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
					if (baseValueParameters != null)
					{
						int num2 = baseValueParameters.baseValue_;
					}
				}
			}
			RepeatedField<Types.TableOfValue> repeatedField2 = tablesOfValues_;
			Func<Types.TableOfValue, bool> func2 = (Func<Types.TableOfValue, bool>)(object)(Func<T, TResult>)delegate(Types.TableOfValue x)
			{
				//Discarded unreachable code: IL_0014
				string b = variableName;
				return string.Equals(x.variableName_, b);
			};
			if (Enumerable.FirstOrDefault<Types.TableOfValue>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func2) == null)
			{
				goto IL_00a3;
			}
			goto IL_00a6;
			IL_00a6:
			throw new NullReferenceException();
			IL_00a3:
			int num3 = 0;
			goto IL_00a6;
		}

		[Cpp2IlInjected.Token(Token = "0x6004302")]
		[Cpp2IlInjected.Address(RVA = "0x287F380", Offset = "0x287DD80", VA = "0x18287F380", Slot = "23")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0027
			string text = objectType_;
			if ("Formula.MissionStep: Please select an ObjectType (cannot be empty)" != null)
			{
				context.AddError("Formula.MissionStep: Please select an ObjectType (cannot be empty)");
			}
			Equation equation = Definitions.Util.Equation.Parse(equation_);
		}

		[Cpp2IlInjected.Token(Token = "0x6004303")]
		[Cpp2IlInjected.Address(RVA = "0x2881F50", Offset = "0x2880950", VA = "0x182881F50")]
		static PriceFormulaItemData()
		{
			Func<PriceFormulaItemData> func = default(Func<PriceFormulaItemData>);
			_parser = (MessageParser<PriceFormulaItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.BaseValueParameters> parser = Types.BaseValueParameters._parser;
			uint num = default(uint);
			_parser = (MessageParser<PriceFormulaItemData>)(object)FieldCodec.ForMessage<Types.BaseValueParameters>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.TableOfValue> parser2 = Types.TableOfValue._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<PriceFormulaItemData>)(object)FieldCodec.ForMessage<Types.TableOfValue>(num2, (MessageParser<>)(object)parser2);
			/*Error: Unexpected end of block*/;
		}
	}
}
