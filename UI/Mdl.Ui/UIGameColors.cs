using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008B9")]
	[CreateAssetMenu]
	public class UIGameColors : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x20008BA")]
		public enum GameColorName
		{
			[Cpp2IlInjected.Token(Token = "0x4003436")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4003437")]
			Universe,
			[Cpp2IlInjected.Token(Token = "0x4003438")]
			Trait,
			[Cpp2IlInjected.Token(Token = "0x4003439")]
			Style,
			[Cpp2IlInjected.Token(Token = "0x400343A")]
			Complexity,
			[Cpp2IlInjected.Token(Token = "0x400343B")]
			Mood,
			[Cpp2IlInjected.Token(Token = "0x400343C")]
			Zone,
			[Cpp2IlInjected.Token(Token = "0x400343D")]
			OffWhite,
			[Cpp2IlInjected.Token(Token = "0x400343E")]
			DarkNavy,
			[Cpp2IlInjected.Token(Token = "0x400343F")]
			Insufficient,
			[Cpp2IlInjected.Token(Token = "0x4003440")]
			DisabledBtn,
			[Cpp2IlInjected.Token(Token = "0x4003441")]
			OffBlack,
			[Cpp2IlInjected.Token(Token = "0x4003442")]
			Gold,
			[Cpp2IlInjected.Token(Token = "0x4003443")]
			ForWhiteText1,
			[Cpp2IlInjected.Token(Token = "0x4003444")]
			ForWhiteText2,
			[Cpp2IlInjected.Token(Token = "0x4003445")]
			ForWhiteText3,
			[Cpp2IlInjected.Token(Token = "0x4003446")]
			ThresholdColor,
			[Cpp2IlInjected.Token(Token = "0x4003447")]
			HeaderQuestComplete,
			[Cpp2IlInjected.Token(Token = "0x4003448")]
			HeaderQuestNew,
			[Cpp2IlInjected.Token(Token = "0x4003449")]
			HeaderQuestOngoing,
			[Cpp2IlInjected.Token(Token = "0x400344A")]
			TrackerQuestNew,
			[Cpp2IlInjected.Token(Token = "0x400344B")]
			TrackerQuestProgress,
			[Cpp2IlInjected.Token(Token = "0x400344C")]
			AchievementNotifCompleted,
			[Cpp2IlInjected.Token(Token = "0x400344D")]
			GreyedOut,
			[Cpp2IlInjected.Token(Token = "0x400344E")]
			CheckMarkGrey,
			[Cpp2IlInjected.Token(Token = "0x400344F")]
			MainMenuFrame,
			[Cpp2IlInjected.Token(Token = "0x4003450")]
			LightPurple,
			[Cpp2IlInjected.Token(Token = "0x4003451")]
			DarkBrown
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20008BB")]
		public class GameColor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003452")]
			public GameColorName Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4003453")]
			public Color Color;

			[Cpp2IlInjected.Token(Token = "0x600371F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GameColor()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003434")]
		public List<GameColor> GameColors = (List<GameColor>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x600371D")]
		[Cpp2IlInjected.Address(RVA = "0xC961F0", Offset = "0xC94BF0", VA = "0x180C961F0")]
		public Color GetColor(GameColorName colorName)
		{
			//Discarded unreachable code: IL_0058
			//IL_0033: Expected O, but got I4
			int num = 0;
			Color black = Color.black;
			GameColorName colorName2 = default(GameColorName);
			Func<GameColor, bool> func = (Func<GameColor, bool>)(object)(Func<T, TResult>)delegate(GameColor x)
			{
				//Discarded unreachable code: IL_0011
				GameColorName gameColorName2 = colorName2;
				return x.Name == gameColorName2;
			};
			GameColor gameColor = default(GameColor);
			Color color = gameColor.Color;
			GameColorName gameColorName = colorName2;
			string text = ((Enum)gameColorName).ToString();
			colorName2 = gameColorName;
			Debug.Log("Failed to get: " + text);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600371E")]
		[Cpp2IlInjected.Address(RVA = "0xC963E0", Offset = "0xC94DE0", VA = "0x180C963E0")]
		public UIGameColors()
		{
		}
	}
}
