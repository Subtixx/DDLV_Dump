using Cpp2IlInjected;
using Gameloft.Localization.Core;
using Mdl.Systems;
using Meta.Duties;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000434")]
	public static class ResolveStringExtenstions
	{
		[Cpp2IlInjected.Token(Token = "0x6001B28")]
		[Cpp2IlInjected.Address(RVA = "0xE328D0", Offset = "0xE312D0", VA = "0x180E328D0")]
		public static string ResolveString(this DutySlot dutySlot, string locId)
		{
			//Discarded unreachable code: IL_002e
			if ((object)typeof(SystemRoot).TypeHandle == null)
			{
				Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
				RoyalDutySlotStringResolver resolver = dutySlot.StringResolver(_003CLocalizator_003Ek__BackingField);
				return LocalizationManager.FromStringID(locId, resolver);
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B29")]
		[Cpp2IlInjected.Address(RVA = "0xE327B0", Offset = "0xE311B0", VA = "0x180E327B0")]
		public static string ResolveString(this AchievementData achievementData, string locId)
		{
			//Discarded unreachable code: IL_002e
			if ((object)typeof(SystemRoot).TypeHandle == null)
			{
				Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
				AchievementDataStringResolver resolver = achievementData.StringResolver(_003CLocalizator_003Ek__BackingField);
				return LocalizationManager.FromStringID(locId, resolver);
			}
			return string.Empty;
		}
	}
}
