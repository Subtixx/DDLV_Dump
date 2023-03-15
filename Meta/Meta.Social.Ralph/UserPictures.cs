using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social.Ralph
{
	[Cpp2IlInjected.Token(Token = "0x2000DE2")]
	public sealed class UserPictures : IMessage<UserPictures>, IMessage, IEquatable<UserPictures>, IDeepCloneable<UserPictures>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4003835")]
		private static readonly MessageParser<UserPictures> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003836")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003837")]
		public const int SnapshotFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003838")]
		private Snapshot snapshot_;

		[Cpp2IlInjected.Token(Token = "0x4003839")]
		public const int PicturesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400383A")]
		private static readonly FieldCodec<AlbumPicture> _repeated_pictures_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400383B")]
		private readonly RepeatedField<AlbumPicture> pictures_ = (RepeatedField<AlbumPicture>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001409")]
		[DebuggerNonUserCode]
		public static MessageParser<UserPictures> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60073D7")]
			[Cpp2IlInjected.Address(RVA = "0x15DF110", Offset = "0x15DDB10", VA = "0x1815DF110")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700140A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60073D8")]
			[Cpp2IlInjected.Address(RVA = "0x15DF040", Offset = "0x15DDA40", VA = "0x1815DF040")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700140B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60073D9")]
			[Cpp2IlInjected.Address(RVA = "0x15DF170", Offset = "0x15DDB70", VA = "0x1815DF170", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700140C")]
		[DebuggerNonUserCode]
		public Snapshot Snapshot
		{
			[Cpp2IlInjected.Token(Token = "0x60073DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return snapshot_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073DE")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				snapshot_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700140D")]
		[DebuggerNonUserCode]
		public RepeatedField<AlbumPicture> Pictures
		{
			[Cpp2IlInjected.Token(Token = "0x60073DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return pictures_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073DA")]
		[Cpp2IlInjected.Address(RVA = "0x15DEEA0", Offset = "0x15DD8A0", VA = "0x1815DEEA0")]
		[DebuggerNonUserCode]
		public UserPictures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60073DB")]
		[Cpp2IlInjected.Address(RVA = "0x15DEF20", Offset = "0x15DD920", VA = "0x1815DEF20")]
		[DebuggerNonUserCode]
		public UserPictures(UserPictures other)
		{
			//IL_002e: Expected O, but got I4
			Snapshot snapshot = other.snapshot_;
			if (snapshot != null)
			{
				Snapshot snapshot2 = snapshot.Clone();
			}
			int num = 0;
			snapshot_ = (Snapshot)num;
			RepeatedField<AlbumPicture> repeatedField = (pictures_ = (RepeatedField<AlbumPicture>)(object)((RepeatedField<T>)(object)other.pictures_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60073DC")]
		[Cpp2IlInjected.Address(RVA = "0x15DE4E0", Offset = "0x15DCEE0", VA = "0x1815DE4E0", Slot = "10")]
		[DebuggerNonUserCode]
		public UserPictures Clone()
		{
			//Discarded unreachable code: IL_005c
			//IL_0030: Expected O, but got I4
			UserPictures userPictures = new UserPictures();
			RepeatedField<AlbumPicture> repeatedField = (userPictures.pictures_ = (RepeatedField<AlbumPicture>)(object)new RepeatedField<T>());
			Snapshot snapshot = snapshot_;
			if (snapshot != null)
			{
				Snapshot snapshot2 = snapshot.Clone();
			}
			int num = 0;
			userPictures.snapshot_ = (Snapshot)num;
			RepeatedField<AlbumPicture> repeatedField2 = (userPictures.pictures_ = (RepeatedField<AlbumPicture>)(object)((RepeatedField<T>)(object)pictures_).Clone());
			UnknownFieldSet unknownFieldSet = (userPictures._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return userPictures;
		}

		[Cpp2IlInjected.Token(Token = "0x60073E0")]
		[Cpp2IlInjected.Address(RVA = "0x15DE630", Offset = "0x15DD030", VA = "0x1815DE630", Slot = "0")]
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
				if (object.Equals(snapshot_, other))
				{
					RepeatedField<AlbumPicture> repeatedField = pictures_;
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

		[Cpp2IlInjected.Token(Token = "0x60073E1")]
		[Cpp2IlInjected.Address(RVA = "0x15DE720", Offset = "0x15DD120", VA = "0x1815DE720", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UserPictures other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Snapshot objB = other.snapshot_;
				if (object.Equals(snapshot_, objB))
				{
					RepeatedField<AlbumPicture> repeatedField = pictures_;
					RepeatedField<AlbumPicture> repeatedField2 = other.pictures_;
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

		[Cpp2IlInjected.Token(Token = "0x60073E2")]
		[Cpp2IlInjected.Address(RVA = "0xC052E0", Offset = "0xC03CE0", VA = "0x180C052E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0033
			Snapshot snapshot = snapshot_;
			if (snapshot != null)
			{
				int hashCode = snapshot.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)pictures_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60073E3")]
		[Cpp2IlInjected.Address(RVA = "0x15DEB80", Offset = "0x15DD580", VA = "0x1815DEB80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60073E4")]
		[Cpp2IlInjected.Address(RVA = "0x15DEBE0", Offset = "0x15DD5E0", VA = "0x1815DEBE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if ((long)snapshot_ != 0)
			{
				Snapshot value = snapshot_;
				output.WriteMessage(value);
			}
			RepeatedField<AlbumPicture> repeatedField = pictures_;
			FieldCodec<AlbumPicture> repeated_pictures_codec = _repeated_pictures_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_pictures_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60073E5")]
		[Cpp2IlInjected.Address(RVA = "0x15DE360", Offset = "0x15DCD60", VA = "0x1815DE360", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			Snapshot snapshot = snapshot_;
			int num = 0;
			if (snapshot != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(snapshot);
			}
			RepeatedField<AlbumPicture> repeatedField = pictures_;
			FieldCodec<AlbumPicture> repeated_pictures_codec = _repeated_pictures_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_pictures_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60073E6")]
		[Cpp2IlInjected.Address(RVA = "0x15DE860", Offset = "0x15DD260", VA = "0x1815DE860", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UserPictures other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			if ((long)other.snapshot_ != 0)
			{
				Snapshot snapshot = snapshot_;
				if (snapshot == null)
				{
					Snapshot snapshot2 = (snapshot_ = new Snapshot());
				}
				Snapshot other2 = other.snapshot_;
				snapshot.MergeFrom(other2);
			}
			RepeatedField<AlbumPicture> repeatedField = pictures_;
			RepeatedField<AlbumPicture> repeatedField2 = other.pictures_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60073E7")]
		[Cpp2IlInjected.Address(RVA = "0x15DE950", Offset = "0x15DD350", VA = "0x1815DE950", Slot = "5")]
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
				Snapshot snapshot = snapshot_;
				if (snapshot == null)
				{
					Snapshot snapshot2 = (snapshot_ = new Snapshot());
				}
				input.ReadMessage(snapshot);
			}
			if (num == 18)
			{
				RepeatedField<AlbumPicture> repeatedField = pictures_;
				FieldCodec<AlbumPicture> repeated_pictures_codec = _repeated_pictures_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_pictures_codec);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60073E8")]
		[Cpp2IlInjected.Address(RVA = "0x15DE7D0", Offset = "0x15DD1D0", VA = "0x1815DE7D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Snapshot snapshot = snapshot_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<AlbumPicture> repeatedField = pictures_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60073E9")]
		[Cpp2IlInjected.Address(RVA = "0x15DEAB0", Offset = "0x15DD4B0", VA = "0x1815DEAB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					snapshot_ = (Snapshot)num;
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

		[Cpp2IlInjected.Token(Token = "0x60073EA")]
		[Cpp2IlInjected.Address(RVA = "0x15DE460", Offset = "0x15DCE60", VA = "0x1815DE460", Slot = "13")]
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
			RepeatedField<AlbumPicture> repeatedField = pictures_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60073EB")]
		[Cpp2IlInjected.Address(RVA = "0x15DECD0", Offset = "0x15DD6D0", VA = "0x1815DECD0")]
		static UserPictures()
		{
			Func<UserPictures> func = default(Func<UserPictures>);
			_parser = (MessageParser<UserPictures>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<AlbumPicture> parser = AlbumPicture._parser;
			uint num = default(uint);
			_parser = (MessageParser<UserPictures>)(object)FieldCodec.ForMessage<AlbumPicture>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
