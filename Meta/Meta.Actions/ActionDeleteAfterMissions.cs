using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000DF6")]
	public sealed class ActionDeleteAfterMissions : IMessage<ActionDeleteAfterMissions>, IMessage, IEquatable<ActionDeleteAfterMissions>, IDeepCloneable<ActionDeleteAfterMissions>, IMessageFieldAccessor, IAction
	{
		[Cpp2IlInjected.Token(Token = "0x400389B")]
		private static readonly MessageParser<ActionDeleteAfterMissions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400389C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400389D")]
		public const int MissionIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400389E")]
		private int missionID_;

		[Cpp2IlInjected.Token(Token = "0x400389F")]
		public const int ItemIDsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40038A0")]
		private static readonly FieldCodec<int> _repeated_itemIDs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40038A1")]
		private readonly RepeatedField<int> itemIDs_;

		[Cpp2IlInjected.Token(Token = "0x1700143E")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionDeleteAfterMissions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60074D4")]
			[Cpp2IlInjected.Address(RVA = "0x1E2EA10", Offset = "0x1E2D410", VA = "0x181E2EA10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700143F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60074D5")]
			[Cpp2IlInjected.Address(RVA = "0x1E2E850", Offset = "0x1E2D250", VA = "0x181E2E850")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001440")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60074D6")]
			[Cpp2IlInjected.Address(RVA = "0x1E2EA70", Offset = "0x1E2D470", VA = "0x181E2EA70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001441")]
		[DebuggerNonUserCode]
		public int MissionID
		{
			[Cpp2IlInjected.Token(Token = "0x60074DA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return missionID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60074DB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				missionID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001442")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemIDs
		{
			[Cpp2IlInjected.Token(Token = "0x60074DC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return itemIDs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001443")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x60074E8")]
			[Cpp2IlInjected.Address(RVA = "0x1E2E9B0", Offset = "0x1E2D3B0", VA = "0x181E2E9B0")]
			get
			{
				long num = Convert.ToInt64((uint)missionID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001444")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60074EA")]
			[Cpp2IlInjected.Address(RVA = "0x1E2E920", Offset = "0x1E2D320", VA = "0x181E2E920", Slot = "15")]
			get
			{
				long num = Convert.ToInt64((uint)missionID_);
				string text = default(string);
				return "DeleteAfterMissions for " + text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60074D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E7D0", Offset = "0x1E2D1D0", VA = "0x181E2E7D0")]
		[DebuggerNonUserCode]
		public ActionDeleteAfterMissions()
		{
			itemIDs_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60074D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E740", Offset = "0x1E2D140", VA = "0x181E2E740")]
		[DebuggerNonUserCode]
		public ActionDeleteAfterMissions(ActionDeleteAfterMissions other)
		{
			int num = (missionID_ = other.missionID_);
			RepeatedField<int> repeatedField = (itemIDs_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemIDs_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60074D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DE50", Offset = "0x1E2C850", VA = "0x181E2DE50", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionDeleteAfterMissions Clone()
		{
			//Discarded unreachable code: IL_003c
			ActionDeleteAfterMissions actionDeleteAfterMissions = new ActionDeleteAfterMissions();
			int num = (actionDeleteAfterMissions.missionID_ = missionID_);
			RepeatedField<int> repeatedField = (actionDeleteAfterMissions.itemIDs_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)itemIDs_).Clone());
			UnknownFieldSet unknownFieldSet = (actionDeleteAfterMissions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return actionDeleteAfterMissions;
		}

		[Cpp2IlInjected.Token(Token = "0x60074DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DFB0", Offset = "0x1E2C9B0", VA = "0x181E2DFB0", Slot = "0")]
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
				if ((IntPtr)missionID_ == (IntPtr)typeof(ActionDeleteAfterMissions).TypeHandle)
				{
					RepeatedField<int> repeatedField = itemIDs_;
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

		[Cpp2IlInjected.Token(Token = "0x60074DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DF10", Offset = "0x1E2C910", VA = "0x181E2DF10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionDeleteAfterMissions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.missionID_;
				if (missionID_ == num)
				{
					RepeatedField<int> repeatedField = itemIDs_;
					RepeatedField<int> repeatedField2 = other.itemIDs_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60074DF")]
		[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0029
			if (missionID_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)itemIDs_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60074E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E4B0", Offset = "0x1E2CEB0", VA = "0x181E2E4B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60074E1")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E510", Offset = "0x1E2CF10", VA = "0x181E2E510", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (missionID_ != 0)
			{
				int value = missionID_;
				output.WriteInt32(value);
			}
			RepeatedField<int> repeatedField = itemIDs_;
			FieldCodec<int> repeated_itemIDs_codec = _repeated_itemIDs_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemIDs_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60074E2")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DCF0", Offset = "0x1E2C6F0", VA = "0x181E2DCF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			int num = missionID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			RepeatedField<int> repeatedField = itemIDs_;
			FieldCodec<int> repeated_itemIDs_codec = _repeated_itemIDs_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemIDs_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num2 += num5;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60074E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E240", Offset = "0x1E2CC40", VA = "0x181E2E240", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionDeleteAfterMissions other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				int num = other.missionID_;
				if (num != 0)
				{
					missionID_ = num;
				}
				RepeatedField<int> repeatedField = itemIDs_;
				RepeatedField<int> repeatedField2 = other.itemIDs_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60074E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E2D0", Offset = "0x1E2CCD0", VA = "0x181E2E2D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0057
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (missionID_ = input.ReadInt32());
				}
				num += 4294967280u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = itemIDs_;
				FieldCodec<int> repeated_itemIDs_codec = _repeated_itemIDs_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemIDs_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60074E5")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E090", Offset = "0x1E2CA90", VA = "0x181E2E090", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = missionID_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<int> repeatedField = itemIDs_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60074E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E3E0", Offset = "0x1E2CDE0", VA = "0x181E2E3E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				missionID_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60074E7")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DDE0", Offset = "0x1E2C7E0", VA = "0x181E2DDE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				missionID_ = 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<int> repeatedField = itemIDs_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60074E9")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DBD0", Offset = "0x1E2C5D0", VA = "0x181E2DBD0", Slot = "14")]
		public unsafe void Apply(Profile profile, ITransactionContext context)
		{
			//IL_001a: Expected O, but got I4
			int num = missionID_;
			RepeatedField<int> repeatedField = itemIDs_;
			int num2 = default(int);
			Func<int, Item> func = (Func<int, Item>)(object)new Func<T, TResult>(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<int, Item>*/)(&Item.New));
			num2 = 0;
			List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x60074EB")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E160", Offset = "0x1E2CB60", VA = "0x181E2E160")]
		public static bool IsValidItem(Item item)
		{
			//Discarded unreachable code: IL_000e
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60074EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E600", Offset = "0x1E2D000", VA = "0x181E2E600")]
		static ActionDeleteAfterMissions()
		{
			Func<ActionDeleteAfterMissions> func = default(Func<ActionDeleteAfterMissions>);
			_parser = (MessageParser<ActionDeleteAfterMissions>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ActionDeleteAfterMissions>)(object)FieldCodec.ForInt32(18u);
			/*Error: Unexpected end of block*/;
		}
	}
}
