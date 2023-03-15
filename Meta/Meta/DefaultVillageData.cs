using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007F3")]
	public sealed class DefaultVillageData : IMessage<DefaultVillageData>, IMessage, IEquatable<DefaultVillageData>, IDeepCloneable<DefaultVillageData>, IMessageFieldAccessor, IDefaultGridCollectionContainer
	{
		[Cpp2IlInjected.Token(Token = "0x4001FBA")]
		private static readonly MessageParser<DefaultVillageData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FBB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FBC")]
		public const int DefaultVillageFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FBD")]
		private Village defaultVillage_;

		[Cpp2IlInjected.Token(Token = "0x4001FBE")]
		public const int GridLayoutPathsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001FBF")]
		private static readonly FieldCodec<string> _repeated_gridLayoutPaths_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FC0")]
		private readonly RepeatedField<string> gridLayoutPaths_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000ABE")]
		[DebuggerNonUserCode]
		public static MessageParser<DefaultVillageData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004231")]
			[Cpp2IlInjected.Address(RVA = "0x1A271C0", Offset = "0x1A25BC0", VA = "0x181A271C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ABF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004232")]
			[Cpp2IlInjected.Address(RVA = "0x1A270F0", Offset = "0x1A25AF0", VA = "0x181A270F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004233")]
			[Cpp2IlInjected.Address(RVA = "0x1A27220", Offset = "0x1A25C20", VA = "0x181A27220", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC1")]
		[DebuggerNonUserCode]
		public Village DefaultVillage
		{
			[Cpp2IlInjected.Token(Token = "0x6004237")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return defaultVillage_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004238")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				defaultVillage_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC2")]
		[DebuggerNonUserCode]
		public RepeatedField<string> GridLayoutPaths
		{
			[Cpp2IlInjected.Token(Token = "0x6004239")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return gridLayoutPaths_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AC3")]
		GridCollection IDefaultGridCollectionContainer.DefaultGridCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6004245")]
			[Cpp2IlInjected.Address(RVA = "0x1A26BA0", Offset = "0x1A255A0", VA = "0x181A26BA0", Slot = "14")]
			get
			{
				InvalidOperationException ex = new InvalidOperationException("The village layout is split");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004234")]
		[Cpp2IlInjected.Address(RVA = "0x1A26F50", Offset = "0x1A25950", VA = "0x181A26F50")]
		[DebuggerNonUserCode]
		public DefaultVillageData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004235")]
		[Cpp2IlInjected.Address(RVA = "0x1A26FD0", Offset = "0x1A259D0", VA = "0x181A26FD0")]
		[DebuggerNonUserCode]
		public DefaultVillageData(DefaultVillageData other)
		{
			//IL_002e: Expected O, but got I4
			Village village = other.defaultVillage_;
			if (village != null)
			{
				Village village2 = village.Clone();
			}
			int num = 0;
			defaultVillage_ = (Village)num;
			RepeatedField<string> repeatedField = (gridLayoutPaths_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.gridLayoutPaths_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004236")]
		[Cpp2IlInjected.Address(RVA = "0x1A265D0", Offset = "0x1A24FD0", VA = "0x181A265D0", Slot = "10")]
		[DebuggerNonUserCode]
		public DefaultVillageData Clone()
		{
			//Discarded unreachable code: IL_005c
			//IL_0030: Expected O, but got I4
			DefaultVillageData defaultVillageData = new DefaultVillageData();
			RepeatedField<string> repeatedField = (defaultVillageData.gridLayoutPaths_ = (RepeatedField<string>)(object)new RepeatedField<T>());
			Village village = defaultVillage_;
			if (village != null)
			{
				Village village2 = village.Clone();
			}
			int num = 0;
			defaultVillageData.defaultVillage_ = (Village)num;
			RepeatedField<string> repeatedField2 = (defaultVillageData.gridLayoutPaths_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)gridLayoutPaths_).Clone());
			UnknownFieldSet unknownFieldSet = (defaultVillageData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return defaultVillageData;
		}

		[Cpp2IlInjected.Token(Token = "0x600423A")]
		[Cpp2IlInjected.Address(RVA = "0x1A267D0", Offset = "0x1A251D0", VA = "0x181A267D0", Slot = "0")]
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
				if (object.Equals(defaultVillage_, other))
				{
					RepeatedField<string> repeatedField = gridLayoutPaths_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600423B")]
		[Cpp2IlInjected.Address(RVA = "0x1A26720", Offset = "0x1A25120", VA = "0x181A26720", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultVillageData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Village objB = other.defaultVillage_;
				if (object.Equals(defaultVillage_, objB))
				{
					RepeatedField<string> repeatedField = gridLayoutPaths_;
					RepeatedField<string> repeatedField2 = other.gridLayoutPaths_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600423C")]
		[Cpp2IlInjected.Address(RVA = "0xC052E0", Offset = "0xC03CE0", VA = "0x180C052E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0033
			Village village = defaultVillage_;
			if (village != null)
			{
				int hashCode = village.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)gridLayoutPaths_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600423D")]
		[Cpp2IlInjected.Address(RVA = "0x1A26CC0", Offset = "0x1A256C0", VA = "0x181A26CC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600423E")]
		[Cpp2IlInjected.Address(RVA = "0x1A26D20", Offset = "0x1A25720", VA = "0x181A26D20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if ((long)defaultVillage_ != 0)
			{
				Village value = defaultVillage_;
				output.WriteMessage(value);
			}
			RepeatedField<string> repeatedField = gridLayoutPaths_;
			FieldCodec<string> repeated_gridLayoutPaths_codec = _repeated_gridLayoutPaths_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_gridLayoutPaths_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600423F")]
		[Cpp2IlInjected.Address(RVA = "0x1A26450", Offset = "0x1A24E50", VA = "0x181A26450", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			Village village = defaultVillage_;
			int num = 0;
			if (village != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(village);
			}
			RepeatedField<string> repeatedField = gridLayoutPaths_;
			FieldCodec<string> repeated_gridLayoutPaths_codec = _repeated_gridLayoutPaths_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_gridLayoutPaths_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004240")]
		[Cpp2IlInjected.Address(RVA = "0x1A26AB0", Offset = "0x1A254B0", VA = "0x181A26AB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DefaultVillageData other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			if ((long)other.defaultVillage_ != 0)
			{
				Village village = defaultVillage_;
				if (village == null)
				{
					Village village2 = (defaultVillage_ = new Village());
				}
				Village other2 = other.defaultVillage_;
				village.MergeFrom(other2);
			}
			RepeatedField<string> repeatedField = gridLayoutPaths_;
			RepeatedField<string> repeatedField2 = other.gridLayoutPaths_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004241")]
		[Cpp2IlInjected.Address(RVA = "0x1A26950", Offset = "0x1A25350", VA = "0x181A26950", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0065
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Village village = defaultVillage_;
				if (village == null)
				{
					Village village2 = (defaultVillage_ = new Village());
				}
				input.ReadMessage(village);
			}
			if (num == 18)
			{
				RepeatedField<string> repeatedField = gridLayoutPaths_;
				FieldCodec<string> repeated_gridLayoutPaths_codec = _repeated_gridLayoutPaths_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_gridLayoutPaths_codec);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004242")]
		[Cpp2IlInjected.Address(RVA = "0x1A268C0", Offset = "0x1A252C0", VA = "0x181A268C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Village village = defaultVillage_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<string> repeatedField = gridLayoutPaths_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004243")]
		[Cpp2IlInjected.Address(RVA = "0x1A26BF0", Offset = "0x1A255F0", VA = "0x181A26BF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					defaultVillage_ = (Village)num;
					return;
				}
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004244")]
		[Cpp2IlInjected.Address(RVA = "0x1A26550", Offset = "0x1A24F50", VA = "0x181A26550", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<string> repeatedField = gridLayoutPaths_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004246")]
		[Cpp2IlInjected.Address(RVA = "0x1A26E10", Offset = "0x1A25810", VA = "0x181A26E10")]
		static DefaultVillageData()
		{
			Func<DefaultVillageData> func = default(Func<DefaultVillageData>);
			_parser = (MessageParser<DefaultVillageData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<DefaultVillageData>)(object)FieldCodec.ForString(18u);
			/*Error: Unexpected end of block*/;
		}
	}
}
