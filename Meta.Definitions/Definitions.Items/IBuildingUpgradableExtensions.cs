using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000685")]
	public static class IBuildingUpgradableExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6004AC8")]
		[Cpp2IlInjected.Address(RVA = "0x27B1B70", Offset = "0x27B0570", VA = "0x1827B1B70")]
		public static UpgradeData GetUpgradeData(this IBuildingUpgradable buildingUpgradable, int level, bool useLowerLast = false)
		{
			if (!useLowerLast)
			{
				Predicate<UpgradeData> predicate = (Predicate<UpgradeData>)(object)(Predicate<T>)delegate(UpgradeData upgradeInfo)
				{
					//Discarded unreachable code: IL_0011
					int num2 = level;
					return upgradeInfo.level_ == num2;
				};
				UpgradeData result = default(UpgradeData);
				return result;
			}
			Func<UpgradeData, bool> func = (Func<UpgradeData, bool>)(object)(Func<T, TResult>)delegate(UpgradeData upgradeInfo)
			{
				//Discarded unreachable code: IL_0014
				int num = level;
				return upgradeInfo.level_ <= num;
			};
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004AC9")]
		[Cpp2IlInjected.Address(RVA = "0x27B1590", Offset = "0x27AFF90", VA = "0x1827B1590")]
		public static void BuildingUpgradableValidation(this IBuildingUpgradable self, DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00dc
			int num = default(int);
			if (num <= 0)
			{
				return;
			}
			if (_003C_003Ec._003C_003E9__1_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(UpgradeData x)
				{
					string upgradeDialogueAddress_ = x.upgradeDialogueAddress_;
					throw new NullReferenceException();
				};
			}
			bool flag = default(bool);
			if (flag)
			{
				context.AddInvalidMemberError("Requires at least one Upgrade Dialogue Address.", "UpgradeInfo");
			}
			if (_003C_003Ec._003C_003E9__1_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.level_ < 1);
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				context.AddInvalidMemberError("Should contain one entry with Level 1+ (or be empty)", "UpgradeInfo");
			}
			flag = flag2;
			if (_003C_003Ec._003C_003E9__1_2 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(UpgradeData x)
				{
					int level_ = x.level_;
					throw new NullReferenceException();
				};
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				context.AddInvalidMemberError("Cannot have negative Level", "UpgradeInfo");
			}
			flag = flag3;
			if (_003C_003Ec._003C_003E9__1_3 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.level_);
			}
			IEnumerable<UpgradeData> enumerable = default(IEnumerable<UpgradeData>);
			int num2 = default(int);
			if (Enumerable.Count<int>(Enumerable.Distinct<int>((IEnumerable<>)enumerable)) != num2)
			{
				context.AddInvalidMemberError("Cannot contain entry with same Level", "UpgradeInfo");
			}
		}
	}
}
