using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000250")]
	public sealed class MissionSettingsData : IMessage<MissionSettingsData>, IMessage, IEquatable<MissionSettingsData>, IDeepCloneable<MissionSettingsData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000933")]
		private static readonly MessageParser<MissionSettingsData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000934")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000935")]
		public const int TakePictureMaxDistanceFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000936")]
		private float takePictureMaxDistance_;

		[Cpp2IlInjected.Token(Token = "0x4000937")]
		public const int TakePictureMaxDistanceNpcFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000938")]
		private float takePictureMaxDistanceNpc_;

		[Cpp2IlInjected.Token(Token = "0x4000939")]
		public const int TakePictureMaxDistanceInterestFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400093A")]
		private float takePictureMaxDistanceInterest_;

		[Cpp2IlInjected.Token(Token = "0x400093B")]
		public const int TakePictureMaxDistanceCrittersFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400093C")]
		private float takePictureMaxDistanceCritters_;

		[Cpp2IlInjected.Token(Token = "0x400093D")]
		public const int NotEnoughManaFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400093E")]
		private ConditionsList notEnoughMana_;

		[Cpp2IlInjected.Token(Token = "0x170004DE")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionSettingsData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60015F4")]
			[Cpp2IlInjected.Address(RVA = "0x29E5D10", Offset = "0x29E4710", VA = "0x1829E5D10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60015F5")]
			[Cpp2IlInjected.Address(RVA = "0x29E5C40", Offset = "0x29E4640", VA = "0x1829E5C40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60015F6")]
			[Cpp2IlInjected.Address(RVA = "0x29E5D70", Offset = "0x29E4770", VA = "0x1829E5D70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E1")]
		[DebuggerNonUserCode]
		public float TakePictureMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x60015FA")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get
			{
				return takePictureMaxDistance_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015FB")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			set
			{
				takePictureMaxDistance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E2")]
		[DebuggerNonUserCode]
		public float TakePictureMaxDistanceNpc
		{
			[Cpp2IlInjected.Token(Token = "0x60015FC")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320")]
			get
			{
				return takePictureMaxDistanceNpc_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015FD")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			set
			{
				takePictureMaxDistanceNpc_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E3")]
		[DebuggerNonUserCode]
		public float TakePictureMaxDistanceInterest
		{
			[Cpp2IlInjected.Token(Token = "0x60015FE")]
			[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
			get
			{
				return takePictureMaxDistanceInterest_;
			}
			[Cpp2IlInjected.Token(Token = "0x60015FF")]
			[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
			set
			{
				takePictureMaxDistanceInterest_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E4")]
		[DebuggerNonUserCode]
		public float TakePictureMaxDistanceCritters
		{
			[Cpp2IlInjected.Token(Token = "0x6001600")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF70", Offset = "0xA7C970", VA = "0x180A7DF70")]
			get
			{
				return takePictureMaxDistanceCritters_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001601")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF90", Offset = "0xA7C990", VA = "0x180A7DF90")]
			set
			{
				takePictureMaxDistanceCritters_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E5")]
		[DebuggerNonUserCode]
		public ConditionsList NotEnoughMana
		{
			[Cpp2IlInjected.Token(Token = "0x6001602")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return notEnoughMana_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001603")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				notEnoughMana_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E6")]
		public unsafe static MissionSettingsData Data
		{
			[Cpp2IlInjected.Token(Token = "0x600160F")]
			[Cpp2IlInjected.Address(RVA = "0x29E5B50", Offset = "0x29E4550", VA = "0x1829E5B50")]
			get
			{
				int num = 0;
				bool flag = ProtoDatabase.Instance.TryGet("MissionSettings", out *(MissionSettingsData*)num);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015F7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MissionSettingsData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60015F8")]
		[Cpp2IlInjected.Address(RVA = "0x29E5AC0", Offset = "0x29E44C0", VA = "0x1829E5AC0")]
		[DebuggerNonUserCode]
		public MissionSettingsData(MissionSettingsData other)
		{
			//IL_005f: Expected O, but got I4
			float num = (takePictureMaxDistance_ = other.takePictureMaxDistance_);
			float num2 = (takePictureMaxDistanceNpc_ = other.takePictureMaxDistanceNpc_);
			float num3 = (takePictureMaxDistanceInterest_ = other.takePictureMaxDistanceInterest_);
			float num4 = (takePictureMaxDistanceCritters_ = other.takePictureMaxDistanceCritters_);
			ConditionsList conditionsList = other.notEnoughMana_;
			if (conditionsList != null)
			{
				ConditionsList conditionsList2 = conditionsList.Clone();
			}
			int num5 = 0;
			notEnoughMana_ = (ConditionsList)num5;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015F9")]
		[Cpp2IlInjected.Address(RVA = "0x29E4B40", Offset = "0x29E3540", VA = "0x1829E4B40", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionSettingsData Clone()
		{
			//Discarded unreachable code: IL_0078
			//IL_0061: Expected O, but got I4
			MissionSettingsData missionSettingsData = new MissionSettingsData();
			float num = (missionSettingsData.takePictureMaxDistance_ = takePictureMaxDistance_);
			float num2 = (missionSettingsData.takePictureMaxDistanceNpc_ = takePictureMaxDistanceNpc_);
			float num3 = (missionSettingsData.takePictureMaxDistanceInterest_ = takePictureMaxDistanceInterest_);
			float num4 = (missionSettingsData.takePictureMaxDistanceCritters_ = takePictureMaxDistanceCritters_);
			ConditionsList conditionsList = notEnoughMana_;
			if (conditionsList != null)
			{
				ConditionsList conditionsList2 = conditionsList.Clone();
			}
			int num5 = 0;
			missionSettingsData.notEnoughMana_ = (ConditionsList)num5;
			UnknownFieldSet unknownFieldSet = (missionSettingsData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionSettingsData;
		}

		[Cpp2IlInjected.Token(Token = "0x6001604")]
		[Cpp2IlInjected.Address(RVA = "0x29E4DC0", Offset = "0x29E37C0", VA = "0x1829E4DC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((MissionSettingsData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001605")]
		[Cpp2IlInjected.Address(RVA = "0x29E4BF0", Offset = "0x29E35F0", VA = "0x1829E4BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionSettingsData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null && (object)typeof(ProtobufEqualityComparers).TypeHandle != null)
				{
					ConditionsList objB = other.notEnoughMana_;
					if (object.Equals(notEnoughMana_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001606")]
		[Cpp2IlInjected.Address(RVA = "0x29E5020", Offset = "0x29E3A20", VA = "0x1829E5020", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0050
			while (ProtobufEqualityComparers.BitwiseSingleEqualityComparer == null || ProtobufEqualityComparers.BitwiseSingleEqualityComparer == null)
			{
			}
			if (ProtobufEqualityComparers.BitwiseSingleEqualityComparer != null)
			{
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			}
			ConditionsList conditionsList = notEnoughMana_;
			if (conditionsList != null)
			{
				int hashCode = conditionsList.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			int result = default(int);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001607")]
		[Cpp2IlInjected.Address(RVA = "0x29E5820", Offset = "0x29E4220", VA = "0x1829E5820", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001608")]
		[Cpp2IlInjected.Address(RVA = "0x29E5880", Offset = "0x29E4280", VA = "0x1829E5880", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0075
			float value = takePictureMaxDistance_;
			output.WriteFloat(value);
			if (output != null)
			{
				float value2 = takePictureMaxDistanceNpc_;
				output.WriteFloat(value2);
			}
			if (output != null)
			{
				float value3 = takePictureMaxDistanceInterest_;
				output.WriteFloat(value3);
			}
			if (output != null)
			{
				float value4 = takePictureMaxDistanceCritters_;
				output.WriteFloat(value4);
			}
			if ((long)notEnoughMana_ != 0)
			{
				ConditionsList value5 = notEnoughMana_;
				output.WriteMessage(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001609")]
		[Cpp2IlInjected.Address(RVA = "0x29E4A00", Offset = "0x29E3400", VA = "0x1829E4A00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			uint num = default(uint);
			UnknownFieldSet unknownFields;
			do
			{
				num += 5;
				num += 5;
				num += 5;
				ConditionsList conditionsList = notEnoughMana_;
				if (conditionsList != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(conditionsList);
					num2++;
					num += (uint)num2;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + (int)num;
		}

		[Cpp2IlInjected.Token(Token = "0x600160A")]
		[Cpp2IlInjected.Address(RVA = "0x29E5550", Offset = "0x29E3F50", VA = "0x1829E5550", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionSettingsData other)
		{
			//Discarded unreachable code: IL_00ab
			if (other == null)
			{
				return;
			}
			float num = other.takePictureMaxDistance_;
			if (other != null)
			{
				takePictureMaxDistance_ = num;
			}
			float num2 = other.takePictureMaxDistanceNpc_;
			if (other != null)
			{
				takePictureMaxDistanceNpc_ = num2;
			}
			float num3 = other.takePictureMaxDistanceInterest_;
			if (other != null)
			{
				takePictureMaxDistanceInterest_ = num3;
			}
			float num4 = other.takePictureMaxDistanceCritters_;
			if (other != null)
			{
				takePictureMaxDistanceCritters_ = num4;
			}
			if ((long)other.notEnoughMana_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (notEnoughMana_ == null)
				{
					ConditionsList conditionsList = (notEnoughMana_ = new ConditionsList());
					conditionsList2 = notEnoughMana_;
				}
				ConditionsList other2 = other.notEnoughMana_;
				conditionsList2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600160B")]
		[Cpp2IlInjected.Address(RVA = "0x29E5410", Offset = "0x29E3E10", VA = "0x1829E5410", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00ac
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 21)
			{
				if (num == 29)
				{
					float num2 = (takePictureMaxDistanceInterest_ = input.ReadFloat());
				}
				if (num == 37)
				{
					float num3 = (takePictureMaxDistanceCritters_ = input.ReadFloat());
				}
				if (num != 82)
				{
					goto IL_0095;
				}
				ConditionsList builder = default(ConditionsList);
				if (notEnoughMana_ == null)
				{
					ConditionsList conditionsList = (notEnoughMana_ = new ConditionsList());
					builder = notEnoughMana_;
				}
				input.ReadMessage(builder);
			}
			if (num == 13)
			{
				float num4 = (takePictureMaxDistance_ = input.ReadFloat());
			}
			if (num == 21)
			{
				float num5 = (takePictureMaxDistanceNpc_ = input.ReadFloat());
			}
			goto IL_0095;
			IL_0095:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600160C")]
		[Cpp2IlInjected.Address(RVA = "0x29E4F20", Offset = "0x29E3920", VA = "0x1829E4F20", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num != 1)
			{
				if (fieldNumber != 10)
				{
					ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
					/*Error: Unexpected end of block*/;
				}
				ConditionsList conditionsList = notEnoughMana_;
			}
			float num2 = takePictureMaxDistance_;
			return typeof(float).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x600160D")]
		[Cpp2IlInjected.Address(RVA = "0x29E5660", Offset = "0x29E4060", VA = "0x1829E5660", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_004d
			//IL_002a: Expected O, but got I4
			//IL_0032: Expected F4, but got O
			//IL_003a: Expected F4, but got O
			//IL_0043: Expected F4, but got O
			//IL_004c: Expected F4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						object obj2 = default(object);
						takePictureMaxDistanceCritters_ = (float)obj2;
						return;
					}
					case 0:
					{
						object obj = default(object);
						takePictureMaxDistanceInterest_ = (float)obj;
						return;
					}
					}
					if (fieldNumber == 10)
					{
						int num2 = 0;
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						notEnoughMana_ = (ConditionsList)num2;
					}
				}
				else
				{
					object obj3 = default(object);
					takePictureMaxDistanceNpc_ = (float)obj3;
				}
			}
			else
			{
				object obj4 = default(object);
				takePictureMaxDistance_ = (float)obj4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600160E")]
		[Cpp2IlInjected.Address(RVA = "0x29E4AE0", Offset = "0x29E34E0", VA = "0x1829E4AE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num == 1 || fieldNumber == 10)
						{
							takePictureMaxDistanceCritters_ = 0f;
						}
					}
					else
					{
						takePictureMaxDistanceInterest_ = 0f;
					}
				}
				else
				{
					takePictureMaxDistanceNpc_ = 0f;
				}
			}
			else
			{
				takePictureMaxDistance_ = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001610")]
		[Cpp2IlInjected.Address(RVA = "0x29E5340", Offset = "0x29E3D40", VA = "0x1829E5340")]
		public static bool GetTakePictureSettings(out float maxSqrDistance, out float maxSqrDistanceNpc, out float maxSqrDistanceInterest, out float maxSqrDistanceCritter)
		{
			int num = 0;
			MissionSettingsData data = Data;
			if (data == null)
			{
			}
			float num2 = (maxSqrDistance.m_value = data.takePictureMaxDistance_);
			float num3 = (maxSqrDistanceNpc.m_value = data.takePictureMaxDistanceNpc_);
			float num4 = (maxSqrDistanceInterest.m_value = data.takePictureMaxDistanceInterest_);
			float num5 = (maxSqrDistanceCritter.m_value = data.takePictureMaxDistanceCritters_);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001611")]
		[Cpp2IlInjected.Address(RVA = "0x29E4E20", Offset = "0x29E3820", VA = "0x1829E4E20")]
		public static bool EvaluateNotEnoughManaCondition(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			int num = 0;
			MissionSettingsData data = Data;
			if (data != null)
			{
				ConditionsList conditionsList = data.notEnoughMana_;
				int num2 = 0;
				if (conditionsList != null)
				{
					bool flag = conditionsList.Evaluate(in playerProfile, in worldProfile, context);
				}
				return num2 == 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001612")]
		[Cpp2IlInjected.Address(RVA = "0x29E59B0", Offset = "0x29E43B0", VA = "0x1829E59B0")]
		static MissionSettingsData()
		{
			Func<MissionSettingsData> func = default(Func<MissionSettingsData>);
			_parser = (MessageParser<MissionSettingsData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
