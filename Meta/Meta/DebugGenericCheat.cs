using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Actions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public sealed class DebugGenericCheat : IMessage<DebugGenericCheat>, IMessage, IEquatable<DebugGenericCheat>, IDeepCloneable<DebugGenericCheat>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20000B0")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400023C")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x400023D")]
				[OriginalName("NotDeveloper")]
				NotDeveloper,
				[Cpp2IlInjected.Token(Token = "0x400023E")]
				[OriginalName("NotImplemented")]
				NotImplemented,
				[Cpp2IlInjected.Token(Token = "0x400023F")]
				[OriginalName("InvalidParam")]
				InvalidParam,
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				[OriginalName("UnknownError")]
				UnknownError
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			public sealed class BuildHouse : IMessage<BuildHouse>, IMessage, IEquatable<BuildHouse>, IDeepCloneable<BuildHouse>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000241")]
				private static readonly MessageParser<BuildHouse> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000242")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public const int GridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public const int ObjectGridIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private uint objectGridID_;

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				[DebuggerNonUserCode]
				public static MessageParser<BuildHouse> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60007F2")]
					[Cpp2IlInjected.Address(RVA = "0x201BF40", Offset = "0x201A940", VA = "0x18201BF40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60007F3")]
					[Cpp2IlInjected.Address(RVA = "0x201BEC0", Offset = "0x201A8C0", VA = "0x18201BEC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60007F4")]
					[Cpp2IlInjected.Address(RVA = "0x201BFA0", Offset = "0x201A9A0", VA = "0x18201BFA0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x60007F8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x60007F9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				[DebuggerNonUserCode]
				public uint ObjectGridID
				{
					[Cpp2IlInjected.Token(Token = "0x60007FA")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x60007FB")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60007F5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public BuildHouse()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007F6")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public BuildHouse(BuildHouse other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007F7")]
				[Cpp2IlInjected.Address(RVA = "0x201BAB0", Offset = "0x201A4B0", VA = "0x18201BAB0", Slot = "10")]
				[DebuggerNonUserCode]
				public BuildHouse Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60007FC")]
				[Cpp2IlInjected.Address(RVA = "0x201BB40", Offset = "0x201A540", VA = "0x18201BB40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60007FD")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(BuildHouse other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60007FE")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60007FF")]
				[Cpp2IlInjected.Address(RVA = "0x201BD50", Offset = "0x201A750", VA = "0x18201BD50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000800")]
				[Cpp2IlInjected.Address(RVA = "0x108E870", Offset = "0x108D270", VA = "0x18108E870", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000801")]
				[Cpp2IlInjected.Address(RVA = "0x201B9E0", Offset = "0x201A3E0", VA = "0x18201B9E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000802")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(BuildHouse other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000803")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000804")]
				[Cpp2IlInjected.Address(RVA = "0x201BBD0", Offset = "0x201A5D0", VA = "0x18201BBD0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000805")]
				[Cpp2IlInjected.Address(RVA = "0x201BC90", Offset = "0x201A690", VA = "0x18201BC90", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000806")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			public sealed class ForceSpecificFish : IMessage<ForceSpecificFish>, IMessage, IEquatable<ForceSpecificFish>, IDeepCloneable<ForceSpecificFish>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x20000B4")]
				public enum FishOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x4000251")]
					None = 0,
					[Cpp2IlInjected.Token(Token = "0x4000252")]
					FishItemID = 2,
					[Cpp2IlInjected.Token(Token = "0x4000253")]
					FishRarity = 3
				}

				[Cpp2IlInjected.Token(Token = "0x4000248")]
				private static readonly MessageParser<ForceSpecificFish> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public const int EnabledFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				private bool enabled_;

				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public const int FishItemIDFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public const int FishRarityFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				private object fish_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				private FishOneofCase fishCase_;

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				[DebuggerNonUserCode]
				public static MessageParser<ForceSpecificFish> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600080B")]
					[Cpp2IlInjected.Address(RVA = "0x201E160", Offset = "0x201CB60", VA = "0x18201E160")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600080C")]
					[Cpp2IlInjected.Address(RVA = "0x201E000", Offset = "0x201CA00", VA = "0x18201E000")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600080D")]
					[Cpp2IlInjected.Address(RVA = "0x201E1C0", Offset = "0x201CBC0", VA = "0x18201E1C0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				[DebuggerNonUserCode]
				public bool Enabled
				{
					[Cpp2IlInjected.Token(Token = "0x6000811")]
					[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000812")]
					[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				[DebuggerNonUserCode]
				public int FishItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6000813")]
					[Cpp2IlInjected.Address(RVA = "0x201E080", Offset = "0x201CA80", VA = "0x18201E080")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000814")]
					[Cpp2IlInjected.Address(RVA = "0x201E280", Offset = "0x201CC80", VA = "0x18201E280")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				[DebuggerNonUserCode]
				public FishRarity FishRarity
				{
					[Cpp2IlInjected.Token(Token = "0x6000815")]
					[Cpp2IlInjected.Address(RVA = "0x201E0F0", Offset = "0x201CAF0", VA = "0x18201E0F0")]
					get
					{
						return default(FishRarity);
					}
					[Cpp2IlInjected.Token(Token = "0x6000816")]
					[Cpp2IlInjected.Address(RVA = "0x201E2F0", Offset = "0x201CCF0", VA = "0x18201E2F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				[DebuggerNonUserCode]
				public FishOneofCase FishCase
				{
					[Cpp2IlInjected.Token(Token = "0x6000817")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(FishOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600080E")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ForceSpecificFish()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600080F")]
				[Cpp2IlInjected.Address(RVA = "0x201DF20", Offset = "0x201C920", VA = "0x18201DF20")]
				[DebuggerNonUserCode]
				public ForceSpecificFish(ForceSpecificFish other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000810")]
				[Cpp2IlInjected.Address(RVA = "0x201D440", Offset = "0x201BE40", VA = "0x18201D440", Slot = "10")]
				[DebuggerNonUserCode]
				public ForceSpecificFish Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000818")]
				[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
				[DebuggerNonUserCode]
				public void ClearFish()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000819")]
				[Cpp2IlInjected.Address(RVA = "0x201D550", Offset = "0x201BF50", VA = "0x18201D550", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600081A")]
				[Cpp2IlInjected.Address(RVA = "0x201D630", Offset = "0x201C030", VA = "0x18201D630", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ForceSpecificFish other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600081B")]
				[Cpp2IlInjected.Address(RVA = "0x201D810", Offset = "0x201C210", VA = "0x18201D810", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600081C")]
				[Cpp2IlInjected.Address(RVA = "0x201DCE0", Offset = "0x201C6E0", VA = "0x18201DCE0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600081D")]
				[Cpp2IlInjected.Address(RVA = "0x201DD40", Offset = "0x201C740", VA = "0x18201DD40", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600081E")]
				[Cpp2IlInjected.Address(RVA = "0x201D180", Offset = "0x201BB80", VA = "0x18201D180", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600081F")]
				[Cpp2IlInjected.Address(RVA = "0x201DB10", Offset = "0x201C510", VA = "0x18201DB10", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ForceSpecificFish other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000820")]
				[Cpp2IlInjected.Address(RVA = "0x201DA10", Offset = "0x201C410", VA = "0x18201DA10", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000821")]
				[Cpp2IlInjected.Address(RVA = "0x201D6E0", Offset = "0x201C0E0", VA = "0x18201D6E0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000822")]
				[Cpp2IlInjected.Address(RVA = "0x201DBA0", Offset = "0x201C5A0", VA = "0x18201DBA0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000823")]
				[Cpp2IlInjected.Address(RVA = "0x201D300", Offset = "0x201BD00", VA = "0x18201D300", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000824")]
				[Cpp2IlInjected.Address(RVA = "0x201D960", Offset = "0x201C360", VA = "0x18201D960", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000825")]
				[Cpp2IlInjected.Address(RVA = "0x201D3D0", Offset = "0x201BDD0", VA = "0x18201D3D0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			public sealed class ForceSpecificMining : IMessage<ForceSpecificMining>, IMessage, IEquatable<ForceSpecificMining>, IDeepCloneable<ForceSpecificMining>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				private static readonly MessageParser<ForceSpecificMining> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000257")]
				public const int MiningItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000258")]
				private int miningItemID_;

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				[DebuggerNonUserCode]
				public static MessageParser<ForceSpecificMining> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600082A")]
					[Cpp2IlInjected.Address(RVA = "0x201E830", Offset = "0x201D230", VA = "0x18201E830")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600082B")]
					[Cpp2IlInjected.Address(RVA = "0x201E7B0", Offset = "0x201D1B0", VA = "0x18201E7B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600082C")]
					[Cpp2IlInjected.Address(RVA = "0x201E890", Offset = "0x201D290", VA = "0x18201E890", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				[DebuggerNonUserCode]
				public int MiningItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6000830")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000831")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600082D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ForceSpecificMining()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600082E")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
				[DebuggerNonUserCode]
				public ForceSpecificMining(ForceSpecificMining other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600082F")]
				[Cpp2IlInjected.Address(RVA = "0x201E400", Offset = "0x201CE00", VA = "0x18201E400", Slot = "10")]
				[DebuggerNonUserCode]
				public ForceSpecificMining Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000832")]
				[Cpp2IlInjected.Address(RVA = "0x201E480", Offset = "0x201CE80", VA = "0x18201E480", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000833")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ForceSpecificMining other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000834")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000835")]
				[Cpp2IlInjected.Address(RVA = "0x201E640", Offset = "0x201D040", VA = "0x18201E640", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000836")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000837")]
				[Cpp2IlInjected.Address(RVA = "0x201E360", Offset = "0x201CD60", VA = "0x18201E360", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000838")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ForceSpecificMining other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000839")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600083A")]
				[Cpp2IlInjected.Address(RVA = "0x201E510", Offset = "0x201CF10", VA = "0x18201E510", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600083B")]
				[Cpp2IlInjected.Address(RVA = "0x201E5C0", Offset = "0x201CFC0", VA = "0x18201E5C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600083C")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B8")]
			public sealed class GenerateAllMissions : IMessage<GenerateAllMissions>, IMessage, IEquatable<GenerateAllMissions>, IDeepCloneable<GenerateAllMissions>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400025A")]
				private static readonly MessageParser<GenerateAllMissions> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400025B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				[DebuggerNonUserCode]
				public static MessageParser<GenerateAllMissions> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000841")]
					[Cpp2IlInjected.Address(RVA = "0x201FC70", Offset = "0x201E670", VA = "0x18201FC70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000842")]
					[Cpp2IlInjected.Address(RVA = "0x201FBF0", Offset = "0x201E5F0", VA = "0x18201FBF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000843")]
					[Cpp2IlInjected.Address(RVA = "0x201FCD0", Offset = "0x201E6D0", VA = "0x18201FCD0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000844")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public GenerateAllMissions()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000845")]
				[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
				[DebuggerNonUserCode]
				public GenerateAllMissions(GenerateAllMissions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000846")]
				[Cpp2IlInjected.Address(RVA = "0x201F910", Offset = "0x201E310", VA = "0x18201F910", Slot = "10")]
				[DebuggerNonUserCode]
				public GenerateAllMissions Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000847")]
				[Cpp2IlInjected.Address(RVA = "0x201F990", Offset = "0x201E390", VA = "0x18201F990", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000848")]
				[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(GenerateAllMissions other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000849")]
				[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600084A")]
				[Cpp2IlInjected.Address(RVA = "0x201FA80", Offset = "0x201E480", VA = "0x18201FA80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600084B")]
				[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600084C")]
				[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600084D")]
				[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(GenerateAllMissions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600084E")]
				[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600084F")]
				[Cpp2IlInjected.Address(RVA = "0x201FA10", Offset = "0x201E410", VA = "0x18201FA10", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000850")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000851")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000BA")]
			public sealed class RemoveNightThorns : IMessage<RemoveNightThorns>, IMessage, IEquatable<RemoveNightThorns>, IDeepCloneable<RemoveNightThorns>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400025D")]
				private static readonly MessageParser<RemoveNightThorns> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400025E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400025F")]
				public const int KeepOneEveryFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				private int keepOneEvery_;

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				[DebuggerNonUserCode]
				public static MessageParser<RemoveNightThorns> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000856")]
					[Cpp2IlInjected.Address(RVA = "0x2020ED0", Offset = "0x201F8D0", VA = "0x182020ED0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000857")]
					[Cpp2IlInjected.Address(RVA = "0x2020E50", Offset = "0x201F850", VA = "0x182020E50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000858")]
					[Cpp2IlInjected.Address(RVA = "0x2020F30", Offset = "0x201F930", VA = "0x182020F30", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				[DebuggerNonUserCode]
				public int KeepOneEvery
				{
					[Cpp2IlInjected.Token(Token = "0x600085C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600085D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000859")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public RemoveNightThorns()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600085A")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
				[DebuggerNonUserCode]
				public RemoveNightThorns(RemoveNightThorns other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600085B")]
				[Cpp2IlInjected.Address(RVA = "0x2020AA0", Offset = "0x201F4A0", VA = "0x182020AA0", Slot = "10")]
				[DebuggerNonUserCode]
				public RemoveNightThorns Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600085E")]
				[Cpp2IlInjected.Address(RVA = "0x2020B20", Offset = "0x201F520", VA = "0x182020B20", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600085F")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(RemoveNightThorns other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000860")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000861")]
				[Cpp2IlInjected.Address(RVA = "0x2020CE0", Offset = "0x201F6E0", VA = "0x182020CE0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000862")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000863")]
				[Cpp2IlInjected.Address(RVA = "0x2020A00", Offset = "0x201F400", VA = "0x182020A00", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000864")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(RemoveNightThorns other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000865")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000866")]
				[Cpp2IlInjected.Address(RVA = "0x2020BB0", Offset = "0x201F5B0", VA = "0x182020BB0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000867")]
				[Cpp2IlInjected.Address(RVA = "0x2020C60", Offset = "0x201F660", VA = "0x182020C60", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000868")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000BC")]
			public sealed class RemoveBlockers : IMessage<RemoveBlockers>, IMessage, IEquatable<RemoveBlockers>, IDeepCloneable<RemoveBlockers>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				private static readonly MessageParser<RemoveBlockers> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000264")]
				public const int BlockerItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				private int blockerItemID_;

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				[DebuggerNonUserCode]
				public static MessageParser<RemoveBlockers> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600086D")]
					[Cpp2IlInjected.Address(RVA = "0x20208E0", Offset = "0x201F2E0", VA = "0x1820208E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600086E")]
					[Cpp2IlInjected.Address(RVA = "0x2020860", Offset = "0x201F260", VA = "0x182020860")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600086F")]
					[Cpp2IlInjected.Address(RVA = "0x2020940", Offset = "0x201F340", VA = "0x182020940", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				[DebuggerNonUserCode]
				public int BlockerItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6000873")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000874")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000870")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public RemoveBlockers()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000871")]
				[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
				[DebuggerNonUserCode]
				public RemoveBlockers(RemoveBlockers other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000872")]
				[Cpp2IlInjected.Address(RVA = "0x20204B0", Offset = "0x201EEB0", VA = "0x1820204B0", Slot = "10")]
				[DebuggerNonUserCode]
				public RemoveBlockers Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000875")]
				[Cpp2IlInjected.Address(RVA = "0x2020530", Offset = "0x201EF30", VA = "0x182020530", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000876")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(RemoveBlockers other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000877")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000878")]
				[Cpp2IlInjected.Address(RVA = "0x20206F0", Offset = "0x201F0F0", VA = "0x1820206F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000879")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600087A")]
				[Cpp2IlInjected.Address(RVA = "0x2020410", Offset = "0x201EE10", VA = "0x182020410", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600087B")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(RemoveBlockers other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600087C")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600087D")]
				[Cpp2IlInjected.Address(RVA = "0x20205C0", Offset = "0x201EFC0", VA = "0x1820205C0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600087E")]
				[Cpp2IlInjected.Address(RVA = "0x2020670", Offset = "0x201F070", VA = "0x182020670", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600087F")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000BE")]
			public sealed class UnlockAllTools : IMessage<UnlockAllTools>, IMessage, IEquatable<UnlockAllTools>, IDeepCloneable<UnlockAllTools>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				private static readonly MessageParser<UnlockAllTools> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000268")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				[DebuggerNonUserCode]
				public static MessageParser<UnlockAllTools> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000884")]
					[Cpp2IlInjected.Address(RVA = "0x2031CF0", Offset = "0x20306F0", VA = "0x182031CF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000885")]
					[Cpp2IlInjected.Address(RVA = "0x2031C70", Offset = "0x2030670", VA = "0x182031C70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000886")]
					[Cpp2IlInjected.Address(RVA = "0x2031D50", Offset = "0x2030750", VA = "0x182031D50", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000887")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public UnlockAllTools()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000888")]
				[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
				[DebuggerNonUserCode]
				public UnlockAllTools(UnlockAllTools other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000889")]
				[Cpp2IlInjected.Address(RVA = "0x2031990", Offset = "0x2030390", VA = "0x182031990", Slot = "10")]
				[DebuggerNonUserCode]
				public UnlockAllTools Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600088A")]
				[Cpp2IlInjected.Address(RVA = "0x2031A10", Offset = "0x2030410", VA = "0x182031A10", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600088B")]
				[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(UnlockAllTools other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600088C")]
				[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600088D")]
				[Cpp2IlInjected.Address(RVA = "0x2031B00", Offset = "0x2030500", VA = "0x182031B00", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600088E")]
				[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600088F")]
				[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000890")]
				[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(UnlockAllTools other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000891")]
				[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000892")]
				[Cpp2IlInjected.Address(RVA = "0x2031A90", Offset = "0x2030490", VA = "0x182031A90", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000893")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000894")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C0")]
			public sealed class UnlockAllRecipies : IMessage<UnlockAllRecipies>, IMessage, IEquatable<UnlockAllRecipies>, IDeepCloneable<UnlockAllRecipies>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400026A")]
				private static readonly MessageParser<UnlockAllRecipies> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400026B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				[DebuggerNonUserCode]
				public static MessageParser<UnlockAllRecipies> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000899")]
					[Cpp2IlInjected.Address(RVA = "0x2031870", Offset = "0x2030270", VA = "0x182031870")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600089A")]
					[Cpp2IlInjected.Address(RVA = "0x20317F0", Offset = "0x20301F0", VA = "0x1820317F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600089B")]
					[Cpp2IlInjected.Address(RVA = "0x20318D0", Offset = "0x20302D0", VA = "0x1820318D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600089C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public UnlockAllRecipies()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600089D")]
				[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
				[DebuggerNonUserCode]
				public UnlockAllRecipies(UnlockAllRecipies other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600089E")]
				[Cpp2IlInjected.Address(RVA = "0x2031510", Offset = "0x202FF10", VA = "0x182031510", Slot = "10")]
				[DebuggerNonUserCode]
				public UnlockAllRecipies Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600089F")]
				[Cpp2IlInjected.Address(RVA = "0x2031590", Offset = "0x202FF90", VA = "0x182031590", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60008A0")]
				[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(UnlockAllRecipies other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60008A1")]
				[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60008A2")]
				[Cpp2IlInjected.Address(RVA = "0x2031680", Offset = "0x2030080", VA = "0x182031680", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008A3")]
				[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008A4")]
				[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60008A5")]
				[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(UnlockAllRecipies other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008A6")]
				[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008A7")]
				[Cpp2IlInjected.Address(RVA = "0x2031610", Offset = "0x2030010", VA = "0x182031610", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008A8")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008A9")]
				[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C2")]
			public sealed class ForceSpecificStoreFilter : IMessage<ForceSpecificStoreFilter>, IMessage, IEquatable<ForceSpecificStoreFilter>, IDeepCloneable<ForceSpecificStoreFilter>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				private static readonly MessageParser<ForceSpecificStoreFilter> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400026E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400026F")]
				public const int DisplayItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000270")]
				private int displayItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public const int FilterTypeFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				private int filterType_;

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				[DebuggerNonUserCode]
				public static MessageParser<ForceSpecificStoreFilter> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60008AE")]
					[Cpp2IlInjected.Address(RVA = "0x201EEB0", Offset = "0x201D8B0", VA = "0x18201EEB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60008AF")]
					[Cpp2IlInjected.Address(RVA = "0x201EE30", Offset = "0x201D830", VA = "0x18201EE30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60008B0")]
					[Cpp2IlInjected.Address(RVA = "0x201EF10", Offset = "0x201D910", VA = "0x18201EF10", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				[DebuggerNonUserCode]
				public int DisplayItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60008B4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60008B5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				[DebuggerNonUserCode]
				public int FilterType
				{
					[Cpp2IlInjected.Token(Token = "0x60008B6")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60008B7")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60008B1")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ForceSpecificStoreFilter()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008B2")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public ForceSpecificStoreFilter(ForceSpecificStoreFilter other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008B3")]
				[Cpp2IlInjected.Address(RVA = "0x201EA20", Offset = "0x201D420", VA = "0x18201EA20", Slot = "10")]
				[DebuggerNonUserCode]
				public ForceSpecificStoreFilter Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008B8")]
				[Cpp2IlInjected.Address(RVA = "0x201EAB0", Offset = "0x201D4B0", VA = "0x18201EAB0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60008B9")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ForceSpecificStoreFilter other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60008BA")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60008BB")]
				[Cpp2IlInjected.Address(RVA = "0x201ECC0", Offset = "0x201D6C0", VA = "0x18201ECC0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008BC")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008BD")]
				[Cpp2IlInjected.Address(RVA = "0x201E950", Offset = "0x201D350", VA = "0x18201E950", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60008BE")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ForceSpecificStoreFilter other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008BF")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008C0")]
				[Cpp2IlInjected.Address(RVA = "0x201EB40", Offset = "0x201D540", VA = "0x18201EB40", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008C1")]
				[Cpp2IlInjected.Address(RVA = "0x201EC00", Offset = "0x201D600", VA = "0x18201EC00", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008C2")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C4")]
			public sealed class GiveBuilding : IMessage<GiveBuilding>, IMessage, IEquatable<GiveBuilding>, IDeepCloneable<GiveBuilding>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				private static readonly MessageParser<GiveBuilding> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000275")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000276")]
				public const int BuildingIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000277")]
				private int buildingID_;

				[Cpp2IlInjected.Token(Token = "0x4000278")]
				public const int FreeUnlockFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000279")]
				private bool freeUnlock_;

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				[DebuggerNonUserCode]
				public static MessageParser<GiveBuilding> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60008C7")]
					[Cpp2IlInjected.Address(RVA = "0x20202F0", Offset = "0x201ECF0", VA = "0x1820202F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60008C8")]
					[Cpp2IlInjected.Address(RVA = "0x2020270", Offset = "0x201EC70", VA = "0x182020270")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60008C9")]
					[Cpp2IlInjected.Address(RVA = "0x2020350", Offset = "0x201ED50", VA = "0x182020350", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				[DebuggerNonUserCode]
				public int BuildingID
				{
					[Cpp2IlInjected.Token(Token = "0x60008CD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60008CE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				[DebuggerNonUserCode]
				public bool FreeUnlock
				{
					[Cpp2IlInjected.Token(Token = "0x60008CF")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60008D0")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60008CA")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public GiveBuilding()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008CB")]
				[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
				[DebuggerNonUserCode]
				public GiveBuilding(GiveBuilding other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008CC")]
				[Cpp2IlInjected.Address(RVA = "0x201FE20", Offset = "0x201E820", VA = "0x18201FE20", Slot = "10")]
				[DebuggerNonUserCode]
				public GiveBuilding Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008D1")]
				[Cpp2IlInjected.Address(RVA = "0x201FEB0", Offset = "0x201E8B0", VA = "0x18201FEB0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60008D2")]
				[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(GiveBuilding other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60008D3")]
				[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60008D4")]
				[Cpp2IlInjected.Address(RVA = "0x2020100", Offset = "0x201EB00", VA = "0x182020100", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008D5")]
				[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008D6")]
				[Cpp2IlInjected.Address(RVA = "0x201FD90", Offset = "0x201E790", VA = "0x18201FD90", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60008D7")]
				[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(GiveBuilding other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008D8")]
				[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008D9")]
				[Cpp2IlInjected.Address(RVA = "0x201FF40", Offset = "0x201E940", VA = "0x18201FF40", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008DA")]
				[Cpp2IlInjected.Address(RVA = "0x2020030", Offset = "0x201EA30", VA = "0x182020030", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008DB")]
				[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C6")]
			public sealed class UnlockMemoryShard : IMessage<UnlockMemoryShard>, IMessage, IEquatable<UnlockMemoryShard>, IDeepCloneable<UnlockMemoryShard>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400027B")]
				private static readonly MessageParser<UnlockMemoryShard> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400027C")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400027D")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400027E")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x400027F")]
				public const int IndexFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000280")]
				private int index_;

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				[DebuggerNonUserCode]
				public static MessageParser<UnlockMemoryShard> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60008E0")]
					[Cpp2IlInjected.Address(RVA = "0x2032370", Offset = "0x2030D70", VA = "0x182032370")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60008E1")]
					[Cpp2IlInjected.Address(RVA = "0x20322F0", Offset = "0x2030CF0", VA = "0x1820322F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60008E2")]
					[Cpp2IlInjected.Address(RVA = "0x20323D0", Offset = "0x2030DD0", VA = "0x1820323D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60008E6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60008E7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				[DebuggerNonUserCode]
				public int Index
				{
					[Cpp2IlInjected.Token(Token = "0x60008E8")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60008E9")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60008E3")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public UnlockMemoryShard()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008E4")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public UnlockMemoryShard(UnlockMemoryShard other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008E5")]
				[Cpp2IlInjected.Address(RVA = "0x2031EE0", Offset = "0x20308E0", VA = "0x182031EE0", Slot = "10")]
				[DebuggerNonUserCode]
				public UnlockMemoryShard Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008EA")]
				[Cpp2IlInjected.Address(RVA = "0x2031F70", Offset = "0x2030970", VA = "0x182031F70", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60008EB")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(UnlockMemoryShard other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60008EC")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60008ED")]
				[Cpp2IlInjected.Address(RVA = "0x2032180", Offset = "0x2030B80", VA = "0x182032180", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008EE")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008EF")]
				[Cpp2IlInjected.Address(RVA = "0x2031E10", Offset = "0x2030810", VA = "0x182031E10", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60008F0")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(UnlockMemoryShard other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008F1")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008F2")]
				[Cpp2IlInjected.Address(RVA = "0x2032000", Offset = "0x2030A00", VA = "0x182032000", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60008F3")]
				[Cpp2IlInjected.Address(RVA = "0x20320C0", Offset = "0x2030AC0", VA = "0x1820320C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008F4")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C8")]
			public sealed class ForceSpecificWeather : IMessage<ForceSpecificWeather>, IMessage, IEquatable<ForceSpecificWeather>, IDeepCloneable<ForceSpecificWeather>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000282")]
				private static readonly MessageParser<ForceSpecificWeather> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000283")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000284")]
				public const int WeatherFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000285")]
				private string weather_;

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				[DebuggerNonUserCode]
				public static MessageParser<ForceSpecificWeather> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60008F9")]
					[Cpp2IlInjected.Address(RVA = "0x201F780", Offset = "0x201E180", VA = "0x18201F780")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60008FA")]
					[Cpp2IlInjected.Address(RVA = "0x201F700", Offset = "0x201E100", VA = "0x18201F700")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60008FB")]
					[Cpp2IlInjected.Address(RVA = "0x201F7E0", Offset = "0x201E1E0", VA = "0x18201F7E0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				[DebuggerNonUserCode]
				public string Weather
				{
					[Cpp2IlInjected.Token(Token = "0x60008FF")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000900")]
					[Cpp2IlInjected.Address(RVA = "0x201F8A0", Offset = "0x201E2A0", VA = "0x18201F8A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60008FC")]
				[Cpp2IlInjected.Address(RVA = "0x201F610", Offset = "0x201E010", VA = "0x18201F610")]
				[DebuggerNonUserCode]
				public ForceSpecificWeather()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008FD")]
				[Cpp2IlInjected.Address(RVA = "0x201F660", Offset = "0x201E060", VA = "0x18201F660")]
				[DebuggerNonUserCode]
				public ForceSpecificWeather(ForceSpecificWeather other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60008FE")]
				[Cpp2IlInjected.Address(RVA = "0x201F100", Offset = "0x201DB00", VA = "0x18201F100", Slot = "10")]
				[DebuggerNonUserCode]
				public ForceSpecificWeather Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000901")]
				[Cpp2IlInjected.Address(RVA = "0x201F1C0", Offset = "0x201DBC0", VA = "0x18201F1C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000902")]
				[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ForceSpecificWeather other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000903")]
				[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000904")]
				[Cpp2IlInjected.Address(RVA = "0x201F4A0", Offset = "0x201DEA0", VA = "0x18201F4A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000905")]
				[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000906")]
				[Cpp2IlInjected.Address(RVA = "0x201EFD0", Offset = "0x201D9D0", VA = "0x18201EFD0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000907")]
				[Cpp2IlInjected.Address(RVA = "0x201F380", Offset = "0x201DD80", VA = "0x18201F380", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ForceSpecificWeather other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000908")]
				[Cpp2IlInjected.Address(RVA = "0x201F2F0", Offset = "0x201DCF0", VA = "0x18201F2F0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000909")]
				[Cpp2IlInjected.Address(RVA = "0x201F270", Offset = "0x201DC70", VA = "0x18201F270", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600090A")]
				[Cpp2IlInjected.Address(RVA = "0x201F3E0", Offset = "0x201DDE0", VA = "0x18201F3E0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600090B")]
				[Cpp2IlInjected.Address(RVA = "0x201F070", Offset = "0x201DA70", VA = "0x18201F070", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			public sealed class ShowAllCraftingRecipes : IMessage<ShowAllCraftingRecipes>, IMessage, IEquatable<ShowAllCraftingRecipes>, IDeepCloneable<ShowAllCraftingRecipes>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000287")]
				private static readonly MessageParser<ShowAllCraftingRecipes> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000288")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000289")]
				public const int EnabledFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				private bool enabled_;

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				[DebuggerNonUserCode]
				public static MessageParser<ShowAllCraftingRecipes> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000910")]
					[Cpp2IlInjected.Address(RVA = "0x20313F0", Offset = "0x202FDF0", VA = "0x1820313F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000911")]
					[Cpp2IlInjected.Address(RVA = "0x2031370", Offset = "0x202FD70", VA = "0x182031370")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000912")]
					[Cpp2IlInjected.Address(RVA = "0x2031450", Offset = "0x202FE50", VA = "0x182031450", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				[DebuggerNonUserCode]
				public bool Enabled
				{
					[Cpp2IlInjected.Token(Token = "0x6000916")]
					[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000917")]
					[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000913")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ShowAllCraftingRecipes()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000914")]
				[Cpp2IlInjected.Address(RVA = "0x13AA900", Offset = "0x13A9300", VA = "0x1813AA900")]
				[DebuggerNonUserCode]
				public ShowAllCraftingRecipes(ShowAllCraftingRecipes other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000915")]
				[Cpp2IlInjected.Address(RVA = "0x2030FC0", Offset = "0x202F9C0", VA = "0x182030FC0", Slot = "10")]
				[DebuggerNonUserCode]
				public ShowAllCraftingRecipes Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000918")]
				[Cpp2IlInjected.Address(RVA = "0x2031040", Offset = "0x202FA40", VA = "0x182031040", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000919")]
				[Cpp2IlInjected.Address(RVA = "0x13AA400", Offset = "0x13A8E00", VA = "0x1813AA400", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ShowAllCraftingRecipes other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600091A")]
				[Cpp2IlInjected.Address(RVA = "0x13AA570", Offset = "0x13A8F70", VA = "0x1813AA570", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600091B")]
				[Cpp2IlInjected.Address(RVA = "0x2031200", Offset = "0x202FC00", VA = "0x182031200", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600091C")]
				[Cpp2IlInjected.Address(RVA = "0x13AA790", Offset = "0x13A9190", VA = "0x1813AA790", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600091D")]
				[Cpp2IlInjected.Address(RVA = "0x13AA330", Offset = "0x13A8D30", VA = "0x1813AA330", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600091E")]
				[Cpp2IlInjected.Address(RVA = "0x13AA660", Offset = "0x13A9060", VA = "0x1813AA660", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ShowAllCraftingRecipes other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600091F")]
				[Cpp2IlInjected.Address(RVA = "0x13AA5E0", Offset = "0x13A8FE0", VA = "0x1813AA5E0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000920")]
				[Cpp2IlInjected.Address(RVA = "0x20310D0", Offset = "0x202FAD0", VA = "0x1820310D0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000921")]
				[Cpp2IlInjected.Address(RVA = "0x2031180", Offset = "0x202FB80", VA = "0x182031180", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000922")]
				[Cpp2IlInjected.Address(RVA = "0x13AA370", Offset = "0x13A8D70", VA = "0x1813AA370", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			public sealed class BattlePassTaskProgresion : IMessage<BattlePassTaskProgresion>, IMessage, IEquatable<BattlePassTaskProgresion>, IDeepCloneable<BattlePassTaskProgresion>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400028C")]
				private static readonly MessageParser<BattlePassTaskProgresion> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400028D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400028E")]
				public const int OnlineIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400028F")]
				private string onlineId_;

				[Cpp2IlInjected.Token(Token = "0x4000290")]
				public const int TaskIndexFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000291")]
				private int taskIndex_;

				[Cpp2IlInjected.Token(Token = "0x4000292")]
				public const int AmountFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000293")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				[DebuggerNonUserCode]
				public static MessageParser<BattlePassTaskProgresion> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000927")]
					[Cpp2IlInjected.Address(RVA = "0x201B850", Offset = "0x201A250", VA = "0x18201B850")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000928")]
					[Cpp2IlInjected.Address(RVA = "0x201B7D0", Offset = "0x201A1D0", VA = "0x18201B7D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000929")]
					[Cpp2IlInjected.Address(RVA = "0x201B8B0", Offset = "0x201A2B0", VA = "0x18201B8B0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				[DebuggerNonUserCode]
				public string OnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x600092D")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600092E")]
					[Cpp2IlInjected.Address(RVA = "0x201B970", Offset = "0x201A370", VA = "0x18201B970")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				[DebuggerNonUserCode]
				public int TaskIndex
				{
					[Cpp2IlInjected.Token(Token = "0x600092F")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000930")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6000931")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000932")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600092A")]
				[Cpp2IlInjected.Address(RVA = "0x201B780", Offset = "0x201A180", VA = "0x18201B780")]
				[DebuggerNonUserCode]
				public BattlePassTaskProgresion()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092B")]
				[Cpp2IlInjected.Address(RVA = "0x201B6E0", Offset = "0x201A0E0", VA = "0x18201B6E0")]
				[DebuggerNonUserCode]
				public BattlePassTaskProgresion(BattlePassTaskProgresion other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092C")]
				[Cpp2IlInjected.Address(RVA = "0x201AF60", Offset = "0x2019960", VA = "0x18201AF60", Slot = "10")]
				[DebuggerNonUserCode]
				public BattlePassTaskProgresion Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000933")]
				[Cpp2IlInjected.Address(RVA = "0x201B030", Offset = "0x2019A30", VA = "0x18201B030", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000934")]
				[Cpp2IlInjected.Address(RVA = "0x17FB860", Offset = "0x17FA260", VA = "0x1817FB860", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(BattlePassTaskProgresion other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000935")]
				[Cpp2IlInjected.Address(RVA = "0x201B1C0", Offset = "0x2019BC0", VA = "0x18201B1C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000936")]
				[Cpp2IlInjected.Address(RVA = "0x201B4B0", Offset = "0x2019EB0", VA = "0x18201B4B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000937")]
				[Cpp2IlInjected.Address(RVA = "0x201B510", Offset = "0x2019F10", VA = "0x18201B510", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000938")]
				[Cpp2IlInjected.Address(RVA = "0x201ADE0", Offset = "0x20197E0", VA = "0x18201ADE0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000939")]
				[Cpp2IlInjected.Address(RVA = "0x201B310", Offset = "0x2019D10", VA = "0x18201B310", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(BattlePassTaskProgresion other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600093A")]
				[Cpp2IlInjected.Address(RVA = "0x201B260", Offset = "0x2019C60", VA = "0x18201B260", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600093B")]
				[Cpp2IlInjected.Address(RVA = "0x201B0F0", Offset = "0x2019AF0", VA = "0x18201B0F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600093C")]
				[Cpp2IlInjected.Address(RVA = "0x201B390", Offset = "0x2019D90", VA = "0x18201B390", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600093D")]
				[Cpp2IlInjected.Address(RVA = "0x201AEE0", Offset = "0x20198E0", VA = "0x18201AEE0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000CE")]
			public sealed class ApplyConditionalActions : IMessage<ApplyConditionalActions>, IMessage, IEquatable<ApplyConditionalActions>, IDeepCloneable<ApplyConditionalActions>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000295")]
				private static readonly MessageParser<ApplyConditionalActions> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000296")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000297")]
				public const int ConditionalActionsFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000298")]
				private ConditionalActions conditionalActions_;

				[Cpp2IlInjected.Token(Token = "0x4000299")]
				public const int SkipConditionsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400029A")]
				private bool skipConditions_;

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				[DebuggerNonUserCode]
				public static MessageParser<ApplyConditionalActions> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000942")]
					[Cpp2IlInjected.Address(RVA = "0x201ACC0", Offset = "0x20196C0", VA = "0x18201ACC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000943")]
					[Cpp2IlInjected.Address(RVA = "0x201AC40", Offset = "0x2019640", VA = "0x18201AC40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000944")]
					[Cpp2IlInjected.Address(RVA = "0x201AD20", Offset = "0x2019720", VA = "0x18201AD20", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				[DebuggerNonUserCode]
				public ConditionalActions ConditionalActions
				{
					[Cpp2IlInjected.Token(Token = "0x6000948")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000949")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				[DebuggerNonUserCode]
				public bool SkipConditions
				{
					[Cpp2IlInjected.Token(Token = "0x600094A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600094B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000945")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public ApplyConditionalActions()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000946")]
				[Cpp2IlInjected.Address(RVA = "0x201ABC0", Offset = "0x20195C0", VA = "0x18201ABC0")]
				[DebuggerNonUserCode]
				public ApplyConditionalActions(ApplyConditionalActions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000947")]
				[Cpp2IlInjected.Address(RVA = "0x201A580", Offset = "0x2018F80", VA = "0x18201A580", Slot = "10")]
				[DebuggerNonUserCode]
				public ApplyConditionalActions Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600094C")]
				[Cpp2IlInjected.Address(RVA = "0x201A630", Offset = "0x2019030", VA = "0x18201A630", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600094D")]
				[Cpp2IlInjected.Address(RVA = "0x1807960", Offset = "0x1806360", VA = "0x181807960", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ApplyConditionalActions other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600094E")]
				[Cpp2IlInjected.Address(RVA = "0x1807AA0", Offset = "0x18064A0", VA = "0x181807AA0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600094F")]
				[Cpp2IlInjected.Address(RVA = "0x201AA50", Offset = "0x2019450", VA = "0x18201AA50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000950")]
				[Cpp2IlInjected.Address(RVA = "0x1807E30", Offset = "0x1806830", VA = "0x181807E30", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000951")]
				[Cpp2IlInjected.Address(RVA = "0x201A4E0", Offset = "0x2018EE0", VA = "0x18201A4E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000952")]
				[Cpp2IlInjected.Address(RVA = "0x201A8A0", Offset = "0x20192A0", VA = "0x18201A8A0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ApplyConditionalActions other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000953")]
				[Cpp2IlInjected.Address(RVA = "0x201A7B0", Offset = "0x20191B0", VA = "0x18201A7B0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000954")]
				[Cpp2IlInjected.Address(RVA = "0x201A6E0", Offset = "0x20190E0", VA = "0x18201A6E0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000955")]
				[Cpp2IlInjected.Address(RVA = "0x201A980", Offset = "0x2019380", VA = "0x18201A980", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000956")]
				[Cpp2IlInjected.Address(RVA = "0x18077D0", Offset = "0x18061D0", VA = "0x1818077D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D0")]
			public sealed class EndFtueEvents : IMessage<EndFtueEvents>, IMessage, IEquatable<EndFtueEvents>, IDeepCloneable<EndFtueEvents>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x400029C")]
				private static readonly MessageParser<EndFtueEvents> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400029D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400029E")]
				public const int FtueEventIDsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x400029F")]
				private static readonly FieldCodec<int> _repeated_ftueEventIDs_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002A0")]
				private readonly RepeatedField<int> ftueEventIDs_;

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				[DebuggerNonUserCode]
				public static MessageParser<EndFtueEvents> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600095B")]
					[Cpp2IlInjected.Address(RVA = "0x201D060", Offset = "0x201BA60", VA = "0x18201D060")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600095C")]
					[Cpp2IlInjected.Address(RVA = "0x201CFE0", Offset = "0x201B9E0", VA = "0x18201CFE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600095D")]
					[Cpp2IlInjected.Address(RVA = "0x201D0C0", Offset = "0x201BAC0", VA = "0x18201D0C0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				[DebuggerNonUserCode]
				public RepeatedField<int> FtueEventIDs
				{
					[Cpp2IlInjected.Token(Token = "0x6000961")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600095E")]
				[Cpp2IlInjected.Address(RVA = "0x201CF60", Offset = "0x201B960", VA = "0x18201CF60")]
				[DebuggerNonUserCode]
				public EndFtueEvents()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600095F")]
				[Cpp2IlInjected.Address(RVA = "0x201CED0", Offset = "0x201B8D0", VA = "0x18201CED0")]
				[DebuggerNonUserCode]
				public EndFtueEvents(EndFtueEvents other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000960")]
				[Cpp2IlInjected.Address(RVA = "0x201C7F0", Offset = "0x201B1F0", VA = "0x18201C7F0", Slot = "10")]
				[DebuggerNonUserCode]
				public EndFtueEvents Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000962")]
				[Cpp2IlInjected.Address(RVA = "0x201C940", Offset = "0x201B340", VA = "0x18201C940", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000963")]
				[Cpp2IlInjected.Address(RVA = "0x201C8B0", Offset = "0x201B2B0", VA = "0x18201C8B0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(EndFtueEvents other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000964")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000965")]
				[Cpp2IlInjected.Address(RVA = "0x201CC70", Offset = "0x201B670", VA = "0x18201CC70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000966")]
				[Cpp2IlInjected.Address(RVA = "0x201CCD0", Offset = "0x201B6D0", VA = "0x18201CCD0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000967")]
				[Cpp2IlInjected.Address(RVA = "0x201C6E0", Offset = "0x201B0E0", VA = "0x18201C6E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000968")]
				[Cpp2IlInjected.Address(RVA = "0x201CAA0", Offset = "0x201B4A0", VA = "0x18201CAA0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(EndFtueEvents other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000969")]
				[Cpp2IlInjected.Address(RVA = "0x201CB20", Offset = "0x201B520", VA = "0x18201CB20", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600096A")]
				[Cpp2IlInjected.Address(RVA = "0x201CA20", Offset = "0x201B420", VA = "0x18201CA20", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600096B")]
				[Cpp2IlInjected.Address(RVA = "0x201CC10", Offset = "0x201B610", VA = "0x18201CC10", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600096C")]
				[Cpp2IlInjected.Address(RVA = "0x201C790", Offset = "0x201B190", VA = "0x18201C790", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D2")]
			public sealed class DropItemsOnFloor : IMessage<DropItemsOnFloor>, IMessage, IEquatable<DropItemsOnFloor>, IDeepCloneable<DropItemsOnFloor>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40002A2")]
				private static readonly MessageParser<DropItemsOnFloor> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002A3")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40002A4")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002A5")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x40002A6")]
				public const int RadiusFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40002A7")]
				private int radius_;

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				[DebuggerNonUserCode]
				public static MessageParser<DropItemsOnFloor> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000971")]
					[Cpp2IlInjected.Address(RVA = "0x201C5C0", Offset = "0x201AFC0", VA = "0x18201C5C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000972")]
					[Cpp2IlInjected.Address(RVA = "0x201C540", Offset = "0x201AF40", VA = "0x18201C540")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000973")]
					[Cpp2IlInjected.Address(RVA = "0x201C620", Offset = "0x201B020", VA = "0x18201C620", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6000977")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000978")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				[DebuggerNonUserCode]
				public int Radius
				{
					[Cpp2IlInjected.Token(Token = "0x6000979")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600097A")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000974")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public DropItemsOnFloor()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000975")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public DropItemsOnFloor(DropItemsOnFloor other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000976")]
				[Cpp2IlInjected.Address(RVA = "0x201C130", Offset = "0x201AB30", VA = "0x18201C130", Slot = "10")]
				[DebuggerNonUserCode]
				public DropItemsOnFloor Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600097B")]
				[Cpp2IlInjected.Address(RVA = "0x201C1C0", Offset = "0x201ABC0", VA = "0x18201C1C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600097C")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(DropItemsOnFloor other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600097D")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600097E")]
				[Cpp2IlInjected.Address(RVA = "0x201C3D0", Offset = "0x201ADD0", VA = "0x18201C3D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600097F")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000980")]
				[Cpp2IlInjected.Address(RVA = "0x201C060", Offset = "0x201AA60", VA = "0x18201C060", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000981")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(DropItemsOnFloor other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000982")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000983")]
				[Cpp2IlInjected.Address(RVA = "0x201C250", Offset = "0x201AC50", VA = "0x18201C250", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000984")]
				[Cpp2IlInjected.Address(RVA = "0x201C310", Offset = "0x201AD10", VA = "0x18201C310", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000985")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D4")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x20000D5")]
				public enum CheatTypeOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x40002C4")]
					None,
					[Cpp2IlInjected.Token(Token = "0x40002C5")]
					BuildHouse,
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					ForceSpecificFish,
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					ForceSpecificMining,
					[Cpp2IlInjected.Token(Token = "0x40002C8")]
					GenerateAllMissions,
					[Cpp2IlInjected.Token(Token = "0x40002C9")]
					RemoveNightThorns,
					[Cpp2IlInjected.Token(Token = "0x40002CA")]
					RemoveBlockers,
					[Cpp2IlInjected.Token(Token = "0x40002CB")]
					UnlockAllTools,
					[Cpp2IlInjected.Token(Token = "0x40002CC")]
					UnlockAllRecipies,
					[Cpp2IlInjected.Token(Token = "0x40002CD")]
					ToggleForceWeedTreasure,
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					ToggleForceWeedMinigame,
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					ToggleForceCriticalSuccess,
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					ForceSpecificStoreFilter,
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					GiveBuilding,
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					CommandLine,
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					UnlockMemoryShard,
					[Cpp2IlInjected.Token(Token = "0x40002D4")]
					ForceSpecificWeather,
					[Cpp2IlInjected.Token(Token = "0x40002D5")]
					ShowAllCraftingRecipes,
					[Cpp2IlInjected.Token(Token = "0x40002D6")]
					GiveFullMana,
					[Cpp2IlInjected.Token(Token = "0x40002D7")]
					BattlePassTaskProgresion,
					[Cpp2IlInjected.Token(Token = "0x40002D8")]
					ApplyConditionalActions,
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					EndFtueEvents,
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					DropItemsOnFloor
				}

				[Cpp2IlInjected.Token(Token = "0x40002A9")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002AA")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40002AB")]
				public const int BuildHouseFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40002AC")]
				public const int ForceSpecificFishFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x40002AD")]
				public const int ForceSpecificMiningFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x40002AE")]
				public const int GenerateAllMissionsFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x40002AF")]
				public const int RemoveNightThornsFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x40002B0")]
				public const int RemoveBlockersFieldNumber = 6;

				[Cpp2IlInjected.Token(Token = "0x40002B1")]
				public const int UnlockAllToolsFieldNumber = 7;

				[Cpp2IlInjected.Token(Token = "0x40002B2")]
				public const int UnlockAllRecipiesFieldNumber = 8;

				[Cpp2IlInjected.Token(Token = "0x40002B3")]
				public const int ToggleForceWeedTreasureFieldNumber = 9;

				[Cpp2IlInjected.Token(Token = "0x40002B4")]
				public const int ToggleForceWeedMinigameFieldNumber = 10;

				[Cpp2IlInjected.Token(Token = "0x40002B5")]
				public const int ToggleForceCriticalSuccessFieldNumber = 11;

				[Cpp2IlInjected.Token(Token = "0x40002B6")]
				public const int ForceSpecificStoreFilterFieldNumber = 12;

				[Cpp2IlInjected.Token(Token = "0x40002B7")]
				public const int GiveBuildingFieldNumber = 13;

				[Cpp2IlInjected.Token(Token = "0x40002B8")]
				public const int CommandLineFieldNumber = 14;

				[Cpp2IlInjected.Token(Token = "0x40002B9")]
				public const int UnlockMemoryShardFieldNumber = 15;

				[Cpp2IlInjected.Token(Token = "0x40002BA")]
				public const int ForceSpecificWeatherFieldNumber = 16;

				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				public const int ShowAllCraftingRecipesFieldNumber = 17;

				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				public const int GiveFullManaFieldNumber = 18;

				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				public const int BattlePassTaskProgresionFieldNumber = 19;

				[Cpp2IlInjected.Token(Token = "0x40002BE")]
				public const int ApplyConditionalActionsFieldNumber = 20;

				[Cpp2IlInjected.Token(Token = "0x40002BF")]
				public const int EndFtueEventsFieldNumber = 21;

				[Cpp2IlInjected.Token(Token = "0x40002C0")]
				public const int DropItemsOnFloorFieldNumber = 22;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002C1")]
				private object cheatType_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002C2")]
				private CheatTypeOneofCase cheatTypeCase_;

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600098A")]
					[Cpp2IlInjected.Address(RVA = "0x20284D0", Offset = "0x2026ED0", VA = "0x1820284D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600098B")]
					[Cpp2IlInjected.Address(RVA = "0x2027F30", Offset = "0x2026930", VA = "0x182027F30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600098C")]
					[Cpp2IlInjected.Address(RVA = "0x2028C50", Offset = "0x2027650", VA = "0x182028C50", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				[DebuggerNonUserCode]
				public BuildHouse BuildHouse
				{
					[Cpp2IlInjected.Token(Token = "0x6000990")]
					[Cpp2IlInjected.Address(RVA = "0x2027D60", Offset = "0x2026760", VA = "0x182027D60")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000991")]
					[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				[DebuggerNonUserCode]
				public ForceSpecificFish ForceSpecificFish
				{
					[Cpp2IlInjected.Token(Token = "0x6000992")]
					[Cpp2IlInjected.Address(RVA = "0x2028170", Offset = "0x2026B70", VA = "0x182028170")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000993")]
					[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				[DebuggerNonUserCode]
				public ForceSpecificMining ForceSpecificMining
				{
					[Cpp2IlInjected.Token(Token = "0x6000994")]
					[Cpp2IlInjected.Address(RVA = "0x20281D0", Offset = "0x2026BD0", VA = "0x1820281D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000995")]
					[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				[DebuggerNonUserCode]
				public GenerateAllMissions GenerateAllMissions
				{
					[Cpp2IlInjected.Token(Token = "0x6000996")]
					[Cpp2IlInjected.Address(RVA = "0x20282F0", Offset = "0x2026CF0", VA = "0x1820282F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000997")]
					[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				[DebuggerNonUserCode]
				public RemoveNightThorns RemoveNightThorns
				{
					[Cpp2IlInjected.Token(Token = "0x6000998")]
					[Cpp2IlInjected.Address(RVA = "0x2028650", Offset = "0x2027050", VA = "0x182028650")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000999")]
					[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				[DebuggerNonUserCode]
				public RemoveBlockers RemoveBlockers
				{
					[Cpp2IlInjected.Token(Token = "0x600099A")]
					[Cpp2IlInjected.Address(RVA = "0x20285F0", Offset = "0x2026FF0", VA = "0x1820285F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600099B")]
					[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				[DebuggerNonUserCode]
				public UnlockAllTools UnlockAllTools
				{
					[Cpp2IlInjected.Token(Token = "0x600099C")]
					[Cpp2IlInjected.Address(RVA = "0x2028890", Offset = "0x2027290", VA = "0x182028890")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600099D")]
					[Cpp2IlInjected.Address(RVA = "0x5C5E10", Offset = "0x5C4810", VA = "0x1805C5E10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				[DebuggerNonUserCode]
				public UnlockAllRecipies UnlockAllRecipies
				{
					[Cpp2IlInjected.Token(Token = "0x600099E")]
					[Cpp2IlInjected.Address(RVA = "0x2028830", Offset = "0x2027230", VA = "0x182028830")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600099F")]
					[Cpp2IlInjected.Address(RVA = "0x5C5E50", Offset = "0x5C4850", VA = "0x1805C5E50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				[DebuggerNonUserCode]
				public Empty ToggleForceWeedTreasure
				{
					[Cpp2IlInjected.Token(Token = "0x60009A0")]
					[Cpp2IlInjected.Address(RVA = "0x20287D0", Offset = "0x20271D0", VA = "0x1820287D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009A1")]
					[Cpp2IlInjected.Address(RVA = "0x1D17080", Offset = "0x1D15A80", VA = "0x181D17080")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				[DebuggerNonUserCode]
				public Empty ToggleForceWeedMinigame
				{
					[Cpp2IlInjected.Token(Token = "0x60009A2")]
					[Cpp2IlInjected.Address(RVA = "0x2028770", Offset = "0x2027170", VA = "0x182028770")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009A3")]
					[Cpp2IlInjected.Address(RVA = "0x1D16FC0", Offset = "0x1D159C0", VA = "0x181D16FC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				[DebuggerNonUserCode]
				public Empty ToggleForceCriticalSuccess
				{
					[Cpp2IlInjected.Token(Token = "0x60009A4")]
					[Cpp2IlInjected.Address(RVA = "0x2028710", Offset = "0x2027110", VA = "0x182028710")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009A5")]
					[Cpp2IlInjected.Address(RVA = "0x1D174F0", Offset = "0x1D15EF0", VA = "0x181D174F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				[DebuggerNonUserCode]
				public ForceSpecificStoreFilter ForceSpecificStoreFilter
				{
					[Cpp2IlInjected.Token(Token = "0x60009A6")]
					[Cpp2IlInjected.Address(RVA = "0x2028230", Offset = "0x2026C30", VA = "0x182028230")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009A7")]
					[Cpp2IlInjected.Address(RVA = "0x1D16F80", Offset = "0x1D15980", VA = "0x181D16F80")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				[DebuggerNonUserCode]
				public GiveBuilding GiveBuilding
				{
					[Cpp2IlInjected.Token(Token = "0x60009A8")]
					[Cpp2IlInjected.Address(RVA = "0x2028350", Offset = "0x2026D50", VA = "0x182028350")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009A9")]
					[Cpp2IlInjected.Address(RVA = "0x1D17040", Offset = "0x1D15A40", VA = "0x181D17040")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				[DebuggerNonUserCode]
				public string CommandLine
				{
					[Cpp2IlInjected.Token(Token = "0x60009AA")]
					[Cpp2IlInjected.Address(RVA = "0x2027DC0", Offset = "0x20267C0", VA = "0x182027DC0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009AB")]
					[Cpp2IlInjected.Address(RVA = "0x2028D90", Offset = "0x2027790", VA = "0x182028D90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				[DebuggerNonUserCode]
				public UnlockMemoryShard UnlockMemoryShard
				{
					[Cpp2IlInjected.Token(Token = "0x60009AC")]
					[Cpp2IlInjected.Address(RVA = "0x20288F0", Offset = "0x20272F0", VA = "0x1820288F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009AD")]
					[Cpp2IlInjected.Address(RVA = "0x1D17000", Offset = "0x1D15A00", VA = "0x181D17000")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				[DebuggerNonUserCode]
				public ForceSpecificWeather ForceSpecificWeather
				{
					[Cpp2IlInjected.Token(Token = "0x60009AE")]
					[Cpp2IlInjected.Address(RVA = "0x2028290", Offset = "0x2026C90", VA = "0x182028290")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009AF")]
					[Cpp2IlInjected.Address(RVA = "0x2028E80", Offset = "0x2027880", VA = "0x182028E80")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				[DebuggerNonUserCode]
				public ShowAllCraftingRecipes ShowAllCraftingRecipes
				{
					[Cpp2IlInjected.Token(Token = "0x60009B0")]
					[Cpp2IlInjected.Address(RVA = "0x20286B0", Offset = "0x20270B0", VA = "0x1820286B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009B1")]
					[Cpp2IlInjected.Address(RVA = "0x2028F00", Offset = "0x2027900", VA = "0x182028F00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				[DebuggerNonUserCode]
				public Empty GiveFullMana
				{
					[Cpp2IlInjected.Token(Token = "0x60009B2")]
					[Cpp2IlInjected.Address(RVA = "0x20283B0", Offset = "0x2026DB0", VA = "0x1820283B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009B3")]
					[Cpp2IlInjected.Address(RVA = "0x2028EC0", Offset = "0x20278C0", VA = "0x182028EC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				[DebuggerNonUserCode]
				public BattlePassTaskProgresion BattlePassTaskProgresion
				{
					[Cpp2IlInjected.Token(Token = "0x60009B4")]
					[Cpp2IlInjected.Address(RVA = "0x2027D00", Offset = "0x2026700", VA = "0x182027D00")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009B5")]
					[Cpp2IlInjected.Address(RVA = "0x2028D50", Offset = "0x2027750", VA = "0x182028D50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				[DebuggerNonUserCode]
				public ApplyConditionalActions ApplyConditionalActions
				{
					[Cpp2IlInjected.Token(Token = "0x60009B6")]
					[Cpp2IlInjected.Address(RVA = "0x2027CA0", Offset = "0x20266A0", VA = "0x182027CA0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009B7")]
					[Cpp2IlInjected.Address(RVA = "0x2028D10", Offset = "0x2027710", VA = "0x182028D10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				[DebuggerNonUserCode]
				public EndFtueEvents EndFtueEvents
				{
					[Cpp2IlInjected.Token(Token = "0x60009B8")]
					[Cpp2IlInjected.Address(RVA = "0x2028110", Offset = "0x2026B10", VA = "0x182028110")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009B9")]
					[Cpp2IlInjected.Address(RVA = "0x2028E40", Offset = "0x2027840", VA = "0x182028E40")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				[DebuggerNonUserCode]
				public DropItemsOnFloor DropItemsOnFloor
				{
					[Cpp2IlInjected.Token(Token = "0x60009BA")]
					[Cpp2IlInjected.Address(RVA = "0x20280B0", Offset = "0x2026AB0", VA = "0x1820280B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009BB")]
					[Cpp2IlInjected.Address(RVA = "0x2028E00", Offset = "0x2027800", VA = "0x182028E00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				[DebuggerNonUserCode]
				public CheatTypeOneofCase CheatTypeCase
				{
					[Cpp2IlInjected.Token(Token = "0x60009BC")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(CheatTypeOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600098D")]
				[Cpp2IlInjected.Address(RVA = "0x2027C60", Offset = "0x2026660", VA = "0x182027C60")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600098E")]
				[Cpp2IlInjected.Address(RVA = "0x2026F70", Offset = "0x2025970", VA = "0x182026F70")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600098F")]
				[Cpp2IlInjected.Address(RVA = "0x2021E80", Offset = "0x2020880", VA = "0x182021E80", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60009BD")]
				[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
				[DebuggerNonUserCode]
				public void ClearCheatType()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009BE")]
				[Cpp2IlInjected.Address(RVA = "0x2022490", Offset = "0x2020E90", VA = "0x182022490", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60009BF")]
				[Cpp2IlInjected.Address(RVA = "0x2021FE0", Offset = "0x20209E0", VA = "0x182021FE0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60009C0")]
				[Cpp2IlInjected.Address(RVA = "0x2022AE0", Offset = "0x20214E0", VA = "0x182022AE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60009C1")]
				[Cpp2IlInjected.Address(RVA = "0x2025D40", Offset = "0x2024740", VA = "0x182025D40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60009C2")]
				[Cpp2IlInjected.Address(RVA = "0x2025FA0", Offset = "0x20249A0", VA = "0x182025FA0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009C3")]
				[Cpp2IlInjected.Address(RVA = "0x2021090", Offset = "0x201FA90", VA = "0x182021090", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60009C4")]
				[Cpp2IlInjected.Address(RVA = "0x20248E0", Offset = "0x20232E0", VA = "0x1820248E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009C5")]
				[Cpp2IlInjected.Address(RVA = "0x2023590", Offset = "0x2021F90", VA = "0x182023590", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009C6")]
				[Cpp2IlInjected.Address(RVA = "0x2022770", Offset = "0x2021170", VA = "0x182022770", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60009C7")]
				[Cpp2IlInjected.Address(RVA = "0x2025460", Offset = "0x2023E60", VA = "0x182025460", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009C8")]
				[Cpp2IlInjected.Address(RVA = "0x2021C10", Offset = "0x2020610", VA = "0x182021C10", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009C9")]
				[Cpp2IlInjected.Address(RVA = "0x20234E0", Offset = "0x2021EE0", VA = "0x1820234E0", Slot = "16")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60009CA")]
				[Cpp2IlInjected.Address(RVA = "0x2021CF0", Offset = "0x20206F0", VA = "0x182021CF0", Slot = "17")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009CB")]
				[Cpp2IlInjected.Address(RVA = "0x2025EC0", Offset = "0x20248C0", VA = "0x182025EC0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000D7")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40002DC")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E1")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60009D0")]
					[Cpp2IlInjected.Address(RVA = "0x2030AE0", Offset = "0x202F4E0", VA = "0x182030AE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60009D1")]
					[Cpp2IlInjected.Address(RVA = "0x20307A0", Offset = "0x202F1A0", VA = "0x1820307A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60009D2")]
					[Cpp2IlInjected.Address(RVA = "0x2030E40", Offset = "0x202F840", VA = "0x182030E40", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60009D6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60009D7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60009D8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60009D9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60009E5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60009E6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60009D3")]
				[Cpp2IlInjected.Address(RVA = "0x2030640", Offset = "0x202F040", VA = "0x182030640")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009D4")]
				[Cpp2IlInjected.Address(RVA = "0x20306C0", Offset = "0x202F0C0", VA = "0x1820306C0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009D5")]
				[Cpp2IlInjected.Address(RVA = "0x202C340", Offset = "0x202AD40", VA = "0x18202C340", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60009DA")]
				[Cpp2IlInjected.Address(RVA = "0x202C940", Offset = "0x202B340", VA = "0x18202C940", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60009DB")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60009DC")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60009DD")]
				[Cpp2IlInjected.Address(RVA = "0x202EE60", Offset = "0x202D860", VA = "0x18202EE60", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60009DE")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009DF")]
				[Cpp2IlInjected.Address(RVA = "0x202BE10", Offset = "0x202A810", VA = "0x18202BE10", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60009E0")]
				[Cpp2IlInjected.Address(RVA = "0x202DFE0", Offset = "0x202C9E0", VA = "0x18202DFE0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009E1")]
				[Cpp2IlInjected.Address(RVA = "0x202DEF0", Offset = "0x202C8F0", VA = "0x18202DEF0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009E2")]
				[Cpp2IlInjected.Address(RVA = "0x202D4C0", Offset = "0x202BEC0", VA = "0x18202D4C0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60009E3")]
				[Cpp2IlInjected.Address(RVA = "0x202EBF0", Offset = "0x202D5F0", VA = "0x18202EBF0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009E4")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60009E7")]
				[Cpp2IlInjected.Address(RVA = "0x2029670", Offset = "0x2028070", VA = "0x182029670", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60009E8")]
				[Cpp2IlInjected.Address(RVA = "0x202B990", Offset = "0x202A390", VA = "0x18202B990")]
				private Result BuildHouse(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009E9")]
				[Cpp2IlInjected.Address(RVA = "0x202CB50", Offset = "0x202B550", VA = "0x18202CB50")]
				private Result ForceSpecificFish(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009EA")]
				[Cpp2IlInjected.Address(RVA = "0x202CDE0", Offset = "0x202B7E0", VA = "0x18202CDE0")]
				private Result ForceSpecificMining(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009EB")]
				[Cpp2IlInjected.Address(RVA = "0x2029630", Offset = "0x2028030", VA = "0x182029630")]
				private Result ApplyGenerateAllMissions(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009EC")]
				[Cpp2IlInjected.Address(RVA = "0x202E610", Offset = "0x202D010", VA = "0x18202E610")]
				private Result RemoveNightThorns(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009ED")]
				[Cpp2IlInjected.Address(RVA = "0x202E0E0", Offset = "0x202CAE0", VA = "0x18202E0E0")]
				private Result RemoveBlockers(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009EE")]
				[Cpp2IlInjected.Address(RVA = "0x202F570", Offset = "0x202DF70", VA = "0x18202F570")]
				private Result UnlockAllTools(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009EF")]
				[Cpp2IlInjected.Address(RVA = "0x202F290", Offset = "0x202DC90", VA = "0x18202F290")]
				private Result UnlockAllRecipies(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009F0")]
				[Cpp2IlInjected.Address(RVA = "0x202CFB0", Offset = "0x202B9B0", VA = "0x18202CFB0")]
				private Result ForceSpecificStoreFilter(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009F1")]
				[Cpp2IlInjected.Address(RVA = "0x202F790", Offset = "0x202E190", VA = "0x18202F790")]
				private Result UnlockMemoryShard(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009F2")]
				[Cpp2IlInjected.Address(RVA = "0x202D230", Offset = "0x202BC30", VA = "0x18202D230")]
				private Result ForceSpecificWeather(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009F3")]
				[Cpp2IlInjected.Address(RVA = "0x202B5B0", Offset = "0x2029FB0", VA = "0x18202B5B0")]
				private Result BattlePassTaskProgresion(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009F4")]
				[Cpp2IlInjected.Address(RVA = "0x2028F40", Offset = "0x2027940", VA = "0x182028F40")]
				private Result ApplyConditionalActions(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009F5")]
				[Cpp2IlInjected.Address(RVA = "0x2029420", Offset = "0x2027E20", VA = "0x182029420")]
				private Result ApplyEndFtueEvents(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x60009F6")]
				[Cpp2IlInjected.Address(RVA = "0x2029110", Offset = "0x2027B10", VA = "0x182029110")]
				private Result ApplyDropItemsOnFloor(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private static readonly MessageParser<DebugGenericCheat> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugGenericCheat> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x18CBD60", Offset = "0x18CA760", VA = "0x1818CBD60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x18CBC90", Offset = "0x18CA690", VA = "0x1818CBC90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x18CBDC0", Offset = "0x18CA7C0", VA = "0x1818CBDC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugGenericCheat()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugGenericCheat(DebugGenericCheat other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x18CB9B0", Offset = "0x18CA3B0", VA = "0x1818CB9B0", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugGenericCheat Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugGenericCheat debugGenericCheat = default(DebugGenericCheat);
			debugGenericCheat.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugGenericCheat._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugGenericCheat;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x18CBA30", Offset = "0x18CA430", VA = "0x1818CBA30", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugGenericCheat other)
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

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x18CBB20", Offset = "0x18CA520", VA = "0x1818CBB20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugGenericCheat other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
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

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x18CBAB0", Offset = "0x18CA4B0", VA = "0x1818CBAB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x18CBB80", Offset = "0x18CA580", VA = "0x1818CBB80")]
		static DebugGenericCheat()
		{
			Func<DebugGenericCheat> func = default(Func<DebugGenericCheat>);
			_parser = (MessageParser<DebugGenericCheat>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
