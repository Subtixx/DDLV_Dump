using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000499")]
	public sealed class CustomStepConditional : IMessage<CustomStepConditional>, IMessage, IEquatable<CustomStepConditional>, IDeepCloneable<CustomStepConditional>, IMessageFieldAccessor, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40018AA")]
		private static readonly MessageParser<CustomStepConditional> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40018AB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40018AC")]
		public const int ConditionsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018AD")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x40018AE")]
		public const int AutoConfirmFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018AF")]
		private bool autoConfirm_;

		[Cpp2IlInjected.Token(Token = "0x17000E68")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepConditional> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600387A")]
			[Cpp2IlInjected.Address(RVA = "0x2D51A40", Offset = "0x2D50440", VA = "0x182D51A40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E69")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600387B")]
			[Cpp2IlInjected.Address(RVA = "0x2D51970", Offset = "0x2D50370", VA = "0x182D51970")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600387C")]
			[Cpp2IlInjected.Address(RVA = "0x2D51AA0", Offset = "0x2D504A0", VA = "0x182D51AA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6B")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6003881")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003882")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E6C")]
		[DebuggerNonUserCode]
		public bool AutoConfirm
		{
			[Cpp2IlInjected.Token(Token = "0x6003883")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return autoConfirm_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003884")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				autoConfirm_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600387D")]
		[Cpp2IlInjected.Address(RVA = "0x2D51900", Offset = "0x2D50300", VA = "0x182D51900")]
		[DebuggerNonUserCode]
		public CustomStepConditional()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600387E")]
		[Cpp2IlInjected.Address(RVA = "0x2D51590", Offset = "0x2D4FF90", VA = "0x182D51590")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600387F")]
		[Cpp2IlInjected.Address(RVA = "0x2D51830", Offset = "0x2D50230", VA = "0x182D51830")]
		[DebuggerNonUserCode]
		public CustomStepConditional(CustomStepConditional other)
		{
			//IL_002e: Expected O, but got I4
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			ConditionsList conditionsList2 = other.conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num = 0;
			conditions_ = (ConditionsList)num;
			bool flag = (autoConfirm_ = other.autoConfirm_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003880")]
		[Cpp2IlInjected.Address(RVA = "0x2D50C70", Offset = "0x2D4F670", VA = "0x182D50C70", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepConditional Clone()
		{
			//Discarded unreachable code: IL_0057
			//IL_0030: Expected O, but got I4
			CustomStepConditional customStepConditional = new CustomStepConditional();
			ConditionsList conditionsList = (customStepConditional.conditions_ = new ConditionsList());
			ConditionsList conditionsList2 = conditions_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num = 0;
			customStepConditional.conditions_ = (ConditionsList)num;
			bool flag = (customStepConditional.autoConfirm_ = autoConfirm_);
			UnknownFieldSet unknownFieldSet = (customStepConditional._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepConditional;
		}

		[Cpp2IlInjected.Token(Token = "0x6003885")]
		[Cpp2IlInjected.Address(RVA = "0x2D51240", Offset = "0x2D4FC40", VA = "0x182D51240", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(conditions_, other);
				if (flag && autoConfirm_ == flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003886")]
		[Cpp2IlInjected.Address(RVA = "0x1807960", Offset = "0x1806360", VA = "0x181807960", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepConditional other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ConditionsList objB = other.conditions_;
				if (object.Equals(conditions_, objB))
				{
					bool flag = other.autoConfirm_;
					if (autoConfirm_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003887")]
		[Cpp2IlInjected.Address(RVA = "0x1807AA0", Offset = "0x18064A0", VA = "0x181807AA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ConditionsList conditionsList = conditions_;
				if (conditionsList != null)
				{
					int hashCode = conditionsList.GetHashCode();
				}
				if (autoConfirm_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003888")]
		[Cpp2IlInjected.Address(RVA = "0x2D516C0", Offset = "0x2D500C0", VA = "0x182D516C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003889")]
		[Cpp2IlInjected.Address(RVA = "0x1807E30", Offset = "0x1806830", VA = "0x181807E30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)conditions_ != 0)
			{
				ConditionsList value = conditions_;
				output.WriteMessage(value);
			}
			if (autoConfirm_)
			{
				bool value2 = autoConfirm_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600388A")]
		[Cpp2IlInjected.Address(RVA = "0x2D50BD0", Offset = "0x2D4F5D0", VA = "0x182D50BD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ConditionsList conditionsList = conditions_;
				num = 0;
				if (conditionsList != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(conditionsList);
					num2++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600388B")]
		[Cpp2IlInjected.Address(RVA = "0x2D513C0", Offset = "0x2D4FDC0", VA = "0x182D513C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepConditional other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.conditions_ != 0)
			{
				ConditionsList conditionsList = conditions_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (conditions_ = new ConditionsList());
				}
				ConditionsList other2 = other.conditions_;
				conditionsList.MergeFrom(other2);
			}
			bool flag = other.autoConfirm_;
			if (flag)
			{
				autoConfirm_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600388C")]
		[Cpp2IlInjected.Address(RVA = "0x2D514A0", Offset = "0x2D4FEA0", VA = "0x182D514A0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ConditionsList conditionsList = conditions_;
				if (conditionsList == null)
				{
					ConditionsList conditionsList2 = (conditions_ = new ConditionsList());
				}
				input.ReadMessage(conditionsList);
			}
			if (num == 16)
			{
				bool flag = (autoConfirm_ = input.ReadBool());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600388D")]
		[Cpp2IlInjected.Address(RVA = "0x2D512F0", Offset = "0x2D4FCF0", VA = "0x182D512F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ConditionsList conditionsList = conditions_;
			}
			if (fieldNumber == 2)
			{
				bool flag = autoConfirm_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600388E")]
		[Cpp2IlInjected.Address(RVA = "0x2D515F0", Offset = "0x2D4FFF0", VA = "0x182D515F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				conditions_ = (ConditionsList)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				autoConfirm_ = (byte)(int)obj != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600388F")]
		[Cpp2IlInjected.Address(RVA = "0x18077D0", Offset = "0x18061D0", VA = "0x1818077D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				autoConfirm_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003890")]
		[Cpp2IlInjected.Address(RVA = "0x1457620", Offset = "0x1456020", VA = "0x181457620", Slot = "14")]
		public void SetDefaultData()
		{
			autoConfirm_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003891")]
		[Cpp2IlInjected.Address(RVA = "0x2D50D70", Offset = "0x2D4F770", VA = "0x182D50D70", Slot = "15")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_016b
			//IL_0025: Expected O, but got I4
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
			IEnumerable<ConditionMissionCompleted> allConditions = (IEnumerable<ConditionMissionCompleted>)conditions_.GetAllConditions<ConditionMissionCompleted>();
			Func<ConditionMissionCompleted, bool> cpp2il__autoParamName__idx_ = (Func<ConditionMissionCompleted, bool>)(object)(Func<T, TResult>)delegate(ConditionMissionCompleted x)
			{
				Item missionItem4 = x.MissionItem;
				if (missionItem != null)
				{
				}
				int num5 = 0;
				throw new NullReferenceException();
			};
			if (((IEnumerable<>)allConditions).Any<ConditionMissionCompleted>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				string message = context.MissionStepName + " cannot use MissionCompleted on him-self";
				context.AddInvalidMemberError(message, "Conditions");
			}
			IEnumerable<ConditionMissionStepCompleted> allConditions2 = (IEnumerable<ConditionMissionStepCompleted>)conditions_.GetAllConditions<ConditionMissionStepCompleted>();
			Func<ConditionMissionStepCompleted, bool> cpp2il__autoParamName__idx_2 = (Func<ConditionMissionStepCompleted, bool>)(object)(Func<T, TResult>)delegate(ConditionMissionStepCompleted x)
			{
				Item missionItem3 = x.MissionItem;
				if (missionItem != null)
				{
				}
				int num4 = 0;
				throw new NullReferenceException();
			};
			if (((IEnumerable<>)allConditions2).Any<ConditionMissionStepCompleted>((Func<, >)(object)cpp2il__autoParamName__idx_2))
			{
				string message2 = context.MissionStepName + " cannot use MissionStepCompleted on him-self";
				context.AddInvalidMemberError(message2, "Conditions");
			}
			IEnumerable<ConditionMissionOngoing> allConditions3 = (IEnumerable<ConditionMissionOngoing>)conditions_.GetAllConditions<ConditionMissionOngoing>();
			Func<ConditionMissionOngoing, bool> cpp2il__autoParamName__idx_3 = (Func<ConditionMissionOngoing, bool>)(object)(Func<T, TResult>)delegate(ConditionMissionOngoing x)
			{
				Item missionItem2 = x.MissionItem;
				if (missionItem != null)
				{
				}
				int num3 = 0;
				throw new NullReferenceException();
			};
			if (((IEnumerable<>)allConditions3).Any<ConditionMissionOngoing>((Func<, >)(object)cpp2il__autoParamName__idx_3))
			{
				string message3 = context.MissionStepName + " cannot use MissionOngoing on him-self";
				context.AddInvalidMemberError(message3, "Conditions");
			}
			if (Enumerable.Any<ConditionCountry>(conditions_.GetAllConditions<ConditionCountry>()) || Enumerable.Any<ConditionDate>(conditions_.GetAllConditions<ConditionDate>()) || Enumerable.Any<ConditionDayOfWeek>(conditions_.GetAllConditions<ConditionDayOfWeek>()) || Enumerable.Any<ConditionPlatform>(conditions_.GetAllConditions<ConditionPlatform>()))
			{
				string message4 = context.MissionStepName + " cannot use Country/Date/Platform conditions";
				context.AddInvalidMemberError(message4, "Conditions");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003892")]
		[Cpp2IlInjected.Address(RVA = "0x2D51720", Offset = "0x2D50120", VA = "0x182D51720")]
		static CustomStepConditional()
		{
			Func<CustomStepConditional> func = default(Func<CustomStepConditional>);
			_parser = (MessageParser<CustomStepConditional>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
