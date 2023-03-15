using System;
using System.Collections;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.U2D;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	[ExecuteInEditMode]
	public class ThreeNineSlices : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private Sprite _sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public SpriteAtlas SpriteAtlas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public Sprite Sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		[Space]
		public NineSliceBase Top;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public NineSliceBase Mid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public NineSliceBase Bot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		[SerializeField]
		protected bool _updateWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		[HideInInspector]
		public float Ratio = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x17EE3C0", Offset = "0x17ECDC0", VA = "0x1817EE3C0")]
		private void Start()
		{
			UpdateTexture();
			char nextChar = ((DecoderFallbackBuffer)(object)this).GetNextChar();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x17EE3F0", Offset = "0x17ECDF0", VA = "0x1817EE3F0")]
		public void UpdateTexture()
		{
			//Discarded unreachable code: IL_007b, IL_0081, IL_0093
			//IL_0028: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0075: Expected I4, but got I8
			int num = 0;
			SpriteAtlas spriteAtlas = SpriteAtlas;
			if ((object)spriteAtlas != null)
			{
				string text = Sprite.name;
				Sprite sprite = spriteAtlas.GetSprite(text);
			}
			_sprite = (Sprite)num;
			_texture = (Texture2D)num;
			int num2 = 0;
			if (!(spriteAtlas != (UnityEngine.Object)num2))
			{
				return;
			}
			IEnumerator enumerator = base.transform.GetEnumerator();
			NineSliceBase nineSliceBase = default(NineSliceBase);
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				ulong num6 = default(ulong);
				nineSliceBase.RefreshSliceBorder((byte)num6 != 0);
			}
			if ((object)nineSliceBase == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x17EE050", Offset = "0x17ECA50", VA = "0x1817EE050", Slot = "4")]
		public virtual void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00c2
			Transform transform = base.transform;
			Vector2 sizeDelta = Mid.RectTransform.sizeDelta;
			NineSliceBase top = Top;
			NineSliceBase bot = Bot;
			RectTransform rectTransform = Top.RectTransform;
			if (_updateWidth)
			{
			}
			Vector2 sizeDelta2 = Top.RectTransform.sizeDelta;
			NineSliceBase top2 = Top;
			rectTransform.sizeDelta = sizeDelta2;
			RectTransform rectTransform2 = Bot.RectTransform;
			if (_updateWidth)
			{
			}
			Vector2 sizeDelta3 = Bot.RectTransform.sizeDelta;
			NineSliceBase bot2 = Bot;
			rectTransform2.sizeDelta = sizeDelta3;
			if (_updateWidth)
			{
				RectTransform rectTransform3 = Mid.RectTransform;
				Vector2 sizeDelta4 = Mid.RectTransform.sizeDelta;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x17EDF30", Offset = "0x17EC930", VA = "0x1817EDF30", Slot = "5")]
		public virtual void AdjustPivotRatio(float offsetY)
		{
			//Discarded unreachable code: IL_0038
			Transform transform = base.transform;
			Vector2 sizeDelta = Mid.RectTransform.sizeDelta;
			NineSliceBase top = Top;
			NineSliceBase bot = Bot;
			float num = (Ratio = Ratio);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x17EE6F0", Offset = "0x17ED0F0", VA = "0x1817EE6F0")]
		public ThreeNineSlices()
		{
		}
	}
}
