using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Missions;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000533")]
	public sealed class MissionItemData : IMessage<MissionItemData>, IMessage, IEquatable<MissionItemData>, IDeepCloneable<MissionItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IItemData, IHasGlotID, IUpdateVersion, IDataValidation, IHasItemDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x2000534")]
		public enum CompletedOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001C5E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001C5F")]
			Any = 50,
			[Cpp2IlInjected.Token(Token = "0x4001C60")]
			Choices = 51,
			[Cpp2IlInjected.Token(Token = "0x4001C61")]
			NoOutro = 52
		}

		[Cpp2IlInjected.Token(Token = "0x2000535")]
		public enum RewardsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001C63")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001C64")]
			OverrideRewards = 60
		}

		[Cpp2IlInjected.Token(Token = "0x2000536")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000537")]
			public enum MissionStatus
			{
				[Cpp2IlInjected.Token(Token = "0x4001C66")]
				[OriginalName("MissionStatus_Debug")]
				Debug,
				[Cpp2IlInjected.Token(Token = "0x4001C67")]
				[OriginalName("MissionStatus_Available")]
				Available
			}

			[Cpp2IlInjected.Token(Token = "0x2000538")]
			public sealed class CompletedDescriptionDialogue : IMessage<CompletedDescriptionDialogue>, IMessage, IEquatable<CompletedDescriptionDialogue>, IDeepCloneable<CompletedDescriptionDialogue>, IMessageFieldAccessor, IDataValidation
			{
				[Cpp2IlInjected.Token(Token = "0x4001C68")]
				private static readonly MessageParser<CompletedDescriptionDialogue> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001C69")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001C6A")]
				public const int CompletedRequestDescriptionFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001C6B")]
				private string completedRequestDescription_;

				[Cpp2IlInjected.Token(Token = "0x4001C6C")]
				public const int OutroDialogueFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001C6D")]
				private string outroDialogue_;

				[Cpp2IlInjected.Token(Token = "0x170010E8")]
				[DebuggerNonUserCode]
				public static MessageParser<CompletedDescriptionDialogue> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600413C")]
					[Cpp2IlInjected.Address(RVA = "0x2FE9670", Offset = "0x2FE8070", VA = "0x182FE9670")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010E9")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600413D")]
					[Cpp2IlInjected.Address(RVA = "0x2FE95F0", Offset = "0x2FE7FF0", VA = "0x182FE95F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010EA")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600413E")]
					[Cpp2IlInjected.Address(RVA = "0x2FE96D0", Offset = "0x2FE80D0", VA = "0x182FE96D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010EB")]
				[DebuggerNonUserCode]
				public string CompletedRequestDescription
				{
					[Cpp2IlInjected.Token(Token = "0x6004142")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004143")]
					[Cpp2IlInjected.Address(RVA = "0x2FE9790", Offset = "0x2FE8190", VA = "0x182FE9790")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010EC")]
				[DebuggerNonUserCode]
				public string OutroDialogue
				{
					[Cpp2IlInjected.Token(Token = "0x6004144")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004145")]
					[Cpp2IlInjected.Address(RVA = "0x2FE9800", Offset = "0x2FE8200", VA = "0x182FE9800")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600413F")]
				[Cpp2IlInjected.Address(RVA = "0x2FE94C0", Offset = "0x2FE7EC0", VA = "0x182FE94C0")]
				[DebuggerNonUserCode]
				public CompletedDescriptionDialogue()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004140")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9520", Offset = "0x2FE7F20", VA = "0x182FE9520")]
				[DebuggerNonUserCode]
				public CompletedDescriptionDialogue(CompletedDescriptionDialogue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004141")]
				[Cpp2IlInjected.Address(RVA = "0x2FE8E30", Offset = "0x2FE7830", VA = "0x182FE8E30", Slot = "10")]
				[DebuggerNonUserCode]
				public CompletedDescriptionDialogue Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004146")]
				[Cpp2IlInjected.Address(RVA = "0x2FE8FC0", Offset = "0x2FE79C0", VA = "0x182FE8FC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004147")]
				[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(CompletedDescriptionDialogue other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004148")]
				[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004149")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9350", Offset = "0x2FE7D50", VA = "0x182FE9350", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600414A")]
				[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600414B")]
				[Cpp2IlInjected.Address(RVA = "0x2FE8CA0", Offset = "0x2FE76A0", VA = "0x182FE8CA0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600414C")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9110", Offset = "0x2FE7B10", VA = "0x182FE9110", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(CompletedDescriptionDialogue other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600414D")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9190", Offset = "0x2FE7B90", VA = "0x182FE9190", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600414E")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9080", Offset = "0x2FE7A80", VA = "0x182FE9080", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600414F")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9240", Offset = "0x2FE7C40", VA = "0x182FE9240", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004150")]
				[Cpp2IlInjected.Address(RVA = "0x2FE8D80", Offset = "0x2FE7780", VA = "0x182FE8D80", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004151")]
				[Cpp2IlInjected.Address(RVA = "0x2FE8F30", Offset = "0x2FE7930", VA = "0x182FE8F30", Slot = "14")]
				public void DataValidation(DataValidation.Context context)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200053A")]
			public sealed class CompletedDescriptionDialogueChoices : IMessage<CompletedDescriptionDialogueChoices>, IMessage, IEquatable<CompletedDescriptionDialogueChoices>, IDeepCloneable<CompletedDescriptionDialogueChoices>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001C6F")]
				private static readonly MessageParser<CompletedDescriptionDialogueChoices> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001C70")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001C71")]
				public const int Choice1FieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001C72")]
				private CompletedDescriptionDialogue choice1_;

				[Cpp2IlInjected.Token(Token = "0x4001C73")]
				public const int Choice2FieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001C74")]
				private CompletedDescriptionDialogue choice2_;

				[Cpp2IlInjected.Token(Token = "0x4001C75")]
				public const int Choice3FieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001C76")]
				private CompletedDescriptionDialogue choice3_;

				[Cpp2IlInjected.Token(Token = "0x170010ED")]
				[DebuggerNonUserCode]
				public static MessageParser<CompletedDescriptionDialogueChoices> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004156")]
					[Cpp2IlInjected.Address(RVA = "0x2FE8B80", Offset = "0x2FE7580", VA = "0x182FE8B80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010EE")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004157")]
					[Cpp2IlInjected.Address(RVA = "0x2FE8B00", Offset = "0x2FE7500", VA = "0x182FE8B00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010EF")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004158")]
					[Cpp2IlInjected.Address(RVA = "0x2FE8BE0", Offset = "0x2FE75E0", VA = "0x182FE8BE0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010F0")]
				[DebuggerNonUserCode]
				public CompletedDescriptionDialogue Choice1
				{
					[Cpp2IlInjected.Token(Token = "0x600415D")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600415E")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010F1")]
				[DebuggerNonUserCode]
				public CompletedDescriptionDialogue Choice2
				{
					[Cpp2IlInjected.Token(Token = "0x600415F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004160")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010F2")]
				[DebuggerNonUserCode]
				public CompletedDescriptionDialogue Choice3
				{
					[Cpp2IlInjected.Token(Token = "0x6004161")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004162")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004159")]
				[Cpp2IlInjected.Address(RVA = "0x2FE8980", Offset = "0x2FE7380", VA = "0x182FE8980")]
				[DebuggerNonUserCode]
				public CompletedDescriptionDialogueChoices()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600415A")]
				[Cpp2IlInjected.Address(RVA = "0x2FE8370", Offset = "0x2FE6D70", VA = "0x182FE8370")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600415B")]
				[Cpp2IlInjected.Address(RVA = "0x2FE8740", Offset = "0x2FE7140", VA = "0x182FE8740")]
				[DebuggerNonUserCode]
				public CompletedDescriptionDialogueChoices(CompletedDescriptionDialogueChoices other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600415C")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7D80", Offset = "0x2FE6780", VA = "0x182FE7D80", Slot = "10")]
				[DebuggerNonUserCode]
				public CompletedDescriptionDialogueChoices Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004163")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7DE0", Offset = "0x2FE67E0", VA = "0x182FE7DE0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004164")]
				[Cpp2IlInjected.Address(RVA = "0x713280", Offset = "0x711C80", VA = "0x180713280", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(CompletedDescriptionDialogueChoices other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004165")]
				[Cpp2IlInjected.Address(RVA = "0x7133C0", Offset = "0x711DC0", VA = "0x1807133C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004166")]
				[Cpp2IlInjected.Address(RVA = "0x2FE85D0", Offset = "0x2FE6FD0", VA = "0x182FE85D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004167")]
				[Cpp2IlInjected.Address(RVA = "0x2375E90", Offset = "0x2374890", VA = "0x182375E90", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004168")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7C70", Offset = "0x2FE6670", VA = "0x182FE7C70", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004169")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7F60", Offset = "0x2FE6960", VA = "0x182FE7F60", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(CompletedDescriptionDialogueChoices other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600416A")]
				[Cpp2IlInjected.Address(RVA = "0x2FE8200", Offset = "0x2FE6C00", VA = "0x182FE8200", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600416B")]
				[Cpp2IlInjected.Address(RVA = "0x2FE7EC0", Offset = "0x2FE68C0", VA = "0x182FE7EC0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600416C")]
				[Cpp2IlInjected.Address(RVA = "0x2FE84F0", Offset = "0x2FE6EF0", VA = "0x182FE84F0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600416D")]
				[Cpp2IlInjected.Address(RVA = "0x2375600", Offset = "0x2374000", VA = "0x182375600", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200053C")]
			public sealed class AutoAcceptOption : IMessage<AutoAcceptOption>, IMessage, IEquatable<AutoAcceptOption>, IDeepCloneable<AutoAcceptOption>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001C78")]
				private static readonly MessageParser<AutoAcceptOption> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001C79")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001C7A")]
				public const int ChoiceFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001C7B")]
				private MissionChoice choice_;

				[Cpp2IlInjected.Token(Token = "0x4001C7C")]
				public const int ConditionsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001C7D")]
				private ConditionsList conditions_;

				[Cpp2IlInjected.Token(Token = "0x170010F3")]
				[DebuggerNonUserCode]
				public static MessageParser<AutoAcceptOption> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004172")]
					[Cpp2IlInjected.Address(RVA = "0x2FE6920", Offset = "0x2FE5320", VA = "0x182FE6920")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010F4")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004173")]
					[Cpp2IlInjected.Address(RVA = "0x2FE68A0", Offset = "0x2FE52A0", VA = "0x182FE68A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010F5")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004174")]
					[Cpp2IlInjected.Address(RVA = "0x2FE6980", Offset = "0x2FE5380", VA = "0x182FE6980", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010F6")]
				[DebuggerNonUserCode]
				public MissionChoice Choice
				{
					[Cpp2IlInjected.Token(Token = "0x6004179")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(MissionChoice);
					}
					[Cpp2IlInjected.Token(Token = "0x600417A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010F7")]
				[DebuggerNonUserCode]
				public ConditionsList Conditions
				{
					[Cpp2IlInjected.Token(Token = "0x600417B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600417C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004175")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6760", Offset = "0x2FE5160", VA = "0x182FE6760")]
				[DebuggerNonUserCode]
				public AutoAcceptOption()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004176")]
				[Cpp2IlInjected.Address(RVA = "0x2FE64C0", Offset = "0x2FE4EC0", VA = "0x182FE64C0")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004177")]
				[Cpp2IlInjected.Address(RVA = "0x2FE67D0", Offset = "0x2FE51D0", VA = "0x182FE67D0")]
				[DebuggerNonUserCode]
				public AutoAcceptOption(AutoAcceptOption other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004178")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6070", Offset = "0x2FE4A70", VA = "0x182FE6070", Slot = "10")]
				[DebuggerNonUserCode]
				public AutoAcceptOption Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600417D")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6170", Offset = "0x2FE4B70", VA = "0x182FE6170", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600417E")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(AutoAcceptOption other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600417F")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004180")]
				[Cpp2IlInjected.Address(RVA = "0x2FE65F0", Offset = "0x2FE4FF0", VA = "0x182FE65F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004181")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004182")]
				[Cpp2IlInjected.Address(RVA = "0x2FE5FA0", Offset = "0x2FE49A0", VA = "0x182FE5FA0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004183")]
				[Cpp2IlInjected.Address(RVA = "0x2FE63E0", Offset = "0x2FE4DE0", VA = "0x182FE63E0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(AutoAcceptOption other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004184")]
				[Cpp2IlInjected.Address(RVA = "0x2FE62F0", Offset = "0x2FE4CF0", VA = "0x182FE62F0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004185")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6220", Offset = "0x2FE4C20", VA = "0x182FE6220", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004186")]
				[Cpp2IlInjected.Address(RVA = "0x2FE6520", Offset = "0x2FE4F20", VA = "0x182FE6520", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004187")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001C20")]
		private static readonly MessageParser<MissionItemData> _parser = (MessageParser<MissionItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MissionItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001C21")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001C22")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C23")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4001C24")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001C25")]
		private string name_;

		[Cpp2IlInjected.Token(Token = "0x4001C26")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001C27")]
		private string displayName_;

		[Cpp2IlInjected.Token(Token = "0x4001C28")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001C29")]
		private string prefabAddress_;

		[Cpp2IlInjected.Token(Token = "0x4001C2A")]
		public const int OwnerCharacterFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001C2B")]
		private int ownerCharacter_;

		[Cpp2IlInjected.Token(Token = "0x4001C2C")]
		public const int StatusFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001C2D")]
		private Types.MissionStatus status_;

		[Cpp2IlInjected.Token(Token = "0x4001C2E")]
		public const int TypeFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001C2F")]
		private MissionType type_;

		[Cpp2IlInjected.Token(Token = "0x4001C30")]
		public const int UpdateVersionFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001C31")]
		private string updateVersion_;

		[Cpp2IlInjected.Token(Token = "0x4001C32")]
		public const int QuestIdFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001C33")]
		private int questId_;

		[Cpp2IlInjected.Token(Token = "0x4001C34")]
		public const int AvailableConditionsFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001C35")]
		private ConditionsList availableConditions_;

		[Cpp2IlInjected.Token(Token = "0x4001C36")]
		public const int UnlockConditionsFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001C37")]
		private ConditionsList unlockConditions_;

		[Cpp2IlInjected.Token(Token = "0x4001C38")]
		public const int AutoAcceptFieldNumber = 14;

		[Cpp2IlInjected.Token(Token = "0x4001C39")]
		private static readonly FieldCodec<Types.AutoAcceptOption> _repeated_autoAccept_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001C3A")]
		private readonly RepeatedField<Types.AutoAcceptOption> autoAccept_;

		[Cpp2IlInjected.Token(Token = "0x4001C3B")]
		public const int AvailableDescriptionFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001C3C")]
		private string availableDescription_;

		[Cpp2IlInjected.Token(Token = "0x4001C3D")]
		public const int StartRequestButtonFieldNumber = 31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001C3E")]
		private string startRequestButton_;

		[Cpp2IlInjected.Token(Token = "0x4001C3F")]
		public const int IntroDialogueFieldNumber = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001C40")]
		private string introDialogue_;

		[Cpp2IlInjected.Token(Token = "0x4001C41")]
		public const int ItemsToGiveFieldNumber = 33;

		[Cpp2IlInjected.Token(Token = "0x4001C42")]
		private static readonly FieldCodec<AnyItemSelectorWithAmount> _repeated_itemsToGive_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001C43")]
		private readonly RepeatedField<AnyItemSelectorWithAmount> itemsToGive_;

		[Cpp2IlInjected.Token(Token = "0x4001C44")]
		public const int StepsFieldNumber = 40;

		[Cpp2IlInjected.Token(Token = "0x4001C45")]
		private static readonly FieldCodec<MissionStepData> _repeated_steps_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001C46")]
		private readonly RepeatedField<MissionStepData> steps_;

		[Cpp2IlInjected.Token(Token = "0x4001C47")]
		public const int NextStepIDFieldNumber = 41;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001C48")]
		private int nextStepID_;

		[Cpp2IlInjected.Token(Token = "0x4001C49")]
		public const int CompletedStoryDescriptionFieldNumber = 42;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001C4A")]
		private string completedStoryDescription_;

		[Cpp2IlInjected.Token(Token = "0x4001C4B")]
		public const int AnyFieldNumber = 50;

		[Cpp2IlInjected.Token(Token = "0x4001C4C")]
		public const int ChoicesFieldNumber = 51;

		[Cpp2IlInjected.Token(Token = "0x4001C4D")]
		public const int NoOutroFieldNumber = 52;

		[Cpp2IlInjected.Token(Token = "0x4001C4E")]
		public const int OverrideRewardsFieldNumber = 60;

		[Cpp2IlInjected.Token(Token = "0x4001C4F")]
		public const int AdditionnalRewardsFieldNumber = 61;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001C50")]
		private LootTable additionnalRewards_;

		[Cpp2IlInjected.Token(Token = "0x4001C51")]
		public const int RewardsXPFieldNumber = 62;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001C52")]
		private MissionReward rewardsXP_;

		[Cpp2IlInjected.Token(Token = "0x4001C53")]
		public const int ItemsToDeleteAfterMissionFieldNumber = 63;

		[Cpp2IlInjected.Token(Token = "0x4001C54")]
		private static readonly FieldCodec<int> _repeated_itemsToDeleteAfterMission_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001C55")]
		private readonly RepeatedField<int> itemsToDeleteAfterMission_;

		[Cpp2IlInjected.Token(Token = "0x4001C56")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001C57")]
		private uint glotID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001C58")]
		private object completed_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001C59")]
		private CompletedOneofCase completedCase_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001C5A")]
		private object rewards_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001C5B")]
		private RewardsOneofCase rewardsCase_;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001C5C")]
		private List<Item> itemDependencies;

		[Cpp2IlInjected.Token(Token = "0x170010BD")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60040C7")]
			[Cpp2IlInjected.Address(RVA = "0x1D46CF0", Offset = "0x1D456F0", VA = "0x181D46CF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010BE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60040C8")]
			[Cpp2IlInjected.Address(RVA = "0x1D45F30", Offset = "0x1D44930", VA = "0x181D45F30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010BF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60040C9")]
			[Cpp2IlInjected.Address(RVA = "0x1D46D50", Offset = "0x1D45750", VA = "0x181D46D50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C0")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60040CE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040CF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C1")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60040D0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040D1")]
			[Cpp2IlInjected.Address(RVA = "0x1D470A0", Offset = "0x1D45AA0", VA = "0x181D470A0")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C2")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60040D2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040D3")]
			[Cpp2IlInjected.Address(RVA = "0x1D46FC0", Offset = "0x1D459C0", VA = "0x181D46FC0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C3")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60040D4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040D5")]
			[Cpp2IlInjected.Address(RVA = "0x1D47190", Offset = "0x1D45B90", VA = "0x181D47190")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C4")]
		[DebuggerNonUserCode]
		public int OwnerCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60040D6")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return ownerCharacter_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040D7")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				ownerCharacter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C5")]
		[DebuggerNonUserCode]
		public Types.MissionStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x60040D8")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return status_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040D9")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				status_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C6")]
		[DebuggerNonUserCode]
		public MissionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60040DA")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040DB")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C7")]
		[DebuggerNonUserCode]
		public string UpdateVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60040DC")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "25")]
			get
			{
				return updateVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040DD")]
			[Cpp2IlInjected.Address(RVA = "0x1D47270", Offset = "0x1D45C70", VA = "0x181D47270", Slot = "26")]
			set
			{
				string text = (updateVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C8")]
		[DebuggerNonUserCode]
		public int QuestId
		{
			[Cpp2IlInjected.Token(Token = "0x60040DE")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return questId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040DF")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				questId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010C9")]
		[DebuggerNonUserCode]
		public ConditionsList AvailableConditions
		{
			[Cpp2IlInjected.Token(Token = "0x60040E0")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return availableConditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040E1")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			set
			{
				availableConditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010CA")]
		[DebuggerNonUserCode]
		public ConditionsList UnlockConditions
		{
			[Cpp2IlInjected.Token(Token = "0x60040E2")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return unlockConditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040E3")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				unlockConditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010CB")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.AutoAcceptOption> AutoAccept
		{
			[Cpp2IlInjected.Token(Token = "0x60040E4")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return autoAccept_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010CC")]
		[DebuggerNonUserCode]
		public string AvailableDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60040E5")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return availableDescription_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040E6")]
			[Cpp2IlInjected.Address(RVA = "0x1D46EA0", Offset = "0x1D458A0", VA = "0x181D46EA0")]
			set
			{
				string text = (availableDescription_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010CD")]
		[DebuggerNonUserCode]
		public string StartRequestButton
		{
			[Cpp2IlInjected.Token(Token = "0x60040E7")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return startRequestButton_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040E8")]
			[Cpp2IlInjected.Address(RVA = "0x1D47200", Offset = "0x1D45C00", VA = "0x181D47200")]
			set
			{
				string text = (startRequestButton_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010CE")]
		[DebuggerNonUserCode]
		public string IntroDialogue
		{
			[Cpp2IlInjected.Token(Token = "0x60040E9")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return introDialogue_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040EA")]
			[Cpp2IlInjected.Address(RVA = "0x1D47030", Offset = "0x1D45A30", VA = "0x181D47030")]
			set
			{
				string text = (introDialogue_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010CF")]
		[DebuggerNonUserCode]
		public RepeatedField<AnyItemSelectorWithAmount> ItemsToGive
		{
			[Cpp2IlInjected.Token(Token = "0x60040EB")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return itemsToGive_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D0")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionStepData> Steps
		{
			[Cpp2IlInjected.Token(Token = "0x60040EC")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return steps_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D1")]
		[DebuggerNonUserCode]
		public int NextStepID
		{
			[Cpp2IlInjected.Token(Token = "0x60040ED")]
			[Cpp2IlInjected.Address(RVA = "0x63F650", Offset = "0x63E050", VA = "0x18063F650")]
			get
			{
				return nextStepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040EE")]
			[Cpp2IlInjected.Address(RVA = "0x1373C40", Offset = "0x1372640", VA = "0x181373C40")]
			set
			{
				nextStepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D2")]
		[DebuggerNonUserCode]
		public string CompletedStoryDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60040EF")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return completedStoryDescription_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040F0")]
			[Cpp2IlInjected.Address(RVA = "0x1D46F50", Offset = "0x1D45950", VA = "0x181D46F50")]
			set
			{
				string text = (completedStoryDescription_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D3")]
		[DebuggerNonUserCode]
		public Types.CompletedDescriptionDialogue Any
		{
			[Cpp2IlInjected.Token(Token = "0x60040F1")]
			[Cpp2IlInjected.Address(RVA = "0x1D45D70", Offset = "0x1D44770", VA = "0x181D45D70")]
			get
			{
				int num = 0;
				if (completedCase_ == CompletedOneofCase.Any)
				{
					object obj = completed_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60040F2")]
			[Cpp2IlInjected.Address(RVA = "0x1D46E60", Offset = "0x1D45860", VA = "0x181D46E60")]
			set
			{
				completed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D4")]
		[DebuggerNonUserCode]
		public Types.CompletedDescriptionDialogueChoices Choices
		{
			[Cpp2IlInjected.Token(Token = "0x60040F3")]
			[Cpp2IlInjected.Address(RVA = "0x1D45DD0", Offset = "0x1D447D0", VA = "0x181D45DD0")]
			get
			{
				int num = 0;
				if (completedCase_ == CompletedOneofCase.Choices)
				{
					object obj = completed_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60040F4")]
			[Cpp2IlInjected.Address(RVA = "0x1D46F10", Offset = "0x1D45910", VA = "0x181D46F10")]
			set
			{
				completed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D5")]
		[DebuggerNonUserCode]
		public Empty NoOutro
		{
			[Cpp2IlInjected.Token(Token = "0x60040F5")]
			[Cpp2IlInjected.Address(RVA = "0x1D46B00", Offset = "0x1D45500", VA = "0x181D46B00")]
			get
			{
				int num = 0;
				if (completedCase_ == CompletedOneofCase.NoOutro)
				{
					object obj = completed_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60040F6")]
			[Cpp2IlInjected.Address(RVA = "0x1D47110", Offset = "0x1D45B10", VA = "0x181D47110")]
			set
			{
				completed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D6")]
		[DebuggerNonUserCode]
		public OverrideRewards OverrideRewards
		{
			[Cpp2IlInjected.Token(Token = "0x60040F7")]
			[Cpp2IlInjected.Address(RVA = "0x1D46B60", Offset = "0x1D45560", VA = "0x181D46B60")]
			get
			{
				int num = 0;
				if (rewardsCase_ == RewardsOneofCase.OverrideRewards)
				{
					object obj = rewards_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60040F8")]
			[Cpp2IlInjected.Address(RVA = "0x1D47150", Offset = "0x1D45B50", VA = "0x181D47150")]
			set
			{
				rewards_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D7")]
		[DebuggerNonUserCode]
		public LootTable AdditionnalRewards
		{
			[Cpp2IlInjected.Token(Token = "0x60040F9")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return additionnalRewards_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040FA")]
			[Cpp2IlInjected.Address(RVA = "0xA5ACE0", Offset = "0xA596E0", VA = "0x180A5ACE0")]
			set
			{
				additionnalRewards_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D8")]
		[DebuggerNonUserCode]
		public MissionReward RewardsXP
		{
			[Cpp2IlInjected.Token(Token = "0x60040FB")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return rewardsXP_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040FC")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
			set
			{
				rewardsXP_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010D9")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemsToDeleteAfterMission
		{
			[Cpp2IlInjected.Token(Token = "0x60040FD")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			get
			{
				return itemsToDeleteAfterMission_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010DA")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x60040FE")]
			[Cpp2IlInjected.Address(RVA = "0x148A150", Offset = "0x1488B50", VA = "0x18148A150", Slot = "23")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x60040FF")]
			[Cpp2IlInjected.Address(RVA = "0x148A410", Offset = "0x1488E10", VA = "0x18148A410", Slot = "24")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010DB")]
		[DebuggerNonUserCode]
		public CompletedOneofCase CompletedCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004100")]
			[Cpp2IlInjected.Address(RVA = "0xE58440", Offset = "0xE56E40", VA = "0x180E58440")]
			get
			{
				return completedCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010DC")]
		[DebuggerNonUserCode]
		public RewardsOneofCase RewardsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004102")]
			[Cpp2IlInjected.Address(RVA = "0x7DAFE0", Offset = "0x7D99E0", VA = "0x1807DAFE0")]
			get
			{
				return rewardsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010DD")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004111")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "17")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010DE")]
		public Item QuestItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004112")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				int num = questId_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010DF")]
		public Item OwnerCharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004113")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				int num = ownerCharacter_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010E0")]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004114")]
			[Cpp2IlInjected.Address(RVA = "0x1D46060", Offset = "0x1D44A60", VA = "0x181D46060", Slot = "20")]
			get
			{
				//Discarded unreachable code: IL_0010
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				bool flag = default(bool);
				if (flag)
				{
				}
				return string.Empty;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010E1")]
		public Item OwnerCharacterHouseItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004115")]
			[Cpp2IlInjected.Address(RVA = "0x1D46BC0", Offset = "0x1D455C0", VA = "0x181D46BC0")]
			get
			{
				//Discarded unreachable code: IL_0010
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				bool flag = default(bool);
				if (flag)
				{
				}
				return Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010E2")]
		public IEnumerable<MissionObjectiveData> AllStepsObjectives
		{
			[Cpp2IlInjected.Token(Token = "0x6004117")]
			[Cpp2IlInjected.Address(RVA = "0x1D45BC0", Offset = "0x1D445C0", VA = "0x181D45BC0")]
			get
			{
				RepeatedField<MissionStepData> repeatedField = steps_;
				Func<MissionStepData, IEnumerable<MissionObjectiveData>> _003C_003E9__181_ = _003C_003Ec._003C_003E9__181_0;
				if (_003C_003E9__181_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => (IEnumerable<MissionObjectiveData>)x.get_AllObjectives());
				}
				return (IEnumerable<MissionObjectiveData>)Enumerable.SelectMany<MissionStepData, MissionObjectiveData>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__181_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010E3")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6004118")]
			[Cpp2IlInjected.Address(RVA = "0x1D46000", Offset = "0x1D44A00", VA = "0x181D46000", Slot = "28")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010E4")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6004119")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "29")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010E5")]
		public unsafe List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x600411A")]
			[Cpp2IlInjected.Address(RVA = "0x1D46170", Offset = "0x1D44B70", VA = "0x181D46170", Slot = "30")]
			get
			{
				//Discarded unreachable code: IL_0147, IL_014d, IL_0153, IL_0159, IL_015f, IL_0165, IL_016b, IL_0171, IL_0177, IL_017d, IL_0183, IL_0189, IL_018f, IL_0195, IL_019b
				//IL_004b: Expected O, but got I4
				int num4 = default(int);
				bool flag = default(bool);
				IEnumerable<ItemWithState> enumerable2 = default(IEnumerable<ItemWithState>);
				bool flag2 = default(bool);
				IEnumerable<MissionObjectiveData> enumerable3 = default(IEnumerable<MissionObjectiveData>);
				CustomStepFollowCharacter customStepFollowCharacter = default(CustomStepFollowCharacter);
				CustomStepFollowCharacter customStepFollowCharacter2 = default(CustomStepFollowCharacter);
				CustomStepTalkToCharacter customStepTalkToCharacter = default(CustomStepTalkToCharacter);
				Action<AnyItemSelectorWithAmount> action = default(Action<AnyItemSelectorWithAmount>);
				bool flag3 = default(bool);
				MissionSubStepData.Types.ExtraBringItem extraBringItem = default(MissionSubStepData.Types.ExtraBringItem);
				MissionSubStepData.Types.ExtraBringItem extraBringItem2 = default(MissionSubStepData.Types.ExtraBringItem);
				Func<ItemToGiveAmount, Item> func2 = default(Func<ItemToGiveAmount, Item>);
				while (true)
				{
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					if ((IntPtr)itemDependencies != (IntPtr)num2)
					{
						break;
					}
					List<Item> list = (itemDependencies = (List<Item>)(object)new List<T>());
					if (rewardsCase_ == RewardsOneofCase.OverrideRewards)
					{
						List<Item> list2 = itemDependencies;
						RepeatedField<int> repeatedField = OverrideRewards.rewards_;
						Func<int, Item> func = (Func<int, Item>)(object)new Func<T, TResult>(num4, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<int, Item>*/)(&Item.New));
						num4 = 0;
						IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Select<int, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
						((List<T>)(object)list2).AddRange((IEnumerable<>)enumerable);
					}
					LootTable lootTable = additionnalRewards_;
					if (lootTable != null)
					{
						RepeatedField<SubLootTable> subLootTables_ = lootTable.subLootTables_;
						if (flag)
						{
							List<Item> list3 = itemDependencies;
							if (_003C_003Ec._003C_003E9__188_2 == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemWithState x) => x.Item);
							}
							((List<T>)(object)list3).AddRange((IEnumerable<>)enumerable2);
						}
					}
					if (!flag2)
					{
						break;
					}
					if (enumerable3 != null)
					{
						if ((long)enumerable3 == 108)
						{
						}
						if ((long)enumerable3 == 175)
						{
							if (customStepFollowCharacter.TalkTo == null)
							{
								continue;
							}
							CustomStepFollowCharacter.Types.FollowTalkTo talkTo = customStepFollowCharacter2.TalkTo;
						}
						while ((long)enumerable3 != 270)
						{
						}
						((RepeatedField<>)(object)customStepTalkToCharacter.itemsToGive_).ForEach<AnyItemSelectorWithAmount>((Action<>)(object)action);
					}
					if (enumerable3 != null)
					{
					}
					if (!flag3)
					{
						break;
					}
					while (extraBringItem == null)
					{
					}
					RepeatedField<ItemToGiveAmount> repeatedField2 = extraBringItem2.itemsToGive_;
					if (_003C_003Ec._003C_003E9__188_6 == null)
					{
						func2 = (Func<ItemToGiveAmount, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ItemToGiveAmount x)
						{
							//Discarded unreachable code: IL_000d
							int itemToGive_ = x.itemToGive_;
							return (Item)typeof(Item).TypeHandle;
						});
					}
					IEnumerable<ItemToGiveAmount> enumerable4 = (IEnumerable<ItemToGiveAmount>)Enumerable.Select<ItemToGiveAmount, Item>((IEnumerable<>)(object)repeatedField2, (Func<, >)(object)func2);
					break;
				}
				return itemDependencies;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010E6")]
		public string DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x6004125")]
			[Cpp2IlInjected.Address(RVA = "0x1D45E30", Offset = "0x1D44830", VA = "0x181D45E30")]
			get
			{
				//Discarded unreachable code: IL_004d
				//IL_003e: Expected O, but got I4
				string text = name_;
				int num = 0;
				if (text != null)
				{
					char[] array = new char[0];
					array[0] = '!';
					string[] array2 = text.Split(array);
				}
				if ((type_ == (MissionType)num && num == 0) || num != 0)
				{
				}
				IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Skip<string>((IEnumerable<>)num, 3);
				return string.Join("!", (IEnumerable<>)enumerable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010E7")]
		public bool AlwaysAutoAccept
		{
			[Cpp2IlInjected.Token(Token = "0x600412B")]
			[Cpp2IlInjected.Address(RVA = "0x1D45CF0", Offset = "0x1D446F0", VA = "0x181D45CF0")]
			get
			{
				Types.AutoAcceptOption autoAcceptOption = Enumerable.LastOrDefault<Types.AutoAcceptOption>((IEnumerable<>)(object)autoAccept_);
				if (autoAcceptOption != null)
				{
					return !Enumerable.Any<ConditionOneOf>((IEnumerable<>)(object)autoAcceptOption.conditions_.conditions_);
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60040CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D45500", Offset = "0x1D43F00", VA = "0x181D45500")]
		[DebuggerNonUserCode]
		public MissionItemData()
		{
			//IL_00c7: Expected I4, but got O
			name_ = "";
			displayName_ = "";
			prefabAddress_ = "";
			updateVersion_ = "";
			autoAccept_ = (RepeatedField<Types.AutoAcceptOption>)(object)new RepeatedField<T>();
			availableDescription_ = "";
			startRequestButton_ = "";
			introDialogue_ = "";
			itemsToGive_ = (RepeatedField<AnyItemSelectorWithAmount>)(object)new RepeatedField<T>();
			steps_ = (RepeatedField<MissionStepData>)(object)new RepeatedField<T>();
			completedStoryDescription_ = "";
			itemsToDeleteAfterMission_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
			ConditionsList conditionsList = (availableConditions_ = new ConditionsList());
			ConditionsList conditionsList2 = (unlockConditions_ = new ConditionsList());
			completedCase_ = (CompletedOneofCase)(completed_ = new Types.CompletedDescriptionDialogue());
		}

		[Cpp2IlInjected.Token(Token = "0x60040CB")]
		[Cpp2IlInjected.Address(RVA = "0x1D42FE0", Offset = "0x1D419E0", VA = "0x181D42FE0")]
		private void OnConstruction()
		{
			//IL_002e: Expected I4, but got O
			ConditionsList conditionsList = (availableConditions_ = new ConditionsList());
			ConditionsList conditionsList2 = (unlockConditions_ = new ConditionsList());
			completedCase_ = (CompletedOneofCase)(completed_ = new Types.CompletedDescriptionDialogue());
		}

		[Cpp2IlInjected.Token(Token = "0x60040CC")]
		[Cpp2IlInjected.Address(RVA = "0x1D457B0", Offset = "0x1D441B0", VA = "0x181D457B0")]
		[DebuggerNonUserCode]
		public MissionItemData(MissionItemData other)
		{
			//IL_00a9: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			//IL_0174: Expected O, but got I4
			//IL_0192: Expected O, but got I4
			//IL_0219: Expected I4, but got O
			//IL_023c: Expected I4, but got O
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (ownerCharacter_ = other.ownerCharacter_);
			Types.MissionStatus missionStatus = (status_ = other.status_);
			MissionType missionType = (type_ = other.type_);
			string text4 = (updateVersion_ = other.updateVersion_);
			int num3 = other.questId_;
			int num4 = 0;
			questId_ = num3;
			ConditionsList conditionsList = other.availableConditions_;
			if (conditionsList != null)
			{
				ConditionsList conditionsList2 = conditionsList.Clone();
			}
			availableConditions_ = (ConditionsList)num4;
			ConditionsList conditionsList3 = other.unlockConditions_;
			if (conditionsList3 != null)
			{
				ConditionsList conditionsList4 = conditionsList3.Clone();
			}
			unlockConditions_ = (ConditionsList)num4;
			RepeatedField<Types.AutoAcceptOption> repeatedField = (autoAccept_ = (RepeatedField<Types.AutoAcceptOption>)(object)((RepeatedField<T>)(object)other.autoAccept_).Clone());
			string text5 = (availableDescription_ = other.availableDescription_);
			string text6 = (startRequestButton_ = other.startRequestButton_);
			string text7 = (introDialogue_ = other.introDialogue_);
			RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = (itemsToGive_ = (RepeatedField<AnyItemSelectorWithAmount>)(object)((RepeatedField<T>)(object)other.itemsToGive_).Clone());
			RepeatedField<MissionStepData> repeatedField3 = (steps_ = (RepeatedField<MissionStepData>)(object)((RepeatedField<T>)(object)other.steps_).Clone());
			int num5 = (nextStepID_ = other.nextStepID_);
			string text8 = (completedStoryDescription_ = other.completedStoryDescription_);
			LootTable lootTable = other.additionnalRewards_;
			if (lootTable != null)
			{
				LootTable lootTable2 = lootTable.Clone();
			}
			additionnalRewards_ = (LootTable)num4;
			MissionReward missionReward = other.rewardsXP_;
			if (missionReward != null)
			{
				MissionReward missionReward2 = missionReward.Clone();
			}
			rewardsXP_ = (MissionReward)num4;
			RepeatedField<int> repeatedField4 = other.itemsToDeleteAfterMission_;
			RepeatedField<int> repeatedField5 = (itemsToDeleteAfterMission_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)repeatedField4).Clone());
			uint num6 = (glotID_ = other.glotID_);
			CompletedOneofCase completedOneofCase = other.completedCase_;
			if (repeatedField4 != null)
			{
				if (repeatedField4 != null)
				{
					if (completedOneofCase != (CompletedOneofCase)1)
					{
						goto IL_0219;
					}
					Empty empty = (Empty)(completed_ = other.NoOutro.Clone());
				}
				Types.CompletedDescriptionDialogueChoices completedDescriptionDialogueChoices = (Types.CompletedDescriptionDialogueChoices)(completed_ = other.Choices.Clone());
			}
			completedCase_ = (CompletedOneofCase)(completed_ = other.Any.Clone());
			goto IL_0219;
			IL_0219:
			if (other.rewardsCase_ == RewardsOneofCase.OverrideRewards)
			{
				if (other.rewards_ == null)
				{
					throw new InvalidCastException();
				}
				OverrideRewards overrideRewards = default(OverrideRewards);
				rewards_ = overrideRewards;
				rewardsCase_ = (RewardsOneofCase)overrideRewards;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60040CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D2F0", Offset = "0x1D3BCF0", VA = "0x181D3D2F0", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionItemData Clone()
		{
			return new MissionItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004101")]
		[Cpp2IlInjected.Address(RVA = "0x1D3CE80", Offset = "0x1D3B880", VA = "0x181D3CE80")]
		[DebuggerNonUserCode]
		public void ClearCompleted()
		{
			//IL_0010: Expected O, but got I4
			completed_ = (completedCase_ = CompletedOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004103")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D2D0", Offset = "0x1D3BCD0", VA = "0x181D3D2D0")]
		[DebuggerNonUserCode]
		public void ClearRewards()
		{
			//IL_0010: Expected O, but got I4
			rewards_ = (rewardsCase_ = RewardsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004104")]
		[Cpp2IlInjected.Address(RVA = "0x1D3FAE0", Offset = "0x1D3E4E0", VA = "0x181D3FAE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((MissionItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004105")]
		[Cpp2IlInjected.Address(RVA = "0x1D3FB40", Offset = "0x1D3E540", VA = "0x181D3FB40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionItemData other)
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
							string text3 = other.prefabAddress_;
							if (!(prefabAddress_ != text3))
							{
								int num2 = other.ownerCharacter_;
								if (ownerCharacter_ == num2)
								{
									Types.MissionStatus missionStatus = other.status_;
									if (status_ == missionStatus)
									{
										MissionType missionType = other.type_;
										if (type_ == missionType)
										{
											string text4 = other.updateVersion_;
											if (!(updateVersion_ != text4))
											{
												int num3 = other.questId_;
												if (questId_ == num3)
												{
													ConditionsList objB = other.availableConditions_;
													if (object.Equals(availableConditions_, objB))
													{
														ConditionsList objB2 = other.unlockConditions_;
														if (object.Equals(unlockConditions_, objB2))
														{
															RepeatedField<Types.AutoAcceptOption> repeatedField = autoAccept_;
															RepeatedField<Types.AutoAcceptOption> repeatedField2 = other.autoAccept_;
															if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
															{
																string text5 = other.availableDescription_;
																if (!(availableDescription_ != text5))
																{
																	string text6 = other.startRequestButton_;
																	if (!(startRequestButton_ != text6))
																	{
																		string text7 = other.introDialogue_;
																		if (!(introDialogue_ != text7))
																		{
																			RepeatedField<AnyItemSelectorWithAmount> repeatedField3 = itemsToGive_;
																			RepeatedField<AnyItemSelectorWithAmount> repeatedField4 = other.itemsToGive_;
																			if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
																			{
																				RepeatedField<MissionStepData> repeatedField5 = steps_;
																				RepeatedField<MissionStepData> repeatedField6 = other.steps_;
																				if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
																				{
																					int num4 = other.nextStepID_;
																					if (nextStepID_ == num4)
																					{
																						string text8 = other.completedStoryDescription_;
																						if (!(completedStoryDescription_ != text8))
																						{
																							Types.CompletedDescriptionDialogue any = Any;
																							Types.CompletedDescriptionDialogue any2 = other.Any;
																							if (object.Equals(any, any2))
																							{
																								Types.CompletedDescriptionDialogueChoices choices = Choices;
																								Types.CompletedDescriptionDialogueChoices choices2 = other.Choices;
																								if (object.Equals(choices, choices2))
																								{
																									Empty noOutro = NoOutro;
																									Empty noOutro2 = other.NoOutro;
																									if (object.Equals(noOutro, noOutro2))
																									{
																										OverrideRewards overrideRewards = OverrideRewards;
																										OverrideRewards overrideRewards2 = other.OverrideRewards;
																										if (object.Equals(overrideRewards, overrideRewards2))
																										{
																											LootTable objB3 = other.additionnalRewards_;
																											if (object.Equals(additionnalRewards_, objB3))
																											{
																												MissionReward objB4 = other.rewardsXP_;
																												if (object.Equals(rewardsXP_, objB4))
																												{
																													RepeatedField<int> repeatedField7 = itemsToDeleteAfterMission_;
																													RepeatedField<int> repeatedField8 = other.itemsToDeleteAfterMission_;
																													if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
																													{
																														uint num5 = other.glotID_;
																														if (glotID_ == num5)
																														{
																															CompletedOneofCase completedOneofCase = other.completedCase_;
																															if (completedCase_ == completedOneofCase)
																															{
																																RewardsOneofCase rewardsOneofCase = other.rewardsCase_;
																																if (rewardsCase_ == rewardsOneofCase)
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
								}
							}
						}
					}
				}
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004106")]
		[Cpp2IlInjected.Address(RVA = "0x1D40270", Offset = "0x1D3EC70", VA = "0x181D40270", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0253
			while (true)
			{
				int num = iD_;
				int num2 = 0;
				if (num != 0)
				{
				}
				string text = name_;
				if (text.m_stringLength != num2)
				{
					int hashCode = text.GetHashCode();
				}
				string text2 = displayName_;
				if (text2.m_stringLength != num2)
				{
					int hashCode2 = text2.GetHashCode();
				}
				string text3 = prefabAddress_;
				if (text3.m_stringLength != num2)
				{
					int hashCode3 = text3.GetHashCode();
				}
				if (ownerCharacter_ != 0)
				{
				}
				if (status_ != 0)
				{
				}
				if (type_ != 0)
				{
				}
				string text4 = updateVersion_;
				if (text4.m_stringLength != num2)
				{
					int hashCode4 = text4.GetHashCode();
				}
				if (questId_ != 0)
				{
				}
				ConditionsList conditionsList = availableConditions_;
				if (conditionsList != null)
				{
					int hashCode5 = conditionsList.GetHashCode();
				}
				ConditionsList conditionsList2 = unlockConditions_;
				if (conditionsList2 != null)
				{
					int hashCode6 = conditionsList2.GetHashCode();
				}
				int hashCode7 = ((RepeatedField<T>)(object)autoAccept_).GetHashCode();
				string text5 = availableDescription_;
				if (text5.m_stringLength != num2)
				{
					int hashCode8 = text5.GetHashCode();
				}
				string text6 = startRequestButton_;
				if (text6.m_stringLength != num2)
				{
					int hashCode9 = text6.GetHashCode();
				}
				string text7 = introDialogue_;
				if (text7.m_stringLength != num2)
				{
					int hashCode10 = text7.GetHashCode();
				}
				int hashCode11 = ((RepeatedField<T>)(object)itemsToGive_).GetHashCode();
				int hashCode12 = ((RepeatedField<T>)(object)steps_).GetHashCode();
				if (nextStepID_ != 0)
				{
				}
				string text8 = completedStoryDescription_;
				if (text8.m_stringLength != num2)
				{
					int hashCode13 = text8.GetHashCode();
				}
				if (completedCase_ != CompletedOneofCase.Any)
				{
					continue;
				}
				object obj = completed_;
				if (obj != null)
				{
					int hashCode14 = obj.GetHashCode();
					if (completedCase_ != CompletedOneofCase.Choices)
					{
						continue;
					}
					object obj2 = completed_;
					if (obj2 != null)
					{
						int hashCode15 = obj2.GetHashCode();
						if (completedCase_ == CompletedOneofCase.NoOutro)
						{
							object obj3 = completed_;
							if (obj3 == null)
							{
								throw new InvalidCastException();
							}
							int hashCode16 = obj3.GetHashCode();
						}
						if (rewardsCase_ == RewardsOneofCase.OverrideRewards)
						{
							object obj4 = rewards_;
							if (obj4 == null)
							{
								break;
							}
							int hashCode17 = obj4.GetHashCode();
						}
						LootTable lootTable = additionnalRewards_;
						if (lootTable != null)
						{
							int hashCode18 = lootTable.GetHashCode();
						}
						MissionReward missionReward = rewardsXP_;
						if (missionReward != null)
						{
							int hashCode19 = missionReward.GetHashCode();
						}
						int hashCode20 = ((RepeatedField<T>)(object)itemsToDeleteAfterMission_).GetHashCode();
						if (glotID_ != 0)
						{
						}
						UnknownFieldSet unknownFields = _unknownFields;
						if (unknownFields != null)
						{
							int hashCode21 = unknownFields.GetHashCode();
						}
						return hashCode12;
					}
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004107")]
		[Cpp2IlInjected.Address(RVA = "0x1D439C0", Offset = "0x1D423C0", VA = "0x181D439C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004108")]
		[Cpp2IlInjected.Address(RVA = "0x1D449F0", Offset = "0x1D433F0", VA = "0x181D449F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_030f
			while (true)
			{
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
				if (prefabAddress_.m_stringLength != 0)
				{
					string value4 = prefabAddress_;
					output.WriteString(value4);
				}
				if (ownerCharacter_ != 0)
				{
					int value5 = ownerCharacter_;
					output.WriteInt32(value5);
				}
				if (status_ != 0)
				{
				}
				if (type_ != 0)
				{
				}
				if (updateVersion_.m_stringLength != 0)
				{
					string value6 = updateVersion_;
					output.WriteString(value6);
				}
				if (questId_ != 0)
				{
					int value7 = questId_;
					output.WriteInt32(value7);
				}
				if ((long)availableConditions_ != 0)
				{
					ConditionsList value8 = availableConditions_;
					output.WriteMessage(value8);
				}
				if ((long)unlockConditions_ != 0)
				{
					ConditionsList value9 = unlockConditions_;
					output.WriteMessage(value9);
				}
				RepeatedField<Types.AutoAcceptOption> repeatedField = autoAccept_;
				FieldCodec<Types.AutoAcceptOption> repeated_autoAccept_codec = _repeated_autoAccept_codec;
				((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_autoAccept_codec);
				if (availableDescription_.m_stringLength != 0)
				{
					string value10 = availableDescription_;
					output.WriteString(value10);
				}
				if (startRequestButton_.m_stringLength != 0)
				{
					string value11 = startRequestButton_;
					output.WriteString(value11);
				}
				if (introDialogue_.m_stringLength != 0)
				{
					string value12 = introDialogue_;
					output.WriteString(value12);
				}
				RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = itemsToGive_;
				FieldCodec<AnyItemSelectorWithAmount> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
				((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_itemsToGive_codec);
				RepeatedField<MissionStepData> repeatedField3 = steps_;
				FieldCodec<MissionStepData> repeated_steps_codec = _repeated_steps_codec;
				((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_steps_codec);
				if (nextStepID_ != 0)
				{
					int value13 = nextStepID_;
					output.WriteInt32(value13);
				}
				if (completedStoryDescription_.m_stringLength != 0)
				{
					string value14 = completedStoryDescription_;
					output.WriteString(value14);
				}
				CompletedOneofCase completedOneofCase = completedCase_;
				int num = 0;
				if (completedOneofCase != CompletedOneofCase.Any)
				{
					continue;
				}
				if (completedCase_ == CompletedOneofCase.Any)
				{
					object obj = completed_;
					if (obj != null && obj == null)
					{
						break;
					}
				}
				if (completedCase_ != CompletedOneofCase.Choices)
				{
					continue;
				}
				if (completedCase_ == CompletedOneofCase.Choices)
				{
					object obj2 = completed_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (completedCase_ == CompletedOneofCase.NoOutro && completedCase_ == CompletedOneofCase.NoOutro)
				{
					object obj3 = completed_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (rewardsCase_ == RewardsOneofCase.OverrideRewards && rewardsCase_ == RewardsOneofCase.OverrideRewards)
				{
					object obj4 = rewards_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if ((long)additionnalRewards_ != 0)
				{
					LootTable value15 = additionnalRewards_;
					output.WriteMessage(value15);
				}
				if ((long)rewardsXP_ != 0)
				{
					MissionReward value16 = rewardsXP_;
					output.WriteMessage(value16);
				}
				RepeatedField<int> repeatedField4 = itemsToDeleteAfterMission_;
				FieldCodec<int> repeated_itemsToDeleteAfterMission_codec = _repeated_itemsToDeleteAfterMission_codec;
				((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_itemsToDeleteAfterMission_codec);
				if (glotID_ != 0)
				{
					uint value17 = glotID_;
					output.WriteUInt32(value17);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004109")]
		[Cpp2IlInjected.Address(RVA = "0x1D3C330", Offset = "0x1D3AD30", VA = "0x181D3C330", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_03e3
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = prefabAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			int num7 = ownerCharacter_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num2 += num8;
			}
			Types.MissionStatus missionStatus = status_;
			if (missionStatus != 0)
			{
				int num9 = CodedOutputStream.ComputeEnumSize((int)missionStatus);
				num9++;
				num2 += num9;
			}
			MissionType missionType = type_;
			if (missionType != 0)
			{
				int num10 = CodedOutputStream.ComputeEnumSize((int)missionType);
				num10++;
				num2 += num10;
			}
			string text4 = updateVersion_;
			if (text4.m_stringLength != num2)
			{
				int num11 = CodedOutputStream.ComputeStringSize(text4);
				num11++;
				num2 += num11;
			}
			int num12 = questId_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			ConditionsList conditionsList = availableConditions_;
			if (conditionsList != null)
			{
				int num14 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num14++;
				num2 += num14;
			}
			ConditionsList conditionsList2 = unlockConditions_;
			if (conditionsList2 != null)
			{
				int num15 = CodedOutputStream.ComputeMessageSize(conditionsList2);
				num15++;
				num2 += num15;
			}
			RepeatedField<Types.AutoAcceptOption> repeatedField = autoAccept_;
			FieldCodec<Types.AutoAcceptOption> repeated_autoAccept_codec = _repeated_autoAccept_codec;
			int num16 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_autoAccept_codec);
			string text5 = availableDescription_;
			num2 += num16;
			if (text5.m_stringLength != num2)
			{
				int num17 = CodedOutputStream.ComputeStringSize(text5);
				num17 += 2;
				num2 += num17;
			}
			string text6 = startRequestButton_;
			if (text6.m_stringLength != num2)
			{
				int num18 = CodedOutputStream.ComputeStringSize(text6);
				num18 += 2;
				num2 += num18;
			}
			string text7 = introDialogue_;
			if (text7.m_stringLength != num2)
			{
				int num19 = CodedOutputStream.ComputeStringSize(text7);
				num19 += 2;
				num2 += num19;
			}
			RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = itemsToGive_;
			FieldCodec<AnyItemSelectorWithAmount> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
			int num20 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_itemsToGive_codec);
			RepeatedField<MissionStepData> repeatedField3 = steps_;
			FieldCodec<MissionStepData> repeated_steps_codec = _repeated_steps_codec;
			int num21 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_steps_codec);
			int num22 = nextStepID_;
			if (num22 != 0)
			{
				int num23 = CodedOutputStream.ComputeInt32Size(num22);
				num23 += 2;
				num2 += num23;
			}
			string text8 = completedStoryDescription_;
			if (text8.m_stringLength != num2)
			{
				int num24 = CodedOutputStream.ComputeStringSize(text8);
				num24 += 2;
				num2 += num24;
			}
			if (completedCase_ == CompletedOneofCase.Any)
			{
				if (completedCase_ != CompletedOneofCase.Any)
				{
				}
				object obj = completed_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num25 = default(int);
				num2 += num25;
			}
			if (completedCase_ == CompletedOneofCase.Choices)
			{
				if (completedCase_ != CompletedOneofCase.Choices)
				{
				}
				object obj2 = completed_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num26 = default(int);
				num2 += num26;
			}
			if (completedCase_ == CompletedOneofCase.NoOutro)
			{
				if (completedCase_ != CompletedOneofCase.NoOutro)
				{
				}
				object obj3 = completed_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num27 = default(int);
				num2 += num27;
			}
			if (rewardsCase_ == RewardsOneofCase.OverrideRewards)
			{
				if (rewardsCase_ == RewardsOneofCase.OverrideRewards)
				{
					object obj4 = rewards_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2 += 2;
				int num28 = default(int);
				num2 += num28;
			}
			LootTable lootTable = additionnalRewards_;
			if (lootTable != null)
			{
				int num29 = CodedOutputStream.ComputeMessageSize(lootTable);
				num29 += 2;
				num2 += num29;
			}
			MissionReward missionReward = rewardsXP_;
			if (missionReward != null)
			{
				int num30 = CodedOutputStream.ComputeMessageSize(missionReward);
				num30 += 2;
				num2 += num30;
			}
			RepeatedField<int> repeatedField4 = itemsToDeleteAfterMission_;
			FieldCodec<int> repeated_itemsToDeleteAfterMission_codec = _repeated_itemsToDeleteAfterMission_codec;
			int num31 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_itemsToDeleteAfterMission_codec);
			uint num32 = glotID_;
			num2 += num31;
			if (num32 != 0)
			{
				int num33 = CodedOutputStream.ComputeUInt32Size(num32);
				num33 += 2;
				num2 += num33;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num34 = unknownFields.CalculateSize();
				num2 += num34;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600410A")]
		[Cpp2IlInjected.Address(RVA = "0x1D429A0", Offset = "0x1D413A0", VA = "0x181D429A0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionItemData other)
		{
			//Discarded unreachable code: IL_03e0
			//IL_02f2: Expected I4, but got O
			//IL_032b: Expected I4, but got O
			//IL_0364: Expected I4, but got O
			//IL_03a7: Expected I4, but got O
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
			string text3 = other.prefabAddress_;
			if (text3.m_stringLength != 0)
			{
				PrefabAddress = text3;
			}
			int num2 = other.ownerCharacter_;
			if (num2 != 0)
			{
				ownerCharacter_ = num2;
			}
			Types.MissionStatus missionStatus = other.status_;
			if (missionStatus != 0)
			{
				status_ = missionStatus;
			}
			MissionType missionType = other.type_;
			if (missionType != 0)
			{
				type_ = missionType;
			}
			string text4 = other.updateVersion_;
			if (text4.m_stringLength != 0)
			{
				UpdateVersion = text4;
			}
			int num3 = other.questId_;
			if (num3 != 0)
			{
				questId_ = num3;
			}
			if ((long)other.availableConditions_ != 0)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				if (availableConditions_ == null)
				{
					ConditionsList conditionsList = (availableConditions_ = new ConditionsList());
					conditionsList2 = availableConditions_;
				}
				ConditionsList other2 = other.availableConditions_;
				conditionsList2.MergeFrom(other2);
			}
			if ((long)other.unlockConditions_ != 0)
			{
				ConditionsList conditionsList4 = default(ConditionsList);
				if (unlockConditions_ == null)
				{
					ConditionsList conditionsList3 = (unlockConditions_ = new ConditionsList());
					conditionsList4 = unlockConditions_;
				}
				ConditionsList other3 = other.unlockConditions_;
				conditionsList4.MergeFrom(other3);
			}
			RepeatedField<Types.AutoAcceptOption> repeatedField = autoAccept_;
			RepeatedField<Types.AutoAcceptOption> repeatedField2 = other.autoAccept_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			string text5 = other.availableDescription_;
			if (text5.m_stringLength != 0)
			{
				AvailableDescription = text5;
			}
			string text6 = other.startRequestButton_;
			if (text6.m_stringLength != 0)
			{
				StartRequestButton = text6;
			}
			string text7 = other.introDialogue_;
			if (text7.m_stringLength != 0)
			{
				IntroDialogue = text7;
			}
			RepeatedField<AnyItemSelectorWithAmount> repeatedField3 = itemsToGive_;
			RepeatedField<AnyItemSelectorWithAmount> repeatedField4 = other.itemsToGive_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			RepeatedField<MissionStepData> repeatedField5 = steps_;
			RepeatedField<MissionStepData> repeatedField6 = other.steps_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			int num4 = other.nextStepID_;
			if (num4 != 0)
			{
				nextStepID_ = num4;
			}
			string text8 = other.completedStoryDescription_;
			if (text8.m_stringLength != 0)
			{
				CompletedStoryDescription = text8;
			}
			if ((long)other.additionnalRewards_ != 0)
			{
				LootTable lootTable2 = default(LootTable);
				if (additionnalRewards_ == null)
				{
					LootTable lootTable = (additionnalRewards_ = new LootTable());
					lootTable2 = additionnalRewards_;
				}
				LootTable other4 = other.additionnalRewards_;
				lootTable2.MergeFrom(other4);
			}
			if ((long)other.rewardsXP_ != 0)
			{
				MissionReward missionReward2 = default(MissionReward);
				if (rewardsXP_ == null)
				{
					MissionReward missionReward = (rewardsXP_ = new MissionReward());
					missionReward2 = rewardsXP_;
				}
				MissionReward other5 = other.rewardsXP_;
				missionReward2.MergeFrom(other5);
			}
			RepeatedField<int> repeatedField7 = itemsToDeleteAfterMission_;
			RepeatedField<int> repeatedField8 = other.itemsToDeleteAfterMission_;
			((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
			uint num5 = other.glotID_;
			if (num5 != 0)
			{
				glotID_ = num5;
			}
			CompletedOneofCase completedOneofCase = other.completedCase_;
			if (num5 != 0)
			{
				if (num5 != 0)
				{
					if (completedOneofCase != (CompletedOneofCase)1)
					{
						goto IL_037d;
					}
					if (NoOutro == null)
					{
						completedCase_ = (CompletedOneofCase)(completed_ = new Empty());
					}
					Empty noOutro = NoOutro;
					Empty noOutro2 = other.NoOutro;
					noOutro.MergeFrom(noOutro2);
				}
				if (Choices == null)
				{
					completedCase_ = (CompletedOneofCase)(completed_ = new Types.CompletedDescriptionDialogueChoices());
				}
				Types.CompletedDescriptionDialogueChoices choices = Choices;
				Types.CompletedDescriptionDialogueChoices choices2 = other.Choices;
				choices.MergeFrom(choices2);
			}
			if (Any == null)
			{
				completedCase_ = (CompletedOneofCase)(completed_ = new Types.CompletedDescriptionDialogue());
			}
			Types.CompletedDescriptionDialogue any = Any;
			Types.CompletedDescriptionDialogue any2 = other.Any;
			any.MergeFrom(any2);
			goto IL_037d;
			IL_037d:
			if (other.rewardsCase_ == RewardsOneofCase.OverrideRewards)
			{
				if (OverrideRewards == null)
				{
					rewardsCase_ = (RewardsOneofCase)(rewards_ = new OverrideRewards());
				}
				OverrideRewards overrideRewards = OverrideRewards;
				OverrideRewards overrideRewards2 = other.OverrideRewards;
				overrideRewards.MergeFrom(overrideRewards2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600410B")]
		[Cpp2IlInjected.Address(RVA = "0x1D42030", Offset = "0x1D40A30", VA = "0x181D42030", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0100: Expected I4, but got O
			//IL_0159: Expected I4, but got O
			//IL_01fe: Expected I4, but got O
			//IL_025a: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num <= 250)
			{
				goto IL_02fa;
			}
			if ((int)num <= 410)
			{
				goto IL_0192;
			}
			if ((int)num <= 490)
			{
				goto IL_00ac;
			}
			if ((int)num > 504)
			{
				if (num == 506)
				{
					goto IL_0093;
				}
				if (num != 7992)
				{
					goto IL_04b0;
				}
				int num2 = (int)(glotID_ = (uint)input.ReadInt32());
			}
			if (num == 498)
			{
				MissionReward missionReward = rewardsXP_;
				if (missionReward == null)
				{
					MissionReward missionReward2 = (rewardsXP_ = new MissionReward());
				}
				input.ReadMessage(missionReward);
			}
			if (num == 504)
			{
				goto IL_0093;
			}
			goto IL_04b0;
			IL_00ac:
			if (num == 418)
			{
				Empty builder = new Empty();
				if (completedCase_ == CompletedOneofCase.NoOutro)
				{
					if (completedCase_ != CompletedOneofCase.NoOutro)
					{
					}
					object obj = completed_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				completed_ = builder;
				completedCase_ = (CompletedOneofCase)typeof(Empty).TypeHandle;
			}
			if ((long)typeof(Empty).TypeHandle == 482)
			{
				OverrideRewards builder2 = new OverrideRewards();
				if (rewardsCase_ == RewardsOneofCase.OverrideRewards)
				{
					if (rewardsCase_ != RewardsOneofCase.OverrideRewards)
					{
					}
					object obj2 = rewards_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder2);
				rewards_ = builder2;
				rewardsCase_ = (RewardsOneofCase)typeof(OverrideRewards).TypeHandle;
			}
			if ((long)typeof(OverrideRewards).TypeHandle == 490)
			{
				LootTable builder3 = default(LootTable);
				if (additionnalRewards_ == null)
				{
					LootTable lootTable = (additionnalRewards_ = new LootTable());
					builder3 = additionnalRewards_;
				}
				input.ReadMessage(builder3);
				goto IL_0192;
			}
			goto IL_04b0;
			IL_0093:
			RepeatedField<int> repeatedField = itemsToDeleteAfterMission_;
			FieldCodec<int> repeated_itemsToDeleteAfterMission_codec = _repeated_itemsToDeleteAfterMission_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsToDeleteAfterMission_codec);
			goto IL_00ac;
			IL_02fa:
			ConditionsList conditionsList2 = default(ConditionsList);
			if ((int)num > 72)
			{
				ConditionsList conditionsList = default(ConditionsList);
				if ((int)num > 98)
				{
					string text4 = default(string);
					if ((int)num > 114)
					{
						string text2 = default(string);
						if (num == 242)
						{
							text2 = (AvailableDescription = input.ReadString());
						}
						if ((long)text2 != 250)
						{
							goto IL_04b0;
						}
						text4 = (StartRequestButton = input.ReadString());
					}
					if ((long)text4 == 106)
					{
						ConditionsList builder4 = default(ConditionsList);
						if (unlockConditions_ == null)
						{
							conditionsList = (unlockConditions_ = new ConditionsList());
							builder4 = unlockConditions_;
						}
						input.ReadMessage(builder4);
					}
					if ((long)conditionsList != 114)
					{
						goto IL_04b0;
					}
					RepeatedField<Types.AutoAcceptOption> repeatedField2 = autoAccept_;
					FieldCodec<Types.AutoAcceptOption> repeated_autoAccept_codec = _repeated_autoAccept_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_autoAccept_codec);
				}
				string text6 = default(string);
				if ((long)conditionsList == 82)
				{
					text6 = (UpdateVersion = input.ReadString());
				}
				int num3 = default(int);
				if ((long)text6 == 88)
				{
					num3 = (questId_ = input.ReadInt32());
				}
				if (num3 != 98)
				{
					goto IL_04b0;
				}
				ConditionsList builder5 = default(ConditionsList);
				if (availableConditions_ == null)
				{
					conditionsList2 = (availableConditions_ = new ConditionsList());
					builder5 = availableConditions_;
				}
				input.ReadMessage(builder5);
			}
			int num6 = default(int);
			if ((long)conditionsList2 > 26)
			{
				int num5 = default(int);
				if ((long)conditionsList2 > 56)
				{
					int num4 = default(int);
					if ((long)conditionsList2 == 64)
					{
						num4 = (int)(status_ = (Types.MissionStatus)input.ReadInt32());
					}
					if (num4 != 72)
					{
						goto IL_04b0;
					}
					num5 = (int)(type_ = (MissionType)input.ReadInt32());
				}
				string text8 = default(string);
				if (num5 == 42)
				{
					text8 = (PrefabAddress = input.ReadString());
				}
				if ((long)text8 != 56)
				{
					goto IL_04b0;
				}
				num6 = (ownerCharacter_ = input.ReadInt32());
			}
			int num7 = default(int);
			if (num6 == 8)
			{
				num7 = (iD_ = input.ReadInt32());
			}
			string text10 = default(string);
			if (num7 == 18)
			{
				text10 = (Name = input.ReadString());
			}
			if ((long)text10 == 26)
			{
				string text12 = (DisplayName = input.ReadString());
			}
			goto IL_04b0;
			IL_0192:
			string text14 = default(string);
			if ((int)num > 322)
			{
				if ((int)num > 338)
				{
					if (num == 402)
					{
						Types.CompletedDescriptionDialogue builder6 = new Types.CompletedDescriptionDialogue();
						if (completedCase_ == CompletedOneofCase.Any)
						{
							if (completedCase_ != CompletedOneofCase.Any)
							{
							}
							object obj3 = completed_;
							if (obj3 != null && obj3 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder6);
						completed_ = builder6;
						completedCase_ = (CompletedOneofCase)typeof(Types.CompletedDescriptionDialogue).TypeHandle;
					}
					if ((long)typeof(Types.CompletedDescriptionDialogue).TypeHandle != 410)
					{
						goto IL_04b0;
					}
					Types.CompletedDescriptionDialogueChoices builder7 = new Types.CompletedDescriptionDialogueChoices();
					if (completedCase_ == CompletedOneofCase.Choices)
					{
						if (completedCase_ != CompletedOneofCase.Choices)
						{
						}
						object obj4 = completed_;
						if (obj4 != null && obj4 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder7);
					completed_ = builder7;
					completedCase_ = (CompletedOneofCase)typeof(Types.CompletedDescriptionDialogueChoices).TypeHandle;
				}
				int num8 = default(int);
				if ((long)typeof(Types.CompletedDescriptionDialogueChoices).TypeHandle == 328)
				{
					num8 = (nextStepID_ = input.ReadInt32());
				}
				if (num8 != 338)
				{
					goto IL_04b0;
				}
				text14 = (CompletedStoryDescription = input.ReadString());
			}
			string text16 = default(string);
			if ((long)text14 == 258)
			{
				text16 = (IntroDialogue = input.ReadString());
			}
			if ((long)text16 == 266)
			{
				RepeatedField<AnyItemSelectorWithAmount> repeatedField3 = itemsToGive_;
				FieldCodec<AnyItemSelectorWithAmount> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
				((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsToGive_codec);
			}
			if ((long)text16 == 322)
			{
				RepeatedField<MissionStepData> repeatedField4 = steps_;
				FieldCodec<MissionStepData> repeated_steps_codec = _repeated_steps_codec;
				((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_steps_codec);
				goto IL_02fa;
			}
			goto IL_04b0;
			IL_04b0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600410C")]
		[Cpp2IlInjected.Address(RVA = "0x1D3FF00", Offset = "0x1D3E900", VA = "0x181D3FF00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 42)
			{
				if ((object)typeof(uint).TypeHandle != null)
				{
					if ((object)typeof(uint).TypeHandle != null)
					{
						if ((long)typeof(uint).TypeHandle != 1)
						{
							if ((object)typeof(uint).TypeHandle != null)
							{
								if ((object)typeof(uint).TypeHandle != null)
								{
									if ((object)typeof(uint).TypeHandle != null)
									{
										if ((long)typeof(uint).TypeHandle != 1)
										{
											if (fieldNumber != 999)
											{
												goto IL_00ae;
											}
											uint num = glotID_;
										}
										RepeatedField<int> repeatedField = itemsToDeleteAfterMission_;
									}
									MissionReward missionReward = rewardsXP_;
								}
								LootTable lootTable = additionnalRewards_;
							}
							OverrideRewards overrideRewards = OverrideRewards;
						}
						Empty noOutro = NoOutro;
					}
					Types.CompletedDescriptionDialogueChoices choices = Choices;
				}
				Types.CompletedDescriptionDialogue any = Any;
			}
			int num2 = fieldNumber - 1;
			if (num2 <= 13)
			{
				int num3 = iD_;
			}
			if (fieldNumber <= 12)
			{
				num2 = fieldNumber;
				string text = availableDescription_;
			}
			goto IL_00ae;
			IL_00ae:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600410D")]
		[Cpp2IlInjected.Address(RVA = "0x1D430B0", Offset = "0x1D41AB0", VA = "0x181D430B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0107, IL_010b, IL_0112, IL_0113, IL_0117, IL_011e, IL_011f, IL_0123, IL_012a, IL_012b, IL_012c, IL_012d, IL_012e, IL_0132, IL_0139, IL_013a, IL_013b, IL_013f, IL_0146, IL_014a, IL_016c, IL_0170, IL_0177, IL_0178, IL_017c, IL_0183, IL_0184, IL_0185, IL_0189, IL_018d, IL_018e, IL_01c4, IL_01ca, IL_01d0, IL_01d6, IL_01dc, IL_01e2
			//IL_005f: Expected I4, but got O
			//IL_0074: Expected O, but got I4
			//IL_009d: Expected I4, but got O
			//IL_00bb: Expected I4, but got O
			//IL_00d9: Expected I4, but got O
			//IL_00f7: Expected I4, but got O
			//IL_0106: Expected I4, but got O
			object obj = default(object);
			object obj2 = default(object);
			object obj3 = default(object);
			while (true)
			{
				if (fieldNumber > 42)
				{
					if ((object)typeof(uint).TypeHandle != null)
					{
						if ((object)typeof(uint).TypeHandle != null)
						{
							if ((long)typeof(uint).TypeHandle != 1)
							{
								if ((object)typeof(uint).TypeHandle != null)
								{
									if ((object)typeof(uint).TypeHandle != null)
									{
										if ((object)typeof(uint).TypeHandle != null)
										{
											if ((long)typeof(uint).TypeHandle != 1)
											{
												if (fieldNumber == 999)
												{
													glotID_ = (uint)(int)obj;
												}
												return;
											}
											InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
										}
										else
										{
											int num = 0;
											if (value == null || value != null)
											{
												rewardsXP_ = (MissionReward)num;
												return;
											}
										}
										throw new InvalidCastException();
									}
									if (value != null && value == null)
									{
										throw new InvalidCastException();
									}
								}
								if (value != null && value == null)
								{
									throw new InvalidCastException();
								}
								rewards_ = value;
								rewardsCase_ = (RewardsOneofCase)typeof(uint).TypeHandle;
							}
							else
							{
								if (value != null && value == null)
								{
									throw new InvalidCastException();
								}
								completed_ = value;
								completedCase_ = (CompletedOneofCase)typeof(uint).TypeHandle;
							}
						}
						else
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							completed_ = value;
							completedCase_ = (CompletedOneofCase)typeof(uint).TypeHandle;
						}
					}
					else
					{
						if (value != null && value == null)
						{
							break;
						}
						completed_ = value;
						completedCase_ = (CompletedOneofCase)typeof(uint).TypeHandle;
					}
					return;
				}
				if (fieldNumber - 1 <= 13)
				{
					iD_ = (int)obj2;
					return;
				}
				while ((long)value > 12)
				{
				}
				obj3 += (object)typeof(ConditionsList).TypeHandle;
				if (value == null || value != null)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600410E")]
		[Cpp2IlInjected.Address(RVA = "0x1D3CEA0", Offset = "0x1D3B8A0", VA = "0x181D3CEA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_00a6, IL_00b2, IL_00be, IL_00ca, IL_00d6, IL_00e2, IL_00ee, IL_00fa, IL_0106, IL_013a, IL_0146, IL_0152, IL_015e, IL_016a
			//IL_0062: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0087: Expected O, but got I4
			//IL_0111: Expected O, but got I4
			//IL_011c: Expected O, but got I4
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected I4, but got Unknown
			if (fieldNumber > 42)
			{
				if ("" != null && "" != null && (long)"" != 1)
				{
					if ("" != null)
					{
						if ("" != null)
						{
							if ("" != null && (long)"" != 1)
							{
								if (fieldNumber == 999)
								{
									int num = (int)(glotID_ = 0u);
								}
								return;
							}
							int num2 = 0;
							rewardsXP_ = (MissionReward)num2;
						}
						int num3 = 0;
						additionnalRewards_ = (LootTable)num3;
					}
					int num4 = 0;
					rewards_ = num4;
					rewardsCase_ = (RewardsOneofCase)num4;
				}
				else
				{
					int num5 = 0;
					completed_ = num5;
					completedCase_ = (CompletedOneofCase)num5;
				}
			}
			else if (fieldNumber - 1 <= 13)
			{
				int num6 = (iD_ = 0);
			}
			else
			{
				uint num7 = (uint)(int)(num7 + typeof(IList).TypeHandle);
				AvailableDescription = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600410F")]
		[Cpp2IlInjected.Address(RVA = "0x1D412C0", Offset = "0x1D3FCC0", VA = "0x181D412C0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null)
			{
				if (string.Equals(oneofName, "Completed"))
				{
					CompletedOneofCase completedOneofCase = completedCase_;
				}
				if (string.Equals(oneofName, "Rewards"))
				{
					RewardsOneofCase rewardsOneofCase = rewardsCase_;
				}
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004110")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D230", Offset = "0x1D3BC30", VA = "0x181D3D230", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0039: Expected O, but got I4
			if (oneofName != null)
			{
				if (string.Equals(oneofName, "Completed"))
				{
					int num = (int)(completedCase_ = CompletedOneofCase.None);
				}
				if (string.Equals(oneofName, "Rewards"))
				{
					rewards_ = (rewardsCase_ = RewardsOneofCase.None);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004116")]
		[Cpp2IlInjected.Address(RVA = "0x1D43CD0", Offset = "0x1D426D0", VA = "0x181D43CD0")]
		public bool TryGetOwnerCharacterHouseItem(out Item house)
		{
			//Discarded unreachable code: IL_001a
			//IL_0017: Expected I4, but got O
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
			}
			Item invalid = Item.Invalid;
			house.ItemID = (int)invalid;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600411B")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D2F0", Offset = "0x1D3BCF0", VA = "0x181D3D2F0", Slot = "22")]
		IItemData IItemData.Clone()
		{
			MissionItemData missionItemData = new MissionItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600411C")]
		[Cpp2IlInjected.Address(RVA = "0x1D414F0", Offset = "0x1D3FEF0", VA = "0x181D414F0")]
		public string GetUniqueStepName()
		{
			//Discarded unreachable code: IL_005d
			string text = default(string);
			string text2 = "Group" + text;
			RepeatedField<MissionStepData> repeatedField = steps_;
			int num = 0;
			int count = ((RepeatedField<T>)(object)repeatedField).Count;
			if (num < count)
			{
				if (string.Equals(((MissionStepData)((RepeatedField<T>)(object)steps_)[num]).stepName_, text2))
				{
					string text3 = default(string);
					string text4 = "Group" + text3;
				}
				RepeatedField<MissionStepData> repeatedField2 = steps_;
				num++;
			}
			return text2;
		}

		[Cpp2IlInjected.Token(Token = "0x600411D")]
		[Cpp2IlInjected.Address(RVA = "0x1D41640", Offset = "0x1D40040", VA = "0x181D41640")]
		public string GetUniqueSubStepName()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600411E")]
		[Cpp2IlInjected.Address(RVA = "0x1D413B0", Offset = "0x1D3FDB0", VA = "0x181D413B0")]
		public string GetUniqueObjectiveName(string prefix)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600411F")]
		[Cpp2IlInjected.Address(RVA = "0x1D410D0", Offset = "0x1D3FAD0", VA = "0x181D410D0")]
		public MissionObjectiveData GetObjectiveByIds(int stepID, int subStepID, int objectiveID)
		{
			RepeatedField<MissionStepData> repeatedField = steps_;
			Func<MissionStepData, bool> func = (Func<MissionStepData, bool>)(object)(Func<T, TResult>)delegate(MissionStepData x)
			{
				//Discarded unreachable code: IL_0011
				int num3 = stepID;
				return x.stepID_ == num3;
			};
			MissionStepData missionStepData = Enumerable.FirstOrDefault<MissionStepData>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			if (missionStepData != null)
			{
				RepeatedField<MissionSubStepData> subSteps_ = missionStepData.subSteps_;
				Func<MissionSubStepData, bool> func2 = (Func<MissionSubStepData, bool>)(object)(Func<T, TResult>)delegate(MissionSubStepData x)
				{
					//Discarded unreachable code: IL_0011
					int num2 = subStepID;
					return x.subStepID_ == num2;
				};
				MissionSubStepData missionSubStepData = Enumerable.FirstOrDefault<MissionSubStepData>((IEnumerable<>)(object)subSteps_, (Func<, >)(object)func2);
				if (missionSubStepData != null)
				{
					RepeatedField<MissionObjectiveData> objectives_ = missionSubStepData.objectives_;
					Func<MissionObjectiveData, bool> func3 = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
					{
						//Discarded unreachable code: IL_0011
						int num = objectiveID;
						return x.objectiveID_ == num;
					};
					return Enumerable.FirstOrDefault<MissionObjectiveData>((IEnumerable<>)(object)objectives_, (Func<, >)(object)func3);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004120")]
		[Cpp2IlInjected.Address(RVA = "0x1D41AB0", Offset = "0x1D404B0", VA = "0x181D41AB0")]
		public List<string> GetVariableList(MissionVariable.VariableOneofCase type, string stepName)
		{
			//Discarded unreachable code: IL_0043, IL_0049, IL_004f, IL_0055, IL_005b
			HashSet<string> hashSet = (HashSet<string>)(object)new HashSet<T>();
			bool flag = ((HashSet<T>)(object)hashSet).Add((T)"");
			List<string> list = default(List<string>);
			((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)list);
			RepeatedField<MissionStepData> repeatedField = steps_;
			bool flag2 = default(bool);
			if (flag2 && !flag2)
			{
				IEnumerable<MissionObjectiveData> enumerable = default(IEnumerable<MissionObjectiveData>);
				if (enumerable != null)
				{
					List<string> list2 = default(List<string>);
					((HashSet<T>)(object)hashSet).UnionWith((IEnumerable<>)list2);
				}
				if (enumerable == null)
				{
				}
			}
			return (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)hashSet);
		}

		[Cpp2IlInjected.Token(Token = "0x6004121")]
		[Cpp2IlInjected.Address(RVA = "0x1D40DB0", Offset = "0x1D3F7B0", VA = "0x181D40DB0")]
		private List<string> GetMissionVariables(MissionVariable.VariableOneofCase type)
		{
			//Discarded unreachable code: IL_0078, IL_007e, IL_0084, IL_008a, IL_0090, IL_0096, IL_009c
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			List<string> list = (List<string>)(object)new List<T>();
			if (type == MissionVariable.VariableOneofCase.ItemFilter)
			{
				RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
				bool flag = default(bool);
				if (flag)
				{
					if (num2 != 0 && num2 != 5)
					{
						string introDlgItemFilterVariableName = GetIntroDlgItemFilterVariableName(num3);
						((List<T>)(object)list).Add((T)introDlgItemFilterVariableName);
					}
					num3++;
				}
				num3++;
				if (num3 == 0)
				{
				}
			}
			if (type == MissionVariable.VariableOneofCase.TargetAmount)
			{
				RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = itemsToGive_;
				bool flag2 = default(bool);
				if (flag2)
				{
					if (num2 != 0 && num2 != 3)
					{
						string introDlgAmountVariableName = GetIntroDlgAmountVariableName(num3);
						((List<T>)(object)list).Add((T)introDlgAmountVariableName);
					}
					num3++;
				}
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6004122")]
		[Cpp2IlInjected.Address(RVA = "0x1D40870", Offset = "0x1D3F270", VA = "0x181D40870")]
		public string GetIntroDlgItemFilterVariableName(int idx)
		{
			//Discarded unreachable code: IL_004a
			AnyItemSelectorWithAmount anyItemSelectorWithAmount = (AnyItemSelectorWithAmount)((RepeatedField<T>)(object)itemsToGive_)[idx];
			ItemSelector itemToGive_ = anyItemSelectorWithAmount.itemToGive_.itemToGive_;
			if (itemToGive_.useCustomVariableName_)
			{
				string variableName_ = itemToGive_.variableName_;
				if (anyItemSelectorWithAmount == null)
				{
					return anyItemSelectorWithAmount.itemToGive_.itemToGive_.variableName_;
				}
			}
			return $"IntroDlg.ItemFilter[{anyItemSelectorWithAmount}]";
		}

		[Cpp2IlInjected.Token(Token = "0x6004123")]
		[Cpp2IlInjected.Address(RVA = "0x1D40790", Offset = "0x1D3F190", VA = "0x181D40790")]
		public string GetIntroDlgAmountVariableName(int idx)
		{
			//Discarded unreachable code: IL_0044
			AnyItemSelectorWithAmount anyItemSelectorWithAmount = (AnyItemSelectorWithAmount)((RepeatedField<T>)(object)itemsToGive_)[idx];
			StepAmount itemToGiveAmount_ = anyItemSelectorWithAmount.itemToGiveAmount_;
			if (itemToGiveAmount_ != null && itemToGiveAmount_.useCustomVariableName_)
			{
				string variableName_ = itemToGiveAmount_.variableName_;
				if (anyItemSelectorWithAmount == null)
				{
					return anyItemSelectorWithAmount.itemToGiveAmount_.variableName_;
				}
			}
			return $"IntroDlg.Amount[{anyItemSelectorWithAmount}]";
		}

		[Cpp2IlInjected.Token(Token = "0x6004124")]
		[Cpp2IlInjected.Address(RVA = "0x1D3CB50", Offset = "0x1D3B550", VA = "0x181D3CB50")]
		public bool CheckCharactersAvaibility(List<int> availableCharacters)
		{
			//Discarded unreachable code: IL_0065, IL_006b
			//IL_0045: Expected O, but got I4
			IEnumerable<MissionObjectiveData> allStepsObjectives;
			ICharactersAvaibility charactersAvaibility = default(ICharactersAvaibility);
			ITargetCharacterOverride targetCharacterOverride = default(ITargetCharacterOverride);
			bool flag2 = default(bool);
			Item item = default(Item);
			int num;
			while (true)
			{
				num = 0;
				allStepsObjectives = (IEnumerable<MissionObjectiveData>)this.get_AllStepsObjectives();
				if (allStepsObjectives == null)
				{
					break;
				}
				if (allStepsObjectives == null || charactersAvaibility != null)
				{
				}
				bool flag = num == 0;
				if (num == (flag ? 1 : 0))
				{
					while (num != 0)
					{
					}
					if (allStepsObjectives == null || targetCharacterOverride != null)
					{
					}
					while (num == 0)
					{
					}
					while (!flag2)
					{
					}
					int itemID = item.ItemID;
					if (((List<T>)(object)availableCharacters).Contains((T)itemID))
					{
						continue;
					}
					num++;
				}
				num++;
				break;
			}
			num++;
			if (allStepsObjectives != null)
			{
			}
			if (num != 0)
			{
				int num2 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004126")]
		[Cpp2IlInjected.Address(RVA = "0x1D41890", Offset = "0x1D40290", VA = "0x181D41890")]
		[IteratorStateMachine(typeof(_003CGetUnlockingCharactersByRewards_003Ed__201))]
		public IEnumerable<CharacterItemData> GetUnlockingCharactersByRewards()
		{
			new _003CGetUnlockingCharactersByRewards_003Ed__201(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004127")]
		[Cpp2IlInjected.Address(RVA = "0x1D41DC0", Offset = "0x1D407C0", VA = "0x181D41DC0")]
		public bool IsUnlockingCharacterByRewards(Item character)
		{
			//IL_0014: Expected O, but got I4
			int itemID = character.ItemID;
			Item character2 = (Item)itemID;
			LootTable lootTable = additionnalRewards_;
			if (lootTable != null)
			{
				RepeatedField<SubLootTable> subLootTables_ = lootTable.subLootTables_;
				if (subLootTables_ != null)
				{
					Predicate<ItemWithState> predicate = default(Predicate<ItemWithState>);
					Predicate<SubLootTable> predicate2 = (Predicate<SubLootTable>)(object)(Predicate<T>)delegate(SubLootTable x)
					{
						if (x == null)
						{
							int num2 = 0;
							/*Error: Unexpected end of block*/;
						}
						RepeatedField<ItemWithState> items_ = x.items_;
						if (items_ != null)
						{
							Predicate<ItemWithState> predicate3 = predicate;
							if (predicate3 == null)
							{
								predicate = (Predicate<ItemWithState>)(object)(Predicate<T>)delegate(ItemWithState y)
								{
									Item item = y.Item;
									throw new NullReferenceException();
								};
							}
							bool flag2 = ((RepeatedField<>)(object)items_).Any<ItemWithState>((Predicate<>)(object)predicate3);
							int num3 = 0;
						}
						return 0 == 1;
					};
					bool flag = ((RepeatedField<>)(object)subLootTables_).Any<SubLootTable>((Predicate<>)(object)predicate2);
					int num = 0;
				}
				return 0 == 1;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004128")]
		[Cpp2IlInjected.Address(RVA = "0x1D40C00", Offset = "0x1D3F600", VA = "0x181D40C00")]
		public IEnumerable<CharacterItemData> GetLockedInVillageCharacters()
		{
			IEnumerable<MissionObjectiveData> allStepsObjectives = (IEnumerable<MissionObjectiveData>)this.get_AllStepsObjectives();
			Func<MissionObjectiveData, bool> _003C_003E9__203_ = _003C_003Ec._003C_003E9__203_0;
			if (_003C_003E9__203_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
				{
					//Discarded unreachable code: IL_0018
					if (x.UnlockCharacter == null)
					{
					}
					return x.UnlockCharacter.nextState_ == CustomStepUnlockCharacter.Types.UnlockType.LockedInVillage;
				};
			}
			IEnumerable<MissionObjectiveData> enumerable = (IEnumerable<MissionObjectiveData>)Enumerable.Where<MissionObjectiveData>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)_003C_003E9__203_);
			Func<MissionObjectiveData, CharacterItemData> func = (Func<MissionObjectiveData, CharacterItemData>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
			{
				//Discarded unreachable code: IL_0015
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item targetCharacter = x.UnlockCharacter.GetTargetCharacter(this);
				CharacterItemData result = default(CharacterItemData);
				return result;
			};
			return (IEnumerable<CharacterItemData>)Enumerable.Select<MissionObjectiveData, CharacterItemData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6004129")]
		[Cpp2IlInjected.Address(RVA = "0x1D41900", Offset = "0x1D40300", VA = "0x181D41900")]
		public IEnumerable<CharacterItemData> GetUnlockingCharacters()
		{
			IEnumerable<MissionObjectiveData> allStepsObjectives = (IEnumerable<MissionObjectiveData>)this.get_AllStepsObjectives();
			Func<MissionObjectiveData, bool> _003C_003E9__204_ = _003C_003Ec._003C_003E9__204_0;
			if (_003C_003E9__204_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
				{
					//Discarded unreachable code: IL_0018
					if (x.UnlockCharacter == null)
					{
					}
					return x.UnlockCharacter.nextState_ == CustomStepUnlockCharacter.Types.UnlockType.Unlocked;
				};
			}
			IEnumerable<MissionObjectiveData> enumerable = (IEnumerable<MissionObjectiveData>)Enumerable.Where<MissionObjectiveData>((IEnumerable<>)allStepsObjectives, (Func<, >)(object)_003C_003E9__204_);
			Func<MissionObjectiveData, CharacterItemData> func = (Func<MissionObjectiveData, CharacterItemData>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
			{
				//Discarded unreachable code: IL_0015
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item targetCharacter = x.UnlockCharacter.GetTargetCharacter(this);
				CharacterItemData result = default(CharacterItemData);
				return result;
			};
			return (IEnumerable<CharacterItemData>)Enumerable.Select<MissionObjectiveData, CharacterItemData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600412A")]
		[Cpp2IlInjected.Address(RVA = "0x1D41F40", Offset = "0x1D40940", VA = "0x181D41F40")]
		public bool IsUnlockingCharacter(Item character)
		{
			//Discarded unreachable code: IL_0037
			//IL_001b: Expected O, but got I4
			int itemID = character.ItemID;
			Item character2 = (Item)itemID;
			IEnumerable<MissionObjectiveData> allStepsObjectives = (IEnumerable<MissionObjectiveData>)this.get_AllStepsObjectives();
			Func<MissionObjectiveData, bool> cpp2il__autoParamName__idx_ = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
			{
				CustomStepUnlockCharacter unlockCharacter = x.UnlockCharacter;
				if (unlockCharacter != null)
				{
					Item characterItem = character2;
					MissionItemData missionData = this;
					if (unlockCharacter.IsTargetCharacter(missionData, characterItem))
					{
						return x.UnlockCharacter.nextState_ == CustomStepUnlockCharacter.Types.UnlockType.Unlocked;
					}
				}
				int num = 0;
				throw new NullReferenceException();
			};
			return ((IEnumerable<>)allStepsObjectives).Any<MissionObjectiveData>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x600412C")]
		[Cpp2IlInjected.Address(RVA = "0x1D43A20", Offset = "0x1D42420", VA = "0x181D43A20")]
		public unsafe static bool TryGetLastVillageMissionRewardsFor(Item characterItem, out List<Item> rewardItems, int maxRewards = 2)
		{
			//Discarded unreachable code: IL_004c
			//IL_0049: Expected O, but got Ref
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				List<Item> list = (List<Item>)(object)new List<T>();
			}
			Func<int, Item> _003C_003E9__208_ = _003C_003Ec._003C_003E9__208_0;
			if (_003C_003E9__208_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle);
			}
			IEnumerable<int> enumerable = default(IEnumerable<int>);
			List<Item> list2 = (List<Item>)(object)(((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref rewardItems))._items = (T[])(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__208_)));
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600412D")]
		[Cpp2IlInjected.Address(RVA = "0x1D40960", Offset = "0x1D3F360", VA = "0x181D40960")]
		public static MissionItemData GetLastVillageMissionFor(Item characterItem)
		{
			//Discarded unreachable code: IL_0040
			int itemID = characterItem.ItemID;
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IEnumerable<MissionItemData> enumerable = default(IEnumerable<MissionItemData>);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_002e;
					}
					num++;
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				while (num <= num)
				{
				}
				goto IL_002e;
			}
			goto IL_0036;
			IL_002e:
			num += 312;
			goto IL_0036;
			IL_0036:
			if (enumerable != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600412E")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D350", Offset = "0x1D3BD50", VA = "0x181D3D350", Slot = "27")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_007c: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			//IL_02d4: Expected O, but got I4
			Func<MissionObjectiveData, bool> cpp2il__autoParamName__idx_ = default(Func<MissionObjectiveData, bool>);
			IEnumerable<MissionObjectiveData> enumerable = default(IEnumerable<MissionObjectiveData>);
			IEnumerable<MissionObjectiveData> enumerable2 = default(IEnumerable<MissionObjectiveData>);
			MissionStepData missionStepData = default(MissionStepData);
			Func<MissionObjectiveData, bool> func = default(Func<MissionObjectiveData, bool>);
			IEnumerable<MissionObjectiveData> enumerable4 = default(IEnumerable<MissionObjectiveData>);
			IEnumerable<MissionObjectiveData> enumerable5 = default(IEnumerable<MissionObjectiveData>);
			bool flag2 = default(bool);
			Predicate<int> predicate3 = default(Predicate<int>);
			bool flag4 = default(bool);
			IEnumerable<MissionObjectiveData> enumerable6 = default(IEnumerable<MissionObjectiveData>);
			CustomStepPossess customStepPossess = default(CustomStepPossess);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				RepeatedField<MissionStepData> repeatedField = steps_;
				Func<MissionStepData, MissionChoice> _003C_003E9__210_ = _003C_003Ec._003C_003E9__210_0;
				if (_003C_003E9__210_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionStepData x) => x.choiceRequirement_);
				}
				List<MissionChoice> list = (List<MissionChoice>)(object)Enumerable.ToList<MissionChoice>(Enumerable.Distinct<MissionChoice>(Enumerable.Select<MissionStepData, MissionChoice>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__210_)));
				if (((RepeatedField<T>)(object)steps_).Count != 0)
				{
					int count = ((RepeatedField<T>)(object)steps_).Count;
					if (Enumerable.First<MissionChoice>((IEnumerable<>)list) == MissionChoice.Any)
					{
						goto IL_008e;
					}
					MissionChoice missionChoice = Enumerable.First<MissionChoice>((IEnumerable<>)list);
					string text = $"Using only '{missionChoice}' in all steps: Please use 'Any' instead OR use 2 differents choices";
				}
				context.AddInvalidMemberError("Please add some steps", "Steps");
				goto IL_008e;
				IL_02e3:
				if (_003C_003Ec._003C_003E9__210_13 == null)
				{
					cpp2il__autoParamName__idx_ = (Func<MissionObjectiveData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MissionObjectiveData x) => !x.Possess.includeStorage_));
				}
				if (((IEnumerable<>)enumerable).Any<MissionObjectiveData>((Func<, >)(object)cpp2il__autoParamName__idx_) && (Enumerable.Any<MissionObjectiveData>((IEnumerable<>)enumerable2) || Enumerable.Any<MissionObjectiveData>(missionStepData.GetCustomStepObjectives(MissionObjectiveData.CustomStepOneofCase.CookMeal))))
				{
					if (_003C_003Ec._003C_003E9__210_14 == null)
					{
						func = (Func<MissionObjectiveData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MissionObjectiveData x)
						{
							//Discarded unreachable code: IL_001c
							if (x.Possess.includeStorage_)
							{
								int num7 = 0;
							}
							return x.Possess.CanIncludeStorage();
						});
					}
					IEnumerable<MissionObjectiveData> enumerable3 = (IEnumerable<MissionObjectiveData>)Enumerable.Where<MissionObjectiveData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
					if (enumerable3 != null)
					{
					}
					if (enumerable3 == null)
					{
					}
				}
				if (Enumerable.Any<MissionObjectiveData>((IEnumerable<>)enumerable4))
				{
					bool flag = Enumerable.Any<MissionObjectiveData>((IEnumerable<>)enumerable5);
					if (flag && flag)
					{
						/*Error: Could not find block for branch target IL_0387*/;
					}
				}
				continue;
				IL_008e:
				int num4 = nextStepID_;
				int count2 = ((RepeatedField<T>)(object)steps_).Count;
				if (num4 < count2)
				{
					int count3 = ((RepeatedField<T>)(object)steps_).Count;
					string message = $"Something went wrong, cannot be lower than {count3}";
					context.AddInvalidMemberError(message, "NextStepID");
				}
				RepeatedField<MissionStepData> repeatedField2 = steps_;
				Predicate<MissionStepData> predicate = (Predicate<MissionStepData>)(object)(Predicate<T>)delegate(MissionStepData x)
				{
					//Discarded unreachable code: IL_0014
					int num6 = nextStepID_;
					return x.stepID_ >= num6;
				};
				if (((RepeatedField<>)(object)repeatedField2).Any<MissionStepData>((Predicate<>)(object)predicate))
				{
					context.AddInvalidMemberError("Something went wrong, ids must be lower than NextStepID", "StepID");
				}
				RepeatedField<MissionStepData> repeatedField3 = steps_;
				Predicate<MissionStepData> predicate2 = (Predicate<MissionStepData>)(object)(Predicate<T>)delegate(MissionStepData x)
				{
					//Discarded unreachable code: IL_002c
					RepeatedField<MissionStepData> repeatedField5 = steps_;
					Func<MissionStepData, bool> func2 = (Func<MissionStepData, bool>)(object)(Func<T, TResult>)delegate(MissionStepData y)
					{
						//Discarded unreachable code: IL_0016
						int stepID_ = x.stepID_;
						return y.stepID_ == stepID_;
					};
					return Enumerable.Count<MissionStepData>((IEnumerable<>)(object)repeatedField5, (Func<, >)(object)func2) > 1;
				};
				if (((RepeatedField<>)(object)repeatedField3).Any<MissionStepData>((Predicate<>)(object)predicate2))
				{
					context.AddInvalidMemberError("Something went wrong, ids are not unique", "StepID");
				}
				Types.AutoAcceptOption autoAcceptOption = Enumerable.LastOrDefault<Types.AutoAcceptOption>((IEnumerable<>)(object)autoAccept_);
				if (autoAcceptOption != null)
				{
					flag2 = !Enumerable.Any<ConditionOneOf>((IEnumerable<>)(object)autoAcceptOption.conditions_.conditions_);
					if (flag2)
					{
						string text2 = introDialogue_;
						if (!flag2)
						{
							context.AddInvalidMemberError("IntroDialogue must be empty (related to AutoAccept conditions)", "IntroDialogue");
						}
						string text3 = startRequestButton_;
						if (flag2)
						{
							goto IL_01a9;
						}
					}
				}
				string text4 = startRequestButton_;
				if (flag2)
				{
					context.AddInvalidMemberError("StartRequestButton is required (related to AutoAccept conditions)", "StartRequestButton");
				}
				goto IL_01a9;
				IL_01a9:
				if (rewardsCase_ != RewardsOneofCase.OverrideRewards)
				{
					goto IL_023d;
				}
				if (rewardsCase_ == RewardsOneofCase.OverrideRewards)
				{
					object obj = rewards_;
					if (obj != null && obj == null)
					{
						continue;
					}
					if (obj != null)
					{
						if (obj != null)
						{
						}
						bool flag3 = num == 1;
						if (num != (flag3 ? 1 : 0))
						{
							RepeatedField<int> repeatedField4 = OverrideRewards.rewards_;
							if (_003C_003Ec._003C_003E9__210_3 == null)
							{
								predicate3 = (Predicate<int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((int x) => (IntPtr)x == (IntPtr)"{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}"));
							}
							if (((RepeatedField<>)(object)repeatedField4).Any<int>((Predicate<>)(object)predicate3))
							{
								context.AddInvalidMemberError("Some OverrideRewards value have not been set", "OverrideRewards");
							}
							goto IL_023d;
						}
					}
				}
				goto IL_02de;
				IL_02de:
				if (!flag4)
				{
				}
				goto IL_02e3;
				IL_023d:
				_003CGetUnlockingCharactersByRewards_003Ed__201 _003CGetUnlockingCharactersByRewards_003Ed__ = new _003CGetUnlockingCharactersByRewards_003Ed__201(-2);
				_003CGetUnlockingCharactersByRewards_003Ed__._003C_003E4__this = this;
				if (Enumerable.Any<CharacterItemData>((IEnumerable<>)(object)_003CGetUnlockingCharactersByRewards_003Ed__))
				{
					context.AddInvalidMemberError("Please use UnlockCharacter step instead of give character has rewards.", "AdditionnalRewards");
				}
				int count4 = ((RepeatedField<T>)(object)steps_).Count;
				if (num >= count4)
				{
					continue;
				}
				MissionStepData missionStepData2 = (MissionStepData)((RepeatedField<T>)(object)steps_)[num];
				missionStepData = (MissionStepData)((RepeatedField<T>)(object)steps_)[1];
				if (Enumerable.Any<MissionObjectiveData>((IEnumerable<>)enumerable))
				{
					flag4 = Enumerable.Any<MissionObjectiveData>((IEnumerable<>)enumerable6);
					if (flag4)
					{
						if (flag4)
						{
							int num5 = 0;
							while (customStepPossess.autoConfirm_)
							{
							}
							string error = "[Completion Mode]: By design " + (string)num5 + " should be Permanant because it's followed by CraftItem";
							context.AddError(error);
						}
						goto IL_02de;
					}
				}
				goto IL_02e3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600412F")]
		[Cpp2IlInjected.Address(RVA = "0x1D45190", Offset = "0x1D43B90", VA = "0x181D45190")]
		static MissionItemData()
		{
			MessageParser<Types.AutoAcceptOption> parser = Types.AutoAcceptOption._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionItemData>)(object)FieldCodec.ForMessage<Types.AutoAcceptOption>(num, (MessageParser<>)(object)parser);
			MessageParser<AnyItemSelectorWithAmount> parser2 = AnyItemSelectorWithAmount._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<MissionItemData>)(object)FieldCodec.ForMessage<AnyItemSelectorWithAmount>(num2, (MessageParser<>)(object)parser2);
			MessageParser<MissionStepData> parser3 = MissionStepData._parser;
			uint num3 = default(uint);
			_parser = (MessageParser<MissionItemData>)(object)FieldCodec.ForMessage<MissionStepData>(num3, (MessageParser<>)(object)parser3);
			uint num4 = default(uint);
			_parser = (MessageParser<MissionItemData>)(object)FieldCodec.ForInt32(num4);
			/*Error: Unexpected end of block*/;
		}
	}
}
