using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CloudScripts;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000CEB")]
	public sealed class SyncOnlineInventory : IMessage<SyncOnlineInventory>, IMessage, IEquatable<SyncOnlineInventory>, IDeepCloneable<SyncOnlineInventory>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000CEC")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000CED")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4003276")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4003277")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4003278")]
				[OriginalName("NotFound")]
				NotFound = 2,
				[Cpp2IlInjected.Token(Token = "0x4003279")]
				[OriginalName("UnknownError")]
				UnknownError = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000CEE")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x400327A")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400327B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400327C")]
				public const int SyncEntitlementsFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400327D")]
				private bool syncEntitlements_;

				[Cpp2IlInjected.Token(Token = "0x400327E")]
				public const int InstalledEntitlementsFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x400327F")]
				private static readonly FieldCodec<ProductID> _repeated_installedEntitlements_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003280")]
				private readonly RepeatedField<ProductID> installedEntitlements_;

				[Cpp2IlInjected.Token(Token = "0x4003281")]
				public const int ApplyRefundFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003282")]
				private bool applyRefund_;

				[Cpp2IlInjected.Token(Token = "0x4003283")]
				public const int IsPS5FieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x4003284")]
				private bool isPS5_;

				[Cpp2IlInjected.Token(Token = "0x4003285")]
				public const int PS4ServiceLabelFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4003286")]
				private string pS4ServiceLabel_;

				[Cpp2IlInjected.Token(Token = "0x4003287")]
				public const int PS5ServiceLabelFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4003288")]
				private string pS5ServiceLabel_;

				[Cpp2IlInjected.Token(Token = "0x4003289")]
				public const int AuthCodeFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400328A")]
				private string authCode_;

				[Cpp2IlInjected.Token(Token = "0x400328B")]
				public const int IssuerIdFieldNumber = 9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x400328C")]
				private int issuerId_;

				[Cpp2IlInjected.Token(Token = "0x400328D")]
				public const int MarketplaceNameFieldNumber = 10;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400328E")]
				private string marketplaceName_;

				[Cpp2IlInjected.Token(Token = "0x17001370")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006EA0")]
					[Cpp2IlInjected.Address(RVA = "0x25FB8B0", Offset = "0x25FA2B0", VA = "0x1825FB8B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001371")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006EA1")]
					[Cpp2IlInjected.Address(RVA = "0x25FB4F0", Offset = "0x25F9EF0", VA = "0x1825FB4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001372")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006EA2")]
					[Cpp2IlInjected.Address(RVA = "0x25FBF10", Offset = "0x25FA910", VA = "0x1825FBF10", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001373")]
				[DebuggerNonUserCode]
				public bool SyncEntitlements
				{
					[Cpp2IlInjected.Token(Token = "0x6006EA6")]
					[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006EA7")]
					[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001374")]
				[DebuggerNonUserCode]
				public RepeatedField<ProductID> InstalledEntitlements
				{
					[Cpp2IlInjected.Token(Token = "0x6006EA8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001375")]
				[DebuggerNonUserCode]
				public bool ApplyRefund
				{
					[Cpp2IlInjected.Token(Token = "0x6006EA9")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006EAA")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001376")]
				[DebuggerNonUserCode]
				public bool IsPS5
				{
					[Cpp2IlInjected.Token(Token = "0x6006EAB")]
					[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006EAC")]
					[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001377")]
				[DebuggerNonUserCode]
				public string PS4ServiceLabel
				{
					[Cpp2IlInjected.Token(Token = "0x6006EAD")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006EAE")]
					[Cpp2IlInjected.Address(RVA = "0x25FC5A0", Offset = "0x25FAFA0", VA = "0x1825FC5A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001378")]
				[DebuggerNonUserCode]
				public string PS5ServiceLabel
				{
					[Cpp2IlInjected.Token(Token = "0x6006EAF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006EB0")]
					[Cpp2IlInjected.Address(RVA = "0x25FC610", Offset = "0x25FB010", VA = "0x1825FC610")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001379")]
				[DebuggerNonUserCode]
				public string AuthCode
				{
					[Cpp2IlInjected.Token(Token = "0x6006EB1")]
					[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006EB2")]
					[Cpp2IlInjected.Address(RVA = "0x25FC450", Offset = "0x25FAE50", VA = "0x1825FC450")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700137A")]
				[DebuggerNonUserCode]
				public int IssuerId
				{
					[Cpp2IlInjected.Token(Token = "0x6006EB3")]
					[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006EB4")]
					[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700137B")]
				[DebuggerNonUserCode]
				public string MarketplaceName
				{
					[Cpp2IlInjected.Token(Token = "0x6006EB5")]
					[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006EB6")]
					[Cpp2IlInjected.Address(RVA = "0x25FC530", Offset = "0x25FAF30", VA = "0x1825FC530")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006EA3")]
				[Cpp2IlInjected.Address(RVA = "0x25FAA70", Offset = "0x25F9470", VA = "0x1825FAA70")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EA4")]
				[Cpp2IlInjected.Address(RVA = "0x25FA7C0", Offset = "0x25F91C0", VA = "0x1825FA7C0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EA5")]
				[Cpp2IlInjected.Address(RVA = "0x25F4DC0", Offset = "0x25F37C0", VA = "0x1825F4DC0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006EB7")]
				[Cpp2IlInjected.Address(RVA = "0x25F53C0", Offset = "0x25F3DC0", VA = "0x1825F53C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006EB8")]
				[Cpp2IlInjected.Address(RVA = "0x25F5650", Offset = "0x25F4050", VA = "0x1825F5650", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006EB9")]
				[Cpp2IlInjected.Address(RVA = "0x25F6800", Offset = "0x25F5200", VA = "0x1825F6800", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006EBA")]
				[Cpp2IlInjected.Address(RVA = "0x25F8380", Offset = "0x25F6D80", VA = "0x1825F8380", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006EBB")]
				[Cpp2IlInjected.Address(RVA = "0x25F94E0", Offset = "0x25F7EE0", VA = "0x1825F94E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EBC")]
				[Cpp2IlInjected.Address(RVA = "0x25F4110", Offset = "0x25F2B10", VA = "0x1825F4110", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006EBD")]
				[Cpp2IlInjected.Address(RVA = "0x25F70A0", Offset = "0x25F5AA0", VA = "0x1825F70A0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EBE")]
				[Cpp2IlInjected.Address(RVA = "0x25F6EB0", Offset = "0x25F58B0", VA = "0x1825F6EB0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EBF")]
				[Cpp2IlInjected.Address(RVA = "0x25F6410", Offset = "0x25F4E10", VA = "0x1825F6410", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006EC0")]
				[Cpp2IlInjected.Address(RVA = "0x25F7A60", Offset = "0x25F6460", VA = "0x1825F7A60", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EC1")]
				[Cpp2IlInjected.Address(RVA = "0x25F49B0", Offset = "0x25F33B0", VA = "0x1825F49B0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EC2")]
				[Cpp2IlInjected.Address(RVA = "0x25FACE0", Offset = "0x25F96E0", VA = "0x1825FACE0")]
				public Request(RedeemProductIds.Request redeemRequest)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CF0")]
			public sealed class ProductID : IMessage<ProductID>, IMessage, IEquatable<ProductID>, IDeepCloneable<ProductID>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4003291")]
				private static readonly MessageParser<ProductID> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003292")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003293")]
				public const int MarkeplaceFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003294")]
				private string markeplace_;

				[Cpp2IlInjected.Token(Token = "0x4003295")]
				public const int ProductFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003296")]
				private string product_;

				[Cpp2IlInjected.Token(Token = "0x1700137C")]
				[DebuggerNonUserCode]
				public static MessageParser<ProductID> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006EC8")]
					[Cpp2IlInjected.Address(RVA = "0x25F3B00", Offset = "0x25F2500", VA = "0x1825F3B00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700137D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006EC9")]
					[Cpp2IlInjected.Address(RVA = "0x25F3A80", Offset = "0x25F2480", VA = "0x1825F3A80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700137E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006ECA")]
					[Cpp2IlInjected.Address(RVA = "0x25F3B60", Offset = "0x25F2560", VA = "0x1825F3B60", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700137F")]
				[DebuggerNonUserCode]
				public string Markeplace
				{
					[Cpp2IlInjected.Token(Token = "0x6006ECE")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006ECF")]
					[Cpp2IlInjected.Address(RVA = "0x25F3C20", Offset = "0x25F2620", VA = "0x1825F3C20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001380")]
				[DebuggerNonUserCode]
				public string Product
				{
					[Cpp2IlInjected.Token(Token = "0x6006ED0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006ED1")]
					[Cpp2IlInjected.Address(RVA = "0x25F3C90", Offset = "0x25F2690", VA = "0x1825F3C90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006ECB")]
				[Cpp2IlInjected.Address(RVA = "0x25F3950", Offset = "0x25F2350", VA = "0x1825F3950")]
				[DebuggerNonUserCode]
				public ProductID()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006ECC")]
				[Cpp2IlInjected.Address(RVA = "0x25F39B0", Offset = "0x25F23B0", VA = "0x1825F39B0")]
				[DebuggerNonUserCode]
				public ProductID(ProductID other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006ECD")]
				[Cpp2IlInjected.Address(RVA = "0x25F3350", Offset = "0x25F1D50", VA = "0x1825F3350", Slot = "10")]
				[DebuggerNonUserCode]
				public ProductID Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006ED2")]
				[Cpp2IlInjected.Address(RVA = "0x25F3450", Offset = "0x25F1E50", VA = "0x1825F3450", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006ED3")]
				[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ProductID other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006ED4")]
				[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006ED5")]
				[Cpp2IlInjected.Address(RVA = "0x25F37E0", Offset = "0x25F21E0", VA = "0x1825F37E0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006ED6")]
				[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006ED7")]
				[Cpp2IlInjected.Address(RVA = "0x25F31C0", Offset = "0x25F1BC0", VA = "0x1825F31C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006ED8")]
				[Cpp2IlInjected.Address(RVA = "0x25F35A0", Offset = "0x25F1FA0", VA = "0x1825F35A0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ProductID other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006ED9")]
				[Cpp2IlInjected.Address(RVA = "0x25F3620", Offset = "0x25F2020", VA = "0x1825F3620", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EDA")]
				[Cpp2IlInjected.Address(RVA = "0x25F3510", Offset = "0x25F1F10", VA = "0x1825F3510", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006EDB")]
				[Cpp2IlInjected.Address(RVA = "0x25F36D0", Offset = "0x25F20D0", VA = "0x1825F36D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EDC")]
				[Cpp2IlInjected.Address(RVA = "0x25F32A0", Offset = "0x25F1CA0", VA = "0x1825F32A0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CF2")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4003298")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003299")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400329A")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400329B")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400329C")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400329D")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x400329E")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400329F")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x40032A0")]
				public const int ItemsToAddFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x40032A1")]
				private static readonly FieldCodec<OnlineItem> _repeated_itemsToAdd_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40032A2")]
				private readonly RepeatedField<OnlineItem> itemsToAdd_;

				[Cpp2IlInjected.Token(Token = "0x40032A3")]
				public const int ItemsToRemoveFieldNumber = 6;

				[Cpp2IlInjected.Token(Token = "0x40032A4")]
				private static readonly FieldCodec<OnlineItem> _repeated_itemsToRemove_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40032A5")]
				private readonly RepeatedField<OnlineItem> itemsToRemove_;

				[Cpp2IlInjected.Token(Token = "0x17001381")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006EE1")]
					[Cpp2IlInjected.Address(RVA = "0xD0C8C0", Offset = "0xD0B2C0", VA = "0x180D0C8C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001382")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006EE2")]
					[Cpp2IlInjected.Address(RVA = "0xD0C760", Offset = "0xD0B160", VA = "0x180D0C760")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001383")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006EE3")]
					[Cpp2IlInjected.Address(RVA = "0xD0CB00", Offset = "0xD0B500", VA = "0x180D0CB00", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001384")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006EE7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006EE8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001385")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006EE9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006EEA")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001386")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006EEB")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006EEC")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001387")]
				[DebuggerNonUserCode]
				public RepeatedField<OnlineItem> ItemsToAdd
				{
					[Cpp2IlInjected.Token(Token = "0x6006EED")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001388")]
				[DebuggerNonUserCode]
				public RepeatedField<OnlineItem> ItemsToRemove
				{
					[Cpp2IlInjected.Token(Token = "0x6006EEE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001389")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006EFA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006EFB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700138A")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006EFC")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006EFD")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006EE4")]
				[Cpp2IlInjected.Address(RVA = "0xD0C5E0", Offset = "0xD0AFE0", VA = "0x180D0C5E0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EE5")]
				[Cpp2IlInjected.Address(RVA = "0xD0C340", Offset = "0xD0AD40", VA = "0x180D0C340")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EE6")]
				[Cpp2IlInjected.Address(RVA = "0xD0A010", Offset = "0xD08A10", VA = "0x180D0A010", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006EEF")]
				[Cpp2IlInjected.Address(RVA = "0xD0A2C0", Offset = "0xD08CC0", VA = "0x180D0A2C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF0")]
				[Cpp2IlInjected.Address(RVA = "0xD0A1E0", Offset = "0xD08BE0", VA = "0x180D0A1E0", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF1")]
				[Cpp2IlInjected.Address(RVA = "0xD0A9A0", Offset = "0xD093A0", VA = "0x180D0A9A0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF2")]
				[Cpp2IlInjected.Address(RVA = "0xD0BB40", Offset = "0xD0A540", VA = "0x180D0BB40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF3")]
				[Cpp2IlInjected.Address(RVA = "0xD0BBA0", Offset = "0xD0A5A0", VA = "0x180D0BBA0", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF4")]
				[Cpp2IlInjected.Address(RVA = "0xD09A00", Offset = "0xD08400", VA = "0x180D09A00", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF5")]
				[Cpp2IlInjected.Address(RVA = "0xD0B090", Offset = "0xD09A90", VA = "0x180D0B090", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF6")]
				[Cpp2IlInjected.Address(RVA = "0xD0ACB0", Offset = "0xD096B0", VA = "0x180D0ACB0", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF7")]
				[Cpp2IlInjected.Address(RVA = "0xD0A790", Offset = "0xD09190", VA = "0x180D0A790", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF8")]
				[Cpp2IlInjected.Address(RVA = "0xD0B890", Offset = "0xD0A290", VA = "0x180D0B890", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EF9")]
				[Cpp2IlInjected.Address(RVA = "0xD09C60", Offset = "0xD08660", VA = "0x180D09C60", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006EFE")]
				[Cpp2IlInjected.Address(RVA = "0xD0A540", Offset = "0xD08F40", VA = "0x180D0A540", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__54))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006EFF")]
				[Cpp2IlInjected.Address(RVA = "0xD0B1B0", Offset = "0xD09BB0", VA = "0x180D0B1B0")]
				private void PrintEntitlementInfo(DisneyCloudScript.GetPlaystationEntitlements.PlaystationEntitlementInfo info)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F00")]
				[Cpp2IlInjected.Address(RVA = "0xD09400", Offset = "0xD07E00", VA = "0x180D09400", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CF5")]
			public sealed class OnlineItem : IMessage<OnlineItem>, IMessage, IEquatable<OnlineItem>, IDeepCloneable<OnlineItem>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40032B0")]
				private static readonly MessageParser<OnlineItem> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40032B1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40032B2")]
				public const int ItemIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40032B3")]
				private int itemId_;

				[Cpp2IlInjected.Token(Token = "0x40032B4")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40032B5")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x1700138B")]
				[DebuggerNonUserCode]
				public static MessageParser<OnlineItem> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006F08")]
					[Cpp2IlInjected.Address(RVA = "0x25F30A0", Offset = "0x25F1AA0", VA = "0x1825F30A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700138C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006F09")]
					[Cpp2IlInjected.Address(RVA = "0x25F3020", Offset = "0x25F1A20", VA = "0x1825F3020")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700138D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006F0A")]
					[Cpp2IlInjected.Address(RVA = "0x25F3100", Offset = "0x25F1B00", VA = "0x1825F3100", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700138E")]
				[DebuggerNonUserCode]
				public int ItemId
				{
					[Cpp2IlInjected.Token(Token = "0x6006F0E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006F0F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700138F")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6006F10")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006F11")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006F0B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public OnlineItem()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F0C")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public OnlineItem(OnlineItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F0D")]
				[Cpp2IlInjected.Address(RVA = "0x25F2C10", Offset = "0x25F1610", VA = "0x1825F2C10", Slot = "10")]
				[DebuggerNonUserCode]
				public OnlineItem Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006F12")]
				[Cpp2IlInjected.Address(RVA = "0x25F2CA0", Offset = "0x25F16A0", VA = "0x1825F2CA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006F13")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(OnlineItem other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006F14")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006F15")]
				[Cpp2IlInjected.Address(RVA = "0x25F2EB0", Offset = "0x25F18B0", VA = "0x1825F2EB0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006F16")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F17")]
				[Cpp2IlInjected.Address(RVA = "0x25F2B40", Offset = "0x25F1540", VA = "0x1825F2B40", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006F18")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(OnlineItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F19")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F1A")]
				[Cpp2IlInjected.Address(RVA = "0x25F2D30", Offset = "0x25F1730", VA = "0x1825F2D30", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006F1B")]
				[Cpp2IlInjected.Address(RVA = "0x25F2DF0", Offset = "0x25F17F0", VA = "0x1825F2DF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006F1C")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4003273")]
		private static readonly MessageParser<SyncOnlineInventory> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003274")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700136D")]
		[DebuggerNonUserCode]
		public static MessageParser<SyncOnlineInventory> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006E8E")]
			[Cpp2IlInjected.Address(RVA = "0x788E70", Offset = "0x787870", VA = "0x180788E70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700136E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006E8F")]
			[Cpp2IlInjected.Address(RVA = "0x788DA0", Offset = "0x7877A0", VA = "0x180788DA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700136F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006E90")]
			[Cpp2IlInjected.Address(RVA = "0x788ED0", Offset = "0x7878D0", VA = "0x180788ED0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006E91")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SyncOnlineInventory()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006E92")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SyncOnlineInventory(SyncOnlineInventory other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006E93")]
		[Cpp2IlInjected.Address(RVA = "0x788AC0", Offset = "0x7874C0", VA = "0x180788AC0", Slot = "10")]
		[DebuggerNonUserCode]
		public SyncOnlineInventory Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SyncOnlineInventory syncOnlineInventory = default(SyncOnlineInventory);
			syncOnlineInventory.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (syncOnlineInventory._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return syncOnlineInventory;
		}

		[Cpp2IlInjected.Token(Token = "0x6006E94")]
		[Cpp2IlInjected.Address(RVA = "0x788B40", Offset = "0x787540", VA = "0x180788B40", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006E95")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SyncOnlineInventory other)
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

		[Cpp2IlInjected.Token(Token = "0x6006E96")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006E97")]
		[Cpp2IlInjected.Address(RVA = "0x788C30", Offset = "0x787630", VA = "0x180788C30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006E98")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006E99")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006E9A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SyncOnlineInventory other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006E9B")]
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

		[Cpp2IlInjected.Token(Token = "0x6006E9C")]
		[Cpp2IlInjected.Address(RVA = "0x788BC0", Offset = "0x7875C0", VA = "0x180788BC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006E9D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006E9E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006E9F")]
		[Cpp2IlInjected.Address(RVA = "0x788C90", Offset = "0x787690", VA = "0x180788C90")]
		static SyncOnlineInventory()
		{
			Func<SyncOnlineInventory> func = default(Func<SyncOnlineInventory>);
			_parser = (MessageParser<SyncOnlineInventory>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
