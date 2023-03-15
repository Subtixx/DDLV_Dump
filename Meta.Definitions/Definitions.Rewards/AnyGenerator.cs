using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x20001FB")]
	public sealed class AnyGenerator : IGenerator, IMessage<AnyGenerator>, IMessage, IEquatable<AnyGenerator>, IDeepCloneable<AnyGenerator>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20001FC")]
		public enum GeneratorOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			Any,
			[Cpp2IlInjected.Token(Token = "0x400081E")]
			Multi,
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			Weighted,
			[Cpp2IlInjected.Token(Token = "0x4000820")]
			Item,
			[Cpp2IlInjected.Token(Token = "0x4000821")]
			Null
		}

		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private static readonly MessageParser<AnyGenerator> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000814")]
		public const int AnyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000815")]
		public const int MultiFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000816")]
		public const int WeightedFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4000817")]
		public const int ItemFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4000818")]
		public const int NullFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private object generator_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private GeneratorOneofCase generatorCase_;

		[Cpp2IlInjected.Token(Token = "0x17000444")]
		[DebuggerNonUserCode]
		public static MessageParser<AnyGenerator> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001300")]
			[Cpp2IlInjected.Address(RVA = "0x26E3560", Offset = "0x26E1F60", VA = "0x1826E3560")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000445")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001301")]
			[Cpp2IlInjected.Address(RVA = "0x26E3360", Offset = "0x26E1D60", VA = "0x1826E3360")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000446")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001302")]
			[Cpp2IlInjected.Address(RVA = "0x26E3620", Offset = "0x26E2020", VA = "0x1826E3620", Slot = "10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000447")]
		[DebuggerNonUserCode]
		public AnyGenerator Any
		{
			[Cpp2IlInjected.Token(Token = "0x6001306")]
			[Cpp2IlInjected.Address(RVA = "0x26E3260", Offset = "0x26E1C60", VA = "0x1826E3260")]
			get
			{
				int num = 0;
				if (generatorCase_ == GeneratorOneofCase.Any)
				{
					object obj = generator_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001307")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				generator_ = value;
				bool flag = (byte)(generatorCase_ = ((value != null) ? GeneratorOneofCase.Any : GeneratorOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000448")]
		[DebuggerNonUserCode]
		public MultiGenerator Multi
		{
			[Cpp2IlInjected.Token(Token = "0x6001308")]
			[Cpp2IlInjected.Address(RVA = "0x26E34A0", Offset = "0x26E1EA0", VA = "0x1826E34A0")]
			get
			{
				int num = 0;
				if (generatorCase_ == GeneratorOneofCase.Multi)
				{
					object obj = generator_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001309")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				generator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000449")]
		[DebuggerNonUserCode]
		public WeightedGenerator Weighted
		{
			[Cpp2IlInjected.Token(Token = "0x600130A")]
			[Cpp2IlInjected.Address(RVA = "0x26E35C0", Offset = "0x26E1FC0", VA = "0x1826E35C0")]
			get
			{
				int num = 0;
				if (generatorCase_ == GeneratorOneofCase.Weighted)
				{
					object obj = generator_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600130B")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				generator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044A")]
		[DebuggerNonUserCode]
		public ItemGenerator Item
		{
			[Cpp2IlInjected.Token(Token = "0x600130C")]
			[Cpp2IlInjected.Address(RVA = "0x26E3440", Offset = "0x26E1E40", VA = "0x1826E3440")]
			get
			{
				int num = 0;
				if (generatorCase_ == GeneratorOneofCase.Item)
				{
					object obj = generator_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600130D")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D90", Offset = "0x5C4790", VA = "0x1805C5D90")]
			set
			{
				generator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044B")]
		[DebuggerNonUserCode]
		public NullGenerator Null
		{
			[Cpp2IlInjected.Token(Token = "0x600130E")]
			[Cpp2IlInjected.Address(RVA = "0x26E3500", Offset = "0x26E1F00", VA = "0x1826E3500")]
			get
			{
				int num = 0;
				if (generatorCase_ == GeneratorOneofCase.Null)
				{
					object obj = generator_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600130F")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				generator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044C")]
		[DebuggerNonUserCode]
		public GeneratorOneofCase GeneratorCase
		{
			[Cpp2IlInjected.Token(Token = "0x6001310")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return generatorCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044D")]
		[DebuggerNonUserCode]
		public IGenerator Generator
		{
			[Cpp2IlInjected.Token(Token = "0x6001312")]
			[Cpp2IlInjected.Address(RVA = "0x26E3430", Offset = "0x26E1E30", VA = "0x1826E3430")]
			get
			{
				return GetGenerator();
			}
			[Cpp2IlInjected.Token(Token = "0x6001313")]
			[Cpp2IlInjected.Address(RVA = "0x26E2AE0", Offset = "0x26E14E0", VA = "0x1826E2AE0")]
			set
			{
				//IL_002a: Expected I4, but got I8
				//IL_003b: Expected I4, but got I8
				//IL_004c: Expected I4, but got I8
				//IL_005d: Expected I4, but got I8
				//IL_006e: Expected I4, but got I8
				//IL_007d: Expected O, but got I4
				int num = 0;
				if (value != null)
				{
					if (value != null)
					{
						generator_ = value;
						generatorCase_ = GeneratorOneofCase.Any;
						return;
					}
					if (value != null)
					{
						generator_ = value;
						generatorCase_ = GeneratorOneofCase.Multi;
						return;
					}
					if (value != null)
					{
						generator_ = value;
						generatorCase_ = GeneratorOneofCase.Weighted;
						return;
					}
					if (value != null)
					{
						generator_ = value;
						generatorCase_ = GeneratorOneofCase.Item;
						return;
					}
					if (value != null)
					{
						generator_ = value;
						generatorCase_ = GeneratorOneofCase.Null;
						return;
					}
				}
				generatorCase_ = (GeneratorOneofCase)num;
				generator_ = num;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044E")]
		public IGenerator DefaultGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6001323")]
			[Cpp2IlInjected.Address(RVA = "0x26E32C0", Offset = "0x26E1CC0", VA = "0x1826E32C0")]
			get
			{
				NullGenerator _003CDefault_003Ek__BackingField = NullGenerator.Default;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001303")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AnyGenerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001304")]
		[Cpp2IlInjected.Address(RVA = "0x26E3060", Offset = "0x26E1A60", VA = "0x1826E3060")]
		[DebuggerNonUserCode]
		public AnyGenerator(AnyGenerator other)
		{
			//IL_0041: Expected I4, but got O
			//IL_005b: Expected I4, but got O
			//IL_0075: Expected I4, but got O
			//IL_0092: Expected I4, but got O
			GeneratorOneofCase generatorOneofCase = other.generatorCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (other != null)
						{
							if (generatorOneofCase != GeneratorOneofCase.Any)
							{
								goto IL_00b9;
							}
							generatorCase_ = (GeneratorOneofCase)(generator_ = other.Null.Clone());
						}
						generatorCase_ = (GeneratorOneofCase)(generator_ = other.Item.Clone());
					}
					generatorCase_ = (GeneratorOneofCase)(generator_ = other.Weighted.Clone());
				}
				generatorCase_ = (GeneratorOneofCase)(generator_ = other.Multi.Clone());
			}
			bool flag = (byte)(generatorCase_ = (((generator_ = new AnyGenerator(other.Any)) != null) ? GeneratorOneofCase.Any : GeneratorOneofCase.None)) != 0;
			goto IL_00b9;
			IL_00b9:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001305")]
		[Cpp2IlInjected.Address(RVA = "0x26E1670", Offset = "0x26E0070", VA = "0x1826E1670", Slot = "12")]
		[DebuggerNonUserCode]
		public AnyGenerator Clone()
		{
			return new AnyGenerator(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001311")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearGenerator()
		{
			//IL_0010: Expected O, but got I4
			generator_ = (generatorCase_ = GeneratorOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001314")]
		[Cpp2IlInjected.Address(RVA = "0x26E1BB0", Offset = "0x26E05B0", VA = "0x1826E1BB0")]
		[DebuggerNonUserCode]
		public IGenerator GetGenerator()
		{
			if (generatorCase_ != GeneratorOneofCase.Any)
			{
				NullGenerator _003CDefault_003Ek__BackingField = NullGenerator.Default;
			}
			NullGenerator @null = Null;
			ItemGenerator item = Item;
			WeightedGenerator weighted = Weighted;
			MultiGenerator multi = Multi;
			AnyGenerator any = Any;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001315")]
		[Cpp2IlInjected.Address(RVA = "0x26E2AE0", Offset = "0x26E14E0", VA = "0x1826E2AE0")]
		[DebuggerNonUserCode]
		public void SetGenerator(IGenerator value)
		{
			//IL_002a: Expected I4, but got I8
			//IL_003b: Expected I4, but got I8
			//IL_004c: Expected I4, but got I8
			//IL_005d: Expected I4, but got I8
			//IL_006e: Expected I4, but got I8
			//IL_007d: Expected O, but got I4
			int num = 0;
			if (value != null)
			{
				if (value != null)
				{
					generator_ = value;
					generatorCase_ = GeneratorOneofCase.Any;
					return;
				}
				if (value != null)
				{
					generator_ = value;
					generatorCase_ = GeneratorOneofCase.Multi;
					return;
				}
				if (value != null)
				{
					generator_ = value;
					generatorCase_ = GeneratorOneofCase.Weighted;
					return;
				}
				if (value != null)
				{
					generator_ = value;
					generatorCase_ = GeneratorOneofCase.Item;
					return;
				}
				if (value != null)
				{
					generator_ = value;
					generatorCase_ = GeneratorOneofCase.Null;
					return;
				}
			}
			generatorCase_ = (GeneratorOneofCase)num;
			generator_ = num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001316")]
		[Cpp2IlInjected.Address(RVA = "0x26E18C0", Offset = "0x26E02C0", VA = "0x1826E18C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((AnyGenerator)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001317")]
		[Cpp2IlInjected.Address(RVA = "0x26E1920", Offset = "0x26E0320", VA = "0x1826E1920", Slot = "11")]
		[DebuggerNonUserCode]
		public bool Equals(AnyGenerator other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (generatorCase_ == GeneratorOneofCase.Any)
				{
					object obj = generator_;
					if (obj != null && obj == null)
					{
						goto IL_00f6;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.generatorCase_ == GeneratorOneofCase.Any)
				{
					obj2 = other.generator_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					MultiGenerator multi = Multi;
					MultiGenerator multi2 = other.Multi;
					if (object.Equals(multi, multi2))
					{
						WeightedGenerator weighted = Weighted;
						WeightedGenerator weighted2 = other.Weighted;
						if (object.Equals(weighted, weighted2))
						{
							ItemGenerator item = Item;
							ItemGenerator item2 = other.Item;
							if (object.Equals(item, item2))
							{
								NullGenerator @null = Null;
								NullGenerator null2 = other.Null;
								if (object.Equals(@null, null2))
								{
									GeneratorOneofCase generatorOneofCase = other.generatorCase_;
									if (generatorCase_ == generatorOneofCase)
									{
										UnknownFieldSet unknownFields = other._unknownFields;
										bool flag = object.Equals(_unknownFields, unknownFields);
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00f6;
			IL_00f6:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001318")]
		[Cpp2IlInjected.Address(RVA = "0x26E1CC0", Offset = "0x26E06C0", VA = "0x1826E1CC0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00b7
			while (true)
			{
				GeneratorOneofCase generatorOneofCase = generatorCase_;
				int num = 0;
				if (generatorOneofCase == GeneratorOneofCase.Any)
				{
					object obj = generator_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (generatorOneofCase != GeneratorOneofCase.Multi)
				{
					continue;
				}
				object obj2 = generator_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (generatorCase_ != GeneratorOneofCase.Weighted)
					{
						continue;
					}
					object obj3 = generator_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (generatorCase_ != GeneratorOneofCase.Item)
						{
							continue;
						}
						object obj4 = generator_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (generatorCase_ == GeneratorOneofCase.Null)
							{
								object obj5 = generator_;
								if (obj5 == null)
								{
									break;
								}
								int hashCode5 = obj5.GetHashCode();
							}
							UnknownFieldSet unknownFields = _unknownFields;
							if (unknownFields != null)
							{
								int hashCode6 = unknownFields.GetHashCode();
							}
							return 1;
						}
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001319")]
		[Cpp2IlInjected.Address(RVA = "0x26E2C60", Offset = "0x26E1660", VA = "0x1826E2C60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600131A")]
		[Cpp2IlInjected.Address(RVA = "0x26E2CC0", Offset = "0x26E16C0", VA = "0x1826E2CC0", Slot = "8")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d6
			//IL_002f: Expected O, but got I4
			while (true)
			{
				GeneratorOneofCase generatorOneofCase = generatorCase_;
				int num = 0;
				if (generatorOneofCase == GeneratorOneofCase.Any)
				{
					if (generatorCase_ == GeneratorOneofCase.Any)
					{
						object obj = generator_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (generatorOneofCase != GeneratorOneofCase.Multi)
				{
					continue;
				}
				if (generatorCase_ == GeneratorOneofCase.Multi)
				{
					object obj2 = generator_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (generatorCase_ != GeneratorOneofCase.Weighted)
				{
					continue;
				}
				if (generatorCase_ == GeneratorOneofCase.Weighted)
				{
					object obj3 = generator_;
					if (obj3 != null && obj3 == null)
					{
						break;
					}
				}
				if (generatorCase_ != GeneratorOneofCase.Item)
				{
					continue;
				}
				if (generatorCase_ == GeneratorOneofCase.Item)
				{
					object obj4 = generator_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (generatorCase_ == GeneratorOneofCase.Null && generatorCase_ == GeneratorOneofCase.Null)
				{
					object obj5 = generator_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600131B")]
		[Cpp2IlInjected.Address(RVA = "0x26E12E0", Offset = "0x26DFCE0", VA = "0x1826E12E0", Slot = "9")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (generatorCase_ == GeneratorOneofCase.Any)
			{
				if (generatorCase_ == GeneratorOneofCase.Any)
				{
					object obj = generator_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (generatorCase_ == GeneratorOneofCase.Multi)
			{
				if (generatorCase_ != GeneratorOneofCase.Multi)
				{
				}
				object obj2 = generator_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (generatorCase_ == GeneratorOneofCase.Weighted)
			{
				if (generatorCase_ != GeneratorOneofCase.Weighted)
				{
				}
				object obj3 = generator_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (generatorCase_ == GeneratorOneofCase.Item)
			{
				if (generatorCase_ != GeneratorOneofCase.Item)
				{
				}
				object obj4 = generator_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (generatorCase_ == GeneratorOneofCase.Null)
			{
				if (generatorCase_ == GeneratorOneofCase.Null)
				{
					object obj5 = generator_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num += num7;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600131C")]
		[Cpp2IlInjected.Address(RVA = "0x26E2130", Offset = "0x26E0B30", VA = "0x1826E2130", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(AnyGenerator other)
		{
			//Discarded unreachable code: IL_016b
			//IL_0048: Expected I4, but got O
			//IL_007d: Expected I4, but got O
			//IL_00b6: Expected I4, but got O
			//IL_00ef: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			GeneratorOneofCase generatorOneofCase = other.generatorCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (other != null)
						{
							if (generatorOneofCase != GeneratorOneofCase.Any)
							{
								goto IL_014b;
							}
							if (Null == null)
							{
								generatorCase_ = (GeneratorOneofCase)(generator_ = new NullGenerator());
							}
							NullGenerator @null = Null;
							NullGenerator null2 = other.Null;
							@null.MergeFrom(null2);
						}
						if (Item == null)
						{
							generatorCase_ = (GeneratorOneofCase)(generator_ = new ItemGenerator());
						}
						ItemGenerator item = Item;
						ItemGenerator item2 = other.Item;
						item.MergeFrom(item2);
					}
					if (Weighted == null)
					{
						generatorCase_ = (GeneratorOneofCase)(generator_ = new WeightedGenerator());
					}
					WeightedGenerator weighted = Weighted;
					WeightedGenerator weighted2 = other.Weighted;
					weighted.MergeFrom(weighted2);
				}
				if (Multi == null)
				{
					generatorCase_ = (GeneratorOneofCase)(generator_ = new MultiGenerator());
				}
				MultiGenerator multi = Multi;
				MultiGenerator multi2 = other.Multi;
				multi.MergeFrom(multi2);
			}
			if (Any == null)
			{
				bool flag = (byte)(generatorCase_ = (((generator_ = new AnyGenerator()) != null) ? GeneratorOneofCase.Any : GeneratorOneofCase.None)) != 0;
			}
			AnyGenerator any = Any;
			AnyGenerator any2 = other.Any;
			any.MergeFrom(any2);
			goto IL_014b;
			IL_014b:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600131D")]
		[Cpp2IlInjected.Address(RVA = "0x26E2440", Offset = "0x26E0E40", VA = "0x1826E2440", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00a9: Expected I4, but got O
			//IL_0100: Expected I4, but got O
			//IL_01a1: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					WeightedGenerator weightedGenerator = new WeightedGenerator();
					if (generatorCase_ == GeneratorOneofCase.Weighted)
					{
						if (generatorCase_ != GeneratorOneofCase.Weighted)
						{
						}
						object obj = generator_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(weightedGenerator);
					generator_ = weightedGenerator;
					generatorCase_ = (GeneratorOneofCase)weightedGenerator;
				}
				if (num == 34)
				{
					ItemGenerator builder = new ItemGenerator();
					if (generatorCase_ == GeneratorOneofCase.Item)
					{
						if (generatorCase_ != GeneratorOneofCase.Item)
						{
						}
						object obj2 = generator_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					generator_ = builder;
					generatorCase_ = (GeneratorOneofCase)typeof(ItemGenerator).TypeHandle;
				}
				if ((long)typeof(ItemGenerator).TypeHandle != 42)
				{
					goto IL_01a1;
				}
				NullGenerator builder2 = new NullGenerator();
				if (generatorCase_ == GeneratorOneofCase.Null)
				{
					if (generatorCase_ != GeneratorOneofCase.Null)
					{
					}
					object obj3 = generator_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				generator_ = builder2;
				generatorCase_ = (GeneratorOneofCase)typeof(NullGenerator).TypeHandle;
			}
			bool flag = default(bool);
			if (num == 10)
			{
				AnyGenerator anyGenerator = new AnyGenerator();
				if (generatorCase_ == GeneratorOneofCase.Any)
				{
					if (generatorCase_ != GeneratorOneofCase.Any)
					{
					}
					object obj4 = generator_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(anyGenerator);
				generator_ = anyGenerator;
				flag = (byte)(generatorCase_ = ((anyGenerator != null) ? GeneratorOneofCase.Any : GeneratorOneofCase.None)) != 0;
			}
			if (flag)
			{
				MultiGenerator builder3 = new MultiGenerator();
				if (generatorCase_ == GeneratorOneofCase.Multi)
				{
					if (generatorCase_ != GeneratorOneofCase.Multi)
					{
					}
					object obj5 = generator_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				generator_ = builder3;
				generatorCase_ = (GeneratorOneofCase)typeof(MultiGenerator).TypeHandle;
			}
			goto IL_01a1;
			IL_01a1:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600131E")]
		[Cpp2IlInjected.Address(RVA = "0x26E1AE0", Offset = "0x26E04E0", VA = "0x1826E1AE0", Slot = "13")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				NullGenerator @null = Null;
				ItemGenerator item = Item;
				WeightedGenerator weighted = Weighted;
				MultiGenerator multi = Multi;
				AnyGenerator any = Any;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600131F")]
		[Cpp2IlInjected.Address(RVA = "0x26E28B0", Offset = "0x26E12B0", VA = "0x1826E28B0", Slot = "14")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0032: Expected O, but got I4
			//IL_003d: Expected I4, but got O
			//IL_005b: Expected I4, but got O
			//IL_0076: Expected I4, but got O
			//IL_0091: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							int num2 = 0;
							if (value == null || value != null)
							{
								generator_ = num2;
								generatorCase_ = (GeneratorOneofCase)typeof(WeightedGenerator).TypeHandle;
								break;
							}
							throw new InvalidCastException();
						}
						case 0:
							if (value == null || value != null)
							{
								generator_ = value;
								generatorCase_ = (GeneratorOneofCase)typeof(WeightedGenerator).TypeHandle;
								break;
							}
							throw new InvalidCastException();
						}
					}
					else
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						generator_ = value;
						generatorCase_ = (GeneratorOneofCase)typeof(WeightedGenerator).TypeHandle;
					}
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					generator_ = value;
					generatorCase_ = (GeneratorOneofCase)typeof(WeightedGenerator).TypeHandle;
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				generator_ = value;
				bool flag = (byte)(generatorCase_ = ((value != null) ? GeneratorOneofCase.Any : GeneratorOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001320")]
		[Cpp2IlInjected.Address(RVA = "0x26E15B0", Offset = "0x26DFFB0", VA = "0x1826E15B0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				generator_ = num;
				generatorCase_ = (GeneratorOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001321")]
		[Cpp2IlInjected.Address(RVA = "0x26E1F40", Offset = "0x26E0940", VA = "0x1826E1F40", Slot = "16")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "generator"))
			{
				GeneratorOneofCase generatorOneofCase = generatorCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001322")]
		[Cpp2IlInjected.Address(RVA = "0x26E1600", Offset = "0x26E0000", VA = "0x1826E1600", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "generator"))
			{
				generator_ = (generatorCase_ = GeneratorOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001324")]
		[Cpp2IlInjected.Address(RVA = "0x26E17D0", Offset = "0x26E01D0", VA = "0x1826E17D0")]
		public bool IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_001f
			IGenerator generator = GetGenerator();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return generator.IsValid(ref playerProfile, ref worldProfile, (List<>)(object)items);
		}

		[Cpp2IlInjected.Token(Token = "0x6001325")]
		[Cpp2IlInjected.Address(RVA = "0x26E16D0", Offset = "0x26E00D0", VA = "0x1826E16D0")]
		public IReward Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0017
			IGenerator generator = GetGenerator();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			IReward result = default(IReward);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001326")]
		[Cpp2IlInjected.Address(RVA = "0x26E2090", Offset = "0x26E0A90", VA = "0x1826E2090")]
		public static AnyGenerator MakeWeighted()
		{
			//Discarded unreachable code: IL_001c
			//IL_001a: Expected I4, but got O
			AnyGenerator anyGenerator = new AnyGenerator();
			anyGenerator.generatorCase_ = (GeneratorOneofCase)(anyGenerator.generator_ = new WeightedGenerator());
			return anyGenerator;
		}

		[Cpp2IlInjected.Token(Token = "0x6001327")]
		[Cpp2IlInjected.Address(RVA = "0x26E1FF0", Offset = "0x26E09F0", VA = "0x1826E1FF0")]
		public static AnyGenerator MakeMulti()
		{
			//Discarded unreachable code: IL_001c
			//IL_001a: Expected I4, but got O
			AnyGenerator anyGenerator = new AnyGenerator();
			anyGenerator.generatorCase_ = (GeneratorOneofCase)(anyGenerator.generator_ = new MultiGenerator());
			return anyGenerator;
		}

		[Cpp2IlInjected.Token(Token = "0x6001328")]
		[Cpp2IlInjected.Address(RVA = "0x26E2F50", Offset = "0x26E1950", VA = "0x1826E2F50")]
		static AnyGenerator()
		{
			Func<AnyGenerator> func = default(Func<AnyGenerator>);
			_parser = (MessageParser<AnyGenerator>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001329")]
		[Cpp2IlInjected.Address(RVA = "0x26E17D0", Offset = "0x26E01D0", VA = "0x1826E17D0", Slot = "4")]
		bool IGenerator.IsValid(in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_001f
			IGenerator generator = GetGenerator();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return generator.IsValid(ref playerProfile, ref worldProfile, (List<>)(object)items);
		}

		[Cpp2IlInjected.Token(Token = "0x600132A")]
		[Cpp2IlInjected.Address(RVA = "0x26E16D0", Offset = "0x26E00D0", VA = "0x1826E16D0", Slot = "5")]
		IReward IGenerator.Generate(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, List<ItemWithState> items)
		{
			//Discarded unreachable code: IL_0017
			IGenerator generator = GetGenerator();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			IReward result = default(IReward);
			return result;
		}
	}
}
