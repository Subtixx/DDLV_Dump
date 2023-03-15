using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000690")]
	public interface ISpawnHelper
	{
		[Cpp2IlInjected.Token(Token = "0x1700136C")]
		StepAmount AmountToSpawn
		{
			[Cpp2IlInjected.Token(Token = "0x6004ADB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700136D")]
		bool UseMultiSources
		{
			[Cpp2IlInjected.Token(Token = "0x6004ADC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700136E")]
		LocationSource LocationSource
		{
			[Cpp2IlInjected.Token(Token = "0x6004ADD")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700136F")]
		List<LocationSource> LocationSourceList
		{
			[Cpp2IlInjected.Token(Token = "0x6004ADE")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001370")]
		StepAmount SpawnRadius
		{
			[Cpp2IlInjected.Token(Token = "0x6004ADF")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001371")]
		ItemWithState RewardOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6004AE0")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001372")]
		bool SpawnDryFlower
		{
			[Cpp2IlInjected.Token(Token = "0x6004AE1")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
}
