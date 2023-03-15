using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005BD")]
	public sealed class CollectionItemType : IMessage<CollectionItemType>, IMessage, IEquatable<CollectionItemType>, IDeepCloneable<CollectionItemType>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005BE")]
		public enum CollectionTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001F5B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001F5C")]
			CharacterUniverse = 2,
			[Cpp2IlInjected.Token(Token = "0x4001F5D")]
			Furniture = 3,
			[Cpp2IlInjected.Token(Token = "0x4001F5E")]
			Clothing = 4,
			[Cpp2IlInjected.Token(Token = "0x4001F5F")]
			Critter = 5,
			[Cpp2IlInjected.Token(Token = "0x4001F60")]
			ActivityItem = 6,
			[Cpp2IlInjected.Token(Token = "0x4001F61")]
			MemoryShard = 7,
			[Cpp2IlInjected.Token(Token = "0x4001F62")]
			Crafting = 8
		}

		[Cpp2IlInjected.Token(Token = "0x4001F4D")]
		private static readonly MessageParser<CollectionItemType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F4E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F4F")]
		public const int IgnoreFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F50")]
		private bool ignore_;

		[Cpp2IlInjected.Token(Token = "0x4001F51")]
		public const int CharacterUniverseFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001F52")]
		public const int FurnitureFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4001F53")]
		public const int ClothingFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4001F54")]
		public const int CritterFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001F55")]
		public const int ActivityItemFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4001F56")]
		public const int MemoryShardFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4001F57")]
		public const int CraftingFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F58")]
		private object collectionType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F59")]
		private CollectionTypeOneofCase collectionTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17001283")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionItemType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600479F")]
			[Cpp2IlInjected.Address(RVA = "0x3209800", Offset = "0x3208200", VA = "0x183209800")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001284")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047A0")]
			[Cpp2IlInjected.Address(RVA = "0x3209670", Offset = "0x3208070", VA = "0x183209670")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001285")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047A1")]
			[Cpp2IlInjected.Address(RVA = "0x3209860", Offset = "0x3208260", VA = "0x183209860", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001286")]
		[DebuggerNonUserCode]
		public bool Ignore
		{
			[Cpp2IlInjected.Token(Token = "0x60047A5")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return ignore_;
			}
			[Cpp2IlInjected.Token(Token = "0x60047A6")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				ignore_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001287")]
		[DebuggerNonUserCode]
		public int CharacterUniverse
		{
			[Cpp2IlInjected.Token(Token = "0x60047A7")]
			[Cpp2IlInjected.Address(RVA = "0x32094E0", Offset = "0x3207EE0", VA = "0x1832094E0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (collectionTypeCase_ == CollectionTypeOneofCase.CharacterUniverse)
				{
					object obj = collectionType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60047A8")]
			[Cpp2IlInjected.Address(RVA = "0x32099B0", Offset = "0x32083B0", VA = "0x1832099B0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				collectionType_ = typeof(int).TypeHandle;
				collectionTypeCase_ = CollectionTypeOneofCase.CharacterUniverse;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001288")]
		[DebuggerNonUserCode]
		public CollectionFurniture Furniture
		{
			[Cpp2IlInjected.Token(Token = "0x60047A9")]
			[Cpp2IlInjected.Address(RVA = "0x3209740", Offset = "0x3208140", VA = "0x183209740")]
			get
			{
				int num = 0;
				if (collectionTypeCase_ == CollectionTypeOneofCase.Furniture)
				{
					object obj = collectionType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60047AA")]
			[Cpp2IlInjected.Address(RVA = "0x24D4340", Offset = "0x24D2D40", VA = "0x1824D4340")]
			set
			{
				collectionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001289")]
		[DebuggerNonUserCode]
		public CollectionClothing Clothing
		{
			[Cpp2IlInjected.Token(Token = "0x60047AB")]
			[Cpp2IlInjected.Address(RVA = "0x3209550", Offset = "0x3207F50", VA = "0x183209550")]
			get
			{
				int num = 0;
				if (collectionTypeCase_ == CollectionTypeOneofCase.Clothing)
				{
					object obj = collectionType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60047AC")]
			[Cpp2IlInjected.Address(RVA = "0x24D4380", Offset = "0x24D2D80", VA = "0x1824D4380")]
			set
			{
				collectionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700128A")]
		[DebuggerNonUserCode]
		public CollectionTypeWithLocation Critter
		{
			[Cpp2IlInjected.Token(Token = "0x60047AD")]
			[Cpp2IlInjected.Address(RVA = "0x3209610", Offset = "0x3208010", VA = "0x183209610")]
			get
			{
				int num = 0;
				if (collectionTypeCase_ == CollectionTypeOneofCase.Critter)
				{
					object obj = collectionType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60047AE")]
			[Cpp2IlInjected.Address(RVA = "0x3209A60", Offset = "0x3208460", VA = "0x183209A60")]
			set
			{
				collectionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700128B")]
		[DebuggerNonUserCode]
		public CollectionActivity ActivityItem
		{
			[Cpp2IlInjected.Token(Token = "0x60047AF")]
			[Cpp2IlInjected.Address(RVA = "0x3209480", Offset = "0x3207E80", VA = "0x183209480")]
			get
			{
				int num = 0;
				if (collectionTypeCase_ == CollectionTypeOneofCase.ActivityItem)
				{
					object obj = collectionType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60047B0")]
			[Cpp2IlInjected.Address(RVA = "0x3209970", Offset = "0x3208370", VA = "0x183209970")]
			set
			{
				collectionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700128C")]
		[DebuggerNonUserCode]
		public CollectionMemoryShard MemoryShard
		{
			[Cpp2IlInjected.Token(Token = "0x60047B1")]
			[Cpp2IlInjected.Address(RVA = "0x32097A0", Offset = "0x32081A0", VA = "0x1832097A0")]
			get
			{
				int num = 0;
				if (collectionTypeCase_ == CollectionTypeOneofCase.MemoryShard)
				{
					object obj = collectionType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60047B2")]
			[Cpp2IlInjected.Address(RVA = "0x3209AA0", Offset = "0x32084A0", VA = "0x183209AA0")]
			set
			{
				collectionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700128D")]
		[DebuggerNonUserCode]
		public CollectionCrafting Crafting
		{
			[Cpp2IlInjected.Token(Token = "0x60047B3")]
			[Cpp2IlInjected.Address(RVA = "0x32095B0", Offset = "0x3207FB0", VA = "0x1832095B0")]
			get
			{
				int num = 0;
				if (collectionTypeCase_ == CollectionTypeOneofCase.Crafting)
				{
					object obj = collectionType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60047B4")]
			[Cpp2IlInjected.Address(RVA = "0x3209A20", Offset = "0x3208420", VA = "0x183209A20")]
			set
			{
				collectionType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700128E")]
		[DebuggerNonUserCode]
		public CollectionTypeOneofCase CollectionTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60047B5")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return collectionTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047A2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectionItemType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60047A3")]
		[Cpp2IlInjected.Address(RVA = "0x3209150", Offset = "0x3207B50", VA = "0x183209150")]
		[DebuggerNonUserCode]
		public CollectionItemType(CollectionItemType other)
		{
			//IL_00af: Expected I4, but got I8
			//IL_0100: Expected I4, but got I8
			//IL_013f: Expected I4, but got I8
			//IL_015c: Expected I4, but got O
			bool flag = (ignore_ = other.ignore_);
			if (other.collectionTypeCase_ <= CollectionTypeOneofCase.ActivityItem)
			{
				int num = (CharacterUniverse = other.CharacterUniverse);
				CollectionFurniture collectionFurniture = (CollectionFurniture)(collectionType_ = other.Furniture.Clone());
				CollectionClothing collectionClothing = (CollectionClothing)(collectionType_ = other.Clothing.Clone());
				CollectionTypeWithLocation critter = other.Critter;
				CollectionTypeWithLocation collectionTypeWithLocation = new CollectionTypeWithLocation();
				bool flag2 = (collectionTypeWithLocation.useLocation_ = critter.useLocation_);
				VillageAreaType villageAreaType = (collectionTypeWithLocation.location_ = critter.location_);
				UnknownFieldSet unknownFieldSet = (collectionTypeWithLocation._unknownFields = UnknownFieldSet.Clone(critter._unknownFields));
				collectionType_ = collectionTypeWithLocation;
				collectionTypeCase_ = CollectionTypeOneofCase.Critter;
				CollectionActivity collectionActivity = (CollectionActivity)(collectionType_ = other.ActivityItem.Clone());
				CollectionMemoryShard memoryShard = other.MemoryShard;
				CollectionMemoryShard collectionMemoryShard = new CollectionMemoryShard();
				CollectionMemoryShard.MemoryShardFilterTypeOneofCase memoryShardFilterTypeCase_ = memoryShard.memoryShardFilterTypeCase_;
				if (memoryShardFilterTypeCase_ == CollectionMemoryShard.MemoryShardFilterTypeOneofCase.Universe)
				{
					int universe = memoryShard.Universe;
					collectionMemoryShard.memoryShardFilterType_ = typeof(int).TypeHandle;
					collectionMemoryShard.memoryShardFilterTypeCase_ = CollectionMemoryShard.MemoryShardFilterTypeOneofCase.Universe;
				}
				if (memoryShardFilterTypeCase_ == CollectionMemoryShard.MemoryShardFilterTypeOneofCase.MemoryShardSubType)
				{
					int num2 = (collectionMemoryShard.MemoryShardSubType = memoryShard.MemoryShardSubType);
				}
				UnknownFieldSet unknownFieldSet2 = (collectionMemoryShard._unknownFields = UnknownFieldSet.Clone(memoryShard._unknownFields));
				collectionType_ = collectionMemoryShard;
				collectionTypeCase_ = CollectionTypeOneofCase.MemoryShard;
				collectionTypeCase_ = (CollectionTypeOneofCase)(collectionType_ = other.Crafting.Clone());
			}
			UnknownFieldSet unknownFieldSet3 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047A4")]
		[Cpp2IlInjected.Address(RVA = "0x3207760", Offset = "0x3206160", VA = "0x183207760", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionItemType Clone()
		{
			return new CollectionItemType(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60047B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearCollectionType()
		{
			//IL_0010: Expected O, but got I4
			collectionType_ = (collectionTypeCase_ = CollectionTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047B7")]
		[Cpp2IlInjected.Address(RVA = "0x3207960", Offset = "0x3206360", VA = "0x183207960", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CollectionItemType)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60047B8")]
		[Cpp2IlInjected.Address(RVA = "0x32077C0", Offset = "0x32061C0", VA = "0x1832077C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionItemType other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.ignore_;
				if (ignore_ == flag)
				{
					int characterUniverse = CharacterUniverse;
					int characterUniverse2 = other.CharacterUniverse;
					if (characterUniverse == characterUniverse2)
					{
						CollectionFurniture furniture = Furniture;
						CollectionFurniture furniture2 = other.Furniture;
						if (object.Equals(furniture, furniture2))
						{
							CollectionClothing clothing = Clothing;
							CollectionClothing clothing2 = other.Clothing;
							if (object.Equals(clothing, clothing2))
							{
								CollectionTypeWithLocation critter = Critter;
								CollectionTypeWithLocation critter2 = other.Critter;
								if (object.Equals(critter, critter2))
								{
									CollectionActivity activityItem = ActivityItem;
									CollectionActivity activityItem2 = other.ActivityItem;
									if (object.Equals(activityItem, activityItem2))
									{
										CollectionMemoryShard memoryShard = MemoryShard;
										CollectionMemoryShard memoryShard2 = other.MemoryShard;
										if (object.Equals(memoryShard, memoryShard2))
										{
											CollectionCrafting crafting = Crafting;
											CollectionCrafting crafting2 = other.Crafting;
											if (object.Equals(crafting, crafting2))
											{
												CollectionTypeOneofCase collectionTypeOneofCase = other.collectionTypeCase_;
												if (collectionTypeCase_ == collectionTypeOneofCase)
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047B9")]
		[Cpp2IlInjected.Address(RVA = "0x3207B60", Offset = "0x3206560", VA = "0x183207B60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_010b
			while (true)
			{
				bool flag = ignore_;
				int num = 0;
				if (flag)
				{
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.CharacterUniverse)
				{
					if (collectionTypeCase_ != CollectionTypeOneofCase.CharacterUniverse)
					{
					}
					object obj = collectionType_;
				}
				if (collectionTypeCase_ != CollectionTypeOneofCase.Furniture)
				{
					continue;
				}
				object obj2 = collectionType_;
				if (obj2 != null)
				{
					int hashCode = obj2.GetHashCode();
					if (collectionTypeCase_ != CollectionTypeOneofCase.Clothing)
					{
						continue;
					}
					object obj3 = collectionType_;
					if (obj3 != null)
					{
						int hashCode2 = obj3.GetHashCode();
						if (collectionTypeCase_ != CollectionTypeOneofCase.Critter)
						{
							continue;
						}
						object obj4 = collectionType_;
						if (obj4 != null)
						{
							int hashCode3 = obj4.GetHashCode();
							if (collectionTypeCase_ != CollectionTypeOneofCase.ActivityItem)
							{
								continue;
							}
							object obj5 = collectionType_;
							if (obj5 != null)
							{
								int hashCode4 = obj5.GetHashCode();
								if (collectionTypeCase_ != CollectionTypeOneofCase.MemoryShard)
								{
									continue;
								}
								object obj6 = collectionType_;
								if (obj6 != null)
								{
									int hashCode5 = obj6.GetHashCode();
									if (collectionTypeCase_ == CollectionTypeOneofCase.Crafting)
									{
										object obj7 = collectionType_;
										if (obj7 == null)
										{
											break;
										}
										int hashCode6 = obj7.GetHashCode();
									}
									UnknownFieldSet unknownFields = _unknownFields;
									if (unknownFields != null)
									{
										int hashCode7 = unknownFields.GetHashCode();
									}
									return 1;
								}
							}
							throw new InvalidCastException();
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047BA")]
		[Cpp2IlInjected.Address(RVA = "0x3208C80", Offset = "0x3207680", VA = "0x183208C80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60047BB")]
		[Cpp2IlInjected.Address(RVA = "0x3208CE0", Offset = "0x32076E0", VA = "0x183208CE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0135
			CollectionTypeOneofCase collectionTypeOneofCase = default(CollectionTypeOneofCase);
			while (true)
			{
				if (ignore_)
				{
					bool value = ignore_;
					output.WriteBool(value);
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.CharacterUniverse)
				{
					int characterUniverse = CharacterUniverse;
					output.WriteInt32(characterUniverse);
					collectionTypeOneofCase = collectionTypeCase_;
				}
				int num = 0;
				if (collectionTypeOneofCase != CollectionTypeOneofCase.Furniture)
				{
					continue;
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.Furniture)
				{
					object obj = collectionType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (collectionTypeCase_ != CollectionTypeOneofCase.Clothing)
				{
					continue;
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.Clothing)
				{
					object obj2 = collectionType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (collectionTypeCase_ != CollectionTypeOneofCase.Critter)
				{
					continue;
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.Critter)
				{
					object obj3 = collectionType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (collectionTypeCase_ != CollectionTypeOneofCase.ActivityItem)
				{
					continue;
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.ActivityItem)
				{
					object obj4 = collectionType_;
					if (obj4 != null && obj4 == null)
					{
						break;
					}
				}
				if (collectionTypeCase_ != CollectionTypeOneofCase.MemoryShard)
				{
					continue;
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.MemoryShard)
				{
					object obj5 = collectionType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.Crafting && collectionTypeCase_ == CollectionTypeOneofCase.Crafting)
				{
					object obj6 = collectionType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047BC")]
		[Cpp2IlInjected.Address(RVA = "0x3207260", Offset = "0x3205C60", VA = "0x183207260", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			while (true)
			{
				int num = 0;
				if (collectionTypeCase_ == CollectionTypeOneofCase.CharacterUniverse)
				{
					if (collectionTypeCase_ != CollectionTypeOneofCase.CharacterUniverse)
					{
					}
					object obj = collectionType_;
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.Furniture)
				{
					if (collectionTypeCase_ != CollectionTypeOneofCase.Furniture)
					{
					}
					object obj2 = collectionType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.Clothing)
				{
					if (collectionTypeCase_ != CollectionTypeOneofCase.Clothing)
					{
					}
					object obj3 = collectionType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.Critter)
				{
					if (collectionTypeCase_ != CollectionTypeOneofCase.Critter)
					{
					}
					object obj4 = collectionType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.ActivityItem)
				{
					if (collectionTypeCase_ != CollectionTypeOneofCase.ActivityItem)
					{
					}
					object obj5 = collectionType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.MemoryShard)
				{
					if (collectionTypeCase_ != CollectionTypeOneofCase.MemoryShard)
					{
					}
					object obj6 = collectionType_;
					if (obj6 != null && obj6 == null)
					{
						break;
					}
				}
				if (collectionTypeCase_ == CollectionTypeOneofCase.Crafting && collectionTypeCase_ == CollectionTypeOneofCase.Crafting)
				{
					object obj7 = collectionType_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					return unknownFields.CalculateSize();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047BD")]
		[Cpp2IlInjected.Address(RVA = "0x3208550", Offset = "0x3206F50", VA = "0x183208550", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionItemType other)
		{
			//Discarded unreachable code: IL_0049, IL_0052, IL_0069, IL_007f, IL_0096, IL_00ac, IL_00c3, IL_00cb, IL_00d0, IL_00de, IL_00e7, IL_00f5, IL_00fe, IL_0129, IL_0140, IL_0156, IL_016d, IL_0183, IL_019a
			//IL_0069: Expected I4, but got O
			//IL_0096: Expected I4, but got O
			//IL_00c3: Expected I4, but got O
			//IL_0140: Expected I4, but got O
			//IL_016d: Expected I4, but got O
			//IL_019a: Expected I4, but got O
			if (other != null)
			{
				bool flag = other.ignore_;
				if (flag)
				{
					ignore_ = flag;
				}
				if (other.collectionTypeCase_ <= CollectionTypeOneofCase.ActivityItem)
				{
					int num = (CharacterUniverse = other.CharacterUniverse);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047BE")]
		[Cpp2IlInjected.Address(RVA = "0x3207F90", Offset = "0x3206990", VA = "0x183207F90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0066: Expected I4, but got O
			//IL_00b5: Expected I4, but got O
			//IL_0105: Expected I4, but got O
			//IL_0119: Expected I4, but got O
			//IL_0143: Expected I4, but got O
			//IL_0197: Expected I4, but got O
			//IL_01ef: Expected I4, but got O
			//IL_0246: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 50)
				{
					if (num == 58)
					{
						CollectionMemoryShard collectionMemoryShard = new CollectionMemoryShard();
						if (collectionTypeCase_ == CollectionTypeOneofCase.MemoryShard)
						{
							if (collectionTypeCase_ != CollectionTypeOneofCase.MemoryShard)
							{
							}
							object obj = collectionType_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(collectionMemoryShard);
						collectionType_ = collectionMemoryShard;
						collectionTypeCase_ = (CollectionTypeOneofCase)collectionMemoryShard;
					}
					if (num != 66)
					{
						goto IL_0275;
					}
					CollectionCrafting builder = new CollectionCrafting();
					if (collectionTypeCase_ == CollectionTypeOneofCase.Crafting)
					{
						if (collectionTypeCase_ != CollectionTypeOneofCase.Crafting)
						{
						}
						object obj2 = collectionType_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					collectionType_ = builder;
					collectionTypeCase_ = (CollectionTypeOneofCase)typeof(CollectionCrafting).TypeHandle;
				}
				UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
				if (num == 42)
				{
					CollectionTypeWithLocation collectionTypeWithLocation = new CollectionTypeWithLocation();
					if (collectionTypeCase_ == CollectionTypeOneofCase.Critter)
					{
						if (collectionTypeCase_ != CollectionTypeOneofCase.Critter)
						{
						}
						object obj3 = collectionType_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
						if (obj3 != null)
						{
							if ((object)typeof(CollectionTypeWithLocation).TypeHandle != null)
							{
								collectionTypeWithLocation.useLocation_ = (byte)(int)typeof(CollectionTypeWithLocation).TypeHandle != 0;
							}
							if ((object)typeof(CollectionTypeWithLocation).TypeHandle != null)
							{
								collectionTypeWithLocation.location_ = (VillageAreaType)typeof(CollectionTypeWithLocation).TypeHandle;
							}
							UnknownFieldSet unknownFields = collectionTypeWithLocation._unknownFields;
							collectionTypeWithLocation._unknownFields = unknownFieldSet;
						}
					}
					input.ReadMessage(collectionTypeWithLocation);
					collectionType_ = collectionTypeWithLocation;
					collectionTypeCase_ = (CollectionTypeOneofCase)unknownFieldSet;
				}
				if ((long)unknownFieldSet != 50)
				{
					goto IL_0275;
				}
				CollectionActivity builder2 = new CollectionActivity();
				if (collectionTypeCase_ == CollectionTypeOneofCase.ActivityItem)
				{
					if (collectionTypeCase_ != CollectionTypeOneofCase.ActivityItem)
					{
					}
					object obj4 = collectionType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				collectionType_ = builder2;
				collectionTypeCase_ = (CollectionTypeOneofCase)typeof(CollectionActivity).TypeHandle;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					CollectionFurniture builder3 = new CollectionFurniture();
					if (collectionTypeCase_ == CollectionTypeOneofCase.Furniture)
					{
						if (collectionTypeCase_ != CollectionTypeOneofCase.Furniture)
						{
						}
						object obj5 = collectionType_;
						if (obj5 != null && obj5 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder3);
					collectionType_ = builder3;
					collectionTypeCase_ = (CollectionTypeOneofCase)typeof(CollectionFurniture).TypeHandle;
				}
				if ((long)typeof(CollectionFurniture).TypeHandle != 34)
				{
					goto IL_0275;
				}
				CollectionClothing builder4 = new CollectionClothing();
				if (collectionTypeCase_ == CollectionTypeOneofCase.Clothing)
				{
					if (collectionTypeCase_ != CollectionTypeOneofCase.Clothing)
					{
					}
					object obj6 = collectionType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				collectionType_ = builder4;
				collectionTypeCase_ = (CollectionTypeOneofCase)typeof(CollectionClothing).TypeHandle;
			}
			bool flag = default(bool);
			if ((long)typeof(CollectionClothing).TypeHandle == 8)
			{
				flag = (ignore_ = input.ReadBool());
			}
			if (flag)
			{
				int num3 = (CharacterUniverse = input.ReadInt32());
			}
			goto IL_0275;
			IL_0275:
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60047BF")]
		[Cpp2IlInjected.Address(RVA = "0x32079C0", Offset = "0x32063C0", VA = "0x1832079C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				bool flag = ignore_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047C0")]
		[Cpp2IlInjected.Address(RVA = "0x3208940", Offset = "0x3207340", VA = "0x183208940", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0013, IL_0018, IL_001c, IL_0020, IL_0021, IL_0025, IL_0029, IL_002a, IL_002e, IL_0032, IL_0033, IL_0037, IL_003b, IL_003c, IL_0040, IL_0044, IL_0045, IL_004b, IL_0051, IL_0057, IL_005d, IL_0063
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 7)
			{
				object obj = default(object);
				ignore_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047C1")]
		[Cpp2IlInjected.Address(RVA = "0x3207660", Offset = "0x3206060", VA = "0x183207660", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016, IL_0027, IL_002b, IL_002f, IL_0033, IL_0045, IL_0055
			//IL_001f: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			if (fieldNumber <= 7)
			{
				ignore_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047C2")]
		[Cpp2IlInjected.Address(RVA = "0x3207EE0", Offset = "0x32068E0", VA = "0x183207EE0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "CollectionType"))
			{
				CollectionTypeOneofCase collectionTypeOneofCase = collectionTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047C3")]
		[Cpp2IlInjected.Address(RVA = "0x32076F0", Offset = "0x32060F0", VA = "0x1832076F0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "CollectionType"))
			{
				collectionType_ = (collectionTypeCase_ = CollectionTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047C4")]
		[Cpp2IlInjected.Address(RVA = "0x3209040", Offset = "0x3207A40", VA = "0x183209040")]
		static CollectionItemType()
		{
			Func<CollectionItemType> func = default(Func<CollectionItemType>);
			_parser = (MessageParser<CollectionItemType>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
