using System;
using Cpp2IlInjected;
using PlayFab.AuthenticationModels;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000895")]
	public class SpriteImageTemplate : BehaviourTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032CB")]
		public float PixelsPerUnitMultiplier = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40032CC")]
		public uint ColorValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032CD")]
		public Image.Type Type = Image.Type.Tiled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40032CE")]
		public bool Maskable;

		[Cpp2IlInjected.Token(Token = "0x600361D")]
		[Cpp2IlInjected.Address(RVA = "0x15FFAE0", Offset = "0x15FE4E0", VA = "0x1815FFAE0")]
		public void Load(Image image)
		{
			//Discarded unreachable code: IL_005b
			//IL_0026: Invalid comparison between F4 and I4
			Load((Behaviour)image);
			uint colorValue = ColorValue;
			int num = 0;
			uint colorValue2 = ColorValue;
			float pixelsPerUnitMultiplier = PixelsPerUnitMultiplier;
			int num2 = 0;
			if (!(pixelsPerUnitMultiplier <= (float)num2))
			{
				image.pixelsPerUnitMultiplier = pixelsPerUnitMultiplier;
			}
			Image.Type type = Type;
			if (type != Image.Type.Tiled)
			{
				image.type = type;
			}
			bool maskable = Maskable;
			if (maskable)
			{
				image.maskable = maskable;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600361E")]
		[Cpp2IlInjected.Address(RVA = "0x15FFBB0", Offset = "0x15FE5B0", VA = "0x1815FFBB0")]
		public void Save(Image image)
		{
			//Discarded unreachable code: IL_0044
			Save((Behaviour)image);
			Color32 color = default(Color32);
			int num = (int)(ColorValue = (uint)color.rgba);
			Image.Type type = (Type = image.m_Type);
			float num2 = (PixelsPerUnitMultiplier = image.m_PixelsPerUnitMultiplier);
			bool flag = (Maskable = ((MaskableGraphic)image).m_Maskable);
		}

		[Cpp2IlInjected.Token(Token = "0x600361F")]
		[Cpp2IlInjected.Address(RVA = "0x15FFC60", Offset = "0x15FE660", VA = "0x1815FFC60")]
		public SpriteImageTemplate()
		{
			//IL_0014: Expected I4, but got I8
			((GetAPIKeysResponse)(object)this)._002Ector();
		}
	}
}
