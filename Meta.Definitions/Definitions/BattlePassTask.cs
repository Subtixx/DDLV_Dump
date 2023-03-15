using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using glPlayFab.Disney;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Newtonsoft.Json.Linq;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class BattlePassTask : IMessage<BattlePassTask>, IMessage, IEquatable<BattlePassTask>, IDeepCloneable<BattlePassTask>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly MessageParser<BattlePassTask> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public const int EditorHeaderNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private string editorHeaderName_;

		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public const int IconAddressFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private string iconAddress_;

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public const int DescriptionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private string description_;

		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public const int ObjectiveFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private ObjectiveData objective_;

		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public const int CurrencyRewardFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int currencyReward_;

		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public const int AvailableOnDayFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private int availableOnDay_;

		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public const int InternalNameFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private string internalName_;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePassTask> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x32E2520", Offset = "0x32E0F20", VA = "0x1832E2520")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x32E2450", Offset = "0x32E0E50", VA = "0x1832E2450")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x32E2580", Offset = "0x32E0F80", VA = "0x1832E2580", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		[DebuggerNonUserCode]
		public string EditorHeaderName
		{
			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return editorHeaderName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x32E2700", Offset = "0x32E1100", VA = "0x1832E2700")]
			set
			{
				string text = (editorHeaderName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x32E2770", Offset = "0x32E1170", VA = "0x1832E2770")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		[DebuggerNonUserCode]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return description_;
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x32E2690", Offset = "0x32E1090", VA = "0x1832E2690")]
			set
			{
				string text = (description_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		[DebuggerNonUserCode]
		public ObjectiveData Objective
		{
			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return objective_;
			}
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				objective_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		[DebuggerNonUserCode]
		public int CurrencyReward
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return currencyReward_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				currencyReward_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		[DebuggerNonUserCode]
		public int AvailableOnDay
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return availableOnDay_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				availableOnDay_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		[DebuggerNonUserCode]
		public string InternalName
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return internalName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x32E27E0", Offset = "0x32E11E0", VA = "0x1832E27E0")]
			set
			{
				string text = (internalName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x32E22C0", Offset = "0x32E0CC0", VA = "0x1832E22C0")]
		[DebuggerNonUserCode]
		public BattlePassTask()
		{
			editorHeaderName_ = "";
			iconAddress_ = "";
			description_ = "";
			internalName_ = "";
			base._002Ector();
			ObjectiveData objectiveData = (objective_ = new ObjectiveData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x32E1C00", Offset = "0x32E0600", VA = "0x1832E1C00")]
		private void OnConstruction()
		{
			ObjectiveData objectiveData = (objective_ = new ObjectiveData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x32E2390", Offset = "0x32E0D90", VA = "0x1832E2390")]
		[DebuggerNonUserCode]
		public BattlePassTask(BattlePassTask other)
		{
			//IL_0048: Expected O, but got I4
			string text = (editorHeaderName_ = other.editorHeaderName_);
			string text2 = (iconAddress_ = other.iconAddress_);
			string text3 = (description_ = other.description_);
			ObjectiveData objectiveData = other.objective_;
			if (objectiveData != null)
			{
				ObjectiveData objectiveData2 = objectiveData.Clone();
			}
			int num = 0;
			objective_ = (ObjectiveData)num;
			int num2 = (currencyReward_ = other.currencyReward_);
			int num3 = (availableOnDay_ = other.availableOnDay_);
			string text4 = (internalName_ = other.internalName_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x32E1190", Offset = "0x32DFB90", VA = "0x1832E1190", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePassTask Clone()
		{
			//Discarded unreachable code: IL_0098
			//IL_0051: Expected O, but got I4
			BattlePassTask battlePassTask = new BattlePassTask();
			string text = (battlePassTask.editorHeaderName_ = editorHeaderName_);
			string text2 = (battlePassTask.iconAddress_ = iconAddress_);
			string text3 = (battlePassTask.description_ = description_);
			ObjectiveData objectiveData = objective_;
			if (objectiveData != null)
			{
				ObjectiveData objectiveData2 = objectiveData.Clone();
			}
			int num = 0;
			battlePassTask.objective_ = (ObjectiveData)num;
			int num2 = (battlePassTask.currencyReward_ = currencyReward_);
			int num3 = (battlePassTask.availableOnDay_ = availableOnDay_);
			string text4 = (battlePassTask.internalName_ = internalName_);
			UnknownFieldSet unknownFieldSet = (battlePassTask._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return battlePassTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x32E13D0", Offset = "0x32DFDD0", VA = "0x1832E13D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = editorHeaderName_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = iconAddress_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = description_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							bool flag4 = object.Equals(objective_, other);
							if (flag4 && currencyReward_ == (flag4 ? 1 : 0) && availableOnDay_ == (flag4 ? 1 : 0))
							{
								string text4 = internalName_;
								bool flag5 = default(bool);
								if (!flag5)
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x32E1300", Offset = "0x32DFD00", VA = "0x1832E1300", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePassTask other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.editorHeaderName_;
				if (!(editorHeaderName_ != text))
				{
					string text2 = other.iconAddress_;
					if (!(iconAddress_ != text2))
					{
						string text3 = other.description_;
						if (!(description_ != text3))
						{
							ObjectiveData objB = other.objective_;
							if (object.Equals(objective_, objB))
							{
								int num = other.currencyReward_;
								if (currencyReward_ == num)
								{
									int num2 = other.availableOnDay_;
									if (availableOnDay_ == num2)
									{
										string text4 = other.internalName_;
										if (!(internalName_ != text4))
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
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x32E17E0", Offset = "0x32E01E0", VA = "0x1832E17E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00a5
			string text = editorHeaderName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = iconAddress_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			ObjectiveData objectiveData = objective_;
			if (objectiveData != null)
			{
				int hashCode4 = objectiveData.GetHashCode();
			}
			if (currencyReward_ != 0)
			{
			}
			if (availableOnDay_ != 0)
			{
			}
			string text4 = internalName_;
			if (text4.m_stringLength != 0)
			{
				int hashCode5 = text4.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x32E1FC0", Offset = "0x32E09C0", VA = "0x1832E1FC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x32E2020", Offset = "0x32E0A20", VA = "0x1832E2020", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d3
			if (editorHeaderName_.m_stringLength != 0)
			{
				string value = editorHeaderName_;
				output.WriteString(value);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value2 = iconAddress_;
				output.WriteString(value2);
			}
			if (description_.m_stringLength != 0)
			{
				string value3 = description_;
				output.WriteString(value3);
			}
			if ((long)objective_ != 0)
			{
				ObjectiveData value4 = objective_;
				output.WriteMessage(value4);
			}
			if (currencyReward_ != 0)
			{
				int value5 = currencyReward_;
				output.WriteInt32(value5);
			}
			if (availableOnDay_ != 0)
			{
				int value6 = availableOnDay_;
				output.WriteInt32(value6);
			}
			if (internalName_.m_stringLength != 0)
			{
				string value7 = internalName_;
				output.WriteString(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x32E0E80", Offset = "0x32DF880", VA = "0x1832E0E80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0108
			string text = editorHeaderName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = iconAddress_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = description_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			ObjectiveData objectiveData = objective_;
			if (objectiveData != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(objectiveData);
				num5++;
				num += num5;
			}
			int num6 = currencyReward_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num += num7;
			}
			int num8 = availableOnDay_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num += num9;
			}
			string text4 = internalName_;
			if (text4.m_stringLength != 0)
			{
				int num10 = CodedOutputStream.ComputeStringSize(text4);
				num10++;
				num += num10;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num11 = unknownFields.CalculateSize();
				num += num11;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x32E1AB0", Offset = "0x32E04B0", VA = "0x1832E1AB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePassTask other)
		{
			//Discarded unreachable code: IL_00ea
			if (other == null)
			{
				return;
			}
			string text = other.editorHeaderName_;
			if (text.m_stringLength != 0)
			{
				EditorHeaderName = text;
			}
			string text2 = other.iconAddress_;
			if (text2.m_stringLength != 0)
			{
				IconAddress = text2;
			}
			string text3 = other.description_;
			if (text3.m_stringLength != 0)
			{
				Description = text3;
			}
			if ((long)other.objective_ != 0)
			{
				ObjectiveData objectiveData2 = default(ObjectiveData);
				if (objective_ == null)
				{
					ObjectiveData objectiveData = (objective_ = new ObjectiveData());
					objectiveData2 = objective_;
				}
				ObjectiveData other2 = other.objective_;
				objectiveData2.MergeFrom(other2);
			}
			int num = other.currencyReward_;
			if (num != 0)
			{
				currencyReward_ = num;
			}
			int num2 = other.availableOnDay_;
			if (num2 != 0)
			{
				availableOnDay_ = num2;
			}
			string text4 = other.internalName_;
			if (text4.m_stringLength != 0)
			{
				InternalName = text4;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x32E1910", Offset = "0x32E0310", VA = "0x1832E1910", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00e9
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 40)
				{
					if (num == 48)
					{
						int num2 = (availableOnDay_ = input.ReadInt32());
					}
					if (num != 58)
					{
						goto IL_00d2;
					}
					string text2 = (InternalName = input.ReadString());
				}
				ObjectiveData objectiveData = default(ObjectiveData);
				if (num == 34)
				{
					ObjectiveData builder = default(ObjectiveData);
					if (objective_ == null)
					{
						objectiveData = (objective_ = new ObjectiveData());
						builder = objective_;
					}
					input.ReadMessage(builder);
				}
				if ((long)objectiveData != 40)
				{
					goto IL_00d2;
				}
				int num3 = (currencyReward_ = input.ReadInt32());
			}
			string text4 = default(string);
			if (num == 10)
			{
				text4 = (EditorHeaderName = input.ReadString());
			}
			string text6 = default(string);
			if ((long)text4 == 18)
			{
				text6 = (IconAddress = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (Description = input.ReadString());
			}
			goto IL_00d2;
			IL_00d2:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x32E16A0", Offset = "0x32E00A0", VA = "0x1832E16A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				string text = editorHeaderName_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x32E1C60", Offset = "0x32E0660", VA = "0x1832E1C60", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001a, IL_0029, IL_0031, IL_0032, IL_003e, IL_0044, IL_004a
			//IL_0017: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			if (fieldNumber - 1 <= 6)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				EditorHeaderName = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x32E1070", Offset = "0x32DFA70", VA = "0x1832E1070", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013, IL_0014, IL_0015
			if (fieldNumber - 1 <= 6)
			{
				EditorHeaderName = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x32E1ED0", Offset = "0x32E08D0", VA = "0x1832E1ED0")]
		public glPlayFab.Disney.BattlePassTask ToServerTask()
		{
			//Discarded unreachable code: IL_0061
			//IL_0050: Expected I4, but got I8
			glPlayFab.Disney.BattlePassTask battlePassTask = new glPlayFab.Disney.BattlePassTask();
			string text = (battlePassTask.Description = description_);
			string text2 = (battlePassTask.IconAddress = iconAddress_);
			int num = (battlePassTask.CurrencyReward = currencyReward_);
			ObjectiveData message = objective_;
			int formatEnumAsIntegers = 0;
			int indented = 0;
			int formatDefaultValues = 0;
			ulong num2 = default(ulong);
			JObject jObject = (battlePassTask.GameObjectiveData = JObject.Parse(message.ToJSONString((byte)formatDefaultValues != 0, (byte)indented != 0, (byte)formatEnumAsIntegers != 0, (int)num2)));
			return battlePassTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x32E14F0", Offset = "0x32DFEF0", VA = "0x1832E14F0")]
		public static BattlePassTask FromServerReward(glPlayFab.Disney.BattlePassTask serverTask)
		{
			//Discarded unreachable code: IL_006b
			BattlePassTask battlePassTask = new BattlePassTask();
			string text = (battlePassTask.description_ = ProtoPreconditions.CheckNotNull(serverTask.Description, "value"));
			string text2 = (battlePassTask.iconAddress_ = ProtoPreconditions.CheckNotNull(serverTask.IconAddress, "value"));
			int num = (battlePassTask.currencyReward_ = serverTask.CurrencyReward);
			int num2 = (battlePassTask.availableOnDay_ = serverTask.AvailableOnDay);
			string text3 = serverTask.GameObjectiveData.ToString();
			ObjectiveData objectiveData = default(ObjectiveData);
			battlePassTask.objective_ = objectiveData;
			return battlePassTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x32E1280", Offset = "0x32DFC80", VA = "0x1832E1280", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0017
			objective_.DataValidation("Battle Pass", "Task", context);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x32E21B0", Offset = "0x32E0BB0", VA = "0x1832E21B0")]
		static BattlePassTask()
		{
			Func<BattlePassTask> func = default(Func<BattlePassTask>);
			_parser = (MessageParser<BattlePassTask>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
