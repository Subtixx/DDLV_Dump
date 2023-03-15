using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003F0")]
	public sealed class RecipeItemData : IMessage<RecipeItemData>, IMessage, IEquatable<RecipeItemData>, IDeepCloneable<RecipeItemData>, IMessageFieldAccessor, IItemData, IDataValidation, IItemConsummableOverride, IActivityDataItemData
	{
		[Cpp2IlInjected.Token(Token = "0x20003F1")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003F2")]
			public sealed class Ingredient : IMessage<Ingredient>, IMessage, IEquatable<Ingredient>, IDeepCloneable<Ingredient>, IMessageFieldAccessor, IMessageOneofAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x20003F3")]
				public enum IngredientOneofCase
				{
					[Cpp2IlInjected.Token(Token = "0x4001597")]
					None,
					[Cpp2IlInjected.Token(Token = "0x4001598")]
					ItemID,
					[Cpp2IlInjected.Token(Token = "0x4001599")]
					Any,
					[Cpp2IlInjected.Token(Token = "0x400159A")]
					ValidItemsList,
					[Cpp2IlInjected.Token(Token = "0x400159B")]
					TagsList
				}

				[Cpp2IlInjected.Token(Token = "0x400158C")]
				private static readonly MessageParser<Ingredient> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400158D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400158E")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x400158F")]
				public const int AnyFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x4001590")]
				public const int ValidItemsListFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4001591")]
				public const int TagsListFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001592")]
				private object ingredient_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001593")]
				private IngredientOneofCase ingredientCase_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001594")]
				private Item[] itemsArray;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4001595")]
				private Item[] tagsArray;

				[Cpp2IlInjected.Token(Token = "0x17000C50")]
				[DebuggerNonUserCode]
				public static MessageParser<Ingredient> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600301A")]
					[Cpp2IlInjected.Address(RVA = "0x2370480", Offset = "0x236EE80", VA = "0x182370480")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C51")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600301B")]
					[Cpp2IlInjected.Address(RVA = "0x2370180", Offset = "0x236EB80", VA = "0x182370180")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C52")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600301C")]
					[Cpp2IlInjected.Address(RVA = "0x2370710", Offset = "0x236F110", VA = "0x182370710", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C53")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6003021")]
					[Cpp2IlInjected.Address(RVA = "0x2370200", Offset = "0x236EC00", VA = "0x182370200")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6003022")]
					[Cpp2IlInjected.Address(RVA = "0x2370840", Offset = "0x236F240", VA = "0x182370840")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C54")]
				[DebuggerNonUserCode]
				public int Any
				{
					[Cpp2IlInjected.Token(Token = "0x6003023")]
					[Cpp2IlInjected.Address(RVA = "0x2370110", Offset = "0x236EB10", VA = "0x182370110")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6003024")]
					[Cpp2IlInjected.Address(RVA = "0x23707D0", Offset = "0x236F1D0", VA = "0x1823707D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C55")]
				[DebuggerNonUserCode]
				public IngredientsList ValidItemsList
				{
					[Cpp2IlInjected.Token(Token = "0x6003025")]
					[Cpp2IlInjected.Address(RVA = "0x23706B0", Offset = "0x236F0B0", VA = "0x1823706B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003026")]
					[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C56")]
				[DebuggerNonUserCode]
				public TagsList TagsList
				{
					[Cpp2IlInjected.Token(Token = "0x6003027")]
					[Cpp2IlInjected.Address(RVA = "0x23704E0", Offset = "0x236EEE0", VA = "0x1823704E0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003028")]
					[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C57")]
				[DebuggerNonUserCode]
				public IngredientOneofCase IngredientCase
				{
					[Cpp2IlInjected.Token(Token = "0x6003029")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(IngredientOneofCase);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C58")]
				public Item? Item
				{
					[Cpp2IlInjected.Token(Token = "0x6003038")]
					[Cpp2IlInjected.Address(RVA = "0x2370270", Offset = "0x236EC70", VA = "0x182370270")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C59")]
				public Item? AnyItem
				{
					[Cpp2IlInjected.Token(Token = "0x6003039")]
					[Cpp2IlInjected.Address(RVA = "0x2370070", Offset = "0x236EA70", VA = "0x182370070")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C5A")]
				public Item[] ItemsList
				{
					[Cpp2IlInjected.Token(Token = "0x600303A")]
					[Cpp2IlInjected.Address(RVA = "0x2370310", Offset = "0x236ED10", VA = "0x182370310")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C5B")]
				public Item[] Tags
				{
					[Cpp2IlInjected.Token(Token = "0x600303B")]
					[Cpp2IlInjected.Address(RVA = "0x2370540", Offset = "0x236EF40", VA = "0x182370540")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600301D")]
				[Cpp2IlInjected.Address(RVA = "0x236FFB0", Offset = "0x236E9B0", VA = "0x18236FFB0")]
				[DebuggerNonUserCode]
				public Ingredient()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600301E")]
				[Cpp2IlInjected.Address(RVA = "0x236F820", Offset = "0x236E220", VA = "0x18236F820")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600301F")]
				[Cpp2IlInjected.Address(RVA = "0x236FD70", Offset = "0x236E770", VA = "0x18236FD70")]
				[DebuggerNonUserCode]
				public Ingredient(Ingredient other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003020")]
				[Cpp2IlInjected.Address(RVA = "0x236E5C0", Offset = "0x236CFC0", VA = "0x18236E5C0", Slot = "10")]
				[DebuggerNonUserCode]
				public Ingredient Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600302A")]
				[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
				[DebuggerNonUserCode]
				public void ClearIngredient()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600302B")]
				[Cpp2IlInjected.Address(RVA = "0x236E720", Offset = "0x236D120", VA = "0x18236E720", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600302C")]
				[Cpp2IlInjected.Address(RVA = "0x236E620", Offset = "0x236D020", VA = "0x18236E620", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Ingredient other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600302D")]
				[Cpp2IlInjected.Address(RVA = "0x236E960", Offset = "0x236D360", VA = "0x18236E960", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600302E")]
				[Cpp2IlInjected.Address(RVA = "0x236FA70", Offset = "0x236E470", VA = "0x18236FA70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600302F")]
				[Cpp2IlInjected.Address(RVA = "0x236FAD0", Offset = "0x236E4D0", VA = "0x18236FAD0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003030")]
				[Cpp2IlInjected.Address(RVA = "0x236E280", Offset = "0x236CC80", VA = "0x18236E280", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003031")]
				[Cpp2IlInjected.Address(RVA = "0x236F660", Offset = "0x236E060", VA = "0x18236F660", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Ingredient other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003032")]
				[Cpp2IlInjected.Address(RVA = "0x236F400", Offset = "0x236DE00", VA = "0x18236F400", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003033")]
				[Cpp2IlInjected.Address(RVA = "0x236E860", Offset = "0x236D260", VA = "0x18236E860", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003034")]
				[Cpp2IlInjected.Address(RVA = "0x236F8D0", Offset = "0x236E2D0", VA = "0x18236F8D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003035")]
				[Cpp2IlInjected.Address(RVA = "0x236E4F0", Offset = "0x236CEF0", VA = "0x18236E4F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003036")]
				[Cpp2IlInjected.Address(RVA = "0x236EB70", Offset = "0x236D570", VA = "0x18236EB70", Slot = "14")]
				[DebuggerNonUserCode]
				public int GetOneofCase(string oneofName)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003037")]
				[Cpp2IlInjected.Address(RVA = "0x236E550", Offset = "0x236CF50", VA = "0x18236E550", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearOneOf(string oneofName)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600303C")]
				[Cpp2IlInjected.Address(RVA = "0x236EFF0", Offset = "0x236D9F0", VA = "0x18236EFF0")]
				public bool IsIngredientValid(Item item)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600303D")]
				[Cpp2IlInjected.Address(RVA = "0x236EC20", Offset = "0x236D620", VA = "0x18236EC20")]
				public bool IsIngredientType(Item cookingIngredientType)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003F7")]
			public sealed class IngredientsList : IMessage<IngredientsList>, IMessage, IEquatable<IngredientsList>, IDeepCloneable<IngredientsList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40015A0")]
				private static readonly MessageParser<IngredientsList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40015A1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40015A2")]
				public const int ListFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40015A3")]
				private static readonly FieldCodec<int> _repeated_list_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40015A4")]
				private readonly RepeatedField<int> list_;

				[Cpp2IlInjected.Token(Token = "0x17000C5C")]
				[DebuggerNonUserCode]
				public static MessageParser<IngredientsList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003046")]
					[Cpp2IlInjected.Address(RVA = "0x2371230", Offset = "0x236FC30", VA = "0x182371230")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C5D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003047")]
					[Cpp2IlInjected.Address(RVA = "0x23711B0", Offset = "0x236FBB0", VA = "0x1823711B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C5E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003048")]
					[Cpp2IlInjected.Address(RVA = "0x2371290", Offset = "0x236FC90", VA = "0x182371290", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C5F")]
				[DebuggerNonUserCode]
				public RepeatedField<int> List
				{
					[Cpp2IlInjected.Token(Token = "0x600304C")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003049")]
				[Cpp2IlInjected.Address(RVA = "0x2371130", Offset = "0x236FB30", VA = "0x182371130")]
				[DebuggerNonUserCode]
				public IngredientsList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600304A")]
				[Cpp2IlInjected.Address(RVA = "0x23710A0", Offset = "0x236FAA0", VA = "0x1823710A0")]
				[DebuggerNonUserCode]
				public IngredientsList(IngredientsList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600304B")]
				[Cpp2IlInjected.Address(RVA = "0x23709C0", Offset = "0x236F3C0", VA = "0x1823709C0", Slot = "10")]
				[DebuggerNonUserCode]
				public IngredientsList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600304D")]
				[Cpp2IlInjected.Address(RVA = "0x2370A80", Offset = "0x236F480", VA = "0x182370A80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600304E")]
				[Cpp2IlInjected.Address(RVA = "0x2370B60", Offset = "0x236F560", VA = "0x182370B60", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(IngredientsList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600304F")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003050")]
				[Cpp2IlInjected.Address(RVA = "0x2370E40", Offset = "0x236F840", VA = "0x182370E40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003051")]
				[Cpp2IlInjected.Address(RVA = "0x2370EA0", Offset = "0x236F8A0", VA = "0x182370EA0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003052")]
				[Cpp2IlInjected.Address(RVA = "0x23708B0", Offset = "0x236F2B0", VA = "0x1823708B0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003053")]
				[Cpp2IlInjected.Address(RVA = "0x2370D60", Offset = "0x236F760", VA = "0x182370D60", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(IngredientsList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003054")]
				[Cpp2IlInjected.Address(RVA = "0x2370C70", Offset = "0x236F670", VA = "0x182370C70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003055")]
				[Cpp2IlInjected.Address(RVA = "0x2370BF0", Offset = "0x236F5F0", VA = "0x182370BF0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003056")]
				[Cpp2IlInjected.Address(RVA = "0x2370DE0", Offset = "0x236F7E0", VA = "0x182370DE0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003057")]
				[Cpp2IlInjected.Address(RVA = "0x2370960", Offset = "0x236F360", VA = "0x182370960", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003F9")]
			public sealed class TagsList : IMessage<TagsList>, IMessage, IEquatable<TagsList>, IDeepCloneable<TagsList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40015A6")]
				private static readonly MessageParser<TagsList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40015A7")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40015A8")]
				public const int ListFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40015A9")]
				private static readonly FieldCodec<int> _repeated_list_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40015AA")]
				private readonly RepeatedField<int> list_;

				[Cpp2IlInjected.Token(Token = "0x17000C60")]
				[DebuggerNonUserCode]
				public static MessageParser<TagsList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600305C")]
					[Cpp2IlInjected.Address(RVA = "0x237A0E0", Offset = "0x2378AE0", VA = "0x18237A0E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C61")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600305D")]
					[Cpp2IlInjected.Address(RVA = "0x237A060", Offset = "0x2378A60", VA = "0x18237A060")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C62")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600305E")]
					[Cpp2IlInjected.Address(RVA = "0x237A140", Offset = "0x2378B40", VA = "0x18237A140", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C63")]
				[DebuggerNonUserCode]
				public RepeatedField<int> List
				{
					[Cpp2IlInjected.Token(Token = "0x6003062")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600305F")]
				[Cpp2IlInjected.Address(RVA = "0x2379FE0", Offset = "0x23789E0", VA = "0x182379FE0")]
				[DebuggerNonUserCode]
				public TagsList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003060")]
				[Cpp2IlInjected.Address(RVA = "0x2379F50", Offset = "0x2378950", VA = "0x182379F50")]
				[DebuggerNonUserCode]
				public TagsList(TagsList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003061")]
				[Cpp2IlInjected.Address(RVA = "0x2379870", Offset = "0x2378270", VA = "0x182379870", Slot = "10")]
				[DebuggerNonUserCode]
				public TagsList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003063")]
				[Cpp2IlInjected.Address(RVA = "0x2379930", Offset = "0x2378330", VA = "0x182379930", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003064")]
				[Cpp2IlInjected.Address(RVA = "0x2379A10", Offset = "0x2378410", VA = "0x182379A10", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(TagsList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003065")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003066")]
				[Cpp2IlInjected.Address(RVA = "0x2379CF0", Offset = "0x23786F0", VA = "0x182379CF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003067")]
				[Cpp2IlInjected.Address(RVA = "0x2379D50", Offset = "0x2378750", VA = "0x182379D50", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003068")]
				[Cpp2IlInjected.Address(RVA = "0x2379760", Offset = "0x2378160", VA = "0x182379760", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003069")]
				[Cpp2IlInjected.Address(RVA = "0x2379C10", Offset = "0x2378610", VA = "0x182379C10", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(TagsList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600306A")]
				[Cpp2IlInjected.Address(RVA = "0x2379B20", Offset = "0x2378520", VA = "0x182379B20", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600306B")]
				[Cpp2IlInjected.Address(RVA = "0x2379AA0", Offset = "0x23784A0", VA = "0x182379AA0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600306C")]
				[Cpp2IlInjected.Address(RVA = "0x2379C90", Offset = "0x2378690", VA = "0x182379C90", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600306D")]
				[Cpp2IlInjected.Address(RVA = "0x2379810", Offset = "0x2378210", VA = "0x182379810", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001577")]
		private static readonly MessageParser<RecipeItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001578")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001579")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400157A")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x400157B")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400157C")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400157D")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400157E")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x400157F")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001580")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001581")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001582")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001583")]
		public const int TimeToCookFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001584")]
		private Duration timeToCook_;

		[Cpp2IlInjected.Token(Token = "0x4001585")]
		public const int ResultItemIDFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001586")]
		private int resultItemID_;

		[Cpp2IlInjected.Token(Token = "0x4001587")]
		public const int ConsummableOverrideItemIDFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4001588")]
		private int consummableOverrideItemID_;

		[Cpp2IlInjected.Token(Token = "0x4001589")]
		public const int IngredientsFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x400158A")]
		private static readonly FieldCodec<Types.Ingredient> _repeated_ingredients_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400158B")]
		private readonly RepeatedField<Types.Ingredient> ingredients_ = (RepeatedField<Types.Ingredient>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000C41")]
		[DebuggerNonUserCode]
		public static MessageParser<RecipeItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002FF0")]
			[Cpp2IlInjected.Address(RVA = "0x2DA6AC0", Offset = "0x2DA54C0", VA = "0x182DA6AC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C42")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002FF1")]
			[Cpp2IlInjected.Address(RVA = "0x2DA69F0", Offset = "0x2DA53F0", VA = "0x182DA69F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C43")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002FF2")]
			[Cpp2IlInjected.Address(RVA = "0x2DA6B20", Offset = "0x2DA5520", VA = "0x182DA6B20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C44")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002FF7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FF8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C45")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002FF9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FFA")]
			[Cpp2IlInjected.Address(RVA = "0x2DA6D10", Offset = "0x2DA5710", VA = "0x182DA6D10")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C46")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002FFB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FFC")]
			[Cpp2IlInjected.Address(RVA = "0x2DA6C30", Offset = "0x2DA5630", VA = "0x182DA6C30")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C47")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002FFD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002FFE")]
			[Cpp2IlInjected.Address(RVA = "0x2DA6CA0", Offset = "0x2DA56A0", VA = "0x182DA6CA0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C48")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002FFF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003000")]
			[Cpp2IlInjected.Address(RVA = "0x2DA6D80", Offset = "0x2DA5780", VA = "0x182DA6D80")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C49")]
		[DebuggerNonUserCode]
		public Duration TimeToCook
		{
			[Cpp2IlInjected.Token(Token = "0x6003001")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return timeToCook_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003002")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				timeToCook_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C4A")]
		[DebuggerNonUserCode]
		public int ResultItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6003003")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return resultItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003004")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				resultItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C4B")]
		[DebuggerNonUserCode]
		public int ConsummableOverrideItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6003005")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return consummableOverrideItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003006")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				consummableOverrideItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C4C")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.Ingredient> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x6003007")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return ingredients_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C4D")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6003013")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C4E")]
		public Item ResultItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003014")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "23")]
			get
			{
				int num = resultItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C4F")]
		public Item? ConsummableOverrideItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003016")]
			[Cpp2IlInjected.Address(RVA = "0x2DA6920", Offset = "0x2DA5320", VA = "0x182DA6920", Slot = "22")]
			get
			{
				int num = consummableOverrideItemID_;
				long num2 = Convert.ToInt64((uint)consummableOverrideItemID_);
				int num3 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF3")]
		[Cpp2IlInjected.Address(RVA = "0x2DA64D0", Offset = "0x2DA4ED0", VA = "0x182DA64D0")]
		[DebuggerNonUserCode]
		public RecipeItemData()
		{
			TimeSpan timeSpan = default(TimeSpan);
			Duration duration = (timeToCook_ = Duration.FromTimeSpan(timeSpan));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF4")]
		[Cpp2IlInjected.Address(RVA = "0x2DA5C80", Offset = "0x2DA4680", VA = "0x182DA5C80")]
		private void OnConstruction()
		{
			TimeSpan timeSpan = default(TimeSpan);
			Duration duration = (timeToCook_ = Duration.FromTimeSpan(timeSpan));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF5")]
		[Cpp2IlInjected.Address(RVA = "0x2DA6670", Offset = "0x2DA5070", VA = "0x182DA6670")]
		[DebuggerNonUserCode]
		public RecipeItemData(RecipeItemData other)
		{
			//IL_00bc: Expected O, but got I4
			TimeSpan timeSpan = default(TimeSpan);
			Duration duration = (timeToCook_ = Duration.FromTimeSpan(timeSpan));
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			Duration duration2 = other.timeToCook_;
			if (duration2 != null)
			{
				Duration duration3 = duration2.Clone();
			}
			int num2 = 0;
			timeToCook_ = (Duration)num2;
			int num3 = (resultItemID_ = other.resultItemID_);
			int num4 = (consummableOverrideItemID_ = other.consummableOverrideItemID_);
			RepeatedField<Types.Ingredient> repeatedField = (ingredients_ = (RepeatedField<Types.Ingredient>)(object)((RepeatedField<T>)(object)other.ingredients_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002FF6")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4F60", Offset = "0x2DA3960", VA = "0x182DA4F60", Slot = "10")]
		[DebuggerNonUserCode]
		public RecipeItemData Clone()
		{
			return new RecipeItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003008")]
		[Cpp2IlInjected.Address(RVA = "0x2DA5340", Offset = "0x2DA3D40", VA = "0x182DA5340", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(RecipeItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									bool flag5 = object.Equals(timeToCook_, other);
									if (flag5 && resultItemID_ == (flag5 ? 1 : 0) && consummableOverrideItemID_ == (flag5 ? 1 : 0))
									{
										RepeatedField<Types.Ingredient> repeatedField = ingredients_;
										bool flag6 = default(bool);
										if (flag6)
										{
											return object.Equals(_unknownFields, other);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003009")]
		[Cpp2IlInjected.Address(RVA = "0x2DA54B0", Offset = "0x2DA3EB0", VA = "0x182DA54B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RecipeItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									Duration objB = other.timeToCook_;
									if (object.Equals(timeToCook_, objB))
									{
										int num2 = other.resultItemID_;
										if (resultItemID_ == num2)
										{
											int num3 = other.consummableOverrideItemID_;
											if (consummableOverrideItemID_ == num3)
											{
												RepeatedField<Types.Ingredient> repeatedField = ingredients_;
												RepeatedField<Types.Ingredient> repeatedField2 = other.ingredients_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													UnknownFieldSet unknownFields = other._unknownFields;
													return object.Equals(_unknownFields, unknownFields);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600300A")]
		[Cpp2IlInjected.Address(RVA = "0x2DA5730", Offset = "0x2DA4130", VA = "0x182DA5730", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00bb
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			Duration duration = timeToCook_;
			if (duration != null)
			{
				int hashCode5 = duration.GetHashCode();
			}
			if (resultItemID_ != 0)
			{
			}
			if (consummableOverrideItemID_ != 0)
			{
			}
			int hashCode6 = ((RepeatedField<T>)(object)ingredients_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600300B")]
		[Cpp2IlInjected.Address(RVA = "0x2DA6060", Offset = "0x2DA4A60", VA = "0x182DA6060", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600300C")]
		[Cpp2IlInjected.Address(RVA = "0x2DA60C0", Offset = "0x2DA4AC0", VA = "0x182DA60C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0105
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if ((long)timeToCook_ != 0)
			{
				Duration value6 = timeToCook_;
				output.WriteMessage(value6);
			}
			if (resultItemID_ != 0)
			{
				int value7 = resultItemID_;
				output.WriteInt32(value7);
			}
			RepeatedField<Types.Ingredient> repeatedField = ingredients_;
			FieldCodec<Types.Ingredient> repeated_ingredients_codec = _repeated_ingredients_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_ingredients_codec);
			if (consummableOverrideItemID_ != 0)
			{
				int value8 = consummableOverrideItemID_;
				output.WriteInt32(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600300D")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4B60", Offset = "0x2DA3560", VA = "0x182DA4B60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0148
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			Duration duration = timeToCook_;
			if (duration != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(duration);
				num8++;
				num2 += num8;
			}
			int num9 = resultItemID_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			int num11 = consummableOverrideItemID_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			RepeatedField<Types.Ingredient> repeatedField = ingredients_;
			FieldCodec<Types.Ingredient> repeated_ingredients_codec = _repeated_ingredients_codec;
			int num13 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_ingredients_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num13;
			if (unknownFields != null)
			{
				int num14 = unknownFields.CalculateSize();
				num2 += num14;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600300E")]
		[Cpp2IlInjected.Address(RVA = "0x2DA5AF0", Offset = "0x2DA44F0", VA = "0x182DA5AF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RecipeItemData other)
		{
			//Discarded unreachable code: IL_0117
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			if ((long)other.timeToCook_ != 0)
			{
				Duration duration2 = default(Duration);
				if (timeToCook_ == null)
				{
					Duration duration = (timeToCook_ = new Duration());
					duration2 = timeToCook_;
				}
				Duration other2 = other.timeToCook_;
				duration2.MergeFrom(other2);
			}
			int num2 = other.resultItemID_;
			if (num2 != 0)
			{
				resultItemID_ = num2;
			}
			int num3 = other.consummableOverrideItemID_;
			if (num3 != 0)
			{
				consummableOverrideItemID_ = num3;
			}
			RepeatedField<Types.Ingredient> repeatedField = ingredients_;
			RepeatedField<Types.Ingredient> repeatedField2 = other.ingredients_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600300F")]
		[Cpp2IlInjected.Address(RVA = "0x2DA58A0", Offset = "0x2DA42A0", VA = "0x182DA58A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0127
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if (num == 56)
					{
						int num2 = (resultItemID_ = input.ReadInt32());
					}
					if (num == 66)
					{
						RepeatedField<Types.Ingredient> repeatedField = ingredients_;
						FieldCodec<Types.Ingredient> repeated_ingredients_codec = _repeated_ingredients_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_ingredients_codec);
					}
					if (num != 72)
					{
						goto IL_0110;
					}
					int num3 = (consummableOverrideItemID_ = input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 42)
				{
					text2 = (PrefabAddress = input.ReadString());
				}
				if ((long)text2 != 50)
				{
					goto IL_0110;
				}
				Duration builder = default(Duration);
				if (timeToCook_ == null)
				{
					Duration duration = (timeToCook_ = new Duration());
					builder = timeToCook_;
				}
				input.ReadMessage(builder);
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text4 = default(string);
				if (num == 26)
				{
					text4 = (DisplayName = input.ReadString());
				}
				if ((long)text4 != 34)
				{
					goto IL_0110;
				}
				text6 = (IconAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text6 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text8 = (Name = input.ReadString());
			}
			goto IL_0110;
			IL_0110:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003010")]
		[Cpp2IlInjected.Address(RVA = "0x2DA55D0", Offset = "0x2DA3FD0", VA = "0x182DA55D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003011")]
		[Cpp2IlInjected.Address(RVA = "0x2DA5D60", Offset = "0x2DA4760", VA = "0x182DA5D60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0021, IL_0029, IL_002f, IL_0035, IL_003b, IL_0041, IL_0047
			//IL_000d: Expected I4, but got O
			//IL_0019: Expected O, but got I4
			if (fieldNumber - 1 <= 8)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003012")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4DF0", Offset = "0x2DA37F0", VA = "0x182DA4DF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0016, IL_0018
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 8)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003015")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4F60", Offset = "0x2DA3960", VA = "0x182DA4F60", Slot = "20")]
		IItemData IItemData.Clone()
		{
			RecipeItemData recipeItemData = new RecipeItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003017")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4FC0", Offset = "0x2DA39C0", VA = "0x182DA4FC0")]
		public bool ContainsIngredientType(Item cookingIngredientType)
		{
			//Discarded unreachable code: IL_002a
			int num = 0;
			int num2 = 0;
			RepeatedField<Types.Ingredient> repeatedField = ingredients_;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003018")]
		[Cpp2IlInjected.Address(RVA = "0x2DA5150", Offset = "0x2DA3B50", VA = "0x182DA5150", Slot = "21")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0064
			//IL_0059: Expected O, but got I4
			RepeatedField<Types.Ingredient> cpp2il__autoParamName__idx_ = ingredients_;
			context.RequireNotEmpty<Types.Ingredient>((IEnumerable<>)(object)cpp2il__autoParamName__idx_, "Ingredients");
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			RepeatedField<Types.Ingredient> repeatedField = ingredients_;
			MealItemData mealItemData = default(MealItemData);
			int starRating_ = mealItemData.starRating_;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			if (starRating_ != count)
			{
				int count2 = ((RepeatedField<T>)(object)ingredients_).Count;
				string error = string.Format("{0} {1} must be equal to {2}", "ResultItem", "StarRating", count2);
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003019")]
		[Cpp2IlInjected.Address(RVA = "0x2DA6300", Offset = "0x2DA4D00", VA = "0x182DA6300")]
		static RecipeItemData()
		{
			Func<RecipeItemData> func = default(Func<RecipeItemData>);
			_parser = (MessageParser<RecipeItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.Ingredient> parser = Types.Ingredient._parser;
			uint num = default(uint);
			_parser = (MessageParser<RecipeItemData>)(object)FieldCodec.ForMessage<Types.Ingredient>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
