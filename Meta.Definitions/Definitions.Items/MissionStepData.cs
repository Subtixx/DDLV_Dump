using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200051D")]
	public sealed class MissionStepData : IMessage<MissionStepData>, IMessage, IEquatable<MissionStepData>, IDeepCloneable<MissionStepData>, IMessageFieldAccessor, IMissionStepName, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001B44")]
		private static readonly MessageParser<MissionStepData> _parser = (MessageParser<MissionStepData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MissionStepData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001B45")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001B46")]
		public const int ChoiceRequirementFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001B47")]
		private MissionChoice choiceRequirement_;

		[Cpp2IlInjected.Token(Token = "0x4001B48")]
		public const int StepDescriptionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001B49")]
		private string stepDescription_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001B4A")]
		public const int StoryDescriptionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001B4B")]
		private string storyDescription_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001B4C")]
		public const int ShowProgressionCountFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001B4D")]
		private bool showProgressionCount_;

		[Cpp2IlInjected.Token(Token = "0x4001B4E")]
		public const int OngoingRequestButtonFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001B4F")]
		private string ongoingRequestButton_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001B50")]
		public const int OngoingDialogueFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001B51")]
		private string ongoingDialogue_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001B52")]
		public const int StepIDFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001B53")]
		private int stepID_;

		[Cpp2IlInjected.Token(Token = "0x4001B54")]
		public const int StepNameFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001B55")]
		private string stepName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001B56")]
		public const int SubStepsFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x4001B57")]
		private static readonly FieldCodec<MissionSubStepData> _repeated_subSteps_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001B58")]
		private readonly RepeatedField<MissionSubStepData> subSteps_ = (RepeatedField<MissionSubStepData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001B59")]
		public const int NextSubStepIDFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001B5A")]
		private int nextSubStepID_;

		[Cpp2IlInjected.Token(Token = "0x17001046")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionStepData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003F68")]
			[Cpp2IlInjected.Address(RVA = "0x29E95E0", Offset = "0x29E7FE0", VA = "0x1829E95E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001047")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003F69")]
			[Cpp2IlInjected.Address(RVA = "0x29E9510", Offset = "0x29E7F10", VA = "0x1829E9510")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001048")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003F6A")]
			[Cpp2IlInjected.Address(RVA = "0x29E9640", Offset = "0x29E8040", VA = "0x1829E9640", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001049")]
		[DebuggerNonUserCode]
		public MissionChoice ChoiceRequirement
		{
			[Cpp2IlInjected.Token(Token = "0x6003F6E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return choiceRequirement_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F6F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				choiceRequirement_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104A")]
		[DebuggerNonUserCode]
		public string StepDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6003F70")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return stepDescription_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F71")]
			[Cpp2IlInjected.Address(RVA = "0x29E9830", Offset = "0x29E8230", VA = "0x1829E9830")]
			set
			{
				string text = (stepDescription_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104B")]
		[DebuggerNonUserCode]
		public string StoryDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6003F72")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return storyDescription_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F73")]
			[Cpp2IlInjected.Address(RVA = "0x29E9910", Offset = "0x29E8310", VA = "0x1829E9910")]
			set
			{
				string text = (storyDescription_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104C")]
		[DebuggerNonUserCode]
		public bool ShowProgressionCount
		{
			[Cpp2IlInjected.Token(Token = "0x6003F74")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return showProgressionCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F75")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				showProgressionCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104D")]
		[DebuggerNonUserCode]
		public string OngoingRequestButton
		{
			[Cpp2IlInjected.Token(Token = "0x6003F76")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return ongoingRequestButton_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F77")]
			[Cpp2IlInjected.Address(RVA = "0x29E97C0", Offset = "0x29E81C0", VA = "0x1829E97C0")]
			set
			{
				string text = (ongoingRequestButton_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104E")]
		[DebuggerNonUserCode]
		public string OngoingDialogue
		{
			[Cpp2IlInjected.Token(Token = "0x6003F78")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return ongoingDialogue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F79")]
			[Cpp2IlInjected.Address(RVA = "0x29E9750", Offset = "0x29E8150", VA = "0x1829E9750")]
			set
			{
				string text = (ongoingDialogue_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700104F")]
		[DebuggerNonUserCode]
		public int StepID
		{
			[Cpp2IlInjected.Token(Token = "0x6003F7A")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return stepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F7B")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				stepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001050")]
		[DebuggerNonUserCode]
		public string StepName
		{
			[Cpp2IlInjected.Token(Token = "0x6003F7C")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "14")]
			get
			{
				return stepName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F7D")]
			[Cpp2IlInjected.Address(RVA = "0x29E98A0", Offset = "0x29E82A0", VA = "0x1829E98A0", Slot = "15")]
			set
			{
				string text = (stepName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001051")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionSubStepData> SubSteps
		{
			[Cpp2IlInjected.Token(Token = "0x6003F7E")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return subSteps_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001052")]
		[DebuggerNonUserCode]
		public int NextSubStepID
		{
			[Cpp2IlInjected.Token(Token = "0x6003F7F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return nextSubStepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F80")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7E0", Offset = "0xA5A1E0", VA = "0x180A5B7E0")]
			set
			{
				nextSubStepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001053")]
		public IEnumerable<MissionObjectiveData> AllObjectives
		{
			[Cpp2IlInjected.Token(Token = "0x6003F8C")]
			[Cpp2IlInjected.Address(RVA = "0x29E93E0", Offset = "0x29E7DE0", VA = "0x1829E93E0")]
			get
			{
				RepeatedField<MissionSubStepData> repeatedField = subSteps_;
				Func<MissionSubStepData, IEnumerable<MissionObjectiveData>> _003C_003E9__74_ = _003C_003Ec._003C_003E9__74_0;
				if (_003C_003E9__74_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionSubStepData x)
					{
						RepeatedField<MissionObjectiveData> objectives_ = x.objectives_;
						throw new NullReferenceException();
					};
				}
				return (IEnumerable<MissionObjectiveData>)Enumerable.SelectMany<MissionSubStepData, MissionObjectiveData>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__74_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F6B")]
		[Cpp2IlInjected.Address(RVA = "0x29E9100", Offset = "0x29E7B00", VA = "0x1829E9100")]
		[DebuggerNonUserCode]
		public MissionStepData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003F6C")]
		[Cpp2IlInjected.Address(RVA = "0x29E91F0", Offset = "0x29E7BF0", VA = "0x1829E91F0")]
		[DebuggerNonUserCode]
		public MissionStepData(MissionStepData other)
		{
			MissionChoice missionChoice = (choiceRequirement_ = other.choiceRequirement_);
			string text = (stepDescription_ = other.stepDescription_);
			string text2 = (storyDescription_ = other.storyDescription_);
			bool flag = (showProgressionCount_ = other.showProgressionCount_);
			string text3 = (ongoingRequestButton_ = other.ongoingRequestButton_);
			string text4 = (ongoingDialogue_ = other.ongoingDialogue_);
			int num = (stepID_ = other.stepID_);
			string text5 = (stepName_ = other.stepName_);
			RepeatedField<MissionSubStepData> repeatedField = (subSteps_ = (RepeatedField<MissionSubStepData>)(object)((RepeatedField<T>)(object)other.subSteps_).Clone());
			int num2 = (nextSubStepID_ = other.nextSubStepID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F6D")]
		[Cpp2IlInjected.Address(RVA = "0x29E62B0", Offset = "0x29E4CB0", VA = "0x1829E62B0", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionStepData Clone()
		{
			return new MissionStepData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F81")]
		[Cpp2IlInjected.Address(RVA = "0x29E7BF0", Offset = "0x29E65F0", VA = "0x1829E7BF0", Slot = "0")]
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
				if ((IntPtr)(void*)(int)choiceRequirement_ == (IntPtr)typeof(MissionStepData).TypeHandle)
				{
					string text = stepDescription_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = storyDescription_;
						bool flag2 = default(bool);
						if (!flag2 && showProgressionCount_ == flag2)
						{
							string text3 = ongoingRequestButton_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = ongoingDialogue_;
								bool flag4 = default(bool);
								if (!flag4 && stepID_ == (flag4 ? 1 : 0))
								{
									string text5 = stepName_;
									bool flag5 = default(bool);
									if (!flag5)
									{
										RepeatedField<MissionSubStepData> repeatedField = subSteps_;
										bool flag6 = default(bool);
										if (flag6 && nextSubStepID_ == (flag6 ? 1 : 0))
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

		[Cpp2IlInjected.Token(Token = "0x6003F82")]
		[Cpp2IlInjected.Address(RVA = "0x29E7AC0", Offset = "0x29E64C0", VA = "0x1829E7AC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionStepData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MissionChoice missionChoice = other.choiceRequirement_;
				if (choiceRequirement_ == missionChoice)
				{
					string text = other.stepDescription_;
					if (!(stepDescription_ != text))
					{
						string text2 = other.storyDescription_;
						if (!(storyDescription_ != text2))
						{
							bool flag = other.showProgressionCount_;
							if (showProgressionCount_ == flag)
							{
								string text3 = other.ongoingRequestButton_;
								if (!(ongoingRequestButton_ != text3))
								{
									string text4 = other.ongoingDialogue_;
									if (!(ongoingDialogue_ != text4))
									{
										int num = other.stepID_;
										if (stepID_ == num)
										{
											string text5 = other.stepName_;
											if (!(stepName_ != text5))
											{
												RepeatedField<MissionSubStepData> repeatedField = subSteps_;
												RepeatedField<MissionSubStepData> repeatedField2 = other.subSteps_;
												if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
												{
													int num2 = other.nextSubStepID_;
													if (nextSubStepID_ == num2)
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F83")]
		[Cpp2IlInjected.Address(RVA = "0x29E8120", Offset = "0x29E6B20", VA = "0x1829E8120", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00cb
			int num = 0;
			if (choiceRequirement_ != 0)
			{
			}
			string text = stepDescription_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = storyDescription_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			if (showProgressionCount_)
			{
			}
			string text3 = ongoingRequestButton_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = ongoingDialogue_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			if (stepID_ != 0)
			{
			}
			string text5 = stepName_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			int hashCode6 = ((RepeatedField<T>)(object)subSteps_).GetHashCode();
			if (nextSubStepID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F84")]
		[Cpp2IlInjected.Address(RVA = "0x29E8A70", Offset = "0x29E7470", VA = "0x1829E8A70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F85")]
		[Cpp2IlInjected.Address(RVA = "0x29E8CB0", Offset = "0x29E76B0", VA = "0x1829E8CB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0111
			if (choiceRequirement_ != 0)
			{
			}
			if (stepDescription_.m_stringLength != 0)
			{
				string value = stepDescription_;
				output.WriteString(value);
			}
			if (storyDescription_.m_stringLength != 0)
			{
				string value2 = storyDescription_;
				output.WriteString(value2);
			}
			if (showProgressionCount_)
			{
				bool value3 = showProgressionCount_;
				output.WriteBool(value3);
			}
			if (ongoingRequestButton_.m_stringLength != 0)
			{
				string value4 = ongoingRequestButton_;
				output.WriteString(value4);
			}
			if (ongoingDialogue_.m_stringLength != 0)
			{
				string value5 = ongoingDialogue_;
				output.WriteString(value5);
			}
			if (stepID_ != 0)
			{
				int value6 = stepID_;
				output.WriteInt32(value6);
			}
			if (stepName_.m_stringLength != 0)
			{
				string value7 = stepName_;
				output.WriteString(value7);
			}
			RepeatedField<MissionSubStepData> repeatedField = subSteps_;
			FieldCodec<MissionSubStepData> repeated_subSteps_codec = _repeated_subSteps_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_subSteps_codec);
			if (nextSubStepID_ != 0)
			{
				int value8 = nextSubStepID_;
				output.WriteInt32(value8);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F86")]
		[Cpp2IlInjected.Address(RVA = "0x29E5E80", Offset = "0x29E4880", VA = "0x1829E5E80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_014d
			MissionChoice missionChoice = choiceRequirement_;
			int num = 0;
			if (missionChoice != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)missionChoice);
			}
			string text = stepDescription_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			string text2 = storyDescription_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				num += num4;
			}
			string text3 = ongoingRequestButton_;
			if (text3.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text3);
				num5++;
				num += num5;
			}
			string text4 = ongoingDialogue_;
			if (text4.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text4);
				num6++;
				num += num6;
			}
			int num7 = stepID_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num += num8;
			}
			string text5 = stepName_;
			if (text5.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text5);
				num9++;
				num += num9;
			}
			RepeatedField<MissionSubStepData> repeatedField = subSteps_;
			FieldCodec<MissionSubStepData> repeated_subSteps_codec = _repeated_subSteps_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_subSteps_codec);
			int num11 = nextSubStepID_;
			num += num10;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num += num12;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num += num13;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F87")]
		[Cpp2IlInjected.Address(RVA = "0x29E83B0", Offset = "0x29E6DB0", VA = "0x1829E83B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionStepData other)
		{
			//Discarded unreachable code: IL_010a
			if (other != null)
			{
				MissionChoice missionChoice = other.choiceRequirement_;
				if (missionChoice != 0)
				{
					choiceRequirement_ = missionChoice;
				}
				string text = other.stepDescription_;
				if (text.m_stringLength != 0)
				{
					StepDescription = text;
				}
				string text2 = other.storyDescription_;
				if (text2.m_stringLength != 0)
				{
					StoryDescription = text2;
				}
				bool flag = other.showProgressionCount_;
				if (flag)
				{
					showProgressionCount_ = flag;
				}
				string text3 = other.ongoingRequestButton_;
				if (text3.m_stringLength != 0)
				{
					OngoingRequestButton = text3;
				}
				string text4 = other.ongoingDialogue_;
				if (text4.m_stringLength != 0)
				{
					OngoingDialogue = text4;
				}
				int num = other.stepID_;
				if (num != 0)
				{
					stepID_ = num;
				}
				string text5 = other.stepName_;
				if (text5.m_stringLength != 0)
				{
					StepName = text5;
				}
				RepeatedField<MissionSubStepData> repeatedField = subSteps_;
				RepeatedField<MissionSubStepData> repeatedField2 = other.subSteps_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num2 = other.nextSubStepID_;
				if (num2 != 0)
				{
					nextSubStepID_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F88")]
		[Cpp2IlInjected.Address(RVA = "0x29E84F0", Offset = "0x29E6EF0", VA = "0x1829E84F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0124
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 42)
			{
				if ((int)num > 72)
				{
					if (num == 82)
					{
						string text2 = (StepName = input.ReadString());
					}
					if (num == 90)
					{
						RepeatedField<MissionSubStepData> repeatedField = subSteps_;
						FieldCodec<MissionSubStepData> repeated_subSteps_codec = _repeated_subSteps_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_subSteps_codec);
					}
					if (num != 96)
					{
						goto IL_010d;
					}
					int num2 = (nextSubStepID_ = input.ReadInt32());
				}
				string text4 = default(string);
				if (num == 50)
				{
					text4 = (OngoingDialogue = input.ReadString());
				}
				if ((long)text4 != 72)
				{
					goto IL_010d;
				}
				int num3 = (stepID_ = input.ReadInt32());
			}
			string text8 = default(string);
			if ((int)num > 18)
			{
				string text6 = default(string);
				if (num == 26)
				{
					text6 = (StoryDescription = input.ReadString());
				}
				bool flag = default(bool);
				if ((long)text6 == 32)
				{
					flag = (showProgressionCount_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_010d;
				}
				text8 = (OngoingRequestButton = input.ReadString());
			}
			int num4 = default(int);
			if ((long)text8 == 8)
			{
				num4 = (int)(choiceRequirement_ = (MissionChoice)input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text10 = (StepDescription = input.ReadString());
			}
			goto IL_010d;
			IL_010d:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003F89")]
		[Cpp2IlInjected.Address(RVA = "0x29E7F60", Offset = "0x29E6960", VA = "0x1829E7F60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				MissionChoice missionChoice = choiceRequirement_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F8A")]
		[Cpp2IlInjected.Address(RVA = "0x29E8710", Offset = "0x29E7110", VA = "0x1829E8710", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_001e, IL_0026, IL_0027, IL_0028, IL_0035, IL_003d, IL_003e, IL_004b, IL_0053, IL_0059, IL_005f, IL_0065, IL_006b, IL_0071, IL_0077, IL_007d
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 11)
			{
				object obj = default(object);
				choiceRequirement_ = (MissionChoice)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F8B")]
		[Cpp2IlInjected.Address(RVA = "0x29E6120", Offset = "0x29E4B20", VA = "0x1829E6120", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_001b
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 11)
			{
				choiceRequirement_ = MissionChoice.Any;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F8D")]
		[Cpp2IlInjected.Address(RVA = "0x29E82B0", Offset = "0x29E6CB0", VA = "0x1829E82B0")]
		public bool HasCustomStep(MissionObjectiveData.CustomStepOneofCase customStep, [Optional] Func<MissionObjectiveData, bool> predicate)
		{
			//Discarded unreachable code: IL_0032
			IEnumerable<MissionObjectiveData> allObjectives = (IEnumerable<MissionObjectiveData>)this.get_AllObjectives();
			Func<MissionObjectiveData, bool> cpp2il__autoParamName__idx_ = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
			{
				//Discarded unreachable code: IL_0027
				//IL_0025: Expected I4, but got O
				MissionObjectiveData.CustomStepOneofCase customStepOneofCase = customStep;
				if (x.customStepCase_ != customStepOneofCase)
				{
					int num = 0;
				}
				Func<MissionObjectiveData, bool> func = predicate;
				return (func == null) ? true : ((byte)(int)func((T)x) != 0);
			};
			return ((IEnumerable<>)allObjectives).Any<MissionObjectiveData>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F8E")]
		[Cpp2IlInjected.Address(RVA = "0x29E7D70", Offset = "0x29E6770", VA = "0x1829E7D70")]
		public MissionObjectiveData GetCustomStepObjective(MissionObjectiveData.CustomStepOneofCase customStep)
		{
			//Discarded unreachable code: IL_0030
			IEnumerable<MissionObjectiveData> allObjectives = (IEnumerable<MissionObjectiveData>)this.get_AllObjectives();
			Func<MissionObjectiveData, bool> func = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
			{
				//Discarded unreachable code: IL_0011
				MissionObjectiveData.CustomStepOneofCase customStepOneofCase = customStep;
				return x.customStepCase_ == customStepOneofCase;
			};
			return Enumerable.FirstOrDefault<MissionObjectiveData>(Enumerable.Where<MissionObjectiveData>((IEnumerable<>)allObjectives, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x6003F8F")]
		[Cpp2IlInjected.Address(RVA = "0x29E7E80", Offset = "0x29E6880", VA = "0x1829E7E80")]
		public IEnumerable<MissionObjectiveData> GetCustomStepObjectives(MissionObjectiveData.CustomStepOneofCase customStep)
		{
			//Discarded unreachable code: IL_002b
			IEnumerable<MissionObjectiveData> allObjectives = (IEnumerable<MissionObjectiveData>)this.get_AllObjectives();
			Func<MissionObjectiveData, bool> func = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
			{
				//Discarded unreachable code: IL_0011
				MissionObjectiveData.CustomStepOneofCase customStepOneofCase = customStep;
				return x.customStepCase_ == customStepOneofCase;
			};
			return (IEnumerable<MissionObjectiveData>)Enumerable.Where<MissionObjectiveData>((IEnumerable<>)allObjectives, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F90")]
		[Cpp2IlInjected.Address(RVA = "0x29E6310", Offset = "0x29E4D10", VA = "0x1829E6310", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_00b9: Expected O, but got I4
			//IL_0140: Expected O, but got I4
			//IL_0153: Expected O, but got I4
			//IL_038c: Expected O, but got I4
			int num4 = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			MissionObjectiveData missionObjectiveData = default(MissionObjectiveData);
			bool flag3 = default(bool);
			string error = default(string);
			MissionSubStepData data = default(MissionSubStepData);
			int num6 = default(int);
			MissionSubStepData missionSubStepData = default(MissionSubStepData);
			MissionSubStepData missionSubStepData2 = default(MissionSubStepData);
			bool flag4 = default(bool);
			MissionSubStepData data2 = default(MissionSubStepData);
			int num8 = default(int);
			Func<MissionObjectiveData, bool> cpp2il__autoParamName__idx_ = default(Func<MissionObjectiveData, bool>);
			Func<MissionObjectiveData, bool> func = default(Func<MissionObjectiveData, bool>);
			Func<MissionObjectiveData, bool> func2 = default(Func<MissionObjectiveData, bool>);
			Func<MissionObjectiveData, Item> func3 = default(Func<MissionObjectiveData, Item>);
			Func<MissionObjectiveData, bool> cpp2il__autoParamName__idx_2 = default(Func<MissionObjectiveData, bool>);
			IEnumerable<MissionObjectiveData> allObjectives5 = default(IEnumerable<MissionObjectiveData>);
			Func<MissionObjectiveData, bool> cpp2il__autoParamName__idx_3 = default(Func<MissionObjectiveData, bool>);
			int num10 = default(int);
			int num11 = default(int);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			Func<MissionSubStepData, bool> func4 = default(Func<MissionSubStepData, bool>);
			Func<MissionSubStepData, Item> func5 = default(Func<MissionSubStepData, Item>);
			do
			{
				IL_0000:
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				bool checkSubstep;
				if (num4 != 0)
				{
					if (_003C_003Ec._003C_003E9__78_0 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSubStepData x) => Enumerable.Any<MissionObjectiveData>((IEnumerable<>)(object)x.objectives_));
					}
					if (flag)
					{
						int num5 = 0;
						if (flag2)
						{
							string text = missionObjectiveData.stepDescription_;
							bool checkObj = missionObjectiveData == null;
							Predicate<MissionObjectiveData> predicate = (Predicate<MissionObjectiveData>)(object)(Predicate<T>)((MissionObjectiveData x) => CheckObjective(x) != checkObj);
							while (!flag3)
							{
							}
							context.AddError(error);
							num3++;
						}
						num3++;
						if (num3 != 0)
						{
							goto IL_0000;
						}
						if (num3 != 0)
						{
						}
						checkSubstep = CheckSubstep(data);
						Predicate<MissionSubStepData> predicate2 = (Predicate<MissionSubStepData>)(object)(Predicate<T>)((MissionSubStepData x) => CheckSubstep(x) != checkSubstep);
						if (!((RepeatedField<>)num2).Any<MissionSubStepData>((Predicate<>)(object)predicate2))
						{
							goto IL_011d;
						}
						if (num6 == 2)
						{
							int num7 = 0;
							MissionObjectiveData missionObjectiveData2 = Enumerable.FirstOrDefault<MissionObjectiveData>((IEnumerable<>)(object)missionSubStepData.objectives_);
							if (missionObjectiveData2 != null && missionObjectiveData2.Possess != null)
							{
								MissionObjectiveData missionObjectiveData3 = Enumerable.FirstOrDefault<MissionObjectiveData>((IEnumerable<>)(object)missionSubStepData2.objectives_);
								if (missionObjectiveData3 != null && missionObjectiveData3.Chase != null)
								{
									if (checkSubstep)
									{
									}
									flag4 = (checkSubstep = CheckSubstep(data2));
									goto IL_011d;
								}
							}
						}
						goto IL_0142;
					}
				}
				else
				{
					string error2 = stepName_ + " cannot be empty, one step is required";
					context.AddError(error2);
				}
				goto IL_0170;
				IL_0142:
				string text2 = "StepDescription problem in " + (string)num8 + ": Don't mix steps with and without a description in same group";
				return;
				IL_0170:
				if (showProgressionCount_ && string.IsNullOrEmpty(stepDescription_))
				{
					context.AddInvalidMemberError("Cannot be enable without StepDescription", "ShowProgressionCount");
				}
				IEnumerable<MissionObjectiveData> allObjectives = (IEnumerable<MissionObjectiveData>)this.get_AllObjectives();
				if (_003C_003Ec._003C_003E9__78_1 == null)
				{
					cpp2il__autoParamName__idx_ = (Func<MissionObjectiveData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjectiveData x) => x.customStepCase_ != MissionObjectiveData.CustomStepOneofCase.TalkToCharacter || x.TalkToCharacter.targetIsNotOwner_.useField_));
				}
				bool flag5 = ((IEnumerable<>)allObjectives).Any<MissionObjectiveData>((Func<, >)(object)cpp2il__autoParamName__idx_);
				string text3 = ongoingRequestButton_;
				if (flag5)
				{
					string text4 = stepName_;
					string message = "Required on " + text4;
					context.AddInvalidMemberError(message, "OngoingRequestButton");
				}
				IEnumerable<MissionObjectiveData> allObjectives2 = (IEnumerable<MissionObjectiveData>)this.get_AllObjectives();
				if (_003C_003Ec._003C_003E9__78_2 == null)
				{
					func = (Func<MissionObjectiveData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
					{
						CustomStepTalkToCharacter talkToCharacter3 = x.TalkToCharacter;
						if (talkToCharacter3 != null)
						{
							return !talkToCharacter3.targetIsNotOwner_.useField_;
						}
						throw new NullReferenceException();
					});
				}
				if (Enumerable.Count<MissionObjectiveData>((IEnumerable<>)allObjectives2, (Func<, >)(object)func) > 1)
				{
					string text5 = stepName_;
					string error3 = "Cannot have multiple TalkTo with mission owner at same time: " + text5;
					context.AddError(error3);
				}
				IEnumerable<MissionObjectiveData> allObjectives3 = (IEnumerable<MissionObjectiveData>)this.get_AllObjectives();
				if (_003C_003Ec._003C_003E9__78_3 == null)
				{
					func2 = (Func<MissionObjectiveData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
					{
						CustomStepTalkToCharacter talkToCharacter2 = x.TalkToCharacter;
						if (talkToCharacter2 != null)
						{
							return talkToCharacter2.targetIsNotOwner_.useField_;
						}
						throw new NullReferenceException();
					});
				}
				IEnumerable<MissionObjectiveData> enumerable = (IEnumerable<MissionObjectiveData>)Enumerable.Where<MissionObjectiveData>((IEnumerable<>)allObjectives3, (Func<, >)(object)func2);
				if (_003C_003Ec._003C_003E9__78_4 == null)
				{
					func3 = (Func<MissionObjectiveData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
					{
						int targetCharacter = x.TalkToCharacter.targetIsNotOwner_.Character.TargetCharacter;
						throw new NullReferenceException();
					});
				}
				List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<MissionObjectiveData, Item>((IEnumerable<>)enumerable, (Func<, >)(object)func3));
				int size = ((List<>)(object)list)._size;
				int num9 = Enumerable.Count<Item>(Enumerable.Distinct<Item>((IEnumerable<>)list));
				if (size != num9)
				{
					string text6 = stepName_;
					string error4 = "Cannot have multiple TalkTo to same character at same time: " + text6;
					context.AddError(error4);
				}
				IEnumerable<MissionObjectiveData> allObjectives4 = (IEnumerable<MissionObjectiveData>)this.get_AllObjectives();
				if (_003C_003Ec._003C_003E9__78_5 == null)
				{
					cpp2il__autoParamName__idx_2 = (Func<MissionObjectiveData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
					{
						CustomStepTalkToCharacter talkToCharacter = x.TalkToCharacter;
						if (talkToCharacter != null)
						{
							return !talkToCharacter.targetIsNotOwner_.useField_;
						}
						throw new NullReferenceException();
					});
				}
				if (((IEnumerable<>)allObjectives4).Any<MissionObjectiveData>((Func<, >)(object)cpp2il__autoParamName__idx_2))
				{
					allObjectives5 = (IEnumerable<MissionObjectiveData>)this.get_AllObjectives();
					if (_003C_003Ec._003C_003E9__78_6 == null)
					{
						cpp2il__autoParamName__idx_3 = (Func<MissionObjectiveData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
						{
							//Discarded unreachable code: IL_0020
							CustomStepFollowCharacter followCharacter = x.FollowCharacter;
							return (followCharacter != null) ? (followCharacter.TalkTo != null) : (followCharacter != null);
						});
					}
					if (((IEnumerable<>)allObjectives5).Any<MissionObjectiveData>((Func<, >)(object)cpp2il__autoParamName__idx_3))
					{
						string text7 = stepName_;
						string error5 = "Cannot mix TalkTo with FollowCharater+TalkTo in " + text7;
						context.AddError(error5);
					}
				}
				if (nextSubStepID_ < num10)
				{
					string message2 = $"Something went wrong, cannot be lower than {num11}";
					context.AddInvalidMemberError(message2, "NextSubStepID");
				}
				Predicate<MissionSubStepData> predicate3 = (Predicate<MissionSubStepData>)(object)(Predicate<T>)delegate(MissionSubStepData x)
				{
					//Discarded unreachable code: IL_0014
					int num12 = nextSubStepID_;
					return x.subStepID_ >= num12;
				};
				if (flag6)
				{
					context.AddInvalidMemberError("Something went wrong, ids must be lower than NextSubStepID", "SubStepID");
				}
				Predicate<MissionSubStepData> predicate4 = (Predicate<MissionSubStepData>)(object)(Predicate<T>)delegate(MissionSubStepData x)
				{
					//Discarded unreachable code: IL_002c
					RepeatedField<MissionSubStepData> repeatedField = subSteps_;
					Func<MissionSubStepData, bool> func6 = (Func<MissionSubStepData, bool>)(object)(Func<T, TResult>)delegate(MissionSubStepData y)
					{
						//Discarded unreachable code: IL_0016
						int subStepID_ = x.subStepID_;
						return y.subStepID_ == subStepID_;
					};
					return Enumerable.Count<MissionSubStepData>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func6) > 1;
				};
				if (flag7)
				{
					context.AddInvalidMemberError("Something went wrong, ids are not unique", "SubStepID");
				}
				if (_003C_003Ec._003C_003E9__78_9 == null)
				{
					func4 = (Func<MissionSubStepData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSubStepData x) => x.isOwnerFollowing_));
				}
				IEnumerable<MissionSubStepData> enumerable2 = (IEnumerable<MissionSubStepData>)Enumerable.Where<MissionSubStepData>((IEnumerable<>)allObjectives5, (Func<, >)(object)func4);
				if (_003C_003Ec._003C_003E9__78_10 == null)
				{
					func5 = (Func<MissionSubStepData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionSubStepData x) => x.FollowerItem));
				}
				if (Enumerable.Count<Item>(Enumerable.Distinct<Item>(Enumerable.Select<MissionSubStepData, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func5))) > 1)
				{
					string error6 = stepName_ + " cannot contain multiple Follower";
					context.AddError(error6);
				}
				continue;
				IL_011d:
				num8 = 0;
				if (flag4 && !checkSubstep)
				{
					string text8 = "StepDescription problem in " + (string)num8 + ": At least one description is missing (Group, Steps or Objectives)";
					goto IL_0142;
				}
				goto IL_0170;
			}
			while (_003C_003Ec._003C_003E9__78_11 != null);
			_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((MissionSubStepData x) => x.isOwnerFollowing_);
			/*Error: Unexpected end of block*/;
			[Cpp2IlInjected.Token(Token = "0x6003F92")]
			[Cpp2IlInjected.Address(RVA = "0x29E8BE0", Offset = "0x29E75E0", VA = "0x1829E8BE0")]
			static bool CheckObjective(MissionObjectiveData _data)
			{
				//Discarded unreachable code: IL_000f
				return !string.IsNullOrEmpty(_data.stepDescription_);
			}
			[Cpp2IlInjected.Token(Token = "0x6003F93")]
			[Cpp2IlInjected.Address(RVA = "0x29E8C10", Offset = "0x29E7610", VA = "0x1829E8C10")]
			static bool CheckSubstep(MissionSubStepData _data)
			{
				//Discarded unreachable code: IL_0029
				if (!string.IsNullOrEmpty(_data.stepDescription_))
				{
					return true;
				}
				return !string.IsNullOrEmpty(Enumerable.First<MissionObjectiveData>((IEnumerable<>)(object)_data.objectives_).stepDescription_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F91")]
		[Cpp2IlInjected.Address(RVA = "0x29E8F30", Offset = "0x29E7930", VA = "0x1829E8F30")]
		static MissionStepData()
		{
			MessageParser<MissionSubStepData> parser = MissionSubStepData._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionStepData>)(object)FieldCodec.ForMessage<MissionSubStepData>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
