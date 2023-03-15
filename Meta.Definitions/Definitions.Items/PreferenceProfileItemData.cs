using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000342")]
	public sealed class PreferenceProfileItemData : IMessage<PreferenceProfileItemData>, IMessage, IEquatable<PreferenceProfileItemData>, IDeepCloneable<PreferenceProfileItemData>, IMessageFieldAccessor, IItemData, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x40010AA")]
		private static readonly MessageParser<PreferenceProfileItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40010AB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40010AC")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010AD")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x40010AE")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40010AF")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x40010B0")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40010B1")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40010B2")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40010B3")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40010B4")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40010B5")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40010B6")]
		public const int SlotsFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x40010B7")]
		private static readonly FieldCodec<int> _repeated_slots_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40010B8")]
		private readonly RepeatedField<int> slots_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40010B9")]
		public const int NumberOfSlotsPerProfile = 3;

		[Cpp2IlInjected.Token(Token = "0x1700095D")]
		[DebuggerNonUserCode]
		public static MessageParser<PreferenceProfileItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60025FB")]
			[Cpp2IlInjected.Address(RVA = "0x287EA60", Offset = "0x287D460", VA = "0x18287EA60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700095E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60025FC")]
			[Cpp2IlInjected.Address(RVA = "0x287E990", Offset = "0x287D390", VA = "0x18287E990")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700095F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60025FD")]
			[Cpp2IlInjected.Address(RVA = "0x287EAC0", Offset = "0x287D4C0", VA = "0x18287EAC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000960")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002601")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002602")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000961")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002603")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002604")]
			[Cpp2IlInjected.Address(RVA = "0x287ECB0", Offset = "0x287D6B0", VA = "0x18287ECB0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000962")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002605")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002606")]
			[Cpp2IlInjected.Address(RVA = "0x287EBD0", Offset = "0x287D5D0", VA = "0x18287EBD0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000963")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002607")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002608")]
			[Cpp2IlInjected.Address(RVA = "0x287EC40", Offset = "0x287D640", VA = "0x18287EC40")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000964")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002609")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600260A")]
			[Cpp2IlInjected.Address(RVA = "0x287ED20", Offset = "0x287D720", VA = "0x18287ED20")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000965")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Slots
		{
			[Cpp2IlInjected.Token(Token = "0x600260B")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return slots_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000966")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002617")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025FE")]
		[Cpp2IlInjected.Address(RVA = "0x287E8C0", Offset = "0x287D2C0", VA = "0x18287E8C0")]
		[DebuggerNonUserCode]
		public PreferenceProfileItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60025FF")]
		[Cpp2IlInjected.Address(RVA = "0x287E710", Offset = "0x287D110", VA = "0x18287E710")]
		[DebuggerNonUserCode]
		public PreferenceProfileItemData(PreferenceProfileItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			RepeatedField<int> repeatedField = (slots_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.slots_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002600")]
		[Cpp2IlInjected.Address(RVA = "0x287D800", Offset = "0x287C200", VA = "0x18287D800", Slot = "10")]
		[DebuggerNonUserCode]
		public PreferenceProfileItemData Clone()
		{
			//Discarded unreachable code: IL_00b7
			PreferenceProfileItemData preferenceProfileItemData = new PreferenceProfileItemData();
			preferenceProfileItemData.name_ = "";
			preferenceProfileItemData.displayName_ = "";
			preferenceProfileItemData.iconAddress_ = "";
			preferenceProfileItemData.prefabAddress_ = "";
			RepeatedField<int> repeatedField = (preferenceProfileItemData.slots_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			int num = (preferenceProfileItemData.iD_ = iD_);
			string text = (preferenceProfileItemData.name_ = name_);
			string text2 = (preferenceProfileItemData.displayName_ = displayName_);
			string text3 = (preferenceProfileItemData.iconAddress_ = iconAddress_);
			string text4 = (preferenceProfileItemData.prefabAddress_ = prefabAddress_);
			RepeatedField<int> repeatedField2 = (preferenceProfileItemData.slots_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)slots_).Clone());
			UnknownFieldSet unknownFieldSet = (preferenceProfileItemData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return preferenceProfileItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x600260C")]
		[Cpp2IlInjected.Address(RVA = "0x287DB50", Offset = "0x287C550", VA = "0x18287DB50", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(PreferenceProfileItemData).TypeHandle)
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
									RepeatedField<int> repeatedField = slots_;
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

		[Cpp2IlInjected.Token(Token = "0x600260D")]
		[Cpp2IlInjected.Address(RVA = "0x287DA50", Offset = "0x287C450", VA = "0x18287DA50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PreferenceProfileItemData other)
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
									RepeatedField<int> repeatedField = slots_;
									RepeatedField<int> repeatedField2 = other.slots_;
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600260E")]
		[Cpp2IlInjected.Address(RVA = "0x287DDC0", Offset = "0x287C7C0", VA = "0x18287DDC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0093
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
			int hashCode5 = ((RepeatedField<T>)(object)slots_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600260F")]
		[Cpp2IlInjected.Address(RVA = "0x287E3A0", Offset = "0x287CDA0", VA = "0x18287E3A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002610")]
		[Cpp2IlInjected.Address(RVA = "0x287E400", Offset = "0x287CE00", VA = "0x18287E400", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b8
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
			RepeatedField<int> repeatedField = slots_;
			FieldCodec<int> repeated_slots_codec = _repeated_slots_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_slots_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002611")]
		[Cpp2IlInjected.Address(RVA = "0x287D4F0", Offset = "0x287BEF0", VA = "0x18287D4F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00e5
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
			RepeatedField<int> repeatedField = slots_;
			FieldCodec<int> repeated_slots_codec = _repeated_slots_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_slots_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num8;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num2 += num9;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002612")]
		[Cpp2IlInjected.Address(RVA = "0x287E080", Offset = "0x287CA80", VA = "0x18287E080", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PreferenceProfileItemData other)
		{
			//Discarded unreachable code: IL_00b1
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
				RepeatedField<int> repeatedField = slots_;
				RepeatedField<int> repeatedField2 = other.slots_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002613")]
		[Cpp2IlInjected.Address(RVA = "0x287DED0", Offset = "0x287C8D0", VA = "0x18287DED0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c4
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 42)
				{
					num += 4294967248u;
					if (num != 4294967293u)
					{
						goto IL_00ad;
					}
					RepeatedField<int> repeatedField = slots_;
					FieldCodec<int> repeated_slots_codec = _repeated_slots_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_slots_codec);
				}
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				if ((long)text2 != 42)
				{
					goto IL_00ad;
				}
				string text4 = (PrefabAddress = input.ReadString());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num2 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_00ad;
			IL_00ad:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002614")]
		[Cpp2IlInjected.Address(RVA = "0x287DC90", Offset = "0x287C690", VA = "0x18287DC90", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6002615")]
		[Cpp2IlInjected.Address(RVA = "0x287E180", Offset = "0x287CB80", VA = "0x18287E180", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0023, IL_0029, IL_002f
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002616")]
		[Cpp2IlInjected.Address(RVA = "0x287D6E0", Offset = "0x287C0E0", VA = "0x18287D6E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0016
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 5)
			{
				iD_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002618")]
		[Cpp2IlInjected.Address(RVA = "0x287D9E0", Offset = "0x287C3E0", VA = "0x18287D9E0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			PreferenceProfileItemData preferenceProfileItemData = Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002619")]
		[Cpp2IlInjected.Address(RVA = "0x287D9F0", Offset = "0x287C3F0", VA = "0x18287D9F0", Slot = "21")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//Discarded unreachable code: IL_0017
			//IL_0012: Expected O, but got I4
			int num = 0;
			RepeatedField<int> repeatedField = slots_;
			int num2 = 0;
			((RepeatedField<T>)(object)repeatedField).Add((T)num2);
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x600261A")]
		[Cpp2IlInjected.Address(RVA = "0x287E5D0", Offset = "0x287CFD0", VA = "0x18287E5D0")]
		static PreferenceProfileItemData()
		{
			Func<PreferenceProfileItemData> func = default(Func<PreferenceProfileItemData>);
			_parser = (MessageParser<PreferenceProfileItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<PreferenceProfileItemData>)(object)FieldCodec.ForInt32(50u);
			/*Error: Unexpected end of block*/;
		}
	}
}
