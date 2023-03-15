using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001D6")]
	[ExecuteInEditMode]
	public class NineSliceBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public Texture2D Texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		public Rect TextureRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		private Rect _fullRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public Rect SliceBorder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private Rect _border;

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public Image Image
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x129C750", Offset = "0x129B150", VA = "0x18129C750")]
			get
			{
				return GetComponent<Image>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public RectTransform RectTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x129C790", Offset = "0x129B190", VA = "0x18129C790")]
			get
			{
				while (true)
				{
					if ((object)base.transform == null)
					{
						/*Error: Could not find block for branch target IL_0009*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CSprite_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CSprite_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C12")]
		[Cpp2IlInjected.Address(RVA = "0x129C120", Offset = "0x129AB20", VA = "0x18129C120")]
		public void RefreshSliceBorder(bool force = false)
		{
			//Discarded unreachable code: IL_0127
			//IL_0016: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			int num = 0;
			if (!force)
			{
				Texture2D texture = Texture;
				int num2 = 0;
				if (texture != (Object)num2)
				{
					Sprite sprite = GetComponent<Image>().m_Sprite;
					int num3 = 0;
					if (sprite == (Object)num3)
					{
						goto IL_0071;
					}
				}
				Texture2D texture2 = Texture;
				int num4 = 0;
				bool flag = default(bool);
				if (!(texture2 != (Object)num4) || !flag)
				{
					Texture2D texture3 = Texture;
					int num5 = 0;
					bool flag2 = default(bool);
					if (!(texture3 != (Object)num5) || !flag2)
					{
						return;
					}
				}
			}
			goto IL_0071;
			IL_0071:
			int width = Texture.width;
			if (num > num)
			{
				int width2 = Texture.width;
			}
			int height = Texture.height;
			if (num > num)
			{
				int height2 = Texture.height;
			}
			Rect textureRect = TextureRect;
			Sprite sprite2 = Sprite;
			_fullRect = textureRect;
			Rect rect = (_border = SliceBorder);
			int num6 = 0;
			if (sprite2 != (Object)num6 && Sprite.packed)
			{
				Sprite sprite3 = Sprite;
				Sprite sprite4 = Sprite;
			}
			Image component = GetComponent<Image>();
			Texture2D texture4 = Texture;
			int num7 = 0;
			Sprite sprite5 = default(Sprite);
			component.sprite = sprite5;
			Image component2 = GetComponent<Image>();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x129C6D0", Offset = "0x129B0D0", VA = "0x18129C6D0")]
		private void Start()
		{
			RefreshSliceBorder(force: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x129C6E0", Offset = "0x129B0E0", VA = "0x18129C6E0")]
		public NineSliceBase()
		{
		}
	}
}
