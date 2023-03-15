using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Customization;

namespace Meta.Social.Ralph
{
	[Cpp2IlInjected.Token(Token = "0x2000DD4")]
	public sealed class PictureRecipe : IMessage<PictureRecipe>, IMessage, IEquatable<PictureRecipe>, IDeepCloneable<PictureRecipe>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40037CE")]
		private static readonly MessageParser<PictureRecipe> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40037CF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40037D0")]
		public const int SceneItemIDFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037D1")]
		private int sceneItemID_;

		[Cpp2IlInjected.Token(Token = "0x40037D2")]
		public const int GridsFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037D3")]
		private GridCollection grids_;

		[Cpp2IlInjected.Token(Token = "0x40037D4")]
		public const int AvatarFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40037D5")]
		private Avatar avatar_;

		[Cpp2IlInjected.Token(Token = "0x40037D6")]
		public const int AvatarIsMaleFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40037D7")]
		private bool avatarIsMale_;

		[Cpp2IlInjected.Token(Token = "0x40037D8")]
		public const int ScreenshotFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40037D9")]
		private ByteString screenshot_;

		[Cpp2IlInjected.Token(Token = "0x40037DA")]
		public const int ThumbnailFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40037DB")]
		private ByteString thumbnail_;

		[Cpp2IlInjected.Token(Token = "0x40037DC")]
		public const int ItemsFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x40037DD")]
		private static readonly FieldCodec<int> _repeated_items_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40037DE")]
		private readonly RepeatedField<int> items_;

