using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004FF")]
	public sealed class LocationVillageArea : IMessage<LocationVillageArea>, IMessage, IEquatable<LocationVillageArea>, IDeepCloneable<LocationVillageArea>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001AB7")]
		private static readonly MessageParser<LocationVillageArea> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001AB8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001AB9")]
		public const int TargetAreasFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001ABA")]
		private static readonly FieldCodec<VillageAreaType> _repeated_targetAreas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001ABB")]
		private readonly RepeatedField<VillageAreaType> targetAreas_ = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000FD4")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationVillageArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003DBC")]
			[Cpp2IlInjected.Address(RVA = "0x38F2920", Offset = "0x38F1320", VA = "0x1838F2920")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003DBD")]
			[Cpp2IlInjected.Address(RVA = "0x38F2850", Offset = "0x38F1250", VA = "0x1838F2850")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003DBE")]
			[Cpp2IlInjected.Address(RVA = "0x38F2980", Offset = "0x38F1380", VA = "0x1838F2980", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD7")]
		[DebuggerNonUserCode]
		public RepeatedField<VillageAreaType> TargetAreas
		{
			[Cpp2IlInjected.Token(Token = "0x6003DC2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetAreas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DBF")]
		[Cpp2IlInjected.Address(RVA = "0x38F27D0", Offset = "0x38F11D0", VA = "0x1838F27D0")]
		[DebuggerNonUserCode]
		public LocationVillageArea()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003DC0")]
		[Cpp2IlInjected.Address(RVA = "0x38F26D0", Offset = "0x38F10D0", VA = "0x1838F26D0")]
		[DebuggerNonUserCode]
		public LocationVillageArea(LocationVillageArea other)
		{
			RepeatedField<VillageAreaType> repeatedField = (targetAreas_ = (RepeatedField<VillageAreaType>)(object)((RepeatedField<T>)(object)other.targetAreas_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003DC1")]
		[Cpp2IlInjected.Address(RVA = "0x38F1EA0", Offset = "0x38F08A0", VA = "0x1838F1EA0", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationVillageArea Clone()
		{
			//Discarded unreachable code: IL_003b
			LocationVillageArea locationVillageArea = new LocationVillageArea();
			RepeatedField<VillageAreaType> repeatedField = (locationVillageArea.targetAreas_ = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>());
			RepeatedField<VillageAreaType> repeatedField2 = (locationVillageArea.targetAreas_ = (RepeatedField<VillageAreaType>)(object)((RepeatedField<T>)(object)targetAreas_).Clone());
			UnknownFieldSet unknownFieldSet = (locationVillageArea._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationVillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DC3")]
		[Cpp2IlInjected.Address(RVA = "0x38F1FD0", Offset = "0x38F09D0", VA = "0x1838F1FD0", Slot = "0")]
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
				RepeatedField<VillageAreaType> repeatedField = targetAreas_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003DC4")]
		[Cpp2IlInjected.Address(RVA = "0x38F20B0", Offset = "0x38F0AB0", VA = "0x1838F20B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationVillageArea other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<VillageAreaType> repeatedField = targetAreas_;
				RepeatedField<VillageAreaType> repeatedField2 = other.targetAreas_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003DC5")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)targetAreas_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DC6")]
		[Cpp2IlInjected.Address(RVA = "0x38F2390", Offset = "0x38F0D90", VA = "0x1838F2390", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003DC7")]
		[Cpp2IlInjected.Address(RVA = "0x38F23F0", Offset = "0x38F0DF0", VA = "0x1838F23F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<VillageAreaType> repeatedField = targetAreas_;
			FieldCodec<VillageAreaType> repeated_targetAreas_codec = _repeated_targetAreas_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_targetAreas_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003DC8")]
		[Cpp2IlInjected.Address(RVA = "0x38F1D90", Offset = "0x38F0790", VA = "0x1838F1D90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<VillageAreaType> repeatedField = targetAreas_;
			FieldCodec<VillageAreaType> repeated_targetAreas_codec = _repeated_targetAreas_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_targetAreas_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DC9")]
		[Cpp2IlInjected.Address(RVA = "0x38F22B0", Offset = "0x38F0CB0", VA = "0x1838F22B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationVillageArea other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<VillageAreaType> repeatedField = targetAreas_;
				RepeatedField<VillageAreaType> repeatedField2 = other.targetAreas_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DCA")]
		[Cpp2IlInjected.Address(RVA = "0x38F21C0", Offset = "0x38F0BC0", VA = "0x1838F21C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<VillageAreaType> repeatedField = targetAreas_;
				FieldCodec<VillageAreaType> repeated_targetAreas_codec = _repeated_targetAreas_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_targetAreas_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DCB")]
		[Cpp2IlInjected.Address(RVA = "0x38F2140", Offset = "0x38F0B40", VA = "0x1838F2140", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<VillageAreaType> repeatedField = targetAreas_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DCC")]
		[Cpp2IlInjected.Address(RVA = "0x38F2330", Offset = "0x38F0D30", VA = "0x1838F2330", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6003DCD")]
		[Cpp2IlInjected.Address(RVA = "0x38F1E40", Offset = "0x38F0840", VA = "0x1838F1E40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<VillageAreaType> repeatedField = targetAreas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DCE")]
		[Cpp2IlInjected.Address(RVA = "0x38F24B0", Offset = "0x38F0EB0", VA = "0x1838F24B0")]
		static LocationVillageArea()
		{
			Func<LocationVillageArea> func = default(Func<LocationVillageArea>);
			MessageParser<LocationVillageArea> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<LocationVillageArea>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<VillageAreaType, int> func2 = (Func<VillageAreaType, int>)(object)(Func<T, TResult>)((VillageAreaType x) => (int)x);
			Func<int, VillageAreaType> func3 = (Func<int, VillageAreaType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<LocationVillageArea>)(object)FieldCodec.ForEnum<VillageAreaType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
