using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004E3")]
	public sealed class ItemSelector : IMessage<ItemSelector>, IMessage, IEquatable<ItemSelector>, IDeepCloneable<ItemSelector>, IMessageFieldAccessor, IMessageOneofAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20004E4")]
		public enum ItemSelectorOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001A45")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001A46")]
			Item,
			[Cpp2IlInjected.Token(Token = "0x4001A47")]
			ItemList,
			[Cpp2IlInjected.Token(Token = "0x4001A48")]
			ItemGenerator,
			[Cpp2IlInjected.Token(Token = "0x4001A49")]
			FilterGenerator,
			[Cpp2IlInjected.Token(Token = "0x4001A4A")]
			Variable
		}

		[Cpp2IlInjected.Token(Token = "0x4001A37")]
		private static readonly MessageParser<ItemSelector> _parser = (MessageParser<ItemSelector>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ItemSelector()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A38")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001A39")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001A3A")]
		public const int ItemListFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001A3B")]
		public const int ItemGeneratorFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x4001A3C")]
		public const int FilterGeneratorFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x4001A3D")]
		public const int VariableFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001A3E")]
		public const int UseCustomVariableNameFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A3F")]
		private bool useCustomVariableName_;

		[Cpp2IlInjected.Token(Token = "0x4001A40")]
		public const int VariableNameFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001A41")]
		private string variableName_ = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001A42")]
		private object itemSelector_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001A43")]
		private ItemSelectorOneofCase itemSelectorCase_;

		[Cpp2IlInjected.Token(Token = "0x17000F7B")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemSelector> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003C57")]
			[Cpp2IlInjected.Address(RVA = "0x25F1280", Offset = "0x25EFC80", VA = "0x1825F1280")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003C58")]
			[Cpp2IlInjected.Address(RVA = "0x25F0FE0", Offset = "0x25EF9E0", VA = "0x1825F0FE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003C59")]
			[Cpp2IlInjected.Address(RVA = "0x25F1350", Offset = "0x25EFD50", VA = "0x1825F1350", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7E")]
		[DebuggerNonUserCode]
		public MissionItemGenerator Item
		{
			[Cpp2IlInjected.Token(Token = "0x6003C5D")]
			[Cpp2IlInjected.Address(RVA = "0x25F1220", Offset = "0x25EFC20", VA = "0x1825F1220")]
			get
			{
				int num = 0;
				if (itemSelectorCase_ == ItemSelectorOneofCase.Item)
				{
					object obj = itemSelector_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003C5E")]
			[Cpp2IlInjected.Address(RVA = "0x25F14A0", Offset = "0x25EFEA0", VA = "0x1825F14A0")]
			set
			{
				itemSelector_ = value;
				bool flag = (byte)(itemSelectorCase_ = ((value != null) ? ItemSelectorOneofCase.Item : ItemSelectorOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F7F")]
		[DebuggerNonUserCode]
		public MissionItemGenerator ItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6003C5F")]
			[Cpp2IlInjected.Address(RVA = "0x25F11C0", Offset = "0x25EFBC0", VA = "0x1825F11C0")]
			get
			{
				int num = 0;
				if (itemSelectorCase_ == ItemSelectorOneofCase.ItemList)
				{
					object obj = itemSelector_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003C60")]
			[Cpp2IlInjected.Address(RVA = "0x25F1460", Offset = "0x25EFE60", VA = "0x1825F1460")]
			set
			{
				itemSelector_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F80")]
		[DebuggerNonUserCode]
		public MissionItemGenerator ItemGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6003C61")]
			[Cpp2IlInjected.Address(RVA = "0x25F1160", Offset = "0x25EFB60", VA = "0x1825F1160")]
			get
			{
				int num = 0;
				if (itemSelectorCase_ == ItemSelectorOneofCase.ItemGenerator)
				{
					object obj = itemSelector_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003C62")]
			[Cpp2IlInjected.Address(RVA = "0x24CC990", Offset = "0x24CB390", VA = "0x1824CC990")]
			set
			{
				itemSelector_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F81")]
		[DebuggerNonUserCode]
		public MissionItemGenerator FilterGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6003C63")]
			[Cpp2IlInjected.Address(RVA = "0x25F10B0", Offset = "0x25EFAB0", VA = "0x1825F10B0")]
			get
			{
				int num = 0;
				if (itemSelectorCase_ == ItemSelectorOneofCase.FilterGenerator)
				{
					object obj = itemSelector_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003C64")]
			[Cpp2IlInjected.Address(RVA = "0x1AC4270", Offset = "0x1AC2C70", VA = "0x181AC4270")]
			set
			{
				itemSelector_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F82")]
		[DebuggerNonUserCode]
		public string Variable
		{
			[Cpp2IlInjected.Token(Token = "0x6003C65")]
			[Cpp2IlInjected.Address(RVA = "0x25F12E0", Offset = "0x25EFCE0", VA = "0x1825F12E0")]
			get
			{
				if (itemSelectorCase_ == ItemSelectorOneofCase.Variable)
				{
					object obj = itemSelector_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				return "";
			}
			[Cpp2IlInjected.Token(Token = "0x6003C66")]
			[Cpp2IlInjected.Address(RVA = "0x25F1550", Offset = "0x25EFF50", VA = "0x1825F1550")]
			set
			{
				//IL_001c: Expected I4, but got I8
				string text = (string)(itemSelector_ = ProtoPreconditions.CheckNotNull(value, "value"));
				itemSelectorCase_ = ItemSelectorOneofCase.Variable;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F83")]
		[DebuggerNonUserCode]
		public bool UseCustomVariableName
		{
			[Cpp2IlInjected.Token(Token = "0x6003C67")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useCustomVariableName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C68")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useCustomVariableName_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F84")]
		[DebuggerNonUserCode]
		public string VariableName
		{
			[Cpp2IlInjected.Token(Token = "0x6003C69")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return variableName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C6A")]
			[Cpp2IlInjected.Address(RVA = "0x25F14E0", Offset = "0x25EFEE0", VA = "0x1825F14E0")]
			set
			{
				string text = (variableName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F85")]
		[DebuggerNonUserCode]
		public ItemSelectorOneofCase ItemSelectorCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003C6B")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return itemSelectorCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F86")]
		public bool IsItemSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003C7A")]
			[Cpp2IlInjected.Address(RVA = "0x25F1140", Offset = "0x25EFB40", VA = "0x1825F1140")]
			get
			{
				ItemSelectorOneofCase itemSelectorOneofCase = itemSelectorCase_;
				if (itemSelectorOneofCase == ItemSelectorOneofCase.Item)
				{
				}
				return itemSelectorOneofCase == ItemSelectorOneofCase.ItemList;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F87")]
		public bool IsGeneratorSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003C7B")]
			[Cpp2IlInjected.Address(RVA = "0x25F1110", Offset = "0x25EFB10", VA = "0x1825F1110")]
			get
			{
				ItemSelectorOneofCase itemSelectorOneofCase = itemSelectorCase_;
				if (itemSelectorOneofCase == ItemSelectorOneofCase.ItemGenerator)
				{
					return true;
				}
				return itemSelectorOneofCase == ItemSelectorOneofCase.FilterGenerator;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F88")]
		public bool IsVariableSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003C7C")]
			[Cpp2IlInjected.Address(RVA = "0x25F1150", Offset = "0x25EFB50", VA = "0x1825F1150")]
			get
			{
				return itemSelectorCase_ == ItemSelectorOneofCase.Variable;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F89")]
		public bool IsItemGeneratorSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003C7D")]
			[Cpp2IlInjected.Address(RVA = "0x25F1130", Offset = "0x25EFB30", VA = "0x1825F1130")]
			get
			{
				return itemSelectorCase_ == ItemSelectorOneofCase.ItemGenerator;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C5A")]
		[Cpp2IlInjected.Address(RVA = "0x25F0DB0", Offset = "0x25EF7B0", VA = "0x1825F0DB0")]
		[DebuggerNonUserCode]
		public ItemSelector()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003C5B")]
		[Cpp2IlInjected.Address(RVA = "0x25F0E00", Offset = "0x25EF800", VA = "0x1825F0E00")]
		[DebuggerNonUserCode]
		public ItemSelector(ItemSelector other)
		{
			//IL_0079: Expected I4, but got O
			//IL_0096: Expected I4, but got O
			//IL_00b3: Expected I4, but got O
			bool flag = (useCustomVariableName_ = other.useCustomVariableName_);
			string text = (variableName_ = other.variableName_);
			ItemSelectorOneofCase itemSelectorOneofCase = other.itemSelectorCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (other != null)
					{
						if (other != null)
						{
							if (itemSelectorOneofCase != ItemSelectorOneofCase.Item)
							{
								goto IL_00da;
							}
							string text2 = (Variable = other.Variable);
						}
						itemSelectorCase_ = (ItemSelectorOneofCase)(itemSelector_ = other.FilterGenerator.Clone());
					}
					itemSelectorCase_ = (ItemSelectorOneofCase)(itemSelector_ = other.ItemGenerator.Clone());
				}
				itemSelectorCase_ = (ItemSelectorOneofCase)(itemSelector_ = other.ItemList.Clone());
			}
			bool flag2 = (byte)(itemSelectorCase_ = (((itemSelector_ = other.Item.Clone()) != null) ? ItemSelectorOneofCase.Item : ItemSelectorOneofCase.None)) != 0;
			goto IL_00da;
			IL_00da:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C5C")]
		[Cpp2IlInjected.Address(RVA = "0x25EE8C0", Offset = "0x25ED2C0", VA = "0x1825EE8C0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemSelector Clone()
		{
			return new ItemSelector(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6C")]
		[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
		[DebuggerNonUserCode]
		public void ClearItemSelector()
		{
			//IL_0010: Expected O, but got I4
			itemSelector_ = (itemSelectorCase_ = ItemSelectorOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6D")]
		[Cpp2IlInjected.Address(RVA = "0x25EF4F0", Offset = "0x25EDEF0", VA = "0x1825EF4F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ItemSelector)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6E")]
		[Cpp2IlInjected.Address(RVA = "0x25EF550", Offset = "0x25EDF50", VA = "0x1825EF550", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemSelector other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (itemSelectorCase_ == ItemSelectorOneofCase.Item)
				{
					object obj = itemSelector_;
					if (obj != null && obj == null)
					{
						goto IL_0123;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.itemSelectorCase_ == ItemSelectorOneofCase.Item)
				{
					obj2 = other.itemSelector_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					MissionItemGenerator itemList = ItemList;
					MissionItemGenerator itemList2 = other.ItemList;
					if (object.Equals(itemList, itemList2))
					{
						MissionItemGenerator itemGenerator = ItemGenerator;
						MissionItemGenerator itemGenerator2 = other.ItemGenerator;
						if (object.Equals(itemGenerator, itemGenerator2))
						{
							MissionItemGenerator filterGenerator = FilterGenerator;
							MissionItemGenerator filterGenerator2 = other.FilterGenerator;
							if (object.Equals(filterGenerator, filterGenerator2))
							{
								string variable = Variable;
								string variable2 = other.Variable;
								if (!(variable != variable2))
								{
									bool flag = other.useCustomVariableName_;
									if (useCustomVariableName_ == flag)
									{
										string text = other.variableName_;
										if (!(variableName_ != text))
										{
											ItemSelectorOneofCase itemSelectorOneofCase = other.itemSelectorCase_;
											if (itemSelectorCase_ == itemSelectorOneofCase)
											{
												UnknownFieldSet unknownFields = other._unknownFields;
												bool flag2 = object.Equals(_unknownFields, unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0123;
			IL_0123:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C6F")]
		[Cpp2IlInjected.Address(RVA = "0x25EF8A0", Offset = "0x25EE2A0", VA = "0x1825EF8A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00ed
			while (true)
			{
				ItemSelectorOneofCase itemSelectorOneofCase = itemSelectorCase_;
				int num = 0;
				if (itemSelectorOneofCase == ItemSelectorOneofCase.Item)
				{
					object obj = itemSelector_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (itemSelectorOneofCase != ItemSelectorOneofCase.ItemList)
				{
					continue;
				}
				object obj2 = itemSelector_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (itemSelectorCase_ != ItemSelectorOneofCase.ItemGenerator)
					{
						continue;
					}
					object obj3 = itemSelector_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (itemSelectorCase_ != ItemSelectorOneofCase.FilterGenerator)
						{
							continue;
						}
						object obj4 = itemSelector_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (itemSelectorCase_ == ItemSelectorOneofCase.Variable)
							{
								if (itemSelectorCase_ != ItemSelectorOneofCase.Variable)
								{
								}
								object obj5 = itemSelector_;
								if (obj5 != null && obj5 == null)
								{
									break;
								}
								int hashCode5 = obj5.GetHashCode();
							}
							if (useCustomVariableName_)
							{
							}
							string text = variableName_;
							if (text.m_stringLength != 0)
							{
								int hashCode6 = text.GetHashCode();
							}
							UnknownFieldSet unknownFields = _unknownFields;
							if (unknownFields != null)
							{
								int hashCode7 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6003C70")]
		[Cpp2IlInjected.Address(RVA = "0x25F05B0", Offset = "0x25EEFB0", VA = "0x1825F05B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C71")]
		[Cpp2IlInjected.Address(RVA = "0x25F09F0", Offset = "0x25EF3F0", VA = "0x1825F09F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0105
			//IL_002f: Expected O, but got I4
			while (true)
			{
				ItemSelectorOneofCase itemSelectorOneofCase = itemSelectorCase_;
				int num = 0;
				if (itemSelectorOneofCase == ItemSelectorOneofCase.Item)
				{
					if (itemSelectorCase_ == ItemSelectorOneofCase.Item)
					{
						object obj = itemSelector_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (itemSelectorOneofCase != ItemSelectorOneofCase.ItemList)
				{
					continue;
				}
				if (itemSelectorCase_ == ItemSelectorOneofCase.ItemList)
				{
					object obj2 = itemSelector_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (itemSelectorCase_ != ItemSelectorOneofCase.ItemGenerator)
				{
					continue;
				}
				if (itemSelectorCase_ == ItemSelectorOneofCase.ItemGenerator)
				{
					object obj3 = itemSelector_;
					if (obj3 != null && obj3 == null)
					{
						break;
					}
				}
				if (itemSelectorCase_ != ItemSelectorOneofCase.FilterGenerator)
				{
					continue;
				}
				if (itemSelectorCase_ == ItemSelectorOneofCase.FilterGenerator)
				{
					object obj4 = itemSelector_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (itemSelectorCase_ == ItemSelectorOneofCase.Variable)
				{
					string variable = Variable;
					output.WriteString(variable);
				}
				if (useCustomVariableName_)
				{
					bool value = useCustomVariableName_;
					output.WriteBool(value);
				}
				if (variableName_.m_stringLength != 0)
				{
					string value2 = variableName_;
					output.WriteString(value2);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C72")]
		[Cpp2IlInjected.Address(RVA = "0x25EE430", Offset = "0x25ECE30", VA = "0x1825EE430", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0123
			int num = 0;
			if (itemSelectorCase_ == ItemSelectorOneofCase.Item)
			{
				if (itemSelectorCase_ != ItemSelectorOneofCase.Item)
				{
				}
				object obj = itemSelector_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (itemSelectorCase_ == ItemSelectorOneofCase.ItemList)
			{
				if (itemSelectorCase_ != ItemSelectorOneofCase.ItemList)
				{
				}
				object obj2 = itemSelector_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num2 = default(int);
				num += num2;
			}
			if (itemSelectorCase_ == ItemSelectorOneofCase.ItemGenerator)
			{
				if (itemSelectorCase_ != ItemSelectorOneofCase.ItemGenerator)
				{
				}
				object obj3 = itemSelector_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (itemSelectorCase_ == ItemSelectorOneofCase.FilterGenerator)
			{
				if (itemSelectorCase_ != ItemSelectorOneofCase.FilterGenerator)
				{
				}
				object obj4 = itemSelector_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			if (itemSelectorCase_ == ItemSelectorOneofCase.Variable)
			{
				if (itemSelectorCase_ != ItemSelectorOneofCase.Variable)
				{
				}
				object obj5 = itemSelector_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num5 = default(int);
				num += num5;
			}
			string text = variableName_;
			if (text.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text);
				num6++;
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

		[Cpp2IlInjected.Token(Token = "0x6003C73")]
		[Cpp2IlInjected.Address(RVA = "0x25EFC30", Offset = "0x25EE630", VA = "0x1825EFC30", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemSelector other)
		{
			//Discarded unreachable code: IL_0169
			//IL_0096: Expected I4, but got O
			//IL_00c6: Expected I4, but got O
			//IL_00f6: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			bool flag = other.useCustomVariableName_;
			if (flag)
			{
				useCustomVariableName_ = flag;
			}
			string text = other.variableName_;
			if (text.m_stringLength != 0)
			{
				VariableName = text;
			}
			ItemSelectorOneofCase itemSelectorOneofCase = other.itemSelectorCase_;
			if (text.m_stringLength != 0)
			{
				if (text.m_stringLength != 0)
				{
					if (text.m_stringLength != 0)
					{
						if (text.m_stringLength != 0)
						{
							if (itemSelectorOneofCase != ItemSelectorOneofCase.Item)
							{
								goto IL_0149;
							}
							string text2 = (Variable = other.Variable);
						}
						if (FilterGenerator == null)
						{
							itemSelectorCase_ = (ItemSelectorOneofCase)(itemSelector_ = new MissionItemGenerator());
						}
						MissionItemGenerator filterGenerator = FilterGenerator;
						MissionItemGenerator filterGenerator2 = other.FilterGenerator;
					}
					if (ItemGenerator == null)
					{
						itemSelectorCase_ = (ItemSelectorOneofCase)(itemSelector_ = new MissionItemGenerator());
					}
					MissionItemGenerator itemGenerator = ItemGenerator;
					MissionItemGenerator itemGenerator2 = other.ItemGenerator;
				}
				if (ItemList == null)
				{
					itemSelectorCase_ = (ItemSelectorOneofCase)(itemSelector_ = new MissionItemGenerator());
				}
				MissionItemGenerator itemList = ItemList;
				MissionItemGenerator itemList2 = other.ItemList;
			}
			if (Item == null)
			{
				bool flag2 = (byte)(itemSelectorCase_ = (((itemSelector_ = new MissionItemGenerator()) != null) ? ItemSelectorOneofCase.Item : ItemSelectorOneofCase.None)) != 0;
			}
			MissionItemGenerator item = Item;
			MissionItemGenerator item2 = other.Item;
			item.MergeFrom(item2);
			goto IL_0149;
			IL_0149:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003C74")]
		[Cpp2IlInjected.Address(RVA = "0x25EFEA0", Offset = "0x25EE8A0", VA = "0x1825EFEA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0095: Expected I4, but got O
			//IL_0157: Expected I4, but got O
			//IL_01a8: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 42)
				{
					if (num == 80)
					{
						bool flag = (useCustomVariableName_ = input.ReadBool());
					}
					if (num != 90)
					{
						goto IL_01a8;
					}
					string text2 = (VariableName = input.ReadString());
				}
				if (num == 34)
				{
					MissionItemGenerator builder = new MissionItemGenerator();
					if (itemSelectorCase_ == ItemSelectorOneofCase.FilterGenerator)
					{
						if (itemSelectorCase_ != ItemSelectorOneofCase.FilterGenerator)
						{
						}
						object obj = itemSelector_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					itemSelector_ = builder;
					itemSelectorCase_ = (ItemSelectorOneofCase)typeof(MissionItemGenerator).TypeHandle;
				}
				if ((long)typeof(MissionItemGenerator).TypeHandle != 42)
				{
					goto IL_01a8;
				}
				string text4 = (Variable = input.ReadString());
			}
			bool flag2 = default(bool);
			if (num == 10)
			{
				MissionItemGenerator missionItemGenerator = new MissionItemGenerator();
				if (itemSelectorCase_ == ItemSelectorOneofCase.Item)
				{
					if (itemSelectorCase_ != ItemSelectorOneofCase.Item)
					{
					}
					object obj2 = itemSelector_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(missionItemGenerator);
				itemSelector_ = missionItemGenerator;
				flag2 = (byte)(itemSelectorCase_ = ((missionItemGenerator != null) ? ItemSelectorOneofCase.Item : ItemSelectorOneofCase.None)) != 0;
			}
			if (flag2)
			{
				MissionItemGenerator builder2 = new MissionItemGenerator();
				if (itemSelectorCase_ == ItemSelectorOneofCase.ItemList)
				{
					if (itemSelectorCase_ != ItemSelectorOneofCase.ItemList)
					{
					}
					object obj3 = itemSelector_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				itemSelector_ = builder2;
				itemSelectorCase_ = (ItemSelectorOneofCase)typeof(MissionItemGenerator).TypeHandle;
			}
			if ((long)typeof(MissionItemGenerator).TypeHandle == 26)
			{
				MissionItemGenerator builder3 = new MissionItemGenerator();
				if (itemSelectorCase_ == ItemSelectorOneofCase.ItemGenerator)
				{
					if (itemSelectorCase_ != ItemSelectorOneofCase.ItemGenerator)
					{
					}
					object obj4 = itemSelector_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder3);
				itemSelector_ = builder3;
				itemSelectorCase_ = (ItemSelectorOneofCase)typeof(MissionItemGenerator).TypeHandle;
			}
			goto IL_01a8;
			IL_01a8:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003C75")]
		[Cpp2IlInjected.Address(RVA = "0x25EF730", Offset = "0x25EE130", VA = "0x1825EF730", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				MissionItemGenerator item = Item;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C76")]
		[Cpp2IlInjected.Address(RVA = "0x25F02F0", Offset = "0x25EECF0", VA = "0x1825F02F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028, IL_002c, IL_0030, IL_0031, IL_0035, IL_0039, IL_003a, IL_003e, IL_0042, IL_0043, IL_0047, IL_004b, IL_004c, IL_004d, IL_0051, IL_0055, IL_0056, IL_0062, IL_0068, IL_006e, IL_0074
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 10)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				itemSelector_ = num;
				bool flag = (byte)(itemSelectorCase_ = ((num != 0) ? ItemSelectorOneofCase.Item : ItemSelectorOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C77")]
		[Cpp2IlInjected.Address(RVA = "0x25EE770", Offset = "0x25ED170", VA = "0x1825EE770", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0018, IL_0019
			//IL_0010: Expected O, but got I4
			if (fieldNumber - 1 <= 10)
			{
				int num = 0;
				itemSelector_ = num;
				itemSelectorCase_ = (ItemSelectorOneofCase)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C78")]
		[Cpp2IlInjected.Address(RVA = "0x25EFB80", Offset = "0x25EE580", VA = "0x1825EFB80", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "ItemSelector"))
			{
				ItemSelectorOneofCase itemSelectorOneofCase = itemSelectorCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C79")]
		[Cpp2IlInjected.Address(RVA = "0x25EE850", Offset = "0x25ED250", VA = "0x1825EE850", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "ItemSelector"))
			{
				itemSelector_ = (itemSelectorCase_ = ItemSelectorOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C7E")]
		[Cpp2IlInjected.Address(RVA = "0x25F0280", Offset = "0x25EEC80", VA = "0x1825F0280")]
		[IteratorStateMachine(typeof(_003CSelectedItems_003Ed__69))]
		public IEnumerable<Item> SelectedItems()
		{
			new _003CSelectedItems_003Ed__69(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C7F")]
		[Cpp2IlInjected.Address(RVA = "0x25EE920", Offset = "0x25ED320", VA = "0x1825EE920", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_02bb, IL_02c0, IL_02ca, IL_02db, IL_02ef
			//IL_0177: Expected O, but got I4
			//IL_02ba: Expected O, but got I4
			int num = 0;
			if ((useCustomVariableName_ ? 1 : 0) != num)
			{
				string text = variableName_;
				if ("IntroDlg.ItemFilter" != null)
				{
					string text2 = variableName_;
					string error = "VariableName is invalid: \"" + text2 + "\"";
					context.AddError(error);
				}
			}
			if (itemSelectorCase_ > ItemSelectorOneofCase.Variable)
			{
				return;
			}
			MissionObjectiveData missionObjectiveData = default(MissionObjectiveData);
			bool flag = default(bool);
			if (missionObjectiveData == null)
			{
				DutyStepDifficulty dutyStepDifficulty = default(DutyStepDifficulty);
				if (dutyStepDifficulty == null || dutyStepDifficulty.GiftToCharacter != null)
				{
					return;
				}
				CustomStepSellItem sellItem = dutyStepDifficulty.SellItem;
				if (sellItem != null)
				{
					bool mustSellSpecificItems_ = sellItem.mustSellSpecificItems_;
				}
				flag = num == 0;
				if (num != (flag ? 1 : 0) || dutyStepDifficulty.WaterPlant != null)
				{
					return;
				}
				if (dutyStepDifficulty.FeedCritter != null)
				{
					CustomStepFeedCritter feedCritter = dutyStepDifficulty.FeedCritter;
					if (feedCritter == null || feedCritter.action_ != CustomStepFeedCritter.Types.FeedAction.SpecificItem)
					{
						return;
					}
				}
			}
			CustomStepGiftToCharacterItem customStepGiftToCharacterItem = default(CustomStepGiftToCharacterItem);
			if (customStepGiftToCharacterItem != null)
			{
				return;
			}
			CustomStepSellItem customStepSellItem = default(CustomStepSellItem);
			if (customStepSellItem != null)
			{
				bool mustSellSpecificItems_2 = customStepSellItem.mustSellSpecificItems_;
			}
			bool flag2 = !flag;
			if (flag != flag2)
			{
				return;
			}
			CustomStepPurchaseItem customStepPurchaseItem = default(CustomStepPurchaseItem);
			if (customStepPurchaseItem != null)
			{
				bool mustPurchaseSpecificItems_ = customStepPurchaseItem.mustPurchaseSpecificItems_;
			}
			bool flag3 = !flag;
			CustomStepTalkToCharacter customStepTalkToCharacter = default(CustomStepTalkToCharacter);
			CustomStepWaterPlant customStepWaterPlant = default(CustomStepWaterPlant);
			CustomStepFeedCritter customStepFeedCritter = default(CustomStepFeedCritter);
			CustomStepFeedCritter customStepFeedCritter2 = default(CustomStepFeedCritter);
			if (flag != flag3 || customStepTalkToCharacter != null || customStepWaterPlant != null || (customStepFeedCritter != null && (customStepFeedCritter2 == null || customStepFeedCritter2.action_ != CustomStepFeedCritter.Types.FeedAction.SpecificItem)))
			{
				return;
			}
			MissionItemGenerator missionItemGenerator = default(MissionItemGenerator);
			int item = missionItemGenerator.item_.Item;
			MissionItemGenerator missionItemGenerator2 = default(MissionItemGenerator);
			item = missionItemGenerator2.itemIngredient_.Item;
			MissionItemGenerator missionItemGenerator3 = default(MissionItemGenerator);
			int item2 = missionItemGenerator3.itemIngredient_.Item;
			MissionItemGenerator missionItemGenerator4 = default(MissionItemGenerator);
			GeneratorItem item_ = missionItemGenerator4.item_;
			int num2 = 0;
			item = item_.Item;
			bool flag4 = default(bool);
			if (flag4)
			{
				string text3 = "Item: " + (string)num2;
			}
			MissionItemGenerator missionItemGenerator5 = default(MissionItemGenerator);
			item = missionItemGenerator5.item_.Item;
			MissionItemGenerator missionItemGenerator6 = default(MissionItemGenerator);
			item = missionItemGenerator6.itemIngredient_.Item;
			string text4 = default(string);
			string text5 = "Editor issue: Item & ItemIngredient cannot be both set at same time in " + text4 + ".\nWorkaround: Change the value and save, then put back the right value may fix the issue.";
			MissionItemGenerator missionItemGenerator7 = default(MissionItemGenerator);
			MissionItemGenerator missionItemGenerator8 = default(MissionItemGenerator);
			int item_2;
			if (((RepeatedField<T>)(object)missionItemGenerator7.item_.ItemList.list_).Count == 0 && ((RepeatedField<T>)(object)missionItemGenerator8.itemIngredient_.ItemList.list_).Count != 0)
			{
				MissionItemGenerator missionItemGenerator9 = default(MissionItemGenerator);
				RepeatedField<GeneratorWeightedItemIngredient> list_ = missionItemGenerator9.itemIngredient_.ItemList.list_;
				if (!Enumerable.Any<GeneratorWeightedItemIngredient>((IEnumerable<>)(object)list_))
				{
				}
				int count = ((RepeatedField<T>)(object)list_).Count;
				if (item >= count)
				{
					return;
				}
				item_2 = ((GeneratorWeightedItemIngredient)((RepeatedField<T>)(object)list_)[item]).item_;
				bool flag5 = default(bool);
				if (flag5)
				{
				}
				item++;
				item_2 = item;
			}
			MissionItemGenerator missionItemGenerator10 = default(MissionItemGenerator);
			RepeatedField<GeneratorWeightedItem> list_2 = missionItemGenerator10.item_.ItemList.list_;
			if (!Enumerable.Any<GeneratorWeightedItem>((IEnumerable<>)(object)list_2))
			{
			}
			item_2 = item;
			int count2 = ((RepeatedField<T>)(object)list_2).Count;
			if (item_2 >= count2)
			{
				return;
			}
			int item_3 = ((GeneratorWeightedItem)((RepeatedField<T>)(object)list_2)[item]).item_;
			bool flag6 = default(bool);
			if (flag6)
			{
			}
			item++;
			item_3 = item;
			bool flag7 = default(bool);
			if (flag7)
			{
			}
			string text6 = default(string);
			MissionItemGenerator missionItemGenerator11 = default(MissionItemGenerator);
			if (text6.EndsWith("].GardeningPlant.TargetItem") && missionItemGenerator11.cropType_ != CropTypeCondition.Vegetable)
			{
				string text7 = default(string);
				MissionItemGenerator missionItemGenerator12 = default(MissionItemGenerator);
				if (!text7.EndsWith("].GardeningPlant.TargetItem") || missionItemGenerator12.cropType_ != CropTypeCondition.Vegetable)
				{
				}
				missionItemGenerator12._unknownFields = (UnknownFieldSet)item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C80")]
		[Cpp2IlInjected.Address(RVA = "0x25F0CA0", Offset = "0x25EF6A0", VA = "0x1825F0CA0")]
		static ItemSelector()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
