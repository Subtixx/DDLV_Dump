using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005BA")]
	public sealed class CollectionCrafting : IMessage<CollectionCrafting>, IMessage, IEquatable<CollectionCrafting>, IDeepCloneable<CollectionCrafting>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20005BB")]
		public enum CollectionCraftingTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001F49")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001F4A")]
			MaterialBasic,
			[Cpp2IlInjected.Token(Token = "0x4001F4B")]
			RecipeType
		}

		[Cpp2IlInjected.Token(Token = "0x4001F42")]
		private static readonly MessageParser<CollectionCrafting> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F43")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F44")]
		public const int MaterialBasicFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001F45")]
		public const int RecipeTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F46")]
		private object collectionCraftingType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F47")]
		private CollectionCraftingTypeOneofCase collectionCraftingTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x1700127D")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionCrafting> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004782")]
			[Cpp2IlInjected.Address(RVA = "0x2EC8E30", Offset = "0x2EC7830", VA = "0x182EC8E30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700127E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004783")]
			[Cpp2IlInjected.Address(RVA = "0x2EC8D00", Offset = "0x2EC7700", VA = "0x182EC8D00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700127F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004784")]
			[Cpp2IlInjected.Address(RVA = "0x2EC8F00", Offset = "0x2EC7900", VA = "0x182EC8F00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001280")]
		[DebuggerNonUserCode]
		public Empty MaterialBasic
		{
			[Cpp2IlInjected.Token(Token = "0x6004788")]
			[Cpp2IlInjected.Address(RVA = "0x2EC8DD0", Offset = "0x2EC77D0", VA = "0x182EC8DD0")]
			get
			{
				int num = 0;
				if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
				{
					object obj = collectionCraftingType_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004789")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				collectionCraftingType_ = value;
				bool flag = (byte)(collectionCraftingTypeCase_ = ((value != null) ? CollectionCraftingTypeOneofCase.MaterialBasic : CollectionCraftingTypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001281")]
		[DebuggerNonUserCode]
		public int RecipeType
		{
			[Cpp2IlInjected.Token(Token = "0x600478A")]
			[Cpp2IlInjected.Address(RVA = "0x2EC8E90", Offset = "0x2EC7890", VA = "0x182EC8E90")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.RecipeType)
				{
					object obj = collectionCraftingType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x600478B")]
			[Cpp2IlInjected.Address(RVA = "0x2EC9010", Offset = "0x2EC7A10", VA = "0x182EC9010")]
			set
			{
				//IL_0014: Expected I4, but got I8
				collectionCraftingType_ = typeof(int).TypeHandle;
				collectionCraftingTypeCase_ = CollectionCraftingTypeOneofCase.RecipeType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001282")]
		[DebuggerNonUserCode]
		public CollectionCraftingTypeOneofCase CollectionCraftingTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x600478C")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return collectionCraftingTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004785")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectionCrafting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004786")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8C00", Offset = "0x2EC7600", VA = "0x182EC8C00")]
		[DebuggerNonUserCode]
		public CollectionCrafting(CollectionCrafting other)
		{
			CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase = other.collectionCraftingTypeCase_;
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.MaterialBasic)
			{
				CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase2 = other.collectionCraftingTypeCase_;
				if (other.collectionCraftingType_ == null)
				{
					throw new InvalidCastException();
				}
				Empty empty = default(Empty);
				collectionCraftingType_ = empty;
				bool flag = (byte)(collectionCraftingTypeCase_ = ((empty != null) ? CollectionCraftingTypeOneofCase.MaterialBasic : CollectionCraftingTypeOneofCase.None)) != 0;
			}
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.RecipeType)
			{
				int num = (RecipeType = other.RecipeType);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004787")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7EC0", Offset = "0x2EC68C0", VA = "0x182EC7EC0", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionCrafting Clone()
		{
			//Discarded unreachable code: IL_0064
			CollectionCrafting collectionCrafting = new CollectionCrafting();
			CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase = collectionCraftingTypeCase_;
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.MaterialBasic)
			{
				CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase2 = collectionCraftingTypeCase_;
				if (collectionCraftingType_ == null)
				{
					throw new InvalidCastException();
				}
				Empty empty = default(Empty);
				collectionCrafting.collectionCraftingType_ = empty;
				bool flag = (byte)(collectionCrafting.collectionCraftingTypeCase_ = ((empty != null) ? CollectionCraftingTypeOneofCase.MaterialBasic : CollectionCraftingTypeOneofCase.None)) != 0;
			}
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.RecipeType)
			{
				int num = (collectionCrafting.RecipeType = RecipeType);
			}
			UnknownFieldSet unknownFieldSet = (collectionCrafting._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionCrafting;
		}

		[Cpp2IlInjected.Token(Token = "0x600478D")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearCollectionCraftingType()
		{
			//IL_0010: Expected O, but got I4
			collectionCraftingType_ = (collectionCraftingTypeCase_ = CollectionCraftingTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600478E")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8120", Offset = "0x2EC6B20", VA = "0x182EC8120", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0069: Expected O, but got I4
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
					{
						object obj = collectionCraftingType_;
						if (obj != null && obj == null)
						{
							goto IL_006e;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(Empty).TypeHandle != null && (object)typeof(Empty).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						int recipeType = RecipeType;
						int num2 = 0;
						int num3 = default(int);
						if (recipeType == num3 && collectionCraftingTypeCase_ == (CollectionCraftingTypeOneofCase)num3)
						{
							bool flag2 = object.Equals(_unknownFields, num2);
						}
					}
				}
			}
			int num4 = 0;
			goto IL_006e;
			IL_006e:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600478F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8000", Offset = "0x2EC6A00", VA = "0x182EC8000", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionCrafting other)
		{
			//IL_004d: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
				{
					object obj = collectionCraftingType_;
					if (obj != null && obj == null)
					{
						goto IL_0090;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
				{
					obj2 = other.collectionCraftingType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					int recipeType = RecipeType;
					int recipeType2 = other.RecipeType;
					if (recipeType == recipeType2)
					{
						CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase = other.collectionCraftingTypeCase_;
						if (collectionCraftingTypeCase_ == collectionCraftingTypeOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							bool flag = object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0090;
			IL_0090:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004790")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8390", Offset = "0x2EC6D90", VA = "0x182EC8390", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004c
			CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase = collectionCraftingTypeCase_;
			int num = 0;
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.MaterialBasic)
			{
				object obj = collectionCraftingType_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.RecipeType && collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.RecipeType)
			{
				object obj2 = collectionCraftingType_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004791")]
		[Cpp2IlInjected.Address(RVA = "0x2EC89B0", Offset = "0x2EC73B0", VA = "0x182EC89B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004792")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8A10", Offset = "0x2EC7410", VA = "0x182EC8A10", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0054
			//IL_002c: Expected O, but got I4
			CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase = collectionCraftingTypeCase_;
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.MaterialBasic)
			{
				int num = 0;
				if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
				{
					object obj = collectionCraftingType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.RecipeType)
			{
				int recipeType = RecipeType;
				output.WriteInt32(recipeType);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004793")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7C60", Offset = "0x2EC6660", VA = "0x182EC7C60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0069
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
			{
				if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
				{
					object obj = collectionCraftingType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.RecipeType)
			{
				if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.RecipeType)
				{
					object obj2 = collectionCraftingType_;
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004794")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8570", Offset = "0x2EC6F70", VA = "0x182EC8570", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionCrafting other)
		{
			if (other == null)
			{
				return;
			}
			CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase = other.collectionCraftingTypeCase_;
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.MaterialBasic)
			{
				CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase2 = collectionCraftingTypeCase_;
				int num = 0;
				if (collectionCraftingTypeOneofCase2 == CollectionCraftingTypeOneofCase.MaterialBasic)
				{
					object obj = collectionCraftingType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(collectionCraftingTypeCase_ = (((collectionCraftingType_ = new Empty()) != null) ? CollectionCraftingTypeOneofCase.MaterialBasic : CollectionCraftingTypeOneofCase.None)) != 0;
				}
				if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
				{
					object obj2 = collectionCraftingType_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
				{
					object obj3 = other.collectionCraftingType_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if (collectionCraftingTypeOneofCase == CollectionCraftingTypeOneofCase.RecipeType)
			{
				int num2 = (RecipeType = other.RecipeType);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004795")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8750", Offset = "0x2EC7150", VA = "0x182EC8750", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Empty empty = new Empty();
				if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
				{
					if (collectionCraftingTypeCase_ != CollectionCraftingTypeOneofCase.MaterialBasic)
					{
					}
					object obj = collectionCraftingType_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(empty);
				collectionCraftingType_ = empty;
				bool flag = (byte)(collectionCraftingTypeCase_ = ((empty != null) ? CollectionCraftingTypeOneofCase.MaterialBasic : CollectionCraftingTypeOneofCase.None)) != 0;
			}
			if (num == 16)
			{
				int num3 = (RecipeType = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004796")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8280", Offset = "0x2EC6C80", VA = "0x182EC8280", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
				goto IL_001c;
			}
			if (collectionCraftingTypeCase_ == CollectionCraftingTypeOneofCase.MaterialBasic)
			{
				object obj = collectionCraftingType_;
				if (obj != null)
				{
					if (obj != null)
					{
						goto IL_001c;
					}
					goto IL_0037;
				}
			}
			goto IL_0027;
			IL_001c:
			if (fieldNumber == 2)
			{
				int recipeType = RecipeType;
			}
			goto IL_0027;
			IL_0037:
			throw new InvalidCastException();
			IL_0027:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_0037;
		}

		[Cpp2IlInjected.Token(Token = "0x6004797")]
		[Cpp2IlInjected.Address(RVA = "0x2EC88C0", Offset = "0x2EC72C0", VA = "0x182EC88C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002a
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				collectionCraftingType_ = num;
				bool flag = (byte)(collectionCraftingTypeCase_ = ((num != 0) ? CollectionCraftingTypeOneofCase.MaterialBasic : CollectionCraftingTypeOneofCase.None)) != 0;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004798")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7DC0", Offset = "0x2EC67C0", VA = "0x182EC7DC0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_0019: Expected O, but got I4
			//IL_0022: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				collectionCraftingTypeCase_ = CollectionCraftingTypeOneofCase.None;
				break;
			case 2:
			{
				int num = default(int);
				collectionCraftingType_ = num;
				collectionCraftingTypeCase_ = CollectionCraftingTypeOneofCase.RecipeType;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004799")]
		[Cpp2IlInjected.Address(RVA = "0x2EC84C0", Offset = "0x2EC6EC0", VA = "0x182EC84C0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "CollectionCraftingType"))
			{
				CollectionCraftingTypeOneofCase collectionCraftingTypeOneofCase = collectionCraftingTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600479A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7E50", Offset = "0x2EC6850", VA = "0x182EC7E50", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "CollectionCraftingType"))
			{
				collectionCraftingType_ = (collectionCraftingTypeCase_ = CollectionCraftingTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600479B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8AF0", Offset = "0x2EC74F0", VA = "0x182EC8AF0")]
		static CollectionCrafting()
		{
			Func<CollectionCrafting> func = default(Func<CollectionCrafting>);
			_parser = (MessageParser<CollectionCrafting>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
