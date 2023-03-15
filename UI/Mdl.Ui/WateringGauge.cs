using System;
using Cpp2IlInjected;
using Definitions.Activities;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007E8")]
	public class WateringGauge : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E76")]
		[SerializeField]
		private SpriteAtlasImage _mcStateIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E77")]
		[SerializeField]
		private Image _mcProgressBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002E78")]
		[SerializeField]
		private Sprite _mcWateredSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002E79")]
		[SerializeField]
		private Sprite _mcDryedSprite;

		[Cpp2IlInjected.Token(Token = "0x1700071D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4002E7A")]
		public WateringState WateringState
		{
			[Cpp2IlInjected.Token(Token = "0x6003267")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003268")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6003269")]
		[Cpp2IlInjected.Address(RVA = "0x8E8EA0", Offset = "0x8E78A0", VA = "0x1808E8EA0")]
		internal unsafe void RefreshDisplay((WateringState wateringState, float ratio) p)
		{
			//Discarded unreachable code: IL_0134
			//IL_0007: Expected I4, but got O
			//IL_000e: Expected I4, but got O
			//IL_0036: Expected F4, but got I8
			//IL_0043: Expected I4, but got I8
			//IL_0080: Expected O, but got I4
			//IL_009a: Expected F4, but got I8
			//IL_00e8: Expected O, but got I4
			//IL_0101: Expected O, but got I4
			WateringState = (WateringState)p;
			WateringState wateringState = (WateringState)((ValueTuple<, >*)(&p))->Item1;
			if ((object)p != null)
			{
				if ((object)p != null)
				{
					if (wateringState != WateringState.Drying)
					{
						return;
					}
					Image mcProgressBar = _mcProgressBar;
					int num = 0;
					ulong num2 = default(ulong);
					_mcProgressBar.fillAmount = (long)num2;
					ulong num3 = default(ulong);
					_mcProgressBar.fillClockwise = (byte)num3 != 0;
					Image image = _mcStateIcon.Image;
					Sprite mcDryedSprite = _mcDryedSprite;
					SpriteAtlasImage mcStateIcon = _mcStateIcon;
					string text = mcDryedSprite.name;
				}
				Image mcProgressBar2 = _mcProgressBar;
				int num4 = 0;
				int num5 = 0;
				mcProgressBar2.color = (Color)num5;
				Image image2 = _mcStateIcon.Image;
				ulong num6 = default(ulong);
				_mcProgressBar.fillAmount = (long)num6;
				Image mcProgressBar3 = _mcProgressBar;
				int num7 = ((mcProgressBar3.fillClockwise = false) ? 1 : 0);
				Sprite mcWateredSprite = _mcWateredSprite;
				SpriteAtlasImage mcStateIcon2 = _mcStateIcon;
				string text3 = (mcStateIcon2.ImageAddress = mcWateredSprite.name);
			}
			else
			{
				Image mcProgressBar4 = _mcProgressBar;
				int num8 = 0;
				int num9 = 0;
				mcProgressBar4.color = (Color)num9;
				Image image3 = _mcStateIcon.Image;
				int num10 = 0;
				image3.color = (Color)num10;
				_mcProgressBar.fillAmount = 1f;
				Sprite mcWateredSprite2 = _mcWateredSprite;
				SpriteAtlasImage mcStateIcon3 = _mcStateIcon;
				string text5 = (mcStateIcon3.ImageAddress = mcWateredSprite2.name);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600326A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WateringGauge()
		{
		}
	}
}
