using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public sealed class SortContainerInventory : IMessage<SortContainerInventory>, IMessage, IEquatable<SortContainerInventory>, IDeepCloneable<SortContainerInventory>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000122")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40003EC")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40003ED")]
				[OriginalName("InvalidContainerInventoryID")]
				InvalidContainerInventoryId
			}

			[Cpp2IlInjected.Token(Token = "0x2000123")]
			public enum SortAlgorithm
			{
				[Cpp2IlInjected.Token(Token = "0x40003EF")]
				[OriginalName("Alphabetical")]
				Alphabetical,
				[Cpp2IlInjected.Token(Token = "0x40003F0")]
				[OriginalName("ByType")]
				ByType,
				[Cpp2IlInjected.Token(Token = "0x40003F1")]
				[OriginalName("ByMana")]
				ByMana,
				[Cpp2IlInjected.Token(Token = "0x40003F2")]
				[OriginalName("BySellPrice")]
				BySellPrice
			}

			[Cpp2IlInjected.Token(Token = "0x2000124")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40003F3")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003F4")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40003F5")]
				public const int ContainerInventoryIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003F6")]
				private uint containerInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x40003F7")]
				public const int AlgorithmFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40003F8")]
				private SortAlgorithm algorithm_;

				[Cpp2IlInjected.Token(Token = "0x1700021D")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000CAD")]
					[Cpp2IlInjected.Address(RVA = "0x15BE1A0", Offset = "0x15BCBA0", VA = "0x1815BE1A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700021E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000CAE")]
					[Cpp2IlInjected.Address(RVA = "0x15BDBE0", Offset = "0x15BC5E0", VA = "0x1815BDBE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700021F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000CAF")]
					[Cpp2IlInjected.Address(RVA = "0x15BE620", Offset = "0x15BD020", VA = "0x1815BE620", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000220")]
				[DebuggerNonUserCode]
				public uint ContainerInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6000CB3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000CB4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000221")]
				[DebuggerNonUserCode]
				public SortAlgorithm Algorithm
				{
					[Cpp2IlInjected.Token(Token = "0x6000CB5")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(SortAlgorithm);
					}
					[Cpp2IlInjected.Token(Token = "0x6000CB6")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000CB0")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CB1")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CB2")]
				[Cpp2IlInjected.Address(RVA = "0x15B9A90", Offset = "0x15B8490", VA = "0x1815B9A90", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000CB7")]
				[Cpp2IlInjected.Address(RVA = "0x15BA0F0", Offset = "0x15B8AF0", VA = "0x1815BA0F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CB8")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CB9")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CBA")]
				[Cpp2IlInjected.Address(RVA = "0x15BBD50", Offset = "0x15BA750", VA = "0x1815BBD50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000CBB")]
				[Cpp2IlInjected.Address(RVA = "0x15BC890", Offset = "0x15BB290", VA = "0x1815BC890", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CBC")]
				[Cpp2IlInjected.Address(RVA = "0x15B8FD0", Offset = "0x15B79D0", VA = "0x1815B8FD0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CBD")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CBE")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CBF")]
				[Cpp2IlInjected.Address(RVA = "0x15BAA60", Offset = "0x15B9460", VA = "0x1815BAA60", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000CC0")]
				[Cpp2IlInjected.Address(RVA = "0x15BB9C0", Offset = "0x15BA3C0", VA = "0x1815BB9C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CC1")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000126")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40003FA")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40003FB")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40003FC")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003FD")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40003FE")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40003FF")]
				private Request request_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000400")]
				private readonly Dictionary<Item, string> localizedNames;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000401")]
				private ContainerInventorySortData inventorySortData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000402")]
				private readonly Dictionary<(Item item, ItemState itemState), int> mana;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000403")]
				private readonly Dictionary<(Item item, ItemState itemState), int> sellPrices;

				[Cpp2IlInjected.Token(Token = "0x17000222")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000CC6")]
					[Cpp2IlInjected.Address(RVA = "0x15C91D0", Offset = "0x15C7BD0", VA = "0x1815C91D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000223")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000CC7")]
					[Cpp2IlInjected.Address(RVA = "0x15C8C70", Offset = "0x15C7670", VA = "0x1815C8C70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000224")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000CC8")]
					[Cpp2IlInjected.Address(RVA = "0x15C9A70", Offset = "0x15C8470", VA = "0x1815C9A70", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000225")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000CCC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000CCD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000226")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000CCE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000CCF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000227")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000CDB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000CDC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000CC9")]
				[Cpp2IlInjected.Address(RVA = "0x15C87B0", Offset = "0x15C71B0", VA = "0x1815C87B0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CCA")]
				[Cpp2IlInjected.Address(RVA = "0x15C7FE0", Offset = "0x15C69E0", VA = "0x1815C7FE0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CCB")]
				[Cpp2IlInjected.Address(RVA = "0x15C30F0", Offset = "0x15C1AF0", VA = "0x1815C30F0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD0")]
				[Cpp2IlInjected.Address(RVA = "0x15C3B40", Offset = "0x15C2540", VA = "0x1815C3B40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD1")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD2")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD3")]
				[Cpp2IlInjected.Address(RVA = "0x15C6B50", Offset = "0x15C5550", VA = "0x1815C6B50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD4")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD5")]
				[Cpp2IlInjected.Address(RVA = "0x15C2B00", Offset = "0x15C1500", VA = "0x1815C2B00", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD6")]
				[Cpp2IlInjected.Address(RVA = "0x15C5240", Offset = "0x15C3C40", VA = "0x1815C5240", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD7")]
				[Cpp2IlInjected.Address(RVA = "0x15C4D00", Offset = "0x15C3700", VA = "0x1815C4D00", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD8")]
				[Cpp2IlInjected.Address(RVA = "0x15C4A10", Offset = "0x15C3410", VA = "0x1815C4A10", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000CD9")]
				[Cpp2IlInjected.Address(RVA = "0x15C6A20", Offset = "0x15C5420", VA = "0x1815C6A20", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CDA")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000CDD")]
				[Cpp2IlInjected.Address(RVA = "0x15C0270", Offset = "0x15BEC70", VA = "0x1815C0270", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CDE")]
				[Cpp2IlInjected.Address(RVA = "0x15BEB10", Offset = "0x15BD510", VA = "0x1815BEB10")]
				private string AlphabeticalSort(ContainerInventory.Types.Slot slot)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000CDF")]
				[Cpp2IlInjected.Address(RVA = "0x15C2600", Offset = "0x15C1000", VA = "0x1815C2600")]
				private int ByTypeSort(ContainerInventory.Types.Slot slot)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CE0")]
				[Cpp2IlInjected.Address(RVA = "0x15C22C0", Offset = "0x15C0CC0", VA = "0x1815C22C0")]
				private int ByMana(ContainerInventory.Types.Slot slot)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000CE1")]
				[Cpp2IlInjected.Address(RVA = "0x15C2430", Offset = "0x15C0E30", VA = "0x1815C2430")]
				private int BySellPrice(ContainerInventory.Types.Slot slot)
				{
					return default(int);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly MessageParser<SortContainerInventory> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		[DebuggerNonUserCode]
		public static MessageParser<SortContainerInventory> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9B")]
			[Cpp2IlInjected.Address(RVA = "0x1832FE0", Offset = "0x18319E0", VA = "0x181832FE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9C")]
			[Cpp2IlInjected.Address(RVA = "0x1832F10", Offset = "0x1831910", VA = "0x181832F10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9D")]
			[Cpp2IlInjected.Address(RVA = "0x1833040", Offset = "0x1831A40", VA = "0x181833040", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SortContainerInventory()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SortContainerInventory(SortContainerInventory other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA0")]
		[Cpp2IlInjected.Address(RVA = "0x1832C30", Offset = "0x1831630", VA = "0x181832C30", Slot = "10")]
		[DebuggerNonUserCode]
		public SortContainerInventory Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SortContainerInventory sortContainerInventory = default(SortContainerInventory);
			sortContainerInventory.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (sortContainerInventory._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return sortContainerInventory;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA1")]
		[Cpp2IlInjected.Address(RVA = "0x1832CB0", Offset = "0x18316B0", VA = "0x181832CB0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SortContainerInventory other)
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

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x1832DA0", Offset = "0x18317A0", VA = "0x181832DA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SortContainerInventory other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
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

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x1832D30", Offset = "0x1831730", VA = "0x181832D30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x1832E00", Offset = "0x1831800", VA = "0x181832E00")]
		static SortContainerInventory()
		{
			Func<SortContainerInventory> func = default(Func<SortContainerInventory>);
			_parser = (MessageParser<SortContainerInventory>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
