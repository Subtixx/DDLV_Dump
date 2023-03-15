using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social.Ralph
{
	[Cpp2IlInjected.Token(Token = "0x2000DDA")]
	public sealed class PostCollection : IMessage<PostCollection>, IMessage, IEquatable<PostCollection>, IDeepCloneable<PostCollection>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40037F8")]
		private static readonly MessageParser<PostCollection> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40037F9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40037FA")]
		public const int PostsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40037FB")]
		private static readonly FieldCodec<Post> _repeated_posts_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037FC")]
		private readonly RepeatedField<Post> posts_ = (RepeatedField<Post>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170013E6")]
		[DebuggerNonUserCode]
		public static MessageParser<PostCollection> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007358")]
			[Cpp2IlInjected.Address(RVA = "0x7BF680", Offset = "0x7BE080", VA = "0x1807BF680")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007359")]
			[Cpp2IlInjected.Address(RVA = "0x7BF5B0", Offset = "0x7BDFB0", VA = "0x1807BF5B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600735A")]
			[Cpp2IlInjected.Address(RVA = "0x7BF6E0", Offset = "0x7BE0E0", VA = "0x1807BF6E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013E9")]
		[DebuggerNonUserCode]
		public RepeatedField<Post> Posts
		{
			[Cpp2IlInjected.Token(Token = "0x600735E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return posts_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600735B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF530", Offset = "0x7BDF30", VA = "0x1807BF530")]
		[DebuggerNonUserCode]
		public PostCollection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600735C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF430", Offset = "0x7BDE30", VA = "0x1807BF430")]
		[DebuggerNonUserCode]
		public PostCollection(PostCollection other)
		{
			RepeatedField<Post> repeatedField = (posts_ = (RepeatedField<Post>)(object)((RepeatedField<T>)(object)other.posts_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600735D")]
		[Cpp2IlInjected.Address(RVA = "0x7BEC50", Offset = "0x7BD650", VA = "0x1807BEC50", Slot = "10")]
		[DebuggerNonUserCode]
		public PostCollection Clone()
		{
			//Discarded unreachable code: IL_003b
			PostCollection postCollection = new PostCollection();
			RepeatedField<Post> repeatedField = (postCollection.posts_ = (RepeatedField<Post>)(object)new RepeatedField<T>());
			RepeatedField<Post> repeatedField2 = (postCollection.posts_ = (RepeatedField<Post>)(object)((RepeatedField<T>)(object)posts_).Clone());
			UnknownFieldSet unknownFieldSet = (postCollection._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return postCollection;
		}

		[Cpp2IlInjected.Token(Token = "0x600735F")]
		[Cpp2IlInjected.Address(RVA = "0x7BED80", Offset = "0x7BD780", VA = "0x1807BED80", Slot = "0")]
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
				RepeatedField<Post> repeatedField = posts_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007360")]
		[Cpp2IlInjected.Address(RVA = "0x7BEE60", Offset = "0x7BD860", VA = "0x1807BEE60", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PostCollection other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Post> repeatedField = posts_;
				RepeatedField<Post> repeatedField2 = other.posts_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007361")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)posts_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6007362")]
		[Cpp2IlInjected.Address(RVA = "0x7BF140", Offset = "0x7BDB40", VA = "0x1807BF140", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007363")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1A0", Offset = "0x7BDBA0", VA = "0x1807BF1A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Post> repeatedField = posts_;
			FieldCodec<Post> repeated_posts_codec = _repeated_posts_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_posts_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007364")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB40", Offset = "0x7BD540", VA = "0x1807BEB40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Post> repeatedField = posts_;
			FieldCodec<Post> repeated_posts_codec = _repeated_posts_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_posts_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6007365")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF70", Offset = "0x7BD970", VA = "0x1807BEF70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PostCollection other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Post> repeatedField = posts_;
				RepeatedField<Post> repeatedField2 = other.posts_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007366")]
		[Cpp2IlInjected.Address(RVA = "0x7BEFF0", Offset = "0x7BD9F0", VA = "0x1807BEFF0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Post> repeatedField = posts_;
					FieldCodec<Post> repeated_posts_codec = _repeated_posts_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_posts_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007367")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEF0", Offset = "0x7BD8F0", VA = "0x1807BEEF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Post> repeatedField = posts_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007368")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0E0", Offset = "0x7BDAE0", VA = "0x1807BF0E0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6007369")]
		[Cpp2IlInjected.Address(RVA = "0x7BEBF0", Offset = "0x7BD5F0", VA = "0x1807BEBF0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Post> repeatedField = posts_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600736A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF260", Offset = "0x7BDC60", VA = "0x1807BF260")]
		static PostCollection()
		{
			Func<PostCollection> func = default(Func<PostCollection>);
			_parser = (MessageParser<PostCollection>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Post> parser = Post._parser;
			uint num = default(uint);
			_parser = (MessageParser<PostCollection>)(object)FieldCodec.ForMessage<Post>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
