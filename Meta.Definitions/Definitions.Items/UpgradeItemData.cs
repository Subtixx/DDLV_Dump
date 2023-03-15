using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002FF")]
	public sealed class UpgradeItemData : IMessage<UpgradeItemData>, IMessage, IEquatable<UpgradeItemData>, IDeepCloneable<UpgradeItemData>, IMessageFieldAccessor, IItemData, IHasGlotID
	{
		[Cpp2IlInjected.Token(Token = "0x4000EB0")]
		private static readonly MessageParser<UpgradeItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000EB1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000EB2")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000EB3")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000EB4")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000EB5")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EB6")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000EB7")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EB8")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000EB9")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EBA")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000EBB")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000EBC")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000EBD")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x17000831")]
		[DebuggerNonUserCode]
		public static MessageParser<UpgradeItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60021F9")]
			[Cpp2IlInjected.Address(RVA = "0x17BF160", Offset = "0x17BDB60", VA = "0x1817BF160")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000832")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60021FA")]
			[Cpp2IlInjected.Address(RVA = "0x17BF030", Offset = "0x17BDA30", VA = "0x1817BF030")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000833")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60021FB")]
			[Cpp2IlInjected.Address(RVA = "0x17BF1C0", Offset = "0x17BDBC0", VA = "0x1817BF1C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000834")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60021FF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002200")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000835")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002201")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002202")]
			[Cpp2IlInjected.Address(RVA = "0x17BF3B0", Offset = "0x17BDDB0", VA = "0x1817BF3B0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000836")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002203")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002204")]
			[Cpp2IlInjected.Address(RVA = "0x17BF2D0", Offset = "0x17BDCD0", VA = "0x1817BF2D0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000837")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002205")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002206")]
			[Cpp2IlInjected.Address(RVA = "0x17BF340", Offset = "0x17BDD40", VA = "0x1817BF340")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000838")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002207")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002208")]
			[Cpp2IlInjected.Address(RVA = "0x17BF420", Offset = "0x17BDE20", VA = "0x1817BF420")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000839")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6002209")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600220A")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083A")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002216")]
			[Cpp2IlInjected.Address(RVA = "0x17BF100", Offset = "0x17BDB00", VA = "0x1817BF100", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021FC")]
		[Cpp2IlInjected.Address(RVA = "0x17BEE80", Offset = "0x17BD880", VA = "0x1817BEE80")]
		[DebuggerNonUserCode]
		public UpgradeItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60021FD")]
		[Cpp2IlInjected.Address(RVA = "0x17BEF00", Offset = "0x17BD900", VA = "0x1817BEF00")]
		[DebuggerNonUserCode]
		public UpgradeItemData(UpgradeItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			uint num2 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021FE")]
		[Cpp2IlInjected.Address(RVA = "0x17BE230", Offset = "0x17BCC30", VA = "0x1817BE230", Slot = "10")]
		[DebuggerNonUserCode]
		public UpgradeItemData Clone()
		{
			//Discarded unreachable code: IL_00a3
			UpgradeItemData upgradeItemData = new UpgradeItemData();
			upgradeItemData.name_ = "";
			upgradeItemData.displayName_ = "";
			upgradeItemData.iconAddress_ = "";
			upgradeItemData.prefabAddress_ = "";
			int num = (upgradeItemData.iD_ = iD_);
			string text = (upgradeItemData.name_ = name_);
			string text2 = (upgradeItemData.displayName_ = displayName_);
			string text3 = (upgradeItemData.iconAddress_ = iconAddress_);
			string text4 = (upgradeItemData.prefabAddress_ = prefabAddress_);
			uint num2 = (upgradeItemData.glotID_ = glotID_);
			UnknownFieldSet unknownFieldSet = (upgradeItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return upgradeItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x600220B")]
		[Cpp2IlInjected.Address(RVA = "0x17BE390", Offset = "0x17BCD90", VA = "0x1817BE390", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(UpgradeItemData).TypeHandle)
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
								if (!flag4 && glotID_ == (flag4 ? 1u : 0u))
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600220C")]
		[Cpp2IlInjected.Address(RVA = "0x17BE4A0", Offset = "0x17BCEA0", VA = "0x1817BE4A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UpgradeItemData other)
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
									uint num2 = other.glotID_;
									if (glotID_ == num2)
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
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600220D")]
		[Cpp2IlInjected.Address(RVA = "0x17BE690", Offset = "0x17BD090", VA = "0x1817BE690", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0092
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
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600220E")]
		[Cpp2IlInjected.Address(RVA = "0x17BEBB0", Offset = "0x17BD5B0", VA = "0x1817BEBB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600220F")]
		[Cpp2IlInjected.Address(RVA = "0x17BEC10", Offset = "0x17BD610", VA = "0x1817BEC10", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b9
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
			if (glotID_ != 0)
			{
				uint value6 = glotID_;
				output.WriteUInt32(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002210")]
		[Cpp2IlInjected.Address(RVA = "0x17BDF70", Offset = "0x17BC970", VA = "0x1817BDF70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00e8
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
			uint num8 = glotID_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeUInt32Size(num8);
				num9 += 2;
				num2 += num9;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				num2 += num10;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002211")]
		[Cpp2IlInjected.Address(RVA = "0x17BE7A0", Offset = "0x17BD1A0", VA = "0x1817BE7A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UpgradeItemData other)
		{
			//Discarded unreachable code: IL_00ae
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
				uint num2 = other.glotID_;
				if (num2 != 0)
				{
					glotID_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002212")]
		[Cpp2IlInjected.Address(RVA = "0x17BE870", Offset = "0x17BD270", VA = "0x1817BE870", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00af
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (IconAddress = input.ReadString());
				}
				string text4 = default(string);
				if (num == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 7992)
				{
					goto IL_0098;
				}
				int num2 = (int)(glotID_ = (uint)input.ReadInt32());
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num3 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_0098;
			IL_0098:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002213")]
		[Cpp2IlInjected.Address(RVA = "0x17BE560", Offset = "0x17BCF60", VA = "0x1817BE560", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (num != 1 && fieldNumber != 999)
							{
								goto IL_0045;
							}
							string text = prefabAddress_;
						}
						string text2 = iconAddress_;
					}
					string text3 = displayName_;
				}
				string text4 = name_;
			}
			int num2 = iD_;
			goto IL_0045;
			IL_0045:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002214")]
		[Cpp2IlInjected.Address(RVA = "0x17BE990", Offset = "0x17BD390", VA = "0x1817BE990", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0054
			//IL_0027: Expected I4, but got O
			//IL_0053: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						default:
							if (fieldNumber == 999)
							{
								object obj = default(object);
								glotID_ = (uint)(int)obj;
							}
							break;
						case 1:
							if (value == null || value != null)
							{
								break;
							}
							throw new InvalidCastException();
						case 0:
							if (value == null || value != null)
							{
								break;
							}
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
			else
			{
				object obj2 = default(object);
				iD_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002215")]
		[Cpp2IlInjected.Address(RVA = "0x17BE130", Offset = "0x17BCB30", VA = "0x1817BE130", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0029: Expected I4, but got I8
			//IL_0063: Expected I4, but got I8
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
							PrefabAddress = "";
							return;
						case 0:
							IconAddress = "";
							return;
						}
						if (fieldNumber == 999)
						{
							glotID_ = 0u;
						}
					}
					else
					{
						DisplayName = "";
					}
				}
				else
				{
					Name = "";
				}
			}
			else
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002217")]
		[Cpp2IlInjected.Address(RVA = "0x17BE230", Offset = "0x17BCC30", VA = "0x1817BE230", Slot = "20")]
		IItemData IItemData.Clone()
		{
			UpgradeItemData upgradeItemData = new UpgradeItemData();
			upgradeItemData.name_ = "";
			upgradeItemData.displayName_ = "";
			upgradeItemData.iconAddress_ = "";
			upgradeItemData.prefabAddress_ = "";
			int num = (upgradeItemData.iD_ = iD_);
			string text = (upgradeItemData.name_ = name_);
			string text2 = (upgradeItemData.displayName_ = displayName_);
			string text3 = (upgradeItemData.iconAddress_ = iconAddress_);
			string text4 = (upgradeItemData.prefabAddress_ = prefabAddress_);
			uint num2 = (upgradeItemData.glotID_ = glotID_);
			UnknownFieldSet unknownFieldSet = (upgradeItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002218")]
		[Cpp2IlInjected.Address(RVA = "0x17BED70", Offset = "0x17BD770", VA = "0x1817BED70")]
		static UpgradeItemData()
		{
			Func<UpgradeItemData> func = default(Func<UpgradeItemData>);
			_parser = (MessageParser<UpgradeItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
