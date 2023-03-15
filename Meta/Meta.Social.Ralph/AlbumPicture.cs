using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Customization;

namespace Meta.Social.Ralph
{
	[Cpp2IlInjected.Token(Token = "0x2000DDC")]
	public sealed class AlbumPicture : IMessage<AlbumPicture>, IMessage, IEquatable<AlbumPicture>, IDeepCloneable<AlbumPicture>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40037FE")]
		private static readonly MessageParser<AlbumPicture> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40037FF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003800")]
		public const int UniqueIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003801")]
		private int uniqueId_;

		[Cpp2IlInjected.Token(Token = "0x4003802")]
		public const int TakenFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003803")]
		private Timestamp taken_;

		[Cpp2IlInjected.Token(Token = "0x4003804")]
		public const int EventIdFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003805")]
		private string eventId_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003806")]
		public const int AvatarFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003807")]
		private Avatar avatar_;

		[Cpp2IlInjected.Token(Token = "0x4003808")]
		public const int IsMaleFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003809")]
		private bool isMale_;

		[Cpp2IlInjected.Token(Token = "0x400380A")]
		public const int ItemsFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x400380B")]
		private static readonly FieldCodec<int> _repeated_items_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400380C")]
		private readonly RepeatedField<int> items_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400380D")]
		public const int SceneFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400380E")]
		private string scene_ = "";

		[Cpp2IlInjected.Token(Token = "0x400380F")]
		public const int AssetNameFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003810")]
		private string assetName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003811")]
		public const int AssetNameThumbnailFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003812")]
		private string assetNameThumbnail_ = "";

		[Cpp2IlInjected.Token(Token = "0x4003813")]
		public const int LikesFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003814")]
		private int likes_;

