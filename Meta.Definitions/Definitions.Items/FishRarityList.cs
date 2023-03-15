using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200041C")]
	public sealed class FishRarityList : IMessage<FishRarityList>, IMessage, IEquatable<FishRarityList>, IDeepCloneable<FishRarityList>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001676")]
		private static readonly MessageParser<FishRarityList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001677")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001678")]
		public const int FishRaritiesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001679")]
		private static readonly FieldCodec<FishRarity> _repeated_fishRarities_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400167A")]
		private readonly RepeatedField<FishRarity> fishRarities_ = (RepeatedField<FishRarity>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000CE1")]
		[DebuggerNonUserCode]
		public static MessageParser<FishRarityList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003242")]
			[Cpp2IlInjected.Address(RVA = "0x3578F90", Offset = "0x3577990", VA = "0x183578F90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003243")]
			[Cpp2IlInjected.Address(RVA = "0x3578EC0", Offset = "0x35778C0", VA = "0x183578EC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003244")]
			[Cpp2IlInjected.Address(RVA = "0x3578FF0", Offset = "0x35779F0", VA = "0x183578FF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CE4")]
		[DebuggerNonUserCode]
		public RepeatedField<FishRarity> FishRarities
		{
			[Cpp2IlInjected.Token(Token = "0x6003248")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return fishRarities_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003245")]
		[Cpp2IlInjected.Address(RVA = "0x3578E40", Offset = "0x3577840", VA = "0x183578E40")]
		[DebuggerNonUserCode]
		public FishRarityList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003246")]
		[Cpp2IlInjected.Address(RVA = "0x3578D40", Offset = "0x3577740", VA = "0x183578D40")]
		[DebuggerNonUserCode]
		public FishRarityList(FishRarityList other)
		{
			RepeatedField<FishRarity> repeatedField = (fishRarities_ = (RepeatedField<FishRarity>)(object)((RepeatedField<T>)(object)other.fishRarities_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003247")]
		[Cpp2IlInjected.Address(RVA = "0x35783E0", Offset = "0x3576DE0", VA = "0x1835783E0", Slot = "10")]
		[DebuggerNonUserCode]
		public FishRarityList Clone()
		{
			//Discarded unreachable code: IL_003b
			FishRarityList fishRarityList = new FishRarityList();
			RepeatedField<FishRarity> repeatedField = (fishRarityList.fishRarities_ = (RepeatedField<FishRarity>)(object)new RepeatedField<T>());
			RepeatedField<FishRarity> repeatedField2 = (fishRarityList.fishRarities_ = (RepeatedField<FishRarity>)(object)((RepeatedField<T>)(object)fishRarities_).Clone());
			UnknownFieldSet unknownFieldSet = (fishRarityList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return fishRarityList;
		}

		[Cpp2IlInjected.Token(Token = "0x6003249")]
		[Cpp2IlInjected.Address(RVA = "0x35786D0", Offset = "0x35770D0", VA = "0x1835786D0", Slot = "0")]
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
				RepeatedField<FishRarity> repeatedField = fishRarities_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600324A")]
		[Cpp2IlInjected.Address(RVA = "0x3578640", Offset = "0x3577040", VA = "0x183578640", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FishRarityList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<FishRarity> repeatedField = fishRarities_;
				RepeatedField<FishRarity> repeatedField2 = other.fishRarities_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600324B")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)fishRarities_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600324C")]
		[Cpp2IlInjected.Address(RVA = "0x3578A00", Offset = "0x3577400", VA = "0x183578A00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600324D")]
		[Cpp2IlInjected.Address(RVA = "0x3578A60", Offset = "0x3577460", VA = "0x183578A60", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<FishRarity> repeatedField = fishRarities_;
			FieldCodec<FishRarity> repeated_fishRarities_codec = _repeated_fishRarities_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_fishRarities_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600324E")]
		[Cpp2IlInjected.Address(RVA = "0x35782D0", Offset = "0x3576CD0", VA = "0x1835782D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<FishRarity> repeatedField = fishRarities_;
			FieldCodec<FishRarity> repeated_fishRarities_codec = _repeated_fishRarities_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_fishRarities_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600324F")]
		[Cpp2IlInjected.Address(RVA = "0x3578830", Offset = "0x3577230", VA = "0x183578830", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FishRarityList other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<FishRarity> repeatedField = fishRarities_;
				RepeatedField<FishRarity> repeatedField2 = other.fishRarities_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003250")]
		[Cpp2IlInjected.Address(RVA = "0x35788B0", Offset = "0x35772B0", VA = "0x1835788B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<FishRarity> repeatedField = fishRarities_;
				FieldCodec<FishRarity> repeated_fishRarities_codec = _repeated_fishRarities_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_fishRarities_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003251")]
		[Cpp2IlInjected.Address(RVA = "0x35787B0", Offset = "0x35771B0", VA = "0x1835787B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<FishRarity> repeatedField = fishRarities_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003252")]
		[Cpp2IlInjected.Address(RVA = "0x35789A0", Offset = "0x35773A0", VA = "0x1835789A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003253")]
		[Cpp2IlInjected.Address(RVA = "0x3578380", Offset = "0x3576D80", VA = "0x183578380", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<FishRarity> repeatedField = fishRarities_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003254")]
		[Cpp2IlInjected.Address(RVA = "0x3578510", Offset = "0x3576F10", VA = "0x183578510", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0051
			if (((RepeatedField<T>)(object)fishRarities_).Count != 0)
			{
				int count = ((RepeatedField<T>)(object)fishRarities_).Count;
				int num = Enumerable.Count<FishRarity>(Enumerable.Distinct<FishRarity>((IEnumerable<>)(object)fishRarities_));
				if (count != num)
				{
					context.AddInvalidMemberError("Cannot have duplicate", "FishRarities");
				}
			}
			else
			{
				context.AddInvalidMemberError("Enter at least one FishRarity", "FishRarities");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003255")]
		[Cpp2IlInjected.Address(RVA = "0x3578B20", Offset = "0x3577520", VA = "0x183578B20")]
		static FishRarityList()
		{
			Func<FishRarityList> func = default(Func<FishRarityList>);
			MessageParser<FishRarityList> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<FishRarityList>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<FishRarity, int> func2 = (Func<FishRarity, int>)(object)(Func<T, TResult>)((FishRarity x) => (int)x);
			Func<int, FishRarity> func3 = (Func<int, FishRarity>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<FishRarityList>)(object)FieldCodec.ForEnum<FishRarity>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
