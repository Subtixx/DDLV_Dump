using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000345")]
	public sealed class SendFishingResult : IMessage<SendFishingResult>, IMessage, IEquatable<SendFishingResult>, IDeepCloneable<SendFishingResult>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000346")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000347")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000A2D")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000A2E")]
				[OriginalName("InvalidPendingFishID")]
				InvalidPendingFishId,
				[Cpp2IlInjected.Token(Token = "0x4000A2F")]
				[OriginalName("InvalidContainerInventoryID")]
				InvalidContainerInventoryId,
				[Cpp2IlInjected.Token(Token = "0x4000A30")]
				[OriginalName("InventoryFull")]
				InventoryFull
			}

			[Cpp2IlInjected.Token(Token = "0x2000348")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IInventoryFullRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4000A31")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000A32")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000A33")]
				public const int SelectorFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000A34")]
				private PendingFishSelector selector_;

				[Cpp2IlInjected.Token(Token = "0x4000A35")]
				public const int ContainerInventoryIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000A36")]
				private uint containerInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000A37")]
				public const int FishingResultFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000A38")]
				private bool fishingResult_;

				[Cpp2IlInjected.Token(Token = "0x4000A39")]
				public const int KeepFishFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x4000A3A")]
				private bool keepFish_;

				[Cpp2IlInjected.Token(Token = "0x4000A3B")]
				public const int InventoryFullResolutionFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000A3C")]
				private InventoryFullResolution inventoryFullResolution_;

				[Cpp2IlInjected.Token(Token = "0x4000A3D")]
				public const int SpectatorCharacterIdFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000A3E")]
				private int spectatorCharacterId_;

				[Cpp2IlInjected.Token(Token = "0x170005E5")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60020A8")]
					[Cpp2IlInjected.Address(RVA = "0x200C190", Offset = "0x200AB90", VA = "0x18200C190")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005E6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60020A9")]
					[Cpp2IlInjected.Address(RVA = "0x200BCB0", Offset = "0x200A6B0", VA = "0x18200BCB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005E7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60020AA")]
					[Cpp2IlInjected.Address(RVA = "0x200CBB0", Offset = "0x200B5B0", VA = "0x18200CBB0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005E8")]
				[DebuggerNonUserCode]
				public PendingFishSelector Selector
				{
					[Cpp2IlInjected.Token(Token = "0x60020AE")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60020AF")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005E9")]
				[DebuggerNonUserCode]
				public uint ContainerInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x60020B0")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x60020B1")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005EA")]
				[DebuggerNonUserCode]
				public bool FishingResult
				{
					[Cpp2IlInjected.Token(Token = "0x60020B2")]
					[Cpp2IlInjected.Address(RVA = "0x1703600", Offset = "0x1702000", VA = "0x181703600")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60020B3")]
					[Cpp2IlInjected.Address(RVA = "0x1703720", Offset = "0x1702120", VA = "0x181703720")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005EB")]
				[DebuggerNonUserCode]
				public bool KeepFish
				{
					[Cpp2IlInjected.Token(Token = "0x60020B4")]
					[Cpp2IlInjected.Address(RVA = "0x1811940", Offset = "0x1810340", VA = "0x181811940")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60020B5")]
					[Cpp2IlInjected.Address(RVA = "0x1811AF0", Offset = "0x18104F0", VA = "0x181811AF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005EC")]
				[DebuggerNonUserCode]
				public InventoryFullResolution InventoryFullResolution
				{
					[Cpp2IlInjected.Token(Token = "0x60020B6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "14")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60020B7")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00", Slot = "15")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005ED")]
				[DebuggerNonUserCode]
				public int SpectatorCharacterId
				{
					[Cpp2IlInjected.Token(Token = "0x60020B8")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60020B9")]
					[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60020AB")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020AC")]
				[Cpp2IlInjected.Address(RVA = "0x200B530", Offset = "0x2009F30", VA = "0x18200B530")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020AD")]
				[Cpp2IlInjected.Address(RVA = "0x2005980", Offset = "0x2004380", VA = "0x182005980", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60020BA")]
				[Cpp2IlInjected.Address(RVA = "0x2006180", Offset = "0x2004B80", VA = "0x182006180", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60020BB")]
				[Cpp2IlInjected.Address(RVA = "0x2006050", Offset = "0x2004A50", VA = "0x182006050", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60020BC")]
				[Cpp2IlInjected.Address(RVA = "0x2007850", Offset = "0x2006250", VA = "0x182007850", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60020BD")]
				[Cpp2IlInjected.Address(RVA = "0x2009750", Offset = "0x2008150", VA = "0x182009750", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60020BE")]
				[Cpp2IlInjected.Address(RVA = "0x200A250", Offset = "0x2008C50", VA = "0x18200A250", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020BF")]
				[Cpp2IlInjected.Address(RVA = "0x2004FB0", Offset = "0x20039B0", VA = "0x182004FB0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60020C0")]
				[Cpp2IlInjected.Address(RVA = "0x20083E0", Offset = "0x2006DE0", VA = "0x1820083E0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020C1")]
				[Cpp2IlInjected.Address(RVA = "0x2007F20", Offset = "0x2006920", VA = "0x182007F20", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020C2")]
				[Cpp2IlInjected.Address(RVA = "0x2007240", Offset = "0x2005C40", VA = "0x182007240", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60020C3")]
				[Cpp2IlInjected.Address(RVA = "0x2008C80", Offset = "0x2007680", VA = "0x182008C80", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020C4")]
				[Cpp2IlInjected.Address(RVA = "0x20056D0", Offset = "0x20040D0", VA = "0x1820056D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200034A")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IInventoryFullResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4000A40")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000A41")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000A42")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000A43")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000A44")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000A45")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000A46")]
				public const int TriggeredCriticalSuccessMinigameIDFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4000A47")]
				private static readonly FieldCodec<int?> _single_triggeredCriticalSuccessMinigameID_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000A48")]
				private int? triggeredCriticalSuccessMinigameID_;

				[Cpp2IlInjected.Token(Token = "0x4000A49")]
				public const int InventoryFullDetailsFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000A4A")]
				private InventoryFullDetails inventoryFullDetails_;

				[Cpp2IlInjected.Token(Token = "0x170005EE")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60020C9")]
					[Cpp2IlInjected.Address(RVA = "0x2019820", Offset = "0x2018220", VA = "0x182019820")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005EF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60020CA")]
					[Cpp2IlInjected.Address(RVA = "0x2019560", Offset = "0x2017F60", VA = "0x182019560")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005F0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60020CB")]
					[Cpp2IlInjected.Address(RVA = "0x2019E20", Offset = "0x2018820", VA = "0x182019E20", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005F1")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60020CF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60020D0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005F2")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60020D1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60020D2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005F3")]
				[DebuggerNonUserCode]
				public int? TriggeredCriticalSuccessMinigameID
				{
					[Cpp2IlInjected.Token(Token = "0x60020D3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60020D4")]
					[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005F4")]
				[DebuggerNonUserCode]
				public InventoryFullDetails InventoryFullDetails
				{
					[Cpp2IlInjected.Token(Token = "0x60020D5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "23")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60020D6")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "24")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170005F5")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60020E2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60020E3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60020CC")]
				[Cpp2IlInjected.Address(RVA = "0x2018F50", Offset = "0x2017950", VA = "0x182018F50")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020CD")]
				[Cpp2IlInjected.Address(RVA = "0x2018A30", Offset = "0x2017430", VA = "0x182018A30")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020CE")]
				[Cpp2IlInjected.Address(RVA = "0x2011150", Offset = "0x200FB50", VA = "0x182011150", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60020D7")]
				[Cpp2IlInjected.Address(RVA = "0x2011EB0", Offset = "0x20108B0", VA = "0x182011EB0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60020D8")]
				[Cpp2IlInjected.Address(RVA = "0x2012810", Offset = "0x2011210", VA = "0x182012810", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60020D9")]
				[Cpp2IlInjected.Address(RVA = "0x2013710", Offset = "0x2012110", VA = "0x182013710", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60020DA")]
				[Cpp2IlInjected.Address(RVA = "0x2016930", Offset = "0x2015330", VA = "0x182016930", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60020DB")]
				[Cpp2IlInjected.Address(RVA = "0x2017050", Offset = "0x2015A50", VA = "0x182017050", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020DC")]
				[Cpp2IlInjected.Address(RVA = "0x20102D0", Offset = "0x200ECD0", VA = "0x1820102D0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60020DD")]
				[Cpp2IlInjected.Address(RVA = "0x2014050", Offset = "0x2012A50", VA = "0x182014050", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020DE")]
				[Cpp2IlInjected.Address(RVA = "0x2013800", Offset = "0x2012200", VA = "0x182013800", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020DF")]
				[Cpp2IlInjected.Address(RVA = "0x2013350", Offset = "0x2011D50", VA = "0x182013350", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60020E0")]
				[Cpp2IlInjected.Address(RVA = "0x2016380", Offset = "0x2014D80", VA = "0x182016380", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020E1")]
				[Cpp2IlInjected.Address(RVA = "0x2010540", Offset = "0x200EF40", VA = "0x182010540", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60020E4")]
				[Cpp2IlInjected.Address(RVA = "0x200DE80", Offset = "0x200C880", VA = "0x18200DE80", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60020E5")]
				[Cpp2IlInjected.Address(RVA = "0x2011550", Offset = "0x200FF50", VA = "0x182011550")]
				internal static ContainerInventory.CanAddResult CollectFish(ContainerInventory containerInventory, int? criticalSuccessMinigameID, PendingFish pendingFish, int amount, bool keepFish, in Player player, ITransactionContext context, ActivityDataLocationFilter locationFilter, Item spectator)
				{
					return default(ContainerInventory.CanAddResult);
				}

				[Cpp2IlInjected.Token(Token = "0x60020E6")]
				[Cpp2IlInjected.Address(RVA = "0x2010640", Offset = "0x200F040", VA = "0x182010640")]
				internal static void ClearPendingFish(PendingFishSelector pendingFishSelector, in World world)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000A2A")]
		private static readonly MessageParser<SendFishingResult> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000A2B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170005E2")]
		[DebuggerNonUserCode]
		public static MessageParser<SendFishingResult> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002095")]
			[Cpp2IlInjected.Address(RVA = "0x1772EF0", Offset = "0x17718F0", VA = "0x181772EF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002096")]
			[Cpp2IlInjected.Address(RVA = "0x1772E20", Offset = "0x1771820", VA = "0x181772E20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002097")]
			[Cpp2IlInjected.Address(RVA = "0x1772F50", Offset = "0x1771950", VA = "0x181772F50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002098")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SendFishingResult()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002099")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SendFishingResult(SendFishingResult other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600209A")]
		[Cpp2IlInjected.Address(RVA = "0x1772B40", Offset = "0x1771540", VA = "0x181772B40", Slot = "10")]
		[DebuggerNonUserCode]
		public SendFishingResult Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SendFishingResult sendFishingResult = default(SendFishingResult);
			sendFishingResult.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (sendFishingResult._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return sendFishingResult;
		}

		[Cpp2IlInjected.Token(Token = "0x600209B")]
		[Cpp2IlInjected.Address(RVA = "0x1772BC0", Offset = "0x17715C0", VA = "0x181772BC0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600209C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SendFishingResult other)
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

		[Cpp2IlInjected.Token(Token = "0x600209D")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600209E")]
		[Cpp2IlInjected.Address(RVA = "0x1772CB0", Offset = "0x17716B0", VA = "0x181772CB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600209F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60020A0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SendFishingResult other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020A2")]
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

		[Cpp2IlInjected.Token(Token = "0x60020A3")]
		[Cpp2IlInjected.Address(RVA = "0x1772C40", Offset = "0x1771640", VA = "0x181772C40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60020A4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60020A5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60020A6")]
		[Cpp2IlInjected.Address(RVA = "0x1772A60", Offset = "0x1771460", VA = "0x181772A60")]
		private static bool ApplyBuff(ProfilePlayer player, ref int amount)
		{
			int buff = player.GetBuff(BuffType.FishingChanceToGet2X);
			int num = 0;
			int seed = default(int);
			uint maxValue = default(uint);
			int num2 = new Random(seed).Next((int)maxValue);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020A7")]
		[Cpp2IlInjected.Address(RVA = "0x1772D10", Offset = "0x1771710", VA = "0x181772D10")]
		static SendFishingResult()
		{
			Func<SendFishingResult> func = default(Func<SendFishingResult>);
			_parser = (MessageParser<SendFishingResult>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
