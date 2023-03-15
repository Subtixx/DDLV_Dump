using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Customization;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200092B")]
	public sealed class AvatarTransferData : IMessage<AvatarTransferData>, IMessage, IEquatable<AvatarTransferData>, IDeepCloneable<AvatarTransferData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002552")]
		private static readonly MessageParser<AvatarTransferData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002553")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002554")]
		public const int FemaleAvatarFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002555")]
		private Avatar femaleAvatar_;

		[Cpp2IlInjected.Token(Token = "0x4002556")]
		public const int MaleAvatarFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002557")]
		private Avatar maleAvatar_;

		[Cpp2IlInjected.Token(Token = "0x4002558")]
		public const int AvatarIsMaleFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002559")]
		private bool avatarIsMale_;

		[Cpp2IlInjected.Token(Token = "0x400255A")]
		public const int FemaleClothingDesignsFieldNumber = 34;

		[Cpp2IlInjected.Token(Token = "0x400255B")]
		private static readonly MapField<int, DesignMap>.Codec _map_femaleClothingDesigns_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400255C")]
		private readonly MapField<int, DesignMap> femaleClothingDesigns_ = (MapField<int, DesignMap>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x400255D")]
		public const int MaleClothingDesignsFieldNumber = 35;

		[Cpp2IlInjected.Token(Token = "0x400255E")]
		private static readonly MapField<int, DesignMap>.Codec _map_maleClothingDesigns_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400255F")]
		private readonly MapField<int, DesignMap> maleClothingDesigns_ = (MapField<int, DesignMap>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4002560")]
		public const int NextClothingDesignIDFieldNumber = 36;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002561")]
		private int nextClothingDesignID_;

		[Cpp2IlInjected.Token(Token = "0x17000DB5")]
		[DebuggerNonUserCode]
		public static MessageParser<AvatarTransferData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004FFD")]
			[Cpp2IlInjected.Address(RVA = "0x1AB3DB0", Offset = "0x1AB27B0", VA = "0x181AB3DB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FFE")]
			[Cpp2IlInjected.Address(RVA = "0x1AB3CE0", Offset = "0x1AB26E0", VA = "0x181AB3CE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FFF")]
			[Cpp2IlInjected.Address(RVA = "0x1AB3E10", Offset = "0x1AB2810", VA = "0x181AB3E10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB8")]
		[DebuggerNonUserCode]
		public Avatar FemaleAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6005003")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return femaleAvatar_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005004")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				femaleAvatar_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB9")]
		[DebuggerNonUserCode]
		public Avatar MaleAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6005005")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return maleAvatar_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005006")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				maleAvatar_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBA")]
		[DebuggerNonUserCode]
		public bool AvatarIsMale
		{
			[Cpp2IlInjected.Token(Token = "0x6005007")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return avatarIsMale_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005008")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				avatarIsMale_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBB")]
		[DebuggerNonUserCode]
		public MapField<int, DesignMap> FemaleClothingDesigns
		{
			[Cpp2IlInjected.Token(Token = "0x6005009")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return femaleClothingDesigns_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBC")]
		[DebuggerNonUserCode]
		public MapField<int, DesignMap> MaleClothingDesigns
		{
			[Cpp2IlInjected.Token(Token = "0x600500A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return maleClothingDesigns_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBD")]
		[DebuggerNonUserCode]
		public int NextClothingDesignID
		{
			[Cpp2IlInjected.Token(Token = "0x600500B")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return nextClothingDesignID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600500C")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				nextClothingDesignID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005000")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3C30", Offset = "0x1AB2630", VA = "0x181AB3C30")]
		[DebuggerNonUserCode]
		public AvatarTransferData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005001")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3A80", Offset = "0x1AB2480", VA = "0x181AB3A80")]
		[DebuggerNonUserCode]
		public AvatarTransferData(AvatarTransferData other)
		{
			//IL_003c: Expected O, but got I4
			Avatar avatar = other.femaleAvatar_;
			int num = 0;
			if (avatar != null)
			{
				Avatar avatar2 = avatar.Clone();
			}
			femaleAvatar_ = (Avatar)num;
			Avatar avatar3 = other.maleAvatar_;
			Avatar avatar4 = default(Avatar);
			if (avatar3 != null)
			{
				avatar4 = avatar3.Clone();
			}
			maleAvatar_ = avatar4;
			bool flag = (avatarIsMale_ = other.avatarIsMale_);
			MapField<int, DesignMap> mapField = (femaleClothingDesigns_ = (MapField<int, DesignMap>)(object)((MapField<TKey, TValue>)(object)other.femaleClothingDesigns_).Clone());
			MapField<int, DesignMap> mapField2 = (maleClothingDesigns_ = (MapField<int, DesignMap>)(object)((MapField<TKey, TValue>)(object)other.maleClothingDesigns_).Clone());
			int num2 = (nextClothingDesignID_ = other.nextClothingDesignID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005002")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2AC0", Offset = "0x1AB14C0", VA = "0x181AB2AC0", Slot = "10")]
		[DebuggerNonUserCode]
		public AvatarTransferData Clone()
		{
			return new AvatarTransferData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600500D")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2B20", Offset = "0x1AB1520", VA = "0x181AB2B20", Slot = "0")]
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
				if (object.Equals(femaleAvatar_, other))
				{
					bool flag = object.Equals(maleAvatar_, other);
					if (flag && avatarIsMale_ == flag)
					{
						MapField<int, DesignMap> mapField = femaleClothingDesigns_;
						bool flag2 = default(bool);
						if (flag2)
						{
							MapField<int, DesignMap> mapField2 = maleClothingDesigns_;
							bool flag3 = default(bool);
							if (flag3 && nextClothingDesignID_ == (flag3 ? 1 : 0))
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

		[Cpp2IlInjected.Token(Token = "0x600500E")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2C60", Offset = "0x1AB1660", VA = "0x181AB2C60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AvatarTransferData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Avatar objB = other.femaleAvatar_;
				if (object.Equals(femaleAvatar_, objB))
				{
					Avatar objB2 = other.maleAvatar_;
					if (object.Equals(maleAvatar_, objB2))
					{
						bool flag = other.avatarIsMale_;
						if (avatarIsMale_ == flag)
						{
							MapField<int, DesignMap> mapField = femaleClothingDesigns_;
							MapField<int, DesignMap> mapField2 = other.femaleClothingDesigns_;
							if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
							{
								MapField<int, DesignMap> mapField3 = maleClothingDesigns_;
								MapField<int, DesignMap> mapField4 = other.maleClothingDesigns_;
								if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
								{
									int num = other.nextClothingDesignID_;
									if (nextClothingDesignID_ == num)
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600500F")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2EA0", Offset = "0x1AB18A0", VA = "0x181AB2EA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0071
			Avatar avatar = femaleAvatar_;
			if (avatar != null)
			{
				int hashCode = avatar.GetHashCode();
			}
			Avatar avatar2 = maleAvatar_;
			if (avatar2 != null)
			{
				int hashCode2 = avatar2.GetHashCode();
			}
			if (avatarIsMale_)
			{
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)femaleClothingDesigns_).GetHashCode();
			int hashCode4 = ((MapField<TKey, TValue>)(object)maleClothingDesigns_).GetHashCode();
			if (nextClothingDesignID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode4;
		}

		[Cpp2IlInjected.Token(Token = "0x6005010")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3590", Offset = "0x1AB1F90", VA = "0x181AB3590", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005011")]
		[Cpp2IlInjected.Address(RVA = "0x1AB35F0", Offset = "0x1AB1FF0", VA = "0x181AB35F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00a8
			if ((long)femaleAvatar_ != 0)
			{
				Avatar value = femaleAvatar_;
				output.WriteMessage(value);
			}
			if ((long)maleAvatar_ != 0)
			{
				Avatar value2 = maleAvatar_;
				output.WriteMessage(value2);
			}
			if (avatarIsMale_)
			{
				bool value3 = avatarIsMale_;
				output.WriteBool(value3);
			}
			MapField<int, DesignMap> mapField = femaleClothingDesigns_;
			MapField<int, DesignMap>.Codec map_femaleClothingDesigns_codec = _map_femaleClothingDesigns_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_femaleClothingDesigns_codec);
			MapField<int, DesignMap> mapField2 = maleClothingDesigns_;
			MapField<int, DesignMap>.Codec map_maleClothingDesigns_codec = _map_maleClothingDesigns_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_maleClothingDesigns_codec);
			if (nextClothingDesignID_ != 0)
			{
				int value4 = nextClothingDesignID_;
				output.WriteInt32(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005012")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2850", Offset = "0x1AB1250", VA = "0x181AB2850", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			Avatar avatar = femaleAvatar_;
			int num = 0;
			if (avatar != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(avatar);
			}
			Avatar avatar2 = maleAvatar_;
			if (avatar2 != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(avatar2);
				num3++;
				num += num3;
			}
			MapField<int, DesignMap> mapField = femaleClothingDesigns_;
			MapField<int, DesignMap>.Codec map_femaleClothingDesigns_codec = _map_femaleClothingDesigns_codec;
			int num4 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_femaleClothingDesigns_codec);
			MapField<int, DesignMap> mapField2 = maleClothingDesigns_;
			MapField<int, DesignMap>.Codec map_maleClothingDesigns_codec = _map_maleClothingDesigns_codec;
			int num5 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_maleClothingDesigns_codec);
			int num6 = nextClothingDesignID_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7 += 2;
				mapField = (MapField<int, DesignMap>)(mapField + num7);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				mapField = (MapField<int, DesignMap>)(mapField + num8);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005013")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2FA0", Offset = "0x1AB19A0", VA = "0x181AB2FA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AvatarTransferData other)
		{
			//Discarded unreachable code: IL_00f7
			if (other == null)
			{
				return;
			}
			if ((long)other.femaleAvatar_ != 0)
			{
				Avatar avatar = femaleAvatar_;
				if (avatar == null)
				{
					Avatar avatar2 = (femaleAvatar_ = new Avatar());
					Avatar avatar3 = femaleAvatar_;
				}
				Avatar other2 = other.femaleAvatar_;
				avatar.MergeFrom(other2);
			}
			if ((long)other.maleAvatar_ != 0)
			{
				Avatar avatar5 = default(Avatar);
				if (maleAvatar_ == null)
				{
					Avatar avatar4 = (maleAvatar_ = new Avatar());
					avatar5 = maleAvatar_;
				}
				Avatar other3 = other.maleAvatar_;
				avatar5.MergeFrom(other3);
			}
			bool flag = other.avatarIsMale_;
			if (flag)
			{
				avatarIsMale_ = flag;
			}
			MapField<int, DesignMap> mapField = femaleClothingDesigns_;
			MapField<int, DesignMap> mapField2 = other.femaleClothingDesigns_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			MapField<int, DesignMap> mapField3 = maleClothingDesigns_;
			MapField<int, DesignMap> mapField4 = other.maleClothingDesigns_;
			((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
			int num = other.nextClothingDesignID_;
			if (num != 0)
			{
				nextClothingDesignID_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6005014")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3120", Offset = "0x1AB1B20", VA = "0x181AB3120", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00fc
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 112)
			{
				if (num == 274)
				{
					MapField<int, DesignMap> mapField = femaleClothingDesigns_;
					MapField<int, DesignMap>.Codec map_femaleClothingDesigns_codec = _map_femaleClothingDesigns_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_femaleClothingDesigns_codec);
				}
				if (num == 282)
				{
					MapField<int, DesignMap> mapField2 = maleClothingDesigns_;
					MapField<int, DesignMap>.Codec map_maleClothingDesigns_codec = _map_maleClothingDesigns_codec;
					((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_maleClothingDesigns_codec);
				}
				if (num != 288)
				{
					goto IL_00e5;
				}
				int num2 = (nextClothingDesignID_ = input.ReadInt32());
			}
			Avatar avatar = default(Avatar);
			if (num == 98)
			{
				Avatar builder = default(Avatar);
				if (femaleAvatar_ == null)
				{
					avatar = (femaleAvatar_ = new Avatar());
					builder = femaleAvatar_;
				}
				input.ReadMessage(builder);
			}
			Avatar avatar2 = default(Avatar);
			if ((long)avatar == 106)
			{
				Avatar builder2 = default(Avatar);
				if (maleAvatar_ == null)
				{
					avatar2 = (maleAvatar_ = new Avatar());
					builder2 = maleAvatar_;
				}
				input.ReadMessage(builder2);
			}
			if ((long)avatar2 == 112)
			{
				bool flag = (avatarIsMale_ = input.ReadBool());
			}
			goto IL_00e5;
			IL_00e5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005015")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2D50", Offset = "0x1AB1750", VA = "0x181AB2D50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (this != null && this != null && (long)this == 1)
			{
				int num = nextClothingDesignID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005016")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3370", Offset = "0x1AB1D70", VA = "0x181AB3370", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_002d: Expected I4, but got O
			//IL_0035: Expected I4, but got O
			object obj = default(object);
			object obj2 = default(object);
			while (fieldNumber != 0)
			{
				switch (fieldNumber)
				{
				case 1:
					avatarIsMale_ = (byte)(int)obj != 0;
					return;
				case 0:
					if (value == null || value != null)
					{
						maleAvatar_ = (Avatar)value;
						return;
					}
					continue;
				}
				if ((object)typeof(int).TypeHandle == null)
				{
					continue;
				}
				if ((object)typeof(int).TypeHandle != null)
				{
					if ((long)typeof(int).TypeHandle == 1)
					{
						nextClothingDesignID_ = (int)obj2;
					}
					return;
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			if (value == null || value != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005017")]
		[Cpp2IlInjected.Address(RVA = "0x1AB29F0", Offset = "0x1AB13F0", VA = "0x181AB29F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0034
			//IL_0023: Expected I4, but got I8
			if ((object)typeof(IDictionary).TypeHandle != null && (object)typeof(IDictionary).TypeHandle != null)
			{
				if ((long)typeof(IDictionary).TypeHandle == 1)
				{
					nextClothingDesignID_ = 0;
				}
			}
			else
			{
				MapField<int, DesignMap> mapField = femaleClothingDesigns_;
				avatarIsMale_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005018")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3790", Offset = "0x1AB2190", VA = "0x181AB3790")]
		static AvatarTransferData()
		{
			Func<AvatarTransferData> func = default(Func<AvatarTransferData>);
			_parser = (MessageParser<AvatarTransferData>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<DesignMap> parser = DesignMap._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<DesignMap>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<AvatarTransferData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			FieldCodec<int> fieldCodec3 = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<DesignMap> parser2 = DesignMap._parser;
			uint num3 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<DesignMap>(num3, (MessageParser<>)(object)parser2);
			uint num4 = default(uint);
			_parser = (MessageParser<AvatarTransferData>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num4);
			/*Error: Unexpected end of block*/;
		}
	}
}