		[Cpp2IlInjected.Token(Token = "0x170013CD")]
		[DebuggerNonUserCode]
		public static MessageParser<PictureRecipe> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60072FA")]
			[Cpp2IlInjected.Address(RVA = "0x7B6450", Offset = "0x7B4E50", VA = "0x1807B6450")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013CE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60072FB")]
			[Cpp2IlInjected.Address(RVA = "0x7B6380", Offset = "0x7B4D80", VA = "0x1807B6380")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013CF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60072FC")]
			[Cpp2IlInjected.Address(RVA = "0x7B64B0", Offset = "0x7B4EB0", VA = "0x1807B64B0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D0")]
		[DebuggerNonUserCode]
		public int SceneItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6007300")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return sceneItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007301")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				sceneItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D1")]
		[DebuggerNonUserCode]
		public GridCollection Grids
		{
			[Cpp2IlInjected.Token(Token = "0x6007302")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return grids_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007303")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				grids_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D2")]
		[DebuggerNonUserCode]
		public Avatar Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x6007304")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return avatar_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007305")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				avatar_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D3")]
		[DebuggerNonUserCode]
		public bool AvatarIsMale
		{
			[Cpp2IlInjected.Token(Token = "0x6007306")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return avatarIsMale_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007307")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				avatarIsMale_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D4")]
		[DebuggerNonUserCode]
		public ByteString Screenshot
		{
			[Cpp2IlInjected.Token(Token = "0x6007308")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return screenshot_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007309")]
			[Cpp2IlInjected.Address(RVA = "0x7B65C0", Offset = "0x7B4FC0", VA = "0x1807B65C0")]
			set
			{
				ByteString byteString = (screenshot_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D5")]
		[DebuggerNonUserCode]
		public ByteString Thumbnail
		{
			[Cpp2IlInjected.Token(Token = "0x600730A")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return thumbnail_;
			}
			[Cpp2IlInjected.Token(Token = "0x600730B")]
			[Cpp2IlInjected.Address(RVA = "0x7B6630", Offset = "0x7B5030", VA = "0x1807B6630")]
			set
			{
				ByteString byteString = (thumbnail_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D6")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Items
		{
			[Cpp2IlInjected.Token(Token = "0x600730C")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return items_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60072FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B62B0", Offset = "0x7B4CB0", VA = "0x1807B62B0")]
		[DebuggerNonUserCode]
		public PictureRecipe()
		{
			int num = 0;
			screenshot_ = ByteString.Empty;
			int num2 = 0;
			thumbnail_ = ByteString.Empty;
			items_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60072FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B61A0", Offset = "0x7B4BA0", VA = "0x1807B61A0")]
		[DebuggerNonUserCode]
		public PictureRecipe(PictureRecipe other)
		{
			//IL_0029: Expected O, but got I4
			int num = (sceneItemID_ = other.sceneItemID_);
			GridCollection gridCollection = other.grids_;
			int num2 = 0;
			if (gridCollection != null)
			{
				GridCollection gridCollection2 = gridCollection.Clone();
			}
			grids_ = (GridCollection)num2;
			Avatar avatar = other.avatar_;
			Avatar avatar2 = default(Avatar);
			if (avatar != null)
			{
				avatar2 = avatar.Clone();
			}
			avatar_ = avatar2;
			bool flag = (avatarIsMale_ = other.avatarIsMale_);
			ByteString byteString = (screenshot_ = other.screenshot_);
			ByteString byteString2 = (thumbnail_ = other.thumbnail_);
			RepeatedField<int> repeatedField = (items_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.items_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60072FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B50D0", Offset = "0x7B3AD0", VA = "0x1807B50D0", Slot = "10")]
		[DebuggerNonUserCode]
		public PictureRecipe Clone()
		{
			//Discarded unreachable code: IL_00aa
			//IL_0030: Expected O, but got I4
			PictureRecipe pictureRecipe = new PictureRecipe();
			int num = (pictureRecipe.sceneItemID_ = sceneItemID_);
			GridCollection gridCollection = grids_;
			int num2 = 0;
			if (gridCollection != null)
			{
				GridCollection gridCollection2 = gridCollection.Clone();
			}
			pictureRecipe.grids_ = (GridCollection)num2;
			Avatar avatar = avatar_;
			Avatar avatar2 = default(Avatar);
			if (avatar != null)
			{
				avatar2 = avatar.Clone();
			}
			pictureRecipe.avatar_ = avatar2;
			bool flag = (pictureRecipe.avatarIsMale_ = avatarIsMale_);
			ByteString byteString = (pictureRecipe.screenshot_ = screenshot_);
			ByteString byteString2 = (pictureRecipe.thumbnail_ = thumbnail_);
			RepeatedField<int> repeatedField = (pictureRecipe.items_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)items_).Clone());
			UnknownFieldSet unknownFieldSet = (pictureRecipe._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pictureRecipe;
		}

		[Cpp2IlInjected.Token(Token = "0x600730D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5370", Offset = "0x7B3D70", VA = "0x1807B5370", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0 && (IntPtr)num != (IntPtr)this && (IntPtr)sceneItemID_ == (IntPtr)typeof(ByteString).TypeHandle && object.Equals(grids_, other))
			{
				bool flag = object.Equals(avatar_, other);
				if (flag && avatarIsMale_ == flag)
				{
					ByteString byteString = screenshot_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						ByteString byteString2 = thumbnail_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							RepeatedField<int> repeatedField = items_;
							bool flag4 = default(bool);
							if (flag4)
							{
								bool flag5 = object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600730E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5210", Offset = "0x7B3C10", VA = "0x1807B5210", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PictureRecipe other)
		{
			if (other != null && other != this)
			{
				int num = other.sceneItemID_;
				if (sceneItemID_ == num)
				{
					GridCollection objB = other.grids_;
					if (object.Equals(grids_, objB))
					{
						Avatar objB2 = other.avatar_;
						if (object.Equals(avatar_, objB2))
						{
							bool flag = other.avatarIsMale_;
							if (avatarIsMale_ == flag)
							{
								ByteString byteString = screenshot_;
								ByteString byteString2 = other.screenshot_;
								if (!(byteString != byteString2))
								{
									ByteString byteString3 = thumbnail_;
									ByteString byteString4 = other.thumbnail_;
									if (!(byteString3 != byteString4))
									{
										RepeatedField<int> repeatedField = items_;
										RepeatedField<int> repeatedField2 = other.items_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											UnknownFieldSet unknownFields = other._unknownFields;
											bool flag2 = object.Equals(_unknownFields, unknownFields);
										}
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

		[Cpp2IlInjected.Token(Token = "0x600730F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5670", Offset = "0x7B4070", VA = "0x1807B5670", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0095
			if (sceneItemID_ != 0)
			{
			}
			GridCollection gridCollection = grids_;
			if (gridCollection != null)
			{
				int hashCode = gridCollection.GetHashCode();
			}
			Avatar avatar = avatar_;
			if (avatar != null)
			{
				int hashCode2 = avatar.GetHashCode();
			}
			if (avatarIsMale_)
			{
			}
			if (screenshot_.Length != 0)
			{
				int hashCode3 = screenshot_.GetHashCode();
			}
			if (thumbnail_.Length != 0)
			{
				int hashCode4 = thumbnail_.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)items_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6007310")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E20", Offset = "0x7B4820", VA = "0x1807B5E20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007311")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E80", Offset = "0x7B4880", VA = "0x1807B5E80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00cb
			if ((long)grids_ != 0)
			{
				GridCollection value = grids_;
				output.WriteMessage(value);
			}
			if ((long)avatar_ != 0)
			{
				Avatar value2 = avatar_;
				output.WriteMessage(value2);
			}
			if (avatarIsMale_)
			{
				bool value3 = avatarIsMale_;
				output.WriteBool(value3);
			}
			if (screenshot_.Length != 0)
			{
				ByteString value4 = screenshot_;
				output.WriteBytes(value4);
			}
			if (thumbnail_.Length != 0)
			{
				ByteString value5 = thumbnail_;
				output.WriteBytes(value5);
			}
			if (sceneItemID_ != 0)
			{
				int value6 = sceneItemID_;
				output.WriteInt32(value6);
			}
			RepeatedField<int> repeatedField = items_;
			FieldCodec<int> repeated_items_codec = _repeated_items_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_items_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007312")]
		[Cpp2IlInjected.Address(RVA = "0x7B4D70", Offset = "0x7B3770", VA = "0x1807B4D70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00db
			int num = sceneItemID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			GridCollection gridCollection = grids_;
			if (gridCollection != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(gridCollection);
				num4++;
				num2 += num4;
			}
			Avatar avatar = avatar_;
			if (avatar != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(avatar);
				num5++;
				num2 += num5;
			}
			if (screenshot_.Length != 0)
			{
				int num6 = CodedOutputStream.ComputeBytesSize(screenshot_);
				num6++;
				num2 += num6;
			}
			if (thumbnail_.Length != 0)
			{
				int num7 = CodedOutputStream.ComputeBytesSize(thumbnail_);
				num7++;
				num2 += num7;
			}
			RepeatedField<int> repeatedField = items_;
			FieldCodec<int> repeated_items_codec = _repeated_items_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_items_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num8;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num2 += num9;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6007313")]
		[Cpp2IlInjected.Address(RVA = "0x7B59F0", Offset = "0x7B43F0", VA = "0x1807B59F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PictureRecipe other)
		{
			//Discarded unreachable code: IL_0115
			if (other == null)
			{
				return;
			}
			int num = other.sceneItemID_;
			if (num != 0)
			{
				sceneItemID_ = num;
			}
			if ((long)other.grids_ != 0)
			{
				GridCollection gridCollection2 = default(GridCollection);
				if (grids_ == null)
				{
					GridCollection gridCollection = (grids_ = new GridCollection());
					gridCollection2 = grids_;
				}
				GridCollection other2 = other.grids_;
				gridCollection2.MergeFrom(other2);
			}
			if ((long)other.avatar_ != 0)
			{
				Avatar avatar2 = default(Avatar);
				if (avatar_ == null)
				{
					Avatar avatar = (avatar_ = new Avatar());
					avatar2 = avatar_;
				}
				Avatar other3 = other.avatar_;
				avatar2.MergeFrom(other3);
			}
			bool flag = other.avatarIsMale_;
			if (flag)
			{
				avatarIsMale_ = flag;
			}
			if (other.screenshot_.Length != 0)
			{
				ByteString byteString2 = (Screenshot = other.screenshot_);
			}
			if (other.thumbnail_.Length != 0)
			{
				ByteString byteString4 = (Thumbnail = other.thumbnail_);
			}
			RepeatedField<int> repeatedField = items_;
			RepeatedField<int> repeatedField2 = other.items_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6007314")]
		[Cpp2IlInjected.Address(RVA = "0x7B57B0", Offset = "0x7B41B0", VA = "0x1807B57B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0115
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 56)
				{
					num += 4294967232u;
					if (num != 4294967293u)
					{
						goto IL_00fe;
					}
					RepeatedField<int> repeatedField = items_;
					FieldCodec<int> repeated_items_codec = _repeated_items_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_items_codec);
				}
				ByteString byteString2 = default(ByteString);
				if (num == 50)
				{
					byteString2 = (Thumbnail = input.ReadBytes());
				}
				if ((long)byteString2 != 56)
				{
					goto IL_00fe;
				}
				int num2 = (sceneItemID_ = input.ReadInt32());
			}
			ByteString byteString4 = default(ByteString);
			if ((int)num > 26)
			{
				bool flag = default(bool);
				if (num == 32)
				{
					flag = (avatarIsMale_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_00fe;
				}
				byteString4 = (Screenshot = input.ReadBytes());
			}
			GridCollection gridCollection = default(GridCollection);
			if ((long)byteString4 == 18)
			{
				GridCollection builder = default(GridCollection);
				if (grids_ == null)
				{
					gridCollection = (grids_ = new GridCollection());
					builder = grids_;
				}
				input.ReadMessage(builder);
			}
			if ((long)gridCollection == 26)
			{
				Avatar builder2 = default(Avatar);
				if (avatar_ == null)
				{
					Avatar avatar = (avatar_ = new Avatar());
					builder2 = avatar_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_00fe;
			IL_00fe:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6007315")]
		[Cpp2IlInjected.Address(RVA = "0x7B5500", Offset = "0x7B3F00", VA = "0x1807B5500", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if ((long)typeof(int).TypeHandle <= 6)
			{
				GridCollection gridCollection = grids_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007316")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BA0", Offset = "0x7B45A0", VA = "0x1807B5BA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_001c, IL_0024, IL_0025, IL_0026, IL_0033, IL_003b, IL_004c, IL_0052, IL_0058, IL_005e
			//IL_001b: Expected O, but got I4
			if ((long)typeof(int).TypeHandle <= 6)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				grids_ = (GridCollection)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007317")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F70", Offset = "0x7B3970", VA = "0x1807B4F70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000b, IL_000c, IL_0015, IL_0021, IL_0022
			if ((long)typeof(IList).TypeHandle > 6)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007318")]
		[Cpp2IlInjected.Address(RVA = "0x7B6060", Offset = "0x7B4A60", VA = "0x1807B6060")]
		static PictureRecipe()
		{
			Func<PictureRecipe> func = default(Func<PictureRecipe>);
			_parser = (MessageParser<PictureRecipe>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<PictureRecipe>)(object)FieldCodec.ForInt32(66u);
			/*Error: Unexpected end of block*/;
		}
	}
}
