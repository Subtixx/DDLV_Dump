using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000597")]
	public sealed class RoyalDutyItemData : IMessage<RoyalDutyItemData>, IMessage, IEquatable<RoyalDutyItemData>, IDeepCloneable<RoyalDutyItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IStringTag
	{
		[Cpp2IlInjected.Token(Token = "0x4001E30")]
		private static readonly MessageParser<RoyalDutyItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001E31")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001E32")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E33")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001E34")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E35")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E36")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E37")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E38")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E39")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E3A")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E3B")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E3C")]
		public const int DescriptionFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E3D")]
		private string description_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001E3E")]
		public const int TypeFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001E3F")]
		private DutyType type_;

		[Cpp2IlInjected.Token(Token = "0x4001E40")]
		public const int QueueIndexFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4001E41")]
		private int queueIndex_;

		[Cpp2IlInjected.Token(Token = "0x4001E42")]
		public const int AvailableWhenFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001E43")]
		private ConditionsList availableWhen_;

		[Cpp2IlInjected.Token(Token = "0x4001E44")]
		public const int StepDifficultyLayersFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x4001E45")]
		private static readonly FieldCodec<DutyStepDifficulty> _repeated_stepDifficultyLayers_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001E46")]
		private readonly RepeatedField<DutyStepDifficulty> stepDifficultyLayers_ = (RepeatedField<DutyStepDifficulty>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001E47")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001E48")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x170011DE")]
		[DebuggerNonUserCode]
		public static MessageParser<RoyalDutyItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600456C")]
			[Cpp2IlInjected.Address(RVA = "0x2DB2110", Offset = "0x2DB0B10", VA = "0x182DB2110")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011DF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600456D")]
			[Cpp2IlInjected.Address(RVA = "0x2DB2040", Offset = "0x2DB0A40", VA = "0x182DB2040")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600456E")]
			[Cpp2IlInjected.Address(RVA = "0x2DB2170", Offset = "0x2DB0B70", VA = "0x182DB2170", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E1")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6004573")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004574")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E2")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004575")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004576")]
			[Cpp2IlInjected.Address(RVA = "0x2DB23D0", Offset = "0x2DB0DD0", VA = "0x182DB23D0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E3")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6004577")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004578")]
			[Cpp2IlInjected.Address(RVA = "0x2DB22F0", Offset = "0x2DB0CF0", VA = "0x182DB22F0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E4")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004579")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600457A")]
			[Cpp2IlInjected.Address(RVA = "0x2DB2360", Offset = "0x2DB0D60", VA = "0x182DB2360")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E5")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600457B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600457C")]
			[Cpp2IlInjected.Address(RVA = "0x2DB2440", Offset = "0x2DB0E40", VA = "0x182DB2440")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E6")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600457D")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x600457E")]
			[Cpp2IlInjected.Address(RVA = "0x2DB2280", Offset = "0x2DB0C80", VA = "0x182DB2280")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E7")]
		[DebuggerNonUserCode]
		public DutyType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600457F")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004580")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E8")]
		[DebuggerNonUserCode]
		public int QueueIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6004581")]
			[Cpp2IlInjected.Address(RVA = "0x1781A40", Offset = "0x1780440", VA = "0x181781A40")]
			get
			{
				return queueIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004582")]
			[Cpp2IlInjected.Address(RVA = "0x1781A60", Offset = "0x1780460", VA = "0x181781A60")]
			set
			{
				queueIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011E9")]
		[DebuggerNonUserCode]
		public ConditionsList AvailableWhen
		{
			[Cpp2IlInjected.Token(Token = "0x6004583")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return availableWhen_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004584")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			set
			{
				availableWhen_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011EA")]
		[DebuggerNonUserCode]
		public RepeatedField<DutyStepDifficulty> StepDifficultyLayers
		{
			[Cpp2IlInjected.Token(Token = "0x6004585")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return stepDifficultyLayers_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011EB")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6004586")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004587")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011EC")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004593")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "15")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011ED")]
		string[] IStringTag.StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6004595")]
			[Cpp2IlInjected.Address(RVA = "0x2DB0710", Offset = "0x2DAF110", VA = "0x182DB0710", Slot = "23")]
			get
			{
				//Discarded unreachable code: IL_0079
				string[] array;
				while (true)
				{
					array = new string[4];
					if ("itemname" != null && "itemname" == null)
					{
						continue;
					}
					array[0] = "itemname";
					if ("targetamount" != null && "targetamount" == null)
					{
						continue;
					}
					array[1] = "targetamount";
					if ("minrarity" == null || "minrarity" != null)
					{
						array[2] = "minrarity";
						if ("minimumstarrating" == null || "minimumstarrating" != null)
						{
							break;
						}
					}
				}
				array[3] = "minimumstarrating";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600456F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1CC0", Offset = "0x2DB06C0", VA = "0x182DB1CC0")]
		[DebuggerNonUserCode]
		public RoyalDutyItemData()
		{
			ConditionsList conditionsList = (availableWhen_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004570")]
		[Cpp2IlInjected.Address(RVA = "0x2DB13C0", Offset = "0x2DAFDC0", VA = "0x182DB13C0")]
		private void OnConstruction()
		{
			ConditionsList conditionsList = (availableWhen_ = new ConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004571")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1DF0", Offset = "0x2DB07F0", VA = "0x182DB1DF0")]
		[DebuggerNonUserCode]
		public RoyalDutyItemData(RoyalDutyItemData other)
		{
			//IL_00f4: Expected O, but got I4
			ConditionsList conditionsList = (availableWhen_ = new ConditionsList());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (description_ = other.description_);
			DutyType dutyType = (type_ = other.type_);
			int num2 = (queueIndex_ = other.queueIndex_);
			ConditionsList conditionsList2 = other.availableWhen_;
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = conditionsList2.Clone();
			}
			int num3 = 0;
			availableWhen_ = (ConditionsList)num3;
			RepeatedField<DutyStepDifficulty> repeatedField = (stepDifficultyLayers_ = (RepeatedField<DutyStepDifficulty>)(object)((RepeatedField<T>)(object)other.stepDifficultyLayers_).Clone());
			uint num4 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004572")]
		[Cpp2IlInjected.Address(RVA = "0x2DB06B0", Offset = "0x2DAF0B0", VA = "0x182DB06B0", Slot = "10")]
		[DebuggerNonUserCode]
		public RoyalDutyItemData Clone()
		{
			return new RoyalDutyItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004588")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0A70", Offset = "0x2DAF470", VA = "0x182DB0A70", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(RoyalDutyItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									string text5 = description_;
									bool flag5 = default(bool);
									if (!flag5 && type_ == (flag5 ? DutyType.Foraging : DutyType.None) && queueIndex_ == (flag5 ? 1 : 0) && object.Equals(availableWhen_, other))
									{
										RepeatedField<DutyStepDifficulty> repeatedField = stepDifficultyLayers_;
										bool flag6 = default(bool);
										if (flag6 && glotID_ == (flag6 ? 1u : 0u))
										{
											return object.Equals(_unknownFields, other);
										}
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004589")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0920", Offset = "0x2DAF320", VA = "0x182DB0920", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RoyalDutyItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									string text5 = other.description_;
									if (!(description_ != text5))
									{
										DutyType dutyType = other.type_;
										if (type_ == dutyType)
										{
											int num2 = other.queueIndex_;
											if (queueIndex_ == num2)
											{
												ConditionsList objB = other.availableWhen_;
												if (object.Equals(availableWhen_, objB))
												{
													RepeatedField<DutyStepDifficulty> repeatedField = stepDifficultyLayers_;
													RepeatedField<DutyStepDifficulty> repeatedField2 = other.stepDifficultyLayers_;
													if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
													{
														uint num3 = other.glotID_;
														if (glotID_ == num3)
														{
															UnknownFieldSet unknownFields = other._unknownFields;
															return object.Equals(_unknownFields, unknownFields);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600458A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0DE0", Offset = "0x2DAF7E0", VA = "0x182DB0DE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00e2
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			string text5 = description_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			if (type_ != 0)
			{
			}
			if (queueIndex_ != 0)
			{
			}
			ConditionsList conditionsList = availableWhen_;
			if (conditionsList != null)
			{
				int hashCode6 = conditionsList.GetHashCode();
			}
			int hashCode7 = ((RepeatedField<T>)(object)stepDifficultyLayers_).GetHashCode();
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode8 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600458B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB17E0", Offset = "0x2DB01E0", VA = "0x182DB17E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600458C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1840", Offset = "0x2DB0240", VA = "0x182DB1840", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_012d
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (description_.m_stringLength != 0)
			{
				string value6 = description_;
				output.WriteString(value6);
			}
			if (type_ != 0)
			{
			}
			if (queueIndex_ != 0)
			{
				int value7 = queueIndex_;
				output.WriteInt32(value7);
			}
			if ((long)availableWhen_ != 0)
			{
				ConditionsList value8 = availableWhen_;
				output.WriteMessage(value8);
			}
			RepeatedField<DutyStepDifficulty> repeatedField = stepDifficultyLayers_;
			FieldCodec<DutyStepDifficulty> repeated_stepDifficultyLayers_codec = _repeated_stepDifficultyLayers_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_stepDifficultyLayers_codec);
			if (glotID_ != 0)
			{
				uint value9 = glotID_;
				output.WriteUInt32(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600458D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0200", Offset = "0x2DAEC00", VA = "0x182DB0200", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0190
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			string text5 = description_;
			if (text5.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text5);
				num8++;
				num2 += num8;
			}
			DutyType dutyType = type_;
			if (dutyType != 0)
			{
				int num9 = CodedOutputStream.ComputeEnumSize((int)dutyType);
				num9++;
				num2 += num9;
			}
			int num10 = queueIndex_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			ConditionsList conditionsList = availableWhen_;
			if (conditionsList != null)
			{
				int num12 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num12++;
				num2 += num12;
			}
			RepeatedField<DutyStepDifficulty> repeatedField = stepDifficultyLayers_;
			FieldCodec<DutyStepDifficulty> repeated_stepDifficultyLayers_codec = _repeated_stepDifficultyLayers_codec;
			int num13 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_stepDifficultyLayers_codec);
			uint num14 = glotID_;
			num2 += num13;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeUInt32Size(num14);
				num15 += 2;
				num2 += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num2 += num16;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600458E")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1210", Offset = "0x2DAFC10", VA = "0x182DB1210", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RoyalDutyItemData other)
		{
			//Discarded unreachable code: IL_0147
			if (other == null)
			{
				return;
			}
			int num = other.iD_;
			if (num != 0)
			{
				iD_ = num;
			}
			string text = other.name_;
			if (text.m_stringLength != 0)
			{
				Name = text;
			}
			string text2 = other.displayName_;
			if (text2.m_stringLength != 0)
			{
				DisplayName = text2;
			}
			string text3 = other.iconAddress_;
			if (text3.m_stringLength != 0)
			{
				IconAddress = text3;
			}
			string text4 = other.prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				PrefabAddress = text4;
			}
			string text5 = other.description_;
			if (text5.m_stringLength != 0)
			{
				Description = text5;
			}
			DutyType dutyType = other.type_;
			if (dutyType != 0)
			{
				type_ = dutyType;
			}
			int num2 = other.queueIndex_;
			if (num2 != 0)
			{
				queueIndex_ = num2;
			}
			if ((long)other.availableWhen_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (availableWhen_ == null)
				{
					ConditionsList conditionsList = (availableWhen_ = new ConditionsList());
					conditionsList2 = availableWhen_;
				}
				ConditionsList other2 = other.availableWhen_;
				conditionsList2.MergeFrom(other2);
			}
			RepeatedField<DutyStepDifficulty> repeatedField = stepDifficultyLayers_;
			RepeatedField<DutyStepDifficulty> repeatedField2 = other.stepDifficultyLayers_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			uint num3 = other.glotID_;
			if (num3 != 0)
			{
				glotID_ = num3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600458F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0F90", Offset = "0x2DAF990", VA = "0x182DB0F90", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_015a
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			int num4 = default(int);
			if ((int)num > 42)
			{
				int num2 = default(int);
				if ((int)num > 80)
				{
					ConditionsList conditionsList = default(ConditionsList);
					if (num == 90)
					{
						ConditionsList builder = default(ConditionsList);
						if (availableWhen_ == null)
						{
							conditionsList = (availableWhen_ = new ConditionsList());
							builder = availableWhen_;
						}
						input.ReadMessage(builder);
					}
					if ((long)conditionsList == 98)
					{
						RepeatedField<DutyStepDifficulty> repeatedField = stepDifficultyLayers_;
						FieldCodec<DutyStepDifficulty> repeated_stepDifficultyLayers_codec = _repeated_stepDifficultyLayers_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_stepDifficultyLayers_codec);
					}
					if ((long)conditionsList != 7992)
					{
						goto IL_0143;
					}
					num2 = (int)(glotID_ = (uint)input.ReadInt32());
				}
				string text2 = default(string);
				if (num2 == 58)
				{
					text2 = (Description = input.ReadString());
				}
				int num3 = default(int);
				if ((long)text2 == 64)
				{
					num3 = (int)(type_ = (DutyType)input.ReadInt32());
				}
				if (num3 != 80)
				{
					goto IL_0143;
				}
				num4 = (queueIndex_ = input.ReadInt32());
			}
			string text8 = default(string);
			if (num4 > 18)
			{
				string text4 = default(string);
				if (num4 == 26)
				{
					text4 = (DisplayName = input.ReadString());
				}
				string text6 = default(string);
				if ((long)text4 == 34)
				{
					text6 = (IconAddress = input.ReadString());
				}
				if ((long)text6 != 42)
				{
					goto IL_0143;
				}
				text8 = (PrefabAddress = input.ReadString());
			}
			int num5 = default(int);
			if ((long)text8 == 8)
			{
				num5 = (iD_ = input.ReadInt32());
			}
			if (num5 == 18)
			{
				string text10 = (Name = input.ReadString());
			}
			goto IL_0143;
			IL_0143:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004590")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0C00", Offset = "0x2DAF600", VA = "0x182DB0C00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
				uint num2 = glotID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004591")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1420", Offset = "0x2DAFE20", VA = "0x182DB1420", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_002a, IL_0032, IL_003a, IL_0051, IL_0057, IL_005d, IL_0063, IL_0069, IL_006f, IL_0075, IL_007b
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0050: Expected I4, but got O
			if (fieldNumber - 1 <= 11)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004592")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0500", Offset = "0x2DAEF00", VA = "0x182DB0500", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0018, IL_0019, IL_002c
			//IL_0010: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			if (fieldNumber - 1 <= 11)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004594")]
		[Cpp2IlInjected.Address(RVA = "0x2DB06B0", Offset = "0x2DAF0B0", VA = "0x182DB06B0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			RoyalDutyItemData royalDutyItemData = new RoyalDutyItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004596")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1AF0", Offset = "0x2DB04F0", VA = "0x182DB1AF0")]
		static RoyalDutyItemData()
		{
			Func<RoyalDutyItemData> func = default(Func<RoyalDutyItemData>);
			_parser = (MessageParser<RoyalDutyItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<DutyStepDifficulty> parser = DutyStepDifficulty._parser;
			uint num = default(uint);
			_parser = (MessageParser<RoyalDutyItemData>)(object)FieldCodec.ForMessage<DutyStepDifficulty>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
