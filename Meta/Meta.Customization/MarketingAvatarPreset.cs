using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010E6")]
	public sealed class MarketingAvatarPreset : IDataValidation, IMessage<MarketingAvatarPreset>, IMessage, IEquatable<MarketingAvatarPreset>, IDeepCloneable<MarketingAvatarPreset>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40045B1")]
		private static readonly MessageParser<MarketingAvatarPreset> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40045B2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40045B3")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40045B4")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40045B5")]
		public const int IconAddressFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40045B6")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40045B7")]
		public const int IsMaleFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40045B8")]
		private bool isMale_;

		[Cpp2IlInjected.Token(Token = "0x40045B9")]
		public const int BodyTypeIndexFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40045BA")]
		private int bodyTypeIndex_;

		[Cpp2IlInjected.Token(Token = "0x40045BB")]
		public const int SkinColorIndexFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40045BC")]
		private int skinColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x40045BD")]
		public const int EyeColorIndexFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40045BE")]
		private int eyeColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x40045BF")]
		public const int HairStyleFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40045C0")]
		private int hairStyle_;

		[Cpp2IlInjected.Token(Token = "0x40045C1")]
		public const int HairColorIndexFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40045C2")]
		private int hairColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x40045C3")]
		public const int HairHighlightColorIndexFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40045C4")]
		private int hairHighlightColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x40045C5")]
		public const int FaceTypeFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x40045C6")]
		private static readonly MapField<uint, int>.Codec _map_faceType_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40045C7")]
		private readonly MapField<uint, int> faceType_ = (MapField<uint, int>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40045C8")]
		public const int MakeupFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x40045C9")]
		private static readonly MapField<uint, Makeup>.Codec _map_makeup_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40045CA")]
		private readonly MapField<uint, Makeup> makeup_ = (MapField<uint, Makeup>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40045CB")]
		public const int ClothesFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x40045CC")]
		private static readonly MapField<uint, int>.Codec _map_clothes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40045CD")]
		private readonly MapField<uint, int> clothes_ = (MapField<uint, int>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x170017E0")]
		[DebuggerNonUserCode]
		public static MessageParser<MarketingAvatarPreset> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600896B")]
			[Cpp2IlInjected.Address(RVA = "0x18B76D0", Offset = "0x18B60D0", VA = "0x1818B76D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600896C")]
			[Cpp2IlInjected.Address(RVA = "0x18B7600", Offset = "0x18B6000", VA = "0x1818B7600")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600896D")]
			[Cpp2IlInjected.Address(RVA = "0x18B7730", Offset = "0x18B6130", VA = "0x1818B7730", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E3")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6008971")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008972")]
			[Cpp2IlInjected.Address(RVA = "0x18B78B0", Offset = "0x18B62B0", VA = "0x1818B78B0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E4")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6008973")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008974")]
			[Cpp2IlInjected.Address(RVA = "0x18B7840", Offset = "0x18B6240", VA = "0x1818B7840")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E5")]
		[DebuggerNonUserCode]
		public bool IsMale
		{
			[Cpp2IlInjected.Token(Token = "0x6008975")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return isMale_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008976")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				isMale_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E6")]
		[DebuggerNonUserCode]
		public int BodyTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6008977")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return bodyTypeIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008978")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				bodyTypeIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E7")]
		[DebuggerNonUserCode]
		public int SkinColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6008979")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return skinColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x600897A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				skinColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E8")]
		[DebuggerNonUserCode]
		public int EyeColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600897B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return eyeColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x600897C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				eyeColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017E9")]
		[DebuggerNonUserCode]
		public int HairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600897D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return hairStyle_;
			}
			[Cpp2IlInjected.Token(Token = "0x600897E")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				hairStyle_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017EA")]
		[DebuggerNonUserCode]
		public int HairColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600897F")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return hairColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008980")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				hairColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017EB")]
		[DebuggerNonUserCode]
		public int HairHighlightColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6008981")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return hairHighlightColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008982")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				hairHighlightColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017EC")]
		[DebuggerNonUserCode]
		public MapField<uint, int> FaceType
		{
			[Cpp2IlInjected.Token(Token = "0x6008983")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return faceType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017ED")]
		[DebuggerNonUserCode]
		public MapField<uint, Makeup> Makeup
		{
			[Cpp2IlInjected.Token(Token = "0x6008984")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return makeup_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017EE")]
		[DebuggerNonUserCode]
		public MapField<uint, int> Clothes
		{
			[Cpp2IlInjected.Token(Token = "0x6008985")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return clothes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008967")]
		[Cpp2IlInjected.Address(RVA = "0x18B4B80", Offset = "0x18B3580", VA = "0x1818B4B80")]
		public void AvatarToPreset(Profile profile)
		{
			//Discarded unreachable code: IL_001e
			ProfilePlayer player_ = profile.player_;
			bool avatarIsMale_ = player_.avatarIsMale_;
			Avatar activeAvatar = player_.ActiveAvatar;
			AvatarToPreset(avatarIsMale_, activeAvatar);
		}

		[Cpp2IlInjected.Token(Token = "0x6008968")]
		[Cpp2IlInjected.Address(RVA = "0x18B4BD0", Offset = "0x18B35D0", VA = "0x1818B4BD0")]
		public unsafe void AvatarToPreset(bool isMale, Avatar avatar)
		{
			//Discarded unreachable code: IL_009a, IL_00a0, IL_00a6
			//IL_0019: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			isMale_ = isMale;
			bool flag = ((MapField<TKey, TValue>)(object)avatar.clothes_).TryGetValue((TKey)5, out *(TValue*)num);
			int num3 = (bodyTypeIndex_ = avatar.bodyType_);
			int num4 = (skinColorIndex_ = avatar.skinColorIndex_);
			int num5 = (eyeColorIndex_ = avatar.eyeColor_);
			hairStyle_ = num;
			int num6 = (hairColorIndex_ = avatar.hairColorIndex_);
			int num7 = (hairHighlightColorIndex_ = avatar.hairHighlightColor_);
			((MapField<TKey, TValue>)(object)faceType_).Clear();
			MapField<uint, int> mapField = avatar.faceType_;
			bool flag2 = default(bool);
			if (flag2)
			{
				MapField<uint, int> mapField2 = faceType_;
			}
			bool flag3 = default(bool);
			if (flag3)
			{
			}
			bool flag4 = default(bool);
			if (!flag4)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008969")]
		[Cpp2IlInjected.Address(RVA = "0x18B6450", Offset = "0x18B4E50", VA = "0x1818B6450")]
		public void PresetToAvatar(Profile profile)
		{
			//Discarded unreachable code: IL_00df, IL_00e5, IL_00eb
			//IL_006e: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			int num = 0;
			ProfilePlayer player_ = profile.player_;
			bool flag = (player_.avatarIsMale_ = isMale_);
			Avatar activeAvatar = profile.player_.ActiveAvatar;
			int num2 = (activeAvatar.bodyType_ = bodyTypeIndex_);
			int num3 = (activeAvatar.skinColorIndex_ = skinColorIndex_);
			int num4 = (activeAvatar.eyeColor_ = eyeColorIndex_);
			MapField<uint, int> mapField = activeAvatar.clothes_;
			int num5 = hairStyle_;
			((MapField<TKey, TValue>)(object)mapField)[(TKey)5] = (TValue)num5;
			int num6 = (activeAvatar.hairColorIndex_ = hairColorIndex_);
			int num7 = (activeAvatar.hairHighlightColor_ = hairHighlightColorIndex_);
			((MapField<TKey, TValue>)(object)activeAvatar.faceType_).Clear();
			MapField<uint, int> mapField2 = faceType_;
			bool flag2 = default(bool);
			if (flag2)
			{
				MapField<uint, int> mapField3 = activeAvatar.faceType_;
			}
			((MapField<TKey, TValue>)(object)activeAvatar.makeup_).Clear();
			bool flag3 = default(bool);
			if (flag3)
			{
				MapField<uint, Makeup> mapField4 = activeAvatar.makeup_;
			}
			((MapField<TKey, TValue>)(object)activeAvatar.clothes_).Clear();
			bool flag4 = default(bool);
			if (flag4)
			{
				MapField<uint, int> mapField5 = activeAvatar.clothes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600896A")]
		[Cpp2IlInjected.Address(RVA = "0x18B5490", Offset = "0x18B3E90", VA = "0x1818B5490", Slot = "4")]
		public unsafe void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00c6, IL_00cc, IL_00d2, IL_00d8, IL_00de, IL_00e4
			//IL_0055: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			MakeupItemType makeupItemType = default(MakeupItemType);
			MakeupItemType makeupItemType2 = default(MakeupItemType);
			bool flag4 = default(bool);
			do
			{
				int num = 0;
				string text = name_;
				if ("HairStyle" != null)
				{
					context.AddInvalidMemberError("Preset must have a name", "Name");
				}
				if (!ProtoDatabase.Instance.TryGet("DefaultInventories", out *(DefaultInventories*)num))
				{
					context.AddError("Unable to find default inventories");
				}
				int num2 = hairStyle_;
				if (flag)
				{
				}
				string message = $"Hair style item {num} is not in default wardrobe";
				context.AddInvalidMemberError(message, "HairStyle");
				MapField<uint, Makeup> mapField = makeup_;
				if (flag2)
				{
					if (flag3)
					{
						string arg = name_;
						string message2 = $"Preset '{arg}' makeup is invalid: {makeupItemType} is {makeupItemType2}";
						context.AddInvalidMemberError(message2, "Makeup");
					}
					if (flag4)
					{
					}
					string message3 = $"Makeup item {flag2} is not in default inventory";
					context.AddInvalidMemberError(message3, "Makeup");
				}
			}
			while (makeupItemType2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600896E")]
		[Cpp2IlInjected.Address(RVA = "0x18B7280", Offset = "0x18B5C80", VA = "0x1818B7280")]
		[DebuggerNonUserCode]
		public MarketingAvatarPreset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600896F")]
		[Cpp2IlInjected.Address(RVA = "0x18B73A0", Offset = "0x18B5DA0", VA = "0x1818B73A0")]
		[DebuggerNonUserCode]
		public MarketingAvatarPreset(MarketingAvatarPreset other)
		{
			string text = (name_ = other.name_);
			string text2 = (iconAddress_ = other.iconAddress_);
			bool flag = (isMale_ = other.isMale_);
			int num = (bodyTypeIndex_ = other.bodyTypeIndex_);
			int num2 = (skinColorIndex_ = other.skinColorIndex_);
			int num3 = (eyeColorIndex_ = other.eyeColorIndex_);
			int num4 = (hairStyle_ = other.hairStyle_);
			int num5 = (hairColorIndex_ = other.hairColorIndex_);
			int num6 = (hairHighlightColorIndex_ = other.hairHighlightColorIndex_);
			MapField<uint, int> mapField = (faceType_ = (MapField<uint, int>)(object)((MapField<TKey, TValue>)(object)other.faceType_).Clone());
			MapField<uint, Makeup> mapField2 = (makeup_ = (MapField<uint, Makeup>)(object)((MapField<TKey, TValue>)(object)other.makeup_).Clone());
			MapField<uint, int> mapField3 = (clothes_ = (MapField<uint, int>)(object)((MapField<TKey, TValue>)(object)other.clothes_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008970")]
		[Cpp2IlInjected.Address(RVA = "0x18B5430", Offset = "0x18B3E30", VA = "0x1818B5430", Slot = "11")]
		[DebuggerNonUserCode]
		public MarketingAvatarPreset Clone()
		{
			return new MarketingAvatarPreset(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008986")]
		[Cpp2IlInjected.Address(RVA = "0x18B5B60", Offset = "0x18B4560", VA = "0x1818B5B60", Slot = "0")]
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
				string text = name_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = iconAddress_;
					bool flag2 = default(bool);
					if (!flag2 && isMale_ == flag2 && bodyTypeIndex_ == (flag2 ? 1 : 0) && skinColorIndex_ == (flag2 ? 1 : 0) && eyeColorIndex_ == (flag2 ? 1 : 0) && hairStyle_ == (flag2 ? 1 : 0) && hairColorIndex_ == (flag2 ? 1 : 0) && hairHighlightColorIndex_ == (flag2 ? 1 : 0))
					{
						MapField<uint, int> mapField = faceType_;
						bool flag3 = default(bool);
						if (flag3)
						{
							MapField<uint, Makeup> mapField2 = makeup_;
							bool flag4 = default(bool);
							if (flag4)
							{
								MapField<uint, int> mapField3 = clothes_;
								bool flag5 = default(bool);
								if (flag5)
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008987")]
		[Cpp2IlInjected.Address(RVA = "0x18B59F0", Offset = "0x18B43F0", VA = "0x1818B59F0", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(MarketingAvatarPreset other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.name_;
				if (!(name_ != text))
				{
					string text2 = other.iconAddress_;
					if (!(iconAddress_ != text2))
					{
						bool flag = other.isMale_;
						if (isMale_ == flag)
						{
							int num = other.bodyTypeIndex_;
							if (bodyTypeIndex_ == num)
							{
								int num2 = other.skinColorIndex_;
								if (skinColorIndex_ == num2)
								{
									int num3 = other.eyeColorIndex_;
									if (eyeColorIndex_ == num3)
									{
										int num4 = other.hairStyle_;
										if (hairStyle_ == num4)
										{
											int num5 = other.hairColorIndex_;
											if (hairColorIndex_ == num5)
											{
												int num6 = other.hairHighlightColorIndex_;
												if (hairHighlightColorIndex_ == num6)
												{
													MapField<uint, int> mapField = faceType_;
													MapField<uint, int> mapField2 = other.faceType_;
													if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
													{
														MapField<uint, Makeup> mapField3 = makeup_;
														MapField<uint, Makeup> mapField4 = other.makeup_;
														if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
														{
															MapField<uint, int> mapField5 = clothes_;
															MapField<uint, int> mapField6 = other.clothes_;
															if (((MapField<TKey, TValue>)(object)mapField5).Equals((MapField<, >)(object)mapField6))
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
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008988")]
		[Cpp2IlInjected.Address(RVA = "0x18B5EA0", Offset = "0x18B48A0", VA = "0x1818B5EA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b5
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = iconAddress_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			if (isMale_)
			{
			}
			if (bodyTypeIndex_ != 0)
			{
			}
			if (skinColorIndex_ != 0)
			{
			}
			if (eyeColorIndex_ != 0)
			{
			}
			if (hairStyle_ != 0)
			{
			}
			if (hairColorIndex_ != 0)
			{
			}
			if (hairHighlightColorIndex_ != 0)
			{
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)faceType_).GetHashCode();
			int hashCode4 = ((MapField<TKey, TValue>)(object)makeup_).GetHashCode();
			int hashCode5 = ((MapField<TKey, TValue>)(object)clothes_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return hashCode5;
		}

		[Cpp2IlInjected.Token(Token = "0x6008989")]
		[Cpp2IlInjected.Address(RVA = "0x18B6C40", Offset = "0x18B5640", VA = "0x1818B6C40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600898A")]
		[Cpp2IlInjected.Address(RVA = "0x18B6CA0", Offset = "0x18B56A0", VA = "0x1818B6CA0", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0144
			if (name_.m_stringLength != 0)
			{
				string value = name_;
				output.WriteString(value);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value2 = iconAddress_;
				output.WriteString(value2);
			}
			if (isMale_)
			{
				bool value3 = isMale_;
				output.WriteBool(value3);
			}
			if (bodyTypeIndex_ != 0)
			{
				int value4 = bodyTypeIndex_;
				output.WriteInt32(value4);
			}
			if (skinColorIndex_ != 0)
			{
				int value5 = skinColorIndex_;
				output.WriteInt32(value5);
			}
			if (eyeColorIndex_ != 0)
			{
				int value6 = eyeColorIndex_;
				output.WriteInt32(value6);
			}
			if (hairStyle_ != 0)
			{
				int value7 = hairStyle_;
				output.WriteInt32(value7);
			}
			if (hairColorIndex_ != 0)
			{
				int value8 = hairColorIndex_;
				output.WriteInt32(value8);
			}
			if (hairHighlightColorIndex_ != 0)
			{
				int value9 = hairHighlightColorIndex_;
				output.WriteInt32(value9);
			}
			MapField<uint, int> mapField = faceType_;
			MapField<uint, int>.Codec map_faceType_codec = _map_faceType_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_faceType_codec);
			MapField<uint, Makeup> mapField2 = makeup_;
			MapField<uint, Makeup>.Codec map_makeup_codec = _map_makeup_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_makeup_codec);
			MapField<uint, int> mapField3 = clothes_;
			MapField<uint, int>.Codec map_clothes_codec = _map_clothes_codec;
			((MapField<TKey, TValue>)(object)mapField3).WriteTo(output, (MapField<, >.Codec)(object)map_clothes_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600898B")]
		[Cpp2IlInjected.Address(RVA = "0x18B4FE0", Offset = "0x18B39E0", VA = "0x1818B4FE0", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_016d
			string text = name_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = iconAddress_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			int num4 = bodyTypeIndex_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			int num6 = skinColorIndex_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			int num8 = eyeColorIndex_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num += num9;
			}
			int num10 = hairStyle_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num += num11;
			}
			int num12 = hairColorIndex_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num += num13;
			}
			int num14 = hairHighlightColorIndex_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num += num15;
			}
			MapField<uint, int> mapField = faceType_;
			MapField<uint, int>.Codec map_faceType_codec = _map_faceType_codec;
			int num16 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_faceType_codec);
			MapField<uint, Makeup> mapField2 = makeup_;
			MapField<uint, Makeup>.Codec map_makeup_codec = _map_makeup_codec;
			int num17 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_makeup_codec);
			MapField<uint, int> mapField3 = clothes_;
			MapField<uint, int>.Codec map_clothes_codec = _map_clothes_codec;
			int num18 = ((MapField<TKey, TValue>)(object)mapField3).CalculateSize((MapField<, >.Codec)(object)map_clothes_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num19 = unknownFields.CalculateSize();
				num += num19;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600898C")]
		[Cpp2IlInjected.Address(RVA = "0x18B6310", Offset = "0x18B4D10", VA = "0x1818B6310", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(MarketingAvatarPreset other)
		{
			//Discarded unreachable code: IL_012d
			if (other != null)
			{
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				string text2 = other.iconAddress_;
				if (text2.m_stringLength != 0)
				{
					IconAddress = text2;
				}
				bool flag = other.isMale_;
				if (flag)
				{
					isMale_ = flag;
				}
				int num = other.bodyTypeIndex_;
				if (num != 0)
				{
					bodyTypeIndex_ = num;
				}
				int num2 = other.skinColorIndex_;
				if (num2 != 0)
				{
					skinColorIndex_ = num2;
				}
				int num3 = other.eyeColorIndex_;
				if (num3 != 0)
				{
					eyeColorIndex_ = num3;
				}
				int num4 = other.hairStyle_;
				if (num4 != 0)
				{
					hairStyle_ = num4;
				}
				int num5 = other.hairColorIndex_;
				if (num5 != 0)
				{
					hairColorIndex_ = num5;
				}
				int num6 = other.hairHighlightColorIndex_;
				if (num6 != 0)
				{
					hairHighlightColorIndex_ = num6;
				}
				MapField<uint, int> mapField = faceType_;
				MapField<uint, int> mapField2 = other.faceType_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				MapField<uint, Makeup> mapField3 = makeup_;
				MapField<uint, Makeup> mapField4 = other.makeup_;
				((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
				MapField<uint, int> mapField5 = clothes_;
				MapField<uint, int> mapField6 = other.clothes_;
				((MapField<TKey, TValue>)(object)mapField5).Add((IDictionary<, >)(object)mapField6);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600898D")]
		[Cpp2IlInjected.Address(RVA = "0x18B6050", Offset = "0x18B4A50", VA = "0x1818B6050", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0162
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 48)
			{
				if ((int)num > 72)
				{
					if (num == 82)
					{
						MapField<uint, int> mapField = faceType_;
						MapField<uint, int>.Codec map_faceType_codec = _map_faceType_codec;
						((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_faceType_codec);
					}
					if (num == 90)
					{
						MapField<uint, Makeup> mapField2 = makeup_;
						MapField<uint, Makeup>.Codec map_makeup_codec = _map_makeup_codec;
						((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_makeup_codec);
					}
					if (num != 98)
					{
						goto IL_014b;
					}
					MapField<uint, int> mapField3 = clothes_;
					MapField<uint, int>.Codec map_clothes_codec = _map_clothes_codec;
					((MapField<TKey, TValue>)(object)mapField3).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_clothes_codec);
				}
				int num2 = default(int);
				if (num == 56)
				{
					num2 = (hairStyle_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num2 == 64)
				{
					num3 = (hairColorIndex_ = input.ReadInt32());
				}
				if (num3 != 72)
				{
					goto IL_014b;
				}
				int num4 = (hairHighlightColorIndex_ = input.ReadInt32());
			}
			int num7 = default(int);
			if ((int)num > 24)
			{
				int num5 = default(int);
				if (num == 32)
				{
					num5 = (bodyTypeIndex_ = input.ReadInt32());
				}
				int num6 = default(int);
				if (num5 == 40)
				{
					num6 = (skinColorIndex_ = input.ReadInt32());
				}
				if (num6 != 48)
				{
					goto IL_014b;
				}
				num7 = (eyeColorIndex_ = input.ReadInt32());
			}
			string text2 = default(string);
			if (num7 == 10)
			{
				text2 = (Name = input.ReadString());
			}
			string text4 = default(string);
			if ((long)text2 == 18)
			{
				text4 = (IconAddress = input.ReadString());
			}
			if ((long)text4 == 24)
			{
				bool flag = (isMale_ = input.ReadBool());
			}
			goto IL_014b;
			IL_014b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600898E")]
		[Cpp2IlInjected.Address(RVA = "0x18B5D10", Offset = "0x18B4710", VA = "0x1818B5D10", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				string text = name_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600898F")]
		[Cpp2IlInjected.Address(RVA = "0x18B6860", Offset = "0x18B5260", VA = "0x1818B6860", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_001a, IL_0027, IL_002f, IL_0037, IL_003f, IL_0047, IL_004f, IL_0057, IL_005f, IL_0070, IL_0076
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 11)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				Name = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008990")]
		[Cpp2IlInjected.Address(RVA = "0x18B52C0", Offset = "0x18B3CC0", VA = "0x1818B52C0", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0013, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d
			if (fieldNumber - 1 <= 11)
			{
				Name = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008991")]
		[Cpp2IlInjected.Address(RVA = "0x18B6F60", Offset = "0x18B5960", VA = "0x1818B6F60")]
		static MarketingAvatarPreset()
		{
			Func<MarketingAvatarPreset> func = default(Func<MarketingAvatarPreset>);
			_parser = (MessageParser<MarketingAvatarPreset>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<uint> fieldCodec = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			FieldCodec<int> fieldCodec2 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num = default(uint);
			_parser = (MessageParser<MarketingAvatarPreset>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			FieldCodec<uint> fieldCodec3 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<Makeup> parser = Meta.Customization.Makeup._parser;
			uint num2 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<Makeup>(num2, (MessageParser<>)(object)parser);
			uint num3 = default(uint);
			_parser = (MessageParser<MarketingAvatarPreset>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num3);
			FieldCodec<uint> fieldCodec5 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			FieldCodec<int> fieldCodec6 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num4 = default(uint);
			_parser = (MessageParser<MarketingAvatarPreset>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec5, (FieldCodec<>)(object)fieldCodec6, num4);
			/*Error: Unexpected end of block*/;
		}
	}
}
