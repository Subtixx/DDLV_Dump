using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x200074F")]
	public sealed class ClothingSupportType : IMessage<ClothingSupportType>, IMessage, IEquatable<ClothingSupportType>, IDeepCloneable<ClothingSupportType>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000750")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000751")]
			public sealed class VisualSetup : IMessage<VisualSetup>, IMessage, IEquatable<VisualSetup>, IDeepCloneable<VisualSetup>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400248C")]
				private static readonly MessageParser<VisualSetup> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400248D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400248E")]
				public const int MainPrefabAddressFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400248F")]
				private string mainPrefabAddress_;

				[Cpp2IlInjected.Token(Token = "0x4002490")]
				public const int AltPrefabAddressFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002491")]
				private string altPrefabAddress_;

				[Cpp2IlInjected.Token(Token = "0x1700148B")]
				[DebuggerNonUserCode]
				public static MessageParser<VisualSetup> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60050DB")]
					[Cpp2IlInjected.Address(RVA = "0x9F39C0", Offset = "0x9F23C0", VA = "0x1809F39C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700148C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60050DC")]
					[Cpp2IlInjected.Address(RVA = "0x9F3940", Offset = "0x9F2340", VA = "0x1809F3940")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700148D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60050DD")]
					[Cpp2IlInjected.Address(RVA = "0x9F3A20", Offset = "0x9F2420", VA = "0x1809F3A20", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700148E")]
				[DebuggerNonUserCode]
				public string MainPrefabAddress
				{
					[Cpp2IlInjected.Token(Token = "0x60050E1")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60050E2")]
					[Cpp2IlInjected.Address(RVA = "0x9F3B50", Offset = "0x9F2550", VA = "0x1809F3B50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700148F")]
				[DebuggerNonUserCode]
				public string AltPrefabAddress
				{
					[Cpp2IlInjected.Token(Token = "0x60050E3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60050E4")]
					[Cpp2IlInjected.Address(RVA = "0x9F3AE0", Offset = "0x9F24E0", VA = "0x1809F3AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60050DE")]
				[Cpp2IlInjected.Address(RVA = "0x9F3810", Offset = "0x9F2210", VA = "0x1809F3810")]
				[DebuggerNonUserCode]
				public VisualSetup()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60050DF")]
				[Cpp2IlInjected.Address(RVA = "0x9F3870", Offset = "0x9F2270", VA = "0x1809F3870")]
				[DebuggerNonUserCode]
				public VisualSetup(VisualSetup other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60050E0")]
				[Cpp2IlInjected.Address(RVA = "0x9F3210", Offset = "0x9F1C10", VA = "0x1809F3210", Slot = "10")]
				[DebuggerNonUserCode]
				public VisualSetup Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60050E5")]
				[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F1D10", VA = "0x1809F3310", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60050E6")]
				[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(VisualSetup other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60050E7")]
				[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60050E8")]
				[Cpp2IlInjected.Address(RVA = "0x9F36A0", Offset = "0x9F20A0", VA = "0x1809F36A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60050E9")]
				[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60050EA")]
				[Cpp2IlInjected.Address(RVA = "0x9F3080", Offset = "0x9F1A80", VA = "0x1809F3080", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60050EB")]
				[Cpp2IlInjected.Address(RVA = "0x9F3510", Offset = "0x9F1F10", VA = "0x1809F3510", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(VisualSetup other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60050EC")]
				[Cpp2IlInjected.Address(RVA = "0x9F3460", Offset = "0x9F1E60", VA = "0x1809F3460", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60050ED")]
				[Cpp2IlInjected.Address(RVA = "0x9F33D0", Offset = "0x9F1DD0", VA = "0x1809F33D0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60050EE")]
				[Cpp2IlInjected.Address(RVA = "0x9F3590", Offset = "0x9F1F90", VA = "0x1809F3590", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60050EF")]
				[Cpp2IlInjected.Address(RVA = "0x9F3160", Offset = "0x9F1B60", VA = "0x1809F3160", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000753")]
			public sealed class ClothingParamLength : IMessage<ClothingParamLength>, IMessage, IEquatable<ClothingParamLength>, IDeepCloneable<ClothingParamLength>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002493")]
				private static readonly MessageParser<ClothingParamLength> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002494")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002495")]
				public const int LengthFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002496")]
				private ClothingParameterLength length_;

				[Cpp2IlInjected.Token(Token = "0x4002497")]
				public const int VisualSetupOverrideFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002498")]
				private VisualSetup visualSetupOverride_;

				[Cpp2IlInjected.Token(Token = "0x17001490")]
				[DebuggerNonUserCode]
				public static MessageParser<ClothingParamLength> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60050F4")]
					[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D0EA0", VA = "0x1809D24A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001491")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60050F5")]
					[Cpp2IlInjected.Address(RVA = "0x9D2420", Offset = "0x9D0E20", VA = "0x1809D2420")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001492")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60050F6")]
					[Cpp2IlInjected.Address(RVA = "0x9D2500", Offset = "0x9D0F00", VA = "0x1809D2500", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001493")]
				[DebuggerNonUserCode]
				public ClothingParameterLength Length
				{
					[Cpp2IlInjected.Token(Token = "0x60050FA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(ClothingParameterLength);
					}
					[Cpp2IlInjected.Token(Token = "0x60050FB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001494")]
				[DebuggerNonUserCode]
				public VisualSetup VisualSetupOverride
				{
					[Cpp2IlInjected.Token(Token = "0x60050FC")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60050FD")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60050F7")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ClothingParamLength()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60050F8")]
				[Cpp2IlInjected.Address(RVA = "0x9D22D0", Offset = "0x9D0CD0", VA = "0x1809D22D0")]
				[DebuggerNonUserCode]
				public ClothingParamLength(ClothingParamLength other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60050F9")]
				[Cpp2IlInjected.Address(RVA = "0x9D1B60", Offset = "0x9D0560", VA = "0x1809D1B60", Slot = "10")]
				[DebuggerNonUserCode]
				public ClothingParamLength Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60050FE")]
				[Cpp2IlInjected.Address(RVA = "0x9D1CE0", Offset = "0x9D06E0", VA = "0x1809D1CE0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60050FF")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ClothingParamLength other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005100")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005101")]
				[Cpp2IlInjected.Address(RVA = "0x9D2160", Offset = "0x9D0B60", VA = "0x1809D2160", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005102")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005103")]
				[Cpp2IlInjected.Address(RVA = "0x9D1A90", Offset = "0x9D0490", VA = "0x1809D1A90", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005104")]
				[Cpp2IlInjected.Address(RVA = "0x9D1E60", Offset = "0x9D0860", VA = "0x1809D1E60", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ClothingParamLength other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005105")]
				[Cpp2IlInjected.Address(RVA = "0x9D1FA0", Offset = "0x9D09A0", VA = "0x1809D1FA0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005106")]
				[Cpp2IlInjected.Address(RVA = "0x9D1D90", Offset = "0x9D0790", VA = "0x1809D1D90", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005107")]
				[Cpp2IlInjected.Address(RVA = "0x9D2090", Offset = "0x9D0A90", VA = "0x1809D2090", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005108")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002482")]
		private static readonly MessageParser<ClothingSupportType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002483")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002484")]
		public const int ItemTypesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002485")]
		private static readonly FieldCodec<ClothingItemType> _repeated_itemTypes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002486")]
		private readonly RepeatedField<ClothingItemType> itemTypes_ = (RepeatedField<ClothingItemType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4002487")]
		public const int VisualSetupDefaultFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002488")]
		private Types.VisualSetup visualSetupDefault_;

		[Cpp2IlInjected.Token(Token = "0x4002489")]
		public const int ParamLengthListFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x400248A")]
		private static readonly FieldCodec<Types.ClothingParamLength> _repeated_paramLengthList_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400248B")]
		private readonly RepeatedField<Types.ClothingParamLength> paramLengthList_ = (RepeatedField<Types.ClothingParamLength>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001485")]
		[DebuggerNonUserCode]
		public static MessageParser<ClothingSupportType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60050C5")]
			[Cpp2IlInjected.Address(RVA = "0x2EC32C0", Offset = "0x2EC1CC0", VA = "0x182EC32C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001486")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60050C6")]
			[Cpp2IlInjected.Address(RVA = "0x2EC31F0", Offset = "0x2EC1BF0", VA = "0x182EC31F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001487")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60050C7")]
			[Cpp2IlInjected.Address(RVA = "0x2EC3320", Offset = "0x2EC1D20", VA = "0x182EC3320", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001488")]
		[DebuggerNonUserCode]
		public RepeatedField<ClothingItemType> ItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60050CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemTypes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001489")]
		[DebuggerNonUserCode]
		public Types.VisualSetup VisualSetupDefault
		{
			[Cpp2IlInjected.Token(Token = "0x60050CC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return visualSetupDefault_;
			}
			[Cpp2IlInjected.Token(Token = "0x60050CD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				visualSetupDefault_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700148A")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.ClothingParamLength> ParamLengthList
		{
			[Cpp2IlInjected.Token(Token = "0x60050CE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return paramLengthList_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60050C8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2F80", Offset = "0x2EC1980", VA = "0x182EC2F80")]
		[DebuggerNonUserCode]
		public ClothingSupportType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050C9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3040", Offset = "0x2EC1A40", VA = "0x182EC3040")]
		[DebuggerNonUserCode]
		public ClothingSupportType(ClothingSupportType other)
		{
			//IL_0051: Expected O, but got I4
			RepeatedField<ClothingItemType> repeatedField = (itemTypes_ = (RepeatedField<ClothingItemType>)(object)((RepeatedField<T>)(object)other.itemTypes_).Clone());
			Types.VisualSetup visualSetup = other.visualSetupDefault_;
			if (visualSetup != null)
			{
				Types.VisualSetup visualSetup2 = visualSetup.Clone();
			}
			int num = 0;
			visualSetupDefault_ = (Types.VisualSetup)num;
			RepeatedField<Types.ClothingParamLength> repeatedField2 = (paramLengthList_ = (RepeatedField<Types.ClothingParamLength>)(object)((RepeatedField<T>)(object)other.paramLengthList_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050CA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC21F0", Offset = "0x2EC0BF0", VA = "0x182EC21F0", Slot = "10")]
		[DebuggerNonUserCode]
		public ClothingSupportType Clone()
		{
			//Discarded unreachable code: IL_0080
			//IL_0054: Expected O, but got I4
			ClothingSupportType clothingSupportType = new ClothingSupportType();
			RepeatedField<ClothingItemType> repeatedField = (clothingSupportType.itemTypes_ = (RepeatedField<ClothingItemType>)(object)new RepeatedField<T>());
			RepeatedField<Types.ClothingParamLength> repeatedField2 = (clothingSupportType.paramLengthList_ = (RepeatedField<Types.ClothingParamLength>)(object)new RepeatedField<T>());
			RepeatedField<ClothingItemType> repeatedField3 = (clothingSupportType.itemTypes_ = (RepeatedField<ClothingItemType>)(object)((RepeatedField<T>)(object)itemTypes_).Clone());
			Types.VisualSetup visualSetup = visualSetupDefault_;
			if (visualSetup != null)
			{
				Types.VisualSetup visualSetup2 = visualSetup.Clone();
			}
			int num = 0;
			clothingSupportType.visualSetupDefault_ = (Types.VisualSetup)num;
			RepeatedField<Types.ClothingParamLength> repeatedField4 = (clothingSupportType.paramLengthList_ = (RepeatedField<Types.ClothingParamLength>)(object)((RepeatedField<T>)(object)paramLengthList_).Clone());
			UnknownFieldSet unknownFieldSet = (clothingSupportType._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return clothingSupportType;
		}

		[Cpp2IlInjected.Token(Token = "0x60050CF")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2490", Offset = "0x2EC0E90", VA = "0x182EC2490", Slot = "0")]
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
				RepeatedField<ClothingItemType> repeatedField = itemTypes_;
				bool flag = default(bool);
				if (flag && object.Equals(visualSetupDefault_, other))
				{
					RepeatedField<Types.ClothingParamLength> repeatedField2 = paramLengthList_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050D0")]
		[Cpp2IlInjected.Address(RVA = "0x2EC23C0", Offset = "0x2EC0DC0", VA = "0x182EC23C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ClothingSupportType other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ClothingItemType> repeatedField = itemTypes_;
				RepeatedField<ClothingItemType> repeatedField2 = other.itemTypes_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					Types.VisualSetup objB = other.visualSetupDefault_;
					if (object.Equals(visualSetupDefault_, objB))
					{
						RepeatedField<Types.ClothingParamLength> repeatedField3 = paramLengthList_;
						RepeatedField<Types.ClothingParamLength> repeatedField4 = other.paramLengthList_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050D1")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2650", Offset = "0x2EC1050", VA = "0x182EC2650", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0046
			int hashCode = ((RepeatedField<T>)(object)itemTypes_).GetHashCode();
			Types.VisualSetup visualSetup = visualSetupDefault_;
			if (visualSetup != null)
			{
				int hashCode2 = visualSetup.GetHashCode();
			}
			int hashCode3 = ((RepeatedField<T>)(object)paramLengthList_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60050D2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2B00", Offset = "0x2EC1500", VA = "0x182EC2B00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60050D3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2B60", Offset = "0x2EC1560", VA = "0x182EC2B60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005b
			RepeatedField<ClothingItemType> repeatedField = itemTypes_;
			FieldCodec<ClothingItemType> repeated_itemTypes_codec = _repeated_itemTypes_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemTypes_codec);
			if ((long)visualSetupDefault_ != 0)
			{
				Types.VisualSetup value = visualSetupDefault_;
				output.WriteMessage(value);
			}
			RepeatedField<Types.ClothingParamLength> repeatedField2 = paramLengthList_;
			FieldCodec<Types.ClothingParamLength> repeated_paramLengthList_codec = _repeated_paramLengthList_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_paramLengthList_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60050D4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2010", Offset = "0x2EC0A10", VA = "0x182EC2010", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0073
			RepeatedField<ClothingItemType> repeatedField = itemTypes_;
			FieldCodec<ClothingItemType> repeated_itemTypes_codec = _repeated_itemTypes_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemTypes_codec);
			Types.VisualSetup visualSetup = visualSetupDefault_;
			if (visualSetup != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(visualSetup);
				num2++;
				num += num2;
			}
			RepeatedField<Types.ClothingParamLength> repeatedField2 = paramLengthList_;
			FieldCodec<Types.ClothingParamLength> repeated_paramLengthList_codec = _repeated_paramLengthList_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_paramLengthList_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60050D5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC26E0", Offset = "0x2EC10E0", VA = "0x182EC26E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ClothingSupportType other)
		{
			//Discarded unreachable code: IL_0088
			if (other == null)
			{
				return;
			}
			RepeatedField<ClothingItemType> repeatedField = itemTypes_;
			RepeatedField<ClothingItemType> repeatedField2 = other.itemTypes_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.visualSetupDefault_ != 0)
			{
				Types.VisualSetup visualSetup = visualSetupDefault_;
				if (visualSetup == null)
				{
					Types.VisualSetup visualSetup2 = (visualSetupDefault_ = new Types.VisualSetup());
				}
				Types.VisualSetup other2 = other.visualSetupDefault_;
				visualSetup.MergeFrom(other2);
			}
			RepeatedField<Types.ClothingParamLength> repeatedField3 = paramLengthList_;
			RepeatedField<Types.ClothingParamLength> repeatedField4 = other.paramLengthList_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60050D6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2800", Offset = "0x2EC1200", VA = "0x182EC2800", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0093
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 10)
			{
				if (num == 18)
				{
					Types.VisualSetup visualSetup = visualSetupDefault_;
					if (visualSetup == null)
					{
						Types.VisualSetup visualSetup2 = (visualSetupDefault_ = new Types.VisualSetup());
					}
					input.ReadMessage(visualSetup);
				}
				if (num != 26)
				{
					goto IL_0063;
				}
				RepeatedField<Types.ClothingParamLength> repeatedField = paramLengthList_;
				FieldCodec<Types.ClothingParamLength> repeated_paramLengthList_codec = _repeated_paramLengthList_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_paramLengthList_codec);
			}
			num += 4294967288u;
			if (num != 4294967293u)
			{
				goto IL_0063;
			}
			goto IL_0079;
			IL_0079:
			RepeatedField<ClothingItemType> repeatedField2 = itemTypes_;
			FieldCodec<ClothingItemType> repeated_itemTypes_codec = _repeated_itemTypes_codec;
			((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemTypes_codec);
			return;
			IL_0063:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			goto IL_0079;
		}

		[Cpp2IlInjected.Token(Token = "0x60050D7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC25B0", Offset = "0x2EC0FB0", VA = "0x182EC25B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.ClothingParamLength> repeatedField = paramLengthList_;
				Types.VisualSetup visualSetup = visualSetupDefault_;
				RepeatedField<ClothingItemType> repeatedField2 = itemTypes_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60050D8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC29D0", Offset = "0x2EC13D0", VA = "0x182EC29D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num == 0 || num != 1)
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						visualSetupDefault_ = (Types.VisualSetup)num2;
						return;
					}
					goto IL_0038;
				}
			}
			else
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			goto IL_0038;
			IL_0038:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050D9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2160", Offset = "0x2EC0B60", VA = "0x182EC2160", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				}
				return;
			}
			RepeatedField<ClothingItemType> repeatedField = itemTypes_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60050DA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2CB0", Offset = "0x2EC16B0", VA = "0x182EC2CB0")]
		static ClothingSupportType()
		{
			Func<ClothingSupportType> func = default(Func<ClothingSupportType>);
			MessageParser<ClothingSupportType> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<ClothingSupportType>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<ClothingItemType, int> func2 = (Func<ClothingItemType, int>)(object)(Func<T, TResult>)((ClothingItemType x) => (int)x);
			Func<int, ClothingItemType> func3 = (Func<int, ClothingItemType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<ClothingSupportType>)(object)FieldCodec.ForEnum<ClothingItemType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			MessageParser<Types.ClothingParamLength> parser = Types.ClothingParamLength._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<ClothingSupportType>)(object)FieldCodec.ForMessage<Types.ClothingParamLength>(num2, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
