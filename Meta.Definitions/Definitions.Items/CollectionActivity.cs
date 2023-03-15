using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005B4")]
	public sealed class CollectionActivity : IMessage<CollectionActivity>, IMessage, IEquatable<CollectionActivity>, IDeepCloneable<CollectionActivity>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005B5")]
		public enum ActivityTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001F2D")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001F2E")]
			Crop,
			[Cpp2IlInjected.Token(Token = "0x4001F2F")]
			Meal,
			[Cpp2IlInjected.Token(Token = "0x4001F30")]
			Flower,
			[Cpp2IlInjected.Token(Token = "0x4001F31")]
			Fish,
			[Cpp2IlInjected.Token(Token = "0x4001F32")]
			Ingredient,
			[Cpp2IlInjected.Token(Token = "0x4001F33")]
			CraftingMaterial,
			[Cpp2IlInjected.Token(Token = "0x4001F34")]
			Mineral,
			[Cpp2IlInjected.Token(Token = "0x4001F35")]
			ByGameplayTag
		}

		[Cpp2IlInjected.Token(Token = "0x4001F20")]
		private static readonly MessageParser<CollectionActivity> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F21")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F22")]
		public const int CropFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001F23")]
		public const int MealFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001F24")]
		public const int FlowerFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4001F25")]
		public const int FishFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4001F26")]
		public const int IngredientFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001F27")]
		public const int CraftingMaterialFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4001F28")]
		public const int MineralFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4001F29")]
		public const int ByGameplayTagFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F2A")]
		private object activityType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F2B")]
		private ActivityTypeOneofCase activityTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x1700126B")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionActivity> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600473C")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5AA0", Offset = "0x2EC44A0", VA = "0x182EC5AA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700126C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600473D")]
			[Cpp2IlInjected.Address(RVA = "0x2EC57E0", Offset = "0x2EC41E0", VA = "0x182EC57E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700126D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600473E")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5B00", Offset = "0x2EC4500", VA = "0x182EC5B00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700126E")]
		[DebuggerNonUserCode]
		public CollectionCrop Crop
		{
			[Cpp2IlInjected.Token(Token = "0x6004742")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5780", Offset = "0x2EC4180", VA = "0x182EC5780")]
			get
			{
				int num = 0;
				if (activityTypeCase_ == ActivityTypeOneofCase.Crop)
				{
					object obj = activityType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004743")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				activityType_ = value;
				bool flag = (byte)(activityTypeCase_ = ((value != null) ? ActivityTypeOneofCase.Crop : ActivityTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700126F")]
		[DebuggerNonUserCode]
		public CollectionMeal Meal
		{
			[Cpp2IlInjected.Token(Token = "0x6004744")]
			[Cpp2IlInjected.Address(RVA = "0x2EC59E0", Offset = "0x2EC43E0", VA = "0x182EC59E0")]
			get
			{
				int num = 0;
				if (activityTypeCase_ == ActivityTypeOneofCase.Meal)
				{
					object obj = activityType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004745")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				activityType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001270")]
		[DebuggerNonUserCode]
		public Empty Flower
		{
			[Cpp2IlInjected.Token(Token = "0x6004746")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5910", Offset = "0x2EC4310", VA = "0x182EC5910")]
			get
			{
				int num = 0;
				if (activityTypeCase_ == ActivityTypeOneofCase.Flower)
				{
					object obj = activityType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004747")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				activityType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001271")]
		[DebuggerNonUserCode]
		public CollectionTypeWithLocation Fish
		{
			[Cpp2IlInjected.Token(Token = "0x6004748")]
			[Cpp2IlInjected.Address(RVA = "0x2EC58B0", Offset = "0x2EC42B0", VA = "0x182EC58B0")]
			get
			{
				int num = 0;
				if (activityTypeCase_ == ActivityTypeOneofCase.Fish)
				{
					object obj = activityType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004749")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				activityType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001272")]
		[DebuggerNonUserCode]
		public int Ingredient
		{
			[Cpp2IlInjected.Token(Token = "0x600474A")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5970", Offset = "0x2EC4370", VA = "0x182EC5970")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (activityTypeCase_ == ActivityTypeOneofCase.Ingredient)
				{
					object obj = activityType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x600474B")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5C80", Offset = "0x2EC4680", VA = "0x182EC5C80")]
			set
			{
				//IL_0014: Expected I4, but got I8
				activityType_ = typeof(int).TypeHandle;
				activityTypeCase_ = ActivityTypeOneofCase.Ingredient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001273")]
		[DebuggerNonUserCode]
		public Empty CraftingMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600474C")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5720", Offset = "0x2EC4120", VA = "0x182EC5720")]
			get
			{
				int num = 0;
				if (activityTypeCase_ == ActivityTypeOneofCase.CraftingMaterial)
				{
					object obj = activityType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600474D")]
			[Cpp2IlInjected.Address(RVA = "0x5C5CD0", Offset = "0x5C46D0", VA = "0x1805C5CD0")]
			set
			{
				activityType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001274")]
		[DebuggerNonUserCode]
		public Empty Mineral
		{
			[Cpp2IlInjected.Token(Token = "0x600474E")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5A40", Offset = "0x2EC4440", VA = "0x182EC5A40")]
			get
			{
				int num = 0;
				if (activityTypeCase_ == ActivityTypeOneofCase.Mineral)
				{
					object obj = activityType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600474F")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E10", Offset = "0x5C4810", VA = "0x1805C5E10")]
			set
			{
				activityType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001275")]
		[DebuggerNonUserCode]
		public int ByGameplayTag
		{
			[Cpp2IlInjected.Token(Token = "0x6004750")]
			[Cpp2IlInjected.Address(RVA = "0x2EC56B0", Offset = "0x2EC40B0", VA = "0x182EC56B0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (activityTypeCase_ == ActivityTypeOneofCase.ByGameplayTag)
				{
					object obj = activityType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6004751")]
			[Cpp2IlInjected.Address(RVA = "0x2EC5C10", Offset = "0x2EC4610", VA = "0x182EC5C10")]
			set
			{
				//IL_0014: Expected I4, but got I8
				activityType_ = typeof(int).TypeHandle;
				activityTypeCase_ = ActivityTypeOneofCase.ByGameplayTag;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001276")]
		[DebuggerNonUserCode]
		public ActivityTypeOneofCase ActivityTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004752")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return activityTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600473F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectionActivity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004740")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5420", Offset = "0x2EC3E20", VA = "0x182EC5420")]
		[DebuggerNonUserCode]
		public CollectionActivity(CollectionActivity other)
		{
			//IL_0050: Expected I4, but got I8
			//IL_006d: Expected I4, but got O
			//IL_008a: Expected I4, but got O
			//IL_00a7: Expected I4, but got O
			//IL_00d4: Expected I4, but got O
			//IL_00f1: Expected I4, but got O
			if (other.activityTypeCase_ <= ActivityTypeOneofCase.Mineral)
			{
				CollectionCrop crop = other.Crop;
				CollectionCrop collectionCrop = new CollectionCrop();
				CropType cropType = (collectionCrop.cropType_ = crop.cropType_);
				UnknownFieldSet unknownFieldSet = (collectionCrop._unknownFields = UnknownFieldSet.Clone(crop._unknownFields));
				activityType_ = collectionCrop;
				activityTypeCase_ = ActivityTypeOneofCase.Crop;
				activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = other.Meal.Clone());
				activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = other.Flower.Clone());
				activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = other.Fish.Clone());
				int num = (Ingredient = other.Ingredient);
				activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = other.CraftingMaterial.Clone());
				activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = other.Mineral.Clone());
				int num2 = (ByGameplayTag = other.ByGameplayTag);
			}
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004741")]
		[Cpp2IlInjected.Address(RVA = "0x2EC39C0", Offset = "0x2EC23C0", VA = "0x182EC39C0", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionActivity Clone()
		{
			return new CollectionActivity(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004753")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearActivityType()
		{
			//IL_0010: Expected O, but got I4
			activityType_ = (activityTypeCase_ = ActivityTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004754")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3A20", Offset = "0x2EC2420", VA = "0x182EC3A20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CollectionActivity)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004755")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3A80", Offset = "0x2EC2480", VA = "0x182EC3A80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionActivity other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (activityTypeCase_ == ActivityTypeOneofCase.Crop)
				{
					object obj = activityType_;
					if (obj != null && obj == null)
					{
						goto IL_0147;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.activityTypeCase_ == ActivityTypeOneofCase.Crop)
				{
					obj2 = other.activityType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					CollectionMeal meal = Meal;
					CollectionMeal meal2 = other.Meal;
					if (object.Equals(meal, meal2))
					{
						Empty flower = Flower;
						Empty flower2 = other.Flower;
						if (object.Equals(flower, flower2))
						{
							CollectionTypeWithLocation fish = Fish;
							CollectionTypeWithLocation fish2 = other.Fish;
							if (object.Equals(fish, fish2))
							{
								int ingredient = Ingredient;
								int ingredient2 = other.Ingredient;
								if (ingredient == ingredient2)
								{
									Empty craftingMaterial = CraftingMaterial;
									Empty craftingMaterial2 = other.CraftingMaterial;
									if (object.Equals(craftingMaterial, craftingMaterial2))
									{
										Empty mineral = Mineral;
										Empty mineral2 = other.Mineral;
										if (object.Equals(mineral, mineral2))
										{
											int byGameplayTag = ByGameplayTag;
											int byGameplayTag2 = other.ByGameplayTag;
											if (byGameplayTag == byGameplayTag2)
											{
												ActivityTypeOneofCase activityTypeOneofCase = other.activityTypeCase_;
												if (activityTypeCase_ == activityTypeOneofCase)
												{
													UnknownFieldSet unknownFields = other._unknownFields;
													bool flag = object.Equals(_unknownFields, unknownFields);
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
			int num2 = 0;
			goto IL_0147;
			IL_0147:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004756")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3E20", Offset = "0x2EC2820", VA = "0x182EC3E20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0116
			while (true)
			{
				ActivityTypeOneofCase activityTypeOneofCase = activityTypeCase_;
				int num = 0;
				if (activityTypeOneofCase == ActivityTypeOneofCase.Crop)
				{
					object obj = activityType_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (activityTypeOneofCase != ActivityTypeOneofCase.Meal)
				{
					continue;
				}
				object obj2 = activityType_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (activityTypeCase_ != ActivityTypeOneofCase.Flower)
					{
						continue;
					}
					object obj3 = activityType_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (activityTypeCase_ != ActivityTypeOneofCase.Fish)
						{
							continue;
						}
						object obj4 = activityType_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (activityTypeCase_ == ActivityTypeOneofCase.Ingredient)
							{
								if (activityTypeCase_ != ActivityTypeOneofCase.Ingredient)
								{
								}
								object obj5 = activityType_;
							}
							if (activityTypeCase_ != ActivityTypeOneofCase.CraftingMaterial)
							{
								continue;
							}
							object obj6 = activityType_;
							if (obj6 != null)
							{
								int hashCode5 = obj6.GetHashCode();
								if (activityTypeCase_ == ActivityTypeOneofCase.Mineral)
								{
									object obj7 = activityType_;
									if (obj7 == null)
									{
										break;
									}
									int hashCode6 = obj7.GetHashCode();
									if (activityTypeCase_ == ActivityTypeOneofCase.ByGameplayTag && activityTypeCase_ == ActivityTypeOneofCase.ByGameplayTag)
									{
										object obj8 = activityType_;
									}
									UnknownFieldSet unknownFields = _unknownFields;
									if (unknownFields != null)
									{
										int hashCode7 = unknownFields.GetHashCode();
									}
									return 1;
								}
								continue;
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

		[Cpp2IlInjected.Token(Token = "0x6004757")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4F40", Offset = "0x2EC3940", VA = "0x182EC4F40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004758")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4FA0", Offset = "0x2EC39A0", VA = "0x182EC4FA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_013b
			//IL_002f: Expected O, but got I4
			while (true)
			{
				ActivityTypeOneofCase activityTypeOneofCase = activityTypeCase_;
				int num = 0;
				if (activityTypeOneofCase == ActivityTypeOneofCase.Crop)
				{
					if (activityTypeCase_ == ActivityTypeOneofCase.Crop)
					{
						object obj = activityType_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (activityTypeOneofCase != ActivityTypeOneofCase.Meal)
				{
					continue;
				}
				if (activityTypeCase_ == ActivityTypeOneofCase.Meal)
				{
					object obj2 = activityType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (activityTypeCase_ != ActivityTypeOneofCase.Flower)
				{
					continue;
				}
				if (activityTypeCase_ == ActivityTypeOneofCase.Flower)
				{
					object obj3 = activityType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (activityTypeCase_ != ActivityTypeOneofCase.Fish)
				{
					continue;
				}
				if (activityTypeCase_ == ActivityTypeOneofCase.Fish)
				{
					object obj4 = activityType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (activityTypeCase_ != ActivityTypeOneofCase.Ingredient)
				{
					continue;
				}
				int ingredient = Ingredient;
				output.WriteInt32(ingredient);
				if (activityTypeCase_ != ActivityTypeOneofCase.CraftingMaterial)
				{
					continue;
				}
				if (activityTypeCase_ == ActivityTypeOneofCase.CraftingMaterial)
				{
					object obj5 = activityType_;
					if (obj5 != null && obj5 == null)
					{
						break;
					}
				}
				if (activityTypeCase_ != ActivityTypeOneofCase.Mineral)
				{
					continue;
				}
				if (activityTypeCase_ == ActivityTypeOneofCase.Mineral)
				{
					object obj6 = activityType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (activityTypeCase_ == ActivityTypeOneofCase.ByGameplayTag)
				{
					int byGameplayTag = ByGameplayTag;
					output.WriteInt32(byGameplayTag);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004759")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3430", Offset = "0x2EC1E30", VA = "0x182EC3430", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_017a
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (activityTypeCase_ == ActivityTypeOneofCase.Crop)
			{
				if (activityTypeCase_ == ActivityTypeOneofCase.Crop)
				{
					object obj = activityType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (activityTypeCase_ == ActivityTypeOneofCase.Meal)
			{
				if (activityTypeCase_ != ActivityTypeOneofCase.Meal)
				{
				}
				object obj2 = activityType_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (activityTypeCase_ == ActivityTypeOneofCase.Flower)
			{
				if (activityTypeCase_ != ActivityTypeOneofCase.Flower)
				{
				}
				object obj3 = activityType_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (activityTypeCase_ == ActivityTypeOneofCase.Fish)
			{
				if (activityTypeCase_ != ActivityTypeOneofCase.Fish)
				{
				}
				object obj4 = activityType_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (activityTypeCase_ == ActivityTypeOneofCase.Ingredient)
			{
				if (activityTypeCase_ != ActivityTypeOneofCase.Ingredient)
				{
				}
				object obj5 = activityType_;
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (activityTypeCase_ == ActivityTypeOneofCase.CraftingMaterial)
			{
				if (activityTypeCase_ != ActivityTypeOneofCase.CraftingMaterial)
				{
				}
				object obj6 = activityType_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			if (activityTypeCase_ == ActivityTypeOneofCase.Mineral)
			{
				if (activityTypeCase_ != ActivityTypeOneofCase.Mineral)
				{
				}
				object obj7 = activityType_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num8 = default(int);
				num += num8;
			}
			if (activityTypeCase_ == ActivityTypeOneofCase.ByGameplayTag)
			{
				if (activityTypeCase_ == ActivityTypeOneofCase.ByGameplayTag)
				{
					object obj8 = activityType_;
				}
				num++;
				int num9 = default(int);
				num += num9;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num += num10;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600475A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4850", Offset = "0x2EC3250", VA = "0x182EC4850", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionActivity other)
		{
			//Discarded unreachable code: IL_01cc
			//IL_00a1: Expected I4, but got O
			//IL_00da: Expected I4, but got O
			//IL_0113: Expected I4, but got O
			//IL_015c: Expected I4, but got O
			//IL_018c: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.activityTypeCase_ <= ActivityTypeOneofCase.Mineral)
			{
				if (Crop == null)
				{
					bool flag = (byte)(activityTypeCase_ = (((activityType_ = new CollectionCrop()) != null) ? ActivityTypeOneofCase.Crop : ActivityTypeOneofCase.None)) != 0;
				}
				CollectionCrop crop = Crop;
				CollectionCrop crop2 = other.Crop;
				if (crop2 != null)
				{
					CropType cropType_ = crop2.cropType_;
					if (cropType_ != 0)
					{
						crop.cropType_ = cropType_;
					}
					UnknownFieldSet unknownFields = crop2._unknownFields;
					UnknownFieldSet unknownFieldSet = (crop._unknownFields = UnknownFieldSet.MergeFrom(crop._unknownFields, unknownFields));
					if (Meal == null)
					{
						activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = new CollectionMeal());
					}
					CollectionMeal meal = Meal;
					CollectionMeal meal2 = other.Meal;
					meal.MergeFrom(meal2);
					if (Flower == null)
					{
						activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = new Empty());
					}
					Empty flower = Flower;
					Empty flower2 = other.Flower;
					flower.MergeFrom(flower2);
					if (Fish == null)
					{
						activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = new CollectionTypeWithLocation());
					}
					CollectionTypeWithLocation fish = Fish;
					CollectionTypeWithLocation fish2 = other.Fish;
					fish.MergeFrom(fish2);
					int num = (Ingredient = other.Ingredient);
					if (CraftingMaterial == null)
					{
						activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = new Empty());
					}
					Empty craftingMaterial = CraftingMaterial;
					Empty craftingMaterial2 = other.CraftingMaterial;
					if (Mineral == null)
					{
						activityTypeCase_ = (ActivityTypeOneofCase)(activityType_ = new Empty());
					}
					Empty mineral = Mineral;
					Empty mineral2 = other.Mineral;
					int num2 = (ByGameplayTag = other.ByGameplayTag);
				}
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x600475B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC42B0", Offset = "0x2EC2CB0", VA = "0x182EC42B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0063: Expected I4, but got O
			//IL_00e2: Expected I4, but got O
			//IL_013a: Expected I4, but got O
			//IL_0191: Expected I4, but got O
			//IL_01e6: Expected I4, but got O
			//IL_0265: Expected I4, but got O
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
						Empty empty = new Empty();
						if (activityTypeCase_ == ActivityTypeOneofCase.Mineral)
						{
							if (activityTypeCase_ != ActivityTypeOneofCase.Mineral)
							{
							}
							object obj = activityType_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(empty);
						activityType_ = empty;
						activityTypeCase_ = (ActivityTypeOneofCase)empty;
					}
					if (num != 64)
					{
						goto IL_0265;
					}
					int num3 = (ByGameplayTag = input.ReadInt32());
				}
				int num5 = default(int);
				if (num == 40)
				{
					num5 = (Ingredient = input.ReadInt32());
				}
				if (num5 != 50)
				{
					goto IL_0265;
				}
				Empty builder = new Empty();
				if (activityTypeCase_ == ActivityTypeOneofCase.CraftingMaterial)
				{
					if (activityTypeCase_ != ActivityTypeOneofCase.CraftingMaterial)
					{
					}
					object obj2 = activityType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				activityType_ = builder;
				activityTypeCase_ = (ActivityTypeOneofCase)typeof(Empty).TypeHandle;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					Empty builder2 = new Empty();
					if (activityTypeCase_ == ActivityTypeOneofCase.Flower)
					{
						if (activityTypeCase_ != ActivityTypeOneofCase.Flower)
						{
						}
						object obj3 = activityType_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					activityType_ = builder2;
					activityTypeCase_ = (ActivityTypeOneofCase)typeof(Empty).TypeHandle;
				}
				if ((long)typeof(Empty).TypeHandle != 34)
				{
					goto IL_0265;
				}
				CollectionTypeWithLocation builder3 = new CollectionTypeWithLocation();
				if (activityTypeCase_ == ActivityTypeOneofCase.Fish)
				{
					if (activityTypeCase_ != ActivityTypeOneofCase.Fish)
					{
					}
					object obj4 = activityType_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				activityType_ = builder3;
				activityTypeCase_ = (ActivityTypeOneofCase)typeof(CollectionTypeWithLocation).TypeHandle;
			}
			bool flag = default(bool);
			if ((long)typeof(CollectionTypeWithLocation).TypeHandle == 10)
			{
				CollectionCrop collectionCrop = new CollectionCrop();
				if (activityTypeCase_ == ActivityTypeOneofCase.Crop)
				{
					if (activityTypeCase_ != ActivityTypeOneofCase.Crop)
					{
					}
					object obj5 = activityType_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
					if (obj5 != null)
					{
						if ((object)typeof(CollectionCrop).TypeHandle != null)
						{
							collectionCrop.cropType_ = (CropType)typeof(CollectionCrop).TypeHandle;
						}
						UnknownFieldSet unknownFields = collectionCrop._unknownFields;
						UnknownFieldSet unknownFields2 = default(UnknownFieldSet);
						collectionCrop._unknownFields = unknownFields2;
					}
				}
				input.ReadMessage(collectionCrop);
				activityType_ = collectionCrop;
				flag = (byte)(activityTypeCase_ = ((collectionCrop != null) ? ActivityTypeOneofCase.Crop : ActivityTypeOneofCase.None)) != 0;
			}
			if (flag)
			{
				CollectionMeal builder4 = new CollectionMeal();
				if (activityTypeCase_ == ActivityTypeOneofCase.Meal)
				{
					if (activityTypeCase_ != ActivityTypeOneofCase.Meal)
					{
					}
					object obj6 = activityType_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				activityType_ = builder4;
				activityTypeCase_ = (ActivityTypeOneofCase)typeof(CollectionMeal).TypeHandle;
			}
			goto IL_0265;
			IL_0265:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600475C")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3CA0", Offset = "0x2EC26A0", VA = "0x182EC3CA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				CollectionCrop crop = Crop;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600475D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4C10", Offset = "0x2EC3610", VA = "0x182EC4C10", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0027, IL_002b, IL_002f, IL_0030, IL_0034, IL_0038, IL_0039, IL_003d, IL_0041, IL_0042, IL_0043, IL_0047, IL_004b, IL_004c, IL_0050, IL_0054, IL_0055, IL_0056, IL_0062, IL_0068, IL_006e, IL_0074, IL_007a
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				activityType_ = num;
				bool flag = (byte)(activityTypeCase_ = ((num != 0) ? ActivityTypeOneofCase.Crop : ActivityTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600475E")]
		[Cpp2IlInjected.Address(RVA = "0x2EC38B0", Offset = "0x2EC22B0", VA = "0x182EC38B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0015, IL_001f
			//IL_000d: Expected O, but got I4
			if (fieldNumber <= 7)
			{
				int num = 0;
				activityType_ = num;
				activityTypeCase_ = (ActivityTypeOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600475F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4200", Offset = "0x2EC2C00", VA = "0x182EC4200", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ActivityType"))
			{
				ActivityTypeOneofCase activityTypeOneofCase = activityTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004760")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3950", Offset = "0x2EC2350", VA = "0x182EC3950", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ActivityType"))
			{
				activityType_ = (activityTypeCase_ = ActivityTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004761")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5310", Offset = "0x2EC3D10", VA = "0x182EC5310")]
		static CollectionActivity()
		{
			Func<CollectionActivity> func = default(Func<CollectionActivity>);
			_parser = (MessageParser<CollectionActivity>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
