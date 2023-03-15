using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001D5")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(HorizontalLayoutGroup))]
	public class HorizontalThreeNineSlices : ThreeNineSlices
	{
		[Cpp2IlInjected.Token(Token = "0x17000258")]
		private bool _updateHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get
			{
				return _updateWidth;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0xAEA590", Offset = "0xAE8F90", VA = "0x180AEA590", Slot = "4")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00a6
			Transform transform = base.transform;
			Vector2 sizeDelta = Mid.RectTransform.sizeDelta;
			NineSliceBase top = Top;
			NineSliceBase bot = Bot;
			RectTransform rectTransform = Top.RectTransform;
			NineSliceBase top2 = Top;
			float ratio = Ratio;
			Vector2 sizeDelta2 = Top.RectTransform.sizeDelta;
			RectTransform rectTransform2 = Bot.RectTransform;
			NineSliceBase bot2 = Bot;
			Vector2 sizeDelta3 = Bot.RectTransform.sizeDelta;
			RectTransform rectTransform3 = Mid.RectTransform;
			Vector2 vector = (rectTransform3.sizeDelta = Mid.RectTransform.sizeDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0C")]
		[Cpp2IlInjected.Address(RVA = "0xAEA470", Offset = "0xAE8E70", VA = "0x180AEA470", Slot = "5")]
		public override void AdjustPivotRatio(float offsetX)
		{
			//Discarded unreachable code: IL_0038
			Transform transform = base.transform;
			Vector2 sizeDelta = Mid.RectTransform.sizeDelta;
			NineSliceBase top = Top;
			NineSliceBase bot = Bot;
			float num = (Ratio = Ratio);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0xAEA920", Offset = "0xAE9320", VA = "0x180AEA920")]
		public HorizontalThreeNineSlices()
		{
		}
	}
}
