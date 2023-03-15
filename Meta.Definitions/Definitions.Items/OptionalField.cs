using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000415")]
	public sealed class OptionalField : IMessage<OptionalField>, IMessage, IEquatable<OptionalField>, IDeepCloneable<OptionalField>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000416")]
		public enum FieldValueOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400165E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400165F")]
			Complexity = 10,
			[Cpp2IlInjected.Token(Token = "0x4001660")]
			Mood = 11,
			[Cpp2IlInjected.Token(Token = "0x4001661")]
			Sturdiness = 12,
			[Cpp2IlInjected.Token(Token = "0x4001662")]
			Normality = 13,
			[Cpp2IlInjected.Token(Token = "0x4001663")]
			Rarity = 14,
			[Cpp2IlInjected.Token(Token = "0x4001664")]
			IntValue = 15,
			[Cpp2IlInjected.Token(Token = "0x4001665")]
			StringValue = 16,
			[Cpp2IlInjected.Token(Token = "0x4001666")]
			Character = 17,
			[Cpp2IlInjected.Token(Token = "0x4001667")]
			ItemWithAmount = 18,
			[Cpp2IlInjected.Token(Token = "0x4001668")]
			VillageArea = 19,
			[Cpp2IlInjected.Token(Token = "0x4001669")]
			VillageAreas = 20,
			[Cpp2IlInjected.Token(Token = "0x400166A")]
			Scene = 21,
			[Cpp2IlInjected.Token(Token = "0x400166B")]
			FishRarity = 22,
			[Cpp2IlInjected.Token(Token = "0x400166C")]
			FishRarities = 23
		}

		[Cpp2IlInjected.Token(Token = "0x4001645")]
		private static readonly MessageParser<OptionalField> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001646")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001647")]
		public const int UseFieldFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001648")]
		private bool useField_;

		[Cpp2IlInjected.Token(Token = "0x4001649")]
		public const int RandomFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400164A")]
		private bool random_;

		[Cpp2IlInjected.Token(Token = "0x400164B")]
		public const int ShowRandomCheckboxFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400164C")]
		private bool showRandomCheckbox_;

		[Cpp2IlInjected.Token(Token = "0x400164D")]
		public const int ComplexityFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x400164E")]
		public const int MoodFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x400164F")]
		public const int SturdinessFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4001650")]
		public const int NormalityFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x4001651")]
		public const int RarityFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x4001652")]
		public const int IntValueFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x4001653")]
		public const int StringValueFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x4001654")]
		public const int CharacterFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x4001655")]
		public const int ItemWithAmountFieldNumber = 18;

		[Cpp2IlInjected.Token(Token = "0x4001656")]
		public const int VillageAreaFieldNumber = 19;

		[Cpp2IlInjected.Token(Token = "0x4001657")]
		public const int VillageAreasFieldNumber = 20;

		[Cpp2IlInjected.Token(Token = "0x4001658")]
		public const int SceneFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x4001659")]
		public const int FishRarityFieldNumber = 22;

		[Cpp2IlInjected.Token(Token = "0x400165A")]
		public const int FishRaritiesFieldNumber = 23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400165B")]
		private object fieldValue_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400165C")]
		private FieldValueOneofCase fieldValueCase_;

		[Cpp2IlInjected.Token(Token = "0x17000CC7")]
		[DebuggerNonUserCode]
		public static MessageParser<OptionalField> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60031E4")]
			[Cpp2IlInjected.Address(RVA = "0x36A59C0", Offset = "0x36A43C0", VA = "0x1836A59C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60031E5")]
			[Cpp2IlInjected.Address(RVA = "0x36A55F0", Offset = "0x36A3FF0", VA = "0x1836A55F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CC9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60031E6")]
			[Cpp2IlInjected.Address(RVA = "0x36A5CA0", Offset = "0x36A46A0", VA = "0x1836A5CA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCA")]
		[DebuggerNonUserCode]
		public bool UseField
		{
			[Cpp2IlInjected.Token(Token = "0x60031EA")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useField_;
			}
			[Cpp2IlInjected.Token(Token = "0x60031EB")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useField_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCB")]
		[DebuggerNonUserCode]
		public bool Random
		{
			[Cpp2IlInjected.Token(Token = "0x60031EC")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return random_;
			}
			[Cpp2IlInjected.Token(Token = "0x60031ED")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			set
			{
				random_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCC")]
		[DebuggerNonUserCode]
		public bool ShowRandomCheckbox
		{
			[Cpp2IlInjected.Token(Token = "0x60031EE")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get
			{
				return showRandomCheckbox_;
			}
			[Cpp2IlInjected.Token(Token = "0x60031EF")]
			[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
			set
			{
				showRandomCheckbox_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCD")]
		[DebuggerNonUserCode]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x60031F0")]
			[Cpp2IlInjected.Address(RVA = "0x36A5580", Offset = "0x36A3F80", VA = "0x1836A5580")]
			get
			{
				if (fieldValueCase_ == FieldValueOneofCase.Complexity)
				{
					object obj = fieldValue_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60031F1")]
			[Cpp2IlInjected.Address(RVA = "0x36A5DF0", Offset = "0x36A47F0", VA = "0x1836A5DF0")]
			set
			{
				//IL_0017: Expected I4, but got I8
				fieldValue_ = typeof(Complexity).TypeHandle;
				fieldValueCase_ = FieldValueOneofCase.Complexity;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCE")]
		[DebuggerNonUserCode]
		public Mood Mood
		{
			[Cpp2IlInjected.Token(Token = "0x60031F2")]
			[Cpp2IlInjected.Address(RVA = "0x36A58E0", Offset = "0x36A42E0", VA = "0x1836A58E0")]
			get
			{
				if (fieldValueCase_ == FieldValueOneofCase.Mood)
				{
					object obj = fieldValue_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60031F3")]
			[Cpp2IlInjected.Address(RVA = "0x36A5FC0", Offset = "0x36A49C0", VA = "0x1836A5FC0")]
			set
			{
				//IL_0017: Expected I4, but got I8
				fieldValue_ = typeof(Mood).TypeHandle;
				fieldValueCase_ = FieldValueOneofCase.Mood;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CCF")]
		[DebuggerNonUserCode]
		public Sturdiness Sturdiness
		{
			[Cpp2IlInjected.Token(Token = "0x60031F4")]
			[Cpp2IlInjected.Address(RVA = "0x36A5B60", Offset = "0x36A4560", VA = "0x1836A5B60")]
			get
			{
				if (fieldValueCase_ == FieldValueOneofCase.Sturdiness)
				{
					object obj = fieldValue_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60031F5")]
			[Cpp2IlInjected.Address(RVA = "0x36A61C0", Offset = "0x36A4BC0", VA = "0x1836A61C0")]
			set
			{
				//IL_0017: Expected I4, but got I8
				fieldValue_ = typeof(Sturdiness).TypeHandle;
				fieldValueCase_ = FieldValueOneofCase.Sturdiness;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD0")]
		[DebuggerNonUserCode]
		public Normality Normality
		{
			[Cpp2IlInjected.Token(Token = "0x60031F6")]
			[Cpp2IlInjected.Address(RVA = "0x36A5950", Offset = "0x36A4350", VA = "0x1836A5950")]
			get
			{
				if (fieldValueCase_ == FieldValueOneofCase.Normality)
				{
					object obj = fieldValue_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60031F7")]
			[Cpp2IlInjected.Address(RVA = "0x36A6030", Offset = "0x36A4A30", VA = "0x1836A6030")]
			set
			{
				//IL_0017: Expected I4, but got I8
				fieldValue_ = typeof(Normality).TypeHandle;
				fieldValueCase_ = FieldValueOneofCase.Normality;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD1")]
		[DebuggerNonUserCode]
		public Rarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x60031F8")]
			[Cpp2IlInjected.Address(RVA = "0x36A5A20", Offset = "0x36A4420", VA = "0x1836A5A20")]
			get
			{
				int num = 0;
				if (fieldValueCase_ == FieldValueOneofCase.Rarity)
				{
					object obj = fieldValue_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60031F9")]
			[Cpp2IlInjected.Address(RVA = "0x36A60A0", Offset = "0x36A4AA0", VA = "0x1836A60A0")]
			set
			{
				fieldValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD2")]
		[DebuggerNonUserCode]
		public int IntValue
		{
			[Cpp2IlInjected.Token(Token = "0x60031FA")]
			[Cpp2IlInjected.Address(RVA = "0x36A5810", Offset = "0x36A4210", VA = "0x1836A5810")]
			get
			{
				//Discarded unreachable code: IL_0013
				if (fieldValueCase_ == FieldValueOneofCase.IntValue)
				{
					object obj = fieldValue_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60031FB")]
			[Cpp2IlInjected.Address(RVA = "0x36A5F10", Offset = "0x36A4910", VA = "0x1836A5F10")]
			set
			{
				//IL_0015: Expected I4, but got I8
				fieldValue_ = typeof(int).TypeHandle;
				fieldValueCase_ = FieldValueOneofCase.IntValue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD3")]
		[DebuggerNonUserCode]
		public string StringValue
		{
			[Cpp2IlInjected.Token(Token = "0x60031FC")]
			[Cpp2IlInjected.Address(RVA = "0x36A5AF0", Offset = "0x36A44F0", VA = "0x1836A5AF0")]
			get
			{
				if (fieldValueCase_ == FieldValueOneofCase.StringValue)
				{
					object obj = fieldValue_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				return "";
			}
			[Cpp2IlInjected.Token(Token = "0x60031FD")]
			[Cpp2IlInjected.Address(RVA = "0x36A6150", Offset = "0x36A4B50", VA = "0x1836A6150")]
			set
			{
				//IL_001d: Expected I4, but got I8
				string text = (string)(fieldValue_ = ProtoPreconditions.CheckNotNull(value, "value"));
				fieldValueCase_ = FieldValueOneofCase.StringValue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD4")]
		[DebuggerNonUserCode]
		public CharacterList Character
		{
			[Cpp2IlInjected.Token(Token = "0x60031FE")]
			[Cpp2IlInjected.Address(RVA = "0x36A5520", Offset = "0x36A3F20", VA = "0x1836A5520")]
			get
			{
				int num = 0;
				if (fieldValueCase_ == FieldValueOneofCase.Character)
				{
					object obj = fieldValue_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60031FF")]
			[Cpp2IlInjected.Address(RVA = "0x36A5DB0", Offset = "0x36A47B0", VA = "0x1836A5DB0")]
			set
			{
				fieldValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD5")]
		[DebuggerNonUserCode]
		public AnyItemSelectorWithAmount ItemWithAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003200")]
			[Cpp2IlInjected.Address(RVA = "0x36A5880", Offset = "0x36A4280", VA = "0x1836A5880")]
			get
			{
				int num = 0;
				if (fieldValueCase_ == FieldValueOneofCase.ItemWithAmount)
				{
					object obj = fieldValue_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003201")]
			[Cpp2IlInjected.Address(RVA = "0x36A5F80", Offset = "0x36A4980", VA = "0x1836A5F80")]
			set
			{
				fieldValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD6")]
		[DebuggerNonUserCode]
		public VillageAreaType VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6003202")]
			[Cpp2IlInjected.Address(RVA = "0x36A5BD0", Offset = "0x36A45D0", VA = "0x1836A5BD0")]
			get
			{
				if (fieldValueCase_ == FieldValueOneofCase.VillageArea)
				{
					object obj = fieldValue_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003203")]
			[Cpp2IlInjected.Address(RVA = "0x36A6230", Offset = "0x36A4C30", VA = "0x1836A6230")]
			set
			{
				//IL_0017: Expected I4, but got I8
				fieldValue_ = typeof(VillageAreaType).TypeHandle;
				fieldValueCase_ = FieldValueOneofCase.VillageArea;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD7")]
		[DebuggerNonUserCode]
		public VillageAreaList VillageAreas
		{
			[Cpp2IlInjected.Token(Token = "0x6003204")]
			[Cpp2IlInjected.Address(RVA = "0x36A5C40", Offset = "0x36A4640", VA = "0x1836A5C40")]
			get
			{
				int num = 0;
				if (fieldValueCase_ == FieldValueOneofCase.VillageAreas)
				{
					object obj = fieldValue_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003205")]
			[Cpp2IlInjected.Address(RVA = "0x36A62A0", Offset = "0x36A4CA0", VA = "0x1836A62A0")]
			set
			{
				fieldValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD8")]
		[DebuggerNonUserCode]
		public SceneType Scene
		{
			[Cpp2IlInjected.Token(Token = "0x6003206")]
			[Cpp2IlInjected.Address(RVA = "0x36A5A80", Offset = "0x36A4480", VA = "0x1836A5A80")]
			get
			{
				if (fieldValueCase_ == FieldValueOneofCase.Scene)
				{
					object obj = fieldValue_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003207")]
			[Cpp2IlInjected.Address(RVA = "0x36A60E0", Offset = "0x36A4AE0", VA = "0x1836A60E0")]
			set
			{
				//IL_0017: Expected I4, but got I8
				fieldValue_ = typeof(SceneType).TypeHandle;
				fieldValueCase_ = FieldValueOneofCase.Scene;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CD9")]
		[DebuggerNonUserCode]
		public FishRarity FishRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6003208")]
			[Cpp2IlInjected.Address(RVA = "0x36A57A0", Offset = "0x36A41A0", VA = "0x1836A57A0")]
			get
			{
				if (fieldValueCase_ == FieldValueOneofCase.FishRarity)
				{
					object obj = fieldValue_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003209")]
			[Cpp2IlInjected.Address(RVA = "0x36A5EA0", Offset = "0x36A48A0", VA = "0x1836A5EA0")]
			set
			{
				//IL_0017: Expected I4, but got I8
				fieldValue_ = typeof(FishRarity).TypeHandle;
				fieldValueCase_ = FieldValueOneofCase.FishRarity;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDA")]
		[DebuggerNonUserCode]
		public FishRarityList FishRarities
		{
			[Cpp2IlInjected.Token(Token = "0x600320A")]
			[Cpp2IlInjected.Address(RVA = "0x36A5740", Offset = "0x36A4140", VA = "0x1836A5740")]
			get
			{
				int num = 0;
				if (fieldValueCase_ == FieldValueOneofCase.FishRarities)
				{
					object obj = fieldValue_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600320B")]
			[Cpp2IlInjected.Address(RVA = "0x36A5E60", Offset = "0x36A4860", VA = "0x1836A5E60")]
			set
			{
				fieldValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDB")]
		[DebuggerNonUserCode]
		public FieldValueOneofCase FieldValueCase
		{
			[Cpp2IlInjected.Token(Token = "0x600320C")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return fieldValueCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CDC")]
		public VillageAreaType FirstVillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x600321F")]
			[Cpp2IlInjected.Address(RVA = "0x36A56C0", Offset = "0x36A40C0", VA = "0x1836A56C0")]
			get
			{
				if (useField_)
				{
					switch (fieldValueCase_)
					{
					case FieldValueOneofCase.VillageAreas:
						return Enumerable.FirstOrDefault<VillageAreaType>((IEnumerable<>)(object)VillageAreas.areaList_);
					case FieldValueOneofCase.VillageArea:
						return VillageArea;
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031E7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public OptionalField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60031E8")]
		[Cpp2IlInjected.Address(RVA = "0x36A5240", Offset = "0x36A3C40", VA = "0x1836A5240")]
		[DebuggerNonUserCode]
		public OptionalField(OptionalField other)
		{
			//IL_0105: Expected I4, but got O
			bool flag = (useField_ = other.useField_);
			bool flag2 = (random_ = other.random_);
			bool flag3 = (showRandomCheckbox_ = other.showRandomCheckbox_);
			if (other.fieldValueCase_ <= FieldValueOneofCase.Normality)
			{
				Complexity complexity = other.Complexity;
				Mood mood = other.Mood;
				Sturdiness sturdiness = other.Sturdiness;
				Normality normality = other.Normality;
				Rarity rarity = (Rarity)(fieldValue_ = other.Rarity.Clone());
				int num = (IntValue = other.IntValue);
				string text = (StringValue = other.StringValue);
				CharacterList characterList = (CharacterList)(fieldValue_ = other.Character.Clone());
				AnyItemSelectorWithAmount anyItemSelectorWithAmount = (AnyItemSelectorWithAmount)(fieldValue_ = other.ItemWithAmount.Clone());
				VillageAreaType villageArea = other.VillageArea;
				VillageAreaList villageAreaList = (VillageAreaList)(fieldValue_ = other.VillageAreas.Clone());
				SceneType scene = other.Scene;
				FishRarity fishRarity = other.FishRarity;
				fieldValueCase_ = (FieldValueOneofCase)(fieldValue_ = other.FishRarities.Clone());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031E9")]
		[Cpp2IlInjected.Address(RVA = "0x36A2540", Offset = "0x36A0F40", VA = "0x1836A2540", Slot = "10")]
		[DebuggerNonUserCode]
		public OptionalField Clone()
		{
			return new OptionalField(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600320D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearFieldValue()
		{
			//IL_0010: Expected O, but got I4
			fieldValue_ = (fieldValueCase_ = FieldValueOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600320E")]
		[Cpp2IlInjected.Address(RVA = "0x36A28D0", Offset = "0x36A12D0", VA = "0x1836A28D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((OptionalField)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600320F")]
		[Cpp2IlInjected.Address(RVA = "0x36A2640", Offset = "0x36A1040", VA = "0x1836A2640", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OptionalField other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.useField_;
				if (useField_ == flag)
				{
					bool flag2 = other.random_;
					if (random_ == flag2)
					{
						bool flag3 = other.showRandomCheckbox_;
						if (showRandomCheckbox_ == flag3)
						{
							int complexity = (int)Complexity;
							Complexity complexity2 = other.Complexity;
							if (complexity == (int)complexity2)
							{
								int mood = (int)Mood;
								Mood mood2 = other.Mood;
								if (mood == (int)mood2)
								{
									int sturdiness = (int)Sturdiness;
									Sturdiness sturdiness2 = other.Sturdiness;
									if (sturdiness == (int)sturdiness2)
									{
										int normality = (int)Normality;
										Normality normality2 = other.Normality;
										if (normality == (int)normality2)
										{
											Rarity rarity = Rarity;
											Rarity rarity2 = other.Rarity;
											if (object.Equals(rarity, rarity2))
											{
												int intValue = IntValue;
												int intValue2 = other.IntValue;
												if (intValue == intValue2)
												{
													string stringValue = StringValue;
													string stringValue2 = other.StringValue;
													if (!(stringValue != stringValue2))
													{
														CharacterList character = Character;
														CharacterList character2 = other.Character;
														if (object.Equals(character, character2))
														{
															AnyItemSelectorWithAmount itemWithAmount = ItemWithAmount;
															AnyItemSelectorWithAmount itemWithAmount2 = other.ItemWithAmount;
															if (object.Equals(itemWithAmount, itemWithAmount2))
															{
																int villageArea = (int)VillageArea;
																VillageAreaType villageArea2 = other.VillageArea;
																if (villageArea == (int)villageArea2)
																{
																	VillageAreaList villageAreas = VillageAreas;
																	VillageAreaList villageAreas2 = other.VillageAreas;
																	if (object.Equals(villageAreas, villageAreas2))
																	{
																		int scene = (int)Scene;
																		SceneType scene2 = other.Scene;
																		if (scene == (int)scene2)
																		{
																			int fishRarity = (int)FishRarity;
																			FishRarity fishRarity2 = other.FishRarity;
																			if (fishRarity == (int)fishRarity2)
																			{
																				FishRarityList fishRarities = FishRarities;
																				FishRarityList fishRarities2 = other.FishRarities;
																				if (object.Equals(fishRarities, fishRarities2))
																				{
																					FieldValueOneofCase fieldValueOneofCase = other.fieldValueCase_;
																					if (fieldValueCase_ == fieldValueOneofCase)
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
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003210")]
		[Cpp2IlInjected.Address(RVA = "0x36A2C90", Offset = "0x36A1690", VA = "0x1836A2C90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0204
			while (true)
			{
				bool flag = useField_;
				int num = 0;
				if (flag)
				{
				}
				if (random_)
				{
				}
				if (showRandomCheckbox_)
				{
				}
				if (fieldValueCase_ == FieldValueOneofCase.Complexity)
				{
					if (fieldValueCase_ != FieldValueOneofCase.Complexity)
					{
					}
					object obj = fieldValue_;
				}
				if (fieldValueCase_ == FieldValueOneofCase.Mood)
				{
					if (fieldValueCase_ != FieldValueOneofCase.Mood)
					{
					}
					object obj2 = fieldValue_;
				}
				if (fieldValueCase_ == FieldValueOneofCase.Sturdiness)
				{
					if (fieldValueCase_ != FieldValueOneofCase.Sturdiness)
					{
					}
					object obj3 = fieldValue_;
				}
				if (fieldValueCase_ == FieldValueOneofCase.Normality)
				{
					if (fieldValueCase_ != FieldValueOneofCase.Normality)
					{
					}
					object obj4 = fieldValue_;
				}
				if (fieldValueCase_ != FieldValueOneofCase.Rarity)
				{
					continue;
				}
				object obj5 = fieldValue_;
				if (obj5 != null)
				{
					int hashCode = obj5.GetHashCode();
					if (fieldValueCase_ == FieldValueOneofCase.IntValue)
					{
						if (fieldValueCase_ != FieldValueOneofCase.IntValue)
						{
						}
						object obj6 = fieldValue_;
					}
					if (fieldValueCase_ != FieldValueOneofCase.StringValue)
					{
						continue;
					}
					if (fieldValueCase_ != FieldValueOneofCase.StringValue)
					{
					}
					object obj7 = fieldValue_;
					if (obj7 == null || obj7 != null)
					{
						int hashCode2 = obj7.GetHashCode();
						if (fieldValueCase_ != FieldValueOneofCase.Character)
						{
							continue;
						}
						object obj8 = fieldValue_;
						if (obj8 != null)
						{
							int hashCode3 = obj8.GetHashCode();
							if (fieldValueCase_ != FieldValueOneofCase.ItemWithAmount)
							{
								continue;
							}
							object obj9 = fieldValue_;
							if (obj9 != null)
							{
								int hashCode4 = obj9.GetHashCode();
								if (fieldValueCase_ == FieldValueOneofCase.VillageArea)
								{
									if (fieldValueCase_ != FieldValueOneofCase.VillageArea)
									{
									}
									object obj10 = fieldValue_;
								}
								if (fieldValueCase_ != FieldValueOneofCase.VillageAreas)
								{
									continue;
								}
								object obj11 = fieldValue_;
								if (obj11 != null)
								{
									int hashCode5 = obj11.GetHashCode();
									if (fieldValueCase_ == FieldValueOneofCase.Scene)
									{
										if (fieldValueCase_ != FieldValueOneofCase.Scene)
										{
										}
										object obj12 = fieldValue_;
									}
									if (fieldValueCase_ == FieldValueOneofCase.FishRarity)
									{
										if (fieldValueCase_ != FieldValueOneofCase.FishRarity)
										{
										}
										object obj13 = fieldValue_;
									}
									if (fieldValueCase_ == FieldValueOneofCase.FishRarities)
									{
										object obj14 = fieldValue_;
										if (obj14 == null)
										{
											break;
										}
										int hashCode6 = obj14.GetHashCode();
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
					}
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003211")]
		[Cpp2IlInjected.Address(RVA = "0x36A4BC0", Offset = "0x36A35C0", VA = "0x1836A4BC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003212")]
		[Cpp2IlInjected.Address(RVA = "0x36A4C20", Offset = "0x36A3620", VA = "0x1836A4C20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0232
			FieldValueOneofCase fieldValueOneofCase = default(FieldValueOneofCase);
			while (true)
			{
				if (useField_)
				{
					bool value = useField_;
					output.WriteBool(value);
				}
				if (random_)
				{
					bool value2 = random_;
					output.WriteBool(value2);
				}
				if (showRandomCheckbox_)
				{
					bool value3 = showRandomCheckbox_;
					output.WriteBool(value3);
				}
				if (fieldValueCase_ != FieldValueOneofCase.Complexity)
				{
					continue;
				}
				int complexity = (int)Complexity;
				output.WriteInt32(complexity);
				if (fieldValueCase_ != FieldValueOneofCase.Mood)
				{
					continue;
				}
				int mood = (int)Mood;
				output.WriteInt32(mood);
				if (fieldValueCase_ != FieldValueOneofCase.Sturdiness)
				{
					continue;
				}
				int sturdiness = (int)Sturdiness;
				output.WriteInt32(sturdiness);
				if (fieldValueCase_ == FieldValueOneofCase.Normality)
				{
					int normality = (int)Normality;
					output.WriteInt32(normality);
					fieldValueOneofCase = fieldValueCase_;
				}
				int num = 0;
				if (fieldValueOneofCase != FieldValueOneofCase.Rarity)
				{
					continue;
				}
				if (fieldValueCase_ == FieldValueOneofCase.Rarity)
				{
					object obj = fieldValue_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (fieldValueCase_ != FieldValueOneofCase.IntValue)
				{
					continue;
				}
				int intValue = IntValue;
				output.WriteInt32(intValue);
				if (fieldValueCase_ != FieldValueOneofCase.StringValue)
				{
					continue;
				}
				string stringValue = StringValue;
				output.WriteString(stringValue);
				if (fieldValueCase_ != FieldValueOneofCase.Character)
				{
					continue;
				}
				if (fieldValueCase_ == FieldValueOneofCase.Character)
				{
					object obj2 = fieldValue_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (fieldValueCase_ != FieldValueOneofCase.ItemWithAmount)
				{
					continue;
				}
				if (fieldValueCase_ == FieldValueOneofCase.ItemWithAmount)
				{
					object obj3 = fieldValue_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (fieldValueCase_ != FieldValueOneofCase.VillageArea)
				{
					continue;
				}
				int villageArea = (int)VillageArea;
				output.WriteInt32(villageArea);
				if (fieldValueCase_ != FieldValueOneofCase.VillageAreas)
				{
					continue;
				}
				if (fieldValueCase_ == FieldValueOneofCase.VillageAreas)
				{
					object obj4 = fieldValue_;
					if (obj4 != null && obj4 == null)
					{
						break;
					}
				}
				if (fieldValueCase_ != FieldValueOneofCase.Scene)
				{
					continue;
				}
				int scene = (int)Scene;
				output.WriteInt32(scene);
				if (fieldValueCase_ != FieldValueOneofCase.FishRarity)
				{
					continue;
				}
				int fishRarity = (int)FishRarity;
				output.WriteInt32(fishRarity);
				if (fieldValueCase_ == FieldValueOneofCase.FishRarities && fieldValueCase_ == FieldValueOneofCase.FishRarities)
				{
					object obj5 = fieldValue_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003213")]
		[Cpp2IlInjected.Address(RVA = "0x36A1B00", Offset = "0x36A0500", VA = "0x1836A1B00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (fieldValueCase_ == FieldValueOneofCase.Complexity)
			{
				if (fieldValueCase_ != FieldValueOneofCase.Complexity)
				{
				}
				object obj = fieldValue_;
			}
			if (fieldValueCase_ == FieldValueOneofCase.Mood)
			{
				if (fieldValueCase_ != FieldValueOneofCase.Mood)
				{
				}
				object obj2 = fieldValue_;
			}
			if (fieldValueCase_ == FieldValueOneofCase.Sturdiness)
			{
				if (fieldValueCase_ != FieldValueOneofCase.Sturdiness)
				{
				}
				object obj3 = fieldValue_;
			}
			if (fieldValueCase_ == FieldValueOneofCase.Normality)
			{
				if (fieldValueCase_ != FieldValueOneofCase.Normality)
				{
				}
				object obj4 = fieldValue_;
			}
			if (fieldValueCase_ == FieldValueOneofCase.Rarity)
			{
				if (fieldValueCase_ != FieldValueOneofCase.Rarity)
				{
				}
				object obj5 = fieldValue_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (fieldValueCase_ == FieldValueOneofCase.IntValue)
			{
				if (fieldValueCase_ != FieldValueOneofCase.IntValue)
				{
				}
				object obj6 = fieldValue_;
			}
			if (fieldValueCase_ == FieldValueOneofCase.StringValue)
			{
				if (fieldValueCase_ != FieldValueOneofCase.StringValue)
				{
				}
				object obj7 = fieldValue_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (fieldValueCase_ == FieldValueOneofCase.Character)
			{
				if (fieldValueCase_ != FieldValueOneofCase.Character)
				{
				}
				object obj8 = fieldValue_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (fieldValueCase_ == FieldValueOneofCase.ItemWithAmount)
			{
				if (fieldValueCase_ != FieldValueOneofCase.ItemWithAmount)
				{
				}
				object obj9 = fieldValue_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (fieldValueCase_ == FieldValueOneofCase.VillageArea)
			{
				if (fieldValueCase_ != FieldValueOneofCase.VillageArea)
				{
				}
				object obj10 = fieldValue_;
			}
			if (fieldValueCase_ == FieldValueOneofCase.VillageAreas)
			{
				if (fieldValueCase_ != FieldValueOneofCase.VillageAreas)
				{
				}
				object obj11 = fieldValue_;
				if (obj11 != null && obj11 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (fieldValueCase_ == FieldValueOneofCase.Scene)
			{
				if (fieldValueCase_ != FieldValueOneofCase.Scene)
				{
				}
				object obj12 = fieldValue_;
			}
			if (fieldValueCase_ == FieldValueOneofCase.FishRarity)
			{
				if (fieldValueCase_ != FieldValueOneofCase.FishRarity)
				{
				}
				object obj13 = fieldValue_;
			}
			if (fieldValueCase_ == FieldValueOneofCase.FishRarities && fieldValueCase_ == FieldValueOneofCase.FishRarities)
			{
				object obj14 = fieldValue_;
				if (obj14 != null && obj14 == null)
				{
					goto IL_01e9;
				}
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
			}
			goto IL_01e9;
			IL_01e9:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003214")]
		[Cpp2IlInjected.Address(RVA = "0x36A3A10", Offset = "0x36A2410", VA = "0x1836A3A10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OptionalField other)
		{
			//Discarded unreachable code: IL_006b, IL_0074, IL_008b, IL_00b1, IL_00c8, IL_00de, IL_00f5, IL_010b, IL_0122, IL_0138, IL_014f
			//IL_008b: Expected I4, but got O
			//IL_00c8: Expected I4, but got O
			//IL_00f5: Expected I4, but got O
			//IL_0122: Expected I4, but got O
			//IL_014f: Expected I4, but got O
			if (other != null)
			{
				bool flag = other.useField_;
				if (flag)
				{
					useField_ = flag;
				}
				bool flag2 = other.random_;
				if (flag2)
				{
					random_ = flag2;
				}
				bool flag3 = other.showRandomCheckbox_;
				if (flag3)
				{
					showRandomCheckbox_ = flag3;
				}
				if (other.fieldValueCase_ <= FieldValueOneofCase.Normality)
				{
					Complexity complexity = other.Complexity;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003215")]
		[Cpp2IlInjected.Address(RVA = "0x36A3E60", Offset = "0x36A2860", VA = "0x1836A3E60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0047: Expected O, but got I4
			//IL_0051: Expected I4, but got I8
			//IL_0068: Expected O, but got I4
			//IL_0072: Expected I4, but got I8
			//IL_00c5: Expected I4, but got O
			//IL_00de: Expected O, but got I4
			//IL_00e8: Expected I4, but got I8
			//IL_013f: Expected I4, but got O
			//IL_019f: Expected I4, but got O
			//IL_01fb: Expected I4, but got O
			//IL_025a: Expected O, but got I4
			//IL_0264: Expected I4, but got I8
			//IL_02b8: Expected I4, but got O
			//IL_02d3: Expected O, but got I4
			//IL_02dd: Expected I4, but got I8
			//IL_02f6: Expected O, but got I4
			//IL_0300: Expected I4, but got I8
			//IL_0331: Expected O, but got I4
			//IL_033b: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 114)
			{
				if ((int)num > 146)
				{
					if ((int)num > 162)
					{
						if (num == 168)
						{
							int num2 = input.ReadInt32();
							fieldValue_ = num2;
							fieldValueCase_ = FieldValueOneofCase.Scene;
						}
						int num3 = default(int);
						if (num == 176)
						{
							num3 = input.ReadInt32();
							fieldValue_ = num3;
							fieldValueCase_ = FieldValueOneofCase.FishRarity;
						}
						if (num3 != 186)
						{
							goto IL_0365;
						}
						FishRarityList builder = new FishRarityList();
						if (fieldValueCase_ == FieldValueOneofCase.FishRarities)
						{
							if (fieldValueCase_ != FieldValueOneofCase.FishRarities)
							{
							}
							object obj = fieldValue_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder);
						fieldValue_ = builder;
						fieldValueCase_ = (FieldValueOneofCase)typeof(FishRarityList).TypeHandle;
					}
					int num4 = default(int);
					if (num == 152)
					{
						num4 = input.ReadInt32();
						fieldValue_ = num4;
						fieldValueCase_ = FieldValueOneofCase.VillageArea;
					}
					if (num4 != 162)
					{
						goto IL_0365;
					}
					VillageAreaList builder2 = new VillageAreaList();
					if (fieldValueCase_ == FieldValueOneofCase.VillageAreas)
					{
						if (fieldValueCase_ != FieldValueOneofCase.VillageAreas)
						{
						}
						object obj2 = fieldValue_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					fieldValue_ = builder2;
					fieldValueCase_ = (FieldValueOneofCase)typeof(VillageAreaList).TypeHandle;
				}
				if ((int)num > 130)
				{
					if (num == 138)
					{
						CharacterList builder3 = new CharacterList();
						if (fieldValueCase_ == FieldValueOneofCase.Character)
						{
							if (fieldValueCase_ != FieldValueOneofCase.Character)
							{
							}
							object obj3 = fieldValue_;
							if (obj3 != null && obj3 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder3);
						fieldValue_ = builder3;
						fieldValueCase_ = (FieldValueOneofCase)typeof(CharacterList).TypeHandle;
					}
					if ((long)typeof(CharacterList).TypeHandle != 146)
					{
						goto IL_0365;
					}
					AnyItemSelectorWithAmount builder4 = new AnyItemSelectorWithAmount();
					if (fieldValueCase_ == FieldValueOneofCase.ItemWithAmount)
					{
						if (fieldValueCase_ != FieldValueOneofCase.ItemWithAmount)
						{
						}
						object obj4 = fieldValue_;
						if (obj4 != null && obj4 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder4);
					fieldValue_ = builder4;
					fieldValueCase_ = (FieldValueOneofCase)typeof(AnyItemSelectorWithAmount).TypeHandle;
				}
				int num6 = default(int);
				if ((long)typeof(AnyItemSelectorWithAmount).TypeHandle == 120)
				{
					num6 = (IntValue = input.ReadInt32());
				}
				if (num6 != 130)
				{
					goto IL_0365;
				}
				string text2 = (StringValue = input.ReadString());
			}
			int num9 = default(int);
			if ((int)num > 80)
			{
				if ((int)num > 96)
				{
					int num7 = default(int);
					if (num == 104)
					{
						num7 = input.ReadInt32();
						fieldValue_ = num7;
						fieldValueCase_ = FieldValueOneofCase.Normality;
					}
					if (num7 != 114)
					{
						goto IL_0365;
					}
					Rarity builder5 = new Rarity();
					if (fieldValueCase_ == FieldValueOneofCase.Rarity)
					{
						if (fieldValueCase_ != FieldValueOneofCase.Rarity)
						{
						}
						object obj5 = fieldValue_;
						if (obj5 != null && obj5 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder5);
					fieldValue_ = builder5;
					fieldValueCase_ = (FieldValueOneofCase)typeof(Rarity).TypeHandle;
				}
				int num8 = default(int);
				if ((long)typeof(Rarity).TypeHandle == 88)
				{
					num8 = input.ReadInt32();
					fieldValue_ = num8;
					fieldValueCase_ = FieldValueOneofCase.Mood;
				}
				if (num8 != 96)
				{
					goto IL_0365;
				}
				num9 = input.ReadInt32();
				fieldValue_ = num9;
				fieldValueCase_ = FieldValueOneofCase.Sturdiness;
			}
			int num10 = default(int);
			if (num9 > 16)
			{
				bool flag = default(bool);
				if (num9 == 24)
				{
					flag = (showRandomCheckbox_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0365;
				}
				num10 = input.ReadInt32();
				fieldValue_ = num10;
				fieldValueCase_ = FieldValueOneofCase.Complexity;
			}
			bool flag2 = default(bool);
			if (num10 == 8)
			{
				flag2 = (useField_ = input.ReadBool());
			}
			if (flag2)
			{
				bool flag3 = (random_ = input.ReadBool());
			}
			goto IL_0365;
			IL_0365:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003216")]
		[Cpp2IlInjected.Address(RVA = "0x36A2930", Offset = "0x36A1330", VA = "0x1836A2930", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 22)
			{
				bool flag = useField_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003217")]
		[Cpp2IlInjected.Address(RVA = "0x36A4560", Offset = "0x36A2F60", VA = "0x1836A4560", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0025, IL_002b, IL_0031, IL_0037, IL_003d, IL_0043, IL_0049, IL_004f
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 22)
			{
				object obj = default(object);
				useField_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003218")]
		[Cpp2IlInjected.Address(RVA = "0x36A2300", Offset = "0x36A0D00", VA = "0x1836A2300", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0014, IL_0017, IL_001a, IL_001d, IL_0021, IL_0022, IL_0026, IL_002a
			if (fieldNumber - 1 <= 22)
			{
				useField_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003219")]
		[Cpp2IlInjected.Address(RVA = "0x36A3380", Offset = "0x36A1D80", VA = "0x1836A3380", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "FieldValue"))
			{
				FieldValueOneofCase fieldValueOneofCase = fieldValueCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600321A")]
		[Cpp2IlInjected.Address(RVA = "0x36A24D0", Offset = "0x36A0ED0", VA = "0x1836A24D0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "FieldValue"))
			{
				fieldValue_ = (fieldValueCase_ = FieldValueOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600321B")]
		[Cpp2IlInjected.Address(RVA = "0x36A3430", Offset = "0x36A1E30", VA = "0x1836A3430")]
		public bool IsRandom(int mask, ref int randomFieldIndex)
		{
			if (!useField_ || random_)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600321C")]
		[Cpp2IlInjected.Address(RVA = "0x36A3460", Offset = "0x36A1E60", VA = "0x1836A3460")]
		public bool IsValidLocation(VillageAreaType location)
		{
			List<VillageAreaType> list = (List<VillageAreaType>)(object)new List<T>();
			List<VillageAreaType> locations = list;
			if (useField_)
			{
				if (fieldValueCase_ == FieldValueOneofCase.VillageArea)
				{
					List<VillageAreaType> list2 = locations;
					VillageAreaType villageArea = VillageArea;
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_0068;
					}
				}
				if (useField_ && fieldValueCase_ == FieldValueOneofCase.VillageAreas)
				{
					if (fieldValue_ == null)
					{
						throw new InvalidCastException();
					}
					Func<VillageAreaType, bool> func = (Func<VillageAreaType, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_000c
						List<VillageAreaType> list3 = locations;
						bool flag3 = default(bool);
						return !flag3;
					};
					bool flag2 = default(bool);
					if (flag2)
					{
						goto IL_0068;
					}
				}
			}
			goto IL_006b;
			IL_006b:
			throw new NullReferenceException();
			IL_0068:
			int num = 0;
			goto IL_006b;
		}

		[Cpp2IlInjected.Token(Token = "0x600321D")]
		[Cpp2IlInjected.Address(RVA = "0x36A3670", Offset = "0x36A2070", VA = "0x1836A3670")]
		public bool IsValidLocation(List<VillageAreaType> locations)
		{
			if (useField_)
			{
				if (fieldValueCase_ == FieldValueOneofCase.VillageArea)
				{
					List<VillageAreaType> list = locations;
					VillageAreaType villageArea = VillageArea;
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_0061;
					}
				}
				if (useField_ && fieldValueCase_ == FieldValueOneofCase.VillageAreas)
				{
					if (fieldValue_ == null)
					{
						throw new InvalidCastException();
					}
					Func<VillageAreaType, bool> func = (Func<VillageAreaType, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_000c
						List<VillageAreaType> list2 = locations;
						bool flag3 = default(bool);
						return !flag3;
					};
					bool flag2 = default(bool);
					if (flag2)
					{
						goto IL_0061;
					}
				}
			}
			goto IL_0064;
			IL_0064:
			throw new NullReferenceException();
			IL_0061:
			int num = 0;
			goto IL_0064;
		}

		[Cpp2IlInjected.Token(Token = "0x600321E")]
		[Cpp2IlInjected.Address(RVA = "0x36A3820", Offset = "0x36A2220", VA = "0x1836A3820")]
		public bool IsValidRarity(List<FishRarity> rarities)
		{
			if (useField_)
			{
				if (fieldValueCase_ == FieldValueOneofCase.FishRarity)
				{
					List<FishRarity> list = rarities;
					FishRarity fishRarity = FishRarity;
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_007c;
					}
				}
				if (useField_ && fieldValueCase_ == FieldValueOneofCase.FishRarities)
				{
					object obj = fieldValue_;
					if (obj != null)
					{
						if (obj == null)
						{
							throw new InvalidCastException();
						}
						if (1L == 0L)
						{
						}
						if (fieldValue_ == null)
						{
							throw new InvalidCastException();
						}
						Func<FishRarity, bool> func = (Func<FishRarity, bool>)(object)(Func<T, TResult>)delegate
						{
							//Discarded unreachable code: IL_000c
							List<FishRarity> list2 = rarities;
							bool flag3 = default(bool);
							return !flag3;
						};
						bool flag2 = default(bool);
						if (flag2)
						{
							goto IL_007c;
						}
					}
				}
			}
			goto IL_007f;
			IL_007f:
			throw new NullReferenceException();
			IL_007c:
			int num = 0;
			goto IL_007f;
		}

		[Cpp2IlInjected.Token(Token = "0x6003220")]
		[Cpp2IlInjected.Address(RVA = "0x36A25A0", Offset = "0x36A0FA0", VA = "0x1836A25A0", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0036
			if (useField_)
			{
			}
			bool flag = (context.StopRecursion = 1 != 0);
			FieldValueOneofCase fieldValueOneofCase = fieldValueCase_;
			if (fieldValueOneofCase != 0 && fieldValueOneofCase == FieldValueOneofCase.FishRarity)
			{
				context.AddError("FishRarity is deprecated, please convert data from 'Windows/Script/Convert Filter'");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003221")]
		[Cpp2IlInjected.Address(RVA = "0x36A5130", Offset = "0x36A3B30", VA = "0x1836A5130")]
		static OptionalField()
		{
			Func<OptionalField> func = default(Func<OptionalField>);
			_parser = (MessageParser<OptionalField>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
