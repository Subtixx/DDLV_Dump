using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mdl.Log;
using Serilog;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007CE")]
	public sealed class ConditionOneOf : ICondition, IReplaceCondition, IDataValidation, IProtobufDefaultData, IMessage<ConditionOneOf>, IMessage, IEquatable<ConditionOneOf>, IDeepCloneable<ConditionOneOf>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20007CF")]
		public enum ConditionsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400271E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400271F")]
			CommonConditions = 5,
			[Cpp2IlInjected.Token(Token = "0x4002720")]
			SubConditions = 10,
			[Cpp2IlInjected.Token(Token = "0x4002721")]
			AlwaysTrue = 12,
			[Cpp2IlInjected.Token(Token = "0x4002722")]
			AlwaysFalse = 13,
			[Cpp2IlInjected.Token(Token = "0x4002723")]
			AreaUnlocked = 15,
			[Cpp2IlInjected.Token(Token = "0x4002724")]
			BuildingUnlocked = 17,
			[Cpp2IlInjected.Token(Token = "0x4002725")]
			CharacterFriendship = 20,
			[Cpp2IlInjected.Token(Token = "0x4002726")]
			CharacterLockedInVillage = 25,
			[Cpp2IlInjected.Token(Token = "0x4002727")]
			CharacterUnlocked = 30,
			[Cpp2IlInjected.Token(Token = "0x4002728")]
			Country = 35,
			[Cpp2IlInjected.Token(Token = "0x4002729")]
			CookingRecipeKnownWith = 37,
			[Cpp2IlInjected.Token(Token = "0x400272A")]
			CookingRecipeVisible = 38,
			[Cpp2IlInjected.Token(Token = "0x400272B")]
			CraftingRecipeVisible = 39,
			[Cpp2IlInjected.Token(Token = "0x400272C")]
			CurrentScene = 40,
			[Cpp2IlInjected.Token(Token = "0x400272D")]
			FTUEEventCompleted = 41,
			[Cpp2IlInjected.Token(Token = "0x400272E")]
			Date = 45,
			[Cpp2IlInjected.Token(Token = "0x400272F")]
			DayOfWeek = 46,
			[Cpp2IlInjected.Token(Token = "0x4002730")]
			DayOfMonth = 47,
			[Cpp2IlInjected.Token(Token = "0x4002731")]
			TimeOfDay = 50,
			[Cpp2IlInjected.Token(Token = "0x4002732")]
			DialogueFlag = 55,
			[Cpp2IlInjected.Token(Token = "0x4002733")]
			HasEnoughCharactersToDiscuss = 56,
			[Cpp2IlInjected.Token(Token = "0x4002734")]
			HasEnoughCrittersToFeed = 57,
			[Cpp2IlInjected.Token(Token = "0x4002735")]
			HasEnoughDriedFlowers = 58,
			[Cpp2IlInjected.Token(Token = "0x4002736")]
			HasEnoughNightThorns = 59,
			[Cpp2IlInjected.Token(Token = "0x4002737")]
			HasEnoughRestaurantOrders = 60,
			[Cpp2IlInjected.Token(Token = "0x4002738")]
			Inventory = 61,
			[Cpp2IlInjected.Token(Token = "0x4002739")]
			IsFTUE = 65,
			[Cpp2IlInjected.Token(Token = "0x400273A")]
			IsHangingOut = 70,
			[Cpp2IlInjected.Token(Token = "0x400273B")]
			KeyholeStatus = 78,
			[Cpp2IlInjected.Token(Token = "0x400273C")]
			ManaHasAlreadyMissed = 80,
			[Cpp2IlInjected.Token(Token = "0x400273D")]
			MemoryShard = 85,
			[Cpp2IlInjected.Token(Token = "0x400273E")]
			MissionAvailable = 89,
			[Cpp2IlInjected.Token(Token = "0x400273F")]
			MissionCompleted = 90,
			[Cpp2IlInjected.Token(Token = "0x4002740")]
			MissionOngoing = 95,
			[Cpp2IlInjected.Token(Token = "0x4002741")]
			MissionStatus = 96,
			[Cpp2IlInjected.Token(Token = "0x4002742")]
			MissionTypeStatus = 97,
			[Cpp2IlInjected.Token(Token = "0x4002743")]
			MissionStepCompleted = 100,
			[Cpp2IlInjected.Token(Token = "0x4002744")]
			MissionStepStatus = 101,
			[Cpp2IlInjected.Token(Token = "0x4002745")]
			MissionObjectiveCompleted = 105,
			[Cpp2IlInjected.Token(Token = "0x4002746")]
			MissionObjectiveStatus = 106,
			[Cpp2IlInjected.Token(Token = "0x4002747")]
			Platform = 110,
			[Cpp2IlInjected.Token(Token = "0x4002748")]
			PlayerLevel = 115,
			[Cpp2IlInjected.Token(Token = "0x4002749")]
			RealmUnlocked = 120,
			[Cpp2IlInjected.Token(Token = "0x400274A")]
			Timer = 122,
			[Cpp2IlInjected.Token(Token = "0x400274B")]
			Timestamp = 123,
			[Cpp2IlInjected.Token(Token = "0x400274C")]
			ToolUnlocked = 125,
			[Cpp2IlInjected.Token(Token = "0x400274D")]
			WearingClothes = 130,
			[Cpp2IlInjected.Token(Token = "0x400274E")]
			Weather = 135
		}

		[Cpp2IlInjected.Token(Token = "0x40026E9")]
		private static readonly MessageParser<ConditionOneOf> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40026EA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40026EB")]
		public const int CommonConditionsFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40026EC")]
		public const int SubConditionsFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x40026ED")]
		public const int AlwaysTrueFieldNumber = 12;

		[Cpp2IlInjected.Token(Token = "0x40026EE")]
		public const int AlwaysFalseFieldNumber = 13;

		[Cpp2IlInjected.Token(Token = "0x40026EF")]
		public const int AreaUnlockedFieldNumber = 15;

		[Cpp2IlInjected.Token(Token = "0x40026F0")]
		public const int BuildingUnlockedFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x40026F1")]
		public const int CharacterFriendshipFieldNumber = 20;

		[Cpp2IlInjected.Token(Token = "0x40026F2")]
		public const int CharacterLockedInVillageFieldNumber = 25;

		[Cpp2IlInjected.Token(Token = "0x40026F3")]
		public const int CharacterUnlockedFieldNumber = 30;

		[Cpp2IlInjected.Token(Token = "0x40026F4")]
		public const int CountryFieldNumber = 35;

		[Cpp2IlInjected.Token(Token = "0x40026F5")]
		public const int CookingRecipeKnownWithFieldNumber = 37;

		[Cpp2IlInjected.Token(Token = "0x40026F6")]
		public const int CookingRecipeVisibleFieldNumber = 38;

		[Cpp2IlInjected.Token(Token = "0x40026F7")]
		public const int CraftingRecipeVisibleFieldNumber = 39;

		[Cpp2IlInjected.Token(Token = "0x40026F8")]
		public const int CurrentSceneFieldNumber = 40;

		[Cpp2IlInjected.Token(Token = "0x40026F9")]
		public const int FTUEEventCompletedFieldNumber = 41;

		[Cpp2IlInjected.Token(Token = "0x40026FA")]
		public const int DateFieldNumber = 45;

		[Cpp2IlInjected.Token(Token = "0x40026FB")]
		public const int DayOfWeekFieldNumber = 46;

		[Cpp2IlInjected.Token(Token = "0x40026FC")]
		public const int DayOfMonthFieldNumber = 47;

		[Cpp2IlInjected.Token(Token = "0x40026FD")]
		public const int TimeOfDayFieldNumber = 50;

		[Cpp2IlInjected.Token(Token = "0x40026FE")]
		public const int DialogueFlagFieldNumber = 55;

		[Cpp2IlInjected.Token(Token = "0x40026FF")]
		public const int HasEnoughCharactersToDiscussFieldNumber = 56;

		[Cpp2IlInjected.Token(Token = "0x4002700")]
		public const int HasEnoughCrittersToFeedFieldNumber = 57;

		[Cpp2IlInjected.Token(Token = "0x4002701")]
		public const int HasEnoughDriedFlowersFieldNumber = 58;

		[Cpp2IlInjected.Token(Token = "0x4002702")]
		public const int HasEnoughNightThornsFieldNumber = 59;

		[Cpp2IlInjected.Token(Token = "0x4002703")]
		public const int HasEnoughRestaurantOrdersFieldNumber = 60;

		[Cpp2IlInjected.Token(Token = "0x4002704")]
		public const int InventoryFieldNumber = 61;

		[Cpp2IlInjected.Token(Token = "0x4002705")]
		public const int IsFTUEFieldNumber = 65;

		[Cpp2IlInjected.Token(Token = "0x4002706")]
		public const int IsHangingOutFieldNumber = 70;

		[Cpp2IlInjected.Token(Token = "0x4002707")]
		public const int KeyholeStatusFieldNumber = 78;

		[Cpp2IlInjected.Token(Token = "0x4002708")]
		public const int ManaHasAlreadyMissedFieldNumber = 80;

		[Cpp2IlInjected.Token(Token = "0x4002709")]
		public const int MemoryShardFieldNumber = 85;

		[Cpp2IlInjected.Token(Token = "0x400270A")]
		public const int MissionAvailableFieldNumber = 89;

		[Cpp2IlInjected.Token(Token = "0x400270B")]
		public const int MissionCompletedFieldNumber = 90;

		[Cpp2IlInjected.Token(Token = "0x400270C")]
		public const int MissionOngoingFieldNumber = 95;

		[Cpp2IlInjected.Token(Token = "0x400270D")]
		public const int MissionStatusFieldNumber = 96;

		[Cpp2IlInjected.Token(Token = "0x400270E")]
		public const int MissionTypeStatusFieldNumber = 97;

		[Cpp2IlInjected.Token(Token = "0x400270F")]
		public const int MissionStepCompletedFieldNumber = 100;

		[Cpp2IlInjected.Token(Token = "0x4002710")]
		public const int MissionStepStatusFieldNumber = 101;

		[Cpp2IlInjected.Token(Token = "0x4002711")]
		public const int MissionObjectiveCompletedFieldNumber = 105;

		[Cpp2IlInjected.Token(Token = "0x4002712")]
		public const int MissionObjectiveStatusFieldNumber = 106;

		[Cpp2IlInjected.Token(Token = "0x4002713")]
		public const int PlatformFieldNumber = 110;

		[Cpp2IlInjected.Token(Token = "0x4002714")]
		public const int PlayerLevelFieldNumber = 115;

		[Cpp2IlInjected.Token(Token = "0x4002715")]
		public const int RealmUnlockedFieldNumber = 120;

		[Cpp2IlInjected.Token(Token = "0x4002716")]
		public const int TimerFieldNumber = 122;

		[Cpp2IlInjected.Token(Token = "0x4002717")]
		public const int TimestampFieldNumber = 123;

		[Cpp2IlInjected.Token(Token = "0x4002718")]
		public const int ToolUnlockedFieldNumber = 125;

		[Cpp2IlInjected.Token(Token = "0x4002719")]
		public const int WearingClothesFieldNumber = 130;

		[Cpp2IlInjected.Token(Token = "0x400271A")]
		public const int WeatherFieldNumber = 135;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400271B")]
		private object conditions_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400271C")]
		private ConditionsOneofCase conditionsCase_;

		[Cpp2IlInjected.Token(Token = "0x17001596")]
		ICondition IReplaceCondition.ReplaceCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6005585")]
			[Cpp2IlInjected.Address(RVA = "0x2086AA0", Offset = "0x20854A0", VA = "0x182086AA0", Slot = "8")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001597")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005587")]
			[Cpp2IlInjected.Address(RVA = "0x2092610", Offset = "0x2091010", VA = "0x182092610", Slot = "5")]
			get
			{
				if ((object)typeof(ICondition).TypeHandle != null)
				{
					int num = 0;
					num += num;
					num++;
					if ((object)typeof(ICondition).TypeHandle != null)
					{
					}
				}
				return "(None)";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001598")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005588")]
			[Cpp2IlInjected.Address(RVA = "0x2092880", Offset = "0x2091280", VA = "0x182092880", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_0018
				//IL_0018: Expected I4, but got O
				//IL_001e: Expected I4, but got O
				//IL_0024: Expected I4, but got O
				if ((object)typeof(ICondition).TypeHandle != null)
				{
					int num = 0;
					num += num;
					num++;
					return (ConditionListener)typeof(ICondition).TypeHandle;
				}
				return (ConditionListener)typeof(ICondition).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001599")]
		[field: Cpp2IlInjected.Token(Token = "0x40026E7")]
		public static ConditionsOneofCase DefaultData
		{
			[Cpp2IlInjected.Token(Token = "0x600558C")]
			[Cpp2IlInjected.Address(RVA = "0x2092240", Offset = "0x2090C40", VA = "0x182092240")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600558D")]
			[Cpp2IlInjected.Address(RVA = "0x2093560", Offset = "0x2091F60", VA = "0x182093560")]
			set;
		} = (ConditionsOneofCase)Serilogger.Create<ConditionOneOf>();


		[Cpp2IlInjected.Token(Token = "0x1700159A")]
		[field: Cpp2IlInjected.Token(Token = "0x40026E8")]
		private static ILogger Log
		{
			[Cpp2IlInjected.Token(Token = "0x600558F")]
			[Cpp2IlInjected.Address(RVA = "0x2092970", Offset = "0x2091370", VA = "0x182092970")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700159B")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionOneOf> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005590")]
			[Cpp2IlInjected.Address(RVA = "0x2092DF0", Offset = "0x20917F0", VA = "0x182092DF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700159C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005591")]
			[Cpp2IlInjected.Address(RVA = "0x20922A0", Offset = "0x2090CA0", VA = "0x1820922A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700159D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005592")]
			[Cpp2IlInjected.Address(RVA = "0x2093210", Offset = "0x2091C10", VA = "0x182093210", Slot = "15")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700159E")]
		[DebuggerNonUserCode]
		public ConditionCommon CommonConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6005596")]
			[Cpp2IlInjected.Address(RVA = "0x2091EE0", Offset = "0x20908E0", VA = "0x182091EE0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005597")]
			[Cpp2IlInjected.Address(RVA = "0x5C5D50", Offset = "0x5C4750", VA = "0x1805C5D50")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700159F")]
		[DebuggerNonUserCode]
		public ConditionsList SubConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6005598")]
			[Cpp2IlInjected.Address(RVA = "0x2092F70", Offset = "0x2091970", VA = "0x182092F70")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.SubConditions)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6005599")]
			[Cpp2IlInjected.Address(RVA = "0x1D16FC0", Offset = "0x1D159C0", VA = "0x181D16FC0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A0")]
		[DebuggerNonUserCode]
		public ConditionAlwaysTrue AlwaysTrue
		{
			[Cpp2IlInjected.Token(Token = "0x600559A")]
			[Cpp2IlInjected.Address(RVA = "0x2091CA0", Offset = "0x20906A0", VA = "0x182091CA0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.AlwaysTrue)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600559B")]
			[Cpp2IlInjected.Address(RVA = "0x1D16F80", Offset = "0x1D15980", VA = "0x181D16F80")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A1")]
		[DebuggerNonUserCode]
		public ConditionAlwaysFalse AlwaysFalse
		{
			[Cpp2IlInjected.Token(Token = "0x600559C")]
			[Cpp2IlInjected.Address(RVA = "0x2091C40", Offset = "0x2090640", VA = "0x182091C40")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.AlwaysFalse)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600559D")]
			[Cpp2IlInjected.Address(RVA = "0x1D17040", Offset = "0x1D15A40", VA = "0x181D17040")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A2")]
		[DebuggerNonUserCode]
		public ConditionAreaUnlocked AreaUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600559E")]
			[Cpp2IlInjected.Address(RVA = "0x2091D00", Offset = "0x2090700", VA = "0x182091D00")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.AreaUnlocked)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600559F")]
			[Cpp2IlInjected.Address(RVA = "0x1D17000", Offset = "0x1D15A00", VA = "0x181D17000")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A3")]
		[DebuggerNonUserCode]
		public ConditionBuildingUnlocked BuildingUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60055A0")]
			[Cpp2IlInjected.Address(RVA = "0x2091D60", Offset = "0x2090760", VA = "0x182091D60")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.BuildingUnlocked)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055A1")]
			[Cpp2IlInjected.Address(RVA = "0x2028F00", Offset = "0x2027900", VA = "0x182028F00")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A4")]
		[DebuggerNonUserCode]
		public ConditionCharacterFriendship CharacterFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x60055A2")]
			[Cpp2IlInjected.Address(RVA = "0x2091DC0", Offset = "0x20907C0", VA = "0x182091DC0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CharacterFriendship)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055A3")]
			[Cpp2IlInjected.Address(RVA = "0x2028D10", Offset = "0x2027710", VA = "0x182028D10")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A5")]
		[DebuggerNonUserCode]
		public ConditionCharacterLockedInVillage CharacterLockedInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x60055A4")]
			[Cpp2IlInjected.Address(RVA = "0x2091E20", Offset = "0x2090820", VA = "0x182091E20")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CharacterLockedInVillage)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055A5")]
			[Cpp2IlInjected.Address(RVA = "0x2093320", Offset = "0x2091D20", VA = "0x182093320")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A6")]
		[DebuggerNonUserCode]
		public ConditionCharacterUnlocked CharacterUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60055A6")]
			[Cpp2IlInjected.Address(RVA = "0x2091E80", Offset = "0x2090880", VA = "0x182091E80")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CharacterUnlocked)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055A7")]
			[Cpp2IlInjected.Address(RVA = "0x2093360", Offset = "0x2091D60", VA = "0x182093360")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A7")]
		[DebuggerNonUserCode]
		public ConditionCountry Country
		{
			[Cpp2IlInjected.Token(Token = "0x60055A8")]
			[Cpp2IlInjected.Address(RVA = "0x2092000", Offset = "0x2090A00", VA = "0x182092000")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Country)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055A9")]
			[Cpp2IlInjected.Address(RVA = "0x2093420", Offset = "0x2091E20", VA = "0x182093420")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A8")]
		[DebuggerNonUserCode]
		public ConditionCookingRecipeKnownWith CookingRecipeKnownWith
		{
			[Cpp2IlInjected.Token(Token = "0x60055AA")]
			[Cpp2IlInjected.Address(RVA = "0x2091F40", Offset = "0x2090940", VA = "0x182091F40")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CookingRecipeKnownWith)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055AB")]
			[Cpp2IlInjected.Address(RVA = "0x20933A0", Offset = "0x2091DA0", VA = "0x1820933A0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015A9")]
		[DebuggerNonUserCode]
		public ConditionCookingRecipeVisible CookingRecipeVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60055AC")]
			[Cpp2IlInjected.Address(RVA = "0x2091FA0", Offset = "0x20909A0", VA = "0x182091FA0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CookingRecipeVisible)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055AD")]
			[Cpp2IlInjected.Address(RVA = "0x20933E0", Offset = "0x2091DE0", VA = "0x1820933E0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AA")]
		[DebuggerNonUserCode]
		public ConditionCraftingRecipeVisible CraftingRecipeVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60055AE")]
			[Cpp2IlInjected.Address(RVA = "0x2092060", Offset = "0x2090A60", VA = "0x182092060")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CraftingRecipeVisible)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055AF")]
			[Cpp2IlInjected.Address(RVA = "0x2093460", Offset = "0x2091E60", VA = "0x182093460")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AB")]
		[DebuggerNonUserCode]
		public ConditionCurrentScene CurrentScene
		{
			[Cpp2IlInjected.Token(Token = "0x60055B0")]
			[Cpp2IlInjected.Address(RVA = "0x20920C0", Offset = "0x2090AC0", VA = "0x1820920C0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CurrentScene)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055B1")]
			[Cpp2IlInjected.Address(RVA = "0x1E38100", Offset = "0x1E36B00", VA = "0x181E38100")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AC")]
		[DebuggerNonUserCode]
		public ConditionFTUEEventCompleted FTUEEventCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60055B2")]
			[Cpp2IlInjected.Address(RVA = "0x20923D0", Offset = "0x2090DD0", VA = "0x1820923D0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.FTUEEventCompleted)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055B3")]
			[Cpp2IlInjected.Address(RVA = "0x2093600", Offset = "0x2092000", VA = "0x182093600")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AD")]
		[DebuggerNonUserCode]
		public ConditionDate Date
		{
			[Cpp2IlInjected.Token(Token = "0x60055B4")]
			[Cpp2IlInjected.Address(RVA = "0x2092120", Offset = "0x2090B20", VA = "0x182092120")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Date)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055B5")]
			[Cpp2IlInjected.Address(RVA = "0x20934A0", Offset = "0x2091EA0", VA = "0x1820934A0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AE")]
		[DebuggerNonUserCode]
		public ConditionDayOfWeek DayOfWeek
		{
			[Cpp2IlInjected.Token(Token = "0x60055B6")]
			[Cpp2IlInjected.Address(RVA = "0x20921E0", Offset = "0x2090BE0", VA = "0x1820921E0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.DayOfWeek)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055B7")]
			[Cpp2IlInjected.Address(RVA = "0x2093520", Offset = "0x2091F20", VA = "0x182093520")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AF")]
		[DebuggerNonUserCode]
		public ConditionDayOfMonth DayOfMonth
		{
			[Cpp2IlInjected.Token(Token = "0x60055B8")]
			[Cpp2IlInjected.Address(RVA = "0x2092180", Offset = "0x2090B80", VA = "0x182092180")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.DayOfMonth)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055B9")]
			[Cpp2IlInjected.Address(RVA = "0x20934E0", Offset = "0x2091EE0", VA = "0x1820934E0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B0")]
		[DebuggerNonUserCode]
		public ConditionTimeOfDay TimeOfDay
		{
			[Cpp2IlInjected.Token(Token = "0x60055BA")]
			[Cpp2IlInjected.Address(RVA = "0x2092FD0", Offset = "0x20919D0", VA = "0x182092FD0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.TimeOfDay)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055BB")]
			[Cpp2IlInjected.Address(RVA = "0x2093B00", Offset = "0x2092500", VA = "0x182093B00")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B1")]
		[DebuggerNonUserCode]
		public ConditionDialogueFlag DialogueFlag
		{
			[Cpp2IlInjected.Token(Token = "0x60055BC")]
			[Cpp2IlInjected.Address(RVA = "0x2092370", Offset = "0x2090D70", VA = "0x182092370")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.DialogueFlag)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055BD")]
			[Cpp2IlInjected.Address(RVA = "0x20935C0", Offset = "0x2091FC0", VA = "0x1820935C0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B2")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughCharactersToDiscuss HasEnoughCharactersToDiscuss
		{
			[Cpp2IlInjected.Token(Token = "0x60055BE")]
			[Cpp2IlInjected.Address(RVA = "0x2092430", Offset = "0x2090E30", VA = "0x182092430")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughCharactersToDiscuss)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055BF")]
			[Cpp2IlInjected.Address(RVA = "0x2093640", Offset = "0x2092040", VA = "0x182093640")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B3")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughCrittersToFeed HasEnoughCrittersToFeed
		{
			[Cpp2IlInjected.Token(Token = "0x60055C0")]
			[Cpp2IlInjected.Address(RVA = "0x2092490", Offset = "0x2090E90", VA = "0x182092490")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughCrittersToFeed)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055C1")]
			[Cpp2IlInjected.Address(RVA = "0x2093680", Offset = "0x2092080", VA = "0x182093680")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B4")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughDriedFlowers HasEnoughDriedFlowers
		{
			[Cpp2IlInjected.Token(Token = "0x60055C2")]
			[Cpp2IlInjected.Address(RVA = "0x20924F0", Offset = "0x2090EF0", VA = "0x1820924F0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughDriedFlowers)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055C3")]
			[Cpp2IlInjected.Address(RVA = "0x20936C0", Offset = "0x20920C0", VA = "0x1820936C0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B5")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughNightThorns HasEnoughNightThorns
		{
			[Cpp2IlInjected.Token(Token = "0x60055C4")]
			[Cpp2IlInjected.Address(RVA = "0x2092550", Offset = "0x2090F50", VA = "0x182092550")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughNightThorns)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055C5")]
			[Cpp2IlInjected.Address(RVA = "0x2093700", Offset = "0x2092100", VA = "0x182093700")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B6")]
		[DebuggerNonUserCode]
		public ConditionHasEnoughRestaurantOrders HasEnoughRestaurantOrders
		{
			[Cpp2IlInjected.Token(Token = "0x60055C6")]
			[Cpp2IlInjected.Address(RVA = "0x20925B0", Offset = "0x2090FB0", VA = "0x1820925B0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughRestaurantOrders)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055C7")]
			[Cpp2IlInjected.Address(RVA = "0x1E38140", Offset = "0x1E36B40", VA = "0x181E38140")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B7")]
		[DebuggerNonUserCode]
		public ConditionInventory Inventory
		{
			[Cpp2IlInjected.Token(Token = "0x60055C8")]
			[Cpp2IlInjected.Address(RVA = "0x2092700", Offset = "0x2091100", VA = "0x182092700")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Inventory)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055C9")]
			[Cpp2IlInjected.Address(RVA = "0x2093740", Offset = "0x2092140", VA = "0x182093740")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B8")]
		[DebuggerNonUserCode]
		public ConditionIsFTUE IsFTUE
		{
			[Cpp2IlInjected.Token(Token = "0x60055CA")]
			[Cpp2IlInjected.Address(RVA = "0x2092760", Offset = "0x2091160", VA = "0x182092760")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.IsFTUE)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055CB")]
			[Cpp2IlInjected.Address(RVA = "0x2093780", Offset = "0x2092180", VA = "0x182093780")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015B9")]
		[DebuggerNonUserCode]
		public ConditionIsHangingOut IsHangingOut
		{
			[Cpp2IlInjected.Token(Token = "0x60055CC")]
			[Cpp2IlInjected.Address(RVA = "0x20927C0", Offset = "0x20911C0", VA = "0x1820927C0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.IsHangingOut)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055CD")]
			[Cpp2IlInjected.Address(RVA = "0x1E38180", Offset = "0x1E36B80", VA = "0x181E38180")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015BA")]
		[DebuggerNonUserCode]
		public ConditionKeyholeStatus KeyholeStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60055CE")]
			[Cpp2IlInjected.Address(RVA = "0x2092820", Offset = "0x2091220", VA = "0x182092820")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.KeyholeStatus)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055CF")]
			[Cpp2IlInjected.Address(RVA = "0x20937C0", Offset = "0x20921C0", VA = "0x1820937C0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015BB")]
		[DebuggerNonUserCode]
		public ConditionManaHasAlreadyMissed ManaHasAlreadyMissed
		{
			[Cpp2IlInjected.Token(Token = "0x60055D0")]
			[Cpp2IlInjected.Address(RVA = "0x20929D0", Offset = "0x20913D0", VA = "0x1820929D0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.ManaHasAlreadyMissed)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055D1")]
			[Cpp2IlInjected.Address(RVA = "0x2093800", Offset = "0x2092200", VA = "0x182093800")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015BC")]
		[DebuggerNonUserCode]
		public ConditionMemoryShard MemoryShard
		{
			[Cpp2IlInjected.Token(Token = "0x60055D2")]
			[Cpp2IlInjected.Address(RVA = "0x2092A30", Offset = "0x2091430", VA = "0x182092A30")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MemoryShard)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055D3")]
			[Cpp2IlInjected.Address(RVA = "0x2093840", Offset = "0x2092240", VA = "0x182093840")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015BD")]
		[DebuggerNonUserCode]
		public ConditionMissionAvailable MissionAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x60055D4")]
			[Cpp2IlInjected.Address(RVA = "0x2092A90", Offset = "0x2091490", VA = "0x182092A90")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MissionAvailable)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055D5")]
			[Cpp2IlInjected.Address(RVA = "0x2093880", Offset = "0x2092280", VA = "0x182093880")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015BE")]
		[DebuggerNonUserCode]
		public ConditionMissionCompleted MissionCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60055D6")]
			[Cpp2IlInjected.Address(RVA = "0x2092AF0", Offset = "0x20914F0", VA = "0x182092AF0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MissionCompleted)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055D7")]
			[Cpp2IlInjected.Address(RVA = "0x1E381C0", Offset = "0x1E36BC0", VA = "0x181E381C0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015BF")]
		[DebuggerNonUserCode]
		public ConditionMissionOngoing MissionOngoing
		{
			[Cpp2IlInjected.Token(Token = "0x60055D8")]
			[Cpp2IlInjected.Address(RVA = "0x2092C10", Offset = "0x2091610", VA = "0x182092C10")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MissionOngoing)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055D9")]
			[Cpp2IlInjected.Address(RVA = "0x2093940", Offset = "0x2092340", VA = "0x182093940")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C0")]
		[DebuggerNonUserCode]
		public ConditionMissionStatus MissionStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60055DA")]
			[Cpp2IlInjected.Address(RVA = "0x2092C70", Offset = "0x2091670", VA = "0x182092C70")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MissionStatus)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055DB")]
			[Cpp2IlInjected.Address(RVA = "0x2093980", Offset = "0x2092380", VA = "0x182093980")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C1")]
		[DebuggerNonUserCode]
		public ConditionMissionTypeStatus MissionTypeStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60055DC")]
			[Cpp2IlInjected.Address(RVA = "0x2092D90", Offset = "0x2091790", VA = "0x182092D90")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MissionTypeStatus)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055DD")]
			[Cpp2IlInjected.Address(RVA = "0x2093A40", Offset = "0x2092440", VA = "0x182093A40")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C2")]
		[DebuggerNonUserCode]
		public ConditionMissionStepCompleted MissionStepCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60055DE")]
			[Cpp2IlInjected.Address(RVA = "0x2092CD0", Offset = "0x20916D0", VA = "0x182092CD0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MissionStepCompleted)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055DF")]
			[Cpp2IlInjected.Address(RVA = "0x20939C0", Offset = "0x20923C0", VA = "0x1820939C0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C3")]
		[DebuggerNonUserCode]
		public ConditionMissionStepStatus MissionStepStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60055E0")]
			[Cpp2IlInjected.Address(RVA = "0x2092D30", Offset = "0x2091730", VA = "0x182092D30")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MissionStepStatus)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055E1")]
			[Cpp2IlInjected.Address(RVA = "0x2093A00", Offset = "0x2092400", VA = "0x182093A00")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C4")]
		[DebuggerNonUserCode]
		public ConditionMissionObjectiveCompleted MissionObjectiveCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60055E2")]
			[Cpp2IlInjected.Address(RVA = "0x2092B50", Offset = "0x2091550", VA = "0x182092B50")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MissionObjectiveCompleted)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055E3")]
			[Cpp2IlInjected.Address(RVA = "0x20938C0", Offset = "0x20922C0", VA = "0x1820938C0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C5")]
		[DebuggerNonUserCode]
		public ConditionMissionObjectiveStatus MissionObjectiveStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60055E4")]
			[Cpp2IlInjected.Address(RVA = "0x2092BB0", Offset = "0x20915B0", VA = "0x182092BB0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.MissionObjectiveStatus)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055E5")]
			[Cpp2IlInjected.Address(RVA = "0x2093900", Offset = "0x2092300", VA = "0x182093900")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C6")]
		[DebuggerNonUserCode]
		public ConditionPlatform Platform
		{
			[Cpp2IlInjected.Token(Token = "0x60055E6")]
			[Cpp2IlInjected.Address(RVA = "0x2092E50", Offset = "0x2091850", VA = "0x182092E50")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Platform)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055E7")]
			[Cpp2IlInjected.Address(RVA = "0x2093A80", Offset = "0x2092480", VA = "0x182093A80")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C7")]
		[DebuggerNonUserCode]
		public ConditionPlayerLevel PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60055E8")]
			[Cpp2IlInjected.Address(RVA = "0x2092EB0", Offset = "0x20918B0", VA = "0x182092EB0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.PlayerLevel)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055E9")]
			[Cpp2IlInjected.Address(RVA = "0x2093AC0", Offset = "0x20924C0", VA = "0x182093AC0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C8")]
		[DebuggerNonUserCode]
		public ConditionRealmUnlocked RealmUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60055EA")]
			[Cpp2IlInjected.Address(RVA = "0x2092F10", Offset = "0x2091910", VA = "0x182092F10")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.RealmUnlocked)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055EB")]
			[Cpp2IlInjected.Address(RVA = "0x1E38200", Offset = "0x1E36C00", VA = "0x181E38200")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C9")]
		[DebuggerNonUserCode]
		public ConditionTimer Timer
		{
			[Cpp2IlInjected.Token(Token = "0x60055EC")]
			[Cpp2IlInjected.Address(RVA = "0x2093030", Offset = "0x2091A30", VA = "0x182093030")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Timer)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055ED")]
			[Cpp2IlInjected.Address(RVA = "0x2093B40", Offset = "0x2092540", VA = "0x182093B40")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015CA")]
		[DebuggerNonUserCode]
		public ConditionTimestamp Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60055EE")]
			[Cpp2IlInjected.Address(RVA = "0x2093090", Offset = "0x2091A90", VA = "0x182093090")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Timestamp)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055EF")]
			[Cpp2IlInjected.Address(RVA = "0x2093B80", Offset = "0x2092580", VA = "0x182093B80")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015CB")]
		[DebuggerNonUserCode]
		public ConditionToolUnlocked ToolUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60055F0")]
			[Cpp2IlInjected.Address(RVA = "0x20930F0", Offset = "0x2091AF0", VA = "0x1820930F0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.ToolUnlocked)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055F1")]
			[Cpp2IlInjected.Address(RVA = "0x2093BC0", Offset = "0x20925C0", VA = "0x182093BC0")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015CC")]
		[DebuggerNonUserCode]
		public ConditionWearingClothes WearingClothes
		{
			[Cpp2IlInjected.Token(Token = "0x60055F2")]
			[Cpp2IlInjected.Address(RVA = "0x2093150", Offset = "0x2091B50", VA = "0x182093150")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.WearingClothes)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E38240", Offset = "0x1E36C40", VA = "0x181E38240")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015CD")]
		[DebuggerNonUserCode]
		public ConditionWeather Weather
		{
			[Cpp2IlInjected.Token(Token = "0x60055F4")]
			[Cpp2IlInjected.Address(RVA = "0x20931B0", Offset = "0x2091BB0", VA = "0x1820931B0")]
			get
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.Weather)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60055F5")]
			[Cpp2IlInjected.Address(RVA = "0x2093C00", Offset = "0x2092600", VA = "0x182093C00")]
			set
			{
				conditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015CE")]
		[DebuggerNonUserCode]
		public ConditionsOneofCase ConditionsCase
		{
			[Cpp2IlInjected.Token(Token = "0x60055F6")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return conditionsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005586")]
		[Cpp2IlInjected.Address(RVA = "0x20869A0", Offset = "0x20853A0", VA = "0x1820869A0")]
		public unsafe bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_001c: Expected I4, but got O
			if ((object)typeof(ICondition).TypeHandle != null)
			{
				int num = 0;
				if ((long)num < (long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref worldProfile))
				{
					num += num;
					num++;
				}
			}
			return (byte)(int)typeof(ICondition).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005589")]
		[Cpp2IlInjected.Address(RVA = "0x2088E80", Offset = "0x2087880", VA = "0x182088E80", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			if ((object)typeof(ICondition).TypeHandle != null)
			{
				int num = 0;
				num += num;
				num++;
				return (LockedInfo)typeof(ICondition).TypeHandle;
			}
			return (LockedInfo)typeof(ICondition).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x600558A")]
		[Cpp2IlInjected.Address(RVA = "0x2086AA0", Offset = "0x20854A0", VA = "0x182086AA0")]
		public ICondition GetOneOfCondition()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600558B")]
		[Cpp2IlInjected.Address(RVA = "0x20868A0", Offset = "0x20852A0", VA = "0x1820868A0", Slot = "9")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0035
			switch (conditionsCase_)
			{
			case ConditionsOneofCase.SubConditions:
				if (conditions_ != null)
				{
					bool flag = default(bool);
					if (!flag)
					{
						context.AddError("Please enter sub-conditions or remove it");
					}
					break;
				}
				throw new InvalidCastException();
			case ConditionsOneofCase.None:
				context.AddError("Please don't leave condition at None");
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600558E")]
		[Cpp2IlInjected.Address(RVA = "0x208CFB0", Offset = "0x208B9B0", VA = "0x18208CFB0", Slot = "10")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_00c4, IL_0133, IL_0163, IL_017b, IL_01f2, IL_0222, IL_023a, IL_026a, IL_0282, IL_029a, IL_02b2, IL_02ef
			//IL_003c: Expected I4, but got O
			//IL_005c: Expected I4, but got O
			//IL_0076: Expected I4, but got O
			//IL_008e: Expected I4, but got O
			//IL_00ab: Expected I4, but got O
			//IL_00c3: Expected I4, but got O
			//IL_00db: Expected I4, but got O
			//IL_0102: Expected I4, but got O
			//IL_011a: Expected I4, but got O
			//IL_0132: Expected I4, but got O
			//IL_014a: Expected I4, but got O
			//IL_0162: Expected I4, but got O
			//IL_017a: Expected I4, but got O
			//IL_0192: Expected I4, but got O
			//IL_01c1: Expected I4, but got O
			//IL_01d9: Expected I4, but got O
			//IL_01f1: Expected I4, but got O
			//IL_0209: Expected I4, but got O
			//IL_0221: Expected I4, but got O
			//IL_0239: Expected I4, but got O
			//IL_0251: Expected I4, but got O
			//IL_0269: Expected I4, but got O
			//IL_0281: Expected I4, but got O
			//IL_0299: Expected I4, but got O
			//IL_02b1: Expected I4, but got O
			//IL_02c9: Expected I4, but got O
			ConditionsOneofCase conditionsOneofCase = DefaultData;
			if (conditionsOneofCase > ConditionsOneofCase.Inventory)
			{
				if (conditionsOneofCase > ConditionsOneofCase.MissionStepCompleted)
				{
					if (conditionsOneofCase > ConditionsOneofCase.PlayerLevel)
					{
						if (conditionsOneofCase > ConditionsOneofCase.ToolUnlocked)
						{
							switch (conditionsOneofCase)
							{
							case ConditionsOneofCase.WearingClothes:
								conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionWearingClothes());
								return;
							case ConditionsOneofCase.Weather:
								conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionWeather());
								return;
							}
							ILogger logger = Log;
							ConditionsOneofCase conditionsOneofCase2 = DefaultData;
							int num = 0;
							uint num2 = default(uint);
							if (num < (int)num2)
							{
								num += num;
								num++;
							}
						}
						else if (conditionsOneofCase == ConditionsOneofCase.RealmUnlocked)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionRealmUnlocked());
						}
						else
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionToolUnlocked());
						}
					}
					else if (conditionsOneofCase == ConditionsOneofCase.MissionObjectiveCompleted)
					{
						conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMissionObjectiveCompleted());
					}
					else
					{
						conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionPlatform());
					}
				}
				else if (conditionsOneofCase > ConditionsOneofCase.ManaHasAlreadyMissed)
				{
					if (conditionsOneofCase > ConditionsOneofCase.MissionCompleted)
					{
						if (conditionsOneofCase == ConditionsOneofCase.MissionOngoing)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMissionOngoing());
						}
						else
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMissionStepCompleted());
						}
					}
					else
					{
						conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMemoryShard());
					}
				}
				else
				{
					conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionIsFTUE());
				}
			}
			else if (conditionsOneofCase > ConditionsOneofCase.CharacterLockedInVillage)
			{
				if (conditionsOneofCase > ConditionsOneofCase.CurrentScene)
				{
					if (conditionsOneofCase > ConditionsOneofCase.DayOfWeek)
					{
						if (conditionsOneofCase == ConditionsOneofCase.DialogueFlag)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionDialogueFlag());
						}
						else
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionInventory());
						}
					}
					else
					{
						conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionDate());
					}
				}
				else
				{
					conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionCharacterUnlocked());
				}
			}
			else
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionAreaUnlocked());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005593")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionOneOf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005594")]
		[Cpp2IlInjected.Address(RVA = "0x2090710", Offset = "0x208F110", VA = "0x182090710")]
		[DebuggerNonUserCode]
		public ConditionOneOf(ConditionOneOf other)
		{
			//IL_0166: Expected I4, but got I8
			//IL_01e2: Expected I4, but got I8
			//IL_023e: Expected I4, but got I8
			//IL_029a: Expected I4, but got I8
			//IL_0308: Expected I4, but got I8
			//IL_0388: Expected I4, but got I8
			//IL_03f6: Expected I4, but got I8
			//IL_0464: Expected I4, but got I8
			//IL_04f6: Expected I4, but got I8
			//IL_0555: Expected I4, but got I8
			//IL_05c3: Expected I4, but got I8
			//IL_061f: Expected I4, but got I8
			//IL_0699: Expected I4, but got I8
			//IL_0793: Expected I4, but got I8
			//IL_0846: Expected I4, but got I8
			//IL_0890: Expected I4, but got I8
			//IL_08da: Expected I4, but got I8
			//IL_0924: Expected I4, but got I8
			//IL_096e: Expected I4, but got I8
			//IL_09dc: Expected I4, but got I8
			//IL_0a2b: Expected I4, but got I8
			ConditionsOneofCase conditionsOneofCase;
			ConditionPlatform conditionPlatform = default(ConditionPlatform);
			while (true)
			{
				base._002Ector();
				conditionsOneofCase = other.conditionsCase_;
				if (conditionsOneofCase <= ConditionsOneofCase.MemoryShard)
				{
					break;
				}
				if (conditionsOneofCase > ConditionsOneofCase.Platform)
				{
					if (conditionsOneofCase > ConditionsOneofCase.ToolUnlocked)
					{
						if (conditionsOneofCase == ConditionsOneofCase.WearingClothes)
						{
							ConditionWearingClothes conditionWearingClothes = (ConditionWearingClothes)(conditions_ = other.WearingClothes.Clone());
						}
						if (conditionsOneofCase != ConditionsOneofCase.Weather)
						{
							continue;
						}
						ConditionWeather conditionWeather = (ConditionWeather)(conditions_ = other.Weather.Clone());
					}
					if (conditionsOneofCase == ConditionsOneofCase.PlayerLevel)
					{
						ConditionPlayerLevel conditionPlayerLevel = (ConditionPlayerLevel)(conditions_ = other.PlayerLevel.Clone());
					}
					ConditionRealmUnlocked conditionRealmUnlocked = (ConditionRealmUnlocked)(conditions_ = other.RealmUnlocked.Clone());
					ConditionTimer conditionTimer = (ConditionTimer)(conditions_ = other.Timer.Clone());
					ConditionTimestamp conditionTimestamp = (ConditionTimestamp)(conditions_ = other.Timestamp.Clone());
					ConditionToolUnlocked conditionToolUnlocked = (ConditionToolUnlocked)(conditions_ = other.ToolUnlocked.Clone());
				}
				if (conditionsOneofCase > ConditionsOneofCase.MissionObjectiveCompleted)
				{
					if (conditionsOneofCase == ConditionsOneofCase.MissionObjectiveStatus)
					{
						ConditionMissionObjectiveStatus missionObjectiveStatus = other.MissionObjectiveStatus;
						ConditionMissionObjectiveStatus conditionMissionObjectiveStatus = new ConditionMissionObjectiveStatus();
						int num = (conditionMissionObjectiveStatus.mission_ = missionObjectiveStatus.mission_);
						int num2 = (conditionMissionObjectiveStatus.stepID_ = missionObjectiveStatus.stepID_);
						int num3 = (conditionMissionObjectiveStatus.subStepID_ = missionObjectiveStatus.subStepID_);
						int num4 = (conditionMissionObjectiveStatus.objectiveID_ = missionObjectiveStatus.objectiveID_);
						MissionStatusOperator missionStatusOperator = (conditionMissionObjectiveStatus.status_ = missionObjectiveStatus.status_);
						UnknownFieldSet unknownFieldSet = (conditionMissionObjectiveStatus._unknownFields = UnknownFieldSet.Clone(missionObjectiveStatus._unknownFields));
						conditions_ = conditionMissionObjectiveStatus;
						conditionsCase_ = ConditionsOneofCase.MissionObjectiveStatus;
					}
					conditionPlatform = (ConditionPlatform)(conditions_ = other.Platform.Clone());
				}
				if ((long)conditionPlatform <= 12)
				{
					ConditionMissionAvailable missionAvailable = other.MissionAvailable;
					ConditionMissionAvailable conditionMissionAvailable = new ConditionMissionAvailable();
					int num5 = (conditionMissionAvailable.mission_ = missionAvailable.mission_);
					bool flag = (conditionMissionAvailable.inversed_ = missionAvailable.inversed_);
					UnknownFieldSet unknownFieldSet2 = (conditionMissionAvailable._unknownFields = UnknownFieldSet.Clone(missionAvailable._unknownFields));
					conditions_ = conditionMissionAvailable;
					conditionsCase_ = ConditionsOneofCase.MissionAvailable;
					ConditionMissionCompleted missionCompleted = other.MissionCompleted;
					ConditionMissionCompleted conditionMissionCompleted = new ConditionMissionCompleted();
					int num6 = (conditionMissionCompleted.mission_ = missionCompleted.mission_);
					bool flag2 = (conditionMissionCompleted.inversed_ = missionCompleted.inversed_);
					UnknownFieldSet unknownFieldSet3 = (conditionMissionCompleted._unknownFields = UnknownFieldSet.Clone(missionCompleted._unknownFields));
					conditions_ = conditionMissionCompleted;
					conditionsCase_ = ConditionsOneofCase.MissionCompleted;
					ConditionMissionOngoing missionOngoing = other.MissionOngoing;
					ConditionMissionOngoing conditionMissionOngoing = new ConditionMissionOngoing();
					int num7 = (conditionMissionOngoing.mission_ = missionOngoing.mission_);
					bool flag3 = (conditionMissionOngoing.inversed_ = missionOngoing.inversed_);
					UnknownFieldSet unknownFieldSet4 = (conditionMissionOngoing._unknownFields = UnknownFieldSet.Clone(missionOngoing._unknownFields));
					conditions_ = conditionMissionOngoing;
					conditionsCase_ = ConditionsOneofCase.MissionOngoing;
					ConditionMissionStatus missionStatus = other.MissionStatus;
					ConditionMissionStatus conditionMissionStatus = new ConditionMissionStatus();
					int num8 = (conditionMissionStatus.mission_ = missionStatus.mission_);
					IntOperator intOperator = (conditionMissionStatus.operator_ = missionStatus.operator_);
					MissionState missionState = (conditionMissionStatus.state_ = missionStatus.state_);
					UnknownFieldSet unknownFieldSet5 = (conditionMissionStatus._unknownFields = UnknownFieldSet.Clone(missionStatus._unknownFields));
					conditions_ = conditionMissionStatus;
					conditionsCase_ = ConditionsOneofCase.MissionStatus;
					ConditionMissionTypeStatus missionTypeStatus = other.MissionTypeStatus;
					ConditionMissionTypeStatus conditionMissionTypeStatus = new ConditionMissionTypeStatus();
					bool flag4 = (conditionMissionTypeStatus.specificType_ = missionTypeStatus.specificType_);
					MissionType missionType = (conditionMissionTypeStatus.missionType_ = missionTypeStatus.missionType_);
					IntOperator intOperator2 = (conditionMissionTypeStatus.operator_ = missionTypeStatus.operator_);
					MissionState missionState2 = (conditionMissionTypeStatus.state_ = missionTypeStatus.state_);
					UnknownFieldSet unknownFieldSet6 = (conditionMissionTypeStatus._unknownFields = UnknownFieldSet.Clone(missionTypeStatus._unknownFields));
					conditions_ = conditionMissionTypeStatus;
					conditionsCase_ = ConditionsOneofCase.MissionTypeStatus;
					ConditionMissionStepCompleted missionStepCompleted = other.MissionStepCompleted;
					ConditionMissionStepCompleted conditionMissionStepCompleted = new ConditionMissionStepCompleted();
					int num9 = (conditionMissionStepCompleted.mission_ = missionStepCompleted.mission_);
					int num10 = (conditionMissionStepCompleted.stepID_ = missionStepCompleted.stepID_);
					bool flag5 = (conditionMissionStepCompleted.inversed_ = missionStepCompleted.inversed_);
					UnknownFieldSet unknownFieldSet7 = (conditionMissionStepCompleted._unknownFields = UnknownFieldSet.Clone(missionStepCompleted._unknownFields));
					conditions_ = conditionMissionStepCompleted;
					conditionsCase_ = ConditionsOneofCase.MissionStepCompleted;
					ConditionMissionStepStatus missionStepStatus = other.MissionStepStatus;
					ConditionMissionStepStatus conditionMissionStepStatus = new ConditionMissionStepStatus();
					int num11 = (conditionMissionStepStatus.mission_ = missionStepStatus.mission_);
					int num12 = (conditionMissionStepStatus.stepID_ = missionStepStatus.stepID_);
					MissionStatusOperator missionStatusOperator2 = (conditionMissionStepStatus.status_ = missionStepStatus.status_);
					UnknownFieldSet unknownFieldSet8 = (conditionMissionStepStatus._unknownFields = UnknownFieldSet.Clone(missionStepStatus._unknownFields));
					conditions_ = conditionMissionStepStatus;
					conditionsCase_ = ConditionsOneofCase.MissionStepStatus;
				}
				ConditionMissionObjectiveCompleted missionObjectiveCompleted = other.MissionObjectiveCompleted;
				ConditionMissionObjectiveCompleted conditionMissionObjectiveCompleted = new ConditionMissionObjectiveCompleted();
				int num13 = (conditionMissionObjectiveCompleted.mission_ = missionObjectiveCompleted.mission_);
				int num14 = (conditionMissionObjectiveCompleted.stepID_ = missionObjectiveCompleted.stepID_);
				int num15 = (conditionMissionObjectiveCompleted.subStepID_ = missionObjectiveCompleted.subStepID_);
				int num16 = (conditionMissionObjectiveCompleted.objectiveID_ = missionObjectiveCompleted.objectiveID_);
				bool flag6 = (conditionMissionObjectiveCompleted.inversed_ = missionObjectiveCompleted.inversed_);
				UnknownFieldSet unknownFieldSet9 = (conditionMissionObjectiveCompleted._unknownFields = UnknownFieldSet.Clone(missionObjectiveCompleted._unknownFields));
				conditions_ = conditionMissionObjectiveCompleted;
				conditionsCase_ = ConditionsOneofCase.MissionObjectiveCompleted;
				break;
			}
			UnknownFieldSet unknownFieldSet13 = default(UnknownFieldSet);
			if (conditionsOneofCase > ConditionsOneofCase.IsFTUE)
			{
				if (conditionsOneofCase > ConditionsOneofCase.KeyholeStatus)
				{
					if (conditionsOneofCase == ConditionsOneofCase.ManaHasAlreadyMissed)
					{
						ConditionManaHasAlreadyMissed manaHasAlreadyMissed = other.ManaHasAlreadyMissed;
						ConditionManaHasAlreadyMissed conditionManaHasAlreadyMissed = new ConditionManaHasAlreadyMissed();
						bool flag7 = (conditionManaHasAlreadyMissed.inversed_ = manaHasAlreadyMissed.inversed_);
						UnknownFieldSet unknownFieldSet10 = (conditionManaHasAlreadyMissed._unknownFields = UnknownFieldSet.Clone(manaHasAlreadyMissed._unknownFields));
						conditions_ = conditionManaHasAlreadyMissed;
						conditionsCase_ = ConditionsOneofCase.ManaHasAlreadyMissed;
					}
					ConditionMemoryShard memoryShard = other.MemoryShard;
					ConditionMemoryShard conditionMemoryShard = new ConditionMemoryShard();
					int num17 = (conditionMemoryShard.shard_ = memoryShard.shard_);
					IntOperator intOperator3 = (conditionMemoryShard.operator_ = memoryShard.operator_);
					int num18 = (conditionMemoryShard.progress_ = memoryShard.progress_);
					UnknownFieldSet unknownFieldSet11 = (conditionMemoryShard._unknownFields = UnknownFieldSet.Clone(memoryShard._unknownFields));
					conditions_ = conditionMemoryShard;
					conditionsCase_ = ConditionsOneofCase.MemoryShard;
				}
				ConditionIsHangingOut isHangingOut = other.IsHangingOut;
				ConditionIsHangingOut conditionIsHangingOut = new ConditionIsHangingOut();
				bool flag8 = (conditionIsHangingOut.inversed_ = isHangingOut.inversed_);
				int num19 = (conditionIsHangingOut.character_ = isHangingOut.character_);
				UnknownFieldSet unknownFieldSet12 = (conditionIsHangingOut._unknownFields = UnknownFieldSet.Clone(isHangingOut._unknownFields));
				conditions_ = conditionIsHangingOut;
				conditionsCase_ = ConditionsOneofCase.IsHangingOut;
				ConditionKeyholeStatus keyholeStatus = other.KeyholeStatus;
				ConditionKeyholeStatus conditionKeyholeStatus = new ConditionKeyholeStatus
				{
					keyhole_ = ""
				};
				string text = (conditionKeyholeStatus.keyhole_ = keyholeStatus.keyhole_);
				int num20 = (conditionKeyholeStatus.level_ = keyholeStatus.level_);
				KeyholeStatusOperator keyholeStatusOperator = (conditionKeyholeStatus.status_ = keyholeStatus.status_);
				unknownFieldSet13 = (conditionKeyholeStatus._unknownFields = UnknownFieldSet.Clone(keyholeStatus._unknownFields));
				conditions_ = conditionKeyholeStatus;
				conditionsCase_ = ConditionsOneofCase.KeyholeStatus;
			}
			if ((long)unknownFieldSet13 <= 36)
			{
				ConditionCharacterLockedInVillage conditionCharacterLockedInVillage = (ConditionCharacterLockedInVillage)(conditions_ = other.CharacterLockedInVillage.Clone());
				ConditionCharacterUnlocked conditionCharacterUnlocked = (ConditionCharacterUnlocked)(conditions_ = other.CharacterUnlocked.Clone());
				ConditionCountry conditionCountry = (ConditionCountry)(conditions_ = other.Country.Clone());
				ConditionCookingRecipeKnownWith conditionCookingRecipeKnownWith = (ConditionCookingRecipeKnownWith)(conditions_ = other.CookingRecipeKnownWith.Clone());
				ConditionCookingRecipeVisible conditionCookingRecipeVisible = (ConditionCookingRecipeVisible)(conditions_ = other.CookingRecipeVisible.Clone());
				ConditionCraftingRecipeVisible conditionCraftingRecipeVisible = (ConditionCraftingRecipeVisible)(conditions_ = other.CraftingRecipeVisible.Clone());
				ConditionCurrentScene conditionCurrentScene = (ConditionCurrentScene)(conditions_ = other.CurrentScene.Clone());
				ConditionFTUEEventCompleted fTUEEventCompleted = other.FTUEEventCompleted;
				ConditionFTUEEventCompleted conditionFTUEEventCompleted = new ConditionFTUEEventCompleted();
				int num21 = (conditionFTUEEventCompleted.fTUEEvent_ = fTUEEventCompleted.fTUEEvent_);
				bool flag9 = (conditionFTUEEventCompleted.inversed_ = fTUEEventCompleted.inversed_);
				UnknownFieldSet unknownFieldSet14 = (conditionFTUEEventCompleted._unknownFields = UnknownFieldSet.Clone(fTUEEventCompleted._unknownFields));
				conditions_ = conditionFTUEEventCompleted;
				conditionsCase_ = ConditionsOneofCase.FTUEEventCompleted;
				ConditionDate conditionDate = (ConditionDate)(conditions_ = other.Date.Clone());
				ConditionDayOfWeek conditionDayOfWeek = (ConditionDayOfWeek)(conditions_ = other.DayOfWeek.Clone());
				ConditionDayOfMonth conditionDayOfMonth = (ConditionDayOfMonth)(conditions_ = other.DayOfMonth.Clone());
				ConditionTimeOfDay conditionTimeOfDay = (ConditionTimeOfDay)(conditions_ = other.TimeOfDay.Clone());
				ConditionDialogueFlag conditionDialogueFlag = (ConditionDialogueFlag)(conditions_ = other.DialogueFlag.Clone());
				ConditionHasEnoughCharactersToDiscuss hasEnoughCharactersToDiscuss = other.HasEnoughCharactersToDiscuss;
				ConditionHasEnoughCharactersToDiscuss conditionHasEnoughCharactersToDiscuss = new ConditionHasEnoughCharactersToDiscuss();
				int num22 = (conditionHasEnoughCharactersToDiscuss.minimum_ = hasEnoughCharactersToDiscuss.minimum_);
				UnknownFieldSet unknownFieldSet15 = (conditionHasEnoughCharactersToDiscuss._unknownFields = UnknownFieldSet.Clone(hasEnoughCharactersToDiscuss._unknownFields));
				conditions_ = conditionHasEnoughCharactersToDiscuss;
				conditionsCase_ = ConditionsOneofCase.HasEnoughCharactersToDiscuss;
				ConditionHasEnoughCrittersToFeed hasEnoughCrittersToFeed = other.HasEnoughCrittersToFeed;
				ConditionHasEnoughCrittersToFeed conditionHasEnoughCrittersToFeed = new ConditionHasEnoughCrittersToFeed();
				int num23 = (conditionHasEnoughCrittersToFeed.minimum_ = hasEnoughCrittersToFeed.minimum_);
				UnknownFieldSet unknownFieldSet16 = (conditionHasEnoughCrittersToFeed._unknownFields = UnknownFieldSet.Clone(hasEnoughCrittersToFeed._unknownFields));
				conditions_ = conditionHasEnoughCrittersToFeed;
				conditionsCase_ = ConditionsOneofCase.HasEnoughCrittersToFeed;
				ConditionHasEnoughDriedFlowers hasEnoughDriedFlowers = other.HasEnoughDriedFlowers;
				ConditionHasEnoughDriedFlowers conditionHasEnoughDriedFlowers = new ConditionHasEnoughDriedFlowers();
				int num24 = (conditionHasEnoughDriedFlowers.minimum_ = hasEnoughDriedFlowers.minimum_);
				UnknownFieldSet unknownFieldSet17 = (conditionHasEnoughDriedFlowers._unknownFields = UnknownFieldSet.Clone(hasEnoughDriedFlowers._unknownFields));
				conditions_ = conditionHasEnoughDriedFlowers;
				conditionsCase_ = ConditionsOneofCase.HasEnoughDriedFlowers;
				ConditionHasEnoughNightThorns hasEnoughNightThorns = other.HasEnoughNightThorns;
				ConditionHasEnoughNightThorns conditionHasEnoughNightThorns = new ConditionHasEnoughNightThorns();
				int num25 = (conditionHasEnoughNightThorns.minimum_ = hasEnoughNightThorns.minimum_);
				UnknownFieldSet unknownFieldSet18 = (conditionHasEnoughNightThorns._unknownFields = UnknownFieldSet.Clone(hasEnoughNightThorns._unknownFields));
				conditions_ = conditionHasEnoughNightThorns;
				conditionsCase_ = ConditionsOneofCase.HasEnoughNightThorns;
				ConditionHasEnoughRestaurantOrders hasEnoughRestaurantOrders = other.HasEnoughRestaurantOrders;
				ConditionHasEnoughRestaurantOrders conditionHasEnoughRestaurantOrders = new ConditionHasEnoughRestaurantOrders();
				int num26 = (conditionHasEnoughRestaurantOrders.minimum_ = hasEnoughRestaurantOrders.minimum_);
				UnknownFieldSet unknownFieldSet19 = (conditionHasEnoughRestaurantOrders._unknownFields = UnknownFieldSet.Clone(hasEnoughRestaurantOrders._unknownFields));
				conditions_ = conditionHasEnoughRestaurantOrders;
				conditionsCase_ = ConditionsOneofCase.HasEnoughRestaurantOrders;
				ConditionInventory inventory = other.Inventory;
				ConditionInventory conditionInventory = new ConditionInventory();
				int num27 = (conditionInventory.item_ = inventory.item_);
				IntOperator intOperator4 = (conditionInventory.operator_ = inventory.operator_);
				int num28 = (conditionInventory.amount_ = inventory.amount_);
				UnknownFieldSet unknownFieldSet20 = (conditionInventory._unknownFields = UnknownFieldSet.Clone(inventory._unknownFields));
				conditions_ = conditionInventory;
				conditionsCase_ = ConditionsOneofCase.Inventory;
			}
			ConditionIsFTUE isFTUE = other.IsFTUE;
			ConditionIsFTUE conditionIsFTUE = default(ConditionIsFTUE);
			conditionIsFTUE.lastFTUE = (Item)typeof(Item).TypeHandle;
			bool flag10 = (conditionIsFTUE.inversed_ = isFTUE.inversed_);
			UnknownFieldSet unknownFieldSet21 = (conditionIsFTUE._unknownFields = UnknownFieldSet.Clone(isFTUE._unknownFields));
			conditions_ = conditionIsFTUE;
			conditionsCase_ = ConditionsOneofCase.IsFTUE;
			ConditionCommon conditionCommon = (ConditionCommon)(conditions_ = other.CommonConditions.Clone());
			ConditionsList conditionsList = (ConditionsList)(conditions_ = other.SubConditions.Clone());
			ConditionAlwaysTrue conditionAlwaysTrue = (ConditionAlwaysTrue)(conditions_ = other.AlwaysTrue.Clone());
			ConditionAlwaysFalse conditionAlwaysFalse = (ConditionAlwaysFalse)(conditions_ = other.AlwaysFalse.Clone());
			ConditionAreaUnlocked conditionAreaUnlocked = (ConditionAreaUnlocked)(conditions_ = other.AreaUnlocked.Clone());
			ConditionBuildingUnlocked buildingUnlocked = other.BuildingUnlocked;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005595")]
		[Cpp2IlInjected.Address(RVA = "0x2086840", Offset = "0x2085240", VA = "0x182086840", Slot = "17")]
		[DebuggerNonUserCode]
		public ConditionOneOf Clone()
		{
			return new ConditionOneOf(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60055F7")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearConditions()
		{
			//IL_0010: Expected O, but got I4
			conditions_ = (conditionsCase_ = ConditionsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60055F8")]
		[Cpp2IlInjected.Address(RVA = "0x2087420", Offset = "0x2085E20", VA = "0x182087420", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ConditionOneOf)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60055F9")]
		[Cpp2IlInjected.Address(RVA = "0x2086AE0", Offset = "0x20854E0", VA = "0x182086AE0", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionOneOf other)
		{
			//IL_0053: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
				{
					object obj = conditions_;
					if (obj != null && obj == null)
					{
						goto IL_062b;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.conditionsCase_ == ConditionsOneofCase.CommonConditions)
				{
					obj2 = other.conditions_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					ConditionsList subConditions = SubConditions;
					ConditionsList subConditions2 = other.SubConditions;
					if (object.Equals(subConditions, subConditions2))
					{
						ConditionAlwaysTrue alwaysTrue = AlwaysTrue;
						ConditionAlwaysTrue alwaysTrue2 = other.AlwaysTrue;
						if (object.Equals(alwaysTrue, alwaysTrue2))
						{
							ConditionAlwaysFalse alwaysFalse = AlwaysFalse;
							ConditionAlwaysFalse alwaysFalse2 = other.AlwaysFalse;
							if (object.Equals(alwaysFalse, alwaysFalse2))
							{
								ConditionAreaUnlocked areaUnlocked = AreaUnlocked;
								ConditionAreaUnlocked areaUnlocked2 = other.AreaUnlocked;
								if (object.Equals(areaUnlocked, areaUnlocked2))
								{
									ConditionBuildingUnlocked buildingUnlocked = BuildingUnlocked;
									ConditionBuildingUnlocked buildingUnlocked2 = other.BuildingUnlocked;
									if (object.Equals(buildingUnlocked, buildingUnlocked2))
									{
										ConditionCharacterFriendship characterFriendship = CharacterFriendship;
										ConditionCharacterFriendship characterFriendship2 = other.CharacterFriendship;
										if (object.Equals(characterFriendship, characterFriendship2))
										{
											ConditionCharacterLockedInVillage characterLockedInVillage = CharacterLockedInVillage;
											ConditionCharacterLockedInVillage characterLockedInVillage2 = other.CharacterLockedInVillage;
											if (object.Equals(characterLockedInVillage, characterLockedInVillage2))
											{
												ConditionCharacterUnlocked characterUnlocked = CharacterUnlocked;
												ConditionCharacterUnlocked characterUnlocked2 = other.CharacterUnlocked;
												if (object.Equals(characterUnlocked, characterUnlocked2))
												{
													ConditionCountry country = Country;
													ConditionCountry country2 = other.Country;
													if (object.Equals(country, country2))
													{
														ConditionCookingRecipeKnownWith cookingRecipeKnownWith = CookingRecipeKnownWith;
														ConditionCookingRecipeKnownWith cookingRecipeKnownWith2 = other.CookingRecipeKnownWith;
														if (object.Equals(cookingRecipeKnownWith, cookingRecipeKnownWith2))
														{
															ConditionCookingRecipeVisible cookingRecipeVisible = CookingRecipeVisible;
															ConditionCookingRecipeVisible cookingRecipeVisible2 = other.CookingRecipeVisible;
															if (object.Equals(cookingRecipeVisible, cookingRecipeVisible2))
															{
																ConditionCraftingRecipeVisible craftingRecipeVisible = CraftingRecipeVisible;
																ConditionCraftingRecipeVisible craftingRecipeVisible2 = other.CraftingRecipeVisible;
																if (object.Equals(craftingRecipeVisible, craftingRecipeVisible2))
																{
																	ConditionCurrentScene currentScene = CurrentScene;
																	ConditionCurrentScene currentScene2 = other.CurrentScene;
																	if (object.Equals(currentScene, currentScene2))
																	{
																		ConditionFTUEEventCompleted fTUEEventCompleted = FTUEEventCompleted;
																		ConditionFTUEEventCompleted fTUEEventCompleted2 = other.FTUEEventCompleted;
																		if (object.Equals(fTUEEventCompleted, fTUEEventCompleted2))
																		{
																			ConditionDate date = Date;
																			ConditionDate date2 = other.Date;
																			if (object.Equals(date, date2))
																			{
																				ConditionDayOfWeek dayOfWeek = DayOfWeek;
																				ConditionDayOfWeek dayOfWeek2 = other.DayOfWeek;
																				if (object.Equals(dayOfWeek, dayOfWeek2))
																				{
																					ConditionDayOfMonth dayOfMonth = DayOfMonth;
																					ConditionDayOfMonth dayOfMonth2 = other.DayOfMonth;
																					if (object.Equals(dayOfMonth, dayOfMonth2))
																					{
																						ConditionTimeOfDay timeOfDay = TimeOfDay;
																						ConditionTimeOfDay timeOfDay2 = other.TimeOfDay;
																						if (object.Equals(timeOfDay, timeOfDay2))
																						{
																							ConditionDialogueFlag dialogueFlag = DialogueFlag;
																							ConditionDialogueFlag dialogueFlag2 = other.DialogueFlag;
																							if (object.Equals(dialogueFlag, dialogueFlag2))
																							{
																								ConditionHasEnoughCharactersToDiscuss hasEnoughCharactersToDiscuss = HasEnoughCharactersToDiscuss;
																								ConditionHasEnoughCharactersToDiscuss hasEnoughCharactersToDiscuss2 = other.HasEnoughCharactersToDiscuss;
																								if (object.Equals(hasEnoughCharactersToDiscuss, hasEnoughCharactersToDiscuss2))
																								{
																									ConditionHasEnoughCrittersToFeed hasEnoughCrittersToFeed = HasEnoughCrittersToFeed;
																									ConditionHasEnoughCrittersToFeed hasEnoughCrittersToFeed2 = other.HasEnoughCrittersToFeed;
																									if (object.Equals(hasEnoughCrittersToFeed, hasEnoughCrittersToFeed2))
																									{
																										ConditionHasEnoughDriedFlowers hasEnoughDriedFlowers = HasEnoughDriedFlowers;
																										ConditionHasEnoughDriedFlowers hasEnoughDriedFlowers2 = other.HasEnoughDriedFlowers;
																										if (object.Equals(hasEnoughDriedFlowers, hasEnoughDriedFlowers2))
																										{
																											ConditionHasEnoughNightThorns hasEnoughNightThorns = HasEnoughNightThorns;
																											ConditionHasEnoughNightThorns hasEnoughNightThorns2 = other.HasEnoughNightThorns;
																											if (object.Equals(hasEnoughNightThorns, hasEnoughNightThorns2))
																											{
																												ConditionHasEnoughRestaurantOrders hasEnoughRestaurantOrders = HasEnoughRestaurantOrders;
																												ConditionHasEnoughRestaurantOrders hasEnoughRestaurantOrders2 = other.HasEnoughRestaurantOrders;
																												if (object.Equals(hasEnoughRestaurantOrders, hasEnoughRestaurantOrders2))
																												{
																													ConditionInventory inventory = Inventory;
																													ConditionInventory inventory2 = other.Inventory;
																													if (object.Equals(inventory, inventory2))
																													{
																														ConditionIsFTUE isFTUE = IsFTUE;
																														ConditionIsFTUE isFTUE2 = other.IsFTUE;
																														if (object.Equals(isFTUE, isFTUE2))
																														{
																															ConditionIsHangingOut isHangingOut = IsHangingOut;
																															ConditionIsHangingOut isHangingOut2 = other.IsHangingOut;
																															if (object.Equals(isHangingOut, isHangingOut2))
																															{
																																ConditionKeyholeStatus keyholeStatus = KeyholeStatus;
																																ConditionKeyholeStatus keyholeStatus2 = other.KeyholeStatus;
																																if (object.Equals(keyholeStatus, keyholeStatus2))
																																{
																																	ConditionManaHasAlreadyMissed manaHasAlreadyMissed = ManaHasAlreadyMissed;
																																	ConditionManaHasAlreadyMissed manaHasAlreadyMissed2 = other.ManaHasAlreadyMissed;
																																	if (object.Equals(manaHasAlreadyMissed, manaHasAlreadyMissed2))
																																	{
																																		ConditionMemoryShard memoryShard = MemoryShard;
																																		ConditionMemoryShard memoryShard2 = other.MemoryShard;
																																		if (object.Equals(memoryShard, memoryShard2))
																																		{
																																			ConditionMissionAvailable missionAvailable = MissionAvailable;
																																			ConditionMissionAvailable missionAvailable2 = other.MissionAvailable;
																																			if (object.Equals(missionAvailable, missionAvailable2))
																																			{
																																				ConditionMissionCompleted missionCompleted = MissionCompleted;
																																				ConditionMissionCompleted missionCompleted2 = other.MissionCompleted;
																																				if (object.Equals(missionCompleted, missionCompleted2))
																																				{
																																					ConditionMissionOngoing missionOngoing = MissionOngoing;
																																					ConditionMissionOngoing missionOngoing2 = other.MissionOngoing;
																																					if (object.Equals(missionOngoing, missionOngoing2))
																																					{
																																						ConditionMissionStatus missionStatus = MissionStatus;
																																						ConditionMissionStatus missionStatus2 = other.MissionStatus;
																																						if (object.Equals(missionStatus, missionStatus2))
																																						{
																																							ConditionMissionTypeStatus missionTypeStatus = MissionTypeStatus;
																																							ConditionMissionTypeStatus missionTypeStatus2 = other.MissionTypeStatus;
																																							if (object.Equals(missionTypeStatus, missionTypeStatus2))
																																							{
																																								ConditionMissionStepCompleted missionStepCompleted = MissionStepCompleted;
																																								ConditionMissionStepCompleted missionStepCompleted2 = other.MissionStepCompleted;
																																								if (object.Equals(missionStepCompleted, missionStepCompleted2))
																																								{
																																									ConditionMissionStepStatus missionStepStatus = MissionStepStatus;
																																									ConditionMissionStepStatus missionStepStatus2 = other.MissionStepStatus;
																																									if (object.Equals(missionStepStatus, missionStepStatus2))
																																									{
																																										ConditionMissionObjectiveCompleted missionObjectiveCompleted = MissionObjectiveCompleted;
																																										ConditionMissionObjectiveCompleted missionObjectiveCompleted2 = other.MissionObjectiveCompleted;
																																										if (object.Equals(missionObjectiveCompleted, missionObjectiveCompleted2))
																																										{
																																											ConditionMissionObjectiveStatus missionObjectiveStatus = MissionObjectiveStatus;
																																											ConditionMissionObjectiveStatus missionObjectiveStatus2 = other.MissionObjectiveStatus;
																																											if (object.Equals(missionObjectiveStatus, missionObjectiveStatus2))
																																											{
																																												ConditionPlatform platform = Platform;
																																												ConditionPlatform platform2 = other.Platform;
																																												if (object.Equals(platform, platform2))
																																												{
																																													ConditionPlayerLevel playerLevel = PlayerLevel;
																																													ConditionPlayerLevel playerLevel2 = other.PlayerLevel;
																																													if (object.Equals(playerLevel, playerLevel2))
																																													{
																																														ConditionRealmUnlocked realmUnlocked = RealmUnlocked;
																																														ConditionRealmUnlocked realmUnlocked2 = other.RealmUnlocked;
																																														if (object.Equals(realmUnlocked, realmUnlocked2))
																																														{
																																															ConditionTimer timer = Timer;
																																															ConditionTimer timer2 = other.Timer;
																																															if (object.Equals(timer, timer2))
																																															{
																																																ConditionTimestamp timestamp = Timestamp;
																																																ConditionTimestamp timestamp2 = other.Timestamp;
																																																if (object.Equals(timestamp, timestamp2))
																																																{
																																																	ConditionToolUnlocked toolUnlocked = ToolUnlocked;
																																																	ConditionToolUnlocked toolUnlocked2 = other.ToolUnlocked;
																																																	if (object.Equals(toolUnlocked, toolUnlocked2))
																																																	{
																																																		ConditionWearingClothes wearingClothes = WearingClothes;
																																																		ConditionWearingClothes wearingClothes2 = other.WearingClothes;
																																																		if (object.Equals(wearingClothes, wearingClothes2))
																																																		{
																																																			ConditionWeather weather = Weather;
																																																			ConditionWeather weather2 = other.Weather;
																																																			if (object.Equals(weather, weather2))
																																																			{
																																																				ConditionsOneofCase conditionsOneofCase = other.conditionsCase_;
																																																				if (conditionsCase_ == conditionsOneofCase)
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
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_062b;
			IL_062b:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60055FA")]
		[Cpp2IlInjected.Address(RVA = "0x2087920", Offset = "0x2086320", VA = "0x182087920", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0700
			object obj47;
			while (true)
			{
				ConditionsOneofCase conditionsOneofCase = conditionsCase_;
				int num = 0;
				if (conditionsOneofCase == ConditionsOneofCase.CommonConditions)
				{
					object obj = conditions_;
					if (obj == null)
					{
						continue;
					}
					int hashCode = obj.GetHashCode();
				}
				if (conditionsOneofCase != ConditionsOneofCase.SubConditions)
				{
					continue;
				}
				object obj2 = conditions_;
				if (obj2 == null)
				{
					continue;
				}
				int hashCode2 = obj2.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.AlwaysTrue)
				{
					continue;
				}
				object obj3 = conditions_;
				if (obj3 == null)
				{
					continue;
				}
				int hashCode3 = obj3.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.AlwaysFalse)
				{
					continue;
				}
				object obj4 = conditions_;
				if (obj4 == null)
				{
					continue;
				}
				int hashCode4 = obj4.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.AreaUnlocked)
				{
					continue;
				}
				object obj5 = conditions_;
				if (obj5 == null)
				{
					continue;
				}
				int hashCode5 = obj5.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.BuildingUnlocked)
				{
					continue;
				}
				object obj6 = conditions_;
				if (obj6 == null)
				{
					continue;
				}
				int hashCode6 = obj6.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.CharacterFriendship)
				{
					continue;
				}
				object obj7 = conditions_;
				if (obj7 == null)
				{
					continue;
				}
				int hashCode7 = obj7.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.CharacterLockedInVillage)
				{
					continue;
				}
				object obj8 = conditions_;
				if (obj8 == null)
				{
					continue;
				}
				int hashCode8 = obj8.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.CharacterUnlocked)
				{
					continue;
				}
				object obj9 = conditions_;
				if (obj9 == null)
				{
					continue;
				}
				int hashCode9 = obj9.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.Country)
				{
					continue;
				}
				object obj10 = conditions_;
				if (obj10 == null)
				{
					continue;
				}
				int hashCode10 = obj10.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.CookingRecipeKnownWith)
				{
					continue;
				}
				object obj11 = conditions_;
				if (obj11 == null)
				{
					continue;
				}
				int hashCode11 = obj11.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.CookingRecipeVisible)
				{
					continue;
				}
				object obj12 = conditions_;
				if (obj12 == null)
				{
					continue;
				}
				int hashCode12 = obj12.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.CraftingRecipeVisible)
				{
					continue;
				}
				object obj13 = conditions_;
				if (obj13 == null)
				{
					continue;
				}
				int hashCode13 = obj13.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.CurrentScene)
				{
					continue;
				}
				object obj14 = conditions_;
				if (obj14 == null)
				{
					continue;
				}
				int hashCode14 = obj14.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.FTUEEventCompleted)
				{
					continue;
				}
				object obj15 = conditions_;
				if (obj15 == null)
				{
					continue;
				}
				int hashCode15 = obj15.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.Date)
				{
					continue;
				}
				object obj16 = conditions_;
				if (obj16 == null)
				{
					continue;
				}
				int hashCode16 = obj16.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.DayOfWeek)
				{
					continue;
				}
				object obj17 = conditions_;
				if (obj17 == null)
				{
					continue;
				}
				int hashCode17 = obj17.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.DayOfMonth)
				{
					continue;
				}
				object obj18 = conditions_;
				if (obj18 == null)
				{
					continue;
				}
				int hashCode18 = obj18.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.TimeOfDay)
				{
					continue;
				}
				object obj19 = conditions_;
				if (obj19 == null)
				{
					continue;
				}
				int hashCode19 = obj19.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.DialogueFlag)
				{
					continue;
				}
				object obj20 = conditions_;
				if (obj20 == null)
				{
					continue;
				}
				int hashCode20 = obj20.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughCharactersToDiscuss)
				{
					continue;
				}
				object obj21 = conditions_;
				if (obj21 == null)
				{
					continue;
				}
				int hashCode21 = obj21.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughCrittersToFeed)
				{
					continue;
				}
				object obj22 = conditions_;
				if (obj22 == null)
				{
					continue;
				}
				int hashCode22 = obj22.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughDriedFlowers)
				{
					continue;
				}
				object obj23 = conditions_;
				if (obj23 == null)
				{
					continue;
				}
				int hashCode23 = obj23.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughNightThorns)
				{
					continue;
				}
				object obj24 = conditions_;
				if (obj24 == null)
				{
					continue;
				}
				int hashCode24 = obj24.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughRestaurantOrders)
				{
					continue;
				}
				object obj25 = conditions_;
				if (obj25 == null)
				{
					continue;
				}
				int hashCode25 = obj25.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.Inventory)
				{
					continue;
				}
				object obj26 = conditions_;
				if (obj26 == null)
				{
					continue;
				}
				int hashCode26 = obj26.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.IsFTUE)
				{
					continue;
				}
				object obj27 = conditions_;
				if (obj27 == null)
				{
					continue;
				}
				int hashCode27 = obj27.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.IsHangingOut)
				{
					continue;
				}
				object obj28 = conditions_;
				if (obj28 == null)
				{
					continue;
				}
				int hashCode28 = obj28.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.KeyholeStatus)
				{
					continue;
				}
				object obj29 = conditions_;
				if (obj29 == null)
				{
					continue;
				}
				int hashCode29 = obj29.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.ManaHasAlreadyMissed)
				{
					continue;
				}
				object obj30 = conditions_;
				if (obj30 == null)
				{
					continue;
				}
				int hashCode30 = obj30.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MemoryShard)
				{
					continue;
				}
				object obj31 = conditions_;
				if (obj31 == null)
				{
					continue;
				}
				int hashCode31 = obj31.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MissionAvailable)
				{
					continue;
				}
				object obj32 = conditions_;
				if (obj32 == null)
				{
					continue;
				}
				int hashCode32 = obj32.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MissionCompleted)
				{
					continue;
				}
				object obj33 = conditions_;
				if (obj33 == null)
				{
					continue;
				}
				int hashCode33 = obj33.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MissionOngoing)
				{
					continue;
				}
				object obj34 = conditions_;
				if (obj34 == null)
				{
					continue;
				}
				int hashCode34 = obj34.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MissionStatus)
				{
					continue;
				}
				object obj35 = conditions_;
				if (obj35 == null)
				{
					continue;
				}
				int hashCode35 = obj35.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MissionTypeStatus)
				{
					continue;
				}
				object obj36 = conditions_;
				if (obj36 == null)
				{
					continue;
				}
				int hashCode36 = obj36.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MissionStepCompleted)
				{
					continue;
				}
				object obj37 = conditions_;
				if (obj37 == null)
				{
					continue;
				}
				int hashCode37 = obj37.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MissionStepStatus)
				{
					continue;
				}
				object obj38 = conditions_;
				if (obj38 == null)
				{
					continue;
				}
				int hashCode38 = obj38.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MissionObjectiveCompleted)
				{
					continue;
				}
				object obj39 = conditions_;
				if (obj39 == null)
				{
					continue;
				}
				int hashCode39 = obj39.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.MissionObjectiveStatus)
				{
					continue;
				}
				object obj40 = conditions_;
				if (obj40 == null)
				{
					continue;
				}
				int hashCode40 = obj40.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.Platform)
				{
					continue;
				}
				object obj41 = conditions_;
				if (obj41 == null)
				{
					continue;
				}
				int hashCode41 = obj41.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.PlayerLevel)
				{
					continue;
				}
				object obj42 = conditions_;
				if (obj42 == null)
				{
					continue;
				}
				int hashCode42 = obj42.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.RealmUnlocked)
				{
					continue;
				}
				object obj43 = conditions_;
				if (obj43 == null)
				{
					continue;
				}
				int hashCode43 = obj43.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.Timer)
				{
					continue;
				}
				object obj44 = conditions_;
				if (obj44 == null)
				{
					continue;
				}
				int hashCode44 = obj44.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.Timestamp)
				{
					continue;
				}
				object obj45 = conditions_;
				if (obj45 == null)
				{
					continue;
				}
				int hashCode45 = obj45.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.ToolUnlocked)
				{
					continue;
				}
				object obj46 = conditions_;
				if (obj46 == null)
				{
					continue;
				}
				int hashCode46 = obj46.GetHashCode();
				if (conditionsCase_ != ConditionsOneofCase.WearingClothes || conditions_ != null)
				{
					obj47 = conditions_;
					if (obj47 != null)
					{
						break;
					}
				}
			}
			int hashCode47 = obj47.GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode48 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60055FB")]
		[Cpp2IlInjected.Address(RVA = "0x208EE50", Offset = "0x208D850", VA = "0x18208EE50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60055FC")]
		[Cpp2IlInjected.Address(RVA = "0x208EEB0", Offset = "0x208D8B0", VA = "0x18208EEB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//IL_002c: Expected O, but got I4
			while (true)
			{
				ConditionsOneofCase conditionsOneofCase = conditionsCase_;
				int num = 0;
				if (conditionsOneofCase == ConditionsOneofCase.CommonConditions)
				{
					if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
					{
						object obj = conditions_;
						if (obj != null && obj == null)
						{
							continue;
						}
					}
					output.WriteMessage((IMessage)num);
				}
				if (conditionsOneofCase != ConditionsOneofCase.SubConditions)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.SubConditions)
				{
					object obj2 = conditions_;
					if (obj2 != null && obj2 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.AlwaysTrue)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.AlwaysTrue)
				{
					object obj3 = conditions_;
					if (obj3 != null && obj3 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.AlwaysFalse)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.AlwaysFalse)
				{
					object obj4 = conditions_;
					if (obj4 != null && obj4 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.AreaUnlocked)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.AreaUnlocked)
				{
					object obj5 = conditions_;
					if (obj5 != null && obj5 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.BuildingUnlocked)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.BuildingUnlocked)
				{
					object obj6 = conditions_;
					if (obj6 != null && obj6 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.CharacterFriendship)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.CharacterFriendship)
				{
					object obj7 = conditions_;
					if (obj7 != null && obj7 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.CharacterLockedInVillage)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.CharacterLockedInVillage)
				{
					object obj8 = conditions_;
					if (obj8 != null && obj8 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.CharacterUnlocked)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.CharacterUnlocked)
				{
					object obj9 = conditions_;
					if (obj9 != null && obj9 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.Country)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.Country)
				{
					object obj10 = conditions_;
					if (obj10 != null && obj10 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.CookingRecipeKnownWith)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.CookingRecipeKnownWith)
				{
					object obj11 = conditions_;
					if (obj11 != null && obj11 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.CookingRecipeVisible)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.CookingRecipeVisible)
				{
					object obj12 = conditions_;
					if (obj12 != null && obj12 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.CraftingRecipeVisible)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.CraftingRecipeVisible)
				{
					object obj13 = conditions_;
					if (obj13 != null && obj13 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.CurrentScene)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.CurrentScene)
				{
					object obj14 = conditions_;
					if (obj14 != null && obj14 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.FTUEEventCompleted)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.FTUEEventCompleted)
				{
					object obj15 = conditions_;
					if (obj15 != null && obj15 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.Date)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.Date)
				{
					object obj16 = conditions_;
					if (obj16 != null && obj16 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.DayOfWeek)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.DayOfWeek)
				{
					object obj17 = conditions_;
					if (obj17 != null && obj17 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.DayOfMonth)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.DayOfMonth)
				{
					object obj18 = conditions_;
					if (obj18 != null && obj18 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.TimeOfDay)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.TimeOfDay)
				{
					object obj19 = conditions_;
					if (obj19 != null && obj19 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.DialogueFlag)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.DialogueFlag)
				{
					object obj20 = conditions_;
					if (obj20 != null && obj20 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughCharactersToDiscuss)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughCharactersToDiscuss)
				{
					object obj21 = conditions_;
					if (obj21 != null && obj21 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughCrittersToFeed)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughCrittersToFeed)
				{
					object obj22 = conditions_;
					if (obj22 != null && obj22 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughDriedFlowers)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughDriedFlowers)
				{
					object obj23 = conditions_;
					if (obj23 != null && obj23 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughNightThorns)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughNightThorns)
				{
					object obj24 = conditions_;
					if (obj24 != null && obj24 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughRestaurantOrders)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughRestaurantOrders)
				{
					object obj25 = conditions_;
					if (obj25 != null && obj25 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.Inventory)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.Inventory)
				{
					object obj26 = conditions_;
					if (obj26 != null && obj26 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.IsFTUE)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.IsFTUE)
				{
					object obj27 = conditions_;
					if (obj27 != null && obj27 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.IsHangingOut)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.IsHangingOut)
				{
					object obj28 = conditions_;
					if (obj28 != null && obj28 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.KeyholeStatus)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.KeyholeStatus)
				{
					object obj29 = conditions_;
					if (obj29 != null && obj29 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.ManaHasAlreadyMissed)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.ManaHasAlreadyMissed)
				{
					object obj30 = conditions_;
					if (obj30 != null && obj30 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MemoryShard)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MemoryShard)
				{
					object obj31 = conditions_;
					if (obj31 != null && obj31 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MissionAvailable)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionAvailable)
				{
					object obj32 = conditions_;
					if (obj32 != null && obj32 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MissionCompleted)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionCompleted)
				{
					object obj33 = conditions_;
					if (obj33 != null && obj33 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MissionOngoing)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionOngoing)
				{
					object obj34 = conditions_;
					if (obj34 != null && obj34 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MissionStatus)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionStatus)
				{
					object obj35 = conditions_;
					if (obj35 != null && obj35 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MissionTypeStatus)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionTypeStatus)
				{
					object obj36 = conditions_;
					if (obj36 != null && obj36 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MissionStepCompleted)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionStepCompleted)
				{
					object obj37 = conditions_;
					if (obj37 != null && obj37 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MissionStepStatus)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionStepStatus)
				{
					object obj38 = conditions_;
					if (obj38 != null && obj38 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MissionObjectiveCompleted)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionObjectiveCompleted)
				{
					object obj39 = conditions_;
					if (obj39 != null && obj39 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.MissionObjectiveStatus)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionObjectiveStatus)
				{
					object obj40 = conditions_;
					if (obj40 != null && obj40 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.Platform)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.Platform)
				{
					object obj41 = conditions_;
					if (obj41 != null && obj41 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.PlayerLevel)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.PlayerLevel)
				{
					object obj42 = conditions_;
					if (obj42 != null && obj42 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.RealmUnlocked)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.RealmUnlocked)
				{
					object obj43 = conditions_;
					if (obj43 != null && obj43 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ != ConditionsOneofCase.Timer)
				{
					continue;
				}
				if (conditionsCase_ == ConditionsOneofCase.Timer)
				{
					object obj44 = conditions_;
					if (obj44 != null && obj44 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ == ConditionsOneofCase.Timestamp)
				{
					/*Error: Could not find block for branch target IL_0786*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60055FD")]
		[Cpp2IlInjected.Address(RVA = "0x2084CD0", Offset = "0x20836D0", VA = "0x182084CD0", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			int num16 = default(int);
			int num17 = default(int);
			int num18 = default(int);
			int num19 = default(int);
			int num20 = default(int);
			int num21 = default(int);
			int num22 = default(int);
			int num23 = default(int);
			int num24 = default(int);
			int num25 = default(int);
			int num26 = default(int);
			int num27 = default(int);
			int num28 = default(int);
			int num29 = default(int);
			int num30 = default(int);
			int num31 = default(int);
			int num32 = default(int);
			int num33 = default(int);
			int num34 = default(int);
			int num35 = default(int);
			int num36 = default(int);
			int num37 = default(int);
			int num38 = default(int);
			int num39 = default(int);
			int num40 = default(int);
			int num41 = default(int);
			int num42 = default(int);
			int num43 = default(int);
			int num44 = default(int);
			int num45 = default(int);
			int num46 = default(int);
			int num;
			while (true)
			{
				num = 0;
				if (conditionsCase_ == ConditionsOneofCase.CommonConditions)
				{
					if (conditionsCase_ != ConditionsOneofCase.CommonConditions)
					{
					}
					object obj = conditions_;
					if (obj != null && obj == null)
					{
						continue;
					}
				}
				if (conditionsCase_ == ConditionsOneofCase.SubConditions)
				{
					if (conditionsCase_ != ConditionsOneofCase.SubConditions)
					{
					}
					object obj2 = conditions_;
					if (obj2 != null && obj2 == null)
					{
						continue;
					}
					num++;
					num += num2;
				}
				if (conditionsCase_ == ConditionsOneofCase.AlwaysTrue)
				{
					if (conditionsCase_ != ConditionsOneofCase.AlwaysTrue)
					{
					}
					object obj3 = conditions_;
					if (obj3 != null && obj3 == null)
					{
						continue;
					}
					num++;
					num += num3;
				}
				if (conditionsCase_ == ConditionsOneofCase.AlwaysFalse)
				{
					if (conditionsCase_ != ConditionsOneofCase.AlwaysFalse)
					{
					}
					object obj4 = conditions_;
					if (obj4 != null && obj4 == null)
					{
						continue;
					}
					num++;
					num += num4;
				}
				if (conditionsCase_ == ConditionsOneofCase.AreaUnlocked)
				{
					if (conditionsCase_ != ConditionsOneofCase.AreaUnlocked)
					{
					}
					object obj5 = conditions_;
					if (obj5 != null && obj5 == null)
					{
						continue;
					}
					num++;
					num += num5;
				}
				if (conditionsCase_ == ConditionsOneofCase.BuildingUnlocked)
				{
					if (conditionsCase_ != ConditionsOneofCase.BuildingUnlocked)
					{
					}
					object obj6 = conditions_;
					if (obj6 != null && obj6 == null)
					{
						continue;
					}
					num += 2;
					num += num6;
				}
				if (conditionsCase_ == ConditionsOneofCase.CharacterFriendship)
				{
					if (conditionsCase_ != ConditionsOneofCase.CharacterFriendship)
					{
					}
					object obj7 = conditions_;
					if (obj7 != null && obj7 == null)
					{
						continue;
					}
					num += 2;
					num += num7;
				}
				if (conditionsCase_ == ConditionsOneofCase.CharacterLockedInVillage)
				{
					if (conditionsCase_ != ConditionsOneofCase.CharacterLockedInVillage)
					{
					}
					object obj8 = conditions_;
					if (obj8 != null && obj8 == null)
					{
						continue;
					}
					num += 2;
					num += num8;
				}
				if (conditionsCase_ == ConditionsOneofCase.CharacterUnlocked)
				{
					if (conditionsCase_ != ConditionsOneofCase.CharacterUnlocked)
					{
					}
					object obj9 = conditions_;
					if (obj9 != null && obj9 == null)
					{
						continue;
					}
					num += 2;
					num += num9;
				}
				if (conditionsCase_ == ConditionsOneofCase.Country)
				{
					if (conditionsCase_ != ConditionsOneofCase.Country)
					{
					}
					object obj10 = conditions_;
					if (obj10 != null && obj10 == null)
					{
						continue;
					}
					num += 2;
					num += num10;
				}
				if (conditionsCase_ == ConditionsOneofCase.CookingRecipeKnownWith)
				{
					if (conditionsCase_ != ConditionsOneofCase.CookingRecipeKnownWith)
					{
					}
					object obj11 = conditions_;
					if (obj11 != null && obj11 == null)
					{
						continue;
					}
					num += 2;
					num += num11;
				}
				if (conditionsCase_ == ConditionsOneofCase.CookingRecipeVisible)
				{
					if (conditionsCase_ != ConditionsOneofCase.CookingRecipeVisible)
					{
					}
					object obj12 = conditions_;
					if (obj12 != null && obj12 == null)
					{
						continue;
					}
					num += 2;
					num += num12;
				}
				if (conditionsCase_ == ConditionsOneofCase.CraftingRecipeVisible)
				{
					if (conditionsCase_ != ConditionsOneofCase.CraftingRecipeVisible)
					{
					}
					object obj13 = conditions_;
					if (obj13 != null && obj13 == null)
					{
						continue;
					}
					num += 2;
					num += num13;
				}
				if (conditionsCase_ == ConditionsOneofCase.CurrentScene)
				{
					if (conditionsCase_ != ConditionsOneofCase.CurrentScene)
					{
					}
					object obj14 = conditions_;
					if (obj14 != null && obj14 == null)
					{
						continue;
					}
					num += 2;
					num += num14;
				}
				if (conditionsCase_ == ConditionsOneofCase.FTUEEventCompleted)
				{
					if (conditionsCase_ != ConditionsOneofCase.FTUEEventCompleted)
					{
					}
					object obj15 = conditions_;
					if (obj15 != null && obj15 == null)
					{
						continue;
					}
					num += 2;
					num += num15;
				}
				if (conditionsCase_ == ConditionsOneofCase.Date)
				{
					if (conditionsCase_ != ConditionsOneofCase.Date)
					{
					}
					object obj16 = conditions_;
					if (obj16 != null && obj16 == null)
					{
						continue;
					}
					num += 2;
					num += num16;
				}
				if (conditionsCase_ == ConditionsOneofCase.DayOfWeek)
				{
					if (conditionsCase_ != ConditionsOneofCase.DayOfWeek)
					{
					}
					object obj17 = conditions_;
					if (obj17 != null && obj17 == null)
					{
						continue;
					}
					num += 2;
					num += num17;
				}
				if (conditionsCase_ == ConditionsOneofCase.DayOfMonth)
				{
					if (conditionsCase_ != ConditionsOneofCase.DayOfMonth)
					{
					}
					object obj18 = conditions_;
					if (obj18 != null && obj18 == null)
					{
						continue;
					}
					num += 2;
					num += num18;
				}
				if (conditionsCase_ == ConditionsOneofCase.TimeOfDay)
				{
					if (conditionsCase_ != ConditionsOneofCase.TimeOfDay)
					{
					}
					object obj19 = conditions_;
					if (obj19 != null && obj19 == null)
					{
						continue;
					}
					num += 2;
					num += num19;
				}
				if (conditionsCase_ == ConditionsOneofCase.DialogueFlag)
				{
					if (conditionsCase_ != ConditionsOneofCase.DialogueFlag)
					{
					}
					object obj20 = conditions_;
					if (obj20 != null && obj20 == null)
					{
						continue;
					}
					num += 2;
					num += num20;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughCharactersToDiscuss)
				{
					if (conditionsCase_ != ConditionsOneofCase.HasEnoughCharactersToDiscuss)
					{
					}
					object obj21 = conditions_;
					if (obj21 != null && obj21 == null)
					{
						continue;
					}
					num += 2;
					num += num21;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughCrittersToFeed)
				{
					if (conditionsCase_ != ConditionsOneofCase.HasEnoughCrittersToFeed)
					{
					}
					object obj22 = conditions_;
					if (obj22 != null && obj22 == null)
					{
						continue;
					}
					num += 2;
					num += num22;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughDriedFlowers)
				{
					if (conditionsCase_ != ConditionsOneofCase.HasEnoughDriedFlowers)
					{
					}
					object obj23 = conditions_;
					if (obj23 != null && obj23 == null)
					{
						continue;
					}
					num += 2;
					num += num23;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughNightThorns)
				{
					if (conditionsCase_ != ConditionsOneofCase.HasEnoughNightThorns)
					{
					}
					object obj24 = conditions_;
					if (obj24 != null && obj24 == null)
					{
						continue;
					}
					num += 2;
					num += num24;
				}
				if (conditionsCase_ == ConditionsOneofCase.HasEnoughRestaurantOrders)
				{
					if (conditionsCase_ != ConditionsOneofCase.HasEnoughRestaurantOrders)
					{
					}
					object obj25 = conditions_;
					if (obj25 != null && obj25 == null)
					{
						continue;
					}
					num += 2;
					num += num25;
				}
				if (conditionsCase_ == ConditionsOneofCase.Inventory)
				{
					if (conditionsCase_ != ConditionsOneofCase.Inventory)
					{
					}
					object obj26 = conditions_;
					if (obj26 != null && obj26 == null)
					{
						continue;
					}
					num += 2;
					num += num26;
				}
				if (conditionsCase_ == ConditionsOneofCase.IsFTUE)
				{
					if (conditionsCase_ != ConditionsOneofCase.IsFTUE)
					{
					}
					object obj27 = conditions_;
					if (obj27 != null && obj27 == null)
					{
						continue;
					}
					num += 2;
					num += num27;
				}
				if (conditionsCase_ == ConditionsOneofCase.IsHangingOut)
				{
					if (conditionsCase_ != ConditionsOneofCase.IsHangingOut)
					{
					}
					object obj28 = conditions_;
					if (obj28 != null && obj28 == null)
					{
						continue;
					}
					num += 2;
					num += num28;
				}
				if (conditionsCase_ == ConditionsOneofCase.KeyholeStatus)
				{
					if (conditionsCase_ != ConditionsOneofCase.KeyholeStatus)
					{
					}
					object obj29 = conditions_;
					if (obj29 != null && obj29 == null)
					{
						continue;
					}
					num += 2;
					num += num29;
				}
				if (conditionsCase_ == ConditionsOneofCase.ManaHasAlreadyMissed)
				{
					if (conditionsCase_ != ConditionsOneofCase.ManaHasAlreadyMissed)
					{
					}
					object obj30 = conditions_;
					if (obj30 != null && obj30 == null)
					{
						continue;
					}
					num += 2;
					num += num30;
				}
				if (conditionsCase_ == ConditionsOneofCase.MemoryShard)
				{
					if (conditionsCase_ != ConditionsOneofCase.MemoryShard)
					{
					}
					object obj31 = conditions_;
					if (obj31 != null && obj31 == null)
					{
						continue;
					}
					num += 2;
					num += num31;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionAvailable)
				{
					if (conditionsCase_ != ConditionsOneofCase.MissionAvailable)
					{
					}
					object obj32 = conditions_;
					if (obj32 != null && obj32 == null)
					{
						continue;
					}
					num += 2;
					num += num32;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionCompleted)
				{
					if (conditionsCase_ != ConditionsOneofCase.MissionCompleted)
					{
					}
					object obj33 = conditions_;
					if (obj33 != null && obj33 == null)
					{
						continue;
					}
					num += 2;
					num += num33;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionOngoing)
				{
					if (conditionsCase_ != ConditionsOneofCase.MissionOngoing)
					{
					}
					object obj34 = conditions_;
					if (obj34 != null && obj34 == null)
					{
						continue;
					}
					num += 2;
					num += num34;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionStatus)
				{
					if (conditionsCase_ != ConditionsOneofCase.MissionStatus)
					{
					}
					object obj35 = conditions_;
					if (obj35 != null && obj35 == null)
					{
						continue;
					}
					num += 2;
					num += num35;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionTypeStatus)
				{
					if (conditionsCase_ != ConditionsOneofCase.MissionTypeStatus)
					{
					}
					object obj36 = conditions_;
					if (obj36 != null && obj36 == null)
					{
						continue;
					}
					num += 2;
					num += num36;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionStepCompleted)
				{
					if (conditionsCase_ != ConditionsOneofCase.MissionStepCompleted)
					{
					}
					object obj37 = conditions_;
					if (obj37 != null && obj37 == null)
					{
						continue;
					}
					num += 2;
					num += num37;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionStepStatus)
				{
					if (conditionsCase_ != ConditionsOneofCase.MissionStepStatus)
					{
					}
					object obj38 = conditions_;
					if (obj38 != null && obj38 == null)
					{
						continue;
					}
					num += 2;
					num += num38;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionObjectiveCompleted)
				{
					if (conditionsCase_ != ConditionsOneofCase.MissionObjectiveCompleted)
					{
					}
					object obj39 = conditions_;
					if (obj39 != null && obj39 == null)
					{
						continue;
					}
					num += 2;
					num += num39;
				}
				if (conditionsCase_ == ConditionsOneofCase.MissionObjectiveStatus)
				{
					if (conditionsCase_ != ConditionsOneofCase.MissionObjectiveStatus)
					{
					}
					object obj40 = conditions_;
					if (obj40 != null && obj40 == null)
					{
						continue;
					}
				}
				if (conditionsCase_ == ConditionsOneofCase.Platform)
				{
					if (conditionsCase_ != ConditionsOneofCase.Platform)
					{
					}
					object obj41 = conditions_;
					if (obj41 != null && obj41 == null)
					{
						continue;
					}
					num += 2;
					num += num40;
				}
				if (conditionsCase_ == ConditionsOneofCase.PlayerLevel)
				{
					if (conditionsCase_ != ConditionsOneofCase.PlayerLevel)
					{
					}
					object obj42 = conditions_;
					if (obj42 != null && obj42 == null)
					{
						continue;
					}
					num += 2;
					num += num41;
				}
				if (conditionsCase_ == ConditionsOneofCase.RealmUnlocked)
				{
					if (conditionsCase_ != ConditionsOneofCase.RealmUnlocked)
					{
					}
					object obj43 = conditions_;
					if (obj43 != null && obj43 == null)
					{
						continue;
					}
					num += 2;
					num += num42;
				}
				if (conditionsCase_ == ConditionsOneofCase.Timer)
				{
					if (conditionsCase_ != ConditionsOneofCase.Timer)
					{
					}
					object obj44 = conditions_;
					if (obj44 != null && obj44 == null)
					{
						continue;
					}
					num += 2;
					num += num43;
				}
				if (conditionsCase_ == ConditionsOneofCase.Timestamp)
				{
					if (conditionsCase_ != ConditionsOneofCase.Timestamp)
					{
					}
					object obj45 = conditions_;
					if (obj45 != null && obj45 == null)
					{
						continue;
					}
					num += 2;
					num += num44;
				}
				if (conditionsCase_ == ConditionsOneofCase.ToolUnlocked)
				{
					if (conditionsCase_ != ConditionsOneofCase.ToolUnlocked)
					{
					}
					object obj46 = conditions_;
					if (obj46 != null && obj46 == null)
					{
						continue;
					}
					num += 2;
					num += num45;
				}
				if (conditionsCase_ != ConditionsOneofCase.WearingClothes)
				{
					break;
				}
				if (conditionsCase_ != ConditionsOneofCase.WearingClothes)
				{
				}
				object obj47 = conditions_;
				if (obj47 == null || obj47 != null)
				{
					num += 2;
					num += num46;
					break;
				}
			}
			if (conditionsCase_ == ConditionsOneofCase.Weather)
			{
				if (conditionsCase_ == ConditionsOneofCase.Weather)
				{
					object obj48 = conditions_;
					if (obj48 != null && obj48 == null)
					{
						throw new InvalidCastException();
					}
				}
				num += 2;
				int num47 = default(int);
				num += num47;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num48 = unknownFields.CalculateSize();
				num += num48;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60055FE")]
		[Cpp2IlInjected.Address(RVA = "0x2089020", Offset = "0x2087A20", VA = "0x182089020", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionOneOf other)
		{
			//Discarded unreachable code: IL_03b1, IL_03ba, IL_03d1, IL_03e7, IL_03fe, IL_0406, IL_040b, IL_0419, IL_0422, IL_0430, IL_0439, IL_0442, IL_0447, IL_0459, IL_0470
			//IL_004b: Expected I4, but got O
			//IL_008b: Expected I4, but got O
			//IL_00c9: Expected I4, but got O
			//IL_010c: Expected I4, but got O
			//IL_0145: Expected I4, but got O
			//IL_017e: Expected I4, but got O
			//IL_01b7: Expected I4, but got O
			//IL_01fd: Expected I4, but got O
			//IL_023e: Expected I4, but got O
			//IL_0285: Expected I4, but got O
			//IL_02b5: Expected I4, but got O
			//IL_02e5: Expected I4, but got O
			//IL_0315: Expected I4, but got O
			//IL_03d1: Expected I4, but got O
			//IL_03fe: Expected I4, but got O
			//IL_0470: Expected I4, but got O
			//IL_0498: Expected I4, but got O
			//IL_04e7: Expected I4, but got O
			//IL_0530: Expected I4, but got O
			//IL_0558: Expected I4, but got O
			//IL_05b9: Expected I4, but got O
			//IL_0600: Expected I4, but got O
			//IL_062d: Expected I4, but got O
			//IL_065a: Expected I4, but got O
			//IL_0687: Expected I4, but got O
			//IL_06b4: Expected I4, but got O
			//IL_06e1: Expected I4, but got O
			//IL_070e: Expected I4, but got O
			//IL_073b: Expected I4, but got O
			//IL_0796: Expected I4, but got O
			//IL_07c3: Expected I4, but got O
			//IL_07f0: Expected I4, but got O
			//IL_081d: Expected I4, but got O
			//IL_084a: Expected I4, but got O
			//IL_0877: Expected I4, but got O
			ConditionMissionObjectiveCompleted missionObjectiveCompleted = default(ConditionMissionObjectiveCompleted);
			ConditionMissionObjectiveCompleted other2 = default(ConditionMissionObjectiveCompleted);
			ConditionManaHasAlreadyMissed conditionManaHasAlreadyMissed = default(ConditionManaHasAlreadyMissed);
			bool inversed_ = default(bool);
			ConditionIsHangingOut conditionIsHangingOut = default(ConditionIsHangingOut);
			ConditionKeyholeStatus keyholeStatus = default(ConditionKeyholeStatus);
			ConditionKeyholeStatus conditionKeyholeStatus = default(ConditionKeyholeStatus);
			do
			{
				if (other == null)
				{
					return;
				}
				ConditionsOneofCase conditionsOneofCase = other.conditionsCase_;
				if (conditionsOneofCase > ConditionsOneofCase.MemoryShard)
				{
					if (conditionsOneofCase > ConditionsOneofCase.Platform)
					{
						if (conditionsOneofCase > ConditionsOneofCase.ToolUnlocked)
						{
							if (conditionsOneofCase == ConditionsOneofCase.WearingClothes)
							{
								if (WearingClothes == null)
								{
									conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionWearingClothes());
								}
								ConditionWearingClothes wearingClothes = WearingClothes;
								ConditionWearingClothes wearingClothes2 = other.WearingClothes;
								wearingClothes.MergeFrom(wearingClothes2);
							}
							if (conditionsOneofCase != ConditionsOneofCase.Weather)
							{
								goto IL_0391;
							}
							if (Weather == null)
							{
								conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionWeather());
							}
							ConditionWeather weather = Weather;
							ConditionWeather weather2 = other.Weather;
							weather.MergeFrom(weather2);
						}
						if (conditionsOneofCase == ConditionsOneofCase.PlayerLevel)
						{
							if (PlayerLevel == null)
							{
								conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionPlayerLevel());
							}
							ConditionPlayerLevel playerLevel = PlayerLevel;
							ConditionPlayerLevel playerLevel2 = other.PlayerLevel;
							playerLevel.MergeFrom(playerLevel2);
						}
						if (conditionsOneofCase > ConditionsOneofCase.CommonConditions)
						{
							goto IL_0391;
						}
						int num = (int)conditionsOneofCase;
						if (RealmUnlocked == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionRealmUnlocked());
						}
						ConditionRealmUnlocked realmUnlocked = RealmUnlocked;
						ConditionRealmUnlocked realmUnlocked2 = other.RealmUnlocked;
						realmUnlocked.MergeFrom(realmUnlocked2);
						if (Timer == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionTimer());
						}
						ConditionTimer timer = Timer;
						ConditionTimer timer2 = other.Timer;
						timer.MergeFrom(timer2);
						if (Timestamp == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionTimestamp());
						}
						ConditionTimestamp timestamp = Timestamp;
						ConditionTimestamp timestamp2 = other.Timestamp;
						timestamp.MergeFrom(timestamp2);
						if (ToolUnlocked == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionToolUnlocked());
						}
						ConditionToolUnlocked toolUnlocked = ToolUnlocked;
						ConditionToolUnlocked toolUnlocked2 = other.ToolUnlocked;
						toolUnlocked.MergeFrom(toolUnlocked2);
					}
					if (conditionsOneofCase > ConditionsOneofCase.MissionObjectiveCompleted)
					{
						if (conditionsOneofCase == ConditionsOneofCase.MissionObjectiveStatus)
						{
							if (MissionObjectiveStatus == null)
							{
								conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMissionObjectiveStatus());
							}
							ConditionMissionObjectiveStatus missionObjectiveStatus = MissionObjectiveStatus;
							ConditionMissionObjectiveStatus missionObjectiveStatus2 = other.MissionObjectiveStatus;
							missionObjectiveStatus.MergeFrom(missionObjectiveStatus2);
						}
						if (conditionsOneofCase != ConditionsOneofCase.Platform)
						{
							goto IL_0391;
						}
						if (Platform == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionPlatform());
						}
						ConditionPlatform platform = Platform;
						ConditionPlatform platform2 = other.Platform;
						platform.MergeFrom(platform2);
					}
					if ((long)typeof(ConditionsList).TypeHandle <= 12)
					{
						if (MissionAvailable == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMissionAvailable());
						}
						ConditionMissionAvailable missionAvailable = MissionAvailable;
						ConditionMissionAvailable missionAvailable2 = other.MissionAvailable;
						if (MissionCompleted == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMissionCompleted());
						}
						ConditionMissionCompleted missionCompleted = MissionCompleted;
						ConditionMissionCompleted missionCompleted2 = other.MissionCompleted;
						if (MissionOngoing == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMissionOngoing());
						}
						ConditionMissionOngoing missionOngoing = MissionOngoing;
						ConditionMissionOngoing missionOngoing2 = other.MissionOngoing;
						if (MissionStatus == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMissionStatus());
						}
						ConditionMissionStatus missionStatus = MissionStatus;
						ConditionMissionStatus missionStatus2 = other.MissionStatus;
						if (missionStatus2 != null)
						{
							int mission_ = missionStatus2.mission_;
							if (mission_ != 0)
							{
								missionStatus.mission_ = mission_;
							}
							IntOperator operator_ = missionStatus2.operator_;
							if (operator_ != 0)
							{
								missionStatus.operator_ = operator_;
							}
							MissionState state_ = missionStatus2.state_;
							if (state_ != 0)
							{
								missionStatus.state_ = state_;
							}
							UnknownFieldSet unknownFields = missionStatus2._unknownFields;
							UnknownFieldSet unknownFieldSet = (missionStatus._unknownFields = UnknownFieldSet.MergeFrom(missionStatus._unknownFields, unknownFields));
						}
						goto IL_0391;
					}
					if (MissionObjectiveCompleted == null)
					{
						conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMissionObjectiveCompleted());
					}
					missionObjectiveCompleted = MissionObjectiveCompleted;
					missionObjectiveCompleted.MergeFrom(other2);
				}
				if ((long)missionObjectiveCompleted <= 65)
				{
					continue;
				}
				if ((long)missionObjectiveCompleted > 78)
				{
					if ((long)missionObjectiveCompleted == 80)
					{
						if (ManaHasAlreadyMissed == null)
						{
							conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionManaHasAlreadyMissed());
						}
						ConditionManaHasAlreadyMissed manaHasAlreadyMissed = ManaHasAlreadyMissed;
						while (conditionManaHasAlreadyMissed == null)
						{
						}
						inversed_ = conditionManaHasAlreadyMissed.inversed_;
						while (!inversed_)
						{
						}
						manaHasAlreadyMissed.inversed_ = inversed_;
					}
					while (!inversed_)
					{
					}
					if (MemoryShard == null)
					{
						conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionMemoryShard());
					}
					ConditionMemoryShard memoryShard = MemoryShard;
				}
				if (IsHangingOut == null)
				{
					conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionIsHangingOut());
				}
				ConditionIsHangingOut isHangingOut = IsHangingOut;
				while (conditionIsHangingOut == null)
				{
				}
				bool inversed_2 = conditionIsHangingOut.inversed_;
				if (inversed_2)
				{
					isHangingOut.inversed_ = inversed_2;
				}
				int character_ = conditionIsHangingOut.character_;
				while (character_ == 0)
				{
				}
				isHangingOut.character_ = character_;
				while (character_ != 78)
				{
				}
				if (KeyholeStatus == null)
				{
					conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionKeyholeStatus());
				}
				keyholeStatus = KeyholeStatus;
				keyholeStatus.MergeFrom(conditionKeyholeStatus);
				continue;
				IL_0391:
				UnknownFieldSet unknownFields2 = other._unknownFields;
				UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
				return;
			}
			while ((long)keyholeStatus <= 20 || (long)conditionKeyholeStatus > 36);
			if (CharacterLockedInVillage == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionCharacterLockedInVillage());
			}
			ConditionCharacterLockedInVillage other3 = default(ConditionCharacterLockedInVillage);
			CharacterLockedInVillage.MergeFrom(other3);
			if (CharacterUnlocked == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionCharacterUnlocked());
			}
			ConditionCharacterUnlocked other4 = default(ConditionCharacterUnlocked);
			CharacterUnlocked.MergeFrom(other4);
			if (Country == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionCountry());
			}
			ConditionCountry other5 = default(ConditionCountry);
			Country.MergeFrom(other5);
			if (CookingRecipeKnownWith == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionCookingRecipeKnownWith());
			}
			ConditionCookingRecipeKnownWith other6 = default(ConditionCookingRecipeKnownWith);
			CookingRecipeKnownWith.MergeFrom(other6);
			if (CookingRecipeVisible == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionCookingRecipeVisible());
			}
			ConditionCookingRecipeVisible other7 = default(ConditionCookingRecipeVisible);
			CookingRecipeVisible.MergeFrom(other7);
			if (CraftingRecipeVisible == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionCraftingRecipeVisible());
			}
			ConditionCraftingRecipeVisible other8 = default(ConditionCraftingRecipeVisible);
			CraftingRecipeVisible.MergeFrom(other8);
			if (CurrentScene == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionCurrentScene());
			}
			ConditionCurrentScene other9 = default(ConditionCurrentScene);
			CurrentScene.MergeFrom(other9);
			if (FTUEEventCompleted == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionFTUEEventCompleted());
			}
			ConditionFTUEEventCompleted fTUEEventCompleted = FTUEEventCompleted;
			ConditionFTUEEventCompleted conditionFTUEEventCompleted = default(ConditionFTUEEventCompleted);
			while (conditionFTUEEventCompleted == null)
			{
			}
			int fTUEEvent_ = conditionFTUEEventCompleted.fTUEEvent_;
			if (fTUEEvent_ != 0)
			{
				fTUEEventCompleted.fTUEEvent_ = fTUEEvent_;
			}
			bool inversed_3 = conditionFTUEEventCompleted.inversed_;
			while (!inversed_3)
			{
			}
			fTUEEventCompleted.inversed_ = inversed_3;
			if (Date == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionDate());
			}
			ConditionDate other10 = default(ConditionDate);
			Date.MergeFrom(other10);
			if (DayOfWeek == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionDayOfWeek());
			}
			ConditionDayOfWeek other11 = default(ConditionDayOfWeek);
			DayOfWeek.MergeFrom(other11);
			if (DayOfMonth == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionDayOfMonth());
			}
			ConditionDayOfMonth other12 = default(ConditionDayOfMonth);
			DayOfMonth.MergeFrom(other12);
			if (TimeOfDay == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionTimeOfDay());
			}
			ConditionTimeOfDay other13 = default(ConditionTimeOfDay);
			TimeOfDay.MergeFrom(other13);
			if (DialogueFlag == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionDialogueFlag());
			}
			ConditionDialogueFlag other14 = default(ConditionDialogueFlag);
			DialogueFlag.MergeFrom(other14);
			if (HasEnoughCharactersToDiscuss == null)
			{
				conditionsCase_ = (ConditionsOneofCase)(conditions_ = new ConditionHasEnoughCharactersToDiscuss());
			}
			ConditionHasEnoughCharactersToDiscuss hasEnoughCharactersToDiscuss = HasEnoughCharactersToDiscuss;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60055FF")]
		[Cpp2IlInjected.Address(RVA = "0x208AAB0", Offset = "0x20894B0", VA = "0x18208AAB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0078: Expected I4, but got O
			//IL_00ba: Expected I4, but got O
			//IL_0105: Expected I4, but got O
			//IL_0148: Expected I4, but got O
			//IL_018d: Expected I4, but got O
			//IL_01d5: Expected I4, but got O
			//IL_0224: Expected I4, but got O
			//IL_0269: Expected I4, but got O
			//IL_02b1: Expected I4, but got O
			//IL_02f6: Expected I4, but got O
			//IL_033b: Expected I4, but got O
			//IL_0383: Expected I4, but got O
			//IL_03de: Expected I4, but got O
			//IL_0423: Expected I4, but got O
			//IL_046b: Expected I4, but got O
			//IL_04c5: Expected I4, but got O
			//IL_04d9: Expected I4, but got O
			//IL_04ed: Expected I4, but got O
			//IL_0517: Expected I4, but got O
			//IL_056e: Expected I4, but got O
			//IL_0582: Expected I4, but got O
			//IL_05ac: Expected I4, but got O
			//IL_0603: Expected I4, but got O
			//IL_0617: Expected I4, but got O
			//IL_0641: Expected I4, but got O
			//IL_06a6: Expected I4, but got O
			//IL_06ba: Expected I4, but got O
			//IL_06e4: Expected I4, but got O
			//IL_073a: Expected I4, but got O
			//IL_0794: Expected I4, but got O
			//IL_07be: Expected I4, but got O
			//IL_0815: Expected I4, but got O
			//IL_083f: Expected I4, but got O
			//IL_0899: Expected I4, but got O
			//IL_08ad: Expected I4, but got O
			//IL_08c1: Expected I4, but got O
			//IL_08eb: Expected I4, but got O
			//IL_0942: Expected I4, but got O
			//IL_096c: Expected I4, but got O
			//IL_09e5: Expected I4, but got O
			//IL_0a0f: Expected I4, but got O
			//IL_0a66: Expected I4, but got O
			//IL_0a90: Expected I4, but got O
			ConditionWearingClothes wearingClothes = default(ConditionWearingClothes);
			ConditionWeather weather = default(ConditionWeather);
			ConditionRealmUnlocked realmUnlocked = default(ConditionRealmUnlocked);
			ConditionTimer timer = default(ConditionTimer);
			ConditionTimestamp timestamp = default(ConditionTimestamp);
			ConditionMissionObjectiveStatus missionObjectiveStatus = default(ConditionMissionObjectiveStatus);
			ConditionPlatform platform = default(ConditionPlatform);
			ConditionPlayerLevel playerLevel = default(ConditionPlayerLevel);
			ConditionMissionStepCompleted missionStepCompleted = default(ConditionMissionStepCompleted);
			ConditionMissionStepStatus missionStepStatus = default(ConditionMissionStepStatus);
			ConditionMissionObjectiveCompleted missionObjectiveCompleted = default(ConditionMissionObjectiveCompleted);
			ConditionMissionOngoing missionOngoing = default(ConditionMissionOngoing);
			ConditionMissionStatus missionStatus = default(ConditionMissionStatus);
			ConditionMissionTypeStatus missionTypeStatus = default(ConditionMissionTypeStatus);
			UnknownFieldSet unknownFieldSet = default(UnknownFieldSet);
			UnknownFieldSet unknownFieldSet2 = default(UnknownFieldSet);
			UnknownFieldSet unknownFieldSet3 = default(UnknownFieldSet);
			UnknownFieldSet unknownFieldSet4 = default(UnknownFieldSet);
			UnknownFieldSet unknownFieldSet5 = default(UnknownFieldSet);
			UnknownFieldSet unknownFieldSet6 = default(UnknownFieldSet);
			UnknownFieldSet unknownFieldSet7 = default(UnknownFieldSet);
			UnknownFieldSet unknownFieldSet8 = default(UnknownFieldSet);
			UnknownFieldSet unknownFieldSet9 = default(UnknownFieldSet);
			ConditionHasEnoughDriedFlowers conditionHasEnoughDriedFlowers;
			UnknownFieldSet unknownFieldSet10 = default(UnknownFieldSet);
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					continue;
				}
				if ((int)num > 474)
				{
					if ((int)num > 778)
					{
						if ((int)num > 922)
						{
							if ((int)num > 986)
							{
								if (num == 1002)
								{
									ConditionToolUnlocked conditionToolUnlocked = new ConditionToolUnlocked();
									if (conditionsCase_ == ConditionsOneofCase.ToolUnlocked)
									{
										ConditionToolUnlocked toolUnlocked = ToolUnlocked;
										conditionToolUnlocked.MergeFrom(toolUnlocked);
									}
									input.ReadMessage(conditionToolUnlocked);
									conditions_ = conditionToolUnlocked;
									conditionsCase_ = (ConditionsOneofCase)conditionToolUnlocked;
								}
								if (num == 1042)
								{
									ConditionWearingClothes conditionWearingClothes = new ConditionWearingClothes();
									if (conditionsCase_ == ConditionsOneofCase.WearingClothes)
									{
										wearingClothes = WearingClothes;
										conditionWearingClothes.MergeFrom(wearingClothes);
									}
									input.ReadMessage(conditionWearingClothes);
									conditions_ = conditionWearingClothes;
									conditionsCase_ = (ConditionsOneofCase)wearingClothes;
								}
								if ((long)wearingClothes != 1082)
								{
									continue;
								}
								ConditionWeather conditionWeather = new ConditionWeather();
								if (conditionsCase_ == ConditionsOneofCase.Weather)
								{
									weather = Weather;
									conditionWeather.MergeFrom(weather);
								}
								input.ReadMessage(conditionWeather);
								conditions_ = conditionWeather;
								conditionsCase_ = (ConditionsOneofCase)weather;
							}
							if (num == 962)
							{
								ConditionRealmUnlocked conditionRealmUnlocked = new ConditionRealmUnlocked();
								if (conditionsCase_ == ConditionsOneofCase.RealmUnlocked)
								{
									realmUnlocked = RealmUnlocked;
									conditionRealmUnlocked.MergeFrom(realmUnlocked);
								}
								input.ReadMessage(conditionRealmUnlocked);
								conditions_ = conditionRealmUnlocked;
								conditionsCase_ = (ConditionsOneofCase)realmUnlocked;
							}
							if ((long)realmUnlocked == 978)
							{
								ConditionTimer conditionTimer = new ConditionTimer();
								if (conditionsCase_ == ConditionsOneofCase.Timer)
								{
									timer = Timer;
									conditionTimer.MergeFrom(timer);
								}
								input.ReadMessage(conditionTimer);
								conditions_ = conditionTimer;
								conditionsCase_ = (ConditionsOneofCase)timer;
							}
							if ((long)timer != 986)
							{
								continue;
							}
							ConditionTimestamp conditionTimestamp = new ConditionTimestamp();
							if (conditionsCase_ == ConditionsOneofCase.Timestamp)
							{
								timestamp = Timestamp;
								conditionTimestamp.MergeFrom(timestamp);
							}
							input.ReadMessage(conditionTimestamp);
							conditions_ = conditionTimestamp;
							conditionsCase_ = (ConditionsOneofCase)timestamp;
						}
						if ((int)num > 842)
						{
							if (num == 850)
							{
								ConditionMissionObjectiveStatus conditionMissionObjectiveStatus = new ConditionMissionObjectiveStatus();
								if (conditionsCase_ == ConditionsOneofCase.MissionObjectiveStatus)
								{
									missionObjectiveStatus = MissionObjectiveStatus;
									conditionMissionObjectiveStatus.MergeFrom(missionObjectiveStatus);
								}
								input.ReadMessage(conditionMissionObjectiveStatus);
								conditions_ = conditionMissionObjectiveStatus;
								conditionsCase_ = (ConditionsOneofCase)missionObjectiveStatus;
							}
							if ((long)missionObjectiveStatus == 882)
							{
								ConditionPlatform conditionPlatform = new ConditionPlatform();
								if (conditionsCase_ == ConditionsOneofCase.Platform)
								{
									platform = Platform;
									conditionPlatform.MergeFrom(platform);
								}
								input.ReadMessage(conditionPlatform);
								conditions_ = conditionPlatform;
								conditionsCase_ = (ConditionsOneofCase)platform;
							}
							if ((long)platform != 922)
							{
								continue;
							}
							ConditionPlayerLevel conditionPlayerLevel = new ConditionPlayerLevel();
							if (conditionsCase_ == ConditionsOneofCase.PlayerLevel)
							{
								playerLevel = PlayerLevel;
								conditionPlayerLevel.MergeFrom(playerLevel);
							}
							input.ReadMessage(conditionPlayerLevel);
							conditions_ = conditionPlayerLevel;
							conditionsCase_ = (ConditionsOneofCase)playerLevel;
						}
						if ((long)playerLevel == 802)
						{
							ConditionMissionStepCompleted conditionMissionStepCompleted = new ConditionMissionStepCompleted();
							if (conditionsCase_ == ConditionsOneofCase.MissionStepCompleted)
							{
								missionStepCompleted = MissionStepCompleted;
								conditionMissionStepCompleted.MergeFrom(missionStepCompleted);
							}
							input.ReadMessage(conditionMissionStepCompleted);
							conditions_ = conditionMissionStepCompleted;
							conditionsCase_ = (ConditionsOneofCase)missionStepCompleted;
						}
						if ((long)missionStepCompleted == 810)
						{
							ConditionMissionStepStatus conditionMissionStepStatus = new ConditionMissionStepStatus();
							if (conditionsCase_ == ConditionsOneofCase.MissionStepStatus)
							{
								missionStepStatus = MissionStepStatus;
								conditionMissionStepStatus.MergeFrom(missionStepStatus);
							}
							input.ReadMessage(conditionMissionStepStatus);
							conditions_ = conditionMissionStepStatus;
							conditionsCase_ = (ConditionsOneofCase)missionStepStatus;
						}
						if ((long)missionStepStatus != 842)
						{
							continue;
						}
						ConditionMissionObjectiveCompleted conditionMissionObjectiveCompleted = new ConditionMissionObjectiveCompleted();
						if (conditionsCase_ == ConditionsOneofCase.MissionObjectiveCompleted)
						{
							missionObjectiveCompleted = MissionObjectiveCompleted;
							conditionMissionObjectiveCompleted.MergeFrom(missionObjectiveCompleted);
						}
						input.ReadMessage(conditionMissionObjectiveCompleted);
						conditions_ = conditionMissionObjectiveCompleted;
						conditionsCase_ = (ConditionsOneofCase)missionObjectiveCompleted;
					}
					if ((int)num > 642)
					{
						if ((int)num > 722)
						{
							if (num == 762)
							{
								ConditionMissionOngoing conditionMissionOngoing = new ConditionMissionOngoing();
								if (conditionsCase_ == ConditionsOneofCase.MissionOngoing)
								{
									missionOngoing = MissionOngoing;
									conditionMissionOngoing.MergeFrom(missionOngoing);
								}
								input.ReadMessage(conditionMissionOngoing);
								conditions_ = conditionMissionOngoing;
								conditionsCase_ = (ConditionsOneofCase)missionOngoing;
							}
							if ((long)missionOngoing == 770)
							{
								ConditionMissionStatus conditionMissionStatus = new ConditionMissionStatus();
								if (conditionsCase_ == ConditionsOneofCase.MissionStatus)
								{
									missionStatus = MissionStatus;
									conditionMissionStatus.MergeFrom(missionStatus);
								}
								input.ReadMessage(conditionMissionStatus);
								conditions_ = conditionMissionStatus;
								conditionsCase_ = (ConditionsOneofCase)missionStatus;
							}
							if ((long)missionStatus != 778)
							{
								continue;
							}
							ConditionMissionTypeStatus conditionMissionTypeStatus = new ConditionMissionTypeStatus();
							if (conditionsCase_ == ConditionsOneofCase.MissionTypeStatus)
							{
								missionTypeStatus = MissionTypeStatus;
								conditionMissionTypeStatus.MergeFrom(missionTypeStatus);
							}
							input.ReadMessage(conditionMissionTypeStatus);
							conditions_ = conditionMissionTypeStatus;
							conditionsCase_ = (ConditionsOneofCase)missionTypeStatus;
						}
						if ((long)missionTypeStatus == 682)
						{
							ConditionMemoryShard conditionMemoryShard = new ConditionMemoryShard();
							if (conditionsCase_ == ConditionsOneofCase.MemoryShard)
							{
								if (conditionsCase_ != ConditionsOneofCase.MemoryShard)
								{
								}
								object obj = conditions_;
								if (obj != null && obj == null)
								{
									continue;
								}
								if (obj != null)
								{
									if ((object)typeof(ConditionMemoryShard).TypeHandle != null)
									{
										conditionMemoryShard.shard_ = (int)typeof(ConditionMemoryShard).TypeHandle;
									}
									if ((object)typeof(ConditionMemoryShard).TypeHandle != null)
									{
										conditionMemoryShard.operator_ = (IntOperator)typeof(ConditionMemoryShard).TypeHandle;
									}
									if ((object)typeof(ConditionMemoryShard).TypeHandle != null)
									{
										conditionMemoryShard.progress_ = (int)typeof(ConditionMemoryShard).TypeHandle;
									}
									UnknownFieldSet unknownFields = conditionMemoryShard._unknownFields;
									conditionMemoryShard._unknownFields = unknownFieldSet;
								}
							}
							input.ReadMessage(conditionMemoryShard);
							conditions_ = conditionMemoryShard;
							conditionsCase_ = (ConditionsOneofCase)unknownFieldSet;
						}
						if ((long)unknownFieldSet == 714)
						{
							ConditionMissionAvailable conditionMissionAvailable = new ConditionMissionAvailable();
							if (conditionsCase_ == ConditionsOneofCase.MissionAvailable)
							{
								if (conditionsCase_ != ConditionsOneofCase.MissionAvailable)
								{
								}
								object obj2 = conditions_;
								if (obj2 != null && obj2 == null)
								{
									continue;
								}
								if (obj2 != null)
								{
									if ((object)typeof(ConditionMissionAvailable).TypeHandle != null)
									{
										conditionMissionAvailable.mission_ = (int)typeof(ConditionMissionAvailable).TypeHandle;
									}
									if ((object)typeof(ConditionMissionAvailable).TypeHandle != null)
									{
										conditionMissionAvailable.inversed_ = (byte)(int)typeof(ConditionMissionAvailable).TypeHandle != 0;
									}
									UnknownFieldSet unknownFields2 = conditionMissionAvailable._unknownFields;
									conditionMissionAvailable._unknownFields = unknownFieldSet2;
								}
							}
							input.ReadMessage(conditionMissionAvailable);
							conditions_ = conditionMissionAvailable;
							conditionsCase_ = (ConditionsOneofCase)unknownFieldSet2;
						}
						if ((long)unknownFieldSet2 != 722)
						{
							continue;
						}
						ConditionMissionCompleted conditionMissionCompleted = new ConditionMissionCompleted();
						if (conditionsCase_ == ConditionsOneofCase.MissionCompleted)
						{
							if (conditionsCase_ != ConditionsOneofCase.MissionCompleted)
							{
							}
							object obj3 = conditions_;
							if (obj3 != null && obj3 == null)
							{
								continue;
							}
							if (obj3 != null)
							{
								if ((object)typeof(ConditionMissionCompleted).TypeHandle != null)
								{
									conditionMissionCompleted.mission_ = (int)typeof(ConditionMissionCompleted).TypeHandle;
								}
								if ((object)typeof(ConditionMissionCompleted).TypeHandle != null)
								{
									conditionMissionCompleted.inversed_ = (byte)(int)typeof(ConditionMissionCompleted).TypeHandle != 0;
								}
								UnknownFieldSet unknownFields3 = conditionMissionCompleted._unknownFields;
								conditionMissionCompleted._unknownFields = unknownFieldSet3;
							}
						}
						input.ReadMessage(conditionMissionCompleted);
						conditions_ = conditionMissionCompleted;
						conditionsCase_ = (ConditionsOneofCase)unknownFieldSet3;
					}
					if ((long)unknownFieldSet3 > 522)
					{
						if ((long)unknownFieldSet3 == 562)
						{
							ConditionIsHangingOut conditionIsHangingOut = new ConditionIsHangingOut();
							if (conditionsCase_ == ConditionsOneofCase.IsHangingOut)
							{
								if (conditionsCase_ != ConditionsOneofCase.IsHangingOut)
								{
								}
								object obj4 = conditions_;
								if (obj4 != null && obj4 == null)
								{
									continue;
								}
								if (obj4 != null)
								{
									if ((object)typeof(ConditionIsHangingOut).TypeHandle != null)
									{
										conditionIsHangingOut.inversed_ = (byte)(int)typeof(ConditionIsHangingOut).TypeHandle != 0;
									}
									if ((object)typeof(ConditionIsHangingOut).TypeHandle != null)
									{
										conditionIsHangingOut.character_ = (int)typeof(ConditionIsHangingOut).TypeHandle;
									}
									UnknownFieldSet unknownFields4 = conditionIsHangingOut._unknownFields;
									conditionIsHangingOut._unknownFields = unknownFieldSet4;
								}
							}
							input.ReadMessage(conditionIsHangingOut);
							conditions_ = conditionIsHangingOut;
							conditionsCase_ = (ConditionsOneofCase)unknownFieldSet4;
						}
						if ((long)unknownFieldSet4 == 626)
						{
							ConditionKeyholeStatus builder = new ConditionKeyholeStatus();
							if (conditionsCase_ == ConditionsOneofCase.KeyholeStatus)
							{
								if (conditionsCase_ != ConditionsOneofCase.KeyholeStatus)
								{
								}
								object obj5 = conditions_;
								if (obj5 != null && obj5 == null)
								{
									continue;
								}
							}
							input.ReadMessage(builder);
							conditions_ = builder;
							conditionsCase_ = (ConditionsOneofCase)typeof(ConditionKeyholeStatus).TypeHandle;
						}
						if ((long)typeof(ConditionKeyholeStatus).TypeHandle != 642)
						{
							continue;
						}
						ConditionManaHasAlreadyMissed conditionManaHasAlreadyMissed = new ConditionManaHasAlreadyMissed();
						if (conditionsCase_ == ConditionsOneofCase.ManaHasAlreadyMissed)
						{
							if (conditionsCase_ != ConditionsOneofCase.ManaHasAlreadyMissed)
							{
							}
							object obj6 = conditions_;
							if (obj6 != null && obj6 == null)
							{
								continue;
							}
							if (obj6 != null)
							{
								if ((object)typeof(ConditionManaHasAlreadyMissed).TypeHandle != null)
								{
									conditionManaHasAlreadyMissed.inversed_ = (byte)(int)typeof(ConditionManaHasAlreadyMissed).TypeHandle != 0;
								}
								UnknownFieldSet unknownFields5 = conditionManaHasAlreadyMissed._unknownFields;
								conditionManaHasAlreadyMissed._unknownFields = unknownFieldSet5;
							}
						}
						input.ReadMessage(conditionManaHasAlreadyMissed);
						conditions_ = conditionManaHasAlreadyMissed;
						conditionsCase_ = (ConditionsOneofCase)unknownFieldSet5;
					}
					if ((long)unknownFieldSet5 == 482)
					{
						ConditionHasEnoughRestaurantOrders conditionHasEnoughRestaurantOrders = new ConditionHasEnoughRestaurantOrders();
						if (conditionsCase_ == ConditionsOneofCase.HasEnoughRestaurantOrders)
						{
							if (conditionsCase_ != ConditionsOneofCase.HasEnoughRestaurantOrders)
							{
							}
							object obj7 = conditions_;
							if (obj7 != null && obj7 == null)
							{
								continue;
							}
							if (obj7 != null)
							{
								if ((object)typeof(ConditionHasEnoughRestaurantOrders).TypeHandle != null)
								{
									conditionHasEnoughRestaurantOrders.minimum_ = (int)typeof(ConditionHasEnoughRestaurantOrders).TypeHandle;
								}
								UnknownFieldSet unknownFields6 = conditionHasEnoughRestaurantOrders._unknownFields;
								conditionHasEnoughRestaurantOrders._unknownFields = unknownFieldSet6;
							}
						}
						input.ReadMessage(conditionHasEnoughRestaurantOrders);
						conditions_ = conditionHasEnoughRestaurantOrders;
						conditionsCase_ = (ConditionsOneofCase)unknownFieldSet6;
					}
					if ((long)unknownFieldSet6 == 490)
					{
						ConditionInventory conditionInventory = new ConditionInventory();
						if (conditionsCase_ == ConditionsOneofCase.Inventory)
						{
							if (conditionsCase_ != ConditionsOneofCase.Inventory)
							{
							}
							object obj8 = conditions_;
							if (obj8 != null && obj8 == null)
							{
								continue;
							}
							if (obj8 != null)
							{
								if ((object)typeof(ConditionInventory).TypeHandle != null)
								{
									conditionInventory.item_ = (int)typeof(ConditionInventory).TypeHandle;
								}
								if ((object)typeof(ConditionInventory).TypeHandle != null)
								{
									conditionInventory.operator_ = (IntOperator)typeof(ConditionInventory).TypeHandle;
								}
								if ((object)typeof(ConditionInventory).TypeHandle != null)
								{
									conditionInventory.amount_ = (int)typeof(ConditionInventory).TypeHandle;
								}
								UnknownFieldSet unknownFields7 = conditionInventory._unknownFields;
								conditionInventory._unknownFields = unknownFieldSet7;
							}
						}
						input.ReadMessage(conditionInventory);
						conditions_ = conditionInventory;
						conditionsCase_ = (ConditionsOneofCase)unknownFieldSet7;
					}
					if ((long)unknownFieldSet7 != 522)
					{
						continue;
					}
					ConditionIsFTUE conditionIsFTUE = new ConditionIsFTUE();
					if (conditionsCase_ == ConditionsOneofCase.IsFTUE)
					{
						if (conditionsCase_ != ConditionsOneofCase.IsFTUE)
						{
						}
						object obj9 = conditions_;
						if (obj9 != null && obj9 == null)
						{
							continue;
						}
						if (obj9 != null)
						{
							if ((object)typeof(ConditionIsFTUE).TypeHandle != null)
							{
								conditionIsFTUE.inversed_ = (byte)(int)typeof(ConditionIsFTUE).TypeHandle != 0;
							}
							UnknownFieldSet unknownFields8 = conditionIsFTUE._unknownFields;
							conditionIsFTUE._unknownFields = unknownFieldSet8;
						}
					}
					input.ReadMessage(conditionIsFTUE);
					conditions_ = conditionIsFTUE;
					conditionsCase_ = (ConditionsOneofCase)unknownFieldSet8;
				}
				if ((int)num <= 306 || (int)num <= 378 || (int)num <= 450)
				{
					continue;
				}
				if (num == 458)
				{
					ConditionHasEnoughCrittersToFeed conditionHasEnoughCrittersToFeed = new ConditionHasEnoughCrittersToFeed();
					if (conditionsCase_ == ConditionsOneofCase.HasEnoughCrittersToFeed)
					{
						if (conditionsCase_ != ConditionsOneofCase.HasEnoughCrittersToFeed)
						{
						}
						object obj10 = conditions_;
						if (obj10 != null && obj10 == null)
						{
							continue;
						}
						if (obj10 != null)
						{
							if ((object)typeof(ConditionHasEnoughCrittersToFeed).TypeHandle != null)
							{
								conditionHasEnoughCrittersToFeed.minimum_ = (int)typeof(ConditionHasEnoughCrittersToFeed).TypeHandle;
							}
							UnknownFieldSet unknownFields9 = conditionHasEnoughCrittersToFeed._unknownFields;
							conditionHasEnoughCrittersToFeed._unknownFields = unknownFieldSet9;
						}
					}
					input.ReadMessage(conditionHasEnoughCrittersToFeed);
					conditions_ = conditionHasEnoughCrittersToFeed;
					conditionsCase_ = (ConditionsOneofCase)unknownFieldSet9;
				}
				if ((long)unknownFieldSet9 != 466)
				{
					continue;
				}
				conditionHasEnoughDriedFlowers = new ConditionHasEnoughDriedFlowers();
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughDriedFlowers)
				{
					break;
				}
				if (conditionsCase_ != ConditionsOneofCase.HasEnoughDriedFlowers)
				{
				}
				object obj11 = conditions_;
				if (obj11 != null && obj11 == null)
				{
					continue;
				}
				if (obj11 != null)
				{
					if ((object)typeof(ConditionHasEnoughDriedFlowers).TypeHandle != null)
					{
						conditionHasEnoughDriedFlowers.minimum_ = (int)typeof(ConditionHasEnoughDriedFlowers).TypeHandle;
					}
					UnknownFieldSet unknownFields10 = conditionHasEnoughDriedFlowers._unknownFields;
					conditionHasEnoughDriedFlowers._unknownFields = unknownFieldSet10;
				}
				break;
			}
			input.ReadMessage(conditionHasEnoughDriedFlowers);
			conditions_ = conditionHasEnoughDriedFlowers;
			conditionsCase_ = (ConditionsOneofCase)unknownFieldSet10;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005600")]
		[Cpp2IlInjected.Address(RVA = "0x2087480", Offset = "0x2085E80", VA = "0x182087480", Slot = "18")]
		[DebuggerNonUserCode]
		public unsafe object GetFieldValue(int fieldNumber)
		{
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Expected O, but got Unknown
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Expected O, but got Unknown
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			ArgumentException ex;
			do
			{
				if (fieldNumber > 85)
				{
					if (fieldNumber > 110)
					{
						if (fieldNumber > 125)
						{
							if (fieldNumber == 130)
							{
								ConditionWearingClothes wearingClothes = WearingClothes;
							}
							if (fieldNumber != 135)
							{
								goto IL_0247;
							}
							ConditionWeather weather = Weather;
						}
						if (fieldNumber == 115)
						{
							num = 0;
							ConditionPlayerLevel playerLevel = PlayerLevel;
						}
						num += -120;
						if (num > 5)
						{
							goto IL_0247;
						}
						ConditionRealmUnlocked realmUnlocked = RealmUnlocked;
						ConditionTimer timer = Timer;
						ConditionTimestamp timestamp = Timestamp;
						ConditionToolUnlocked toolUnlocked = ToolUnlocked;
					}
					if (fieldNumber > 105)
					{
						if (fieldNumber == 106)
						{
							num2 = 0;
							ConditionMissionObjectiveStatus missionObjectiveStatus = MissionObjectiveStatus;
						}
						if (num2 != 110)
						{
							goto IL_0247;
						}
						ConditionPlatform platform = Platform;
					}
					if (-89L <= 12L)
					{
						ConditionMissionAvailable missionAvailable = MissionAvailable;
						ConditionMissionCompleted missionCompleted = MissionCompleted;
						ConditionMissionOngoing missionOngoing = MissionOngoing;
						ConditionMissionStatus missionStatus = MissionStatus;
						ConditionMissionTypeStatus missionTypeStatus = MissionTypeStatus;
						ConditionMissionStepCompleted missionStepCompleted = MissionStepCompleted;
						num3 = 0;
						ConditionMissionStepStatus missionStepStatus = MissionStepStatus;
					}
					if (num3 != 105)
					{
						goto IL_0247;
					}
					ConditionMissionObjectiveCompleted missionObjectiveCompleted = MissionObjectiveCompleted;
				}
				if (fieldNumber > 65)
				{
					if (fieldNumber > 78)
					{
						if (fieldNumber == 80)
						{
							num4 = 0;
							ConditionManaHasAlreadyMissed manaHasAlreadyMissed = ManaHasAlreadyMissed;
						}
						if (num4 != 85)
						{
							goto IL_0247;
						}
						num5 = 0;
						ConditionMemoryShard memoryShard = MemoryShard;
					}
					if (num5 == 70)
					{
						num6 = 0;
						ConditionIsHangingOut isHangingOut = IsHangingOut;
					}
					if (num6 != 78)
					{
						goto IL_0247;
					}
					num7 = 0;
					ConditionKeyholeStatus keyholeStatus = KeyholeStatus;
				}
				if (num7 > 20)
				{
					if (-25L <= 36L)
					{
						ConditionCharacterLockedInVillage characterLockedInVillage = CharacterLockedInVillage;
						ConditionCharacterUnlocked characterUnlocked = CharacterUnlocked;
						ConditionCountry country = Country;
						ConditionCookingRecipeKnownWith cookingRecipeKnownWith = CookingRecipeKnownWith;
						ConditionCookingRecipeVisible cookingRecipeVisible = CookingRecipeVisible;
						ConditionCraftingRecipeVisible craftingRecipeVisible = CraftingRecipeVisible;
						ConditionCurrentScene currentScene = CurrentScene;
						ConditionFTUEEventCompleted fTUEEventCompleted = FTUEEventCompleted;
						ConditionDate date = Date;
						ConditionDayOfWeek dayOfWeek = DayOfWeek;
						ConditionDayOfMonth dayOfMonth = DayOfMonth;
						ConditionTimeOfDay timeOfDay = TimeOfDay;
						ConditionDialogueFlag dialogueFlag = DialogueFlag;
						ConditionHasEnoughCharactersToDiscuss hasEnoughCharactersToDiscuss = HasEnoughCharactersToDiscuss;
						ConditionHasEnoughCrittersToFeed hasEnoughCrittersToFeed = HasEnoughCrittersToFeed;
						ConditionHasEnoughDriedFlowers hasEnoughDriedFlowers = HasEnoughDriedFlowers;
						ConditionHasEnoughNightThorns hasEnoughNightThorns = HasEnoughNightThorns;
						ConditionHasEnoughRestaurantOrders hasEnoughRestaurantOrders = HasEnoughRestaurantOrders;
						num8 = 0;
						ConditionInventory inventory = Inventory;
					}
					if (num8 != 65)
					{
						goto IL_0247;
					}
					num9 = 0;
					ConditionIsFTUE isFTUE = IsFTUE;
				}
				if (num9 == 5)
				{
					num10 = 0;
					ConditionCommon commonConditions = CommonConditions;
				}
				num10 += -10;
				if (num10 <= 10)
				{
					ConditionsList subConditions = SubConditions;
					ConditionAlwaysTrue alwaysTrue = AlwaysTrue;
					ConditionAlwaysFalse alwaysFalse = AlwaysFalse;
					ConditionAreaUnlocked areaUnlocked = AreaUnlocked;
					ConditionBuildingUnlocked buildingUnlocked = BuildingUnlocked;
					ConditionCharacterFriendship characterFriendship = CharacterFriendship;
				}
				goto IL_0247;
				IL_031b:
				if ((num10 <= 10 && num10 > 10) || num10 <= 10)
				{
					goto IL_032d;
				}
				goto IL_0333;
				IL_0304:
				ex = (ArgumentException)(ex + __ldftn(ConditionOneOf.GetFieldValue));
				if (num10 > 10)
				{
					goto IL_0315;
				}
				goto IL_031b;
				IL_02d9:
				if (num10 > 10)
				{
					goto IL_02df;
				}
				goto IL_02e5;
				IL_02e5:
				if (num10 <= 10)
				{
					goto IL_02eb;
				}
				goto IL_02fe;
				IL_02eb:
				ex = (ArgumentException)(object)((object)ex + (object)ex);
				if (num10 <= 10)
				{
					goto IL_0304;
				}
				if (num10 > 10)
				{
					goto IL_02fe;
				}
				goto IL_0315;
				IL_02cd:
				if (num10 > 10)
				{
					goto IL_02d3;
				}
				goto IL_02d9;
				IL_02fe:
				if (num10 > 10)
				{
					goto IL_0304;
				}
				goto IL_031b;
				IL_0333:
				if (num10 > 10)
				{
					break;
				}
				continue;
				IL_0247:
				ex = new ArgumentException("Invalid field number", "fieldNumber");
				if ((((num10 != 10 && num10 != 10) || num10 == 10) && num10 != 10) || num10 > 10)
				{
					if ((num10 <= 10 && num10 > 10) || num10 == 10)
					{
					}
					if ((((num10 <= 10 && num10 != 10) || num10 > 10) && num10 > 10) || num10 <= 10)
					{
					}
					if (((num10 <= 10 && num10 > 10) || num10 <= 10) && num10 != 10)
					{
						goto IL_032d;
					}
					if (num10 > 10)
					{
						goto IL_02cd;
					}
				}
				if (num10 <= 10)
				{
					goto IL_02cd;
				}
				goto IL_02d3;
				IL_032d:
				if (num10 <= 10)
				{
					goto IL_0333;
				}
				continue;
				IL_02d3:
				if (num10 <= 10)
				{
					goto IL_02d9;
				}
				goto IL_02df;
				IL_0315:
				if (num10 <= 10)
				{
				}
				goto IL_031b;
				IL_02df:
				if (num10 <= 10)
				{
					goto IL_02e5;
				}
				goto IL_02eb;
			}
			while (num10 > 10);
			ex = (ArgumentException)(ex + __ldftn(ConditionOneOf.GetFieldValue));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005601")]
		[Cpp2IlInjected.Address(RVA = "0x208DA80", Offset = "0x208C480", VA = "0x18208DA80", Slot = "19")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0092, IL_0096, IL_009d, IL_009e, IL_00a2, IL_00a9, IL_00aa, IL_00ae, IL_00b5, IL_0108, IL_010c, IL_0113, IL_0114, IL_0118, IL_011f, IL_0120, IL_0124, IL_012b, IL_012c, IL_0130, IL_0137, IL_0138, IL_013c, IL_0143, IL_0144, IL_0148, IL_014f, IL_01af, IL_01b3, IL_01ba, IL_01dc, IL_01e0, IL_01e7, IL_01e8, IL_01ec, IL_01f3, IL_01f4, IL_01f8, IL_01ff, IL_0200, IL_0204, IL_020b, IL_020c, IL_0210, IL_0217, IL_0218, IL_021c, IL_0223, IL_0224, IL_0228, IL_022f, IL_0230, IL_0234, IL_023b, IL_023c, IL_0240, IL_0247, IL_0248, IL_024c, IL_0253, IL_0254, IL_0258, IL_025f, IL_0260, IL_0264, IL_026b, IL_026c, IL_0270, IL_0277, IL_0278, IL_027c, IL_0283, IL_0284, IL_0288, IL_028f, IL_0290, IL_0294, IL_029b, IL_029c, IL_02a0, IL_02a7, IL_02a8, IL_02ac, IL_02b3, IL_02c0, IL_02c4, IL_02cb, IL_02cc, IL_02d0, IL_02d7, IL_02d8, IL_02dc, IL_02e3, IL_02e4, IL_02e8, IL_02ef, IL_02f0, IL_02f4, IL_02fb, IL_02fc, IL_0300, IL_0307, IL_0308, IL_030c, IL_0310, IL_0311, IL_032f, IL_0335, IL_033b, IL_0353, IL_0359, IL_035f, IL_0365, IL_036b, IL_0371, IL_038f, IL_039b, IL_03a1, IL_03a7, IL_03ad, IL_03b3, IL_03b9, IL_03bf, IL_03c5, IL_03cb, IL_03d1, IL_03d7, IL_03dd, IL_03e3, IL_03e9, IL_03ef, IL_03f5, IL_03fb, IL_0401, IL_040d, IL_0413, IL_0419, IL_041f, IL_0425, IL_042b
			//IL_0031: Expected O, but got I4
			//IL_003c: Expected I4, but got O
			//IL_0062: Expected I4, but got O
			//IL_0085: Expected I4, but got O
			//IL_00dd: Expected I4, but got O
			//IL_0188: Expected I4, but got O
			if (fieldNumber > 85)
			{
				if (fieldNumber > 110)
				{
					if (fieldNumber > 125)
					{
						if (fieldNumber == 130)
						{
							int num = 0;
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							conditions_ = num;
							conditionsCase_ = (ConditionsOneofCase)typeof(ConditionsList).TypeHandle;
						}
						else
						{
							while (fieldNumber != 135)
							{
							}
							if (value != null && value == null)
							{
								throw new InvalidCastException();
							}
							conditions_ = value;
							conditionsCase_ = (ConditionsOneofCase)typeof(ConditionsList).TypeHandle;
						}
					}
					else if (fieldNumber == 115)
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						conditions_ = value;
						conditionsCase_ = (ConditionsOneofCase)typeof(ConditionsList).TypeHandle;
					}
					else if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
				}
				else if (fieldNumber > 105)
				{
					if (fieldNumber == 106)
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						conditions_ = value;
						conditionsCase_ = (ConditionsOneofCase)typeof(ConditionsList).TypeHandle;
					}
					else
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						conditions_ = value;
					}
				}
				else if ((long)typeof(ConditionsList).TypeHandle <= 12)
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else if (fieldNumber > 65)
			{
				if (fieldNumber > 78)
				{
					if (fieldNumber == 80)
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						conditions_ = value;
						conditionsCase_ = (ConditionsOneofCase)typeof(ConditionsList).TypeHandle;
					}
					else
					{
						if (value != null && value == null)
						{
							throw new InvalidCastException();
						}
						conditions_ = value;
					}
				}
				else
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					conditions_ = value;
				}
			}
			else if ((long)typeof(ConditionsList).TypeHandle <= 36)
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005602")]
		[Cpp2IlInjected.Address(RVA = "0x2086590", Offset = "0x2084F90", VA = "0x182086590", Slot = "20")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0045: Expected O, but got I4
			if (fieldNumber > 85)
			{
				if (fieldNumber > 110)
				{
					if (fieldNumber > 125 && fieldNumber != 130 && fieldNumber != 135)
					{
						return;
					}
					while (fieldNumber == 115)
					{
					}
					if (fieldNumber > 5)
					{
						return;
					}
				}
				if (fieldNumber > 105)
				{
					while (true)
					{
						switch (fieldNumber)
						{
						case 106:
							continue;
						case 110:
							break;
						default:
							return;
						}
						break;
					}
				}
				if (fieldNumber == 105)
				{
					int num = 0;
					conditions_ = num;
					conditionsCase_ = (ConditionsOneofCase)num;
				}
				return;
			}
			if (fieldNumber > 65)
			{
				if (fieldNumber > 78)
				{
					while (fieldNumber == 80)
					{
					}
					while (fieldNumber != 85)
					{
					}
				}
				while (fieldNumber == 70)
				{
				}
				while (fieldNumber != 78)
				{
				}
			}
			if (fieldNumber > 20)
			{
				while (fieldNumber != 65)
				{
				}
			}
			while (fieldNumber == 5)
			{
			}
			while (true)
			{
				if (fieldNumber <= 10)
				{
					/*Error: Could not find block for branch target IL_007e*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005603")]
		[Cpp2IlInjected.Address(RVA = "0x2088F70", Offset = "0x2087970", VA = "0x182088F70", Slot = "21")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Conditions"))
			{
				ConditionsOneofCase conditionsOneofCase = conditionsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005604")]
		[Cpp2IlInjected.Address(RVA = "0x20867D0", Offset = "0x20851D0", VA = "0x1820867D0", Slot = "22")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Conditions"))
			{
				conditions_ = (conditionsCase_ = ConditionsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005605")]
		[Cpp2IlInjected.Address(RVA = "0x20905A0", Offset = "0x208EFA0", VA = "0x1820905A0")]
		static ConditionOneOf()
		{
			//IL_000a: Expected I4, but got O
			//IL_0015: Expected I4, but got O
			Func<ConditionOneOf> func = default(Func<ConditionOneOf>);
			DefaultData = (ConditionsOneofCase)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005606")]
		[Cpp2IlInjected.Address(RVA = "0x20869A0", Offset = "0x20853A0", VA = "0x1820869A0", Slot = "4")]
		unsafe bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_001c: Expected I4, but got O
			if ((object)typeof(ICondition).TypeHandle != null)
			{
				int num = 0;
				if ((long)num < (long)System.Runtime.CompilerServices.Unsafe.AsPointer(ref worldProfile))
				{
					num += num;
					num++;
				}
			}
			return (byte)(int)typeof(ICondition).TypeHandle != 0;
		}
	}
}
