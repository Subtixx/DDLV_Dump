using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000297")]
	public sealed class ItemListDefinition : IMessage<ItemListDefinition>, IMessage, IEquatable<ItemListDefinition>, IDeepCloneable<ItemListDefinition>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000A51")]
		private static readonly MessageParser<ItemListDefinition> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000A52")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000A53")]
		public const int NameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A54")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000A55")]
		public const int PreviousNamesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000A56")]
		private static readonly FieldCodec<string> _repeated_previousNames_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A57")]
		private readonly RepeatedField<string> previousNames_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000A58")]
		public const int DeletedFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000A59")]
		private bool deleted_;

		[Cpp2IlInjected.Token(Token = "0x4000A5A")]
		public const int ItemDataFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000A5B")]
		private ByteString itemData_;

		[Cpp2IlInjected.Token(Token = "0x1700056E")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemListDefinition> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60019CE")]
			[Cpp2IlInjected.Address(RVA = "0x25E0180", Offset = "0x25DEB80", VA = "0x1825E0180")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60019CF")]
			[Cpp2IlInjected.Address(RVA = "0x25E00B0", Offset = "0x25DEAB0", VA = "0x1825E00B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000570")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60019D0")]
			[Cpp2IlInjected.Address(RVA = "0x25E01E0", Offset = "0x25DEBE0", VA = "0x1825E01E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000571")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60019D4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019D5")]
			[Cpp2IlInjected.Address(RVA = "0x25E0360", Offset = "0x25DED60", VA = "0x1825E0360")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000572")]
		[DebuggerNonUserCode]
		public RepeatedField<string> PreviousNames
		{
			[Cpp2IlInjected.Token(Token = "0x60019D6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return previousNames_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000573")]
		[DebuggerNonUserCode]
		public bool Deleted
		{
			[Cpp2IlInjected.Token(Token = "0x60019D7")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return deleted_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019D8")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				deleted_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000574")]
		[DebuggerNonUserCode]
		public ByteString ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60019D9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return itemData_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019DA")]
			[Cpp2IlInjected.Address(RVA = "0x25E02F0", Offset = "0x25DECF0", VA = "0x1825E02F0")]
			set
			{
				ByteString byteString = (itemData_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019D1")]
		[Cpp2IlInjected.Address(RVA = "0x25DFFD0", Offset = "0x25DE9D0", VA = "0x1825DFFD0")]
		[DebuggerNonUserCode]
		public ItemListDefinition()
		{
			int num = 0;
			itemData_ = ByteString.Empty;
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60019D2")]
		[Cpp2IlInjected.Address(RVA = "0x25DFE40", Offset = "0x25DE840", VA = "0x1825DFE40")]
		[DebuggerNonUserCode]
		public ItemListDefinition(ItemListDefinition other)
		{
			int num = 0;
			itemData_ = ByteString.Empty;
			base._002Ector();
			string text = (name_ = other.name_);
			RepeatedField<string> repeatedField = (previousNames_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.previousNames_).Clone());
			bool flag = (deleted_ = other.deleted_);
			ByteString byteString = (itemData_ = other.itemData_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019D3")]
		[Cpp2IlInjected.Address(RVA = "0x25DF1B0", Offset = "0x25DDBB0", VA = "0x1825DF1B0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemListDefinition Clone()
		{
			//Discarded unreachable code: IL_0089
			ItemListDefinition itemListDefinition = new ItemListDefinition();
			itemListDefinition.name_ = "";
			RepeatedField<string> repeatedField = (itemListDefinition.previousNames_ = (RepeatedField<string>)(object)new RepeatedField<T>());
			int num = 0;
			ByteString byteString = (itemListDefinition.itemData_ = ByteString.Empty);
			string text = (itemListDefinition.name_ = name_);
			RepeatedField<string> repeatedField2 = (itemListDefinition.previousNames_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)previousNames_).Clone());
			bool flag = (itemListDefinition.deleted_ = deleted_);
			ByteString byteString2 = (itemListDefinition.itemData_ = itemData_);
			UnknownFieldSet unknownFieldSet = (itemListDefinition._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemListDefinition;
		}

		[Cpp2IlInjected.Token(Token = "0x60019DB")]
		[Cpp2IlInjected.Address(RVA = "0x25DF370", Offset = "0x25DDD70", VA = "0x1825DF370", Slot = "0")]
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
				string text = name_;
				bool flag = default(bool);
				if (!flag)
				{
					RepeatedField<string> repeatedField = previousNames_;
					bool flag2 = default(bool);
					if (flag2 && deleted_ == flag2)
					{
						ByteString byteString = itemData_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019DC")]
		[Cpp2IlInjected.Address(RVA = "0x25DF4C0", Offset = "0x25DDEC0", VA = "0x1825DF4C0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemListDefinition other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.name_;
				if (!(name_ != text))
				{
					RepeatedField<string> repeatedField = previousNames_;
					RepeatedField<string> repeatedField2 = other.previousNames_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						bool flag = other.deleted_;
						if (deleted_ == flag)
						{
							ByteString byteString = itemData_;
							ByteString byteString2 = other.itemData_;
							if (!(byteString != byteString2))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019DD")]
		[Cpp2IlInjected.Address(RVA = "0x25DF6D0", Offset = "0x25DE0D0", VA = "0x1825DF6D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005f
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)previousNames_).GetHashCode();
			if (deleted_)
			{
			}
			if (itemData_.Length != 0)
			{
				int hashCode3 = itemData_.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60019DE")]
		[Cpp2IlInjected.Address(RVA = "0x25DFB50", Offset = "0x25DE550", VA = "0x1825DFB50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60019DF")]
		[Cpp2IlInjected.Address(RVA = "0x25DFBB0", Offset = "0x25DE5B0", VA = "0x1825DFBB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007c
			if (name_.m_stringLength != 0)
			{
				string value = name_;
				output.WriteString(value);
			}
			RepeatedField<string> repeatedField = previousNames_;
			FieldCodec<string> repeated_previousNames_codec = _repeated_previousNames_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_previousNames_codec);
			if (deleted_)
			{
				bool value2 = deleted_;
				output.WriteBool(value2);
			}
			if (itemData_.Length != 0)
			{
				ByteString value3 = itemData_;
				output.WriteBytes(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60019E0")]
		[Cpp2IlInjected.Address(RVA = "0x25DEF60", Offset = "0x25DD960", VA = "0x1825DEF60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			string text = name_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			RepeatedField<string> repeatedField = previousNames_;
			FieldCodec<string> repeated_previousNames_codec = _repeated_previousNames_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_previousNames_codec);
			if (itemData_.Length != 0)
			{
				int num4 = CodedOutputStream.ComputeBytesSize(itemData_);
				num4++;
				repeatedField = (RepeatedField<string>)(repeatedField + num4);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<string>)(repeatedField + num5);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019E1")]
		[Cpp2IlInjected.Address(RVA = "0x25DF900", Offset = "0x25DE300", VA = "0x1825DF900", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemListDefinition other)
		{
			//Discarded unreachable code: IL_0083
			if (other != null)
			{
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				RepeatedField<string> repeatedField = previousNames_;
				RepeatedField<string> repeatedField2 = other.previousNames_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				bool flag = other.deleted_;
				if (flag)
				{
					deleted_ = flag;
				}
				if (other.itemData_.Length != 0)
				{
					ByteString byteString2 = (ItemData = other.itemData_);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019E2")]
		[Cpp2IlInjected.Address(RVA = "0x25DF7B0", Offset = "0x25DE1B0", VA = "0x1825DF7B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0088
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					bool flag = (deleted_ = input.ReadBool());
				}
				if (num != 34)
				{
					goto IL_0071;
				}
				ByteString byteString2 = (ItemData = input.ReadBytes());
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (Name = input.ReadString());
			}
			if ((long)text2 == 18)
			{
				RepeatedField<string> repeatedField = previousNames_;
				FieldCodec<string> repeated_previousNames_codec = _repeated_previousNames_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_previousNames_codec);
			}
			goto IL_0071;
			IL_0071:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60019E3")]
		[Cpp2IlInjected.Address(RVA = "0x25DF5E0", Offset = "0x25DDFE0", VA = "0x1825DF5E0", Slot = "11")]
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
						if (num != 1)
						{
							goto IL_0031;
						}
						ByteString byteString = itemData_;
					}
					bool flag = deleted_;
				}
				RepeatedField<string> repeatedField = previousNames_;
			}
			string text = name_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60019E4")]
		[Cpp2IlInjected.Address(RVA = "0x25DF9D0", Offset = "0x25DE3D0", VA = "0x1825DF9D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0025: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
						break;
					default:
						return;
					case 0:
					{
						object obj = default(object);
						deleted_ = (byte)(int)obj != 0;
						return;
					}
					}
					int num2 = 0;
					if (value == null || value != null)
					{
						ItemData = (ByteString)num2;
						return;
					}
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019E5")]
		[Cpp2IlInjected.Address(RVA = "0x25DF0B0", Offset = "0x25DDAB0", VA = "0x1825DF0B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0028
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num == 1)
			{
				int num2 = 0;
				ByteString empty = ByteString.Empty;
				int num3 = 0;
				ItemData = empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019E6")]
		[Cpp2IlInjected.Address(RVA = "0x25DFD00", Offset = "0x25DE700", VA = "0x1825DFD00")]
		static ItemListDefinition()
		{
			Func<ItemListDefinition> func = default(Func<ItemListDefinition>);
			_parser = (MessageParser<ItemListDefinition>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ItemListDefinition>)(object)FieldCodec.ForString(18u);
			/*Error: Unexpected end of block*/;
		}
	}
}
