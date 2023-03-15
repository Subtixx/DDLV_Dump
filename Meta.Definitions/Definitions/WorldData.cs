using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public sealed class WorldData : IMessage<WorldData>, IMessage, IEquatable<WorldData>, IDeepCloneable<WorldData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000116")]
			public sealed class World : IMessage<World>, IMessage, IEquatable<World>, IDeepCloneable<World>, IMessageFieldAccessor, IDataValidation
			{
				[Cpp2IlInjected.Token(Token = "0x400051A")]
				private static readonly MessageParser<World> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400051B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400051C")]
				public const int WorldNameFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400051D")]
				private string worldName_;

				[Cpp2IlInjected.Token(Token = "0x400051E")]
				public const int UnlockWithFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400051F")]
				private int unlockWith_;

				[Cpp2IlInjected.Token(Token = "0x4000520")]
				public const int UnlockAtLevelFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000521")]
				private int unlockAtLevel_;

				[Cpp2IlInjected.Token(Token = "0x4000522")]
				public const int UnlockCharacterCountFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000523")]
				private int unlockCharacterCount_;

				[Cpp2IlInjected.Token(Token = "0x4000524")]
				public const int ForceUnlockWithDialogueFlagFieldNumber = 11;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000525")]
				private int forceUnlockWithDialogueFlag_;

				[Cpp2IlInjected.Token(Token = "0x4000526")]
				public const int UnlockCostFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x4000527")]
				private static readonly FieldCodec<CurrencyCost> _repeated_unlockCost_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000528")]
				private readonly RepeatedField<CurrencyCost> unlockCost_;

				[Cpp2IlInjected.Token(Token = "0x4000529")]
				public const int ManaCostFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400052A")]
				private int manaCost_;

				[Cpp2IlInjected.Token(Token = "0x400052B")]
				public const int UniverseTagFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
				[Cpp2IlInjected.Token(Token = "0x400052C")]
				private int universeTag_;

				[Cpp2IlInjected.Token(Token = "0x400052D")]
				public const int DefaultGridLayoutPathFieldNumber = 8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400052E")]
				private string defaultGridLayoutPath_;

				[Cpp2IlInjected.Token(Token = "0x400052F")]
				public const int SceneIdFieldNumber = 9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000530")]
				private int sceneId_;

				[Cpp2IlInjected.Token(Token = "0x4000531")]
				public const int CharactersFieldNumber = 10;

				[Cpp2IlInjected.Token(Token = "0x4000532")]
				private static readonly FieldCodec<int> _repeated_characters_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000533")]
				private readonly RepeatedField<int> characters_;

				[Cpp2IlInjected.Token(Token = "0x4000534")]
				public const int DebugFieldNumber = 12;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000535")]
				private bool debug_;

				[Cpp2IlInjected.Token(Token = "0x170002C3")]
				[DebuggerNonUserCode]
				public static MessageParser<World> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6000B79")]
					[Cpp2IlInjected.Address(RVA = "0x2382330", Offset = "0x2380D30", VA = "0x182382330")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002C4")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000B7A")]
					[Cpp2IlInjected.Address(RVA = "0x23822B0", Offset = "0x2380CB0", VA = "0x1823822B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002C5")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6000B7B")]
					[Cpp2IlInjected.Address(RVA = "0x23823F0", Offset = "0x2380DF0", VA = "0x1823823F0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002C6")]
				[DebuggerNonUserCode]
				public string WorldName
				{
					[Cpp2IlInjected.Token(Token = "0x6000B7F")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000B80")]
					[Cpp2IlInjected.Address(RVA = "0x2382520", Offset = "0x2380F20", VA = "0x182382520")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002C7")]
				[DebuggerNonUserCode]
				public int UnlockWith
				{
					[Cpp2IlInjected.Token(Token = "0x6000B81")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B82")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002C8")]
				[DebuggerNonUserCode]
				public int UnlockAtLevel
				{
					[Cpp2IlInjected.Token(Token = "0x6000B83")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B84")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002C9")]
				[DebuggerNonUserCode]
				public int UnlockCharacterCount
				{
					[Cpp2IlInjected.Token(Token = "0x6000B85")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B86")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002CA")]
				[DebuggerNonUserCode]
				public int ForceUnlockWithDialogueFlag
				{
					[Cpp2IlInjected.Token(Token = "0x6000B87")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B88")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002CB")]
				[DebuggerNonUserCode]
				public RepeatedField<CurrencyCost> UnlockCost
				{
					[Cpp2IlInjected.Token(Token = "0x6000B89")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002CC")]
				[DebuggerNonUserCode]
				public int ManaCost
				{
					[Cpp2IlInjected.Token(Token = "0x6000B8A")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B8B")]
					[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002CD")]
				[DebuggerNonUserCode]
				public int UniverseTag
				{
					[Cpp2IlInjected.Token(Token = "0x6000B8C")]
					[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B8D")]
					[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002CE")]
				[DebuggerNonUserCode]
				public string DefaultGridLayoutPath
				{
					[Cpp2IlInjected.Token(Token = "0x6000B8E")]
					[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000B8F")]
					[Cpp2IlInjected.Address(RVA = "0x23824B0", Offset = "0x2380EB0", VA = "0x1823824B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002CF")]
				[DebuggerNonUserCode]
				public int SceneId
				{
					[Cpp2IlInjected.Token(Token = "0x6000B90")]
					[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B91")]
					[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002D0")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Characters
				{
					[Cpp2IlInjected.Token(Token = "0x6000B92")]
					[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002D1")]
				[DebuggerNonUserCode]
				public bool Debug
				{
					[Cpp2IlInjected.Token(Token = "0x6000B93")]
					[Cpp2IlInjected.Address(RVA = "0xA5F820", Offset = "0xA5E220", VA = "0x180A5F820")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6000B94")]
					[Cpp2IlInjected.Address(RVA = "0xE3A650", Offset = "0xE39050", VA = "0x180E3A650")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170002D2")]
				public Item UniverseTagItem
				{
					[Cpp2IlInjected.Token(Token = "0x6000BA0")]
					[Cpp2IlInjected.Address(RVA = "0x2382390", Offset = "0x2380D90", VA = "0x182382390")]
					get
					{
						return default(Item);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000B7C")]
				[Cpp2IlInjected.Address(RVA = "0x23820A0", Offset = "0x2380AA0", VA = "0x1823820A0")]
				[DebuggerNonUserCode]
				public World()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B7D")]
				[Cpp2IlInjected.Address(RVA = "0x2382190", Offset = "0x2380B90", VA = "0x182382190")]
				[DebuggerNonUserCode]
				public World(World other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B7E")]
				[Cpp2IlInjected.Address(RVA = "0x2380A20", Offset = "0x237F420", VA = "0x182380A20", Slot = "10")]
				[DebuggerNonUserCode]
				public World Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B95")]
				[Cpp2IlInjected.Address(RVA = "0x2380DC0", Offset = "0x237F7C0", VA = "0x182380DC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B96")]
				[Cpp2IlInjected.Address(RVA = "0x2380F50", Offset = "0x237F950", VA = "0x182380F50", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(World other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B97")]
				[Cpp2IlInjected.Address(RVA = "0x2381220", Offset = "0x237FC20", VA = "0x182381220", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B98")]
				[Cpp2IlInjected.Address(RVA = "0x2381B70", Offset = "0x2380570", VA = "0x182381B70", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B99")]
				[Cpp2IlInjected.Address(RVA = "0x2381BD0", Offset = "0x23805D0", VA = "0x182381BD0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9A")]
				[Cpp2IlInjected.Address(RVA = "0x2380370", Offset = "0x237ED70", VA = "0x182380370", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9B")]
				[Cpp2IlInjected.Address(RVA = "0x23813C0", Offset = "0x237FDC0", VA = "0x1823813C0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(World other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9C")]
				[Cpp2IlInjected.Address(RVA = "0x2381500", Offset = "0x237FF00", VA = "0x182381500", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9D")]
				[Cpp2IlInjected.Address(RVA = "0x2381090", Offset = "0x237FA90", VA = "0x182381090", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9E")]
				[Cpp2IlInjected.Address(RVA = "0x2381790", Offset = "0x2380190", VA = "0x182381790", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B9F")]
				[Cpp2IlInjected.Address(RVA = "0x2380890", Offset = "0x237F290", VA = "0x182380890", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BA1")]
				[Cpp2IlInjected.Address(RVA = "0x2380670", Offset = "0x237F070", VA = "0x182380670")]
				public bool CanEnter(IProfile profile)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BA2")]
				[Cpp2IlInjected.Address(RVA = "0x2380B60", Offset = "0x237F560", VA = "0x182380B60", Slot = "14")]
				void IDataValidation.DataValidation(DataValidation.Context context)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly MessageParser<WorldData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public const int WorldsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private static readonly FieldCodec<Types.World> _repeated_worlds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private readonly RepeatedField<Types.World> worlds_ = (RepeatedField<Types.World>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170002BF")]
		[DebuggerNonUserCode]
		public static MessageParser<WorldData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000B65")]
			[Cpp2IlInjected.Address(RVA = "0x17D0530", Offset = "0x17CEF30", VA = "0x1817D0530")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B66")]
			[Cpp2IlInjected.Address(RVA = "0x17D0460", Offset = "0x17CEE60", VA = "0x1817D0460")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x17D0590", Offset = "0x17CEF90", VA = "0x1817D0590", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C2")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.World> Worlds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return worlds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0x17D02E0", Offset = "0x17CECE0", VA = "0x1817D02E0")]
		[DebuggerNonUserCode]
		public WorldData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x17D0360", Offset = "0x17CED60", VA = "0x1817D0360")]
		[DebuggerNonUserCode]
		public WorldData(WorldData other)
		{
			RepeatedField<Types.World> repeatedField = (worlds_ = (RepeatedField<Types.World>)(object)((RepeatedField<T>)(object)other.worlds_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x17CFA20", Offset = "0x17CE420", VA = "0x1817CFA20", Slot = "10")]
		[DebuggerNonUserCode]
		public WorldData Clone()
		{
			//Discarded unreachable code: IL_003b
			WorldData worldData = new WorldData();
			RepeatedField<Types.World> repeatedField = (worldData.worlds_ = (RepeatedField<Types.World>)(object)new RepeatedField<T>());
			RepeatedField<Types.World> repeatedField2 = (worldData.worlds_ = (RepeatedField<Types.World>)(object)((RepeatedField<T>)(object)worlds_).Clone());
			UnknownFieldSet unknownFieldSet = (worldData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return worldData;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x17CFBE0", Offset = "0x17CE5E0", VA = "0x1817CFBE0", Slot = "0")]
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
				RepeatedField<Types.World> repeatedField = worlds_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x17CFB50", Offset = "0x17CE550", VA = "0x1817CFB50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(WorldData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.World> repeatedField = worlds_;
				RepeatedField<Types.World> repeatedField2 = other.worlds_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)worlds_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x17CFFF0", Offset = "0x17CE9F0", VA = "0x1817CFFF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x17D0050", Offset = "0x17CEA50", VA = "0x1817D0050", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Types.World> repeatedField = worlds_;
			FieldCodec<Types.World> repeated_worlds_codec = _repeated_worlds_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_worlds_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x17CF910", Offset = "0x17CE310", VA = "0x1817CF910", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Types.World> repeatedField = worlds_;
			FieldCodec<Types.World> repeated_worlds_codec = _repeated_worlds_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_worlds_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x17CFE30", Offset = "0x17CE830", VA = "0x1817CFE30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(WorldData other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Types.World> repeatedField = worlds_;
				RepeatedField<Types.World> repeatedField2 = other.worlds_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x17CFD40", Offset = "0x17CE740", VA = "0x1817CFD40", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.World> repeatedField = worlds_;
					FieldCodec<Types.World> repeated_worlds_codec = _repeated_worlds_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_worlds_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x17CFCC0", Offset = "0x17CE6C0", VA = "0x1817CFCC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.World> repeatedField = worlds_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x17CFEB0", Offset = "0x17CE8B0", VA = "0x1817CFEB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x17CF9C0", Offset = "0x17CE3C0", VA = "0x1817CF9C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Types.World> repeatedField = worlds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x17CFF10", Offset = "0x17CE910", VA = "0x1817CFF10")]
		public static bool StoryCharacterOnly(Item item)
		{
			//Discarded unreachable code: IL_0014
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			CharacterItemData characterItemData = default(CharacterItemData);
			if (characterItemData == null)
			{
			}
			return characterItemData.unlockCondition_ == CharacterUnlockCondition.StoryReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x17D0110", Offset = "0x17CEB10", VA = "0x1817D0110")]
		static WorldData()
		{
			Func<WorldData> func = default(Func<WorldData>);
			_parser = (MessageParser<WorldData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.World> parser = Types.World._parser;
			uint num = default(uint);
			_parser = (MessageParser<WorldData>)(object)FieldCodec.ForMessage<Types.World>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
