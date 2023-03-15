using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	public sealed class ReplaceGridObject : IMessage<ReplaceGridObject>, IMessage, IEquatable<ReplaceGridObject>, IDeepCloneable<ReplaceGridObject>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200016B")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40004F4")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40004F5")]
				[OriginalName("InvalidOldGridID")]
				InvalidOldGridId,
				[Cpp2IlInjected.Token(Token = "0x40004F6")]
				[OriginalName("InvalidOldGridObjectID")]
				InvalidOldGridObjectId,
				[Cpp2IlInjected.Token(Token = "0x40004F7")]
				[OriginalName("InvalidInventory")]
				InvalidInventory,
				[Cpp2IlInjected.Token(Token = "0x40004F8")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x40004F9")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x40004FA")]
				[OriginalName("OverLimits")]
				OverLimits,
				[Cpp2IlInjected.Token(Token = "0x40004FB")]
				[OriginalName("Occupied")]
				Occupied
			}

			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40004FC")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40004FD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40004FE")]
				public const int OldGridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004FF")]
				private uint oldGridID_;

				[Cpp2IlInjected.Token(Token = "0x4000500")]
				public const int OldGridObjectIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000501")]
				private uint oldGridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x4000502")]
				public const int InventoryIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000503")]
				private uint inventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000504")]
				public const int ItemIDFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000505")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000506")]
				public const int GridIDFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000507")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x4000508")]
				public const int PosXFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000509")]
				private int posX_;

				[Cpp2IlInjected.Token(Token = "0x400050A")]
				public const int PosYFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400050B")]
				private int posY_;

				[Cpp2IlInjected.Token(Token = "0x400050C")]
				public const int OrientationFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x400050D")]
				private GridOrientation orientation_;

				[Cpp2IlInjected.Token(Token = "0x400050E")]
				public const int ClearAreaFieldNumber = 9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400050F")]
				private bool clearArea_;

				[Cpp2IlInjected.Token(Token = "0x170002AE")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000F7C")]
					[Cpp2IlInjected.Address(RVA = "0x200C3D0", Offset = "0x200ADD0", VA = "0x18200C3D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002AF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000F7D")]
					[Cpp2IlInjected.Address(RVA = "0x200BFB0", Offset = "0x200A9B0", VA = "0x18200BFB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000F7E")]
					[Cpp2IlInjected.Address(RVA = "0x200C730", Offset = "0x200B130", VA = "0x18200C730", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B1")]
				[DebuggerNonUserCode]
				public uint OldGridID
				{
					[Cpp2IlInjected.Token(Token = "0x6000F82")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F83")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B2")]
				[DebuggerNonUserCode]
				public uint OldGridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6000F84")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F85")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B3")]
				[DebuggerNonUserCode]
				public uint InventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x6000F86")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F87")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B4")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6000F88")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F89")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B5")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6000F8A")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F8B")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B6")]
				[DebuggerNonUserCode]
				public int PosX
				{
					[Cpp2IlInjected.Token(Token = "0x6000F8C")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F8D")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B7")]
				[DebuggerNonUserCode]
				public int PosY
				{
					[Cpp2IlInjected.Token(Token = "0x6000F8E")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F8F")]
					[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B8")]
				[DebuggerNonUserCode]
				public GridOrientation Orientation
				{
					[Cpp2IlInjected.Token(Token = "0x6000F90")]
					[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
					get
					{
						return default(GridOrientation);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F91")]
					[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002B9")]
				[DebuggerNonUserCode]
				public bool ClearArea
				{
					[Cpp2IlInjected.Token(Token = "0x6000F92")]
					[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000F93")]
					[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000F7F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F80")]
				[Cpp2IlInjected.Address(RVA = "0x200B440", Offset = "0x2009E40", VA = "0x18200B440")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F81")]
				[Cpp2IlInjected.Address(RVA = "0x2005EF0", Offset = "0x20048F0", VA = "0x182005EF0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F94")]
				[Cpp2IlInjected.Address(RVA = "0x2006750", Offset = "0x2005150", VA = "0x182006750", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F95")]
				[Cpp2IlInjected.Address(RVA = "0x2006650", Offset = "0x2005050", VA = "0x182006650", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F96")]
				[Cpp2IlInjected.Address(RVA = "0x20075D0", Offset = "0x2005FD0", VA = "0x1820075D0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F97")]
				[Cpp2IlInjected.Address(RVA = "0x2009570", Offset = "0x2007F70", VA = "0x182009570", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F98")]
				[Cpp2IlInjected.Address(RVA = "0x200A0A0", Offset = "0x2008AA0", VA = "0x18200A0A0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F99")]
				[Cpp2IlInjected.Address(RVA = "0x2004DB0", Offset = "0x20037B0", VA = "0x182004DB0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000F9A")]
				[Cpp2IlInjected.Address(RVA = "0x2008620", Offset = "0x2007020", VA = "0x182008620", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F9B")]
				[Cpp2IlInjected.Address(RVA = "0x20081A0", Offset = "0x2006BA0", VA = "0x1820081A0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F9C")]
				[Cpp2IlInjected.Address(RVA = "0x2006BA0", Offset = "0x20055A0", VA = "0x182006BA0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000F9D")]
				[Cpp2IlInjected.Address(RVA = "0x2008F70", Offset = "0x2007970", VA = "0x182008F70", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000F9E")]
				[Cpp2IlInjected.Address(RVA = "0x20055E0", Offset = "0x2003FE0", VA = "0x1820055E0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200016E")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000511")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000512")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000513")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000514")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000515")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000516")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000517")]
				public const int GridObjectIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000518")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x170002BA")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000FA3")]
					[Cpp2IlInjected.Address(RVA = "0x20197C0", Offset = "0x20181C0", VA = "0x1820197C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002BB")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000FA4")]
					[Cpp2IlInjected.Address(RVA = "0x2019660", Offset = "0x2018060", VA = "0x182019660")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002BC")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000FA5")]
					[Cpp2IlInjected.Address(RVA = "0x2019D60", Offset = "0x2018760", VA = "0x182019D60", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002BD")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6000FA9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000FAA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002BE")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6000FAB")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000FAC")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002BF")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6000FAD")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6000FAE")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002C0")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6000FBA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6000FBB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000FA6")]
				[Cpp2IlInjected.Address(RVA = "0x2018180", Offset = "0x2016B80", VA = "0x182018180")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000FA7")]
				[Cpp2IlInjected.Address(RVA = "0x2018630", Offset = "0x2017030", VA = "0x182018630")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000FA8")]
				[Cpp2IlInjected.Address(RVA = "0x20113F0", Offset = "0x200FDF0", VA = "0x1820113F0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000FAF")]
				[Cpp2IlInjected.Address(RVA = "0x2012200", Offset = "0x2010C00", VA = "0x182012200", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB0")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB1")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB2")]
				[Cpp2IlInjected.Address(RVA = "0x2016870", Offset = "0x2015270", VA = "0x182016870", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB3")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCEA0", Offset = "0x1DCB8A0", VA = "0x181DCCEA0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB4")]
				[Cpp2IlInjected.Address(RVA = "0x200FF70", Offset = "0x200E970", VA = "0x18200FF70", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB5")]
				[Cpp2IlInjected.Address(RVA = "0x20142F0", Offset = "0x2012CF0", VA = "0x1820142F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB6")]
				[Cpp2IlInjected.Address(RVA = "0x2013D50", Offset = "0x2012750", VA = "0x182013D50", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB7")]
				[Cpp2IlInjected.Address(RVA = "0x2013620", Offset = "0x2012020", VA = "0x182013620", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB8")]
				[Cpp2IlInjected.Address(RVA = "0x2015CD0", Offset = "0x20146D0", VA = "0x182015CD0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000FB9")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000FBC")]
				[Cpp2IlInjected.Address(RVA = "0x200E970", Offset = "0x200D370", VA = "0x18200E970", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000FBD")]
				[Cpp2IlInjected.Address(RVA = "0x20156F0", Offset = "0x20140F0", VA = "0x1820156F0")]
				private bool SameType(Item item1, Item item2)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private static readonly MessageParser<ReplaceGridObject> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		[DebuggerNonUserCode]
		public static MessageParser<ReplaceGridObject> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000F6A")]
			[Cpp2IlInjected.Address(RVA = "0x5C9E80", Offset = "0x5C8880", VA = "0x1805C9E80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F6B")]
			[Cpp2IlInjected.Address(RVA = "0x5C9DB0", Offset = "0x5C87B0", VA = "0x1805C9DB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000F6C")]
			[Cpp2IlInjected.Address(RVA = "0x5C9EE0", Offset = "0x5C88E0", VA = "0x1805C9EE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ReplaceGridObject()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ReplaceGridObject(ReplaceGridObject other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6F")]
		[Cpp2IlInjected.Address(RVA = "0x5C9AD0", Offset = "0x5C84D0", VA = "0x1805C9AD0", Slot = "10")]
		[DebuggerNonUserCode]
		public ReplaceGridObject Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ReplaceGridObject replaceGridObject = default(ReplaceGridObject);
			replaceGridObject.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (replaceGridObject._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return replaceGridObject;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F70")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B50", Offset = "0x5C8550", VA = "0x1805C9B50", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F71")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ReplaceGridObject other)
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

		[Cpp2IlInjected.Token(Token = "0x6000F72")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F73")]
		[Cpp2IlInjected.Address(RVA = "0x5C9C40", Offset = "0x5C8640", VA = "0x1805C9C40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F74")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F75")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F76")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ReplaceGridObject other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F77")]
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

		[Cpp2IlInjected.Token(Token = "0x6000F78")]
		[Cpp2IlInjected.Address(RVA = "0x5C9BD0", Offset = "0x5C85D0", VA = "0x1805C9BD0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F79")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000F7B")]
		[Cpp2IlInjected.Address(RVA = "0x5C9CA0", Offset = "0x5C86A0", VA = "0x1805C9CA0")]
		static ReplaceGridObject()
		{
			Func<ReplaceGridObject> func = default(Func<ReplaceGridObject>);
			_parser = (MessageParser<ReplaceGridObject>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
