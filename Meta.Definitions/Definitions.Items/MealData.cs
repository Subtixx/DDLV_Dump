using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000287")]
	public sealed class MealData : IMessage<MealData>, IMessage, IEquatable<MealData>, IDeepCloneable<MealData>, IMessageFieldAccessor, IHasSceneRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x40009FC")]
		private static readonly MessageParser<MealData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009FD")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40009FE")]
		public const int IngredientsUsedFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40009FF")]
		private static readonly FieldCodec<int> _repeated_ingredientsUsed_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A00")]
		private readonly RepeatedField<int> ingredientsUsed_;

		[Cpp2IlInjected.Token(Token = "0x4000A01")]
		public const int SceneRestrictionFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000A02")]
		private static readonly FieldCodec<int?> _single_sceneRestriction_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A03")]
		private int? sceneRestriction_;

		[Cpp2IlInjected.Token(Token = "0x1700055A")]
		[DebuggerNonUserCode]
		public static MessageParser<MealData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600183F")]
			[Cpp2IlInjected.Address(RVA = "0x30695D0", Offset = "0x3067FD0", VA = "0x1830695D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001840")]
			[Cpp2IlInjected.Address(RVA = "0x3069500", Offset = "0x3067F00", VA = "0x183069500")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001841")]
			[Cpp2IlInjected.Address(RVA = "0x3069700", Offset = "0x3068100", VA = "0x183069700", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055D")]
		[DebuggerNonUserCode]
		public RepeatedField<int> IngredientsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6001845")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return ingredientsUsed_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055E")]
		[DebuggerNonUserCode]
		public int? SceneRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6001846")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return sceneRestriction_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001847")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
			set
			{
				sceneRestriction_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055F")]
		public Item? SceneRestrictionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001853")]
			[Cpp2IlInjected.Address(RVA = "0x3069630", Offset = "0x3068030", VA = "0x183069630", Slot = "14")]
			get
			{
				if ((object)sceneRestriction_ != null)
				{
					int value = default(int);
					long num = Convert.ToInt64((uint)value);
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001842")]
		[Cpp2IlInjected.Address(RVA = "0x3069480", Offset = "0x3067E80", VA = "0x183069480")]
		[DebuggerNonUserCode]
		public MealData()
		{
			ingredientsUsed_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001843")]
		[Cpp2IlInjected.Address(RVA = "0x30693E0", Offset = "0x3067DE0", VA = "0x1830693E0")]
		[DebuggerNonUserCode]
		public MealData(MealData other)
		{
			RepeatedField<int> repeatedField = (ingredientsUsed_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.ingredientsUsed_).Clone());
			int? num = (sceneRestriction_ = other.sceneRestriction_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001844")]
		[Cpp2IlInjected.Address(RVA = "0x3068950", Offset = "0x3067350", VA = "0x183068950", Slot = "10")]
		[DebuggerNonUserCode]
		public MealData Clone()
		{
			//Discarded unreachable code: IL_003c
			MealData mealData = new MealData();
			RepeatedField<int> repeatedField = (mealData.ingredientsUsed_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)ingredientsUsed_).Clone());
			int? num = (mealData.sceneRestriction_ = sceneRestriction_);
			UnknownFieldSet unknownFieldSet = (mealData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return mealData;
		}

		[Cpp2IlInjected.Token(Token = "0x6001848")]
		[Cpp2IlInjected.Address(RVA = "0x3068A10", Offset = "0x3067410", VA = "0x183068A10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0033: Expected O, but got I4
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
				RepeatedField<int> repeatedField = ingredientsUsed_;
				bool flag = default(bool);
				if (flag)
				{
					int? num2 = sceneRestriction_;
					bool flag2 = default(bool);
					bool flag3 = default(bool);
					if (flag2 != flag3)
					{
						return object.Equals(_unknownFields, flag3);
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001849")]
		[Cpp2IlInjected.Address(RVA = "0x3068B30", Offset = "0x3067530", VA = "0x183068B30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MealData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = ingredientsUsed_;
				RepeatedField<int> repeatedField2 = other.ingredientsUsed_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int? num = sceneRestriction_;
					int? num2 = other.sceneRestriction_;
					bool flag = (object)num == (object)num2;
					if ((object)num == (object)num2 != flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600184A")]
		[Cpp2IlInjected.Address(RVA = "0x3068CE0", Offset = "0x30676E0", VA = "0x183068CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002f
			int hashCode = ((RepeatedField<T>)(object)ingredientsUsed_).GetHashCode();
			int? num = sceneRestriction_;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600184B")]
		[Cpp2IlInjected.Address(RVA = "0x30690E0", Offset = "0x3067AE0", VA = "0x1830690E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600184C")]
		[Cpp2IlInjected.Address(RVA = "0x3069140", Offset = "0x3067B40", VA = "0x183069140", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0040
			RepeatedField<int> repeatedField = ingredientsUsed_;
			FieldCodec<int> repeated_ingredientsUsed_codec = _repeated_ingredientsUsed_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_ingredientsUsed_codec);
			FieldCodec<int?> single_sceneRestriction_codec = _single_sceneRestriction_codec;
			int? value = sceneRestriction_;
			((FieldCodec<T>)(object)single_sceneRestriction_codec).WriteTagAndValue(output, (T)value);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600184D")]
		[Cpp2IlInjected.Address(RVA = "0x30687C0", Offset = "0x30671C0", VA = "0x1830687C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0053
			RepeatedField<int> repeatedField = ingredientsUsed_;
			FieldCodec<int> repeated_ingredientsUsed_codec = _repeated_ingredientsUsed_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_ingredientsUsed_codec);
			FieldCodec<int?> single_sceneRestriction_codec = _single_sceneRestriction_codec;
			int? value = sceneRestriction_;
			int num2 = ((FieldCodec<T>)(object)single_sceneRestriction_codec).CalculateSizeWithTag((T)value);
			num += num2;
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600184E")]
		[Cpp2IlInjected.Address(RVA = "0x3068D90", Offset = "0x3067790", VA = "0x183068D90", Slot = "4")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(MealData other)
		{
			//Discarded unreachable code: IL_0055
			if (other != null)
			{
				RepeatedField<int> repeatedField = ingredientsUsed_;
				RepeatedField<int> repeatedField2 = other.ingredientsUsed_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int? num = other.sceneRestriction_;
				if ((IntPtr)(((object)num == null) ? 1 : 0) == (IntPtr)(void*)num)
				{
					int? num2 = (sceneRestriction_ = other.sceneRestriction_);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600184F")]
		[Cpp2IlInjected.Address(RVA = "0x3068E50", Offset = "0x3067850", VA = "0x183068E50", Slot = "5")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0065
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					break;
				}
				if ((long)input != 4294967293L)
				{
					if (num == 18)
					{
						int? num2 = (int?)((FieldCodec<T>)(object)_single_sceneRestriction_codec).Read(input);
						if ((IntPtr)(((object)num2 == null) ? 1 : 0) != (IntPtr)(void*)num2)
						{
							continue;
						}
						sceneRestriction_ = num2;
					}
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = ingredientsUsed_;
				FieldCodec<int> repeated_ingredientsUsed_codec = _repeated_ingredientsUsed_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_ingredientsUsed_codec);
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001850")]
		[Cpp2IlInjected.Address(RVA = "0x3068C10", Offset = "0x3067610", VA = "0x183068C10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = ingredientsUsed_;
			}
			if (fieldNumber == 2)
			{
				int? num = sceneRestriction_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001851")]
		[Cpp2IlInjected.Address(RVA = "0x3068FF0", Offset = "0x30679F0", VA = "0x183068FF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0013: Expected O, but got I4
			switch (fieldNumber)
			{
			case 2:
				if (value != null)
				{
				}
				sceneRestriction_ = (int?)(object)0;
				break;
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001852")]
		[Cpp2IlInjected.Address(RVA = "0x30688E0", Offset = "0x30672E0", VA = "0x1830688E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected O, but got I8
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = ingredientsUsed_;
			}
			if (fieldNumber == 2)
			{
				sceneRestriction_ = (int?)(object)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001854")]
		[Cpp2IlInjected.Address(RVA = "0x3069270", Offset = "0x3067C70", VA = "0x183069270")]
		static MealData()
		{
			Func<MealData> func = default(Func<MealData>);
			_parser = (MessageParser<MealData>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<MealData>)(object)FieldCodec.ForInt32(10u);
			uint num = default(uint);
			_parser = (MessageParser<MealData>)(object)FieldCodec.ForStructWrapper<int>(num);
			/*Error: Unexpected end of block*/;
		}
	}
}
