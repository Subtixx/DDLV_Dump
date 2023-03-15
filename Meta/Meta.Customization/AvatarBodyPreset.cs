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
	[Cpp2IlInjected.Token(Token = "0x20010E2")]
	public sealed class AvatarBodyPreset : IDataValidation, IMessage<AvatarBodyPreset>, IMessage, IEquatable<AvatarBodyPreset>, IDeepCloneable<AvatarBodyPreset>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400458A")]
		private static readonly MessageParser<AvatarBodyPreset> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400458B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400458C")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400458D")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400458E")]
		public const int IconAddressFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400458F")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4004590")]
		public const int IsMaleFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004591")]
		private bool isMale_;

		[Cpp2IlInjected.Token(Token = "0x4004592")]
		public const int BodyTypeIndexFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4004593")]
		private int bodyTypeIndex_;

		[Cpp2IlInjected.Token(Token = "0x4004594")]
		public const int SkinColorIndexFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004595")]
		private int skinColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x4004596")]
		public const int EyeColorIndexFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4004597")]
		private int eyeColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x4004598")]
		public const int HairStyleFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004599")]
		private int hairStyle_;

		[Cpp2IlInjected.Token(Token = "0x400459A")]
		public const int FacialHairUpperFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400459B")]
		private int facialHairUpper_;

		[Cpp2IlInjected.Token(Token = "0x400459C")]
		public const int FacialHairLowerFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400459D")]
		private int facialHairLower_;

		[Cpp2IlInjected.Token(Token = "0x400459E")]
		public const int HairColorIndexFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400459F")]
		private int hairColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x40045A0")]
		public const int HairHighlightColorIndexFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40045A1")]
		private int hairHighlightColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x40045A2")]
		public const int FaceTypeFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x40045A3")]
		private static readonly MapField<uint, int>.Codec _map_faceType_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40045A4")]
		private readonly MapField<uint, int> faceType_ = (MapField<uint, int>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x40045A5")]
		public const int MakeupFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x40045A6")]
		private static readonly MapField<uint, Makeup>.Codec _map_makeup_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40045A7")]
		private readonly MapField<uint, Makeup> makeup_ = (MapField<uint, Makeup>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x170017CC")]
		[DebuggerNonUserCode]
		public static MessageParser<AvatarBodyPreset> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008921")]
			[Cpp2IlInjected.Address(RVA = "0x18EFB60", Offset = "0x18EE560", VA = "0x1818EFB60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017CD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008922")]
			[Cpp2IlInjected.Address(RVA = "0x18EFA90", Offset = "0x18EE490", VA = "0x1818EFA90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017CE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008923")]
			[Cpp2IlInjected.Address(RVA = "0x18EFBC0", Offset = "0x18EE5C0", VA = "0x1818EFBC0", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017CF")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6008927")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008928")]
			[Cpp2IlInjected.Address(RVA = "0x18EFD40", Offset = "0x18EE740", VA = "0x1818EFD40")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D0")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6008929")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600892A")]
			[Cpp2IlInjected.Address(RVA = "0x18EFCD0", Offset = "0x18EE6D0", VA = "0x1818EFCD0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D1")]
		[DebuggerNonUserCode]
		public bool IsMale
		{
			[Cpp2IlInjected.Token(Token = "0x600892B")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return isMale_;
			}
			[Cpp2IlInjected.Token(Token = "0x600892C")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				isMale_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D2")]
		[DebuggerNonUserCode]
		public int BodyTypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600892D")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return bodyTypeIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x600892E")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				bodyTypeIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D3")]
		[DebuggerNonUserCode]
		public int SkinColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600892F")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return skinColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008930")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				skinColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D4")]
		[DebuggerNonUserCode]
		public int EyeColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6008931")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return eyeColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008932")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				eyeColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D5")]
		[DebuggerNonUserCode]
		public int HairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6008933")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return hairStyle_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008934")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				hairStyle_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D6")]
		[DebuggerNonUserCode]
		public int FacialHairUpper
		{
			[Cpp2IlInjected.Token(Token = "0x6008935")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return facialHairUpper_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008936")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				facialHairUpper_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D7")]
		[DebuggerNonUserCode]
		public int FacialHairLower
		{
			[Cpp2IlInjected.Token(Token = "0x6008937")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return facialHairLower_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008938")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				facialHairLower_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D8")]
		[DebuggerNonUserCode]
		public int HairColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6008939")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return hairColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x600893A")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set
			{
				hairColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017D9")]
		[DebuggerNonUserCode]
		public int HairHighlightColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600893B")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return hairHighlightColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x600893C")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				hairHighlightColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DA")]
		[DebuggerNonUserCode]
		public MapField<uint, int> FaceType
		{
			[Cpp2IlInjected.Token(Token = "0x600893D")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return faceType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DB")]
		[DebuggerNonUserCode]
		public MapField<uint, Makeup> Makeup
		{
			[Cpp2IlInjected.Token(Token = "0x600893E")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return makeup_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600891D")]
		[Cpp2IlInjected.Address(RVA = "0x18ED520", Offset = "0x18EBF20", VA = "0x1818ED520")]
		public void AvatarToPreset(Profile profile)
		{
			//Discarded unreachable code: IL_001e
			ProfilePlayer player_ = profile.player_;
			bool avatarIsMale_ = player_.avatarIsMale_;
			Avatar activeAvatar = player_.ActiveAvatar;
			AvatarToPreset(avatarIsMale_, activeAvatar);
		}

		[Cpp2IlInjected.Token(Token = "0x600891E")]
		[Cpp2IlInjected.Address(RVA = "0x18ED190", Offset = "0x18EBB90", VA = "0x1818ED190")]
		public unsafe void AvatarToPreset(bool isMale, Avatar avatar)
		{
			//Discarded unreachable code: IL_00c6, IL_00cc
			//IL_0019: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			isMale_ = isMale;
			bool flag = ((MapField<TKey, TValue>)(object)avatar.clothes_).TryGetValue((TKey)5, out *(TValue*)num);
			bool flag2 = ((MapField<TKey, TValue>)(object)avatar.clothes_).TryGetValue((TKey)16, out *(TValue*)num);
			bool flag3 = ((MapField<TKey, TValue>)(object)avatar.clothes_).TryGetValue((TKey)17, out *(TValue*)num);
			int num3 = (bodyTypeIndex_ = avatar.bodyType_);
			int num4 = (skinColorIndex_ = avatar.skinColorIndex_);
			int num5 = (eyeColorIndex_ = avatar.eyeColor_);
			hairStyle_ = num;
			facialHairUpper_ = num;
			facialHairLower_ = num;
			int num6 = (hairColorIndex_ = avatar.hairColorIndex_);
			int num7 = (hairHighlightColorIndex_ = avatar.hairHighlightColor_);
			((MapField<TKey, TValue>)(object)faceType_).Clear();
			MapField<uint, int> mapField = avatar.faceType_;
			bool flag4 = default(bool);
			if (flag4)
			{
				MapField<uint, int> mapField2 = faceType_;
			}
			bool flag5 = default(bool);
			if (!flag5)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600891F")]
		[Cpp2IlInjected.Address(RVA = "0x18EEA00", Offset = "0x18ED400", VA = "0x1818EEA00")]
		public void PresetToAvatar(Profile profile)
		{
			//Discarded unreachable code: IL_00ff, IL_0105
			//IL_006e: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_008a: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			//IL_00a6: Expected O, but got I4
			int num = 0;
			ProfilePlayer player_ = profile.player_;
			bool flag = (player_.avatarIsMale_ = isMale_);
			Avatar activeAvatar = profile.player_.ActiveAvatar;
			int num2 = (activeAvatar.bodyType_ = bodyTypeIndex_);
			int num3 = (activeAvatar.skinColorIndex_ = skinColorIndex_);
			int num4 = (activeAvatar.eyeColor_ = eyeColorIndex_);
			MapField<uint, int> clothes_ = activeAvatar.clothes_;
			int num5 = hairStyle_;
			((MapField<TKey, TValue>)(object)clothes_)[(TKey)5] = (TValue)num5;
			MapField<uint, int> clothes_2 = activeAvatar.clothes_;
			int num6 = facialHairUpper_;
			((MapField<TKey, TValue>)(object)clothes_2)[(TKey)16] = (TValue)num6;
			MapField<uint, int> clothes_3 = activeAvatar.clothes_;
			int num7 = facialHairLower_;
			((MapField<TKey, TValue>)(object)clothes_3)[(TKey)17] = (TValue)num7;
			int num8 = (activeAvatar.hairColorIndex_ = hairColorIndex_);
			int num9 = (activeAvatar.hairHighlightColor_ = hairHighlightColorIndex_);
			((MapField<TKey, TValue>)(object)activeAvatar.faceType_).Clear();
			MapField<uint, int> mapField = faceType_;
			bool flag2 = default(bool);
			if (flag2)
			{
				MapField<uint, int> mapField2 = activeAvatar.faceType_;
			}
			((MapField<TKey, TValue>)(object)activeAvatar.makeup_).Clear();
			bool flag3 = default(bool);
			if (flag3)
			{
				MapField<uint, Makeup> mapField3 = activeAvatar.makeup_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008920")]
		[Cpp2IlInjected.Address(RVA = "0x18EDA70", Offset = "0x18EC470", VA = "0x1818EDA70", Slot = "4")]
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

		[Cpp2IlInjected.Token(Token = "0x6008924")]
		[Cpp2IlInjected.Address(RVA = "0x18EF9A0", Offset = "0x18EE3A0", VA = "0x1818EF9A0")]
		[DebuggerNonUserCode]
		public AvatarBodyPreset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008925")]
		[Cpp2IlInjected.Address(RVA = "0x18EF790", Offset = "0x18EE190", VA = "0x1818EF790")]
		[DebuggerNonUserCode]
		public AvatarBodyPreset(AvatarBodyPreset other)
		{
			string text = (name_ = other.name_);
			string text2 = (iconAddress_ = other.iconAddress_);
			bool flag = (isMale_ = other.isMale_);
			int num = (bodyTypeIndex_ = other.bodyTypeIndex_);
			int num2 = (skinColorIndex_ = other.skinColorIndex_);
			int num3 = (eyeColorIndex_ = other.eyeColorIndex_);
			int num4 = (hairStyle_ = other.hairStyle_);
			int num5 = (facialHairUpper_ = other.facialHairUpper_);
			int num6 = (facialHairLower_ = other.facialHairLower_);
			int num7 = (hairColorIndex_ = other.hairColorIndex_);
			int num8 = (hairHighlightColorIndex_ = other.hairHighlightColorIndex_);
			MapField<uint, int> mapField = (faceType_ = (MapField<uint, int>)(object)((MapField<TKey, TValue>)(object)other.faceType_).Clone());
			MapField<uint, Makeup> mapField2 = (makeup_ = (MapField<uint, Makeup>)(object)((MapField<TKey, TValue>)(object)other.makeup_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008926")]
		[Cpp2IlInjected.Address(RVA = "0x18EDA10", Offset = "0x18EC410", VA = "0x1818EDA10", Slot = "11")]
		[DebuggerNonUserCode]
		public AvatarBodyPreset Clone()
		{
			return new AvatarBodyPreset(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600893F")]
		[Cpp2IlInjected.Address(RVA = "0x18EDFD0", Offset = "0x18EC9D0", VA = "0x1818EDFD0", Slot = "0")]
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
					if (!flag2 && isMale_ == flag2 && bodyTypeIndex_ == (flag2 ? 1 : 0) && skinColorIndex_ == (flag2 ? 1 : 0) && eyeColorIndex_ == (flag2 ? 1 : 0) && hairStyle_ == (flag2 ? 1 : 0) && facialHairUpper_ == (flag2 ? 1 : 0) && facialHairLower_ == (flag2 ? 1 : 0) && hairColorIndex_ == (flag2 ? 1 : 0) && hairHighlightColorIndex_ == (flag2 ? 1 : 0))
					{
						MapField<uint, int> mapField = faceType_;
						bool flag3 = default(bool);
						if (flag3)
						{
							MapField<uint, Makeup> mapField2 = makeup_;
							bool flag4 = default(bool);
							if (flag4)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008940")]
		[Cpp2IlInjected.Address(RVA = "0x18EE170", Offset = "0x18ECB70", VA = "0x1818EE170", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(AvatarBodyPreset other)
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
											int num5 = other.facialHairUpper_;
											if (facialHairUpper_ == num5)
											{
												int num6 = other.facialHairLower_;
												if (facialHairLower_ == num6)
												{
													int num7 = other.hairColorIndex_;
													if (hairColorIndex_ == num7)
													{
														int num8 = other.hairHighlightColorIndex_;
														if (hairHighlightColorIndex_ == num8)
														{
															MapField<uint, int> mapField = faceType_;
															MapField<uint, int> mapField2 = other.faceType_;
															if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
															{
																MapField<uint, Makeup> mapField3 = makeup_;
																MapField<uint, Makeup> mapField4 = other.makeup_;
																if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
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
			int num9 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008941")]
		[Cpp2IlInjected.Address(RVA = "0x18EE450", Offset = "0x18ECE50", VA = "0x1818EE450", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00ba
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
			if (facialHairUpper_ != 0)
			{
			}
			if (facialHairLower_ != 0)
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
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode4;
		}

		[Cpp2IlInjected.Token(Token = "0x6008942")]
		[Cpp2IlInjected.Address(RVA = "0x18EF1A0", Offset = "0x18EDBA0", VA = "0x1818EF1A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008943")]
		[Cpp2IlInjected.Address(RVA = "0x18EF200", Offset = "0x18EDC00", VA = "0x1818EF200", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_015d
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
			if (facialHairUpper_ != 0)
			{
				int value8 = facialHairUpper_;
				output.WriteInt32(value8);
			}
			if (facialHairLower_ != 0)
			{
				int value9 = facialHairLower_;
				output.WriteInt32(value9);
			}
			if (hairColorIndex_ != 0)
			{
				int value10 = hairColorIndex_;
				output.WriteInt32(value10);
			}
			if (hairHighlightColorIndex_ != 0)
			{
				int value11 = hairHighlightColorIndex_;
				output.WriteInt32(value11);
			}
			MapField<uint, int> mapField = faceType_;
			MapField<uint, int>.Codec map_faceType_codec = _map_faceType_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_faceType_codec);
			MapField<uint, Makeup> mapField2 = makeup_;
			MapField<uint, Makeup>.Codec map_makeup_codec = _map_makeup_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_makeup_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008944")]
		[Cpp2IlInjected.Address(RVA = "0x18ED570", Offset = "0x18EBF70", VA = "0x1818ED570", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0195
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
			int num12 = facialHairUpper_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num += num13;
			}
			int num14 = facialHairLower_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num += num15;
			}
			int num16 = hairColorIndex_;
			if (num16 != 0)
			{
				int num17 = CodedOutputStream.ComputeInt32Size(num16);
				num17++;
				num += num17;
			}
			int num18 = hairHighlightColorIndex_;
			if (num18 != 0)
			{
				int num19 = CodedOutputStream.ComputeInt32Size(num18);
				num19++;
				num += num19;
			}
			MapField<uint, int> mapField = faceType_;
			MapField<uint, int>.Codec map_faceType_codec = _map_faceType_codec;
			int num20 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_faceType_codec);
			MapField<uint, Makeup> mapField2 = makeup_;
			MapField<uint, Makeup>.Codec map_makeup_codec = _map_makeup_codec;
			int num21 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_makeup_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num22 = unknownFields.CalculateSize();
				num += num22;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008945")]
		[Cpp2IlInjected.Address(RVA = "0x18EE620", Offset = "0x18ED020", VA = "0x1818EE620", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(AvatarBodyPreset other)
		{
			//Discarded unreachable code: IL_013e
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
				int num5 = other.facialHairUpper_;
				if (num5 != 0)
				{
					facialHairUpper_ = num5;
				}
				int num6 = other.facialHairLower_;
				if (num6 != 0)
				{
					facialHairLower_ = num6;
				}
				int num7 = other.hairColorIndex_;
				if (num7 != 0)
				{
					hairColorIndex_ = num7;
				}
				int num8 = other.hairHighlightColorIndex_;
				if (num8 != 0)
				{
					hairHighlightColorIndex_ = num8;
				}
				MapField<uint, int> mapField = faceType_;
				MapField<uint, int> mapField2 = other.faceType_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				MapField<uint, Makeup> mapField3 = makeup_;
				MapField<uint, Makeup> mapField4 = other.makeup_;
				((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008946")]
		[Cpp2IlInjected.Address(RVA = "0x18EE760", Offset = "0x18ED160", VA = "0x1818EE760", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0178
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 48)
			{
				if ((int)num > 72)
				{
					if ((int)num > 88)
					{
						if (num == 98)
						{
							MapField<uint, int> mapField = faceType_;
							MapField<uint, int>.Codec map_faceType_codec = _map_faceType_codec;
							((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_faceType_codec);
						}
						if (num != 106)
						{
							goto IL_0161;
						}
						MapField<uint, Makeup> mapField2 = makeup_;
						MapField<uint, Makeup>.Codec map_makeup_codec = _map_makeup_codec;
						((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_makeup_codec);
					}
					int num2 = default(int);
					if (num == 80)
					{
						num2 = (hairColorIndex_ = input.ReadInt32());
					}
					if (num2 != 88)
					{
						goto IL_0161;
					}
					int num3 = (hairHighlightColorIndex_ = input.ReadInt32());
				}
				int num4 = default(int);
				if (num == 56)
				{
					num4 = (hairStyle_ = input.ReadInt32());
				}
				int num5 = default(int);
				if (num4 == 64)
				{
					num5 = (facialHairUpper_ = input.ReadInt32());
				}
				if (num5 != 72)
				{
					goto IL_0161;
				}
				int num6 = (facialHairLower_ = input.ReadInt32());
			}
			int num9 = default(int);
			if ((int)num > 24)
			{
				int num7 = default(int);
				if (num == 32)
				{
					num7 = (bodyTypeIndex_ = input.ReadInt32());
				}
				int num8 = default(int);
				if (num7 == 40)
				{
					num8 = (skinColorIndex_ = input.ReadInt32());
				}
				if (num8 != 48)
				{
					goto IL_0161;
				}
				num9 = (eyeColorIndex_ = input.ReadInt32());
			}
			string text2 = default(string);
			if (num9 == 10)
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
			goto IL_0161;
			IL_0161:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008947")]
		[Cpp2IlInjected.Address(RVA = "0x18EE2C0", Offset = "0x18ECCC0", VA = "0x1818EE2C0", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 12)
			{
				string text = name_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008948")]
		[Cpp2IlInjected.Address(RVA = "0x18EED70", Offset = "0x18ED770", VA = "0x1818EED70", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_001a, IL_0027, IL_002f, IL_0037, IL_003f, IL_0047, IL_004f, IL_0057, IL_005f, IL_0067, IL_006f, IL_0080, IL_0086
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 12)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				Name = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008949")]
		[Cpp2IlInjected.Address(RVA = "0x18ED880", Offset = "0x18EC280", VA = "0x1818ED880", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0013, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f
			if (fieldNumber - 1 <= 12)
			{
				Name = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600894A")]
		[Cpp2IlInjected.Address(RVA = "0x18EF4E0", Offset = "0x18EDEE0", VA = "0x1818EF4E0")]
		static AvatarBodyPreset()
		{
			Func<AvatarBodyPreset> func = default(Func<AvatarBodyPreset>);
			_parser = (MessageParser<AvatarBodyPreset>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<uint> fieldCodec = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			FieldCodec<int> fieldCodec2 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num = default(uint);
			_parser = (MessageParser<AvatarBodyPreset>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			FieldCodec<uint> fieldCodec3 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<Makeup> parser = Meta.Customization.Makeup._parser;
			uint num2 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<Makeup>(num2, (MessageParser<>)(object)parser);
			uint num3 = default(uint);
			_parser = (MessageParser<AvatarBodyPreset>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num3);
			/*Error: Unexpected end of block*/;
		}
	}
}
