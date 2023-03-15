using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005C9")]
	public sealed class FeatureDevList : IMessage<FeatureDevList>, IMessage, IEquatable<FeatureDevList>, IDeepCloneable<FeatureDevList>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001F9E")]
		private static readonly MessageParser<FeatureDevList> _parser = (MessageParser<FeatureDevList>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new FeatureDevList()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F9F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FA0")]
		public const int ListFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001FA1")]
		private static readonly FieldCodec<FeatureDevInfo> _repeated_list_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FA2")]
		private readonly RepeatedField<FeatureDevInfo> list_ = (RepeatedField<FeatureDevInfo>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001FA3")]
		public const string EmptyChoice = "(None)";

		[Cpp2IlInjected.Token(Token = "0x170012A1")]
		[DebuggerNonUserCode]
		public static MessageParser<FeatureDevList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004835")]
			[Cpp2IlInjected.Address(RVA = "0x2CA67C0", Offset = "0x2CA51C0", VA = "0x182CA67C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012A2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004836")]
			[Cpp2IlInjected.Address(RVA = "0x2CA6610", Offset = "0x2CA5010", VA = "0x182CA6610")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012A3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004837")]
			[Cpp2IlInjected.Address(RVA = "0x2CA6820", Offset = "0x2CA5220", VA = "0x182CA6820", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012A4")]
		[DebuggerNonUserCode]
		public RepeatedField<FeatureDevInfo> List
		{
			[Cpp2IlInjected.Token(Token = "0x600483B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012A5")]
		public static FeatureDevList Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6004847")]
			[Cpp2IlInjected.Address(RVA = "0x2CA66E0", Offset = "0x2CA50E0", VA = "0x182CA66E0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return ProtoDatabase.Instance.Get<FeatureDevList>("FeatureDev");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004838")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6590", Offset = "0x2CA4F90", VA = "0x182CA6590")]
		[DebuggerNonUserCode]
		public FeatureDevList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004839")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6490", Offset = "0x2CA4E90", VA = "0x182CA6490")]
		[DebuggerNonUserCode]
		public FeatureDevList(FeatureDevList other)
		{
			RepeatedField<FeatureDevInfo> repeatedField = (list_ = (RepeatedField<FeatureDevInfo>)(object)((RepeatedField<T>)(object)other.list_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600483A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5810", Offset = "0x2CA4210", VA = "0x182CA5810", Slot = "10")]
		[DebuggerNonUserCode]
		public FeatureDevList Clone()
		{
			//Discarded unreachable code: IL_003b
			FeatureDevList featureDevList = new FeatureDevList();
			RepeatedField<FeatureDevInfo> repeatedField = (featureDevList.list_ = (RepeatedField<FeatureDevInfo>)(object)new RepeatedField<T>());
			RepeatedField<FeatureDevInfo> repeatedField2 = (featureDevList.list_ = (RepeatedField<FeatureDevInfo>)(object)((RepeatedField<T>)(object)list_).Clone());
			UnknownFieldSet unknownFieldSet = (featureDevList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return featureDevList;
		}

		[Cpp2IlInjected.Token(Token = "0x600483C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5B90", Offset = "0x2CA4590", VA = "0x182CA5B90", Slot = "0")]
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
				RepeatedField<FeatureDevInfo> repeatedField = list_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600483D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5C70", Offset = "0x2CA4670", VA = "0x182CA5C70", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FeatureDevList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<FeatureDevInfo> repeatedField = list_;
				RepeatedField<FeatureDevInfo> repeatedField2 = other.list_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600483E")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)list_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600483F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA61A0", Offset = "0x2CA4BA0", VA = "0x182CA61A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004840")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6200", Offset = "0x2CA4C00", VA = "0x182CA6200", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<FeatureDevInfo> repeatedField = list_;
			FieldCodec<FeatureDevInfo> repeated_list_codec = _repeated_list_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_list_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004841")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5700", Offset = "0x2CA4100", VA = "0x182CA5700", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<FeatureDevInfo> repeatedField = list_;
			FieldCodec<FeatureDevInfo> repeated_list_codec = _repeated_list_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_list_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004842")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5FD0", Offset = "0x2CA49D0", VA = "0x182CA5FD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FeatureDevList other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<FeatureDevInfo> repeatedField = list_;
				RepeatedField<FeatureDevInfo> repeatedField2 = other.list_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004843")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6050", Offset = "0x2CA4A50", VA = "0x182CA6050", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<FeatureDevInfo> repeatedField = list_;
					FieldCodec<FeatureDevInfo> repeated_list_codec = _repeated_list_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_list_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004844")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5D00", Offset = "0x2CA4700", VA = "0x182CA5D00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<FeatureDevInfo> repeatedField = list_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004845")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6140", Offset = "0x2CA4B40", VA = "0x182CA6140", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004846")]
		[Cpp2IlInjected.Address(RVA = "0x2CA57B0", Offset = "0x2CA41B0", VA = "0x182CA57B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<FeatureDevInfo> repeatedField = list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004848")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5B10", Offset = "0x2CA4510", VA = "0x182CA5B10")]
		[IteratorStateMachine(typeof(_003CEnumerateName_003Ed__31))]
		public static IEnumerable<string> EnumerateName([Optional] string currentName, bool includeEmptyChoice = true)
		{
			_003CEnumerateName_003Ed__31 _003CEnumerateName_003Ed__ = new _003CEnumerateName_003Ed__31(-2);
			_003CEnumerateName_003Ed__._003C_003E3__currentName = currentName;
			_003CEnumerateName_003Ed__._003C_003E3__includeEmptyChoice = includeEmptyChoice;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004849")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5D80", Offset = "0x2CA4780", VA = "0x182CA5D80")]
		public static bool IsValid(string name)
		{
			//Discarded unreachable code: IL_005a
			if (!string.IsNullOrEmpty(name) && !string.Equals(name, "(None)"))
			{
				RepeatedField<FeatureDevInfo> repeatedField = ProtoDatabase.Instance.Get<FeatureDevList>("FeatureDev").list_;
				Predicate<FeatureDevInfo> predicate = (Predicate<FeatureDevInfo>)(object)(Predicate<T>)delegate(FeatureDevInfo x)
				{
					//Discarded unreachable code: IL_0014
					string name_ = x.name_;
					return string.Equals(name, name_);
				};
				return ((RepeatedField<>)(object)repeatedField).Any<FeatureDevInfo>((Predicate<>)(object)predicate);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600484A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5940", Offset = "0x2CA4340", VA = "0x182CA5940", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0054
			RepeatedField<FeatureDevInfo> repeatedField = list_;
			Func<FeatureDevInfo, string> _003C_003E9__33_ = _003C_003Ec._003C_003E9__33_0;
			if (_003C_003E9__33_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FeatureDevInfo x) => x.name_);
			}
			int num = Enumerable.Count<string>(Enumerable.Distinct<string>(Enumerable.Select<FeatureDevInfo, string>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__33_)));
			int count = ((RepeatedField<T>)(object)list_).Count;
			if (num != count)
			{
				context.AddError("Cannot have duplicated featuredev name");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600484B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA62C0", Offset = "0x2CA4CC0", VA = "0x182CA62C0")]
		static FeatureDevList()
		{
			MessageParser<FeatureDevInfo> parser = FeatureDevInfo._parser;
			uint num = default(uint);
			_parser = (MessageParser<FeatureDevList>)(object)FieldCodec.ForMessage<FeatureDevInfo>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
