using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004DE")]
	public sealed class MissionItemGenerator : IMessage<MissionItemGenerator>, IMessage, IEquatable<MissionItemGenerator>, IDeepCloneable<MissionItemGenerator>, IMessageFieldAccessor, IHasTagsRnd, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40019E6")]
		private static readonly MessageParser<MissionItemGenerator> _parser = (MessageParser<MissionItemGenerator>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MissionItemGenerator()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40019E7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40019E8")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019E9")]
		private GeneratorItem item_;

		[Cpp2IlInjected.Token(Token = "0x40019EA")]
		public const int ItemIngredientFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019EB")]
		private GeneratorItemIngredient itemIngredient_;

		[Cpp2IlInjected.Token(Token = "0x40019EC")]
		public const int TypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40019ED")]
		private ItemType type_;

		[Cpp2IlInjected.Token(Token = "0x40019EE")]
		public const int ActivityItemTypeFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40019EF")]
		private ActivityItemType activityItemType_;

		[Cpp2IlInjected.Token(Token = "0x40019F0")]
		public const int SetFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40019F1")]
		private int set_;

		[Cpp2IlInjected.Token(Token = "0x40019F2")]
		public const int ComplexityFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40019F3")]
		private OptionalField complexity_;

		[Cpp2IlInjected.Token(Token = "0x40019F4")]
		public const int MoodFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40019F5")]
		private OptionalField mood_;

		[Cpp2IlInjected.Token(Token = "0x40019F6")]
		public const int SturdinessFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40019F7")]
		private OptionalField sturdiness_;

		[Cpp2IlInjected.Token(Token = "0x40019F8")]
		public const int NormalityFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40019F9")]
		private OptionalField normality_;

		[Cpp2IlInjected.Token(Token = "0x40019FA")]
		public const int MinRarityFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40019FB")]
		private StepAmount minRarity_;

		[Cpp2IlInjected.Token(Token = "0x40019FC")]
		public const int MaxRarityFieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40019FD")]
		private StepAmount maxRarity_;

		[Cpp2IlInjected.Token(Token = "0x40019FE")]
		public const int FishLocationFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40019FF")]
		private OptionalField fishLocation_;

		[Cpp2IlInjected.Token(Token = "0x4001A00")]
		public const int FishRarityFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001A01")]
		private OptionalField fishRarity_;

		[Cpp2IlInjected.Token(Token = "0x4001A02")]
		public const int FishConstraintFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001A03")]
		private string fishConstraint_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001A04")]
		public const int FishWeatherFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001A05")]
		private string fishWeather_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001A06")]
		public const int FishIncludeTrashFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001A07")]
		private bool fishIncludeTrash_;

		[Cpp2IlInjected.Token(Token = "0x4001A08")]
		public const int RequireAtLeastOneTagFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4001A09")]
		private bool requireAtLeastOneTag_;

		[Cpp2IlInjected.Token(Token = "0x4001A0A")]
		public const int TagsFieldNumber = 26;

		[Cpp2IlInjected.Token(Token = "0x4001A0B")]
		private static readonly FieldCodec<TagGroupWithRndOption> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001A0C")]
		private readonly RepeatedField<TagGroupWithRndOption> tags_ = (RepeatedField<TagGroupWithRndOption>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001A0D")]
		public const int CropTypeFieldNumber = 27;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001A0E")]
		private CropTypeCondition cropType_;

		[Cpp2IlInjected.Token(Token = "0x4001A0F")]
		public const int SeedTypeFieldNumber = 28;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4001A10")]
		private SeedTypeCondition seedType_;

		[Cpp2IlInjected.Token(Token = "0x4001A11")]
		public const int FlowerRarityFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001A12")]
		private FlowerRarityCondition flowerRarity_;

		[Cpp2IlInjected.Token(Token = "0x4001A13")]
		public const int IngredientsTypeFieldNumber = 31;

		[Cpp2IlInjected.Token(Token = "0x4001A14")]
		private static readonly FieldCodec<int> _repeated_ingredientsType_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001A15")]
		private readonly RepeatedField<int> ingredientsType_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001A16")]
		public const int MinMealStarRatingFieldNumber = 40;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001A17")]
		private StepAmount minMealStarRating_;

		[Cpp2IlInjected.Token(Token = "0x4001A18")]
		public const int MinUnlockLevelFieldNumber = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001A19")]
		private ScalableValue minUnlockLevel_;

		[Cpp2IlInjected.Token(Token = "0x4001A1A")]
		public const int MaxUnlockLevelFieldNumber = 51;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001A1B")]
		private ScalableValue maxUnlockLevel_;

		[Cpp2IlInjected.Token(Token = "0x4001A1C")]
		public const int MineralRoughnessFieldNumber = 52;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001A1D")]
		private MineralRoughness mineralRoughness_;

		[Cpp2IlInjected.Token(Token = "0x4001A1E")]
		public const int EphemeralTypeFieldNumber = 53;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4001A1F")]
		private EphemeralTypeCondition ephemeralType_;

		[Cpp2IlInjected.Token(Token = "0x4001A20")]
		public const int ProfessionFieldNumber = 54;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001A21")]
		private int profession_;

		[Cpp2IlInjected.Token(Token = "0x4001A22")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x17000F51")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionItemGenerator> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003BDB")]
			[Cpp2IlInjected.Address(RVA = "0x3711B30", Offset = "0x3710530", VA = "0x183711B30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F52")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003BDC")]
			[Cpp2IlInjected.Address(RVA = "0x3711A60", Offset = "0x3710460", VA = "0x183711A60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F53")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003BDD")]
			[Cpp2IlInjected.Address(RVA = "0x37120F0", Offset = "0x3710AF0", VA = "0x1837120F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F54")]
		[DebuggerNonUserCode]
		public GeneratorItem Item
		{
			[Cpp2IlInjected.Token(Token = "0x6003BE2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BE3")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				item_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F55")]
		[DebuggerNonUserCode]
		public GeneratorItemIngredient ItemIngredient
		{
			[Cpp2IlInjected.Token(Token = "0x6003BE4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemIngredient_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BE5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				itemIngredient_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F56")]
		[DebuggerNonUserCode]
		public ItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6003BE6")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BE7")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F57")]
		[DebuggerNonUserCode]
		public ActivityItemType ActivityItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6003BE8")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return activityItemType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BE9")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				activityItemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F58")]
		[DebuggerNonUserCode]
		public int Set
		{
			[Cpp2IlInjected.Token(Token = "0x6003BEA")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return set_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BEB")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				set_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F59")]
		[DebuggerNonUserCode]
		public OptionalField Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x6003BEC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return complexity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BED")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				complexity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5A")]
		[DebuggerNonUserCode]
		public OptionalField Mood
		{
			[Cpp2IlInjected.Token(Token = "0x6003BEE")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return mood_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BEF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				mood_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5B")]
		[DebuggerNonUserCode]
		public OptionalField Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF0")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return sturdiness_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BF1")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				sturdiness_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5C")]
		[DebuggerNonUserCode]
		public OptionalField Normality
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF2")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return normality_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BF3")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				normality_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5D")]
		[DebuggerNonUserCode]
		public StepAmount MinRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF4")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return minRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BF5")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				minRarity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5E")]
		[DebuggerNonUserCode]
		public StepAmount MaxRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF6")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return maxRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BF7")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				maxRarity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F5F")]
		[DebuggerNonUserCode]
		public OptionalField FishLocation
		{
			[Cpp2IlInjected.Token(Token = "0x6003BF8")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return fishLocation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BF9")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			set
			{
				fishLocation_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F60")]
		[DebuggerNonUserCode]
		public OptionalField FishRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6003BFA")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return fishRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BFB")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			set
			{
				fishRarity_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F61")]
		[DebuggerNonUserCode]
		public string FishConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6003BFC")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return fishConstraint_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BFD")]
			[Cpp2IlInjected.Address(RVA = "0x3712200", Offset = "0x3710C00", VA = "0x183712200")]
			set
			{
				string text = (fishConstraint_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F62")]
		[DebuggerNonUserCode]
		public string FishWeather
		{
			[Cpp2IlInjected.Token(Token = "0x6003BFE")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return fishWeather_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BFF")]
			[Cpp2IlInjected.Address(RVA = "0x3712270", Offset = "0x3710C70", VA = "0x183712270")]
			set
			{
				string text = (fishWeather_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F63")]
		[DebuggerNonUserCode]
		public bool FishIncludeTrash
		{
			[Cpp2IlInjected.Token(Token = "0x6003C00")]
			[Cpp2IlInjected.Address(RVA = "0xBD6330", Offset = "0xBD4D30", VA = "0x180BD6330")]
			get
			{
				return fishIncludeTrash_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C01")]
			[Cpp2IlInjected.Address(RVA = "0x102A930", Offset = "0x1029330", VA = "0x18102A930")]
			set
			{
				fishIncludeTrash_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F64")]
		[DebuggerNonUserCode]
		public bool RequireAtLeastOneTag
		{
			[Cpp2IlInjected.Token(Token = "0x6003C02")]
			[Cpp2IlInjected.Address(RVA = "0x3711B90", Offset = "0x3710590", VA = "0x183711B90")]
			get
			{
				return requireAtLeastOneTag_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C03")]
			[Cpp2IlInjected.Address(RVA = "0x37122E0", Offset = "0x3710CE0", VA = "0x1837122E0")]
			set
			{
				requireAtLeastOneTag_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F65")]
		[DebuggerNonUserCode]
		public RepeatedField<TagGroupWithRndOption> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6003C04")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0", Slot = "15")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F66")]
		[DebuggerNonUserCode]
		public CropTypeCondition CropType
		{
			[Cpp2IlInjected.Token(Token = "0x6003C05")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get
			{
				return cropType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C06")]
			[Cpp2IlInjected.Address(RVA = "0x1373C40", Offset = "0x1372640", VA = "0x181373C40")]
			set
			{
				cropType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F67")]
		[DebuggerNonUserCode]
		public SeedTypeCondition SeedType
		{
			[Cpp2IlInjected.Token(Token = "0x6003C07")]
			[Cpp2IlInjected.Address(RVA = "0x1EA0390", Offset = "0x1E9ED90", VA = "0x181EA0390")]
			get
			{
				return seedType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C08")]
			[Cpp2IlInjected.Address(RVA = "0x22DD580", Offset = "0x22DBF80", VA = "0x1822DD580")]
			set
			{
				seedType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F68")]
		[DebuggerNonUserCode]
		public FlowerRarityCondition FlowerRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6003C09")]
			[Cpp2IlInjected.Address(RVA = "0x975DB0", Offset = "0x9747B0", VA = "0x180975DB0")]
			get
			{
				return flowerRarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C0A")]
			[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x974F80", VA = "0x180976580")]
			set
			{
				flowerRarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F69")]
		[DebuggerNonUserCode]
		public RepeatedField<int> IngredientsType
		{
			[Cpp2IlInjected.Token(Token = "0x6003C0B")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return ingredientsType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6A")]
		[DebuggerNonUserCode]
		public StepAmount MinMealStarRating
		{
			[Cpp2IlInjected.Token(Token = "0x6003C0C")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return minMealStarRating_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C0D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
			set
			{
				minMealStarRating_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6B")]
		[DebuggerNonUserCode]
		public ScalableValue MinUnlockLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6003C0E")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return minUnlockLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C0F")]
			[Cpp2IlInjected.Address(RVA = "0x9766B0", Offset = "0x9750B0", VA = "0x1809766B0")]
			set
			{
				minUnlockLevel_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6C")]
		[DebuggerNonUserCode]
		public ScalableValue MaxUnlockLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6003C10")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30")]
			get
			{
				return maxUnlockLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C11")]
			[Cpp2IlInjected.Address(RVA = "0xD2FD20", Offset = "0xD2E720", VA = "0x180D2FD20")]
			set
			{
				maxUnlockLevel_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6D")]
		[DebuggerNonUserCode]
		public MineralRoughness MineralRoughness
		{
			[Cpp2IlInjected.Token(Token = "0x6003C12")]
			[Cpp2IlInjected.Address(RVA = "0x148A270", Offset = "0x1488C70", VA = "0x18148A270")]
			get
			{
				return mineralRoughness_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C13")]
			[Cpp2IlInjected.Address(RVA = "0x148A490", Offset = "0x1488E90", VA = "0x18148A490")]
			set
			{
				mineralRoughness_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6E")]
		[DebuggerNonUserCode]
		public EphemeralTypeCondition EphemeralType
		{
			[Cpp2IlInjected.Token(Token = "0x6003C14")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A50", Offset = "0x8D5450", VA = "0x1808D6A50")]
			get
			{
				return ephemeralType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C15")]
			[Cpp2IlInjected.Address(RVA = "0x2705E80", Offset = "0x2704880", VA = "0x182705E80")]
			set
			{
				ephemeralType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F6F")]
		[DebuggerNonUserCode]
		public int Profession
		{
			[Cpp2IlInjected.Token(Token = "0x6003C16")]
			[Cpp2IlInjected.Address(RVA = "0xE58440", Offset = "0xE56E40", VA = "0x180E58440")]
			get
			{
				return profession_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C17")]
			[Cpp2IlInjected.Address(RVA = "0xE58490", Offset = "0xE56E90", VA = "0x180E58490")]
			set
			{
				profession_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F70")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6003C23")]
			[Cpp2IlInjected.Address(RVA = "0x3711BA0", Offset = "0x37105A0", VA = "0x183711BA0", Slot = "14")]
			get
			{
				bool result = default(bool);
				while (true)
				{
					if (type_ == ItemType.Character)
					{
						List<(TagItemType, int?)> list = (List<(TagItemType, int?)>)(object)Enumerable.ToList<(TagItemType, int?)>((IEnumerable<>)FurnitureItemData.usedTagTypes);
						Predicate<(TagItemType, int?)> _003C_003E9__165_ = _003C_003Ec._003C_003E9__165_0;
						if (_003C_003E9__165_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)(((TagItemType tagType, int? limit) x) => result);
						}
						if (((List<T>)(object)list).FindIndex((Predicate<>)(object)_003C_003E9__165_) == -1)
						{
							break;
						}
						int num = 0;
						if (activityItemType_ != ActivityItemType.Crop)
						{
							continue;
						}
						if ((long)CropItemData.usedTagTypes != 1)
						{
						}
					}
					List<(TagItemType, int?)> list2 = (List<(TagItemType, int?)>)(object)Enumerable.ToList<(TagItemType, int?)>((IEnumerable<>)CharacterItemData.usedTagTypes);
					break;
				}
				if (type_ <= ItemType.Character)
				{
					int num2 = 0;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BDE")]
		[Cpp2IlInjected.Address(RVA = "0x37114E0", Offset = "0x370FEE0", VA = "0x1837114E0")]
		[DebuggerNonUserCode]
		public MissionItemGenerator()
		{
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BDF")]
		[Cpp2IlInjected.Address(RVA = "0x3710010", Offset = "0x370EA10", VA = "0x183710010")]
		private void OnConstruction()
		{
			GeneratorItem generatorItem = (item_ = new GeneratorItem());
			GeneratorItemIngredient generatorItemIngredient = (itemIngredient_ = new GeneratorItemIngredient());
			OptionalField optionalField = new OptionalField();
			optionalField.useField_ = false;
			int num = (int)(optionalField.Complexity = Definitions.Items.Complexity.Lavish);
			optionalField.showRandomCheckbox_ = true;
			complexity_ = optionalField;
			OptionalField optionalField2 = new OptionalField();
			optionalField2.useField_ = false;
			int num2 = (int)(optionalField2.Mood = Definitions.Items.Mood.Calm);
			optionalField2.showRandomCheckbox_ = true;
			mood_ = optionalField2;
			OptionalField optionalField3 = new OptionalField();
			optionalField3.useField_ = false;
			int num3 = (int)(optionalField3.Sturdiness = Definitions.Items.Sturdiness.Strong);
			optionalField3.showRandomCheckbox_ = true;
			sturdiness_ = optionalField3;
			OptionalField optionalField4 = new OptionalField();
			optionalField4.useField_ = false;
			int num4 = (int)(optionalField4.Normality = Definitions.Items.Normality.Wondrous);
			optionalField4.showRandomCheckbox_ = true;
			normality_ = optionalField4;
			StepAmount stepAmount = (maxRarity_ = new StepAmount());
			StepAmount stepAmount2 = (minRarity_ = new StepAmount());
			OptionalField optionalField5 = new OptionalField();
			optionalField5.useField_ = false;
			VillageAreaList villageAreaList2 = (optionalField5.VillageAreas = new VillageAreaList());
			optionalField5.showRandomCheckbox_ = true;
			fishLocation_ = optionalField5;
			OptionalField optionalField6 = new OptionalField();
			optionalField6.useField_ = false;
			FishRarityList fishRarityList2 = (optionalField6.FishRarities = new FishRarityList());
			optionalField6.showRandomCheckbox_ = true;
			fishRarity_ = optionalField6;
			ScalableValue scalableValue = (minUnlockLevel_ = new ScalableValue());
			ScalableValue scalableValue2 = (maxUnlockLevel_ = new ScalableValue());
			StepAmount stepAmount3 = (minMealStarRating_ = new StepAmount());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BE0")]
		[Cpp2IlInjected.Address(RVA = "0x37115E0", Offset = "0x370FFE0", VA = "0x1837115E0")]
		[DebuggerNonUserCode]
		public MissionItemGenerator(MissionItemGenerator other)
		{
			//IL_0058: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			//IL_00df: Expected O, but got I4
			//IL_00fc: Expected O, but got I4
			//IL_0119: Expected O, but got I4
			//IL_0136: Expected O, but got I4
			//IL_0153: Expected O, but got I4
			//IL_0170: Expected O, but got I4
			//IL_018d: Expected O, but got I4
			//IL_0244: Expected O, but got I4
			//IL_0261: Expected O, but got I4
			OnConstruction();
			GeneratorItem generatorItem = other.item_;
			int num = 0;
			if (generatorItem != null)
			{
				GeneratorItem generatorItem2 = generatorItem.Clone();
			}
			item_ = (GeneratorItem)num;
			GeneratorItemIngredient generatorItemIngredient = other.itemIngredient_;
			if (generatorItemIngredient != null)
			{
				GeneratorItemIngredient generatorItemIngredient2 = generatorItemIngredient.Clone();
			}
			itemIngredient_ = (GeneratorItemIngredient)num;
			ItemType itemType = (type_ = other.type_);
			ActivityItemType activityItemType = (activityItemType_ = other.activityItemType_);
			int num2 = (set_ = other.set_);
			OptionalField optionalField = other.complexity_;
			if (optionalField != null)
			{
				OptionalField optionalField2 = optionalField.Clone();
			}
			complexity_ = (OptionalField)num;
			OptionalField optionalField3 = other.mood_;
			if (optionalField3 != null)
			{
				OptionalField optionalField4 = optionalField3.Clone();
			}
			mood_ = (OptionalField)num;
			OptionalField optionalField5 = other.sturdiness_;
			if (optionalField5 != null)
			{
				OptionalField optionalField6 = optionalField5.Clone();
			}
			sturdiness_ = (OptionalField)num;
			OptionalField optionalField7 = other.normality_;
			if (optionalField7 != null)
			{
				OptionalField optionalField8 = optionalField7.Clone();
			}
			normality_ = (OptionalField)num;
			StepAmount stepAmount = other.minRarity_;
			if (stepAmount != null)
			{
				StepAmount stepAmount2 = stepAmount.Clone();
			}
			minRarity_ = (StepAmount)num;
			StepAmount stepAmount3 = other.maxRarity_;
			if (stepAmount3 != null)
			{
				StepAmount stepAmount4 = stepAmount3.Clone();
			}
			maxRarity_ = (StepAmount)num;
			OptionalField optionalField9 = other.fishLocation_;
			if (optionalField9 != null)
			{
				OptionalField optionalField10 = optionalField9.Clone();
			}
			fishLocation_ = (OptionalField)num;
			OptionalField optionalField11 = other.fishRarity_;
			if (optionalField11 != null)
			{
				OptionalField optionalField12 = optionalField11.Clone();
			}
			fishRarity_ = (OptionalField)num;
			string text = (fishConstraint_ = other.fishConstraint_);
			string text2 = (fishWeather_ = other.fishWeather_);
			bool flag = (fishIncludeTrash_ = other.fishIncludeTrash_);
			bool flag2 = (requireAtLeastOneTag_ = other.requireAtLeastOneTag_);
			RepeatedField<TagGroupWithRndOption> repeatedField = (tags_ = (RepeatedField<TagGroupWithRndOption>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			CropTypeCondition cropTypeCondition = (cropType_ = other.cropType_);
			SeedTypeCondition seedTypeCondition = (seedType_ = other.seedType_);
			FlowerRarityCondition flowerRarityCondition = (flowerRarity_ = other.flowerRarity_);
			RepeatedField<int> repeatedField2 = (ingredientsType_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.ingredientsType_).Clone());
			StepAmount stepAmount5 = other.minMealStarRating_;
			if (stepAmount5 != null)
			{
				StepAmount stepAmount6 = stepAmount5.Clone();
			}
			minMealStarRating_ = (StepAmount)num;
			ScalableValue scalableValue = other.minUnlockLevel_;
			if (scalableValue != null)
			{
				ScalableValue scalableValue2 = scalableValue.Clone();
			}
			minUnlockLevel_ = (ScalableValue)num;
			ScalableValue scalableValue3 = other.maxUnlockLevel_;
			ScalableValue scalableValue4 = default(ScalableValue);
			if (scalableValue3 != null)
			{
				scalableValue4 = scalableValue3.Clone();
			}
			maxUnlockLevel_ = scalableValue4;
			MineralRoughness mineralRoughness = (mineralRoughness_ = other.mineralRoughness_);
			EphemeralTypeCondition ephemeralTypeCondition = (ephemeralType_ = other.ephemeralType_);
			int num3 = (profession_ = other.profession_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003BE1")]
		[Cpp2IlInjected.Address(RVA = "0x370E400", Offset = "0x370CE00", VA = "0x18370E400", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionItemGenerator Clone()
		{
			return new MissionItemGenerator(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C18")]
		[Cpp2IlInjected.Address(RVA = "0x370E700", Offset = "0x370D100", VA = "0x18370E700", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((MissionItemGenerator)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C19")]
		[Cpp2IlInjected.Address(RVA = "0x370E760", Offset = "0x370D160", VA = "0x18370E760", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionItemGenerator other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				GeneratorItem objB = other.item_;
				if (object.Equals(item_, objB))
				{
					GeneratorItemIngredient objB2 = other.itemIngredient_;
					if (object.Equals(itemIngredient_, objB2))
					{
						ItemType itemType = other.type_;
						if (type_ == itemType)
						{
							ActivityItemType activityItemType = other.activityItemType_;
							if (activityItemType_ == activityItemType)
							{
								int num = other.set_;
								if (set_ == num)
								{
									OptionalField objB3 = other.complexity_;
									if (object.Equals(complexity_, objB3))
									{
										OptionalField objB4 = other.mood_;
										if (object.Equals(mood_, objB4))
										{
											OptionalField objB5 = other.sturdiness_;
											if (object.Equals(sturdiness_, objB5))
											{
												OptionalField objB6 = other.normality_;
												if (object.Equals(normality_, objB6))
												{
													StepAmount objB7 = other.minRarity_;
													if (object.Equals(minRarity_, objB7))
													{
														StepAmount objB8 = other.maxRarity_;
														if (object.Equals(maxRarity_, objB8))
														{
															OptionalField objB9 = other.fishLocation_;
															if (object.Equals(fishLocation_, objB9))
															{
																OptionalField objB10 = other.fishRarity_;
																if (object.Equals(fishRarity_, objB10))
																{
																	string text = other.fishConstraint_;
																	if (!(fishConstraint_ != text))
																	{
																		string text2 = other.fishWeather_;
																		if (!(fishWeather_ != text2))
																		{
																			bool flag = other.fishIncludeTrash_;
																			if (fishIncludeTrash_ == flag)
																			{
																				bool flag2 = other.requireAtLeastOneTag_;
																				if (requireAtLeastOneTag_ == flag2)
																				{
																					RepeatedField<TagGroupWithRndOption> repeatedField = tags_;
																					RepeatedField<TagGroupWithRndOption> repeatedField2 = other.tags_;
																					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
																					{
																						CropTypeCondition cropTypeCondition = other.cropType_;
																						if (cropType_ == cropTypeCondition)
																						{
																							SeedTypeCondition seedTypeCondition = other.seedType_;
																							if (seedType_ == seedTypeCondition)
																							{
																								FlowerRarityCondition flowerRarityCondition = other.flowerRarity_;
																								if (flowerRarity_ == flowerRarityCondition)
																								{
																									RepeatedField<int> repeatedField3 = ingredientsType_;
																									RepeatedField<int> repeatedField4 = other.ingredientsType_;
																									if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
																									{
																										StepAmount objB11 = other.minMealStarRating_;
																										if (object.Equals(minMealStarRating_, objB11))
																										{
																											ScalableValue objB12 = other.minUnlockLevel_;
																											if (object.Equals(minUnlockLevel_, objB12))
																											{
																												ScalableValue objB13 = other.maxUnlockLevel_;
																												if (object.Equals(maxUnlockLevel_, objB13))
																												{
																													MineralRoughness mineralRoughness = other.mineralRoughness_;
																													if (mineralRoughness_ == mineralRoughness)
																													{
																														EphemeralTypeCondition ephemeralTypeCondition = other.ephemeralType_;
																														if (ephemeralType_ == ephemeralTypeCondition)
																														{
																															int num2 = other.profession_;
																															if (profession_ == num2)
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
							}
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C1A")]
		[Cpp2IlInjected.Address(RVA = "0x370EE90", Offset = "0x370D890", VA = "0x18370EE90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_01e1
			GeneratorItem generatorItem = item_;
			if (generatorItem != null)
			{
				int hashCode = generatorItem.GetHashCode();
			}
			GeneratorItemIngredient generatorItemIngredient = itemIngredient_;
			if (generatorItemIngredient != null)
			{
				int hashCode2 = generatorItemIngredient.GetHashCode();
			}
			if (type_ != 0)
			{
			}
			if (activityItemType_ != 0)
			{
			}
			if (set_ != 0)
			{
			}
			OptionalField optionalField = complexity_;
			if (optionalField != null)
			{
				int hashCode3 = optionalField.GetHashCode();
			}
			OptionalField optionalField2 = mood_;
			if (optionalField2 != null)
			{
				int hashCode4 = optionalField2.GetHashCode();
			}
			OptionalField optionalField3 = sturdiness_;
			if (optionalField3 != null)
			{
				int hashCode5 = optionalField3.GetHashCode();
			}
			OptionalField optionalField4 = normality_;
			if (optionalField4 != null)
			{
				int hashCode6 = optionalField4.GetHashCode();
			}
			StepAmount stepAmount = minRarity_;
			if (stepAmount != null)
			{
				int hashCode7 = stepAmount.GetHashCode();
			}
			StepAmount stepAmount2 = maxRarity_;
			if (stepAmount2 != null)
			{
				int hashCode8 = stepAmount2.GetHashCode();
			}
			OptionalField optionalField5 = fishLocation_;
			if (optionalField5 != null)
			{
				int hashCode9 = optionalField5.GetHashCode();
			}
			OptionalField optionalField6 = fishRarity_;
			if (optionalField6 != null)
			{
				int hashCode10 = optionalField6.GetHashCode();
			}
			string text = fishConstraint_;
			if (text.m_stringLength != 0)
			{
				int hashCode11 = text.GetHashCode();
			}
			string text2 = fishWeather_;
			if (text2.m_stringLength != 0)
			{
				int hashCode12 = text2.GetHashCode();
			}
			if (fishIncludeTrash_)
			{
			}
			if (requireAtLeastOneTag_)
			{
			}
			int hashCode13 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (cropType_ != 0)
			{
			}
			if (seedType_ != 0)
			{
			}
			if (flowerRarity_ != 0)
			{
			}
			int hashCode14 = ((RepeatedField<T>)(object)ingredientsType_).GetHashCode();
			StepAmount stepAmount3 = minMealStarRating_;
			if (stepAmount3 != null)
			{
				int hashCode15 = stepAmount3.GetHashCode();
			}
			ScalableValue scalableValue = minUnlockLevel_;
			if (scalableValue != null)
			{
				int hashCode16 = scalableValue.GetHashCode();
			}
			ScalableValue scalableValue2 = maxUnlockLevel_;
			if (scalableValue2 != null)
			{
				int hashCode17 = scalableValue2.GetHashCode();
			}
			if (mineralRoughness_ != 0)
			{
			}
			if (ephemeralType_ != 0)
			{
			}
			if (profession_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode18 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C1B")]
		[Cpp2IlInjected.Address(RVA = "0x3710C20", Offset = "0x370F620", VA = "0x183710C20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C1C")]
		[Cpp2IlInjected.Address(RVA = "0x3710C80", Offset = "0x370F680", VA = "0x183710C80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_027e
			if ((long)item_ != 0)
			{
				GeneratorItem value = item_;
				output.WriteMessage(value);
			}
			if ((long)itemIngredient_ != 0)
			{
				GeneratorItemIngredient value2 = itemIngredient_;
				output.WriteMessage(value2);
			}
			if (type_ != 0)
			{
			}
			if (activityItemType_ != 0)
			{
			}
			if (set_ != 0)
			{
				int value3 = set_;
				output.WriteInt32(value3);
			}
			if ((long)complexity_ != 0)
			{
				OptionalField value4 = complexity_;
				output.WriteMessage(value4);
			}
			if ((long)mood_ != 0)
			{
				OptionalField value5 = mood_;
				output.WriteMessage(value5);
			}
			if ((long)sturdiness_ != 0)
			{
				OptionalField value6 = sturdiness_;
				output.WriteMessage(value6);
			}
			if ((long)normality_ != 0)
			{
				OptionalField value7 = normality_;
				output.WriteMessage(value7);
			}
			if ((long)minRarity_ != 0)
			{
				StepAmount value8 = minRarity_;
				output.WriteMessage(value8);
			}
			if ((long)maxRarity_ != 0)
			{
				StepAmount value9 = maxRarity_;
				output.WriteMessage(value9);
			}
			if ((long)fishLocation_ != 0)
			{
				OptionalField value10 = fishLocation_;
				output.WriteMessage(value10);
			}
			if ((long)fishRarity_ != 0)
			{
				OptionalField value11 = fishRarity_;
				output.WriteMessage(value11);
			}
			if (fishConstraint_.m_stringLength != 0)
			{
				string value12 = fishConstraint_;
				output.WriteString(value12);
			}
			if (fishWeather_.m_stringLength != 0)
			{
				string value13 = fishWeather_;
				output.WriteString(value13);
			}
			if (fishIncludeTrash_)
			{
				bool value14 = fishIncludeTrash_;
				output.WriteBool(value14);
			}
			if (requireAtLeastOneTag_)
			{
				bool value15 = requireAtLeastOneTag_;
				output.WriteBool(value15);
			}
			RepeatedField<TagGroupWithRndOption> repeatedField = tags_;
			FieldCodec<TagGroupWithRndOption> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (cropType_ != 0)
			{
			}
			if (seedType_ != 0)
			{
			}
			if (flowerRarity_ != 0)
			{
			}
			RepeatedField<int> repeatedField2 = ingredientsType_;
			FieldCodec<int> repeated_ingredientsType_codec = _repeated_ingredientsType_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_ingredientsType_codec);
			if ((long)minMealStarRating_ != 0)
			{
				StepAmount value16 = minMealStarRating_;
				output.WriteMessage(value16);
			}
			if ((long)minUnlockLevel_ != 0)
			{
				ScalableValue value17 = minUnlockLevel_;
				output.WriteMessage(value17);
			}
			if ((long)maxUnlockLevel_ != 0)
			{
				ScalableValue value18 = maxUnlockLevel_;
				output.WriteMessage(value18);
			}
			if (mineralRoughness_ != 0)
			{
			}
			if (ephemeralType_ != 0)
			{
			}
			if (profession_ != 0)
			{
				int value19 = profession_;
				output.WriteInt32(value19);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C1D")]
		[Cpp2IlInjected.Address(RVA = "0x370D9D0", Offset = "0x370C3D0", VA = "0x18370D9D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0331
			GeneratorItem generatorItem = item_;
			int num = 0;
			if (generatorItem != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(generatorItem);
			}
			GeneratorItemIngredient generatorItemIngredient = itemIngredient_;
			if (generatorItemIngredient != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(generatorItemIngredient);
				num3++;
				num += num3;
			}
			ItemType itemType = type_;
			if (itemType != 0)
			{
				int num4 = CodedOutputStream.ComputeEnumSize((int)itemType);
				num4++;
				num += num4;
			}
			ActivityItemType activityItemType = activityItemType_;
			if (activityItemType != 0)
			{
				int num5 = CodedOutputStream.ComputeEnumSize((int)activityItemType);
				num5++;
				num += num5;
			}
			int num6 = set_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			OptionalField optionalField = complexity_;
			if (optionalField != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(optionalField);
				num8++;
				num += num8;
			}
			OptionalField optionalField2 = mood_;
			if (optionalField2 != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(optionalField2);
				num9++;
				num += num9;
			}
			OptionalField optionalField3 = sturdiness_;
			if (optionalField3 != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(optionalField3);
				num10++;
				num += num10;
			}
			OptionalField optionalField4 = normality_;
			if (optionalField4 != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(optionalField4);
				num11++;
				num += num11;
			}
			StepAmount stepAmount = minRarity_;
			if (stepAmount != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num12 += 2;
				num += num12;
			}
			StepAmount stepAmount2 = maxRarity_;
			if (stepAmount2 != null)
			{
				int num13 = CodedOutputStream.ComputeMessageSize(stepAmount2);
				num13 += 2;
				num += num13;
			}
			OptionalField optionalField5 = fishLocation_;
			if (optionalField5 != null)
			{
				int num14 = CodedOutputStream.ComputeMessageSize(optionalField5);
				num14 += 2;
				num += num14;
			}
			OptionalField optionalField6 = fishRarity_;
			if (optionalField6 != null)
			{
				int num15 = CodedOutputStream.ComputeMessageSize(optionalField6);
				num15 += 2;
				num += num15;
			}
			string text = fishConstraint_;
			if (text.m_stringLength != 0)
			{
				int num16 = CodedOutputStream.ComputeStringSize(text);
				num16 += 2;
				num += num16;
			}
			string text2 = fishWeather_;
			if (text2.m_stringLength != 0)
			{
				int num17 = CodedOutputStream.ComputeStringSize(text2);
				num17 += 2;
				num += num17;
			}
			RepeatedField<TagGroupWithRndOption> repeatedField = tags_;
			FieldCodec<TagGroupWithRndOption> repeated_tags_codec = _repeated_tags_codec;
			int num18 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			CropTypeCondition cropTypeCondition = cropType_;
			if (cropTypeCondition != 0)
			{
				int num19 = CodedOutputStream.ComputeEnumSize((int)cropTypeCondition);
				num19 += 2;
			}
			SeedTypeCondition seedTypeCondition = seedType_;
			if (seedTypeCondition != 0)
			{
				int num20 = CodedOutputStream.ComputeEnumSize((int)seedTypeCondition);
				num20 += 2;
			}
			FlowerRarityCondition flowerRarityCondition = flowerRarity_;
			if (flowerRarityCondition != 0)
			{
				int num21 = CodedOutputStream.ComputeEnumSize((int)flowerRarityCondition);
				num21 += 2;
			}
			RepeatedField<int> repeatedField2 = ingredientsType_;
			FieldCodec<int> repeated_ingredientsType_codec = _repeated_ingredientsType_codec;
			int num22 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_ingredientsType_codec);
			StepAmount stepAmount3 = minMealStarRating_;
			if (stepAmount3 != null)
			{
				int num23 = CodedOutputStream.ComputeMessageSize(stepAmount3);
				num23 += 2;
			}
			ScalableValue scalableValue = minUnlockLevel_;
			if (scalableValue != null)
			{
				int num24 = CodedOutputStream.ComputeMessageSize(scalableValue);
				num24 += 2;
			}
			ScalableValue scalableValue2 = maxUnlockLevel_;
			if (scalableValue2 != null)
			{
				int num25 = CodedOutputStream.ComputeMessageSize(scalableValue2);
				num25 += 2;
			}
			MineralRoughness mineralRoughness = mineralRoughness_;
			if (mineralRoughness != 0)
			{
				int num26 = CodedOutputStream.ComputeEnumSize((int)mineralRoughness);
				num26 += 2;
			}
			EphemeralTypeCondition ephemeralTypeCondition = ephemeralType_;
			if (ephemeralTypeCondition != 0)
			{
				int num27 = CodedOutputStream.ComputeEnumSize((int)ephemeralTypeCondition);
				num27 += 2;
			}
			int num28 = profession_;
			if (num28 != 0)
			{
				int num29 = CodedOutputStream.ComputeInt32Size(num28);
				num29 += 2;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num30 = unknownFields.CalculateSize();
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C1E")]
		[Cpp2IlInjected.Address(RVA = "0x370F200", Offset = "0x370DC00", VA = "0x18370F200", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionItemGenerator other)
		{
			//Discarded unreachable code: IL_047c
			if (other == null)
			{
				return;
			}
			if ((long)other.item_ != 0)
			{
				GeneratorItem generatorItem = item_;
				if (generatorItem == null)
				{
					GeneratorItem generatorItem2 = (item_ = new GeneratorItem());
					GeneratorItem generatorItem3 = item_;
				}
				GeneratorItem other2 = other.item_;
				generatorItem.MergeFrom(other2);
			}
			if ((long)other.itemIngredient_ != 0)
			{
				GeneratorItemIngredient generatorItemIngredient2 = default(GeneratorItemIngredient);
				if (itemIngredient_ == null)
				{
					GeneratorItemIngredient generatorItemIngredient = (itemIngredient_ = new GeneratorItemIngredient());
					generatorItemIngredient2 = itemIngredient_;
				}
				GeneratorItemIngredient other3 = other.itemIngredient_;
				generatorItemIngredient2.MergeFrom(other3);
			}
			ItemType itemType = other.type_;
			if (itemType != 0)
			{
				type_ = itemType;
			}
			ActivityItemType activityItemType = other.activityItemType_;
			if (activityItemType != 0)
			{
				activityItemType_ = activityItemType;
			}
			int num = other.set_;
			if (num != 0)
			{
				set_ = num;
			}
			if ((long)other.complexity_ != 0)
			{
				OptionalField optionalField2 = default(OptionalField);
				if (complexity_ == null)
				{
					OptionalField optionalField = (complexity_ = new OptionalField());
					optionalField2 = complexity_;
				}
				OptionalField other4 = other.complexity_;
				optionalField2.MergeFrom(other4);
			}
			if ((long)other.mood_ != 0)
			{
				OptionalField optionalField4 = default(OptionalField);
				if (mood_ == null)
				{
					OptionalField optionalField3 = (mood_ = new OptionalField());
					optionalField4 = mood_;
				}
				OptionalField other5 = other.mood_;
				optionalField4.MergeFrom(other5);
			}
			if ((long)other.sturdiness_ != 0)
			{
				OptionalField optionalField6 = default(OptionalField);
				if (sturdiness_ == null)
				{
					OptionalField optionalField5 = (sturdiness_ = new OptionalField());
					optionalField6 = sturdiness_;
				}
				OptionalField other6 = other.sturdiness_;
				optionalField6.MergeFrom(other6);
			}
			if ((long)other.normality_ != 0)
			{
				OptionalField optionalField8 = default(OptionalField);
				if (normality_ == null)
				{
					OptionalField optionalField7 = (normality_ = new OptionalField());
					optionalField8 = normality_;
				}
				OptionalField other7 = other.normality_;
				optionalField8.MergeFrom(other7);
			}
			if ((long)other.minRarity_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (minRarity_ == null)
				{
					StepAmount stepAmount = (minRarity_ = new StepAmount());
					stepAmount2 = minRarity_;
				}
				StepAmount other8 = other.minRarity_;
				stepAmount2.MergeFrom(other8);
			}
			if ((long)other.maxRarity_ != 0)
			{
				StepAmount stepAmount4 = default(StepAmount);
				if (maxRarity_ == null)
				{
					StepAmount stepAmount3 = (maxRarity_ = new StepAmount());
					stepAmount4 = maxRarity_;
				}
				StepAmount other9 = other.maxRarity_;
				stepAmount4.MergeFrom(other9);
			}
			if ((long)other.fishLocation_ != 0)
			{
				OptionalField optionalField10 = default(OptionalField);
				if (fishLocation_ == null)
				{
					OptionalField optionalField9 = (fishLocation_ = new OptionalField());
					optionalField10 = fishLocation_;
				}
				OptionalField other10 = other.fishLocation_;
				optionalField10.MergeFrom(other10);
			}
			if ((long)other.fishRarity_ != 0)
			{
				OptionalField optionalField12 = default(OptionalField);
				if (fishRarity_ == null)
				{
					OptionalField optionalField11 = (fishRarity_ = new OptionalField());
					optionalField12 = fishRarity_;
				}
				OptionalField other11 = other.fishRarity_;
				optionalField12.MergeFrom(other11);
			}
			string text = other.fishConstraint_;
			if (text.m_stringLength != 0)
			{
				FishConstraint = text;
			}
			string text2 = other.fishWeather_;
			if (text2.m_stringLength != 0)
			{
				FishWeather = text2;
			}
			bool flag = other.fishIncludeTrash_;
			if (flag)
			{
				fishIncludeTrash_ = flag;
			}
			bool flag2 = other.requireAtLeastOneTag_;
			if (flag2)
			{
				requireAtLeastOneTag_ = flag2;
			}
			RepeatedField<TagGroupWithRndOption> repeatedField = tags_;
			RepeatedField<TagGroupWithRndOption> repeatedField2 = other.tags_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			CropTypeCondition cropTypeCondition = other.cropType_;
			if (cropTypeCondition != 0)
			{
				cropType_ = cropTypeCondition;
			}
			SeedTypeCondition seedTypeCondition = other.seedType_;
			if (seedTypeCondition != 0)
			{
				seedType_ = seedTypeCondition;
			}
			FlowerRarityCondition flowerRarityCondition = other.flowerRarity_;
			if (flowerRarityCondition != 0)
			{
				flowerRarity_ = flowerRarityCondition;
			}
			RepeatedField<int> repeatedField3 = ingredientsType_;
			RepeatedField<int> repeatedField4 = other.ingredientsType_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			if ((long)other.minMealStarRating_ != 0)
			{
				StepAmount stepAmount6 = default(StepAmount);
				if (minMealStarRating_ == null)
				{
					StepAmount stepAmount5 = (minMealStarRating_ = new StepAmount());
					stepAmount6 = minMealStarRating_;
				}
				StepAmount other12 = other.minMealStarRating_;
				stepAmount6.MergeFrom(other12);
			}
			if ((long)other.minUnlockLevel_ != 0)
			{
				ScalableValue scalableValue2 = default(ScalableValue);
				if (minUnlockLevel_ == null)
				{
					ScalableValue scalableValue = (minUnlockLevel_ = new ScalableValue());
					scalableValue2 = minUnlockLevel_;
				}
				ScalableValue other13 = other.minUnlockLevel_;
				scalableValue2.MergeFrom(other13);
			}
			if ((long)other.maxUnlockLevel_ != 0)
			{
				ScalableValue scalableValue4 = default(ScalableValue);
				if (maxUnlockLevel_ == null)
				{
					ScalableValue scalableValue3 = (maxUnlockLevel_ = new ScalableValue());
					scalableValue4 = maxUnlockLevel_;
				}
				ScalableValue other14 = other.maxUnlockLevel_;
				scalableValue4.MergeFrom(other14);
			}
			MineralRoughness mineralRoughness = other.mineralRoughness_;
			if (mineralRoughness != 0)
			{
				mineralRoughness_ = mineralRoughness;
			}
			EphemeralTypeCondition ephemeralTypeCondition = other.ephemeralType_;
			if (ephemeralTypeCondition != 0)
			{
				ephemeralType_ = ephemeralTypeCondition;
			}
			int num2 = other.profession_;
			if (num2 != 0)
			{
				profession_ = num2;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003C1F")]
		[Cpp2IlInjected.Address(RVA = "0x370F850", Offset = "0x370E250", VA = "0x18370F850", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_04c7
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 178)
			{
				if ((int)num > 240)
				{
					if ((int)num > 402)
					{
						if ((int)num > 416)
						{
							if (num == 424)
							{
								int num2 = (int)(ephemeralType_ = (EphemeralTypeCondition)input.ReadInt32());
							}
							if (num != 432)
							{
								goto IL_04b0;
							}
							int num3 = (profession_ = input.ReadInt32());
						}
						ScalableValue scalableValue = default(ScalableValue);
						if (num == 410)
						{
							ScalableValue builder = default(ScalableValue);
							if (maxUnlockLevel_ == null)
							{
								scalableValue = (maxUnlockLevel_ = new ScalableValue());
								builder = maxUnlockLevel_;
							}
							input.ReadMessage(builder);
						}
						if ((long)scalableValue != 416)
						{
							goto IL_04b0;
						}
						int num4 = (int)(mineralRoughness_ = (MineralRoughness)input.ReadInt32());
					}
					ScalableValue scalableValue2 = default(ScalableValue);
					if ((int)num > 250)
					{
						StepAmount stepAmount = default(StepAmount);
						if (num == 322)
						{
							StepAmount builder2 = default(StepAmount);
							if (minMealStarRating_ == null)
							{
								stepAmount = (minMealStarRating_ = new StepAmount());
								builder2 = minMealStarRating_;
							}
							input.ReadMessage(builder2);
						}
						if ((long)stepAmount != 402)
						{
							goto IL_04b0;
						}
						ScalableValue builder3 = default(ScalableValue);
						if (minUnlockLevel_ == null)
						{
							scalableValue2 = (minUnlockLevel_ = new ScalableValue());
							builder3 = minUnlockLevel_;
						}
						input.ReadMessage(builder3);
					}
					if ((long)scalableValue2 != 4294967293L)
					{
						goto IL_04b0;
					}
					RepeatedField<int> repeatedField = ingredientsType_;
					FieldCodec<int> repeated_ingredientsType_codec = _repeated_ingredientsType_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_ingredientsType_codec);
				}
				int num7 = default(int);
				if ((int)num > 200)
				{
					int num6 = default(int);
					if ((int)num > 216)
					{
						int num5 = default(int);
						if (num == 224)
						{
							num5 = (int)(seedType_ = (SeedTypeCondition)input.ReadInt32());
						}
						if (num5 != 240)
						{
							goto IL_04b0;
						}
						num6 = (int)(flowerRarity_ = (FlowerRarityCondition)input.ReadInt32());
					}
					if (num6 == 210)
					{
						RepeatedField<TagGroupWithRndOption> repeatedField2 = tags_;
						FieldCodec<TagGroupWithRndOption> repeated_tags_codec = _repeated_tags_codec;
						((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
					}
					if (num6 != 216)
					{
						goto IL_04b0;
					}
					num7 = (int)(cropType_ = (CropTypeCondition)input.ReadInt32());
				}
				string text2 = default(string);
				if (num7 == 186)
				{
					text2 = (FishWeather = input.ReadString());
				}
				bool flag = default(bool);
				if ((long)text2 == 192)
				{
					flag = (fishIncludeTrash_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_04b0;
				}
				bool flag2 = (requireAtLeastOneTag_ = input.ReadBool());
			}
			StepAmount stepAmount3 = default(StepAmount);
			if ((int)num > 98)
			{
				OptionalField optionalField2 = default(OptionalField);
				if ((int)num > 130)
				{
					string text4 = default(string);
					if ((int)num > 162)
					{
						OptionalField optionalField = default(OptionalField);
						if (num == 170)
						{
							OptionalField builder4 = default(OptionalField);
							if (fishRarity_ == null)
							{
								optionalField = (fishRarity_ = new OptionalField());
								builder4 = fishRarity_;
							}
							input.ReadMessage(builder4);
						}
						if ((long)optionalField != 178)
						{
							goto IL_04b0;
						}
						text4 = (FishConstraint = input.ReadString());
					}
					StepAmount stepAmount2 = default(StepAmount);
					if ((long)text4 == 138)
					{
						StepAmount builder5 = default(StepAmount);
						if (maxRarity_ == null)
						{
							stepAmount2 = (maxRarity_ = new StepAmount());
							builder5 = maxRarity_;
						}
						input.ReadMessage(builder5);
					}
					if ((long)stepAmount2 != 162)
					{
						goto IL_04b0;
					}
					OptionalField builder6 = default(OptionalField);
					if (fishLocation_ == null)
					{
						optionalField2 = (fishLocation_ = new OptionalField());
						builder6 = fishLocation_;
					}
					input.ReadMessage(builder6);
				}
				OptionalField optionalField3 = default(OptionalField);
				if ((long)optionalField2 == 106)
				{
					OptionalField builder7 = default(OptionalField);
					if (sturdiness_ == null)
					{
						optionalField3 = (sturdiness_ = new OptionalField());
						builder7 = sturdiness_;
					}
					input.ReadMessage(builder7);
				}
				OptionalField optionalField4 = default(OptionalField);
				if ((long)optionalField3 == 114)
				{
					OptionalField builder8 = default(OptionalField);
					if (normality_ == null)
					{
						optionalField4 = (normality_ = new OptionalField());
						builder8 = normality_;
					}
					input.ReadMessage(builder8);
				}
				if ((long)optionalField4 != 130)
				{
					goto IL_04b0;
				}
				StepAmount builder9 = default(StepAmount);
				if (minRarity_ == null)
				{
					stepAmount3 = (minRarity_ = new StepAmount());
					builder9 = minRarity_;
				}
				input.ReadMessage(builder9);
			}
			int num9 = default(int);
			if ((long)stepAmount3 > 24)
			{
				OptionalField optionalField6 = default(OptionalField);
				if ((long)stepAmount3 > 80)
				{
					OptionalField optionalField5 = default(OptionalField);
					if ((long)stepAmount3 == 90)
					{
						OptionalField builder10 = default(OptionalField);
						if (complexity_ == null)
						{
							optionalField5 = (complexity_ = new OptionalField());
							builder10 = complexity_;
						}
						input.ReadMessage(builder10);
					}
					if ((long)optionalField5 != 98)
					{
						goto IL_04b0;
					}
					OptionalField builder11 = default(OptionalField);
					if (mood_ == null)
					{
						optionalField6 = (mood_ = new OptionalField());
						builder11 = mood_;
					}
					input.ReadMessage(builder11);
				}
				int num8 = default(int);
				if ((long)optionalField6 == 32)
				{
					num8 = (int)(activityItemType_ = (ActivityItemType)input.ReadInt32());
				}
				if (num8 != 80)
				{
					goto IL_04b0;
				}
				num9 = (set_ = input.ReadInt32());
			}
			GeneratorItem generatorItem = default(GeneratorItem);
			if (num9 == 10)
			{
				GeneratorItem builder12 = default(GeneratorItem);
				if (item_ == null)
				{
					generatorItem = (item_ = new GeneratorItem());
					builder12 = item_;
				}
				input.ReadMessage(builder12);
			}
			GeneratorItemIngredient generatorItemIngredient = default(GeneratorItemIngredient);
			if ((long)generatorItem == 18)
			{
				GeneratorItemIngredient builder13 = default(GeneratorItemIngredient);
				if (itemIngredient_ == null)
				{
					generatorItemIngredient = (itemIngredient_ = new GeneratorItemIngredient());
					builder13 = itemIngredient_;
				}
				input.ReadMessage(builder13);
			}
			if ((long)generatorItemIngredient == 24)
			{
				int num10 = (int)(type_ = (ItemType)input.ReadInt32());
			}
			goto IL_04b0;
			IL_04b0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003C20")]
		[Cpp2IlInjected.Address(RVA = "0x370EA60", Offset = "0x370D460", VA = "0x18370EA60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 53)
			{
				GeneratorItem generatorItem = item_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C21")]
		[Cpp2IlInjected.Address(RVA = "0x37103A0", Offset = "0x370EDA0", VA = "0x1837103A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_0021, IL_0029, IL_0031, IL_0032, IL_0033, IL_0043, IL_004b, IL_0053, IL_005b, IL_0063, IL_006b, IL_0073, IL_007b, IL_0083, IL_008f, IL_0095, IL_009b, IL_00a1, IL_00a7, IL_00ad, IL_00b3, IL_00b9, IL_00bf, IL_00c5, IL_00cb, IL_00d1
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 53)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				item_ = (GeneratorItem)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C22")]
		[Cpp2IlInjected.Address(RVA = "0x370E030", Offset = "0x370CA30", VA = "0x18370E030", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0008, IL_0009, IL_000a, IL_000b, IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0016
			if (fieldNumber - 1 > 53)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C24")]
		[Cpp2IlInjected.Address(RVA = "0x370E460", Offset = "0x370CE60", VA = "0x18370E460", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00f6
			if (!fishIncludeTrash_)
			{
				OptionalField optionalField = fishRarity_;
				if (optionalField.useField_)
				{
					FishRarityList fishRarities = optionalField.FishRarities;
					if (fishRarities != null)
					{
						RepeatedField<FishRarity> fishRarities_ = fishRarities.fishRarities_;
						if (fishRarities_ != null)
						{
							int count = ((RepeatedField<T>)(object)fishRarities_).Count;
							int num = 0;
						}
					}
					int num2 = 0;
					if (num2 != 1)
					{
						OptionalField optionalField2 = fishRarity_;
						if (optionalField2 != null)
						{
							FishRarityList fishRarities2 = optionalField2.FishRarities;
							if (fishRarities2 != null)
							{
								int num3 = (int)Enumerable.First<FishRarity>((IEnumerable<>)(object)fishRarities2.fishRarities_);
							}
							if (num2 != 0)
							{
								context.AddError("FishIncludeTrash must be true since rarity only include Trash");
							}
						}
					}
					OptionalField optionalField3 = fishRarity_;
					if (optionalField3 != null && optionalField3.fieldValueCase_ == OptionalField.FieldValueOneofCase.FishRarity && optionalField3.FishRarity == Definitions.Items.FishRarity.Trash)
					{
						context.AddError("FishIncludeTrash must be true when rarity = Trash");
					}
				}
			}
			int num4 = Enumerable.Count<int>(Enumerable.Distinct<int>((IEnumerable<>)(object)ingredientsType_));
			int count2 = ((RepeatedField<T>)(object)ingredientsType_).Count;
			if (num4 != count2)
			{
				string missionStepName = context.MissionStepName;
				string message = "Cannot have duplicates, " + missionStepName;
				context.AddInvalidMemberError(message, "IngredientsType");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C25")]
		[Cpp2IlInjected.Address(RVA = "0x3711290", Offset = "0x370FC90", VA = "0x183711290")]
		static MissionItemGenerator()
		{
			MessageParser<TagGroupWithRndOption> parser = TagGroupWithRndOption._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionItemGenerator>)(object)FieldCodec.ForMessage<TagGroupWithRndOption>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<MissionItemGenerator>)(object)FieldCodec.ForInt32(num2);
			(TagItemType, int?)[] array = new(TagItemType, int?)[0];
			ReadOnlyCollection<(TagItemType, int?)> parser2 = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<MissionItemGenerator>)(object)parser2;
			/*Error: Unexpected end of block*/;
		}
	}
}
