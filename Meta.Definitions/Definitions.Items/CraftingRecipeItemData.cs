using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000403")]
	public sealed class CraftingRecipeItemData : IMessage<CraftingRecipeItemData>, IMessage, IEquatable<CraftingRecipeItemData>, IDeepCloneable<CraftingRecipeItemData>, IMessageFieldAccessor, IItemData, IRewardGenerationCondition, IDataValidation, IHasItemDependencies, IItemConsummableOverride, IActivityDataItemData
	{
		[Cpp2IlInjected.Token(Token = "0x2000404")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000405")]
			public sealed class ResultInstance : IMessage<ResultInstance>, IMessage, IEquatable<ResultInstance>, IDeepCloneable<ResultInstance>, IMessageFieldAccessor, IItemWithState
			{
				[Cpp2IlInjected.Token(Token = "0x400160D")]
				private static readonly MessageParser<ResultInstance> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400160E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400160F")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001610")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4001611")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4001612")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x4001613")]
				public const int StateFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001614")]
				private ItemState state_;

				[Cpp2IlInjected.Token(Token = "0x17000CA3")]
				[DebuggerNonUserCode]
				public static MessageParser<ResultInstance> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003135")]
					[Cpp2IlInjected.Address(RVA = "0x294A230", Offset = "0x2948C30", VA = "0x18294A230")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA4")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003136")]
					[Cpp2IlInjected.Address(RVA = "0x294A150", Offset = "0x2948B50", VA = "0x18294A150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA5")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003137")]
					[Cpp2IlInjected.Address(RVA = "0x294A290", Offset = "0x2948C90", VA = "0x18294A290", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA6")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x600313C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600313D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA7")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x600313E")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600313F")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA8")]
				[DebuggerNonUserCode]
				public ItemState State
				{
					[Cpp2IlInjected.Token(Token = "0x6003140")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003141")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "17")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CA9")]
				public Item Item
				{
					[Cpp2IlInjected.Token(Token = "0x600314D")]
					[Cpp2IlInjected.Address(RVA = "0x294A1D0", Offset = "0x2948BD0", VA = "0x18294A1D0", Slot = "15")]
					get
					{
						return default(Item);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003138")]
				[Cpp2IlInjected.Address(RVA = "0x1EE50B0", Offset = "0x1EE3AB0", VA = "0x181EE50B0")]
				[DebuggerNonUserCode]
				public ResultInstance()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003139")]
				[Cpp2IlInjected.Address(RVA = "0x1E30960", Offset = "0x1E2F360", VA = "0x181E30960")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600313A")]
				[Cpp2IlInjected.Address(RVA = "0x294A0D0", Offset = "0x2948AD0", VA = "0x18294A0D0")]
				[DebuggerNonUserCode]
				public ResultInstance(ResultInstance other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600313B")]
				[Cpp2IlInjected.Address(RVA = "0x2949A10", Offset = "0x2948410", VA = "0x182949A10", Slot = "10")]
				[DebuggerNonUserCode]
				public ResultInstance Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003142")]
				[Cpp2IlInjected.Address(RVA = "0x2949AC0", Offset = "0x29484C0", VA = "0x182949AC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003143")]
				[Cpp2IlInjected.Address(RVA = "0x18C2CE0", Offset = "0x18C16E0", VA = "0x1818C2CE0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ResultInstance other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003144")]
				[Cpp2IlInjected.Address(RVA = "0x18C2EE0", Offset = "0x18C18E0", VA = "0x1818C2EE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003145")]
				[Cpp2IlInjected.Address(RVA = "0x2949F60", Offset = "0x2948960", VA = "0x182949F60", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003146")]
				[Cpp2IlInjected.Address(RVA = "0x1F16E70", Offset = "0x1F15870", VA = "0x181F16E70", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003147")]
				[Cpp2IlInjected.Address(RVA = "0x2949910", Offset = "0x2948310", VA = "0x182949910", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003148")]
				[Cpp2IlInjected.Address(RVA = "0x2949C50", Offset = "0x2948650", VA = "0x182949C50", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ResultInstance other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003149")]
				[Cpp2IlInjected.Address(RVA = "0x2949D30", Offset = "0x2948730", VA = "0x182949D30", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600314A")]
				[Cpp2IlInjected.Address(RVA = "0x2949B80", Offset = "0x2948580", VA = "0x182949B80", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600314B")]
				[Cpp2IlInjected.Address(RVA = "0x2949E40", Offset = "0x2948840", VA = "0x182949E40", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600314C")]
				[Cpp2IlInjected.Address(RVA = "0x1F16580", Offset = "0x1F14F80", VA = "0x181F16580", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000407")]
			public sealed class Ingredient : IMessage<Ingredient>, IMessage, IEquatable<Ingredient>, IDeepCloneable<Ingredient>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001616")]
				private static readonly MessageParser<Ingredient> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001617")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001618")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001619")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x400161A")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x400161B")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x17000CAA")]
				[DebuggerNonUserCode]
				public static MessageParser<Ingredient> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003152")]
					[Cpp2IlInjected.Address(RVA = "0x2943720", Offset = "0x2942120", VA = "0x182943720")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CAB")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003153")]
					[Cpp2IlInjected.Address(RVA = "0x2943640", Offset = "0x2942040", VA = "0x182943640")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CAC")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003154")]
					[Cpp2IlInjected.Address(RVA = "0x2943780", Offset = "0x2942180", VA = "0x182943780", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CAD")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6003159")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600315A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CAE")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x600315B")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600315C")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CAF")]
				public Item Item
				{
					[Cpp2IlInjected.Token(Token = "0x6003168")]
					[Cpp2IlInjected.Address(RVA = "0x29436C0", Offset = "0x29420C0", VA = "0x1829436C0")]
					get
					{
						return default(Item);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003155")]
				[Cpp2IlInjected.Address(RVA = "0x1EE50B0", Offset = "0x1EE3AB0", VA = "0x181EE50B0")]
				[DebuggerNonUserCode]
				public Ingredient()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003156")]
				[Cpp2IlInjected.Address(RVA = "0x1E30960", Offset = "0x1E2F360", VA = "0x181E30960")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003157")]
				[Cpp2IlInjected.Address(RVA = "0x29370F0", Offset = "0x2935AF0", VA = "0x1829370F0")]
				[DebuggerNonUserCode]
				public Ingredient(Ingredient other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003158")]
				[Cpp2IlInjected.Address(RVA = "0x2943230", Offset = "0x2941C30", VA = "0x182943230", Slot = "10")]
				[DebuggerNonUserCode]
				public Ingredient Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600315D")]
				[Cpp2IlInjected.Address(RVA = "0x29432C0", Offset = "0x2941CC0", VA = "0x1829432C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600315E")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Ingredient other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600315F")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003160")]
				[Cpp2IlInjected.Address(RVA = "0x29434D0", Offset = "0x2941ED0", VA = "0x1829434D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003161")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003162")]
				[Cpp2IlInjected.Address(RVA = "0x2943160", Offset = "0x2941B60", VA = "0x182943160", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003163")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Ingredient other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003164")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003165")]
				[Cpp2IlInjected.Address(RVA = "0x2943350", Offset = "0x2941D50", VA = "0x182943350", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003166")]
				[Cpp2IlInjected.Address(RVA = "0x2943410", Offset = "0x2941E10", VA = "0x182943410", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003167")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000409")]
			public sealed class AppearWhenData : IMessage<AppearWhenData>, IMessage, IEquatable<AppearWhenData>, IDeepCloneable<AppearWhenData>, IMessageFieldAccessor, IProtobufDefaultData, IDataValidation
			{
				[Cpp2IlInjected.Token(Token = "0x400161D")]
				private static readonly MessageParser<AppearWhenData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400161E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400161F")]
				public const int HasMaterialFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001620")]
				private bool hasMaterial_;

				[Cpp2IlInjected.Token(Token = "0x4001621")]
				public const int AcquiredFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
				[Cpp2IlInjected.Token(Token = "0x4001622")]
				private bool acquired_;

				[Cpp2IlInjected.Token(Token = "0x4001623")]
				public const int ConditionsMeetFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
				[Cpp2IlInjected.Token(Token = "0x4001624")]
				private bool conditionsMeet_;

				[Cpp2IlInjected.Token(Token = "0x4001625")]
				public const int ConditionsFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001626")]
				private ConditionsList conditions_;

				[Cpp2IlInjected.Token(Token = "0x17000CB0")]
				[DebuggerNonUserCode]
				public static MessageParser<AppearWhenData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600316D")]
					[Cpp2IlInjected.Address(RVA = "0x29380F0", Offset = "0x2936AF0", VA = "0x1829380F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CB1")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600316E")]
					[Cpp2IlInjected.Address(RVA = "0x2938070", Offset = "0x2936A70", VA = "0x182938070")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CB2")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600316F")]
					[Cpp2IlInjected.Address(RVA = "0x2938150", Offset = "0x2936B50", VA = "0x182938150", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CB3")]
				[DebuggerNonUserCode]
				public bool HasMaterial
				{
					[Cpp2IlInjected.Token(Token = "0x6003174")]
					[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6003175")]
					[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CB4")]
				[DebuggerNonUserCode]
				public bool Acquired
				{
					[Cpp2IlInjected.Token(Token = "0x6003176")]
					[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6003177")]
					[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CB5")]
				[DebuggerNonUserCode]
				public bool ConditionsMeet
				{
					[Cpp2IlInjected.Token(Token = "0x6003178")]
					[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6003179")]
					[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000CB6")]
				[DebuggerNonUserCode]
				public ConditionsList Conditions
				{
					[Cpp2IlInjected.Token(Token = "0x600317A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600317B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003170")]
				[Cpp2IlInjected.Address(RVA = "0x2938000", Offset = "0x2936A00", VA = "0x182938000")]
				[DebuggerNonUserCode]
				public AppearWhenData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003171")]
				[Cpp2IlInjected.Address(RVA = "0x2937B00", Offset = "0x2936500", VA = "0x182937B00")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003172")]
				[Cpp2IlInjected.Address(RVA = "0x2937F20", Offset = "0x2936920", VA = "0x182937F20")]
				[DebuggerNonUserCode]
				public AppearWhenData(AppearWhenData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003173")]
				[Cpp2IlInjected.Address(RVA = "0x29373F0", Offset = "0x2935DF0", VA = "0x1829373F0", Slot = "10")]
				[DebuggerNonUserCode]
				public AppearWhenData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600317C")]
				[Cpp2IlInjected.Address(RVA = "0x2937600", Offset = "0x2936000", VA = "0x182937600", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600317D")]
				[Cpp2IlInjected.Address(RVA = "0x29376D0", Offset = "0x29360D0", VA = "0x1829376D0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(AppearWhenData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600317E")]
				[Cpp2IlInjected.Address(RVA = "0x2937830", Offset = "0x2936230", VA = "0x182937830", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600317F")]
				[Cpp2IlInjected.Address(RVA = "0x2937CD0", Offset = "0x29366D0", VA = "0x182937CD0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003180")]
				[Cpp2IlInjected.Address(RVA = "0x2937D30", Offset = "0x2936730", VA = "0x182937D30", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003181")]
				[Cpp2IlInjected.Address(RVA = "0x29372F0", Offset = "0x2935CF0", VA = "0x1829372F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003182")]
				[Cpp2IlInjected.Address(RVA = "0x29378F0", Offset = "0x29362F0", VA = "0x1829378F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(AppearWhenData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003183")]
				[Cpp2IlInjected.Address(RVA = "0x29379E0", Offset = "0x29363E0", VA = "0x1829379E0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003184")]
				[Cpp2IlInjected.Address(RVA = "0x2937750", Offset = "0x2936150", VA = "0x182937750", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003185")]
				[Cpp2IlInjected.Address(RVA = "0x2937B60", Offset = "0x2936560", VA = "0x182937B60", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003186")]
				[Cpp2IlInjected.Address(RVA = "0x29373B0", Offset = "0x2935DB0", VA = "0x1829373B0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003187")]
				[Cpp2IlInjected.Address(RVA = "0x16260C0", Offset = "0x1624AC0", VA = "0x1816260C0", Slot = "14")]
				void IProtobufDefaultData.SetDefaultData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003188")]
				[Cpp2IlInjected.Address(RVA = "0x2937500", Offset = "0x2935F00", VA = "0x182937500", Slot = "15")]
				public void DataValidation(DataValidation.Context context)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40015F6")]
		private static readonly MessageParser<CraftingRecipeItemData> _parser = (MessageParser<CraftingRecipeItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CraftingRecipeItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015F7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40015F8")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015F9")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40015FA")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015FB")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015FC")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40015FD")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40015FE")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40015FF")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001600")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001601")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001602")]
		public const int ResultFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001603")]
		private Types.ResultInstance result_;

		[Cpp2IlInjected.Token(Token = "0x4001604")]
		public const int IngredientsFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4001605")]
		private static readonly FieldCodec<Types.Ingredient> _repeated_ingredients_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001606")]
		private readonly RepeatedField<Types.Ingredient> ingredients_ = (RepeatedField<Types.Ingredient>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001607")]
		public const int RecipeTypeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001608")]
		private int recipeType_;

		[Cpp2IlInjected.Token(Token = "0x4001609")]
		public const int AppearWhenFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400160A")]
		private Types.AppearWhenData appearWhen_;

		[Cpp2IlInjected.Token(Token = "0x400160B")]
		public const int ConsummableOverrideItemIDFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400160C")]
		private int consummableOverrideItemID_;

		[Cpp2IlInjected.Token(Token = "0x17000C8F")]
		[DebuggerNonUserCode]
		public static MessageParser<CraftingRecipeItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60030FF")]
			[Cpp2IlInjected.Address(RVA = "0x32886D0", Offset = "0x32870D0", VA = "0x1832886D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C90")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003100")]
			[Cpp2IlInjected.Address(RVA = "0x3288450", Offset = "0x3286E50", VA = "0x183288450")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C91")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003101")]
			[Cpp2IlInjected.Address(RVA = "0x3288730", Offset = "0x3287130", VA = "0x183288730", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C92")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003106")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003107")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C93")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003108")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003109")]
			[Cpp2IlInjected.Address(RVA = "0x3288920", Offset = "0x3287320", VA = "0x183288920")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C94")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600310A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600310B")]
			[Cpp2IlInjected.Address(RVA = "0x3288840", Offset = "0x3287240", VA = "0x183288840")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C95")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600310C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600310D")]
			[Cpp2IlInjected.Address(RVA = "0x32888B0", Offset = "0x32872B0", VA = "0x1832888B0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C96")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600310E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600310F")]
			[Cpp2IlInjected.Address(RVA = "0x3288990", Offset = "0x3287390", VA = "0x183288990")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C97")]
		[DebuggerNonUserCode]
		public Types.ResultInstance Result
		{
			[Cpp2IlInjected.Token(Token = "0x6003110")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return result_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003111")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				result_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C98")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.Ingredient> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x6003112")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return ingredients_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C99")]
		[DebuggerNonUserCode]
		public int RecipeType
		{
			[Cpp2IlInjected.Token(Token = "0x6003113")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return recipeType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003114")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				recipeType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9A")]
		[DebuggerNonUserCode]
		public Types.AppearWhenData AppearWhen
		{
			[Cpp2IlInjected.Token(Token = "0x6003115")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return appearWhen_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003116")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				appearWhen_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9B")]
		[DebuggerNonUserCode]
		public int ConsummableOverrideItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6003117")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return consummableOverrideItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003118")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				consummableOverrideItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9C")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6003124")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9D")]
		Item IActivityDataItemData.ResultItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003125")]
			[Cpp2IlInjected.Address(RVA = "0x32862C0", Offset = "0x3284CC0", VA = "0x1832862C0", Slot = "27")]
			get
			{
				//Discarded unreachable code: IL_000c
				return result_.Item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9E")]
		public Item? ConsummableOverrideItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003126")]
			[Cpp2IlInjected.Address(RVA = "0x3288380", Offset = "0x3286D80", VA = "0x183288380", Slot = "26")]
			get
			{
				int num = consummableOverrideItemID_;
				long num2 = Convert.ToInt64((uint)consummableOverrideItemID_);
				int num3 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C9F")]
		public bool IsConditionAlwaysFalse
		{
			[Cpp2IlInjected.Token(Token = "0x6003128")]
			[Cpp2IlInjected.Address(RVA = "0x3288580", Offset = "0x3286F80", VA = "0x183288580")]
			get
			{
				Types.AppearWhenData appearWhenData = appearWhen_;
				if (appearWhenData.conditionsMeet_ && ((RepeatedField<T>)(object)appearWhenData.conditions_.conditions_).Count == 1)
				{
					RepeatedField<ConditionOneOf> conditions_ = appearWhen_.conditions_.conditions_;
					int index = 0;
					return ((ConditionOneOf)((RepeatedField<T>)(object)conditions_)[index]).conditionsCase_ == ConditionOneOf.ConditionsOneofCase.AlwaysFalse;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CA0")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600312B")]
			[Cpp2IlInjected.Address(RVA = "0x3288520", Offset = "0x3286F20", VA = "0x183288520", Slot = "23")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CA1")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x600312C")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "24")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CA2")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x600312D")]
			[Cpp2IlInjected.Address(RVA = "0x3288630", Offset = "0x3287030", VA = "0x183288630", Slot = "25")]
			get
			{
				//Discarded unreachable code: IL_0014
				List<Item> result = (List<Item>)(object)new List<T>();
				Item item = result_.Item;
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003102")]
		[Cpp2IlInjected.Address(RVA = "0x3288230", Offset = "0x3286C30", VA = "0x183288230")]
		[DebuggerNonUserCode]
		public CraftingRecipeItemData()
		{
			Types.ResultInstance resultInstance = (result_ = new Types.ResultInstance());
			Types.AppearWhenData appearWhenData = (appearWhen_ = new Types.AppearWhenData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003103")]
		[Cpp2IlInjected.Address(RVA = "0x3287480", Offset = "0x3285E80", VA = "0x183287480")]
		private void OnConstruction()
		{
			Types.ResultInstance resultInstance = (result_ = new Types.ResultInstance());
			Types.AppearWhenData appearWhenData = (appearWhen_ = new Types.AppearWhenData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003104")]
		[Cpp2IlInjected.Address(RVA = "0x3287FB0", Offset = "0x32869B0", VA = "0x183287FB0")]
		[DebuggerNonUserCode]
		public CraftingRecipeItemData(CraftingRecipeItemData other)
		{
			//IL_00c8: Expected O, but got I4
			Types.ResultInstance resultInstance = (result_ = new Types.ResultInstance());
			Types.AppearWhenData appearWhenData = (appearWhen_ = new Types.AppearWhenData());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			Types.ResultInstance resultInstance2 = other.result_;
			int num2 = 0;
			if (resultInstance2 != null)
			{
				Types.ResultInstance resultInstance3 = resultInstance2.Clone();
			}
			result_ = (Types.ResultInstance)num2;
			RepeatedField<Types.Ingredient> repeatedField = (ingredients_ = (RepeatedField<Types.Ingredient>)(object)((RepeatedField<T>)(object)other.ingredients_).Clone());
			int num3 = (recipeType_ = other.recipeType_);
			Types.AppearWhenData appearWhenData2 = other.appearWhen_;
			Types.AppearWhenData appearWhenData3 = default(Types.AppearWhenData);
			if (appearWhenData2 != null)
			{
				appearWhenData3 = appearWhenData2.Clone();
			}
			appearWhen_ = appearWhenData3;
			int num4 = (consummableOverrideItemID_ = other.consummableOverrideItemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003105")]
		[Cpp2IlInjected.Address(RVA = "0x3286260", Offset = "0x3284C60", VA = "0x183286260", Slot = "10")]
		[DebuggerNonUserCode]
		public CraftingRecipeItemData Clone()
		{
			return new CraftingRecipeItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003119")]
		[Cpp2IlInjected.Address(RVA = "0x3286600", Offset = "0x3285000", VA = "0x183286600", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(CraftingRecipeItemData).TypeHandle)
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
								if (!flag4 && object.Equals(result_, other))
								{
									RepeatedField<Types.Ingredient> repeatedField = ingredients_;
									bool flag5 = default(bool);
									if (flag5 && recipeType_ == (flag5 ? 1 : 0))
									{
										bool flag6 = object.Equals(appearWhen_, other);
										if (flag6 && consummableOverrideItemID_ == (flag6 ? 1 : 0))
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

		[Cpp2IlInjected.Token(Token = "0x600311A")]
		[Cpp2IlInjected.Address(RVA = "0x3286780", Offset = "0x3285180", VA = "0x183286780", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CraftingRecipeItemData other)
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
									Types.ResultInstance objB = other.result_;
									if (object.Equals(result_, objB))
									{
										RepeatedField<Types.Ingredient> repeatedField = ingredients_;
										RepeatedField<Types.Ingredient> repeatedField2 = other.ingredients_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											int num2 = other.recipeType_;
											if (recipeType_ == num2)
											{
												Types.AppearWhenData objB2 = other.appearWhen_;
												if (object.Equals(appearWhen_, objB2))
												{
													int num3 = other.consummableOverrideItemID_;
													if (consummableOverrideItemID_ == num3)
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
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600311B")]
		[Cpp2IlInjected.Address(RVA = "0x3286AE0", Offset = "0x32854E0", VA = "0x183286AE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00d1
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
			Types.ResultInstance resultInstance = result_;
			if (resultInstance != null)
			{
				int hashCode5 = resultInstance.GetHashCode();
			}
			int hashCode6 = ((RepeatedField<T>)(object)ingredients_).GetHashCode();
			if (recipeType_ != 0)
			{
			}
			Types.AppearWhenData appearWhenData = appearWhen_;
			if (appearWhenData != null)
			{
				int hashCode7 = appearWhenData.GetHashCode();
			}
			if (consummableOverrideItemID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600311C")]
		[Cpp2IlInjected.Address(RVA = "0x3287860", Offset = "0x3286260", VA = "0x183287860", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600311D")]
		[Cpp2IlInjected.Address(RVA = "0x3287B70", Offset = "0x3286570", VA = "0x183287B70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0120
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
			if ((long)result_ != 0)
			{
				Types.ResultInstance value6 = result_;
				output.WriteMessage(value6);
			}
			RepeatedField<Types.Ingredient> repeatedField = ingredients_;
			FieldCodec<Types.Ingredient> repeated_ingredients_codec = _repeated_ingredients_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_ingredients_codec);
			if (recipeType_ != 0)
			{
				int value7 = recipeType_;
				output.WriteInt32(value7);
			}
			if ((long)appearWhen_ != 0)
			{
				Types.AppearWhenData value8 = appearWhen_;
				output.WriteMessage(value8);
			}
			if (consummableOverrideItemID_ != 0)
			{
				int value9 = consummableOverrideItemID_;
				output.WriteInt32(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600311E")]
		[Cpp2IlInjected.Address(RVA = "0x3285D80", Offset = "0x3284780", VA = "0x183285D80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0169
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
			Types.ResultInstance resultInstance = result_;
			if (resultInstance != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(resultInstance);
				num8++;
				num2 += num8;
			}
			RepeatedField<Types.Ingredient> repeatedField = ingredients_;
			FieldCodec<Types.Ingredient> repeated_ingredients_codec = _repeated_ingredients_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_ingredients_codec);
			int num10 = recipeType_;
			num2 += num9;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			Types.AppearWhenData appearWhenData = appearWhen_;
			if (appearWhenData != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(appearWhenData);
				num12++;
				num2 += num12;
			}
			int num13 = consummableOverrideItemID_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				num2 += num15;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600311F")]
		[Cpp2IlInjected.Address(RVA = "0x3287000", Offset = "0x3285A00", VA = "0x183287000", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CraftingRecipeItemData other)
		{
			//Discarded unreachable code: IL_0153
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
			if ((long)other.result_ != 0)
			{
				Types.ResultInstance resultInstance2 = default(Types.ResultInstance);
				if (result_ == null)
				{
					Types.ResultInstance resultInstance = (result_ = new Types.ResultInstance());
					resultInstance2 = result_;
				}
				Types.ResultInstance other2 = other.result_;
				resultInstance2.MergeFrom(other2);
			}
			RepeatedField<Types.Ingredient> repeatedField = ingredients_;
			RepeatedField<Types.Ingredient> repeatedField2 = other.ingredients_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num2 = other.recipeType_;
			if (num2 != 0)
			{
				recipeType_ = num2;
			}
			if ((long)other.appearWhen_ != 0)
			{
				Types.AppearWhenData appearWhenData2 = default(Types.AppearWhenData);
				if (appearWhen_ == null)
				{
					Types.AppearWhenData appearWhenData = (appearWhen_ = new Types.AppearWhenData());
					appearWhenData2 = appearWhen_;
				}
				Types.AppearWhenData other3 = other.appearWhen_;
				appearWhenData2.MergeFrom(other3);
			}
			int num3 = other.consummableOverrideItemID_;
			if (num3 != 0)
			{
				consummableOverrideItemID_ = num3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003120")]
		[Cpp2IlInjected.Address(RVA = "0x32871F0", Offset = "0x3285BF0", VA = "0x1832871F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0158
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 58)
				{
					if (num == 64)
					{
						int num2 = (recipeType_ = input.ReadInt32());
					}
					Types.AppearWhenData appearWhenData = default(Types.AppearWhenData);
					if (num == 74)
					{
						Types.AppearWhenData builder = default(Types.AppearWhenData);
						if (appearWhen_ == null)
						{
							appearWhenData = (appearWhen_ = new Types.AppearWhenData());
							builder = appearWhen_;
						}
						input.ReadMessage(builder);
					}
					if ((long)appearWhenData != 96)
					{
						goto IL_0141;
					}
					int num3 = (consummableOverrideItemID_ = input.ReadInt32());
				}
				Types.ResultInstance resultInstance = default(Types.ResultInstance);
				if (num == 50)
				{
					Types.ResultInstance builder2 = default(Types.ResultInstance);
					if (result_ == null)
					{
						resultInstance = (result_ = new Types.ResultInstance());
						builder2 = result_;
					}
					input.ReadMessage(builder2);
				}
				if ((long)resultInstance != 58)
				{
					goto IL_0141;
				}
				RepeatedField<Types.Ingredient> repeatedField = ingredients_;
				FieldCodec<Types.Ingredient> repeated_ingredients_codec = _repeated_ingredients_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_ingredients_codec);
			}
			string text6 = default(string);
			if ((int)num > 18)
			{
				string text2 = default(string);
				if (num == 26)
				{
					text2 = (DisplayName = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 34)
				{
					text4 = (IconAddress = input.ReadString());
				}
				if ((long)text4 != 42)
				{
					goto IL_0141;
				}
				text6 = (PrefabAddress = input.ReadString());
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
			goto IL_0141;
			IL_0141:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003121")]
		[Cpp2IlInjected.Address(RVA = "0x3286970", Offset = "0x3285370", VA = "0x183286970", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003122")]
		[Cpp2IlInjected.Address(RVA = "0x3287510", Offset = "0x3285F10", VA = "0x183287510", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0024, IL_0025, IL_002d, IL_0033, IL_0039, IL_003f, IL_0045, IL_004b
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			if (fieldNumber - 1 <= 11)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003123")]
		[Cpp2IlInjected.Address(RVA = "0x32860D0", Offset = "0x3284AD0", VA = "0x1832860D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0019
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 11)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003127")]
		[Cpp2IlInjected.Address(RVA = "0x3286040", Offset = "0x3284A40", VA = "0x183286040")]
		public bool CanBeGiven(in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] RewardGenerationParameters parameters)
		{
			//Discarded unreachable code: IL_001a
			if (!appearWhen_.acquired_)
			{
				int num = 0;
			}
			return playerProfile.Section == null;
		}

		[Cpp2IlInjected.Token(Token = "0x6003129")]
		[Cpp2IlInjected.Address(RVA = "0x3286DE0", Offset = "0x32857E0", VA = "0x183286DE0")]
		public bool IsRestricted(IProfilePlayer profile)
		{
			//Discarded unreachable code: IL_001e
			do
			{
				if (IsConditionAlwaysFalse)
				{
					return true;
				}
			}
			while (appearWhen_.acquired_);
			return 0 == 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600312A")]
		[Cpp2IlInjected.Address(RVA = "0x3286260", Offset = "0x3284C60", VA = "0x183286260", Slot = "20")]
		IItemData IItemData.Clone()
		{
			CraftingRecipeItemData craftingRecipeItemData = new CraftingRecipeItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600312E")]
		[Cpp2IlInjected.Address(RVA = "0x32868C0", Offset = "0x32852C0", VA = "0x1832868C0")]
		public List<CraftingRecipeItemData> GetChildrenRecipes()
		{
			return (List<CraftingRecipeItemData>)(object)new List<T>();
		}

		[Cpp2IlInjected.Token(Token = "0x600312F")]
		[Cpp2IlInjected.Address(RVA = "0x3286C60", Offset = "0x3285660", VA = "0x183286C60")]
		public static IEnumerable<CraftingRecipeItemData> GetRecipesWhoCraft(Item craftedItem)
		{
			//Discarded unreachable code: IL_003c
			//IL_0014: Expected O, but got I4
			int itemID = craftedItem.ItemID;
			Item craftedItem2 = (Item)itemID;
			IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<CraftingRecipeItemData, ActivityDataItemType>(ItemType.ActivityData, ActivityDataItemType.CraftingRecipe);
			Func<CraftingRecipeItemData, bool> func = (Func<CraftingRecipeItemData, bool>)(object)(Func<T, TResult>)delegate(CraftingRecipeItemData x)
			{
				Item item = x.result_.Item;
				throw new NullReferenceException();
			};
			return (IEnumerable<CraftingRecipeItemData>)Enumerable.Where<CraftingRecipeItemData>(allByType, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6003130")]
		[Cpp2IlInjected.Address(RVA = "0x32862E0", Offset = "0x3284CE0", VA = "0x1832862E0", Slot = "22")]
		void IDataValidation.DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00a2
			if (((RepeatedField<T>)(object)ingredients_).Count != 0)
			{
				RepeatedField<Types.Ingredient> repeatedField = ingredients_;
				Func<Types.Ingredient, Item> _003C_003E9__93_ = _003C_003Ec._003C_003E9__93_0;
				if (_003C_003E9__93_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.Ingredient x) => x.Item);
				}
				int num = Enumerable.Count<Item>(Enumerable.Distinct<Item>(Enumerable.Select<Types.Ingredient, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__93_)));
				int count = ((RepeatedField<T>)(object)ingredients_).Count;
				if (num == count)
				{
					goto IL_0066;
				}
			}
			context.AddInvalidMemberError("A crafting recipe must have at least 1 ingredient", "Ingredients");
			goto IL_0066;
			IL_0066:
			Types.ResultInstance resultInstance = result_;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = resultInstance.Item;
			IItemData itemData = default(IItemData);
			if (itemData.IsMissionItem() && !IsConditionAlwaysFalse)
			{
				context.AddInvalidMemberError("Result is a mission item, Conditions must be set to AlwaysFalse", "Conditions");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003131")]
		[Cpp2IlInjected.Address(RVA = "0x3286E80", Offset = "0x3285880", VA = "0x183286E80")]
		private static bool IsValidIngredientItem(Item item)
		{
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.ActivityItem)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				bool flag = default(bool);
				ActivityItemType activityItemType = default(ActivityItemType);
				if (flag && activityItemType != ActivityItemType.LootPresent)
				{
					return activityItemType != ActivityItemType.Consummable;
				}
			}
			else
			{
				if (itemType == ItemType.Furniture)
				{
					FurnitureItemType furnitureItemType = default(FurnitureItemType);
					if (furnitureItemType <= FurnitureItemType.GroundAlteration)
					{
						return true;
					}
					return 1L == 7L;
				}
				bool flag2 = default(bool);
				while (flag2)
				{
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003132")]
		[Cpp2IlInjected.Address(RVA = "0x3287DE0", Offset = "0x32867E0", VA = "0x183287DE0")]
		static CraftingRecipeItemData()
		{
			MessageParser<Types.Ingredient> parser = Types.Ingredient._parser;
			uint num = default(uint);
			_parser = (MessageParser<CraftingRecipeItemData>)(object)FieldCodec.ForMessage<Types.Ingredient>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003133")]
		[Cpp2IlInjected.Address(RVA = "0x3286040", Offset = "0x3284A40", VA = "0x183286040", Slot = "21")]
		bool IRewardGenerationCondition.CanBeGiven(in PlayerProfile playerProfile, in WorldProfile worldProfile, RewardGenerationParameters parameters)
		{
			//Discarded unreachable code: IL_001a
			if (!appearWhen_.acquired_)
			{
				int num = 0;
			}
			return playerProfile.Section == null;
		}
	}
}
