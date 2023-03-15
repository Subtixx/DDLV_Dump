using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200082E")]
	public sealed class PreferredDifficultyToArea : IMessage<PreferredDifficultyToArea>, IMessage, IEquatable<PreferredDifficultyToArea>, IDeepCloneable<PreferredDifficultyToArea>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40020A0")]
		private static readonly MessageParser<PreferredDifficultyToArea> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40020A1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40020A2")]
		public const int DifficultyFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40020A3")]
		private PreferredItemDifficulty difficulty_;

		[Cpp2IlInjected.Token(Token = "0x40020A4")]
		public const int AreasFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40020A5")]
		private static readonly FieldCodec<VillageAreaType> _repeated_areas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40020A6")]
		private readonly RepeatedField<VillageAreaType> areas_;

		[Cpp2IlInjected.Token(Token = "0x17000B28")]
		[DebuggerNonUserCode]
		public static MessageParser<PreferredDifficultyToArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600443C")]
			[Cpp2IlInjected.Address(RVA = "0x7C28D0", Offset = "0x7C12D0", VA = "0x1807C28D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B29")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600443D")]
			[Cpp2IlInjected.Address(RVA = "0x7C2800", Offset = "0x7C1200", VA = "0x1807C2800")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600443E")]
			[Cpp2IlInjected.Address(RVA = "0x7C2930", Offset = "0x7C1330", VA = "0x1807C2930", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2B")]
		[DebuggerNonUserCode]
		public PreferredItemDifficulty Difficulty
		{
			[Cpp2IlInjected.Token(Token = "0x6004442")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return difficulty_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004443")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				difficulty_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2C")]
		[DebuggerNonUserCode]
		public RepeatedField<VillageAreaType> Areas
		{
			[Cpp2IlInjected.Token(Token = "0x6004444")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return areas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600443F")]
		[Cpp2IlInjected.Address(RVA = "0x7C26F0", Offset = "0x7C10F0", VA = "0x1807C26F0")]
		[DebuggerNonUserCode]
		public PreferredDifficultyToArea()
		{
			areas_ = (RepeatedField<VillageAreaType>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6004440")]
		[Cpp2IlInjected.Address(RVA = "0x7C2770", Offset = "0x7C1170", VA = "0x1807C2770")]
		[DebuggerNonUserCode]
		public PreferredDifficultyToArea(PreferredDifficultyToArea other)
		{
			PreferredItemDifficulty preferredItemDifficulty = (difficulty_ = other.difficulty_);
			RepeatedField<VillageAreaType> repeatedField = (areas_ = (RepeatedField<VillageAreaType>)(object)((RepeatedField<T>)(object)other.areas_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004441")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E00", Offset = "0x7C0800", VA = "0x1807C1E00", Slot = "10")]
		[DebuggerNonUserCode]
		public PreferredDifficultyToArea Clone()
		{
			//Discarded unreachable code: IL_003c
			PreferredDifficultyToArea preferredDifficultyToArea = new PreferredDifficultyToArea();
			PreferredItemDifficulty preferredItemDifficulty = (preferredDifficultyToArea.difficulty_ = difficulty_);
			RepeatedField<VillageAreaType> repeatedField = (preferredDifficultyToArea.areas_ = (RepeatedField<VillageAreaType>)(object)((RepeatedField<T>)(object)areas_).Clone());
			UnknownFieldSet unknownFieldSet = (preferredDifficultyToArea._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return preferredDifficultyToArea;
		}

		[Cpp2IlInjected.Token(Token = "0x6004445")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EC0", Offset = "0x7C08C0", VA = "0x1807C1EC0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
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
				if ((IntPtr)(void*)(int)difficulty_ == (IntPtr)typeof(PreferredDifficultyToArea).TypeHandle)
				{
					RepeatedField<VillageAreaType> repeatedField = areas_;
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

		[Cpp2IlInjected.Token(Token = "0x6004446")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FA0", Offset = "0x7C09A0", VA = "0x1807C1FA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PreferredDifficultyToArea other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				PreferredItemDifficulty preferredItemDifficulty = other.difficulty_;
				if (difficulty_ == preferredItemDifficulty)
				{
					RepeatedField<VillageAreaType> repeatedField = areas_;
					RepeatedField<VillageAreaType> repeatedField2 = other.areas_;
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

		[Cpp2IlInjected.Token(Token = "0x6004447")]
		[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0029
			if (difficulty_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)areas_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004448")]
		[Cpp2IlInjected.Address(RVA = "0x7C2380", Offset = "0x7C0D80", VA = "0x1807C2380", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004449")]
		[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0DE0", VA = "0x1807C23E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0031
			if (difficulty_ != 0)
			{
			}
			RepeatedField<VillageAreaType> repeatedField = areas_;
			FieldCodec<VillageAreaType> repeated_areas_codec = _repeated_areas_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_areas_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600444A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CA0", Offset = "0x7C06A0", VA = "0x1807C1CA0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			PreferredItemDifficulty preferredItemDifficulty = difficulty_;
			int num = 0;
			if (preferredItemDifficulty != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)preferredItemDifficulty);
			}
			RepeatedField<VillageAreaType> repeatedField = areas_;
			FieldCodec<VillageAreaType> repeated_areas_codec = _repeated_areas_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_areas_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600444B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2110", Offset = "0x7C0B10", VA = "0x1807C2110", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PreferredDifficultyToArea other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				PreferredItemDifficulty preferredItemDifficulty = other.difficulty_;
				if (preferredItemDifficulty != 0)
				{
					difficulty_ = preferredItemDifficulty;
				}
				RepeatedField<VillageAreaType> repeatedField = areas_;
				RepeatedField<VillageAreaType> repeatedField2 = other.areas_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600444C")]
		[Cpp2IlInjected.Address(RVA = "0x7C21A0", Offset = "0x7C0BA0", VA = "0x1807C21A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0057
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(difficulty_ = (PreferredItemDifficulty)input.ReadInt32());
				}
				num += 4294967280u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<VillageAreaType> repeatedField = areas_;
				FieldCodec<VillageAreaType> repeated_areas_codec = _repeated_areas_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_areas_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600444D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2040", Offset = "0x7C0A40", VA = "0x1807C2040", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				PreferredItemDifficulty preferredItemDifficulty = difficulty_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<VillageAreaType> repeatedField = areas_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600444E")]
		[Cpp2IlInjected.Address(RVA = "0x7C22B0", Offset = "0x7C0CB0", VA = "0x1807C22B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				difficulty_ = (PreferredItemDifficulty)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600444F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D90", Offset = "0x7C0790", VA = "0x1807C1D90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				difficulty_ = PreferredItemDifficulty.None;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<VillageAreaType> repeatedField = areas_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004450")]
		[Cpp2IlInjected.Address(RVA = "0x7C24D0", Offset = "0x7C0ED0", VA = "0x1807C24D0")]
		static PreferredDifficultyToArea()
		{
			Func<PreferredDifficultyToArea> func = default(Func<PreferredDifficultyToArea>);
			MessageParser<PreferredDifficultyToArea> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<PreferredDifficultyToArea>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<VillageAreaType, int> func2 = (Func<VillageAreaType, int>)(object)(Func<T, TResult>)((VillageAreaType x) => (int)x);
			Func<int, VillageAreaType> func3 = (Func<int, VillageAreaType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<PreferredDifficultyToArea>)(object)FieldCodec.ForEnum<VillageAreaType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			/*Error: Unexpected end of block*/;
		}
	}
}
