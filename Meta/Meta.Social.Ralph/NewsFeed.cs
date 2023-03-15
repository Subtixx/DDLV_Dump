using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social.Ralph
{
	[Cpp2IlInjected.Token(Token = "0x2000DE4")]
	public sealed class NewsFeed : IMessage<NewsFeed>, IMessage, IEquatable<NewsFeed>, IDeepCloneable<NewsFeed>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400383D")]
		private static readonly MessageParser<NewsFeed> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400383E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400383F")]
		public const int PicturesPerUserFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4003840")]
		private static readonly FieldCodec<UserPictures> _repeated_picturesPerUser_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003841")]
		private readonly RepeatedField<UserPictures> picturesPerUser_ = (RepeatedField<UserPictures>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700140E")]
		[DebuggerNonUserCode]
		public static MessageParser<NewsFeed> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60073EF")]
			[Cpp2IlInjected.Address(RVA = "0x139B2D0", Offset = "0x1399CD0", VA = "0x18139B2D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700140F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60073F0")]
			[Cpp2IlInjected.Address(RVA = "0x139B200", Offset = "0x1399C00", VA = "0x18139B200")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001410")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60073F1")]
			[Cpp2IlInjected.Address(RVA = "0x139B330", Offset = "0x1399D30", VA = "0x18139B330", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001411")]
		[DebuggerNonUserCode]
		public RepeatedField<UserPictures> PicturesPerUser
		{
			[Cpp2IlInjected.Token(Token = "0x60073F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return picturesPerUser_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073F2")]
		[Cpp2IlInjected.Address(RVA = "0x139B180", Offset = "0x1399B80", VA = "0x18139B180")]
		[DebuggerNonUserCode]
		public NewsFeed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60073F3")]
		[Cpp2IlInjected.Address(RVA = "0x139B080", Offset = "0x1399A80", VA = "0x18139B080")]
		[DebuggerNonUserCode]
		public NewsFeed(NewsFeed other)
		{
			RepeatedField<UserPictures> repeatedField = (picturesPerUser_ = (RepeatedField<UserPictures>)(object)((RepeatedField<T>)(object)other.picturesPerUser_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60073F4")]
		[Cpp2IlInjected.Address(RVA = "0x139A8A0", Offset = "0x13992A0", VA = "0x18139A8A0", Slot = "10")]
		[DebuggerNonUserCode]
		public NewsFeed Clone()
		{
			//Discarded unreachable code: IL_003b
			NewsFeed newsFeed = new NewsFeed();
			RepeatedField<UserPictures> repeatedField = (newsFeed.picturesPerUser_ = (RepeatedField<UserPictures>)(object)new RepeatedField<T>());
			RepeatedField<UserPictures> repeatedField2 = (newsFeed.picturesPerUser_ = (RepeatedField<UserPictures>)(object)((RepeatedField<T>)(object)picturesPerUser_).Clone());
			UnknownFieldSet unknownFieldSet = (newsFeed._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return newsFeed;
		}

		[Cpp2IlInjected.Token(Token = "0x60073F6")]
		[Cpp2IlInjected.Address(RVA = "0x139AA60", Offset = "0x1399460", VA = "0x18139AA60", Slot = "0")]
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
				RepeatedField<UserPictures> repeatedField = picturesPerUser_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60073F7")]
		[Cpp2IlInjected.Address(RVA = "0x139A9D0", Offset = "0x13993D0", VA = "0x18139A9D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(NewsFeed other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<UserPictures> repeatedField = picturesPerUser_;
				RepeatedField<UserPictures> repeatedField2 = other.picturesPerUser_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60073F8")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)picturesPerUser_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60073F9")]
		[Cpp2IlInjected.Address(RVA = "0x139AD90", Offset = "0x1399790", VA = "0x18139AD90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60073FA")]
		[Cpp2IlInjected.Address(RVA = "0x139ADF0", Offset = "0x13997F0", VA = "0x18139ADF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<UserPictures> repeatedField = picturesPerUser_;
			FieldCodec<UserPictures> repeated_picturesPerUser_codec = _repeated_picturesPerUser_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_picturesPerUser_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60073FB")]
		[Cpp2IlInjected.Address(RVA = "0x139A790", Offset = "0x1399190", VA = "0x18139A790", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<UserPictures> repeatedField = picturesPerUser_;
			FieldCodec<UserPictures> repeated_picturesPerUser_codec = _repeated_picturesPerUser_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_picturesPerUser_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60073FC")]
		[Cpp2IlInjected.Address(RVA = "0x139ACB0", Offset = "0x13996B0", VA = "0x18139ACB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(NewsFeed other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<UserPictures> repeatedField = picturesPerUser_;
				RepeatedField<UserPictures> repeatedField2 = other.picturesPerUser_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073FD")]
		[Cpp2IlInjected.Address(RVA = "0x139ABC0", Offset = "0x13995C0", VA = "0x18139ABC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<UserPictures> repeatedField = picturesPerUser_;
					FieldCodec<UserPictures> repeated_picturesPerUser_codec = _repeated_picturesPerUser_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_picturesPerUser_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073FE")]
		[Cpp2IlInjected.Address(RVA = "0x139AB40", Offset = "0x1399540", VA = "0x18139AB40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<UserPictures> repeatedField = picturesPerUser_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60073FF")]
		[Cpp2IlInjected.Address(RVA = "0x139AD30", Offset = "0x1399730", VA = "0x18139AD30", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6007400")]
		[Cpp2IlInjected.Address(RVA = "0x139A840", Offset = "0x1399240", VA = "0x18139A840", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<UserPictures> repeatedField = picturesPerUser_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007401")]
		[Cpp2IlInjected.Address(RVA = "0x139AEB0", Offset = "0x13998B0", VA = "0x18139AEB0")]
		static NewsFeed()
		{
			Func<NewsFeed> func = default(Func<NewsFeed>);
			_parser = (MessageParser<NewsFeed>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<UserPictures> parser = UserPictures._parser;
			uint num = default(uint);
			_parser = (MessageParser<NewsFeed>)(object)FieldCodec.ForMessage<UserPictures>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
