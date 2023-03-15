using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003C0")]
	public sealed class ConditionalEventItemData : IMessage<ConditionalEventItemData>, IMessage, IEquatable<ConditionalEventItemData>, IDeepCloneable<ConditionalEventItemData>, IMessageFieldAccessor, IMessageOneofAccessor, IItemData, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20003C1")]
		public enum ActionOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40013B1")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40013B2")]
			Spawn = 20,
			[Cpp2IlInjected.Token(Token = "0x40013B3")]
			Timestamp = 21,
			[Cpp2IlInjected.Token(Token = "0x40013B4")]
			RecurringEvent = 22,
			[Cpp2IlInjected.Token(Token = "0x40013B5")]
			ExpandGrid = 23
		}

		[Cpp2IlInjected.Token(Token = "0x4001398")]
		private static readonly MessageParser<ConditionalEventItemData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001399")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400139A")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400139B")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x400139C")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400139D")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x400139E")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400139F")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40013A0")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40013A1")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40013A2")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40013A3")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x40013A4")]
		public const int PriorityFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40013A5")]
		private int priority_;

		[Cpp2IlInjected.Token(Token = "0x40013A6")]
		public const int ConditionsFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40013A7")]
		private ConditionsList conditions_;

		[Cpp2IlInjected.Token(Token = "0x40013A8")]
		public const int SpawnFieldNumber = 20;

		[Cpp2IlInjected.Token(Token = "0x40013A9")]
		public const int TimestampFieldNumber = 21;

		[Cpp2IlInjected.Token(Token = "0x40013AA")]
		public const int RecurringEventFieldNumber = 22;

		[Cpp2IlInjected.Token(Token = "0x40013AB")]
		public const int ExpandGridFieldNumber = 23;

		[Cpp2IlInjected.Token(Token = "0x40013AC")]
		public const int DoOnceFieldNumber = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40013AD")]
		private bool doOnce_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40013AE")]
		private object action_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40013AF")]
		private ActionOneofCase actionCase_;

		[Cpp2IlInjected.Token(Token = "0x17000B26")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionalEventItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002C93")]
			[Cpp2IlInjected.Address(RVA = "0x24D1550", Offset = "0x24CFF50", VA = "0x1824D1550")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B27")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C94")]
			[Cpp2IlInjected.Address(RVA = "0x24D13C0", Offset = "0x24CFDC0", VA = "0x1824D13C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B28")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002C95")]
			[Cpp2IlInjected.Address(RVA = "0x24D16D0", Offset = "0x24D00D0", VA = "0x1824D16D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B29")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6002C9A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "16")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C9B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2A")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6002C9C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "18")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C9D")]
			[Cpp2IlInjected.Address(RVA = "0x24D1900", Offset = "0x24D0300", VA = "0x1824D1900")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2B")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6002C9E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "19")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C9F")]
			[Cpp2IlInjected.Address(RVA = "0x24D17E0", Offset = "0x24D01E0", VA = "0x1824D17E0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2C")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002CA0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CA1")]
			[Cpp2IlInjected.Address(RVA = "0x24D1890", Offset = "0x24D0290", VA = "0x1824D1890")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2D")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6002CA2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "21")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CA3")]
			[Cpp2IlInjected.Address(RVA = "0x24D1970", Offset = "0x24D0370", VA = "0x1824D1970")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2E")]
		[DebuggerNonUserCode]
		public int Priority
		{
			[Cpp2IlInjected.Token(Token = "0x6002CA4")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return priority_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CA5")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				priority_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B2F")]
		[DebuggerNonUserCode]
		public ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6002CA6")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return conditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CA7")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				conditions_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B30")]
		[DebuggerNonUserCode]
		public ConditionalSpawnData Spawn
		{
			[Cpp2IlInjected.Token(Token = "0x6002CA8")]
			[Cpp2IlInjected.Address(RVA = "0x24D1610", Offset = "0x24D0010", VA = "0x1824D1610")]
			get
			{
				int num = 0;
				if (actionCase_ == ActionOneofCase.Spawn)
				{
					object obj = action_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CA9")]
			[Cpp2IlInjected.Address(RVA = "0x24D1A20", Offset = "0x24D0420", VA = "0x1824D1A20")]
			set
			{
				action_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B31")]
		[DebuggerNonUserCode]
		public ConditionalTimestampData Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6002CAA")]
			[Cpp2IlInjected.Address(RVA = "0x24D1670", Offset = "0x24D0070", VA = "0x1824D1670")]
			get
			{
				int num = 0;
				if (actionCase_ == ActionOneofCase.Timestamp)
				{
					object obj = action_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CAB")]
			[Cpp2IlInjected.Address(RVA = "0x24D1A60", Offset = "0x24D0460", VA = "0x1824D1A60")]
			set
			{
				action_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B32")]
		[DebuggerNonUserCode]
		public ConditionalRecurringEvent RecurringEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002CAC")]
			[Cpp2IlInjected.Address(RVA = "0x24D15B0", Offset = "0x24CFFB0", VA = "0x1824D15B0")]
			get
			{
				int num = 0;
				if (actionCase_ == ActionOneofCase.RecurringEvent)
				{
					object obj = action_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CAD")]
			[Cpp2IlInjected.Address(RVA = "0x24D19E0", Offset = "0x24D03E0", VA = "0x1824D19E0")]
			set
			{
				action_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B33")]
		[DebuggerNonUserCode]
		public ConditionalExpandGrid ExpandGrid
		{
			[Cpp2IlInjected.Token(Token = "0x6002CAE")]
			[Cpp2IlInjected.Address(RVA = "0x24D1490", Offset = "0x24CFE90", VA = "0x1824D1490")]
			get
			{
				int num = 0;
				if (actionCase_ == ActionOneofCase.ExpandGrid)
				{
					object obj = action_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002CAF")]
			[Cpp2IlInjected.Address(RVA = "0x24D1850", Offset = "0x24D0250", VA = "0x1824D1850")]
			set
			{
				action_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B34")]
		[DebuggerNonUserCode]
		public bool DoOnce
		{
			[Cpp2IlInjected.Token(Token = "0x6002CB0")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return doOnce_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CB1")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set
			{
				doOnce_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B35")]
		[DebuggerNonUserCode]
		public ActionOneofCase ActionCase
		{
			[Cpp2IlInjected.Token(Token = "0x6002CB2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return actionCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000B36")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6002CC1")]
			[Cpp2IlInjected.Address(RVA = "0x24D14F0", Offset = "0x24CFEF0", VA = "0x1824D14F0", Slot = "17")]
			get
			{
				long num = Convert.ToInt64((uint)iD_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C96")]
		[Cpp2IlInjected.Address(RVA = "0x24D0D90", Offset = "0x24CF790", VA = "0x1824D0D90")]
		[DebuggerNonUserCode]
		public ConditionalEventItemData()
		{
			//IL_0053: Expected I4, but got O
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			actionCase_ = (ActionOneofCase)(action_ = new ConditionalSpawnData());
		}

		[Cpp2IlInjected.Token(Token = "0x6002C97")]
		[Cpp2IlInjected.Address(RVA = "0x24D0360", Offset = "0x24CED60", VA = "0x1824D0360")]
		private void OnConstruction()
		{
			//IL_0021: Expected I4, but got O
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			actionCase_ = (ActionOneofCase)(action_ = new ConditionalSpawnData());
		}

		[Cpp2IlInjected.Token(Token = "0x6002C98")]
		[Cpp2IlInjected.Address(RVA = "0x24D0EA0", Offset = "0x24CF8A0", VA = "0x1824D0EA0")]
		[DebuggerNonUserCode]
		public ConditionalEventItemData(ConditionalEventItemData other)
		{
			//IL_0053: Expected I4, but got O
			//IL_0112: Expected O, but got I4
			//IL_0191: Expected I4, but got I8
			//IL_01ba: Expected I4, but got I8
			//IL_0225: Expected I4, but got I8
			//IL_0242: Expected I4, but got O
			ConditionsList conditionsList = (conditions_ = new ConditionsList());
			actionCase_ = (ActionOneofCase)(action_ = new ConditionalSpawnData());
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			int num2 = (priority_ = other.priority_);
			ConditionsList conditionsList2 = other.conditions_;
			RepeatedField<ConditionOneOf> repeatedField = default(RepeatedField<ConditionOneOf>);
			if (conditionsList2 != null)
			{
				ConditionsList conditionsList3 = new ConditionsList();
				BoolOperator boolOperator = (conditionsList3.operator_ = conditionsList2.operator_);
				repeatedField = conditionsList2.conditions_;
				RepeatedField<ConditionOneOf> repeatedField2 = (conditionsList3.conditions_ = (RepeatedField<ConditionOneOf>)(object)((RepeatedField<T>)(object)repeatedField).Clone());
				UnknownFieldSet unknownFieldSet = (conditionsList3._unknownFields = UnknownFieldSet.Clone(conditionsList2._unknownFields));
			}
			int num3 = 0;
			conditions_ = (ConditionsList)num3;
			bool flag = (doOnce_ = other.doOnce_);
			ActionOneofCase actionOneofCase = other.actionCase_;
			if (repeatedField != null)
			{
				if (repeatedField != null)
				{
					if (repeatedField != null)
					{
						if (actionOneofCase != (ActionOneofCase)1)
						{
							goto IL_0242;
						}
						ConditionalExpandGrid expandGrid = other.ExpandGrid;
						ConditionalExpandGrid conditionalExpandGrid = new ConditionalExpandGrid();
						string text5 = (conditionalExpandGrid.gridDataPath_ = expandGrid.gridDataPath_);
						if (expandGrid.gridCase_ == ConditionalExpandGrid.GridOneofCase.VillageArea)
						{
							int villageArea = (int)expandGrid.VillageArea;
							conditionalExpandGrid.grid_ = typeof(VillageAreaType).TypeHandle;
							conditionalExpandGrid.gridCase_ = ConditionalExpandGrid.GridOneofCase.VillageArea;
						}
						UnknownFieldSet unknownFieldSet2 = (conditionalExpandGrid._unknownFields = UnknownFieldSet.Clone(expandGrid._unknownFields));
						action_ = conditionalExpandGrid;
						actionCase_ = ActionOneofCase.ExpandGrid;
					}
					ConditionalRecurringEvent conditionalRecurringEvent = (ConditionalRecurringEvent)(action_ = new ConditionalRecurringEvent(other.RecurringEvent));
				}
				ConditionalTimestampData timestamp = other.Timestamp;
				ConditionalTimestampData conditionalTimestampData = new ConditionalTimestampData
				{
					timestamp_ = ""
				};
				string text6 = (conditionalTimestampData.timestamp_ = timestamp.timestamp_);
				UnknownFieldSet unknownFieldSet3 = (conditionalTimestampData._unknownFields = UnknownFieldSet.Clone(timestamp._unknownFields));
				action_ = conditionalTimestampData;
				actionCase_ = ActionOneofCase.Timestamp;
			}
			actionCase_ = (ActionOneofCase)(action_ = new ConditionalSpawnData(other.Spawn));
			goto IL_0242;
			IL_0242:
			UnknownFieldSet unknownFieldSet4 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C99")]
		[Cpp2IlInjected.Address(RVA = "0x24CF070", Offset = "0x24CDA70", VA = "0x1824CF070", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionalEventItemData Clone()
		{
			return new ConditionalEventItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB3")]
		[Cpp2IlInjected.Address(RVA = "0x1D36160", Offset = "0x1D34B60", VA = "0x181D36160")]
		[DebuggerNonUserCode]
		public void ClearAction()
		{
			//IL_0010: Expected O, but got I4
			action_ = (actionCase_ = ActionOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB4")]
		[Cpp2IlInjected.Address(RVA = "0x24CF3E0", Offset = "0x24CDDE0", VA = "0x1824CF3E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ConditionalEventItemData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB5")]
		[Cpp2IlInjected.Address(RVA = "0x24CF220", Offset = "0x24CDC20", VA = "0x1824CF220", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionalEventItemData other)
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
									int num2 = other.priority_;
									if (priority_ == num2)
									{
										ConditionsList objB = other.conditions_;
										if (object.Equals(conditions_, objB))
										{
											ConditionalSpawnData spawn = Spawn;
											ConditionalSpawnData spawn2 = other.Spawn;
											if (object.Equals(spawn, spawn2))
											{
												ConditionalTimestampData timestamp = Timestamp;
												ConditionalTimestampData timestamp2 = other.Timestamp;
												if (object.Equals(timestamp, timestamp2))
												{
													ConditionalRecurringEvent recurringEvent = RecurringEvent;
													ConditionalRecurringEvent recurringEvent2 = other.RecurringEvent;
													if (object.Equals(recurringEvent, recurringEvent2))
													{
														ConditionalExpandGrid expandGrid = ExpandGrid;
														ConditionalExpandGrid expandGrid2 = other.ExpandGrid;
														if (object.Equals(expandGrid, expandGrid2))
														{
															bool flag = other.doOnce_;
															if (doOnce_ == flag)
															{
																ActionOneofCase actionOneofCase = other.actionCase_;
																if (actionCase_ == actionOneofCase)
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
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB6")]
		[Cpp2IlInjected.Address(RVA = "0x24CF630", Offset = "0x24CE030", VA = "0x1824CF630", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0144
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
				string text3 = iconAddress_;
				if (text3.m_stringLength != num2)
				{
					int hashCode3 = text3.GetHashCode();
				}
				string text4 = prefabAddress_;
				if (text4.m_stringLength != num2)
				{
					int hashCode4 = text4.GetHashCode();
				}
				if (priority_ != 0)
				{
				}
				ConditionsList conditionsList = conditions_;
				if (conditionsList != null)
				{
					int hashCode5 = conditionsList.GetHashCode();
				}
				if (actionCase_ != ActionOneofCase.Spawn)
				{
					continue;
				}
				object obj = action_;
				if (obj != null)
				{
					int hashCode6 = obj.GetHashCode();
					if (actionCase_ != ActionOneofCase.Timestamp)
					{
						continue;
					}
					object obj2 = action_;
					if (obj2 != null)
					{
						int hashCode7 = obj2.GetHashCode();
						if (actionCase_ != ActionOneofCase.RecurringEvent)
						{
							continue;
						}
						object obj3 = action_;
						if (obj3 != null)
						{
							int hashCode8 = obj3.GetHashCode();
							if (actionCase_ == ActionOneofCase.ExpandGrid)
							{
								object obj4 = action_;
								if (obj4 == null)
								{
									break;
								}
								int hashCode9 = obj4.GetHashCode();
							}
							if (doOnce_)
							{
							}
							UnknownFieldSet unknownFields = _unknownFields;
							if (unknownFields != null)
							{
								int hashCode10 = unknownFields.GetHashCode();
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

		[Cpp2IlInjected.Token(Token = "0x6002CB7")]
		[Cpp2IlInjected.Address(RVA = "0x24D0870", Offset = "0x24CF270", VA = "0x1824D0870", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB8")]
		[Cpp2IlInjected.Address(RVA = "0x24D08D0", Offset = "0x24CF2D0", VA = "0x1824D08D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_019a
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
				if (priority_ != 0)
				{
					int value6 = priority_;
					output.WriteInt32(value6);
				}
				if ((long)conditions_ != 0)
				{
					ConditionsList value7 = conditions_;
					output.WriteMessage(value7);
				}
				ActionOneofCase actionOneofCase = actionCase_;
				int num = 0;
				if (actionOneofCase != ActionOneofCase.Spawn)
				{
					continue;
				}
				if (actionCase_ == ActionOneofCase.Spawn)
				{
					object obj = action_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionCase_ != ActionOneofCase.Timestamp)
				{
					continue;
				}
				if (actionCase_ == ActionOneofCase.Timestamp)
				{
					object obj2 = action_;
					if (obj2 != null && obj2 == null)
					{
						break;
					}
				}
				if (actionCase_ != ActionOneofCase.RecurringEvent)
				{
					continue;
				}
				if (actionCase_ == ActionOneofCase.RecurringEvent)
				{
					object obj3 = action_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (actionCase_ == ActionOneofCase.ExpandGrid && actionCase_ == ActionOneofCase.ExpandGrid)
				{
					object obj4 = action_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (doOnce_)
				{
					bool value8 = doOnce_;
					output.WriteBool(value8);
				}
				_unknownFields?.WriteTo(output);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CB9")]
		[Cpp2IlInjected.Address(RVA = "0x24CEA90", Offset = "0x24CD490", VA = "0x1824CEA90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01ca
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
			string text3 = iconAddress_;
			if (text3.m_stringLength != num2)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != num2)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			int num8 = priority_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			ConditionsList conditionsList = conditions_;
			if (conditionsList != null)
			{
				int num10 = CodedOutputStream.ComputeMessageSize(conditionsList);
				num10++;
				num2 += num10;
			}
			if (actionCase_ == ActionOneofCase.Spawn)
			{
				if (actionCase_ != ActionOneofCase.Spawn)
				{
				}
				object obj = action_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num11 = default(int);
				num2 += num11;
			}
			if (actionCase_ == ActionOneofCase.Timestamp)
			{
				if (actionCase_ != ActionOneofCase.Timestamp)
				{
				}
				object obj2 = action_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num12 = default(int);
				num2 += num12;
			}
			if (actionCase_ == ActionOneofCase.RecurringEvent)
			{
				if (actionCase_ != ActionOneofCase.RecurringEvent)
				{
				}
				object obj3 = action_;
				if (obj3 != null && obj3 == null)
				{
					throw new InvalidCastException();
				}
				num2 += 2;
				int num13 = default(int);
				num2 += num13;
			}
			if (actionCase_ == ActionOneofCase.ExpandGrid)
			{
				if (actionCase_ == ActionOneofCase.ExpandGrid)
				{
					object obj4 = action_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
				}
				num2 += 2;
				int num14 = default(int);
				num2 += num14;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				num2 += num15;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CBA")]
		[Cpp2IlInjected.Address(RVA = "0x24CFA00", Offset = "0x24CE400", VA = "0x1824CFA00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionalEventItemData other)
		{
			//Discarded unreachable code: IL_0292
			//IL_0174: Expected I4, but got O
			//IL_01ad: Expected I4, but got O
			//IL_01e6: Expected I4, but got O
			//IL_0259: Expected I4, but got O
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
			int num2 = other.priority_;
			if (num2 != 0)
			{
				priority_ = num2;
			}
			if (other.conditions_ != null)
			{
				ConditionsList conditionsList2 = default(ConditionsList);
				ConditionsList conditionsList3 = default(ConditionsList);
				if (conditions_ == null)
				{
					ConditionsList conditionsList = (conditions_ = new ConditionsList());
					conditionsList2 = conditions_;
					conditionsList3 = other.conditions_;
				}
				if (conditionsList3 != null)
				{
					BoolOperator operator_ = conditionsList3.operator_;
					if (operator_ != 0)
					{
						conditionsList2.operator_ = operator_;
					}
					RepeatedField<ConditionOneOf> repeatedField = conditionsList2.conditions_;
					RepeatedField<ConditionOneOf> repeatedField2 = conditionsList3.conditions_;
					((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
					UnknownFieldSet unknownFields = conditionsList3._unknownFields;
					UnknownFieldSet unknownFieldSet = (conditionsList2._unknownFields = UnknownFieldSet.MergeFrom(conditionsList2._unknownFields, unknownFields));
				}
			}
			bool flag = other.doOnce_;
			if (flag)
			{
				doOnce_ = flag;
			}
			ActionOneofCase actionOneofCase = other.actionCase_;
			if (flag)
			{
				if (flag)
				{
					if (flag)
					{
						if (actionOneofCase != (ActionOneofCase)1)
						{
							goto IL_0272;
						}
						if (ExpandGrid == null)
						{
							actionCase_ = (ActionOneofCase)(action_ = new ConditionalExpandGrid());
						}
						ConditionalExpandGrid expandGrid = ExpandGrid;
						ConditionalExpandGrid expandGrid2 = other.ExpandGrid;
						expandGrid.MergeFrom(expandGrid2);
					}
					if (RecurringEvent == null)
					{
						actionCase_ = (ActionOneofCase)(action_ = new ConditionalRecurringEvent());
					}
					ConditionalRecurringEvent recurringEvent = RecurringEvent;
					ConditionalRecurringEvent recurringEvent2 = other.RecurringEvent;
					recurringEvent.MergeFrom(recurringEvent2);
				}
				if (Timestamp == null)
				{
					actionCase_ = (ActionOneofCase)(action_ = new ConditionalTimestampData());
				}
				ConditionalTimestampData timestamp = Timestamp;
				ConditionalTimestampData timestamp2 = other.Timestamp;
				if (timestamp2 == null)
				{
					goto IL_0272;
				}
				string timestamp_ = timestamp2.timestamp_;
				if (timestamp_.m_stringLength != 0)
				{
					timestamp.Timestamp = timestamp_;
				}
				UnknownFieldSet unknownFields2 = timestamp2._unknownFields;
				UnknownFieldSet unknownFieldSet2 = (timestamp._unknownFields = UnknownFieldSet.MergeFrom(timestamp._unknownFields, unknownFields2));
			}
			if (Spawn == null)
			{
				actionCase_ = (ActionOneofCase)(action_ = new ConditionalSpawnData());
			}
			ConditionalSpawnData spawn = Spawn;
			ConditionalSpawnData spawn2 = other.Spawn;
			spawn.MergeFrom(spawn2);
			goto IL_0272;
			IL_0272:
			UnknownFieldSet unknownFields3 = other._unknownFields;
			UnknownFieldSet unknownFieldSet3 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields3));
		}

		[Cpp2IlInjected.Token(Token = "0x6002CBB")]
		[Cpp2IlInjected.Address(RVA = "0x24CFE30", Offset = "0x24CE830", VA = "0x1824CFE30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_006e: Expected I4, but got O
			//IL_00bf: Expected I4, but got O
			//IL_0164: Expected I4, but got O
			//IL_01d4: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 80)
			{
				if ((int)num > 170)
				{
					if (num == 178)
					{
						ConditionalRecurringEvent conditionalRecurringEvent = new ConditionalRecurringEvent();
						if (actionCase_ == ActionOneofCase.RecurringEvent)
						{
							if (actionCase_ != ActionOneofCase.RecurringEvent)
							{
							}
							object obj = action_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(conditionalRecurringEvent);
						action_ = conditionalRecurringEvent;
						actionCase_ = (ActionOneofCase)conditionalRecurringEvent;
					}
					if (num == 186)
					{
						ConditionalExpandGrid builder = new ConditionalExpandGrid();
						if (actionCase_ == ActionOneofCase.ExpandGrid)
						{
							if (actionCase_ != ActionOneofCase.ExpandGrid)
							{
							}
							object obj2 = action_;
							if (obj2 != null && obj2 == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(builder);
						action_ = builder;
						actionCase_ = (ActionOneofCase)typeof(ConditionalExpandGrid).TypeHandle;
					}
					if ((long)typeof(ConditionalExpandGrid).TypeHandle != 240)
					{
						goto IL_0263;
					}
					bool flag = (doOnce_ = input.ReadBool());
				}
				ConditionsList conditionsList = default(ConditionsList);
				if (num == 90)
				{
					ConditionsList builder2 = default(ConditionsList);
					if (conditions_ == null)
					{
						conditionsList = (conditions_ = new ConditionsList());
						builder2 = conditions_;
					}
					input.ReadMessage(builder2);
				}
				if ((long)conditionsList == 162)
				{
					ConditionalSpawnData builder3 = new ConditionalSpawnData();
					if (actionCase_ == ActionOneofCase.Spawn)
					{
						if (actionCase_ != ActionOneofCase.Spawn)
						{
						}
						object obj3 = action_;
						if (obj3 != null && obj3 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder3);
					action_ = builder3;
					actionCase_ = (ActionOneofCase)typeof(ConditionalSpawnData).TypeHandle;
				}
				if ((long)typeof(ConditionalSpawnData).TypeHandle != 170)
				{
					goto IL_0263;
				}
				ConditionalTimestampData conditionalTimestampData = new ConditionalTimestampData();
				UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
				if (actionCase_ == ActionOneofCase.Timestamp)
				{
					if (actionCase_ != ActionOneofCase.Timestamp)
					{
					}
					object obj4 = action_;
					if (obj4 != null && obj4 == null)
					{
						throw new InvalidCastException();
					}
					if (obj4 != null)
					{
						UnknownFieldSet unknownFields = conditionalTimestampData._unknownFields;
						conditionalTimestampData._unknownFields = unknownFieldSet;
					}
				}
				input.ReadMessage(conditionalTimestampData);
				action_ = conditionalTimestampData;
				actionCase_ = (ActionOneofCase)unknownFieldSet;
			}
			int num2 = default(int);
			if ((int)num > 26)
			{
				string text2 = default(string);
				if (num == 34)
				{
					text2 = (IconAddress = input.ReadString());
				}
				string text4 = default(string);
				if ((long)text2 == 42)
				{
					text4 = (PrefabAddress = input.ReadString());
				}
				if ((long)text4 != 80)
				{
					goto IL_0263;
				}
				num2 = (priority_ = input.ReadInt32());
			}
			int num3 = default(int);
			if (num2 == 8)
			{
				num3 = (iD_ = input.ReadInt32());
			}
			string text6 = default(string);
			if (num3 == 18)
			{
				text6 = (Name = input.ReadString());
			}
			if ((long)text6 == 26)
			{
				string text8 = (DisplayName = input.ReadString());
			}
			goto IL_0263;
			IL_0263:
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6002CBC")]
		[Cpp2IlInjected.Address(RVA = "0x24CF440", Offset = "0x24CDE40", VA = "0x1824CF440", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 10)
			{
				int num = iD_;
			}
			if ((object)typeof(int).TypeHandle != null && (object)typeof(int).TypeHandle != null && (object)typeof(int).TypeHandle != null && (long)typeof(int).TypeHandle != 1 && fieldNumber == 30)
			{
				bool flag = doOnce_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CBD")]
		[Cpp2IlInjected.Address(RVA = "0x24D0400", Offset = "0x24CEE00", VA = "0x1824D0400", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0015, IL_001c, IL_001d, IL_0021, IL_0028, IL_0029, IL_002d, IL_0034, IL_0035, IL_0039, IL_0040, IL_0041, IL_0042, IL_0046, IL_00a6, IL_00ac, IL_00b2, IL_00b8, IL_00be
			//IL_000e: Expected I4, but got O
			//IL_007b: Expected I4, but got O
			if (fieldNumber - 1 <= 10)
			{
				object obj = default(object);
				iD_ = (int)obj;
			}
			else if ((object)typeof(string).TypeHandle != null)
			{
				if ((object)typeof(string).TypeHandle != null)
				{
					if ((object)typeof(string).TypeHandle != null)
					{
						if ((long)typeof(string).TypeHandle != 1)
						{
							if (fieldNumber == 30)
							{
								object obj2 = default(object);
								doOnce_ = (byte)(int)obj2 != 0;
							}
						}
						else if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
					}
					else if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CBE")]
		[Cpp2IlInjected.Address(RVA = "0x24CEE90", Offset = "0x24CD890", VA = "0x1824CEE90", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_001d, IL_0029, IL_0035, IL_0041, IL_004b
			//IL_0054: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			if (fieldNumber - 1 <= 10)
			{
				int num = (iD_ = 0);
			}
			else if ("" != null && "" != null && "" != null && (long)"" != 1)
			{
				if (fieldNumber == 30)
				{
					doOnce_ = false;
				}
			}
			else
			{
				int num2 = 0;
				action_ = num2;
				actionCase_ = (ActionOneofCase)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CBF")]
		[Cpp2IlInjected.Address(RVA = "0x24CF940", Offset = "0x24CE340", VA = "0x1824CF940", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Action"))
			{
				ActionOneofCase actionOneofCase = actionCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CC0")]
		[Cpp2IlInjected.Address(RVA = "0x24CF000", Offset = "0x24CDA00", VA = "0x1824CF000", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Action"))
			{
				action_ = (actionCase_ = ActionOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CC2")]
		[Cpp2IlInjected.Address(RVA = "0x24CF070", Offset = "0x24CDA70", VA = "0x1824CF070", Slot = "22")]
		IItemData IItemData.Clone()
		{
			ConditionalEventItemData conditionalEventItemData = new ConditionalEventItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CC3")]
		[Cpp2IlInjected.Address(RVA = "0x24CF210", Offset = "0x24CDC10", VA = "0x1824CF210", Slot = "23")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//IL_000a: Expected I4, but got I8
			priority_ = 100;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CC4")]
		[Cpp2IlInjected.Address(RVA = "0x24CF9F0", Offset = "0x24CE3F0", VA = "0x1824CF9F0")]
		public bool IsDisabledForever(bool eventWasActive)
		{
			if (!eventWasActive)
			{
				int num = 0;
			}
			return doOnce_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CC5")]
		[Cpp2IlInjected.Address(RVA = "0x24CF0D0", Offset = "0x24CDAD0", VA = "0x1824CF0D0", Slot = "24")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_0025: Expected O, but got I4
			if (!doOnce_)
			{
				ActionOneofCase actionOneofCase = actionCase_;
				if (actionOneofCase == ActionOneofCase.Timestamp || actionOneofCase == ActionOneofCase.ExpandGrid)
				{
					string message = $"{actionOneofCase} cannot be undone";
					context.AddInvalidMemberError(message, "DoOnce");
				}
				return;
			}
			while (actionCase_ != ActionOneofCase.Spawn)
			{
			}
			object obj = action_;
			if (obj == null || obj != null)
			{
				while (obj == null)
				{
				}
				context.AddInvalidMemberError("Cannot be used with RemoveWhenDone", "DoOnce");
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CC6")]
		[Cpp2IlInjected.Address(RVA = "0x24D0C80", Offset = "0x24CF680", VA = "0x1824D0C80")]
		static ConditionalEventItemData()
		{
			Func<ConditionalEventItemData> func = default(Func<ConditionalEventItemData>);
			_parser = (MessageParser<ConditionalEventItemData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
