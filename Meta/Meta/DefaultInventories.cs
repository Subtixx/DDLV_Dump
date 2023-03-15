using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class DefaultInventories : IMessage<DefaultInventories>, IMessage, IEquatable<DefaultInventories>, IDeepCloneable<DefaultInventories>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly MessageParser<DefaultInventories> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public const int BackpackFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private ContainerInventory backpack_;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public const int HomeStorageFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private ContainerInventory homeStorage_;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public const int CatalogFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private ListInventory catalog_;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public const int WardrobeFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private ListInventory wardrobe_;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public const int PantryFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private ListInventory pantry_;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public const int MakeupFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private ListInventory makeup_;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public const int TrimmingFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private ListInventory trimming_;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public const int BuildingsFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private ListInventory buildings_;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public const int DecalsFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private ListInventory decals_;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public const int SkinsFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private ListInventory skins_;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[DebuggerNonUserCode]
		public static MessageParser<DefaultInventories> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1A23B70", Offset = "0x1A22570", VA = "0x181A23B70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1A23AA0", Offset = "0x1A224A0", VA = "0x181A23AA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1A23BD0", Offset = "0x1A225D0", VA = "0x181A23BD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		[DebuggerNonUserCode]
		public ContainerInventory Backpack
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return backpack_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				backpack_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		[DebuggerNonUserCode]
		public ContainerInventory HomeStorage
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return homeStorage_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				homeStorage_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[DebuggerNonUserCode]
		public ListInventory Catalog
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return catalog_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				catalog_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		[DebuggerNonUserCode]
		public ListInventory Wardrobe
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return wardrobe_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				wardrobe_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		[DebuggerNonUserCode]
		public ListInventory Pantry
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return pantry_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				pantry_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		[DebuggerNonUserCode]
		public ListInventory Makeup
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return makeup_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				makeup_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		[DebuggerNonUserCode]
		public ListInventory Trimming
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return trimming_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				trimming_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		[DebuggerNonUserCode]
		public ListInventory Buildings
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return buildings_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				buildings_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		[DebuggerNonUserCode]
		public ListInventory Decals
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return decals_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				decals_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[DebuggerNonUserCode]
		public ListInventory Skins
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return skins_;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				skins_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DefaultInventories()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1A238D0", Offset = "0x1A222D0", VA = "0x181A238D0")]
		[DebuggerNonUserCode]
		public DefaultInventories(DefaultInventories other)
		{
			//IL_0021: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			//IL_00af: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			//IL_00e9: Expected O, but got I4
			//IL_0106: Expected O, but got I4
			ContainerInventory containerInventory = other.backpack_;
			int num = 0;
			if (containerInventory != null)
			{
				ContainerInventory containerInventory2 = containerInventory.Clone();
			}
			backpack_ = (ContainerInventory)num;
			ContainerInventory containerInventory3 = other.homeStorage_;
			if (containerInventory3 != null)
			{
				ContainerInventory containerInventory4 = containerInventory3.Clone();
			}
			homeStorage_ = (ContainerInventory)num;
			ListInventory listInventory = other.catalog_;
			if (listInventory != null)
			{
				ListInventory listInventory2 = listInventory.Clone();
			}
			catalog_ = (ListInventory)num;
			ListInventory listInventory3 = other.wardrobe_;
			if (listInventory3 != null)
			{
				ListInventory listInventory4 = listInventory3.Clone();
			}
			wardrobe_ = (ListInventory)num;
			ListInventory listInventory5 = other.pantry_;
			if (listInventory5 != null)
			{
				ListInventory listInventory6 = listInventory5.Clone();
			}
			pantry_ = (ListInventory)num;
			ListInventory listInventory7 = other.makeup_;
			if (listInventory7 != null)
			{
				ListInventory listInventory8 = listInventory7.Clone();
			}
			makeup_ = (ListInventory)num;
			ListInventory listInventory9 = other.trimming_;
			if (listInventory9 != null)
			{
				ListInventory listInventory10 = listInventory9.Clone();
			}
			trimming_ = (ListInventory)num;
			ListInventory listInventory11 = other.buildings_;
			if (listInventory11 != null)
			{
				ListInventory listInventory12 = listInventory11.Clone();
			}
			buildings_ = (ListInventory)num;
			ListInventory listInventory13 = other.decals_;
			if (listInventory13 != null)
			{
				ListInventory listInventory14 = listInventory13.Clone();
			}
			decals_ = (ListInventory)num;
			ListInventory listInventory15 = other.skins_;
			ListInventory listInventory16 = default(ListInventory);
			if (listInventory15 != null)
			{
				listInventory16 = listInventory15.Clone();
			}
			skins_ = listInventory16;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1A225C0", Offset = "0x1A20FC0", VA = "0x181A225C0", Slot = "10")]
		[DebuggerNonUserCode]
		public DefaultInventories Clone()
		{
			return new DefaultInventories(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1A22760", Offset = "0x1A21160", VA = "0x181A22760", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(backpack_, other) && object.Equals(homeStorage_, other) && object.Equals(catalog_, other) && object.Equals(wardrobe_, other) && object.Equals(pantry_, other) && object.Equals(makeup_, other) && object.Equals(trimming_, other) && object.Equals(buildings_, other) && object.Equals(decals_, other) && object.Equals(skins_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1A22620", Offset = "0x1A21020", VA = "0x181A22620", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultInventories other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ContainerInventory objB = other.backpack_;
				if (object.Equals(backpack_, objB))
				{
					ContainerInventory objB2 = other.homeStorage_;
					if (object.Equals(homeStorage_, objB2))
					{
						ListInventory objB3 = other.catalog_;
						if (object.Equals(catalog_, objB3))
						{
							ListInventory objB4 = other.wardrobe_;
							if (object.Equals(wardrobe_, objB4))
							{
								ListInventory objB5 = other.pantry_;
								if (object.Equals(pantry_, objB5))
								{
									ListInventory objB6 = other.makeup_;
									if (object.Equals(makeup_, objB6))
									{
										ListInventory objB7 = other.trimming_;
										if (object.Equals(trimming_, objB7))
										{
											ListInventory objB8 = other.buildings_;
											if (object.Equals(buildings_, objB8))
											{
												ListInventory objB9 = other.decals_;
												if (object.Equals(decals_, objB9))
												{
													ListInventory objB10 = other.skins_;
													if (object.Equals(skins_, objB10))
													{
														UnknownFieldSet unknownFields = other._unknownFields;
														return object.Equals(_unknownFields, unknownFields);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1A22A00", Offset = "0x1A21400", VA = "0x181A22A00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ContainerInventory containerInventory = backpack_;
				if (containerInventory != null)
				{
					int hashCode = containerInventory.GetHashCode();
				}
				ContainerInventory containerInventory2 = homeStorage_;
				if (containerInventory2 != null)
				{
					int hashCode2 = containerInventory2.GetHashCode();
				}
				ListInventory listInventory = catalog_;
				if (listInventory != null)
				{
					int hashCode3 = listInventory.GetHashCode();
				}
				ListInventory listInventory2 = wardrobe_;
				if (listInventory2 != null)
				{
					int hashCode4 = listInventory2.GetHashCode();
				}
				ListInventory listInventory3 = pantry_;
				if (listInventory3 != null)
				{
					int hashCode5 = listInventory3.GetHashCode();
				}
				ListInventory listInventory4 = makeup_;
				if (listInventory4 != null)
				{
					int hashCode6 = listInventory4.GetHashCode();
				}
				ListInventory listInventory5 = trimming_;
				if (listInventory5 != null)
				{
					int hashCode7 = listInventory5.GetHashCode();
				}
				ListInventory listInventory6 = buildings_;
				if (listInventory6 != null)
				{
					int hashCode8 = listInventory6.GetHashCode();
				}
				ListInventory listInventory7 = decals_;
				if (listInventory7 != null)
				{
					int hashCode9 = listInventory7.GetHashCode();
				}
				ListInventory listInventory8 = skins_;
				if (listInventory8 != null)
				{
					int hashCode10 = listInventory8.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1A23570", Offset = "0x1A21F70", VA = "0x181A23570", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1A235D0", Offset = "0x1A21FD0", VA = "0x181A235D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_011c
			if ((long)backpack_ != 0)
			{
				ContainerInventory value = backpack_;
				output.WriteMessage(value);
			}
			if ((long)homeStorage_ != 0)
			{
				ContainerInventory value2 = homeStorage_;
				output.WriteMessage(value2);
			}
			if ((long)catalog_ != 0)
			{
				ListInventory value3 = catalog_;
				output.WriteMessage(value3);
			}
			if ((long)wardrobe_ != 0)
			{
				ListInventory value4 = wardrobe_;
				output.WriteMessage(value4);
			}
			if ((long)pantry_ != 0)
			{
				ListInventory value5 = pantry_;
				output.WriteMessage(value5);
			}
			if ((long)makeup_ != 0)
			{
				ListInventory value6 = makeup_;
				output.WriteMessage(value6);
			}
			if ((long)trimming_ != 0)
			{
				ListInventory value7 = trimming_;
				output.WriteMessage(value7);
			}
			if ((long)buildings_ != 0)
			{
				ListInventory value8 = buildings_;
				output.WriteMessage(value8);
			}
			if ((long)decals_ != 0)
			{
				ListInventory value9 = decals_;
				output.WriteMessage(value9);
			}
			if ((long)skins_ != 0)
			{
				ListInventory value10 = skins_;
				output.WriteMessage(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1A22240", Offset = "0x1A20C40", VA = "0x181A22240", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ContainerInventory containerInventory = backpack_;
				num = 0;
				if (containerInventory != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(containerInventory);
				}
				ContainerInventory containerInventory2 = homeStorage_;
				if (containerInventory2 != null)
				{
					int num3 = CodedOutputStream.ComputeMessageSize(containerInventory2);
					num3++;
					num += num3;
				}
				ListInventory listInventory = catalog_;
				if (listInventory != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(listInventory);
					num4++;
					num += num4;
				}
				ListInventory listInventory2 = wardrobe_;
				if (listInventory2 != null)
				{
					int num5 = CodedOutputStream.ComputeMessageSize(listInventory2);
					num5++;
					num += num5;
				}
				ListInventory listInventory3 = pantry_;
				if (listInventory3 != null)
				{
					int num6 = CodedOutputStream.ComputeMessageSize(listInventory3);
					num6++;
					num += num6;
				}
				ListInventory listInventory4 = makeup_;
				if (listInventory4 != null)
				{
					int num7 = CodedOutputStream.ComputeMessageSize(listInventory4);
					num7++;
					num += num7;
				}
				ListInventory listInventory5 = trimming_;
				if (listInventory5 != null)
				{
					int num8 = CodedOutputStream.ComputeMessageSize(listInventory5);
					num8++;
					num += num8;
				}
				ListInventory listInventory6 = buildings_;
				if (listInventory6 != null)
				{
					int num9 = CodedOutputStream.ComputeMessageSize(listInventory6);
					num9++;
					num += num9;
				}
				ListInventory listInventory7 = decals_;
				if (listInventory7 != null)
				{
					int num10 = CodedOutputStream.ComputeMessageSize(listInventory7);
					num10++;
					num += num10;
				}
				ListInventory listInventory8 = skins_;
				if (listInventory8 != null)
				{
					int num11 = CodedOutputStream.ComputeMessageSize(listInventory8);
					num11++;
					num += num11;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num12 = unknownFields.CalculateSize();
			return num12 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1A22F20", Offset = "0x1A21920", VA = "0x181A22F20", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DefaultInventories other)
		{
			//Discarded unreachable code: IL_027b
			if (other == null)
			{
				return;
			}
			if ((long)other.backpack_ != 0)
			{
				ContainerInventory containerInventory = backpack_;
				if (containerInventory == null)
				{
					ContainerInventory containerInventory2 = (backpack_ = new ContainerInventory());
					ContainerInventory containerInventory3 = backpack_;
				}
				ContainerInventory other2 = other.backpack_;
				containerInventory.MergeFrom(other2);
			}
			if ((long)other.homeStorage_ != 0)
			{
				ContainerInventory containerInventory5 = default(ContainerInventory);
				if (homeStorage_ == null)
				{
					ContainerInventory containerInventory4 = (homeStorage_ = new ContainerInventory());
					containerInventory5 = homeStorage_;
				}
				ContainerInventory other3 = other.homeStorage_;
				containerInventory5.MergeFrom(other3);
			}
			if ((long)other.catalog_ != 0)
			{
				ListInventory listInventory2 = default(ListInventory);
				if (catalog_ == null)
				{
					ListInventory listInventory = (catalog_ = new ListInventory());
					listInventory2 = catalog_;
				}
				ListInventory other4 = other.catalog_;
				listInventory2.MergeFrom(other4);
			}
			if ((long)other.wardrobe_ != 0)
			{
				ListInventory listInventory4 = default(ListInventory);
				if (wardrobe_ == null)
				{
					ListInventory listInventory3 = (wardrobe_ = new ListInventory());
					listInventory4 = wardrobe_;
				}
				ListInventory other5 = other.wardrobe_;
				listInventory4.MergeFrom(other5);
			}
			if ((long)other.pantry_ != 0)
			{
				ListInventory listInventory6 = default(ListInventory);
				if (pantry_ == null)
				{
					ListInventory listInventory5 = (pantry_ = new ListInventory());
					listInventory6 = pantry_;
				}
				ListInventory other6 = other.pantry_;
				listInventory6.MergeFrom(other6);
			}
			if ((long)other.makeup_ != 0)
			{
				ListInventory listInventory8 = default(ListInventory);
				if (makeup_ == null)
				{
					ListInventory listInventory7 = (makeup_ = new ListInventory());
					listInventory8 = makeup_;
				}
				ListInventory other7 = other.makeup_;
				listInventory8.MergeFrom(other7);
			}
			if ((long)other.trimming_ != 0)
			{
				ListInventory listInventory10 = default(ListInventory);
				if (trimming_ == null)
				{
					ListInventory listInventory9 = (trimming_ = new ListInventory());
					listInventory10 = trimming_;
				}
				ListInventory other8 = other.trimming_;
				listInventory10.MergeFrom(other8);
			}
			if ((long)other.buildings_ != 0)
			{
				ListInventory listInventory12 = default(ListInventory);
				if (buildings_ == null)
				{
					ListInventory listInventory11 = (buildings_ = new ListInventory());
					listInventory12 = buildings_;
				}
				ListInventory other9 = other.buildings_;
				listInventory12.MergeFrom(other9);
			}
			if ((long)other.decals_ != 0)
			{
				ListInventory listInventory14 = default(ListInventory);
				if (decals_ == null)
				{
					ListInventory listInventory13 = (decals_ = new ListInventory());
					listInventory14 = decals_;
				}
				ListInventory other10 = other.decals_;
				listInventory14.MergeFrom(other10);
			}
			if ((long)other.skins_ != 0)
			{
				ListInventory listInventory16 = default(ListInventory);
				if (skins_ == null)
				{
					ListInventory listInventory15 = (skins_ = new ListInventory());
					listInventory16 = skins_;
				}
				ListInventory other11 = other.skins_;
				listInventory16.MergeFrom(other11);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1A22B60", Offset = "0x1A21560", VA = "0x181A22B60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0216
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 58)
				{
					if (num == 66)
					{
						ListInventory listInventory = buildings_;
						if (listInventory == null)
						{
							ListInventory listInventory2 = (buildings_ = new ListInventory());
						}
						input.ReadMessage(listInventory);
					}
					ListInventory listInventory3 = default(ListInventory);
					if (num == 74)
					{
						ListInventory builder = default(ListInventory);
						if (decals_ == null)
						{
							listInventory3 = (decals_ = new ListInventory());
							builder = decals_;
						}
						input.ReadMessage(builder);
					}
					if ((long)listInventory3 != 82)
					{
						goto IL_01ff;
					}
					ListInventory builder2 = default(ListInventory);
					if (skins_ == null)
					{
						ListInventory listInventory4 = (skins_ = new ListInventory());
						builder2 = skins_;
					}
					input.ReadMessage(builder2);
				}
				ListInventory listInventory5 = default(ListInventory);
				if (num == 50)
				{
					ListInventory builder3 = default(ListInventory);
					if (makeup_ == null)
					{
						listInventory5 = (makeup_ = new ListInventory());
						builder3 = makeup_;
					}
					input.ReadMessage(builder3);
				}
				if ((long)listInventory5 != 58)
				{
					goto IL_01ff;
				}
				ListInventory builder4 = default(ListInventory);
				if (trimming_ == null)
				{
					ListInventory listInventory6 = (trimming_ = new ListInventory());
					builder4 = trimming_;
				}
				input.ReadMessage(builder4);
			}
			ListInventory listInventory9 = default(ListInventory);
			if ((int)num > 18)
			{
				ListInventory listInventory7 = default(ListInventory);
				if (num == 26)
				{
					ListInventory builder5 = default(ListInventory);
					if (catalog_ == null)
					{
						listInventory7 = (catalog_ = new ListInventory());
						builder5 = catalog_;
					}
					input.ReadMessage(builder5);
				}
				ListInventory listInventory8 = default(ListInventory);
				if ((long)listInventory7 == 34)
				{
					ListInventory builder6 = default(ListInventory);
					if (wardrobe_ == null)
					{
						listInventory8 = (wardrobe_ = new ListInventory());
						builder6 = wardrobe_;
					}
					input.ReadMessage(builder6);
				}
				if ((long)listInventory8 != 42)
				{
					goto IL_01ff;
				}
				ListInventory builder7 = default(ListInventory);
				if (pantry_ == null)
				{
					listInventory9 = (pantry_ = new ListInventory());
					builder7 = pantry_;
				}
				input.ReadMessage(builder7);
			}
			ContainerInventory containerInventory = default(ContainerInventory);
			if ((long)listInventory9 == 10)
			{
				ContainerInventory builder8 = default(ContainerInventory);
				if (backpack_ == null)
				{
					containerInventory = (backpack_ = new ContainerInventory());
					builder8 = backpack_;
				}
				input.ReadMessage(builder8);
			}
			if ((long)containerInventory == 18)
			{
				ContainerInventory builder9 = default(ContainerInventory);
				if (homeStorage_ == null)
				{
					ContainerInventory containerInventory2 = (homeStorage_ = new ContainerInventory());
					builder9 = homeStorage_;
				}
				input.ReadMessage(builder9);
			}
			goto IL_01ff;
			IL_01ff:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x1A228E0", Offset = "0x1A212E0", VA = "0x181A228E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber <= 9)
			{
				ContainerInventory containerInventory = backpack_;
				ContainerInventory containerInventory2 = homeStorage_;
				ListInventory listInventory = catalog_;
				ListInventory listInventory2 = wardrobe_;
				ListInventory listInventory3 = pantry_;
				ListInventory listInventory4 = makeup_;
				ListInventory listInventory5 = trimming_;
				ListInventory listInventory6 = buildings_;
				ListInventory listInventory7 = decals_;
				ListInventory listInventory8 = skins_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1A232E0", Offset = "0x1A21CE0", VA = "0x181A232E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_0025, IL_002b, IL_0031, IL_0037, IL_003d, IL_0043, IL_0049, IL_004f
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 9)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				backpack_ = (ContainerInventory)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1A224C0", Offset = "0x1A20EC0", VA = "0x181A224C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber > 9)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1A237C0", Offset = "0x1A221C0", VA = "0x181A237C0")]
		static DefaultInventories()
		{
			Func<DefaultInventories> func = default(Func<DefaultInventories>);
			_parser = (MessageParser<DefaultInventories>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
