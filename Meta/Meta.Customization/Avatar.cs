using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010DB")]
	public sealed class Avatar : IAvatar, IDataValidation, IMessage<Avatar>, IMessage, IEquatable<Avatar>, IDeepCloneable<Avatar>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400455B")]
		private static readonly MessageParser<Avatar> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400455C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400455D")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400455E")]
		private uint id_;

		[Cpp2IlInjected.Token(Token = "0x400455F")]
		public const int ClothesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4004560")]
		private static readonly MapField<uint, int>.Codec _map_clothes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004561")]
		private readonly MapField<uint, int> clothes_;

		[Cpp2IlInjected.Token(Token = "0x4004562")]
		public const int IncompatibleClothesFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4004563")]
		private static readonly MapField<uint, int>.Codec _map_incompatibleClothes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004564")]
		private readonly MapField<uint, int> incompatibleClothes_;

		[Cpp2IlInjected.Token(Token = "0x4004565")]
		public const int SkinColorIndexFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004566")]
		private int skinColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x4004567")]
		public const int EyeColorFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4004568")]
		private int eyeColor_;

		[Cpp2IlInjected.Token(Token = "0x4004569")]
		public const int HairColorIndexFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400456A")]
		private int hairColorIndex_;

		[Cpp2IlInjected.Token(Token = "0x400456B")]
		public const int HairHighlightColorFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400456C")]
		private int hairHighlightColor_;

		[Cpp2IlInjected.Token(Token = "0x400456D")]
		public const int BodyTypeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400456E")]
		private int bodyType_;

		[Cpp2IlInjected.Token(Token = "0x400456F")]
		public const int FaceTypeFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4004570")]
		private static readonly MapField<uint, int>.Codec _map_faceType_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004571")]
		private readonly MapField<uint, int> faceType_;

		[Cpp2IlInjected.Token(Token = "0x4004572")]
		public const int MakeupFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4004573")]
		private static readonly MapField<uint, Makeup>.Codec _map_makeup_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004574")]
		private readonly MapField<uint, Makeup> makeup_;

		[Cpp2IlInjected.Token(Token = "0x4004575")]
		public const int ClothingCustomizationFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4004576")]
		private static readonly MapField<int, int>.Codec _map_clothingCustomization_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004577")]
		private readonly MapField<int, int> clothingCustomization_;

		[Cpp2IlInjected.Token(Token = "0x170017B2")]
		IReadOnlyDictionary<uint, int> IAvatar.Clothes
		{
			[Cpp2IlInjected.Token(Token = "0x60088BC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "4")]
			get
			{
				MapField<uint, int> mapField = clothes_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B3")]
		IReadOnlyDictionary<uint, int> IAvatar.FaceType
		{
			[Cpp2IlInjected.Token(Token = "0x60088BD")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "8")]
			get
			{
				MapField<uint, int> mapField = faceType_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B4")]
		IReadOnlyDictionary<uint, Makeup> IAvatar.Makeup
		{
			[Cpp2IlInjected.Token(Token = "0x60088BE")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "9")]
			get
			{
				MapField<uint, Makeup> mapField = makeup_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B5")]
		[DebuggerNonUserCode]
		public static MessageParser<Avatar> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60088C3")]
			[Cpp2IlInjected.Address(RVA = "0x18F2330", Offset = "0x18F0D30", VA = "0x1818F2330")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60088C4")]
			[Cpp2IlInjected.Address(RVA = "0x18F2260", Offset = "0x18F0C60", VA = "0x1818F2260")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60088C5")]
			[Cpp2IlInjected.Address(RVA = "0x18F2390", Offset = "0x18F0D90", VA = "0x1818F2390", Slot = "18")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B8")]
		[DebuggerNonUserCode]
		public uint Id
		{
			[Cpp2IlInjected.Token(Token = "0x60088C9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x60088CA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017B9")]
		[DebuggerNonUserCode]
		public MapField<uint, int> Clothes
		{
			[Cpp2IlInjected.Token(Token = "0x60088CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return clothes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BA")]
		[DebuggerNonUserCode]
		public MapField<uint, int> IncompatibleClothes
		{
			[Cpp2IlInjected.Token(Token = "0x60088CC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return incompatibleClothes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BB")]
		[DebuggerNonUserCode]
		public int SkinColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60088CD")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40", Slot = "5")]
			get
			{
				return skinColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x60088CE")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				skinColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BC")]
		[DebuggerNonUserCode]
		public int EyeColor
		{
			[Cpp2IlInjected.Token(Token = "0x60088CF")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500", Slot = "6")]
			get
			{
				return eyeColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x60088D0")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				eyeColor_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BD")]
		[DebuggerNonUserCode]
		public int HairColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60088D1")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return hairColorIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x60088D2")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				hairColorIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BE")]
		[DebuggerNonUserCode]
		public int HairHighlightColor
		{
			[Cpp2IlInjected.Token(Token = "0x60088D3")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return hairHighlightColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x60088D4")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				hairHighlightColor_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017BF")]
		[DebuggerNonUserCode]
		public int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x60088D5")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0", Slot = "7")]
			get
			{
				return bodyType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60088D6")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				bodyType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017C0")]
		[DebuggerNonUserCode]
		public MapField<uint, int> FaceType
		{
			[Cpp2IlInjected.Token(Token = "0x60088D7")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return faceType_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017C1")]
		[DebuggerNonUserCode]
		public MapField<uint, Makeup> Makeup
		{
			[Cpp2IlInjected.Token(Token = "0x60088D8")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return makeup_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017C2")]
		[DebuggerNonUserCode]
		public MapField<int, int> ClothingCustomization
		{
			[Cpp2IlInjected.Token(Token = "0x60088D9")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return clothingCustomization_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088BF")]
		[Cpp2IlInjected.Address(RVA = "0x18F0F60", Offset = "0x18EF960", VA = "0x1818F0F60", Slot = "10")]
		public bool IsWearing(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_000f
			//IL_000e: Expected O, but got I4
			return ((MapField<TKey, TValue>)(object)clothes_).ContainsKey((TKey)clothingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60088C0")]
		[Cpp2IlInjected.Address(RVA = "0x18F0E60", Offset = "0x18EF860", VA = "0x1818F0E60", Slot = "11")]
		public bool IsWearing(ClothingItemType clothingType, out Item item)
		{
			//Discarded unreachable code: IL_0024
			//IL_001b: Expected I4, but got O
			MapField<uint, int> mapField = clothes_;
			bool flag = default(bool);
			if (!flag)
			{
				Item invalid = Item.Invalid;
				int num = 0;
				item.ItemID = (int)invalid;
			}
			item.ItemID = (flag ? 1 : 0);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60088C1")]
		[Cpp2IlInjected.Address(RVA = "0x18F0FC0", Offset = "0x18EF9C0", VA = "0x1818F0FC0", Slot = "12")]
		public unsafe bool IsWearing(Item item)
		{
			//IL_0019: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				MapField<uint, int> mapField = clothes_;
				ClothingItemType clothingItemType = default(ClothingItemType);
				int num2 = (int)clothingItemType;
				bool result = default(bool);
				if (((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)num2, out *(TValue*)num))
				{
					return result;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088C2")]
		[Cpp2IlInjected.Address(RVA = "0x18F0370", Offset = "0x18EED70", VA = "0x1818F0370", Slot = "13")]
		void IDataValidation.DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004d, IL_0053, IL_0059
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			MapField<uint, int> mapField = clothes_;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				string message = $"Invalid clothing in avatar. {flag} is not of type {flag}";
				context.AddInvalidMemberError(message, "Clothes");
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
				string text = $"Invalid makeup in avatar. {flag3} is not of type {flag3}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088C6")]
		[Cpp2IlInjected.Address(RVA = "0x18F2100", Offset = "0x18F0B00", VA = "0x1818F2100")]
		[DebuggerNonUserCode]
		public Avatar()
		{
			clothes_ = (MapField<uint, int>)(object)new MapField<TKey, TValue>();
			incompatibleClothes_ = (MapField<uint, int>)(object)new MapField<TKey, TValue>();
			faceType_ = (MapField<uint, int>)(object)new MapField<TKey, TValue>();
			makeup_ = (MapField<uint, Makeup>)(object)new MapField<TKey, TValue>();
			clothingCustomization_ = (MapField<int, int>)(object)new MapField<TKey, TValue>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60088C7")]
		[Cpp2IlInjected.Address(RVA = "0x18F1F90", Offset = "0x18F0990", VA = "0x1818F1F90")]
		[DebuggerNonUserCode]
		public Avatar(Avatar other)
		{
			uint num = (id_ = other.id_);
			MapField<uint, int> mapField = (clothes_ = (MapField<uint, int>)(object)((MapField<TKey, TValue>)(object)other.clothes_).Clone());
			MapField<uint, int> mapField2 = (incompatibleClothes_ = (MapField<uint, int>)(object)((MapField<TKey, TValue>)(object)other.incompatibleClothes_).Clone());
			int num2 = (skinColorIndex_ = other.skinColorIndex_);
			int num3 = (eyeColor_ = other.eyeColor_);
			int num4 = (hairColorIndex_ = other.hairColorIndex_);
			int num5 = (hairHighlightColor_ = other.hairHighlightColor_);
			int num6 = (bodyType_ = other.bodyType_);
			MapField<uint, int> mapField3 = (faceType_ = (MapField<uint, int>)(object)((MapField<TKey, TValue>)(object)other.faceType_).Clone());
			MapField<uint, Makeup> mapField4 = (makeup_ = (MapField<uint, Makeup>)(object)((MapField<TKey, TValue>)(object)other.makeup_).Clone());
			MapField<int, int> mapField5 = (clothingCustomization_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)other.clothingCustomization_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088C8")]
		[Cpp2IlInjected.Address(RVA = "0x18F01D0", Offset = "0x18EEBD0", VA = "0x1818F01D0", Slot = "20")]
		[DebuggerNonUserCode]
		public Avatar Clone()
		{
			//Discarded unreachable code: IL_00e0
			Avatar avatar = new Avatar();
			uint num = (avatar.id_ = id_);
			MapField<uint, int> mapField = (avatar.clothes_ = (MapField<uint, int>)(object)((MapField<TKey, TValue>)(object)clothes_).Clone());
			MapField<uint, int> mapField2 = (avatar.incompatibleClothes_ = (MapField<uint, int>)(object)((MapField<TKey, TValue>)(object)incompatibleClothes_).Clone());
			int num2 = (avatar.skinColorIndex_ = skinColorIndex_);
			int num3 = (avatar.eyeColor_ = eyeColor_);
			int num4 = (avatar.hairColorIndex_ = hairColorIndex_);
			int num5 = (avatar.hairHighlightColor_ = hairHighlightColor_);
			int num6 = (avatar.bodyType_ = bodyType_);
			MapField<uint, int> mapField3 = (avatar.faceType_ = (MapField<uint, int>)(object)((MapField<TKey, TValue>)(object)faceType_).Clone());
			MapField<uint, Makeup> mapField4 = (avatar.makeup_ = (MapField<uint, Makeup>)(object)((MapField<TKey, TValue>)(object)makeup_).Clone());
			MapField<int, int> mapField5 = (avatar.clothingCustomization_ = (MapField<int, int>)(object)((MapField<TKey, TValue>)(object)clothingCustomization_).Clone());
			UnknownFieldSet unknownFieldSet = (avatar._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return avatar;
		}

		[Cpp2IlInjected.Token(Token = "0x60088DA")]
		[Cpp2IlInjected.Address(RVA = "0x18F0970", Offset = "0x18EF370", VA = "0x1818F0970", Slot = "0")]
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
				if ((object)_map_faceType_codec == (object)typeof(Avatar).TypeHandle)
				{
					MapField<uint, int> mapField = clothes_;
					bool flag = default(bool);
					if (flag)
					{
						MapField<uint, int> mapField2 = incompatibleClothes_;
						bool flag2 = default(bool);
						if (flag2 && skinColorIndex_ == (flag2 ? 1 : 0) && eyeColor_ == (flag2 ? 1 : 0) && hairColorIndex_ == (flag2 ? 1 : 0) && hairHighlightColor_ == (flag2 ? 1 : 0) && bodyType_ == (flag2 ? 1 : 0))
						{
							MapField<uint, int> mapField3 = faceType_;
							bool flag3 = default(bool);
							if (flag3)
							{
								MapField<uint, Makeup> mapField4 = makeup_;
								bool flag4 = default(bool);
								if (flag4)
								{
									MapField<int, int> mapField5 = clothingCustomization_;
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
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088DB")]
		[Cpp2IlInjected.Address(RVA = "0x18F07F0", Offset = "0x18EF1F0", VA = "0x1818F07F0", Slot = "19")]
		[DebuggerNonUserCode]
		public bool Equals(Avatar other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.id_;
				if ((IntPtr)_map_faceType_codec == (IntPtr)(int)num)
				{
					MapField<uint, int> mapField = clothes_;
					MapField<uint, int> mapField2 = other.clothes_;
					if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
					{
						MapField<uint, int> mapField3 = incompatibleClothes_;
						MapField<uint, int> mapField4 = other.incompatibleClothes_;
						if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
						{
							int num2 = other.skinColorIndex_;
							if (skinColorIndex_ == num2)
							{
								int num3 = other.eyeColor_;
								if (eyeColor_ == num3)
								{
									int num4 = other.hairColorIndex_;
									if (hairColorIndex_ == num4)
									{
										int num5 = other.hairHighlightColor_;
										if (hairHighlightColor_ == num5)
										{
											int num6 = other.bodyType_;
											if (bodyType_ == num6)
											{
												MapField<uint, int> mapField5 = faceType_;
												MapField<uint, int> mapField6 = other.faceType_;
												if (((MapField<TKey, TValue>)(object)mapField5).Equals((MapField<, >)(object)mapField6))
												{
													MapField<uint, Makeup> mapField7 = makeup_;
													MapField<uint, Makeup> mapField8 = other.makeup_;
													if (((MapField<TKey, TValue>)(object)mapField7).Equals((MapField<, >)(object)mapField8))
													{
														MapField<int, int> mapField9 = clothingCustomization_;
														MapField<int, int> mapField10 = other.clothingCustomization_;
														if (((MapField<TKey, TValue>)(object)mapField9).Equals((MapField<, >)(object)mapField10))
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
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60088DC")]
		[Cpp2IlInjected.Address(RVA = "0x18F0CD0", Offset = "0x18EF6D0", VA = "0x1818F0CD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_009c
			int num = 0;
			if (id_ != 0)
			{
			}
			int hashCode = ((MapField<TKey, TValue>)(object)clothes_).GetHashCode();
			int hashCode2 = ((MapField<TKey, TValue>)(object)incompatibleClothes_).GetHashCode();
			if (skinColorIndex_ != 0)
			{
			}
			if (eyeColor_ != 0)
			{
			}
			if (hairColorIndex_ != 0)
			{
			}
			if (hairHighlightColor_ != 0)
			{
			}
			if (bodyType_ != 0)
			{
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)faceType_).GetHashCode();
			MapField<uint, Makeup> mapField = makeup_;
			hashCode = hashCode3;
			int hashCode4 = ((MapField<TKey, TValue>)(object)mapField).GetHashCode();
			int hashCode5 = ((MapField<TKey, TValue>)(object)clothingCustomization_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			hashCode2 = hashCode5;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x60088DD")]
		[Cpp2IlInjected.Address(RVA = "0x18F1880", Offset = "0x18F0280", VA = "0x1818F1880", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60088DE")]
		[Cpp2IlInjected.Address(RVA = "0x18F18E0", Offset = "0x18F02E0", VA = "0x1818F18E0", Slot = "16")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0123
			if ((long)_map_faceType_codec != 0)
			{
				uint value = id_;
				output.WriteUInt32(value);
			}
			MapField<uint, int> mapField = clothes_;
			MapField<uint, int>.Codec map_clothes_codec = _map_clothes_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_clothes_codec);
			MapField<uint, int> mapField2 = incompatibleClothes_;
			MapField<uint, int>.Codec map_incompatibleClothes_codec = _map_incompatibleClothes_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_incompatibleClothes_codec);
			if (skinColorIndex_ != 0)
			{
				int value2 = skinColorIndex_;
				output.WriteInt32(value2);
			}
			if (eyeColor_ != 0)
			{
				int value3 = eyeColor_;
				output.WriteInt32(value3);
			}
			if (hairColorIndex_ != 0)
			{
				int value4 = hairColorIndex_;
				output.WriteInt32(value4);
			}
			if (hairHighlightColor_ != 0)
			{
				int value5 = hairHighlightColor_;
				output.WriteInt32(value5);
			}
			if (bodyType_ != 0)
			{
				int value6 = bodyType_;
				output.WriteInt32(value6);
			}
			MapField<uint, int> mapField3 = faceType_;
			MapField<uint, int>.Codec map_faceType_codec = _map_faceType_codec;
			((MapField<TKey, TValue>)(object)mapField3).WriteTo(output, (MapField<, >.Codec)(object)map_faceType_codec);
			MapField<uint, Makeup> mapField4 = makeup_;
			MapField<uint, Makeup>.Codec map_makeup_codec = _map_makeup_codec;
			((MapField<TKey, TValue>)(object)mapField4).WriteTo(output, (MapField<, >.Codec)(object)map_makeup_codec);
			MapField<int, int> mapField5 = clothingCustomization_;
			MapField<int, int>.Codec map_clothingCustomization_codec = _map_clothingCustomization_codec;
			((MapField<TKey, TValue>)(object)mapField5).WriteTo(output, (MapField<, >.Codec)(object)map_clothingCustomization_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60088DF")]
		[Cpp2IlInjected.Address(RVA = "0x18EFDB0", Offset = "0x18EE7B0", VA = "0x1818EFDB0", Slot = "17")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0157
			uint num = id_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeUInt32Size(num);
			}
			MapField<uint, int> mapField = clothes_;
			MapField<uint, int>.Codec map_clothes_codec = _map_clothes_codec;
			int num4 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_clothes_codec);
			MapField<uint, int> mapField2 = incompatibleClothes_;
			MapField<uint, int>.Codec map_incompatibleClothes_codec = _map_incompatibleClothes_codec;
			int num5 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_incompatibleClothes_codec);
			int num6 = skinColorIndex_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			int num8 = eyeColor_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			int num10 = hairColorIndex_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			int num12 = hairHighlightColor_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			int num14 = bodyType_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			MapField<uint, int> mapField3 = faceType_;
			MapField<uint, int>.Codec map_faceType_codec = _map_faceType_codec;
			int num16 = ((MapField<TKey, TValue>)(object)mapField3).CalculateSize((MapField<, >.Codec)(object)map_faceType_codec);
			MapField<uint, Makeup> mapField4 = makeup_;
			MapField<uint, Makeup>.Codec map_makeup_codec = _map_makeup_codec;
			int num17 = ((MapField<TKey, TValue>)(object)mapField4).CalculateSize((MapField<, >.Codec)(object)map_makeup_codec);
			MapField<int, int> mapField5 = clothingCustomization_;
			MapField<int, int>.Codec map_clothingCustomization_codec = _map_clothingCustomization_codec;
			int num18 = ((MapField<TKey, TValue>)(object)mapField5).CalculateSize((MapField<, >.Codec)(object)map_clothingCustomization_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num19 = unknownFields.CalculateSize();
				num2 += num19;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60088E0")]
		[Cpp2IlInjected.Address(RVA = "0x18F1070", Offset = "0x18EFA70", VA = "0x1818F1070", Slot = "14")]
		[DebuggerNonUserCode]
		public void MergeFrom(Avatar other)
		{
			//Discarded unreachable code: IL_011a
			if (other != null)
			{
				uint num = other.id_;
				if (num != 0)
				{
					id_ = num;
				}
				MapField<uint, int> mapField = clothes_;
				MapField<uint, int> mapField2 = other.clothes_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				MapField<uint, int> mapField3 = incompatibleClothes_;
				MapField<uint, int> mapField4 = other.incompatibleClothes_;
				((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
				int num2 = other.skinColorIndex_;
				if (num2 != 0)
				{
					skinColorIndex_ = num2;
				}
				int num3 = other.eyeColor_;
				if (num3 != 0)
				{
					eyeColor_ = num3;
				}
				int num4 = other.hairColorIndex_;
				if (num4 != 0)
				{
					hairColorIndex_ = num4;
				}
				int num5 = other.hairHighlightColor_;
				if (num5 != 0)
				{
					hairHighlightColor_ = num5;
				}
				int num6 = other.bodyType_;
				if (num6 != 0)
				{
					bodyType_ = num6;
				}
				MapField<uint, int> mapField5 = faceType_;
				MapField<uint, int> mapField6 = other.faceType_;
				((MapField<TKey, TValue>)(object)mapField5).Add((IDictionary<, >)(object)mapField6);
				MapField<uint, Makeup> mapField7 = makeup_;
				MapField<uint, Makeup> mapField8 = other.makeup_;
				((MapField<TKey, TValue>)(object)mapField7).Add((IDictionary<, >)(object)mapField8);
				MapField<int, int> mapField9 = clothingCustomization_;
				MapField<int, int> mapField10 = other.clothingCustomization_;
				((MapField<TKey, TValue>)(object)mapField9).Add((IDictionary<, >)(object)mapField10);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088E1")]
		[Cpp2IlInjected.Address(RVA = "0x18F11B0", Offset = "0x18EFBB0", VA = "0x1818F11B0", Slot = "15")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0159
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 40)
			{
				if ((int)num > 64)
				{
					if (num == 74)
					{
						MapField<uint, int> mapField = faceType_;
						MapField<uint, int>.Codec map_faceType_codec = _map_faceType_codec;
						((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_faceType_codec);
					}
					if (num == 82)
					{
						MapField<uint, Makeup> mapField2 = makeup_;
						MapField<uint, Makeup>.Codec map_makeup_codec = _map_makeup_codec;
						((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_makeup_codec);
					}
					if (num != 90)
					{
						goto IL_0142;
					}
					MapField<int, int> mapField3 = clothingCustomization_;
					MapField<int, int>.Codec map_clothingCustomization_codec = _map_clothingCustomization_codec;
					((MapField<TKey, TValue>)(object)mapField3).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_clothingCustomization_codec);
				}
				int num2 = default(int);
				if (num == 48)
				{
					num2 = (hairColorIndex_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num2 == 56)
				{
					num3 = (hairHighlightColor_ = input.ReadInt32());
				}
				if (num3 != 64)
				{
					goto IL_0142;
				}
				int num4 = (bodyType_ = input.ReadInt32());
			}
			int num6 = default(int);
			if ((int)num > 18)
			{
				if (num == 26)
				{
					MapField<uint, int> mapField4 = incompatibleClothes_;
					MapField<uint, int>.Codec map_incompatibleClothes_codec = _map_incompatibleClothes_codec;
					((MapField<TKey, TValue>)(object)mapField4).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_incompatibleClothes_codec);
				}
				int num5 = default(int);
				if (num == 32)
				{
					num5 = (skinColorIndex_ = input.ReadInt32());
				}
				if (num5 != 40)
				{
					goto IL_0142;
				}
				num6 = (eyeColor_ = input.ReadInt32());
			}
			int num7 = default(int);
			if (num6 == 8)
			{
				num7 = (int)(id_ = (uint)input.ReadInt32());
			}
			if (num7 == 18)
			{
				MapField<uint, int> mapField5 = clothes_;
				MapField<uint, int>.Codec map_clothes_codec = _map_clothes_codec;
				((MapField<TKey, TValue>)(object)mapField5).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_clothes_codec);
			}
			goto IL_0142;
			IL_0142:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60088E2")]
		[Cpp2IlInjected.Address(RVA = "0x18F0B40", Offset = "0x18EF540", VA = "0x1818F0B40", Slot = "21")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				uint num = id_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60088E3")]
		[Cpp2IlInjected.Address(RVA = "0x18F14E0", Offset = "0x18EFEE0", VA = "0x1818F14E0", Slot = "22")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 10)
			{
				object obj = default(object);
				id_ = (uint)(int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088E4")]
		[Cpp2IlInjected.Address(RVA = "0x18F00A0", Offset = "0x18EEAA0", VA = "0x1818F00A0", Slot = "23")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 10)
			{
				id_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60088E5")]
		[Cpp2IlInjected.Address(RVA = "0x18F1B90", Offset = "0x18F0590", VA = "0x1818F1B90")]
		static Avatar()
		{
			Func<Avatar> func = default(Func<Avatar>);
			_parser = (MessageParser<Avatar>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<uint> fieldCodec = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			FieldCodec<int> fieldCodec2 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num = default(uint);
			_parser = (MessageParser<Avatar>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			FieldCodec<uint> fieldCodec3 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			FieldCodec<int> fieldCodec4 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num2 = default(uint);
			_parser = (MessageParser<Avatar>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, (FieldCodec<>)(object)fieldCodec4, num2);
			FieldCodec<uint> fieldCodec5 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			FieldCodec<int> fieldCodec6 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num3 = default(uint);
			_parser = (MessageParser<Avatar>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec5, (FieldCodec<>)(object)fieldCodec6, num3);
			FieldCodec<uint> fieldCodec7 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<Makeup> parser = Meta.Customization.Makeup._parser;
			uint num4 = default(uint);
			FieldCodec<> fieldCodec8 = FieldCodec.ForMessage<Makeup>(num4, (MessageParser<>)(object)parser);
			uint num5 = default(uint);
			_parser = (MessageParser<Avatar>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec7, fieldCodec8, num5);
			FieldCodec<int> fieldCodec9 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<int> fieldCodec10 = (FieldCodec<int>)(object)FieldCodec.ForInt32(16u);
			uint num6 = default(uint);
			_parser = (MessageParser<Avatar>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec9, (FieldCodec<>)(object)fieldCodec10, num6);
			/*Error: Unexpected end of block*/;
		}
	}
}
