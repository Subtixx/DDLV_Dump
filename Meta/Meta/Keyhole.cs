using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Keyholes;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using UnityEngine.UI;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class Keyhole : IMessage<Keyhole>, IMessage, IEquatable<Keyhole>, IDeepCloneable<Keyhole>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public enum CanAddResult
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			InvalidInventory,
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			InvalidItem,
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			InventoryFull,
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			NotInInventory
		}

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private static readonly MessageParser<Keyhole> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public const int ContentFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private static readonly FieldCodec<KeyholeContent> _repeated_content_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly RepeatedField<KeyholeContent> content_ = (RepeatedField<KeyholeContent>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public const int GUIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private string gUID_ = "";

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public const int CurrentLevelFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int currentLevel_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private KeyholeConfig _config;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[DebuggerNonUserCode]
		public static MessageParser<Keyhole> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x171DF00", Offset = "0x171C900", VA = "0x18171DF00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x171DE30", Offset = "0x171C830", VA = "0x18171DE30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x171DF60", Offset = "0x171C960", VA = "0x18171DF60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[DebuggerNonUserCode]
		public RepeatedField<KeyholeContent> Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return content_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[DebuggerNonUserCode]
		public string GUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return gUID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x171E070", Offset = "0x171CA70", VA = "0x18171E070")]
			set
			{
				string text = (gUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public int CurrentLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return currentLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				currentLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public KeyholeConfig Config
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x171DDB0", Offset = "0x171C7B0", VA = "0x18171DDB0")]
			get
			{
				if ((long)_config == 0)
				{
					KeyholeConfig keyholeConfig = (_config = KeyholeConfig.GetKeyholeConfig(gUID_));
				}
				return (KeyholeConfig)typeof(KeyholeConfig).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x171DBE0", Offset = "0x171C5E0", VA = "0x18171DBE0")]
		[DebuggerNonUserCode]
		public Keyhole()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x171DC80", Offset = "0x171C680", VA = "0x18171DC80")]
		[DebuggerNonUserCode]
		public Keyhole(Keyhole other)
		{
			RepeatedField<KeyholeContent> repeatedField = (content_ = (RepeatedField<KeyholeContent>)(object)((RepeatedField<T>)(object)other.content_).Clone());
			string text = (gUID_ = other.gUID_);
			int num = (currentLevel_ = other.currentLevel_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x171AE00", Offset = "0x1719800", VA = "0x18171AE00", Slot = "10")]
		[DebuggerNonUserCode]
		public Keyhole Clone()
		{
			//Discarded unreachable code: IL_0066
			Keyhole keyhole = new Keyhole();
			RepeatedField<KeyholeContent> repeatedField = (keyhole.content_ = (RepeatedField<KeyholeContent>)(object)new RepeatedField<T>());
			keyhole.gUID_ = "";
			RepeatedField<KeyholeContent> repeatedField2 = (keyhole.content_ = (RepeatedField<KeyholeContent>)(object)((RepeatedField<T>)(object)content_).Clone());
			string text = (keyhole.gUID_ = gUID_);
			int num = (keyhole.currentLevel_ = currentLevel_);
			UnknownFieldSet unknownFieldSet = (keyhole._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return keyhole;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x171B160", Offset = "0x1719B60", VA = "0x18171B160", Slot = "0")]
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
				RepeatedField<KeyholeContent> repeatedField = content_;
				bool flag = default(bool);
				if (flag)
				{
					string text = gUID_;
					bool flag2 = default(bool);
					if (!flag2 && currentLevel_ == (flag2 ? 1 : 0))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x171B250", Offset = "0x1719C50", VA = "0x18171B250", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Keyhole other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<KeyholeContent> repeatedField = content_;
				RepeatedField<KeyholeContent> repeatedField2 = other.content_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					string text = other.gUID_;
					if (!(gUID_ != text))
					{
						int num = other.currentLevel_;
						if (currentLevel_ == num)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x17067A0", Offset = "0x17051A0", VA = "0x1817067A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0048
			int hashCode = ((RepeatedField<T>)(object)content_).GetHashCode();
			string text = gUID_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			if (currentLevel_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x171D370", Offset = "0x171BD70", VA = "0x18171D370", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x171D8F0", Offset = "0x171C2F0", VA = "0x18171D8F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005e
			RepeatedField<KeyholeContent> repeatedField = content_;
			FieldCodec<KeyholeContent> repeated_content_codec = _repeated_content_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_content_codec);
			if (gUID_.m_stringLength != 0)
			{
				string value = gUID_;
				output.WriteString(value);
			}
			if (currentLevel_ != 0)
			{
				int value2 = currentLevel_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1719FA0", Offset = "0x17189A0", VA = "0x181719FA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_007a
			RepeatedField<KeyholeContent> repeatedField = content_;
			FieldCodec<KeyholeContent> repeated_content_codec = _repeated_content_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_content_codec);
			string text = gUID_;
			if (text.m_stringLength != 0)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
				num += num2;
			}
			int num3 = currentLevel_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeInt32Size(num3);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x171BF70", Offset = "0x171A970", VA = "0x18171BF70", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Keyhole other)
		{
			//Discarded unreachable code: IL_0062
			if (other != null)
			{
				RepeatedField<KeyholeContent> repeatedField = content_;
				RepeatedField<KeyholeContent> repeatedField2 = other.content_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				string text = other.gUID_;
				if (text.m_stringLength != 0)
				{
					GUID = text;
				}
				int num = other.currentLevel_;
				if (num != 0)
				{
					currentLevel_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x171BE40", Offset = "0x171A840", VA = "0x18171BE40", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0069
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<KeyholeContent> repeatedField = content_;
					FieldCodec<KeyholeContent> repeated_content_codec = _repeated_content_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_content_codec);
				}
				string text2 = default(string);
				if (num == 18)
				{
					text2 = (GUID = input.ReadString());
				}
				if ((long)text2 == 24)
				{
					int num2 = (currentLevel_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x171B810", Offset = "0x171A210", VA = "0x18171B810", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					int num2 = currentLevel_;
				}
				string text = gUID_;
			}
			RepeatedField<KeyholeContent> repeatedField = content_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x171CD30", Offset = "0x171B730", VA = "0x18171CD30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj = default(object);
					currentLevel_ = (int)obj;
					return;
				}
				default:
					return;
				case 0:
					break;
				}
				if (value == null || value != null)
				{
					return;
				}
			}
			else
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x171AD60", Offset = "0x1719760", VA = "0x18171AD60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					currentLevel_ = 0;
					break;
				case 0:
					GUID = "";
					break;
				}
				return;
			}
			RepeatedField<KeyholeContent> repeatedField = content_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x171B8F0", Offset = "0x171A2F0", VA = "0x18171B8F0")]
		private int GetStackAmount(Item item)
		{
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			RepeatedField<CompletionLevel> levels_ = Config.levels_;
			int index = currentLevel_;
			RepeatedField<KeyholeContent> neededItems_ = ((CompletionLevel)((RepeatedField<T>)(object)levels_)[index]).neededItems_;
			Func<KeyholeContent, bool> func = (Func<KeyholeContent, bool>)(object)(Func<T, TResult>)delegate(KeyholeContent x)
			{
				int itemID2 = x.ItemID;
				throw new NullReferenceException();
			};
			KeyholeContent keyholeContent = Enumerable.FirstOrDefault<KeyholeContent>((IEnumerable<>)(object)neededItems_, (Func<, >)(object)func);
			if (keyholeContent != null)
			{
				return keyholeContent.amount_;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1719BB0", Offset = "0x17185B0", VA = "0x181719BB0")]
		public CanAddResult AddItem(Item item, int amount, ProfileEventDispatcher dispatcher, [Optional] ItemState state, [Optional] bool? inVillage, [Optional] bool? isMissionItem, [Optional] int? characterId, InvActionType reason = InvActionType.None)
		{
			//Discarded unreachable code: IL_011c
			//IL_00ac: Expected O, but got I4
			//IL_0104: Expected I4, but got O
			//IL_010d: Expected O, but got I4
			int num = item.ItemID;
			int num2 = 0;
			CanAddResult canAddResult = default(CanAddResult);
			if (canAddResult == CanAddResult.Success)
			{
				int count = ((RepeatedField<T>)(object)content_).Count;
				if (num2 < count)
				{
					KeyholeContent keyholeContent = (KeyholeContent)((RepeatedField<T>)(object)content_)[num2];
					bool flag = default(bool);
					if (flag)
					{
						int amount_ = keyholeContent.amount_;
						int num3 = default(int);
						num = num3;
						num -= amount_;
						int num4 = Math.Min(amount, num);
					}
					if (amount <= 0)
					{
						goto IL_011a;
					}
					RepeatedField<KeyholeContent> repeatedField = content_;
					num2++;
				}
				if (amount > 0)
				{
					RepeatedField<KeyholeContent> repeatedField2 = content_;
					int num5 = 0;
					int count2 = ((RepeatedField<T>)(object)repeatedField2).Count;
					if (num5 < count2)
					{
						KeyholeContent keyholeContent2 = (KeyholeContent)((RepeatedField<T>)(object)content_)[num5];
						if (keyholeContent2.ItemID != 0)
						{
							keyholeContent2.ItemID = num;
							keyholeContent2.state_ = (ItemState)num5;
							keyholeContent2.amount_ = num5;
						}
						if (amount <= 0)
						{
							goto IL_011a;
						}
						RepeatedField<KeyholeContent> repeatedField3 = content_;
						num5++;
						while (repeatedField3 != null)
						{
						}
					}
					int count3 = ((RepeatedField<T>)(object)content_).Count;
					KeyholeConfig config = Config;
					if (count3 < config.size_)
					{
						KeyholeContent keyholeContent3 = new KeyholeContent();
						keyholeContent3.itemID_ = num;
						keyholeContent3.amount_ = (int)keyholeContent3;
						keyholeContent3.state_ = (ItemState)num5;
						((RepeatedField<T>)(object)content_).Add((T)keyholeContent3);
					}
				}
			}
			goto IL_011a;
			IL_011a:
			return canAddResult;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x171AD40", Offset = "0x1719740", VA = "0x18171AD40")]
		public bool CanTransferItem(Item item, int amount)
		{
			int stackAmount = GetStackAmount(item);
			return amount <= stackAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x171A710", Offset = "0x1719110", VA = "0x18171A710")]
		public CanAddResult CanAddItem(Item item, int amount, [Optional] ItemState state, [Optional] InventoryFullResolution inventoryFullResolution)
		{
			int num = 0;
			CanAddResult result = default(CanAddResult);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x171A740", Offset = "0x1719140", VA = "0x18171A740")]
		public CanAddResult CanAddItem(Item item, int amount, out int? keyholeFullOverflow, [Optional] ItemState state, [Optional] InventoryFullResolution inventoryFullResolution)
		{
			//IL_0010: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			System.Runtime.CompilerServices.Unsafe.As<int?, Nullable<>>(ref keyholeFullOverflow).value = (T)num;
			ItemType itemType = default(ItemType);
			int num2 = default(int);
			if (itemType == ItemType.ActivityItem && num2 != 0)
			{
				RepeatedField<KeyholeContent> repeatedField = content_;
				int num3 = 0;
				int num4 = 0;
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				if (num4 < count)
				{
					if (((RepeatedField<T>)(object)repeatedField).Contains((T)num3))
					{
					}
					KeyholeContent keyholeContent = (KeyholeContent)((RepeatedField<T>)(object)content_)[num3];
					bool flag = default(bool);
					if (flag)
					{
						int amount_ = keyholeContent.amount_;
						amount_ -= num2;
					}
					if (amount <= 0)
					{
						goto IL_00cb;
					}
					RepeatedField<KeyholeContent> repeatedField2 = content_;
					num3++;
				}
				if (amount > 0)
				{
					RepeatedField<KeyholeContent> repeatedField3 = content_;
					int num5 = 0;
					int num6 = 0;
					int count2 = ((RepeatedField<T>)(object)repeatedField3).Count;
					if (num6 < count2)
					{
						if (((KeyholeContent)((RepeatedField<T>)(object)content_)[num5]).ItemID != 0)
						{
						}
						if (amount > 0)
						{
							RepeatedField<KeyholeContent> repeatedField4 = content_;
							num5++;
							while (repeatedField4 != null)
							{
							}
						}
					}
				}
				goto IL_00cb;
			}
			goto IL_011c;
			IL_011c:
			throw new NullReferenceException();
			IL_0118:
			while (amount == 0)
			{
			}
			goto IL_011c;
			IL_00cb:
			int count3 = ((RepeatedField<T>)(object)content_).Count;
			if (amount > 0)
			{
				if ((long)_config == 0)
				{
					KeyholeConfig keyholeConfig = (_config = KeyholeConfig.GetKeyholeConfig(gUID_));
				}
				KeyholeConfig config = _config;
				if (count3 >= config.size_)
				{
					goto IL_0118;
				}
				count3++;
			}
			int num7 = 0;
			goto IL_0118;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x171B6C0", Offset = "0x171A0C0", VA = "0x18171B6C0")]
		public KeyholeContent GetContent(int position)
		{
			return Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)content_, position);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x171B710", Offset = "0x171A110", VA = "0x18171B710")]
		private KeyholeContent GetContent(int position, bool mustAdd)
		{
			//Discarded unreachable code: IL_0039
			if (mustAdd)
			{
				int count = ((RepeatedField<T>)(object)content_).Count;
				int num = position + 1;
				if (count < num)
				{
					RepeatedField<KeyholeContent> repeatedField = content_;
					KeyholeContent item = new KeyholeContent();
					((RepeatedField<T>)(object)repeatedField).Add((T)item);
				}
			}
			return Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)content_, position);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x171D3D0", Offset = "0x171BDD0", VA = "0x18171D3D0")]
		public bool TryGetContent(int position, out KeyholeContent content)
		{
			KeyholeContent keyholeContent = Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)content_, position);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x171CB50", Offset = "0x171B550", VA = "0x18171CB50")]
		public bool RemoveItem(int position, ProfileEventDispatcher dispatcher, [Optional] int? amountToRemove, InvActionType reason = InvActionType.None)
		{
			KeyholeContent keyholeContent = Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)content_, position);
			if (keyholeContent != null && keyholeContent.ItemID == 0)
			{
				int amount_ = keyholeContent.amount_;
				if (keyholeContent.amount_ == 0)
				{
					Item item = (keyholeContent.Item = Item.Invalid);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x171B4F0", Offset = "0x1719EF0", VA = "0x18171B4F0")]
		internal static int? GetAmountToMove(ContainerInventory source, int sourcePosition, Keyhole destination, int? destinationPosition, int? amountToMove)
		{
			//IL_000a: Expected O, but got I8
			bool flag = default(bool);
			int num2 = default(int);
			int price;
			if (flag)
			{
				ulong num = default(ulong);
				price = ((glPlayFab.Disney.BattlePassReward)num).Price;
				KeyholeContent keyholeContent = Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)destination.content_, sourcePosition);
				if (keyholeContent == null || keyholeContent.amount_ <= 0)
				{
					goto IL_0043;
				}
				bool flag2 = default(bool);
				if (flag2)
				{
					int amount_ = keyholeContent.amount_;
					if (amount_ != num2)
					{
						num2 -= amount_;
						goto IL_0043;
					}
				}
			}
			goto IL_0046;
			IL_0046:
			throw new NullReferenceException();
			IL_0043:
			price = num2;
			goto IL_0046;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x171A0E0", Offset = "0x1718AE0", VA = "0x18171A0E0")]
		public static AddItemToKeyhole.Types.Result CanAddItemFromInventory(ContainerInventory source, int sourcePosition, Keyhole destination, int? destinationPosition, [Optional] int? amountToMove)
		{
			//Discarded unreachable code: IL_007b
			int num = 0;
			bool flag = default(bool);
			if (sourcePosition < source.size_ && flag)
			{
				uint iD = source.ID;
				int num2 = 0;
				if (iD == 0)
				{
					KeyholeConfig config = destination.Config;
					int num3 = default(int);
					if (iD == 0 || num3 > 0)
					{
					}
					if (iD == 0)
					{
						RepeatedField<KeyholeContent> repeatedField = destination.content_;
						KeyholeContent keyholeContent = Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)repeatedField, sourcePosition);
						if (repeatedField != null)
						{
							int price = ((glPlayFab.Disney.BattlePassReward)(object)repeatedField).Price;
							bool flag2 = default(bool);
							if (!flag2)
							{
								goto IL_0079;
							}
							uint iD2 = source.ID;
							int size_ = source.size_;
						}
					}
					if ((object)typeof(Item).TypeHandle == null)
					{
					}
					CanAddResult canAddResult = default(CanAddResult);
					if (canAddResult != 0)
					{
					}
				}
			}
			goto IL_0079;
			IL_0079:
			return AddItemToKeyhole.Types.Result.InvalidSourcePosition;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x171C010", Offset = "0x171AA10", VA = "0x18171C010")]
		internal unsafe static AddItemToKeyhole.Types.Result MoveItemFromInventory(ContainerInventory source, int sourcePosition, Keyhole destination, int? destinationPosition, IWorldEventDispatcher dispatcher, [Optional] int? amountToMove)
		{
			//IL_003a: Expected I4, but got I8
			//IL_0051: Expected O, but got I4
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected I4, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_00bf: Expected native int or pointer, but got O
			int num = 0;
			AddItemToKeyhole.Types.Result result = Keyhole.CanAddItemFromInventory(source, sourcePosition, destination, (Nullable<>)destinationPosition, (Nullable<>)destinationPosition);
			if (result == AddItemToKeyhole.Types.Result.Success)
			{
				ContainerInventory.Types.Slot slot = source.GetSlot(sourcePosition);
				if (source.ID == 0)
				{
				}
				int num2 = 0;
				uint iD = source.ID;
				int position = default(int);
				ulong num3 = default(ulong);
				KeyholeContent content = destination.GetContent(position, (byte)num3 != 0);
				bool flag = default(bool);
				if (((ContentSizeFitter)(object)destination).horizontalFit == ContentSizeFitter.FitMode.Unconstrained && flag)
				{
					int price = ((glPlayFab.Disney.BattlePassReward)iD).Price;
					int num4 = default(int);
					if ((IntPtr)source != (IntPtr)num4)
					{
						num4 -= source;
						price = num4;
						uint num5 = default(uint);
						((int*)num4)->m_value = (int)num5;
						if (num4 != 0)
						{
						}
						if (num5 != 2 || num4 != 0)
						{
						}
						RepeatedField<CompletionLevel> levels_ = destination.Config.levels_;
						int index = destination.currentLevel_;
						RepeatedField<KeyholeContent> neededItems_ = ((CompletionLevel)((RepeatedField<T>)(object)levels_)[index]).neededItems_;
						if (!Keyhole.IsKeyholeLevelCompleted(destination, (IEnumerable<>)(object)neededItems_))
						{
						}
						goto IL_00ab;
					}
				}
				int num7 = (((glPlayFab.Disney.BattlePassReward)destinationPosition).Price = (int)result);
				if ((object)destinationPosition != null)
				{
				}
				uint num8 = default(uint);
				((Nullable<>*)(IntPtr)(void*)destinationPosition)->value = (T)num8;
				throw new NullReferenceException();
			}
			goto IL_00ab;
			IL_00ab:
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x171B300", Offset = "0x1719D00", VA = "0x18171B300")]
		internal static int? GetAmountToMove(Keyhole source, int sourcePosition, ContainerInventory destination, int? destinationPosition, int? amountToMove)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected I4, but got Unknown
			KeyholeContent keyholeContent = Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)source.content_, sourcePosition);
			ContainerInventoryStackData stackData = destination.StackData;
			int itemID = keyholeContent.ItemID;
			bool flag = default(bool);
			int num = default(int);
			if (flag)
			{
				bool flag2 = default(bool);
				if (!flag2 || (IntPtr)keyholeContent == (IntPtr)num)
				{
					goto IL_0033;
				}
				num -= keyholeContent;
			}
			itemID = num;
			goto IL_0033;
			IL_0033:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x171A3F0", Offset = "0x1718DF0", VA = "0x18171A3F0")]
		public static RemoveItemFromKeyhole.Types.Result CanAddItemToInventory(Keyhole source, int sourcePosition, ContainerInventory destination, int? destinationPosition, [Optional] int? amountToMove)
		{
			//Discarded unreachable code: IL_0036, IL_003a, IL_003f, IL_0041, IL_0045, IL_0052, IL_0072, IL_007e, IL_0083, IL_0086, IL_008a
			KeyholeConfig config = source.Config;
			if (sourcePosition < config.size_)
			{
				RepeatedField<KeyholeContent> repeatedField = source.content_;
				KeyholeContent keyholeContent = Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)repeatedField, sourcePosition);
				if (repeatedField != null)
				{
					int price = ((glPlayFab.Disney.BattlePassReward)(object)repeatedField).Price;
					int num = 0;
					if (price == 0)
					{
						return RemoveItemFromKeyhole.Types.Result.InvalidDestinationPosition;
					}
				}
			}
			return RemoveItemFromKeyhole.Types.Result.InvalidSourcePosition;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x171C600", Offset = "0x171B000", VA = "0x18171C600")]
		internal unsafe static RemoveItemFromKeyhole.Types.Result MoveItemToInventory(Keyhole source, int sourcePosition, ContainerInventory destination, int? destinationPosition, IWorldEventDispatcher dispatcher, [Optional] int? amountToMove)
		{
			//IL_0041: Expected I4, but got I8
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected I4, but got Unknown
			//IL_009f: Expected O, but got I4
			//IL_009a: Expected native int or pointer, but got O
			int num = 0;
			RemoveItemFromKeyhole.Types.Result result = Keyhole.CanAddItemToInventory(source, sourcePosition, destination, (Nullable<>)destinationPosition, (Nullable<>)destinationPosition);
			if (result == RemoveItemFromKeyhole.Types.Result.Success)
			{
				RepeatedField<KeyholeContent> repeatedField = source.content_;
				KeyholeContent keyholeContent = Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)repeatedField, sourcePosition);
				if (((glPlayFab.Disney.BattlePassReward)(object)repeatedField).Price == 0)
				{
				}
				int num2 = 0;
				int price = ((glPlayFab.Disney.BattlePassReward)(object)repeatedField).Price;
				int position = default(int);
				ulong num3 = default(ulong);
				ContainerInventory.Types.Slot slot = destination.GetSlot(position, (byte)num3 != 0);
				bool flag = default(bool);
				if (destination.ID == 0 && flag)
				{
					ContainerInventoryStackData stackData = destination.StackData;
					uint iD = destination.ID;
					int num4 = default(int);
					if ((IntPtr)destination != (IntPtr)num4)
					{
						num4 -= destination;
						uint num5 = default(uint);
						((int*)num4)->m_value = (int)num5;
						if (num4 != 0)
						{
						}
						if (num5 == 2 && num4 == 0)
						{
						}
						goto IL_0086;
					}
				}
				int num7 = (((glPlayFab.Disney.BattlePassReward)destinationPosition).Price = (int)result);
				if ((object)destinationPosition != null)
				{
				}
				uint num8 = default(uint);
				((Nullable<>*)(IntPtr)(void*)destinationPosition)->value = (T)num8;
				throw new NullReferenceException();
			}
			goto IL_0086;
			IL_0086:
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x171AAD0", Offset = "0x17194D0", VA = "0x18171AAD0")]
		public static SwapItemInKeyhole.Types.Result CanSwapItemInKeyhole(Keyhole keyhole, int sourcePosition, int destinationPosition, [Optional] int? amountToMove)
		{
			//Discarded unreachable code: IL_006b
			KeyholeConfig config = keyhole.Config;
			if (sourcePosition < config.size_)
			{
				KeyholeContent keyholeContent = Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)keyhole.content_, sourcePosition);
				if (keyholeContent != null && keyholeContent.ItemID == 0)
				{
					KeyholeConfig config2 = keyhole.Config;
					if (destinationPosition < config2.size_)
					{
						int num = default(int);
						int num2 = default(int);
						if (num <= 0 || num2 > keyholeContent.amount_)
						{
							return Meta.SwapItemInKeyhole.Types.Result.NotEnoughItems;
						}
						int itemID = keyholeContent.ItemID;
						ItemState state_ = keyholeContent.state_;
						int num3 = 0;
						CanAddResult canAddResult = default(CanAddResult);
						if (canAddResult != 0)
						{
							return Meta.SwapItemInKeyhole.Types.Result.NotEnoughSpaceToTransfer;
						}
						int num4 = 0;
					}
					return Meta.SwapItemInKeyhole.Types.Result.InvalidDestinationPosition;
				}
			}
			return Meta.SwapItemInKeyhole.Types.Result.InvalidSourcePosition;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x171CE60", Offset = "0x171B860", VA = "0x18171CE60")]
		internal unsafe static SwapItemInKeyhole.Types.Result SwapItemInKeyhole(Keyhole keyhole, int sourcePosition, int destinationPosition, IWorldEventDispatcher dispatcher, [Optional] int? amountToMove)
		{
			//Discarded unreachable code: IL_0077
			//IL_002d: Expected I4, but got I8
			//IL_0043: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			int num = 0;
			SwapItemInKeyhole.Types.Result result = default(SwapItemInKeyhole.Types.Result);
			if (result == Meta.SwapItemInKeyhole.Types.Result.Success)
			{
				RepeatedField<KeyholeContent> repeatedField = keyhole.content_;
				KeyholeContent keyholeContent = Enumerable.ElementAtOrDefault<KeyholeContent>((IEnumerable<>)(object)repeatedField, sourcePosition);
				int num2 = 0;
				if (((glPlayFab.Disney.BattlePassReward)(object)repeatedField).Price == 0)
				{
				}
				ulong num3 = default(ulong);
				KeyholeContent content = keyhole.GetContent(sourcePosition, (byte)num3 != 0);
				bool flag = default(bool);
				if (((ContentSizeFitter)(object)keyhole).horizontalFit == ContentSizeFitter.FitMode.Unconstrained && flag)
				{
					int price = ((glPlayFab.Disney.BattlePassReward)destinationPosition).Price;
					if (keyhole == null)
					{
					}
					price = destinationPosition;
				}
				int num4 = default(int);
				if (num4 == 0)
				{
				}
				((glPlayFab.Disney.BattlePassReward)destinationPosition).Price = num4;
				if (destinationPosition != 0)
				{
				}
				((int*)destinationPosition)->m_value = num;
				uint num5 = default(uint);
				if (dispatcher != null && num < (int)num5)
				{
					num += num;
					num++;
				}
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x171D800", Offset = "0x171C200", VA = "0x18171D800")]
		internal static void ValidateKeyholeCompletion(Keyhole keyhole, IWorldEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0032
			RepeatedField<CompletionLevel> levels_ = keyhole.Config.levels_;
			int index = keyhole.currentLevel_;
			RepeatedField<KeyholeContent> neededItems_ = ((CompletionLevel)((RepeatedField<T>)(object)levels_)[index]).neededItems_;
			if (Keyhole.IsKeyholeLevelCompleted(keyhole, (IEnumerable<>)(object)neededItems_))
			{
				CompleteKeyholeLevel(keyhole, dispatcher);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x171AF60", Offset = "0x1719960", VA = "0x18171AF60")]
		internal static void CompleteKeyholeLevel(Keyhole keyhole, IWorldEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0069
			if (((RepeatedField<T>)(object)keyhole.Config.levels_).Count > keyhole.currentLevel_)
			{
				RepeatedField<CompletionLevel> levels_ = keyhole.Config.levels_;
				int index = keyhole.currentLevel_;
				RepeatedField<KeyholeContent> neededItems_ = ((CompletionLevel)((RepeatedField<T>)(object)levels_)[index]).neededItems_;
				if (!Keyhole.IsKeyholeLevelCompleted(keyhole, (IEnumerable<>)(object)neededItems_))
				{
					((RepeatedField<T>)(object)keyhole.content_).Clear();
				}
			}
			if (dispatcher != null)
			{
				int num = 0;
				int num2 = keyhole.currentLevel_;
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x171BA20", Offset = "0x171A420", VA = "0x18171BA20")]
		public static bool IsKeyholeCompleted(Keyhole keyhole)
		{
			//Discarded unreachable code: IL_0048
			if (((RepeatedField<T>)(object)keyhole.Config.levels_).Count > keyhole.currentLevel_)
			{
				RepeatedField<CompletionLevel> levels_ = keyhole.Config.levels_;
				int index = keyhole.currentLevel_;
				RepeatedField<KeyholeContent> neededItems_ = ((CompletionLevel)((RepeatedField<T>)(object)levels_)[index]).neededItems_;
				bool flag = Keyhole.IsKeyholeLevelCompleted(keyhole, (IEnumerable<>)(object)neededItems_);
				if (!flag)
				{
					return flag;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x171BB20", Offset = "0x171A520", VA = "0x18171BB20")]
		private static bool IsKeyholeLevelCompleted(Keyhole keyhole, IEnumerable<KeyholeContent> neededItemEnumerable)
		{
			//Discarded unreachable code: IL_003b, IL_0041, IL_0047, IL_004d
			//IL_0036: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			List<KeyholeContent> list = (List<KeyholeContent>)(object)Enumerable.ToList<KeyholeContent>((IEnumerable<>)neededItemEnumerable);
			RepeatedField<KeyholeContent> repeatedField = keyhole.content_;
			bool flag = default(bool);
			if (flag)
			{
				int num3 = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
					int num4 = default(int);
					while (num4 == 0)
					{
					}
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
				}
				while (num3 == 0)
				{
				}
				bool flag4 = ((List<T>)(object)list).Remove((T)num3);
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8FED40", Offset = "0x8FD740", VA = "0x1808FED40")]
		public bool IsValidKeyholeItem(Item item)
		{
			ItemType itemType = default(ItemType);
			return itemType == ItemType.ActivityItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x171DA10", Offset = "0x171C410", VA = "0x18171DA10")]
		static Keyhole()
		{
			Func<Keyhole> func = default(Func<Keyhole>);
			_parser = (MessageParser<Keyhole>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<KeyholeContent> parser = KeyholeContent._parser;
			uint num = default(uint);
			_parser = (MessageParser<Keyhole>)(object)FieldCodec.ForMessage<KeyholeContent>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
