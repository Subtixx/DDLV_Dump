using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000879")]
	public sealed class FishingData : IActivityLockCondition, IMessage<FishingData>, IMessage, IEquatable<FishingData>, IDeepCloneable<FishingData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200087A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200087B")]
			public sealed class FishRarityData : IMessage<FishRarityData>, IMessage, IEquatable<FishRarityData>, IDeepCloneable<FishRarityData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40029F1")]
				private static readonly MessageParser<FishRarityData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40029F2")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40029F3")]
				public const int FishRarityFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40029F4")]
				private FishRarity fishRarity_;

				[Cpp2IlInjected.Token(Token = "0x40029F5")]
				public const int WeightFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40029F6")]
				private int weight_;

				[Cpp2IlInjected.Token(Token = "0x170017E4")]
				[DebuggerNonUserCode]
				public static MessageParser<FishRarityData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005EE5")]
					[Cpp2IlInjected.Address(RVA = "0x293C440", Offset = "0x293AE40", VA = "0x18293C440")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017E5")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005EE6")]
					[Cpp2IlInjected.Address(RVA = "0x293C3C0", Offset = "0x293ADC0", VA = "0x18293C3C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017E6")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005EE7")]
					[Cpp2IlInjected.Address(RVA = "0x293C4A0", Offset = "0x293AEA0", VA = "0x18293C4A0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017E7")]
				[DebuggerNonUserCode]
				public FishRarity FishRarity
				{
					[Cpp2IlInjected.Token(Token = "0x6005EEB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(FishRarity);
					}
					[Cpp2IlInjected.Token(Token = "0x6005EEC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017E8")]
				[DebuggerNonUserCode]
				public int Weight
				{
					[Cpp2IlInjected.Token(Token = "0x6005EED")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6005EEE")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005EE8")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public FishRarityData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005EE9")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public FishRarityData(FishRarityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005EEA")]
				[Cpp2IlInjected.Address(RVA = "0x293BF70", Offset = "0x293A970", VA = "0x18293BF70", Slot = "10")]
				[DebuggerNonUserCode]
				public FishRarityData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005EEF")]
				[Cpp2IlInjected.Address(RVA = "0x293C000", Offset = "0x293AA00", VA = "0x18293C000", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF0")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FishRarityData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF1")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF2")]
				[Cpp2IlInjected.Address(RVA = "0x293C250", Offset = "0x293AC50", VA = "0x18293C250", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF3")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF4")]
				[Cpp2IlInjected.Address(RVA = "0x293BEA0", Offset = "0x293A8A0", VA = "0x18293BEA0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF5")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FishRarityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF6")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF7")]
				[Cpp2IlInjected.Address(RVA = "0x293C090", Offset = "0x293AA90", VA = "0x18293C090", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF8")]
				[Cpp2IlInjected.Address(RVA = "0x293C180", Offset = "0x293AB80", VA = "0x18293C180", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005EF9")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200087D")]
			public sealed class FishRippleRarityData : IMessage<FishRippleRarityData>, IMessage, IEquatable<FishRippleRarityData>, IDeepCloneable<FishRippleRarityData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40029F8")]
				private static readonly MessageParser<FishRippleRarityData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40029F9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40029FA")]
				public const int RippleRarityFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40029FB")]
				private FishRippleRarity rippleRarity_;

				[Cpp2IlInjected.Token(Token = "0x40029FC")]
				public const int WeightFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40029FD")]
				private int weight_;

				[Cpp2IlInjected.Token(Token = "0x170017E9")]
				[DebuggerNonUserCode]
				public static MessageParser<FishRippleRarityData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005EFE")]
					[Cpp2IlInjected.Address(RVA = "0x293E260", Offset = "0x293CC60", VA = "0x18293E260")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017EA")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005EFF")]
					[Cpp2IlInjected.Address(RVA = "0x293E1E0", Offset = "0x293CBE0", VA = "0x18293E1E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017EB")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005F00")]
					[Cpp2IlInjected.Address(RVA = "0x293E2C0", Offset = "0x293CCC0", VA = "0x18293E2C0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017EC")]
				[DebuggerNonUserCode]
				public FishRippleRarity RippleRarity
				{
					[Cpp2IlInjected.Token(Token = "0x6005F04")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(FishRippleRarity);
					}
					[Cpp2IlInjected.Token(Token = "0x6005F05")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017ED")]
				[DebuggerNonUserCode]
				public int Weight
				{
					[Cpp2IlInjected.Token(Token = "0x6005F06")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6005F07")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005F01")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public FishRippleRarityData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F02")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public FishRippleRarityData(FishRippleRarityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F03")]
				[Cpp2IlInjected.Address(RVA = "0x293DD90", Offset = "0x293C790", VA = "0x18293DD90", Slot = "10")]
				[DebuggerNonUserCode]
				public FishRippleRarityData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005F08")]
				[Cpp2IlInjected.Address(RVA = "0x293DE20", Offset = "0x293C820", VA = "0x18293DE20", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F09")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FishRippleRarityData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F0A")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F0B")]
				[Cpp2IlInjected.Address(RVA = "0x293E070", Offset = "0x293CA70", VA = "0x18293E070", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005F0C")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F0D")]
				[Cpp2IlInjected.Address(RVA = "0x293DCC0", Offset = "0x293C6C0", VA = "0x18293DCC0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F0E")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FishRippleRarityData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F0F")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F10")]
				[Cpp2IlInjected.Address(RVA = "0x293DEB0", Offset = "0x293C8B0", VA = "0x18293DEB0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005F11")]
				[Cpp2IlInjected.Address(RVA = "0x293DFA0", Offset = "0x293C9A0", VA = "0x18293DFA0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F12")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200087F")]
			public sealed class FishRippleContentRarities : IMessage<FishRippleContentRarities>, IMessage, IEquatable<FishRippleContentRarities>, IDeepCloneable<FishRippleContentRarities>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40029FF")]
				private static readonly MessageParser<FishRippleContentRarities> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002A00")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002A01")]
				public const int RippleRarityFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002A02")]
				private FishRippleRarity rippleRarity_;

				[Cpp2IlInjected.Token(Token = "0x4002A03")]
				public const int DataFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4002A04")]
				private static readonly FieldCodec<FishRarityData> _repeated_data_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002A05")]
				private readonly RepeatedField<FishRarityData> data_;

				[Cpp2IlInjected.Token(Token = "0x170017EE")]
				[DebuggerNonUserCode]
				public static MessageParser<FishRippleContentRarities> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005F17")]
					[Cpp2IlInjected.Address(RVA = "0x293D1C0", Offset = "0x293BBC0", VA = "0x18293D1C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017EF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005F18")]
					[Cpp2IlInjected.Address(RVA = "0x293D140", Offset = "0x293BB40", VA = "0x18293D140")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017F0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005F19")]
					[Cpp2IlInjected.Address(RVA = "0x293D220", Offset = "0x293BC20", VA = "0x18293D220", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017F1")]
				[DebuggerNonUserCode]
				public FishRippleRarity RippleRarity
				{
					[Cpp2IlInjected.Token(Token = "0x6005F1D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(FishRippleRarity);
					}
					[Cpp2IlInjected.Token(Token = "0x6005F1E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017F2")]
				[DebuggerNonUserCode]
				public RepeatedField<FishRarityData> Data
				{
					[Cpp2IlInjected.Token(Token = "0x6005F1F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005F1A")]
				[Cpp2IlInjected.Address(RVA = "0x293CFC0", Offset = "0x293B9C0", VA = "0x18293CFC0")]
				[DebuggerNonUserCode]
				public FishRippleContentRarities()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F1B")]
				[Cpp2IlInjected.Address(RVA = "0x293D040", Offset = "0x293BA40", VA = "0x18293D040")]
				[DebuggerNonUserCode]
				public FishRippleContentRarities(FishRippleContentRarities other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F1C")]
				[Cpp2IlInjected.Address(RVA = "0x293C6C0", Offset = "0x293B0C0", VA = "0x18293C6C0", Slot = "10")]
				[DebuggerNonUserCode]
				public FishRippleContentRarities Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005F20")]
				[Cpp2IlInjected.Address(RVA = "0x293C890", Offset = "0x293B290", VA = "0x18293C890", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F21")]
				[Cpp2IlInjected.Address(RVA = "0x293C7F0", Offset = "0x293B1F0", VA = "0x18293C7F0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FishRippleContentRarities other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F22")]
				[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F23")]
				[Cpp2IlInjected.Address(RVA = "0x293CCA0", Offset = "0x293B6A0", VA = "0x18293CCA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005F24")]
				[Cpp2IlInjected.Address(RVA = "0x293CD00", Offset = "0x293B700", VA = "0x18293CD00", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F25")]
				[Cpp2IlInjected.Address(RVA = "0x293C560", Offset = "0x293AF60", VA = "0x18293C560", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F26")]
				[Cpp2IlInjected.Address(RVA = "0x293CB40", Offset = "0x293B540", VA = "0x18293CB40", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FishRippleContentRarities other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F27")]
				[Cpp2IlInjected.Address(RVA = "0x293CA40", Offset = "0x293B440", VA = "0x18293CA40", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F28")]
				[Cpp2IlInjected.Address(RVA = "0x293C970", Offset = "0x293B370", VA = "0x18293C970", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005F29")]
				[Cpp2IlInjected.Address(RVA = "0x293CBD0", Offset = "0x293B5D0", VA = "0x18293CBD0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F2A")]
				[Cpp2IlInjected.Address(RVA = "0x293C650", Offset = "0x293B050", VA = "0x18293C650", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000881")]
			public sealed class FishRippleDifficulty : IMessage<FishRippleDifficulty>, IMessage, IEquatable<FishRippleDifficulty>, IDeepCloneable<FishRippleDifficulty>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002A07")]
				private static readonly MessageParser<FishRippleDifficulty> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002A08")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002A09")]
				public const int RippleRarityFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002A0A")]
				private FishRippleRarity rippleRarity_;

				[Cpp2IlInjected.Token(Token = "0x4002A0B")]
				public const int DifficultyAddressFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002A0C")]
				private string difficultyAddress_;

				[Cpp2IlInjected.Token(Token = "0x170017F3")]
				[DebuggerNonUserCode]
				public static MessageParser<FishRippleDifficulty> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005F2F")]
					[Cpp2IlInjected.Address(RVA = "0x293DB30", Offset = "0x293C530", VA = "0x18293DB30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017F4")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005F30")]
					[Cpp2IlInjected.Address(RVA = "0x293DAB0", Offset = "0x293C4B0", VA = "0x18293DAB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017F5")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005F31")]
					[Cpp2IlInjected.Address(RVA = "0x293DB90", Offset = "0x293C590", VA = "0x18293DB90", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017F6")]
				[DebuggerNonUserCode]
				public FishRippleRarity RippleRarity
				{
					[Cpp2IlInjected.Token(Token = "0x6005F35")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(FishRippleRarity);
					}
					[Cpp2IlInjected.Token(Token = "0x6005F36")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017F7")]
				[DebuggerNonUserCode]
				public string DifficultyAddress
				{
					[Cpp2IlInjected.Token(Token = "0x6005F37")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6005F38")]
					[Cpp2IlInjected.Address(RVA = "0x293DC50", Offset = "0x293C650", VA = "0x18293DC50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005F32")]
				[Cpp2IlInjected.Address(RVA = "0x293DA60", Offset = "0x293C460", VA = "0x18293DA60")]
				[DebuggerNonUserCode]
				public FishRippleDifficulty()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F33")]
				[Cpp2IlInjected.Address(RVA = "0x293D9C0", Offset = "0x293C3C0", VA = "0x18293D9C0")]
				[DebuggerNonUserCode]
				public FishRippleDifficulty(FishRippleDifficulty other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F34")]
				[Cpp2IlInjected.Address(RVA = "0x293D420", Offset = "0x293BE20", VA = "0x18293D420", Slot = "10")]
				[DebuggerNonUserCode]
				public FishRippleDifficulty Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005F39")]
				[Cpp2IlInjected.Address(RVA = "0x293D4F0", Offset = "0x293BEF0", VA = "0x18293D4F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F3A")]
				[Cpp2IlInjected.Address(RVA = "0x1708900", Offset = "0x1707300", VA = "0x181708900", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FishRippleDifficulty other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F3B")]
				[Cpp2IlInjected.Address(RVA = "0x1708AF0", Offset = "0x17074F0", VA = "0x181708AF0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F3C")]
				[Cpp2IlInjected.Address(RVA = "0x293D850", Offset = "0x293C250", VA = "0x18293D850", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005F3D")]
				[Cpp2IlInjected.Address(RVA = "0x1708DC0", Offset = "0x17077C0", VA = "0x181708DC0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F3E")]
				[Cpp2IlInjected.Address(RVA = "0x293D2E0", Offset = "0x293BCE0", VA = "0x18293D2E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005F3F")]
				[Cpp2IlInjected.Address(RVA = "0x293D710", Offset = "0x293C110", VA = "0x18293D710", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FishRippleDifficulty other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F40")]
				[Cpp2IlInjected.Address(RVA = "0x293D670", Offset = "0x293C070", VA = "0x18293D670", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F41")]
				[Cpp2IlInjected.Address(RVA = "0x293D5A0", Offset = "0x293BFA0", VA = "0x18293D5A0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005F42")]
				[Cpp2IlInjected.Address(RVA = "0x293D780", Offset = "0x293C180", VA = "0x18293D780", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005F43")]
				[Cpp2IlInjected.Address(RVA = "0x293D3B0", Offset = "0x293BDB0", VA = "0x18293D3B0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40029E4")]
		private static readonly MessageParser<FishingData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40029E5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40029E6")]
		public const int UnlockBuildingItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40029E7")]
		private int unlockBuildingItemID_;

		[Cpp2IlInjected.Token(Token = "0x40029E8")]
		public const int RippleRarityDataFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40029E9")]
		private static readonly FieldCodec<Types.FishRippleRarityData> _repeated_rippleRarityData_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40029EA")]
		private readonly RepeatedField<Types.FishRippleRarityData> rippleRarityData_ = (RepeatedField<Types.FishRippleRarityData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40029EB")]
		public const int RippleContentRaritiesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40029EC")]
		private static readonly FieldCodec<Types.FishRippleContentRarities> _repeated_rippleContentRarities_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40029ED")]
		private readonly RepeatedField<Types.FishRippleContentRarities> rippleContentRarities_ = (RepeatedField<Types.FishRippleContentRarities>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40029EE")]
		public const int RippleDifficultiesFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40029EF")]
		private static readonly FieldCodec<Types.FishRippleDifficulty> _repeated_rippleDifficulties_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40029F0")]
		private readonly RepeatedField<Types.FishRippleDifficulty> rippleDifficulties_ = (RepeatedField<Types.FishRippleDifficulty>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170017DC")]
		public Item UnlockBuildingItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005ECB")]
			[Cpp2IlInjected.Address(RVA = "0x357EF80", Offset = "0x357D980", VA = "0x18357EF80", Slot = "4")]
			get
			{
				long num = Convert.ToInt64((uint)unlockBuildingItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DD")]
		[DebuggerNonUserCode]
		public static MessageParser<FishingData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005ECE")]
			[Cpp2IlInjected.Address(RVA = "0x357EF20", Offset = "0x357D920", VA = "0x18357EF20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005ECF")]
			[Cpp2IlInjected.Address(RVA = "0x357EE50", Offset = "0x357D850", VA = "0x18357EE50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005ED0")]
			[Cpp2IlInjected.Address(RVA = "0x357EFE0", Offset = "0x357D9E0", VA = "0x18357EFE0", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E0")]
		[DebuggerNonUserCode]
		public int UnlockBuildingItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6005ED4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return unlockBuildingItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005ED5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				unlockBuildingItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E1")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.FishRippleRarityData> RippleRarityData
		{
			[Cpp2IlInjected.Token(Token = "0x6005ED6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return rippleRarityData_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E2")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.FishRippleContentRarities> RippleContentRarities
		{
			[Cpp2IlInjected.Token(Token = "0x6005ED7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return rippleContentRarities_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E3")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.FishRippleDifficulty> RippleDifficulties
		{
			[Cpp2IlInjected.Token(Token = "0x6005ED8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return rippleDifficulties_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005ECC")]
		[Cpp2IlInjected.Address(RVA = "0x357E040", Offset = "0x357CA40", VA = "0x18357E040")]
		public IEnumerable<Types.FishRarityData> GetRarityContents(FishRippleRarity rarity)
		{
			RepeatedField<Types.FishRippleContentRarities> repeatedField = rippleContentRarities_;
			Func<Types.FishRippleContentRarities, bool> func = (Func<Types.FishRippleContentRarities, bool>)(object)(Func<T, TResult>)delegate(Types.FishRippleContentRarities rarityContentData)
			{
				//Discarded unreachable code: IL_0011
				FishRippleRarity fishRippleRarity = rarity;
				return rarityContentData.rippleRarity_ == fishRippleRarity;
			};
			RepeatedField<Types.FishRarityData> data_ = Enumerable.First<Types.FishRippleContentRarities>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func).data_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005ECD")]
		[Cpp2IlInjected.Address(RVA = "0x357E120", Offset = "0x357CB20", VA = "0x18357E120")]
		public string GetRarityDifficultyAddress(FishRippleRarity rarity)
		{
			//Discarded unreachable code: IL_0030
			RepeatedField<Types.FishRippleDifficulty> repeatedField = rippleDifficulties_;
			Func<Types.FishRippleDifficulty, bool> func = (Func<Types.FishRippleDifficulty, bool>)(object)(Func<T, TResult>)delegate(Types.FishRippleDifficulty rarityDifficulty)
			{
				//Discarded unreachable code: IL_0011
				FishRippleRarity fishRippleRarity = rarity;
				return rarityDifficulty.rippleRarity_ == fishRippleRarity;
			};
			return Enumerable.First<Types.FishRippleDifficulty>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func).difficultyAddress_;
		}

		[Cpp2IlInjected.Token(Token = "0x6005ED1")]
		[Cpp2IlInjected.Address(RVA = "0x357ED50", Offset = "0x357D750", VA = "0x18357ED50")]
		[DebuggerNonUserCode]
		public FishingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005ED2")]
		[Cpp2IlInjected.Address(RVA = "0x357EB50", Offset = "0x357D550", VA = "0x18357EB50")]
		[DebuggerNonUserCode]
		public FishingData(FishingData other)
		{
			int num = (unlockBuildingItemID_ = other.unlockBuildingItemID_);
			RepeatedField<Types.FishRippleRarityData> repeatedField = (rippleRarityData_ = (RepeatedField<Types.FishRippleRarityData>)(object)((RepeatedField<T>)(object)other.rippleRarityData_).Clone());
			RepeatedField<Types.FishRippleContentRarities> repeatedField2 = (rippleContentRarities_ = (RepeatedField<Types.FishRippleContentRarities>)(object)((RepeatedField<T>)(object)other.rippleContentRarities_).Clone());
			RepeatedField<Types.FishRippleDifficulty> repeatedField3 = (rippleDifficulties_ = (RepeatedField<Types.FishRippleDifficulty>)(object)((RepeatedField<T>)(object)other.rippleDifficulties_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005ED3")]
		[Cpp2IlInjected.Address(RVA = "0x357DBD0", Offset = "0x357C5D0", VA = "0x18357DBD0", Slot = "11")]
		[DebuggerNonUserCode]
		public FishingData Clone()
		{
			return new FishingData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005ED9")]
		[Cpp2IlInjected.Address(RVA = "0x357DC30", Offset = "0x357C630", VA = "0x18357DC30", Slot = "0")]
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
				if ((IntPtr)unlockBuildingItemID_ == (IntPtr)typeof(FishingData).TypeHandle)
				{
					RepeatedField<Types.FishRippleRarityData> repeatedField = rippleRarityData_;
					bool flag = default(bool);
					if (flag)
					{
						RepeatedField<Types.FishRippleContentRarities> repeatedField2 = rippleContentRarities_;
						bool flag2 = default(bool);
						if (flag2)
						{
							RepeatedField<Types.FishRippleDifficulty> repeatedField3 = rippleDifficulties_;
							bool flag3 = default(bool);
							if (flag3)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005EDA")]
		[Cpp2IlInjected.Address(RVA = "0x357DD70", Offset = "0x357C770", VA = "0x18357DD70", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(FishingData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.unlockBuildingItemID_;
				if (unlockBuildingItemID_ == num)
				{
					RepeatedField<Types.FishRippleRarityData> repeatedField = rippleRarityData_;
					RepeatedField<Types.FishRippleRarityData> repeatedField2 = other.rippleRarityData_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						RepeatedField<Types.FishRippleContentRarities> repeatedField3 = rippleContentRarities_;
						RepeatedField<Types.FishRippleContentRarities> repeatedField4 = other.rippleContentRarities_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							RepeatedField<Types.FishRippleDifficulty> repeatedField5 = rippleDifficulties_;
							RepeatedField<Types.FishRippleDifficulty> repeatedField6 = other.rippleDifficulties_;
							if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005EDB")]
		[Cpp2IlInjected.Address(RVA = "0x357DF60", Offset = "0x357C960", VA = "0x18357DF60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0049
			if (unlockBuildingItemID_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)rippleRarityData_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)rippleContentRarities_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)rippleDifficulties_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode3;
		}

		[Cpp2IlInjected.Token(Token = "0x6005EDC")]
		[Cpp2IlInjected.Address(RVA = "0x357E640", Offset = "0x357D040", VA = "0x18357E640", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005EDD")]
		[Cpp2IlInjected.Address(RVA = "0x357E6A0", Offset = "0x357D0A0", VA = "0x18357E6A0", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0072
			if (unlockBuildingItemID_ != 0)
			{
				int value = unlockBuildingItemID_;
				output.WriteInt32(value);
			}
			RepeatedField<Types.FishRippleRarityData> repeatedField = rippleRarityData_;
			FieldCodec<Types.FishRippleRarityData> repeated_rippleRarityData_codec = _repeated_rippleRarityData_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rippleRarityData_codec);
			RepeatedField<Types.FishRippleContentRarities> repeatedField2 = rippleContentRarities_;
			FieldCodec<Types.FishRippleContentRarities> repeated_rippleContentRarities_codec = _repeated_rippleContentRarities_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_rippleContentRarities_codec);
			RepeatedField<Types.FishRippleDifficulty> repeatedField3 = rippleDifficulties_;
			FieldCodec<Types.FishRippleDifficulty> repeated_rippleDifficulties_codec = _repeated_rippleDifficulties_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_rippleDifficulties_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005EDE")]
		[Cpp2IlInjected.Address(RVA = "0x357D9D0", Offset = "0x357C3D0", VA = "0x18357D9D0", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_007d
			int num = unlockBuildingItemID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			RepeatedField<Types.FishRippleRarityData> repeatedField = rippleRarityData_;
			FieldCodec<Types.FishRippleRarityData> repeated_rippleRarityData_codec = _repeated_rippleRarityData_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rippleRarityData_codec);
			RepeatedField<Types.FishRippleContentRarities> repeatedField2 = rippleContentRarities_;
			FieldCodec<Types.FishRippleContentRarities> repeated_rippleContentRarities_codec = _repeated_rippleContentRarities_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_rippleContentRarities_codec);
			RepeatedField<Types.FishRippleDifficulty> repeatedField3 = rippleDifficulties_;
			FieldCodec<Types.FishRippleDifficulty> repeated_rippleDifficulties_codec = _repeated_rippleDifficulties_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_rippleDifficulties_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005EDF")]
		[Cpp2IlInjected.Address(RVA = "0x357E200", Offset = "0x357CC00", VA = "0x18357E200", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingData other)
		{
			//Discarded unreachable code: IL_007b
			if (other != null)
			{
				int num = other.unlockBuildingItemID_;
				if (num != 0)
				{
					unlockBuildingItemID_ = num;
				}
				RepeatedField<Types.FishRippleRarityData> repeatedField = rippleRarityData_;
				RepeatedField<Types.FishRippleRarityData> repeatedField2 = other.rippleRarityData_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<Types.FishRippleContentRarities> repeatedField3 = rippleContentRarities_;
				RepeatedField<Types.FishRippleContentRarities> repeatedField4 = other.rippleContentRarities_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<Types.FishRippleDifficulty> repeatedField5 = rippleDifficulties_;
				RepeatedField<Types.FishRippleDifficulty> repeatedField6 = other.rippleDifficulties_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005EE0")]
		[Cpp2IlInjected.Address(RVA = "0x357E2D0", Offset = "0x357CCD0", VA = "0x18357E2D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0098
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					RepeatedField<Types.FishRippleContentRarities> repeatedField = rippleContentRarities_;
					FieldCodec<Types.FishRippleContentRarities> repeated_rippleContentRarities_codec = _repeated_rippleContentRarities_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rippleContentRarities_codec);
				}
				if (num != 34)
				{
					goto IL_0081;
				}
				RepeatedField<Types.FishRippleDifficulty> repeatedField2 = rippleDifficulties_;
				FieldCodec<Types.FishRippleDifficulty> repeated_rippleDifficulties_codec = _repeated_rippleDifficulties_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rippleDifficulties_codec);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (unlockBuildingItemID_ = input.ReadInt32());
			}
			if (num2 == 18)
			{
				RepeatedField<Types.FishRippleRarityData> repeatedField3 = rippleRarityData_;
				FieldCodec<Types.FishRippleRarityData> repeated_rippleRarityData_codec = _repeated_rippleRarityData_codec;
				((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rippleRarityData_codec);
			}
			goto IL_0081;
			IL_0081:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005EE1")]
		[Cpp2IlInjected.Address(RVA = "0x357DE70", Offset = "0x357C870", VA = "0x18357DE70", Slot = "12")]
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
						if (num != 1)
						{
							goto IL_0031;
						}
						RepeatedField<Types.FishRippleDifficulty> repeatedField = rippleDifficulties_;
					}
					RepeatedField<Types.FishRippleContentRarities> repeatedField2 = rippleContentRarities_;
				}
				RepeatedField<Types.FishRippleRarityData> repeatedField3 = rippleRarityData_;
			}
			int num2 = unlockBuildingItemID_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005EE2")]
		[Cpp2IlInjected.Address(RVA = "0x357E4C0", Offset = "0x357CEC0", VA = "0x18357E4C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_001c
			//IL_001b: Expected I4, but got O
			while (true)
			{
				int num = fieldNumber - 1;
				if (num == 0)
				{
					break;
				}
				if (num != 0)
				{
					switch (num)
					{
					case 0:
						continue;
					case 1:
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						/*Error: Unexpected end of block*/;
					}
					}
					break;
				}
			}
			object obj = default(object);
			unlockBuildingItemID_ = (int)obj;
		}

		[Cpp2IlInjected.Token(Token = "0x6005EE3")]
		[Cpp2IlInjected.Address(RVA = "0x357DB40", Offset = "0x357C540", VA = "0x18357DB40", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0025
			//IL_0024: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0 && num != 1)
				{
					return;
				}
				RepeatedField<Types.FishRippleRarityData> repeatedField = rippleRarityData_;
			}
			unlockBuildingItemID_ = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005EE4")]
		[Cpp2IlInjected.Address(RVA = "0x357E800", Offset = "0x357D200", VA = "0x18357E800")]
		static FishingData()
		{
			Func<FishingData> func = default(Func<FishingData>);
			_parser = (MessageParser<FishingData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.FishRippleRarityData> parser = Types.FishRippleRarityData._parser;
			uint num = default(uint);
			_parser = (MessageParser<FishingData>)(object)FieldCodec.ForMessage<Types.FishRippleRarityData>(num, (MessageParser<>)(object)parser);
			MessageParser<Types.FishRippleContentRarities> parser2 = Types.FishRippleContentRarities._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<FishingData>)(object)FieldCodec.ForMessage<Types.FishRippleContentRarities>(num2, (MessageParser<>)(object)parser2);
			MessageParser<Types.FishRippleDifficulty> parser3 = Types.FishRippleDifficulty._parser;
			uint num3 = default(uint);
			_parser = (MessageParser<FishingData>)(object)FieldCodec.ForMessage<Types.FishRippleDifficulty>(num3, (MessageParser<>)(object)parser3);
			/*Error: Unexpected end of block*/;
		}
	}
}
