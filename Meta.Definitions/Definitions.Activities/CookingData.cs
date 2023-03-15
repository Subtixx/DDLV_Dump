using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Player;
using Gameloft.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x200086B")]
	public sealed class CookingData : IActivityLockCondition, IDataValidation, IMessage<CookingData>, IMessage, IEquatable<CookingData>, IDeepCloneable<CookingData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200086C")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200086D")]
			public sealed class RecipeStarResult : IMessage<RecipeStarResult>, IMessage, IEquatable<RecipeStarResult>, IDeepCloneable<RecipeStarResult>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40029AC")]
				private static readonly MessageParser<RecipeStarResult> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40029AD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40029AE")]
				public const int StarFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40029AF")]
				private int star_;

				[Cpp2IlInjected.Token(Token = "0x40029B0")]
				public const int MinDiscoveredInfoPercentageFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40029B1")]
				private int minDiscoveredInfoPercentage_;

				[Cpp2IlInjected.Token(Token = "0x40029B2")]
				public const int MaxDiscoveredInfoPercentageFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40029B3")]
				private int maxDiscoveredInfoPercentage_;

				[Cpp2IlInjected.Token(Token = "0x40029B4")]
				public const int SellPriceIngredientPercentageFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x40029B5")]
				private int sellPriceIngredientPercentage_;

				[Cpp2IlInjected.Token(Token = "0x40029B6")]
				public const int ManaRecoveredIngredientPercentageFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40029B7")]
				private int manaRecoveredIngredientPercentage_;

				[Cpp2IlInjected.Token(Token = "0x170017C0")]
				[DebuggerNonUserCode]
				public static MessageParser<RecipeStarResult> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005E4B")]
					[Cpp2IlInjected.Address(RVA = "0x29483D0", Offset = "0x2946DD0", VA = "0x1829483D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017C1")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005E4C")]
					[Cpp2IlInjected.Address(RVA = "0x2948350", Offset = "0x2946D50", VA = "0x182948350")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017C2")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005E4D")]
					[Cpp2IlInjected.Address(RVA = "0x2948430", Offset = "0x2946E30", VA = "0x182948430", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017C3")]
				[DebuggerNonUserCode]
				public int Star
				{
					[Cpp2IlInjected.Token(Token = "0x6005E51")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6005E52")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017C4")]
				[DebuggerNonUserCode]
				public int MinDiscoveredInfoPercentage
				{
					[Cpp2IlInjected.Token(Token = "0x6005E53")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6005E54")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017C5")]
				[DebuggerNonUserCode]
				public int MaxDiscoveredInfoPercentage
				{
					[Cpp2IlInjected.Token(Token = "0x6005E55")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6005E56")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017C6")]
				[DebuggerNonUserCode]
				public int SellPriceIngredientPercentage
				{
					[Cpp2IlInjected.Token(Token = "0x6005E57")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6005E58")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017C7")]
				[DebuggerNonUserCode]
				public int ManaRecoveredIngredientPercentage
				{
					[Cpp2IlInjected.Token(Token = "0x6005E59")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6005E5A")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005E4E")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public RecipeStarResult()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E4F")]
				[Cpp2IlInjected.Address(RVA = "0x1A54730", Offset = "0x1A53130", VA = "0x181A54730")]
				[DebuggerNonUserCode]
				public RecipeStarResult(RecipeStarResult other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E50")]
				[Cpp2IlInjected.Address(RVA = "0x2947E00", Offset = "0x2946800", VA = "0x182947E00", Slot = "10")]
				[DebuggerNonUserCode]
				public RecipeStarResult Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005E5B")]
				[Cpp2IlInjected.Address(RVA = "0x2947EA0", Offset = "0x29468A0", VA = "0x182947EA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005E5C")]
				[Cpp2IlInjected.Address(RVA = "0x1A53B70", Offset = "0x1A52570", VA = "0x181A53B70", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(RecipeStarResult other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005E5D")]
				[Cpp2IlInjected.Address(RVA = "0x1A53D50", Offset = "0x1A52750", VA = "0x181A53D50", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005E5E")]
				[Cpp2IlInjected.Address(RVA = "0x29481E0", Offset = "0x2946BE0", VA = "0x1829481E0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005E5F")]
				[Cpp2IlInjected.Address(RVA = "0x1A54520", Offset = "0x1A52F20", VA = "0x181A54520", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E60")]
				[Cpp2IlInjected.Address(RVA = "0x2947CA0", Offset = "0x29466A0", VA = "0x182947CA0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005E61")]
				[Cpp2IlInjected.Address(RVA = "0x1A53E20", Offset = "0x1A52820", VA = "0x181A53E20", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(RecipeStarResult other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E62")]
				[Cpp2IlInjected.Address(RVA = "0x1A53EA0", Offset = "0x1A528A0", VA = "0x181A53EA0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E63")]
				[Cpp2IlInjected.Address(RVA = "0x2947F50", Offset = "0x2946950", VA = "0x182947F50", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005E64")]
				[Cpp2IlInjected.Address(RVA = "0x2948030", Offset = "0x2946A30", VA = "0x182948030", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E65")]
				[Cpp2IlInjected.Address(RVA = "0x1A53A70", Offset = "0x1A52470", VA = "0x181A53A70", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400298D")]
		private static readonly MessageParser<CookingData> _parser = (MessageParser<CookingData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CookingData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400298E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400298F")]
		public const int NumberOfCorrectIngredientsWeightFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002990")]
		private float numberOfCorrectIngredientsWeight_;

		[Cpp2IlInjected.Token(Token = "0x4002991")]
		public const int NumberOfCorrectTypesWeightFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002992")]
		private float numberOfCorrectTypesWeight_;

		[Cpp2IlInjected.Token(Token = "0x4002993")]
		public const int NumberOfWrongIngredientsWeightFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002994")]
		private float numberOfWrongIngredientsWeight_;

		[Cpp2IlInjected.Token(Token = "0x4002995")]
		public const int NumberOfMissingIngredientsWeightFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002996")]
		private float numberOfMissingIngredientsWeight_;

		[Cpp2IlInjected.Token(Token = "0x4002997")]
		public const int RecipeStarResultsFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4002998")]
		private static readonly FieldCodec<Types.RecipeStarResult> _repeated_recipeStarResults_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002999")]
		private readonly RepeatedField<Types.RecipeStarResult> recipeStarResults_ = (RepeatedField<Types.RecipeStarResult>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400299A")]
		public const int CombustibleItemIDFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400299B")]
		private int combustibleItemID_;

		[Cpp2IlInjected.Token(Token = "0x400299C")]
		public const int CombustileAmountFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400299D")]
		private int combustileAmount_;

		[Cpp2IlInjected.Token(Token = "0x400299E")]
		public const int PreviousRecipeHistoryLengthFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400299F")]
		private int previousRecipeHistoryLength_;

		[Cpp2IlInjected.Token(Token = "0x40029A0")]
		public const int FriendshipAmountPerStarFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40029A1")]
		private int friendshipAmountPerStar_;

		[Cpp2IlInjected.Token(Token = "0x40029A2")]
		public const int PercentageOfSellPriceRewardFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40029A3")]
		private int percentageOfSellPriceReward_;

		[Cpp2IlInjected.Token(Token = "0x40029A4")]
		public const int RestaurantHostFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40029A5")]
		private int restaurantHost_;

		[Cpp2IlInjected.Token(Token = "0x40029A6")]
		public const int UnlockBuildingItemIDFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40029A7")]
		private int unlockBuildingItemID_;

		[Cpp2IlInjected.Token(Token = "0x40029A8")]
		public const int BaseManaRecoveredFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40029A9")]
		private int baseManaRecovered_;

		[Cpp2IlInjected.Token(Token = "0x40029AA")]
		public const int MaxManaRecoveredFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40029AB")]
		private int maxManaRecovered_;

		[Cpp2IlInjected.Token(Token = "0x170017AB")]
		public static CookingData Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6005E10")]
			[Cpp2IlInjected.Address(RVA = "0x32823E0", Offset = "0x3280DE0", VA = "0x1832823E0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return ProtoDatabase.Instance.Get<CookingData>("Cooking");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017AC")]
		public Item CombustibleItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005E11")]
			[Cpp2IlInjected.Address(RVA = "0x32822B0", Offset = "0x3280CB0", VA = "0x1832822B0")]
			get
			{
				long num = Convert.ToInt64((uint)combustibleItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017AD")]
		public Item UnlockBuildingItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005E12")]
			[Cpp2IlInjected.Address(RVA = "0x3282580", Offset = "0x3280F80", VA = "0x183282580", Slot = "4")]
			get
			{
				long num = Convert.ToInt64((uint)unlockBuildingItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017AE")]
		public Item RestaurantHostItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005E13")]
			[Cpp2IlInjected.Address(RVA = "0x3282520", Offset = "0x3280F20", VA = "0x183282520")]
			get
			{
				long num = Convert.ToInt64((uint)restaurantHost_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017AF")]
		[DebuggerNonUserCode]
		public static MessageParser<CookingData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005E1E")]
			[Cpp2IlInjected.Address(RVA = "0x32824C0", Offset = "0x3280EC0", VA = "0x1832824C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005E1F")]
			[Cpp2IlInjected.Address(RVA = "0x3282310", Offset = "0x3280D10", VA = "0x183282310")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005E20")]
			[Cpp2IlInjected.Address(RVA = "0x32825E0", Offset = "0x3280FE0", VA = "0x1832825E0", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B2")]
		[DebuggerNonUserCode]
		public float NumberOfCorrectIngredientsWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6005E24")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get
			{
				return numberOfCorrectIngredientsWeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E25")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			set
			{
				numberOfCorrectIngredientsWeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B3")]
		[DebuggerNonUserCode]
		public float NumberOfCorrectTypesWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6005E26")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320")]
			get
			{
				return numberOfCorrectTypesWeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E27")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			set
			{
				numberOfCorrectTypesWeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B4")]
		[DebuggerNonUserCode]
		public float NumberOfWrongIngredientsWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6005E28")]
			[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
			get
			{
				return numberOfWrongIngredientsWeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E29")]
			[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
			set
			{
				numberOfWrongIngredientsWeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B5")]
		[DebuggerNonUserCode]
		public float NumberOfMissingIngredientsWeight
		{
			[Cpp2IlInjected.Token(Token = "0x6005E2A")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF70", Offset = "0xA7C970", VA = "0x180A7DF70")]
			get
			{
				return numberOfMissingIngredientsWeight_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E2B")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF90", Offset = "0xA7C990", VA = "0x180A7DF90")]
			set
			{
				numberOfMissingIngredientsWeight_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B6")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.RecipeStarResult> RecipeStarResults
		{
			[Cpp2IlInjected.Token(Token = "0x6005E2C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return recipeStarResults_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B7")]
		[DebuggerNonUserCode]
		public int CombustibleItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6005E2D")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return combustibleItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E2E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				combustibleItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B8")]
		[DebuggerNonUserCode]
		public int CombustileAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6005E2F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return combustileAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E30")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				combustileAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B9")]
		[DebuggerNonUserCode]
		public int PreviousRecipeHistoryLength
		{
			[Cpp2IlInjected.Token(Token = "0x6005E31")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return previousRecipeHistoryLength_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E32")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				previousRecipeHistoryLength_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BA")]
		[DebuggerNonUserCode]
		public int FriendshipAmountPerStar
		{
			[Cpp2IlInjected.Token(Token = "0x6005E33")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return friendshipAmountPerStar_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E34")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				friendshipAmountPerStar_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BB")]
		[DebuggerNonUserCode]
		public int PercentageOfSellPriceReward
		{
			[Cpp2IlInjected.Token(Token = "0x6005E35")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return percentageOfSellPriceReward_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E36")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				percentageOfSellPriceReward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BC")]
		[DebuggerNonUserCode]
		public int RestaurantHost
		{
			[Cpp2IlInjected.Token(Token = "0x6005E37")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return restaurantHost_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E38")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set
			{
				restaurantHost_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BD")]
		[DebuggerNonUserCode]
		public int UnlockBuildingItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6005E39")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return unlockBuildingItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E3A")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				unlockBuildingItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BE")]
		[DebuggerNonUserCode]
		public int BaseManaRecovered
		{
			[Cpp2IlInjected.Token(Token = "0x6005E3B")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return baseManaRecovered_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E3C")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				baseManaRecovered_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BF")]
		[DebuggerNonUserCode]
		public int MaxManaRecovered
		{
			[Cpp2IlInjected.Token(Token = "0x6005E3D")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return maxManaRecovered_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005E3E")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				maxManaRecovered_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E14")]
		[Cpp2IlInjected.Address(RVA = "0x3281200", Offset = "0x327FC00", VA = "0x183281200")]
		public int GetNumberOfCorrectIngredientsWeight()
		{
			//IL_000d: Expected I4, but got O
			float num = numberOfCorrectIngredientsWeight_;
			return (int)typeof(Math).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E15")]
		[Cpp2IlInjected.Address(RVA = "0x3281270", Offset = "0x327FC70", VA = "0x183281270")]
		public int GetNumberOfCorrectTypesWeight()
		{
			//IL_000d: Expected I4, but got O
			float num = numberOfCorrectTypesWeight_;
			return (int)typeof(Math).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E16")]
		[Cpp2IlInjected.Address(RVA = "0x3281350", Offset = "0x327FD50", VA = "0x183281350")]
		public int GetNumberOfWrongIngredientsWeight()
		{
			//IL_000d: Expected I4, but got O
			float num = numberOfWrongIngredientsWeight_;
			return (int)typeof(Math).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E17")]
		[Cpp2IlInjected.Address(RVA = "0x32812E0", Offset = "0x327FCE0", VA = "0x1832812E0")]
		public int GetNumberOfMissingIngredientsWeight()
		{
			//IL_000d: Expected I4, but got O
			float num = numberOfMissingIngredientsWeight_;
			return (int)typeof(Math).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E18")]
		[Cpp2IlInjected.Address(RVA = "0x327F8C0", Offset = "0x327E2C0", VA = "0x18327F8C0")]
		public int CalculateCookingValue(int numberOfCorrectIngredients, int numberOfCorrectTypes, int numberOfMissingIngredients, int numberOfWrongIngredients)
		{
			//IL_0006: Expected I4, but got O
			return (int)typeof(Math).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E19")]
		[Cpp2IlInjected.Address(RVA = "0x327FC50", Offset = "0x327E650", VA = "0x18327FC50")]
		public int CalculateFinalValue(int cookingValue, int ingredientsCount)
		{
			//IL_0006: Expected I8, but got I4
			long num = cookingValue * 100;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E1A")]
		[Cpp2IlInjected.Address(RVA = "0x327FA80", Offset = "0x327E480", VA = "0x18327FA80")]
		public int CalculateFinalValue(int numberOfCorrectIngredients, int numberOfCorrectTypes, int numberOfMissingIngredients, int numberOfWrongIngredients, int ingredientsCount)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected I8, but got Unknown
			long num = typeof(Math).TypeHandle * 100;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E1B")]
		[Cpp2IlInjected.Address(RVA = "0x3280110", Offset = "0x327EB10", VA = "0x183280110")]
		public int CalculateStarValue(int finalValue)
		{
			//Discarded unreachable code: IL_0068
			RepeatedField<Types.RecipeStarResult> repeatedField = recipeStarResults_;
			Func<Types.RecipeStarResult, bool> func = (Func<Types.RecipeStarResult, bool>)(object)(Func<T, TResult>)delegate(Types.RecipeStarResult x)
			{
				//Discarded unreachable code: IL_001f
				int num = finalValue;
				if (num < x.minDiscoveredInfoPercentage_)
				{
					int num2 = 0;
				}
				return num <= x.maxDiscoveredInfoPercentage_;
			};
			Types.RecipeStarResult recipeStarResult = Enumerable.FirstOrDefault<Types.RecipeStarResult>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			if (recipeStarResult == null)
			{
				RepeatedField<Types.RecipeStarResult> repeatedField2 = recipeStarResults_;
				Func<Types.RecipeStarResult, int> _003C_003E9__15_ = _003C_003Ec._003C_003E9__15_1;
				if (_003C_003E9__15_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Types.RecipeStarResult x) => x.star_);
				}
				Types.RecipeStarResult recipeStarResult2 = MoreLinq.MinBy<Types.RecipeStarResult, int>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)_003C_003E9__15_);
			}
			return recipeStarResult.star_;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E1C")]
		[Cpp2IlInjected.Address(RVA = "0x327FF30", Offset = "0x327E930", VA = "0x18327FF30")]
		public int CalculateStarValue(int numberOfCorrectIngredients, int numberOfCorrectTypes, int numberOfMissingIngredients, int numberOfWrongIngredients, int ingredientsCount)
		{
			//IL_0006: Expected I8, but got I4
			//IL_000d: Expected I4, but got I8
			long num = numberOfCorrectTypes * 100;
			return CalculateStarValue((int)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E1D")]
		[Cpp2IlInjected.Address(RVA = "0x3280620", Offset = "0x327F020", VA = "0x183280620", Slot = "5")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0086
			//IL_005c: Expected I4, but got I8
			//IL_0076: Expected O, but got I8
			int num = restaurantHost_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				context.AddInvalidMemberError("Cannot be None (Should be Remy)", "RestaurantHost");
			}
			PlayerInfo playerInfo = ProtoDatabase.Instance.Get<PlayerInfo>("PlayerInfo");
			ManaData manaData = ProtoDatabase.Instance.Get<ManaData>("ManaInfo");
			int maximumManaAmount_ = ((IEnumerable<>)(object)playerInfo.playerLevels_).Last<PlayerLevel>().maximumManaAmount_;
			ulong num2 = num2 + num2;
			maximumManaAmount_ = (int)((long)maximumManaAmount_ + (long)num2);
			if (maxManaRecovered_ != maximumManaAmount_)
			{
				string message = string.Format("{0} must be set to {1}", "MaxManaRecovered", num2);
				context.AddInvalidMemberError(message, "MaxManaRecovered");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E21")]
		[Cpp2IlInjected.Address(RVA = "0x32820E0", Offset = "0x3280AE0", VA = "0x1832820E0")]
		[DebuggerNonUserCode]
		public CookingData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005E22")]
		[Cpp2IlInjected.Address(RVA = "0x3282160", Offset = "0x3280B60", VA = "0x183282160")]
		[DebuggerNonUserCode]
		public CookingData(CookingData other)
		{
			float num = (numberOfCorrectIngredientsWeight_ = other.numberOfCorrectIngredientsWeight_);
			float num2 = (numberOfCorrectTypesWeight_ = other.numberOfCorrectTypesWeight_);
			float num3 = (numberOfWrongIngredientsWeight_ = other.numberOfWrongIngredientsWeight_);
			float num4 = (numberOfMissingIngredientsWeight_ = other.numberOfMissingIngredientsWeight_);
			RepeatedField<Types.RecipeStarResult> repeatedField = (recipeStarResults_ = (RepeatedField<Types.RecipeStarResult>)(object)((RepeatedField<T>)(object)other.recipeStarResults_).Clone());
			int num5 = (combustibleItemID_ = other.combustibleItemID_);
			int num6 = (combustileAmount_ = other.combustileAmount_);
			int num7 = (previousRecipeHistoryLength_ = other.previousRecipeHistoryLength_);
			int num8 = (friendshipAmountPerStar_ = other.friendshipAmountPerStar_);
			int num9 = (percentageOfSellPriceReward_ = other.percentageOfSellPriceReward_);
			int num10 = (restaurantHost_ = other.restaurantHost_);
			int num11 = (unlockBuildingItemID_ = other.unlockBuildingItemID_);
			int num12 = (baseManaRecovered_ = other.baseManaRecovered_);
			int num13 = (maxManaRecovered_ = other.maxManaRecovered_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E23")]
		[Cpp2IlInjected.Address(RVA = "0x32804A0", Offset = "0x327EEA0", VA = "0x1832804A0", Slot = "12")]
		[DebuggerNonUserCode]
		public CookingData Clone()
		{
			//Discarded unreachable code: IL_010b
			CookingData cookingData = new CookingData();
			RepeatedField<Types.RecipeStarResult> repeatedField = (cookingData.recipeStarResults_ = (RepeatedField<Types.RecipeStarResult>)(object)new RepeatedField<T>());
			float num = (cookingData.numberOfCorrectIngredientsWeight_ = numberOfCorrectIngredientsWeight_);
			float num2 = (cookingData.numberOfCorrectTypesWeight_ = numberOfCorrectTypesWeight_);
			float num3 = (cookingData.numberOfWrongIngredientsWeight_ = numberOfWrongIngredientsWeight_);
			float num4 = (cookingData.numberOfMissingIngredientsWeight_ = numberOfMissingIngredientsWeight_);
			RepeatedField<Types.RecipeStarResult> repeatedField2 = (cookingData.recipeStarResults_ = (RepeatedField<Types.RecipeStarResult>)(object)((RepeatedField<T>)(object)recipeStarResults_).Clone());
			int num5 = (cookingData.combustibleItemID_ = combustibleItemID_);
			int num6 = (cookingData.combustileAmount_ = combustileAmount_);
			int num7 = (cookingData.previousRecipeHistoryLength_ = previousRecipeHistoryLength_);
			int num8 = (cookingData.friendshipAmountPerStar_ = friendshipAmountPerStar_);
			int num9 = (cookingData.percentageOfSellPriceReward_ = percentageOfSellPriceReward_);
			int num10 = (cookingData.restaurantHost_ = restaurantHost_);
			int num11 = (cookingData.unlockBuildingItemID_ = unlockBuildingItemID_);
			int num12 = (cookingData.baseManaRecovered_ = baseManaRecovered_);
			int num13 = (cookingData.maxManaRecovered_ = maxManaRecovered_);
			UnknownFieldSet unknownFieldSet = (cookingData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return cookingData;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E3F")]
		[Cpp2IlInjected.Address(RVA = "0x3280940", Offset = "0x327F340", VA = "0x183280940", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CookingData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E40")]
		[Cpp2IlInjected.Address(RVA = "0x32809A0", Offset = "0x327F3A0", VA = "0x1832809A0", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(CookingData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					RepeatedField<Types.RecipeStarResult> repeatedField = recipeStarResults_;
					RepeatedField<Types.RecipeStarResult> repeatedField2 = other.recipeStarResults_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						int num = other.combustibleItemID_;
						if (combustibleItemID_ == num)
						{
							int num2 = other.combustileAmount_;
							if (combustileAmount_ == num2)
							{
								int num3 = other.previousRecipeHistoryLength_;
								if (previousRecipeHistoryLength_ == num3)
								{
									int num4 = other.friendshipAmountPerStar_;
									if (friendshipAmountPerStar_ == num4)
									{
										int num5 = other.percentageOfSellPriceReward_;
										if (percentageOfSellPriceReward_ == num5)
										{
											int num6 = other.restaurantHost_;
											if (restaurantHost_ == num6)
											{
												int num7 = other.unlockBuildingItemID_;
												if (unlockBuildingItemID_ == num7)
												{
													int num8 = other.baseManaRecovered_;
													if (baseManaRecovered_ == num8)
													{
														int num9 = other.maxManaRecovered_;
														if (maxManaRecovered_ == num9)
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
			}
			int num10 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E41")]
		[Cpp2IlInjected.Address(RVA = "0x3280DF0", Offset = "0x327F7F0", VA = "0x183280DF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0099
			while (ProtobufEqualityComparers.BitwiseSingleEqualityComparer == null || ProtobufEqualityComparers.BitwiseSingleEqualityComparer == null)
			{
			}
			if (ProtobufEqualityComparers.BitwiseSingleEqualityComparer != null)
			{
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			}
			int hashCode = ((RepeatedField<T>)(object)recipeStarResults_).GetHashCode();
			if (combustibleItemID_ != 0)
			{
			}
			if (combustileAmount_ != 0)
			{
			}
			if (previousRecipeHistoryLength_ != 0)
			{
			}
			if (friendshipAmountPerStar_ != 0)
			{
			}
			if (percentageOfSellPriceReward_ != 0)
			{
			}
			if (restaurantHost_ != 0)
			{
			}
			if (unlockBuildingItemID_ != 0)
			{
			}
			if (baseManaRecovered_ != 0)
			{
			}
			if (maxManaRecovered_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E42")]
		[Cpp2IlInjected.Address(RVA = "0x3281BA0", Offset = "0x32805A0", VA = "0x183281BA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E43")]
		[Cpp2IlInjected.Address(RVA = "0x3281C00", Offset = "0x3280600", VA = "0x183281C00", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0154
			float value = numberOfCorrectIngredientsWeight_;
			output.WriteFloat(value);
			if (output != null)
			{
				float value2 = numberOfCorrectTypesWeight_;
				output.WriteFloat(value2);
			}
			if (output != null)
			{
				float value3 = numberOfWrongIngredientsWeight_;
				output.WriteFloat(value3);
			}
			if (output != null)
			{
				float value4 = numberOfMissingIngredientsWeight_;
				output.WriteFloat(value4);
			}
			RepeatedField<Types.RecipeStarResult> repeatedField = recipeStarResults_;
			FieldCodec<Types.RecipeStarResult> repeated_recipeStarResults_codec = _repeated_recipeStarResults_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_recipeStarResults_codec);
			if (combustibleItemID_ != 0)
			{
				int value5 = combustibleItemID_;
				output.WriteInt32(value5);
			}
			if (combustileAmount_ != 0)
			{
				int value6 = combustileAmount_;
				output.WriteInt32(value6);
			}
			if (previousRecipeHistoryLength_ != 0)
			{
				int value7 = previousRecipeHistoryLength_;
				output.WriteInt32(value7);
			}
			if (friendshipAmountPerStar_ != 0)
			{
				int value8 = friendshipAmountPerStar_;
				output.WriteInt32(value8);
			}
			if (percentageOfSellPriceReward_ != 0)
			{
				int value9 = percentageOfSellPriceReward_;
				output.WriteInt32(value9);
			}
			if (restaurantHost_ != 0)
			{
				int value10 = restaurantHost_;
				output.WriteInt32(value10);
			}
			if (unlockBuildingItemID_ != 0)
			{
				int value11 = unlockBuildingItemID_;
				output.WriteInt32(value11);
			}
			if (baseManaRecovered_ != 0)
			{
				int value12 = baseManaRecovered_;
				output.WriteInt32(value12);
			}
			if (maxManaRecovered_ != 0)
			{
				int value13 = maxManaRecovered_;
				output.WriteInt32(value13);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E44")]
		[Cpp2IlInjected.Address(RVA = "0x327FC60", Offset = "0x327E660", VA = "0x18327FC60", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			uint num = num + 5;
			num += 5;
			num += 5;
			RepeatedField<Types.RecipeStarResult> repeatedField = recipeStarResults_;
			FieldCodec<Types.RecipeStarResult> repeated_recipeStarResults_codec = _repeated_recipeStarResults_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_recipeStarResults_codec);
			int num3 = combustibleItemID_;
			num += (uint)num2;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += (uint)num4;
			}
			int num5 = combustileAmount_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += (uint)num6;
			}
			int num7 = previousRecipeHistoryLength_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num += (uint)num8;
			}
			int num9 = friendshipAmountPerStar_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num += (uint)num10;
			}
			int num11 = percentageOfSellPriceReward_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num += (uint)num12;
			}
			int num13 = restaurantHost_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num += (uint)num14;
			}
			int num15 = unlockBuildingItemID_;
			if (num15 != 0)
			{
				int num16 = CodedOutputStream.ComputeInt32Size(num15);
				num16++;
				num += (uint)num16;
			}
			int num17 = baseManaRecovered_;
			if (num17 != 0)
			{
				int num18 = CodedOutputStream.ComputeInt32Size(num17);
				num18++;
				num += (uint)num18;
			}
			int num19 = maxManaRecovered_;
			if (num19 != 0)
			{
				int num20 = CodedOutputStream.ComputeInt32Size(num19);
				num20++;
				num += (uint)num20;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num21 = unknownFields.CalculateSize();
				num += (uint)num21;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E45")]
		[Cpp2IlInjected.Address(RVA = "0x32813C0", Offset = "0x327FDC0", VA = "0x1832813C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CookingData other)
		{
			//Discarded unreachable code: IL_0145
			if (other != null)
			{
				float num = other.numberOfCorrectIngredientsWeight_;
				if (other != null)
				{
					numberOfCorrectIngredientsWeight_ = num;
				}
				float num2 = other.numberOfCorrectTypesWeight_;
				if (other != null)
				{
					numberOfCorrectTypesWeight_ = num2;
				}
				float num3 = other.numberOfWrongIngredientsWeight_;
				if (other != null)
				{
					numberOfWrongIngredientsWeight_ = num3;
				}
				float num4 = other.numberOfMissingIngredientsWeight_;
				if (other != null)
				{
					numberOfMissingIngredientsWeight_ = num4;
				}
				RepeatedField<Types.RecipeStarResult> repeatedField = recipeStarResults_;
				RepeatedField<Types.RecipeStarResult> repeatedField2 = other.recipeStarResults_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num5 = other.combustibleItemID_;
				if (num5 != 0)
				{
					combustibleItemID_ = num5;
				}
				int num6 = other.combustileAmount_;
				if (num6 != 0)
				{
					combustileAmount_ = num6;
				}
				int num7 = other.previousRecipeHistoryLength_;
				if (num7 != 0)
				{
					previousRecipeHistoryLength_ = num7;
				}
				int num8 = other.friendshipAmountPerStar_;
				if (num8 != 0)
				{
					friendshipAmountPerStar_ = num8;
				}
				int num9 = other.percentageOfSellPriceReward_;
				if (num9 != 0)
				{
					percentageOfSellPriceReward_ = num9;
				}
				int num10 = other.restaurantHost_;
				if (num10 != 0)
				{
					restaurantHost_ = num10;
				}
				int num11 = other.unlockBuildingItemID_;
				if (num11 != 0)
				{
					unlockBuildingItemID_ = num11;
				}
				int num12 = other.baseManaRecovered_;
				if (num12 != 0)
				{
					baseManaRecovered_ = num12;
				}
				int num13 = other.maxManaRecovered_;
				if (num13 != 0)
				{
					maxManaRecovered_ = num13;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E46")]
		[Cpp2IlInjected.Address(RVA = "0x32814F0", Offset = "0x327FEF0", VA = "0x1832814F0", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0189
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 56)
			{
				if ((int)num > 88)
				{
					if ((int)num > 104)
					{
						if (num == 112)
						{
							int num2 = (baseManaRecovered_ = input.ReadInt32());
						}
						if (num != 120)
						{
							goto IL_0172;
						}
						int num3 = (maxManaRecovered_ = input.ReadInt32());
					}
					int num4 = default(int);
					if (num == 96)
					{
						num4 = (restaurantHost_ = input.ReadInt32());
					}
					if (num4 != 104)
					{
						goto IL_0172;
					}
					int num5 = (unlockBuildingItemID_ = input.ReadInt32());
				}
				int num6 = default(int);
				if (num == 72)
				{
					num6 = (previousRecipeHistoryLength_ = input.ReadInt32());
				}
				int num7 = default(int);
				if (num6 == 80)
				{
					num7 = (friendshipAmountPerStar_ = input.ReadInt32());
				}
				if (num7 != 88)
				{
					goto IL_0172;
				}
				int num8 = (percentageOfSellPriceReward_ = input.ReadInt32());
			}
			int num10 = default(int);
			if ((int)num > 29)
			{
				if ((int)num > 42)
				{
					int num9 = default(int);
					if (num == 48)
					{
						num9 = (combustibleItemID_ = input.ReadInt32());
					}
					if (num9 != 56)
					{
						goto IL_0172;
					}
					num10 = (combustileAmount_ = input.ReadInt32());
				}
				if (num10 == 37)
				{
					float num11 = (numberOfMissingIngredientsWeight_ = input.ReadFloat());
				}
				if (num10 != 42)
				{
					goto IL_0172;
				}
				RepeatedField<Types.RecipeStarResult> repeatedField = recipeStarResults_;
				FieldCodec<Types.RecipeStarResult> repeated_recipeStarResults_codec = _repeated_recipeStarResults_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_recipeStarResults_codec);
			}
			if (num10 == 13)
			{
				float num12 = (numberOfCorrectIngredientsWeight_ = input.ReadFloat());
			}
			if (num10 == 21)
			{
				float num13 = (numberOfCorrectTypesWeight_ = input.ReadFloat());
			}
			if (num10 == 29)
			{
				float num14 = (numberOfWrongIngredientsWeight_ = input.ReadFloat());
			}
			goto IL_0172;
			IL_0172:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005E47")]
		[Cpp2IlInjected.Address(RVA = "0x3280BE0", Offset = "0x327F5E0", VA = "0x183280BE0", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 14)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E48")]
		[Cpp2IlInjected.Address(RVA = "0x3281740", Offset = "0x3280140", VA = "0x183281740", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b
			//IL_000e: Expected F4, but got O
			if (fieldNumber - 1 <= 14)
			{
				object obj = default(object);
				numberOfCorrectIngredientsWeight_ = (float)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E49")]
		[Cpp2IlInjected.Address(RVA = "0x3280300", Offset = "0x327ED00", VA = "0x183280300", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001f
			if (fieldNumber - 1 <= 14)
			{
				numberOfCorrectIngredientsWeight_ = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E4A")]
		[Cpp2IlInjected.Address(RVA = "0x3281F10", Offset = "0x3280910", VA = "0x183281F10")]
		static CookingData()
		{
			MessageParser<Types.RecipeStarResult> parser = Types.RecipeStarResult._parser;
			uint num = default(uint);
			_parser = (MessageParser<CookingData>)(object)FieldCodec.ForMessage<Types.RecipeStarResult>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
