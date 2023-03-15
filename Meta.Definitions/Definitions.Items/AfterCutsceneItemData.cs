using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000314")]
	public sealed class AfterCutsceneItemData : IMessage<AfterCutsceneItemData>, IMessage, IEquatable<AfterCutsceneItemData>, IDeepCloneable<AfterCutsceneItemData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000F90")]
		private static readonly MessageParser<AfterCutsceneItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000F91")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000F92")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F93")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000F94")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F95")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F96")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F97")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F98")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F99")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F9A")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F9B")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000F9C")]
		public const int CutsceneIdFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F9D")]
		private string cutsceneId_ = "";

		[Cpp2IlInjected.Token(Token = "0x170008BD")]
		[DebuggerNonUserCode]
		public static MessageParser<AfterCutsceneItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60023A5")]
			[Cpp2IlInjected.Address(RVA = "0x315C660", Offset = "0x315B060", VA = "0x18315C660")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008BE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60023A6")]
			[Cpp2IlInjected.Address(RVA = "0x315C590", Offset = "0x315AF90", VA = "0x18315C590")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008BF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60023A7")]
			[Cpp2IlInjected.Address(RVA = "0x315C6C0", Offset = "0x315B0C0", VA = "0x18315C6C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C0")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60023AB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60023AC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C1")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60023AD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60023AE")]
			[Cpp2IlInjected.Address(RVA = "0x315C920", Offset = "0x315B320", VA = "0x18315C920")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C2")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60023AF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60023B0")]
			[Cpp2IlInjected.Address(RVA = "0x315C840", Offset = "0x315B240", VA = "0x18315C840")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C3")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60023B1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60023B2")]
			[Cpp2IlInjected.Address(RVA = "0x315C8B0", Offset = "0x315B2B0", VA = "0x18315C8B0")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C4")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60023B3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60023B4")]
			[Cpp2IlInjected.Address(RVA = "0x315C990", Offset = "0x315B390", VA = "0x18315C990")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008C5")]
		[DebuggerNonUserCode]
		public string CutsceneId
		{
			[Cpp2IlInjected.Token(Token = "0x60023B5")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return cutsceneId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60023B6")]
			[Cpp2IlInjected.Address(RVA = "0x315C7D0", Offset = "0x315B1D0", VA = "0x18315C7D0")]
			set
			{
				string text = (cutsceneId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023A8")]
		[Cpp2IlInjected.Address(RVA = "0x315C4F0", Offset = "0x315AEF0", VA = "0x18315C4F0")]
		[DebuggerNonUserCode]
		public AfterCutsceneItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60023A9")]
		[Cpp2IlInjected.Address(RVA = "0x315C3A0", Offset = "0x315ADA0", VA = "0x18315C3A0")]
		[DebuggerNonUserCode]
		public AfterCutsceneItemData(AfterCutsceneItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (cutsceneId_ = other.cutsceneId_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023AA")]
		[Cpp2IlInjected.Address(RVA = "0x315B6E0", Offset = "0x315A0E0", VA = "0x18315B6E0", Slot = "10")]
		[DebuggerNonUserCode]
		public AfterCutsceneItemData Clone()
		{
			//Discarded unreachable code: IL_00ae
			AfterCutsceneItemData afterCutsceneItemData = new AfterCutsceneItemData();
			afterCutsceneItemData.name_ = "";
			afterCutsceneItemData.displayName_ = "";
			afterCutsceneItemData.iconAddress_ = "";
			afterCutsceneItemData.prefabAddress_ = "";
			afterCutsceneItemData.cutsceneId_ = "";
			int num = (afterCutsceneItemData.iD_ = iD_);
			string text = (afterCutsceneItemData.name_ = name_);
			string text2 = (afterCutsceneItemData.displayName_ = displayName_);
			string text3 = (afterCutsceneItemData.iconAddress_ = iconAddress_);
			string text4 = (afterCutsceneItemData.prefabAddress_ = prefabAddress_);
			string text5 = (afterCutsceneItemData.cutsceneId_ = cutsceneId_);
			UnknownFieldSet unknownFieldSet = (afterCutsceneItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return afterCutsceneItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x60023B7")]
		[Cpp2IlInjected.Address(RVA = "0x315B930", Offset = "0x315A330", VA = "0x18315B930", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)iD_ == (IntPtr)typeof(AfterCutsceneItemData).TypeHandle)
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
								if (!flag4)
								{
									string text5 = cutsceneId_;
									bool flag5 = default(bool);
									if (!flag5)
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

		[Cpp2IlInjected.Token(Token = "0x60023B8")]
		[Cpp2IlInjected.Address(RVA = "0x315B860", Offset = "0x315A260", VA = "0x18315B860", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AfterCutsceneItemData other)
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
									string text5 = other.cutsceneId_;
									if (!(cutsceneId_ != text5))
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
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023B9")]
		[Cpp2IlInjected.Address(RVA = "0x315BB80", Offset = "0x315A580", VA = "0x18315BB80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00a1
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
			string text5 = cutsceneId_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60023BA")]
		[Cpp2IlInjected.Address(RVA = "0x315C0C0", Offset = "0x315AAC0", VA = "0x18315C0C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60023BB")]
		[Cpp2IlInjected.Address(RVA = "0x315C120", Offset = "0x315AB20", VA = "0x18315C120", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00bd
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
			if (cutsceneId_.m_stringLength != 0)
			{
				string value6 = cutsceneId_;
				output.WriteString(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60023BC")]
		[Cpp2IlInjected.Address(RVA = "0x315B400", Offset = "0x3159E00", VA = "0x18315B400", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00ec
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
			string text5 = cutsceneId_;
			if (text5.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text5);
				num8++;
				num2 += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num2 += num9;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60023BD")]
		[Cpp2IlInjected.Address(RVA = "0x315BCA0", Offset = "0x315A6A0", VA = "0x18315BCA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AfterCutsceneItemData other)
		{
			//Discarded unreachable code: IL_00b2
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
				string text5 = other.cutsceneId_;
				if (text5.m_stringLength != 0)
				{
					CutsceneId = text5;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023BE")]
		[Cpp2IlInjected.Address(RVA = "0x315BD80", Offset = "0x315A780", VA = "0x18315BD80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00ac
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
				if ((long)text4 != 50)
				{
					goto IL_0095;
				}
				string text6 = (CutsceneId = input.ReadString());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			string text8 = default(string);
			if (num2 == 18)
			{
				text8 = (Name = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (DisplayName = input.ReadString());
			}
			goto IL_0095;
			IL_0095:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60023BF")]
		[Cpp2IlInjected.Address(RVA = "0x315BA50", Offset = "0x315A450", VA = "0x18315BA50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				int num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023C0")]
		[Cpp2IlInjected.Address(RVA = "0x315BEB0", Offset = "0x315A8B0", VA = "0x18315BEB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0019, IL_001f, IL_0025, IL_002b
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023C1")]
		[Cpp2IlInjected.Address(RVA = "0x315B5D0", Offset = "0x3159FD0", VA = "0x18315B5D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 5)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023C2")]
		[Cpp2IlInjected.Address(RVA = "0x315C290", Offset = "0x315AC90", VA = "0x18315C290")]
		static AfterCutsceneItemData()
		{
			Func<AfterCutsceneItemData> func = default(Func<AfterCutsceneItemData>);
			_parser = (MessageParser<AfterCutsceneItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
