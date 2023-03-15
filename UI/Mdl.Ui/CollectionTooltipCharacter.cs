using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200030F")]
	public class CollectionTooltipCharacter : CollectionTooltip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000ED8")]
		public CollectionTooltipElement Friendship;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000ED9")]
		public CollectionTooltipElement Profession;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000EDA")]
		public CollectionTooltipElement HangoutBuff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000EDB")]
		public RectTransform Elements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000EDC")]
		public GameObject Body;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000EDD")]
		public GameObject Part2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000EDE")]
		public Transform Part2ItemContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000EDF")]
		public GameObject LevelRewardItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000EE0")]
		public NPCLevelRewardItem CurrentLevelReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000EE1")]
		public bool IShowingPart2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000EE2")]
		public float FullWidth = 242f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000EE3")]
		public RectTransform ProgressBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000EE4")]
		public Color UnknowPrefredColor;

		[Cpp2IlInjected.Token(Token = "0x60013D1")]
		[Cpp2IlInjected.Address(RVA = "0x1148B80", Offset = "0x1147580", VA = "0x181148B80")]
		public void GotoPart1()
		{
			//Discarded unreachable code: IL_0024
			Body.SetActive(value: true);
			GameObject part = Part2;
			int active = 0;
			part.SetActive((byte)active != 0);
			IShowingPart2 = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60013D2")]
		[Cpp2IlInjected.Address(RVA = "0x1148BD0", Offset = "0x11475D0", VA = "0x181148BD0")]
		public void Toggle()
		{
			//Discarded unreachable code: IL_0041
			GameObject body = Body;
			bool iShowingPart = IShowingPart2;
			body.SetActive(iShowingPart);
			GameObject part = Part2;
			bool active = !IShowingPart2;
			part.SetActive(active);
			bool flag = (IShowingPart2 = !IShowingPart2);
		}

		[Cpp2IlInjected.Token(Token = "0x60013D3")]
		[Cpp2IlInjected.Address(RVA = "0x1148AF0", Offset = "0x11474F0", VA = "0x181148AF0")]
		public Transform GetLevelObject()
		{
			//Discarded unreachable code: IL_001b
			GameObject levelRewardItem = LevelRewardItem;
			Transform part2ItemContainer = Part2ItemContainer;
			return Object.Instantiate(levelRewardItem, part2ItemContainer).transform;
		}

		[Cpp2IlInjected.Token(Token = "0x60013D4")]
		[Cpp2IlInjected.Address(RVA = "0x1148C30", Offset = "0x1147630", VA = "0x181148C30")]
		public CollectionTooltipCharacter()
		{
		}
	}
}
