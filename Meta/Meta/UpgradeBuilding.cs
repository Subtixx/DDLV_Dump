using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20004B3")]
	public sealed class UpgradeBuilding : IMessage<UpgradeBuilding>, IMessage, IEquatable<UpgradeBuilding>, IDeepCloneable<UpgradeBuilding>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20004B4")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004B5")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000E9F")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000EA0")]
				[OriginalName("InvalidGrid")]
				InvalidGrid,
				[Cpp2IlInjected.Token(Token = "0x4000EA1")]
				[OriginalName("InvalidGridObjectID")]
				InvalidGridObjectId,
				[Cpp2IlInjected.Token(Token = "0x4000EA2")]
				[OriginalName("InvalidNextLevel")]
				InvalidNextLevel,
				[Cpp2IlInjected.Token(Token = "0x4000EA3")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency,
				[Cpp2IlInjected.Token(Token = "0x4000EA4")]
				[OriginalName("NotEnoughPlayerLevel")]
				NotEnoughPlayerLevel
			}

			[Cpp2IlInjected.Token(Token = "0x20004B6")]
			public enum BuildingType
			{
				[Cpp2IlInjected.Token(Token = "0x4000EA6")]
				[OriginalName("Normal")]
				Normal,
				[Cpp2IlInjected.Token(Token = "0x4000EA7")]
				[OriginalName("Castle")]
				Castle,
				[Cpp2IlInjected.Token(Token = "0x4000EA8")]
				[OriginalName("WishingWell")]
				WishingWell,
				[Cpp2IlInjected.Token(Token = "0x4000EA9")]
				[OriginalName("KitchenStall")]
				KitchenStall
			}

			[Cpp2IlInjected.Token(Token = "0x20004B7")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000EAA")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000EAB")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000EAC")]
				public const int GridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000EAD")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x4000EAE")]
				public const int GridObjectIDFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000EAF")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x4000EB0")]
				public const int CheatForcedFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000EB1")]
				private bool cheatForced_;

				[Cpp2IlInjected.Token(Token = "0x4000EB2")]
				public const int BuildingTypeFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000EB3")]
				private BuildingType buildingType_;

				[Cpp2IlInjected.Token(Token = "0x17000867")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002DC3")]
					[Cpp2IlInjected.Address(RVA = "0xACB630", Offset = "0xACA030", VA = "0x180ACB630")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000868")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002DC4")]
					[Cpp2IlInjected.Address(RVA = "0xACB5B0", Offset = "0xAC9FB0", VA = "0x180ACB5B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000869")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002DC5")]
					[Cpp2IlInjected.Address(RVA = "0xACB810", Offset = "0xACA210", VA = "0x180ACB810", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700086A")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6002DC9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6002DCA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700086B")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6002DCB")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6002DCC")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700086C")]
				[DebuggerNonUserCode]
				public bool CheatForced
				{
					[Cpp2IlInjected.Token(Token = "0x6002DCD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002DCE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700086D")]
				[DebuggerNonUserCode]
				public BuildingType BuildingType
				{
					[Cpp2IlInjected.Token(Token = "0x6002DCF")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(BuildingType);
					}
					[Cpp2IlInjected.Token(Token = "0x6002DD0")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002DC6")]
				[Cpp2IlInjected.Address(RVA = "0xACB140", Offset = "0xAC9B40", VA = "0x180ACB140")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DC7")]
				[Cpp2IlInjected.Address(RVA = "0xACB310", Offset = "0xAC9D10", VA = "0x180ACB310")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DC8")]
				[Cpp2IlInjected.Address(RVA = "0xAC8D60", Offset = "0xAC7760", VA = "0x180AC8D60", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002DD1")]
				[Cpp2IlInjected.Address(RVA = "0xAC9150", Offset = "0xAC7B50", VA = "0x180AC9150", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DD2")]
				[Cpp2IlInjected.Address(RVA = "0xAC9070", Offset = "0xAC7A70", VA = "0x180AC9070", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DD3")]
				[Cpp2IlInjected.Address(RVA = "0xAC9450", Offset = "0xAC7E50", VA = "0x180AC9450", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DD4")]
				[Cpp2IlInjected.Address(RVA = "0xAC9C40", Offset = "0xAC8640", VA = "0x180AC9C40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002DD5")]
				[Cpp2IlInjected.Address(RVA = "0xACAAC0", Offset = "0xAC94C0", VA = "0x180ACAAC0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DD6")]
				[Cpp2IlInjected.Address(RVA = "0xAC8950", Offset = "0xAC7350", VA = "0x180AC8950", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DD7")]
				[Cpp2IlInjected.Address(RVA = "0xAC9510", Offset = "0xAC7F10", VA = "0x180AC9510", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DD8")]
				[Cpp2IlInjected.Address(RVA = "0xAC9700", Offset = "0xAC8100", VA = "0x180AC9700", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DD9")]
				[Cpp2IlInjected.Address(RVA = "0xAC9270", Offset = "0xAC7C70", VA = "0x180AC9270", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002DDA")]
				[Cpp2IlInjected.Address(RVA = "0xAC9940", Offset = "0xAC8340", VA = "0x180AC9940", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DDB")]
				[Cpp2IlInjected.Address(RVA = "0xAC8AC0", Offset = "0xAC74C0", VA = "0x180AC8AC0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DDC")]
				[Cpp2IlInjected.Address(RVA = "0xACA560", Offset = "0xAC8F60", VA = "0x180ACA560", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20004B9")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000EB5")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000EB6")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000EB7")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000EB8")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000EB9")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000EBA")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700086E")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002DE1")]
					[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE120", VA = "0x180ACF720")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700086F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002DE2")]
					[Cpp2IlInjected.Address(RVA = "0xACF4E0", Offset = "0xACDEE0", VA = "0x180ACF4E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000870")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002DE3")]
					[Cpp2IlInjected.Address(RVA = "0xACF900", Offset = "0xACE300", VA = "0x180ACF900", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000871")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002DE7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002DE8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000872")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002DE9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002DEA")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000873")]
				public bool DebugSkipValidation
				{
					[Cpp2IlInjected.Token(Token = "0x6002DF6")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
					[CompilerGenerated]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6002DF7")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000874")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002DF8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002DF9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002DE4")]
				[Cpp2IlInjected.Address(RVA = "0xACF320", Offset = "0xACDD20", VA = "0x180ACF320")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DE5")]
				[Cpp2IlInjected.Address(RVA = "0xACF3A0", Offset = "0xACDDA0", VA = "0x180ACF3A0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DE6")]
				[Cpp2IlInjected.Address(RVA = "0xACCA90", Offset = "0xACB490", VA = "0x180ACCA90", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002DEB")]
				[Cpp2IlInjected.Address(RVA = "0xACCBF0", Offset = "0xACB5F0", VA = "0x180ACCBF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DEC")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DED")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DEE")]
				[Cpp2IlInjected.Address(RVA = "0xACDA90", Offset = "0xACC490", VA = "0x180ACDA90", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002DEF")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DF0")]
				[Cpp2IlInjected.Address(RVA = "0xACC660", Offset = "0xACB060", VA = "0x180ACC660", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DF1")]
				[Cpp2IlInjected.Address(RVA = "0xACD5E0", Offset = "0xACBFE0", VA = "0x180ACD5E0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DF2")]
				[Cpp2IlInjected.Address(RVA = "0xACD4F0", Offset = "0xACBEF0", VA = "0x180ACD4F0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DF3")]
				[Cpp2IlInjected.Address(RVA = "0xACD1B0", Offset = "0xACBBB0", VA = "0x180ACD1B0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002DF4")]
				[Cpp2IlInjected.Address(RVA = "0xACD870", Offset = "0xACC270", VA = "0x180ACD870", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DF5")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002DFA")]
				[Cpp2IlInjected.Address(RVA = "0xACC570", Offset = "0xACAF70", VA = "0x180ACC570", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DFB")]
				[Cpp2IlInjected.Address(RVA = "0xACE9F0", Offset = "0xACD3F0", VA = "0x180ACE9F0")]
				private Result UpgradeSpecialBuilding(in Player player, in World world, ITransactionContext context)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DFC")]
				[Cpp2IlInjected.Address(RVA = "0xACDE70", Offset = "0xACC870", VA = "0x180ACDE70")]
				private Result UpgradeBuilding(in Player player, in World world, ITransactionContext context)
				{
					return default(Result);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DFD")]
				[Cpp2IlInjected.Address(RVA = "0xACCF80", Offset = "0xACB980", VA = "0x180ACCF80")]
				public static bool ExpandShopSlots(in Player player, in World world, ITransactionContext context, Item stallItem, StallData stallData, string shopName)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DFE")]
				[Cpp2IlInjected.Address(RVA = "0xACCDE0", Offset = "0xACB7E0", VA = "0x180ACCDE0")]
				public static bool ExpandGardenSlots(GardenData gardenData, int numberOfSlots)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002DFF")]
				[Cpp2IlInjected.Address(RVA = "0xACCEB0", Offset = "0xACB8B0", VA = "0x180ACCEB0")]
				private static bool ExpandGardenStallSlots(GardenStallData gardenData, int numberOfSlots)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002E00")]
				[Cpp2IlInjected.Address(RVA = "0xACDBB0", Offset = "0xACC5B0", VA = "0x180ACDBB0")]
				private static void UpdateLastCollect(IBuildingUpgradable buildingUpgradable, UpgradeData nextUpgradeData, GridObject gridObject, DateTime now)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000E9C")]
		private static readonly MessageParser<UpgradeBuilding> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E9D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000864")]
		[DebuggerNonUserCode]
		public static MessageParser<UpgradeBuilding> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB1")]
			[Cpp2IlInjected.Address(RVA = "0x15DC8A0", Offset = "0x15DB2A0", VA = "0x1815DC8A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000865")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB2")]
			[Cpp2IlInjected.Address(RVA = "0x15DC7D0", Offset = "0x15DB1D0", VA = "0x1815DC7D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000866")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002DB3")]
			[Cpp2IlInjected.Address(RVA = "0x15DC900", Offset = "0x15DB300", VA = "0x1815DC900", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UpgradeBuilding()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public UpgradeBuilding(UpgradeBuilding other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB6")]
		[Cpp2IlInjected.Address(RVA = "0x15DC4F0", Offset = "0x15DAEF0", VA = "0x1815DC4F0", Slot = "10")]
		[DebuggerNonUserCode]
		public UpgradeBuilding Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			UpgradeBuilding upgradeBuilding = default(UpgradeBuilding);
			upgradeBuilding.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (upgradeBuilding._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return upgradeBuilding;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DB7")]
		[Cpp2IlInjected.Address(RVA = "0x15DC570", Offset = "0x15DAF70", VA = "0x1815DC570", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002DB8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpgradeBuilding other)
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

		[Cpp2IlInjected.Token(Token = "0x6002DB9")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DBA")]
		[Cpp2IlInjected.Address(RVA = "0x15DC660", Offset = "0x15DB060", VA = "0x1815DC660", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DBB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002DBC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DBD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpgradeBuilding other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DBE")]
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

		[Cpp2IlInjected.Token(Token = "0x6002DBF")]
		[Cpp2IlInjected.Address(RVA = "0x15DC5F0", Offset = "0x15DAFF0", VA = "0x1815DC5F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002DC2")]
		[Cpp2IlInjected.Address(RVA = "0x15DC6C0", Offset = "0x15DB0C0", VA = "0x1815DC6C0")]
		static UpgradeBuilding()
		{
			Func<UpgradeBuilding> func = default(Func<UpgradeBuilding>);
			_parser = (MessageParser<UpgradeBuilding>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
