using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000307")]
	public sealed class CharacterSkinItemData : IMessage<CharacterSkinItemData>, IMessage, IEquatable<CharacterSkinItemData>, IDeepCloneable<CharacterSkinItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IProtobufDefaultData, IIsOnlineOnly, IOnlineAvailability, IAvailability
	{
		[Cpp2IlInjected.Token(Token = "0x2000308")]
		public enum ActivationMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000F2F")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000F30")]
			Hidden,
			[Cpp2IlInjected.Token(Token = "0x4000F31")]
			Conditions
		}

		[Cpp2IlInjected.Token(Token = "0x4000F12")]
		private static readonly MessageParser<CharacterSkinItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F13")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000F14")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F15")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000F16")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F17")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F18")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F19")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F1A")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F1B")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F1C")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F1D")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F1E")]
		public const int CharacterItemIDFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F1F")]
		private int characterItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000F20")]
		public const int ConditionsFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F21")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x4000F22")]
		public const int CanHangoutWithPlayerFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000F23")]
		private bool canHangoutWithPlayer_;

		[Cpp2IlInjected.Token(Token = "0x4000F24")]
		public const int IsHiddenFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000F25")]
		private bool isHidden_;

		[Cpp2IlInjected.Token(Token = "0x4000F26")]
		public const int IsUnavailableForGeneratorFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
		[Cpp2IlInjected.Token(Token = "0x4000F27")]
		private bool isUnavailableForGenerator_;

		[Cpp2IlInjected.Token(Token = "0x4000F28")]
		public const int IsSyncOnlineItemFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x53")]
		[Cpp2IlInjected.Token(Token = "0x4000F29")]
		private bool isSyncOnlineItem_;

		[Cpp2IlInjected.Token(Token = "0x4000F2A")]
		public const int IsOnlineOnlyFieldNumber = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000F2B")]
		private bool isOnlineOnly_;

		[Cpp2IlInjected.Token(Token = "0x4000F2C")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000F2D")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x1700086F")]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterSkinItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60022AF")]
			[Cpp2IlInjected.Address(RVA = "0x28A3FE0", Offset = "0x28A29E0", VA = "0x1828A3FE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000870")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60022B0")]
			[Cpp2IlInjected.Address(RVA = "0x28A3EA0", Offset = "0x28A28A0", VA = "0x1828A3EA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000871")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60022B1")]
			[Cpp2IlInjected.Address(RVA = "0x28A4040", Offset = "0x28A2A40", VA = "0x1828A4040", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000872")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60022B6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022B7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000873")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60022B8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022B9")]
			[Cpp2IlInjected.Address(RVA = "0x28A4240", Offset = "0x28A2C40", VA = "0x1828A4240")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000874")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60022BA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022BB")]
			[Cpp2IlInjected.Address(RVA = "0x28A4150", Offset = "0x28A2B50", VA = "0x1828A4150")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000875")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60022BC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022BD")]
			[Cpp2IlInjected.Address(RVA = "0x28A41C0", Offset = "0x28A2BC0", VA = "0x1828A41C0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000876")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60022BE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022BF")]
			[Cpp2IlInjected.Address(RVA = "0x28A42B0", Offset = "0x28A2CB0", VA = "0x1828A42B0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000877")]
		[DebuggerNonUserCode]
		public int CharacterItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60022C0")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return characterItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022C1")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				characterItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000878")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x60022C2")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022C3")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000879")]
		[DebuggerNonUserCode]
		public bool CanHangoutWithPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60022C4")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return canHangoutWithPlayer_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022C5")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				canHangoutWithPlayer_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700087A")]
		[DebuggerNonUserCode]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x60022C6")]
			[Cpp2IlInjected.Address(RVA = "0xFAD850", Offset = "0xFAC250", VA = "0x180FAD850")]
			get
			{
				return isHidden_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022C7")]
			[Cpp2IlInjected.Address(RVA = "0x2191C60", Offset = "0x2190660", VA = "0x182191C60")]
			set
			{
				isHidden_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700087B")]
		[DebuggerNonUserCode]
		public bool IsUnavailableForGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x60022C8")]
			[Cpp2IlInjected.Address(RVA = "0x270A590", Offset = "0x2708F90", VA = "0x18270A590", Slot = "27")]
			get
			{
				return isUnavailableForGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022C9")]
			[Cpp2IlInjected.Address(RVA = "0x270A5A0", Offset = "0x2708FA0", VA = "0x18270A5A0", Slot = "28")]
			set
			{
				isUnavailableForGenerator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700087C")]
		[DebuggerNonUserCode]
		public bool IsSyncOnlineItem
		{
			[Cpp2IlInjected.Token(Token = "0x60022CA")]
			[Cpp2IlInjected.Address(RVA = "0x28A3F70", Offset = "0x28A2970", VA = "0x1828A3F70", Slot = "25")]
			get
			{
				return isSyncOnlineItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022CB")]
			[Cpp2IlInjected.Address(RVA = "0x28A4230", Offset = "0x28A2C30", VA = "0x1828A4230", Slot = "26")]
			set
			{
				isSyncOnlineItem_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700087D")]
		[DebuggerNonUserCode]
		public bool IsOnlineOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60022CC")]
			[Cpp2IlInjected.Address(RVA = "0x1781430", Offset = "0x177FE30", VA = "0x181781430", Slot = "24")]
			get
			{
				return isOnlineOnly_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022CD")]
			[Cpp2IlInjected.Address(RVA = "0x1781A50", Offset = "0x1780450", VA = "0x181781A50")]
			set
			{
				isOnlineOnly_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700087E")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60022CE")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60022CF")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700087F")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60022DB")]
			[Cpp2IlInjected.Address(RVA = "0x28A3F80", Offset = "0x28A2980", VA = "0x1828A3F80", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000880")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x60022DC")]
			[Cpp2IlInjected.Address(RVA = "0x28A3E40", Offset = "0x28A2840", VA = "0x1828A3E40")]
			get
			{
				long num = Convert.ToInt64((uint)characterItemID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000881")]
		public ActivationMode ActivatedBy
		{
			[Cpp2IlInjected.Token(Token = "0x60022DD")]
			[Cpp2IlInjected.Address(RVA = "0x28A3E00", Offset = "0x28A2800", VA = "0x1828A3E00")]
			get
			{
				//Discarded unreachable code: IL_0019
				if (!isHidden_)
				{
					bool isEmpty = conditions_.IsEmpty;
					int num = 0;
				}
				return ActivationMode.Hidden;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022B2")]
		[Cpp2IlInjected.Address(RVA = "0x28A3D30", Offset = "0x28A2730", VA = "0x1828A3D30")]
		[DebuggerNonUserCode]
		public CharacterSkinItemData()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022B3")]
		[Cpp2IlInjected.Address(RVA = "0x28A32B0", Offset = "0x28A1CB0", VA = "0x1828A32B0")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022B4")]
		[Cpp2IlInjected.Address(RVA = "0x28A3B70", Offset = "0x28A2570", VA = "0x1828A3B70")]
		[DebuggerNonUserCode]
		public CharacterSkinItemData(CharacterSkinItemData other)
		{
			//IL_00ba: Expected O, but got I4
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (characterItemID_ = other.characterItemID_);
			ConditionsList conditionsList2 = other.conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num3 = 0;
			conditions_ = (ConditionsList)num3;
			bool flag = (canHangoutWithPlayer_ = other.canHangoutWithPlayer_);
			bool flag2 = (isHidden_ = other.isHidden_);
			bool flag3 = (isUnavailableForGenerator_ = other.isUnavailableForGenerator_);
			bool flag4 = (isSyncOnlineItem_ = other.isSyncOnlineItem_);
			bool flag5 = (isOnlineOnly_ = other.isOnlineOnly_);
			uint num4 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022B5")]
		[Cpp2IlInjected.Address(RVA = "0x28A27E0", Offset = "0x28A11E0", VA = "0x1828A27E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CharacterSkinItemData Clone()
		{
			return new CharacterSkinItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60022D0")]
		[Cpp2IlInjected.Address(RVA = "0x28A2950", Offset = "0x28A1350", VA = "0x1828A2950", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(CharacterSkinItemData).TypeHandle)
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
								if (!flag4 && characterItemID_ == (flag4 ? 1 : 0))
								{
									bool flag5 = object.Equals(conditions_, other);
									if (flag5 && canHangoutWithPlayer_ == flag5 && isHidden_ == flag5 && isUnavailableForGenerator_ == flag5 && isSyncOnlineItem_ == flag5 && isOnlineOnly_ == flag5 && glotID_ == (flag5 ? 1u : 0u))
									{
										return object.Equals(_unknownFields, other);
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

		[Cpp2IlInjected.Token(Token = "0x60022D1")]
		[Cpp2IlInjected.Address(RVA = "0x28A2840", Offset = "0x28A1240", VA = "0x1828A2840", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CharacterSkinItemData other)
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
									int num2 = other.characterItemID_;
									if (characterItemID_ == num2)
									{
										ConditionsList objB = other.conditions_;
										if (object.Equals(conditions_, objB))
										{
											bool flag = other.canHangoutWithPlayer_;
											if (canHangoutWithPlayer_ == flag)
											{
												bool flag2 = other.isHidden_;
												if (isHidden_ == flag2)
												{
													bool flag3 = other.isUnavailableForGenerator_;
													if (isUnavailableForGenerator_ == flag3)
													{
														bool flag4 = other.isSyncOnlineItem_;
														if (isSyncOnlineItem_ == flag4)
														{
															bool flag5 = other.isOnlineOnly_;
															if (isOnlineOnly_ == flag5)
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
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022D2")]
		[Cpp2IlInjected.Address(RVA = "0x28A2D00", Offset = "0x28A1700", VA = "0x1828A2D00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00de
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
			if (characterItemID_ != 0)
			{
			}
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int hashCode5 = conditionsList.GetHashCode();
			}
			if (canHangoutWithPlayer_)
			{
			}
			if (isHidden_)
			{
			}
			if (isUnavailableForGenerator_)
			{
			}
			if (isSyncOnlineItem_)
			{
			}
			if (isOnlineOnly_)
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

		[Cpp2IlInjected.Token(Token = "0x60022D3")]
		[Cpp2IlInjected.Address(RVA = "0x28A3760", Offset = "0x28A2160", VA = "0x1828A3760", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60022D4")]
		[Cpp2IlInjected.Address(RVA = "0x28A37C0", Offset = "0x28A21C0", VA = "0x1828A37C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_016a
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
			if (characterItemID_ != 0)
			{
				int value6 = characterItemID_;
				output.WriteInt32(value6);
			}
			if ((long)conditions_ != 0)
			{
				ConditionsList value7 = conditions_;
				output.WriteMessage(value7);
			}
			if (canHangoutWithPlayer_)
			{
				bool value8 = canHangoutWithPlayer_;
				output.WriteBool(value8);
			}
			if (isHidden_)
			{
				bool value9 = isHidden_;
				output.WriteBool(value9);
			}
			if (isUnavailableForGenerator_)
			{
				bool value10 = isUnavailableForGenerator_;
				output.WriteBool(value10);
			}
			if (isSyncOnlineItem_)
			{
				bool value11 = isSyncOnlineItem_;
				output.WriteBool(value11);
			}
			if (isOnlineOnly_)
			{
				bool value12 = isOnlineOnly_;
				output.WriteBool(value12);
			}
			if (glotID_ != 0)
			{
				uint value13 = glotID_;
				output.WriteUInt32(value13);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60022D5")]
		[Cpp2IlInjected.Address(RVA = "0x28A23D0", Offset = "0x28A0DD0", VA = "0x1828A23D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_012a
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
			int num8 = characterItemID_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num10++;
				num2 += num10;
			}
			uint num11 = glotID_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeUInt32Size(num11);
				num12 += 2;
				num2 += num12;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num2 += num13;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60022D6")]
		[Cpp2IlInjected.Address(RVA = "0x28A3110", Offset = "0x28A1B10", VA = "0x1828A3110", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterSkinItemData other)
		{
			//Discarded unreachable code: IL_0168
			if (other == null)
			{
				return;
			}
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
			int num2 = other.characterItemID_;
			if (num2 != 0)
			{
				characterItemID_ = num2;
			}
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (conditions_ == null)
				{
					ConditionsList conditionsList = (conditions_ = new ConditionsList());
					conditionsList2 = conditions_;
				}
				ConditionsList other2 = other.conditions_;
				conditionsList2.MergeFrom(other2);
			}
			bool flag = other.canHangoutWithPlayer_;
			if (flag)
			{
				canHangoutWithPlayer_ = flag;
			}
			bool flag2 = other.isHidden_;
			if (flag2)
			{
				isHidden_ = flag2;
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
			bool flag5 = other.isOnlineOnly_;
			if (flag5)
			{
				isOnlineOnly_ = flag5;
			}
			uint num3 = other.glotID_;
			if (num3 != 0)
			{
				glotID_ = num3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60022D7")]
		[Cpp2IlInjected.Address(RVA = "0x28A2ED0", Offset = "0x28A18D0", VA = "0x1828A2ED0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0187
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 48)
			{
				if ((int)num > 72)
				{
					if ((int)num > 128)
					{
						if (num == 800)
						{
							bool flag = (isOnlineOnly_ = input.ReadBool());
						}
						if (num != 7992)
						{
							goto IL_0170;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					bool flag2 = default(bool);
					if (num == 120)
					{
						flag2 = (isUnavailableForGenerator_ = input.ReadBool());
					}
					if (!flag2)
					{
						goto IL_0170;
					}
					bool flag3 = (isSyncOnlineItem_ = input.ReadBool());
				}
				ConditionsList conditionsList = default(ConditionsList);
				if (num == 58)
				{
					ConditionsList builder = default(ConditionsList);
					if (conditions_ == null)
					{
						conditionsList = (conditions_ = new ConditionsList());
						builder = conditions_;
					}
					input.ReadMessage(builder);
				}
				bool flag4 = default(bool);
				if ((long)conditionsList == 64)
				{
					flag4 = (canHangoutWithPlayer_ = input.ReadBool());
				}
				if (!flag4)
				{
					goto IL_0170;
				}
				bool flag5 = (isHidden_ = input.ReadBool());
			}
			int num3 = default(int);
			if ((int)num > 26)
			{
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 48)
				{
					goto IL_0170;
				}
				num3 = (characterItemID_ = input.ReadInt32());
			}
			int num4 = default(int);
			if (num3 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num4 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_0170;
			IL_0170:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60022D8")]
		[Cpp2IlInjected.Address(RVA = "0x28A2AB0", Offset = "0x28A14B0", VA = "0x1828A2AB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 15)
			{
				int num = iD_;
			}
			if (fieldNumber == 100)
			{
				bool flag = isOnlineOnly_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022D9")]
		[Cpp2IlInjected.Address(RVA = "0x28A3310", Offset = "0x28A1D10", VA = "0x1828A3310", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_0029, IL_0031, IL_0040, IL_0048, IL_0050, IL_006d, IL_0073, IL_0079, IL_007f, IL_0085, IL_008b, IL_0091, IL_0097
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			//IL_0064: Expected I4, but got O
			//IL_006c: Expected I4, but got O
			if (fieldNumber - 1 <= 15)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
			else if (fieldNumber == 100)
			{
				object obj2 = default(object);
				isOnlineOnly_ = (byte)(int)obj2 != 0;
			}
			else
			{
				object obj3 = default(object);
				glotID_ = (uint)(int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022DA")]
		[Cpp2IlInjected.Address(RVA = "0x28A2630", Offset = "0x28A1030", VA = "0x1828A2630", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 15)
			{
				iD_ = 0;
				return;
			}
			switch (fieldNumber)
			{
			case 100:
				isOnlineOnly_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60022DE")]
		[Cpp2IlInjected.Address(RVA = "0x28A27E0", Offset = "0x28A11E0", VA = "0x1828A27E0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			CharacterSkinItemData characterSkinItemData = new CharacterSkinItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60022DF")]
		[Cpp2IlInjected.Address(RVA = "0x5B9FB0", Offset = "0x5B89B0", VA = "0x1805B9FB0", Slot = "23")]
		void IProtobufDefaultData.SetDefaultData()
		{
			canHangoutWithPlayer_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60022E0")]
		[Cpp2IlInjected.Address(RVA = "0x28A3A60", Offset = "0x28A2460", VA = "0x1828A3A60")]
		static CharacterSkinItemData()
		{
			Func<CharacterSkinItemData> func = default(Func<CharacterSkinItemData>);
			_parser = (MessageParser<CharacterSkinItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
