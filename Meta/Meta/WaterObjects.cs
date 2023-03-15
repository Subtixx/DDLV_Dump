using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000329")]
	public sealed class WaterObjects : IMessage<WaterObjects>, IMessage, IEquatable<WaterObjects>, IDeepCloneable<WaterObjects>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200032A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200032B")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40009D6")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40009D7")]
				[OriginalName("NoWateringTool")]
				NoWateringTool,
				[Cpp2IlInjected.Token(Token = "0x40009D8")]
				[OriginalName("NotEnoughMana")]
				NotEnoughMana,
				[Cpp2IlInjected.Token(Token = "0x40009D9")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x40009DA")]
				[OriginalName("InvalidObjectsToWater")]
				InvalidObjectsToWater
			}

			[Cpp2IlInjected.Token(Token = "0x200032C")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40009DB")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40009DC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40009DD")]
				public const int GridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40009DE")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x40009DF")]
				public const int ObjectsToWaterFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x40009E0")]
				private static readonly FieldCodec<ObjectToWater> _repeated_objectsToWater_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40009E1")]
				private readonly RepeatedField<ObjectToWater> objectsToWater_;

				[Cpp2IlInjected.Token(Token = "0x170005B5")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001FA6")]
					[Cpp2IlInjected.Address(RVA = "0xACB6F0", Offset = "0xACA0F0", VA = "0x180ACB6F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005B6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001FA7")]
					[Cpp2IlInjected.Address(RVA = "0xACB4B0", Offset = "0xAC9EB0", VA = "0x180ACB4B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005B7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001FA8")]
					[Cpp2IlInjected.Address(RVA = "0xACB750", Offset = "0xACA150", VA = "0x180ACB750", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005B8")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6001FAC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001FAD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005B9")]
				[DebuggerNonUserCode]
				public RepeatedField<ObjectToWater> ObjectsToWater
				{
					[Cpp2IlInjected.Token(Token = "0x6001FAE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001FA9")]
				[Cpp2IlInjected.Address(RVA = "0xACB280", Offset = "0xAC9C80", VA = "0x180ACB280")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FAA")]
				[Cpp2IlInjected.Address(RVA = "0xACB420", Offset = "0xAC9E20", VA = "0x180ACB420")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FAB")]
				[Cpp2IlInjected.Address(RVA = "0xAC8CA0", Offset = "0xAC76A0", VA = "0x180AC8CA0", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FAF")]
				[Cpp2IlInjected.Address(RVA = "0xAC8E10", Offset = "0xAC7810", VA = "0x180AC8E10", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB0")]
				[Cpp2IlInjected.Address(RVA = "0xAC8FD0", Offset = "0xAC79D0", VA = "0x180AC8FD0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB1")]
				[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB2")]
				[Cpp2IlInjected.Address(RVA = "0xAC9BE0", Offset = "0xAC85E0", VA = "0x180AC9BE0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB3")]
				[Cpp2IlInjected.Address(RVA = "0xACABA0", Offset = "0xAC95A0", VA = "0x180ACABA0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB4")]
				[Cpp2IlInjected.Address(RVA = "0xAC8860", Offset = "0xAC7260", VA = "0x180AC8860", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB5")]
				[Cpp2IlInjected.Address(RVA = "0xAC9580", Offset = "0xAC7F80", VA = "0x180AC9580", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB6")]
				[Cpp2IlInjected.Address(RVA = "0xAC97C0", Offset = "0xAC81C0", VA = "0x180AC97C0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB7")]
				[Cpp2IlInjected.Address(RVA = "0xAC9380", Offset = "0xAC7D80", VA = "0x180AC9380", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB8")]
				[Cpp2IlInjected.Address(RVA = "0xAC9B10", Offset = "0xAC8510", VA = "0x180AC9B10", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FB9")]
				[Cpp2IlInjected.Address(RVA = "0xAC8B00", Offset = "0xAC7500", VA = "0x180AC8B00", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FBA")]
				[Cpp2IlInjected.Address(RVA = "0xAC9D00", Offset = "0xAC8700", VA = "0x180AC9D00", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200032E")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40009E3")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40009E4")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40009E5")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40009E6")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40009E7")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40009E8")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170005BA")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001FBF")]
					[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE0C0", VA = "0x180ACF6C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005BB")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001FC0")]
					[Cpp2IlInjected.Address(RVA = "0xACF560", Offset = "0xACDF60", VA = "0x180ACF560")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005BC")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001FC1")]
					[Cpp2IlInjected.Address(RVA = "0xACF840", Offset = "0xACE240", VA = "0x180ACF840", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005BD")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001FC5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001FC6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005BE")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001FC7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001FC8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005BF")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001FD4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001FD5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001FC2")]
				[Cpp2IlInjected.Address(RVA = "0xACF360", Offset = "0xACDD60", VA = "0x180ACF360")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FC3")]
				[Cpp2IlInjected.Address(RVA = "0xACF1E0", Offset = "0xACDBE0", VA = "0x180ACF1E0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FC4")]
				[Cpp2IlInjected.Address(RVA = "0xACC8A0", Offset = "0xACB2A0", VA = "0x180ACC8A0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FC9")]
				[Cpp2IlInjected.Address(RVA = "0xACCCA0", Offset = "0xACB6A0", VA = "0x180ACCCA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FCA")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FCB")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FCC")]
				[Cpp2IlInjected.Address(RVA = "0xACDAF0", Offset = "0xACC4F0", VA = "0x180ACDAF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FCD")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FCE")]
				[Cpp2IlInjected.Address(RVA = "0xACC7D0", Offset = "0xACB1D0", VA = "0x180ACC7D0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FCF")]
				[Cpp2IlInjected.Address(RVA = "0xACD720", Offset = "0xACC120", VA = "0x180ACD720", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FD0")]
				[Cpp2IlInjected.Address(RVA = "0xACD400", Offset = "0xACBE00", VA = "0x180ACD400", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FD1")]
				[Cpp2IlInjected.Address(RVA = "0xACD330", Offset = "0xACBD30", VA = "0x180ACD330", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FD2")]
				[Cpp2IlInjected.Address(RVA = "0xACD9C0", Offset = "0xACC3C0", VA = "0x180ACD9C0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FD3")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FD6")]
				[Cpp2IlInjected.Address(RVA = "0xACB990", Offset = "0xACA390", VA = "0x180ACB990", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000332")]
			public sealed class ObjectToWater : IMessage<ObjectToWater>, IMessage, IEquatable<ObjectToWater>, IDeepCloneable<ObjectToWater>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40009EE")]
				private static readonly MessageParser<ObjectToWater> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40009EF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40009F0")]
				public const int GridObjectIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40009F1")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x40009F2")]
				public const int SlotIndexFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x40009F3")]
				private static readonly FieldCodec<int?> _single_slotIndex_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40009F4")]
				private int? slotIndex_;

				[Cpp2IlInjected.Token(Token = "0x170005C0")]
				[DebuggerNonUserCode]
				public static MessageParser<ObjectToWater> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001FE0")]
					[Cpp2IlInjected.Address(RVA = "0xAC8670", Offset = "0xAC7070", VA = "0x180AC8670")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005C1")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001FE1")]
					[Cpp2IlInjected.Address(RVA = "0xAC85F0", Offset = "0xAC6FF0", VA = "0x180AC85F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005C2")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001FE2")]
					[Cpp2IlInjected.Address(RVA = "0xAC86E0", Offset = "0xAC70E0", VA = "0x180AC86E0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005C3")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6001FE6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6001FE7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005C4")]
				[DebuggerNonUserCode]
				public int? SlotIndex
				{
					[Cpp2IlInjected.Token(Token = "0x6001FE8")]
					[Cpp2IlInjected.Address(RVA = "0xAC86D0", Offset = "0xAC70D0", VA = "0x180AC86D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001FE9")]
					[Cpp2IlInjected.Address(RVA = "0xAC87A0", Offset = "0xAC71A0", VA = "0x180AC87A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ObjectToWater()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE4")]
				[Cpp2IlInjected.Address(RVA = "0xAC8590", Offset = "0xAC6F90", VA = "0x180AC8590")]
				[DebuggerNonUserCode]
				public ObjectToWater(ObjectToWater other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE5")]
				[Cpp2IlInjected.Address(RVA = "0xAC7C40", Offset = "0xAC6640", VA = "0x180AC7C40", Slot = "10")]
				[DebuggerNonUserCode]
				public ObjectToWater Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FEA")]
				[Cpp2IlInjected.Address(RVA = "0xAC7CD0", Offset = "0xAC66D0", VA = "0x180AC7CD0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FEB")]
				[Cpp2IlInjected.Address(RVA = "0xAC7DD0", Offset = "0xAC67D0", VA = "0x180AC7DD0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ObjectToWater other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FEC")]
				[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6970", VA = "0x180AC7F70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FED")]
				[Cpp2IlInjected.Address(RVA = "0xAC82F0", Offset = "0xAC6CF0", VA = "0x180AC82F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FEE")]
				[Cpp2IlInjected.Address(RVA = "0xAC8350", Offset = "0xAC6D50", VA = "0x180AC8350", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FEF")]
				[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6520", VA = "0x180AC7B20", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FF0")]
				[Cpp2IlInjected.Address(RVA = "0xAC8160", Offset = "0xAC6B60", VA = "0x180AC8160", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ObjectToWater other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FF1")]
				[Cpp2IlInjected.Address(RVA = "0xAC8030", Offset = "0xAC6A30", VA = "0x180AC8030", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FF2")]
				[Cpp2IlInjected.Address(RVA = "0xAC7E80", Offset = "0xAC6880", VA = "0x180AC7E80", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FF3")]
				[Cpp2IlInjected.Address(RVA = "0xAC8200", Offset = "0xAC6C00", VA = "0x180AC8200", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FF4")]
				[Cpp2IlInjected.Address(RVA = "0xAC7C20", Offset = "0xAC6620", VA = "0x180AC7C20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40009D3")]
		private static readonly MessageParser<WaterObjects> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009D4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170005B2")]
		[DebuggerNonUserCode]
		public static MessageParser<WaterObjects> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001F91")]
			[Cpp2IlInjected.Address(RVA = "0x15E55D0", Offset = "0x15E3FD0", VA = "0x1815E55D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F92")]
			[Cpp2IlInjected.Address(RVA = "0x15E5500", Offset = "0x15E3F00", VA = "0x1815E5500")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005B4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001F93")]
			[Cpp2IlInjected.Address(RVA = "0x15E5630", Offset = "0x15E4030", VA = "0x1815E5630", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F94")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public WaterObjects()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F95")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public WaterObjects(WaterObjects other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F96")]
		[Cpp2IlInjected.Address(RVA = "0x15E44B0", Offset = "0x15E2EB0", VA = "0x1815E44B0", Slot = "10")]
		[DebuggerNonUserCode]
		public WaterObjects Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			WaterObjects waterObjects = default(WaterObjects);
			waterObjects.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (waterObjects._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return waterObjects;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F97")]
		[Cpp2IlInjected.Address(RVA = "0x15E4530", Offset = "0x15E2F30", VA = "0x1815E4530", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other != this)
				{
					return object.Equals(_unknownFields, other);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F98")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WaterObjects other)
		{
			if (other != null)
			{
				if (other != this)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F99")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9A")]
		[Cpp2IlInjected.Address(RVA = "0x15E4620", Offset = "0x15E3020", VA = "0x1815E4620", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WaterObjects other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9F")]
		[Cpp2IlInjected.Address(RVA = "0x15E45B0", Offset = "0x15E2FB0", VA = "0x1815E45B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA2")]
		[Cpp2IlInjected.Address(RVA = "0x15E40C0", Offset = "0x15E2AC0", VA = "0x1815E40C0")]
		public unsafe static bool CanWaterGardeningSlot(uint gridID, uint gridObjectID, int slotIndex, Profile profile, ITransactionContext context)
		{
			int num = 0;
			GardenData gardenData = default(GardenData);
			if (profile.player_.IsToolUnlocked(ToolItemType.Watering) && profile.world_.gridCollection_.TryGetGrid(gridID, out *(IGridInternal*)num) && (!profile.Village.TryGetVillageArea(gridID, out *(VillageAreaType*)num, out *(Village.Types.VillageArea*)num) || profile.world_.IsGridUnlocked(gridID)) && 15u != 0 && gardenData != null)
			{
				GardenData gardenData2 = default(GardenData);
				int count = ((RepeatedField<T>)(object)gardenData2.slots_).Count;
				GardenData gardenData3 = default(GardenData);
				if (slotIndex < count && ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gardenData3.slots_)[slotIndex]).Sapling != null && profile.HasEnoughMana(ManaData.Types.ManaSpendingActionType.Water))
				{
					GardenData gardenData4 = default(GardenData);
					Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gardenData4.slots_)[slotIndex]).PlantedSeedItem;
					GardenData gardenData5 = default(GardenData);
					SaplingGrowthData sapling = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gardenData5.slots_)[slotIndex]).Sapling;
					bool flag = profile.Village.TryGetVillageArea(gridID, out *(VillageAreaType*)num, out *(Village.Types.VillageArea*)num);
					WateringState wateringState = default(WateringState);
					if (wateringState != 0)
					{
						return true;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA3")]
		[Cpp2IlInjected.Address(RVA = "0x15E4990", Offset = "0x15E3390", VA = "0x1815E4990")]
		internal static bool WaterGardeningSlot(uint gridID, uint gridObjectID, int slotIndex, bool automatic, in Player player, in World world, ITransactionContext context)
		{
			//IL_012f: Expected I4, but got O
			//IL_0138: Expected I4, but got O
			//IL_0164: Expected O, but got I4
			//IL_01aa: Expected O, but got I4
			ProfilePlayer profilePlayer = default(ProfilePlayer);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			uint num2 = default(uint);
			GardenData gardenData = default(GardenData);
			GardenData gardenData2 = default(GardenData);
			GardenData gardenData3 = default(GardenData);
			GardenData gardenData4 = default(GardenData);
			SeedItemData seedItemData = default(SeedItemData);
			WateringState wateringState = default(WateringState);
			ProfilePlayer profilePlayer2 = default(ProfilePlayer);
			bool flag4 = default(bool);
			ProfilePlayer profilePlayer3 = default(ProfilePlayer);
			DateTime dateTime4 = default(DateTime);
			uint num5 = default(uint);
			uint num6 = default(uint);
			Timestamp lastWateringDate_ = default(Timestamp);
			uint num8 = default(uint);
			while (true)
			{
				int num = 0;
				if ((!automatic && !profilePlayer.IsToolUnlocked(ToolItemType.Watering)) || !flag || (flag2 && !flag3))
				{
					break;
				}
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (num == 0 || !automatic || gardenData == null)
				{
					break;
				}
				int count = ((RepeatedField<T>)(object)gardenData2.slots_).Count;
				if (slotIndex >= count)
				{
					break;
				}
				GardenData.Types.GardeningSlot gardeningSlot = (GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gardenData3.slots_)[slotIndex];
				if (gardeningSlot.Sapling == null)
				{
					break;
				}
				int plantedSeedItemID_ = gardeningSlot.plantedSeedItemID_;
				GardenData.Types.GardeningSlot gardeningSlot2 = (GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gardenData4.slots_)[slotIndex];
				Item plantedSeedItem = gardeningSlot2.PlantedSeedItem;
				DateTime dateTime = gardeningSlot2.Sapling.endOfGrowth_.ToDateTime();
				TimeSpan timeSpan = seedItemData.growthPeriod_.ToTimeSpan();
				DateTime dateTime2 = dateTime + timeSpan;
				if (dateTime > dateTime2)
				{
					SaplingGrowthData sapling = gardeningSlot2.Sapling;
					seedItemData = (SeedItemData)(object)((object)seedItemData + (object)seedItemData);
				}
				SaplingGrowthData sapling2 = gardeningSlot2.Sapling;
				int num3 = (int)wateringState;
				if ((seedItemData.noGrowthBuff_ ? 1 : 0) != num)
				{
					continue;
				}
				int num4 = 0;
				if (profilePlayer2.GetBuff(BuffType.GardeningCompleteGrowth) == 0 || num3 == 0)
				{
					continue;
				}
				FinishGardeningSlotGrowth.Types.Response response = new FinishGardeningSlotGrowth.Types.Response();
				FinishGardeningSlotGrowth.Types.Request request = new FinishGardeningSlotGrowth.Types.Request();
				request.gridObjectID_ = (uint)(int)request;
				request.slotIndex_ = (int)gardeningSlot2;
				request.gridID_ = gridID;
				request.ForceEndOfGrowth = true;
				response.request_ = request;
				if (!flag4)
				{
					continue;
				}
				if (profilePlayer3.UseBuff(BuffType.GardeningCompleteGrowth, (IPlayerEventDispatcher)num4) && (long)request == 2)
				{
					DateTime dateTime3 = gardeningSlot2.Sapling.lastWateringDate_.ToDateTime();
					TimeSpan timeSpan2 = dateTime4 - dateTime4;
					if (num < (int)num5)
					{
						num += num;
						num++;
					}
					Duration duration = timeSpan2.ToProto();
					Timestamp timestamp = (Timestamp)num + duration;
					if (num < (int)num6)
					{
						num += num;
						num++;
					}
					timestamp = (Timestamp)(object)((object)timestamp + (object)timestamp);
					num += 312;
					timestamp = (Timestamp)(object)((object)timestamp + (object)timestamp);
					num += 328;
				}
				SaplingGrowthData sapling3 = gardeningSlot2.Sapling;
				sapling3.lastWateringDate_ = lastWateringDate_;
				if (seedItemData != null)
				{
					int num7 = 0;
				}
				if (sapling3 != null)
				{
					bool flag5 = gridID != 0;
					if (num < (int)num8)
					{
						num += num;
						num++;
					}
					sapling3 = (SaplingGrowthData)(object)((object)sapling3 + (object)sapling3);
					num += 552;
				}
				if (gridID == 0)
				{
				}
				break;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA4")]
		[Cpp2IlInjected.Address(RVA = "0x15E4680", Offset = "0x15E3080", VA = "0x1815E4680")]
		internal unsafe static bool WaterFlower(uint gridID, uint gridObjectID, bool automatic, Profile profile, IWorldEventDispatcher dispatcher)
		{
			//IL_007b: Expected I4, but got I8
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected I8, but got Unknown
			int num = 0;
			if ((automatic || profile.player_.IsToolUnlocked(ToolItemType.Watering)) && profile.world_.gridCollection_.TryGetGrid(gridObjectID, out *(IGridInternal*)num))
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				FlowerData flowerData = default(FlowerData);
				if (num != 0 && num != 0 && flowerData != null)
				{
					FlowerData flowerData2 = default(FlowerData);
					bool dry_ = flowerData2.dry_;
					FlowerData flowerData3 = default(FlowerData);
					flowerData3.dry_ = (byte)num != 0;
					int num3 = 0;
					num += num;
					num++;
					Profile.HangoutSystemState hangoutState = default(Profile.HangoutSystemState);
					if (dry_ && !automatic)
					{
						hangoutState = profile.HangoutState;
						ulong num4 = default(ulong);
						bool flag = hangoutState.TryApplyHangoutActivityFriendship(HangoutActivityType.HangoutActivityWater, (byte)num4 != 0);
					}
					hangoutState = (Profile.HangoutSystemState)(object)((object)hangoutState + (object)hangoutState);
					ulong num5 = (ulong)(long)(num5 + typeof(IGrid).TypeHandle);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA5")]
		[Cpp2IlInjected.Address(RVA = "0x15E53F0", Offset = "0x15E3DF0", VA = "0x1815E53F0")]
		static WaterObjects()
		{
			Func<WaterObjects> func = default(Func<WaterObjects>);
			_parser = (MessageParser<WaterObjects>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
