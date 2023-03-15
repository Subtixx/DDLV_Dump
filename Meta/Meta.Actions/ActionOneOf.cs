using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000DF0")]
	public sealed class ActionOneOf : IMessage<ActionOneOf>, IMessage, IEquatable<ActionOneOf>, IDeepCloneable<ActionOneOf>, IMessageFieldAccessor, IMessageOneofAccessor, IAction, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000DF1")]
		public enum ActionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400387B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400387C")]
			DeleteAfterMissions = 40,
			[Cpp2IlInjected.Token(Token = "0x400387D")]
			FixTargetAmount = 60,
			[Cpp2IlInjected.Token(Token = "0x400387E")]
			GiveItem = 70,
			[Cpp2IlInjected.Token(Token = "0x400387F")]
			ItemDeleted = 90,
			[Cpp2IlInjected.Token(Token = "0x4003880")]
			MoveMissionObjective = 120,
			[Cpp2IlInjected.Token(Token = "0x4003881")]
			NewMissionStep = 130,
			[Cpp2IlInjected.Token(Token = "0x4003882")]
			RemoveFromCollectionMenu = 180,
			[Cpp2IlInjected.Token(Token = "0x4003883")]
			RemoveFromInventory = 181,
			[Cpp2IlInjected.Token(Token = "0x4003884")]
			RemoveFromGrid = 182,
			[Cpp2IlInjected.Token(Token = "0x4003885")]
			RemoveMissionStep = 183,
			[Cpp2IlInjected.Token(Token = "0x4003886")]
			SetDialogFlag = 190
		}

		[Cpp2IlInjected.Token(Token = "0x400386B")]
		private static readonly MessageParser<ActionOneOf> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400386C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400386D")]
		public const int DeleteAfterMissionsFieldNumber = 40;

		[Cpp2IlInjected.Token(Token = "0x400386E")]
		public const int FixTargetAmountFieldNumber = 60;

		[Cpp2IlInjected.Token(Token = "0x400386F")]
		public const int GiveItemFieldNumber = 70;

		[Cpp2IlInjected.Token(Token = "0x4003870")]
		public const int ItemDeletedFieldNumber = 90;

		[Cpp2IlInjected.Token(Token = "0x4003871")]
		public const int MoveMissionObjectiveFieldNumber = 120;

		[Cpp2IlInjected.Token(Token = "0x4003872")]
		public const int NewMissionStepFieldNumber = 130;

		[Cpp2IlInjected.Token(Token = "0x4003873")]
		public const int RemoveFromCollectionMenuFieldNumber = 180;

		[Cpp2IlInjected.Token(Token = "0x4003874")]
		public const int RemoveFromInventoryFieldNumber = 181;

		[Cpp2IlInjected.Token(Token = "0x4003875")]
		public const int RemoveFromGridFieldNumber = 182;

		[Cpp2IlInjected.Token(Token = "0x4003876")]
		public const int RemoveMissionStepFieldNumber = 183;

		[Cpp2IlInjected.Token(Token = "0x4003877")]
		public const int SetDialogFlagFieldNumber = 190;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003878")]
		private object actions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003879")]
		private ActionsOneofCase actionsCase_;

		[Cpp2IlInjected.Token(Token = "0x17001423")]
		[DebuggerNonUserCode]
		public static MessageParser<ActionOneOf> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007474")]
			[Cpp2IlInjected.Address(RVA = "0x1E37DB0", Offset = "0x1E367B0", VA = "0x181E37DB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001424")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007475")]
			[Cpp2IlInjected.Address(RVA = "0x1E37A10", Offset = "0x1E36410", VA = "0x181E37A10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001425")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007476")]
			[Cpp2IlInjected.Address(RVA = "0x1E37FF0", Offset = "0x1E369F0", VA = "0x181E37FF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001426")]
		[DebuggerNonUserCode]
		public ActionDeleteAfterMissions DeleteAfterMissions
		{
			[Cpp2IlInjected.Token(Token = "0x600747A")]
			[Cpp2IlInjected.Address(RVA = "0x1E379B0", Offset = "0x1E363B0", VA = "0x181E379B0")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.DeleteAfterMissions)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600747B")]
			[Cpp2IlInjected.Address(RVA = "0x1E38100", Offset = "0x1E36B00", VA = "0x181E38100")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001427")]
		[DebuggerNonUserCode]
		public ActionFixTargetAmount FixTargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600747C")]
			[Cpp2IlInjected.Address(RVA = "0x1E37AE0", Offset = "0x1E364E0", VA = "0x181E37AE0")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.FixTargetAmount)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600747D")]
			[Cpp2IlInjected.Address(RVA = "0x1E38140", Offset = "0x1E36B40", VA = "0x181E38140")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001428")]
		[DebuggerNonUserCode]
		public ActionGiveItem GiveItem
		{
			[Cpp2IlInjected.Token(Token = "0x600747E")]
			[Cpp2IlInjected.Address(RVA = "0x1E37B40", Offset = "0x1E36540", VA = "0x181E37B40")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.GiveItem)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600747F")]
			[Cpp2IlInjected.Address(RVA = "0x1E38180", Offset = "0x1E36B80", VA = "0x181E38180")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001429")]
		[DebuggerNonUserCode]
		public ActionItemDeleted ItemDeleted
		{
			[Cpp2IlInjected.Token(Token = "0x6007480")]
			[Cpp2IlInjected.Address(RVA = "0x1E37C90", Offset = "0x1E36690", VA = "0x181E37C90")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.ItemDeleted)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007481")]
			[Cpp2IlInjected.Address(RVA = "0x1E381C0", Offset = "0x1E36BC0", VA = "0x181E381C0")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142A")]
		[DebuggerNonUserCode]
		public ActionMoveMissionObjective MoveMissionObjective
		{
			[Cpp2IlInjected.Token(Token = "0x6007482")]
			[Cpp2IlInjected.Address(RVA = "0x1E37CF0", Offset = "0x1E366F0", VA = "0x181E37CF0")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.MoveMissionObjective)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007483")]
			[Cpp2IlInjected.Address(RVA = "0x1E38200", Offset = "0x1E36C00", VA = "0x181E38200")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142B")]
		[DebuggerNonUserCode]
		public ActionNewMissionStep NewMissionStep
		{
			[Cpp2IlInjected.Token(Token = "0x6007484")]
			[Cpp2IlInjected.Address(RVA = "0x1E37D50", Offset = "0x1E36750", VA = "0x181E37D50")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.NewMissionStep)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007485")]
			[Cpp2IlInjected.Address(RVA = "0x1E38240", Offset = "0x1E36C40", VA = "0x181E38240")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142C")]
		[DebuggerNonUserCode]
		public ActionRemoveFromCollectionMenu RemoveFromCollectionMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6007486")]
			[Cpp2IlInjected.Address(RVA = "0x1E37E10", Offset = "0x1E36810", VA = "0x181E37E10")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.RemoveFromCollectionMenu)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007487")]
			[Cpp2IlInjected.Address(RVA = "0x1E38280", Offset = "0x1E36C80", VA = "0x181E38280")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142D")]
		[DebuggerNonUserCode]
		public ActionRemoveFromInventory RemoveFromInventory
		{
			[Cpp2IlInjected.Token(Token = "0x6007488")]
			[Cpp2IlInjected.Address(RVA = "0x1E37ED0", Offset = "0x1E368D0", VA = "0x181E37ED0")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.RemoveFromInventory)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007489")]
			[Cpp2IlInjected.Address(RVA = "0x1E38300", Offset = "0x1E36D00", VA = "0x181E38300")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142E")]
		[DebuggerNonUserCode]
		public ActionRemoveFromGrid RemoveFromGrid
		{
			[Cpp2IlInjected.Token(Token = "0x600748A")]
			[Cpp2IlInjected.Address(RVA = "0x1E37E70", Offset = "0x1E36870", VA = "0x181E37E70")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.RemoveFromGrid)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600748B")]
			[Cpp2IlInjected.Address(RVA = "0x1E382C0", Offset = "0x1E36CC0", VA = "0x181E382C0")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700142F")]
		[DebuggerNonUserCode]
		public ActionRemoveMissionStep RemoveMissionStep
		{
			[Cpp2IlInjected.Token(Token = "0x600748C")]
			[Cpp2IlInjected.Address(RVA = "0x1E37F30", Offset = "0x1E36930", VA = "0x181E37F30")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.RemoveMissionStep)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600748D")]
			[Cpp2IlInjected.Address(RVA = "0x1E38340", Offset = "0x1E36D40", VA = "0x181E38340")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001430")]
		[DebuggerNonUserCode]
		public ActionSetDialogFlag SetDialogFlag
		{
			[Cpp2IlInjected.Token(Token = "0x600748E")]
			[Cpp2IlInjected.Address(RVA = "0x1E37F90", Offset = "0x1E36990", VA = "0x181E37F90")]
			get
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.SetDialogFlag)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600748F")]
			[Cpp2IlInjected.Address(RVA = "0x1E38380", Offset = "0x1E36D80", VA = "0x181E38380")]
			set
			{
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001431")]
		[DebuggerNonUserCode]
		public ActionsOneofCase ActionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6007490")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return actionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001432")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60074A0")]
			[Cpp2IlInjected.Address(RVA = "0x1E37BA0", Offset = "0x1E365A0", VA = "0x181E37BA0", Slot = "17")]
			get
			{
				if ((object)typeof(IAction).TypeHandle != null)
				{
					int num = 0;
					num += num;
					num++;
					if ((object)typeof(IAction).TypeHandle != null)
					{
					}
				}
				return "(None)";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007477")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActionOneOf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007478")]
		[Cpp2IlInjected.Address(RVA = "0x1E37340", Offset = "0x1E35D40", VA = "0x181E37340")]
		[DebuggerNonUserCode]
		public ActionOneOf(ActionOneOf other)
		{
			//IL_005a: Expected I4, but got O
			//IL_0074: Expected I4, but got O
			//IL_0091: Expected I4, but got O
			//IL_00ae: Expected I4, but got O
			//IL_00cb: Expected I4, but got O
			//IL_0183: Expected I4, but got I8
			//IL_01ff: Expected I4, but got I8
			//IL_0268: Expected I4, but got I8
			//IL_02ba: Expected I4, but got I8
			//IL_0320: Expected I4, but got I8
			//IL_03c6: Expected I4, but got I8
			int num = 0;
			base._002Ector();
			ActionsOneofCase actionsOneofCase = other.actionsCase_;
			if (actionsOneofCase > ActionsOneofCase.ItemDeleted)
			{
				if (actionsOneofCase > ActionsOneofCase.NewMissionStep)
				{
					if (num != 0)
					{
						if (num != 0)
						{
							if (num != 0)
							{
								if (num != 1)
								{
									if (actionsOneofCase != ActionsOneofCase.SetDialogFlag)
									{
										goto IL_03c6;
									}
									actionsCase_ = (ActionsOneofCase)(actions_ = other.SetDialogFlag.Clone());
								}
								actionsCase_ = (ActionsOneofCase)(actions_ = other.RemoveMissionStep.Clone());
							}
							actionsCase_ = (ActionsOneofCase)(actions_ = other.RemoveFromGrid.Clone());
						}
						actionsCase_ = (ActionsOneofCase)(actions_ = other.RemoveFromInventory.Clone());
					}
					actionsCase_ = (ActionsOneofCase)(actions_ = other.RemoveFromCollectionMenu.Clone());
				}
				if (actionsOneofCase == ActionsOneofCase.MoveMissionObjective)
				{
					ActionMoveMissionObjective moveMissionObjective = other.MoveMissionObjective;
					ActionMoveMissionObjective actionMoveMissionObjective = new ActionMoveMissionObjective
					{
						stepName_ = ""
					};
					int num2 = (actionMoveMissionObjective.missionID_ = moveMissionObjective.missionID_);
					string text = (actionMoveMissionObjective.stepName_ = moveMissionObjective.stepName_);
					int num3 = (actionMoveMissionObjective.fromIndex_ = moveMissionObjective.fromIndex_);
					int num4 = (actionMoveMissionObjective.toIndex_ = moveMissionObjective.toIndex_);
					int num5 = (actionMoveMissionObjective.prevAmount_ = moveMissionObjective.prevAmount_);
					int num6 = (actionMoveMissionObjective.targetedItemID_ = moveMissionObjective.targetedItemID_);
					UnknownFieldSet unknownFieldSet = (actionMoveMissionObjective._unknownFields = UnknownFieldSet.Clone(moveMissionObjective._unknownFields));
					actions_ = actionMoveMissionObjective;
					actionsCase_ = ActionsOneofCase.MoveMissionObjective;
				}
				if (actionsOneofCase != ActionsOneofCase.NewMissionStep)
				{
					goto IL_03c6;
				}
				ActionNewMissionStep newMissionStep = other.NewMissionStep;
				ActionNewMissionStep actionNewMissionStep = new ActionNewMissionStep();
				int num7 = (actionNewMissionStep.missionID_ = newMissionStep.missionID_);
				int num8 = (actionNewMissionStep.stepID_ = newMissionStep.stepID_);
				bool flag = (actionNewMissionStep.canOverrideActive_ = newMissionStep.canOverrideActive_);
				UnknownFieldSet unknownFieldSet2 = (actionNewMissionStep._unknownFields = UnknownFieldSet.Clone(newMissionStep._unknownFields));
				actions_ = actionNewMissionStep;
				actionsCase_ = ActionsOneofCase.NewMissionStep;
			}
			if (actionsOneofCase > ActionsOneofCase.FixTargetAmount)
			{
				if (actionsOneofCase == ActionsOneofCase.GiveItem)
				{
					ActionGiveItem giveItem = other.GiveItem;
					ActionGiveItem actionGiveItem = new ActionGiveItem();
					int num9 = (actionGiveItem.itemID_ = giveItem.itemID_);
					int num10 = (actionGiveItem.amount_ = giveItem.amount_);
					UnknownFieldSet unknownFieldSet3 = (actionGiveItem._unknownFields = UnknownFieldSet.Clone(giveItem._unknownFields));
					actions_ = actionGiveItem;
					actionsCase_ = ActionsOneofCase.GiveItem;
				}
				if (actionsOneofCase != ActionsOneofCase.ItemDeleted)
				{
					goto IL_03c6;
				}
				ActionItemDeleted itemDeleted = other.ItemDeleted;
				ActionItemDeleted actionItemDeleted = new ActionItemDeleted();
				int num11 = (actionItemDeleted.itemID_ = itemDeleted.itemID_);
				UnknownFieldSet unknownFieldSet4 = (actionItemDeleted._unknownFields = UnknownFieldSet.Clone(itemDeleted._unknownFields));
				actions_ = actionItemDeleted;
				actionsCase_ = ActionsOneofCase.ItemDeleted;
			}
			if (actionsOneofCase == ActionsOneofCase.DeleteAfterMissions)
			{
				ActionDeleteAfterMissions deleteAfterMissions = other.DeleteAfterMissions;
				ActionDeleteAfterMissions actionDeleteAfterMissions = new ActionDeleteAfterMissions();
				int num12 = (actionDeleteAfterMissions.missionID_ = deleteAfterMissions.missionID_);
				RepeatedField<int> repeatedField = (actionDeleteAfterMissions.itemIDs_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)deleteAfterMissions.itemIDs_).Clone());
				UnknownFieldSet unknownFieldSet5 = (actionDeleteAfterMissions._unknownFields = UnknownFieldSet.Clone(deleteAfterMissions._unknownFields));
				actions_ = actionDeleteAfterMissions;
				actionsCase_ = ActionsOneofCase.DeleteAfterMissions;
			}
			if (actionsOneofCase == ActionsOneofCase.FixTargetAmount)
			{
				ActionFixTargetAmount fixTargetAmount = other.FixTargetAmount;
				ActionFixTargetAmount actionFixTargetAmount = new ActionFixTargetAmount
				{
					stepName_ = ""
				};
				int num13 = (actionFixTargetAmount.missionID_ = fixTargetAmount.missionID_);
				string text2 = (actionFixTargetAmount.stepName_ = fixTargetAmount.stepName_);
				int num14 = (actionFixTargetAmount.amount_ = fixTargetAmount.amount_);
				int num15 = (actionFixTargetAmount.prevAmount_ = fixTargetAmount.prevAmount_);
				int num16 = (actionFixTargetAmount.targetedItemID_ = fixTargetAmount.targetedItemID_);
				UnknownFieldSet unknownFieldSet6 = (actionFixTargetAmount._unknownFields = UnknownFieldSet.Clone(fixTargetAmount._unknownFields));
				actions_ = actionFixTargetAmount;
				actionsCase_ = ActionsOneofCase.FixTargetAmount;
			}
			goto IL_03c6;
			IL_03c6:
			UnknownFieldSet unknownFieldSet7 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007479")]
		[Cpp2IlInjected.Address(RVA = "0x1E34AE0", Offset = "0x1E334E0", VA = "0x181E34AE0", Slot = "10")]
		[DebuggerNonUserCode]
		public ActionOneOf Clone()
		{
			return new ActionOneOf(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007491")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearActions()
		{
			//IL_0010: Expected O, but got I4
			actions_ = (actionsCase_ = ActionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007492")]
		[Cpp2IlInjected.Address(RVA = "0x1E34BA0", Offset = "0x1E335A0", VA = "0x181E34BA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ActionOneOf)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6007493")]
		[Cpp2IlInjected.Address(RVA = "0x1E34C00", Offset = "0x1E33600", VA = "0x181E34C00", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActionOneOf other)
		{
			//IL_0055: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (actionsCase_ == ActionsOneofCase.DeleteAfterMissions)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
						goto IL_01b2;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.actionsCase_ == ActionsOneofCase.DeleteAfterMissions)
				{
					obj2 = other.actions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					ActionFixTargetAmount fixTargetAmount = FixTargetAmount;
					ActionFixTargetAmount fixTargetAmount2 = other.FixTargetAmount;
					if (object.Equals(fixTargetAmount, fixTargetAmount2))
					{
						ActionGiveItem giveItem = GiveItem;
						ActionGiveItem giveItem2 = other.GiveItem;
						if (object.Equals(giveItem, giveItem2))
						{
							ActionItemDeleted itemDeleted = ItemDeleted;
							ActionItemDeleted itemDeleted2 = other.ItemDeleted;
							if (object.Equals(itemDeleted, itemDeleted2))
							{
								ActionMoveMissionObjective moveMissionObjective = MoveMissionObjective;
								ActionMoveMissionObjective moveMissionObjective2 = other.MoveMissionObjective;
								if (object.Equals(moveMissionObjective, moveMissionObjective2))
								{
									ActionNewMissionStep newMissionStep = NewMissionStep;
									ActionNewMissionStep newMissionStep2 = other.NewMissionStep;
									if (object.Equals(newMissionStep, newMissionStep2))
									{
										ActionRemoveFromCollectionMenu removeFromCollectionMenu = RemoveFromCollectionMenu;
										ActionRemoveFromCollectionMenu removeFromCollectionMenu2 = other.RemoveFromCollectionMenu;
										if (object.Equals(removeFromCollectionMenu, removeFromCollectionMenu2))
										{
											ActionRemoveFromInventory removeFromInventory = RemoveFromInventory;
											ActionRemoveFromInventory removeFromInventory2 = other.RemoveFromInventory;
											if (object.Equals(removeFromInventory, removeFromInventory2))
											{
												ActionRemoveFromGrid removeFromGrid = RemoveFromGrid;
												ActionRemoveFromGrid removeFromGrid2 = other.RemoveFromGrid;
												if (object.Equals(removeFromGrid, removeFromGrid2))
												{
													ActionRemoveMissionStep removeMissionStep = RemoveMissionStep;
													ActionRemoveMissionStep removeMissionStep2 = other.RemoveMissionStep;
													if (object.Equals(removeMissionStep, removeMissionStep2))
													{
														ActionSetDialogFlag setDialogFlag = SetDialogFlag;
														ActionSetDialogFlag setDialogFlag2 = other.SetDialogFlag;
														if (object.Equals(setDialogFlag, setDialogFlag2))
														{
															ActionsOneofCase actionsOneofCase = other.actionsCase_;
															if (actionsCase_ == actionsOneofCase)
															{
																UnknownFieldSet unknownFields = other._unknownFields;
																bool flag = object.Equals(_unknownFields, unknownFields);
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
			int num2 = 0;
			goto IL_01b2;
			IL_01b2:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007494")]
		[Cpp2IlInjected.Address(RVA = "0x1E35010", Offset = "0x1E33A10", VA = "0x181E35010", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_01b5
			while (true)
			{
				ActionsOneofCase actionsOneofCase = actionsCase_;
				int num = 0;
				if (actionsOneofCase == ActionsOneofCase.DeleteAfterMissions)
				{
					object obj = actions_;
					if (obj == null)
					{
						throw new InvalidCastException();
					}
					int hashCode = obj.GetHashCode();
				}
				if (actionsOneofCase != ActionsOneofCase.FixTargetAmount)
				{
					continue;
				}
				object obj2 = actions_;
				if (obj2 != null)
				{
					int hashCode2 = obj2.GetHashCode();
					if (actionsCase_ != ActionsOneofCase.GiveItem)
					{
						continue;
					}
					object obj3 = actions_;
					if (obj3 != null)
					{
						int hashCode3 = obj3.GetHashCode();
						if (actionsCase_ != ActionsOneofCase.ItemDeleted)
						{
							continue;
						}
						object obj4 = actions_;
						if (obj4 != null)
						{
							int hashCode4 = obj4.GetHashCode();
							if (actionsCase_ != ActionsOneofCase.MoveMissionObjective)
							{
								continue;
							}
							object obj5 = actions_;
							if (obj5 != null)
							{
								int hashCode5 = obj5.GetHashCode();
								if (actionsCase_ != ActionsOneofCase.NewMissionStep)
								{
									continue;
								}
								object obj6 = actions_;
								if (obj6 != null)
								{
									int hashCode6 = obj6.GetHashCode();
									if (actionsCase_ != ActionsOneofCase.RemoveFromCollectionMenu)
									{
										continue;
									}
									object obj7 = actions_;
									if (obj7 != null)
									{
										int hashCode7 = obj7.GetHashCode();
										if (actionsCase_ != ActionsOneofCase.RemoveFromInventory)
										{
											continue;
										}
										object obj8 = actions_;
										if (obj8 != null)
										{
											int hashCode8 = obj8.GetHashCode();
											if (actionsCase_ != ActionsOneofCase.RemoveFromGrid)
											{
												continue;
											}
											object obj9 = actions_;
											if (obj9 != null)
											{
												int hashCode9 = obj9.GetHashCode();
												if (actionsCase_ != ActionsOneofCase.RemoveMissionStep)
												{
													continue;
												}
												object obj10 = actions_;
												if (obj10 != null)
												{
													int hashCode10 = obj10.GetHashCode();
													if (actionsCase_ == ActionsOneofCase.SetDialogFlag)
													{
														object obj11 = actions_;
														if (obj11 == null)
														{
															break;
														}
														int hashCode11 = obj11.GetHashCode();
													}
													UnknownFieldSet unknownFields = _unknownFields;
													if (unknownFields != null)
													{
														int hashCode12 = unknownFields.GetHashCode();
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
							throw new InvalidCastException();
						}
						throw new InvalidCastException();
					}
					throw new InvalidCastException();
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007495")]
		[Cpp2IlInjected.Address(RVA = "0x1E36C40", Offset = "0x1E35640", VA = "0x181E36C40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007496")]
		[Cpp2IlInjected.Address(RVA = "0x1E36CA0", Offset = "0x1E356A0", VA = "0x181E36CA0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_020f
			//IL_0031: Expected O, but got I4
			while (true)
			{
				ActionsOneofCase actionsOneofCase = actionsCase_;
				int num = 0;
				if (actionsOneofCase == ActionsOneofCase.DeleteAfterMissions)
				{
					if (actionsCase_ == ActionsOneofCase.DeleteAfterMissions)
					{
						object obj = actions_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (actionsOneofCase != ActionsOneofCase.FixTargetAmount)
				{
					continue;
				}
				if (actionsCase_ == ActionsOneofCase.FixTargetAmount)
				{
					object obj2 = actions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionsCase_ != ActionsOneofCase.GiveItem)
				{
					continue;
				}
				if (actionsCase_ == ActionsOneofCase.GiveItem)
				{
					object obj3 = actions_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionsCase_ != ActionsOneofCase.ItemDeleted)
				{
					continue;
				}
				if (actionsCase_ == ActionsOneofCase.ItemDeleted)
				{
					object obj4 = actions_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionsCase_ != ActionsOneofCase.MoveMissionObjective)
				{
					continue;
				}
				if (actionsCase_ == ActionsOneofCase.MoveMissionObjective)
				{
					object obj5 = actions_;
					if (obj5 != null && obj5 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionsCase_ != ActionsOneofCase.NewMissionStep)
				{
					continue;
				}
				if (actionsCase_ == ActionsOneofCase.NewMissionStep)
				{
					object obj6 = actions_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionsCase_ != ActionsOneofCase.RemoveFromCollectionMenu)
				{
					continue;
				}
				if (actionsCase_ == ActionsOneofCase.RemoveFromCollectionMenu)
				{
					object obj7 = actions_;
					if (obj7 != null && obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionsCase_ != ActionsOneofCase.RemoveFromInventory)
				{
					continue;
				}
				if (actionsCase_ == ActionsOneofCase.RemoveFromInventory)
				{
					object obj8 = actions_;
					if (obj8 != null && obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionsCase_ != ActionsOneofCase.RemoveFromGrid)
				{
					continue;
				}
				if (actionsCase_ == ActionsOneofCase.RemoveFromGrid)
				{
					object obj9 = actions_;
					if (obj9 != null && obj9 == null)
					{
						break;
					}
				}
				if (actionsCase_ != ActionsOneofCase.RemoveMissionStep)
				{
					continue;
				}
				if (actionsCase_ == ActionsOneofCase.RemoveMissionStep)
				{
					object obj10 = actions_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionsCase_ == ActionsOneofCase.SetDialogFlag && actionsCase_ == ActionsOneofCase.SetDialogFlag)
				{
					object obj11 = actions_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007497")]
		[Cpp2IlInjected.Address(RVA = "0x1E343E0", Offset = "0x1E32DE0", VA = "0x181E343E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002e: Expected O, but got I4
			int num = 0;
			if (actionsCase_ == ActionsOneofCase.DeleteAfterMissions)
			{
				if (actionsCase_ == ActionsOneofCase.DeleteAfterMissions)
				{
					object obj = actions_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (actionsCase_ == ActionsOneofCase.FixTargetAmount)
			{
				if (actionsCase_ != ActionsOneofCase.FixTargetAmount)
				{
				}
				object obj2 = actions_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num3 = default(int);
				num += num3;
			}
			if (actionsCase_ == ActionsOneofCase.GiveItem)
			{
				if (actionsCase_ != ActionsOneofCase.GiveItem)
				{
				}
				object obj3 = actions_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num4 = default(int);
				num += num4;
			}
			if (actionsCase_ == ActionsOneofCase.ItemDeleted)
			{
				if (actionsCase_ != ActionsOneofCase.ItemDeleted)
				{
				}
				object obj4 = actions_;
				if (obj4 != null && obj4 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num5 = default(int);
				num += num5;
			}
			if (actionsCase_ == ActionsOneofCase.MoveMissionObjective)
			{
				if (actionsCase_ != ActionsOneofCase.MoveMissionObjective)
				{
				}
				object obj5 = actions_;
				if (obj5 != null && obj5 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num6 = default(int);
				num += num6;
			}
			if (actionsCase_ == ActionsOneofCase.NewMissionStep)
			{
				if (actionsCase_ != ActionsOneofCase.NewMissionStep)
				{
				}
				object obj6 = actions_;
				if (obj6 != null && obj6 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num7 = default(int);
				num += num7;
			}
			if (actionsCase_ == ActionsOneofCase.RemoveFromCollectionMenu)
			{
				if (actionsCase_ != ActionsOneofCase.RemoveFromCollectionMenu)
				{
				}
				object obj7 = actions_;
				if (obj7 != null && obj7 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num8 = default(int);
				num += num8;
			}
			if (actionsCase_ == ActionsOneofCase.RemoveFromInventory)
			{
				if (actionsCase_ != ActionsOneofCase.RemoveFromInventory)
				{
				}
				object obj8 = actions_;
				if (obj8 != null && obj8 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num9 = default(int);
				num += num9;
			}
			if (actionsCase_ == ActionsOneofCase.RemoveFromGrid)
			{
				if (actionsCase_ != ActionsOneofCase.RemoveFromGrid)
				{
				}
				object obj9 = actions_;
				if (obj9 != null && obj9 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num10 = default(int);
				num += num10;
			}
			if (actionsCase_ == ActionsOneofCase.RemoveMissionStep)
			{
				if (actionsCase_ != ActionsOneofCase.RemoveMissionStep)
				{
				}
				object obj10 = actions_;
				if (obj10 != null && obj10 == null)
				{
					throw new InvalidCastException();
				}
				num += 2;
				int num11 = default(int);
				num += num11;
			}
			if (actionsCase_ == ActionsOneofCase.SetDialogFlag)
			{
				if (actionsCase_ == ActionsOneofCase.SetDialogFlag)
				{
					object obj11 = actions_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				num += 2;
				int num12 = default(int);
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

		[Cpp2IlInjected.Token(Token = "0x6007498")]
		[Cpp2IlInjected.Address(RVA = "0x1E360C0", Offset = "0x1E34AC0", VA = "0x181E360C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActionOneOf other)
		{
			//IL_0064: Expected I4, but got O
			//IL_0099: Expected I4, but got O
			//IL_00d2: Expected I4, but got O
			//IL_010b: Expected I4, but got O
			//IL_0144: Expected I4, but got O
			//IL_0182: Expected I4, but got O
			//IL_01c6: Expected I4, but got O
			//IL_029b: Expected I4, but got O
			//IL_02fc: Expected I4, but got O
			//IL_0346: Expected I4, but got O
			//IL_037f: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			ActionsOneofCase actionsOneofCase = other.actionsCase_;
			if (actionsOneofCase > ActionsOneofCase.ItemDeleted)
			{
				if (actionsOneofCase > ActionsOneofCase.NewMissionStep)
				{
					if (other != null)
					{
						if (other != null)
						{
							if (other != null)
							{
								if ((long)other != 1)
								{
									if (actionsOneofCase != ActionsOneofCase.SetDialogFlag)
									{
										goto IL_0242;
									}
									if (SetDialogFlag == null)
									{
										actionsCase_ = (ActionsOneofCase)(actions_ = new ActionSetDialogFlag());
									}
									ActionSetDialogFlag setDialogFlag = SetDialogFlag;
									ActionSetDialogFlag setDialogFlag2 = other.SetDialogFlag;
									setDialogFlag.MergeFrom(setDialogFlag2);
								}
								if (RemoveMissionStep == null)
								{
									actionsCase_ = (ActionsOneofCase)(actions_ = new ActionRemoveMissionStep());
								}
								ActionRemoveMissionStep removeMissionStep = RemoveMissionStep;
								ActionRemoveMissionStep removeMissionStep2 = other.RemoveMissionStep;
								removeMissionStep.MergeFrom(removeMissionStep2);
							}
							if (RemoveFromGrid == null)
							{
								actionsCase_ = (ActionsOneofCase)(actions_ = new ActionRemoveFromGrid());
							}
							ActionRemoveFromGrid removeFromGrid = RemoveFromGrid;
							ActionRemoveFromGrid removeFromGrid2 = other.RemoveFromGrid;
							removeFromGrid.MergeFrom(removeFromGrid2);
						}
						if (RemoveFromInventory == null)
						{
							actionsCase_ = (ActionsOneofCase)(actions_ = new ActionRemoveFromInventory());
						}
						ActionRemoveFromInventory removeFromInventory = RemoveFromInventory;
						ActionRemoveFromInventory removeFromInventory2 = other.RemoveFromInventory;
						removeFromInventory.MergeFrom(removeFromInventory2);
					}
					if (RemoveFromCollectionMenu == null)
					{
						actionsCase_ = (ActionsOneofCase)(actions_ = new ActionRemoveFromCollectionMenu());
					}
					ActionRemoveFromCollectionMenu removeFromCollectionMenu = RemoveFromCollectionMenu;
					ActionRemoveFromCollectionMenu removeFromCollectionMenu2 = other.RemoveFromCollectionMenu;
					removeFromCollectionMenu.MergeFrom(removeFromCollectionMenu2);
				}
				if (actionsOneofCase == ActionsOneofCase.MoveMissionObjective)
				{
					if (MoveMissionObjective == null)
					{
						actionsCase_ = (ActionsOneofCase)(actions_ = new ActionMoveMissionObjective());
					}
					ActionMoveMissionObjective moveMissionObjective = MoveMissionObjective;
					ActionMoveMissionObjective moveMissionObjective2 = other.MoveMissionObjective;
					moveMissionObjective.MergeFrom(moveMissionObjective2);
				}
				if (actionsOneofCase == ActionsOneofCase.NewMissionStep)
				{
					if (NewMissionStep == null)
					{
						actionsCase_ = (ActionsOneofCase)(actions_ = new ActionNewMissionStep());
					}
					ActionNewMissionStep newMissionStep = NewMissionStep;
					ActionNewMissionStep newMissionStep2 = other.NewMissionStep;
					if (newMissionStep2 != null)
					{
						int missionID_ = newMissionStep2.missionID_;
						if (missionID_ != 0)
						{
							newMissionStep.missionID_ = missionID_;
						}
						int stepID_ = newMissionStep2.stepID_;
						if (stepID_ != 0)
						{
							newMissionStep.stepID_ = stepID_;
						}
						bool canOverrideActive_ = newMissionStep2.canOverrideActive_;
						if (canOverrideActive_)
						{
							newMissionStep.canOverrideActive_ = canOverrideActive_;
						}
						UnknownFieldSet unknownFields = newMissionStep2._unknownFields;
						UnknownFieldSet unknownFieldSet = (newMissionStep._unknownFields = UnknownFieldSet.MergeFrom(newMissionStep._unknownFields, unknownFields));
					}
				}
				goto IL_0242;
			}
			int itemID_2 = default(int);
			if ((long)typeof(ActionSetDialogFlag).TypeHandle > 60)
			{
				int amount_ = default(int);
				if ((long)typeof(ActionSetDialogFlag).TypeHandle == 70)
				{
					if (GiveItem == null)
					{
						actionsCase_ = (ActionsOneofCase)(actions_ = new ActionGiveItem());
					}
					ActionGiveItem giveItem = GiveItem;
					ActionGiveItem actionGiveItem = default(ActionGiveItem);
					while (actionGiveItem == null)
					{
					}
					int itemID_ = actionGiveItem.itemID_;
					if (itemID_ != 0)
					{
						giveItem.itemID_ = itemID_;
					}
					amount_ = actionGiveItem.amount_;
					while (amount_ == 0)
					{
					}
					giveItem.amount_ = amount_;
				}
				while (amount_ != 90)
				{
				}
				if (ItemDeleted == null)
				{
					actionsCase_ = (ActionsOneofCase)(actions_ = new ActionItemDeleted());
				}
				ActionItemDeleted itemDeleted = ItemDeleted;
				ActionItemDeleted actionItemDeleted = default(ActionItemDeleted);
				while (actionItemDeleted == null)
				{
				}
				itemID_2 = actionItemDeleted.itemID_;
				while (itemID_2 == 0)
				{
				}
				itemDeleted.itemID_ = itemID_2;
			}
			ActionDeleteAfterMissions deleteAfterMissions = default(ActionDeleteAfterMissions);
			if (itemID_2 == 40)
			{
				if (DeleteAfterMissions == null)
				{
					actionsCase_ = (ActionsOneofCase)(actions_ = new ActionDeleteAfterMissions());
				}
				deleteAfterMissions = DeleteAfterMissions;
				ActionDeleteAfterMissions other2 = default(ActionDeleteAfterMissions);
				deleteAfterMissions.MergeFrom(other2);
			}
			while ((long)deleteAfterMissions != 60)
			{
			}
			if (FixTargetAmount == null)
			{
				actionsCase_ = (ActionsOneofCase)(actions_ = new ActionFixTargetAmount());
			}
			ActionFixTargetAmount other3 = default(ActionFixTargetAmount);
			FixTargetAmount.MergeFrom(other3);
			throw new NullReferenceException();
			IL_0242:
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6007499")]
		[Cpp2IlInjected.Address(RVA = "0x1E356B0", Offset = "0x1E340B0", VA = "0x181E356B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0077: Expected I4, but got O
			//IL_00ce: Expected I4, but got O
			//IL_0130: Expected I4, but got O
			//IL_018e: Expected I4, but got O
			//IL_01a2: Expected I4, but got O
			//IL_01b6: Expected I4, but got O
			//IL_01e0: Expected I4, but got O
			//IL_023c: Expected I4, but got O
			//IL_029e: Expected I4, but got O
			//IL_02ff: Expected I4, but got O
			//IL_0313: Expected I4, but got O
			//IL_033d: Expected I4, but got O
			//IL_0394: Expected I4, but got O
			//IL_03be: Expected I4, but got O
			//IL_0417: Expected I4, but got O
			//IL_0470: Expected I4, but got O
			//IL_04c6: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 962)
			{
				if ((int)num > 1450)
				{
					if (num == 1458)
					{
						ActionRemoveFromGrid actionRemoveFromGrid = new ActionRemoveFromGrid();
						if (actionsCase_ == ActionsOneofCase.RemoveFromGrid)
						{
							if (actionsCase_ != ActionsOneofCase.RemoveFromGrid)
							{
							}
							object obj = actions_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(actionRemoveFromGrid);
						actions_ = actionRemoveFromGrid;
						actionsCase_ = (ActionsOneofCase)actionRemoveFromGrid;
					}
					if (num == 1466)
					{
						ActionRemoveMissionStep builder = new ActionRemoveMissionStep();
						if (actionsCase_ == ActionsOneofCase.RemoveMissionStep)
						{
							if (actionsCase_ != ActionsOneofCase.RemoveMissionStep)
							{
							}
							object obj2 = actions_;
							if (obj2 != null && obj2 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder);
						actions_ = builder;
						actionsCase_ = (ActionsOneofCase)typeof(ActionRemoveMissionStep).TypeHandle;
					}
					if ((long)typeof(ActionRemoveMissionStep).TypeHandle != 1522)
					{
						goto IL_04c6;
					}
					ActionSetDialogFlag builder2 = new ActionSetDialogFlag();
					if (actionsCase_ == ActionsOneofCase.SetDialogFlag)
					{
						if (actionsCase_ != ActionsOneofCase.SetDialogFlag)
						{
						}
						object obj3 = actions_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder2);
					actions_ = builder2;
					actionsCase_ = (ActionsOneofCase)typeof(ActionSetDialogFlag).TypeHandle;
				}
				UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
				if (num == 1042)
				{
					ActionNewMissionStep actionNewMissionStep = new ActionNewMissionStep();
					if (actionsCase_ == ActionsOneofCase.NewMissionStep)
					{
						if (actionsCase_ != ActionsOneofCase.NewMissionStep)
						{
						}
						object obj4 = actions_;
						if (obj4 != null && obj4 == null)
						{
							throw new InvalidCastException();
						}
						if (obj4 != null)
						{
							if ((object)typeof(ActionNewMissionStep).TypeHandle != null)
							{
								actionNewMissionStep.missionID_ = (int)typeof(ActionNewMissionStep).TypeHandle;
							}
							if ((object)typeof(ActionNewMissionStep).TypeHandle != null)
							{
								actionNewMissionStep.stepID_ = (int)typeof(ActionNewMissionStep).TypeHandle;
							}
							if ((object)typeof(ActionNewMissionStep).TypeHandle != null)
							{
								actionNewMissionStep.canOverrideActive_ = (byte)(int)typeof(ActionNewMissionStep).TypeHandle != 0;
							}
							UnknownFieldSet unknownFields = actionNewMissionStep._unknownFields;
							actionNewMissionStep._unknownFields = unknownFieldSet;
						}
					}
					input.ReadMessage(actionNewMissionStep);
					actions_ = actionNewMissionStep;
					actionsCase_ = (ActionsOneofCase)unknownFieldSet;
				}
				if ((long)unknownFieldSet == 1442)
				{
					ActionRemoveFromCollectionMenu builder3 = new ActionRemoveFromCollectionMenu();
					if (actionsCase_ == ActionsOneofCase.RemoveFromCollectionMenu)
					{
						if (actionsCase_ != ActionsOneofCase.RemoveFromCollectionMenu)
						{
						}
						object obj5 = actions_;
						if (obj5 != null && obj5 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder3);
					actions_ = builder3;
					actionsCase_ = (ActionsOneofCase)typeof(ActionRemoveFromCollectionMenu).TypeHandle;
				}
				if ((long)typeof(ActionRemoveFromCollectionMenu).TypeHandle != 1450)
				{
					goto IL_04c6;
				}
				ActionRemoveFromInventory builder4 = new ActionRemoveFromInventory();
				if (actionsCase_ == ActionsOneofCase.RemoveFromInventory)
				{
					if (actionsCase_ != ActionsOneofCase.RemoveFromInventory)
					{
					}
					object obj6 = actions_;
					if (obj6 != null && obj6 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder4);
				actions_ = builder4;
				actionsCase_ = (ActionsOneofCase)typeof(ActionRemoveFromInventory).TypeHandle;
			}
			if ((int)num > 482)
			{
				UnknownFieldSet unknownFieldSet2 = default(UnknownFieldSet);
				if (num == 562)
				{
					ActionGiveItem actionGiveItem = new ActionGiveItem();
					if (actionsCase_ == ActionsOneofCase.GiveItem)
					{
						if (actionsCase_ != ActionsOneofCase.GiveItem)
						{
						}
						object obj7 = actions_;
						if (obj7 != null && obj7 == null)
						{
							throw new InvalidCastException();
						}
						if (obj7 != null)
						{
							if ((object)typeof(ActionGiveItem).TypeHandle != null)
							{
								actionGiveItem.itemID_ = (int)typeof(ActionGiveItem).TypeHandle;
							}
							if ((object)typeof(ActionGiveItem).TypeHandle != null)
							{
								actionGiveItem.amount_ = (int)typeof(ActionGiveItem).TypeHandle;
							}
							UnknownFieldSet unknownFields2 = actionGiveItem._unknownFields;
							actionGiveItem._unknownFields = unknownFieldSet2;
						}
					}
					input.ReadMessage(actionGiveItem);
					actions_ = actionGiveItem;
					actionsCase_ = (ActionsOneofCase)unknownFieldSet2;
				}
				UnknownFieldSet unknownFieldSet3 = default(UnknownFieldSet);
				if ((long)unknownFieldSet2 == 722)
				{
					ActionItemDeleted actionItemDeleted = new ActionItemDeleted();
					if (actionsCase_ == ActionsOneofCase.ItemDeleted)
					{
						if (actionsCase_ != ActionsOneofCase.ItemDeleted)
						{
						}
						object obj8 = actions_;
						if (obj8 != null && obj8 == null)
						{
							throw new InvalidCastException();
						}
						if (obj8 != null)
						{
							if ((object)typeof(ActionItemDeleted).TypeHandle != null)
							{
								actionItemDeleted.itemID_ = (int)typeof(ActionItemDeleted).TypeHandle;
							}
							UnknownFieldSet unknownFields3 = actionItemDeleted._unknownFields;
							actionItemDeleted._unknownFields = unknownFieldSet3;
						}
					}
					input.ReadMessage(actionItemDeleted);
					actions_ = actionItemDeleted;
					actionsCase_ = (ActionsOneofCase)unknownFieldSet3;
				}
				if ((long)unknownFieldSet3 != 962)
				{
					goto IL_04c6;
				}
				ActionMoveMissionObjective builder5 = new ActionMoveMissionObjective();
				if (actionsCase_ == ActionsOneofCase.MoveMissionObjective)
				{
					if (actionsCase_ != ActionsOneofCase.MoveMissionObjective)
					{
					}
					object obj9 = actions_;
					if (obj9 != null && obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder5);
				actions_ = builder5;
				actionsCase_ = (ActionsOneofCase)typeof(ActionMoveMissionObjective).TypeHandle;
			}
			if ((long)typeof(ActionMoveMissionObjective).TypeHandle == 322)
			{
				ActionDeleteAfterMissions builder6 = new ActionDeleteAfterMissions();
				if (actionsCase_ == ActionsOneofCase.DeleteAfterMissions)
				{
					if (actionsCase_ != ActionsOneofCase.DeleteAfterMissions)
					{
					}
					object obj10 = actions_;
					if (obj10 != null && obj10 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder6);
				actions_ = builder6;
				actionsCase_ = (ActionsOneofCase)typeof(ActionDeleteAfterMissions).TypeHandle;
			}
			if ((long)typeof(ActionDeleteAfterMissions).TypeHandle == 482)
			{
				ActionFixTargetAmount builder7 = new ActionFixTargetAmount();
				if (actionsCase_ == ActionsOneofCase.FixTargetAmount)
				{
					if (actionsCase_ != ActionsOneofCase.FixTargetAmount)
					{
					}
					object obj11 = actions_;
					if (obj11 != null && obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder7);
				actions_ = builder7;
				actionsCase_ = (ActionsOneofCase)typeof(ActionFixTargetAmount).TypeHandle;
			}
			goto IL_04c6;
			IL_04c6:
			UnknownFieldSet unknownFieldSet4 = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600749A")]
		[Cpp2IlInjected.Address(RVA = "0x1E34EC0", Offset = "0x1E338C0", VA = "0x181E34EC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber > 90)
			{
				if (fieldNumber > 130)
				{
					if (fieldNumber != 190)
					{
						goto IL_009e;
					}
					ActionSetDialogFlag setDialogFlag = SetDialogFlag;
					ActionRemoveMissionStep removeMissionStep = RemoveMissionStep;
					ActionRemoveFromGrid removeFromGrid = RemoveFromGrid;
					ActionRemoveFromInventory removeFromInventory = RemoveFromInventory;
					ActionRemoveFromCollectionMenu removeFromCollectionMenu = RemoveFromCollectionMenu;
				}
				if (fieldNumber == 120)
				{
					ActionMoveMissionObjective moveMissionObjective = MoveMissionObjective;
				}
				if (fieldNumber != 130)
				{
					goto IL_009e;
				}
				ActionNewMissionStep newMissionStep = NewMissionStep;
			}
			int num2 = default(int);
			if (fieldNumber > 60)
			{
				int num = default(int);
				if (fieldNumber == 70)
				{
					num = 0;
					ActionGiveItem giveItem = GiveItem;
				}
				if (num != 90)
				{
					goto IL_009e;
				}
				num2 = 0;
				ActionItemDeleted itemDeleted = ItemDeleted;
			}
			int num3 = default(int);
			if (num2 == 40)
			{
				num3 = 0;
				ActionDeleteAfterMissions deleteAfterMissions = DeleteAfterMissions;
			}
			if (num3 == 60)
			{
				ActionFixTargetAmount fixTargetAmount = FixTargetAmount;
			}
			goto IL_009e;
			IL_009e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600749B")]
		[Cpp2IlInjected.Address(RVA = "0x1E36790", Offset = "0x1E35190", VA = "0x181E36790", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0159, IL_015d, IL_0161, IL_0169
			//IL_0057: Expected O, but got I4
			//IL_0062: Expected I4, but got O
			//IL_0080: Expected I4, but got O
			//IL_009e: Expected I4, but got O
			//IL_00bc: Expected I4, but got O
			//IL_00da: Expected I4, but got O
			//IL_00fd: Expected I4, but got O
			//IL_0138: Expected I4, but got O
			if (fieldNumber > 90)
			{
				if (fieldNumber > 130)
				{
					if ((object)typeof(ActionSetDialogFlag).TypeHandle != null)
					{
						if ((object)typeof(ActionSetDialogFlag).TypeHandle != null)
						{
							if ((object)typeof(ActionSetDialogFlag).TypeHandle != null)
							{
								if ((long)typeof(ActionSetDialogFlag).TypeHandle != 1)
								{
									if (fieldNumber == 190)
									{
										int num = 0;
										if (value != null && value == null)
										{
											throw new InvalidCastException();
										}
										actions_ = num;
										actionsCase_ = (ActionsOneofCase)typeof(ActionSetDialogFlag).TypeHandle;
									}
								}
								else
								{
									if (value != null && value == null)
									{
										throw new InvalidCastException();
									}
									actions_ = value;
									actionsCase_ = (ActionsOneofCase)typeof(ActionSetDialogFlag).TypeHandle;
								}
							}
							else
							{
								if (value != null && value == null)
								{
									throw new InvalidCastException();
								}
								actions_ = value;
								actionsCase_ = (ActionsOneofCase)typeof(ActionSetDialogFlag).TypeHandle;
							}
						}
						else
						{
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							actions_ = value;
							actionsCase_ = (ActionsOneofCase)typeof(ActionSetDialogFlag).TypeHandle;
						}
					}
					else
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						actions_ = value;
						actionsCase_ = (ActionsOneofCase)typeof(ActionSetDialogFlag).TypeHandle;
					}
				}
				else if (fieldNumber == 120)
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					actions_ = value;
					actionsCase_ = (ActionsOneofCase)typeof(ActionSetDialogFlag).TypeHandle;
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					actions_ = value;
				}
			}
			else if (fieldNumber > 60)
			{
				if (fieldNumber == 70)
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					actions_ = value;
					actionsCase_ = (ActionsOneofCase)typeof(ActionSetDialogFlag).TypeHandle;
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					actions_ = value;
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				actions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600749C")]
		[Cpp2IlInjected.Address(RVA = "0x1E349E0", Offset = "0x1E333E0", VA = "0x181E349E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0049: Expected O, but got I4
			if (fieldNumber > 90)
			{
				if (fieldNumber > 130 && this != null && this != null && this != null && (long)this != 1 && fieldNumber != 190)
				{
					return;
				}
				if (fieldNumber == 120)
				{
					goto IL_0040;
				}
			}
			if ((fieldNumber <= 60 || fieldNumber != 70) && fieldNumber != 40 && fieldNumber != 60)
			{
				return;
			}
			goto IL_0040;
			IL_0040:
			int num = 0;
			actions_ = num;
			actionsCase_ = (ActionsOneofCase)num;
		}

		[Cpp2IlInjected.Token(Token = "0x600749D")]
		[Cpp2IlInjected.Address(RVA = "0x1E35600", Offset = "0x1E34000", VA = "0x181E35600", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Actions"))
			{
				ActionsOneofCase actionsOneofCase = actionsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600749E")]
		[Cpp2IlInjected.Address(RVA = "0x1E34A70", Offset = "0x1E33470", VA = "0x181E34A70", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Actions"))
			{
				actions_ = (actionsCase_ = ActionsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600749F")]
		[Cpp2IlInjected.Address(RVA = "0x1E342F0", Offset = "0x1E32CF0", VA = "0x181E342F0", Slot = "16")]
		public void Apply(Profile profile, ITransactionContext context)
		{
			while ((object)typeof(IAction).TypeHandle != null)
			{
				int num = 0;
				if ((long)num < (long)(IntPtr)context)
				{
					num += num;
					if ((object)"{il2cpp array field il2cppMethodInfo->}" != (object)typeof(IAction).TypeHandle)
					{
						num++;
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60074A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E355C0", Offset = "0x1E33FC0", VA = "0x181E355C0")]
		public IAction GetOneOfAction()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60074A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E35550", Offset = "0x1E33F50", VA = "0x181E35550")]
		[IteratorStateMachine(typeof(_003CGetLeafActions_003Ed__79))]
		public IEnumerable<IAction> GetLeafActions()
		{
			new _003CGetLeafActions_003Ed__79(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60074A3")]
		[Cpp2IlInjected.Address(RVA = "0x1E34B40", Offset = "0x1E33540", VA = "0x181E34B40", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0015
			if (actionsCase_ == ActionsOneofCase.None)
			{
				context.AddError("Please select an action");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60074A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E37230", Offset = "0x1E35C30", VA = "0x181E37230")]
		static ActionOneOf()
		{
			Func<ActionOneOf> func = default(Func<ActionOneOf>);
			_parser = (MessageParser<ActionOneOf>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
