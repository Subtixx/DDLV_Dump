using Cpp2IlInjected;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;

namespace Meta.Duties
{
	[Cpp2IlInjected.Token(Token = "0x20010AA")]
	public sealed class AchievementDataStringResolver : IResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40044A0")]
		private AchievementData _achievementData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40044A1")]
		private Localizator _localizator;

		[Cpp2IlInjected.Token(Token = "0x6008707")]
		[Cpp2IlInjected.Address(RVA = "0x539250", Offset = "0x537C50", VA = "0x180539250")]
		public AchievementDataStringResolver(AchievementData achievementData, Localizator localizator)
		{
			_achievementData = achievementData;
			_localizator = localizator;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008708")]
		[Cpp2IlInjected.Address(RVA = "0x1E230A0", Offset = "0x1E21AA0", VA = "0x181E230A0", Slot = "4")]
		public object Resolve(string key)
		{
			//Discarded unreachable code: IL_0017
			AchievementData achievementData = _achievementData;
			Localizator localizator = _localizator;
			return achievementData.ResolveKey(localizator, key);
		}
	}
}
