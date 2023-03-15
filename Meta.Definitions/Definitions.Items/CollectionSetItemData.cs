using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005C7")]
	public sealed class CollectionSetItemData : IMessage<CollectionSetItemData>, IMessage, IEquatable<CollectionSetItemData>, IDeepCloneable<CollectionSetItemData>, IMessageFieldAccessor, IItemData, IItemGeneratorOwner, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001F88")]
		private static readonly MessageParser<CollectionSetItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F89")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F8A")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F8B")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001F8C")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F8D")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001F8E")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F8F")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001F90")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001F91")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001F92")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001F93")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001F94")]
		public const int SortPriorityFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001F95")]
		private int sortPriority_;

		[Cpp2IlInjected.Token(Token = "0x4001F96")]
		public const int CollectionNameFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001F97")]
		private string collectionName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001F98")]
		public const int SubmenuFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001F99")]
		private CollectionSubMenu submenu_;

		[Cpp2IlInjected.Token(Token = "0x4001F9A")]
		public const int GroupsFieldNumber = 9;

		[Cpp2IlInjected.Token(Token = "0x4001F9B")]
		private static readonly FieldCodec<CollectionGroup> _repeated_groups_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001F9C")]
		private readonly RepeatedField<CollectionGroup> groups_ = (RepeatedField<CollectionGroup>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001294")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionSetItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600480B")]
			[Cpp2IlInjected.Address(RVA = "0x320E1D0", Offset = "0x320CBD0", VA = "0x18320E1D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001295")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600480C")]
			[Cpp2IlInjected.Address(RVA = "0x320E100", Offset = "0x320CB00", VA = "0x18320E100")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001296")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600480D")]
			[Cpp2IlInjected.Address(RVA = "0x320E230", Offset = "0x320CC30", VA = "0x18320E230", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001297")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6004811")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004812")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001298")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004813")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004814")]
			[Cpp2IlInjected.Address(RVA = "0x320E490", Offset = "0x320CE90", VA = "0x18320E490")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001299")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6004815")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004816")]
			[Cpp2IlInjected.Address(RVA = "0x320E3B0", Offset = "0x320CDB0", VA = "0x18320E3B0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700129A")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004817")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004818")]
			[Cpp2IlInjected.Address(RVA = "0x320E420", Offset = "0x320CE20", VA = "0x18320E420")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700129B")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004819")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600481A")]
			[Cpp2IlInjected.Address(RVA = "0x320E500", Offset = "0x320CF00", VA = "0x18320E500")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700129C")]
		[DebuggerNonUserCode]
		public int SortPriority
		{
			[Cpp2IlInjected.Token(Token = "0x600481B")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return sortPriority_;
			}
			[Cpp2IlInjected.Token(Token = "0x600481C")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				sortPriority_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700129D")]
		[DebuggerNonUserCode]
		public string CollectionName
		{
			[Cpp2IlInjected.Token(Token = "0x600481D")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return collectionName_;
			}
			[Cpp2IlInjected.Token(Token = "0x600481E")]
			[Cpp2IlInjected.Address(RVA = "0x320E340", Offset = "0x320CD40", VA = "0x18320E340")]
			set
			{
				string text = (collectionName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700129E")]
		[DebuggerNonUserCode]
		public CollectionSubMenu Submenu
		{
			[Cpp2IlInjected.Token(Token = "0x600481F")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return submenu_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004820")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				submenu_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700129F")]
		[DebuggerNonUserCode]
		public RepeatedField<CollectionGroup> Groups
		{
			[Cpp2IlInjected.Token(Token = "0x6004821")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return groups_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012A0")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600482D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600480E")]
		[Cpp2IlInjected.Address(RVA = "0x320DE30", Offset = "0x320C830", VA = "0x18320DE30")]
		[DebuggerNonUserCode]
		public CollectionSetItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600480F")]
		[Cpp2IlInjected.Address(RVA = "0x320DF20", Offset = "0x320C920", VA = "0x18320DF20")]
		[DebuggerNonUserCode]
		public CollectionSetItemData(CollectionSetItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (sortPriority_ = other.sortPriority_);
			string text5 = (collectionName_ = other.collectionName_);
			CollectionSubMenu collectionSubMenu = (submenu_ = other.submenu_);
			RepeatedField<CollectionGroup> repeatedField = (groups_ = (RepeatedField<CollectionGroup>)(object)((RepeatedField<T>)(object)other.groups_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004810")]
		[Cpp2IlInjected.Address(RVA = "0x320CA90", Offset = "0x320B490", VA = "0x18320CA90", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionSetItemData Clone()
		{
			return new CollectionSetItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004822")]
		[Cpp2IlInjected.Address(RVA = "0x320CE30", Offset = "0x320B830", VA = "0x18320CE30", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(CollectionSetItemData).TypeHandle)
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
								if (!flag4 && sortPriority_ == (flag4 ? 1 : 0))
								{
									string text5 = collectionName_;
									bool flag5 = default(bool);
									if (!flag5 && submenu_ == (flag5 ? CollectionSubMenu.Fish : CollectionSubMenu.Crop))
									{
										RepeatedField<CollectionGroup> repeatedField = groups_;
										bool flag6 = default(bool);
										if (flag6)
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

		[Cpp2IlInjected.Token(Token = "0x6004823")]
		[Cpp2IlInjected.Address(RVA = "0x320CD10", Offset = "0x320B710", VA = "0x18320CD10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionSetItemData other)
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
									int num2 = other.sortPriority_;
									if (sortPriority_ == num2)
									{
										string text5 = other.collectionName_;
										if (!(collectionName_ != text5))
										{
											CollectionSubMenu collectionSubMenu = other.submenu_;
											if (submenu_ == collectionSubMenu)
											{
												RepeatedField<CollectionGroup> repeatedField = groups_;
												RepeatedField<CollectionGroup> repeatedField2 = other.groups_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004824")]
		[Cpp2IlInjected.Address(RVA = "0x320D110", Offset = "0x320BB10", VA = "0x18320D110", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00c2
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
			if (sortPriority_ != 0)
			{
			}
			string text5 = collectionName_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			if (submenu_ != 0)
			{
			}
			int hashCode6 = ((RepeatedField<T>)(object)groups_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004825")]
		[Cpp2IlInjected.Address(RVA = "0x320D9B0", Offset = "0x320C3B0", VA = "0x18320D9B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004826")]
		[Cpp2IlInjected.Address(RVA = "0x320DA10", Offset = "0x320C410", VA = "0x18320DA10", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00f8
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
			if (sortPriority_ != 0)
			{
				int value6 = sortPriority_;
				output.WriteInt32(value6);
			}
			if (collectionName_.m_stringLength != 0)
			{
				string value7 = collectionName_;
				output.WriteString(value7);
			}
			if (submenu_ != 0)
			{
			}
			RepeatedField<CollectionGroup> repeatedField = groups_;
			FieldCodec<CollectionGroup> repeated_groups_codec = _repeated_groups_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_groups_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004827")]
		[Cpp2IlInjected.Address(RVA = "0x320C690", Offset = "0x320B090", VA = "0x18320C690", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_014d
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
			int num8 = sortPriority_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			string text5 = collectionName_;
			if (text5.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text5);
				num10++;
				num2 += num10;
			}
			CollectionSubMenu collectionSubMenu = submenu_;
			if (collectionSubMenu != 0)
			{
				int num11 = CodedOutputStream.ComputeEnumSize((int)collectionSubMenu);
				num11++;
				num2 += num11;
			}
			RepeatedField<CollectionGroup> repeatedField = groups_;
			FieldCodec<CollectionGroup> repeated_groups_codec = _repeated_groups_codec;
			int num12 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_groups_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num12;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num2 += num13;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004828")]
		[Cpp2IlInjected.Address(RVA = "0x320D380", Offset = "0x320BD80", VA = "0x18320D380", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionSetItemData other)
		{
			//Discarded unreachable code: IL_00f5
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
				int num2 = other.sortPriority_;
				if (num2 != 0)
				{
					sortPriority_ = num2;
				}
				string text5 = other.collectionName_;
				if (text5.m_stringLength != 0)
				{
					CollectionName = text5;
				}
				CollectionSubMenu collectionSubMenu = other.submenu_;
				if (collectionSubMenu != 0)
				{
					submenu_ = collectionSubMenu;
				}
				RepeatedField<CollectionGroup> repeatedField = groups_;
				RepeatedField<CollectionGroup> repeatedField2 = other.groups_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004829")]
		[Cpp2IlInjected.Address(RVA = "0x320D4B0", Offset = "0x320BEB0", VA = "0x18320D4B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_010e
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 34)
			{
				if ((int)num > 48)
				{
					if (num == 58)
					{
						string text2 = (CollectionName = input.ReadString());
					}
					int num2 = default(int);
					if (num == 64)
					{
						num2 = (int)(submenu_ = (CollectionSubMenu)input.ReadInt32());
					}
					if (num2 != 74)
					{
						goto IL_00f7;
					}
					RepeatedField<CollectionGroup> repeatedField = groups_;
					FieldCodec<CollectionGroup> repeated_groups_codec = _repeated_groups_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_groups_codec);
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 48)
				{
					goto IL_00f7;
				}
				int num3 = (sortPriority_ = input.ReadInt32());
			}
			string text8 = default(string);
			if ((int)num > 18)
			{
				string text6 = default(string);
				if (num == 26)
				{
					text6 = (DisplayName = input.ReadString());
				}
				if ((long)text6 != 34)
				{
					goto IL_00f7;
				}
				text8 = (IconAddress = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text8 == 8)
			{
				num4 = (iD_ = input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_00f7;
			IL_00f7:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600482A")]
		[Cpp2IlInjected.Address(RVA = "0x320CFA0", Offset = "0x320B9A0", VA = "0x18320CFA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600482B")]
		[Cpp2IlInjected.Address(RVA = "0x320D6B0", Offset = "0x320C0B0", VA = "0x18320D6B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_001f, IL_0027, IL_0028, IL_0035, IL_003d, IL_004e, IL_0054, IL_005a, IL_0060, IL_0066, IL_006c
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 8)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600482C")]
		[Cpp2IlInjected.Address(RVA = "0x320C920", Offset = "0x320B320", VA = "0x18320C920", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 8)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600482E")]
		[Cpp2IlInjected.Address(RVA = "0x320CA90", Offset = "0x320B490", VA = "0x18320CA90", Slot = "20")]
		IItemData IItemData.Clone()
		{
			CollectionSetItemData collectionSetItemData = new CollectionSetItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600482F")]
		[Cpp2IlInjected.Address(RVA = "0x320D280", Offset = "0x320BC80", VA = "0x18320D280", Slot = "21")]
		public (ItemType, ActivityItemType?) GetItemGeneratorParameters()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004830")]
		[Cpp2IlInjected.Address(RVA = "0x320CAF0", Offset = "0x320B4F0", VA = "0x18320CAF0", Slot = "22")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004a, IL_0050, IL_0056, IL_005c
			//IL_0039: Expected O, but got I4
			bool flag = default(bool);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			uint num4 = default(uint);
			do
			{
				if (((RepeatedField<T>)(object)groups_).Count == 0)
				{
					context.AddError("Collection needs to contain at least one group.");
				}
				RepeatedField<CollectionGroup> repeatedField = groups_;
				if (flag)
				{
					while (num != 0)
					{
					}
					while (num2 != 0)
					{
					}
					string error = $"Group[{num3}].ItemList contain invalid item (deleted or never set)";
					context.AddError(error);
				}
			}
			while (num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6004831")]
		[Cpp2IlInjected.Address(RVA = "0x320DC60", Offset = "0x320C660", VA = "0x18320DC60")]
		static CollectionSetItemData()
		{
			Func<CollectionSetItemData> func = default(Func<CollectionSetItemData>);
			_parser = (MessageParser<CollectionSetItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<CollectionGroup> parser = CollectionGroup._parser;
			uint num = default(uint);
			_parser = (MessageParser<CollectionSetItemData>)(object)FieldCodec.ForMessage<CollectionGroup>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
