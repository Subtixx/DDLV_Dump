using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002F9")]
	public sealed class DecalItemData : IMessage<DecalItemData>, IMessage, IEquatable<DecalItemData>, IDeepCloneable<DecalItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IHasTags, IHasSet, IIsHiddable, IRewardGenerationCondition, IProtobufDefaultData, IOnlineAvailability, IAvailability
	{
		[Cpp2IlInjected.Token(Token = "0x4000E51")]
		private static readonly MessageParser<DecalItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E52")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000E53")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000E54")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000E55")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000E56")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E57")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000E58")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E59")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000E5A")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E5B")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000E5C")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000E5D")]
		public const int SetItemIDFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000E5E")]
		private int setItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000E5F")]
		public const int AllowColoringFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000E60")]
		private bool allowColoring_;

		[Cpp2IlInjected.Token(Token = "0x4000E61")]
		public const int IsHiddenFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000E62")]
		private bool isHidden_;

		[Cpp2IlInjected.Token(Token = "0x4000E63")]
		public const int TagsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4000E64")]
		private static readonly FieldCodec<int> _repeated_tags_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000E65")]
		private readonly RepeatedField<int> tags_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000E66")]
		public const int AppearanceConditionFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000E67")]
		private RewardAppearanceCondition appearanceCondition_;

		[Cpp2IlInjected.Token(Token = "0x4000E68")]
		public const int IsUnavailableForGeneratorFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000E69")]
		private bool isUnavailableForGenerator_;

		[Cpp2IlInjected.Token(Token = "0x4000E6A")]
		public const int IsSyncOnlineItemFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
		[Cpp2IlInjected.Token(Token = "0x4000E6B")]
		private bool isSyncOnlineItem_;

		[Cpp2IlInjected.Token(Token = "0x4000E6C")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000E6D")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000E6E")]
		public static ReadOnlyCollection<(TagItemType tagType, int? limit)> usedTagTypes;

		[Cpp2IlInjected.Token(Token = "0x170007F6")]
		[DebuggerNonUserCode]
		public static MessageParser<DecalItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002159")]
			[Cpp2IlInjected.Address(RVA = "0x356EC70", Offset = "0x356D670", VA = "0x18356EC70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600215A")]
			[Cpp2IlInjected.Address(RVA = "0x356EBA0", Offset = "0x356D5A0", VA = "0x18356EBA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600215B")]
			[Cpp2IlInjected.Address(RVA = "0x356ED30", Offset = "0x356D730", VA = "0x18356ED30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F9")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x600215F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002160")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FA")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002161")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002162")]
			[Cpp2IlInjected.Address(RVA = "0x356EF20", Offset = "0x356D920", VA = "0x18356EF20")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FB")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002163")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002164")]
			[Cpp2IlInjected.Address(RVA = "0x356EE40", Offset = "0x356D840", VA = "0x18356EE40")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FC")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002165")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002166")]
			[Cpp2IlInjected.Address(RVA = "0x356EEB0", Offset = "0x356D8B0", VA = "0x18356EEB0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FD")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002167")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002168")]
			[Cpp2IlInjected.Address(RVA = "0x356EF90", Offset = "0x356D990", VA = "0x18356EF90")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FE")]
		[DebuggerNonUserCode]
		public int SetItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6002169")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return setItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600216A")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				setItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007FF")]
		[DebuggerNonUserCode]
		public bool AllowColoring
		{
			[Cpp2IlInjected.Token(Token = "0x600216B")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E60", Offset = "0xAE0860", VA = "0x180AE1E60")]
			get
			{
				return allowColoring_;
			}
			[Cpp2IlInjected.Token(Token = "0x600216C")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E70", Offset = "0xAE0870", VA = "0x180AE1E70")]
			set
			{
				allowColoring_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000800")]
		[DebuggerNonUserCode]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x600216D")]
			[Cpp2IlInjected.Address(RVA = "0x139A3F0", Offset = "0x1398DF0", VA = "0x18139A3F0", Slot = "26")]
			get
			{
				return isHidden_;
			}
			[Cpp2IlInjected.Token(Token = "0x600216E")]
			[Cpp2IlInjected.Address(RVA = "0x139A700", Offset = "0x1399100", VA = "0x18139A700")]
			set
			{
				isHidden_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000801")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x600216F")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "24")]
			get
			{
				return tags_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000802")]
		[DebuggerNonUserCode]
		public RewardAppearanceCondition AppearanceCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6002170")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return appearanceCondition_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002171")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				appearanceCondition_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000803")]
		[DebuggerNonUserCode]
		public bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6002172")]
			[Cpp2IlInjected.Address(RVA = "0x1781430", Offset = "0x177FE30", VA = "0x181781430", Slot = "31")]
			get
			{
				return isUnavailableForGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002173")]
			[Cpp2IlInjected.Address(RVA = "0x1781A50", Offset = "0x1780450", VA = "0x181781A50", Slot = "32")]
			set
			{
				isUnavailableForGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000804")]
		[DebuggerNonUserCode]
		public bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002174")]
			[Cpp2IlInjected.Address(RVA = "0x881950", Offset = "0x880350", VA = "0x180881950", Slot = "29")]
			get
			{
				return isSyncOnlineItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002175")]
			[Cpp2IlInjected.Address(RVA = "0x881A60", Offset = "0x880460", VA = "0x180881A60", Slot = "30")]
			set
			{
				isSyncOnlineItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000805")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002176")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002177")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000806")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002183")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000807")]
		public Item SetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002184")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0", Slot = "25")]
			get
			{
				int num = setItemID_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000808")]
		public IEnumerable<(TagItemType tagType, int? limit)> UsedTagTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6002185")]
			[Cpp2IlInjected.Address(RVA = "0x356ECD0", Offset = "0x356D6D0", VA = "0x18356ECD0", Slot = "23")]
			get
			{
				ReadOnlyCollection<(TagItemType, int?)> readOnlyCollection = usedTagTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600215C")]
		[Cpp2IlInjected.Address(RVA = "0x356EAD0", Offset = "0x356D4D0", VA = "0x18356EAD0")]
		[DebuggerNonUserCode]
		public DecalItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600215D")]
		[Cpp2IlInjected.Address(RVA = "0x356E8F0", Offset = "0x356D2F0", VA = "0x18356E8F0")]
		[DebuggerNonUserCode]
		public DecalItemData(DecalItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (setItemID_ = other.setItemID_);
			bool flag = (allowColoring_ = other.allowColoring_);
			bool flag2 = (isHidden_ = other.isHidden_);
			RepeatedField<int> repeatedField = (tags_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tags_).Clone());
			RewardAppearanceCondition rewardAppearanceCondition = (appearanceCondition_ = other.appearanceCondition_);
			bool flag3 = (isUnavailableForGenerator_ = other.isUnavailableForGenerator_);
			bool flag4 = (isSyncOnlineItem_ = other.isSyncOnlineItem_);
			uint num3 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600215E")]
		[Cpp2IlInjected.Address(RVA = "0x356D290", Offset = "0x356BC90", VA = "0x18356D290", Slot = "10")]
		[DebuggerNonUserCode]
		public DecalItemData Clone()
		{
			return new DecalItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002178")]
		[Cpp2IlInjected.Address(RVA = "0x356D580", Offset = "0x356BF80", VA = "0x18356D580", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(DecalItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4 && setItemID_ == (flag4 ? 1 : 0) && allowColoring_ == flag4 && isHidden_ == flag4)
								{
									RepeatedField<int> repeatedField = tags_;
									bool flag5 = default(bool);
									if (flag5 && appearanceCondition_ == (flag5 ? RewardAppearanceCondition.Gardening : RewardAppearanceCondition.Anywhere) && isUnavailableForGenerator_ == flag5 && isSyncOnlineItem_ == flag5 && glotID_ == (flag5 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x6002179")]
		[Cpp2IlInjected.Address(RVA = "0x356D440", Offset = "0x356BE40", VA = "0x18356D440", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DecalItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									int num2 = other.setItemID_;
									if (setItemID_ == num2)
									{
										bool flag = other.allowColoring_;
										if (allowColoring_ == flag)
										{
											bool flag2 = other.isHidden_;
											if (isHidden_ == flag2)
											{
												RepeatedField<int> repeatedField = tags_;
												RepeatedField<int> repeatedField2 = other.tags_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													RewardAppearanceCondition rewardAppearanceCondition = other.appearanceCondition_;
													if (appearanceCondition_ == rewardAppearanceCondition)
													{
														bool flag3 = other.isUnavailableForGenerator_;
														if (isUnavailableForGenerator_ == flag3)
														{
															bool flag4 = other.isSyncOnlineItem_;
															if (isSyncOnlineItem_ == flag4)
															{
																uint num3 = other.glotID_;
																if (glotID_ == num3)
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
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600217A")]
		[Cpp2IlInjected.Address(RVA = "0x356D950", Offset = "0x356C350", VA = "0x18356D950", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00d5
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			if (setItemID_ != 0)
			{
			}
			if (allowColoring_)
			{
			}
			if (isHidden_)
			{
			}
			int hashCode5 = ((RepeatedField<T>)(object)tags_).GetHashCode();
			if (appearanceCondition_ != 0)
			{
			}
			if (isUnavailableForGenerator_)
			{
			}
			if (isSyncOnlineItem_)
			{
			}
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600217B")]
		[Cpp2IlInjected.Address(RVA = "0x356E330", Offset = "0x356CD30", VA = "0x18356E330", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600217C")]
		[Cpp2IlInjected.Address(RVA = "0x356E390", Offset = "0x356CD90", VA = "0x18356E390", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0158
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (setItemID_ != 0)
			{
				int value6 = setItemID_;
				output.WriteInt32(value6);
			}
			if (allowColoring_)
			{
				bool value7 = allowColoring_;
				output.WriteBool(value7);
			}
			if (isHidden_)
			{
				bool value8 = isHidden_;
				output.WriteBool(value8);
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tags_codec);
			if (appearanceCondition_ != 0)
			{
			}
			if (isUnavailableForGenerator_)
			{
				bool value9 = isUnavailableForGenerator_;
				output.WriteBool(value9);
			}
			if (isSyncOnlineItem_)
			{
				bool value10 = isSyncOnlineItem_;
				output.WriteBool(value10);
			}
			if (glotID_ != 0)
			{
				uint value11 = glotID_;
				output.WriteUInt32(value11);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600217D")]
		[Cpp2IlInjected.Address(RVA = "0x356CCE0", Offset = "0x356B6E0", VA = "0x18356CCE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0135
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			int num8 = setItemID_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			RepeatedField<int> repeatedField = tags_;
			FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tags_codec);
			RewardAppearanceCondition rewardAppearanceCondition = appearanceCondition_;
			if (rewardAppearanceCondition != 0)
			{
				int num11 = CodedOutputStream.ComputeEnumSize((int)rewardAppearanceCondition);
				num11++;
			}
			uint num12 = glotID_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeUInt32Size(num12);
				num13 += 2;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num14 = unknownFields.CalculateSize();
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600217E")]
		[Cpp2IlInjected.Address(RVA = "0x356DB30", Offset = "0x356C530", VA = "0x18356DB30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DecalItemData other)
		{
			//Discarded unreachable code: IL_0145
			if (other != null)
			{
				int num = other.iD_;
				if (num != 0)
				{
					iD_ = num;
				}
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				string text2 = other.displayName_;
				if (text2.m_stringLength != 0)
				{
					DisplayName = text2;
				}
				string text3 = other.iconAddress_;
				if (text3.m_stringLength != 0)
				{
					IconAddress = text3;
				}
				string text4 = other.prefabAddress_;
				if (text4.m_stringLength != 0)
				{
					PrefabAddress = text4;
				}
				int num2 = other.setItemID_;
				if (num2 != 0)
				{
					setItemID_ = num2;
				}
				bool flag = other.allowColoring_;
				if (flag)
				{
					allowColoring_ = flag;
				}
				bool flag2 = other.isHidden_;
				if (flag2)
				{
					isHidden_ = flag2;
				}
				RepeatedField<int> repeatedField = tags_;
				RepeatedField<int> repeatedField2 = other.tags_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RewardAppearanceCondition rewardAppearanceCondition = other.appearanceCondition_;
				if (rewardAppearanceCondition != 0)
				{
					appearanceCondition_ = rewardAppearanceCondition;
				}
				bool flag3 = other.isUnavailableForGenerator_;
				if (flag3)
				{
					isUnavailableForGenerator_ = flag3;
				}
				bool flag4 = other.isSyncOnlineItem_;
				if (flag4)
				{
					isSyncOnlineItem_ = flag4;
				}
				uint num3 = other.glotID_;
				if (num3 != 0)
				{
					glotID_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600217F")]
		[Cpp2IlInjected.Address(RVA = "0x356DC80", Offset = "0x356C680", VA = "0x18356DC80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_017c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 56)
			{
				if ((int)num > 74)
				{
					if ((int)num > 120)
					{
						if (num == 128)
						{
							bool flag = (isSyncOnlineItem_ = input.ReadBool());
						}
						if (num != 7992)
						{
							goto IL_0165;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					int num3 = default(int);
					if (num == 80)
					{
						num3 = (int)(appearanceCondition_ = (RewardAppearanceCondition)input.ReadInt32());
					}
					if (num3 != 120)
					{
						goto IL_0165;
					}
					bool flag2 = (isUnavailableForGenerator_ = input.ReadBool());
				}
				bool flag3 = default(bool);
				if (num == 64)
				{
					flag3 = (isHidden_ = input.ReadBool());
				}
				if (!flag3)
				{
					goto IL_0165;
				}
				RepeatedField<int> repeatedField = tags_;
				FieldCodec<int> repeated_tags_codec = _repeated_tags_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tags_codec);
			}
			string text4 = default(string);
			if ((int)num > 26)
			{
				bool flag4 = default(bool);
				if ((int)num > 42)
				{
					int num4 = default(int);
					if (num == 48)
					{
						num4 = (setItemID_ = input.ReadInt32());
					}
					if (num4 != 56)
					{
						goto IL_0165;
					}
					flag4 = (allowColoring_ = input.ReadBool());
				}
				string text2 = default(string);
				if (flag4)
				{
					text2 = (IconAddress = input.ReadString());
				}
				if ((long)text2 != 42)
				{
					goto IL_0165;
				}
				text4 = (PrefabAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text4 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num5 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_0165;
			IL_0165:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002180")]
		[Cpp2IlInjected.Address(RVA = "0x356D710", Offset = "0x356C110", VA = "0x18356D710", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 15)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002181")]
		[Cpp2IlInjected.Address(RVA = "0x356DEE0", Offset = "0x356C8E0", VA = "0x18356DEE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0029, IL_0031, IL_0039, IL_0041, IL_0049, IL_0051, IL_0069, IL_006f, IL_0075, IL_007b, IL_0081, IL_0087
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0068: Expected I4, but got O
			if (fieldNumber - 1 <= 15)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002182")]
		[Cpp2IlInjected.Address(RVA = "0x356D0D0", Offset = "0x356BAD0", VA = "0x18356D0D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_002f
			//IL_0010: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			if (fieldNumber - 1 <= 15)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002186")]
		[Cpp2IlInjected.Address(RVA = "0x356CF90", Offset = "0x356B990", VA = "0x18356CF90")]
		public bool CanBeGiven(in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] RewardGenerationParameters parameters)
		{
			IProfilePlayer section = playerProfile.Section;
			int num = iD_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			if (section == null)
			{
				if (appearanceCondition_ == RewardAppearanceCondition.Anywhere)
				{
					num += num;
				}
				if (section == null)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002187")]
		[Cpp2IlInjected.Address(RVA = "0x356D430", Offset = "0x356BE30", VA = "0x18356D430", Slot = "28")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_000a: Expected I4, but got I8
			appearanceCondition_ = RewardAppearanceCondition.Custom;
		}

		[Cpp2IlInjected.Token(Token = "0x6002188")]
		[Cpp2IlInjected.Address(RVA = "0x356D290", Offset = "0x356BC90", VA = "0x18356D290", Slot = "20")]
		IItemData IItemData.Clone()
		{
			DecalItemData decalItemData = new DecalItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002189")]
		[Cpp2IlInjected.Address(RVA = "0x356E680", Offset = "0x356D080", VA = "0x18356E680")]
		static DecalItemData()
		{
			//Discarded unreachable code: IL_003f
			//IL_002b: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			Func<DecalItemData> func = default(Func<DecalItemData>);
			_parser = (MessageParser<DecalItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<DecalItemData>)(object)FieldCodec.ForInt32(74u);
			(TagItemType, int?)[] array = new(TagItemType, int?)[2];
			int num = 0;
			((ValueTuple<, >[])(object)array)[1] = (ValueTuple<, >)num;
			int num2 = 0;
			((ValueTuple<, >[])(object)array)[2] = (ValueTuple<, >)num2;
			ReadOnlyCollection<(TagItemType, int?)> parser = default(ReadOnlyCollection<(TagItemType, int?)>);
			_parser = (MessageParser<DecalItemData>)(object)parser;
		}

		[Cpp2IlInjected.Token(Token = "0x600218A")]
		[Cpp2IlInjected.Address(RVA = "0x356D2F0", Offset = "0x356BCF0", VA = "0x18356D2F0", Slot = "27")]
		bool IRewardGenerationCondition.CanBeGiven(in PlayerProfile playerProfile, in WorldProfile worldProfile, RewardGenerationParameters parameters)
		{
			IProfilePlayer section = playerProfile.Section;
			int num = iD_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			if (section == null)
			{
				if (appearanceCondition_ == RewardAppearanceCondition.Anywhere)
				{
					num += num;
				}
				if (section == null)
				{
				}
			}
			throw new NullReferenceException();
		}
	}
}
