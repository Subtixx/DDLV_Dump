using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200037E")]
	public sealed class CookWithIngredients : IMessage<CookWithIngredients>, IMessage, IEquatable<CookWithIngredients>, IDeepCloneable<CookWithIngredients>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200037F")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000380")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000ADF")]
				[OriginalName("Result_Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000AE0")]
				[OriginalName("Result_InvalidCookingStation")]
				InvalidCookingStation,
				[Cpp2IlInjected.Token(Token = "0x4000AE1")]
				[OriginalName("Result_InvalidContainerInventory")]
				InvalidContainerInventory,
				[Cpp2IlInjected.Token(Token = "0x4000AE2")]
				[OriginalName("Result_NotEnoughIngredients")]
				NotEnoughIngredients,
				[Cpp2IlInjected.Token(Token = "0x4000AE3")]
				[OriginalName("Result_NotEnoughMana")]
				NotEnoughMana,
				[Cpp2IlInjected.Token(Token = "0x4000AE4")]
				[OriginalName("Result_NotEnoughCombustible")]
				NotEnoughCombustible,
				[Cpp2IlInjected.Token(Token = "0x4000AE5")]
				[OriginalName("Result_InvalidIngredients")]
				InvalidIngredients,
				[Cpp2IlInjected.Token(Token = "0x4000AE6")]
				[OriginalName("Result_InventoryFull")]
				InventoryFull
			}

			[Cpp2IlInjected.Token(Token = "0x2000381")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IInventoryFullRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4000AE7")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000AE8")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000AE9")]
				public const int CookingStationItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000AEA")]
				private int cookingStationItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000AEB")]
				public const int IngredientsFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4000AEC")]
				private static readonly FieldCodec<int> _repeated_ingredients_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000AED")]
				private readonly RepeatedField<int> ingredients_;

				[Cpp2IlInjected.Token(Token = "0x4000AEE")]
				public const int ContainerInventoryIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000AEF")]
				private uint containerInventoryID_;

				[Cpp2IlInjected.Token(Token = "0x4000AF0")]
				public const int InventoryFullResolutionFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000AF1")]
				private InventoryFullResolution inventoryFullResolution_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000AF2")]
				public bool DryRun;

				[Cpp2IlInjected.Token(Token = "0x17000652")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60022CB")]
					[Cpp2IlInjected.Address(RVA = "0x1F07CF0", Offset = "0x1F066F0", VA = "0x181F07CF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000653")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60022CC")]
					[Cpp2IlInjected.Address(RVA = "0x1F077D0", Offset = "0x1F061D0", VA = "0x181F077D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000654")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60022CD")]
					[Cpp2IlInjected.Address(RVA = "0x1F07F30", Offset = "0x1F06930", VA = "0x181F07F30", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000655")]
				[DebuggerNonUserCode]
				public int CookingStationItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60022D1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60022D2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000656")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Ingredients
				{
					[Cpp2IlInjected.Token(Token = "0x60022D3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000657")]
				[DebuggerNonUserCode]
				public uint ContainerInventoryID
				{
					[Cpp2IlInjected.Token(Token = "0x60022D4")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x60022D5")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000658")]
				[DebuggerNonUserCode]
				public InventoryFullResolution InventoryFullResolution
				{
					[Cpp2IlInjected.Token(Token = "0x60022D6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "16")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60022D7")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "17")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60022CE")]
				[Cpp2IlInjected.Address(RVA = "0x1F073C0", Offset = "0x1F05DC0", VA = "0x181F073C0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60022CF")]
				[Cpp2IlInjected.Address(RVA = "0x1F07180", Offset = "0x1F05B80", VA = "0x181F07180")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60022D0")]
				[Cpp2IlInjected.Address(RVA = "0x1F02A90", Offset = "0x1F01490", VA = "0x181F02A90", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60022D8")]
				[Cpp2IlInjected.Address(RVA = "0x1F030A0", Offset = "0x1F01AA0", VA = "0x181F030A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60022D9")]
				[Cpp2IlInjected.Address(RVA = "0x1F02F40", Offset = "0x1F01940", VA = "0x181F02F40", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60022DA")]
				[Cpp2IlInjected.Address(RVA = "0x1F03C80", Offset = "0x1F02680", VA = "0x181F03C80", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60022DB")]
				[Cpp2IlInjected.Address(RVA = "0x1F04AD0", Offset = "0x1F034D0", VA = "0x181F04AD0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60022DC")]
				[Cpp2IlInjected.Address(RVA = "0x1F064C0", Offset = "0x1F04EC0", VA = "0x181F064C0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60022DD")]
				[Cpp2IlInjected.Address(RVA = "0x1F016A0", Offset = "0x1F000A0", VA = "0x181F016A0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60022DE")]
				[Cpp2IlInjected.Address(RVA = "0x1F03DC0", Offset = "0x1F027C0", VA = "0x181F03DC0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60022DF")]
				[Cpp2IlInjected.Address(RVA = "0x1F03FC0", Offset = "0x1F029C0", VA = "0x181F03FC0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60022E0")]
				[Cpp2IlInjected.Address(RVA = "0x1F03740", Offset = "0x1F02140", VA = "0x181F03740", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60022E1")]
				[Cpp2IlInjected.Address(RVA = "0x1F045A0", Offset = "0x1F02FA0", VA = "0x181F045A0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60022E2")]
				[Cpp2IlInjected.Address(RVA = "0x1F026F0", Offset = "0x1F010F0", VA = "0x181F026F0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60022E3")]
				[Cpp2IlInjected.Address(RVA = "0x1F058C0", Offset = "0x1F042C0", VA = "0x181F058C0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000384")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IInventoryFullResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4000AF9")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000AFA")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000AFB")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000AFC")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000AFD")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000AFE")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4000AFF")]
				public const int RecipeItemIDFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000B00")]
				private int recipeItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000B01")]
				public const int MealItemIDFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000B02")]
				private int mealItemID_;

				[Cpp2IlInjected.Token(Token = "0x4000B03")]
				public const int NewRecipeFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000B04")]
				private bool newRecipe_;

				[Cpp2IlInjected.Token(Token = "0x4000B05")]
				public const int InventoryFullDetailsFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000B06")]
				private InventoryFullDetails inventoryFullDetails_;

				[Cpp2IlInjected.Token(Token = "0x17000659")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60022ED")]
					[Cpp2IlInjected.Address(RVA = "0x1F15D00", Offset = "0x1F14700", VA = "0x181F15D00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065A")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60022EE")]
					[Cpp2IlInjected.Address(RVA = "0x1F155E0", Offset = "0x1F13FE0", VA = "0x181F155E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065B")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60022EF")]
					[Cpp2IlInjected.Address(RVA = "0x1F15DC0", Offset = "0x1F147C0", VA = "0x181F15DC0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065C")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60022F3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60022F4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065D")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60022F5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60022F6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065E")]
				[DebuggerNonUserCode]
				public int RecipeItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60022F7")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60022F8")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065F")]
				[DebuggerNonUserCode]
				public int MealItemID
				{
					[Cpp2IlInjected.Token(Token = "0x60022F9")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60022FA")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000660")]
				[DebuggerNonUserCode]
				public bool NewRecipe
				{
					[Cpp2IlInjected.Token(Token = "0x60022FB")]
					[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x60022FC")]
					[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000661")]
				[DebuggerNonUserCode]
				public InventoryFullDetails InventoryFullDetails
				{
					[Cpp2IlInjected.Token(Token = "0x60022FD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "23")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60022FE")]
					[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0", Slot = "24")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000662")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600230A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600230B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60022F0")]
				[Cpp2IlInjected.Address(RVA = "0x1F153F0", Offset = "0x1F13DF0", VA = "0x181F153F0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60022F1")]
				[Cpp2IlInjected.Address(RVA = "0x1F15430", Offset = "0x1F13E30", VA = "0x181F15430")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60022F2")]
				[Cpp2IlInjected.Address(RVA = "0x1F0F380", Offset = "0x1F0DD80", VA = "0x181F0F380", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60022FF")]
				[Cpp2IlInjected.Address(RVA = "0x1F0FE70", Offset = "0x1F0E870", VA = "0x181F0FE70", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002300")]
				[Cpp2IlInjected.Address(RVA = "0x1F10530", Offset = "0x1F0EF30", VA = "0x181F10530", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002301")]
				[Cpp2IlInjected.Address(RVA = "0x1F10EF0", Offset = "0x1F0F8F0", VA = "0x181F10EF0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002302")]
				[Cpp2IlInjected.Address(RVA = "0x1F134F0", Offset = "0x1F11EF0", VA = "0x181F134F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002303")]
				[Cpp2IlInjected.Address(RVA = "0x1F13B00", Offset = "0x1F12500", VA = "0x181F13B00", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002304")]
				[Cpp2IlInjected.Address(RVA = "0x1F0EBA0", Offset = "0x1F0D5A0", VA = "0x181F0EBA0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002305")]
				[Cpp2IlInjected.Address(RVA = "0x1F116B0", Offset = "0x1F100B0", VA = "0x181F116B0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002306")]
				[Cpp2IlInjected.Address(RVA = "0x1F11B50", Offset = "0x1F10550", VA = "0x181F11B50", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002307")]
				[Cpp2IlInjected.Address(RVA = "0x1F10790", Offset = "0x1F0F190", VA = "0x181F10790", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002308")]
				[Cpp2IlInjected.Address(RVA = "0x1F12CF0", Offset = "0x1F116F0", VA = "0x181F12CF0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002309")]
				[Cpp2IlInjected.Address(RVA = "0x1F0F300", Offset = "0x1F0DD00", VA = "0x181F0F300", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600230C")]
				[Cpp2IlInjected.Address(RVA = "0x1F0B070", Offset = "0x1F09A70", VA = "0x181F0B070", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000ADC")]
		private static readonly MessageParser<CookWithIngredients> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000ADD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700064F")]
		[DebuggerNonUserCode]
		public static MessageParser<CookWithIngredients> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60022B9")]
			[Cpp2IlInjected.Address(RVA = "0x18BA4F0", Offset = "0x18B8EF0", VA = "0x1818BA4F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000650")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60022BA")]
			[Cpp2IlInjected.Address(RVA = "0x18BA420", Offset = "0x18B8E20", VA = "0x1818BA420")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000651")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60022BB")]
			[Cpp2IlInjected.Address(RVA = "0x18BA550", Offset = "0x18B8F50", VA = "0x1818BA550", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022BC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CookWithIngredients()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60022BD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public CookWithIngredients(CookWithIngredients other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022BE")]
		[Cpp2IlInjected.Address(RVA = "0x18BA140", Offset = "0x18B8B40", VA = "0x1818BA140", Slot = "10")]
		[DebuggerNonUserCode]
		public CookWithIngredients Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			CookWithIngredients cookWithIngredients = default(CookWithIngredients);
			cookWithIngredients.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (cookWithIngredients._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return cookWithIngredients;
		}

		[Cpp2IlInjected.Token(Token = "0x60022BF")]
		[Cpp2IlInjected.Address(RVA = "0x18BA1C0", Offset = "0x18B8BC0", VA = "0x1818BA1C0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60022C0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CookWithIngredients other)
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

		[Cpp2IlInjected.Token(Token = "0x60022C1")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60022C2")]
		[Cpp2IlInjected.Address(RVA = "0x18BA2B0", Offset = "0x18B8CB0", VA = "0x1818BA2B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60022C3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60022C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60022C5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CookWithIngredients other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022C6")]
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

		[Cpp2IlInjected.Token(Token = "0x60022C7")]
		[Cpp2IlInjected.Address(RVA = "0x18BA240", Offset = "0x18B8C40", VA = "0x1818BA240", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022C8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60022CA")]
		[Cpp2IlInjected.Address(RVA = "0x18BA310", Offset = "0x18B8D10", VA = "0x1818BA310")]
		static CookWithIngredients()
		{
			Func<CookWithIngredients> func = default(Func<CookWithIngredients>);
			_parser = (MessageParser<CookWithIngredients>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
