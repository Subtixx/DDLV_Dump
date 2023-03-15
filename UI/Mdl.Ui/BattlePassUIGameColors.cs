using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200082F")]
	[CreateAssetMenu]
	public class BattlePassUIGameColors : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000830")]
		public enum GameColorName
		{
			[Cpp2IlInjected.Token(Token = "0x4003055")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4003056")]
			BattlePassDescText,
			[Cpp2IlInjected.Token(Token = "0x4003057")]
			BattlePassTimerText,
			[Cpp2IlInjected.Token(Token = "0x4003058")]
			BattlePassTaskIcon,
			[Cpp2IlInjected.Token(Token = "0x4003059")]
			BattlePassLockedPageBg,
			[Cpp2IlInjected.Token(Token = "0x400305A")]
			BattlePassUnlockedPageBg,
			[Cpp2IlInjected.Token(Token = "0x400305B")]
			BattlePassOngoingTaskTitle,
			[Cpp2IlInjected.Token(Token = "0x400305C")]
			BattlePassClaimableTaskTitle,
			[Cpp2IlInjected.Token(Token = "0x400305D")]
			BattlePassHighlightedTaskTitle,
			[Cpp2IlInjected.Token(Token = "0x400305E")]
			BattlePassProgressTask,
			[Cpp2IlInjected.Token(Token = "0x400305F")]
			BattlePassRewardName,
			[Cpp2IlInjected.Token(Token = "0x4003060")]
			BattlePassRewardPriceUnlocked,
			[Cpp2IlInjected.Token(Token = "0x4003061")]
			BattlePassRewardPriceLocked,
			[Cpp2IlInjected.Token(Token = "0x4003062")]
			BattlePassRewardPremiumLabelUnlocked,
			[Cpp2IlInjected.Token(Token = "0x4003063")]
			BattlePassRewardPremiumLabelLocked,
			[Cpp2IlInjected.Token(Token = "0x4003064")]
			BattlePassRewardAmountLabel,
			[Cpp2IlInjected.Token(Token = "0x4003065")]
			BattlePassRewardAmountBg,
			[Cpp2IlInjected.Token(Token = "0x4003066")]
			BattlePassPageLabelUnlocked,
			[Cpp2IlInjected.Token(Token = "0x4003067")]
			BattlePassPageLabelLocked,
			[Cpp2IlInjected.Token(Token = "0x4003068")]
			BattlePassSelectedPageLabelUnlocked,
			[Cpp2IlInjected.Token(Token = "0x4003069")]
			BattlePassSelectedPageLabelLocked,
			[Cpp2IlInjected.Token(Token = "0x400306A")]
			BattlePassPreviewLockedRewardBg,
			[Cpp2IlInjected.Token(Token = "0x400306B")]
			BattlePassPreviewLockedRewardLabel,
			[Cpp2IlInjected.Token(Token = "0x400306C")]
			BattlePassPreviewRewardName,
			[Cpp2IlInjected.Token(Token = "0x400306D")]
			BattlePassEndMessage,
			[Cpp2IlInjected.Token(Token = "0x400306E")]
			BattlePassEventHover,
			[Cpp2IlInjected.Token(Token = "0x400306F")]
			BattlePassPreviewCompletedRewardBg,
			[Cpp2IlInjected.Token(Token = "0x4003070")]
			BattlePassPreviewCompletedRewardLabel,
			[Cpp2IlInjected.Token(Token = "0x4003071")]
			BattlePassRewardUncollectableText,
			[Cpp2IlInjected.Token(Token = "0x4003072")]
			BattlePassSelectedPageBg,
			[Cpp2IlInjected.Token(Token = "0x4003073")]
			BattlePassNotifCollectText,
			[Cpp2IlInjected.Token(Token = "0x4003074")]
			BattlePassNotifTitleText,
			[Cpp2IlInjected.Token(Token = "0x4003075")]
			BattlePassRewardPriceSelected,
			[Cpp2IlInjected.Token(Token = "0x4003076")]
			BattlePassProgressTaskBg,
			[Cpp2IlInjected.Token(Token = "0x4003077")]
			BattlePassProgressTaskClaimable
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000831")]
		public class GameColor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003078")]
			public GameColorName Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4003079")]
			public Color Color;

			[Cpp2IlInjected.Token(Token = "0x6003414")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GameColor()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003053")]
		public List<GameColor> GameColors = (List<GameColor>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003412")]
		[Cpp2IlInjected.Address(RVA = "0xA62720", Offset = "0xA61120", VA = "0x180A62720")]
		public Color GetColor(GameColorName colorName)
		{
			Func<GameColor, bool> func = (Func<GameColor, bool>)(object)new Func<T, TResult>(new _003C_003Ec__DisplayClass3_0()._003CGetColor_003Eb__0);
			GameColor gameColor = default(GameColor);
			Color color = gameColor.Color;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003413")]
		[Cpp2IlInjected.Address(RVA = "0xA62820", Offset = "0xA61220", VA = "0x180A62820")]
		public BattlePassUIGameColors()
		{
		}
	}
}
