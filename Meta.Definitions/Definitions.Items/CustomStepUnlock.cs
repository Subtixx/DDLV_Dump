using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000465")]
	public sealed class CustomStepUnlock : IMessage<CustomStepUnlock>, IMessage, IEquatable<CustomStepUnlock>, IDeepCloneable<CustomStepUnlock>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount, IStringTag, IBuildingMapMarker, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000466")]
		public enum TypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40017CD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40017CE")]
			Building,
			[Cpp2IlInjected.Token(Token = "0x40017CF")]
			Area,
			[Cpp2IlInjected.Token(Token = "0x40017D0")]
			Realm,
			[Cpp2IlInjected.Token(Token = "0x40017D1")]
			Tool,
			[Cpp2IlInjected.Token(Token = "0x40017D2")]
			MemoryShard,
			[Cpp2IlInjected.Token(Token = "0x40017D3")]
			Recipe
		}

		[Cpp2IlInjected.Token(Token = "0x40017C2")]
		private static readonly MessageParser<CustomStepUnlock> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40017C3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40017C4")]
		public const int BuildingFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40017C5")]
		public const int AreaFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40017C6")]
		public const int RealmFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40017C7")]
		public const int ToolFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40017C8")]
		public const int MemoryShardFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40017C9")]
		public const int RecipeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40017CA")]
		private object type_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40017CB")]
		private TypeOneofCase typeCase_;

		[Cpp2IlInjected.Token(Token = "0x17000DBD")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepUnlock> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60035F3")]
			[Cpp2IlInjected.Address(RVA = "0x355F950", Offset = "0x355E350", VA = "0x18355F950")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60035F4")]
			[Cpp2IlInjected.Address(RVA = "0x355F820", Offset = "0x355E220", VA = "0x18355F820")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DBF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60035F5")]
			[Cpp2IlInjected.Address(RVA = "0x355FEA0", Offset = "0x355E8A0", VA = "0x18355FEA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC0")]
		[DebuggerNonUserCode]
		public TargetBuildingType Building
		{
			[Cpp2IlInjected.Token(Token = "0x60035FA")]
			[Cpp2IlInjected.Address(RVA = "0x355F7C0", Offset = "0x355E1C0", VA = "0x18355F7C0")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.Building)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60035FB")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				type_ = value;
				bool flag = (byte)(typeCase_ = ((value != null) ? TypeOneofCase.Building : TypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC1")]
		[DebuggerNonUserCode]
		public TargetArea Area
		{
			[Cpp2IlInjected.Token(Token = "0x60035FC")]
			[Cpp2IlInjected.Address(RVA = "0x355F760", Offset = "0x355E160", VA = "0x18355F760")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.Area)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60035FD")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D10", Offset = "0x5C4710", VA = "0x1805C5D10")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC2")]
		[DebuggerNonUserCode]
		public TargetRealm Realm
		{
			[Cpp2IlInjected.Token(Token = "0x60035FE")]
			[Cpp2IlInjected.Address(RVA = "0x355F9B0", Offset = "0x355E3B0", VA = "0x18355F9B0")]
			get
			{
				if (typeCase_ == TypeOneofCase.Realm)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60035FF")]
			[Cpp2IlInjected.Address(RVA = "0x5C5E90", Offset = "0x5C4890", VA = "0x1805C5E90")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC3")]
		[DebuggerNonUserCode]
		public int Tool
		{
			[Cpp2IlInjected.Token(Token = "0x6003600")]
			[Cpp2IlInjected.Address(RVA = "0x355FE30", Offset = "0x355E830", VA = "0x18355FE30")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (typeCase_ == TypeOneofCase.Tool)
				{
					object obj = type_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003601")]
			[Cpp2IlInjected.Address(RVA = "0x3560020", Offset = "0x355EA20", VA = "0x183560020")]
			set
			{
				//IL_0014: Expected I4, but got I8
				type_ = typeof(int).TypeHandle;
				typeCase_ = TypeOneofCase.Tool;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC4")]
		[DebuggerNonUserCode]
		public TargetMemoryShard MemoryShard
		{
			[Cpp2IlInjected.Token(Token = "0x6003602")]
			[Cpp2IlInjected.Address(RVA = "0x355F8F0", Offset = "0x355E2F0", VA = "0x18355F8F0")]
			get
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.MemoryShard)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003603")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC5")]
		[DebuggerNonUserCode]
		public int Recipe
		{
			[Cpp2IlInjected.Token(Token = "0x6003604")]
			[Cpp2IlInjected.Address(RVA = "0x355FAC0", Offset = "0x355E4C0", VA = "0x18355FAC0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (typeCase_ == TypeOneofCase.Recipe)
				{
					object obj = type_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003605")]
			[Cpp2IlInjected.Address(RVA = "0x355FFB0", Offset = "0x355E9B0", VA = "0x18355FFB0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				type_ = typeof(int).TypeHandle;
				typeCase_ = TypeOneofCase.Recipe;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC6")]
		[DebuggerNonUserCode]
		public TypeOneofCase TypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003606")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return typeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC7")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003615")]
			[Cpp2IlInjected.Address(RVA = "0x355FB30", Offset = "0x355E530", VA = "0x18355FB30", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_001b
				if (typeCase_ != TypeOneofCase.Building)
				{
					return new StepAmount(1);
				}
				StepAmount result = default(StepAmount);
				if (type_ != null)
				{
					return result;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC8")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003616")]
			[Cpp2IlInjected.Address(RVA = "0x355FBE0", Offset = "0x355E5E0", VA = "0x18355FBE0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_005d
				string[] array;
				while (true)
				{
					array = new string[3];
					if ("TargetName" != null && "TargetName" == null)
					{
						continue;
					}
					array[0] = "TargetName";
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[1] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[2] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DC9")]
		public Item ToolItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003617")]
			[Cpp2IlInjected.Address(RVA = "0x355FD80", Offset = "0x355E780", VA = "0x18355FD80")]
			get
			{
				if (typeCase_ == TypeOneofCase.Tool)
				{
					object obj = type_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCA")]
		public Item RecipeItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003618")]
			[Cpp2IlInjected.Address(RVA = "0x355FA10", Offset = "0x355E410", VA = "0x18355FA10")]
			get
			{
				if (typeCase_ == TypeOneofCase.Recipe)
				{
					object obj = type_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035F6")]
		[Cpp2IlInjected.Address(RVA = "0x355F6F0", Offset = "0x355E0F0", VA = "0x18355F6F0")]
		[DebuggerNonUserCode]
		public CustomStepUnlock()
		{
			bool flag = (byte)(typeCase_ = (((type_ = new TargetBuildingType()) != null) ? TypeOneofCase.Building : TypeOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60035F7")]
		[Cpp2IlInjected.Address(RVA = "0x355ED60", Offset = "0x355D760", VA = "0x18355ED60")]
		private void OnConstruction()
		{
			bool flag = (byte)(typeCase_ = (((type_ = new TargetBuildingType()) != null) ? TypeOneofCase.Building : TypeOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60035F8")]
		[Cpp2IlInjected.Address(RVA = "0x355F4D0", Offset = "0x355DED0", VA = "0x18355F4D0")]
		[DebuggerNonUserCode]
		public CustomStepUnlock(CustomStepUnlock other)
		{
			//IL_006d: Expected I4, but got O
			//IL_008a: Expected I4, but got O
			//IL_00b7: Expected I4, but got O
			bool flag = (byte)(typeCase_ = (((type_ = new TargetBuildingType()) != null) ? TypeOneofCase.Building : TypeOneofCase.None)) != 0;
			if (other.typeCase_ <= TypeOneofCase.MemoryShard)
			{
				bool flag2 = (byte)(typeCase_ = (((type_ = other.Building.Clone()) != null) ? TypeOneofCase.Building : TypeOneofCase.None)) != 0;
				typeCase_ = (TypeOneofCase)(type_ = other.Area.Clone());
				typeCase_ = (TypeOneofCase)(type_ = other.Realm.Clone());
				int num = (Tool = other.Tool);
				typeCase_ = (TypeOneofCase)(type_ = other.MemoryShard.Clone());
				int num2 = (Recipe = other.Recipe);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035F9")]
		[Cpp2IlInjected.Address(RVA = "0x355D3A0", Offset = "0x355BDA0", VA = "0x18355D3A0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepUnlock Clone()
		{
			return new CustomStepUnlock(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003607")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearType()
		{
			//IL_0010: Expected O, but got I4
			type_ = (typeCase_ = TypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003608")]
		[Cpp2IlInjected.Address(RVA = "0x355DE50", Offset = "0x355C850", VA = "0x18355DE50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CustomStepUnlock)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003609")]
		[Cpp2IlInjected.Address(RVA = "0x355DC90", Offset = "0x355C690", VA = "0x18355DC90", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepUnlock other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (typeCase_ == TypeOneofCase.Building)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						goto IL_0106;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.typeCase_ == TypeOneofCase.Building)
				{
					obj2 = other.type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					TargetArea area = Area;
					TargetArea area2 = other.Area;
					if (object.Equals(area, area2))
					{
						TargetRealm realm = Realm;
						TargetRealm realm2 = other.Realm;
						if (object.Equals(realm, realm2))
						{
							int tool = Tool;
							int tool2 = other.Tool;
							if (tool == tool2)
							{
								TargetMemoryShard memoryShard = MemoryShard;
								TargetMemoryShard memoryShard2 = other.MemoryShard;
								if (object.Equals(memoryShard, memoryShard2))
								{
									int recipe = Recipe;
									int recipe2 = other.Recipe;
									if (recipe == recipe2)
									{
										TypeOneofCase typeOneofCase = other.typeCase_;
										if (typeCase_ == typeOneofCase)
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
			}
			int num2 = 0;
			goto IL_0106;
			IL_0106:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600360A")]
		[Cpp2IlInjected.Address(RVA = "0x355E230", Offset = "0x355CC30", VA = "0x18355E230", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00cf
			while (true)
			{
				TypeOneofCase typeOneofCase = typeCase_;
				int num = 0;
				if (typeOneofCase == TypeOneofCase.Building)
				{
					object obj = type_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (typeOneofCase != TypeOneofCase.Area)
				{
					continue;
				}
				object obj2 = type_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (typeCase_ != TypeOneofCase.Realm)
					{
						continue;
					}
					object obj3 = type_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (typeCase_ == TypeOneofCase.Tool)
						{
							if (typeCase_ != TypeOneofCase.Tool)
							{
							}
							object obj4 = type_;
						}
						if (typeCase_ == TypeOneofCase.MemoryShard)
						{
							object obj5 = type_;
							if (obj5 == null)
							{
								break;
							}
							int hashCode4 = obj5.GetHashCode();
							if (typeCase_ == TypeOneofCase.Recipe && typeCase_ == TypeOneofCase.Recipe)
							{
								object obj6 = type_;
							}
							UnknownFieldSet unknownFields = _unknownFields;
							if (unknownFields != null)
							{
								int hashCode5 = unknownFields.GetHashCode();
							}
							return 1;
						}
						continue;
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600360B")]
		[Cpp2IlInjected.Address(RVA = "0x355F050", Offset = "0x355DA50", VA = "0x18355F050", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600360C")]
		[Cpp2IlInjected.Address(RVA = "0x355F140", Offset = "0x355DB40", VA = "0x18355F140", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00e7
			//IL_002f: Expected O, but got I4
			while (true)
			{
				TypeOneofCase typeOneofCase = typeCase_;
				int num = 0;
				if (typeOneofCase == TypeOneofCase.Building)
				{
					if (typeCase_ == TypeOneofCase.Building)
					{
						object obj = type_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (typeOneofCase != TypeOneofCase.Area)
				{
					continue;
				}
				if (typeCase_ == TypeOneofCase.Area)
				{
					object obj2 = type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (typeCase_ != TypeOneofCase.Realm)
				{
					continue;
				}
				if (typeCase_ == TypeOneofCase.Realm)
				{
					object obj3 = type_;
					if (obj3 != null && obj3 == null)
					{
						break;
					}
				}
				if (typeCase_ != TypeOneofCase.Tool)
				{
					continue;
				}
				int tool = Tool;
				output.WriteInt32(tool);
				if (typeCase_ != TypeOneofCase.MemoryShard)
				{
					continue;
				}
				if (typeCase_ == TypeOneofCase.MemoryShard)
				{
					object obj4 = type_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (typeCase_ == TypeOneofCase.Recipe)
				{
					int recipe = Recipe;
					output.WriteInt32(recipe);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600360D")]
		[Cpp2IlInjected.Address(RVA = "0x355CF30", Offset = "0x355B930", VA = "0x18355CF30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_011a
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (typeCase_ == TypeOneofCase.Building)
			{
				if (typeCase_ == TypeOneofCase.Building)
				{
					object obj = type_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (typeCase_ == TypeOneofCase.Area)
			{
				if (typeCase_ != TypeOneofCase.Area)
				{
				}
				object obj2 = type_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (typeCase_ == TypeOneofCase.Realm)
			{
				if (typeCase_ != TypeOneofCase.Realm)
				{
				}
				object obj3 = type_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (typeCase_ == TypeOneofCase.Tool)
			{
				if (typeCase_ != TypeOneofCase.Tool)
				{
				}
				object obj4 = type_;
				num++;
				int num5 = default(int);
				num += num5;
			}
			if (typeCase_ == TypeOneofCase.MemoryShard)
			{
				if (typeCase_ != TypeOneofCase.MemoryShard)
				{
				}
				object obj5 = type_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num6 = default(int);
				num += num6;
			}
			if (typeCase_ == TypeOneofCase.Recipe)
			{
				if (typeCase_ == TypeOneofCase.Recipe)
				{
					object obj6 = type_;
				}
				num++;
				int num7 = default(int);
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600360E")]
		[Cpp2IlInjected.Address(RVA = "0x355E6B0", Offset = "0x355D0B0", VA = "0x18355E6B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepUnlock other)
		{
			//Discarded unreachable code: IL_0138
			//IL_006d: Expected I4, but got O
			//IL_00a6: Expected I4, but got O
			//IL_00ef: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if (other.typeCase_ <= TypeOneofCase.MemoryShard)
			{
				if (Building == null)
				{
					bool flag = (byte)(typeCase_ = (((type_ = new TargetBuildingType()) != null) ? TypeOneofCase.Building : TypeOneofCase.None)) != 0;
				}
				TargetBuildingType building = Building;
				TargetBuildingType building2 = other.Building;
				building.MergeFrom(building2);
				if (Area == null)
				{
					typeCase_ = (TypeOneofCase)(type_ = new TargetArea());
				}
				TargetArea area = Area;
				TargetArea area2 = other.Area;
				area.MergeFrom(area2);
				if (Realm == null)
				{
					typeCase_ = (TypeOneofCase)(type_ = new TargetRealm());
				}
				TargetRealm realm = Realm;
				TargetRealm realm2 = other.Realm;
				realm.MergeFrom(realm2);
				int num = (Tool = other.Tool);
				if (MemoryShard == null)
				{
					typeCase_ = (TypeOneofCase)(type_ = new TargetMemoryShard());
				}
				TargetMemoryShard memoryShard = MemoryShard;
				TargetMemoryShard memoryShard2 = other.MemoryShard;
				memoryShard.MergeFrom(memoryShard2);
				int num2 = (Recipe = other.Recipe);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600360F")]
		[Cpp2IlInjected.Address(RVA = "0x355E980", Offset = "0x355D380", VA = "0x18355E980", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0075: Expected I4, but got O
			//IL_0137: Expected I4, but got O
			//IL_0188: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 32)
				{
					int num3 = (Tool = input.ReadInt32());
				}
				if (num == 42)
				{
					TargetMemoryShard builder = new TargetMemoryShard();
					if (typeCase_ == TypeOneofCase.MemoryShard)
					{
						if (typeCase_ != TypeOneofCase.MemoryShard)
						{
						}
						object obj = type_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					type_ = builder;
					typeCase_ = (TypeOneofCase)typeof(TargetMemoryShard).TypeHandle;
				}
				if ((long)typeof(TargetMemoryShard).TypeHandle != 48)
				{
					goto IL_0188;
				}
				int num5 = (Recipe = input.ReadInt32());
			}
			bool flag = default(bool);
			if (num == 10)
			{
				TargetBuildingType targetBuildingType = new TargetBuildingType();
				if (typeCase_ == TypeOneofCase.Building)
				{
					if (typeCase_ != TypeOneofCase.Building)
					{
					}
					object obj2 = type_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(targetBuildingType);
				type_ = targetBuildingType;
				flag = (byte)(typeCase_ = ((targetBuildingType != null) ? TypeOneofCase.Building : TypeOneofCase.None)) != 0;
			}
			if (flag)
			{
				TargetArea builder2 = new TargetArea();
				if (typeCase_ == TypeOneofCase.Area)
				{
					if (typeCase_ != TypeOneofCase.Area)
					{
					}
					object obj3 = type_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				type_ = builder2;
				typeCase_ = (TypeOneofCase)typeof(TargetArea).TypeHandle;
			}
			if ((long)typeof(TargetArea).TypeHandle == 26)
			{
				TargetRealm builder3 = new TargetRealm();
				if (typeCase_ == TypeOneofCase.Realm)
				{
					if (typeCase_ != TypeOneofCase.Realm)
					{
					}
					object obj4 = type_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				type_ = builder3;
				typeCase_ = (TypeOneofCase)typeof(TargetRealm).TypeHandle;
			}
			goto IL_0188;
			IL_0188:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003610")]
		[Cpp2IlInjected.Address(RVA = "0x355E0E0", Offset = "0x355CAE0", VA = "0x18355E0E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				TargetBuildingType building = Building;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003611")]
		[Cpp2IlInjected.Address(RVA = "0x355EDD0", Offset = "0x355D7D0", VA = "0x18355EDD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0027, IL_002b, IL_002f, IL_0030, IL_0034, IL_0038, IL_0039, IL_003a, IL_003e, IL_0042, IL_0043, IL_0044, IL_0050, IL_0056, IL_005c
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				type_ = num;
				bool flag = (byte)(typeCase_ = ((num != 0) ? TypeOneofCase.Building : TypeOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003612")]
		[Cpp2IlInjected.Address(RVA = "0x355D2A0", Offset = "0x355BCA0", VA = "0x18355D2A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0015, IL_001f
			//IL_000d: Expected O, but got I4
			if (fieldNumber <= 5)
			{
				int num = 0;
				type_ = num;
				typeCase_ = (TypeOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003613")]
		[Cpp2IlInjected.Address(RVA = "0x355E530", Offset = "0x355CF30", VA = "0x18355E530", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				TypeOneofCase typeOneofCase = typeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003614")]
		[Cpp2IlInjected.Address(RVA = "0x355D330", Offset = "0x355BD30", VA = "0x18355D330", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Type"))
			{
				type_ = (typeCase_ = TypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003619")]
		[Cpp2IlInjected.Address(RVA = "0x355DEB0", Offset = "0x355C8B0", VA = "0x18355DEB0")]
		public List<Item> GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			if (typeCase_ == TypeOneofCase.Building)
			{
				object obj = type_;
				int num = 0;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				if (num != 0)
				{
					TargetBuilding targetBuilding = default(TargetBuilding);
					if (targetBuilding != null)
					{
						TargetBuilding.TargetOneofCase targetCase_ = targetBuilding.targetCase_;
					}
					if (num != 2)
					{
						List<Item> result = (List<Item>)(object)new List<T>();
						if (typeCase_ == TypeOneofCase.Building)
						{
							object obj2 = type_;
							if (obj2 != null && obj2 == null)
							{
								goto IL_0061;
							}
							if (obj2 == null)
							{
							}
						}
						Item invalid = Item.Invalid;
						return result;
					}
				}
			}
			int num2 = 0;
			goto IL_0061;
			IL_0061:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600361A")]
		[Cpp2IlInjected.Address(RVA = "0x355E5E0", Offset = "0x355CFE0", VA = "0x18355E5E0")]
		public Item GetTargetBuildingItem(MissionItemData data)
		{
			if (typeCase_ == TypeOneofCase.Building)
			{
				object obj = type_;
				int num = 0;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				Item result = default(Item);
				if (num != 0)
				{
					return result;
				}
			}
			return Item.Invalid;
		}

		[Cpp2IlInjected.Token(Token = "0x600361B")]
		[Cpp2IlInjected.Address(RVA = "0x355D400", Offset = "0x355BE00", VA = "0x18355D400", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_000d, IL_001d, IL_001e, IL_0022, IL_0039, IL_0046, IL_0053, IL_006a, IL_006f, IL_0074, IL_0087, IL_008b, IL_0099, IL_00a6, IL_00af, IL_00bd, IL_00be, IL_00bf, IL_00c9, IL_00d3, IL_00dc, IL_00ed, IL_00f6, IL_00fe
			if (typeCase_ > TypeOneofCase.Recipe)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600361C")]
		[Cpp2IlInjected.Address(RVA = "0x355F3C0", Offset = "0x355DDC0", VA = "0x18355F3C0")]
		static CustomStepUnlock()
		{
			Func<CustomStepUnlock> func = default(Func<CustomStepUnlock>);
			_parser = (MessageParser<CustomStepUnlock>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600361D")]
		[Cpp2IlInjected.Address(RVA = "0x355DC80", Offset = "0x355C680", VA = "0x18355DC80", Slot = "18")]
		List<Item> IBuildingMapMarker.GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			return (List<Item>)(object)this.GetBuildingMapMarker(data, ref world);
		}
	}
}
