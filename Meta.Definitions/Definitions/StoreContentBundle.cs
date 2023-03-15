using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class StoreContentBundle : IMessage<StoreContentBundle>, IMessage, IEquatable<StoreContentBundle>, IDeepCloneable<StoreContentBundle>, IMessageFieldAccessor, IStoreContentType
	{
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private static readonly MessageParser<StoreContentBundle> _parser = (MessageParser<StoreContentBundle>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new StoreContentBundle()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public const int IdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private string id_;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public const int OverrideAvailablePricesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private static readonly FieldCodec<ContentPrice> _repeated_overrideAvailablePrices_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private readonly RepeatedField<ContentPrice> overrideAvailablePrices_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private OnlineBundleData data;

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreContentBundle> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x2635E70", Offset = "0x2634870", VA = "0x182635E70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x2635BB0", Offset = "0x26345B0", VA = "0x182635BB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x2635FC0", Offset = "0x26349C0", VA = "0x182635FC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		[DebuggerNonUserCode]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return id_;
			}
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x26360D0", Offset = "0x2634AD0", VA = "0x1826360D0")]
			set
			{
				string text = (id_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		[DebuggerNonUserCode]
		public RepeatedField<ContentPrice> OverrideAvailablePrices
		{
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return overrideAvailablePrices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
			get
			{
				return id_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0x2635E50", Offset = "0x2634850", VA = "0x182635E50", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.title_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public List<StoreContent.ItemReward> Items
		{
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x2635CF0", Offset = "0x26346F0", VA = "0x182635CF0", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0038
				RepeatedField<OnlineBundleData.Types.BundleContent> contents_ = Data.contents_;
				Func<OnlineBundleData.Types.BundleContent, StoreContent.ItemReward> _003C_003E9__38_ = _003C_003Ec._003C_003E9__38_0;
				if (_003C_003E9__38_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						int num = 0;
						ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
						throw new NullReferenceException();
					};
				}
				return (List<StoreContent.ItemReward>)(object)Enumerable.ToList<StoreContent.ItemReward>(Enumerable.Select<OnlineBundleData.Types.BundleContent, StoreContent.ItemReward>((IEnumerable<>)(object)contents_, (Func<, >)(object)_003C_003E9__38_));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public List<ContentPrice> Prices
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x2635ED0", Offset = "0x26348D0", VA = "0x182635ED0", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_001c, IL_003d
				OnlineBundleData onlineBundleData;
				do
				{
					if (((RepeatedField<T>)(object)overrideAvailablePrices_).Count > 0)
					{
						return (List<ContentPrice>)(object)Enumerable.ToList<ContentPrice>((IEnumerable<>)(object)overrideAvailablePrices_);
					}
					onlineBundleData = Data;
				}
				while (onlineBundleData != null && Enumerable.ToList<ContentPrice>((IEnumerable<>)(object)onlineBundleData.availablePrices_) != null);
				return (List<ContentPrice>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x2635FA0", Offset = "0x26349A0", VA = "0x182635FA0", Slot = "18")]
			get
			{
				OnlineBundleData onlineBundleData;
				do
				{
					onlineBundleData = Data;
				}
				while (onlineBundleData == null);
				return onlineBundleData.version_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x2635CB0", Offset = "0x26346B0", VA = "0x182635CB0", Slot = "19")]
			get
			{
				//Discarded unreachable code: IL_0015
				if (Data == null)
				{
				}
				return Data.active_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public OnlineBundleData Data
		{
			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0x2635AB0", Offset = "0x26344B0", VA = "0x182635AB0")]
			get
			{
				//Discarded unreachable code: IL_0029
				OnlineBundleData onlineBundleData = data;
				if (onlineBundleData == null)
				{
					ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
					string text = id_;
					OnlineBundleData onlineBundleData2 = (data = _003CInstance_003Ek__BackingField.Get<OnlineBundleData>(text));
				}
				return onlineBundleData;
			}
			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				data = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public IAPData BundleIAPData
		{
			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0x2635A80", Offset = "0x2634480", VA = "0x182635A80")]
			get
			{
				OnlineBundleData onlineBundleData;
				do
				{
					onlineBundleData = Data;
				}
				while (onlineBundleData == null);
				return onlineBundleData.MyIAPData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public bool IsInAppPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0x2635C80", Offset = "0x2634680", VA = "0x182635C80")]
			get
			{
				OnlineBundleData onlineBundleData = Data;
				if (onlineBundleData != null)
				{
					return onlineBundleData.MyIAPData != null;
				}
				return onlineBundleData != null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x26359E0", Offset = "0x26343E0", VA = "0x1826359E0")]
		[DebuggerNonUserCode]
		public StoreContentBundle()
		{
			id_ = "";
			overrideAvailablePrices_ = (RepeatedField<ContentPrice>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x2635940", Offset = "0x2634340", VA = "0x182635940")]
		[DebuggerNonUserCode]
		public StoreContentBundle(StoreContentBundle other)
		{
			string text = (id_ = other.id_);
			RepeatedField<ContentPrice> repeatedField = (overrideAvailablePrices_ = (RepeatedField<ContentPrice>)(object)((RepeatedField<T>)(object)other.overrideAvailablePrices_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2635060", Offset = "0x2633A60", VA = "0x182635060", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreContentBundle Clone()
		{
			//Discarded unreachable code: IL_003c
			StoreContentBundle storeContentBundle = new StoreContentBundle();
			string text = (storeContentBundle.id_ = id_);
			RepeatedField<ContentPrice> repeatedField = (storeContentBundle.overrideAvailablePrices_ = (RepeatedField<ContentPrice>)(object)((RepeatedField<T>)(object)overrideAvailablePrices_).Clone());
			UnknownFieldSet unknownFieldSet = (storeContentBundle._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storeContentBundle;
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x26351E0", Offset = "0x2633BE0", VA = "0x1826351E0", Slot = "0")]
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
				string text = id_;
				bool flag = default(bool);
				if (!flag)
				{
					RepeatedField<ContentPrice> repeatedField = overrideAvailablePrices_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x2635130", Offset = "0x2633B30", VA = "0x182635130", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreContentBundle other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.id_;
				if (!(id_ != text))
				{
					RepeatedField<ContentPrice> repeatedField = overrideAvailablePrices_;
					RepeatedField<ContentPrice> repeatedField2 = other.overrideAvailablePrices_;
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

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x218CDE0", Offset = "0x218B7E0", VA = "0x18218CDE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0038
			string text = id_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)overrideAvailablePrices_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x2635620", Offset = "0x2634020", VA = "0x182635620", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x2635680", Offset = "0x2634080", VA = "0x182635680", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0044
			if (id_.m_stringLength != 0)
			{
				string value = id_;
				output.WriteString(value);
			}
			RepeatedField<ContentPrice> repeatedField = overrideAvailablePrices_;
			FieldCodec<ContentPrice> repeated_overrideAvailablePrices_codec = _repeated_overrideAvailablePrices_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_overrideAvailablePrices_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2634E90", Offset = "0x2633890", VA = "0x182634E90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0053
			string text = id_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			RepeatedField<ContentPrice> repeatedField = overrideAvailablePrices_;
			FieldCodec<ContentPrice> repeated_overrideAvailablePrices_codec = _repeated_overrideAvailablePrices_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_overrideAvailablePrices_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2635360", Offset = "0x2633D60", VA = "0x182635360", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreContentBundle other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.id_;
				if (text.m_stringLength != 0)
				{
					Id = text;
				}
				RepeatedField<ContentPrice> repeatedField = overrideAvailablePrices_;
				RepeatedField<ContentPrice> repeatedField2 = other.overrideAvailablePrices_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2635400", Offset = "0x2633E00", VA = "0x182635400", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0052
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Id = input.ReadString());
				}
				if (num == 18)
				{
					RepeatedField<ContentPrice> repeatedField = overrideAvailablePrices_;
					FieldCodec<ContentPrice> repeated_overrideAvailablePrices_codec = _repeated_overrideAvailablePrices_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_overrideAvailablePrices_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x26352D0", Offset = "0x2633CD0", VA = "0x1826352D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = id_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<ContentPrice> repeatedField = overrideAvailablePrices_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2635510", Offset = "0x2633F10", VA = "0x182635510", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					string text = (id_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
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

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2634F90", Offset = "0x2633990", VA = "0x182634F90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (id_ = ProtoPreconditions.CheckNotNull("", "value"));
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<ContentPrice> repeatedField = overrideAvailablePrices_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x2635770", Offset = "0x2634170", VA = "0x182635770")]
		static StoreContentBundle()
		{
			MessageParser<ContentPrice> parser = ContentPrice._parser;
			uint num = default(uint);
			_parser = (MessageParser<StoreContentBundle>)(object)FieldCodec.ForMessage<ContentPrice>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
