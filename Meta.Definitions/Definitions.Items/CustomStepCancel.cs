using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004E8")]
	public sealed class CustomStepCancel : IMessage<CustomStepCancel>, IMessage, IEquatable<CustomStepCancel>, IDeepCloneable<CustomStepCancel>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001A54")]
		private static readonly MessageParser<CustomStepCancel> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001A55")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001A56")]
		public const int CancelMissionWhenFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A57")]
		private ConditionsList cancelMissionWhen_;

		[Cpp2IlInjected.Token(Token = "0x17000F8C")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepCancel> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003C90")]
			[Cpp2IlInjected.Address(RVA = "0x2D4C940", Offset = "0x2D4B340", VA = "0x182D4C940")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F8D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003C91")]
			[Cpp2IlInjected.Address(RVA = "0x2D4C870", Offset = "0x2D4B270", VA = "0x182D4C870")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F8E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003C92")]
			[Cpp2IlInjected.Address(RVA = "0x2D4C9A0", Offset = "0x2D4B3A0", VA = "0x182D4C9A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F8F")]
		[DebuggerNonUserCode]
		public ConditionsList CancelMissionWhen
		{
			[Cpp2IlInjected.Token(Token = "0x6003C97")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return cancelMissionWhen_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C98")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				cancelMissionWhen_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C93")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C730", Offset = "0x2D4B130", VA = "0x182D4C730")]
		[DebuggerNonUserCode]
		public CustomStepCancel()
		{
			ConditionsList conditionsList = (cancelMissionWhen_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C94")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C4E0", Offset = "0x2D4AEE0", VA = "0x182D4C4E0")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (cancelMissionWhen_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C95")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C7A0", Offset = "0x2D4B1A0", VA = "0x182D4C7A0")]
		[DebuggerNonUserCode]
		public CustomStepCancel(CustomStepCancel other)
		{
			//IL_002e: Expected O, but got I4
			ConditionsList conditionsList = (cancelMissionWhen_ = new ConditionsList());
			ConditionsList conditionsList2 = other.cancelMissionWhen_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num = 0;
			cancelMissionWhen_ = (ConditionsList)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C96")]
		[Cpp2IlInjected.Address(RVA = "0x2D4BBD0", Offset = "0x2D4A5D0", VA = "0x182D4BBD0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepCancel Clone()
		{
			//Discarded unreachable code: IL_0047
			//IL_0030: Expected O, but got I4
			CustomStepCancel customStepCancel = new CustomStepCancel();
			ConditionsList conditionsList = (customStepCancel.cancelMissionWhen_ = new ConditionsList());
			ConditionsList conditionsList2 = cancelMissionWhen_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num = 0;
			customStepCancel.cancelMissionWhen_ = (ConditionsList)num;
			UnknownFieldSet unknownFieldSet = (customStepCancel._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepCancel;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C99")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C200", Offset = "0x2D4AC00", VA = "0x182D4C200", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(cancelMissionWhen_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C9A")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepCancel other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ConditionsList objB = other.cancelMissionWhen_;
				if (object.Equals(cancelMissionWhen_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C9B")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ConditionsList conditionsList = cancelMissionWhen_;
				if (conditionsList != null)
				{
					int hashCode = conditionsList.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C9C")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C5C0", Offset = "0x2D4AFC0", VA = "0x182D4C5C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C9D")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)cancelMissionWhen_ != 0)
			{
				ConditionsList value = cancelMissionWhen_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003C9E")]
		[Cpp2IlInjected.Address(RVA = "0x2D4BB30", Offset = "0x2D4A530", VA = "0x182D4BB30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ConditionsList conditionsList = cancelMissionWhen_;
				num = 0;
				if (conditionsList != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(conditionsList);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C9F")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C410", Offset = "0x2D4AE10", VA = "0x182D4C410", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepCancel other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.cancelMissionWhen_ != 0)
			{
				ConditionsList conditionsList = cancelMissionWhen_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (cancelMissionWhen_ = new ConditionsList());
				}
				ConditionsList other2 = other.cancelMissionWhen_;
				conditionsList.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA0")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C330", Offset = "0x2D4AD30", VA = "0x182D4C330", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ConditionsList conditionsList = cancelMissionWhen_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (cancelMissionWhen_ = new ConditionsList());
				}
				input.ReadMessage(conditionsList);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA1")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C2B0", Offset = "0x2D4ACB0", VA = "0x182D4C2B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ConditionsList conditionsList = cancelMissionWhen_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C540", Offset = "0x2D4AF40", VA = "0x182D4C540", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				cancelMissionWhen_ = (ConditionsList)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA3")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2D4BCD0", Offset = "0x2D4A6D0", VA = "0x182D4BCD0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_019a
			//IL_0054: Expected O, but got I4
			if (cancelMissionWhen_.IsEmpty)
			{
				string missionStepName = context.MissionStepName;
				string message = "Is required in " + missionStepName;
				context.AddInvalidMemberError(message, "CancelMissionWhen");
			}
			MissionItemData parentOfType = context.GetParentOfType<MissionItemData>();
			if (parentOfType != null)
			{
				int iD = parentOfType.ID;
				int num = 0;
			}
			int num2 = 0;
			Item? missionItem = (Item?)(object)num2;
			if (num2 == 0)
			{
				return;
			}
			IEnumerable<> allConditions = cancelMissionWhen_.GetAllConditions<ConditionMissionCompleted>();
			Func<ConditionMissionCompleted, bool> cpp2il__autoParamName__idx_ = (Func<ConditionMissionCompleted, bool>)(object)(Func<T, TResult>)delegate(ConditionMissionCompleted x)
			{
				Item missionItem4 = x.MissionItem;
				if (missionItem != null)
				{
				}
				int num5 = 0;
				throw new NullReferenceException();
			};
			if (allConditions.Any<ConditionMissionCompleted>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				string message2 = context.MissionStepName + " cannot use MissionCompleted on him-self";
				context.AddInvalidMemberError(message2, "CancelMissionWhen");
			}
			IEnumerable<> allConditions2 = cancelMissionWhen_.GetAllConditions<ConditionMissionStepCompleted>();
			Func<ConditionMissionStepCompleted, bool> cpp2il__autoParamName__idx_2 = (Func<ConditionMissionStepCompleted, bool>)(object)(Func<T, TResult>)delegate(ConditionMissionStepCompleted x)
			{
				Item missionItem3 = x.MissionItem;
				if (missionItem != null)
				{
				}
				int num4 = 0;
				throw new NullReferenceException();
			};
			if (allConditions2.Any<ConditionMissionStepCompleted>((Func<, >)(object)cpp2il__autoParamName__idx_2))
			{
				string message3 = context.MissionStepName + " cannot use MissionStepCompleted on him-self";
				context.AddInvalidMemberError(message3, "CancelMissionWhen");
			}
			IEnumerable<> allConditions3 = cancelMissionWhen_.GetAllConditions<ConditionMissionOngoing>();
			Func<ConditionMissionOngoing, bool> cpp2il__autoParamName__idx_3 = (Func<ConditionMissionOngoing, bool>)(object)(Func<T, TResult>)delegate(ConditionMissionOngoing x)
			{
				Item missionItem2 = x.MissionItem;
				if (missionItem != null)
				{
				}
				int num3 = 0;
				throw new NullReferenceException();
			};
			if (allConditions3.Any<ConditionMissionOngoing>((Func<, >)(object)cpp2il__autoParamName__idx_3))
			{
				string message4 = context.MissionStepName + " cannot use MissionOngoing on him-self";
				context.AddInvalidMemberError(message4, "CancelMissionWhen");
			}
			if (Enumerable.Any<ConditionCountry>(cancelMissionWhen_.GetAllConditions<ConditionCountry>()) || Enumerable.Any<ConditionDate>(cancelMissionWhen_.GetAllConditions<ConditionDate>()) || Enumerable.Any<ConditionDayOfWeek>(cancelMissionWhen_.GetAllConditions<ConditionDayOfWeek>()) || Enumerable.Any<ConditionPlatform>(cancelMissionWhen_.GetAllConditions<ConditionPlatform>()))
			{
				string message5 = context.MissionStepName + " cannot use Country/Date/Platform conditions";
				context.AddInvalidMemberError(message5, "CancelMissionWhen");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C620", Offset = "0x2D4B020", VA = "0x182D4C620")]
		static CustomStepCancel()
		{
			Func<CustomStepCancel> func = default(Func<CustomStepCancel>);
			_parser = (MessageParser<CustomStepCancel>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
