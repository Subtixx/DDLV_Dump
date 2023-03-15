using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf.Collections;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000662")]
	public interface IDialogueItemData : IItemData, IUpdateVersion
	{
		[Cpp2IlInjected.Token(Token = "0x17001337")]
		string DialogueAssetAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004A65")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001338")]
		Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004A66")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001339")]
		Item PreviousDiscussion
		{
			[Cpp2IlInjected.Token(Token = "0x6004A67")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700133A")]
		Season Season
		{
			[Cpp2IlInjected.Token(Token = "0x6004A68")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700133B")]
		string TimeOfDay
		{
			[Cpp2IlInjected.Token(Token = "0x6004A69")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700133C")]
		ScheduleType Schedule
		{
			[Cpp2IlInjected.Token(Token = "0x6004A6A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700133D")]
		CharacterLocation Location
		{
			[Cpp2IlInjected.Token(Token = "0x6004A6B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700133E")]
		bool SpecificWeather
		{
			[Cpp2IlInjected.Token(Token = "0x6004A6C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700133F")]
		RepeatedField<string> Weathers
		{
			[Cpp2IlInjected.Token(Token = "0x6004A6D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001340")]
		RepeatedField<int> NecessaryCharactersInVillage
		{
			[Cpp2IlInjected.Token(Token = "0x6004A6E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001341")]
		ConditionsList Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6004A6F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}
	}
}
