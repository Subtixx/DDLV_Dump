using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008FC")]
	public sealed class SpawnActionState : IMessage<SpawnActionState>, IMessage, IEquatable<SpawnActionState>, IDeepCloneable<SpawnActionState>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002469")]
		private static readonly MessageParser<SpawnActionState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400246A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400246B")]
		public const int SpawnedObjectsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400246C")]
		private static readonly FieldCodec<GridObjectAddress> _repeated_spawnedObjects_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400246D")]
		private readonly RepeatedField<GridObjectAddress> spawnedObjects_ = (RepeatedField<GridObjectAddress>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000D47")]
		[DebuggerNonUserCode]
		public static MessageParser<SpawnActionState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E06")]
			[Cpp2IlInjected.Address(RVA = "0x1833CF0", Offset = "0x18326F0", VA = "0x181833CF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D48")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E07")]
			[Cpp2IlInjected.Address(RVA = "0x1833C20", Offset = "0x1832620", VA = "0x181833C20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D49")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E08")]
			[Cpp2IlInjected.Address(RVA = "0x1833D50", Offset = "0x1832750", VA = "0x181833D50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D4A")]
		[DebuggerNonUserCode]
		public RepeatedField<GridObjectAddress> SpawnedObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6004E0C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return spawnedObjects_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E09")]
		[Cpp2IlInjected.Address(RVA = "0x1833AA0", Offset = "0x18324A0", VA = "0x181833AA0")]
		[DebuggerNonUserCode]
		public SpawnActionState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0A")]
		[Cpp2IlInjected.Address(RVA = "0x1833B20", Offset = "0x1832520", VA = "0x181833B20")]
		[DebuggerNonUserCode]
		public SpawnActionState(SpawnActionState other)
		{
			RepeatedField<GridObjectAddress> repeatedField = (spawnedObjects_ = (RepeatedField<GridObjectAddress>)(object)((RepeatedField<T>)(object)other.spawnedObjects_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0B")]
		[Cpp2IlInjected.Address(RVA = "0x18332C0", Offset = "0x1831CC0", VA = "0x1818332C0", Slot = "10")]
		[DebuggerNonUserCode]
		public SpawnActionState Clone()
		{
			//Discarded unreachable code: IL_003b
			SpawnActionState spawnActionState = new SpawnActionState();
			RepeatedField<GridObjectAddress> repeatedField = (spawnActionState.spawnedObjects_ = (RepeatedField<GridObjectAddress>)(object)new RepeatedField<T>());
			RepeatedField<GridObjectAddress> repeatedField2 = (spawnActionState.spawnedObjects_ = (RepeatedField<GridObjectAddress>)(object)((RepeatedField<T>)(object)spawnedObjects_).Clone());
			UnknownFieldSet unknownFieldSet = (spawnActionState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return spawnActionState;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0D")]
		[Cpp2IlInjected.Address(RVA = "0x1833480", Offset = "0x1831E80", VA = "0x181833480", Slot = "0")]
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
				RepeatedField<GridObjectAddress> repeatedField = spawnedObjects_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0E")]
		[Cpp2IlInjected.Address(RVA = "0x18333F0", Offset = "0x1831DF0", VA = "0x1818333F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SpawnActionState other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<GridObjectAddress> repeatedField = spawnedObjects_;
				RepeatedField<GridObjectAddress> repeatedField2 = other.spawnedObjects_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0F")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)spawnedObjects_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E10")]
		[Cpp2IlInjected.Address(RVA = "0x18337B0", Offset = "0x18321B0", VA = "0x1818337B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E11")]
		[Cpp2IlInjected.Address(RVA = "0x1833810", Offset = "0x1832210", VA = "0x181833810", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<GridObjectAddress> repeatedField = spawnedObjects_;
			FieldCodec<GridObjectAddress> repeated_spawnedObjects_codec = _repeated_spawnedObjects_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_spawnedObjects_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E12")]
		[Cpp2IlInjected.Address(RVA = "0x1833150", Offset = "0x1831B50", VA = "0x181833150", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<GridObjectAddress> repeatedField = spawnedObjects_;
			FieldCodec<GridObjectAddress> repeated_spawnedObjects_codec = _repeated_spawnedObjects_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_spawnedObjects_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E13")]
		[Cpp2IlInjected.Address(RVA = "0x18335E0", Offset = "0x1831FE0", VA = "0x1818335E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SpawnActionState other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<GridObjectAddress> repeatedField = spawnedObjects_;
				RepeatedField<GridObjectAddress> repeatedField2 = other.spawnedObjects_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E14")]
		[Cpp2IlInjected.Address(RVA = "0x1833660", Offset = "0x1832060", VA = "0x181833660", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<GridObjectAddress> repeatedField = spawnedObjects_;
					FieldCodec<GridObjectAddress> repeated_spawnedObjects_codec = _repeated_spawnedObjects_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_spawnedObjects_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E15")]
		[Cpp2IlInjected.Address(RVA = "0x1833560", Offset = "0x1831F60", VA = "0x181833560", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<GridObjectAddress> repeatedField = spawnedObjects_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E16")]
		[Cpp2IlInjected.Address(RVA = "0x1833750", Offset = "0x1832150", VA = "0x181833750", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6004E17")]
		[Cpp2IlInjected.Address(RVA = "0x1833200", Offset = "0x1831C00", VA = "0x181833200", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_001a
			if (fieldNumber == 1)
			{
				RepeatedField<GridObjectAddress> repeatedField = spawnedObjects_;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E18")]
		[Cpp2IlInjected.Address(RVA = "0x18338D0", Offset = "0x18322D0", VA = "0x1818338D0")]
		static SpawnActionState()
		{
			Func<SpawnActionState> func = default(Func<SpawnActionState>);
			_parser = (MessageParser<SpawnActionState>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<GridObjectAddress> parser = GridObjectAddress._parser;
			uint num = default(uint);
			_parser = (MessageParser<SpawnActionState>)(object)FieldCodec.ForMessage<GridObjectAddress>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
