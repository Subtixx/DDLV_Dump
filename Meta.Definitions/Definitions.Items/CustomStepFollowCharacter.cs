using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200043B")]
	public sealed class CustomStepFollowCharacter : IMessage<CustomStepFollowCharacter>, IMessage, IEquatable<CustomStepFollowCharacter>, IDeepCloneable<CustomStepFollowCharacter>, IMessageFieldAccessor, IMessageOneofAccessor, IStringTag, IItemSelectorsWithAmount, ICharacterDialog, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200043C")]
		public enum UntilOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001733")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001734")]
			TalkTo = 20,
			[Cpp2IlInjected.Token(Token = "0x4001735")]
			EndOfObjective = 21,
			[Cpp2IlInjected.Token(Token = "0x4001736")]
			EndOfStep = 22,
			[Cpp2IlInjected.Token(Token = "0x4001737")]
			EndOfMission = 23,
			[Cpp2IlInjected.Token(Token = "0x4001738")]
			HasFollower = 24
		}

		[Cpp2IlInjected.Token(Token = "0x200043D")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200043E")]
			public sealed class FollowTalkTo : IMessage<FollowTalkTo>, IMessage, IEquatable<FollowTalkTo>, IDeepCloneable<FollowTalkTo>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001739")]
				private static readonly MessageParser<FollowTalkTo> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400173A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400173B")]
				public const int TalkToDialogFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400173C")]
				private string talkToDialog_;

				[Cpp2IlInjected.Token(Token = "0x400173D")]
				public const int TalkToDescriptionFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400173E")]
				private string talkToDescription_;

				[Cpp2IlInjected.Token(Token = "0x400173F")]
				public const int TalkToItemsToGiveFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4001740")]
				private static readonly FieldCodec<AnyItemSelectorWithAmount> _repeated_talkToItemsToGive_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001741")]
				private readonly RepeatedField<AnyItemSelectorWithAmount> talkToItemsToGive_;

				[Cpp2IlInjected.Token(Token = "0x17000D5D")]
				[DebuggerNonUserCode]
				public static MessageParser<FollowTalkTo> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003423")]
					[Cpp2IlInjected.Address(RVA = "0x293F2F0", Offset = "0x293DCF0", VA = "0x18293F2F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D5E")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003424")]
					[Cpp2IlInjected.Address(RVA = "0x293F270", Offset = "0x293DC70", VA = "0x18293F270")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D5F")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003425")]
					[Cpp2IlInjected.Address(RVA = "0x293F350", Offset = "0x293DD50", VA = "0x18293F350", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D60")]
				[DebuggerNonUserCode]
				public string TalkToDialog
				{
					[Cpp2IlInjected.Token(Token = "0x6003429")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600342A")]
					[Cpp2IlInjected.Address(RVA = "0x293F480", Offset = "0x293DE80", VA = "0x18293F480")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D61")]
				[DebuggerNonUserCode]
				public string TalkToDescription
				{
					[Cpp2IlInjected.Token(Token = "0x600342B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600342C")]
					[Cpp2IlInjected.Address(RVA = "0x293F410", Offset = "0x293DE10", VA = "0x18293F410")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D62")]
				[DebuggerNonUserCode]
				public RepeatedField<AnyItemSelectorWithAmount> TalkToItemsToGive
				{
					[Cpp2IlInjected.Token(Token = "0x600342D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003426")]
				[Cpp2IlInjected.Address(RVA = "0x293F060", Offset = "0x293DA60", VA = "0x18293F060")]
				[DebuggerNonUserCode]
				public FollowTalkTo()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003427")]
				[Cpp2IlInjected.Address(RVA = "0x293F110", Offset = "0x293DB10", VA = "0x18293F110")]
				[DebuggerNonUserCode]
				public FollowTalkTo(FollowTalkTo other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003428")]
				[Cpp2IlInjected.Address(RVA = "0x293E570", Offset = "0x293CF70", VA = "0x18293E570", Slot = "10")]
				[DebuggerNonUserCode]
				public FollowTalkTo Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600342E")]
				[Cpp2IlInjected.Address(RVA = "0x293E6F0", Offset = "0x293D0F0", VA = "0x18293E6F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600342F")]
				[Cpp2IlInjected.Address(RVA = "0x293E7F0", Offset = "0x293D1F0", VA = "0x18293E7F0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(FollowTalkTo other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003430")]
				[Cpp2IlInjected.Address(RVA = "0x293E950", Offset = "0x293D350", VA = "0x18293E950", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003431")]
				[Cpp2IlInjected.Address(RVA = "0x293ED00", Offset = "0x293D700", VA = "0x18293ED00", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003432")]
				[Cpp2IlInjected.Address(RVA = "0x293ED60", Offset = "0x293D760", VA = "0x18293ED60", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003433")]
				[Cpp2IlInjected.Address(RVA = "0x293E380", Offset = "0x293CD80", VA = "0x18293E380", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003434")]
				[Cpp2IlInjected.Address(RVA = "0x293EB30", Offset = "0x293D530", VA = "0x18293EB30", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(FollowTalkTo other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003435")]
				[Cpp2IlInjected.Address(RVA = "0x293EA00", Offset = "0x293D400", VA = "0x18293EA00", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003436")]
				[Cpp2IlInjected.Address(RVA = "0x293E8B0", Offset = "0x293D2B0", VA = "0x18293E8B0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003437")]
				[Cpp2IlInjected.Address(RVA = "0x293EBE0", Offset = "0x293D5E0", VA = "0x18293EBE0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003438")]
				[Cpp2IlInjected.Address(RVA = "0x293E4C0", Offset = "0x293CEC0", VA = "0x18293E4C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001721")]
		private static readonly MessageParser<CustomStepFollowCharacter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001722")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001723")]
		public const int TargetLocationFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001724")]
		private LocationSource targetLocation_;

		[Cpp2IlInjected.Token(Token = "0x4001725")]
		public const int RunFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001726")]
		private bool run_;

		[Cpp2IlInjected.Token(Token = "0x4001727")]
		public const int TargetRadiusFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001728")]
		private float targetRadius_;

		[Cpp2IlInjected.Token(Token = "0x4001729")]
		public const int AvatarRadiusFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400172A")]
		private float avatarRadius_;

		[Cpp2IlInjected.Token(Token = "0x400172B")]
		public const int TalkToFieldNumber = 20;

		[Cpp2IlInjected.Token(Token = "0x400172C")]
		public const int EndOfObjectiveFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x400172D")]
		public const int EndOfStepFieldNumber = 22;

		[Cpp2IlInjected.Token(Token = "0x400172E")]
		public const int EndOfMissionFieldNumber = 23;

		[Cpp2IlInjected.Token(Token = "0x400172F")]
		public const int HasFollowerFieldNumber = 24;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001730")]
		private object until_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001731")]
		private UntilOneofCase untilCase_;

		[Cpp2IlInjected.Token(Token = "0x17000D4B")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepFollowCharacter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60033F2")]
			[Cpp2IlInjected.Address(RVA = "0x34E77B0", Offset = "0x34E61B0", VA = "0x1834E77B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D4C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60033F3")]
			[Cpp2IlInjected.Address(RVA = "0x34E7560", Offset = "0x34E5F60", VA = "0x1834E7560")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D4D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60033F4")]
			[Cpp2IlInjected.Address(RVA = "0x34E7990", Offset = "0x34E6390", VA = "0x1834E7990", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D4E")]
		[DebuggerNonUserCode]
		public LocationSource TargetLocation
		{
			[Cpp2IlInjected.Token(Token = "0x60033F9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetLocation_;
			}
			[Cpp2IlInjected.Token(Token = "0x60033FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetLocation_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D4F")]
		[DebuggerNonUserCode]
		public bool Run
		{
			[Cpp2IlInjected.Token(Token = "0x60033FB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return run_;
			}
			[Cpp2IlInjected.Token(Token = "0x60033FC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				run_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D50")]
		[DebuggerNonUserCode]
		public float TargetRadius
		{
			[Cpp2IlInjected.Token(Token = "0x60033FD")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF70", Offset = "0xA7C970", VA = "0x180A7DF70")]
			get
			{
				return targetRadius_;
			}
			[Cpp2IlInjected.Token(Token = "0x60033FE")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF90", Offset = "0xA7C990", VA = "0x180A7DF90")]
			set
			{
				targetRadius_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D51")]
		[DebuggerNonUserCode]
		public float AvatarRadius
		{
			[Cpp2IlInjected.Token(Token = "0x60033FF")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get
			{
				return avatarRadius_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003400")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
			set
			{
				avatarRadius_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D52")]
		[DebuggerNonUserCode]
		public Types.FollowTalkTo TalkTo
		{
			[Cpp2IlInjected.Token(Token = "0x6003401")]
			[Cpp2IlInjected.Address(RVA = "0x34E7930", Offset = "0x34E6330", VA = "0x1834E7930")]
			get
			{
				int num = 0;
				if (untilCase_ == UntilOneofCase.TalkTo)
				{
					object obj = until_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003402")]
			[Cpp2IlInjected.Address(RVA = "0x34E7BA0", Offset = "0x34E65A0", VA = "0x1834E7BA0")]
			set
			{
				until_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D53")]
		[DebuggerNonUserCode]
		public Empty EndOfObjective
		{
			[Cpp2IlInjected.Token(Token = "0x6003403")]
			[Cpp2IlInjected.Address(RVA = "0x34E7690", Offset = "0x34E6090", VA = "0x1834E7690")]
			get
			{
				int num = 0;
				if (untilCase_ == UntilOneofCase.EndOfObjective)
				{
					object obj = until_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003404")]
			[Cpp2IlInjected.Address(RVA = "0x34E7AE0", Offset = "0x34E64E0", VA = "0x1834E7AE0")]
			set
			{
				until_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D54")]
		[DebuggerNonUserCode]
		public Empty EndOfStep
		{
			[Cpp2IlInjected.Token(Token = "0x6003405")]
			[Cpp2IlInjected.Address(RVA = "0x34E76F0", Offset = "0x34E60F0", VA = "0x1834E76F0")]
			get
			{
				int num = 0;
				if (untilCase_ == UntilOneofCase.EndOfStep)
				{
					object obj = until_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003406")]
			[Cpp2IlInjected.Address(RVA = "0x34E7B20", Offset = "0x34E6520", VA = "0x1834E7B20")]
			set
			{
				until_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D55")]
		[DebuggerNonUserCode]
		public Empty EndOfMission
		{
			[Cpp2IlInjected.Token(Token = "0x6003407")]
			[Cpp2IlInjected.Address(RVA = "0x34E7630", Offset = "0x34E6030", VA = "0x1834E7630")]
			get
			{
				int num = 0;
				if (untilCase_ == UntilOneofCase.EndOfMission)
				{
					object obj = until_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003408")]
			[Cpp2IlInjected.Address(RVA = "0x34E7AA0", Offset = "0x34E64A0", VA = "0x1834E7AA0")]
			set
			{
				until_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D56")]
		[DebuggerNonUserCode]
		public Empty HasFollower
		{
			[Cpp2IlInjected.Token(Token = "0x6003409")]
			[Cpp2IlInjected.Address(RVA = "0x34E7750", Offset = "0x34E6150", VA = "0x1834E7750")]
			get
			{
				int num = 0;
				if (untilCase_ == UntilOneofCase.HasFollower)
				{
					object obj = until_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600340A")]
			[Cpp2IlInjected.Address(RVA = "0x34E7B60", Offset = "0x34E6560", VA = "0x1834E7B60")]
			set
			{
				until_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D57")]
		[DebuggerNonUserCode]
		public UntilOneofCase UntilCase
		{
			[Cpp2IlInjected.Token(Token = "0x600340B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return untilCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D58")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x600341A")]
			[Cpp2IlInjected.Address(RVA = "0x34E7810", Offset = "0x34E6210", VA = "0x1834E7810", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0041
				string[] array;
				while (true)
				{
					array = new string[2];
					if ("CharacterName" == null || "CharacterName" != null)
					{
						array[0] = "CharacterName";
						if ("Location" == null || "Location" != null)
						{
							break;
						}
					}
				}
				array[1] = "Location";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D59")]
		public bool AutoConfirm
		{
			[Cpp2IlInjected.Token(Token = "0x600341B")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D5A")]
		string ICharacterDialog.GetCharacterDialog
		{
			[Cpp2IlInjected.Token(Token = "0x600341C")]
			[Cpp2IlInjected.Address(RVA = "0x34E5620", Offset = "0x34E4020", VA = "0x1834E5620", Slot = "18")]
			get
			{
				if (untilCase_ == UntilOneofCase.TalkTo)
				{
					object obj = until_;
					int num = 0;
					if (obj != null && obj == null)
					{
						goto IL_0021;
					}
					if (num == 0)
					{
					}
				}
				int num2 = 0;
				goto IL_0021;
				IL_0021:
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D5B")]
		bool ICharacterDialog.CompleteObjectiveAfterDialogue
		{
			[Cpp2IlInjected.Token(Token = "0x600341D")]
			[Cpp2IlInjected.Address(RVA = "0x34E55C0", Offset = "0x34E3FC0", VA = "0x1834E55C0", Slot = "19")]
			get
			{
				int num = 0;
				if (untilCase_ == UntilOneofCase.TalkTo)
				{
					object obj = until_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				return num != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D5C")]
		IEnumerable<AnyItemSelectorWithAmount> IItemSelectorsWithAmount.ItemSelectorsWithAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600341F")]
			[Cpp2IlInjected.Address(RVA = "0x34E5690", Offset = "0x34E4090", VA = "0x1834E5690", Slot = "17")]
			get
			{
				if (untilCase_ == UntilOneofCase.TalkTo)
				{
					object obj = until_;
					int num = 0;
					if ((obj == null || obj != null) && num != 0 && num != 0)
					{
					}
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033F5")]
		[Cpp2IlInjected.Address(RVA = "0x34E74B0", Offset = "0x34E5EB0", VA = "0x1834E74B0")]
		[DebuggerNonUserCode]
		public CustomStepFollowCharacter()
		{
			//IL_003d: Expected I4, but got O
			LocationSource locationSource = (targetLocation_ = new LocationSource());
			targetRadius_ = 1f;
			avatarRadius_ = 1f;
			untilCase_ = (UntilOneofCase)(until_ = new Empty());
		}

		[Cpp2IlInjected.Token(Token = "0x60033F6")]
		[Cpp2IlInjected.Address(RVA = "0x34E6930", Offset = "0x34E5330", VA = "0x1834E6930")]
		private void OnConstruction()
		{
			//IL_0037: Expected I4, but got O
			LocationSource locationSource = (targetLocation_ = new LocationSource());
			targetRadius_ = 1f;
			avatarRadius_ = 1f;
			untilCase_ = (UntilOneofCase)(until_ = new Empty());
		}

		[Cpp2IlInjected.Token(Token = "0x60033F7")]
		[Cpp2IlInjected.Address(RVA = "0x34E7220", Offset = "0x34E5C20", VA = "0x1834E7220")]
		[DebuggerNonUserCode]
		public CustomStepFollowCharacter(CustomStepFollowCharacter other)
		{
			//IL_003d: Expected I4, but got O
			//IL_005a: Expected O, but got I4
			//IL_0118: Expected I4, but got O
			LocationSource locationSource = (targetLocation_ = new LocationSource());
			targetRadius_ = 1f;
			avatarRadius_ = 1f;
			untilCase_ = (UntilOneofCase)(until_ = new Empty());
			LocationSource locationSource2 = other.targetLocation_;
			if (locationSource2 != null)
			{
				LocationSource locationSource3 = locationSource2.Clone();
			}
			int num = 0;
			targetLocation_ = (LocationSource)num;
			bool flag = (run_ = other.run_);
			float num2 = (targetRadius_ = other.targetRadius_);
			float num3 = (avatarRadius_ = other.avatarRadius_);
			UntilOneofCase untilOneofCase = other.untilCase_;
			if (locationSource2 != null)
			{
				if (locationSource2 != null)
				{
					if (locationSource2 != null)
					{
						if (locationSource2 != null)
						{
							if (untilOneofCase != (UntilOneofCase)1)
							{
								goto IL_0118;
							}
							Empty empty = (Empty)(until_ = other.HasFollower.Clone());
						}
						Empty empty2 = (Empty)(until_ = other.EndOfMission.Clone());
					}
					Empty empty3 = (Empty)(until_ = other.EndOfStep.Clone());
				}
				Empty empty4 = (Empty)(until_ = other.EndOfObjective.Clone());
			}
			untilCase_ = (UntilOneofCase)(until_ = other.TalkTo.Clone());
			goto IL_0118;
			IL_0118:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033F8")]
		[Cpp2IlInjected.Address(RVA = "0x34E5130", Offset = "0x34E3B30", VA = "0x1834E5130", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepFollowCharacter Clone()
		{
			return new CustomStepFollowCharacter(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600340C")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
		[DebuggerNonUserCode]
		public void ClearUntil()
		{
			//IL_0010: Expected O, but got I4
			until_ = (untilCase_ = UntilOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600340D")]
		[Cpp2IlInjected.Address(RVA = "0x34E59F0", Offset = "0x34E43F0", VA = "0x1834E59F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((CustomStepFollowCharacter)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600340E")]
		[Cpp2IlInjected.Address(RVA = "0x34E57B0", Offset = "0x34E41B0", VA = "0x1834E57B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepFollowCharacter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				LocationSource objB = other.targetLocation_;
				if (object.Equals(targetLocation_, objB))
				{
					bool flag = other.run_;
					if (run_ == flag)
					{
						Types.FollowTalkTo talkTo = TalkTo;
						Types.FollowTalkTo talkTo2 = other.TalkTo;
						if (object.Equals(talkTo, talkTo2))
						{
							Empty endOfObjective = EndOfObjective;
							Empty endOfObjective2 = other.EndOfObjective;
							if (object.Equals(endOfObjective, endOfObjective2))
							{
								Empty endOfStep = EndOfStep;
								Empty endOfStep2 = other.EndOfStep;
								if (object.Equals(endOfStep, endOfStep2))
								{
									Empty endOfMission = EndOfMission;
									Empty endOfMission2 = other.EndOfMission;
									if (object.Equals(endOfMission, endOfMission2))
									{
										Empty hasFollower = HasFollower;
										Empty hasFollower2 = other.HasFollower;
										if (object.Equals(hasFollower, hasFollower2))
										{
											UntilOneofCase untilOneofCase = other.untilCase_;
											if (untilCase_ == untilOneofCase)
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
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600340F")]
		[Cpp2IlInjected.Address(RVA = "0x34E5C00", Offset = "0x34E4600", VA = "0x1834E5C00", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0117
			//IL_0034: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			int num = default(int);
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = default(EqualityComparer<float>);
			while (true)
			{
				LocationSource locationSource = targetLocation_;
				if (locationSource != null)
				{
					int hashCode = locationSource.GetHashCode();
				}
				bool flag = run_;
				if (flag)
				{
					num = 0;
				}
				if (flag)
				{
					_003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
					int hashCode2 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField).GetHashCode((T)num);
				}
				if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField != null)
				{
					int hashCode3 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num);
				}
				UntilOneofCase untilOneofCase = untilCase_;
				int num2 = 0;
				if (untilOneofCase != UntilOneofCase.TalkTo)
				{
					continue;
				}
				object obj = until_;
				if (obj != null)
				{
					int hashCode4 = obj.GetHashCode();
					if (untilCase_ != UntilOneofCase.EndOfObjective)
					{
						continue;
					}
					object obj2 = until_;
					if (obj2 != null)
					{
						int hashCode5 = obj2.GetHashCode();
						if (untilCase_ != UntilOneofCase.EndOfStep)
						{
							continue;
						}
						object obj3 = until_;
						if (obj3 != null)
						{
							int hashCode6 = obj3.GetHashCode();
							if (untilCase_ != UntilOneofCase.EndOfMission)
							{
								continue;
							}
							object obj4 = until_;
							if (obj4 != null)
							{
								int hashCode7 = obj4.GetHashCode();
								if (untilCase_ == UntilOneofCase.HasFollower)
								{
									object obj5 = until_;
									if (obj5 == null)
									{
										break;
									}
									int hashCode8 = obj5.GetHashCode();
								}
								UnknownFieldSet unknownFields = _unknownFields;
								if (unknownFields != null)
								{
									int hashCode9 = unknownFields.GetHashCode();
								}
								return 1;
							}
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003410")]
		[Cpp2IlInjected.Address(RVA = "0x34E6D40", Offset = "0x34E5740", VA = "0x1834E6D40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003411")]
		[Cpp2IlInjected.Address(RVA = "0x34E6DA0", Offset = "0x34E57A0", VA = "0x1834E6DA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0141
			while (true)
			{
				if ((long)targetLocation_ != 0)
				{
					LocationSource value = targetLocation_;
					output.WriteMessage(value);
				}
				if (run_)
				{
					bool value2 = run_;
					output.WriteBool(value2);
				}
				if (output != null)
				{
					float value3 = targetRadius_;
					output.WriteFloat(value3);
				}
				if (output != null)
				{
					float value4 = avatarRadius_;
					output.WriteFloat(value4);
				}
				UntilOneofCase untilOneofCase = untilCase_;
				int num = 0;
				if (untilOneofCase != UntilOneofCase.TalkTo)
				{
					continue;
				}
				if (untilCase_ == UntilOneofCase.TalkTo)
				{
					object obj = until_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (untilCase_ != UntilOneofCase.EndOfObjective)
				{
					continue;
				}
				if (untilCase_ == UntilOneofCase.EndOfObjective)
				{
					object obj2 = until_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (untilCase_ != UntilOneofCase.EndOfStep)
				{
					continue;
				}
				if (untilCase_ == UntilOneofCase.EndOfStep)
				{
					object obj3 = until_;
					if (obj3 != null && obj3 == null)
					{
						break;
					}
				}
				if (untilCase_ != UntilOneofCase.EndOfMission)
				{
					continue;
				}
				if (untilCase_ == UntilOneofCase.EndOfMission)
				{
					object obj4 = until_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (untilCase_ == UntilOneofCase.HasFollower && untilCase_ == UntilOneofCase.HasFollower)
				{
					object obj5 = until_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003412")]
		[Cpp2IlInjected.Address(RVA = "0x34E4CD0", Offset = "0x34E36D0", VA = "0x1834E4CD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			LocationSource locationSource = targetLocation_;
			int num = 0;
			if (locationSource != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(locationSource);
				num2++;
			}
			if ((run_ ? 1 : 0) != num)
			{
				num += 5;
			}
			if ((run_ ? 1 : 0) != num)
			{
				num += 5;
			}
			if (untilCase_ == UntilOneofCase.TalkTo)
			{
				if (untilCase_ != UntilOneofCase.TalkTo)
				{
				}
				object obj = until_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num3 = default(int);
				num += num3;
			}
			if (untilCase_ == UntilOneofCase.EndOfObjective)
			{
				if (untilCase_ != UntilOneofCase.EndOfObjective)
				{
				}
				object obj2 = until_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num4 = default(int);
				num += num4;
			}
			if (untilCase_ == UntilOneofCase.EndOfStep)
			{
				if (untilCase_ != UntilOneofCase.EndOfStep)
				{
				}
				object obj3 = until_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num5 = default(int);
				num += num5;
			}
			if (untilCase_ == UntilOneofCase.EndOfMission)
			{
				if (untilCase_ != UntilOneofCase.EndOfMission)
				{
				}
				object obj4 = until_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num6 = default(int);
				num += num6;
			}
			if (untilCase_ == UntilOneofCase.HasFollower)
			{
				if (untilCase_ == UntilOneofCase.HasFollower)
				{
					object obj5 = until_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				num += 2;
				int num7 = default(int);
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003413")]
		[Cpp2IlInjected.Address(RVA = "0x34E60E0", Offset = "0x34E4AE0", VA = "0x1834E60E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepFollowCharacter other)
		{
			//Discarded unreachable code: IL_01ba
			//IL_00b8: Expected I4, but got O
			//IL_00f1: Expected I4, but got O
			//IL_0121: Expected I4, but got O
			//IL_0151: Expected I4, but got O
			//IL_0181: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			if ((long)other.targetLocation_ != 0)
			{
				LocationSource locationSource = targetLocation_;
				if (locationSource == null)
				{
					LocationSource locationSource2 = (targetLocation_ = new LocationSource());
				}
				LocationSource other2 = other.targetLocation_;
				locationSource.MergeFrom(other2);
			}
			bool flag = other.run_;
			if (flag)
			{
				run_ = flag;
			}
			float num = other.targetRadius_;
			if (flag)
			{
				targetRadius_ = num;
			}
			float num2 = other.avatarRadius_;
			if (flag)
			{
				avatarRadius_ = num2;
			}
			UntilOneofCase untilOneofCase = other.untilCase_;
			if (flag)
			{
				if (flag)
				{
					if (flag)
					{
						if (flag)
						{
							if (untilOneofCase != (UntilOneofCase)1)
							{
								goto IL_019a;
							}
							if (HasFollower == null)
							{
								untilCase_ = (UntilOneofCase)(until_ = new Empty());
							}
							Empty hasFollower = HasFollower;
							Empty hasFollower2 = other.HasFollower;
							hasFollower.MergeFrom(hasFollower2);
						}
						if (EndOfMission == null)
						{
							untilCase_ = (UntilOneofCase)(until_ = new Empty());
						}
						Empty endOfMission = EndOfMission;
						Empty endOfMission2 = other.EndOfMission;
					}
					if (EndOfStep == null)
					{
						untilCase_ = (UntilOneofCase)(until_ = new Empty());
					}
					Empty endOfStep = EndOfStep;
					Empty endOfStep2 = other.EndOfStep;
				}
				if (EndOfObjective == null)
				{
					untilCase_ = (UntilOneofCase)(until_ = new Empty());
				}
				Empty endOfObjective = EndOfObjective;
				Empty endOfObjective2 = other.EndOfObjective;
			}
			if (TalkTo == null)
			{
				untilCase_ = (UntilOneofCase)(until_ = new Types.FollowTalkTo());
			}
			Types.FollowTalkTo talkTo = TalkTo;
			Types.FollowTalkTo talkTo2 = other.TalkTo;
			talkTo.MergeFrom(talkTo2);
			goto IL_019a;
			IL_019a:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003414")]
		[Cpp2IlInjected.Address(RVA = "0x34E6420", Offset = "0x34E4E20", VA = "0x1834E6420", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_006e: Expected I4, but got O
			//IL_00bf: Expected I4, but got O
			//IL_011b: Expected I4, but got O
			//IL_016f: Expected I4, but got O
			//IL_01cb: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 37)
			{
				if ((int)num > 170)
				{
					if (num == 178)
					{
						Empty empty = new Empty();
						if (untilCase_ == UntilOneofCase.EndOfStep)
						{
							if (untilCase_ != UntilOneofCase.EndOfStep)
							{
							}
							object obj = until_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(empty);
						until_ = empty;
						untilCase_ = (UntilOneofCase)empty;
					}
					if (num == 186)
					{
						Empty builder = new Empty();
						if (untilCase_ == UntilOneofCase.EndOfMission)
						{
							if (untilCase_ != UntilOneofCase.EndOfMission)
							{
							}
							object obj2 = until_;
							if (obj2 != null && obj2 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder);
						until_ = builder;
						untilCase_ = (UntilOneofCase)typeof(Empty).TypeHandle;
					}
					if ((long)typeof(Empty).TypeHandle != 194)
					{
						goto IL_0243;
					}
					Empty builder2 = new Empty();
					if (untilCase_ == UntilOneofCase.HasFollower)
					{
						if (untilCase_ != UntilOneofCase.HasFollower)
						{
						}
						object obj3 = until_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					until_ = builder2;
					untilCase_ = (UntilOneofCase)typeof(Empty).TypeHandle;
				}
				if (num == 162)
				{
					Types.FollowTalkTo builder3 = new Types.FollowTalkTo();
					if (untilCase_ == UntilOneofCase.TalkTo)
					{
						if (untilCase_ != UntilOneofCase.TalkTo)
						{
						}
						object obj4 = until_;
						if (obj4 != null && obj4 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder3);
					until_ = builder3;
					untilCase_ = (UntilOneofCase)typeof(Types.FollowTalkTo).TypeHandle;
				}
				if ((long)typeof(Types.FollowTalkTo).TypeHandle != 170)
				{
					goto IL_0243;
				}
				Empty builder4 = new Empty();
				if (untilCase_ == UntilOneofCase.EndOfObjective)
				{
					if (untilCase_ != UntilOneofCase.EndOfObjective)
					{
					}
					object obj5 = until_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				until_ = builder4;
				untilCase_ = (UntilOneofCase)typeof(Empty).TypeHandle;
			}
			if ((int)num > 16)
			{
				if (num == 29)
				{
					float num2 = (targetRadius_ = input.ReadFloat());
				}
				if (num != 37)
				{
					goto IL_0243;
				}
				float num3 = (avatarRadius_ = input.ReadFloat());
			}
			LocationSource locationSource = default(LocationSource);
			if (num == 10)
			{
				LocationSource builder5 = default(LocationSource);
				if (targetLocation_ == null)
				{
					locationSource = (targetLocation_ = new LocationSource());
					builder5 = targetLocation_;
				}
				input.ReadMessage(builder5);
			}
			if ((long)locationSource == 16)
			{
				bool flag = (run_ = input.ReadBool());
			}
			goto IL_0243;
			IL_0243:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003415")]
		[Cpp2IlInjected.Address(RVA = "0x34E5A50", Offset = "0x34E4450", VA = "0x1834E5A50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0 && num != 1)
					{
						if ((object)typeof(float).TypeHandle != null)
						{
							if ((object)typeof(float).TypeHandle != null)
							{
								if ((object)typeof(float).TypeHandle != null)
								{
									if ((object)typeof(float).TypeHandle != null)
									{
										if ((long)typeof(float).TypeHandle != 1)
										{
											goto IL_0084;
										}
										Empty hasFollower = HasFollower;
									}
									Empty endOfMission = EndOfMission;
								}
								Empty endOfStep = EndOfStep;
							}
							Empty endOfObjective = EndOfObjective;
						}
						Types.FollowTalkTo talkTo = TalkTo;
					}
					float num2 = targetRadius_;
					return typeof(float).TypeHandle;
				}
				bool flag = run_;
			}
			LocationSource locationSource = targetLocation_;
			goto IL_0084;
			IL_0084:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003416")]
		[Cpp2IlInjected.Address(RVA = "0x34E69E0", Offset = "0x34E53E0", VA = "0x1834E69E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_004b: Expected O, but got I4
			//IL_0056: Expected I4, but got O
			//IL_0074: Expected I4, but got O
			//IL_0092: Expected I4, but got O
			//IL_00ad: Expected I4, but got O
			//IL_00c8: Expected I4, but got O
			//IL_00d0: Expected F4, but got O
			//IL_00d8: Expected F4, but got O
			//IL_00e1: Expected I4, but got O
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
						avatarRadius_ = (float)obj2;
						return;
					}
					case 0:
					{
						object obj = default(object);
						targetRadius_ = (float)obj;
						return;
					}
					}
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
										until_ = num2;
										untilCase_ = (UntilOneofCase)typeof(float).TypeHandle;
										break;
									}
									throw new InvalidCastException();
								}
								case 0:
									if (value == null || value != null)
									{
										until_ = value;
										untilCase_ = (UntilOneofCase)typeof(float).TypeHandle;
										break;
									}
									throw new InvalidCastException();
								}
							}
							else
							{
								if (value != null && value == null)
								{
									throw new InvalidCastException();
								}
								until_ = value;
								untilCase_ = (UntilOneofCase)typeof(float).TypeHandle;
							}
						}
						else
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							until_ = value;
							untilCase_ = (UntilOneofCase)typeof(float).TypeHandle;
						}
					}
					else
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						until_ = value;
						untilCase_ = (UntilOneofCase)typeof(float).TypeHandle;
					}
				}
				else
				{
					object obj3 = default(object);
					run_ = (byte)(int)obj3 != 0;
				}
				return;
			}
			if (value == null || value != null)
			{
				targetLocation_ = (LocationSource)value;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003417")]
		[Cpp2IlInjected.Address(RVA = "0x34E5010", Offset = "0x34E3A10", VA = "0x1834E5010", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0031: Expected O, but got I4
			//IL_0042: Expected F4, but got I4
			//IL_004c: Expected F4, but got I4
			//IL_0060: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num3 = 0;
						avatarRadius_ = num3;
						return;
					}
					case 0:
					{
						int num2 = 0;
						targetRadius_ = num2;
						return;
					}
					}
					if (num == 0 || num == 0 || num == 0 || num == 0 || num == 1)
					{
						int num4 = 0;
						until_ = num4;
						untilCase_ = (UntilOneofCase)num4;
					}
				}
				else
				{
					run_ = false;
				}
			}
			else
			{
				int num5 = 0;
				targetLocation_ = (LocationSource)num5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003418")]
		[Cpp2IlInjected.Address(RVA = "0x34E6030", Offset = "0x34E4A30", VA = "0x1834E6030", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Until"))
			{
				UntilOneofCase untilOneofCase = untilCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003419")]
		[Cpp2IlInjected.Address(RVA = "0x34E50C0", Offset = "0x34E3AC0", VA = "0x1834E50C0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Until"))
			{
				until_ = (untilCase_ = UntilOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600341E")]
		[Cpp2IlInjected.Address(RVA = "0x34E5540", Offset = "0x34E3F40", VA = "0x1834E5540", Slot = "20")]
		bool ICharacterDialog.CheckCharacterDialogStatus(MissionStepStatus status)
		{
			if (untilCase_ == UntilOneofCase.TalkTo)
			{
				object obj = until_;
				if (obj != null)
				{
					if (obj != null)
					{
						return status == MissionStepStatus.ReadyToBeCompleted;
					}
					goto IL_0022;
				}
			}
			int num = 0;
			goto IL_0022;
			IL_0022:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003420")]
		[Cpp2IlInjected.Address(RVA = "0x1457620", Offset = "0x1456020", VA = "0x181457620", Slot = "21")]
		void IProtobufDefaultData.SetDefaultData()
		{
			run_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003421")]
		[Cpp2IlInjected.Address(RVA = "0x34E5190", Offset = "0x34E3B90", VA = "0x1834E5190", Slot = "22")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_010e
			//IL_0090: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			bool flag = default(bool);
			UntilOneofCase untilOneofCase;
			do
			{
				context.AddInvalidMemberError("Minimum value of 0.25", "TargetRadius");
				context.AddInvalidMemberError("Minimum value of 1", "AvatarRadius");
				MissionItemData parentOfType = context.GetParentOfType<MissionItemData>();
				if (parentOfType != null)
				{
					int ownerCharacter = parentOfType.OwnerCharacter;
				}
				int itemID = Item.Invalid.ItemID;
				if (flag)
				{
					string missionStepName = context.MissionStepName;
					string error = $"[{missionStepName}] FollowCharacter step cannot be used with AQUATIC npc ({missionStepName})";
					context.AddError(error);
				}
				untilOneofCase = untilCase_;
				int num = 0;
			}
			while (untilOneofCase == UntilOneofCase.TalkTo || untilOneofCase == UntilOneofCase.EndOfObjective);
			string missionStepName2 = context.MissionStepName;
			UntilOneofCase untilOneofCase2 = default(UntilOneofCase);
			string error2 = $"[Until] {untilOneofCase} is not supported in {missionStepName2}, please select EndOfObjective or {untilOneofCase2}";
			context.AddError(error2);
			if (untilCase_ == UntilOneofCase.TalkTo)
			{
				object obj = until_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				if (obj != null)
				{
					string missionStepName3 = context.MissionStepName;
					string message = "Is required " + missionStepName3;
					context.AddInvalidMemberError(message, "TalkToDialog");
				}
				if (until_ == null)
				{
					throw new InvalidCastException();
				}
				if ((object)typeof(Types.FollowTalkTo).TypeHandle != null)
				{
					string missionStepName4 = context.MissionStepName;
					string message2 = "Is required " + missionStepName4;
					context.AddInvalidMemberError(message2, "TalkToDescription");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003422")]
		[Cpp2IlInjected.Address(RVA = "0x34E7110", Offset = "0x34E5B10", VA = "0x1834E7110")]
		static CustomStepFollowCharacter()
		{
			Func<CustomStepFollowCharacter> func = default(Func<CustomStepFollowCharacter>);
			_parser = (MessageParser<CustomStepFollowCharacter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
