using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class PlaceOnGrid : IMessage<PlaceOnGrid>, IMessage, IEquatable<PlaceOnGrid>, IDeepCloneable<PlaceOnGrid>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				[OriginalName("InvalidItem")]
				InvalidItem,
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				[OriginalName("OverLimits")]
				OverLimits,
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				[OriginalName("Occupied")]
				Occupied
			}

			[Cpp2IlInjected.Token(Token = "0x2000072")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x2000073")]
				public enum SourceOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x400018C")]
					None = 0,
					[Cpp2IlInjected.Token(Token = "0x400018D")]
					From = 9
				}

				[Cpp2IlInjected.Token(Token = "0x4000174")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public const int GridIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public const int PosXFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				private int posX_;

				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public const int PosYFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				private int posY_;

				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public const int OrientationFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private GridOrientation orientation_;

				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public const int GridStateFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private GridState gridState_;

				[Cpp2IlInjected.Token(Token = "0x4000182")]
				public const int ClearAreaFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				private bool clearArea_;

				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public const int AutomaticSpawningFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				private bool automaticSpawning_;

				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public const int FromFieldNumber = 9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private object source_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private SourceOneofCase sourceCase_;

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60005B1")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4580", Offset = "0x1DC2F80", VA = "0x181DC4580")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60005B2")]
					[Cpp2IlInjected.Address(RVA = "0x1DC3FD0", Offset = "0x1DC29D0", VA = "0x181DC3FD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60005B3")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4AD0", Offset = "0x1DC34D0", VA = "0x181DC4AD0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60005B7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60005B8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x60005B9")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x60005BA")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				[DebuggerNonUserCode]
				public int PosX
				{
					[Cpp2IlInjected.Token(Token = "0x60005BB")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60005BC")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				[DebuggerNonUserCode]
				public int PosY
				{
					[Cpp2IlInjected.Token(Token = "0x60005BD")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60005BE")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				[DebuggerNonUserCode]
				public GridOrientation Orientation
				{
					[Cpp2IlInjected.Token(Token = "0x60005BF")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(GridOrientation);
					}
					[Cpp2IlInjected.Token(Token = "0x60005C0")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				[DebuggerNonUserCode]
				public GridState GridState
				{
					[Cpp2IlInjected.Token(Token = "0x60005C1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60005C2")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				[DebuggerNonUserCode]
				public bool ClearArea
				{
					[Cpp2IlInjected.Token(Token = "0x60005C3")]
					[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60005C4")]
					[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				[DebuggerNonUserCode]
				public bool AutomaticSpawning
				{
					[Cpp2IlInjected.Token(Token = "0x60005C5")]
					[Cpp2IlInjected.Address(RVA = "0xBA18B0", Offset = "0xBA02B0", VA = "0x180BA18B0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60005C6")]
					[Cpp2IlInjected.Address(RVA = "0xBA18E0", Offset = "0xBA02E0", VA = "0x180BA18E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				[DebuggerNonUserCode]
				public GridSource From
				{
					[Cpp2IlInjected.Token(Token = "0x60005C7")]
					[Cpp2IlInjected.Address(RVA = "0x1DC42D0", Offset = "0x1DC2CD0", VA = "0x181DC42D0")]
					get
					{
						return default(GridSource);
					}
					[Cpp2IlInjected.Token(Token = "0x60005C8")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4CE0", Offset = "0x1DC36E0", VA = "0x181DC4CE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				[DebuggerNonUserCode]
				public SourceOneofCase SourceCase
				{
					[Cpp2IlInjected.Token(Token = "0x60005C9")]
					[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
					get
					{
						return default(SourceOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				internal bool IgnoreLimits
				{
					[Cpp2IlInjected.Token(Token = "0x60005D8")]
					[Cpp2IlInjected.Address(RVA = "0x70CA70", Offset = "0x70B470", VA = "0x18070CA70")]
					[CompilerGenerated]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60005D9")]
					[Cpp2IlInjected.Address(RVA = "0x70CE60", Offset = "0x70B860", VA = "0x18070CE60")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				internal GridAddObjectOptions AddObjectOptions
				{
					[Cpp2IlInjected.Token(Token = "0x60005DA")]
					[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60005DB")]
					[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public GridSource? Source
				{
					[Cpp2IlInjected.Token(Token = "0x60005DC")]
					[Cpp2IlInjected.Address(RVA = "0x1DC45E0", Offset = "0x1DC2FE0", VA = "0x181DC45E0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60005DD")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4D50", Offset = "0x1DC3750", VA = "0x181DC4D50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3E70", Offset = "0x1DC2870", VA = "0x181DC3E70")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3B60", Offset = "0x1DC2560", VA = "0x181DC3B60")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B6")]
				[Cpp2IlInjected.Address(RVA = "0x1DBFC70", Offset = "0x1DBE670", VA = "0x181DBFC70", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60005CA")]
				[Cpp2IlInjected.Address(RVA = "0x1396870", Offset = "0x1395270", VA = "0x181396870")]
				[DebuggerNonUserCode]
				public void ClearSource()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CB")]
				[Cpp2IlInjected.Address(RVA = "0x1DC00F0", Offset = "0x1DBEAF0", VA = "0x181DC00F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005CC")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0570", Offset = "0x1DBEF70", VA = "0x181DC0570", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005CD")]
				[Cpp2IlInjected.Address(RVA = "0x1DC10A0", Offset = "0x1DBFAA0", VA = "0x181DC10A0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005CE")]
				[Cpp2IlInjected.Address(RVA = "0x1DC25D0", Offset = "0x1DC0FD0", VA = "0x181DC25D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60005CF")]
				[Cpp2IlInjected.Address(RVA = "0x1DC2FF0", Offset = "0x1DC19F0", VA = "0x181DC2FF0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005D0")]
				[Cpp2IlInjected.Address(RVA = "0x1DBF3E0", Offset = "0x1DBDDE0", VA = "0x181DBF3E0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005D1")]
				[Cpp2IlInjected.Address(RVA = "0x1DC12E0", Offset = "0x1DBFCE0", VA = "0x181DC12E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005D2")]
				[Cpp2IlInjected.Address(RVA = "0x1DC1510", Offset = "0x1DBFF10", VA = "0x181DC1510", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005D3")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0870", Offset = "0x1DBF270", VA = "0x181DC0870", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60005D4")]
				[Cpp2IlInjected.Address(RVA = "0x1DC1AF0", Offset = "0x1DC04F0", VA = "0x181DC1AF0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005D5")]
				[Cpp2IlInjected.Address(RVA = "0x1DBF8E0", Offset = "0x1DBE2E0", VA = "0x181DBF8E0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005D6")]
				[Cpp2IlInjected.Address(RVA = "0x1DC1230", Offset = "0x1DBFC30", VA = "0x181DC1230", Slot = "16")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005D7")]
				[Cpp2IlInjected.Address(RVA = "0x1DBF980", Offset = "0x1DBE380", VA = "0x181DBF980", Slot = "17")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005DE")]
				[Cpp2IlInjected.Address(RVA = "0x1DC27C0", Offset = "0x1DC11C0", VA = "0x181DC27C0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000075")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000190")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000191")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000192")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000193")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public const int GridObjectIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60005E4")]
					[Cpp2IlInjected.Address(RVA = "0x1DCEEB0", Offset = "0x1DCD8B0", VA = "0x181DCEEB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60005E5")]
					[Cpp2IlInjected.Address(RVA = "0x1DCEA70", Offset = "0x1DCD470", VA = "0x181DCEA70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60005E6")]
					[Cpp2IlInjected.Address(RVA = "0x1DCF4B0", Offset = "0x1DCDEB0", VA = "0x181DCF4B0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60005EA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60005EB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60005EC")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60005ED")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x60005EE")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x60005EF")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60005FB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60005FC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005E7")]
				[Cpp2IlInjected.Address(RVA = "0x1DCE440", Offset = "0x1DCCE40", VA = "0x181DCE440")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005E8")]
				[Cpp2IlInjected.Address(RVA = "0x1DCE630", Offset = "0x1DCD030", VA = "0x181DCE630")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005E9")]
				[Cpp2IlInjected.Address(RVA = "0x1DC8C30", Offset = "0x1DC7630", VA = "0x181DC8C30", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60005F0")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9510", Offset = "0x1DC7F10", VA = "0x181DC9510", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005F1")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005F2")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005F3")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCC60", Offset = "0x1DCB660", VA = "0x181DCCC60", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60005F4")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCEA0", Offset = "0x1DCB8A0", VA = "0x181DCCEA0", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005F5")]
				[Cpp2IlInjected.Address(RVA = "0x1DC7E00", Offset = "0x1DC6800", VA = "0x181DC7E00", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60005F6")]
				[Cpp2IlInjected.Address(RVA = "0x1DCAAB0", Offset = "0x1DC94B0", VA = "0x181DCAAB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005F7")]
				[Cpp2IlInjected.Address(RVA = "0x1DCB810", Offset = "0x1DCA210", VA = "0x181DCB810", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005F8")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9F00", Offset = "0x1DC8900", VA = "0x181DC9F00", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60005F9")]
				[Cpp2IlInjected.Address(RVA = "0x1DCC0C0", Offset = "0x1DCAAC0", VA = "0x181DCC0C0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005FA")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005FD")]
				[Cpp2IlInjected.Address(RVA = "0x1DC5E20", Offset = "0x1DC4820", VA = "0x181DC5E20", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static readonly MessageParser<PlaceOnGrid> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		[DebuggerNonUserCode]
		public static MessageParser<PlaceOnGrid> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B7CE0", VA = "0x1807B92E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x7B9210", Offset = "0x7B7C10", VA = "0x1807B9210")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x7B9340", Offset = "0x7B7D40", VA = "0x1807B9340", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PlaceOnGrid()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PlaceOnGrid(PlaceOnGrid other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7930", VA = "0x1807B8F30", Slot = "10")]
		[DebuggerNonUserCode]
		public PlaceOnGrid Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PlaceOnGrid placeOnGrid = default(PlaceOnGrid);
			placeOnGrid.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (placeOnGrid._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return placeOnGrid;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8FB0", Offset = "0x7B79B0", VA = "0x1807B8FB0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PlaceOnGrid other)
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

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B90A0", Offset = "0x7B7AA0", VA = "0x1807B90A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PlaceOnGrid other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
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

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B9030", Offset = "0x7B7A30", VA = "0x1807B9030", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B9100", Offset = "0x7B7B00", VA = "0x1807B9100")]
		static PlaceOnGrid()
		{
			Func<PlaceOnGrid> func = default(Func<PlaceOnGrid>);
			_parser = (MessageParser<PlaceOnGrid>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
