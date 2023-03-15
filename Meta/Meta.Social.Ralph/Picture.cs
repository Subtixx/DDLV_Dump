using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Customization;

namespace Meta.Social.Ralph
{
	[Cpp2IlInjected.Token(Token = "0x2000DD6")]
	public sealed class Picture : IMessage<Picture>, IMessage, IEquatable<Picture>, IDeepCloneable<Picture>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40037E0")]
		private static readonly MessageParser<Picture> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40037E1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40037E2")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037E3")]
		private string iD_ = "";

		[Cpp2IlInjected.Token(Token = "0x40037E4")]
		public const int PlayerIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037E5")]
		private string playerID_ = "";

		[Cpp2IlInjected.Token(Token = "0x40037E6")]
		public const int ImageUrlFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40037E7")]
		private string imageUrl_ = "";

		[Cpp2IlInjected.Token(Token = "0x40037E8")]
		public const int RecipeFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40037E9")]
		private PictureRecipe recipe_;

		[Cpp2IlInjected.Token(Token = "0x40037EA")]
		public const int DateTakenFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40037EB")]
		private Timestamp dateTaken_;

		[Cpp2IlInjected.Token(Token = "0x170013D7")]
		[DebuggerNonUserCode]
		public static MessageParser<Picture> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600731C")]
			[Cpp2IlInjected.Address(RVA = "0x7B7D10", Offset = "0x7B6710", VA = "0x1807B7D10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600731D")]
			[Cpp2IlInjected.Address(RVA = "0x7B7C40", Offset = "0x7B6640", VA = "0x1807B7C40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013D9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600731E")]
			[Cpp2IlInjected.Address(RVA = "0x7B7D70", Offset = "0x7B6770", VA = "0x1807B7D70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DA")]
		[DebuggerNonUserCode]
		public string ID
		{
			[Cpp2IlInjected.Token(Token = "0x6007322")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007323")]
			[Cpp2IlInjected.Address(RVA = "0x7B7E80", Offset = "0x7B6880", VA = "0x1807B7E80")]
			set
			{
				string text = (iD_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DB")]
		[DebuggerNonUserCode]
		public string PlayerID
		{
			[Cpp2IlInjected.Token(Token = "0x6007324")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return playerID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007325")]
			[Cpp2IlInjected.Address(RVA = "0x7B7F60", Offset = "0x7B6960", VA = "0x1807B7F60")]
			set
			{
				string text = (playerID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DC")]
		[DebuggerNonUserCode]
		public string ImageUrl
		{
			[Cpp2IlInjected.Token(Token = "0x6007326")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return imageUrl_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007327")]
			[Cpp2IlInjected.Address(RVA = "0x7B7EF0", Offset = "0x7B68F0", VA = "0x1807B7EF0")]
			set
			{
				string text = (imageUrl_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DD")]
		[DebuggerNonUserCode]
		public PictureRecipe Recipe
		{
			[Cpp2IlInjected.Token(Token = "0x6007328")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return recipe_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007329")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				recipe_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013DE")]
		[DebuggerNonUserCode]
		public Timestamp DateTaken
		{
			[Cpp2IlInjected.Token(Token = "0x600732A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return dateTaken_;
			}
			[Cpp2IlInjected.Token(Token = "0x600732B")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				dateTaken_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600731F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7BD0", Offset = "0x7B65D0", VA = "0x1807B7BD0")]
		[DebuggerNonUserCode]
		public Picture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007320")]
		[Cpp2IlInjected.Address(RVA = "0x7B7980", Offset = "0x7B6380", VA = "0x1807B7980")]
		[DebuggerNonUserCode]
		public Picture(Picture other)
		{
			//IL_0099: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_0122: Expected O, but got I4
			string text = (iD_ = other.iD_);
			string text2 = (playerID_ = other.playerID_);
			string text3 = (imageUrl_ = other.imageUrl_);
			PictureRecipe pictureRecipe = other.recipe_;
			if (pictureRecipe != null)
			{
				PictureRecipe pictureRecipe2 = new PictureRecipe();
				int sceneItemID_ = pictureRecipe.sceneItemID_;
				int num = 0;
				pictureRecipe2.sceneItemID_ = sceneItemID_;
				GridCollection grids_ = pictureRecipe.grids_;
				if (grids_ != null)
				{
					GridCollection gridCollection = grids_.Clone();
				}
				pictureRecipe2.grids_ = (GridCollection)num;
				Avatar avatar_ = pictureRecipe.avatar_;
				if (avatar_ != null)
				{
					Avatar avatar = avatar_.Clone();
				}
				pictureRecipe2.avatar_ = (Avatar)num;
				bool flag = (pictureRecipe2.avatarIsMale_ = pictureRecipe.avatarIsMale_);
				ByteString byteString = (pictureRecipe2.screenshot_ = pictureRecipe.screenshot_);
				ByteString byteString2 = (pictureRecipe2.thumbnail_ = pictureRecipe.thumbnail_);
				RepeatedField<int> repeatedField = (pictureRecipe2.items_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)pictureRecipe.items_).Clone());
				UnknownFieldSet unknownFieldSet = (pictureRecipe2._unknownFields = UnknownFieldSet.Clone(pictureRecipe._unknownFields));
			}
			int num2 = 0;
			recipe_ = (PictureRecipe)num2;
			Timestamp timestamp = other.dateTaken_;
			Timestamp timestamp2 = default(Timestamp);
			if (timestamp != null)
			{
				timestamp2 = timestamp.Clone();
			}
			dateTaken_ = timestamp2;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007321")]
		[Cpp2IlInjected.Address(RVA = "0x7B6E20", Offset = "0x7B5820", VA = "0x1807B6E20", Slot = "10")]
		[DebuggerNonUserCode]
		public Picture Clone()
		{
			return new Picture(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600732C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6E80", Offset = "0x7B5880", VA = "0x1807B6E80", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = iD_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = playerID_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = imageUrl_;
						bool flag3 = default(bool);
						if (!flag3 && object.Equals(recipe_, other) && object.Equals(dateTaken_, other))
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600732D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F90", Offset = "0x7B5990", VA = "0x1807B6F90", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Picture other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.iD_;
				if (!(iD_ != text))
				{
					string text2 = other.playerID_;
					if (!(playerID_ != text2))
					{
						string text3 = other.imageUrl_;
						if (!(imageUrl_ != text3))
						{
							PictureRecipe objB = other.recipe_;
							if (object.Equals(recipe_, objB))
							{
								Timestamp objB2 = other.dateTaken_;
								if (object.Equals(dateTaken_, objB2))
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600732E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7110", Offset = "0x7B5B10", VA = "0x1807B7110", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_008d
			string text = iD_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = playerID_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = imageUrl_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			PictureRecipe pictureRecipe = recipe_;
			if (pictureRecipe != null)
			{
				int hashCode4 = pictureRecipe.GetHashCode();
			}
			Timestamp timestamp = dateTaken_;
			if (timestamp != null)
			{
				int hashCode5 = timestamp.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600732F")]
		[Cpp2IlInjected.Address(RVA = "0x7B76E0", Offset = "0x7B60E0", VA = "0x1807B76E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007330")]
		[Cpp2IlInjected.Address(RVA = "0x7B7740", Offset = "0x7B6140", VA = "0x1807B7740", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_009e
			if (iD_.m_stringLength != 0)
			{
				string value = iD_;
				output.WriteString(value);
			}
			if (playerID_.m_stringLength != 0)
			{
				string value2 = playerID_;
				output.WriteString(value2);
			}
			if (imageUrl_.m_stringLength != 0)
			{
				string value3 = imageUrl_;
				output.WriteString(value3);
			}
			if ((long)recipe_ != 0)
			{
				PictureRecipe value4 = recipe_;
				output.WriteMessage(value4);
			}
			if ((long)dateTaken_ != 0)
			{
				Timestamp value5 = dateTaken_;
				output.WriteMessage(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007331")]
		[Cpp2IlInjected.Address(RVA = "0x7B6BC0", Offset = "0x7B55C0", VA = "0x1807B6BC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00c1
			string text = iD_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = playerID_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = imageUrl_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			PictureRecipe pictureRecipe = recipe_;
			if (pictureRecipe != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(pictureRecipe);
				num5++;
				num += num5;
			}
			Timestamp timestamp = dateTaken_;
			if (timestamp != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(timestamp);
				num6++;
				num += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6007332")]
		[Cpp2IlInjected.Address(RVA = "0x7B7200", Offset = "0x7B5C00", VA = "0x1807B7200", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Picture other)
		{
			//Discarded unreachable code: IL_00e2
			if (other == null)
			{
				return;
			}
			string text = other.iD_;
			if (text.m_stringLength != 0)
			{
				ID = text;
			}
			string text2 = other.playerID_;
			if (text2.m_stringLength != 0)
			{
				PlayerID = text2;
			}
			string text3 = other.imageUrl_;
			if (text3.m_stringLength != 0)
			{
				ImageUrl = text3;
			}
			if ((long)other.recipe_ != 0)
			{
				PictureRecipe pictureRecipe2 = default(PictureRecipe);
				if (recipe_ == null)
				{
					PictureRecipe pictureRecipe = (recipe_ = new PictureRecipe());
					pictureRecipe2 = recipe_;
				}
				PictureRecipe other2 = other.recipe_;
				pictureRecipe2.MergeFrom(other2);
			}
			if ((long)other.dateTaken_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (dateTaken_ == null)
				{
					Timestamp timestamp = (dateTaken_ = new Timestamp());
					timestamp2 = dateTaken_;
				}
				Timestamp other3 = other.dateTaken_;
				timestamp2.MergeFrom(other3);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6007333")]
		[Cpp2IlInjected.Address(RVA = "0x7B7380", Offset = "0x7B5D80", VA = "0x1807B7380", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c7
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (ImageUrl = input.ReadString());
				}
				PictureRecipe pictureRecipe = default(PictureRecipe);
				if (num == 34)
				{
					PictureRecipe builder = default(PictureRecipe);
					if (recipe_ == null)
					{
						pictureRecipe = (recipe_ = new PictureRecipe());
						builder = recipe_;
					}
					input.ReadMessage(builder);
				}
				if ((long)pictureRecipe != 42)
				{
					goto IL_00b0;
				}
				Timestamp builder2 = default(Timestamp);
				if (dateTaken_ == null)
				{
					Timestamp timestamp = (dateTaken_ = new Timestamp());
					builder2 = dateTaken_;
				}
				input.ReadMessage(builder2);
			}
			string text4 = default(string);
			if (num == 10)
			{
				text4 = (ID = input.ReadString());
			}
			if ((long)text4 == 18)
			{
				string text6 = (PlayerID = input.ReadString());
			}
			goto IL_00b0;
			IL_00b0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6007334")]
		[Cpp2IlInjected.Address(RVA = "0x7B7050", Offset = "0x7B5A50", VA = "0x1807B7050", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Timestamp timestamp = dateTaken_;
				PictureRecipe pictureRecipe = recipe_;
				string text = imageUrl_;
				string text2 = playerID_;
				string text3 = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007335")]
		[Cpp2IlInjected.Address(RVA = "0x7B7530", Offset = "0x7B5F30", VA = "0x1807B7530", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0029: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							int num2 = 0;
							if (value == null || value != null)
							{
								dateTaken_ = (Timestamp)num2;
								return;
							}
							throw new InvalidCastException();
						}
						default:
							return;
						case 0:
							break;
						}
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
					}
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007336")]
		[Cpp2IlInjected.Address(RVA = "0x7B6D40", Offset = "0x7B5740", VA = "0x1807B6D40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0 || num == 0 || num == 1)
					{
						ImageUrl = "";
					}
				}
				else
				{
					PlayerID = "";
				}
			}
			else
			{
				ID = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007337")]
		[Cpp2IlInjected.Address(RVA = "0x7B7870", Offset = "0x7B6270", VA = "0x1807B7870")]
		static Picture()
		{
			Func<Picture> func = default(Func<Picture>);
			_parser = (MessageParser<Picture>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
