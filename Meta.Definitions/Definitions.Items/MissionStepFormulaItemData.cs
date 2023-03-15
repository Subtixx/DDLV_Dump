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
	[Cpp2IlInjected.Token(Token = "0x2000574")]
	public sealed class MissionStepFormulaItemData : IMessage<MissionStepFormulaItemData>, IMessage, IEquatable<MissionStepFormulaItemData>, IDeepCloneable<MissionStepFormulaItemData>, IMessageFieldAccessor, IItemData, IEquationContext, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000575")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000576")]
			public sealed class TableOfValue : IMessage<TableOfValue>, IMessage, IEquatable<TableOfValue>, IDeepCloneable<TableOfValue>, IMessageFieldAccessor, IDataValidation
			{
				[Cpp2IlInjected.Token(Token = "0x2000577")]
				[DebuggerNonUserCode]
				public static class Types
				{
					[Cpp2IlInjected.Token(Token = "0x2000578")]
					public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>, IMessageFieldAccessor
					{
						[Cpp2IlInjected.Token(Token = "0x4001DA9")]
						private static readonly MessageParser<Value> _parser;

						[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
						[Cpp2IlInjected.Token(Token = "0x4001DAA")]
						private UnknownFieldSet _unknownFields;

						[Cpp2IlInjected.Token(Token = "0x4001DAB")]
						public const int KeyFieldNumber = 1;

						[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
						[Cpp2IlInjected.Token(Token = "0x4001DAC")]
						private string key_;

						[Cpp2IlInjected.Token(Token = "0x4001DAD")]
						public const int EquationValueFieldNumber = 2;

						[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
						[Cpp2IlInjected.Token(Token = "0x4001DAE")]
						private float equationValue_;

						[Cpp2IlInjected.Token(Token = "0x17001194")]
						[DebuggerNonUserCode]
						public static MessageParser<Value> Parser
						{
							[Cpp2IlInjected.Token(Token = "0x600441E")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E7B0", Offset = "0x3F9D1B0", VA = "0x183F9E7B0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17001195")]
						[DebuggerNonUserCode]
						public static MessageDescriptor Descriptor
						{
							[Cpp2IlInjected.Token(Token = "0x600441F")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E4F0", Offset = "0x3F9CEF0", VA = "0x183F9E4F0")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17001196")]
						[DebuggerNonUserCode]
						private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
						{
							[Cpp2IlInjected.Token(Token = "0x6004420")]
							[Cpp2IlInjected.Address(RVA = "0x3F9E9F0", Offset = "0x3F9D3F0", VA = "0x183F9E9F0", Slot = "8")]
							get
							{
								return null;
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17001197")]
						[DebuggerNonUserCode]
						public string Key
						{
							[Cpp2IlInjected.Token(Token = "0x6004424")]
							[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
							get
							{
								return null;
							}
							[Cpp2IlInjected.Token(Token = "0x6004425")]
							[Cpp2IlInjected.Address(RVA = "0x3F9EB70", Offset = "0x3F9D570", VA = "0x183F9EB70")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x17001198")]
						[DebuggerNonUserCode]
						public float EquationValue
						{
							[Cpp2IlInjected.Token(Token = "0x6004426")]
							[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
							get
							{
								return default(float);
							}
							[Cpp2IlInjected.Token(Token = "0x6004427")]
							[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
							set
							{
							}
						}

						[Cpp2IlInjected.Token(Token = "0x6004421")]
						[Cpp2IlInjected.Address(RVA = "0x3F9E450", Offset = "0x3F9CE50", VA = "0x183F9E450")]
						[DebuggerNonUserCode]
						public Value()
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004422")]
						[Cpp2IlInjected.Address(RVA = "0x3F9E3B0", Offset = "0x3F9CDB0", VA = "0x183F9E3B0")]
						[DebuggerNonUserCode]
						public Value(Value other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004423")]
						[Cpp2IlInjected.Address(RVA = "0x3F9BF40", Offset = "0x3F9A940", VA = "0x183F9BF40", Slot = "10")]
						[DebuggerNonUserCode]
						public Value Clone()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6004428")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C840", Offset = "0x3F9B240", VA = "0x183F9C840", Slot = "0")]
						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x6004429")]
						[Cpp2IlInjected.Address(RVA = "0x3F9C240", Offset = "0x3F9AC40", VA = "0x183F9C240", Slot = "9")]
						[DebuggerNonUserCode]
						public bool Equals(Value other)
						{
							return default(bool);
						}

						[Cpp2IlInjected.Token(Token = "0x600442A")]
						[Cpp2IlInjected.Address(RVA = "0x3F9CE40", Offset = "0x3F9B840", VA = "0x183F9CE40", Slot = "2")]
						[DebuggerNonUserCode]
						public override int GetHashCode()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600442B")]
						[Cpp2IlInjected.Address(RVA = "0x3F9DB80", Offset = "0x3F9C580", VA = "0x183F9DB80", Slot = "3")]
						[DebuggerNonUserCode]
						public override string ToString()
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x600442C")]
						[Cpp2IlInjected.Address(RVA = "0x3F9DBE0", Offset = "0x3F9C5E0", VA = "0x183F9DBE0", Slot = "6")]
						[DebuggerNonUserCode]
						public void WriteTo(CodedOutputStream output)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600442D")]
						[Cpp2IlInjected.Address(RVA = "0x3F9BB00", Offset = "0x3F9A500", VA = "0x183F9BB00", Slot = "7")]
						[DebuggerNonUserCode]
						public int CalculateSize()
						{
							return default(int);
						}

						[Cpp2IlInjected.Token(Token = "0x600442E")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D1D0", Offset = "0x3F9BBD0", VA = "0x183F9D1D0", Slot = "4")]
						[DebuggerNonUserCode]
						public void MergeFrom(Value other)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x600442F")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D470", Offset = "0x3F9BE70", VA = "0x183F9D470", Slot = "5")]
						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004430")]
						[Cpp2IlInjected.Address(RVA = "0x3F9CA60", Offset = "0x3F9B460", VA = "0x183F9CA60", Slot = "11")]
						[DebuggerNonUserCode]
						public object GetFieldValue(int fieldNumber)
						{
							return null;
						}

						[Cpp2IlInjected.Token(Token = "0x6004431")]
						[Cpp2IlInjected.Address(RVA = "0x3F9D710", Offset = "0x3F9C110", VA = "0x183F9D710", Slot = "12")]
						[DebuggerNonUserCode]
						public void SetFieldValue(int fieldNumber, object value)
						{
						}

						[Cpp2IlInjected.Token(Token = "0x6004432")]
						[Cpp2IlInjected.Address(RVA = "0x3F9BDC0", Offset = "0x3F9A7C0", VA = "0x183F9BDC0", Slot = "13")]
						[DebuggerNonUserCode]
						public void ClearFieldValue(int fieldNumber)
						{
						}
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4001D9E")]
				private static readonly MessageParser<TableOfValue> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001D9F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001DA0")]
				public const int VariableNameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001DA1")]
				private string variableName_;

				[Cpp2IlInjected.Token(Token = "0x4001DA2")]
				public const int FieldNameFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001DA3")]
				private string fieldName_;

				[Cpp2IlInjected.Token(Token = "0x4001DA4")]
				public const int DefaultValueFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001DA5")]
				private float defaultValue_;

				[Cpp2IlInjected.Token(Token = "0x4001DA6")]
				public const int ValuesFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4001DA7")]
				private static readonly FieldCodec<Types.Value> _repeated_values_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4001DA8")]
				private readonly RepeatedField<Types.Value> values_;

				[Cpp2IlInjected.Token(Token = "0x1700118D")]
				[DebuggerNonUserCode]
				public static MessageParser<TableOfValue> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004403")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6420", Offset = "0x2FF4E20", VA = "0x182FF6420")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700118E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004404")]
					[Cpp2IlInjected.Address(RVA = "0x2FF62C0", Offset = "0x2FF4CC0", VA = "0x182FF62C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700118F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004405")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6480", Offset = "0x2FF4E80", VA = "0x182FF6480", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001190")]
				[DebuggerNonUserCode]
				public string VariableName
				{
					[Cpp2IlInjected.Token(Token = "0x6004409")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600440A")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6750", Offset = "0x2FF5150", VA = "0x182FF6750")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001191")]
				[DebuggerNonUserCode]
				public string FieldName
				{
					[Cpp2IlInjected.Token(Token = "0x600440B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600440C")]
					[Cpp2IlInjected.Address(RVA = "0x2FF6600", Offset = "0x2FF5000", VA = "0x182FF6600")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001192")]
				[DebuggerNonUserCode]
				public float DefaultValue
				{
					[Cpp2IlInjected.Token(Token = "0x600440D")]
					[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
					get
					{
						return default(float);
					}
					[Cpp2IlInjected.Token(Token = "0x600440E")]
					[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001193")]
				[DebuggerNonUserCode]
				public RepeatedField<Types.Value> Values
				{
					[Cpp2IlInjected.Token(Token = "0x600440F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004406")]
				[Cpp2IlInjected.Address(RVA = "0x2FF5E90", Offset = "0x2FF4890", VA = "0x182FF5E90")]
				[DebuggerNonUserCode]
				public TableOfValue()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004407")]
				[Cpp2IlInjected.Address(RVA = "0x2FF5FF0", Offset = "0x2FF49F0", VA = "0x182FF5FF0")]
				[DebuggerNonUserCode]
				public TableOfValue(TableOfValue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004408")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3160", Offset = "0x2FF1B60", VA = "0x182FF3160", Slot = "10")]
				[DebuggerNonUserCode]
				public TableOfValue Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004410")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3500", Offset = "0x2FF1F00", VA = "0x182FF3500", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004411")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3670", Offset = "0x2FF2070", VA = "0x182FF3670", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TableOfValue other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004412")]
				[Cpp2IlInjected.Address(RVA = "0x2FF4B30", Offset = "0x2FF3530", VA = "0x182FF4B30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004413")]
				[Cpp2IlInjected.Address(RVA = "0x2FF5740", Offset = "0x2FF4140", VA = "0x182FF5740", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004414")]
				[Cpp2IlInjected.Address(RVA = "0x2FF5800", Offset = "0x2FF4200", VA = "0x182FF5800", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004415")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2E70", Offset = "0x2FF1870", VA = "0x182FF2E70", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004416")]
				[Cpp2IlInjected.Address(RVA = "0x2FF5320", Offset = "0x2FF3D20", VA = "0x182FF5320", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TableOfValue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004417")]
				[Cpp2IlInjected.Address(RVA = "0x2FF51C0", Offset = "0x2FF3BC0", VA = "0x182FF51C0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004418")]
				[Cpp2IlInjected.Address(RVA = "0x2FF4A40", Offset = "0x2FF3440", VA = "0x182FF4A40", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004419")]
				[Cpp2IlInjected.Address(RVA = "0x2FF53F0", Offset = "0x2FF3DF0", VA = "0x182FF53F0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600441A")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2FC0", Offset = "0x2FF19C0", VA = "0x182FF2FC0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600441B")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3B40", Offset = "0x2FF2540", VA = "0x182FF3B40")]
				public float GetEquationValue(string key)
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600441C")]
				[Cpp2IlInjected.Address(RVA = "0x2FF3480", Offset = "0x2FF1E80", VA = "0x182FF3480", Slot = "14")]
				public void DataValidation(DataValidation.Context context)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001D89")]
		private static readonly MessageParser<MissionStepFormulaItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001D8A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001D8B")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001D8C")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001D8D")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D8E")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D8F")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D90")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D91")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001D92")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D93")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D94")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D95")]
		public const int MissionStepTypeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001D96")]
		private int missionStepType_;

		[Cpp2IlInjected.Token(Token = "0x4001D97")]
		public const int EquationFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001D98")]
		private string equation_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001D99")]
		public const int TablesOfValuesFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4001D9A")]
		private static readonly FieldCodec<Types.TableOfValue> _repeated_tablesOfValues_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001D9B")]
		private readonly RepeatedField<Types.TableOfValue> tablesOfValues_ = (RepeatedField<Types.TableOfValue>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001D9C")]
		private Equation equation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001D9D")]
		private IEquationKeyProvider evaluatedMissionStep;

		[Cpp2IlInjected.Token(Token = "0x1700117F")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionStepFormulaItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60043DA")]
			[Cpp2IlInjected.Address(RVA = "0x29EB7D0", Offset = "0x29EA1D0", VA = "0x1829EB7D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001180")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60043DB")]
			[Cpp2IlInjected.Address(RVA = "0x29EB6A0", Offset = "0x29EA0A0", VA = "0x1829EB6A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001181")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60043DC")]
			[Cpp2IlInjected.Address(RVA = "0x29EB890", Offset = "0x29EA290", VA = "0x1829EB890", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001182")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60043E0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043E1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001183")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60043E2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043E3")]
			[Cpp2IlInjected.Address(RVA = "0x29EBAF0", Offset = "0x29EA4F0", VA = "0x1829EBAF0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001184")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60043E4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043E5")]
			[Cpp2IlInjected.Address(RVA = "0x29EB9A0", Offset = "0x29EA3A0", VA = "0x1829EB9A0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001185")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60043E6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043E7")]
			[Cpp2IlInjected.Address(RVA = "0x29EBA80", Offset = "0x29EA480", VA = "0x1829EBA80")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001186")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60043E8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043E9")]
			[Cpp2IlInjected.Address(RVA = "0x29EBB60", Offset = "0x29EA560", VA = "0x1829EBB60")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001187")]
		[DebuggerNonUserCode]
		public int MissionStepType
		{
			[Cpp2IlInjected.Token(Token = "0x60043EA")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return missionStepType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043EB")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				missionStepType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001188")]
		[DebuggerNonUserCode]
		public string Equation
		{
			[Cpp2IlInjected.Token(Token = "0x60043EC")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return equation_;
			}
			[Cpp2IlInjected.Token(Token = "0x60043ED")]
			[Cpp2IlInjected.Address(RVA = "0x29EBA10", Offset = "0x29EA410", VA = "0x1829EBA10")]
			set
			{
				string text = (equation_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001189")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.TableOfValue> TablesOfValues
		{
			[Cpp2IlInjected.Token(Token = "0x60043EE")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return tablesOfValues_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700118A")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60043FA")]
			[Cpp2IlInjected.Address(RVA = "0x29EB770", Offset = "0x29EA170", VA = "0x1829EB770", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700118B")]
		private Equation TheEquation
		{
			[Cpp2IlInjected.Token(Token = "0x60043FB")]
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

		[Cpp2IlInjected.Token(Token = "0x1700118C")]
		public MissionObjectiveData.CustomStepOneofCase CustomStepCase
		{
			[Cpp2IlInjected.Token(Token = "0x60043FE")]
			[Cpp2IlInjected.Address(RVA = "0x29EB5B0", Offset = "0x29E9FB0", VA = "0x1829EB5B0")]
			get
			{
				Type typeFromHandle = typeof(MissionObjectiveData.CustomStepOneofCase);
				int value = missionStepType_;
				object obj = Enum.ToObject(typeFromHandle, value);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60043DD")]
		[Cpp2IlInjected.Address(RVA = "0x29EB4C0", Offset = "0x29E9EC0", VA = "0x1829EB4C0")]
		[DebuggerNonUserCode]
		public MissionStepFormulaItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60043DE")]
		[Cpp2IlInjected.Address(RVA = "0x29EB2E0", Offset = "0x29E9CE0", VA = "0x1829EB2E0")]
		[DebuggerNonUserCode]
		public MissionStepFormulaItemData(MissionStepFormulaItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (missionStepType_ = other.missionStepType_);
			string text5 = (equation_ = other.equation_);
			RepeatedField<Types.TableOfValue> repeatedField = (tablesOfValues_ = (RepeatedField<Types.TableOfValue>)(object)((RepeatedField<T>)(object)other.tablesOfValues_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60043DF")]
		[Cpp2IlInjected.Address(RVA = "0x29E9E00", Offset = "0x29E8800", VA = "0x1829E9E00", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionStepFormulaItemData Clone()
		{
			return new MissionStepFormulaItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60043EF")]
		[Cpp2IlInjected.Address(RVA = "0x29EA040", Offset = "0x29E8A40", VA = "0x1829EA040", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(MissionStepFormulaItemData).TypeHandle)
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
								if (!flag4 && missionStepType_ == (flag4 ? 1 : 0))
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

		[Cpp2IlInjected.Token(Token = "0x60043F0")]
		[Cpp2IlInjected.Address(RVA = "0x29EA1A0", Offset = "0x29E8BA0", VA = "0x1829EA1A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionStepFormulaItemData other)
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
									int num2 = other.missionStepType_;
									if (missionStepType_ == num2)
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
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60043F1")]
		[Cpp2IlInjected.Address(RVA = "0x29EA410", Offset = "0x29E8E10", VA = "0x1829EA410", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b7
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
			if (missionStepType_ != 0)
			{
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

		[Cpp2IlInjected.Token(Token = "0x60043F2")]
		[Cpp2IlInjected.Address(RVA = "0x29EAE80", Offset = "0x29E9880", VA = "0x1829EAE80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60043F3")]
		[Cpp2IlInjected.Address(RVA = "0x29EAEE0", Offset = "0x29E98E0", VA = "0x1829EAEE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ef
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
			if (missionStepType_ != 0)
			{
				int value6 = missionStepType_;
				output.WriteInt32(value6);
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

		[Cpp2IlInjected.Token(Token = "0x60043F4")]
		[Cpp2IlInjected.Address(RVA = "0x29E9A50", Offset = "0x29E8450", VA = "0x1829E9A50", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_012c
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
			int num8 = missionStepType_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			string text5 = equation_;
			if (text5.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text5);
				num10++;
				num2 += num10;
			}
			RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
			FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
			int num11 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tablesOfValues_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num11;
			if (unknownFields != null)
			{
				int num12 = unknownFields.CalculateSize();
				num2 += num12;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60043F5")]
		[Cpp2IlInjected.Address(RVA = "0x29EAAA0", Offset = "0x29E94A0", VA = "0x1829EAAA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionStepFormulaItemData other)
		{
			//Discarded unreachable code: IL_00e0
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
				int num2 = other.missionStepType_;
				if (num2 != 0)
				{
					missionStepType_ = num2;
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

		[Cpp2IlInjected.Token(Token = "0x60043F6")]
		[Cpp2IlInjected.Address(RVA = "0x29EA8B0", Offset = "0x29E92B0", VA = "0x1829EA8B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00f6
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 48)
				{
					if (num == 58)
					{
						string text2 = (Equation = input.ReadString());
					}
					if (num != 66)
					{
						goto IL_00df;
					}
					RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
					FieldCodec<Types.TableOfValue> repeated_tablesOfValues_codec = _repeated_tablesOfValues_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tablesOfValues_codec);
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 48)
				{
					goto IL_00df;
				}
				int num2 = (missionStepType_ = input.ReadInt32());
			}
			string text8 = default(string);
			if ((int)num > 18)
			{
				string text6 = default(string);
				if (num == 26)
				{
					text6 = (DisplayName = input.ReadString());
				}
				if ((long)text6 != 34)
				{
					goto IL_00df;
				}
				text8 = (IconAddress = input.ReadString());
			}
			int num3 = default(int);
			if ((long)text8 == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_00df;
			IL_00df:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60043F7")]
		[Cpp2IlInjected.Address(RVA = "0x29EA2C0", Offset = "0x29E8CC0", VA = "0x1829EA2C0", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60043F8")]
		[Cpp2IlInjected.Address(RVA = "0x29EABD0", Offset = "0x29E95D0", VA = "0x1829EABD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_001f, IL_0027, IL_0028, IL_0039, IL_003f, IL_0045, IL_004b, IL_0051
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 7)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60043F9")]
		[Cpp2IlInjected.Address(RVA = "0x29E9CB0", Offset = "0x29E86B0", VA = "0x1829E9CB0", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x60043FC")]
		[Cpp2IlInjected.Address(RVA = "0x29E9980", Offset = "0x29E8380", VA = "0x1829E9980")]
		public float CalculateScore(IEquationKeyProvider missionStep)
		{
			//Discarded unreachable code: IL_004a
			int num = 0;
			evaluatedMissionStep = missionStep;
			Equation equation = this.equation;
			if (equation != null)
			{
				string text = equation_;
				if (!(equation.EquationString != text))
				{
					goto IL_003d;
				}
			}
			Equation equation2 = (this.equation = Definitions.Util.Equation.Parse(equation_));
			goto IL_003d;
			IL_003d:
			return this.equation.Evaluate(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60043FD")]
		[Cpp2IlInjected.Address(RVA = "0x29E9E00", Offset = "0x29E8800", VA = "0x1829E9E00", Slot = "20")]
		IItemData IItemData.Clone()
		{
			MissionStepFormulaItemData missionStepFormulaItemData = new MissionStepFormulaItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60043FF")]
		[Cpp2IlInjected.Address(RVA = "0x29EA7A0", Offset = "0x29E91A0", VA = "0x1829EA7A0", Slot = "22")]
		public bool HasVariableValue(string variableName)
		{
			if ((long)evaluatedMissionStep != 0)
			{
				RepeatedField<Types.TableOfValue> repeatedField = tablesOfValues_;
				Func<Types.TableOfValue, bool> func = (Func<Types.TableOfValue, bool>)(object)(Func<T, TResult>)delegate(Types.TableOfValue x)
				{
					//Discarded unreachable code: IL_0014
					string b = variableName;
					return string.Equals(x.variableName_, b);
				};
				return Enumerable.FirstOrDefault<Types.TableOfValue>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func) != null;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004400")]
		[Cpp2IlInjected.Address(RVA = "0x29EA560", Offset = "0x29E8F60", VA = "0x1829EA560", Slot = "21")]
		public float GetVariableValue(string variableName)
		{
			//Discarded unreachable code: IL_0069
			if ((long)evaluatedMissionStep != 0)
			{
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
					IEquationKeyProvider equationKeyProvider = evaluatedMissionStep;
					string fieldName_ = tableOfValue.fieldName_;
					int num = 0;
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					if (tableOfValue == null)
					{
						return tableOfValue.defaultValue_;
					}
					tableOfValue = (Types.TableOfValue)(object)((object)tableOfValue + (object)tableOfValue);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004401")]
		[Cpp2IlInjected.Address(RVA = "0x29E9E60", Offset = "0x29E8860", VA = "0x1829E9E60", Slot = "23")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_003d
			//IL_0022: Expected O, but got I4
			if (CustomStepCase != 0)
			{
				Type typeFromHandle = typeof(MissionObjectiveData.CustomStepOneofCase);
				MissionObjectiveData.CustomStepOneofCase customStepCase = CustomStepCase;
				if (Enum.IsDefined(typeFromHandle, customStepCase))
				{
					goto IL_0030;
				}
			}
			context.AddError("Formula.MissionStep: Please select a valid StepType (cannot be None)");
			goto IL_0030;
			IL_0030:
			Equation equation = Definitions.Util.Equation.Parse(equation_);
		}

		[Cpp2IlInjected.Token(Token = "0x6004402")]
		[Cpp2IlInjected.Address(RVA = "0x29EB110", Offset = "0x29E9B10", VA = "0x1829EB110")]
		static MissionStepFormulaItemData()
		{
			Func<MissionStepFormulaItemData> func = default(Func<MissionStepFormulaItemData>);
			_parser = (MessageParser<MissionStepFormulaItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.TableOfValue> parser = Types.TableOfValue._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionStepFormulaItemData>)(object)FieldCodec.ForMessage<Types.TableOfValue>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
