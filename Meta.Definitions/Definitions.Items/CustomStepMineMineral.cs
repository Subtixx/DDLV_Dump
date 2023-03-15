using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004AE")]
	public sealed class CustomStepMineMineral : IMessage<CustomStepMineMineral>, IMessage, IEquatable<CustomStepMineMineral>, IDeepCloneable<CustomStepMineMineral>, IMessageFieldAccessor, IStepAmount, IStringTag, IItemSelector, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001906")]
		private static readonly MessageParser<CustomStepMineMineral> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001907")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001908")]
		public const int AcceptMiningFailureFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001909")]
		private bool acceptMiningFailure_;

		[Cpp2IlInjected.Token(Token = "0x400190A")]
		public const int TargetItemFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400190B")]
		private ItemSelector targetItem_;

		[Cpp2IlInjected.Token(Token = "0x400190C")]
		public const int TargetAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400190D")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x400190E")]
		public const int LocationsFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400190F")]
		private static readonly FieldCodec<ActivityDataLocationFilter> _repeated_locations_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001910")]
		private readonly RepeatedField<ActivityDataLocationFilter> locations_ = (RepeatedField<ActivityDataLocationFilter>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001911")]
		public const int WithFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001912")]
		private HangoutWithCharacter with_;

		[Cpp2IlInjected.Token(Token = "0x17000EAE")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepMineMineral> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600398F")]
			[Cpp2IlInjected.Address(RVA = "0x34F5200", Offset = "0x34F3C00", VA = "0x1834F5200")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EAF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003990")]
			[Cpp2IlInjected.Address(RVA = "0x34F5130", Offset = "0x34F3B30", VA = "0x1834F5130")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003991")]
			[Cpp2IlInjected.Address(RVA = "0x34F5400", Offset = "0x34F3E00", VA = "0x1834F5400", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB1")]
		[DebuggerNonUserCode]
		public bool AcceptMiningFailure
		{
			[Cpp2IlInjected.Token(Token = "0x6003996")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return acceptMiningFailure_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003997")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				acceptMiningFailure_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB2")]
		[DebuggerNonUserCode]
		public ItemSelector TargetItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003998")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return targetItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003999")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				targetItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB3")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600399A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600399B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB4")]
		[DebuggerNonUserCode]
		public RepeatedField<ActivityDataLocationFilter> Locations
		{
			[Cpp2IlInjected.Token(Token = "0x600399C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return locations_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB5")]
		[DebuggerNonUserCode]
		public HangoutWithCharacter With
		{
			[Cpp2IlInjected.Token(Token = "0x600399D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return with_;
			}
			[Cpp2IlInjected.Token(Token = "0x600399E")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				with_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB6")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60039AA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "14")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB7")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x60039AB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return targetItem_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EB8")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x60039AC")]
			[Cpp2IlInjected.Address(RVA = "0x34F5260", Offset = "0x34F3C60", VA = "0x1834F5260", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_005d
				string[] array;
				while (true)
				{
					array = new string[3];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[1] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[2] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003992")]
		[Cpp2IlInjected.Address(RVA = "0x34F4DC0", Offset = "0x34F37C0", VA = "0x1834F4DC0")]
		[DebuggerNonUserCode]
		public CustomStepMineMineral()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003993")]
		[Cpp2IlInjected.Address(RVA = "0x34F47A0", Offset = "0x34F31A0", VA = "0x1834F47A0")]
		private void OnConstruction()
		{
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003994")]
		[Cpp2IlInjected.Address(RVA = "0x34F4EF0", Offset = "0x34F38F0", VA = "0x1834F4EF0")]
		[DebuggerNonUserCode]
		public CustomStepMineMineral(CustomStepMineMineral other)
		{
			//IL_006b: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			ItemSelector itemSelector = (targetItem_ = new ItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
			bool flag = other.acceptMiningFailure_;
			int num = 0;
			acceptMiningFailure_ = flag;
			ItemSelector itemSelector2 = other.targetItem_;
			if (itemSelector2 != null)
			{
				ItemSelector itemSelector3 = itemSelector2.Clone();
			}
			targetItem_ = (ItemSelector)num;
			StepAmount stepAmount2 = other.targetAmount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			targetAmount_ = (StepAmount)num;
			RepeatedField<ActivityDataLocationFilter> repeatedField = (locations_ = (RepeatedField<ActivityDataLocationFilter>)(object)((RepeatedField<T>)(object)other.locations_).Clone());
			HangoutWithCharacter hangoutWithCharacter2 = other.with_;
			HangoutWithCharacter hangoutWithCharacter3 = default(HangoutWithCharacter);
			if (hangoutWithCharacter2 != null)
			{
				hangoutWithCharacter3 = hangoutWithCharacter2.Clone();
			}
			with_ = hangoutWithCharacter3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003995")]
		[Cpp2IlInjected.Address(RVA = "0x34F3E40", Offset = "0x34F2840", VA = "0x1834F3E40", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepMineMineral Clone()
		{
			return new CustomStepMineMineral(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600399F")]
		[Cpp2IlInjected.Address(RVA = "0x34F3FC0", Offset = "0x34F29C0", VA = "0x1834F3FC0", Slot = "0")]
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
				if ((IntPtr)(acceptMiningFailure_ ? 1 : 0) == (IntPtr)typeof(CustomStepMineMineral).TypeHandle && object.Equals(targetItem_, other) && object.Equals(targetAmount_, other))
				{
					RepeatedField<ActivityDataLocationFilter> repeatedField = locations_;
					bool flag = default(bool);
					if (flag && object.Equals(with_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039A0")]
		[Cpp2IlInjected.Address(RVA = "0x34F40F0", Offset = "0x34F2AF0", VA = "0x1834F40F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepMineMineral other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.acceptMiningFailure_;
				if (acceptMiningFailure_ == flag)
				{
					ItemSelector objB = other.targetItem_;
					if (object.Equals(targetItem_, objB))
					{
						StepAmount objB2 = other.targetAmount_;
						if (object.Equals(targetAmount_, objB2))
						{
							RepeatedField<ActivityDataLocationFilter> repeatedField = locations_;
							RepeatedField<ActivityDataLocationFilter> repeatedField2 = other.locations_;
							if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
							{
								HangoutWithCharacter objB3 = other.with_;
								if (object.Equals(with_, objB3))
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039A1")]
		[Cpp2IlInjected.Address(RVA = "0x34F42E0", Offset = "0x34F2CE0", VA = "0x1834F42E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006c
			if (acceptMiningFailure_)
			{
			}
			ItemSelector itemSelector = targetItem_;
			if (itemSelector != null)
			{
				int hashCode = itemSelector.GetHashCode();
			}
			StepAmount stepAmount = targetAmount_;
			if (stepAmount != null)
			{
				int hashCode2 = stepAmount.GetHashCode();
			}
			int hashCode3 = ((RepeatedField<T>)(object)locations_).GetHashCode();
			HangoutWithCharacter hangoutWithCharacter = with_;
			if (hangoutWithCharacter != null)
			{
				int hashCode4 = hangoutWithCharacter.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60039A2")]
		[Cpp2IlInjected.Address(RVA = "0x34F4A20", Offset = "0x34F3420", VA = "0x1834F4A20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60039A3")]
		[Cpp2IlInjected.Address(RVA = "0x34F4A80", Offset = "0x34F3480", VA = "0x1834F4A80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0091
			if (acceptMiningFailure_)
			{
				bool value = acceptMiningFailure_;
				output.WriteBool(value);
			}
			if ((long)targetItem_ != 0)
			{
				ItemSelector value2 = targetItem_;
				output.WriteMessage(value2);
			}
			if ((long)targetAmount_ != 0)
			{
				StepAmount value3 = targetAmount_;
				output.WriteMessage(value3);
			}
			RepeatedField<ActivityDataLocationFilter> repeatedField = locations_;
			FieldCodec<ActivityDataLocationFilter> repeated_locations_codec = _repeated_locations_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_locations_codec);
			if ((long)with_ != 0)
			{
				HangoutWithCharacter value4 = with_;
				output.WriteMessage(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60039A4")]
		[Cpp2IlInjected.Address(RVA = "0x34F3B90", Offset = "0x34F2590", VA = "0x1834F3B90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0077
			UnknownFieldSet unknownFields;
			do
			{
				ItemSelector itemSelector = targetItem_;
				if (itemSelector != null)
				{
					int num = CodedOutputStream.ComputeMessageSize(itemSelector);
					num++;
				}
				StepAmount stepAmount = targetAmount_;
				if (stepAmount != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(stepAmount);
					num2++;
				}
				RepeatedField<ActivityDataLocationFilter> repeatedField = locations_;
				FieldCodec<ActivityDataLocationFilter> repeated_locations_codec = _repeated_locations_codec;
				int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_locations_codec);
				HangoutWithCharacter hangoutWithCharacter = with_;
				if (hangoutWithCharacter != null)
				{
					int num4 = CodedOutputStream.ComputeMessageSize(hangoutWithCharacter);
					num4++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x60039A5")]
		[Cpp2IlInjected.Address(RVA = "0x34F45E0", Offset = "0x34F2FE0", VA = "0x1834F45E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepMineMineral other)
		{
			//Discarded unreachable code: IL_0100
			if (other == null)
			{
				return;
			}
			bool flag = other.acceptMiningFailure_;
			if (flag)
			{
				acceptMiningFailure_ = flag;
			}
			if ((long)other.targetItem_ != 0)
			{
				ItemSelector itemSelector2 = default(ItemSelector);
				if (targetItem_ == null)
				{
					ItemSelector itemSelector = (targetItem_ = new ItemSelector());
					itemSelector2 = targetItem_;
				}
				ItemSelector other2 = other.targetItem_;
				itemSelector2.MergeFrom(other2);
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					stepAmount2 = targetAmount_;
				}
				StepAmount other3 = other.targetAmount_;
				stepAmount2.MergeFrom(other3);
			}
			RepeatedField<ActivityDataLocationFilter> repeatedField = locations_;
			RepeatedField<ActivityDataLocationFilter> repeatedField2 = other.locations_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.with_ != 0)
			{
				HangoutWithCharacter hangoutWithCharacter2 = default(HangoutWithCharacter);
				if (with_ == null)
				{
					HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
					hangoutWithCharacter2 = with_;
				}
				HangoutWithCharacter other4 = other.with_;
				hangoutWithCharacter2.MergeFrom(other4);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60039A6")]
		[Cpp2IlInjected.Address(RVA = "0x34F43B0", Offset = "0x34F2DB0", VA = "0x1834F43B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00de
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					StepAmount stepAmount = targetAmount_;
					if (stepAmount == null)
					{
						StepAmount stepAmount2 = (targetAmount_ = new StepAmount());
					}
					input.ReadMessage(stepAmount);
				}
				if (num == 34)
				{
					RepeatedField<ActivityDataLocationFilter> repeatedField = locations_;
					FieldCodec<ActivityDataLocationFilter> repeated_locations_codec = _repeated_locations_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_locations_codec);
				}
				if (num != 42)
				{
					goto IL_00c7;
				}
				HangoutWithCharacter builder = default(HangoutWithCharacter);
				if (with_ == null)
				{
					HangoutWithCharacter hangoutWithCharacter = (with_ = new HangoutWithCharacter());
					builder = with_;
				}
				input.ReadMessage(builder);
			}
			bool flag = default(bool);
			if (num == 8)
			{
				flag = (acceptMiningFailure_ = input.ReadBool());
			}
			if (flag)
			{
				ItemSelector builder2 = default(ItemSelector);
				if (targetItem_ == null)
				{
					ItemSelector itemSelector = (targetItem_ = new ItemSelector());
					builder2 = targetItem_;
				}
				input.ReadMessage(builder2);
			}
			goto IL_00c7;
			IL_00c7:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60039A7")]
		[Cpp2IlInjected.Address(RVA = "0x34F41D0", Offset = "0x34F2BD0", VA = "0x1834F41D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_003d;
							}
							HangoutWithCharacter hangoutWithCharacter = with_;
						}
						RepeatedField<ActivityDataLocationFilter> repeatedField = locations_;
					}
					StepAmount stepAmount = targetAmount_;
				}
				ItemSelector itemSelector = targetItem_;
			}
			bool flag = acceptMiningFailure_;
			goto IL_003d;
			IL_003d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60039A8")]
		[Cpp2IlInjected.Address(RVA = "0x34F4870", Offset = "0x34F3270", VA = "0x1834F4870", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0042
			//IL_0029: Expected O, but got I4
			//IL_0041: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							int num2 = 0;
							if (value == null || value != null)
							{
								with_ = (HangoutWithCharacter)num2;
								return;
							}
							break;
						}
						default:
							return;
						case 0:
							break;
						}
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					}
					else if (value == null || value != null)
					{
						goto IL_0032;
					}
					throw new InvalidCastException();
				}
				goto IL_0032;
			}
			goto IL_003a;
			IL_0032:
			if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
			goto IL_003a;
			IL_003a:
			object obj = default(object);
			acceptMiningFailure_ = (byte)(int)obj != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60039A9")]
		[Cpp2IlInjected.Address(RVA = "0x34F3D00", Offset = "0x34F2700", VA = "0x1834F3D00", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0038, IL_005a
			//IL_0021: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							int num2 = 0;
							with_ = (HangoutWithCharacter)num2;
							break;
						}
						case 0:
							break;
						default:
							return;
						}
						RepeatedField<ActivityDataLocationFilter> repeatedField = locations_;
						int num3 = 0;
						uint num4 = default(uint);
						if (num3 < (int)num4)
						{
							num3 += num3;
							num3++;
						}
						return;
					}
					int num5 = 0;
					targetAmount_ = (StepAmount)num5;
				}
				int num6 = 0;
				targetItem_ = (ItemSelector)num6;
			}
			acceptMiningFailure_ = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60039AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D57A30", Offset = "0x2D56430", VA = "0x182D57A30", Slot = "17")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			targetAmount_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60039AE")]
		[Cpp2IlInjected.Address(RVA = "0x34F3EA0", Offset = "0x34F28A0", VA = "0x1834F3EA0", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0050
			if (targetItem_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.None)
			{
				context.AddInvalidMemberError("Cannot be None", "TargetItem");
			}
			int count = ((RepeatedField<T>)(object)locations_).Count;
			int num = Enumerable.Count<ActivityDataLocationFilter>(Enumerable.Distinct<ActivityDataLocationFilter>((IEnumerable<>)(object)locations_));
			if (count != num)
			{
				context.AddInvalidMemberError("Please remove location duplicate", "Locations");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039AF")]
		[Cpp2IlInjected.Address(RVA = "0x34F4BF0", Offset = "0x34F35F0", VA = "0x1834F4BF0")]
		static CustomStepMineMineral()
		{
			Func<CustomStepMineMineral> func = default(Func<CustomStepMineMineral>);
			_parser = (MessageParser<CustomStepMineMineral>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ActivityDataLocationFilter> parser = ActivityDataLocationFilter._parser;
			uint num = default(uint);
			_parser = (MessageParser<CustomStepMineMineral>)(object)FieldCodec.ForMessage<ActivityDataLocationFilter>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
