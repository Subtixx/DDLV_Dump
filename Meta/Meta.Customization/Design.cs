using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010F3")]
	public sealed class Design : IDesign, IMessage<Design>, IMessage, IEquatable<Design>, IDeepCloneable<Design>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40045F9")]
		private static readonly MessageParser<Design> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40045FA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40045FB")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40045FC")]
		private int id_;

		[Cpp2IlInjected.Token(Token = "0x40045FD")]
		public const int ItemFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40045FE")]
		private int item_;

		[Cpp2IlInjected.Token(Token = "0x40045FF")]
		public const int BaseColorFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004600")]
		private string baseColor_;

		[Cpp2IlInjected.Token(Token = "0x4004601")]
		public const int DecalsFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4004602")]
		private static readonly FieldCodec<Decal> _repeated_decals_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004603")]
		private readonly RepeatedField<Decal> decals_;

		[Cpp2IlInjected.Token(Token = "0x17001823")]
		Item IDesign.Item
		{
			[Cpp2IlInjected.Token(Token = "0x6008A1E")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180", Slot = "5")]
			get
			{
				int num = item_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001824")]
		string IDesign.BaseColor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A1F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "6")]
			get
			{
				return baseColor_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001825")]
		IReadOnlyList<IDecal> IDesign.Decals
		{
			[Cpp2IlInjected.Token(Token = "0x6008A20")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "7")]
			get
			{
				RepeatedField<Decal> repeatedField = decals_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001826")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6008A21")]
			[Cpp2IlInjected.Address(RVA = "0x1A2BA90", Offset = "0x1A2A490", VA = "0x181A2BA90")]
			get
			{
				//Discarded unreachable code: IL_001c
				if (((RepeatedField<T>)(object)decals_).Count != 0)
				{
					int num = 0;
				}
				return string.IsNullOrEmpty(baseColor_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001827")]
		[DebuggerNonUserCode]
		public static MessageParser<Design> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008A22")]
			[Cpp2IlInjected.Address(RVA = "0x1A2BAF0", Offset = "0x1A2A4F0", VA = "0x181A2BAF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001828")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A23")]
			[Cpp2IlInjected.Address(RVA = "0x1A2B9C0", Offset = "0x1A2A3C0", VA = "0x181A2B9C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001829")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A24")]
			[Cpp2IlInjected.Address(RVA = "0x1A2BB50", Offset = "0x1A2A550", VA = "0x181A2BB50", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182A")]
		[DebuggerNonUserCode]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6008A29")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "4")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A2A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				id_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182B")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6008A2B")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A2C")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182C")]
		[DebuggerNonUserCode]
		public string BaseColor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A2D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return baseColor_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A2E")]
			[Cpp2IlInjected.Address(RVA = "0x1A2BC60", Offset = "0x1A2A660", VA = "0x181A2BC60")]
			set
			{
				string text = (baseColor_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700182D")]
		[DebuggerNonUserCode]
		public RepeatedField<Decal> Decals
		{
			[Cpp2IlInjected.Token(Token = "0x6008A2F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return decals_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A25")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B870", Offset = "0x1A2A270", VA = "0x181A2B870")]
		[DebuggerNonUserCode]
		public Design()
		{
			baseColor_ = "";
			RepeatedField<Decal> repeatedField = (decals_ = (RepeatedField<Decal>)(object)new RepeatedField<T>());
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A26")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnConstruction()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008A27")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B910", Offset = "0x1A2A310", VA = "0x181A2B910")]
		[DebuggerNonUserCode]
		public Design(Design other)
		{
			int num = (id_ = other.id_);
			int num2 = (item_ = other.item_);
			string text = (baseColor_ = other.baseColor_);
			RepeatedField<Decal> repeatedField = (decals_ = (RepeatedField<Decal>)(object)((RepeatedField<T>)(object)other.decals_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A28")]
		[Cpp2IlInjected.Address(RVA = "0x1A2AD30", Offset = "0x1A29730", VA = "0x181A2AD30", Slot = "14")]
		[DebuggerNonUserCode]
		public Design Clone()
		{
			//Discarded unreachable code: IL_005c
			Design design = new Design();
			int num = (design.id_ = id_);
			int num2 = (design.item_ = item_);
			string text = (design.baseColor_ = baseColor_);
			RepeatedField<Decal> repeatedField = (design.decals_ = (RepeatedField<Decal>)(object)((RepeatedField<T>)(object)decals_).Clone());
			UnknownFieldSet unknownFieldSet = (design._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return design;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A30")]
		[Cpp2IlInjected.Address(RVA = "0x1A2AE10", Offset = "0x1A29810", VA = "0x181A2AE10", Slot = "0")]
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
				if ((IntPtr)id_ == (IntPtr)typeof(Design).TypeHandle && (IntPtr)item_ == (IntPtr)typeof(Design).TypeHandle)
				{
					string text = baseColor_;
					bool flag = default(bool);
					if (!flag)
					{
						RepeatedField<Decal> repeatedField = decals_;
						bool flag2 = default(bool);
						if (flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A31")]
		[Cpp2IlInjected.Address(RVA = "0x1A2AF10", Offset = "0x1A29910", VA = "0x181A2AF10", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(Design other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.id_;
				if (id_ == num)
				{
					int num2 = other.item_;
					if (item_ == num2)
					{
						string text = other.baseColor_;
						if (!(baseColor_ != text))
						{
							RepeatedField<Decal> repeatedField = decals_;
							RepeatedField<Decal> repeatedField2 = other.decals_;
							if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A32")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B0C0", Offset = "0x1A29AC0", VA = "0x181A2B0C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004d
			if (id_ != 0)
			{
			}
			if (item_ != 0)
			{
			}
			string text = baseColor_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)decals_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A33")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B4F0", Offset = "0x1A29EF0", VA = "0x181A2B4F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008A34")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B550", Offset = "0x1A29F50", VA = "0x181A2B550", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0077
			if (id_ != 0)
			{
				int value = id_;
				output.WriteInt32(value);
			}
			if (item_ != 0)
			{
				int value2 = item_;
				output.WriteInt32(value2);
			}
			if (baseColor_.m_stringLength != 0)
			{
				string value3 = baseColor_;
				output.WriteString(value3);
			}
			RepeatedField<Decal> repeatedField = decals_;
			FieldCodec<Decal> repeated_decals_codec = _repeated_decals_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_decals_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008A35")]
		[Cpp2IlInjected.Address(RVA = "0x1A2AB10", Offset = "0x1A29510", VA = "0x181A2AB10", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0094
			int num = id_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = item_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			string text = baseColor_;
			if (text.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text);
				num6++;
				num2 += num6;
			}
			RepeatedField<Decal> repeatedField = decals_;
			FieldCodec<Decal> repeated_decals_codec = _repeated_decals_codec;
			int num7 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_decals_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num7;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num2 += num8;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A36")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B2D0", Offset = "0x1A29CD0", VA = "0x181A2B2D0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(Design other)
		{
			//Discarded unreachable code: IL_0076
			if (other != null)
			{
				int num = other.id_;
				if (num != 0)
				{
					id_ = num;
				}
				int num2 = other.item_;
				if (num2 != 0)
				{
					item_ = num2;
				}
				string text = other.baseColor_;
				if (text.m_stringLength != 0)
				{
					BaseColor = text;
				}
				RepeatedField<Decal> repeatedField = decals_;
				RepeatedField<Decal> repeatedField2 = other.decals_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A37")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B180", Offset = "0x1A29B80", VA = "0x181A2B180", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0086
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					string text2 = (BaseColor = input.ReadString());
				}
				if (num != 34)
				{
					goto IL_006f;
				}
				RepeatedField<Decal> repeatedField = decals_;
				FieldCodec<Decal> repeated_decals_codec = _repeated_decals_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_decals_codec);
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (id_ = input.ReadInt32());
			}
			if (num2 == 16)
			{
				int num3 = (item_ = input.ReadInt32());
			}
			goto IL_006f;
			IL_006f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008A38")]
		[Cpp2IlInjected.Address(RVA = "0x1A2AFD0", Offset = "0x1A299D0", VA = "0x181A2AFD0", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0029;
					}
					RepeatedField<Decal> repeatedField = decals_;
				}
				string text = baseColor_;
			}
			int num2 = id_;
			goto IL_0029;
			IL_0029:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A39")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B380", Offset = "0x1A29D80", VA = "0x181A2B380", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0036
			//IL_0025: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			//IL_0035: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0 || num != 1)
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							BaseColor = (string)num2;
							return;
						}
					}
					else
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					}
					throw new InvalidCastException();
				}
				object obj = default(object);
				item_ = (int)obj;
			}
			else
			{
				object obj2 = default(object);
				id_ = (int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A3A")]
		[Cpp2IlInjected.Address(RVA = "0x1A2AC70", Offset = "0x1A29670", VA = "0x181A2AC70", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_003b
			//IL_0030: Expected I4, but got I8
			//IL_003a: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						RepeatedField<Decal> repeatedField = decals_;
						break;
					}
					case 0:
						break;
					default:
						return;
					}
					BaseColor = "";
				}
				else
				{
					item_ = 0;
				}
			}
			else
			{
				id_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A3B")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B6A0", Offset = "0x1A2A0A0", VA = "0x181A2B6A0")]
		static Design()
		{
			Func<Design> func = default(Func<Design>);
			_parser = (MessageParser<Design>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Decal> parser = Decal._parser;
			uint num = default(uint);
			_parser = (MessageParser<Design>)(object)FieldCodec.ForMessage<Decal>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