		[Cpp2IlInjected.Token(Token = "0x170013EA")]
		[DebuggerNonUserCode]
		public static MessageParser<AlbumPicture> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600736E")]
			[Cpp2IlInjected.Address(RVA = "0x18E86B0", Offset = "0x18E70B0", VA = "0x1818E86B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013EB")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600736F")]
			[Cpp2IlInjected.Address(RVA = "0x18E85E0", Offset = "0x18E6FE0", VA = "0x1818E85E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013EC")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007370")]
			[Cpp2IlInjected.Address(RVA = "0x18E8710", Offset = "0x18E7110", VA = "0x1818E8710", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013ED")]
		[DebuggerNonUserCode]
		public int UniqueId
		{
			[Cpp2IlInjected.Token(Token = "0x6007374")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return uniqueId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007375")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				uniqueId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013EE")]
		[DebuggerNonUserCode]
		public Timestamp Taken
		{
			[Cpp2IlInjected.Token(Token = "0x6007376")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return taken_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007377")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				taken_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013EF")]
		[DebuggerNonUserCode]
		public string EventId
		{
			[Cpp2IlInjected.Token(Token = "0x6007378")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return eventId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007379")]
			[Cpp2IlInjected.Address(RVA = "0x18E8900", Offset = "0x18E7300", VA = "0x1818E8900")]
			set
			{
				string text = (eventId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F0")]
		[DebuggerNonUserCode]
		public Avatar Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x600737A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return avatar_;
			}
			[Cpp2IlInjected.Token(Token = "0x600737B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				avatar_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F1")]
		[DebuggerNonUserCode]
		public bool IsMale
		{
			[Cpp2IlInjected.Token(Token = "0x600737C")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get
			{
				return isMale_;
			}
			[Cpp2IlInjected.Token(Token = "0x600737D")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			set
			{
				isMale_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F2")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Items
		{
			[Cpp2IlInjected.Token(Token = "0x600737E")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return items_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F3")]
		[DebuggerNonUserCode]
		public string Scene
		{
			[Cpp2IlInjected.Token(Token = "0x600737F")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return scene_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007380")]
			[Cpp2IlInjected.Address(RVA = "0x18E8970", Offset = "0x18E7370", VA = "0x1818E8970")]
			set
			{
				string text = (scene_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F4")]
		[DebuggerNonUserCode]
		public string AssetName
		{
			[Cpp2IlInjected.Token(Token = "0x6007381")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return assetName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007382")]
			[Cpp2IlInjected.Address(RVA = "0x18E8890", Offset = "0x18E7290", VA = "0x1818E8890")]
			set
			{
				string text = (assetName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F5")]
		[DebuggerNonUserCode]
		public string AssetNameThumbnail
		{
			[Cpp2IlInjected.Token(Token = "0x6007383")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return assetNameThumbnail_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007384")]
			[Cpp2IlInjected.Address(RVA = "0x18E8820", Offset = "0x18E7220", VA = "0x1818E8820")]
			set
			{
				string text = (assetNameThumbnail_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F6")]
		[DebuggerNonUserCode]
		public int Likes
		{
			[Cpp2IlInjected.Token(Token = "0x6007385")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return likes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6007386")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				likes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007371")]
		[Cpp2IlInjected.Address(RVA = "0x18E8300", Offset = "0x18E6D00", VA = "0x1818E8300")]
		[DebuggerNonUserCode]
		public AlbumPicture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007372")]
		[Cpp2IlInjected.Address(RVA = "0x18E83D0", Offset = "0x18E6DD0", VA = "0x1818E83D0")]
		[DebuggerNonUserCode]
		public AlbumPicture(AlbumPicture other)
		{
			//IL_0069: Expected O, but got I4
			int num = other.uniqueId_;
			int num2 = 0;
			uniqueId_ = num;
			Timestamp timestamp = other.taken_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			taken_ = (Timestamp)num2;
			string text = (eventId_ = other.eventId_);
			Avatar avatar = other.avatar_;
			Avatar avatar2 = default(Avatar);
			if (avatar != null)
			{
				avatar2 = avatar.Clone();
			}
			avatar_ = avatar2;
			bool flag = (isMale_ = other.isMale_);
			RepeatedField<int> repeatedField = (items_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.items_).Clone());
			string text2 = (scene_ = other.scene_);
			string text3 = (assetName_ = other.assetName_);
			string text4 = (assetNameThumbnail_ = other.assetNameThumbnail_);
			int num3 = (likes_ = other.likes_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007373")]
		[Cpp2IlInjected.Address(RVA = "0x18E6F40", Offset = "0x18E5940", VA = "0x1818E6F40", Slot = "10")]
		[DebuggerNonUserCode]
		public AlbumPicture Clone()
		{
			return new AlbumPicture(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007387")]
		[Cpp2IlInjected.Address(RVA = "0x18E70E0", Offset = "0x18E5AE0", VA = "0x1818E70E0", Slot = "0")]
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
				if ((IntPtr)uniqueId_ == (IntPtr)typeof(AlbumPicture).TypeHandle && object.Equals(taken_, other))
				{
					string text = eventId_;
					bool flag = default(bool);
					if (!flag)
					{
						bool flag2 = object.Equals(avatar_, other);
						if (flag2 && isMale_ == flag2)
						{
							RepeatedField<int> repeatedField = items_;
							bool flag3 = default(bool);
							if (flag3)
							{
								string text2 = scene_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									string text3 = assetName_;
									bool flag5 = default(bool);
									if (!flag5)
									{
										string text4 = assetNameThumbnail_;
										bool flag6 = default(bool);
										if (!flag6 && likes_ == (flag6 ? 1 : 0))
										{
											return object.Equals(_unknownFields, other);
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

		[Cpp2IlInjected.Token(Token = "0x6007388")]
		[Cpp2IlInjected.Address(RVA = "0x18E6FA0", Offset = "0x18E59A0", VA = "0x1818E6FA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AlbumPicture other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.uniqueId_;
				if (uniqueId_ == num)
				{
					Timestamp objB = other.taken_;
					if (object.Equals(taken_, objB))
					{
						string text = other.eventId_;
						if (!(eventId_ != text))
						{
							Avatar objB2 = other.avatar_;
							if (object.Equals(avatar_, objB2))
							{
								bool flag = other.isMale_;
								if (isMale_ == flag)
								{
									RepeatedField<int> repeatedField = items_;
									RepeatedField<int> repeatedField2 = other.items_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
									{
										string text2 = other.scene_;
										if (!(scene_ != text2))
										{
											string text3 = other.assetName_;
											if (!(assetName_ != text3))
											{
												string text4 = other.assetNameThumbnail_;
												if (!(assetNameThumbnail_ != text4))
												{
													int num2 = other.likes_;
													if (likes_ == num2)
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007389")]
		[Cpp2IlInjected.Address(RVA = "0x18E7430", Offset = "0x18E5E30", VA = "0x1818E7430", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00d4
			if (uniqueId_ != 0)
			{
			}
			Timestamp timestamp = taken_;
			if (timestamp != null)
			{
				int hashCode = timestamp.GetHashCode();
			}
			string text = eventId_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			Avatar avatar = avatar_;
			if (avatar != null)
			{
				int hashCode3 = avatar.GetHashCode();
			}
			if (isMale_)
			{
			}
			int hashCode4 = ((RepeatedField<T>)(object)items_).GetHashCode();
			string text2 = scene_;
			if (text2.m_stringLength != 0)
			{
				int hashCode5 = text2.GetHashCode();
			}
			string text3 = assetName_;
			if (text3.m_stringLength != 0)
			{
				int hashCode6 = text3.GetHashCode();
			}
			string text4 = assetNameThumbnail_;
			if (text4.m_stringLength != 0)
			{
				int hashCode7 = text4.GetHashCode();
			}
			if (likes_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600738A")]
		[Cpp2IlInjected.Address(RVA = "0x18E7EF0", Offset = "0x18E68F0", VA = "0x1818E7EF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600738B")]
		[Cpp2IlInjected.Address(RVA = "0x18E7F50", Offset = "0x18E6950", VA = "0x1818E7F50", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0120
			if (uniqueId_ != 0)
			{
				int value = uniqueId_;
				output.WriteInt32(value);
			}
			if ((long)taken_ != 0)
			{
				Timestamp value2 = taken_;
				output.WriteMessage(value2);
			}
			if (eventId_.m_stringLength != 0)
			{
				string value3 = eventId_;
				output.WriteString(value3);
			}
			if ((long)avatar_ != 0)
			{
				Avatar value4 = avatar_;
				output.WriteMessage(value4);
			}
			if (isMale_)
			{
				bool value5 = isMale_;
				output.WriteBool(value5);
			}
			RepeatedField<int> repeatedField = items_;
			FieldCodec<int> repeated_items_codec = _repeated_items_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_items_codec);
			if (scene_.m_stringLength != 0)
			{
				string value6 = scene_;
				output.WriteString(value6);
			}
			if (assetName_.m_stringLength != 0)
			{
				string value7 = assetName_;
				output.WriteString(value7);
			}
			if (assetNameThumbnail_.m_stringLength != 0)
			{
				string value8 = assetNameThumbnail_;
				output.WriteString(value8);
			}
			if (likes_ != 0)
			{
				int value9 = likes_;
				output.WriteInt32(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600738C")]
		[Cpp2IlInjected.Address(RVA = "0x18E6AF0", Offset = "0x18E54F0", VA = "0x1818E6AF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_012a
			int num = uniqueId_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			Timestamp timestamp = taken_;
			if (timestamp != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(timestamp);
				num4++;
				num2 += num4;
			}
			string text = eventId_;
			if (text.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text);
				num5++;
				num2 += num5;
			}
			Avatar avatar = avatar_;
			if (avatar != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(avatar);
				num6++;
				num2 += num6;
			}
			RepeatedField<int> repeatedField = items_;
			FieldCodec<int> repeated_items_codec = _repeated_items_codec;
			int num7 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_items_codec);
			string text2 = scene_;
			if (text2.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text2);
				num8++;
			}
			string text3 = assetName_;
			if (text3.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text3);
				num9 += 2;
			}
			string text4 = assetNameThumbnail_;
			if (text4.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text4);
				num10 += 2;
			}
			int num11 = likes_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12 += 2;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600738D")]
		[Cpp2IlInjected.Address(RVA = "0x18E75B0", Offset = "0x18E5FB0", VA = "0x1818E75B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AlbumPicture other)
		{
			//Discarded unreachable code: IL_028a
			if (other == null)
			{
				return;
			}
			int num = other.uniqueId_;
			if (num != 0)
			{
				uniqueId_ = num;
			}
			if ((long)other.taken_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (taken_ == null)
				{
					Timestamp timestamp = (taken_ = new Timestamp());
					timestamp2 = taken_;
				}
				Timestamp other2 = other.taken_;
				timestamp2.MergeFrom(other2);
			}
			string text = other.eventId_;
			if (text.m_stringLength != 0)
			{
				EventId = text;
			}
			if (other.avatar_ != null)
			{
				Avatar avatar2 = default(Avatar);
				Avatar avatar3 = default(Avatar);
				if (avatar_ == null)
				{
					Avatar avatar = (avatar_ = new Avatar());
					avatar2 = avatar_;
					avatar3 = other.avatar_;
				}
				if (avatar3 != null)
				{
					uint id_ = avatar3.id_;
					if (id_ != 0)
					{
						avatar2.id_ = id_;
					}
					MapField<uint, int> clothes_ = avatar2.clothes_;
					MapField<uint, int> clothes_2 = avatar3.clothes_;
					((MapField<TKey, TValue>)(object)clothes_).Add((IDictionary<, >)(object)clothes_2);
					MapField<uint, int> incompatibleClothes_ = avatar2.incompatibleClothes_;
					MapField<uint, int> incompatibleClothes_2 = avatar3.incompatibleClothes_;
					((MapField<TKey, TValue>)(object)incompatibleClothes_).Add((IDictionary<, >)(object)incompatibleClothes_2);
					int skinColorIndex_ = avatar3.skinColorIndex_;
					if (skinColorIndex_ != 0)
					{
						avatar2.skinColorIndex_ = skinColorIndex_;
					}
					int eyeColor_ = avatar3.eyeColor_;
					if (eyeColor_ != 0)
					{
						avatar2.eyeColor_ = eyeColor_;
					}
					int hairColorIndex_ = avatar3.hairColorIndex_;
					if (hairColorIndex_ != 0)
					{
						avatar2.hairColorIndex_ = hairColorIndex_;
					}
					int hairHighlightColor_ = avatar3.hairHighlightColor_;
					if (hairHighlightColor_ != 0)
					{
						avatar2.hairHighlightColor_ = hairHighlightColor_;
					}
					int bodyType_ = avatar3.bodyType_;
					if (bodyType_ != 0)
					{
						avatar2.bodyType_ = bodyType_;
					}
					MapField<uint, int> faceType_ = avatar2.faceType_;
					MapField<uint, int> faceType_2 = avatar3.faceType_;
					((MapField<TKey, TValue>)(object)faceType_).Add((IDictionary<, >)(object)faceType_2);
					MapField<uint, Makeup> makeup_ = avatar2.makeup_;
					MapField<uint, Makeup> makeup_2 = avatar3.makeup_;
					((MapField<TKey, TValue>)(object)makeup_).Add((IDictionary<, >)(object)makeup_2);
					MapField<int, int> clothingCustomization_ = avatar2.clothingCustomization_;
					MapField<int, int> clothingCustomization_2 = avatar3.clothingCustomization_;
					((MapField<TKey, TValue>)(object)clothingCustomization_).Add((IDictionary<, >)(object)clothingCustomization_2);
					UnknownFieldSet unknownFields = avatar3._unknownFields;
					UnknownFieldSet unknownFieldSet = (avatar2._unknownFields = UnknownFieldSet.MergeFrom(avatar2._unknownFields, unknownFields));
				}
			}
			bool flag = other.isMale_;
			if (flag)
			{
				isMale_ = flag;
			}
			RepeatedField<int> repeatedField = items_;
			RepeatedField<int> repeatedField2 = other.items_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			string text2 = other.scene_;
			if (text2.m_stringLength != 0)
			{
				Scene = text2;
			}
			string text3 = other.assetName_;
			if (text3.m_stringLength != 0)
			{
				AssetName = text3;
			}
			string text4 = other.assetNameThumbnail_;
			if (text4.m_stringLength != 0)
			{
				AssetNameThumbnail = text4;
			}
			int num2 = other.likes_;
			if (num2 != 0)
			{
				likes_ = num2;
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x600738E")]
		[Cpp2IlInjected.Address(RVA = "0x18E78D0", Offset = "0x18E62D0", VA = "0x1818E78D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0164
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 88)
			{
				if ((int)num > 106)
				{
					if (num == 162)
					{
						string text2 = (AssetName = input.ReadString());
					}
					string text4 = default(string);
					if (num == 170)
					{
						text4 = (AssetNameThumbnail = input.ReadString());
					}
					if ((long)text4 != 240)
					{
						goto IL_014d;
					}
					int num2 = (likes_ = input.ReadInt32());
				}
				if ((long)input != 4294967293L)
				{
					if (num != 106)
					{
						goto IL_014d;
					}
					string text6 = (Scene = input.ReadString());
				}
				RepeatedField<int> repeatedField = items_;
				FieldCodec<int> repeated_items_codec = _repeated_items_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_items_codec);
			}
			bool flag = default(bool);
			if ((int)num > 18)
			{
				string text8 = default(string);
				if (num == 26)
				{
					text8 = (EventId = input.ReadString());
				}
				Avatar avatar = default(Avatar);
				if ((long)text8 == 82)
				{
					Avatar builder = default(Avatar);
					if (avatar_ == null)
					{
						avatar = (avatar_ = new Avatar());
						builder = avatar_;
					}
					input.ReadMessage(builder);
				}
				if ((long)avatar != 88)
				{
					goto IL_014d;
				}
				flag = (isMale_ = input.ReadBool());
			}
			int num3 = default(int);
			if (flag)
			{
				num3 = (uniqueId_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				Timestamp builder2 = default(Timestamp);
				if (taken_ == null)
				{
					Timestamp timestamp = (taken_ = new Timestamp());
					builder2 = taken_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_014d;
			IL_014d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600738F")]
		[Cpp2IlInjected.Address(RVA = "0x18E7270", Offset = "0x18E5C70", VA = "0x1818E7270", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 20)
			{
				if (fieldNumber == 21)
				{
					string text = assetNameThumbnail_;
				}
				if (fieldNumber != 30)
				{
					goto IL_0029;
				}
			}
			if (fieldNumber - 1 <= 12)
			{
				int num = uniqueId_;
			}
			if (fieldNumber != 20)
			{
			}
			goto IL_0029;
			IL_0029:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007390")]
		[Cpp2IlInjected.Address(RVA = "0x18E7B70", Offset = "0x18E6570", VA = "0x1818E7B70", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0038, IL_0040, IL_0041, IL_0049, IL_004b, IL_0057, IL_005d, IL_0063
			//IL_001b: Expected O, but got I4
			//IL_0028: Expected I4, but got O
			//IL_0037: Expected I4, but got O
			//IL_003f: Expected O, but got I4
			if (fieldNumber > 20)
			{
				switch (fieldNumber)
				{
				case 21:
				{
					int num = 0;
					if (value == null || value != null)
					{
						AssetNameThumbnail = (string)num;
						break;
					}
					throw new InvalidCastException();
				}
				case 30:
				{
					object obj = default(object);
					likes_ = (int)obj;
					break;
				}
				}
			}
			else if (fieldNumber - 1 <= 12)
			{
				object obj2 = default(object);
				uniqueId_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007391")]
		[Cpp2IlInjected.Address(RVA = "0x18E6D90", Offset = "0x18E5790", VA = "0x1818E6D90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0036, IL_0039, IL_003a, IL_0041
			//IL_0024: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			if (fieldNumber > 20)
			{
				switch (fieldNumber)
				{
				case 21:
					AssetNameThumbnail = "";
					break;
				case 30:
					likes_ = 0;
					break;
				}
			}
			else if (fieldNumber - 1 <= 12)
			{
				uniqueId_ = 0;
			}
			else if (fieldNumber != 20)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007392")]
		[Cpp2IlInjected.Address(RVA = "0x18E81C0", Offset = "0x18E6BC0", VA = "0x1818E81C0")]
		static AlbumPicture()
		{
			Func<AlbumPicture> func = default(Func<AlbumPicture>);
			_parser = (MessageParser<AlbumPicture>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<AlbumPicture>)(object)FieldCodec.ForInt32(98u);
			/*Error: Unexpected end of block*/;
		}
	}
}
