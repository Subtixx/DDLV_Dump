using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010EA")]
	public class AvatarRules
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40045D6")]
		private DefaultAvatar defaultAvatar;

		[Cpp2IlInjected.Token(Token = "0x170017F6")]
		public IAvatar DefaultMale
		{
			[Cpp2IlInjected.Token(Token = "0x60089B0")]
			[Cpp2IlInjected.Address(RVA = "0x1AB19C0", Offset = "0x1AB03C0", VA = "0x181AB19C0")]
			get
			{
				DefaultAvatar defaultAvatar = this.defaultAvatar;
				if (defaultAvatar == null)
				{
					LoadDefaultAvatar();
					DefaultAvatar defaultAvatar2 = this.defaultAvatar;
				}
				Avatar male_ = defaultAvatar.male_;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017F7")]
		public IAvatar DefaultFemale
		{
			[Cpp2IlInjected.Token(Token = "0x60089B1")]
			[Cpp2IlInjected.Address(RVA = "0x1AB1980", Offset = "0x1AB0380", VA = "0x181AB1980")]
			get
			{
				DefaultAvatar defaultAvatar = this.defaultAvatar;
				if (defaultAvatar == null)
				{
					LoadDefaultAvatar();
					DefaultAvatar defaultAvatar2 = this.defaultAvatar;
				}
				Avatar female_ = defaultAvatar.female_;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017F8")]
		public static AvatarRules Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60089BA")]
			[Cpp2IlInjected.Address(RVA = "0x1AB1A00", Offset = "0x1AB0400", VA = "0x181AB1A00")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60089BB")]
			[Cpp2IlInjected.Address(RVA = "0x1AB1A40", Offset = "0x1AB0440", VA = "0x181AB1A40")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089AF")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0D30", Offset = "0x1AAF730", VA = "0x181AB0D30")]
		public IAvatar GetDefaultAvatar(bool isMale)
		{
			DefaultAvatar defaultAvatar;
			do
			{
				defaultAvatar = this.defaultAvatar;
				if (isMale)
				{
					if (defaultAvatar == null)
					{
						LoadDefaultAvatar();
						DefaultAvatar defaultAvatar2 = this.defaultAvatar;
					}
					Avatar male_ = defaultAvatar.male_;
				}
			}
			while (defaultAvatar != null);
			LoadDefaultAvatar();
			Avatar female_ = this.defaultAvatar.female_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089B2")]
		[Cpp2IlInjected.Address(RVA = "0x1AB18A0", Offset = "0x1AB02A0", VA = "0x181AB18A0")]
		private void LoadDefaultAvatar()
		{
			//Discarded unreachable code: IL_0007
			ProtoDatabase protoDatabase = ProtoDatabase.Instance;
		}

		[Cpp2IlInjected.Token(Token = "0x60089B3")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1520", Offset = "0x1AAFF20", VA = "0x181AB1520")]
		public bool IsDefaultClothingItem(Item item)
		{
			bool flag = default(bool);
			Item item2 = default(Item);
			do
			{
				if (!flag)
				{
					return flag;
				}
			}
			while ((object)item2 == null);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60089B4")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0D90", Offset = "0x1AAF790", VA = "0x181AB0D90")]
		public Item GetDefaultClothingItem(ClothingItemType clothingType, bool isMale)
		{
			DefaultAvatar defaultAvatar = this.defaultAvatar;
			int num = 0;
			if (isMale && defaultAvatar == null)
			{
				LoadDefaultAvatar();
				DefaultAvatar defaultAvatar2 = this.defaultAvatar;
			}
			if (defaultAvatar == null)
			{
				LoadDefaultAvatar();
				DefaultAvatar defaultAvatar3 = this.defaultAvatar;
			}
			Avatar female_ = defaultAvatar.female_;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					goto IL_0053;
				}
				num++;
			}
			if (num == 0)
			{
				return Item.Invalid;
			}
			goto IL_0053;
			IL_0053:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089B5")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0F50", Offset = "0x1AAF950", VA = "0x181AB0F50")]
		public static bool IsAdequatelyDressed(IAvatar avatar)
		{
			//Discarded unreachable code: IL_0076, IL_007c, IL_0082, IL_0088, IL_008e
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (num3 != 0)
			{
				if (num3 == 0 && num3 == 0 && num3 == 0 && num3 == 0)
				{
					goto IL_0024;
				}
				int num4 = 0;
			}
			while (num3 == 0)
			{
			}
			while (num3 == 0)
			{
			}
			goto IL_0024;
			IL_0051:
			num += 312;
			goto IL_0059;
			IL_0024:
			if (num3 != 0)
			{
				uint num5 = default(uint);
				if (num < (int)num5)
				{
					num += num;
					if (num == (int)num5)
					{
						goto IL_0051;
					}
					num++;
				}
				ClothingItemData clothingItemData = default(ClothingItemData);
				RepeatedField<ClothingItemType> incompatibleWith_ = clothingItemData.incompatibleWith_;
				bool flag = default(bool);
				if (flag)
				{
					while (!flag)
					{
					}
					num++;
					goto IL_0051;
				}
				goto IL_0059;
			}
			goto IL_0061;
			IL_0059:
			num++;
			while (num == 0)
			{
			}
			goto IL_0061;
			IL_0061:
			int num6 = num6 + 1;
			if (num3 != 0)
			{
			}
			if (num6 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089B6")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1770", Offset = "0x1AB0170", VA = "0x181AB1770")]
		public static bool IsWig(ClothingItem clothingItem)
		{
			//IL_0017: Expected O, but got I4
			ClothingItemType clothingItemType = default(ClothingItemType);
			if (clothingItemType == ClothingItemType.BodHair)
			{
				ItemDatabase itemDatabase = ItemDatabase.Instance;
				ClothingItemData clothingItemData = default(ClothingItemData);
				return ((RepeatedField<T>)(object)clothingItemData.incompatibleWith_).Contains((T)4);
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089B7")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1630", Offset = "0x1AB0030", VA = "0x181AB1630")]
		public static bool IsHelmet(ClothingItem clothingItem)
		{
			//IL_0017: Expected O, but got I4
			ClothingItemType clothingItemType = default(ClothingItemType);
			if (clothingItemType == ClothingItemType.AccHeadHat)
			{
				ItemDatabase itemDatabase = ItemDatabase.Instance;
				ClothingItemData clothingItemData = default(ClothingItemData);
				if (((RepeatedField<T>)(object)clothingItemData.incompatibleWith_).Contains((T)5))
				{
					return true;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089B8")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0CA0", Offset = "0x1AAF6A0", VA = "0x181AB0CA0")]
		public static bool CanBeEmpty(ClothingItemType clothingType)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60089B9")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0CB0", Offset = "0x1AAF6B0", VA = "0x181AB0CB0")]
		public static void CreateInstance()
		{
			Instance = new AvatarRules();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60089BC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AvatarRules()
		{
		}
	}
}
