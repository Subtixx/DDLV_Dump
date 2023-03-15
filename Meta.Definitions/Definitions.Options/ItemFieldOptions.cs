using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000763")]
	public sealed class ItemFieldOptions : IMessage<ItemFieldOptions>, IMessage, IEquatable<ItemFieldOptions>, IDeepCloneable<ItemFieldOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40024C5")]
		private static readonly MessageParser<ItemFieldOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024C6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024C7")]
		public const int ItemTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024C8")]
		private string itemType_ = "";

		[Cpp2IlInjected.Token(Token = "0x40024C9")]
		public const int SubItemTypesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40024CA")]
		private static readonly FieldCodec<string> _repeated_subItemTypes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024CB")]
		private readonly RepeatedField<string> subItemTypes_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40024CC")]
		public const int IsIngredientFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024CD")]
		private bool isIngredient_;

		[Cpp2IlInjected.Token(Token = "0x40024CE")]
		public const int HideButtonFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40024CF")]
		private bool hideButton_;

		[Cpp2IlInjected.Token(Token = "0x40024D0")]
		public const int CreateButtonFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40024D1")]
		private bool createButton_;

		[Cpp2IlInjected.Token(Token = "0x40024D2")]
		public const int InvalidTextFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024D3")]
		private string invalidText_ = "";

		[Cpp2IlInjected.Token(Token = "0x40024D4")]
		public const int RequiredFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40024D5")]
		private bool required_;

		[Cpp2IlInjected.Token(Token = "0x40024D6")]
		public const int FilteringMethodFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40024D7")]
		private MethodInfo filteringMethod_;

		[Cpp2IlInjected.Token(Token = "0x40024D8")]
		public const int CategoryMethodFieldNumber = 21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40024D9")]
		private MethodInfo categoryMethod_;

		[Cpp2IlInjected.Token(Token = "0x40024DA")]
		public const int ItemNameMethodFieldNumber = 22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40024DB")]
		private MethodInfo itemNameMethod_;

		[Cpp2IlInjected.Token(Token = "0x40024DC")]
		public const int IconSizeFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40024DD")]
		private int iconSize_;

		[Cpp2IlInjected.Token(Token = "0x170014AF")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemFieldOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600519B")]
			[Cpp2IlInjected.Address(RVA = "0x22D9380", Offset = "0x22D7D80", VA = "0x1822D9380")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600519C")]
			[Cpp2IlInjected.Address(RVA = "0x22D92B0", Offset = "0x22D7CB0", VA = "0x1822D92B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600519D")]
			[Cpp2IlInjected.Address(RVA = "0x22D93E0", Offset = "0x22D7DE0", VA = "0x1822D93E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B2")]
		[DebuggerNonUserCode]
		public string ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60051A1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemType_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051A2")]
			[Cpp2IlInjected.Address(RVA = "0x22D9560", Offset = "0x22D7F60", VA = "0x1822D9560")]
			set
			{
				string text = (itemType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B3")]
		[DebuggerNonUserCode]
		public RepeatedField<string> SubItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60051A3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return subItemTypes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B4")]
		[DebuggerNonUserCode]
		public bool IsIngredient
		{
			[Cpp2IlInjected.Token(Token = "0x60051A4")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return isIngredient_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051A5")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				isIngredient_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B5")]
		[DebuggerNonUserCode]
		public bool HideButton
		{
			[Cpp2IlInjected.Token(Token = "0x60051A6")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return hideButton_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051A7")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set
			{
				hideButton_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B6")]
		[DebuggerNonUserCode]
		public bool CreateButton
		{
			[Cpp2IlInjected.Token(Token = "0x60051A8")]
			[Cpp2IlInjected.Address(RVA = "0xDC7980", Offset = "0xDC6380", VA = "0x180DC7980")]
			get
			{
				return createButton_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051A9")]
			[Cpp2IlInjected.Address(RVA = "0xDC79A0", Offset = "0xDC63A0", VA = "0x180DC79A0")]
			set
			{
				createButton_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B7")]
		[DebuggerNonUserCode]
		public string InvalidText
		{
			[Cpp2IlInjected.Token(Token = "0x60051AA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return invalidText_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051AB")]
			[Cpp2IlInjected.Address(RVA = "0x22D94F0", Offset = "0x22D7EF0", VA = "0x1822D94F0")]
			set
			{
				string text = (invalidText_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B8")]
		[DebuggerNonUserCode]
		public bool Required
		{
			[Cpp2IlInjected.Token(Token = "0x60051AC")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get
			{
				return required_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051AD")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			set
			{
				required_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014B9")]
		[DebuggerNonUserCode]
		public MethodInfo FilteringMethod
		{
			[Cpp2IlInjected.Token(Token = "0x60051AE")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return filteringMethod_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051AF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			set
			{
				filteringMethod_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BA")]
		[DebuggerNonUserCode]
		public MethodInfo CategoryMethod
		{
			[Cpp2IlInjected.Token(Token = "0x60051B0")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return categoryMethod_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051B1")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				categoryMethod_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BB")]
		[DebuggerNonUserCode]
		public MethodInfo ItemNameMethod
		{
			[Cpp2IlInjected.Token(Token = "0x60051B2")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return itemNameMethod_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051B3")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				itemNameMethod_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014BC")]
		[DebuggerNonUserCode]
		public int IconSize
		{
			[Cpp2IlInjected.Token(Token = "0x60051B4")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return iconSize_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051B5")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				iconSize_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005197")]
		[Cpp2IlInjected.Address(RVA = "0x22D7EC0", Offset = "0x22D68C0", VA = "0x1822D7EC0")]
		public unsafe Dictionary<ItemType, Enum[]> GetFilters()
		{
			//Discarded unreachable code: IL_0036, IL_0059, IL_0066, IL_006b
			//IL_0041: Expected O, but got I4
			string value = itemType_;
			int num = 0;
			if (!string.IsNullOrEmpty(value) && Enum.TryParse<ItemType>(itemType_, out *(ItemType*)num))
			{
				_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				Dictionary<ItemType, Enum[]> dictionary = (Dictionary<ItemType, Enum[]>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005198")]
		[Cpp2IlInjected.Address(RVA = "0x22D7E70", Offset = "0x22D6870", VA = "0x1822D7E70")]
		public Func<Item, bool> GetFilteringMethod()
		{
			MethodInfo methodInfo = filteringMethod_;
			if (methodInfo != null)
			{
				return (Func<Item, bool>)(object)methodInfo.GetMethod<Item, bool>();
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005199")]
		[Cpp2IlInjected.Address(RVA = "0x22D7C70", Offset = "0x22D6670", VA = "0x1822D7C70")]
		public Func<Item, string> GetCategoryMethod()
		{
			MethodInfo methodInfo = categoryMethod_;
			if (methodInfo != null)
			{
				return (Func<Item, string>)(object)methodInfo.GetMethod<Item, string>();
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600519A")]
		[Cpp2IlInjected.Address(RVA = "0x22D8310", Offset = "0x22D6D10", VA = "0x1822D8310")]
		public Func<object, string> GetItemNameMethod()
		{
			MethodInfo methodInfo = itemNameMethod_;
			if (methodInfo != null)
			{
				return (Func<object, string>)(object)methodInfo.GetMethod<object, string>();
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600519E")]
		[Cpp2IlInjected.Address(RVA = "0x22D9200", Offset = "0x22D7C00", VA = "0x1822D9200")]
		[DebuggerNonUserCode]
		public ItemFieldOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600519F")]
		[Cpp2IlInjected.Address(RVA = "0x22D9010", Offset = "0x22D7A10", VA = "0x1822D9010")]
		[DebuggerNonUserCode]
		public ItemFieldOptions(ItemFieldOptions other)
		{
			//IL_00b9: Expected O, but got I4
			//IL_00d7: Expected O, but got I4
			string text = (itemType_ = other.itemType_);
			RepeatedField<string> repeatedField = (subItemTypes_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.subItemTypes_).Clone());
			bool flag = (isIngredient_ = other.isIngredient_);
			bool flag2 = (hideButton_ = other.hideButton_);
			bool flag3 = (createButton_ = other.createButton_);
			string text2 = (invalidText_ = other.invalidText_);
			bool flag4 = other.required_;
			int num = 0;
			required_ = flag4;
			MethodInfo methodInfo = other.filteringMethod_;
			if (methodInfo != null)
			{
				MethodInfo methodInfo2 = methodInfo.Clone();
			}
			filteringMethod_ = (MethodInfo)num;
			MethodInfo methodInfo3 = other.categoryMethod_;
			if (methodInfo3 != null)
			{
				MethodInfo methodInfo4 = methodInfo3.Clone();
			}
			categoryMethod_ = (MethodInfo)num;
			MethodInfo methodInfo5 = other.itemNameMethod_;
			MethodInfo methodInfo6 = default(MethodInfo);
			if (methodInfo5 != null)
			{
				methodInfo6 = methodInfo5.Clone();
			}
			itemNameMethod_ = methodInfo6;
			int num2 = (iconSize_ = other.iconSize_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051A0")]
		[Cpp2IlInjected.Address(RVA = "0x22D7940", Offset = "0x22D6340", VA = "0x1822D7940", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemFieldOptions Clone()
		{
			return new ItemFieldOptions(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60051B6")]
		[Cpp2IlInjected.Address(RVA = "0x22D7AE0", Offset = "0x22D64E0", VA = "0x1822D7AE0", Slot = "0")]
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
				string text = itemType_;
				bool flag = default(bool);
				if (!flag)
				{
					RepeatedField<string> repeatedField = subItemTypes_;
					bool flag2 = default(bool);
					if (flag2 && isIngredient_ == flag2 && hideButton_ == flag2 && createButton_ == flag2)
					{
						string text2 = invalidText_;
						bool flag3 = default(bool);
						if (!flag3 && required_ == flag3 && object.Equals(filteringMethod_, other) && object.Equals(categoryMethod_, other))
						{
							bool flag4 = object.Equals(itemNameMethod_, other);
							if (flag4 && iconSize_ == (flag4 ? 1 : 0))
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051B7")]
		[Cpp2IlInjected.Address(RVA = "0x22D79A0", Offset = "0x22D63A0", VA = "0x1822D79A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemFieldOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.itemType_;
				if (!(itemType_ != text))
				{
					RepeatedField<string> repeatedField = subItemTypes_;
					RepeatedField<string> repeatedField2 = other.subItemTypes_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						bool flag = other.isIngredient_;
						if (isIngredient_ == flag)
						{
							bool flag2 = other.hideButton_;
							if (hideButton_ == flag2)
							{
								bool flag3 = other.createButton_;
								if (createButton_ == flag3)
								{
									string text2 = other.invalidText_;
									if (!(invalidText_ != text2))
									{
										bool flag4 = other.required_;
										if (required_ == flag4)
										{
											MethodInfo objB = other.filteringMethod_;
											if (object.Equals(filteringMethod_, objB))
											{
												MethodInfo objB2 = other.categoryMethod_;
												if (object.Equals(categoryMethod_, objB2))
												{
													MethodInfo objB3 = other.itemNameMethod_;
													if (object.Equals(itemNameMethod_, objB3))
													{
														int num = other.iconSize_;
														if (iconSize_ == num)
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
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051B8")]
		[Cpp2IlInjected.Address(RVA = "0x22D8180", Offset = "0x22D6B80", VA = "0x1822D8180", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00c6
			string text = itemType_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)subItemTypes_).GetHashCode();
			if (isIngredient_)
			{
			}
			if (hideButton_)
			{
			}
			if (createButton_)
			{
			}
			string text2 = invalidText_;
			if (text2.m_stringLength != 0)
			{
				int hashCode3 = text2.GetHashCode();
			}
			if (required_)
			{
			}
			MethodInfo methodInfo = filteringMethod_;
			if (methodInfo != null)
			{
				int hashCode4 = methodInfo.GetHashCode();
			}
			MethodInfo methodInfo2 = categoryMethod_;
			if (methodInfo2 != null)
			{
				int hashCode5 = methodInfo2.GetHashCode();
			}
			MethodInfo methodInfo3 = itemNameMethod_;
			if (methodInfo3 != null)
			{
				int hashCode6 = methodInfo3.GetHashCode();
			}
			if (iconSize_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60051B9")]
		[Cpp2IlInjected.Address(RVA = "0x22D8BE0", Offset = "0x22D75E0", VA = "0x1822D8BE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60051BA")]
		[Cpp2IlInjected.Address(RVA = "0x22D8C40", Offset = "0x22D7640", VA = "0x1822D8C40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0131
			if (itemType_.m_stringLength != 0)
			{
				string value = itemType_;
				output.WriteString(value);
			}
			RepeatedField<string> repeatedField = subItemTypes_;
			FieldCodec<string> repeated_subItemTypes_codec = _repeated_subItemTypes_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_subItemTypes_codec);
			if (isIngredient_)
			{
				bool value2 = isIngredient_;
				output.WriteBool(value2);
			}
			if (hideButton_)
			{
				bool value3 = hideButton_;
				output.WriteBool(value3);
			}
			if (createButton_)
			{
				bool value4 = createButton_;
				output.WriteBool(value4);
			}
			if (invalidText_.m_stringLength != 0)
			{
				string value5 = invalidText_;
				output.WriteString(value5);
			}
			if (required_)
			{
				bool value6 = required_;
				output.WriteBool(value6);
			}
			if ((long)filteringMethod_ != 0)
			{
				MethodInfo value7 = filteringMethod_;
				output.WriteMessage(value7);
			}
			if ((long)categoryMethod_ != 0)
			{
				MethodInfo value8 = categoryMethod_;
				output.WriteMessage(value8);
			}
			if ((long)itemNameMethod_ != 0)
			{
				MethodInfo value9 = itemNameMethod_;
				output.WriteMessage(value9);
			}
			if (iconSize_ != 0)
			{
				int value10 = iconSize_;
				output.WriteInt32(value10);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60051BB")]
		[Cpp2IlInjected.Address(RVA = "0x22D7580", Offset = "0x22D5F80", VA = "0x1822D7580", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			string text = itemType_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			RepeatedField<string> repeatedField = subItemTypes_;
			FieldCodec<string> repeated_subItemTypes_codec = _repeated_subItemTypes_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_subItemTypes_codec);
			string text2 = invalidText_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				repeatedField = (RepeatedField<string>)(repeatedField + num4);
			}
			MethodInfo methodInfo = filteringMethod_;
			if (methodInfo != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(methodInfo);
				num5 += 2;
				repeatedField = (RepeatedField<string>)(repeatedField + num5);
			}
			MethodInfo methodInfo2 = categoryMethod_;
			if (methodInfo2 != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(methodInfo2);
				num6 += 2;
				repeatedField = (RepeatedField<string>)(repeatedField + num6);
			}
			MethodInfo methodInfo3 = itemNameMethod_;
			if (methodInfo3 != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(methodInfo3);
				num7 += 2;
				repeatedField = (RepeatedField<string>)(repeatedField + num7);
			}
			int num8 = iconSize_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9 += 2;
				repeatedField = (RepeatedField<string>)(repeatedField + num9);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num10 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<string>)(repeatedField + num10);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051BC")]
		[Cpp2IlInjected.Address(RVA = "0x22D8360", Offset = "0x22D6D60", VA = "0x1822D8360", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemFieldOptions other)
		{
			//Discarded unreachable code: IL_0187
			if (other == null)
			{
				return;
			}
			string text = other.itemType_;
			if (text.m_stringLength != 0)
			{
				ItemType = text;
			}
			RepeatedField<string> repeatedField = subItemTypes_;
			RepeatedField<string> repeatedField2 = other.subItemTypes_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			bool flag = other.isIngredient_;
			if (flag)
			{
				isIngredient_ = flag;
			}
			bool flag2 = other.hideButton_;
			if (flag2)
			{
				hideButton_ = flag2;
			}
			bool flag3 = other.createButton_;
			if (flag3)
			{
				createButton_ = flag3;
			}
			string text2 = other.invalidText_;
			if (text2.m_stringLength != 0)
			{
				InvalidText = text2;
			}
			bool flag4 = other.required_;
			if (flag4)
			{
				required_ = flag4;
			}
			if ((long)other.filteringMethod_ != 0)
			{
				MethodInfo methodInfo2 = default(MethodInfo);
				if (filteringMethod_ == null)
				{
					MethodInfo methodInfo = (filteringMethod_ = new MethodInfo());
					methodInfo2 = filteringMethod_;
				}
				MethodInfo other2 = other.filteringMethod_;
				methodInfo2.MergeFrom(other2);
			}
			if ((long)other.categoryMethod_ != 0)
			{
				MethodInfo methodInfo4 = default(MethodInfo);
				if (categoryMethod_ == null)
				{
					MethodInfo methodInfo3 = (categoryMethod_ = new MethodInfo());
					methodInfo4 = categoryMethod_;
				}
				MethodInfo other3 = other.categoryMethod_;
				methodInfo4.MergeFrom(other3);
			}
			if ((long)other.itemNameMethod_ != 0)
			{
				MethodInfo methodInfo6 = default(MethodInfo);
				if (itemNameMethod_ == null)
				{
					MethodInfo methodInfo5 = (itemNameMethod_ = new MethodInfo());
					methodInfo6 = itemNameMethod_;
				}
				MethodInfo other4 = other.itemNameMethod_;
				methodInfo6.MergeFrom(other4);
			}
			int num = other.iconSize_;
			if (num != 0)
			{
				iconSize_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60051BD")]
		[Cpp2IlInjected.Address(RVA = "0x22D8570", Offset = "0x22D6F70", VA = "0x1822D8570", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0189
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 88)
			{
				if ((int)num > 162)
				{
					if (num == 170)
					{
						MethodInfo methodInfo = categoryMethod_;
						if (methodInfo == null)
						{
							MethodInfo methodInfo2 = (categoryMethod_ = new MethodInfo());
						}
						input.ReadMessage(methodInfo);
					}
					MethodInfo methodInfo3 = default(MethodInfo);
					if (num == 178)
					{
						MethodInfo builder = default(MethodInfo);
						if (itemNameMethod_ == null)
						{
							methodInfo3 = (itemNameMethod_ = new MethodInfo());
							builder = itemNameMethod_;
						}
						input.ReadMessage(builder);
					}
					if ((long)methodInfo3 != 240)
					{
						goto IL_0172;
					}
					int num2 = (iconSize_ = input.ReadInt32());
				}
				string text2 = default(string);
				if (num == 98)
				{
					text2 = (InvalidText = input.ReadString());
				}
				bool flag = default(bool);
				if ((long)text2 == 104)
				{
					flag = (required_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_0172;
				}
				MethodInfo builder2 = default(MethodInfo);
				if (filteringMethod_ == null)
				{
					MethodInfo methodInfo4 = (filteringMethod_ = new MethodInfo());
					builder2 = filteringMethod_;
				}
				input.ReadMessage(builder2);
			}
			bool flag4 = default(bool);
			if ((int)num > 18)
			{
				bool flag2 = default(bool);
				if (num == 72)
				{
					flag2 = (isIngredient_ = input.ReadBool());
				}
				bool flag3 = default(bool);
				if (flag2)
				{
					flag3 = (hideButton_ = input.ReadBool());
				}
				if (!flag3)
				{
					goto IL_0172;
				}
				flag4 = (createButton_ = input.ReadBool());
			}
			string text4 = default(string);
			if (flag4)
			{
				text4 = (ItemType = input.ReadString());
			}
			if ((long)text4 == 18)
			{
				RepeatedField<string> repeatedField = subItemTypes_;
				FieldCodec<string> repeated_subItemTypes_codec = _repeated_subItemTypes_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_subItemTypes_codec);
			}
			goto IL_0172;
			IL_0172:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60051BE")]
		[Cpp2IlInjected.Address(RVA = "0x22D7CC0", Offset = "0x22D66C0", VA = "0x1822D7CC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 12)
			{
				string text = itemType_;
			}
			if ((object)typeof(int).TypeHandle != null && (object)typeof(int).TypeHandle != null && (long)typeof(int).TypeHandle != 1 && fieldNumber == 30)
			{
				int num = iconSize_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60051BF")]
		[Cpp2IlInjected.Address(RVA = "0x22D8840", Offset = "0x22D7240", VA = "0x1822D8840", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_001c, IL_0029, IL_0031, IL_0039, IL_0041, IL_0042, IL_004f
			//IL_001b: Expected O, but got I4
			//IL_007d: Expected I4, but got O
			//IL_0085: Expected O, but got I4
			if (fieldNumber - 1 <= 12)
			{
				int num = 0;
				if (value == null || value != null)
				{
					ItemType = (string)num;
					return;
				}
				throw new InvalidCastException();
			}
			if ((object)typeof(string).TypeHandle != null && (object)typeof(string).TypeHandle != null)
			{
				if ((long)typeof(string).TypeHandle != 1)
				{
					if (fieldNumber == 30)
					{
						object obj = default(object);
						iconSize_ = (int)obj;
					}
				}
				else
				{
					itemNameMethod_ = (MethodInfo)0;
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051C0")]
		[Cpp2IlInjected.Address(RVA = "0x22D77C0", Offset = "0x22D61C0", VA = "0x1822D77C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_0044
			//IL_0042: Expected I4, but got I8
			if (fieldNumber - 1 <= 12)
			{
				int num = 0;
				ItemType = "";
			}
			else if ("" != null && "" != null && (long)"" != 1 && fieldNumber == 30)
			{
				iconSize_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051C1")]
		[Cpp2IlInjected.Address(RVA = "0x22D8ED0", Offset = "0x22D78D0", VA = "0x1822D8ED0")]
		static ItemFieldOptions()
		{
			Func<ItemFieldOptions> func = default(Func<ItemFieldOptions>);
			_parser = (MessageParser<ItemFieldOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ItemFieldOptions>)(object)FieldCodec.ForString(18u);
			/*Error: Unexpected end of block*/;
		}
	}
}
